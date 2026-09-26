using System.Collections.Generic;
using BattleServer;
using EveEngine;
using GameServer;
using UnityEngine;

internal static class V093CompatibilityFix
{
	private static bool m_runeLoadInProgress;

	internal static bool ApplyTeamMove(GLAMMOFPCHP room, BattleServer.PBOOPPEPAIK player, byte target)
	{
		return PhoneLOLParticipantFix.ApplyTeamMove(room, player, target);
	}

	internal static int FindOppositeTeamSlot(PNDMCOBIODO client)
	{
		if (client == null || client.IMKOGBNIJBO() == null || client.IMKOGBNIJBO().OOHFDEPKKFN() != BattleServer.OCPEALOGAIP.OEOIIKMBGAG.Ready)
		{
			return -1;
		}
		if (client != null)
		{
			GLAMMOFPCHP gLAMMOFPCHP = client.IMKOGBNIJBO();
			BattleServer.PBOOPPEPAIK pBOOPPEPAIK = client.GLPDLIDMHFA();
			if (gLAMMOFPCHP != null && pBOOPPEPAIK != null)
			{
				int num = pBOOPPEPAIK.GDMBDKBCNBD();
				if ((uint)num < (uint)gLAMMOFPCHP.IFOLDPBLAGD())
				{
					for (int i = (num + 1) % 2; i < gLAMMOFPCHP.IFOLDPBLAGD(); i += 2)
					{
						if (gLAMMOFPCHP.FBNKGOOJPBB((byte)i).MNHIDGANMFO())
						{
							return i;
						}
					}
				}
			}
		}
		return -1;
	}

	internal static void RequestTeamMove(UILobbyBattleReady panel)
	{
		PNDMCOBIODO battleNetClient = NetworkManager.get_Instance().get_m_battleNetClient();
		int num = FindOppositeTeamSlot(battleNetClient);
		if (num >= 0)
		{
			if (battleNetClient.GLPDLIDMHFA().HHIEBIMNHPL())
			{
				battleNetClient.DFPELPCDPGK();
			}
			var packet = CMNIABEFLBJ.PEFJOMFAOJI();
			packet.DGFDHOLDCDL(61001);
			packet.GBMJNFOEACC((byte)num);
			battleNetClient.FBAFKOCPFPG(packet);
		}
	}

	internal static void ConfigureTeamButton(UILobbyBattleReady panel)
	{
		if ((object)panel != null && (object)panel.m_autoEnterButton != null && (object)panel.m_readyButton != null)
		{
			panel.m_autoEnterButton.gameObject.SetActive(true);
			Vector3 localPosition = panel.m_readyButton.transform.localPosition;
			localPosition.x -= 145f;
			panel.m_autoEnterButton.transform.localPosition = localPosition;
			panel.m_autoEnterButton.transform.localScale = panel.m_readyButton.transform.localScale;
			UILabel uILabel = panel.m_autoEnterButton.GetComponentInChildren(typeof(UILabel)) as UILabel;
			if ((object)uILabel != null)
			{
				uILabel.set_text("팀 이동");
			}
		}
	}

	internal static void UpdateTeamButton(UILobbyBattleReady panel)
	{
		if ((object)panel != null && (object)panel.m_autoEnterButton != null && (object)panel.m_readyButton != null)
		{
			panel.m_readyButton.gameObject.SetActive(true);
			panel.m_autoEnterButton.gameObject.SetActive(true);
			PNDMCOBIODO battleNetClient = NetworkManager.get_Instance().get_m_battleNetClient();
			panel.m_autoEnterButton.set_isEnabled(FindOppositeTeamSlot(battleNetClient) > -1);
		}
	}

	internal static bool IsRuneLayoutReady(CEDBCGHKKLK container)
	{
		if (container != null)
		{
			List<CDAEKMFPFCH> mLNHFHFKOFM = container.MLNHFHFKOFM;
			if (mLNHFHFKOFM != null && mLNHFHFKOFM.Count >= 2)
			{
				CDAEKMFPFCH cDAEKMFPFCH = mLNHFHFKOFM[0];
				if (cDAEKMFPFCH != null && cDAEKMFPFCH.DFMEJOGADLG != null && cDAEKMFPFCH.DFMEJOGADLG.Count >= 30)
				{
					cDAEKMFPFCH = mLNHFHFKOFM[1];
					if (cDAEKMFPFCH != null && cDAEKMFPFCH.DFMEJOGADLG != null && cDAEKMFPFCH.DFMEJOGADLG.Count >= 30)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	internal static void BeginRuneLoad()
	{
		m_runeLoadInProgress = true;
	}

	internal static void SaveRuneLoadout(CEDBCGHKKLK container)
	{
		if (!m_runeLoadInProgress && IsRuneLayoutReady(container))
		{
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.0", container.MLNHFHFKOFM[0].DFMEJOGADLG[0].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.1", container.MLNHFHFKOFM[0].DFMEJOGADLG[1].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.2", container.MLNHFHFKOFM[0].DFMEJOGADLG[2].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.3", container.MLNHFHFKOFM[0].DFMEJOGADLG[3].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.4", container.MLNHFHFKOFM[0].DFMEJOGADLG[4].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.5", container.MLNHFHFKOFM[0].DFMEJOGADLG[5].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.6", container.MLNHFHFKOFM[0].DFMEJOGADLG[6].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.7", container.MLNHFHFKOFM[0].DFMEJOGADLG[7].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.8", container.MLNHFHFKOFM[0].DFMEJOGADLG[8].IKHBHNCPDLB);
			PlayerPrefs.SetInt("BATTLE INIT: HOST PATH", container.MLNHFHFKOFM[0].DFMEJOGADLG[9].IKHBHNCPDLB);
			PlayerPrefs.SetInt("START: TRIGGER NOT SEEN", container.MLNHFHFKOFM[0].DFMEJOGADLG[10].IKHBHNCPDLB);
			PlayerPrefs.SetInt("BATTLE INIT: GUEST WAIT", container.MLNHFHFKOFM[0].DFMEJOGADLG[11].IKHBHNCPDLB);
			PlayerPrefs.SetInt("attempt=1              ", container.MLNHFHFKOFM[0].DFMEJOGADLG[12].IKHBHNCPDLB);
			PlayerPrefs.SetInt("ready=1                ", container.MLNHFHFKOFM[0].DFMEJOGADLG[13].IKHBHNCPDLB);
			PlayerPrefs.SetInt("room=0                 ", container.MLNHFHFKOFM[0].DFMEJOGADLG[14].IKHBHNCPDLB);
			PlayerPrefs.SetInt("fail=0                 ", container.MLNHFHFKOFM[0].DFMEJOGADLG[15].IKHBHNCPDLB);
			PlayerPrefs.SetInt("role=1                 ", container.MLNHFHFKOFM[0].DFMEJOGADLG[16].IKHBHNCPDLB);
			PlayerPrefs.SetInt("role=2                 ", container.MLNHFHFKOFM[0].DFMEJOGADLG[17].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.18", container.MLNHFHFKOFM[0].DFMEJOGADLG[18].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.19", container.MLNHFHFKOFM[0].DFMEJOGADLG[19].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.20", container.MLNHFHFKOFM[0].DFMEJOGADLG[20].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.21", container.MLNHFHFKOFM[0].DFMEJOGADLG[21].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.22", container.MLNHFHFKOFM[0].DFMEJOGADLG[22].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.23", container.MLNHFHFKOFM[0].DFMEJOGADLG[23].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.24", container.MLNHFHFKOFM[0].DFMEJOGADLG[24].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.25", container.MLNHFHFKOFM[0].DFMEJOGADLG[25].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.26", container.MLNHFHFKOFM[0].DFMEJOGADLG[26].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.27", container.MLNHFHFKOFM[0].DFMEJOGADLG[27].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.28", container.MLNHFHFKOFM[0].DFMEJOGADLG[28].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.0.29", container.MLNHFHFKOFM[0].DFMEJOGADLG[29].IKHBHNCPDLB);
			PlayerPrefs.SetInt("ROOM MOVE: STATE SEEN ", container.MLNHFHFKOFM[1].DFMEJOGADLG[0].IKHBHNCPDLB);
			PlayerPrefs.SetInt("PhoneLOL 1.15.7 TRACE ", container.MLNHFHFKOFM[1].DFMEJOGADLG[1].IKHBHNCPDLB);
			PlayerPrefs.SetInt("RECONNECT: LOOP/WARN  ", container.MLNHFHFKOFM[1].DFMEJOGADLG[2].IKHBHNCPDLB);
			PlayerPrefs.SetInt("AUTH: CENTRAL SERVER  ", container.MLNHFHFKOFM[1].DFMEJOGADLG[3].IKHBHNCPDLB);
			PlayerPrefs.SetInt("START PATH: WAITING   ", container.MLNHFHFKOFM[1].DFMEJOGADLG[4].IKHBHNCPDLB);
			PlayerPrefs.SetInt("START PATH: SYNC OK   ", container.MLNHFHFKOFM[1].DFMEJOGADLG[5].IKHBHNCPDLB);
			PlayerPrefs.SetInt("START PATH: STALLED   ", container.MLNHFHFKOFM[1].DFMEJOGADLG[6].IKHBHNCPDLB);
			PlayerPrefs.SetInt("RECONNECT: NONE       ", container.MLNHFHFKOFM[1].DFMEJOGADLG[7].IKHBHNCPDLB);
			PlayerPrefs.SetInt("RECONNECT: OK         ", container.MLNHFHFKOFM[1].DFMEJOGADLG[8].IKHBHNCPDLB);
			PlayerPrefs.SetInt("attempt=0             ", container.MLNHFHFKOFM[1].DFMEJOGADLG[9].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.10", container.MLNHFHFKOFM[1].DFMEJOGADLG[10].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.11", container.MLNHFHFKOFM[1].DFMEJOGADLG[11].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.12", container.MLNHFHFKOFM[1].DFMEJOGADLG[12].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.13", container.MLNHFHFKOFM[1].DFMEJOGADLG[13].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.14", container.MLNHFHFKOFM[1].DFMEJOGADLG[14].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.15", container.MLNHFHFKOFM[1].DFMEJOGADLG[15].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.16", container.MLNHFHFKOFM[1].DFMEJOGADLG[16].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.17", container.MLNHFHFKOFM[1].DFMEJOGADLG[17].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.18", container.MLNHFHFKOFM[1].DFMEJOGADLG[18].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.19", container.MLNHFHFKOFM[1].DFMEJOGADLG[19].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.20", container.MLNHFHFKOFM[1].DFMEJOGADLG[20].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.21", container.MLNHFHFKOFM[1].DFMEJOGADLG[21].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.22", container.MLNHFHFKOFM[1].DFMEJOGADLG[22].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.23", container.MLNHFHFKOFM[1].DFMEJOGADLG[23].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.24", container.MLNHFHFKOFM[1].DFMEJOGADLG[24].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.25", container.MLNHFHFKOFM[1].DFMEJOGADLG[25].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.26", container.MLNHFHFKOFM[1].DFMEJOGADLG[26].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.27", container.MLNHFHFKOFM[1].DFMEJOGADLG[27].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.28", container.MLNHFHFKOFM[1].DFMEJOGADLG[28].IKHBHNCPDLB);
			PlayerPrefs.SetInt("MultiGod.v093.rune.1.29", container.MLNHFHFKOFM[1].DFMEJOGADLG[29].IKHBHNCPDLB);
			PlayerPrefs.SetInt("ROOM: JOINED / WAIT READY", 1);
			PlayerPrefs.Save();
		}
	}

	internal static void RestoreRuneLoadout(CEDBCGHKKLK container)
	{
		m_runeLoadInProgress = false;
		SaveRuneLoadout(container);
	}

	internal static void SaveCurrentRuneLoadout()
	{
		NetworkManager instance = NetworkManager.get_Instance();
		if ((object)instance != null)
		{
			OPOPGDNFGCF gameNetClient = instance.get_m_gameNetClient();
			if (gameNetClient != null)
			{
				SaveRuneLoadout(gameNetClient.DAGCAFAEABC());
			}
		}
	}

	internal static void SaveBattleRunePage(int page)
	{
		if (page >= 0 && page <= 1)
		{
			PlayerPrefs.SetInt("MultiGod.v093.battleRunePage", page);
			PlayerPrefs.Save();
		}
	}

	internal static void RestoreBattleRunePage(UILobbyBattleReady panel)
	{
		if ((object)panel != null)
		{
			if (PlayerPrefs.GetInt("MultiGod.v093.battleRunePage", 0) == 1)
			{
				panel.OnClickRunePage2();
			}
			else
			{
				panel.OnClickRunePage1();
			}
		}
	}

	internal static void ReceiveRoleOrTeamMove(PNDMCOBIODO client, PJEMPFEIOAK reader)
	{
		PhoneLOLParticipantFix.ReceiveRoleOrTeamMove(client, reader);
	}
}
