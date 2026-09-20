using UnityEngine;

public class Swipe : MonoBehaviour
{
	private TextMesh DBHCNBKJMAK;

	private GameObject BBBNLDJDGOG;

	private void LOKIALNKABF(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			float num = BMNGEAFPELI.BPHMNCGOKJA();
			TextMesh dBHCNBKJMAK = DBHCNBKJMAK;
			object[] array = new object[8];
			array[0] = "B";
			array[1] = BMNGEAFPELI.NNDELMPJFGO.ToString();
			array[0] = "E68D00";
			array[4] = BMNGEAFPELI.BJGBOGIIFAI.normalized;
			array[2] = "attack";
			array[0] = num.ToString("FxmTestControls.m_fTimeScale");
			dBHCNBKJMAK.text = string.Concat(array);
		}
	}

	private void BFJPAIGMIFK(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(5f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void KJCMCJKEBEO()
	{
		EasyTouch.remove_On_SwipeStart(JBBFMCBBIPO);
		EasyTouch.remove_On_Swipe(FCOPPPBGOHN);
		EasyTouch.remove_On_SwipeEnd(PEIAOINKPHH);
	}

	private void MNNGIGELCHH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO == 0 && BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.GCBDPDJEFMO(242f);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("skill2_2"), position, Quaternion.identity) as GameObject;
		}
	}

	private void DFOBLLAMHHA(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.JONLDJMFINH(585f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void JBBFMCBBIPO(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO == 0 && BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.EBOPOAAOPGE(1200f);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("]"), position, Quaternion.identity) as GameObject;
		}
	}

	private void PGECONIAALI(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.EBOPOAAOPGE(467f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void FCOOCIECLGH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			float num = BMNGEAFPELI.AIBKNBEIECC();
			DBHCNBKJMAK.text = string.Concat("Last swipe : ", BMNGEAFPELI.NNDELMPJFGO.ToString(), " /  vector : ", BMNGEAFPELI.BJGBOGIIFAI.normalized, " / angle : ", num.ToString("f2"));
		}
	}

	private void OnEnable()
	{
		EasyTouch.add_On_SwipeStart(NNKJJEOADNH);
		EasyTouch.add_On_Swipe(BFJPAIGMIFK);
		EasyTouch.add_On_SwipeEnd(FCOOCIECLGH);
	}

	private void BALBBDCPHBB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.BNEGFOLCCDM(88f, true);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void DFOCBKNIDGB()
	{
		EasyTouch.JDJGIPNNCDJ(HFPHJHALADH);
		EasyTouch.add_On_Swipe(FCOPPPBGOHN);
		EasyTouch.add_On_SwipeEnd(PEIAOINKPHH);
	}

	private void HFPHJHALADH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO == 0 && BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.GCBDPDJEFMO(277f);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("bgm_lobby"), position, Quaternion.identity) as GameObject;
		}
	}

	private void PEIAOINKPHH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Object.Destroy(BBBNLDJDGOG);
			float num = BMNGEAFPELI.KFPCECLOCFB();
			TextMesh dBHCNBKJMAK = DBHCNBKJMAK;
			object[] array = new object[8];
			array[0] = "RefreshGuildMemberList";
			array[1] = BMNGEAFPELI.NNDELMPJFGO.ToString();
			array[5] = "buff_shield_loop";
			array[6] = BMNGEAFPELI.BJGBOGIIFAI.normalized;
			array[5] = "中級";
			array[4] = num.ToString("Line");
			dBHCNBKJMAK.text = string.Concat(array);
		}
	}

	private void EKKMNFJLGJH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO == 0 && BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.BNEGFOLCCDM(313f, true);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("Skill3Rpc"), position, Quaternion.identity) as GameObject;
		}
	}

	private void OJLBKJAMLCO()
	{
		EasyTouch.remove_On_SwipeStart(MNNGIGELCHH);
		EasyTouch.remove_On_Swipe(CDKHKKNCDLL);
		EasyTouch.remove_On_SwipeEnd(LOKIALNKABF);
	}

	private void FCOPPPBGOHN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.JONLDJMFINH(1373f, true);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void LPAOAJBEJPB(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(1148f, true);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void ICACNPOPMIL()
	{
		EasyTouch.add_On_SwipeStart(DBEKOOHHCFO);
		EasyTouch.add_On_Swipe(CDKHKKNCDLL);
		EasyTouch.add_On_SwipeEnd(FCOOCIECLGH);
	}

	private void OnDestroy()
	{
		CEMADMOLBJK();
	}

	private void DBEKOOHHCFO(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO == 0 && BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.EBOPOAAOPGE(534f);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("liandry_torment"), position, Quaternion.identity) as GameObject;
		}
	}

	private void NLCFACPOFEB()
	{
		EasyTouch.remove_On_SwipeStart(EKKMNFJLGJH);
		EasyTouch.remove_On_Swipe(CBKEMMLGHFM);
		EasyTouch.remove_On_SwipeEnd(FCOOCIECLGH);
	}

	private void CEOABHBMHDI()
	{
		NLCFACPOFEB();
	}

	private void ELPIBDJAKIN(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.KJBMDJNLEAH(838f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void LCBNJAKFLMK()
	{
		KJCMCJKEBEO();
	}

	private void CEMADMOLBJK()
	{
		EasyTouch.remove_On_SwipeStart(NNKJJEOADNH);
		EasyTouch.remove_On_Swipe(BFJPAIGMIFK);
		EasyTouch.remove_On_SwipeEnd(FCOOCIECLGH);
	}

	private void CBKEMMLGHFM(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.GCBDPDJEFMO(1427f, true);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void JBJBNNPMGII()
	{
		KJCMCJKEBEO();
	}

	private void OnDisable()
	{
		CEMADMOLBJK();
	}

	private void NNKJJEOADNH(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BMNGEAFPELI.NKGNNOMNIKO == 0 && BBBNLDJDGOG == null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(5f);
			BBBNLDJDGOG = Object.Instantiate(Resources.Load("Trail"), position, Quaternion.identity) as GameObject;
		}
	}

	private void CFEIPPFANKJ()
	{
		EasyTouch.JDJGIPNNCDJ(EKKMNFJLGJH);
		EasyTouch.add_On_Swipe(DFOBLLAMHHA);
		EasyTouch.add_On_SwipeEnd(FCOOCIECLGH);
	}

	private void MCGBEHNCGEP()
	{
		CEMADMOLBJK();
	}

	private void JIMPGFGADPK()
	{
		DBHCNBKJMAK = GameObject.Find("P2P Change Master {0}").transform.gameObject.GetComponent("상급 방어력 문양") as TextMesh;
	}

	private void CDKHKKNCDLL(NLKIHCFELMK BMNGEAFPELI)
	{
		if (BBBNLDJDGOG != null)
		{
			Vector3 position = BMNGEAFPELI.DACNFMFLPDH(913f);
			BBBNLDJDGOG.transform.position = position;
		}
	}

	private void KOEKMJOFAGP()
	{
		NLCFACPOFEB();
	}

	private void Start()
	{
		DBHCNBKJMAK = GameObject.Find("LastSwipeText").transform.gameObject.GetComponent("TextMesh") as TextMesh;
	}
}
