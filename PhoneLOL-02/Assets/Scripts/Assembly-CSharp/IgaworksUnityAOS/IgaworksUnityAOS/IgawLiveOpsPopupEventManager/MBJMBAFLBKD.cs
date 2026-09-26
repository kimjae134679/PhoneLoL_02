using UnityEngine;

namespace IgaworksUnityAOS.IgaworksUnityAOS.IgawLiveOpsPopupEventManager
{
	internal class MBJMBAFLBKD
	{
		private AndroidJavaObject ONPFAFPKLLF;

		public MBJMBAFLBKD(PAKAHKBCLCL PMNNPCHKNJN)
		{
			AndroidJavaClass androidJavaClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
			AndroidJavaObject androidJavaObject = androidJavaClass.GetStatic<AndroidJavaObject>("currentActivity");
			ONPFAFPKLLF = new AndroidJavaObject("com.igaworks.unity.plugin.IgawLiveOpsPopupEventManager", androidJavaObject, new GMLGKJGKDPC(PMNNPCHKNJN));
		}
	}
}
