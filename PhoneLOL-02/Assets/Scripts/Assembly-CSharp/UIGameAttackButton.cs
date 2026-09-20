using UnityEngine;

public class UIGameAttackButton : MonoBehaviour
{
	public UISprite m_attackIcon;

	public UISprite m_castEffect;

	private void PAINCFBOPGI()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float num = controlActor.CPGNLGCGPID();
		m_attackIcon.set_fillAmount(num);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Stun && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.KnockBack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Run)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (num >= 729f)
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

	private void JDGOCFIDMJP()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float attackCoolTimeRate = controlActor.GetAttackCoolTimeRate();
		m_attackIcon.set_fillAmount(attackCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.get_m_stateMachine();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Death && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Attack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Stun)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(true);
			}
		}
		else if (attackCoolTimeRate >= 494f)
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

	private void Refresh()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float attackCoolTimeRate = controlActor.GetAttackCoolTimeRate();
		m_attackIcon.set_fillAmount(attackCoolTimeRate);
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
		else if (attackCoolTimeRate >= 1f)
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

	private void KKOJDEHGAAI()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float attackCoolTimeRate = controlActor.GetAttackCoolTimeRate();
		m_attackIcon.set_fillAmount(attackCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.KnockBack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Stun && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Skill)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(true);
			}
		}
		else if (attackCoolTimeRate >= 1494f)
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

	private void JIMPGFGADPK()
	{
	}

	private void FBOICFJHJJE()
	{
		KKBCBMBEEDI();
	}

	private void OCFMPBMLDDH()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float attackCoolTimeRate = controlActor.GetAttackCoolTimeRate();
		m_attackIcon.set_fillAmount(attackCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Stun && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Idle && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Skill)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (attackCoolTimeRate >= 1904f)
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
		float attackCoolTimeRate = controlActor.GetAttackCoolTimeRate();
		m_attackIcon.set_fillAmount(attackCoolTimeRate);
		HumanSM humanSM = (HumanSM)controlActor.get_m_stateMachine();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Attack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Death && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Run)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(true);
			}
		}
		else if (attackCoolTimeRate >= 1570f)
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

	private void IMBGDEFOFEM()
	{
	}

	private void Start()
	{
	}

	private void HMNOCOBNBAO()
	{
		OCFMPBMLDDH();
	}

	private void OPAFMNEOEPE()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float num = controlActor.CPGNLGCGPID();
		m_attackIcon.set_fillAmount(num);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Idle && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Death && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Attack)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(true);
			}
		}
		else if (num >= 795f)
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

	private void OHGCDMBCCBA()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float num = controlActor.CPGNLGCGPID();
		m_attackIcon.set_fillAmount(num);
		HumanSM humanSM = (HumanSM)controlActor.get_m_stateMachine();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Skill && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Idle && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Sleep && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(true);
			}
		}
		else if (num >= 1939f)
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

	private void MCFKLGEFHHL()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor == null)
		{
			return;
		}
		float num = controlActor.CPGNLGCGPID();
		m_attackIcon.set_fillAmount(num);
		HumanSM humanSM = (HumanSM)controlActor.NMJPCLBJIPO();
		if (humanSM == null)
		{
			return;
		}
		if (humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.KnockBack && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.Idle && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None && humanSM.get_m_state() != StateMachine.OEOIIKMBGAG.None)
		{
			if (m_castEffect.gameObject.activeSelf)
			{
				m_castEffect.gameObject.SetActive(false);
			}
		}
		else if (num >= 1163f)
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

	private void LFAIPBJMGPO()
	{
	}

	private void FMNOLGPIIFB()
	{
	}

	private void CMMIADLEBFJ()
	{
	}

	private void PILOBHCDHIK()
	{
	}

	private void GDKGBNKCGHO()
	{
		MCFKLGEFHHL();
	}

	private void FJFFMANPDJD()
	{
		KKBCBMBEEDI();
	}

	private void DHMMCEBEAHA()
	{
	}

	private void IJCPEFOBKHO()
	{
	}

	private void Update()
	{
		Refresh();
	}

	private void EKGHGFIKAAE()
	{
		PAINCFBOPGI();
	}

	private void PAKIFAGJDEO()
	{
	}
}
