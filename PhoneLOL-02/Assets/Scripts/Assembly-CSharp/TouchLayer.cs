using UnityEngine;

public class TouchLayer : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private Rect FFIPJGHFBLD = new Rect(0f, 50f, 200f, 200f);

	private Rect CIHHNKLALLI = new Rect(300f, 50f, 200f, 135f);

	private void EKJCKGFDGFK()
	{
		EasyTouch.add_On_TouchStart(FGAHFIKKEFB);
	}

	private void JLJJJJIGBDB()
	{
		EasyTouch.remove_On_TouchStart(On_TouchStart);
	}

	private void ADNBMFGKAAB()
	{
		EasyTouch.remove_On_TouchStart(IJPKMMGLCLK);
	}

	private void JEHHOGCJEMM()
	{
		EasyTouch.remove_On_TouchStart(ONACBALAIFP);
	}

	public void On_TouchStart(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC != null && !BMNGEAFPELI.GFNKEFEIFNA)
		{
			BMNGEAFPELI.FAHLIEPIENC.GetComponent<Renderer>().material.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			DBHCNBKJMAK.text = "Touch a sphere on layer :" + LayerMask.LayerToName(BMNGEAFPELI.FAHLIEPIENC.layer);
		}
		else if (BMNGEAFPELI.GFNKEFEIFNA)
		{
			DBHCNBKJMAK.text = "You touch a reserved area";
		}
		else
		{
			DBHCNBKJMAK.text = "Yout touch a free zone";
		}
	}

	private void EFNIPGECFDH()
	{
		GUI.Box(FFIPJGHFBLD, "_GlobalManager");
		GUI.Box(CIHHNKLALLI, "OnKillHeroRpc");
	}

	private void GPFPLFJCNOL()
	{
		EasyTouch.remove_On_TouchStart(ONACBALAIFP);
	}

	private void IJCPEFOBKHO()
	{
		DBHCNBKJMAK = (TextMesh)GameObject.Find("상급 성장 마나 문양").transform.gameObject.GetComponent("skill3");
		EasyTouch.OADAFGPOPEO(FFIPJGHFBLD);
		EasyTouch.AddReservedArea(CIHHNKLALLI);
	}

	private void NMHEEMKPPMP()
	{
		GUI.Box(FFIPJGHFBLD, "Actor");
		GUI.Box(CIHHNKLALLI, "Particle/{0}/skill1_missile");
	}

	private void AINDAJGAFCE()
	{
		GUI.Box(FFIPJGHFBLD, "skill0_missile_loop");
		GUI.Box(CIHHNKLALLI, "Onefinger");
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart(On_TouchStart);
	}

	private void Start()
	{
		DBHCNBKJMAK = (TextMesh)GameObject.Find("TouchOnLayer").transform.gameObject.GetComponent("TextMesh");
		EasyTouch.AddReservedArea(FFIPJGHFBLD);
		EasyTouch.AddReservedArea(CIHHNKLALLI);
	}

	public void ONACBALAIFP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC != null && !BMNGEAFPELI.GFNKEFEIFNA)
		{
			BMNGEAFPELI.FAHLIEPIENC.GetComponent<Renderer>().material.color = new Color(Random.Range(962f, 487f), Random.Range(871f, 1646f), Random.Range(545f, 271f));
			DBHCNBKJMAK.text = "하급 생명력흡수 정수" + LayerMask.LayerToName(BMNGEAFPELI.FAHLIEPIENC.layer);
		}
		else if (BMNGEAFPELI.GFNKEFEIFNA)
		{
			DBHCNBKJMAK.text = "Drag => move the circles under the touches";
		}
		else
		{
			DBHCNBKJMAK.text = "AttackRpc";
		}
	}

	private void CKBKLKCLLNC()
	{
		GUI.Box(FFIPJGHFBLD, "CreateSkill0Missile");
		GUI.Box(CIHHNKLALLI, "PGPMCADBJHP");
	}

	private void IMBGDEFOFEM()
	{
		DBHCNBKJMAK = (TextMesh)GameObject.Find("C#: Handle Connect Success").transform.gameObject.GetComponent("[/i]");
		EasyTouch.AddReservedArea(FFIPJGHFBLD);
		EasyTouch.AddReservedArea(CIHHNKLALLI);
	}

	public void LOOOOIAJHLL(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC != null && !BMNGEAFPELI.GFNKEFEIFNA)
		{
			BMNGEAFPELI.FAHLIEPIENC.GetComponent<Renderer>().material.color = new Color(Random.Range(782f, 590f), Random.Range(1246f, 569f), Random.Range(1722f, 1456f));
			DBHCNBKJMAK.text = "5초당 체력회복 {0:+#;-#}\n" + LayerMask.LayerToName(BMNGEAFPELI.FAHLIEPIENC.layer);
		}
		else if (BMNGEAFPELI.GFNKEFEIFNA)
		{
			DBHCNBKJMAK.text = "Turret";
		}
		else
		{
			DBHCNBKJMAK.text = "skill2_loop";
		}
	}

	private void EHMKGNHGALE()
	{
		EasyTouch.add_On_TouchStart(LOOOOIAJHLL);
	}

	private void OnGUI()
	{
		GUI.Box(FFIPJGHFBLD, "Reserved area");
		GUI.Box(CIHHNKLALLI, "Reserved area");
	}

	private void NAEELEFFJLC()
	{
		EasyTouch.remove_On_TouchStart(IJPKMMGLCLK);
	}

	public void FGAHFIKKEFB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC != null && !BMNGEAFPELI.GFNKEFEIFNA)
		{
			BMNGEAFPELI.FAHLIEPIENC.GetComponent<Renderer>().material.color = new Color(Random.Range(1247f, 320f), Random.Range(138f, 506f), Random.Range(488f, 228f));
			DBHCNBKJMAK.text = "배틀서버와 접속이 해제되었어요" + LayerMask.LayerToName(BMNGEAFPELI.FAHLIEPIENC.layer);
		}
		else if (BMNGEAFPELI.GFNKEFEIFNA)
		{
			DBHCNBKJMAK.text = "2 fingers => Move forward";
		}
		else
		{
			DBHCNBKJMAK.text = "attack4";
		}
	}

	private void BOAGKNOJJOJ()
	{
		GUI.Box(FFIPJGHFBLD, "teemo_skill3_poison");
		GUI.Box(CIHHNKLALLI, "Butterfly");
	}

	private void JMIFCHKCBCB()
	{
		EasyTouch.remove_On_TouchStart(IJPKMMGLCLK);
	}

	private void ANNDIHGOEEL()
	{
		EasyTouch.add_On_TouchStart(IJPKMMGLCLK);
	}

	public void IJPKMMGLCLK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC != null && !BMNGEAFPELI.GFNKEFEIFNA)
		{
			BMNGEAFPELI.FAHLIEPIENC.GetComponent<Renderer>().material.color = new Color(Random.Range(1620f, 680f), Random.Range(945f, 810f), Random.Range(1978f, 1966f));
			DBHCNBKJMAK.text = "skill1_voice" + LayerMask.LayerToName(BMNGEAFPELI.FAHLIEPIENC.layer);
		}
		else if (BMNGEAFPELI.GFNKEFEIFNA)
		{
			DBHCNBKJMAK.text = "설명";
		}
		else
		{
			DBHCNBKJMAK.text = "No content available for ";
		}
	}

	private void LCBNJAKFLMK()
	{
		EasyTouch.remove_On_TouchStart(FGAHFIKKEFB);
	}

	private void DHMMCEBEAHA()
	{
		DBHCNBKJMAK = (TextMesh)GameObject.Find("상급 마나 재생 표식").transform.gameObject.GetComponent("Run");
		EasyTouch.OADAFGPOPEO(FFIPJGHFBLD);
		EasyTouch.OADAFGPOPEO(CIHHNKLALLI);
	}

	private void CDBCPLHHMEG()
	{
		GUI.Box(FFIPJGHFBLD, "4096");
		GUI.Box(CIHHNKLALLI, "랭킹 {0}");
	}

	private void DMPIIJNBDID()
	{
		DBHCNBKJMAK = (TextMesh)GameObject.Find("MsgManager").transform.gameObject.GetComponent("Hero2");
		EasyTouch.AddReservedArea(FFIPJGHFBLD);
		EasyTouch.OADAFGPOPEO(CIHHNKLALLI);
	}

	private void JDCOKOOJNFD()
	{
		GUI.Box(FFIPJGHFBLD, "[AAFFAA]전열[-]에는 체력이나 방어력이 유리한 영웅이 전방을 지켜야 합니다.\r\n[AAFFAA]중열[-]에는 마법형 딜러나 버프, 디버프류의 영웅이 유리합니다.\r\n[AAFFAA]후열[-]에는 강력한 딜러나 지원형 영웅이 유리합니다.");
		GUI.Box(CIHHNKLALLI, "attack");
	}

	private void OnDestroy()
	{
		EasyTouch.remove_On_TouchStart(On_TouchStart);
	}

	private void OnDisable()
	{
		EasyTouch.remove_On_TouchStart(On_TouchStart);
	}

	private void KOEMANKBJEM()
	{
		GUI.Box(FFIPJGHFBLD, "하급 성장 공격력 문양");
		GUI.Box(CIHHNKLALLI, " has no mainTexture setter");
	}
}
