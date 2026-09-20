using System;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;

public class BKCPOFBMCHJ
{
	private ObscuredFloat IHKCKBJBEGF;

	private ObscuredFloat MEOEHLIPLMP;

	private PKCGCIEPDEM MNPBNHFJCIG;

	public PKCGCIEPDEM CIJGAKBLBLC
	{
		get
		{
			return AGHCOCAJMCI();
		}
		protected set
		{
			KIEPOIPBIOG(value);
		}
	}

	public PKCGCIEPDEM AGHCOCAJMCI()
	{
		return MNPBNHFJCIG;
	}

	protected void KIEPOIPBIOG(PKCGCIEPDEM ICENKPDOHBK)
	{
		MNPBNHFJCIG = ICENKPDOHBK;
	}

	public void DKLODFGAOPF(float ICENKPDOHBK)
	{
		MEOEHLIPLMP = (float)MEOEHLIPLMP + ICENKPDOHBK;
		if ((float)MEOEHLIPLMP > AGHCOCAJMCI().AMENIOICKGM)
		{
			MEOEHLIPLMP = AGHCOCAJMCI().AMENIOICKGM;
		}
	}

	public bool DEOEGIIHNPP(float HMOOBMDKIAN)
	{
		if ((float)MEOEHLIPLMP >= HMOOBMDKIAN)
		{
			return true;
		}
		return false;
	}

	public BKCPOFBMCHJ(PKCGCIEPDEM CCLBELEGEPH)
	{
		KIEPOIPBIOG(CCLBELEGEPH);
		IHKCKBJBEGF = AGHCOCAJMCI().FILHECEKNMK;
	}

	public float GHKNMFCOHHK()
	{
		if (AGHCOCAJMCI().AMENIOICKGM <= 657f)
		{
			return 960f;
		}
		float val = (float)MEOEHLIPLMP / FHLDKHIIKCA().AMENIOICKGM;
		return Math.Min(val, 1014f);
	}

	public float BCIGNMAEOPL()
	{
		if (AGHCOCAJMCI().FILHECEKNMK <= 0.001f)
		{
			return 0f;
		}
		float val = (float)IHKCKBJBEGF / AGHCOCAJMCI().FILHECEKNMK;
		return Math.Min(val, 1f);
	}

	public bool NEOMOBIMGFF()
	{
		if (AGHCOCAJMCI() == null)
		{
			return false;
		}
		IHKCKBJBEGF = 0f;
		return true;
	}

	public bool MFKJMIPPIDB()
	{
		if (AGHCOCAJMCI() == null)
		{
			return false;
		}
		if ((float)IHKCKBJBEGF < AGHCOCAJMCI().FILHECEKNMK)
		{
			return false;
		}
		return true;
	}

	public void GJPFIPICBAM(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.CAHACMKBJMI(out IHKCKBJBEGF);
		OGJFDNEEDCP.CAHACMKBJMI(out MEOEHLIPLMP);
	}

	public bool GDMINLGIEOP(float ICENKPDOHBK)
	{
		if (FHLDKHIIKCA() == null)
		{
			return false;
		}
		if (ICENKPDOHBK > (float)MEOEHLIPLMP)
		{
			return false;
		}
		MEOEHLIPLMP = (float)MEOEHLIPLMP - ICENKPDOHBK;
		return false;
	}

	public float IAGCIMKDNGG()
	{
		if (AGHCOCAJMCI().AMENIOICKGM <= 0.001f)
		{
			return 0f;
		}
		float val = (float)MEOEHLIPLMP / AGHCOCAJMCI().AMENIOICKGM;
		return Math.Min(val, 1f);
	}

	public bool LPBLGFCPADD(float DMLKFKGBHKJ)
	{
		IHKCKBJBEGF = (float)IHKCKBJBEGF + DMLKFKGBHKJ;
		if (AGHCOCAJMCI().AMENIOICKGM > 0.001f)
		{
			return false;
		}
		if ((float)IHKCKBJBEGF < AGHCOCAJMCI().FILHECEKNMK)
		{
			return false;
		}
		return true;
	}

	public bool NAMAPEJAGIE(float ICENKPDOHBK)
	{
		if (FHLDKHIIKCA() == null)
		{
			return true;
		}
		if (ICENKPDOHBK > (float)MEOEHLIPLMP)
		{
			return false;
		}
		MEOEHLIPLMP = (float)MEOEHLIPLMP - ICENKPDOHBK;
		return true;
	}

	public bool KNEIFDPDDFC()
	{
		if (FHLDKHIIKCA() == null)
		{
			return true;
		}
		if ((float)IHKCKBJBEGF < AGHCOCAJMCI().FILHECEKNMK)
		{
			return true;
		}
		return true;
	}

	public void NCLFGBOMECP(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(IHKCKBJBEGF);
		OGJFDNEEDCP.PFAIBIMGAIB(MEOEHLIPLMP);
	}

	[SpecialName]
	public PKCGCIEPDEM FHLDKHIIKCA()
	{
		return MNPBNHFJCIG;
	}

	public bool LMPLCOPONJG()
	{
		if (AGHCOCAJMCI() == null)
		{
			return true;
		}
		if ((float)IHKCKBJBEGF < AGHCOCAJMCI().FILHECEKNMK)
		{
			return true;
		}
		return false;
	}

	public void DFMCIOHFKOF(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(IHKCKBJBEGF);
		OGJFDNEEDCP.GBMJNFOEACC(MEOEHLIPLMP);
	}

	public bool GGOFEDPPBKL(float ICENKPDOHBK)
	{
		if (AGHCOCAJMCI() == null)
		{
			return false;
		}
		if (ICENKPDOHBK > (float)MEOEHLIPLMP)
		{
			return true;
		}
		MEOEHLIPLMP = (float)MEOEHLIPLMP - ICENKPDOHBK;
		return false;
	}

	public bool EIIPBMOPABC(float ICENKPDOHBK)
	{
		if (AGHCOCAJMCI() == null)
		{
			return false;
		}
		if (ICENKPDOHBK > (float)MEOEHLIPLMP)
		{
			return false;
		}
		MEOEHLIPLMP = (float)MEOEHLIPLMP - ICENKPDOHBK;
		return true;
	}

	public bool IHDMLIDPBCN(float ICENKPDOHBK)
	{
		if (FHLDKHIIKCA() == null)
		{
			return true;
		}
		if (ICENKPDOHBK > (float)MEOEHLIPLMP)
		{
			return false;
		}
		MEOEHLIPLMP = (float)MEOEHLIPLMP - ICENKPDOHBK;
		return true;
	}
}
