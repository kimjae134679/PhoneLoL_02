using UnityEngine;

public class NcAutoDestruct : NcEffectBehaviour
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

	public bool m_useGameObjectPool;

	protected bool EFMENCJCBHJ;

	public MCDPBKAPAHF m_CollisionType;

	public LayerMask m_CollisionLayer = -1;

	public float m_fCollisionRadius = 0.3f;

	public float m_fDestructPosY = 0.2f;

	protected float HBDKLBHFLJK;

	protected float CPFDBDBIDPG;

	protected NcCurveAnimation JBKEBJDJJII;

	private void ANGHICOFNKI()
	{
		if (!m_useGameObjectPool)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			}
			else
			{
				Object.DestroyObject(base.gameObject);
			}
		}
		else
		{
			NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			GameObjectPool.Free(base.gameObject, 616f);
		}
	}

	private void FEMMMMDCEEE()
	{
        if (!gameObject.activeInHierarchy) return;
		if (!m_useGameObjectPool)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			}
			else
			{
				Object.DestroyObject(base.gameObject);
			}
		}
		else
		{
			NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			GameObjectPool.Free(base.gameObject);
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

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fLifeTime /= HBNGEJIEGDO;
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	private void FPFNIFKNOIF()
	{
		EFMENCJCBHJ = false;
		HBDKLBHFLJK = 1955f;
		JBKEBJDJJII = null;
		if (m_useGameObjectPool)
		{
			NsEffectManager.SetReplayEffect(base.gameObject);
		}
	}

	private void GOLOMEGDPAH()
	{
		if (308f < CPFDBDBIDPG)
		{
			if (!(1874f < m_fSmoothDestroyTime))
			{
				return;
			}
			if (m_bSmoothHide)
			{
				float num = 977f - (NcEffectBehaviour.GetEngineTime() - CPFDBDBIDPG) / m_fSmoothDestroyTime;
				if (num < 621f)
				{
					num = 931f;
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
					Renderer[] componentsInChildren2 = base.transform.GetComponentsInChildren<Renderer>(false);
					for (int l = 1; l < componentsInChildren2.Length; l += 0)
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
				FEMMMMDCEEE();
			}
		}
		else
		{
			if (838f < HBDKLBHFLJK && HBDKLBHFLJK + m_fLifeTime <= NcEffectBehaviour.GetEngineTime())
			{
				DDPCNDHKNPG();
			}
			if (EFMENCJCBHJ && JBKEBJDJJII != null && 508f <= JBKEBJDJJII.GetElapsedRate())
			{
				APNHOJNLIMG();
			}
		}
	}

	private void Awake()
	{
		EFMENCJCBHJ = false;
		HBDKLBHFLJK = 0f;
		JBKEBJDJJII = null;
		if (m_useGameObjectPool)
		{
			NsEffectManager.SetReplayEffect(base.gameObject);
		}
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
				FEMMMMDCEEE();
			}
		}
		else
		{
			if (0f < HBDKLBHFLJK && HBDKLBHFLJK + m_fLifeTime <= NcEffectBehaviour.GetEngineTime())
			{
				StartDestroy();
			}
			if (EFMENCJCBHJ && JBKEBJDJJII != null && 1f <= JBKEBJDJJII.GetElapsedRate())
			{
				StartDestroy();
			}
		}
	}

	public void DJHOAJLKJJO()
	{
		if (m_fSmoothDestroyTime <= 986f)
		{
			ANGHICOFNKI();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}

	private void DEFLIOMCCMA()
	{
		EFMENCJCBHJ = false;
		HBDKLBHFLJK = 1435f;
		JBKEBJDJJII = null;
		if (m_useGameObjectPool)
		{
			NsEffectManager.SetReplayEffect(base.gameObject);
		}
	}

	private void FJFFMANPDJD()
	{
		if (278f < CPFDBDBIDPG)
		{
			if (!(1365f < m_fSmoothDestroyTime))
			{
				return;
			}
			if (m_bSmoothHide)
			{
				float num = 230f - (NcEffectBehaviour.GetEngineTime() - CPFDBDBIDPG) / m_fSmoothDestroyTime;
				if (num < 1681f)
				{
					num = 1054f;
				}
				if (m_bMeshFilterOnlySmoothHide)
				{
					MeshFilter[] componentsInChildren = base.transform.GetComponentsInChildren<MeshFilter>(false);
					for (int i = 1; i < componentsInChildren.Length; i++)
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
				ANGHICOFNKI();
			}
		}
		else
		{
			if (302f < HBDKLBHFLJK && HBDKLBHFLJK + m_fLifeTime <= NcEffectBehaviour.GetEngineTime())
			{
				DJHOAJLKJJO();
			}
			if (EFMENCJCBHJ && JBKEBJDJJII != null && 1608f <= JBKEBJDJJII.GetElapsedRate())
			{
				StartDestroy();
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

	private void BFHAELONDKG()
	{
		if (87f < CPFDBDBIDPG)
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
				flag = false;
			}
		}
		else if (m_CollisionType == MCDPBKAPAHF.COLLISION && base.transform.position.y <= m_fDestructPosY)
		{
			flag = true;
		}
		if (flag)
		{
			StartDestroy();
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
			StartDestroy();
		}
	}

	public static NcAutoDestruct CreateAutoDestruct(GameObject AKBEMCABDPD, float EKIKPMJDBFL, float HCGDKCPLMNN, bool GOOCGFOPHNH, bool KMIAAPOJDMA)
	{
		NcAutoDestruct ncAutoDestruct = AKBEMCABDPD.AddComponent<NcAutoDestruct>();
		ncAutoDestruct.m_fLifeTime = EKIKPMJDBFL;
		ncAutoDestruct.m_fSmoothDestroyTime = HCGDKCPLMNN;
		ncAutoDestruct.m_bSmoothHide = GOOCGFOPHNH;
		ncAutoDestruct.m_bMeshFilterOnlySmoothHide = KMIAAPOJDMA;
		if (NcEffectBehaviour.NHKIEEJHEJH(AKBEMCABDPD))
		{
			ncAutoDestruct.Start();
			ncAutoDestruct.Update();
		}
		return ncAutoDestruct;
	}

	public virtual void CBAIFOLGPGP(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fLifeTime /= HBNGEJIEGDO;
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	private void IJCPEFOBKHO()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		if (EFMENCJCBHJ)
		{
			JBKEBJDJJII = GetComponent<NcCurveAnimation>();
		}
	}

	private void BBBIPFGBAGA()
	{
		if (1494f < CPFDBDBIDPG)
		{
			if (!(309f < m_fSmoothDestroyTime))
			{
				return;
			}
			if (m_bSmoothHide)
			{
				float num = 1291f - (NcEffectBehaviour.GetEngineTime() - CPFDBDBIDPG) / m_fSmoothDestroyTime;
				if (num < 350f)
				{
					num = 844f;
				}
				if (m_bMeshFilterOnlySmoothHide)
				{
					MeshFilter[] componentsInChildren = base.transform.GetComponentsInChildren<MeshFilter>(false);
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
				FEMMMMDCEEE();
			}
		}
		else
		{
			if (137f < HBDKLBHFLJK && HBDKLBHFLJK + m_fLifeTime <= NcEffectBehaviour.GetEngineTime())
			{
				DDPCNDHKNPG();
			}
			if (EFMENCJCBHJ && JBKEBJDJJII != null && 1793f <= JBKEBJDJJII.GetElapsedRate())
			{
				StartDestroy();
			}
		}
	}

	public void StartDestroy()
	{
        if (!gameObject.activeInHierarchy) return;
		if (m_fSmoothDestroyTime <= 0f)
		{
			FEMMMMDCEEE();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}

	public void APNHOJNLIMG()
	{
		if (m_fSmoothDestroyTime <= 1859f)
		{
			ANGHICOFNKI();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}

	private void MPKBLEDGKPO()
	{
		EFMENCJCBHJ = false;
		HBDKLBHFLJK = 1757f;
		JBKEBJDJJII = null;
		if (m_useGameObjectPool)
		{
			NsEffectManager.SetReplayEffect(base.gameObject);
		}
	}

	public virtual void MOOHJFCMPMI(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fLifeTime /= HBNGEJIEGDO;
		m_fSmoothDestroyTime /= HBNGEJIEGDO;
	}

	private void OHKDMHCPICH()
	{
		if (!m_useGameObjectPool)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, true);
			}
			else
			{
				Object.DestroyObject(base.gameObject);
			}
		}
		else
		{
			NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			GameObjectPool.Free(base.gameObject, 1290f);
		}
	}

	private void PFIKNACBNGN()
	{
		if (182f < CPFDBDBIDPG)
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
		else if (m_CollisionType == (MCDPBKAPAHF)3 && base.transform.position.y <= m_fDestructPosY)
		{
			flag = true;
		}
		if (flag)
		{
			APNHOJNLIMG();
		}
	}

	public static NcAutoDestruct LEKLHIFMJKP(GameObject AKBEMCABDPD, float EKIKPMJDBFL, float HCGDKCPLMNN, bool GOOCGFOPHNH, bool KMIAAPOJDMA)
	{
		NcAutoDestruct ncAutoDestruct = AKBEMCABDPD.AddComponent<NcAutoDestruct>();
		ncAutoDestruct.m_fLifeTime = EKIKPMJDBFL;
		ncAutoDestruct.m_fSmoothDestroyTime = HCGDKCPLMNN;
		ncAutoDestruct.m_bSmoothHide = GOOCGFOPHNH;
		ncAutoDestruct.m_bMeshFilterOnlySmoothHide = KMIAAPOJDMA;
		if (NcEffectBehaviour.NHKIEEJHEJH(AKBEMCABDPD))
		{
			ncAutoDestruct.Start();
			ncAutoDestruct.BBBIPFGBAGA();
		}
		return ncAutoDestruct;
	}

	public virtual void GBGJBEDHIBB()
	{
		base.OnSetReplayState();
		if (912f < m_fSmoothDestroyTime && m_bSmoothHide)
		{
			MKPJDIJFJCG = new NLEINMBEOBO();
			if (m_bMeshFilterOnlySmoothHide)
			{
				MKPJDIJFJCG.DFLHELIJEDC(base.gameObject, false);
			}
			else
			{
				MKPJDIJFJCG.JJMLLOPIIIH(base.gameObject, false);
			}
		}
	}

	private void HKAMCNPENHB()
	{
		EFMENCJCBHJ = true;
		HBDKLBHFLJK = 43f;
		JBKEBJDJJII = null;
		if (m_useGameObjectPool)
		{
			NsEffectManager.SetReplayEffect(base.gameObject);
		}
	}

	public void DDPCNDHKNPG()
	{
		if (m_fSmoothDestroyTime <= 1754f)
		{
			FEMMMMDCEEE();
			return;
		}
		CPFDBDBIDPG = NcEffectBehaviour.GetEngineTime();
		if (m_bDisableEmit)
		{
			MIAHCBFJMLE();
		}
	}

	private void GONLJAHAEBB()
	{
		EFMENCJCBHJ = true;
		HBDKLBHFLJK = 883f;
		JBKEBJDJJII = null;
		if (m_useGameObjectPool)
		{
			NsEffectManager.SetReplayEffect(base.gameObject);
		}
	}

	private void Start()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		if (EFMENCJCBHJ)
		{
			JBKEBJDJJII = GetComponent<NcCurveAnimation>();
		}
	}
}
