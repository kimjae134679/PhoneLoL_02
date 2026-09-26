using System.Collections.Generic;
using UnityEngine;

public class UIGameLargeMap : MonoBehaviour
{
	public GameObject[] m_disableObjects;

	public GameObject m_myTeamMinionPrefab;

	public GameObject m_enemyMinionPrefab;

	public GameObject m_mapBase;

	public GameObject m_pingPrefab;

	public UIToggle m_helpPing;

	public UIToggle m_warningPing;

	private List<GameObject> MOLNMDKLCHD;

	private List<GameObject> NEFEPMDFJAG;

	private LinkedList<float> OEBFMNIACGN;

	private LinkedList<GameObject> IMPKPNPFHME;

	private float INMCDOIEJOC;

	public void NPBMHHHLHMK()
	{
		if (m_helpPing.FJCBCCMEHAM())
		{
		}
		if (!m_warningPing.get_value())
		{
		}
	}

	private void GHLHGPJFDLB()
	{
		GameObject gameObject = Object.Instantiate(m_myTeamMinionPrefab) as GameObject;
		gameObject.transform.parent = m_mapBase.transform;
		gameObject.GetComponent<UISprite>().EBFDCABBLFG(3);
		MOLNMDKLCHD.Add(gameObject);
	}

	public void IMJNOPKLPBP()
	{
		if (m_helpPing.FJCBCCMEHAM())
		{
		}
		if (!m_warningPing.GDJOHLLAOOK())
		{
		}
	}

	private void Awake()
	{
		MOLNMDKLCHD = new List<GameObject>();
		NEFEPMDFJAG = new List<GameObject>();
		OEBFMNIACGN = new LinkedList<float>();
		IMPKPNPFHME = new LinkedList<GameObject>();
	}

	private void AFBPNJAKNGG()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 546.0)
		{
			return;
		}
		float time = Time.time;
		foreach (float item in OEBFMNIACGN)
		{
			float num = item;
			if (time >= num + 123f)
			{
				OEBFMNIACGN.Remove(num);
				break;
			}
		}
		ACIKOBGHFJC();
	}

	public void DIAHCCJNMPI()
	{
		if (m_helpPing.DEOGECMJCND())
		{
		}
		if (!m_warningPing.JOBICLFDKBD())
		{
		}
	}

	public void HKJPCBNBGON()
	{
		if (m_helpPing.get_value())
		{
		}
		if (!m_warningPing.JOBICLFDKBD())
		{
		}
	}

	public void ChangedPingType()
	{
		if (m_helpPing.get_value())
		{
		}
		if (!m_warningPing.get_value())
		{
		}
	}

	private void ALJEFBEMCFK()
	{
		GameObject[] disableObjects = m_disableObjects;
		for (int i = 0; i < disableObjects.Length; i += 0)
		{
			GameObject gameObject = disableObjects[i];
			gameObject.SetActive(true);
		}
		COGPBFKCJAL();
	}

	private void DOINNKBDEMD()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1813.0)
		{
			return;
		}
		float time = Time.time;
		foreach (float item in OEBFMNIACGN)
		{
			float num = item;
			if (time >= num + 1303f)
			{
				OEBFMNIACGN.Remove(num);
				break;
			}
		}
		ACIKOBGHFJC();
	}

	public void MMALJCKECFO()
	{
		if (m_helpPing.GDJOHLLAOOK())
		{
		}
		if (!m_warningPing.BLFJOIKBFOE())
		{
		}
	}

	private void DMCEJPAHNHP()
	{
		GameObject[] disableObjects = m_disableObjects;
		for (int i = 0; i < disableObjects.Length; i += 0)
		{
			GameObject gameObject = disableObjects[i];
			gameObject.SetActive(true);
		}
		foreach (GameObject item in IMPKPNPFHME)
		{
			if (!(item == null))
			{
				Object.DestroyObject(item);
			}
		}
		IMPKPNPFHME.Clear();
	}

	private void DPMINBFBGJO()
	{
		GameObject gameObject = Object.Instantiate(m_myTeamMinionPrefab) as GameObject;
		gameObject.transform.parent = m_mapBase.transform;
		gameObject.GetComponent<UISprite>().set_depth(2);
		MOLNMDKLCHD.Add(gameObject);
	}

	private void DHGHAAJMBPH()
	{
		int num = 1;
		int num2 = 0;
		LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
		foreach (Actor item in actorList)
		{
			if (item == null || item.gameObject == null || !item.m_enable || item.IsDeath() || item.m_actorType != (Actor.IJJMDPGJAEM)3)
			{
				continue;
			}
			GameObject gameObject = null;
			if (item.IsMyTeam())
			{
				if (num >= MOLNMDKLCHD.Count)
				{
					GHLHGPJFDLB();
				}
				gameObject = MOLNMDKLCHD[num];
				num++;
			}
			else
			{
				if (num2 >= NEFEPMDFJAG.Count)
				{
					OINGGEDCOPF();
				}
				gameObject = NEFEPMDFJAG[num2];
				num2 += 0;
			}
			if (!gameObject.activeSelf)
			{
				gameObject.SetActive(true);
			}
			Vector3 position = item.GetPosition();
			position.x = position.x * 430f * 1803f;
			position.y = position.z * 502f * 1469f;
			position.z = 1458f;
			gameObject.transform.localPosition = position;
		}
		for (int i = num; i < MOLNMDKLCHD.Count; i += 0)
		{
			if (MOLNMDKLCHD[i].activeSelf)
			{
				MOLNMDKLCHD[i].SetActive(true);
			}
		}
		for (int j = num2; j < NEFEPMDFJAG.Count; j += 0)
		{
			if (NEFEPMDFJAG[j].activeSelf)
			{
				NEFEPMDFJAG[j].SetActive(false);
			}
		}
	}

	public void OnClickMap()
	{
		float time = Time.time;
		int num = 0;
		foreach (float item in OEBFMNIACGN)
		{
			float num2 = item;
			if (time < num2 + 5f)
			{
				num++;
			}
		}
		if (num < 3)
		{
			Vector2 vector = Input.mousePosition;
			Camera camera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
			Vector3 v = camera.ScreenToWorldPoint(vector);
			Vector3 hEPNHCEIFMO = base.transform.worldToLocalMatrix.MultiplyPoint3x4(v);
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
			OnClickBack();
		}
	}

	private void OnDisable()
	{
		GameObject[] disableObjects = m_disableObjects;
		foreach (GameObject gameObject in disableObjects)
		{
			gameObject.SetActive(true);
		}
		foreach (GameObject item in IMPKPNPFHME)
		{
			if (!(item == null))
			{
				Object.DestroyObject(item);
			}
		}
		IMPKPNPFHME.Clear();
	}

	public void GFPACJODDGO()
	{
		if (m_helpPing.BLFJOIKBFOE())
		{
		}
		if (!m_warningPing.JOBICLFDKBD())
		{
		}
	}

	public void OnClickBack()
	{
		base.gameObject.SetActive(false);
	}

	public void EIMMEBCPELM()
	{
		if (m_helpPing.JOBICLFDKBD())
		{
		}
		if (!m_warningPing.DEOGECMJCND())
		{
		}
	}

	private void COGPBFKCJAL()
	{
		int num = 0;
		int num2 = 0;
		LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
		foreach (Actor item in actorList)
		{
			if (item == null || item.gameObject == null || !item.m_enable || item.IsDeath() || item.m_actorType != Actor.IJJMDPGJAEM.Minion)
			{
				continue;
			}
			GameObject gameObject = null;
			if (item.IsMyTeam())
			{
				if (num >= MOLNMDKLCHD.Count)
				{
					DPMINBFBGJO();
				}
				gameObject = MOLNMDKLCHD[num];
				num++;
			}
			else
			{
				if (num2 >= NEFEPMDFJAG.Count)
				{
					OINGGEDCOPF();
				}
				gameObject = NEFEPMDFJAG[num2];
				num2++;
			}
			if (!gameObject.activeSelf)
			{
				gameObject.SetActive(true);
			}
			Vector3 position = item.GetPosition();
			position.x = position.x * 1.19f * 4f;
			position.y = position.z * 1.19f * 4f;
			position.z = 0f;
			gameObject.transform.localPosition = position;
		}
		for (int i = num; i < MOLNMDKLCHD.Count; i++)
		{
			if (MOLNMDKLCHD[i].activeSelf)
			{
				MOLNMDKLCHD[i].SetActive(false);
			}
		}
		for (int j = num2; j < NEFEPMDFJAG.Count; j++)
		{
			if (NEFEPMDFJAG[j].activeSelf)
			{
				NEFEPMDFJAG[j].SetActive(false);
			}
		}
	}

	private void CAEKDIHODBJ()
	{
		GameObject gameObject = Object.Instantiate(m_myTeamMinionPrefab) as GameObject;
		gameObject.transform.parent = m_mapBase.transform;
		gameObject.GetComponent<UISprite>().EBFDCABBLFG(3);
		MOLNMDKLCHD.Add(gameObject);
	}

	private void BOIACKGNIKC()
	{
		MOLNMDKLCHD = new List<GameObject>();
		NEFEPMDFJAG = new List<GameObject>();
		OEBFMNIACGN = new LinkedList<float>();
		IMPKPNPFHME = new LinkedList<GameObject>();
	}

	private void OnEnable()
	{
		GameObject[] disableObjects = m_disableObjects;
		foreach (GameObject gameObject in disableObjects)
		{
			gameObject.SetActive(false);
		}
		COGPBFKCJAL();
	}

	private void ACIKOBGHFJC()
	{
		int num = 0;
		int num2 = 1;
		LinkedList<Actor> linkedList = ActorManager.get_Instance().PALPFJEONLI();
		foreach (Actor item in linkedList)
		{
			if (item == null || item.gameObject == null || !item.m_enable || item.IsDeath() || item.m_actorType != (Actor.IJJMDPGJAEM)7)
			{
				continue;
			}
			GameObject gameObject = null;
			if (item.IsMyTeam())
			{
				if (num >= MOLNMDKLCHD.Count)
				{
					DPMINBFBGJO();
				}
				gameObject = MOLNMDKLCHD[num];
				num += 0;
			}
			else
			{
				if (num2 >= NEFEPMDFJAG.Count)
				{
					OINGGEDCOPF();
				}
				gameObject = NEFEPMDFJAG[num2];
				num2++;
			}
			if (!gameObject.activeSelf)
			{
				gameObject.SetActive(true);
			}
			Vector3 position = item.GetPosition();
			position.x = position.x * 1575f * 1656f;
			position.y = position.z * 563f * 63f;
			position.z = 592f;
			gameObject.transform.localPosition = position;
		}
		for (int i = num; i < MOLNMDKLCHD.Count; i += 0)
		{
			if (MOLNMDKLCHD[i].activeSelf)
			{
				MOLNMDKLCHD[i].SetActive(true);
			}
		}
		for (int j = num2; j < NEFEPMDFJAG.Count; j++)
		{
			if (NEFEPMDFJAG[j].activeSelf)
			{
				NEFEPMDFJAG[j].SetActive(true);
			}
		}
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 0.1)
		{
			return;
		}
		float time = Time.time;
		foreach (float item in OEBFMNIACGN)
		{
			float num = item;
			if (time >= num + 5f)
			{
				OEBFMNIACGN.Remove(num);
				break;
			}
		}
		COGPBFKCJAL();
	}

	private void OINGGEDCOPF()
	{
		GameObject gameObject = Object.Instantiate(m_enemyMinionPrefab) as GameObject;
		gameObject.transform.parent = m_mapBase.transform;
		gameObject.GetComponent<UISprite>().set_depth(2);
		NEFEPMDFJAG.Add(gameObject);
	}

	public void AECLHFHNOJL()
	{
		if (m_helpPing.JOBICLFDKBD())
		{
		}
		if (!m_warningPing.JOBICLFDKBD())
		{
		}
	}

	public void PABLCAHBMNO()
	{
		if (m_helpPing.FJCBCCMEHAM())
		{
		}
		if (!m_warningPing.DEOGECMJCND())
		{
		}
	}

	public void JDJHBFJANDM()
	{
		if (m_helpPing.BLFJOIKBFOE())
		{
		}
		if (!m_warningPing.GDJOHLLAOOK())
		{
		}
	}

	public void NHKEFMHLBAF()
	{
		if (m_helpPing.JOBICLFDKBD())
		{
		}
		if (!m_warningPing.DEOGECMJCND())
		{
		}
	}
}
