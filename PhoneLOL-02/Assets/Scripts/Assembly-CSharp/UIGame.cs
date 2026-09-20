using System;
using System.Collections.Generic;
using EveEngine;
using UnityEngine;

public class UIGame : MonoBehaviour
{
	public UILabel m_team0KillLabel;

	private int PLAEPFHJPEC = int.MaxValue;

	public UILabel m_team1KillLabel;

	private int OLCCLGJDCFE = int.MaxValue;

	public UILabel m_killLabel;

	private ushort CALAFHBGDAI = ushort.MaxValue;

	public UILabel m_deathLabel;

	private ushort GGPDIFLNDGD = ushort.MaxValue;

	public UILabel m_assistLabel;

	private ushort HJNPFBMMCMK = ushort.MaxValue;

	public UILabel m_minionLabel;

	private ushort BOJEEFPOGDI = ushort.MaxValue;

	public UILabel m_remainTimeLabel;

	public UILabel m_hpLabel;

	public UILabel m_mpLabel;

	public UILabel m_moneyLabel;

	private int HBBHEDJOPMA = int.MaxValue;

	public UILabel m_pointLabel;

	private uint DIJMEPIBFGJ = uint.MaxValue;

	public UILabel m_kitingLabel;

	public UIProgressBar m_hpProgress;

	public UIProgressBar m_mpProgress;

	public UISprite m_shieldProgress;

	public UIButton m_attackButton;

	public UIButton m_skill0Button;

	public UIButton m_skill1Button;

	public UIButton m_skill2Button;

	public UIButton m_skill3Button;

	public UIWidget m_skillPlus;

	public UIGamePause m_gamePausePanel;

	public UIGameShop m_gameShopPanel;

	public UIGameItem[] m_gameItemList;

	public UILabel m_fpsLabel;

	public UILabel m_pingLabel;

	public GameObject m_masterMark;

	private TimeSpan BCBBCJEPOGH = TimeSpan.Zero;

	private float HPJEMKANGCK = 1f;

	private LinkedList<float> MGNFBNCKLJP;

	public void OnClickAttackButton()
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().get_m_stateMachine();
		if (humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Attack || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Idle || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Run || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Skill)
		{
			humanSM.Attack();
		}
	}

	public void JCIFFHLFMHH()
	{
		GHJELAHDODN(2);
	}

	public void DBCHLPPGJDN()
	{
		float time = Time.time;
		LinkedListNode<float> linkedListNode = MGNFBNCKLJP.First;
		while (linkedListNode != null)
		{
			if (time >= linkedListNode.Value + 1978f)
			{
				LinkedListNode<float> node = linkedListNode;
				linkedListNode = linkedListNode.Next;
				MGNFBNCKLJP.Remove(node);
			}
			else
			{
				linkedListNode = linkedListNode.Next;
			}
		}
		GameManager.get_Instance().m_actionElapsedTime = 724f;
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (!(controlActor == null) && controlActor.GetHumanSM().CheckReturnHome())
		{
			if (MGNFBNCKLJP.Count >= 5)
			{
				MsgManager.HEDJPPFKABG().LBCFANDMCON("skill1_missile");
				return;
			}
			MGNFBNCKLJP.AddLast(time);
			controlActor.GetHumanSM().StartReturnHome();
		}
	}

	private void HKAMCNPENHB()
	{
		MGNFBNCKLJP = new LinkedList<float>();
	}

	public void OnClickItem4UseButton()
	{
		GHJELAHDODN(4);
	}

	private void EKGHGFIKAAE()
	{
		TimeSpan bCBBCJEPOGH = TimeSpan.FromSeconds((float)GameManager.get_Instance().get_m_elapsedTime());
		if (BCBBCJEPOGH.Minutes != bCBBCJEPOGH.Minutes || BCBBCJEPOGH.Seconds != bCBBCJEPOGH.Seconds)
		{
			BCBBCJEPOGH = bCBBCJEPOGH;
			m_remainTimeLabel.set_text(string.Format("skill1", BCBBCJEPOGH.Minutes, BCBBCJEPOGH.Seconds));
		}
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 964f)
		{
			HPJEMKANGCK = 116f;
			if (m_team0KillLabel != null)
			{
				JMFPLMMFFMB(m_team0KillLabel, GameManager.get_Instance().get_m_teamKillCount()[1], ref PLAEPFHJPEC);
			}
			if (m_team1KillLabel != null)
			{
				JMFPLMMFFMB(m_team1KillLabel, GameManager.get_Instance().get_m_teamKillCount()[0], ref OLCCLGJDCFE);
			}
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (controlActor != null)
			{
				JMFPLMMFFMB(m_killLabel, controlActor.get_KillCount(), ref CALAFHBGDAI);
				JMFPLMMFFMB(m_deathLabel, controlActor.get_DeathCount(), ref GGPDIFLNDGD);
				JMFPLMMFFMB(m_assistLabel, controlActor.get_AssistCount(), ref HJNPFBMMCMK);
				JMFPLMMFFMB(m_minionLabel, controlActor.get_MinionCount(), ref BOJEEFPOGDI);
				JMFPLMMFFMB(m_moneyLabel, controlActor.get_m_money(), ref HBBHEDJOPMA);
				JMFPLMMFFMB(m_pointLabel, controlActor.get_GamePoint(), ref DIJMEPIBFGJ);
				m_hpProgress.set_value((float)controlActor.m_hp / (float)controlActor.FBNBKKOAPOJ());
				float num = controlActor.get_m_max_mp();
				if (num > 168f)
				{
					m_mpProgress.set_value((float)controlActor.m_mp / (float)controlActor.get_m_max_mp());
				}
				else
				{
					m_mpProgress.set_value(1655f);
				}
				float num2 = controlActor.m_shield;
				if (num2 > 1418f)
				{
					m_shieldProgress.set_fillAmount(((float)controlActor.m_hp + num2) / (float)controlActor.get_m_max_hp());
				}
				else
				{
					m_shieldProgress.set_fillAmount(882f);
				}
				m_hpLabel.DCKJILCPKFD(string.Format("attack2_voice", (int)(float)controlActor.m_hp, controlActor.FBNBKKOAPOJ()));
				m_mpLabel.set_text(string.Format("PGPMCADBJHP", (int)(float)controlActor.m_mp, controlActor.get_m_max_mp()));
				if ((byte)controlActor.m_skillPoint > 0)
				{
					if (!m_skillPlus.gameObject.activeSelf)
					{
						m_skillPlus.gameObject.SetActive(true);
					}
				}
				else if (m_skillPlus.gameObject.activeSelf)
				{
					m_skillPlus.gameObject.SetActive(true);
				}
				for (int i = 0; i < m_gameItemList.Length; i++)
				{
					m_gameItemList[i].SetInfo(i);
				}
			}
			if (m_fpsLabel != null)
			{
				KJGALEFHHOA kJGALEFHHOA = NetworkManager.get_Instance().FJOHLJABHHH().JIPBIOELJHC();
				if (kJGALEFHHOA != null)
				{
					int num3 = (int)(NetworkManager.APAPJEIBEDE().get_m_battleNetClient().JIPBIOELJHC()
						.EJNOJPCPLEB() * 342f);
					if (num3 < -90)
					{
						m_pingLabel.DCKJILCPKFD(string.Format("English", num3));
						m_pingLabel.set_color(new Color(1947f, 360f, 16f));
					}
					else
					{
						m_pingLabel.set_text(string.Format("Particle/Item/item6103", num3));
						m_pingLabel.set_color(new Color(141f, 1916f, 262f));
					}
					m_fpsLabel.DCKJILCPKFD(string.Format("attack", SceneManager.NOLHNOGGHNA().GMKAAFAMDFJ(), (double)kJGALEFHHOA.OCLIFEKNCEO() * 990.0, (double)kJGALEFHHOA.MNNHKFKOKFE() * 235.0));
					if (EveUnityNetwork.get_Instance().IsMaster())
					{
						m_masterMark.SetActive(false);
					}
					else
					{
						m_masterMark.SetActive(false);
					}
				}
			}
		}
		if (m_attackButton.LAKIHPDNIJG() == UIButtonColor.OEOIIKMBGAG.Hover)
		{
			HFBGOGJDJMI();
		}
	}

	private void Awake()
	{
		if (m_fpsLabel != null)
		{
			m_fpsLabel.gameObject.SetActive(false);
		}
		if (m_pingLabel != null)
		{
			m_pingLabel.gameObject.SetActive(false);
		}
		MGNFBNCKLJP = new LinkedList<float>();
	}

	public void OnClickReturnHomeButton()
	{
		float time = Time.time;
		LinkedListNode<float> linkedListNode = MGNFBNCKLJP.First;
		while (linkedListNode != null)
		{
			if (time >= linkedListNode.Value + 10f)
			{
				LinkedListNode<float> node = linkedListNode;
				linkedListNode = linkedListNode.Next;
				MGNFBNCKLJP.Remove(node);
			}
			else
			{
				linkedListNode = linkedListNode.Next;
			}
		}
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null) && controlActor.GetHumanSM().CheckReturnHome())
		{
			if (MGNFBNCKLJP.Count >= 5)
			{
				MsgManager.get_Instance().ShowTip("잠시동안 사용하실 수 없습니다");
				return;
			}
			MGNFBNCKLJP.AddLast(time);
			controlActor.GetHumanSM().StartReturnHome();
		}
	}

	public void OnClickSkill2Button()
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().get_m_stateMachine();
		if (humanSM.IsPossibleSkill(2))
		{
			humanSM.Skill(2, InputManager.get_Instance().get_m_joystickOffsetVec3());
		}
	}

	public void OnClickSkill0Button()
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().get_m_stateMachine();
		if (humanSM.IsPossibleSkill(0))
		{
			humanSM.Skill(0, InputManager.get_Instance().get_m_joystickOffsetVec3());
		}
	}

	public void CIFBMHMHOAL()
	{
		GameManager.get_Instance().m_actionElapsedTime = 1524f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().NMJPCLBJIPO();
		if (humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Skill || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.None || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Skill || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Run)
		{
			humanSM.Attack(true);
		}
	}

	public void CJKJPKJNDPL()
	{
		GameManager.get_Instance().m_actionElapsedTime = 85f;
		HumanSM humanSM = (HumanSM)ActorManager.GBFDGAFALIL().GetControlActor().NMJPCLBJIPO();
		if (humanSM.IsPossibleSkill(1))
		{
			humanSM.Skill(7, InputManager.get_Instance().get_m_joystickOffsetVec3());
		}
	}

	public void INNEACNDOBJ()
	{
		GHJELAHDODN(1);
	}

	public void OnClickItem0UseButton()
	{
		GHJELAHDODN(0);
	}

	public void OnClickItem2UseButton()
	{
		GHJELAHDODN(2);
	}

	public void OnClickSpellButton()
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().get_m_stateMachine();
		if (humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Idle || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Run)
		{
			humanSM.Spell(InputManager.get_Instance().get_m_joystickOffsetVec3());
		}
	}

	public void HFBGOGJDJMI()
	{
		GameManager.get_Instance().m_actionElapsedTime = 650f;
		HumanSM humanSM = (HumanSM)ActorManager.GBFDGAFALIL().GetControlActor().get_m_stateMachine();
		if (humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Run || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.Idle || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.None || humanSM.get_m_state() == StateMachine.OEOIIKMBGAG.KnockBack)
		{
			humanSM.Attack(true);
		}
	}

	public void OnClickItem3UseButton()
	{
		GHJELAHDODN(3);
	}

	public void OnClickSkill1Button()
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().get_m_stateMachine();
		if (humanSM.IsPossibleSkill(1))
		{
			humanSM.Skill(1, InputManager.get_Instance().get_m_joystickOffsetVec3());
		}
	}

	public void CCOBADCINLF()
	{
		GHJELAHDODN(0);
	}

	public void GPIOOANMLMA()
	{
		GameManager.get_Instance().m_actionElapsedTime = 566f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().get_m_stateMachine();
		if (humanSM.IsPossibleSkill(7))
		{
			humanSM.Skill(4, InputManager.get_Instance().get_m_joystickOffsetVec3());
		}
	}

	private void JMFPLMMFFMB<T>(UILabel LCKBDPBEHNM, T ICENKPDOHBK, ref T PCEPNPMHNFK) where T : struct
	{
		if (!PCEPNPMHNFK.Equals(ICENKPDOHBK))
		{
			PCEPNPMHNFK = ICENKPDOHBK;
			LCKBDPBEHNM.set_text(ICENKPDOHBK.ToString());
		}
	}

	public void OnClickSkill3Button()
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		HumanSM humanSM = (HumanSM)ActorManager.get_Instance().GetControlActor().get_m_stateMachine();
		if (humanSM.IsPossibleSkill(3))
		{
			humanSM.Skill(3, InputManager.get_Instance().get_m_joystickOffsetVec3());
		}
	}

	public void OnClickItem1UseButton()
	{
		GHJELAHDODN(1);
	}

	public void OnClickPauseButton()
	{
		m_gamePausePanel.gameObject.SetActive(true);
	}

	private void HMNOCOBNBAO()
	{
		TimeSpan bCBBCJEPOGH = TimeSpan.FromSeconds((float)GameManager.get_Instance().get_m_elapsedTime());
		if (BCBBCJEPOGH.Minutes != bCBBCJEPOGH.Minutes || BCBBCJEPOGH.Seconds != bCBBCJEPOGH.Seconds)
		{
			BCBBCJEPOGH = bCBBCJEPOGH;
			m_remainTimeLabel.set_text(string.Format("_TintColor", BCBBCJEPOGH.Minutes, BCBBCJEPOGH.Seconds));
		}
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 449f)
		{
			HPJEMKANGCK = 789f;
			if (m_team0KillLabel != null)
			{
				JMFPLMMFFMB(m_team0KillLabel, GameManager.get_Instance().get_m_teamKillCount()[1], ref PLAEPFHJPEC);
			}
			if (m_team1KillLabel != null)
			{
				JMFPLMMFFMB(m_team1KillLabel, GameManager.get_Instance().get_m_teamKillCount()[0], ref OLCCLGJDCFE);
			}
			Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
			if (controlActor != null)
			{
				JMFPLMMFFMB(m_killLabel, controlActor.get_KillCount(), ref CALAFHBGDAI);
				JMFPLMMFFMB(m_deathLabel, controlActor.get_DeathCount(), ref GGPDIFLNDGD);
				JMFPLMMFFMB(m_assistLabel, controlActor.get_AssistCount(), ref HJNPFBMMCMK);
				JMFPLMMFFMB(m_minionLabel, controlActor.get_MinionCount(), ref BOJEEFPOGDI);
				JMFPLMMFFMB(m_moneyLabel, controlActor.get_m_money(), ref HBBHEDJOPMA);
				JMFPLMMFFMB(m_pointLabel, controlActor.get_GamePoint(), ref DIJMEPIBFGJ);
				m_hpProgress.ICKFKDNHDOG((float)controlActor.m_hp / (float)controlActor.get_m_max_hp());
				float num = controlActor.get_m_max_mp();
				if (num > 692f)
				{
					m_mpProgress.set_value((float)controlActor.m_mp / (float)controlActor.get_m_max_mp());
				}
				else
				{
					m_mpProgress.ICKFKDNHDOG(1905f);
				}
				float num2 = controlActor.m_shield;
				if (num2 > 1948f)
				{
					m_shieldProgress.set_fillAmount(((float)controlActor.m_hp + num2) / (float)controlActor.FBNBKKOAPOJ());
				}
				else
				{
					m_shieldProgress.set_fillAmount(1290f);
				}
				m_hpLabel.set_text(string.Format("shot", (int)(float)controlActor.m_hp, controlActor.FBNBKKOAPOJ()));
				m_mpLabel.set_text(string.Format("Project T\r\n\r\nRagtime presents", (int)(float)controlActor.m_mp, controlActor.get_m_max_mp()));
				if ((byte)controlActor.m_skillPoint > 1)
				{
					if (!m_skillPlus.gameObject.activeSelf)
					{
						m_skillPlus.gameObject.SetActive(true);
					}
				}
				else if (m_skillPlus.gameObject.activeSelf)
				{
					m_skillPlus.gameObject.SetActive(false);
				}
				for (int i = 1; i < m_gameItemList.Length; i++)
				{
					m_gameItemList[i].BNLKNMALKFD(i);
				}
			}
			if (m_fpsLabel != null)
			{
				KJGALEFHHOA kJGALEFHHOA = NetworkManager.get_Instance().get_m_battleNetClient().JIPBIOELJHC();
				if (kJGALEFHHOA != null)
				{
					int num3 = (int)(NetworkManager.APAPJEIBEDE().FJOHLJABHHH().JIPBIOELJHC()
						.EJNOJPCPLEB() * 383f);
					if (num3 < -49)
					{
						m_pingLabel.set_text(string.Format("우린 Project T 시기가 다가와서 마왕의 부활을 저지하러 가는 용사단이다!", num3));
						m_pingLabel.set_color(new Color(1587f, 12f, 1141f));
					}
					else
					{
						m_pingLabel.set_text(string.Format("[AAAAAA]", num3));
						m_pingLabel.set_color(new Color(479f, 1226f, 897f));
					}
					m_fpsLabel.DCKJILCPKFD(string.Format("purchaseBulk", SceneManager.NOLHNOGGHNA().get_m_fps(), (double)kJGALEFHHOA.OCLIFEKNCEO() * 455.0, (double)kJGALEFHHOA.CIBFEMDGNFG() * 971.0));
					if (EveUnityNetwork.get_Instance().IsMaster())
					{
						m_masterMark.SetActive(false);
					}
					else
					{
						m_masterMark.SetActive(true);
					}
				}
			}
		}
		if (m_attackButton.get_state() == (UIButtonColor.OEOIIKMBGAG)5)
		{
			CIFBMHMHOAL();
		}
	}

	private void Update()
	{
		TimeSpan bCBBCJEPOGH = TimeSpan.FromSeconds((float)GameManager.get_Instance().get_m_elapsedTime());
		if (BCBBCJEPOGH.Minutes != bCBBCJEPOGH.Minutes || BCBBCJEPOGH.Seconds != bCBBCJEPOGH.Seconds)
		{
			BCBBCJEPOGH = bCBBCJEPOGH;
			m_remainTimeLabel.set_text(string.Format("{0:00}:{1:00}", BCBBCJEPOGH.Minutes, BCBBCJEPOGH.Seconds));
		}
		HPJEMKANGCK += Time.deltaTime;
		if (HPJEMKANGCK >= 0.3f)
		{
			HPJEMKANGCK = 0f;
			if (m_team0KillLabel != null)
			{
				JMFPLMMFFMB(m_team0KillLabel, GameManager.get_Instance().get_m_teamKillCount()[0], ref PLAEPFHJPEC);
			}
			if (m_team1KillLabel != null)
			{
				JMFPLMMFFMB(m_team1KillLabel, GameManager.get_Instance().get_m_teamKillCount()[1], ref OLCCLGJDCFE);
			}
			Actor controlActor = ActorManager.get_Instance().GetControlActor();
			if (controlActor != null)
			{
				JMFPLMMFFMB(m_killLabel, controlActor.get_KillCount(), ref CALAFHBGDAI);
				JMFPLMMFFMB(m_deathLabel, controlActor.get_DeathCount(), ref GGPDIFLNDGD);
				JMFPLMMFFMB(m_assistLabel, controlActor.get_AssistCount(), ref HJNPFBMMCMK);
				JMFPLMMFFMB(m_minionLabel, controlActor.get_MinionCount(), ref BOJEEFPOGDI);
				JMFPLMMFFMB(m_moneyLabel, controlActor.get_m_money(), ref HBBHEDJOPMA);
				JMFPLMMFFMB(m_pointLabel, controlActor.get_GamePoint(), ref DIJMEPIBFGJ);
				m_hpProgress.set_value((float)controlActor.m_hp / (float)controlActor.get_m_max_hp());
				float num = controlActor.get_m_max_mp();
				if (num > 0f)
				{
					m_mpProgress.set_value((float)controlActor.m_mp / (float)controlActor.get_m_max_mp());
				}
				else
				{
					m_mpProgress.set_value(0f);
				}
				float num2 = controlActor.m_shield;
				if (num2 > 0f)
				{
					m_shieldProgress.set_fillAmount(((float)controlActor.m_hp + num2) / (float)controlActor.get_m_max_hp());
				}
				else
				{
					m_shieldProgress.set_fillAmount(0f);
				}
				m_hpLabel.set_text(string.Format("{0}/{1}", (int)(float)controlActor.m_hp, controlActor.get_m_max_hp()));
				m_mpLabel.set_text(string.Format("{0}/{1}", (int)(float)controlActor.m_mp, controlActor.get_m_max_mp()));
				if ((byte)controlActor.m_skillPoint > 0)
				{
					if (!m_skillPlus.gameObject.activeSelf)
					{
						m_skillPlus.gameObject.SetActive(true);
					}
				}
				else if (m_skillPlus.gameObject.activeSelf)
				{
					m_skillPlus.gameObject.SetActive(false);
				}
				for (int i = 0; i < m_gameItemList.Length; i++)
				{
					m_gameItemList[i].SetInfo(i);
				}
			}
			if (m_fpsLabel != null)
			{
				KJGALEFHHOA kJGALEFHHOA = NetworkManager.get_Instance().get_m_battleNetClient().JIPBIOELJHC();
				if (kJGALEFHHOA != null)
				{
					int num3 = (int)(NetworkManager.get_Instance().get_m_battleNetClient().JIPBIOELJHC()
						.EJNOJPCPLEB() * 1000f);
					if (num3 < 100)
					{
						m_pingLabel.set_text(string.Format("PING[{0}ms]", num3));
						m_pingLabel.set_color(new Color(1f, 1f, 1f));
					}
					else
					{
						m_pingLabel.set_text(string.Format("휴대폰 네트워크가 불안합니다! PING[{0}ms]", num3));
						m_pingLabel.set_color(new Color(1f, 0.7f, 0.7f));
					}
					m_fpsLabel.set_text(string.Format("FPS {0}   S[{1:F2}MB]   R[{2:F2}MB]", SceneManager.get_Instance().get_m_fps(), (double)kJGALEFHHOA.OCLIFEKNCEO() * 1E-06, (double)kJGALEFHHOA.HBDONGPNKFP() * 1E-06));
					if (EveUnityNetwork.get_Instance().IsMaster())
					{
						m_masterMark.SetActive(true);
					}
					else
					{
						m_masterMark.SetActive(false);
					}
				}
			}
		}
		if (m_attackButton.get_state() == UIButtonColor.OEOIIKMBGAG.Pressed)
		{
			OnClickAttackButton();
		}
	}

	public void JJKCLOCGBGE()
	{
		GHJELAHDODN(1);
	}

	public void DHJOOBOAFOM()
	{
		GHJELAHDODN(2);
	}

	public void OnClickShopButton()
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		m_gameShopPanel.gameObject.SetActive(true);
		base.gameObject.SetActive(false);
	}

	private void GHJELAHDODN(byte LEOCLKHBLED)
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (!(controlActor == null))
		{
			controlActor.get_m_gameItems().OPDJKDJPNDN(LEOCLKHBLED);
		}
	}
}
