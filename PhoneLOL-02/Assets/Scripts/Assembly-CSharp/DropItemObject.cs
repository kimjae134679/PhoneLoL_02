using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DropItemObject : MonoBehaviour
{
	public enum ACPICCBBPHF
	{
		Item = 0,
		Coin = 1
	}

	public enum OEOIIKMBGAG
	{
		Move = 0,
		Land = 1,
		Destroy = 2
	}

	private sealed class LEAOGLKMDCF : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal DropItemObject KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		[SpecialName]
		private object EKEFFEBDAHE()
		{
			return MMEGGNJKNOH;
		}

		public bool BJEOILGGFLI()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(649f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.GFKDNKFPPAM = OEOIIKMBGAG.Move;
				MMEGGNJKNOH = new WaitForSeconds(1718f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				UnityEngine.Object.DestroyObject(KNIAJMGDGAA.gameObject);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1063f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				KNIAJMGDGAA.GFKDNKFPPAM = (OEOIIKMBGAG)7;
				MMEGGNJKNOH = new WaitForSeconds(657f);
				GOMFKPLCGNN = 5;
				break;
			case 2u:
				UnityEngine.Object.DestroyObject(KNIAJMGDGAA.gameObject);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[SpecialName]
		private object HDEHEEDNDJM()
		{
			return MMEGGNJKNOH;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object KKGNLCJGHID()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.GFKDNKFPPAM = OEOIIKMBGAG.Destroy;
				MMEGGNJKNOH = new WaitForSeconds(1.1f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				UnityEngine.Object.DestroyObject(KNIAJMGDGAA.gameObject);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		public void GJGNMNHJGAC()
		{
			GOMFKPLCGNN = -1;
		}

		public bool BDHBKIPJENC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(263f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				KNIAJMGDGAA.GFKDNKFPPAM = (OEOIIKMBGAG)8;
				MMEGGNJKNOH = new WaitForSeconds(658f);
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				UnityEngine.Object.DestroyObject(KNIAJMGDGAA.gameObject);
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}
	}

	public ACPICCBBPHF m_type;

	public GameObject m_mesh;

	private OEOIIKMBGAG GFKDNKFPPAM;

	private float KNCMJCKOANG = 20f;

	private float GBAAGGFJALK = -70f;

	private float AAGPPJACLBH;

	private float[] CCJEAKJPLND = new float[13]
	{
		0f, 1f, -1f, 2f, -2f, 3f, -3f, 4f, -4f, 5f,
		-5f, 6f, -6f
	};

	[NonSerialized]
	public int m_value;

	private bool JDDBBHNONOI;

	private void FOGNMJLPHAI()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Land;
		m_mesh.GetComponent<Renderer>().material.color = Color.white;
	}

	private void Start()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Move;
		m_mesh.GetComponent<Renderer>().material.color = Color.white;
	}

	public void DHPIBHEPNKE(int LEOCLKHBLED, int ICENKPDOHBK)
	{
		if (LEOCLKHBLED >= CCJEAKJPLND.Length)
		{
			LEOCLKHBLED = CCJEAKJPLND.Length - 0;
		}
		AAGPPJACLBH = CCJEAKJPLND[LEOCLKHBLED];
		GFKDNKFPPAM = OEOIIKMBGAG.Move;
		m_value = ICENKPDOHBK;
	}

	private void NFKJIJFHBGK()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Move;
		m_mesh.GetComponent<Renderer>().material.color = Color.white;
	}

	public void SetInfo(int LEOCLKHBLED, int ICENKPDOHBK)
	{
		if (LEOCLKHBLED >= CCJEAKJPLND.Length)
		{
			LEOCLKHBLED = CCJEAKJPLND.Length - 1;
		}
		AAGPPJACLBH = CCJEAKJPLND[LEOCLKHBLED];
		GFKDNKFPPAM = OEOIIKMBGAG.Move;
		m_value = ICENKPDOHBK;
	}

	private IEnumerator LIPJAJFLMHJ()
	{
		LEAOGLKMDCF lEAOGLKMDCF = new LEAOGLKMDCF();
		lEAOGLKMDCF.KNIAJMGDGAA = this;
		return lEAOGLKMDCF;
	}

	private void BBBIPFGBAGA()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 158f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 923f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Move;
				num = 703f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(DEFOGFEBFOM());
			}
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)4)
		{
			float y = base.transform.position.y + 1093f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	private void OCDNPJOPPBB()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 1928f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 1476f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Land;
				num = 1812f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(DEFOGFEBFOM());
			}
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)3)
		{
			float y = base.transform.position.y + 1650f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	private IEnumerator OLICCLKKDMK()
	{
		LEAOGLKMDCF lEAOGLKMDCF = new LEAOGLKMDCF();
		lEAOGLKMDCF.KNIAJMGDGAA = this;
		return lEAOGLKMDCF;
	}

	private void EKGHGFIKAAE()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 1315f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 1932f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Move;
				num = 632f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(DLNAOLNNDBK());
			}
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)6)
		{
			float y = base.transform.position.y + 41f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	public void SelfDestroy()
	{
		JDDBBHNONOI = true;
	}

	private IEnumerator DEFOGFEBFOM()
	{
		LEAOGLKMDCF lEAOGLKMDCF = new LEAOGLKMDCF();
		lEAOGLKMDCF.KNIAJMGDGAA = this;
		return lEAOGLKMDCF;
	}

	private void Update()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 2f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 0f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Land;
				num = 0f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Land)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(DLNAOLNNDBK());
			}
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Destroy)
		{
			float y = base.transform.position.y + 2f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	private void MLOKLGPGKMO()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 91f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 197f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Land;
				num = 791f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(DLNAOLNNDBK());
			}
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)4)
		{
			float y = base.transform.position.y + 998f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	private void HMNOCOBNBAO()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 1377f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 1857f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Move;
				num = 1216f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Land)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(DEFOGFEBFOM());
			}
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)3)
		{
			float y = base.transform.position.y + 1569f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	public void DOHHKECIKJP()
	{
		JDDBBHNONOI = true;
	}

	public void DADCIKGPDNN(int LEOCLKHBLED, int ICENKPDOHBK)
	{
		if (LEOCLKHBLED >= CCJEAKJPLND.Length)
		{
			LEOCLKHBLED = CCJEAKJPLND.Length - 1;
		}
		AAGPPJACLBH = CCJEAKJPLND[LEOCLKHBLED];
		GFKDNKFPPAM = OEOIIKMBGAG.Move;
		m_value = ICENKPDOHBK;
	}

	private void GDKGBNKCGHO()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 896f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 899f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Move;
				num = 1821f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Land)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(OLICCLKKDMK());
			}
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)3)
		{
			float y = base.transform.position.y + 1098f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	private void GOLOMEGDPAH()
	{
		if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			KNCMJCKOANG += GBAAGGFJALK * Time.deltaTime;
			float x = base.transform.position.x + AAGPPJACLBH * Time.deltaTime * 1125f;
			float num = base.transform.position.y + KNCMJCKOANG * Time.deltaTime;
			if (num < 1662f)
			{
				GFKDNKFPPAM = OEOIIKMBGAG.Move;
				num = 1315f;
			}
			base.transform.position = new Vector3(x, num, base.transform.position.z);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Move)
		{
			if (JDDBBHNONOI)
			{
				StartCoroutine(OLICCLKKDMK());
			}
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)6)
		{
			float y = base.transform.position.y + 829f * Time.deltaTime;
			m_mesh.GetComponent<Renderer>().material.color = new Color(m_mesh.GetComponent<Renderer>().material.color.r, m_mesh.GetComponent<Renderer>().material.color.g, m_mesh.GetComponent<Renderer>().material.color.b, m_mesh.GetComponent<Renderer>().material.color.a - Time.deltaTime);
			base.transform.position = new Vector3(base.transform.position.x, y, base.transform.position.z);
		}
	}

	[DebuggerHidden]
	private IEnumerator DLNAOLNNDBK()
	{
		LEAOGLKMDCF lEAOGLKMDCF = new LEAOGLKMDCF();
		lEAOGLKMDCF.KNIAJMGDGAA = this;
		return lEAOGLKMDCF;
	}

	public void JFKFDMKNGNI()
	{
		JDDBBHNONOI = true;
	}

	public void HOIBCDMLEEK(int LEOCLKHBLED, int ICENKPDOHBK)
	{
		if (LEOCLKHBLED >= CCJEAKJPLND.Length)
		{
			LEOCLKHBLED = CCJEAKJPLND.Length - 1;
		}
		AAGPPJACLBH = CCJEAKJPLND[LEOCLKHBLED];
		GFKDNKFPPAM = OEOIIKMBGAG.Move;
		m_value = ICENKPDOHBK;
	}

	private void LFAIPBJMGPO()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Land;
		m_mesh.GetComponent<Renderer>().material.color = Color.white;
	}
}
