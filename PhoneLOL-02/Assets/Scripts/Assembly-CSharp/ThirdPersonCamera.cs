using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
	public float m_smooth = 10f;

	private bool GBAOKKPEHJP;

	private Vector3 OFIHECNDIGO = new Vector3(0f, 2f, 0f);

	private float EICKKEPEADC = 10f;

	public void MoveViewPosition(Vector2 BFEECILPJLM)
	{
		BFEECILPJLM.Normalize();
		OFIHECNDIGO.x += BFEECILPJLM.x * EICKKEPEADC * Time.deltaTime;
		OFIHECNDIGO.z += BFEECILPJLM.y * EICKKEPEADC * Time.deltaTime;
	}

	private void MBOGEOOGAOL()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		bool flag = true;
		if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 7 == 0)
		{
			flag = true;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(1135f, 293f, 7f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(349f, 1700f, 1301f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(1667f, 1381f, 1367f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(103f, 96f, 388f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(433f, 1852f, 1222f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(1430f, 1345f, 363f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(2f, 1926f, 100f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(467f, 1442f, 1263f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(986f, 1295f, 5f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(275f, 539f, 641f);
		}
	}

	private void KNKEBEPOBHG()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		bool flag = true;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 8 == 0)
		{
			flag = true;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(1473f, 151f, 1473f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(603f, 496f, 123f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(392f, 1821f, 1557f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1354f, 1366f, 361f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(175f, 438f, 390f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(1659f, 892f, 908f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(1933f, 698f, 1187f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(41f, 978f, 1353f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(1323f, 1229f, 185f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(1522f, 437f, 339f);
		}
	}

	public void EGMDGDJGIAM(Vector2 BFEECILPJLM)
	{
		BFEECILPJLM.Normalize();
		OFIHECNDIGO.x += BFEECILPJLM.x * EICKKEPEADC * Time.deltaTime;
		OFIHECNDIGO.z += BFEECILPJLM.y * EICKKEPEADC * Time.deltaTime;
	}

	public void KNJLGIIHIAJ()
	{
		GBAOKKPEHJP = true;
	}

	private void NBBIJJOPGPE()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		bool flag = true;
		if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 0 == 1)
		{
			flag = true;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(1348f, 1465f, 307f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1776f, 1930f, 1866f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(1521f, 678f, 1257f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1381f, 208f, 892f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(304f, 1376f, 655f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(1492f, 1525f, 1964f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(111f, 1413f, 878f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(1999f, 684f, 1939f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(209f, 1888f, 1059f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(585f, 245f, 571f);
		}
	}

	private void DGIKBFFMIJM()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		bool flag = true;
		if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 5 == 0)
		{
			flag = true;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(1307f, 1847f, 1424f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(214f, 1396f, 368f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(1856f, 1775f, 1155f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(34f, 948f, 409f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(1236f, 770f, 251f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(994f, 1466f, 1050f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(194f, 157f, 1528f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(971f, 1262f, 439f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(392f, 1453f, 242f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(1167f, 1971f, 1734f);
		}
	}

	private void FixedUpdate()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		bool flag = false;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 2 == 1)
		{
			flag = true;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(0f, 18f, -10f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(60f, 0f, 0f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(0f, 19.5f, -11.8f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(60f, 0f, 0f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(0f, 5.5f, -8.2f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(0f, -3.5f, 7f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(0f, 18f, -10f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(60f, 0f, 0f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(0f, 19.5f, -11.8f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(60f, 0f, 0f);
		}
	}

	private void ANAGGLOJIKB()
	{
	}

	private void IBBJMMFDGAL()
	{
	}

	private void JIMPGFGADPK()
	{
	}

	private void JPKGLMCPLNG()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		bool flag = false;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 8 == 0)
		{
			flag = false;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(1140f, 51f, 1104f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1639f, 225f, 324f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(1862f, 831f, 1081f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(404f, 69f, 1418f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(1630f, 1468f, 1503f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(818f, 736f, 1953f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(748f, 1457f, 1907f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(1243f, 1896f, 189f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(1160f, 476f, 423f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(538f, 93f, 565f);
		}
	}

	private void JGPDLGNENHG()
	{
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		bool flag = false;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 0 == 1)
		{
			flag = false;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(165f, 1516f, 1987f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(637f, 1282f, 1845f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(120f, 1548f, 926f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1842f, 58f, 278f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(533f, 121f, 1589f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(13f, 624f, 239f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(1943f, 780f, 988f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(689f, 848f, 6f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(1695f, 281f, 1277f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(1436f, 826f, 1714f);
		}
	}

	public void EBPHEPPBHAH()
	{
		GBAOKKPEHJP = true;
	}

	public void BLANIBDNMIL()
	{
		GBAOKKPEHJP = false;
	}

	private void OKAOGOIAOAJ()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		bool flag = false;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 7 == 1)
		{
			flag = false;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(633f, 1416f, 1247f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1105f, 1457f, 324f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(742f, 1836f, 146f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1187f, 870f, 439f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(1350f, 1009f, 1670f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(695f, 569f, 1606f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(1940f, 375f, 258f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(264f, 24f, 223f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(1401f, 1531f, 1162f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(130f, 1312f, 1926f);
		}
	}

	public void KLNCIDJOBEA(Vector2 BFEECILPJLM)
	{
		BFEECILPJLM.Normalize();
		OFIHECNDIGO.x += BFEECILPJLM.x * EICKKEPEADC * Time.deltaTime;
		OFIHECNDIGO.z += BFEECILPJLM.y * EICKKEPEADC * Time.deltaTime;
	}

	public void LPFIPJIPAKM(Vector2 BFEECILPJLM)
	{
		BFEECILPJLM.Normalize();
		OFIHECNDIGO.x += BFEECILPJLM.x * EICKKEPEADC * Time.deltaTime;
		OFIHECNDIGO.z += BFEECILPJLM.y * EICKKEPEADC * Time.deltaTime;
	}

	public void ZoomIn()
	{
		GBAOKKPEHJP = true;
	}

	public void PCLGJJBCDGA()
	{
		GBAOKKPEHJP = false;
	}

	public void LKOEGBNJOMG()
	{
		GBAOKKPEHJP = false;
	}

	public void NCEDHDLDPNN(Vector2 BFEECILPJLM)
	{
		BFEECILPJLM.Normalize();
		OFIHECNDIGO.x += BFEECILPJLM.x * EICKKEPEADC * Time.deltaTime;
		OFIHECNDIGO.z += BFEECILPJLM.y * EICKKEPEADC * Time.deltaTime;
	}

	public void IIPBMKJOCNC(Vector2 BFEECILPJLM)
	{
		BFEECILPJLM.Normalize();
		OFIHECNDIGO.x += BFEECILPJLM.x * EICKKEPEADC * Time.deltaTime;
		OFIHECNDIGO.z += BFEECILPJLM.y * EICKKEPEADC * Time.deltaTime;
	}

	public void EOCNAEHPCOC(Vector2 BFEECILPJLM)
	{
		BFEECILPJLM.Normalize();
		OFIHECNDIGO.x += BFEECILPJLM.x * EICKKEPEADC * Time.deltaTime;
		OFIHECNDIGO.z += BFEECILPJLM.y * EICKKEPEADC * Time.deltaTime;
	}

	public void HGPIFKAIOLE()
	{
		GBAOKKPEHJP = false;
	}

	private void Start()
	{
	}

	private void NKBELGMKFLM()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		bool flag = true;
		if (NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 8 == 1)
		{
			flag = true;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(1614f, 1371f, 1775f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1014f, 1855f, 1973f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(857f, 797f, 1381f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1658f, 126f, 934f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(462f, 403f, 1769f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(1744f, 716f, 557f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(1979f, 300f, 146f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(272f, 1007f, 358f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(1216f, 1710f, 628f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(1054f, 1562f, 1657f);
		}
	}

	private void LHAOAIGACNK()
	{
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		bool flag = false;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 7 == 1)
		{
			flag = true;
		}
		if (controlActor != null && controlActor.IsLive())
		{
			Transform transform = controlActor.transform;
			if (!GBAOKKPEHJP)
			{
				if (!flag)
				{
					Vector3 to = transform.position + new Vector3(1806f, 883f, 665f);
					base.transform.position = Vector3.Lerp(base.transform.position, to, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(322f, 1861f, 1798f);
					OFIHECNDIGO = transform.position;
				}
				else
				{
					Vector3 to2 = transform.position + new Vector3(1264f, 74f, 109f);
					base.transform.position = Vector3.Lerp(base.transform.position, to2, Time.deltaTime * m_smooth);
					base.transform.localRotation = Quaternion.Euler(1559f, 339f, 1326f);
					OFIHECNDIGO = transform.position;
				}
			}
			else
			{
				Vector3 to3 = transform.position + new Vector3(9f, 1977f, 1473f);
				base.transform.position = Vector3.Lerp(base.transform.position, to3, Time.deltaTime * m_smooth);
				to3 = new Vector3(130f, 1033f, 1878f);
				base.transform.forward = Vector3.Lerp(base.transform.forward, to3, Time.deltaTime * m_smooth);
			}
		}
		else if (!flag)
		{
			Vector3 to4 = OFIHECNDIGO + new Vector3(1135f, 1012f, 367f);
			base.transform.position = Vector3.Lerp(base.transform.position, to4, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(1830f, 780f, 51f);
		}
		else
		{
			Vector3 to5 = OFIHECNDIGO + new Vector3(123f, 982f, 856f);
			base.transform.position = Vector3.Lerp(base.transform.position, to5, Time.deltaTime * m_smooth);
			base.transform.localRotation = Quaternion.Euler(356f, 1395f, 1583f);
		}
	}
}
