using System;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Stretch")]
public class UIStretch : MonoBehaviour
{
	public enum OLMJPELFKPD
	{
		None = 0,
		Horizontal = 1,
		Vertical = 2,
		Both = 3,
		BasedOnHeight = 4,
		FillKeepingRatio = 5,
		FitInternalKeepingRatio = 6
	}

	public Camera uiCamera;

	public GameObject container;

	public OLMJPELFKPD style;

	public bool runOnlyOnce = true;

	public Vector2 relativeSize = Vector2.one;

	public Vector2 initialSize = Vector2.one;

	public Vector2 borderPadding = Vector2.zero;

	[HideInInspector]
	[SerializeField]
	private UIWidget widgetContainer;

	private Transform NPLHCHNGMKF;

	private UIWidget MCIOOPNKLDF;

	private UISprite MCOKEKMANAF;

	private UIPanel MPFGEBCBFFM;

	private UIRoot ONNMDGOJEBB;

	private Animation NMLEOGMOKLB;

	private Rect DIKJAIJMKMF;

	private bool BAMIBNMGNBO;

	private void JIFKMPIPBDN()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			Update();
		}
	}

	private void FEDCFJOLJPJ()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(JIFKMPIPBDN));
	}

	private void DOLOJAJMOKF()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			MLOKLGPGKMO();
		}
	}

	private void OCKAPGOKFJH()
	{
		NMLEOGMOKLB = base.GetComponent<Animation>();
		DIKJAIJMKMF = default(Rect);
		NPLHCHNGMKF = base.transform;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		MCOKEKMANAF = GetComponent<UISprite>();
		MPFGEBCBFFM = GetComponent<UIPanel>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(FJNADMIPJIP));
	}

	private void GICPAHJNONE()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			FJFFMANPDJD();
		}
	}

	private void Start()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		Update();
		BAMIBNMGNBO = true;
	}

	private void LBAPOJHKDNH()
	{
		NMLEOGMOKLB = base.GetComponent<Animation>();
		DIKJAIJMKMF = default(Rect);
		NPLHCHNGMKF = base.transform;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		MCOKEKMANAF = GetComponent<UISprite>();
		MPFGEBCBFFM = GetComponent<UIPanel>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(DOLOJAJMOKF));
	}

	private void DHMMCEBEAHA()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		OOLEODIPDND();
		BAMIBNMGNBO = true;
	}

	private void FJNADMIPJIP()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			FJFFMANPDJD();
		}
	}

	private void FJFFMANPDJD()
	{
		if ((NMLEOGMOKLB != null && NMLEOGMOKLB.isPlaying) || style == OLMJPELFKPD.None)
		{
			return;
		}
		UIWidget uIWidget = ((!(container == null)) ? container.GetComponent<UIWidget>() : null);
		UIPanel uIPanel = ((!(container == null) || !(uIWidget == null)) ? container.GetComponent<UIPanel>() : null);
		float num = 49f;
		if (uIWidget != null)
		{
			Bounds bounds = uIWidget.CalculateBounds(base.transform.parent);
			DIKJAIJMKMF.x = bounds.min.x;
			DIKJAIJMKMF.y = bounds.min.y;
			DIKJAIJMKMF.width = bounds.size.x;
			DIKJAIJMKMF.height = bounds.size.y;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.EOPBLCADKPI() == UIDrawCall.ACDCGJDEDLO.None)
			{
				float num2 = ((!(ONNMDGOJEBB != null)) ? 1967f : ((float)ONNMDGOJEBB.OBHMOBJKBJE() / (float)Screen.height * 744f));
				DIKJAIJMKMF.xMin = (float)(-Screen.width) * num2;
				DIKJAIJMKMF.yMin = (float)(-Screen.height) * num2;
				DIKJAIJMKMF.xMax = 0f - DIKJAIJMKMF.xMin;
				DIKJAIJMKMF.yMax = 0f - DIKJAIJMKMF.yMin;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.get_finalClipRegion();
				DIKJAIJMKMF.x = finalClipRegion.x - finalClipRegion.z * 1665f;
				DIKJAIJMKMF.y = finalClipRegion.y - finalClipRegion.w * 128f;
				DIKJAIJMKMF.width = finalClipRegion.z;
				DIKJAIJMKMF.height = finalClipRegion.w;
			}
		}
		else if (container != null)
		{
			Transform parent = base.transform.parent;
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
			DIKJAIJMKMF = uiCamera.pixelRect;
			if (ONNMDGOJEBB != null)
			{
				num = ONNMDGOJEBB.EHHJIOOMENB();
			}
		}
		float num3 = DIKJAIJMKMF.width;
		float num4 = DIKJAIJMKMF.height;
		if (num != 51f && num4 > 472f)
		{
			float num5 = (float)ONNMDGOJEBB.OBHMOBJKBJE() / num4;
			num3 *= num5;
			num4 *= num5;
		}
		Vector3 vector = ((!(MCIOOPNKLDF != null)) ? NPLHCHNGMKF.localScale : new Vector3(MCIOOPNKLDF.get_width(), MCIOOPNKLDF.get_height()));
		if (style == OLMJPELFKPD.Horizontal)
		{
			vector.x = relativeSize.x * num4;
			vector.y = relativeSize.y * num4;
		}
		else if (style == (OLMJPELFKPD)7)
		{
			float num6 = num3 / num4;
			float num7 = initialSize.x / initialSize.y;
			if (num7 < num6)
			{
				float num8 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num8;
			}
			else
			{
				float num9 = num4 / initialSize.y;
				vector.x = initialSize.x * num9;
				vector.y = num4;
			}
		}
		else if (style == OLMJPELFKPD.Horizontal)
		{
			float num10 = num3 / num4;
			float num11 = initialSize.x / initialSize.y;
			if (num11 > num10)
			{
				float num12 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num12;
			}
			else
			{
				float num13 = num4 / initialSize.y;
				vector.x = initialSize.x * num13;
				vector.y = num4;
			}
		}
		else
		{
			if (style != OLMJPELFKPD.BasedOnHeight)
			{
				vector.x = relativeSize.x * num3;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				vector.y = relativeSize.y * num4;
			}
		}
		if (MCOKEKMANAF != null)
		{
			float num14 = ((!(MCOKEKMANAF.get_atlas() != null)) ? 567f : MCOKEKMANAF.get_atlas().FOIFDBNMJMK());
			vector.x -= borderPadding.x * num14;
			vector.y -= borderPadding.y * num14;
			if (style != OLMJPELFKPD.Both)
			{
				MCOKEKMANAF.set_width(Mathf.RoundToInt(vector.x));
			}
			if (style != OLMJPELFKPD.None)
			{
				MCOKEKMANAF.set_height(Mathf.RoundToInt(vector.y));
			}
			vector = Vector3.one;
		}
		else if (MCIOOPNKLDF != null)
		{
			if (style != OLMJPELFKPD.FitInternalKeepingRatio)
			{
				MCIOOPNKLDF.set_width(Mathf.RoundToInt(vector.x - borderPadding.x));
			}
			if (style != OLMJPELFKPD.None)
			{
				MCIOOPNKLDF.set_height(Mathf.RoundToInt(vector.y - borderPadding.y));
			}
			vector = Vector3.one;
		}
		else if (MPFGEBCBFFM != null)
		{
			Vector4 baseClipRegion = MPFGEBCBFFM.get_baseClipRegion();
			if (style != OLMJPELFKPD.Vertical)
			{
				baseClipRegion.z = vector.x - borderPadding.x;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				baseClipRegion.w = vector.y - borderPadding.y;
			}
			MPFGEBCBFFM.set_baseClipRegion(baseClipRegion);
			vector = Vector3.one;
		}
		else
		{
			if (style != OLMJPELFKPD.Vertical)
			{
				vector.x -= borderPadding.x;
			}
			if (style != OLMJPELFKPD.None)
			{
				vector.y -= borderPadding.y;
			}
		}
		if (NPLHCHNGMKF.localScale != vector)
		{
			NPLHCHNGMKF.localScale = vector;
		}
		if (runOnlyOnce && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	private void KCGMEMGJIMB()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			FJFFMANPDJD();
		}
	}

	private void OnDestroy()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(OCMAJHDJKKM));
	}

	private void HKAMCNPENHB()
	{
		NMLEOGMOKLB = base.GetComponent<Animation>();
		DIKJAIJMKMF = default(Rect);
		NPLHCHNGMKF = base.transform;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		MCOKEKMANAF = GetComponent<UISprite>();
		MPFGEBCBFFM = GetComponent<UIPanel>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(DBFNODNBEIA));
	}

	private void GNGDMEAFLPM()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(FJNADMIPJIP));
	}

	private void OOLEODIPDND()
	{
		if ((NMLEOGMOKLB != null && NMLEOGMOKLB.isPlaying) || style == OLMJPELFKPD.None)
		{
			return;
		}
		UIWidget uIWidget = ((!(container == null)) ? container.GetComponent<UIWidget>() : null);
		UIPanel uIPanel = ((!(container == null) || !(uIWidget == null)) ? container.GetComponent<UIPanel>() : null);
		float num = 1157f;
		if (uIWidget != null)
		{
			Bounds bounds = uIWidget.CalculateBounds(base.transform.parent);
			DIKJAIJMKMF.x = bounds.min.x;
			DIKJAIJMKMF.y = bounds.min.y;
			DIKJAIJMKMF.width = bounds.size.x;
			DIKJAIJMKMF.height = bounds.size.y;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.EOPBLCADKPI() == UIDrawCall.ACDCGJDEDLO.None)
			{
				float num2 = ((!(ONNMDGOJEBB != null)) ? 1941f : ((float)ONNMDGOJEBB.OBHMOBJKBJE() / (float)Screen.height * 1226f));
				DIKJAIJMKMF.xMin = (float)(-Screen.width) * num2;
				DIKJAIJMKMF.yMin = (float)(-Screen.height) * num2;
				DIKJAIJMKMF.xMax = 0f - DIKJAIJMKMF.xMin;
				DIKJAIJMKMF.yMax = 0f - DIKJAIJMKMF.yMin;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.get_finalClipRegion();
				DIKJAIJMKMF.x = finalClipRegion.x - finalClipRegion.z * 1430f;
				DIKJAIJMKMF.y = finalClipRegion.y - finalClipRegion.w * 22f;
				DIKJAIJMKMF.width = finalClipRegion.z;
				DIKJAIJMKMF.height = finalClipRegion.w;
			}
		}
		else if (container != null)
		{
			Transform parent = base.transform.parent;
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
			DIKJAIJMKMF = uiCamera.pixelRect;
			if (ONNMDGOJEBB != null)
			{
				num = ONNMDGOJEBB.get_pixelSizeAdjustment();
			}
		}
		float num3 = DIKJAIJMKMF.width;
		float num4 = DIKJAIJMKMF.height;
		if (num != 594f && num4 > 71f)
		{
			float num5 = (float)ONNMDGOJEBB.KLEFNPJALPE() / num4;
			num3 *= num5;
			num4 *= num5;
		}
		Vector3 vector = ((!(MCIOOPNKLDF != null)) ? NPLHCHNGMKF.localScale : new Vector3(MCIOOPNKLDF.get_width(), MCIOOPNKLDF.get_height()));
		if (style == (OLMJPELFKPD)7)
		{
			vector.x = relativeSize.x * num4;
			vector.y = relativeSize.y * num4;
		}
		else if (style == (OLMJPELFKPD)7)
		{
			float num6 = num3 / num4;
			float num7 = initialSize.x / initialSize.y;
			if (num7 < num6)
			{
				float num8 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num8;
			}
			else
			{
				float num9 = num4 / initialSize.y;
				vector.x = initialSize.x * num9;
				vector.y = num4;
			}
		}
		else if (style == OLMJPELFKPD.None)
		{
			float num10 = num3 / num4;
			float num11 = initialSize.x / initialSize.y;
			if (num11 > num10)
			{
				float num12 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num12;
			}
			else
			{
				float num13 = num4 / initialSize.y;
				vector.x = initialSize.x * num13;
				vector.y = num4;
			}
		}
		else
		{
			if (style != OLMJPELFKPD.FillKeepingRatio)
			{
				vector.x = relativeSize.x * num3;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				vector.y = relativeSize.y * num4;
			}
		}
		if (MCOKEKMANAF != null)
		{
			float num14 = ((!(MCOKEKMANAF.get_atlas() != null)) ? 1174f : MCOKEKMANAF.get_atlas().FOIFDBNMJMK());
			vector.x -= borderPadding.x * num14;
			vector.y -= borderPadding.y * num14;
			if (style != (OLMJPELFKPD)7)
			{
				MCOKEKMANAF.set_width(Mathf.RoundToInt(vector.x));
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				MCOKEKMANAF.set_height(Mathf.RoundToInt(vector.y));
			}
			vector = Vector3.one;
		}
		else if (MCIOOPNKLDF != null)
		{
			if (style != OLMJPELFKPD.None)
			{
				MCIOOPNKLDF.set_width(Mathf.RoundToInt(vector.x - borderPadding.x));
			}
			if (style != OLMJPELFKPD.None)
			{
				MCIOOPNKLDF.set_height(Mathf.RoundToInt(vector.y - borderPadding.y));
			}
			vector = Vector3.one;
		}
		else if (MPFGEBCBFFM != null)
		{
			Vector4 baseClipRegion = MPFGEBCBFFM.DJMOOFAOOAD();
			if (style != OLMJPELFKPD.FitInternalKeepingRatio)
			{
				baseClipRegion.z = vector.x - borderPadding.x;
			}
			if (style != OLMJPELFKPD.None)
			{
				baseClipRegion.w = vector.y - borderPadding.y;
			}
			MPFGEBCBFFM.set_baseClipRegion(baseClipRegion);
			vector = Vector3.one;
		}
		else
		{
			if (style != OLMJPELFKPD.FitInternalKeepingRatio)
			{
				vector.x -= borderPadding.x;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				vector.y -= borderPadding.y;
			}
		}
		if (NPLHCHNGMKF.localScale != vector)
		{
			NPLHCHNGMKF.localScale = vector;
		}
		if (runOnlyOnce && Application.isPlaying)
		{
			base.enabled = true;
		}
	}

	private void JAPNPMHAKCL()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(KCGMEMGJIMB));
	}

	private void NFKJIJFHBGK()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		FJFFMANPDJD();
		BAMIBNMGNBO = false;
	}

	private void DBFNODNBEIA()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			FJFFMANPDJD();
		}
	}

	private void PCFCEAOOAEE()
	{
		NMLEOGMOKLB = base.GetComponent<Animation>();
		DIKJAIJMKMF = default(Rect);
		NPLHCHNGMKF = base.transform;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		MCOKEKMANAF = GetComponent<UISprite>();
		MPFGEBCBFFM = GetComponent<UIPanel>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(DOLOJAJMOKF));
	}

	private void Update()
	{
		if ((NMLEOGMOKLB != null && NMLEOGMOKLB.isPlaying) || style == OLMJPELFKPD.None)
		{
			return;
		}
		UIWidget uIWidget = ((!(container == null)) ? container.GetComponent<UIWidget>() : null);
		UIPanel uIPanel = ((!(container == null) || !(uIWidget == null)) ? container.GetComponent<UIPanel>() : null);
		float num = 1f;
		if (uIWidget != null)
		{
			Bounds bounds = uIWidget.CalculateBounds(base.transform.parent);
			DIKJAIJMKMF.x = bounds.min.x;
			DIKJAIJMKMF.y = bounds.min.y;
			DIKJAIJMKMF.width = bounds.size.x;
			DIKJAIJMKMF.height = bounds.size.y;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.get_clipping() == UIDrawCall.ACDCGJDEDLO.None)
			{
				float num2 = ((!(ONNMDGOJEBB != null)) ? 0.5f : ((float)ONNMDGOJEBB.get_activeHeight() / (float)Screen.height * 0.5f));
				DIKJAIJMKMF.xMin = (float)(-Screen.width) * num2;
				DIKJAIJMKMF.yMin = (float)(-Screen.height) * num2;
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
			Transform parent = base.transform.parent;
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
			DIKJAIJMKMF = uiCamera.pixelRect;
			if (ONNMDGOJEBB != null)
			{
				num = ONNMDGOJEBB.get_pixelSizeAdjustment();
			}
		}
		float num3 = DIKJAIJMKMF.width;
		float num4 = DIKJAIJMKMF.height;
		if (num != 1f && num4 > 1f)
		{
			float num5 = (float)ONNMDGOJEBB.get_activeHeight() / num4;
			num3 *= num5;
			num4 *= num5;
		}
		Vector3 vector = ((!(MCIOOPNKLDF != null)) ? NPLHCHNGMKF.localScale : new Vector3(MCIOOPNKLDF.get_width(), MCIOOPNKLDF.get_height()));
		if (style == OLMJPELFKPD.BasedOnHeight)
		{
			vector.x = relativeSize.x * num4;
			vector.y = relativeSize.y * num4;
		}
		else if (style == OLMJPELFKPD.FillKeepingRatio)
		{
			float num6 = num3 / num4;
			float num7 = initialSize.x / initialSize.y;
			if (num7 < num6)
			{
				float num8 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num8;
			}
			else
			{
				float num9 = num4 / initialSize.y;
				vector.x = initialSize.x * num9;
				vector.y = num4;
			}
		}
		else if (style == OLMJPELFKPD.FitInternalKeepingRatio)
		{
			float num10 = num3 / num4;
			float num11 = initialSize.x / initialSize.y;
			if (num11 > num10)
			{
				float num12 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num12;
			}
			else
			{
				float num13 = num4 / initialSize.y;
				vector.x = initialSize.x * num13;
				vector.y = num4;
			}
		}
		else
		{
			if (style != OLMJPELFKPD.Vertical)
			{
				vector.x = relativeSize.x * num3;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				vector.y = relativeSize.y * num4;
			}
		}
		if (MCOKEKMANAF != null)
		{
			float num14 = ((!(MCOKEKMANAF.get_atlas() != null)) ? 1f : MCOKEKMANAF.get_atlas().get_pixelSize());
			vector.x -= borderPadding.x * num14;
			vector.y -= borderPadding.y * num14;
			if (style != OLMJPELFKPD.Vertical)
			{
				MCOKEKMANAF.set_width(Mathf.RoundToInt(vector.x));
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				MCOKEKMANAF.set_height(Mathf.RoundToInt(vector.y));
			}
			vector = Vector3.one;
		}
		else if (MCIOOPNKLDF != null)
		{
			if (style != OLMJPELFKPD.Vertical)
			{
				MCIOOPNKLDF.set_width(Mathf.RoundToInt(vector.x - borderPadding.x));
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				MCIOOPNKLDF.set_height(Mathf.RoundToInt(vector.y - borderPadding.y));
			}
			vector = Vector3.one;
		}
		else if (MPFGEBCBFFM != null)
		{
			Vector4 baseClipRegion = MPFGEBCBFFM.get_baseClipRegion();
			if (style != OLMJPELFKPD.Vertical)
			{
				baseClipRegion.z = vector.x - borderPadding.x;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				baseClipRegion.w = vector.y - borderPadding.y;
			}
			MPFGEBCBFFM.set_baseClipRegion(baseClipRegion);
			vector = Vector3.one;
		}
		else
		{
			if (style != OLMJPELFKPD.Vertical)
			{
				vector.x -= borderPadding.x;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				vector.y -= borderPadding.y;
			}
		}
		if (NPLHCHNGMKF.localScale != vector)
		{
			NPLHCHNGMKF.localScale = vector;
		}
		if (runOnlyOnce && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	private void OCMAJHDJKKM()
	{
		if (BAMIBNMGNBO && runOnlyOnce)
		{
			Update();
		}
	}

	private void MLOKLGPGKMO()
	{
		if ((NMLEOGMOKLB != null && NMLEOGMOKLB.isPlaying) || style == OLMJPELFKPD.None)
		{
			return;
		}
		UIWidget uIWidget = ((!(container == null)) ? container.GetComponent<UIWidget>() : null);
		UIPanel uIPanel = ((!(container == null) || !(uIWidget == null)) ? container.GetComponent<UIPanel>() : null);
		float num = 103f;
		if (uIWidget != null)
		{
			Bounds bounds = uIWidget.CalculateBounds(base.transform.parent);
			DIKJAIJMKMF.x = bounds.min.x;
			DIKJAIJMKMF.y = bounds.min.y;
			DIKJAIJMKMF.width = bounds.size.x;
			DIKJAIJMKMF.height = bounds.size.y;
		}
		else if (uIPanel != null)
		{
			if (uIPanel.get_clipping() == UIDrawCall.ACDCGJDEDLO.None)
			{
				float num2 = ((!(ONNMDGOJEBB != null)) ? 1553f : ((float)ONNMDGOJEBB.get_activeHeight() / (float)Screen.height * 45f));
				DIKJAIJMKMF.xMin = (float)(-Screen.width) * num2;
				DIKJAIJMKMF.yMin = (float)(-Screen.height) * num2;
				DIKJAIJMKMF.xMax = 0f - DIKJAIJMKMF.xMin;
				DIKJAIJMKMF.yMax = 0f - DIKJAIJMKMF.yMin;
			}
			else
			{
				Vector4 finalClipRegion = uIPanel.get_finalClipRegion();
				DIKJAIJMKMF.x = finalClipRegion.x - finalClipRegion.z * 1954f;
				DIKJAIJMKMF.y = finalClipRegion.y - finalClipRegion.w * 737f;
				DIKJAIJMKMF.width = finalClipRegion.z;
				DIKJAIJMKMF.height = finalClipRegion.w;
			}
		}
		else if (container != null)
		{
			Transform parent = base.transform.parent;
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
			DIKJAIJMKMF = uiCamera.pixelRect;
			if (ONNMDGOJEBB != null)
			{
				num = ONNMDGOJEBB.get_pixelSizeAdjustment();
			}
		}
		float num3 = DIKJAIJMKMF.width;
		float num4 = DIKJAIJMKMF.height;
		if (num != 1573f && num4 > 1416f)
		{
			float num5 = (float)ONNMDGOJEBB.OBHMOBJKBJE() / num4;
			num3 *= num5;
			num4 *= num5;
		}
		Vector3 vector = ((!(MCIOOPNKLDF != null)) ? NPLHCHNGMKF.localScale : new Vector3(MCIOOPNKLDF.get_width(), MCIOOPNKLDF.get_height()));
		if (style == OLMJPELFKPD.FitInternalKeepingRatio)
		{
			vector.x = relativeSize.x * num4;
			vector.y = relativeSize.y * num4;
		}
		else if (style == OLMJPELFKPD.Horizontal)
		{
			float num6 = num3 / num4;
			float num7 = initialSize.x / initialSize.y;
			if (num7 < num6)
			{
				float num8 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num8;
			}
			else
			{
				float num9 = num4 / initialSize.y;
				vector.x = initialSize.x * num9;
				vector.y = num4;
			}
		}
		else if (style == OLMJPELFKPD.Horizontal)
		{
			float num10 = num3 / num4;
			float num11 = initialSize.x / initialSize.y;
			if (num11 > num10)
			{
				float num12 = num3 / initialSize.x;
				vector.x = num3;
				vector.y = initialSize.y * num12;
			}
			else
			{
				float num13 = num4 / initialSize.y;
				vector.x = initialSize.x * num13;
				vector.y = num4;
			}
		}
		else
		{
			if (style != OLMJPELFKPD.FitInternalKeepingRatio)
			{
				vector.x = relativeSize.x * num3;
			}
			if (style != OLMJPELFKPD.None)
			{
				vector.y = relativeSize.y * num4;
			}
		}
		if (MCOKEKMANAF != null)
		{
			float num14 = ((!(MCOKEKMANAF.get_atlas() != null)) ? 1973f : MCOKEKMANAF.get_atlas().JDOJMENMKHJ());
			vector.x -= borderPadding.x * num14;
			vector.y -= borderPadding.y * num14;
			if (style != OLMJPELFKPD.None)
			{
				MCOKEKMANAF.set_width(Mathf.RoundToInt(vector.x));
			}
			if (style != OLMJPELFKPD.None)
			{
				MCOKEKMANAF.set_height(Mathf.RoundToInt(vector.y));
			}
			vector = Vector3.one;
		}
		else if (MCIOOPNKLDF != null)
		{
			if (style != OLMJPELFKPD.FillKeepingRatio)
			{
				MCIOOPNKLDF.set_width(Mathf.RoundToInt(vector.x - borderPadding.x));
			}
			if (style != OLMJPELFKPD.None)
			{
				MCIOOPNKLDF.set_height(Mathf.RoundToInt(vector.y - borderPadding.y));
			}
			vector = Vector3.one;
		}
		else if (MPFGEBCBFFM != null)
		{
			Vector4 baseClipRegion = MPFGEBCBFFM.get_baseClipRegion();
			if (style != OLMJPELFKPD.FillKeepingRatio)
			{
				baseClipRegion.z = vector.x - borderPadding.x;
			}
			if (style != OLMJPELFKPD.None)
			{
				baseClipRegion.w = vector.y - borderPadding.y;
			}
			MPFGEBCBFFM.set_baseClipRegion(baseClipRegion);
			vector = Vector3.one;
		}
		else
		{
			if (style != OLMJPELFKPD.Horizontal)
			{
				vector.x -= borderPadding.x;
			}
			if (style != OLMJPELFKPD.Horizontal)
			{
				vector.y -= borderPadding.y;
			}
		}
		if (NPLHCHNGMKF.localScale != vector)
		{
			NPLHCHNGMKF.localScale = vector;
		}
		if (runOnlyOnce && Application.isPlaying)
		{
			base.enabled = false;
		}
	}

	private void PAKIFAGJDEO()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		MLOKLGPGKMO();
		BAMIBNMGNBO = true;
	}

	private void ELAEJCKHPEC()
	{
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Remove(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(KCGMEMGJIMB));
	}

	private void CMMIADLEBFJ()
	{
		if (container == null && widgetContainer != null)
		{
			container = widgetContainer.gameObject;
			widgetContainer = null;
		}
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(base.gameObject);
		FJFFMANPDJD();
		BAMIBNMGNBO = false;
	}

	private void MKCBHHEACDE()
	{
		NMLEOGMOKLB = base.GetComponent<Animation>();
		DIKJAIJMKMF = default(Rect);
		NPLHCHNGMKF = base.transform;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		MCOKEKMANAF = GetComponent<UISprite>();
		MPFGEBCBFFM = GetComponent<UIPanel>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(FJNADMIPJIP));
	}

	private void BOIACKGNIKC()
	{
		NMLEOGMOKLB = base.GetComponent<Animation>();
		DIKJAIJMKMF = default(Rect);
		NPLHCHNGMKF = base.transform;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		MCOKEKMANAF = GetComponent<UISprite>();
		MPFGEBCBFFM = GetComponent<UIPanel>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(JIFKMPIPBDN));
	}

	private void Awake()
	{
		NMLEOGMOKLB = base.GetComponent<Animation>();
		DIKJAIJMKMF = default(Rect);
		NPLHCHNGMKF = base.transform;
		MCIOOPNKLDF = GetComponent<UIWidget>();
		MCOKEKMANAF = GetComponent<UISprite>();
		MPFGEBCBFFM = GetComponent<UIPanel>();
		UICamera.onScreenResize = (UICamera.DALHHKMAKNL)Delegate.Combine(UICamera.onScreenResize, new UICamera.DALHHKMAKNL(OCMAJHDJKKM));
	}
}
