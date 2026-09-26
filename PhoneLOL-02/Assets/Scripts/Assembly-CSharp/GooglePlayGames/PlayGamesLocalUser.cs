using System;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames
{
	public class PlayGamesLocalUser : PlayGamesUserProfile, IUserProfile, ILocalUser
	{
		private PlayGamesPlatform mPlatform;

		private WWW mAvatarUrl;

		private Texture2D mImage;

		public IUserProfile[] friends
		{
			get
			{
				return new IUserProfile[0];
			}
		}

		public bool authenticated
		{
			get
			{
				return mPlatform.IsAuthenticated();
			}
		}

		public bool underage
		{
			get
			{
				return true;
			}
		}

		public new string userName
		{
			get
			{
				return (!authenticated) ? string.Empty : mPlatform.GetUserDisplayName();
			}
		}

		public new string id
		{
			get
			{
				return (!authenticated) ? string.Empty : mPlatform.GetUserId();
			}
		}

		public new bool isFriend
		{
			get
			{
				return true;
			}
		}

		public new UserState state
		{
			get
			{
				return UserState.Online;
			}
		}

		public new Texture2D image
		{
			get
			{
				if (mImage == null)
				{
					mImage = LoadImage();
				}
				return mImage;
			}
		}

		internal PlayGamesLocalUser(PlayGamesPlatform plaf)
		{
			mPlatform = plaf;
			mAvatarUrl = null;
			mImage = null;
		}

		public void Authenticate(Action<bool, string> callback)
		{
			Authenticate(success => callback?.Invoke(success, success ? null : "Authentication failed"));
		}

		public void Authenticate(Action<bool> callback)
		{
			mPlatform.Authenticate(callback);
		}

		public void Authenticate(Action<bool> callback, bool silent)
		{
			mPlatform.Authenticate(callback, silent);
		}

		public void LoadFriends(Action<bool> callback)
		{
			if (callback != null)
			{
				callback(false);
			}
		}

		private Texture2D LoadImage()
		{
			string userImageUrl = mPlatform.GetUserImageUrl();
			if (userImageUrl != null)
			{
				if (mAvatarUrl == null)
				{
					mAvatarUrl = new WWW(userImageUrl);
				}
				if (mAvatarUrl.isDone)
				{
					return mAvatarUrl.texture;
				}
			}
			return null;
		}
	}
}
