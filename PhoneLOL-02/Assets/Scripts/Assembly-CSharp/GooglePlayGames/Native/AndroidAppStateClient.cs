using Logger = GooglePlayGames.OurUtils.Logger;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using UnityEngine;

namespace GooglePlayGames.Native
{
	internal class AndroidAppStateClient : AppStateClient
	{
		private class OnStateResultProxy : AndroidJavaProxy
		{
			private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;

			private readonly OnStateLoadedListener mListener;

			internal OnStateResultProxy(GooglePlayGames.Native.PInvoke.GameServices services, OnStateLoadedListener listener)
				: base("com.google.android.gms.common.api.ResultCallback")
			{
				mServices = Misc.CheckNotNull(services);
				mListener = listener;
			}

			private void OnStateConflict(int stateKey, string resolvedVersion, byte[] localData, byte[] serverData)
			{
				Logger.d("OnStateResultProxy.onStateConflict called, stateKey=" + stateKey + ", resolvedVersion=" + resolvedVersion);
				debugLogData("localData", localData);
				debugLogData("serverData", serverData);
				if (mListener != null)
				{
					Logger.d("OnStateResultProxy.onStateConflict invoking conflict callback.");
					PlayGamesHelperObject.RunOnGameThread(() =>
					{
						byte[] resolvedData = mListener.OnStateConflict(stateKey, localData, serverData);
						ResolveState(stateKey, resolvedVersion, resolvedData, mListener);
					});
				}
				else
				{
					Logger.w("No conflict callback specified! Cannot resolve cloud save conflict.");
				}
			}

			private void ResolveState(int slot, string resolvedVersion, byte[] resolvedData, OnStateLoadedListener listener)
			{
				Logger.d(string.Format("AndroidClient.ResolveState, slot={0}, ver={1}, data={2}", slot, resolvedVersion, resolvedData));
				using (AndroidJavaObject apiClient = GetApiClient(mServices))
				{
					CallAppState(apiClient, "resolve", new OnStateResultProxy(mServices, listener), slot, resolvedVersion, resolvedData);
				}
			}

			private void OnStateLoaded(int statusCode, int stateKey, byte[] localData)
			{
				Logger.d("OnStateResultProxy.onStateLoaded called, status " + statusCode + ", stateKey=" + stateKey);
				debugLogData("localData", localData);
				bool success = false;
				switch (statusCode)
				{
				case 0:
					Logger.d("Status is OK, so success.");
					success = true;
					break;
				case 4:
					Logger.d("Status is NO DATA (no network?), so it's a failure.");
					success = false;
					localData = null;
					break;
				case 3:
					Logger.d("Status is STALE DATA, so considering as success.");
					success = true;
					break;
				case 2002:
					Logger.d("Status is KEY NOT FOUND, which is a success, but with no data.");
					success = true;
					localData = null;
					break;
				default:
					Logger.e("Cloud load failed with status code " + statusCode);
					success = false;
					localData = null;
					break;
				}
				if (mListener != null)
				{
					Logger.d("OnStateResultProxy.onStateLoaded invoking load callback.");
					PlayGamesHelperObject.RunOnGameThread(() =>
					{
						mListener.OnStateLoaded(success, stateKey, localData);
					});
				}
				else
				{
					Logger.w("No load callback specified!");
				}
			}

			private void debugLogData(string tag, byte[] data)
			{
				Logger.d("   " + tag + ": " + Logger.describe(data));
			}

			public void onResult(AndroidJavaObject result)
			{
				Logger.d("OnStateResultProxy.onResult, result=" + result);
				int statusCode = GetStatusCode(result);
				Logger.d("OnStateResultProxy: status code is " + statusCode);
				if (result == null)
				{
					Logger.e("OnStateResultProxy: result is null.");
					return;
				}
				Logger.d("OnstateResultProxy: retrieving result objects...");
				AndroidJavaObject androidJavaObject = result.NullSafeCall("getLoadedResult");
				AndroidJavaObject androidJavaObject2 = result.NullSafeCall("getConflictResult");
				Logger.d("Got result objects.");
				Logger.d("loadedResult = " + androidJavaObject);
				Logger.d("conflictResult = " + androidJavaObject2);
				if (androidJavaObject2 != null)
				{
					Logger.d("OnStateResultProxy: processing conflict.");
					int stateKey = androidJavaObject2.Call<int>("getStateKey", new object[0]);
					string resolvedVersion = androidJavaObject2.Call<string>("getResolvedVersion", new object[0]);
					byte[] localData = ToByteArray(androidJavaObject2.NullSafeCall("getLocalData"));
					byte[] serverData = ToByteArray(androidJavaObject2.NullSafeCall("getServerData"));
					Logger.d("OnStateResultProxy: conflict args parsed, calling.");
					OnStateConflict(stateKey, resolvedVersion, localData, serverData);
				}
				else if (androidJavaObject != null)
				{
					Logger.d("OnStateResultProxy: processing normal load.");
					int stateKey2 = androidJavaObject.Call<int>("getStateKey", new object[0]);
					byte[] localData2 = ToByteArray(androidJavaObject.NullSafeCall("getLocalData"));
					Logger.d("OnStateResultProxy: loaded args parsed, calling.");
					OnStateLoaded(statusCode, stateKey2, localData2);
				}
				else
				{
					Logger.e("OnStateResultProxy: both loadedResult and conflictResult are null!");
				}
			}
		}

		private const int STATUS_OK = 0;

		private const int STATUS_STALE_DATA = 3;

		private const int STATUS_NO_DATA = 4;

		private const int STATUS_KEY_NOT_FOUND = 2002;

		private const int STATUS_CONFLICT = 2000;

		private const string ResultCallbackClassname = "com.google.android.gms.common.api.ResultCallback";

		private static AndroidJavaClass AppStateManager = new AndroidJavaClass("com.google.android.gms.appstate.AppStateManager");

		private readonly GooglePlayGames.Native.PInvoke.GameServices mServices;

		internal AndroidAppStateClient(GooglePlayGames.Native.PInvoke.GameServices services)
		{
			mServices = Misc.CheckNotNull(services);
		}

		private static AndroidJavaObject GetApiClient(GooglePlayGames.Native.PInvoke.GameServices services)
		{
			return JavaUtils.JavaObjectFromPointer(InternalHooks.InternalHooks_GetApiClient(services.AsHandle()));
		}

		public void LoadState(int slot, OnStateLoadedListener listener)
		{
			Logger.d("LoadState, slot=" + slot);
			using (AndroidJavaObject apiClient = GetApiClient(mServices))
			{
				CallAppState(apiClient, "load", new OnStateResultProxy(mServices, listener), slot);
			}
		}

		public void UpdateState(int slot, byte[] data, OnStateLoadedListener listener)
		{
			Logger.d("UpdateState, slot=" + slot);
			using (AndroidJavaObject androidJavaObject = GetApiClient(mServices))
			{
				AppStateManager.CallStatic("update", androidJavaObject, slot, data);
			}
			if (listener != null)
			{
				PlayGamesHelperObject.RunOnGameThread(() =>
				{
					listener.OnStateSaved(true, slot);
				});
			}
		}

		private static object[] PrependApiClient(AndroidJavaObject apiClient, params object[] args)
		{
			List<object> list = new List<object>();
			list.Add(apiClient);
			list.AddRange(args);
			return list.ToArray();
		}

		private static void CallAppState(AndroidJavaObject apiClient, string methodName, params object[] args)
		{
			AppStateManager.CallStatic(methodName, PrependApiClient(apiClient, args));
		}

		private static void CallAppState(AndroidJavaObject apiClient, string methodName, AndroidJavaProxy callbackProxy, params object[] args)
		{
			AndroidJavaObject androidJavaObject = AppStateManager.CallStatic<AndroidJavaObject>(methodName, PrependApiClient(apiClient, args));
			using (androidJavaObject)
			{
				androidJavaObject.Call("setResultCallback", callbackProxy);
			}
		}

		private static int GetStatusCode(AndroidJavaObject result)
		{
			if (result == null)
			{
				return -1;
			}
			AndroidJavaObject androidJavaObject = result.Call<AndroidJavaObject>("getStatus", new object[0]);
			return androidJavaObject.Call<int>("getStatusCode", new object[0]);
		}

		internal static byte[] ToByteArray(AndroidJavaObject javaByteArray)
		{
			if (javaByteArray == null)
			{
				return null;
			}
			return AndroidJNIHelper.ConvertFromJNIArray<byte[]>(javaByteArray.GetRawObject());
		}
	}
}
