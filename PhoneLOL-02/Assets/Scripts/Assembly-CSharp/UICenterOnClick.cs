using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Center Scroll View on Click")]
public class UICenterOnClick : MonoBehaviour
{
	private void GIGCDPFPOKK()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.LNJOMEEDGFJ(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.EOPBLCADKPI() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.COBNOGAECME())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.AIADFIFJNOF(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 1480f);
		}
	}

	private void KEEJHLDEHAJ()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.NEGAACAKCGL(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.get_clipping() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.COBNOGAECME())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.NHBCPCFLMBL(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 1789f);
		}
	}

	private void BOJEFAHLEFP()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.NEGAACAKCGL(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.EOPBLCADKPI() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.LFAOACONLGM())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.GHOKHJDJMCD(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 209f);
		}
	}

	private void KCBLKLMPNII()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.NEGAACAKCGL(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.EOPBLCADKPI() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.HEABABABELL())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.BAJKKKBAMPC(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 1916f);
		}
	}

	private void KNPIKGJDOLJ()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.CenterOn(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.EOPBLCADKPI() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.COBNOGAECME())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.EOGPMFCILOP(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 262f);
		}
	}

	private void HHKILFJHIKF()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.CenterOn(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.EOPBLCADKPI() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.HEABABABELL())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.GHOKHJDJMCD(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 1196f);
		}
	}

	private void OnClick()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.CenterOn(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.get_clipping() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.get_canMoveHorizontally())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.Begin(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 6f);
		}
	}

	private void PHKIDDNBBHB()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.ABGCPMCEAFK(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.EOPBLCADKPI() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.HEABABABELL())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.Begin(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 650f);
		}
	}

	private void LJNHGILPEDC()
	{
		UICenterOnChild uICenterOnChild = NLDABIMKKMP.ANPDHFFNJFD<UICenterOnChild>(base.gameObject);
		UIPanel uIPanel = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		if (uICenterOnChild != null)
		{
			if (uICenterOnChild.enabled)
			{
				uICenterOnChild.ABGCPMCEAFK(base.transform);
			}
		}
		else if (uIPanel != null && uIPanel.get_clipping() != UIDrawCall.ACDCGJDEDLO.None)
		{
			UIScrollView component = uIPanel.GetComponent<UIScrollView>();
			Vector3 hEPNHCEIFMO = -uIPanel.get_cachedTransform().InverseTransformPoint(base.transform.position);
			if (!component.LFAOACONLGM())
			{
				hEPNHCEIFMO.x = uIPanel.get_cachedTransform().localPosition.x;
			}
			if (!component.get_canMoveVertically())
			{
				hEPNHCEIFMO.y = uIPanel.get_cachedTransform().localPosition.y;
			}
			SpringPanel.GHOKHJDJMCD(uIPanel.get_cachedGameObject(), hEPNHCEIFMO, 1854f);
		}
	}
}
