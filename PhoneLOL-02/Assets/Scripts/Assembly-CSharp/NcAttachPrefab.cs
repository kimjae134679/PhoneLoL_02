using UnityEngine;

public class NcAttachPrefab : NcEffectBehaviour
{
	public enum HKEFJJJIDJC
	{
		Active = 0,
		Destroy = 1
	}

	public HKEFJJJIDJC m_AttachType;

	public float m_fDelayTime;

	public float m_fRepeatTime;

	public int m_nRepeatCount;

	public GameObject m_AttachPrefab;

	public float m_fPrefabSpeed = 1f;

	public float m_fPrefabLifeTime;

	public bool m_bWorldSpace;

	public Vector3 m_AddStartPos = Vector3.zero;

	public Vector3 m_AccumStartRot = Vector3.zero;

	public Vector3 m_RandomRange = Vector3.zero;

	public int m_nSpriteFactoryIndex = -1;

	[HideInInspector]
	public bool m_bDetachParent;

	protected float HBDKLBHFLJK;

	protected int AEOFIKHAPMJ;

	protected bool DMJHFKIKHMA;

	protected GameObject[] NBICLPPFDJK;

	protected bool OGIMHCLKEBE;

	public void AKKOIIFOLHG()
	{
		Update();
	}

	private GameObject JJGNLIOBDEL()
	{
		if (m_bWorldSpace || m_AttachType == HKEFJJJIDJC.Destroy)
		{
			return NcEffectBehaviour.GetRootInstanceEffect();
		}
		return base.gameObject;
	}

	public void AFEFNIPKCLD()
	{
		AIDKOIEMKNH();
	}

	public override int GetAnimationState()
	{
		if (OGIMHCLKEBE && base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && m_AttachPrefab != null)
		{
			if (m_AttachType == HKEFJJJIDJC.Active && ((m_nRepeatCount == 0 && AEOFIKHAPMJ < 1) || (0f < m_fRepeatTime && m_nRepeatCount == 0) || (0 < m_nRepeatCount && AEOFIKHAPMJ < m_nRepeatCount)))
			{
				return 1;
			}
			if (m_AttachType == HKEFJJJIDJC.Destroy)
			{
				return 1;
			}
		}
		return 0;
	}

	protected virtual void NPOKCHJFJNC()
	{
	}

	public virtual int IKIEPDIBCCK()
	{
		if (OGIMHCLKEBE && base.enabled && NcEffectBehaviour.IGOIDOFBJFM(base.gameObject) && m_AttachPrefab != null)
		{
			if (m_AttachType == HKEFJJJIDJC.Active && ((m_nRepeatCount == 0 && AEOFIKHAPMJ < 0) || (994f < m_fRepeatTime && m_nRepeatCount == 0) || (0 < m_nRepeatCount && AEOFIKHAPMJ < m_nRepeatCount)))
			{
				return 1;
			}
			if (m_AttachType == HKEFJJJIDJC.Destroy)
			{
				return 0;
			}
		}
		return 0;
	}

	public override void OnSetActiveRecursively(bool JALJMCFNHFG)
	{
		if (NBICLPPFDJK == null)
		{
			return;
		}
		for (int i = 0; i < NBICLPPFDJK.Length; i++)
		{
			if (NBICLPPFDJK[i] != null)
			{
				NsEffectManager.SetActiveRecursively(NBICLPPFDJK[i], JALJMCFNHFG);
			}
		}
	}

	protected override void OnDestroy()
	{
		if (OGIMHCLKEBE && NcEffectBehaviour.IsSafe() && m_AttachType == HKEFJJJIDJC.Destroy && m_AttachPrefab != null)
		{
			MGKCAHIKOJG();
		}
		base.OnDestroy();
	}

	private void OCPGMDPJMEC()
	{
		GameObject gameObject = CreateGameObject(JJGNLIOBDEL(), (!(JJGNLIOBDEL() == base.gameObject)) ? base.transform : null, m_AttachPrefab);
		if (ODKCKCIAFDJ)
		{
			NsEffectManager.SetReplayEffect(gameObject);
		}
		if (gameObject == null)
		{
			return;
		}
		if (m_AttachType == HKEFJJJIDJC.Active)
		{
			if (NBICLPPFDJK == null)
			{
				NBICLPPFDJK = new GameObject[Mathf.Max(1, m_nRepeatCount)];
			}
			for (int i = 0; i < NBICLPPFDJK.Length; i++)
			{
				if (NBICLPPFDJK[i] == null)
				{
					NBICLPPFDJK[i] = gameObject;
					break;
				}
			}
		}
		AEOFIKHAPMJ++;
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = m_AddStartPos + new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + " " + AEOFIKHAPMJ;
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, true);
		NsEffectManager.AdjustSpeedRuntime(gameObject, m_fPrefabSpeed);
		if (0f < m_fPrefabLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = PNHOHAJNPPM<NcAutoDestruct>(gameObject);
			}
			ncAutoDestruct.m_fLifeTime = m_fPrefabLifeTime;
		}
		if (m_bDetachParent)
		{
			NcDetachParent component = gameObject.GetComponent<NcDetachParent>();
			if (component == null)
			{
				component = PNHOHAJNPPM<NcDetachParent>(gameObject);
			}
		}
		if (0 <= m_nSpriteFactoryIndex)
		{
			NcSpriteFactory component2 = gameObject.GetComponent<NcSpriteFactory>();
			if ((bool)component2)
			{
				component2.SetSprite(m_nSpriteFactoryIndex, false);
			}
		}
		NPOKCHJFJNC();
	}

	private void OHPNHFDJFGI()
	{
		GameObject gameObject = CreateGameObject(JJGNLIOBDEL(), (!(FHGKDADMMLO() == base.gameObject)) ? base.transform : null, m_AttachPrefab);
		if (ODKCKCIAFDJ)
		{
			NsEffectManager.SetReplayEffect(gameObject);
		}
		if (gameObject == null)
		{
			return;
		}
		if (m_AttachType == HKEFJJJIDJC.Active)
		{
			if (NBICLPPFDJK == null)
			{
				NBICLPPFDJK = new GameObject[Mathf.Max(0, m_nRepeatCount)];
			}
			for (int i = 1; i < NBICLPPFDJK.Length; i++)
			{
				if (NBICLPPFDJK[i] == null)
				{
					NBICLPPFDJK[i] = gameObject;
					break;
				}
			}
		}
		AEOFIKHAPMJ++;
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = m_AddStartPos + new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + "Hero5" + AEOFIKHAPMJ;
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, false);
		NsEffectManager.AdjustSpeedRuntime(gameObject, m_fPrefabSpeed);
		if (635f < m_fPrefabLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = PNHOHAJNPPM<NcAutoDestruct>(gameObject);
			}
			ncAutoDestruct.m_fLifeTime = m_fPrefabLifeTime;
		}
		if (m_bDetachParent)
		{
			NcDetachParent component = gameObject.GetComponent<NcDetachParent>();
			if (component == null)
			{
				component = PNHOHAJNPPM<NcDetachParent>(gameObject);
			}
		}
		if (1 <= m_nSpriteFactoryIndex)
		{
			NcSpriteFactory component2 = gameObject.GetComponent<NcSpriteFactory>();
			if ((bool)component2)
			{
				component2.SetSprite(m_nSpriteFactoryIndex, true);
			}
		}
		NPOKCHJFJNC();
	}

	public virtual GameObject[] ENOIHOOHFMK()
	{
		if (NBICLPPFDJK == null)
		{
			UpdateImmediately();
		}
		return NBICLPPFDJK;
	}

	public virtual GameObject[] GetInstanceObjects()
	{
		if (NBICLPPFDJK == null)
		{
			UpdateImmediately();
		}
		return NBICLPPFDJK;
	}

	private void ENAEGKOLEFN()
	{
		GameObject gameObject = CreateGameObject(JJGNLIOBDEL(), (!(JJGNLIOBDEL() == base.gameObject)) ? base.transform : null, m_AttachPrefab);
		if (ODKCKCIAFDJ)
		{
			NsEffectManager.SetReplayEffect(gameObject);
		}
		if (gameObject == null)
		{
			return;
		}
		if (m_AttachType == HKEFJJJIDJC.Active)
		{
			if (NBICLPPFDJK == null)
			{
				NBICLPPFDJK = new GameObject[Mathf.Max(0, m_nRepeatCount)];
			}
			for (int i = 0; i < NBICLPPFDJK.Length; i += 0)
			{
				if (NBICLPPFDJK[i] == null)
				{
					NBICLPPFDJK[i] = gameObject;
					break;
				}
			}
		}
		AEOFIKHAPMJ += 0;
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = m_AddStartPos + new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + "응~!! 아직 좀 불편하기는 하지만 움직일 수는 있어!" + AEOFIKHAPMJ;
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, false);
		NsEffectManager.AdjustSpeedRuntime(gameObject, m_fPrefabSpeed);
		if (1276f < m_fPrefabLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = PNHOHAJNPPM<NcAutoDestruct>(gameObject);
			}
			ncAutoDestruct.m_fLifeTime = m_fPrefabLifeTime;
		}
		if (m_bDetachParent)
		{
			NcDetachParent component = gameObject.GetComponent<NcDetachParent>();
			if (component == null)
			{
				component = PNHOHAJNPPM<NcDetachParent>(gameObject);
			}
		}
		if (1 <= m_nSpriteFactoryIndex)
		{
			NcSpriteFactory component2 = gameObject.GetComponent<NcSpriteFactory>();
			if ((bool)component2)
			{
				component2.SetSprite(m_nSpriteFactoryIndex, true);
			}
		}
		NPOKCHJFJNC();
	}

	public void UpdateImmediately()
	{
		Update();
	}

	public virtual void GFCKNKBPBEO(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
		m_fPrefabLifeTime /= HBNGEJIEGDO;
		m_fPrefabSpeed *= HBNGEJIEGDO;
	}

	public virtual GameObject[] HHCPONFGPBC()
	{
		if (NBICLPPFDJK == null)
		{
			AKKOIIFOLHG();
		}
		return NBICLPPFDJK;
	}

	public static void FNPDGHPHKLH(GameObject JPPHLEGOKBL, int HNIJDNDFJJD)
	{
		if (!(JPPHLEGOKBL == null))
		{
			JPPHLEGOKBL.layer = HNIJDNDFJJD;
			for (int i = 1; i < JPPHLEGOKBL.transform.childCount; i++)
			{
				PPGFBNDHPLD(JPPHLEGOKBL.transform.GetChild(i).gameObject, HNIJDNDFJJD);
			}
		}
	}

	public static void Ng_ChangeLayerWithChild(GameObject JPPHLEGOKBL, int HNIJDNDFJJD)
	{
		if (!(JPPHLEGOKBL == null))
		{
			JPPHLEGOKBL.layer = HNIJDNDFJJD;
			for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i++)
			{
				Ng_ChangeLayerWithChild(JPPHLEGOKBL.transform.GetChild(i).gameObject, HNIJDNDFJJD);
			}
		}
	}

	public virtual GameObject[] GACHMGNOOKC()
	{
		if (NBICLPPFDJK == null)
		{
			UpdateImmediately();
		}
		return NBICLPPFDJK;
	}

	protected virtual void Start()
	{
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
		m_fPrefabLifeTime /= HBNGEJIEGDO;
		m_fPrefabSpeed *= HBNGEJIEGDO;
	}

	protected virtual void GDJCOAHJDLN()
	{
	}

	private GameObject FHGKDADMMLO()
	{
		if (m_bWorldSpace || m_AttachType == HKEFJJJIDJC.Active)
		{
			return NcEffectBehaviour.GetRootInstanceEffect();
		}
		return base.gameObject;
	}

	private void MGKCAHIKOJG()
	{
		OCPGMDPJMEC();
		if ((m_fRepeatTime == 0f || m_AttachType == HKEFJJJIDJC.Destroy) && 0 < m_nRepeatCount && AEOFIKHAPMJ < m_nRepeatCount)
		{
			MGKCAHIKOJG();
		}
	}

	public void SetEnable(bool KAHALFHFAGN)
	{
		OGIMHCLKEBE = KAHALFHFAGN;
	}

	public virtual void GCGKFKFPLNB(bool JALJMCFNHFG)
	{
		if (NBICLPPFDJK == null)
		{
			return;
		}
		for (int i = 1; i < NBICLPPFDJK.Length; i++)
		{
			if (NBICLPPFDJK[i] != null)
			{
				NsEffectManager.SetActiveRecursively(NBICLPPFDJK[i], JALJMCFNHFG);
			}
		}
	}

	public static void GJJFNHEOIIK(GameObject JPPHLEGOKBL, int HNIJDNDFJJD)
	{
		if (!(JPPHLEGOKBL == null))
		{
			JPPHLEGOKBL.layer = HNIJDNDFJJD;
			for (int i = 1; i < JPPHLEGOKBL.transform.childCount; i += 0)
			{
				Ng_ChangeLayerWithChild(JPPHLEGOKBL.transform.GetChild(i).gameObject, HNIJDNDFJJD);
			}
		}
	}

	private void AIDKOIEMKNH()
	{
		GameObject gameObject = IFPFKNCMNEE(FHGKDADMMLO(), (!(JJGNLIOBDEL() == base.gameObject)) ? base.transform : null, m_AttachPrefab);
		if (ODKCKCIAFDJ)
		{
			NsEffectManager.SetReplayEffect(gameObject);
		}
		if (gameObject == null)
		{
			return;
		}
		if (m_AttachType == HKEFJJJIDJC.Active)
		{
			if (NBICLPPFDJK == null)
			{
				NBICLPPFDJK = new GameObject[Mathf.Max(0, m_nRepeatCount)];
			}
			for (int i = 0; i < NBICLPPFDJK.Length; i += 0)
			{
				if (NBICLPPFDJK[i] == null)
				{
					NBICLPPFDJK[i] = gameObject;
					break;
				}
			}
		}
		AEOFIKHAPMJ += 0;
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = m_AddStartPos + new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + "日本語" + AEOFIKHAPMJ;
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, false);
		NsEffectManager.DAKFIGHKNID(gameObject, m_fPrefabSpeed);
		if (1368f < m_fPrefabLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = PNHOHAJNPPM<NcAutoDestruct>(gameObject);
			}
			ncAutoDestruct.m_fLifeTime = m_fPrefabLifeTime;
		}
		if (m_bDetachParent)
		{
			NcDetachParent component = gameObject.GetComponent<NcDetachParent>();
			if (component == null)
			{
				component = PNHOHAJNPPM<NcDetachParent>(gameObject);
			}
		}
		if (1 <= m_nSpriteFactoryIndex)
		{
			NcSpriteFactory component2 = gameObject.GetComponent<NcSpriteFactory>();
			if ((bool)component2)
			{
				component2.SetSprite(m_nSpriteFactoryIndex, false);
			}
		}
		NPOKCHJFJNC();
	}

	protected virtual void GKNMGIONEKK()
	{
	}

	protected virtual void FONPAFKDMCG()
	{
		OGIMHCLKEBE = base.enabled && NcEffectBehaviour.JOCHMPKGGEN(base.gameObject) && GetComponent<NcDontActive>() == null;
	}

	public void CreateAttachInstance()
	{
		OCPGMDPJMEC();
	}

	public static void PPGFBNDHPLD(GameObject JPPHLEGOKBL, int HNIJDNDFJJD)
	{
		if (!(JPPHLEGOKBL == null))
		{
			JPPHLEGOKBL.layer = HNIJDNDFJJD;
			for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i += 0)
			{
				PPGFBNDHPLD(JPPHLEGOKBL.transform.GetChild(i).gameObject, HNIJDNDFJJD);
			}
		}
	}

	protected virtual void MLOKLGPGKMO()
	{
		if (m_AttachPrefab == null || m_AttachType != HKEFJJJIDJC.Active)
		{
			return;
		}
		if (!DMJHFKIKHMA)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			DMJHFKIKHMA = true;
		}
		if (HBDKLBHFLJK + m_fDelayTime <= NcEffectBehaviour.GetEngineTime())
		{
			MGKCAHIKOJG();
			if ((203f < m_fRepeatTime && m_nRepeatCount == 0) || AEOFIKHAPMJ < m_nRepeatCount)
			{
				HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
				m_fDelayTime = m_fRepeatTime;
			}
			else
			{
				base.enabled = true;
			}
		}
	}

	protected virtual void MKCBHHEACDE()
	{
		OGIMHCLKEBE = base.enabled && NcEffectBehaviour.JOCHMPKGGEN(base.gameObject) && GetComponent<NcDontActive>() == null;
	}

	protected virtual void Update()
	{
		if (m_AttachPrefab == null || m_AttachType != HKEFJJJIDJC.Active)
		{
			return;
		}
		if (!DMJHFKIKHMA)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			DMJHFKIKHMA = true;
		}
		if (HBDKLBHFLJK + m_fDelayTime <= NcEffectBehaviour.GetEngineTime())
		{
			MGKCAHIKOJG();
			if ((0f < m_fRepeatTime && m_nRepeatCount == 0) || AEOFIKHAPMJ < m_nRepeatCount)
			{
				HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
				m_fDelayTime = m_fRepeatTime;
			}
			else
			{
				base.enabled = false;
			}
		}
	}

	protected virtual void Awake()
	{
		OGIMHCLKEBE = base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && GetComponent<NcDontActive>() == null;
	}

	public GameObject GetInstanceObject()
	{
		if (NBICLPPFDJK == null)
		{
			UpdateImmediately();
		}
		return (NBICLPPFDJK != null && NBICLPPFDJK.Length >= 1) ? NBICLPPFDJK[0] : null;
	}
}
