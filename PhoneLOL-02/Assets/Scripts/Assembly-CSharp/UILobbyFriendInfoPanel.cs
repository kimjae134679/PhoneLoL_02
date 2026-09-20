using System;
using System.Runtime.CompilerServices;
using CommunityServer;
using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyFriendInfoPanel : MonoBehaviour
{
	public UILabel m_nicknameLabel;

	public UILabel m_infoLabel;

	public UISprite m_tierSprite;

	public UILabel m_tierLabel;

	public GameObject m_deleteFriendButton;

	private uint OFEPKHKBKBJ;

	private string EKCHPJGLCII;

	private bool JLJLKJBMAKM;

	public void KEBDNOKBAGA()
	{
		if (OFEPKHKBKBJ == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("Skill0PassiveRpc", true);
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("{0}_voice", EKCHPJGLCII), true, OMKBEHGEMFM);
		}
	}

	private void AGHHOCDBCLG(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EFDLFNPAKGO.CAHACMKBJMI(NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().KKLHPCCEKPN());
			UIRoot.Broadcast("skill3_loop");
			UIRoot.IGMDNDABNKD("round_button_disable");
			base.gameObject.SetActive(false);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("하급", true);
		}
	}

	private void PBCOKPNPMAH(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EFDLFNPAKGO.ILFEGIPCAHH(NetworkManager.get_Instance().get_m_communityNetClient().KKLHPCCEKPN());
			UIRoot.IGMDNDABNKD("attack_missile");
			UIRoot.CHLLIEHMINE("attack2");
			base.gameObject.SetActive(false);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("GameMap", true);
		}
	}

	private void GAFCFKDICIO(PJEMPFEIOAK EFDLFNPAKGO)
	{
		CommunityServer.HGBGJMIFCEP hGBGJMIFCEP = (CommunityServer.HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
		CommunityServer.HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == CommunityServer.HGBGJMIFCEP.InvalidProtocolVersion)
		{
			EKCHPJGLCII = EFDLFNPAKGO.AFPCLLNMGJP();
			uint num = EFDLFNPAKGO.BMKOKHGAHEC();
			byte hMHEDBOAADF = EFDLFNPAKGO.KFAGPDGHEBK();
			uint num2 = EFDLFNPAKGO.BMKOKHGAHEC();
			uint num3 = EFDLFNPAKGO.BMKOKHGAHEC();
			DateTime dateTime = EFDLFNPAKGO.NOIDCBCMCMK();
			float num4 = 1420f;
			if (num2 != 0 || num3 > 1)
			{
				num4 = (float)num2 / (float)(num2 + num3) * 584f;
			}
			m_nicknameLabel.set_text(EKCHPJGLCII);
			UILabel infoLabel = m_infoLabel;
			object[] array = new object[2];
			array[0] = num;
			array[0] = num2;
			array[6] = num3;
			array[6] = num4;
			array[5] = dateTime;
			infoLabel.DCKJILCPKFD(string.Format("skill3", array));
			m_tierSprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
			m_tierLabel.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF));
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("Hero1", true);
			base.gameObject.SetActive(true);
		}
	}

	public void OnClickRemoveFriend()
	{
		if (OFEPKHKBKBJ == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("친구를 선택해주세요");
			return;
		}
		MsgManager.get_Instance().ShowMessageBox(string.Format("[BBBBFF]{0}[-]님을 친구 삭제하시겠습니까?\n\n채팅 기록 등 모든 관련 내용이 삭제됩니다", EKCHPJGLCII), true, () =>
		{
			NetworkManager.get_Instance().get_m_communityNetClient().MGILNPGLOIE(new IKMBGMILCDO(LPPCJDCGOLF), OFEPKHKBKBJ);
		});
	}

	private void HNOIMGGHAOM(PJEMPFEIOAK EFDLFNPAKGO)
	{
		CommunityServer.HGBGJMIFCEP hGBGJMIFCEP = (CommunityServer.HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
		CommunityServer.HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == CommunityServer.HGBGJMIFCEP.InvalidProtocolVersion)
		{
			EKCHPJGLCII = EFDLFNPAKGO.AFPCLLNMGJP();
			uint num = EFDLFNPAKGO.BMKOKHGAHEC();
			byte hMHEDBOAADF = EFDLFNPAKGO.KFAGPDGHEBK();
			uint num2 = EFDLFNPAKGO.BMKOKHGAHEC();
			uint num3 = EFDLFNPAKGO.BMKOKHGAHEC();
			DateTime dateTime = EFDLFNPAKGO.NOIDCBCMCMK();
			float num4 = 1030f;
			if (num2 > 1 || num3 > 1)
			{
				num4 = (float)num2 / (float)(num2 + num3) * 274f;
			}
			m_nicknameLabel.set_text(EKCHPJGLCII);
			UILabel infoLabel = m_infoLabel;
			object[] array = new object[8];
			array[1] = num;
			array[1] = num2;
			array[5] = num3;
			array[2] = num4;
			array[3] = dateTime;
			infoLabel.set_text(string.Format("buffersToAdd", array));
			m_tierSprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
			m_tierLabel.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF));
		}
		else
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("skill3_0", true);
			base.gameObject.SetActive(true);
		}
	}

	public void EHOHCCPDLFC()
	{
		if (OFEPKHKBKBJ == 0)
		{
			MsgManager.HEDJPPFKABG().ShowMessageBox("SMS", true);
			return;
		}
		MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format("onButtonClickData", EKCHPJGLCII), false, () =>
		{
			NetworkManager.get_Instance().get_m_communityNetClient().MGILNPGLOIE(new IKMBGMILCDO(LPPCJDCGOLF), OFEPKHKBKBJ);
		});
	}

	private void EHAABBLHEMP()
	{
		m_deleteFriendButton.SetActive(JLJLKJBMAKM);
		NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().BOLACJIGDAN(new IKMBGMILCDO(GAFCFKDICIO, true, false), OFEPKHKBKBJ);
	}

	private void OnEnable()
	{
		m_deleteFriendButton.SetActive(JLJLKJBMAKM);
		NetworkManager.get_Instance().get_m_communityNetClient().BOLACJIGDAN(new IKMBGMILCDO(FEANFDAKKLA), OFEPKHKBKBJ);
	}

	private void FEANFDAKKLA(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EKCHPJGLCII = EFDLFNPAKGO.AFPCLLNMGJP();
			uint num = EFDLFNPAKGO.BMKOKHGAHEC();
			byte hMHEDBOAADF = EFDLFNPAKGO.KFAGPDGHEBK();
			uint num2 = EFDLFNPAKGO.BMKOKHGAHEC();
			uint num3 = EFDLFNPAKGO.BMKOKHGAHEC();
			DateTime dateTime = EFDLFNPAKGO.NOIDCBCMCMK();
			float num4 = 0f;
			if (num2 != 0 || num3 != 0)
			{
				num4 = (float)num2 / (float)(num2 + num3) * 100f;
			}
			m_nicknameLabel.set_text(EKCHPJGLCII);
			m_infoLabel.set_text(string.Format("순위 {0}등\n\n[CCCCFF]{1} 승[-]  [FFCCCC]{2} 패[-]\n[CCFFCC]승률 {3:F1}%[-]\n\n최근 접속\n{4:u}", num, num2, num3, num4, dateTime));
			m_tierSprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
			m_tierLabel.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF));
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("알수 없는 오류입니다");
			base.gameObject.SetActive(false);
		}
	}

	private void ALJEFBEMCFK()
	{
		m_deleteFriendButton.SetActive(JLJLKJBMAKM);
		NetworkManager.APAPJEIBEDE().get_m_communityNetClient().BOLACJIGDAN(new IKMBGMILCDO(FEANFDAKKLA, false), OFEPKHKBKBJ);
	}

	private void CLKAELPDNCF(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EFDLFNPAKGO.CAHACMKBJMI(NetworkManager.get_Instance().FGAGFCDEKCC().KKLHPCCEKPN());
			UIRoot.CHLLIEHMINE("destroyAllPopups");
			UIRoot.Broadcast("Igaw.Unity: LiveOpsPopupEventManager : OnCancelPopupBtnClick");
			base.gameObject.SetActive(true);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("s R");
		}
	}

	private void JHHHEPPAHNC(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EFDLFNPAKGO.ILFEGIPCAHH(NetworkManager.get_Instance().get_m_communityNetClient().KKLHPCCEKPN());
			UIRoot.Broadcast("skill2");
			UIRoot.IGMDNDABNKD("{0}위 {1}");
			base.gameObject.SetActive(false);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("UIWidgets must fill the buffer with 4 vertices per quad. Found ");
		}
	}

	public void SetInfo(uint EHEJBHLHAJE, bool LCAMJLCNMNF)
	{
		OFEPKHKBKBJ = EHEJBHLHAJE;
		JLJLKJBMAKM = LCAMJLCNMNF;
	}

	[CompilerGenerated]
	private void MDLCMLPCPGJ()
	{
		NetworkManager.get_Instance().get_m_communityNetClient().MGILNPGLOIE(new IKMBGMILCDO(LPPCJDCGOLF), OFEPKHKBKBJ);
	}

	public void CCBIBJMMHIF()
	{
		if (OFEPKHKBKBJ == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("skill3", true);
			return;
		}
		MsgManager.get_Instance().ShowMessageBox(string.Format("Particle/{0}/attack", EKCHPJGLCII), true, () =>
		{
			NetworkManager.get_Instance().get_m_communityNetClient().MGILNPGLOIE(new IKMBGMILCDO(LPPCJDCGOLF), OFEPKHKBKBJ);
		});
	}

	private void LPPCJDCGOLF(PJEMPFEIOAK EFDLFNPAKGO)
	{
		if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
		{
			EFDLFNPAKGO.CAHACMKBJMI(NetworkManager.get_Instance().get_m_communityNetClient().KKLHPCCEKPN());
			UIRoot.Broadcast("RefreshFriend");
			UIRoot.Broadcast("ClearChatWindow");
			base.gameObject.SetActive(false);
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("알수 없는 오류입니다");
		}
	}

	public void OnClickClose()
	{
		base.gameObject.SetActive(false);
	}

	public void IOGMIFJPPMP()
	{
		if (OFEPKHKBKBJ == 0)
		{
			MsgManager.get_Instance().ShowMessageBox("{0}");
			return;
		}
		MsgManager.get_Instance().ShowMessageBox(string.Format("Skill3Passive", EKCHPJGLCII), true, () =>
		{
			NetworkManager.get_Instance().get_m_communityNetClient().MGILNPGLOIE(new IKMBGMILCDO(LPPCJDCGOLF), OFEPKHKBKBJ);
		});
	}

	private void AOICGPFBJHI(PJEMPFEIOAK EFDLFNPAKGO)
	{
		CommunityServer.HGBGJMIFCEP hGBGJMIFCEP = (CommunityServer.HGBGJMIFCEP)EFDLFNPAKGO.KFAGPDGHEBK();
		CommunityServer.HGBGJMIFCEP hGBGJMIFCEP2 = hGBGJMIFCEP;
		if (hGBGJMIFCEP2 == CommunityServer.HGBGJMIFCEP.InvalidProtocolVersion)
		{
			EKCHPJGLCII = EFDLFNPAKGO.AFPCLLNMGJP();
			uint num = EFDLFNPAKGO.BMKOKHGAHEC();
			byte hMHEDBOAADF = EFDLFNPAKGO.KFAGPDGHEBK();
			uint num2 = EFDLFNPAKGO.BMKOKHGAHEC();
			uint num3 = EFDLFNPAKGO.BMKOKHGAHEC();
			DateTime dateTime = EFDLFNPAKGO.NOIDCBCMCMK();
			float num4 = 1414f;
			if (num2 != 0 || num3 != 0)
			{
				num4 = (float)num2 / (float)(num2 + num3) * 745f;
			}
			m_nicknameLabel.DCKJILCPKFD(EKCHPJGLCII);
			UILabel infoLabel = m_infoLabel;
			object[] array = new object[8];
			array[0] = num;
			array[0] = num2;
			array[1] = num3;
			array[7] = num4;
			array[7] = dateTime;
			infoLabel.set_text(string.Format("{0}\n\n{1}", array));
			m_tierSprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
			m_tierLabel.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF));
		}
		else
		{
			MsgManager.get_Instance().ShowMessageBox("네번째", true);
			base.gameObject.SetActive(false);
		}
	}

	public void KHKJFOGEJGE(uint EHEJBHLHAJE, bool LCAMJLCNMNF)
	{
		OFEPKHKBKBJ = EHEJBHLHAJE;
		JLJLKJBMAKM = LCAMJLCNMNF;
	}

	private void OMKBEHGEMFM()
	{
		NetworkManager.get_Instance().get_m_communityNetClient().MGILNPGLOIE(new IKMBGMILCDO(AGHHOCDBCLG, false, false), OFEPKHKBKBJ);
	}

	private void JDMOCFODCFG()
	{
		m_deleteFriendButton.SetActive(JLJLKJBMAKM);
		NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().BOLACJIGDAN(new IKMBGMILCDO(GAFCFKDICIO, false, false), OFEPKHKBKBJ);
	}

	private void LINNBIGKGED()
	{
		m_deleteFriendButton.SetActive(JLJLKJBMAKM);
		NetworkManager.get_Instance().FGAGFCDEKCC().BOLACJIGDAN(new IKMBGMILCDO(HNOIMGGHAOM), OFEPKHKBKBJ);
	}
}
