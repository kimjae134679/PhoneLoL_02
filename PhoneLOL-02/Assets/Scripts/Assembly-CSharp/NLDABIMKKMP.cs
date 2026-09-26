using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using UnityEngine;

public static class NLDABIMKKMP
{
	private static AudioListener HJHOHOMNMPL;

	private static bool DIHJNAMINKD = false;

	private static float PBIDGBAANED = 1f;

	private static Vector3[] OMFIAGADNDK = new Vector3[4];

	public static float JNKAIDKPFMC
	{
		get
		{
			return KOIEJCDNKKJ();
		}
		set
		{
			FMEJHPOLPEK(value);
		}
	}

	public static bool AGAHLFJLKPG
	{
		get
		{
			return ADJICBBFPBG();
		}
	}

	public static string PEGGNPMOKKG
	{
		get
		{
			return NGAMPPOJCHJ();
		}
		set
		{
			DJILPNJPOPC(value);
		}
	}

	public static float KOIEJCDNKKJ()
	{
		if (!DIHJNAMINKD)
		{
			DIHJNAMINKD = true;
			PBIDGBAANED = PlayerPrefs.GetFloat("Sound", 1f);
		}
		return PBIDGBAANED;
	}

	public static void FMEJHPOLPEK(float ICENKPDOHBK)
	{
		if (PBIDGBAANED != ICENKPDOHBK)
		{
			DIHJNAMINKD = true;
			PBIDGBAANED = ICENKPDOHBK;
			PlayerPrefs.SetFloat("Sound", ICENKPDOHBK);
		}
	}

	public static bool ADJICBBFPBG()
	{
		return Application.platform != ((RuntimePlatform)5) && Application.platform != ((RuntimePlatform)3);
	}

	public static AudioSource FANLLKDLCPF(AudioClip MPMBKOGKPPO)
	{
		return FANLLKDLCPF(MPMBKOGKPPO, 1f, 1f);
	}

	public static AudioSource FANLLKDLCPF(AudioClip MPMBKOGKPPO, float HKKDIPCBADK)
	{
		return FANLLKDLCPF(MPMBKOGKPPO, HKKDIPCBADK, 1f);
	}

	public static AudioSource FANLLKDLCPF(AudioClip MPMBKOGKPPO, float HKKDIPCBADK, float HAJCOMDGHHJ)
	{
		HKKDIPCBADK *= KOIEJCDNKKJ();
		if (MPMBKOGKPPO != null && HKKDIPCBADK > 0.01f)
		{
			if (HJHOHOMNMPL == null || !FGIDLKLMBHB(HJHOHOMNMPL))
			{
				AudioListener[] array = UnityEngine.Object.FindObjectsOfType(typeof(AudioListener)) as AudioListener[];
				if (array != null)
				{
					for (int i = 0; i < array.Length; i++)
					{
						if (FGIDLKLMBHB(array[i]))
						{
							HJHOHOMNMPL = array[i];
							break;
						}
					}
				}
				if (HJHOHOMNMPL == null)
				{
					Camera camera = Camera.main;
					if (camera == null)
					{
						camera = UnityEngine.Object.FindObjectOfType(typeof(Camera)) as Camera;
					}
					if (camera != null)
					{
						HJHOHOMNMPL = camera.gameObject.AddComponent<AudioListener>();
					}
				}
			}
			if (HJHOHOMNMPL != null && HJHOHOMNMPL.enabled && FGIDLKLMBHB(HJHOHOMNMPL.gameObject))
			{
				AudioSource audioSource = HJHOHOMNMPL.GetComponent<AudioSource>();
				if (audioSource == null)
				{
					audioSource = HJHOHOMNMPL.gameObject.AddComponent<AudioSource>();
				}
				audioSource.pitch = HAJCOMDGHHJ;
				audioSource.PlayOneShot(MPMBKOGKPPO, HKKDIPCBADK);
				return audioSource;
			}
		}
		return null;
	}

	public static WWW ABBCPGFDPMN(string IOFIAJPFHGN)
	{
		WWW result = null;
		try
		{
			result = new WWW(IOFIAJPFHGN);
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError(ex.Message);
		}
		return result;
	}

	public static WWW ABBCPGFDPMN(string IOFIAJPFHGN, WWWForm NBIJEOPJBDN)
	{
		if (NBIJEOPJBDN == null)
		{
			return ABBCPGFDPMN(IOFIAJPFHGN);
		}
		WWW result = null;
		try
		{
			result = new WWW(IOFIAJPFHGN, NBIJEOPJBDN);
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError((ex == null) ? "<null>" : ex.Message);
		}
		return result;
	}

	public static int HAALNHCHOMH(int EIFFBKMJCEL, int KBBNDLJDCAP)
	{
		if (EIFFBKMJCEL == KBBNDLJDCAP)
		{
			return EIFFBKMJCEL;
		}
		return UnityEngine.Random.Range(EIFFBKMJCEL, KBBNDLJDCAP + 1);
	}

	public static string KHEEJPKGGFP(GameObject HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI == null)
		{
			return string.Empty;
		}
		string text = HCKCCHPJOPI.name;
		while (HCKCCHPJOPI.transform.parent != null)
		{
			HCKCCHPJOPI = HCKCCHPJOPI.transform.parent.gameObject;
			text = HCKCCHPJOPI.name + "\\" + text;
		}
		return text;
	}

	public static T[] MHMBABFFMHO<T>() where T : Component
	{
		return UnityEngine.Object.FindObjectsOfType(typeof(T)) as T[];
	}

	public static Camera MLHKJOCLJIC(int DGLDFJMPHMJ)
	{
		int num = 1 << DGLDFJMPHMJ;
		Camera cachedCamera;
		for (int i = 0; i < UICamera.list.POIJPKODPCK; i++)
		{
			cachedCamera = UICamera.list.EDMNHDBEPMC[i].get_cachedCamera();
			if ((bool)cachedCamera && (cachedCamera.cullingMask & num) != 0)
			{
				return cachedCamera;
			}
		}
		cachedCamera = Camera.main;
		if ((bool)cachedCamera && (cachedCamera.cullingMask & num) != 0)
		{
			return cachedCamera;
		}
		Camera[] array = MHMBABFFMHO<Camera>();
		int j = 0;
		for (int num2 = array.Length; j < num2; j++)
		{
			cachedCamera = array[j];
			if ((bool)cachedCamera && (cachedCamera.cullingMask & num) != 0)
			{
				return cachedCamera;
			}
		}
		return null;
	}

	public static void EJPENNCFGKM(GameObject LHACFNECMNA)
	{
		EJPENNCFGKM(LHACFNECMNA, false);
	}

	public static void EJPENNCFGKM(GameObject LHACFNECMNA, bool IJOOEOPFMIH)
	{
		if (!(LHACFNECMNA != null))
		{
			return;
		}
		Collider component = LHACFNECMNA.GetComponent<Collider>();
		BoxCollider boxCollider = component as BoxCollider;
		if (boxCollider != null)
		{
			AFNBJACCKKC(boxCollider, IJOOEOPFMIH);
		}
		else
		{
			if (component != null)
			{
				return;
			}
			BoxCollider2D component2 = LHACFNECMNA.GetComponent<BoxCollider2D>();
			if (component2 != null)
			{
				AFNBJACCKKC(component2, IJOOEOPFMIH);
				return;
			}
			UICamera uICamera = UICamera.FindCameraForLayer(LHACFNECMNA.layer);
			if (uICamera != null && (uICamera.eventType == UICamera.IJGBIHBDJHM.World_2D || uICamera.eventType == UICamera.IJGBIHBDJHM.UI_2D))
			{
				component2 = LHACFNECMNA.AddComponent<BoxCollider2D>();
				component2.isTrigger = true;
				UIWidget component3 = LHACFNECMNA.GetComponent<UIWidget>();
				if (component3 != null)
				{
					component3.autoResizeBoxCollider = true;
				}
				AFNBJACCKKC(component2, IJOOEOPFMIH);
			}
			else
			{
				boxCollider = LHACFNECMNA.AddComponent<BoxCollider>();
				boxCollider.isTrigger = true;
				UIWidget component4 = LHACFNECMNA.GetComponent<UIWidget>();
				if (component4 != null)
				{
					component4.autoResizeBoxCollider = true;
				}
				AFNBJACCKKC(boxCollider, IJOOEOPFMIH);
			}
		}
	}

	public static void AFNBJACCKKC(GameObject LHACFNECMNA)
	{
		AFNBJACCKKC(LHACFNECMNA, false);
	}

	public static void AFNBJACCKKC(GameObject LHACFNECMNA, bool IJOOEOPFMIH)
	{
		if (!(LHACFNECMNA != null))
		{
			return;
		}
		BoxCollider component = LHACFNECMNA.GetComponent<BoxCollider>();
		if (component != null)
		{
			AFNBJACCKKC(component, IJOOEOPFMIH);
			return;
		}
		BoxCollider2D component2 = LHACFNECMNA.GetComponent<BoxCollider2D>();
		if (component2 != null)
		{
			AFNBJACCKKC(component2, IJOOEOPFMIH);
		}
	}

	public static void AFNBJACCKKC(BoxCollider BGPIGKODGBI, bool IJOOEOPFMIH)
	{
		if (!(BGPIGKODGBI != null))
		{
			return;
		}
		GameObject gameObject = BGPIGKODGBI.gameObject;
		UIWidget component = gameObject.GetComponent<UIWidget>();
		if (component != null)
		{
			Vector4 drawRegion = component.get_drawRegion();
			if (drawRegion.x != 0f || drawRegion.y != 0f || drawRegion.z != 1f || drawRegion.w != 1f)
			{
				Vector4 drawingDimensions = component.get_drawingDimensions();
				BGPIGKODGBI.center = new Vector3((drawingDimensions.x + drawingDimensions.z) * 0.5f, (drawingDimensions.y + drawingDimensions.w) * 0.5f);
				BGPIGKODGBI.size = new Vector3(drawingDimensions.z - drawingDimensions.x, drawingDimensions.w - drawingDimensions.y);
			}
			else
			{
				Vector3[] localCorners = component.get_localCorners();
				BGPIGKODGBI.center = Vector3.Lerp(localCorners[0], localCorners[2], 0.5f);
				BGPIGKODGBI.size = localCorners[2] - localCorners[0];
			}
		}
		else
		{
			Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(gameObject.transform, IJOOEOPFMIH);
			BGPIGKODGBI.center = bounds.center;
			BGPIGKODGBI.size = new Vector3(bounds.size.x, bounds.size.y, 0f);
		}
	}

	public static void AFNBJACCKKC(BoxCollider2D BGPIGKODGBI, bool IJOOEOPFMIH)
	{
		if (BGPIGKODGBI != null)
		{
			GameObject gameObject = BGPIGKODGBI.gameObject;
			UIWidget component = gameObject.GetComponent<UIWidget>();
			if (component != null)
			{
				Vector3[] localCorners = component.get_localCorners();
				BGPIGKODGBI.offset = Vector3.Lerp(localCorners[0], localCorners[2], 0.5f);
				BGPIGKODGBI.size = localCorners[2] - localCorners[0];
			}
			else
			{
				Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(gameObject.transform, IJOOEOPFMIH);
				BGPIGKODGBI.offset = bounds.center;
				BGPIGKODGBI.size = new Vector2(bounds.size.x, bounds.size.y);
			}
		}
	}

	public static string OEPINOGBBJK<T>()
	{
		string text = typeof(T).ToString();
		if (text.StartsWith("UI"))
		{
			text = text.Substring(2);
		}
		else if (text.StartsWith("UnityEngine."))
		{
			text = text.Substring(12);
		}
		return text;
	}

	public static string OEPINOGBBJK(UnityEngine.Object HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI == null)
		{
			return "Null";
		}
		string text = HCKCCHPJOPI.GetType().ToString();
		if (text.StartsWith("UI"))
		{
			text = text.Substring(2);
		}
		else if (text.StartsWith("UnityEngine."))
		{
			text = text.Substring(12);
		}
		return text;
	}

	public static void NLBKLAFJFCP(UnityEngine.Object HCKCCHPJOPI, string NCADFOBAFJD)
	{
	}

	public static void KIODMNBCEMD(UnityEngine.Object HCKCCHPJOPI)
	{
	}

	public static GameObject MJFJKJOJJJJ(GameObject CBLFBICGAIA)
	{
		return MJFJKJOJJJJ(CBLFBICGAIA, true);
	}

	public static GameObject MJFJKJOJJJJ(GameObject CBLFBICGAIA, bool AEPFKOLCGAI)
	{
		GameObject gameObject = new GameObject();
		if (CBLFBICGAIA != null)
		{
			Transform transform = gameObject.transform;
			transform.parent = CBLFBICGAIA.transform;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			gameObject.layer = CBLFBICGAIA.layer;
		}
		return gameObject;
	}

	public static GameObject MJFJKJOJJJJ(GameObject CBLFBICGAIA, GameObject JAAAMFIKGAO)
	{
		GameObject gameObject = UnityEngine.Object.Instantiate(JAAAMFIKGAO) as GameObject;
		if (gameObject != null && CBLFBICGAIA != null)
		{
			Transform transform = gameObject.transform;
			transform.parent = CBLFBICGAIA.transform;
			transform.localPosition = Vector3.zero;
			transform.localRotation = Quaternion.identity;
			transform.localScale = Vector3.one;
			gameObject.layer = CBLFBICGAIA.layer;
		}
		return gameObject;
	}

	public static int DFPAKLJLAEK(GameObject LHACFNECMNA)
	{
		UIWidget component = LHACFNECMNA.GetComponent<UIWidget>();
		if (component != null)
		{
			return component.get_raycastDepth();
		}
		UIWidget[] componentsInChildren = LHACFNECMNA.GetComponentsInChildren<UIWidget>();
		if (componentsInChildren.Length == 0)
		{
			return 0;
		}
		int num = int.MaxValue;
		int i = 0;
		for (int num2 = componentsInChildren.Length; i < num2; i++)
		{
			if (componentsInChildren[i].enabled)
			{
				num = Mathf.Min(num, componentsInChildren[i].get_raycastDepth());
			}
		}
		return num;
	}

	public static int IFLIJMLBPII(GameObject LHACFNECMNA)
	{
		int num = -1;
		UIWidget[] componentsInChildren = LHACFNECMNA.GetComponentsInChildren<UIWidget>();
		int i = 0;
		for (int num2 = componentsInChildren.Length; i < num2; i++)
		{
			num = Mathf.Max(num, componentsInChildren[i].get_depth());
		}
		return num + 1;
	}

	public static int IFLIJMLBPII(GameObject LHACFNECMNA, bool PJAFNPPJBIK)
	{
		if (PJAFNPPJBIK)
		{
			int num = -1;
			UIWidget[] componentsInChildren = LHACFNECMNA.GetComponentsInChildren<UIWidget>();
			int i = 0;
			for (int num2 = componentsInChildren.Length; i < num2; i++)
			{
				UIWidget uIWidget = componentsInChildren[i];
				if (!(uIWidget.get_cachedGameObject() != LHACFNECMNA) || (!(uIWidget.GetComponent<Collider>() != null) && !(uIWidget.GetComponent<Collider2D>() != null)))
				{
					num = Mathf.Max(num, uIWidget.get_depth());
				}
			}
			return num + 1;
		}
		return IFLIJMLBPII(LHACFNECMNA);
	}

	public static int MBHAPAHHAEG(GameObject LHACFNECMNA, int JGDFEHFHAKA)
	{
		if (LHACFNECMNA != null)
		{
			UIPanel component = LHACFNECMNA.GetComponent<UIPanel>();
			if (component != null)
			{
				UIPanel[] componentsInChildren = LHACFNECMNA.GetComponentsInChildren<UIPanel>(true);
				foreach (UIPanel uIPanel in componentsInChildren)
				{
					uIPanel.set_depth(uIPanel.get_depth() + JGDFEHFHAKA);
				}
				return 1;
			}
			UIWidget[] componentsInChildren2 = LHACFNECMNA.GetComponentsInChildren<UIWidget>(true);
			int j = 0;
			for (int num = componentsInChildren2.Length; j < num; j++)
			{
				UIWidget uIWidget = componentsInChildren2[j];
				uIWidget.set_depth(uIWidget.get_depth() + JGDFEHFHAKA);
			}
			return 2;
		}
		return 0;
	}

	public static void NJENOMFLCGN(GameObject LHACFNECMNA)
	{
		switch (MBHAPAHHAEG(LHACFNECMNA, 1000))
		{
		case 1:
			IPCDOJALAHL();
			break;
		case 2:
			DJEJLHFEPOA();
			break;
		}
	}

	public static void AGJACNNEGDG(GameObject LHACFNECMNA)
	{
		switch (MBHAPAHHAEG(LHACFNECMNA, -1000))
		{
		case 1:
			IPCDOJALAHL();
			break;
		case 2:
			DJEJLHFEPOA();
			break;
		}
	}

	public static void FNCOJFEOCLJ()
	{
		DJEJLHFEPOA();
		IPCDOJALAHL();
	}

	public static void DJEJLHFEPOA()
	{
		UIWidget[] array = MHMBABFFMHO<UIWidget>();
		int num = array.Length;
		if (num <= 0)
		{
			return;
		}
		Array.Sort(array, UIWidget.FullCompareFunc);
		int num2 = 0;
		int depth = array[0].get_depth();
		for (int i = 0; i < num; i++)
		{
			UIWidget uIWidget = array[i];
			if (uIWidget.get_depth() == depth)
			{
				uIWidget.set_depth(num2);
				continue;
			}
			depth = uIWidget.get_depth();
			uIWidget.set_depth(++num2);
		}
	}

	public static void IPCDOJALAHL()
	{
		UIPanel[] array = MHMBABFFMHO<UIPanel>();
		int num = array.Length;
		if (num <= 0)
		{
			return;
		}
		Array.Sort(array, UIPanel.CompareFunc);
		int num2 = 0;
		int depth = array[0].get_depth();
		for (int i = 0; i < num; i++)
		{
			UIPanel uIPanel = array[i];
			if (uIPanel.get_depth() == depth)
			{
				uIPanel.set_depth(num2);
				continue;
			}
			depth = uIPanel.get_depth();
			uIPanel.set_depth(++num2);
		}
	}

	public static UIPanel CHDLNKKKIBG(bool BALFNKFJIEP)
	{
		return CHDLNKKKIBG(null, BALFNKFJIEP, -1);
	}

	public static UIPanel CHDLNKKKIBG(bool BALFNKFJIEP, int DGLDFJMPHMJ)
	{
		return CHDLNKKKIBG(null, BALFNKFJIEP, DGLDFJMPHMJ);
	}

	public static UIPanel CHDLNKKKIBG(Transform FOMOIPPFLBA, bool BALFNKFJIEP, int DGLDFJMPHMJ)
	{
		UIRoot uIRoot = ((!(FOMOIPPFLBA != null)) ? null : ANPDHFFNJFD<UIRoot>(FOMOIPPFLBA.gameObject));
		if (uIRoot == null && UIRoot.list.Count > 0)
		{
			uIRoot = UIRoot.list[0];
		}
		if (uIRoot != null)
		{
			UICamera componentInChildren = uIRoot.GetComponentInChildren<UICamera>();
			if (componentInChildren != null && componentInChildren.GetComponent<Camera>().orthographic == BALFNKFJIEP)
			{
				FOMOIPPFLBA = null;
				uIRoot = null;
			}
		}
		if (uIRoot == null)
		{
			GameObject gameObject = MJFJKJOJJJJ(null, false);
			uIRoot = gameObject.AddComponent<UIRoot>();
			if (DGLDFJMPHMJ == -1)
			{
				DGLDFJMPHMJ = LayerMask.NameToLayer("UI");
			}
			if (DGLDFJMPHMJ == -1)
			{
				DGLDFJMPHMJ = LayerMask.NameToLayer("2D UI");
			}
			gameObject.layer = DGLDFJMPHMJ;
			if (BALFNKFJIEP)
			{
				gameObject.name = "UI Root (3D)";
				uIRoot.scalingStyle = UIRoot.GIBOFPNBLAM.FixedSize;
			}
			else
			{
				gameObject.name = "UI Root";
				uIRoot.scalingStyle = UIRoot.GIBOFPNBLAM.PixelPerfect;
			}
		}
		UIPanel uIPanel = uIRoot.GetComponentInChildren<UIPanel>();
		if (uIPanel == null)
		{
			Camera[] array = MHMBABFFMHO<Camera>();
			float num = -1f;
			bool flag = false;
			int num2 = 1 << uIRoot.gameObject.layer;
			foreach (Camera camera in array)
			{
				if (camera.clearFlags == CameraClearFlags.Color || camera.clearFlags == CameraClearFlags.Skybox)
				{
					flag = true;
				}
				num = Mathf.Max(num, camera.depth);
				camera.cullingMask &= ~num2;
			}
			Camera camera2 = MJFJKJOJJJJ<Camera>(uIRoot.gameObject, false);
			camera2.gameObject.AddComponent<UICamera>();
			camera2.clearFlags = ((!flag) ? CameraClearFlags.Color : CameraClearFlags.Depth);
			camera2.backgroundColor = Color.grey;
			camera2.cullingMask = num2;
			camera2.depth = num + 1f;
			if (BALFNKFJIEP)
			{
				camera2.nearClipPlane = 0.1f;
				camera2.farClipPlane = 4f;
				camera2.transform.localPosition = new Vector3(0f, 0f, -700f);
			}
			else
			{
				camera2.orthographic = true;
				camera2.orthographicSize = 1f;
				camera2.nearClipPlane = -10f;
				camera2.farClipPlane = 10f;
			}
			AudioListener[] array2 = MHMBABFFMHO<AudioListener>();
			if (array2 == null || array2.Length == 0)
			{
				camera2.gameObject.AddComponent<AudioListener>();
			}
			uIPanel = uIRoot.gameObject.AddComponent<UIPanel>();
		}
		if (FOMOIPPFLBA != null)
		{
			while (FOMOIPPFLBA.parent != null)
			{
				FOMOIPPFLBA = FOMOIPPFLBA.parent;
			}
			if (OGKEPGLNHDJ(FOMOIPPFLBA, uIPanel.transform))
			{
				uIPanel = FOMOIPPFLBA.gameObject.AddComponent<UIPanel>();
			}
			else
			{
				FOMOIPPFLBA.parent = uIPanel.transform;
				FOMOIPPFLBA.localScale = Vector3.one;
				FOMOIPPFLBA.localPosition = Vector3.zero;
				NFNAAEACMAL(uIPanel.get_cachedTransform(), uIPanel.get_cachedGameObject().layer);
			}
		}
		return uIPanel;
	}

	public static void NFNAAEACMAL(Transform FFMBLAOKAKN, int DGLDFJMPHMJ)
	{
		for (int i = 0; i < FFMBLAOKAKN.childCount; i++)
		{
			Transform child = FFMBLAOKAKN.GetChild(i);
			child.gameObject.layer = DGLDFJMPHMJ;
			NFNAAEACMAL(child, DGLDFJMPHMJ);
		}
	}

	public static T MJFJKJOJJJJ<T>(GameObject CBLFBICGAIA) where T : Component
	{
		GameObject gameObject = MJFJKJOJJJJ(CBLFBICGAIA);
		gameObject.name = OEPINOGBBJK<T>();
		return gameObject.AddComponent<T>();
	}

	public static T MJFJKJOJJJJ<T>(GameObject CBLFBICGAIA, bool AEPFKOLCGAI) where T : Component
	{
		GameObject gameObject = MJFJKJOJJJJ(CBLFBICGAIA, AEPFKOLCGAI);
		gameObject.name = OEPINOGBBJK<T>();
		return gameObject.AddComponent<T>();
	}

	public static T EDDDFKNEJEN<T>(GameObject LHACFNECMNA) where T : UIWidget
	{
		int depth = IFLIJMLBPII(LHACFNECMNA);
		T result = MJFJKJOJJJJ<T>(LHACFNECMNA);
		result.set_width(100);
		result.set_height(100);
		result.set_depth(depth);
		result.gameObject.layer = LHACFNECMNA.layer;
		return result;
	}

	public static UISprite FLNELHLEDFB(GameObject LHACFNECMNA, UIAtlas FONGKNFGOBM, string ADNCNHHHCBF)
	{
		UISpriteData uISpriteData = ((!(FONGKNFGOBM != null)) ? null : FONGKNFGOBM.GetSprite(ADNCNHHHCBF));
		UISprite uISprite = EDDDFKNEJEN<UISprite>(LHACFNECMNA);
		uISprite.set_type((uISpriteData != null && uISpriteData.hasBorder) ? UIBasicSprite.ACPICCBBPHF.Sliced : UIBasicSprite.ACPICCBBPHF.Simple);
		uISprite.set_atlas(FONGKNFGOBM);
		uISprite.set_spriteName(ADNCNHHHCBF);
		return uISprite;
	}

	public static GameObject KHLEHBGOHLD(GameObject LHACFNECMNA)
	{
		Transform transform = LHACFNECMNA.transform;
		while (true)
		{
			Transform parent = transform.parent;
			if (parent == null)
			{
				break;
			}
			transform = parent;
		}
		return transform.gameObject;
	}

	public static T ANPDHFFNJFD<T>(GameObject LHACFNECMNA) where T : Component
	{
		if (LHACFNECMNA == null)
		{
			return (T)null;
		}
		T component = LHACFNECMNA.GetComponent<T>();
		if (component == null)
		{
			Transform parent = LHACFNECMNA.transform.parent;
			while (parent != null && component == null)
			{
				component = parent.gameObject.GetComponent<T>();
				parent = parent.parent;
			}
		}
		return component;
	}

	public static T ANPDHFFNJFD<T>(Transform FOMOIPPFLBA) where T : Component
	{
		if (FOMOIPPFLBA == null)
		{
			return (T)null;
		}
		T component = FOMOIPPFLBA.GetComponent<T>();
		if (component == null)
		{
			Transform parent = FOMOIPPFLBA.transform.parent;
			while (parent != null && component == null)
			{
				component = parent.gameObject.GetComponent<T>();
				parent = parent.parent;
			}
		}
		return component;
	}

	public static void HEAFKMJAOHM(UnityEngine.Object HCKCCHPJOPI)
	{
		if (!(HCKCCHPJOPI != null))
		{
			return;
		}
		if (Application.isPlaying)
		{
			if (HCKCCHPJOPI is GameObject)
			{
				GameObject gameObject = HCKCCHPJOPI as GameObject;
				gameObject.transform.parent = null;
			}
			UnityEngine.Object.Destroy(HCKCCHPJOPI);
		}
		else
		{
			UnityEngine.Object.DestroyImmediate(HCKCCHPJOPI);
		}
	}

	public static void LKPKIMCMIPG(UnityEngine.Object HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI != null)
		{
			if (Application.isEditor)
			{
				UnityEngine.Object.DestroyImmediate(HCKCCHPJOPI);
			}
			else
			{
				UnityEngine.Object.Destroy(HCKCCHPJOPI);
			}
		}
	}

	public static void NBFPGICCJGI(string BBKBHMHFFBK)
	{
		GameObject[] array = UnityEngine.Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		int i = 0;
		for (int num = array.Length; i < num; i++)
		{
			array[i].SendMessage(BBKBHMHFFBK, SendMessageOptions.DontRequireReceiver);
		}
	}

	public static void NBFPGICCJGI(string BBKBHMHFFBK, object DHMJKGNLEAD)
	{
		GameObject[] array = UnityEngine.Object.FindObjectsOfType(typeof(GameObject)) as GameObject[];
		int i = 0;
		for (int num = array.Length; i < num; i++)
		{
			array[i].SendMessage(BBKBHMHFFBK, DHMJKGNLEAD, SendMessageOptions.DontRequireReceiver);
		}
	}

	public static bool OGKEPGLNHDJ(Transform CBLFBICGAIA, Transform CDDLPPIEPMP)
	{
		if (CBLFBICGAIA == null || CDDLPPIEPMP == null)
		{
			return false;
		}
		while (CDDLPPIEPMP != null)
		{
			if (CDDLPPIEPMP == CBLFBICGAIA)
			{
				return true;
			}
			CDDLPPIEPMP = CDDLPPIEPMP.parent;
		}
		return false;
	}

	private static void OOMONGJIOAB(Transform FFMBLAOKAKN)
	{
		OOMONGJIOAB(FFMBLAOKAKN, false);
	}

	private static void OOMONGJIOAB(Transform FFMBLAOKAKN, bool BPDNIPMGDEM)
	{
		CDBICNLDIAF(FFMBLAOKAKN.gameObject, true);
		if (!BPDNIPMGDEM)
		{
			return;
		}
		int i = 0;
		for (int childCount = FFMBLAOKAKN.childCount; i < childCount; i++)
		{
			Transform child = FFMBLAOKAKN.GetChild(i);
			if (child.gameObject.activeSelf)
			{
				return;
			}
		}
		int j = 0;
		for (int childCount2 = FFMBLAOKAKN.childCount; j < childCount2; j++)
		{
			Transform child2 = FFMBLAOKAKN.GetChild(j);
			OOMONGJIOAB(child2, true);
		}
	}

	private static void NEFPLIAKOEE(Transform FFMBLAOKAKN)
	{
		CDBICNLDIAF(FFMBLAOKAKN.gameObject, false);
	}

	public static void ENFAJGGIEAI(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		ENFAJGGIEAI(LHACFNECMNA, EBILEBOJADB, true);
	}

	public static void ENFAJGGIEAI(GameObject LHACFNECMNA, bool EBILEBOJADB, bool BPDNIPMGDEM)
	{
		if ((bool)LHACFNECMNA)
		{
			if (EBILEBOJADB)
			{
				OOMONGJIOAB(LHACFNECMNA.transform, BPDNIPMGDEM);
				JGEIKLGJDPL(LHACFNECMNA.transform);
			}
			else
			{
				NEFPLIAKOEE(LHACFNECMNA.transform);
			}
		}
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	private static void JGEIKLGJDPL(Transform FFMBLAOKAKN)
	{
		UIWidget component = FFMBLAOKAKN.GetComponent<UIWidget>();
		if (component != null)
		{
			component.CreatePanel();
		}
		int i = 0;
		for (int childCount = FFMBLAOKAKN.childCount; i < childCount; i++)
		{
			JGEIKLGJDPL(FFMBLAOKAKN.GetChild(i));
		}
	}

	public static void MHBIBDMFHAK(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		Transform transform = LHACFNECMNA.transform;
		if (EBILEBOJADB)
		{
			int i = 0;
			for (int childCount = transform.childCount; i < childCount; i++)
			{
				Transform child = transform.GetChild(i);
				OOMONGJIOAB(child);
			}
		}
		else
		{
			int j = 0;
			for (int childCount2 = transform.childCount; j < childCount2; j++)
			{
				Transform child2 = transform.GetChild(j);
				NEFPLIAKOEE(child2);
			}
		}
	}

	[Obsolete("Use NGUITools.GetActive instead")]
	public static bool NHKIEEJHEJH(Behaviour KLCGKDMCCON)
	{
		return KLCGKDMCCON != null && KLCGKDMCCON.enabled && KLCGKDMCCON.gameObject.activeInHierarchy;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool FGIDLKLMBHB(Behaviour KLCGKDMCCON)
	{
		return (bool)KLCGKDMCCON && KLCGKDMCCON.enabled && KLCGKDMCCON.gameObject.activeInHierarchy;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public static bool FGIDLKLMBHB(GameObject LHACFNECMNA)
	{
		return (bool)LHACFNECMNA && LHACFNECMNA.activeInHierarchy;
	}

	[DebuggerStepThrough]
	[DebuggerHidden]
	public static void CDBICNLDIAF(GameObject LHACFNECMNA, bool EBILEBOJADB)
	{
		LHACFNECMNA.SetActive(EBILEBOJADB);
	}

	public static void ALBBBNDACDD(GameObject LHACFNECMNA, int DGLDFJMPHMJ)
	{
		LHACFNECMNA.layer = DGLDFJMPHMJ;
		Transform transform = LHACFNECMNA.transform;
		int i = 0;
		for (int childCount = transform.childCount; i < childCount; i++)
		{
			Transform child = transform.GetChild(i);
			ALBBBNDACDD(child.gameObject, DGLDFJMPHMJ);
		}
	}

	public static Vector3 KGBNMNFDBED(Vector3 FCGJBBHEOFJ)
	{
		FCGJBBHEOFJ.x = Mathf.Round(FCGJBBHEOFJ.x);
		FCGJBBHEOFJ.y = Mathf.Round(FCGJBBHEOFJ.y);
		FCGJBBHEOFJ.z = Mathf.Round(FCGJBBHEOFJ.z);
		return FCGJBBHEOFJ;
	}

	public static void EKLDFOODNKJ(Transform FFMBLAOKAKN)
	{
		UIWidget component = FFMBLAOKAKN.GetComponent<UIWidget>();
		if (component != null)
		{
			component.MakePixelPerfect();
		}
		if (FFMBLAOKAKN.GetComponent<UIAnchor>() == null && FFMBLAOKAKN.GetComponent<UIRoot>() == null)
		{
			FFMBLAOKAKN.localPosition = KGBNMNFDBED(FFMBLAOKAKN.localPosition);
			FFMBLAOKAKN.localScale = KGBNMNFDBED(FFMBLAOKAKN.localScale);
		}
		int i = 0;
		for (int childCount = FFMBLAOKAKN.childCount; i < childCount; i++)
		{
			EKLDFOODNKJ(FFMBLAOKAKN.GetChild(i));
		}
	}

	public static bool GMDNFBKIDMG(string LOGBKDOCDLI, byte[] EOOFAKHOBPM)
	{
		if (!ADJICBBFPBG())
		{
			return false;
		}
		string path = Application.persistentDataPath + "/" + LOGBKDOCDLI;
		if (EOOFAKHOBPM == null)
		{
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			return true;
		}
		FileStream fileStream = null;
		try
		{
			fileStream = File.Create(path);
		}
		catch (Exception ex)
		{
			UnityEngine.Debug.LogError(ex.Message);
			return false;
		}
		fileStream.Write(EOOFAKHOBPM, 0, EOOFAKHOBPM.Length);
		fileStream.Close();
		return true;
	}

	public static byte[] AOBEBHBHAHB(string LOGBKDOCDLI)
	{
		if (!ADJICBBFPBG())
		{
			return null;
		}
		string path = Application.persistentDataPath + "/" + LOGBKDOCDLI;
		if (File.Exists(path))
		{
			return File.ReadAllBytes(path);
		}
		return null;
	}

	public static Color CPFGKGLEIKJ(Color CEMGPCOMLOP)
	{
		if (CEMGPCOMLOP.a != 1f)
		{
			CEMGPCOMLOP.r *= CEMGPCOMLOP.a;
			CEMGPCOMLOP.g *= CEMGPCOMLOP.a;
			CEMGPCOMLOP.b *= CEMGPCOMLOP.a;
		}
		return CEMGPCOMLOP;
	}

	public static void NADGFEKBOIH(GameObject LHACFNECMNA)
	{
		UIRect[] componentsInChildren = LHACFNECMNA.GetComponentsInChildren<UIRect>();
		int i = 0;
		for (int num = componentsInChildren.Length; i < num; i++)
		{
			componentsInChildren[i].ParentHasChanged();
		}
	}

	public static string NGAMPPOJCHJ()
	{
		TextEditor textEditor = new TextEditor();
		textEditor.Paste();
		return textEditor.text;
	}

	public static void DJILPNJPOPC(string ICENKPDOHBK)
	{
		TextEditor textEditor = new TextEditor();
		textEditor.text = ICENKPDOHBK;
		textEditor.OnFocus();
		textEditor.Copy();
	}

	[Obsolete("Use NGUIText.EncodeColor instead")]
	public static string CMILNJAOOCB(Color CEMGPCOMLOP)
	{
		return MGDLEEIDDII.INJJFDNPJMD(CEMGPCOMLOP);
	}

	[Obsolete("Use NGUIText.ParseColor instead")]
	public static Color LMBKNJGDFLG(string BMNKKBDCELE, int BFEECILPJLM)
	{
		return MGDLEEIDDII.DFHHEKCDFGD(BMNKKBDCELE, BFEECILPJLM);
	}

	[Obsolete("Use NGUIText.StripSymbols instead")]
	public static string AFNLFGAHKKC(string BMNKKBDCELE)
	{
		return MGDLEEIDDII.AFNLFGAHKKC(BMNKKBDCELE);
	}

	public static T OMIOCEFCNIO<T>(this GameObject LHACFNECMNA) where T : Component
	{
		T val = LHACFNECMNA.GetComponent<T>();
		if (val == null)
		{
			val = LHACFNECMNA.AddComponent<T>();
		}
		return val;
	}

	public static Vector3[] EKECFKMAGNH(this Camera DDKDLNDJAMA)
	{
		return DDKDLNDJAMA.EKECFKMAGNH(Mathf.Lerp(DDKDLNDJAMA.nearClipPlane, DDKDLNDJAMA.farClipPlane, 0.5f), null);
	}

	public static Vector3[] EKECFKMAGNH(this Camera DDKDLNDJAMA, float OHHJPFKMMOB)
	{
		return DDKDLNDJAMA.EKECFKMAGNH(OHHJPFKMMOB, null);
	}

	public static Vector3[] EKECFKMAGNH(this Camera DDKDLNDJAMA, Transform DNIFGOKCBEL)
	{
		return DDKDLNDJAMA.EKECFKMAGNH(Mathf.Lerp(DDKDLNDJAMA.nearClipPlane, DDKDLNDJAMA.farClipPlane, 0.5f), DNIFGOKCBEL);
	}

	public static Vector3[] EKECFKMAGNH(this Camera DDKDLNDJAMA, float OHHJPFKMMOB, Transform DNIFGOKCBEL)
	{
		OMFIAGADNDK[0] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(0f, 0.5f, OHHJPFKMMOB));
		OMFIAGADNDK[1] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(0.5f, 1f, OHHJPFKMMOB));
		OMFIAGADNDK[2] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(1f, 0.5f, OHHJPFKMMOB));
		OMFIAGADNDK[3] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(0.5f, 0f, OHHJPFKMMOB));
		if (DNIFGOKCBEL != null)
		{
			for (int i = 0; i < 4; i++)
			{
				OMFIAGADNDK[i] = DNIFGOKCBEL.InverseTransformPoint(OMFIAGADNDK[i]);
			}
		}
		return OMFIAGADNDK;
	}

	public static Vector3[] GJJFCFJDPCA(this Camera DDKDLNDJAMA)
	{
		return DDKDLNDJAMA.GJJFCFJDPCA(Mathf.Lerp(DDKDLNDJAMA.nearClipPlane, DDKDLNDJAMA.farClipPlane, 0.5f), null);
	}

	public static Vector3[] GJJFCFJDPCA(this Camera DDKDLNDJAMA, float OHHJPFKMMOB)
	{
		return DDKDLNDJAMA.GJJFCFJDPCA(OHHJPFKMMOB, null);
	}

	public static Vector3[] GJJFCFJDPCA(this Camera DDKDLNDJAMA, Transform DNIFGOKCBEL)
	{
		return DDKDLNDJAMA.GJJFCFJDPCA(Mathf.Lerp(DDKDLNDJAMA.nearClipPlane, DDKDLNDJAMA.farClipPlane, 0.5f), DNIFGOKCBEL);
	}

	public static Vector3[] GJJFCFJDPCA(this Camera DDKDLNDJAMA, float OHHJPFKMMOB, Transform DNIFGOKCBEL)
	{
		OMFIAGADNDK[0] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(0f, 0f, OHHJPFKMMOB));
		OMFIAGADNDK[1] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(0f, 1f, OHHJPFKMMOB));
		OMFIAGADNDK[2] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(1f, 1f, OHHJPFKMMOB));
		OMFIAGADNDK[3] = DDKDLNDJAMA.ViewportToWorldPoint(new Vector3(1f, 0f, OHHJPFKMMOB));
		if (DNIFGOKCBEL != null)
		{
			for (int i = 0; i < 4; i++)
			{
				OMFIAGADNDK[i] = DNIFGOKCBEL.InverseTransformPoint(OMFIAGADNDK[i]);
			}
		}
		return OMFIAGADNDK;
	}

	public static string JEHNHBDJHMJ(object HCKCCHPJOPI, string HMFMCLLFDPC)
	{
		if (HCKCCHPJOPI == null)
		{
			return "<null>";
		}
		string text = HCKCCHPJOPI.GetType().ToString();
		int num = text.LastIndexOf('/');
		if (num > 0)
		{
			text = text.Substring(num + 1);
		}
		return (!string.IsNullOrEmpty(HMFMCLLFDPC)) ? (text + "/" + HMFMCLLFDPC) : text;
	}

	public static void MKPMEAMPDLJ<T>(GameObject LHACFNECMNA, string BBKBHMHFFBK) where T : Component
	{
		T[] components = LHACFNECMNA.GetComponents<T>();
		T[] array = components;
		for (int i = 0; i < array.Length; i++)
		{
			T obj = array[i];
			MethodInfo method = obj.GetType().GetMethod(BBKBHMHFFBK, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (method != null)
			{
				method.Invoke(obj, null);
			}
		}
	}

	public static void MFBNIPBFPIJ<T>(GameObject FHBEKMLLJPI, string BBKBHMHFFBK) where T : Component
	{
		MKPMEAMPDLJ<T>(FHBEKMLLJPI, BBKBHMHFFBK);
		Transform transform = FHBEKMLLJPI.transform;
		int i = 0;
		for (int childCount = transform.childCount; i < childCount; i++)
		{
			MFBNIPBFPIJ<T>(transform.GetChild(i).gameObject, BBKBHMHFFBK);
		}
	}

	public static void KBPIKHNEJIG(GameObject FHBEKMLLJPI)
	{
		MFBNIPBFPIJ<UIWidget>(FHBEKMLLJPI, "Start");
		MFBNIPBFPIJ<UIPanel>(FHBEKMLLJPI, "Start");
		MFBNIPBFPIJ<UIWidget>(FHBEKMLLJPI, "Update");
		MFBNIPBFPIJ<UIPanel>(FHBEKMLLJPI, "Update");
		MFBNIPBFPIJ<UIPanel>(FHBEKMLLJPI, "LateUpdate");
	}
}
