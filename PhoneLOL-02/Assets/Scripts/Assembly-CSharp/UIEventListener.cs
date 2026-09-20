using UnityEngine;

[AddComponentMenu("NGUI/Internal/Event Listener")]
public class UIEventListener : MonoBehaviour
{
	public delegate void MEJLHPPDFBK(GameObject LHACFNECMNA);

	public delegate void BFNMOBFNJNO(GameObject LHACFNECMNA, bool EBILEBOJADB);

	public delegate void BOHMDJHEBMO(GameObject LHACFNECMNA, float ALBBEKIPKGK);

	public delegate void LOJJJBBHHBF(GameObject LHACFNECMNA, Vector2 ALBBEKIPKGK);

	public delegate void BALLELHCBIF(GameObject LHACFNECMNA, GameObject PJLCFJDMHHE);

	public delegate void IBCFDPKAMHP(GameObject LHACFNECMNA, KeyCode NNKLGFNHPBE);

	public object parameter;

	public MEJLHPPDFBK onSubmit;

	public MEJLHPPDFBK onClick;

	public MEJLHPPDFBK onDoubleClick;

	public BFNMOBFNJNO onHover;

	public BFNMOBFNJNO onPress;

	public BFNMOBFNJNO onSelect;

	public BOHMDJHEBMO onScroll;

	public LOJJJBBHHBF onDrag;

	public BALLELHCBIF onDrop;

	public IBCFDPKAMHP onKey;

	private void OJMBNBMBAMK(bool MLIBCICOOAI)
	{
		if (onHover != null)
		{
			onHover(base.gameObject, MLIBCICOOAI);
		}
	}

	private void OnClick()
	{
		if (onClick != null)
		{
			onClick(base.gameObject);
		}
	}

	private void AMGMEEEIMEL(KeyCode NNKLGFNHPBE)
	{
		if (onKey != null)
		{
			onKey(base.gameObject, NNKLGFNHPBE);
		}
	}

	private void MAPBCONECLF(Vector2 ALBBEKIPKGK)
	{
		if (onDrag != null)
		{
			onDrag(base.gameObject, ALBBEKIPKGK);
		}
	}

	private void HMJLBBELIGG(GameObject LHACFNECMNA)
	{
		if (onDrop != null)
		{
			onDrop(base.gameObject, LHACFNECMNA);
		}
	}

	private void GPEIOKHGGDL()
	{
		if (onDoubleClick != null)
		{
			onDoubleClick(base.gameObject);
		}
	}

	private void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if (onDrag != null)
		{
			onDrag(base.gameObject, ALBBEKIPKGK);
		}
	}

	private void FGECOIGPMOK(bool JPNFGIEDOMM)
	{
		if (onPress != null)
		{
			onPress(base.gameObject, JPNFGIEDOMM);
		}
	}

	private void MBMEFILMAME(Vector2 ALBBEKIPKGK)
	{
		if (onDrag != null)
		{
			onDrag(base.gameObject, ALBBEKIPKGK);
		}
	}

	private void PBDCBOEHJLH(bool MLIBCICOOAI)
	{
		if (onHover != null)
		{
			onHover(base.gameObject, MLIBCICOOAI);
		}
	}

	private void NJAPIAABFOI(bool JBHJFOLKOCP)
	{
		if (onSelect != null)
		{
			onSelect(base.gameObject, JBHJFOLKOCP);
		}
	}

	private void MAIPLAJNNAB(bool JPNFGIEDOMM)
	{
		if (onPress != null)
		{
			onPress(base.gameObject, JPNFGIEDOMM);
		}
	}

	private void NOACAIINNGJ()
	{
		if (onDoubleClick != null)
		{
			onDoubleClick(base.gameObject);
		}
	}

	public static UIEventListener Get(GameObject LHACFNECMNA)
	{
		UIEventListener uIEventListener = LHACFNECMNA.GetComponent<UIEventListener>();
		if (uIEventListener == null)
		{
			uIEventListener = LHACFNECMNA.AddComponent<UIEventListener>();
		}
		return uIEventListener;
	}

	private void OnScroll(float ALBBEKIPKGK)
	{
		if (onScroll != null)
		{
			onScroll(base.gameObject, ALBBEKIPKGK);
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (onHover != null)
		{
			onHover(base.gameObject, MLIBCICOOAI);
		}
	}

	private void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (onPress != null)
		{
			onPress(base.gameObject, JPNFGIEDOMM);
		}
	}

	private void PCCAJGCPDFN(GameObject LHACFNECMNA)
	{
		if (onDrop != null)
		{
			onDrop(base.gameObject, LHACFNECMNA);
		}
	}

	private void BEADMIJEKJF(bool JPNFGIEDOMM)
	{
		if (onPress != null)
		{
			onPress(base.gameObject, JPNFGIEDOMM);
		}
	}

	private void MMKOGAFAIOM(bool JPNFGIEDOMM)
	{
		if (onPress != null)
		{
			onPress(base.gameObject, JPNFGIEDOMM);
		}
	}

	private void PLEKNAJFOPP()
	{
		if (onClick != null)
		{
			onClick(base.gameObject);
		}
	}

	private void FJEJPEDGLHN(bool JPNFGIEDOMM)
	{
		if (onPress != null)
		{
			onPress(base.gameObject, JPNFGIEDOMM);
		}
	}

	private void FLAJCLOKBPH()
	{
		if (onSubmit != null)
		{
			onSubmit(base.gameObject);
		}
	}

	private void NMFIJPONHGK()
	{
		if (onSubmit != null)
		{
			onSubmit(base.gameObject);
		}
	}

	private void JADBJGCMIMF(bool JBHJFOLKOCP)
	{
		if (onSelect != null)
		{
			onSelect(base.gameObject, JBHJFOLKOCP);
		}
	}

	private void EPIOLHABMIP(Vector2 ALBBEKIPKGK)
	{
		if (onDrag != null)
		{
			onDrag(base.gameObject, ALBBEKIPKGK);
		}
	}

	private void KGECMPGKEFC(KeyCode NNKLGFNHPBE)
	{
		if (onKey != null)
		{
			onKey(base.gameObject, NNKLGFNHPBE);
		}
	}

	private void BPPLABHECCG()
	{
		if (onSubmit != null)
		{
			onSubmit(base.gameObject);
		}
	}

	private void MNJJBJANFFA(GameObject LHACFNECMNA)
	{
		if (onDrop != null)
		{
			onDrop(base.gameObject, LHACFNECMNA);
		}
	}
}
