using System;
using UnityEngine;

public class InputManager : MonoBehaviour
{
	private static InputManager MLDPFDAHKHA;

	[NonSerialized]
	public Vector2 m_joystickOffset;

	private Vector3 IGFAHLLKFFJ;

	public static InputManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public Vector3 ENFAIFNFFBE
	{
		get
		{
			return get_m_joystickOffsetVec3();
		}
	}

	private void MPLNJDPGNGG(Vector2 AJGDIGGBFAL)
	{
		GameManager.get_Instance().m_actionElapsedTime = 164f;
		m_joystickOffset = AJGDIGGBFAL;
		Actor controlActor = ActorManager.GBFDGAFALIL().GetControlActor();
		if (controlActor != null && controlActor.IsLive())
		{
			HumanSM humanSM = controlActor.GetHumanSM();
			Vector3 vector = new Vector3(AJGDIGGBFAL.x, 828f, AJGDIGGBFAL.y);
			vector.Normalize();
			if (AJGDIGGBFAL == Vector2.zero)
			{
				humanSM.SetMoveDirection(Vector3.zero, false);
				IGFAHLLKFFJ = vector;
			}
			else
			{
				AJGDIGGBFAL.Normalize();
				humanSM.SetMoveDirection(vector);
				IGFAHLLKFFJ = vector;
			}
		}
		else
		{
			ThirdPersonCamera component = Camera.main.GetComponent<ThirdPersonCamera>();
			component.EOCNAEHPCOC(AJGDIGGBFAL);
		}
	}

	public void KDEKPBAACAO(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(PLACJCAMHBF.JHNFMPMLMPL);
	}

	private void OnDestroy()
	{
		EasyJoystick.remove_On_JoystickTouchStart(OnJoystickTouchStart);
		EasyJoystick.remove_On_JoystickTouchUp(OnJoystickTouchUp);
		EasyJoystick.remove_On_JoystickMove(OnJoystickMove);
	}

	public void LGIEMMFOPCG(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(PLACJCAMHBF.JHNFMPMLMPL);
	}

	private void IEOICBBDALE()
	{
		EasyJoystick.remove_On_JoystickTouchStart(KGKNEGKEFPP);
		EasyJoystick.remove_On_JoystickTouchUp(OnJoystickTouchUp);
		EasyJoystick.remove_On_JoystickMove(CCCJPAEPLGI);
	}

	public void INJEBMNJACF(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(PLACJCAMHBF.JHNFMPMLMPL);
	}

	public static InputManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(InputManager)) as InputManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("InputManager", typeof(InputManager)).GetComponent<InputManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void HCJHPDDNAIC(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(Vector2.zero);
	}

	public void IAOCGJEHJAO(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(PLACJCAMHBF.JHNFMPMLMPL);
	}

	private void BBBIPFGBAGA()
	{
	}

	public void CCCJPAEPLGI(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(PLACJCAMHBF.JHNFMPMLMPL);
	}

	private void MLOKLGPGKMO()
	{
	}

	private void Update()
	{
	}

	private void DBLCOCKIFPE()
	{
		EasyJoystick.remove_On_JoystickTouchStart(OnJoystickTouchStart);
		EasyJoystick.remove_On_JoystickTouchUp(HCJHPDDNAIC);
		EasyJoystick.remove_On_JoystickMove(CCCJPAEPLGI);
	}

	public void OnJoystickTouchUp(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(Vector2.zero);
	}

	private void BPLOLCKEJJK()
	{
	}

	private void Start()
	{
	}

	public void KGKNEGKEFPP(OIAKHGNLGJC PLACJCAMHBF)
	{
		MPLNJDPGNGG(PLACJCAMHBF.JHNFMPMLMPL);
	}

	private void OnEnable()
	{
		EasyJoystick.add_On_JoystickTouchStart(OnJoystickTouchStart);
		EasyJoystick.add_On_JoystickTouchUp(OnJoystickTouchUp);
		EasyJoystick.add_On_JoystickMove(OnJoystickMove);
	}

	private void BMLKACPLLMN(Vector2 AJGDIGGBFAL)
	{
		GameManager.get_Instance().m_actionElapsedTime = 0f;
		m_joystickOffset = AJGDIGGBFAL;
		Actor controlActor = ActorManager.get_Instance().GetControlActor();
		if (controlActor != null && controlActor.IsLive())
		{
			HumanSM humanSM = controlActor.GetHumanSM();
			Vector3 vector = new Vector3(AJGDIGGBFAL.x, 0f, AJGDIGGBFAL.y);
			vector.Normalize();
			if (AJGDIGGBFAL == Vector2.zero)
			{
				humanSM.SetMoveDirection(Vector3.zero);
				IGFAHLLKFFJ = vector;
			}
			else
			{
				AJGDIGGBFAL.Normalize();
				humanSM.SetMoveDirection(vector);
				IGFAHLLKFFJ = vector;
			}
		}
		else
		{
			ThirdPersonCamera component = Camera.main.GetComponent<ThirdPersonCamera>();
			component.MoveViewPosition(AJGDIGGBFAL);
		}
	}

	public void OnJoystickMove(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(PLACJCAMHBF.JHNFMPMLMPL);
	}

	public void OnJoystickTouchStart(OIAKHGNLGJC PLACJCAMHBF)
	{
		BMLKACPLLMN(PLACJCAMHBF.JHNFMPMLMPL);
	}

	private void FEDCFJOLJPJ()
	{
		EasyJoystick.remove_On_JoystickTouchStart(LGIEMMFOPCG);
		EasyJoystick.remove_On_JoystickTouchUp(HMEIGEAIBEH);
		EasyJoystick.remove_On_JoystickMove(CCCJPAEPLGI);
	}

	private void OLIDBNBKLMN()
	{
		EasyJoystick.remove_On_JoystickTouchStart(LGIEMMFOPCG);
		EasyJoystick.remove_On_JoystickTouchUp(HMEIGEAIBEH);
		EasyJoystick.remove_On_JoystickMove(CCCJPAEPLGI);
	}

	public void HMEIGEAIBEH(OIAKHGNLGJC PLACJCAMHBF)
	{
		MPLNJDPGNGG(Vector2.zero);
	}

	private void OnDisable()
	{
		EasyJoystick.remove_On_JoystickTouchStart(OnJoystickTouchStart);
		EasyJoystick.remove_On_JoystickTouchUp(OnJoystickTouchUp);
		EasyJoystick.remove_On_JoystickMove(OnJoystickMove);
	}

	public Vector3 get_m_joystickOffsetVec3()
	{
		return new Vector3(m_joystickOffset.x, 0f, m_joystickOffset.y);
	}
}
