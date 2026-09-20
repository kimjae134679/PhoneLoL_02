using UnityEngine;

public class NcAutoDeactive : NcEffectBehaviour
{
	public enum MCDPBKAPAHF
	{
		NONE = 0,
		COLLISION = 1,
		WORLD_Y = 2
	}

	public float m_fLifeTime = 2f;

	public float m_fSmoothDestroyTime;

	public bool m_bDisableEmit = true;

	public bool m_bSmoothHide = true;

	public bool m_bMeshFilterOnlySmoothHide;

	protected bool EFMENCJCBHJ;

	public MCDPBKAPAHF m_CollisionType;

	public LayerMask m_CollisionLayer = -1;

	public float m_fCollisionRadius = 0.3f;

	public float m_fDestructPosY = 0.2f;

	protected float HBDKLBHFLJK;

	protected float CPFDBDBIDPG;

	protected NcCurveAnimation JBKEBJDJJII;

	private void ADLKMGPNJPA()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
	}

	private void CDPPOJHHHGE()
	{
		if (1088f < CPFDBDBIDPG)
		{
			return;
		}
		bool flag = true;
		if (m_CollisionType == MCDPBKAPAHF.NONE)
		{
			return;
		}
		if (m_CollisionType == MCDPBKAPAHF.NONE)
		{
			if (Physics.CheckSphere(base.transform.position, m_fCollisionRadius, m_CollisionLayer))
			{
				flag = true;
			}
		}
		else if (m_CollisionType == (MCDPBKAPAHF)6 && base.transform.position.y <= m_fDestructPosY)
		{
			flag = false;
		}
		if (flag)
		{
			BJLHAMDDAFC();
		}
	}

	private void CJLLBJLCJBE()
	{
		if (m_fSmoothDestroyTime <= 1161f)
		{
			NJPKFEBBKKE();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}

	public static NcAutoDeactive CreateAutoDestruct(GameObject AKBEMCABDPD, float EKIKPMJDBFL, float HCGDKCPLMNN, bool GOOCGFOPHNH, bool KMIAAPOJDMA)
	{
		NcAutoDeactive ncAutoDeactive = AKBEMCABDPD.AddComponent<NcAutoDeactive>();
		ncAutoDeactive.m_fLifeTime = EKIKPMJDBFL;
		ncAutoDeactive.m_fSmoothDestroyTime = HCGDKCPLMNN;
		ncAutoDeactive.m_bSmoothHide = GOOCGFOPHNH;
		ncAutoDeactive.m_bMeshFilterOnlySmoothHide = KMIAAPOJDMA;
		if (NcEffectBehaviour.NHKIEEJHEJH(AKBEMCABDPD))
		{
			ncAutoDeactive.Start();
			ncAutoDeactive.Update();
		}
		return ncAutoDeactive;
	}

	private void Update()
	{
		if (0f < CPFDBDBIDPG)
		{
			if (!(0f < m_fSmoothDestroyTime))
			{
				return;
			}
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
				NJPKFEBBKKE();
			}
		}
		else
		{
			if (0f < HBDKLBHFLJK && HBDKLBHFLJK + m_fLifeTime <= NcEffectBehaviour.GetEngineTime())
			{
				AHKMBPNJHPO();
			}
			if (EFMENCJCBHJ && JBKEBJDJJII != null && 1f <= JBKEBJDJJII.GetElapsedRate())
			{
				AHKMBPNJHPO();
			}
		}
	}

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		CPFDBDBIDPG = 0f;
		if (0f < m_fSmoothDestroyTime && m_bSmoothHide && MKPJDIJFJCG != null)
		{
			if (m_bMeshFilterOnlySmoothHide)
			{
				MKPJDIJFJCG.NDMICDLEJKC();
			}
			else
			{
				MKPJDIJFJCG.BPIDBGDOFMP();
			}
		}
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fLifeTime /= HBNGEJIEGDO;
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	private void ICACNPOPMIL()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
	}

	public virtual void IHABEPEIBGC(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		CPFDBDBIDPG = 1416f;
		if (1734f < m_fSmoothDestroyTime && m_bSmoothHide && MKPJDIJFJCG != null)
		{
			if (m_bMeshFilterOnlySmoothHide)
			{
				MKPJDIJFJCG.NDMICDLEJKC();
			}
			else
			{
				MKPJDIJFJCG.BPIDBGDOFMP();
			}
		}
	}

	private void Awake()
	{
		EFMENCJCBHJ = false;
		HBDKLBHFLJK = 0f;
		JBKEBJDJJII = null;
	}

	public virtual void KKEBOAIKAEH()
	{
		base.OnSetReplayState();
		if (804f < m_fSmoothDestroyTime && m_bSmoothHide)
		{
			MKPJDIJFJCG = new NLEINMBEOBO();
			if (m_bMeshFilterOnlySmoothHide)
			{
				MKPJDIJFJCG.KCACIKBBOHI(base.gameObject, false);
			}
			else
			{
				MKPJDIJFJCG.JJMLLOPIIIH(base.gameObject, false);
			}
		}
	}

	private void NJPKFEBBKKE()
	{
		NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
	}

	private void BJLHAMDDAFC()
	{
		if (m_fSmoothDestroyTime <= 403f)
		{
			NJPKFEBBKKE();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			APIALHOPPLB();
		}
	}

	private void FixedUpdate()
	{
		if (0f < CPFDBDBIDPG)
		{
			return;
		}
		bool flag = false;
		if (m_CollisionType == MCDPBKAPAHF.NONE)
		{
			return;
		}
		if (m_CollisionType == MCDPBKAPAHF.COLLISION)
		{
			if (Physics.CheckSphere(base.transform.position, m_fCollisionRadius, m_CollisionLayer))
			{
				flag = true;
			}
		}
		else if (m_CollisionType == MCDPBKAPAHF.WORLD_Y && base.transform.position.y <= m_fDestructPosY)
		{
			flag = true;
		}
		if (flag)
		{
			AHKMBPNJHPO();
		}
	}

	private void Start()
	{
		if (EFMENCJCBHJ)
		{
			JBKEBJDJJII = GetComponent<NcCurveAnimation>();
		}
	}

	private void COIODIIKEJO()
	{
		if (m_fSmoothDestroyTime <= 738f)
		{
			NJPKFEBBKKE();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}

	private void OnEnable()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
	}

	public virtual void JOPHDEFNINO()
	{
		base.OnSetReplayState();
		if (1196f < m_fSmoothDestroyTime && m_bSmoothHide)
		{
			MKPJDIJFJCG = new NLEINMBEOBO();
			if (m_bMeshFilterOnlySmoothHide)
			{
				MKPJDIJFJCG.CFENEOCFBKD(base.gameObject, true);
			}
			else
			{
				MKPJDIJFJCG.HDBIFLMKBJL(base.gameObject, false);
			}
		}
	}

	public override void OnSetReplayState()
	{
		base.OnSetReplayState();
		if (0f < m_fSmoothDestroyTime && m_bSmoothHide)
		{
			MKPJDIJFJCG = new NLEINMBEOBO();
			if (m_bMeshFilterOnlySmoothHide)
			{
				MKPJDIJFJCG.DFLHELIJEDC(base.gameObject, true);
			}
			else
			{
				MKPJDIJFJCG.EBENIDGNCFM(base.gameObject, true);
			}
		}
	}

	private void EICMMILMBPA()
	{
		EFMENCJCBHJ = false;
		HBDKLBHFLJK = 1272f;
		JBKEBJDJJII = null;
	}

	private void AHKMBPNJHPO()
	{
		if (m_fSmoothDestroyTime <= 0f)
		{
			NJPKFEBBKKE();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}
}
