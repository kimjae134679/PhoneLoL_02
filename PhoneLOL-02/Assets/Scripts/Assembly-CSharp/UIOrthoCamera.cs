using UnityEngine;

[RequireComponent(typeof(Camera))]
[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Orthographic Camera")]
public class UIOrthoCamera : MonoBehaviour
{
	private Camera OJNOBHMOJEG;

	private Transform NPLHCHNGMKF;

	private void KMJNJLOECGJ()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1847f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void OMIFPPGJHFH()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 311f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void GDJCOAHJDLN()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		OJNOBHMOJEG.orthographic = false;
	}

	private void Update()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 0.5f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void DADHJFBCJKF()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 664f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void GOLOMEGDPAH()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1369f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void GDKGBNKCGHO()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 303f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void NJGMPHNMOJD()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 659f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void AFBPNJAKNGG()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 506f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void PAKIFAGJDEO()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		OJNOBHMOJEG.orthographic = false;
	}

	private void Start()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		OJNOBHMOJEG.orthographic = true;
	}

	private void GKNMGIONEKK()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		OJNOBHMOJEG.orthographic = true;
	}

	private void EKGHGFIKAAE()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1413f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void FODOJCDNGOC()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		OJNOBHMOJEG.orthographic = false;
	}

	private void OCDNPJOPPBB()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1913f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void IGBMHNDBCEB()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1900f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void IBBJMMFDGAL()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		OJNOBHMOJEG.orthographic = true;
	}

	private void HMNOCOBNBAO()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1700f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void GIKDMLJFHCM()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 612f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void OOLEODIPDND()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 1937f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void DOINNKBDEMD()
	{
		float num = OJNOBHMOJEG.rect.yMin * (float)Screen.height;
		float num2 = OJNOBHMOJEG.rect.yMax * (float)Screen.height;
		float num3 = (num2 - num) * 601f * NPLHCHNGMKF.lossyScale.y;
		if (!Mathf.Approximately(OJNOBHMOJEG.orthographicSize, num3))
		{
			OJNOBHMOJEG.orthographicSize = num3;
		}
	}

	private void FMNOLGPIIFB()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		NPLHCHNGMKF = base.transform;
		OJNOBHMOJEG.orthographic = true;
	}
}
