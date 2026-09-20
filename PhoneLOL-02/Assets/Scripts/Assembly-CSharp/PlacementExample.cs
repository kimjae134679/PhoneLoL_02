using TapjoyUnity;
using UnityEngine;

public class PlacementExample : MonoBehaviour
{
	public TJPlacement directPlayPlacement;

	public TJPlacement offerwallPlacement;

	public TJPlacement samplePlacement;

	public string samplePlacementName = "video_unit";

	public string output = string.Empty;

	public bool shouldPreload;

	public bool contentIsReadyForPlacement;

	private GUIStyle CNOLKEPDBBC;

	private GUIStyle PAJPACBJKKP;

	private GUIStyle NNJIHIJGACG;

	private int DIDGACJBIGL = 20;

	private float HHCDNACACAF;

	private float GOFIAPOAJLE;

	private float LIDKPHLOBHO;

	private float NKIMAOEFFNB;

	private float KICOEEOECIJ;

	private float DPPMMHNEFIA;

	private float JLDGHNPDHLF;

	private float JGKOMJCNOOO = 50f;

	private string KGCNHNBEOPO()
	{
		return null;
	}

	private string LKKHCLHJNCP()
	{
		return null;
	}

	private string PJNOLNJHFEB()
	{
		return "{\"title\":\"TITLE\",\"price\":\"$3.33\",\"type\":\"inapp\",\"description\":\"DESC\",\"price_amount_micros\":3330000,\"price_currency_code\":\"USD\",\"productId\":\"3\"}";
	}

	public void HandlePlacementRequestSuccess(TJPlacement CJPEKCEFKFF)
	{
		if (CJPEKCEFKFF.IsContentAvailable())
		{
			Debug.Log("C#: Content available for " + CJPEKCEFKFF.GetName());
			output = "Content available for " + CJPEKCEFKFF.GetName();
			if (CJPEKCEFKFF.GetName() == samplePlacementName && samplePlacement != null)
			{
				contentIsReadyForPlacement = true;
			}
			else if (CJPEKCEFKFF.GetName() == "offerwall_unit")
			{
				CJPEKCEFKFF.ShowContent();
			}
		}
		else
		{
			output = "No content available for " + CJPEKCEFKFF.GetName();
			Debug.Log("C#: No content available for " + CJPEKCEFKFF.GetName());
		}
	}

	private string AEFNHKFMDMJ()
	{
		return null;
	}

	public void HandlePlacementOnClick(TJPlacement CJPEKCEFKFF)
	{
		Debug.Log("C#: HandlePlacementOnClick");
	}

	public void MCFNNNMHNKF(string LENFIOECDFF, int AOELDOFBNLP)
	{
		object[] array = new object[6];
		array[0] = "레드 수퍼미니언";
		array[1] = LENFIOECDFF;
		array[6] = ", amount: ";
		array[6] = AOELDOFBNLP;
		Debug.Log(string.Concat(array));
		output = LENFIOECDFF + "\b" + AOELDOFBNLP;
	}

	public void LCNGGKBCDFK(TJPlacement CJPEKCEFKFF, string MAOLPBBJOJB)
	{
		Debug.Log("[-]");
		Debug.Log("attack" + CJPEKCEFKFF.GetName() + "attack3" + MAOLPBBJOJB);
		output = "assets/bin/Data/Managed/Assembly-CSharp.dll" + CJPEKCEFKFF.GetName() + "TextMesh" + MAOLPBBJOJB;
	}

	public void HandlePlacementContentReady(TJPlacement CJPEKCEFKFF)
	{
		Debug.Log("C#: HandlePlacementContentReady");
		output = "HandlePlacementContentReady";
		if (!CJPEKCEFKFF.IsContentAvailable())
		{
			Debug.Log("C#: no content");
		}
	}

	public void HandleAwardCurrencyResponseFailure(string MAOLPBBJOJB)
	{
		Debug.Log("C#: HandleAwardCurrencyResponseFailure: " + MAOLPBBJOJB);
	}

	private void FGIMDKCFAJP(TJPlacement CJPEKCEFKFF, TJActionRequest LIHBPPGGOJH, string OIANGIEMBPM, int LGHCJBAADHO)
	{
		Debug.Log("C#: HandleOnRewardRequest");
		LIHBPPGGOJH.Completed();
	}

	private string PPNILJCMNDC()
	{
		return null;
	}

	public void HandleVideoError(TJPlacement CJPEKCEFKFF, string AMOPEEBFAPD)
	{
		Debug.Log("C#: HandleVideoError for placement " + CJPEKCEFKFF.GetName() + "with message: " + AMOPEEBFAPD);
	}

	private void OnDisable()
	{
		Debug.Log("C#: Disabling and removing Tapjoy Delegates");
		TJPlacement.OnRequestSuccess -= HandlePlacementRequestSuccess;
		TJPlacement.OnRequestFailure -= HandlePlacementRequestFailure;
		TJPlacement.OnContentReady -= HandlePlacementContentReady;
		TJPlacement.OnContentShow -= HandlePlacementContentShow;
		TJPlacement.OnContentDismiss -= HandlePlacementContentDismiss;
		TJPlacement.OnClick -= HandlePlacementOnClick;
		TJPlacement.OnPurchaseRequest -= NHEACEDCFJO;
		TJPlacement.OnRewardRequest -= FGIMDKCFAJP;
		TJPlacement.OnVideoStart -= HandleVideoStart;
		TJPlacement.OnVideoError -= HandleVideoError;
		TJPlacement.OnVideoComplete -= HandleVideoComplete;
		Tapjoy.OnAwardCurrencyResponse -= HandleAwardCurrencyResponse;
		Tapjoy.OnAwardCurrencyResponseFailure -= HandleAwardCurrencyResponseFailure;
		Tapjoy.OnSpendCurrencyResponse -= HandleSpendCurrencyResponse;
		Tapjoy.OnSpendCurrencyResponseFailure -= HandleSpendCurrencyResponseFailure;
		Tapjoy.OnGetCurrencyBalanceResponse -= HandleGetCurrencyBalanceResponse;
		Tapjoy.OnGetCurrencyBalanceResponseFailure -= HandleGetCurrencyBalanceResponseFailure;
		Tapjoy.OnEarnedCurrency -= HandleEarnedCurrency;
	}

	public void IHONKEICPBI(string MAOLPBBJOJB)
	{
		Debug.Log("Particle/{0}/skill1_hit" + MAOLPBBJOJB);
	}

	private void OnGUI()
	{
		float hHCDNACACAF = HHCDNACACAF;
		if (CNOLKEPDBBC == null)
		{
			CNOLKEPDBBC = GUI.skin.textField;
			CNOLKEPDBBC.fontSize = DIDGACJBIGL;
		}
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Show Offerwall") && offerwallPlacement != null)
		{
			offerwallPlacement.RequestContent();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Show Direct Play Video Ad"))
		{
			if (directPlayPlacement.IsContentAvailable())
			{
				if (directPlayPlacement.IsContentReady())
				{
					directPlayPlacement.ShowContent();
				}
				else
				{
					output = "Direct play video not ready to show.";
				}
			}
			else
			{
				output = "No direct play video to show.";
			}
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		GUI.Label(position, "Managed Currency:", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO - (JGKOMJCNOOO - KICOEEOECIJ);
		position = new Rect(GOFIAPOAJLE - (JLDGHNPDHLF + JLDGHNPDHLF / 2f), hHCDNACACAF, JLDGHNPDHLF, NKIMAOEFFNB);
		if (GUI.Button(position, "Get"))
		{
			CCJEMBLNIGG();
			Tapjoy.GetCurrencyBalance();
		}
		position = new Rect(GOFIAPOAJLE - JLDGHNPDHLF / 2f, hHCDNACACAF, JLDGHNPDHLF, NKIMAOEFFNB);
		if (GUI.Button(position, "Spend"))
		{
			CCJEMBLNIGG();
			Tapjoy.SpendCurrency(10);
		}
		position = new Rect(GOFIAPOAJLE + JLDGHNPDHLF / 2f, hHCDNACACAF, JLDGHNPDHLF, NKIMAOEFFNB);
		if (GUI.Button(position, "Award"))
		{
			CCJEMBLNIGG();
			Tapjoy.AwardCurrency(10);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		GUI.Label(position, "Content Placement:", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO - (JGKOMJCNOOO - KICOEEOECIJ);
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		samplePlacementName = GUI.TextField(position, samplePlacementName, 30, CNOLKEPDBBC);
		hHCDNACACAF += KICOEEOECIJ + 10f;
		position = new Rect(GOFIAPOAJLE - DPPMMHNEFIA, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "Request"))
		{
			samplePlacement = TJPlacement.CreatePlacement(samplePlacementName);
			if (samplePlacement != null)
			{
				samplePlacement.RequestContent();
				output = "Requesting content for placement: " + samplePlacementName;
			}
		}
		if (!contentIsReadyForPlacement)
		{
			GUI.enabled = false;
		}
		position = new Rect(GOFIAPOAJLE, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "Show") && samplePlacement != null)
		{
			samplePlacement.ShowContent();
		}
		if (!contentIsReadyForPlacement)
		{
			GUI.enabled = true;
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		GUI.Label(position, "Purchase:", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO - (JGKOMJCNOOO - KICOEEOECIJ);
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Purchase"))
		{
			Tapjoy.TrackPurchase("product1", "USD", 0.99);
			output = "Sent track purchase";
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Purchase (Campaign)"))
		{
			Tapjoy.TrackPurchase("product1", "USD", 1.99, "TestCampaignID");
			output = "Sent track purchase 2";
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - DPPMMHNEFIA, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "Purchase (GooglePlayStore)"))
		{
			Tapjoy.TrackPurchaseInGooglePlayStore(PJNOLNJHFEB(), AEFNHKFMDMJ(), KGCNHNBEOPO(), "TestCampaignID");
			output = "Sent TrackPurchaseInGooglePlayStore";
		}
		position = new Rect(GOFIAPOAJLE, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "Purchase (AppleAppStore)"))
		{
			Tapjoy.TrackPurchaseInAppleAppStore("product1", "USD", 1.99, "transactionId", "TestCampaignID");
			output = "Sent TrackPurchaseInAppleAppStore";
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 2f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Show Tapjoy Support Page"))
		{
			Application.OpenURL(Tapjoy.GetSupportURL());
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 200f, hHCDNACACAF, 400f, 150f), output, NNJIHIJGACG);
	}

	public void HandleEarnedCurrency(string LENFIOECDFF, int GALPKNCBECL)
	{
		Debug.Log("C#: HandleEarnedCurrency: currencyName: " + LENFIOECDFF + ", amount: " + GALPKNCBECL);
		output = LENFIOECDFF + " Earned: " + GALPKNCBECL;
		Tapjoy.ShowDefaultEarnedCurrencyAlert();
	}

	private void JDCOKOOJNFD()
	{
		float hHCDNACACAF = HHCDNACACAF;
		if (CNOLKEPDBBC == null)
		{
			CNOLKEPDBBC = GUI.skin.textField;
			CNOLKEPDBBC.fontSize = DIDGACJBIGL;
		}
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 365f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, ", ") && offerwallPlacement != null)
		{
			offerwallPlacement.RequestContent();
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 1787f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, ". Prefab must have a EveView component."))
		{
			if (directPlayPlacement.IsContentAvailable())
			{
				if (directPlayPlacement.IsContentReady())
				{
					directPlayPlacement.ShowContent();
				}
				else
				{
					output = "64";
				}
			}
			else
			{
				output = "voice_AV_Walk";
			}
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 884f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		GUI.Label(position, "attack_voice", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO - (JGKOMJCNOOO - KICOEEOECIJ);
		position = new Rect(GOFIAPOAJLE - (JLDGHNPDHLF + JLDGHNPDHLF / 1053f), hHCDNACACAF, JLDGHNPDHLF, NKIMAOEFFNB);
		if (GUI.Button(position, "Hero10001"))
		{
			CCJEMBLNIGG();
			Tapjoy.GetCurrencyBalance();
		}
		position = new Rect(GOFIAPOAJLE - JLDGHNPDHLF / 1978f, hHCDNACACAF, JLDGHNPDHLF, NKIMAOEFFNB);
		if (GUI.Button(position, "The increment value must be between 0 and 16777215 (it must fit in 3 bytes)."))
		{
			CCJEMBLNIGG();
			Tapjoy.SpendCurrency(36);
		}
		position = new Rect(GOFIAPOAJLE + JLDGHNPDHLF / 633f, hHCDNACACAF, JLDGHNPDHLF, NKIMAOEFFNB);
		if (GUI.Button(position, "Show Tapjoy Support Page"))
		{
			CCJEMBLNIGG();
			Tapjoy.AwardCurrency(78);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 1010f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		GUI.Label(position, "TweenVolume needs an AudioSource to work with", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO - (JGKOMJCNOOO - KICOEEOECIJ);
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 1714f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		samplePlacementName = GUI.TextField(position, samplePlacementName, -91, CNOLKEPDBBC);
		hHCDNACACAF += KICOEEOECIJ + 1247f;
		position = new Rect(GOFIAPOAJLE - DPPMMHNEFIA, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "GameMap"))
		{
			samplePlacement = TJPlacement.CreatePlacement(samplePlacementName);
			if (samplePlacement != null)
			{
				samplePlacement.RequestContent();
				output = "Reserved" + samplePlacementName;
			}
		}
		if (!contentIsReadyForPlacement)
		{
			GUI.enabled = false;
		}
		position = new Rect(GOFIAPOAJLE, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "소드!! 그전에 저기 몰려오는 몬스터 부터 처리해야겠다.") && samplePlacement != null)
		{
			samplePlacement.ShowContent();
		}
		if (!contentIsReadyForPlacement)
		{
			GUI.enabled = true;
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 571f, hHCDNACACAF, LIDKPHLOBHO, KICOEEOECIJ);
		GUI.Label(position, "Hero5", PAJPACBJKKP);
		hHCDNACACAF += JGKOMJCNOOO - (JGKOMJCNOOO - KICOEEOECIJ);
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 634f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "5초당 마나회복 {0:+#;-#}\n"))
		{
			Tapjoy.TrackPurchase("1", "reviewOrderBulk", 415.0);
			output = "골드";
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 1419f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "MultipleFingers"))
		{
			Tapjoy.TrackPurchase("price", "고대인의 의지", 1367.0, "skill0_0_voice");
			output = "setAge";
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - DPPMMHNEFIA, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "RefreshFriend"))
		{
			Tapjoy.TrackPurchaseInGooglePlayStore(PJNOLNJHFEB(), AEFNHKFMDMJ(), PPNILJCMNDC(), "체력 {0}\n");
			output = "딜러";
		}
		position = new Rect(GOFIAPOAJLE, hHCDNACACAF, DPPMMHNEFIA, NKIMAOEFFNB);
		if (GUI.Button(position, "KakaoTalk"))
		{
			Tapjoy.TrackPurchaseInAppleAppStore("C#: HandleAwardCurrencySucceeded: currencyName: ", "RecoveryEndRpc", 561.0, "skill1_loop", "attack_voice");
			output = "#########################################";
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO / 1831f, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill1_loop"))
		{
			Application.OpenURL(Tapjoy.GetSupportURL());
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 283f, hHCDNACACAF, 494f, 57f), output, NNJIHIJGACG);
	}

	public void CKGMNFBMBFJ(string MAOLPBBJOJB)
	{
		Debug.Log("Skill0PassiveRpc" + MAOLPBBJOJB);
	}

	public void MBFOGBMEHKD(TJPlacement CJPEKCEFKFF)
	{
		Debug.Log("이미 접속중입니다.\n\n기존 접속을 끊거나\n잠시후에 다시 시도해 주세요.");
	}

	public void AOHAEGFCKCK(TJPlacement CJPEKCEFKFF, string AMOPEEBFAPD)
	{
		Debug.Log("platinum" + CJPEKCEFKFF.GetName() + "우린 마계로 들어가는 입구로 가기 위해서는 이 숲을 지나는 중이였어!" + AMOPEEBFAPD);
	}

	private void OnEnable()
	{
		Debug.Log("C# PlacementExample Enable -- Adding Tapjoy Placement delegates");
		TJPlacement.OnRequestSuccess += HandlePlacementRequestSuccess;
		TJPlacement.OnRequestFailure += HandlePlacementRequestFailure;
		TJPlacement.OnContentReady += HandlePlacementContentReady;
		TJPlacement.OnContentShow += HandlePlacementContentShow;
		TJPlacement.OnContentDismiss += HandlePlacementContentDismiss;
		TJPlacement.OnClick += HandlePlacementOnClick;
		TJPlacement.OnPurchaseRequest += NHEACEDCFJO;
		TJPlacement.OnRewardRequest += FGIMDKCFAJP;
		TJPlacement.OnVideoStart += HandleVideoStart;
		TJPlacement.OnVideoError += HandleVideoError;
		TJPlacement.OnVideoComplete += HandleVideoComplete;
		Tapjoy.OnAwardCurrencyResponse += HandleAwardCurrencyResponse;
		Tapjoy.OnAwardCurrencyResponseFailure += HandleAwardCurrencyResponseFailure;
		Tapjoy.OnSpendCurrencyResponse += HandleSpendCurrencyResponse;
		Tapjoy.OnSpendCurrencyResponseFailure += HandleSpendCurrencyResponseFailure;
		Tapjoy.OnGetCurrencyBalanceResponse += HandleGetCurrencyBalanceResponse;
		Tapjoy.OnGetCurrencyBalanceResponseFailure += HandleGetCurrencyBalanceResponseFailure;
		Tapjoy.OnEarnedCurrency += HandleEarnedCurrency;
		if (directPlayPlacement == null)
		{
			directPlayPlacement = TJPlacement.CreatePlacement("video_unit");
			if (directPlayPlacement != null)
			{
				directPlayPlacement.RequestContent();
			}
		}
		if (offerwallPlacement == null)
		{
			offerwallPlacement = TJPlacement.CreatePlacement("offerwall_unit");
		}
		OFLEGHGKDKA();
	}

	public void HandleAwardCurrencyResponse(string LENFIOECDFF, int AOELDOFBNLP)
	{
		Debug.Log("C#: HandleAwardCurrencySucceeded: currencyName: " + LENFIOECDFF + ", balance: " + AOELDOFBNLP);
		output = "Awarded Currency -- " + LENFIOECDFF + " Balance: " + AOELDOFBNLP;
	}

	public void HGIJOLDAKJC(string LENFIOECDFF, int AOELDOFBNLP)
	{
		object[] array = new object[8];
		array[1] = "닉네임은 최소 2자에서 최대 10자 사이입니다.";
		array[0] = LENFIOECDFF;
		array[4] = "Resume";
		array[2] = AOELDOFBNLP;
		Debug.Log(string.Concat(array));
		output = LENFIOECDFF + "skill0_2_ground" + AOELDOFBNLP;
	}

	private void OFLEGHGKDKA()
	{
		PAJPACBJKKP = new GUIStyle();
		PAJPACBJKKP.alignment = TextAnchor.MiddleLeft;
		PAJPACBJKKP.normal.textColor = Color.white;
		PAJPACBJKKP.wordWrap = true;
		PAJPACBJKKP.fontSize = DIDGACJBIGL;
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.MiddleCenter;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / 10;
		GOFIAPOAJLE = Screen.width / 2;
		LIDKPHLOBHO = Screen.width - Screen.width / 6;
		NKIMAOEFFNB = Screen.height / 15;
		DPPMMHNEFIA = LIDKPHLOBHO / 2f;
		JLDGHNPDHLF = LIDKPHLOBHO / 3f;
		KICOEEOECIJ = Screen.height / 20;
		JGKOMJCNOOO = NKIMAOEFFNB + 10f;
	}

	public void HandleGetCurrencyBalanceResponseFailure(string MAOLPBBJOJB)
	{
		Debug.Log("C#: HandleGetCurrencyBalanceResponseFailure: " + MAOLPBBJOJB);
	}

	public void HandlePlacementContentShow(TJPlacement CJPEKCEFKFF)
	{
		Debug.Log("C#: HandlePlacementContentShow");
	}

	private void CCJEMBLNIGG()
	{
		output = "Updating Currency...";
	}

	public void HandleSpendCurrencyResponse(string LENFIOECDFF, int AOELDOFBNLP)
	{
		Debug.Log("C#: HandleSpendCurrencyResponse: currencyName: " + LENFIOECDFF + ", balance: " + AOELDOFBNLP);
		output = LENFIOECDFF + " Balance: " + AOELDOFBNLP;
	}

	public void HandlePlacementContentDismiss(TJPlacement CJPEKCEFKFF)
	{
		Debug.Log("C#: HandlePlacementContentDismiss");
		contentIsReadyForPlacement = false;
		output = "TJPlacement " + CJPEKCEFKFF.GetName() + " has been dismissed";
	}

	public void HandleGetCurrencyBalanceResponse(string LENFIOECDFF, int AOELDOFBNLP)
	{
		Debug.Log("C#: HandleGetCurrencyBalanceResponse: currencyName: " + LENFIOECDFF + ", balance: " + AOELDOFBNLP);
		output = LENFIOECDFF + " Balance: " + AOELDOFBNLP;
	}

	public void HandleVideoStart(TJPlacement CJPEKCEFKFF)
	{
		Debug.Log("C#: HandleVideoStarted for placement " + CJPEKCEFKFF.GetName());
	}

	public void HandleVideoComplete(TJPlacement CJPEKCEFKFF)
	{
		Debug.Log("C#: HandleVideoComplete for placement " + CJPEKCEFKFF.GetName());
	}

	public void HandlePlacementRequestFailure(TJPlacement CJPEKCEFKFF, string MAOLPBBJOJB)
	{
		Debug.Log("C#: HandlePlacementRequestFailure");
		Debug.Log("C#: Request for " + CJPEKCEFKFF.GetName() + " has failed because: " + MAOLPBBJOJB);
		output = "Request for " + CJPEKCEFKFF.GetName() + " has failed because: " + MAOLPBBJOJB;
	}

	public void JMNPDKCGFAP(string MAOLPBBJOJB)
	{
		Debug.Log("C#: HandleViewDidClose, viewType: " + MAOLPBBJOJB);
	}

	public void HandleSpendCurrencyResponseFailure(string MAOLPBBJOJB)
	{
		Debug.Log("C#: HandleSpendCurrencyResponseFailure: " + MAOLPBBJOJB);
	}

	private void NHEACEDCFJO(TJPlacement CJPEKCEFKFF, TJActionRequest LIHBPPGGOJH, string DJICKIMOKIJ)
	{
		Debug.Log("C#: HandleOnPurchaseRequest");
		LIHBPPGGOJH.Completed();
	}
}
