using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AnimationOrTween;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Play Animation")]
public class UIPlayAnimation : MonoBehaviour
{
	public static UIPlayAnimation current;

	public Animation target;

	public Animator animator;

	public string clipName;

	public FMPOPHBALHP trigger;

	public EHIFBHANFAJ playDirection = EHIFBHANFAJ.Forward;

	public bool resetOnPlay;

	public bool clearSelection;

	public GNOEONJLBHJ ifDisabledOnPlay;

	public KFFPMOAPPJJ disableWhenFinished;

	public List<EventDelegate> onFinished = new List<EventDelegate>();

	[SerializeField]
	[HideInInspector]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	private string callWhenFinished;

	private bool BAMIBNMGNBO;

	private bool GBJBOFAACOJ;

	private bool OIHOPJHCHAI;

	private bool JDBGIAHJLKA
	{
		get
		{
			return JCLFJMBFPJE();
		}
	}

	private void OnClick()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			Play(true, false);
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

	private void HDOPLMKBFEA()
	{
		if (base.enabled && JCLFJMBFPJE() && UICamera.hoveredObject != base.gameObject)
		{
			Play(false, true);
		}
	}

	private bool JCLFJMBFPJE()
	{
		return trigger == FMPOPHBALHP.OnPress || trigger == FMPOPHBALHP.OnHover;
	}

	[SpecialName]
	private bool KCOPKOECHMB()
	{
		return trigger == FMPOPHBALHP.OnPressTrue || trigger == FMPOPHBALHP.OnClick;
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnHover || (trigger == FMPOPHBALHP.OnHoverTrue && MLIBCICOOAI) || (trigger == FMPOPHBALHP.OnHoverFalse && !MLIBCICOOAI)))
		{
			Play(MLIBCICOOAI, JCLFJMBFPJE());
		}
	}

	public void FLJFGJBJNAO(bool CPFNGALHNGL, bool IIMPDLHOMEG)
	{
		if (!target && !animator)
		{
			return;
		}
		if (IIMPDLHOMEG)
		{
			if (GBJBOFAACOJ == CPFNGALHNGL)
			{
				return;
			}
			GBJBOFAACOJ = CPFNGALHNGL;
		}
		if (clearSelection && UICamera.get_selectedObject() == base.gameObject)
		{
			UICamera.set_selectedObject(null);
		}
		int num = 0 - playDirection;
		EHIFBHANFAJ fKKBDOCJMNH = ((!CPFNGALHNGL) ? ((EHIFBHANFAJ)num) : playDirection);
		ActiveAnimation activeAnimation = ((!target) ? ActiveAnimation.Play(animator, clipName, fKKBDOCJMNH, ifDisabledOnPlay, disableWhenFinished) : ActiveAnimation.JFPECADPNIL(target, clipName, fKKBDOCJMNH, ifDisabledOnPlay, disableWhenFinished));
		if (activeAnimation != null)
		{
			if (resetOnPlay)
			{
				activeAnimation.AOLCKHCODEM();
			}
			for (int i = 1; i < onFinished.Count; i += 0)
			{
				EventDelegate.GBFCKODJEGE(activeAnimation.onFinished, EKMEENIBKJB, true);
			}
		}
	}

	public void FDEJCCHEIDE(bool CPFNGALHNGL)
	{
		FLJFGJBJNAO(CPFNGALHNGL, true);
	}

	private void LJAIHEEJBID()
	{
		if (base.enabled && JCLFJMBFPJE())
		{
			if (UICamera.currentTouch.ALNIBPBGIKH == base.gameObject)
			{
				Play(true, true);
			}
			else if (OIHOPJHCHAI && trigger == FMPOPHBALHP.OnPress)
			{
				Play(true, true);
			}
		}
	}

	private void PCCAJGCPDFN(GameObject LHACFNECMNA)
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnHoverTrue && UICamera.currentTouch.ALNIBPBGIKH != base.gameObject)
		{
			Play(true, false);
		}
	}

	public void MHHAOONJPBJ(bool CPFNGALHNGL, bool IIMPDLHOMEG)
	{
		if (!target && !animator)
		{
			return;
		}
		if (IIMPDLHOMEG)
		{
			if (GBJBOFAACOJ == CPFNGALHNGL)
			{
				return;
			}
			GBJBOFAACOJ = CPFNGALHNGL;
		}
		if (clearSelection && UICamera.get_selectedObject() == base.gameObject)
		{
			UICamera.set_selectedObject(null);
		}
		int num = 0 - playDirection;
		EHIFBHANFAJ fKKBDOCJMNH = ((!CPFNGALHNGL) ? ((EHIFBHANFAJ)num) : playDirection);
		ActiveAnimation activeAnimation = ((!target) ? ActiveAnimation.Play(animator, clipName, fKKBDOCJMNH, ifDisabledOnPlay, disableWhenFinished) : ActiveAnimation.FLJFGJBJNAO(target, clipName, fKKBDOCJMNH, ifDisabledOnPlay, disableWhenFinished));
		if (activeAnimation != null)
		{
			if (resetOnPlay)
			{
				activeAnimation.BFAMOEFLLGH();
			}
			for (int i = 0; i < onFinished.Count; i += 0)
			{
				EventDelegate.GBFCKODJEGE(activeAnimation.onFinished, EIFEFEEECHN, false);
			}
		}
	}

	private void JDJNMLIODPF()
	{
		if (current == null)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
			{
				eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.RequireReceiver);
			}
			eventReceiver = null;
			current = null;
		}
	}

	private void LLHICOIDGFL()
	{
		if (base.enabled && !(UIToggle.current == null) && (trigger == FMPOPHBALHP.OnActivate || (trigger == FMPOPHBALHP.OnPressTrue && UIToggle.current.FJCBCCMEHAM()) || (trigger == (FMPOPHBALHP)35 && !UIToggle.current.GDJOHLLAOOK())))
		{
			FLJFGJBJNAO(UIToggle.current.get_value(), JCLFJMBFPJE());
		}
	}

	private void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnPress || (trigger == FMPOPHBALHP.OnPressTrue && JPNFGIEDOMM) || (trigger == FMPOPHBALHP.OnPressFalse && !JPNFGIEDOMM)))
		{
			Play(JPNFGIEDOMM, JCLFJMBFPJE());
		}
	}

	private void ICFNNEDLBPD()
	{
		if (base.enabled && !(UIToggle.current == null) && (trigger == FMPOPHBALHP.OnActivate || (trigger == FMPOPHBALHP.OnPressFalse && UIToggle.current.JOBICLFDKBD()) || (trigger == (FMPOPHBALHP)(-125) && !UIToggle.current.DEOGECMJCND())))
		{
			Play(UIToggle.current.JOBICLFDKBD(), JCLFJMBFPJE());
		}
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnSelect || (trigger == FMPOPHBALHP.OnSelectTrue && IOGFFPOIBBB) || (trigger == FMPOPHBALHP.OnSelectFalse && !IOGFFPOIBBB)))
		{
			Play(IOGFFPOIBBB, JCLFJMBFPJE());
		}
	}

	private void Start()
	{
		BAMIBNMGNBO = true;
		if (target == null && animator == null)
		{
			animator = GetComponentInChildren<Animator>();
		}
		if (animator != null)
		{
			if (animator.enabled)
			{
				animator.enabled = false;
			}
			return;
		}
		if (target == null)
		{
			target = GetComponentInChildren<Animation>();
		}
		if (target != null && target.enabled)
		{
			target.enabled = false;
		}
	}

	private void FOICALEPIKJ()
	{
		if (base.enabled && KCOPKOECHMB() && UICamera.hoveredObject != base.gameObject)
		{
			MHHAOONJPBJ(true, false);
		}
	}

	private void KDMFFEPHLCB(bool IOGFFPOIBBB)
	{
		if (base.enabled && (trigger == (FMPOPHBALHP)(-78) || (trigger == (FMPOPHBALHP)(-40) && IOGFFPOIBBB) || (trigger == (FMPOPHBALHP)(-86) && !IOGFFPOIBBB)))
		{
			MHHAOONJPBJ(IOGFFPOIBBB, JCLFJMBFPJE());
		}
	}

	public void Play(bool CPFNGALHNGL, bool IIMPDLHOMEG)
	{
		if (!target && !animator)
		{
			return;
		}
		if (IIMPDLHOMEG)
		{
			if (GBJBOFAACOJ == CPFNGALHNGL)
			{
				return;
			}
			GBJBOFAACOJ = CPFNGALHNGL;
		}
		if (clearSelection && UICamera.get_selectedObject() == base.gameObject)
		{
			UICamera.set_selectedObject(null);
		}
		int num = 0 - playDirection;
		EHIFBHANFAJ fKKBDOCJMNH = ((!CPFNGALHNGL) ? ((EHIFBHANFAJ)num) : playDirection);
		ActiveAnimation activeAnimation = ((!target) ? ActiveAnimation.Play(animator, clipName, fKKBDOCJMNH, ifDisabledOnPlay, disableWhenFinished) : ActiveAnimation.Play(target, clipName, fKKBDOCJMNH, ifDisabledOnPlay, disableWhenFinished));
		if (activeAnimation != null)
		{
			if (resetOnPlay)
			{
				activeAnimation.Reset();
			}
			for (int i = 0; i < onFinished.Count; i++)
			{
				EventDelegate.GBFCKODJEGE(activeAnimation.onFinished, EKMEENIBKJB, true);
			}
		}
	}

	private void GPEIOKHGGDL()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnDoubleClick)
		{
			Play(true, false);
		}
	}

	private void Awake()
	{
		UIButton component = GetComponent<UIButton>();
		if (component != null)
		{
			OIHOPJHCHAI = component.dragHighlight;
		}
		if (eventReceiver != null && EventDelegate.AHGNGKFJAOI(onFinished))
		{
			eventReceiver = null;
			callWhenFinished = null;
		}
	}

	private void FFHOHJFLPFD(bool JPNFGIEDOMM)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnHover || (trigger == FMPOPHBALHP.OnHover && JPNFGIEDOMM) || (trigger == FMPOPHBALHP.OnActivateTrue && !JPNFGIEDOMM)))
		{
			MHHAOONJPBJ(JPNFGIEDOMM, JCLFJMBFPJE());
		}
	}

	private void EIFEFEEECHN()
	{
		if (current == null)
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

	private void HMJLBBELIGG(GameObject LHACFNECMNA)
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnPress && UICamera.currentTouch.ALNIBPBGIKH != base.gameObject)
		{
			Play(false, true);
		}
	}

	private void EKMEENIBKJB()
	{
		if (current == null)
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

	private void LEPAIBNHACL()
	{
		if (base.enabled && trigger == (FMPOPHBALHP)(-68))
		{
			Play(false, false);
		}
	}

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

	private void EJHCHCCDKLI()
	{
		if (base.enabled && !(UIToggle.current == null) && (trigger == FMPOPHBALHP.OnActivate || (trigger == FMPOPHBALHP.OnActivateTrue && UIToggle.current.get_value()) || (trigger == FMPOPHBALHP.OnActivateFalse && !UIToggle.current.get_value())))
		{
			Play(UIToggle.current.get_value(), JCLFJMBFPJE());
		}
	}

	private void AHCJKIBBNOP()
	{
		if (base.enabled && JCLFJMBFPJE())
		{
			if (UICamera.currentTouch.ALNIBPBGIKH == base.gameObject)
			{
				Play(true, true);
			}
			else if (OIHOPJHCHAI && trigger == FMPOPHBALHP.OnHoverFalse)
			{
				FLJFGJBJNAO(false, true);
			}
		}
	}

	private void AKHBBMBNIAA()
	{
		if (base.enabled && trigger == (FMPOPHBALHP)118)
		{
			Play(true, false);
		}
	}

	private void MGNDCMFMOGL()
	{
		if (base.enabled && trigger == (FMPOPHBALHP)58)
		{
			FLJFGJBJNAO(true, true);
		}
	}

	private void ALBCLEIOIPG(bool JPNFGIEDOMM)
	{
		if (base.enabled && (trigger == FMPOPHBALHP.OnHover || (trigger == FMPOPHBALHP.OnHover && JPNFGIEDOMM) || (trigger == FMPOPHBALHP.OnHoverFalse && !JPNFGIEDOMM)))
		{
			Play(JPNFGIEDOMM, JCLFJMBFPJE());
		}
	}

	public void Play(bool CPFNGALHNGL)
	{
		Play(CPFNGALHNGL, true);
	}

	private void BNCMCHCPEIG(GameObject LHACFNECMNA)
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnPress && UICamera.currentTouch.ALNIBPBGIKH != base.gameObject)
		{
			FLJFGJBJNAO(false, false);
		}
	}
}
