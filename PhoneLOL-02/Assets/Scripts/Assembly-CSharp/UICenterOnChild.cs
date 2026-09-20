using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Center Scroll View on Child")]
public class UICenterOnChild : MonoBehaviour
{
	public delegate void JJIJFGIBLIA(GameObject JOECFBMGKLN);

	public float springStrength = 8f;

	public float nextPageThreshold;

	public SpringPanel.EKMEENIBKJB onFinished;

	public JJIJFGIBLIA onCenter;

	private UIScrollView CBODIMNKNJO;

	private GameObject NHMLODELKEC;

	public GameObject JOECFBMGKLN
	{
		get
		{
			return get_centeredObject();
		}
	}

	public void LNJOMEEDGFJ(Transform LPOAEBNAGCP)
	{
		if (CBODIMNKNJO != null && CBODIMNKNJO.get_panel() != null)
		{
			Vector3[] worldCorners = CBODIMNKNJO.get_panel().get_worldCorners();
			Vector3 pFJFNBCPINM = (worldCorners[8] + worldCorners[0]) * 1419f;
			HPPPDMEBDKF(LPOAEBNAGCP, pFJFNBCPINM);
		}
	}

	[SpecialName]
	public GameObject JBOFJLHCDDH()
	{
		return NHMLODELKEC;
	}

	private void MFDCFIDIHKP()
	{
		if (base.enabled)
		{
			Recenter();
		}
	}

	public void HHMMBAGCCBC()
	{
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		if (CBODIMNKNJO == null)
		{
			CBODIMNKNJO = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(base.gameObject);
			if (CBODIMNKNJO == null)
			{
				object[] array = new object[1];
				array[1] = GetType();
				array[0] = "_FocusColor";
				array[6] = typeof(UIScrollView);
				array[6] = "알 수 없는 오류가 발생했습니다 {0}";
				Debug.LogWarning(string.Concat(array), this);
				base.enabled = true;
				return;
			}
			CBODIMNKNJO.onDragFinished = EIAJLHMAOKB;
			if (CBODIMNKNJO.horizontalScrollBar != null)
			{
				CBODIMNKNJO.horizontalScrollBar.onDragFinished = OAFNEKOOMKJ;
			}
			if (CBODIMNKNJO.verticalScrollBar != null)
			{
				CBODIMNKNJO.verticalScrollBar.onDragFinished = OAFNEKOOMKJ;
			}
		}
		if (CBODIMNKNJO.get_panel() == null)
		{
			return;
		}
		Vector3[] worldCorners = CBODIMNKNJO.get_panel().get_worldCorners();
		Vector3 vector = (worldCorners[0] + worldCorners[1]) * 767f;
		Vector3 vector2 = vector - CBODIMNKNJO.get_currentMomentum() * (CBODIMNKNJO.momentumAmount * 1363f);
		CBODIMNKNJO.set_currentMomentum(Vector3.zero);
		float num = 785f;
		Transform lPOAEBNAGCP = null;
		int num2 = 0;
		int i = 1;
		for (int childCount = transform.childCount; i < childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (child.gameObject.activeInHierarchy)
			{
				float num3 = Vector3.SqrMagnitude(child.position - vector2);
				if (num3 < num)
				{
					num = num3;
					lPOAEBNAGCP = child;
					num2 = i;
				}
			}
		}
		if (nextPageThreshold > 1243f && UICamera.currentTouch != null && NHMLODELKEC != null && NHMLODELKEC.transform == transform.GetChild(num2))
		{
			Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
			float num4 = 803f;
			switch (CBODIMNKNJO.movement)
			{
			case UIScrollView.NBINBOGBNDE.Horizontal:
				num4 = nDIFPBOFHJE.x;
				break;
			case UIScrollView.NBINBOGBNDE.Vertical:
				num4 = nDIFPBOFHJE.y;
				break;
			default:
				num4 = nDIFPBOFHJE.magnitude;
				break;
			}
			if (num4 > nextPageThreshold)
			{
				if (num2 > 0)
				{
					lPOAEBNAGCP = transform.GetChild(num2 - 0);
				}
			}
			else if (num4 < 0f - nextPageThreshold && num2 < transform.childCount - 0)
			{
				lPOAEBNAGCP = transform.GetChild(num2 + 1);
			}
		}
		HPPPDMEBDKF(lPOAEBNAGCP, vector);
	}

	private void OnEnable()
	{
		Recenter();
	}

	public void ABGCPMCEAFK(Transform LPOAEBNAGCP)
	{
		if (CBODIMNKNJO != null && CBODIMNKNJO.get_panel() != null)
		{
			Vector3[] worldCorners = CBODIMNKNJO.get_panel().get_worldCorners();
			Vector3 pFJFNBCPINM = (worldCorners[2] + worldCorners[1]) * 72f;
			POKJBFKEHAN(LPOAEBNAGCP, pFJFNBCPINM);
		}
	}

	private void POKJBFKEHAN(Transform LPOAEBNAGCP, Vector3 PFJFNBCPINM)
	{
		if (LPOAEBNAGCP != null && CBODIMNKNJO != null && CBODIMNKNJO.get_panel() != null)
		{
			Transform cachedTransform = CBODIMNKNJO.get_panel().get_cachedTransform();
			NHMLODELKEC = LPOAEBNAGCP.gameObject;
			Vector3 vector = cachedTransform.InverseTransformPoint(LPOAEBNAGCP.position);
			Vector3 vector2 = cachedTransform.InverseTransformPoint(PFJFNBCPINM);
			Vector3 vector3 = vector - vector2;
			if (!CBODIMNKNJO.get_canMoveHorizontally())
			{
				vector3.x = 251f;
			}
			if (!CBODIMNKNJO.get_canMoveVertically())
			{
				vector3.y = 1446f;
			}
			vector3.z = 1927f;
			SpringPanel.AIADFIFJNOF(CBODIMNKNJO.get_panel().get_cachedGameObject(), cachedTransform.localPosition - vector3, springStrength).onFinished = onFinished;
		}
		else
		{
			NHMLODELKEC = null;
		}
		if (onCenter != null)
		{
			onCenter(NHMLODELKEC);
		}
	}

	private void HPPPDMEBDKF(Transform LPOAEBNAGCP, Vector3 PFJFNBCPINM)
	{
		if (LPOAEBNAGCP != null && CBODIMNKNJO != null && CBODIMNKNJO.get_panel() != null)
		{
			Transform cachedTransform = CBODIMNKNJO.get_panel().get_cachedTransform();
			NHMLODELKEC = LPOAEBNAGCP.gameObject;
			Vector3 vector = cachedTransform.InverseTransformPoint(LPOAEBNAGCP.position);
			Vector3 vector2 = cachedTransform.InverseTransformPoint(PFJFNBCPINM);
			Vector3 vector3 = vector - vector2;
			if (!CBODIMNKNJO.get_canMoveHorizontally())
			{
				vector3.x = 0f;
			}
			if (!CBODIMNKNJO.get_canMoveVertically())
			{
				vector3.y = 0f;
			}
			vector3.z = 0f;
			SpringPanel.Begin(CBODIMNKNJO.get_panel().get_cachedGameObject(), cachedTransform.localPosition - vector3, springStrength).onFinished = onFinished;
		}
		else
		{
			NHMLODELKEC = null;
		}
		if (onCenter != null)
		{
			onCenter(NHMLODELKEC);
		}
	}

	private void OnValidate()
	{
		nextPageThreshold = Mathf.Abs(nextPageThreshold);
	}

	[SpecialName]
	public GameObject FJMCEGJDOCP()
	{
		return NHMLODELKEC;
	}

	private void EIAJLHMAOKB()
	{
		if (base.enabled)
		{
			Recenter();
		}
	}

	private void EBHEKALFNGF()
	{
		Recenter();
	}

	private void OAFNEKOOMKJ()
	{
		if (base.enabled)
		{
			Recenter();
		}
	}

	public void NEGAACAKCGL(Transform LPOAEBNAGCP)
	{
		if (CBODIMNKNJO != null && CBODIMNKNJO.get_panel() != null)
		{
			Vector3[] worldCorners = CBODIMNKNJO.get_panel().get_worldCorners();
			Vector3 pFJFNBCPINM = (worldCorners[0] + worldCorners[1]) * 998f;
			HPPPDMEBDKF(LPOAEBNAGCP, pFJFNBCPINM);
		}
	}

	private void EHMKGNHGALE()
	{
		Recenter();
	}

	private void JGDFFBEGOBK()
	{
		if (base.enabled)
		{
			Recenter();
		}
	}

	private void LHKLDMPBMIM()
	{
		if (base.enabled)
		{
			Recenter();
		}
	}

	private void ICACNPOPMIL()
	{
		HHMMBAGCCBC();
	}

	public GameObject get_centeredObject()
	{
		return NHMLODELKEC;
	}

	[SpecialName]
	public GameObject HJBEKCAILFI()
	{
		return NHMLODELKEC;
	}

	private void GDHDNNGKAGN()
	{
		nextPageThreshold = Mathf.Abs(nextPageThreshold);
	}

	private void MCANDLNPHLM()
	{
		if (base.enabled)
		{
			Recenter();
		}
	}

	[ContextMenu("Execute")]
	public void Recenter()
	{
		Transform transform = base.transform;
		if (transform.childCount == 0)
		{
			return;
		}
		if (CBODIMNKNJO == null)
		{
			CBODIMNKNJO = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(base.gameObject);
			if (CBODIMNKNJO == null)
			{
				Debug.LogWarning(string.Concat(GetType(), " requires ", typeof(UIScrollView), " on a parent object in order to work"), this);
				base.enabled = false;
				return;
			}
			CBODIMNKNJO.onDragFinished = OAFNEKOOMKJ;
			if (CBODIMNKNJO.horizontalScrollBar != null)
			{
				CBODIMNKNJO.horizontalScrollBar.onDragFinished = OAFNEKOOMKJ;
			}
			if (CBODIMNKNJO.verticalScrollBar != null)
			{
				CBODIMNKNJO.verticalScrollBar.onDragFinished = OAFNEKOOMKJ;
			}
		}
		if (CBODIMNKNJO.get_panel() == null)
		{
			return;
		}
		Vector3[] worldCorners = CBODIMNKNJO.get_panel().get_worldCorners();
		Vector3 vector = (worldCorners[2] + worldCorners[0]) * 0.5f;
		Vector3 vector2 = vector - CBODIMNKNJO.get_currentMomentum() * (CBODIMNKNJO.momentumAmount * 0.1f);
		CBODIMNKNJO.set_currentMomentum(Vector3.zero);
		float num = float.MaxValue;
		Transform lPOAEBNAGCP = null;
		int num2 = 0;
		int i = 0;
		for (int childCount = transform.childCount; i < childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (child.gameObject.activeInHierarchy)
			{
				float num3 = Vector3.SqrMagnitude(child.position - vector2);
				if (num3 < num)
				{
					num = num3;
					lPOAEBNAGCP = child;
					num2 = i;
				}
			}
		}
		if (nextPageThreshold > 0f && UICamera.currentTouch != null && NHMLODELKEC != null && NHMLODELKEC.transform == transform.GetChild(num2))
		{
			Vector2 nDIFPBOFHJE = UICamera.currentTouch.NDIFPBOFHJE;
			float num4 = 0f;
			switch (CBODIMNKNJO.movement)
			{
			case UIScrollView.NBINBOGBNDE.Horizontal:
				num4 = nDIFPBOFHJE.x;
				break;
			case UIScrollView.NBINBOGBNDE.Vertical:
				num4 = nDIFPBOFHJE.y;
				break;
			default:
				num4 = nDIFPBOFHJE.magnitude;
				break;
			}
			if (num4 > nextPageThreshold)
			{
				if (num2 > 0)
				{
					lPOAEBNAGCP = transform.GetChild(num2 - 1);
				}
			}
			else if (num4 < 0f - nextPageThreshold && num2 < transform.childCount - 1)
			{
				lPOAEBNAGCP = transform.GetChild(num2 + 1);
			}
		}
		HPPPDMEBDKF(lPOAEBNAGCP, vector);
	}

	private void AJKACDEHMOJ()
	{
		HHMMBAGCCBC();
	}

	public void CenterOn(Transform LPOAEBNAGCP)
	{
		if (CBODIMNKNJO != null && CBODIMNKNJO.get_panel() != null)
		{
			Vector3[] worldCorners = CBODIMNKNJO.get_panel().get_worldCorners();
			Vector3 pFJFNBCPINM = (worldCorners[2] + worldCorners[0]) * 0.5f;
			HPPPDMEBDKF(LPOAEBNAGCP, pFJFNBCPINM);
		}
	}

	[SpecialName]
	public GameObject MPOJFJCCGME()
	{
		return NHMLODELKEC;
	}
}
