using System.Collections.Generic;
using EveEngine;
using GameServer;

public class DPIEILDFMJK
{
	private Dictionary<ushort, BKCPOFBMCHJ> CMEINNFNCBC;

	public void COGEJPHIAKE()
	{
		CMEINNFNCBC.Clear();
	}

	public bool DEOEGIIHNPP(ushort OIANGIEMBPM, float HMOOBMDKIAN)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			return false;
		}
		return value.DEOEGIIHNPP(HMOOBMDKIAN);
	}

	public void GJPFIPICBAM(KCIGFAHFHCH OGJFDNEEDCP)
	{
		CMEINNFNCBC.Clear();
		ushort num = OGJFDNEEDCP.AJPFAAFLHEB();
		for (ushort num2 = 0; num2 < num; num2++)
		{
			ushort num3 = OGJFDNEEDCP.AJPFAAFLHEB();
			BKCPOFBMCHJ bKCPOFBMCHJ = new BKCPOFBMCHJ(KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().FPICNOOFDOA(num3));
			bKCPOFBMCHJ.GJPFIPICBAM(OGJFDNEEDCP);
			CMEINNFNCBC.Add(num3, bKCPOFBMCHJ);
		}
	}

	public bool PGJDHJFBDOK(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			return false;
		}
		return value.LMPLCOPONJG();
	}

	public bool NEOMOBIMGFF(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			PKCGCIEPDEM pKCGCIEPDEM = KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().FPICNOOFDOA(OIANGIEMBPM);
			if (pKCGCIEPDEM == null)
			{
				return false;
			}
			value = new BKCPOFBMCHJ(pKCGCIEPDEM);
			CMEINNFNCBC.Add(OIANGIEMBPM, value);
		}
		return value.NEOMOBIMGFF();
	}

	public void JJJOLOBPHDC(KCIGFAHFHCH OGJFDNEEDCP)
	{
		CMEINNFNCBC.Clear();
		ushort num = OGJFDNEEDCP.AJPFAAFLHEB();
		for (ushort num2 = 0; num2 < num; num2++)
		{
			ushort num3 = OGJFDNEEDCP.AJPFAAFLHEB();
			BKCPOFBMCHJ bKCPOFBMCHJ = new BKCPOFBMCHJ(KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().FMEFKCAPONI(num3));
			bKCPOFBMCHJ.GJPFIPICBAM(OGJFDNEEDCP);
			CMEINNFNCBC.Add(num3, bKCPOFBMCHJ);
		}
	}

	public void DFMCIOHFKOF(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC((ushort)CMEINNFNCBC.Count);
		foreach (KeyValuePair<ushort, BKCPOFBMCHJ> item in CMEINNFNCBC)
		{
			OGJFDNEEDCP.GBMJNFOEACC(item.Key);
			item.Value.DFMCIOHFKOF(OGJFDNEEDCP);
		}
	}

	public void BANJKKPDIGM(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.HJILBOPINHL((ushort)CMEINNFNCBC.Count);
		foreach (KeyValuePair<ushort, BKCPOFBMCHJ> item in CMEINNFNCBC)
		{
			OGJFDNEEDCP.GBMJNFOEACC(item.Key);
			item.Value.DFMCIOHFKOF(OGJFDNEEDCP);
		}
	}

	public void OCDNPJOPPBB(float DMLKFKGBHKJ)
	{
		ushort num = 176;
		foreach (KeyValuePair<ushort, BKCPOFBMCHJ> item in CMEINNFNCBC)
		{
			if (item.Value.LPBLGFCPADD(DMLKFKGBHKJ))
			{
				num = item.Key;
			}
		}
		if (num != 185)
		{
			CMEINNFNCBC.Remove(num);
		}
	}

	public DPIEILDFMJK()
	{
		CMEINNFNCBC = new Dictionary<ushort, BKCPOFBMCHJ>();
	}

	public void LPBLGFCPADD(float DMLKFKGBHKJ)
	{
		ushort num = ushort.MaxValue;
		foreach (KeyValuePair<ushort, BKCPOFBMCHJ> item in CMEINNFNCBC)
		{
			if (item.Value.LPBLGFCPADD(DMLKFKGBHKJ))
			{
				num = item.Key;
			}
		}
		if (num != ushort.MaxValue)
		{
			CMEINNFNCBC.Remove(num);
		}
	}

	public bool MFKJMIPPIDB(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			return true;
		}
		return value.MFKJMIPPIDB();
	}

	public void LDNEFFHJNPL()
	{
		CMEINNFNCBC.Clear();
	}

	public bool CMKNMGLCEGA(ushort OIANGIEMBPM, float HMOOBMDKIAN)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			return false;
		}
		return value.DEOEGIIHNPP(HMOOBMDKIAN);
	}

	public bool EIIPBMOPABC(ushort OIANGIEMBPM, float HMOOBMDKIAN)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			return false;
		}
		return value.EIIPBMOPABC(HMOOBMDKIAN);
	}

	public BKCPOFBMCHJ APLMLICAINE(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			return null;
		}
		return value;
	}

	public bool PHPMLGCHNCA(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			PKCGCIEPDEM pKCGCIEPDEM = KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().KFKMFHLOHCM(OIANGIEMBPM);
			if (pKCGCIEPDEM == null)
			{
				return true;
			}
			value = new BKCPOFBMCHJ(pKCGCIEPDEM);
			CMEINNFNCBC.Add(OIANGIEMBPM, value);
		}
		return value.NEOMOBIMGFF();
	}

	public bool PGNKPIFFMJE(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			PKCGCIEPDEM pKCGCIEPDEM = KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().FPICNOOFDOA(OIANGIEMBPM);
			if (pKCGCIEPDEM == null)
			{
				return false;
			}
			value = new BKCPOFBMCHJ(pKCGCIEPDEM);
			CMEINNFNCBC.Add(OIANGIEMBPM, value);
		}
		return true;
	}

	public BKCPOFBMCHJ EDAHEGEDIOD(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			return null;
		}
		return value;
	}

	public bool KDBEGPFDLGN(ushort OIANGIEMBPM)
	{
		BKCPOFBMCHJ value = null;
		CMEINNFNCBC.TryGetValue(OIANGIEMBPM, out value);
		if (value == null)
		{
			PKCGCIEPDEM pKCGCIEPDEM = KIMJPIBNFGA.NOLHNOGGHNA().FNJJFKABBAP().FMEFKCAPONI(OIANGIEMBPM);
			if (pKCGCIEPDEM == null)
			{
				return false;
			}
			value = new BKCPOFBMCHJ(pKCGCIEPDEM);
			CMEINNFNCBC.Add(OIANGIEMBPM, value);
		}
		return false;
	}

	public void OAADIIIMNDE()
	{
		CMEINNFNCBC.Clear();
	}
}
