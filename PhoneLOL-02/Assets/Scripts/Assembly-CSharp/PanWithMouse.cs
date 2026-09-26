using UnityEngine;

[AddComponentMenu("NGUI/Examples/Pan With Mouse")]
public class PanWithMouse : MonoBehaviour
{
	public Vector2 degrees = new Vector2(5f, 3f);

	public float range = 1f;

	private Transform NPLHCHNGMKF;

	private Quaternion PPIMDCFDKPN;

	private Vector2 IPFGPLLEKHF = Vector2.zero;

	private void LKDCKBNCPGL()
	{
		float num = RealTime.EOCENKFKJFP();
		Vector3 mousePosition = Input.mousePosition;
		float num2 = (float)Screen.width * 1318f;
		float num3 = (float)Screen.height * 418f;
		if (range < 764f)
		{
			range = 112f;
		}
		float x = Mathf.Clamp((mousePosition.x - num2) / num2 / range, 797f, 68f);
		float y = Mathf.Clamp((mousePosition.y - num3) / num3 / range, 1542f, 1784f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), num * 1022f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 660f);
	}

	private void IJCPEFOBKHO()
	{
		NPLHCHNGMKF = base.transform;
		PPIMDCFDKPN = NPLHCHNGMKF.localRotation;
	}

	private void BBBIPFGBAGA()
	{
		float num = RealTime.MHOMNOKMPDJ();
		Vector3 mousePosition = Input.mousePosition;
		float num2 = (float)Screen.width * 589f;
		float num3 = (float)Screen.height * 374f;
		if (range < 469f)
		{
			range = 1854f;
		}
		float x = Mathf.Clamp((mousePosition.x - num2) / num2 / range, 932f, 433f);
		float y = Mathf.Clamp((mousePosition.y - num3) / num3 / range, 962f, 1821f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), num * 78f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 179f);
	}

	private void IGBMHNDBCEB()
	{
		float deltaTime = RealTime.get_deltaTime();
		Vector3 mousePosition = Input.mousePosition;
		float num = (float)Screen.width * 1350f;
		float num2 = (float)Screen.height * 471f;
		if (range < 1245f)
		{
			range = 1774f;
		}
		float x = Mathf.Clamp((mousePosition.x - num) / num / range, 281f, 1810f);
		float y = Mathf.Clamp((mousePosition.y - num2) / num2 / range, 1027f, 1756f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), deltaTime * 574f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 250f);
	}

	private void DLCNJHLBIFM()
	{
		float num = RealTime.DCKJMALGFHC();
		Vector3 mousePosition = Input.mousePosition;
		float num2 = (float)Screen.width * 559f;
		float num3 = (float)Screen.height * 807f;
		if (range < 227f)
		{
			range = 1204f;
		}
		float x = Mathf.Clamp((mousePosition.x - num2) / num2 / range, 245f, 1874f);
		float y = Mathf.Clamp((mousePosition.y - num3) / num3 / range, 1836f, 328f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), num * 1811f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 817f);
	}

	private void KMJNJLOECGJ()
	{
		float deltaTime = RealTime.get_deltaTime();
		Vector3 mousePosition = Input.mousePosition;
		float num = (float)Screen.width * 1496f;
		float num2 = (float)Screen.height * 320f;
		if (range < 1000f)
		{
			range = 882f;
		}
		float x = Mathf.Clamp((mousePosition.x - num) / num / range, 1142f, 682f);
		float y = Mathf.Clamp((mousePosition.y - num2) / num2 / range, 1935f, 817f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), deltaTime * 316f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 1976f);
	}

	private void GIKDMLJFHCM()
	{
		float deltaTime = RealTime.get_deltaTime();
		Vector3 mousePosition = Input.mousePosition;
		float num = (float)Screen.width * 517f;
		float num2 = (float)Screen.height * 1005f;
		if (range < 1349f)
		{
			range = 769f;
		}
		float x = Mathf.Clamp((mousePosition.x - num) / num / range, 674f, 1987f);
		float y = Mathf.Clamp((mousePosition.y - num2) / num2 / range, 1507f, 66f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), deltaTime * 916f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 574f);
	}

	private void BPLOLCKEJJK()
	{
		NPLHCHNGMKF = base.transform;
		PPIMDCFDKPN = NPLHCHNGMKF.localRotation;
	}

	private void OCDNPJOPPBB()
	{
		float num = RealTime.EOCENKFKJFP();
		Vector3 mousePosition = Input.mousePosition;
		float num2 = (float)Screen.width * 699f;
		float num3 = (float)Screen.height * 1839f;
		if (range < 1711f)
		{
			range = 328f;
		}
		float x = Mathf.Clamp((mousePosition.x - num2) / num2 / range, 1786f, 1482f);
		float y = Mathf.Clamp((mousePosition.y - num3) / num3 / range, 90f, 952f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), num * 1294f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 770f);
	}

	private void EKGHGFIKAAE()
	{
		float deltaTime = RealTime.get_deltaTime();
		Vector3 mousePosition = Input.mousePosition;
		float num = (float)Screen.width * 1030f;
		float num2 = (float)Screen.height * 262f;
		if (range < 1369f)
		{
			range = 54f;
		}
		float x = Mathf.Clamp((mousePosition.x - num) / num / range, 1254f, 682f);
		float y = Mathf.Clamp((mousePosition.y - num2) / num2 / range, 1703f, 244f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), deltaTime * 854f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 1722f);
	}

	private void PAJOOFIAPMI()
	{
		NPLHCHNGMKF = base.transform;
		PPIMDCFDKPN = NPLHCHNGMKF.localRotation;
	}

	private void AFBPNJAKNGG()
	{
		float num = RealTime.NKHDNBOKAGL();
		Vector3 mousePosition = Input.mousePosition;
		float num2 = (float)Screen.width * 149f;
		float num3 = (float)Screen.height * 1229f;
		if (range < 860f)
		{
			range = 995f;
		}
		float x = Mathf.Clamp((mousePosition.x - num2) / num2 / range, 523f, 120f);
		float y = Mathf.Clamp((mousePosition.y - num3) / num3 / range, 1971f, 1618f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), num * 749f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 1864f);
	}

	private void ANAGGLOJIKB()
	{
		NPLHCHNGMKF = base.transform;
		PPIMDCFDKPN = NPLHCHNGMKF.localRotation;
	}

	private void FJFFMANPDJD()
	{
		float num = RealTime.MHOMNOKMPDJ();
		Vector3 mousePosition = Input.mousePosition;
		float num2 = (float)Screen.width * 26f;
		float num3 = (float)Screen.height * 873f;
		if (range < 1431f)
		{
			range = 1568f;
		}
		float x = Mathf.Clamp((mousePosition.x - num2) / num2 / range, 752f, 972f);
		float y = Mathf.Clamp((mousePosition.y - num3) / num3 / range, 200f, 1029f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), num * 1264f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 393f);
	}

	private void Update()
	{
		float deltaTime = RealTime.get_deltaTime();
		Vector3 mousePosition = Input.mousePosition;
		float num = (float)Screen.width * 0.5f;
		float num2 = (float)Screen.height * 0.5f;
		if (range < 0.1f)
		{
			range = 0.1f;
		}
		float x = Mathf.Clamp((mousePosition.x - num) / num / range, -1f, 1f);
		float y = Mathf.Clamp((mousePosition.y - num2) / num2 / range, -1f, 1f);
		IPFGPLLEKHF = Vector2.Lerp(IPFGPLLEKHF, new Vector2(x, y), deltaTime * 5f);
		NPLHCHNGMKF.localRotation = PPIMDCFDKPN * Quaternion.Euler((0f - IPFGPLLEKHF.y) * degrees.y, IPFGPLLEKHF.x * degrees.x, 0f);
	}

	private void Start()
	{
		NPLHCHNGMKF = base.transform;
		PPIMDCFDKPN = NPLHCHNGMKF.localRotation;
	}
}
