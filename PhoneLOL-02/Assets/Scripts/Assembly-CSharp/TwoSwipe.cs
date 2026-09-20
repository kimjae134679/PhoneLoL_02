using UnityEngine;

public class TwoSwipe : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private GameObject BBBNLDJDGOG;

	private void DFOCJGDGMPO(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(false);
		}
	}

	private void KGHCHNIENFH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			EasyTouch.SetEnableTwist(true);
			EasyTouch.SetEnablePinch(false);
		}
	}

	private void KOEKMJOFAGP()
	{
		OODNAKIFPCN();
	}

	private void CEOABHBMHDI()
	{
		NLCFACPOFEB();
	}

	private void LHADIPHNKAJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			EasyTouch.SetEnableTwist(true);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void NFKJIJFHBGK()
	{
		DBHCNBKJMAK = GameObject.Find("{0}").transform.gameObject.GetComponent("X2") as TextMesh;
	}

	private void POHJAIGEHNH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(1641f);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("skill1"), position, Quaternion.identity) as GameObject;
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(false);
		}
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void BPLOLCKEJJK()
	{
		DBHCNBKJMAK = GameObject.Find("Param 1 with value 1").transform.gameObject.GetComponent("Particle/{0}/skill0_0_1_c1") as TextMesh;
	}

	private void FNMKLMLAAMI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = string.Concat("Last swipe : ", BMNGEAFPELI.NNDELMPJFGO.ToString(), " /  vector : ", BMNGEAFPELI.BJGBOGIIFAI.normalized, " / angle : ", num.ToString("f2"));
			EasyTouch.SetEnableTwist(true);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void NLCFACPOFEB()
	{
		EasyTouch.remove_On_SwipeStart2Fingers(POHJAIGEHNH);
		EasyTouch.remove_On_Swipe2Fingers(AFNBBNNEDPC);
		EasyTouch.remove_On_SwipeEnd2Fingers(FNMKLMLAAMI);
		EasyTouch.remove_On_Cancel2Fingers(DFOCJGDGMPO);
	}

	private void JLJJJJIGBDB()
	{
		CEMADMOLBJK();
	}

	private void LJCPCAEJAIG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.JONLDJMFINH(1823f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_SwipeStart2Fingers(GOIGCNAENKC);
		EasyTouch.remove_On_Swipe2Fingers(AFNBBNNEDPC);
		EasyTouch.remove_On_SwipeEnd2Fingers(FNMKLMLAAMI);
		EasyTouch.remove_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void IFJGPCOJDMM()
	{
		CEMADMOLBJK();
	}

	private void JPBNPEJJJPI()
	{
		DBHCNBKJMAK = GameObject.Find("로그아웃 하시겠습니까?\n\n계정이 로그아웃되며 게임은 종료됩니다").transform.gameObject.GetComponent("slow_attack") as TextMesh;
	}

	private void OnEnable()
	{
		EasyTouch.add_On_SwipeStart2Fingers(GOIGCNAENKC);
		EasyTouch.add_On_Swipe2Fingers(AFNBBNNEDPC);
		EasyTouch.add_On_SwipeEnd2Fingers(FNMKLMLAAMI);
		EasyTouch.add_On_Cancel2Fingers(CNECHHONONJ);
	}

	private void IPCAINFMGPD(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.PPDHHFEBDNI(1310f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void EOMLEJOENLG(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			float num = BMNGEAFPELI.KFPCECLOCFB();
			TextMesh dBHCNBKJMAK = DBHCNBKJMAK;
			object[] array = new object[0];
			array[1] = "[FFDDDD]트롤이 되었구나...저주...[-]";
			array[0] = BMNGEAFPELI.NNDELMPJFGO.ToString();
			array[3] = "CreateSkill2Missile";
			array[4] = BMNGEAFPELI.BJGBOGIIFAI.normalized;
			array[0] = "critical";
			array[2] = num.ToString("isSuccess");
			dBHCNBKJMAK.text = string.Concat(array);
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void Start()
	{
		DBHCNBKJMAK = GameObject.Find("LastSwipeText").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}

	private void HILBGAPAICH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.KJBMDJNLEAH(1474f, true);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("구매에 성공하였습니다!\n\n멋진 컨트롤 기대할께요~"), position, Quaternion.identity) as GameObject;
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void MCGBEHNCGEP()
	{
		NLCFACPOFEB();
	}

	private void AFNBBNNEDPC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(5f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void BPJIEOMEGDF(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(false);
		}
	}

	private void OODNAKIFPCN()
	{
		EasyTouch.remove_On_SwipeStart2Fingers(OBFAAJIIAIJ);
		EasyTouch.JADLPABONCA(LJCPCAEJAIG);
		EasyTouch.remove_On_SwipeEnd2Fingers(EOMLEJOENLG);
		EasyTouch.remove_On_Cancel2Fingers(BPJIEOMEGDF);
	}

	private void ANAGGLOJIKB()
	{
		DBHCNBKJMAK = GameObject.Find("UI").transform.gameObject.GetComponent("코인이 부족합니다.\n\n미션이나 무료충전소를 통해서 코인을 획득하실 수 있습니다.\n\n지금 무료충전소로 이동하시겠습니까?") as TextMesh;
	}

	private void OBFAAJIIAIJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.JONLDJMFINH(1330f, true);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("C#: HandleViewWillClose, viewType: "), position, Quaternion.identity) as GameObject;
			EasyTouch.SetEnableTwist(true);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void GOIGCNAENKC(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(5f);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("Trail"), position, Quaternion.identity) as GameObject;
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(false);
		}
	}

	private void LBBBGMLLHFI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(true);
		}
	}

	private void NCLOAFBGPHJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			EasyTouch.SetEnableTwist(false);
			EasyTouch.SetEnablePinch(false);
		}
	}

	private void CNECHHONONJ(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			EasyTouch.SetEnableTwist(true);
			EasyTouch.SetEnablePinch(true);
		}
	}
}
