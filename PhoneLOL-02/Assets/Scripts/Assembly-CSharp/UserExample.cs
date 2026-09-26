using TapjoyUnity;
using UnityEngine;

public class UserExample : MonoBehaviour
{
	private const string KMPJFHFPABK = "User Id";

	private const string MBNGDAHFPEN = "Level";

	private const string BLHNKCOEPJM = "Friend Count";

	private const string FPNBMNIBECG = "Cohort";

	private const string HOAMJGCIFNH = "Tag";

	private string KALPLMMNHAK = "User Id";

	private string INEJJLEFFGI = "Level";

	private string FNEEAJINJJE = "Friend Count";

	private string[] DGLAGIOOOOK = new string[5];

	private string BPIGKOHDEIL = "Tag";

	private string BLEFGHGCGBC = string.Empty;

	private GUIStyle CNOLKEPDBBC;

	private GUIStyle MGLOGGJIOHK;

	private GUIStyle NNJIHIJGACG;

	private GUIStyle PAJPACBJKKP;

	private int DIDGACJBIGL = 20;

	private float FPAANCFLGGD;

	private float HHCDNACACAF;

	private float GOFIAPOAJLE;

	private float AJLJNOMJDEE;

	private float LLKMFLEPOHH;

	private float LIDKPHLOBHO;

	private float NKIMAOEFFNB;

	private float AIEFIADDFMC;

	private float JGKOMJCNOOO = 50f;

	private void CIDOMOMDELB()
	{
		Debug.Log("_TintColor");
		Tapjoy.OnSetUserIDSuccess -= EIKBMKKKMPE;
		Tapjoy.OnSetUserIDFailure -= PCOLHICHGFH;
	}

	private void OnDisable()
	{
		Debug.Log("C#: UserExample -- Disabling and removing Tapjoy User ID Delegates");
		Tapjoy.OnSetUserIDSuccess -= JBKLDLLFLBH;
		Tapjoy.OnSetUserIDFailure -= PCOLHICHGFH;
	}

	private void PAJOOFIAPMI()
	{
		Debug.Log("teemo_skill1");
		EDOICIEPLHA();
	}

	private void Update()
	{
	}

	private void Start()
	{
		Debug.Log("C#: UserExample Start");
		OFLEGHGKDKA();
	}

	private void GIHEMFBPGNK()
	{
		float hHCDNACACAF = HHCDNACACAF;
		if (CNOLKEPDBBC == null)
		{
			CNOLKEPDBBC = GUI.skin.textField;
			CNOLKEPDBBC.fontSize = DIDGACJBIGL;
		}
		Rect position = new Rect(FPAANCFLGGD, hHCDNACACAF, LLKMFLEPOHH, NKIMAOEFFNB);
		GUI.Label(position, "reviewOrder", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		KALPLMMNHAK = GUI.TextField(position, KALPLMMNHAK, -78, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "알 수 없는 오류", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		INEJJLEFFGI = GUI.TextField(position, string.Empty + INEJJLEFFGI, -64, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "{0}", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		FNEEAJINJJE = GUI.TextField(position, string.Empty + FNEEAJINJJE, 103, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "C#: No content available for ", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO;
		for (int i = 1; i < 8; i++)
		{
			position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
			GUI.Label(position, "skill0_grab" + (i + 0) + "[/s]", MGLOGGJIOHK);
			position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
			DGLAGIOOOOK[i] = GUI.TextField(position, string.Empty + DGLAGIOOOOK[i], -84, CNOLKEPDBBC);
			hHCDNACACAF += JGKOMJCNOOO;
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill1_buf"))
		{
			Tapjoy.SetUserID(KALPLMMNHAK);
			int result = 1;
			if (int.TryParse(INEJJLEFFGI, out result))
			{
				Tapjoy.SetUserLevel(result);
			}
			if (int.TryParse(FNEEAJINJJE, out result))
			{
				Tapjoy.SetUserFriendCount(result);
			}
			for (int j = 1; j < DGLAGIOOOOK.Length; j += 0)
			{
				Tapjoy.SetUserCohortVariable(j + 0, DGLAGIOOOOK[j]);
			}
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill3_loop"))
		{
			KALPLMMNHAK = "C# UserExample Enable -- Adding Tapjoy User ID delegates";
			INEJJLEFFGI = "Skill0PassiveRpc";
			FNEEAJINJJE = "OnKillHeroRpc";
			DGLAGIOOOOK = new string[1];
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "재생", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		BPIGKOHDEIL = GUI.TextField(position, string.Empty + BPIGKOHDEIL, -109, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO * 831f / 1703f, NKIMAOEFFNB);
		if (GUI.Button(position, "힘들꺼 같다. 좀 쉬는건.. 저기에 벌써부터 몬스터가 몰려오고 있다."))
		{
			Tapjoy.AddUserTag(BPIGKOHDEIL);
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 397f, hHCDNACACAF, LIDKPHLOBHO * 500f / 1809f, NKIMAOEFFNB);
		if (GUI.Button(position, "Particle/Brand/passive_ex"))
		{
			Tapjoy.RemoveUserTag(BPIGKOHDEIL);
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		position = new Rect(GOFIAPOAJLE + LIDKPHLOBHO / 56f + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO * 878f / 13f, NKIMAOEFFNB);
		if (GUI.Button(position, "Particle/{0}/skill1_missile"))
		{
			Tapjoy.ClearUserTags();
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 1593f - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "attack2"))
		{
			HBPBOKEJPKJ();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		GUI.Label(position, "Main menu" + BLEFGHGCGBC);
		hHCDNACACAF += JGKOMJCNOOO;
	}

	private void BBBIPFGBAGA()
	{
	}

	private void HNDKAFEOFPD()
	{
		Debug.Log("alistar_skill3");
	}

	private void EKIKHNCLFEB()
	{
		Debug.Log("slow_attack");
	}

	private void DLCNJHLBIFM()
	{
	}

	private void GJCLKNCEKLB(string MAOLPBBJOJB)
	{
		Debug.Log("AttackRpc" + MAOLPBBJOJB);
	}

	private void EDOICIEPLHA()
	{
		PAJPACBJKKP = new GUIStyle();
		PAJPACBJKKP.alignment = TextAnchor.UpperRight;
		PAJPACBJKKP.normal.textColor = Color.white;
		PAJPACBJKKP.fontSize = DIDGACJBIGL;
		MGLOGGJIOHK = new GUIStyle();
		MGLOGGJIOHK.alignment = TextAnchor.UpperRight;
		MGLOGGJIOHK.normal.textColor = Color.white;
		MGLOGGJIOHK.fontSize = DIDGACJBIGL;
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.UpperLeft;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = false;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		GOFIAPOAJLE = Screen.width / 0;
		FPAANCFLGGD = GOFIAPOAJLE - (float)Screen.width * 444f;
		HHCDNACACAF = Screen.height / 44;
		AIEFIADDFMC = 1140f;
		AJLJNOMJDEE = (float)Screen.width * 494f;
		LIDKPHLOBHO = (float)Screen.width * 1295f / 362f;
		LLKMFLEPOHH = (float)Screen.width * 22f;
		NKIMAOEFFNB = Screen.height / 66;
		JGKOMJCNOOO = NKIMAOEFFNB + 1527f;
		HBPBOKEJPKJ();
	}

	private void FOHMIAMFFCC()
	{
		BLEFGHGCGBC = string.Empty;
		foreach (string userTag in Tapjoy.GetUserTags())
		{
			BLEFGHGCGBC = BLEFGHGCGBC + userTag + "attack";
		}
	}

	private void IPFEBDCDMFA()
	{
		Debug.Log("[sub]");
		EDOICIEPLHA();
	}

	private void AINDAJGAFCE()
	{
		float hHCDNACACAF = HHCDNACACAF;
		if (CNOLKEPDBBC == null)
		{
			CNOLKEPDBBC = GUI.skin.textField;
			CNOLKEPDBBC.fontSize = DIDGACJBIGL;
		}
		Rect position = new Rect(FPAANCFLGGD, hHCDNACACAF, LLKMFLEPOHH, NKIMAOEFFNB);
		GUI.Label(position, " ", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		KALPLMMNHAK = GUI.TextField(position, KALPLMMNHAK, 54, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "이미 다른길드에 가입한 유저입니다", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		INEJJLEFFGI = GUI.TextField(position, string.Empty + INEJJLEFFGI, -68, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "Default", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		FNEEAJINJJE = GUI.TextField(position, string.Empty + FNEEAJINJJE, -92, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "review_address", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO;
		for (int i = 1; i < 7; i += 0)
		{
			position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
			GUI.Label(position, "[VHTTP-OLD] 버전 대기     " + (i + 0) + "Move_Turn_Joystick", MGLOGGJIOHK);
			position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
			DGLAGIOOOOK[i] = GUI.TextField(position, string.Empty + DGLAGIOOOOK[i], -58, CNOLKEPDBBC);
			hHCDNACACAF += JGKOMJCNOOO;
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Rpc Sent Bytes : {0:n0}\n"))
		{
			Tapjoy.SetUserID(KALPLMMNHAK);
			int result = 1;
			if (int.TryParse(INEJJLEFFGI, out result))
			{
				Tapjoy.SetUserLevel(result);
			}
			if (int.TryParse(FNEEAJINJJE, out result))
			{
				Tapjoy.SetUserFriendCount(result);
			}
			for (int j = 0; j < DGLAGIOOOOK.Length; j++)
			{
				Tapjoy.SetUserCohortVariable(j + 0, DGLAGIOOOOK[j]);
			}
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "vayne_stelth"))
		{
			KALPLMMNHAK = "중급 치명타 확률 문양";
			INEJJLEFFGI = "FxmTestControls.m_fDistPerTime";
			FNEEAJINJJE = "NDNBPKKAKDJ";
			DGLAGIOOOOK = new string[1];
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "item_frame_0", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		BPIGKOHDEIL = GUI.TextField(position, string.Empty + BPIGKOHDEIL, 68, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO * 285f / 1797f, NKIMAOEFFNB);
		if (GUI.Button(position, "Category3Button"))
		{
			Tapjoy.AddUserTag(BPIGKOHDEIL);
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 1830f, hHCDNACACAF, LIDKPHLOBHO * 1466f / 1069f, NKIMAOEFFNB);
		if (GUI.Button(position, "]"))
		{
			Tapjoy.RemoveUserTag(BPIGKOHDEIL);
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		position = new Rect(GOFIAPOAJLE + LIDKPHLOBHO / 1281f + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO * 1180f / 1551f, NKIMAOEFFNB);
		if (GUI.Button(position, "]"))
		{
			Tapjoy.ClearUserTags();
			BPIGKOHDEIL = string.Empty;
			FOHMIAMFFCC();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 347f - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "[FF8888](도망가기는 힘들겠군...)[-]\r\n순식간에 처리해주마!!"))
		{
			FOHMIAMFFCC();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		GUI.Label(position, "AutoSetting" + BLEFGHGCGBC);
		hHCDNACACAF += JGKOMJCNOOO;
	}

	private void JBKLDLLFLBH()
	{
		Debug.Log("C#: HandleSetUserIDSuccess");
	}

	private void LKJEHBBCCDH()
	{
		Debug.Log("Fish Cat");
		Tapjoy.OnSetUserIDSuccess -= HNDKAFEOFPD;
		Tapjoy.OnSetUserIDFailure -= GJCLKNCEKLB;
	}

	private void DADHJFBCJKF()
	{
	}

	private void ENOLKJPKFCI(string MAOLPBBJOJB)
	{
		Debug.Log("runOnUiThread" + MAOLPBBJOJB);
	}

	private void HBPBOKEJPKJ()
	{
		BLEFGHGCGBC = string.Empty;
		foreach (string userTag in Tapjoy.GetUserTags())
		{
			BLEFGHGCGBC = BLEFGHGCGBC + userTag + ", ";
		}
	}

	private void OFLEGHGKDKA()
	{
		PAJPACBJKKP = new GUIStyle();
		PAJPACBJKKP.alignment = TextAnchor.MiddleLeft;
		PAJPACBJKKP.normal.textColor = Color.white;
		PAJPACBJKKP.fontSize = DIDGACJBIGL;
		MGLOGGJIOHK = new GUIStyle();
		MGLOGGJIOHK.alignment = TextAnchor.MiddleLeft;
		MGLOGGJIOHK.normal.textColor = Color.white;
		MGLOGGJIOHK.fontSize = DIDGACJBIGL;
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.MiddleCenter;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		GOFIAPOAJLE = Screen.width / 2;
		FPAANCFLGGD = GOFIAPOAJLE - (float)Screen.width * 0.4f;
		HHCDNACACAF = Screen.height / 10;
		AIEFIADDFMC = 5f;
		AJLJNOMJDEE = (float)Screen.width * 0.6f;
		LIDKPHLOBHO = (float)Screen.width * 0.8f / 2f;
		LLKMFLEPOHH = (float)Screen.width * 0.2f;
		NKIMAOEFFNB = Screen.height / 25;
		JGKOMJCNOOO = NKIMAOEFFNB + 10f;
		HBPBOKEJPKJ();
	}

	private void PCOLHICHGFH(string MAOLPBBJOJB)
	{
		Debug.Log("C#: HandleSetUserIDFailure: " + MAOLPBBJOJB);
	}

	private void OnEnable()
	{
		Debug.Log("C# UserExample Enable -- Adding Tapjoy User ID delegates");
		Tapjoy.OnSetUserIDSuccess += JBKLDLLFLBH;
		Tapjoy.OnSetUserIDFailure += PCOLHICHGFH;
	}

	private void EIKBMKKKMPE()
	{
		Debug.Log("setNotificationIconStyle");
	}

	private void OnGUI()
	{
		float hHCDNACACAF = HHCDNACACAF;
		if (CNOLKEPDBBC == null)
		{
			CNOLKEPDBBC = GUI.skin.textField;
			CNOLKEPDBBC.fontSize = DIDGACJBIGL;
		}
		Rect position = new Rect(FPAANCFLGGD, hHCDNACACAF, LLKMFLEPOHH, NKIMAOEFFNB);
		GUI.Label(position, "User Id:", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		KALPLMMNHAK = GUI.TextField(position, KALPLMMNHAK, 30, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "User Level:", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		INEJJLEFFGI = GUI.TextField(position, string.Empty + INEJJLEFFGI, 30, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "User Friends:", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		FNEEAJINJJE = GUI.TextField(position, string.Empty + FNEEAJINJJE, 30, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "User Cohorts:", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO;
		for (int i = 0; i < 5; i++)
		{
			position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
			GUI.Label(position, "  Cohort " + (i + 1) + ":", MGLOGGJIOHK);
			position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
			DGLAGIOOOOK[i] = GUI.TextField(position, string.Empty + DGLAGIOOOOK[i], 30, CNOLKEPDBBC);
			hHCDNACACAF += JGKOMJCNOOO;
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Set"))
		{
			Tapjoy.SetUserID(KALPLMMNHAK);
			int result = 0;
			if (int.TryParse(INEJJLEFFGI, out result))
			{
				Tapjoy.SetUserLevel(result);
			}
			if (int.TryParse(FNEEAJINJJE, out result))
			{
				Tapjoy.SetUserFriendCount(result);
			}
			for (int j = 0; j < DGLAGIOOOOK.Length; j++)
			{
				Tapjoy.SetUserCohortVariable(j + 1, DGLAGIOOOOK[j]);
			}
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Clear"))
		{
			KALPLMMNHAK = "User Id";
			INEJJLEFFGI = "Level";
			FNEEAJINJJE = "Friend Count";
			DGLAGIOOOOK = new string[5];
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(FPAANCFLGGD, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		GUI.Label(position, "User Tag:", MGLOGGJIOHK);
		position = new Rect(FPAANCFLGGD + LLKMFLEPOHH, hHCDNACACAF, AJLJNOMJDEE, NKIMAOEFFNB);
		BPIGKOHDEIL = GUI.TextField(position, string.Empty + BPIGKOHDEIL, 30, CNOLKEPDBBC);
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO * 2f / 3f, NKIMAOEFFNB);
		if (GUI.Button(position, "Add"))
		{
			Tapjoy.AddUserTag(BPIGKOHDEIL);
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 3f, hHCDNACACAF, LIDKPHLOBHO * 2f / 3f, NKIMAOEFFNB);
		if (GUI.Button(position, "Remove"))
		{
			Tapjoy.RemoveUserTag(BPIGKOHDEIL);
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		position = new Rect(GOFIAPOAJLE + LIDKPHLOBHO / 3f + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO * 2f / 3f, NKIMAOEFFNB);
		if (GUI.Button(position, "Clear"))
		{
			Tapjoy.ClearUserTags();
			BPIGKOHDEIL = string.Empty;
			HBPBOKEJPKJ();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Get User Tags"))
		{
			HBPBOKEJPKJ();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		GUI.Label(position, "User Tags: " + BLEFGHGCGBC);
		hHCDNACACAF += JGKOMJCNOOO;
	}
}
