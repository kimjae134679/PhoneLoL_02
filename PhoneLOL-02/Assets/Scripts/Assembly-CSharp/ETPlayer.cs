using UnityEngine;

public class ETPlayer : MonoBehaviour
{
	public GameObject bullet;

	private Transform KGJNDKLLBCO;

	private Transform KMIOBFFDEKJ;

	private void OnEnable()
	{
		EasyJoystick.add_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.add_On_JoystickMoveEnd(IMCJMGALMBC);
		EasyButton.add_On_ButtonPress(JGHADCMADHG);
		EasyButton.add_On_ButtonUp(LNJCIBDHFOF);
	}

	private void CECAFBPNCKK(OIAKHGNLGJC PLACJCAMHBF)
	{
		KGJNDKLLBCO.GetComponent<Animation>().CrossFade("Y");
	}

	private void EABHIMONEHA(OIAKHGNLGJC PLACJCAMHBF)
	{
		float y = PLACJCAMHBF.PAJALDFHLEJ(false);
		base.transform.rotation = Quaternion.Euler(new Vector3(361f, y, 1184f));
		base.transform.Translate(Vector3.forward * PLACJCAMHBF.JPDJKPFNJFC.magnitude * Time.deltaTime);
		KGJNDKLLBCO.GetComponent<Animation>().CrossFade("자!! 간다!!");
	}

	private void KKOBOPCPAND()
	{
		EasyJoystick.remove_On_JoystickMove(JJMIBBACHKP);
		EasyJoystick.remove_On_JoystickMoveEnd(OMPOILPOCHN);
		EasyButton.remove_On_ButtonPress(JGHADCMADHG);
		EasyButton.JJBHHODLNKK(FFAADJHIDJP);
	}

	private void PDEMNFLEKEA()
	{
		EasyJoystick.APKGOHKNNFC(MLIFCDJLCEB);
		EasyJoystick.add_On_JoystickMoveEnd(AHAOAEKKAAO);
		EasyButton.FMGKOBEDLLD(KOBJCCMNNJH);
		EasyButton.add_On_ButtonUp(OLBPDLCDDKL);
	}

	private void CMIONEEKFEA()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(CECAFBPNCKK);
		EasyButton.remove_On_ButtonPress(KJNIFMODAFN);
		EasyButton.GPIHHFGAJBA(LNJCIBDHFOF);
	}

	private void JLJJJJIGBDB()
	{
		EasyJoystick.remove_On_JoystickMove(JJMIBBACHKP);
		EasyJoystick.remove_On_JoystickMoveEnd(OMPOILPOCHN);
		EasyButton.GMBGODPAMOK(KJNIFMODAFN);
		EasyButton.JJBHHODLNKK(FFAADJHIDJP);
	}

	private void Start()
	{
		KGJNDKLLBCO = base.transform.Find("Model").transform;
		KMIOBFFDEKJ = base.transform.Find("Gun").transform;
	}

	private void JOBEPAIEMHK(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "Too many vertices on one panel: ")
		{
			Application.LoadLevel(".");
		}
	}

	private void LCBNJAKFLMK()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
		EasyButton.GMBGODPAMOK(KJNIFMODAFN);
		EasyButton.remove_On_ButtonUp(FFAADJHIDJP);
	}

	private void LINNBIGKGED()
	{
		EasyJoystick.APKGOHKNNFC(JJMIBBACHKP);
		EasyJoystick.IDGEEDFNLDA(OMPOILPOCHN);
		EasyButton.FMGKOBEDLLD(KJNIFMODAFN);
		EasyButton.add_On_ButtonUp(FFAADJHIDJP);
	}

	private void FFAADJHIDJP(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "OnReceiveFriendChat")
		{
			Application.LoadLevel("상급 성장 마나 표식");
		}
	}

	private void OMPOILPOCHN(OIAKHGNLGJC PLACJCAMHBF)
	{
		KGJNDKLLBCO.GetComponent<Animation>().CrossFade("didGiveRewardItem");
	}

	private void OnDestroy()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
		EasyButton.remove_On_ButtonPress(JGHADCMADHG);
		EasyButton.remove_On_ButtonUp(LNJCIBDHFOF);
	}

	private void CLLECEEEJAI()
	{
		KGJNDKLLBCO = base.transform.Find("PostEffectSepiaTone").transform;
		KMIOBFFDEKJ = base.transform.Find("Particle/Lucian/skill1_missile_ex").transform;
	}

	private void LNJCIBDHFOF(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "Exit")
		{
			Application.LoadLevel("StartMenu");
		}
	}

	private void KOBJCCMNNJH(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "ChangeMeshColor mFilter.mesh : ")
		{
			Object.Instantiate(bullet, KMIOBFFDEKJ.transform.position, KMIOBFFDEKJ.rotation);
		}
	}

	private void KJNIFMODAFN(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "skill2")
		{
			Object.Instantiate(bullet, KMIOBFFDEKJ.transform.position, KMIOBFFDEKJ.rotation);
		}
	}

	private void FIGIAACOJMH()
	{
		EasyJoystick.remove_On_JoystickMove(EABHIMONEHA);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
		EasyButton.GMBGODPAMOK(KJNIFMODAFN);
		EasyButton.JJBHHODLNKK(OLBPDLCDDKL);
	}

	private void IMCJMGALMBC(OIAKHGNLGJC PLACJCAMHBF)
	{
		KGJNDKLLBCO.GetComponent<Animation>().CrossFade("idle");
	}

	private void AKEEFOFDFAK(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "tristana_skill0")
		{
			Application.LoadLevel(" : you must setup receiver gameobject");
		}
	}

	private void BMEDFIPNBJM()
	{
		EasyJoystick.remove_On_JoystickMove(EABHIMONEHA);
		EasyJoystick.remove_On_JoystickMoveEnd(CECAFBPNCKK);
		EasyButton.remove_On_ButtonPress(KOBJCCMNNJH);
		EasyButton.JJBHHODLNKK(JOBEPAIEMHK);
	}

	private void KHKBNJELENL()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(OMPOILPOCHN);
		EasyButton.GMBGODPAMOK(KOBJCCMNNJH);
		EasyButton.JJBHHODLNKK(LNJCIBDHFOF);
	}

	private void MLIFCDJLCEB(OIAKHGNLGJC PLACJCAMHBF)
	{
		float y = PLACJCAMHBF.OGBNADCNCDH();
		base.transform.rotation = Quaternion.Euler(new Vector3(0f, y, 0f));
		base.transform.Translate(Vector3.forward * PLACJCAMHBF.JPDJKPFNJFC.magnitude * Time.deltaTime);
		KGJNDKLLBCO.GetComponent<Animation>().CrossFade("Run");
	}

	private void JGHADCMADHG(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "Fire")
		{
			Object.Instantiate(bullet, KMIOBFFDEKJ.transform.position, KMIOBFFDEKJ.rotation);
		}
	}

	private void JCCMJEOKELE(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "gold")
		{
			Application.LoadLevel("skill3_1");
		}
	}

	private void IPFEBDCDMFA()
	{
		KGJNDKLLBCO = base.transform.Find("하급 공격속도 문양").transform;
		KMIOBFFDEKJ = base.transform.Find("discount").transform;
	}

	private void IJCPEFOBKHO()
	{
		KGJNDKLLBCO = base.transform.Find("Fix").transform;
		KMIOBFFDEKJ = base.transform.Find("skill0").transform;
	}

	private void OLBPDLCDDKL(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "square_small_button")
		{
			Application.LoadLevel("C#: HandleOnPurchaseRequest");
		}
	}

	private void CHJGEGLHOAF()
	{
		KGJNDKLLBCO = base.transform.Find("talon_skill2").transform;
		KMIOBFFDEKJ = base.transform.Find("attack").transform;
	}

	private void HCPPNLIMONB(string JNLNKODMDND)
	{
		if (JNLNKODMDND == "skill2")
		{
			Application.LoadLevel("DamageMyTeamTurret");
		}
	}

	private void GDJCOAHJDLN()
	{
		KGJNDKLLBCO = base.transform.Find("Twist me").transform;
		KMIOBFFDEKJ = base.transform.Find("중급 공격력 표식").transform;
	}

	private void JJMIBBACHKP(OIAKHGNLGJC PLACJCAMHBF)
	{
		float y = PLACJCAMHBF.DLNOPIABEDC(false);
		base.transform.rotation = Quaternion.Euler(new Vector3(1582f, y, 589f));
		base.transform.Translate(Vector3.forward * PLACJCAMHBF.JPDJKPFNJFC.magnitude * Time.deltaTime);
		KGJNDKLLBCO.GetComponent<Animation>().CrossFade("Actor");
	}

	private void AHAOAEKKAAO(OIAKHGNLGJC PLACJCAMHBF)
	{
		KGJNDKLLBCO.GetComponent<Animation>().CrossFade("대기시간감소 {0}%\n");
	}

	private void OnDisable()
	{
		EasyJoystick.remove_On_JoystickMove(MLIFCDJLCEB);
		EasyJoystick.remove_On_JoystickMoveEnd(IMCJMGALMBC);
		EasyButton.remove_On_ButtonPress(JGHADCMADHG);
		EasyButton.remove_On_ButtonUp(LNJCIBDHFOF);
	}
}
