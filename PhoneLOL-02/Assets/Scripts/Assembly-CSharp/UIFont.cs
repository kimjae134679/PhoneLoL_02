using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/NGUI Font")]
[ExecuteInEditMode]
public class UIFont : MonoBehaviour
{
	[SerializeField]
	[HideInInspector]
	private Material mMat;

	[HideInInspector]
	[SerializeField]
	private Rect mUVRect = new Rect(0f, 0f, 1f, 1f);

	[SerializeField]
	[HideInInspector]
	private BMFont mFont = new BMFont();

	[SerializeField]
	[HideInInspector]
	private UIAtlas mAtlas;

	[HideInInspector]
	[SerializeField]
	private UIFont mReplacement;

	[HideInInspector]
	[SerializeField]
	private List<BMSymbol> mSymbols = new List<BMSymbol>();

	[SerializeField]
	[HideInInspector]
	private Font mDynamicFont;

	[HideInInspector]
	[SerializeField]
	private int mDynamicFontSize = 16;

	[SerializeField]
	[HideInInspector]
	private FontStyle mDynamicFontStyle;

	[NonSerialized]
	private UISpriteData MCOKEKMANAF;

	private int MJIKPDACEDJ = -1;

	private int MCMMABFKCHO = -1;

	public BMFont EJMHHLGDMGA
	{
		get
		{
			return get_bmFont();
		}
		set
		{
			set_bmFont(value);
		}
	}

	public int IOHPOONELAG
	{
		get
		{
			return get_texWidth();
		}
		set
		{
			set_texWidth(value);
		}
	}

	public int NOOLAEONJPF
	{
		get
		{
			return get_texHeight();
		}
		set
		{
			set_texHeight(value);
		}
	}

	public bool DMIINLMHOOG
	{
		get
		{
			return get_hasSymbols();
		}
	}

	public List<BMSymbol> PNDBFIGIAMM
	{
		get
		{
			return get_symbols();
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

	public Material BJJILBPBOGP
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

	public bool LICFIIMABMB
	{
		get
		{
			return get_premultipliedAlphaShader();
		}
	}

	public bool HIBOFMCADDP
	{
		get
		{
			return get_packedFontShader();
		}
	}

	public Texture2D EIMMPDHKMKN
	{
		get
		{
			return get_texture();
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

	[Obsolete("Use UIFont.defaultSize instead")]
	public int POIJPKODPCK
	{
		get
		{
			return get_size();
		}
		set
		{
			set_size(value);
		}
	}

	public int NKMJALJMKNA
	{
		get
		{
			return get_defaultSize();
		}
		set
		{
			set_defaultSize(value);
		}
	}

	public UISpriteData BGOMOIOJAPC
	{
		get
		{
			return get_sprite();
		}
	}

	public UIFont GDGGNNJBJKM
	{
		get
		{
			return get_replacement();
		}
		set
		{
			set_replacement(value);
		}
	}

	public bool EKFCHOJPING
	{
		get
		{
			return get_isDynamic();
		}
	}

	public Font AFADEAFMPPG
	{
		get
		{
			return get_dynamicFont();
		}
		set
		{
			set_dynamicFont(value);
		}
	}

	public FontStyle KNMDEGGJJAA
	{
		get
		{
			return get_dynamicFontStyle();
		}
		set
		{
			set_dynamicFontStyle(value);
		}
	}

	private Texture PFCFADOIEAJ
	{
		get
		{
			return CGOEFJEPDNM();
		}
	}

	public string get_spriteName()
	{
		return (!(mReplacement != null)) ? mFont.spriteName : mReplacement.get_spriteName();
	}

	public static bool CheckIfRelated(UIFont IFGAPHGCLHF, UIFont GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF == null || GMMDCPLBFJL == null)
		{
			return false;
		}
		if (IFGAPHGCLHF.get_isDynamic() && GMMDCPLBFJL.get_isDynamic() && IFGAPHGCLHF.get_dynamicFont().fontNames[0] == GMMDCPLBFJL.get_dynamicFont().fontNames[0])
		{
			return true;
		}
		return IFGAPHGCLHF == GMMDCPLBFJL || IFGAPHGCLHF.CBFKKNIOODG(GMMDCPLBFJL) || GMMDCPLBFJL.CBFKKNIOODG(IFGAPHGCLHF);
	}

	public Rect get_uvRect()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_uvRect();
		}
		return (!(mAtlas != null) || get_sprite() == null) ? new Rect(0f, 0f, 1f, 1f) : mUVRect;
	}

	[SpecialName]
	public void DHOJMJFHJGG(BMFont ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.DHOJMJFHJGG(ICENKPDOHBK);
		}
		else
		{
			mFont = ICENKPDOHBK;
		}
	}

	private void EHPLJHCACAA()
	{
		Texture texture = mAtlas.get_texture();
		if (texture != null && MCOKEKMANAF != null)
		{
			Rect rect = HHAINCPODGE.MEDHFBHAEAE(mUVRect, get_texture().width, get_texture().height, true);
			Rect rect2 = new Rect(MCOKEKMANAF.x, MCOKEKMANAF.y, MCOKEKMANAF.width, MCOKEKMANAF.height);
			int hCMGBFNGLAI = Mathf.RoundToInt(rect2.xMin - rect.xMin);
			int cCKPHGIAIAC = Mathf.RoundToInt(rect2.yMin - rect.yMin);
			int fAFIACNJEGP = Mathf.RoundToInt(rect2.xMax - rect.xMin);
			int eDPEJFDHPGP = Mathf.RoundToInt(rect2.yMax - rect.yMin);
			mFont.EHPLJHCACAA(hCMGBFNGLAI, cCKPHGIAIAC, fAFIACNJEGP, eDPEJFDHPGP);
		}
	}

	public bool get_isDynamic()
	{
		return (!(mReplacement != null)) ? (mDynamicFont != null) : mReplacement.get_isDynamic();
	}

	private BMSymbol EBHJAKJAHLH(string EJIABJKFOIE, bool LJHPCELEBKK)
	{
		int i = 0;
		for (int count = mSymbols.Count; i < count; i++)
		{
			BMSymbol bMSymbol = mSymbols[i];
			if (bMSymbol.sequence == EJIABJKFOIE)
			{
				return bMSymbol;
			}
		}
		if (LJHPCELEBKK)
		{
			BMSymbol bMSymbol2 = new BMSymbol();
			bMSymbol2.sequence = EJIABJKFOIE;
			mSymbols.Add(bMSymbol2);
			return bMSymbol2;
		}
		return null;
	}

	public UISpriteData get_sprite()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_sprite();
		}
		if (MCOKEKMANAF == null && mAtlas != null && !string.IsNullOrEmpty(mFont.spriteName))
		{
			MCOKEKMANAF = mAtlas.GetSprite(mFont.spriteName);
			if (MCOKEKMANAF == null)
			{
				MCOKEKMANAF = mAtlas.GetSprite(base.name);
			}
			if (MCOKEKMANAF == null)
			{
				mFont.spriteName = null;
			}
			else
			{
				UpdateUVRect();
			}
			int i = 0;
			for (int count = mSymbols.Count; i < count; i++)
			{
				get_symbols()[i].KENEGPNLIOO();
			}
		}
		return MCOKEKMANAF;
	}

	public UIFont get_replacement()
	{
		return mReplacement;
	}

	public void set_spriteName(string ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_spriteName(ICENKPDOHBK);
		}
		else if (mFont.spriteName != ICENKPDOHBK)
		{
			mFont.spriteName = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public List<BMSymbol> get_symbols()
	{
		return (!(mReplacement != null)) ? mSymbols : mReplacement.get_symbols();
	}

	public bool get_premultipliedAlphaShader()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_premultipliedAlphaShader();
		}
		if (mAtlas != null)
		{
			return mAtlas.get_premultipliedAlpha();
		}
		if (MJIKPDACEDJ == -1)
		{
			Material material = get_material();
			MJIKPDACEDJ = ((material != null && material.shader != null && material.shader.name.Contains("Premultiplied")) ? 1 : 0);
		}
		return MJIKPDACEDJ == 1;
	}

	private bool CBFKKNIOODG(UIFont OGGNOMLIGBI)
	{
		if (OGGNOMLIGBI == null)
		{
			return false;
		}
		if (OGGNOMLIGBI == this)
		{
			return true;
		}
		return mReplacement != null && mReplacement.CBFKKNIOODG(OGGNOMLIGBI);
	}

	public void UpdateUVRect()
	{
		if (mAtlas == null)
		{
			return;
		}
		Texture texture = mAtlas.get_texture();
		if (texture != null)
		{
			mUVRect = new Rect(MCOKEKMANAF.x - MCOKEKMANAF.paddingLeft, MCOKEKMANAF.y - MCOKEKMANAF.paddingTop, MCOKEKMANAF.width + MCOKEKMANAF.paddingLeft + MCOKEKMANAF.paddingRight, MCOKEKMANAF.height + MCOKEKMANAF.paddingTop + MCOKEKMANAF.paddingBottom);
			mUVRect = HHAINCPODGE.KOAAFAOHINH(mUVRect, texture.width, texture.height);
			if (MCOKEKMANAF.hasPadding)
			{
				EHPLJHCACAA();
			}
		}
	}

	[SpecialName]
	public void ENLDIMNFIAA(int ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_defaultSize(ICENKPDOHBK);
		}
		else
		{
			mDynamicFontSize = ICENKPDOHBK;
		}
	}

	[SpecialName]
	public FontStyle DKHLCCBMJIJ()
	{
		return (!(mReplacement != null)) ? mDynamicFontStyle : mReplacement.DKHLCCBMJIJ();
	}

	private BMSymbol IDFHHEBGFLN(string EJIABJKFOIE, bool LJHPCELEBKK)
	{
		int i = 1;
		for (int count = mSymbols.Count; i < count; i++)
		{
			BMSymbol bMSymbol = mSymbols[i];
			if (bMSymbol.sequence == EJIABJKFOIE)
			{
				return bMSymbol;
			}
		}
		if (LJHPCELEBKK)
		{
			BMSymbol bMSymbol2 = new BMSymbol();
			bMSymbol2.sequence = EJIABJKFOIE;
			mSymbols.Add(bMSymbol2);
			return bMSymbol2;
		}
		return null;
	}

	public void set_uvRect(Rect ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_uvRect(ICENKPDOHBK);
		}
		else if (get_sprite() == null && mUVRect != ICENKPDOHBK)
		{
			mUVRect = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public void set_texHeight(int ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_texHeight(ICENKPDOHBK);
		}
		else if (mFont != null)
		{
			mFont.texHeight = ICENKPDOHBK;
		}
	}

	public void set_dynamicFontStyle(FontStyle ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_dynamicFontStyle(ICENKPDOHBK);
		}
		else if (mDynamicFontStyle != ICENKPDOHBK)
		{
			mDynamicFontStyle = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public bool get_packedFontShader()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_packedFontShader();
		}
		if (mAtlas != null)
		{
			return false;
		}
		if (MCMMABFKCHO == -1)
		{
			Material material = get_material();
			MCMMABFKCHO = ((material != null && material.shader != null && material.shader.name.Contains("Packed")) ? 1 : 0);
		}
		return MCMMABFKCHO == 1;
	}

	public void RemoveSymbol(string EJIABJKFOIE)
	{
		BMSymbol bMSymbol = EBHJAKJAHLH(EJIABJKFOIE, false);
		if (bMSymbol != null)
		{
			get_symbols().Remove(bMSymbol);
		}
		MarkAsChanged();
	}

	public void set_replacement(UIFont ICENKPDOHBK)
	{
		UIFont uIFont = ICENKPDOHBK;
		if (uIFont == this)
		{
			uIFont = null;
		}
		if (mReplacement != uIFont)
		{
			if (uIFont != null && uIFont.get_replacement() == this)
			{
				uIFont.set_replacement(null);
			}
			if (mReplacement != null)
			{
				MarkAsChanged();
			}
			mReplacement = uIFont;
			if (uIFont != null)
			{
				MJIKPDACEDJ = -1;
				mMat = null;
				mFont = null;
				mDynamicFont = null;
			}
			MarkAsChanged();
		}
	}

	private void ECEECANLBBJ()
	{
		Texture texture = mAtlas.get_texture();
		if (texture != null && MCOKEKMANAF != null)
		{
			Rect rect = HHAINCPODGE.MEDHFBHAEAE(mUVRect, get_texture().width, get_texture().height, true);
			Rect rect2 = new Rect(MCOKEKMANAF.x, MCOKEKMANAF.y, MCOKEKMANAF.width, MCOKEKMANAF.height);
			int hCMGBFNGLAI = Mathf.RoundToInt(rect2.xMin - rect.xMin);
			int cCKPHGIAIAC = Mathf.RoundToInt(rect2.yMin - rect.yMin);
			int fAFIACNJEGP = Mathf.RoundToInt(rect2.xMax - rect.xMin);
			int eDPEJFDHPGP = Mathf.RoundToInt(rect2.yMax - rect.yMin);
			mFont.EHPLJHCACAA(hCMGBFNGLAI, cCKPHGIAIAC, fAFIACNJEGP, eDPEJFDHPGP);
		}
	}

	public int get_texWidth()
	{
		return (mReplacement != null) ? mReplacement.get_texWidth() : ((mFont == null) ? 1 : mFont.texWidth);
	}

	[SpecialName]
	public UIAtlas MHHNBLOFPPO()
	{
		return (!(mReplacement != null)) ? mAtlas : mReplacement.MHHNBLOFPPO();
	}

	private Texture CGOEFJEPDNM()
	{
		if ((bool)mReplacement)
		{
			return mReplacement.CGOEFJEPDNM();
		}
		if (get_isDynamic())
		{
			return mDynamicFont.material.mainTexture;
		}
		return null;
	}

	public BMFont get_bmFont()
	{
		return (!(mReplacement != null)) ? mFont : mReplacement.get_bmFont();
	}

	public int get_defaultSize()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_defaultSize();
		}
		if (get_isDynamic() || mFont == null)
		{
			return mDynamicFontSize;
		}
		return mFont.charSize;
	}

	public void AddSymbol(string EJIABJKFOIE, string ADNCNHHHCBF)
	{
		BMSymbol bMSymbol = EBHJAKJAHLH(EJIABJKFOIE, true);
		bMSymbol.spriteName = ADNCNHHHCBF;
		MarkAsChanged();
	}

	public int get_size()
	{
		return get_defaultSize();
	}

	public bool UsesSprite(string MABBPNNIMBJ)
	{
		if (!string.IsNullOrEmpty(MABBPNNIMBJ))
		{
			if (MABBPNNIMBJ.Equals(get_spriteName()))
			{
				return true;
			}
			int i = 0;
			for (int count = get_symbols().Count; i < count; i++)
			{
				BMSymbol bMSymbol = get_symbols()[i];
				if (MABBPNNIMBJ.Equals(bMSymbol.spriteName))
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool get_isValid()
	{
		return mDynamicFont != null || mFont.isValid;
	}

	public void set_atlas(UIAtlas ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_atlas(ICENKPDOHBK);
		}
		else
		{
			if (!(mAtlas != ICENKPDOHBK))
			{
				return;
			}
			if (ICENKPDOHBK == null)
			{
				if (mAtlas != null)
				{
					mMat = mAtlas.get_spriteMaterial();
				}
				if (get_sprite() != null)
				{
					mUVRect = get_uvRect();
				}
			}
			MJIKPDACEDJ = -1;
			mAtlas = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public void set_size(int ICENKPDOHBK)
	{
		set_defaultSize(ICENKPDOHBK);
	}

	public void set_dynamicFont(Font ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_dynamicFont(ICENKPDOHBK);
		}
		else if (mDynamicFont != ICENKPDOHBK)
		{
			if (mDynamicFont != null)
			{
				set_material(null);
			}
			mDynamicFont = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public Material get_material()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_material();
		}
		if (mAtlas != null)
		{
			return mAtlas.get_spriteMaterial();
		}
		if (mMat != null)
		{
			if (mDynamicFont != null && mMat != mDynamicFont.material)
			{
				mMat.mainTexture = mDynamicFont.material.mainTexture;
			}
			return mMat;
		}
		if (mDynamicFont != null)
		{
			return mDynamicFont.material;
		}
		return null;
	}

	public void set_material(Material ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_material(ICENKPDOHBK);
		}
		else if (mMat != ICENKPDOHBK)
		{
			MJIKPDACEDJ = -1;
			mMat = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	public void EDBAGAJIIPK(string EJIABJKFOIE, string ADNCNHHHCBF)
	{
		BMSymbol bMSymbol = IDFHHEBGFLN(EJIABJKFOIE, true);
		bMSymbol.spriteName = ADNCNHHHCBF;
		MarkAsChanged();
	}

	public void RenameSymbol(string MDGOBGPDGHN, string DCMLDAONFNE)
	{
		BMSymbol bMSymbol = EBHJAKJAHLH(MDGOBGPDGHN, false);
		if (bMSymbol != null)
		{
			bMSymbol.sequence = DCMLDAONFNE;
		}
		MarkAsChanged();
	}

	public void set_bmFont(BMFont ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_bmFont(ICENKPDOHBK);
		}
		else
		{
			mFont = ICENKPDOHBK;
		}
	}

	public void MarkAsChanged()
	{
		if (mReplacement != null)
		{
			mReplacement.MarkAsChanged();
		}
		MCOKEKMANAF = null;
		UILabel[] array = NLDABIMKKMP.MHMBABFFMHO<UILabel>();
		int i = 0;
		for (int num = array.Length; i < num; i++)
		{
			UILabel uILabel = array[i];
			if (uILabel.enabled && NLDABIMKKMP.FGIDLKLMBHB(uILabel.gameObject) && CheckIfRelated(this, uILabel.get_bitmapFont()))
			{
				UIFont bitmapFont = uILabel.get_bitmapFont();
				uILabel.set_bitmapFont(null);
				uILabel.set_bitmapFont(bitmapFont);
			}
		}
		int j = 0;
		for (int count = get_symbols().Count; j < count; j++)
		{
			get_symbols()[j].KENEGPNLIOO();
		}
	}

	public Texture2D get_texture()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_texture();
		}
		Material material = get_material();
		return (!(material != null)) ? null : (material.mainTexture as Texture2D);
	}

	public Font get_dynamicFont()
	{
		return (!(mReplacement != null)) ? mDynamicFont : mReplacement.get_dynamicFont();
	}

	public bool get_hasSymbols()
	{
		return (mReplacement != null) ? mReplacement.get_hasSymbols() : (mSymbols != null && mSymbols.Count != 0);
	}

	public BMSymbol MatchSymbol(string BMNKKBDCELE, int BFEECILPJLM, int LDBGBEKBKOC)
	{
		int count = mSymbols.Count;
		if (count == 0)
		{
			return null;
		}
		LDBGBEKBKOC -= BFEECILPJLM;
		for (int i = 0; i < count; i++)
		{
			BMSymbol bMSymbol = mSymbols[i];
			int length = bMSymbol.length;
			if (length == 0 || LDBGBEKBKOC < length)
			{
				continue;
			}
			bool flag = true;
			for (int j = 0; j < length; j++)
			{
				if (BMNKKBDCELE[BFEECILPJLM + j] != bMSymbol.sequence[j])
				{
					flag = false;
					break;
				}
			}
			if (flag && bMSymbol.PBHCIHJGEOO(get_atlas()))
			{
				return bMSymbol;
			}
		}
		return null;
	}

	public void set_defaultSize(int ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_defaultSize(ICENKPDOHBK);
		}
		else
		{
			mDynamicFontSize = ICENKPDOHBK;
		}
	}

	public void set_texWidth(int ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_texWidth(ICENKPDOHBK);
		}
		else if (mFont != null)
		{
			mFont.texWidth = ICENKPDOHBK;
		}
	}

	public void KGHOFNAEGHD(string MDGOBGPDGHN, string DCMLDAONFNE)
	{
		BMSymbol bMSymbol = FMDEGNKIMPI(MDGOBGPDGHN, false);
		if (bMSymbol != null)
		{
			bMSymbol.sequence = DCMLDAONFNE;
		}
		MarkAsChanged();
	}

	public UIAtlas get_atlas()
	{
		return (!(mReplacement != null)) ? mAtlas : mReplacement.get_atlas();
	}

	public FontStyle get_dynamicFontStyle()
	{
		return (!(mReplacement != null)) ? mDynamicFontStyle : mReplacement.get_dynamicFontStyle();
	}

	[SpecialName]
	public UIAtlas LCEJKCEJGAL()
	{
		return (!(mReplacement != null)) ? mAtlas : mReplacement.MHHNBLOFPPO();
	}

	[SpecialName]
	public void OAKAMKGNJPA(Material ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.OAKAMKGNJPA(ICENKPDOHBK);
		}
		else if (mMat != ICENKPDOHBK)
		{
			MJIKPDACEDJ = -1;
			mMat = ICENKPDOHBK;
			MarkAsChanged();
		}
	}

	[SpecialName]
	public bool JOECNDFLKDE()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_premultipliedAlphaShader();
		}
		if (mAtlas != null)
		{
			return mAtlas.get_premultipliedAlpha();
		}
		if (MJIKPDACEDJ == -1)
		{
			Material material = get_material();
			MJIKPDACEDJ = ((!(material != null) || !(material.shader != null) || !material.shader.name.Contains("Hero3")) ? 1 : 0);
		}
		return MJIKPDACEDJ == 1;
	}

	private BMSymbol FMDEGNKIMPI(string EJIABJKFOIE, bool LJHPCELEBKK)
	{
		int i = 1;
		for (int count = mSymbols.Count; i < count; i++)
		{
			BMSymbol bMSymbol = mSymbols[i];
			if (bMSymbol.sequence == EJIABJKFOIE)
			{
				return bMSymbol;
			}
		}
		if (LJHPCELEBKK)
		{
			BMSymbol bMSymbol2 = new BMSymbol();
			bMSymbol2.sequence = EJIABJKFOIE;
			mSymbols.Add(bMSymbol2);
			return bMSymbol2;
		}
		return null;
	}

	public int get_texHeight()
	{
		return (mReplacement != null) ? mReplacement.get_texHeight() : ((mFont == null) ? 1 : mFont.texHeight);
	}

	public void OGMLEKGNNDC(string EJIABJKFOIE)
	{
		BMSymbol bMSymbol = IDFHHEBGFLN(EJIABJKFOIE, false);
		if (bMSymbol != null)
		{
			get_symbols().Remove(bMSymbol);
		}
		MarkAsChanged();
	}
}
