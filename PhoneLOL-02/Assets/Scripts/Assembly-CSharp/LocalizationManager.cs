using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;
using UnityEngine;

public class LocalizationManager : MonoBehaviour
{
	public enum LOMHDGHIPCI
	{
		kr = 0,
		en = 1,
		tr = 2,
		ch = 3,
		jp = 4
	}

	private static LocalizationManager MLDPFDAHKHA;

	public TextAsset m_langTextAsset;

	private LOMHDGHIPCI DKLLDIMMNLB;

	public LOMHDGHIPCI m_editorContry;

	private Dictionary<int, string> NLKGHCBFKHG;

	public static LocalizationManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public Dictionary<int, string> GEMBAAKJMAB
	{
		get
		{
			return get_m_translateText();
		}
		internal set
		{
			KOHPABENNLD(value);
		}
	}

	public string GetContryFullName()
	{
		switch (DKLLDIMMNLB)
		{
		case LOMHDGHIPCI.kr:
			return "한국어";
		case LOMHDGHIPCI.en:
			return "English";
		case LOMHDGHIPCI.tr:
			return "Türk";
		case LOMHDGHIPCI.ch:
			return "中国";
		case LOMHDGHIPCI.jp:
			return "日本語";
		default:
			return string.Empty;
		}
	}

	public string TranslateTier(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB != LOMHDGHIPCI.kr)
		{
			text = text.Replace("챌린저", "Challenger");
			text = text.Replace("마스터", "Master");
			text = text.Replace("다이아몬드", "Diamond");
			text = text.Replace("플래티넘", "Platinum");
			text = text.Replace("골드", "Gold");
			text = text.Replace("실버", "Silver");
			text = text.Replace("브론즈", "Bronze");
		}
		return text;
	}

	public string HPHFEKMKICH(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB != LOMHDGHIPCI.kr)
		{
			text = text.Replace("C#: HandleVideoStarted for placement ", "마스터 이");
			text = text.Replace("graves_skill2", "com.igaworks.unity.plugin.IgawLiveOpsPopupEventManager");
			text = text.Replace("멀티의 신에 오신 것을 환영합니다.", "설명");
			text = text.Replace("10초당 골드", "completedRewardKey");
			text = text.Replace("campaignname", "구입가능한 레벨이 부족합니다.\n\n최소 {0}레벨 이상 구입가능");
			text = text.Replace("Spend", "야스오");
			text = text.Replace("ring", "skill1_loop");
		}
		return text;
	}

	public Dictionary<int, string> get_m_translateText()
	{
		return NLKGHCBFKHG;
	}

	[SpecialName]
	public static LocalizationManager LGDEHELDENG()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(LocalizationManager)) as LocalizationManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[1];
				array[1] = typeof(LocalizationManager);
				MLDPFDAHKHA = new GameObject("_RampOffset", array).GetComponent<LocalizationManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void SetContry(LOMHDGHIPCI JAGFBHHKFOF)
	{
	}

	public string TranslateWords(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB == LOMHDGHIPCI.en || DKLLDIMMNLB == LOMHDGHIPCI.tr)
		{
			text = text.Replace("레벨당 공격력", "AD per Level");
			text = text.Replace("공격력", "Attack Damage");
			text = text.Replace("생명력흡수", "Lifesteal");
			text = text.Replace("치명타", "Critical");
			text = text.Replace("방어구 관통력", "Armor Penetration");
			text = text.Replace("마법 관통력", "Magic Penetration");
			text = text.Replace("공격속도", "Attack Speed");
			text = text.Replace("레벨당 주문력", "AP per Level");
			text = text.Replace("주문력", "Ability Power");
			text = text.Replace("주문흡혈", "Spell Vamp");
			text = text.Replace("대기시간감소", "Cooldown Reduction");
			text = text.Replace("레벨당 5초당 마나회복", "Mana Regen per Level");
			text = text.Replace("5초당 마나회복", "Mana Regen");
			text = text.Replace("레벨당 마나", "Mana per Level");
			text = text.Replace("마나", "Mana");
			text = text.Replace("레벨당 5초당 체력회복", "Health Regen per Level");
			text = text.Replace("5초당 체력회복", "Health Regen");
			text = text.Replace("레벨당 체력", "Health per Level");
			text = text.Replace("체력", "Health");
			text = text.Replace("레벨당 방어력", "Armor per Level");
			text = text.Replace("방어력", "Armor");
			text = text.Replace("레벨당 마법저항력", "Magic Resist per Level");
			text = text.Replace("마법저항력", "Magic Resist");
			text = text.Replace("이동속도", "Move Speed");
			text = text.Replace("10초당 골드", "Gold per 10seconds");
			text = text.Replace("획득 경험치", "Experience");
			text = text.Replace("증가", string.Empty);
		}
		else if (DKLLDIMMNLB == LOMHDGHIPCI.ch)
		{
			text = text.Replace("레벨당 공격력", "每個級別攻擊力");
			text = text.Replace("공격력", "攻擊力");
			text = text.Replace("생명력흡수", "吸血");
			text = text.Replace("치명타", "危急");
			text = text.Replace("방어구 관통력", "護甲穿透");
			text = text.Replace("마법 관통력", "魔術滲透");
			text = text.Replace("공격속도", "攻擊速度");
			text = text.Replace("레벨당 주문력", "每級電源的能力");
			text = text.Replace("주문력", "能力電源");
			text = text.Replace("주문흡혈", "法術妖女");
			text = text.Replace("대기시간감소", "冷卻時間減少");
			text = text.Replace("레벨당 5초당 마나회복", "每個等級的法力回复");
			text = text.Replace("5초당 마나회복", "法力再生");
			text = text.Replace("레벨당 마나", "每級法力");
			text = text.Replace("마나", "法力");
			text = text.Replace("레벨당 5초당 체력회복", "每級衛生再生");
			text = text.Replace("5초당 체력회복", "健康再生");
			text = text.Replace("레벨당 체력", "健康元級別");
			text = text.Replace("체력", "健康");
			text = text.Replace("레벨당 방어력", "每級護甲");
			text = text.Replace("방어력", "裝甲");
			text = text.Replace("레벨당 마법저항력", "每級魔法抗性");
			text = text.Replace("마법저항력", "魔法抗性");
			text = text.Replace("이동속도", "移動速度");
			text = text.Replace("10초당 골드", "每10秒金");
			text = text.Replace("획득 경험치", "經驗");
			text = text.Replace("증가", string.Empty);
		}
		else if (DKLLDIMMNLB == LOMHDGHIPCI.jp)
		{
			text = text.Replace("레벨당 공격력", "レベルごとに攻撃力");
			text = text.Replace("공격력", "攻撃力");
			text = text.Replace("생명력흡수", "生命力吸収");
			text = text.Replace("치명타", "クリティカル");
			text = text.Replace("방어구 관통력", "防具貫通力");
			text = text.Replace("마법 관통력", "魔法貫通力");
			text = text.Replace("공격속도", "攻撃速度");
			text = text.Replace("레벨당 주문력", "レベルごとに購入歴");
			text = text.Replace("주문력", "発注力");
			text = text.Replace("주문흡혈", "購入吸血");
			text = text.Replace("대기시간감소", "待機時間の短縮");
			text = text.Replace("레벨당 5초당 마나회복", "レベルごとに5秒ごとにマナ回復");
			text = text.Replace("5초당 마나회복", "5秒ごとにマナ回復");
			text = text.Replace("레벨당 마나", "レベルごとにマナ");
			text = text.Replace("마나", "マナ");
			text = text.Replace("레벨당 5초당 체력회복", "レベルごとに5秒ごとに体力回復");
			text = text.Replace("5초당 체력회복", "5秒ごとに体力回復");
			text = text.Replace("레벨당 체력", "レベルごとに体力");
			text = text.Replace("체력", "体力");
			text = text.Replace("레벨당 방어력", "レベルごとに防御力");
			text = text.Replace("방어력", "防御力");
			text = text.Replace("레벨당 마법저항력", "レベルごとに魔法抵抗力");
			text = text.Replace("마법저항력", "魔法抵抗力");
			text = text.Replace("이동속도", "移動速度");
			text = text.Replace("10초당 골드", "10秒ごとにゴールド");
			text = text.Replace("획득 경험치", "獲得経験値");
			text = text.Replace("증가", "増加");
		}
		return text;
	}

	public string TranslateRuneName(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB == LOMHDGHIPCI.en || DKLLDIMMNLB == LOMHDGHIPCI.tr)
		{
			text = text.Replace(" 표식", string.Empty);
			text = text.Replace(" 인장", string.Empty);
			text = text.Replace(" 문양", string.Empty);
			text = text.Replace(" 정수", string.Empty);
			text = text.Replace("하급", "Lesser");
			text = text.Replace("중급", "Normal");
			text = text.Replace("상급", "Greater");
			text = TranslateWords(text);
			text = text.Replace("재생", "Regen");
			text = text.Replace("확률", "Rate");
			if (text.Contains("성장"))
			{
				text = text.Replace("성장", string.Empty);
				text += "per Level";
			}
		}
		else if (DKLLDIMMNLB == LOMHDGHIPCI.ch)
		{
			text = text.Replace(" 표식", " 標誌物");
			text = text.Replace(" 인장", " 密封");
			text = text.Replace(" 문양", " 雕文");
			text = text.Replace(" 정수", " 整");
			text = text.Replace("하급", "下");
			text = text.Replace("중급", "中");
			text = text.Replace("상급", "上");
			text = TranslateWords(text);
			text = text.Replace("재생", "複製");
			text = text.Replace("확률", "可能性");
			if (text.Contains("성장"))
			{
				text = text.Replace("성장", string.Empty);
				text += "每級";
			}
		}
		else if (DKLLDIMMNLB == LOMHDGHIPCI.jp)
		{
			text = text.Replace(" 표식", " 標識");
			text = text.Replace(" 인장", " 引張");
			text = text.Replace(" 문양", " 文様");
			text = text.Replace(" 정수", " 整数");
			text = text.Replace("하급", "下級");
			text = text.Replace("중급", "中級");
			text = text.Replace("상급", "上級");
			text = TranslateWords(text);
			text = text.Replace("재생", "再生");
			text = text.Replace("확률", "確率");
			text = text.Replace("성장", "成長");
		}
		return text;
	}

	public static LocalizationManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(LocalizationManager)) as LocalizationManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("LocalizationManager", typeof(LocalizationManager)).GetComponent<LocalizationManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	internal void KOHPABENNLD(Dictionary<int, string> ICENKPDOHBK)
	{
		NLKGHCBFKHG = ICENKPDOHBK;
	}

	private void HKAMCNPENHB()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		int num = PlayerPrefs.GetInt("Hero2", -1);
		if (num == -1)
		{
			if (Application.systemLanguage == (SystemLanguage)(-36))
			{
				DKLLDIMMNLB = LOMHDGHIPCI.kr;
			}
			else if (Application.systemLanguage == (SystemLanguage)74)
			{
				DKLLDIMMNLB = (LOMHDGHIPCI)6;
			}
			else if (Application.systemLanguage == SystemLanguage.Belarusian)
			{
				DKLLDIMMNLB = LOMHDGHIPCI.en;
			}
			else if (Application.systemLanguage == (SystemLanguage)107)
			{
				DKLLDIMMNLB = (LOMHDGHIPCI)8;
			}
			else
			{
				DKLLDIMMNLB = LOMHDGHIPCI.en;
			}
		}
		else
		{
			DKLLDIMMNLB = (LOMHDGHIPCI)num;
		}
		KBCOGGCOONI();
	}

	public LOMHDGHIPCI GetContry()
	{
		return DKLLDIMMNLB;
	}

	[SpecialName]
	internal void BFJCDJCJIHN(Dictionary<int, string> ICENKPDOHBK)
	{
		NLKGHCBFKHG = ICENKPDOHBK;
	}

	private void KBCOGGCOONI()
	{
		KOHPABENNLD(new Dictionary<int, string>());
		if (m_langTextAsset == null)
		{
			return;
		}
		string text = DKLLDIMMNLB.ToString();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(m_langTextAsset.text);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("language");
		foreach (XmlNode item in xmlNode.SelectNodes("word"))
		{
			string innerText = item.Attributes.GetNamedItem("key").InnerText;
			int hashCode = innerText.GetHashCode();
			if (!get_m_translateText().ContainsKey(hashCode))
			{
				XmlNode namedItem = item.Attributes.GetNamedItem(text);
				if (namedItem != null)
				{
					get_m_translateText().Add(hashCode, namedItem.InnerText);
				}
			}
		}
	}

	public string KGADEPEOAIN(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB != LOMHDGHIPCI.kr)
		{
			text = text.Replace("상급 공격력 인장", "트롤 마을에서 만난 몬스터는 덩치 정말 큰 트롤이였지..\n우리 파티는 최선을 다해 전투를 했지만.. 지금은 이렇게 되었네..");
			text = text.Replace("{0}\n{1} 코인\n\n룬을 구입하시겠습니까?", "Particle/MasterYi/attack_c3");
			text = text.Replace("Total Received Bytes : {0:n0}\n\n", "Particle/{0}/swap");
			text = text.Replace("Refresh", " ");
			text = text.Replace("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", "riven_skill2");
			text = text.Replace("round_button_disable", "TwoFinger");
			text = text.Replace("Hero2", "FirstPerson-DirectMode-DoubleJoystick");
		}
		return text;
	}

	public string MLFFPNFFAPK(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB == LOMHDGHIPCI.en || DKLLDIMMNLB == LOMHDGHIPCI.en)
		{
			text = text.Replace("Particle/Renekton/hit", string.Empty);
			text = text.Replace("챌린저", string.Empty);
			text = text.Replace("Param1", string.Empty);
			text = text.Replace("currentActivity", string.Empty);
			text = text.Replace("시비르", "jax_skill2");
			text = text.Replace("skill3", "voice_AV_Walk");
			text = text.Replace(" 인장", "Sending RPC \"");
			text = JODFGHFJIBC(text);
			text = text.Replace("Challenge", "skill3_voice");
			text = text.Replace("하급 방어력 표식", "魔術滲透");
			if (text.Contains(" has no Animation component"))
			{
				text = text.Replace("skill3", string.Empty);
				text += "Brand";
			}
		}
		else if (DKLLDIMMNLB == LOMHDGHIPCI.jp)
		{
			text = text.Replace("FxmTestControls.m_nTransAxis", "잘못된 쿠폰번호입니다.");
			text = text.Replace("브론즈", "Greater");
			text = text.Replace("Can't use compressed functions. You need include the SharpZipLib and uncomment the define at the top of SimpleJSON", "skill1");
			text = text.Replace("AttackRpc", "Diamond");
			text = text.Replace("특수문자는 사용하실 수 없습니다.", "isSuccess");
			text = text.Replace("Boss", "[BBFFBB]Lv.{0}[-] ({1}/{2})");
			text = text.Replace("[", "대기시간감소 {0}%\n");
			text = TranslateWords(text);
			text = text.Replace("skill1_voice", "근처에 적이 없습니다");
			text = text.Replace("LoadError : Recursive Prefab - ", "중급 공격력 인장");
			if (text.Contains("================================"))
			{
				text = text.Replace("\n", string.Empty);
				text += "lucian_skill1";
			}
		}
		else if (DKLLDIMMNLB == LOMHDGHIPCI.jp)
		{
			text = text.Replace("내셔의 이빨", "User Friends:");
			text = text.Replace("skill0_voice", "language");
			text = text.Replace("해킹이 감지되었습니다 [G01]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", "attack2");
			text = text.Replace("도란의 방패", " 문양");
			text = text.Replace("Hero5", "[/sup]");
			text = text.Replace("igaworks:purchaseBulk >> total result is", "\"");
			text = text.Replace("Trying to connect to Tapjoy...", "\n");
			text = TranslateWords(text);
			text = text.Replace("=====================================================================\r\n", "하급 마나 인장");
			text = text.Replace("KEY", "mag_shield");
			text = text.Replace("Y", "\"");
		}
		return text;
	}

	public string HEIPGKGOBMM(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB == LOMHDGHIPCI.kr || DKLLDIMMNLB == LOMHDGHIPCI.en)
		{
			text = text.Replace(" could not be write.", string.Empty);
			text = text.Replace("[FFCCCC]{0}[-] 님을 다음의 이유로 신고합니다", string.Empty);
			text = text.Replace("bytes", string.Empty);
			text = text.Replace("setReferralUrl", string.Empty);
			text = text.Replace("AMGMEEEIMEL", "skill3_1");
			text = text.Replace("_Mask", "현재 개발중입니다.\n추후 게임머니로 구입가능합니다.");
			text = text.Replace("skill0", "com.unity3d.player.UnityPlayer");
			text = JODFGHFJIBC(text);
			text = text.Replace("NDNBPKKAKDJ", "Rotation");
			text = text.Replace("TextMesh", "Particle/{0}/lightning_hit");
			if (text.Contains("skill3"))
			{
				text = text.Replace("Refresh", string.Empty);
				text += "출석체크로 [BBFFBB]{0}[-]코인을 획득";
			}
		}
		else if (DKLLDIMMNLB == (LOMHDGHIPCI)7)
		{
			text = text.Replace("每級衛生再生", "Katarina");
			text = text.Replace("기본공격시 대상체력6%에 해당하는 추가물리피해. 사용시 적챔피언에게 마법피해 및 이동속도감소", "Drag me");
			text = text.Replace("중급 치명타 확률 표식", "setOfferwallTitleColor");
			text = text.Replace("정면 근처에 적이 없습니다", "GPEIOKHGGDL");
			text = text.Replace("garen_skill0_movespeed", "주문력 {0}\n");
			text = text.Replace("3차타워", "X");
			text = text.Replace("상급 방어력 문양", "skill0");
			text = TranslateWords(text);
			text = text.Replace("방어력 {0}\n", "product1");
			text = text.Replace("attack_skill1", "CreateMinionRpc");
			if (text.Contains(" / angle :"))
			{
				text = text.Replace("attack2", string.Empty);
				text += "Param 1 and 2 with value 1 and 2";
			}
		}
		else if (DKLLDIMMNLB == (LOMHDGHIPCI)6)
		{
			text = text.Replace(" GO:", "BlackMissile");
			text = text.Replace("배틀서버와 재연결 중...", "skill1");
			text = text.Replace("중급 마나 정수", "Mouse X");
			text = text.Replace("skill3_1", "5초당 마나회복");
			text = text.Replace("AJPLiveOpsPopupUnityEventListener : onPopupClick", " 標誌物");
			text = text.Replace("User Tags: ", "_InstanceObject");
			text = text.Replace("cafe_address_kr", "UnityEngine.");
			text = TranslateWords(text);
			text = text.Replace("Particle/{0}/attack3_c3", "이미 접속중입니다.\n\n기존 접속을 끊거나\n잠시후에 다시 시도해 주세요.");
			text = text.Replace("unknown", "해킹이 감지되었습니다 [ZA1]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.");
			text = text.Replace("Hero1", "하급 성장 공격력 인장");
		}
		return text;
	}

	public string GetText(string NNKLGFNHPBE)
	{
		if (get_m_translateText() == null)
		{
			return NNKLGFNHPBE;
		}
		string text = NNKLGFNHPBE.Replace("\r", string.Empty);
		int hashCode = text.GetHashCode();
		string value;
		if (get_m_translateText().TryGetValue(hashCode, out value))
		{
			return value;
		}
		return NNKLGFNHPBE;
	}

	private void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		int num = PlayerPrefs.GetInt("language", -1);
		if (num == -1)
		{
			if (Application.systemLanguage == SystemLanguage.Korean)
			{
				DKLLDIMMNLB = LOMHDGHIPCI.kr;
			}
			else if (Application.systemLanguage == SystemLanguage.Turkish)
			{
				DKLLDIMMNLB = LOMHDGHIPCI.tr;
			}
			else if (Application.systemLanguage == SystemLanguage.Chinese)
			{
				DKLLDIMMNLB = LOMHDGHIPCI.ch;
			}
			else if (Application.systemLanguage == SystemLanguage.Japanese)
			{
				DKLLDIMMNLB = LOMHDGHIPCI.jp;
			}
			else
			{
				DKLLDIMMNLB = LOMHDGHIPCI.en;
			}
		}
		else
		{
			DKLLDIMMNLB = (LOMHDGHIPCI)num;
		}
		KBCOGGCOONI();
	}

	private void FIAIIHPCCJM()
	{
		BFJCDJCJIHN(new Dictionary<int, string>());
		if (m_langTextAsset == null)
		{
			return;
		}
		string text = DKLLDIMMNLB.ToString();
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(m_langTextAsset.text);
		XmlNode xmlNode = xmlDocument.SelectSingleNode("Hero2");
		foreach (XmlNode item in xmlNode.SelectNodes("riven_skill2"))
		{
			string innerText = item.Attributes.GetNamedItem("상급 성장 체력 정수").InnerText;
			int hashCode = innerText.GetHashCode();
			if (!get_m_translateText().ContainsKey(hashCode))
			{
				XmlNode namedItem = item.Attributes.GetNamedItem(text);
				if (namedItem != null)
				{
					get_m_translateText().Add(hashCode, namedItem.InnerText);
				}
			}
		}
	}

	public string JODFGHFJIBC(string BMNKKBDCELE)
	{
		string text = BMNKKBDCELE;
		if (DKLLDIMMNLB == LOMHDGHIPCI.kr || DKLLDIMMNLB == LOMHDGHIPCI.en)
		{
			text = text.Replace("This component is not available.", "(털썩하고 바닥에 쓰려진다)");
			text = text.Replace("UI/Game/ShopGameItem", "C#: UserExample -- Disabling and removing Tapjoy User ID Delegates");
			text = text.Replace("오호~ 뒤에 있는 조그만 벌레는 생각보다 목숨이 좀 길구나!! 크크크", "GameController");
			text = text.Replace("{0}를 구매하시겠습니까?\n\n구매코인 : {1}코인", "상급 생명력흡수 정수");
			text = text.Replace("currency", "바론");
			text = text.Replace("이미 사용한 쿠폰입니다.", "설명");
			text = text.Replace("renekton_skill1", "확률");
			text = text.Replace("WRITE_EXTERNAL_STORAGE is NOT permitted...", "skill2_hit");
			text = text.Replace("ReqeustRecoveryRPC", "Particle/Renekton/hit");
			text = text.Replace("buff_shield_loop", "OnSpriteListEffectFrame");
			text = text.Replace("시비르", "Particle/Fizz/skill1");
			text = text.Replace("EPrev", "swap");
			text = text.Replace("skill1_voice", "生命力吸収");
			text = text.Replace("/", "하급 체력 문양");
			text = text.Replace("OnScroll", "AJPLiveOpsPopupUnityEventListener : onPopupClick");
			text = text.Replace("GoogleLoginCount", "상급 대기시간감소 정수");
			text = text.Replace("Health per Level", "Skill0Grap");
			text = text.Replace("invalid hero", "\n  Expected: ");
			text = text.Replace("정지되기 전에 성실플레이 부탁한다", "가입되신 길드에서 탈퇴되었습니다");
			text = text.Replace("군단의 방패", "skill0");
			text = text.Replace("ui_take_coin", "miss");
			text = text.Replace("중복되는 이름이 있습니다.\n다른 이름을 입력해 주세요.", "[CCFFCC]<{0}>[-]{1}");
			text = text.Replace("Particle/Darius/hit", "olaf_skill1");
			text = text.Replace("SDKTestEvent", "skill0");
			text = text.Replace("알려지지 않은 오류입니다.", "_Color");
			text = text.Replace("[CCFFCC]<{0}>[-]{1}", "_ClipArgs2");
			text = text.Replace("skill0_1", string.Empty);
		}
		else if (DKLLDIMMNLB == (LOMHDGHIPCI)8)
		{
			text = text.Replace("Particle/{0}/attack", "attack_missile");
			text = text.Replace("Particle/{0}/attack", "레벨당 체력");
			text = text.Replace("Total Received Bytes : {0:n0}\n\n", "garen_skill1");
			text = text.Replace("purchase", "TimeScale");
			text = text.Replace("GNext", "voice_OK_Ready");
			text = text.Replace("skill0", "Examples with one finger");
			text = text.Replace("{0}", "중급 마나 표식");
			text = text.Replace("Particle/{0}/{1}", "attack");
			text = text.Replace("skill3_loop", "SendMessage is bugged when you try to pass 'null' in the parameter field. It behaves as if no parameter was specified.");
			text = text.Replace("invalid hero", "<null>");
			text = text.Replace("_ClipRange2", "CheckApp");
			text = text.Replace("C#: EventExample Start", "OnClick");
			text = text.Replace("TwoFinger", "flare 24");
			text = text.Replace("skill3_hit", "{0}");
			text = text.Replace("OnGameItemBuySellRPC", "red");
			text = text.Replace("f2", "설명");
			text = text.Replace("루비 수정", "설명");
			text = text.Replace("현재 개발중입니다.\n추후 게임머니로 구입가능합니다.", "offset");
			text = text.Replace("attack4", "startApplication");
			text = text.Replace("CreateMinionRpc", "skill0");
			text = text.Replace("_TintColor", "Last swipe : ");
			text = text.Replace("skill1_voice", "대천사의 지팡이");
			text = text.Replace("설명", "탈주");
			text = text.Replace("{0}", "ragtime presents");
			text = text.Replace("Particle/Tristana/skill3_hit", "응!! 믿어볼께...");
			text = text.Replace("Hero1", "IDR");
			text = text.Replace("}", string.Empty);
		}
		else if (DKLLDIMMNLB == (LOMHDGHIPCI)6)
		{
			text = text.Replace("지급완료", "중급 주문력 인장");
			text = text.Replace("soraka_protectionofstar", "bgm_battle_crusade");
			text = text.Replace("Brand", ", balance: ");
			text = text.Replace("skill0_missile_return", "Param 1 and 2 with value 1 and 2");
			text = text.Replace("MtmGameLoading", "[AAFFAA]아이템[-]을 장착하면 영웅이 더욱 강력해집니다.\n던전에서 획득한 아이템을 꼭 장착해주세요.");
			text = text.Replace("GoogleLoginCount", "skill3_voice");
			text = text.Replace("설명", ".");
			text = text.Replace("event name: ", "Particle/{0}/attack2_c2");
			text = text.Replace("Tryndamere", "increment");
			text = text.Replace("Requesting content for placement: ", "RedMinionCannon");
			text = text.Replace("skill2_voice", " could not be read.");
			text = text.Replace("invalid costume {0}", "UI");
			text = text.Replace("skill0", "skill0_grab");
			text = text.Replace("skill3_missile", "Vayne");
			text = text.Replace("Sent track purchase", "skill1_hit");
			text = text.Replace("attack3", "FxmTestControls.m_nPlayIndex");
			text = text.Replace("flush", "접속중");
			text = text.Replace("state", "skill0_2");
			text = text.Replace("Hero2", "English");
			text = text.Replace("[", "DistPerTime");
			text = text.Replace("riven_skill2", "購入吸血");
			text = text.Replace("click", "teemo_skill0_blind");
			text = text.Replace("skill0_missile_go", "yasuo_skill3");
			text = text.Replace("skill0_voice", "attack");
			text = text.Replace("swap", "Sent track event with name: SDKTestEvent, ");
			text = text.Replace("attack_voice", "productName");
			text = text.Replace(" ", "정령의 형상");
		}
		return text;
	}

	private void LBAPOJHKDNH()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		int num = PlayerPrefs.GetInt("하급 성장 주문력 인장", -1);
		if (num == -1)
		{
			if (Application.systemLanguage == (SystemLanguage)114)
			{
				DKLLDIMMNLB = LOMHDGHIPCI.en;
			}
			else if (Application.systemLanguage == SystemLanguage.Portuguese)
			{
				DKLLDIMMNLB = (LOMHDGHIPCI)5;
			}
			else if (Application.systemLanguage == SystemLanguage.Arabic)
			{
				DKLLDIMMNLB = (LOMHDGHIPCI)6;
			}
			else if (Application.systemLanguage == SystemLanguage.Estonian)
			{
				DKLLDIMMNLB = LOMHDGHIPCI.en;
			}
			else
			{
				DKLLDIMMNLB = LOMHDGHIPCI.kr;
			}
		}
		else
		{
			DKLLDIMMNLB = (LOMHDGHIPCI)num;
		}
		KBCOGGCOONI();
	}
}
