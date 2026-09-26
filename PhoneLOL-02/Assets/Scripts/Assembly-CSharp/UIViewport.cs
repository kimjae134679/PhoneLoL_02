using UnityEngine;

[AddComponentMenu("NGUI/UI/Viewport Camera")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class UIViewport : MonoBehaviour
{
	public Camera sourceCamera;

	public Transform topLeft;

	public Transform bottomRight;

	public float fullSize = 1f;

	private Camera OJNOBHMOJEG;

	private void PAJOOFIAPMI()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		if (sourceCamera == null)
		{
			sourceCamera = Camera.main;
		}
	}

	private void BGNGPCGPLOH()
	{
		if (topLeft != null && bottomRight != null)
		{
			Vector3 vector = sourceCamera.WorldToScreenPoint(topLeft.position);
			Vector3 vector2 = sourceCamera.WorldToScreenPoint(bottomRight.position);
			Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
			float num = fullSize * rect.height;
			if (rect != OJNOBHMOJEG.rect)
			{
				OJNOBHMOJEG.rect = rect;
			}
			if (OJNOBHMOJEG.orthographicSize != num)
			{
				OJNOBHMOJEG.orthographicSize = num;
			}
		}
	}

	private void LateUpdate()
	{
		if (topLeft != null && bottomRight != null)
		{
			Vector3 vector = sourceCamera.WorldToScreenPoint(topLeft.position);
			Vector3 vector2 = sourceCamera.WorldToScreenPoint(bottomRight.position);
			Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
			float num = fullSize * rect.height;
			if (rect != OJNOBHMOJEG.rect)
			{
				OJNOBHMOJEG.rect = rect;
			}
			if (OJNOBHMOJEG.orthographicSize != num)
			{
				OJNOBHMOJEG.orthographicSize = num;
			}
		}
	}

	private void Start()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		if (sourceCamera == null)
		{
			sourceCamera = Camera.main;
		}
	}

	private void NFKJIJFHBGK()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		if (sourceCamera == null)
		{
			sourceCamera = Camera.main;
		}
	}

	private void BPLOLCKEJJK()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		if (sourceCamera == null)
		{
			sourceCamera = Camera.main;
		}
	}

	private void GLHGKGENGCC()
	{
		if (topLeft != null && bottomRight != null)
		{
			Vector3 vector = sourceCamera.WorldToScreenPoint(topLeft.position);
			Vector3 vector2 = sourceCamera.WorldToScreenPoint(bottomRight.position);
			Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
			float num = fullSize * rect.height;
			if (rect != OJNOBHMOJEG.rect)
			{
				OJNOBHMOJEG.rect = rect;
			}
			if (OJNOBHMOJEG.orthographicSize != num)
			{
				OJNOBHMOJEG.orthographicSize = num;
			}
		}
	}

	private void GNCKMJCEMFA()
	{
		if (topLeft != null && bottomRight != null)
		{
			Vector3 vector = sourceCamera.WorldToScreenPoint(topLeft.position);
			Vector3 vector2 = sourceCamera.WorldToScreenPoint(bottomRight.position);
			Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
			float num = fullSize * rect.height;
			if (rect != OJNOBHMOJEG.rect)
			{
				OJNOBHMOJEG.rect = rect;
			}
			if (OJNOBHMOJEG.orthographicSize != num)
			{
				OJNOBHMOJEG.orthographicSize = num;
			}
		}
	}

	private void FGNDEBGCPFN()
	{
		if (topLeft != null && bottomRight != null)
		{
			Vector3 vector = sourceCamera.WorldToScreenPoint(topLeft.position);
			Vector3 vector2 = sourceCamera.WorldToScreenPoint(bottomRight.position);
			Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
			float num = fullSize * rect.height;
			if (rect != OJNOBHMOJEG.rect)
			{
				OJNOBHMOJEG.rect = rect;
			}
			if (OJNOBHMOJEG.orthographicSize != num)
			{
				OJNOBHMOJEG.orthographicSize = num;
			}
		}
	}

	private void LOFLFGMJMLH()
	{
		if (topLeft != null && bottomRight != null)
		{
			Vector3 vector = sourceCamera.WorldToScreenPoint(topLeft.position);
			Vector3 vector2 = sourceCamera.WorldToScreenPoint(bottomRight.position);
			Rect rect = new Rect(vector.x / (float)Screen.width, vector2.y / (float)Screen.height, (vector2.x - vector.x) / (float)Screen.width, (vector.y - vector2.y) / (float)Screen.height);
			float num = fullSize * rect.height;
			if (rect != OJNOBHMOJEG.rect)
			{
				OJNOBHMOJEG.rect = rect;
			}
			if (OJNOBHMOJEG.orthographicSize != num)
			{
				OJNOBHMOJEG.orthographicSize = num;
			}
		}
	}

	private void IMBGDEFOFEM()
	{
		OJNOBHMOJEG = base.GetComponent<Camera>();
		if (sourceCamera == null)
		{
			sourceCamera = Camera.main;
		}
	}
}
