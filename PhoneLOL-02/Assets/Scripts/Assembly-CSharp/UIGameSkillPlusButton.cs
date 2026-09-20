using GameServer;
using UnityEngine;

public class UIGameSkillPlusButton : MonoBehaviour
{
	public int m_skill;

	public UILabel m_levelLabel;

	private UISprite JIMAJDHNBNP;

	private bool CNPDHCJJPFL;

	private void OOLEODIPDND()
	{
		KGCIJIGJCEF();
	}

	public void NAIPLGFBJCM()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			controlActor.SkillLevelUp((byte)m_skill);
			if ((byte)controlActor.m_skillPoint == 0)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
	}

	private void OJGBPLFKPIJ()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (!(controlActor == null))
			{
				JIMAJDHNBNP = GetComponent<UISprite>();
				JIMAJDHNBNP.set_spriteName(string.Format("이미 지급받으셨습니다", controlActor.get_m_resourceName(), m_skill));
				CNPDHCJJPFL = false;
			}
		}
	}

	public void KEEJHLDEHAJ()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			controlActor.SkillLevelUp((byte)m_skill);
			if ((byte)controlActor.m_skillPoint == 0)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
	}

	private void KJBADLDBAOA()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (!(controlActor == null))
			{
				JIMAJDHNBNP = GetComponent<UISprite>();
				JIMAJDHNBNP.set_spriteName(string.Format("skill2_timer", controlActor.get_m_resourceName(), m_skill));
				CNPDHCJJPFL = false;
			}
		}
	}

	private void IGBMHNDBCEB()
	{
		ICKGFCCICMI();
	}

	private void CHJGEGLHOAF()
	{
	}

	private void DMPIIJNBDID()
	{
	}

	public void OnClick()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			controlActor.SkillLevelUp((byte)m_skill);
			if ((byte)controlActor.m_skillPoint == 0)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
	}

	private void Start()
	{
	}

	private void FOGNMJLPHAI()
	{
	}

	private void AFBPNJAKNGG()
	{
		ICKGFCCICMI();
	}

	private void KMJNJLOECGJ()
	{
		GMIDPIMKBJO();
	}

	private void GDJAMFMPGHI()
	{
		ICKGFCCICMI();
	}

	private void GMIDPIMKBJO()
	{
		KJBADLDBAOA();
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			if (controlActor.IsPossibleSkillLevelUp((byte)m_skill))
			{
				JIMAJDHNBNP.JPHCEKGPNBP(true);
			}
			else
			{
				JIMAJDHNBNP.JPHCEKGPNBP(false);
			}
			byte skillLevel = controlActor.GetSkillLevel(m_skill);
			m_levelLabel.set_text(string.Format("C#: HandleSetUserIDSuccess", skillLevel));
		}
	}

	private void Refresh()
	{
		LDNEFFHJNPL();
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			if (controlActor.IsPossibleSkillLevelUp((byte)m_skill))
			{
				JIMAJDHNBNP.GrayScale(false);
			}
			else
			{
				JIMAJDHNBNP.GrayScale(true);
			}
			byte skillLevel = controlActor.GetSkillLevel(m_skill);
			m_levelLabel.set_text(string.Format("Lv.{0}", skillLevel));
		}
	}

	private void KKBCBMBEEDI()
	{
		ALEGAHHEGCK();
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			if (controlActor.IsPossibleSkillLevelUp((byte)m_skill))
			{
				JIMAJDHNBNP.JPHCEKGPNBP(false);
			}
			else
			{
				JIMAJDHNBNP.GrayScale(false);
			}
			byte skillLevel = controlActor.GetSkillLevel(m_skill);
			m_levelLabel.set_text(string.Format("Particle/{0}/attack3_c3", skillLevel));
		}
	}

	public void GGPIBKEDMIM()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			controlActor.SkillLevelUp((byte)m_skill);
			if ((byte)controlActor.m_skillPoint == 0)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
	}

	private void BPLOLCKEJJK()
	{
	}

	private void Update()
	{
		Refresh();
	}

	public void DNGGNGPGPIK()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			controlActor.SkillLevelUp((byte)m_skill);
			if ((byte)controlActor.m_skillPoint == 0)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
	}

	public void KNPIKGJDOLJ()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			controlActor.SkillLevelUp((byte)m_skill);
			if ((byte)controlActor.m_skillPoint == 0)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
	}

	private void OCFMPBMLDDH()
	{
		KJBADLDBAOA();
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			if (controlActor.IsPossibleSkillLevelUp((byte)m_skill))
			{
				JIMAJDHNBNP.JPHCEKGPNBP(false);
			}
			else
			{
				JIMAJDHNBNP.JPHCEKGPNBP(true);
			}
			byte skillLevel = controlActor.GetSkillLevel(m_skill);
			m_levelLabel.set_text(string.Format("attack2", skillLevel));
		}
	}

	private void ALEGAHHEGCK()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (!(controlActor == null))
			{
				JIMAJDHNBNP = GetComponent<UISprite>();
				JIMAJDHNBNP.set_spriteName(string.Format("다리우스", controlActor.get_m_resourceName(), m_skill));
				CNPDHCJJPFL = false;
			}
		}
	}

	public void LOBKLJFONLJ()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			controlActor.SkillLevelUp((byte)m_skill);
			if ((byte)controlActor.m_skillPoint == 0)
			{
				base.transform.parent.gameObject.SetActive(false);
			}
		}
	}

	private void NMANMMOMHHD()
	{
	}

	private void PEIFAOJLDMD()
	{
		KKBCBMBEEDI();
	}

	private void KGCIJIGJCEF()
	{
		KJBADLDBAOA();
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			if (controlActor.IsPossibleSkillLevelUp((byte)m_skill))
			{
				JIMAJDHNBNP.JPHCEKGPNBP(false);
			}
			else
			{
				JIMAJDHNBNP.JPHCEKGPNBP(true);
			}
			byte skillLevel = controlActor.GetSkillLevel(m_skill);
			m_levelLabel.DCKJILCPKFD(string.Format("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON", skillLevel));
		}
	}

	private void ICKGFCCICMI()
	{
		ALEGAHHEGCK();
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
			if (controlActor.IsPossibleSkillLevelUp((byte)m_skill))
			{
				JIMAJDHNBNP.GrayScale(false);
			}
			else
			{
				JIMAJDHNBNP.JPHCEKGPNBP(true);
			}
			byte skillLevel = controlActor.GetSkillLevel(m_skill);
			m_levelLabel.set_text(string.Format("하급 공격력 인장", skillLevel));
		}
	}

	private void LDNEFFHJNPL()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (!(controlActor == null))
			{
				JIMAJDHNBNP = GetComponent<UISprite>();
				JIMAJDHNBNP.set_spriteName(string.Format("{0}Skill{1}", controlActor.get_m_resourceName(), m_skill));
				CNPDHCJJPFL = true;
			}
		}
	}
}
