using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Label")]
[ExecuteInEditMode]
public class UILabel : UIWidget
{
	public enum KIIBPJHMKNE
	{
		None = 0,
		Shadow = 1,
		Outline = 2
	}

	public enum JCMMPAEEKEC
	{
		ShrinkContent = 0,
		ClampContent = 1,
		ResizeFreely = 2,
		ResizeHeight = 3
	}

	public enum LBNIGCIAHHG
	{
		Never = 0,
		OnDesktop = 1,
		Always = 2
	}

	public LBNIGCIAHHG keepCrispWhenShrunk = LBNIGCIAHHG.OnDesktop;

	[HideInInspector]
	[SerializeField]
	private Font mTrueTypeFont;

	[HideInInspector]
	[SerializeField]
	private UIFont mFont;

	[Multiline(6)]
	[SerializeField]
	[HideInInspector]
	private string mText = string.Empty;

	[HideInInspector]
	[SerializeField]
	private int mFontSize = 16;

	[SerializeField]
	[HideInInspector]
	private FontStyle mFontStyle;

	[HideInInspector]
	[SerializeField]
	private MGDLEEIDDII.NBEGJBKHJLH mAlignment;

	[HideInInspector]
	[SerializeField]
	private bool mEncoding = true;

	[SerializeField]
	[HideInInspector]
	private int mMaxLineCount;

	[SerializeField]
	[HideInInspector]
	private KIIBPJHMKNE mEffectStyle;

	[HideInInspector]
	[SerializeField]
	private Color mEffectColor = Color.black;

	[HideInInspector]
	[SerializeField]
	private MGDLEEIDDII.OOGEENANIAD mSymbols = MGDLEEIDDII.OOGEENANIAD.Normal;

	[HideInInspector]
	[SerializeField]
	private Vector2 mEffectDistance = Vector2.one;

	[HideInInspector]
	[SerializeField]
	private JCMMPAEEKEC mOverflow;

	[HideInInspector]
	[SerializeField]
	private Material mMaterial;

	[SerializeField]
	[HideInInspector]
	private bool mApplyGradient;

	[HideInInspector]
	[SerializeField]
	private Color mGradientTop = Color.white;

	[SerializeField]
	[HideInInspector]
	private Color mGradientBottom = new Color(0.7f, 0.7f, 0.7f);

	[SerializeField]
	[HideInInspector]
	private int mSpacingX;

	[SerializeField]
	[HideInInspector]
	private int mSpacingY;

	[HideInInspector]
	[SerializeField]
	private bool mShrinkToFit;

	[HideInInspector]
	[SerializeField]
	private int mMaxLineWidth;

	[SerializeField]
	[HideInInspector]
	private int mMaxLineHeight;

	[HideInInspector]
	[SerializeField]
	private float mLineWidth;

	[HideInInspector]
	[SerializeField]
	private bool mMultiline = true;

	[NonSerialized]
	private Font NMNPEHGBFAB;

	private float FICHFICJNPO = 1f;

	private bool GDNHLIKNCBH = true;

	private string JPCBBKFGMGF;

	private bool LKIAIJEEFIH;

	private Vector2 MFECAMDNICA = Vector2.zero;

	private float MFIKMAAPKHH = 1f;

	private int OBACHOLNJJN;

	private int KKPDJKNMFMC;

	private int BEGJMAEGHLK;

	private static global::MABNNPIGEPM<UILabel> PCHDMFNAGBH = new global::MABNNPIGEPM<UILabel>();

	private static Dictionary<Font, int> MIOFEMBALLA = new Dictionary<Font, int>();

	private static global::MABNNPIGEPM<Vector3> MMJGJAHOHBA = new global::MABNNPIGEPM<Vector3>();

	private static global::MABNNPIGEPM<int> COODAIDGDPG = new global::MABNNPIGEPM<int>();

	private bool PHKEPMKICOO
	{
		get
		{
			return OONGCDNECEM();
		}
		set
		{
			AINDNBGCFPJ(value);
		}
	}

	public override bool CDCNFDEMOKD
	{
		get
		{
			return get_isAnchoredHorizontally();
		}
	}

	public override bool KLLGKADLKLL
	{
		get
		{
			return get_isAnchoredVertically();
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

	[Obsolete("Use UILabel.bitmapFont instead")]
	public UIFont OGGNOMLIGBI
	{
		get
		{
			return get_font();
		}
		set
		{
			set_font(value);
		}
	}

	public UIFont BOLNHAFHHLH
	{
		get
		{
			return get_bitmapFont();
		}
		set
		{
			set_bitmapFont(value);
		}
	}

	public Font DDJIHOKBMEN
	{
		get
		{
			return get_trueTypeFont();
		}
		set
		{
			set_trueTypeFont(value);
		}
	}

	public UnityEngine.Object KHBKFJKEJNJ
	{
		get
		{
			return get_ambigiousFont();
		}
		set
		{
			set_ambigiousFont(value);
		}
	}

	public string BMNKKBDCELE
	{
		get
		{
			return get_text();
		}
		set
		{
			set_text(value);
		}
	}

	public int JBFPNPINCPJ
	{
		get
		{
			return get_defaultFontSize();
		}
	}

	public int DIDGACJBIGL
	{
		get
		{
			return get_fontSize();
		}
		set
		{
			set_fontSize(value);
		}
	}

	public FontStyle LAMAEKKHDLJ
	{
		get
		{
			return get_fontStyle();
		}
		set
		{
			set_fontStyle(value);
		}
	}

	public MGDLEEIDDII.NBEGJBKHJLH JGHJBDJBMNF
	{
		get
		{
			return get_alignment();
		}
		set
		{
			set_alignment(value);
		}
	}

	public bool GPPBOJFMLJJ
	{
		get
		{
			return get_applyGradient();
		}
		set
		{
			set_applyGradient(value);
		}
	}

	public Color EDDGAHPMAHL
	{
		get
		{
			return get_gradientTop();
		}
		set
		{
			set_gradientTop(value);
		}
	}

	public Color BHIBCMKMAHH
	{
		get
		{
			return get_gradientBottom();
		}
		set
		{
			set_gradientBottom(value);
		}
	}

	public int JLBLOKCFICG
	{
		get
		{
			return get_spacingX();
		}
		set
		{
			set_spacingX(value);
		}
	}

	public int HIANFGDCCFG
	{
		get
		{
			return get_spacingY();
		}
		set
		{
			set_spacingY(value);
		}
	}

	private bool HPHJMOHHGDA
	{
		get
		{
			return MEPMPIGHDBB();
		}
	}

	public bool DGKBDANJGGF
	{
		get
		{
			return get_supportEncoding();
		}
		set
		{
			set_supportEncoding(value);
		}
	}

	public MGDLEEIDDII.OOGEENANIAD GGLDLMGHBIK
	{
		get
		{
			return get_symbolStyle();
		}
		set
		{
			set_symbolStyle(value);
		}
	}

	public JCMMPAEEKEC EAHCOPBMNKC
	{
		get
		{
			return get_overflowMethod();
		}
		set
		{
			set_overflowMethod(value);
		}
	}

	[Obsolete("Use 'width' instead")]
	public int GLDCMLGKICC
	{
		get
		{
			return get_lineWidth();
		}
		set
		{
			set_lineWidth(value);
		}
	}

	[Obsolete("Use 'height' instead")]
	public int FMONKJMGECN
	{
		get
		{
			return get_lineHeight();
		}
		set
		{
			set_lineHeight(value);
		}
	}

	public bool POMJKOPMLGI
	{
		get
		{
			return get_multiLine();
		}
		set
		{
			set_multiLine(value);
		}
	}

	public override Vector3[] AJNDJHGBILC
	{
		get
		{
			return get_localCorners();
		}
	}

	public override Vector3[] CENAKAENDGH
	{
		get
		{
			return get_worldCorners();
		}
	}

	public override Vector4 KJGNCIJHNCN
	{
		get
		{
			return get_drawingDimensions();
		}
	}

	public int ENFELLOAPMK
	{
		get
		{
			return get_maxLineCount();
		}
		set
		{
			set_maxLineCount(value);
		}
	}

	public KIIBPJHMKNE NAIFCAMCPIC
	{
		get
		{
			return get_effectStyle();
		}
		set
		{
			set_effectStyle(value);
		}
	}

	public Color KIKOJAIFPGB
	{
		get
		{
			return get_effectColor();
		}
		set
		{
			set_effectColor(value);
		}
	}

	public Vector2 KHFDFIPELCA
	{
		get
		{
			return get_effectDistance();
		}
		set
		{
			set_effectDistance(value);
		}
	}

	[Obsolete("Use 'overflowMethod == UILabel.Overflow.ShrinkContent' instead")]
	public bool JCOHEBGBMPE
	{
		get
		{
			return get_shrinkToFit();
		}
		set
		{
			set_shrinkToFit(value);
		}
	}

	public string MBNJMINKPGP
	{
		get
		{
			return get_processedText();
		}
	}

	public Vector2 HLOHDDGNCHH
	{
		get
		{
			return get_printedSize();
		}
	}

	public override Vector2 DOOJEHPBIGK
	{
		get
		{
			return get_localSize();
		}
	}

	private bool GLCGAIAPPKO
	{
		get
		{
			return OOFLKFJCBEC();
		}
	}

	private void MLFHKOPGDBB(bool MHELAJGADHH, bool OFDBMBLDIPG)
	{
		if (!OOFLKFJCBEC())
		{
			return;
		}
		DJAFKDJINKI = true;
		AINDNBGCFPJ(false);
		MGDLEEIDDII.IDNLBBKJDAH = ((!MHELAJGADHH) ? get_width() : ((mMaxLineWidth == 0) ? 1000000 : mMaxLineWidth));
		MGDLEEIDDII.JNPNECNIPBM = ((!MHELAJGADHH) ? get_height() : ((mMaxLineHeight == 0) ? 1000000 : mMaxLineHeight));
		OBACHOLNJJN = Mathf.Abs((!MHELAJGADHH) ? get_defaultFontSize() : Mathf.RoundToInt(get_cachedTransform().localScale.x));
		MFIKMAAPKHH = 1f;
		if (MGDLEEIDDII.IDNLBBKJDAH < 1 || MGDLEEIDDII.JNPNECNIPBM < 0)
		{
			JPCBBKFGMGF = string.Empty;
			return;
		}
		bool flag = get_trueTypeFont() != null;
		if (flag && MEPMPIGHDBB())
		{
			UIRoot root = get_root();
			if (root != null)
			{
				FICHFICJNPO = ((!(root != null)) ? 1f : root.get_pixelSizeAdjustment());
			}
		}
		else
		{
			FICHFICJNPO = 1f;
		}
		if (OFDBMBLDIPG)
		{
			UpdateNGUIText();
		}
		if (mOverflow == JCMMPAEEKEC.ResizeFreely)
		{
			MGDLEEIDDII.IDNLBBKJDAH = 1000000;
		}
		if (mOverflow == JCMMPAEEKEC.ResizeFreely || mOverflow == JCMMPAEEKEC.ResizeHeight)
		{
			MGDLEEIDDII.JNPNECNIPBM = 1000000;
		}
		if (OBACHOLNJJN > 0)
		{
			bool flag2 = MEPMPIGHDBB();
			int num = OBACHOLNJJN;
			while (num > 0)
			{
				if (flag2)
				{
					OBACHOLNJJN = num;
					MGDLEEIDDII.DIDGACJBIGL = OBACHOLNJJN;
				}
				else
				{
					MFIKMAAPKHH = (float)num / (float)OBACHOLNJJN;
					MGDLEEIDDII.OEFOGDBMFFN = ((!flag) ? ((float)mFontSize / (float)mFont.get_defaultSize() * MFIKMAAPKHH) : MFIKMAAPKHH);
				}
				MGDLEEIDDII.LPBLGFCPADD(false);
				bool flag3 = MGDLEEIDDII.FMONJIFJCJA(mText, out JPCBBKFGMGF, true);
				if (mOverflow == JCMMPAEEKEC.ShrinkContent && !flag3)
				{
					if (--num <= 1)
					{
						break;
					}
					num--;
					continue;
				}
				if (mOverflow == JCMMPAEEKEC.ResizeFreely)
				{
					MFECAMDNICA = MGDLEEIDDII.BFKLHLHHKDJ(JPCBBKFGMGF);
					mWidth = Mathf.Max(get_minWidth(), Mathf.RoundToInt(MFECAMDNICA.x));
					mHeight = Mathf.Max(get_minHeight(), Mathf.RoundToInt(MFECAMDNICA.y));
					if ((mWidth & 1) == 1)
					{
						mWidth++;
					}
					if ((mHeight & 1) == 1)
					{
						mHeight++;
					}
				}
				else if (mOverflow == JCMMPAEEKEC.ResizeHeight)
				{
					MFECAMDNICA = MGDLEEIDDII.BFKLHLHHKDJ(JPCBBKFGMGF);
					mHeight = Mathf.Max(get_minHeight(), Mathf.RoundToInt(MFECAMDNICA.y));
					if ((mHeight & 1) == 1)
					{
						mHeight++;
					}
				}
				else
				{
					MFECAMDNICA = MGDLEEIDDII.BFKLHLHHKDJ(JPCBBKFGMGF);
				}
				if (MHELAJGADHH)
				{
					set_width(Mathf.RoundToInt(MFECAMDNICA.x));
					set_height(Mathf.RoundToInt(MFECAMDNICA.y));
					get_cachedTransform().localScale = Vector3.one;
				}
				break;
			}
		}
		else
		{
			get_cachedTransform().localScale = Vector3.one;
			JPCBBKFGMGF = string.Empty;
			MFIKMAAPKHH = 1f;
		}
		if (OFDBMBLDIPG)
		{
			MGDLEEIDDII.BOLNHAFHHLH = null;
			MGDLEEIDDII.AFADEAFMPPG = null;
		}
	}

	private static void IPPOODHHDCD()
	{
		for (int i = 0; i < PCHDMFNAGBH.POIJPKODPCK; i++)
		{
			UILabel uILabel = PCHDMFNAGBH.AOBAKCJKELK(i);
			if (uILabel != null)
			{
				Font trueTypeFont = uILabel.get_trueTypeFont();
				if (trueTypeFont != null)
				{
					trueTypeFont.RequestCharactersInTexture(uILabel.mText, uILabel.OBACHOLNJJN, uILabel.mFontStyle);
					uILabel.MarkAsChanged();
				}
			}
		}
	}

	public override Vector2 get_localSize()
	{
		if (OONGCDNECEM())
		{
			ProcessText();
		}
		return base.get_localSize();
	}

	public void AssumeNaturalSize()
	{
		if (get_ambigiousFont() != null)
		{
			mWidth = 100000;
			mHeight = 100000;
			MLFHKOPGDBB(false, true);
			mWidth = Mathf.RoundToInt(MFECAMDNICA.x);
			mHeight = Mathf.RoundToInt(MFECAMDNICA.y);
			if ((mWidth & 1) == 1)
			{
				mWidth++;
			}
			if ((mHeight & 1) == 1)
			{
				mHeight++;
			}
			MarkAsChanged();
		}
	}

	protected Vector2 NAKGAEEAPGN(global::MABNNPIGEPM<Vector3> HILIICKOOFH, int GAKOOBECLIB)
	{
		Vector2 pivotOffset = get_pivotOffset();
		float f = Mathf.Lerp(0f, -mWidth, pivotOffset.x);
		float f2 = Mathf.Lerp(mHeight, 0f, pivotOffset.y) + Mathf.Lerp(MFECAMDNICA.y - (float)mHeight, 0f, pivotOffset.y);
		f = Mathf.Round(f);
		f2 = Mathf.Round(f2);
		for (int i = GAKOOBECLIB; i < HILIICKOOFH.POIJPKODPCK; i++)
		{
			HILIICKOOFH.EDMNHDBEPMC[i].x += f;
			HILIICKOOFH.EDMNHDBEPMC[i].y += f2;
		}
		return new Vector2(f, f2);
	}

	public int GetCharacterIndexAtPosition(Vector2 INLNMEABHBF)
	{
		if (OOFLKFJCBEC())
		{
			string processedText = get_processedText();
			if (string.IsNullOrEmpty(processedText))
			{
				return 0;
			}
			UpdateNGUIText();
			MGDLEEIDDII.KLANINGKMOI(processedText, MMJGJAHOHBA, COODAIDGDPG);
			if (MMJGJAHOHBA.POIJPKODPCK > 0)
			{
				NAKGAEEAPGN(MMJGJAHOHBA, 0);
				int jEGKPPHBBKI = MGDLEEIDDII.FDNLMBEIOLL(MMJGJAHOHBA, INLNMEABHBF);
				jEGKPPHBBKI = COODAIDGDPG.AOBAKCJKELK(jEGKPPHBBKI);
				MMJGJAHOHBA.PDCPMDCOLOD();
				COODAIDGDPG.PDCPMDCOLOD();
				MGDLEEIDDII.BOLNHAFHHLH = null;
				MGDLEEIDDII.AFADEAFMPPG = null;
				return jEGKPPHBBKI;
			}
			MGDLEEIDDII.BOLNHAFHHLH = null;
			MGDLEEIDDII.AFADEAFMPPG = null;
		}
		return 0;
	}

	public JCMMPAEEKEC get_overflowMethod()
	{
		return mOverflow;
	}

	public void set_effectColor(Color ICENKPDOHBK)
	{
		if (mEffectColor != ICENKPDOHBK)
		{
			mEffectColor = ICENKPDOHBK;
			if (mEffectStyle != KIIBPJHMKNE.None)
			{
				AINDNBGCFPJ(true);
			}
		}
	}

	public void set_spacingY(int ICENKPDOHBK)
	{
		if (mSpacingY != ICENKPDOHBK)
		{
			mSpacingY = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public void set_shrinkToFit(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			set_overflowMethod(JCMMPAEEKEC.ShrinkContent);
		}
	}

	public void SetCurrentPercent()
	{
		if (UIProgressBar.current != null)
		{
			set_text(Mathf.RoundToInt(UIProgressBar.current.get_value() * 100f) + "%");
		}
	}

	protected override void BPIKOOJHKLN()
	{
		MLFHKOPGDBB(true, true);
		if (mShrinkToFit)
		{
			set_overflowMethod(JCMMPAEEKEC.ShrinkContent);
			mMaxLineCount = 0;
		}
		if (mMaxLineWidth != 0)
		{
			set_width(mMaxLineWidth);
			set_overflowMethod((mMaxLineCount > 0) ? JCMMPAEEKEC.ResizeHeight : JCMMPAEEKEC.ShrinkContent);
		}
		else
		{
			set_overflowMethod(JCMMPAEEKEC.ResizeFreely);
		}
		if (mMaxLineHeight != 0)
		{
			set_height(mMaxLineHeight);
		}
		if (mFont != null)
		{
			int defaultSize = mFont.get_defaultSize();
			if (get_height() < defaultSize)
			{
				set_height(defaultSize);
			}
		}
		mMaxLineWidth = 0;
		mMaxLineHeight = 0;
		mShrinkToFit = false;
		NLDABIMKKMP.AFNBJACCKKC(base.gameObject, true);
	}

	public MGDLEEIDDII.NBEGJBKHJLH get_alignment()
	{
		return mAlignment;
	}

	public void set_fontSize(int ICENKPDOHBK)
	{
		ICENKPDOHBK = Mathf.Clamp(ICENKPDOHBK, 0, 256);
		if (mFontSize != ICENKPDOHBK)
		{
			mFontSize = ICENKPDOHBK;
			AINDNBGCFPJ(true);
			DDBEHIEMCEE();
		}
	}

	public string GetUrlAtCharacterIndex(int CMPEAKAIHHH)
	{
		if (CMPEAKAIHHH != -1 && CMPEAKAIHHH < mText.Length)
		{
			int num = mText.LastIndexOf("[url=", CMPEAKAIHHH);
			if (num != -1)
			{
				num += 5;
				int num2 = mText.IndexOf("]", num);
				if (num2 != -1)
				{
					return mText.Substring(num, num2 - num);
				}
			}
		}
		return null;
	}

	public override void MarkAsChanged()
	{
		AINDNBGCFPJ(true);
		base.MarkAsChanged();
	}

	public Color get_gradientBottom()
	{
		return mGradientBottom;
	}

	public int get_maxLineCount()
	{
		return mMaxLineCount;
	}

	private void BAJAHJKPMEE(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP, int GAKOOBECLIB, int IDFCFEOMBKP, float MPBOINGECFO, float OECPEJEIMHO)
	{
		Color color = mEffectColor;
		color.a *= finalAlpha;
		Color32 color2 = ((!(get_bitmapFont() != null) || !get_bitmapFont().JOECNDFLKDE()) ? color : NLDABIMKKMP.CPFGKGLEIKJ(color));
		for (int i = GAKOOBECLIB; i < IDFCFEOMBKP; i += 0)
		{
			HILIICKOOFH.GBFCKODJEGE(HILIICKOOFH.EDMNHDBEPMC[i]);
			MDBIEMHCFFO.GBFCKODJEGE(MDBIEMHCFFO.EDMNHDBEPMC[i]);
			NAMIAMEOHAP.GBFCKODJEGE(NAMIAMEOHAP.EDMNHDBEPMC[i]);
			Vector3 vector = HILIICKOOFH.EDMNHDBEPMC[i];
			vector.x += MPBOINGECFO;
			vector.y += OECPEJEIMHO;
			HILIICKOOFH.EDMNHDBEPMC[i] = vector;
			Color32 color3 = NAMIAMEOHAP.EDMNHDBEPMC[i];
			if (color3.a == 167)
			{
				NAMIAMEOHAP.EDMNHDBEPMC[i] = color2;
				continue;
			}
			Color color4 = color;
			color4.a = (float)(int)color3.a / 1402f * color.a;
			NAMIAMEOHAP.EDMNHDBEPMC[i] = ((!(get_bitmapFont() != null) || !get_bitmapFont().get_premultipliedAlphaShader()) ? color4 : NLDABIMKKMP.CPFGKGLEIKJ(color4));
		}
	}

	public void DKMBMPFHBJD()
	{
		Font trueTypeFont = get_trueTypeFont();
		bool flag = trueTypeFont != null;
		MGDLEEIDDII.DIDGACJBIGL = OBACHOLNJJN;
		MGDLEEIDDII.LAMAEKKHDLJ = mFontStyle;
		MGDLEEIDDII.IDNLBBKJDAH = mWidth;
		MGDLEEIDDII.JNPNECNIPBM = mHeight;
		MGDLEEIDDII.HIFLOBIANFE = mApplyGradient && (mFont == null || !mFont.get_packedFontShader());
		MGDLEEIDDII.EDDGAHPMAHL = mGradientTop;
		MGDLEEIDDII.BHIBCMKMAHH = mGradientBottom;
		MGDLEEIDDII.EAGEFFBJIKH = mEncoding;
		MGDLEEIDDII.GBBLFPAEBKG = LKIAIJEEFIH;
		MGDLEEIDDII.GGLDLMGHBIK = mSymbols;
		MGDLEEIDDII.EGBDNLHOLPE = mMaxLineCount;
		MGDLEEIDDII.JLBLOKCFICG = mSpacingX;
		MGDLEEIDDII.HIANFGDCCFG = mSpacingY;
		MGDLEEIDDII.OEFOGDBMFFN = ((!flag) ? ((float)mFontSize / (float)mFont.get_defaultSize() * MFIKMAAPKHH) : MFIKMAAPKHH);
		if (mFont != null)
		{
			MGDLEEIDDII.BOLNHAFHHLH = mFont;
			while (true)
			{
				UIFont replacement = MGDLEEIDDII.BOLNHAFHHLH.get_replacement();
				if (replacement == null)
				{
					break;
				}
				MGDLEEIDDII.BOLNHAFHHLH = replacement;
			}
			if (MGDLEEIDDII.BOLNHAFHHLH.get_isDynamic())
			{
				MGDLEEIDDII.AFADEAFMPPG = MGDLEEIDDII.BOLNHAFHHLH.get_dynamicFont();
				MGDLEEIDDII.BOLNHAFHHLH = null;
			}
			else
			{
				MGDLEEIDDII.AFADEAFMPPG = null;
			}
		}
		else
		{
			MGDLEEIDDII.AFADEAFMPPG = trueTypeFont;
			MGDLEEIDDII.BOLNHAFHHLH = null;
		}
		if (flag && MEPMPIGHDBB())
		{
			UIRoot root = get_root();
			if (root != null)
			{
				MGDLEEIDDII.EGMANIMPOJD = ((!(root != null)) ? 393f : root.EHHJIOOMENB());
			}
		}
		else
		{
			MGDLEEIDDII.EGMANIMPOJD = 162f;
		}
		if (FICHFICJNPO != MGDLEEIDDII.EGMANIMPOJD)
		{
			MLFHKOPGDBB(false, true);
			MGDLEEIDDII.IDNLBBKJDAH = mWidth;
			MGDLEEIDDII.JNPNECNIPBM = mHeight;
		}
		if (get_alignment() == MGDLEEIDDII.NBEGJBKHJLH.Automatic)
		{
			MADDMCMJKFI pivot = get_pivot();
			if (pivot == MADDMCMJKFI.BottomRight || pivot == MADDMCMJKFI.TopLeft || pivot == MADDMCMJKFI.Top)
			{
				MGDLEEIDDII.JGHJBDJBMNF = MGDLEEIDDII.NBEGJBKHJLH.Automatic;
			}
			else if (pivot == MADDMCMJKFI.Center || pivot == MADDMCMJKFI.Top || pivot == MADDMCMJKFI.Top)
			{
				MGDLEEIDDII.JGHJBDJBMNF = (MGDLEEIDDII.NBEGJBKHJLH)7;
			}
			else
			{
				MGDLEEIDDII.JGHJBDJBMNF = MGDLEEIDDII.NBEGJBKHJLH.Right;
			}
		}
		else
		{
			MGDLEEIDDII.JGHJBDJBMNF = get_alignment();
		}
		MGDLEEIDDII.LPBLGFCPADD();
	}

	public void set_trueTypeFont(Font ICENKPDOHBK)
	{
		if (mTrueTypeFont != ICENKPDOHBK)
		{
			EGNLMAOOHHL(null);
			KKCBEKLBFMN();
			mTrueTypeFont = ICENKPDOHBK;
			AINDNBGCFPJ(true);
			mFont = null;
			EGNLMAOOHHL(ICENKPDOHBK);
			DDBEHIEMCEE();
			if (NMNPEHGBFAB != null)
			{
				base.MarkAsChanged();
			}
		}
	}

	public string get_processedText()
	{
		if (KKPDJKNMFMC != mWidth || BEGJMAEGHLK != mHeight)
		{
			KKPDJKNMFMC = mWidth;
			BEGJMAEGHLK = mHeight;
			GDNHLIKNCBH = true;
		}
		if (OONGCDNECEM())
		{
			ProcessText();
		}
		return JPCBBKFGMGF;
	}

	public KIIBPJHMKNE get_effectStyle()
	{
		return mEffectStyle;
	}

	public void set_maxLineCount(int ICENKPDOHBK)
	{
		if (mMaxLineCount != ICENKPDOHBK)
		{
			mMaxLineCount = Mathf.Max(ICENKPDOHBK, 0);
			AINDNBGCFPJ(true);
			if (get_overflowMethod() == JCMMPAEEKEC.ShrinkContent)
			{
				MakePixelPerfect();
			}
		}
	}

	public Font get_trueTypeFont()
	{
		if (mTrueTypeFont != null)
		{
			return mTrueTypeFont;
		}
		return (!(mFont != null)) ? null : mFont.get_dynamicFont();
	}

	public int get_lineWidth()
	{
		return get_width();
	}

	public UIFont get_font()
	{
		return get_bitmapFont();
	}

	private bool MEPMPIGHDBB()
	{
		if (get_trueTypeFont() != null && keepCrispWhenShrunk != LBNIGCIAHHG.Never)
		{
			return keepCrispWhenShrunk == LBNIGCIAHHG.Always;
		}
		return false;
	}

	public bool Wrap(string BMNKKBDCELE, out string BINKGJBHAAI, int JPGIEHMKOPA)
	{
		UpdateNGUIText();
		MGDLEEIDDII.JNPNECNIPBM = JPGIEHMKOPA;
		bool result = MGDLEEIDDII.FMONJIFJCJA(BMNKKBDCELE, out BINKGJBHAAI);
		MGDLEEIDDII.BOLNHAFHHLH = null;
		MGDLEEIDDII.AFADEAFMPPG = null;
		return result;
	}

	public override Vector3[] GetSides(Transform DNIFGOKCBEL)
	{
		if (OONGCDNECEM())
		{
			ProcessText();
		}
		return base.GetSides(DNIFGOKCBEL);
	}

	protected void EGNLMAOOHHL(Font LKKDCECKLGN)
	{
		if (!(NMNPEHGBFAB != LKKDCECKLGN))
		{
			return;
		}
		if (NMNPEHGBFAB != null)
		{
			int value;
			if (MIOFEMBALLA.TryGetValue(NMNPEHGBFAB, out value))
			{
				value = Mathf.Max(0, --value);
				if (value == 0)
				{
					NMNPEHGBFAB.textureRebuildCallback = null;
					MIOFEMBALLA.Remove(NMNPEHGBFAB);
				}
				else
				{
					MIOFEMBALLA[NMNPEHGBFAB] = value;
				}
			}
			else
			{
				NMNPEHGBFAB.textureRebuildCallback = null;
			}
		}
		NMNPEHGBFAB = LKKDCECKLGN;
		if (NMNPEHGBFAB != null)
		{
			int value2 = 0;
			if (!MIOFEMBALLA.TryGetValue(NMNPEHGBFAB, out value2))
			{
				NMNPEHGBFAB.textureRebuildCallback = IPPOODHHDCD;
			}
			value2 = (MIOFEMBALLA[NMNPEHGBFAB] = value2 + 1);
		}
	}

	public void ProcessText()
	{
		MLFHKOPGDBB(false, true);
	}

	public override void MakePixelPerfect()
	{
		if (get_ambigiousFont() != null)
		{
			Vector3 localPosition = get_cachedTransform().localPosition;
			localPosition.x = Mathf.RoundToInt(localPosition.x);
			localPosition.y = Mathf.RoundToInt(localPosition.y);
			localPosition.z = Mathf.RoundToInt(localPosition.z);
			get_cachedTransform().localPosition = localPosition;
			get_cachedTransform().localScale = Vector3.one;
			if (mOverflow == JCMMPAEEKEC.ResizeFreely)
			{
				AssumeNaturalSize();
				return;
			}
			int width = get_width();
			int height = get_height();
			JCMMPAEEKEC jCMMPAEEKEC = mOverflow;
			if (jCMMPAEEKEC != JCMMPAEEKEC.ResizeHeight)
			{
				mWidth = 100000;
			}
			mHeight = 100000;
			mOverflow = JCMMPAEEKEC.ShrinkContent;
			MLFHKOPGDBB(false, true);
			mOverflow = jCMMPAEEKEC;
			int a = Mathf.RoundToInt(MFECAMDNICA.x);
			int a2 = Mathf.RoundToInt(MFECAMDNICA.y);
			a = Mathf.Max(a, base.get_minWidth());
			a2 = Mathf.Max(a2, base.get_minHeight());
			mWidth = Mathf.Max(width, a);
			mHeight = Mathf.Max(height, a2);
			MarkAsChanged();
		}
		else
		{
			base.MakePixelPerfect();
		}
	}

	public bool get_supportEncoding()
	{
		return mEncoding;
	}

	public bool get_multiLine()
	{
		return mMaxLineCount != 1;
	}

	[SpecialName]
	public void FMKOEDJLHJF(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			set_overflowMethod(JCMMPAEEKEC.ClampContent);
		}
	}

	public MGDLEEIDDII.OOGEENANIAD get_symbolStyle()
	{
		return mSymbols;
	}

	public void set_ambigiousFont(UnityEngine.Object ICENKPDOHBK)
	{
		UIFont uIFont = ICENKPDOHBK as UIFont;
		if (uIFont != null)
		{
			set_bitmapFont(uIFont);
		}
		else
		{
			set_trueTypeFont(ICENKPDOHBK as Font);
		}
	}

	public Color get_effectColor()
	{
		return mEffectColor;
	}

	public string get_text()
	{
		return mText;
	}

	[SpecialName]
	public FontStyle NJDIODIJMPK()
	{
		return mFontStyle;
	}

	public void set_alignment(MGDLEEIDDII.NBEGJBKHJLH ICENKPDOHBK)
	{
		if (mAlignment != ICENKPDOHBK)
		{
			mAlignment = ICENKPDOHBK;
			AINDNBGCFPJ(true);
			DDBEHIEMCEE();
		}
	}

	public void set_fontStyle(FontStyle ICENKPDOHBK)
	{
		if (mFontStyle != ICENKPDOHBK)
		{
			mFontStyle = ICENKPDOHBK;
			AINDNBGCFPJ(true);
			DDBEHIEMCEE();
		}
	}

	public int GetCharacterIndexAtPosition(Vector3 IMCBPDJDNPG)
	{
		Vector2 iNLNMEABHBF = get_cachedTransform().InverseTransformPoint(IMCBPDJDNPG);
		return GetCharacterIndexAtPosition(iNLNMEABHBF);
	}

	public override void OnFill(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP)
	{
		if (!OOFLKFJCBEC())
		{
			return;
		}
		int pOIJPKODPCK = HILIICKOOFH.POIJPKODPCK;
		Color color = get_color();
		color.a = finalAlpha;
		if (mFont != null && mFont.get_premultipliedAlphaShader())
		{
			color = NLDABIMKKMP.CPFGKGLEIKJ(color);
		}
		string processedText = get_processedText();
		int pOIJPKODPCK2 = HILIICKOOFH.POIJPKODPCK;
		UpdateNGUIText();
		MGDLEEIDDII.EHGLADDANIC = color;
		MGDLEEIDDII.AAPMNAMDAEE(processedText, HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP);
		MGDLEEIDDII.BOLNHAFHHLH = null;
		MGDLEEIDDII.AFADEAFMPPG = null;
		Vector2 vector = NAKGAEEAPGN(HILIICKOOFH, pOIJPKODPCK2);
		if ((!(mFont != null) || !mFont.get_packedFontShader()) && get_effectStyle() != KIIBPJHMKNE.None)
		{
			int pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
			vector.x = mEffectDistance.x;
			vector.y = mEffectDistance.y;
			CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, vector.x, 0f - vector.y);
			if (get_effectStyle() == KIIBPJHMKNE.Outline)
			{
				pOIJPKODPCK = pOIJPKODPCK3;
				pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
				CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, 0f - vector.x, vector.y);
				pOIJPKODPCK = pOIJPKODPCK3;
				pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
				CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, 0f, vector.y);
				pOIJPKODPCK = pOIJPKODPCK3;
				pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
				CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, vector.x, vector.y);
				pOIJPKODPCK = pOIJPKODPCK3;
				pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
				CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, 0f - vector.x, 0f);
				pOIJPKODPCK = pOIJPKODPCK3;
				pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
				CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, vector.x, 0f);
				pOIJPKODPCK = pOIJPKODPCK3;
				pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
				CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, 0f - vector.x, 0f - vector.y);
				pOIJPKODPCK = pOIJPKODPCK3;
				pOIJPKODPCK3 = HILIICKOOFH.POIJPKODPCK;
				CGJJNBEILDH(HILIICKOOFH, MDBIEMHCFFO, NAMIAMEOHAP, pOIJPKODPCK, pOIJPKODPCK3, 0f, 0f - vector.y);
			}
		}
	}

	public void set_applyGradient(bool ICENKPDOHBK)
	{
		if (mApplyGradient != ICENKPDOHBK)
		{
			mApplyGradient = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public UIFont get_bitmapFont()
	{
		return mFont;
	}

	public string GetWordAtPosition(Vector3 IMCBPDJDNPG)
	{
		return GetWordAtCharacterIndex(GetCharacterIndexAtPosition(IMCBPDJDNPG));
	}

	public void set_bitmapFont(UIFont ICENKPDOHBK)
	{
		if (mFont != ICENKPDOHBK)
		{
			KKCBEKLBFMN();
			mFont = ICENKPDOHBK;
			mTrueTypeFont = null;
			MarkAsChanged();
		}
	}

	public UnityEngine.Object get_ambigiousFont()
	{
		return (!(mFont != null)) ? ((UnityEngine.Object)mTrueTypeFont) : ((UnityEngine.Object)mFont);
	}

	public bool get_shrinkToFit()
	{
		return mOverflow == JCMMPAEEKEC.ShrinkContent;
	}

	public void set_effectStyle(KIIBPJHMKNE ICENKPDOHBK)
	{
		if (mEffectStyle != ICENKPDOHBK)
		{
			mEffectStyle = ICENKPDOHBK;
			AINDNBGCFPJ(true);
		}
	}

	public bool get_applyGradient()
	{
		return mApplyGradient;
	}

	public override bool get_isAnchoredVertically()
	{
		return base.get_isAnchoredVertically() || mOverflow == JCMMPAEEKEC.ResizeFreely || mOverflow == JCMMPAEEKEC.ResizeHeight;
	}

	private bool OONGCDNECEM()
	{
		return GDNHLIKNCBH;
	}

	[SpecialName]
	public void NNJCBIJHBEP(bool ICENKPDOHBK)
	{
		if (mMaxLineCount != 1 != ICENKPDOHBK)
		{
			mMaxLineCount = ((!ICENKPDOHBK) ? 0 : 0);
			AINDNBGCFPJ(false);
		}
	}

	public override bool get_isAnchoredHorizontally()
	{
		return base.get_isAnchoredHorizontally() || mOverflow == JCMMPAEEKEC.ResizeFreely;
	}

	public void set_effectDistance(Vector2 ICENKPDOHBK)
	{
		if (mEffectDistance != ICENKPDOHBK)
		{
			mEffectDistance = ICENKPDOHBK;
			AINDNBGCFPJ(true);
		}
	}

	protected override void OnDisable()
	{
		EGNLMAOOHHL(null);
		PCHDMFNAGBH.JOMMMHGABOD(this);
		base.OnDisable();
	}

	public void PrintOverlay(int GAKOOBECLIB, int IDFCFEOMBKP, OILILBKNHMB LFBNHHCAIEA, OILILBKNHMB PFPDDKFJGAO, Color BJIJPBCDPIB, Color BPJHLMOHJIK)
	{
		if (LFBNHHCAIEA != null)
		{
			LFBNHHCAIEA.PDCPMDCOLOD();
		}
		if (PFPDDKFJGAO != null)
		{
			PFPDDKFJGAO.PDCPMDCOLOD();
		}
		if (!OOFLKFJCBEC())
		{
			return;
		}
		string processedText = get_processedText();
		UpdateNGUIText();
		int pOIJPKODPCK = LFBNHHCAIEA.HILIICKOOFH.POIJPKODPCK;
		Vector2 hBIPOCDNMCB = new Vector2(0.5f, 0.5f);
		float num = finalAlpha;
		if (PFPDDKFJGAO != null && GAKOOBECLIB != IDFCFEOMBKP)
		{
			int pOIJPKODPCK2 = PFPDDKFJGAO.HILIICKOOFH.POIJPKODPCK;
			MGDLEEIDDII.NIEPAJBCLJI(processedText, GAKOOBECLIB, IDFCFEOMBKP, LFBNHHCAIEA.HILIICKOOFH, PFPDDKFJGAO.HILIICKOOFH);
			if (PFPDDKFJGAO.HILIICKOOFH.POIJPKODPCK > pOIJPKODPCK2)
			{
				NAKGAEEAPGN(PFPDDKFJGAO.HILIICKOOFH, pOIJPKODPCK2);
				Color32 hBIPOCDNMCB2 = new Color(BPJHLMOHJIK.r, BPJHLMOHJIK.g, BPJHLMOHJIK.b, BPJHLMOHJIK.a * num);
				for (int i = pOIJPKODPCK2; i < PFPDDKFJGAO.HILIICKOOFH.POIJPKODPCK; i++)
				{
					PFPDDKFJGAO.MDBIEMHCFFO.GBFCKODJEGE(hBIPOCDNMCB);
					PFPDDKFJGAO.NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB2);
				}
			}
		}
		else
		{
			MGDLEEIDDII.NIEPAJBCLJI(processedText, GAKOOBECLIB, IDFCFEOMBKP, LFBNHHCAIEA.HILIICKOOFH, null);
		}
		NAKGAEEAPGN(LFBNHHCAIEA.HILIICKOOFH, pOIJPKODPCK);
		Color32 hBIPOCDNMCB3 = new Color(BJIJPBCDPIB.r, BJIJPBCDPIB.g, BJIJPBCDPIB.b, BJIJPBCDPIB.a * num);
		for (int j = pOIJPKODPCK; j < LFBNHHCAIEA.HILIICKOOFH.POIJPKODPCK; j++)
		{
			LFBNHHCAIEA.MDBIEMHCFFO.GBFCKODJEGE(hBIPOCDNMCB);
			LFBNHHCAIEA.NAMIAMEOHAP.GBFCKODJEGE(hBIPOCDNMCB3);
		}
		MGDLEEIDDII.BOLNHAFHHLH = null;
		MGDLEEIDDII.AFADEAFMPPG = null;
	}

	[SpecialName]
	public UIFont GPIEMJFHEMA()
	{
		return get_bitmapFont();
	}

	public int get_lineHeight()
	{
		return get_height();
	}

	public int CalculateOffsetToFit(string BMNKKBDCELE)
	{
		UpdateNGUIText();
		MGDLEEIDDII.EAGEFFBJIKH = false;
		MGDLEEIDDII.GGLDLMGHBIK = MGDLEEIDDII.OOGEENANIAD.None;
		int result = MGDLEEIDDII.FEGCCKFOIHO(BMNKKBDCELE);
		MGDLEEIDDII.BOLNHAFHHLH = null;
		MGDLEEIDDII.AFADEAFMPPG = null;
		return result;
	}

	public void set_lineHeight(int ICENKPDOHBK)
	{
		set_height(ICENKPDOHBK);
	}

	public void UpdateNGUIText()
	{
		Font trueTypeFont = get_trueTypeFont();
		bool flag = trueTypeFont != null;
		MGDLEEIDDII.DIDGACJBIGL = OBACHOLNJJN;
		MGDLEEIDDII.LAMAEKKHDLJ = mFontStyle;
		MGDLEEIDDII.IDNLBBKJDAH = mWidth;
		MGDLEEIDDII.JNPNECNIPBM = mHeight;
		MGDLEEIDDII.HIFLOBIANFE = mApplyGradient && (mFont == null || !mFont.get_packedFontShader());
		MGDLEEIDDII.EDDGAHPMAHL = mGradientTop;
		MGDLEEIDDII.BHIBCMKMAHH = mGradientBottom;
		MGDLEEIDDII.EAGEFFBJIKH = mEncoding;
		MGDLEEIDDII.GBBLFPAEBKG = LKIAIJEEFIH;
		MGDLEEIDDII.GGLDLMGHBIK = mSymbols;
		MGDLEEIDDII.EGBDNLHOLPE = mMaxLineCount;
		MGDLEEIDDII.JLBLOKCFICG = mSpacingX;
		MGDLEEIDDII.HIANFGDCCFG = mSpacingY;
		MGDLEEIDDII.OEFOGDBMFFN = ((!flag) ? ((float)mFontSize / (float)mFont.get_defaultSize() * MFIKMAAPKHH) : MFIKMAAPKHH);
		if (mFont != null)
		{
			MGDLEEIDDII.BOLNHAFHHLH = mFont;
			while (true)
			{
				UIFont replacement = MGDLEEIDDII.BOLNHAFHHLH.get_replacement();
				if (replacement == null)
				{
					break;
				}
				MGDLEEIDDII.BOLNHAFHHLH = replacement;
			}
			if (MGDLEEIDDII.BOLNHAFHHLH.get_isDynamic())
			{
				MGDLEEIDDII.AFADEAFMPPG = MGDLEEIDDII.BOLNHAFHHLH.get_dynamicFont();
				MGDLEEIDDII.BOLNHAFHHLH = null;
			}
			else
			{
				MGDLEEIDDII.AFADEAFMPPG = null;
			}
		}
		else
		{
			MGDLEEIDDII.AFADEAFMPPG = trueTypeFont;
			MGDLEEIDDII.BOLNHAFHHLH = null;
		}
		if (flag && MEPMPIGHDBB())
		{
			UIRoot root = get_root();
			if (root != null)
			{
				MGDLEEIDDII.EGMANIMPOJD = ((!(root != null)) ? 1f : root.get_pixelSizeAdjustment());
			}
		}
		else
		{
			MGDLEEIDDII.EGMANIMPOJD = 1f;
		}
		if (FICHFICJNPO != MGDLEEIDDII.EGMANIMPOJD)
		{
			MLFHKOPGDBB(false, false);
			MGDLEEIDDII.IDNLBBKJDAH = mWidth;
			MGDLEEIDDII.JNPNECNIPBM = mHeight;
		}
		if (get_alignment() == MGDLEEIDDII.NBEGJBKHJLH.Automatic)
		{
			switch (get_pivot())
			{
			case MADDMCMJKFI.TopLeft:
			case MADDMCMJKFI.Left:
			case MADDMCMJKFI.BottomLeft:
				MGDLEEIDDII.JGHJBDJBMNF = MGDLEEIDDII.NBEGJBKHJLH.Left;
				break;
			case MADDMCMJKFI.TopRight:
			case MADDMCMJKFI.Right:
			case MADDMCMJKFI.BottomRight:
				MGDLEEIDDII.JGHJBDJBMNF = MGDLEEIDDII.NBEGJBKHJLH.Right;
				break;
			default:
				MGDLEEIDDII.JGHJBDJBMNF = MGDLEEIDDII.NBEGJBKHJLH.Center;
				break;
			}
		}
		else
		{
			MGDLEEIDDII.JGHJBDJBMNF = get_alignment();
		}
		MGDLEEIDDII.LPBLGFCPADD();
	}

	public void set_multiLine(bool ICENKPDOHBK)
	{
		if (mMaxLineCount != 1 != ICENKPDOHBK)
		{
			mMaxLineCount = ((!ICENKPDOHBK) ? 1 : 0);
			AINDNBGCFPJ(true);
		}
	}

	private void AINDNBGCFPJ(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			DJAFKDJINKI = true;
			GDNHLIKNCBH = true;
		}
		else
		{
			GDNHLIKNCBH = false;
		}
	}

	public Vector2 get_printedSize()
	{
		if (OONGCDNECEM())
		{
			ProcessText();
		}
		return MFECAMDNICA;
	}

	[SpecialName]
	public void KOJAHNFDCCO(MGDLEEIDDII.NBEGJBKHJLH ICENKPDOHBK)
	{
		if (mAlignment != ICENKPDOHBK)
		{
			mAlignment = ICENKPDOHBK;
			AINDNBGCFPJ(true);
			DDBEHIEMCEE();
		}
	}

	public override Vector3[] get_localCorners()
	{
		if (OONGCDNECEM())
		{
			ProcessText();
		}
		return base.get_localCorners();
	}

	public FontStyle get_fontStyle()
	{
		return mFontStyle;
	}

	public int GetCharacterIndex(int MFOLBKEIIFA, KeyCode NNKLGFNHPBE)
	{
		if (OOFLKFJCBEC())
		{
			string processedText = get_processedText();
			if (string.IsNullOrEmpty(processedText))
			{
				return 0;
			}
			int defaultFontSize = get_defaultFontSize();
			UpdateNGUIText();
			MGDLEEIDDII.KLANINGKMOI(processedText, MMJGJAHOHBA, COODAIDGDPG);
			if (MMJGJAHOHBA.POIJPKODPCK > 0)
			{
				NAKGAEEAPGN(MMJGJAHOHBA, 0);
				for (int i = 0; i < COODAIDGDPG.POIJPKODPCK; i++)
				{
					if (COODAIDGDPG.AOBAKCJKELK(i) == MFOLBKEIIFA)
					{
						Vector2 hEPNHCEIFMO = MMJGJAHOHBA.AOBAKCJKELK(i);
						switch (NNKLGFNHPBE)
						{
						case KeyCode.UpArrow:
							hEPNHCEIFMO.y += defaultFontSize + get_spacingY();
							break;
						case KeyCode.DownArrow:
							hEPNHCEIFMO.y -= defaultFontSize + get_spacingY();
							break;
						case KeyCode.Home:
							hEPNHCEIFMO.x -= 1000f;
							break;
						case KeyCode.End:
							hEPNHCEIFMO.x += 1000f;
							break;
						}
						int jEGKPPHBBKI = MGDLEEIDDII.FDNLMBEIOLL(MMJGJAHOHBA, hEPNHCEIFMO);
						jEGKPPHBBKI = COODAIDGDPG.AOBAKCJKELK(jEGKPPHBBKI);
						if (jEGKPPHBBKI == MFOLBKEIIFA)
						{
							break;
						}
						MMJGJAHOHBA.PDCPMDCOLOD();
						COODAIDGDPG.PDCPMDCOLOD();
						return jEGKPPHBBKI;
					}
				}
				MMJGJAHOHBA.PDCPMDCOLOD();
				COODAIDGDPG.PDCPMDCOLOD();
			}
			MGDLEEIDDII.BOLNHAFHHLH = null;
			MGDLEEIDDII.AFADEAFMPPG = null;
			switch (NNKLGFNHPBE)
			{
			case KeyCode.UpArrow:
			case KeyCode.Home:
				return 0;
			case KeyCode.DownArrow:
			case KeyCode.End:
				return processedText.Length;
			}
		}
		return MFOLBKEIIFA;
	}

	public string GetUrlAtPosition(Vector2 INLNMEABHBF)
	{
		return GetUrlAtCharacterIndex(GetCharacterIndexAtPosition(INLNMEABHBF));
	}

	private void CGJJNBEILDH(global::MABNNPIGEPM<Vector3> HILIICKOOFH, global::MABNNPIGEPM<Vector2> MDBIEMHCFFO, global::MABNNPIGEPM<Color32> NAMIAMEOHAP, int GAKOOBECLIB, int IDFCFEOMBKP, float MPBOINGECFO, float OECPEJEIMHO)
	{
		Color color = mEffectColor;
		color.a *= finalAlpha;
		Color32 color2 = ((!(get_bitmapFont() != null) || !get_bitmapFont().get_premultipliedAlphaShader()) ? color : NLDABIMKKMP.CPFGKGLEIKJ(color));
		for (int i = GAKOOBECLIB; i < IDFCFEOMBKP; i++)
		{
			HILIICKOOFH.GBFCKODJEGE(HILIICKOOFH.EDMNHDBEPMC[i]);
			MDBIEMHCFFO.GBFCKODJEGE(MDBIEMHCFFO.EDMNHDBEPMC[i]);
			NAMIAMEOHAP.GBFCKODJEGE(NAMIAMEOHAP.EDMNHDBEPMC[i]);
			Vector3 vector = HILIICKOOFH.EDMNHDBEPMC[i];
			vector.x += MPBOINGECFO;
			vector.y += OECPEJEIMHO;
			HILIICKOOFH.EDMNHDBEPMC[i] = vector;
			Color32 color3 = NAMIAMEOHAP.EDMNHDBEPMC[i];
			if (color3.a == byte.MaxValue)
			{
				NAMIAMEOHAP.EDMNHDBEPMC[i] = color2;
				continue;
			}
			Color color4 = color;
			color4.a = (float)(int)color3.a / 255f * color.a;
			NAMIAMEOHAP.EDMNHDBEPMC[i] = ((!(get_bitmapFont() != null) || !get_bitmapFont().get_premultipliedAlphaShader()) ? color4 : NLDABIMKKMP.CPFGKGLEIKJ(color4));
		}
	}

	protected override void ADEEMHKMJBF()
	{
		if (mOverflow == JCMMPAEEKEC.ResizeFreely)
		{
			if (get_isFullyAnchored())
			{
				mOverflow = JCMMPAEEKEC.ShrinkContent;
			}
		}
		else if (mOverflow == JCMMPAEEKEC.ResizeHeight && topAnchor.target != null && bottomAnchor.target != null)
		{
			mOverflow = JCMMPAEEKEC.ShrinkContent;
		}
		base.ADEEMHKMJBF();
	}

	public void set_text(string ICENKPDOHBK)
	{
		if (mText == ICENKPDOHBK)
		{
			return;
		}
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			if (!string.IsNullOrEmpty(mText))
			{
				mText = string.Empty;
				MarkAsChanged();
				DDBEHIEMCEE();
			}
		}
		else if (mText != ICENKPDOHBK)
		{
			mText = ICENKPDOHBK;
			MarkAsChanged();
			DDBEHIEMCEE();
		}
		if (autoResizeBoxCollider)
		{
			ResizeCollider();
		}
	}

	public string GetUrlAtPosition(Vector3 IMCBPDJDNPG)
	{
		return GetUrlAtCharacterIndex(GetCharacterIndexAtPosition(IMCBPDJDNPG));
	}

	public void set_lineWidth(int ICENKPDOHBK)
	{
		set_width(ICENKPDOHBK);
	}

	public override Vector4 get_drawingDimensions()
	{
		if (OONGCDNECEM())
		{
			ProcessText();
		}
		return base.get_drawingDimensions();
	}

	public Color get_gradientTop()
	{
		return mGradientTop;
	}

	public void set_supportEncoding(bool ICENKPDOHBK)
	{
		if (mEncoding != ICENKPDOHBK)
		{
			mEncoding = ICENKPDOHBK;
			AINDNBGCFPJ(true);
		}
	}

	private void DDBEHIEMCEE()
	{
		if (get_ambigiousFont() != null)
		{
			ProcessText();
		}
	}

	public string GetWordAtCharacterIndex(int CMPEAKAIHHH)
	{
		if (CMPEAKAIHHH != -1 && CMPEAKAIHHH < mText.Length)
		{
			int num = mText.LastIndexOf(' ', CMPEAKAIHHH) + 1;
			int num2 = mText.IndexOf(' ', CMPEAKAIHHH);
			if (num2 == -1)
			{
				num2 = mText.Length;
			}
			if (num != num2)
			{
				int num3 = num2 - num;
				if (num3 > 0)
				{
					string bMNKKBDCELE = mText.Substring(num, num3);
					return MGDLEEIDDII.AFNLFGAHKKC(bMNKKBDCELE);
				}
			}
		}
		return null;
	}

	public void set_font(UIFont ICENKPDOHBK)
	{
		set_bitmapFont(ICENKPDOHBK);
	}

	protected override void PCIBIJNAIKF()
	{
		base.PCIBIJNAIKF();
		if (mLineWidth > 0f)
		{
			mMaxLineWidth = Mathf.RoundToInt(mLineWidth);
			mLineWidth = 0f;
		}
		if (!mMultiline)
		{
			mMaxLineCount = 1;
			mMultiline = true;
		}
		LKIAIJEEFIH = get_material() != null && get_material().shader != null && get_material().shader.name.Contains("Premultiplied");
		DDBEHIEMCEE();
	}

	public void set_gradientBottom(Color ICENKPDOHBK)
	{
		if (mGradientBottom != ICENKPDOHBK)
		{
			mGradientBottom = ICENKPDOHBK;
			if (mApplyGradient)
			{
				MarkAsChanged();
			}
		}
	}

	public bool Wrap(string BMNKKBDCELE, out string BINKGJBHAAI)
	{
		return Wrap(BMNKKBDCELE, out BINKGJBHAAI, 1000000);
	}

	public int get_spacingX()
	{
		return mSpacingX;
	}

	public override Vector3[] get_worldCorners()
	{
		if (OONGCDNECEM())
		{
			ProcessText();
		}
		return base.get_worldCorners();
	}

	public override Material get_material()
	{
		if (mMaterial != null)
		{
			return mMaterial;
		}
		if (mFont != null)
		{
			return mFont.get_material();
		}
		if (mTrueTypeFont != null)
		{
			return mTrueTypeFont.material;
		}
		return null;
	}

	[SpecialName]
	public void GACEDJJHFGD(MGDLEEIDDII.NBEGJBKHJLH ICENKPDOHBK)
	{
		if (mAlignment != ICENKPDOHBK)
		{
			mAlignment = ICENKPDOHBK;
			AINDNBGCFPJ(true);
			DDBEHIEMCEE();
		}
	}

	public void SetCurrentSelection()
	{
		if (UIPopupList.current != null)
		{
			set_text((!UIPopupList.current.isLocalized) ? UIPopupList.current.get_value() : FKHDOBFNMLP.OHKHGNFHJJM(UIPopupList.current.get_value()));
		}
	}

	public int get_fontSize()
	{
		return mFontSize;
	}

	public int get_defaultFontSize()
	{
		return (get_trueTypeFont() != null) ? mFontSize : ((!(mFont != null)) ? 16 : mFont.get_defaultSize());
	}

	protected virtual void ANLIKCICGDF()
	{
		if (mOverflow == JCMMPAEEKEC.ShrinkContent)
		{
			if (get_isFullyAnchored())
			{
				mOverflow = JCMMPAEEKEC.ClampContent;
			}
		}
		else if (mOverflow == JCMMPAEEKEC.ResizeFreely && topAnchor.target != null && bottomAnchor.target != null)
		{
			mOverflow = JCMMPAEEKEC.ClampContent;
		}
		base.ADEEMHKMJBF();
	}

	public void set_spacingX(int ICENKPDOHBK)
	{
		if (mSpacingX != ICENKPDOHBK)
		{
			mSpacingX = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public Vector2 get_effectDistance()
	{
		return mEffectDistance;
	}

	public void set_overflowMethod(JCMMPAEEKEC ICENKPDOHBK)
	{
		if (mOverflow != ICENKPDOHBK)
		{
			mOverflow = ICENKPDOHBK;
			AINDNBGCFPJ(true);
		}
	}

	public override void set_material(Material ICENKPDOHBK)
	{
		if (mMaterial != ICENKPDOHBK)
		{
			MarkAsChanged();
			mMaterial = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public string GetWordAtPosition(Vector2 INLNMEABHBF)
	{
		return GetWordAtCharacterIndex(GetCharacterIndexAtPosition(INLNMEABHBF));
	}

	private bool OOFLKFJCBEC()
	{
		return mFont != null || mTrueTypeFont != null;
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector2 INLNMEABHBF)
	{
		return GetCharacterIndexAtPosition(INLNMEABHBF);
	}

	public int get_spacingY()
	{
		return mSpacingY;
	}

	[SpecialName]
	public void DCKJILCPKFD(string ICENKPDOHBK)
	{
		if (mText == ICENKPDOHBK)
		{
			return;
		}
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			if (!string.IsNullOrEmpty(mText))
			{
				mText = string.Empty;
				MarkAsChanged();
				DDBEHIEMCEE();
			}
		}
		else if (mText != ICENKPDOHBK)
		{
			mText = ICENKPDOHBK;
			MarkAsChanged();
			DDBEHIEMCEE();
		}
		if (autoResizeBoxCollider)
		{
			ResizeCollider();
		}
	}

	[Obsolete("Use UILabel.GetCharacterAtPosition instead")]
	public int GetCharacterIndex(Vector3 IMCBPDJDNPG)
	{
		return GetCharacterIndexAtPosition(IMCBPDJDNPG);
	}

	public void SetCurrentProgress()
	{
		if (UIProgressBar.current != null)
		{
			set_text(UIProgressBar.current.get_value().ToString("F"));
		}
	}

	protected override void OHHOHFAGBBF()
	{
		base.OHHOHFAGBBF();
		PCHDMFNAGBH.GBFCKODJEGE(this);
		EGNLMAOOHHL(get_trueTypeFont());
	}

	public void set_gradientTop(Color ICENKPDOHBK)
	{
		if (mGradientTop != ICENKPDOHBK)
		{
			mGradientTop = ICENKPDOHBK;
			if (mApplyGradient)
			{
				MarkAsChanged();
			}
		}
	}

	public void set_symbolStyle(MGDLEEIDDII.OOGEENANIAD ICENKPDOHBK)
	{
		if (mSymbols != ICENKPDOHBK)
		{
			mSymbols = ICENKPDOHBK;
			AINDNBGCFPJ(true);
		}
	}
}
