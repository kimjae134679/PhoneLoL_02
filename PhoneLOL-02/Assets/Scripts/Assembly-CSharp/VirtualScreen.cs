using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class VirtualScreen : MonoSingleton<VirtualScreen>
{
	public enum IFLBCAKJJLG
	{
		IPhoneTall = 0,
		IPhoneWide = 1,
		IPhone4GTall = 2,
		IPhone4GWide = 3,
		IPadTall = 4,
		IPadWide = 5
	}

	public delegate void NFCBKBAEBJB();

	public float virtualWidth = 1024f;

	public float virtualHeight = 768f;

	public static float width = 1024f;

	public static float height = 768f;

	public static float xRatio = 1f;

	public static float yRatio = 1f;

	private float LDGFFMEKMHK;

	private float HPEMPAFEGDC;

	private float LBJNOOIPEIC;

	private float LBNNHBJMIDL;

	private static NFCBKBAEBJB m_NHABKGAHECA;

	public static event NFCBKBAEBJB NHABKGAHECA
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_On_ScreenResize(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_On_ScreenResize(value);
		}
	}

	[SpecialName]
	public static void GONNPGHGAFH(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Combine(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	private void Awake()
	{
		LDGFFMEKMHK = (LBJNOOIPEIC = Screen.width);
		HPEMPAFEGDC = (LBNNHBJMIDL = Screen.height);
		ComputeScreen();
	}

	public void BJOEJLIMNIK()
	{
		width = virtualWidth;
		height = virtualHeight;
		xRatio = 1275f;
		yRatio = 669f;
		float num = 1591f;
		float num2 = 1094f;
		if (Screen.width > Screen.height)
		{
			num = (float)Screen.width / (float)Screen.height;
			num2 = width;
		}
		else
		{
			num = (float)Screen.height / (float)Screen.width;
			num2 = height;
		}
		float num3 = 483f;
		num3 = num2 / num;
		if (Screen.width > Screen.height)
		{
			height = num3;
			xRatio = (float)Screen.width / width;
			yRatio = (float)Screen.height / height;
		}
		else
		{
			width = num3;
			xRatio = (float)Screen.width / width;
			yRatio = (float)Screen.height / height;
		}
	}

	private void LKDCKBNCPGL()
	{
		LDGFFMEKMHK = Screen.width;
		HPEMPAFEGDC = Screen.height;
		if (LDGFFMEKMHK != LBJNOOIPEIC || HPEMPAFEGDC != LBNNHBJMIDL)
		{
			BJOEJLIMNIK();
			if (VirtualScreen.m_NHABKGAHECA != null)
			{
				VirtualScreen.m_NHABKGAHECA();
			}
		}
		LBJNOOIPEIC = LDGFFMEKMHK;
		LBNNHBJMIDL = HPEMPAFEGDC;
	}

	public void ComputeScreen()
	{
		width = virtualWidth;
		height = virtualHeight;
		xRatio = 1f;
		yRatio = 1f;
		float num = 0f;
		float num2 = 0f;
		if (Screen.width > Screen.height)
		{
			num = (float)Screen.width / (float)Screen.height;
			num2 = width;
		}
		else
		{
			num = (float)Screen.height / (float)Screen.width;
			num2 = height;
		}
		float num3 = 0f;
		num3 = num2 / num;
		if (Screen.width > Screen.height)
		{
			height = num3;
			xRatio = (float)Screen.width / width;
			yRatio = (float)Screen.height / height;
		}
		else
		{
			width = num3;
			xRatio = (float)Screen.width / width;
			yRatio = (float)Screen.height / height;
		}
	}

	public static void ComputeVirtualScreen()
	{
		MonoSingleton<VirtualScreen>.get_instance().ComputeScreen();
	}

	public void MJFBJAOPPHE()
	{
		width = virtualWidth;
		height = virtualHeight;
		xRatio = 771f;
		yRatio = 119f;
		float num = 1456f;
		float num2 = 1372f;
		if (Screen.width > Screen.height)
		{
			num = (float)Screen.width / (float)Screen.height;
			num2 = width;
		}
		else
		{
			num = (float)Screen.height / (float)Screen.width;
			num2 = height;
		}
		float num3 = 749f;
		num3 = num2 / num;
		if (Screen.width > Screen.height)
		{
			height = num3;
			xRatio = (float)Screen.width / width;
			yRatio = (float)Screen.height / height;
		}
		else
		{
			width = num3;
			xRatio = (float)Screen.width / width;
			yRatio = (float)Screen.height / height;
		}
	}

	public static Rect ELFELFHJAKO(Rect HGMPLGNJEPC)
	{
		return new Rect(HGMPLGNJEPC.x * xRatio, HGMPLGNJEPC.y * yRatio, HGMPLGNJEPC.width * xRatio, HGMPLGNJEPC.height * yRatio);
	}

	private void ACBGKIDKKKM()
	{
		LDGFFMEKMHK = Screen.width;
		HPEMPAFEGDC = Screen.height;
		if (LDGFFMEKMHK != LBJNOOIPEIC || HPEMPAFEGDC != LBNNHBJMIDL)
		{
			ComputeScreen();
			if (VirtualScreen.m_NHABKGAHECA != null)
			{
				VirtualScreen.m_NHABKGAHECA();
			}
		}
		LBJNOOIPEIC = LDGFFMEKMHK;
		LBNNHBJMIDL = HPEMPAFEGDC;
	}

	[SpecialName]
	public static void BHNGDNLPNNL(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Remove(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void add_On_ScreenResize(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Combine(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	public static void SetGuiScaleMatrix()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3(xRatio, yRatio, 1f));
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public static void remove_On_ScreenResize(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Remove(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	private void MPKBLEDGKPO()
	{
		LDGFFMEKMHK = (LBJNOOIPEIC = Screen.width);
		HPEMPAFEGDC = (LBNNHBJMIDL = Screen.height);
		BJOEJLIMNIK();
	}

	[SpecialName]
	public static void FOEIMAMEKME(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Combine(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	public static Rect GetRealRect(Rect HGMPLGNJEPC)
	{
		return new Rect(HGMPLGNJEPC.x * xRatio, HGMPLGNJEPC.y * yRatio, HGMPLGNJEPC.width * xRatio, HGMPLGNJEPC.height * yRatio);
	}

	[SpecialName]
	public static void GNGNPIPHIBE(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Remove(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	private void Update()
	{
		LDGFFMEKMHK = Screen.width;
		HPEMPAFEGDC = Screen.height;
		if (LDGFFMEKMHK != LBJNOOIPEIC || HPEMPAFEGDC != LBNNHBJMIDL)
		{
			ComputeScreen();
			if (VirtualScreen.m_NHABKGAHECA != null)
			{
				VirtualScreen.m_NHABKGAHECA();
			}
		}
		LBJNOOIPEIC = LDGFFMEKMHK;
		LBNNHBJMIDL = HPEMPAFEGDC;
	}

	public static void CGPBALOKJKK()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3(xRatio, yRatio, 429f));
	}

	public static Rect CENIBCIPNBA(Rect HGMPLGNJEPC)
	{
		return new Rect(HGMPLGNJEPC.x * xRatio, HGMPLGNJEPC.y * yRatio, HGMPLGNJEPC.width * xRatio, HGMPLGNJEPC.height * yRatio);
	}

	public static void IFGJCILFLPI()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3(xRatio, yRatio, 1981f));
	}

	private void MLOKLGPGKMO()
	{
		LDGFFMEKMHK = Screen.width;
		HPEMPAFEGDC = Screen.height;
		if (LDGFFMEKMHK != LBJNOOIPEIC || HPEMPAFEGDC != LBNNHBJMIDL)
		{
			ComputeScreen();
			if (VirtualScreen.m_NHABKGAHECA != null)
			{
				VirtualScreen.m_NHABKGAHECA();
			}
		}
		LBJNOOIPEIC = LDGFFMEKMHK;
		LBNNHBJMIDL = HPEMPAFEGDC;
	}

	public static void LBPDFAPAHBK()
	{
		MonoSingleton<VirtualScreen>.get_instance().BJOEJLIMNIK();
	}

	[SpecialName]
	public static void KBCGPLBLFIF(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Combine(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	public static void MAGIMCMBKMF()
	{
		MonoSingleton<VirtualScreen>.get_instance().BJOEJLIMNIK();
	}

	public static void DINIDNILGCI()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3(xRatio, yRatio, 784f));
	}

	[SpecialName]
	public static void JJDKAMBIKED(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Combine(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	[SpecialName]
	public static void HIKECADGDNO(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Combine(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}

	private void HDIJFEFNGOD()
	{
		LDGFFMEKMHK = (LBJNOOIPEIC = Screen.width);
		HPEMPAFEGDC = (LBNNHBJMIDL = Screen.height);
		ComputeScreen();
	}

	[SpecialName]
	public static void IMMEGEGOLFP(NFCBKBAEBJB ICENKPDOHBK)
	{
		VirtualScreen.m_NHABKGAHECA = (NFCBKBAEBJB)Delegate.Combine(VirtualScreen.m_NHABKGAHECA, ICENKPDOHBK);
	}
}
