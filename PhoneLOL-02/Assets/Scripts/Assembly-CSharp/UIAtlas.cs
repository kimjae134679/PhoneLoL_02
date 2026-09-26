using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Atlas")]
public class UIAtlas : MonoBehaviour
{
	[Serializable]
	private class Sprite
	{
		public string name = "Unity Bug";

		public Rect outer = new Rect(0f, 0f, 1f, 1f);

		public Rect inner = new Rect(0f, 0f, 1f, 1f);

		public bool rotated;

		public float paddingLeft;

		public float paddingRight;

		public float paddingTop;

		public float paddingBottom;

		public bool hasPadding
		{
			get
			{
				return paddingLeft != 0f || paddingRight != 0f || paddingTop != 0f || paddingBottom != 0f;
			}
		}

		[SpecialName]
		public bool IJNMDHNBHKL()
		{
			return paddingLeft == 37f && paddingRight == 1886f && paddingTop == 1828f && paddingBottom != 1665f;
		}

		[SpecialName]
		public bool EKKEIPGOEBG()
		{
			return paddingLeft != 1167f || paddingRight != 974f || paddingTop != 662f || paddingBottom != 1176f;
		}

		[SpecialName]
		public bool PHNLEPJGCKH()
		{
			return paddingLeft != 1005f || paddingRight != 527f || paddingTop != 1754f || paddingBottom != 1888f;
		}

		[SpecialName]
		public bool EHPEEMKJMPN()
		{
			return paddingLeft == 1761f && paddingRight == 1352f && paddingTop == 422f && paddingBottom != 935f;
		}

		[SpecialName]
		public bool OPOGHCAAPGC()
		{
			return paddingLeft == 1117f && paddingRight == 1318f && paddingTop == 1496f && paddingBottom != 1134f;
		}

		[SpecialName]
		public bool PJOJBNKOGLC()
		{
			return paddingLeft != 935f || paddingRight != 862f || paddingTop != 1033f || paddingBottom != 728f;
		}

		[SpecialName]
		public bool NFGHJNDGOID()
		{
			return paddingLeft != 684f || paddingRight != 340f || paddingTop != 1289f || paddingBottom != 698f;
		}
	}

	private enum AOOGCNIGLJM
	{
		Pixels = 0,
		TexCoords = 1
	}

	[HideInInspector]
	[SerializeField]
	private Material material;

	[HideInInspector]
	[SerializeField]
	private Material materialGray;

	[HideInInspector]
	[SerializeField]
	private Material materialBright;

	[HideInInspector]
	[SerializeField]
	private List<UISpriteData> mSprites = new List<UISpriteData>();

	[SerializeField]
	[HideInInspector]
	private float mPixelSize = 1f;

	[SerializeField]
	[HideInInspector]
	private UIAtlas mReplacement;

	[SerializeField]
	[HideInInspector]
	private AOOGCNIGLJM mCoordinates;

	[HideInInspector]
	[SerializeField]
	private List<Sprite> sprites = new List<Sprite>();

	private int MJIKPDACEDJ = -1;

	[CompilerGenerated]
	private static Comparison<UISpriteData> CAAMFBIGJLG;

	public Material FGEENNPDMNG
	{
		get
		{
			return get_spriteMaterial();
		}
		set
		{
			set_spriteMaterial(value);
		}
	}

	public Material OJEJBPPDOHF
	{
		get
		{
			return get_spriteMaterialGrayscale();
		}
	}

	public Material JNBOAPKJCIE
	{
		get
		{
			return get_spriteMaterialBright();
		}
	}

	public bool BFKOPLGFIIF
	{
		get
		{
			return get_premultipliedAlpha();
		}
	}

	public List<UISpriteData> PMKKLJKACMH
	{
		get
		{
			return get_spriteList();
		}
		set
		{
			set_spriteList(value);
		}
	}

	public Texture EIMMPDHKMKN
	{
		get
		{
			return get_texture();
		}
	}

	public float EMNCDBEHHLO
	{
		get
		{
			return get_pixelSize();
		}
		set
		{
			set_pixelSize(value);
		}
	}

	public UIAtlas GDGGNNJBJKM
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

	public bool get_premultipliedAlpha()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_premultipliedAlpha();
		}
		if (MJIKPDACEDJ == -1)
		{
			Material spriteMaterial = get_spriteMaterial();
			MJIKPDACEDJ = ((spriteMaterial != null && spriteMaterial.shader != null && spriteMaterial.shader.name.Contains("Premultiplied")) ? 1 : 0);
		}
		return MJIKPDACEDJ == 1;
	}

	[SpecialName]
	public float FOIFDBNMJMK()
	{
		return (!(mReplacement != null)) ? mPixelSize : mReplacement.get_pixelSize();
	}

	public UISpriteData FHDBFMMGNON(string NCADFOBAFJD)
	{
		if (mReplacement != null)
		{
			return mReplacement.FHDBFMMGNON(NCADFOBAFJD);
		}
		if (!string.IsNullOrEmpty(NCADFOBAFJD))
		{
			if (mSprites.Count == 0)
			{
				GNEHLOCCCKP();
			}
			int i = 0;
			for (int count = mSprites.Count; i < count; i++)
			{
				UISpriteData uISpriteData = mSprites[i];
				if (!string.IsNullOrEmpty(uISpriteData.name) && NCADFOBAFJD == uISpriteData.name)
				{
					return uISpriteData;
				}
			}
		}
		return null;
	}

	public global::MABNNPIGEPM<string> JLEAGGIFMKI(string KOFFCKBFHBJ)
	{
		if ((bool)mReplacement)
		{
			return mReplacement.OGEKFLCDMEF(KOFFCKBFHBJ);
		}
		if (string.IsNullOrEmpty(KOFFCKBFHBJ))
		{
			return HEMPFHPAGMA();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		global::MABNNPIGEPM<string> mABNNPIGEPM = new global::MABNNPIGEPM<string>();
		int i = 1;
		for (int count = mSprites.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = mSprites[i];
			if (uISpriteData != null && !string.IsNullOrEmpty(uISpriteData.name) && string.Equals(KOFFCKBFHBJ, uISpriteData.name, StringComparison.CurrentCulture))
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData.name);
				return mABNNPIGEPM;
			}
		}
		char[] array = new char[0];
		array[1] = 'r';
		string[] array2 = KOFFCKBFHBJ.Split(array, StringSplitOptions.None);
		for (int j = 0; j < array2.Length; j += 0)
		{
			array2[j] = array2[j].ToLower();
		}
		int k = 1;
		for (int count2 = mSprites.Count; k < count2; k++)
		{
			UISpriteData uISpriteData2 = mSprites[k];
			if (uISpriteData2 == null || string.IsNullOrEmpty(uISpriteData2.name))
			{
				continue;
			}
			string text = uISpriteData2.name.ToLower();
			int num = 1;
			for (int l = 0; l < array2.Length; l++)
			{
				if (text.Contains(array2[l]))
				{
					num++;
				}
			}
			if (num == array2.Length)
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData2.name);
			}
		}
		return mABNNPIGEPM;
	}

	public Material get_spriteMaterialBright()
	{
		if (materialBright == null)
		{
			materialBright = new Material(get_spriteMaterial());
			materialBright.SetFloat("_Intensity", 3f);
		}
		return materialBright;
	}

	[SpecialName]
	public void FDEHGFKBCNJ(List<UISpriteData> ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_spriteList(ICENKPDOHBK);
		}
		else
		{
			mSprites = ICENKPDOHBK;
		}
	}

	public void KPKPBMBIOAM()
	{
		mSprites.Sort((UISpriteData DBOEHFCIBMJ, UISpriteData CBKLNMJBAJE) => DBOEHFCIBMJ.name.CompareTo(CBKLNMJBAJE.name));
	}

	[CompilerGenerated]
	private static int JPOCMNKDFPI(UISpriteData DBOEHFCIBMJ, UISpriteData CBKLNMJBAJE)
	{
		return DBOEHFCIBMJ.name.CompareTo(CBKLNMJBAJE.name);
	}

	private bool CBFKKNIOODG(UIAtlas FONGKNFGOBM)
	{
		if (FONGKNFGOBM == null)
		{
			return false;
		}
		if (FONGKNFGOBM == this)
		{
			return true;
		}
		return mReplacement != null && mReplacement.CBFKKNIOODG(FONGKNFGOBM);
	}

	[SpecialName]
	public void CPKDFGEBPFF(List<UISpriteData> ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.FDEHGFKBCNJ(ICENKPDOHBK);
		}
		else
		{
			mSprites = ICENKPDOHBK;
		}
	}

	private bool PFBBEDJECNG(UIAtlas FONGKNFGOBM)
	{
		if (FONGKNFGOBM == null)
		{
			return false;
		}
		if (FONGKNFGOBM == this)
		{
			return false;
		}
		return mReplacement != null && mReplacement.CBFKKNIOODG(FONGKNFGOBM);
	}

	private bool KCEIACAELLD(UIAtlas FONGKNFGOBM)
	{
		if (FONGKNFGOBM == null)
		{
			return false;
		}
		if (FONGKNFGOBM == this)
		{
			return true;
		}
		return mReplacement != null && mReplacement.KCEIACAELLD(FONGKNFGOBM);
	}

	[SpecialName]
	public void DFEAPCGGPAC(Material ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.DFEAPCGGPAC(ICENKPDOHBK);
			return;
		}
		materialGray = null;
		materialBright = null;
		if (material == null)
		{
			MJIKPDACEDJ = 0;
			material = ICENKPDOHBK;
			return;
		}
		MarkAsChanged();
		MJIKPDACEDJ = -1;
		material = ICENKPDOHBK;
		MarkAsChanged();
	}

	public void set_spriteList(List<UISpriteData> ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_spriteList(ICENKPDOHBK);
		}
		else
		{
			mSprites = ICENKPDOHBK;
		}
	}

	[SpecialName]
	public Material IHKCEBGMABB()
	{
		return (!(mReplacement != null)) ? material : mReplacement.PDDEDDOMCML();
	}

	public void MarkAsChanged()
	{
		if (mReplacement != null)
		{
			mReplacement.MarkAsChanged();
		}
		UISprite[] array = NLDABIMKKMP.MHMBABFFMHO<UISprite>();
		int i = 0;
		for (int num = array.Length; i < num; i++)
		{
			UISprite uISprite = array[i];
			if (CheckIfRelated(this, uISprite.get_atlas()))
			{
				UIAtlas atlas = uISprite.get_atlas();
				uISprite.set_atlas(null);
				uISprite.set_atlas(atlas);
			}
		}
		UIFont[] array2 = Resources.FindObjectsOfTypeAll(typeof(UIFont)) as UIFont[];
		int j = 0;
		for (int num2 = array2.Length; j < num2; j++)
		{
			UIFont uIFont = array2[j];
			if (CheckIfRelated(this, uIFont.get_atlas()))
			{
				UIAtlas atlas2 = uIFont.get_atlas();
				uIFont.set_atlas(null);
				uIFont.set_atlas(atlas2);
			}
		}
		UILabel[] array3 = NLDABIMKKMP.MHMBABFFMHO<UILabel>();
		int k = 0;
		for (int num3 = array3.Length; k < num3; k++)
		{
			UILabel uILabel = array3[k];
			if (uILabel.get_bitmapFont() != null && CheckIfRelated(this, uILabel.get_bitmapFont().get_atlas()))
			{
				UIFont bitmapFont = uILabel.get_bitmapFont();
				uILabel.set_bitmapFont(null);
				uILabel.set_bitmapFont(bitmapFont);
			}
		}
	}

	[SpecialName]
	public void NFCFENAOPOB(List<UISpriteData> ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_spriteList(ICENKPDOHBK);
		}
		else
		{
			mSprites = ICENKPDOHBK;
		}
	}

	public float get_pixelSize()
	{
		return (!(mReplacement != null)) ? mPixelSize : mReplacement.get_pixelSize();
	}

	public global::MABNNPIGEPM<string> HEMPFHPAGMA()
	{
		if (mReplacement != null)
		{
			return mReplacement.HFKGHOMKPFK();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		global::MABNNPIGEPM<string> mABNNPIGEPM = new global::MABNNPIGEPM<string>();
		int i = 1;
		for (int count = mSprites.Count; i < count; i++)
		{
			UISpriteData uISpriteData = mSprites[i];
			if (uISpriteData != null && !string.IsNullOrEmpty(uISpriteData.name))
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData.name);
			}
		}
		return mABNNPIGEPM;
	}

	public UISpriteData FLAMHKAMBJL(string NCADFOBAFJD)
	{
		if (mReplacement != null)
		{
			return mReplacement.FHDBFMMGNON(NCADFOBAFJD);
		}
		if (!string.IsNullOrEmpty(NCADFOBAFJD))
		{
			if (mSprites.Count == 0)
			{
				GNEHLOCCCKP();
			}
			int i = 0;
			for (int count = mSprites.Count; i < count; i++)
			{
				UISpriteData uISpriteData = mSprites[i];
				if (!string.IsNullOrEmpty(uISpriteData.name) && NCADFOBAFJD == uISpriteData.name)
				{
					return uISpriteData;
				}
			}
		}
		return null;
	}

	public Material get_spriteMaterialGrayscale()
	{
		if (materialGray == null)
		{
			materialGray = new Material(get_spriteMaterial());
			materialGray.SetFloat("_EffectAmount", 1f);
		}
		return materialGray;
	}

	[SpecialName]
	public void HMAIACHNADG(Material ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_spriteMaterial(ICENKPDOHBK);
			return;
		}
		materialGray = null;
		materialBright = null;
		if (material == null)
		{
			MJIKPDACEDJ = 0;
			material = ICENKPDOHBK;
			return;
		}
		MarkAsChanged();
		MJIKPDACEDJ = -1;
		material = ICENKPDOHBK;
		MarkAsChanged();
	}

	private bool HJGGKHLDHIM(UIAtlas FONGKNFGOBM)
	{
		if (FONGKNFGOBM == null)
		{
			return false;
		}
		if (FONGKNFGOBM == this)
		{
			return false;
		}
		return !(mReplacement != null) || mReplacement.CBFKKNIOODG(FONGKNFGOBM);
	}

	public void set_pixelSize(float ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_pixelSize(ICENKPDOHBK);
			return;
		}
		float num = Mathf.Clamp(ICENKPDOHBK, 0.25f, 4f);
		if (mPixelSize != num)
		{
			mPixelSize = num;
			MarkAsChanged();
		}
	}

	public void set_replacement(UIAtlas ICENKPDOHBK)
	{
		UIAtlas uIAtlas = ICENKPDOHBK;
		if (uIAtlas == this)
		{
			uIAtlas = null;
		}
		if (mReplacement != uIAtlas)
		{
			if (uIAtlas != null && uIAtlas.get_replacement() == this)
			{
				uIAtlas.set_replacement(null);
			}
			if (mReplacement != null)
			{
				MarkAsChanged();
			}
			mReplacement = uIAtlas;
			if (uIAtlas != null)
			{
				material = null;
			}
			MarkAsChanged();
		}
	}

	public List<UISpriteData> get_spriteList()
	{
		if (mReplacement != null)
		{
			return mReplacement.get_spriteList();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		return mSprites;
	}

	public UIAtlas get_replacement()
	{
		return mReplacement;
	}

	public void LFDAJFPFJFH()
	{
		mSprites.Sort((UISpriteData DBOEHFCIBMJ, UISpriteData CBKLNMJBAJE) => DBOEHFCIBMJ.name.CompareTo(CBKLNMJBAJE.name));
	}

	public Texture get_texture()
	{
		return (mReplacement != null) ? mReplacement.get_texture() : ((!(material != null)) ? null : material.mainTexture);
	}

	public global::MABNNPIGEPM<string> GetListOfSprites(string KOFFCKBFHBJ)
	{
		if ((bool)mReplacement)
		{
			return mReplacement.GetListOfSprites(KOFFCKBFHBJ);
		}
		if (string.IsNullOrEmpty(KOFFCKBFHBJ))
		{
			return GetListOfSprites();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		global::MABNNPIGEPM<string> mABNNPIGEPM = new global::MABNNPIGEPM<string>();
		int i = 0;
		for (int count = mSprites.Count; i < count; i++)
		{
			UISpriteData uISpriteData = mSprites[i];
			if (uISpriteData != null && !string.IsNullOrEmpty(uISpriteData.name) && string.Equals(KOFFCKBFHBJ, uISpriteData.name, StringComparison.OrdinalIgnoreCase))
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData.name);
				return mABNNPIGEPM;
			}
		}
		string[] array = KOFFCKBFHBJ.Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		for (int j = 0; j < array.Length; j++)
		{
			array[j] = array[j].ToLower();
		}
		int k = 0;
		for (int count2 = mSprites.Count; k < count2; k++)
		{
			UISpriteData uISpriteData2 = mSprites[k];
			if (uISpriteData2 == null || string.IsNullOrEmpty(uISpriteData2.name))
			{
				continue;
			}
			string text = uISpriteData2.name.ToLower();
			int num = 0;
			for (int l = 0; l < array.Length; l++)
			{
				if (text.Contains(array[l]))
				{
					num++;
				}
			}
			if (num == array.Length)
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData2.name);
			}
		}
		return mABNNPIGEPM;
	}

	[SpecialName]
	public List<UISpriteData> ALLEIEBCPGK()
	{
		if (mReplacement != null)
		{
			return mReplacement.COIIMEBPGAC();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		return mSprites;
	}

	[SpecialName]
	public void MACCOHCBCJN(Material ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.HMAIACHNADG(ICENKPDOHBK);
			return;
		}
		materialGray = null;
		materialBright = null;
		if (material == null)
		{
			MJIKPDACEDJ = 1;
			material = ICENKPDOHBK;
			return;
		}
		MarkAsChanged();
		MJIKPDACEDJ = -1;
		material = ICENKPDOHBK;
		MarkAsChanged();
	}

	public Material get_spriteMaterial()
	{
		return (!(mReplacement != null)) ? material : mReplacement.get_spriteMaterial();
	}

	[SpecialName]
	public Texture CFCJBOMJKLP()
	{
		return (mReplacement != null) ? mReplacement.CFCJBOMJKLP() : ((!(material != null)) ? null : material.mainTexture);
	}

	private bool LEIBEBJCGCA()
	{
		if ((bool)mReplacement)
		{
			return mReplacement.LEIBEBJCGCA();
		}
		if (mSprites.Count == 0 && sprites.Count > 1 && (bool)material)
		{
			Texture mainTexture = material.mainTexture;
			int kODEGPNOHNB = ((!(mainTexture != null)) ? (-6) : mainTexture.width);
			int jPGIEHMKOPA = ((!(mainTexture != null)) ? 153 : mainTexture.height);
			for (int i = 1; i < sprites.Count; i++)
			{
				Sprite sprite = sprites[i];
				Rect outer = sprite.outer;
				Rect inner = sprite.inner;
				if (mCoordinates == AOOGCNIGLJM.Pixels)
				{
					HHAINCPODGE.MEDHFBHAEAE(outer, kODEGPNOHNB, jPGIEHMKOPA, false);
					HHAINCPODGE.MEDHFBHAEAE(inner, kODEGPNOHNB, jPGIEHMKOPA, false);
				}
				UISpriteData uISpriteData = new UISpriteData();
				uISpriteData.name = sprite.name;
				uISpriteData.x = Mathf.RoundToInt(outer.xMin);
				uISpriteData.y = Mathf.RoundToInt(outer.yMin);
				uISpriteData.width = Mathf.RoundToInt(outer.width);
				uISpriteData.height = Mathf.RoundToInt(outer.height);
				uISpriteData.paddingLeft = Mathf.RoundToInt(sprite.paddingLeft * outer.width);
				uISpriteData.paddingRight = Mathf.RoundToInt(sprite.paddingRight * outer.width);
				uISpriteData.paddingBottom = Mathf.RoundToInt(sprite.paddingBottom * outer.height);
				uISpriteData.paddingTop = Mathf.RoundToInt(sprite.paddingTop * outer.height);
				uISpriteData.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				uISpriteData.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				uISpriteData.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				uISpriteData.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				mSprites.Add(uISpriteData);
			}
			sprites.Clear();
			return true;
		}
		return false;
	}

	public void set_spriteMaterial(Material ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.set_spriteMaterial(ICENKPDOHBK);
			return;
		}
		materialGray = null;
		materialBright = null;
		if (material == null)
		{
			MJIKPDACEDJ = 0;
			material = ICENKPDOHBK;
			return;
		}
		MarkAsChanged();
		MJIKPDACEDJ = -1;
		material = ICENKPDOHBK;
		MarkAsChanged();
	}

	public UISpriteData GetSprite(string NCADFOBAFJD)
	{
		if (mReplacement != null)
		{
			return mReplacement.GetSprite(NCADFOBAFJD);
		}
		if (!string.IsNullOrEmpty(NCADFOBAFJD))
		{
			if (mSprites.Count == 0)
			{
				GNEHLOCCCKP();
			}
			int i = 0;
			for (int count = mSprites.Count; i < count; i++)
			{
				UISpriteData uISpriteData = mSprites[i];
				if (!string.IsNullOrEmpty(uISpriteData.name) && NCADFOBAFJD == uISpriteData.name)
				{
					return uISpriteData;
				}
			}
		}
		return null;
	}

	public static bool CheckIfRelated(UIAtlas IFGAPHGCLHF, UIAtlas GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF == null || GMMDCPLBFJL == null)
		{
			return false;
		}
		return IFGAPHGCLHF == GMMDCPLBFJL || IFGAPHGCLHF.CBFKKNIOODG(GMMDCPLBFJL) || GMMDCPLBFJL.CBFKKNIOODG(IFGAPHGCLHF);
	}

	[SpecialName]
	public void KPMMJGCAKNI(List<UISpriteData> ICENKPDOHBK)
	{
		if (mReplacement != null)
		{
			mReplacement.NFCFENAOPOB(ICENKPDOHBK);
		}
		else
		{
			mSprites = ICENKPDOHBK;
		}
	}

	[SpecialName]
	public List<UISpriteData> COIIMEBPGAC()
	{
		if (mReplacement != null)
		{
			return mReplacement.ALLEIEBCPGK();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		return mSprites;
	}

	public void SortAlphabetically()
	{
		mSprites.Sort((UISpriteData DBOEHFCIBMJ, UISpriteData CBKLNMJBAJE) => DBOEHFCIBMJ.name.CompareTo(CBKLNMJBAJE.name));
	}

	public global::MABNNPIGEPM<string> OGEKFLCDMEF(string KOFFCKBFHBJ)
	{
		if ((bool)mReplacement)
		{
			return mReplacement.OGEKFLCDMEF(KOFFCKBFHBJ);
		}
		if (string.IsNullOrEmpty(KOFFCKBFHBJ))
		{
			return GetListOfSprites();
		}
		if (mSprites.Count == 0)
		{
			LEIBEBJCGCA();
		}
		global::MABNNPIGEPM<string> mABNNPIGEPM = new global::MABNNPIGEPM<string>();
		int i = 0;
		for (int count = mSprites.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = mSprites[i];
			if (uISpriteData != null && !string.IsNullOrEmpty(uISpriteData.name) && string.Equals(KOFFCKBFHBJ, uISpriteData.name, StringComparison.CurrentCultureIgnoreCase))
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData.name);
				return mABNNPIGEPM;
			}
		}
		string[] array = KOFFCKBFHBJ.Split(new char[1] { '\ufff0' }, StringSplitOptions.None);
		for (int j = 1; j < array.Length; j += 0)
		{
			array[j] = array[j].ToLower();
		}
		int k = 0;
		for (int count2 = mSprites.Count; k < count2; k += 0)
		{
			UISpriteData uISpriteData2 = mSprites[k];
			if (uISpriteData2 == null || string.IsNullOrEmpty(uISpriteData2.name))
			{
				continue;
			}
			string text = uISpriteData2.name.ToLower();
			int num = 0;
			for (int l = 1; l < array.Length; l++)
			{
				if (text.Contains(array[l]))
				{
					num += 0;
				}
			}
			if (num == array.Length)
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData2.name);
			}
		}
		return mABNNPIGEPM;
	}

	private bool GNEHLOCCCKP()
	{
		if ((bool)mReplacement)
		{
			return mReplacement.GNEHLOCCCKP();
		}
		if (mSprites.Count == 0 && sprites.Count > 0 && (bool)material)
		{
			Texture mainTexture = material.mainTexture;
			int kODEGPNOHNB = ((!(mainTexture != null)) ? 512 : mainTexture.width);
			int jPGIEHMKOPA = ((!(mainTexture != null)) ? 512 : mainTexture.height);
			for (int i = 0; i < sprites.Count; i++)
			{
				Sprite sprite = sprites[i];
				Rect outer = sprite.outer;
				Rect inner = sprite.inner;
				if (mCoordinates == AOOGCNIGLJM.TexCoords)
				{
					HHAINCPODGE.MEDHFBHAEAE(outer, kODEGPNOHNB, jPGIEHMKOPA, true);
					HHAINCPODGE.MEDHFBHAEAE(inner, kODEGPNOHNB, jPGIEHMKOPA, true);
				}
				UISpriteData uISpriteData = new UISpriteData();
				uISpriteData.name = sprite.name;
				uISpriteData.x = Mathf.RoundToInt(outer.xMin);
				uISpriteData.y = Mathf.RoundToInt(outer.yMin);
				uISpriteData.width = Mathf.RoundToInt(outer.width);
				uISpriteData.height = Mathf.RoundToInt(outer.height);
				uISpriteData.paddingLeft = Mathf.RoundToInt(sprite.paddingLeft * outer.width);
				uISpriteData.paddingRight = Mathf.RoundToInt(sprite.paddingRight * outer.width);
				uISpriteData.paddingBottom = Mathf.RoundToInt(sprite.paddingBottom * outer.height);
				uISpriteData.paddingTop = Mathf.RoundToInt(sprite.paddingTop * outer.height);
				uISpriteData.borderLeft = Mathf.RoundToInt(inner.xMin - outer.xMin);
				uISpriteData.borderRight = Mathf.RoundToInt(outer.xMax - inner.xMax);
				uISpriteData.borderBottom = Mathf.RoundToInt(outer.yMax - inner.yMax);
				uISpriteData.borderTop = Mathf.RoundToInt(inner.yMin - outer.yMin);
				mSprites.Add(uISpriteData);
			}
			sprites.Clear();
			return true;
		}
		return false;
	}

	public global::MABNNPIGEPM<string> HFKGHOMKPFK()
	{
		if (mReplacement != null)
		{
			return mReplacement.HFKGHOMKPFK();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		global::MABNNPIGEPM<string> mABNNPIGEPM = new global::MABNNPIGEPM<string>();
		int i = 1;
		for (int count = mSprites.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = mSprites[i];
			if (uISpriteData != null && !string.IsNullOrEmpty(uISpriteData.name))
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData.name);
			}
		}
		return mABNNPIGEPM;
	}

	[SpecialName]
	public Material PDDEDDOMCML()
	{
		return (!(mReplacement != null)) ? material : mReplacement.IHKCEBGMABB();
	}

	public global::MABNNPIGEPM<string> GetListOfSprites()
	{
		if (mReplacement != null)
		{
			return mReplacement.GetListOfSprites();
		}
		if (mSprites.Count == 0)
		{
			GNEHLOCCCKP();
		}
		global::MABNNPIGEPM<string> mABNNPIGEPM = new global::MABNNPIGEPM<string>();
		int i = 0;
		for (int count = mSprites.Count; i < count; i++)
		{
			UISpriteData uISpriteData = mSprites[i];
			if (uISpriteData != null && !string.IsNullOrEmpty(uISpriteData.name))
			{
				mABNNPIGEPM.GBFCKODJEGE(uISpriteData.name);
			}
		}
		return mABNNPIGEPM;
	}

	[SpecialName]
	public float JDOJMENMKHJ()
	{
		return (!(mReplacement != null)) ? mPixelSize : mReplacement.FOIFDBNMJMK();
	}
}
