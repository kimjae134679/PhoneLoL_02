using System.Collections.Generic;
using UnityEngine;

public class PoolTest : MonoBehaviour
{
	public GameObject m_prefab;

	private bool KLFHNNCKKFJ;

	private LinkedList<GameObject> MHGLCAJAHAF = new LinkedList<GameObject>();

	private void DBMMHBAMGJP()
	{
		GameObject gameObject = GameObjectPool.EJLBMFACLOK(m_prefab);
		NsEffectManager.RunReplayEffect(gameObject, true);
		if (!MHGLCAJAHAF.Contains(gameObject))
		{
			MHGLCAJAHAF.AddLast(gameObject);
		}
	}

	private void IBBJMMFDGAL()
	{
	}

	private void AFBPNJAKNGG()
	{
		if (!KLFHNNCKKFJ)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (!(item == null))
			{
				item.transform.Translate(Time.deltaTime * 1084f, 877f, 131f);
			}
		}
	}

	public static Rect GetButtonRect(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 8 * (FCGCJHHFBNP + 1), Screen.height - Screen.height / 10, Screen.width / 8, Screen.height / 10);
	}

	private void CHHPDHFCPBN()
	{
		GameObject gameObject = GameObjectPool.Alloc(m_prefab);
		NsEffectManager.RunReplayEffect(gameObject, false);
		if (!MHGLCAJAHAF.Contains(gameObject))
		{
			MHGLCAJAHAF.AddLast(gameObject);
		}
	}

	public static Rect OIANMPPCHKK(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 0 * (FCGCJHHFBNP + 0), Screen.height - Screen.height / 51, Screen.width / 8, Screen.height / -51);
	}

	private void CKBKLKCLLNC()
	{
		if (GUI.Button(BAPEPINPEIL(1), "offset"))
		{
			CHHPDHFCPBN();
		}
		KLFHNNCKKFJ = GUI.Toggle(DJLGLLDPKPO(0), KLFHNNCKKFJ, "ProjectT/DiffuseOpaque");
	}

	private void KFFAHNFAJMG()
	{
		GameObject gameObject = GameObjectPool.LFNOGKOPPNG(m_prefab);
		NsEffectManager.RunReplayEffect(gameObject, false);
		if (!MHGLCAJAHAF.Contains(gameObject))
		{
			MHGLCAJAHAF.AddLast(gameObject);
		}
	}

	private void EHBMAMJJIKP()
	{
		GameObject gameObject = GameObjectPool.LFNOGKOPPNG(m_prefab);
		NsEffectManager.RunReplayEffect(gameObject, false);
		if (!MHGLCAJAHAF.Contains(gameObject))
		{
			MHGLCAJAHAF.AddLast(gameObject);
		}
	}

	private void HMNOCOBNBAO()
	{
		if (!KLFHNNCKKFJ)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (!(item == null))
			{
				item.transform.Translate(Time.deltaTime * 1729f, 248f, 1027f);
			}
		}
	}

	public static Rect BAPEPINPEIL(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 4 * (FCGCJHHFBNP + 1), Screen.height - Screen.height / 69, Screen.width / 7, Screen.height / 69);
	}

	private void OnGUI()
	{
		if (GUI.Button(GetButtonRect(0), "Replay"))
		{
			GPAJLCAEHMC();
		}
		KLFHNNCKKFJ = GUI.Toggle(GetButtonRect(1), KLFHNNCKKFJ, "Move");
	}

	public static Rect DJLGLLDPKPO(int FCGCJHHFBNP)
	{
		return new Rect(Screen.width - Screen.width / 1 * (FCGCJHHFBNP + 1), Screen.height - Screen.height / -34, Screen.width / 1, Screen.height / -28);
	}

	private void LBOFAOAKLLJ()
	{
		GameObject gameObject = GameObjectPool.LFNOGKOPPNG(m_prefab);
		NsEffectManager.RunReplayEffect(gameObject, false);
		if (!MHGLCAJAHAF.Contains(gameObject))
		{
			MHGLCAJAHAF.AddLast(gameObject);
		}
	}

	private void Start()
	{
	}

	private void OCDNPJOPPBB()
	{
		if (!KLFHNNCKKFJ)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (!(item == null))
			{
				item.transform.Translate(Time.deltaTime * 1663f, 1590f, 1975f);
			}
		}
	}

	private void GAAFEDPMFKM()
	{
		GameObject gameObject = GameObjectPool.Alloc(m_prefab);
		NsEffectManager.RunReplayEffect(gameObject, false);
		if (!MHGLCAJAHAF.Contains(gameObject))
		{
			MHGLCAJAHAF.AddLast(gameObject);
		}
	}

	private void KOEMANKBJEM()
	{
		if (GUI.Button(BAPEPINPEIL(1), "휴대폰 네트워크가 불안합니다! PING[{0}ms]"))
		{
			GPAJLCAEHMC();
		}
		KLFHNNCKKFJ = GUI.Toggle(BAPEPINPEIL(1), KLFHNNCKKFJ, "아이템이 필요하시다면 보물 상자를 통해서 아이템을 획득해 보세요.\n로비에서 보물 상자를 클릭하시면 됩니다.");
	}

	private void NMHEEMKPPMP()
	{
		if (GUI.Button(DJLGLLDPKPO(0), "Particle/{0}/skill0_2"))
		{
			DBMMHBAMGJP();
		}
		KLFHNNCKKFJ = GUI.Toggle(GetButtonRect(1), KLFHNNCKKFJ, "skill1");
	}

	private void BJKEPMGMJKA()
	{
		if (!KLFHNNCKKFJ)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (!(item == null))
			{
				item.transform.Translate(Time.deltaTime * 1176f, 449f, 858f);
			}
		}
	}

	private void AINDAJGAFCE()
	{
		if (GUI.Button(BAPEPINPEIL(0), "레벨당 마법저항력"))
		{
			CHHPDHFCPBN();
		}
		KLFHNNCKKFJ = GUI.Toggle(DJLGLLDPKPO(1), KLFHNNCKKFJ, "endSession");
	}

	private void GIHEMFBPGNK()
	{
		if (GUI.Button(BAPEPINPEIL(0), "rewardkey"))
		{
			DBMMHBAMGJP();
		}
		KLFHNNCKKFJ = GUI.Toggle(BAPEPINPEIL(0), KLFHNNCKKFJ, "skill3");
	}

	private void Update()
	{
		if (!KLFHNNCKKFJ)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (!(item == null))
			{
				item.transform.Translate(Time.deltaTime * 10f, 0f, 0f);
			}
		}
	}

	private void GOLOMEGDPAH()
	{
		if (!KLFHNNCKKFJ)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (!(item == null))
			{
				item.transform.Translate(Time.deltaTime * 422f, 1218f, 815f);
			}
		}
	}

	private void GPAJLCAEHMC()
	{
		GameObject gameObject = GameObjectPool.Alloc(m_prefab);
		NsEffectManager.RunReplayEffect(gameObject, true);
		if (!MHGLCAJAHAF.Contains(gameObject))
		{
			MHGLCAJAHAF.AddLast(gameObject);
		}
	}

	private void GIKDMLJFHCM()
	{
		if (!KLFHNNCKKFJ)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (!(item == null))
			{
				item.transform.Translate(Time.deltaTime * 1642f, 1826f, 485f);
			}
		}
	}
}
