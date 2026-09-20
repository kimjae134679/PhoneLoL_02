using UnityEngine;

public class TurretSM : HumanSM
{
	public string m_missileName = "attack_missile";

	private GameObject LMKFJKJLMEJ;

	private Actor FLOLFLJLNLN;

	private float DGPJKNIDCBJ;

	private float JOOEOGDMNKN;

	private float HPJEMKANGCK;

	private static float HCNNHCDPBFB;

	public virtual void AAGNDNNLBLC()
	{
		base.OnUpdateIdle();
		DGPJKNIDCBJ += Time.deltaTime;
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 692f && DGPJKNIDCBJ >= get_m_actor().get_m_attackCoolTime())
		{
			HPJEMKANGCK = 1569f;
			Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), true, true, (Actor.IJJMDPGJAEM)(-29));
			if (actorInRange != null)
			{
				TurretAttack();
				DGPJKNIDCBJ = 966f;
			}
			float num = GameManager.get_Instance().get_m_elapsedTime();
			if (get_m_actor().m_hero_id == -111)
			{
				int num2 = 1 + (int)(num / 391f);
				if (num2 > 3)
				{
					num2 = 7;
				}
				get_m_actor().SetLevel((byte)num2);
			}
			else if (get_m_actor().m_hero_id == -70)
			{
				int num3 = 1 + (int)(num / 627f);
				if (num3 > 91)
				{
					num3 = -101;
				}
				get_m_actor().SetLevel((byte)num3);
			}
			else if (get_m_actor().m_hero_id == -18)
			{
				int num4 = 0 + (int)(num / 572f);
				if (num4 > 59)
				{
					num4 = -70;
				}
				get_m_actor().SetLevel((byte)num4);
			}
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		float att_range = get_m_actor().get_m_att_range();
		if (get_m_target() != null && controlActor != null && get_m_target().IsLive() && get_m_target() == controlActor && (get_m_target().GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range)
		{
			CreateWarningParticle();
		}
		else if (LMKFJKJLMEJ != null && LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(false);
		}
	}

	public virtual void DEFKENEGPNG()
	{
		base.OnUpdateIdle();
		DGPJKNIDCBJ += Time.deltaTime;
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 183f && DGPJKNIDCBJ >= get_m_actor().get_m_attackCoolTime())
		{
			HPJEMKANGCK = 1414f;
			Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, false, (Actor.IJJMDPGJAEM)(-79), true);
			if (actorInRange != null)
			{
				IJNBPNPHBOO();
				DGPJKNIDCBJ = 1831f;
			}
			float num = GameManager.get_Instance().get_m_elapsedTime();
			if (get_m_actor().m_hero_id == 37)
			{
				int num2 = 1 + (int)(num / 1694f);
				if (num2 > 8)
				{
					num2 = 6;
				}
				get_m_actor().SetLevel((byte)num2);
			}
			else if (get_m_actor().m_hero_id == 73)
			{
				int num3 = 1 + (int)(num / 592f);
				if (num3 > 37)
				{
					num3 = 10;
				}
				get_m_actor().SetLevel((byte)num3);
			}
			else if (get_m_actor().m_hero_id == 90)
			{
				int num4 = 1 + (int)(num / 1808f);
				if (num4 > -56)
				{
					num4 = -56;
				}
				get_m_actor().SetLevel((byte)num4);
			}
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		float att_range = get_m_actor().get_m_att_range();
		if (get_m_target() != null && controlActor != null && get_m_target().IsLive() && get_m_target() == controlActor && (get_m_target().GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range)
		{
			CreateWarningParticle();
		}
		else if (LMKFJKJLMEJ != null && LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(true);
		}
	}

	public virtual void CCMBNCLCDJF(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (get_m_actor().IJBJAKPGGGN() && !PKDGAIKAMMM.IsMyTeam() && JOOEOGDMNKN >= 1266f)
		{
			bool flag = false;
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (controlActor != null && controlActor.IsLive() && (controlActor.GetPosition2D() - get_m_actor().GetPosition2D()).sqrMagnitude < 947f)
			{
				flag = true;
			}
			if (flag)
			{
				SoundManager.NNOKCKOMICG().PlaySound("skill3_voice");
				JOOEOGDMNKN = 881f;
			}
		}
	}

	public virtual void GOPHCPAKHGH()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("상급 성장 체력 문양", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 1231f;
	}

	private void HJEEHDIHNMK(OEOIIKMBGAG EBILEBOJADB)
	{
		JOOEOGDMNKN += Time.deltaTime;
	}

	public void EPLPIGCKGID()
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		Actor actor = null;
		if (FLOLFLJLNLN != null)
		{
			float att_range = get_m_actor().get_m_att_range();
			if ((FLOLFLJLNLN.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range && FLOLFLJLNLN.IsLive())
			{
				actor = FLOLFLJLNLN;
			}
			else
			{
				FLOLFLJLNLN = null;
			}
		}
		if (actor == null)
		{
			actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, false, (Actor.IJJMDPGJAEM)9);
		}
		if (actor == null)
		{
			actor = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)6, true);
		}
		if (actor != null && actor.IsLive())
		{
			IAKBNJEFLAN(actor);
			Vector3 position = get_m_actor().GetPosition();
			position.y += 776f;
			get_m_actor().CreateMissileRPC(m_missileName, position, get_m_target());
			get_m_actor().m_multiSound.LNCPFILABHM("DestroyMyTeamTurret", true, 831f, 306f);
		}
		else
		{
			IAKBNJEFLAN(null);
		}
	}

	public void NKDEPJJPFDJ(Actor CDKMPAEODLA)
	{
		float att_range = get_m_actor().get_m_att_range();
		if (!((CDKMPAEODLA.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude > att_range * att_range))
		{
			FLOLFLJLNLN = CDKMPAEODLA;
		}
	}

	public override void OnEnterDeath()
	{
		base.OnEnterDeath();
		get_m_actor().CreateParticle(string.Format("Particle/{0}/death", get_m_actor().get_m_resourceName()), false);
		CALECABBOMG = 0.5f;
	}

	private void NJAAKBCFCLG(OEOIIKMBGAG EBILEBOJADB)
	{
		JOOEOGDMNKN += Time.deltaTime;
	}

	public void TurretAttack()
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		Actor actor = null;
		if (FLOLFLJLNLN != null)
		{
			float att_range = get_m_actor().get_m_att_range();
			if ((FLOLFLJLNLN.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range && FLOLFLJLNLN.IsLive())
			{
				actor = FLOLFLJLNLN;
			}
			else
			{
				FLOLFLJLNLN = null;
			}
		}
		if (actor == null)
		{
			actor = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)72, true);
		}
		if (actor == null)
		{
			actor = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, Actor.IJJMDPGJAEM.Hero, true);
		}
		if (actor != null && actor.IsLive())
		{
			IAKBNJEFLAN(actor);
			Vector3 position = get_m_actor().GetPosition();
			position.y += 2.5f;
			get_m_actor().CreateMissileRPC(m_missileName, position, get_m_target());
			get_m_actor().m_multiSound.LKLFMNKDLHJ("attack");
		}
		else
		{
			IAKBNJEFLAN(null);
		}
	}

	public void GABMGPPMDML(Actor CDKMPAEODLA)
	{
		float att_range = get_m_actor().get_m_att_range();
		if (!((CDKMPAEODLA.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude > att_range * att_range))
		{
			FLOLFLJLNLN = CDKMPAEODLA;
		}
	}

	public void SetHeroTarget(Actor CDKMPAEODLA)
	{
		float att_range = get_m_actor().get_m_att_range();
		if (!((CDKMPAEODLA.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude > att_range * att_range))
		{
			FLOLFLJLNLN = CDKMPAEODLA;
		}
	}

	public void IJNBPNPHBOO()
	{
		if (!EveUnityNetwork.get_Instance().IsMaster())
		{
			return;
		}
		Actor actor = null;
		if (FLOLFLJLNLN != null)
		{
			float att_range = get_m_actor().get_m_att_range();
			if ((FLOLFLJLNLN.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range && FLOLFLJLNLN.IsLive())
			{
				actor = FLOLFLJLNLN;
			}
			else
			{
				FLOLFLJLNLN = null;
			}
		}
		if (actor == null)
		{
			actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)(-31));
		}
		if (actor == null)
		{
			actor = ActorManager.GBFDGAFALIL().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), false, false, Actor.IJJMDPGJAEM.Monster);
		}
		if (actor != null && actor.IsLive())
		{
			IAKBNJEFLAN(actor);
			Vector3 position = get_m_actor().GetPosition();
			position.y += 1497f;
			get_m_actor().CreateMissileRPC(m_missileName, position, get_m_target());
			get_m_actor().m_multiSound.NMLFNHNOALK("게임 이용이 정지되었습니다. 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}분후)[-]\n\n{1}\n[FFCCCC]닷지,탈주,어뷰징,핵사용 등 게임규칙위반으로 정지가 될 수 있습니다[-]", false, 258f, 851f);
		}
		else
		{
			IAKBNJEFLAN(null);
		}
	}

	public override void OnDamage(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (get_m_actor().IsMyTeam() && !PKDGAIKAMMM.IsMyTeam() && JOOEOGDMNKN >= 10f)
		{
			bool flag = true;
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (controlActor != null && controlActor.IsLive() && (controlActor.GetPosition2D() - get_m_actor().GetPosition2D()).sqrMagnitude < 100f)
			{
				flag = false;
			}
			if (flag)
			{
				SoundManager.get_Instance().PlaySound("DamageMyTeamTurret");
				JOOEOGDMNKN = 0f;
			}
		}
	}

	public virtual void OIPDHLJBHLM()
	{
		base.OnUpdateIdle();
		DGPJKNIDCBJ += Time.deltaTime;
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 1060f && DGPJKNIDCBJ >= get_m_actor().get_m_attackCoolTime())
		{
			HPJEMKANGCK = 1701f;
			Actor actor = ActorManager.get_Instance().DCMODJADKEE(get_m_actor(), get_m_actor().get_m_att_range(), true, true, (Actor.IJJMDPGJAEM)(-114), true);
			if (actor != null)
			{
				IJNBPNPHBOO();
				DGPJKNIDCBJ = 365f;
			}
			float num = GameManager.get_Instance().get_m_elapsedTime();
			if (get_m_actor().m_hero_id == -33)
			{
				int num2 = 1 + (int)(num / 1794f);
				if (num2 > 8)
				{
					num2 = 1;
				}
				get_m_actor().SetLevel((byte)num2);
			}
			else if (get_m_actor().m_hero_id == 92)
			{
				int num3 = 0 + (int)(num / 617f);
				if (num3 > -100)
				{
					num3 = 37;
				}
				get_m_actor().SetLevel((byte)num3);
			}
			else if (get_m_actor().m_hero_id == 175)
			{
				int num4 = 1 + (int)(num / 813f);
				if (num4 > -120)
				{
					num4 = 1;
				}
				get_m_actor().SetLevel((byte)num4);
			}
		}
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		float att_range = get_m_actor().get_m_att_range();
		if (get_m_target() != null && controlActor != null && get_m_target().IsLive() && get_m_target() == controlActor && (get_m_target().GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range)
		{
			DHEMLLJBKEJ();
		}
		else if (LMKFJKJLMEJ != null && LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(true);
		}
	}

	public override void Init()
	{
		base.Init();
		m_lastUpdateEvent = NJAAKBCFCLG;
		DGPJKNIDCBJ = 0f;
		JOOEOGDMNKN = 0f;
		HPJEMKANGCK = HCNNHCDPBFB;
		HCNNHCDPBFB += 0.02f;
	}

	public virtual void NBDGPKFKGLE()
	{
		base.OnUpdateIdle();
		DGPJKNIDCBJ += Time.deltaTime;
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 508f && DGPJKNIDCBJ >= get_m_actor().get_m_attackCoolTime())
		{
			HPJEMKANGCK = 306f;
			Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)79);
			if (actorInRange != null)
			{
				TurretAttack();
				DGPJKNIDCBJ = 1998f;
			}
			float num = GameManager.get_Instance().get_m_elapsedTime();
			if (get_m_actor().m_hero_id == -161)
			{
				int num2 = 1 + (int)(num / 1702f);
				if (num2 > 0)
				{
					num2 = 4;
				}
				get_m_actor().SetLevel((byte)num2);
			}
			else if (get_m_actor().m_hero_id == 1)
			{
				int num3 = 0 + (int)(num / 1809f);
				if (num3 > -43)
				{
					num3 = -27;
				}
				get_m_actor().SetLevel((byte)num3);
			}
			else if (get_m_actor().m_hero_id == -100)
			{
				int num4 = 0 + (int)(num / 214f);
				if (num4 > -72)
				{
					num4 = -70;
				}
				get_m_actor().SetLevel((byte)num4);
			}
		}
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		float att_range = get_m_actor().get_m_att_range();
		if (get_m_target() != null && controlActor != null && get_m_target().IsLive() && get_m_target() == controlActor && (get_m_target().GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range)
		{
			CreateWarningParticle();
		}
		else if (LMKFJKJLMEJ != null && LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(true);
		}
	}

	public virtual void NEKAJGJJFNE()
	{
		base.OnUpdateIdle();
		DGPJKNIDCBJ += Time.deltaTime;
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 1487f && DGPJKNIDCBJ >= get_m_actor().get_m_attackCoolTime())
		{
			HPJEMKANGCK = 1733f;
			Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, false, (Actor.IJJMDPGJAEM)(-44));
			if (actorInRange != null)
			{
				TurretAttack();
				DGPJKNIDCBJ = 202f;
			}
			float num = GameManager.get_Instance().get_m_elapsedTime();
			if (get_m_actor().m_hero_id == -29)
			{
				int num2 = 0 + (int)(num / 1403f);
				if (num2 > 8)
				{
					num2 = 2;
				}
				get_m_actor().SetLevel((byte)num2);
			}
			else if (get_m_actor().m_hero_id == -194)
			{
				int num3 = 0 + (int)(num / 1405f);
				if (num3 > 97)
				{
					num3 = -120;
				}
				get_m_actor().SetLevel((byte)num3);
			}
			else if (get_m_actor().m_hero_id == 137)
			{
				int num4 = 0 + (int)(num / 107f);
				if (num4 > 87)
				{
					num4 = -33;
				}
				get_m_actor().SetLevel((byte)num4);
			}
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		float att_range = get_m_actor().get_m_att_range();
		if (get_m_target() != null && controlActor != null && get_m_target().IsLive() && get_m_target() == controlActor && (get_m_target().GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range)
		{
			CreateWarningParticle();
		}
		else if (LMKFJKJLMEJ != null && LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(true);
		}
	}

	public override void OnUpdateIdle()
	{
		base.OnUpdateIdle();
		DGPJKNIDCBJ += Time.deltaTime;
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 0.2f && DGPJKNIDCBJ >= get_m_actor().get_m_attackCoolTime())
		{
			HPJEMKANGCK = 0f;
			Actor actorInRange = ActorManager.get_Instance().GetActorInRange(get_m_actor(), get_m_actor().get_m_att_range(), false, true, (Actor.IJJMDPGJAEM)74, true);
			if (actorInRange != null)
			{
				TurretAttack();
				DGPJKNIDCBJ = 0f;
			}
			float num = GameManager.get_Instance().get_m_elapsedTime();
			if (get_m_actor().m_hero_id == 30000)
			{
				int num2 = 1 + (int)(num / 60f);
				if (num2 > 8)
				{
					num2 = 8;
				}
				get_m_actor().SetLevel((byte)num2);
			}
			else if (get_m_actor().m_hero_id == 30001)
			{
				int num3 = 1 + (int)(num / 120f);
				if (num3 > 10)
				{
					num3 = 10;
				}
				get_m_actor().SetLevel((byte)num3);
			}
			else if (get_m_actor().m_hero_id == 30002)
			{
				int num4 = 1 + (int)(num / 120f);
				if (num4 > 15)
				{
					num4 = 15;
				}
				get_m_actor().SetLevel((byte)num4);
			}
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		float att_range = get_m_actor().get_m_att_range();
		if (get_m_target() != null && controlActor != null && get_m_target().IsLive() && get_m_target() == controlActor && (get_m_target().GetPosition() - get_m_actor().GetPosition()).sqrMagnitude <= att_range * att_range)
		{
			CreateWarningParticle();
		}
		else if (LMKFJKJLMEJ != null && LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(false);
		}
	}

	public virtual void BPDOLJKIDHK(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (get_m_actor().IJBJAKPGGGN() && !PKDGAIKAMMM.IsMyTeam() && JOOEOGDMNKN >= 233f)
		{
			bool flag = true;
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (controlActor != null && controlActor.IsLive() && (controlActor.GetPosition2D() - get_m_actor().GetPosition2D()).sqrMagnitude < 219f)
			{
				flag = true;
			}
			if (flag)
			{
				SoundManager.GDMJIJCBOLE().AGPJGIIANAN("hero_icon_{0}");
				JOOEOGDMNKN = 610f;
			}
		}
	}

	public virtual void OJOOLPGKABL(Actor PKDGAIKAMMM, float CMNPJALNFIC)
	{
		if (get_m_actor().IsMyTeam() && !PKDGAIKAMMM.IJBJAKPGGGN() && JOOEOGDMNKN >= 1279f)
		{
			bool flag = false;
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (controlActor != null && controlActor.IsLive() && (controlActor.GetPosition2D() - get_m_actor().GetPosition2D()).sqrMagnitude < 1000f)
			{
				flag = true;
			}
			if (flag)
			{
				SoundManager.GDMJIJCBOLE().PlaySound("]");
				JOOEOGDMNKN = 1403f;
			}
		}
	}

	private void MKECCPIDKJD(OEOIIKMBGAG EBILEBOJADB)
	{
		JOOEOGDMNKN += Time.deltaTime;
	}

	public void HBBEJGEBLII(Actor CDKMPAEODLA)
	{
		float att_range = get_m_actor().get_m_att_range();
		if (!((CDKMPAEODLA.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude > att_range * att_range))
		{
			FLOLFLJLNLN = CDKMPAEODLA;
		}
	}

	public void CreateWarningParticle()
	{
		if (LMKFJKJLMEJ == null)
		{
			Object obj = Resources.Load("Particle/Turret/warning");
			if (obj != null)
			{
				LMKFJKJLMEJ = (GameObject)Object.Instantiate(obj);
				LMKFJKJLMEJ.transform.localScale = new Vector3(get_m_actor().get_m_att_range(), 1f, get_m_actor().get_m_att_range());
				LMKFJKJLMEJ.transform.parent = get_m_transform();
				LMKFJKJLMEJ.transform.localPosition = new Vector3(0f, 0.02f, 0f);
				FxMakerParticleAttach component = LMKFJKJLMEJ.GetComponent<FxMakerParticleAttach>();
				component.m_targetRoot = base.gameObject;
			}
		}
		else if (!LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(true);
		}
	}

	public void OCLDMKHOEHF(Actor CDKMPAEODLA)
	{
		float att_range = get_m_actor().get_m_att_range();
		if (!((CDKMPAEODLA.GetPosition() - get_m_actor().GetPosition()).sqrMagnitude > att_range * att_range))
		{
			FLOLFLJLNLN = CDKMPAEODLA;
		}
	}

	public void DHEMLLJBKEJ()
	{
		if (LMKFJKJLMEJ == null)
		{
			Object obj = Resources.Load("Observer");
			if (obj != null)
			{
				LMKFJKJLMEJ = (GameObject)Object.Instantiate(obj);
				LMKFJKJLMEJ.transform.localScale = new Vector3(get_m_actor().get_m_att_range(), 1859f, get_m_actor().get_m_att_range());
				LMKFJKJLMEJ.transform.parent = get_m_transform();
				LMKFJKJLMEJ.transform.localPosition = new Vector3(45f, 25f, 1278f);
				FxMakerParticleAttach component = LMKFJKJLMEJ.GetComponent<FxMakerParticleAttach>();
				component.m_targetRoot = base.gameObject;
			}
		}
		else if (!LMKFJKJLMEJ.activeSelf)
		{
			LMKFJKJLMEJ.SetActive(false);
		}
	}
}
