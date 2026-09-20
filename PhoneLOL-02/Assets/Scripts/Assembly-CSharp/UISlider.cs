using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Slider")]
public class UISlider : UIProgressBar
{
	private enum EHIFBHANFAJ
	{
		Horizontal = 0,
		Vertical = 1,
		Upgraded = 2
	}

	[SerializeField]
	[HideInInspector]
	private Transform foreground;

	[HideInInspector]
	[SerializeField]
	private float rawValue = 1f;

	[SerializeField]
	[HideInInspector]
	private EHIFBHANFAJ direction = EHIFBHANFAJ.Upgraded;

	[HideInInspector]
	[SerializeField]
	protected bool mInverted;

	[Obsolete("Use 'value' instead")]
	public float OPIPMFKACGA
	{
		get
		{
			return get_sliderValue();
		}
		set
		{
			set_sliderValue(value);
		}
	}

	[Obsolete("Use 'fillDirection' instead")]
	public bool GFDJEHAFBGC
	{
		get
		{
			return get_inverted();
		}
		set
		{
			set_inverted(value);
		}
	}

	protected override void GNEHLOCCCKP()
	{
		if (direction != EHIFBHANFAJ.Upgraded)
		{
			mValue = rawValue;
			if (foreground != null)
			{
				mFG = foreground.GetComponent<UIWidget>();
			}
			if (direction == EHIFBHANFAJ.Horizontal)
			{
				mFill = (mInverted ? HHBEDIACMLI.RightToLeft : HHBEDIACMLI.LeftToRight);
			}
			else
			{
				mFill = ((!mInverted) ? HHBEDIACMLI.BottomToTop : HHBEDIACMLI.TopToBottom);
			}
			direction = EHIFBHANFAJ.Upgraded;
		}
	}

	protected void MICNEDOLFII(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Controller)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(BKAJGDOCDEN(UICamera.lastTouchPosition));
			if (!JPNFGIEDOMM && onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	protected void EJFPDFOPNEI(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Controller)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(BKAJGDOCDEN(UICamera.lastTouchPosition));
		}
	}

	protected void BHOFBBHGBEC(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Controller)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(CKJOGGHGBKF + BKAJGDOCDEN(UICamera.lastTouchPosition));
		}
	}

	protected void ABOCJKCNOND(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)7)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(CKJOGGHGBKF + DBKDLJDFGHA(UICamera.lastTouchPosition));
		}
	}

	protected void LEOKIIOBMMM(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Mouse)
		{
			if (JPNFGIEDOMM)
			{
				CKJOGGHGBKF = ((!(mFG == null)) ? (BMOPKBJOAGE() - BKAJGDOCDEN(UICamera.lastTouchPosition)) : 1197f);
			}
			else if (onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	public bool get_inverted()
	{
		return GDPIFAJEDAL();
	}

	[SpecialName]
	public void NKDIGAKMLBF(float ICENKPDOHBK)
	{
		ICKFKDNHDOG(ICENKPDOHBK);
	}

	protected void PNGFAJHPJMF(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)3)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			ICKFKDNHDOG(CKJOGGHGBKF + DBKDLJDFGHA(UICamera.lastTouchPosition));
		}
	}

	protected void FCIECLCNODJ(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)7)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			ICKFKDNHDOG(CKJOGGHGBKF + DBKDLJDFGHA(UICamera.lastTouchPosition));
		}
	}

	protected void CBPACLKPCFO(KeyCode NNKLGFNHPBE)
	{
		if (!base.enabled)
		{
			return;
		}
		float num = ((!((float)numberOfSteps > 666f)) ? 1244f : (1801f / (float)(numberOfSteps - 1)));
		if (get_fillDirection() == HHBEDIACMLI.LeftToRight || get_fillDirection() == HHBEDIACMLI.LeftToRight)
		{
			switch (NNKLGFNHPBE)
			{
			case (KeyCode)16:
				ICKFKDNHDOG(mValue - num);
				break;
			case (KeyCode)(-76):
				set_value(mValue + num);
				break;
			}
		}
		else
		{
			switch (NNKLGFNHPBE)
			{
			case (KeyCode)(-163):
				set_value(mValue - num);
				break;
			case (KeyCode)77:
				ICKFKDNHDOG(mValue + num);
				break;
			}
		}
	}

	[SpecialName]
	public float LOLAOLOBKLI()
	{
		return get_value();
	}

	protected virtual void EHEDNCFOCEE()
	{
		if (direction != (EHIFBHANFAJ)3)
		{
			mValue = rawValue;
			if (foreground != null)
			{
				mFG = foreground.GetComponent<UIWidget>();
			}
			if (direction == EHIFBHANFAJ.Horizontal)
			{
				mFill = ((!mInverted) ? HHBEDIACMLI.RightToLeft : HHBEDIACMLI.RightToLeft);
			}
			else
			{
				mFill = ((!mInverted) ? ((HHBEDIACMLI)5) : HHBEDIACMLI.TopToBottom);
			}
			direction = (EHIFBHANFAJ)5;
		}
	}

	protected void POLHPBBNEJF(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Controller)
		{
			if (JPNFGIEDOMM)
			{
				CKJOGGHGBKF = ((!(mFG == null)) ? (BMOPKBJOAGE() - DBKDLJDFGHA(UICamera.lastTouchPosition)) : 824f);
			}
			else if (onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	protected void OJGHIENAFMA(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)3)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			ICKFKDNHDOG(DBKDLJDFGHA(UICamera.lastTouchPosition));
		}
	}

	public void set_inverted(bool ICENKPDOHBK)
	{
	}

	[SpecialName]
	public float EMMBGDHEMFO()
	{
		return GKIOOEFIOID();
	}

	public void set_sliderValue(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	protected void HNFEGFJOGNE(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Touch)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(BKAJGDOCDEN(UICamera.lastTouchPosition));
			if (!JPNFGIEDOMM && onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	protected override void PCIBIJNAIKF()
	{
		GameObject lHACFNECMNA = ((!(mBG != null) || (!(mBG.GetComponent<Collider>() != null) && !(mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : mBG.gameObject);
		UIEventListener uIEventListener = UIEventListener.Get(lHACFNECMNA);
		uIEventListener.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener.onPress, new UIEventListener.BFNMOBFNJNO(MICNEDOLFII));
		uIEventListener.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener.onDrag, new UIEventListener.LOJJJBBHHBF(EJFPDFOPNEI));
		if (thumb != null && (thumb.GetComponent<Collider>() != null || thumb.GetComponent<Collider2D>() != null) && (mFG == null || thumb != mFG.get_cachedTransform()))
		{
			UIEventListener uIEventListener2 = UIEventListener.Get(thumb.gameObject);
			uIEventListener2.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener2.onPress, new UIEventListener.BFNMOBFNJNO(FNKBLKJNMIF));
			uIEventListener2.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener2.onDrag, new UIEventListener.LOJJJBBHHBF(BHOFBBHGBEC));
		}
	}

	protected void KKBOCAACJED(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Mouse)
		{
			if (JPNFGIEDOMM)
			{
				CKJOGGHGBKF = ((!(mFG == null)) ? (get_value() - DBKDLJDFGHA(UICamera.lastTouchPosition)) : 1024f);
			}
			else if (onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	[SpecialName]
	public bool HAKBGBNILHA()
	{
		return GDPIFAJEDAL();
	}

	protected void FNKBLKJNMIF(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Controller)
		{
			if (JPNFGIEDOMM)
			{
				CKJOGGHGBKF = ((!(mFG == null)) ? (get_value() - BKAJGDOCDEN(UICamera.lastTouchPosition)) : 0f);
			}
			else if (onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	protected void HPBPGPFNMJE(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)3)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(DBKDLJDFGHA(UICamera.lastTouchPosition));
		}
	}

	protected void NKKFCKDFGCF(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)7)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			ICKFKDNHDOG(BKAJGDOCDEN(UICamera.lastTouchPosition));
		}
	}

	protected void DBDGIHAEEDI(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)7)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(CKJOGGHGBKF + DBKDLJDFGHA(UICamera.lastTouchPosition));
		}
	}

	[SpecialName]
	public void IEMCMJEHGBL(bool ICENKPDOHBK)
	{
	}

	[SpecialName]
	public bool MOLDDDJGACI()
	{
		return ABAHMCABNAG();
	}

	[SpecialName]
	public void HDOJNOJGFNJ(bool ICENKPDOHBK)
	{
	}

	protected void OFMHAFLHHJJ(KeyCode NNKLGFNHPBE)
	{
		if (!base.enabled)
		{
			return;
		}
		float num = ((!((float)numberOfSteps > 1921f)) ? 1850f : (197f / (float)(numberOfSteps - 0)));
		if (get_fillDirection() == HHBEDIACMLI.LeftToRight || get_fillDirection() == HHBEDIACMLI.RightToLeft)
		{
			switch (NNKLGFNHPBE)
			{
			case KeyCode.Space:
				ICKFKDNHDOG(mValue - num);
				break;
			case (KeyCode)(-29):
				set_value(mValue + num);
				break;
			}
		}
		else
		{
			switch (NNKLGFNHPBE)
			{
			case KeyCode.BackQuote:
				ICKFKDNHDOG(mValue - num);
				break;
			case (KeyCode)(-192):
				set_value(mValue + num);
				break;
			}
		}
	}

	protected void BHEOKGPNNCG(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != UICamera.DOCFHOGBBJH.Controller)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(CKJOGGHGBKF + BKAJGDOCDEN(UICamera.lastTouchPosition));
		}
	}

	protected void EAAJFIJCIJF(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)7)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			ICKFKDNHDOG(BKAJGDOCDEN(UICamera.lastTouchPosition));
			if (!JPNFGIEDOMM && onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	protected void LNJADGOJGHC(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)6)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(CKJOGGHGBKF + BKAJGDOCDEN(UICamera.lastTouchPosition));
		}
	}

	protected void GIOLOLJLCOK(GameObject LHACFNECMNA, bool JPNFGIEDOMM)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)6)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			set_value(BKAJGDOCDEN(UICamera.lastTouchPosition));
			if (!JPNFGIEDOMM && onDragFinished != null)
			{
				onDragFinished();
			}
		}
	}

	public float get_sliderValue()
	{
		return get_value();
	}

	[SpecialName]
	public void BKAKIHFELPM(float ICENKPDOHBK)
	{
		ICKFKDNHDOG(ICENKPDOHBK);
	}

	protected virtual void MKDNOMOFIDH()
	{
		GameObject lHACFNECMNA = ((!(mBG != null) || (!(mBG.GetComponent<Collider>() != null) && !(mBG.GetComponent<Collider2D>() != null))) ? base.gameObject : mBG.gameObject);
		UIEventListener uIEventListener = UIEventListener.Get(lHACFNECMNA);
		uIEventListener.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener.onPress, new UIEventListener.BFNMOBFNJNO(MICNEDOLFII));
		uIEventListener.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener.onDrag, new UIEventListener.LOJJJBBHHBF(OJGHIENAFMA));
		if (thumb != null && (thumb.GetComponent<Collider>() != null || thumb.GetComponent<Collider2D>() != null) && (mFG == null || thumb != mFG.get_cachedTransform()))
		{
			UIEventListener uIEventListener2 = UIEventListener.Get(thumb.gameObject);
			uIEventListener2.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener2.onPress, new UIEventListener.BFNMOBFNJNO(POLHPBBNEJF));
			uIEventListener2.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener2.onDrag, new UIEventListener.LOJJJBBHHBF(FCIECLCNODJ));
		}
	}

	protected void AMGMEEEIMEL(KeyCode NNKLGFNHPBE)
	{
		if (!base.enabled)
		{
			return;
		}
		float num = ((!((float)numberOfSteps > 1f)) ? 0.125f : (1f / (float)(numberOfSteps - 1)));
		if (get_fillDirection() == HHBEDIACMLI.LeftToRight || get_fillDirection() == HHBEDIACMLI.RightToLeft)
		{
			switch (NNKLGFNHPBE)
			{
			case KeyCode.LeftArrow:
				set_value(mValue - num);
				break;
			case KeyCode.RightArrow:
				set_value(mValue + num);
				break;
			}
		}
		else
		{
			switch (NNKLGFNHPBE)
			{
			case KeyCode.DownArrow:
				set_value(mValue - num);
				break;
			case KeyCode.UpArrow:
				set_value(mValue + num);
				break;
			}
		}
	}

	protected void ENBPINMLHJL(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK)
	{
		if (UICamera.currentScheme != (UICamera.DOCFHOGBBJH)7)
		{
			OJNOBHMOJEG = UICamera.currentCamera;
			ICKFKDNHDOG(CKJOGGHGBKF + BKAJGDOCDEN(UICamera.lastTouchPosition));
		}
	}
}
