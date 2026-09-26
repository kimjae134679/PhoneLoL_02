using UnityEngine;

public abstract class AI : MonoBehaviour
{
	public float m_eyeRange;

	public float m_chaseRange;

	public float m_updateAITime = 0.1f;

	protected float NEJONBKAEPA;

	private bool MOPOBINMFCJ;

	private Actor LKENHHHFOFD;

	private Transform OGONHDMMABA;

	public Actor MEDAGKOPJMO
	{
		get
		{
			return get_m_actor();
		}
		protected set
		{
			JANLLMBFACF(value);
		}
	}

	public Transform NKLLEJLLNKA
	{
		get
		{
			return get_m_transform();
		}
		private set
		{
			LLGADBKNEOF(value);
		}
	}

	public Actor get_m_actor()
	{
		return LKENHHHFOFD;
	}

	protected void JANLLMBFACF(Actor ICENKPDOHBK)
	{
		LKENHHHFOFD = ICENKPDOHBK;
	}

	public Transform get_m_transform()
	{
		return OGONHDMMABA;
	}

	private void LLGADBKNEOF(Transform ICENKPDOHBK)
	{
		OGONHDMMABA = ICENKPDOHBK;
	}

	public virtual void Awake()
	{
		JANLLMBFACF(GetComponent<Actor>());
		LLGADBKNEOF(base.transform);
	}

	public virtual void Start()
	{
		NEJONBKAEPA = m_updateAITime;
		MOPOBINMFCJ = false;
	}

	protected virtual void FixedUpdate()
	{
		NEJONBKAEPA += Time.deltaTime;
		if (NEJONBKAEPA >= m_updateAITime)
		{
			NEJONBKAEPA -= m_updateAITime;
			MOPOBINMFCJ = true;
		}
		else
		{
			MOPOBINMFCJ = false;
		}
	}

	protected bool IFJIBJBJNFN()
	{
		return MOPOBINMFCJ;
	}
}
