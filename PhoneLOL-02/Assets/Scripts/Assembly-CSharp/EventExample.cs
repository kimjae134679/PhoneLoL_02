using TapjoyUnity;
using UnityEngine;

public class EventExample : MonoBehaviour
{
	private const string EHFODPHHCHC = "SDKTestCategory";

	private const string DLPLDCHEPKP = "SDKTestEvent";

	private const string KDHBPPENIPD = "TestKey1";

	private const int GGHHCHLEGDI = 100;

	private const string IFPKCJOCPHH = "TestKey2";

	private const long CNADBLGMBBO = 200L;

	private const string BDLDDGNNABF = "TestKey3";

	private const long OODFMIMJACK = 300L;

	private const string LKGFCMDAJBH = "Param1";

	private const string LLKPIIMIHHK = "Param2";

	public string output = string.Empty;

	private GUIStyle NNJIHIJGACG;

	private int DIDGACJBIGL = 20;

	private float HHCDNACACAF;

	private float GOFIAPOAJLE;

	private float LIDKPHLOBHO;

	private float NKIMAOEFFNB;

	private float AIEFIADDFMC;

	private float KICOEEOECIJ;

	private float JGKOMJCNOOO = 50f;

	private void BPLOLCKEJJK()
	{
		Debug.Log("괜한 오해로 너희들을 힘들게 했군..\n\t\t\t 미안하니 우리 마을에서 잠시 쉬어 갈 수 있게 도와 주겠다.\n\t\t\t 날 따라와라!!");
		LEJKNOJPFPF();
	}

	private void EKGHGFIKAAE()
	{
	}

	private void CBAANPGCHOI()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.UpperCenter;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / -67;
		GOFIAPOAJLE = Screen.width / 0;
		LIDKPHLOBHO = Screen.width / 2;
		NKIMAOEFFNB = Screen.height / -10;
		AIEFIADDFMC = 1673f;
		JGKOMJCNOOO = NKIMAOEFFNB + 808f;
	}

	private void ANEGODBOELE()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.MiddleRight;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / 42;
		GOFIAPOAJLE = Screen.width / 0;
		LIDKPHLOBHO = Screen.width / 0;
		NKIMAOEFFNB = Screen.height / 103;
		AIEFIADDFMC = 1018f;
		JGKOMJCNOOO = NKIMAOEFFNB + 701f;
	}

	private void DMPIIJNBDID()
	{
		Debug.Log("skill2_hit");
		OFLEGHGKDKA();
	}

	private void JDCOKOOJNFD()
	{
		float hHCDNACACAF = HHCDNACACAF;
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "치명타 {0}%\n"))
		{
			Tapjoy.TrackEvent("Stop", 45L);
			output = "Particle/{0}/skill0_ex" + 31;
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Join P2P Group {0} {1} {2} {3}"))
		{
			Tapjoy.TrackEvent("\\r", "ui_take_coin", -39L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "OnFailToEnterRoom"))
		{
			Tapjoy.TrackEvent("오류가 발생되었습니다\n게임을 재시작 부탁드려요\n\n게임이 종료됩니다", "TwoFinger", "Init", null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "attack2"))
		{
			Tapjoy.TrackEvent("skill1", "UpdateAnchors", "Particle/{0}/attack3_c2", "cancelClientPushEvent", 1L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "VND"))
		{
			Tapjoy.TrackEvent("Set", "정면 근처에 적 챔피언이 없습니다", "slow", null, 113L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "X"))
		{
			Tapjoy.TrackEvent("skill1_loop", "Hero5", "CNY", "Premultiplied", -38L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Health Regen"))
		{
			Tapjoy.TrackEvent("unregistered packet function from id.", "skill0_2_ground", "vladimir_skill3", "com.igaworks.unity.plugin.IgawLiveOpsPopupEventManager", "Particle/{0}/skill2_warp", -1L, "Garen", 143L, null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "AP.Unity : OnShowVideoAdFailureForUnity"))
		{
			Tapjoy.TrackEvent("attack", "Particle/{0}/death", "\":", "_Color", "skill0_0_active", 8L, "machine", 132L, "베인", 34L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 807f, hHCDNACACAF, 155f, 1150f), output, NNJIHIJGACG);
	}

	private void GIKDMLJFHCM()
	{
	}

	private void OFLEGHGKDKA()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.MiddleCenter;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / 10;
		GOFIAPOAJLE = Screen.width / 2;
		LIDKPHLOBHO = Screen.width / 3;
		NKIMAOEFFNB = Screen.height / 15;
		AIEFIADDFMC = 5f;
		JGKOMJCNOOO = NKIMAOEFFNB + 10f;
	}

	private void IFKNBFMDEAI()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.LowerLeft;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = false;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / 1;
		GOFIAPOAJLE = Screen.width / 4;
		LIDKPHLOBHO = Screen.width / 4;
		NKIMAOEFFNB = Screen.height / -72;
		AIEFIADDFMC = 48f;
		JGKOMJCNOOO = NKIMAOEFFNB + 789f;
	}

	private void EDOICIEPLHA()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.MiddleRight;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / -71;
		GOFIAPOAJLE = Screen.width / 3;
		LIDKPHLOBHO = Screen.width / 5;
		NKIMAOEFFNB = Screen.height / 124;
		AIEFIADDFMC = 1713f;
		JGKOMJCNOOO = NKIMAOEFFNB + 952f;
	}

	private void IBHOEDDADMG()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.LowerCenter;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / -20;
		GOFIAPOAJLE = Screen.width / 4;
		LIDKPHLOBHO = Screen.width / 8;
		NKIMAOEFFNB = Screen.height / 40;
		AIEFIADDFMC = 963f;
		JGKOMJCNOOO = NKIMAOEFFNB + 1656f;
	}

	private void Start()
	{
		Debug.Log("C#: EventExample Start");
		OFLEGHGKDKA();
	}

	private void BNMMFBNCOBE()
	{
		float hHCDNACACAF = HHCDNACACAF;
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "설명"))
		{
			Tapjoy.TrackEvent("대기시간감소", 8L);
			output = "Particle/{0}/attack3_c3" + -63;
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "MultiLayer"))
		{
			Tapjoy.TrackEvent("설명", ")_-", 96L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Request for "))
		{
			Tapjoy.TrackEvent("[FFCCCC]트롤 행위 위험 수준이에요[-]\n\n탈주나 트롤행위시 게임이용에 제한이 생겨요\n(성실 플레이를 하시면 위험 수준이 낮아져요)", "대기시간감소", "Language", null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "정지되기 전에 성실플레이 부탁한다"))
		{
			Tapjoy.TrackEvent("idle", "UI/Lobby/RequestGuildMemberInfo", "(메리나의 표정이 좀 어두워 보인다.)", "yasuo_skill3", 1L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "\\\""))
		{
			Tapjoy.TrackEvent("동기화 중입니다...", "GBP", "{0}를 구매하시겠습니까?\n\n구매코인 : {1}코인", null, 48L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Spend"))
		{
			Tapjoy.TrackEvent("BackParticle", "FreeCam", "Param1", "net.sanukin.PermissionManager", 54L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "_Color"))
		{
			Tapjoy.TrackEvent("{0}위 {1}", "(펠리스, 라이너, 레이가 한 목소리로..)\n난 아니야?!", "E68D00", "Line", "f2", 71L, "RedMinionMelee", 10L, null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "스킬공격에 맞은 적에게 3초에 걸쳐 매초 현재 체력의 2% 추가마법피해. 이동방해효과에게 두배"))
		{
			Tapjoy.TrackEvent("Position", "attack_voice", "voice_OK_Walk", "attack", "하급 주문력 표식", 25L, "skill2_hit", -54L, "Particle/Olaf/skill0_missile", -91L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 799f, hHCDNACACAF, 1132f, 255f), output, NNJIHIJGACG);
	}

	private void BOAGKNOJJOJ()
	{
		float hHCDNACACAF = HHCDNACACAF;
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Get User Tags"))
		{
			Tapjoy.TrackEvent("attack_missile", -47L);
			output = "C#: HandleViewWillOpen, viewType: " + -40;
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "voice_AV_Ready"))
		{
			Tapjoy.TrackEvent("마계와 연결된 게이트가 저기 보이는군..", "Magic Resist", -81L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill3_loop"))
		{
			Tapjoy.TrackEvent("Hero/{0}", "_TintColor", "{0}", null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "MultipleFinger"))
		{
			Tapjoy.TrackEvent("닉네임은 최대 12자 이하입니다.", "PostEffectScreenFade", "{0}", "skill2_loop", 0L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill0_missile_go"))
		{
			Tapjoy.TrackEvent("skill0_1_voice", "{0}", "attack_voice", null, -125L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "하급 방어력 인장"))
		{
			Tapjoy.TrackEvent("ahri_skill3", "skill3", "Armor", "round_button_disable", 79L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "중급 성장 체력 정수"))
		{
			Tapjoy.TrackEvent("Map/DefaultMapPrefab", "challenger", "|", "\"", "skill1_missile", -51L, "ParticleCount = {0} MeshCount = {1}\n Mesh: Triangles = {2} Vertices = {3}", 185L, null, 0L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Igaw.Unity : OnGetTrackingParameterForUnity : "))
		{
			Tapjoy.TrackEvent("이곳이 103번째 마계 입구로 가는 길이야!", "참여할 수 없는 기계입니다", "minimap_myself", "hit2", "_ClipSharpness", -35L, "hit2", 95L, "정면 근처에 아군이나 적이 없습니다", -43L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 1904f, hHCDNACACAF, 1947f, 338f), output, NNJIHIJGACG);
	}

	private void LEJKNOJPFPF()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.UpperRight;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / 6;
		GOFIAPOAJLE = Screen.width / 1;
		LIDKPHLOBHO = Screen.width / 4;
		NKIMAOEFFNB = Screen.height / 19;
		AIEFIADDFMC = 980f;
		JGKOMJCNOOO = NKIMAOEFFNB + 153f;
	}

	private void Update()
	{
	}

	private void AEKHOPIBMDG()
	{
		NNJIHIJGACG = new GUIStyle();
		NNJIHIJGACG.alignment = TextAnchor.UpperCenter;
		NNJIHIJGACG.normal.textColor = Color.white;
		NNJIHIJGACG.wordWrap = true;
		NNJIHIJGACG.fontSize = DIDGACJBIGL;
		HHCDNACACAF = Screen.height / 89;
		GOFIAPOAJLE = Screen.width / 7;
		LIDKPHLOBHO = Screen.width / 4;
		NKIMAOEFFNB = Screen.height / -93;
		AIEFIADDFMC = 695f;
		JGKOMJCNOOO = NKIMAOEFFNB + 636f;
	}

	private void OnGUI()
	{
		float hHCDNACACAF = HHCDNACACAF;
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Basic"))
		{
			Tapjoy.TrackEvent("SDKTestEvent", 100L);
			output = "Sent track event with name: SDKTestEvent, " + 100;
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Value"))
		{
			Tapjoy.TrackEvent("SDKTestCategory", "SDKTestEvent", 100L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Param1"))
		{
			Tapjoy.TrackEvent("SDKTestCategory", "SDKTestEvent", "Param1", null, 0L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Param 1 and 2"))
		{
			Tapjoy.TrackEvent("SDKTestCategory", "SDKTestEvent", "Param1", "Param2", 0L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Param 1 with value 1"))
		{
			Tapjoy.TrackEvent("SDKTestCategory", "SDKTestEvent", "Param1", null, 100L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Param 1 and 2 with value 1"))
		{
			Tapjoy.TrackEvent("SDKTestCategory", "SDKTestEvent", "Param1", "Param2", 100L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Param 1 and 2 with value 1 and 2"))
		{
			Tapjoy.TrackEvent("SDKTestCategory", "SDKTestEvent", "Param1", "Param2", "TestKey1", 100L, "TestKey2", 200L, null, 0L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "All"))
		{
			Tapjoy.TrackEvent("SDKTestCategory", "SDKTestEvent", "Param1", "Param2", "TestKey1", 100L, "TestKey2", 200L, "TestKey3", 300L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 200f, hHCDNACACAF, 400f, 150f), output, NNJIHIJGACG);
	}

	private void LMGKFBLNEJP()
	{
		float hHCDNACACAF = HHCDNACACAF;
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "NDNBPKKAKDJ"))
		{
			Tapjoy.TrackEvent("Minion/{0}", 100L);
			output = "hero_icon_{0}" + 15;
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "상급 공격력 문양"))
		{
			Tapjoy.TrackEvent("skill1_voice", "Particle/Olaf/skill2_hit", -62L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "The number of buffers to remove must be a nonnegative, nonzero integer."))
		{
			Tapjoy.TrackEvent("{0}", "setOfferwallTitleBackgroundColor", "실버", null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, " /  vector : "))
		{
			Tapjoy.TrackEvent("skill1", " (SoftClip)", "hit", "\n[CCFFCC]{0}[-] : {1}", 1L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "어제 좀 정신이 없었지?! 난 '메리나' 라고해!"))
		{
			Tapjoy.TrackEvent("레벨당 5초당 마나회복", " 문양", "Hero1", null, 7L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "방어력 25%관통. 적 챔피언에게 물리피해를 입히면 고통스러운 상처를 남김"))
		{
			Tapjoy.TrackEvent("productId", "{ ", "]", "Hero5", 49L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "CreateSkill2Missile"))
		{
			Tapjoy.TrackEvent("괜한 오해로 너희들을 힘들게 했군..\n\t\t\t 미안하니 우리 마을에서 잠시 쉬어 갈 수 있게 도와 주겠다.\n\t\t\t 날 따라와라!!", "Hero1", "[", "<null>", "didGiveRewardItem", 79L, "skill3", 199L, null, 0L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "{0}위 {1}"))
		{
			Tapjoy.TrackEvent("魔術滲透", "MsgManager", "skill1_hit", "setExceptionPermissionList", " ", 112L, "Unkown", -25L, "접속중", 180L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 745f, hHCDNACACAF, 1132f, 603f), output, NNJIHIJGACG);
	}

	private void AFBPNJAKNGG()
	{
	}

	private void PAJOOFIAPMI()
	{
		Debug.Log("접속중");
		ANEGODBOELE();
	}

	private void BGHDCPECHHD()
	{
		float hHCDNACACAF = HHCDNACACAF;
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill2"))
		{
			Tapjoy.TrackEvent("sivir_passive", 80L);
			output = "Awarded Currency -- " + -46;
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "{0}경험치"))
		{
			Tapjoy.TrackEvent("하급 마나 재생 표식", "ElapsedTime ", 126L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "치명적 트롤러로 게임을 하실 수 없습니다\n[FFCCCC](탈주 및 신고, 트롤행위 등)[-]\n\n내일 출석 체크를 하시면 위험수준이 낮아져요"))
		{
			Tapjoy.TrackEvent("{0}\n\n{1}", "Default", "내가 거는 저주를 받게된다", null, 0L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "0.00"))
		{
			Tapjoy.TrackEvent("addToWishList", "로그아웃 하시겠습니까?\n\n계정이 로그아웃되며 게임은 종료됩니다", "해킹이 감지되었습니다 [G11]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", "Sound", 0L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "中"))
		{
			Tapjoy.TrackEvent("[VNET ] 버전 오류\n게임 인증 응답 경로          ", "Vertical", "이동속도 {0}% 증가\n", null, -109L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill2_voice"))
		{
			Tapjoy.TrackEvent("가시 갑옷", "吸血", "]", "skill0_hit", 49L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill3_shadow_c1"))
		{
			Tapjoy.TrackEvent("[", "{0:N0}", "buff_shield_loop", ", balance: ", "{0}코인이 지급되었습니다", -55L, "skill2", -156L, null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Hidden/"))
		{
			Tapjoy.TrackEvent("skill1", "hit2", "{0}", "UI/Lobby/AttendanceInfo", "TestKey3", -82L, ".", 119L, "sound", 171L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 1386f, hHCDNACACAF, 235f, 405f), output, NNJIHIJGACG);
	}

	private void CKBKLKCLLNC()
	{
		float hHCDNACACAF = HHCDNACACAF;
		Rect position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "attack_missile"))
		{
			Tapjoy.TrackEvent("Tapjoy Connect Sample App", 53L);
			output = "skill3_voice" + -127;
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill1_1"))
		{
			Tapjoy.TrackEvent("방어력 25%관통. 적 챔피언에게 물리피해를 입히면 고통스러운 상처를 남김", "게임중", 106L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "skill1_loop"))
		{
			Tapjoy.TrackEvent("Hero/{0}", "_AccumOrig", "skill2_timer", null, 0L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, " "))
		{
			Tapjoy.TrackEvent("상급 성장 마나 표식", "skill3_loop", "ProjectT 는 5명의 영웅이 전투를 벌이는 RPG 게임입니다.\r\n전열,중열,후열에 맞게 영웅을 배치하여 전략적인 전투가 진행됩니다.", "레드 수퍼미니언", 1L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "FxmTestControls.m_bMinimize"))
		{
			Tapjoy.TrackEvent("true", "skill3_voice", ".", null, 85L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "설명"))
		{
			Tapjoy.TrackEvent("이제 본격적으로 시작하는 건가?!", "Hero10002", "skill3_missile", "OnAssistHeroRpc", 74L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		position = new Rect(GOFIAPOAJLE - LIDKPHLOBHO - AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "Particle/Brand/passive_ex"))
		{
			Tapjoy.TrackEvent("새로운 방 생성 중.", "새로운 방 생성 중...", "- Serialize List -\n", "skill0", "F1", -79L, "전송에 성공하였어요!\n\n전송된 코인은 총 [FFFFCC]{0:N0} 코인[-]\n\n막타의신을 재시작 한후 우편함을 확인해주세요", -98L, null, 1L);
		}
		position = new Rect(GOFIAPOAJLE + AIEFIADDFMC, hHCDNACACAF, LIDKPHLOBHO, NKIMAOEFFNB);
		if (GUI.Button(position, "{0}"))
		{
			Tapjoy.TrackEvent("vayne_skill3", "skill2", "OnReceiveFriendChat", "market://details?id=com.zestyroad.rebirthhero", "하급 주문력 문양", -128L, "SDKTestEvent", 161L, "&", 157L);
		}
		hHCDNACACAF += JGKOMJCNOOO;
		GUI.Label(new Rect(GOFIAPOAJLE - 1671f, hHCDNACACAF, 1885f, 236f), output, NNJIHIJGACG);
	}
}
