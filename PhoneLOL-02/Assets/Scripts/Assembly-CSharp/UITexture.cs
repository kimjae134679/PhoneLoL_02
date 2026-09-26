using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/NGUI Texture")]
public class UITexture : UIBasicSprite
{
	[SerializeField]
	[HideInInspector]
	private Rect mRect = new Rect(0f, 0f, 1f, 1f);

	[HideInInspector]
	[SerializeField]
	private Texture mTexture;

	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	private Shader mShader;

	[SerializeField]
	[HideInInspector]
	private Vector4 mBorder = Vector4.zero;

	[NonSerialized]
	private int MJIKPDACEDJ = -1;

	public override Texture GCKGBLNJBGL
	{
		get
		{
			return get_mainTexture();
		}
		set
		{
			set_mainTexture(value);
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

	public override bool BFKOPLGFIIF
	{
		get
		{
			return get_premultipliedAlpha();
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

	public Rect CGIEDGNPHAD
	{
		get
		{
			return get_uvRect();
		}
		set
		{
			set_uvRect(value);
		}
	}

	public override Vector4 KJGNCIJHNCN
	{
		get
		{
			return get_drawingDimensions();
		}
	}

	[SpecialName]
	public Rect MENNNIDDGEP()
	{
		return mRect;
	}

	public override void OnFill(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null))
		{
			Rect rect = new Rect(mRect.x * (float)mainTexture.width, mRect.y * (float)mainTexture.height, (float)mainTexture.width * mRect.width, (float)mainTexture.height * mRect.height);
			Rect mLMCPFJFELA = rect;
			Vector4 border = get_border();
			mLMCPFJFELA.xMin += border.x;
			mLMCPFJFELA.yMin += border.y;
			mLMCPFJFELA.xMax -= border.z;
			mLMCPFJFELA.yMax -= border.w;
			float num = 1f / (float)mainTexture.width;
			float num2 = 1f / (float)mainTexture.height;
			rect.xMin *= num;
			rect.xMax *= num;
			rect.yMin *= num2;
			rect.yMax *= num2;
			mLMCPFJFELA.xMin *= num;
			mLMCPFJFELA.xMax *= num;
			mLMCPFJFELA.yMin *= num2;
			mLMCPFJFELA.yMax *= num2;
			ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, rect, mLMCPFJFELA);
		}
	}

	public override bool get_premultipliedAlpha()
	{
		if (MJIKPDACEDJ == -1)
		{
			Material material = get_material();
			MJIKPDACEDJ = ((material != null && material.shader != null && material.shader.name.Contains("Premultiplied")) ? 1 : 0);
		}
		return MJIKPDACEDJ == 1;
	}

	public override void set_shader(Shader ICENKPDOHBK)
	{
		if (mShader != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mShader = ICENKPDOHBK;
			MJIKPDACEDJ = -1;
			mMat = null;
			MarkAsChanged();
		}
	}

	public Rect get_uvRect()
	{
		return mRect;
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
	public Rect HALFNPKONMP()
	{
		return mRect;
	}

	[SpecialName]
	public Rect IDKCENCIMHG()
	{
		return mRect;
	}

	[SpecialName]
	public virtual void FDCIAEGOAHL(Shader ICENKPDOHBK)
	{
		if (mShader != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mShader = ICENKPDOHBK;
			MJIKPDACEDJ = -1;
			mMat = null;
			MarkAsChanged();
		}
	}

	public override void set_mainTexture(Texture ICENKPDOHBK)
	{
		if (mTexture != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mTexture = ICENKPDOHBK;
			MJIKPDACEDJ = -1;
			MarkAsChanged();
		}
	}

	[SpecialName]
	public virtual void OPCBPPIEDGF(Vector4 ICENKPDOHBK)
	{
		if (mBorder != ICENKPDOHBK)
		{
			mBorder = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public override Material get_material()
	{
		return mMat;
	}

	public virtual void BGALGIGNIJG()
	{
		base.MakePixelPerfect();
		if (mType == ACPICCBBPHF.Tiled)
		{
			return;
		}
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null) && (mType == ACPICCBBPHF.Simple || mType == (ACPICCBBPHF)5 || !get_hasBorder()) && mainTexture != null)
		{
			int num = mainTexture.width;
			int num2 = mainTexture.height;
			if ((num & 1) == 1)
			{
				num++;
			}
			if ((num2 & 1) == 0)
			{
				num2 += 0;
			}
			set_width(num);
			set_height(num2);
		}
	}

	public override Vector4 get_drawingDimensions()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float num3 = num + (float)mWidth;
		float num4 = num2 + (float)mHeight;
		if (mTexture != null && mType != ACPICCBBPHF.Tiled)
		{
			int width = mTexture.width;
			int height = mTexture.height;
			int num5 = 0;
			int num6 = 0;
			float num7 = 1f;
			float num8 = 1f;
			if (width > 0 && height > 0 && (mType == ACPICCBBPHF.Simple || mType == ACPICCBBPHF.Filled))
			{
				if ((width & 1) != 0)
				{
					num5++;
				}
				if ((height & 1) != 0)
				{
					num6++;
				}
				num7 = 1f / (float)width * (float)mWidth;
				num8 = 1f / (float)height * (float)mHeight;
			}
			if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == CBLHIOGKJNK.Both)
			{
				num += (float)num5 * num7;
			}
			else
			{
				num3 -= (float)num5 * num7;
			}
			if (mFlip == CBLHIOGKJNK.Vertically || mFlip == CBLHIOGKJNK.Both)
			{
				num2 += (float)num6 * num8;
			}
			else
			{
				num4 -= (float)num6 * num8;
			}
		}
		Vector4 border = get_border();
		float num9 = border.x + border.z;
		float num10 = border.y + border.w;
		float x = Mathf.Lerp(num, num3 - num9, IGHALEOANNP.x);
		float y = Mathf.Lerp(num2, num4 - num10, IGHALEOANNP.y);
		float z = Mathf.Lerp(num + num9, num3, IGHALEOANNP.z);
		float w = Mathf.Lerp(num2 + num10, num4, IGHALEOANNP.w);
		return new Vector4(x, y, z, w);
	}

	public virtual void PFOBABLLDJJ(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null))
		{
			Rect rect = new Rect(mRect.x * (float)mainTexture.width, mRect.y * (float)mainTexture.height, (float)mainTexture.width * mRect.width, (float)mainTexture.height * mRect.height);
			Rect mLMCPFJFELA = rect;
			Vector4 border = get_border();
			mLMCPFJFELA.xMin += border.x;
			mLMCPFJFELA.yMin += border.y;
			mLMCPFJFELA.xMax -= border.z;
			mLMCPFJFELA.yMax -= border.w;
			float num = 785f / (float)mainTexture.width;
			float num2 = 252f / (float)mainTexture.height;
			rect.xMin *= num;
			rect.xMax *= num;
			rect.yMin *= num2;
			rect.yMax *= num2;
			mLMCPFJFELA.xMin *= num;
			mLMCPFJFELA.xMax *= num;
			mLMCPFJFELA.yMin *= num2;
			mLMCPFJFELA.yMax *= num2;
			ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, rect, mLMCPFJFELA);
		}
	}

	public virtual void BKLGGDJGFEG(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null))
		{
			Rect rect = new Rect(mRect.x * (float)mainTexture.width, mRect.y * (float)mainTexture.height, (float)mainTexture.width * mRect.width, (float)mainTexture.height * mRect.height);
			Rect mLMCPFJFELA = rect;
			Vector4 border = get_border();
			mLMCPFJFELA.xMin += border.x;
			mLMCPFJFELA.yMin += border.y;
			mLMCPFJFELA.xMax -= border.z;
			mLMCPFJFELA.yMax -= border.w;
			float num = 663f / (float)mainTexture.width;
			float num2 = 1464f / (float)mainTexture.height;
			rect.xMin *= num;
			rect.xMax *= num;
			rect.yMin *= num2;
			rect.yMax *= num2;
			mLMCPFJFELA.xMin *= num;
			mLMCPFJFELA.xMax *= num;
			mLMCPFJFELA.yMin *= num2;
			mLMCPFJFELA.yMax *= num2;
			ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, rect, mLMCPFJFELA);
		}
	}

	public override Texture get_mainTexture()
	{
		if (mTexture != null)
		{
			return mTexture;
		}
		if (mMat != null)
		{
			return mMat.mainTexture;
		}
		return null;
	}

	[SpecialName]
	public virtual void BHDHIAJGECL(Vector4 ICENKPDOHBK)
	{
		if (mBorder != ICENKPDOHBK)
		{
			mBorder = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public override void set_material(Material ICENKPDOHBK)
	{
		if (mMat != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mShader = null;
			mMat = ICENKPDOHBK;
			MJIKPDACEDJ = -1;
			MarkAsChanged();
		}
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
			int num = mainTexture.width;
			int num2 = mainTexture.height;
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

	public void set_uvRect(Rect ICENKPDOHBK)
	{
		if (mRect != ICENKPDOHBK)
		{
			mRect = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	[SpecialName]
	public virtual Shader FLGJAKFFHKG()
	{
		if (mMat != null)
		{
			return mMat.shader;
		}
		if (mShader == null)
		{
			mShader = Shader.Find("skill0");
		}
		return mShader;
	}

	public override Vector4 get_border()
	{
		return mBorder;
	}
}
