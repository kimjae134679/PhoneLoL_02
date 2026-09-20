using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public class ALBEPPGKFMM
{
	private Actor MEDAGKOPJMO;

	private GameObject NKBBHDJMKBI;

	private float INMCDOIEJOC;

	private float DGOKCMMFOBH;

	private float CINKCJHCHAP;

	private ObscuredByte NILKHJJLMPL;

	public float CGPEFIHCMDD;

	private IDMGMJLOKBB NNNGEPOLJMG;

	private Actor NPOHGHPGFEO;

	public IDMGMJLOKBB KBNFANNCAIM
	{
		get
		{
			return ICPDLHPHKLJ();
		}
		protected set
		{
			NDFLBFGADMG(value);
		}
	}

	public Actor AFDDJMJAFKM
	{
		get
		{
			return FEFNGALOFDI();
		}
		protected set
		{
			PCICAHMILBF(value);
		}
	}

	protected void PCICAHMILBF(Actor ICENKPDOHBK)
	{
		NPOHGHPGFEO = ICENKPDOHBK;
	}

	public ALBEPPGKFMM(Actor CDKMPAEODLA)
	{
		INMCDOIEJOC = 0f;
		DGOKCMMFOBH = 0f;
		CGPEFIHCMDD = 0f;
		NILKHJJLMPL = (byte)0;
		MEDAGKOPJMO = CDKMPAEODLA;
		PCICAHMILBF(null);
		NDFLBFGADMG(null);
		CINKCJHCHAP = 0f;
	}

	public float BCHKKMGIPPC()
	{
		return INMCDOIEJOC;
	}

	private void EBIEBOPLOOG(int OMFKOHIBMEK)
	{
		if (FEFNGALOFDI() == null)
		{
			return;
		}
		float num = FEFNGALOFDI().get_m_mag_att() * 473f + (float)OMFKOHIBMEK * 895f;
		num += FEFNGALOFDI().get_m_phy_att_add() * (1603f + (float)OMFKOHIBMEK * 1664f);
		num += 916f + (float)OMFKOHIBMEK * 1605f;
		bool flag = MEDAGKOPJMO.m_actorType != (Actor.IJJMDPGJAEM)(-76) && false;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(MEDAGKOPJMO.get_m_transform().localPosition, (!flag) ? 1124f : 441f, FEFNGALOFDI().m_team, false, false, (Actor.IJJMDPGJAEM)126, true);
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			allActorInRange[i].OnDamage(FEFNGALOFDI(), 233.0, num, 159.0);
		}
		if (OMFKOHIBMEK == 5 && MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
		{
			TristanaSM tristanaSM = FEFNGALOFDI().NMJPCLBJIPO() as TristanaSM;
			if (tristanaSM != null)
			{
				tristanaSM.EBEKMJDKBEF();
			}
		}
		if (flag)
		{
			MEDAGKOPJMO.CreateParticle("bgm_lobby", false);
		}
		else
		{
			MEDAGKOPJMO.CreateParticle("Move_Turn_Joystick", false);
		}
		FEFNGALOFDI().m_multiSound.JKOODMAKJHJ("攻擊力", true, 286f, 1689f);
	}

	public bool DPILNPAPPKI(float DMLKFKGBHKJ)
	{
		INMCDOIEJOC += DMLKFKGBHKJ;
		DGOKCMMFOBH += DMLKFKGBHKJ;
		if (DGOKCMMFOBH >= ICPDLHPHKLJ().GBKDEBIFGDD())
		{
			DGOKCMMFOBH -= ICPDLHPHKLJ().GBKDEBIFGDD();
			EHBODNPBEPN();
		}
		if (INMCDOIEJOC > CINKCJHCHAP)
		{
			return false;
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 13)
		{
		}
		if (NKBBHDJMKBI != null)
		{
			if ((bool)MEDAGKOPJMO.get_m_cloaking())
			{
				if (NKBBHDJMKBI.gameObject.activeSelf)
				{
					NKBBHDJMKBI.gameObject.SetActive(false);
				}
			}
			else if (!NKBBHDJMKBI.gameObject.activeSelf)
			{
				NKBBHDJMKBI.gameObject.SetActive(true);
			}
		}
		return true;
	}

	private void CFBLCDJHKBJ()
	{
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 71 && (byte)NILKHJJLMPL == 3)
		{
			MEDAGKOPJMO.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveEx, FEFNGALOFDI());
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() != 74)
		{
			return;
		}
		if ((byte)NILKHJJLMPL > 5)
		{
			NILKHJJLMPL = (byte)5;
		}
		if (FEFNGALOFDI() != null)
		{
			if (FEFNGALOFDI().get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.DariusPassiveEx))
			{
				NILKHJJLMPL = (byte)5;
			}
			if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Hero && (byte)NILKHJJLMPL == 5)
			{
				FEFNGALOFDI().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.DariusPassiveEx);
			}
		}
	}

	public void AACACGCPHEC(KCIGFAHFHCH OGJFDNEEDCP)
	{
		ushort ICENKPDOHBK;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
		int ICENKPDOHBK2;
		OGJFDNEEDCP.GALCFOLBAAK(out ICENKPDOHBK2);
		NDFLBFGADMG(KIMJPIBNFGA.NOLHNOGGHNA().MDAEKOLGOOC().FPICNOOFDOA(ICENKPDOHBK));
		PCICAHMILBF(null);
		if (ICENKPDOHBK2 > 1)
		{
			EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NLALKBLCPFK(ICENKPDOHBK2);
			if (eveView != null)
			{
				PCICAHMILBF(eveView.GetComponent<Actor>());
			}
		}
		MGOENKOOFLO();
		OGJFDNEEDCP.CAHACMKBJMI(out INMCDOIEJOC);
		OGJFDNEEDCP.CAHACMKBJMI(out DGOKCMMFOBH);
		OGJFDNEEDCP.CAHACMKBJMI(out CINKCJHCHAP);
		OGJFDNEEDCP.CAHACMKBJMI(out CGPEFIHCMDD);
		OGJFDNEEDCP.CAHACMKBJMI(out NILKHJJLMPL);
	}

	public void AMHNAKJIAHG()
	{
		switch ((int)ICPDLHPHKLJ().PEBCAPNIMOL())
		{
		case -30:
			MEDAGKOPJMO.AddHpRemote(3);
			break;
		case -34:
		{
			byte level = MEDAGKOPJMO.get_Level();
			double oHEDEPKFAJE = 1878.0 + (double)(int)level * 83.0;
			MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 1371.0, 587.0, oHEDEPKFAJE);
			break;
		}
		case -88:
		{
			double num4 = (double)MEDAGKOPJMO.get_m_mag_att() * 1570.0;
			num4 += 1081.0 + (double)(MEDAGKOPJMO.GetSkillLevel(8) - 0) * 1804.0;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(MEDAGKOPJMO, 82f, true, false, (Actor.IJJMDPGJAEM)(-128), false);
			for (int i = 0; i < allActorInRange.Count; i += 0)
			{
				allActorInRange[i].OnDamage(MEDAGKOPJMO, 1676.0, num4, 1777.0, 6);
			}
			MEDAGKOPJMO.AddMpRemote(1307f);
			break;
		}
		case -105:
			if (FEFNGALOFDI() != null)
			{
				double num6 = (double)FEFNGALOFDI().get_m_phy_att_add() * 1062.0;
				num6 += 452.0 + (double)(FEFNGALOFDI().GetSkillLevel(1) - 0) * 135.0;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), num6, 984.0, 635.0, 8);
			}
			break;
		case -69:
			if (FEFNGALOFDI() != null)
			{
				float num8 = (float)MEDAGKOPJMO.m_hp * 808f;
				if (MEDAGKOPJMO.get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack) || MEDAGKOPJMO.get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)0))
				{
					num8 *= 918f;
				}
				if ((MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Monster || MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)5) && num8 > 628f)
				{
					num8 = 1521f;
				}
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 901.0, num8, 1407.0, 3);
			}
			break;
		case 51:
			if (FEFNGALOFDI() != null)
			{
				float num2 = FEFNGALOFDI().get_m_mag_att() * 329f;
				num2 += 1998f + (float)(FEFNGALOFDI().GetSkillLevel(6) - 0) * 1472f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 1132.0, num2, 230.0, 7);
			}
			break;
		case 52:
			if (FEFNGALOFDI() != null)
			{
				float num7 = FEFNGALOFDI().get_m_mag_att() * 1787f;
				num7 += 635f + (float)(FEFNGALOFDI().GetSkillLevel(6) - 0) * 384f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 1372.0, num7, 1972.0, 7);
			}
			break;
		case 53:
			if (FEFNGALOFDI() != null)
			{
				byte b2 = NILKHJJLMPL;
				if (b2 > 5)
				{
					b2 = 2;
				}
				float num9 = (float)MEDAGKOPJMO.FBNBKKOAPOJ() * 1463f * (float)(int)b2;
				if (MEDAGKOPJMO.m_actorType != (Actor.IJJMDPGJAEM)7 && num9 > 49f)
				{
					num9 = 180f;
				}
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 537.0, num9, 143.0, 6);
			}
			break;
		case 56:
			if (FEFNGALOFDI() != null)
			{
				byte b = NILKHJJLMPL;
				if (b > 0)
				{
					b = 1;
				}
				float num5 = FEFNGALOFDI().get_m_phy_att_add() * 1771f;
				num5 += 531f + (float)(int)MEDAGKOPJMO.get_Level() * 1513f;
				num5 *= (float)(int)b;
				num5 *= 190f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), num5, 75.0, 1989.0, 3);
			}
			break;
		case -104:
			if (FEFNGALOFDI() != null)
			{
				float num3 = FEFNGALOFDI().get_m_mag_att() * 1247f;
				num3 += 1208f + (float)(FEFNGALOFDI().GetSkillLevel(0) - 1) * 1829f;
				MEDAGKOPJMO.AddHpRemote((int)num3);
			}
			break;
		case -101:
			if (INMCDOIEJOC <= 652f && FEFNGALOFDI() != null)
			{
				float num = FEFNGALOFDI().get_m_mag_att() * 970f;
				num += 508f + (float)(FEFNGALOFDI().GetSkillLevel(1) - 0) * 759f;
				num /= 529f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 1590.0, num, 775.0, 6);
			}
			break;
		}
	}

	public void MHBDGLDDGKB(float ICENKPDOHBK, Actor PKDGAIKAMMM = null)
	{
		if (!(PKDGAIKAMMM != null) || !(FEFNGALOFDI() != PKDGAIKAMMM))
		{
			CGPEFIHCMDD += ICENKPDOHBK;
		}
	}

	private void CLAJCODAKBL(int OMFKOHIBMEK)
	{
		if (FEFNGALOFDI() == null)
		{
			return;
		}
		float num = FEFNGALOFDI().get_m_mag_att() * 1103f + (float)OMFKOHIBMEK * 1078f;
		num += FEFNGALOFDI().get_m_phy_att_add() * (1968f + (float)OMFKOHIBMEK * 133f);
		num += 1194f + (float)OMFKOHIBMEK * 41f;
		bool flag = MEDAGKOPJMO.m_actorType != (Actor.IJJMDPGJAEM)48 && false;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(MEDAGKOPJMO.get_m_transform().localPosition, (!flag) ? 219f : 282f, FEFNGALOFDI().m_team, false, true, (Actor.IJJMDPGJAEM)(-91));
		for (int i = 1; i < allActorInRange.Count; i++)
		{
			allActorInRange[i].OnDamage(FEFNGALOFDI(), 72.0, num, 1856.0, 3);
		}
		if (OMFKOHIBMEK == 2 && MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
		{
			TristanaSM tristanaSM = FEFNGALOFDI().NMJPCLBJIPO() as TristanaSM;
			if (tristanaSM != null)
			{
				tristanaSM.SetSkill2MaxStackExplosion();
			}
		}
		if (flag)
		{
			MEDAGKOPJMO.CreateParticle("attack3", false);
		}
		else
		{
			MEDAGKOPJMO.CreateParticle("blue", false);
		}
		FEFNGALOFDI().m_multiSound.HDOLPLIDACO("가입 최대인원이 초과되었습니다", false, 1559f, 779f);
	}

	public void DFMCIOHFKOF(KCIGFAHFHCH OGJFDNEEDCP)
	{
		ushort iCENKPDOHBK = ICPDLHPHKLJ().PEBCAPNIMOL();
		int iCENKPDOHBK2 = 0;
		if (FEFNGALOFDI() != null)
		{
			iCENKPDOHBK2 = FEFNGALOFDI().get_m_view().get_viewID();
		}
		OGJFDNEEDCP.GBMJNFOEACC(iCENKPDOHBK);
		OGJFDNEEDCP.GBMJNFOEACC(iCENKPDOHBK2);
		OGJFDNEEDCP.GBMJNFOEACC(INMCDOIEJOC);
		OGJFDNEEDCP.GBMJNFOEACC(DGOKCMMFOBH);
		OGJFDNEEDCP.GBMJNFOEACC(CINKCJHCHAP);
		OGJFDNEEDCP.GBMJNFOEACC(CGPEFIHCMDD);
		OGJFDNEEDCP.GBMJNFOEACC(NILKHJJLMPL);
	}

	public byte DGMHBHFHHBL()
	{
		return NILKHJJLMPL;
	}

	public Actor FEFNGALOFDI()
	{
		return NPOHGHPGFEO;
	}

	public void LMPKFILMJGA(float ICENKPDOHBK)
	{
		CGPEFIHCMDD = ICENKPDOHBK;
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 78 && CGPEFIHCMDD >= 4f)
		{
			INMCDOIEJOC = CINKCJHCHAP;
		}
	}

	private void MNMLIJDIBDD(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = MEDAGKOPJMO.gameObject;
		Vector3 position = MEDAGKOPJMO.GetPosition();
		HCKCCHPJOPI.transform.localPosition = position;
	}

	protected void NDFLBFGADMG(IDMGMJLOKBB ICENKPDOHBK)
	{
		NNNGEPOLJMG = ICENKPDOHBK;
	}

	private void GCPMCCBCOBO(int OMFKOHIBMEK)
	{
		if (FEFNGALOFDI() == null)
		{
			return;
		}
		float num = FEFNGALOFDI().get_m_mag_att() * 0.5f + (float)OMFKOHIBMEK * 0.15f;
		num += FEFNGALOFDI().get_m_phy_att_add() * (0.5f + (float)OMFKOHIBMEK * 0.2f);
		num += 70f + (float)OMFKOHIBMEK * 21f;
		bool flag = MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Turret;
		List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(MEDAGKOPJMO.get_m_transform().localPosition, (!flag) ? 2.5f : 5f, FEFNGALOFDI().m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			allActorInRange[i].OnDamage(FEFNGALOFDI(), 0.0, num, 0.0, 2);
		}
		if (OMFKOHIBMEK == 4 && MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			TristanaSM tristanaSM = FEFNGALOFDI().get_m_stateMachine() as TristanaSM;
			if (tristanaSM != null)
			{
				tristanaSM.SetSkill2MaxStackExplosion();
			}
		}
		if (flag)
		{
			MEDAGKOPJMO.CreateParticle("Particle/Tristana/skill2_ex2x", false);
		}
		else
		{
			MEDAGKOPJMO.CreateParticle("Particle/Tristana/skill2_ex", false);
		}
		FEFNGALOFDI().m_multiSound.LKLFMNKDLHJ("skill2_ex");
	}

	public float GACPEELMOHE()
	{
		return INMCDOIEJOC;
	}

	public void PMIMCLENGDE(float ICENKPDOHBK, Actor PKDGAIKAMMM = null)
	{
		if (!(PKDGAIKAMMM != null) || !(FEFNGALOFDI() != PKDGAIKAMMM))
		{
			CGPEFIHCMDD += ICENKPDOHBK;
		}
	}

	public byte NKPPMLLKHOL()
	{
		return NILKHJJLMPL;
	}

	public void EHBODNPBEPN()
	{
		switch ((JGOOOBHDBCG.ACPICCBBPHF)ICPDLHPHKLJ().PEBCAPNIMOL())
		{
		case JGOOOBHDBCG.ACPICCBBPHF.HpPotion:
			MEDAGKOPJMO.AddHpRemote(5);
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.RedDebuff:
		{
			byte level = MEDAGKOPJMO.get_Level();
			double oHEDEPKFAJE = 10.0 + (double)(int)level * 1.0;
			MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 0.0, 0.0, oHEDEPKFAJE, 2);
			break;
		}
		case JGOOOBHDBCG.ACPICCBBPHF.RenektonSkill3:
		{
			double num4 = (double)MEDAGKOPJMO.get_m_mag_att() * 0.1;
			num4 += 15.0 + (double)(MEDAGKOPJMO.GetSkillLevel(3) - 1) * 20.0;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(MEDAGKOPJMO, 3.2f, false, true, (Actor.IJJMDPGJAEM)14);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				allActorInRange[i].OnDamage(MEDAGKOPJMO, 0.0, num4, 0.0, 2);
			}
			MEDAGKOPJMO.AddMpRemote(3f);
			break;
		}
		case JGOOOBHDBCG.ACPICCBBPHF.TalonSkill0Blood:
			if (FEFNGALOFDI() != null)
			{
				double num6 = (double)FEFNGALOFDI().get_m_phy_att_add() * 0.167;
				num6 += 1.7 + (double)(FEFNGALOFDI().GetSkillLevel(0) - 1) * 1.7;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), num6, 0.0, 0.0, 2);
			}
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.LiandryTorment:
			if (FEFNGALOFDI() != null)
			{
				float num8 = (float)MEDAGKOPJMO.m_hp * 0.02f;
				if (MEDAGKOPJMO.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Slow) || MEDAGKOPJMO.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Stun))
				{
					num8 *= 2f;
				}
				if ((MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Minion || MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Monster) && num8 > 100f)
				{
					num8 = 100f;
				}
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 0.0, num8, 0.0, 2);
			}
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill2Poison:
			if (FEFNGALOFDI() != null)
			{
				float num2 = FEFNGALOFDI().get_m_mag_att() * 0.1f;
				num2 += 6f + (float)(FEFNGALOFDI().GetSkillLevel(2) - 1) * 6f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 0.0, num2, 0.0, 2);
			}
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill3Poison:
			if (FEFNGALOFDI() != null)
			{
				float num7 = FEFNGALOFDI().get_m_mag_att() * 0.125f;
				num7 += 50f + (float)(FEFNGALOFDI().GetSkillLevel(3) - 1) * 31.25f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 0.0, num7, 0.0, 2);
			}
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire:
			if (FEFNGALOFDI() != null)
			{
				byte b2 = NILKHJJLMPL;
				if (b2 > 3)
				{
					b2 = 3;
				}
				float num9 = (float)MEDAGKOPJMO.get_m_max_hp() * 0.005f * (float)(int)b2;
				if (MEDAGKOPJMO.m_actorType != Actor.IJJMDPGJAEM.Hero && num9 > 80f)
				{
					num9 = 80f;
				}
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 0.0, num9, 0.0, 2);
			}
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.DariusPassive:
			if (FEFNGALOFDI() != null)
			{
				byte b = NILKHJJLMPL;
				if (b > 5)
				{
					b = 5;
				}
				float num5 = FEFNGALOFDI().get_m_phy_att_add() * 0.3f;
				num5 += 10f + (float)(int)MEDAGKOPJMO.get_Level() * 1f;
				num5 *= (float)(int)b;
				num5 *= 0.16f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), num5, 0.0, 0.0, 2);
			}
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.SorakaProtectionOfStar:
			if (FEFNGALOFDI() != null)
			{
				float num3 = FEFNGALOFDI().get_m_mag_att() * 0.1f;
				num3 += 12f + (float)(FEFNGALOFDI().GetSkillLevel(0) - 1) * 4f;
				MEDAGKOPJMO.AddHpRemote((int)num3);
			}
			break;
		case JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive:
			if (INMCDOIEJOC <= 3.4f && FEFNGALOFDI() != null)
			{
				float num = FEFNGALOFDI().get_m_mag_att() * 0.4f;
				num += 20f + (float)(FEFNGALOFDI().GetSkillLevel(1) - 1) * 10f;
				num /= 6f;
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 0.0, num, 0.0, 2);
			}
			break;
		}
	}

	[SpecialName]
	protected void OKNCBIPGAFA(IDMGMJLOKBB ICENKPDOHBK)
	{
		NNNGEPOLJMG = ICENKPDOHBK;
	}

	public void AJICCOCMBKE()
	{
		INMCDOIEJOC = 0f;
	}

	private void POGHIMAPKDB(int OMFKOHIBMEK)
	{
		if (FEFNGALOFDI() == null)
		{
			return;
		}
		float num = FEFNGALOFDI().get_m_mag_att() * 319f + (float)OMFKOHIBMEK * 1084f;
		num += FEFNGALOFDI().get_m_phy_att_add() * (1744f + (float)OMFKOHIBMEK * 978f);
		num += 754f + (float)OMFKOHIBMEK * 821f;
		bool flag = MEDAGKOPJMO.m_actorType != (Actor.IJJMDPGJAEM)73 || true;
		List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(MEDAGKOPJMO.get_m_transform().localPosition, (!flag) ? 990f : 473f, FEFNGALOFDI().m_team, false, true, (Actor.IJJMDPGJAEM)(-50));
		for (int i = 0; i < allActorInRange.Count; i++)
		{
			allActorInRange[i].OnDamage(FEFNGALOFDI(), 1951.0, num, 1940.0, 0);
		}
		if (OMFKOHIBMEK == 3 && MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)7)
		{
			TristanaSM tristanaSM = FEFNGALOFDI().NMJPCLBJIPO() as TristanaSM;
			if (tristanaSM != null)
			{
				tristanaSM.SetSkill2MaxStackExplosion();
			}
		}
		if (flag)
		{
			MEDAGKOPJMO.CreateParticle("User Cohorts:", true);
		}
		else
		{
			MEDAGKOPJMO.CreateParticle("Tornado", true);
		}
		FEFNGALOFDI().m_multiSound.LNCPFILABHM("닉네임은 최소 2자 이상입니다.", false, 162f, 783f);
	}

	public void NOBKMHENFHO(float HBNDHMPNCME)
	{
		CINKCJHCHAP = HBNDHMPNCME;
	}

	public ALBEPPGKFMM(Actor CDKMPAEODLA, IDMGMJLOKBB DAHPLNJAPGO, Actor PGGLHMPOBBP)
	{
		INMCDOIEJOC = 0f;
		DGOKCMMFOBH = 0f;
		CGPEFIHCMDD = 0f;
		NILKHJJLMPL = (byte)0;
		MEDAGKOPJMO = CDKMPAEODLA;
		PCICAHMILBF(PGGLHMPOBBP);
		NDFLBFGADMG(DAHPLNJAPGO);
		CINKCJHCHAP = ICPDLHPHKLJ().EKJHPEJHAKO();
	}

	[SpecialName]
	public IDMGMJLOKBB JPEIDLJEAHC()
	{
		return NNNGEPOLJMG;
	}

	public void MGOENKOOFLO()
	{
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 1)
		{
			MEDAGKOPJMO.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Stun);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 8)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("buff_shield");
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("buff_shield_loop", true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 9)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("buff_shield");
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("buff_shield_loop", true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 15)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill3");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 16)
		{
			MEDAGKOPJMO.SetCloaking(true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 24)
		{
			MEDAGKOPJMO.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Temptation);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 30)
		{
			CGPEFIHCMDD = (float)MEDAGKOPJMO.m_mp * 0.5f;
			Actor mEDAGKOPJMO = MEDAGKOPJMO;
			mEDAGKOPJMO.m_shield = (float)mEDAGKOPJMO.m_shield + CGPEFIHCMDD;
			MEDAGKOPJMO.CreateParticle(string.Format("Particle/{0}/shield", MEDAGKOPJMO.get_m_resourceName()), false);
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("shield");
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("shield2");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 31)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill1_loop", true, 0.5f);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 34)
		{
			CGPEFIHCMDD = MEDAGKOPJMO.get_m_phy_att_add();
			CGPEFIHCMDD += 90f + (float)(MEDAGKOPJMO.GetSkillLevel(2) - 1) * 33f;
			Actor mEDAGKOPJMO2 = MEDAGKOPJMO;
			mEDAGKOPJMO2.m_shield = (float)mEDAGKOPJMO2.m_shield + CGPEFIHCMDD;
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill2_shield", true, 0.5f);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 37)
		{
			MasterYiSM masterYiSM = MEDAGKOPJMO.get_m_stateMachine() as MasterYiSM;
			if (masterYiSM != null)
			{
				masterYiSM.ShowSkill2Particles(true);
			}
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 38)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill3_loop", true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 40)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill3_loop", true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 43)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill1_loop", true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 46)
		{
			switch (MEDAGKOPJMO.GetSkillLevel(3))
			{
			case 1:
				CGPEFIHCMDD = 300f;
				break;
			case 2:
				CGPEFIHCMDD = 550f;
				break;
			case 3:
				CGPEFIHCMDD = 800f;
				break;
			}
			Actor mEDAGKOPJMO3 = MEDAGKOPJMO;
			mEDAGKOPJMO3.m_shield = (float)mEDAGKOPJMO3.m_shield + CGPEFIHCMDD;
			MEDAGKOPJMO.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 48)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill2_shield", true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 49)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill3_loop", true);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 53)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill0_loop", true, 0.8f);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 56)
		{
			MEDAGKOPJMO.SetCloaking(true);
		}
		if (ICPDLHPHKLJ().GKGMIOOHOLE().Length > 0)
		{
			string empty = string.Empty;
			empty = ((MEDAGKOPJMO.m_heroCostumeID != 0) ? string.Format("Particle/Buff/{0}_c{1}", ICPDLHPHKLJ().GKGMIOOHOLE(), MEDAGKOPJMO.m_heroCostumeID) : string.Format("Particle/Buff/{0}", ICPDLHPHKLJ().GKGMIOOHOLE()));
			Object obj = Resources.Load(empty);
			if (obj == null)
			{
				empty = string.Format("Particle/Buff/{0}", ICPDLHPHKLJ().GKGMIOOHOLE());
				obj = Resources.Load(empty);
			}
			if (obj != null)
			{
				NKBBHDJMKBI = GameObjectPool.Alloc(obj, (GameObject HCKCCHPJOPI) =>
				{
					HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = MEDAGKOPJMO.gameObject;
					Vector3 position = MEDAGKOPJMO.GetPosition();
					HCKCCHPJOPI.transform.localPosition = position;
				});
				NcAutoDestruct component = NKBBHDJMKBI.GetComponent<NcAutoDestruct>();
				if (component != null && component.m_useGameObjectPool)
				{
					NsEffectManager.RunReplayEffect(NKBBHDJMKBI, true);
				}
			}
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 59)
		{
			Actor mEDAGKOPJMO4 = MEDAGKOPJMO;
			mEDAGKOPJMO4.m_shield = (float)mEDAGKOPJMO4.m_shield + CGPEFIHCMDD;
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("passive");
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("passive2");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 61)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill0_passive");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 62)
		{
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 63)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill3_buff");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 68)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill1");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 76)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill1_loop", true, 0.3f);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 75)
		{
			MEDAGKOPJMO.CreateParticle("Particle/Darius/skill3_ground", false);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 77)
		{
			TristanaSM tristanaSM = MEDAGKOPJMO.get_m_stateMachine() as TristanaSM;
			if (tristanaSM != null)
			{
				tristanaSM.SetSkill0Particle(true);
			}
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 78)
		{
			FEFNGALOFDI().m_multiSound.LKLFMNKDLHJ("skill2_timer");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 79)
		{
			FEFNGALOFDI().m_multiSound.LKLFMNKDLHJ("protectionofstar");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 80)
		{
			OlafSM olafSM = MEDAGKOPJMO.get_m_stateMachine() as OlafSM;
			if (olafSM != null)
			{
				olafSM.ShowSkill1Particle(true);
			}
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill1_loop", true, 0.3f);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 81)
		{
			if (MEDAGKOPJMO.get_EffectChanger() != null)
			{
				MEDAGKOPJMO.get_EffectChanger().SetColorWithoutAlpha(new Color(1f, 0.4f, 0.4f));
			}
			OlafSM olafSM2 = MEDAGKOPJMO.get_m_stateMachine() as OlafSM;
			if (olafSM2 != null)
			{
				olafSM2.ShowSkill3Particle(true);
			}
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill3_loop", true, 0.3f);
		}
	}

	public void CAOABAIGMKM(float HBNDHMPNCME)
	{
		CINKCJHCHAP = HBNDHMPNCME;
	}

	[SpecialName]
	protected void IJMAGBIBBND(IDMGMJLOKBB ICENKPDOHBK)
	{
		NNNGEPOLJMG = ICENKPDOHBK;
	}

	private void NCMLMCGJPDL()
	{
		if (JPEIDLJEAHC().PEBCAPNIMOL() == -67 && (byte)NILKHJJLMPL == 6)
		{
			MEDAGKOPJMO.get_m_buffsInfo().ECBAJEFFIBA((JGOOOBHDBCG.ACPICCBBPHF)65493, FEFNGALOFDI(), 821f, 1203f);
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() != 39)
		{
			return;
		}
		if ((byte)NILKHJJLMPL > 3)
		{
			NILKHJJLMPL = (byte)0;
		}
		if (FEFNGALOFDI() != null)
		{
			if (FEFNGALOFDI().get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)65431))
			{
				NILKHJJLMPL = (byte)0;
			}
			if (MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)3 && (byte)NILKHJJLMPL == 3)
			{
				FEFNGALOFDI().get_m_buffsInfo().ECBAJEFFIBA(JGOOOBHDBCG.ACPICCBBPHF.BrandPassiveFire, null, 510f, 838f, false);
			}
		}
	}

	public void HIGCLCKDNIB()
	{
		try
		{
			if (NKBBHDJMKBI != null)
			{
				NcAutoDestruct component = NKBBHDJMKBI.GetComponent<NcAutoDestruct>();
				if (component != null)
				{
					if (component.m_useGameObjectPool)
					{
						GameObjectPool.Free(NKBBHDJMKBI);
					}
					else
					{
						Object.DestroyObject(NKBBHDJMKBI);
					}
				}
				else
				{
					Object.DestroyObject(NKBBHDJMKBI);
				}
				NKBBHDJMKBI = null;
			}
		}
		catch
		{
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 1)
		{
			if (MEDAGKOPJMO.get_m_stateMachine().get_m_state() == StateMachine.OEOIIKMBGAG.Stun)
			{
				MEDAGKOPJMO.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Idle);
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 13)
		{
			if (MEDAGKOPJMO.get_m_stateMachine().get_m_state() == StateMachine.OEOIIKMBGAG.Stun)
			{
				MEDAGKOPJMO.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Idle);
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 8)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("buff_shield_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 9)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("buff_shield_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 16)
		{
			MEDAGKOPJMO.SetCloaking(false);
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 23)
		{
			if (FEFNGALOFDI() != null)
			{
				double num = FEFNGALOFDI().get_m_phy_att();
				switch ((int)FEFNGALOFDI().GetSkillLevel(3))
				{
				case 1:
					num += (double)CGPEFIHCMDD * 0.3;
					break;
				case 2:
					num += (double)CGPEFIHCMDD * 0.4;
					break;
				case 3:
					num += (double)CGPEFIHCMDD * 0.5;
					break;
				}
				MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), num, 0.0, 0.0, 2);
				FEFNGALOFDI().m_multiSound.LKLFMNKDLHJ("skill3_explosion");
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 24)
		{
			if (MEDAGKOPJMO.get_m_stateMachine().get_m_state() == StateMachine.OEOIIKMBGAG.Temptation)
			{
				MEDAGKOPJMO.get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Idle);
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 25)
		{
			MEDAGKOPJMO.GetHumanSM().GetCastSkill(3).IHKCKBJBEGF = 0f;
			MEDAGKOPJMO.GetHumanSM().GetCastSkill(3).BELPBCDOPBA = 100;
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 30)
		{
			Actor mEDAGKOPJMO = MEDAGKOPJMO;
			mEDAGKOPJMO.m_shield = (float)mEDAGKOPJMO.m_shield - CGPEFIHCMDD;
			if ((float)MEDAGKOPJMO.m_shield < 0f)
			{
				MEDAGKOPJMO.m_shield = 0f;
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 31)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill1_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 33)
		{
			RivenSM rivenSM = (RivenSM)MEDAGKOPJMO.get_m_stateMachine();
			rivenSM.OnDisableSkill0();
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 34)
		{
			Actor mEDAGKOPJMO2 = MEDAGKOPJMO;
			mEDAGKOPJMO2.m_shield = (float)mEDAGKOPJMO2.m_shield - CGPEFIHCMDD;
			if ((float)MEDAGKOPJMO.m_shield < 0f)
			{
				MEDAGKOPJMO.m_shield = 0f;
			}
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill2_shield");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 35)
		{
			RivenSM rivenSM2 = (RivenSM)MEDAGKOPJMO.get_m_stateMachine();
			rivenSM2.OnDisableSkill3_0();
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 37)
		{
			MasterYiSM masterYiSM = MEDAGKOPJMO.get_m_stateMachine() as MasterYiSM;
			if (masterYiSM != null)
			{
				masterYiSM.ShowSkill2Particles(false);
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 38)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill3_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 40)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill3_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 43)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill1_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 45)
		{
			MEDAGKOPJMO.GetHumanSM().GetCastSkill(2).IHKCKBJBEGF = 0f;
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 46)
		{
			Actor mEDAGKOPJMO3 = MEDAGKOPJMO;
			mEDAGKOPJMO3.m_shield = (float)mEDAGKOPJMO3.m_shield - CGPEFIHCMDD;
			if ((float)MEDAGKOPJMO.m_shield < 0f)
			{
				MEDAGKOPJMO.m_shield = 0f;
			}
			MEDAGKOPJMO.transform.localScale = new Vector3(1f, 1f, 1f);
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 48)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill2_shield");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 49)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill3_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 53)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill0_loop");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 56)
		{
			MEDAGKOPJMO.SetCloaking(false);
			TalonSM talonSM = MEDAGKOPJMO.get_m_stateMachine() as TalonSM;
			if (talonSM != null)
			{
				talonSM.EndSkill3Buff();
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 59)
		{
			Actor mEDAGKOPJMO4 = MEDAGKOPJMO;
			mEDAGKOPJMO4.m_shield = (float)mEDAGKOPJMO4.m_shield - CGPEFIHCMDD;
			if ((float)MEDAGKOPJMO.m_shield < 0f)
			{
				MEDAGKOPJMO.m_shield = 0f;
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 62)
		{
			double num2 = (double)MEDAGKOPJMO.get_m_mag_att() * 0.7;
			num2 += (double)((float)MEDAGKOPJMO.get_m_max_hp() * 0.08f);
			num2 += 60.0 + (double)(MEDAGKOPJMO.GetSkillLevel(2) - 1) * 30.0;
			float num3 = INMCDOIEJOC;
			if (num3 > 1f)
			{
				num3 = 1f;
			}
			num2 *= (double)(0.5f + num3 * 0.5f);
			float iCENKPDOHBK = 0.4f + (float)(MEDAGKOPJMO.GetSkillLevel(2) - 1) * 0.05f;
			List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(MEDAGKOPJMO, 4.5f, false, true, (Actor.IJJMDPGJAEM)14);
			for (int i = 0; i < allActorInRange.Count; i++)
			{
				allActorInRange[i].OnDamage(MEDAGKOPJMO, 0.0, num2, 0.0, 2);
				if (INMCDOIEJOC >= 0.99f && allActorInRange[i].m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					allActorInRange[i].get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Slow, MEDAGKOPJMO, 0.5f, iCENKPDOHBK);
				}
			}
			MEDAGKOPJMO.GetHumanSM().GetCastSkill(2).IHKCKBJBEGF = 0f;
			MEDAGKOPJMO.CreateParticle("Particle/Vladimir/skill2_ex", false);
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill2_ex");
			if (allActorInRange.Count > 0)
			{
				MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill2_hit");
			}
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 63)
		{
			if (FEFNGALOFDI() != null)
			{
				double num4 = (double)FEFNGALOFDI().get_m_mag_att() * 0.7;
				num4 += 150.0 + (double)(FEFNGALOFDI().GetSkillLevel(3) - 1) * 100.0;
				if (MEDAGKOPJMO.OnDamage(FEFNGALOFDI(), 0.0, num4) >= 0f)
				{
					FEFNGALOFDI().AddHpRemote((int)(num4 * 0.8));
				}
			}
			MEDAGKOPJMO.CreateParticle("Particle/Vladimir/skill3_ex", false);
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill3_hit");
		}
		else if (ICPDLHPHKLJ().PEBCAPNIMOL() == 68)
		{
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("skill1_end");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 72)
		{
			MEDAGKOPJMO.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.BrandDontPassive);
			if (MEDAGKOPJMO.IsLive() && FEFNGALOFDI() != null)
			{
				List<Actor> allActorInRange2 = ActorManager.get_Instance().GetAllActorInRange(MEDAGKOPJMO.GetPosition(), 3f, FEFNGALOFDI().m_team, false, true, (Actor.IJJMDPGJAEM)14, true);
				for (int j = 0; j < allActorInRange2.Count; j++)
				{
					float num5 = 0.12f + (float)(FEFNGALOFDI().get_Level() - 1) * 0.00236f;
					num5 += FEFNGALOFDI().get_m_mag_att() * 0.00015f;
					float num6 = (float)allActorInRange2[j].get_m_max_hp() * num5;
					allActorInRange2[j].OnDamage(FEFNGALOFDI(), 0.0, num6, 0.0, 2);
				}
				MEDAGKOPJMO.CreateParticle("Particle/Brand/passive_ex", false);
				FEFNGALOFDI().m_multiSound.LKLFMNKDLHJ("passive_ex");
			}
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 76)
		{
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill1_loop");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 77)
		{
			TristanaSM tristanaSM = MEDAGKOPJMO.get_m_stateMachine() as TristanaSM;
			if (tristanaSM != null)
			{
				tristanaSM.SetSkill0Particle(false);
			}
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 78)
		{
			int value = (int)CGPEFIHCMDD;
			GCPMCCBCOBO(Mathf.Clamp(value, 0, 4));
			if (FEFNGALOFDI() != null)
			{
				FEFNGALOFDI().m_multiSound.FLAIMHHIDLC("skill2_timer");
			}
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 80)
		{
			OlafSM olafSM = MEDAGKOPJMO.get_m_stateMachine() as OlafSM;
			if (olafSM != null)
			{
				olafSM.ShowSkill1Particle(false);
			}
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill1_loop");
		}
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == 81)
		{
			if (MEDAGKOPJMO.get_EffectChanger() != null)
			{
				MEDAGKOPJMO.get_EffectChanger().SetColorWithoutAlpha(Color.white);
			}
			OlafSM olafSM2 = MEDAGKOPJMO.get_m_stateMachine() as OlafSM;
			if (olafSM2 != null)
			{
				olafSM2.ShowSkill3Particle(false);
			}
			MEDAGKOPJMO.m_multiSound.FLAIMHHIDLC("skill3_loop");
		}
	}

	[CompilerGenerated]
	private void FGCGEPMEIBJ(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = MEDAGKOPJMO.gameObject;
		Vector3 position = MEDAGKOPJMO.GetPosition();
		HCKCCHPJOPI.transform.localPosition = position;
	}

	public void GGKECAMBCOB(float ICENKPDOHBK)
	{
		CGPEFIHCMDD = ICENKPDOHBK;
		if (ICPDLHPHKLJ().PEBCAPNIMOL() == -3 && CGPEFIHCMDD >= 1743f)
		{
			INMCDOIEJOC = CINKCJHCHAP;
		}
	}

	public float FDJMANPHEII()
	{
		float num = CINKCJHCHAP - INMCDOIEJOC;
		if (num < 0f)
		{
			num = 0f;
		}
		return num;
	}

	public float FBKFEHOLBGD()
	{
		if (CINKCJHCHAP == 0f)
		{
			return 0f;
		}
		if (INMCDOIEJOC >= CINKCJHCHAP)
		{
			return 0f;
		}
		return (CINKCJHCHAP - INMCDOIEJOC) / CINKCJHCHAP;
	}

	public void HNLKMKOIIOG()
	{
		if ((byte)NILKHJJLMPL < 100)
		{
			++NILKHJJLMPL;
		}
		CFBLCDJHKBJ();
	}

	public void GJPFIPICBAM(KCIGFAHFHCH OGJFDNEEDCP)
	{
		ushort ICENKPDOHBK;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
		int ICENKPDOHBK2;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
		NDFLBFGADMG(KIMJPIBNFGA.JJBDAOJIDAL().MDAEKOLGOOC().FPICNOOFDOA(ICENKPDOHBK));
		PCICAHMILBF(null);
		if (ICENKPDOHBK2 > 0)
		{
			EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK2);
			if (eveView != null)
			{
				PCICAHMILBF(eveView.GetComponent<Actor>());
			}
		}
		MGOENKOOFLO();
		OGJFDNEEDCP.CAHACMKBJMI(out INMCDOIEJOC);
		OGJFDNEEDCP.CAHACMKBJMI(out DGOKCMMFOBH);
		OGJFDNEEDCP.CAHACMKBJMI(out CINKCJHCHAP);
		OGJFDNEEDCP.CAHACMKBJMI(out CGPEFIHCMDD);
		OGJFDNEEDCP.CAHACMKBJMI(out NILKHJJLMPL);
	}

	public bool BGJMKMJAGML(float DMLKFKGBHKJ)
	{
		INMCDOIEJOC += DMLKFKGBHKJ;
		DGOKCMMFOBH += DMLKFKGBHKJ;
		if (DGOKCMMFOBH >= ICPDLHPHKLJ().BONICEDFMGK())
		{
			DGOKCMMFOBH -= JPEIDLJEAHC().BONICEDFMGK();
			AMHNAKJIAHG();
		}
		if (INMCDOIEJOC > CINKCJHCHAP)
		{
			return false;
		}
		if (JPEIDLJEAHC().PEBCAPNIMOL() == -126)
		{
		}
		if (NKBBHDJMKBI != null)
		{
			if ((bool)MEDAGKOPJMO.get_m_cloaking())
			{
				if (NKBBHDJMKBI.gameObject.activeSelf)
				{
					NKBBHDJMKBI.gameObject.SetActive(true);
				}
			}
			else if (!NKBBHDJMKBI.gameObject.activeSelf)
			{
				NKBBHDJMKBI.gameObject.SetActive(false);
			}
		}
		return false;
	}

	private void NKMHDFKOKOM(GameObject HCKCCHPJOPI)
	{
		HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>().m_targetRoot = MEDAGKOPJMO.gameObject;
		Vector3 position = MEDAGKOPJMO.GetPosition();
		HCKCCHPJOPI.transform.localPosition = position;
	}

	public void FKCBMDHKKAF(float ICENKPDOHBK, Actor PKDGAIKAMMM = null)
	{
		if (!(PKDGAIKAMMM != null) || !(FEFNGALOFDI() != PKDGAIKAMMM))
		{
			CGPEFIHCMDD += ICENKPDOHBK;
		}
	}

	public void LIEFFFNFCNM(KCIGFAHFHCH OGJFDNEEDCP)
	{
		ushort ICENKPDOHBK;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
		int ICENKPDOHBK2;
		OGJFDNEEDCP.GALCFOLBAAK(out ICENKPDOHBK2);
		NDFLBFGADMG(KIMJPIBNFGA.JJBDAOJIDAL().MDAEKOLGOOC().DDIBAIMBOGJ(ICENKPDOHBK));
		PCICAHMILBF(null);
		if (ICENKPDOHBK2 > 0)
		{
			EveView eveView = EveUnityNetwork.get_Instance().PBLOPNNPNEJ().NODACNJHDFD(ICENKPDOHBK2);
			if (eveView != null)
			{
				PCICAHMILBF(eveView.GetComponent<Actor>());
			}
		}
		MGOENKOOFLO();
		OGJFDNEEDCP.CAHACMKBJMI(out INMCDOIEJOC);
		OGJFDNEEDCP.CAHACMKBJMI(out DGOKCMMFOBH);
		OGJFDNEEDCP.CAHACMKBJMI(out CINKCJHCHAP);
		OGJFDNEEDCP.CAHACMKBJMI(out CGPEFIHCMDD);
		OGJFDNEEDCP.CAHACMKBJMI(out NILKHJJLMPL);
	}

	public IDMGMJLOKBB ICPDLHPHKLJ()
	{
		return NNNGEPOLJMG;
	}

	public void AGHIKEMBFNG(KCIGFAHFHCH OGJFDNEEDCP)
	{
		ushort iCENKPDOHBK = JPEIDLJEAHC().PEBCAPNIMOL();
		int iCENKPDOHBK2 = 0;
		if (FEFNGALOFDI() != null)
		{
			iCENKPDOHBK2 = FEFNGALOFDI().get_m_view().get_viewID();
		}
		OGJFDNEEDCP.HEDNLNDFFCL(iCENKPDOHBK);
		OGJFDNEEDCP.GBMJNFOEACC(iCENKPDOHBK2);
		OGJFDNEEDCP.PFAIBIMGAIB(INMCDOIEJOC);
		OGJFDNEEDCP.GBMJNFOEACC(DGOKCMMFOBH);
		OGJFDNEEDCP.GBMJNFOEACC(CINKCJHCHAP);
		OGJFDNEEDCP.PFAIBIMGAIB(CGPEFIHCMDD);
		OGJFDNEEDCP.GBMJNFOEACC(NILKHJJLMPL);
	}
}
