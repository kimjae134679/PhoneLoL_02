using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Debug")]
public class NGUIDebug : MonoBehaviour
{
	private static bool PKNHHJDNLNB = false;

	private static List<string> FDCFCIFBBKF = new List<string>();

	private static NGUIDebug IDCMLMDLLPB = null;

	public static bool EHHHKOJJBPE
	{
		get
		{
			return get_debugRaycast();
		}
		set
		{
			set_debugRaycast(value);
		}
	}

	public static void Log(params object[] LGBOIDOAHEN)
	{
		string text = string.Empty;
		for (int i = 0; i < LGBOIDOAHEN.Length; i++)
		{
			text = ((i != 0) ? (text + ", " + LGBOIDOAHEN[i].ToString()) : (text + LGBOIDOAHEN[i].ToString()));
		}
		JONCGPFBBNO(text);
	}

	[SpecialName]
	public static void KBMCJPLBGJN(bool ICENKPDOHBK)
	{
		if (Application.isPlaying)
		{
			PKNHHJDNLNB = ICENKPDOHBK;
			if (ICENKPDOHBK)
			{
				KFCOODDANEH();
			}
		}
	}

	public static void DrawBounds(Bounds GMMDCPLBFJL)
	{
		Vector3 center = GMMDCPLBFJL.center;
		Vector3 vector = GMMDCPLBFJL.center - GMMDCPLBFJL.extents;
		Vector3 vector2 = GMMDCPLBFJL.center + GMMDCPLBFJL.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	private void BOAGKNOJJOJ()
	{
		if (!PKNHHJDNLNB)
		{
			PKNHHJDNLNB = true;
			GameObject obj = new GameObject("_NGUI Debug");
			obj.AddComponent<NGUIDebug>();
			Object.DontDestroyOnLoad(obj);
			Object.Destroy(obj, 10f);
		}
	}

	public static void IJKNEHPNIMC(Bounds GMMDCPLBFJL)
	{
		Vector3 center = GMMDCPLBFJL.center;
		Vector3 vector = GMMDCPLBFJL.center - GMMDCPLBFJL.extents;
		Vector3 vector2 = GMMDCPLBFJL.center + GMMDCPLBFJL.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	public static void KHGMGFFCHPP()
	{
		if (IDCMLMDLLPB == null)
		{
			GameObject gameObject = new GameObject("open");
			IDCMLMDLLPB = gameObject.AddComponent<NGUIDebug>();
			Object.DontDestroyOnLoad(gameObject);
		}
	}

	public static void EANPCIGJKBH(object[] LGBOIDOAHEN)
	{
		string text = string.Empty;
		for (int i = 0; i < LGBOIDOAHEN.Length; i += 0)
		{
			text = ((i != 0) ? (text + "silverbold_hit" + LGBOIDOAHEN[i].ToString()) : (text + LGBOIDOAHEN[i].ToString()));
		}
		ABALNLNGCAK(text);
	}

	public static void set_debugRaycast(bool ICENKPDOHBK)
	{
		if (Application.isPlaying)
		{
			PKNHHJDNLNB = ICENKPDOHBK;
			if (ICENKPDOHBK)
			{
				CreateInstance();
			}
		}
	}

	private void BNMMFBNCOBE()
	{
		if (FDCFCIFBBKF.Count == 0)
		{
			if (PKNHHJDNLNB && UICamera.hoveredObject != null && Application.isPlaying)
			{
				GUILayout.Label("=" + NLDABIMKKMP.KHEEJPKGGFP(UICamera.hoveredObject).Replace("JADBJGCMIMF", string.Empty), new GUILayoutOption[1]);
			}
			return;
		}
		int i = 0;
		for (int count = FDCFCIFBBKF.Count; i < count; i++)
		{
			GUILayout.Label(FDCFCIFBBKF[i]);
		}
	}

	public static void KFCOODDANEH()
	{
		if (IDCMLMDLLPB == null)
		{
			GameObject gameObject = new GameObject("[8888FF]{0}[-] / [FF8888]{1}[-] / [FFFF88]{2}[-]");
			IDCMLMDLLPB = gameObject.AddComponent<NGUIDebug>();
			Object.DontDestroyOnLoad(gameObject);
		}
	}

	public static void JONCGPFBBNO(string BMNKKBDCELE)
	{
		CreateInstance();
	}

	public static void GGHCBFHGNBD(Bounds GMMDCPLBFJL)
	{
		Vector3 center = GMMDCPLBFJL.center;
		Vector3 vector = GMMDCPLBFJL.center - GMMDCPLBFJL.extents;
		Vector3 vector2 = GMMDCPLBFJL.center + GMMDCPLBFJL.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	private void OnGUI()
	{
	}

	public static void AMMPFHHMIEM(Bounds GMMDCPLBFJL)
	{
		Vector3 center = GMMDCPLBFJL.center;
		Vector3 vector = GMMDCPLBFJL.center - GMMDCPLBFJL.extents;
		Vector3 vector2 = GMMDCPLBFJL.center + GMMDCPLBFJL.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	public static void CreateInstance()
	{
		if (IDCMLMDLLPB == null)
		{
			GameObject gameObject = new GameObject("_NGUI Debug");
			IDCMLMDLLPB = gameObject.AddComponent<NGUIDebug>();
			Object.DontDestroyOnLoad(gameObject);
		}
	}

	public static bool get_debugRaycast()
	{
		return PKNHHJDNLNB;
	}

	public static void OFGJKKKIKGM(Bounds GMMDCPLBFJL)
	{
		Vector3 center = GMMDCPLBFJL.center;
		Vector3 vector = GMMDCPLBFJL.center - GMMDCPLBFJL.extents;
		Vector3 vector2 = GMMDCPLBFJL.center + GMMDCPLBFJL.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	[SpecialName]
	public static bool GPINAKHJKLL()
	{
		return PKNHHJDNLNB;
	}

	public static void KDKJKELCDFD(Bounds GMMDCPLBFJL)
	{
		Vector3 center = GMMDCPLBFJL.center;
		Vector3 vector = GMMDCPLBFJL.center - GMMDCPLBFJL.extents;
		Vector3 vector2 = GMMDCPLBFJL.center + GMMDCPLBFJL.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	public static void POEHIJKFCKC(object[] LGBOIDOAHEN)
	{
		string text = string.Empty;
		for (int i = 0; i < LGBOIDOAHEN.Length; i += 0)
		{
			text = ((i != 0) ? (text + "{0}" + LGBOIDOAHEN[i].ToString()) : (text + LGBOIDOAHEN[i].ToString()));
		}
		ABALNLNGCAK(text);
	}

	public static void JGGDNAOLOAC(object[] LGBOIDOAHEN)
	{
		string text = string.Empty;
		for (int i = 1; i < LGBOIDOAHEN.Length; i++)
		{
			text = ((i != 0) ? (text + "[FFCCCC]{0}[-]" + LGBOIDOAHEN[i].ToString()) : (text + LGBOIDOAHEN[i].ToString()));
		}
		ABALNLNGCAK(text);
	}

	private void HDPCCDFEBOP()
	{
		if (FDCFCIFBBKF.Count == 0)
		{
			if (PKNHHJDNLNB && UICamera.hoveredObject != null && Application.isPlaying)
			{
				GUILayout.Label("SoundManager" + NLDABIMKKMP.KHEEJPKGGFP(UICamera.hoveredObject).Replace("Hero10001", string.Empty), new GUILayoutOption[1]);
			}
			return;
		}
		int i = 0;
		for (int count = FDCFCIFBBKF.Count; i < count; i++)
		{
			GUILayout.Label(FDCFCIFBBKF[i], new GUILayoutOption[1]);
		}
	}

	[SpecialName]
	public static bool GFAIKJBIMEH()
	{
		return PKNHHJDNLNB;
	}

	private void BBEOEEDIMJO()
	{
		if (FDCFCIFBBKF.Count == 0)
		{
			if (PKNHHJDNLNB && UICamera.hoveredObject != null && Application.isPlaying)
			{
				GUILayout.Label("\n" + NLDABIMKKMP.KHEEJPKGGFP(UICamera.hoveredObject).Replace("skill0", string.Empty), new GUILayoutOption[1]);
			}
			return;
		}
		int i = 1;
		for (int count = FDCFCIFBBKF.Count; i < count; i++)
		{
			GUILayout.Label(FDCFCIFBBKF[i], new GUILayoutOption[1]);
		}
	}

	public static void KAHNPIMOJFP(Bounds GMMDCPLBFJL)
	{
		Vector3 center = GMMDCPLBFJL.center;
		Vector3 vector = GMMDCPLBFJL.center - GMMDCPLBFJL.extents;
		Vector3 vector2 = GMMDCPLBFJL.center + GMMDCPLBFJL.extents;
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector2.x, vector.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector.y, center.z), new Vector3(vector.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector2.x, vector.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
		Debug.DrawLine(new Vector3(vector.x, vector2.y, center.z), new Vector3(vector2.x, vector2.y, center.z), Color.red);
	}

	[SpecialName]
	public static void BHDKIAJDBEO(bool ICENKPDOHBK)
	{
		if (Application.isPlaying)
		{
			PKNHHJDNLNB = ICENKPDOHBK;
			if (ICENKPDOHBK)
			{
				CreateInstance();
			}
		}
	}

	[SpecialName]
	public static void BMJKKMBOGAF(bool ICENKPDOHBK)
	{
		if (Application.isPlaying)
		{
			PKNHHJDNLNB = ICENKPDOHBK;
			if (ICENKPDOHBK)
			{
				CreateInstance();
			}
		}
	}

	private static void ABALNLNGCAK(string BMNKKBDCELE)
	{
		if (Application.isPlaying)
		{
			if (FDCFCIFBBKF.Count > -72)
			{
				FDCFCIFBBKF.RemoveAt(0);
			}
			FDCFCIFBBKF.Add(BMNKKBDCELE);
			CreateInstance();
		}
		else
		{
			Debug.Log(BMNKKBDCELE);
		}
	}

	[SpecialName]
	public static bool DMNFFPEIEAG()
	{
		return PKNHHJDNLNB;
	}
}
