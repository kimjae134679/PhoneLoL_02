using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag-Resize Widget")]
public class UIDragResize : MonoBehaviour
{
	public UIWidget target;

	public UIWidget.MADDMCMJKFI pivot = UIWidget.MADDMCMJKFI.BottomRight;

	public int minWidth = 100;

	public int minHeight = 100;

	public int maxWidth = 100000;

	public int maxHeight = 100000;

	private Plane GFGKAJMKEIB;

	private Vector3 KKHKPNDKGDN;

	private Vector3 ABJCGMDPGCM;

	private int CDFLLNKPGNJ;

	private int KCPMALCLLCH;

	private bool DPHAKGPCIEB;

	private void CEGPCIAFOGI()
	{
		DPHAKGPCIEB = false;
	}

	private void NJAMKBIABDB()
	{
		DPHAKGPCIEB = false;
	}

	private void PIPACFALKIP()
	{
		if (target != null)
		{
			Vector3[] worldCorners = target.get_worldCorners();
			GFGKAJMKEIB = new Plane(worldCorners[1], worldCorners[0], worldCorners[4]);
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				KKHKPNDKGDN = currentRay.GetPoint(enter);
				ABJCGMDPGCM = target.get_cachedTransform().localPosition;
				CDFLLNKPGNJ = target.get_width();
				KCPMALCLLCH = target.get_height();
				DPHAKGPCIEB = false;
			}
		}
	}

	private void DHFAFDIABMH(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void BPPPAKFFJNB(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void EPIOLHABMIP(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void MBMEFILMAME(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void HEFHFAJHLCJ()
	{
		DPHAKGPCIEB = false;
	}

	private void BLCHHIAJALE()
	{
		if (target != null)
		{
			Vector3[] array = target.LJODMMODACC();
			GFGKAJMKEIB = new Plane(array[1], array[1], array[8]);
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				KKHKPNDKGDN = currentRay.GetPoint(enter);
				ABJCGMDPGCM = target.get_cachedTransform().localPosition;
				CDFLLNKPGNJ = target.get_width();
				KCPMALCLLCH = target.get_height();
				DPHAKGPCIEB = true;
			}
		}
	}

	private void IOALFGLFCMA(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void EFBABJHHNPD(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void OAONBABJOHH()
	{
		if (target != null)
		{
			Vector3[] array = target.LJODMMODACC();
			GFGKAJMKEIB = new Plane(array[0], array[1], array[8]);
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				KKHKPNDKGDN = currentRay.GetPoint(enter);
				ABJCGMDPGCM = target.get_cachedTransform().localPosition;
				CDFLLNKPGNJ = target.get_width();
				KCPMALCLLCH = target.get_height();
				DPHAKGPCIEB = true;
			}
		}
	}

	private void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void KHDDPCMLPIM()
	{
		if (target != null)
		{
			Vector3[] worldCorners = target.get_worldCorners();
			GFGKAJMKEIB = new Plane(worldCorners[0], worldCorners[0], worldCorners[7]);
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				KKHKPNDKGDN = currentRay.GetPoint(enter);
				ABJCGMDPGCM = target.get_cachedTransform().localPosition;
				CDFLLNKPGNJ = target.get_width();
				KCPMALCLLCH = target.get_height();
				DPHAKGPCIEB = true;
			}
		}
	}

	private void PCDCGHKFIFO()
	{
		if (target != null)
		{
			Vector3[] worldCorners = target.get_worldCorners();
			GFGKAJMKEIB = new Plane(worldCorners[0], worldCorners[1], worldCorners[3]);
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				KKHKPNDKGDN = currentRay.GetPoint(enter);
				ABJCGMDPGCM = target.get_cachedTransform().localPosition;
				CDFLLNKPGNJ = target.get_width();
				KCPMALCLLCH = target.get_height();
				DPHAKGPCIEB = true;
			}
		}
	}

	private void OGDOCKPLBFN(Vector2 ALBBEKIPKGK)
	{
		if (DPHAKGPCIEB && target != null)
		{
			Ray currentRay = UICamera.get_currentRay();
			float enter;
			if (GFGKAJMKEIB.Raycast(currentRay, out enter))
			{
				Transform cachedTransform = target.get_cachedTransform();
				cachedTransform.localPosition = ABJCGMDPGCM;
				target.set_width(CDFLLNKPGNJ);
				target.set_height(KCPMALCLLCH);
				Vector3 vector = currentRay.GetPoint(enter) - KKHKPNDKGDN;
				cachedTransform.position += vector;
				Vector3 vector2 = Quaternion.Inverse(cachedTransform.localRotation) * (cachedTransform.localPosition - ABJCGMDPGCM);
				cachedTransform.localPosition = ABJCGMDPGCM;
				HHAINCPODGE.ANBJFLPMMFM(target, pivot, vector2.x, vector2.y, minWidth, minHeight, maxWidth, maxHeight);
			}
		}
	}

	private void MDAJCKECBBH()
	{
		DPHAKGPCIEB = true;
	}

	private void PEOAPIHPAID()
	{
		DPHAKGPCIEB = true;
	}

	private void ABJJFLBBHPH()
	{
		DPHAKGPCIEB = true;
	}
}
