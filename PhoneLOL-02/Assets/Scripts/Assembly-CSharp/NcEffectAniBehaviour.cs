using UnityEngine;

public class NcEffectAniBehaviour : NcEffectBehaviour
{
	protected GLONLENANOI OLDKLNCLBAJ;

	protected GameObject PLOIJMMEDON;

	protected bool HOIMFLAHEDF;

	public string m_OnEndAniFunction = "OnEndAnimation";

	public bool FKLLMMHGPID()
	{
		return HOIMFLAHEDF;
	}

	public virtual void BOBKEMJEALD()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.NDBEHNIGEAJ();
		}
	}

	protected void JDHLKHJFADL()
	{
		if (OLDKLNCLBAJ == null)
		{
			OLDKLNCLBAJ = new GLONLENANOI();
		}
		HOIMFLAHEDF = false;
		OLDKLNCLBAJ.NFKJIJFHBGK();
	}

	public bool DAHIONECKHG()
	{
		return HOIMFLAHEDF;
	}

	protected void ALAMJEOLLAH()
	{
		HOIMFLAHEDF = true;
		if (PLOIJMMEDON != null)
		{
			PLOIJMMEDON.SendMessage(m_OnEndAniFunction, this, SendMessageOptions.DontRequireReceiver);
		}
	}

	public virtual void ALIIDIGDDDF()
	{
		HOIMFLAHEDF = true;
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.NDKCFGFNNLO(626f);
		}
	}

	public virtual void HCBINEBINKP(float CGJKLDDCNHO)
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.MBFBGLJMLMI(CGJKLDDCNHO);
		}
	}

	public virtual void EBDEFIBILII(float CGJKLDDCNHO)
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.MBFBGLJMLMI(CGJKLDDCNHO);
		}
	}

	protected void BMGIGCPNNKM()
	{
		HOIMFLAHEDF = false;
		if (PLOIJMMEDON != null)
		{
			PLOIJMMEDON.SendMessage(m_OnEndAniFunction, this, SendMessageOptions.RequireReceiver);
		}
	}

	public bool PIIMHJFFKMG()
	{
		return OLDKLNCLBAJ == null || OLDKLNCLBAJ.LPCEBMNDMJG();
	}

	public virtual void LGAEAAEECDA()
	{
		HOIMFLAHEDF = true;
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.NDKCFGFNNLO(982f);
		}
	}

	public void IFHLHMEGAOM(GameObject BAKLEJFGGHE, string GFNJCLDCGJN)
	{
		PLOIJMMEDON = BAKLEJFGGHE;
		m_OnEndAniFunction = GFNJCLDCGJN;
	}

	public bool IsEndAnimation()
	{
		return HOIMFLAHEDF;
	}

	public bool IsStartAnimation()
	{
		return OLDKLNCLBAJ != null && OLDKLNCLBAJ.LPCEBMNDMJG();
	}

	public virtual void OOLHLPKEGLI()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.APHCABDEOHF();
		}
	}

	public virtual void ResetAnimation()
	{
		HOIMFLAHEDF = false;
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.MBFBGLJMLMI(0f);
		}
	}

	public bool OCBLHCLIEKA()
	{
		return HOIMFLAHEDF;
	}

	public virtual void DIAFBCKPMCJ(float CGJKLDDCNHO)
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.MBFBGLJMLMI(CGJKLDDCNHO);
		}
	}

	public virtual void KOABOHOCCDD()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.HKACEBOBAGK();
		}
	}

	protected void MMBKNEDOEHG()
	{
		if (OLDKLNCLBAJ == null)
		{
			OLDKLNCLBAJ = new GLONLENANOI();
		}
		HOIMFLAHEDF = true;
		OLDKLNCLBAJ.NFKJIJFHBGK();
	}

	public void SetCallBackEndAnimation(GameObject BAKLEJFGGHE, string GFNJCLDCGJN)
	{
		PLOIJMMEDON = BAKLEJFGGHE;
		m_OnEndAniFunction = GFNJCLDCGJN;
	}

	public virtual void ResumeAnimation()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.HKACEBOBAGK();
		}
	}

	protected void KJMAHKIMHPM()
	{
		if (OLDKLNCLBAJ == null)
		{
			OLDKLNCLBAJ = new GLONLENANOI();
		}
		HOIMFLAHEDF = false;
		OLDKLNCLBAJ.BFGLBEPNDLB();
	}

	public void OBDONGAKLHC(GameObject BAKLEJFGGHE)
	{
		PLOIJMMEDON = BAKLEJFGGHE;
	}

	public virtual void MoveAnimation(float CGJKLDDCNHO)
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.MBFBGLJMLMI(CGJKLDDCNHO);
		}
	}

	public virtual void NOLFPOBLNMP()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.HKACEBOBAGK();
		}
	}

	public void SetCallBackEndAnimation(GameObject BAKLEJFGGHE)
	{
		PLOIJMMEDON = BAKLEJFGGHE;
	}

	public virtual void FJBHIEEHGOG()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.HKACEBOBAGK();
		}
	}

	public void KGPBGADPNNJ(GameObject BAKLEJFGGHE, string GFNJCLDCGJN)
	{
		PLOIJMMEDON = BAKLEJFGGHE;
		m_OnEndAniFunction = GFNJCLDCGJN;
	}

	public virtual void NBEDMLNPEOJ()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.APHCABDEOHF();
		}
	}

	public bool JGHEOOFJAHC()
	{
		return HOIMFLAHEDF;
	}

	public virtual void PauseAnimation()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.NDBEHNIGEAJ();
		}
	}

	public void IBHELDDCENN(GameObject BAKLEJFGGHE, string GFNJCLDCGJN)
	{
		PLOIJMMEDON = BAKLEJFGGHE;
		m_OnEndAniFunction = GFNJCLDCGJN;
	}

	protected void BPMHCNIAOLP()
	{
		HOIMFLAHEDF = false;
		if (PLOIJMMEDON != null)
		{
			PLOIJMMEDON.SendMessage(m_OnEndAniFunction, this, SendMessageOptions.RequireReceiver);
		}
	}

	public virtual void DNENCOGDAAL()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.KEIMLHDCJMC();
		}
	}

	public virtual void AKDBGMBJPHC()
	{
		if (OLDKLNCLBAJ != null)
		{
			OLDKLNCLBAJ.HKACEBOBAGK();
		}
	}
}
