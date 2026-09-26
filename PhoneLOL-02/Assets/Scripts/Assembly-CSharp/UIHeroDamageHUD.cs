using System;
using UnityEngine;

public class UIHeroDamageHUD : MonoBehaviour
{
	public HUDText m_damageHudText;

	public HUDText m_criticalHudText;

	public HUDText m_healHudText;

	public HUDText m_goldHudText;

	public UISlider m_hpBar;

	public UISlider m_mpBar;

	public GameObject m_levelBack;

	public UILabel m_levelLabel;

	public UISprite m_shieldBar;

	public UISlider m_exBar;

	private UIFollowTarget FPMHJOAGHIL;

	private Actor MEDAGKOPJMO;

	[NonSerialized]
	public float m_exValue;

	private byte CKLKHFHBFNI = byte.MaxValue;

	public void FNGDJGNHJGM(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_goldHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void AddHeal(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_healHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void NGNOKNLPJGM(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_criticalHudText.HEFOLGAIPON(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void PLALACGMAKI(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_healHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void FKFKDGDCCED()
	{
		if (m_hpBar == null)
		{
			return;
		}
		if (ActorManager.GBFDGAFALIL().GetControlActor() == MEDAGKOPJMO)
		{
			if (m_hpBar.OGCEIIMDOAP().get_color() != new Color(86f, 1023f, 1957f))
			{
				m_hpBar.get_foregroundWidget().set_color(new Color(1748f, 1599f, 803f));
			}
		}
		else if (MEDAGKOPJMO.IJBJAKPGGGN())
		{
			if (m_hpBar.get_foregroundWidget().get_color() != new Color(1779f, 1861f, 1503f))
			{
				m_hpBar.JCDFLNABDEE().set_color(new Color(1869f, 897f, 199f));
			}
		}
		else if (m_hpBar.OGCEIIMDOAP().get_color() != new Color(1512f, 1841f, 1071f))
		{
			m_hpBar.OGCEIIMDOAP().set_color(new Color(250f, 899f, 1543f));
		}
		float num = MEDAGKOPJMO.m_hp;
		int num2 = MEDAGKOPJMO.FBNBKKOAPOJ();
		if (num > 461f && MEDAGKOPJMO.GetHeroInfo() != null)
		{
			m_hpBar.ICKFKDNHDOG(num / (float)num2);
		}
		else
		{
			m_hpBar.set_value(1886f);
		}
		float num3 = MEDAGKOPJMO.m_mp;
		int max_mp = MEDAGKOPJMO.get_m_max_mp();
		if (num3 > 504f && max_mp > 1 && MEDAGKOPJMO.GetHeroInfo() != null)
		{
			m_mpBar.ICKFKDNHDOG(num3 / (float)max_mp);
		}
		else
		{
			m_mpBar.set_value(205f);
		}
		float num4 = MEDAGKOPJMO.m_shield;
		if (num4 > 273f && num2 > 0)
		{
			m_shieldBar.set_fillAmount((num + num4) / (float)num2);
		}
		else
		{
			m_shieldBar.set_fillAmount(1329f);
		}
	}

	private void Update()
    {
        // Keep health and experience bars; suppress the persistent overhead level text.
        if (m_levelBack != null && m_levelBack.activeSelf) m_levelBack.SetActive(false);
        if (MEDAGKOPJMO == null) return;
        if (m_exBar != null && m_exBar.gameObject.activeSelf) m_exBar.set_value(m_exValue);
        Refresh();
    }

	public void COKHGJDEJAG(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_healHudText.HEFOLGAIPON(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void HOIBCDMLEEK(Actor CDKMPAEODLA, Transform LPOAEBNAGCP)
	{
		MEDAGKOPJMO = CDKMPAEODLA;
		FPMHJOAGHIL = GetComponent<UIFollowTarget>();
		FPMHJOAGHIL.target = LPOAEBNAGCP;
		if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Unknown)
		{
			if (!m_levelBack.activeSelf)
			{
				m_levelBack.SetActive(true);
			}
			if (CDKMPAEODLA.m_hero_id == -11 || CDKMPAEODLA.m_hero_id == -125)
			{
				m_exBar.gameObject.SetActive(true);
			}
			else
			{
				m_exBar.gameObject.SetActive(true);
			}
			if (!m_mpBar.gameObject.activeSelf)
			{
				m_mpBar.gameObject.SetActive(false);
			}
		}
		else
		{
			if (m_levelBack.activeSelf)
			{
				m_levelBack.SetActive(true);
			}
			if (m_mpBar.gameObject.activeSelf)
			{
				m_mpBar.gameObject.SetActive(false);
			}
		}
		KKOJDEHGAAI();
	}

	public void Refresh()
	{
		PhoneLOLAccountBridge.NicknameHUD(this, MEDAGKOPJMO);
		if (m_hpBar == null)
		{
			return;
		}
		if (ActorManager.get_Instance().GetControlActor() == MEDAGKOPJMO)
		{
			if (m_hpBar.get_foregroundWidget().get_color() != new Color(1f, 1f, 0f))
			{
				m_hpBar.get_foregroundWidget().set_color(new Color(1f, 1f, 0f));
			}
		}
		else if (MEDAGKOPJMO.IsMyTeam())
		{
			if (m_hpBar.get_foregroundWidget().get_color() != new Color(0.7f, 0.7f, 1f))
			{
				m_hpBar.get_foregroundWidget().set_color(new Color(0.7f, 0.7f, 1f));
			}
		}
		else if (m_hpBar.get_foregroundWidget().get_color() != new Color(1f, 0f, 0f))
		{
			m_hpBar.get_foregroundWidget().set_color(new Color(1f, 0f, 0f));
		}
		float num = MEDAGKOPJMO.m_hp;
		int max_hp = MEDAGKOPJMO.get_m_max_hp();
		if (num > 0f && MEDAGKOPJMO.GetHeroInfo() != null)
		{
			m_hpBar.set_value(num / (float)max_hp);
		}
		else
		{
			m_hpBar.set_value(0f);
		}
		float num2 = MEDAGKOPJMO.m_mp;
		int max_mp = MEDAGKOPJMO.get_m_max_mp();
		if (num2 > 0f && max_mp > 0 && MEDAGKOPJMO.GetHeroInfo() != null)
		{
			m_mpBar.set_value(num2 / (float)max_mp);
		}
		else
		{
			m_mpBar.set_value(0f);
		}
		float num3 = MEDAGKOPJMO.m_shield;
		if (num3 > 0f && max_hp > 0)
		{
			m_shieldBar.set_fillAmount((num + num3) / (float)max_hp);
		}
		else
		{
			m_shieldBar.set_fillAmount(0f);
		}
	}

	public void AddCritical(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_criticalHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void AddDamage(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_damageHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void AFJAAILHBDJ(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_healHudText.HEFOLGAIPON(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void AddGold(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_goldHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void FFGIFEGHHCH(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_damageHudText.HEFOLGAIPON(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	private void Start()
	{
		Refresh();
	}

	public void PAAPJINGMBN(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_damageHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void FMMABCHEONP(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_damageHudText.HEFOLGAIPON(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void SetInfo(Actor CDKMPAEODLA, Transform LPOAEBNAGCP)
	{
		MEDAGKOPJMO = CDKMPAEODLA;
		FPMHJOAGHIL = GetComponent<UIFollowTarget>();
		FPMHJOAGHIL.target = LPOAEBNAGCP;
		if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			if (!m_levelBack.activeSelf)
			{
				m_levelBack.SetActive(true);
			}
			if (CDKMPAEODLA.m_hero_id == 18 || CDKMPAEODLA.m_hero_id == 19)
			{
				m_exBar.gameObject.SetActive(true);
			}
			else
			{
				m_exBar.gameObject.SetActive(false);
			}
			if (!m_mpBar.gameObject.activeSelf)
			{
				m_mpBar.gameObject.SetActive(true);
			}
		}
		else
		{
			if (m_levelBack.activeSelf)
			{
				m_levelBack.SetActive(false);
			}
			if (m_mpBar.gameObject.activeSelf)
			{
				m_mpBar.gameObject.SetActive(false);
			}
		}
		Refresh();
	}

	public void KKOJDEHGAAI()
	{
		if (m_hpBar == null)
		{
			return;
		}
		if (ActorManager.get_Instance().GetControlActor() == MEDAGKOPJMO)
		{
			if (m_hpBar.NPPHLHAGKKE().get_color() != new Color(1353f, 1703f, 500f))
			{
				m_hpBar.get_foregroundWidget().set_color(new Color(1812f, 71f, 385f));
			}
		}
		else if (MEDAGKOPJMO.IJBJAKPGGGN())
		{
			if (m_hpBar.OGCEIIMDOAP().get_color() != new Color(353f, 964f, 1272f))
			{
				m_hpBar.JCDFLNABDEE().set_color(new Color(1995f, 1228f, 1159f));
			}
		}
		else if (m_hpBar.OGCEIIMDOAP().get_color() != new Color(783f, 1531f, 1785f))
		{
			m_hpBar.JCDFLNABDEE().set_color(new Color(399f, 731f, 1438f));
		}
		float num = MEDAGKOPJMO.m_hp;
		int max_hp = MEDAGKOPJMO.get_m_max_hp();
		if (num > 1844f && MEDAGKOPJMO.GetHeroInfo() != null)
		{
			m_hpBar.ICKFKDNHDOG(num / (float)max_hp);
		}
		else
		{
			m_hpBar.ICKFKDNHDOG(1615f);
		}
		float num2 = MEDAGKOPJMO.m_mp;
		int max_mp = MEDAGKOPJMO.get_m_max_mp();
		if (num2 > 1813f && max_mp > 1 && MEDAGKOPJMO.GetHeroInfo() != null)
		{
			m_mpBar.set_value(num2 / (float)max_mp);
		}
		else
		{
			m_mpBar.ICKFKDNHDOG(947f);
		}
		float num3 = MEDAGKOPJMO.m_shield;
		if (num3 > 1677f && max_hp > 1)
		{
			m_shieldBar.set_fillAmount((num + num3) / (float)max_hp);
		}
		else
		{
			m_shieldBar.set_fillAmount(846f);
		}
	}

	public void MBDEAIINOIP(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_damageHudText.HEFOLGAIPON(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	public void HJMJFONMNGI(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		m_criticalHudText.Add(HCKCCHPJOPI, CEMGPCOMLOP, CMADNCOPOAO);
	}

	private void CLLECEEEJAI()
	{
		FKFKDGDCCED();
	}
}
