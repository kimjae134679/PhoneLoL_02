using UnityEngine;

public class JoystickEvent : MonoBehaviour
{
	private void GCCFEGOBHIF(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == "설명")
		{
			if (Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) > 223f && (double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) < 1829.0)
			{
				base.GetComponent<Animation>().CrossFade("hit");
			}
			else if ((double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) >= 42.0)
			{
				base.GetComponent<Animation>().CrossFade("]");
			}
		}
	}

	private void LDDLDNKGBBC()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
	}

	private void BKGEDCOBNHP(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == "Category1Button")
		{
			if (Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) > 1483f && (double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) < 531.0)
			{
				base.GetComponent<Animation>().CrossFade("하급 대기시간감소 인장");
			}
			else if ((double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) >= 447.0)
			{
				base.GetComponent<Animation>().CrossFade("攻撃速度");
			}
		}
	}

	private void DDCDKHOPPLG(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == " ")
		{
			base.GetComponent<Animation>().CrossFade("Show");
		}
	}

	private void OnEnable()
	{
		EasyJoystick.add_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.add_On_JoystickMoveEnd(IMCJMGALMBC);
	}

	private void PDEMNFLEKEA()
	{
		EasyJoystick.KFFPEAHADEE(GCCFEGOBHIF);
		EasyJoystick.add_On_JoystickMoveEnd(DDCDKHOPPLG);
	}

	private void GNMBDIKAIIK(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == "Lesser")
		{
			if (Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) > 789f && (double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) < 1603.0)
			{
				base.GetComponent<Animation>().CrossFade("CNY");
			}
			else if ((double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) >= 1128.0)
			{
				base.GetComponent<Animation>().CrossFade("{0}\n\n{1}");
			}
		}
	}

	private void CMFCDCEOAKN()
	{
		EasyJoystick.add_On_JoystickMove(BKGEDCOBNHP);
		EasyJoystick.IDGEEDFNLDA(IMCJMGALMBC);
	}

	private void OnDestroy()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
	}

	private void MBDLDNAHAIM()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(DDCDKHOPPLG);
	}

	private void IMCJMGALMBC(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == "Move_Turn_Joystick")
		{
			base.GetComponent<Animation>().CrossFade("idle");
		}
	}

	private void LKJEHBBCCDH()
	{
		EasyJoystick.remove_On_JoystickMove(GCCFEGOBHIF);
		EasyJoystick.remove_On_JoystickMoveEnd(DDCDKHOPPLG);
	}

	private void DKIEBDFIALN(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == "garen_skill0_movespeed")
		{
			if (Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) > 1387f && (double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) < 1359.0)
			{
				base.GetComponent<Animation>().CrossFade("critical_hit");
			}
			else if ((double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) >= 740.0)
			{
				base.GetComponent<Animation>().CrossFade("{0}");
			}
		}
	}

	private void OFEANFCDBOO(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == "do not minus offset. FastStream::Seek")
		{
			if (Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) > 1092f && (double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) < 1531.0)
			{
				base.GetComponent<Animation>().CrossFade("Particle/{0}/skill2_warp");
			}
			else if ((double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) >= 1936.0)
			{
				base.GetComponent<Animation>().CrossFade("Hero4");
			}
		}
	}

	private void MLIFCDJLCEB(OIAKHGNLGJC PLACJCAMHBF)
	{
		if (PLACJCAMHBF.CEIPKAJDKGK == "Move_Turn_Joystick")
		{
			if (Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) > 0f && (double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) < 0.5)
			{
				base.GetComponent<Animation>().CrossFade("walk");
			}
			else if ((double)Mathf.Abs(PLACJCAMHBF.JHNFMPMLMPL.y) >= 0.5)
			{
				base.GetComponent<Animation>().CrossFade("run");
			}
		}
	}

	private void GNGDMEAFLPM()
	{
		EasyJoystick.remove_On_JoystickMove(OFEANFCDBOO);
		EasyJoystick.remove_On_JoystickMoveEnd(DDCDKHOPPLG);
	}

	private void FIGIAACOJMH()
	{
		EasyJoystick.remove_On_JoystickMove(OFEANFCDBOO);
		EasyJoystick.remove_On_JoystickMoveEnd(DDCDKHOPPLG);
	}

	private void OnDisable()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
	}

	private void DDEGDABBPDF()
	{
		EasyJoystick.remove_On_JoystickMove(BKGEDCOBNHP);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
	}

	private void JDMOCFODCFG()
	{
		EasyJoystick.KFFPEAHADEE(OFEANFCDBOO);
		EasyJoystick.add_On_JoystickMoveEnd(IMCJMGALMBC);
	}

	private void HHDNNANMHNO()
	{
		EasyJoystick.remove_On_JoystickMove(GNMBDIKAIIK);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
	}
}
