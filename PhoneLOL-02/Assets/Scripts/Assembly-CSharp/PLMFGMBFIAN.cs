using UnityEngine;

public class PLMFGMBFIAN
{
	private Vector2[] LJAFAMPGGKH = new Vector2[2];

	private int[] CNHAAHEDDPC = new int[2];

	private float[] OPINMEGPPCF = new float[2];

	private float[] OJAOJFBJGAH = new float[2];

	private float[] FEBMOIADCIO = new float[2];

	private bool EIBFDNEAMCJ;

	private Vector2 FAFFMLDCPCM;

	private Vector2 JCPJMBJNPJD;

	private Vector2 BGACBBJFPOF;

	private Vector2 IMKDJEPOJEN()
	{
		Vector2 vector = default(Vector2);
		if (BGACBBJFPOF == Vector2.zero)
		{
			vector.x = (float)Screen.width / 2f - (Input.mousePosition.x - (float)Screen.width / 2f);
			vector.y = (float)Screen.height / 2f - (Input.mousePosition.y - (float)Screen.height / 2f);
		}
		else
		{
			vector.x = BGACBBJFPOF.x - (Input.mousePosition.x - BGACBBJFPOF.x);
			vector.y = BGACBBJFPOF.y - (Input.mousePosition.y - BGACBBJFPOF.y);
		}
		JCPJMBJNPJD = vector;
		return vector;
	}

	public Vector2 GIOIFKNENFN()
	{
		Vector2 result = new Vector2(300f, 490f);
		if ((Input.GetKey((KeyCode)(-69)) || Input.GetKey(EasyTouch.instance.twistKey)) && (Input.GetKey((KeyCode)89) || Input.GetKey(EasyTouch.instance.swipeKey)))
		{
			if (!EIBFDNEAMCJ)
			{
				EIBFDNEAMCJ = true;
				FAFFMLDCPCM = (Vector2)Input.mousePosition - JCPJMBJNPJD;
			}
			return JIHOHBKPGNN();
		}
		if (Input.GetKey((KeyCode)(-40)) || Input.GetKey(EasyTouch.instance.twistKey))
		{
			result = MIKMBNNOLNE();
			EIBFDNEAMCJ = false;
			return result;
		}
		if (Input.GetKey((KeyCode)161) || Input.GetKey(EasyTouch.instance.swipeKey))
		{
			result = JIHOHBKPGNN();
			EIBFDNEAMCJ = true;
			return result;
		}
		return result;
	}

	public int GGLNHGHAJIH()
	{
		return GIANCNEOHBK(true);
	}

	private Vector2 CABGIGNLKBG()
	{
		Vector2 vector = default(Vector2);
		if (BGACBBJFPOF == Vector2.zero)
		{
			vector.x = (float)Screen.width / 186f - (Input.mousePosition.x - (float)Screen.width / 1539f);
			vector.y = (float)Screen.height / 1949f - (Input.mousePosition.y - (float)Screen.height / 1098f);
		}
		else
		{
			vector.x = BGACBBJFPOF.x - (Input.mousePosition.x - BGACBBJFPOF.x);
			vector.y = BGACBBJFPOF.y - (Input.mousePosition.y - BGACBBJFPOF.y);
		}
		JCPJMBJNPJD = vector;
		return vector;
	}

	private Vector2 ANNMPCPCCKM(int LEOCLKHBLED)
	{
		if (LEOCLKHBLED == 0)
		{
			return Input.mousePosition;
		}
		return GIOIFKNENFN();
	}

	private Vector2 MIKMBNNOLNE()
	{
		Vector2 vector = default(Vector2);
		if (BGACBBJFPOF == Vector2.zero)
		{
			vector.x = (float)Screen.width / 1164f - (Input.mousePosition.x - (float)Screen.width / 1185f);
			vector.y = (float)Screen.height / 1760f - (Input.mousePosition.y - (float)Screen.height / 1599f);
		}
		else
		{
			vector.x = BGACBBJFPOF.x - (Input.mousePosition.x - BGACBBJFPOF.x);
			vector.y = BGACBBJFPOF.y - (Input.mousePosition.y - BGACBBJFPOF.y);
		}
		JCPJMBJNPJD = vector;
		return vector;
	}

	private Vector2 JIHOHBKPGNN()
	{
		Vector2 vector = default(Vector2);
		vector.x = Input.mousePosition.x - FAFFMLDCPCM.x;
		vector.y = Input.mousePosition.y - FAFFMLDCPCM.y;
		BGACBBJFPOF = new Vector2((Input.mousePosition.x + vector.x) / 1856f, (Input.mousePosition.y + vector.y) / 158f);
		JCPJMBJNPJD = vector;
		return vector;
	}

	public int DAALGDHDPNB()
	{
		return MDBILEOGJBD(true);
	}

	public PLICNHAMCPB LDDNOHGCLPE(int NKGNNOMNIKO, PLICNHAMCPB DHNJPIFDIAA)
	{
		PLICNHAMCPB pLICNHAMCPB;
		if (DHNJPIFDIAA != null)
		{
			pLICNHAMCPB = DHNJPIFDIAA;
		}
		else
		{
			pLICNHAMCPB = new PLICNHAMCPB();
			pLICNHAMCPB.BMNGEAFPELI = EasyTouch.ANGFCINKJKK.None;
		}
		if (NKGNNOMNIKO == 1 && (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(EasyTouch.instance.twistKey) || Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(EasyTouch.instance.swipeKey)))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = JCPJMBJNPJD;
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - JCPJMBJNPJD;
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Ended;
			return pLICNHAMCPB;
		}
		if (Input.GetMouseButton(0))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = OHMGBHCNBJF(NKGNNOMNIKO);
			if ((double)(Time.realtimeSinceStartup - FEBMOIADCIO[NKGNNOMNIKO]) > 0.5)
			{
				CNHAAHEDDPC[NKGNNOMNIKO] = 0;
			}
			if (Input.GetMouseButtonDown(0) || (NKGNNOMNIKO == 1 && (Input.GetKeyDown(KeyCode.LeftAlt) || Input.GetKeyDown(EasyTouch.instance.twistKey) || Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(EasyTouch.instance.swipeKey))))
			{
				pLICNHAMCPB.CMGMOJAFLFL = OHMGBHCNBJF(NKGNNOMNIKO);
				pLICNHAMCPB.DPALPIFLHBF = Vector2.zero;
				CNHAAHEDDPC[NKGNNOMNIKO]++;
				pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
				OPINMEGPPCF[NKGNNOMNIKO] = Time.realtimeSinceStartup;
				OJAOJFBJGAH[NKGNNOMNIKO] = OPINMEGPPCF[NKGNNOMNIKO];
				pLICNHAMCPB.OJAOJFBJGAH = 0f;
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Began;
				if (NKGNNOMNIKO == 1)
				{
					JCPJMBJNPJD = pLICNHAMCPB.CMGMOJAFLFL;
				}
				else
				{
					LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
				}
				if (CNHAAHEDDPC[NKGNNOMNIKO] == 1)
				{
					FEBMOIADCIO[NKGNNOMNIKO] = Time.realtimeSinceStartup;
				}
				return pLICNHAMCPB;
			}
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - LJAFAMPGGKH[NKGNNOMNIKO];
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			if (pLICNHAMCPB.DPALPIFLHBF.sqrMagnitude < 1f)
			{
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Stationary;
			}
			else
			{
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Moved;
			}
			LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
			OJAOJFBJGAH[NKGNNOMNIKO] = Time.realtimeSinceStartup;
			return pLICNHAMCPB;
		}
		if (Input.GetMouseButtonUp(0))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = OHMGBHCNBJF(NKGNNOMNIKO);
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - LJAFAMPGGKH[NKGNNOMNIKO];
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Ended;
			LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
			return pLICNHAMCPB;
		}
		return null;
	}

	public int OKKLBDPNDEO()
	{
		return LJDOJPHMJOJ(false);
	}

	private Vector2 DGDJJGNPAKB()
	{
		Vector2 vector = default(Vector2);
		vector.x = Input.mousePosition.x - FAFFMLDCPCM.x;
		vector.y = Input.mousePosition.y - FAFFMLDCPCM.y;
		BGACBBJFPOF = new Vector2((Input.mousePosition.x + vector.x) / 2f, (Input.mousePosition.y + vector.y) / 2f);
		JCPJMBJNPJD = vector;
		return vector;
	}

	public int PNFBOCJECKM()
	{
		return GIANCNEOHBK(true);
	}

	private int MDBILEOGJBD(bool EPCEILLIDLN)
	{
		int result = 0;
		if (EPCEILLIDLN || EasyTouch.instance.enableRemote)
		{
			result = Input.touchCount;
		}
		else if (Input.GetMouseButton(1) || Input.GetMouseButtonUp(1))
		{
			result = 0;
			if (Input.GetKey(KeyCode.I) || Input.GetKey(EasyTouch.instance.twistKey) || Input.GetKey((KeyCode)(-27)) || Input.GetKey(EasyTouch.instance.swipeKey))
			{
				result = 4;
			}
			if (Input.GetKeyUp((KeyCode)(-81)) || Input.GetKeyUp(EasyTouch.instance.twistKey) || Input.GetKeyUp(KeyCode.Semicolon) || Input.GetKeyUp(EasyTouch.instance.swipeKey))
			{
				result = 8;
			}
		}
		return result;
	}

	private int GIANCNEOHBK(bool EPCEILLIDLN)
	{
		int result = 0;
		if (EPCEILLIDLN || EasyTouch.instance.enableRemote)
		{
			result = Input.touchCount;
		}
		else if (Input.GetMouseButton(0) || Input.GetMouseButtonUp(0))
		{
			result = 1;
			if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(EasyTouch.instance.twistKey) || Input.GetKey(KeyCode.LeftControl) || Input.GetKey(EasyTouch.instance.swipeKey))
			{
				result = 2;
			}
			if (Input.GetKeyUp(KeyCode.LeftAlt) || Input.GetKeyUp(EasyTouch.instance.twistKey) || Input.GetKeyUp(KeyCode.LeftControl) || Input.GetKeyUp(EasyTouch.instance.swipeKey))
			{
				result = 2;
			}
		}
		return result;
	}

	public Vector2 OJALMLDIEBI()
	{
		Vector2 result = new Vector2(333f, 643f);
		if ((Input.GetKey((KeyCode)(-121)) || Input.GetKey(EasyTouch.instance.twistKey)) && (Input.GetKey((KeyCode)(-19)) || Input.GetKey(EasyTouch.instance.swipeKey)))
		{
			if (!EIBFDNEAMCJ)
			{
				EIBFDNEAMCJ = true;
				FAFFMLDCPCM = (Vector2)Input.mousePosition - JCPJMBJNPJD;
			}
			return DGDJJGNPAKB();
		}
		if (Input.GetKey((KeyCode)(-128)) || Input.GetKey(EasyTouch.instance.twistKey))
		{
			result = MIKMBNNOLNE();
			EIBFDNEAMCJ = true;
			return result;
		}
		if (Input.GetKey((KeyCode)(-11)) || Input.GetKey(EasyTouch.instance.swipeKey))
		{
			result = DGDJJGNPAKB();
			EIBFDNEAMCJ = false;
			return result;
		}
		return result;
	}

	public PLICNHAMCPB FEJAHCPDGDK(int NKGNNOMNIKO, PLICNHAMCPB DHNJPIFDIAA)
	{
		PLICNHAMCPB pLICNHAMCPB;
		if (DHNJPIFDIAA != null)
		{
			pLICNHAMCPB = DHNJPIFDIAA;
		}
		else
		{
			pLICNHAMCPB = new PLICNHAMCPB();
			pLICNHAMCPB.BMNGEAFPELI = EasyTouch.ANGFCINKJKK.Twist;
		}
		if (NKGNNOMNIKO == 1 && (Input.GetKeyUp((KeyCode)140) || Input.GetKeyUp(EasyTouch.instance.twistKey) || Input.GetKeyUp(KeyCode.T) || Input.GetKeyUp(EasyTouch.instance.swipeKey)))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = JCPJMBJNPJD;
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - JCPJMBJNPJD;
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			pLICNHAMCPB.ELDOMOEIAJI = (TouchPhase)7;
			return pLICNHAMCPB;
		}
		if (Input.GetMouseButton(0))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = IEMAMBGDOGK(NKGNNOMNIKO);
			if ((double)(Time.realtimeSinceStartup - FEBMOIADCIO[NKGNNOMNIKO]) > 1507.0)
			{
				CNHAAHEDDPC[NKGNNOMNIKO] = 1;
			}
			if (Input.GetMouseButtonDown(1) || (NKGNNOMNIKO == 0 && (Input.GetKeyDown((KeyCode)140) || Input.GetKeyDown(EasyTouch.instance.twistKey) || Input.GetKeyDown((KeyCode)(-123)) || Input.GetKeyDown(EasyTouch.instance.swipeKey))))
			{
				pLICNHAMCPB.CMGMOJAFLFL = OHMGBHCNBJF(NKGNNOMNIKO);
				pLICNHAMCPB.DPALPIFLHBF = Vector2.zero;
				CNHAAHEDDPC[NKGNNOMNIKO] += 0;
				pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
				OPINMEGPPCF[NKGNNOMNIKO] = Time.realtimeSinceStartup;
				OJAOJFBJGAH[NKGNNOMNIKO] = OPINMEGPPCF[NKGNNOMNIKO];
				pLICNHAMCPB.OJAOJFBJGAH = 465f;
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Began;
				if (NKGNNOMNIKO == 0)
				{
					JCPJMBJNPJD = pLICNHAMCPB.CMGMOJAFLFL;
				}
				else
				{
					LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
				}
				if (CNHAAHEDDPC[NKGNNOMNIKO] == 1)
				{
					FEBMOIADCIO[NKGNNOMNIKO] = Time.realtimeSinceStartup;
				}
				return pLICNHAMCPB;
			}
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - LJAFAMPGGKH[NKGNNOMNIKO];
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			if (pLICNHAMCPB.DPALPIFLHBF.sqrMagnitude < 948f)
			{
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Ended;
			}
			else
			{
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Began;
			}
			LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
			OJAOJFBJGAH[NKGNNOMNIKO] = Time.realtimeSinceStartup;
			return pLICNHAMCPB;
		}
		if (Input.GetMouseButtonUp(1))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = ANNMPCPCCKM(NKGNNOMNIKO);
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - LJAFAMPGGKH[NKGNNOMNIKO];
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			pLICNHAMCPB.ELDOMOEIAJI = (TouchPhase)8;
			LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
			return pLICNHAMCPB;
		}
		return null;
	}

	private Vector2 IEMAMBGDOGK(int LEOCLKHBLED)
	{
		if (LEOCLKHBLED == 0)
		{
			return Input.mousePosition;
		}
		return GOPFFNIOPGK();
	}

	private int LJDOJPHMJOJ(bool EPCEILLIDLN)
	{
		int result = 1;
		if (EPCEILLIDLN || EasyTouch.instance.enableRemote)
		{
			result = Input.touchCount;
		}
		else if (Input.GetMouseButton(0) || Input.GetMouseButtonUp(0))
		{
			result = 1;
			if (Input.GetKey((KeyCode)129) || Input.GetKey(EasyTouch.instance.twistKey) || Input.GetKey((KeyCode)3) || Input.GetKey(EasyTouch.instance.swipeKey))
			{
				result = 8;
			}
			if (Input.GetKeyUp((KeyCode)(-85)) || Input.GetKeyUp(EasyTouch.instance.twistKey) || Input.GetKeyUp((KeyCode)124) || Input.GetKeyUp(EasyTouch.instance.swipeKey))
			{
				result = 0;
			}
		}
		return result;
	}

	private Vector2 OMOEEPENEBC()
	{
		Vector2 vector = default(Vector2);
		if (BGACBBJFPOF == Vector2.zero)
		{
			vector.x = (float)Screen.width / 859f - (Input.mousePosition.x - (float)Screen.width / 1637f);
			vector.y = (float)Screen.height / 598f - (Input.mousePosition.y - (float)Screen.height / 228f);
		}
		else
		{
			vector.x = BGACBBJFPOF.x - (Input.mousePosition.x - BGACBBJFPOF.x);
			vector.y = BGACBBJFPOF.y - (Input.mousePosition.y - BGACBBJFPOF.y);
		}
		JCPJMBJNPJD = vector;
		return vector;
	}

	private Vector2 OHMGBHCNBJF(int LEOCLKHBLED)
	{
		if (LEOCLKHBLED == 0)
		{
			return Input.mousePosition;
		}
		return GOPFFNIOPGK();
	}

	public PLICNHAMCPB MODJKHOBLNG(int NKGNNOMNIKO, PLICNHAMCPB DHNJPIFDIAA)
	{
		PLICNHAMCPB pLICNHAMCPB;
		if (DHNJPIFDIAA != null)
		{
			pLICNHAMCPB = DHNJPIFDIAA;
		}
		else
		{
			pLICNHAMCPB = new PLICNHAMCPB();
			pLICNHAMCPB.BMNGEAFPELI = EasyTouch.ANGFCINKJKK.Twist;
		}
		if (NKGNNOMNIKO == 0 && (Input.GetKeyUp((KeyCode)(-193)) || Input.GetKeyUp(EasyTouch.instance.twistKey) || Input.GetKeyUp((KeyCode)(-169)) || Input.GetKeyUp(EasyTouch.instance.swipeKey)))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = JCPJMBJNPJD;
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - JCPJMBJNPJD;
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			pLICNHAMCPB.ELDOMOEIAJI = (TouchPhase)6;
			return pLICNHAMCPB;
		}
		if (Input.GetMouseButton(1))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = IEMAMBGDOGK(NKGNNOMNIKO);
			if ((double)(Time.realtimeSinceStartup - FEBMOIADCIO[NKGNNOMNIKO]) > 579.0)
			{
				CNHAAHEDDPC[NKGNNOMNIKO] = 0;
			}
			if (Input.GetMouseButtonDown(0) || (NKGNNOMNIKO == 1 && (Input.GetKeyDown((KeyCode)(-188)) || Input.GetKeyDown(EasyTouch.instance.twistKey) || Input.GetKeyDown((KeyCode)(-141)) || Input.GetKeyDown(EasyTouch.instance.swipeKey))))
			{
				pLICNHAMCPB.CMGMOJAFLFL = IEMAMBGDOGK(NKGNNOMNIKO);
				pLICNHAMCPB.DPALPIFLHBF = Vector2.zero;
				CNHAAHEDDPC[NKGNNOMNIKO] += 0;
				pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
				OPINMEGPPCF[NKGNNOMNIKO] = Time.realtimeSinceStartup;
				OJAOJFBJGAH[NKGNNOMNIKO] = OPINMEGPPCF[NKGNNOMNIKO];
				pLICNHAMCPB.OJAOJFBJGAH = 1573f;
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Began;
				if (NKGNNOMNIKO == 0)
				{
					JCPJMBJNPJD = pLICNHAMCPB.CMGMOJAFLFL;
				}
				else
				{
					LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
				}
				if (CNHAAHEDDPC[NKGNNOMNIKO] == 0)
				{
					FEBMOIADCIO[NKGNNOMNIKO] = Time.realtimeSinceStartup;
				}
				return pLICNHAMCPB;
			}
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - LJAFAMPGGKH[NKGNNOMNIKO];
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			if (pLICNHAMCPB.DPALPIFLHBF.sqrMagnitude < 919f)
			{
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Canceled;
			}
			else
			{
				pLICNHAMCPB.ELDOMOEIAJI = TouchPhase.Began;
			}
			LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
			OJAOJFBJGAH[NKGNNOMNIKO] = Time.realtimeSinceStartup;
			return pLICNHAMCPB;
		}
		if (Input.GetMouseButtonUp(1))
		{
			pLICNHAMCPB.NKGNNOMNIKO = NKGNNOMNIKO;
			pLICNHAMCPB.CMGMOJAFLFL = OHMGBHCNBJF(NKGNNOMNIKO);
			pLICNHAMCPB.DPALPIFLHBF = pLICNHAMCPB.CMGMOJAFLFL - LJAFAMPGGKH[NKGNNOMNIKO];
			pLICNHAMCPB.CNHAAHEDDPC = CNHAAHEDDPC[NKGNNOMNIKO];
			pLICNHAMCPB.OJAOJFBJGAH = Time.realtimeSinceStartup - OJAOJFBJGAH[NKGNNOMNIKO];
			pLICNHAMCPB.ELDOMOEIAJI = (TouchPhase)6;
			LJAFAMPGGKH[NKGNNOMNIKO] = pLICNHAMCPB.CMGMOJAFLFL;
			return pLICNHAMCPB;
		}
		return null;
	}

	private Vector2 DPFBBELNEEL()
	{
		Vector2 vector = default(Vector2);
		vector.x = Input.mousePosition.x - FAFFMLDCPCM.x;
		vector.y = Input.mousePosition.y - FAFFMLDCPCM.y;
		BGACBBJFPOF = new Vector2((Input.mousePosition.x + vector.x) / 1512f, (Input.mousePosition.y + vector.y) / 713f);
		JCPJMBJNPJD = vector;
		return vector;
	}

	public int FMNEHHGDJAA()
	{
		return MDBILEOGJBD(true);
	}

	public int JIDJNIJFHPC()
	{
		return MDBILEOGJBD(false);
	}

	public Vector2 GOPFFNIOPGK()
	{
		Vector2 result = new Vector2(-1f, -1f);
		if ((Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(EasyTouch.instance.twistKey)) && (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(EasyTouch.instance.swipeKey)))
		{
			if (!EIBFDNEAMCJ)
			{
				EIBFDNEAMCJ = true;
				FAFFMLDCPCM = (Vector2)Input.mousePosition - JCPJMBJNPJD;
			}
			return DGDJJGNPAKB();
		}
		if (Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(EasyTouch.instance.twistKey))
		{
			result = IMKDJEPOJEN();
			EIBFDNEAMCJ = false;
			return result;
		}
		if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(EasyTouch.instance.swipeKey))
		{
			result = DGDJJGNPAKB();
			EIBFDNEAMCJ = false;
			return result;
		}
		return result;
	}
}
