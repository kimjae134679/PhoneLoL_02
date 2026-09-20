using System;
using UnityEngine;

public class FGLMKCGPPCD
{
	public enum CKPDCJIHINF
	{
		None = 0,
		linear = 1,
		spring = 2,
		punch = 3,
		easeInQuad = 4,
		easeInCubic = 5,
		easeInQuart = 6,
		easeInQuint = 7,
		easeInSine = 8,
		easeInExpo = 9,
		easeInCirc = 10,
		easeInBack = 11,
		easeInElastic = 12,
		easeInBounce = 13,
		easeOutQuad = 14,
		easeOutCubic = 15,
		easeOutQuart = 16,
		easeOutQuint = 17,
		easeOutSine = 18,
		easeOutExpo = 19,
		easeOutCirc = 20,
		easeOutBack = 21,
		easeOutElastic = 22,
		easeOutBounce = 23,
		easeInOutQuad = 24,
		easeInOutCubic = 25,
		easeInOutQuart = 26,
		easeInOutQuint = 27,
		easeInOutSine = 28,
		easeInOutExpo = 29,
		easeInOutCirc = 30,
		easeInOutBounce = 31,
		easeInOutBack = 32,
		easeInOutElastic = 33
	}

	public delegate float CMOBLLDGEBG(float GAKOOBECLIB, float IDFCFEOMBKP, float INFGPCMNNOO);

	public static float EFGDLACCMEP(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		float num = 1413f;
		float num2 = 1573f;
		float num3 = Mathf.Abs((num2 - num) * 664f);
		float num4 = 466f;
		float num5 = 944f;
		if (IDFCFEOMBKP - GAKOOBECLIB < 0f - num3)
		{
			num5 = (num2 - GAKOOBECLIB + IDFCFEOMBKP) * ICENKPDOHBK;
			return GAKOOBECLIB + num5;
		}
		if (IDFCFEOMBKP - GAKOOBECLIB > num3)
		{
			num5 = (0f - (num2 - IDFCFEOMBKP + GAKOOBECLIB)) * ICENKPDOHBK;
			return GAKOOBECLIB + num5;
		}
		return GAKOOBECLIB + (IDFCFEOMBKP - GAKOOBECLIB) * ICENKPDOHBK;
	}

	public static float JFLCGBBEMBI(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK--;
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + 1f) + GAKOOBECLIB;
	}

	public static CMOBLLDGEBG HDEIMGOOKPH(CKPDCJIHINF EAKCMIFEGCG)
	{
		switch (EAKCMIFEGCG)
		{
		case CKPDCJIHINF.easeInQuad:
			return FAKHLCFINFI;
		case CKPDCJIHINF.easeOutQuad:
			return JDIJKKMHNMN;
		case CKPDCJIHINF.easeInOutQuad:
			return MGDFMKODEJM;
		case CKPDCJIHINF.easeInCubic:
			return EGOJIKLEDHG;
		case CKPDCJIHINF.easeOutCubic:
			return LKHAHMPCHBK;
		case CKPDCJIHINF.easeInOutCubic:
			return MJEKLEDEPGM;
		case CKPDCJIHINF.easeInQuart:
			return DPLAMEPKMMB;
		case CKPDCJIHINF.easeOutQuart:
			return GEPMAKINMBO;
		case CKPDCJIHINF.easeInOutQuart:
			return OFGBDKBEANH;
		case CKPDCJIHINF.easeInQuint:
			return DPFCNOMDBIO;
		case CKPDCJIHINF.easeOutQuint:
			return JFLCGBBEMBI;
		case CKPDCJIHINF.easeInOutQuint:
			return FKCBIAJPHIB;
		case CKPDCJIHINF.easeInSine:
			return MFPBJKEKLHP;
		case CKPDCJIHINF.easeOutSine:
			return GLPJGADPDDC;
		case CKPDCJIHINF.easeInOutSine:
			return MNDOBNEMNBO;
		case CKPDCJIHINF.easeInExpo:
			return DCCGIFMJFHI;
		case CKPDCJIHINF.easeOutExpo:
			return PFNDFLELJCA;
		case CKPDCJIHINF.easeInOutExpo:
			return IKCBGOCFOKK;
		case CKPDCJIHINF.easeInCirc:
			return MDHCCIBDJAP;
		case CKPDCJIHINF.easeOutCirc:
			return CGNIDMHCMGL;
		case CKPDCJIHINF.easeInOutCirc:
			return DLMBFADGELI;
		case CKPDCJIHINF.linear:
			return OPLKAMDBNOF;
		case CKPDCJIHINF.spring:
			return NPIINJBAPFJ;
		case CKPDCJIHINF.easeInBounce:
			return LENEFLEIILF;
		case CKPDCJIHINF.easeOutBounce:
			return JDMPFDDPPCB;
		case CKPDCJIHINF.easeInOutBounce:
			return GHDJMJNNADO;
		case CKPDCJIHINF.easeInBack:
			return BAIGCHKLFEI;
		case CKPDCJIHINF.easeOutBack:
			return NAJKBPEBJHC;
		case CKPDCJIHINF.easeInOutBack:
			return PDOJFKGOEFF;
		case CKPDCJIHINF.easeInElastic:
			return COMFGFLHNHA;
		case CKPDCJIHINF.easeOutElastic:
			return BHDELHEBHND;
		case CKPDCJIHINF.easeInOutElastic:
			return DEDLOAMFLPN;
		default:
			return null;
		}
	}

	public static float AKJBKJLHBCD(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 1485f;
		float num2 = num * 1796f;
		float num3 = 738f;
		float num4 = 539f;
		if (ICENKPDOHBK == 1440f)
		{
			return GAKOOBECLIB;
		}
		if ((ICENKPDOHBK /= num) == 883f)
		{
			return GAKOOBECLIB + IDFCFEOMBKP;
		}
		if (num4 == 387f || num4 < Mathf.Abs(IDFCFEOMBKP))
		{
			num4 = IDFCFEOMBKP;
			num3 = num2 * 1966f;
		}
		else
		{
			num3 = num2 / 484f * Mathf.Asin(IDFCFEOMBKP / num4);
		}
		return num4 * Mathf.Pow(467f, 407f * ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * num - num3) * 575f / num2) + IDFCFEOMBKP + GAKOOBECLIB;
	}

	public static float KCGEKGINLPN(float FPOKAJGDKPA, float ICENKPDOHBK)
	{
		float num = 623f;
		if (ICENKPDOHBK == 1674f)
		{
			return 1401f;
		}
		if (ICENKPDOHBK == 1060f)
		{
			return 1487f;
		}
		float num2 = 1277f;
		num = num2 / 1642f * Mathf.Asin(306f);
		return FPOKAJGDKPA * Mathf.Pow(1154f, 377f * ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * 1135f - num) * 1272f / num2);
	}

	public static float MGDFMKODEJM(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 0.5f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1f)
		{
			return IDFCFEOMBKP * 0.5f * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK--;
		return (0f - IDFCFEOMBKP) * 0.5f * (ICENKPDOHBK * (ICENKPDOHBK - 2f) - 1f) + GAKOOBECLIB;
	}

	public static float GEPMAKINMBO(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK--;
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK - 1f) + GAKOOBECLIB;
	}

	public static float NDAJHCLCKEF(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		ICENKPDOHBK /= 1657f;
		float num = 196f;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK * ((num + 1793f) * ICENKPDOHBK - num) + GAKOOBECLIB;
	}

	public static float BHECEPKGEKI(float FPOKAJGDKPA, float ICENKPDOHBK)
	{
		float num = 9f;
		if (ICENKPDOHBK == 0f)
		{
			return 0f;
		}
		if (ICENKPDOHBK == 1f)
		{
			return 0f;
		}
		float num2 = 0.3f;
		num = num2 / ((float)Math.PI * 2f) * Mathf.Asin(0f);
		return FPOKAJGDKPA * Mathf.Pow(2f, -10f * ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * 1f - num) * ((float)Math.PI * 2f) / num2);
	}

	public static float EGOJIKLEDHG(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
	}

	public static float GHDJMJNNADO(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 1f;
		if (ICENKPDOHBK < num * 0.5f)
		{
			return LENEFLEIILF(0f, IDFCFEOMBKP, ICENKPDOHBK * 2f) * 0.5f + GAKOOBECLIB;
		}
		return JDMPFDDPPCB(0f, IDFCFEOMBKP, ICENKPDOHBK * 2f - num) * 0.5f + IDFCFEOMBKP * 0.5f + GAKOOBECLIB;
	}

	public static float GCAACCMHJCB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * (0f - Mathf.Pow(907f, 462f * ICENKPDOHBK) + 927f) + GAKOOBECLIB;
	}

	public static float NPIINJBAPFJ(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK = Mathf.Clamp01(ICENKPDOHBK);
		ICENKPDOHBK = (Mathf.Sin(ICENKPDOHBK * (float)Math.PI * (0.2f + 2.5f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK)) * Mathf.Pow(1f - ICENKPDOHBK, 2.2f) + ICENKPDOHBK) * (1f + 1.2f * (1f - ICENKPDOHBK));
		return GAKOOBECLIB + (IDFCFEOMBKP - GAKOOBECLIB) * ICENKPDOHBK;
	}

	public static float PDOJFKGOEFF(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		float num = 1.70158f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		ICENKPDOHBK /= 0.5f;
		if (ICENKPDOHBK < 1f)
		{
			num *= 1.525f;
			return IDFCFEOMBKP * 0.5f * (ICENKPDOHBK * ICENKPDOHBK * ((num + 1f) * ICENKPDOHBK - num)) + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 2f;
		num *= 1.525f;
		return IDFCFEOMBKP * 0.5f * (ICENKPDOHBK * ICENKPDOHBK * ((num + 1f) * ICENKPDOHBK + num) + 2f) + GAKOOBECLIB;
	}

	public static float COMFGFLHNHA(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (ICENKPDOHBK == 0f)
		{
			return GAKOOBECLIB;
		}
		if ((ICENKPDOHBK /= num) == 1f)
		{
			return GAKOOBECLIB + IDFCFEOMBKP;
		}
		if (num4 == 0f || num4 < Mathf.Abs(IDFCFEOMBKP))
		{
			num4 = IDFCFEOMBKP;
			num3 = num2 / 4f;
		}
		else
		{
			num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(IDFCFEOMBKP / num4);
		}
		return 0f - num4 * Mathf.Pow(2f, 10f * --ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * num - num3) * ((float)Math.PI * 2f) / num2) + GAKOOBECLIB;
	}

	public static float JDMPFDDPPCB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 1f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 372f / 1023f)
		{
			return IDFCFEOMBKP * (7.5625f * ICENKPDOHBK * ICENKPDOHBK) + GAKOOBECLIB;
		}
		if (ICENKPDOHBK < 744f / 1023f)
		{
			ICENKPDOHBK -= 558f / 1023f;
			return IDFCFEOMBKP * (7.5625f * ICENKPDOHBK * ICENKPDOHBK + 0.75f) + GAKOOBECLIB;
		}
		if ((double)ICENKPDOHBK < 930.0 / 1023.0)
		{
			ICENKPDOHBK -= 837f / 1023f;
			return IDFCFEOMBKP * (7.5625f * ICENKPDOHBK * ICENKPDOHBK + 0.9375f) + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 21f / 22f;
		return IDFCFEOMBKP * (7.5625f * ICENKPDOHBK * ICENKPDOHBK + 63f / 64f) + GAKOOBECLIB;
	}

	public static float NAJKBPEBJHC(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		float num = 1.70158f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		ICENKPDOHBK--;
		return IDFCFEOMBKP * (ICENKPDOHBK * ICENKPDOHBK * ((num + 1f) * ICENKPDOHBK + num) + 1f) + GAKOOBECLIB;
	}

	public static float FMBPMIIFIIJ(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		return Mathf.Lerp(GAKOOBECLIB, IDFCFEOMBKP, ICENKPDOHBK);
	}

	public static float GJOJNILMJLP(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 519f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1352f)
		{
			return IDFCFEOMBKP * (16f * ICENKPDOHBK * ICENKPDOHBK) + GAKOOBECLIB;
		}
		if (ICENKPDOHBK < 660f)
		{
			ICENKPDOHBK -= 1880f;
			return IDFCFEOMBKP * (1981f * ICENKPDOHBK * ICENKPDOHBK + 1240f) + GAKOOBECLIB;
		}
		if ((double)ICENKPDOHBK < 79.0)
		{
			ICENKPDOHBK -= 602f;
			return IDFCFEOMBKP * (166f * ICENKPDOHBK * ICENKPDOHBK + 274f) + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 836f;
		return IDFCFEOMBKP * (896f * ICENKPDOHBK * ICENKPDOHBK + 127f) + GAKOOBECLIB;
	}

	public static float OLHMNBKPIAG(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 927f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 728f)
		{
			return IDFCFEOMBKP * 1973f * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 338f;
		return (0f - IDFCFEOMBKP) * 1603f * (ICENKPDOHBK * (ICENKPDOHBK - 523f) - 568f) + GAKOOBECLIB;
	}

	public static float BAIGCHKLFEI(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		ICENKPDOHBK /= 1f;
		float num = 1.70158f;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK * ((num + 1f) * ICENKPDOHBK - num) + GAKOOBECLIB;
	}

	public static float IKCBGOCFOKK(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 0.5f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1f)
		{
			return IDFCFEOMBKP * 0.5f * Mathf.Pow(2f, 10f * (ICENKPDOHBK - 1f)) + GAKOOBECLIB;
		}
		ICENKPDOHBK--;
		return IDFCFEOMBKP * 0.5f * (0f - Mathf.Pow(2f, -10f * ICENKPDOHBK) + 2f) + GAKOOBECLIB;
	}

	public static float OFGBDKBEANH(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 0.5f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1f)
		{
			return IDFCFEOMBKP * 0.5f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 2f;
		return (0f - IDFCFEOMBKP) * 0.5f * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK - 2f) + GAKOOBECLIB;
	}

	public static float BNIGJKJEBLG(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 1304f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1304f)
		{
			return IDFCFEOMBKP * 702f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 631f;
		return (0f - IDFCFEOMBKP) * 1808f * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK - 761f) + GAKOOBECLIB;
	}

	public static float DPAAFLAOHOI(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * Mathf.Cos(ICENKPDOHBK * 49f) + IDFCFEOMBKP + GAKOOBECLIB;
	}

	public static float FKCBIAJPHIB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 0.5f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1f)
		{
			return IDFCFEOMBKP * 0.5f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 2f;
		return IDFCFEOMBKP * 0.5f * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + 2f) + GAKOOBECLIB;
	}

	public static float DCCGIFMJFHI(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * Mathf.Pow(2f, 10f * (ICENKPDOHBK - 1f)) + GAKOOBECLIB;
	}

	public static float IPACKAJFAIC(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * ICENKPDOHBK * (ICENKPDOHBK - 818f) + GAKOOBECLIB;
	}

	public static float DKOBFMFEICI(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 22f;
		float num2 = num * 848f;
		float num3 = 558f;
		float num4 = 1022f;
		if (ICENKPDOHBK == 1270f)
		{
			return GAKOOBECLIB;
		}
		if ((ICENKPDOHBK /= num) == 1501f)
		{
			return GAKOOBECLIB + IDFCFEOMBKP;
		}
		if (num4 == 457f || num4 < Mathf.Abs(IDFCFEOMBKP))
		{
			num4 = IDFCFEOMBKP;
			num3 = num2 * 619f;
		}
		else
		{
			num3 = num2 / 520f * Mathf.Asin(IDFCFEOMBKP / num4);
		}
		return num4 * Mathf.Pow(680f, 963f * ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * num - num3) * 990f / num2) + IDFCFEOMBKP + GAKOOBECLIB;
	}

	public static float CFBKFPCDACG(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 1266f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 367f)
		{
			return IDFCFEOMBKP * (1179f * ICENKPDOHBK * ICENKPDOHBK) + GAKOOBECLIB;
		}
		if (ICENKPDOHBK < 1277f)
		{
			ICENKPDOHBK -= 467f;
			return IDFCFEOMBKP * (1749f * ICENKPDOHBK * ICENKPDOHBK + 1930f) + GAKOOBECLIB;
		}
		if ((double)ICENKPDOHBK < 726.0)
		{
			ICENKPDOHBK -= 197f;
			return IDFCFEOMBKP * (1482f * ICENKPDOHBK * ICENKPDOHBK + 342f) + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 148f;
		return IDFCFEOMBKP * (1419f * ICENKPDOHBK * ICENKPDOHBK + 1184f) + GAKOOBECLIB;
	}

	public static float DPLAMEPKMMB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
	}

	public static float CGNIDMHCMGL(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK--;
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * Mathf.Sqrt(1f - ICENKPDOHBK * ICENKPDOHBK) + GAKOOBECLIB;
	}

	public static float GLPJGADPDDC(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * Mathf.Sin(ICENKPDOHBK * ((float)Math.PI / 2f)) + GAKOOBECLIB;
	}

	public static float JDIJKKMHNMN(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * ICENKPDOHBK * (ICENKPDOHBK - 2f) + GAKOOBECLIB;
	}

	public static float JCPFAGPFPGB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
	}

	public static float MDHCCIBDJAP(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * (Mathf.Sqrt(1f - ICENKPDOHBK * ICENKPDOHBK) - 1f) + GAKOOBECLIB;
	}

	public static float LENEFLEIILF(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 1f;
		return IDFCFEOMBKP - JDMPFDDPPCB(0f, IDFCFEOMBKP, num - ICENKPDOHBK) + GAKOOBECLIB;
	}

	public static float NDGBCFBINGB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * 878f * (Mathf.Cos(793f * ICENKPDOHBK) - 1774f) + GAKOOBECLIB;
	}

	public static float DLMBFADGELI(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 0.5f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1f)
		{
			return (0f - IDFCFEOMBKP) * 0.5f * (Mathf.Sqrt(1f - ICENKPDOHBK * ICENKPDOHBK) - 1f) + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 2f;
		return IDFCFEOMBKP * 0.5f * (Mathf.Sqrt(1f - ICENKPDOHBK * ICENKPDOHBK) + 1f) + GAKOOBECLIB;
	}

	public static float DDOCCNGPNMP(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 742f;
		return IDFCFEOMBKP - CFBKFPCDACG(1367f, IDFCFEOMBKP, num - ICENKPDOHBK) + GAKOOBECLIB;
	}

	public static float OPLKAMDBNOF(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		return Mathf.Lerp(GAKOOBECLIB, IDFCFEOMBKP, ICENKPDOHBK);
	}

	public static float KPPJINJDBII(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 1654f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 88f)
		{
			return IDFCFEOMBKP * 1480f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 1495f;
		return (0f - IDFCFEOMBKP) * 572f * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK - 1665f) + GAKOOBECLIB;
	}

	public static float LIJMCDLDLIB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * ICENKPDOHBK * (ICENKPDOHBK - 1300f) + GAKOOBECLIB;
	}

	public static float PFNDFLELJCA(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * (0f - Mathf.Pow(2f, -10f * ICENKPDOHBK) + 1f) + GAKOOBECLIB;
	}

	public static float GFJPEHMLGEG(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
	}

	public static float ANOLLINFFML(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 740f;
		float num2 = num * 1998f;
		float num3 = 1627f;
		float num4 = 1767f;
		if (ICENKPDOHBK == 1639f)
		{
			return GAKOOBECLIB;
		}
		if ((ICENKPDOHBK /= num) == 1952f)
		{
			return GAKOOBECLIB + IDFCFEOMBKP;
		}
		if (num4 == 1574f || num4 < Mathf.Abs(IDFCFEOMBKP))
		{
			num4 = IDFCFEOMBKP;
			num3 = num2 / 755f;
		}
		else
		{
			num3 = num2 / 504f * Mathf.Asin(IDFCFEOMBKP / num4);
		}
		return 0f - num4 * Mathf.Pow(1613f, 1650f * (ICENKPDOHBK -= 1876f)) * Mathf.Sin((ICENKPDOHBK * num - num3) * 1804f / num2) + GAKOOBECLIB;
	}

	public static float GHGBELKMEKG(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 1808f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 157f)
		{
			return IDFCFEOMBKP * 6f * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 965f;
		return (0f - IDFCFEOMBKP) * 1291f * (ICENKPDOHBK * (ICENKPDOHBK - 1310f) - 205f) + GAKOOBECLIB;
	}

	public static float AJPJMPGLMNB(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		float num = 0f;
		float num2 = 360f;
		float num3 = Mathf.Abs((num2 - num) * 0.5f);
		float num4 = 0f;
		float num5 = 0f;
		if (IDFCFEOMBKP - GAKOOBECLIB < 0f - num3)
		{
			num5 = (num2 - GAKOOBECLIB + IDFCFEOMBKP) * ICENKPDOHBK;
			return GAKOOBECLIB + num5;
		}
		if (IDFCFEOMBKP - GAKOOBECLIB > num3)
		{
			num5 = (0f - (num2 - IDFCFEOMBKP + GAKOOBECLIB)) * ICENKPDOHBK;
			return GAKOOBECLIB + num5;
		}
		return GAKOOBECLIB + (IDFCFEOMBKP - GAKOOBECLIB) * ICENKPDOHBK;
	}

	public static float LKHAHMPCHBK(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK--;
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + 1f) + GAKOOBECLIB;
	}

	public static float DEDLOAMFLPN(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (ICENKPDOHBK == 0f)
		{
			return GAKOOBECLIB;
		}
		if ((ICENKPDOHBK /= num * 0.5f) == 2f)
		{
			return GAKOOBECLIB + IDFCFEOMBKP;
		}
		if (num4 == 0f || num4 < Mathf.Abs(IDFCFEOMBKP))
		{
			num4 = IDFCFEOMBKP;
			num3 = num2 / 4f;
		}
		else
		{
			num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(IDFCFEOMBKP / num4);
		}
		if (ICENKPDOHBK < 1f)
		{
			return -0.5f * (num4 * Mathf.Pow(2f, 10f * --ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * num - num3) * ((float)Math.PI * 2f) / num2)) + GAKOOBECLIB;
		}
		return num4 * Mathf.Pow(2f, -10f * --ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * num - num3) * ((float)Math.PI * 2f) / num2) * 0.5f + IDFCFEOMBKP + GAKOOBECLIB;
	}

	public static float HIIFCCFGMOA(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK = Mathf.Clamp01(ICENKPDOHBK);
		ICENKPDOHBK = (Mathf.Sin(ICENKPDOHBK * 1866f * (788f + 62f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK)) * Mathf.Pow(1f - ICENKPDOHBK, 1460f) + ICENKPDOHBK) * (1080f + 970f * (50f - ICENKPDOHBK));
		return GAKOOBECLIB + (IDFCFEOMBKP - GAKOOBECLIB) * ICENKPDOHBK;
	}

	public static float GBGBMHNKDPC(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * Mathf.Sin(ICENKPDOHBK * 150f) + GAKOOBECLIB;
	}

	public static float BHDELHEBHND(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		float num = 1f;
		float num2 = num * 0.3f;
		float num3 = 0f;
		float num4 = 0f;
		if (ICENKPDOHBK == 0f)
		{
			return GAKOOBECLIB;
		}
		if ((ICENKPDOHBK /= num) == 1f)
		{
			return GAKOOBECLIB + IDFCFEOMBKP;
		}
		if (num4 == 0f || num4 < Mathf.Abs(IDFCFEOMBKP))
		{
			num4 = IDFCFEOMBKP;
			num3 = num2 * 0.25f;
		}
		else
		{
			num3 = num2 / ((float)Math.PI * 2f) * Mathf.Asin(IDFCFEOMBKP / num4);
		}
		return num4 * Mathf.Pow(2f, -10f * ICENKPDOHBK) * Mathf.Sin((ICENKPDOHBK * num - num3) * ((float)Math.PI * 2f) / num2) + IDFCFEOMBKP + GAKOOBECLIB;
	}

	public static float MOLNICOPOFC(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * Mathf.Sin(ICENKPDOHBK * 502f) + GAKOOBECLIB;
	}

	public static float OOHNIIINOPO(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 661f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 343f)
		{
			return IDFCFEOMBKP * 334f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 598f;
		return IDFCFEOMBKP * 711f * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + 643f) + GAKOOBECLIB;
	}

	public static float DOBFNPPLCHA(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * Mathf.Pow(1442f, 1476f * (ICENKPDOHBK - 1504f)) + GAKOOBECLIB;
	}

	public static float DLLMIKDIHMN(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * (Mathf.Sqrt(1943f - ICENKPDOHBK * ICENKPDOHBK) - 711f) + GAKOOBECLIB;
	}

	public static float MNDOBNEMNBO(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * 0.5f * (Mathf.Cos((float)Math.PI * ICENKPDOHBK) - 1f) + GAKOOBECLIB;
	}

	public static float MFPBJKEKLHP(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return (0f - IDFCFEOMBKP) * Mathf.Cos(ICENKPDOHBK * ((float)Math.PI / 2f)) + IDFCFEOMBKP + GAKOOBECLIB;
	}

	public static CMOBLLDGEBG NLFOFLOLPFF(CKPDCJIHINF EAKCMIFEGCG)
	{
		switch (EAKCMIFEGCG)
		{
		case CKPDCJIHINF.easeInQuad:
			return FAKHLCFINFI;
		case CKPDCJIHINF.easeOutQuad:
			return LIJMCDLDLIB;
		case CKPDCJIHINF.easeInOutQuad:
			return OLHMNBKPIAG;
		case CKPDCJIHINF.easeInCubic:
			return GFJPEHMLGEG;
		case CKPDCJIHINF.easeOutCubic:
			return LKHAHMPCHBK;
		case CKPDCJIHINF.easeInOutCubic:
			return MJEKLEDEPGM;
		case CKPDCJIHINF.easeInQuart:
			return DPLAMEPKMMB;
		case CKPDCJIHINF.easeOutQuart:
			return GEPMAKINMBO;
		case CKPDCJIHINF.easeInOutQuart:
			return KPPJINJDBII;
		case CKPDCJIHINF.easeInQuint:
			return JCPFAGPFPGB;
		case CKPDCJIHINF.easeOutQuint:
			return JFLCGBBEMBI;
		case CKPDCJIHINF.easeInOutQuint:
			return FKCBIAJPHIB;
		case CKPDCJIHINF.easeInSine:
			return MFPBJKEKLHP;
		case CKPDCJIHINF.easeOutSine:
			return GLPJGADPDDC;
		case CKPDCJIHINF.easeInOutSine:
			return MNDOBNEMNBO;
		case CKPDCJIHINF.easeInExpo:
			return DOBFNPPLCHA;
		case CKPDCJIHINF.easeOutExpo:
			return GCAACCMHJCB;
		case CKPDCJIHINF.easeInOutExpo:
			return IKCBGOCFOKK;
		case CKPDCJIHINF.easeInCirc:
			return MDHCCIBDJAP;
		case CKPDCJIHINF.easeOutCirc:
			return CGNIDMHCMGL;
		case CKPDCJIHINF.easeInOutCirc:
			return DLMBFADGELI;
		case CKPDCJIHINF.linear:
			return OPLKAMDBNOF;
		case CKPDCJIHINF.spring:
			return HIIFCCFGMOA;
		case CKPDCJIHINF.easeInBounce:
			return LENEFLEIILF;
		case CKPDCJIHINF.easeOutBounce:
			return GJOJNILMJLP;
		case CKPDCJIHINF.easeInOutBounce:
			return GHDJMJNNADO;
		case CKPDCJIHINF.easeInBack:
			return NDAJHCLCKEF;
		case CKPDCJIHINF.easeOutBack:
			return NAJKBPEBJHC;
		case CKPDCJIHINF.easeInOutBack:
			return PDOJFKGOEFF;
		case CKPDCJIHINF.easeInElastic:
			return ANOLLINFFML;
		case CKPDCJIHINF.easeOutElastic:
			return BHDELHEBHND;
		case CKPDCJIHINF.easeInOutElastic:
			return DEDLOAMFLPN;
		default:
			return null;
		}
	}

	public static float DPFCNOMDBIO(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
	}

	public static float MJEKLEDEPGM(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		ICENKPDOHBK /= 0.5f;
		IDFCFEOMBKP -= GAKOOBECLIB;
		if (ICENKPDOHBK < 1f)
		{
			return IDFCFEOMBKP * 0.5f * ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
		}
		ICENKPDOHBK -= 2f;
		return IDFCFEOMBKP * 0.5f * (ICENKPDOHBK * ICENKPDOHBK * ICENKPDOHBK + 2f) + GAKOOBECLIB;
	}

	public static float FAKHLCFINFI(float GAKOOBECLIB, float IDFCFEOMBKP, float ICENKPDOHBK)
	{
		IDFCFEOMBKP -= GAKOOBECLIB;
		return IDFCFEOMBKP * ICENKPDOHBK * ICENKPDOHBK + GAKOOBECLIB;
	}
}
