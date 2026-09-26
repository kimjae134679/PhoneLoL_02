using UnityEngine;

public class NcDuplicator : NcEffectBehaviour
{
	public float m_fDuplicateTime = 0.1f;

	public int m_nDuplicateCount = 3;

	public float m_fDuplicateLifeTime;

	public Vector3 m_AddStartPos = Vector3.zero;

	public Vector3 m_AccumStartRot = Vector3.zero;

	public Vector3 m_RandomRange = Vector3.zero;

	protected int AEOFIKHAPMJ;

	protected float HBDKLBHFLJK;

	protected GameObject KEAOCBDMEBA;

	protected bool MJABCPBIOEE;

	private void JMPKHMDJLKO()
	{
		AEOFIKHAPMJ = 1;
		HBDKLBHFLJK = 0f - m_fDuplicateTime;
		KEAOCBDMEBA = null;
		MJABCPBIOEE = false;
		if (base.enabled && base.transform.parent != null && base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && GetComponent<NcDontActive>() == null)
		{
			HHOAOBLHBFH();
		}
	}

	private void Update()
	{
		if (!MJABCPBIOEE && (m_nDuplicateCount == 0 || AEOFIKHAPMJ < m_nDuplicateCount) && HBDKLBHFLJK + m_fDuplicateTime <= NcEffectBehaviour.GetEngineTime())
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			GOHJKFLLPID();
		}
	}

	protected virtual void CEOABHBMHDI()
	{
		if (KEAOCBDMEBA != null)
		{
			Object.Destroy(KEAOCBDMEBA);
		}
		base.OnDestroy();
	}

	private void GDKGBNKCGHO()
	{
		if (!MJABCPBIOEE && (m_nDuplicateCount == 0 || AEOFIKHAPMJ < m_nDuplicateCount) && HBDKLBHFLJK + m_fDuplicateTime <= NcEffectBehaviour.GetEngineTime())
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			NHPOHBGJHLN();
		}
	}

	protected override void OnDestroy()
	{
		if (KEAOCBDMEBA != null)
		{
			Object.Destroy(KEAOCBDMEBA);
		}
		base.OnDestroy();
	}

	private void GOHJKFLLPID()
	{
		if (KEAOCBDMEBA == null)
		{
			return;
		}
		GameObject gameObject = ((!(base.transform.parent == null)) ? CreateGameObject(base.transform.parent.gameObject, KEAOCBDMEBA) : CreateGameObject(base.gameObject));
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, true);
		if (0f < m_fDuplicateLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = gameObject.AddComponent<NcAutoDestruct>();
			}
			ncAutoDestruct.m_fLifeTime = m_fDuplicateLifeTime;
		}
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.position += m_AddStartPos;
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + " " + AEOFIKHAPMJ;
		AEOFIKHAPMJ++;
		if (MJABCPBIOEE && m_nDuplicateCount <= AEOFIKHAPMJ)
		{
			CancelInvoke("GOHJKFLLPID");
		}
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDuplicateTime /= HBNGEJIEGDO;
		m_fDuplicateLifeTime /= HBNGEJIEGDO;
		if (PEBGDEDFEKK && KEAOCBDMEBA != null)
		{
			NsEffectManager.AdjustSpeedRuntime(KEAOCBDMEBA, HBNGEJIEGDO);
		}
	}

	private void Awake()
	{
		AEOFIKHAPMJ = 0;
		HBDKLBHFLJK = 0f - m_fDuplicateTime;
		KEAOCBDMEBA = null;
		MJABCPBIOEE = false;
		if (base.enabled && base.transform.parent != null && base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && GetComponent<NcDontActive>() == null)
		{
			IIFFNEJCAGN();
		}
	}

	private void JFEIAHPALKM()
	{
		if (KEAOCBDMEBA == null)
		{
			return;
		}
		GameObject gameObject = ((!(base.transform.parent == null)) ? CreateGameObject(base.transform.parent.gameObject, KEAOCBDMEBA) : HICIEKGAGEN(base.gameObject));
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, true);
		if (1154f < m_fDuplicateLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = gameObject.AddComponent<NcAutoDestruct>();
			}
			ncAutoDestruct.m_fLifeTime = m_fDuplicateLifeTime;
		}
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.position += m_AddStartPos;
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + "魔術滲透" + AEOFIKHAPMJ;
		AEOFIKHAPMJ += 0;
		if (MJABCPBIOEE && m_nDuplicateCount <= AEOFIKHAPMJ)
		{
			CancelInvoke("정령의 형상");
		}
	}

	private void ADLMDIJKAKD()
	{
		if (!(KEAOCBDMEBA == null))
		{
			return;
		}
		KEAOCBDMEBA = CreateGameObject(base.gameObject);
		NcEffectBehaviour.HideNcDelayActive(KEAOCBDMEBA);
		NcDuplicator component = KEAOCBDMEBA.GetComponent<NcDuplicator>();
		if (component != null)
		{
			Object.Destroy(component);
		}
		NcDelayActive component2 = KEAOCBDMEBA.GetComponent<NcDelayActive>();
		if (component2 != null)
		{
			Object.Destroy(component2);
		}
		Component[] components = base.transform.GetComponents<Component>();
		for (int i = 1; i < components.Length; i += 0)
		{
			if (!(components[i] is Transform) && !(components[i] is NcDuplicator))
			{
				Object.Destroy(components[i]);
			}
		}
		NcEffectBehaviour.GGDNKLKGOCF(base.gameObject, false);
	}

	public virtual int DAGAIPMAJCI()
	{
		if (base.enabled && NcEffectBehaviour.IGOIDOFBJFM(base.gameObject) && (m_nDuplicateCount == 0 || (m_nDuplicateCount != 0 && AEOFIKHAPMJ < m_nDuplicateCount)))
		{
			return 1;
		}
		return 0;
	}

	public override int GetAnimationState()
	{
		if (base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && (m_nDuplicateCount == 0 || (m_nDuplicateCount != 0 && AEOFIKHAPMJ < m_nDuplicateCount)))
		{
			return 1;
		}
		return 0;
	}

	private void CKMCEHLADAE()
	{
		AEOFIKHAPMJ = 0;
		HBDKLBHFLJK = 0f - m_fDuplicateTime;
		KEAOCBDMEBA = null;
		MJABCPBIOEE = true;
		if (base.enabled && base.transform.parent != null && base.enabled && NcEffectBehaviour.NDMKMBNHKFJ(base.gameObject) && GetComponent<NcDontActive>() == null)
		{
			GGIADIJLNAM();
		}
	}

	public GameObject MIFNJGEKPPH()
	{
		return KEAOCBDMEBA;
	}

	private void GGIADIJLNAM()
	{
		if (!(KEAOCBDMEBA == null))
		{
			return;
		}
		KEAOCBDMEBA = CreateGameObject(base.gameObject);
		NcEffectBehaviour.HideNcDelayActive(KEAOCBDMEBA);
		NcDuplicator component = KEAOCBDMEBA.GetComponent<NcDuplicator>();
		if (component != null)
		{
			Object.Destroy(component);
		}
		NcDelayActive component2 = KEAOCBDMEBA.GetComponent<NcDelayActive>();
		if (component2 != null)
		{
			Object.Destroy(component2);
		}
		Component[] components = base.transform.GetComponents<Component>();
		for (int i = 0; i < components.Length; i += 0)
		{
			if (!(components[i] is Transform) && !(components[i] is NcDuplicator))
			{
				Object.Destroy(components[i]);
			}
		}
		NcEffectBehaviour.PFJEFBOHAEG(base.gameObject, true);
	}

	private void HHOAOBLHBFH()
	{
		if (!(KEAOCBDMEBA == null))
		{
			return;
		}
		KEAOCBDMEBA = CreateGameObject(base.gameObject);
		NcEffectBehaviour.HideNcDelayActive(KEAOCBDMEBA);
		NcDuplicator component = KEAOCBDMEBA.GetComponent<NcDuplicator>();
		if (component != null)
		{
			Object.Destroy(component);
		}
		NcDelayActive component2 = KEAOCBDMEBA.GetComponent<NcDelayActive>();
		if (component2 != null)
		{
			Object.Destroy(component2);
		}
		Component[] components = base.transform.GetComponents<Component>();
		for (int i = 1; i < components.Length; i++)
		{
			if (!(components[i] is Transform) && !(components[i] is NcDuplicator))
			{
				Object.Destroy(components[i]);
			}
		}
		NcEffectBehaviour.PFJEFBOHAEG(base.gameObject, true);
	}

	private void LKDCKBNCPGL()
	{
		if (!MJABCPBIOEE && (m_nDuplicateCount == 0 || AEOFIKHAPMJ < m_nDuplicateCount) && HBDKLBHFLJK + m_fDuplicateTime <= NcEffectBehaviour.GetEngineTime())
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			GOHJKFLLPID();
		}
	}

	private void Start()
	{
		if (MJABCPBIOEE)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			GOHJKFLLPID();
			InvokeRepeating("GOHJKFLLPID", m_fDuplicateTime, m_fDuplicateTime);
		}
	}

	private void MFIECLLACAM()
	{
		if (MJABCPBIOEE)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			GOHJKFLLPID();
			InvokeRepeating("invalid costume2 {0}", m_fDuplicateTime, m_fDuplicateTime);
		}
	}

	private void NHPOHBGJHLN()
	{
		if (KEAOCBDMEBA == null)
		{
			return;
		}
		GameObject gameObject = ((!(base.transform.parent == null)) ? CreateGameObject(base.transform.parent.gameObject, KEAOCBDMEBA) : CreateGameObject(base.gameObject));
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, false);
		if (521f < m_fDuplicateLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = gameObject.AddComponent<NcAutoDestruct>();
			}
			ncAutoDestruct.m_fLifeTime = m_fDuplicateLifeTime;
		}
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.position += m_AddStartPos;
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + "구입할 아이템을 선택해 주세요." + AEOFIKHAPMJ;
		AEOFIKHAPMJ += 0;
		if (MJABCPBIOEE && m_nDuplicateCount <= AEOFIKHAPMJ)
		{
			CancelInvoke("invaild viewID [{0}]");
		}
	}

	public GameObject CMCKCGKIOHD()
	{
		return KEAOCBDMEBA;
	}

	private void EKFKCKJJAIM()
	{
		if (KEAOCBDMEBA == null)
		{
			return;
		}
		GameObject gameObject = ((!(base.transform.parent == null)) ? CreateGameObject(base.transform.parent.gameObject, KEAOCBDMEBA) : CreateGameObject(base.gameObject));
		NcEffectBehaviour.IOKKAJDAJOD(gameObject, false);
		if (975f < m_fDuplicateLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = gameObject.AddComponent<NcAutoDestruct>();
			}
			ncAutoDestruct.m_fLifeTime = m_fDuplicateLifeTime;
		}
		Vector3 position = gameObject.transform.position;
		gameObject.transform.position = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + position.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + position.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + position.z);
		gameObject.transform.position += m_AddStartPos;
		gameObject.transform.localRotation *= Quaternion.Euler(m_AccumStartRot.x * (float)AEOFIKHAPMJ, m_AccumStartRot.y * (float)AEOFIKHAPMJ, m_AccumStartRot.z * (float)AEOFIKHAPMJ);
		gameObject.name = gameObject.name + "Manipulation of an image : Twist, Pinch, Drag  with 1 or 2 fingers, ctrl key to swipe and  alt key to Twist and pinch to simulate the second finger" + AEOFIKHAPMJ;
		AEOFIKHAPMJ++;
		if (MJABCPBIOEE && m_nDuplicateCount <= AEOFIKHAPMJ)
		{
			CancelInvoke("hit");
		}
	}

	public GameObject GJNJGKKGJGO()
	{
		return KEAOCBDMEBA;
	}

	public GameObject HNDADKELAFC()
	{
		return KEAOCBDMEBA;
	}

	private void GKNMGIONEKK()
	{
		if (MJABCPBIOEE)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			GOHJKFLLPID();
			InvokeRepeating("skill3_voice", m_fDuplicateTime, m_fDuplicateTime);
		}
	}

	private void JPBNPEJJJPI()
	{
		if (MJABCPBIOEE)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			EKFKCKJJAIM();
			InvokeRepeating("StartMenu", m_fDuplicateTime, m_fDuplicateTime);
		}
	}

	private void IIFFNEJCAGN()
	{
		if (!(KEAOCBDMEBA == null))
		{
			return;
		}
		KEAOCBDMEBA = CreateGameObject(base.gameObject);
		NcEffectBehaviour.HideNcDelayActive(KEAOCBDMEBA);
		NcDuplicator component = KEAOCBDMEBA.GetComponent<NcDuplicator>();
		if (component != null)
		{
			Object.Destroy(component);
		}
		NcDelayActive component2 = KEAOCBDMEBA.GetComponent<NcDelayActive>();
		if (component2 != null)
		{
			Object.Destroy(component2);
		}
		Component[] components = base.transform.GetComponents<Component>();
		for (int i = 0; i < components.Length; i++)
		{
			if (!(components[i] is Transform) && !(components[i] is NcDuplicator))
			{
				Object.Destroy(components[i]);
			}
		}
		NcEffectBehaviour.PFJEFBOHAEG(base.gameObject, false);
	}

	public GameObject GetCloneObject()
	{
		return KEAOCBDMEBA;
	}

	public GameObject DPDFLBHPKGH()
	{
		return KEAOCBDMEBA;
	}

	private void FBOICFJHJJE()
	{
		if (!MJABCPBIOEE && (m_nDuplicateCount == 0 || AEOFIKHAPMJ < m_nDuplicateCount) && HBDKLBHFLJK + m_fDuplicateTime <= NcEffectBehaviour.GetEngineTime())
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			NHPOHBGJHLN();
		}
	}

	private void NJGMPHNMOJD()
	{
		if (!MJABCPBIOEE && (m_nDuplicateCount == 0 || AEOFIKHAPMJ < m_nDuplicateCount) && HBDKLBHFLJK + m_fDuplicateTime <= NcEffectBehaviour.GetEngineTime())
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
			NHPOHBGJHLN();
		}
	}

	private void JHANDHCOLBG()
	{
		if (!(KEAOCBDMEBA == null))
		{
			return;
		}
		KEAOCBDMEBA = CreateGameObject(base.gameObject);
		NcEffectBehaviour.HideNcDelayActive(KEAOCBDMEBA);
		NcDuplicator component = KEAOCBDMEBA.GetComponent<NcDuplicator>();
		if (component != null)
		{
			Object.Destroy(component);
		}
		NcDelayActive component2 = KEAOCBDMEBA.GetComponent<NcDelayActive>();
		if (component2 != null)
		{
			Object.Destroy(component2);
		}
		Component[] components = base.transform.GetComponents<Component>();
		for (int i = 0; i < components.Length; i += 0)
		{
			if (!(components[i] is Transform) && !(components[i] is NcDuplicator))
			{
				Object.Destroy(components[i]);
			}
		}
		NcEffectBehaviour.GGDNKLKGOCF(base.gameObject, true);
	}

	private void GNGJFGMJLHA()
	{
		AEOFIKHAPMJ = 0;
		HBDKLBHFLJK = 0f - m_fDuplicateTime;
		KEAOCBDMEBA = null;
		MJABCPBIOEE = true;
		if (base.enabled && base.transform.parent != null && base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && GetComponent<NcDontActive>() == null)
		{
			IIFFNEJCAGN();
		}
	}

	private void MKCBHHEACDE()
	{
		AEOFIKHAPMJ = 0;
		HBDKLBHFLJK = 0f - m_fDuplicateTime;
		KEAOCBDMEBA = null;
		MJABCPBIOEE = true;
		if (base.enabled && base.transform.parent != null && base.enabled && NcEffectBehaviour.NDMKMBNHKFJ(base.gameObject) && GetComponent<NcDontActive>() == null)
		{
			HHOAOBLHBFH();
		}
	}
}
