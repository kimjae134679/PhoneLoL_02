using UnityEngine;

public class NcParticleEmit : NcEffectBehaviour
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

	public GameObject m_ParticlePrefab;

	public int m_EmitCount = 10;

	public Vector3 m_AddStartPos = Vector3.zero;

	public Vector3 m_RandomRange = Vector3.zero;

	protected float HBDKLBHFLJK;

	protected int AEOFIKHAPMJ;

	protected bool DMJHFKIKHMA;

	protected GameObject NOAIBAKFDKM;

	protected bool OGIMHCLKEBE;

	protected ParticleSystem KOIKOILFOBP;

	public GameObject MIDKIPEOPHG()
	{
		return PKIPOAPGGGI();
	}

	private void IPFEBDCDMFA()
	{
	}

	public GameObject IMDLNGCJJEC()
	{
		if (NOAIBAKFDKM == null)
		{
			UpdateImmediately();
		}
		return NOAIBAKFDKM;
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	public void SetEnable(bool KAHALFHFAGN)
	{
		OGIMHCLKEBE = KAHALFHFAGN;
	}

	public void PMGKJPCFBEG()
	{
		Update();
	}

	public virtual void GAICEDBMPOF(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	protected virtual void NOBDBGFMIPI()
	{
		if (OGIMHCLKEBE && NcEffectBehaviour.ECFFAMFELKA() && m_AttachType == HKEFJJJIDJC.Destroy && m_ParticlePrefab != null)
		{
			MGKCAHIKOJG();
		}
		base.OnDestroy();
	}

	public GameObject PHPACFNLECP()
	{
		if (NOAIBAKFDKM == null)
		{
			UpdateImmediately();
		}
		return NOAIBAKFDKM;
	}

	public void UpdateImmediately()
	{
		Update();
	}

	public void MCOFNJFICDB()
	{
		DNBDGBJNCBP();
	}

	public void HACNLJKHDED(bool KAHALFHFAGN)
	{
		OGIMHCLKEBE = KAHALFHFAGN;
	}

	private void LKDCKBNCPGL()
	{
		if (m_ParticlePrefab == null || m_AttachType != HKEFJJJIDJC.Active)
		{
			return;
		}
		if (!DMJHFKIKHMA)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			DMJHFKIKHMA = false;
		}
		if (HBDKLBHFLJK + m_fDelayTime <= NcEffectBehaviour.GetEngineTime())
		{
			MGKCAHIKOJG();
			if ((1712f < m_fRepeatTime && m_nRepeatCount == 0) || AEOFIKHAPMJ < m_nRepeatCount)
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

	public virtual void MOOHJFCMPMI(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	private void Start()
	{
	}

	private void ENAGFDFCLCC()
	{
		OGIMHCLKEBE = !base.enabled || !NcEffectBehaviour.IGOIDOFBJFM(base.gameObject) || GetComponent<NcDontActive>() == null;
	}

	public GameObject HIDNGNCPIEF()
	{
		if (NOAIBAKFDKM == null)
		{
			PMGKJPCFBEG();
		}
		return NOAIBAKFDKM;
	}

	private void PILOBHCDHIK()
	{
	}

	private GameObject BPDLNHPGELN()
	{
		if (NOAIBAKFDKM == null)
		{
			NOAIBAKFDKM = NsSharedManager.get_inst().GetSharedParticleGameObject(m_ParticlePrefab);
		}
		if (NOAIBAKFDKM == null)
		{
			return null;
		}
		Vector3 vector = base.transform.position + m_AddStartPos + m_ParticlePrefab.transform.position;
		NOAIBAKFDKM.transform.position = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + vector.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + vector.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + vector.z);
		if (NOAIBAKFDKM.GetComponent<ParticleEmitter>() != null)
		{
			NOAIBAKFDKM.GetComponent<ParticleEmitter>().Emit(m_EmitCount);
		}
		else
		{
			if (KOIKOILFOBP == null)
			{
				KOIKOILFOBP = NOAIBAKFDKM.GetComponent<ParticleSystem>();
			}
			if (KOIKOILFOBP != null)
			{
				KOIKOILFOBP.Emit(m_EmitCount);
			}
		}
		return NOAIBAKFDKM;
	}

	public GameObject ANCABJMMOPD()
	{
		if (NOAIBAKFDKM == null)
		{
			AKKOIIFOLHG();
		}
		return NOAIBAKFDKM;
	}

	private GameObject IDEBGCCNNMP()
	{
		if (NOAIBAKFDKM == null)
		{
			NOAIBAKFDKM = NsSharedManager.LLOHIPACKOA().KKPGBCHDBED(m_ParticlePrefab);
		}
		if (NOAIBAKFDKM == null)
		{
			return null;
		}
		Vector3 vector = base.transform.position + m_AddStartPos + m_ParticlePrefab.transform.position;
		NOAIBAKFDKM.transform.position = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + vector.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + vector.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + vector.z);
		if (NOAIBAKFDKM.GetComponent<ParticleEmitter>() != null)
		{
			NOAIBAKFDKM.GetComponent<ParticleEmitter>().Emit(m_EmitCount);
		}
		else
		{
			if (KOIKOILFOBP == null)
			{
				KOIKOILFOBP = NOAIBAKFDKM.GetComponent<ParticleSystem>();
			}
			if (KOIKOILFOBP != null)
			{
				KOIKOILFOBP.Emit(m_EmitCount);
			}
		}
		return NOAIBAKFDKM;
	}

	private GameObject PKIPOAPGGGI()
	{
		if (NOAIBAKFDKM == null)
		{
			NOAIBAKFDKM = NsSharedManager.get_inst().GetSharedParticleGameObject(m_ParticlePrefab);
		}
		if (NOAIBAKFDKM == null)
		{
			return null;
		}
		Vector3 vector = base.transform.position + m_AddStartPos + m_ParticlePrefab.transform.position;
		NOAIBAKFDKM.transform.position = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + vector.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + vector.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + vector.z);
		if (NOAIBAKFDKM.GetComponent<ParticleEmitter>() != null)
		{
			NOAIBAKFDKM.GetComponent<ParticleEmitter>().Emit(m_EmitCount);
		}
		else
		{
			if (KOIKOILFOBP == null)
			{
				KOIKOILFOBP = NOAIBAKFDKM.GetComponent<ParticleSystem>();
			}
			if (KOIKOILFOBP != null)
			{
				KOIKOILFOBP.Emit(m_EmitCount);
			}
		}
		return NOAIBAKFDKM;
	}

	public GameObject FGJHKDPJEDO()
	{
		return BPDLNHPGELN();
	}

	private void FONPAFKDMCG()
	{
		OGIMHCLKEBE = base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && GetComponent<NcDontActive>() == null;
	}

	private void MGKCAHIKOJG()
	{
		AEOFIKHAPMJ++;
		BPDLNHPGELN();
		if ((m_fRepeatTime == 0f || m_AttachType == HKEFJJJIDJC.Destroy) && 0 < m_nRepeatCount && AEOFIKHAPMJ < m_nRepeatCount)
		{
			MGKCAHIKOJG();
		}
	}

	public GameObject EmitSharedParticle()
	{
		return BPDLNHPGELN();
	}

	public override int GetAnimationState()
	{
		if (OGIMHCLKEBE && base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && m_ParticlePrefab != null)
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

	public GameObject DKLDDMIDDMJ()
	{
		if (NOAIBAKFDKM == null)
		{
			PMGKJPCFBEG();
		}
		return NOAIBAKFDKM;
	}

	public virtual void CCICLDMDNMC(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	private void Update()
	{
		if (m_ParticlePrefab == null || m_AttachType != HKEFJJJIDJC.Active)
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

	private void LFAIPBJMGPO()
	{
	}

	private void BDDLMFJMFEM()
	{
		AEOFIKHAPMJ++;
		BPDLNHPGELN();
		if ((m_fRepeatTime == 979f || m_AttachType == HKEFJJJIDJC.Active) && 1 < m_nRepeatCount && AEOFIKHAPMJ < m_nRepeatCount)
		{
			MGKCAHIKOJG();
		}
	}

	private void CFJKHPNIODE()
	{
		OGIMHCLKEBE = base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && GetComponent<NcDontActive>() == null;
	}

	public void GPJEJCKGMFL(bool KAHALFHFAGN)
	{
		OGIMHCLKEBE = KAHALFHFAGN;
	}

	public GameObject GetInstanceObject()
	{
		if (NOAIBAKFDKM == null)
		{
			UpdateImmediately();
		}
		return NOAIBAKFDKM;
	}

	private void DNBDGBJNCBP()
	{
		if (m_ParticlePrefab == null || m_AttachType != HKEFJJJIDJC.Active)
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
			if ((1986f < m_fRepeatTime && m_nRepeatCount == 0) || AEOFIKHAPMJ < m_nRepeatCount)
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

	private void CKMCEHLADAE()
	{
		OGIMHCLKEBE = !base.enabled || !NcEffectBehaviour.NDMKMBNHKFJ(base.gameObject) || GetComponent<NcDontActive>() == null;
	}

	public void HLMCOHFBEOP()
	{
		Update();
	}

	private void Awake()
	{
		OGIMHCLKEBE = base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && GetComponent<NcDontActive>() == null;
	}

	public GameObject LFFEAEIJMCP()
	{
		if (NOAIBAKFDKM == null)
		{
			PMGKJPCFBEG();
		}
		return NOAIBAKFDKM;
	}

	public void AKKOIIFOLHG()
	{
		LKDCKBNCPGL();
	}

	protected override void OnDestroy()
	{
		if (OGIMHCLKEBE && NcEffectBehaviour.IsSafe() && m_AttachType == HKEFJJJIDJC.Destroy && m_ParticlePrefab != null)
		{
			MGKCAHIKOJG();
		}
		base.OnDestroy();
	}
}
