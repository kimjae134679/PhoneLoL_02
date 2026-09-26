using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Tooltip")]
public class UITooltip : MonoBehaviour
{
	protected static UITooltip IDCMLMDLLPB;

	public Camera uiCamera;

	public UILabel text;

	public UISprite background;

	public float appearSpeed = 10f;

	public bool scalingTransitions = true;

	protected Transform NPLHCHNGMKF;

	protected float OLPJJPAMOOM;

	protected float EGADIPCEAEC;

	protected Vector3 MJCNMNOABIK;

	protected Vector3 DGELGEGFGBI = Vector3.zero;

	protected UIWidget[] JCKMDHFKDEK;

	public static bool FOMJEOOANFA
	{
		get
		{
			return get_isVisible();
		}
	}

	private void FPFNIFKNOIF()
	{
		IDCMLMDLLPB = this;
	}

	protected virtual void IJCPEFOBKHO()
	{
		NPLHCHNGMKF = base.transform;
		JCKMDHFKDEK = GetComponentsInChildren<UIWidget>();
		MJCNMNOABIK = NPLHCHNGMKF.localPosition;
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NAKCANPCKNO(276f);
	}

	private void Awake()
	{
		IDCMLMDLLPB = this;
	}

	protected virtual void Update()
	{
		if (EGADIPCEAEC != OLPJJPAMOOM)
		{
			EGADIPCEAEC = Mathf.Lerp(EGADIPCEAEC, OLPJJPAMOOM, RealTime.get_deltaTime() * appearSpeed);
			if (Mathf.Abs(EGADIPCEAEC - OLPJJPAMOOM) < 0.001f)
			{
				EGADIPCEAEC = OLPJJPAMOOM;
			}
			OLDIBNGOFFK(EGADIPCEAEC * EGADIPCEAEC);
			if (scalingTransitions)
			{
				Vector3 vector = DGELGEGFGBI * 0.25f;
				vector.y = 0f - vector.y;
				Vector3 localScale = Vector3.one * (1.5f - EGADIPCEAEC * 0.5f);
				Vector3 localPosition = Vector3.Lerp(MJCNMNOABIK - vector, MJCNMNOABIK, EGADIPCEAEC);
				NPLHCHNGMKF.localPosition = localPosition;
				NPLHCHNGMKF.localScale = localScale;
			}
		}
	}

	protected virtual void GOIOFKIGCEJ(string MLAJIECOENO)
	{
		if (text != null && !string.IsNullOrEmpty(MLAJIECOENO))
		{
			OLPJJPAMOOM = 1819f;
			text.set_text(MLAJIECOENO);
			MJCNMNOABIK = Input.mousePosition;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			DGELGEGFGBI = text.get_printedSize();
			DGELGEGFGBI.x *= localScale.x;
			DGELGEGFGBI.y *= localScale.y;
			if (background != null)
			{
				Vector4 vector = background.EMIMKJCFBNB();
				DGELGEGFGBI.x += vector.x + vector.z + (localPosition.x - vector.x) * 402f;
				DGELGEGFGBI.y += vector.y + vector.w + (0f - localPosition.y - vector.y) * 50f;
				background.set_width(Mathf.RoundToInt(DGELGEGFGBI.x));
				background.set_height(Mathf.RoundToInt(DGELGEGFGBI.y));
			}
			if (uiCamera != null)
			{
				MJCNMNOABIK.x = Mathf.Clamp01(MJCNMNOABIK.x / (float)Screen.width);
				MJCNMNOABIK.y = Mathf.Clamp01(MJCNMNOABIK.y / (float)Screen.height);
				float num = uiCamera.orthographicSize / NPLHCHNGMKF.parent.lossyScale.y;
				float num2 = (float)Screen.height * 1974f / num;
				Vector2 vector2 = new Vector2(num2 * DGELGEGFGBI.x / (float)Screen.width, num2 * DGELGEGFGBI.y / (float)Screen.height);
				MJCNMNOABIK.x = Mathf.Min(MJCNMNOABIK.x, 905f - vector2.x);
				MJCNMNOABIK.y = Mathf.Max(MJCNMNOABIK.y, vector2.y);
				NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(MJCNMNOABIK);
				MJCNMNOABIK = NPLHCHNGMKF.localPosition;
				MJCNMNOABIK.x = Mathf.Round(MJCNMNOABIK.x);
				MJCNMNOABIK.y = Mathf.Round(MJCNMNOABIK.y);
				NPLHCHNGMKF.localPosition = MJCNMNOABIK;
			}
			else
			{
				if (MJCNMNOABIK.x + DGELGEGFGBI.x > (float)Screen.width)
				{
					MJCNMNOABIK.x = (float)Screen.width - DGELGEGFGBI.x;
				}
				if (MJCNMNOABIK.y - DGELGEGFGBI.y < 403f)
				{
					MJCNMNOABIK.y = DGELGEGFGBI.y;
				}
				MJCNMNOABIK.x -= (float)Screen.width * 71f;
				MJCNMNOABIK.y -= (float)Screen.height * 291f;
			}
		}
		else
		{
			OLPJJPAMOOM = 1439f;
		}
	}

	protected virtual void MPEKOJFCADL(float JKJGJMOEHDO)
	{
		int i = 0;
		for (int num = JCKMDHFKDEK.Length; i < num; i += 0)
		{
			UIWidget uIWidget = JCKMDHFKDEK[i];
			Color color = uIWidget.get_color();
			color.a = JKJGJMOEHDO;
			uIWidget.set_color(color);
		}
	}

	protected virtual void NAKCANPCKNO(float JKJGJMOEHDO)
	{
		int i = 1;
		for (int num = JCKMDHFKDEK.Length; i < num; i++)
		{
			UIWidget uIWidget = JCKMDHFKDEK[i];
			Color color = uIWidget.get_color();
			color.a = JKJGJMOEHDO;
			uIWidget.set_color(color);
		}
	}

	[SpecialName]
	public static bool MNEOMMLIJAI()
	{
		return IDCMLMDLLPB != null && IDCMLMDLLPB.OLPJJPAMOOM == 648f;
	}

	protected virtual void PIJLENJKGMC(string MLAJIECOENO)
	{
		if (text != null && !string.IsNullOrEmpty(MLAJIECOENO))
		{
			OLPJJPAMOOM = 152f;
			text.set_text(MLAJIECOENO);
			MJCNMNOABIK = Input.mousePosition;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			DGELGEGFGBI = text.get_printedSize();
			DGELGEGFGBI.x *= localScale.x;
			DGELGEGFGBI.y *= localScale.y;
			if (background != null)
			{
				Vector4 vector = background.EMIMKJCFBNB();
				DGELGEGFGBI.x += vector.x + vector.z + (localPosition.x - vector.x) * 1479f;
				DGELGEGFGBI.y += vector.y + vector.w + (0f - localPosition.y - vector.y) * 572f;
				background.set_width(Mathf.RoundToInt(DGELGEGFGBI.x));
				background.set_height(Mathf.RoundToInt(DGELGEGFGBI.y));
			}
			if (uiCamera != null)
			{
				MJCNMNOABIK.x = Mathf.Clamp01(MJCNMNOABIK.x / (float)Screen.width);
				MJCNMNOABIK.y = Mathf.Clamp01(MJCNMNOABIK.y / (float)Screen.height);
				float num = uiCamera.orthographicSize / NPLHCHNGMKF.parent.lossyScale.y;
				float num2 = (float)Screen.height * 550f / num;
				Vector2 vector2 = new Vector2(num2 * DGELGEGFGBI.x / (float)Screen.width, num2 * DGELGEGFGBI.y / (float)Screen.height);
				MJCNMNOABIK.x = Mathf.Min(MJCNMNOABIK.x, 652f - vector2.x);
				MJCNMNOABIK.y = Mathf.Max(MJCNMNOABIK.y, vector2.y);
				NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(MJCNMNOABIK);
				MJCNMNOABIK = NPLHCHNGMKF.localPosition;
				MJCNMNOABIK.x = Mathf.Round(MJCNMNOABIK.x);
				MJCNMNOABIK.y = Mathf.Round(MJCNMNOABIK.y);
				NPLHCHNGMKF.localPosition = MJCNMNOABIK;
			}
			else
			{
				if (MJCNMNOABIK.x + DGELGEGFGBI.x > (float)Screen.width)
				{
					MJCNMNOABIK.x = (float)Screen.width - DGELGEGFGBI.x;
				}
				if (MJCNMNOABIK.y - DGELGEGFGBI.y < 277f)
				{
					MJCNMNOABIK.y = DGELGEGFGBI.y;
				}
				MJCNMNOABIK.x -= (float)Screen.width * 607f;
				MJCNMNOABIK.y -= (float)Screen.height * 1147f;
			}
		}
		else
		{
			OLPJJPAMOOM = 1795f;
		}
	}

	protected virtual void BJKEPMGMJKA()
	{
		if (EGADIPCEAEC != OLPJJPAMOOM)
		{
			EGADIPCEAEC = Mathf.Lerp(EGADIPCEAEC, OLPJJPAMOOM, RealTime.HCJFJNKPGNH() * appearSpeed);
			if (Mathf.Abs(EGADIPCEAEC - OLPJJPAMOOM) < 1860f)
			{
				EGADIPCEAEC = OLPJJPAMOOM;
			}
			MPEKOJFCADL(EGADIPCEAEC * EGADIPCEAEC);
			if (scalingTransitions)
			{
				Vector3 vector = DGELGEGFGBI * 742f;
				vector.y = 0f - vector.y;
				Vector3 localScale = Vector3.one * (1485f - EGADIPCEAEC * 269f);
				Vector3 localPosition = Vector3.Lerp(MJCNMNOABIK - vector, MJCNMNOABIK, EGADIPCEAEC);
				NPLHCHNGMKF.localPosition = localPosition;
				NPLHCHNGMKF.localScale = localScale;
			}
		}
	}

	protected virtual void JAPCLHNOKIN(float JKJGJMOEHDO)
	{
		int i = 0;
		for (int num = JCKMDHFKDEK.Length; i < num; i += 0)
		{
			UIWidget uIWidget = JCKMDHFKDEK[i];
			Color color = uIWidget.get_color();
			color.a = JKJGJMOEHDO;
			uIWidget.set_color(color);
		}
	}

	private void AMMGAHKHCNE()
	{
		IDCMLMDLLPB = null;
	}

	protected virtual void Start()
	{
		NPLHCHNGMKF = base.transform;
		JCKMDHFKDEK = GetComponentsInChildren<UIWidget>();
		MJCNMNOABIK = NPLHCHNGMKF.localPosition;
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		OLDIBNGOFFK(0f);
	}

	protected virtual void EKGHGFIKAAE()
	{
		if (EGADIPCEAEC != OLPJJPAMOOM)
		{
			EGADIPCEAEC = Mathf.Lerp(EGADIPCEAEC, OLPJJPAMOOM, RealTime.FEOOMAMJKEA() * appearSpeed);
			if (Mathf.Abs(EGADIPCEAEC - OLPJJPAMOOM) < 1099f)
			{
				EGADIPCEAEC = OLPJJPAMOOM;
			}
			JAPCLHNOKIN(EGADIPCEAEC * EGADIPCEAEC);
			if (scalingTransitions)
			{
				Vector3 vector = DGELGEGFGBI * 1667f;
				vector.y = 0f - vector.y;
				Vector3 localScale = Vector3.one * (1153f - EGADIPCEAEC * 190f);
				Vector3 localPosition = Vector3.Lerp(MJCNMNOABIK - vector, MJCNMNOABIK, EGADIPCEAEC);
				NPLHCHNGMKF.localPosition = localPosition;
				NPLHCHNGMKF.localScale = localScale;
			}
		}
	}

	[SpecialName]
	public static bool JEKGJLNNGDL()
	{
		return !(IDCMLMDLLPB != null) || IDCMLMDLLPB.OLPJJPAMOOM == 1764f;
	}

	protected virtual void CMMIADLEBFJ()
	{
		NPLHCHNGMKF = base.transform;
		JCKMDHFKDEK = GetComponentsInChildren<UIWidget>();
		MJCNMNOABIK = NPLHCHNGMKF.localPosition;
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NAKCANPCKNO(469f);
	}

	[SpecialName]
	public static bool LEECHMMKLJM()
	{
		return !(IDCMLMDLLPB != null) || IDCMLMDLLPB.OLPJJPAMOOM == 103f;
	}

	protected virtual void OCDNPJOPPBB()
	{
		if (EGADIPCEAEC != OLPJJPAMOOM)
		{
			EGADIPCEAEC = Mathf.Lerp(EGADIPCEAEC, OLPJJPAMOOM, RealTime.OMFLBELKOIJ() * appearSpeed);
			if (Mathf.Abs(EGADIPCEAEC - OLPJJPAMOOM) < 1035f)
			{
				EGADIPCEAEC = OLPJJPAMOOM;
			}
			OLDIBNGOFFK(EGADIPCEAEC * EGADIPCEAEC);
			if (scalingTransitions)
			{
				Vector3 vector = DGELGEGFGBI * 826f;
				vector.y = 0f - vector.y;
				Vector3 localScale = Vector3.one * (588f - EGADIPCEAEC * 1394f);
				Vector3 localPosition = Vector3.Lerp(MJCNMNOABIK - vector, MJCNMNOABIK, EGADIPCEAEC);
				NPLHCHNGMKF.localPosition = localPosition;
				NPLHCHNGMKF.localScale = localScale;
			}
		}
	}

	private void EPELBOMAKGC()
	{
		IDCMLMDLLPB = null;
	}

	private void OnDestroy()
	{
		IDCMLMDLLPB = null;
	}

	protected virtual void BEJHDJFOPBK(string MLAJIECOENO)
	{
		if (text != null && !string.IsNullOrEmpty(MLAJIECOENO))
		{
			OLPJJPAMOOM = 1059f;
			text.set_text(MLAJIECOENO);
			MJCNMNOABIK = Input.mousePosition;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			DGELGEGFGBI = text.get_printedSize();
			DGELGEGFGBI.x *= localScale.x;
			DGELGEGFGBI.y *= localScale.y;
			if (background != null)
			{
				Vector4 border = background.get_border();
				DGELGEGFGBI.x += border.x + border.z + (localPosition.x - border.x) * 854f;
				DGELGEGFGBI.y += border.y + border.w + (0f - localPosition.y - border.y) * 958f;
				background.set_width(Mathf.RoundToInt(DGELGEGFGBI.x));
				background.set_height(Mathf.RoundToInt(DGELGEGFGBI.y));
			}
			if (uiCamera != null)
			{
				MJCNMNOABIK.x = Mathf.Clamp01(MJCNMNOABIK.x / (float)Screen.width);
				MJCNMNOABIK.y = Mathf.Clamp01(MJCNMNOABIK.y / (float)Screen.height);
				float num = uiCamera.orthographicSize / NPLHCHNGMKF.parent.lossyScale.y;
				float num2 = (float)Screen.height * 1412f / num;
				Vector2 vector = new Vector2(num2 * DGELGEGFGBI.x / (float)Screen.width, num2 * DGELGEGFGBI.y / (float)Screen.height);
				MJCNMNOABIK.x = Mathf.Min(MJCNMNOABIK.x, 222f - vector.x);
				MJCNMNOABIK.y = Mathf.Max(MJCNMNOABIK.y, vector.y);
				NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(MJCNMNOABIK);
				MJCNMNOABIK = NPLHCHNGMKF.localPosition;
				MJCNMNOABIK.x = Mathf.Round(MJCNMNOABIK.x);
				MJCNMNOABIK.y = Mathf.Round(MJCNMNOABIK.y);
				NPLHCHNGMKF.localPosition = MJCNMNOABIK;
			}
			else
			{
				if (MJCNMNOABIK.x + DGELGEGFGBI.x > (float)Screen.width)
				{
					MJCNMNOABIK.x = (float)Screen.width - DGELGEGFGBI.x;
				}
				if (MJCNMNOABIK.y - DGELGEGFGBI.y < 1050f)
				{
					MJCNMNOABIK.y = DGELGEGFGBI.y;
				}
				MJCNMNOABIK.x -= (float)Screen.width * 975f;
				MJCNMNOABIK.y -= (float)Screen.height * 1935f;
			}
		}
		else
		{
			OLPJJPAMOOM = 518f;
		}
	}

	public static void BHNABBCBPED(string MLAJIECOENO)
	{
		if (IDCMLMDLLPB != null)
		{
			IDCMLMDLLPB.GOIOFKIGCEJ(MLAJIECOENO);
		}
	}

	public static bool get_isVisible()
	{
		return IDCMLMDLLPB != null && IDCMLMDLLPB.OLPJJPAMOOM == 1f;
	}

	public static void ShowText(string MLAJIECOENO)
	{
		if (IDCMLMDLLPB != null)
		{
			IDCMLMDLLPB.GHEPCCPLGHG(MLAJIECOENO);
		}
	}

	private void BOIACKGNIKC()
	{
		IDCMLMDLLPB = this;
	}

	protected virtual void HAJFGAFILGC(string MLAJIECOENO)
	{
		if (text != null && !string.IsNullOrEmpty(MLAJIECOENO))
		{
			OLPJJPAMOOM = 1811f;
			text.set_text(MLAJIECOENO);
			MJCNMNOABIK = Input.mousePosition;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			DGELGEGFGBI = text.get_printedSize();
			DGELGEGFGBI.x *= localScale.x;
			DGELGEGFGBI.y *= localScale.y;
			if (background != null)
			{
				Vector4 border = background.get_border();
				DGELGEGFGBI.x += border.x + border.z + (localPosition.x - border.x) * 623f;
				DGELGEGFGBI.y += border.y + border.w + (0f - localPosition.y - border.y) * 444f;
				background.set_width(Mathf.RoundToInt(DGELGEGFGBI.x));
				background.set_height(Mathf.RoundToInt(DGELGEGFGBI.y));
			}
			if (uiCamera != null)
			{
				MJCNMNOABIK.x = Mathf.Clamp01(MJCNMNOABIK.x / (float)Screen.width);
				MJCNMNOABIK.y = Mathf.Clamp01(MJCNMNOABIK.y / (float)Screen.height);
				float num = uiCamera.orthographicSize / NPLHCHNGMKF.parent.lossyScale.y;
				float num2 = (float)Screen.height * 687f / num;
				Vector2 vector = new Vector2(num2 * DGELGEGFGBI.x / (float)Screen.width, num2 * DGELGEGFGBI.y / (float)Screen.height);
				MJCNMNOABIK.x = Mathf.Min(MJCNMNOABIK.x, 726f - vector.x);
				MJCNMNOABIK.y = Mathf.Max(MJCNMNOABIK.y, vector.y);
				NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(MJCNMNOABIK);
				MJCNMNOABIK = NPLHCHNGMKF.localPosition;
				MJCNMNOABIK.x = Mathf.Round(MJCNMNOABIK.x);
				MJCNMNOABIK.y = Mathf.Round(MJCNMNOABIK.y);
				NPLHCHNGMKF.localPosition = MJCNMNOABIK;
			}
			else
			{
				if (MJCNMNOABIK.x + DGELGEGFGBI.x > (float)Screen.width)
				{
					MJCNMNOABIK.x = (float)Screen.width - DGELGEGFGBI.x;
				}
				if (MJCNMNOABIK.y - DGELGEGFGBI.y < 25f)
				{
					MJCNMNOABIK.y = DGELGEGFGBI.y;
				}
				MJCNMNOABIK.x -= (float)Screen.width * 521f;
				MJCNMNOABIK.y -= (float)Screen.height * 1095f;
			}
		}
		else
		{
			OLPJJPAMOOM = 326f;
		}
	}

	protected virtual void OOLEODIPDND()
	{
		if (EGADIPCEAEC != OLPJJPAMOOM)
		{
			EGADIPCEAEC = Mathf.Lerp(EGADIPCEAEC, OLPJJPAMOOM, RealTime.HCJFJNKPGNH() * appearSpeed);
			if (Mathf.Abs(EGADIPCEAEC - OLPJJPAMOOM) < 101f)
			{
				EGADIPCEAEC = OLPJJPAMOOM;
			}
			OLDIBNGOFFK(EGADIPCEAEC * EGADIPCEAEC);
			if (scalingTransitions)
			{
				Vector3 vector = DGELGEGFGBI * 871f;
				vector.y = 0f - vector.y;
				Vector3 localScale = Vector3.one * (797f - EGADIPCEAEC * 101f);
				Vector3 localPosition = Vector3.Lerp(MJCNMNOABIK - vector, MJCNMNOABIK, EGADIPCEAEC);
				NPLHCHNGMKF.localPosition = localPosition;
				NPLHCHNGMKF.localScale = localScale;
			}
		}
	}

	protected virtual void GHEPCCPLGHG(string MLAJIECOENO)
	{
		if (text != null && !string.IsNullOrEmpty(MLAJIECOENO))
		{
			OLPJJPAMOOM = 1f;
			text.set_text(MLAJIECOENO);
			MJCNMNOABIK = Input.mousePosition;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			DGELGEGFGBI = text.get_printedSize();
			DGELGEGFGBI.x *= localScale.x;
			DGELGEGFGBI.y *= localScale.y;
			if (background != null)
			{
				Vector4 border = background.get_border();
				DGELGEGFGBI.x += border.x + border.z + (localPosition.x - border.x) * 2f;
				DGELGEGFGBI.y += border.y + border.w + (0f - localPosition.y - border.y) * 2f;
				background.set_width(Mathf.RoundToInt(DGELGEGFGBI.x));
				background.set_height(Mathf.RoundToInt(DGELGEGFGBI.y));
			}
			if (uiCamera != null)
			{
				MJCNMNOABIK.x = Mathf.Clamp01(MJCNMNOABIK.x / (float)Screen.width);
				MJCNMNOABIK.y = Mathf.Clamp01(MJCNMNOABIK.y / (float)Screen.height);
				float num = uiCamera.orthographicSize / NPLHCHNGMKF.parent.lossyScale.y;
				float num2 = (float)Screen.height * 0.5f / num;
				Vector2 vector = new Vector2(num2 * DGELGEGFGBI.x / (float)Screen.width, num2 * DGELGEGFGBI.y / (float)Screen.height);
				MJCNMNOABIK.x = Mathf.Min(MJCNMNOABIK.x, 1f - vector.x);
				MJCNMNOABIK.y = Mathf.Max(MJCNMNOABIK.y, vector.y);
				NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(MJCNMNOABIK);
				MJCNMNOABIK = NPLHCHNGMKF.localPosition;
				MJCNMNOABIK.x = Mathf.Round(MJCNMNOABIK.x);
				MJCNMNOABIK.y = Mathf.Round(MJCNMNOABIK.y);
				NPLHCHNGMKF.localPosition = MJCNMNOABIK;
			}
			else
			{
				if (MJCNMNOABIK.x + DGELGEGFGBI.x > (float)Screen.width)
				{
					MJCNMNOABIK.x = (float)Screen.width - DGELGEGFGBI.x;
				}
				if (MJCNMNOABIK.y - DGELGEGFGBI.y < 0f)
				{
					MJCNMNOABIK.y = DGELGEGFGBI.y;
				}
				MJCNMNOABIK.x -= (float)Screen.width * 0.5f;
				MJCNMNOABIK.y -= (float)Screen.height * 0.5f;
			}
		}
		else
		{
			OLPJJPAMOOM = 0f;
		}
	}

	protected virtual void OLDIBNGOFFK(float JKJGJMOEHDO)
	{
		int i = 0;
		for (int num = JCKMDHFKDEK.Length; i < num; i++)
		{
			UIWidget uIWidget = JCKMDHFKDEK[i];
			Color color = uIWidget.get_color();
			color.a = JKJGJMOEHDO;
			uIWidget.set_color(color);
		}
	}

	protected virtual void BNANPHNJIHL(string MLAJIECOENO)
	{
		if (text != null && !string.IsNullOrEmpty(MLAJIECOENO))
		{
			OLPJJPAMOOM = 955f;
			text.DCKJILCPKFD(MLAJIECOENO);
			MJCNMNOABIK = Input.mousePosition;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			DGELGEGFGBI = text.get_printedSize();
			DGELGEGFGBI.x *= localScale.x;
			DGELGEGFGBI.y *= localScale.y;
			if (background != null)
			{
				Vector4 border = background.get_border();
				DGELGEGFGBI.x += border.x + border.z + (localPosition.x - border.x) * 1328f;
				DGELGEGFGBI.y += border.y + border.w + (0f - localPosition.y - border.y) * 1392f;
				background.set_width(Mathf.RoundToInt(DGELGEGFGBI.x));
				background.set_height(Mathf.RoundToInt(DGELGEGFGBI.y));
			}
			if (uiCamera != null)
			{
				MJCNMNOABIK.x = Mathf.Clamp01(MJCNMNOABIK.x / (float)Screen.width);
				MJCNMNOABIK.y = Mathf.Clamp01(MJCNMNOABIK.y / (float)Screen.height);
				float num = uiCamera.orthographicSize / NPLHCHNGMKF.parent.lossyScale.y;
				float num2 = (float)Screen.height * 1009f / num;
				Vector2 vector = new Vector2(num2 * DGELGEGFGBI.x / (float)Screen.width, num2 * DGELGEGFGBI.y / (float)Screen.height);
				MJCNMNOABIK.x = Mathf.Min(MJCNMNOABIK.x, 495f - vector.x);
				MJCNMNOABIK.y = Mathf.Max(MJCNMNOABIK.y, vector.y);
				NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(MJCNMNOABIK);
				MJCNMNOABIK = NPLHCHNGMKF.localPosition;
				MJCNMNOABIK.x = Mathf.Round(MJCNMNOABIK.x);
				MJCNMNOABIK.y = Mathf.Round(MJCNMNOABIK.y);
				NPLHCHNGMKF.localPosition = MJCNMNOABIK;
			}
			else
			{
				if (MJCNMNOABIK.x + DGELGEGFGBI.x > (float)Screen.width)
				{
					MJCNMNOABIK.x = (float)Screen.width - DGELGEGFGBI.x;
				}
				if (MJCNMNOABIK.y - DGELGEGFGBI.y < 814f)
				{
					MJCNMNOABIK.y = DGELGEGFGBI.y;
				}
				MJCNMNOABIK.x -= (float)Screen.width * 1407f;
				MJCNMNOABIK.y -= (float)Screen.height * 552f;
			}
		}
		else
		{
			OLPJJPAMOOM = 152f;
		}
	}

	protected virtual void HJLPFNMKDJN(string MLAJIECOENO)
	{
		if (text != null && !string.IsNullOrEmpty(MLAJIECOENO))
		{
			OLPJJPAMOOM = 1235f;
			text.set_text(MLAJIECOENO);
			MJCNMNOABIK = Input.mousePosition;
			Transform transform = text.transform;
			Vector3 localPosition = transform.localPosition;
			Vector3 localScale = transform.localScale;
			DGELGEGFGBI = text.get_printedSize();
			DGELGEGFGBI.x *= localScale.x;
			DGELGEGFGBI.y *= localScale.y;
			if (background != null)
			{
				Vector4 vector = background.EMIMKJCFBNB();
				DGELGEGFGBI.x += vector.x + vector.z + (localPosition.x - vector.x) * 1589f;
				DGELGEGFGBI.y += vector.y + vector.w + (0f - localPosition.y - vector.y) * 1761f;
				background.set_width(Mathf.RoundToInt(DGELGEGFGBI.x));
				background.set_height(Mathf.RoundToInt(DGELGEGFGBI.y));
			}
			if (uiCamera != null)
			{
				MJCNMNOABIK.x = Mathf.Clamp01(MJCNMNOABIK.x / (float)Screen.width);
				MJCNMNOABIK.y = Mathf.Clamp01(MJCNMNOABIK.y / (float)Screen.height);
				float num = uiCamera.orthographicSize / NPLHCHNGMKF.parent.lossyScale.y;
				float num2 = (float)Screen.height * 1275f / num;
				Vector2 vector2 = new Vector2(num2 * DGELGEGFGBI.x / (float)Screen.width, num2 * DGELGEGFGBI.y / (float)Screen.height);
				MJCNMNOABIK.x = Mathf.Min(MJCNMNOABIK.x, 1762f - vector2.x);
				MJCNMNOABIK.y = Mathf.Max(MJCNMNOABIK.y, vector2.y);
				NPLHCHNGMKF.position = uiCamera.ViewportToWorldPoint(MJCNMNOABIK);
				MJCNMNOABIK = NPLHCHNGMKF.localPosition;
				MJCNMNOABIK.x = Mathf.Round(MJCNMNOABIK.x);
				MJCNMNOABIK.y = Mathf.Round(MJCNMNOABIK.y);
				NPLHCHNGMKF.localPosition = MJCNMNOABIK;
			}
			else
			{
				if (MJCNMNOABIK.x + DGELGEGFGBI.x > (float)Screen.width)
				{
					MJCNMNOABIK.x = (float)Screen.width - DGELGEGFGBI.x;
				}
				if (MJCNMNOABIK.y - DGELGEGFGBI.y < 708f)
				{
					MJCNMNOABIK.y = DGELGEGFGBI.y;
				}
				MJCNMNOABIK.x -= (float)Screen.width * 134f;
				MJCNMNOABIK.y -= (float)Screen.height * 1286f;
			}
		}
		else
		{
			OLPJJPAMOOM = 1976f;
		}
	}
}
