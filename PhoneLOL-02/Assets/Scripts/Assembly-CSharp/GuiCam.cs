using UnityEngine;

public class GuiCam : MonoBehaviour
{
	private void OnGUI()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1024f, (float)Screen.height / 768f, 1f));
		GUI.Box(new Rect(0f, -4f, 1024f, 30f), string.Empty);
		GUILayout.Label("Free camera ctrl or alt key to simulate the second finger");
		GUILayout.Space(15f);
		GUILayout.Label("1 finger => Look around");
		GUILayout.Label("2 fingers => Move forward");
		GUILayout.Label("3 fingers => Move backward");
		if (GUI.Button(new Rect(412f, 700f, 200f, 50f), "Main menu"))
		{
			Application.LoadLevel("StartMenu");
		}
	}

	private void BECBNCOAEAF()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 190f, (float)Screen.height / 235f, 466f));
		GUI.Box(new Rect(912f, 893f, 1742f, 902f), string.Empty);
		GUILayout.Label("skill0_missile_hit");
		GUILayout.Space(1039f);
		GUILayout.Label("ChangeMeshColor mFilter.mesh : ");
		GUILayout.Label("중급 성장 주문력 인장", new GUILayoutOption[1]);
		GUILayout.Label("talon_skill2");
		if (GUI.Button(new Rect(728f, 977f, 1860f, 1035f), "게임실행을 위해 권한수락을 부탁드려요"))
		{
			Application.LoadLevel("Nexus");
		}
	}

	private void LMGKFBLNEJP()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1324f, (float)Screen.height / 60f, 969f));
		GUI.Box(new Rect(118f, 851f, 213f, 1765f), string.Empty);
		GUILayout.Label("5초당 마나회복");
		GUILayout.Space(665f);
		GUILayout.Label("destroyAllPopups", new GUILayoutOption[1]);
		GUILayout.Label("(용사님들 이쪽에 생존자가 있습니다.", new GUILayoutOption[1]);
		GUILayout.Label("다른 플레이어들을 기다려 주세요.", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(1490f, 647f, 1081f, 1717f), "플래티넘"))
		{
			Application.LoadLevel("NDNBPKKAKDJ");
		}
	}

	private void BNMMFBNCOBE()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 663f, (float)Screen.height / 1606f, 1125f));
		GUI.Box(new Rect(1185f, 1892f, 23f, 1409f), string.Empty);
		GUILayout.Label("0.0");
		GUILayout.Space(1048f);
		GUILayout.Label("코인이 부족합니다");
		GUILayout.Label("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON");
		GUILayout.Label("skill3_shark");
		if (GUI.Button(new Rect(251f, 1205f, 585f, 1763f), "마법저항력"))
		{
			Application.LoadLevel("상급 성장 체력 정수");
		}
	}

	private void GPDFCFBNDJJ()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 884f, (float)Screen.height / 948f, 1269f));
		GUI.Box(new Rect(1158f, 1859f, 1132f, 965f), string.Empty);
		GUILayout.Label("CreateSkill3Missile", new GUILayoutOption[1]);
		GUILayout.Space(1376f);
		GUILayout.Label("Delta pinch : ", new GUILayoutOption[1]);
		GUILayout.Label("AP.Unity : OnVideoAdCloseForUnity");
		GUILayout.Label("Clear");
		if (GUI.Button(new Rect(1893f, 1966f, 1987f, 1801f), "하급 방어력 표식"))
		{
			Application.LoadLevel("UI");
		}
	}

	private void AAICEEAEGIO()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1025f, (float)Screen.height / 988f, 75f));
		GUI.Box(new Rect(143f, 1917f, 1108f, 1282f), string.Empty);
		GUILayout.Label("move_speed");
		GUILayout.Space(989f);
		GUILayout.Label("Silver");
		GUILayout.Label("AP.Unity : OnLoadVideoAdFailureForUnity", new GUILayoutOption[1]);
		GUILayout.Label("\n", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(1530f, 1442f, 1302f, 945f), "Shadow"))
		{
			Application.LoadLevel("블루 근접미니언");
		}
	}
}
