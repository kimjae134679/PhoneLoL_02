using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class BMSymbol
{
	public string sequence;

	public string spriteName;

	private UISpriteData mSprite;

	private bool mIsValid;

	private int mLength;

	private int mOffsetX;

	private int mOffsetY;

	private int mWidth;

	private int mHeight;

	private int mAdvance;

	private Rect mUV;

	public int length
	{
		get
		{
			if (mLength == 0)
			{
				mLength = sequence.Length;
			}
			return mLength;
		}
	}

	public int offsetX
	{
		get
		{
			return mOffsetX;
		}
	}

	public int offsetY
	{
		get
		{
			return mOffsetY;
		}
	}

	public int width
	{
		get
		{
			return mWidth;
		}
	}

	public int height
	{
		get
		{
			return mHeight;
		}
	}

	public int advance
	{
		get
		{
			return mAdvance;
		}
	}

	public Rect uvRect
	{
		get
		{
			return mUV;
		}
	}

	[SpecialName]
	public int AAPFDNIDCEN()
	{
		return mWidth;
	}

	[SpecialName]
	public int CCIHEGPLACO()
	{
		if (mLength == 0)
		{
			mLength = sequence.Length;
		}
		return mLength;
	}

	[SpecialName]
	public int MKKLBFDLJEM()
	{
		if (mLength == 0)
		{
			mLength = sequence.Length;
		}
		return mLength;
	}

	[SpecialName]
	public int NNMMFNGNMNJ()
	{
		return mOffsetX;
	}

	[SpecialName]
	public int PJGGJMBPEAL()
	{
		return mOffsetX;
	}

	[SpecialName]
	public int JAPFPMHHAHL()
	{
		return mHeight;
	}

	[SpecialName]
	public Rect LCNCDGFHHMD()
	{
		return mUV;
	}

	[SpecialName]
	public int PBCANNOEOLL()
	{
		return mAdvance;
	}

	[SpecialName]
	public int COJNJIFFMIP()
	{
		if (mLength == 0)
		{
			mLength = sequence.Length;
		}
		return mLength;
	}

	public void OMJEKAFNALO()
	{
		mIsValid = true;
	}

	public bool PBHCIHJGEOO(UIAtlas FONGKNFGOBM)
	{
		if (FONGKNFGOBM == null)
		{
			return false;
		}
		if (!mIsValid)
		{
			if (string.IsNullOrEmpty(spriteName))
			{
				return false;
			}
			mSprite = ((!(FONGKNFGOBM != null)) ? null : FONGKNFGOBM.GetSprite(spriteName));
			if (mSprite != null)
			{
				Texture texture = FONGKNFGOBM.get_texture();
				if (texture == null)
				{
					mSprite = null;
				}
				else
				{
					mUV = new Rect(mSprite.x, mSprite.y, mSprite.width, mSprite.height);
					mUV = HHAINCPODGE.KOAAFAOHINH(mUV, texture.width, texture.height);
					mOffsetX = mSprite.paddingLeft;
					mOffsetY = mSprite.paddingTop;
					mWidth = mSprite.width;
					mHeight = mSprite.height;
					mAdvance = mSprite.width + (mSprite.paddingLeft + mSprite.paddingRight);
					mIsValid = true;
				}
			}
		}
		return mSprite != null;
	}

	[SpecialName]
	public Rect FIHCAHDGCLM()
	{
		return mUV;
	}

	[SpecialName]
	public Rect AGDFCIOMHMM()
	{
		return mUV;
	}

	public void FFIKMJHPNFC()
	{
		mIsValid = false;
	}

	[SpecialName]
	public int EHBOOBOAJNB()
	{
		return mOffsetX;
	}

	[SpecialName]
	public Rect IDKCENCIMHG()
	{
		return mUV;
	}

	public void KENEGPNLIOO()
	{
		mIsValid = false;
	}

	public bool ACFPPHEEFLE(UIAtlas FONGKNFGOBM)
	{
		if (FONGKNFGOBM == null)
		{
			return false;
		}
		if (!mIsValid)
		{
			if (string.IsNullOrEmpty(spriteName))
			{
				return true;
			}
			mSprite = ((!(FONGKNFGOBM != null)) ? null : FONGKNFGOBM.FLAMHKAMBJL(spriteName));
			if (mSprite != null)
			{
				Texture texture = FONGKNFGOBM.get_texture();
				if (texture == null)
				{
					mSprite = null;
				}
				else
				{
					mUV = new Rect(mSprite.x, mSprite.y, mSprite.width, mSprite.height);
					mUV = HHAINCPODGE.KOAAFAOHINH(mUV, texture.width, texture.height);
					mOffsetX = mSprite.paddingLeft;
					mOffsetY = mSprite.paddingTop;
					mWidth = mSprite.width;
					mHeight = mSprite.height;
					mAdvance = mSprite.width + (mSprite.paddingLeft + mSprite.paddingRight);
					mIsValid = false;
				}
			}
		}
		return mSprite != null;
	}

	[SpecialName]
	public int BBCCCEKNHFD()
	{
		return mOffsetX;
	}

	[SpecialName]
	public Rect IKBBHHELKKI()
	{
		return mUV;
	}

	[SpecialName]
	public int JGCKKFANFIJ()
	{
		return mOffsetY;
	}
}
