using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Input Field")]
public class UIInput : MonoBehaviour
{
	public enum NACDKDJHJGB
	{
		Standard = 0,
		AutoCorrect = 1,
		Password = 2
	}

	public enum DEHBPDBFIAL
	{
		None = 0,
		Integer = 1,
		Float = 2,
		Alphanumeric = 3,
		Username = 4,
		Name = 5
	}

	public enum ABKBFPBPCBH
	{
		Default = 0,
		ASCIICapable = 1,
		NumbersAndPunctuation = 2,
		URL = 3,
		NumberPad = 4,
		PhonePad = 5,
		NamePhonePad = 6,
		EmailAddress = 7
	}

	public enum NBNDGIACPBN
	{
		Default = 0,
		Submit = 1,
		NewLine = 2
	}

	public delegate char IKNMJLFNLJH(string BMNKKBDCELE, int GIJDBKJDLNB, char GGKPDDGCFJE);

	public static UIInput current;

	public static UIInput selection;

	public UILabel label;

	public NACDKDJHJGB inputType;

	public NBNDGIACPBN onReturnKey;

	public ABKBFPBPCBH keyboardType;

	public bool hideInput;

	public DEHBPDBFIAL validation;

	public int characterLimit;

	public string savedAs;

	public GameObject selectOnTab;

	public Color activeTextColor = Color.white;

	public Color caretColor = new Color(1f, 1f, 1f, 0.8f);

	public Color selectionColor = new Color(1f, 223f / 255f, 141f / 255f, 0.5f);

	public List<EventDelegate> onSubmit = new List<EventDelegate>();

	public List<EventDelegate> onChange = new List<EventDelegate>();

	public IKNMJLFNLJH onValidate;

	[SerializeField]
	[HideInInspector]
	protected string mValue;

	[NonSerialized]
	protected string HABOBGOEMKN = string.Empty;

	[NonSerialized]
	protected Color BAOFOHKGELG = Color.white;

	[NonSerialized]
	protected float CANMIFCKKLE;

	[NonSerialized]
	protected bool GACPCJMOMBG = true;

	[NonSerialized]
	protected UIWidget.MADDMCMJKFI MIBDBOOFIOF;

	[NonSerialized]
	protected bool MLAFEMFNGJN = true;

	protected static int OIAEMPDJONN;

	protected static string JKDNCOFMOMO = string.Empty;

	protected static TouchScreenKeyboard ENJFEMDMJFP;

	[NonSerialized]
	protected int NBIGEFAENHP;

	[NonSerialized]
	protected int OJOPELFGKGB;

	[NonSerialized]
	protected UITexture FFLGBDBPNNB;

	[NonSerialized]
	protected UITexture HNPALDEBBEG;

	[NonSerialized]
	protected Texture2D ACENHMAHMDK;

	[NonSerialized]
	protected float EANHLFAFDCG;

	[NonSerialized]
	protected float OOJFPGHMJJA;

	[NonSerialized]
	protected string POAEHCAPMJO = string.Empty;

	[NonSerialized]
	protected int GPDLGLOLBAM = -1;

	public string DOALAHFBGNE
	{
		get
		{
			return get_defaultText();
		}
		set
		{
			set_defaultText(value);
		}
	}

	public bool FPAKKMJOIHJ
	{
		get
		{
			return get_inputShouldBeHidden();
		}
	}

	[Obsolete("Use UIInput.value instead")]
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

	[Obsolete("Use UIInput.isSelected instead")]
	public bool JBHJFOLKOCP
	{
		get
		{
			return get_selected();
		}
		set
		{
			set_selected(value);
		}
	}

	public bool IOGFFPOIBBB
	{
		get
		{
			return get_isSelected();
		}
		set
		{
			set_isSelected(value);
		}
	}

	public int INHJNIMAJCH
	{
		get
		{
			return get_cursorPosition();
		}
		set
		{
			set_cursorPosition(value);
		}
	}

	public int NKHNPKKEBGI
	{
		get
		{
			return get_selectionStart();
		}
		set
		{
			set_selectionStart(value);
		}
	}

	public int FPBGEBPEGMB
	{
		get
		{
			return get_selectionEnd();
		}
		set
		{
			set_selectionEnd(value);
		}
	}

	public UITexture LFBNHHCAIEA
	{
		get
		{
			return get_caret();
		}
	}

	public void Submit()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			mValue = get_value();
			if (current == null)
			{
				current = this;
				EventDelegate.MKPMEAMPDLJ(onSubmit);
				current = null;
			}
			FALCJDGEAIM(mValue);
		}
	}

	public string Validate(string JKJGJMOEHDO)
	{
		if (string.IsNullOrEmpty(JKJGJMOEHDO))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder(JKJGJMOEHDO.Length);
		for (int i = 0; i < JKJGJMOEHDO.Length; i++)
		{
			char c = JKJGJMOEHDO[i];
			if (onValidate != null)
			{
				c = onValidate(stringBuilder.ToString(), stringBuilder.Length, c);
			}
			else if (validation != DEHBPDBFIAL.None)
			{
				c = PBHCIHJGEOO(stringBuilder.ToString(), stringBuilder.Length, c);
			}
			if (c != 0)
			{
				stringBuilder.Append(c);
			}
		}
		if (characterLimit > 0 && stringBuilder.Length > characterLimit)
		{
			return stringBuilder.ToString(0, characterLimit);
		}
		return stringBuilder.ToString();
	}

	private void OnGUI()
	{
		if (get_isSelected() && Event.current.rawType == EventType.KeyDown)
		{
			ODJMJBKILJL(Event.current);
		}
	}

	public string get_defaultText()
	{
		return HABOBGOEMKN;
	}

	protected virtual void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if (label != null && (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Touch))
		{
			set_selectionEnd(HPAFFOHDGIN());
		}
	}

	[SpecialName]
	public string CMGIMLOCEDJ()
	{
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		return mValue;
	}

	public int get_selectionStart()
	{
		if (ENJFEMDMJFP != null && !get_inputShouldBeHidden())
		{
			return 0;
		}
		return (!get_isSelected()) ? get_value().Length : NBIGEFAENHP;
	}

	protected void LDBMDDFCIDD()
	{
		if (current == null && EventDelegate.AHGNGKFJAOI(onChange))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onChange);
			current = null;
		}
	}

	public bool get_inputShouldBeHidden()
	{
		return hideInput && label != null && !label.get_multiLine() && inputType != NACDKDJHJGB.Password;
	}

	public string get_value()
	{
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		return mValue;
	}

	public void set_value(string ICENKPDOHBK)
	{
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		OIAEMPDJONN = 0;
		if (Application.platform == ((RuntimePlatform)22))
		{
			ICENKPDOHBK = ICENKPDOHBK.Replace("\\b", "\b");
		}
		ICENKPDOHBK = Validate(ICENKPDOHBK);
		if (get_isSelected() && ENJFEMDMJFP != null && POAEHCAPMJO != ICENKPDOHBK)
		{
			ENJFEMDMJFP.text = ICENKPDOHBK;
			POAEHCAPMJO = ICENKPDOHBK;
		}
		if (!(mValue != ICENKPDOHBK))
		{
			return;
		}
		mValue = ICENKPDOHBK;
		MLAFEMFNGJN = false;
		if (get_isSelected())
		{
			if (string.IsNullOrEmpty(ICENKPDOHBK))
			{
				NBIGEFAENHP = 0;
				OJOPELFGKGB = 0;
			}
			else
			{
				NBIGEFAENHP = ICENKPDOHBK.Length;
				OJOPELFGKGB = NBIGEFAENHP;
			}
		}
		else
		{
			FALCJDGEAIM(ICENKPDOHBK);
		}
		UpdateLabel();
		LDBMDDFCIDD();
	}

	public int get_selectionEnd()
	{
		if (ENJFEMDMJFP != null && !get_inputShouldBeHidden())
		{
			return get_value().Length;
		}
		return (!get_isSelected()) ? get_value().Length : OJOPELFGKGB;
	}

	protected string MIBIJBFCPCG()
	{
		int num = Mathf.Max(NBIGEFAENHP, OJOPELFGKGB);
		return (!string.IsNullOrEmpty(mValue) && num < mValue.Length) ? mValue.Substring(num) : string.Empty;
	}

	[SpecialName]
	public UITexture MBJLDICCBDE()
	{
		return HNPALDEBBEG;
	}

	protected virtual void FFHOHJFLPFD(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM && get_isSelected() && label != null && (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse))
		{
			set_selectionEnd(HPAFFOHDGIN());
			if (!Input.GetKey((KeyCode)(-111)) && !Input.GetKey(KeyCode.Equals))
			{
				set_selectionStart(OJOPELFGKGB);
			}
		}
	}

	protected virtual void BEADMIJEKJF(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM && get_isSelected() && label != null && (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Touch))
		{
			set_selectionEnd(HPAFFOHDGIN());
			if (!Input.GetKey((KeyCode)(-82)) && !Input.GetKey((KeyCode)(-152)))
			{
				set_selectionStart(OJOPELFGKGB);
			}
		}
	}

	public UITexture get_caret()
	{
		return HNPALDEBBEG;
	}

	public void set_defaultText(string ICENKPDOHBK)
	{
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		HABOBGOEMKN = ICENKPDOHBK;
		UpdateLabel();
	}

	private void GKNMGIONEKK()
	{
		if (MLAFEMFNGJN && !string.IsNullOrEmpty(savedAs))
		{
			LoadValue();
		}
		else
		{
			set_value(mValue.Replace("攻撃速度", "GameItem Hack"));
		}
	}

	private void Update()
	{
		if (!get_isSelected())
		{
			return;
		}
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		if (GPDLGLOLBAM != -1 && GPDLGLOLBAM != Time.frameCount)
		{
			GPDLGLOLBAM = -1;
			NBIGEFAENHP = 0;
			OJOPELFGKGB = ((!string.IsNullOrEmpty(mValue)) ? mValue.Length : 0);
			OIAEMPDJONN = 0;
			label.set_color(activeTextColor);
			if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.WP8Player || Application.platform == ((RuntimePlatform)22))
			{
				TouchScreenKeyboardType touchScreenKeyboardType;
				string text;
				if (get_inputShouldBeHidden())
				{
					TouchScreenKeyboard.hideInput = true;
					touchScreenKeyboardType = (TouchScreenKeyboardType)keyboardType;
					text = "|";
				}
				else if (inputType == NACDKDJHJGB.Password)
				{
					TouchScreenKeyboard.hideInput = false;
					touchScreenKeyboardType = TouchScreenKeyboardType.Default;
					text = mValue;
					NBIGEFAENHP = OJOPELFGKGB;
				}
				else
				{
					TouchScreenKeyboard.hideInput = false;
					touchScreenKeyboardType = (TouchScreenKeyboardType)keyboardType;
					text = mValue;
					NBIGEFAENHP = OJOPELFGKGB;
				}
				ENJFEMDMJFP = ((inputType != NACDKDJHJGB.Password) ? TouchScreenKeyboard.Open(text, touchScreenKeyboardType, !get_inputShouldBeHidden() && inputType == NACDKDJHJGB.AutoCorrect, label.get_multiLine() && !hideInput, false, false, get_defaultText()) : TouchScreenKeyboard.Open(text, touchScreenKeyboardType, false, false, true));
			}
			else
			{
				Vector2 compositionCursorPos = ((!(UICamera.current != null) || !(UICamera.current.get_cachedCamera() != null)) ? label.get_worldCorners()[0] : UICamera.current.get_cachedCamera().WorldToScreenPoint(label.get_worldCorners()[0]));
				compositionCursorPos.y = (float)Screen.height - compositionCursorPos.y;
				Input.imeCompositionMode = IMECompositionMode.On;
				Input.compositionCursorPos = compositionCursorPos;
			}
			UpdateLabel();
			return;
		}
		if (ENJFEMDMJFP != null)
		{
			string text2 = ENJFEMDMJFP.text;
			if (get_inputShouldBeHidden())
			{
				if (text2 != "|")
				{
					if (!string.IsNullOrEmpty(text2))
					{
						PGNKPIFFMJE(text2.Substring(1));
					}
					else
					{
						BOBNHOENDPO();
					}
					ENJFEMDMJFP.text = "|";
				}
			}
			else if (POAEHCAPMJO != text2)
			{
				POAEHCAPMJO = text2;
				set_value(text2);
			}
			if (ENJFEMDMJFP.done || !ENJFEMDMJFP.active)
			{
				if (!ENJFEMDMJFP.wasCanceled)
				{
					Submit();
				}
				ENJFEMDMJFP = null;
				set_isSelected(false);
				POAEHCAPMJO = string.Empty;
			}
		}
		else
		{
			if (selectOnTab != null && Input.GetKeyDown(KeyCode.Tab))
			{
				UICamera.set_selectedObject(selectOnTab);
				return;
			}
			string compositionString = Input.compositionString;
			if (string.IsNullOrEmpty(compositionString) && !string.IsNullOrEmpty(Input.inputString))
			{
				string inputString = Input.inputString;
				for (int i = 0; i < inputString.Length; i++)
				{
					char c = inputString[i];
					if (c >= ' ' && c != '\uf700' && c != '\uf701' && c != '\uf702' && c != '\uf703')
					{
						PGNKPIFFMJE(c.ToString());
					}
				}
			}
			if (JKDNCOFMOMO != compositionString)
			{
				OJOPELFGKGB = ((!string.IsNullOrEmpty(compositionString)) ? (mValue.Length + compositionString.Length) : NBIGEFAENHP);
				JKDNCOFMOMO = compositionString;
				UpdateLabel();
				LDBMDDFCIDD();
			}
		}
		if (HNPALDEBBEG != null && EANHLFAFDCG < RealTime.get_time())
		{
			EANHLFAFDCG = RealTime.get_time() + 0.5f;
			HNPALDEBBEG.enabled = !HNPALDEBBEG.enabled;
		}
		if (get_isSelected() && OOJFPGHMJJA != label.finalAlpha)
		{
			UpdateLabel();
		}
	}

	protected int HPAFFOHDGIN()
	{
		Vector3[] worldCorners = label.get_worldCorners();
		Ray currentRay = UICamera.get_currentRay();
		float enter;
		return new Plane(worldCorners[0], worldCorners[1], worldCorners[2]).Raycast(currentRay, out enter) ? (OIAEMPDJONN + label.GetCharacterIndexAtPosition(currentRay.GetPoint(enter))) : 0;
	}

	protected void DMPCGEBBOIO()
	{
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		if (label != null && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			mValue = get_value();
			if (ENJFEMDMJFP != null)
			{
				ENJFEMDMJFP.active = true;
				ENJFEMDMJFP = null;
			}
			if (string.IsNullOrEmpty(mValue))
			{
				label.DCKJILCPKFD(HABOBGOEMKN);
				label.set_color(BAOFOHKGELG);
			}
			else
			{
				label.set_text(mValue);
			}
			Input.imeCompositionMode = IMECompositionMode.On;
			NBPLAFECDCO();
		}
		selection = null;
		UpdateLabel();
	}

	private void OnDisable()
	{
		FMDFFHAAMID();
	}

	protected virtual void PGNKPIFFMJE(string BMNKKBDCELE)
	{
		string text = CNMILBFDCGH();
		string text2 = MIBIJBFCPCG();
		int length = text2.Length;
		StringBuilder stringBuilder = new StringBuilder(text.Length + text2.Length + BMNKKBDCELE.Length);
		stringBuilder.Append(text);
		int i = 0;
		for (int length2 = BMNKKBDCELE.Length; i < length2; i++)
		{
			if (characterLimit > 0 && stringBuilder.Length + length >= characterLimit)
			{
				break;
			}
			char c = BMNKKBDCELE[i];
			if (onValidate != null)
			{
				c = onValidate(stringBuilder.ToString(), stringBuilder.Length, c);
			}
			else if (validation != DEHBPDBFIAL.None)
			{
				c = PBHCIHJGEOO(stringBuilder.ToString(), stringBuilder.Length, c);
			}
			if (c != 0)
			{
				stringBuilder.Append(c);
			}
		}
		NBIGEFAENHP = stringBuilder.Length;
		OJOPELFGKGB = NBIGEFAENHP;
		int j = 0;
		for (int length3 = text2.Length; j < length3; j++)
		{
			char c2 = text2[j];
			if (onValidate != null)
			{
				c2 = onValidate(stringBuilder.ToString(), stringBuilder.Length, c2);
			}
			else if (validation != DEHBPDBFIAL.None)
			{
				c2 = PBHCIHJGEOO(stringBuilder.ToString(), stringBuilder.Length, c2);
			}
			if (c2 != 0)
			{
				stringBuilder.Append(c2);
			}
		}
		mValue = stringBuilder.ToString();
		UpdateLabel();
		LDBMDDFCIDD();
	}

	public int get_cursorPosition()
	{
		if (ENJFEMDMJFP != null && !get_inputShouldBeHidden())
		{
			return get_value().Length;
		}
		return (!get_isSelected()) ? get_value().Length : OJOPELFGKGB;
	}

	protected virtual bool ODJMJBKILJL(Event ENANCLPIOGJ)
	{
		if (label == null)
		{
			return false;
		}
		RuntimePlatform platform = Application.platform;
		bool flag = ((platform != RuntimePlatform.OSXEditor && platform != RuntimePlatform.OSXPlayer && platform != ((RuntimePlatform)3)) ? ((ENANCLPIOGJ.modifiers & EventModifiers.Control) != 0) : ((ENANCLPIOGJ.modifiers & EventModifiers.Command) != 0));
		bool flag2 = (ENANCLPIOGJ.modifiers & EventModifiers.Shift) != 0;
		switch (ENANCLPIOGJ.keyCode)
		{
		case KeyCode.Backspace:
			ENANCLPIOGJ.Use();
			BOBNHOENDPO();
			return true;
		case KeyCode.Delete:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				if (NBIGEFAENHP == OJOPELFGKGB)
				{
					if (NBIGEFAENHP >= mValue.Length)
					{
						return true;
					}
					OJOPELFGKGB++;
				}
				PGNKPIFFMJE(string.Empty);
			}
			return true;
		case KeyCode.LeftArrow:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				OJOPELFGKGB = Mathf.Max(OJOPELFGKGB - 1, 0);
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.RightArrow:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				OJOPELFGKGB = Mathf.Min(OJOPELFGKGB + 1, mValue.Length);
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.PageUp:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				OJOPELFGKGB = 0;
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.PageDown:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				OJOPELFGKGB = mValue.Length;
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.Home:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				if (label.get_multiLine())
				{
					OJOPELFGKGB = label.GetCharacterIndex(OJOPELFGKGB, KeyCode.Home);
				}
				else
				{
					OJOPELFGKGB = 0;
				}
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.End:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				if (label.get_multiLine())
				{
					OJOPELFGKGB = label.GetCharacterIndex(OJOPELFGKGB, KeyCode.End);
				}
				else
				{
					OJOPELFGKGB = mValue.Length;
				}
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.UpArrow:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				OJOPELFGKGB = label.GetCharacterIndex(OJOPELFGKGB, KeyCode.UpArrow);
				if (OJOPELFGKGB != 0)
				{
					OJOPELFGKGB += OIAEMPDJONN;
				}
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.DownArrow:
			ENANCLPIOGJ.Use();
			if (!string.IsNullOrEmpty(mValue))
			{
				OJOPELFGKGB = label.GetCharacterIndex(OJOPELFGKGB, KeyCode.DownArrow);
				if (OJOPELFGKGB != label.get_processedText().Length)
				{
					OJOPELFGKGB += OIAEMPDJONN;
				}
				else
				{
					OJOPELFGKGB = mValue.Length;
				}
				if (!flag2)
				{
					NBIGEFAENHP = OJOPELFGKGB;
				}
				UpdateLabel();
			}
			return true;
		case KeyCode.A:
			if (flag)
			{
				ENANCLPIOGJ.Use();
				NBIGEFAENHP = 0;
				OJOPELFGKGB = mValue.Length;
				UpdateLabel();
			}
			return true;
		case KeyCode.C:
			if (flag)
			{
				ENANCLPIOGJ.Use();
				NLDABIMKKMP.DJILPNJPOPC(ADCEJCBPLBH());
			}
			return true;
		case KeyCode.V:
			if (flag)
			{
				ENANCLPIOGJ.Use();
				PGNKPIFFMJE(NLDABIMKKMP.NGAMPPOJCHJ());
			}
			return true;
		case KeyCode.X:
			if (flag)
			{
				ENANCLPIOGJ.Use();
				NLDABIMKKMP.DJILPNJPOPC(ADCEJCBPLBH());
				PGNKPIFFMJE(string.Empty);
			}
			return true;
		case KeyCode.Return:
		case KeyCode.KeypadEnter:
			ENANCLPIOGJ.Use();
			if (onReturnKey == NBNDGIACPBN.NewLine || (onReturnKey == NBNDGIACPBN.Default && label.get_multiLine() && !flag && label.get_overflowMethod() != UILabel.JCMMPAEEKEC.ClampContent && validation == DEHBPDBFIAL.None))
			{
				PGNKPIFFMJE("\n");
			}
			else
			{
				UICamera.currentScheme = UICamera.DOCFHOGBBJH.Controller;
				UICamera.currentKey = ENANCLPIOGJ.keyCode;
				Submit();
				UICamera.currentKey = KeyCode.None;
			}
			return true;
		default:
			return false;
		}
	}

	public void LoadValue()
	{
		if (!string.IsNullOrEmpty(savedAs))
		{
			string text = mValue.Replace("\\n", "\n");
			mValue = string.Empty;
			set_value((!PlayerPrefs.HasKey(savedAs)) ? text : PlayerPrefs.GetString(savedAs));
		}
	}

	protected virtual void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM && get_isSelected() && label != null && (UICamera.currentScheme == UICamera.DOCFHOGBBJH.Mouse || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Touch))
		{
			set_selectionEnd(HPAFFOHDGIN());
			if (!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
			{
				set_selectionStart(OJOPELFGKGB);
			}
		}
	}

	protected virtual void FMDFFHAAMID()
	{
		if ((bool)FFLGBDBPNNB)
		{
			FFLGBDBPNNB.enabled = false;
		}
		if ((bool)HNPALDEBBEG)
		{
			HNPALDEBBEG.enabled = false;
		}
		if ((bool)ACENHMAHMDK)
		{
			NLDABIMKKMP.HEAFKMJAOHM(ACENHMAHMDK);
			ACENHMAHMDK = null;
		}
	}

	public bool get_selected()
	{
		return get_isSelected();
	}

	public void set_selected(bool ICENKPDOHBK)
	{
		set_isSelected(ICENKPDOHBK);
	}

	protected void FALCJDGEAIM(string JKJGJMOEHDO)
	{
		if (!string.IsNullOrEmpty(savedAs))
		{
			if (string.IsNullOrEmpty(JKJGJMOEHDO))
			{
				PlayerPrefs.DeleteKey(savedAs);
			}
			else
			{
				PlayerPrefs.SetString(savedAs, JKJGJMOEHDO);
			}
		}
	}

	public void set_isSelected(bool ICENKPDOHBK)
	{
		if (!ICENKPDOHBK)
		{
			if (get_isSelected())
			{
				UICamera.set_selectedObject(null);
			}
		}
		else
		{
			UICamera.set_selectedObject(base.gameObject);
		}
	}

	private void Start()
	{
		if (MLAFEMFNGJN && !string.IsNullOrEmpty(savedAs))
		{
			LoadValue();
		}
		else
		{
			set_value(mValue.Replace("\\n", "\n"));
		}
	}

	protected void DPIFGKMBDFI()
	{
		Vector2 bFEECILPJLM = HHAINCPODGE.OILFNOECKPI(MIBDBOOFIOF);
		bFEECILPJLM.x = 1f;
		label.set_pivot(HHAINCPODGE.FIIPBCFKFBF(bFEECILPJLM));
	}

	public void UpdateLabel()
	{
		if (!(label != null))
		{
			return;
		}
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		bool isSelected = get_isSelected();
		string value = get_value();
		bool flag = string.IsNullOrEmpty(value) && string.IsNullOrEmpty(Input.compositionString);
		label.set_color((!flag || isSelected) ? activeTextColor : BAOFOHKGELG);
		string text;
		if (flag)
		{
			text = ((!isSelected) ? HABOBGOEMKN : string.Empty);
			NBPLAFECDCO();
		}
		else
		{
			if (inputType == NACDKDJHJGB.Password)
			{
				text = string.Empty;
				string text2 = "*";
				if (label.get_bitmapFont() != null && label.get_bitmapFont().get_bmFont() != null && label.get_bitmapFont().get_bmFont().KHLMNHAIBFH(42) == null)
				{
					text2 = "x";
				}
				int i = 0;
				for (int length = value.Length; i < length; i++)
				{
					text += text2;
				}
			}
			else
			{
				text = value;
			}
			int num = (isSelected ? Mathf.Min(text.Length, get_cursorPosition()) : 0);
			string text3 = text.Substring(0, num);
			if (isSelected)
			{
				text3 += Input.compositionString;
			}
			text = text3 + text.Substring(num, text.Length - num);
			if (isSelected && label.get_overflowMethod() == UILabel.JCMMPAEEKEC.ClampContent && label.get_maxLineCount() == 1)
			{
				int num2 = label.CalculateOffsetToFit(text);
				if (num2 == 0)
				{
					OIAEMPDJONN = 0;
					NBPLAFECDCO();
				}
				else if (num < OIAEMPDJONN)
				{
					OIAEMPDJONN = num;
					LJHFGONDNKE();
				}
				else if (num2 < OIAEMPDJONN)
				{
					OIAEMPDJONN = num2;
					LJHFGONDNKE();
				}
				else
				{
					num2 = label.CalculateOffsetToFit(text.Substring(0, num));
					if (num2 > OIAEMPDJONN)
					{
						OIAEMPDJONN = num2;
						DPIFGKMBDFI();
					}
				}
				if (OIAEMPDJONN != 0)
				{
					text = text.Substring(OIAEMPDJONN, text.Length - OIAEMPDJONN);
				}
			}
			else
			{
				OIAEMPDJONN = 0;
				NBPLAFECDCO();
			}
		}
		label.set_text(text);
		if (isSelected && (ENJFEMDMJFP == null || get_inputShouldBeHidden()))
		{
			int num3 = NBIGEFAENHP - OIAEMPDJONN;
			int num4 = OJOPELFGKGB - OIAEMPDJONN;
			if (ACENHMAHMDK == null)
			{
				ACENHMAHMDK = new Texture2D(2, 2, TextureFormat.ARGB32, false);
				for (int j = 0; j < 2; j++)
				{
					for (int k = 0; k < 2; k++)
					{
						ACENHMAHMDK.SetPixel(k, j, Color.white);
					}
				}
				ACENHMAHMDK.Apply();
			}
			if (num3 != num4)
			{
				if (FFLGBDBPNNB == null)
				{
					FFLGBDBPNNB = NLDABIMKKMP.EDDDFKNEJEN<UITexture>(label.get_cachedGameObject());
					FFLGBDBPNNB.name = "Input Highlight";
					FFLGBDBPNNB.set_mainTexture(ACENHMAHMDK);
					FFLGBDBPNNB.fillGeometry = false;
					FFLGBDBPNNB.set_pivot(label.get_pivot());
					FFLGBDBPNNB.SetAnchor(label.get_cachedTransform());
				}
				else
				{
					FFLGBDBPNNB.set_pivot(label.get_pivot());
					FFLGBDBPNNB.set_mainTexture(ACENHMAHMDK);
					FFLGBDBPNNB.MarkAsChanged();
					FFLGBDBPNNB.enabled = true;
				}
			}
			if (HNPALDEBBEG == null)
			{
				HNPALDEBBEG = NLDABIMKKMP.EDDDFKNEJEN<UITexture>(label.get_cachedGameObject());
				HNPALDEBBEG.name = "Input Caret";
				HNPALDEBBEG.set_mainTexture(ACENHMAHMDK);
				HNPALDEBBEG.fillGeometry = false;
				HNPALDEBBEG.set_pivot(label.get_pivot());
				HNPALDEBBEG.SetAnchor(label.get_cachedTransform());
			}
			else
			{
				HNPALDEBBEG.set_pivot(label.get_pivot());
				HNPALDEBBEG.set_mainTexture(ACENHMAHMDK);
				HNPALDEBBEG.MarkAsChanged();
				HNPALDEBBEG.enabled = true;
			}
			if (num3 != num4)
			{
				label.PrintOverlay(num3, num4, HNPALDEBBEG.geometry, FFLGBDBPNNB.geometry, caretColor, selectionColor);
				FFLGBDBPNNB.enabled = FFLGBDBPNNB.geometry.NOGNPLFBAPG();
			}
			else
			{
				label.PrintOverlay(num3, num4, HNPALDEBBEG.geometry, null, caretColor, selectionColor);
				if (FFLGBDBPNNB != null)
				{
					FFLGBDBPNNB.enabled = false;
				}
			}
			EANHLFAFDCG = RealTime.get_time() + 0.5f;
			OOJFPGHMJJA = label.finalAlpha;
		}
		else
		{
			FMDFFHAAMID();
		}
	}

	public void SaveValue()
	{
		FALCJDGEAIM(mValue);
	}

	protected void LDNEFFHJNPL()
	{
		if (GACPCJMOMBG && label != null)
		{
			GACPCJMOMBG = false;
			HABOBGOEMKN = label.get_text();
			BAOFOHKGELG = label.get_color();
			label.set_supportEncoding(false);
			if (label.get_alignment() == MGDLEEIDDII.NBEGJBKHJLH.Justified)
			{
				label.set_alignment(MGDLEEIDDII.NBEGJBKHJLH.Left);
				Debug.LogWarning("Input fields using labels with justified alignment are not supported at this time", this);
			}
			MIBDBOOFIOF = label.get_pivot();
			CANMIFCKKLE = label.get_cachedTransform().localPosition.x;
			UpdateLabel();
		}
	}

	[SpecialName]
	public bool AJJPEONJAIM()
	{
		return get_isSelected();
	}

	protected virtual void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (IOGFFPOIBBB)
		{
			GMENHEPLBFK();
		}
		else
		{
			FLDBFJKMNMB();
		}
	}

	protected string IBFDHJIDHJL()
	{
		int num = Mathf.Min(NBIGEFAENHP, OJOPELFGKGB);
		return (!string.IsNullOrEmpty(mValue) && num >= 0) ? mValue.Substring(0, num) : string.Empty;
	}

	protected string ADCEJCBPLBH()
	{
		if (string.IsNullOrEmpty(mValue) || NBIGEFAENHP == OJOPELFGKGB)
		{
			return string.Empty;
		}
		int num = Mathf.Min(NBIGEFAENHP, OJOPELFGKGB);
		int num2 = Mathf.Max(NBIGEFAENHP, OJOPELFGKGB);
		return mValue.Substring(num, num2 - num);
	}

	protected void BOBNHOENDPO()
	{
		if (string.IsNullOrEmpty(mValue))
		{
			return;
		}
		if (NBIGEFAENHP == OJOPELFGKGB)
		{
			if (NBIGEFAENHP < 1)
			{
				return;
			}
			OJOPELFGKGB--;
		}
		PGNKPIFFMJE(string.Empty);
	}

	public void set_text(string ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	protected char PBHCIHJGEOO(string BMNKKBDCELE, int HEPNHCEIFMO, char JBIBLBJBBAM)
	{
		if (validation == DEHBPDBFIAL.None || !base.enabled)
		{
			return JBIBLBJBBAM;
		}
		if (validation == DEHBPDBFIAL.Integer)
		{
			if (JBIBLBJBBAM >= '0' && JBIBLBJBBAM <= '9')
			{
				return JBIBLBJBBAM;
			}
			if (JBIBLBJBBAM == '-' && HEPNHCEIFMO == 0 && !BMNKKBDCELE.Contains("-"))
			{
				return JBIBLBJBBAM;
			}
		}
		else if (validation == DEHBPDBFIAL.Float)
		{
			if (JBIBLBJBBAM >= '0' && JBIBLBJBBAM <= '9')
			{
				return JBIBLBJBBAM;
			}
			if (JBIBLBJBBAM == '-' && HEPNHCEIFMO == 0 && !BMNKKBDCELE.Contains("-"))
			{
				return JBIBLBJBBAM;
			}
			if (JBIBLBJBBAM == '.' && !BMNKKBDCELE.Contains("."))
			{
				return JBIBLBJBBAM;
			}
		}
		else if (validation == DEHBPDBFIAL.Alphanumeric)
		{
			if (JBIBLBJBBAM >= 'A' && JBIBLBJBBAM <= 'Z')
			{
				return JBIBLBJBBAM;
			}
			if (JBIBLBJBBAM >= 'a' && JBIBLBJBBAM <= 'z')
			{
				return JBIBLBJBBAM;
			}
			if (JBIBLBJBBAM >= '0' && JBIBLBJBBAM <= '9')
			{
				return JBIBLBJBBAM;
			}
		}
		else if (validation == DEHBPDBFIAL.Username)
		{
			if (JBIBLBJBBAM >= 'A' && JBIBLBJBBAM <= 'Z')
			{
				return (char)(JBIBLBJBBAM - 65 + 97);
			}
			if (JBIBLBJBBAM >= 'a' && JBIBLBJBBAM <= 'z')
			{
				return JBIBLBJBBAM;
			}
			if (JBIBLBJBBAM >= '0' && JBIBLBJBBAM <= '9')
			{
				return JBIBLBJBBAM;
			}
		}
		else if (validation == DEHBPDBFIAL.Name)
		{
			char c = ((BMNKKBDCELE.Length <= 0) ? ' ' : BMNKKBDCELE[Mathf.Clamp(HEPNHCEIFMO, 0, BMNKKBDCELE.Length - 1)]);
			char c2 = ((BMNKKBDCELE.Length <= 0) ? '\n' : BMNKKBDCELE[Mathf.Clamp(HEPNHCEIFMO + 1, 0, BMNKKBDCELE.Length - 1)]);
			if (JBIBLBJBBAM >= 'a' && JBIBLBJBBAM <= 'z')
			{
				if (c == ' ')
				{
					return (char)(JBIBLBJBBAM - 97 + 65);
				}
				return JBIBLBJBBAM;
			}
			if (JBIBLBJBBAM >= 'A' && JBIBLBJBBAM <= 'Z')
			{
				if (c != ' ' && c != '\'')
				{
					return (char)(JBIBLBJBBAM - 65 + 97);
				}
				return JBIBLBJBBAM;
			}
			switch (JBIBLBJBBAM)
			{
			case '\'':
				if (c != ' ' && c != '\'' && c2 != '\'' && !BMNKKBDCELE.Contains("'"))
				{
					return JBIBLBJBBAM;
				}
				break;
			case ' ':
				if (c != ' ' && c != '\'' && c2 != ' ' && c2 != '\'')
				{
					return JBIBLBJBBAM;
				}
				break;
			}
		}
		return '\0';
	}

	protected void NBPLAFECDCO()
	{
		if (label != null && label.get_pivot() != MIBDBOOFIOF)
		{
			label.set_pivot(MIBDBOOFIOF);
		}
	}

	public void RemoveFocus()
	{
		set_isSelected(false);
	}

	protected void FLDBFJKMNMB()
	{
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		if (label != null && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			mValue = get_value();
			if (ENJFEMDMJFP != null)
			{
				ENJFEMDMJFP.active = false;
				ENJFEMDMJFP = null;
			}
			if (string.IsNullOrEmpty(mValue))
			{
				label.set_text(HABOBGOEMKN);
				label.set_color(BAOFOHKGELG);
			}
			else
			{
				label.set_text(mValue);
			}
			Input.imeCompositionMode = IMECompositionMode.Auto;
			NBPLAFECDCO();
		}
		selection = null;
		UpdateLabel();
	}

	private void GIHEMFBPGNK()
	{
		if (get_isSelected() && Event.current.rawType == EventType.KeyUp)
		{
			ODJMJBKILJL(Event.current);
		}
	}

	public string get_text()
	{
		return get_value();
	}

	[SpecialName]
	public int HCHLDNHADDK()
	{
		if (ENJFEMDMJFP != null && !get_inputShouldBeHidden())
		{
			return CMGIMLOCEDJ().Length;
		}
		return (!get_isSelected()) ? CMGIMLOCEDJ().Length : OJOPELFGKGB;
	}

	[SpecialName]
	public string MBDOJCKJIIK()
	{
		return CMGIMLOCEDJ();
	}

	public void set_selectionEnd(int ICENKPDOHBK)
	{
		if (get_isSelected() && (ENJFEMDMJFP == null || get_inputShouldBeHidden()))
		{
			OJOPELFGKGB = ICENKPDOHBK;
			UpdateLabel();
		}
	}

	protected void GMENHEPLBFK()
	{
		selection = this;
		if (GACPCJMOMBG)
		{
			LDNEFFHJNPL();
		}
		if (label != null && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GPDLGLOLBAM = Time.frameCount;
		}
	}

	protected void LJHFGONDNKE()
	{
		Vector2 bFEECILPJLM = HHAINCPODGE.OILFNOECKPI(MIBDBOOFIOF);
		bFEECILPJLM.x = 0f;
		label.set_pivot(HHAINCPODGE.FIIPBCFKFBF(bFEECILPJLM));
	}

	public void set_cursorPosition(int ICENKPDOHBK)
	{
		if (get_isSelected() && (ENJFEMDMJFP == null || get_inputShouldBeHidden()))
		{
			OJOPELFGKGB = ICENKPDOHBK;
			UpdateLabel();
		}
	}

	protected string CNMILBFDCGH()
	{
		int num = Mathf.Min(NBIGEFAENHP, OJOPELFGKGB);
		return (!string.IsNullOrEmpty(mValue) && num >= 0) ? mValue.Substring(0, num) : string.Empty;
	}

	public bool get_isSelected()
	{
		return selection == this;
	}

	public void set_selectionStart(int ICENKPDOHBK)
	{
		if (get_isSelected() && (ENJFEMDMJFP == null || get_inputShouldBeHidden()))
		{
			NBIGEFAENHP = ICENKPDOHBK;
			UpdateLabel();
		}
	}
}
