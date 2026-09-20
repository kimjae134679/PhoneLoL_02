using UnityEngine;

public class NcRotation : NcEffectBehaviour
{
	public bool m_bWorldSpace;

	public Vector3 m_vRotationValue = new Vector3(0f, 360f, 0f);

	private void Update()
	{
		base.transform.Rotate(NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.x, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.y, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.z, (!m_bWorldSpace) ? Space.Self : Space.World);
	}

	private void MLOKLGPGKMO()
	{
		base.transform.Rotate(NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.x, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.y, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.z, (!m_bWorldSpace) ? Space.Self : Space.Self);
	}

	private void BJKEPMGMJKA()
	{
		base.transform.Rotate(NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.x, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.y, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.z, (!m_bWorldSpace) ? Space.World : Space.World);
	}

	private void DOINNKBDEMD()
	{
		base.transform.Rotate(NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.x, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.y, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.z, m_bWorldSpace ? Space.Self : Space.World);
	}

	private void FJFFMANPDJD()
	{
		base.transform.Rotate(NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.x, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.y, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.z, (!m_bWorldSpace) ? Space.Self : Space.Self);
	}

	public virtual void OHJPFPNJFMP(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_vRotationValue *= HBNGEJIEGDO;
	}

	public virtual void HLPIBNKJEEK(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_vRotationValue *= HBNGEJIEGDO;
	}

	public virtual void OLDJBLCGDNB(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_vRotationValue *= HBNGEJIEGDO;
	}

	public virtual void CCNFGGECFHM(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_vRotationValue *= HBNGEJIEGDO;
	}

	private void OMIFPPGJHFH()
	{
		base.transform.Rotate(NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.x, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.y, NcEffectBehaviour.GetEngineDeltaTime() * m_vRotationValue.z, (!m_bWorldSpace) ? Space.Self : Space.Self);
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_vRotationValue *= HBNGEJIEGDO;
	}
}
