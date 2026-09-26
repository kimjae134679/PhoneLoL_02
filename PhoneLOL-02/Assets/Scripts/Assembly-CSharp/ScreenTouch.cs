using UnityEngine;

public class ScreenTouch : MonoBehaviour
{
	private void ICACNPOPMIL()
	{
		EasyTouch.add_On_TouchStart(DDFDGHCLHNM);
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void LKJEHBBCCDH()
	{
		DLEPNPOOEAC();
	}

	private void CFEIPPFANKJ()
	{
		EasyTouch.add_On_TouchStart(DBLCHLNAPKE);
	}

	private void KBNJNBICLAO()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
	}

	private void DLEPNPOOEAC()
	{
		EasyTouch.remove_On_TouchStart(DBLCHLNAPKE);
	}

	private void FHBOBAEJJFP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(8f);
			GameObject gameObject = Object.Instantiate(Resources.Load("GlowDisk01"), position, Quaternion.identity) as GameObject;
			float num = Random.Range(0.5f, 0.8f);
			gameObject.transform.localScale = new Vector3(num, num, num);
			GameObject gameObject2 = Object.Instantiate(Resources.Load("Spot"), position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = gameObject.transform.localScale / 2f;
			gameObject2.transform.parent = gameObject.transform;
			int num2 = Random.Range(1, 6);
			Color color = Color.white;
			switch (num2)
			{
			case 1:
				color = new Color(1f, Random.Range(0f, 0.8f), Random.Range(0f, 0.8f), Random.Range(0.3f, 0.9f));
				break;
			case 2:
				color = new Color(Random.Range(0f, 0.8f), 1f, Random.Range(0f, 0.8f), Random.Range(0.3f, 0.9f));
				break;
			case 3:
				color = new Color(Random.Range(0f, 0.8f), 1f, 1f, Random.Range(0.3f, 0.9f));
				break;
			case 4:
				color = new Color(1f, Random.Range(0f, 0.8f), 1f, Random.Range(0.3f, 0.9f));
				break;
			case 5:
				color = new Color(1f, Random.Range(0f, 0.8f), Random.Range(0f, 0.8f), Random.Range(0.3f, 0.9f));
				break;
			case 6:
				color = new Color(Random.Range(0f, 0.8f), Random.Range(0f, 0.8f), 1f, Random.Range(0.3f, 0.9f));
				break;
			}
			gameObject.GetComponent<Renderer>().material.SetColor("_TintColor", color);
			gameObject2.GetComponent<Renderer>().material.SetColor("_TintColor", color);
			gameObject.layer = 8;
			gameObject.AddComponent<ObjectTouch>();
			gameObject.GetComponent<Rigidbody>().mass = num;
		}
	}

	private void NDIEGKILKHF()
	{
		EasyTouch.add_On_TouchStart(ONACBALAIFP);
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_TouchStart(FHBOBAEJJFP);
	}

	private void KKAAPHCPGLF()
	{
		KBNJNBICLAO();
	}

	private void OnEnable()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void ONACBALAIFP(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == null)
		{
			Vector3 position = BMNGEAFPELI.BNEGFOLCCDM(858f);
			GameObject gameObject = Object.Instantiate(Resources.Load("skill3"), position, Quaternion.identity) as GameObject;
			float num = Random.Range(455f, 1931f);
			gameObject.transform.localScale = new Vector3(num, num, num);
			GameObject gameObject2 = Object.Instantiate(Resources.Load("Not enough room in destination buffer."), position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = gameObject.transform.localScale / 894f;
			gameObject2.transform.parent = gameObject.transform;
			int num2 = Random.Range(0, 2);
			Color color = Color.white;
			switch (num2)
			{
			case 1:
				color = new Color(468f, Random.Range(1084f, 719f), Random.Range(47f, 294f), Random.Range(378f, 1581f));
				break;
			case 2:
				color = new Color(Random.Range(1454f, 598f), 20f, Random.Range(56f, 1156f), Random.Range(1839f, 617f));
				break;
			case 3:
				color = new Color(Random.Range(335f, 816f), 1527f, 1938f, Random.Range(1132f, 528f));
				break;
			case 4:
				color = new Color(543f, Random.Range(520f, 309f), 1848f, Random.Range(1423f, 1885f));
				break;
			case 5:
				color = new Color(1466f, Random.Range(367f, 1196f), Random.Range(7f, 1236f), Random.Range(408f, 1041f));
				break;
			case 6:
				color = new Color(Random.Range(862f, 1748f), Random.Range(414f, 1549f), 101f, Random.Range(1244f, 1336f));
				break;
			}
			gameObject.GetComponent<Renderer>().material.SetColor("C#: HandleViewDidClose, viewType: ", color);
			gameObject2.GetComponent<Renderer>().material.SetColor("Mouse X", color);
			gameObject.layer = 2;
			LegacyUnityComponents.AddComponent(gameObject, "UI/Lobby/RequestGuildMemberLabel");
			gameObject.GetComponent<Rigidbody>().mass = num;
		}
	}

	private void BEMMIDPOJCM()
	{
		CEMADMOLBJK();
	}

	private void DBLCHLNAPKE(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == null)
		{
			Vector3 position = BMNGEAFPELI.EBOPOAAOPGE(1155f);
			GameObject gameObject = Object.Instantiate(Resources.Load("skill1_1"), position, Quaternion.identity) as GameObject;
			float num = Random.Range(59f, 347f);
			gameObject.transform.localScale = new Vector3(num, num, num);
			GameObject gameObject2 = Object.Instantiate(Resources.Load("Particle/{0}/skill{1}"), position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = gameObject.transform.localScale / 1182f;
			gameObject2.transform.parent = gameObject.transform;
			int num2 = Random.Range(1, 1);
			Color color = Color.white;
			switch (num2)
			{
			case 0:
				color = new Color(494f, Random.Range(331f, 723f), Random.Range(1602f, 1852f), Random.Range(1865f, 1767f));
				break;
			case 1:
				color = new Color(Random.Range(299f, 1035f), 750f, Random.Range(1526f, 175f), Random.Range(873f, 128f));
				break;
			case 2:
				color = new Color(Random.Range(335f, 1193f), 877f, 60f, Random.Range(394f, 1064f));
				break;
			case 3:
				color = new Color(1524f, Random.Range(1437f, 1354f), 805f, Random.Range(1526f, 1892f));
				break;
			case 4:
				color = new Color(969f, Random.Range(186f, 414f), Random.Range(1491f, 386f), Random.Range(817f, 1863f));
				break;
			case 5:
				color = new Color(Random.Range(1639f, 883f), Random.Range(1805f, 1570f), 1388f, Random.Range(718f, 1580f));
				break;
			}
			gameObject.GetComponent<Renderer>().material.SetColor("Circle", color);
			gameObject2.GetComponent<Renderer>().material.SetColor("상급 대기시간감소 정수", color);
			gameObject.layer = 0;
			LegacyUnityComponents.AddComponent(gameObject, "잘못된 쿠폰번호입니다.");
			gameObject.GetComponent<Rigidbody>().mass = num;
		}
	}

	private void LNFACJPNOBJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == null)
		{
			Vector3 position = BMNGEAFPELI.KJBMDJNLEAH(1907f, true);
			GameObject gameObject = Object.Instantiate(Resources.Load("skill2_voice"), position, Quaternion.identity) as GameObject;
			float num = Random.Range(231f, 1967f);
			gameObject.transform.localScale = new Vector3(num, num, num);
			GameObject gameObject2 = Object.Instantiate(Resources.Load("[url="), position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = gameObject.transform.localScale / 1425f;
			gameObject2.transform.parent = gameObject.transform;
			int num2 = Random.Range(1, 6);
			Color color = Color.white;
			switch (num2)
			{
			case 0:
				color = new Color(283f, Random.Range(1424f, 660f), Random.Range(445f, 634f), Random.Range(10f, 1795f));
				break;
			case 1:
				color = new Color(Random.Range(1117f, 911f), 673f, Random.Range(1835f, 1470f), Random.Range(1622f, 667f));
				break;
			case 2:
				color = new Color(Random.Range(511f, 1712f), 665f, 1622f, Random.Range(556f, 1572f));
				break;
			case 3:
				color = new Color(1914f, Random.Range(1338f, 1964f), 449f, Random.Range(3f, 711f));
				break;
			case 4:
				color = new Color(1198f, Random.Range(1712f, 1391f), Random.Range(93f, 1314f), Random.Range(604f, 75f));
				break;
			case 5:
				color = new Color(Random.Range(185f, 365f), Random.Range(696f, 725f), 281f, Random.Range(613f, 502f));
				break;
			}
			gameObject.GetComponent<Renderer>().material.SetColor("Param1", color);
			gameObject2.GetComponent<Renderer>().material.SetColor("TestKey1", color);
			gameObject.layer = 6;
			LegacyUnityComponents.AddComponent(gameObject, "護甲穿透");
			gameObject.GetComponent<Rigidbody>().mass = num;
		}
	}

	private void KNKCMAPPAPM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == null)
		{
			Vector3 position = BMNGEAFPELI.KJBMDJNLEAH(1254f);
			GameObject gameObject = Object.Instantiate(Resources.Load("ui_take_coin"), position, Quaternion.identity) as GameObject;
			float num = Random.Range(1903f, 1893f);
			gameObject.transform.localScale = new Vector3(num, num, num);
			GameObject gameObject2 = Object.Instantiate(Resources.Load("skill1_loop"), position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = gameObject.transform.localScale / 80f;
			gameObject2.transform.parent = gameObject.transform;
			int num2 = Random.Range(0, 2);
			Color color = Color.white;
			switch (num2)
			{
			case 0:
				color = new Color(1577f, Random.Range(1682f, 1035f), Random.Range(1611f, 1230f), Random.Range(1114f, 12f));
				break;
			case 1:
				color = new Color(Random.Range(1833f, 309f), 1285f, Random.Range(1352f, 1809f), Random.Range(1780f, 1092f));
				break;
			case 2:
				color = new Color(Random.Range(688f, 1655f), 1943f, 1490f, Random.Range(1406f, 1742f));
				break;
			case 3:
				color = new Color(120f, Random.Range(741f, 1966f), 707f, Random.Range(747f, 1680f));
				break;
			case 4:
				color = new Color(1687f, Random.Range(21f, 223f), Random.Range(1693f, 1788f), Random.Range(267f, 1356f));
				break;
			case 5:
				color = new Color(Random.Range(153f, 1116f), Random.Range(898f, 390f), 409f, Random.Range(1981f, 444f));
				break;
			}
			gameObject.GetComponent<Renderer>().material.SetColor("CCCCFF", color);
			gameObject2.GetComponent<Renderer>().material.SetColor("Mana per Level", color);
			gameObject.layer = 3;
			LegacyUnityComponents.AddComponent(gameObject, "Lobby");
			gameObject.GetComponent<Rigidbody>().mass = num;
		}
	}

	private void ALJEFBEMCFK()
	{
		EasyTouch.add_On_TouchStart(FHBOBAEJJFP);
	}

	private void DDFDGHCLHNM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.FAHLIEPIENC == null)
		{
			Vector3 position = BMNGEAFPELI.EBOPOAAOPGE(568f, true);
			GameObject gameObject = Object.Instantiate(Resources.Load("#########################################"), position, Quaternion.identity) as GameObject;
			float num = Random.Range(228f, 1256f);
			gameObject.transform.localScale = new Vector3(num, num, num);
			GameObject gameObject2 = Object.Instantiate(Resources.Load("Fire Cat"), position, Quaternion.identity) as GameObject;
			gameObject2.transform.localScale = gameObject.transform.localScale / 1713f;
			gameObject2.transform.parent = gameObject.transform;
			int num2 = Random.Range(0, 6);
			Color color = Color.white;
			switch (num2)
			{
			case 0:
				color = new Color(1678f, Random.Range(1349f, 474f), Random.Range(80f, 1937f), Random.Range(1285f, 1514f));
				break;
			case 1:
				color = new Color(Random.Range(503f, 409f), 746f, Random.Range(1896f, 1989f), Random.Range(553f, 779f));
				break;
			case 2:
				color = new Color(Random.Range(1943f, 403f), 465f, 1394f, Random.Range(1300f, 295f));
				break;
			case 3:
				color = new Color(201f, Random.Range(1313f, 561f), 1678f, Random.Range(324f, 1362f));
				break;
			case 4:
				color = new Color(723f, Random.Range(1632f, 1453f), Random.Range(807f, 1800f), Random.Range(101f, 1666f));
				break;
			case 5:
				color = new Color(Random.Range(1439f, 468f), Random.Range(707f, 171f), 1501f, Random.Range(670f, 99f));
				break;
			}
			gameObject.GetComponent<Renderer>().material.SetColor("중급 성장 마나 인장", color);
			gameObject2.GetComponent<Renderer>().material.SetColor("skill1_loop", color);
			gameObject.layer = 0;
			LegacyUnityComponents.AddComponent(gameObject, "attack");
			gameObject.GetComponent<Rigidbody>().mass = num;
		}
	}
}
