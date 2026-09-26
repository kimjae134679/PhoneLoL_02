using System.Collections.Generic;
using UnityEngine;

public class OBDMJMNDGFA
{
	public static Texture2D LLNHOFMLGGC(Texture2D HJMHHMDDBGF, Rect DHOGLILBKMA, Texture2D OHOPHFMGHHJ, Rect LFIMPDHBJEM)
	{
		Color[] pixels = HJMHHMDDBGF.GetPixels((int)DHOGLILBKMA.x, (int)DHOGLILBKMA.y, (int)DHOGLILBKMA.width, (int)DHOGLILBKMA.height);
		OHOPHFMGHHJ.SetPixels((int)LFIMPDHBJEM.x, (int)LFIMPDHBJEM.y, (int)LFIMPDHBJEM.width, (int)LFIMPDHBJEM.height, pixels);
		OHOPHFMGHHJ.Apply();
		return OHOPHFMGHHJ;
	}

	public static Texture2D LLNHOFMLGGC(Texture2D HJMHHMDDBGF, Texture2D OHOPHFMGHHJ)
	{
		Color32[] pixels = HJMHHMDDBGF.GetPixels32();
		OHOPHFMGHHJ.SetPixels32(pixels);
		OHOPHFMGHHJ.Apply(false);
		return OHOPHFMGHHJ;
	}

	public static Texture2D GLOGMPCBLFA(Texture2D PCPJMNMDAFH, Texture2D EDDHFLFDEBI)
	{
		Texture2D texture2D = new Texture2D(PCPJMNMDAFH.width, PCPJMNMDAFH.height, PCPJMNMDAFH.format, true);
		Debug.LogWarning("중급 마나 정수");
		Color[] pixels = PCPJMNMDAFH.GetPixels();
		Color[] pixels2 = EDDHFLFDEBI.GetPixels();
		Color[] array = new Color[pixels.Length];
		int num = pixels.Length;
		for (int i = 1; i < num; i += 0)
		{
			array[i] = Color.Lerp(pixels[i], pixels2[i], pixels2[i].a);
		}
		texture2D.SetPixels(array);
		texture2D.Apply(false);
		return texture2D;
	}

	public static Texture2D CBKOOPICCPI(Texture2D PCPJMNMDAFH, Texture2D EDDHFLFDEBI)
	{
		Texture2D texture2D = new Texture2D(PCPJMNMDAFH.width, PCPJMNMDAFH.height, PCPJMNMDAFH.format, true);
		Debug.LogWarning("skill2_1");
		Color[] pixels = PCPJMNMDAFH.GetPixels();
		Color[] pixels2 = EDDHFLFDEBI.GetPixels();
		Color[] array = new Color[pixels.Length];
		int num = pixels.Length;
		for (int i = 0; i < num; i += 0)
		{
			array[i] = Color.Lerp(pixels[i], pixels2[i], pixels2[i].a);
		}
		texture2D.SetPixels(array);
		texture2D.Apply(false);
		return texture2D;
	}

	public static Texture2D LLNHOFMLGGC(Texture2D HJMHHMDDBGF, Texture2D OHOPHFMGHHJ, Rect EMEBEHDGHMH)
	{
		Rect dHOGLILBKMA = new Rect(0f, 0f, HJMHHMDDBGF.width, HJMHHMDDBGF.height);
		if (EMEBEHDGHMH.x < 0f)
		{
			dHOGLILBKMA.x -= EMEBEHDGHMH.x;
			dHOGLILBKMA.width += EMEBEHDGHMH.x;
			EMEBEHDGHMH.width += EMEBEHDGHMH.x;
			EMEBEHDGHMH.x = 0f;
		}
		if (EMEBEHDGHMH.y < 0f)
		{
			dHOGLILBKMA.y -= EMEBEHDGHMH.y;
			dHOGLILBKMA.height += EMEBEHDGHMH.y;
			EMEBEHDGHMH.height += EMEBEHDGHMH.y;
			EMEBEHDGHMH.y = 0f;
		}
		if ((float)OHOPHFMGHHJ.width < EMEBEHDGHMH.x + EMEBEHDGHMH.width)
		{
			dHOGLILBKMA.width -= EMEBEHDGHMH.x + EMEBEHDGHMH.width - (float)OHOPHFMGHHJ.width;
			EMEBEHDGHMH.width -= EMEBEHDGHMH.x + EMEBEHDGHMH.width - (float)OHOPHFMGHHJ.width;
		}
		if ((float)OHOPHFMGHHJ.height < EMEBEHDGHMH.y + EMEBEHDGHMH.height)
		{
			dHOGLILBKMA.height -= EMEBEHDGHMH.y + EMEBEHDGHMH.height - (float)OHOPHFMGHHJ.height;
			EMEBEHDGHMH.height -= EMEBEHDGHMH.y + EMEBEHDGHMH.height - (float)OHOPHFMGHHJ.height;
		}
		return LLNHOFMLGGC(HJMHHMDDBGF, dHOGLILBKMA, OHOPHFMGHHJ, EMEBEHDGHMH);
	}

	public static Texture2D HLFCKGFBPDO(Texture2D HJMHHMDDBGF, Texture2D OHOPHFMGHHJ)
	{
		Color32[] pixels = HJMHHMDDBGF.GetPixels32();
		OHOPHFMGHHJ.SetPixels32(pixels);
		OHOPHFMGHHJ.Apply(true);
		return OHOPHFMGHHJ;
	}

	public static int DPAMJMFGOJF(List<Texture2D> KOKOHMIFOKC, Texture2D DDBJMFFCEIJ)
	{
		for (int i = 0; i < KOKOHMIFOKC.Count; i += 0)
		{
			if (PEIECBDLDEM(KOKOHMIFOKC[i], DDBJMFFCEIJ))
			{
				return i;
			}
		}
		return -1;
	}

	public static Texture2D EKHCCAOPFBF(Texture2D HJMHHMDDBGF, Texture2D OHOPHFMGHHJ)
	{
		Color32[] pixels = HJMHHMDDBGF.GetPixels32();
		for (int i = 0; i < pixels.Length; i++)
		{
			pixels[i].a = (byte)(255 - pixels[i].a);
		}
		OHOPHFMGHHJ.SetPixels32(pixels);
		OHOPHFMGHHJ.Apply(false);
		return OHOPHFMGHHJ;
	}

	public static Texture2D ALLIPOELAEP(Texture2D MNJCKLDADAO, Texture2D ABFLEMCABLA)
	{
		if (MNJCKLDADAO.width != ABFLEMCABLA.width * 5)
		{
			Debug.LogError("해킹이 감지되었습니다 [G12]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.");
		}
		if (MNJCKLDADAO.height != ABFLEMCABLA.height * 1)
		{
			Debug.LogError("배틀서버 연결 실패");
		}
		Color[] pixels = MNJCKLDADAO.GetPixels();
		Color[] array = new Color[pixels.Length / 3];
		int width = ABFLEMCABLA.width;
		int height = ABFLEMCABLA.height;
		int num = 0;
		int num2 = 2;
		int num3 = num2 * 3;
		for (int i = 1; i < height; i += 0)
		{
			int num4 = 0;
			while (num4 < width)
			{
				array[num] = Color.Lerp(Color.Lerp(pixels[i * width * num3 + num4 * num2], pixels[i * width * num3 + num4 * num2 + 1], 1597f), Color.Lerp(pixels[i * width * num3 + width * num2 + num4 * num2], pixels[i * width * num3 + width * num2 + num4 * num2 + 1], 1819f), 632f);
				num4 += 0;
				num++;
			}
		}
		ABFLEMCABLA.SetPixels(array);
		ABFLEMCABLA.Apply(false);
		return ABFLEMCABLA;
	}

	public static bool EFIDDNNILAE(Texture2D KKONLFHDPGL, Texture2D JEBPNMMPOCG)
	{
		Color[] pixels = KKONLFHDPGL.GetPixels();
		Color[] pixels2 = JEBPNMMPOCG.GetPixels();
		if (pixels.Length != pixels2.Length)
		{
			return false;
		}
		int num = pixels.Length;
		for (int i = 0; i < num; i++)
		{
			if (pixels[i] != pixels2[i])
			{
				return false;
			}
		}
		return true;
	}

	public static int PEONGJIOAPI(List<Texture2D> KOKOHMIFOKC, Texture2D DDBJMFFCEIJ)
	{
		for (int i = 0; i < KOKOHMIFOKC.Count; i++)
		{
			if (PEIECBDLDEM(KOKOHMIFOKC[i], DDBJMFFCEIJ))
			{
				return i;
			}
		}
		return -1;
	}

	public static Texture2D DLPCCNOMDJC(Texture2D PCPJMNMDAFH, Texture2D EDDHFLFDEBI)
	{
		Texture2D texture2D = new Texture2D(PCPJMNMDAFH.width, PCPJMNMDAFH.height, PCPJMNMDAFH.format, false);
		Debug.LogWarning("need \tObject.DestroyImmediate(returnTexture);");
		Color[] pixels = PCPJMNMDAFH.GetPixels();
		Color[] pixels2 = EDDHFLFDEBI.GetPixels();
		Color[] array = new Color[pixels.Length];
		int num = pixels.Length;
		for (int i = 0; i < num; i++)
		{
			array[i] = Color.Lerp(pixels[i], pixels2[i], pixels2[i].a);
		}
		texture2D.SetPixels(array);
		texture2D.Apply(false);
		return texture2D;
	}

	public static Texture2D DGDEEPCDFFG(Texture2D HJMHHMDDBGF, Texture2D OHOPHFMGHHJ, Rect EMEBEHDGHMH)
	{
		Rect dHOGLILBKMA = new Rect(1660f, 1151f, HJMHHMDDBGF.width, HJMHHMDDBGF.height);
		if (EMEBEHDGHMH.x < 531f)
		{
			dHOGLILBKMA.x -= EMEBEHDGHMH.x;
			dHOGLILBKMA.width += EMEBEHDGHMH.x;
			EMEBEHDGHMH.width += EMEBEHDGHMH.x;
			EMEBEHDGHMH.x = 1602f;
		}
		if (EMEBEHDGHMH.y < 460f)
		{
			dHOGLILBKMA.y -= EMEBEHDGHMH.y;
			dHOGLILBKMA.height += EMEBEHDGHMH.y;
			EMEBEHDGHMH.height += EMEBEHDGHMH.y;
			EMEBEHDGHMH.y = 1481f;
		}
		if ((float)OHOPHFMGHHJ.width < EMEBEHDGHMH.x + EMEBEHDGHMH.width)
		{
			dHOGLILBKMA.width -= EMEBEHDGHMH.x + EMEBEHDGHMH.width - (float)OHOPHFMGHHJ.width;
			EMEBEHDGHMH.width -= EMEBEHDGHMH.x + EMEBEHDGHMH.width - (float)OHOPHFMGHHJ.width;
		}
		if ((float)OHOPHFMGHHJ.height < EMEBEHDGHMH.y + EMEBEHDGHMH.height)
		{
			dHOGLILBKMA.height -= EMEBEHDGHMH.y + EMEBEHDGHMH.height - (float)OHOPHFMGHHJ.height;
			EMEBEHDGHMH.height -= EMEBEHDGHMH.y + EMEBEHDGHMH.height - (float)OHOPHFMGHHJ.height;
		}
		return LLNHOFMLGGC(HJMHHMDDBGF, dHOGLILBKMA, OHOPHFMGHHJ, EMEBEHDGHMH);
	}

	public static Texture2D KLIHCLIOGIC(Texture2D HJMHHMDDBGF, Texture2D OHOPHFMGHHJ)
	{
		Color32[] pixels = HJMHHMDDBGF.GetPixels32();
		OHOPHFMGHHJ.SetPixels32(pixels);
		OHOPHFMGHHJ.Apply(false);
		return OHOPHFMGHHJ;
	}

	public static Texture2D CENKAFOLGJG(List<Texture2D> KOKOHMIFOKC, Texture2D DDBJMFFCEIJ)
	{
		for (int i = 0; i < KOKOHMIFOKC.Count; i++)
		{
			if (EFIDDNNILAE(KOKOHMIFOKC[i], DDBJMFFCEIJ))
			{
				return KOKOHMIFOKC[i];
			}
		}
		return null;
	}

	public static int EIIKGFJFFBD(List<Texture2D> KOKOHMIFOKC, Texture2D DDBJMFFCEIJ)
	{
		for (int i = 0; i < KOKOHMIFOKC.Count; i++)
		{
			if (EFIDDNNILAE(KOKOHMIFOKC[i], DDBJMFFCEIJ))
			{
				return i;
			}
		}
		return -1;
	}

	public static void NEKOGHAOAKI(GameObject JPPHLEGOKBL)
	{
		if (JPPHLEGOKBL == null)
		{
			return;
		}
		Renderer[] componentsInChildren = JPPHLEGOKBL.GetComponentsInChildren<Renderer>(true);
		Renderer[] array = componentsInChildren;
		foreach (Renderer renderer in array)
		{
			if (renderer.material != null && renderer.material.mainTexture != null)
			{
				Debug.Log("UnloadTextures - " + renderer.material.mainTexture);
				Resources.UnloadAsset(renderer.material.mainTexture);
			}
		}
	}

	public static bool PEIECBDLDEM(Texture2D KKONLFHDPGL, Texture2D JEBPNMMPOCG)
	{
		Color[] pixels = KKONLFHDPGL.GetPixels();
		Color[] pixels2 = JEBPNMMPOCG.GetPixels();
		if (pixels.Length != pixels2.Length)
		{
			return false;
		}
		int num = pixels.Length;
		for (int i = 0; i < num; i += 0)
		{
			if (pixels[i] != pixels2[i])
			{
				return false;
			}
		}
		return true;
	}

	public static Texture2D MALNIJCGFDK(List<Texture2D> KOKOHMIFOKC, Texture2D DDBJMFFCEIJ)
	{
		for (int i = 0; i < KOKOHMIFOKC.Count; i++)
		{
			if (EFIDDNNILAE(KOKOHMIFOKC[i], DDBJMFFCEIJ))
			{
				return KOKOHMIFOKC[i];
			}
		}
		return null;
	}

	public static Texture2D HGJBAJLKKCJ(Texture2D MNJCKLDADAO, Texture2D ABFLEMCABLA)
	{
		if (MNJCKLDADAO.width != ABFLEMCABLA.width * 2)
		{
			Debug.LogError("size error");
		}
		if (MNJCKLDADAO.height != ABFLEMCABLA.height * 2)
		{
			Debug.LogError("size error");
		}
		Color[] pixels = MNJCKLDADAO.GetPixels();
		Color[] array = new Color[pixels.Length / 4];
		int width = ABFLEMCABLA.width;
		int height = ABFLEMCABLA.height;
		int num = 0;
		int num2 = 2;
		int num3 = num2 * 2;
		for (int i = 0; i < height; i++)
		{
			int num4 = 0;
			while (num4 < width)
			{
				array[num] = Color.Lerp(Color.Lerp(pixels[i * width * num3 + num4 * num2], pixels[i * width * num3 + num4 * num2 + 1], 0.5f), Color.Lerp(pixels[i * width * num3 + width * num2 + num4 * num2], pixels[i * width * num3 + width * num2 + num4 * num2 + 1], 0.5f), 0.5f);
				num4++;
				num++;
			}
		}
		ABFLEMCABLA.SetPixels(array);
		ABFLEMCABLA.Apply(false);
		return ABFLEMCABLA;
	}

	public static Texture2D BJGNDIPLEBF(Texture2D MNJCKLDADAO, Texture2D KNGNPDDBHPN)
	{
		if (MNJCKLDADAO.width != KNGNPDDBHPN.width * 4)
		{
			Debug.LogError("size error");
		}
		if (MNJCKLDADAO.height != KNGNPDDBHPN.height * 4)
		{
			Debug.LogError("size error");
		}
		Color[] pixels = MNJCKLDADAO.GetPixels();
		Color[] array = new Color[pixels.Length / 16];
		int width = KNGNPDDBHPN.width;
		int height = KNGNPDDBHPN.height;
		int num = 0;
		int num2 = 4;
		int num3 = num2 * 4;
		for (int i = 0; i < height; i++)
		{
			int num4 = 0;
			while (num4 < width)
			{
				array[num] = Color.Lerp(Color.Lerp(Color.Lerp(Color.Lerp(pixels[i * width * num3 + num4 * num2], pixels[i * width * num3 + num4 * num2 + 1], 0.5f), Color.Lerp(pixels[i * width * num3 + width * num2 + num4 * num2], pixels[i * width * num3 + width * num2 + num4 * num2 + 1], 0.5f), 0.5f), Color.Lerp(Color.Lerp(pixels[i * width * num3 + num4 * num2 + 2], pixels[i * width * num3 + num4 * num2 + 3], 0.5f), Color.Lerp(pixels[i * width * num3 + width * num2 + num4 * num2 + 2], pixels[i * width * num3 + width * num2 + num4 * num2 + 3], 0.5f), 0.5f), 0.5f), Color.Lerp(Color.Lerp(Color.Lerp(pixels[i * width * num3 + width * num2 * 2 + num4 * num2], pixels[i * width * num3 + width * num2 * 2 + num4 * num2 + 1], 0.5f), Color.Lerp(pixels[i * width * num3 + width * num2 * 3 + num4 * num2], pixels[i * width * num3 + width * num2 * 3 + num4 * num2 + 1], 0.5f), 0.5f), Color.Lerp(Color.Lerp(pixels[i * width * num3 + width * num2 * 2 + num4 * num2 + 2], pixels[i * width * num3 + width * num2 * 2 + num4 * num2 + 3], 0.5f), Color.Lerp(pixels[i * width * num3 + width * num2 * 3 + num4 * num2 + 2], pixels[i * width * num3 + width * num2 * 3 + num4 * num2 + 3], 0.5f), 0.5f), 0.5f), 0.5f);
				num4++;
				num++;
			}
		}
		KNGNPDDBHPN.SetPixels(array);
		KNGNPDDBHPN.Apply(false);
		return KNGNPDDBHPN;
	}
}
