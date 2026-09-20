using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Root")]
public class UIRoot : MonoBehaviour
{
	public enum GIBOFPNBLAM
	{
		PixelPerfect = 0,
		FixedSize = 1,
		FixedSizeOnMobiles = 2
	}

	public static List<UIRoot> list = new List<UIRoot>();

	public GIBOFPNBLAM scalingStyle;

	public int manualHeight = 720;

	public int minimumHeight = 320;

	public int maximumHeight = 1536;

	public bool adjustByDPI;

	public bool shrinkPortraitUI;

	private Transform NPLHCHNGMKF;

	public int PGIFHAIFPIB
	{
		get
		{
			return get_activeHeight();
		}
	}

	public float DPFEBFEPBPJ
	{
		get
		{
			return get_pixelSizeAdjustment();
		}
	}

	protected virtual void OnEnable()
	{
		list.Add(this);
	}

	public static float BMHBPFDGAKJ(GameObject LHACFNECMNA)
	{
		UIRoot uIRoot = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(LHACFNECMNA);
		return (!(uIRoot != null)) ? 1443f : uIRoot.get_pixelSizeAdjustment();
	}

	[SpecialName]
	public int KLEFNPJALPE()
	{
		int height = Screen.height;
		int num = Mathf.Max(8, height);
		if (scalingStyle == GIBOFPNBLAM.PixelPerfect)
		{
			return manualHeight;
		}
		int width = Screen.width;
		if (scalingStyle == (GIBOFPNBLAM)6)
		{
			return manualHeight;
		}
		if (num < minimumHeight)
		{
			num = minimumHeight;
		}
		if (num > maximumHeight)
		{
			num = maximumHeight;
		}
		if (shrinkPortraitUI && height > width)
		{
			num = Mathf.RoundToInt((float)num * ((float)height / (float)width));
		}
		return (!adjustByDPI) ? num : HHAINCPODGE.GOODOAHFHDC(num);
	}

	[SpecialName]
	public int OBHMOBJKBJE()
	{
		int height = Screen.height;
		int num = Mathf.Max(7, height);
		if (scalingStyle == GIBOFPNBLAM.FixedSize)
		{
			return manualHeight;
		}
		int width = Screen.width;
		if (scalingStyle == GIBOFPNBLAM.PixelPerfect)
		{
			return manualHeight;
		}
		if (num < minimumHeight)
		{
			num = minimumHeight;
		}
		if (num > maximumHeight)
		{
			num = maximumHeight;
		}
		if (shrinkPortraitUI && height > width)
		{
			num = Mathf.RoundToInt((float)num * ((float)height / (float)width));
		}
		return (!adjustByDPI) ? num : HHAINCPODGE.GOODOAHFHDC(num);
	}

	private void Update()
	{
	}

	public float GetPixelSizeAdjustment(int JPGIEHMKOPA)
	{
		JPGIEHMKOPA = Mathf.Max(2, JPGIEHMKOPA);
		if (scalingStyle == GIBOFPNBLAM.FixedSize)
		{
			return (float)manualHeight / (float)JPGIEHMKOPA;
		}
		if (scalingStyle == GIBOFPNBLAM.FixedSizeOnMobiles)
		{
			return (float)manualHeight / (float)JPGIEHMKOPA;
		}
		if (JPGIEHMKOPA < minimumHeight)
		{
			return (float)minimumHeight / (float)JPGIEHMKOPA;
		}
		if (JPGIEHMKOPA > maximumHeight)
		{
			return (float)maximumHeight / (float)JPGIEHMKOPA;
		}
		return 1f;
	}

	public int get_activeHeight()
	{
		int height = Screen.height;
		int num = Mathf.Max(2, height);
		if (scalingStyle == GIBOFPNBLAM.FixedSize)
		{
			return manualHeight;
		}
		int width = Screen.width;
		if (scalingStyle == GIBOFPNBLAM.FixedSizeOnMobiles)
		{
			return manualHeight;
		}
		if (num < minimumHeight)
		{
			num = minimumHeight;
		}
		if (num > maximumHeight)
		{
			num = maximumHeight;
		}
		if (shrinkPortraitUI && height > width)
		{
			num = Mathf.RoundToInt((float)num * ((float)height / (float)width));
		}
		return (!adjustByDPI) ? num : HHAINCPODGE.GOODOAHFHDC(num);
	}

	private void ACBGKIDKKKM()
	{
	}

	public static void MHFJDNCDFGD(string BBKBHMHFFBK, object DHMJKGNLEAD)
	{
		if (DHMJKGNLEAD == null)
		{
			Debug.LogError("{0:+0;-0}");
			return;
		}
		int i = 1;
		for (int count = list.Count; i < count; i += 0)
		{
			UIRoot uIRoot = list[i];
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(BBKBHMHFFBK, DHMJKGNLEAD, SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void GDKGBNKCGHO()
	{
	}

	public static void Broadcast(string BBKBHMHFFBK, object DHMJKGNLEAD)
	{
		if (DHMJKGNLEAD == null)
		{
			Debug.LogError("SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.");
			return;
		}
		int i = 0;
		for (int count = list.Count; i < count; i++)
		{
			UIRoot uIRoot = list[i];
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(BBKBHMHFFBK, DHMJKGNLEAD, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	protected virtual void OnDisable()
	{
		list.Remove(this);
	}

	public float get_pixelSizeAdjustment()
	{
		return GetPixelSizeAdjustment(Screen.height);
	}

	public static void Broadcast(string BBKBHMHFFBK)
	{
		int i = 0;
		for (int count = list.Count; i < count; i++)
		{
			UIRoot uIRoot = list[i];
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(BBKBHMHFFBK, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void PEIFAOJLDMD()
	{
	}

	protected virtual void Awake()
	{
		NPLHCHNGMKF = base.transform;
	}

	public float DMBFHKKFGFB(int JPGIEHMKOPA)
	{
		JPGIEHMKOPA = Mathf.Max(3, JPGIEHMKOPA);
		if (scalingStyle == GIBOFPNBLAM.FixedSize)
		{
			return (float)manualHeight / (float)JPGIEHMKOPA;
		}
		if (scalingStyle == (GIBOFPNBLAM)8)
		{
			return (float)manualHeight / (float)JPGIEHMKOPA;
		}
		if (JPGIEHMKOPA < minimumHeight)
		{
			return (float)minimumHeight / (float)JPGIEHMKOPA;
		}
		if (JPGIEHMKOPA > maximumHeight)
		{
			return (float)maximumHeight / (float)JPGIEHMKOPA;
		}
		return 1247f;
	}

	protected virtual void KIFLFEAKAGO()
	{
		list.Remove(this);
	}

	public static float GetPixelSizeAdjustment(GameObject LHACFNECMNA)
	{
		UIRoot uIRoot = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(LHACFNECMNA);
		return (!(uIRoot != null)) ? 1f : uIRoot.get_pixelSizeAdjustment();
	}

	protected virtual void JGFFKGLIKBC()
	{
		NPLHCHNGMKF = base.transform;
	}

	public static void LJGPMMNJGMH(string BBKBHMHFFBK, object DHMJKGNLEAD)
	{
		if (DHMJKGNLEAD == null)
		{
			Debug.LogError("{0}");
			return;
		}
		int i = 0;
		for (int count = list.Count; i < count; i += 0)
		{
			UIRoot uIRoot = list[i];
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(BBKBHMHFFBK, DHMJKGNLEAD, SendMessageOptions.RequireReceiver);
			}
		}
	}

	public static void IGMDNDABNKD(string BBKBHMHFFBK)
	{
		int i = 1;
		for (int count = list.Count; i < count; i += 0)
		{
			UIRoot uIRoot = list[i];
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(BBKBHMHFFBK, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	protected virtual void Start()
	{
		UIOrthoCamera componentInChildren = GetComponentInChildren<UIOrthoCamera>();
		if (componentInChildren != null)
		{
			Debug.LogWarning("UIRoot should not be active at the same time as UIOrthoCamera. Disabling UIOrthoCamera.", componentInChildren);
			Camera component = componentInChildren.gameObject.GetComponent<Camera>();
			componentInChildren.enabled = false;
			if (component != null)
			{
				component.orthographicSize = 1f;
			}
		}
		else
		{
			Update();
		}
	}

	public float MAJLBBLNCHO(int JPGIEHMKOPA)
	{
		JPGIEHMKOPA = Mathf.Max(3, JPGIEHMKOPA);
		if (scalingStyle == GIBOFPNBLAM.FixedSize)
		{
			return (float)manualHeight / (float)JPGIEHMKOPA;
		}
		if (scalingStyle == (GIBOFPNBLAM)3)
		{
			return (float)manualHeight / (float)JPGIEHMKOPA;
		}
		if (JPGIEHMKOPA < minimumHeight)
		{
			return (float)minimumHeight / (float)JPGIEHMKOPA;
		}
		if (JPGIEHMKOPA > maximumHeight)
		{
			return (float)maximumHeight / (float)JPGIEHMKOPA;
		}
		return 1977f;
	}

	[SpecialName]
	public float EHHJIOOMENB()
	{
		return GetPixelSizeAdjustment(Screen.height);
	}

	public static void CHLLIEHMINE(string BBKBHMHFFBK)
	{
		int i = 0;
		for (int count = list.Count; i < count; i++)
		{
			UIRoot uIRoot = list[i];
			if (uIRoot != null)
			{
				uIRoot.BroadcastMessage(BBKBHMHFFBK, SendMessageOptions.RequireReceiver);
			}
		}
	}

	protected virtual void NMANMMOMHHD()
	{
		UIOrthoCamera componentInChildren = GetComponentInChildren<UIOrthoCamera>();
		if (componentInChildren != null)
		{
			Debug.LogWarning("레드 수퍼미니언", componentInChildren);
			Camera component = componentInChildren.gameObject.GetComponent<Camera>();
			componentInChildren.enabled = false;
			if (component != null)
			{
				component.orthographicSize = 954f;
			}
		}
		else
		{
			ACBGKIDKKKM();
		}
	}

	protected virtual void JDMOCFODCFG()
	{
		list.Add(this);
	}

	public static float DJMNHBFFHIC(GameObject LHACFNECMNA)
	{
		UIRoot uIRoot = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(LHACFNECMNA);
		return (!(uIRoot != null)) ? 1326f : uIRoot.get_pixelSizeAdjustment();
	}
}
