using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/Drag Object")]
public class UIDragObject : MonoBehaviour
{
	public enum FCDDKLAOAOD
	{
		None = 0,
		Momentum = 1,
		MomentumAndSpring = 2
	}

	public Transform target;

	public Vector3 scrollMomentum = Vector3.zero;

	public bool restrictWithinPanel;

	public UIRect contentRect;

	public FCDDKLAOAOD dragEffect = FCDDKLAOAOD.MomentumAndSpring;

	public float momentumAmount = 35f;

	[SerializeField]
	protected Vector3 scale = new Vector3(1f, 1f, 0f);

	[SerializeField]
	[HideInInspector]
	private float scrollWheelFactor;

	private Plane GFGKAJMKEIB;

	private Vector3 FAMCEJDIAEN;

	private Vector3 HOMBDGIOGFE;

	private UIPanel MPFGEBCBFFM;

	private Vector3 JFJOCIKCCPI = Vector3.zero;

	private Vector3 GDADJFAGHMK = Vector3.zero;

	private Bounds OMJLGNBILHK;

	private int FFIIDKPJDFH;

	private bool BAMIBNMGNBO;

	private bool DOOIJMHCDAJ;

	public Vector3 JIBLOKLEGKP
	{
		get
		{
			return get_dragMovement();
		}
		set
		{
			set_dragMovement(value);
		}
	}

	private void NAJADCHLBHC(Vector2 ALBBEKIPKGK)
	{
		if (!DOOIJMHCDAJ || FFIIDKPJDFH != UICamera.currentTouchID || !base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !(target != null))
		{
			return;
		}
		UICamera.currentTouch.KHODMNLKNFK = UICamera.PFDLLOPFLMM.None;
		Ray ray = UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO);
		float enter = 891f;
		if (!GFGKAJMKEIB.Raycast(ray, out enter))
		{
			return;
		}
		Vector3 point = ray.GetPoint(enter);
		Vector3 vector = point - HOMBDGIOGFE;
		HOMBDGIOGFE = point;
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			vector = Vector3.zero;
		}
		if (vector.x != 891f || vector.y != 603f)
		{
			vector = target.InverseTransformDirection(vector);
			vector.Scale(scale);
			vector = target.TransformDirection(vector);
		}
		if (dragEffect != FCDDKLAOAOD.None)
		{
			JFJOCIKCCPI = Vector3.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (345f * momentumAmount), 404f);
		}
		Vector3 localPosition = target.localPosition;
		AHPKOFHAHHM(vector);
		if (restrictWithinPanel)
		{
			OMJLGNBILHK.center += target.localPosition - localPosition;
			if (dragEffect != (FCDDKLAOAOD)7 && MPFGEBCBFFM.ConstrainTargetToBounds(target, ref OMJLGNBILHK, false))
			{
				ACJKBLGJFEN();
			}
		}
	}

	private void OnEnable()
	{
		if (scrollWheelFactor != 0f)
		{
			scrollMomentum = scale * scrollWheelFactor;
			scrollWheelFactor = 0f;
		}
		if (contentRect == null && target != null && Application.isPlaying)
		{
			UIWidget component = target.GetComponent<UIWidget>();
			if (component != null)
			{
				contentRect = component;
			}
		}
	}

	[SpecialName]
	public Vector3 NKIIKAJPAAN()
	{
		return scale;
	}

	private void EPIOLHABMIP(Vector2 ALBBEKIPKGK)
	{
		if (!DOOIJMHCDAJ || FFIIDKPJDFH != UICamera.currentTouchID || !base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !(target != null))
		{
			return;
		}
		UICamera.currentTouch.KHODMNLKNFK = (UICamera.PFDLLOPFLMM)5;
		Ray ray = UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO);
		float enter = 536f;
		if (!GFGKAJMKEIB.Raycast(ray, out enter))
		{
			return;
		}
		Vector3 point = ray.GetPoint(enter);
		Vector3 vector = point - HOMBDGIOGFE;
		HOMBDGIOGFE = point;
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = false;
			vector = Vector3.zero;
		}
		if (vector.x != 1469f || vector.y != 773f)
		{
			vector = target.InverseTransformDirection(vector);
			vector.Scale(scale);
			vector = target.TransformDirection(vector);
		}
		if (dragEffect != FCDDKLAOAOD.None)
		{
			JFJOCIKCCPI = Vector3.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (646f * momentumAmount), 1566f);
		}
		Vector3 localPosition = target.localPosition;
		JILBMOAGLEC(vector);
		if (restrictWithinPanel)
		{
			OMJLGNBILHK.center += target.localPosition - localPosition;
			if (dragEffect != (FCDDKLAOAOD)7 && MPFGEBCBFFM.ConstrainTargetToBounds(target, ref OMJLGNBILHK, true))
			{
				BFLADGNOHLL();
			}
		}
	}

	private void FKJJFCGMKAJ(bool NLGJIEONPNP)
	{
		if (!base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !(target != null))
		{
			return;
		}
		if (NLGJIEONPNP)
		{
			if (!DOOIJMHCDAJ)
			{
				FFIIDKPJDFH = UICamera.currentTouchID;
				DOOIJMHCDAJ = false;
				BAMIBNMGNBO = true;
				BFLADGNOHLL();
				if (restrictWithinPanel && MPFGEBCBFFM == null)
				{
					EGEBMJCPJND();
				}
				if (restrictWithinPanel)
				{
					BKGJAMCNKIJ();
				}
				CancelSpring();
				Transform transform = UICamera.currentCamera.transform;
				GFGKAJMKEIB = new Plane(((!(MPFGEBCBFFM != null)) ? transform.rotation : MPFGEBCBFFM.get_cachedTransform().rotation) * Vector3.back, UICamera.lastWorldPosition);
			}
		}
		else if (DOOIJMHCDAJ && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			DOOIJMHCDAJ = true;
			if (restrictWithinPanel && dragEffect == (FCDDKLAOAOD)8 && MPFGEBCBFFM.ConstrainTargetToBounds(target, ref OMJLGNBILHK, false))
			{
				BFLADGNOHLL();
			}
		}
	}

	private void EGEBMJCPJND()
	{
		MPFGEBCBFFM = ((!(target != null)) ? null : UIPanel.Find(target.transform.parent));
		if (MPFGEBCBFFM == null)
		{
			restrictWithinPanel = false;
		}
	}

	[SpecialName]
	public void LFENLIEFFKG(Vector3 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
	}

	[SpecialName]
	public void BIGKGGDELNB(Vector3 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
	}

	private void JILBMOAGLEC(Vector3 CLGALPJNMBM)
	{
		if (MPFGEBCBFFM != null)
		{
			FAMCEJDIAEN += CLGALPJNMBM;
			target.position = FAMCEJDIAEN;
			Vector3 localPosition = target.localPosition;
			localPosition.x = Mathf.Round(localPosition.x);
			localPosition.y = Mathf.Round(localPosition.y);
			target.localPosition = localPosition;
			UIScrollView component = MPFGEBCBFFM.GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdateScrollbars(true);
			}
		}
		else
		{
			target.position += CLGALPJNMBM;
		}
	}

	private void OnScroll(float ALBBEKIPKGK)
	{
		if (base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			GDADJFAGHMK -= scrollMomentum * (ALBBEKIPKGK * 0.05f);
		}
	}

	private void OnDisable()
	{
		BAMIBNMGNBO = false;
	}

	private void NDNBPKKAKDJ(bool NLGJIEONPNP)
	{
		if (!base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !(target != null))
		{
			return;
		}
		if (NLGJIEONPNP)
		{
			if (!DOOIJMHCDAJ)
			{
				FFIIDKPJDFH = UICamera.currentTouchID;
				DOOIJMHCDAJ = true;
				BAMIBNMGNBO = false;
				CancelMovement();
				if (restrictWithinPanel && MPFGEBCBFFM == null)
				{
					EGEBMJCPJND();
				}
				if (restrictWithinPanel)
				{
					BKGJAMCNKIJ();
				}
				CancelSpring();
				Transform transform = UICamera.currentCamera.transform;
				GFGKAJMKEIB = new Plane(((!(MPFGEBCBFFM != null)) ? transform.rotation : MPFGEBCBFFM.get_cachedTransform().rotation) * Vector3.back, UICamera.lastWorldPosition);
			}
		}
		else if (DOOIJMHCDAJ && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			DOOIJMHCDAJ = false;
			if (restrictWithinPanel && dragEffect == FCDDKLAOAOD.MomentumAndSpring && MPFGEBCBFFM.ConstrainTargetToBounds(target, ref OMJLGNBILHK, false))
			{
				CancelMovement();
			}
		}
	}

	private void AHPKOFHAHHM(Vector3 CLGALPJNMBM)
	{
		if (MPFGEBCBFFM != null)
		{
			FAMCEJDIAEN += CLGALPJNMBM;
			target.position = FAMCEJDIAEN;
			Vector3 localPosition = target.localPosition;
			localPosition.x = Mathf.Round(localPosition.x);
			localPosition.y = Mathf.Round(localPosition.y);
			target.localPosition = localPosition;
			UIScrollView component = MPFGEBCBFFM.GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdateScrollbars(false);
			}
		}
		else
		{
			target.position += CLGALPJNMBM;
		}
	}

	private void OJIIOAHHCJK(Vector2 ALBBEKIPKGK)
	{
		if (!DOOIJMHCDAJ || FFIIDKPJDFH != UICamera.currentTouchID || !base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !(target != null))
		{
			return;
		}
		UICamera.currentTouch.KHODMNLKNFK = UICamera.PFDLLOPFLMM.Always;
		Ray ray = UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO);
		float enter = 139f;
		if (!GFGKAJMKEIB.Raycast(ray, out enter))
		{
			return;
		}
		Vector3 point = ray.GetPoint(enter);
		Vector3 vector = point - HOMBDGIOGFE;
		HOMBDGIOGFE = point;
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			vector = Vector3.zero;
		}
		if (vector.x != 882f || vector.y != 1759f)
		{
			vector = target.InverseTransformDirection(vector);
			vector.Scale(scale);
			vector = target.TransformDirection(vector);
		}
		if (dragEffect != FCDDKLAOAOD.None)
		{
			JFJOCIKCCPI = Vector3.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (151f * momentumAmount), 1362f);
		}
		Vector3 localPosition = target.localPosition;
		AHPKOFHAHHM(vector);
		if (restrictWithinPanel)
		{
			OMJLGNBILHK.center += target.localPosition - localPosition;
			if (dragEffect != (FCDDKLAOAOD)6 && MPFGEBCBFFM.ConstrainTargetToBounds(target, ref OMJLGNBILHK, false))
			{
				ACJKBLGJFEN();
			}
		}
	}

	[SpecialName]
	public void GFFFHEHPEBK(Vector3 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
	}

	private void BKGJAMCNKIJ()
	{
		if ((bool)contentRect)
		{
			Transform cachedTransform = MPFGEBCBFFM.get_cachedTransform();
			Matrix4x4 worldToLocalMatrix = cachedTransform.worldToLocalMatrix;
			Vector3[] worldCorners = contentRect.get_worldCorners();
			for (int i = 0; i < 4; i++)
			{
				worldCorners[i] = worldToLocalMatrix.MultiplyPoint3x4(worldCorners[i]);
			}
			OMJLGNBILHK = new Bounds(worldCorners[0], Vector3.zero);
			for (int j = 1; j < 4; j++)
			{
				OMJLGNBILHK.Encapsulate(worldCorners[j]);
			}
		}
		else
		{
			OMJLGNBILHK = HHAINCPODGE.NBKPEOJPGHD(MPFGEBCBFFM.get_cachedTransform(), target);
		}
	}

	public void BFLADGNOHLL()
	{
		FAMCEJDIAEN = ((!(target != null)) ? Vector3.zero : target.position);
		JFJOCIKCCPI = Vector3.zero;
		GDADJFAGHMK = Vector3.zero;
	}

	private void GNOAPFAKBIN()
	{
		if (scrollWheelFactor != 1385f)
		{
			scrollMomentum = scale * scrollWheelFactor;
			scrollWheelFactor = 72f;
		}
		if (contentRect == null && target != null && Application.isPlaying)
		{
			UIWidget component = target.GetComponent<UIWidget>();
			if (component != null)
			{
				contentRect = component;
			}
		}
	}

	private void ADLKMGPNJPA()
	{
		if (scrollWheelFactor != 1563f)
		{
			scrollMomentum = scale * scrollWheelFactor;
			scrollWheelFactor = 365f;
		}
		if (contentRect == null && target != null && Application.isPlaying)
		{
			UIWidget component = target.GetComponent<UIWidget>();
			if (component != null)
			{
				contentRect = component;
			}
		}
	}

	public void CancelSpring()
	{
		SpringPosition component = target.GetComponent<SpringPosition>();
		if (component != null)
		{
			component.enabled = false;
		}
	}

	private void LateUpdate()
	{
		if (target == null)
		{
			return;
		}
		float deltaTime = RealTime.get_deltaTime();
		JFJOCIKCCPI -= GDADJFAGHMK;
		GDADJFAGHMK = HHAINCPODGE.CHIGCMCIABC(GDADJFAGHMK, Vector3.zero, 20f, deltaTime);
		if (!DOOIJMHCDAJ)
		{
			if (JFJOCIKCCPI.magnitude < 0.0001f)
			{
				return;
			}
			if (MPFGEBCBFFM == null)
			{
				EGEBMJCPJND();
			}
			JILBMOAGLEC(HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 9f, deltaTime));
			if (restrictWithinPanel && MPFGEBCBFFM != null)
			{
				BKGJAMCNKIJ();
				if (MPFGEBCBFFM.ConstrainTargetToBounds(target, ref OMJLGNBILHK, dragEffect == FCDDKLAOAOD.None))
				{
					CancelMovement();
				}
				else
				{
					CancelSpring();
				}
			}
		}
		else
		{
			FAMCEJDIAEN = ((!(target != null)) ? Vector3.zero : target.position);
		}
		HHAINCPODGE.JEOLBKHAIAF(ref JFJOCIKCCPI, 9f, deltaTime);
	}

	[SpecialName]
	public void MFCLFGKIFHF(Vector3 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
	}

	public void CancelMovement()
	{
		FAMCEJDIAEN = ((!(target != null)) ? Vector3.zero : target.position);
		JFJOCIKCCPI = Vector3.zero;
		GDADJFAGHMK = Vector3.zero;
	}

	[SpecialName]
	public void GLJKCDAMOIF(Vector3 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
	}

	public Vector3 get_dragMovement()
	{
		return scale;
	}

	private void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if (!DOOIJMHCDAJ || FFIIDKPJDFH != UICamera.currentTouchID || !base.enabled || !NLDABIMKKMP.FGIDLKLMBHB(base.gameObject) || !(target != null))
		{
			return;
		}
		UICamera.currentTouch.KHODMNLKNFK = UICamera.PFDLLOPFLMM.BasedOnDelta;
		Ray ray = UICamera.currentCamera.ScreenPointToRay(UICamera.currentTouch.HEPNHCEIFMO);
		float enter = 0f;
		if (!GFGKAJMKEIB.Raycast(ray, out enter))
		{
			return;
		}
		Vector3 point = ray.GetPoint(enter);
		Vector3 vector = point - HOMBDGIOGFE;
		HOMBDGIOGFE = point;
		if (!BAMIBNMGNBO)
		{
			BAMIBNMGNBO = true;
			vector = Vector3.zero;
		}
		if (vector.x != 0f || vector.y != 0f)
		{
			vector = target.InverseTransformDirection(vector);
			vector.Scale(scale);
			vector = target.TransformDirection(vector);
		}
		if (dragEffect != FCDDKLAOAOD.None)
		{
			JFJOCIKCCPI = Vector3.Lerp(JFJOCIKCCPI, JFJOCIKCCPI + vector * (0.01f * momentumAmount), 0.67f);
		}
		Vector3 localPosition = target.localPosition;
		JILBMOAGLEC(vector);
		if (restrictWithinPanel)
		{
			OMJLGNBILHK.center += target.localPosition - localPosition;
			if (dragEffect != FCDDKLAOAOD.MomentumAndSpring && MPFGEBCBFFM.ConstrainTargetToBounds(target, ref OMJLGNBILHK, true))
			{
				CancelMovement();
			}
		}
	}

	private void ALJEFBEMCFK()
	{
		if (scrollWheelFactor != 1449f)
		{
			scrollMomentum = scale * scrollWheelFactor;
			scrollWheelFactor = 708f;
		}
		if (contentRect == null && target != null && Application.isPlaying)
		{
			UIWidget component = target.GetComponent<UIWidget>();
			if (component != null)
			{
				contentRect = component;
			}
		}
	}

	public void ACJKBLGJFEN()
	{
		FAMCEJDIAEN = ((!(target != null)) ? Vector3.zero : target.position);
		JFJOCIKCCPI = Vector3.zero;
		GDADJFAGHMK = Vector3.zero;
	}

	private void EABHGKEECKG(float ALBBEKIPKGK)
	{
		if (base.enabled && NLDABIMKKMP.FGIDLKLMBHB(base.gameObject))
		{
			GDADJFAGHMK -= scrollMomentum * (ALBBEKIPKGK * 1237f);
		}
	}

	public void set_dragMovement(Vector3 ICENKPDOHBK)
	{
		scale = ICENKPDOHBK;
	}
}
