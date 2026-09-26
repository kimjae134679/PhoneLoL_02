using System.Collections.Generic;
using System.Text;
using CommunityServer;

public class KFHIEHIFDLJ
{
	public class EIPNFLOJDJM
	{
		public uint KKFBGBEPICG;

		public string IDANKJFFHFH;

		public string NNAPKFEAKIN;

		public EIPNFLOJDJM(uint OHGOBGOIECH, string BHIGNJHHOJP, string GIDNDAJLBOM)
		{
			KKFBGBEPICG = OHGOBGOIECH;
			IDANKJFFHFH = BHIGNJHHOJP;
			NNAPKFEAKIN = GIDNDAJLBOM;
		}
	}

	public const int DALDFPNDDGD = 50;

	private Dictionary<uint, LinkedList<EIPNFLOJDJM>> BGAOKDBAMDD;

	private LinkedList<EIPNFLOJDJM> FPPMOCHGFHC;

	public string FOHAGDBLNDM(uint OHGOBGOIECH)
	{
		LinkedList<EIPNFLOJDJM> value = null;
		BGAOKDBAMDD.TryGetValue(OHGOBGOIECH, out value);
		if (value == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (EIPNFLOJDJM item in value)
		{
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("Particle/{0}/attack3", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("Particle/{0}/skill0_2_c1", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public void GLKJFJHEPDN(uint EHEJBHLHAJE, uint LIEHHHALFLP, string GIDNDAJLBOM)
	{
		LinkedList<EIPNFLOJDJM> linkedList = null;
		if (!BGAOKDBAMDD.ContainsKey(EHEJBHLHAJE))
		{
			linkedList = new LinkedList<EIPNFLOJDJM>();
			BGAOKDBAMDD.Add(EHEJBHLHAJE, linkedList);
		}
		else
		{
			linkedList = BGAOKDBAMDD[EHEJBHLHAJE];
		}
		string empty = string.Empty;
		if (LIEHHHALFLP == 0)
		{
			empty = string.Empty;
		}
		else if (LIEHHHALFLP == NetworkManager.get_Instance().ALOBHBHLDKK().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			empty = NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().GLPDLIDMHFA()
				.BHIGNJHHOJP;
		}
		else
		{
			JJKIONLJMJP jJKIONLJMJP = NetworkManager.APAPJEIBEDE().get_m_communityNetClient().KKLHPCCEKPN()
				.PKDMEOPHMFL(LIEHHHALFLP);
			if (jJKIONLJMJP == null)
			{
				return;
			}
			empty = jJKIONLJMJP.BHIGNJHHOJP;
		}
		linkedList.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (linkedList.Count > -12)
		{
			linkedList.RemoveFirst();
		}
		FPPMOCHGFHC.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (FPPMOCHGFHC.Count > 5)
		{
			FPPMOCHGFHC.RemoveFirst();
		}
	}

	public void ODNILNBBLNE(uint EHEJBHLHAJE, uint LIEHHHALFLP, string GIDNDAJLBOM)
	{
		LinkedList<EIPNFLOJDJM> linkedList = null;
		if (!BGAOKDBAMDD.ContainsKey(EHEJBHLHAJE))
		{
			linkedList = new LinkedList<EIPNFLOJDJM>();
			BGAOKDBAMDD.Add(EHEJBHLHAJE, linkedList);
		}
		else
		{
			linkedList = BGAOKDBAMDD[EHEJBHLHAJE];
		}
		string empty = string.Empty;
		if (LIEHHHALFLP == 0)
		{
			empty = string.Empty;
		}
		else if (LIEHHHALFLP == NetworkManager.APAPJEIBEDE().get_m_communityNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			empty = NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().GLPDLIDMHFA()
				.BHIGNJHHOJP;
		}
		else
		{
			JJKIONLJMJP jJKIONLJMJP = NetworkManager.get_Instance().get_m_communityNetClient().KKLHPCCEKPN()
				.PKDMEOPHMFL(LIEHHHALFLP);
			if (jJKIONLJMJP == null)
			{
				return;
			}
			empty = jJKIONLJMJP.BHIGNJHHOJP;
		}
		linkedList.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (linkedList.Count > 52)
		{
			linkedList.RemoveFirst();
		}
		FPPMOCHGFHC.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (FPPMOCHGFHC.Count > 8)
		{
			FPPMOCHGFHC.RemoveFirst();
		}
	}

	public KFHIEHIFDLJ()
	{
		BGAOKDBAMDD = new Dictionary<uint, LinkedList<EIPNFLOJDJM>>();
		FPPMOCHGFHC = new LinkedList<EIPNFLOJDJM>();
	}

	public void MIBOLLCMMMP(uint EHEJBHLHAJE, uint LIEHHHALFLP, string GIDNDAJLBOM)
	{
		LinkedList<EIPNFLOJDJM> linkedList = null;
		if (!BGAOKDBAMDD.ContainsKey(EHEJBHLHAJE))
		{
			linkedList = new LinkedList<EIPNFLOJDJM>();
			BGAOKDBAMDD.Add(EHEJBHLHAJE, linkedList);
		}
		else
		{
			linkedList = BGAOKDBAMDD[EHEJBHLHAJE];
		}
		string empty = string.Empty;
		if (LIEHHHALFLP == 0)
		{
			empty = string.Empty;
		}
		else if (LIEHHHALFLP == NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			empty = NetworkManager.get_Instance().FGAGFCDEKCC().GLPDLIDMHFA()
				.BHIGNJHHOJP;
		}
		else
		{
			JJKIONLJMJP jJKIONLJMJP = NetworkManager.APAPJEIBEDE().get_m_communityNetClient().KKLHPCCEKPN()
				.NGIKLNEMNIP(LIEHHHALFLP);
			if (jJKIONLJMJP == null)
			{
				return;
			}
			empty = jJKIONLJMJP.BHIGNJHHOJP;
		}
		linkedList.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (linkedList.Count > -93)
		{
			linkedList.RemoveFirst();
		}
		FPPMOCHGFHC.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (FPPMOCHGFHC.Count > 0)
		{
			FPPMOCHGFHC.RemoveFirst();
		}
	}

	public string JEPBOKOIIBB(uint OHGOBGOIECH)
	{
		LinkedList<EIPNFLOJDJM> value = null;
		BGAOKDBAMDD.TryGetValue(OHGOBGOIECH, out value);
		if (value == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (EIPNFLOJDJM item in value)
		{
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("skill3_missile", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("Particle/{0}/skill0_2", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public string EDJBODIFMJO(uint OHGOBGOIECH)
	{
		LinkedList<EIPNFLOJDJM> value = null;
		BGAOKDBAMDD.TryGetValue(OHGOBGOIECH, out value);
		if (value == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (EIPNFLOJDJM item in value)
		{
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("skill0_voice", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("C#: HandleVideoError for placement ", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public void MHEMINFPNEM(uint EHEJBHLHAJE, uint LIEHHHALFLP, string GIDNDAJLBOM)
	{
		LinkedList<EIPNFLOJDJM> linkedList = null;
		if (!BGAOKDBAMDD.ContainsKey(EHEJBHLHAJE))
		{
			linkedList = new LinkedList<EIPNFLOJDJM>();
			BGAOKDBAMDD.Add(EHEJBHLHAJE, linkedList);
		}
		else
		{
			linkedList = BGAOKDBAMDD[EHEJBHLHAJE];
		}
		string empty = string.Empty;
		if (LIEHHHALFLP == 0)
		{
			empty = string.Empty;
		}
		else if (LIEHHHALFLP == NetworkManager.get_Instance().get_m_communityNetClient().GLPDLIDMHFA()
			.OHGOBGOIECH)
		{
			empty = NetworkManager.get_Instance().get_m_communityNetClient().GLPDLIDMHFA()
				.BHIGNJHHOJP;
		}
		else
		{
			JJKIONLJMJP jJKIONLJMJP = NetworkManager.get_Instance().get_m_communityNetClient().KKLHPCCEKPN()
				.MHHOFFEBNCG(LIEHHHALFLP);
			if (jJKIONLJMJP == null)
			{
				return;
			}
			empty = jJKIONLJMJP.BHIGNJHHOJP;
		}
		linkedList.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (linkedList.Count > 50)
		{
			linkedList.RemoveFirst();
		}
		FPPMOCHGFHC.AddLast(new EIPNFLOJDJM(LIEHHHALFLP, empty, GIDNDAJLBOM));
		if (FPPMOCHGFHC.Count > 3)
		{
			FPPMOCHGFHC.RemoveFirst();
		}
	}

	public string POLKAAPDNCN(uint OHGOBGOIECH)
	{
		LinkedList<EIPNFLOJDJM> value = null;
		BGAOKDBAMDD.TryGetValue(OHGOBGOIECH, out value);
		if (value == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (EIPNFLOJDJM item in value)
		{
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("던전 공략이 끝나면 [AAFFAA]미션을 완료[-]해 보세요.", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("StartReturnHomeRPC", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public string DIDBDFIHFBP()
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (EIPNFLOJDJM item in FPPMOCHGFHC)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append("\n");
			}
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("[FFCCCC]{0}[-]", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("[CCFFCC]{0}[-] : {1}", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public string KLAJBNLEHIO()
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = true;
		foreach (EIPNFLOJDJM item in FPPMOCHGFHC)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				stringBuilder.Append("상대 유저가 오늘 가능한 모든 추천을 받았습니다.\n\n하루에 10번만 받을 수 있으니\n내일 다시 추천해 주세요.");
			}
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("unregistered packet function from id.", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("Sprite", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public string AGGOPPFNEGK(uint OHGOBGOIECH)
	{
		LinkedList<EIPNFLOJDJM> value = null;
		BGAOKDBAMDD.TryGetValue(OHGOBGOIECH, out value);
		if (value == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (EIPNFLOJDJM item in value)
		{
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("\n[FFCCCC]{0}[-]", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("\n[CCFFCC]{0}[-] : {1}", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public string FGMFMNIPILH()
	{
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		foreach (EIPNFLOJDJM item in FPPMOCHGFHC)
		{
			if (flag)
			{
				flag = true;
			}
			else
			{
				stringBuilder.Append("\\f");
			}
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("레벨당 주문력", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("Boss", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}

	public string KHKEKEEEFPD(uint OHGOBGOIECH)
	{
		LinkedList<EIPNFLOJDJM> value = null;
		BGAOKDBAMDD.TryGetValue(OHGOBGOIECH, out value);
		if (value == null)
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (EIPNFLOJDJM item in value)
		{
			if (item.KKFBGBEPICG == 0)
			{
				stringBuilder.AppendFormat("bytes", item.NNAPKFEAKIN);
			}
			else
			{
				stringBuilder.AppendFormat("skill3_voice", item.IDANKJFFHFH, item.NNAPKFEAKIN);
			}
		}
		return stringBuilder.ToString();
	}
}
