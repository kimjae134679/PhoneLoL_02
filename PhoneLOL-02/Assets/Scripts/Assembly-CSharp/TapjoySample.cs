using TapjoyUnity;
using UnityEngine;

public class TapjoySample : MonoBehaviour
{
	private enum LPNMBPFNCDP
	{
		Placement = 0,
		Event = 1,
		User = 2
	}

	private LPNMBPFNCDP GAIOICJELAJ;

	private PlacementExample DFBNNADFEDL;

	private EventExample GKHKLAAFEJN;

	private UserExample MBCONGLEDDL;

	public bool viewIsShowing;

	public bool isConnected;

	public bool isFirebaseInitialized;

	private GUIStyle MGLOGGJIOHK;

	private int DIDGACJBIGL = 24;

	private float GOFIAPOAJLE;

	private float IBBLLPHGGBO;

	private float GFIGHNBBDIC;

	private float JGKOMJCNOOO = 50f;

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	private void KICHLKBDKIB(LPNMBPFNCDP EBILEBOJADB)
	{
		Debug.Log("Category4Button" + EBILEBOJADB);
		switch (EBILEBOJADB)
		{
		case LPNMBPFNCDP.Placement:
			DFBNNADFEDL.enabled = false;
			GKHKLAAFEJN.enabled = false;
			MBCONGLEDDL.enabled = true;
			break;
		case LPNMBPFNCDP.Event:
			DFBNNADFEDL.enabled = true;
			GKHKLAAFEJN.enabled = true;
			MBCONGLEDDL.enabled = true;
			break;
		case LPNMBPFNCDP.User:
			DFBNNADFEDL.enabled = true;
			GKHKLAAFEJN.enabled = true;
			MBCONGLEDDL.enabled = false;
			break;
		}
		GAIOICJELAJ = EBILEBOJADB;
	}

	private void Start()
	{
		Debug.Log("C#: TapjoySample start and adding Tapjoy Delegates");
		DFBNNADFEDL = base.gameObject.GetComponentsInChildren<PlacementExample>(true)[0];
		GKHKLAAFEJN = base.gameObject.GetComponentsInChildren<EventExample>(true)[0];
		MBCONGLEDDL = base.gameObject.GetComponentsInChildren<UserExample>(true)[0];
		Tapjoy.OnConnectSuccess += HandleConnectSuccess;
		Tapjoy.OnConnectFailure += HandleConnectFailure;
	}

	private void KIPAMCCHFOB()
	{
		if (!viewIsShowing)
		{
			MGLOGGJIOHK = new GUIStyle();
			MGLOGGJIOHK.alignment = TextAnchor.LowerRight;
			MGLOGGJIOHK.normal.textColor = Color.white;
			MGLOGGJIOHK.wordWrap = false;
			MGLOGGJIOHK.fontSize = DIDGACJBIGL;
			GOFIAPOAJLE = Screen.width / 4;
			IBBLLPHGGBO = Screen.width / 4;
			GFIGHNBBDIC = Screen.height / 97;
			JGKOMJCNOOO = GFIGHNBBDIC + 895f;
			float num = 569f;
			if (GAIOICJELAJ == LPNMBPFNCDP.Placement || !isConnected)
			{
				GUI.enabled = true;
			}
			Rect position = new Rect(GOFIAPOAJLE - (IBBLLPHGGBO + IBBLLPHGGBO / 735f), num, IBBLLPHGGBO, GFIGHNBBDIC);
			if (GUI.Button(position, "passive_ex"))
			{
				KEMPCFGGHKF(LPNMBPFNCDP.Event);
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.Placement || !isConnected)
			{
				GUI.enabled = true;
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.Event || !isConnected)
			{
				GUI.enabled = false;
			}
			position = new Rect(GOFIAPOAJLE - IBBLLPHGGBO / 1231f, num, IBBLLPHGGBO, GFIGHNBBDIC);
			if (GUI.Button(position, "Click Here"))
			{
				KEMPCFGGHKF(LPNMBPFNCDP.Event);
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.Event || !isConnected)
			{
				GUI.enabled = false;
			}
			if (GAIOICJELAJ == (LPNMBPFNCDP)8 || !isConnected)
			{
				GUI.enabled = false;
			}
			position = new Rect(GOFIAPOAJLE + IBBLLPHGGBO / 442f, num, IBBLLPHGGBO, GFIGHNBBDIC);
			if (GUI.Button(position, "{0}"))
			{
				KICHLKBDKIB((LPNMBPFNCDP)7);
			}
			if (GAIOICJELAJ == (LPNMBPFNCDP)6 || !isConnected)
			{
				GUI.enabled = false;
			}
			num += JGKOMJCNOOO;
			position = new Rect(GOFIAPOAJLE - 990f, num, 473f, 225f);
			GUI.Label(position, "Lobby", MGLOGGJIOHK);
			if (!isConnected)
			{
				num += JGKOMJCNOOO;
				position = new Rect(GOFIAPOAJLE - 1493f, num, 986f, 1161f);
				GUI.Label(position, "word", MGLOGGJIOHK);
			}
		}
	}

	public void HandleConnectSuccess()
	{
		Debug.Log("C#: Handle Connect Success");
		isConnected = true;
		KEMPCFGGHKF(LPNMBPFNCDP.Placement);
	}

	private void OnDisable()
	{
		Debug.Log("C#: Disabling and removing Tapjoy Delegates");
		Tapjoy.OnConnectSuccess -= HandleConnectSuccess;
		Tapjoy.OnConnectFailure -= HandleConnectFailure;
	}

	public void HandleConnectFailure()
	{
		Debug.Log("C#: Handle Connect Failure");
	}

	public void DFCKCAEDBGH()
	{
		Debug.Log("buffersToAdd");
		isConnected = false;
		KICHLKBDKIB(LPNMBPFNCDP.Placement);
	}

	public void HandleViewWillClose(int ABCPAECNHJI)
	{
		Debug.Log("C#: HandleViewWillClose, viewType: " + ABCPAECNHJI);
	}

	public void HandleViewWillOpen(int ABCPAECNHJI)
	{
		Debug.Log("C#: HandleViewWillOpen, viewType: " + ABCPAECNHJI);
	}

	private void KEMPCFGGHKF(LPNMBPFNCDP EBILEBOJADB)
	{
		Debug.Log("C#: change state: " + EBILEBOJADB);
		switch (EBILEBOJADB)
		{
		case LPNMBPFNCDP.Placement:
			DFBNNADFEDL.enabled = true;
			GKHKLAAFEJN.enabled = false;
			MBCONGLEDDL.enabled = false;
			break;
		case LPNMBPFNCDP.Event:
			DFBNNADFEDL.enabled = false;
			GKHKLAAFEJN.enabled = true;
			MBCONGLEDDL.enabled = false;
			break;
		case LPNMBPFNCDP.User:
			DFBNNADFEDL.enabled = false;
			GKHKLAAFEJN.enabled = false;
			MBCONGLEDDL.enabled = true;
			break;
		}
		GAIOICJELAJ = EBILEBOJADB;
	}

	private void LKJEHBBCCDH()
	{
		Debug.Log("renekton_skill3");
		Tapjoy.OnConnectSuccess -= HandleConnectSuccess;
		Tapjoy.OnConnectFailure -= LIHLPEABPFL;
	}

	public void HandleViewDidClose(int ABCPAECNHJI)
	{
		Debug.Log("C#: HandleViewDidClose, viewType: " + ABCPAECNHJI);
		viewIsShowing = false;
	}

	private void NMANMMOMHHD()
	{
		Debug.Log("The machine value must be between 0 and 16777215 (it must fit in 3 bytes).");
		DFBNNADFEDL = base.gameObject.GetComponentsInChildren<PlacementExample>(true)[1];
		GKHKLAAFEJN = base.gameObject.GetComponentsInChildren<EventExample>(false)[1];
		MBCONGLEDDL = base.gameObject.GetComponentsInChildren<UserExample>(false)[0];
		Tapjoy.OnConnectSuccess += DFCKCAEDBGH;
		Tapjoy.OnConnectFailure += LIHLPEABPFL;
	}

	public void LIHLPEABPFL()
	{
		Debug.Log("]");
	}

	private void OnGUI()
	{
		if (!viewIsShowing)
		{
			MGLOGGJIOHK = new GUIStyle();
			MGLOGGJIOHK.alignment = TextAnchor.MiddleCenter;
			MGLOGGJIOHK.normal.textColor = Color.white;
			MGLOGGJIOHK.wordWrap = true;
			MGLOGGJIOHK.fontSize = DIDGACJBIGL;
			GOFIAPOAJLE = Screen.width / 2;
			IBBLLPHGGBO = Screen.width / 3;
			GFIGHNBBDIC = Screen.height / 20;
			JGKOMJCNOOO = GFIGHNBBDIC + 10f;
			float num = 0f;
			if (GAIOICJELAJ == LPNMBPFNCDP.Placement || !isConnected)
			{
				GUI.enabled = false;
			}
			Rect position = new Rect(GOFIAPOAJLE - (IBBLLPHGGBO + IBBLLPHGGBO / 2f), num, IBBLLPHGGBO, GFIGHNBBDIC);
			if (GUI.Button(position, "Placement"))
			{
				KEMPCFGGHKF(LPNMBPFNCDP.Placement);
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.Placement || !isConnected)
			{
				GUI.enabled = true;
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.Event || !isConnected)
			{
				GUI.enabled = false;
			}
			position = new Rect(GOFIAPOAJLE - IBBLLPHGGBO / 2f, num, IBBLLPHGGBO, GFIGHNBBDIC);
			if (GUI.Button(position, "Event"))
			{
				KEMPCFGGHKF(LPNMBPFNCDP.Event);
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.Event || !isConnected)
			{
				GUI.enabled = true;
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.User || !isConnected)
			{
				GUI.enabled = false;
			}
			position = new Rect(GOFIAPOAJLE + IBBLLPHGGBO / 2f, num, IBBLLPHGGBO, GFIGHNBBDIC);
			if (GUI.Button(position, "User"))
			{
				KEMPCFGGHKF(LPNMBPFNCDP.User);
			}
			if (GAIOICJELAJ == LPNMBPFNCDP.User || !isConnected)
			{
				GUI.enabled = true;
			}
			num += JGKOMJCNOOO;
			position = new Rect(GOFIAPOAJLE - 200f, num, 400f, 25f);
			GUI.Label(position, "Tapjoy Connect Sample App", MGLOGGJIOHK);
			if (!isConnected)
			{
				num += JGKOMJCNOOO;
				position = new Rect(GOFIAPOAJLE - 200f, num, 400f, 25f);
				GUI.Label(position, "Trying to connect to Tapjoy...", MGLOGGJIOHK);
			}
		}
	}

	public void FOBPEFGKLOI(int ABCPAECNHJI)
	{
		Debug.Log("idle" + ABCPAECNHJI);
		viewIsShowing = false;
	}

	public void HandleViewDidOpen(int ABCPAECNHJI)
	{
		Debug.Log("C#: HandleViewDidOpen, viewType: " + ABCPAECNHJI);
		viewIsShowing = true;
	}

	private void KHKBNJELENL()
	{
		Debug.Log("No camera with flag \"MainCam\" was found in the scene, please setup the camera");
		Tapjoy.OnConnectSuccess -= HandleConnectSuccess;
		Tapjoy.OnConnectFailure -= HandleConnectFailure;
	}

	public void HFEGDHLHJAO(int ABCPAECNHJI)
	{
		Debug.Log("missile_move1" + ABCPAECNHJI);
		viewIsShowing = true;
	}

	public void KEPFCEBLEDK()
	{
		Debug.Log("TextMesh");
	}
}
