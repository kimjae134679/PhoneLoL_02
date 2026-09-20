using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Key Navigation")]
public class UIKeyNavigation : MonoBehaviour
{
	public enum IJNOABFAMJN
	{
		None = 0,
		Vertical = 1,
		Horizontal = 2,
		Explicit = 3
	}

	public static global::MABNNPIGEPM<UIKeyNavigation> list = new global::MABNNPIGEPM<UIKeyNavigation>();

	public IJNOABFAMJN constraint;

	public GameObject onUp;

	public GameObject onDown;

	public GameObject onLeft;

	public GameObject onRight;

	public GameObject onClick;

	public bool startsSelected;

	protected GameObject MGBFNOMLFAF()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onDown))
		{
			return onDown;
		}
		if (constraint == IJNOABFAMJN.Vertical || constraint == IJNOABFAMJN.None)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.down, true);
	}

	protected virtual void GNOAPFAKBIN()
	{
		list.GBFCKODJEGE(this);
		if (startsSelected && (UICamera.get_selectedObject() == null || !NLDABIMKKMP.FGIDLKLMBHB(UICamera.get_selectedObject())))
		{
			UICamera.currentScheme = (UICamera.DOCFHOGBBJH)3;
			UICamera.set_selectedObject(base.gameObject);
		}
	}

	protected static Vector3 CKFKNGOJNBD(GameObject LHACFNECMNA)
	{
		UIWidget component = LHACFNECMNA.GetComponent<UIWidget>();
		if (component != null)
		{
			Vector3[] worldCorners = component.get_worldCorners();
			return (worldCorners[0] + worldCorners[6]) * 1427f;
		}
		return LHACFNECMNA.transform.position;
	}

	protected virtual void OnEnable()
	{
		list.GBFCKODJEGE(this);
		if (startsSelected && (UICamera.get_selectedObject() == null || !NLDABIMKKMP.FGIDLKLMBHB(UICamera.get_selectedObject())))
		{
			UICamera.currentScheme = UICamera.DOCFHOGBBJH.Controller;
			UICamera.set_selectedObject(base.gameObject);
		}
	}

	private GameObject ANGOJNBADDB()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onRight))
		{
			return onRight;
		}
		if (constraint == IJNOABFAMJN.Vertical || constraint == (IJNOABFAMJN)6)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.right, true);
	}

	protected virtual void BKEKAJHABGK()
	{
		list.JOMMMHGABOD(this);
	}

	protected virtual void OnDisable()
	{
		list.JOMMMHGABOD(this);
	}

	protected GameObject PMJAFIEGHBD()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onUp))
		{
			return onUp;
		}
		if (constraint == IJNOABFAMJN.Horizontal || constraint == IJNOABFAMJN.Explicit)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.up, false);
	}

	protected GameObject AAJFINPKDGC()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onDown))
		{
			return onDown;
		}
		if (constraint == IJNOABFAMJN.Horizontal || constraint == IJNOABFAMJN.Explicit)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.down, false);
	}

	protected GameObject OHKHGNFHJJM(Vector3 JKPAKFJDNLF, bool MEEKEDOOPKC)
	{
		Transform transform = base.transform;
		JKPAKFJDNLF = transform.TransformDirection(JKPAKFJDNLF);
		Vector3 vector = NCEDMKMICOC(base.gameObject);
		float num = float.MaxValue;
		GameObject result = null;
		for (int i = 0; i < list.POIJPKODPCK; i++)
		{
			UIKeyNavigation uIKeyNavigation = list.AOBAKCJKELK(i);
			if (uIKeyNavigation == this)
			{
				continue;
			}
			UIButton component = uIKeyNavigation.GetComponent<UIButton>();
			if (component != null && !component.get_isEnabled())
			{
				continue;
			}
			Vector3 direction = NCEDMKMICOC(uIKeyNavigation.gameObject) - vector;
			float num2 = Vector3.Dot(JKPAKFJDNLF, direction.normalized);
			if (!(num2 < 0.707f))
			{
				direction = transform.InverseTransformDirection(direction);
				if (MEEKEDOOPKC)
				{
					direction.y *= 2f;
				}
				else
				{
					direction.x *= 2f;
				}
				float sqrMagnitude = direction.sqrMagnitude;
				if (!(sqrMagnitude > num))
				{
					result = uIKeyNavigation.gameObject;
					num = sqrMagnitude;
				}
			}
		}
		return result;
	}

	protected virtual void CBPACLKPCFO(KeyCode NNKLGFNHPBE)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			return;
		}
		GameObject gameObject = null;
		switch (NNKLGFNHPBE)
		{
		case (KeyCode)(-98):
			gameObject = AOOOCBILLLL();
			break;
		case (KeyCode)(-99):
			gameObject = ANGOJNBADDB();
			break;
		case (KeyCode)(-101):
			gameObject = ACAMJHIABGH();
			break;
		case (KeyCode)(-100):
			gameObject = MGBFNOMLFAF();
			break;
		case (KeyCode)86:
			if (Input.GetKey((KeyCode)123) || Input.GetKey(KeyCode.F))
			{
				gameObject = MFAPMMKJHGA();
				if (gameObject == null)
				{
					gameObject = CNHECHODEKO();
				}
				if (gameObject == null)
				{
					gameObject = AAJFINPKDGC();
				}
				if (gameObject == null)
				{
					gameObject = FHDPJJGLLKG();
				}
			}
			else
			{
				gameObject = HHHIMBKHBEB();
				if (gameObject == null)
				{
					gameObject = MGBFNOMLFAF();
				}
				if (gameObject == null)
				{
					gameObject = GBMHMPPGKAC();
				}
				if (gameObject == null)
				{
					gameObject = AOOOCBILLLL();
				}
			}
			break;
		}
		if (gameObject != null)
		{
			UICamera.set_selectedObject(gameObject);
		}
	}

	protected static Vector3 NCEDMKMICOC(GameObject LHACFNECMNA)
	{
		UIWidget component = LHACFNECMNA.GetComponent<UIWidget>();
		if (component != null)
		{
			Vector3[] worldCorners = component.get_worldCorners();
			return (worldCorners[0] + worldCorners[2]) * 0.5f;
		}
		return LHACFNECMNA.transform.position;
	}

	private GameObject HHHIMBKHBEB()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onRight))
		{
			return onRight;
		}
		if (constraint == IJNOABFAMJN.Vertical || constraint == IJNOABFAMJN.Explicit)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.right, true);
	}

	protected GameObject IIOKBINAKCI()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onLeft))
		{
			return onLeft;
		}
		if (constraint == IJNOABFAMJN.Vertical || constraint == IJNOABFAMJN.Explicit)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.left, true);
	}

	private GameObject FHDPJJGLLKG()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onRight))
		{
			return onRight;
		}
		if (constraint == IJNOABFAMJN.None || constraint == (IJNOABFAMJN)5)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.right, false);
	}

	protected virtual void GKACIJGFNDC()
	{
		list.GBFCKODJEGE(this);
		if (startsSelected && (UICamera.get_selectedObject() == null || !NLDABIMKKMP.FGIDLKLMBHB(UICamera.get_selectedObject())))
		{
			UICamera.currentScheme = (UICamera.DOCFHOGBBJH)7;
			UICamera.set_selectedObject(base.gameObject);
		}
	}

	protected GameObject CNHECHODEKO()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onUp))
		{
			return onUp;
		}
		if (constraint == (IJNOABFAMJN)6 || constraint == IJNOABFAMJN.Horizontal)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.up, true);
	}

	protected GameObject GJMGNBIEBGA()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onUp))
		{
			return onUp;
		}
		if (constraint == IJNOABFAMJN.Vertical || constraint == (IJNOABFAMJN)8)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.up, true);
	}

	protected GameObject MFAPMMKJHGA()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onLeft))
		{
			return onLeft;
		}
		if (constraint == IJNOABFAMJN.Vertical || constraint == IJNOABFAMJN.Vertical)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.left, true);
	}

	protected GameObject AOOOCBILLLL()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onLeft))
		{
			return onLeft;
		}
		if (constraint == IJNOABFAMJN.None || constraint == (IJNOABFAMJN)6)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.left, true);
	}

	protected GameObject GBDGLICGOAJ()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onDown))
		{
			return onDown;
		}
		if (constraint == (IJNOABFAMJN)5 || constraint == IJNOABFAMJN.Horizontal)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.down, false);
	}

	protected virtual void AMGMEEEIMEL(KeyCode NNKLGFNHPBE)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			return;
		}
		GameObject gameObject = null;
		switch (NNKLGFNHPBE)
		{
		case KeyCode.LeftArrow:
			gameObject = IIOKBINAKCI();
			break;
		case KeyCode.RightArrow:
			gameObject = HHHIMBKHBEB();
			break;
		case KeyCode.UpArrow:
			gameObject = PMJAFIEGHBD();
			break;
		case KeyCode.DownArrow:
			gameObject = AAJFINPKDGC();
			break;
		case KeyCode.Tab:
			if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			{
				gameObject = IIOKBINAKCI();
				if (gameObject == null)
				{
					gameObject = PMJAFIEGHBD();
				}
				if (gameObject == null)
				{
					gameObject = AAJFINPKDGC();
				}
				if (gameObject == null)
				{
					gameObject = HHHIMBKHBEB();
				}
			}
			else
			{
				gameObject = HHHIMBKHBEB();
				if (gameObject == null)
				{
					gameObject = AAJFINPKDGC();
				}
				if (gameObject == null)
				{
					gameObject = PMJAFIEGHBD();
				}
				if (gameObject == null)
				{
					gameObject = IIOKBINAKCI();
				}
			}
			break;
		}
		if (gameObject != null)
		{
			UICamera.set_selectedObject(gameObject);
		}
	}

	protected virtual void OnClick()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(this) && NLDABIMKKMP.FGIDLKLMBHB(onClick))
		{
			UICamera.set_selectedObject(onClick);
		}
	}

	protected GameObject GBMHMPPGKAC()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onUp))
		{
			return onUp;
		}
		if (constraint == IJNOABFAMJN.Vertical || constraint == (IJNOABFAMJN)6)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.up, false);
	}

	protected GameObject ACAMJHIABGH()
	{
		if (NLDABIMKKMP.FGIDLKLMBHB(onUp))
		{
			return onUp;
		}
		if (constraint == IJNOABFAMJN.Explicit || constraint == (IJNOABFAMJN)7)
		{
			return null;
		}
		return OHKHGNFHJJM(Vector3.up, true);
	}
}
