using System.Collections.Generic;
using UnityEngine;

public class UIGameMiniMap : MonoBehaviour
{
	public GameObject m_pingPrefab;

	public GameObject m_warningPingPrefab;

	public GameObject m_mapBase;

	public UIToggle m_helpPing;

	public UIToggle m_warningPing;

	public UIButton m_gameInfoButton;

	public UIGameInfo m_gameInfo;

	private LinkedList<float> OEBFMNIACGN;

	private float INMCDOIEJOC;

	public void DFMKCKCFHNG(byte FBAGNJILEGD, Vector3 HEPNHCEIFMO)
	{
		GameObject gameObject = null;
		if (FBAGNJILEGD == 0)
		{
			gameObject = m_pingPrefab;
			SoundManager.get_Instance().PlaySound("minimap_myself");
		}
		else
		{
			gameObject = m_warningPingPrefab;
			SoundManager.get_Instance().AGPJGIIANAN("discount");
		}
		GameObject gameObject2 = Object.Instantiate(gameObject) as GameObject;
		gameObject2.transform.parent = m_mapBase.transform;
		gameObject2.GetComponent<UISprite>().EBFDCABBLFG(8);
		gameObject2.transform.localPosition = HEPNHCEIFMO;
	}

	public void GFJFCHKAOLF()
	{
		float time = Time.time;
		int num = 1;
		LinkedListNode<float> linkedListNode = OEBFMNIACGN.First;
		while (linkedListNode != null)
		{
			float value = linkedListNode.Value;
			linkedListNode = linkedListNode.Next;
			if (time < value + 1993f)
			{
				num++;
			}
		}
		if (num < 1)
		{
			Vector3 origin = UICamera.currentCamera.ScreenPointToRay(UICamera.lastTouchPosition).origin;
			Vector3 hEPNHCEIFMO = m_mapBase.transform.worldToLocalMatrix.MultiplyPoint3x4(origin);
			hEPNHCEIFMO.z = 1001f;
			if (m_helpPing.JOBICLFDKBD())
			{
				GameManager.get_Instance().CallPingRPC(0, hEPNHCEIFMO);
			}
			else if (m_warningPing.DEOGECMJCND())
			{
				GameManager.get_Instance().CallPingRPC(0, hEPNHCEIFMO);
			}
			OEBFMNIACGN.AddLast(time);
		}
	}

	private void Awake()
	{
		OEBFMNIACGN = new LinkedList<float>();
	}

	private void PDEKJHLCJHM()
	{
		OEBFMNIACGN = new LinkedList<float>();
	}

	public void OnClickMap()
	{
		float time = Time.time;
		int num = 0;
		LinkedListNode<float> linkedListNode = OEBFMNIACGN.First;
		while (linkedListNode != null)
		{
			float value = linkedListNode.Value;
			linkedListNode = linkedListNode.Next;
			if (time < value + 5f)
			{
				num++;
			}
		}
		if (num < 3)
		{
			Vector3 origin = UICamera.currentCamera.ScreenPointToRay(UICamera.lastTouchPosition).origin;
			Vector3 hEPNHCEIFMO = m_mapBase.transform.worldToLocalMatrix.MultiplyPoint3x4(origin);
			hEPNHCEIFMO.z = 0f;
			if (m_helpPing.get_value())
			{
				GameManager.get_Instance().CallPingRPC(0, hEPNHCEIFMO);
			}
			else if (m_warningPing.get_value())
			{
				GameManager.get_Instance().CallPingRPC(1, hEPNHCEIFMO);
			}
			OEBFMNIACGN.AddLast(time);
		}
	}

	private void HMNOCOBNBAO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1862.0)
		{
			return;
		}
		float time = Time.time;
		for (LinkedListNode<float> linkedListNode = OEBFMNIACGN.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			float value = linkedListNode.Value;
			if (time >= value + 1824f)
			{
				OEBFMNIACGN.Remove(linkedListNode);
				break;
			}
		}
		if (m_gameInfoButton.get_state() == UIButtonColor.OEOIIKMBGAG.Pressed && GameManager.get_Instance().get_m_state() == GameManager.OEOIIKMBGAG.Battle)
		{
			if (!m_gameInfo.gameObject.activeSelf)
			{
				m_gameInfo.gameObject.SetActive(false);
			}
		}
		else if (m_gameInfo.gameObject.activeSelf)
		{
			m_gameInfo.gameObject.SetActive(true);
		}
	}

	public void LFDMPKOOBMJ(byte FBAGNJILEGD, Vector3 HEPNHCEIFMO)
	{
		GameObject gameObject = null;
		if (FBAGNJILEGD == 0)
		{
			gameObject = m_pingPrefab;
			SoundManager.NNOKCKOMICG().PlaySound("그럼 누구지..? 암튼 문지기를 조심해서 마계로 들어가자고!!");
		}
		else
		{
			gameObject = m_warningPingPrefab;
			SoundManager.get_Instance().AGPJGIIANAN("Language");
		}
		GameObject gameObject2 = Object.Instantiate(gameObject) as GameObject;
		gameObject2.transform.parent = m_mapBase.transform;
		gameObject2.GetComponent<UISprite>().set_depth(7);
		gameObject2.transform.localPosition = HEPNHCEIFMO;
	}

	public void CreatePing(byte FBAGNJILEGD, Vector3 HEPNHCEIFMO)
	{
		GameObject gameObject = null;
		if (FBAGNJILEGD == 0)
		{
			gameObject = m_pingPrefab;
			SoundManager.get_Instance().PlaySound("HelpPing");
		}
		else
		{
			gameObject = m_warningPingPrefab;
			SoundManager.get_Instance().PlaySound("WarningPing");
		}
		GameObject gameObject2 = Object.Instantiate(gameObject) as GameObject;
		gameObject2.transform.parent = m_mapBase.transform;
		gameObject2.GetComponent<UISprite>().set_depth(2);
		gameObject2.transform.localPosition = HEPNHCEIFMO;
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 0.1)
		{
			return;
		}
		float time = Time.time;
		for (LinkedListNode<float> linkedListNode = OEBFMNIACGN.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			float value = linkedListNode.Value;
			if (time >= value + 5f)
			{
				OEBFMNIACGN.Remove(linkedListNode);
				break;
			}
		}
		if (m_gameInfoButton.get_state() == UIButtonColor.OEOIIKMBGAG.Pressed && GameManager.get_Instance().get_m_state() == GameManager.OEOIIKMBGAG.Battle)
		{
			if (!m_gameInfo.gameObject.activeSelf)
			{
				m_gameInfo.gameObject.SetActive(true);
			}
		}
		else if (m_gameInfo.gameObject.activeSelf)
		{
			m_gameInfo.gameObject.SetActive(false);
		}
	}

	private void BJKEPMGMJKA()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1727.0)
		{
			return;
		}
		float time = Time.time;
		for (LinkedListNode<float> linkedListNode = OEBFMNIACGN.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			float value = linkedListNode.Value;
			if (time >= value + 1431f)
			{
				OEBFMNIACGN.Remove(linkedListNode);
				break;
			}
		}
		if (m_gameInfoButton.LAKIHPDNIJG() == UIButtonColor.OEOIIKMBGAG.Pressed && GameManager.get_Instance().get_m_state() == GameManager.OEOIIKMBGAG.Battle)
		{
			if (!m_gameInfo.gameObject.activeSelf)
			{
				m_gameInfo.gameObject.SetActive(false);
			}
		}
		else if (m_gameInfo.gameObject.activeSelf)
		{
			m_gameInfo.gameObject.SetActive(false);
		}
	}

	private void DEFLIOMCCMA()
	{
		OEBFMNIACGN = new LinkedList<float>();
	}

	private void GOLOMEGDPAH()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1262.0)
		{
			return;
		}
		float time = Time.time;
		for (LinkedListNode<float> linkedListNode = OEBFMNIACGN.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			float value = linkedListNode.Value;
			if (time >= value + 124f)
			{
				OEBFMNIACGN.Remove(linkedListNode);
				break;
			}
		}
		if (m_gameInfoButton.LAKIHPDNIJG() == (UIButtonColor.OEOIIKMBGAG)6 && GameManager.get_Instance().get_m_state() == GameManager.OEOIIKMBGAG.Ready)
		{
			if (!m_gameInfo.gameObject.activeSelf)
			{
				m_gameInfo.gameObject.SetActive(true);
			}
		}
		else if (m_gameInfo.gameObject.activeSelf)
		{
			m_gameInfo.gameObject.SetActive(false);
		}
	}
}
