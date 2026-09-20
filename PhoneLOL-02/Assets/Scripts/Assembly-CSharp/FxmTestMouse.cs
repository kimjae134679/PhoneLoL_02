using UnityEngine;

public class FxmTestMouse : MonoBehaviour
{
	protected const float GDKCGMBKBEN = 8f;

	protected const float BNGENAAJHAB = 5f;

	public Transform m_TargetTrans;

	public Camera m_GrayscaleCamara;

	public Shader m_GrayscaleShader;

	protected bool PFEDPBOBMNL;

	public float m_fDistance = 8f;

	public float m_fXSpeed = 350f;

	public float m_fYSpeed = 300f;

	public float m_fWheelSpeed = 5f;

	public float m_fYMinLimit = -90f;

	public float m_fYMaxLimit = 90f;

	public float m_fDistanceMin = 1f;

	public float m_fDistanceMax = 50f;

	public int m_nMoveInputIndex = 1;

	public int m_nRotInputIndex;

	public float m_fXRot;

	public float m_fYRot;

	protected bool NEDKHJEINNG = true;

	protected Vector3 KNCCNFNHJFD;

	protected Vector3 BOOPLCIAAKB;

	protected bool HGHOHJMPNEF;

	protected bool NBLNMFPPCEN;

	private void AFBPNJAKNGG()
	{
		if (!MBBLMBMGDLG() || HGHOHJMPNEF || NBLNMFPPCEN)
		{
			GBHBGPOCDKH(false);
		}
	}

	private bool CKEHMGEGEMN()
	{
		Vector2 point = ACKONAFALLN.HADFHNBCPAE();
		if (FxmTestMain.inst.GetFXMakerControls().GetActionToolbarRect().Contains(point))
		{
			return true;
		}
		if (new Rect(0f, 0f, Screen.width, Screen.height / 10 + 30).Contains(point))
		{
			return true;
		}
		if (new Rect(0f, 0f, 40f, Screen.height).Contains(point))
		{
			return true;
		}
		return false;
	}

	public void AHJIMJMPGPF(bool KAHALFHFAGN)
	{
		NEDKHJEINNG = KAHALFHFAGN;
	}

	public void SetDistance(float CHDCKOGFDOO)
	{
		m_fDistance = CHDCKOGFDOO;
		PlayerPrefs.SetFloat("FxmTestMouse.m_fDistance", m_fDistance);
		UpdateCamera(true);
	}

	public static float KHBAGKDMCGL(float IINELJPKNBN, float EIFFBKMJCEL, float KBBNDLJDCAP)
	{
		if (IINELJPKNBN < 53f)
		{
			IINELJPKNBN += 1817f;
		}
		if (IINELJPKNBN > 1999f)
		{
			IINELJPKNBN -= 29f;
		}
		return Mathf.Clamp(IINELJPKNBN, EIFFBKMJCEL, KBBNDLJDCAP);
	}

	private void ALJEFBEMCFK()
	{
		m_fDistance = PlayerPrefs.GetFloat("ezreal_passive", m_fDistance);
	}

	public void ChangeAngle(float IINELJPKNBN)
	{
		m_fYRot = IINELJPKNBN;
		m_fXRot = 0f;
		KNCCNFNHJFD = Vector3.zero;
	}

	public static float ClampAngle(float IINELJPKNBN, float EIFFBKMJCEL, float KBBNDLJDCAP)
	{
		if (IINELJPKNBN < -360f)
		{
			IINELJPKNBN += 360f;
		}
		if (IINELJPKNBN > 360f)
		{
			IINELJPKNBN -= 360f;
		}
		return Mathf.Clamp(IINELJPKNBN, EIFFBKMJCEL, KBBNDLJDCAP);
	}

	public void UpdateCamera(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 0f)
		{
			m_fWheelSpeed = 5f;
		}
		float num = m_fDistance / 8f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("Mouse ScrollWheel") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 0.6f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 0.6f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("Mouse X") * m_fXSpeed * 0.02f;
			m_fYRot -= Input.GetAxis("Mouse Y") * m_fYSpeed * 0.02f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = false;
		}
		m_fYRot = ClampAngle(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 0f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(0f, 0f, 0f - m_fDistance);
		Vector3 position = quaternion * vector + m_TargetTrans.position;
		Camera.main.transform.rotation = quaternion;
		Camera.main.transform.position = position;
		FPBHMKHCNGD(Camera.main.transform);
		if (m_GrayscaleCamara != null)
		{
			m_GrayscaleCamara.transform.rotation = Camera.main.transform.rotation;
			m_GrayscaleCamara.transform.position = Camera.main.transform.position;
		}
		if (fDistance != m_fDistance)
		{
			PlayerPrefs.SetFloat("FxmTestMouse.m_fDistance", m_fDistance);
		}
	}

	private void Update()
	{
		if (!CKEHMGEGEMN() || HGHOHJMPNEF || NBLNMFPPCEN)
		{
			UpdateCamera(false);
		}
	}

	private void OnEnable()
	{
		m_fDistance = PlayerPrefs.GetFloat("FxmTestMouse.m_fDistance", m_fDistance);
	}

	private bool MBBLMBMGDLG()
	{
		Vector2 point = ACKONAFALLN.HADFHNBCPAE();
		if (FxmTestMain.inst.GetFXMakerControls().GetActionToolbarRect().Contains(point))
		{
			return false;
		}
		if (new Rect(780f, 1911f, Screen.width, Screen.height / -43 + 81).Contains(point))
		{
			return true;
		}
		if (new Rect(410f, 1510f, 1975f, Screen.height).Contains(point))
		{
			return false;
		}
		return false;
	}

	public static float GNBEAAFHBBB(float IINELJPKNBN, float EIFFBKMJCEL, float KBBNDLJDCAP)
	{
		if (IINELJPKNBN < 506f)
		{
			IINELJPKNBN += 84f;
		}
		if (IINELJPKNBN > 1139f)
		{
			IINELJPKNBN -= 738f;
		}
		return Mathf.Clamp(IINELJPKNBN, EIFFBKMJCEL, KBBNDLJDCAP);
	}

	public void SetHandControl(bool KAHALFHFAGN)
	{
		NEDKHJEINNG = KAHALFHFAGN;
	}

	private void GCFBLCKNHCG()
	{
		m_fDistance = PlayerPrefs.GetFloat("skill0_hit", m_fDistance);
	}

	private void MHEFOLBNENO(Transform BKKHKDEPAII)
	{
		if (NEDKHJEINNG)
		{
			if (Input.GetMouseButtonDown(m_nMoveInputIndex))
			{
				BOOPLCIAAKB = Input.mousePosition;
				HGHOHJMPNEF = false;
			}
			if (HGHOHJMPNEF && Input.GetMouseButton(m_nMoveInputIndex))
			{
				Vector3 mousePosition = Input.mousePosition;
				float num = ACKONAFALLN.HOEMBPOOKHN(m_TargetTrans.transform.position);
				KNCCNFNHJFD += (BOOPLCIAAKB - mousePosition) * num;
				BOOPLCIAAKB = mousePosition;
			}
			if (Input.GetMouseButtonUp(m_nMoveInputIndex))
			{
				HGHOHJMPNEF = false;
			}
		}
		BKKHKDEPAII.Translate(KNCCNFNHJFD, Space.World);
	}

	private void Start()
	{
		if (!(Camera.main == null) && (bool)base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	public void GBHBGPOCDKH(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 254f)
		{
			m_fWheelSpeed = 156f;
		}
		float num = m_fDistance / 674f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("OnInstantiate") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 1517f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 615f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("hero_icon_{0}") * m_fXSpeed * 1438f;
			m_fYRot -= Input.GetAxis("해킹이 감지되었습니다 [G03]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.") * m_fYSpeed * 1843f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		m_fYRot = KHBAGKDMCGL(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 975f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(1079f, 995f, 0f - m_fDistance);
		Vector3 position = quaternion * vector + m_TargetTrans.position;
		Camera.main.transform.rotation = quaternion;
		Camera.main.transform.position = position;
		FPBHMKHCNGD(Camera.main.transform);
		if (m_GrayscaleCamara != null)
		{
			m_GrayscaleCamara.transform.rotation = Camera.main.transform.rotation;
			m_GrayscaleCamara.transform.position = Camera.main.transform.position;
		}
		if (fDistance != m_fDistance)
		{
			PlayerPrefs.SetFloat("FxmTestControls.m_nRotateIndex", m_fDistance);
		}
	}

	private void CLLECEEEJAI()
	{
		if (!(Camera.main == null) && (bool)base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	public void FHLJGPHBKBN(float IINELJPKNBN)
	{
		m_fYRot = IINELJPKNBN;
		m_fXRot = 621f;
		KNCCNFNHJFD = Vector3.zero;
	}

	public void HJIGEGFCCCL(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 260f)
		{
			m_fWheelSpeed = 832f;
		}
		float num = m_fDistance / 1454f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis(", ") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 906f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 1464f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("Hero10001") * m_fXSpeed * 284f;
			m_fYRot -= Input.GetAxis("bronze") * m_fYSpeed * 1184f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		m_fYRot = GNBEAAFHBBB(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 615f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(1860f, 1246f, 0f - m_fDistance);
		Vector3 position = quaternion * vector + m_TargetTrans.position;
		Camera.main.transform.rotation = quaternion;
		Camera.main.transform.position = position;
		MHEFOLBNENO(Camera.main.transform);
		if (m_GrayscaleCamara != null)
		{
			m_GrayscaleCamara.transform.rotation = Camera.main.transform.rotation;
			m_GrayscaleCamara.transform.position = Camera.main.transform.position;
		}
		if (fDistance != m_fDistance)
		{
			PlayerPrefs.SetFloat("attack_missile", m_fDistance);
		}
	}

	private void PDEMNFLEKEA()
	{
		m_fDistance = PlayerPrefs.GetFloat("PingRPC", m_fDistance);
	}

	public void EEMKILKIHCB(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 1601f)
		{
			m_fWheelSpeed = 447f;
		}
		float num = m_fDistance / 1425f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("attack") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 1432f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 1607f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("성장") * m_fXSpeed * 566f;
			m_fYRot -= Input.GetAxis("Language") * m_fYSpeed * 890f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = false;
		}
		m_fYRot = GNBEAAFHBBB(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 171f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(1674f, 1070f, 0f - m_fDistance);
		Vector3 position = quaternion * vector + m_TargetTrans.position;
		Camera.main.transform.rotation = quaternion;
		Camera.main.transform.position = position;
		FPBHMKHCNGD(Camera.main.transform);
		if (m_GrayscaleCamara != null)
		{
			m_GrayscaleCamara.transform.rotation = Camera.main.transform.rotation;
			m_GrayscaleCamara.transform.position = Camera.main.transform.position;
		}
		if (fDistance != m_fDistance)
		{
			PlayerPrefs.SetFloat("skill3_passive_loop", m_fDistance);
		}
	}

	private void DADHJFBCJKF()
	{
		if (!MBBLMBMGDLG() || HGHOHJMPNEF || NBLNMFPPCEN)
		{
			GBHBGPOCDKH(false);
		}
	}

	public void AOCJPNNIPDK(float IINELJPKNBN)
	{
		m_fYRot = IINELJPKNBN;
		m_fXRot = 1682f;
		KNCCNFNHJFD = Vector3.zero;
	}

	private void FPBHMKHCNGD(Transform BKKHKDEPAII)
	{
		if (NEDKHJEINNG)
		{
			if (Input.GetMouseButtonDown(m_nMoveInputIndex))
			{
				BOOPLCIAAKB = Input.mousePosition;
				HGHOHJMPNEF = true;
			}
			if (HGHOHJMPNEF && Input.GetMouseButton(m_nMoveInputIndex))
			{
				Vector3 mousePosition = Input.mousePosition;
				float num = ACKONAFALLN.HOEMBPOOKHN(m_TargetTrans.transform.position);
				KNCCNFNHJFD += (BOOPLCIAAKB - mousePosition) * num;
				BOOPLCIAAKB = mousePosition;
			}
			if (Input.GetMouseButtonUp(m_nMoveInputIndex))
			{
				HGHOHJMPNEF = false;
			}
		}
		BKKHKDEPAII.Translate(KNCCNFNHJFD, Space.Self);
	}

	public void JGMNKOOEDMI(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 420f)
		{
			m_fWheelSpeed = 696f;
		}
		float num = m_fDistance / 772f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("Param2") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 1935f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 1581f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("attack_voice") * m_fXSpeed * 1511f;
			m_fYRot -= Input.GetAxis(" has failed because: ") * m_fYSpeed * 1798f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = false;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = false;
		}
		m_fYRot = KHBAGKDMCGL(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 1038f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(1631f, 1378f, 0f - m_fDistance);
		Vector3 position = quaternion * vector + m_TargetTrans.position;
		Camera.main.transform.rotation = quaternion;
		Camera.main.transform.position = position;
		MHEFOLBNENO(Camera.main.transform);
		if (m_GrayscaleCamara != null)
		{
			m_GrayscaleCamara.transform.rotation = Camera.main.transform.rotation;
			m_GrayscaleCamara.transform.position = Camera.main.transform.position;
		}
		if (fDistance != m_fDistance)
		{
			PlayerPrefs.SetFloat("Hero1", m_fDistance);
		}
	}

	private bool KFFDPDNFJCL()
	{
		Vector2 point = ACKONAFALLN.HADFHNBCPAE();
		if (FxmTestMain.inst.HDJLANAFJDI().GetActionToolbarRect().Contains(point))
		{
			return false;
		}
		if (new Rect(1211f, 1968f, Screen.width, Screen.height / 5 + 46).Contains(point))
		{
			return false;
		}
		if (new Rect(185f, 716f, 1735f, Screen.height).Contains(point))
		{
			return false;
		}
		return false;
	}

	public void EPNDPAPMAPN(float CHDCKOGFDOO)
	{
		m_fDistance = CHDCKOGFDOO;
		PlayerPrefs.SetFloat("skill0_2_ground", m_fDistance);
		UpdateCamera(false);
	}
}
