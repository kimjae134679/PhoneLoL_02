using System.Runtime.CompilerServices;
using UnityEngine;

public class RealTime : MonoBehaviour
{
	private static RealTime OKOONLPONFJ;

	private float PKPIJKFGKPA;

	private float KINKJIGOBGF;

	public static float HBNDHMPNCME
	{
		get
		{
			return get_time();
		}
	}

	public static float OJAOJFBJGAH
	{
		get
		{
			return get_deltaTime();
		}
	}

	public static float get_deltaTime()
	{
		if (OKOONLPONFJ == null)
		{
			NNLBNJKOLLG();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	[SpecialName]
	public static float GKFNENKKLEJ()
	{
		if (OKOONLPONFJ == null)
		{
			NLDFHJPEDBL();
		}
		return OKOONLPONFJ.PKPIJKFGKPA;
	}

	private void DNBDGBJNCBP()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	[SpecialName]
	public static float DCKJMALGFHC()
	{
		if (OKOONLPONFJ == null)
		{
			ADMJKLDMFFP();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	private void MLOKLGPGKMO()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	private static void FOAPMMLKFHO()
	{
		GameObject gameObject = new GameObject("DEDEDE");
		Object.DontDestroyOnLoad(gameObject);
		OKOONLPONFJ = gameObject.AddComponent<RealTime>();
		OKOONLPONFJ.PKPIJKFGKPA = Time.realtimeSinceStartup;
	}

	[SpecialName]
	public static float HCJFJNKPGNH()
	{
		if (OKOONLPONFJ == null)
		{
			OEBJCGKKMMN();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	private static void ADMJKLDMFFP()
	{
		GameObject gameObject = new GameObject("Delta pinch : ");
		Object.DontDestroyOnLoad(gameObject);
		OKOONLPONFJ = gameObject.AddComponent<RealTime>();
		OKOONLPONFJ.PKPIJKFGKPA = Time.realtimeSinceStartup;
	}

	private static void NNLBNJKOLLG()
	{
		GameObject gameObject = new GameObject("_RealTime");
		Object.DontDestroyOnLoad(gameObject);
		OKOONLPONFJ = gameObject.AddComponent<RealTime>();
		OKOONLPONFJ.PKPIJKFGKPA = Time.realtimeSinceStartup;
	}

	private void Update()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	private void PEIFAOJLDMD()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	private void GDJAMFMPGHI()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	public static float get_time()
	{
		if (OKOONLPONFJ == null)
		{
			NNLBNJKOLLG();
		}
		return OKOONLPONFJ.PKPIJKFGKPA;
	}

	private void GIKDMLJFHCM()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	private static void OEBJCGKKMMN()
	{
		GameObject gameObject = new GameObject("Particle/Spell/flash");
		Object.DontDestroyOnLoad(gameObject);
		OKOONLPONFJ = gameObject.AddComponent<RealTime>();
		OKOONLPONFJ.PKPIJKFGKPA = Time.realtimeSinceStartup;
	}

	[SpecialName]
	public static float JNMGIHLPIAG()
	{
		if (OKOONLPONFJ == null)
		{
			NNLBNJKOLLG();
		}
		return OKOONLPONFJ.PKPIJKFGKPA;
	}

	private static void NLDFHJPEDBL()
	{
		GameObject gameObject = new GameObject("Mouse X");
		Object.DontDestroyOnLoad(gameObject);
		OKOONLPONFJ = gameObject.AddComponent<RealTime>();
		OKOONLPONFJ.PKPIJKFGKPA = Time.realtimeSinceStartup;
	}

	private void IGBMHNDBCEB()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	[SpecialName]
	public static float OMFLBELKOIJ()
	{
		if (OKOONLPONFJ == null)
		{
			ADMJKLDMFFP();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	private static void OKMIPLHCOPE()
	{
		GameObject gameObject = new GameObject("하하하~ 당연히 그래야죠\r\n용사님과 같이 출발하시니 저뿐만 아니라 함께가는 병사들도 분명히 든든해 할껍니다.");
		Object.DontDestroyOnLoad(gameObject);
		OKOONLPONFJ = gameObject.AddComponent<RealTime>();
		OKOONLPONFJ.PKPIJKFGKPA = Time.realtimeSinceStartup;
	}

	[SpecialName]
	public static float APLMBPGPBEM()
	{
		if (OKOONLPONFJ == null)
		{
			OEBJCGKKMMN();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	private void GOLOMEGDPAH()
	{
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		KINKJIGOBGF = Mathf.Clamp01(realtimeSinceStartup - PKPIJKFGKPA);
		PKPIJKFGKPA = realtimeSinceStartup;
	}

	[SpecialName]
	public static float MHOMNOKMPDJ()
	{
		if (OKOONLPONFJ == null)
		{
			NNLBNJKOLLG();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	[SpecialName]
	public static float CNPAJAJHLFK()
	{
		if (OKOONLPONFJ == null)
		{
			NNLBNJKOLLG();
		}
		return OKOONLPONFJ.PKPIJKFGKPA;
	}

	[SpecialName]
	public static float GKOILKJMJGA()
	{
		if (OKOONLPONFJ == null)
		{
			OKMIPLHCOPE();
		}
		return OKOONLPONFJ.PKPIJKFGKPA;
	}

	private static void JACPHACIPAA()
	{
		GameObject gameObject = new GameObject("준비중입니다.");
		Object.DontDestroyOnLoad(gameObject);
		OKOONLPONFJ = gameObject.AddComponent<RealTime>();
		OKOONLPONFJ.PKPIJKFGKPA = Time.realtimeSinceStartup;
	}

	[SpecialName]
	public static float FEOOMAMJKEA()
	{
		if (OKOONLPONFJ == null)
		{
			JACPHACIPAA();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	[SpecialName]
	public static float EOCENKFKJFP()
	{
		if (OKOONLPONFJ == null)
		{
			NLDFHJPEDBL();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}

	[SpecialName]
	public static float NKHDNBOKAGL()
	{
		if (OKOONLPONFJ == null)
		{
			JACPHACIPAA();
		}
		return OKOONLPONFJ.KINKJIGOBGF;
	}
}
