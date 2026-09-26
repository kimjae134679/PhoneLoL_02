using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Drag and Drop Item")]
public class UIDragDropItem : MonoBehaviour
{
	public enum ENJDAMOBMHE
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		PressAndHold = 3
	}

	public ENJDAMOBMHE restriction;

	public bool cloneOnDrag;

	[HideInInspector]
	public float pressAndHoldDelay = 1f;

	protected Transform NPLHCHNGMKF;

	protected Transform IIJJJLNFCNC;

	protected Collider IGCEALPLMPH;

	protected UIButton AOKFPINANLN;

	protected UIRoot ONNMDGOJEBB;

	protected UIGrid PIDGKPNPEOO;

	protected UITable FHNBLICPKHE;

	protected int FFIIDKPJDFH = int.MinValue;

	protected float MLPFOHLMKGB;

	protected UIDragScrollView JMDOCCNCEEK;

	private void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			LAMFAEKPPBO((Vector3)ALBBEKIPKGK * ONNMDGOJEBB.get_pixelSizeAdjustment());
		}
	}

	protected virtual void CMMIADLEBFJ()
	{
		NPLHCHNGMKF = base.transform;
		IGCEALPLMPH = base.GetComponent<Collider>();
		AOKFPINANLN = GetComponent<UIButton>();
		JMDOCCNCEEK = GetComponent<UIDragScrollView>();
	}

	protected virtual void EDDELPIBBLH(Vector3 ALBBEKIPKGK)
	{
		NPLHCHNGMKF.localPosition += ALBBEKIPKGK;
	}

	protected virtual void CHJGEGLHOAF()
	{
		NPLHCHNGMKF = base.transform;
		IGCEALPLMPH = base.GetComponent<Collider>();
		AOKFPINANLN = GetComponent<UIButton>();
		JMDOCCNCEEK = GetComponent<UIDragScrollView>();
	}

	private void PCDCGHKFIFO()
	{
		if (!base.enabled || FFIIDKPJDFH != int.MinValue)
		{
			return;
		}
		if (restriction != ENJDAMOBMHE.None)
		{
			if (restriction == ENJDAMOBMHE.Horizontal)
			{
				Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE.x) < Mathf.Abs(nDIFPBOFHJE.y))
				{
					return;
				}
			}
			else if (restriction == ENJDAMOBMHE.Vertical)
			{
				Vector2 nDIFPBOFHJE2 = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE2.x) > Mathf.Abs(nDIFPBOFHJE2.y))
				{
					return;
				}
			}
			else if (restriction == ENJDAMOBMHE.PressAndHold && MLPFOHLMKGB + pressAndHoldDelay > RealTime.get_time())
			{
				return;
			}
		}
		if (cloneOnDrag)
		{
			GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.transform.parent.gameObject, base.gameObject);
			gameObject.transform.localPosition = base.transform.localPosition;
			gameObject.transform.localRotation = base.transform.localRotation;
			gameObject.transform.localScale = base.transform.localScale;
			UIButtonColor component = gameObject.GetComponent<UIButtonColor>();
			if (component != null)
			{
				component.set_defaultColor(GetComponent<UIButtonColor>().get_defaultColor());
			}
			UICamera.currentTouch.ALNIBPBGIKH = gameObject;
			UIDragDropItem component2 = gameObject.GetComponent<UIDragDropItem>();
			component2.Start();
			component2.LACFJCGJNPF();
		}
		else
		{
			LACFJCGJNPF();
		}
	}

	protected virtual void FJAEDIKKIHD()
	{
		if (JMDOCCNCEEK != null)
		{
			JMDOCCNCEEK.enabled = true;
		}
		if (AOKFPINANLN != null)
		{
			AOKFPINANLN.DMAMACNDKGD(true);
		}
		else if (IGCEALPLMPH != null)
		{
			IGCEALPLMPH.enabled = false;
		}
		FFIIDKPJDFH = UICamera.currentTouchID;
		IIJJJLNFCNC = NPLHCHNGMKF.parent;
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(IIJJJLNFCNC);
		PIDGKPNPEOO = NLDABIMKKMP.ANPDHFFNJFD<UIGrid>(IIJJJLNFCNC);
		FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(IIJJJLNFCNC);
		if (UIDragDropRoot.root != null)
		{
			NPLHCHNGMKF.parent = UIDragDropRoot.root;
		}
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		localPosition.z = 614f;
		NPLHCHNGMKF.localPosition = localPosition;
		TweenPosition component = GetComponent<TweenPosition>();
		if (component != null)
		{
			component.enabled = false;
		}
		SpringPosition component2 = GetComponent<SpringPosition>();
		if (component2 != null)
		{
			component2.enabled = true;
		}
		NLDABIMKKMP.NADGFEKBOIH(base.gameObject);
		if (FHNBLICPKHE != null)
		{
			FHNBLICPKHE.LMABFIEADMG(true);
		}
		if (PIDGKPNPEOO != null)
		{
			PIDGKPNPEOO.GMCLGLGHEKB(true);
		}
	}

	private void JBPHKGDJFID(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			MLPFOHLMKGB = RealTime.GKFNENKKLEJ();
		}
	}

	private void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			MLPFOHLMKGB = RealTime.get_time();
		}
	}

	protected virtual void FMNOLGPIIFB()
	{
		NPLHCHNGMKF = base.transform;
		IGCEALPLMPH = base.GetComponent<Collider>();
		AOKFPINANLN = GetComponent<UIButton>();
		JMDOCCNCEEK = GetComponent<UIDragScrollView>();
	}

	protected virtual void BEAADEKNPKO(GameObject ABNPMCHABMP)
	{
		if (!cloneOnDrag)
		{
			FFIIDKPJDFH = -174;
			if (AOKFPINANLN != null)
			{
				AOKFPINANLN.DMAMACNDKGD(false);
			}
			else if (IGCEALPLMPH != null)
			{
				IGCEALPLMPH.enabled = false;
			}
			UIDragDropContainer uIDragDropContainer = ((!ABNPMCHABMP) ? null : NLDABIMKKMP.ANPDHFFNJFD<UIDragDropContainer>(ABNPMCHABMP));
			if (uIDragDropContainer != null)
			{
				NPLHCHNGMKF.parent = ((!(uIDragDropContainer.reparentTarget != null)) ? uIDragDropContainer.transform : uIDragDropContainer.reparentTarget);
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.z = 332f;
				NPLHCHNGMKF.localPosition = localPosition;
			}
			else
			{
				NPLHCHNGMKF.parent = IIJJJLNFCNC;
			}
			IIJJJLNFCNC = NPLHCHNGMKF.parent;
			PIDGKPNPEOO = NLDABIMKKMP.ANPDHFFNJFD<UIGrid>(IIJJJLNFCNC);
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(IIJJJLNFCNC);
			if (JMDOCCNCEEK != null)
			{
				JMDOCCNCEEK.enabled = false;
			}
			NLDABIMKKMP.NADGFEKBOIH(base.gameObject);
			if (FHNBLICPKHE != null)
			{
				FHNBLICPKHE.BDFFOMOPFBL(false);
			}
			if (PIDGKPNPEOO != null)
			{
				PIDGKPNPEOO.LHFKJENEEGB(false);
			}
		}
		else
		{
			NLDABIMKKMP.HEAFKMJAOHM(base.gameObject);
		}
	}

	private void NPADAPGPMEC()
	{
		if (!base.enabled || FFIIDKPJDFH != 86)
		{
			return;
		}
		if (restriction != ENJDAMOBMHE.None)
		{
			if (restriction == ENJDAMOBMHE.Horizontal)
			{
				Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE.x) < Mathf.Abs(nDIFPBOFHJE.y))
				{
					return;
				}
			}
			else if (restriction == (ENJDAMOBMHE)5)
			{
				Vector2 nDIFPBOFHJE2 = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE2.x) > Mathf.Abs(nDIFPBOFHJE2.y))
				{
					return;
				}
			}
			else if (restriction == ENJDAMOBMHE.Vertical && MLPFOHLMKGB + pressAndHoldDelay > RealTime.GKOILKJMJGA())
			{
				return;
			}
		}
		if (cloneOnDrag)
		{
			GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.transform.parent.gameObject, base.gameObject);
			gameObject.transform.localPosition = base.transform.localPosition;
			gameObject.transform.localRotation = base.transform.localRotation;
			gameObject.transform.localScale = base.transform.localScale;
			UIButtonColor component = gameObject.GetComponent<UIButtonColor>();
			if (component != null)
			{
				component.NBKHAELMBKJ(GetComponent<UIButtonColor>().CCHLPJJPILL());
			}
			UICamera.currentTouch.ALNIBPBGIKH = gameObject;
			UIDragDropItem component2 = gameObject.GetComponent<UIDragDropItem>();
			component2.CMMIADLEBFJ();
			component2.FJAEDIKKIHD();
		}
		else
		{
			LACFJCGJNPF();
		}
	}

	protected virtual void KGBPEGIIBJJ(Vector3 ALBBEKIPKGK)
	{
		NPLHCHNGMKF.localPosition += ALBBEKIPKGK;
	}

	protected virtual void BPLOLCKEJJK()
	{
		NPLHCHNGMKF = base.transform;
		IGCEALPLMPH = base.GetComponent<Collider>();
		AOKFPINANLN = GetComponent<UIButton>();
		JMDOCCNCEEK = GetComponent<UIDragScrollView>();
	}

	protected virtual void LACFJCGJNPF()
	{
		if (JMDOCCNCEEK != null)
		{
			JMDOCCNCEEK.enabled = false;
		}
		if (AOKFPINANLN != null)
		{
			AOKFPINANLN.set_isEnabled(false);
		}
		else if (IGCEALPLMPH != null)
		{
			IGCEALPLMPH.enabled = false;
		}
		FFIIDKPJDFH = UICamera.currentTouchID;
		IIJJJLNFCNC = NPLHCHNGMKF.parent;
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(IIJJJLNFCNC);
		PIDGKPNPEOO = NLDABIMKKMP.ANPDHFFNJFD<UIGrid>(IIJJJLNFCNC);
		FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(IIJJJLNFCNC);
		if (UIDragDropRoot.root != null)
		{
			NPLHCHNGMKF.parent = UIDragDropRoot.root;
		}
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		localPosition.z = 0f;
		NPLHCHNGMKF.localPosition = localPosition;
		TweenPosition component = GetComponent<TweenPosition>();
		if (component != null)
		{
			component.enabled = false;
		}
		SpringPosition component2 = GetComponent<SpringPosition>();
		if (component2 != null)
		{
			component2.enabled = false;
		}
		NLDABIMKKMP.NADGFEKBOIH(base.gameObject);
		if (FHNBLICPKHE != null)
		{
			FHNBLICPKHE.set_repositionNow(true);
		}
		if (PIDGKPNPEOO != null)
		{
			PIDGKPNPEOO.set_repositionNow(true);
		}
	}

	private void NKFGJDIBPBN()
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			AHIDGJGINOA(UICamera.hoveredObject);
		}
	}

	protected virtual void AHIDGJGINOA(GameObject ABNPMCHABMP)
	{
		if (!cloneOnDrag)
		{
			FFIIDKPJDFH = int.MinValue;
			if (AOKFPINANLN != null)
			{
				AOKFPINANLN.set_isEnabled(true);
			}
			else if (IGCEALPLMPH != null)
			{
				IGCEALPLMPH.enabled = true;
			}
			UIDragDropContainer uIDragDropContainer = ((!ABNPMCHABMP) ? null : NLDABIMKKMP.ANPDHFFNJFD<UIDragDropContainer>(ABNPMCHABMP));
			if (uIDragDropContainer != null)
			{
				NPLHCHNGMKF.parent = ((!(uIDragDropContainer.reparentTarget != null)) ? uIDragDropContainer.transform : uIDragDropContainer.reparentTarget);
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.z = 0f;
				NPLHCHNGMKF.localPosition = localPosition;
			}
			else
			{
				NPLHCHNGMKF.parent = IIJJJLNFCNC;
			}
			IIJJJLNFCNC = NPLHCHNGMKF.parent;
			PIDGKPNPEOO = NLDABIMKKMP.ANPDHFFNJFD<UIGrid>(IIJJJLNFCNC);
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(IIJJJLNFCNC);
			if (JMDOCCNCEEK != null)
			{
				JMDOCCNCEEK.enabled = true;
			}
			NLDABIMKKMP.NADGFEKBOIH(base.gameObject);
			if (FHNBLICPKHE != null)
			{
				FHNBLICPKHE.set_repositionNow(true);
			}
			if (PIDGKPNPEOO != null)
			{
				PIDGKPNPEOO.set_repositionNow(true);
			}
		}
		else
		{
			NLDABIMKKMP.HEAFKMJAOHM(base.gameObject);
		}
	}

	protected virtual void FNPOBANODOE(Vector3 ALBBEKIPKGK)
	{
		NPLHCHNGMKF.localPosition += ALBBEKIPKGK;
	}

	private void DBAEJAHLDCA()
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			AHIDGJGINOA(UICamera.hoveredObject);
		}
	}

	private void CDDKAAGIDKN()
	{
		if (!base.enabled || FFIIDKPJDFH != 158)
		{
			return;
		}
		if (restriction != ENJDAMOBMHE.None)
		{
			if (restriction == ENJDAMOBMHE.Horizontal)
			{
				Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE.x) < Mathf.Abs(nDIFPBOFHJE.y))
				{
					return;
				}
			}
			else if (restriction == (ENJDAMOBMHE)6)
			{
				Vector2 nDIFPBOFHJE2 = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE2.x) > Mathf.Abs(nDIFPBOFHJE2.y))
				{
					return;
				}
			}
			else if (restriction == ENJDAMOBMHE.None && MLPFOHLMKGB + pressAndHoldDelay > RealTime.JNMGIHLPIAG())
			{
				return;
			}
		}
		if (cloneOnDrag)
		{
			GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.transform.parent.gameObject, base.gameObject);
			gameObject.transform.localPosition = base.transform.localPosition;
			gameObject.transform.localRotation = base.transform.localRotation;
			gameObject.transform.localScale = base.transform.localScale;
			UIButtonColor component = gameObject.GetComponent<UIButtonColor>();
			if (component != null)
			{
				component.NBKHAELMBKJ(GetComponent<UIButtonColor>().get_defaultColor());
			}
			UICamera.currentTouch.ALNIBPBGIKH = gameObject;
			UIDragDropItem component2 = gameObject.GetComponent<UIDragDropItem>();
			component2.CMMIADLEBFJ();
			component2.FJAEDIKKIHD();
		}
		else
		{
			FJAEDIKKIHD();
		}
	}

	private void MDCBAMCFLNC()
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			AHIDGJGINOA(UICamera.hoveredObject);
		}
	}

	protected virtual void PILOBHCDHIK()
	{
		NPLHCHNGMKF = base.transform;
		IGCEALPLMPH = base.GetComponent<Collider>();
		AOKFPINANLN = GetComponent<UIButton>();
		JMDOCCNCEEK = GetComponent<UIDragScrollView>();
	}

	private void KALBKLACMNE()
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			AHIDGJGINOA(UICamera.hoveredObject);
		}
	}

	protected virtual void ILHGGJOLNCG(GameObject ABNPMCHABMP)
	{
		if (!cloneOnDrag)
		{
			FFIIDKPJDFH = 120;
			if (AOKFPINANLN != null)
			{
				AOKFPINANLN.set_isEnabled(true);
			}
			else if (IGCEALPLMPH != null)
			{
				IGCEALPLMPH.enabled = false;
			}
			UIDragDropContainer uIDragDropContainer = ((!ABNPMCHABMP) ? null : NLDABIMKKMP.ANPDHFFNJFD<UIDragDropContainer>(ABNPMCHABMP));
			if (uIDragDropContainer != null)
			{
				NPLHCHNGMKF.parent = ((!(uIDragDropContainer.reparentTarget != null)) ? uIDragDropContainer.transform : uIDragDropContainer.reparentTarget);
				Vector3 localPosition = NPLHCHNGMKF.localPosition;
				localPosition.z = 1716f;
				NPLHCHNGMKF.localPosition = localPosition;
			}
			else
			{
				NPLHCHNGMKF.parent = IIJJJLNFCNC;
			}
			IIJJJLNFCNC = NPLHCHNGMKF.parent;
			PIDGKPNPEOO = NLDABIMKKMP.ANPDHFFNJFD<UIGrid>(IIJJJLNFCNC);
			FHNBLICPKHE = NLDABIMKKMP.ANPDHFFNJFD<UITable>(IIJJJLNFCNC);
			if (JMDOCCNCEEK != null)
			{
				JMDOCCNCEEK.enabled = false;
			}
			NLDABIMKKMP.NADGFEKBOIH(base.gameObject);
			if (FHNBLICPKHE != null)
			{
				FHNBLICPKHE.BDFFOMOPFBL(true);
			}
			if (PIDGKPNPEOO != null)
			{
				PIDGKPNPEOO.CBJHPMGELAP(false);
			}
		}
		else
		{
			NLDABIMKKMP.HEAFKMJAOHM(base.gameObject);
		}
	}

	private void JFCLLAHJEFA(Vector2 ALBBEKIPKGK)
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			MFEDCPNAKDN((Vector3)ALBBEKIPKGK * ONNMDGOJEBB.get_pixelSizeAdjustment());
		}
	}

	private void JIGJHPJDMFI()
	{
		if (!base.enabled || FFIIDKPJDFH != 41)
		{
			return;
		}
		if (restriction != ENJDAMOBMHE.None)
		{
			if (restriction == ENJDAMOBMHE.Horizontal)
			{
				Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE.x) < Mathf.Abs(nDIFPBOFHJE.y))
				{
					return;
				}
			}
			else if (restriction == ENJDAMOBMHE.PressAndHold)
			{
				Vector2 nDIFPBOFHJE2 = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE2.x) > Mathf.Abs(nDIFPBOFHJE2.y))
				{
					return;
				}
			}
			else if (restriction == (ENJDAMOBMHE)5 && MLPFOHLMKGB + pressAndHoldDelay > RealTime.JNMGIHLPIAG())
			{
				return;
			}
		}
		if (cloneOnDrag)
		{
			GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.transform.parent.gameObject, base.gameObject);
			gameObject.transform.localPosition = base.transform.localPosition;
			gameObject.transform.localRotation = base.transform.localRotation;
			gameObject.transform.localScale = base.transform.localScale;
			UIButtonColor component = gameObject.GetComponent<UIButtonColor>();
			if (component != null)
			{
				component.NBKHAELMBKJ(GetComponent<UIButtonColor>().CCHLPJJPILL());
			}
			UICamera.currentTouch.ALNIBPBGIKH = gameObject;
			UIDragDropItem component2 = gameObject.GetComponent<UIDragDropItem>();
			component2.BPLOLCKEJJK();
			component2.LACFJCGJNPF();
		}
		else
		{
			FJAEDIKKIHD();
		}
	}

	protected virtual void Start()
	{
		NPLHCHNGMKF = base.transform;
		IGCEALPLMPH = base.GetComponent<Collider>();
		AOKFPINANLN = GetComponent<UIButton>();
		JMDOCCNCEEK = GetComponent<UIDragScrollView>();
	}

	protected virtual void LAMFAEKPPBO(Vector3 ALBBEKIPKGK)
	{
		NPLHCHNGMKF.localPosition += ALBBEKIPKGK;
	}

	private void OAONBABJOHH()
	{
		if (!base.enabled || FFIIDKPJDFH != 128)
		{
			return;
		}
		if (restriction != ENJDAMOBMHE.None)
		{
			if (restriction == ENJDAMOBMHE.Horizontal)
			{
				Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE.x) < Mathf.Abs(nDIFPBOFHJE.y))
				{
					return;
				}
			}
			else if (restriction == ENJDAMOBMHE.None)
			{
				Vector2 nDIFPBOFHJE2 = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE2.x) > Mathf.Abs(nDIFPBOFHJE2.y))
				{
					return;
				}
			}
			else if (restriction == ENJDAMOBMHE.Vertical && MLPFOHLMKGB + pressAndHoldDelay > RealTime.GKFNENKKLEJ())
			{
				return;
			}
		}
		if (cloneOnDrag)
		{
			GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.transform.parent.gameObject, base.gameObject);
			gameObject.transform.localPosition = base.transform.localPosition;
			gameObject.transform.localRotation = base.transform.localRotation;
			gameObject.transform.localScale = base.transform.localScale;
			UIButtonColor component = gameObject.GetComponent<UIButtonColor>();
			if (component != null)
			{
				component.NBKHAELMBKJ(GetComponent<UIButtonColor>().CCHLPJJPILL());
			}
			UICamera.currentTouch.ALNIBPBGIKH = gameObject;
			UIDragDropItem component2 = gameObject.GetComponent<UIDragDropItem>();
			component2.Start();
			component2.FJAEDIKKIHD();
		}
		else
		{
			LACFJCGJNPF();
		}
	}

	protected virtual void MFEDCPNAKDN(Vector3 ALBBEKIPKGK)
	{
		NPLHCHNGMKF.localPosition += ALBBEKIPKGK;
	}

	private void FKJJFCGMKAJ(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			MLPFOHLMKGB = RealTime.GKFNENKKLEJ();
		}
	}

	private void PIPACFALKIP()
	{
		if (!base.enabled || FFIIDKPJDFH != -6)
		{
			return;
		}
		if (restriction != ENJDAMOBMHE.None)
		{
			if (restriction == ENJDAMOBMHE.None)
			{
				Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE.x) < Mathf.Abs(nDIFPBOFHJE.y))
				{
					return;
				}
			}
			else if (restriction == (ENJDAMOBMHE)7)
			{
				Vector2 nDIFPBOFHJE2 = UICamera.currentTouch.NDIFPBOFHJE;
				if (Mathf.Abs(nDIFPBOFHJE2.x) > Mathf.Abs(nDIFPBOFHJE2.y))
				{
					return;
				}
			}
			else if (restriction == (ENJDAMOBMHE)6 && MLPFOHLMKGB + pressAndHoldDelay > RealTime.CNPAJAJHLFK())
			{
				return;
			}
		}
		if (cloneOnDrag)
		{
			GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.transform.parent.gameObject, base.gameObject);
			gameObject.transform.localPosition = base.transform.localPosition;
			gameObject.transform.localRotation = base.transform.localRotation;
			gameObject.transform.localScale = base.transform.localScale;
			UIButtonColor component = gameObject.GetComponent<UIButtonColor>();
			if (component != null)
			{
				component.set_defaultColor(GetComponent<UIButtonColor>().get_defaultColor());
			}
			UICamera.currentTouch.ALNIBPBGIKH = gameObject;
			UIDragDropItem component2 = gameObject.GetComponent<UIDragDropItem>();
			component2.PILOBHCDHIK();
			component2.FJAEDIKKIHD();
		}
		else
		{
			LACFJCGJNPF();
		}
	}

	private void KDHBGEDFGDJ(bool JPNFGIEDOMM)
	{
		if (JPNFGIEDOMM)
		{
			MLPFOHLMKGB = RealTime.JNMGIHLPIAG();
		}
	}

	private void GDPOHBPOMNC()
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			ILHGGJOLNCG(UICamera.hoveredObject);
		}
	}

	private void NJAMKBIABDB()
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			AHIDGJGINOA(UICamera.hoveredObject);
		}
	}

	private void HHDIDDCGCAH(Vector2 ALBBEKIPKGK)
	{
		if (base.enabled && FFIIDKPJDFH == UICamera.currentTouchID)
		{
			FNPOBANODOE((Vector3)ALBBEKIPKGK * ONNMDGOJEBB.EHHJIOOMENB());
		}
	}

	protected virtual void FMGCECPDBGC(Vector3 ALBBEKIPKGK)
	{
		NPLHCHNGMKF.localPosition += ALBBEKIPKGK;
	}
}
