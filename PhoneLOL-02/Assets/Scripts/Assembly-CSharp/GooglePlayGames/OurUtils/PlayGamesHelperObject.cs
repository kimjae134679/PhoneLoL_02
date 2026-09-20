using System;
using System.Collections.Generic;
using UnityEngine;

namespace GooglePlayGames.OurUtils
{
	public class PlayGamesHelperObject : MonoBehaviour
	{
		private static PlayGamesHelperObject instance = null;

		private static bool sIsDummy = false;

		private static List<Action> sQueue = new List<Action>();

		private static volatile bool sQueueEmpty = true;

		private static Action<bool> sPauseCallback = null;

		private static Action<bool> sFocusCallback = null;

		public static void CreateObject()
		{
			if (!(instance != null))
			{
				if (Application.isPlaying)
				{
					GameObject gameObject = new GameObject("PlayGames_QueueRunner");
					UnityEngine.Object.DontDestroyOnLoad(gameObject);
					instance = gameObject.AddComponent<PlayGamesHelperObject>();
				}
				else
				{
					instance = new PlayGamesHelperObject();
					sIsDummy = true;
				}
			}
		}

		private void Awake()
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		}

		private void OnDisable()
		{
			if (instance == this)
			{
				instance = null;
			}
		}

		public static void RunOnGameThread(Action action)
		{
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			if (sIsDummy)
			{
				return;
			}
			lock (sQueue)
			{
				sQueue.Add(action);
				sQueueEmpty = false;
			}
		}

		private void Update()
		{
			if (!sIsDummy && !sQueueEmpty)
			{
				List<Action> list = new List<Action>();
				lock (sQueue)
				{
					list.AddRange(sQueue);
					sQueue.Clear();
					sQueueEmpty = true;
				}
				list.ForEach((Action a) =>
				{
					a();
				});
			}
		}

		private void OnApplicationFocus(bool focused)
		{
			Logger.d("PlayGamesHelperObject.OnApplicationFocus " + focused);
			if (sFocusCallback != null)
			{
				sFocusCallback(focused);
			}
		}

		private void OnApplicationPause(bool paused)
		{
			Logger.d("PlayGamesHelperObject.OnApplicationPause " + paused);
			if (sPauseCallback != null)
			{
				sPauseCallback(paused);
			}
		}

		public static void SetFocusCallback(Action<bool> callback)
		{
			sFocusCallback = callback;
		}

		public static void SetPauseCallback(Action<bool> callback)
		{
			sPauseCallback = callback;
		}
	}
}
