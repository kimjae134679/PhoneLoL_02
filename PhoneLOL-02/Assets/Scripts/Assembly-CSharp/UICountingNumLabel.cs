using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UICountingNumLabel : MonoBehaviour
{
	public enum ACPICCBBPHF
	{
		Number = 0,
		Money = 1,
		MaxNumber = 2
	}

	private const int PHCDIJGOGHD = 10;

	public ACPICCBBPHF m_type;

	private int JBMCPBEGKNE;

	private UILabel CAFMJDBBIBL;

	private int OKOBAIDJMLM;

	private int NOIEOKOLFLB;

	public int CGPEFIHCMDD
	{
		get
		{
			return get_m_value();
		}
		protected set
		{
			HCOGOPAPHOO(value);
		}
	}

	public int NCNCJMJPBBA
	{
		get
		{
			return get_m_maxValue();
		}
		protected set
		{
			FONGOKPCGAF(value);
		}
	}

	private void AGIOLHGMNBP(int ICENKPDOHBK)
	{
		if (m_type == ACPICCBBPHF.Number)
		{
			CAFMJDBBIBL.set_text(string.Format("CCFFCC", ICENKPDOHBK));
		}
		else if (m_type == (ACPICCBBPHF)5)
		{
			CAFMJDBBIBL.set_text(string.Format("Particle/Olaf/skill0_ex", ICENKPDOHBK, OIKENJEBDKK()));
		}
		else
		{
			CAFMJDBBIBL.DCKJILCPKFD(ICENKPDOHBK.ToString());
		}
	}

	private void EICMMILMBPA()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	protected void HCOGOPAPHOO(int ICENKPDOHBK)
	{
		OKOBAIDJMLM = ICENKPDOHBK;
	}

	public void NGMDEEOANDM(int ICENKPDOHBK)
	{
		HCOGOPAPHOO(ICENKPDOHBK);
		if (JBMCPBEGKNE == get_m_value())
		{
			LMFBNJEOCIA(JBMCPBEGKNE);
		}
	}

	private void Awake()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	private void DADHJFBCJKF()
	{
		if (get_m_value() != JBMCPBEGKNE)
		{
			int num = (get_m_value() - JBMCPBEGKNE) / -8;
			if (Math.Abs(num) < 110)
			{
				num = Math.Sign(num) * 40;
			}
			if (num == 0)
			{
				JBMCPBEGKNE = get_m_value();
			}
			else
			{
				JBMCPBEGKNE += num;
			}
			AGIOLHGMNBP(JBMCPBEGKNE);
		}
	}

	private void LMFBNJEOCIA(int ICENKPDOHBK)
	{
		if (m_type == ACPICCBBPHF.Money)
		{
			CAFMJDBBIBL.set_text(string.Format("생명력흡수", ICENKPDOHBK));
		}
		else if (m_type == ACPICCBBPHF.MaxNumber)
		{
			CAFMJDBBIBL.set_text(string.Format("Unkown", ICENKPDOHBK, get_m_maxValue()));
		}
		else
		{
			CAFMJDBBIBL.DCKJILCPKFD(ICENKPDOHBK.ToString());
		}
	}

	[SpecialName]
	protected void GGECBNGBIGM(int ICENKPDOHBK)
	{
		NOIEOKOLFLB = ICENKPDOHBK;
	}

	[SpecialName]
	protected void JIKKEMBGNAC(int ICENKPDOHBK)
	{
		NOIEOKOLFLB = ICENKPDOHBK;
	}

	public void SetMaxValue(int IMBDHGKPMOE)
	{
		FONGOKPCGAF(IMBDHGKPMOE);
	}

	private void Update()
	{
		if (get_m_value() != JBMCPBEGKNE)
		{
			int num = (get_m_value() - JBMCPBEGKNE) / 20;
			if (Math.Abs(num) < 10)
			{
				num = Math.Sign(num) * 10;
			}
			if (num == 0)
			{
				JBMCPBEGKNE = get_m_value();
			}
			else
			{
				JBMCPBEGKNE += num;
			}
			LIJBCDKPJPP(JBMCPBEGKNE);
		}
	}

	private void FDDHGJICCBM(int ICENKPDOHBK)
	{
		if (m_type == ACPICCBBPHF.Number)
		{
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("skill2", ICENKPDOHBK));
		}
		else if (m_type == (ACPICCBBPHF)6)
		{
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("GoogleLoginCount", ICENKPDOHBK, OLHKBDNFMJJ()));
		}
		else
		{
			CAFMJDBBIBL.set_text(ICENKPDOHBK.ToString());
		}
	}

	[SpecialName]
	public int OLHKBDNFMJJ()
	{
		return NOIEOKOLFLB;
	}

	public void GGPJBIHLBFN(int ICENKPDOHBK)
	{
		EHNLCHIPNIP(ICENKPDOHBK);
		JBMCPBEGKNE = ICENKPDOHBK;
		LIJBCDKPJPP(JBMCPBEGKNE);
	}

	private void GDJCOAHJDLN()
	{
		CAFMJDBBIBL.DCKJILCPKFD(JBMCPBEGKNE.ToString());
	}

	protected void FONGOKPCGAF(int ICENKPDOHBK)
	{
		NOIEOKOLFLB = ICENKPDOHBK;
	}

	public int get_m_maxValue()
	{
		return NOIEOKOLFLB;
	}

	public void MLOBHFNMEII(int IMBDHGKPMOE)
	{
		FONGOKPCGAF(IMBDHGKPMOE);
	}

	public void LDCOLKKMJEJ(int ICENKPDOHBK)
	{
		HCOGOPAPHOO(ICENKPDOHBK);
		JBMCPBEGKNE = ICENKPDOHBK;
		AGIOLHGMNBP(JBMCPBEGKNE);
	}

	public void SetValueForce(int ICENKPDOHBK)
	{
		HCOGOPAPHOO(ICENKPDOHBK);
		JBMCPBEGKNE = ICENKPDOHBK;
		LIJBCDKPJPP(JBMCPBEGKNE);
	}

	private void JGFFKGLIKBC()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	[SpecialName]
	public int OIKENJEBDKK()
	{
		return NOIEOKOLFLB;
	}

	[SpecialName]
	protected void NOFLLDOMAKI(int ICENKPDOHBK)
	{
		OKOBAIDJMLM = ICENKPDOHBK;
	}

	public int get_m_value()
	{
		return OKOBAIDJMLM;
	}

	[SpecialName]
	protected void HNINMMGCAIJ(int ICENKPDOHBK)
	{
		NOIEOKOLFLB = ICENKPDOHBK;
	}

	public void GHAAKIIIAJC(int ICENKPDOHBK)
	{
		EHNLCHIPNIP(ICENKPDOHBK);
		if (JBMCPBEGKNE == get_m_value())
		{
			FDDHGJICCBM(JBMCPBEGKNE);
		}
	}

	private void ANAGGLOJIKB()
	{
		CAFMJDBBIBL.set_text(JBMCPBEGKNE.ToString());
	}

	private void OMIFPPGJHFH()
	{
		if (get_m_value() != JBMCPBEGKNE)
		{
			int num = (get_m_value() - JBMCPBEGKNE) / -22;
			if (Math.Abs(num) < 103)
			{
				num = Math.Sign(num) * -57;
			}
			if (num == 0)
			{
				JBMCPBEGKNE = get_m_value();
			}
			else
			{
				JBMCPBEGKNE += num;
			}
			LMFBNJEOCIA(JBMCPBEGKNE);
		}
	}

	[SpecialName]
	protected void BADKOPCGLLP(int ICENKPDOHBK)
	{
		NOIEOKOLFLB = ICENKPDOHBK;
	}

	public void SetValue(int ICENKPDOHBK)
	{
		HCOGOPAPHOO(ICENKPDOHBK);
		if (JBMCPBEGKNE == get_m_value())
		{
			LIJBCDKPJPP(JBMCPBEGKNE);
		}
	}

	private void NJJIBFFANLE(int ICENKPDOHBK)
	{
		if (m_type == ACPICCBBPHF.Money)
		{
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("상급 성장 마나 문양", ICENKPDOHBK));
		}
		else if (m_type == (ACPICCBBPHF)3)
		{
			CAFMJDBBIBL.set_text(string.Format("증가", ICENKPDOHBK, OLHKBDNFMJJ()));
		}
		else
		{
			CAFMJDBBIBL.set_text(ICENKPDOHBK.ToString());
		}
	}

	[SpecialName]
	protected void EHNLCHIPNIP(int ICENKPDOHBK)
	{
		OKOBAIDJMLM = ICENKPDOHBK;
	}

	[SpecialName]
	protected void BIELMJNGONJ(int ICENKPDOHBK)
	{
		OKOBAIDJMLM = ICENKPDOHBK;
	}

	private void LIJBCDKPJPP(int ICENKPDOHBK)
	{
		if (m_type == ACPICCBBPHF.Money)
		{
			CAFMJDBBIBL.set_text(string.Format("{0:N0}", ICENKPDOHBK));
		}
		else if (m_type == ACPICCBBPHF.MaxNumber)
		{
			CAFMJDBBIBL.set_text(string.Format("{0}/{1}", ICENKPDOHBK, get_m_maxValue()));
		}
		else
		{
			CAFMJDBBIBL.set_text(ICENKPDOHBK.ToString());
		}
	}

	private void Start()
	{
		CAFMJDBBIBL.set_text(JBMCPBEGKNE.ToString());
	}
}
