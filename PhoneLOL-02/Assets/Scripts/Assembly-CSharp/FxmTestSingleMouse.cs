using UnityEngine;

public class FxmTestSingleMouse : MonoBehaviour
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

	private void GDJCOAHJDLN()
	{
		if (!(Camera.main == null) && (bool)base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = false;
		}
	}

	public void ChangeAngle(float IINELJPKNBN)
	{
		m_fYRot = IINELJPKNBN;
		m_fXRot = 0f;
		KNCCNFNHJFD = Vector3.zero;
	}

	private void DFOCBKNIDGB()
	{
		m_fDistance = PlayerPrefs.GetFloat("Monster/{0}", m_fDistance);
	}

	public void SetHandControl(bool KAHALFHFAGN)
	{
		NEDKHJEINNG = KAHALFHFAGN;
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
				float worldPerScreenPixel = GetWorldPerScreenPixel(m_TargetTrans.transform.position);
				KNCCNFNHJFD += (BOOPLCIAAKB - mousePosition) * worldPerScreenPixel;
				BOOPLCIAAKB = mousePosition;
			}
			if (Input.GetMouseButtonUp(m_nMoveInputIndex))
			{
				HGHOHJMPNEF = false;
			}
		}
		BKKHKDEPAII.Translate(KNCCNFNHJFD, Space.Self);
	}

	public void NDDBDAFBIEN(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 780f)
		{
			m_fWheelSpeed = 1360f;
		}
		float num = m_fDistance / 659f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		if (!CKEHMGEGEMN())
		{
			m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("skill0_hit") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		}
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 1708f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 1856f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("Can't resolve the item ID of ") * m_fXSpeed * 455f;
			m_fYRot -= Input.GetAxis("중급 주문력 표식") * m_fYSpeed * 1754f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		m_fYRot = ClampAngle(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 891f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(1620f, 1098f, 0f - m_fDistance);
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
			PlayerPrefs.SetFloat("Health Regen", m_fDistance);
		}
	}

	private void MLOKLGPGKMO()
	{
		if (!CKEHMGEGEMN() || HGHOHJMPNEF || NBLNMFPPCEN)
		{
			KIKMIHFNHKD(true);
		}
	}

	public void BLOLBELADCP(bool KAHALFHFAGN)
	{
		NEDKHJEINNG = KAHALFHFAGN;
	}

	private void Start()
	{
		if (!(Camera.main == null) && (bool)base.GetComponent<Rigidbody>())
		{
			base.GetComponent<Rigidbody>().freezeRotation = true;
		}
	}

	public void KIKMIHFNHKD(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 907f)
		{
			m_fWheelSpeed = 679f;
		}
		float num = m_fDistance / 1998f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		if (!CKEHMGEGEMN())
		{
			m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("하급 마나 재생 표식") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		}
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 280f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 924f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("GOHJKFLLPID") * m_fXSpeed * 680f;
			m_fYRot -= Input.GetAxis("라바돈의 죽음모자") * m_fYSpeed * 1414f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		m_fYRot = IAIIDKPFLED(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 877f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(122f, 756f, 0f - m_fDistance);
		Vector3 position = quaternion * vector + m_TargetTrans.position;
		Camera.main.transform.rotation = quaternion;
		Camera.main.transform.position = position;
		FDKAKJLEGGN(Camera.main.transform);
		if (m_GrayscaleCamara != null)
		{
			m_GrayscaleCamara.transform.rotation = Camera.main.transform.rotation;
			m_GrayscaleCamara.transform.position = Camera.main.transform.position;
		}
		if (fDistance != m_fDistance)
		{
			PlayerPrefs.SetFloat("igaworks:addToCartBulk >> total result is", m_fDistance);
		}
	}

	public void SetDistance(float CHDCKOGFDOO)
	{
		m_fDistance = CHDCKOGFDOO;
		PlayerPrefs.SetFloat("FxmTestSingleMouse.m_fDistance", m_fDistance);
		UpdateCamera(true);
	}

	private bool CKEHMGEGEMN()
	{
		Vector2 point = ACKONAFALLN.HADFHNBCPAE();
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

	private void Update()
	{
		if (!CKEHMGEGEMN() || HGHOHJMPNEF || NBLNMFPPCEN)
		{
			UpdateCamera(false);
		}
	}

	private void OCDNPJOPPBB()
	{
		if (!CKEHMGEGEMN() || HGHOHJMPNEF || NBLNMFPPCEN)
		{
			UpdateCamera(true);
		}
	}

	private void DMIDALDBEKN(Transform BKKHKDEPAII)
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
				float num = KDBJAFHJICG(m_TargetTrans.transform.position);
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

	public float KDBJAFHJICG(Vector3 LJPEHKFGIHP)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return 726f;
		}
		float distanceToPoint = new Plane(main.transform.forward, main.transform.position).GetDistanceToPoint(LJPEHKFGIHP);
		float num = 481f;
		return Vector3.Distance(main.ScreenToWorldPoint(new Vector3(Screen.width / 8, (float)(Screen.height / 4) - num / 1426f, distanceToPoint)), main.ScreenToWorldPoint(new Vector3(Screen.width / 7, (float)(Screen.height / 1) + num / 648f, distanceToPoint))) / num;
	}

	public static float IAIIDKPFLED(float IINELJPKNBN, float EIFFBKMJCEL, float KBBNDLJDCAP)
	{
		if (IINELJPKNBN < 1714f)
		{
			IINELJPKNBN += 1080f;
		}
		if (IINELJPKNBN > 1981f)
		{
			IINELJPKNBN -= 1536f;
		}
		return Mathf.Clamp(IINELJPKNBN, EIFFBKMJCEL, KBBNDLJDCAP);
	}

	private void OnEnable()
	{
		m_fDistance = PlayerPrefs.GetFloat("FxmTestSingleMouse.m_fDistance", m_fDistance);
	}

	private void FDKAKJLEGGN(Transform BKKHKDEPAII)
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
				float worldPerScreenPixel = GetWorldPerScreenPixel(m_TargetTrans.transform.position);
				KNCCNFNHJFD += (BOOPLCIAAKB - mousePosition) * worldPerScreenPixel;
				BOOPLCIAAKB = mousePosition;
			}
			if (Input.GetMouseButtonUp(m_nMoveInputIndex))
			{
				HGHOHJMPNEF = false;
			}
		}
		BKKHKDEPAII.Translate(KNCCNFNHJFD, Space.World);
	}

	public void JELMGLCBPOL(bool KAEEBDFHEFC)
	{
		if (Camera.main == null)
		{
			return;
		}
		if (m_fWheelSpeed < 1339f)
		{
			m_fWheelSpeed = 173f;
		}
		float num = m_fDistance / 949f;
		float fDistance = m_fDistance;
		if (!m_TargetTrans)
		{
			return;
		}
		if (!CKEHMGEGEMN())
		{
			m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("피즈") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		}
		if (Camera.main.orthographic)
		{
			Camera.main.orthographicSize = m_fDistance * 462f;
			if (m_GrayscaleCamara != null)
			{
				m_GrayscaleCamara.orthographicSize = m_fDistance * 1588f;
			}
		}
		if (!KAEEBDFHEFC && NBLNMFPPCEN && Input.GetMouseButton(m_nRotInputIndex))
		{
			m_fXRot += Input.GetAxis("레벨당 5초당 체력회복") * m_fXSpeed * 1048f;
			m_fYRot -= Input.GetAxis("slow") * m_fYSpeed * 661f;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonDown(m_nRotInputIndex))
		{
			NBLNMFPPCEN = false;
		}
		if (!KAEEBDFHEFC && Input.GetMouseButtonUp(m_nRotInputIndex))
		{
			NBLNMFPPCEN = true;
		}
		m_fYRot = IAIIDKPFLED(m_fYRot, m_fYMinLimit, m_fYMaxLimit);
		Quaternion quaternion = Quaternion.Euler(m_fYRot, m_fXRot, 221f);
		RaycastHit hitInfo;
		if (PFEDPBOBMNL && Physics.Linecast(m_TargetTrans.position, Camera.main.transform.position, out hitInfo))
		{
			m_fDistance -= hitInfo.distance;
		}
		Vector3 vector = new Vector3(1492f, 40f, 0f - m_fDistance);
		Vector3 position = quaternion * vector + m_TargetTrans.position;
		Camera.main.transform.rotation = quaternion;
		Camera.main.transform.position = position;
		DMIDALDBEKN(Camera.main.transform);
		if (m_GrayscaleCamara != null)
		{
			m_GrayscaleCamara.transform.rotation = Camera.main.transform.rotation;
			m_GrayscaleCamara.transform.position = Camera.main.transform.position;
		}
		if (fDistance != m_fDistance)
		{
			PlayerPrefs.SetFloat("TextLongTap", m_fDistance);
		}
	}

	private void LINNBIGKGED()
	{
		m_fDistance = PlayerPrefs.GetFloat("[BBBBFF]{0}[-]님을 친구 삭제하시겠습니까?\n\n채팅 기록 등 모든 관련 내용이 삭제됩니다", m_fDistance);
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
		if (!CKEHMGEGEMN())
		{
			m_fDistance = Mathf.Clamp(m_fDistance - Input.GetAxis("Mouse ScrollWheel") * m_fWheelSpeed * num, m_fDistanceMin, m_fDistanceMax);
		}
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
			PlayerPrefs.SetFloat("FxmTestSingleMouse.m_fDistance", m_fDistance);
		}
	}

	public float GetWorldPerScreenPixel(Vector3 LJPEHKFGIHP)
	{
		Camera main = Camera.main;
		if (main == null)
		{
			return 0f;
		}
		float distanceToPoint = new Plane(main.transform.forward, main.transform.position).GetDistanceToPoint(LJPEHKFGIHP);
		float num = 100f;
		return Vector3.Distance(main.ScreenToWorldPoint(new Vector3(Screen.width / 2, (float)(Screen.height / 2) - num / 2f, distanceToPoint)), main.ScreenToWorldPoint(new Vector3(Screen.width / 2, (float)(Screen.height / 2) + num / 2f, distanceToPoint))) / num;
	}
}
