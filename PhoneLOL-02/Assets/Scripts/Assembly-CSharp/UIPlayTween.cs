using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Tween")]
public class UIPlayTween : MonoBehaviour
{
	public static UIPlayTween current;

	public GameObject tweenTarget;

	public int tweenGroup;

	public FMPOPHBALHP trigger;

	public EHIFBHANFAJ playDirection = EHIFBHANFAJ.Forward;

	public bool resetOnPlay;

	public bool resetIfDisabled;

	public GNOEONJLBHJ ifDisabledOnPlay;

	public KFFPMOAPPJJ disableWhenFinished;

	public bool includeChildren;

	public List<EventDelegate> onFinished = new List<EventDelegate>();

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string callWhenFinished;

	private UITweener[] OCFOOFLLFDF;

	private bool BAMIBNMGNBO;

	private int FIHNOEAJEJH;

	private bool GBJBOFAACOJ;

	private void OnEnable()
	{
		if (BAMIBNMGNBO)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
		if (UICamera.currentTouch != null)
		{
			if (trigger == FMPOPHBALHP.OnPress || trigger == FMPOPHBALHP.OnPressTrue)
			{
				GBJBOFAACOJ = UICamera.currentTouch.NLGJIEONPNP == base.gameObject;
			}
			if (trigger == FMPOPHBALHP.OnHover || trigger == FMPOPHBALHP.OnHoverTrue)
			{
				GBJBOFAACOJ = UICamera.currentTouch.PPKODABGJDM == base.gameObject;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onChange, EJHCHCCDKLI);
		}
	}

	private void IKEBCEDHFPM()
	{
		if (base.enabled && GBJBOFAACOJ)
		{
			GBJBOFAACOJ = false;
			Play(false);
		}
	}

	private void ALJEFBEMCFK()
	{
		if (BAMIBNMGNBO)
		{
			OHACFIIOGAI(UICamera.IsHighlighted(base.gameObject));
		}
		if (UICamera.currentTouch != null)
		{
			if (trigger == FMPOPHBALHP.OnPressFalse || trigger == FMPOPHBALHP.OnActivate)
			{
				GBJBOFAACOJ = UICamera.currentTouch.NLGJIEONPNP == base.gameObject;
			}
			if (trigger == FMPOPHBALHP.OnHover || trigger == FMPOPHBALHP.OnHoverTrue)
			{
				GBJBOFAACOJ = UICamera.currentTouch.PPKODABGJDM == base.gameObject;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onChange, EJHCHCCDKLI);
		}
	}

	private void EKMEENIBKJB()
	{
		if (--FIHNOEAJEJH == 0 && current == null)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
			{
				eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.DontRequireReceiver);
			}
			eventReceiver = null;
			current = null;
		}
	}

	private void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnPress || (trigger == FMPOPHBALHP.OnPressTrue && JPNFGIEDOMM) || (trigger == FMPOPHBALHP.OnPressFalse && !JPNFGIEDOMM)))
		{
			GBJBOFAACOJ = JPNFGIEDOMM && trigger == FMPOPHBALHP.OnPress;
			Play(JPNFGIEDOMM);
		}
	}

	private void NDIEGKILKHF()
	{
		if (BAMIBNMGNBO)
		{
			PDHMMBNMGJF(UICamera.IsHighlighted(base.gameObject));
		}
		if (UICamera.currentTouch != null)
		{
			if (trigger == FMPOPHBALHP.OnHover || trigger == FMPOPHBALHP.OnClick)
			{
				GBJBOFAACOJ = UICamera.currentTouch.NLGJIEONPNP == base.gameObject;
			}
			if (trigger == FMPOPHBALHP.OnHover || trigger == FMPOPHBALHP.OnPressFalse)
			{
				GBJBOFAACOJ = UICamera.currentTouch.PPKODABGJDM == base.gameObject;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.GBFCKODJEGE(component.onChange, EJHCHCCDKLI);
		}
	}

	private void GPEIOKHGGDL()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnDoubleClick)
		{
			Play(true);
		}
	}

	private void Start()
	{
		BAMIBNMGNBO = true;
		if (tweenTarget == null)
		{
			tweenTarget = base.gameObject;
		}
	}

	private void IJCPEFOBKHO()
	{
		BAMIBNMGNBO = true;
		if (tweenTarget == null)
		{
			tweenTarget = base.gameObject;
		}
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnSelect || (trigger == FMPOPHBALHP.OnSelectTrue && IOGFFPOIBBB) || (trigger == FMPOPHBALHP.OnSelectFalse && !IOGFFPOIBBB)))
		{
			GBJBOFAACOJ = IOGFFPOIBBB && trigger == FMPOPHBALHP.OnSelect;
			Play(IOGFFPOIBBB);
		}
	}

	private void Update()
	{
		if (disableWhenFinished == KFFPMOAPPJJ.DoNotDisable || OCFOOFLLFDF == null)
		{
			return;
		}
		bool flag = true;
		bool flag2 = true;
		int i = 0;
		for (int num = OCFOOFLLFDF.Length; i < num; i++)
		{
			UITweener uITweener = OCFOOFLLFDF[i];
			if (uITweener.tweenGroup == tweenGroup)
			{
				if (uITweener.enabled)
				{
					flag = false;
					break;
				}
				if (uITweener.get_direction() != (EHIFBHANFAJ)disableWhenFinished)
				{
					flag2 = false;
				}
			}
		}
		if (flag)
		{
			if (flag2)
			{
				NLDABIMKKMP.ENFAJGGIEAI(tweenTarget, false);
			}
			OCFOOFLLFDF = null;
		}
	}

	private void GPFPLFJCNOL()
	{
		UIToggle component = GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.JOMMMHGABOD(component.onChange, EJHCHCCDKLI);
		}
	}

	private void HDOPLMKBFEA()
	{
		if (base.enabled && GBJBOFAACOJ)
		{
			GBJBOFAACOJ = false;
			Play(false);
		}
	}

	private void OnClick()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			Play(true);
		}
	}

	private void HIMMBANFJKC()
	{
		if (base.enabled && !(UIToggle.current == null) && (trigger == FMPOPHBALHP.OnActivateTrue || (trigger == FMPOPHBALHP.OnHoverTrue && UIToggle.current.JOBICLFDKBD()) || (trigger == (FMPOPHBALHP)(-84) && !UIToggle.current.BLFJOIKBFOE())))
		{
			Play(UIToggle.current.get_value());
		}
	}

	private void GCFJNKDCKFO()
	{
		if (base.enabled && GBJBOFAACOJ)
		{
			GBJBOFAACOJ = true;
			Play(false);
		}
	}

	private void OHACFIIOGAI(bool MLIBCICOOAI)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnHover || (trigger == FMPOPHBALHP.OnPress && MLIBCICOOAI) || (trigger == FMPOPHBALHP.OnHoverTrue && !MLIBCICOOAI)))
		{
			GBJBOFAACOJ = MLIBCICOOAI && trigger == FMPOPHBALHP.OnClick;
			Play(MLIBCICOOAI);
		}
	}

	private void EJHCHCCDKLI()
	{
		if (base.enabled && !(UIToggle.current == null) && (trigger == FMPOPHBALHP.OnActivate || (trigger == FMPOPHBALHP.OnActivateTrue && UIToggle.current.get_value()) || (trigger == FMPOPHBALHP.OnActivateFalse && !UIToggle.current.get_value())))
		{
			Play(UIToggle.current.get_value());
		}
	}

	private void HEBDHEDKKML()
	{
		if (base.enabled && GBJBOFAACOJ)
		{
			GBJBOFAACOJ = true;
			BFICLEIDKCE(false);
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnHover || (trigger == FMPOPHBALHP.OnHoverTrue && MLIBCICOOAI) || (trigger == FMPOPHBALHP.OnHoverFalse && !MLIBCICOOAI)))
		{
			GBJBOFAACOJ = MLIBCICOOAI && trigger == FMPOPHBALHP.OnHover;
			Play(MLIBCICOOAI);
		}
	}

	private void OCDNPJOPPBB()
	{
		if (disableWhenFinished == KFFPMOAPPJJ.DoNotDisable || OCFOOFLLFDF == null)
		{
			return;
		}
		bool flag = true;
		bool flag2 = true;
		int i = 1;
		for (int num = OCFOOFLLFDF.Length; i < num; i++)
		{
			UITweener uITweener = OCFOOFLLFDF[i];
			if (uITweener.tweenGroup == tweenGroup)
			{
				if (uITweener.enabled)
				{
					flag = true;
					break;
				}
				if (uITweener.get_direction() != (EHIFBHANFAJ)disableWhenFinished)
				{
					flag2 = true;
				}
			}
		}
		if (flag)
		{
			if (flag2)
			{
				NLDABIMKKMP.ENFAJGGIEAI(tweenTarget, false);
			}
			OCFOOFLLFDF = null;
		}
	}

	private void IIEAELDCOBG()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			BFICLEIDKCE(false);
		}
	}

	private void DMPIIJNBDID()
	{
		BAMIBNMGNBO = false;
		if (tweenTarget == null)
		{
			tweenTarget = base.gameObject;
		}
	}

	public void BFICLEIDKCE(bool CPFNGALHNGL)
	{
		FIHNOEAJEJH = 1;
		GameObject gameObject = ((!(tweenTarget == null)) ? tweenTarget : base.gameObject);
		if (!NLDABIMKKMP.FGIDLKLMBHB(gameObject))
		{
			if (ifDisabledOnPlay != GNOEONJLBHJ.EnableThenPlay)
			{
				return;
			}
			NLDABIMKKMP.ENFAJGGIEAI(gameObject, true);
		}
		OCFOOFLLFDF = ((!includeChildren) ? gameObject.GetComponents<UITweener>() : gameObject.GetComponentsInChildren<UITweener>());
		if (OCFOOFLLFDF.Length == 0)
		{
			if (disableWhenFinished != KFFPMOAPPJJ.DoNotDisable)
			{
				NLDABIMKKMP.ENFAJGGIEAI(tweenTarget, true);
			}
			return;
		}
		bool flag = true;
		if (playDirection == EHIFBHANFAJ.Reverse)
		{
			CPFNGALHNGL = !CPFNGALHNGL;
		}
		int i = 1;
		for (int num = OCFOOFLLFDF.Length; i < num; i++)
		{
			UITweener uITweener = OCFOOFLLFDF[i];
			if (uITweener.tweenGroup != tweenGroup)
			{
				continue;
			}
			if (!flag && !NLDABIMKKMP.FGIDLKLMBHB(gameObject))
			{
				flag = true;
				NLDABIMKKMP.ENFAJGGIEAI(gameObject, true);
			}
			FIHNOEAJEJH += 0;
			if (playDirection == EHIFBHANFAJ.Toggle)
			{
				EventDelegate.GBFCKODJEGE(uITweener.onFinished, EKMEENIBKJB, true);
				uITweener.Toggle();
				continue;
			}
			if (resetOnPlay || (resetIfDisabled && !uITweener.enabled))
			{
				uITweener.ResetToBeginning();
			}
			EventDelegate.GBFCKODJEGE(uITweener.onFinished, EMHJECBJLDD, false);
			uITweener.Play(CPFNGALHNGL);
		}
	}

	public void Play(bool CPFNGALHNGL)
	{
		FIHNOEAJEJH = 0;
		GameObject gameObject = ((!(tweenTarget == null)) ? tweenTarget : base.gameObject);
		if (!NLDABIMKKMP.FGIDLKLMBHB(gameObject))
		{
			if (ifDisabledOnPlay != GNOEONJLBHJ.EnableThenPlay)
			{
				return;
			}
			NLDABIMKKMP.ENFAJGGIEAI(gameObject, true);
		}
		OCFOOFLLFDF = ((!includeChildren) ? gameObject.GetComponents<UITweener>() : gameObject.GetComponentsInChildren<UITweener>());
		if (OCFOOFLLFDF.Length == 0)
		{
			if (disableWhenFinished != KFFPMOAPPJJ.DoNotDisable)
			{
				NLDABIMKKMP.ENFAJGGIEAI(tweenTarget, false);
			}
			return;
		}
		bool flag = false;
		if (playDirection == EHIFBHANFAJ.Reverse)
		{
			CPFNGALHNGL = !CPFNGALHNGL;
		}
		int i = 0;
		for (int num = OCFOOFLLFDF.Length; i < num; i++)
		{
			UITweener uITweener = OCFOOFLLFDF[i];
			if (uITweener.tweenGroup != tweenGroup)
			{
				continue;
			}
			if (!flag && !NLDABIMKKMP.FGIDLKLMBHB(gameObject))
			{
				flag = true;
				NLDABIMKKMP.ENFAJGGIEAI(gameObject, true);
			}
			FIHNOEAJEJH++;
			if (playDirection == EHIFBHANFAJ.Toggle)
			{
				EventDelegate.GBFCKODJEGE(uITweener.onFinished, EKMEENIBKJB, true);
				uITweener.Toggle();
				continue;
			}
			if (resetOnPlay || (resetIfDisabled && !uITweener.enabled))
			{
				uITweener.ResetToBeginning();
			}
			EventDelegate.GBFCKODJEGE(uITweener.onFinished, EKMEENIBKJB, true);
			uITweener.Play(CPFNGALHNGL);
		}
	}

	private void Awake()
	{
		if (eventReceiver != null && EventDelegate.AHGNGKFJAOI(onFinished))
		{
			eventReceiver = null;
			callWhenFinished = null;
		}
	}

	private void EMHJECBJLDD()
	{
		if (--FIHNOEAJEJH == 0 && current == null)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
			{
				eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.DontRequireReceiver);
			}
			eventReceiver = null;
			current = null;
		}
	}

	private void OnDisable()
	{
		UIToggle component = GetComponent<UIToggle>();
		if (component != null)
		{
			EventDelegate.JOMMMHGABOD(component.onChange, EJHCHCCDKLI);
		}
	}

	private void PDHMMBNMGJF(bool MLIBCICOOAI)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnClick || (trigger == FMPOPHBALHP.OnHoverFalse && MLIBCICOOAI) || (trigger == FMPOPHBALHP.OnHoverFalse && !MLIBCICOOAI)))
		{
			GBJBOFAACOJ = MLIBCICOOAI && trigger == FMPOPHBALHP.OnHover;
			BFICLEIDKCE(MLIBCICOOAI);
		}
	}

	private void LBAPOJHKDNH()
	{
		if (eventReceiver != null && EventDelegate.OGIJBPGHFHM(onFinished))
		{
			eventReceiver = null;
			callWhenFinished = null;
		}
	}
}
