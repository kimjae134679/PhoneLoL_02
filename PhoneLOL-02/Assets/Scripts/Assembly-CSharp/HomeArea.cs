using UnityEngine;

public class HomeArea : MonoBehaviour
{
	private const float CNKOEKGNNPJ = 1f;

	public int m_team;

	public UIButton m_shopButton;

	public UIGameShop m_shopPanel;

	private float INMCDOIEJOC;

	private bool BCEPECJDKKF(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 291f)
		{
			return false;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.FBNBKKOAPOJ())
			{
				CDKMPAEODLA.AddHpRemote(38);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1401f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.EMPANLICMPL(947f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 199.0, 1865.0, 1194.0, 6);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(-195);
			}
		}
		return true;
	}

	private bool NAAFHCOMHPB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Monster)
		{
			return false;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1032f)
		{
			return true;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(-172);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(175f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.KHLJMGEKOEJ(1106f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 536.0, 214.0, 1055.0, 0);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(194);
			}
		}
		return false;
	}

	private bool IGGOAILPIKB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)5)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1887f)
		{
			return false;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(152);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(730f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.IEHGFJKIDHI(190f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 1286.0, 1961.0, 1303.0, 0);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(46);
			}
		}
		return true;
	}

	private void BJKEPMGMJKA()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 920f)
		{
			INMCDOIEJOC -= 1966f;
			ActorManager.get_Instance().ProcessActorList(BCEPECJDKKF);
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor != null))
		{
			return;
		}
		bool flag = true;
		if ((controlActor.GetPosition() - base.transform.position).sqrMagnitude < 1769f)
		{
			flag = false;
		}
		if (m_shopButton != null && m_shopPanel != null && m_team == controlActor.m_team)
		{
			if (m_shopButton.gameObject.activeSelf != flag)
			{
				m_shopButton.gameObject.SetActive(flag);
			}
			if (!flag && m_shopPanel.gameObject.activeSelf != flag)
			{
				m_shopPanel.gameObject.SetActive(flag);
			}
		}
	}

	private void Start()
	{
	}

	private bool MCCEFGLFAGI(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)3)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return false;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 608f)
		{
			return true;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(-8);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(781f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.EMPANLICMPL(225f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 1805.0, 341.0, 1338.0, 8);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(138);
			}
		}
		return false;
	}

	private void GDKGBNKCGHO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 465f)
		{
			INMCDOIEJOC -= 1897f;
			ActorManager.get_Instance().AKFACHNPPMN(CEKCEBKDHMF);
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor != null))
		{
			return;
		}
		bool flag = false;
		if ((controlActor.GetPosition() - base.transform.position).sqrMagnitude < 1623f)
		{
			flag = false;
		}
		if (m_shopButton != null && m_shopPanel != null && m_team == controlActor.m_team)
		{
			if (m_shopButton.gameObject.activeSelf != flag)
			{
				m_shopButton.gameObject.SetActive(flag);
			}
			if (!flag && m_shopPanel.gameObject.activeSelf != flag)
			{
				m_shopPanel.gameObject.SetActive(flag);
			}
		}
	}

	private void OMIFPPGJHFH()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 1574f)
		{
			INMCDOIEJOC -= 73f;
			ActorManager.GBFDGAFALIL().ProcessActorList(IGGOAILPIKB);
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor != null))
		{
			return;
		}
		bool flag = true;
		if ((controlActor.GetPosition() - base.transform.position).sqrMagnitude < 1756f)
		{
			flag = true;
		}
		if (m_shopButton != null && m_shopPanel != null && m_team == controlActor.m_team)
		{
			if (m_shopButton.gameObject.activeSelf != flag)
			{
				m_shopButton.gameObject.SetActive(flag);
			}
			if (!flag && m_shopPanel.gameObject.activeSelf != flag)
			{
				m_shopPanel.gameObject.SetActive(flag);
			}
		}
	}

	private void OCDNPJOPPBB()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 1768f)
		{
			INMCDOIEJOC -= 306f;
			ActorManager.get_Instance().AKFACHNPPMN(BBMFDFEIPII);
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor != null))
		{
			return;
		}
		bool flag = false;
		if ((controlActor.GetPosition() - base.transform.position).sqrMagnitude < 95f)
		{
			flag = true;
		}
		if (m_shopButton != null && m_shopPanel != null && m_team == controlActor.m_team)
		{
			if (m_shopButton.gameObject.activeSelf != flag)
			{
				m_shopButton.gameObject.SetActive(flag);
			}
			if (!flag && m_shopPanel.gameObject.activeSelf != flag)
			{
				m_shopPanel.gameObject.SetActive(flag);
			}
		}
	}

	private bool HIEIDBBPAKL(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Unknown)
		{
			return false;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 986f)
		{
			return false;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(-18);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1896f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.JAHIGHKFIJN(1142f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 1.0, 396.0, 894.0);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(67);
			}
		}
		return false;
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 1f)
		{
			INMCDOIEJOC--;
			ActorManager.get_Instance().ProcessActorList(NAFGAMEENFB);
		}
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor != null))
		{
			return;
		}
		bool flag = false;
		if ((controlActor.GetPosition() - base.transform.position).sqrMagnitude < 9f)
		{
			flag = true;
		}
		if (m_shopButton != null && m_shopPanel != null && m_team == controlActor.m_team)
		{
			if (m_shopButton.gameObject.activeSelf != flag)
			{
				m_shopButton.gameObject.SetActive(flag);
			}
			if (!flag && m_shopPanel.gameObject.activeSelf != flag)
			{
				m_shopPanel.gameObject.SetActive(flag);
			}
		}
	}

	private void BPLOLCKEJJK()
	{
	}

	private bool BNIGJOBBNMC(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)3)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1326f)
		{
			return true;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(-148);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1744f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.KJODCEPCCPG(1910f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 1834.0, 1193.0, 913.0);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(13);
			}
		}
		return true;
	}

	private bool NAFGAMEENFB(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 9f)
		{
			return true;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(400);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(400f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.IEHGFJKIDHI())
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 0.0, 0.0, 100000.0, 3);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(-100000);
			}
		}
		return true;
	}

	private bool CEKCEBKDHMF(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Unknown)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1379f)
		{
			return true;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(121);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(476f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.JNLHIOHCIJB(144f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 360.0, 1664.0, 1285.0, 0);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(32);
			}
		}
		return false;
	}

	private bool ILJBINICJDE(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Unknown)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1291f)
		{
			return true;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.FBNBKKOAPOJ())
			{
				CDKMPAEODLA.AddHpRemote(83);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1163f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.IEHGFJKIDHI(1196f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 808.0, 1750.0, 132.0, 7);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(44);
			}
		}
		return true;
	}

	private bool DIACPGGEDOD(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Hero)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return false;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1452f)
		{
			return true;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.FBNBKKOAPOJ())
			{
				CDKMPAEODLA.AddHpRemote(-26);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1319f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.ECKCFOEPEAO(362f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 1908.0, 457.0, 800.0, 0);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(78);
			}
		}
		return true;
	}

	private bool CMLIMBIBLAD(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != (Actor.IJJMDPGJAEM)7)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 30f)
		{
			return false;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(-87);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1356f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.IEHGFJKIDHI(603f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 136.0, 1199.0, 75.0, 4);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(-18);
			}
		}
		return false;
	}

	private void JIMPGFGADPK()
	{
	}

	private bool BBMFDFEIPII(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.Monster)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return true;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1340f)
		{
			return false;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(142);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1268f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.IEHGFJKIDHI(976f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 320.0, 1043.0, 1533.0, 7);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(92);
			}
		}
		return true;
	}

	private void GDJCOAHJDLN()
	{
	}

	private bool IKENCHEOKGD(Actor CDKMPAEODLA)
	{
		if (CDKMPAEODLA.m_actorType != Actor.IJJMDPGJAEM.NotUsed)
		{
			return true;
		}
		if (!CDKMPAEODLA.IsLive())
		{
			return false;
		}
		if ((CDKMPAEODLA.GetPosition() - base.transform.position).sqrMagnitude >= 1490f)
		{
			return false;
		}
		if (CDKMPAEODLA.m_team == m_team)
		{
			if ((float)CDKMPAEODLA.m_hp < (float)CDKMPAEODLA.get_m_max_hp())
			{
				CDKMPAEODLA.AddHpRemote(183);
			}
			if (!CDKMPAEODLA.m_furyHero && (float)CDKMPAEODLA.m_mp < (float)CDKMPAEODLA.get_m_max_mp())
			{
				CDKMPAEODLA.AddMpRemote(1168f);
			}
		}
		else
		{
			Actor.NDCNGDGAAIN lastAttacker = CDKMPAEODLA.GetLastAttacker();
			if (lastAttacker != null && lastAttacker.DNHIMPHKODN(1f))
			{
				CDKMPAEODLA.OnDamage(lastAttacker.MEDAGKOPJMO, 1447.0, 1490.0, 1112.0, 4);
			}
			else
			{
				CDKMPAEODLA.AddHpRemote(-10);
			}
		}
		return false;
	}

	private void FJFFMANPDJD()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= 786f)
		{
			INMCDOIEJOC -= 157f;
			ActorManager.GBFDGAFALIL().AKFACHNPPMN(NAAFHCOMHPB);
		}
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (!(controlActor != null))
		{
			return;
		}
		bool flag = true;
		if ((controlActor.GetPosition() - base.transform.position).sqrMagnitude < 389f)
		{
			flag = true;
		}
		if (m_shopButton != null && m_shopPanel != null && m_team == controlActor.m_team)
		{
			if (m_shopButton.gameObject.activeSelf != flag)
			{
				m_shopButton.gameObject.SetActive(flag);
			}
			if (!flag && m_shopPanel.gameObject.activeSelf != flag)
			{
				m_shopPanel.gameObject.SetActive(flag);
			}
		}
	}
}
