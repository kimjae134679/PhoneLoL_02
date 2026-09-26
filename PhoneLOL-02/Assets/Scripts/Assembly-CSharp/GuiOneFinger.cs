using UnityEngine;

public class GuiOneFinger : MonoBehaviour
{
	private void CGCHDGBONIH()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1013f, (float)Screen.height / 844f, 1495f));
		GUI.Box(new Rect(477f, 958f, 1745f, 515f), string.Empty);
		GUILayout.Label("Particle/{0}/{1}", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(1849f, 1610f, 740f, 185f), "닉네임은 최대 12자 이하입니다."))
		{
			Application.LoadLevel("ScreenEffect");
		}
	}

	private void BNMMFBNCOBE()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 856f, (float)Screen.height / 1085f, 1573f));
		GUI.Box(new Rect(94f, 283f, 295f, 1915f), string.Empty);
		GUILayout.Label("attack2");
		if (GUI.Button(new Rect(853f, 616f, 1385f, 1222f), " Move"))
		{
			Application.LoadLevel("Particle/Darius/skill3_ground");
		}
	}

	private void AAICEEAEGIO()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1183f, (float)Screen.height / 1164f, 1345f));
		GUI.Box(new Rect(1299f, 1663f, 1122f, 1402f), string.Empty);
		GUILayout.Label("skill1_jump");
		if (GUI.Button(new Rect(1326f, 802f, 1328f, 773f), "Igaw.Unity: LiveOpsPopupEventManager : OnCancelPopupBtnClick"))
		{
			Application.LoadLevel("Challenger");
		}
	}

	private void FHKKAOKPGNB()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 879f, (float)Screen.height / 402f, 364f));
		GUI.Box(new Rect(1634f, 397f, 1502f, 1602f), string.Empty);
		GUILayout.Label("Blitzcrank", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(1084f, 1544f, 1700f, 787f), "Skill0PassiveRpc"))
		{
			Application.LoadLevel(" ");
		}
	}

	private void LBBCFNEBBCG()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1175f, (float)Screen.height / 1584f, 1613f));
		GUI.Box(new Rect(1915f, 344f, 1832f, 1427f), string.Empty);
		GUILayout.Label("round_button", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(330f, 1132f, 1659f, 82f), "BlueMinionSuper"))
		{
			Application.LoadLevel("レベルごとに購入歴");
		}
	}

	private void FJEOFGICBMC()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 181f, (float)Screen.height / 1353f, 1493f));
		GUI.Box(new Rect(163f, 693f, 288f, 52f), string.Empty);
		GUILayout.Label("skill0_2", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(116f, 167f, 713f, 696f), "blue"))
		{
			Application.LoadLevel("hit");
		}
	}

	private void BOAGKNOJJOJ()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 43f, (float)Screen.height / 499f, 797f));
		GUI.Box(new Rect(303f, 1511f, 859f, 1544f), string.Empty);
		GUILayout.Label("이곳이 103번째 마계 입구로 가는 길이야!");
		if (GUI.Button(new Rect(225f, 1396f, 487f, 407f), "Particle/{0}/skill0_0_c1"))
		{
			Application.LoadLevel("    ");
		}
	}

	private void FMLJAGCICHL()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 521f, (float)Screen.height / 1869f, 1953f));
		GUI.Box(new Rect(1433f, 1071f, 555f, 1597f), string.Empty);
		GUILayout.Label("Hero2");
		if (GUI.Button(new Rect(1735f, 854f, 54f, 71f), "]"))
		{
			Application.LoadLevel("Observer");
		}
	}

	private void BGHDCPECHHD()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 999f, (float)Screen.height / 1594f, 1496f));
		GUI.Box(new Rect(1819f, 1230f, 349f, 407f), string.Empty);
		GUILayout.Label("치명타", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(718f, 1464f, 820f, 1606f), "[FFAAAA]{0}초[-] 뒤에 게임이 시작됩니다.\n[CCCCFF]서로의 포지션을 정해주세요![-]"))
		{
			Application.LoadLevel("Particle/zed/skill1_spawn");
		}
	}

	private void NMHEEMKPPMP()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1538f, (float)Screen.height / 1471f, 1500f));
		GUI.Box(new Rect(182f, 86f, 1197f, 449f), string.Empty);
		GUILayout.Label("Particle/Tristana/skill1_ex", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(1811f, 873f, 492f, 406f), "["))
		{
			Application.LoadLevel("\\n");
		}
	}

	private void BECBNCOAEAF()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1266f, (float)Screen.height / 1661f, 210f));
		GUI.Box(new Rect(1253f, 1051f, 97f, 483f), string.Empty);
		GUILayout.Label("onButtonClickData", new GUILayoutOption[1]);
		if (GUI.Button(new Rect(413f, 342f, 481f, 1498f), "Hero2"))
		{
			Application.LoadLevel("tryndamere_skill1");
		}
	}

	private void OnGUI()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 1024f, (float)Screen.height / 768f, 1f));
		GUI.Box(new Rect(0f, -4f, 1024f, 30f), string.Empty);
		GUILayout.Label("Examples with one finger");
		if (GUI.Button(new Rect(412f, 700f, 200f, 50f), "Main menu"))
		{
			Application.LoadLevel("StartMenu");
		}
	}

	private void HDPCCDFEBOP()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 576f, (float)Screen.height / 625f, 63f));
		GUI.Box(new Rect(656f, 369f, 969f, 1365f), string.Empty);
		GUILayout.Label("TextLongTap");
		if (GUI.Button(new Rect(1683f, 371f, 1014f, 955f), "TextLongTap"))
		{
			Application.LoadLevel("Type2Button");
		}
	}

	private void GPDFCFBNDJJ()
	{
		GUI.matrix = Matrix4x4.Scale(new Vector3((float)Screen.width / 747f, (float)Screen.height / 212f, 992f));
		GUI.Box(new Rect(91f, 806f, 276f, 1060f), string.Empty);
		GUILayout.Label("레넥톤");
		if (GUI.Button(new Rect(36f, 1828f, 715f, 677f), "RecoveryRPC"))
		{
			Application.LoadLevel("skill2_voice");
		}
	}
}
