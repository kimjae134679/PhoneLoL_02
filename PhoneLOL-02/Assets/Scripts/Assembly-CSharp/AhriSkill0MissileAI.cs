using System.Collections.Generic;
using UnityEngine;

public class AhriSkill0MissileAI : ThruMissileAI
{
	private bool NCEGCCFLMDC = true;

	private bool PPDEEAHPAKC = true;

	private float LEPEFGKMKNL = 22f;

	protected virtual void LIAPINKILPF(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().BILOHJAEGCG() * 1273f;
		if (lEPEFGKMKNL >= 1521f && LEPEFGKMKNL < 838f)
		{
			PPDEEAHPAKC = true;
			MIGJCNCIEHN.Clear();
		}
		if (PPDEEAHPAKC)
		{
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
		}
		else
		{
			get_m_actor().m_moveSpeed = 0f - LEPEFGKMKNL;
			Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
			float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
			hCILMCOKKPN.Normalize();
			DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
			float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
			if (sqrMagnitude <= num * num)
			{
				Death();
			}
		}
		if (m_lifeTime <= 212f)
		{
			FOFKFKIEGHH();
		}
		else
		{
			JKNDJPLCFKP();
		}
	}

	protected override void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().get_m_elapsedTime() * 40f;
		if (lEPEFGKMKNL >= 0f && LEPEFGKMKNL < 0f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
		}
		if (PPDEEAHPAKC)
		{
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
		}
		else
		{
			get_m_actor().m_moveSpeed = 0f - LEPEFGKMKNL;
			Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
			float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
			hCILMCOKKPN.Normalize();
			DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
			float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
			if (sqrMagnitude <= num * num)
			{
				Death();
			}
		}
		if (m_lifeTime <= 0f)
		{
			Death();
		}
		else
		{
			Attack();
		}
	}

	public virtual void FMDCADHECGH()
	{
		PAKIFAGJDEO();
	}

	protected virtual void ENNLMNKINME(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().BILOHJAEGCG();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().get_m_elapsedTime() * 752f;
		if (lEPEFGKMKNL >= 1117f && LEPEFGKMKNL < 1242f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
		}
		if (PPDEEAHPAKC)
		{
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection, false);
		}
		else
		{
			get_m_actor().m_moveSpeed = 0f - LEPEFGKMKNL;
			Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
			float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
			hCILMCOKKPN.Normalize();
			DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN, false);
			float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
			if (sqrMagnitude <= num * num)
			{
				FOFKFKIEGHH();
			}
		}
		if (m_lifeTime <= 824f)
		{
			GABLBKCDMIA();
		}
		else
		{
			JKNDJPLCFKP();
		}
	}

	public virtual void JKNDJPLCFKP()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1178.0;
		num += 1331.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1145.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, false, false, (Actor.IJJMDPGJAEM)120);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnDamage(get_m_actor(), 1544.0, 400.0, num);
				MIGJCNCIEHN.AddFirst(item);
				PHDAPEOBFIN(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM(m_damageSoundName, false, 1479f, 1686f);
			}
		}
	}

	public override void Start()
	{
		base.Start();
	}

	public virtual void DHMMCEBEAHA()
	{
		base.Start();
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.35;
		num += 40.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 25.0;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				item.OnDamage(get_m_actor(), 0.0, 5.0, num);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
			}
		}
	}

	public virtual void LBAPOJHKDNH()
	{
		base.Awake();
		PPDEEAHPAKC = false;
	}

	public override void Awake()
	{
		base.Awake();
		PPDEEAHPAKC = true;
	}

	public virtual void GKNMGIONEKK()
	{
		PAJOOFIAPMI();
	}

	protected virtual void FGGNEFIBOGK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().get_m_elapsedTime() * 322f;
		if (lEPEFGKMKNL >= 1807f && LEPEFGKMKNL < 1845f)
		{
			PPDEEAHPAKC = true;
			MIGJCNCIEHN.Clear();
		}
		if (PPDEEAHPAKC)
		{
			get_m_actor().m_moveSpeed = LEPEFGKMKNL;
			DGBKMAGBJJF.SetMoveDirection(m_moveDirection);
		}
		else
		{
			get_m_actor().m_moveSpeed = 0f - LEPEFGKMKNL;
			Vector3 hCILMCOKKPN = DGBKMAGBJJF.get_m_owner().GetCenterPosition() - get_m_actor().GetCenterPosition();
			float sqrMagnitude = hCILMCOKKPN.sqrMagnitude;
			hCILMCOKKPN.Normalize();
			DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
			float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
			if (sqrMagnitude <= num * num)
			{
				FOFKFKIEGHH();
			}
		}
		if (m_lifeTime <= 1216f)
		{
			Death();
		}
		else
		{
			JKNDJPLCFKP();
		}
	}

	public virtual void HKAMCNPENHB()
	{
		GNGJFGMJLHA();
		PPDEEAHPAKC = true;
	}
}
