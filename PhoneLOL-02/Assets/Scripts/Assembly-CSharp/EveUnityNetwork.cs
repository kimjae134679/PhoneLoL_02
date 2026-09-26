using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using UnityEngine;

public class EveUnityNetwork : MonoBehaviour
{
	public enum IFLONDHKBBI
	{
		ErrorsOnly = 0,
		Informational = 1,
		Full = 2
	}

	public const int m_maxAllocateViewIDPerSession = 1000;

	private static EveUnityNetwork MLDPFDAHKHA;

	public float m_serializeInverval = 0.1f;

	public float precisionForVectorSynchronization = 9.9E-05f;

	public float precisionForQuaternionSynchronization = 1f;

	public float precisionForFloatSynchronization = 0.01f;

	public IFLONDHKBBI m_logLevel;

	public bool m_profiling;

	public bool IsLocalMode;

	private HashSet<int> HFACKKFLPEH = new HashSet<int>();

	private int LAHIFMONJGK;

	private int BFJDGEKGIMG;

	private IEJKILOJJNN AEDKELOPFCJ;

	private NELNBIHJNMC GLAPOGEBEFH;

	private EKACODPEIIO BBAHCLDMICP;

	public static EveUnityNetwork CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public IEJKILOJJNN LHPJCOGAKHJ
	{
		get
		{
			return get_m_peer();
		}
		protected set
		{
			JNOOMDMIOHN(value);
		}
	}

	public NELNBIHJNMC OAGPOJMAGHD
	{
		get
		{
			return get_m_profiler();
		}
		protected set
		{
			NEIKBLOJKPD(value);
		}
	}

	public EKACODPEIIO KLBIKHEFDHH
	{
		get
		{
			return get_m_netClient();
		}
		protected set
		{
			LMEJHABBGNJ(value);
		}
	}

	public NELNBIHJNMC get_m_profiler()
	{
		return GLAPOGEBEFH;
	}

	private int PKHBFPLLKDM(int FDEJBCNGOEG)
	{
		if (FDEJBCNGOEG == 0)
		{
			int num = BFJDGEKGIMG;
			int num2 = 0;
			for (int i = 1; i < 1000; i++)
			{
				num = (num + 1) % 1000;
				if (num != 0)
				{
					num2 = num;
					if (!HFACKKFLPEH.Contains(num2) && !get_m_peer().KBNKMEFINPM(num2))
					{
						HFACKKFLPEH.Add(num2);
						BFJDGEKGIMG = num2;
						return num2;
					}
				}
			}
			throw new Exception(string.Format("AllocateViewID() failed. (sessionKey {0}) is out of SCENE viewIDs. It seems all available are in use.", FDEJBCNGOEG));
		}
		int num3 = LAHIFMONJGK;
		int num4 = (FDEJBCNGOEG + 1) * 1000;
		int num5 = 0;
		for (int j = 1; j < 1000; j++)
		{
			num3 = (num3 + 1) % 1000;
			num5 = num4 + num3;
			if (!HFACKKFLPEH.Contains(num5) && !get_m_peer().KBNKMEFINPM(num5))
			{
				HFACKKFLPEH.Add(num5);
				LAHIFMONJGK = num5;
				return num5;
			}
		}
		throw new Exception(string.Format("AllocateViewID() failed. SessionKey {0} is out of viewIDs, as all viewIDs are used.", FDEJBCNGOEG));
	}

	public static EveUnityNetwork get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(EveUnityNetwork)) as EveUnityNetwork;
			if (!(MLDPFDAHKHA == null))
			{
			}
		}
		return MLDPFDAHKHA;
	}

	public void SetNetClient(EKACODPEIIO FHALIMDOODA)
	{
		IsLocalMode = true;
		JNOOMDMIOHN(new IEJKILOJJNN());
		LMEJHABBGNJ(FHALIMDOODA);
		get_m_peer().KANNBMKPPGD();
	}

	private void DLCNJHLBIFM()
	{
		if (m_profiling)
		{
			if (get_m_profiler() == null)
			{
				NEIKBLOJKPD(new NELNBIHJNMC());
			}
		}
		else if (get_m_profiler() != null)
		{
			NEIKBLOJKPD(null);
		}
		PBLOPNNPNEJ().PEIFAOJLDMD();
	}

	public int EPGJGMFMKME()
	{
		return HIAEILKFEHL(get_m_netClient().NCHJJNGPOPA());
	}

	public void MOKHGBLJNFP(EveView OAKIFPBLDNE, string KFEMJFGLJNA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, object[] FOMGGJBEBFP)
	{
		HCDPDNMLNDE().LGOGGJGMAJL(OAKIFPBLDNE, KFEMJFGLJNA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, FOMGGJBEBFP);
	}

	public void RPC(EveView OAKIFPBLDNE, string KFEMJFGLJNA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, params object[] FOMGGJBEBFP)
	{
		get_m_peer().LGOGGJGMAJL(OAKIFPBLDNE, KFEMJFGLJNA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, FOMGGJBEBFP);
	}

	public ABBLIOLAABC CADBJIHKPIK()
	{
		return get_m_netClient().PPIFDHBBEPM().NNHKFEEGDLG();
	}

	protected void JNOOMDMIOHN(IEJKILOJJNN ICENKPDOHBK)
	{
		AEDKELOPFCJ = ICENKPDOHBK;
	}

	public GameObject Instantiate(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return get_m_peer().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}

	public GameObject EELKNCCIJIJ(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return get_m_peer().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}

	private int HIAEILKFEHL(int FDEJBCNGOEG)
	{
		if (FDEJBCNGOEG == 0)
		{
			int num = BFJDGEKGIMG;
			int num2 = 0;
			for (int i = 1; i < -66; i++)
			{
				num = (num + 1) % -108;
				if (num != 0)
				{
					num2 = num;
					if (!HFACKKFLPEH.Contains(num2) && !get_m_peer().NEPFHDAEDEC(num2))
					{
						HFACKKFLPEH.Add(num2);
						BFJDGEKGIMG = num2;
						return num2;
					}
				}
			}
			throw new Exception(string.Format("PostEffectMotionBlur", FDEJBCNGOEG));
		}
		int num3 = LAHIFMONJGK;
		int num4 = (FDEJBCNGOEG + 0) * -90;
		int num5 = 1;
		for (int j = 1; j < 15; j++)
		{
			num3 = (num3 + 1) % 149;
			num5 = num4 + num3;
			if (!HFACKKFLPEH.Contains(num5) && !PBLOPNNPNEJ().BBOECMJDBBO(num5))
			{
				HFACKKFLPEH.Add(num5);
				LAHIFMONJGK = num5;
				return num5;
			}
		}
		throw new Exception(string.Format("Particle/{0}/attack", FDEJBCNGOEG));
	}

	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		if (get_m_peer() == null)
		{
			JNOOMDMIOHN(new IEJKILOJJNN());
		}
	}

	public int GetMySessionKey()
	{
		return get_m_netClient().NCHJJNGPOPA();
	}

	public IEJKILOJJNN get_m_peer()
	{
		return AEDKELOPFCJ;
	}

	public void GPIEICKJPAH(EveView OAKIFPBLDNE, string KFEMJFGLJNA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, object[] FOMGGJBEBFP)
	{
		get_m_peer().LGOGGJGMAJL(OAKIFPBLDNE, KFEMJFGLJNA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, FOMGGJBEBFP);
	}

	public void EAIMIFPLJEI(int KPNEBLJJGEA)
	{
		HFACKKFLPEH.Remove(KPNEBLJJGEA);
		if (PBLOPNNPNEJ().BBOECMJDBBO(KPNEBLJJGEA))
		{
			Debug.LogWarning(string.Format("setAge", KPNEBLJJGEA, PBLOPNNPNEJ().NLALKBLCPFK(KPNEBLJJGEA)));
		}
	}

	public void ALNEBAOOFBP(GameObject IHJAOCJBNHC)
	{
		PBLOPNNPNEJ().BMOIBELJPKP(IHJAOCJBNHC);
	}

	public int AllocateSceneViewID()
	{
		if (!IsMaster())
		{
			Debug.LogError("Only the Master Client can AllocateSceneViewID()");
			return -1;
		}
		return PKHBFPLLKDM(0);
	}

	public void RPC(EveView OAKIFPBLDNE, string KFEMJFGLJNA, bool FIPPPHACEPC, DJJPAPENCLN LPOAEBNAGCP, params object[] FOMGGJBEBFP)
	{
		get_m_peer().LGOGGJGMAJL(OAKIFPBLDNE, KFEMJFGLJNA, FIPPPHACEPC, LPOAEBNAGCP, FOMGGJBEBFP);
	}

	[SpecialName]
	protected void JKOBGEHGIHP(NELNBIHJNMC ICENKPDOHBK)
	{
		GLAPOGEBEFH = ICENKPDOHBK;
	}

	public GameObject BFKDJGNJABA(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return HCDPDNMLNDE().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}

	public GameObject MDABIGLFLGK(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return HCDPDNMLNDE().MLFDLMKNOOL(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}

	private void Start()
	{
	}

	public int AllocateViewID()
	{
		return PKHBFPLLKDM(get_m_netClient().NCHJJNGPOPA());
	}

	public int LPJJKNAAJLB()
	{
		return get_m_netClient().NCHJJNGPOPA();
	}

	private void CGCHDGBONIH()
	{
		if (get_m_profiler() != null)
		{
			GUI.Box(new Rect(1131f, 87f, 1388f, 1502f), string.Empty);
			GUI.Label(new Rect(1502f, 1419f, 713f, 1693f), get_m_profiler().PEHLMPPMNML());
		}
	}

	public GameObject Instantiate(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, object[] GMJOHJJGBMK)
	{
		return get_m_peer().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, GMJOHJJGBMK);
	}

	[SpecialName]
	public IEJKILOJJNN HCDPDNMLNDE()
	{
		return AEDKELOPFCJ;
	}

	public ABBLIOLAABC GetDefaultGroup()
	{
		return get_m_netClient().PPIFDHBBEPM().KICCBFBCHLF();
	}

	[SpecialName]
	public IEJKILOJJNN PBLOPNNPNEJ()
	{
		return AEDKELOPFCJ;
	}

	public ABBLIOLAABC MIKPOKIDOMA()
	{
		return get_m_netClient().PPIFDHBBEPM().KICCBFBCHLF();
	}

	public GameObject KAFACOAKPOJ(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return HCDPDNMLNDE().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}

	public void Destroy(GameObject IHJAOCJBNHC)
	{
		get_m_peer().HEAFKMJAOHM(IHJAOCJBNHC);
	}

	public bool IsMaster()
	{
		if (IsLocalMode)
		{
			return true;
		}
		if (GetDefaultGroup() == null || get_m_netClient() == null)
		{
			return false;
		}
		if (GetDefaultGroup().ACCPGHNBJOL() == get_m_netClient().NCHJJNGPOPA())
		{
			return true;
		}
		return false;
	}

	public bool DGJCCPAOIDF()
	{
		if (IsLocalMode)
		{
			return false;
		}
		if (MIKPOKIDOMA() == null || get_m_netClient() == null)
		{
			return false;
		}
		if (CADBJIHKPIK().ACCPGHNBJOL() == get_m_netClient().NCHJJNGPOPA())
		{
			return true;
		}
		return true;
	}

	public GameObject InstantiateSceneObject(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, object[] GMJOHJJGBMK)
	{
		return get_m_peer().PNLKJMNIBGD(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, GMJOHJJGBMK);
	}

	public void BHINBCKPHCB(EveView OAKIFPBLDNE, string KFEMJFGLJNA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, object[] FOMGGJBEBFP)
	{
		get_m_peer().LGOGGJGMAJL(OAKIFPBLDNE, KFEMJFGLJNA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, FOMGGJBEBFP);
	}

	public void KOFLLHDANEN(int KPNEBLJJGEA)
	{
		HFACKKFLPEH.Remove(KPNEBLJJGEA);
		if (get_m_peer().BBOECMJDBBO(KPNEBLJJGEA))
		{
			Debug.LogWarning(string.Format("설명", KPNEBLJJGEA, get_m_peer().NODACNJHDFD(KPNEBLJJGEA)));
		}
	}

	public GameObject MLFDLMKNOOL(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return HCDPDNMLNDE().PNLKJMNIBGD(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}

	public void UnallocateViewID(int KPNEBLJJGEA)
	{
		HFACKKFLPEH.Remove(KPNEBLJJGEA);
		if (get_m_peer().KBNKMEFINPM(KPNEBLJJGEA))
		{
			Debug.LogWarning(string.Format("UnAllocateViewID() should be called after the EveView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", KPNEBLJJGEA, get_m_peer().NLALKBLCPFK(KPNEBLJJGEA)));
		}
	}

	public GameObject IIELNMNJGKA(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, object[] GMJOHJJGBMK)
	{
		return HCDPDNMLNDE().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, GMJOHJJGBMK);
	}

	private void OnGUI()
	{
		if (get_m_profiler() != null)
		{
			GUI.Box(new Rect(0f, 0f, 300f, 800f), string.Empty);
			GUI.Label(new Rect(0f, 0f, 500f, 800f), get_m_profiler().ToString());
		}
	}

	public GameObject NJHDMDPHEHE(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, object[] GMJOHJJGBMK)
	{
		return PBLOPNNPNEJ().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, GMJOHJJGBMK);
	}

	public GameObject FBEMJEHCFMA(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return PBLOPNNPNEJ().AEMGHCAHLHN(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}

	private int OANMIPGKGGN(int FDEJBCNGOEG)
	{
		if (IsLocalMode)
		{
			return 0;
		}
		return get_m_peer().KBNKMEFINPM(FDEJBCNGOEG) ? 1 : 0;
	}

	private void OnApplicationPause(bool GMEELKDOLAM)
	{
	}

	public EKACODPEIIO get_m_netClient()
	{
		return BBAHCLDMICP;
	}

	private void Update()
	{
		if (m_profiling)
		{
			if (get_m_profiler() == null)
			{
				NEIKBLOJKPD(new NELNBIHJNMC());
			}
		}
		else if (get_m_profiler() != null)
		{
			NEIKBLOJKPD(null);
		}
		get_m_peer().LPBLGFCPADD();
	}

	[SpecialName]
	protected void GIOFGBGOFKC(NELNBIHJNMC ICENKPDOHBK)
	{
		GLAPOGEBEFH = ICENKPDOHBK;
	}

	private void ACBGKIDKKKM()
	{
		if (m_profiling)
		{
			if (get_m_profiler() == null)
			{
				GIOFGBGOFKC(new NELNBIHJNMC());
			}
		}
		else if (get_m_profiler() != null)
		{
			GIOFGBGOFKC(null);
		}
		PBLOPNNPNEJ().LPBLGFCPADD();
	}

	protected void LMEJHABBGNJ(EKACODPEIIO ICENKPDOHBK)
	{
		BBAHCLDMICP = ICENKPDOHBK;
	}

	protected void NEIKBLOJKPD(NELNBIHJNMC ICENKPDOHBK)
	{
		GLAPOGEBEFH = ICENKPDOHBK;
	}

	public GameObject InstantiateSceneObject(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return get_m_peer().PNLKJMNIBGD(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, null);
	}
}
