using System;
using GooglePlayGames.BasicApi.Multiplayer;
using GooglePlayGames.BasicApi.SavedGame;

namespace GooglePlayGames.BasicApi
{
	public interface IPlayGamesClient
	{
		void Authenticate(Action<bool> callback, bool silent);

		bool IsAuthenticated();

		void SignOut();

		string GetUserId();

		string GetUserDisplayName();

		string GetUserImageUrl();

		Achievement GetAchievement(string achievementId);

		void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

		void ShowAchievementsUI();

		void ShowLeaderboardUI(string leaderboardId);

		void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

		void LoadState(int slot, OnStateLoadedListener listener);

		void UpdateState(int slot, byte[] data, OnStateLoadedListener listener);

		IRealTimeMultiplayerClient GetRtmpClient();

		ITurnBasedMultiplayerClient GetTbmpClient();

		ISavedGameClient GetSavedGameClient();

		void RegisterInvitationDelegate(InvitationReceivedDelegate invitationDelegate);
	}
}
