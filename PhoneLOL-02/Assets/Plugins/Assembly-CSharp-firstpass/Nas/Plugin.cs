using UnityEngine;

namespace Nas
{
	public class Plugin
	{
		private static Plugin _instance;

		private string _handlerName;

		private AndroidJavaClass pluginClass;

		public static Plugin Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Plugin();
				}
				return _instance;
			}
		}

		public Plugin()
		{
			pluginClass = new AndroidJavaClass("com.nas.unity.NasUnityPlugin");
		}

		public void init(bool testMode, string handlerName)
		{
			_handlerName = handlerName;
			pluginClass.CallStatic("init", testMode, _handlerName);
		}

		public void init(bool testMode, string userid, string handlerName)
		{
			_handlerName = handlerName;
			pluginClass.CallStatic("init", testMode, userid, _handlerName);
		}

		public void open(string userData)
		{
			pluginClass.CallStatic("open", userData);
		}

		public void open(string userData, int age, int sex)
		{
			pluginClass.CallStatic("open", userData, age, sex);
		}

		public void getUserPoint()
		{
			pluginClass.CallStatic("getUserPoint", _handlerName);
		}

		public void purchaseItem(string itemId)
		{
			pluginClass.CallStatic("purchaseItem", itemId, _handlerName);
		}

		public void purchaseItem(string itemId, int purchaseCount)
		{
			pluginClass.CallStatic("purchaseItem", itemId, purchaseCount, _handlerName);
		}
	}
}
