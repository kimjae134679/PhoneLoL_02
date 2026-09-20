using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag Scroll View")]
public class UIDragScrollView : MonoBehaviour
{
	public UIScrollView scrollView;

	[HideInInspector]
	[SerializeField]
	private UIScrollView draggablePanel;

	private Transform NPLHCHNGMKF;

	private UIScrollView GDADJFAGHMK;

	private bool MECALEJPMMO;

	private bool BAMIBNMGNBO;

	private void OGGPKDMILNB(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void DENFPNKMHJJ(bool NLGJIEONPNP)
	{
		if (MECALEJPMMO && GDADJFAGHMK != scrollView)
		{
			GDADJFAGHMK = scrollView;
			MECALEJPMMO = true;
		}
		if ((bool)scrollView && base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			scrollView.Press(NLGJIEONPNP);
			if (!NLGJIEONPNP && MECALEJPMMO)
			{
				scrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
				GDADJFAGHMK = scrollView;
			}
		}
	}

	private void IJCPEFOBKHO()
	{
		BAMIBNMGNBO = true;
		APDMACILPLP();
	}

	private void Start()
	{
		BAMIBNMGNBO = true;
		NLBLAPNPBKK();
	}

	private void GEECPDLFIGE(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void OnEnable()
	{
		NPLHCHNGMKF = base.transform;
		if (scrollView == null && draggablePanel != null)
		{
			scrollView = draggablePanel;
			draggablePanel = null;
		}
		if (BAMIBNMGNBO && (MECALEJPMMO || GDADJFAGHMK == null))
		{
			NLBLAPNPBKK();
		}
	}

	private void OnScroll(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void JPDELIOGKJP(Vector2 ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Drag();
		}
	}

	private void MMKOGAFAIOM(bool NLGJIEONPNP)
	{
		if (MECALEJPMMO && GDADJFAGHMK != scrollView)
		{
			GDADJFAGHMK = scrollView;
			MECALEJPMMO = true;
		}
		if ((bool)scrollView && base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			scrollView.Press(NLGJIEONPNP);
			if (!NLGJIEONPNP && MECALEJPMMO)
			{
				scrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
				GDADJFAGHMK = scrollView;
			}
		}
	}

	private void PAJOOFIAPMI()
	{
		BAMIBNMGNBO = false;
		APDMACILPLP();
	}

	private void IOHELNCNDCI(Vector2 ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.BADGEJEAMFP();
		}
	}

	private void JDNELGEGLHD(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void NDNBPKKAKDJ(bool NLGJIEONPNP)
	{
		if (MECALEJPMMO && GDADJFAGHMK != scrollView)
		{
			GDADJFAGHMK = scrollView;
			MECALEJPMMO = false;
		}
		if ((bool)scrollView && base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			scrollView.Press(NLGJIEONPNP);
			if (!NLGJIEONPNP && MECALEJPMMO)
			{
				scrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
				GDADJFAGHMK = scrollView;
			}
		}
	}

	private void HBHMPDMDEEC(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void NLBLAPNPBKK()
	{
		UIScrollView uIScrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
		if (scrollView == null)
		{
			scrollView = uIScrollView;
			MECALEJPMMO = true;
		}
		else if (scrollView == uIScrollView)
		{
			MECALEJPMMO = true;
		}
		GDADJFAGHMK = scrollView;
	}

	private void FKJJFCGMKAJ(bool NLGJIEONPNP)
	{
		if (MECALEJPMMO && GDADJFAGHMK != scrollView)
		{
			GDADJFAGHMK = scrollView;
			MECALEJPMMO = true;
		}
		if ((bool)scrollView && base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			scrollView.Press(NLGJIEONPNP);
			if (!NLGJIEONPNP && MECALEJPMMO)
			{
				scrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
				GDADJFAGHMK = scrollView;
			}
		}
	}

	private void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Drag();
		}
	}

	private void LKJLEOBLEFM(Vector2 ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.BADGEJEAMFP();
		}
	}

	private void IOEPJPKHPPH()
	{
		UIScrollView uIScrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
		if (scrollView == null)
		{
			scrollView = uIScrollView;
			MECALEJPMMO = true;
		}
		else if (scrollView == uIScrollView)
		{
			MECALEJPMMO = true;
		}
		GDADJFAGHMK = scrollView;
	}

	private void MHFDHNGBILJ(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void KNCDKJNGMEM(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void OHIGGKLDEEB(float ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.Scroll(ALBBEKIPKGK);
		}
	}

	private void MLHNMPEDDHL()
	{
		UIScrollView uIScrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
		if (scrollView == null)
		{
			scrollView = uIScrollView;
			MECALEJPMMO = false;
		}
		else if (scrollView == uIScrollView)
		{
			MECALEJPMMO = true;
		}
		GDADJFAGHMK = scrollView;
	}

	private void APDMACILPLP()
	{
		UIScrollView uIScrollView = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(NPLHCHNGMKF);
		if (scrollView == null)
		{
			scrollView = uIScrollView;
			MECALEJPMMO = true;
		}
		else if (scrollView == uIScrollView)
		{
			MECALEJPMMO = false;
		}
		GDADJFAGHMK = scrollView;
	}

	private void CHCDEELCNJJ(Vector2 ALBBEKIPKGK)
	{
		if ((bool)scrollView && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			scrollView.BADGEJEAMFP();
		}
	}

	private void DJCELGKLDAP()
	{
		NPLHCHNGMKF = base.transform;
		if (scrollView == null && draggablePanel != null)
		{
			scrollView = draggablePanel;
			draggablePanel = null;
		}
		if (BAMIBNMGNBO && (MECALEJPMMO || GDADJFAGHMK == null))
		{
			NLBLAPNPBKK();
		}
	}
}
