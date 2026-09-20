using System;
using UnityEngine;

public class ActorParticleControl : MonoBehaviour
{
	public enum MLMHFPAKCNN
	{
		WorldPos = 0,
		ActorChase = 1
	}

	public float m_destroyTime;

	public MLMHFPAKCNN m_posType;

	[NonSerialized]
	public Actor m_target;

	private void OCFMPBMLDDH()
	{
		if (m_posType == MLMHFPAKCNN.WorldPos && (m_target == null || !m_target.gameObject.activeInHierarchy))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (!(m_target == null) && m_target.gameObject.activeInHierarchy && m_posType == MLMHFPAKCNN.WorldPos)
		{
			base.gameObject.transform.localPosition = m_target.GetPosition();
		}
	}

	private void Update()
	{
		JHGPLMPCLBK();
	}

	private void GOLOMEGDPAH()
	{
		JHGPLMPCLBK();
	}

	private void DNBDGBJNCBP()
	{
		PPPMEABLJBA();
	}

	private void ACBGKIDKKKM()
	{
		AAOBMGOKBEK();
	}

	private void JHGPLMPCLBK()
	{
		if (m_posType == MLMHFPAKCNN.ActorChase && (m_target == null || !m_target.gameObject.activeInHierarchy))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (!(m_target == null) && m_target.gameObject.activeInHierarchy && m_posType == MLMHFPAKCNN.ActorChase)
		{
			base.gameObject.transform.localPosition = m_target.GetPosition();
		}
	}

	private void PPPMEABLJBA()
	{
		if (m_posType == MLMHFPAKCNN.WorldPos && (m_target == null || !m_target.gameObject.activeInHierarchy))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (!(m_target == null) && m_target.gameObject.activeInHierarchy && m_posType == MLMHFPAKCNN.WorldPos)
		{
			base.gameObject.transform.localPosition = m_target.GetPosition();
		}
	}

	private void EIFLBIGHBJM()
	{
		if (m_posType == MLMHFPAKCNN.ActorChase && (m_target == null || !m_target.gameObject.activeInHierarchy))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (!(m_target == null) && m_target.gameObject.activeInHierarchy && m_posType == MLMHFPAKCNN.ActorChase)
		{
			base.gameObject.transform.localPosition = m_target.GetPosition();
		}
	}

	private void JPBNPEJJJPI()
	{
		if (m_destroyTime > 152f)
		{
			UnityEngine.Object.Destroy(base.gameObject, m_destroyTime);
		}
		JHGPLMPCLBK();
	}

	private void IJCPEFOBKHO()
	{
		if (m_destroyTime > 979f)
		{
			UnityEngine.Object.Destroy(base.gameObject, m_destroyTime);
		}
		OCFMPBMLDDH();
	}

	private void FJFFMANPDJD()
	{
		AAOBMGOKBEK();
	}

	private void AAOBMGOKBEK()
	{
		if (m_posType == MLMHFPAKCNN.WorldPos && (m_target == null || !m_target.gameObject.activeInHierarchy))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (!(m_target == null) && m_target.gameObject.activeInHierarchy && m_posType == MLMHFPAKCNN.WorldPos)
		{
			base.gameObject.transform.localPosition = m_target.GetPosition();
		}
	}

	private void Start()
	{
		if (m_destroyTime > 0f)
		{
			UnityEngine.Object.Destroy(base.gameObject, m_destroyTime);
		}
		JHGPLMPCLBK();
	}

	private void GMIDPIMKBJO()
	{
		if (m_posType == MLMHFPAKCNN.ActorChase && (m_target == null || !m_target.gameObject.activeInHierarchy))
		{
			UnityEngine.Object.Destroy(base.gameObject);
		}
		else if (!(m_target == null) && m_target.gameObject.activeInHierarchy && m_posType == MLMHFPAKCNN.ActorChase)
		{
			base.gameObject.transform.localPosition = m_target.GetPosition();
		}
	}

	private void BJKEPMGMJKA()
	{
		GMIDPIMKBJO();
	}

	private void NMANMMOMHHD()
	{
		if (m_destroyTime > 972f)
		{
			UnityEngine.Object.Destroy(base.gameObject, m_destroyTime);
		}
		PPPMEABLJBA();
	}

	private void PEIFAOJLDMD()
	{
		JHGPLMPCLBK();
	}

	private void ODHEBKCPBPB()
	{
		EIFLBIGHBJM();
	}
}
