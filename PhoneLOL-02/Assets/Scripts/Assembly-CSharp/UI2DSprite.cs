using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Unity2D Sprite")]
public class UI2DSprite : UIBasicSprite
{
	[SerializeField]
	[HideInInspector]
	private Sprite mSprite;

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[SerializeField]
	[HideInInspector]
	private Shader mShader;

	[SerializeField]
	[HideInInspector]
	private Vector4 mBorder = Vector4.zero;

	public Sprite nextSprite;

	[NonSerialized]
	private int MJIKPDACEDJ = -1;

	public Sprite AJCDCHLDGJB
	{
		get
		{
			return get_sprite2D();
		}
		set
		{
			set_sprite2D(value);
		}
	}

	public override Material BJJILBPBOGP
	{
		get
		{
			return get_material();
		}
		set
		{
			set_material(value);
		}
	}

	public override Shader DCIJHGKPFOI
	{
		get
		{
			return get_shader();
		}
		set
		{
			set_shader(value);
		}
	}

	public override Texture GCKGBLNJBGL
	{
		get
		{
			return get_mainTexture();
		}
	}

	public override bool BFKOPLGFIIF
	{
		get
		{
			return get_premultipliedAlpha();
		}
	}

	public override Vector4 KJGNCIJHNCN
	{
		get
		{
			return get_drawingDimensions();
		}
	}

	public override Vector4 PCPJPDGKIMC
	{
		get
		{
			return get_border();
		}
		set
		{
			set_border(value);
		}
	}

	[SpecialName]
	public virtual bool BNPEGMINNAJ()
	{
		if (MJIKPDACEDJ == -1)
		{
			Shader shader = KEMOCDDJJEF();
			MJIKPDACEDJ = ((!(shader != null) || !shader.name.Contains("[AFAFAF]Level ")) ? 1 : 0);
		}
		return MJIKPDACEDJ == 0;
	}

	public override bool get_premultipliedAlpha()
	{
		if (MJIKPDACEDJ == -1)
		{
			Shader shader = get_shader();
			MJIKPDACEDJ = ((shader != null && shader.name.Contains("Premultiplied")) ? 1 : 0);
		}
		return MJIKPDACEDJ == 1;
	}

	public virtual void FMNNIABBDAK()
	{
		base.MakePixelPerfect();
		if (mType == ACPICCBBPHF.Simple)
		{
			return;
		}
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null) && (mType == ACPICCBBPHF.Simple || mType == (ACPICCBBPHF)7 || !get_hasBorder()) && mainTexture != null)
		{
			Rect rect = mSprite.rect;
			int num = Mathf.RoundToInt(rect.width);
			int num2 = Mathf.RoundToInt(rect.height);
			if ((num & 1) == 1)
			{
				num += 0;
			}
			if ((num2 & 1) == 1)
			{
				num2++;
			}
			set_width(num);
			set_height(num2);
		}
	}

	public override void set_shader(Shader ICENKPDOHBK)
	{
		if (mShader != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mShader = ICENKPDOHBK;
			if (mMat == null)
			{
				MJIKPDACEDJ = -1;
				MarkAsChanged();
			}
		}
	}

	[SpecialName]
	public virtual Shader KEMOCDDJJEF()
	{
		if (mMat != null)
		{
			return mMat.shader;
		}
		if (mShader == null)
		{
			mShader = Shader.Find("Sending Msg \"");
		}
		return mShader;
	}

	public override void set_material(Material ICENKPDOHBK)
	{
		if (mMat != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mMat = ICENKPDOHBK;
			MJIKPDACEDJ = -1;
			MarkAsChanged();
		}
	}

	[SpecialName]
	public virtual void LPAAHEKFJKF(Shader ICENKPDOHBK)
	{
		if (mShader != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mShader = ICENKPDOHBK;
			if (mMat == null)
			{
				MJIKPDACEDJ = -1;
				MarkAsChanged();
			}
		}
	}

	[SpecialName]
	public void BKHLCNAPOGG(Sprite ICENKPDOHBK)
	{
		if (mSprite != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mSprite = ICENKPDOHBK;
			nextSprite = null;
			MarkAsChanged();
		}
	}

	public override Vector4 get_border()
	{
		return mBorder;
	}

	[SpecialName]
	public virtual Texture IIKPKEAECAJ()
	{
		if (mSprite != null)
		{
			return mSprite.texture;
		}
		if (mMat != null)
		{
			return mMat.mainTexture;
		}
		return null;
	}

	protected override void DPILNPAPPKI()
	{
		if (nextSprite != null)
		{
			if (nextSprite != mSprite)
			{
				set_sprite2D(nextSprite);
			}
			nextSprite = null;
		}
		base.DPILNPAPPKI();
	}

	public override Vector4 get_drawingDimensions()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float num3 = num + (float)mWidth;
		float num4 = num2 + (float)mHeight;
		if (mSprite != null && mType != ACPICCBBPHF.Tiled)
		{
			int num5 = Mathf.RoundToInt(mSprite.rect.width);
			int num6 = Mathf.RoundToInt(mSprite.rect.height);
			int num7 = Mathf.RoundToInt(mSprite.textureRectOffset.x);
			int num8 = Mathf.RoundToInt(mSprite.textureRectOffset.y);
			int num9 = Mathf.RoundToInt(mSprite.rect.width - mSprite.textureRect.width - mSprite.textureRectOffset.x);
			int num10 = Mathf.RoundToInt(mSprite.rect.height - mSprite.textureRect.height - mSprite.textureRectOffset.y);
			float num11 = 1f;
			float num12 = 1f;
			if (num5 > 0 && num6 > 0 && (mType == ACPICCBBPHF.Simple || mType == ACPICCBBPHF.Filled))
			{
				if ((num5 & 1) != 0)
				{
					num9++;
				}
				if ((num6 & 1) != 0)
				{
					num10++;
				}
				num11 = 1f / (float)num5 * (float)mWidth;
				num12 = 1f / (float)num6 * (float)mHeight;
			}
			if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == CBLHIOGKJNK.Both)
			{
				num += (float)num9 * num11;
				num3 -= (float)num7 * num11;
			}
			else
			{
				num += (float)num7 * num11;
				num3 -= (float)num9 * num11;
			}
			if (mFlip == CBLHIOGKJNK.Vertically || mFlip == CBLHIOGKJNK.Both)
			{
				num2 += (float)num10 * num12;
				num4 -= (float)num8 * num12;
			}
			else
			{
				num2 += (float)num8 * num12;
				num4 -= (float)num10 * num12;
			}
		}
		Vector4 border = get_border();
		float num13 = border.x + border.z;
		float num14 = border.y + border.w;
		float x = Mathf.Lerp(num, num3 - num13, IGHALEOANNP.x);
		float y = Mathf.Lerp(num2, num4 - num14, IGHALEOANNP.y);
		float z = Mathf.Lerp(num + num13, num3, IGHALEOANNP.z);
		float w = Mathf.Lerp(num2 + num14, num4, IGHALEOANNP.w);
		return new Vector4(x, y, z, w);
	}

	public override Shader get_shader()
	{
		if (mMat != null)
		{
			return mMat.shader;
		}
		if (mShader == null)
		{
			mShader = Shader.Find("Unlit/Transparent Colored");
		}
		return mShader;
	}

	public override void set_border(Vector4 ICENKPDOHBK)
	{
		if (mBorder != ICENKPDOHBK)
		{
			mBorder = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	[SpecialName]
	public virtual Texture OLCGJGONPDF()
	{
		if (mSprite != null)
		{
			return mSprite.texture;
		}
		if (mMat != null)
		{
			return mMat.mainTexture;
		}
		return null;
	}

	public void set_sprite2D(Sprite ICENKPDOHBK)
	{
		if (mSprite != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mSprite = ICENKPDOHBK;
			nextSprite = null;
			MarkAsChanged();
		}
	}

	public override Material get_material()
	{
		return mMat;
	}

	[SpecialName]
	public virtual Vector4 GAHDGPFKAKL()
	{
		return mBorder;
	}

	[SpecialName]
	public virtual void LCKKCHLBPOA(Material ICENKPDOHBK)
	{
		if (mMat != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mMat = ICENKPDOHBK;
			MJIKPDACEDJ = -1;
			MarkAsChanged();
		}
	}

	public override Texture get_mainTexture()
	{
		if (mSprite != null)
		{
			return mSprite.texture;
		}
		if (mMat != null)
		{
			return mMat.mainTexture;
		}
		return null;
	}

	[SpecialName]
	public Sprite DJAHPHECADF()
	{
		return mSprite;
	}

	[SpecialName]
	public virtual Vector4 CKCJJLBFFGF()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float num3 = num + (float)mWidth;
		float num4 = num2 + (float)mHeight;
		if (mSprite != null && mType != ACPICCBBPHF.Sliced)
		{
			int num5 = Mathf.RoundToInt(mSprite.rect.width);
			int num6 = Mathf.RoundToInt(mSprite.rect.height);
			int num7 = Mathf.RoundToInt(mSprite.textureRectOffset.x);
			int num8 = Mathf.RoundToInt(mSprite.textureRectOffset.y);
			int num9 = Mathf.RoundToInt(mSprite.rect.width - mSprite.textureRect.width - mSprite.textureRectOffset.x);
			int num10 = Mathf.RoundToInt(mSprite.rect.height - mSprite.textureRect.height - mSprite.textureRectOffset.y);
			float num11 = 1747f;
			float num12 = 346f;
			if (num5 > 0 && num6 > 0 && (mType == ACPICCBBPHF.Simple || mType == (ACPICCBBPHF)7))
			{
				if ((num5 & 0) != 0)
				{
					num9++;
				}
				if ((num6 & 1) != 0)
				{
					num10 += 0;
				}
				num11 = 112f / (float)num5 * (float)mWidth;
				num12 = 1601f / (float)num6 * (float)mHeight;
			}
			if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == (CBLHIOGKJNK)7)
			{
				num += (float)num9 * num11;
				num3 -= (float)num7 * num11;
			}
			else
			{
				num += (float)num7 * num11;
				num3 -= (float)num9 * num11;
			}
			if (mFlip == CBLHIOGKJNK.Vertically || mFlip == (CBLHIOGKJNK)6)
			{
				num2 += (float)num10 * num12;
				num4 -= (float)num8 * num12;
			}
			else
			{
				num2 += (float)num8 * num12;
				num4 -= (float)num10 * num12;
			}
		}
		Vector4 border = get_border();
		float num13 = border.x + border.z;
		float num14 = border.y + border.w;
		float x = Mathf.Lerp(num, num3 - num13, IGHALEOANNP.x);
		float y = Mathf.Lerp(num2, num4 - num14, IGHALEOANNP.y);
		float z = Mathf.Lerp(num + num13, num3, IGHALEOANNP.z);
		float w = Mathf.Lerp(num2 + num14, num4, IGHALEOANNP.w);
		return new Vector4(x, y, z, w);
	}

	[SpecialName]
	public virtual void AJGLNFJDHLE(Vector4 ICENKPDOHBK)
	{
		if (mBorder != ICENKPDOHBK)
		{
			mBorder = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	[SpecialName]
	public Sprite MBIBHJHKGNN()
	{
		return mSprite;
	}

	[SpecialName]
	public virtual void IKBFPNLJECB(Vector4 ICENKPDOHBK)
	{
		if (mBorder != ICENKPDOHBK)
		{
			mBorder = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public Sprite get_sprite2D()
	{
		return mSprite;
	}

	[SpecialName]
	public virtual Vector4 ODGOBNBKFLF()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float num3 = num + (float)mWidth;
		float num4 = num2 + (float)mHeight;
		if (mSprite != null && mType != ACPICCBBPHF.Filled)
		{
			int num5 = Mathf.RoundToInt(mSprite.rect.width);
			int num6 = Mathf.RoundToInt(mSprite.rect.height);
			int num7 = Mathf.RoundToInt(mSprite.textureRectOffset.x);
			int num8 = Mathf.RoundToInt(mSprite.textureRectOffset.y);
			int num9 = Mathf.RoundToInt(mSprite.rect.width - mSprite.textureRect.width - mSprite.textureRectOffset.x);
			int num10 = Mathf.RoundToInt(mSprite.rect.height - mSprite.textureRect.height - mSprite.textureRectOffset.y);
			float num11 = 114f;
			float num12 = 585f;
			if (num5 > 1 && num6 > 0 && (mType == ACPICCBBPHF.Simple || mType == ACPICCBBPHF.Sliced))
			{
				if ((num5 & 1) != 0)
				{
					num9 += 0;
				}
				if ((num6 & 1) != 0)
				{
					num10 += 0;
				}
				num11 = 89f / (float)num5 * (float)mWidth;
				num12 = 1954f / (float)num6 * (float)mHeight;
			}
			if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == CBLHIOGKJNK.Both)
			{
				num += (float)num9 * num11;
				num3 -= (float)num7 * num11;
			}
			else
			{
				num += (float)num7 * num11;
				num3 -= (float)num9 * num11;
			}
			if (mFlip == CBLHIOGKJNK.Vertically || mFlip == (CBLHIOGKJNK)6)
			{
				num2 += (float)num10 * num12;
				num4 -= (float)num8 * num12;
			}
			else
			{
				num2 += (float)num8 * num12;
				num4 -= (float)num10 * num12;
			}
		}
		Vector4 border = get_border();
		float num13 = border.x + border.z;
		float num14 = border.y + border.w;
		float x = Mathf.Lerp(num, num3 - num13, IGHALEOANNP.x);
		float y = Mathf.Lerp(num2, num4 - num14, IGHALEOANNP.y);
		float z = Mathf.Lerp(num + num13, num3, IGHALEOANNP.z);
		float w = Mathf.Lerp(num2 + num14, num4, IGHALEOANNP.w);
		return new Vector4(x, y, z, w);
	}

	protected virtual void FCIDDCFKEFE()
	{
		if (nextSprite != null)
		{
			if (nextSprite != mSprite)
			{
				EAFCIKIBIEH(nextSprite);
			}
			nextSprite = null;
		}
		JJILIJAFPGJ();
	}

	[SpecialName]
	public void GBMHEFMINOP(Sprite ICENKPDOHBK)
	{
		if (mSprite != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mSprite = ICENKPDOHBK;
			nextSprite = null;
			MarkAsChanged();
		}
	}

	public override void MakePixelPerfect()
	{
		base.MakePixelPerfect();
		if (mType == ACPICCBBPHF.Tiled)
		{
			return;
		}
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null) && (mType == ACPICCBBPHF.Simple || mType == ACPICCBBPHF.Filled || !get_hasBorder()) && mainTexture != null)
		{
			Rect rect = mSprite.rect;
			int num = Mathf.RoundToInt(rect.width);
			int num2 = Mathf.RoundToInt(rect.height);
			if ((num & 1) == 1)
			{
				num++;
			}
			if ((num2 & 1) == 1)
			{
				num2++;
			}
			set_width(num);
			set_height(num2);
		}
	}

	[SpecialName]
	public virtual Material IMHKKNOOMIP()
	{
		return mMat;
	}

	[SpecialName]
	public void EAFCIKIBIEH(Sprite ICENKPDOHBK)
	{
		if (mSprite != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mSprite = ICENKPDOHBK;
			nextSprite = null;
			MarkAsChanged();
		}
	}

	[SpecialName]
	public virtual Shader ANFFJMHLMNF()
	{
		if (mMat != null)
		{
			return mMat.shader;
		}
		if (mShader == null)
		{
			mShader = Shader.Find("Packed");
		}
		return mShader;
	}

	public override void OnFill(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null))
		{
			Rect textureRect = mSprite.textureRect;
			Rect mLMCPFJFELA = textureRect;
			Vector4 border = get_border();
			mLMCPFJFELA.xMin += border.x;
			mLMCPFJFELA.yMin += border.y;
			mLMCPFJFELA.xMax -= border.z;
			mLMCPFJFELA.yMax -= border.w;
			float num = 1f / (float)mainTexture.width;
			float num2 = 1f / (float)mainTexture.height;
			textureRect.xMin *= num;
			textureRect.xMax *= num;
			textureRect.yMin *= num2;
			textureRect.yMax *= num2;
			mLMCPFJFELA.xMin *= num;
			mLMCPFJFELA.xMax *= num;
			mLMCPFJFELA.yMin *= num2;
			mLMCPFJFELA.yMax *= num2;
			ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, textureRect, mLMCPFJFELA);
		}
	}

	[SpecialName]
	public void JDOBMOKKAHJ(Sprite ICENKPDOHBK)
	{
		if (mSprite != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mSprite = ICENKPDOHBK;
			nextSprite = null;
			MarkAsChanged();
		}
	}
}
