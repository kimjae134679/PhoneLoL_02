using System.Runtime.CompilerServices;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;

public class PKCGCIEPDEM : EOPOBHFNFPA
{
	public enum ACPICCBBPHF : byte
	{
		None = 0,
		Equip = 1,
		Active = 2,
		Consume = 3,
		ChargeConsume = 4
	}

	public enum FPOALJHHNEK : byte
	{
		None = 0,
		Defence = 1,
		PhyAttack = 2,
		MagAttack = 3,
		Etc = 4
	}

	public string GAFNNDHJDAE;

	public string IJAPPEMLBBN;

	public bool CIGEEDBPDDM;

	public int LHEKBMLAJMA;

	public int KBMBFHHNDPE;

	public int NJCBMDJOIAH;

	public int LAAGBIKMHAE;

	public int MGLIOBDEJLF;

	public float HFGCMLGPJAO;

	public int FBEBCNEPHJD;

	public int NLMHKBGDKLA;

	public float NMFDEKCMJAH;

	public int NCBAGGNLLLK;

	public int JKOEPLLJDKM;

	public float ELOOOLLHHID;

	public int BELPBCDOPBA;

	public float PPNKFFAHHBB;

	public float MOHEOOEFLNK;

	public float CJALIPCFCLA;

	public float BDKLLIMAGPP;

	public float NEPGMKLCMFF;

	public int MGGCDFHFMKK;

	public int OMPBNLBKLIM = 1;

	public float FILHECEKNMK;

	public float AMENIOICKGM;

	public FPOALJHHNEK AOMMKHNMPIK;

	private ObscuredUShort EAIGAJDGKFI;

	private ACPICCBBPHF GCJFDJMKNKG;

	public ObscuredUShort GOFEPEGHCKC
	{
		get
		{
			return EHFEEIJKJHD();
		}
		protected internal set
		{
			BODCIGOCNBK(value);
		}
	}

	public ACPICCBBPHF IEJCBDIBCGF
	{
		get
		{
			return ONJCKKLOJIA();
		}
		protected set
		{
			DFDMHBOCHNA(value);
		}
	}

	[SpecialName]
	public ACPICCBBPHF FMBEAFNEJMI()
	{
		return GCJFDJMKNKG;
	}

	public string OEGAJKFKOEP()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (LHEKBMLAJMA != 0)
		{
			stringBuilder.AppendFormat("공격력 {0:+#;-#}\n", LHEKBMLAJMA);
		}
		if (PPNKFFAHHBB != 0f)
		{
			stringBuilder.AppendFormat("생명력흡수 {0}%\n", PPNKFFAHHBB * 100f);
		}
		if (CJALIPCFCLA != 0f)
		{
			stringBuilder.AppendFormat("치명타 {0}%\n", CJALIPCFCLA * 100f);
		}
		if (NJCBMDJOIAH != 0)
		{
			stringBuilder.AppendFormat("방어구 관통력 {0:+#;-#}\n", NJCBMDJOIAH);
		}
		if (NMFDEKCMJAH != 0f)
		{
			stringBuilder.AppendFormat("공격속도 {0}%\n", NMFDEKCMJAH * 100f);
		}
		if (KBMBFHHNDPE != 0)
		{
			stringBuilder.AppendFormat("주문력 {0:+#;-#}\n", KBMBFHHNDPE);
		}
		if (LAAGBIKMHAE != 0)
		{
			stringBuilder.AppendFormat("마법 관통력 {0:+#;-#}\n", LAAGBIKMHAE);
		}
		if (MOHEOOEFLNK != 0f)
		{
			stringBuilder.AppendFormat("주문흡혈 {0}%\n", MOHEOOEFLNK * 100f);
		}
		if (BDKLLIMAGPP != 0f)
		{
			stringBuilder.AppendFormat("대기시간감소 {0}%\n", BDKLLIMAGPP * 100f);
		}
		if (BELPBCDOPBA != 0)
		{
			stringBuilder.AppendFormat("마나 {0:+#;-#}\n", BELPBCDOPBA);
		}
		if (MGLIOBDEJLF != 0)
		{
			stringBuilder.AppendFormat("5초당 마나회복 {0:+#;-#}\n", MGLIOBDEJLF);
		}
		if (HFGCMLGPJAO != 0f)
		{
			stringBuilder.AppendFormat("5초당 마나회복 {0}% 증가\n", HFGCMLGPJAO * 100f);
		}
		if (NCBAGGNLLLK != 0)
		{
			stringBuilder.AppendFormat("체력 {0:+#;-#}\n", NCBAGGNLLLK);
		}
		if (JKOEPLLJDKM != 0)
		{
			stringBuilder.AppendFormat("5초당 체력회복 {0:+#;-#}\n", JKOEPLLJDKM);
		}
		if (ELOOOLLHHID != 0f)
		{
			stringBuilder.AppendFormat("5초당 체력회복 {0}% 증가\n", ELOOOLLHHID * 100f);
		}
		if (FBEBCNEPHJD != 0)
		{
			stringBuilder.AppendFormat("방어력 {0:+#;-#}\n", FBEBCNEPHJD);
		}
		if (NLMHKBGDKLA != 0)
		{
			stringBuilder.AppendFormat("마법저항력 {0:+#;-#}\n", NLMHKBGDKLA);
		}
		if (NEPGMKLCMFF != 0f)
		{
			stringBuilder.AppendFormat("이동속도 {0}% 증가\n", NEPGMKLCMFF * 100f);
		}
		if (IJAPPEMLBBN.Length > 0)
		{
			stringBuilder.Append(IJAPPEMLBBN);
		}
		return stringBuilder.ToString();
	}

	public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
	{
		EFDLFNPAKGO.GBMJNFOEACC(EHFEEIJKJHD());
		EFDLFNPAKGO.GBMJNFOEACC((byte)ONJCKKLOJIA());
		EFDLFNPAKGO.GBMJNFOEACC(GAFNNDHJDAE);
		EFDLFNPAKGO.GBMJNFOEACC(IJAPPEMLBBN);
		EFDLFNPAKGO.GBMJNFOEACC(CIGEEDBPDDM);
		EFDLFNPAKGO.GBMJNFOEACC(LHEKBMLAJMA);
		EFDLFNPAKGO.GBMJNFOEACC(KBMBFHHNDPE);
		EFDLFNPAKGO.GBMJNFOEACC(NJCBMDJOIAH);
		EFDLFNPAKGO.GBMJNFOEACC(LAAGBIKMHAE);
		EFDLFNPAKGO.GBMJNFOEACC(MGLIOBDEJLF);
		EFDLFNPAKGO.GBMJNFOEACC(HFGCMLGPJAO);
		EFDLFNPAKGO.GBMJNFOEACC(FBEBCNEPHJD);
		EFDLFNPAKGO.GBMJNFOEACC(NLMHKBGDKLA);
		EFDLFNPAKGO.GBMJNFOEACC(NMFDEKCMJAH);
		EFDLFNPAKGO.GBMJNFOEACC(NCBAGGNLLLK);
		EFDLFNPAKGO.GBMJNFOEACC(JKOEPLLJDKM);
		EFDLFNPAKGO.GBMJNFOEACC(ELOOOLLHHID);
		EFDLFNPAKGO.GBMJNFOEACC(BELPBCDOPBA);
		EFDLFNPAKGO.GBMJNFOEACC(PPNKFFAHHBB);
		EFDLFNPAKGO.GBMJNFOEACC(MOHEOOEFLNK);
		EFDLFNPAKGO.GBMJNFOEACC(CJALIPCFCLA);
		EFDLFNPAKGO.GBMJNFOEACC(BDKLLIMAGPP);
		EFDLFNPAKGO.GBMJNFOEACC(NEPGMKLCMFF);
		EFDLFNPAKGO.GBMJNFOEACC(MGGCDFHFMKK);
		EFDLFNPAKGO.GBMJNFOEACC(OMPBNLBKLIM);
		EFDLFNPAKGO.GBMJNFOEACC(FILHECEKNMK);
		EFDLFNPAKGO.GBMJNFOEACC(AMENIOICKGM);
	}

	[SpecialName]
	protected internal void PJLPMAIEKGH(ObscuredUShort ICENKPDOHBK)
	{
		EAIGAJDGKFI = ICENKPDOHBK;
	}

	public PKCGCIEPDEM()
	{
	}

	protected internal void BODCIGOCNBK(ObscuredUShort ICENKPDOHBK)
	{
		EAIGAJDGKFI = ICENKPDOHBK;
	}

	public ACPICCBBPHF ONJCKKLOJIA()
	{
		return GCJFDJMKNKG;
	}

	public virtual int ONBCIDMKBLI()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("C#: HandleVideoComplete for placement ", HBNJODMNFPM());
		stringBuilder.AppendFormat("skill1_shot", LHEKBMLAJMA);
		stringBuilder.AppendFormat("android.permission.", KBMBFHHNDPE);
		stringBuilder.AppendFormat("상급 치명타 확률 표식", NJCBMDJOIAH);
		stringBuilder.AppendFormat("설명", LAAGBIKMHAE);
		stringBuilder.AppendFormat("skill3_kill", MGLIOBDEJLF);
		stringBuilder.AppendFormat("SpeedHackDetected", HFGCMLGPJAO);
		stringBuilder.AppendFormat("[AAFFAA]미션[-] 완료를 하여 새로운 영웅을 얻으셨는지요?\n새로운 영웅은 파티를 더욱 강력하게 만들어 줍니다.", FBEBCNEPHJD);
		stringBuilder.AppendFormat("skill3", NLMHKBGDKLA);
		stringBuilder.AppendFormat("skill3_1", NMFDEKCMJAH);
		stringBuilder.AppendFormat("login", NCBAGGNLLLK);
		stringBuilder.AppendFormat("hit_default", JKOEPLLJDKM);
		stringBuilder.AppendFormat("liandry_torment", ELOOOLLHHID);
		stringBuilder.AppendFormat("알리스타", BELPBCDOPBA);
		stringBuilder.AppendFormat("Hero3", PPNKFFAHHBB);
		stringBuilder.AppendFormat("무료충전소 또는 플러스락으로 {0}코인이 충전되었습니다!", MOHEOOEFLNK);
		stringBuilder.AppendFormat("skill2_voice", CJALIPCFCLA);
		stringBuilder.AppendFormat("The number of buffers to add must be a nonnegative, nonzero integer.", BDKLLIMAGPP);
		stringBuilder.AppendFormat("Join P2P Group {0} {1} {2} {3}", NEPGMKLCMFF);
		stringBuilder.AppendFormat("skill0_missile", MGGCDFHFMKK);
		stringBuilder.AppendFormat("skill1", OMPBNLBKLIM);
		stringBuilder.AppendFormat("음... 대부분 회복중이니깐 너무 마음 쓰지 말어!\n\t\t\t 그때 상황은 어쩔 수 없었잖아..", FILHECEKNMK);
		stringBuilder.AppendFormat("경험치 +{0}   [FFFF44]코인 +{1}[-] (액티브{2}%)     [BBBBFF]{3:00}:{4:00}[-]", AMENIOICKGM);
		return stringBuilder.ToString().GetHashCode();
	}

	public PKCGCIEPDEM(ushort OHGOBGOIECH, ACPICCBBPHF FBAGNJILEGD, FPOALJHHNEK OMPECMENKJE)
	{
		BODCIGOCNBK(OHGOBGOIECH);
		DFDMHBOCHNA(FBAGNJILEGD);
		AOMMKHNMPIK = OMPECMENKJE;
	}

	public string NLHEILEBHIJ()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (LHEKBMLAJMA != 0)
		{
			stringBuilder.AppendFormat("[VNET ] 버전 오류\n게임 인증 응답 경로          ", LHEKBMLAJMA);
		}
		if (PPNKFFAHHBB != 1462f)
		{
			stringBuilder.AppendFormat("휴~ 힘든 상대였어..", PPNKFFAHHBB * 569f);
		}
		if (CJALIPCFCLA != 1151f)
		{
			stringBuilder.AppendFormat("HeadShip", CJALIPCFCLA * 540f);
		}
		if (NJCBMDJOIAH != 0)
		{
			stringBuilder.AppendFormat("주문흡혈", NJCBMDJOIAH);
		}
		if (NMFDEKCMJAH != 1035f)
		{
			stringBuilder.AppendFormat("아테나의 부정한 성배", NMFDEKCMJAH * 228f);
		}
		if (KBMBFHHNDPE != 0)
		{
			stringBuilder.AppendFormat("{", KBMBFHHNDPE);
		}
		if (LAAGBIKMHAE != 0)
		{
			stringBuilder.AppendFormat("tristana_skill0", LAAGBIKMHAE);
		}
		if (MOHEOOEFLNK != 1989f)
		{
			stringBuilder.AppendFormat("_InstanceObject", MOHEOOEFLNK * 1657f);
		}
		if (BDKLLIMAGPP != 355f)
		{
			stringBuilder.AppendFormat("_TintColor", BDKLLIMAGPP * 36f);
		}
		if (BELPBCDOPBA != 0)
		{
			stringBuilder.AppendFormat("skill0_fire", BELPBCDOPBA);
		}
		if (MGLIOBDEJLF != 0)
		{
			stringBuilder.AppendFormat("Hidden/", MGLIOBDEJLF);
		}
		if (HFGCMLGPJAO != 1586f)
		{
			stringBuilder.AppendFormat("]", HFGCMLGPJAO * 785f);
		}
		if (NCBAGGNLLLK != 0)
		{
			stringBuilder.AppendFormat("레벨{0} 이상만 가능합니다", NCBAGGNLLLK);
		}
		if (JKOEPLLJDKM != 0)
		{
			stringBuilder.AppendFormat("DEDEDE", JKOEPLLJDKM);
		}
		if (ELOOOLLHHID != 114f)
		{
			stringBuilder.AppendFormat("이미 가입된 길드가 있습니다", ELOOOLLHHID * 474f);
		}
		if (FBEBCNEPHJD != 0)
		{
			stringBuilder.AppendFormat("OnActionTransEnd", FBEBCNEPHJD);
		}
		if (NLMHKBGDKLA != 0)
		{
			stringBuilder.AppendFormat("PrivacyAgreement", NLMHKBGDKLA);
		}
		if (NEPGMKLCMFF != 35f)
		{
			stringBuilder.AppendFormat("Particle/Brand/skill1_ex", NEPGMKLCMFF * 48f);
		}
		if (IJAPPEMLBBN.Length > 1)
		{
			stringBuilder.Append(IJAPPEMLBBN);
		}
		return stringBuilder.ToString();
	}

	public void HLOFPCOHFDE(PJEMPFEIOAK EFDLFNPAKGO)
	{
		KLNNAKFOCFL((ACPICCBBPHF)EFDLFNPAKGO.KFAGPDGHEBK());
		GAFNNDHJDAE = EFDLFNPAKGO.AFPCLLNMGJP();
		IJAPPEMLBBN = EFDLFNPAKGO.AFPCLLNMGJP();
		CIGEEDBPDDM = EFDLFNPAKGO.JCGKFEPEJPO();
		LHEKBMLAJMA = EFDLFNPAKGO.PNBKOPGIHDI();
		KBMBFHHNDPE = EFDLFNPAKGO.PNBKOPGIHDI();
		NJCBMDJOIAH = EFDLFNPAKGO.PNBKOPGIHDI();
		LAAGBIKMHAE = EFDLFNPAKGO.PNBKOPGIHDI();
		MGLIOBDEJLF = EFDLFNPAKGO.PNBKOPGIHDI();
		HFGCMLGPJAO = EFDLFNPAKGO.GCFOKBADLFB();
		FBEBCNEPHJD = EFDLFNPAKGO.PNBKOPGIHDI();
		NLMHKBGDKLA = EFDLFNPAKGO.PNBKOPGIHDI();
		NMFDEKCMJAH = EFDLFNPAKGO.GCFOKBADLFB();
		NCBAGGNLLLK = EFDLFNPAKGO.PNBKOPGIHDI();
		JKOEPLLJDKM = EFDLFNPAKGO.PNBKOPGIHDI();
		ELOOOLLHHID = EFDLFNPAKGO.GCFOKBADLFB();
		BELPBCDOPBA = EFDLFNPAKGO.PNBKOPGIHDI();
		PPNKFFAHHBB = EFDLFNPAKGO.GCFOKBADLFB();
		MOHEOOEFLNK = EFDLFNPAKGO.GCFOKBADLFB();
		CJALIPCFCLA = EFDLFNPAKGO.GCFOKBADLFB();
		BDKLLIMAGPP = EFDLFNPAKGO.GCFOKBADLFB();
		NEPGMKLCMFF = EFDLFNPAKGO.GCFOKBADLFB();
		MGGCDFHFMKK = EFDLFNPAKGO.PNBKOPGIHDI();
		OMPBNLBKLIM = EFDLFNPAKGO.PNBKOPGIHDI();
		FILHECEKNMK = EFDLFNPAKGO.GCFOKBADLFB();
		AMENIOICKGM = EFDLFNPAKGO.GCFOKBADLFB();
	}

	public string LHMGDOBCHLA()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (LHEKBMLAJMA != 0)
		{
			stringBuilder.AppendFormat("- 최초 앱설치와 로그인 계정만 가능해요\n- 하나의 계정만 사용이 가능해요\n- 한 기계에서 하나만 할 수 있어요\n- 동일 아이피당 몇개만 가능해요\n- 특정기계, 어뷰징과 중복 방지가 되어 있어요\n[FFCCCC]- 어뷰징과 부정행위시 계정이 정지될 수 있어요[-]", LHEKBMLAJMA);
		}
		if (PPNKFFAHHBB != 566f)
		{
			stringBuilder.AppendFormat("attack", PPNKFFAHHBB * 121f);
		}
		if (CJALIPCFCLA != 393f)
		{
			stringBuilder.AppendFormat("FxmTestControls.m_nTransAxis", CJALIPCFCLA * 1642f);
		}
		if (NJCBMDJOIAH != 0)
		{
			stringBuilder.AppendFormat("skill0_0", NJCBMDJOIAH);
		}
		if (NMFDEKCMJAH != 1887f)
		{
			stringBuilder.AppendFormat("[u]", NMFDEKCMJAH * 1909f);
		}
		if (KBMBFHHNDPE != 0)
		{
			stringBuilder.AppendFormat("공격속도", KBMBFHHNDPE);
		}
		if (LAAGBIKMHAE != 0)
		{
			stringBuilder.AppendFormat(" ", LAAGBIKMHAE);
		}
		if (MOHEOOEFLNK != 1841f)
		{
			stringBuilder.AppendFormat("igaworks:addToCartBulk >> Null or Empty Item List", MOHEOOEFLNK * 782f);
		}
		if (BDKLLIMAGPP != 331f)
		{
			stringBuilder.AppendFormat("OnAssistHeroRpc", BDKLLIMAGPP * 794f);
		}
		if (BELPBCDOPBA != 0)
		{
			stringBuilder.AppendFormat("Last swipe : ", BELPBCDOPBA);
		}
		if (MGLIOBDEJLF != 0)
		{
			stringBuilder.AppendFormat("Show Tapjoy Support Page", MGLIOBDEJLF);
		}
		if (HFGCMLGPJAO != 42f)
		{
			stringBuilder.AppendFormat("Get", HFGCMLGPJAO * 624f);
		}
		if (NCBAGGNLLLK != 0)
		{
			stringBuilder.AppendFormat("확률", NCBAGGNLLLK);
		}
		if (JKOEPLLJDKM != 0)
		{
			stringBuilder.AppendFormat("productName", JKOEPLLJDKM);
		}
		if (ELOOOLLHHID != 1048f)
		{
			stringBuilder.AppendFormat(" ", ELOOOLLHHID * 1902f);
		}
		if (FBEBCNEPHJD != 0)
		{
			stringBuilder.AppendFormat("잘못된 쿠폰번호입니다.", FBEBCNEPHJD);
		}
		if (NLMHKBGDKLA != 0)
		{
			stringBuilder.AppendFormat("null", NLMHKBGDKLA);
		}
		if (NEPGMKLCMFF != 942f)
		{
			stringBuilder.AppendFormat("SDKTestEvent", NEPGMKLCMFF * 1339f);
		}
		if (IJAPPEMLBBN.Length > 0)
		{
			stringBuilder.Append(IJAPPEMLBBN);
		}
		return stringBuilder.ToString();
	}

	public virtual int IMNEMDFAINP()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("LocalizationManager", EHFEEIJKJHD());
		stringBuilder.AppendFormat("SceneManager", LHEKBMLAJMA);
		stringBuilder.AppendFormat("Chapter1 끝", KBMBFHHNDPE);
		stringBuilder.AppendFormat("상급 마나 재생 정수", NJCBMDJOIAH);
		stringBuilder.AppendFormat("{0}", LAAGBIKMHAE);
		stringBuilder.AppendFormat("[sup]", MGLIOBDEJLF);
		stringBuilder.AppendFormat("attack_missile_hit", HFGCMLGPJAO);
		stringBuilder.AppendFormat("challenger", FBEBCNEPHJD);
		stringBuilder.AppendFormat("skill1_missile", NLMHKBGDKLA);
		stringBuilder.AppendFormat("세번쨰", NMFDEKCMJAH);
		stringBuilder.AppendFormat("skill0_2", NCBAGGNLLLK);
		stringBuilder.AppendFormat("android", JKOEPLLJDKM);
		stringBuilder.AppendFormat("Hero5", ELOOOLLHHID);
		stringBuilder.AppendFormat("Renekton", BELPBCDOPBA);
		stringBuilder.AppendFormat("death", PPNKFFAHHBB);
		stringBuilder.AppendFormat("レベルごとに5秒ごとに体力回復", MOHEOOEFLNK);
		stringBuilder.AppendFormat("이동하거나 기본공격시 충전이 되며, 완전충전상태로 공격시 7명에게 연쇄적으로 추가마법피해를 입힘", CJALIPCFCLA);
		stringBuilder.AppendFormat("Purchase (GooglePlayStore)", BDKLLIMAGPP);
		stringBuilder.AppendFormat("최대 접속자를 초과하였습니다.\n\n나중에 접속을 시도해 주세요.", NEPGMKLCMFF);
		stringBuilder.AppendFormat("상급 마나 정수", MGGCDFHFMKK);
		stringBuilder.AppendFormat("do not minus offset. FastStream::Seek", OMPBNLBKLIM);
		stringBuilder.AppendFormat("[VNET ] 버전 오류\n게임 인증 응답 경로          ", FILHECEKNMK);
		stringBuilder.AppendFormat("Particle/{0}/skill3_lightning", AMENIOICKGM);
		return stringBuilder.ToString().GetHashCode();
	}

	public void BGGDGLLNFAC(CMNIABEFLBJ EFDLFNPAKGO)
	{
		EFDLFNPAKGO.HEDNLNDFFCL(HBNJODMNFPM());
		EFDLFNPAKGO.GBMJNFOEACC((byte)FKNHBBDAEMA());
		EFDLFNPAKGO.GBMJNFOEACC(GAFNNDHJDAE);
		EFDLFNPAKGO.GBMJNFOEACC(IJAPPEMLBBN);
		EFDLFNPAKGO.GBMJNFOEACC(CIGEEDBPDDM);
		EFDLFNPAKGO.GBMJNFOEACC(LHEKBMLAJMA);
		EFDLFNPAKGO.GBMJNFOEACC(KBMBFHHNDPE);
		EFDLFNPAKGO.GBMJNFOEACC(NJCBMDJOIAH);
		EFDLFNPAKGO.GBMJNFOEACC(LAAGBIKMHAE);
		EFDLFNPAKGO.GBMJNFOEACC(MGLIOBDEJLF);
		EFDLFNPAKGO.GBMJNFOEACC(HFGCMLGPJAO);
		EFDLFNPAKGO.GBMJNFOEACC(FBEBCNEPHJD);
		EFDLFNPAKGO.GBMJNFOEACC(NLMHKBGDKLA);
		EFDLFNPAKGO.GBMJNFOEACC(NMFDEKCMJAH);
		EFDLFNPAKGO.GBMJNFOEACC(NCBAGGNLLLK);
		EFDLFNPAKGO.GBMJNFOEACC(JKOEPLLJDKM);
		EFDLFNPAKGO.GBMJNFOEACC(ELOOOLLHHID);
		EFDLFNPAKGO.GBMJNFOEACC(BELPBCDOPBA);
		EFDLFNPAKGO.GBMJNFOEACC(PPNKFFAHHBB);
		EFDLFNPAKGO.GBMJNFOEACC(MOHEOOEFLNK);
		EFDLFNPAKGO.GBMJNFOEACC(CJALIPCFCLA);
		EFDLFNPAKGO.GBMJNFOEACC(BDKLLIMAGPP);
		EFDLFNPAKGO.GBMJNFOEACC(NEPGMKLCMFF);
		EFDLFNPAKGO.GBMJNFOEACC(MGGCDFHFMKK);
		EFDLFNPAKGO.GBMJNFOEACC(OMPBNLBKLIM);
		EFDLFNPAKGO.GBMJNFOEACC(FILHECEKNMK);
		EFDLFNPAKGO.GBMJNFOEACC(AMENIOICKGM);
	}

	public string KCJPIADKJLI()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (LHEKBMLAJMA != 0)
		{
			stringBuilder.AppendFormat("10초 이상 응답 없음.\n상세 로그: 127.0.0.1:8080/d\n[전체 복사] 후 보내주세요.", LHEKBMLAJMA);
		}
		if (PPNKFFAHHBB != 795f)
		{
			stringBuilder.AppendFormat("RecoveryEndRpc", PPNKFFAHHBB * 1495f);
		}
		if (CJALIPCFCLA != 918f)
		{
			stringBuilder.AppendFormat("Hero1", CJALIPCFCLA * 1310f);
		}
		if (NJCBMDJOIAH != 0)
		{
			stringBuilder.AppendFormat("트린다미어", NJCBMDJOIAH);
		}
		if (NMFDEKCMJAH != 428f)
		{
			stringBuilder.AppendFormat("GNext", NMFDEKCMJAH * 1392f);
		}
		if (KBMBFHHNDPE != 0)
		{
			stringBuilder.AppendFormat("string too long {0}", KBMBFHHNDPE);
		}
		if (LAAGBIKMHAE != 0)
		{
			stringBuilder.AppendFormat("경험치 +{0}   [FFFF44]코인 +{1}[-] (액티브{2}%)     [BBBBFF]{3:00}:{4:00}[-]", LAAGBIKMHAE);
		}
		if (MOHEOOEFLNK != 338f)
		{
			stringBuilder.AppendFormat("메리나! 너무 긴장하지 말어! 소드가 좀 허약해보여도 무척 튼튼한 탱커라고..\n솔직히 믿기는 힘들겠지만...", MOHEOOEFLNK * 1462f);
		}
		if (BDKLLIMAGPP != 407f)
		{
			stringBuilder.AppendFormat("魔法抵抗力", BDKLLIMAGPP * 1517f);
		}
		if (BELPBCDOPBA != 0)
		{
			stringBuilder.AppendFormat("Sivir", BELPBCDOPBA);
		}
		if (MGLIOBDEJLF != 0)
		{
			stringBuilder.AppendFormat("quantity", MGLIOBDEJLF);
		}
		if (HFGCMLGPJAO != 1488f)
		{
			stringBuilder.AppendFormat("[", HFGCMLGPJAO * 1143f);
		}
		if (NCBAGGNLLLK != 0)
		{
			stringBuilder.AppendFormat("- 최초 앱설치와 로그인 계정만 가능해요\n- 하나의 계정만 사용이 가능해요\n- 한 기계에서 하나만 할 수 있어요\n- 동일 아이피당 몇개만 가능해요\n- 특정기계, 어뷰징과 중복 방지가 되어 있어요\n[FFCCCC]- 어뷰징과 부정행위시 계정이 정지될 수 있어요[-]", NCBAGGNLLLK);
		}
		if (JKOEPLLJDKM != 0)
		{
			stringBuilder.AppendFormat("com.unity3d.player.UnityPlayer", JKOEPLLJDKM);
		}
		if (ELOOOLLHHID != 1654f)
		{
			stringBuilder.AppendFormat("skill0_missile_return", ELOOOLLHHID * 532f);
		}
		if (FBEBCNEPHJD != 0)
		{
			stringBuilder.AppendFormat("찾을 이름을 적어주세요", FBEBCNEPHJD);
		}
		if (NLMHKBGDKLA != 0)
		{
			stringBuilder.AppendFormat("{0}", NLMHKBGDKLA);
		}
		if (NEPGMKLCMFF != 1791f)
		{
			stringBuilder.AppendFormat("챌린저", NEPGMKLCMFF * 655f);
		}
		if (IJAPPEMLBBN.Length > 1)
		{
			stringBuilder.Append(IJAPPEMLBBN);
		}
		return stringBuilder.ToString();
	}

	[SpecialName]
	protected void KLNNAKFOCFL(ACPICCBBPHF ICENKPDOHBK)
	{
		GCJFDJMKNKG = ICENKPDOHBK;
	}

	public virtual int DANGCBMLJHE()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("currency", HBNJODMNFPM());
		stringBuilder.AppendFormat("Olaf", LHEKBMLAJMA);
		stringBuilder.AppendFormat("하급 마나 표식", KBMBFHHNDPE);
		stringBuilder.AppendFormat("Refresh", NJCBMDJOIAH);
		stringBuilder.AppendFormat("Main menu", LAAGBIKMHAE);
		stringBuilder.AppendFormat("순위 없음", MGLIOBDEJLF);
		stringBuilder.AppendFormat("늑대", HFGCMLGPJAO);
		stringBuilder.AppendFormat("_Color", FBEBCNEPHJD);
		stringBuilder.AppendFormat("中", NLMHKBGDKLA);
		stringBuilder.AppendFormat("MtmGame", NMFDEKCMJAH);
		stringBuilder.AppendFormat("Particle/{0}/skill2", NCBAGGNLLLK);
		stringBuilder.AppendFormat("skill3_hit", JKOEPLLJDKM);
		stringBuilder.AppendFormat("DeathMyself", ELOOOLLHHID);
		stringBuilder.AppendFormat("skill2", BELPBCDOPBA);
		stringBuilder.AppendFormat("휴대폰 네트워크가 불안합니다! PING[{0}ms]", PPNKFFAHHBB);
		stringBuilder.AppendFormat("기본공격을 받으면 적 챔피언에게 체력대비 마법피해 및 고통스러운 상처를 되돌려줌", MOHEOOEFLNK);
		stringBuilder.AppendFormat("extra_attrs", CJALIPCFCLA);
		stringBuilder.AppendFormat("]", BDKLLIMAGPP);
		stringBuilder.AppendFormat("brand_passive_fire", NEPGMKLCMFF);
		stringBuilder.AppendFormat("AJPLiveOpsPopupUnityEventListener : onCancelPopupBtnClick", MGGCDFHFMKK);
		stringBuilder.AppendFormat("skill0_loop", OMPBNLBKLIM);
		stringBuilder.AppendFormat("attack2", FILHECEKNMK);
		stringBuilder.AppendFormat("platinum", AMENIOICKGM);
		return stringBuilder.ToString().GetHashCode();
	}

	public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
	{
		DFDMHBOCHNA((ACPICCBBPHF)EFDLFNPAKGO.KFAGPDGHEBK());
		GAFNNDHJDAE = EFDLFNPAKGO.AFPCLLNMGJP();
		IJAPPEMLBBN = EFDLFNPAKGO.AFPCLLNMGJP();
		CIGEEDBPDDM = EFDLFNPAKGO.JCGKFEPEJPO();
		LHEKBMLAJMA = EFDLFNPAKGO.PNBKOPGIHDI();
		KBMBFHHNDPE = EFDLFNPAKGO.PNBKOPGIHDI();
		NJCBMDJOIAH = EFDLFNPAKGO.PNBKOPGIHDI();
		LAAGBIKMHAE = EFDLFNPAKGO.PNBKOPGIHDI();
		MGLIOBDEJLF = EFDLFNPAKGO.PNBKOPGIHDI();
		HFGCMLGPJAO = EFDLFNPAKGO.GCFOKBADLFB();
		FBEBCNEPHJD = EFDLFNPAKGO.PNBKOPGIHDI();
		NLMHKBGDKLA = EFDLFNPAKGO.PNBKOPGIHDI();
		NMFDEKCMJAH = EFDLFNPAKGO.GCFOKBADLFB();
		NCBAGGNLLLK = EFDLFNPAKGO.PNBKOPGIHDI();
		JKOEPLLJDKM = EFDLFNPAKGO.PNBKOPGIHDI();
		ELOOOLLHHID = EFDLFNPAKGO.GCFOKBADLFB();
		BELPBCDOPBA = EFDLFNPAKGO.PNBKOPGIHDI();
		PPNKFFAHHBB = EFDLFNPAKGO.GCFOKBADLFB();
		MOHEOOEFLNK = EFDLFNPAKGO.GCFOKBADLFB();
		CJALIPCFCLA = EFDLFNPAKGO.GCFOKBADLFB();
		BDKLLIMAGPP = EFDLFNPAKGO.GCFOKBADLFB();
		NEPGMKLCMFF = EFDLFNPAKGO.GCFOKBADLFB();
		MGGCDFHFMKK = EFDLFNPAKGO.PNBKOPGIHDI();
		OMPBNLBKLIM = EFDLFNPAKGO.PNBKOPGIHDI();
		FILHECEKNMK = EFDLFNPAKGO.GCFOKBADLFB();
		AMENIOICKGM = EFDLFNPAKGO.GCFOKBADLFB();
	}

	public void AEKECAINBCA(CMNIABEFLBJ EFDLFNPAKGO)
	{
		EFDLFNPAKGO.HEDNLNDFFCL(EHFEEIJKJHD());
		EFDLFNPAKGO.GBMJNFOEACC((byte)EBHAKAADLEK());
		EFDLFNPAKGO.GBMJNFOEACC(GAFNNDHJDAE);
		EFDLFNPAKGO.GBMJNFOEACC(IJAPPEMLBBN);
		EFDLFNPAKGO.KHEGDBFKNMB(CIGEEDBPDDM);
		EFDLFNPAKGO.GBMJNFOEACC(LHEKBMLAJMA);
		EFDLFNPAKGO.GBMJNFOEACC(KBMBFHHNDPE);
		EFDLFNPAKGO.GBMJNFOEACC(NJCBMDJOIAH);
		EFDLFNPAKGO.GBMJNFOEACC(LAAGBIKMHAE);
		EFDLFNPAKGO.GBMJNFOEACC(MGLIOBDEJLF);
		EFDLFNPAKGO.GBMJNFOEACC(HFGCMLGPJAO);
		EFDLFNPAKGO.GBMJNFOEACC(FBEBCNEPHJD);
		EFDLFNPAKGO.GBMJNFOEACC(NLMHKBGDKLA);
		EFDLFNPAKGO.GBMJNFOEACC(NMFDEKCMJAH);
		EFDLFNPAKGO.GBMJNFOEACC(NCBAGGNLLLK);
		EFDLFNPAKGO.GBMJNFOEACC(JKOEPLLJDKM);
		EFDLFNPAKGO.GBMJNFOEACC(ELOOOLLHHID);
		EFDLFNPAKGO.GBMJNFOEACC(BELPBCDOPBA);
		EFDLFNPAKGO.GBMJNFOEACC(PPNKFFAHHBB);
		EFDLFNPAKGO.GBMJNFOEACC(MOHEOOEFLNK);
		EFDLFNPAKGO.GBMJNFOEACC(CJALIPCFCLA);
		EFDLFNPAKGO.GBMJNFOEACC(BDKLLIMAGPP);
		EFDLFNPAKGO.GBMJNFOEACC(NEPGMKLCMFF);
		EFDLFNPAKGO.GBMJNFOEACC(MGGCDFHFMKK);
		EFDLFNPAKGO.GBMJNFOEACC(OMPBNLBKLIM);
		EFDLFNPAKGO.GBMJNFOEACC(FILHECEKNMK);
		EFDLFNPAKGO.GBMJNFOEACC(AMENIOICKGM);
	}

	[SpecialName]
	protected void GCPPGBFLCPN(ACPICCBBPHF ICENKPDOHBK)
	{
		GCJFDJMKNKG = ICENKPDOHBK;
	}

	[SpecialName]
	protected internal void PKMICNPOHGH(ObscuredUShort ICENKPDOHBK)
	{
		EAIGAJDGKFI = ICENKPDOHBK;
	}

	protected void DFDMHBOCHNA(ACPICCBBPHF ICENKPDOHBK)
	{
		GCJFDJMKNKG = ICENKPDOHBK;
	}

	[SpecialName]
	public ACPICCBBPHF KNHFICOKDCD()
	{
		return GCJFDJMKNKG;
	}

	public bool POLDNPKBGIH()
	{
		if (ONJCKKLOJIA() == ACPICCBBPHF.Active || ONJCKKLOJIA() == ACPICCBBPHF.ChargeConsume || ONJCKKLOJIA() == ACPICCBBPHF.Consume)
		{
			return true;
		}
		return false;
	}

	public ObscuredUShort EHFEEIJKJHD()
	{
		return EAIGAJDGKFI;
	}

	[SpecialName]
	public ACPICCBBPHF EBHAKAADLEK()
	{
		return GCJFDJMKNKG;
	}

	[SpecialName]
	public ACPICCBBPHF ODNFALIBMFO()
	{
		return GCJFDJMKNKG;
	}

	public override int GetHashCode()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("{0}", EHFEEIJKJHD());
		stringBuilder.AppendFormat("{0}", LHEKBMLAJMA);
		stringBuilder.AppendFormat("{0}", KBMBFHHNDPE);
		stringBuilder.AppendFormat("{0}", NJCBMDJOIAH);
		stringBuilder.AppendFormat("{0}", LAAGBIKMHAE);
		stringBuilder.AppendFormat("{0}", MGLIOBDEJLF);
		stringBuilder.AppendFormat("{0}", HFGCMLGPJAO);
		stringBuilder.AppendFormat("{0}", FBEBCNEPHJD);
		stringBuilder.AppendFormat("{0}", NLMHKBGDKLA);
		stringBuilder.AppendFormat("{0}", NMFDEKCMJAH);
		stringBuilder.AppendFormat("{0}", NCBAGGNLLLK);
		stringBuilder.AppendFormat("{0}", JKOEPLLJDKM);
		stringBuilder.AppendFormat("{0}", ELOOOLLHHID);
		stringBuilder.AppendFormat("{0}", BELPBCDOPBA);
		stringBuilder.AppendFormat("{0}", PPNKFFAHHBB);
		stringBuilder.AppendFormat("{0}", MOHEOOEFLNK);
		stringBuilder.AppendFormat("{0}", CJALIPCFCLA);
		stringBuilder.AppendFormat("{0}", BDKLLIMAGPP);
		stringBuilder.AppendFormat("{0}", NEPGMKLCMFF);
		stringBuilder.AppendFormat("{0}", MGGCDFHFMKK);
		stringBuilder.AppendFormat("{0}", OMPBNLBKLIM);
		stringBuilder.AppendFormat("{0}", FILHECEKNMK);
		stringBuilder.AppendFormat("{0}", AMENIOICKGM);
		return stringBuilder.ToString().GetHashCode();
	}

	[SpecialName]
	public ACPICCBBPHF FKNHBBDAEMA()
	{
		return GCJFDJMKNKG;
	}

	[SpecialName]
	protected internal void HAAHEFELFHO(ObscuredUShort ICENKPDOHBK)
	{
		EAIGAJDGKFI = ICENKPDOHBK;
	}

	[SpecialName]
	protected void CAHBCJNPOLO(ACPICCBBPHF ICENKPDOHBK)
	{
		GCJFDJMKNKG = ICENKPDOHBK;
	}

	[SpecialName]
	public ObscuredUShort HBNJODMNFPM()
	{
		return EAIGAJDGKFI;
	}
}
