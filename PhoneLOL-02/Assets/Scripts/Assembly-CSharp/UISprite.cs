using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Sprite")]
[ExecuteInEditMode]
public class UISprite : UIBasicSprite
{
	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private string mSpriteName;

	[NonSerialized]
	private bool ODJKOAIGPNK;

	[NonSerialized]
	private bool GFEAFCEOHJM;

	[SerializeField]
	[HideInInspector]
	private bool mFillCenter = true;

	[NonSerialized]
	protected UISpriteData MCOKEKMANAF;

	[NonSerialized]
	private bool PJNAEEDMJFD;

	public override Material BJJILBPBOGP
	{
		get
		{
			return get_material();
		}
	}

	public UIAtlas FONGKNFGOBM
	{
		get
		{
			return get_atlas();
		}
		set
		{
			set_atlas(value);
		}
	}

	public string ADNCNHHHCBF
	{
		get
		{
			return get_spriteName();
		}
		set
		{
			set_spriteName(value);
		}
	}

	public bool GLCGAIAPPKO
	{
		get
		{
			return get_isValid();
		}
	}

	[Obsolete("Use 'centerType' instead")]
	public bool PEPOJJAJDIB
	{
		get
		{
			return get_fillCenter();
		}
		set
		{
			set_fillCenter(value);
		}
	}

	public override Vector4 PCPJPDGKIMC
	{
		get
		{
			return get_border();
		}
	}

	public override float EMNCDBEHHLO
	{
		get
		{
			return get_pixelSize();
		}
	}

	public override int AAHPICGBDMF
	{
		get
		{
			return get_minWidth();
		}
	}

	public override int MNMJMJPFNMA
	{
		get
		{
			return get_minHeight();
		}
	}

	public override Vector4 KJGNCIJHNCN
	{
		get
		{
			return get_drawingDimensions();
		}
	}

	public override bool BFKOPLGFIIF
	{
		get
		{
			return get_premultipliedAlpha();
		}
	}

	public UISpriteData GetAtlasSprite()
	{
		if (!PJNAEEDMJFD)
		{
			MCOKEKMANAF = null;
		}
		if (MCOKEKMANAF == null && mAtlas != null)
		{
			if (!string.IsNullOrEmpty(mSpriteName))
			{
				UISpriteData sprite = mAtlas.GetSprite(mSpriteName);
				if (sprite == null)
				{
					return null;
				}
				GJMDOGPDEKF(sprite);
			}
			if (MCOKEKMANAF == null && mAtlas.get_spriteList().Count > 0)
			{
				UISpriteData uISpriteData = mAtlas.get_spriteList()[0];
				if (uISpriteData == null)
				{
					return null;
				}
				GJMDOGPDEKF(uISpriteData);
				if (MCOKEKMANAF == null)
				{
					Debug.LogError(mAtlas.name + " seems to have a null sprite!");
					return null;
				}
				mSpriteName = MCOKEKMANAF.name;
			}
		}
		return MCOKEKMANAF;
	}

	public override void OnFill(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null))
		{
			if (MCOKEKMANAF == null)
			{
				MCOKEKMANAF = get_atlas().GetSprite(get_spriteName());
			}
			if (MCOKEKMANAF != null)
			{
				Rect hGMPLGNJEPC = new Rect(MCOKEKMANAF.x, MCOKEKMANAF.y, MCOKEKMANAF.width, MCOKEKMANAF.height);
				Rect hGMPLGNJEPC2 = new Rect(MCOKEKMANAF.x + MCOKEKMANAF.borderLeft, MCOKEKMANAF.y + MCOKEKMANAF.borderTop, MCOKEKMANAF.width - MCOKEKMANAF.borderLeft - MCOKEKMANAF.borderRight, MCOKEKMANAF.height - MCOKEKMANAF.borderBottom - MCOKEKMANAF.borderTop);
				hGMPLGNJEPC = HHAINCPODGE.KOAAFAOHINH(hGMPLGNJEPC, mainTexture.width, mainTexture.height);
				hGMPLGNJEPC2 = HHAINCPODGE.KOAAFAOHINH(hGMPLGNJEPC2, mainTexture.width, mainTexture.height);
				ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, hGMPLGNJEPC, hGMPLGNJEPC2);
			}
		}
	}

	[SpecialName]
	public string DCLPIGEEKNF()
	{
		return mSpriteName;
	}

	public void set_fillCenter(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK != (centerType != LEMAHCPEPAC.Invisible))
		{
			centerType = (ICENKPDOHBK ? LEMAHCPEPAC.Sliced : LEMAHCPEPAC.Invisible);
			MarkAsChanged();
		}
	}

	public override Material get_material()
	{
		if (mAtlas == null)
		{
			return null;
		}
		if (ODJKOAIGPNK)
		{
			return mAtlas.get_spriteMaterialGrayscale();
		}
		if (GFEAFCEOHJM)
		{
			return mAtlas.get_spriteMaterialBright();
		}
		return mAtlas.get_spriteMaterial();
	}

	public string get_spriteName()
	{
		return mSpriteName;
	}

	protected void GJMDOGPDEKF(UISpriteData NBEPJPOEBBE)
	{
		DJAFKDJINKI = true;
		PJNAEEDMJFD = true;
		if (NBEPJPOEBBE != null)
		{
			MCOKEKMANAF = NBEPJPOEBBE;
			mSpriteName = MCOKEKMANAF.name;
		}
		else
		{
			mSpriteName = ((MCOKEKMANAF == null) ? string.Empty : MCOKEKMANAF.name);
			MCOKEKMANAF = NBEPJPOEBBE;
		}
	}

	protected override void OHHOHFAGBBF()
	{
		if (!mFillCenter)
		{
			mFillCenter = true;
			centerType = LEMAHCPEPAC.Invisible;
		}
		base.OHHOHFAGBBF();
	}

	protected virtual void JNEAHJDJDOC()
	{
		base.DPILNPAPPKI();
		if (DJAFKDJINKI || !PJNAEEDMJFD)
		{
			PJNAEEDMJFD = false;
			MCOKEKMANAF = null;
			DJAFKDJINKI = true;
		}
	}

	[SpecialName]
	public void PPCGFFNNAMM(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK != (centerType == LEMAHCPEPAC.Sliced))
		{
			centerType = (ICENKPDOHBK ? LEMAHCPEPAC.Sliced : LEMAHCPEPAC.Invisible);
			MarkAsChanged();
		}
	}

	public void JPHCEKGPNBP(bool AGFFBCBPNGO)
	{
		if (ODJKOAIGPNK != AGFFBCBPNGO)
		{
			ODJKOAIGPNK = AGFFBCBPNGO;
			if (panel != null)
			{
				panel.GOPIMFGKDGK();
			}
		}
	}

	public override float get_pixelSize()
	{
		return (!(mAtlas != null)) ? 1f : mAtlas.get_pixelSize();
	}

	public override Vector4 get_drawingDimensions()
	{
		Vector2 pivotOffset = get_pivotOffset();
		float num = (0f - pivotOffset.x) * (float)mWidth;
		float num2 = (0f - pivotOffset.y) * (float)mHeight;
		float num3 = num + (float)mWidth;
		float num4 = num2 + (float)mHeight;
		if (GetAtlasSprite() != null && mType != ACPICCBBPHF.Tiled)
		{
			int paddingLeft = MCOKEKMANAF.paddingLeft;
			int paddingBottom = MCOKEKMANAF.paddingBottom;
			int num5 = MCOKEKMANAF.paddingRight;
			int num6 = MCOKEKMANAF.paddingTop;
			int num7 = MCOKEKMANAF.width + paddingLeft + num5;
			int num8 = MCOKEKMANAF.height + paddingBottom + num6;
			float num9 = 1f;
			float num10 = 1f;
			if (num7 > 0 && num8 > 0 && (mType == ACPICCBBPHF.Simple || mType == ACPICCBBPHF.Filled))
			{
				if ((num7 & 1) != 0)
				{
					num5++;
				}
				if ((num8 & 1) != 0)
				{
					num6++;
				}
				num9 = 1f / (float)num7 * (float)mWidth;
				num10 = 1f / (float)num8 * (float)mHeight;
			}
			if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == CBLHIOGKJNK.Both)
			{
				num += (float)num5 * num9;
				num3 -= (float)paddingLeft * num9;
			}
			else
			{
				num += (float)paddingLeft * num9;
				num3 -= (float)num5 * num9;
			}
			if (mFlip == CBLHIOGKJNK.Vertically || mFlip == CBLHIOGKJNK.Both)
			{
				num2 += (float)num6 * num10;
				num4 -= (float)paddingBottom * num10;
			}
			else
			{
				num2 += (float)paddingBottom * num10;
				num4 -= (float)num6 * num10;
			}
		}
		Vector4 vector = ((!(mAtlas != null)) ? Vector4.zero : (get_border() * get_pixelSize()));
		float num11 = vector.x + vector.z;
		float num12 = vector.y + vector.w;
		float x = Mathf.Lerp(num, num3 - num11, IGHALEOANNP.x);
		float y = Mathf.Lerp(num2, num4 - num12, IGHALEOANNP.y);
		float z = Mathf.Lerp(num + num11, num3, IGHALEOANNP.z);
		float w = Mathf.Lerp(num2 + num12, num4, IGHALEOANNP.w);
		return new Vector4(x, y, z, w);
	}

	[SpecialName]
	public virtual int FCEGFMABFEE()
	{
		if (get_type() == ACPICCBBPHF.Simple || get_type() == ACPICCBBPHF.Sliced)
		{
			Vector4 vector = EMIMKJCFBNB() * get_pixelSize();
			int num = Mathf.RoundToInt(vector.y + vector.w);
			UISpriteData atlasSprite = GetAtlasSprite();
			if (atlasSprite != null)
			{
				num += atlasSprite.paddingTop + atlasSprite.paddingBottom;
			}
			return Mathf.Max(base.get_minHeight(), ((num & 1) != 0) ? num : (num + 1));
		}
		return base.get_minHeight();
	}

	public UISpriteData GJKAIBDBCFN()
	{
		if (!PJNAEEDMJFD)
		{
			MCOKEKMANAF = null;
		}
		if (MCOKEKMANAF == null && mAtlas != null)
		{
			if (!string.IsNullOrEmpty(mSpriteName))
			{
				UISpriteData sprite = mAtlas.GetSprite(mSpriteName);
				if (sprite == null)
				{
					return null;
				}
				GJMDOGPDEKF(sprite);
			}
			if (MCOKEKMANAF == null && mAtlas.COIIMEBPGAC().Count > 1)
			{
				UISpriteData uISpriteData = mAtlas.ALLEIEBCPGK()[1];
				if (uISpriteData == null)
				{
					return null;
				}
				NIMMHLFPDAE(uISpriteData);
				if (MCOKEKMANAF == null)
				{
					Debug.LogError(mAtlas.name + ".");
					return null;
				}
				mSpriteName = MCOKEKMANAF.name;
			}
		}
		return MCOKEKMANAF;
	}

	public void Bright(bool AFNHLKGKGJN)
	{
		GFEAFCEOHJM = AFNHLKGKGJN;
		if (panel != null)
		{
			panel.RebuildAllDrawCalls();
		}
	}

	public override Vector4 get_border()
	{
		UISpriteData atlasSprite = GetAtlasSprite();
		if (atlasSprite == null)
		{
			return base.get_border();
		}
		return new Vector4(atlasSprite.borderLeft, atlasSprite.borderBottom, atlasSprite.borderRight, atlasSprite.borderTop);
	}

	public void set_atlas(UIAtlas ICENKPDOHBK)
	{
		if (mAtlas != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mAtlas = ICENKPDOHBK;
			PJNAEEDMJFD = false;
			MCOKEKMANAF = null;
			if (string.IsNullOrEmpty(mSpriteName) && mAtlas != null && mAtlas.get_spriteList().Count > 0)
			{
				GJMDOGPDEKF(mAtlas.get_spriteList()[0]);
				mSpriteName = MCOKEKMANAF.name;
			}
			if (!string.IsNullOrEmpty(mSpriteName))
			{
				string spriteName = mSpriteName;
				mSpriteName = string.Empty;
				set_spriteName(spriteName);
				MarkAsChanged();
			}
		}
	}

	public UIAtlas get_atlas()
	{
		return mAtlas;
	}

	[SpecialName]
	public virtual int KPKEKAKCLCC()
	{
		if (get_type() == ACPICCBBPHF.Sliced || get_type() == (ACPICCBBPHF)5)
		{
			Vector4 vector = EMIMKJCFBNB() * get_pixelSize();
			int num = Mathf.RoundToInt(vector.y + vector.w);
			UISpriteData uISpriteData = GJKAIBDBCFN();
			if (uISpriteData != null)
			{
				num += uISpriteData.paddingTop + uISpriteData.paddingBottom;
			}
			return Mathf.Max(base.get_minHeight(), ((num & 1) != 0) ? num : (num + 1));
		}
		return base.get_minHeight();
	}

	protected override void DPILNPAPPKI()
	{
		base.DPILNPAPPKI();
		if (DJAFKDJINKI || !PJNAEEDMJFD)
		{
			PJNAEEDMJFD = true;
			MCOKEKMANAF = null;
			DJAFKDJINKI = true;
		}
	}

	public void GrayScale(bool AGFFBCBPNGO)
	{
		if (ODJKOAIGPNK != AGFFBCBPNGO)
		{
			ODJKOAIGPNK = AGFFBCBPNGO;
			if (panel != null)
			{
				panel.RebuildAllDrawCalls();
			}
		}
	}

	public override void MakePixelPerfect()
	{
		if (!get_isValid())
		{
			return;
		}
		base.MakePixelPerfect();
		if (mType == ACPICCBBPHF.Tiled)
		{
			return;
		}
		UISpriteData atlasSprite = GetAtlasSprite();
		if (atlasSprite == null)
		{
			return;
		}
		Texture mainTexture = get_mainTexture();
		if (!(mainTexture == null) && (mType == ACPICCBBPHF.Simple || mType == ACPICCBBPHF.Filled || !atlasSprite.hasBorder) && mainTexture != null)
		{
			int num = Mathf.RoundToInt(get_pixelSize() * (float)(atlasSprite.width + atlasSprite.paddingLeft + atlasSprite.paddingRight));
			int num2 = Mathf.RoundToInt(get_pixelSize() * (float)(atlasSprite.height + atlasSprite.paddingTop + atlasSprite.paddingBottom));
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
	public string NJHDFNDHAAC()
	{
		return mSpriteName;
	}

	public void set_spriteName(string ICENKPDOHBK)
	{
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			if (!string.IsNullOrEmpty(mSpriteName))
			{
				mSpriteName = string.Empty;
				MCOKEKMANAF = null;
				DJAFKDJINKI = true;
				PJNAEEDMJFD = false;
			}
		}
		else if (mSpriteName != ICENKPDOHBK)
		{
			mSpriteName = ICENKPDOHBK;
			MCOKEKMANAF = null;
			DJAFKDJINKI = true;
			PJNAEEDMJFD = false;
		}
	}

	[SpecialName]
	public string FECKGIJOCFF()
	{
		return mSpriteName;
	}

	public override int get_minHeight()
	{
		if (get_type() == ACPICCBBPHF.Sliced || get_type() == ACPICCBBPHF.Advanced)
		{
			Vector4 vector = get_border() * get_pixelSize();
			int num = Mathf.RoundToInt(vector.y + vector.w);
			UISpriteData atlasSprite = GetAtlasSprite();
			if (atlasSprite != null)
			{
				num += atlasSprite.paddingTop + atlasSprite.paddingBottom;
			}
			return Mathf.Max(base.get_minHeight(), ((num & 1) != 1) ? num : (num + 1));
		}
		return base.get_minHeight();
	}

	[SpecialName]
	public void NGBDKOENLNI(UIAtlas ICENKPDOHBK)
	{
		if (mAtlas != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mAtlas = ICENKPDOHBK;
			PJNAEEDMJFD = false;
			MCOKEKMANAF = null;
			if (string.IsNullOrEmpty(mSpriteName) && mAtlas != null && mAtlas.ALLEIEBCPGK().Count > 0)
			{
				GJMDOGPDEKF(mAtlas.COIIMEBPGAC()[0]);
				mSpriteName = MCOKEKMANAF.name;
			}
			if (!string.IsNullOrEmpty(mSpriteName))
			{
				string spriteName = mSpriteName;
				mSpriteName = string.Empty;
				set_spriteName(spriteName);
				MarkAsChanged();
			}
		}
	}

	[SpecialName]
	public string FFPPLGDLPIF()
	{
		return mSpriteName;
	}

	protected void NIMMHLFPDAE(UISpriteData NBEPJPOEBBE)
	{
		DJAFKDJINKI = true;
		PJNAEEDMJFD = false;
		if (NBEPJPOEBBE != null)
		{
			MCOKEKMANAF = NBEPJPOEBBE;
			mSpriteName = MCOKEKMANAF.name;
		}
		else
		{
			mSpriteName = ((MCOKEKMANAF == null) ? string.Empty : MCOKEKMANAF.name);
			MCOKEKMANAF = NBEPJPOEBBE;
		}
	}

	public override bool get_premultipliedAlpha()
	{
		return mAtlas != null && mAtlas.get_premultipliedAlpha();
	}

	[SpecialName]
	public virtual bool JFOMHGEEEKE()
	{
		return mAtlas != null && mAtlas.get_premultipliedAlpha();
	}

	public override int get_minWidth()
	{
		if (get_type() == ACPICCBBPHF.Sliced || get_type() == ACPICCBBPHF.Advanced)
		{
			Vector4 vector = get_border() * get_pixelSize();
			int num = Mathf.RoundToInt(vector.x + vector.z);
			UISpriteData atlasSprite = GetAtlasSprite();
			if (atlasSprite != null)
			{
				num += atlasSprite.paddingLeft + atlasSprite.paddingRight;
			}
			return Mathf.Max(base.get_minWidth(), ((num & 1) != 1) ? num : (num + 1));
		}
		return base.get_minWidth();
	}

	public bool get_isValid()
	{
		return GetAtlasSprite() != null;
	}

	public bool get_fillCenter()
	{
		return centerType != LEMAHCPEPAC.Invisible;
	}

	[SpecialName]
	public virtual Vector4 EMIMKJCFBNB()
	{
		UISpriteData uISpriteData = GJKAIBDBCFN();
		if (uISpriteData == null)
		{
			return base.get_border();
		}
		return new Vector4(uISpriteData.borderLeft, uISpriteData.borderBottom, uISpriteData.borderRight, uISpriteData.borderTop);
	}
}
