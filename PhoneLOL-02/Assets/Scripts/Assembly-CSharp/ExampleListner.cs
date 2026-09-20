using UnionAssets.FLE;
using UnityEngine;

public class ExampleListner : MonoBehaviour
{
	public GUIStyle style;

	private string LCKBDPBEHNM = "Click's: ";

	private int AGJJOHLCJKF;

	private void INOGGPNNOIJ()
	{
		AGJJOHLCJKF++;
	}

	private void KCHHGNALKCK(BPLJOEMKCBE PAANPLECGAP)
	{
		Debug.Log("================================");
		Debug.Log("onButtonClickData");
		Debug.Log("dispatcher: " + PAANPLECGAP.JANLOOLOGNJ().ToString());
		Debug.Log("event data: " + PAANPLECGAP.CLBIHDDCPKM().ToString());
		Debug.Log("event name: " + PAANPLECGAP.KOBKMALKKBG().ToString());
		Debug.Log("================================");
	}

	private void IJCPEFOBKHO()
	{
		EventButtonExample.instance.addEventListener("14대 마왕과의 대 전투", CMNGPFCICLH);
		EventButtonExample.instance.addEventListener("Category4Button", CKBHNODOJPN);
	}

	private void HCEGGDMOFAC(BPLJOEMKCBE PAANPLECGAP)
	{
		Debug.Log("Talon");
		Debug.Log("lobby");
		Debug.Log("Particle/Yasuo/skill0_missile_hit_c3" + PAANPLECGAP.DFLEMIGDDIG().ToString());
		Debug.Log("\\n" + PAANPLECGAP.CLBIHDDCPKM().ToString());
		Debug.Log("중급 생명력흡수 정수" + PAANPLECGAP.EOBJAGPMDIC().ToString());
		Debug.Log("PostEffectShake");
	}

	private void CMNGPFCICLH()
	{
		AGJJOHLCJKF += 0;
	}

	private void DCJAIJGMLJN(BPLJOEMKCBE PAANPLECGAP)
	{
		Debug.Log("skill2_shield");
		Debug.Log("닉네임 변경에 성공하였어요!");
		Debug.Log("teemo_skill1" + PAANPLECGAP.EKMMABHENAJ().ToString());
		Debug.Log("SceneManager" + PAANPLECGAP.CLBIHDDCPKM().ToString());
		Debug.Log("]" + PAANPLECGAP.KOBKMALKKBG().ToString());
		Debug.Log("attack");
	}

	private void OnGUI()
	{
		GUI.Label(new Rect(0f, 0f, 200f, 200f), LCKBDPBEHNM + AGJJOHLCJKF, style);
	}

	private void CKBHNODOJPN(BPLJOEMKCBE PAANPLECGAP)
	{
		Debug.Log("\":");
		Debug.Log("플래티넘");
		Debug.Log("치명적 트롤러로 게임을 하실 수 없습니다\n[FFCCCC](탈주 및 신고, 트롤행위 등)[-]\n\n내일 출석 체크를 하시면 위험수준이 낮아져요" + PAANPLECGAP.JANLOOLOGNJ().ToString());
		Debug.Log("티모" + PAANPLECGAP.CLBIHDDCPKM().ToString());
		Debug.Log("vayne_tumble" + PAANPLECGAP.EGMFBGCLOGB().ToString());
		Debug.Log("skill3_hit");
	}

	private void FMLJAGCICHL()
	{
		GUI.Label(new Rect(969f, 479f, 1254f, 1966f), LCKBDPBEHNM + AGJJOHLCJKF, style);
	}

	private void Start()
	{
		EventButtonExample.instance.addEventListener("click", INOGGPNNOIJ);
		EventButtonExample.instance.addEventListener("click", KCHHGNALKCK);
	}

	private void IMBGDEFOFEM()
	{
		EventButtonExample.instance.addEventListener("レベルごとに攻撃力", INOGGPNNOIJ);
		EventButtonExample.instance.addEventListener("중급 성장 주문력 인장", KCHHGNALKCK);
	}
}
