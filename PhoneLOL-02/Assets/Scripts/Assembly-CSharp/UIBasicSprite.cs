using System;
using UnityEngine;

public abstract class UIBasicSprite : UIWidget
{
	public enum ACPICCBBPHF
	{
		Simple = 0,
		Sliced = 1,
		Tiled = 2,
		Filled = 3,
		Advanced = 4
	}

	public enum HHBEDIACMLI
	{
		Horizontal = 0,
		Vertical = 1,
		Radial90 = 2,
		Radial180 = 3,
		Radial360 = 4
	}

	public enum LEMAHCPEPAC
	{
		Invisible = 0,
		Sliced = 1,
		Tiled = 2
	}

	public enum CBLHIOGKJNK
	{
		Nothing = 0,
		Horizontally = 1,
		Vertically = 2,
		Both = 3
	}

	[HideInInspector]
	[SerializeField]
	protected ACPICCBBPHF mType;

	[HideInInspector]
	[SerializeField]
	protected HHBEDIACMLI mFillDirection = HHBEDIACMLI.Radial360;

	[Range(0f, 1f)]
	[HideInInspector]
	[SerializeField]
	protected float mFillAmount = 1f;

	[SerializeField]
	[HideInInspector]
	protected bool mInvert;

	[SerializeField]
	[HideInInspector]
	protected CBLHIOGKJNK mFlip;

	[NonSerialized]
	private Rect FJBCHKOOFOG = default(Rect);

	[NonSerialized]
	private Rect BBLOLGMFAGG = default(Rect);

	public LEMAHCPEPAC centerType = LEMAHCPEPAC.Sliced;

	public LEMAHCPEPAC leftType = LEMAHCPEPAC.Sliced;

	public LEMAHCPEPAC rightType = LEMAHCPEPAC.Sliced;

	public LEMAHCPEPAC bottomType = LEMAHCPEPAC.Sliced;

	public LEMAHCPEPAC topType = LEMAHCPEPAC.Sliced;

	protected static Vector2[] OOMHOPLNPEI = new Vector2[4];

	protected static Vector2[] HBCIFGJPMNA = new Vector2[4];

	public virtual ACPICCBBPHF FBAGNJILEGD
	{
		get
		{
			return get_type();
		}
		set
		{
			set_type(value);
		}
	}

	public CBLHIOGKJNK JLMOBACBFGP
	{
		get
		{
			return get_flip();
		}
		set
		{
			set_flip(value);
		}
	}

	public HHBEDIACMLI CJBCPDCBENL
	{
		get
		{
			return get_fillDirection();
		}
		set
		{
			set_fillDirection(value);
		}
	}

	public float FEMGOFONNML
	{
		get
		{
			return get_fillAmount();
		}
		set
		{
			set_fillAmount(value);
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

	public bool DIMPJENACIL
	{
		get
		{
			return get_invert();
		}
		set
		{
			set_invert(value);
		}
	}

	public bool LCMDMKCCGCO
	{
		get
		{
			return get_hasBorder();
		}
	}

	public virtual bool BFKOPLGFIIF
	{
		get
		{
			return get_premultipliedAlpha();
		}
	}

	public virtual float EMNCDBEHHLO
	{
		get
		{
			return get_pixelSize();
		}
	}

	private Vector4 BGKGDOKGKFN
	{
		get
		{
			return HMOPLMONHKH();
		}
	}

	private Color32 FHMFODACDEC
	{
		get
		{
			return BHOHJEINJOD();
		}
	}

	public virtual ACPICCBBPHF get_type()
	{
		return mType;
	}

	public virtual void set_type(ACPICCBBPHF ICENKPDOHBK)
	{
		if (mType != ICENKPDOHBK)
		{
			mType = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public CBLHIOGKJNK get_flip()
	{
		return mFlip;
	}

	public void set_flip(CBLHIOGKJNK ICENKPDOHBK)
	{
		if (mFlip != ICENKPDOHBK)
		{
			mFlip = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public HHBEDIACMLI get_fillDirection()
	{
		return mFillDirection;
	}

	public void set_fillDirection(HHBEDIACMLI ICENKPDOHBK)
	{
		if (mFillDirection != ICENKPDOHBK)
		{
			mFillDirection = ICENKPDOHBK;
			DJAFKDJINKI = true;
		}
	}

	public float get_fillAmount()
	{
		return mFillAmount;
	}

	public void set_fillAmount(float ICENKPDOHBK)
	{
		float num = Mathf.Clamp01(ICENKPDOHBK);
		if (mFillAmount != num)
		{
			mFillAmount = num;
			DJAFKDJINKI = true;
		}
	}

	public override int get_minWidth()
	{
		if (get_type() == ACPICCBBPHF.Sliced || get_type() == ACPICCBBPHF.Advanced)
		{
			Vector4 vector = get_border() * get_pixelSize();
			int num = Mathf.RoundToInt(vector.x + vector.z);
			return Mathf.Max(base.get_minWidth(), ((num & 1) != 1) ? num : (num + 1));
		}
		return base.get_minWidth();
	}

	public override int get_minHeight()
	{
		if (get_type() == ACPICCBBPHF.Sliced || get_type() == ACPICCBBPHF.Advanced)
		{
			Vector4 vector = get_border() * get_pixelSize();
			int num = Mathf.RoundToInt(vector.y + vector.w);
			return Mathf.Max(base.get_minHeight(), ((num & 1) != 1) ? num : (num + 1));
		}
		return base.get_minHeight();
	}

	public bool get_invert()
	{
		return mInvert;
	}

	public void set_invert(bool ICENKPDOHBK)
	{
		if (mInvert != ICENKPDOHBK)
		{
			mInvert = ICENKPDOHBK;
			DJAFKDJINKI = true;
		}
	}

	public bool get_hasBorder()
	{
		Vector4 border = get_border();
		return border.x != 0f || border.y != 0f || border.z != 0f || border.w != 0f;
	}

	public virtual bool get_premultipliedAlpha()
	{
		return false;
	}

	public virtual float get_pixelSize()
	{
		return 1f;
	}

	private Vector4 HMOPLMONHKH()
	{
		switch (mFlip)
		{
		case CBLHIOGKJNK.Horizontally:
			return new Vector4(BBLOLGMFAGG.xMax, BBLOLGMFAGG.yMin, BBLOLGMFAGG.xMin, BBLOLGMFAGG.yMax);
		case CBLHIOGKJNK.Vertically:
			return new Vector4(BBLOLGMFAGG.xMin, BBLOLGMFAGG.yMax, BBLOLGMFAGG.xMax, BBLOLGMFAGG.yMin);
		case CBLHIOGKJNK.Both:
			return new Vector4(BBLOLGMFAGG.xMax, BBLOLGMFAGG.yMax, BBLOLGMFAGG.xMin, BBLOLGMFAGG.yMin);
		default:
			return new Vector4(BBLOLGMFAGG.xMin, BBLOLGMFAGG.yMin, BBLOLGMFAGG.xMax, BBLOLGMFAGG.yMax);
		}
	}

	private Color32 BHOHJEINJOD()
	{
		Color color = get_color();
		color.a = finalAlpha;
		return (!get_premultipliedAlpha()) ? color : NLDABIMKKMP.CPFGKGLEIKJ(color);
	}

	protected void ADLMDIBJIIL(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP, Rect LJGIGDNFPGK, Rect MLMCPFJFELA)
	{
		BBLOLGMFAGG = LJGIGDNFPGK;
		FJBCHKOOFOG = MLMCPFJFELA;
		switch (get_type())
		{
		case ACPICCBBPHF.Simple:
			CDCONFHIGKM(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
			break;
		case ACPICCBBPHF.Sliced:
			OEPAIBGAPML(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
			break;
		case ACPICCBBPHF.Filled:
			JAHKIAOJBHC(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
			break;
		case ACPICCBBPHF.Tiled:
			PBEEHMNHNAH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
			break;
		case ACPICCBBPHF.Advanced:
			PCMBMJNADEG(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
			break;
		}
	}

	private void CDCONFHIGKM(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Vector4 drawingDimensions = get_drawingDimensions();
		Vector4 vector = HMOPLMONHKH();
		Color32 hBIPOCDNMCB = BHOHJEINJOD();
		HILIICKOOFH.GBFCKODJEGE(new Vector3(drawingDimensions.x, drawingDimensions.y));
		HILIICKOOFH.GBFCKODJEGE(new Vector3(drawingDimensions.x, drawingDimensions.w));
		HILIICKOOFH.GBFCKODJEGE(new Vector3(drawingDimensions.z, drawingDimensions.w));
		HILIICKOOFH.GBFCKODJEGE(new Vector3(drawingDimensions.z, drawingDimensions.y));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(vector.x, vector.y));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(vector.x, vector.w));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(vector.z, vector.w));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(vector.z, vector.y));
		NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
		NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
		NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
		NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
	}

	private void OEPAIBGAPML(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Vector4 vector = get_border() * get_pixelSize();
		if (vector.x == 0f && vector.y == 0f && vector.z == 0f && vector.w == 0f)
		{
			CDCONFHIGKM(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
			return;
		}
		Color32 hBIPOCDNMCB = BHOHJEINJOD();
		Vector4 drawingDimensions = get_drawingDimensions();
		OOMHOPLNPEI[0].x = drawingDimensions.x;
		OOMHOPLNPEI[0].y = drawingDimensions.y;
		OOMHOPLNPEI[3].x = drawingDimensions.z;
		OOMHOPLNPEI[3].y = drawingDimensions.w;
		if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == CBLHIOGKJNK.Both)
		{
			OOMHOPLNPEI[1].x = OOMHOPLNPEI[0].x + vector.z;
			OOMHOPLNPEI[2].x = OOMHOPLNPEI[3].x - vector.x;
			HBCIFGJPMNA[3].x = BBLOLGMFAGG.xMin;
			HBCIFGJPMNA[2].x = FJBCHKOOFOG.xMin;
			HBCIFGJPMNA[1].x = FJBCHKOOFOG.xMax;
			HBCIFGJPMNA[0].x = BBLOLGMFAGG.xMax;
		}
		else
		{
			OOMHOPLNPEI[1].x = OOMHOPLNPEI[0].x + vector.x;
			OOMHOPLNPEI[2].x = OOMHOPLNPEI[3].x - vector.z;
			HBCIFGJPMNA[0].x = BBLOLGMFAGG.xMin;
			HBCIFGJPMNA[1].x = FJBCHKOOFOG.xMin;
			HBCIFGJPMNA[2].x = FJBCHKOOFOG.xMax;
			HBCIFGJPMNA[3].x = BBLOLGMFAGG.xMax;
		}
		if (mFlip == CBLHIOGKJNK.Vertically || mFlip == CBLHIOGKJNK.Both)
		{
			OOMHOPLNPEI[1].y = OOMHOPLNPEI[0].y + vector.w;
			OOMHOPLNPEI[2].y = OOMHOPLNPEI[3].y - vector.y;
			HBCIFGJPMNA[3].y = BBLOLGMFAGG.yMin;
			HBCIFGJPMNA[2].y = FJBCHKOOFOG.yMin;
			HBCIFGJPMNA[1].y = FJBCHKOOFOG.yMax;
			HBCIFGJPMNA[0].y = BBLOLGMFAGG.yMax;
		}
		else
		{
			OOMHOPLNPEI[1].y = OOMHOPLNPEI[0].y + vector.y;
			OOMHOPLNPEI[2].y = OOMHOPLNPEI[3].y - vector.w;
			HBCIFGJPMNA[0].y = BBLOLGMFAGG.yMin;
			HBCIFGJPMNA[1].y = FJBCHKOOFOG.yMin;
			HBCIFGJPMNA[2].y = FJBCHKOOFOG.yMax;
			HBCIFGJPMNA[3].y = BBLOLGMFAGG.yMax;
		}
		for (int i = 0; i < 3; i++)
		{
			int num = i + 1;
			for (int j = 0; j < 3; j++)
			{
				if (centerType != LEMAHCPEPAC.Invisible || i != 1 || j != 1)
				{
					int num2 = j + 1;
					HILIICKOOFH.GBFCKODJEGE(new Vector3(OOMHOPLNPEI[i].x, OOMHOPLNPEI[j].y));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(OOMHOPLNPEI[i].x, OOMHOPLNPEI[num2].y));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(OOMHOPLNPEI[num].x, OOMHOPLNPEI[num2].y));
					HILIICKOOFH.GBFCKODJEGE(new Vector3(OOMHOPLNPEI[num].x, OOMHOPLNPEI[j].y));
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(HBCIFGJPMNA[i].x, HBCIFGJPMNA[j].y));
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(HBCIFGJPMNA[i].x, HBCIFGJPMNA[num2].y));
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(HBCIFGJPMNA[num].x, HBCIFGJPMNA[num2].y));
					MDBIEMHCFFO.GBFCKODJEGE(new Vector2(HBCIFGJPMNA[num].x, HBCIFGJPMNA[j].y));
					NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
					NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
					NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
					NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
				}
			}
		}
	}

	private void PBEEHMNHNAH(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Texture mainTexture = get_mainTexture();
		if (mainTexture == null)
		{
			return;
		}
		Vector2 vector = new Vector2(FJBCHKOOFOG.width * (float)mainTexture.width, FJBCHKOOFOG.height * (float)mainTexture.height);
		vector *= get_pixelSize();
		if (mainTexture == null || vector.x < 2f || vector.y < 2f)
		{
			return;
		}
		Color32 hBIPOCDNMCB = BHOHJEINJOD();
		Vector4 drawingDimensions = get_drawingDimensions();
		Vector4 vector2 = default(Vector4);
		if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == CBLHIOGKJNK.Both)
		{
			vector2.x = FJBCHKOOFOG.xMax;
			vector2.z = FJBCHKOOFOG.xMin;
		}
		else
		{
			vector2.x = FJBCHKOOFOG.xMin;
			vector2.z = FJBCHKOOFOG.xMax;
		}
		if (mFlip == CBLHIOGKJNK.Vertically || mFlip == CBLHIOGKJNK.Both)
		{
			vector2.y = FJBCHKOOFOG.yMax;
			vector2.w = FJBCHKOOFOG.yMin;
		}
		else
		{
			vector2.y = FJBCHKOOFOG.yMin;
			vector2.w = FJBCHKOOFOG.yMax;
		}
		float x = drawingDimensions.x;
		float num = drawingDimensions.y;
		float x2 = vector2.x;
		float y = vector2.y;
		for (; num < drawingDimensions.w; num += vector.y)
		{
			x = drawingDimensions.x;
			float num2 = num + vector.y;
			float y2 = vector2.w;
			if (num2 > drawingDimensions.w)
			{
				y2 = Mathf.Lerp(vector2.y, vector2.w, (drawingDimensions.w - num) / vector.y);
				num2 = drawingDimensions.w;
			}
			for (; x < drawingDimensions.z; x += vector.x)
			{
				float num3 = x + vector.x;
				float x3 = vector2.z;
				if (num3 > drawingDimensions.z)
				{
					x3 = Mathf.Lerp(vector2.x, vector2.z, (drawingDimensions.z - x) / vector.x);
					num3 = drawingDimensions.z;
				}
				HILIICKOOFH.GBFCKODJEGE(new Vector3(x, num));
				HILIICKOOFH.GBFCKODJEGE(new Vector3(x, num2));
				HILIICKOOFH.GBFCKODJEGE(new Vector3(num3, num2));
				HILIICKOOFH.GBFCKODJEGE(new Vector3(num3, num));
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x2, y));
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x2, y2));
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x3, y2));
				MDBIEMHCFFO.GBFCKODJEGE(new Vector2(x3, y));
				NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
				NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
				NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
				NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
			}
		}
	}

	private void JAHKIAOJBHC(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		if (mFillAmount < 0.001f)
		{
			return;
		}
		Vector4 drawingDimensions = get_drawingDimensions();
		Vector4 vector = HMOPLMONHKH();
		Color32 hBIPOCDNMCB = BHOHJEINJOD();
		if (mFillDirection == HHBEDIACMLI.Horizontal || mFillDirection == HHBEDIACMLI.Vertical)
		{
			if (mFillDirection == HHBEDIACMLI.Horizontal)
			{
				float num = (vector.z - vector.x) * mFillAmount;
				if (mInvert)
				{
					drawingDimensions.x = drawingDimensions.z - (drawingDimensions.z - drawingDimensions.x) * mFillAmount;
					vector.x = vector.z - num;
				}
				else
				{
					drawingDimensions.z = drawingDimensions.x + (drawingDimensions.z - drawingDimensions.x) * mFillAmount;
					vector.z = vector.x + num;
				}
			}
			else if (mFillDirection == HHBEDIACMLI.Vertical)
			{
				float num2 = (vector.w - vector.y) * mFillAmount;
				if (mInvert)
				{
					drawingDimensions.y = drawingDimensions.w - (drawingDimensions.w - drawingDimensions.y) * mFillAmount;
					vector.y = vector.w - num2;
				}
				else
				{
					drawingDimensions.w = drawingDimensions.y + (drawingDimensions.w - drawingDimensions.y) * mFillAmount;
					vector.w = vector.y + num2;
				}
			}
		}
		OOMHOPLNPEI[0] = new Vector2(drawingDimensions.x, drawingDimensions.y);
		OOMHOPLNPEI[1] = new Vector2(drawingDimensions.x, drawingDimensions.w);
		OOMHOPLNPEI[2] = new Vector2(drawingDimensions.z, drawingDimensions.w);
		OOMHOPLNPEI[3] = new Vector2(drawingDimensions.z, drawingDimensions.y);
		HBCIFGJPMNA[0] = new Vector2(vector.x, vector.y);
		HBCIFGJPMNA[1] = new Vector2(vector.x, vector.w);
		HBCIFGJPMNA[2] = new Vector2(vector.z, vector.w);
		HBCIFGJPMNA[3] = new Vector2(vector.z, vector.y);
		if (mFillAmount < 1f)
		{
			if (mFillDirection == HHBEDIACMLI.Radial90)
			{
				if (AJIKOIPCLGA(OOMHOPLNPEI, HBCIFGJPMNA, mFillAmount, mInvert, 0))
				{
					for (int i = 0; i < 4; i++)
					{
						HILIICKOOFH.GBFCKODJEGE(OOMHOPLNPEI[i]);
						MDBIEMHCFFO.GBFCKODJEGE(HBCIFGJPMNA[i]);
						NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
					}
				}
				return;
			}
			if (mFillDirection == HHBEDIACMLI.Radial180)
			{
				for (int j = 0; j < 2; j++)
				{
					float t = 0f;
					float t2 = 1f;
					float t3;
					float t4;
					if (j == 0)
					{
						t3 = 0f;
						t4 = 0.5f;
					}
					else
					{
						t3 = 0.5f;
						t4 = 1f;
					}
					OOMHOPLNPEI[0].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, t3);
					OOMHOPLNPEI[1].x = OOMHOPLNPEI[0].x;
					OOMHOPLNPEI[2].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, t4);
					OOMHOPLNPEI[3].x = OOMHOPLNPEI[2].x;
					OOMHOPLNPEI[0].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, t);
					OOMHOPLNPEI[1].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, t2);
					OOMHOPLNPEI[2].y = OOMHOPLNPEI[1].y;
					OOMHOPLNPEI[3].y = OOMHOPLNPEI[0].y;
					HBCIFGJPMNA[0].x = Mathf.Lerp(vector.x, vector.z, t3);
					HBCIFGJPMNA[1].x = HBCIFGJPMNA[0].x;
					HBCIFGJPMNA[2].x = Mathf.Lerp(vector.x, vector.z, t4);
					HBCIFGJPMNA[3].x = HBCIFGJPMNA[2].x;
					HBCIFGJPMNA[0].y = Mathf.Lerp(vector.y, vector.w, t);
					HBCIFGJPMNA[1].y = Mathf.Lerp(vector.y, vector.w, t2);
					HBCIFGJPMNA[2].y = HBCIFGJPMNA[1].y;
					HBCIFGJPMNA[3].y = HBCIFGJPMNA[0].y;
					float value = (mInvert ? (mFillAmount * 2f - (float)(1 - j)) : (get_fillAmount() * 2f - (float)j));
					if (AJIKOIPCLGA(OOMHOPLNPEI, HBCIFGJPMNA, Mathf.Clamp01(value), !mInvert, HHAINCPODGE.FMIHOIEFOON(j + 3, 4)))
					{
						for (int k = 0; k < 4; k++)
						{
							HILIICKOOFH.GBFCKODJEGE(OOMHOPLNPEI[k]);
							MDBIEMHCFFO.GBFCKODJEGE(HBCIFGJPMNA[k]);
							NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
						}
					}
				}
				return;
			}
			if (mFillDirection == HHBEDIACMLI.Radial360)
			{
				for (int l = 0; l < 4; l++)
				{
					float t5;
					float t6;
					if (l < 2)
					{
						t5 = 0f;
						t6 = 0.5f;
					}
					else
					{
						t5 = 0.5f;
						t6 = 1f;
					}
					float t7;
					float t8;
					if (l == 0 || l == 3)
					{
						t7 = 0f;
						t8 = 0.5f;
					}
					else
					{
						t7 = 0.5f;
						t8 = 1f;
					}
					OOMHOPLNPEI[0].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, t5);
					OOMHOPLNPEI[1].x = OOMHOPLNPEI[0].x;
					OOMHOPLNPEI[2].x = Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, t6);
					OOMHOPLNPEI[3].x = OOMHOPLNPEI[2].x;
					OOMHOPLNPEI[0].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, t7);
					OOMHOPLNPEI[1].y = Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, t8);
					OOMHOPLNPEI[2].y = OOMHOPLNPEI[1].y;
					OOMHOPLNPEI[3].y = OOMHOPLNPEI[0].y;
					HBCIFGJPMNA[0].x = Mathf.Lerp(vector.x, vector.z, t5);
					HBCIFGJPMNA[1].x = HBCIFGJPMNA[0].x;
					HBCIFGJPMNA[2].x = Mathf.Lerp(vector.x, vector.z, t6);
					HBCIFGJPMNA[3].x = HBCIFGJPMNA[2].x;
					HBCIFGJPMNA[0].y = Mathf.Lerp(vector.y, vector.w, t7);
					HBCIFGJPMNA[1].y = Mathf.Lerp(vector.y, vector.w, t8);
					HBCIFGJPMNA[2].y = HBCIFGJPMNA[1].y;
					HBCIFGJPMNA[3].y = HBCIFGJPMNA[0].y;
					float value2 = ((!mInvert) ? (mFillAmount * 4f - (float)(3 - HHAINCPODGE.FMIHOIEFOON(l + 2, 4))) : (mFillAmount * 4f - (float)HHAINCPODGE.FMIHOIEFOON(l + 2, 4)));
					if (AJIKOIPCLGA(OOMHOPLNPEI, HBCIFGJPMNA, Mathf.Clamp01(value2), mInvert, HHAINCPODGE.FMIHOIEFOON(l + 2, 4)))
					{
						for (int m = 0; m < 4; m++)
						{
							HILIICKOOFH.GBFCKODJEGE(OOMHOPLNPEI[m]);
							MDBIEMHCFFO.GBFCKODJEGE(HBCIFGJPMNA[m]);
							NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
						}
					}
				}
				return;
			}
		}
		for (int n = 0; n < 4; n++)
		{
			HILIICKOOFH.GBFCKODJEGE(OOMHOPLNPEI[n]);
			MDBIEMHCFFO.GBFCKODJEGE(HBCIFGJPMNA[n]);
			NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB);
		}
	}

	private void PCMBMJNADEG(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		Texture mainTexture = get_mainTexture();
		if (mainTexture == null)
		{
			return;
		}
		Vector4 vector = get_border() * get_pixelSize();
		if (vector.x == 0f && vector.y == 0f && vector.z == 0f && vector.w == 0f)
		{
			CDCONFHIGKM(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
			return;
		}
		Color32 color = BHOHJEINJOD();
		Vector4 drawingDimensions = get_drawingDimensions();
		Vector2 vector2 = new Vector2(FJBCHKOOFOG.width * (float)mainTexture.width, FJBCHKOOFOG.height * (float)mainTexture.height);
		vector2 *= get_pixelSize();
		if (vector2.x < 1f)
		{
			vector2.x = 1f;
		}
		if (vector2.y < 1f)
		{
			vector2.y = 1f;
		}
		OOMHOPLNPEI[0].x = drawingDimensions.x;
		OOMHOPLNPEI[0].y = drawingDimensions.y;
		OOMHOPLNPEI[3].x = drawingDimensions.z;
		OOMHOPLNPEI[3].y = drawingDimensions.w;
		if (mFlip == CBLHIOGKJNK.Horizontally || mFlip == CBLHIOGKJNK.Both)
		{
			OOMHOPLNPEI[1].x = OOMHOPLNPEI[0].x + vector.z;
			OOMHOPLNPEI[2].x = OOMHOPLNPEI[3].x - vector.x;
			HBCIFGJPMNA[3].x = BBLOLGMFAGG.xMin;
			HBCIFGJPMNA[2].x = FJBCHKOOFOG.xMin;
			HBCIFGJPMNA[1].x = FJBCHKOOFOG.xMax;
			HBCIFGJPMNA[0].x = BBLOLGMFAGG.xMax;
		}
		else
		{
			OOMHOPLNPEI[1].x = OOMHOPLNPEI[0].x + vector.x;
			OOMHOPLNPEI[2].x = OOMHOPLNPEI[3].x - vector.z;
			HBCIFGJPMNA[0].x = BBLOLGMFAGG.xMin;
			HBCIFGJPMNA[1].x = FJBCHKOOFOG.xMin;
			HBCIFGJPMNA[2].x = FJBCHKOOFOG.xMax;
			HBCIFGJPMNA[3].x = BBLOLGMFAGG.xMax;
		}
		if (mFlip == CBLHIOGKJNK.Vertically || mFlip == CBLHIOGKJNK.Both)
		{
			OOMHOPLNPEI[1].y = OOMHOPLNPEI[0].y + vector.w;
			OOMHOPLNPEI[2].y = OOMHOPLNPEI[3].y - vector.y;
			HBCIFGJPMNA[3].y = BBLOLGMFAGG.yMin;
			HBCIFGJPMNA[2].y = FJBCHKOOFOG.yMin;
			HBCIFGJPMNA[1].y = FJBCHKOOFOG.yMax;
			HBCIFGJPMNA[0].y = BBLOLGMFAGG.yMax;
		}
		else
		{
			OOMHOPLNPEI[1].y = OOMHOPLNPEI[0].y + vector.y;
			OOMHOPLNPEI[2].y = OOMHOPLNPEI[3].y - vector.w;
			HBCIFGJPMNA[0].y = BBLOLGMFAGG.yMin;
			HBCIFGJPMNA[1].y = FJBCHKOOFOG.yMin;
			HBCIFGJPMNA[2].y = FJBCHKOOFOG.yMax;
			HBCIFGJPMNA[3].y = BBLOLGMFAGG.yMax;
		}
		for (int i = 0; i < 3; i++)
		{
			int num = i + 1;
			for (int j = 0; j < 3; j++)
			{
				if (centerType == LEMAHCPEPAC.Invisible && i == 1 && j == 1)
				{
					continue;
				}
				int num2 = j + 1;
				if (i == 1 && j == 1)
				{
					if (centerType == LEMAHCPEPAC.Tiled)
					{
						float x = OOMHOPLNPEI[i].x;
						float x2 = OOMHOPLNPEI[num].x;
						float y = OOMHOPLNPEI[j].y;
						float y2 = OOMHOPLNPEI[num2].y;
						float x3 = HBCIFGJPMNA[i].x;
						float y3 = HBCIFGJPMNA[j].y;
						for (float num3 = y; num3 < y2; num3 += vector2.y)
						{
							float num4 = x;
							float num5 = HBCIFGJPMNA[num2].y;
							float num6 = num3 + vector2.y;
							if (num6 > y2)
							{
								num5 = Mathf.Lerp(y3, num5, (y2 - num3) / vector2.y);
								num6 = y2;
							}
							for (; num4 < x2; num4 += vector2.x)
							{
								float num7 = num4 + vector2.x;
								float num8 = HBCIFGJPMNA[num].x;
								if (num7 > x2)
								{
									num8 = Mathf.Lerp(x3, num8, (x2 - num4) / vector2.x);
									num7 = x2;
								}
								ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, num4, num7, num3, num6, x3, num8, y3, num5, color);
							}
						}
					}
					else if (centerType == LEMAHCPEPAC.Sliced)
					{
						ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, OOMHOPLNPEI[i].x, OOMHOPLNPEI[num].x, OOMHOPLNPEI[j].y, OOMHOPLNPEI[num2].y, HBCIFGJPMNA[i].x, HBCIFGJPMNA[num].x, HBCIFGJPMNA[j].y, HBCIFGJPMNA[num2].y, color);
					}
				}
				else if (i == 1)
				{
					if ((j == 0 && bottomType == LEMAHCPEPAC.Tiled) || (j == 2 && topType == LEMAHCPEPAC.Tiled))
					{
						float x4 = OOMHOPLNPEI[i].x;
						float x5 = OOMHOPLNPEI[num].x;
						float y4 = OOMHOPLNPEI[j].y;
						float y5 = OOMHOPLNPEI[num2].y;
						float x6 = HBCIFGJPMNA[i].x;
						float y6 = HBCIFGJPMNA[j].y;
						float y7 = HBCIFGJPMNA[num2].y;
						for (float num9 = x4; num9 < x5; num9 += vector2.x)
						{
							float num10 = num9 + vector2.x;
							float num11 = HBCIFGJPMNA[num].x;
							if (num10 > x5)
							{
								num11 = Mathf.Lerp(x6, num11, (x5 - num9) / vector2.x);
								num10 = x5;
							}
							ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, num9, num10, y4, y5, x6, num11, y6, y7, color);
						}
					}
					else if ((j == 0 && bottomType == LEMAHCPEPAC.Sliced) || (j == 2 && topType == LEMAHCPEPAC.Sliced))
					{
						ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, OOMHOPLNPEI[i].x, OOMHOPLNPEI[num].x, OOMHOPLNPEI[j].y, OOMHOPLNPEI[num2].y, HBCIFGJPMNA[i].x, HBCIFGJPMNA[num].x, HBCIFGJPMNA[j].y, HBCIFGJPMNA[num2].y, color);
					}
				}
				else if (j == 1)
				{
					if ((i == 0 && leftType == LEMAHCPEPAC.Tiled) || (i == 2 && rightType == LEMAHCPEPAC.Tiled))
					{
						float x7 = OOMHOPLNPEI[i].x;
						float x8 = OOMHOPLNPEI[num].x;
						float y8 = OOMHOPLNPEI[j].y;
						float y9 = OOMHOPLNPEI[num2].y;
						float x9 = HBCIFGJPMNA[i].x;
						float x10 = HBCIFGJPMNA[num].x;
						float y10 = HBCIFGJPMNA[j].y;
						for (float num12 = y8; num12 < y9; num12 += vector2.y)
						{
							float num13 = HBCIFGJPMNA[num2].y;
							float num14 = num12 + vector2.y;
							if (num14 > y9)
							{
								num13 = Mathf.Lerp(y10, num13, (y9 - num12) / vector2.y);
								num14 = y9;
							}
							ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, x7, x8, num12, num14, x9, x10, y10, num13, color);
						}
					}
					else if ((i == 0 && leftType == LEMAHCPEPAC.Sliced) || (i == 2 && rightType == LEMAHCPEPAC.Sliced))
					{
						ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, OOMHOPLNPEI[i].x, OOMHOPLNPEI[num].x, OOMHOPLNPEI[j].y, OOMHOPLNPEI[num2].y, HBCIFGJPMNA[i].x, HBCIFGJPMNA[num].x, HBCIFGJPMNA[j].y, HBCIFGJPMNA[num2].y, color);
					}
				}
				else
				{
					ADLMDIBJIIL(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, OOMHOPLNPEI[i].x, OOMHOPLNPEI[num].x, OOMHOPLNPEI[j].y, OOMHOPLNPEI[num2].y, HBCIFGJPMNA[i].x, HBCIFGJPMNA[num].x, HBCIFGJPMNA[j].y, HBCIFGJPMNA[num2].y, color);
				}
			}
		}
	}

	private static bool AJIKOIPCLGA(Vector2[] CFECNBGIBKN, Vector2[] LKNIPAJLBEK, float BEBDMAOGLPM, bool DIMPJENACIL, int ENODHBIMIEL)
	{
		if (BEBDMAOGLPM < 0.001f)
		{
			return false;
		}
		if ((ENODHBIMIEL & 1) == 1)
		{
			DIMPJENACIL = !DIMPJENACIL;
		}
		if (!DIMPJENACIL && BEBDMAOGLPM > 0.999f)
		{
			return true;
		}
		float num = Mathf.Clamp01(BEBDMAOGLPM);
		if (DIMPJENACIL)
		{
			num = 1f - num;
		}
		num *= (float)Math.PI / 2f;
		float bJICMKCPEKC = Mathf.Cos(num);
		float kONLEONLBOG = Mathf.Sin(num);
		AJIKOIPCLGA(CFECNBGIBKN, bJICMKCPEKC, kONLEONLBOG, DIMPJENACIL, ENODHBIMIEL);
		AJIKOIPCLGA(LKNIPAJLBEK, bJICMKCPEKC, kONLEONLBOG, DIMPJENACIL, ENODHBIMIEL);
		return true;
	}

	private static void AJIKOIPCLGA(Vector2[] CFECNBGIBKN, float BJICMKCPEKC, float KONLEONLBOG, bool DIMPJENACIL, int ENODHBIMIEL)
	{
		int num = HHAINCPODGE.FMIHOIEFOON(ENODHBIMIEL + 1, 4);
		int num2 = HHAINCPODGE.FMIHOIEFOON(ENODHBIMIEL + 2, 4);
		int num3 = HHAINCPODGE.FMIHOIEFOON(ENODHBIMIEL + 3, 4);
		if ((ENODHBIMIEL & 1) == 1)
		{
			if (KONLEONLBOG > BJICMKCPEKC)
			{
				BJICMKCPEKC /= KONLEONLBOG;
				KONLEONLBOG = 1f;
				if (DIMPJENACIL)
				{
					CFECNBGIBKN[num].x = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].x, CFECNBGIBKN[num2].x, BJICMKCPEKC);
					CFECNBGIBKN[num2].x = CFECNBGIBKN[num].x;
				}
			}
			else if (BJICMKCPEKC > KONLEONLBOG)
			{
				KONLEONLBOG /= BJICMKCPEKC;
				BJICMKCPEKC = 1f;
				if (!DIMPJENACIL)
				{
					CFECNBGIBKN[num2].y = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].y, CFECNBGIBKN[num2].y, KONLEONLBOG);
					CFECNBGIBKN[num3].y = CFECNBGIBKN[num2].y;
				}
			}
			else
			{
				BJICMKCPEKC = 1f;
				KONLEONLBOG = 1f;
			}
			if (!DIMPJENACIL)
			{
				CFECNBGIBKN[num3].x = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].x, CFECNBGIBKN[num2].x, BJICMKCPEKC);
			}
			else
			{
				CFECNBGIBKN[num].y = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].y, CFECNBGIBKN[num2].y, KONLEONLBOG);
			}
			return;
		}
		if (BJICMKCPEKC > KONLEONLBOG)
		{
			KONLEONLBOG /= BJICMKCPEKC;
			BJICMKCPEKC = 1f;
			if (!DIMPJENACIL)
			{
				CFECNBGIBKN[num].y = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].y, CFECNBGIBKN[num2].y, KONLEONLBOG);
				CFECNBGIBKN[num2].y = CFECNBGIBKN[num].y;
			}
		}
		else if (KONLEONLBOG > BJICMKCPEKC)
		{
			BJICMKCPEKC /= KONLEONLBOG;
			KONLEONLBOG = 1f;
			if (DIMPJENACIL)
			{
				CFECNBGIBKN[num2].x = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].x, CFECNBGIBKN[num2].x, BJICMKCPEKC);
				CFECNBGIBKN[num3].x = CFECNBGIBKN[num2].x;
			}
		}
		else
		{
			BJICMKCPEKC = 1f;
			KONLEONLBOG = 1f;
		}
		if (DIMPJENACIL)
		{
			CFECNBGIBKN[num3].y = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].y, CFECNBGIBKN[num2].y, KONLEONLBOG);
		}
		else
		{
			CFECNBGIBKN[num].x = Mathf.Lerp(CFECNBGIBKN[ENODHBIMIEL].x, CFECNBGIBKN[num2].x, BJICMKCPEKC);
		}
	}

	private static void ADLMDIBJIIL(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP, float MFGEFHDGDEM, float PIEJDMICONP, float BJKAPEOJPHO, float OKJNJJFPFAI, float ECMECLAKNAO, float JMPMKDFBNAD, float LOFAJOKLKAK, float ALJOJAMEKPN, Color HJHHHGLBPMP)
	{
		HILIICKOOFH.GBFCKODJEGE(new Vector3(MFGEFHDGDEM, BJKAPEOJPHO));
		HILIICKOOFH.GBFCKODJEGE(new Vector3(MFGEFHDGDEM, OKJNJJFPFAI));
		HILIICKOOFH.GBFCKODJEGE(new Vector3(PIEJDMICONP, OKJNJJFPFAI));
		HILIICKOOFH.GBFCKODJEGE(new Vector3(PIEJDMICONP, BJKAPEOJPHO));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(ECMECLAKNAO, LOFAJOKLKAK));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(ECMECLAKNAO, ALJOJAMEKPN));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(JMPMKDFBNAD, ALJOJAMEKPN));
		MDBIEMHCFFO.GBFCKODJEGE(new Vector2(JMPMKDFBNAD, LOFAJOKLKAK));
		NAMIAMEOHAP.GBFCKODJEGE(HJHHHGLBPMP);
		NAMIAMEOHAP.GBFCKODJEGE(HJHHHGLBPMP);
		NAMIAMEOHAP.GBFCKODJEGE(HJHHHGLBPMP);
		NAMIAMEOHAP.GBFCKODJEGE(HJHHHGLBPMP);
	}
}
