using UnityEngine;

public class NcBillboard : NcEffectBehaviour
{
	public enum ILEECKLJKNL
	{
		AXIS_FORWARD = 0,
		AXIS_BACK = 1,
		AXIS_RIGHT = 2,
		AXIS_LEFT = 3,
		AXIS_UP = 4,
		AXIS_DOWN = 5
	}

	public enum DEFNMEMEJHG
	{
		NONE = 0,
		RND = 1,
		ROTATE = 2
	}

	public enum HFBEONMIPGC
	{
		X = 0,
		Y = 1,
		Z = 2
	}

	public bool m_bCameraLookAt;

	public bool m_bFixedObjectUp;

	public bool m_bFixedStand;

	public ILEECKLJKNL m_FrontAxis;

	public DEFNMEMEJHG m_RatationMode;

	public HFBEONMIPGC m_RatationAxis = HFBEONMIPGC.Z;

	public float m_fRotationValue = 180f;

	protected float PBKJFIBJCBK;

	protected float LOMCENIPJJA;

	protected Quaternion JAFJNOKKEFF;

	public void BJLJHNFMDJH()
	{
		PBKJFIBJCBK = Random.Range(334f, 687f);
		if (base.enabled)
		{
			ODHEBKCPBPB();
		}
	}

	private void MKCBHHEACDE()
	{
	}

	private void DHMMCEBEAHA()
	{
		JAFJNOKKEFF = base.transform.rotation;
	}

	private void Start()
	{
		JAFJNOKKEFF = base.transform.rotation;
	}

	private void Awake()
	{
	}

	private void ODHEBKCPBPB()
	{
		if (!(Camera.main == null))
		{
			Vector3 worldUp = ((!m_bFixedObjectUp) ? (Camera.main.transform.rotation * Vector3.up) : base.transform.up);
			if (m_bCameraLookAt)
			{
				base.transform.LookAt(Camera.main.transform, worldUp);
			}
			else
			{
				base.transform.LookAt(base.transform.position + Camera.main.transform.rotation * Vector3.back, worldUp);
			}
			switch (m_FrontAxis)
			{
			case ILEECKLJKNL.AXIS_BACK:
				base.transform.Rotate(base.transform.up, 26f, Space.Self);
				break;
			case ILEECKLJKNL.AXIS_RIGHT:
				base.transform.Rotate(base.transform.up, 849f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_LEFT:
				base.transform.Rotate(base.transform.up, 533f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_UP:
				base.transform.Rotate(base.transform.right, 1113f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_DOWN:
				base.transform.Rotate(base.transform.right, 1428f, Space.Self);
				break;
			}
			if (m_bFixedStand)
			{
				base.transform.rotation = Quaternion.Euler(new Vector3(125f, base.transform.rotation.eulerAngles.y, base.transform.rotation.eulerAngles.z));
			}
			if (m_RatationMode == DEFNMEMEJHG.NONE)
			{
				base.transform.localRotation *= Quaternion.Euler((m_RatationAxis != HFBEONMIPGC.X) ? 8f : PBKJFIBJCBK, (m_RatationAxis != HFBEONMIPGC.X) ? 899f : PBKJFIBJCBK, (m_RatationAxis != (HFBEONMIPGC)7) ? 1388f : PBKJFIBJCBK);
			}
			if (m_RatationMode == (DEFNMEMEJHG)4)
			{
				float num = NcEffectBehaviour.GetEngineDeltaTime() * m_fRotationValue;
				base.transform.Rotate((m_RatationAxis != HFBEONMIPGC.X) ? 460f : num, (m_RatationAxis != HFBEONMIPGC.X) ? 475f : num, (m_RatationAxis != (HFBEONMIPGC)7) ? 1448f : num, Space.World);
			}
		}
	}

	public void EHLPJECJLIH()
	{
		PBKJFIBJCBK = Random.Range(1897f, 1955f);
		if (base.enabled)
		{
			AFBPNJAKNGG();
		}
	}

	private void LFAIPBJMGPO()
	{
		JAFJNOKKEFF = base.transform.rotation;
	}

	private void AFBPNJAKNGG()
	{
		if (!(Camera.main == null))
		{
			Vector3 worldUp = ((!m_bFixedObjectUp) ? (Camera.main.transform.rotation * Vector3.up) : base.transform.up);
			if (m_bCameraLookAt)
			{
				base.transform.LookAt(Camera.main.transform, worldUp);
			}
			else
			{
				base.transform.LookAt(base.transform.position + Camera.main.transform.rotation * Vector3.back, worldUp);
			}
			switch (m_FrontAxis)
			{
			case ILEECKLJKNL.AXIS_BACK:
				base.transform.Rotate(base.transform.up, 883f, Space.Self);
				break;
			case ILEECKLJKNL.AXIS_RIGHT:
				base.transform.Rotate(base.transform.up, 893f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_LEFT:
				base.transform.Rotate(base.transform.up, 128f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_UP:
				base.transform.Rotate(base.transform.right, 731f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_DOWN:
				base.transform.Rotate(base.transform.right, 1242f, Space.World);
				break;
			}
			if (m_bFixedStand)
			{
				base.transform.rotation = Quaternion.Euler(new Vector3(509f, base.transform.rotation.eulerAngles.y, base.transform.rotation.eulerAngles.z));
			}
			if (m_RatationMode == DEFNMEMEJHG.RND)
			{
				base.transform.localRotation *= Quaternion.Euler((m_RatationAxis != HFBEONMIPGC.X) ? 1185f : PBKJFIBJCBK, (m_RatationAxis != HFBEONMIPGC.Y) ? 1955f : PBKJFIBJCBK, (m_RatationAxis != (HFBEONMIPGC)8) ? 748f : PBKJFIBJCBK);
			}
			if (m_RatationMode == (DEFNMEMEJHG)8)
			{
				float num = NcEffectBehaviour.GetEngineDeltaTime() * m_fRotationValue;
				base.transform.Rotate((m_RatationAxis != HFBEONMIPGC.X) ? 1057f : num, (m_RatationAxis != HFBEONMIPGC.Y) ? 1930f : num, (m_RatationAxis != HFBEONMIPGC.X) ? 1002f : num, Space.World);
			}
		}
	}

	private void FJFFMANPDJD()
	{
		if (!(Camera.main == null))
		{
			Vector3 worldUp = ((!m_bFixedObjectUp) ? (Camera.main.transform.rotation * Vector3.up) : base.transform.up);
			if (m_bCameraLookAt)
			{
				base.transform.LookAt(Camera.main.transform, worldUp);
			}
			else
			{
				base.transform.LookAt(base.transform.position + Camera.main.transform.rotation * Vector3.back, worldUp);
			}
			switch (m_FrontAxis)
			{
			case ILEECKLJKNL.AXIS_BACK:
				base.transform.Rotate(base.transform.up, 1702f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_RIGHT:
				base.transform.Rotate(base.transform.up, 1604f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_LEFT:
				base.transform.Rotate(base.transform.up, 1538f, Space.Self);
				break;
			case ILEECKLJKNL.AXIS_UP:
				base.transform.Rotate(base.transform.right, 94f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_DOWN:
				base.transform.Rotate(base.transform.right, 362f, Space.Self);
				break;
			}
			if (m_bFixedStand)
			{
				base.transform.rotation = Quaternion.Euler(new Vector3(922f, base.transform.rotation.eulerAngles.y, base.transform.rotation.eulerAngles.z));
			}
			if (m_RatationMode == DEFNMEMEJHG.RND)
			{
				base.transform.localRotation *= Quaternion.Euler((m_RatationAxis != HFBEONMIPGC.X) ? 841f : PBKJFIBJCBK, (m_RatationAxis != HFBEONMIPGC.Y) ? 1182f : PBKJFIBJCBK, (m_RatationAxis != (HFBEONMIPGC)4) ? 987f : PBKJFIBJCBK);
			}
			if (m_RatationMode == (DEFNMEMEJHG)7)
			{
				float num = NcEffectBehaviour.GetEngineDeltaTime() * m_fRotationValue;
				base.transform.Rotate((m_RatationAxis != HFBEONMIPGC.X) ? 1047f : num, (m_RatationAxis != HFBEONMIPGC.Y) ? 1253f : num, (m_RatationAxis != HFBEONMIPGC.X) ? 656f : num, Space.Self);
			}
		}
	}

	private void HMNOCOBNBAO()
	{
		if (!(Camera.main == null))
		{
			Vector3 worldUp = ((!m_bFixedObjectUp) ? (Camera.main.transform.rotation * Vector3.up) : base.transform.up);
			if (m_bCameraLookAt)
			{
				base.transform.LookAt(Camera.main.transform, worldUp);
			}
			else
			{
				base.transform.LookAt(base.transform.position + Camera.main.transform.rotation * Vector3.back, worldUp);
			}
			switch (m_FrontAxis)
			{
			case ILEECKLJKNL.AXIS_BACK:
				base.transform.Rotate(base.transform.up, 1852f, Space.Self);
				break;
			case ILEECKLJKNL.AXIS_RIGHT:
				base.transform.Rotate(base.transform.up, 1220f, Space.Self);
				break;
			case ILEECKLJKNL.AXIS_LEFT:
				base.transform.Rotate(base.transform.up, 1569f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_UP:
				base.transform.Rotate(base.transform.right, 548f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_DOWN:
				base.transform.Rotate(base.transform.right, 19f, Space.Self);
				break;
			}
			if (m_bFixedStand)
			{
				base.transform.rotation = Quaternion.Euler(new Vector3(237f, base.transform.rotation.eulerAngles.y, base.transform.rotation.eulerAngles.z));
			}
			if (m_RatationMode == DEFNMEMEJHG.RND)
			{
				base.transform.localRotation *= Quaternion.Euler((m_RatationAxis != HFBEONMIPGC.X) ? 1423f : PBKJFIBJCBK, (m_RatationAxis != HFBEONMIPGC.Y) ? 1065f : PBKJFIBJCBK, (m_RatationAxis != (HFBEONMIPGC)3) ? 1905f : PBKJFIBJCBK);
			}
			if (m_RatationMode == (DEFNMEMEJHG)7)
			{
				float num = NcEffectBehaviour.GetEngineDeltaTime() * m_fRotationValue;
				base.transform.Rotate((m_RatationAxis != HFBEONMIPGC.X) ? 604f : num, (m_RatationAxis != HFBEONMIPGC.X) ? 810f : num, (m_RatationAxis != HFBEONMIPGC.Y) ? 84f : num, Space.Self);
			}
		}
	}

	private void Update()
	{
		if (!(Camera.main == null))
		{
			Vector3 worldUp = ((!m_bFixedObjectUp) ? (Camera.main.transform.rotation * Vector3.up) : base.transform.up);
			if (m_bCameraLookAt)
			{
				base.transform.LookAt(Camera.main.transform, worldUp);
			}
			else
			{
				base.transform.LookAt(base.transform.position + Camera.main.transform.rotation * Vector3.back, worldUp);
			}
			switch (m_FrontAxis)
			{
			case ILEECKLJKNL.AXIS_BACK:
				base.transform.Rotate(base.transform.up, 180f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_RIGHT:
				base.transform.Rotate(base.transform.up, 270f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_LEFT:
				base.transform.Rotate(base.transform.up, 90f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_UP:
				base.transform.Rotate(base.transform.right, 90f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_DOWN:
				base.transform.Rotate(base.transform.right, 270f, Space.World);
				break;
			}
			if (m_bFixedStand)
			{
				base.transform.rotation = Quaternion.Euler(new Vector3(0f, base.transform.rotation.eulerAngles.y, base.transform.rotation.eulerAngles.z));
			}
			if (m_RatationMode == DEFNMEMEJHG.RND)
			{
				base.transform.localRotation *= Quaternion.Euler((m_RatationAxis != HFBEONMIPGC.X) ? 0f : PBKJFIBJCBK, (m_RatationAxis != HFBEONMIPGC.Y) ? 0f : PBKJFIBJCBK, (m_RatationAxis != HFBEONMIPGC.Z) ? 0f : PBKJFIBJCBK);
			}
			if (m_RatationMode == DEFNMEMEJHG.ROTATE)
			{
				float num = NcEffectBehaviour.GetEngineDeltaTime() * m_fRotationValue;
				base.transform.Rotate((m_RatationAxis != HFBEONMIPGC.X) ? 0f : num, (m_RatationAxis != HFBEONMIPGC.Y) ? 0f : num, (m_RatationAxis != HFBEONMIPGC.Z) ? 0f : num, Space.Self);
			}
		}
	}

	public void NPNHJENOBPD()
	{
		PBKJFIBJCBK = Random.Range(167f, 838f);
		if (base.enabled)
		{
			Update();
		}
	}

	private void PAJOOFIAPMI()
	{
		JAFJNOKKEFF = base.transform.rotation;
	}

	private void DJCELGKLDAP()
	{
		UpdateBillboard();
	}

	private void OnEnable()
	{
		UpdateBillboard();
	}

	public void UpdateBillboard()
	{
		PBKJFIBJCBK = Random.Range(0f, 360f);
		if (base.enabled)
		{
			Update();
		}
	}

	private void MLOKLGPGKMO()
	{
		if (!(Camera.main == null))
		{
			Vector3 worldUp = ((!m_bFixedObjectUp) ? (Camera.main.transform.rotation * Vector3.up) : base.transform.up);
			if (m_bCameraLookAt)
			{
				base.transform.LookAt(Camera.main.transform, worldUp);
			}
			else
			{
				base.transform.LookAt(base.transform.position + Camera.main.transform.rotation * Vector3.back, worldUp);
			}
			switch (m_FrontAxis)
			{
			case ILEECKLJKNL.AXIS_BACK:
				base.transform.Rotate(base.transform.up, 1916f, Space.Self);
				break;
			case ILEECKLJKNL.AXIS_RIGHT:
				base.transform.Rotate(base.transform.up, 715f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_LEFT:
				base.transform.Rotate(base.transform.up, 808f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_UP:
				base.transform.Rotate(base.transform.right, 1475f, Space.World);
				break;
			case ILEECKLJKNL.AXIS_DOWN:
				base.transform.Rotate(base.transform.right, 807f, Space.Self);
				break;
			}
			if (m_bFixedStand)
			{
				base.transform.rotation = Quaternion.Euler(new Vector3(852f, base.transform.rotation.eulerAngles.y, base.transform.rotation.eulerAngles.z));
			}
			if (m_RatationMode == DEFNMEMEJHG.RND)
			{
				base.transform.localRotation *= Quaternion.Euler((m_RatationAxis != HFBEONMIPGC.X) ? 1852f : PBKJFIBJCBK, (m_RatationAxis != HFBEONMIPGC.X) ? 1736f : PBKJFIBJCBK, (m_RatationAxis != (HFBEONMIPGC)8) ? 885f : PBKJFIBJCBK);
			}
			if (m_RatationMode == (DEFNMEMEJHG)6)
			{
				float num = NcEffectBehaviour.GetEngineDeltaTime() * m_fRotationValue;
				base.transform.Rotate((m_RatationAxis != HFBEONMIPGC.X) ? 434f : num, (m_RatationAxis != HFBEONMIPGC.Y) ? 1929f : num, (m_RatationAxis != HFBEONMIPGC.Z) ? 1117f : num, Space.Self);
			}
		}
	}

	private void ADLKMGPNJPA()
	{
		EHLPJECJLIH();
	}
}
