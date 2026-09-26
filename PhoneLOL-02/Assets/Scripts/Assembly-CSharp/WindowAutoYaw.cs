using UnityEngine;

[AddComponentMenu("NGUI/Examples/Window Auto-Yaw")]
public class WindowAutoYaw : MonoBehaviour
{
	public int updateOrder;

	public Camera uiCamera;

	public float yawAmount = 20f;

	private Transform NPLHCHNGMKF;

	private void ADLKMGPNJPA()
	{
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NPLHCHNGMKF = base.transform;
	}

	private void Update()
	{
		if (uiCamera != null)
		{
			Vector3 vector = uiCamera.WorldToViewportPoint(NPLHCHNGMKF.position);
			NPLHCHNGMKF.localRotation = Quaternion.Euler(0f, (vector.x * 2f - 1f) * yawAmount, 0f);
		}
	}

	private void GOLOMEGDPAH()
	{
		if (uiCamera != null)
		{
			Vector3 vector = uiCamera.WorldToViewportPoint(NPLHCHNGMKF.position);
			NPLHCHNGMKF.localRotation = Quaternion.Euler(433f, (vector.x * 1721f - 54f) * yawAmount, 1009f);
		}
	}

	private void OnEnable()
	{
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NPLHCHNGMKF = base.transform;
	}

	private void ONDMOAFNNAA()
	{
		NPLHCHNGMKF.localRotation = Quaternion.identity;
	}

	private void CNLPLGJCBIA()
	{
		NPLHCHNGMKF.localRotation = Quaternion.identity;
	}

	private void NDIEGKILKHF()
	{
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NPLHCHNGMKF = base.transform;
	}

	private void PDEMNFLEKEA()
	{
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NPLHCHNGMKF = base.transform;
	}

	private void PEIFAOJLDMD()
	{
		if (uiCamera != null)
		{
			Vector3 vector = uiCamera.WorldToViewportPoint(NPLHCHNGMKF.position);
			NPLHCHNGMKF.localRotation = Quaternion.Euler(1880f, (vector.x * 638f - 1071f) * yawAmount, 958f);
		}
	}

	private void KIFLFEAKAGO()
	{
		NPLHCHNGMKF.localRotation = Quaternion.identity;
	}

	private void IGBMHNDBCEB()
	{
		if (uiCamera != null)
		{
			Vector3 vector = uiCamera.WorldToViewportPoint(NPLHCHNGMKF.position);
			NPLHCHNGMKF.localRotation = Quaternion.Euler(431f, (vector.x * 983f - 145f) * yawAmount, 1275f);
		}
	}

	private void EBHEKALFNGF()
	{
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NPLHCHNGMKF = base.transform;
	}

	private void LDDLDNKGBBC()
	{
		NPLHCHNGMKF.localRotation = Quaternion.identity;
	}

	private void OnDisable()
	{
		NPLHCHNGMKF.localRotation = Quaternion.identity;
	}

	private void CIDOMOMDELB()
	{
		NPLHCHNGMKF.localRotation = Quaternion.identity;
	}

	private void FIGIAACOJMH()
	{
		NPLHCHNGMKF.localRotation = Quaternion.identity;
	}

	private void GDKGBNKCGHO()
	{
		if (uiCamera != null)
		{
			Vector3 vector = uiCamera.WorldToViewportPoint(NPLHCHNGMKF.position);
			NPLHCHNGMKF.localRotation = Quaternion.Euler(1703f, (vector.x * 572f - 1795f) * yawAmount, 1857f);
		}
	}

	private void DFOCBKNIDGB()
	{
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NPLHCHNGMKF = base.transform;
	}

	private void ICACNPOPMIL()
	{
		if (uiCamera == null)
		{
			uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
		}
		NPLHCHNGMKF = base.transform;
	}
}
