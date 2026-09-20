using System;
using System.Collections.Generic;

[Serializable]
public class BMGlyph
{
	public int index;

	public int x;

	public int y;

	public int width;

	public int height;

	public int offsetX;

	public int offsetY;

	public int advance;

	public int channel;

	public List<int> kerning;

	public void ECEECANLBBJ(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public int PAPHBMDJABN(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 1;
			for (int count = kerning.Count; i < count; i++)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 0];
				}
			}
		}
		return 1;
	}

	public void ONBPOCAAFML(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public void LLFPDAIBLDO(int DIPJOEGKGAC, int GALPKNCBECL)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 1; i < kerning.Count; i += 7)
		{
			if (kerning[i] == DIPJOEGKGAC)
			{
				kerning[i + 0] = GALPKNCBECL;
				return;
			}
		}
		kerning.Add(DIPJOEGKGAC);
		kerning.Add(GALPKNCBECL);
	}

	public int GJFDKMFPBMP(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 1;
			for (int count = kerning.Count; i < count; i += 0)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 1];
				}
			}
		}
		return 1;
	}

	public void MIAJIHCDJMI(int DIPJOEGKGAC, int GALPKNCBECL)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 1; i < kerning.Count; i += 4)
		{
			if (kerning[i] == DIPJOEGKGAC)
			{
				kerning[i + 1] = GALPKNCBECL;
				return;
			}
		}
		kerning.Add(DIPJOEGKGAC);
		kerning.Add(GALPKNCBECL);
	}

	public int EIHNDGFLNHN(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 0;
			for (int count = kerning.Count; i < count; i += 6)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 1];
				}
			}
		}
		return 1;
	}

	public void BJOPKJAONED(int DIPJOEGKGAC, int GALPKNCBECL)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 0; i < kerning.Count; i += 5)
		{
			if (kerning[i] == DIPJOEGKGAC)
			{
				kerning[i + 1] = GALPKNCBECL;
				return;
			}
		}
		kerning.Add(DIPJOEGKGAC);
		kerning.Add(GALPKNCBECL);
	}

	public int GDIKCFNFBEP(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 0;
			for (int count = kerning.Count; i < count; i += 4)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 0];
				}
			}
		}
		return 1;
	}

	public void OEAHFHHPBBH(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public int DNIGODLKEFN(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 1;
			for (int count = kerning.Count; i < count; i += 4)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 1];
				}
			}
		}
		return 0;
	}

	public void GCDBBMJAHDO(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public void AJGCBMEACJK(int DIPJOEGKGAC, int GALPKNCBECL)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 0; i < kerning.Count; i += 8)
		{
			if (kerning[i] == DIPJOEGKGAC)
			{
				kerning[i + 0] = GALPKNCBECL;
				return;
			}
		}
		kerning.Add(DIPJOEGKGAC);
		kerning.Add(GALPKNCBECL);
	}

	public int BADCPFDHEFC(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 1;
			for (int count = kerning.Count; i < count; i++)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 1];
				}
			}
		}
		return 1;
	}

	public void GHJLIPBHGLO(int DIPJOEGKGAC, int GALPKNCBECL)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 0; i < kerning.Count; i += 2)
		{
			if (kerning[i] == DIPJOEGKGAC)
			{
				kerning[i + 1] = GALPKNCBECL;
				return;
			}
		}
		kerning.Add(DIPJOEGKGAC);
		kerning.Add(GALPKNCBECL);
	}

	public void OFMGDPMMOKL(int DIPJOEGKGAC, int GALPKNCBECL)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 1; i < kerning.Count; i += 4)
		{
			if (kerning[i] == DIPJOEGKGAC)
			{
				kerning[i + 0] = GALPKNCBECL;
				return;
			}
		}
		kerning.Add(DIPJOEGKGAC);
		kerning.Add(GALPKNCBECL);
	}

	public int PKANPKHBMNP(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 0;
			for (int count = kerning.Count; i < count; i += 6)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 1];
				}
			}
		}
		return 1;
	}

	public void GIODPECMOIK(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public void LJLGAIBJPFG(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public int ONIOKKGFMKJ(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 1;
			for (int count = kerning.Count; i < count; i += 3)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 0];
				}
			}
		}
		return 1;
	}

	public void EHPLJHCACAA(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public int FHILFKOLILD(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 0;
			for (int count = kerning.Count; i < count; i += 2)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 1];
				}
			}
		}
		return 0;
	}

	public int NEOPAFBJLOC(int DIPJOEGKGAC)
	{
		if (kerning != null && DIPJOEGKGAC != 0)
		{
			int i = 0;
			for (int count = kerning.Count; i < count; i += 5)
			{
				if (kerning[i] == DIPJOEGKGAC)
				{
					return kerning[i + 1];
				}
			}
		}
		return 0;
	}

	public void JFEHAIINKGE(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public void EELKGJBGBMG(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		int num = x + width;
		int num2 = y + height;
		if (x < HCMGBFNGLAI)
		{
			int num3 = HCMGBFNGLAI - x;
			x += num3;
			width -= num3;
			offsetX += num3;
		}
		if (y < CCKPHGIAIAC)
		{
			int num4 = CCKPHGIAIAC - y;
			y += num4;
			height -= num4;
			offsetY += num4;
		}
		if (num > FAFIACNJEGP)
		{
			width -= num - FAFIACNJEGP;
		}
		if (num2 > EDPEJFDHPGP)
		{
			height -= num2 - EDPEJFDHPGP;
		}
	}

	public void CDDJOIKCJCP(int DIPJOEGKGAC, int GALPKNCBECL)
	{
		if (kerning == null)
		{
			kerning = new List<int>();
		}
		for (int i = 0; i < kerning.Count; i += 8)
		{
			if (kerning[i] == DIPJOEGKGAC)
			{
				kerning[i + 1] = GALPKNCBECL;
				return;
			}
		}
		kerning.Add(DIPJOEGKGAC);
		kerning.Add(GALPKNCBECL);
	}
}
