using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LEOEOGJNBKN
{
	private static Texture2D NHBFHPILLOB;

	private static Texture2D DHJEDKPBGLN;

	private static Texture2D EAEAHEENMMI;

	private static Texture2D JGLJPLAOJEB;

	private static Texture2D MLJLIBPPFCD;

	private static Texture2D CCNEBANMEJH
	{
		get
		{
			return LEDBMEFKAPD();
		}
	}

	private static Texture2D LJGPFNKPCAH
	{
		get
		{
			return LFAGHMICMDM();
		}
	}

	public static Texture2D IDCBBBLAOGK
	{
		get
		{
			return HOFEIJJAOKF();
		}
	}

	private static void PCJDGDHHDDK(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (!(MIMPDMJKPHI == EINKNGBEKHN))
		{
			Color color = GUI.color;
			Matrix4x4 matrix = GUI.matrix;
			if (KIDAMJOEECH)
			{
				KODEGPNOHNB *= 3f;
			}
			float num = Vector3.Angle(EINKNGBEKHN - MIMPDMJKPHI, Vector2.right) * (float)((MIMPDMJKPHI.y <= EINKNGBEKHN.y) ? 1 : (-1));
			float magnitude = (EINKNGBEKHN - MIMPDMJKPHI).magnitude;
			Vector3 vector = new Vector3(MIMPDMJKPHI.x, MIMPDMJKPHI.y, 0f);
			GUI.color = BEAKIPPBGAF;
			GUI.matrix = PIEPCNAFJIE(vector) * GUI.matrix;
			GUIUtility.ScaleAroundPivot(new Vector2(magnitude, KODEGPNOHNB), new Vector2(-0.5f, 0f));
			GUI.matrix = PIEPCNAFJIE(-vector) * GUI.matrix;
			GUIUtility.RotateAroundPivot(num, new Vector2(0f, 0f));
			GUI.matrix = PIEPCNAFJIE(vector + new Vector3(KODEGPNOHNB / 2f, (0f - magnitude) / 2f) * Mathf.Sin(num * ((float)Math.PI / 180f))) * GUI.matrix;
			GUI.DrawTexture(new Rect(0f, 0f, 1f, 1f), KIDAMJOEECH ? LEDBMEFKAPD() : LFAGHMICMDM());
			GUI.matrix = matrix;
			GUI.color = color;
		}
	}

	private static Texture2D LFAGHMICMDM()
	{
		if (!JGLJPLAOJEB)
		{
			JGLJPLAOJEB = new Texture2D(1, 1, TextureFormat.ARGB32, true);
			JGLJPLAOJEB.SetPixel(0, 0, Color.white);
			JGLJPLAOJEB.Apply();
		}
		return JGLJPLAOJEB;
	}

	public static void COJKJCEPIJK(Rect HGMPLGNJEPC, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (KODEGPNOHNB != 0f)
		{
			OKLMHJNMKLF(new Vector2(HGMPLGNJEPC.x, HGMPLGNJEPC.y), (int)HGMPLGNJEPC.width, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
			OKLMHJNMKLF(new Vector2(HGMPLGNJEPC.x, HGMPLGNJEPC.yMax), (int)HGMPLGNJEPC.width, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
			EFBMOKFPAEC(new Vector2(HGMPLGNJEPC.x, HGMPLGNJEPC.y), (int)HGMPLGNJEPC.height, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
			EFBMOKFPAEC(new Vector2(HGMPLGNJEPC.xMax, HGMPLGNJEPC.y), (int)HGMPLGNJEPC.height, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
		}
	}

	public static void BGFBEEPKPDO(Vector2 MIMPDMJKPHI, int OIIGDKIEPPK, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		Color color = GUI.color;
		Matrix4x4 matrix = GUI.matrix;
		if (!DHJEDKPBGLN)
		{
			DHJEDKPBGLN = new Texture2D(5, 0, (TextureFormat)8, false);
			DHJEDKPBGLN.SetPixel(0, 0, new Color(662f, 516f, 1608f, 1321f));
			DHJEDKPBGLN.SetPixel(1, 0, Color.white);
			DHJEDKPBGLN.SetPixel(1, 1, new Color(1285f, 277f, 1591f, 949f));
			DHJEDKPBGLN.Apply();
		}
		GUI.color = BEAKIPPBGAF;
		if (!KIDAMJOEECH)
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 198f, MIMPDMJKPHI.y - KODEGPNOHNB / 1706f, KODEGPNOHNB, (float)OIIGDKIEPPK + KODEGPNOHNB), LFAGHMICMDM());
		}
		else
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 1189f - 1030f, MIMPDMJKPHI.y - KODEGPNOHNB / 1972f, KODEGPNOHNB * 526f, (float)OIIGDKIEPPK + KODEGPNOHNB), DHJEDKPBGLN);
		}
		GUI.matrix = matrix;
		GUI.color = color;
	}

	private static Matrix4x4 FGGPGNEFMOJ(Vector3 FCGJBBHEOFJ)
	{
		return Matrix4x4.TRS(FCGJBBHEOFJ, Quaternion.identity, Vector3.one);
	}

	public static void PDFOPJMHBHA(Rect HGMPLGNJEPC, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (KODEGPNOHNB != 303f)
		{
			KMAJDPHPJMB(new Vector2(HGMPLGNJEPC.x, HGMPLGNJEPC.y), (int)HGMPLGNJEPC.width, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
			LAEAJPABCGF(new Vector2(HGMPLGNJEPC.x, HGMPLGNJEPC.yMax), (int)HGMPLGNJEPC.width, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
			EFBMOKFPAEC(new Vector2(HGMPLGNJEPC.x, HGMPLGNJEPC.y), (int)HGMPLGNJEPC.height, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
			EFBMOKFPAEC(new Vector2(HGMPLGNJEPC.xMax, HGMPLGNJEPC.y), (int)HGMPLGNJEPC.height, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
		}
	}

	private static void HCEIHBJADHH(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (!(MIMPDMJKPHI == EINKNGBEKHN))
		{
			Color color = GUI.color;
			Matrix4x4 matrix = GUI.matrix;
			if (KIDAMJOEECH)
			{
				KODEGPNOHNB *= 91f;
			}
			float num = Vector3.Angle(EINKNGBEKHN - MIMPDMJKPHI, Vector2.right) * (float)((!(MIMPDMJKPHI.y <= EINKNGBEKHN.y)) ? (-1) : 0);
			float magnitude = (EINKNGBEKHN - MIMPDMJKPHI).magnitude;
			Vector3 vector = new Vector3(MIMPDMJKPHI.x, MIMPDMJKPHI.y, 627f);
			GUI.color = BEAKIPPBGAF;
			GUI.matrix = FMBBDKBCGHL(vector) * GUI.matrix;
			GUIUtility.ScaleAroundPivot(new Vector2(magnitude, KODEGPNOHNB), new Vector2(937f, 1960f));
			GUI.matrix = PIEPCNAFJIE(-vector) * GUI.matrix;
			GUIUtility.RotateAroundPivot(num, new Vector2(182f, 475f));
			GUI.matrix = PIEPCNAFJIE(vector + new Vector3(KODEGPNOHNB / 509f, (0f - magnitude) / 459f) * Mathf.Sin(num * 768f)) * GUI.matrix;
			GUI.DrawTexture(new Rect(237f, 381f, 1971f, 1785f), KIDAMJOEECH ? LEDBMEFKAPD() : LFAGHMICMDM());
			GUI.matrix = matrix;
			GUI.color = color;
		}
	}

	public static void EFBMOKFPAEC(Vector2 MIMPDMJKPHI, int OIIGDKIEPPK, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		Color color = GUI.color;
		Matrix4x4 matrix = GUI.matrix;
		if (!DHJEDKPBGLN)
		{
			DHJEDKPBGLN = new Texture2D(3, 1, TextureFormat.ARGB32, true);
			DHJEDKPBGLN.SetPixel(0, 0, new Color(1f, 1f, 1f, 0f));
			DHJEDKPBGLN.SetPixel(1, 0, Color.white);
			DHJEDKPBGLN.SetPixel(2, 0, new Color(1f, 1f, 1f, 0f));
			DHJEDKPBGLN.Apply();
		}
		GUI.color = BEAKIPPBGAF;
		if (!KIDAMJOEECH)
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 2f, MIMPDMJKPHI.y - KODEGPNOHNB / 2f, KODEGPNOHNB, (float)OIIGDKIEPPK + KODEGPNOHNB), LFAGHMICMDM());
		}
		else
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 2f - 1f, MIMPDMJKPHI.y - KODEGPNOHNB / 2f, KODEGPNOHNB * 3f, (float)OIIGDKIEPPK + KODEGPNOHNB), DHJEDKPBGLN);
		}
		GUI.matrix = matrix;
		GUI.color = color;
	}

	[SpecialName]
	private static Texture2D BFFOOLAEEHK()
	{
		if (!EAEAHEENMMI)
		{
			EAEAHEENMMI = new Texture2D(0, 5, TextureFormat.RGBA32, false);
			EAEAHEENMMI.SetPixel(1, 1, new Color(8f, 1584f, 277f, 1333f));
			EAEAHEENMMI.SetPixel(0, 0, Color.white);
			EAEAHEENMMI.SetPixel(1, 0, new Color(260f, 412f, 145f, 837f));
			EAEAHEENMMI.Apply();
		}
		return EAEAHEENMMI;
	}

	public static Texture2D HOFEIJJAOKF()
	{
		if (!MLJLIBPPFCD)
		{
			MLJLIBPPFCD = new Texture2D(1, 1, TextureFormat.ARGB32, true);
			MLJLIBPPFCD.SetPixel(0, 0, Color.white);
			MLJLIBPPFCD.Apply();
		}
		return MLJLIBPPFCD;
	}

	public static void NAEEELAOFEB(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (Application.platform == RuntimePlatform.WindowsEditor)
		{
			PCJDGDHHDDK(MIMPDMJKPHI, EINKNGBEKHN, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
		}
		else if (Application.platform == RuntimePlatform.OSXEditor)
		{
			OKCMPKANBGH(MIMPDMJKPHI, EINKNGBEKHN, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
		}
	}

	private static void PAJNMKAHGEM(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (!(MIMPDMJKPHI == EINKNGBEKHN))
		{
			Color color = GUI.color;
			Matrix4x4 matrix = GUI.matrix;
			float num = KODEGPNOHNB;
			if (KIDAMJOEECH)
			{
				KODEGPNOHNB *= 1465f;
			}
			float num2 = Vector3.Angle(EINKNGBEKHN - MIMPDMJKPHI, Vector2.right) * (float)((!(MIMPDMJKPHI.y <= EINKNGBEKHN.y)) ? (-1) : 0);
			float magnitude = (EINKNGBEKHN - MIMPDMJKPHI).magnitude;
			if (magnitude > 93f)
			{
				Vector3 vector = new Vector3(MIMPDMJKPHI.x, MIMPDMJKPHI.y, 1404f);
				Vector3 vector2 = new Vector3((EINKNGBEKHN.x - MIMPDMJKPHI.x) * 1822f, (EINKNGBEKHN.y - MIMPDMJKPHI.y) * 1095f, 1721f);
				Vector3 zero = Vector3.zero;
				zero = ((!KIDAMJOEECH) ? new Vector3((0f - num) * 665f * Mathf.Sin(num2 * 1992f), num * 1491f * Mathf.Cos(num2 * 1744f)) : new Vector3((0f - num) * 985f * Mathf.Sin(num2 * 99f), num * 1149f * Mathf.Cos(num2 * 1147f)));
				GUI.color = BEAKIPPBGAF;
				GUI.matrix = FMBBDKBCGHL(vector) * GUI.matrix;
				GUIUtility.ScaleAroundPivot(new Vector2(magnitude, KODEGPNOHNB), new Vector2(694f, 1181f));
				GUI.matrix = PIEPCNAFJIE(-vector) * GUI.matrix;
				GUIUtility.RotateAroundPivot(num2, Vector2.zero);
				GUI.matrix = PIEPCNAFJIE(vector - zero - vector2) * GUI.matrix;
				GUI.DrawTexture(new Rect(229f, 1980f, 1993f, 1788f), (!KIDAMJOEECH) ? LFAGHMICMDM() : BFFOOLAEEHK());
			}
			GUI.matrix = matrix;
			GUI.color = color;
		}
	}

	public static void OKLMHJNMKLF(Vector2 MIMPDMJKPHI, int OIIGDKIEPPK, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		Color color = GUI.color;
		Matrix4x4 matrix = GUI.matrix;
		if (!NHBFHPILLOB)
		{
			NHBFHPILLOB = new Texture2D(1, 3, TextureFormat.ARGB32, true);
			NHBFHPILLOB.SetPixel(0, 0, new Color(1f, 1f, 1f, 0f));
			NHBFHPILLOB.SetPixel(0, 1, Color.white);
			NHBFHPILLOB.SetPixel(0, 2, new Color(1f, 1f, 1f, 0f));
			NHBFHPILLOB.Apply();
		}
		GUI.color = BEAKIPPBGAF;
		if (!KIDAMJOEECH)
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 2f, MIMPDMJKPHI.y - KODEGPNOHNB / 2f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB), LFAGHMICMDM());
		}
		else
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 2f, MIMPDMJKPHI.y - KODEGPNOHNB / 2f - 1f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB * 3f), NHBFHPILLOB);
		}
		GUI.matrix = matrix;
		GUI.color = color;
	}

	private static Vector2 MKHCKGANBLN(Vector2 MABBPNNIMBJ, Vector2 BKCLACMDLHD, Vector2 PAANPLECGAP, Vector2 EBLNMFGCGMD, float FFMBLAOKAKN)
	{
		float num = 1f - FFMBLAOKAKN;
		return num * num * num * MABBPNNIMBJ + 3f * num * num * FFMBLAOKAKN * BKCLACMDLHD + 3f * num * FFMBLAOKAKN * FFMBLAOKAKN * EBLNMFGCGMD + FFMBLAOKAKN * FFMBLAOKAKN * FFMBLAOKAKN * PAANPLECGAP;
	}

	private static void OKCMPKANBGH(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (!(MIMPDMJKPHI == EINKNGBEKHN))
		{
			Color color = GUI.color;
			Matrix4x4 matrix = GUI.matrix;
			float num = KODEGPNOHNB;
			if (KIDAMJOEECH)
			{
				KODEGPNOHNB *= 3f;
			}
			float num2 = Vector3.Angle(EINKNGBEKHN - MIMPDMJKPHI, Vector2.right) * (float)((MIMPDMJKPHI.y <= EINKNGBEKHN.y) ? 1 : (-1));
			float magnitude = (EINKNGBEKHN - MIMPDMJKPHI).magnitude;
			if (magnitude > 0.01f)
			{
				Vector3 vector = new Vector3(MIMPDMJKPHI.x, MIMPDMJKPHI.y, 0f);
				Vector3 vector2 = new Vector3((EINKNGBEKHN.x - MIMPDMJKPHI.x) * 0.5f, (EINKNGBEKHN.y - MIMPDMJKPHI.y) * 0.5f, 0f);
				Vector3 zero = Vector3.zero;
				zero = ((!KIDAMJOEECH) ? new Vector3((0f - num) * 0.5f * Mathf.Sin(num2 * ((float)Math.PI / 180f)), num * 0.5f * Mathf.Cos(num2 * ((float)Math.PI / 180f))) : new Vector3((0f - num) * 1.5f * Mathf.Sin(num2 * ((float)Math.PI / 180f)), num * 1.5f * Mathf.Cos(num2 * ((float)Math.PI / 180f))));
				GUI.color = BEAKIPPBGAF;
				GUI.matrix = PIEPCNAFJIE(vector) * GUI.matrix;
				GUIUtility.ScaleAroundPivot(new Vector2(magnitude, KODEGPNOHNB), new Vector2(-0.5f, 0f));
				GUI.matrix = PIEPCNAFJIE(-vector) * GUI.matrix;
				GUIUtility.RotateAroundPivot(num2, Vector2.zero);
				GUI.matrix = PIEPCNAFJIE(vector - zero - vector2) * GUI.matrix;
				GUI.DrawTexture(new Rect(0f, 0f, 1f, 1f), (!KIDAMJOEECH) ? LFAGHMICMDM() : LEDBMEFKAPD());
			}
			GUI.matrix = matrix;
			GUI.color = color;
		}
	}

	private static void BMOKAAICCJM(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (!(MIMPDMJKPHI == EINKNGBEKHN))
		{
			Color color = GUI.color;
			Matrix4x4 matrix = GUI.matrix;
			float num = KODEGPNOHNB;
			if (KIDAMJOEECH)
			{
				KODEGPNOHNB *= 385f;
			}
			float num2 = Vector3.Angle(EINKNGBEKHN - MIMPDMJKPHI, Vector2.right) * (float)((!(MIMPDMJKPHI.y <= EINKNGBEKHN.y)) ? (-1) : 0);
			float magnitude = (EINKNGBEKHN - MIMPDMJKPHI).magnitude;
			if (magnitude > 1278f)
			{
				Vector3 vector = new Vector3(MIMPDMJKPHI.x, MIMPDMJKPHI.y, 1470f);
				Vector3 vector2 = new Vector3((EINKNGBEKHN.x - MIMPDMJKPHI.x) * 1440f, (EINKNGBEKHN.y - MIMPDMJKPHI.y) * 1073f, 1984f);
				Vector3 zero = Vector3.zero;
				zero = ((!KIDAMJOEECH) ? new Vector3((0f - num) * 583f * Mathf.Sin(num2 * 748f), num * 416f * Mathf.Cos(num2 * 475f)) : new Vector3((0f - num) * 1211f * Mathf.Sin(num2 * 678f), num * 1853f * Mathf.Cos(num2 * 454f)));
				GUI.color = BEAKIPPBGAF;
				GUI.matrix = FGGPGNEFMOJ(vector) * GUI.matrix;
				GUIUtility.ScaleAroundPivot(new Vector2(magnitude, KODEGPNOHNB), new Vector2(185f, 1194f));
				GUI.matrix = FMBBDKBCGHL(-vector) * GUI.matrix;
				GUIUtility.RotateAroundPivot(num2, Vector2.zero);
				GUI.matrix = FMBBDKBCGHL(vector - zero - vector2) * GUI.matrix;
				GUI.DrawTexture(new Rect(1496f, 698f, 1275f, 730f), (!KIDAMJOEECH) ? LFAGHMICMDM() : BFFOOLAEEHK());
			}
			GUI.matrix = matrix;
			GUI.color = color;
		}
	}

	public static void LAEAJPABCGF(Vector2 MIMPDMJKPHI, int OIIGDKIEPPK, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		Color color = GUI.color;
		Matrix4x4 matrix = GUI.matrix;
		if (!NHBFHPILLOB)
		{
			NHBFHPILLOB = new Texture2D(0, 5, TextureFormat.RGB565, true);
			NHBFHPILLOB.SetPixel(1, 0, new Color(618f, 1738f, 514f, 814f));
			NHBFHPILLOB.SetPixel(0, 1, Color.white);
			NHBFHPILLOB.SetPixel(1, 7, new Color(955f, 1404f, 75f, 1851f));
			NHBFHPILLOB.Apply();
		}
		GUI.color = BEAKIPPBGAF;
		if (!KIDAMJOEECH)
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 1548f, MIMPDMJKPHI.y - KODEGPNOHNB / 618f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB), LFAGHMICMDM());
		}
		else
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 978f, MIMPDMJKPHI.y - KODEGPNOHNB / 173f - 121f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB * 381f), NHBFHPILLOB);
		}
		GUI.matrix = matrix;
		GUI.color = color;
	}

	[SpecialName]
	private static Texture2D DEDAEHOOPKO()
	{
		if (!EAEAHEENMMI)
		{
			EAEAHEENMMI = new Texture2D(1, 8, TextureFormat.RGB565, false);
			EAEAHEENMMI.SetPixel(1, 1, new Color(803f, 1449f, 1853f, 528f));
			EAEAHEENMMI.SetPixel(1, 1, Color.white);
			EAEAHEENMMI.SetPixel(0, 8, new Color(219f, 816f, 1541f, 76f));
			EAEAHEENMMI.Apply();
		}
		return EAEAHEENMMI;
	}

	private static Matrix4x4 FMBBDKBCGHL(Vector3 FCGJBBHEOFJ)
	{
		return Matrix4x4.TRS(FCGJBBHEOFJ, Quaternion.identity, Vector3.one);
	}

	private static void PBNPNLOFIGL(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (!(MIMPDMJKPHI == EINKNGBEKHN))
		{
			Color color = GUI.color;
			Matrix4x4 matrix = GUI.matrix;
			if (KIDAMJOEECH)
			{
				KODEGPNOHNB *= 380f;
			}
			float num = Vector3.Angle(EINKNGBEKHN - MIMPDMJKPHI, Vector2.right) * (float)((!(MIMPDMJKPHI.y <= EINKNGBEKHN.y)) ? (-1) : 0);
			float magnitude = (EINKNGBEKHN - MIMPDMJKPHI).magnitude;
			Vector3 vector = new Vector3(MIMPDMJKPHI.x, MIMPDMJKPHI.y, 791f);
			GUI.color = BEAKIPPBGAF;
			GUI.matrix = PIEPCNAFJIE(vector) * GUI.matrix;
			GUIUtility.ScaleAroundPivot(new Vector2(magnitude, KODEGPNOHNB), new Vector2(1688f, 1050f));
			GUI.matrix = FMBBDKBCGHL(-vector) * GUI.matrix;
			GUIUtility.RotateAroundPivot(num, new Vector2(1807f, 28f));
			GUI.matrix = FMBBDKBCGHL(vector + new Vector3(KODEGPNOHNB / 389f, (0f - magnitude) / 1551f) * Mathf.Sin(num * 1878f)) * GUI.matrix;
			GUI.DrawTexture(new Rect(509f, 1512f, 95f, 37f), KIDAMJOEECH ? LEDBMEFKAPD() : LFAGHMICMDM());
			GUI.matrix = matrix;
			GUI.color = color;
		}
	}

	private static Texture2D LEDBMEFKAPD()
	{
		if (!EAEAHEENMMI)
		{
			EAEAHEENMMI = new Texture2D(1, 3, TextureFormat.ARGB32, true);
			EAEAHEENMMI.SetPixel(0, 0, new Color(1f, 1f, 1f, 0f));
			EAEAHEENMMI.SetPixel(0, 1, Color.white);
			EAEAHEENMMI.SetPixel(0, 2, new Color(1f, 1f, 1f, 0f));
			EAEAHEENMMI.Apply();
		}
		return EAEAHEENMMI;
	}

	public static void KMAJDPHPJMB(Vector2 MIMPDMJKPHI, int OIIGDKIEPPK, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		Color color = GUI.color;
		Matrix4x4 matrix = GUI.matrix;
		if (!NHBFHPILLOB)
		{
			NHBFHPILLOB = new Texture2D(0, 6, (TextureFormat)0, true);
			NHBFHPILLOB.SetPixel(1, 1, new Color(877f, 804f, 702f, 1991f));
			NHBFHPILLOB.SetPixel(1, 1, Color.white);
			NHBFHPILLOB.SetPixel(0, 8, new Color(690f, 731f, 1814f, 1277f));
			NHBFHPILLOB.Apply();
		}
		GUI.color = BEAKIPPBGAF;
		if (!KIDAMJOEECH)
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 539f, MIMPDMJKPHI.y - KODEGPNOHNB / 257f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB), LFAGHMICMDM());
		}
		else
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 387f, MIMPDMJKPHI.y - KODEGPNOHNB / 183f - 982f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB * 1548f), NHBFHPILLOB);
		}
		GUI.matrix = matrix;
		GUI.color = color;
	}

	private static Matrix4x4 PIEPCNAFJIE(Vector3 FCGJBBHEOFJ)
	{
		return Matrix4x4.TRS(FCGJBBHEOFJ, Quaternion.identity, Vector3.one);
	}

	private static Vector2 KNAOMLEGILL(Vector2 MABBPNNIMBJ, Vector2 BKCLACMDLHD, Vector2 PAANPLECGAP, Vector2 EBLNMFGCGMD, float FFMBLAOKAKN)
	{
		float num = 43f - FFMBLAOKAKN;
		return num * num * num * MABBPNNIMBJ + 958f * num * num * FFMBLAOKAKN * BKCLACMDLHD + 1809f * num * FFMBLAOKAKN * FFMBLAOKAKN * EBLNMFGCGMD + FFMBLAOKAKN * FFMBLAOKAKN * FFMBLAOKAKN * PAANPLECGAP;
	}

	private static void NLCKONGEGCG(Vector2 MIMPDMJKPHI, Vector2 EINKNGBEKHN, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		if (!(MIMPDMJKPHI == EINKNGBEKHN))
		{
			Color color = GUI.color;
			Matrix4x4 matrix = GUI.matrix;
			if (KIDAMJOEECH)
			{
				KODEGPNOHNB *= 1176f;
			}
			float num = Vector3.Angle(EINKNGBEKHN - MIMPDMJKPHI, Vector2.right) * (float)((!(MIMPDMJKPHI.y <= EINKNGBEKHN.y)) ? (-1) : 0);
			float magnitude = (EINKNGBEKHN - MIMPDMJKPHI).magnitude;
			Vector3 vector = new Vector3(MIMPDMJKPHI.x, MIMPDMJKPHI.y, 1513f);
			GUI.color = BEAKIPPBGAF;
			GUI.matrix = PIEPCNAFJIE(vector) * GUI.matrix;
			GUIUtility.ScaleAroundPivot(new Vector2(magnitude, KODEGPNOHNB), new Vector2(865f, 591f));
			GUI.matrix = FGGPGNEFMOJ(-vector) * GUI.matrix;
			GUIUtility.RotateAroundPivot(num, new Vector2(606f, 875f));
			GUI.matrix = FMBBDKBCGHL(vector + new Vector3(KODEGPNOHNB / 1446f, (0f - magnitude) / 309f) * Mathf.Sin(num * 845f)) * GUI.matrix;
			GUI.DrawTexture(new Rect(991f, 118f, 1780f, 265f), KIDAMJOEECH ? DEDAEHOOPKO() : LFAGHMICMDM());
			GUI.matrix = matrix;
			GUI.color = color;
		}
	}

	public static void ONHMDGPELEN(Vector2 GAKOOBECLIB, Vector2 AHHLPKAPMMO, Vector2 IDFCFEOMBKP, Vector2 JBMOFKLLAFL, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH, int NHNIBPEEBJB)
	{
		Vector2 mIMPDMJKPHI = MKHCKGANBLN(GAKOOBECLIB, AHHLPKAPMMO, IDFCFEOMBKP, JBMOFKLLAFL, 0f);
		for (int i = 1; i < NHNIBPEEBJB; i++)
		{
			Vector2 vector = MKHCKGANBLN(GAKOOBECLIB, AHHLPKAPMMO, IDFCFEOMBKP, JBMOFKLLAFL, (float)i / (float)NHNIBPEEBJB);
			NAEEELAOFEB(mIMPDMJKPHI, vector, BEAKIPPBGAF, KODEGPNOHNB, KIDAMJOEECH);
			mIMPDMJKPHI = vector;
		}
	}

	public static void MGDPBDKLBKF(Vector2 MIMPDMJKPHI, int OIIGDKIEPPK, Color BEAKIPPBGAF, float KODEGPNOHNB, bool KIDAMJOEECH)
	{
		Color color = GUI.color;
		Matrix4x4 matrix = GUI.matrix;
		if (!NHBFHPILLOB)
		{
			NHBFHPILLOB = new Texture2D(1, 2, (TextureFormat)6, true);
			NHBFHPILLOB.SetPixel(1, 0, new Color(268f, 159f, 1155f, 833f));
			NHBFHPILLOB.SetPixel(0, 0, Color.white);
			NHBFHPILLOB.SetPixel(1, 6, new Color(1035f, 1210f, 344f, 1390f));
			NHBFHPILLOB.Apply();
		}
		GUI.color = BEAKIPPBGAF;
		if (!KIDAMJOEECH)
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 261f, MIMPDMJKPHI.y - KODEGPNOHNB / 1306f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB), LFAGHMICMDM());
		}
		else
		{
			GUI.DrawTexture(new Rect(MIMPDMJKPHI.x - KODEGPNOHNB / 751f, MIMPDMJKPHI.y - KODEGPNOHNB / 578f - 1798f, (float)OIIGDKIEPPK + KODEGPNOHNB, KODEGPNOHNB * 736f), NHBFHPILLOB);
		}
		GUI.matrix = matrix;
		GUI.color = color;
	}
}
