using CommunityServer;
using UnityEngine;

public class UILobbyGuild : MonoBehaviour
{
	public GameObject[] m_windows;

	public UILobbyModifyGuildMember m_modifyGuildMemberPanel;

	public UIToggle m_guildInfoTab;

	public UIToggle m_joinGuildTab;

	public UIToggle m_createGuildTab;

	public void LCLGDGMEPJK()
	{
		if (m_guildInfoTab.BLFJOIKBFOE())
		{
			m_windows[0].SetActive(true);
			m_windows[0].SetActive(false);
			m_windows[4].SetActive(true);
		}
		else if (m_joinGuildTab.DEOGECMJCND())
		{
			m_windows[0].SetActive(true);
			m_windows[0].SetActive(true);
			m_windows[0].SetActive(true);
		}
		else if (m_createGuildTab.FJCBCCMEHAM())
		{
			m_windows[1].SetActive(false);
			m_windows[0].SetActive(true);
			m_windows[0].SetActive(true);
		}
	}

	private void JCOAPDFPKPP(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.GMDKOKNGLAK(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(false);
		}
	}

	private void KIGKNPJLKBP(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.SetInfo(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(false);
		}
	}

	public void PIENFLIEOLJ()
	{
		if (m_guildInfoTab.DEOGECMJCND())
		{
			m_windows[1].SetActive(true);
			m_windows[1].SetActive(false);
			m_windows[8].SetActive(true);
		}
		else if (m_joinGuildTab.FJCBCCMEHAM())
		{
			m_windows[0].SetActive(false);
			m_windows[1].SetActive(true);
			m_windows[2].SetActive(false);
		}
		else if (m_createGuildTab.DEOGECMJCND())
		{
			m_windows[0].SetActive(true);
			m_windows[0].SetActive(false);
			m_windows[5].SetActive(false);
		}
	}

	private void KPOCBMHPMOO(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.SetInfo(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(true);
		}
	}

	public void ELJHAPKLLLJ()
	{
		if (m_guildInfoTab.GDJOHLLAOOK())
		{
			m_windows[1].SetActive(true);
			m_windows[0].SetActive(false);
			m_windows[5].SetActive(true);
		}
		else if (m_joinGuildTab.JOBICLFDKBD())
		{
			m_windows[0].SetActive(false);
			m_windows[0].SetActive(true);
			m_windows[4].SetActive(true);
		}
		else if (m_createGuildTab.DEOGECMJCND())
		{
			m_windows[1].SetActive(false);
			m_windows[0].SetActive(false);
			m_windows[7].SetActive(false);
		}
	}

	private void MADCDCNEGBO()
	{
	}

	private void BHBOKLKMBPN(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.SetInfo(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(false);
		}
	}

	private void ModifyGuildMemberPanel(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.SetInfo(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(true);
		}
	}

	private void BOGIJEIDBEH(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.IEPMMBBMGCJ(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(true);
		}
	}

	private void OnEnable()
	{
	}

	public void AMLLAEDKPDN()
	{
		if (m_guildInfoTab.GDJOHLLAOOK())
		{
			m_windows[1].SetActive(true);
			m_windows[1].SetActive(true);
			m_windows[3].SetActive(true);
		}
		else if (m_joinGuildTab.get_value())
		{
			m_windows[0].SetActive(false);
			m_windows[1].SetActive(false);
			m_windows[0].SetActive(true);
		}
		else if (m_createGuildTab.FJCBCCMEHAM())
		{
			m_windows[0].SetActive(false);
			m_windows[0].SetActive(false);
			m_windows[4].SetActive(true);
		}
	}

	public void EAMFKBIFDEC()
	{
		if (m_guildInfoTab.DEOGECMJCND())
		{
			m_windows[1].SetActive(false);
			m_windows[0].SetActive(false);
			m_windows[8].SetActive(false);
		}
		else if (m_joinGuildTab.JOBICLFDKBD())
		{
			m_windows[0].SetActive(true);
			m_windows[0].SetActive(false);
			m_windows[8].SetActive(true);
		}
		else if (m_createGuildTab.GDJOHLLAOOK())
		{
			m_windows[0].SetActive(true);
			m_windows[1].SetActive(false);
			m_windows[6].SetActive(false);
		}
	}

	private void KJBGEJOMPJJ()
	{
	}

	private void JDMOCFODCFG()
	{
	}

	private void EGLJJFMFHBG()
	{
	}

	public void OnChangeTab()
	{
		if (m_guildInfoTab.get_value())
		{
			m_windows[0].SetActive(true);
			m_windows[1].SetActive(false);
			m_windows[2].SetActive(false);
		}
		else if (m_joinGuildTab.get_value())
		{
			m_windows[0].SetActive(false);
			m_windows[1].SetActive(true);
			m_windows[2].SetActive(false);
		}
		else if (m_createGuildTab.get_value())
		{
			m_windows[0].SetActive(false);
			m_windows[1].SetActive(false);
			m_windows[2].SetActive(true);
		}
	}

	private void CFEIPPFANKJ()
	{
	}

	private void EENOBEBHOOL(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.GMDKOKNGLAK(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(true);
		}
	}

	public void DNFBNJAIPGC()
	{
		if (m_guildInfoTab.BLFJOIKBFOE())
		{
			m_windows[0].SetActive(true);
			m_windows[1].SetActive(true);
			m_windows[4].SetActive(false);
		}
		else if (m_joinGuildTab.DEOGECMJCND())
		{
			m_windows[0].SetActive(true);
			m_windows[0].SetActive(false);
			m_windows[8].SetActive(false);
		}
		else if (m_createGuildTab.BLFJOIKBFOE())
		{
			m_windows[1].SetActive(false);
			m_windows[0].SetActive(true);
			m_windows[1].SetActive(false);
		}
	}

	private void PNPGBNKGOIB(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.GMDKOKNGLAK(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(true);
		}
	}

	private void CEKIBLDLEFJ(object param)
	{
		FCKLFFEFEFH fCKLFFEFEFH = (FCKLFFEFEFH)param;
		if (fCKLFFEFEFH != null)
		{
			m_modifyGuildMemberPanel.IEPMMBBMGCJ(fCKLFFEFEFH);
			m_modifyGuildMemberPanel.gameObject.SetActive(true);
		}
	}

	public void FCMAIJIKHII()
	{
		if (m_guildInfoTab.GDJOHLLAOOK())
		{
			m_windows[0].SetActive(true);
			m_windows[1].SetActive(true);
			m_windows[6].SetActive(false);
		}
		else if (m_joinGuildTab.FJCBCCMEHAM())
		{
			m_windows[0].SetActive(false);
			m_windows[0].SetActive(true);
			m_windows[7].SetActive(false);
		}
		else if (m_createGuildTab.GDJOHLLAOOK())
		{
			m_windows[1].SetActive(false);
			m_windows[1].SetActive(true);
			m_windows[4].SetActive(true);
		}
	}
}
