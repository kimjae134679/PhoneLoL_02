using Nas;
using UnityEngine;

public class UserServerUITest : MonoBehaviour
{
	public string _handlerName;

	private void Start()
	{
		Screen.orientation = ScreenOrientation.Portrait;
		bool testMode = false;
		Plugin.Instance.init(testMode, _handlerName);
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
			Plugin.Instance.open("USER_DATA");
		}
		if (GUI.Button(new Rect(30f, 230f, Screen.width - 60, 100f), "광고리스트 타겟팅", gUIStyle))
		{
			Debug.Log("광고리스트 타겟팅");
			Plugin.Instance.open("USER_DATA", 20, 2);
		}
	}
}
