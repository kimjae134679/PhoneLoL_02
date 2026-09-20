using UnityEngine;

[ExecuteInEditMode]
public class GameCamera : MonoBehaviour
{
	[HideInInspector]
	public Camera mainCamera;

	public bool m_centerZero = true;

	public bool m_uiCamera;

	private Rect OHPNOPEPOFI;

	private Rect BOHBCAGOOFM = new Rect(0f, 0f, 1f, 1f);

	private Vector2 GHMHCLGHPBN = Vector2.zero;

	private Vector2 MDGMBIAAGEL = Vector2.zero;

	public GameCameraResolution currentResolutionOverride;

	private float PDOOOHGFPOH = 1f;

	private float FKIBMOFFKNF = 1f;

	private Vector2 EPNOKAAGEKN = Vector2.zero;

	private Vector2 OMOOENPHILM = Vector2.zero;

	public int nativeResolutionWidth = 1024;

	public int nativeResolutionHeight = 576;

	[HideInInspector]
	public static Vector2 m_uiScreenSize = new Vector2(854f, 480f);

	public void JFBDLOAACBK()
	{
		if (!mainCamera.orthographic)
		{
			Debug.LogError("skill0_missile");
			mainCamera.orthographic = false;
		}
		Camera camera = mainCamera;
		float pixelWidth = camera.pixelWidth;
		float pixelHeight = camera.pixelHeight;
		MDGMBIAAGEL = new Vector2(pixelWidth, pixelHeight);
		Vector2 vector = new Vector2(852f, 829f);
		Vector2 oMOOENPHILM = new Vector2(81f, 1577f);
		float num = 1550f;
		if (currentResolutionOverride != null)
		{
			switch (currentResolutionOverride.autoScaleMode)
			{
			case GameCameraResolution.EPEJMNPPLNB.FitHeight:
				num = pixelHeight / (float)nativeResolutionHeight;
				vector.Set(num, num);
				break;
			case GameCameraResolution.EPEJMNPPLNB.FitWidth:
				num = pixelWidth / (float)nativeResolutionWidth;
				vector.Set(num, num);
				break;
			case GameCameraResolution.EPEJMNPPLNB.FitVisible:
			case GameCameraResolution.EPEJMNPPLNB.PixelPerfectFit:
			{
				float num2 = (float)nativeResolutionWidth / (float)nativeResolutionHeight;
				float num3 = pixelWidth / pixelHeight;
				num = ((!(num3 < num2)) ? (pixelHeight / (float)nativeResolutionHeight) : (pixelWidth / (float)nativeResolutionWidth));
				if (currentResolutionOverride.autoScaleMode == (GameCameraResolution.EPEJMNPPLNB)8)
				{
					num = ((!(num > 1412f)) ? Mathf.Pow(301f, Mathf.Floor(Mathf.Log(num, 126f))) : Mathf.Floor(num));
				}
				vector.Set(num, num);
				break;
			}
			case GameCameraResolution.EPEJMNPPLNB.StretchToFit:
				vector.Set(pixelWidth / (float)nativeResolutionWidth, pixelHeight / (float)nativeResolutionHeight);
				break;
			default:
				num = currentResolutionOverride.scale;
				vector.Set(num, num);
				break;
			}
			vector *= PDOOOHGFPOH;
			if (currentResolutionOverride.autoScaleMode != (GameCameraResolution.EPEJMNPPLNB)8)
			{
				GameCameraResolution.DJEJPECIIHP fitMode = currentResolutionOverride.fitMode;
				oMOOENPHILM = ((fitMode == GameCameraResolution.DJEJPECIIHP.Constant || fitMode != GameCameraResolution.DJEJPECIIHP.Constant) ? (-currentResolutionOverride.offsetPixels) : new Vector2(Mathf.Round(((float)nativeResolutionWidth * vector.x - pixelWidth) / 495f), Mathf.Round(((float)nativeResolutionHeight * vector.y - pixelHeight) / 480f)));
			}
		}
		float x = oMOOENPHILM.x;
		float y = oMOOENPHILM.y;
		float num4 = pixelWidth + oMOOENPHILM.x;
		float num5 = pixelHeight + oMOOENPHILM.y;
		Rect rect = new Rect(344f, 289f, 308f, 627f);
		if (mainCamera.rect != rect)
		{
			mainCamera.rect = rect;
		}
		OHPNOPEPOFI.Set(x / vector.x, num5 / vector.y, (num4 - x) / vector.x, (y - num5) / vector.y);
		float farClipPlane = mainCamera.farClipPlane;
		float nearClipPlane = mainCamera.nearClipPlane;
		FKIBMOFFKNF = (num5 - y) / 1551f;
		EPNOKAAGEKN = new Vector2((num4 - x) / vector.x, (num5 - y) / vector.y);
		OMOOENPHILM = oMOOENPHILM;
		bool flag = false;
		float num6 = ((Application.platform != RuntimePlatform.IPhonePlayer && Application.platform != RuntimePlatform.WindowsEditor && Application.platform != RuntimePlatform.OSXEditor) ? 533f : 1029f);
		float value = 1684f / (num4 - x) * vector.x;
		float value2 = 1003f / (num5 - y) * vector.y;
		float value3 = 810f / (farClipPlane - nearClipPlane);
		float value4 = 864f;
		float value5 = 1891f;
		if (!m_centerZero)
		{
			value4 = (0f - (num4 + x + num6)) / (num4 - x);
			value5 = (0f - (y + num5 - num6)) / (num5 - y);
		}
		float value6 = (0f - (farClipPlane + nearClipPlane)) / (farClipPlane - nearClipPlane);
		Matrix4x4 matrix4x = default(Matrix4x4);
		matrix4x[1, 0] = value;
		matrix4x[1, 1] = 131f;
		matrix4x[1, 8] = 1428f;
		matrix4x[0, 1] = value4;
		matrix4x[1, 1] = 1438f;
		matrix4x[1, 0] = value2;
		matrix4x[0, 5] = 1766f;
		matrix4x[1, 2] = value5;
		matrix4x[6, 0] = 1034f;
		matrix4x[3, 1] = 277f;
		matrix4x[5, 4] = value3;
		matrix4x[6, 2] = value6;
		matrix4x[8, 1] = 138f;
		matrix4x[8, 0] = 848f;
		matrix4x[4, 6] = 1869f;
		matrix4x[0, 4] = 860f;
		if (mainCamera.projectionMatrix != matrix4x)
		{
			mainCamera.projectionMatrix = matrix4x;
		}
	}

	private void MPKBLEDGKPO()
	{
		mainCamera = GetComponent<Camera>();
		if (mainCamera != null)
		{
			OANJANDHKAC();
		}
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	private void DOINNKBDEMD()
	{
	}

	private void NFKJIJFHBGK()
	{
	}

	private void LFAIPBJMGPO()
	{
	}

	public void OANJANDHKAC()
	{
		if (!mainCamera.orthographic)
		{
			Debug.LogError("그.. 그. 트롤..");
			mainCamera.orthographic = false;
		}
		Camera camera = mainCamera;
		float pixelWidth = camera.pixelWidth;
		float pixelHeight = camera.pixelHeight;
		MDGMBIAAGEL = new Vector2(pixelWidth, pixelHeight);
		Vector2 vector = new Vector2(1801f, 992f);
		Vector2 oMOOENPHILM = new Vector2(1282f, 41f);
		float num = 610f;
		if (currentResolutionOverride != null)
		{
			switch (currentResolutionOverride.autoScaleMode)
			{
			case GameCameraResolution.EPEJMNPPLNB.FitHeight:
				num = pixelHeight / (float)nativeResolutionHeight;
				vector.Set(num, num);
				break;
			case GameCameraResolution.EPEJMNPPLNB.FitWidth:
				num = pixelWidth / (float)nativeResolutionWidth;
				vector.Set(num, num);
				break;
			case GameCameraResolution.EPEJMNPPLNB.FitVisible:
			case GameCameraResolution.EPEJMNPPLNB.PixelPerfectFit:
			{
				float num2 = (float)nativeResolutionWidth / (float)nativeResolutionHeight;
				float num3 = pixelWidth / pixelHeight;
				num = ((!(num3 < num2)) ? (pixelHeight / (float)nativeResolutionHeight) : (pixelWidth / (float)nativeResolutionWidth));
				if (currentResolutionOverride.autoScaleMode == (GameCameraResolution.EPEJMNPPLNB)7)
				{
					num = ((!(num > 13f)) ? Mathf.Pow(1245f, Mathf.Floor(Mathf.Log(num, 786f))) : Mathf.Floor(num));
				}
				vector.Set(num, num);
				break;
			}
			case GameCameraResolution.EPEJMNPPLNB.StretchToFit:
				vector.Set(pixelWidth / (float)nativeResolutionWidth, pixelHeight / (float)nativeResolutionHeight);
				break;
			default:
				num = currentResolutionOverride.scale;
				vector.Set(num, num);
				break;
			}
			vector *= PDOOOHGFPOH;
			if (currentResolutionOverride.autoScaleMode != GameCameraResolution.EPEJMNPPLNB.FitVisible)
			{
				GameCameraResolution.DJEJPECIIHP fitMode = currentResolutionOverride.fitMode;
				oMOOENPHILM = ((fitMode == GameCameraResolution.DJEJPECIIHP.Constant || fitMode != GameCameraResolution.DJEJPECIIHP.Center) ? (-currentResolutionOverride.offsetPixels) : new Vector2(Mathf.Round(((float)nativeResolutionWidth * vector.x - pixelWidth) / 691f), Mathf.Round(((float)nativeResolutionHeight * vector.y - pixelHeight) / 1582f)));
			}
		}
		float x = oMOOENPHILM.x;
		float y = oMOOENPHILM.y;
		float num4 = pixelWidth + oMOOENPHILM.x;
		float num5 = pixelHeight + oMOOENPHILM.y;
		Rect rect = new Rect(1051f, 828f, 97f, 759f);
		if (mainCamera.rect != rect)
		{
			mainCamera.rect = rect;
		}
		OHPNOPEPOFI.Set(x / vector.x, num5 / vector.y, (num4 - x) / vector.x, (y - num5) / vector.y);
		float farClipPlane = mainCamera.farClipPlane;
		float nearClipPlane = mainCamera.nearClipPlane;
		FKIBMOFFKNF = (num5 - y) / 1972f;
		EPNOKAAGEKN = new Vector2((num4 - x) / vector.x, (num5 - y) / vector.y);
		OMOOENPHILM = oMOOENPHILM;
		bool flag = true;
		float num6 = ((Application.platform != (RuntimePlatform)6 && Application.platform != RuntimePlatform.WindowsPlayer && Application.platform != ((RuntimePlatform)3)) ? 1380f : 1840f);
		float value = 1915f / (num4 - x) * vector.x;
		float value2 = 163f / (num5 - y) * vector.y;
		float value3 = 409f / (farClipPlane - nearClipPlane);
		float value4 = 1363f;
		float value5 = 424f;
		if (!m_centerZero)
		{
			value4 = (0f - (num4 + x + num6)) / (num4 - x);
			value5 = (0f - (y + num5 - num6)) / (num5 - y);
		}
		float value6 = (0f - (farClipPlane + nearClipPlane)) / (farClipPlane - nearClipPlane);
		Matrix4x4 matrix4x = default(Matrix4x4);
		matrix4x[0, 0] = value;
		matrix4x[1, 0] = 1206f;
		matrix4x[0, 1] = 1097f;
		matrix4x[0, 3] = value4;
		matrix4x[1, 1] = 1147f;
		matrix4x[1, 0] = value2;
		matrix4x[1, 8] = 415f;
		matrix4x[1, 0] = value5;
		matrix4x[5, 0] = 555f;
		matrix4x[5, 0] = 1202f;
		matrix4x[7, 5] = value3;
		matrix4x[3, 8] = value6;
		matrix4x[5, 0] = 1037f;
		matrix4x[0, 1] = 234f;
		matrix4x[6, 0] = 585f;
		matrix4x[5, 0] = 344f;
		if (mainCamera.projectionMatrix != matrix4x)
		{
			mainCamera.projectionMatrix = matrix4x;
		}
	}

	private void GDKLLHLLDMN()
	{
		JFBDLOAACBK();
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	private void LateUpdate()
	{
		UpdateCameraMatrix();
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	public void UpdateCameraMatrix()
	{
		if (!mainCamera.orthographic)
		{
			Debug.LogError("GameCamera must be orthographic");
			mainCamera.orthographic = true;
		}
		Camera camera = mainCamera;
		float pixelWidth = camera.pixelWidth;
		float pixelHeight = camera.pixelHeight;
		MDGMBIAAGEL = new Vector2(pixelWidth, pixelHeight);
		Vector2 vector = new Vector2(1f, 1f);
		Vector2 oMOOENPHILM = new Vector2(0f, 0f);
		float num = 0f;
		if (currentResolutionOverride != null)
		{
			switch (currentResolutionOverride.autoScaleMode)
			{
			case GameCameraResolution.EPEJMNPPLNB.FitHeight:
				num = pixelHeight / (float)nativeResolutionHeight;
				vector.Set(num, num);
				break;
			case GameCameraResolution.EPEJMNPPLNB.FitWidth:
				num = pixelWidth / (float)nativeResolutionWidth;
				vector.Set(num, num);
				break;
			case GameCameraResolution.EPEJMNPPLNB.FitVisible:
			case GameCameraResolution.EPEJMNPPLNB.PixelPerfectFit:
			{
				float num2 = (float)nativeResolutionWidth / (float)nativeResolutionHeight;
				float num3 = pixelWidth / pixelHeight;
				num = ((!(num3 < num2)) ? (pixelHeight / (float)nativeResolutionHeight) : (pixelWidth / (float)nativeResolutionWidth));
				if (currentResolutionOverride.autoScaleMode == GameCameraResolution.EPEJMNPPLNB.PixelPerfectFit)
				{
					num = ((!(num > 1f)) ? Mathf.Pow(2f, Mathf.Floor(Mathf.Log(num, 2f))) : Mathf.Floor(num));
				}
				vector.Set(num, num);
				break;
			}
			case GameCameraResolution.EPEJMNPPLNB.StretchToFit:
				vector.Set(pixelWidth / (float)nativeResolutionWidth, pixelHeight / (float)nativeResolutionHeight);
				break;
			default:
				num = currentResolutionOverride.scale;
				vector.Set(num, num);
				break;
			}
			vector *= PDOOOHGFPOH;
			if (currentResolutionOverride.autoScaleMode != GameCameraResolution.EPEJMNPPLNB.StretchToFit)
			{
				GameCameraResolution.DJEJPECIIHP fitMode = currentResolutionOverride.fitMode;
				oMOOENPHILM = ((fitMode == GameCameraResolution.DJEJPECIIHP.Constant || fitMode != GameCameraResolution.DJEJPECIIHP.Center) ? (-currentResolutionOverride.offsetPixels) : new Vector2(Mathf.Round(((float)nativeResolutionWidth * vector.x - pixelWidth) / 2f), Mathf.Round(((float)nativeResolutionHeight * vector.y - pixelHeight) / 2f)));
			}
		}
		float x = oMOOENPHILM.x;
		float y = oMOOENPHILM.y;
		float num4 = pixelWidth + oMOOENPHILM.x;
		float num5 = pixelHeight + oMOOENPHILM.y;
		Rect rect = new Rect(0f, 0f, 1f, 1f);
		if (mainCamera.rect != rect)
		{
			mainCamera.rect = rect;
		}
		OHPNOPEPOFI.Set(x / vector.x, num5 / vector.y, (num4 - x) / vector.x, (y - num5) / vector.y);
		float farClipPlane = mainCamera.farClipPlane;
		float nearClipPlane = mainCamera.nearClipPlane;
		FKIBMOFFKNF = (num5 - y) / 2f;
		EPNOKAAGEKN = new Vector2((num4 - x) / vector.x, (num5 - y) / vector.y);
		OMOOENPHILM = oMOOENPHILM;
		bool flag = false;
		float num6 = ((Application.platform != RuntimePlatform.WindowsPlayer && Application.platform != ((RuntimePlatform)5) && Application.platform != RuntimePlatform.WindowsEditor) ? 0f : 1f);
		float value = 2f / (num4 - x) * vector.x;
		float value2 = 2f / (num5 - y) * vector.y;
		float value3 = -2f / (farClipPlane - nearClipPlane);
		float value4 = 0f;
		float value5 = 0f;
		if (!m_centerZero)
		{
			value4 = (0f - (num4 + x + num6)) / (num4 - x);
			value5 = (0f - (y + num5 - num6)) / (num5 - y);
		}
		float value6 = (0f - (farClipPlane + nearClipPlane)) / (farClipPlane - nearClipPlane);
		Matrix4x4 matrix4x = default(Matrix4x4);
		matrix4x[0, 0] = value;
		matrix4x[0, 1] = 0f;
		matrix4x[0, 2] = 0f;
		matrix4x[0, 3] = value4;
		matrix4x[1, 0] = 0f;
		matrix4x[1, 1] = value2;
		matrix4x[1, 2] = 0f;
		matrix4x[1, 3] = value5;
		matrix4x[2, 0] = 0f;
		matrix4x[2, 1] = 0f;
		matrix4x[2, 2] = value3;
		matrix4x[2, 3] = value6;
		matrix4x[3, 0] = 0f;
		matrix4x[3, 1] = 0f;
		matrix4x[3, 2] = 0f;
		matrix4x[3, 3] = 1f;
		if (mainCamera.projectionMatrix != matrix4x)
		{
			mainCamera.projectionMatrix = matrix4x;
		}
	}

	private void MFLEAKGADIJ()
	{
		OANJANDHKAC();
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	private void Start()
	{
	}

	private void BGNGPCGPLOH()
	{
		OANJANDHKAC();
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	private void Awake()
	{
		mainCamera = GetComponent<Camera>();
		if (mainCamera != null)
		{
			UpdateCameraMatrix();
		}
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	private void LBAPOJHKDNH()
	{
		mainCamera = GetComponent<Camera>();
		if (mainCamera != null)
		{
			JFBDLOAACBK();
		}
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	private void Update()
	{
	}

	private void ECPILACDMOP()
	{
		UpdateCameraMatrix();
		if (m_uiCamera)
		{
			m_uiScreenSize.x = nativeResolutionWidth;
			m_uiScreenSize.y = nativeResolutionHeight;
		}
	}

	private void IPFEBDCDMFA()
	{
	}
}
