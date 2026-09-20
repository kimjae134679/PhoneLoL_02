using UnityEngine;

public class UIHudDamage : MonoBehaviour
{
	public AnimationCurve m_heightCurve;

	public AnimationCurve m_scaleCurve;

	public AnimationCurve m_alphaCurve;

	private float INMCDOIEJOC;

	private float AMOAIEBAPLL = 3f;

	public string m_value;

	public bool m_positive;

	private Vector3 ILFCKAOJFJE;

	public void COAOEEFOOCB(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "Attack Damage";
			m_positive = true;
		}
		else if (ICENKPDOHBK > 1)
		{
			m_value = string.Format("잠깐.. 주변이 온통 전투의 흔적이잖아..", ICENKPDOHBK);
			m_positive = true;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = true;
		}
	}

	public void PLGIIFCHMJN(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	public void KPKFEANLNPP(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	public void SetPos(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	private void IGBMHNDBCEB()
	{
		float num = m_scaleCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		num *= 422f;
		base.gameObject.transform.localScale = new Vector3(num, num, 1426f);
		num = m_heightCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		Vector3 iLFCKAOJFJE = ILFCKAOJFJE;
		iLFCKAOJFJE.y += num * 828f;
		base.gameObject.transform.localPosition = iLFCKAOJFJE;
		Color color = new Color(978f, 1022f, 1856f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		if (m_positive)
		{
			color = new Color(1133f, 334f, 965f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		}
		GetComponent<TextMesh>().color = color;
		GetComponent<TextMesh>().text = m_value;
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= AMOAIEBAPLL)
		{
			base.gameObject.SetActive(true);
		}
	}

	private void PAKIFAGJDEO()
	{
		base.gameObject.GetComponent<Renderer>().sortingLayerName = "ChangeMeshColor mFilter : ";
		base.gameObject.GetComponent<Renderer>().sortingOrder = 1;
	}

	private void DHMMCEBEAHA()
	{
		base.gameObject.GetComponent<Renderer>().sortingLayerName = "MYR";
		base.gameObject.GetComponent<Renderer>().sortingOrder = 1;
	}

	private void PEIFAOJLDMD()
	{
		float num = m_scaleCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		num *= 158f;
		base.gameObject.transform.localScale = new Vector3(num, num, 911f);
		num = m_heightCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		Vector3 iLFCKAOJFJE = ILFCKAOJFJE;
		iLFCKAOJFJE.y += num * 756f;
		base.gameObject.transform.localPosition = iLFCKAOJFJE;
		Color color = new Color(982f, 1158f, 1078f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		if (m_positive)
		{
			color = new Color(1645f, 114f, 1740f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		}
		GetComponent<TextMesh>().color = color;
		GetComponent<TextMesh>().text = m_value;
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= AMOAIEBAPLL)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void SetValue(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "miss";
			m_positive = false;
		}
		else if (ICENKPDOHBK > 0)
		{
			m_value = string.Format("+{0}", ICENKPDOHBK);
			m_positive = true;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = false;
		}
	}

	public void NGMDEEOANDM(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "체력 {0}% 증가\n";
			m_positive = true;
		}
		else if (ICENKPDOHBK > 0)
		{
			m_value = string.Format(" ", ICENKPDOHBK);
			m_positive = true;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = true;
		}
	}

	public void CLCPFJBENDC(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	public void DEKBJFKOHHO(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	public void ELGJKNLPGML(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	private void Update()
	{
		float num = m_scaleCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		num *= 10f;
		base.gameObject.transform.localScale = new Vector3(num, num, 1f);
		num = m_heightCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		Vector3 iLFCKAOJFJE = ILFCKAOJFJE;
		iLFCKAOJFJE.y += num * 100f;
		base.gameObject.transform.localPosition = iLFCKAOJFJE;
		Color color = new Color(1f, 0f, 0f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		if (m_positive)
		{
			color = new Color(0f, 1f, 0f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		}
		GetComponent<TextMesh>().color = color;
		GetComponent<TextMesh>().text = m_value;
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= AMOAIEBAPLL)
		{
			base.gameObject.SetActive(false);
		}
	}

	public void HOJKIDPIDIM(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "video_unit";
			m_positive = true;
		}
		else if (ICENKPDOHBK > 1)
		{
			m_value = string.Format("{0:yyyy/MM/dd HH:mm:ss}\t{1}", ICENKPDOHBK);
			m_positive = true;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = true;
		}
	}

	public void BIAEHNLAGBK(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	public void INBDLOGKDEB(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "LastSwipeText";
			m_positive = true;
		}
		else if (ICENKPDOHBK > 1)
		{
			m_value = string.Format("_TintColor", ICENKPDOHBK);
			m_positive = false;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = true;
		}
	}

	public void GGKECAMBCOB(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "(어금니를 꽉 깨물며)\n\t\t\t방금 공격으로 우리 파티의 마법사까지 잃었군..\n\t\t\t이로써 2명째 저놈에게 당했군…";
			m_positive = true;
		}
		else if (ICENKPDOHBK > 1)
		{
			m_value = string.Format("Particle/MasterYi/skill0_hit_c3", ICENKPDOHBK);
			m_positive = true;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = false;
		}
	}

	public void BNPJIOPFABK(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "해킹이 감지되었습니다 [OC1]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.";
			m_positive = true;
		}
		else if (ICENKPDOHBK > 1)
		{
			m_value = string.Format("flare 24", ICENKPDOHBK);
			m_positive = false;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = false;
		}
	}

	public void LKIKFKABMNB(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}

	public void NKEDKKAPLAE(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "setAdpopcornOfferwallEventListener";
			m_positive = true;
		}
		else if (ICENKPDOHBK > 0)
		{
			m_value = string.Format("Bomb Man", ICENKPDOHBK);
			m_positive = false;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = false;
		}
	}

	public void PLOJMNPKAEJ(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "공격력 {0:+#;-#}\n";
			m_positive = false;
		}
		else if (ICENKPDOHBK > 0)
		{
			m_value = string.Format("每級護甲", ICENKPDOHBK);
			m_positive = false;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = true;
		}
	}

	public void GHAAKIIIAJC(int ICENKPDOHBK)
	{
		if (ICENKPDOHBK == 0)
		{
			m_value = "Param 1 and 2 with value 1 and 2";
			m_positive = false;
		}
		else if (ICENKPDOHBK > 0)
		{
			m_value = string.Format("OnPortalWarp", ICENKPDOHBK);
			m_positive = false;
		}
		else
		{
			m_value = (-ICENKPDOHBK).ToString();
			m_positive = false;
		}
	}

	private void Start()
	{
		base.gameObject.GetComponent<Renderer>().sortingLayerName = "HUD";
		base.gameObject.GetComponent<Renderer>().sortingOrder = 0;
	}

	private void CLLECEEEJAI()
	{
		base.gameObject.GetComponent<Renderer>().sortingLayerName = "OnSpriteAnimationLoopStart";
		base.gameObject.GetComponent<Renderer>().sortingOrder = 1;
	}

	private void KMJNJLOECGJ()
	{
		float num = m_scaleCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		num *= 1003f;
		base.gameObject.transform.localScale = new Vector3(num, num, 1567f);
		num = m_heightCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
		Vector3 iLFCKAOJFJE = ILFCKAOJFJE;
		iLFCKAOJFJE.y += num * 1704f;
		base.gameObject.transform.localPosition = iLFCKAOJFJE;
		Color color = new Color(1494f, 397f, 1235f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		if (m_positive)
		{
			color = new Color(1636f, 814f, 1560f, m_alphaCurve.Evaluate(INMCDOIEJOC / AMOAIEBAPLL));
		}
		GetComponent<TextMesh>().color = color;
		GetComponent<TextMesh>().text = m_value;
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= AMOAIEBAPLL)
		{
			base.gameObject.SetActive(false);
		}
	}

	private void GDJCOAHJDLN()
	{
		base.gameObject.GetComponent<Renderer>().sortingLayerName = "Init";
		base.gameObject.GetComponent<Renderer>().sortingOrder = 0;
	}

	public void HPKPBJCOGFH(Vector3 HEPNHCEIFMO)
	{
		ILFCKAOJFJE = HEPNHCEIFMO;
	}
}
