using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Popup List")]
public class UIPopupList : UIWidgetContainer
{
	public enum CGNFDFOCFHO
	{
		Auto = 0,
		Above = 1,
		Below = 2
	}

	public delegate void DALEJIENJLM(string JKJGJMOEHDO);

	private sealed class GJFAAPECGGF : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal TweenPosition JKDFGLHKLIE;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UIPopupList KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		public bool DAJHAEIAPAO()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (KNIAJMGDGAA.FFLGBDBPNNB != null && KNIAJMGDGAA.EJOEPCIEPKD != null)
				{
					JKDFGLHKLIE = KNIAJMGDGAA.FFLGBDBPNNB.GetComponent<TweenPosition>();
					goto case 1u;
				}
				goto IL_00b2;
			case 1u:
				{
					if (JKDFGLHKLIE != null && JKDFGLHKLIE.enabled)
					{
						JKDFGLHKLIE.to = KNIAJMGDGAA.NNPFBCHCKFH();
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 0;
						return true;
					}
					goto IL_00b2;
				}
				IL_00b2:
				KNIAJMGDGAA.AEPEJFAIOIB = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public bool MNHCKJNDJOG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (KNIAJMGDGAA.FFLGBDBPNNB != null && KNIAJMGDGAA.EJOEPCIEPKD != null)
				{
					JKDFGLHKLIE = KNIAJMGDGAA.FFLGBDBPNNB.GetComponent<TweenPosition>();
					goto case 1u;
				}
				goto IL_00b2;
			case 1u:
				{
					if (JKDFGLHKLIE != null && JKDFGLHKLIE.enabled)
					{
						JKDFGLHKLIE.to = KNIAJMGDGAA.IFOEJEJNEMF();
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 0;
						return false;
					}
					goto IL_00b2;
				}
				IL_00b2:
				KNIAJMGDGAA.AEPEJFAIOIB = false;
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		public bool BDHBKIPJENC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (KNIAJMGDGAA.FFLGBDBPNNB != null && KNIAJMGDGAA.EJOEPCIEPKD != null)
				{
					JKDFGLHKLIE = KNIAJMGDGAA.FFLGBDBPNNB.GetComponent<TweenPosition>();
					goto case 1u;
				}
				goto IL_00b2;
			case 1u:
				{
					if (JKDFGLHKLIE != null && JKDFGLHKLIE.enabled)
					{
						JKDFGLHKLIE.to = KNIAJMGDGAA.OAAOAMDEGNN();
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 1;
						return true;
					}
					goto IL_00b2;
				}
				IL_00b2:
				KNIAJMGDGAA.AEPEJFAIOIB = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				if (KNIAJMGDGAA.FFLGBDBPNNB != null && KNIAJMGDGAA.EJOEPCIEPKD != null)
				{
					JKDFGLHKLIE = KNIAJMGDGAA.FFLGBDBPNNB.GetComponent<TweenPosition>();
					goto case 1u;
				}
				goto IL_00b2;
			case 1u:
				{
					if (JKDFGLHKLIE != null && JKDFGLHKLIE.enabled)
					{
						JKDFGLHKLIE.to = KNIAJMGDGAA.NNPFBCHCKFH();
						MMEGGNJKNOH = null;
						GOMFKPLCGNN = 1;
						return true;
					}
					goto IL_00b2;
				}
				IL_00b2:
				KNIAJMGDGAA.AEPEJFAIOIB = false;
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object LNGNAHOMCFE()
		{
			return MMEGGNJKNOH;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BFBDKFOJMAK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object IDOOOPMEFDM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object PHDGFFDAMLI()
		{
			return MMEGGNJKNOH;
		}
	}

	private const float LBFPEIJNEBO = 0.15f;

	public static UIPopupList current;

	public UIAtlas atlas;

	public UIFont bitmapFont;

	public Font trueTypeFont;

	public int fontSize = 16;

	public FontStyle fontStyle;

	public string backgroundSprite;

	public string highlightSprite;

	public CGNFDFOCFHO position;

	public MGDLEEIDDII.NBEGJBKHJLH alignment = MGDLEEIDDII.NBEGJBKHJLH.Left;

	public List<string> items = new List<string>();

	public Vector2 padding = new Vector3(4f, 4f);

	public Color textColor = Color.white;

	public Color backgroundColor = Color.white;

	public Color highlightColor = new Color(225f / 255f, 200f / 255f, 150f / 255f, 1f);

	public bool isAnimated = true;

	public bool isLocalized;

	public List<EventDelegate> onChange = new List<EventDelegate>();

	[HideInInspector]
	[SerializeField]
	private string mSelectedItem;

	private UIPanel MPFGEBCBFFM;

	private GameObject ANOIPNOCGGF;

	private UISprite MFDPPDINMHL;

	private UISprite FFLGBDBPNNB;

	private UILabel EJOEPCIEPKD;

	private List<UILabel> BMCEJIIMKKN = new List<UILabel>();

	private float DGHOHCPFABE;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string functionName = "OnSelectionChange";

	[SerializeField]
	[HideInInspector]
	private float textScale;

	[HideInInspector]
	[SerializeField]
	private UIFont font;

	[SerializeField]
	[HideInInspector]
	private UILabel textLabel;

	private DALEJIENJLM HMHLBNJAAPC;

	private bool OAHNFMGNJNG;

	private bool AEPEJFAIOIB;

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

	[Obsolete("Use EventDelegate.Add(popup.onChange, YourCallback) instead, and UIPopupList.current.value to determine the state")]
	public DALEJIENJLM LNFPKCOLDKO
	{
		get
		{
			return get_onSelectionChange();
		}
		set
		{
			set_onSelectionChange(value);
		}
	}

	public bool BFJHENPLIPB
	{
		get
		{
			return get_isOpen();
		}
	}

	public string ICENKPDOHBK
	{
		get
		{
			return get_value();
		}
		set
		{
			set_value(value);
		}
	}

	[Obsolete("Use 'value' instead")]
	public string IIEIFEDPNGM
	{
		get
		{
			return get_selection();
		}
		set
		{
			set_selection(value);
		}
	}

	private bool MDIFAIFBMKP
	{
		get
		{
			return ALEODCDOOOE();
		}
		set
		{
			OIKFDKIGDPP(value);
		}
	}

	private bool GLCGAIAPPKO
	{
		get
		{
			return OOFLKFJCBEC();
		}
	}

	private int FGLBHNOPKIB
	{
		get
		{
			return FODFAAKOGBC();
		}
	}

	private float BMKEFJGECPC
	{
		get
		{
			return ADIIPKFDICE();
		}
	}

	private void HBILFLMHDHA(GameObject LHACFNECMNA, bool MLIBCICOOAI)
	{
		if (MLIBCICOOAI)
		{
			UILabel component = LHACFNECMNA.GetComponent<UILabel>();
			HGDCDPCBHIO(component, false);
		}
	}

	private void IHPCNIBKFIC(GameObject LHACFNECMNA)
	{
		Close();
	}

	private void DDBHEOMLDPH(UIWidget ANEPINFLFJK, bool GKNHHPEFPLI, float HKAHBBIAGHM)
	{
		GameObject lHACFNECMNA = ANEPINFLFJK.gameObject;
		Transform cachedTransform = ANEPINFLFJK.get_cachedTransform();
		float num = (float)FODFAAKOGBC() * ADIIPKFDICE() + DGHOHCPFABE * 2f;
		cachedTransform.localScale = new Vector3(1f, num / (float)ANEPINFLFJK.get_height(), 1f);
		TweenScale.Begin(lHACFNECMNA, 0.15f, Vector3.one).method = UITweener.MAIJGNJIIIC.EaseOut;
		if (GKNHHPEFPLI)
		{
			Vector3 localPosition = cachedTransform.localPosition;
			cachedTransform.localPosition = new Vector3(localPosition.x, localPosition.y - (float)ANEPINFLFJK.get_height() + num, localPosition.z);
			TweenPosition.Begin(lHACFNECMNA, 0.15f, localPosition).method = UITweener.MAIJGNJIIIC.EaseOut;
		}
	}

	public void set_onSelectionChange(DALEJIENJLM ICENKPDOHBK)
	{
		HMHLBNJAAPC = ICENKPDOHBK;
	}

	private void OnEnable()
	{
		if (EventDelegate.AHGNGKFJAOI(onChange))
		{
			eventReceiver = null;
			functionName = null;
		}
		if (font != null)
		{
			if (font.get_isDynamic())
			{
				trueTypeFont = font.get_dynamicFont();
				fontStyle = font.get_dynamicFontStyle();
				OAHNFMGNJNG = true;
			}
			else if (bitmapFont == null)
			{
				bitmapFont = font;
				OAHNFMGNJNG = false;
			}
			font = null;
		}
		if (textScale != 0f)
		{
			fontSize = ((!(bitmapFont != null)) ? 16 : Mathf.RoundToInt((float)bitmapFont.get_defaultSize() * textScale));
			textScale = 0f;
		}
		if (trueTypeFont == null && bitmapFont != null && bitmapFont.get_isDynamic())
		{
			trueTypeFont = bitmapFont.get_dynamicFont();
			bitmapFont = null;
		}
	}

	private void AMGMEEEIMEL(KeyCode NNKLGFNHPBE)
	{
		if (!base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !ALEODCDOOOE())
		{
			return;
		}
		int num = BMCEJIIMKKN.IndexOf(EJOEPCIEPKD);
		if (num == -1)
		{
			num = 0;
		}
		switch (NNKLGFNHPBE)
		{
		case KeyCode.UpArrow:
			if (num > 0)
			{
				LPANHHLFAHF(BMCEJIIMKKN[--num], false);
			}
			break;
		case KeyCode.DownArrow:
			if (num + 1 < BMCEJIIMKKN.Count)
			{
				LPANHHLFAHF(BMCEJIIMKKN[++num], false);
			}
			break;
		case KeyCode.Escape:
			JADBJGCMIMF(false);
			break;
		}
	}

	private bool OOFLKFJCBEC()
	{
		return bitmapFont != null || trueTypeFont != null;
	}

	[SpecialName]
	public void NFMMHLFHLFB(DALEJIENJLM ICENKPDOHBK)
	{
		HMHLBNJAAPC = ICENKPDOHBK;
	}

	private void DCLKJAAFOIB(UIWidget ANEPINFLFJK, bool GKNHHPEFPLI, float HKAHBBIAGHM)
	{
		Vector3 localPosition = ANEPINFLFJK.get_cachedTransform().localPosition;
		Vector3 localPosition2 = ((!GKNHHPEFPLI) ? new Vector3(localPosition.x, 1696f, localPosition.z) : new Vector3(localPosition.x, HKAHBBIAGHM, localPosition.z));
		ANEPINFLFJK.get_cachedTransform().localPosition = localPosition2;
		GameObject lHACFNECMNA = ANEPINFLFJK.gameObject;
		TweenPosition.Begin(lHACFNECMNA, 1639f, localPosition).method = (UITweener.MAIJGNJIIIC)6;
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (!IOGFFPOIBBB)
		{
			Close();
		}
	}

	public void set_ambigiousFont(UnityEngine.Object ICENKPDOHBK)
	{
		if (ICENKPDOHBK is Font)
		{
			trueTypeFont = ICENKPDOHBK as Font;
			bitmapFont = null;
			font = null;
		}
		else if (ICENKPDOHBK is UIFont)
		{
			bitmapFont = ICENKPDOHBK as UIFont;
			trueTypeFont = null;
			font = null;
		}
	}

	public void Close()
	{
		if (!(ANOIPNOCGGF != null))
		{
			return;
		}
		BMCEJIIMKKN.Clear();
		OIKFDKIGDPP(false);
		if (isAnimated)
		{
			UIWidget[] componentsInChildren = ANOIPNOCGGF.GetComponentsInChildren<UIWidget>();
			int i = 0;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				UIWidget uIWidget = componentsInChildren[i];
				Color color = uIWidget.get_color();
				color.a = 0f;
				TweenColor.Begin(uIWidget.gameObject, 0.15f, color).method = UITweener.MAIJGNJIIIC.EaseOut;
			}
			Collider[] componentsInChildren2 = ANOIPNOCGGF.GetComponentsInChildren<Collider>();
			int j = 0;
			for (int num2 = componentsInChildren2.Length; j < num2; j++)
			{
				componentsInChildren2[j].enabled = false;
			}
			UnityEngine.Object.Destroy(ANOIPNOCGGF, 0.15f);
		}
		else
		{
			UnityEngine.Object.Destroy(ANOIPNOCGGF);
		}
		MFDPPDINMHL = null;
		FFLGBDBPNNB = null;
		ANOIPNOCGGF = null;
	}

	[SpecialName]
	private void FBOFILGHBDF(bool ICENKPDOHBK)
	{
		UIKeyNavigation component = GetComponent<UIKeyNavigation>();
		if (component != null)
		{
			component.enabled = !ICENKPDOHBK;
		}
	}

	[SpecialName]
	public void OMPIOLFOLLP(DALEJIENJLM ICENKPDOHBK)
	{
		HMHLBNJAAPC = ICENKPDOHBK;
	}

	private IEnumerator EKANHEOAJKI()
	{
		GJFAAPECGGF gJFAAPECGGF = new GJFAAPECGGF();
		gJFAAPECGGF.KNIAJMGDGAA = this;
		return gJFAAPECGGF;
	}

	private void FNDGFIIDDDK(UILabel BMOJJLLDAAC, bool MABBBDMDFHE)
	{
		HGDCDPCBHIO(BMOJJLLDAAC, MABBBDMDFHE);
		UIEventListener component = BMOJJLLDAAC.gameObject.GetComponent<UIEventListener>();
		EJFDKKEEEIG(component.parameter as string);
		UIPlaySound[] components = GetComponents<UIPlaySound>();
		int i = 0;
		for (int num = components.Length; i < num; i += 0)
		{
			UIPlaySound uIPlaySound = components[i];
			if (uIPlaySound.trigger == UIPlaySound.FMPOPHBALHP.OnClick)
			{
				NLDABIMKKMP.FANLLKDLCPF(uIPlaySound.audioClip, uIPlaySound.volume, 1174f);
			}
		}
	}

	private void LPANHHLFAHF(UILabel BMOJJLLDAAC, bool MABBBDMDFHE)
	{
		HGDCDPCBHIO(BMOJJLLDAAC, MABBBDMDFHE);
		UIEventListener component = BMOJJLLDAAC.gameObject.GetComponent<UIEventListener>();
		set_value(component.parameter as string);
		UIPlaySound[] components = GetComponents<UIPlaySound>();
		int i = 0;
		for (int num = components.Length; i < num; i++)
		{
			UIPlaySound uIPlaySound = components[i];
			if (uIPlaySound.trigger == UIPlaySound.FMPOPHBALHP.OnClick)
			{
				NLDABIMKKMP.FANLLKDLCPF(uIPlaySound.audioClip, uIPlaySound.volume, 1f);
			}
		}
	}

	private void HGDCDPCBHIO(UILabel BMOJJLLDAAC, bool MABBBDMDFHE)
	{
		if (!(FFLGBDBPNNB != null))
		{
			return;
		}
		EJOEPCIEPKD = BMOJJLLDAAC;
		UISpriteData atlasSprite = FFLGBDBPNNB.GetAtlasSprite();
		if (atlasSprite == null)
		{
			return;
		}
		Vector3 vector = NNPFBCHCKFH();
		if (MABBBDMDFHE || !isAnimated)
		{
			FFLGBDBPNNB.get_cachedTransform().localPosition = vector;
			return;
		}
		TweenPosition.Begin(FFLGBDBPNNB.gameObject, 0.1f, vector).method = UITweener.MAIJGNJIIIC.EaseOut;
		if (!AEPEJFAIOIB)
		{
			AEPEJFAIOIB = true;
			StartCoroutine(AKNMFAGKPED());
		}
	}

	private void JBDAIMPFKDJ(UILabel BMOJJLLDAAC, bool MABBBDMDFHE)
	{
		HGDCDPCBHIO(BMOJJLLDAAC, MABBBDMDFHE);
		UIEventListener component = BMOJJLLDAAC.gameObject.GetComponent<UIEventListener>();
		set_value(component.parameter as string);
		UIPlaySound[] components = GetComponents<UIPlaySound>();
		int i = 0;
		for (int num = components.Length; i < num; i++)
		{
			UIPlaySound uIPlaySound = components[i];
			if (uIPlaySound.trigger == UIPlaySound.FMPOPHBALHP.OnClick)
			{
				NLDABIMKKMP.FANLLKDLCPF(uIPlaySound.audioClip, uIPlaySound.volume, 813f);
			}
		}
	}

	private void OIKFDKIGDPP(bool ICENKPDOHBK)
	{
		UIKeyNavigation component = GetComponent<UIKeyNavigation>();
		if (component != null)
		{
			component.enabled = !ICENKPDOHBK;
		}
	}

	public void set_selection(string ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	private void EINDHIEGCIK(UIWidget ANEPINFLFJK, bool GKNHHPEFPLI, float HKAHBBIAGHM)
	{
		PFEKLLKOCOP(ANEPINFLFJK);
		AMLGONBGBDH(ANEPINFLFJK, GKNHHPEFPLI, HKAHBBIAGHM);
	}

	private void PFEKLLKOCOP(UIWidget ANEPINFLFJK)
	{
		Color color = ANEPINFLFJK.get_color();
		ANEPINFLFJK.set_color(new Color(color.r, color.g, color.b, 0f));
		TweenColor.Begin(ANEPINFLFJK.gameObject, 0.15f, color).method = UITweener.MAIJGNJIIIC.EaseOut;
	}

	public void set_value(string ICENKPDOHBK)
	{
		mSelectedItem = ICENKPDOHBK;
		if (mSelectedItem != null && mSelectedItem != null)
		{
			JHBFDHPHIPN();
		}
	}

	[SpecialName]
	public bool JGOIBHKNANE()
	{
		return ANOIPNOCGGF != null;
	}

	[SpecialName]
	public DALEJIENJLM KJGLHMGEGHF()
	{
		return HMHLBNJAAPC;
	}

	[SpecialName]
	public void OJHPEMKLKPM(UnityEngine.Object ICENKPDOHBK)
	{
		if (ICENKPDOHBK is Font)
		{
			trueTypeFont = ICENKPDOHBK as Font;
			bitmapFont = null;
			font = null;
		}
		else if (ICENKPDOHBK is UIFont)
		{
			bitmapFont = ICENKPDOHBK as UIFont;
			trueTypeFont = null;
			font = null;
		}
	}

	private void LDIPPAPIBAK(KeyCode NNKLGFNHPBE)
	{
		if (!base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !ALEODCDOOOE())
		{
			return;
		}
		int num = BMCEJIIMKKN.IndexOf(EJOEPCIEPKD);
		if (num == -1)
		{
			num = 0;
		}
		switch (NNKLGFNHPBE)
		{
		case (KeyCode)(-181):
			if (num > 1)
			{
				FNDGFIIDDDK(BMCEJIIMKKN[--num], false);
			}
			break;
		case (KeyCode)158:
			if (num + 1 < BMCEJIIMKKN.Count)
			{
				FNDGFIIDDDK(BMCEJIIMKKN[num += 0], false);
			}
			break;
		case KeyCode.S:
			FIEHFDLBDKD(true);
			break;
		}
	}

	private void OnValidate()
	{
		Font font = trueTypeFont;
		UIFont uIFont = bitmapFont;
		bitmapFont = null;
		trueTypeFont = null;
		if (font != null && (uIFont == null || !OAHNFMGNJNG))
		{
			bitmapFont = null;
			trueTypeFont = font;
			OAHNFMGNJNG = true;
		}
		else if (uIFont != null)
		{
			if (uIFont.get_isDynamic())
			{
				trueTypeFont = uIFont.get_dynamicFont();
				fontStyle = uIFont.get_dynamicFontStyle();
				fontSize = uIFont.get_defaultSize();
				OAHNFMGNJNG = true;
			}
			else
			{
				bitmapFont = uIFont;
				OAHNFMGNJNG = false;
			}
		}
		else
		{
			trueTypeFont = font;
			OAHNFMGNJNG = true;
		}
	}

	public string get_selection()
	{
		return get_value();
	}

	private float ADIIPKFDICE()
	{
		return (!(trueTypeFont != null) && !(bitmapFont == null)) ? ((float)fontSize / (float)bitmapFont.get_defaultSize()) : 1f;
	}

	private bool ALEODCDOOOE()
	{
		UIKeyNavigation component = GetComponent<UIKeyNavigation>();
		return component == null || !component.enabled;
	}

	public string get_value()
	{
		return mSelectedItem;
	}

	private void Start()
	{
		if (textLabel != null)
		{
			EventDelegate.GBFCKODJEGE(onChange, textLabel.SetCurrentSelection);
			textLabel = null;
		}
		if (!Application.isPlaying)
		{
			return;
		}
		if (string.IsNullOrEmpty(mSelectedItem))
		{
			if (items.Count > 0)
			{
				set_value(items[0]);
			}
		}
		else
		{
			string value = mSelectedItem;
			mSelectedItem = null;
			set_value(value);
		}
	}

	private void AMLGONBGBDH(UIWidget ANEPINFLFJK, bool GKNHHPEFPLI, float HKAHBBIAGHM)
	{
		Vector3 localPosition = ANEPINFLFJK.get_cachedTransform().localPosition;
		Vector3 localPosition2 = ((!GKNHHPEFPLI) ? new Vector3(localPosition.x, 0f, localPosition.z) : new Vector3(localPosition.x, HKAHBBIAGHM, localPosition.z));
		ANEPINFLFJK.get_cachedTransform().localPosition = localPosition2;
		GameObject lHACFNECMNA = ANEPINFLFJK.gameObject;
		TweenPosition.Begin(lHACFNECMNA, 0.15f, localPosition).method = UITweener.MAIJGNJIIIC.EaseOut;
	}

	private int FODFAAKOGBC()
	{
		return (!(trueTypeFont != null) && !(bitmapFont == null)) ? bitmapFont.get_defaultSize() : fontSize;
	}

	private void OnClick()
	{
		if (base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) && ANOIPNOCGGF == null && atlas != null && OOFLKFJCBEC() && items.Count > 0)
		{
			BMCEJIIMKKN.Clear();
			if (MPFGEBCBFFM == null)
			{
				MPFGEBCBFFM = UIPanel.Find(base.transform);
				if (MPFGEBCBFFM == null)
				{
					return;
				}
			}
			OIKFDKIGDPP(true);
			Transform transform = base.transform;
			Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(transform.parent, transform);
			ANOIPNOCGGF = new GameObject("Drop-down List");
			ANOIPNOCGGF.layer = base.gameObject.layer;
			Transform transform2 = ANOIPNOCGGF.transform;
			transform2.parent = transform.parent;
			transform2.localPosition = bounds.min;
			transform2.localRotation = Quaternion.identity;
			transform2.localScale = Vector3.one;
			MFDPPDINMHL = NLDABIMKKMP.FLNELHLEDFB(ANOIPNOCGGF, atlas, backgroundSprite);
			MFDPPDINMHL.set_pivot(UIWidget.MADDMCMJKFI.TopLeft);
			MFDPPDINMHL.set_depth(NLDABIMKKMP.IFLIJMLBPII(MPFGEBCBFFM.gameObject));
			MFDPPDINMHL.set_color(backgroundColor);
			Vector4 border = MFDPPDINMHL.get_border();
			DGHOHCPFABE = border.y;
			MFDPPDINMHL.get_cachedTransform().localPosition = new Vector3(0f, border.y, 0f);
			FFLGBDBPNNB = NLDABIMKKMP.FLNELHLEDFB(ANOIPNOCGGF, atlas, highlightSprite);
			FFLGBDBPNNB.set_pivot(UIWidget.MADDMCMJKFI.TopLeft);
			FFLGBDBPNNB.set_color(highlightColor);
			UISpriteData atlasSprite = FFLGBDBPNNB.GetAtlasSprite();
			if (atlasSprite == null)
			{
				return;
			}
			float num = atlasSprite.borderTop;
			float num2 = FODFAAKOGBC();
			float num3 = ADIIPKFDICE();
			float num4 = num2 * num3;
			float a = 0f;
			float num5 = 0f - padding.y;
			int num6 = ((!(bitmapFont != null)) ? fontSize : bitmapFont.get_defaultSize());
			List<UILabel> list = new List<UILabel>();
			int i = 0;
			for (int count = items.Count; i < count; i++)
			{
				string text = items[i];
				UILabel uILabel = NLDABIMKKMP.EDDDFKNEJEN<UILabel>(ANOIPNOCGGF);
				uILabel.name = i.ToString();
				uILabel.set_pivot(UIWidget.MADDMCMJKFI.TopLeft);
				uILabel.set_bitmapFont(bitmapFont);
				uILabel.set_trueTypeFont(trueTypeFont);
				uILabel.set_fontSize(num6);
				uILabel.set_fontStyle(fontStyle);
				uILabel.set_text((!isLocalized) ? text : FKHDOBFNMLP.OHKHGNFHJJM(text));
				uILabel.set_color(textColor);
				uILabel.get_cachedTransform().localPosition = new Vector3(border.x + padding.x, num5, -1f);
				uILabel.set_overflowMethod(UILabel.JCMMPAEEKEC.ResizeFreely);
				uILabel.set_alignment(alignment);
				uILabel.MakePixelPerfect();
				if (num3 != 1f)
				{
					uILabel.get_cachedTransform().localScale = Vector3.one * num3;
				}
				list.Add(uILabel);
				num5 -= num4;
				num5 -= padding.y;
				a = Mathf.Max(a, uILabel.get_printedSize().x);
				UIEventListener uIEventListener = UIEventListener.Get(uILabel.gameObject);
				uIEventListener.onHover = HBILFLMHDHA;
				uIEventListener.onPress = OBGALOFMDML;
				uIEventListener.onClick = IHPCNIBKFIC;
				uIEventListener.parameter = text;
				if (mSelectedItem == text || (i == 0 && string.IsNullOrEmpty(mSelectedItem)))
				{
					HGDCDPCBHIO(uILabel, true);
				}
				BMCEJIIMKKN.Add(uILabel);
			}
			a = Mathf.Max(a, bounds.size.x * num3 - (border.x + padding.x) * 2f);
			float num7 = a / num3;
			Vector3 vector = new Vector3(num7 * 0.5f, (0f - num2) * 0.5f, 0f);
			Vector3 vector2 = new Vector3(num7, (num4 + padding.y) / num3, 1f);
			int j = 0;
			for (int count2 = list.Count; j < count2; j++)
			{
				UILabel uILabel2 = list[j];
				NLDABIMKKMP.EJPENNCFGKM(uILabel2.gameObject);
				BoxCollider component = uILabel2.GetComponent<BoxCollider>();
				if (component != null)
				{
					vector.z = component.center.z;
					component.center = vector;
					component.size = vector2;
				}
				else
				{
					BoxCollider2D component2 = uILabel2.GetComponent<BoxCollider2D>();
					component2.offset = vector;
					component2.size = vector2;
				}
			}
			int width = Mathf.RoundToInt(a);
			a += (border.x + padding.x) * 2f;
			num5 -= border.y;
			MFDPPDINMHL.set_width(Mathf.RoundToInt(a));
			MFDPPDINMHL.set_height(Mathf.RoundToInt(0f - num5 + border.y));
			int k = 0;
			for (int count3 = list.Count; k < count3; k++)
			{
				UILabel uILabel3 = list[k];
				uILabel3.set_overflowMethod(UILabel.JCMMPAEEKEC.ShrinkContent);
				uILabel3.set_width(width);
			}
			float num8 = 2f * atlas.get_pixelSize();
			float f = a - (border.x + padding.x) * 2f + (float)atlasSprite.borderLeft * num8;
			float f2 = num4 + num * num8;
			FFLGBDBPNNB.set_width(Mathf.RoundToInt(f));
			FFLGBDBPNNB.set_height(Mathf.RoundToInt(f2));
			bool flag = position == CGNFDFOCFHO.Above;
			if (position == CGNFDFOCFHO.Auto)
			{
				UICamera uICamera = UICamera.FindCameraForLayer(base.gameObject.layer);
				if (uICamera != null)
				{
					flag = uICamera.get_cachedCamera().WorldToViewportPoint(transform.position).y < 0.5f;
				}
			}
			if (isAnimated)
			{
				float hKAHBBIAGHM = num5 + num4;
				EINDHIEGCIK(FFLGBDBPNNB, flag, hKAHBBIAGHM);
				int l = 0;
				for (int count4 = list.Count; l < count4; l++)
				{
					EINDHIEGCIK(list[l], flag, hKAHBBIAGHM);
				}
				PFEKLLKOCOP(MFDPPDINMHL);
				DDBHEOMLDPH(MFDPPDINMHL, flag, hKAHBBIAGHM);
			}
			if (flag)
			{
				transform2.localPosition = new Vector3(bounds.min.x, bounds.max.y - num5 - border.y, bounds.min.z);
			}
		}
		else
		{
			JADBJGCMIMF(false);
		}
	}

	private Vector3 OAAOAMDEGNN()
	{
		if (EJOEPCIEPKD == null)
		{
			return Vector3.zero;
		}
		UISpriteData uISpriteData = FFLGBDBPNNB.GJKAIBDBCFN();
		if (uISpriteData == null)
		{
			return Vector3.zero;
		}
		float num = atlas.JDOJMENMKHJ();
		float num2 = (float)uISpriteData.borderLeft * num;
		float y = (float)uISpriteData.borderTop * num;
		return EJOEPCIEPKD.get_cachedTransform().localPosition + new Vector3(0f - num2, y, 138f);
	}

	private void OnLocalize()
	{
		if (isLocalized)
		{
			JHBFDHPHIPN();
		}
	}

	public bool get_isOpen()
	{
		return ANOIPNOCGGF != null;
	}

	private void NCFGKGOAMMN()
	{
		if (isLocalized)
		{
			JHBFDHPHIPN();
		}
	}

	[SpecialName]
	public string GDJOHLLAOOK()
	{
		return mSelectedItem;
	}

	[SpecialName]
	public void AGBKAJNBEGO(string ICENKPDOHBK)
	{
		mSelectedItem = ICENKPDOHBK;
		if (mSelectedItem != null && mSelectedItem != null)
		{
			JHBFDHPHIPN();
		}
	}

	[SpecialName]
	public void GJJPHDKCHBP(string ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	[SpecialName]
	public DALEJIENJLM NNAPHNAOGMC()
	{
		return HMHLBNJAAPC;
	}

	[SpecialName]
	public void EJFDKKEEEIG(string ICENKPDOHBK)
	{
		mSelectedItem = ICENKPDOHBK;
		if (mSelectedItem != null && mSelectedItem != null)
		{
			JHBFDHPHIPN();
		}
	}

	[SpecialName]
	public void NCIGDECCDFN(UnityEngine.Object ICENKPDOHBK)
	{
		if (ICENKPDOHBK is Font)
		{
			trueTypeFont = ICENKPDOHBK as Font;
			bitmapFont = null;
			font = null;
		}
		else if (ICENKPDOHBK is UIFont)
		{
			bitmapFont = ICENKPDOHBK as UIFont;
			trueTypeFont = null;
			font = null;
		}
	}

	private Vector3 IFOEJEJNEMF()
	{
		if (EJOEPCIEPKD == null)
		{
			return Vector3.zero;
		}
		UISpriteData uISpriteData = FFLGBDBPNNB.GJKAIBDBCFN();
		if (uISpriteData == null)
		{
			return Vector3.zero;
		}
		float num = atlas.JDOJMENMKHJ();
		float num2 = (float)uISpriteData.borderLeft * num;
		float y = (float)uISpriteData.borderTop * num;
		return EJOEPCIEPKD.get_cachedTransform().localPosition + new Vector3(0f - num2, y, 1087f);
	}

	protected void JHBFDHPHIPN()
	{
		if (current != this)
		{
			UIPopupList uIPopupList = current;
			current = this;
			if (HMHLBNJAAPC != null)
			{
				HMHLBNJAAPC(mSelectedItem);
			}
			if (EventDelegate.AHGNGKFJAOI(onChange))
			{
				EventDelegate.MKPMEAMPDLJ(onChange);
			}
			else if (eventReceiver != null && !string.IsNullOrEmpty(functionName))
			{
				eventReceiver.SendMessage(functionName, mSelectedItem, SendMessageOptions.DontRequireReceiver);
			}
			current = uIPopupList;
		}
	}

	private void OBGALOFMDML(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			LPANHHLFAHF(LHACFNECMNA.GetComponent<UILabel>(), true);
		}
	}

	private Vector3 NNPFBCHCKFH()
	{
		if (EJOEPCIEPKD == null)
		{
			return Vector3.zero;
		}
		UISpriteData atlasSprite = FFLGBDBPNNB.GetAtlasSprite();
		if (atlasSprite == null)
		{
			return Vector3.zero;
		}
		float pixelSize = atlas.get_pixelSize();
		float num = (float)atlasSprite.borderLeft * pixelSize;
		float y = (float)atlasSprite.borderTop * pixelSize;
		return EJOEPCIEPKD.get_cachedTransform().localPosition + new Vector3(0f - num, y, 1f);
	}

	[DebuggerHidden]
	private IEnumerator AKNMFAGKPED()
	{
		GJFAAPECGGF gJFAAPECGGF = new GJFAAPECGGF();
		gJFAAPECGGF.KNIAJMGDGAA = this;
		return gJFAAPECGGF;
	}

	private void EMMCLPJADFN(UIWidget ANEPINFLFJK)
	{
		Color color = ANEPINFLFJK.get_color();
		ANEPINFLFJK.set_color(new Color(color.r, color.g, color.b, 1047f));
		TweenColor.Begin(ANEPINFLFJK.gameObject, 1913f, color).method = UITweener.MAIJGNJIIIC.Linear;
	}

	private void FIEHFDLBDKD(bool IOGFFPOIBBB)
	{
		if (!IOGFFPOIBBB)
		{
			Close();
		}
	}

	public UnityEngine.Object get_ambigiousFont()
	{
		if (trueTypeFont != null)
		{
			return trueTypeFont;
		}
		if (bitmapFont != null)
		{
			return bitmapFont;
		}
		return font;
	}

	public DALEJIENJLM get_onSelectionChange()
	{
		return HMHLBNJAAPC;
	}
}
