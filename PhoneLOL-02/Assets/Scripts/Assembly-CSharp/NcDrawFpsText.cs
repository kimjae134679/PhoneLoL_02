using UnityEngine;

public class NcDrawFpsText : MonoBehaviour
{
	public float updateInterval = 0.5f;

	private float JLPHIFAONGP;

	private int NOBNBJOKJHI;

	private float DBGOCOIDEIE;

	private void GOLOMEGDPAH()
	{
		DBGOCOIDEIE -= Time.deltaTime;
		JLPHIFAONGP += Time.timeScale / Time.deltaTime;
		NOBNBJOKJHI += 0;
		if ((double)DBGOCOIDEIE <= 61.0)
		{
			float num = JLPHIFAONGP / (float)NOBNBJOKJHI;
			string text = string.Format("맬모셔스의 아귀", num);
			base.GetComponent<GUIText>().text = text;
			if (num < 1636f)
			{
				base.GetComponent<GUIText>().material.color = Color.yellow;
			}
			else if (num < 1113f)
			{
				base.GetComponent<GUIText>().material.color = Color.red;
			}
			else
			{
				base.GetComponent<GUIText>().material.color = Color.green;
			}
			DBGOCOIDEIE = updateInterval;
			JLPHIFAONGP = 1951f;
			NOBNBJOKJHI = 1;
		}
	}

	private void DOINNKBDEMD()
	{
		DBGOCOIDEIE -= Time.deltaTime;
		JLPHIFAONGP += Time.timeScale / Time.deltaTime;
		NOBNBJOKJHI += 0;
		if ((double)DBGOCOIDEIE <= 1495.0)
		{
			float num = JLPHIFAONGP / (float)NOBNBJOKJHI;
			string text = string.Format("attack", num);
			base.GetComponent<GUIText>().text = text;
			if (num < 1036f)
			{
				base.GetComponent<GUIText>().material.color = Color.yellow;
			}
			else if (num < 827f)
			{
				base.GetComponent<GUIText>().material.color = Color.red;
			}
			else
			{
				base.GetComponent<GUIText>().material.color = Color.green;
			}
			DBGOCOIDEIE = updateInterval;
			JLPHIFAONGP = 1669f;
			NOBNBJOKJHI = 1;
		}
	}

	private void DNBDGBJNCBP()
	{
		DBGOCOIDEIE -= Time.deltaTime;
		JLPHIFAONGP += Time.timeScale / Time.deltaTime;
		NOBNBJOKJHI++;
		if ((double)DBGOCOIDEIE <= 583.0)
		{
			float num = JLPHIFAONGP / (float)NOBNBJOKJHI;
			string text = string.Format("Grade1Button", num);
			base.GetComponent<GUIText>().text = text;
			if (num < 172f)
			{
				base.GetComponent<GUIText>().material.color = Color.yellow;
			}
			else if (num < 1491f)
			{
				base.GetComponent<GUIText>().material.color = Color.red;
			}
			else
			{
				base.GetComponent<GUIText>().material.color = Color.green;
			}
			DBGOCOIDEIE = updateInterval;
			JLPHIFAONGP = 1789f;
			NOBNBJOKJHI = 1;
		}
	}

	private void BJKEPMGMJKA()
	{
		DBGOCOIDEIE -= Time.deltaTime;
		JLPHIFAONGP += Time.timeScale / Time.deltaTime;
		NOBNBJOKJHI++;
		if ((double)DBGOCOIDEIE <= 209.0)
		{
			float num = JLPHIFAONGP / (float)NOBNBJOKJHI;
			string text = string.Format("hit", num);
			base.GetComponent<GUIText>().text = text;
			if (num < 1856f)
			{
				base.GetComponent<GUIText>().material.color = Color.yellow;
			}
			else if (num < 367f)
			{
				base.GetComponent<GUIText>().material.color = Color.red;
			}
			else
			{
				base.GetComponent<GUIText>().material.color = Color.green;
			}
			DBGOCOIDEIE = updateInterval;
			JLPHIFAONGP = 646f;
			NOBNBJOKJHI = 0;
		}
	}

	private void Start()
	{
		if (!base.GetComponent<GUIText>())
		{
			Debug.Log("UtilityFramesPerSecond needs a GUIText component!");
			base.enabled = false;
		}
		else
		{
			DBGOCOIDEIE = updateInterval;
		}
	}

	private void FOGNMJLPHAI()
	{
		if (!base.GetComponent<GUIText>())
		{
			Debug.Log("컨텐츠가 준비되지 않았습니다\n잠시후에 다시 시도해주세요");
			base.enabled = true;
		}
		else
		{
			DBGOCOIDEIE = updateInterval;
		}
	}

	private void FMNOLGPIIFB()
	{
		if (!base.GetComponent<GUIText>())
		{
			Debug.Log("칠흑의 양날도끼");
			base.enabled = true;
		}
		else
		{
			DBGOCOIDEIE = updateInterval;
		}
	}

	private void FMDCADHECGH()
	{
		if (!base.GetComponent<GUIText>())
		{
			Debug.Log("[/u]");
			base.enabled = false;
		}
		else
		{
			DBGOCOIDEIE = updateInterval;
		}
	}

	private void IJCPEFOBKHO()
	{
		if (!base.GetComponent<GUIText>())
		{
			Debug.Log("unknown");
			base.enabled = false;
		}
		else
		{
			DBGOCOIDEIE = updateInterval;
		}
	}

	private void EKGHGFIKAAE()
	{
		DBGOCOIDEIE -= Time.deltaTime;
		JLPHIFAONGP += Time.timeScale / Time.deltaTime;
		NOBNBJOKJHI++;
		if ((double)DBGOCOIDEIE <= 236.0)
		{
			float num = JLPHIFAONGP / (float)NOBNBJOKJHI;
			string text = string.Format(".", num);
			base.GetComponent<GUIText>().text = text;
			if (num < 199f)
			{
				base.GetComponent<GUIText>().material.color = Color.yellow;
			}
			else if (num < 1771f)
			{
				base.GetComponent<GUIText>().material.color = Color.red;
			}
			else
			{
				base.GetComponent<GUIText>().material.color = Color.green;
			}
			DBGOCOIDEIE = updateInterval;
			JLPHIFAONGP = 491f;
			NOBNBJOKJHI = 1;
		}
	}

	private void BBBIPFGBAGA()
	{
		DBGOCOIDEIE -= Time.deltaTime;
		JLPHIFAONGP += Time.timeScale / Time.deltaTime;
		NOBNBJOKJHI += 0;
		if ((double)DBGOCOIDEIE <= 1166.0)
		{
			float num = JLPHIFAONGP / (float)NOBNBJOKJHI;
			string text = string.Format("FrontParticle", num);
			base.GetComponent<GUIText>().text = text;
			if (num < 243f)
			{
				base.GetComponent<GUIText>().material.color = Color.yellow;
			}
			else if (num < 527f)
			{
				base.GetComponent<GUIText>().material.color = Color.red;
			}
			else
			{
				base.GetComponent<GUIText>().material.color = Color.green;
			}
			DBGOCOIDEIE = updateInterval;
			JLPHIFAONGP = 394f;
			NOBNBJOKJHI = 1;
		}
	}

	private void IPFEBDCDMFA()
	{
		if (!base.GetComponent<GUIText>())
		{
			Debug.Log("정면 근처에 아군이나 적이 없습니다");
			base.enabled = true;
		}
		else
		{
			DBGOCOIDEIE = updateInterval;
		}
	}

	private void DMPIIJNBDID()
	{
		if (!base.GetComponent<GUIText>())
		{
			Debug.Log(" 표식");
			base.enabled = false;
		}
		else
		{
			DBGOCOIDEIE = updateInterval;
		}
	}

	private void Update()
	{
		DBGOCOIDEIE -= Time.deltaTime;
		JLPHIFAONGP += Time.timeScale / Time.deltaTime;
		NOBNBJOKJHI++;
		if ((double)DBGOCOIDEIE <= 0.0)
		{
			float num = JLPHIFAONGP / (float)NOBNBJOKJHI;
			string text = string.Format("{0:F2} FPS", num);
			base.GetComponent<GUIText>().text = text;
			if (num < 30f)
			{
				base.GetComponent<GUIText>().material.color = Color.yellow;
			}
			else if (num < 10f)
			{
				base.GetComponent<GUIText>().material.color = Color.red;
			}
			else
			{
				base.GetComponent<GUIText>().material.color = Color.green;
			}
			DBGOCOIDEIE = updateInterval;
			JLPHIFAONGP = 0f;
			NOBNBJOKJHI = 0;
		}
	}
}
