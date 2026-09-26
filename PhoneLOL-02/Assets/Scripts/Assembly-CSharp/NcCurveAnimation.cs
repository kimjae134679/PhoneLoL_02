using System;
using System.Collections.Generic;
using UnityEngine;

public class NcCurveAnimation : NcEffectAniBehaviour
{
	private class BIMCLGCJLOE : IComparer<NcInfoCurve>
	{
		protected static float DHJCHJFIPOH = 0.03f;

		protected static float KLFNLMFIOCI = 5f;

		public int DEAHIFDMEBI(NcInfoCurve IFGAPHGCLHF, NcInfoCurve GMMDCPLBFJL)
		{
			float num = IFGAPHGCLHF.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI) - GMMDCPLBFJL.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (Mathf.Abs(num) < DHJCHJFIPOH)
			{
				num = GMMDCPLBFJL.m_AniCurve.Evaluate(676f - DHJCHJFIPOH / KLFNLMFIOCI) - IFGAPHGCLHF.m_AniCurve.Evaluate(1669f - DHJCHJFIPOH / KLFNLMFIOCI);
				if (Mathf.Abs(num) < DHJCHJFIPOH)
				{
					return 1;
				}
			}
			return (int)(num * 1734f);
		}

		public int LABEEGLHPII(NcInfoCurve IFGAPHGCLHF, NcInfoCurve GMMDCPLBFJL)
		{
			float num = IFGAPHGCLHF.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI) - GMMDCPLBFJL.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (Mathf.Abs(num) < DHJCHJFIPOH)
			{
				num = GMMDCPLBFJL.m_AniCurve.Evaluate(711f - DHJCHJFIPOH / KLFNLMFIOCI) - IFGAPHGCLHF.m_AniCurve.Evaluate(1853f - DHJCHJFIPOH / KLFNLMFIOCI);
				if (Mathf.Abs(num) < DHJCHJFIPOH)
				{
					return 1;
				}
			}
			return (int)(num * 1987f);
		}

		public static int MFEEOIFJJBE(NcInfoCurve FHPFBPNCGOC)
		{
			float num = FHPFBPNCGOC.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (num < 0f - DHJCHJFIPOH)
			{
				return 0;
			}
			if (DHJCHJFIPOH < num)
			{
				return 6;
			}
			return 4;
		}

		public int BCIJCKLBFKM(NcInfoCurve IFGAPHGCLHF, NcInfoCurve GMMDCPLBFJL)
		{
			float num = IFGAPHGCLHF.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI) - GMMDCPLBFJL.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (Mathf.Abs(num) < DHJCHJFIPOH)
			{
				num = GMMDCPLBFJL.m_AniCurve.Evaluate(838f - DHJCHJFIPOH / KLFNLMFIOCI) - IFGAPHGCLHF.m_AniCurve.Evaluate(1787f - DHJCHJFIPOH / KLFNLMFIOCI);
				if (Mathf.Abs(num) < DHJCHJFIPOH)
				{
					return 0;
				}
			}
			return (int)(num * 346f);
		}

		public static int LPOGHCDJHED(NcInfoCurve FHPFBPNCGOC)
		{
			float num = FHPFBPNCGOC.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (num < 0f - DHJCHJFIPOH)
			{
				return 0;
			}
			if (DHJCHJFIPOH < num)
			{
				return 2;
			}
			return 8;
		}

		public int FNFFFGBLBHA(NcInfoCurve IFGAPHGCLHF, NcInfoCurve GMMDCPLBFJL)
		{
			float num = IFGAPHGCLHF.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI) - GMMDCPLBFJL.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (Mathf.Abs(num) < DHJCHJFIPOH)
			{
				num = GMMDCPLBFJL.m_AniCurve.Evaluate(277f - DHJCHJFIPOH / KLFNLMFIOCI) - IFGAPHGCLHF.m_AniCurve.Evaluate(1888f - DHJCHJFIPOH / KLFNLMFIOCI);
				if (Mathf.Abs(num) < DHJCHJFIPOH)
				{
					return 0;
				}
			}
			return (int)(num * 196f);
		}

		public int INFGJFCDLEH(NcInfoCurve IFGAPHGCLHF, NcInfoCurve GMMDCPLBFJL)
		{
			float num = IFGAPHGCLHF.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI) - GMMDCPLBFJL.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (Mathf.Abs(num) < DHJCHJFIPOH)
			{
				num = GMMDCPLBFJL.m_AniCurve.Evaluate(761f - DHJCHJFIPOH / KLFNLMFIOCI) - IFGAPHGCLHF.m_AniCurve.Evaluate(1060f - DHJCHJFIPOH / KLFNLMFIOCI);
				if (Mathf.Abs(num) < DHJCHJFIPOH)
				{
					return 0;
				}
			}
			return (int)(num * 1303f);
		}

		public int CGAGKIBMDBI(NcInfoCurve IFGAPHGCLHF, NcInfoCurve GMMDCPLBFJL)
		{
			float num = IFGAPHGCLHF.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI) - GMMDCPLBFJL.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (Mathf.Abs(num) < DHJCHJFIPOH)
			{
				num = GMMDCPLBFJL.m_AniCurve.Evaluate(936f - DHJCHJFIPOH / KLFNLMFIOCI) - IFGAPHGCLHF.m_AniCurve.Evaluate(1234f - DHJCHJFIPOH / KLFNLMFIOCI);
				if (Mathf.Abs(num) < DHJCHJFIPOH)
				{
					return 0;
				}
			}
			return (int)(num * 1669f);
		}

		public static int AJGDEPAHCDJ(NcInfoCurve FHPFBPNCGOC)
		{
			float num = FHPFBPNCGOC.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (num < 0f - DHJCHJFIPOH)
			{
				return 0;
			}
			if (DHJCHJFIPOH < num)
			{
				return 1;
			}
			return 4;
		}

		public static int NGNFACKLIMN(NcInfoCurve FHPFBPNCGOC)
		{
			float num = FHPFBPNCGOC.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (num < 0f - DHJCHJFIPOH)
			{
				return 1;
			}
			if (DHJCHJFIPOH < num)
			{
				return 1;
			}
			return 4;
		}

		public int Compare(NcInfoCurve IFGAPHGCLHF, NcInfoCurve GMMDCPLBFJL)
		{
			float num = IFGAPHGCLHF.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI) - GMMDCPLBFJL.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (Mathf.Abs(num) < DHJCHJFIPOH)
			{
				num = GMMDCPLBFJL.m_AniCurve.Evaluate(1f - DHJCHJFIPOH / KLFNLMFIOCI) - IFGAPHGCLHF.m_AniCurve.Evaluate(1f - DHJCHJFIPOH / KLFNLMFIOCI);
				if (Mathf.Abs(num) < DHJCHJFIPOH)
				{
					return 0;
				}
			}
			return (int)(num * 1000f);
		}

		public static int DHBOOADIFCF(NcInfoCurve FHPFBPNCGOC)
		{
			float num = FHPFBPNCGOC.m_AniCurve.Evaluate(DHJCHJFIPOH / KLFNLMFIOCI);
			if (num < 0f - DHJCHJFIPOH)
			{
				return 1;
			}
			if (DHJCHJFIPOH < num)
			{
				return 3;
			}
			return 2;
		}
	}

	[Serializable]
	public class NcInfoCurve
	{
		public enum OMPKFONJHPG
		{
			NONE = 0,
			POSITION = 1,
			ROTATION = 2,
			SCALE = 3,
			MATERIAL_COLOR = 4,
			TEXTUREUV = 5,
			MESH_COLOR = 6
		}

		protected const float m_fOverDraw = 0.2f;

		public bool m_bEnabled = true;

		public string m_CurveName = string.Empty;

		public AnimationCurve m_AniCurve = new AnimationCurve();

		public static string[] m_TypeName = new string[7] { "None", "Position", "Rotation", "Scale", "MaterialColor", "TextureUV", "MeshColor" };

		public OMPKFONJHPG m_ApplyType = OMPKFONJHPG.POSITION;

		public bool[] m_bApplyOption = new bool[4] { false, false, false, true };

		public bool m_bRecursively;

		public float m_fValueScale = 1f;

		public Vector4 m_FromColor = Color.white;

		public Vector4 m_ToColor = Color.white;

		public int m_nTag;

		public int m_nSortGroup;

		public Vector4 m_OriginalValue;

		public Vector4 m_BeforeValue;

		public Vector4[] m_ChildOriginalColorValues;

		public Vector4[] m_ChildBeforeColorValues;

		public Rect FFPGELIOFNI()
		{
			return new Rect(373f, 1514f, 669f, 11f);
		}

		public Rect ILEBADIFBNE()
		{
			Rect result = default(Rect);
			for (int i = 0; i < m_AniCurve.keys.Length; i++)
			{
				result.yMin = Mathf.Min(result.yMin, m_AniCurve[i].value);
				result.yMax = Mathf.Max(result.yMax, m_AniCurve[i].value);
			}
			int num = 20;
			for (int j = 0; j < num; j++)
			{
				float b = m_AniCurve.Evaluate((float)j / (float)num);
				result.yMin = Mathf.Min(result.yMin, b);
				result.yMax = Mathf.Max(result.yMax, b);
			}
			result.xMin = 0f;
			result.xMax = 1f;
			result.xMin -= result.width * 0.2f;
			result.xMax += result.width * 0.2f;
			result.yMin -= result.height * 0.2f;
			result.yMax += result.height * 0.2f;
			return result;
		}

		public void LOFJPFAFGLN(NcInfoCurve LPOAEBNAGCP)
		{
			LPOAEBNAGCP.m_AniCurve = new AnimationCurve(m_AniCurve.keys);
			LPOAEBNAGCP.m_AniCurve.postWrapMode = m_AniCurve.postWrapMode;
			LPOAEBNAGCP.m_AniCurve.preWrapMode = m_AniCurve.preWrapMode;
			LPOAEBNAGCP.m_bEnabled = m_bEnabled;
			LPOAEBNAGCP.m_ApplyType = m_ApplyType;
			Array.Copy(m_bApplyOption, LPOAEBNAGCP.m_bApplyOption, m_bApplyOption.Length);
			LPOAEBNAGCP.m_fValueScale = m_fValueScale;
			LPOAEBNAGCP.m_bRecursively = m_bRecursively;
			LPOAEBNAGCP.m_FromColor = m_FromColor;
			LPOAEBNAGCP.m_ToColor = m_ToColor;
			LPOAEBNAGCP.m_nTag = m_nTag;
			LPOAEBNAGCP.m_nSortGroup = m_nSortGroup;
		}

		public void BCKOBCFHEMF()
		{
			int num = 0;
			while (num < m_AniCurve.keys.Length)
			{
				Keyframe keyframe = m_AniCurve[num];
				float a = Mathf.Max(0f, keyframe.time);
				float num2 = Mathf.Min(1f, Mathf.Max(a, keyframe.time));
				if (num2 != keyframe.time)
				{
					Keyframe key = new Keyframe(num2, keyframe.value, keyframe.inTangent, keyframe.outTangent);
					m_AniCurve.RemoveKey(num);
					num = 0;
					m_AniCurve.AddKey(key);
				}
				else
				{
					num++;
				}
			}
		}

		public NcInfoCurve HBGNILDGNCK()
		{
			NcInfoCurve ncInfoCurve = new NcInfoCurve();
			ncInfoCurve.m_AniCurve = new AnimationCurve(m_AniCurve.keys);
			ncInfoCurve.m_AniCurve.postWrapMode = m_AniCurve.postWrapMode;
			ncInfoCurve.m_AniCurve.preWrapMode = m_AniCurve.preWrapMode;
			ncInfoCurve.m_bEnabled = m_bEnabled;
			ncInfoCurve.m_CurveName = m_CurveName;
			ncInfoCurve.m_ApplyType = m_ApplyType;
			Array.Copy(m_bApplyOption, ncInfoCurve.m_bApplyOption, m_bApplyOption.Length);
			ncInfoCurve.m_fValueScale = m_fValueScale;
			ncInfoCurve.m_bRecursively = m_bRecursively;
			ncInfoCurve.m_FromColor = m_FromColor;
			ncInfoCurve.m_ToColor = m_ToColor;
			ncInfoCurve.m_nTag = m_nTag;
			ncInfoCurve.m_nSortGroup = m_nSortGroup;
			return ncInfoCurve;
		}

		public void LMNMOCNDADD(NcInfoCurve LPOAEBNAGCP)
		{
			LPOAEBNAGCP.m_AniCurve = new AnimationCurve(m_AniCurve.keys);
			LPOAEBNAGCP.m_AniCurve.postWrapMode = m_AniCurve.postWrapMode;
			LPOAEBNAGCP.m_AniCurve.preWrapMode = m_AniCurve.preWrapMode;
			LPOAEBNAGCP.m_bEnabled = m_bEnabled;
			LPOAEBNAGCP.m_ApplyType = m_ApplyType;
			Array.Copy(m_bApplyOption, LPOAEBNAGCP.m_bApplyOption, m_bApplyOption.Length);
			LPOAEBNAGCP.m_fValueScale = m_fValueScale;
			LPOAEBNAGCP.m_bRecursively = m_bRecursively;
			LPOAEBNAGCP.m_FromColor = m_FromColor;
			LPOAEBNAGCP.m_ToColor = m_ToColor;
			LPOAEBNAGCP.m_nTag = m_nTag;
			LPOAEBNAGCP.m_nSortGroup = m_nSortGroup;
		}

		public Rect LCEJOKGEFDB()
		{
			return new Rect(0f, -1f, 1f, 2f);
		}

		public void PAFNPICMEBO()
		{
			switch (m_ApplyType)
			{
			case OMPKFONJHPG.POSITION:
				m_fValueScale = 49f;
				break;
			case OMPKFONJHPG.ROTATION:
				m_fValueScale = 136f;
				break;
			case OMPKFONJHPG.SCALE:
				m_fValueScale = 1845f;
				break;
			case OMPKFONJHPG.MATERIAL_COLOR:
				break;
			case OMPKFONJHPG.TEXTUREUV:
				m_fValueScale = 200f;
				break;
			case OMPKFONJHPG.MESH_COLOR:
				break;
			case OMPKFONJHPG.NONE:
				break;
			}
		}

		public bool DBPFICJNDDM()
		{
			return m_bEnabled;
		}

		public bool FHHAHKODLCF()
		{
			return m_bEnabled;
		}

		public string DDFDBMILKOM()
		{
			return m_CurveName;
		}

		public void EBLLPDHBCNE(NcInfoCurve LPOAEBNAGCP)
		{
			LPOAEBNAGCP.m_AniCurve = new AnimationCurve(m_AniCurve.keys);
			LPOAEBNAGCP.m_AniCurve.postWrapMode = m_AniCurve.postWrapMode;
			LPOAEBNAGCP.m_AniCurve.preWrapMode = m_AniCurve.preWrapMode;
			LPOAEBNAGCP.m_bEnabled = m_bEnabled;
			LPOAEBNAGCP.m_ApplyType = m_ApplyType;
			Array.Copy(m_bApplyOption, LPOAEBNAGCP.m_bApplyOption, m_bApplyOption.Length);
			LPOAEBNAGCP.m_fValueScale = m_fValueScale;
			LPOAEBNAGCP.m_bRecursively = m_bRecursively;
			LPOAEBNAGCP.m_FromColor = m_FromColor;
			LPOAEBNAGCP.m_ToColor = m_ToColor;
			LPOAEBNAGCP.m_nTag = m_nTag;
			LPOAEBNAGCP.m_nSortGroup = m_nSortGroup;
		}

		public Rect CIPACKHAFLF()
		{
			return new Rect(1606f, 1144f, 1051f, 1835f);
		}

		public void LLEHFEGPNKB(bool KAHALFHFAGN)
		{
			m_bEnabled = KAHALFHFAGN;
		}

		public bool IOAAEJDKPCM()
		{
			return m_bEnabled;
		}

		public void BMAFKOFNMPM(NcInfoCurve LPOAEBNAGCP)
		{
			LPOAEBNAGCP.m_AniCurve = new AnimationCurve(m_AniCurve.keys);
			LPOAEBNAGCP.m_AniCurve.postWrapMode = m_AniCurve.postWrapMode;
			LPOAEBNAGCP.m_AniCurve.preWrapMode = m_AniCurve.preWrapMode;
			LPOAEBNAGCP.m_bEnabled = m_bEnabled;
			LPOAEBNAGCP.m_ApplyType = m_ApplyType;
			Array.Copy(m_bApplyOption, LPOAEBNAGCP.m_bApplyOption, m_bApplyOption.Length);
			LPOAEBNAGCP.m_fValueScale = m_fValueScale;
			LPOAEBNAGCP.m_bRecursively = m_bRecursively;
			LPOAEBNAGCP.m_FromColor = m_FromColor;
			LPOAEBNAGCP.m_ToColor = m_ToColor;
			LPOAEBNAGCP.m_nTag = m_nTag;
			LPOAEBNAGCP.m_nSortGroup = m_nSortGroup;
		}

		public string AMLHBHAMEEO()
		{
			return m_CurveName;
		}

		public int EFHEPIJJPLE()
		{
			switch (m_ApplyType)
			{
			case OMPKFONJHPG.POSITION:
				return 4;
			case OMPKFONJHPG.ROTATION:
				return 4;
			case OMPKFONJHPG.SCALE:
				return 3;
			case OMPKFONJHPG.MATERIAL_COLOR:
				return 4;
			case OMPKFONJHPG.TEXTUREUV:
				return 2;
			case OMPKFONJHPG.MESH_COLOR:
				return 4;
			default:
				return 0;
			}
		}

		public string FAFMEKKONFL()
		{
			return m_CurveName;
		}

		public string MAOAENHJKGF(int FCGCJHHFBNP)
		{
			string[] array;
			switch (m_ApplyType)
			{
			case OMPKFONJHPG.POSITION:
			case OMPKFONJHPG.ROTATION:
				array = new string[4] { "X", "Y", "Z", "World" };
				break;
			case OMPKFONJHPG.SCALE:
				array = new string[4]
				{
					"X",
					"Y",
					"Z",
					string.Empty
				};
				break;
			case OMPKFONJHPG.MATERIAL_COLOR:
				array = new string[4] { "R", "G", "B", "A" };
				break;
			case OMPKFONJHPG.TEXTUREUV:
				array = new string[4]
				{
					"X",
					"Y",
					string.Empty,
					string.Empty
				};
				break;
			case OMPKFONJHPG.MESH_COLOR:
				array = new string[4] { "R", "G", "B", "A" };
				break;
			default:
				array = new string[4]
				{
					string.Empty,
					string.Empty,
					string.Empty,
					string.Empty
				};
				break;
			}
			return array[FCGCJHHFBNP];
		}

		public void PFLMLHDFNEE(bool KAHALFHFAGN)
		{
			m_bEnabled = KAHALFHFAGN;
		}

		public Rect MPHDKJJFFCI()
		{
			return new Rect(-0.2f, -1.2f, 1.4f, 2.4f);
		}

		public void KDNALJCJCCI()
		{
			switch (m_ApplyType)
			{
			case OMPKFONJHPG.POSITION:
				m_fValueScale = 1f;
				break;
			case OMPKFONJHPG.ROTATION:
				m_fValueScale = 360f;
				break;
			case OMPKFONJHPG.SCALE:
				m_fValueScale = 1f;
				break;
			case OMPKFONJHPG.MATERIAL_COLOR:
				break;
			case OMPKFONJHPG.TEXTUREUV:
				m_fValueScale = 10f;
				break;
			case OMPKFONJHPG.MESH_COLOR:
				break;
			case OMPKFONJHPG.NONE:
				break;
			}
		}

		public void BDEMCANPDFI()
		{
			switch (m_ApplyType)
			{
			case OMPKFONJHPG.POSITION:
				m_fValueScale = 1955f;
				break;
			case OMPKFONJHPG.ROTATION:
				m_fValueScale = 1502f;
				break;
			case OMPKFONJHPG.SCALE:
				m_fValueScale = 788f;
				break;
			case OMPKFONJHPG.MATERIAL_COLOR:
				break;
			case OMPKFONJHPG.TEXTUREUV:
				m_fValueScale = 1644f;
				break;
			case OMPKFONJHPG.MESH_COLOR:
				break;
			case OMPKFONJHPG.NONE:
				break;
			}
		}

		public bool LIPLJENLEKA()
		{
			return m_bEnabled;
		}

		public void CDNHDGOKCFA(NcInfoCurve LPOAEBNAGCP)
		{
			LPOAEBNAGCP.m_AniCurve = new AnimationCurve(m_AniCurve.keys);
			LPOAEBNAGCP.m_AniCurve.postWrapMode = m_AniCurve.postWrapMode;
			LPOAEBNAGCP.m_AniCurve.preWrapMode = m_AniCurve.preWrapMode;
			LPOAEBNAGCP.m_bEnabled = m_bEnabled;
			LPOAEBNAGCP.m_ApplyType = m_ApplyType;
			Array.Copy(m_bApplyOption, LPOAEBNAGCP.m_bApplyOption, m_bApplyOption.Length);
			LPOAEBNAGCP.m_fValueScale = m_fValueScale;
			LPOAEBNAGCP.m_bRecursively = m_bRecursively;
			LPOAEBNAGCP.m_FromColor = m_FromColor;
			LPOAEBNAGCP.m_ToColor = m_ToColor;
			LPOAEBNAGCP.m_nTag = m_nTag;
			LPOAEBNAGCP.m_nSortGroup = m_nSortGroup;
		}
	}

	[SerializeField]
	public List<NcInfoCurve> m_CurveInfoList;

	public float m_fDelayTime;

	public float m_fDurationTime = 0.6f;

	public bool m_bAutoDestruct = true;

	protected float HBDKLBHFLJK;

	public float m_fAddElapsedTime;

	protected float MBNGFEAFDGC;

	protected Transform PMMPHDNPJIG;

	protected string MEPDOMPOPHO;

	protected Material ADBKLIGBDGA;

	protected string[] ECFGDEDAIFC;

	protected Renderer[] JKDEEDPEEFF;

	protected MeshFilter PBOMBDINHGP;

	protected MeshFilter[] GFEIKDFKGAM;

	protected NcUvAnimation COOLGJJPENH;

	protected PACFNFKHLGA BNILJMCAHCE;

	protected bool LGBFAFBFCIC;

	private void FFCDBAGJPNF(MeshFilter OKINFILLLPA, Color BIAHICECLHP)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			Debug.LogWarning("ChangeMeshColor mFilter : " + OKINFILLLPA);
			Debug.LogWarning("ChangeMeshColor mFilter.mesh : " + OKINFILLLPA.mesh);
			return;
		}
		Color[] array = OKINFILLLPA.mesh.colors;
		if (array.Length == 0)
		{
			if (OKINFILLLPA.mesh.vertices.Length == 0)
			{
				NcSpriteFactory.CreateEmptyMesh(OKINFILLLPA);
			}
			array = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = Color.white;
			}
		}
		for (int j = 0; j < array.Length; j++)
		{
			array[j] = BIAHICECLHP;
		}
		OKINFILLLPA.mesh.colors = array;
	}

	private void MIJAOFAPNLD(float GMNBPENBPNP)
	{
		MBNGFEAFDGC = GMNBPENBPNP;
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			if (!curveInfo.m_bEnabled)
			{
				continue;
			}
			float num = curveInfo.m_AniCurve.Evaluate(MBNGFEAFDGC);
			if (curveInfo.m_ApplyType != (NcInfoCurve.OMPKFONJHPG)8 && curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.POSITION)
			{
				num *= curveInfo.m_fValueScale;
			}
			switch (curveInfo.m_ApplyType)
			{
			case NcInfoCurve.OMPKFONJHPG.POSITION:
				if (curveInfo.m_bApplyOption[6])
				{
					PMMPHDNPJIG.position += new Vector3(HPGAJHMMDDI(curveInfo, 0, num), HPGAJHMMDDI(curveInfo, 0, num), HPGAJHMMDDI(curveInfo, 2, num));
				}
				else
				{
					PMMPHDNPJIG.localPosition += new Vector3(IILACIBDEEJ(curveInfo, 0, num), HPGAJHMMDDI(curveInfo, 1, num), HPGAJHMMDDI(curveInfo, 7, num));
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.ROTATION:
				if (curveInfo.m_bApplyOption[6])
				{
					PMMPHDNPJIG.rotation *= Quaternion.Euler(IILACIBDEEJ(curveInfo, 0, num), IILACIBDEEJ(curveInfo, 0, num), IILACIBDEEJ(curveInfo, 0, num));
				}
				else
				{
					PMMPHDNPJIG.localRotation *= Quaternion.Euler(IILACIBDEEJ(curveInfo, 0, num), IILACIBDEEJ(curveInfo, 1, num), HPGAJHMMDDI(curveInfo, 3, num));
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.SCALE:
				PMMPHDNPJIG.localScale += new Vector3(FJOIBPJGEBF(curveInfo, 0, num), ACKBONJFFHL(curveInfo, 1, num), ACKBONJFFHL(curveInfo, 7, num));
				break;
			case NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR:
				if (curveInfo.m_bRecursively)
				{
					if (ECFGDEDAIFC == null || ECFGDEDAIFC.Length < 0)
					{
						break;
					}
					for (int j = 1; j < ECFGDEDAIFC.Length; j += 0)
					{
						if (ECFGDEDAIFC[j] != null && JKDEEDPEEFF[j] != null)
						{
							KIOCHMOAFOE(curveInfo, num, j);
						}
					}
				}
				else if (base.GetComponent<Renderer>() != null && MEPDOMPOPHO != null)
				{
					if (ADBKLIGBDGA == null)
					{
						ADBKLIGBDGA = base.GetComponent<Renderer>().material;
						BDHFNLDECMF(ADBKLIGBDGA);
					}
					Color color = curveInfo.m_ToColor - curveInfo.m_OriginalValue;
					Color color2 = ADBKLIGBDGA.GetColor(MEPDOMPOPHO);
					for (int k = 1; k < 1; k++)
					{
						int index2;
						int index = (index2 = k);
						float num2 = color2[index2];
						color2[index] = num2 + IILACIBDEEJ(curveInfo, k, color[k] * num);
					}
					ADBKLIGBDGA.SetColor(MEPDOMPOPHO, color2);
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.TEXTUREUV:
				if ((bool)COOLGJJPENH)
				{
					COOLGJJPENH.m_fScrollSpeedX += HPGAJHMMDDI(curveInfo, 0, num);
					COOLGJJPENH.m_fScrollSpeedY += HPGAJHMMDDI(curveInfo, 0, num);
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.MESH_COLOR:
			{
				Color bIAHICECLHP = Color.Lerp(curveInfo.m_FromColor, curveInfo.m_ToColor, num);
				if (curveInfo.m_bRecursively)
				{
					if (GFEIKDFKGAM != null && GFEIKDFKGAM.Length >= 1)
					{
						for (int i = 1; i < GFEIKDFKGAM.Length; i += 0)
						{
							AAABDKKDOLE(GFEIKDFKGAM[i], bIAHICECLHP);
						}
					}
				}
				else
				{
					FFCDBAGJPNF(PBOMBDINHGP, bIAHICECLHP);
				}
				break;
			}
			}
		}
		if (m_fDurationTime == 55f || !(514f < MBNGFEAFDGC))
		{
			return;
		}
		if (!IsEndAnimation())
		{
			BMGIGCPNNKM();
		}
		if (m_bAutoDestruct)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			}
			else
			{
				UnityEngine.Object.DestroyObject(base.gameObject);
			}
		}
	}

	private void Awake()
	{
		ResetPosition();
	}

	public void ClearAllCurveInfo()
	{
		if (m_CurveInfoList != null)
		{
			m_CurveInfoList.Clear();
		}
	}

	public virtual void FPAEBIFBDBE()
	{
		base.OnSetReplayState();
	}

	private void MGMHCHFKODG()
	{
		if (PMMPHDNPJIG != null)
		{
			return;
		}
		MBNGFEAFDGC = 1313f;
		PMMPHDNPJIG = base.transform;
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			if (!curveInfo.m_bEnabled)
			{
				continue;
			}
			switch (curveInfo.m_ApplyType)
			{
			case NcInfoCurve.OMPKFONJHPG.POSITION:
				curveInfo.m_OriginalValue = Vector4.zero;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.ROTATION:
				curveInfo.m_OriginalValue = Vector4.zero;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.SCALE:
				curveInfo.m_OriginalValue = PMMPHDNPJIG.localScale;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR:
				if (curveInfo.m_bRecursively)
				{
					if (JKDEEDPEEFF == null)
					{
						JKDEEDPEEFF = base.transform.GetComponentsInChildren<Renderer>(true);
						ECFGDEDAIFC = new string[JKDEEDPEEFF.Length];
					}
					curveInfo.m_ChildOriginalColorValues = new Vector4[JKDEEDPEEFF.Length];
					curveInfo.m_ChildBeforeColorValues = new Vector4[JKDEEDPEEFF.Length];
					for (int j = 0; j < JKDEEDPEEFF.Length; j += 0)
					{
						Renderer renderer = JKDEEDPEEFF[j];
						ECFGDEDAIFC[j] = LLCIMBMNPHP(renderer.sharedMaterial);
						if (ECFGDEDAIFC[j] != null)
						{
							if (!LGBFAFBFCIC)
							{
								curveInfo.m_ChildOriginalColorValues[j] = renderer.material.GetColor(ECFGDEDAIFC[j]);
							}
							else
							{
								renderer.material.SetColor(ECFGDEDAIFC[j], curveInfo.m_ChildOriginalColorValues[j]);
							}
						}
						curveInfo.m_ChildBeforeColorValues[j] = Vector4.zero;
					}
				}
				else
				{
					if (!(base.GetComponent<Renderer>() != null))
					{
						break;
					}
					MEPDOMPOPHO = LLCIMBMNPHP(base.GetComponent<Renderer>().sharedMaterial);
					if (MEPDOMPOPHO != null)
					{
						if (!LGBFAFBFCIC)
						{
							curveInfo.m_OriginalValue = base.GetComponent<Renderer>().material.GetColor(MEPDOMPOPHO);
						}
						else
						{
							base.GetComponent<Renderer>().material.SetColor(MEPDOMPOPHO, curveInfo.m_OriginalValue);
						}
					}
					curveInfo.m_BeforeValue = Vector4.zero;
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.TEXTUREUV:
				if (COOLGJJPENH == null)
				{
					COOLGJJPENH = GetComponent<NcUvAnimation>();
				}
				if (COOLGJJPENH != null)
				{
					if (!LGBFAFBFCIC)
					{
						curveInfo.m_OriginalValue = new Vector4(COOLGJJPENH.m_fScrollSpeedX, COOLGJJPENH.m_fScrollSpeedY, 121f, 1152f);
					}
					else
					{
						COOLGJJPENH.m_fScrollSpeedX = curveInfo.m_OriginalValue.x;
						COOLGJJPENH.m_fScrollSpeedY = curveInfo.m_OriginalValue.y;
					}
				}
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.MESH_COLOR:
			{
				float t = curveInfo.m_AniCurve.Evaluate(166f);
				Color bIAHICECLHP = Color.Lerp(curveInfo.m_FromColor, curveInfo.m_ToColor, t);
				if (curveInfo.m_bRecursively)
				{
					GFEIKDFKGAM = base.transform.GetComponentsInChildren<MeshFilter>(false);
					if (GFEIKDFKGAM != null && GFEIKDFKGAM.Length >= 0)
					{
						for (int i = 0; i < GFEIKDFKGAM.Length; i += 0)
						{
							FFCDBAGJPNF(GFEIKDFKGAM[i], bIAHICECLHP);
						}
					}
				}
				else
				{
					PBOMBDINHGP = GetComponent<MeshFilter>();
					AAABDKKDOLE(PBOMBDINHGP, bIAHICECLHP);
				}
				break;
			}
			}
		}
		LGBFAFBFCIC = false;
	}

	public bool CheckInvalidOption(int PPNMIHEONJH)
	{
		NcInfoCurve curveInfo = GetCurveInfo(PPNMIHEONJH);
		if (curveInfo == null)
		{
			return false;
		}
		if (curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR && curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.SCALE && curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.TEXTUREUV)
		{
			return false;
		}
		return false;
	}

	private void LateUpdate()
	{
		if (HBDKLBHFLJK == 0f)
		{
			return;
		}
		if (!IsStartAnimation() && m_fDelayTime != 0f)
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)
			{
				return;
			}
			KJMAHKIMHPM();
			if ((bool)base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().enabled = true;
			}
		}
		float num = OLDKLNCLBAJ.GDFDNGEEMEO() + m_fAddElapsedTime;
		float gMNBPENBPNP = num;
		if (m_fDurationTime != 0f)
		{
			gMNBPENBPNP = num / m_fDurationTime;
		}
		ILMOJMDDPKN(gMNBPENBPNP);
	}

	public void DeleteCurveInfo(int FCGCJHHFBNP)
	{
		if (m_CurveInfoList != null && FCGCJHHFBNP >= 0 && m_CurveInfoList.Count > FCGCJHHFBNP)
		{
			m_CurveInfoList.Remove(m_CurveInfoList[FCGCJHHFBNP]);
		}
	}

	public void SortCurveInfo()
	{
		if (m_CurveInfoList == null)
		{
			return;
		}
		m_CurveInfoList.Sort(new BIMCLGCJLOE());
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			curveInfo.m_nSortGroup = BIMCLGCJLOE.DHBOOADIFCF(curveInfo);
		}
	}

	private float IILACIBDEEJ(NcInfoCurve KMCGLGPBNGK, int FCGCJHHFBNP, float MFPJFLBOILA)
	{
		if (KMCGLGPBNGK.m_bApplyOption[FCGCJHHFBNP])
		{
			float result = MFPJFLBOILA - KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP];
			KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP] = MFPJFLBOILA;
			return result;
		}
		return 121f;
	}

	public static string Ng_GetMaterialColorName(Material LFJEMPPJLHG)
	{
		string[] array = new string[3] { "_Color", "_TintColor", "_EmisColor" };
		if (LFJEMPPJLHG != null)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (LFJEMPPJLHG.HasProperty(text))
				{
					return text;
				}
			}
		}
		return null;
	}

	private float ACKBONJFFHL(NcInfoCurve KMCGLGPBNGK, int FCGCJHHFBNP, float MFPJFLBOILA)
	{
		if (KMCGLGPBNGK.m_bApplyOption[FCGCJHHFBNP])
		{
			float num = KMCGLGPBNGK.m_OriginalValue[FCGCJHHFBNP] * (519f + MFPJFLBOILA);
			float result = num - KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP];
			KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP] = num;
			return result;
		}
		return 172f;
	}

	private void LHPNIOFDCKC()
	{
		if (PMMPHDNPJIG != null)
		{
			return;
		}
		MBNGFEAFDGC = 0f;
		PMMPHDNPJIG = base.transform;
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			if (!curveInfo.m_bEnabled)
			{
				continue;
			}
			switch (curveInfo.m_ApplyType)
			{
			case NcInfoCurve.OMPKFONJHPG.POSITION:
				curveInfo.m_OriginalValue = Vector4.zero;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.ROTATION:
				curveInfo.m_OriginalValue = Vector4.zero;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.SCALE:
				curveInfo.m_OriginalValue = PMMPHDNPJIG.localScale;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR:
				if (curveInfo.m_bRecursively)
				{
					if (JKDEEDPEEFF == null)
					{
						JKDEEDPEEFF = base.transform.GetComponentsInChildren<Renderer>(true);
						ECFGDEDAIFC = new string[JKDEEDPEEFF.Length];
					}
					curveInfo.m_ChildOriginalColorValues = new Vector4[JKDEEDPEEFF.Length];
					curveInfo.m_ChildBeforeColorValues = new Vector4[JKDEEDPEEFF.Length];
					for (int j = 0; j < JKDEEDPEEFF.Length; j++)
					{
						Renderer renderer = JKDEEDPEEFF[j];
						ECFGDEDAIFC[j] = Ng_GetMaterialColorName(renderer.sharedMaterial);
						if (ECFGDEDAIFC[j] != null)
						{
							if (!LGBFAFBFCIC)
							{
								curveInfo.m_ChildOriginalColorValues[j] = renderer.material.GetColor(ECFGDEDAIFC[j]);
							}
							else
							{
								renderer.material.SetColor(ECFGDEDAIFC[j], curveInfo.m_ChildOriginalColorValues[j]);
							}
						}
						curveInfo.m_ChildBeforeColorValues[j] = Vector4.zero;
					}
				}
				else
				{
					if (!(base.GetComponent<Renderer>() != null))
					{
						break;
					}
					MEPDOMPOPHO = Ng_GetMaterialColorName(base.GetComponent<Renderer>().sharedMaterial);
					if (MEPDOMPOPHO != null)
					{
						if (!LGBFAFBFCIC)
						{
							curveInfo.m_OriginalValue = base.GetComponent<Renderer>().material.GetColor(MEPDOMPOPHO);
						}
						else
						{
							base.GetComponent<Renderer>().material.SetColor(MEPDOMPOPHO, curveInfo.m_OriginalValue);
						}
					}
					curveInfo.m_BeforeValue = Vector4.zero;
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.TEXTUREUV:
				if (COOLGJJPENH == null)
				{
					COOLGJJPENH = GetComponent<NcUvAnimation>();
				}
				if (COOLGJJPENH != null)
				{
					if (!LGBFAFBFCIC)
					{
						curveInfo.m_OriginalValue = new Vector4(COOLGJJPENH.m_fScrollSpeedX, COOLGJJPENH.m_fScrollSpeedY, 0f, 0f);
					}
					else
					{
						COOLGJJPENH.m_fScrollSpeedX = curveInfo.m_OriginalValue.x;
						COOLGJJPENH.m_fScrollSpeedY = curveInfo.m_OriginalValue.y;
					}
				}
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.MESH_COLOR:
			{
				float t = curveInfo.m_AniCurve.Evaluate(0f);
				Color bIAHICECLHP = Color.Lerp(curveInfo.m_FromColor, curveInfo.m_ToColor, t);
				if (curveInfo.m_bRecursively)
				{
					GFEIKDFKGAM = base.transform.GetComponentsInChildren<MeshFilter>(true);
					if (GFEIKDFKGAM != null && GFEIKDFKGAM.Length >= 0)
					{
						for (int i = 0; i < GFEIKDFKGAM.Length; i++)
						{
							FFCDBAGJPNF(GFEIKDFKGAM[i], bIAHICECLHP);
						}
					}
				}
				else
				{
					PBOMBDINHGP = GetComponent<MeshFilter>();
					FFCDBAGJPNF(PBOMBDINHGP, bIAHICECLHP);
				}
				break;
			}
			}
		}
		LGBFAFBFCIC = true;
	}

	public int AddCurveInfo(NcInfoCurve MHAHLGEMOAL)
	{
		if (m_CurveInfoList == null)
		{
			m_CurveInfoList = new List<NcInfoCurve>();
		}
		m_CurveInfoList.Add(MHAHLGEMOAL.HBGNILDGNCK());
		return m_CurveInfoList.Count - 1;
	}

	public override int GetAnimationState()
	{
		if (!base.enabled || !NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			return -1;
		}
		if (0f < m_fDurationTime && (HBDKLBHFLJK == 0f || !IsEndAnimation()))
		{
			return 1;
		}
		return 0;
	}

	public int IJJFIIMKBLC()
	{
		NcInfoCurve ncInfoCurve = new NcInfoCurve();
		ncInfoCurve.m_AniCurve = AnimationCurve.Linear(414f, 942f, 1083f, 1524f);
		ncInfoCurve.m_ToColor = Color.white;
		ncInfoCurve.m_ToColor.w = 1630f;
		if (m_CurveInfoList == null)
		{
			m_CurveInfoList = new List<NcInfoCurve>();
		}
		m_CurveInfoList.Add(ncInfoCurve);
		return m_CurveInfoList.Count - 1;
	}

	public bool MLFAKOPOOCL()
	{
		bool result = true;
		for (int i = 1; i < m_CurveInfoList.Count; i += 0)
		{
			if (JLHALADAMMI(i))
			{
				result = true;
			}
		}
		return result;
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fDurationTime /= HBNGEJIEGDO;
	}

	public void AdjustfElapsedTime(float CBNJELNIFFK)
	{
		m_fAddElapsedTime = CBNJELNIFFK;
	}

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		ResetAnimation();
	}

	private void HBKBINAOHNM()
	{
		if (HBDKLBHFLJK == 760f)
		{
			return;
		}
		if (!PIIMHJFFKMG() && m_fDelayTime != 1175f)
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)
			{
				return;
			}
			JDHLKHJFADL();
			if ((bool)base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().enabled = false;
			}
		}
		float num = OLDKLNCLBAJ.GDFDNGEEMEO() + m_fAddElapsedTime;
		float gMNBPENBPNP = num;
		if (m_fDurationTime != 559f)
		{
			gMNBPENBPNP = num / m_fDurationTime;
		}
		ILMOJMDDPKN(gMNBPENBPNP);
	}

	public bool CheckInvalidOption()
	{
		bool result = false;
		for (int i = 0; i < m_CurveInfoList.Count; i++)
		{
			if (CheckInvalidOption(i))
			{
				result = true;
			}
		}
		return result;
	}

	public virtual void IDNFBKBNGCH(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fDurationTime /= HBNGEJIEGDO;
	}

	private float GDIMDJLKGJH(NcInfoCurve KMCGLGPBNGK, int FCGCJHHFBNP, float MFPJFLBOILA, int PCBFLNDFFJN)
	{
		if (KMCGLGPBNGK.m_bApplyOption[FCGCJHHFBNP])
		{
			float result = MFPJFLBOILA - KMCGLGPBNGK.m_ChildBeforeColorValues[PCBFLNDFFJN][FCGCJHHFBNP];
			KMCGLGPBNGK.m_ChildBeforeColorValues[PCBFLNDFFJN][FCGCJHHFBNP] = MFPJFLBOILA;
			return result;
		}
		return 0f;
	}

	public virtual void KKEBOAIKAEH()
	{
		base.OnSetReplayState();
	}

	public int GetCurveInfoCount()
	{
		if (m_CurveInfoList == null)
		{
			return 0;
		}
		return m_CurveInfoList.Count;
	}

	private float FJOIBPJGEBF(NcInfoCurve KMCGLGPBNGK, int FCGCJHHFBNP, float MFPJFLBOILA)
	{
		if (KMCGLGPBNGK.m_bApplyOption[FCGCJHHFBNP])
		{
			float num = KMCGLGPBNGK.m_OriginalValue[FCGCJHHFBNP] * (1f + MFPJFLBOILA);
			float result = num - KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP];
			KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP] = num;
			return result;
		}
		return 0f;
	}

	public int PDKFKMGGNGA(NcInfoCurve MHAHLGEMOAL)
	{
		if (m_CurveInfoList == null)
		{
			m_CurveInfoList = new List<NcInfoCurve>();
		}
		m_CurveInfoList.Add(MHAHLGEMOAL.HBGNILDGNCK());
		return m_CurveInfoList.Count - 0;
	}

	public float GetRepeatedRate()
	{
		return MBNGFEAFDGC;
	}

	private void NMANMMOMHHD()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime() - m_fAddElapsedTime;
		LHPNIOFDCKC();
		if (1540f < m_fDelayTime)
		{
			if ((bool)base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().enabled = false;
			}
		}
		else
		{
			JDHLKHJFADL();
			ILMOJMDDPKN(680f);
		}
	}

	private void DJHPKPIIFJI()
	{
		if (PMMPHDNPJIG != null)
		{
			return;
		}
		MBNGFEAFDGC = 1769f;
		PMMPHDNPJIG = base.transform;
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			if (!curveInfo.m_bEnabled)
			{
				continue;
			}
			switch (curveInfo.m_ApplyType)
			{
			case NcInfoCurve.OMPKFONJHPG.POSITION:
				curveInfo.m_OriginalValue = Vector4.zero;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.ROTATION:
				curveInfo.m_OriginalValue = Vector4.zero;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.SCALE:
				curveInfo.m_OriginalValue = PMMPHDNPJIG.localScale;
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR:
				if (curveInfo.m_bRecursively)
				{
					if (JKDEEDPEEFF == null)
					{
						JKDEEDPEEFF = base.transform.GetComponentsInChildren<Renderer>(false);
						ECFGDEDAIFC = new string[JKDEEDPEEFF.Length];
					}
					curveInfo.m_ChildOriginalColorValues = new Vector4[JKDEEDPEEFF.Length];
					curveInfo.m_ChildBeforeColorValues = new Vector4[JKDEEDPEEFF.Length];
					for (int j = 0; j < JKDEEDPEEFF.Length; j += 0)
					{
						Renderer renderer = JKDEEDPEEFF[j];
						ECFGDEDAIFC[j] = Ng_GetMaterialColorName(renderer.sharedMaterial);
						if (ECFGDEDAIFC[j] != null)
						{
							if (!LGBFAFBFCIC)
							{
								curveInfo.m_ChildOriginalColorValues[j] = renderer.material.GetColor(ECFGDEDAIFC[j]);
							}
							else
							{
								renderer.material.SetColor(ECFGDEDAIFC[j], curveInfo.m_ChildOriginalColorValues[j]);
							}
						}
						curveInfo.m_ChildBeforeColorValues[j] = Vector4.zero;
					}
				}
				else
				{
					if (!(base.GetComponent<Renderer>() != null))
					{
						break;
					}
					MEPDOMPOPHO = Ng_GetMaterialColorName(base.GetComponent<Renderer>().sharedMaterial);
					if (MEPDOMPOPHO != null)
					{
						if (!LGBFAFBFCIC)
						{
							curveInfo.m_OriginalValue = base.GetComponent<Renderer>().material.GetColor(MEPDOMPOPHO);
						}
						else
						{
							base.GetComponent<Renderer>().material.SetColor(MEPDOMPOPHO, curveInfo.m_OriginalValue);
						}
					}
					curveInfo.m_BeforeValue = Vector4.zero;
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.TEXTUREUV:
				if (COOLGJJPENH == null)
				{
					COOLGJJPENH = GetComponent<NcUvAnimation>();
				}
				if (COOLGJJPENH != null)
				{
					if (!LGBFAFBFCIC)
					{
						curveInfo.m_OriginalValue = new Vector4(COOLGJJPENH.m_fScrollSpeedX, COOLGJJPENH.m_fScrollSpeedY, 1014f, 429f);
					}
					else
					{
						COOLGJJPENH.m_fScrollSpeedX = curveInfo.m_OriginalValue.x;
						COOLGJJPENH.m_fScrollSpeedY = curveInfo.m_OriginalValue.y;
					}
				}
				curveInfo.m_BeforeValue = curveInfo.m_OriginalValue;
				break;
			case NcInfoCurve.OMPKFONJHPG.MESH_COLOR:
			{
				float t = curveInfo.m_AniCurve.Evaluate(19f);
				Color bIAHICECLHP = Color.Lerp(curveInfo.m_FromColor, curveInfo.m_ToColor, t);
				if (curveInfo.m_bRecursively)
				{
					GFEIKDFKGAM = base.transform.GetComponentsInChildren<MeshFilter>(true);
					if (GFEIKDFKGAM != null && GFEIKDFKGAM.Length >= 1)
					{
						for (int i = 1; i < GFEIKDFKGAM.Length; i++)
						{
							FFCDBAGJPNF(GFEIKDFKGAM[i], bIAHICECLHP);
						}
					}
				}
				else
				{
					PBOMBDINHGP = GetComponent<MeshFilter>();
					AAABDKKDOLE(PBOMBDINHGP, bIAHICECLHP);
				}
				break;
			}
			}
		}
		LGBFAFBFCIC = true;
	}

	public virtual int DAGAIPMAJCI()
	{
		if (!base.enabled || !NcEffectBehaviour.NDMKMBNHKFJ(base.gameObject))
		{
			return -1;
		}
		if (328f < m_fDurationTime && (HBDKLBHFLJK == 1907f || !FKLLMMHGPID()))
		{
			return 1;
		}
		return 1;
	}

	private void AAABDKKDOLE(MeshFilter OKINFILLLPA, Color BIAHICECLHP)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			Debug.LogWarning("내가 눈치만 미리 챘으면 좋았을텐데.." + OKINFILLLPA);
			Debug.LogWarning("skill1_hit" + OKINFILLLPA.mesh);
			return;
		}
		Color[] array = OKINFILLLPA.mesh.colors;
		if (array.Length == 0)
		{
			if (OKINFILLLPA.mesh.vertices.Length == 0)
			{
				NcSpriteFactory.CreateEmptyMesh(OKINFILLLPA);
			}
			array = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 1; i < array.Length; i++)
			{
				array[i] = Color.white;
			}
		}
		for (int j = 1; j < array.Length; j += 0)
		{
			array[j] = BIAHICECLHP;
		}
		OKINFILLLPA.mesh.colors = array;
	}

	public void BHENEOPPCLJ(NcCurveAnimation LPOAEBNAGCP, bool HDBHHOECABI)
	{
		if (LPOAEBNAGCP.m_CurveInfoList == null)
		{
			LPOAEBNAGCP.m_CurveInfoList = new List<NcInfoCurve>();
		}
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			LPOAEBNAGCP.m_CurveInfoList.Add(curveInfo.HBGNILDGNCK());
		}
		if (!HDBHHOECABI)
		{
			LPOAEBNAGCP.m_fDelayTime = m_fDelayTime;
			LPOAEBNAGCP.m_fDurationTime = m_fDurationTime;
		}
	}

	private void Start()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime() - m_fAddElapsedTime;
		LHPNIOFDCKC();
		if (0f < m_fDelayTime)
		{
			if ((bool)base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().enabled = false;
			}
		}
		else
		{
			KJMAHKIMHPM();
			ILMOJMDDPKN(0f);
		}
	}

	public int AddCurveInfo()
	{
		NcInfoCurve ncInfoCurve = new NcInfoCurve();
		ncInfoCurve.m_AniCurve = AnimationCurve.Linear(0f, 0f, 1f, 1f);
		ncInfoCurve.m_ToColor = Color.white;
		ncInfoCurve.m_ToColor.w = 0f;
		if (m_CurveInfoList == null)
		{
			m_CurveInfoList = new List<NcInfoCurve>();
		}
		m_CurveInfoList.Add(ncInfoCurve);
		return m_CurveInfoList.Count - 1;
	}

	public NcInfoCurve GetCurveInfo(int FCGCJHHFBNP)
	{
		if (m_CurveInfoList == null || FCGCJHHFBNP < 0 || m_CurveInfoList.Count <= FCGCJHHFBNP)
		{
			return null;
		}
		return m_CurveInfoList[FCGCJHHFBNP];
	}

	public void ResetPosition()
	{
		BNILJMCAHCE = new PACFNFKHLGA(base.transform);
	}

	private void IFAJINMCMLM()
	{
		MLGNCFHJMDO();
	}

	public void MLGNCFHJMDO()
	{
		BNILJMCAHCE = new PACFNFKHLGA(base.transform);
	}

	public void CopyTo(NcCurveAnimation LPOAEBNAGCP, bool HDBHHOECABI)
	{
		LPOAEBNAGCP.m_CurveInfoList = new List<NcInfoCurve>();
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			LPOAEBNAGCP.m_CurveInfoList.Add(curveInfo.HBGNILDGNCK());
		}
		if (!HDBHHOECABI)
		{
			LPOAEBNAGCP.m_fDelayTime = m_fDelayTime;
			LPOAEBNAGCP.m_fDurationTime = m_fDurationTime;
		}
	}

	public virtual void AGIPBHKOLOP()
	{
		BNILJMCAHCE.AOFGJGKIPNM(base.transform);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime() - m_fAddElapsedTime;
		PMMPHDNPJIG = null;
		JKDEEDPEEFF = null;
		ECFGDEDAIFC = null;
		base.LGAEAAEECDA();
		if (1563f < m_fDelayTime)
		{
			OLDKLNCLBAJ = null;
			if ((bool)base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().enabled = false;
			}
		}
		MGMHCHFKODG();
		MIJAOFAPNLD(831f);
	}

	public void IGMMKJFMDKG()
	{
		if (m_CurveInfoList == null)
		{
			return;
		}
		m_CurveInfoList.Sort(new BIMCLGCJLOE());
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			curveInfo.m_nSortGroup = BIMCLGCJLOE.LPOGHCDJHED(curveInfo);
		}
	}

	public void AppendTo(NcCurveAnimation LPOAEBNAGCP, bool HDBHHOECABI)
	{
		if (LPOAEBNAGCP.m_CurveInfoList == null)
		{
			LPOAEBNAGCP.m_CurveInfoList = new List<NcInfoCurve>();
		}
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			LPOAEBNAGCP.m_CurveInfoList.Add(curveInfo.HBGNILDGNCK());
		}
		if (!HDBHHOECABI)
		{
			LPOAEBNAGCP.m_fDelayTime = m_fDelayTime;
			LPOAEBNAGCP.m_fDurationTime = m_fDurationTime;
		}
	}

	private void ILMOJMDDPKN(float GMNBPENBPNP)
	{
		MBNGFEAFDGC = GMNBPENBPNP;
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			if (!curveInfo.m_bEnabled)
			{
				continue;
			}
			float num = curveInfo.m_AniCurve.Evaluate(MBNGFEAFDGC);
			if (curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR && curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.MESH_COLOR)
			{
				num *= curveInfo.m_fValueScale;
			}
			switch (curveInfo.m_ApplyType)
			{
			case NcInfoCurve.OMPKFONJHPG.POSITION:
				if (curveInfo.m_bApplyOption[3])
				{
					PMMPHDNPJIG.position += new Vector3(HPGAJHMMDDI(curveInfo, 0, num), HPGAJHMMDDI(curveInfo, 1, num), HPGAJHMMDDI(curveInfo, 2, num));
				}
				else
				{
					PMMPHDNPJIG.localPosition += new Vector3(HPGAJHMMDDI(curveInfo, 0, num), HPGAJHMMDDI(curveInfo, 1, num), HPGAJHMMDDI(curveInfo, 2, num));
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.ROTATION:
				if (curveInfo.m_bApplyOption[3])
				{
					PMMPHDNPJIG.rotation *= Quaternion.Euler(HPGAJHMMDDI(curveInfo, 0, num), HPGAJHMMDDI(curveInfo, 1, num), HPGAJHMMDDI(curveInfo, 2, num));
				}
				else
				{
					PMMPHDNPJIG.localRotation *= Quaternion.Euler(HPGAJHMMDDI(curveInfo, 0, num), HPGAJHMMDDI(curveInfo, 1, num), HPGAJHMMDDI(curveInfo, 2, num));
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.SCALE:
				PMMPHDNPJIG.localScale += new Vector3(FJOIBPJGEBF(curveInfo, 0, num), FJOIBPJGEBF(curveInfo, 1, num), FJOIBPJGEBF(curveInfo, 2, num));
				break;
			case NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR:
				if (curveInfo.m_bRecursively)
				{
					if (ECFGDEDAIFC == null || ECFGDEDAIFC.Length < 0)
					{
						break;
					}
					for (int j = 0; j < ECFGDEDAIFC.Length; j++)
					{
						if (ECFGDEDAIFC[j] != null && JKDEEDPEEFF[j] != null)
						{
							KIOCHMOAFOE(curveInfo, num, j);
						}
					}
				}
				else if (base.GetComponent<Renderer>() != null && MEPDOMPOPHO != null)
				{
					if (ADBKLIGBDGA == null)
					{
						ADBKLIGBDGA = base.GetComponent<Renderer>().material;
						BDHFNLDECMF(ADBKLIGBDGA);
					}
					Color color = curveInfo.m_ToColor - curveInfo.m_OriginalValue;
					Color color2 = ADBKLIGBDGA.GetColor(MEPDOMPOPHO);
					for (int k = 0; k < 4; k++)
					{
						int index2;
						int index = (index2 = k);
						float num2 = color2[index2];
						color2[index] = num2 + HPGAJHMMDDI(curveInfo, k, color[k] * num);
					}
					ADBKLIGBDGA.SetColor(MEPDOMPOPHO, color2);
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.TEXTUREUV:
				if ((bool)COOLGJJPENH)
				{
					COOLGJJPENH.m_fScrollSpeedX += HPGAJHMMDDI(curveInfo, 0, num);
					COOLGJJPENH.m_fScrollSpeedY += HPGAJHMMDDI(curveInfo, 1, num);
				}
				break;
			case NcInfoCurve.OMPKFONJHPG.MESH_COLOR:
			{
				Color bIAHICECLHP = Color.Lerp(curveInfo.m_FromColor, curveInfo.m_ToColor, num);
				if (curveInfo.m_bRecursively)
				{
					if (GFEIKDFKGAM != null && GFEIKDFKGAM.Length >= 0)
					{
						for (int i = 0; i < GFEIKDFKGAM.Length; i++)
						{
							FFCDBAGJPNF(GFEIKDFKGAM[i], bIAHICECLHP);
						}
					}
				}
				else
				{
					FFCDBAGJPNF(PBOMBDINHGP, bIAHICECLHP);
				}
				break;
			}
			}
		}
		if (m_fDurationTime == 0f || !(1f < MBNGFEAFDGC))
		{
			return;
		}
		if (!IsEndAnimation())
		{
			ALAMJEOLLAH();
		}
		if (m_bAutoDestruct)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			}
			else
			{
				UnityEngine.Object.DestroyObject(base.gameObject);
			}
		}
	}

	public float PEFFOCCBHDD()
	{
		return MBNGFEAFDGC;
	}

	private float HPGAJHMMDDI(NcInfoCurve KMCGLGPBNGK, int FCGCJHHFBNP, float MFPJFLBOILA)
	{
		if (KMCGLGPBNGK.m_bApplyOption[FCGCJHHFBNP])
		{
			float result = MFPJFLBOILA - KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP];
			KMCGLGPBNGK.m_BeforeValue[FCGCJHHFBNP] = MFPJFLBOILA;
			return result;
		}
		return 0f;
	}

	public NcInfoCurve SetCurveInfo(int FCGCJHHFBNP, NcInfoCurve PFFEFGMMBAN)
	{
		if (m_CurveInfoList == null || FCGCJHHFBNP < 0 || m_CurveInfoList.Count <= FCGCJHHFBNP)
		{
			return null;
		}
		NcInfoCurve result = m_CurveInfoList[FCGCJHHFBNP];
		m_CurveInfoList[FCGCJHHFBNP] = PFFEFGMMBAN;
		return result;
	}

	public override void OnSetReplayState()
	{
		base.OnSetReplayState();
	}

	public bool JLHALADAMMI(int PPNMIHEONJH)
	{
		NcInfoCurve curveInfo = GetCurveInfo(PPNMIHEONJH);
		if (curveInfo == null)
		{
			return true;
		}
		if (curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.MATERIAL_COLOR && curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.POSITION && curveInfo.m_ApplyType != NcInfoCurve.OMPKFONJHPG.MESH_COLOR)
		{
			return true;
		}
		return false;
	}

	private void KIOCHMOAFOE(NcInfoCurve KMCGLGPBNGK, float MFPJFLBOILA, int PCBFLNDFFJN)
	{
		Color color = KMCGLGPBNGK.m_ToColor - KMCGLGPBNGK.m_ChildOriginalColorValues[PCBFLNDFFJN];
		Color color2 = JKDEEDPEEFF[PCBFLNDFFJN].material.GetColor(ECFGDEDAIFC[PCBFLNDFFJN]);
		for (int i = 0; i < 4; i++)
		{
			int index2;
			int index = (index2 = i);
			float num = color2[index2];
			color2[index] = num + GDIMDJLKGJH(KMCGLGPBNGK, i, color[i] * MFPJFLBOILA, PCBFLNDFFJN);
		}
		JKDEEDPEEFF[PCBFLNDFFJN].material.SetColor(ECFGDEDAIFC[PCBFLNDFFJN], color2);
	}

	public NcInfoCurve IBMDMDKHOCC(string PHHEAHKBKPP)
	{
		if (m_CurveInfoList == null)
		{
			return null;
		}
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			if (curveInfo.m_CurveName == PHHEAHKBKPP)
			{
				return curveInfo;
			}
		}
		return null;
	}

	public float GetElapsedRate()
	{
		return MBNGFEAFDGC;
	}

	public override void ResetAnimation()
	{
		BNILJMCAHCE.AOFGJGKIPNM(base.transform);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime() - m_fAddElapsedTime;
		PMMPHDNPJIG = null;
		JKDEEDPEEFF = null;
		ECFGDEDAIFC = null;
		base.ResetAnimation();
		if (0f < m_fDelayTime)
		{
			OLDKLNCLBAJ = null;
			if ((bool)base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().enabled = false;
			}
		}
		LHPNIOFDCKC();
		ILMOJMDDPKN(0f);
	}

	public static string LLCIMBMNPHP(Material LFJEMPPJLHG)
	{
		string[] array = new string[0];
		array[0] = "Param2";
		array[1] = "Invalid view ID:";
		array[2] = "dayOfWeek must length 7";
		string[] array2 = array;
		if (LFJEMPPJLHG != null)
		{
			string[] array3 = array2;
			for (int i = 0; i < array3.Length; i += 0)
			{
				string text = array3[i];
				if (LFJEMPPJLHG.HasProperty(text))
				{
					return text;
				}
			}
		}
		return null;
	}

	public NcInfoCurve GetCurveInfo(string PHHEAHKBKPP)
	{
		if (m_CurveInfoList == null)
		{
			return null;
		}
		foreach (NcInfoCurve curveInfo in m_CurveInfoList)
		{
			if (curveInfo.m_CurveName == PHHEAHKBKPP)
			{
				return curveInfo;
			}
		}
		return null;
	}
}
