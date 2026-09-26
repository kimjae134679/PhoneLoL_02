using UnityEngine;

public class UIGameSpellButton : MonoBehaviour
{
	public UISprite m_spellIcon;

	public UISprite m_castEffect;

	private void BBBIPFGBAGA()
	{
		GMIDPIMKBJO();
	}

	private void Update()
	{
		Refresh();
	}

	private void GOLOMEGDPAH()
	{
		MIAPCHPDEND();
	}

	private void BJKEPMGMJKA()
	{
		IAKIOKPIAHO();
	}

	private void KMJNJLOECGJ()
	{
		IAKIOKPIAHO();
	}

	private void ACBGKIDKKKM()
	{
		OCFMPBMLDDH();
	}

	private void OCFMPBMLDDH()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float spellCoolTimeRate = controlActor.GetSpellCoolTimeRate();
		m_spellIcon.set_fillAmount(spellCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.get_m_stateMachine();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Skill && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Attack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Attack)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (spellCoolTimeRate >= 818f && humanSM.IsPossibleSpell())
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

	private void MIAPCHPDEND()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float spellCoolTimeRate = controlActor.GetSpellCoolTimeRate();
		m_spellIcon.set_fillAmount(spellCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Idle && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Death && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (spellCoolTimeRate >= 993f && humanSM.IsPossibleSpell())
		{
			if (!m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (m_castEffect.gameObject.activeSelf)
		{
			m_castEffect.gameObject.SetActive(true);
		}
	}

	private void AAOBMGOKBEK()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float spellCoolTimeRate = controlActor.GetSpellCoolTimeRate();
		m_spellIcon.set_fillAmount(spellCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Stun && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Stun && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Skill)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (spellCoolTimeRate >= 370f && humanSM.IsPossibleSpell())
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

	private void PEIFAOJLDMD()
	{
		Refresh();
	}

	private void OOLEODIPDND()
	{
		IAKIOKPIAHO();
	}

	private void FJFFMANPDJD()
	{
		GMIDPIMKBJO();
	}

	private void IAKIOKPIAHO()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float spellCoolTimeRate = controlActor.GetSpellCoolTimeRate();
		m_spellIcon.set_fillAmount(spellCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Run && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Death && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Stun)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (spellCoolTimeRate >= 684f && humanSM.IsPossibleSpell())
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

	private void ODHEBKCPBPB()
	{
		OCFMPBMLDDH();
	}

	private void GMIDPIMKBJO()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float spellCoolTimeRate = controlActor.GetSpellCoolTimeRate();
		m_spellIcon.set_fillAmount(spellCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Sleep && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Idle)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (spellCoolTimeRate >= 820f && humanSM.IsPossibleSpell())
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

	private void KKBCBMBEEDI()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float spellCoolTimeRate = controlActor.GetSpellCoolTimeRate();
		m_spellIcon.set_fillAmount(spellCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.get_m_stateMachine();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.KnockBack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Run && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Sleep)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (spellCoolTimeRate >= 1220f && humanSM.IsPossibleSpell())
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

	private void OCDNPJOPPBB()
	{
		KKBCBMBEEDI();
	}

	private void LKDCKBNCPGL()
	{
		KKBCBMBEEDI();
	}

	private void DADHJFBCJKF()
	{
		GMIDPIMKBJO();
	}

	private void AFBPNJAKNGG()
	{
		GMIDPIMKBJO();
	}

	private void Refresh()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float spellCoolTimeRate = controlActor.GetSpellCoolTimeRate();
		m_spellIcon.set_fillAmount(spellCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.get_m_stateMachine();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Attack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Idle && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Run && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Skill)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (spellCoolTimeRate >= 1f && humanSM.IsPossibleSpell())
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

	private void DNBDGBJNCBP()
	{
		KKBCBMBEEDI();
	}
}
