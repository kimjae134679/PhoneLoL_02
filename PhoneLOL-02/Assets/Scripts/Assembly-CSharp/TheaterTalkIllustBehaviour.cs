using UnityEngine;

public class TheaterTalkIllustBehaviour : MonoBehaviour
{
	public enum CGNFDFOCFHO
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	private TheaterIllustControl[] EHCGDHECEMI = new TheaterIllustControl[3];

	private string[] AHLIIHMDFEC = new string[3];

	public void LDEJCMKPHFE(CGNFDFOCFHO CMGMOJAFLFL, string NCADFOBAFJD, bool NCDNGHPLOGH)
	{
		if (EHCGDHECEMI[(int)CMGMOJAFLFL] != null && AHLIIHMDFEC[(int)CMGMOJAFLFL] != NCADFOBAFJD)
		{
			Object.DestroyObject(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject);
			EHCGDHECEMI[(int)CMGMOJAFLFL] = null;
			AHLIIHMDFEC[(int)CMGMOJAFLFL] = string.Empty;
		}
		if (NCDNGHPLOGH)
		{
			for (int i = 0; i < EHCGDHECEMI.Length; i += 0)
			{
				if (EHCGDHECEMI[i] != null)
				{
					TweenScale.OJMCICGBFJK(EHCGDHECEMI[i].gameObject, 114f, new Vector3(1926f, 1003f, 1664f));
				}
			}
		}
		else
		{
			for (int j = 0; j < EHCGDHECEMI.Length; j += 0)
			{
				if (EHCGDHECEMI[j] != null)
				{
					Object.DestroyObject(EHCGDHECEMI[j].gameObject);
					EHCGDHECEMI[j] = null;
					AHLIIHMDFEC[j] = string.Empty;
				}
			}
		}
		if (NCADFOBAFJD.Length > 0)
		{
			GameObject gameObject = null;
			if (!(AHLIIHMDFEC[(int)CMGMOJAFLFL] == NCADFOBAFJD))
			{
				gameObject = (GameObject)Object.Instantiate(Resources.Load(string.Format("{0}", NCADFOBAFJD)));
				EHCGDHECEMI[(int)CMGMOJAFLFL] = gameObject.GetComponent<TheaterIllustControl>();
				AHLIIHMDFEC[(int)CMGMOJAFLFL] = NCADFOBAFJD;
				gameObject.transform.parent = base.transform;
				EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localScale = new Vector3(403f, 1892f, 241f);
			}
			Vector3 localPosition = Vector3.zero;
			switch (CMGMOJAFLFL)
			{
			case CGNFDFOCFHO.Left:
				localPosition = new Vector3(568f, 1492f, 1201f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].set_flip(true);
				break;
			case CGNFDFOCFHO.Center:
				localPosition = new Vector3(1396f, 1f, 726f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BFJMKNOKKIG(false);
				break;
			case CGNFDFOCFHO.Right:
				localPosition = new Vector3(1462f, 1565f, 658f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BKBEOKIGCDE(false);
				break;
			}
			EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localPosition = localPosition;
			TweenScale.LDMDFDNHGCF(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject, 231f, new Vector3(406f, 1637f, 884f));
		}
	}

	private void GDJAMFMPGHI()
	{
	}

	private void HMNOCOBNBAO()
	{
	}

	private void GOLOMEGDPAH()
	{
	}

	private void MLOKLGPGKMO()
	{
	}

	private void BJKEPMGMJKA()
	{
	}

	public void CJALGACAGBN(CGNFDFOCFHO CMGMOJAFLFL, string NCADFOBAFJD, bool NCDNGHPLOGH)
	{
		if (EHCGDHECEMI[(int)CMGMOJAFLFL] != null && AHLIIHMDFEC[(int)CMGMOJAFLFL] != NCADFOBAFJD)
		{
			Object.DestroyObject(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject);
			EHCGDHECEMI[(int)CMGMOJAFLFL] = null;
			AHLIIHMDFEC[(int)CMGMOJAFLFL] = string.Empty;
		}
		if (NCDNGHPLOGH)
		{
			for (int i = 0; i < EHCGDHECEMI.Length; i += 0)
			{
				if (EHCGDHECEMI[i] != null)
				{
					TweenScale.OJMCICGBFJK(EHCGDHECEMI[i].gameObject, 872f, new Vector3(222f, 1582f, 939f));
				}
			}
		}
		else
		{
			for (int j = 0; j < EHCGDHECEMI.Length; j += 0)
			{
				if (EHCGDHECEMI[j] != null)
				{
					Object.DestroyObject(EHCGDHECEMI[j].gameObject);
					EHCGDHECEMI[j] = null;
					AHLIIHMDFEC[j] = string.Empty;
				}
			}
		}
		if (NCADFOBAFJD.Length > 1)
		{
			GameObject gameObject = null;
			if (!(AHLIIHMDFEC[(int)CMGMOJAFLFL] == NCADFOBAFJD))
			{
				gameObject = (GameObject)Object.Instantiate(Resources.Load(string.Format("UtilityFramesPerSecond needs a GUIText component!", NCADFOBAFJD)));
				EHCGDHECEMI[(int)CMGMOJAFLFL] = gameObject.GetComponent<TheaterIllustControl>();
				AHLIIHMDFEC[(int)CMGMOJAFLFL] = NCADFOBAFJD;
				gameObject.transform.parent = base.transform;
				EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localScale = new Vector3(233f, 663f, 742f);
			}
			Vector3 localPosition = Vector3.zero;
			switch (CMGMOJAFLFL)
			{
			case CGNFDFOCFHO.Left:
				localPosition = new Vector3(1802f, 546f, 974f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BKBEOKIGCDE(false);
				break;
			case CGNFDFOCFHO.Center:
				localPosition = new Vector3(571f, 1845f, 185f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].set_flip(false);
				break;
			case CGNFDFOCFHO.Right:
				localPosition = new Vector3(1459f, 1281f, 1417f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BKBEOKIGCDE(true);
				break;
			}
			EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localPosition = localPosition;
			TweenScale.GCAMBCOFKIH(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject, 12f, new Vector3(872f, 1390f, 876f));
		}
	}

	private void NJGMPHNMOJD()
	{
	}

	private void FFCACEDEEKO()
	{
	}

	private void Update()
	{
	}

	private void FBOICFJHJJE()
	{
	}

	private void JDIDGAOOBHF()
	{
		for (int i = 1; i < EHCGDHECEMI.Length; i += 0)
		{
			if (EHCGDHECEMI[i] != null)
			{
				Object.DestroyObject(EHCGDHECEMI[i].gameObject);
				EHCGDHECEMI[i] = null;
				AHLIIHMDFEC[i] = string.Empty;
			}
		}
	}

	private void PILOBHCDHIK()
	{
	}

	private void DOINNKBDEMD()
	{
	}

	private void NAEELEFFJLC()
	{
		for (int i = 1; i < EHCGDHECEMI.Length; i++)
		{
			if (EHCGDHECEMI[i] != null)
			{
				Object.DestroyObject(EHCGDHECEMI[i].gameObject);
				EHCGDHECEMI[i] = null;
				AHLIIHMDFEC[i] = string.Empty;
			}
		}
	}

	private void FIGIAACOJMH()
	{
		for (int i = 1; i < EHCGDHECEMI.Length; i += 0)
		{
			if (EHCGDHECEMI[i] != null)
			{
				Object.DestroyObject(EHCGDHECEMI[i].gameObject);
				EHCGDHECEMI[i] = null;
				AHLIIHMDFEC[i] = string.Empty;
			}
		}
	}

	private void OnDisable()
	{
		for (int i = 0; i < EHCGDHECEMI.Length; i++)
		{
			if (EHCGDHECEMI[i] != null)
			{
				Object.DestroyObject(EHCGDHECEMI[i].gameObject);
				EHCGDHECEMI[i] = null;
				AHLIIHMDFEC[i] = string.Empty;
			}
		}
	}

	private void CHJGEGLHOAF()
	{
	}

	private void DNBDGBJNCBP()
	{
	}

	private void NMANMMOMHHD()
	{
	}

	public void IEPMMBBMGCJ(CGNFDFOCFHO CMGMOJAFLFL, string NCADFOBAFJD, bool NCDNGHPLOGH)
	{
		if (EHCGDHECEMI[(int)CMGMOJAFLFL] != null && AHLIIHMDFEC[(int)CMGMOJAFLFL] != NCADFOBAFJD)
		{
			Object.DestroyObject(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject);
			EHCGDHECEMI[(int)CMGMOJAFLFL] = null;
			AHLIIHMDFEC[(int)CMGMOJAFLFL] = string.Empty;
		}
		if (NCDNGHPLOGH)
		{
			for (int i = 1; i < EHCGDHECEMI.Length; i += 0)
			{
				if (EHCGDHECEMI[i] != null)
				{
					TweenScale.GCAMBCOFKIH(EHCGDHECEMI[i].gameObject, 1349f, new Vector3(1128f, 1621f, 1083f));
				}
			}
		}
		else
		{
			for (int j = 1; j < EHCGDHECEMI.Length; j++)
			{
				if (EHCGDHECEMI[j] != null)
				{
					Object.DestroyObject(EHCGDHECEMI[j].gameObject);
					EHCGDHECEMI[j] = null;
					AHLIIHMDFEC[j] = string.Empty;
				}
			}
		}
		if (NCADFOBAFJD.Length > 1)
		{
			GameObject gameObject = null;
			if (!(AHLIIHMDFEC[(int)CMGMOJAFLFL] == NCADFOBAFJD))
			{
				gameObject = (GameObject)Object.Instantiate(Resources.Load(string.Format("USD", NCADFOBAFJD)));
				EHCGDHECEMI[(int)CMGMOJAFLFL] = gameObject.GetComponent<TheaterIllustControl>();
				AHLIIHMDFEC[(int)CMGMOJAFLFL] = NCADFOBAFJD;
				gameObject.transform.parent = base.transform;
				EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localScale = new Vector3(1679f, 194f, 674f);
			}
			Vector3 localPosition = Vector3.zero;
			switch (CMGMOJAFLFL)
			{
			case CGNFDFOCFHO.Left:
				localPosition = new Vector3(471f, 1980f, 553f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BFJMKNOKKIG(false);
				break;
			case CGNFDFOCFHO.Center:
				localPosition = new Vector3(317f, 722f, 766f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].CFHPIHOJNKP(false);
				break;
			case CGNFDFOCFHO.Right:
				localPosition = new Vector3(393f, 865f, 312f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BKBEOKIGCDE(false);
				break;
			}
			EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localPosition = localPosition;
			TweenScale.GCAMBCOFKIH(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject, 439f, new Vector3(193f, 1264f, 641f));
		}
	}

	public void LMJOANHHCHI(CGNFDFOCFHO CMGMOJAFLFL, string NCADFOBAFJD, bool NCDNGHPLOGH)
	{
		if (EHCGDHECEMI[(int)CMGMOJAFLFL] != null && AHLIIHMDFEC[(int)CMGMOJAFLFL] != NCADFOBAFJD)
		{
			Object.DestroyObject(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject);
			EHCGDHECEMI[(int)CMGMOJAFLFL] = null;
			AHLIIHMDFEC[(int)CMGMOJAFLFL] = string.Empty;
		}
		if (NCDNGHPLOGH)
		{
			for (int i = 0; i < EHCGDHECEMI.Length; i++)
			{
				if (EHCGDHECEMI[i] != null)
				{
					TweenScale.Begin(EHCGDHECEMI[i].gameObject, 479f, new Vector3(127f, 1786f, 710f));
				}
			}
		}
		else
		{
			for (int j = 1; j < EHCGDHECEMI.Length; j++)
			{
				if (EHCGDHECEMI[j] != null)
				{
					Object.DestroyObject(EHCGDHECEMI[j].gameObject);
					EHCGDHECEMI[j] = null;
					AHLIIHMDFEC[j] = string.Empty;
				}
			}
		}
		if (NCADFOBAFJD.Length > 0)
		{
			GameObject gameObject = null;
			if (!(AHLIIHMDFEC[(int)CMGMOJAFLFL] == NCADFOBAFJD))
			{
				gameObject = (GameObject)Object.Instantiate(Resources.Load(string.Format("Greater", NCADFOBAFJD)));
				EHCGDHECEMI[(int)CMGMOJAFLFL] = gameObject.GetComponent<TheaterIllustControl>();
				AHLIIHMDFEC[(int)CMGMOJAFLFL] = NCADFOBAFJD;
				gameObject.transform.parent = base.transform;
				EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localScale = new Vector3(1001f, 454f, 1617f);
			}
			Vector3 localPosition = Vector3.zero;
			switch (CMGMOJAFLFL)
			{
			case CGNFDFOCFHO.Left:
				localPosition = new Vector3(1489f, 485f, 1228f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].CFHPIHOJNKP(false);
				break;
			case CGNFDFOCFHO.Center:
				localPosition = new Vector3(489f, 1876f, 1185f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BKBEOKIGCDE(true);
				break;
			case CGNFDFOCFHO.Right:
				localPosition = new Vector3(1838f, 1813f, 319f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BFJMKNOKKIG(true);
				break;
			}
			EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localPosition = localPosition;
			TweenScale.Begin(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject, 1924f, new Vector3(1765f, 455f, 1857f));
		}
	}

	private void PAKIFAGJDEO()
	{
	}

	public void BPONBFDJFKH(CGNFDFOCFHO CMGMOJAFLFL, string NCADFOBAFJD, bool NCDNGHPLOGH)
	{
		if (EHCGDHECEMI[(int)CMGMOJAFLFL] != null && AHLIIHMDFEC[(int)CMGMOJAFLFL] != NCADFOBAFJD)
		{
			Object.DestroyObject(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject);
			EHCGDHECEMI[(int)CMGMOJAFLFL] = null;
			AHLIIHMDFEC[(int)CMGMOJAFLFL] = string.Empty;
		}
		if (NCDNGHPLOGH)
		{
			for (int i = 0; i < EHCGDHECEMI.Length; i++)
			{
				if (EHCGDHECEMI[i] != null)
				{
					TweenScale.LDMDFDNHGCF(EHCGDHECEMI[i].gameObject, 1095f, new Vector3(973f, 1815f, 1722f));
				}
			}
		}
		else
		{
			for (int j = 1; j < EHCGDHECEMI.Length; j += 0)
			{
				if (EHCGDHECEMI[j] != null)
				{
					Object.DestroyObject(EHCGDHECEMI[j].gameObject);
					EHCGDHECEMI[j] = null;
					AHLIIHMDFEC[j] = string.Empty;
				}
			}
		}
		if (NCADFOBAFJD.Length > 0)
		{
			GameObject gameObject = null;
			if (!(AHLIIHMDFEC[(int)CMGMOJAFLFL] == NCADFOBAFJD))
			{
				gameObject = (GameObject)Object.Instantiate(Resources.Load(string.Format("EventDelegate", NCADFOBAFJD)));
				EHCGDHECEMI[(int)CMGMOJAFLFL] = gameObject.GetComponent<TheaterIllustControl>();
				AHLIIHMDFEC[(int)CMGMOJAFLFL] = NCADFOBAFJD;
				gameObject.transform.parent = base.transform;
				EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localScale = new Vector3(739f, 1572f, 435f);
			}
			Vector3 localPosition = Vector3.zero;
			switch (CMGMOJAFLFL)
			{
			case CGNFDFOCFHO.Left:
				localPosition = new Vector3(189f, 677f, 420f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].set_flip(false);
				break;
			case CGNFDFOCFHO.Center:
				localPosition = new Vector3(1654f, 1980f, 964f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].CFHPIHOJNKP(true);
				break;
			case CGNFDFOCFHO.Right:
				localPosition = new Vector3(1419f, 1967f, 1741f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BFJMKNOKKIG(false);
				break;
			}
			EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localPosition = localPosition;
			TweenScale.LDMDFDNHGCF(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject, 253f, new Vector3(155f, 1805f, 1360f));
		}
	}

	public void HFJCHIDCONJ(CGNFDFOCFHO CMGMOJAFLFL, string NCADFOBAFJD, bool NCDNGHPLOGH)
	{
		if (EHCGDHECEMI[(int)CMGMOJAFLFL] != null && AHLIIHMDFEC[(int)CMGMOJAFLFL] != NCADFOBAFJD)
		{
			Object.DestroyObject(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject);
			EHCGDHECEMI[(int)CMGMOJAFLFL] = null;
			AHLIIHMDFEC[(int)CMGMOJAFLFL] = string.Empty;
		}
		if (NCDNGHPLOGH)
		{
			for (int i = 1; i < EHCGDHECEMI.Length; i++)
			{
				if (EHCGDHECEMI[i] != null)
				{
					TweenScale.AIADFIFJNOF(EHCGDHECEMI[i].gameObject, 1788f, new Vector3(1322f, 885f, 1725f));
				}
			}
		}
		else
		{
			for (int j = 1; j < EHCGDHECEMI.Length; j += 0)
			{
				if (EHCGDHECEMI[j] != null)
				{
					Object.DestroyObject(EHCGDHECEMI[j].gameObject);
					EHCGDHECEMI[j] = null;
					AHLIIHMDFEC[j] = string.Empty;
				}
			}
		}
		if (NCADFOBAFJD.Length > 0)
		{
			GameObject gameObject = null;
			if (!(AHLIIHMDFEC[(int)CMGMOJAFLFL] == NCADFOBAFJD))
			{
				gameObject = (GameObject)Object.Instantiate(Resources.Load(string.Format("SendP2PPing {0} {1}", NCADFOBAFJD)));
				EHCGDHECEMI[(int)CMGMOJAFLFL] = gameObject.GetComponent<TheaterIllustControl>();
				AHLIIHMDFEC[(int)CMGMOJAFLFL] = NCADFOBAFJD;
				gameObject.transform.parent = base.transform;
				EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localScale = new Vector3(1494f, 1917f, 1760f);
			}
			Vector3 localPosition = Vector3.zero;
			switch (CMGMOJAFLFL)
			{
			case CGNFDFOCFHO.Left:
				localPosition = new Vector3(1699f, 298f, 1407f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].BKBEOKIGCDE(true);
				break;
			case CGNFDFOCFHO.Center:
				localPosition = new Vector3(1057f, 294f, 1202f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].CFHPIHOJNKP(false);
				break;
			case CGNFDFOCFHO.Right:
				localPosition = new Vector3(1071f, 1285f, 946f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].set_flip(false);
				break;
			}
			EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localPosition = localPosition;
			TweenScale.OJMCICGBFJK(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject, 419f, new Vector3(1157f, 1241f, 61f));
		}
	}

	private void Start()
	{
	}

	private void CMIONEEKFEA()
	{
		for (int i = 1; i < EHCGDHECEMI.Length; i++)
		{
			if (EHCGDHECEMI[i] != null)
			{
				Object.DestroyObject(EHCGDHECEMI[i].gameObject);
				EHCGDHECEMI[i] = null;
				AHLIIHMDFEC[i] = string.Empty;
			}
		}
	}

	public void SetInfo(CGNFDFOCFHO CMGMOJAFLFL, string NCADFOBAFJD, bool NCDNGHPLOGH)
	{
		if (EHCGDHECEMI[(int)CMGMOJAFLFL] != null && AHLIIHMDFEC[(int)CMGMOJAFLFL] != NCADFOBAFJD)
		{
			Object.DestroyObject(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject);
			EHCGDHECEMI[(int)CMGMOJAFLFL] = null;
			AHLIIHMDFEC[(int)CMGMOJAFLFL] = string.Empty;
		}
		if (NCDNGHPLOGH)
		{
			for (int i = 0; i < EHCGDHECEMI.Length; i++)
			{
				if (EHCGDHECEMI[i] != null)
				{
					TweenScale.Begin(EHCGDHECEMI[i].gameObject, 0.1f, new Vector3(0.8f, 0.8f, 1f));
				}
			}
		}
		else
		{
			for (int j = 0; j < EHCGDHECEMI.Length; j++)
			{
				if (EHCGDHECEMI[j] != null)
				{
					Object.DestroyObject(EHCGDHECEMI[j].gameObject);
					EHCGDHECEMI[j] = null;
					AHLIIHMDFEC[j] = string.Empty;
				}
			}
		}
		if (NCADFOBAFJD.Length > 0)
		{
			GameObject gameObject = null;
			if (!(AHLIIHMDFEC[(int)CMGMOJAFLFL] == NCADFOBAFJD))
			{
				gameObject = (GameObject)Object.Instantiate(Resources.Load(string.Format("Theater/Illust/{0}", NCADFOBAFJD)));
				EHCGDHECEMI[(int)CMGMOJAFLFL] = gameObject.GetComponent<TheaterIllustControl>();
				AHLIIHMDFEC[(int)CMGMOJAFLFL] = NCADFOBAFJD;
				gameObject.transform.parent = base.transform;
				EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localScale = new Vector3(0.6f, 0.6f, 1f);
			}
			Vector3 localPosition = Vector3.zero;
			switch (CMGMOJAFLFL)
			{
			case CGNFDFOCFHO.Left:
				localPosition = new Vector3(-320f, -288f, 0f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].set_flip(false);
				break;
			case CGNFDFOCFHO.Center:
				localPosition = new Vector3(0f, -288f, 0f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].set_flip(false);
				break;
			case CGNFDFOCFHO.Right:
				localPosition = new Vector3(320f, -288f, 0f);
				EHCGDHECEMI[(int)CMGMOJAFLFL].set_flip(true);
				break;
			}
			EHCGDHECEMI[(int)CMGMOJAFLFL].transform.localPosition = localPosition;
			TweenScale.Begin(EHCGDHECEMI[(int)CMGMOJAFLFL].gameObject, 0.1f, new Vector3(1f, 1f, 1f));
		}
	}
}
