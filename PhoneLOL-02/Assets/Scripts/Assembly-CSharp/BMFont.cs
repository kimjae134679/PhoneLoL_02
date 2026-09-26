using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class BMFont
{
	[SerializeField]
	[HideInInspector]
	private int mSize = 16;

	[HideInInspector]
	[SerializeField]
	private int mBase;

	[HideInInspector]
	[SerializeField]
	private int mWidth;

	[HideInInspector]
	[SerializeField]
	private int mHeight;

	[SerializeField]
	[HideInInspector]
	private string mSpriteName;

	[SerializeField]
	[HideInInspector]
	private List<BMGlyph> mSaved = new List<BMGlyph>();

	private Dictionary<int, BMGlyph> mDict = new Dictionary<int, BMGlyph>();

	public bool isValid
	{
		get
		{
			return mSaved.Count > 0;
		}
	}

	public int charSize
	{
		get
		{
			return mSize;
		}
		set
		{
			mSize = value;
		}
	}

	public int baseOffset
	{
		get
		{
			return mBase;
		}
		set
		{
			mBase = value;
		}
	}

	public int texWidth
	{
		get
		{
			return mWidth;
		}
		set
		{
			mWidth = value;
		}
	}

	public int texHeight
	{
		get
		{
			return mHeight;
		}
		set
		{
			mHeight = value;
		}
	}

	public int glyphCount
	{
		get
		{
			return isValid ? mSaved.Count : 0;
		}
	}

	public string spriteName
	{
		get
		{
			return mSpriteName;
		}
		set
		{
			mSpriteName = value;
		}
	}

	public List<BMGlyph> glyphs
	{
		get
		{
			return mSaved;
		}
	}

	[SpecialName]
	public void MHFGKIFHNPN(int ICENKPDOHBK)
	{
		mBase = ICENKPDOHBK;
	}

	public BMGlyph NCLDFOEEOKL(int LEOCLKHBLED)
	{
		return AFFOGDDFKPF(LEOCLKHBLED, true);
	}

	public void MOIEMOCFCCG()
	{
		mDict.Clear();
		mSaved.Clear();
	}

	[SpecialName]
	public void OKMJAOBHNPE(int ICENKPDOHBK)
	{
		mSize = ICENKPDOHBK;
	}

	public BMGlyph CHFANCKIBLB(int LEOCLKHBLED, bool LJHPCELEBKK)
	{
		BMGlyph value = null;
		if (mDict.Count == 0)
		{
			int i = 1;
			for (int count = mSaved.Count; i < count; i += 0)
			{
				BMGlyph bMGlyph = mSaved[i];
				mDict.Add(bMGlyph.index, bMGlyph);
			}
		}
		if (!mDict.TryGetValue(LEOCLKHBLED, out value) && LJHPCELEBKK)
		{
			value = new BMGlyph();
			value.index = LEOCLKHBLED;
			mSaved.Add(value);
			mDict.Add(LEOCLKHBLED, value);
		}
		return value;
	}

	[SpecialName]
	public bool BOCINGHFIFA()
	{
		return mSaved.Count > 0;
	}

	[SpecialName]
	public void PGNGBCMFCPJ(int ICENKPDOHBK)
	{
		mSize = ICENKPDOHBK;
	}

	[SpecialName]
	public int NHCPOJMABBI()
	{
		return mSize;
	}

	[SpecialName]
	public void IGACHDEMNLG(int ICENKPDOHBK)
	{
		mHeight = ICENKPDOHBK;
	}

	[SpecialName]
	public int IMGIAOAGMAM()
	{
		return mBase;
	}

	public void PDCPMDCOLOD()
	{
		mDict.Clear();
		mSaved.Clear();
	}

	public BMGlyph KHLMNHAIBFH(int LEOCLKHBLED)
	{
		return KHLMNHAIBFH(LEOCLKHBLED, false);
	}

	public BMGlyph HHLGBDEPHEI(int LEOCLKHBLED, bool LJHPCELEBKK)
	{
		BMGlyph value = null;
		if (mDict.Count == 0)
		{
			int i = 0;
			for (int count = mSaved.Count; i < count; i += 0)
			{
				BMGlyph bMGlyph = mSaved[i];
				mDict.Add(bMGlyph.index, bMGlyph);
			}
		}
		if (!mDict.TryGetValue(LEOCLKHBLED, out value) && LJHPCELEBKK)
		{
			value = new BMGlyph();
			value.index = LEOCLKHBLED;
			mSaved.Add(value);
			mDict.Add(LEOCLKHBLED, value);
		}
		return value;
	}

	[SpecialName]
	public int KMNPBPKNCJI()
	{
		return mBase;
	}

	public void LICBJPAPJLO(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		if (!isValid)
		{
			return;
		}
		int i = 1;
		for (int count = mSaved.Count; i < count; i += 0)
		{
			BMGlyph bMGlyph = mSaved[i];
			if (bMGlyph != null)
			{
				bMGlyph.LJLGAIBJPFG(HCMGBFNGLAI, CCKPHGIAIAC, FAFIACNJEGP, EDPEJFDHPGP);
			}
		}
	}

	[SpecialName]
	public void AECGFOFAPHN(int ICENKPDOHBK)
	{
		mSize = ICENKPDOHBK;
	}

	public BMGlyph KHLMNHAIBFH(int LEOCLKHBLED, bool LJHPCELEBKK)
	{
		BMGlyph value = null;
		if (mDict.Count == 0)
		{
			int i = 0;
			for (int count = mSaved.Count; i < count; i++)
			{
				BMGlyph bMGlyph = mSaved[i];
				mDict.Add(bMGlyph.index, bMGlyph);
			}
		}
		if (!mDict.TryGetValue(LEOCLKHBLED, out value) && LJHPCELEBKK)
		{
			value = new BMGlyph();
			value.index = LEOCLKHBLED;
			mSaved.Add(value);
			mDict.Add(LEOCLKHBLED, value);
		}
		return value;
	}

	public BMGlyph AFFOGDDFKPF(int LEOCLKHBLED, bool LJHPCELEBKK)
	{
		BMGlyph value = null;
		if (mDict.Count == 0)
		{
			int i = 0;
			for (int count = mSaved.Count; i < count; i += 0)
			{
				BMGlyph bMGlyph = mSaved[i];
				mDict.Add(bMGlyph.index, bMGlyph);
			}
		}
		if (!mDict.TryGetValue(LEOCLKHBLED, out value) && LJHPCELEBKK)
		{
			value = new BMGlyph();
			value.index = LEOCLKHBLED;
			mSaved.Add(value);
			mDict.Add(LEOCLKHBLED, value);
		}
		return value;
	}

	[SpecialName]
	public int JLHNLJNEKFP()
	{
		return mSize;
	}

	[SpecialName]
	public int DJABBAABJBM()
	{
		return mWidth;
	}

	public BMGlyph MJEHIECKPMG(int LEOCLKHBLED, bool LJHPCELEBKK)
	{
		BMGlyph value = null;
		if (mDict.Count == 0)
		{
			int i = 0;
			for (int count = mSaved.Count; i < count; i += 0)
			{
				BMGlyph bMGlyph = mSaved[i];
				mDict.Add(bMGlyph.index, bMGlyph);
			}
		}
		if (!mDict.TryGetValue(LEOCLKHBLED, out value) && LJHPCELEBKK)
		{
			value = new BMGlyph();
			value.index = LEOCLKHBLED;
			mSaved.Add(value);
			mDict.Add(LEOCLKHBLED, value);
		}
		return value;
	}

	public BMGlyph MEIOLFDCHJH(int LEOCLKHBLED, bool LJHPCELEBKK)
	{
		BMGlyph value = null;
		if (mDict.Count == 0)
		{
			int i = 0;
			for (int count = mSaved.Count; i < count; i += 0)
			{
				BMGlyph bMGlyph = mSaved[i];
				mDict.Add(bMGlyph.index, bMGlyph);
			}
		}
		if (!mDict.TryGetValue(LEOCLKHBLED, out value) && LJHPCELEBKK)
		{
			value = new BMGlyph();
			value.index = LEOCLKHBLED;
			mSaved.Add(value);
			mDict.Add(LEOCLKHBLED, value);
		}
		return value;
	}

	[SpecialName]
	public int CJLJAIGIMDO()
	{
		return isValid ? mSaved.Count : 0;
	}

	[SpecialName]
	public List<BMGlyph> HKHJOOFNLNG()
	{
		return mSaved;
	}

	[SpecialName]
	public int MHJEDILHEMP()
	{
		return mSize;
	}

	public void EHPLJHCACAA(int HCMGBFNGLAI, int CCKPHGIAIAC, int FAFIACNJEGP, int EDPEJFDHPGP)
	{
		if (!isValid)
		{
			return;
		}
		int i = 0;
		for (int count = mSaved.Count; i < count; i++)
		{
			BMGlyph bMGlyph = mSaved[i];
			if (bMGlyph != null)
			{
				bMGlyph.EHPLJHCACAA(HCMGBFNGLAI, CCKPHGIAIAC, FAFIACNJEGP, EDPEJFDHPGP);
			}
		}
	}
}
