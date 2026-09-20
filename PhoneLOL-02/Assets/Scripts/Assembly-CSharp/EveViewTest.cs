using EveEngine;
using UnityEngine;

public class EveViewTest : MonoBehaviour
{
	private GameObject BPKDBKHFFOK;

	private void PCAIPLFLPBG(object[] GMJOHJJGBMK)
	{
	}

	public void OnClickTest()
	{
		EveView component = GetComponent<EveView>();
		component.RPC("TestRPC2", DJJPAPENCLN.All);
	}

	private void IMBGDEFOFEM()
	{
	}

	[JDLHECHNNDH]
	private void OBPOFNGPDCL(int ICENKPDOHBK, string KHNJCKLKKAO)
	{
		MsgManager.get_Instance().ShowTip(ICENKPDOHBK + " " + KHNJCKLKKAO);
	}

	private void OnClick()
	{
		if (BPKDBKHFFOK == null)
		{
			BPKDBKHFFOK = EveUnityNetwork.get_Instance().Instantiate("Test", Vector3.zero, Quaternion.identity);
			return;
		}
		EveUnityNetwork.get_Instance().Destroy(BPKDBKHFFOK);
		BPKDBKHFFOK = null;
	}

	private void Update()
	{
	}

	private void DLCNJHLBIFM()
	{
	}

	private void PCGCMGEMJBH(object[] GMJOHJJGBMK)
	{
	}

	private void FOGNMJLPHAI()
	{
	}

	private void LKJDPGDPMLO(NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (OGJFDNEEDCP.BNENHLMHIII())
		{
			Vector3 HCKCCHPJOPI = base.transform.localPosition;
			OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI);
		}
		else
		{
			Vector3 HCKCCHPJOPI2 = Vector3.zero;
			OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
			base.transform.localPosition = HCKCCHPJOPI2;
		}
	}

	[JDLHECHNNDH]
	private void PJFLGEBFFLC()
	{
		MsgManager.get_Instance().ShowTip("TestRPC2");
	}

	private void MLOKLGPGKMO()
	{
	}

	private void FEBJDAHIPII()
	{
		if (BPKDBKHFFOK == null)
		{
			BPKDBKHFFOK = EveUnityNetwork.get_Instance().KAFACOAKPOJ("vladimir_skill3", Vector3.zero, Quaternion.identity);
			return;
		}
		EveUnityNetwork.get_Instance().ALNEBAOOFBP(BPKDBKHFFOK);
		BPKDBKHFFOK = null;
	}

	public void CFFBPEDCIJP()
	{
		EveView component = GetComponent<EveView>();
		component.RPC("{0} pool", DJJPAPENCLN.Others, new object[1]);
	}

	private void IPDDEIBPEEK(NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (OGJFDNEEDCP.BNENHLMHIII())
		{
			Vector3 HCKCCHPJOPI = base.transform.localPosition;
			OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
		}
		else
		{
			Vector3 HCKCCHPJOPI2 = Vector3.zero;
			OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
			base.transform.localPosition = HCKCCHPJOPI2;
		}
	}

	private void PKHGHIPGIED(NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (OGJFDNEEDCP.BNENHLMHIII())
		{
			Vector3 HCKCCHPJOPI = base.transform.localPosition;
			OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI);
		}
		else
		{
			Vector3 HCKCCHPJOPI2 = Vector3.zero;
			OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
			base.transform.localPosition = HCKCCHPJOPI2;
		}
	}

	public void JEFFNEBKOBG()
	{
		EveView component = GetComponent<EveView>();
		component.RPC("다이아몬드", DJJPAPENCLN.Others, new object[1]);
	}

	private void DNBDGBJNCBP()
	{
	}

	private void CLLECEEEJAI()
	{
	}

	public void DNAIENBNEML()
	{
		EveView component = GetComponent<EveView>();
		component.RPC("하급 성장 공격력 표식", DJJPAPENCLN.All);
	}

	private void FMNOLGPIIFB()
	{
	}

	private void HGCHEGNNALC()
	{
		MsgManager.get_Instance().LBCFANDMCON("masteryi_skill3");
	}

	private void Start()
	{
	}
}
