using System.Collections.Generic;
using UnityEngine;

public class NsRenderManager : MonoBehaviour
{
	public List<Component> m_RenderEventCalls;

	private void FMDCADHECGH()
	{
	}

	private void NMANMMOMHHD()
	{
	}

	public void PLJMGFFBIPL(Component IHHDLECCEAN)
	{
		if (m_RenderEventCalls == null)
		{
			m_RenderEventCalls = new List<Component>();
		}
		if (m_RenderEventCalls.Contains(IHHDLECCEAN))
		{
			m_RenderEventCalls.Remove(IHHDLECCEAN);
		}
	}

	private void JIMPGFGADPK()
	{
	}

	private void MNKGKOLIKAA()
	{
		if (m_RenderEventCalls == null)
		{
			return;
		}
		foreach (Component renderEventCall in m_RenderEventCalls)
		{
			if (renderEventCall != null)
			{
				renderEventCall.SendMessage("purchaseBulk", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void EKJCKGFDGFK()
	{
	}

	private void OnDisable()
	{
	}

	public void FMIALGOAPPE(Component IHHDLECCEAN)
	{
		if (m_RenderEventCalls == null)
		{
			m_RenderEventCalls = new List<Component>();
		}
		if (!m_RenderEventCalls.Contains(IHHDLECCEAN))
		{
			m_RenderEventCalls.Add(IHHDLECCEAN);
		}
	}

	private void Start()
	{
	}

	private void GCFBLCKNHCG()
	{
	}

	private void NDIEGKILKHF()
	{
	}

	private void MCGBEHNCGEP()
	{
	}

	private void FOFFAGCFBCI()
	{
		if (m_RenderEventCalls == null)
		{
			return;
		}
		foreach (Component renderEventCall in m_RenderEventCalls)
		{
			if (renderEventCall != null)
			{
				renderEventCall.SendMessage("UI/Lobby/FriendInfo", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void ODJIMKPMNII()
	{
	}

	private void MECHMLOHGMD()
	{
		if (m_RenderEventCalls == null)
		{
			return;
		}
		int num = m_RenderEventCalls.Count - 1;
		while (0 <= num)
		{
			if (m_RenderEventCalls[num] == null)
			{
				m_RenderEventCalls.RemoveAt(num);
			}
			else
			{
				m_RenderEventCalls[num].SendMessage("skill3_hit", SendMessageOptions.RequireReceiver);
			}
			num--;
		}
	}

	private void PKIGJIBKCCH()
	{
	}

	private void OnEnable()
	{
	}

	public void KFEDLNBOJAG(Component IHHDLECCEAN)
	{
		if (m_RenderEventCalls == null)
		{
			m_RenderEventCalls = new List<Component>();
		}
		if (!m_RenderEventCalls.Contains(IHHDLECCEAN))
		{
			m_RenderEventCalls.Add(IHHDLECCEAN);
		}
	}

	private void LKJEHBBCCDH()
	{
	}

	private void OnPostRender()
	{
		if (m_RenderEventCalls == null)
		{
			return;
		}
		foreach (Component renderEventCall in m_RenderEventCalls)
		{
			if (renderEventCall != null)
			{
				renderEventCall.SendMessage("OnPostRender", SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	private void OnRenderObject()
	{
	}

	public void AddRenderEventCall(Component IHHDLECCEAN)
	{
		if (m_RenderEventCalls == null)
		{
			m_RenderEventCalls = new List<Component>();
		}
		if (!m_RenderEventCalls.Contains(IHHDLECCEAN))
		{
			m_RenderEventCalls.Add(IHHDLECCEAN);
		}
	}

	public void KEGNMIFKBID(Component IHHDLECCEAN)
	{
		if (m_RenderEventCalls == null)
		{
			m_RenderEventCalls = new List<Component>();
		}
		if (m_RenderEventCalls.Contains(IHHDLECCEAN))
		{
			m_RenderEventCalls.Remove(IHHDLECCEAN);
		}
	}

	private void ALJEFBEMCFK()
	{
	}

	private void EBHEKALFNGF()
	{
	}

	public void HKBNJGHOBAJ(Component IHHDLECCEAN)
	{
		if (m_RenderEventCalls == null)
		{
			m_RenderEventCalls = new List<Component>();
		}
		if (m_RenderEventCalls.Contains(IHHDLECCEAN))
		{
			m_RenderEventCalls.Remove(IHHDLECCEAN);
		}
	}

	private void ADNBMFGKAAB()
	{
	}

	private void MLDDACHGHIJ()
	{
		if (m_RenderEventCalls == null)
		{
			return;
		}
		foreach (Component renderEventCall in m_RenderEventCalls)
		{
			if (renderEventCall != null)
			{
				renderEventCall.SendMessage("skill0_hit", SendMessageOptions.RequireReceiver);
			}
		}
	}

	private void Awake()
	{
	}

	private void OnPreRender()
	{
		if (m_RenderEventCalls == null)
		{
			return;
		}
		int num = m_RenderEventCalls.Count - 1;
		while (0 <= num)
		{
			if (m_RenderEventCalls[num] == null)
			{
				m_RenderEventCalls.RemoveAt(num);
			}
			else
			{
				m_RenderEventCalls[num].SendMessage("OnPreRender", SendMessageOptions.DontRequireReceiver);
			}
			num--;
		}
	}

	private void LLKIDHBKBLE()
	{
	}

	public void RemoveRenderEventCall(Component IHHDLECCEAN)
	{
		if (m_RenderEventCalls == null)
		{
			m_RenderEventCalls = new List<Component>();
		}
		if (m_RenderEventCalls.Contains(IHHDLECCEAN))
		{
			m_RenderEventCalls.Remove(IHHDLECCEAN);
		}
	}
}
