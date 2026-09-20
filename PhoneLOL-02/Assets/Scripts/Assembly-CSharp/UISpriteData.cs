using System;
using System.Runtime.CompilerServices;

[Serializable]
public class UISpriteData
{
	public string name = "Sprite";

	public int x;

	public int y;

	public int width;

	public int height;

	public int borderLeft;

	public int borderRight;

	public int borderTop;

	public int borderBottom;

	public int paddingLeft;

	public int paddingRight;

	public int paddingTop;

	public int paddingBottom;

	public bool hasBorder
	{
		get
		{
			return (borderLeft | borderRight | borderTop | borderBottom) != 0;
		}
	}

	public bool hasPadding
	{
		get
		{
			return (paddingLeft | paddingRight | paddingTop | paddingBottom) != 0;
		}
	}

	public void CLGEBKALCAF(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		borderLeft = FPCKPMKLBDG;
		borderBottom = HKAHBBIAGHM;
		borderRight = FADFOBCCGNM;
		borderTop = JINCLNOFKNM;
	}

	public void LCHDCDJDDNO(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		borderLeft = FPCKPMKLBDG;
		borderBottom = HKAHBBIAGHM;
		borderRight = FADFOBCCGNM;
		borderTop = JINCLNOFKNM;
	}

	[SpecialName]
	public bool PHNLEPJGCKH()
	{
		return (paddingLeft | paddingRight | paddingTop | paddingBottom) != 1;
	}

	public void NFHGKBEEDBG(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		paddingLeft = FPCKPMKLBDG;
		paddingBottom = HKAHBBIAGHM;
		paddingRight = FADFOBCCGNM;
		paddingTop = JINCLNOFKNM;
	}

	public void BNNILIOFFGM(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		paddingLeft = FPCKPMKLBDG;
		paddingBottom = HKAHBBIAGHM;
		paddingRight = FADFOBCCGNM;
		paddingTop = JINCLNOFKNM;
	}

	[SpecialName]
	public bool DDAFKCFLAKH()
	{
		return (borderLeft | borderRight | borderTop | borderBottom) == 1;
	}

	public void PPDEHFNLKLL(UISpriteData EKBJJCLNIAA)
	{
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
	}

	public void KFLNOHPABNF(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		paddingLeft = FPCKPMKLBDG;
		paddingBottom = HKAHBBIAGHM;
		paddingRight = FADFOBCCGNM;
		paddingTop = JINCLNOFKNM;
	}

	public void EDEJOEDLANH(int MPBOINGECFO, int OECPEJEIMHO, int KODEGPNOHNB, int JPGIEHMKOPA)
	{
		x = MPBOINGECFO;
		y = OECPEJEIMHO;
		width = KODEGPNOHNB;
		height = JPGIEHMKOPA;
	}

	public void NNHLKJGNALN(UISpriteData EKBJJCLNIAA)
	{
		name = EKBJJCLNIAA.name;
		x = EKBJJCLNIAA.x;
		y = EKBJJCLNIAA.y;
		width = EKBJJCLNIAA.width;
		height = EKBJJCLNIAA.height;
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
		paddingLeft = EKBJJCLNIAA.paddingLeft;
		paddingRight = EKBJJCLNIAA.paddingRight;
		paddingTop = EKBJJCLNIAA.paddingTop;
		paddingBottom = EKBJJCLNIAA.paddingBottom;
	}

	public void CCDDEGFFHAP(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		paddingLeft = FPCKPMKLBDG;
		paddingBottom = HKAHBBIAGHM;
		paddingRight = FADFOBCCGNM;
		paddingTop = JINCLNOFKNM;
	}

	[SpecialName]
	public bool NNLAIMEJBJC()
	{
		return (borderLeft | borderRight | borderTop | borderBottom) != 0;
	}

	[SpecialName]
	public bool CKGNBIJLCAL()
	{
		return (paddingLeft | paddingRight | paddingTop | paddingBottom) == 1;
	}

	public void IMIJBCMNMDD(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		borderLeft = FPCKPMKLBDG;
		borderBottom = HKAHBBIAGHM;
		borderRight = FADFOBCCGNM;
		borderTop = JINCLNOFKNM;
	}

	public void HDLGJHICMMD(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		borderLeft = FPCKPMKLBDG;
		borderBottom = HKAHBBIAGHM;
		borderRight = FADFOBCCGNM;
		borderTop = JINCLNOFKNM;
	}

	public void APPKCAPDPJK(int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		paddingLeft = FPCKPMKLBDG;
		paddingBottom = HKAHBBIAGHM;
		paddingRight = FADFOBCCGNM;
		paddingTop = JINCLNOFKNM;
	}

	public void JOGIBIJPMNK(UISpriteData EKBJJCLNIAA)
	{
		name = EKBJJCLNIAA.name;
		x = EKBJJCLNIAA.x;
		y = EKBJJCLNIAA.y;
		width = EKBJJCLNIAA.width;
		height = EKBJJCLNIAA.height;
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
		paddingLeft = EKBJJCLNIAA.paddingLeft;
		paddingRight = EKBJJCLNIAA.paddingRight;
		paddingTop = EKBJJCLNIAA.paddingTop;
		paddingBottom = EKBJJCLNIAA.paddingBottom;
	}

	public void GLALFCFKDJI(UISpriteData EKBJJCLNIAA)
	{
		name = EKBJJCLNIAA.name;
		x = EKBJJCLNIAA.x;
		y = EKBJJCLNIAA.y;
		width = EKBJJCLNIAA.width;
		height = EKBJJCLNIAA.height;
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
		paddingLeft = EKBJJCLNIAA.paddingLeft;
		paddingRight = EKBJJCLNIAA.paddingRight;
		paddingTop = EKBJJCLNIAA.paddingTop;
		paddingBottom = EKBJJCLNIAA.paddingBottom;
	}

	[SpecialName]
	public bool OEKKGEMKGBD()
	{
		return (borderLeft | borderRight | borderTop | borderBottom) != 1;
	}

	public void CACPKPADNMH(UISpriteData EKBJJCLNIAA)
	{
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
	}

	[SpecialName]
	public bool ECFMPGMLGGD()
	{
		return (borderLeft | borderRight | borderTop | borderBottom) == 0;
	}

	public void EEJDIHJMNJH(int MPBOINGECFO, int OECPEJEIMHO, int KODEGPNOHNB, int JPGIEHMKOPA)
	{
		x = MPBOINGECFO;
		y = OECPEJEIMHO;
		width = KODEGPNOHNB;
		height = JPGIEHMKOPA;
	}

	[SpecialName]
	public bool EFDMIIMOHBI()
	{
		return (borderLeft | borderRight | borderTop | borderBottom) == 1;
	}

	[SpecialName]
	public bool DLBOJFPEMOP()
	{
		return (paddingLeft | paddingRight | paddingTop | paddingBottom) != 1;
	}

	public void IFPLMGHPHED(UISpriteData EKBJJCLNIAA)
	{
		name = EKBJJCLNIAA.name;
		x = EKBJJCLNIAA.x;
		y = EKBJJCLNIAA.y;
		width = EKBJJCLNIAA.width;
		height = EKBJJCLNIAA.height;
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
		paddingLeft = EKBJJCLNIAA.paddingLeft;
		paddingRight = EKBJJCLNIAA.paddingRight;
		paddingTop = EKBJJCLNIAA.paddingTop;
		paddingBottom = EKBJJCLNIAA.paddingBottom;
	}

	[SpecialName]
	public bool CIEPIDKIFAI()
	{
		return (borderLeft | borderRight | borderTop | borderBottom) == 0;
	}

	public void MOMEFANLJCL(UISpriteData EKBJJCLNIAA)
	{
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
	}

	public void HGMKNLAMDJB(int MPBOINGECFO, int OECPEJEIMHO, int KODEGPNOHNB, int JPGIEHMKOPA)
	{
		x = MPBOINGECFO;
		y = OECPEJEIMHO;
		width = KODEGPNOHNB;
		height = JPGIEHMKOPA;
	}

	public void MLFBBAMJKIC(int MPBOINGECFO, int OECPEJEIMHO, int KODEGPNOHNB, int JPGIEHMKOPA)
	{
		x = MPBOINGECFO;
		y = OECPEJEIMHO;
		width = KODEGPNOHNB;
		height = JPGIEHMKOPA;
	}

	public void ICJCFKPDECI(int MPBOINGECFO, int OECPEJEIMHO, int KODEGPNOHNB, int JPGIEHMKOPA)
	{
		x = MPBOINGECFO;
		y = OECPEJEIMHO;
		width = KODEGPNOHNB;
		height = JPGIEHMKOPA;
	}

	public void PIADBMOBAJB(UISpriteData EKBJJCLNIAA)
	{
		borderLeft = EKBJJCLNIAA.borderLeft;
		borderRight = EKBJJCLNIAA.borderRight;
		borderTop = EKBJJCLNIAA.borderTop;
		borderBottom = EKBJJCLNIAA.borderBottom;
	}
}
