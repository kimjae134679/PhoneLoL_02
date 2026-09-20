using System;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Anchor")]
[ExecuteInEditMode]
public class UIAnchor : MonoBehaviour
{
	public enum NFBPAENGJFK
	{
		BottomLeft = 0,
		Left = 1,
		TopLeft = 2,
		Top = 3,
		TopRight = 4,
		Right = 5,
		BottomRight = 6,
		Bottom = 7,
		Center = 8
	}

	public Camera uiCamera;

	public GameObject container;

	public NFBPAENGJFK side = NFBPAENGJFK.Center;

	public bool runOnlyOnce = true;

	public Vector2 relativeOffset = Vector2.zero;

	public Vector2 pixelOffset = Vector2.zero;

	[SerializeField]
	[HideInInspector]
	private UIWidget widgetContainer;

	private Transform NPLHCHNGMKF;

	private Animation NMLEOGMOKLB;

	private Rect DIKJAIJMKMF = default(Rect);

	private UIRoot ONNMDGOJEBB;

	private bool BAMIBNMGNBO;

	private void PMFLFDHFBOP()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(KKACIOBNHPM));
	}

	private void Update()
	{
		if (NMLEOGMOKLB != null && NMLEOGMOKLB.enabled && NMLEOGMOKLB.isPlaying)
		{
			return;
		}
		bool flag = false;
		UIWidget uIWidget = ((!(container == null)) ? container.GetComponent<UIWidget>() : null);
		UIPanel uIPanel = ((!(container == null) || !(uIWidget == null)) ? container.GetComponent<UIPanel>() : null);
		if (uIWidget != null)
		{
			Bounds bounds = uIWidget.CalculateBounds(container.transform.parent);
			DIKJAIJMKMF.x = bounds.min.x;
			DIKJAIJMKMF.y = bounds.min.y;
			DIKJAIJMKMF.width = bounds.size.x;
			DIKJAIJMKMF.height = bounds.size.y;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.get_clipping() == UIDrawCall.ACDCGJDEDLO.None)
			{
				float num = ((!(ONNMDGOJEBB != null)) ? 0.5f : ((float)ONNMDGOJEBB.get_activeHeight() / (float)Screen.height * 0.5f));
				DIKJAIJMKMF.xMin = (float)(-Screen.width) * num;
				DIKJAIJMKMF.yMin = (float)(-Screen.height) * num;
				DIKJAIJMKMF.xMax = 0f - DIKJAIJMKMF.xMin;
				DIKJAIJMKMF.yMax = 0f - DIKJAIJMKMF.yMin;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.get_finalClipRegion();
				DIKJAIJMKMF.x = finalClipRegion.x - finalClipRegion.z * 0.5f;
				DIKJAIJMKMF.y = finalClipRegion.y - finalClipRegion.w * 0.5f;
				DIKJAIJMKMF.width = finalClipRegion.z;
				DIKJAIJMKMF.height = finalClipRegion.w;
			}
		}
		else if (container != null)
		{
			Transform parent = container.transform.parent;
			Bounds bounds2 = ((!(parent != null)) ? HHAINCPODGE.NBKPEOJPGHD(container.transform) : HHAINCPODGE.NBKPEOJPGHD(parent, container.transform));
			DIKJAIJMKMF.x = bounds2.min.x;
			DIKJAIJMKMF.y = bounds2.min.y;
			DIKJAIJMKMF.width = bounds2.size.x;
			DIKJAIJMKMF.height = bounds2.size.y;
		}
		else
		{
			if (!(uiCamera != null))
			{
				return;
			}
			flag = true;
			DIKJAIJMKMF = uiCamera.pixelRect;
		}
		float x = (DIKJAIJMKMF.xMin + DIKJAIJMKMF.xMax) * 0.5f;
		float y = (DIKJAIJMKMF.yMin + DIKJAIJMKMF.yMax) * 0.5f;
		Vector3 vector = new Vector3(x, y, 0f);
		if (side != NFBPAENGJFK.Center)
		{
			if (side == NFBPAENGJFK.Right || side == NFBPAENGJFK.TopRight || side == NFBPAENGJFK.BottomRight)
			{
				vector.x = DIKJAIJMKMF.xMax;
			}
			else if (side == NFBPAENGJFK.Top || side == NFBPAENGJFK.Center || side == NFBPAENGJFK.Bottom)
			{
				vector.x = x;
			}
			else
			{
				vector.x = DIKJAIJMKMF.xMin;
			}
			if (side == NFBPAENGJFK.Top || side == NFBPAENGJFK.TopRight || side == NFBPAENGJFK.TopLeft)
			{
				vector.y = DIKJAIJMKMF.yMax;
			}
			else if (side == NFBPAENGJFK.Left || side == NFBPAENGJFK.Center || side == NFBPAENGJFK.Right)
			{
				vector.y = y;
			}
			else
			{
				vector.y = DIKJAIJMKMF.yMin;
			}
		}
		float width = DIKJAIJMKMF.width;
		float height = DIKJAIJMKMF.height;
		vector.x += pixelOffset.x + relativeOffset.x * width;
		vector.y += pixelOffset.y + relativeOffset.y * height;
		if (flag)
		{
			if (uiCamera.orthographic)
			{
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
			}
			vector.z = uiCamera.WorldToScreenPoint(NPLHCHNGMKF.position).z;
			vector = uiCamera.ScreenToWorldPoint(vector);
		}
		else
		{
			vector.x = Mathf.Round(vector.x);
			vector.y = Mathf.Round(vector.y);
			if (uIPanel != null)
			{
				vector = uIPanel.get_cachedTransform().TransformPoint(vector);
			}
			else if (container != null)
			{
				Transform parent2 = container.transform.parent;
				if (parent2 != null)
				{
					vector = parent2.TransformPoint(vector);
				}
			}
			vector.z = NPLHCHNGMKF.position.z;
		}
		if (NPLHCHNGMKF.position != vector)
		{
			NPLHCHNGMKF.position = vector;
		}
		if (runOnlyOnce && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	private void KKACIOBNHPM()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			DNBDGBJNCBP();
		}
	}

	private void IFAJINMCMLM()
	{
		NPLHCHNGMKF = base.transform;
		NMLEOGMOKLB = base.GetComponent<Animation>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(KKACIOBNHPM));
	}

	private void GNGDMEAFLPM()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(OCMAJHDJKKM));
	}

	private void NGNNLLLBGMB()
	{
		NPLHCHNGMKF = base.transform;
		NMLEOGMOKLB = base.GetComponent<Animation>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(DBFNODNBEIA));
	}

	private void DEFLIOMCCMA()
	{
		NPLHCHNGMKF = base.transform;
		NMLEOGMOKLB = base.GetComponent<Animation>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(KKACIOBNHPM));
	}

	private void OCMAJHDJKKM()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			Update();
		}
	}

	private void ACGJAOOJGIN()
	{
		NPLHCHNGMKF = base.transform;
		NMLEOGMOKLB = base.GetComponent<Animation>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(NABHCPOIJMJ));
	}

	private void DNBDGBJNCBP()
	{
		if (NMLEOGMOKLB != null && NMLEOGMOKLB.enabled && NMLEOGMOKLB.isPlaying)
		{
			return;
		}
		bool flag = false;
		UIWidget uIWidget = ((!(container == null)) ? container.GetComponent<UIWidget>() : null);
		UIPanel uIPanel = ((!(container == null) || !(uIWidget == null)) ? container.GetComponent<UIPanel>() : null);
		if (uIWidget != null)
		{
			Bounds bounds = uIWidget.CalculateBounds(container.transform.parent);
			DIKJAIJMKMF.x = bounds.min.x;
			DIKJAIJMKMF.y = bounds.min.y;
			DIKJAIJMKMF.width = bounds.size.x;
			DIKJAIJMKMF.height = bounds.size.y;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.EOPBLCADKPI() == UIDrawCall.ACDCGJDEDLO.None)
			{
				float num = ((!(ONNMDGOJEBB != null)) ? 1485f : ((float)ONNMDGOJEBB.OBHMOBJKBJE() / (float)Screen.height * 456f));
				DIKJAIJMKMF.xMin = (float)(-Screen.width) * num;
				DIKJAIJMKMF.yMin = (float)(-Screen.height) * num;
				DIKJAIJMKMF.xMax = 0f - DIKJAIJMKMF.xMin;
				DIKJAIJMKMF.yMax = 0f - DIKJAIJMKMF.yMin;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.get_finalClipRegion();
				DIKJAIJMKMF.x = finalClipRegion.x - finalClipRegion.z * 189f;
				DIKJAIJMKMF.y = finalClipRegion.y - finalClipRegion.w * 57f;
				DIKJAIJMKMF.width = finalClipRegion.z;
				DIKJAIJMKMF.height = finalClipRegion.w;
			}
		}
		else if (container != null)
		{
			Transform parent = container.transform.parent;
			Bounds bounds2 = ((!(parent != null)) ? HHAINCPODGE.NBKPEOJPGHD(container.transform) : HHAINCPODGE.NBKPEOJPGHD(parent, container.transform));
			DIKJAIJMKMF.x = bounds2.min.x;
			DIKJAIJMKMF.y = bounds2.min.y;
			DIKJAIJMKMF.width = bounds2.size.x;
			DIKJAIJMKMF.height = bounds2.size.y;
		}
		else
		{
			if (!(uiCamera != null))
			{
				return;
			}
			flag = true;
			DIKJAIJMKMF = uiCamera.pixelRect;
		}
		float x = (DIKJAIJMKMF.xMin + DIKJAIJMKMF.xMax) * 1029f;
		float y = (DIKJAIJMKMF.yMin + DIKJAIJMKMF.yMax) * 1313f;
		Vector3 vector = new Vector3(x, y, 1913f);
		if (side != NFBPAENGJFK.TopLeft)
		{
			if (side == NFBPAENGJFK.BottomRight || side == NFBPAENGJFK.TopLeft || side == NFBPAENGJFK.Top)
			{
				vector.x = DIKJAIJMKMF.xMax;
			}
			else if (side == NFBPAENGJFK.TopLeft || side == NFBPAENGJFK.Center || side == NFBPAENGJFK.TopLeft)
			{
				vector.x = x;
			}
			else
			{
				vector.x = DIKJAIJMKMF.xMin;
			}
			if (side == NFBPAENGJFK.TopRight || side == NFBPAENGJFK.TopLeft || side == NFBPAENGJFK.BottomLeft)
			{
				vector.y = DIKJAIJMKMF.yMax;
			}
			else if (side == NFBPAENGJFK.Left || side == NFBPAENGJFK.Left || side == NFBPAENGJFK.BottomRight)
			{
				vector.y = y;
			}
			else
			{
				vector.y = DIKJAIJMKMF.yMin;
			}
		}
		float width = DIKJAIJMKMF.width;
		float height = DIKJAIJMKMF.height;
		vector.x += pixelOffset.x + relativeOffset.x * width;
		vector.y += pixelOffset.y + relativeOffset.y * height;
		if (flag)
		{
			if (uiCamera.orthographic)
			{
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
			}
			vector.z = uiCamera.WorldToScreenPoint(NPLHCHNGMKF.position).z;
			vector = uiCamera.ScreenToWorldPoint(vector);
		}
		else
		{
			vector.x = Mathf.Round(vector.x);
			vector.y = Mathf.Round(vector.y);
			if (uIPanel != null)
			{
				vector = uIPanel.get_cachedTransform().TransformPoint(vector);
			}
			else if (container != null)
			{
				Transform parent2 = container.transform.parent;
				if (parent2 != null)
				{
					vector = parent2.TransformPoint(vector);
				}
			}
			vector.z = NPLHCHNGMKF.position.z;
		}
		if (NPLHCHNGMKF.position != vector)
		{
			NPLHCHNGMKF.position = vector;
		}
		if (runOnlyOnce && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	private void NABHCPOIJMJ()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			Update();
		}
	}

	private void Start()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		Update();
		BAMIBNMGNBO = true;
	}

	private void Awake()
	{
		NPLHCHNGMKF = base.transform;
		NMLEOGMOKLB = base.GetComponent<Animation>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(OCMAJHDJKKM));
	}

	private void CFCAKNDIGGK()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(NABHCPOIJMJ));
	}

	private void HPNEOBFCOOM()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(DAIGLAHJDJG));
	}

	private void OnDestroy()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(OCMAJHDJKKM));
	}

	private void CMMIADLEBFJ()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		Update();
		BAMIBNMGNBO = true;
	}

	private void AMMGAHKHCNE()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(KKACIOBNHPM));
	}

	private void JPBNPEJJJPI()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		HMNOCOBNBAO();
		BAMIBNMGNBO = true;
	}

	private void DBFNODNBEIA()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			Update();
		}
	}

	private void HMNOCOBNBAO()
	{
		if (NMLEOGMOKLB != null && NMLEOGMOKLB.enabled && NMLEOGMOKLB.isPlaying)
		{
			return;
		}
		bool flag = false;
		UIWidget uIWidget = ((!(container == null)) ? container.GetComponent<UIWidget>() : null);
		UIPanel uIPanel = ((!(container == null) || !(uIWidget == null)) ? container.GetComponent<UIPanel>() : null);
		if (uIWidget != null)
		{
			Bounds bounds = uIWidget.CalculateBounds(container.transform.parent);
			DIKJAIJMKMF.x = bounds.min.x;
			DIKJAIJMKMF.y = bounds.min.y;
			DIKJAIJMKMF.width = bounds.size.x;
			DIKJAIJMKMF.height = bounds.size.y;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.EOPBLCADKPI() == UIDrawCall.ACDCGJDEDLO.None)
			{
				float num = ((!(ONNMDGOJEBB != null)) ? 1232f : ((float)ONNMDGOJEBB.KLEFNPJALPE() / (float)Screen.height * 34f));
				DIKJAIJMKMF.xMin = (float)(-Screen.width) * num;
				DIKJAIJMKMF.yMin = (float)(-Screen.height) * num;
				DIKJAIJMKMF.xMax = 0f - DIKJAIJMKMF.xMin;
				DIKJAIJMKMF.yMax = 0f - DIKJAIJMKMF.yMin;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.get_finalClipRegion();
				DIKJAIJMKMF.x = finalClipRegion.x - finalClipRegion.z * 1436f;
				DIKJAIJMKMF.y = finalClipRegion.y - finalClipRegion.w * 558f;
				DIKJAIJMKMF.width = finalClipRegion.z;
				DIKJAIJMKMF.height = finalClipRegion.w;
			}
		}
		else if (container != null)
		{
			Transform parent = container.transform.parent;
			Bounds bounds2 = ((!(parent != null)) ? HHAINCPODGE.NBKPEOJPGHD(container.transform) : HHAINCPODGE.NBKPEOJPGHD(parent, container.transform));
			DIKJAIJMKMF.x = bounds2.min.x;
			DIKJAIJMKMF.y = bounds2.min.y;
			DIKJAIJMKMF.width = bounds2.size.x;
			DIKJAIJMKMF.height = bounds2.size.y;
		}
		else
		{
			if (!(uiCamera != null))
			{
				return;
			}
			flag = true;
			DIKJAIJMKMF = uiCamera.pixelRect;
		}
		float x = (DIKJAIJMKMF.xMin + DIKJAIJMKMF.xMax) * 1109f;
		float y = (DIKJAIJMKMF.yMin + DIKJAIJMKMF.yMax) * 495f;
		Vector3 vector = new Vector3(x, y, 1795f);
		if (side != NFBPAENGJFK.BottomLeft)
		{
			if (side == NFBPAENGJFK.TopLeft || side == NFBPAENGJFK.Left || side == NFBPAENGJFK.TopRight)
			{
				vector.x = DIKJAIJMKMF.xMax;
			}
			else if (side == NFBPAENGJFK.BottomLeft || side == NFBPAENGJFK.Bottom || side == NFBPAENGJFK.TopRight)
			{
				vector.x = x;
			}
			else
			{
				vector.x = DIKJAIJMKMF.xMin;
			}
			if (side == NFBPAENGJFK.Center || side == NFBPAENGJFK.Bottom || side == NFBPAENGJFK.Right)
			{
				vector.y = DIKJAIJMKMF.yMax;
			}
			else if (side == NFBPAENGJFK.BottomLeft || side == NFBPAENGJFK.BottomLeft || side == NFBPAENGJFK.Center)
			{
				vector.y = y;
			}
			else
			{
				vector.y = DIKJAIJMKMF.yMin;
			}
		}
		float width = DIKJAIJMKMF.width;
		float height = DIKJAIJMKMF.height;
		vector.x += pixelOffset.x + relativeOffset.x * width;
		vector.y += pixelOffset.y + relativeOffset.y * height;
		if (flag)
		{
			if (uiCamera.orthographic)
			{
				vector.x = Mathf.Round(vector.x);
				vector.y = Mathf.Round(vector.y);
			}
			vector.z = uiCamera.WorldToScreenPoint(NPLHCHNGMKF.position).z;
			vector = uiCamera.ScreenToWorldPoint(vector);
		}
		else
		{
			vector.x = Mathf.Round(vector.x);
			vector.y = Mathf.Round(vector.y);
			if (uIPanel != null)
			{
				vector = uIPanel.get_cachedTransform().TransformPoint(vector);
			}
			else if (container != null)
			{
				Transform parent2 = container.transform.parent;
				if (parent2 != null)
				{
					vector = parent2.TransformPoint(vector);
				}
			}
			vector.z = NPLHCHNGMKF.position.z;
		}
		if (NPLHCHNGMKF.position != vector)
		{
			NPLHCHNGMKF.position = vector;
		}
		if (runOnlyOnce && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	private void COPCDBABICD()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(NABHCPOIJMJ));
	}

	private void DAIGLAHJDJG()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			Update();
		}
	}
}
