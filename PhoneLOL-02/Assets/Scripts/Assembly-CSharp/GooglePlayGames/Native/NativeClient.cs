using Logger = GooglePlayGames.OurUtils.Logger;
using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;
using GooglePlayGames.Native.Cwrapper;
using GooglePlayGames.Native.PInvoke;
using GooglePlayGames.OurUtils;
using UnityEngine;

namespace GooglePlayGames.Native
{
	public class NativeClient : IPlayGamesClient
	{
		private enum AuthState
		{
			Unauthenticated = 0,
			Authenticated = 1,
			SilentPending = 2
		}

		private const string BridgeActivityClass = "com.google.games.bridge.NativeBridgeActivity";

		private const string LaunchBridgeMethod = "launchBridgeIntent";

		private const string LaunchBridgeSignature = "(Landroid/app/Activity;Landroid/content/Intent;)V";

		private readonly object GameServicesLock = new object();

		private readonly object AuthStateLock = new object();

		private readonly PlayGamesClientConfiguration mConfiguration;

		private GooglePlayGames.Native.PInvoke.GameServices mServices;

		private volatile NativeTurnBasedMultiplayerClient mTurnBasedClient;

		private volatile NativeRealtimeMultiplayerClient mRealTimeClient;

		private volatile ISavedGameClient mSavedGameClient;

		private volatile AppStateClient mAppStateClient;

		private volatile Action<Invitation, bool> mInvitationDelegate;

		private volatile Dictionary<string, GooglePlayGames.BasicApi.Achievement> mAchievements;

		private volatile GooglePlayGames.BasicApi.Multiplayer.Player mUser;

		private volatile Action<bool> mPendingAuthCallbacks;

		private volatile Action<bool> mSilentAuthCallbacks;

		private volatile AuthState mAuthState;

		private volatile uint mAuthGeneration;

		private volatile bool mSilentAuthFailed;

		public NativeClient(PlayGamesClientConfiguration configuration)
		{
			PlayGamesHelperObject.CreateObject();
			mConfiguration = Misc.CheckNotNull(configuration);
		}

		private GooglePlayGames.Native.PInvoke.GameServices GameServices()
		{
			lock (GameServicesLock)
			{
				return mServices;
			}
		}

		public void Authenticate(Action<bool> callback, bool silent)
		{
			lock (AuthStateLock)
			{
				if (mAuthState == AuthState.Authenticated)
				{
					InvokeCallbackOnGameThread(callback, true);
					return;
				}
				if (mSilentAuthFailed && silent)
				{
					InvokeCallbackOnGameThread(callback, false);
					return;
				}
				if (callback != null)
				{
					if (silent)
					{
						mSilentAuthCallbacks = (Action<bool>)Delegate.Combine(mSilentAuthCallbacks, callback);
					}
					else
					{
						mPendingAuthCallbacks = (Action<bool>)Delegate.Combine(mPendingAuthCallbacks, callback);
					}
				}
			}
			InitializeGameServices();
			if (!silent)
			{
				GameServices().StartAuthorizationUI();
			}
		}

		private static Action<bool> AsOnGameThreadCallback(Action<bool> callback)
		{
			if (callback == null)
			{
				return delegate
				{
				};
			}
			return (bool result) =>
			{
				InvokeCallbackOnGameThread(callback, result);
			};
		}

		private static void InvokeCallbackOnGameThread(Action<bool> callback, bool success)
		{
			if (callback != null)
			{
				PlayGamesHelperObject.RunOnGameThread(() =>
				{
					Logger.d("Invoking user callback on game thread");
					callback(success);
				});
			}
		}

		private void InitializeGameServices()
		{
			lock (GameServicesLock)
			{
				if (mServices != null)
				{
					return;
				}
				using (GameServicesBuilder gameServicesBuilder = GameServicesBuilder.Create())
				{
					using (PlatformConfiguration configRef = CreatePlatformConfiguration(gameServicesBuilder))
					{
						RegisterInvitationDelegate(mConfiguration.InvitationDelegate);
						gameServicesBuilder.SetOnAuthFinishedCallback(HandleAuthTransition);
						gameServicesBuilder.SetOnTurnBasedMatchEventCallback((GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string matchId, NativeTurnBasedMatch match) =>
						{
							mTurnBasedClient.HandleMatchEvent(eventType, matchId, match);
						});
						gameServicesBuilder.SetOnMultiplayerInvitationEventCallback(HandleInvitation);
						if (mConfiguration.EnableSavedGames)
						{
							gameServicesBuilder.EnableSnapshots();
						}
						mServices = gameServicesBuilder.Build(configRef);
						mTurnBasedClient = new NativeTurnBasedMultiplayerClient(this, new TurnBasedManager(mServices));
						mTurnBasedClient.RegisterMatchDelegate(mConfiguration.MatchDelegate);
						mRealTimeClient = new NativeRealtimeMultiplayerClient(this, new RealtimeManager(mServices));
						if (mConfiguration.EnableSavedGames)
						{
							mSavedGameClient = new NativeSavedGameClient(new GooglePlayGames.Native.PInvoke.SnapshotManager(mServices));
						}
						else
						{
							mSavedGameClient = new UnsupportedSavedGamesClient("You must enable saved games before it can be used. See PlayGamesClientConfiguration.Builder.EnableSavedGames.");
						}
						mAppStateClient = CreateAppStateClient();
						mAuthState = AuthState.SilentPending;
					}
				}
			}
		}

		private AppStateClient CreateAppStateClient()
		{
			if (mConfiguration.EnableDeprecatedCloudSave)
			{
				return new AndroidAppStateClient(mServices);
			}
			return new UnsupportedAppStateClient("You must explicitly enable cloud save - see PlayGamesClientConfiguration.Builder.EnableDeprecatedCloudSave.");
		}

		internal void HandleInvitation(GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent eventType, string invitationId, GooglePlayGames.Native.PInvoke.MultiplayerInvitation invitation)
		{
			Action<Invitation, bool> action = mInvitationDelegate;
			if (action == null)
			{
				Logger.d(string.Concat("Received ", eventType, " for invitation ", invitationId, " but no handler was registered."));
			}
			else if (eventType == GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent.REMOVED)
			{
				Logger.d("Ignoring REMOVED for invitation " + invitationId);
			}
			else
			{
				bool arg = eventType == GooglePlayGames.Native.Cwrapper.Types.MultiplayerEvent.UPDATED_FROM_APP_LAUNCH;
				action(invitation.AsInvitation(), arg);
			}
		}

		internal AndroidJavaObject GetActivity()
		{
			using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
			{
				return androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			}
		}

		private void LaunchBridgeIntent(IntPtr bridgedIntent)
		{
			object[] args = new object[2];
			jvalue[] array = AndroidJNIHelper.CreateJNIArgArray(args);
			try
			{
				using (AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.google.games.bridge.NativeBridgeActivity"))
				{
					using (AndroidJavaObject androidJavaObject = GetActivity())
					{
						IntPtr staticMethodID = AndroidJNI.GetStaticMethodID(androidJavaClass.GetRawClass(), "launchBridgeIntent", "(Landroid/app/Activity;Landroid/content/Intent;)V");
						array[0].l = androidJavaObject.GetRawObject();
						array[1].l = bridgedIntent;
						AndroidJNI.CallStaticVoidMethod(androidJavaClass.GetRawClass(), staticMethodID, array);
					}
				}
			}
			finally
			{
				AndroidJNIHelper.DeleteJNIArgArray(args, array);
			}
		}

		private PlatformConfiguration CreatePlatformConfiguration(GameServicesBuilder builder)
		{
			GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration androidPlatformConfiguration = GooglePlayGames.Native.PInvoke.AndroidPlatformConfiguration.Create();
			androidPlatformConfiguration.EnableAppState();
			using (AndroidJavaObject androidJavaObject = GetActivity())
			{
				androidPlatformConfiguration.SetActivity(androidJavaObject.GetRawObject());
				androidPlatformConfiguration.SetOptionalIntentHandlerForUI((IntPtr intent) =>
				{
					IntPtr intentRef = AndroidJNI.NewGlobalRef(intent);
					PlayGamesHelperObject.RunOnGameThread(() =>
					{
						try
						{
							LaunchBridgeIntent(intentRef);
						}
						finally
						{
							AndroidJNI.DeleteGlobalRef(intentRef);
						}
					});
				});
				return androidPlatformConfiguration;
			}
		}

		public bool IsAuthenticated()
		{
			lock (AuthStateLock)
			{
				return mAuthState == AuthState.Authenticated;
			}
		}

		private void PopulateAchievements(uint authGeneration, GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse response)
		{
			if (authGeneration != mAuthGeneration)
			{
				Logger.d("Received achievement callback after signout occurred, ignoring");
				return;
			}
			Logger.d("Populating Achievements");
			lock (AuthStateLock)
			{
				if (response.Status() != CommonErrorStatus.ResponseStatus.VALID && response.Status() != CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
				{
					Logger.e("Error retrieving achievements - check the log for more information. Failing signin.");
					Action<bool> action = mPendingAuthCallbacks;
					mPendingAuthCallbacks = null;
					if (action != null)
					{
						InvokeCallbackOnGameThread(action, false);
					}
					SignOut();
					return;
				}
				Dictionary<string, GooglePlayGames.BasicApi.Achievement> dictionary = new Dictionary<string, GooglePlayGames.BasicApi.Achievement>();
				foreach (NativeAchievement item in response)
				{
					using (item)
					{
						dictionary[item.Id()] = item.AsAchievement();
					}
				}
				mAchievements = dictionary;
			}
			Logger.d("Maybe finish for Achievements");
			MaybeFinishAuthentication();
		}

		private void MaybeFinishAuthentication()
		{
			Action<bool> action = null;
			lock (AuthStateLock)
			{
				if (mUser == null || mAchievements == null)
				{
					Logger.d(string.Concat("Auth not finished. User=", mUser, " achievements=", mAchievements));
					return;
				}
				Logger.d("Auth finished. Proceeding.");
				action = mPendingAuthCallbacks;
				mPendingAuthCallbacks = null;
				mAuthState = AuthState.Authenticated;
			}
			if (action != null)
			{
				Logger.d("Invoking Callbacks: " + action);
				InvokeCallbackOnGameThread(action, true);
			}
		}

		private void PopulateUser(uint authGeneration, PlayerManager.FetchSelfResponse response)
		{
			Logger.d("Populating User");
			if (authGeneration != mAuthGeneration)
			{
				Logger.d("Received user callback after signout occurred, ignoring");
				return;
			}
			lock (AuthStateLock)
			{
				if (response.Status() != CommonErrorStatus.ResponseStatus.VALID && response.Status() != CommonErrorStatus.ResponseStatus.VALID_BUT_STALE)
				{
					Logger.e("Error retrieving user, signing out");
					Action<bool> action = mPendingAuthCallbacks;
					mPendingAuthCallbacks = null;
					if (action != null)
					{
						InvokeCallbackOnGameThread(action, false);
					}
					SignOut();
					return;
				}
				mUser = response.Self().AsPlayer();
			}
			Logger.d("Found User: " + mUser);
			Logger.d("Maybe finish for User");
			MaybeFinishAuthentication();
		}

		private void HandleAuthTransition(GooglePlayGames.Native.Cwrapper.Types.AuthOperation operation, CommonErrorStatus.AuthStatus status)
		{
			Logger.d(string.Concat("Starting Auth Transition. Op: ", operation, " status: ", status));
			lock (AuthStateLock)
			{
				switch (operation)
				{
				case GooglePlayGames.Native.Cwrapper.Types.AuthOperation.SIGN_IN:
					if (status == CommonErrorStatus.AuthStatus.VALID)
					{
						if (mSilentAuthCallbacks != null)
						{
							mPendingAuthCallbacks = (Action<bool>)Delegate.Combine(mPendingAuthCallbacks, mSilentAuthCallbacks);
							mSilentAuthCallbacks = null;
						}
						uint currentAuthGeneration = mAuthGeneration;
						mServices.AchievementManager().FetchAll((GooglePlayGames.Native.PInvoke.AchievementManager.FetchAllResponse results) =>
						{
							PopulateAchievements(currentAuthGeneration, results);
						});
						mServices.PlayerManager().FetchSelf((PlayerManager.FetchSelfResponse results) =>
						{
							PopulateUser(currentAuthGeneration, results);
						});
					}
					else if (mAuthState == AuthState.SilentPending)
					{
						mSilentAuthFailed = true;
						mAuthState = AuthState.Unauthenticated;
						Action<bool> callback = mSilentAuthCallbacks;
						mSilentAuthCallbacks = null;
						InvokeCallbackOnGameThread(callback, false);
						if (mPendingAuthCallbacks != null)
						{
							GameServices().StartAuthorizationUI();
						}
					}
					else
					{
						Action<bool> callback2 = mPendingAuthCallbacks;
						mPendingAuthCallbacks = null;
						InvokeCallbackOnGameThread(callback2, false);
					}
					break;
				case GooglePlayGames.Native.Cwrapper.Types.AuthOperation.SIGN_OUT:
					mAuthState = AuthState.Unauthenticated;
					break;
				default:
					Logger.e("Unknown AuthOperation " + operation);
					break;
				}
			}
		}

		private void ToUnauthenticated()
		{
			lock (AuthStateLock)
			{
				mUser = null;
				mAchievements = null;
				mAuthState = AuthState.Unauthenticated;
				mAuthGeneration++;
			}
		}

		public void SignOut()
		{
			ToUnauthenticated();
			if (GameServices() != null)
			{
				GameServices().SignOut();
			}
		}

		public string GetUserId()
		{
			if (mUser == null)
			{
				return null;
			}
			return mUser.PlayerId;
		}

		public string GetUserDisplayName()
		{
			if (mUser == null)
			{
				return null;
			}
			return mUser.DisplayName;
		}

		public string GetUserImageUrl()
		{
			if (mUser == null)
			{
				return null;
			}
			return mUser.AvatarURL;
		}

		public GooglePlayGames.BasicApi.Achievement GetAchievement(string achId)
		{
			if (mAchievements == null || !mAchievements.ContainsKey(achId))
			{
				return null;
			}
			return mAchievements[achId];
		}

		public void UnlockAchievement(string achId, Action<bool> callback)
		{
			UpdateAchievement("Unlock", achId, callback, (GooglePlayGames.BasicApi.Achievement a) => a.IsUnlocked, (GooglePlayGames.BasicApi.Achievement a) =>
			{
				a.IsUnlocked = true;
				GameServices().AchievementManager().Unlock(achId);
			});
		}

		public void RevealAchievement(string achId, Action<bool> callback)
		{
			UpdateAchievement("Reveal", achId, callback, (GooglePlayGames.BasicApi.Achievement a) => a.IsRevealed, (GooglePlayGames.BasicApi.Achievement a) =>
			{
				a.IsRevealed = true;
				GameServices().AchievementManager().Reveal(achId);
			});
		}

		private void UpdateAchievement(string updateType, string achId, Action<bool> callback, Predicate<GooglePlayGames.BasicApi.Achievement> alreadyDone, Action<GooglePlayGames.BasicApi.Achievement> updateAchievment)
		{
			callback = AsOnGameThreadCallback(callback);
			Misc.CheckNotNull(achId);
			InitializeGameServices();
			GooglePlayGames.BasicApi.Achievement achievement = GetAchievement(achId);
			if (achievement == null)
			{
				Logger.d("Could not " + updateType + ", no achievement with ID " + achId);
				callback(false);
			}
			else if (alreadyDone(achievement))
			{
				Logger.d("Did not need to perform " + updateType + ": on achievement " + achId);
				callback(true);
			}
			else
			{
				Logger.d("Performing " + updateType + " on " + achId);
				updateAchievment(achievement);
				callback(true);
			}
		}

		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
			Misc.CheckNotNull(achId);
			callback = AsOnGameThreadCallback(callback);
			InitializeGameServices();
			GooglePlayGames.BasicApi.Achievement achievement = GetAchievement(achId);
			if (achievement == null)
			{
				Logger.e("Could not increment, no achievement with ID " + achId);
				callback(false);
			}
			else if (!achievement.IsIncremental)
			{
				Logger.e("Could not increment, achievement with ID " + achId + " was not incremental");
				callback(false);
			}
			else if (steps < 0)
			{
				Logger.e("Attempted to increment by negative steps");
				callback(false);
			}
			else
			{
				GameServices().AchievementManager().Increment(achId, Convert.ToUInt32(steps));
				callback(true);
			}
		}

		public void ShowAchievementsUI()
		{
			if (IsAuthenticated())
			{
				GameServices().AchievementManager().ShowAllUI(Callbacks.NoopUICallback);
			}
		}

		public void ShowLeaderboardUI(string leaderboardId)
		{
			if (IsAuthenticated())
			{
				if (leaderboardId == null)
				{
					GameServices().LeaderboardManager().ShowAllUI(Callbacks.NoopUICallback);
				}
				else
				{
					GameServices().LeaderboardManager().ShowUI(leaderboardId, Callbacks.NoopUICallback);
				}
			}
		}

		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
			callback = AsOnGameThreadCallback(callback);
			if (!IsAuthenticated())
			{
				callback(false);
			}
			InitializeGameServices();
			if (leaderboardId == null)
			{
				throw new ArgumentNullException("Leaderboard ID was null");
			}
			GameServices().LeaderboardManager().SubmitScore(leaderboardId, score);
			callback(true);
		}

		public void LoadState(int slot, OnStateLoadedListener listener)
		{
			Misc.CheckNotNull(listener);
			lock (GameServicesLock)
			{
				if (mAuthState != AuthState.Authenticated)
				{
					Logger.e("You can only call LoadState after the user has successfully logged in");
					listener.OnStateLoaded(false, slot, null);
				}
				mAppStateClient.LoadState(slot, listener);
			}
		}

		public void UpdateState(int slot, byte[] data, OnStateLoadedListener listener)
		{
			Misc.CheckNotNull(listener);
			lock (GameServicesLock)
			{
				if (mAuthState != AuthState.Authenticated)
				{
					Logger.e("You can only call UpdateState after the user has successfully logged in");
					listener.OnStateSaved(false, slot);
				}
				mAppStateClient.UpdateState(slot, data, listener);
			}
		}

		public IRealTimeMultiplayerClient GetRtmpClient()
		{
			if (!IsAuthenticated())
			{
				return null;
			}
			lock (GameServicesLock)
			{
				return mRealTimeClient;
			}
		}

		public ITurnBasedMultiplayerClient GetTbmpClient()
		{
			lock (GameServicesLock)
			{
				return mTurnBasedClient;
			}
		}

		public ISavedGameClient GetSavedGameClient()
		{
			lock (GameServicesLock)
			{
				return mSavedGameClient;
			}
		}

		public void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate)
		{
			if (invitationDelegate == null)
			{
				mInvitationDelegate = null;
				return;
			}
			mInvitationDelegate = Callbacks.AsOnGameThreadCallback((Invitation invitation, bool autoAccept) =>
			{
				invitationDelegate(invitation, autoAccept);
			});
		}
	}
}
