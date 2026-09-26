using Nas;
using UnityEngine;

public class NasServerUITest : MonoBehaviour
{
	public string _handlerName;

	private void Start()
	{
		Screen.orientation = ScreenOrientation.Portrait;
		bool testMode = false;
		string userid = "사용자ID";
		Plugin.Instance.init(testMode, userid, _handlerName);
	}

	private void Update()
	{
		if (Application.platform == RuntimePlatform.Android && Input.GetKeyUp(KeyCode.Escape))
		{
			Application.Quit();
		}
	}

	private void OnGUI()
	{
		GUIStyle gUIStyle = new GUIStyle(GUI.skin.button);
		gUIStyle.fontSize = 50;
		if (GUI.Button(new Rect(30f, 100f, Screen.width - 60, 100f), "광고리스트", gUIStyle))
		{
			Debug.Log("광고리스트");
			string userData = "USER_DATA";
			Plugin.Instance.open(userData);
		}
		if (GUI.Button(new Rect(30f, 230f, Screen.width - 60, 100f), "광고리스트 타겟팅", gUIStyle))
		{
			Debug.Log("광고리스트 타겟팅");
			Plugin.Instance.open("USER_DATA", 20, 2);
		}
		if (GUI.Button(new Rect(30f, 360f, Screen.width - 60, 100f), "적립금 조회", gUIStyle))
		{
			Debug.Log("적립금 조회");
			Plugin.Instance.getUserPoint();
		}
		if (GUI.Button(new Rect(30f, 490f, Screen.width - 60, 100f), "아이템 한개구매", gUIStyle))
		{
			Debug.Log("아이템 한개구매");
			Plugin.Instance.purchaseItem("Android 아이템아이디");
		}
		if (GUI.Button(new Rect(30f, 620f, Screen.width - 60, 100f), "아이템 여러개구매", gUIStyle))
		{
			Debug.Log("아이템 여러개구매");
			Plugin.Instance.purchaseItem("Android 아이템아이디", 3);
		}
	}
}
