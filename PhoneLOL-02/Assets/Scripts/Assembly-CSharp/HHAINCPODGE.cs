using System.Diagnostics;
using UnityEngine;

public static class HHAINCPODGE
{
	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float KCLHKIALKPN(float HGKDALECODA, float CIBKFGPHPGN, float JMHOHNCILGL)
	{
		return HGKDALECODA * (1f - JMHOHNCILGL) + CIBKFGPHPGN * JMHOHNCILGL;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int CAEFGJJNBPA(int JKJGJMOEHDO, int KBBNDLJDCAP)
	{
		return (JKJGJMOEHDO >= 0) ? ((JKJGJMOEHDO >= KBBNDLJDCAP) ? (KBBNDLJDCAP - 1) : JKJGJMOEHDO) : 0;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int FMIHOIEFOON(int JKJGJMOEHDO, int KBBNDLJDCAP)
	{
		if (KBBNDLJDCAP < 1)
		{
			return 0;
		}
		while (JKJGJMOEHDO < 0)
		{
			JKJGJMOEHDO += KBBNDLJDCAP;
		}
		while (JKJGJMOEHDO >= KBBNDLJDCAP)
		{
			JKJGJMOEHDO -= KBBNDLJDCAP;
		}
		return JKJGJMOEHDO;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static float ABNMAJAPKCG(float IINELJPKNBN)
	{
		while (IINELJPKNBN > 180f)
		{
			IINELJPKNBN -= 360f;
		}
		while (IINELJPKNBN < -180f)
		{
			IINELJPKNBN += 360f;
		}
		return IINELJPKNBN;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static float DPEDEFEJLGL(float JKJGJMOEHDO)
	{
		return JKJGJMOEHDO - (float)Mathf.FloorToInt(JKJGJMOEHDO);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static int DCGHFDGMJGN(char JBIBLBJBBAM)
	{
		switch (JBIBLBJBBAM)
		{
		case '0':
			return 0;
		case '1':
			return 1;
		case '2':
			return 2;
		case '3':
			return 3;
		case '4':
			return 4;
		case '5':
			return 5;
		case '6':
			return 6;
		case '7':
			return 7;
		case '8':
			return 8;
		case '9':
			return 9;
		case 'A':
		case 'a':
			return 10;
		case 'B':
		case 'b':
			return 11;
		case 'C':
		case 'c':
			return 12;
		case 'D':
		case 'd':
			return 13;
		case 'E':
		case 'e':
			return 14;
		case 'F':
		case 'f':
			return 15;
		default:
			return 15;
		}
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static char KLPPILJLNPI(int AOKGMGEAHDH)
	{
		if (AOKGMGEAHDH > 15)
		{
			return 'F';
		}
		if (AOKGMGEAHDH < 10)
		{
			return (char)(48 + AOKGMGEAHDH);
		}
		return (char)(65 + AOKGMGEAHDH - 10);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string EMCAPPABKPJ(int AOKGMGEAHDH)
	{
		AOKGMGEAHDH &= 0xFF;
		return AOKGMGEAHDH.ToString("X2");
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string LCNAAGNGCAG(int AOKGMGEAHDH)
	{
		AOKGMGEAHDH &= 0xFFFFFF;
		return AOKGMGEAHDH.ToString("X6");
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string OIPMDKJABOE(int AOKGMGEAHDH)
	{
		return AOKGMGEAHDH.ToString("X8");
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static int KLHHMOMABPJ(Color CEMGPCOMLOP)
	{
		int num = 0;
		num |= Mathf.RoundToInt(CEMGPCOMLOP.r * 255f) << 24;
		num |= Mathf.RoundToInt(CEMGPCOMLOP.g * 255f) << 16;
		num |= Mathf.RoundToInt(CEMGPCOMLOP.b * 255f) << 8;
		return num | Mathf.RoundToInt(CEMGPCOMLOP.a * 255f);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static Color CIDFDNKJACL(int JKJGJMOEHDO)
	{
		float num = 1f / 255f;
		Color black = Color.black;
		black.r = num * (float)((JKJGJMOEHDO >> 24) & 0xFF);
		black.g = num * (float)((JKJGJMOEHDO >> 16) & 0xFF);
		black.b = num * (float)((JKJGJMOEHDO >> 8) & 0xFF);
		black.a = num * (float)(JKJGJMOEHDO & 0xFF);
		return black;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static string JADEBELIJOJ(int JKJGJMOEHDO, int MHJFOHJPKFK)
	{
		string text = string.Empty;
		int num = MHJFOHJPKFK;
		while (num > 0)
		{
			if (num == 8 || num == 16 || num == 24)
			{
				text += " ";
			}
			text += (((JKJGJMOEHDO & (1 << --num)) == 0) ? '0' : '1');
		}
		return text;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static Color PCNFFAKCGBM(uint JKJGJMOEHDO)
	{
		return CIDFDNKJACL((int)JKJGJMOEHDO);
	}

	public static Rect KOAAFAOHINH(Rect HGMPLGNJEPC, int KODEGPNOHNB, int JPGIEHMKOPA)
	{
		Rect result = HGMPLGNJEPC;
		if ((float)KODEGPNOHNB != 0f && (float)JPGIEHMKOPA != 0f)
		{
			result.xMin = HGMPLGNJEPC.xMin / (float)KODEGPNOHNB;
			result.xMax = HGMPLGNJEPC.xMax / (float)KODEGPNOHNB;
			result.yMin = 1f - HGMPLGNJEPC.yMax / (float)JPGIEHMKOPA;
			result.yMax = 1f - HGMPLGNJEPC.yMin / (float)JPGIEHMKOPA;
		}
		return result;
	}

	public static Rect MEDHFBHAEAE(Rect HGMPLGNJEPC, int KODEGPNOHNB, int JPGIEHMKOPA, bool CMMFEMMALAL)
	{
		Rect result = HGMPLGNJEPC;
		if (CMMFEMMALAL)
		{
			result.xMin = Mathf.RoundToInt(HGMPLGNJEPC.xMin * (float)KODEGPNOHNB);
			result.xMax = Mathf.RoundToInt(HGMPLGNJEPC.xMax * (float)KODEGPNOHNB);
			result.yMin = Mathf.RoundToInt((1f - HGMPLGNJEPC.yMax) * (float)JPGIEHMKOPA);
			result.yMax = Mathf.RoundToInt((1f - HGMPLGNJEPC.yMin) * (float)JPGIEHMKOPA);
		}
		else
		{
			result.xMin = HGMPLGNJEPC.xMin * (float)KODEGPNOHNB;
			result.xMax = HGMPLGNJEPC.xMax * (float)KODEGPNOHNB;
			result.yMin = (1f - HGMPLGNJEPC.yMax) * (float)JPGIEHMKOPA;
			result.yMax = (1f - HGMPLGNJEPC.yMin) * (float)JPGIEHMKOPA;
		}
		return result;
	}

	public static Rect EKLDFOODNKJ(Rect HGMPLGNJEPC)
	{
		HGMPLGNJEPC.xMin = Mathf.RoundToInt(HGMPLGNJEPC.xMin);
		HGMPLGNJEPC.yMin = Mathf.RoundToInt(HGMPLGNJEPC.yMin);
		HGMPLGNJEPC.xMax = Mathf.RoundToInt(HGMPLGNJEPC.xMax);
		HGMPLGNJEPC.yMax = Mathf.RoundToInt(HGMPLGNJEPC.yMax);
		return HGMPLGNJEPC;
	}

	public static Rect EKLDFOODNKJ(Rect HGMPLGNJEPC, int KODEGPNOHNB, int JPGIEHMKOPA)
	{
		HGMPLGNJEPC = MEDHFBHAEAE(HGMPLGNJEPC, KODEGPNOHNB, JPGIEHMKOPA, true);
		HGMPLGNJEPC.xMin = Mathf.RoundToInt(HGMPLGNJEPC.xMin);
		HGMPLGNJEPC.yMin = Mathf.RoundToInt(HGMPLGNJEPC.yMin);
		HGMPLGNJEPC.xMax = Mathf.RoundToInt(HGMPLGNJEPC.xMax);
		HGMPLGNJEPC.yMax = Mathf.RoundToInt(HGMPLGNJEPC.yMax);
		return KOAAFAOHINH(HGMPLGNJEPC, KODEGPNOHNB, JPGIEHMKOPA);
	}

	public static Vector2 HGFCFKHEOHJ(Vector2 HCFEAFBPEKE, Vector2 HBPCPGFEACJ, Vector2 KNHKAOPKFBG, Vector2 MPPJMELKOLE)
	{
		Vector2 zero = Vector2.zero;
		float num = HBPCPGFEACJ.x - HCFEAFBPEKE.x;
		float num2 = HBPCPGFEACJ.y - HCFEAFBPEKE.y;
		float num3 = MPPJMELKOLE.x - KNHKAOPKFBG.x;
		float num4 = MPPJMELKOLE.y - KNHKAOPKFBG.y;
		if (num > num3)
		{
			float num5 = num - num3;
			KNHKAOPKFBG.x -= num5;
			MPPJMELKOLE.x += num5;
		}
		if (num2 > num4)
		{
			float num6 = num2 - num4;
			KNHKAOPKFBG.y -= num6;
			MPPJMELKOLE.y += num6;
		}
		if (HCFEAFBPEKE.x < KNHKAOPKFBG.x)
		{
			zero.x += KNHKAOPKFBG.x - HCFEAFBPEKE.x;
		}
		if (HBPCPGFEACJ.x > MPPJMELKOLE.x)
		{
			zero.x -= HBPCPGFEACJ.x - MPPJMELKOLE.x;
		}
		if (HCFEAFBPEKE.y < KNHKAOPKFBG.y)
		{
			zero.y += KNHKAOPKFBG.y - HCFEAFBPEKE.y;
		}
		if (HBPCPGFEACJ.y > MPPJMELKOLE.y)
		{
			zero.y -= HBPCPGFEACJ.y - MPPJMELKOLE.y;
		}
		return zero;
	}

	public static Bounds NMEFALEJEJF(Transform FOMOIPPFLBA)
	{
		if (FOMOIPPFLBA != null)
		{
			UIWidget[] componentsInChildren = FOMOIPPFLBA.GetComponentsInChildren<UIWidget>();
			if (componentsInChildren.Length == 0)
			{
				return new Bounds(FOMOIPPFLBA.position, Vector3.zero);
			}
			Vector3 center = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 point = new Vector3(float.MinValue, float.MinValue, float.MinValue);
			int i = 0;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				UIWidget uIWidget = componentsInChildren[i];
				if (!uIWidget.enabled)
				{
					continue;
				}
				Vector3[] worldCorners = uIWidget.get_worldCorners();
				for (int j = 0; j < 4; j++)
				{
					Vector3 vector = worldCorners[j];
					if (vector.x > point.x)
					{
						point.x = vector.x;
					}
					if (vector.y > point.y)
					{
						point.y = vector.y;
					}
					if (vector.z > point.z)
					{
						point.z = vector.z;
					}
					if (vector.x < center.x)
					{
						center.x = vector.x;
					}
					if (vector.y < center.y)
					{
						center.y = vector.y;
					}
					if (vector.z < center.z)
					{
						center.z = vector.z;
					}
				}
			}
			Bounds result = new Bounds(center, Vector3.zero);
			result.Encapsulate(point);
			return result;
		}
		return new Bounds(Vector3.zero, Vector3.zero);
	}

	public static Bounds NBKPEOJPGHD(Transform FOMOIPPFLBA)
	{
		return NBKPEOJPGHD(FOMOIPPFLBA, FOMOIPPFLBA, false);
	}

	public static Bounds NBKPEOJPGHD(Transform FOMOIPPFLBA, bool IJOOEOPFMIH)
	{
		return NBKPEOJPGHD(FOMOIPPFLBA, FOMOIPPFLBA, IJOOEOPFMIH);
	}

	public static Bounds NBKPEOJPGHD(Transform DNIFGOKCBEL, Transform AOJANHAIAFP)
	{
		return NBKPEOJPGHD(DNIFGOKCBEL, AOJANHAIAFP, false);
	}

	public static Bounds NBKPEOJPGHD(Transform DNIFGOKCBEL, Transform AOJANHAIAFP, bool IJOOEOPFMIH)
	{
		if (AOJANHAIAFP != null && DNIFGOKCBEL != null)
		{
			bool IJMBKDCJDIA = false;
			Matrix4x4 HBAGPGKGNOB = DNIFGOKCBEL.worldToLocalMatrix;
			Vector3 KHEEKILOGIA = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);
			Vector3 BNHLMFNNFMP = new Vector3(float.MinValue, float.MinValue, float.MinValue);
			NBKPEOJPGHD(AOJANHAIAFP, IJOOEOPFMIH, true, ref HBAGPGKGNOB, ref KHEEKILOGIA, ref BNHLMFNNFMP, ref IJMBKDCJDIA);
			if (IJMBKDCJDIA)
			{
				Bounds result = new Bounds(KHEEKILOGIA, Vector3.zero);
				result.Encapsulate(BNHLMFNNFMP);
				return result;
			}
		}
		return new Bounds(Vector3.zero, Vector3.zero);
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	private static void NBKPEOJPGHD(Transform AOJANHAIAFP, bool IJOOEOPFMIH, bool NLPCBLNMGBE, ref Matrix4x4 HBAGPGKGNOB, ref Vector3 KHEEKILOGIA, ref Vector3 BNHLMFNNFMP, ref bool IJMBKDCJDIA)
	{
		if (AOJANHAIAFP == null || (!IJOOEOPFMIH && !NLDABIMKKMP.FGIDLKLMBHB(AOJANHAIAFP.gameObject)))
		{
			return;
		}
		UIPanel uIPanel = ((!NLPCBLNMGBE) ? AOJANHAIAFP.GetComponent<UIPanel>() : null);
		if (uIPanel != null && !uIPanel.enabled)
		{
			return;
		}
		if (uIPanel != null && uIPanel.get_clipping() != UIDrawCall.ACDCGJDEDLO.None)
		{
			Vector3[] worldCorners = uIPanel.get_worldCorners();
			for (int i = 0; i < 4; i++)
			{
				Vector3 vector = HBAGPGKGNOB.MultiplyPoint3x4(worldCorners[i]);
				if (vector.x > BNHLMFNNFMP.x)
				{
					BNHLMFNNFMP.x = vector.x;
				}
				if (vector.y > BNHLMFNNFMP.y)
				{
					BNHLMFNNFMP.y = vector.y;
				}
				if (vector.z > BNHLMFNNFMP.z)
				{
					BNHLMFNNFMP.z = vector.z;
				}
				if (vector.x < KHEEKILOGIA.x)
				{
					KHEEKILOGIA.x = vector.x;
				}
				if (vector.y < KHEEKILOGIA.y)
				{
					KHEEKILOGIA.y = vector.y;
				}
				if (vector.z < KHEEKILOGIA.z)
				{
					KHEEKILOGIA.z = vector.z;
				}
				IJMBKDCJDIA = true;
			}
			return;
		}
		UIWidget component = AOJANHAIAFP.GetComponent<UIWidget>();
		if (component != null && component.enabled)
		{
			Vector3[] worldCorners2 = component.get_worldCorners();
			for (int j = 0; j < 4; j++)
			{
				Vector3 vector2 = HBAGPGKGNOB.MultiplyPoint3x4(worldCorners2[j]);
				if (vector2.x > BNHLMFNNFMP.x)
				{
					BNHLMFNNFMP.x = vector2.x;
				}
				if (vector2.y > BNHLMFNNFMP.y)
				{
					BNHLMFNNFMP.y = vector2.y;
				}
				if (vector2.z > BNHLMFNNFMP.z)
				{
					BNHLMFNNFMP.z = vector2.z;
				}
				if (vector2.x < KHEEKILOGIA.x)
				{
					KHEEKILOGIA.x = vector2.x;
				}
				if (vector2.y < KHEEKILOGIA.y)
				{
					KHEEKILOGIA.y = vector2.y;
				}
				if (vector2.z < KHEEKILOGIA.z)
				{
					KHEEKILOGIA.z = vector2.z;
				}
				IJMBKDCJDIA = true;
			}
		}
		int k = 0;
		for (int childCount = AOJANHAIAFP.childCount; k < childCount; k++)
		{
			NBKPEOJPGHD(AOJANHAIAFP.GetChild(k), IJOOEOPFMIH, false, ref HBAGPGKGNOB, ref KHEEKILOGIA, ref BNHLMFNNFMP, ref IJMBKDCJDIA);
		}
	}

	public static Vector3 JEOLBKHAIAF(ref Vector3 BPDMFHMJNBB, float NKNAABDPFBC, float OJAOJFBJGAH)
	{
		if (OJAOJFBJGAH > 1f)
		{
			OJAOJFBJGAH = 1f;
		}
		float f = 1f - NKNAABDPFBC * 0.001f;
		int num = Mathf.RoundToInt(OJAOJFBJGAH * 1000f);
		float num2 = Mathf.Pow(f, num);
		Vector3 vector = BPDMFHMJNBB * ((num2 - 1f) / Mathf.Log(f));
		BPDMFHMJNBB *= num2;
		return vector * 0.06f;
	}

	public static Vector2 JEOLBKHAIAF(ref Vector2 BPDMFHMJNBB, float NKNAABDPFBC, float OJAOJFBJGAH)
	{
		if (OJAOJFBJGAH > 1f)
		{
			OJAOJFBJGAH = 1f;
		}
		float f = 1f - NKNAABDPFBC * 0.001f;
		int num = Mathf.RoundToInt(OJAOJFBJGAH * 1000f);
		float num2 = Mathf.Pow(f, num);
		Vector2 vector = BPDMFHMJNBB * ((num2 - 1f) / Mathf.Log(f));
		BPDMFHMJNBB *= num2;
		return vector * 0.06f;
	}

	public static float CHIGCMCIABC(float NKNAABDPFBC, float OJAOJFBJGAH)
	{
		if (OJAOJFBJGAH > 1f)
		{
			OJAOJFBJGAH = 1f;
		}
		int num = Mathf.RoundToInt(OJAOJFBJGAH * 1000f);
		OJAOJFBJGAH = 0.001f * NKNAABDPFBC;
		float num2 = 0f;
		for (int i = 0; i < num; i++)
		{
			num2 = Mathf.Lerp(num2, 1f, OJAOJFBJGAH);
		}
		return num2;
	}

	public static float CHIGCMCIABC(float HGKDALECODA, float CIBKFGPHPGN, float NKNAABDPFBC, float OJAOJFBJGAH)
	{
		if (OJAOJFBJGAH > 1f)
		{
			OJAOJFBJGAH = 1f;
		}
		int num = Mathf.RoundToInt(OJAOJFBJGAH * 1000f);
		OJAOJFBJGAH = 0.001f * NKNAABDPFBC;
		for (int i = 0; i < num; i++)
		{
			HGKDALECODA = Mathf.Lerp(HGKDALECODA, CIBKFGPHPGN, OJAOJFBJGAH);
		}
		return HGKDALECODA;
	}

	public static Vector2 CHIGCMCIABC(Vector2 HGKDALECODA, Vector2 CIBKFGPHPGN, float NKNAABDPFBC, float OJAOJFBJGAH)
	{
		return Vector2.Lerp(HGKDALECODA, CIBKFGPHPGN, CHIGCMCIABC(NKNAABDPFBC, OJAOJFBJGAH));
	}

	public static Vector3 CHIGCMCIABC(Vector3 HGKDALECODA, Vector3 CIBKFGPHPGN, float NKNAABDPFBC, float OJAOJFBJGAH)
	{
		return Vector3.Lerp(HGKDALECODA, CIBKFGPHPGN, CHIGCMCIABC(NKNAABDPFBC, OJAOJFBJGAH));
	}

	public static Quaternion CHIGCMCIABC(Quaternion HGKDALECODA, Quaternion CIBKFGPHPGN, float NKNAABDPFBC, float OJAOJFBJGAH)
	{
		return Quaternion.Slerp(HGKDALECODA, CIBKFGPHPGN, CHIGCMCIABC(NKNAABDPFBC, OJAOJFBJGAH));
	}

	public static float KMDHINACBGC(float HGKDALECODA, float CIBKFGPHPGN, float IAAAPJHNLBF)
	{
		float num = ABNMAJAPKCG(CIBKFGPHPGN - HGKDALECODA);
		if (Mathf.Abs(num) > IAAAPJHNLBF)
		{
			num = IAAAPJHNLBF * Mathf.Sign(num);
		}
		return HGKDALECODA + num;
	}

	private static float DPEOKPBBHII(Vector2 HFDENIPJGDG, Vector2 IFGAPHGCLHF, Vector2 GMMDCPLBFJL)
	{
		float sqrMagnitude = (GMMDCPLBFJL - IFGAPHGCLHF).sqrMagnitude;
		if (sqrMagnitude == 0f)
		{
			return (HFDENIPJGDG - IFGAPHGCLHF).magnitude;
		}
		float num = Vector2.Dot(HFDENIPJGDG - IFGAPHGCLHF, GMMDCPLBFJL - IFGAPHGCLHF) / sqrMagnitude;
		if (num < 0f)
		{
			return (HFDENIPJGDG - IFGAPHGCLHF).magnitude;
		}
		if (num > 1f)
		{
			return (HFDENIPJGDG - GMMDCPLBFJL).magnitude;
		}
		Vector2 vector = IFGAPHGCLHF + num * (GMMDCPLBFJL - IFGAPHGCLHF);
		return (HFDENIPJGDG - vector).magnitude;
	}

	public static float AKMLOEFNKOJ(Vector2[] LFPKMDCDILN, Vector2 EJGJIPPBICH)
	{
		bool flag = false;
		int jKJGJMOEHDO = 4;
		for (int i = 0; i < 5; i++)
		{
			Vector3 vector = LFPKMDCDILN[FMIHOIEFOON(i, 4)];
			Vector3 vector2 = LFPKMDCDILN[FMIHOIEFOON(jKJGJMOEHDO, 4)];
			if (vector.y > EJGJIPPBICH.y != vector2.y > EJGJIPPBICH.y && EJGJIPPBICH.x < (vector2.x - vector.x) * (EJGJIPPBICH.y - vector.y) / (vector2.y - vector.y) + vector.x)
			{
				flag = !flag;
			}
			jKJGJMOEHDO = i;
		}
		if (!flag)
		{
			float num = -1f;
			for (int j = 0; j < 4; j++)
			{
				Vector3 vector3 = LFPKMDCDILN[j];
				Vector3 vector4 = LFPKMDCDILN[FMIHOIEFOON(j + 1, 4)];
				float num2 = DPEOKPBBHII(EJGJIPPBICH, vector3, vector4);
				if (num2 < num || num < 0f)
				{
					num = num2;
				}
			}
			return num;
		}
		return 0f;
	}

	public static float AKMLOEFNKOJ(Vector3[] IPEJIEFPMKF, Vector2 EJGJIPPBICH, Camera DDKDLNDJAMA)
	{
		Vector2[] array = new Vector2[4];
		for (int i = 0; i < 4; i++)
		{
			array[i] = DDKDLNDJAMA.WorldToScreenPoint(IPEJIEFPMKF[i]);
		}
		return AKMLOEFNKOJ(array, EJGJIPPBICH);
	}

	public static Vector2 OILFNOECKPI(UIWidget.MADDMCMJKFI PBGJPPBLOGB)
	{
		Vector2 zero = Vector2.zero;
		switch (PBGJPPBLOGB)
		{
		case UIWidget.MADDMCMJKFI.Top:
		case UIWidget.MADDMCMJKFI.Center:
		case UIWidget.MADDMCMJKFI.Bottom:
			zero.x = 0.5f;
			break;
		case UIWidget.MADDMCMJKFI.TopRight:
		case UIWidget.MADDMCMJKFI.Right:
		case UIWidget.MADDMCMJKFI.BottomRight:
			zero.x = 1f;
			break;
		default:
			zero.x = 0f;
			break;
		}
		switch (PBGJPPBLOGB)
		{
		case UIWidget.MADDMCMJKFI.Left:
		case UIWidget.MADDMCMJKFI.Center:
		case UIWidget.MADDMCMJKFI.Right:
			zero.y = 0.5f;
			break;
		case UIWidget.MADDMCMJKFI.TopLeft:
		case UIWidget.MADDMCMJKFI.Top:
		case UIWidget.MADDMCMJKFI.TopRight:
			zero.y = 1f;
			break;
		default:
			zero.y = 0f;
			break;
		}
		return zero;
	}

	public static UIWidget.MADDMCMJKFI FIIPBCFKFBF(Vector2 BFEECILPJLM)
	{
		if (BFEECILPJLM.x == 0f)
		{
			if (BFEECILPJLM.y == 0f)
			{
				return UIWidget.MADDMCMJKFI.BottomLeft;
			}
			if (BFEECILPJLM.y == 1f)
			{
				return UIWidget.MADDMCMJKFI.TopLeft;
			}
			return UIWidget.MADDMCMJKFI.Left;
		}
		if (BFEECILPJLM.x == 1f)
		{
			if (BFEECILPJLM.y == 0f)
			{
				return UIWidget.MADDMCMJKFI.BottomRight;
			}
			if (BFEECILPJLM.y == 1f)
			{
				return UIWidget.MADDMCMJKFI.TopRight;
			}
			return UIWidget.MADDMCMJKFI.Right;
		}
		if (BFEECILPJLM.y == 0f)
		{
			return UIWidget.MADDMCMJKFI.Bottom;
		}
		if (BFEECILPJLM.y == 1f)
		{
			return UIWidget.MADDMCMJKFI.Top;
		}
		return UIWidget.MADDMCMJKFI.Center;
	}

	public static void OELEDMGBCDE(UIRect ADFJMGLHGHC, float MPBOINGECFO, float OECPEJEIMHO)
	{
		NIBNHOBPPFL(ADFJMGLHGHC, MPBOINGECFO, OECPEJEIMHO);
	}

	public static void NIBNHOBPPFL(UIRect HGMPLGNJEPC, float MPBOINGECFO, float OECPEJEIMHO)
	{
		int num = Mathf.FloorToInt(MPBOINGECFO + 0.5f);
		int num2 = Mathf.FloorToInt(OECPEJEIMHO + 0.5f);
		HGMPLGNJEPC.get_cachedTransform().localPosition += new Vector3(num, num2);
		int num3 = 0;
		if ((bool)HGMPLGNJEPC.leftAnchor.target)
		{
			num3++;
			HGMPLGNJEPC.leftAnchor.absolute += num;
		}
		if ((bool)HGMPLGNJEPC.rightAnchor.target)
		{
			num3++;
			HGMPLGNJEPC.rightAnchor.absolute += num;
		}
		if ((bool)HGMPLGNJEPC.bottomAnchor.target)
		{
			num3++;
			HGMPLGNJEPC.bottomAnchor.absolute += num2;
		}
		if ((bool)HGMPLGNJEPC.topAnchor.target)
		{
			num3++;
			HGMPLGNJEPC.topAnchor.absolute += num2;
		}
		if (num3 != 0)
		{
			HGMPLGNJEPC.UpdateAnchors();
		}
	}

	public static void ANBJFLPMMFM(UIWidget ADFJMGLHGHC, UIWidget.MADDMCMJKFI NKHHGLDCFOE, float MPBOINGECFO, float OECPEJEIMHO, int AAHPICGBDMF, int MNMJMJPFNMA)
	{
		ANBJFLPMMFM(ADFJMGLHGHC, NKHHGLDCFOE, MPBOINGECFO, OECPEJEIMHO, 2, 2, 100000, 100000);
	}

	public static void ANBJFLPMMFM(UIWidget ADFJMGLHGHC, UIWidget.MADDMCMJKFI NKHHGLDCFOE, float MPBOINGECFO, float OECPEJEIMHO, int AAHPICGBDMF, int MNMJMJPFNMA, int FPLIHFAPPOC, int DEFEACMLIFG)
	{
		if (NKHHGLDCFOE == UIWidget.MADDMCMJKFI.Center)
		{
			int num = Mathf.RoundToInt(MPBOINGECFO - (float)ADFJMGLHGHC.get_width());
			int num2 = Mathf.RoundToInt(OECPEJEIMHO - (float)ADFJMGLHGHC.get_height());
			num -= num & 1;
			num2 -= num2 & 1;
			if ((num | num2) != 0)
			{
				num >>= 1;
				num2 >>= 1;
				JOHHMNNEHPJ(ADFJMGLHGHC, -num, -num2, num, num2, AAHPICGBDMF, MNMJMJPFNMA);
			}
			return;
		}
		Vector3 vector = new Vector3(MPBOINGECFO, OECPEJEIMHO);
		vector = Quaternion.Inverse(ADFJMGLHGHC.get_cachedTransform().localRotation) * vector;
		switch (NKHHGLDCFOE)
		{
		case UIWidget.MADDMCMJKFI.BottomLeft:
			JOHHMNNEHPJ(ADFJMGLHGHC, vector.x, vector.y, 0f, 0f, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.Left:
			JOHHMNNEHPJ(ADFJMGLHGHC, vector.x, 0f, 0f, 0f, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.TopLeft:
			JOHHMNNEHPJ(ADFJMGLHGHC, vector.x, 0f, 0f, vector.y, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.Top:
			JOHHMNNEHPJ(ADFJMGLHGHC, 0f, 0f, 0f, vector.y, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.TopRight:
			JOHHMNNEHPJ(ADFJMGLHGHC, 0f, 0f, vector.x, vector.y, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.Right:
			JOHHMNNEHPJ(ADFJMGLHGHC, 0f, 0f, vector.x, 0f, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.BottomRight:
			JOHHMNNEHPJ(ADFJMGLHGHC, 0f, vector.y, vector.x, 0f, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.Bottom:
			JOHHMNNEHPJ(ADFJMGLHGHC, 0f, vector.y, 0f, 0f, AAHPICGBDMF, MNMJMJPFNMA, FPLIHFAPPOC, DEFEACMLIFG);
			break;
		case UIWidget.MADDMCMJKFI.Center:
			break;
		}
	}

	public static void JOHHMNNEHPJ(UIWidget ADFJMGLHGHC, float FPCKPMKLBDG, float HKAHBBIAGHM, float FADFOBCCGNM, float JINCLNOFKNM)
	{
		JOHHMNNEHPJ(ADFJMGLHGHC, FPCKPMKLBDG, HKAHBBIAGHM, FADFOBCCGNM, JINCLNOFKNM, 2, 2, 100000, 100000);
	}

	public static void JOHHMNNEHPJ(UIWidget ADFJMGLHGHC, float FPCKPMKLBDG, float HKAHBBIAGHM, float FADFOBCCGNM, float JINCLNOFKNM, int AAHPICGBDMF, int MNMJMJPFNMA)
	{
		JOHHMNNEHPJ(ADFJMGLHGHC, FPCKPMKLBDG, HKAHBBIAGHM, FADFOBCCGNM, JINCLNOFKNM, AAHPICGBDMF, MNMJMJPFNMA, 100000, 100000);
	}

	public static void JOHHMNNEHPJ(UIWidget ADFJMGLHGHC, float FPCKPMKLBDG, float HKAHBBIAGHM, float FADFOBCCGNM, float JINCLNOFKNM, int AAHPICGBDMF, int MNMJMJPFNMA, int FPLIHFAPPOC, int DEFEACMLIFG)
	{
		Vector2 pivotOffset = ADFJMGLHGHC.get_pivotOffset();
		Transform cachedTransform = ADFJMGLHGHC.get_cachedTransform();
		Quaternion localRotation = cachedTransform.localRotation;
		int num = Mathf.FloorToInt(FPCKPMKLBDG + 0.5f);
		int num2 = Mathf.FloorToInt(HKAHBBIAGHM + 0.5f);
		int num3 = Mathf.FloorToInt(FADFOBCCGNM + 0.5f);
		int num4 = Mathf.FloorToInt(JINCLNOFKNM + 0.5f);
		if (pivotOffset.x == 0.5f && (num == 0 || num3 == 0))
		{
			num = num >> 1 << 1;
			num3 = num3 >> 1 << 1;
		}
		if (pivotOffset.y == 0.5f && (num2 == 0 || num4 == 0))
		{
			num2 = num2 >> 1 << 1;
			num4 = num4 >> 1 << 1;
		}
		Vector3 vector = localRotation * new Vector3(num, num4);
		Vector3 vector2 = localRotation * new Vector3(num3, num4);
		Vector3 vector3 = localRotation * new Vector3(num, num2);
		Vector3 vector4 = localRotation * new Vector3(num3, num2);
		Vector3 vector5 = localRotation * new Vector3(num, 0f);
		Vector3 vector6 = localRotation * new Vector3(num3, 0f);
		Vector3 vector7 = localRotation * new Vector3(0f, num4);
		Vector3 vector8 = localRotation * new Vector3(0f, num2);
		Vector3 zero = Vector3.zero;
		if (pivotOffset.x == 0f && pivotOffset.y == 1f)
		{
			zero.x = vector.x;
			zero.y = vector.y;
		}
		else if (pivotOffset.x == 1f && pivotOffset.y == 0f)
		{
			zero.x = vector4.x;
			zero.y = vector4.y;
		}
		else if (pivotOffset.x == 0f && pivotOffset.y == 0f)
		{
			zero.x = vector3.x;
			zero.y = vector3.y;
		}
		else if (pivotOffset.x == 1f && pivotOffset.y == 1f)
		{
			zero.x = vector2.x;
			zero.y = vector2.y;
		}
		else if (pivotOffset.x == 0f && pivotOffset.y == 0.5f)
		{
			zero.x = vector5.x + (vector7.x + vector8.x) * 0.5f;
			zero.y = vector5.y + (vector7.y + vector8.y) * 0.5f;
		}
		else if (pivotOffset.x == 1f && pivotOffset.y == 0.5f)
		{
			zero.x = vector6.x + (vector7.x + vector8.x) * 0.5f;
			zero.y = vector6.y + (vector7.y + vector8.y) * 0.5f;
		}
		else if (pivotOffset.x == 0.5f && pivotOffset.y == 1f)
		{
			zero.x = vector7.x + (vector5.x + vector6.x) * 0.5f;
			zero.y = vector7.y + (vector5.y + vector6.y) * 0.5f;
		}
		else if (pivotOffset.x == 0.5f && pivotOffset.y == 0f)
		{
			zero.x = vector8.x + (vector5.x + vector6.x) * 0.5f;
			zero.y = vector8.y + (vector5.y + vector6.y) * 0.5f;
		}
		else if (pivotOffset.x == 0.5f && pivotOffset.y == 0.5f)
		{
			zero.x = (vector5.x + vector6.x + vector7.x + vector8.x) * 0.5f;
			zero.y = (vector7.y + vector8.y + vector5.y + vector6.y) * 0.5f;
		}
		AAHPICGBDMF = Mathf.Max(AAHPICGBDMF, ADFJMGLHGHC.get_minWidth());
		MNMJMJPFNMA = Mathf.Max(MNMJMJPFNMA, ADFJMGLHGHC.get_minHeight());
		int num5 = ADFJMGLHGHC.get_width() + num3 - num;
		int num6 = ADFJMGLHGHC.get_height() + num4 - num2;
		Vector3 zero2 = Vector3.zero;
		int num7 = num5;
		if (num5 < AAHPICGBDMF)
		{
			num7 = AAHPICGBDMF;
		}
		else if (num5 > FPLIHFAPPOC)
		{
			num7 = FPLIHFAPPOC;
		}
		if (num5 != num7)
		{
			if (num != 0)
			{
				zero2.x -= Mathf.Lerp(num7 - num5, 0f, pivotOffset.x);
			}
			else
			{
				zero2.x += Mathf.Lerp(0f, num7 - num5, pivotOffset.x);
			}
			num5 = num7;
		}
		int num8 = num6;
		if (num6 < MNMJMJPFNMA)
		{
			num8 = MNMJMJPFNMA;
		}
		else if (num6 > DEFEACMLIFG)
		{
			num8 = DEFEACMLIFG;
		}
		if (num6 != num8)
		{
			if (num2 != 0)
			{
				zero2.y -= Mathf.Lerp(num8 - num6, 0f, pivotOffset.y);
			}
			else
			{
				zero2.y += Mathf.Lerp(0f, num8 - num6, pivotOffset.y);
			}
			num6 = num8;
		}
		if (pivotOffset.x == 0.5f)
		{
			num5 = num5 >> 1 << 1;
		}
		if (pivotOffset.y == 0.5f)
		{
			num6 = num6 >> 1 << 1;
		}
		Vector3 vector9 = (cachedTransform.localPosition = cachedTransform.localPosition + zero + localRotation * zero2);
		ADFJMGLHGHC.SetDimensions(num5, num6);
		if (ADFJMGLHGHC.get_isAnchored())
		{
			cachedTransform = cachedTransform.parent;
			float num9 = vector9.x - pivotOffset.x * (float)num5;
			float num10 = vector9.y - pivotOffset.y * (float)num6;
			if ((bool)ADFJMGLHGHC.leftAnchor.target)
			{
				ADFJMGLHGHC.leftAnchor.MCFJPKPKGPF(cachedTransform, num9);
			}
			if ((bool)ADFJMGLHGHC.rightAnchor.target)
			{
				ADFJMGLHGHC.rightAnchor.MCFJPKPKGPF(cachedTransform, num9 + (float)num5);
			}
			if ((bool)ADFJMGLHGHC.bottomAnchor.target)
			{
				ADFJMGLHGHC.bottomAnchor.DEFOECCCCAM(cachedTransform, num10);
			}
			if ((bool)ADFJMGLHGHC.topAnchor.target)
			{
				ADFJMGLHGHC.topAnchor.DEFOECCCCAM(cachedTransform, num10 + (float)num6);
			}
		}
	}

	public static int GOODOAHFHDC(float JPGIEHMKOPA)
	{
		float num = Screen.dpi;
		RuntimePlatform platform = Application.platform;
		if (num == 0f)
		{
			num = ((platform != RuntimePlatform.Android && platform != RuntimePlatform.IPhonePlayer) ? 96f : 160f);
		}
		int num2 = Mathf.RoundToInt(JPGIEHMKOPA * (96f / num));
		if ((num2 & 1) == 1)
		{
			num2++;
		}
		return num2;
	}

	public static Vector2 IBILJFHHGJL(Vector2 HEPNHCEIFMO, Transform DNIFGOKCBEL)
	{
		int layer = DNIFGOKCBEL.gameObject.layer;
		Camera camera = NLDABIMKKMP.MLHKJOCLJIC(layer);
		if (camera == null)
		{
			UnityEngine.Debug.LogWarning("No camera found for layer " + layer);
			return HEPNHCEIFMO;
		}
		Vector3 position = camera.ScreenToWorldPoint(HEPNHCEIFMO);
		return DNIFGOKCBEL.InverseTransformPoint(position);
	}

	public static Vector2 KPBHLFIMBDK(Vector2 HEPNHCEIFMO, Transform DNIFGOKCBEL)
	{
		int layer = DNIFGOKCBEL.gameObject.layer;
		if (DNIFGOKCBEL.parent != null)
		{
			DNIFGOKCBEL = DNIFGOKCBEL.parent;
		}
		Camera camera = NLDABIMKKMP.MLHKJOCLJIC(layer);
		if (camera == null)
		{
			UnityEngine.Debug.LogWarning("No camera found for layer " + layer);
			return HEPNHCEIFMO;
		}
		Vector3 vector = camera.ScreenToWorldPoint(HEPNHCEIFMO);
		return (!(DNIFGOKCBEL != null)) ? vector : DNIFGOKCBEL.InverseTransformPoint(vector);
	}
}
