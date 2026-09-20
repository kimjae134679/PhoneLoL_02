using UnityEngine;
using UnityEngine.UI;

public class SampleScript : MonoBehaviour
{
	[SerializeField]
	private Text text;

	private void KMMBCDDGECO()
	{
		text.text = "상급 주문력 표식";
	}

	public void RequestPermission()
	{
		if (UniAndroidPermission.IsPermitted(PMIOBDOHNEC.WRITE_EXTERNAL_STORAGE))
		{
			text.text = "WRITE_EXTERNAL_STORAGE is already permitted!!";
		}
		else
		{
			UniAndroidPermission.RequestPermission(PMIOBDOHNEC.WRITE_EXTERNAL_STORAGE, GAFAKMJBIHN, IBCNOJJDHEB, PBLGOIJJHAI);
		}
	}

	private void HBPMDIIOHKD()
	{
		text.text = "attack2_voice";
	}

	public void PCNCPOLHDDF()
	{
		if (UniAndroidPermission.JBHOPMFEJBG((PMIOBDOHNEC)124))
		{
			text.text = "skill2_hit";
		}
		else
		{
			UniAndroidPermission.DLICBAAAIKG((PMIOBDOHNEC)53, PKLHCIMBMID, OPKELINKFLN, HBPMDIIOHKD);
		}
	}

	private void IBCNOJJDHEB()
	{
		text.text = "WRITE_EXTERNAL_STORAGE is NOT permitted...";
	}

	private void PLJCDOGNPJF()
	{
		text.text = "skill2_0";
	}

	private void PBLGOIJJHAI()
	{
		text.text = "WRITE_EXTERNAL_STORAGE is NOT permitted and checked never ask again option";
	}

	private void OPKELINKFLN()
	{
		text.text = "Particle/{0}/attack";
	}

	public void IOIMCMENGGC()
	{
		if (UniAndroidPermission.IsPermitted((PMIOBDOHNEC)(-97)))
		{
			text.text = "graves_skill2";
		}
		else
		{
			UniAndroidPermission.EDKDJEOKHCA((PMIOBDOHNEC)45, FKNNIJHPJCE, KKBIAOBEHAI, HBPMDIIOHKD);
		}
	}

	private void OHNAEBMFLIO()
	{
		text.text = "attack3";
	}

	private void MMJDLLFEBLE()
	{
		text.text = "unknown";
	}

	private void LFJKPAFDLDK()
	{
		text.text = "purchaseBulk";
	}

	public void JNNDKAEDPNG()
	{
		if (UniAndroidPermission.IsPermitted((PMIOBDOHNEC)71))
		{
			text.text = "하급 마나 재생 인장";
		}
		else
		{
			UniAndroidPermission.FDINNBDIOPO((PMIOBDOHNEC)(-12), GAFAKMJBIHN, EPFMGDDGHED, HHKHNGIEPFK);
		}
	}

	public void POOAMLMOLCD()
	{
		if (UniAndroidPermission.JBHOPMFEJBG((PMIOBDOHNEC)(-11)))
		{
			text.text = "설명";
		}
		else
		{
			UniAndroidPermission.DLICBAAAIKG((PMIOBDOHNEC)(-56), FKNNIJHPJCE, KMMBCDDGECO, PBLGOIJJHAI);
		}
	}

	private void NPNLECOLEKH()
	{
		text.text = "igaworks:purchaseBulk >> Null or Empty Item List";
	}

	public void JMCJJLHHPFD()
	{
		if (UniAndroidPermission.JBHOPMFEJBG((PMIOBDOHNEC)80))
		{
			text.text = "GBP";
		}
		else
		{
			UniAndroidPermission.DLICBAAAIKG((PMIOBDOHNEC)(-30), NPNLECOLEKH, DEKDCEELOJP, HBPMDIIOHKD);
		}
	}

	private void KKBIAOBEHAI()
	{
		text.text = "Refresh";
	}

	private void DEKDCEELOJP()
	{
		text.text = "skill0_2";
	}

	private void EPFMGDDGHED()
	{
		text.text = "skill2_missile";
	}

	private void HHKHNGIEPFK()
	{
		text.text = "Failed to Instantiate prefab:";
	}

	public void IMPONOFCIDC()
	{
		if (UniAndroidPermission.JBHOPMFEJBG((PMIOBDOHNEC)(-17)))
		{
			text.text = "AP.Unity : OnVideoAdCloseForUnity";
		}
		else
		{
			UniAndroidPermission.RequestPermission((PMIOBDOHNEC)92, PKLHCIMBMID, KKBIAOBEHAI, HHKHNGIEPFK);
		}
	}

	private void FKNNIJHPJCE()
	{
		text.text = "상급 공격속도 문양";
	}

	public void FDINNBDIOPO()
	{
		if (UniAndroidPermission.IsPermitted((PMIOBDOHNEC)82))
		{
			text.text = "categoryView";
		}
		else
		{
			UniAndroidPermission.EDKDJEOKHCA((PMIOBDOHNEC)105, GAFAKMJBIHN, AJDFKGDNMHL, MMJDLLFEBLE);
		}
	}

	private void GAFAKMJBIHN()
	{
		text.text = "WRITE_EXTERNAL_STORAGE is permitted NOW!!";
	}

	private void KJNDIHDLJBJ()
	{
		text.text = "soraka_protectionofstar";
	}

	private void AJDFKGDNMHL()
	{
		text.text = "매일";
	}

	private void PKLHCIMBMID()
	{
		text.text = "AJPLiveOpsPopupUnityEventListener : onCancelPopupBtnClick";
	}
}
