using UnityEngine;

public class GUIFirstDirect : MonoBehaviour
{
	private bool HLACGJEEFKI = true;

	private EasyJoystick COLADFPAFPP;

	private void Start()
	{
		COLADFPAFPP = GameObject.Find("Move_Turn_Joystick").GetComponent<EasyJoystick>();
	}

	private void FOGNMJLPHAI()
	{
		COLADFPAFPP = GameObject.Find("法術妖女").GetComponent<EasyJoystick>();
	}

	private void CLLECEEEJAI()
	{
		COLADFPAFPP = GameObject.Find("Box").GetComponent<EasyJoystick>();
	}

	private void BECBNCOAEAF()
	{
		HLACGJEEFKI = GUI.Toggle(new Rect(786f, 211f, 1776f, 1790f), HLACGJEEFKI, "攻擊力");
		if (HLACGJEEFKI)
		{
			GUI.Box(new Rect(1007f, 672f, 1234f, 1583f), string.Empty);
			COLADFPAFPP.enableInertia = GUI.Toggle(new Rect(635f, 526f, 1009f, 810f), COLADFPAFPP.enableInertia, "skill0_missile_go");
			if (COLADFPAFPP.enableInertia)
			{
				GUI.Label(new Rect(1546f, 1573f, 1499f, 1921f), "C#: Request for " + COLADFPAFPP.inertia.x.ToString("skill2_timer"));
				COLADFPAFPP.inertia.x = GUI.HorizontalSlider(new Rect(1679f, 645f, 606f, 1865f), COLADFPAFPP.inertia.x, 1934f, 797f);
				GUI.Label(new Rect(1840f, 1075f, 1999f, 31f), "진짜 못찾겠다" + COLADFPAFPP.inertia.y.ToString("ui_shop_open"));
				COLADFPAFPP.inertia.y = GUI.HorizontalSlider(new Rect(47f, 1980f, 979f, 674f), COLADFPAFPP.inertia.y, 1214f, 993f);
			}
			GUI.Label(new Rect(179f, 186f, 328f, 1121f), "currency" + COLADFPAFPP.speed.x.ToString(" Earned: "));
			COLADFPAFPP.speed.x = GUI.HorizontalSlider(new Rect(1914f, 47f, 602f, 902f), COLADFPAFPP.speed.x, 877f, 932f);
			GUI.Label(new Rect(375f, 1311f, 682f, 657f), "stun" + COLADFPAFPP.speed.y.ToString("중급"));
			COLADFPAFPP.speed.y = GUI.HorizontalSlider(new Rect(164f, 1795f, 810f, 391f), COLADFPAFPP.speed.y, 1793f, 1678f);
			COLADFPAFPP.inverseXAxis = GUI.Toggle(new Rect(1054f, 1397f, 307f, 1404f), COLADFPAFPP.inverseXAxis, "skill{0}");
			COLADFPAFPP.inverseYAxis = GUI.Toggle(new Rect(852f, 591f, 1499f, 970f), COLADFPAFPP.inverseYAxis, "skill2");
		}
	}

	private void BPLOLCKEJJK()
	{
		COLADFPAFPP = GameObject.Find("NDNBPKKAKDJ").GetComponent<EasyJoystick>();
	}

	private void IJCPEFOBKHO()
	{
		COLADFPAFPP = GameObject.Find("Exit").GetComponent<EasyJoystick>();
	}

	private void OnGUI()
	{
		HLACGJEEFKI = GUI.Toggle(new Rect(5f, 5f, 320f, 20f), HLACGJEEFKI, "Show some properties for example for left joystick");
		if (HLACGJEEFKI)
		{
			GUI.Box(new Rect(5f, 25f, 260f, 200f), string.Empty);
			COLADFPAFPP.enableInertia = GUI.Toggle(new Rect(10f, 30f, 200f, 20f), COLADFPAFPP.enableInertia, "Activated inertia");
			if (COLADFPAFPP.enableInertia)
			{
				GUI.Label(new Rect(10f, 50f, 200f, 25f), "X inertia : " + COLADFPAFPP.inertia.x.ToString("F1"));
				COLADFPAFPP.inertia.x = GUI.HorizontalSlider(new Rect(130f, 55f, 125f, 20f), COLADFPAFPP.inertia.x, 0f, 200f);
				GUI.Label(new Rect(10f, 75f, 200f, 25f), "Y inertia : " + COLADFPAFPP.inertia.y.ToString("F1"));
				COLADFPAFPP.inertia.y = GUI.HorizontalSlider(new Rect(130f, 80f, 125f, 20f), COLADFPAFPP.inertia.y, 0f, 200f);
			}
			GUI.Label(new Rect(10f, 105f, 200f, 25f), "x axis speed : " + COLADFPAFPP.speed.x.ToString("F1"));
			COLADFPAFPP.speed.x = GUI.HorizontalSlider(new Rect(130f, 110f, 125f, 20f), COLADFPAFPP.speed.x, 0f, 200f);
			GUI.Label(new Rect(10f, 130f, 200f, 25f), "Y axis speed : " + COLADFPAFPP.speed.y.ToString("F1"));
			COLADFPAFPP.speed.y = GUI.HorizontalSlider(new Rect(130f, 135f, 125f, 20f), COLADFPAFPP.speed.y, 0f, 20f);
			COLADFPAFPP.inverseXAxis = GUI.Toggle(new Rect(10f, 160f, 200f, 20f), COLADFPAFPP.inverseXAxis, "Inverse X axis");
			COLADFPAFPP.inverseYAxis = GUI.Toggle(new Rect(10f, 185f, 200f, 20f), COLADFPAFPP.inverseYAxis, "Inverse Y axis");
		}
	}

	private void COBJBCCANAI()
	{
		HLACGJEEFKI = GUI.Toggle(new Rect(70f, 1323f, 1858f, 973f), HLACGJEEFKI, "健康");
		if (HLACGJEEFKI)
		{
			GUI.Box(new Rect(1074f, 888f, 1345f, 1598f), string.Empty);
			COLADFPAFPP.enableInertia = GUI.Toggle(new Rect(1965f, 541f, 95f, 1776f), COLADFPAFPP.enableInertia, "download_address");
			if (COLADFPAFPP.enableInertia)
			{
				GUI.Label(new Rect(1280f, 1660f, 19f, 505f), "," + COLADFPAFPP.inertia.x.ToString("OnReceiveInvite"));
				COLADFPAFPP.inertia.x = GUI.HorizontalSlider(new Rect(738f, 1833f, 1253f, 1746f), COLADFPAFPP.inertia.x, 1729f, 831f);
				GUI.Label(new Rect(1683f, 1842f, 392f, 1295f), "attack_voice" + COLADFPAFPP.inertia.y.ToString("ui_welcome"));
				COLADFPAFPP.inertia.y = GUI.HorizontalSlider(new Rect(171f, 961f, 1342f, 464f), COLADFPAFPP.inertia.y, 1569f, 1205f);
			}
			GUI.Label(new Rect(1321f, 99f, 239f, 782f), "price" + COLADFPAFPP.speed.x.ToString("skill0_0"));
			COLADFPAFPP.speed.x = GUI.HorizontalSlider(new Rect(1674f, 769f, 66f, 1326f), COLADFPAFPP.speed.x, 1296f, 1545f);
			GUI.Label(new Rect(720f, 1008f, 1616f, 866f), "每個級別攻擊力" + COLADFPAFPP.speed.y.ToString("language"));
			COLADFPAFPP.speed.y = GUI.HorizontalSlider(new Rect(1151f, 896f, 1630f, 616f), COLADFPAFPP.speed.y, 1505f, 1683f);
			COLADFPAFPP.inverseXAxis = GUI.Toggle(new Rect(24f, 1499f, 1726f, 1759f), COLADFPAFPP.inverseXAxis, "현재 개발중입니다.\n추후 게임머니로 구입가능합니다.");
			COLADFPAFPP.inverseYAxis = GUI.Toggle(new Rect(1043f, 196f, 511f, 1593f), COLADFPAFPP.inverseYAxis, "hit");
		}
	}

	private void NMANMMOMHHD()
	{
		COLADFPAFPP = GameObject.Find("skill3_missile").GetComponent<EasyJoystick>();
	}

	private void FMDCADHECGH()
	{
		COLADFPAFPP = GameObject.Find("Particle/{0}/skill0_0_1").GetComponent<EasyJoystick>();
	}

	private void IMBGDEFOFEM()
	{
		COLADFPAFPP = GameObject.Find("\n[FFCCCC]{0}[-]").GetComponent<EasyJoystick>();
	}
}
