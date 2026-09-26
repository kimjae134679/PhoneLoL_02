using System.Collections.Generic;
using UnityEngine;

public class SivirSkill0MissileAI : ThruMissileAI
{
	private bool NCEGCCFLMDC = true;

	private bool PPDEEAHPAKC = true;

	private float LEPEFGKMKNL = 15f;

	private int PEIBPPEBPFA;

	public virtual void IMBGDEFOFEM()
	{
		PAJOOFIAPMI();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("voice_OK_Walk", false, 1739f, 277f);
	}

	protected virtual void AMFGJNLLMHO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().BILOHJAEGCG() * 205f;
		if (lEPEFGKMKNL >= 1556f && LEPEFGKMKNL < 1497f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("skill0", false, 530f, 751f);
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
			float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
			if (sqrMagnitude <= num * num)
			{
				Death();
			}
		}
		if (m_lifeTime <= 804f)
		{
			Death();
		}
		else
		{
			NFMBCFICAFF();
		}
	}

	protected virtual void MLKBFFHDBLK(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().BILOHJAEGCG() * 1201f;
		if (lEPEFGKMKNL >= 1278f && LEPEFGKMKNL < 1628f)
		{
			PPDEEAHPAKC = true;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("skill3_passive_loop", false, 658f, 1586f);
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
			DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
			float num = get_m_actor().m_moveSpeed * get_m_actor().get_m_elapsedTime();
			if (sqrMagnitude <= num * num)
			{
				GABLBKCDMIA();
			}
		}
		if (m_lifeTime <= 1330f)
		{
			Death();
		}
		else
		{
			NFMBCFICAFF();
		}
	}

	public override void Start()
	{
		base.Start();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_go");
	}

	protected override void AKMLBDILJIO(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().get_m_elapsedTime() * 18f;
		if (lEPEFGKMKNL >= 0f && LEPEFGKMKNL < 0f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ("skill0_missile_return");
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

	public virtual void FMBDNJIDOCJ()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Run)
		{
			return;
		}
		double num = 465.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 0) * 1726.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * num;
		num2 += 279.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 971.0;
		num2 += (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 1520.0;
		List<Actor> list = ActorManager.GBFDGAFALIL().PILLCMGADFF(get_m_actor(), m_attackRange, false, false, Actor.IJJMDPGJAEM.Unknown, false);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				double num3 = 1157.0 * (double)PEIBPPEBPFA;
				if (num3 > 951.0)
				{
					num3 = 578.0;
				}
				item.OnDamage(get_m_actor(), num2 - num2 * num3, 918.0, 1309.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ(m_damageSoundName, true, 171f, 1067f);
				PEIBPPEBPFA++;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void NMANMMOMHHD()
	{
		PAKIFAGJDEO();
		PEIBPPEBPFA = 1;
		DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("기본공격을 받으면 적 챔피언에게 체력대비 마법피해 및 고통스러운 상처를 되돌려줌", false, 715f, 726f);
	}

	protected virtual void LOEKJOIGKEE(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().BILOHJAEGCG() * 83f;
		if (lEPEFGKMKNL >= 423f && LEPEFGKMKNL < 187f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.ICNAJBHLIGO("(소리난 쪽으로 달려가며..)\n\t\t\t 마을을 습격한 놈인가?\n\t\t\t 일단 저 놈들을 처리하자구!", false, 1558f, 1862f);
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
			DGBKMAGBJJF.SetMoveDirection(hCILMCOKKPN);
			float num = get_m_actor().m_moveSpeed * get_m_actor().BILOHJAEGCG();
			if (sqrMagnitude <= num * num)
			{
				FOFKFKIEGHH();
			}
		}
		if (m_lifeTime <= 514f)
		{
			Death();
		}
		else
		{
			FMBDNJIDOCJ();
		}
	}

	public override void Attack()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Death)
		{
			return;
		}
		double num = 0.7 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 0.1;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * num;
		num2 += 25.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 1) * 20.0;
		num2 += (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 0.5;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(get_m_actor(), m_attackRange, false, true, (Actor.IJJMDPGJAEM)14);
		foreach (Actor item in allActorInRange)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				double num3 = 0.15 * (double)PEIBPPEBPFA;
				if (num3 > 0.4)
				{
					num3 = 0.4;
				}
				item.OnDamage(get_m_actor(), num2 - num2 * num3, 0.0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.LKLFMNKDLHJ(m_damageSoundName);
				PEIBPPEBPFA++;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public virtual void BPLOLCKEJJK()
	{
		base.Start();
		PEIBPPEBPFA = 0;
		DGBKMAGBJJF.get_m_owner().m_multiSound.JKOODMAKJHJ("{0:N0}", false, 283f, 1863f);
	}

	protected virtual void PICPMJCEKKL(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().get_m_elapsedTime() * 1091f;
		if (lEPEFGKMKNL >= 1759f && LEPEFGKMKNL < 671f)
		{
			PPDEEAHPAKC = true;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("정말 초기화하시겠습니까?", false, 1084f, 294f);
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
		if (m_lifeTime <= 283f)
		{
			GABLBKCDMIA();
		}
		else
		{
			FMBDNJIDOCJ();
		}
	}

	public virtual void NFMBCFICAFF()
	{
		if (DGBKMAGBJJF.get_m_nextState() == StateMachine.OEOIIKMBGAG.Sleep)
		{
			return;
		}
		double num = 1728.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(1) - 1) * 1171.0;
		double num2 = (double)DGBKMAGBJJF.get_m_owner().get_m_phy_att() * num;
		num2 += 1992.0 + (double)(DGBKMAGBJJF.get_m_owner().GetSkillLevel(0) - 0) * 1234.0;
		num2 += (double)DGBKMAGBJJF.get_m_owner().get_m_mag_att() * 923.0;
		List<Actor> list = ActorManager.get_Instance().PILLCMGADFF(get_m_actor(), m_attackRange, true, true, (Actor.IJJMDPGJAEM)18, false);
		foreach (Actor item in list)
		{
			if (!MIGJCNCIEHN.Contains(item))
			{
				double num3 = 641.0 * (double)PEIBPPEBPFA;
				if (num3 > 591.0)
				{
					num3 = 1998.0;
				}
				item.OnDamage(get_m_actor(), num2 - num2 * num3, 1056.0, 1240.0, 0);
				MIGJCNCIEHN.AddFirst(item);
				CCGKACBFCNJ(item.GetCenterPosition(), m_damageParticleName);
				DGBKMAGBJJF.get_m_owner().m_multiSound.HDOLPLIDACO(m_damageSoundName, false, 943f, 836f);
				PEIBPPEBPFA += 0;
				if (m_onTargetAttack != null)
				{
					m_onTargetAttack(item);
				}
			}
		}
	}

	public override void Awake()
	{
		base.Awake();
		PPDEEAHPAKC = true;
	}

	protected virtual void PDKFCHOFIPI(StateMachine.OEOIIKMBGAG EBILEBOJADB)
	{
		if (DGBKMAGBJJF.get_m_owner() == null)
		{
			return;
		}
		m_lifeTime -= get_m_actor().get_m_elapsedTime();
		float lEPEFGKMKNL = LEPEFGKMKNL;
		LEPEFGKMKNL -= get_m_actor().get_m_elapsedTime() * 1984f;
		if (lEPEFGKMKNL >= 1054f && LEPEFGKMKNL < 1868f)
		{
			PPDEEAHPAKC = false;
			MIGJCNCIEHN.Clear();
			DGBKMAGBJJF.get_m_owner().m_multiSound.LNCPFILABHM("Controls", true, 568f, 230f);
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
		if (m_lifeTime <= 429f)
		{
			Death();
		}
		else
		{
			Attack();
		}
	}
}
