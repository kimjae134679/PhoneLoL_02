using Logger = GooglePlayGames.OurUtils.Logger;
using System;
using System.Runtime.InteropServices;
using AOT;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.OurUtils;

namespace GooglePlayGames.Native.PInvoke
{
	internal static class Callbacks
	{
		internal enum Type
		{
			Permanent = 0,
			Temporary = 1
		}

		internal delegate void ShowUICallbackInternal(CommonErrorStatus.UIStatus status, IntPtr data);

		internal static readonly Action<CommonErrorStatus.UIStatus> NoopUICallback = (CommonErrorStatus.UIStatus status) =>
		{
			Logger.d("Received UI callback: " + status);
		};

		internal static IntPtr ToIntPtr<T>(Action<T> callback, Func<IntPtr, T> conversionFunction) where T : BaseReferenceHolder
		{
			Action<IntPtr> callback2 = (IntPtr result) =>
			{
				using (T obj = conversionFunction(result))
				{
					if (callback != null)
					{
						callback(obj);
					}
				}
			};
			return ToIntPtr(callback2);
		}

		internal static IntPtr ToIntPtr(Delegate callback)
		{
			if ((object)callback == null)
			{
				return IntPtr.Zero;
			}
			GCHandle value = GCHandle.Alloc(callback, GCHandleType.Pinned);
			return GCHandle.ToIntPtr(value);
		}

		internal static T IntPtrToTempCallback<T>(IntPtr handle) where T : class
		{
			return IntPtrToCallback<T>(handle, true);
		}

		private static T IntPtrToCallback<T>(IntPtr handle, bool unpinHandle) where T : class
		{
			if (PInvokeUtilities.IsNull(handle))
			{
				return (T)null;
			}
			GCHandle gCHandle = GCHandle.FromIntPtr(handle);
			try
			{
				return (T)gCHandle.Target;
			}
			catch (InvalidCastException ex)
			{
				Logger.e("GC Handle pointed to unexpected type: " + gCHandle.Target.ToString() + ". Expected " + typeof(T));
				throw ex;
			}
			finally
			{
				if (unpinHandle)
				{
					gCHandle.Free();
				}
			}
		}

		internal static T IntPtrToPermanentCallback<T>(IntPtr handle) where T : class
		{
			return IntPtrToCallback<T>(handle, false);
		}

		[AOT.MonoPInvokeCallback(typeof(ShowUICallbackInternal))]
		internal static void InternalShowUICallback(CommonErrorStatus.UIStatus status, IntPtr data)
		{
			Logger.d("Showing UI Internal callback: " + status);
			Action<CommonErrorStatus.UIStatus> action = IntPtrToTempCallback<Action<CommonErrorStatus.UIStatus>>(data);
			try
			{
				action(status);
			}
			catch (Exception ex)
			{
				Logger.e("Error encountered executing InternalShowAllUICallback. Smothering to avoid passing exception into Native: " + ex);
			}
		}

		internal static void PerformInternalCallback(string callbackName, Type callbackType, IntPtr response, IntPtr userData)
		{
			Logger.d("Entering internal callback for " + callbackName);
			Action<IntPtr> action = ((callbackType != Type.Permanent) ? IntPtrToTempCallback<Action<IntPtr>>(userData) : IntPtrToPermanentCallback<Action<IntPtr>>(userData));
			if (action == null)
			{
				return;
			}
			try
			{
				action(response);
			}
			catch (Exception ex)
			{
				Logger.e("Error encountered executing " + callbackName + ". Smothering to avoid passing exception into Native: " + ex);
			}
		}

		internal static Action<T> AsOnGameThreadCallback<T>(Action<T> toInvokeOnGameThread)
		{
			return (T result) =>
			{
				if (toInvokeOnGameThread != null)
				{
					PlayGamesHelperObject.RunOnGameThread(() =>
					{
						toInvokeOnGameThread(result);
					});
				}
			};
		}

		internal static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return (T1 result1, T2 result2) =>
			{
				if (toInvokeOnGameThread != null)
				{
					PlayGamesHelperObject.RunOnGameThread(() =>
					{
						toInvokeOnGameThread(result1, result2);
					});
				}
			};
		}
	}
}
