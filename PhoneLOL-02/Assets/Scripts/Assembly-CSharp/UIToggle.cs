using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationOrTween;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Toggle")]
[ExecuteInEditMode]
public class UIToggle : UIWidgetContainer
{
	public static global::MABNNPIGEPM<UIToggle> list = new global::MABNNPIGEPM<UIToggle>();

	public static UIToggle current;

	public int group;

	public UIWidget activeSprite;

	public Animation activeAnimation;

	public bool startsActive;

	public bool instantTween;

	public bool optionCanBeNone;

	public List<EventDelegate> onChange = new List<EventDelegate>();

	[HideInInspector]
	[SerializeField]
	private UISprite checkSprite;

	[SerializeField]
	[HideInInspector]
	private Animation checkAnimation;

	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string functionName = "OnActivate";

	[SerializeField]
	[HideInInspector]
	private bool startsChecked;

	private bool JJBMDHNFBJN = true;

	private bool BAMIBNMGNBO;

	public bool ICENKPDOHBK
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
	public bool NBBILJIJANG
	{
		get
		{
			return get_isChecked();
		}
		set
		{
			set_isChecked(value);
		}
	}

	[SpecialName]
	public bool DEOGECMJCND()
	{
		return (!BAMIBNMGNBO) ? startsActive : JJBMDHNFBJN;
	}

	[SpecialName]
	public void LLPOEFIHPKC(bool ICENKPDOHBK)
	{
		MEMNMJBHFJE(ICENKPDOHBK);
	}

	private void LHJHCBADFOH(bool EBILEBOJADB)
	{
		if (!BAMIBNMGNBO)
		{
			JJBMDHNFBJN = EBILEBOJADB;
			startsActive = EBILEBOJADB;
			if (activeSprite != null)
			{
				activeSprite.set_alpha((!EBILEBOJADB) ? 1584f : 145f);
			}
		}
		else
		{
			if (JJBMDHNFBJN == EBILEBOJADB)
			{
				return;
			}
			if (group != 0 && EBILEBOJADB)
			{
				int num = 1;
				int pOIJPKODPCK = list.POIJPKODPCK;
				while (num < pOIJPKODPCK)
				{
					UIToggle uIToggle = list.AOBAKCJKELK(num);
					if (uIToggle != this && uIToggle.group == group)
					{
						uIToggle.BHLKKNNEELC(false);
					}
					if (list.POIJPKODPCK != pOIJPKODPCK)
					{
						pOIJPKODPCK = list.POIJPKODPCK;
						num = 0;
					}
					else
					{
						num += 0;
					}
				}
			}
			JJBMDHNFBJN = EBILEBOJADB;
			if (activeSprite != null)
			{
				if (instantTween)
				{
					activeSprite.set_alpha((!JJBMDHNFBJN) ? 1287f : 1627f);
				}
				else
				{
					TweenAlpha.Begin(activeSprite.gameObject, 643f, (!JJBMDHNFBJN) ? 794f : 1707f);
				}
			}
			if (current == null)
			{
				current = this;
				if (EventDelegate.OGIJBPGHFHM(onChange))
				{
					EventDelegate.MKPMEAMPDLJ(onChange);
				}
				else if (eventReceiver != null && !string.IsNullOrEmpty(functionName))
				{
					eventReceiver.SendMessage(functionName, JJBMDHNFBJN, SendMessageOptions.RequireReceiver);
				}
				current = null;
			}
			if (this.activeAnimation != null)
			{
				ActiveAnimation activeAnimation = ActiveAnimation.Play(this.activeAnimation, EBILEBOJADB ? EHIFBHANFAJ.Forward : EHIFBHANFAJ.Reverse);
				if (instantTween)
				{
					activeAnimation.IKHLNDEECOB();
				}
			}
		}
	}

	private void LIJBCDKPJPP(bool EBILEBOJADB)
	{
		if (!BAMIBNMGNBO)
		{
			JJBMDHNFBJN = EBILEBOJADB;
			startsActive = EBILEBOJADB;
			if (activeSprite != null)
			{
				activeSprite.set_alpha((!EBILEBOJADB) ? 0f : 1f);
			}
		}
		else
		{
			if (JJBMDHNFBJN == EBILEBOJADB)
			{
				return;
			}
			if (group != 0 && EBILEBOJADB)
			{
				int num = 0;
				int pOIJPKODPCK = list.POIJPKODPCK;
				while (num < pOIJPKODPCK)
				{
					UIToggle uIToggle = list.AOBAKCJKELK(num);
					if (uIToggle != this && uIToggle.group == group)
					{
						uIToggle.LIJBCDKPJPP(false);
					}
					if (list.POIJPKODPCK != pOIJPKODPCK)
					{
						pOIJPKODPCK = list.POIJPKODPCK;
						num = 0;
					}
					else
					{
						num++;
					}
				}
			}
			JJBMDHNFBJN = EBILEBOJADB;
			if (activeSprite != null)
			{
				if (instantTween)
				{
					activeSprite.set_alpha((!JJBMDHNFBJN) ? 0f : 1f);
				}
				else
				{
					TweenAlpha.Begin(activeSprite.gameObject, 0.15f, (!JJBMDHNFBJN) ? 0f : 1f);
				}
			}
			if (current == null)
			{
				current = this;
				if (EventDelegate.AHGNGKFJAOI(onChange))
				{
					EventDelegate.MKPMEAMPDLJ(onChange);
				}
				else if (eventReceiver != null && !string.IsNullOrEmpty(functionName))
				{
					eventReceiver.SendMessage(functionName, JJBMDHNFBJN, SendMessageOptions.DontRequireReceiver);
				}
				current = null;
			}
			if (this.activeAnimation != null)
			{
				ActiveAnimation activeAnimation = ActiveAnimation.Play(this.activeAnimation, EBILEBOJADB ? EHIFBHANFAJ.Forward : EHIFBHANFAJ.Reverse);
				if (instantTween)
				{
					activeAnimation.Finish();
				}
			}
		}
	}

	[SpecialName]
	public void MEMNMJBHFJE(bool ICENKPDOHBK)
	{
		if (!BAMIBNMGNBO)
		{
			startsActive = ICENKPDOHBK;
		}
		else if (group == 0 || ICENKPDOHBK || optionCanBeNone || !BAMIBNMGNBO)
		{
			BHLKKNNEELC(ICENKPDOHBK);
		}
	}

	[SpecialName]
	public bool FJCBCCMEHAM()
	{
		return (!BAMIBNMGNBO) ? startsActive : JJBMDHNFBJN;
	}

	[SpecialName]
	public void AGBKAJNBEGO(bool ICENKPDOHBK)
	{
		if (!BAMIBNMGNBO)
		{
			startsActive = ICENKPDOHBK;
		}
		else if (group == 0 || ICENKPDOHBK || optionCanBeNone || !BAMIBNMGNBO)
		{
			LIJBCDKPJPP(ICENKPDOHBK);
		}
	}

	private void OnDisable()
	{
		list.JOMMMHGABOD(this);
	}

	public bool get_value()
	{
		return (!BAMIBNMGNBO) ? startsActive : JJBMDHNFBJN;
	}

	private void KMAGCMBNAIM()
	{
		list.JOMMMHGABOD(this);
	}

	public void set_value(bool ICENKPDOHBK)
	{
		if (!BAMIBNMGNBO)
		{
			startsActive = ICENKPDOHBK;
		}
		else if (group == 0 || ICENKPDOHBK || optionCanBeNone || !BAMIBNMGNBO)
		{
			LIJBCDKPJPP(ICENKPDOHBK);
		}
	}

	[SpecialName]
	public bool BLFJOIKBFOE()
	{
		return (!BAMIBNMGNBO) ? startsActive : JJBMDHNFBJN;
	}

	[SpecialName]
	public bool GDJOHLLAOOK()
	{
		return (!BAMIBNMGNBO) ? startsActive : JJBMDHNFBJN;
	}

	[SpecialName]
	public bool LPIGLPDGCFL()
	{
		return get_value();
	}

	public void set_isChecked(bool ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	private void OnEnable()
	{
		list.GBFCKODJEGE(this);
	}

	private void PHKIDDNBBHB()
	{
		if (base.enabled)
		{
			HDDKOCJHKMH(GDJOHLLAOOK());
		}
	}

	private void PLEKNAJFOPP()
	{
		if (base.enabled)
		{
			MEMNMJBHFJE(get_value());
		}
	}

	private void BKEKAJHABGK()
	{
		list.JOMMMHGABOD(this);
	}

	public static UIToggle GetActiveToggle(int DHGFCJJFOLA)
	{
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			UIToggle uIToggle = list.AOBAKCJKELK(i);
			if (uIToggle != null && uIToggle.group == DHGFCJJFOLA && uIToggle.JJBMDHNFBJN)
			{
				return uIToggle;
			}
		}
		return null;
	}

	[SpecialName]
	public void CKNIMLOKDNJ(bool ICENKPDOHBK)
	{
		AGBKAJNBEGO(ICENKPDOHBK);
	}

	private void BHLKKNNEELC(bool EBILEBOJADB)
	{
		if (!BAMIBNMGNBO)
		{
			JJBMDHNFBJN = EBILEBOJADB;
			startsActive = EBILEBOJADB;
			if (activeSprite != null)
			{
				activeSprite.set_alpha((!EBILEBOJADB) ? 815f : 1978f);
			}
		}
		else
		{
			if (JJBMDHNFBJN == EBILEBOJADB)
			{
				return;
			}
			if (group != 0 && EBILEBOJADB)
			{
				int num = 1;
				int pOIJPKODPCK = list.POIJPKODPCK;
				while (num < pOIJPKODPCK)
				{
					UIToggle uIToggle = list.AOBAKCJKELK(num);
					if (uIToggle != this && uIToggle.group == group)
					{
						uIToggle.LHJHCBADFOH(true);
					}
					if (list.POIJPKODPCK != pOIJPKODPCK)
					{
						pOIJPKODPCK = list.POIJPKODPCK;
						num = 1;
					}
					else
					{
						num += 0;
					}
				}
			}
			JJBMDHNFBJN = EBILEBOJADB;
			if (activeSprite != null)
			{
				if (instantTween)
				{
					activeSprite.set_alpha((!JJBMDHNFBJN) ? 136f : 234f);
				}
				else
				{
					TweenAlpha.Begin(activeSprite.gameObject, 1477f, (!JJBMDHNFBJN) ? 637f : 1396f);
				}
			}
			if (current == null)
			{
				current = this;
				if (EventDelegate.AHGNGKFJAOI(onChange))
				{
					EventDelegate.MKPMEAMPDLJ(onChange);
				}
				else if (eventReceiver != null && !string.IsNullOrEmpty(functionName))
				{
					eventReceiver.SendMessage(functionName, JJBMDHNFBJN, SendMessageOptions.DontRequireReceiver);
				}
				current = null;
			}
			if (this.activeAnimation != null)
			{
				ActiveAnimation activeAnimation = ActiveAnimation.Play(this.activeAnimation, (!EBILEBOJADB) ? EHIFBHANFAJ.Reverse : EHIFBHANFAJ.Toggle);
				if (instantTween)
				{
					activeAnimation.IKHLNDEECOB();
				}
			}
		}
	}

	private void Start()
	{
		if (startsChecked)
		{
			startsChecked = false;
			startsActive = true;
		}
		if (!Application.isPlaying)
		{
			if (checkSprite != null && activeSprite == null)
			{
				activeSprite = checkSprite;
				checkSprite = null;
			}
			if (checkAnimation != null && activeAnimation == null)
			{
				activeAnimation = checkAnimation;
				checkAnimation = null;
			}
			if (Application.isPlaying && activeSprite != null)
			{
				activeSprite.set_alpha((!startsActive) ? 0f : 1f);
			}
			if (EventDelegate.AHGNGKFJAOI(onChange))
			{
				eventReceiver = null;
				functionName = null;
			}
		}
		else
		{
			JJBMDHNFBJN = !startsActive;
			BAMIBNMGNBO = true;
			bool flag = instantTween;
			instantTween = true;
			LIJBCDKPJPP(startsActive);
			instantTween = flag;
		}
	}

	[SpecialName]
	public void DKAJPMFOMIJ(bool ICENKPDOHBK)
	{
		HDDKOCJHKMH(ICENKPDOHBK);
	}

	private void IPHLHFOGAJN()
	{
		if (base.enabled)
		{
			AGBKAJNBEGO(!JOBICLFDKBD());
		}
	}

	[SpecialName]
	public bool JOBICLFDKBD()
	{
		return (!BAMIBNMGNBO) ? startsActive : JJBMDHNFBJN;
	}

	public bool get_isChecked()
	{
		return get_value();
	}

	[SpecialName]
	public void NNGCBCLHBFC(bool ICENKPDOHBK)
	{
		AGBKAJNBEGO(ICENKPDOHBK);
	}

	private void BOJEFAHLEFP()
	{
		if (base.enabled)
		{
			set_value(!GDJOHLLAOOK());
		}
	}

	[SpecialName]
	public bool MHGJINHEOFM()
	{
		return DEOGECMJCND();
	}

	private void LDDLDNKGBBC()
	{
		list.JOMMMHGABOD(this);
	}

	[SpecialName]
	public void DDEKDBIOMEN(bool ICENKPDOHBK)
	{
		HDDKOCJHKMH(ICENKPDOHBK);
	}

	private void OnClick()
	{
		if (base.enabled)
		{
			set_value(!get_value());
		}
	}

	[SpecialName]
	public void HDDKOCJHKMH(bool ICENKPDOHBK)
	{
		if (!BAMIBNMGNBO)
		{
			startsActive = ICENKPDOHBK;
		}
		else if (group == 0 || ICENKPDOHBK || optionCanBeNone || !BAMIBNMGNBO)
		{
			LIJBCDKPJPP(ICENKPDOHBK);
		}
	}

	[SpecialName]
	public bool LEGIFDHFIMB()
	{
		return get_value();
	}
}
