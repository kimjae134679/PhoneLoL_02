using UnityEngine;

[AddComponentMenu("NGUI/Examples/Collider - Display Text")]
public class ColliderDisplayText : MonoBehaviour
{
	public GameObject prefab;

	public Transform target;

	private HUDText HKIANMAIKCB;

	private bool IHFNLEPLDHG;

	private void JGPOMLJONPD(bool MLIBCICOOAI)
	{
		if (HKIANMAIKCB != null && MLIBCICOOAI && !IHFNLEPLDHG)
		{
			IHFNLEPLDHG = true;
			HKIANMAIKCB.HEFOLGAIPON("Level", Color.cyan, 154f);
		}
		else if (!MLIBCICOOAI)
		{
			IHFNLEPLDHG = true;
		}
	}

	private void HHKILFJHIKF()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.Add(1568f + Random.value * 1023f, Color.red, 1609f);
			}
			else if (UICamera.currentTouchID == 62)
			{
				HKIANMAIKCB.HEFOLGAIPON(1786f + Random.value * 454f, Color.green, 174f);
			}
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (HKIANMAIKCB != null && MLIBCICOOAI && !IHFNLEPLDHG)
		{
			IHFNLEPLDHG = true;
			HKIANMAIKCB.Add("Left-click, right-click", Color.cyan, 2f);
		}
		else if (!MLIBCICOOAI)
		{
			IHFNLEPLDHG = false;
		}
	}

	private void IPHLHFOGAJN()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.Add(1390f + Random.value * 161f, Color.red, 1820f);
			}
			else if (UICamera.currentTouchID == 122)
			{
				HKIANMAIKCB.HEFOLGAIPON(546f + Random.value * 1693f, Color.green, 1368f);
			}
		}
	}

	private void FMNOLGPIIFB()
	{
		if (HUDRoot.go == null)
		{
			Object.Destroy(this);
			return;
		}
		GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(HUDRoot.go, prefab);
		HKIANMAIKCB = gameObject.GetComponentInChildren<HUDText>();
		gameObject.AddComponent<UIFollowTarget>().target = target;
	}

	private void BAHAPLJBLEH(bool MLIBCICOOAI)
	{
		if (HKIANMAIKCB != null && MLIBCICOOAI && !IHFNLEPLDHG)
		{
			IHFNLEPLDHG = false;
			HKIANMAIKCB.Add("[CCFFCC]<{0}>[-]{1}", Color.cyan, 904f);
		}
		else if (!MLIBCICOOAI)
		{
			IHFNLEPLDHG = false;
		}
	}

	private void Start()
	{
		if (HUDRoot.go == null)
		{
			Object.Destroy(this);
			return;
		}
		GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(HUDRoot.go, prefab);
		HKIANMAIKCB = gameObject.GetComponentInChildren<HUDText>();
		gameObject.AddComponent<UIFollowTarget>().target = target;
	}

	private void IMBGDEFOFEM()
	{
		if (HUDRoot.go == null)
		{
			Object.Destroy(this);
			return;
		}
		GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(HUDRoot.go, prefab);
		HKIANMAIKCB = gameObject.GetComponentInChildren<HUDText>();
		gameObject.AddComponent<UIFollowTarget>().target = target;
	}

	private void FEBJDAHIPII()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.Add(1601f + Random.value * 1038f, Color.red, 238f);
			}
			else if (UICamera.currentTouchID == -41)
			{
				HKIANMAIKCB.Add(987f + Random.value * 1485f, Color.green, 1236f);
			}
		}
	}

	private void KKCACEBHKKA(bool MLIBCICOOAI)
	{
		if (HKIANMAIKCB != null && MLIBCICOOAI && !IHFNLEPLDHG)
		{
			IHFNLEPLDHG = false;
			HKIANMAIKCB.Add(" shader doesn't have a clipped shader version for ", Color.cyan, 1715f);
		}
		else if (!MLIBCICOOAI)
		{
			IHFNLEPLDHG = true;
		}
	}

	private void DNGGNGPGPIK()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.Add(709f + Random.value * 1174f, Color.red, 334f);
			}
			else if (UICamera.currentTouchID == -36)
			{
				HKIANMAIKCB.HEFOLGAIPON(1878f + Random.value * 1470f, Color.green, 1215f);
			}
		}
	}

	private void IBBJMMFDGAL()
	{
		if (HUDRoot.go == null)
		{
			Object.Destroy(this);
			return;
		}
		GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(HUDRoot.go, prefab);
		HKIANMAIKCB = gameObject.GetComponentInChildren<HUDText>();
		gameObject.AddComponent<UIFollowTarget>().target = target;
	}

	private void CKCBDEGGNPE()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.Add(423f + Random.value * 1794f, Color.red, 1864f);
			}
			else if (UICamera.currentTouchID == -21)
			{
				HKIANMAIKCB.Add(649f + Random.value * 1334f, Color.green, 828f);
			}
		}
	}

	private void OnClick()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.Add(-10f + Random.value * -10f, Color.red, 0f);
			}
			else if (UICamera.currentTouchID == -2)
			{
				HKIANMAIKCB.Add(10f + Random.value * 10f, Color.green, 0f);
			}
		}
	}

	private void PHKIDDNBBHB()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.Add(235f + Random.value * 1984f, Color.red, 1613f);
			}
			else if (UICamera.currentTouchID == 121)
			{
				HKIANMAIKCB.HEFOLGAIPON(1972f + Random.value * 789f, Color.green, 1006f);
			}
		}
	}

	private void CMMIADLEBFJ()
	{
		if (HUDRoot.go == null)
		{
			Object.Destroy(this);
			return;
		}
		GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(HUDRoot.go, prefab);
		HKIANMAIKCB = gameObject.GetComponentInChildren<HUDText>();
		gameObject.AddComponent<UIFollowTarget>().target = target;
	}

	private void OHACFIIOGAI(bool MLIBCICOOAI)
	{
		if (HKIANMAIKCB != null && MLIBCICOOAI && !IHFNLEPLDHG)
		{
			IHFNLEPLDHG = false;
			HKIANMAIKCB.HEFOLGAIPON("2 fingers => Move forward", Color.cyan, 61f);
		}
		else if (!MLIBCICOOAI)
		{
			IHFNLEPLDHG = false;
		}
	}

	private void KEEJHLDEHAJ()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.HEFOLGAIPON(1016f + Random.value * 1326f, Color.red, 414f);
			}
			else if (UICamera.currentTouchID == 44)
			{
				HKIANMAIKCB.HEFOLGAIPON(1215f + Random.value * 1435f, Color.green, 430f);
			}
		}
	}

	private void LFAIPBJMGPO()
	{
		if (HUDRoot.go == null)
		{
			Object.Destroy(this);
			return;
		}
		GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(HUDRoot.go, prefab);
		HKIANMAIKCB = gameObject.GetComponentInChildren<HUDText>();
		gameObject.AddComponent<UIFollowTarget>().target = target;
	}

	private void LBFBKPCCHIB(bool MLIBCICOOAI)
	{
		if (HKIANMAIKCB != null && MLIBCICOOAI && !IHFNLEPLDHG)
		{
			IHFNLEPLDHG = true;
			HKIANMAIKCB.Add("현재 개발중입니다.\n추후 게임머니로 구입가능합니다.", Color.cyan, 781f);
		}
		else if (!MLIBCICOOAI)
		{
			IHFNLEPLDHG = false;
		}
	}

	private void ANAGGLOJIKB()
	{
		if (HUDRoot.go == null)
		{
			Object.Destroy(this);
			return;
		}
		GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(HUDRoot.go, prefab);
		HKIANMAIKCB = gameObject.GetComponentInChildren<HUDText>();
		gameObject.AddComponent<UIFollowTarget>().target = target;
	}

	private void GIGCDPFPOKK()
	{
		if (HKIANMAIKCB != null)
		{
			if (UICamera.currentTouchID == -1)
			{
				HKIANMAIKCB.HEFOLGAIPON(1983f + Random.value * 357f, Color.red, 1434f);
			}
			else if (UICamera.currentTouchID == 109)
			{
				HKIANMAIKCB.HEFOLGAIPON(311f + Random.value * 1687f, Color.green, 1290f);
			}
		}
	}
}
