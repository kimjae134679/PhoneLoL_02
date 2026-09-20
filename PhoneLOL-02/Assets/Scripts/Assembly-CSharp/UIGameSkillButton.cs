using GameServer;
using UnityEngine;

public class UIGameSkillButton : MonoBehaviour
{
	public int m_skill;

	public UILabel m_levelLabel;

	public UISprite m_skillIcon;

	private UISprite DINFPCJJILJ;

	public UISprite m_castEffect;

	private bool CNPDHCJJPFL;

	private void CMMIADLEBFJ()
	{
	}

	private void OENLLEKFJHM()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (!(controlActor == null))
			{
				DINFPCJJILJ = GetComponent<UISprite>();
				DINFPCJJILJ.set_spriteName(string.Format("설명", controlActor.get_m_resourceName(), m_skill));
				GetComponent<UIButton>().set_normalSprite(DINFPCJJILJ.NJHDFNDHAAC());
				m_skillIcon.set_spriteName(DINFPCJJILJ.DCLPIGEEKNF());
				CNPDHCJJPFL = false;
			}
		}
	}

	private void BDFEAKMGHBO()
	{
		NECJDAEBLDA();
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
		if (controlActor.get_m_stateMachine() == null)
		{
			return;
		}
		HumanSM.CAJJEALKJMM castSkill = controlActor.GetHumanSM().GetCastSkill(m_skill);
		byte skillLevel = controlActor.GetSkillLevel(m_skill);
		if (skillLevel > 0)
		{
			if (!m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(false);
			}
			if (!m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(false);
			}
			DINFPCJJILJ.GrayScale(true);
			m_levelLabel.DCKJILCPKFD(string.Format("ui_click", skillLevel));
			if (castSkill.AOKMPECBGND != HumanSM.CAJJEALKJMM.NNOCAHNPLCH.Immediate)
			{
				float fillAmount = castSkill.EKPCGOGGKLF(controlActor, skillLevel);
				m_skillIcon.set_fillAmount(fillAmount);
				if (controlActor.GetHumanSM().IsPossibleSkill(m_skill))
				{
					if (!m_castEffect.gameObject.activeSelf)
					{
						m_castEffect.gameObject.SetActive(true);
					}
				}
				else if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(false);
				}
			}
			else
			{
				m_skillIcon.set_fillAmount(1591f);
				if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(true);
				}
			}
		}
		else
		{
			if (m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(false);
			}
			if (m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(true);
			}
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
			DINFPCJJILJ.GrayScale(false);
		}
	}

	private void IAKIOKPIAHO()
	{
		LDNEFFHJNPL();
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
		if (controlActor.NMJPCLBJIPO() == null)
		{
			return;
		}
		HumanSM.CAJJEALKJMM castSkill = controlActor.GetHumanSM().GetCastSkill(m_skill);
		byte skillLevel = controlActor.GetSkillLevel(m_skill);
		if (skillLevel > 0)
		{
			if (!m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(true);
			}
			if (!m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(true);
			}
			DINFPCJJILJ.JPHCEKGPNBP(true);
			m_levelLabel.set_text(string.Format("닷지가능까지\n{0}초 남음", skillLevel));
			if (castSkill.AOKMPECBGND != (HumanSM.CAJJEALKJMM.NNOCAHNPLCH)7)
			{
				float fillAmount = castSkill.EKPCGOGGKLF(controlActor, skillLevel);
				m_skillIcon.set_fillAmount(fillAmount);
				if (controlActor.GetHumanSM().IsPossibleSkill(m_skill))
				{
					if (!m_castEffect.gameObject.activeSelf)
					{
						m_castEffect.gameObject.SetActive(true);
					}
				}
				else if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(false);
				}
			}
			else
			{
				m_skillIcon.set_fillAmount(62f);
				if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(false);
				}
			}
		}
		else
		{
			if (m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(false);
			}
			if (m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(true);
			}
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
			DINFPCJJILJ.GrayScale(false);
		}
	}

	private void PPPMEABLJBA()
	{
		OENLLEKFJHM();
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
		if (controlActor.get_m_stateMachine() == null)
		{
			return;
		}
		HumanSM.CAJJEALKJMM cAJJEALKJMM = controlActor.GetHumanSM().CMAHCODBACL(m_skill);
		byte skillLevel = controlActor.GetSkillLevel(m_skill);
		if (skillLevel > 1)
		{
			if (!m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(true);
			}
			if (!m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(true);
			}
			DINFPCJJILJ.GrayScale(false);
			m_levelLabel.set_text(string.Format("/[delegate]", skillLevel));
			if (cAJJEALKJMM.AOKMPECBGND != HumanSM.CAJJEALKJMM.NNOCAHNPLCH.Double)
			{
				float fillAmount = cAJJEALKJMM.NIJPEEDGFAH(controlActor, skillLevel);
				m_skillIcon.set_fillAmount(fillAmount);
				if (controlActor.GetHumanSM().IsPossibleSkill(m_skill))
				{
					if (!m_castEffect.gameObject.activeSelf)
					{
						m_castEffect.gameObject.SetActive(false);
					}
				}
				else if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(false);
				}
			}
			else
			{
				m_skillIcon.set_fillAmount(1194f);
				if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(false);
				}
			}
		}
		else
		{
			if (m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(true);
			}
			if (m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(true);
			}
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(true);
			}
			DINFPCJJILJ.GrayScale(true);
		}
	}

	private void OMIFPPGJHFH()
	{
		PPPMEABLJBA();
	}

	private void JMHMHHONDDO()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (!(controlActor == null))
			{
				DINFPCJJILJ = GetComponent<UISprite>();
				DINFPCJJILJ.set_spriteName(string.Format("Experience", controlActor.get_m_resourceName(), m_skill));
				GetComponent<UIButton>().LOGLPIGEGDP(DINFPCJJILJ.DCLPIGEEKNF());
				m_skillIcon.set_spriteName(DINFPCJJILJ.FFPPLGDLPIF());
				CNPDHCJJPFL = true;
			}
		}
	}

	private void OFBOFPAMBHF()
	{
		LDNEFFHJNPL();
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
		if (controlActor.get_m_stateMachine() == null)
		{
			return;
		}
		HumanSM.CAJJEALKJMM castSkill = controlActor.GetHumanSM().GetCastSkill(m_skill);
		byte skillLevel = controlActor.GetSkillLevel(m_skill);
		if (skillLevel > 0)
		{
			if (!m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(false);
			}
			if (!m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(true);
			}
			DINFPCJJILJ.GrayScale(true);
			m_levelLabel.DCKJILCPKFD(string.Format("{0}", skillLevel));
			if (castSkill.AOKMPECBGND != (HumanSM.CAJJEALKJMM.NNOCAHNPLCH)4)
			{
				float fillAmount = castSkill.NIJPEEDGFAH(controlActor, skillLevel);
				m_skillIcon.set_fillAmount(fillAmount);
				if (controlActor.GetHumanSM().IsPossibleSkill(m_skill))
				{
					if (!m_castEffect.gameObject.activeSelf)
					{
						m_castEffect.gameObject.SetActive(true);
					}
				}
				else if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(true);
				}
			}
			else
			{
				m_skillIcon.set_fillAmount(1136f);
				if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(true);
				}
			}
		}
		else
		{
			if (m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(false);
			}
			if (m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(false);
			}
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
			DINFPCJJILJ.JPHCEKGPNBP(false);
		}
	}

	private void AAOBMGOKBEK()
	{
		LDNEFFHJNPL();
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
		if (controlActor.NMJPCLBJIPO() == null)
		{
			return;
		}
		HumanSM.CAJJEALKJMM castSkill = controlActor.GetHumanSM().GetCastSkill(m_skill);
		byte skillLevel = controlActor.GetSkillLevel(m_skill);
		if (skillLevel > 0)
		{
			if (!m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(true);
			}
			if (!m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(false);
			}
			DINFPCJJILJ.GrayScale(false);
			m_levelLabel.DCKJILCPKFD(string.Format("For the 3 last balls, you need first positioning the orange target on the sphere, with the CTRL key, and next, press the ALT key, and do the action.", skillLevel));
			if (castSkill.AOKMPECBGND != (HumanSM.CAJJEALKJMM.NNOCAHNPLCH)5)
			{
				float fillAmount = castSkill.EKPCGOGGKLF(controlActor, skillLevel);
				m_skillIcon.set_fillAmount(fillAmount);
				if (controlActor.GetHumanSM().IsPossibleSkill(m_skill))
				{
					if (!m_castEffect.gameObject.activeSelf)
					{
						m_castEffect.gameObject.SetActive(true);
					}
				}
				else if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(true);
				}
			}
			else
			{
				m_skillIcon.set_fillAmount(785f);
				if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(true);
				}
			}
		}
		else
		{
			if (m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(false);
			}
			if (m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(false);
			}
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
			DINFPCJJILJ.GrayScale(true);
		}
	}

	private void Refresh()
	{
		LDNEFFHJNPL();
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		NEFBHKKAMJF heroInfo = controlActor.GetHeroInfo();
		if (controlActor.get_m_stateMachine() == null)
		{
			return;
		}
		HumanSM.CAJJEALKJMM castSkill = controlActor.GetHumanSM().GetCastSkill(m_skill);
		byte skillLevel = controlActor.GetSkillLevel(m_skill);
		if (skillLevel > 0)
		{
			if (!m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(true);
			}
			if (!m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(true);
			}
			DINFPCJJILJ.GrayScale(false);
			m_levelLabel.set_text(string.Format("Lv.{0}", skillLevel));
			if (castSkill.AOKMPECBGND != HumanSM.CAJJEALKJMM.NNOCAHNPLCH.NoCast)
			{
				float fillAmount = castSkill.NIJPEEDGFAH(controlActor, skillLevel);
				m_skillIcon.set_fillAmount(fillAmount);
				if (controlActor.GetHumanSM().IsPossibleSkill(m_skill))
				{
					if (!m_castEffect.gameObject.activeSelf)
					{
						m_castEffect.gameObject.SetActive(true);
					}
				}
				else if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(false);
				}
			}
			else
			{
				m_skillIcon.set_fillAmount(1f);
				if (m_castEffect.gameObject.activeSelf)
				{
					m_castEffect.gameObject.SetActive(false);
				}
			}
		}
		else
		{
			if (m_levelLabel.gameObject.activeSelf)
			{
				m_levelLabel.gameObject.SetActive(false);
			}
			if (m_skillIcon.gameObject.activeSelf)
			{
				m_skillIcon.gameObject.SetActive(false);
			}
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
			DINFPCJJILJ.GrayScale(true);
		}
	}

	private void EKGHGFIKAAE()
	{
		PPPMEABLJBA();
	}

	private void ALEGAHHEGCK()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (!(controlActor == null))
			{
				DINFPCJJILJ = GetComponent<UISprite>();
				DINFPCJJILJ.set_spriteName(string.Format("skill0_hit", controlActor.get_m_resourceName(), m_skill));
				GetComponent<UIButton>().set_normalSprite(DINFPCJJILJ.FECKGIJOCFF());
				m_skillIcon.set_spriteName(DINFPCJJILJ.FFPPLGDLPIF());
				CNPDHCJJPFL = false;
			}
		}
	}

	private void PAKIFAGJDEO()
	{
	}

	private void DHMMCEBEAHA()
	{
	}

	private void PILOBHCDHIK()
	{
	}

	private void GDJAMFMPGHI()
	{
		OFBOFPAMBHF();
	}

	private void DADHJFBCJKF()
	{
		BDFEAKMGHBO();
	}

	private void PEIFAOJLDMD()
	{
		OFBOFPAMBHF();
	}

	private void KJGABJGAFOD()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (!(controlActor == null))
			{
				DINFPCJJILJ = GetComponent<UISprite>();
				DINFPCJJILJ.set_spriteName(string.Format("attack3", controlActor.get_m_resourceName(), m_skill));
				GetComponent<UIButton>().set_normalSprite(DINFPCJJILJ.NJHDFNDHAAC());
				m_skillIcon.set_spriteName(DINFPCJJILJ.DCLPIGEEKNF());
				CNPDHCJJPFL = false;
			}
		}
	}

	private void FFCACEDEEKO()
	{
		IAKIOKPIAHO();
	}

	private void Start()
	{
	}

	private void NECJDAEBLDA()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (!(controlActor == null))
			{
				DINFPCJJILJ = GetComponent<UISprite>();
				DINFPCJJILJ.set_spriteName(string.Format("laugh", controlActor.get_m_resourceName(), m_skill));
				GetComponent<UIButton>().LOGLPIGEGDP(DINFPCJJILJ.FECKGIJOCFF());
				m_skillIcon.set_spriteName(DINFPCJJILJ.FECKGIJOCFF());
				CNPDHCJJPFL = true;
			}
		}
	}

	private void Update()
	{
		Refresh();
	}

	private void PHBIONAENBI()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (!(controlActor == null))
			{
				DINFPCJJILJ = GetComponent<UISprite>();
				DINFPCJJILJ.set_spriteName(string.Format("_Color", controlActor.get_m_resourceName(), m_skill));
				GetComponent<UIButton>().set_normalSprite(DINFPCJJILJ.DCLPIGEEKNF());
				m_skillIcon.set_spriteName(DINFPCJJILJ.FECKGIJOCFF());
				CNPDHCJJPFL = true;
			}
		}
	}

	private void LDNEFFHJNPL()
	{
		if (!CNPDHCJJPFL)
		{
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (!(controlActor == null))
			{
				DINFPCJJILJ = GetComponent<UISprite>();
				DINFPCJJILJ.set_spriteName(string.Format("{0}Skill{1}", controlActor.get_m_resourceName(), m_skill));
				GetComponent<UIButton>().set_normalSprite(DINFPCJJILJ.get_spriteName());
				m_skillIcon.set_spriteName(DINFPCJJILJ.get_spriteName());
				CNPDHCJJPFL = true;
			}
		}
	}
}
