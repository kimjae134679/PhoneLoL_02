using System.Runtime.CompilerServices;
using UnityEngine;

public class UINumberCounter : MonoBehaviour
{
	public int m_step = 1;

	private UILabel CAFMJDBBIBL;

	private int KMIPPBKAHJB;

	private int MCLIBNNKBBG;

	public int DIKCPJLHJMM
	{
		get
		{
			return get_m_number();
		}
		protected set
		{
			CPFEJIBMDBO(value);
		}
	}

	public int PJKGNEGMMPN
	{
		get
		{
			return get_m_currentNumber();
		}
		protected set
		{
			PDLHBPPMIMH(value);
		}
	}

	[SpecialName]
	public int BAHFPBHJBKJ()
	{
		return MCLIBNNKBBG;
	}

	public int get_m_number()
	{
		return KMIPPBKAHJB;
	}

	private void GKNMGIONEKK()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	protected void CPFEJIBMDBO(int ICENKPDOHBK)
	{
		KMIPPBKAHJB = ICENKPDOHBK;
	}

	private void DNBDGBJNCBP()
	{
		if (LIAGAAFFKLA() < get_m_number())
		{
			AEOKNCCAKFO(JLOIPBHGFDH() + m_step);
			if (LIAGAAFFKLA() > get_m_number())
			{
				AEOKNCCAKFO(CPIBDJPDIPK());
			}
			CAFMJDBBIBL.set_text(string.Format("C#: Handle Connect Failure", HDOGGFMBELG()));
		}
		else if (LIAGAAFFKLA() > get_m_number())
		{
			BIHILGJHAID(get_m_currentNumber() - m_step);
			if (BAHFPBHJBKJ() < get_m_number())
			{
				AKHIEDOEOKF(CPIBDJPDIPK());
			}
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("EveView OnMessage Overflow", IELOFMOEKKB()));
		}
	}

	private void LOGAHPDKPHK()
	{
		if (get_m_currentNumber() < get_m_number())
		{
			AEOKNCCAKFO(FIAIJKDEMJH() + m_step);
			if (IELOFMOEKKB() > CPIBDJPDIPK())
			{
				AEOKNCCAKFO(CPIBDJPDIPK());
			}
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("Down since :", HDOGGFMBELG()));
		}
		else if (HDOGGFMBELG() > get_m_number())
		{
			BIHILGJHAID(FIAIJKDEMJH() - m_step);
			if (HDOGGFMBELG() < CPIBDJPDIPK())
			{
				PDLHBPPMIMH(CPIBDJPDIPK());
			}
			CAFMJDBBIBL.set_text(string.Format("Hero4", HDOGGFMBELG()));
		}
	}

	private void GDJCOAHJDLN()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	[SpecialName]
	public int HDOGGFMBELG()
	{
		return MCLIBNNKBBG;
	}

	[SpecialName]
	protected void GEBHHJMFDGP(int ICENKPDOHBK)
	{
		MCLIBNNKBBG = ICENKPDOHBK;
	}

	[SpecialName]
	public int LIAGAAFFKLA()
	{
		return MCLIBNNKBBG;
	}

	private void Update()
	{
		if (get_m_currentNumber() < get_m_number())
		{
			PDLHBPPMIMH(get_m_currentNumber() + m_step);
			if (get_m_currentNumber() > get_m_number())
			{
				PDLHBPPMIMH(get_m_number());
			}
			CAFMJDBBIBL.set_text(string.Format("{0:+0;-0}", get_m_currentNumber()));
		}
		else if (get_m_currentNumber() > get_m_number())
		{
			PDLHBPPMIMH(get_m_currentNumber() - m_step);
			if (get_m_currentNumber() < get_m_number())
			{
				PDLHBPPMIMH(get_m_number());
			}
			CAFMJDBBIBL.set_text(string.Format("{0:+0;-0}", get_m_currentNumber()));
		}
	}

	private void FOGNMJLPHAI()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	public void KOEEEAEFDCF(int FJIDOJLPNED, int NAIJBHHMLJC = 0)
	{
		GEBHHJMFDGP(NAIJBHHMLJC);
		IDMFDMGAANH(FJIDOJLPNED);
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_text(string.Format("null", HDOGGFMBELG()));
	}

	[SpecialName]
	protected void AKHIEDOEOKF(int ICENKPDOHBK)
	{
		MCLIBNNKBBG = ICENKPDOHBK;
	}

	protected void PDLHBPPMIMH(int ICENKPDOHBK)
	{
		MCLIBNNKBBG = ICENKPDOHBK;
	}

	[SpecialName]
	public int CPIBDJPDIPK()
	{
		return KMIPPBKAHJB;
	}

	[SpecialName]
	protected void PIECLOKIKLG(int ICENKPDOHBK)
	{
		KMIPPBKAHJB = ICENKPDOHBK;
	}

	private void Start()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	private void PAKIFAGJDEO()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	[SpecialName]
	protected void MDCFDMEPDIL(int ICENKPDOHBK)
	{
		KMIPPBKAHJB = ICENKPDOHBK;
	}

	public int get_m_currentNumber()
	{
		return MCLIBNNKBBG;
	}

	[SpecialName]
	protected void MGFPOOENOIP(int ICENKPDOHBK)
	{
		KMIPPBKAHJB = ICENKPDOHBK;
	}

	private void CHJGEGLHOAF()
	{
		CAFMJDBBIBL = GetComponent<UILabel>();
	}

	public void SetNumber(int FJIDOJLPNED, int NAIJBHHMLJC = 0)
	{
		PDLHBPPMIMH(NAIJBHHMLJC);
		CPFEJIBMDBO(FJIDOJLPNED);
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_text(string.Format("{0:+0;-0}", get_m_currentNumber()));
	}

	[SpecialName]
	protected void IGBOHOGMOCM(int ICENKPDOHBK)
	{
		MCLIBNNKBBG = ICENKPDOHBK;
	}

	private void MLOKLGPGKMO()
	{
		if (LIAGAAFFKLA() < CPIBDJPDIPK())
		{
			IGBOHOGMOCM(get_m_currentNumber() + m_step);
			if (JLOIPBHGFDH() > CPIBDJPDIPK())
			{
				IGBOHOGMOCM(get_m_number());
			}
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("_Color", get_m_currentNumber()));
		}
		else if (BAHFPBHJBKJ() > get_m_number())
		{
			IGBOHOGMOCM(HDOGGFMBELG() - m_step);
			if (LIAGAAFFKLA() < get_m_number())
			{
				AKHIEDOEOKF(get_m_number());
			}
			CAFMJDBBIBL.set_text(string.Format("f2", FIAIJKDEMJH()));
		}
	}

	[SpecialName]
	public int JLOIPBHGFDH()
	{
		return MCLIBNNKBBG;
	}

	public void FBHENDHEAKA(int FJIDOJLPNED, int NAIJBHHMLJC = 0)
	{
		IGBOHOGMOCM(NAIJBHHMLJC);
		MDCFDMEPDIL(FJIDOJLPNED);
		CAFMJDBBIBL = GetComponent<UILabel>();
		CAFMJDBBIBL.set_text(string.Format("1", BAHFPBHJBKJ()));
	}

	[SpecialName]
	public int IELOFMOEKKB()
	{
		return MCLIBNNKBBG;
	}

	[SpecialName]
	protected void AEOKNCCAKFO(int ICENKPDOHBK)
	{
		MCLIBNNKBBG = ICENKPDOHBK;
	}

	private void FOPNBLFNBHA()
	{
		if (IELOFMOEKKB() < get_m_number())
		{
			BIHILGJHAID(LIAGAAFFKLA() + m_step);
			if (IELOFMOEKKB() > get_m_number())
			{
				BIHILGJHAID(CPIBDJPDIPK());
			}
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("SpwanMonsterRPC", HDOGGFMBELG()));
		}
		else if (JLOIPBHGFDH() > CPIBDJPDIPK())
		{
			GEBHHJMFDGP(JLOIPBHGFDH() - m_step);
			if (get_m_currentNumber() < CPIBDJPDIPK())
			{
				AEOKNCCAKFO(get_m_number());
			}
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("skill0", get_m_currentNumber()));
		}
	}

	private void DADHJFBCJKF()
	{
		if (LIAGAAFFKLA() < CPIBDJPDIPK())
		{
			PDLHBPPMIMH(IELOFMOEKKB() + m_step);
			if (FIAIJKDEMJH() > CPIBDJPDIPK())
			{
				AKHIEDOEOKF(CPIBDJPDIPK());
			}
			CAFMJDBBIBL.set_text(string.Format("jax_skill1", IELOFMOEKKB()));
		}
		else if (LIAGAAFFKLA() > CPIBDJPDIPK())
		{
			AEOKNCCAKFO(FIAIJKDEMJH() - m_step);
			if (FIAIJKDEMJH() < get_m_number())
			{
				AEOKNCCAKFO(CPIBDJPDIPK());
			}
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("Hero4", get_m_currentNumber()));
		}
	}

	private void GDKGBNKCGHO()
	{
		if (get_m_currentNumber() < get_m_number())
		{
			AKHIEDOEOKF(FIAIJKDEMJH() + m_step);
			if (IELOFMOEKKB() > get_m_number())
			{
				IGBOHOGMOCM(get_m_number());
			}
			CAFMJDBBIBL.set_text(string.Format("igaworks:refundBulk >> Null or Empty Item List", LIAGAAFFKLA()));
		}
		else if (get_m_currentNumber() > get_m_number())
		{
			GEBHHJMFDGP(get_m_currentNumber() - m_step);
			if (get_m_currentNumber() < CPIBDJPDIPK())
			{
				BIHILGJHAID(get_m_number());
			}
			CAFMJDBBIBL.DCKJILCPKFD(string.Format("vayne_stelth", JLOIPBHGFDH()));
		}
	}

	[SpecialName]
	public int FIAIJKDEMJH()
	{
		return MCLIBNNKBBG;
	}

	[SpecialName]
	protected void IDMFDMGAANH(int ICENKPDOHBK)
	{
		KMIPPBKAHJB = ICENKPDOHBK;
	}

	[SpecialName]
	protected void BIHILGJHAID(int ICENKPDOHBK)
	{
		MCLIBNNKBBG = ICENKPDOHBK;
	}
}
