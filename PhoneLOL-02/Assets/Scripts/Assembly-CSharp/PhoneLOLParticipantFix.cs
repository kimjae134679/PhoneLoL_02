using System;
using System.Reflection;
using BattleServer;
using EveEngine;

public static class PhoneLOLParticipantFix
{
	public static bool MoveParticipant(GLAMMOFPCHP room, PBOOPPEPAIK player, byte target)
	{
		if (room == null || player == null || target >= room.IFOLDPBLAGD() || target >= room.FMCMCKANEBC().Count)
		{
			return false;
		}
		NOBFFGBGCNA nOBFFGBGCNA = room.FBNKGOOJPBB(player.OHGOBGOIECH);
		if (nOBFFGBGCNA == null || nOBFFGBGCNA.CJENLAELLAO() == null)
		{
			return false;
		}
		byte b = nOBFFGBGCNA.COKFPAODPCF();
		if (b >= room.IFOLDPBLAGD() || b >= room.FMCMCKANEBC().Count)
		{
			return false;
		}
		if (b == target)
		{
			player.ABNABOGNJPI(target);
			nOBFFGBGCNA.CJENLAELLAO().ABNABOGNJPI(target);
			return true;
		}
		NOBFFGBGCNA nOBFFGBGCNA2 = room.FBNKGOOJPBB(target);
		if (b % 2 == target % 2 || nOBFFGBGCNA2 == null || !nOBFFGBGCNA2.MNHIDGANMFO())
		{
			return false;
		}
		room.FMCMCKANEBC()[target] = nOBFFGBGCNA;
		room.FMCMCKANEBC()[b] = nOBFFGBGCNA2;
		typeof(NOBFFGBGCNA).GetProperty("CCHCPBANHJN").SetValue(nOBFFGBGCNA, target, null);
		typeof(NOBFFGBGCNA).GetProperty("CCHCPBANHJN").SetValue(nOBFFGBGCNA2, b, null);
		player.ABNABOGNJPI(target);
		nOBFFGBGCNA.CJENLAELLAO().ABNABOGNJPI(target);
		if (room.EBEGKANNPHB() == b)
		{
			typeof(GLAMMOFPCHP).GetProperty("PLPAACMHLJK").SetValue(room, target, null);
		}
		return true;
	}

	public static void CopyProfile(PBOOPPEPAIK source, PBOOPPEPAIK target)
	{
		if (source != null && target != null && source != target && source.OHGOBGOIECH == target.OHGOBGOIECH)
		{
			target.ABNABOGNJPI(source.GDMBDKBCNBD());
		}
	}

	public static void SynchronizeSnapshot(PBOOPPEPAIK incoming)
	{
		CopyProfile(incoming, NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA());
	}

	public static bool ApplyTeamMove(GLAMMOFPCHP room, PBOOPPEPAIK player, byte target)
	{
		bool num = MoveParticipant(room, player, target);
		if (num)
		{
			UIRoot.Broadcast("Refresh");
		}
		return num;
	}

	public static void ReceiveRoleOrTeamMove(PNDMCOBIODO client, PJEMPFEIOAK reader)
	{
		if (client == null || reader == null || client.IMKOGBNIJBO() == null)
		{
			return;
		}
		uint num = reader.BMKOKHGAHEC();
		byte b = reader.KFAGPDGHEBK();
		NOBFFGBGCNA nOBFFGBGCNA = client.IMKOGBNIJBO().FBNKGOOJPBB(num);
		if (nOBFFGBGCNA == null || nOBFFGBGCNA.MNHIDGANMFO())
		{
			return;
		}
		PBOOPPEPAIK pBOOPPEPAIK = nOBFFGBGCNA.CJENLAELLAO();
		PBOOPPEPAIK pBOOPPEPAIK2 = client.GLPDLIDMHFA();
		if (b >= 128 && b <= 133)
		{
			if (!MoveParticipant(client.IMKOGBNIJBO(), pBOOPPEPAIK, (byte)(b - 128)))
			{
				return;
			}
			if (pBOOPPEPAIK2 != null && pBOOPPEPAIK2.OHGOBGOIECH == num)
			{
				pBOOPPEPAIK2.ABNABOGNJPI((byte)(b - 128));
			}
		}
		else
		{
			if (b > 3)
			{
				return;
			}
			pBOOPPEPAIK.MHELCCFGKKG(b);
			if (pBOOPPEPAIK2 != null && pBOOPPEPAIK2.OHGOBGOIECH == num)
			{
				pBOOPPEPAIK2.MHELCCFGKKG(b);
			}
		}
		UIRoot.Broadcast("Refresh");
	}

	public static string MatchDuration(int seconds)
	{
		seconds = Math.Max(0, seconds);
		return string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);
	}

	public static void CompleteResult(UIMultiGameResult panel)
	{
		int seconds = (int)(float)GameManager.get_Instance().get_m_elapsedTime();
		panel.m_prizeLabel.set_text("경기 시간 " + MatchDuration(seconds));
		panel.m_prize2Label.set_text("경기 보상: 미지급");
		panel.m_timeLabel.set_text(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
		typeof(UIMultiGameResult).GetField("FDCFGPJALMN", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(panel, false);
		typeof(UIMultiGameResult).GetField("AFFMNKJGDBJ", BindingFlags.Instance | BindingFlags.NonPublic).SetValue(panel, true);
	}
}
