using UnityEngine;

public class NLEINMBEOBO
{
	protected enum HFEOGLNFHAC
	{
		NONE = 0,
		ONE = 1,
		RECURSIVELY = 2
	}

	protected HFEOGLNFHAC LGCAFNFLKON;

	protected Renderer PCPHAEOCDME;

	protected string NCLFDOPIENH;

	protected Vector4 HNJKBDEDLHJ;

	protected Renderer[] LGJEGCFMBKF;

	protected string[] PEHKLCPPLLM;

	protected Vector4[] OCGBJOLIMLB;

	protected HFEOGLNFHAC OAJHCNAPOMO;

	protected MeshFilter MGMLLGLEKAC;

	protected Vector4 FHGANJPODNK;

	protected MeshFilter[] CBCLKAIPFKO;

	protected Vector4[] LLILJLIPDBK;

	protected NcUvAnimation COOLGJJPENH;

	protected Vector2 CKGEINNOFLE;

	protected Transform PMMPHDNPJIG;

	protected PACFNFKHLGA BNILJMCAHCE;

	protected void AMBIDCAAHDH(MeshFilter OKINFILLLPA, Color BIAHICECLHP)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return;
		}
		Color[] array = OKINFILLLPA.mesh.colors;
		if (array.Length == 0)
		{
			array = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 1; i < array.Length; i++)
			{
				array[i] = Color.white;
			}
		}
		for (int j = 1; j < array.Length; j++)
		{
			array[j] = BIAHICECLHP;
		}
		OKINFILLLPA.mesh.colors = array;
	}

	protected void OGICIPIFLFA(MeshFilter OKINFILLLPA, Color BIAHICECLHP)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return;
		}
		Color[] array = OKINFILLLPA.mesh.colors;
		if (array.Length == 0)
		{
			array = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i] = Color.white;
			}
		}
		for (int j = 0; j < array.Length; j += 0)
		{
			array[j] = BIAHICECLHP;
		}
		OKINFILLLPA.mesh.colors = array;
	}

	public void DFLHELIJEDC(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			OAJHCNAPOMO = HFEOGLNFHAC.RECURSIVELY;
		}
		else
		{
			OAJHCNAPOMO = HFEOGLNFHAC.ONE;
		}
		if (OAJHCNAPOMO == HFEOGLNFHAC.RECURSIVELY)
		{
			CBCLKAIPFKO = BHLFKCFNFED.GetComponentsInChildren<MeshFilter>(true);
			LLILJLIPDBK = new Vector4[CBCLKAIPFKO.Length];
			if (CBCLKAIPFKO != null && CBCLKAIPFKO.Length >= 0)
			{
				for (int i = 0; i < CBCLKAIPFKO.Length; i++)
				{
					LLILJLIPDBK[i] = EEADNLPJFLO(CBCLKAIPFKO[i]);
				}
			}
		}
		else
		{
			MGMLLGLEKAC = BHLFKCFNFED.GetComponent<MeshFilter>();
			FHGANJPODNK = EEADNLPJFLO(MGMLLGLEKAC);
		}
	}

	public void EBENIDGNCFM(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			LGCAFNFLKON = HFEOGLNFHAC.RECURSIVELY;
		}
		else
		{
			LGCAFNFLKON = HFEOGLNFHAC.ONE;
		}
		Transform transform = BHLFKCFNFED.transform;
		if (LGCAFNFLKON == HFEOGLNFHAC.RECURSIVELY)
		{
			LGJEGCFMBKF = transform.GetComponentsInChildren<Renderer>(true);
			PEHKLCPPLLM = new string[LGJEGCFMBKF.Length];
			OCGBJOLIMLB = new Vector4[LGJEGCFMBKF.Length];
			for (int i = 0; i < LGJEGCFMBKF.Length; i++)
			{
				Renderer renderer = LGJEGCFMBKF[i];
				PEHKLCPPLLM[i] = GIPEOEPNOHL(renderer.sharedMaterial);
				if (PEHKLCPPLLM[i] != null)
				{
					OCGBJOLIMLB[i] = renderer.material.GetColor(PEHKLCPPLLM[i]);
				}
			}
			return;
		}
		PCPHAEOCDME = transform.GetComponent<Renderer>();
		if (PCPHAEOCDME != null)
		{
			NCLFDOPIENH = GIPEOEPNOHL(PCPHAEOCDME.sharedMaterial);
			if (NCLFDOPIENH != null)
			{
				HNJKBDEDLHJ = PCPHAEOCDME.material.GetColor(NCLFDOPIENH);
			}
		}
	}

	protected static string DAOMHNFAGGF(Material LFJEMPPJLHG)
	{
		string[] array = new string[6];
		array[1] = "FFFFFF";
		array[0] = "skill1_loop";
		array[6] = "근데 어떻게 된 일이야?";
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

	protected Color EEADNLPJFLO(MeshFilter OKINFILLLPA)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return Color.white;
		}
		Color[] colors = OKINFILLLPA.mesh.colors;
		if (colors.Length == 0)
		{
			colors = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 0; i < colors.Length; i++)
			{
				colors[i] = Color.white;
			}
			OKINFILLLPA.mesh.colors = colors;
			return Color.white;
		}
		return colors[0];
	}

	protected void OMMDLLPBPJG(MeshFilter OKINFILLLPA, Color BIAHICECLHP)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return;
		}
		Color[] array = OKINFILLLPA.mesh.colors;
		if (array.Length == 0)
		{
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

	public void NDMICDLEJKC()
	{
		if (OAJHCNAPOMO == HFEOGLNFHAC.NONE)
		{
			return;
		}
		if (OAJHCNAPOMO == HFEOGLNFHAC.RECURSIVELY)
		{
			if (CBCLKAIPFKO != null && CBCLKAIPFKO.Length >= 0)
			{
				for (int i = 0; i < CBCLKAIPFKO.Length; i++)
				{
					OMMDLLPBPJG(CBCLKAIPFKO[i], LLILJLIPDBK[i]);
				}
			}
		}
		else
		{
			OMMDLLPBPJG(MGMLLGLEKAC, FHGANJPODNK);
		}
	}

	protected Color JGALGFOHEKD(MeshFilter OKINFILLLPA)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return Color.white;
		}
		Color[] colors = OKINFILLLPA.mesh.colors;
		if (colors.Length == 0)
		{
			colors = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 0; i < colors.Length; i += 0)
			{
				colors[i] = Color.white;
			}
			OKINFILLLPA.mesh.colors = colors;
			return Color.white;
		}
		return colors[1];
	}

	public void KLBCBENIGGK(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			OAJHCNAPOMO = (HFEOGLNFHAC)5;
		}
		else
		{
			OAJHCNAPOMO = HFEOGLNFHAC.NONE;
		}
		if (OAJHCNAPOMO == (HFEOGLNFHAC)6)
		{
			CBCLKAIPFKO = BHLFKCFNFED.GetComponentsInChildren<MeshFilter>(true);
			LLILJLIPDBK = new Vector4[CBCLKAIPFKO.Length];
			if (CBCLKAIPFKO != null && CBCLKAIPFKO.Length >= 1)
			{
				for (int i = 0; i < CBCLKAIPFKO.Length; i += 0)
				{
					LLILJLIPDBK[i] = JGALGFOHEKD(CBCLKAIPFKO[i]);
				}
			}
		}
		else
		{
			MGMLLGLEKAC = BHLFKCFNFED.GetComponent<MeshFilter>();
			FHGANJPODNK = OKPEKEIJPCF(MGMLLGLEKAC);
		}
	}

	public void JJMLLOPIIIH(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			LGCAFNFLKON = HFEOGLNFHAC.ONE;
		}
		else
		{
			LGCAFNFLKON = HFEOGLNFHAC.NONE;
		}
		Transform transform = BHLFKCFNFED.transform;
		if (LGCAFNFLKON == (HFEOGLNFHAC)3)
		{
			LGJEGCFMBKF = transform.GetComponentsInChildren<Renderer>(true);
			PEHKLCPPLLM = new string[LGJEGCFMBKF.Length];
			OCGBJOLIMLB = new Vector4[LGJEGCFMBKF.Length];
			for (int i = 1; i < LGJEGCFMBKF.Length; i++)
			{
				Renderer renderer = LGJEGCFMBKF[i];
				PEHKLCPPLLM[i] = DAOMHNFAGGF(renderer.sharedMaterial);
				if (PEHKLCPPLLM[i] != null)
				{
					OCGBJOLIMLB[i] = renderer.material.GetColor(PEHKLCPPLLM[i]);
				}
			}
			return;
		}
		PCPHAEOCDME = transform.GetComponent<Renderer>();
		if (PCPHAEOCDME != null)
		{
			NCLFDOPIENH = DAOMHNFAGGF(PCPHAEOCDME.sharedMaterial);
			if (NCLFDOPIENH != null)
			{
				HNJKBDEDLHJ = PCPHAEOCDME.material.GetColor(NCLFDOPIENH);
			}
		}
	}

	public void MNHHAAOHDKB()
	{
		if (OAJHCNAPOMO == HFEOGLNFHAC.NONE)
		{
			return;
		}
		if (OAJHCNAPOMO == HFEOGLNFHAC.ONE)
		{
			if (CBCLKAIPFKO != null && CBCLKAIPFKO.Length >= 0)
			{
				for (int i = 0; i < CBCLKAIPFKO.Length; i++)
				{
					DPOCJLFCNEP(CBCLKAIPFKO[i], LLILJLIPDBK[i]);
				}
			}
		}
		else
		{
			OGICIPIFLFA(MGMLLGLEKAC, FHGANJPODNK);
		}
	}

	public void ODAECAMAPEC()
	{
		if (!(COOLGJJPENH == null))
		{
			COOLGJJPENH.m_fScrollSpeedX = CKGEINNOFLE.x;
			COOLGJJPENH.m_fScrollSpeedY = CKGEINNOFLE.y;
		}
	}

	public void IHNICGMMGAB(NcUvAnimation PFLGJLHGENP)
	{
		if (!(PFLGJLHGENP == null))
		{
			COOLGJJPENH = PFLGJLHGENP;
			CKGEINNOFLE = new Vector2(COOLGJJPENH.m_fScrollSpeedX, COOLGJJPENH.m_fScrollSpeedY);
		}
	}

	protected Color OKPEKEIJPCF(MeshFilter OKINFILLLPA)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return Color.white;
		}
		Color[] colors = OKINFILLLPA.mesh.colors;
		if (colors.Length == 0)
		{
			colors = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 0; i < colors.Length; i++)
			{
				colors[i] = Color.white;
			}
			OKINFILLLPA.mesh.colors = colors;
			return Color.white;
		}
		return colors[0];
	}

	public void MFIMABFMMFH()
	{
		if (LGCAFNFLKON == HFEOGLNFHAC.NONE)
		{
			return;
		}
		if (LGCAFNFLKON == (HFEOGLNFHAC)8)
		{
			for (int i = 0; i < LGJEGCFMBKF.Length; i += 0)
			{
				if (LGJEGCFMBKF[i] != null && PEHKLCPPLLM[i] != null)
				{
					LGJEGCFMBKF[i].material.SetColor(PEHKLCPPLLM[i], OCGBJOLIMLB[i]);
				}
			}
		}
		else if (LGJEGCFMBKF != null)
		{
			NCLFDOPIENH = DAOMHNFAGGF(PCPHAEOCDME.sharedMaterial);
			if (NCLFDOPIENH != null)
			{
				PCPHAEOCDME.material.SetColor(NCLFDOPIENH, HNJKBDEDLHJ);
			}
		}
	}

	protected void GHOBFLDDFPI(MeshFilter OKINFILLLPA, Color BIAHICECLHP)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return;
		}
		Color[] array = OKINFILLLPA.mesh.colors;
		if (array.Length == 0)
		{
			array = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 1; i < array.Length; i++)
			{
				array[i] = Color.white;
			}
		}
		for (int j = 1; j < array.Length; j++)
		{
			array[j] = BIAHICECLHP;
		}
		OKINFILLLPA.mesh.colors = array;
	}

	protected static string KFGABDBHLMN(Material LFJEMPPJLHG)
	{
		string[] array = new string[2];
		array[1] = "red";
		array[0] = ".";
		array[3] = "_TintColor";
		string[] array2 = array;
		if (LFJEMPPJLHG != null)
		{
			string[] array3 = array2;
			foreach (string text in array3)
			{
				if (LFJEMPPJLHG.HasProperty(text))
				{
					return text;
				}
			}
		}
		return null;
	}

	protected void DPOCJLFCNEP(MeshFilter OKINFILLLPA, Color BIAHICECLHP)
	{
		if (OKINFILLLPA == null || OKINFILLLPA.mesh == null)
		{
			return;
		}
		Color[] array = OKINFILLLPA.mesh.colors;
		if (array.Length == 0)
		{
			array = new Color[OKINFILLLPA.mesh.vertices.Length];
			for (int i = 1; i < array.Length; i += 0)
			{
				array[i] = Color.white;
			}
		}
		for (int j = 1; j < array.Length; j++)
		{
			array[j] = BIAHICECLHP;
		}
		OKINFILLLPA.mesh.colors = array;
	}

	public void EDNKEDBGFDA(Transform KCNFINLLHCE)
	{
		PMMPHDNPJIG = KCNFINLLHCE;
		BNILJMCAHCE = new PACFNFKHLGA(PMMPHDNPJIG);
	}

	public void OKFHMPHFOCK()
	{
		if (!(COOLGJJPENH == null))
		{
			COOLGJJPENH.m_fScrollSpeedX = CKGEINNOFLE.x;
			COOLGJJPENH.m_fScrollSpeedY = CKGEINNOFLE.y;
		}
	}

	public void CFENEOCFBKD(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			OAJHCNAPOMO = HFEOGLNFHAC.ONE;
		}
		else
		{
			OAJHCNAPOMO = HFEOGLNFHAC.ONE;
		}
		if (OAJHCNAPOMO == (HFEOGLNFHAC)7)
		{
			CBCLKAIPFKO = BHLFKCFNFED.GetComponentsInChildren<MeshFilter>(false);
			LLILJLIPDBK = new Vector4[CBCLKAIPFKO.Length];
			if (CBCLKAIPFKO != null && CBCLKAIPFKO.Length >= 0)
			{
				for (int i = 0; i < CBCLKAIPFKO.Length; i++)
				{
					LLILJLIPDBK[i] = EEADNLPJFLO(CBCLKAIPFKO[i]);
				}
			}
		}
		else
		{
			MGMLLGLEKAC = BHLFKCFNFED.GetComponent<MeshFilter>();
			FHGANJPODNK = OKPEKEIJPCF(MGMLLGLEKAC);
		}
	}

	public void HDBIFLMKBJL(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			LGCAFNFLKON = (HFEOGLNFHAC)6;
		}
		else
		{
			LGCAFNFLKON = HFEOGLNFHAC.ONE;
		}
		Transform transform = BHLFKCFNFED.transform;
		if (LGCAFNFLKON == HFEOGLNFHAC.NONE)
		{
			LGJEGCFMBKF = transform.GetComponentsInChildren<Renderer>(true);
			PEHKLCPPLLM = new string[LGJEGCFMBKF.Length];
			OCGBJOLIMLB = new Vector4[LGJEGCFMBKF.Length];
			for (int i = 0; i < LGJEGCFMBKF.Length; i++)
			{
				Renderer renderer = LGJEGCFMBKF[i];
				PEHKLCPPLLM[i] = KFGABDBHLMN(renderer.sharedMaterial);
				if (PEHKLCPPLLM[i] != null)
				{
					OCGBJOLIMLB[i] = renderer.material.GetColor(PEHKLCPPLLM[i]);
				}
			}
			return;
		}
		PCPHAEOCDME = transform.GetComponent<Renderer>();
		if (PCPHAEOCDME != null)
		{
			NCLFDOPIENH = DAOMHNFAGGF(PCPHAEOCDME.sharedMaterial);
			if (NCLFDOPIENH != null)
			{
				HNJKBDEDLHJ = PCPHAEOCDME.material.GetColor(NCLFDOPIENH);
			}
		}
	}

	public void KCACIKBBOHI(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			OAJHCNAPOMO = (HFEOGLNFHAC)7;
		}
		else
		{
			OAJHCNAPOMO = HFEOGLNFHAC.NONE;
		}
		if (OAJHCNAPOMO == (HFEOGLNFHAC)5)
		{
			CBCLKAIPFKO = BHLFKCFNFED.GetComponentsInChildren<MeshFilter>(false);
			LLILJLIPDBK = new Vector4[CBCLKAIPFKO.Length];
			if (CBCLKAIPFKO != null && CBCLKAIPFKO.Length >= 0)
			{
				for (int i = 0; i < CBCLKAIPFKO.Length; i++)
				{
					LLILJLIPDBK[i] = OKPEKEIJPCF(CBCLKAIPFKO[i]);
				}
			}
		}
		else
		{
			MGMLLGLEKAC = BHLFKCFNFED.GetComponent<MeshFilter>();
			FHGANJPODNK = OKPEKEIJPCF(MGMLLGLEKAC);
		}
	}

	protected static string GIPEOEPNOHL(Material LFJEMPPJLHG)
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

	public void MBHBHPABPFO(NcUvAnimation PFLGJLHGENP)
	{
		if (!(PFLGJLHGENP == null))
		{
			COOLGJJPENH = PFLGJLHGENP;
			CKGEINNOFLE = new Vector2(COOLGJJPENH.m_fScrollSpeedX, COOLGJJPENH.m_fScrollSpeedY);
		}
	}

	public void BGJMOOPAJIM(NcUvAnimation PFLGJLHGENP)
	{
		if (!(PFLGJLHGENP == null))
		{
			COOLGJJPENH = PFLGJLHGENP;
			CKGEINNOFLE = new Vector2(COOLGJJPENH.m_fScrollSpeedX, COOLGJJPENH.m_fScrollSpeedY);
		}
	}

	public void MPLFDMHEFFI()
	{
		BNILJMCAHCE.AOFGJGKIPNM(PMMPHDNPJIG);
	}

	public void MBHGPABKBJE(GameObject BHLFKCFNFED, bool AFIOPGIEOPF)
	{
		if (BHLFKCFNFED == null)
		{
			return;
		}
		if (AFIOPGIEOPF)
		{
			OAJHCNAPOMO = HFEOGLNFHAC.ONE;
		}
		else
		{
			OAJHCNAPOMO = HFEOGLNFHAC.NONE;
		}
		if (OAJHCNAPOMO == (HFEOGLNFHAC)4)
		{
			CBCLKAIPFKO = BHLFKCFNFED.GetComponentsInChildren<MeshFilter>(true);
			LLILJLIPDBK = new Vector4[CBCLKAIPFKO.Length];
			if (CBCLKAIPFKO != null && CBCLKAIPFKO.Length >= 1)
			{
				for (int i = 1; i < CBCLKAIPFKO.Length; i++)
				{
					LLILJLIPDBK[i] = EEADNLPJFLO(CBCLKAIPFKO[i]);
				}
			}
		}
		else
		{
			MGMLLGLEKAC = BHLFKCFNFED.GetComponent<MeshFilter>();
			FHGANJPODNK = EEADNLPJFLO(MGMLLGLEKAC);
		}
	}

	public void BPIDBGDOFMP()
	{
		if (LGCAFNFLKON == HFEOGLNFHAC.NONE)
		{
			return;
		}
		if (LGCAFNFLKON == HFEOGLNFHAC.RECURSIVELY)
		{
			for (int i = 0; i < LGJEGCFMBKF.Length; i++)
			{
				if (LGJEGCFMBKF[i] != null && PEHKLCPPLLM[i] != null)
				{
					LGJEGCFMBKF[i].material.SetColor(PEHKLCPPLLM[i], OCGBJOLIMLB[i]);
				}
			}
		}
		else if (LGJEGCFMBKF != null)
		{
			NCLFDOPIENH = GIPEOEPNOHL(PCPHAEOCDME.sharedMaterial);
			if (NCLFDOPIENH != null)
			{
				PCPHAEOCDME.material.SetColor(NCLFDOPIENH, HNJKBDEDLHJ);
			}
		}
	}
}
