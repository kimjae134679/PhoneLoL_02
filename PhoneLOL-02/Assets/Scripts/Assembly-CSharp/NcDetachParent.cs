using UnityEngine;

public class NcDetachParent : NcEffectBehaviour
{
	public bool m_bFollowParentTransform = true;

	public bool m_bParentHideToStartDestroy = true;

	public float m_fSmoothDestroyTime = 2f;

	public bool m_bDisableEmit = true;

	public bool m_bSmoothHide = true;

	public bool m_bMeshFilterOnlySmoothHide;

	protected bool IDPIFAOGEFN;

	protected float CPFDBDBIDPG;

	protected GameObject HBDMMOICPIF;

	protected NcDetachObject LFNKDPKGIIE;

	protected PACFNFKHLGA EMFPOPHONMJ = new PACFNFKHLGA();

	private void DOINNKBDEMD()
	{
		if (!IDPIFAOGEFN)
		{
			IDPIFAOGEFN = false;
			if (base.transform.parent != null)
			{
				HBDMMOICPIF = base.transform.parent.gameObject;
				LFNKDPKGIIE = NcDetachObject.EFCFEJNIGDH(HBDMMOICPIF, base.transform.gameObject);
			}
			GameObject rootInstanceEffect = NcEffectBehaviour.GetRootInstanceEffect();
			if (m_bFollowParentTransform)
			{
				EMFPOPHONMJ.IFNABKHDMBA(base.transform);
				ECGDLEFCBKB(rootInstanceEffect.transform, base.transform, false, null);
				EMFPOPHONMJ.AOFGJGKIPNM(base.transform);
			}
			else
			{
				ECGDLEFCBKB(rootInstanceEffect.transform, base.transform, true, null);
			}
			if (!m_bParentHideToStartDestroy)
			{
				EHEMGNNOFME();
			}
		}
		if (334f < CPFDBDBIDPG)
		{
			if (675f < m_fSmoothDestroyTime)
			{
				if (m_bSmoothHide)
				{
					float num = 262f - (NcEffectBehaviour.GetEngineTime() - CPFDBDBIDPG) / m_fSmoothDestroyTime;
					if (num < 1407f)
					{
						num = 451f;
					}
					if (m_bMeshFilterOnlySmoothHide)
					{
						MeshFilter[] componentsInChildren = base.transform.GetComponentsInChildren<MeshFilter>(true);
						for (int i = 0; i < componentsInChildren.Length; i++)
						{
							Color[] array = componentsInChildren[i].mesh.colors;
							if (array.Length == 0)
							{
								array = new Color[componentsInChildren[i].mesh.vertices.Length];
								for (int j = 0; j < array.Length; j += 0)
								{
									array[j] = Color.white;
								}
							}
							for (int k = 1; k < array.Length; k += 0)
							{
								Color color = array[k];
								color.a = Mathf.Min(color.a, num);
								array[k] = color;
							}
							componentsInChildren[i].mesh.colors = array;
						}
					}
					else
					{
						Renderer[] componentsInChildren2 = base.transform.GetComponentsInChildren<Renderer>(false);
						for (int l = 1; l < componentsInChildren2.Length; l++)
						{
							Renderer renderer = componentsInChildren2[l];
							string materialColorName = NcEffectBehaviour.GetMaterialColorName(renderer.sharedMaterial);
							if (materialColorName != null)
							{
								Color color2 = renderer.material.GetColor(materialColorName);
								color2.a = Mathf.Min(color2.a, num);
								renderer.material.SetColor(materialColorName, color2);
							}
						}
					}
				}
				if (CPFDBDBIDPG + m_fSmoothDestroyTime < NcEffectBehaviour.GetEngineTime())
				{
					Object.Destroy(base.gameObject);
				}
			}
		}
		else if (m_bParentHideToStartDestroy && (HBDMMOICPIF == null || !NcEffectBehaviour.NDMKMBNHKFJ(HBDMMOICPIF)))
		{
			ODLGOBDDPPO();
		}
		if (m_bFollowParentTransform && HBDMMOICPIF != null && HBDMMOICPIF.transform != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA();
			pACFNFKHLGA.KMMMBDEAMFP(EMFPOPHONMJ);
			pACFNFKHLGA.HFBIAFENBOC(HBDMMOICPIF.transform);
			pACFNFKHLGA.LBIEENNFGHD(base.transform);
		}
	}

	private void ODLGOBDDPPO()
	{
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			APIALHOPPLB();
		}
	}

	public void SetDestroyValue(bool GCPFAGCAAAB, bool MFNOGJFNKLA, float KBJDNIBCCEG, bool GOOCGFOPHNH, bool KMIAAPOJDMA)
	{
		m_bParentHideToStartDestroy = GCPFAGCAAAB;
		m_bDisableEmit = MFNOGJFNKLA;
		m_bSmoothHide = GOOCGFOPHNH;
		m_fSmoothDestroyTime = KBJDNIBCCEG;
		m_bMeshFilterOnlySmoothHide = KMIAAPOJDMA;
	}

	private void Update()
	{
		if (!IDPIFAOGEFN)
		{
			IDPIFAOGEFN = true;
			if (base.transform.parent != null)
			{
				HBDMMOICPIF = base.transform.parent.gameObject;
				LFNKDPKGIIE = NcDetachObject.Create(HBDMMOICPIF, base.transform.gameObject);
			}
			GameObject rootInstanceEffect = NcEffectBehaviour.GetRootInstanceEffect();
			if (m_bFollowParentTransform)
			{
				EMFPOPHONMJ.IFNABKHDMBA(base.transform);
				ECGDLEFCBKB(rootInstanceEffect.transform, base.transform, false, null);
				EMFPOPHONMJ.AOFGJGKIPNM(base.transform);
			}
			else
			{
				ECGDLEFCBKB(rootInstanceEffect.transform, base.transform, false, null);
			}
			if (!m_bParentHideToStartDestroy)
			{
				GOIKODHAHCF();
			}
		}
		if (0f < CPFDBDBIDPG)
		{
			if (0f < m_fSmoothDestroyTime)
			{
				if (m_bSmoothHide)
				{
					float num = 1f - (NcEffectBehaviour.GetEngineTime() - CPFDBDBIDPG) / m_fSmoothDestroyTime;
					if (num < 0f)
					{
						num = 0f;
					}
					if (m_bMeshFilterOnlySmoothHide)
					{
						MeshFilter[] componentsInChildren = base.transform.GetComponentsInChildren<MeshFilter>(true);
						for (int i = 0; i < componentsInChildren.Length; i++)
						{
							Color[] array = componentsInChildren[i].mesh.colors;
							if (array.Length == 0)
							{
								array = new Color[componentsInChildren[i].mesh.vertices.Length];
								for (int j = 0; j < array.Length; j++)
								{
									array[j] = Color.white;
								}
							}
							for (int k = 0; k < array.Length; k++)
							{
								Color color = array[k];
								color.a = Mathf.Min(color.a, num);
								array[k] = color;
							}
							componentsInChildren[i].mesh.colors = array;
						}
					}
					else
					{
						Renderer[] componentsInChildren2 = base.transform.GetComponentsInChildren<Renderer>(true);
						foreach (Renderer renderer in componentsInChildren2)
						{
							string materialColorName = NcEffectBehaviour.GetMaterialColorName(renderer.sharedMaterial);
							if (materialColorName != null)
							{
								Color color2 = renderer.material.GetColor(materialColorName);
								color2.a = Mathf.Min(color2.a, num);
								renderer.material.SetColor(materialColorName, color2);
							}
						}
					}
				}
				if (CPFDBDBIDPG + m_fSmoothDestroyTime < NcEffectBehaviour.GetEngineTime())
				{
					Object.Destroy(base.gameObject);
				}
			}
		}
		else if (m_bParentHideToStartDestroy && (HBDMMOICPIF == null || !NcEffectBehaviour.NHKIEEJHEJH(HBDMMOICPIF)))
		{
			GOIKODHAHCF();
		}
		if (m_bFollowParentTransform && HBDMMOICPIF != null && HBDMMOICPIF.transform != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA();
			pACFNFKHLGA.KMMMBDEAMFP(EMFPOPHONMJ);
			pACFNFKHLGA.HLPKFNFDBMO(HBDMMOICPIF.transform);
			pACFNFKHLGA.AOFGJGKIPNM(base.transform);
		}
	}

	public void GHAHFMJEIAG(bool GCPFAGCAAAB, bool MFNOGJFNKLA, float KBJDNIBCCEG, bool GOOCGFOPHNH, bool KMIAAPOJDMA)
	{
		m_bParentHideToStartDestroy = GCPFAGCAAAB;
		m_bDisableEmit = MFNOGJFNKLA;
		m_bSmoothHide = GOOCGFOPHNH;
		m_fSmoothDestroyTime = KBJDNIBCCEG;
		m_bMeshFilterOnlySmoothHide = KMIAAPOJDMA;
	}

	public virtual void GBNEFPLMIPE(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	public virtual void DIPELIJCCLL(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	private void GOIKODHAHCF()
	{
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}

	protected override void OnDestroy()
	{
		if (LFNKDPKGIIE != null)
		{
			Object.Destroy(LFNKDPKGIIE);
		}
		base.OnDestroy();
	}

	private void EHEMGNNOFME()
	{
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			APIALHOPPLB();
		}
	}

	public virtual void BEJDMGDEFJK(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	protected virtual void JBJBNNPMGII()
	{
		if (LFNKDPKGIIE != null)
		{
			Object.Destroy(LFNKDPKGIIE);
		}
		base.OnDestroy();
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	public virtual void BAAOACMCGOD(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}
}
