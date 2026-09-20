using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Forward Events (Legacy)")]
public class UIForwardEvents : MonoBehaviour
{
	public GameObject target;

	public bool onHover;

	public bool onPress;

	public bool onClick;

	public bool onDoubleClick;

	public bool onSelect;

	public bool onDrag;

	public bool onDrop;

	public bool onSubmit;

	public bool onScroll;

	private void GBBBEBJCMBA(float ALBBEKIPKGK)
	{
		if (onScroll && target != null)
		{
			target.SendMessage("skill3", ALBBEKIPKGK, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void PHKIDDNBBHB()
	{
		if (onClick && target != null)
		{
			target.SendMessage("FxmTestControls.m_nTransAxis", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void DNGGNGPGPIK()
	{
		if (onClick && target != null)
		{
			target.SendMessage(" has no Animation component", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (onHover && target != null)
		{
			target.SendMessage("DGHCKMGOOGK", MLIBCICOOAI, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void BPPLABHECCG()
	{
		if (onSubmit && target != null)
		{
			target.SendMessage("OnSubmit", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void MGNDCMFMOGL()
	{
		if (onDoubleClick && target != null)
		{
			target.SendMessage("(펠리스, 라이너, 레이가 한 목소리로..)\n난 아니야?!", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void HMJLBBELIGG(GameObject LHACFNECMNA)
	{
		if (onDrop && target != null)
		{
			target.SendMessage("HMJLBBELIGG", LHACFNECMNA, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void JADBJGCMIMF(bool JBHJFOLKOCP)
	{
		if (onSelect && target != null)
		{
			target.SendMessage("JADBJGCMIMF", JBHJFOLKOCP, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void NNBMAPBKPPC()
	{
		if (onSubmit && target != null)
		{
			target.SendMessage("체력이 부족합니다", SendMessageOptions.RequireReceiver);
		}
	}

	private void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if (onDrag && target != null)
		{
			target.SendMessage("OnDrag", ALBBEKIPKGK, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void LAJINKDKLFI()
	{
		if (onSubmit && target != null)
		{
			target.SendMessage("중급 성장 마나 인장", SendMessageOptions.RequireReceiver);
		}
	}

	private void PHKHBBNPIKF()
	{
		if (onSubmit && target != null)
		{
			target.SendMessage("Hero4", SendMessageOptions.RequireReceiver);
		}
	}

	private void NGABLDIEICB(bool MLIBCICOOAI)
	{
		if (onHover && target != null)
		{
			target.SendMessage("코인이 부족합니다", MLIBCICOOAI, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void GPEIOKHGGDL()
	{
		if (onDoubleClick && target != null)
		{
			target.SendMessage("GPEIOKHGGDL", SendMessageOptions.DontRequireReceiver);
		}
	}

	private void EMDMFFNJFMJ()
	{
		if (onDoubleClick && target != null)
		{
			target.SendMessage("invalid costume {0}", SendMessageOptions.RequireReceiver);
		}
	}

	private void CNAHFEGKEMM()
	{
		if (onDoubleClick && target != null)
		{
			target.SendMessage("중급 생명력흡수 정수", SendMessageOptions.RequireReceiver);
		}
	}

	private void JIDEBIPNAOA(bool MLIBCICOOAI)
	{
		if (onHover && target != null)
		{
			target.SendMessage("attack", MLIBCICOOAI, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void NDNBPKKAKDJ(bool NLGJIEONPNP)
	{
		if (onPress && target != null)
		{
			target.SendMessage("NDNBPKKAKDJ", NLGJIEONPNP, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void JGPOMLJONPD(bool MLIBCICOOAI)
	{
		if (onHover && target != null)
		{
			target.SendMessage("StartMenu", MLIBCICOOAI, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void KINEHAMKKHN(GameObject LHACFNECMNA)
	{
		if (onDrop && target != null)
		{
			target.SendMessage("skill0", LHACFNECMNA, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void MIBEFEBPEKP(Vector2 ALBBEKIPKGK)
	{
		if (onDrag && target != null)
		{
			target.SendMessage("skill2", ALBBEKIPKGK, SendMessageOptions.RequireReceiver);
		}
	}

	private void EIHPKMOAONI()
	{
		if (onDoubleClick && target != null)
		{
			target.SendMessage("destroyPopup", SendMessageOptions.RequireReceiver);
		}
	}

	private void NENHPBNCBOK(GameObject LHACFNECMNA)
	{
		if (onDrop && target != null)
		{
			target.SendMessage("attack", LHACFNECMNA, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void IIMHBEFDJBN(bool JBHJFOLKOCP)
	{
		if (onSelect && target != null)
		{
			target.SendMessage("purchaseBulk", JBHJFOLKOCP, SendMessageOptions.RequireReceiver);
		}
	}

	private void HJHLOFDNIOL(bool MLIBCICOOAI)
	{
		if (onHover && target != null)
		{
			target.SendMessage("invalid hero", MLIBCICOOAI, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void OnScroll(float ALBBEKIPKGK)
	{
		if (onScroll && target != null)
		{
			target.SendMessage("OnScroll", ALBBEKIPKGK, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void DENFPNKMHJJ(bool NLGJIEONPNP)
	{
		if (onPress && target != null)
		{
			target.SendMessage("G", NLGJIEONPNP, SendMessageOptions.RequireReceiver);
		}
	}

	private void OJIIOAHHCJK(Vector2 ALBBEKIPKGK)
	{
		if (onDrag && target != null)
		{
			target.SendMessage("AJPLiveOpsPopupUnityEventListener : onCancelPopupBtnClick", ALBBEKIPKGK, SendMessageOptions.RequireReceiver);
		}
	}

	private void DENKKGPIFKA(bool MLIBCICOOAI)
	{
		if (onHover && target != null)
		{
			target.SendMessage("Main menu", MLIBCICOOAI, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void PCILBLDBBDH(bool MLIBCICOOAI)
	{
		if (onHover && target != null)
		{
			target.SendMessage("attack_voice", MLIBCICOOAI, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void BNCMCHCPEIG(GameObject LHACFNECMNA)
	{
		if (onDrop && target != null)
		{
			target.SendMessage("Igaw.Unity : OnRequestPopupResourceForUnity Result: ", LHACFNECMNA, SendMessageOptions.RequireReceiver);
		}
	}

	private void IAHDODLPFOG()
	{
		if (onDoubleClick && target != null)
		{
			target.SendMessage("bytes", SendMessageOptions.RequireReceiver);
		}
	}

	private void OnClick()
	{
		if (onClick && target != null)
		{
			target.SendMessage("OnClick", SendMessageOptions.DontRequireReceiver);
		}
	}
}
