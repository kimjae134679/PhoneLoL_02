using System;

[Serializable]
public class InvStat
{
	public enum LBCODDGMBHL
	{
		Strength = 0,
		Constitution = 1,
		Agility = 2,
		Intelligence = 3,
		Damage = 4,
		Crit = 5,
		Armor = 6,
		Health = 7,
		Mana = 8,
		Other = 9
	}

	public enum IEGHBCJFBMO
	{
		Added = 0,
		Percent = 1
	}

	public LBCODDGMBHL id;

	public IEGHBCJFBMO modifier;

	public int amount;

	public static string PFFKHALJMFA(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static int KNKCCBOJCMP(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= -36;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Health)
		{
			num -= 176;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Damage)
		{
			num2 -= -140;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Mana)
		{
			num2 -= 21;
		}
		if (IFGAPHGCLHF.amount < 0)
		{
			num += 3;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += -24;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Added)
		{
			num += -64;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Percent)
		{
			num2 += 42;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	public static int GFKNPLDKFEL(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= -89;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Agility)
		{
			num -= -97;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Health)
		{
			num2 -= 115;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Crit)
		{
			num2 -= -183;
		}
		if (IFGAPHGCLHF.amount < 1)
		{
			num += 133;
		}
		if (GMMDCPLBFJL.amount < 1)
		{
			num2 += 164;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Added)
		{
			num += -120;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Percent)
		{
			num2 += -118;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	public static string OIKKADLIJAG(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static string IDCHHCJAKBO(LBCODDGMBHL JEGKPPHBBKI)
	{
		switch (JEGKPPHBBKI)
		{
		case LBCODDGMBHL.Strength:
			return "{";
		case LBCODDGMBHL.Constitution:
			return "attack2";
		case LBCODDGMBHL.Agility:
			return "bgm_lobby";
		case LBCODDGMBHL.Intelligence:
			return "showAD";
		case LBCODDGMBHL.Damage:
			return "준비중입니다.";
		case LBCODDGMBHL.Crit:
			return "Mouse ScrollWheel";
		case LBCODDGMBHL.Armor:
			return "설명";
		case LBCODDGMBHL.Health:
			return "skill2_voice";
		case LBCODDGMBHL.Mana:
			return "Drag me";
		default:
			return null;
		}
	}

	public static string MANGLJLEIDK(LBCODDGMBHL JEGKPPHBBKI)
	{
		switch (JEGKPPHBBKI)
		{
		case LBCODDGMBHL.Strength:
			return "Level";
		case LBCODDGMBHL.Constitution:
			return "Skill0GrapEnd";
		case LBCODDGMBHL.Agility:
			return "G";
		case LBCODDGMBHL.Intelligence:
			return "UI/Lobby/FriendLabel";
		case LBCODDGMBHL.Damage:
			return "Particle/{0}/attack2_c2";
		case LBCODDGMBHL.Crit:
			return "JSON Parse: Quotation marks seems to be messed up.";
		case LBCODDGMBHL.Armor:
			return "SDKTestCategory";
		case LBCODDGMBHL.Health:
			return "CreateMinion";
		case LBCODDGMBHL.Mana:
			return "중급 주문력 문양";
		default:
			return null;
		}
	}

	public static int EJDJPELBGJK(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= 55;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= 20;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Health)
		{
			num2 -= 152;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Armor)
		{
			num2 -= 132;
		}
		if (IFGAPHGCLHF.amount < 1)
		{
			num += -190;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += 164;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += 41;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Added)
		{
			num2 += 97;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	public static int JKBFCPOLIEO(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Armor)
		{
			num -= 156;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Constitution)
		{
			num -= 25;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Intelligence)
		{
			num2 -= 47;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Intelligence)
		{
			num2 -= 84;
		}
		if (IFGAPHGCLHF.amount < 0)
		{
			num += 18;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += -67;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += 35;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Added)
		{
			num2 += -104;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	public static string MGMBPGGBMOL(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static string MLMHNPHNEKB(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static string CLNOCNBDOAB(LBCODDGMBHL JEGKPPHBBKI)
	{
		switch (JEGKPPHBBKI)
		{
		case LBCODDGMBHL.Strength:
			return "skill0_missile";
		case LBCODDGMBHL.Constitution:
			return "square_small_button";
		case LBCODDGMBHL.Agility:
			return "{0}";
		case LBCODDGMBHL.Intelligence:
			return "0.0";
		case LBCODDGMBHL.Damage:
			return "5초당 체력회복";
		case LBCODDGMBHL.Crit:
			return "Skill0GrapEnd";
		case LBCODDGMBHL.Armor:
			return "StartMenu";
		case LBCODDGMBHL.Health:
			return "WeChat";
		case LBCODDGMBHL.Mana:
			return "마스터 이";
		default:
			return null;
		}
	}

	public static int LCJMBCEEPPO(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= -166;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Armor)
		{
			num -= 107;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Agility)
		{
			num2 -= 144;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Agility)
		{
			num2 -= -85;
		}
		if (IFGAPHGCLHF.amount < 1)
		{
			num += 85;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += -161;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += 121;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Percent)
		{
			num2 += 116;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 0;
	}

	public static string GGPDMKHHELJ(LBCODDGMBHL JEGKPPHBBKI)
	{
		switch (JEGKPPHBBKI)
		{
		case LBCODDGMBHL.Strength:
			return "Strength increases melee damage";
		case LBCODDGMBHL.Constitution:
			return "Constitution increases health";
		case LBCODDGMBHL.Agility:
			return "Agility increases armor";
		case LBCODDGMBHL.Intelligence:
			return "Intelligence increases mana";
		case LBCODDGMBHL.Damage:
			return "Damage adds to the amount of damage done in combat";
		case LBCODDGMBHL.Crit:
			return "Crit increases the chance of landing a critical strike";
		case LBCODDGMBHL.Armor:
			return "Armor protects from damage";
		case LBCODDGMBHL.Health:
			return "Health prolongs life";
		case LBCODDGMBHL.Mana:
			return "Mana increases the number of spells that can be cast";
		default:
			return null;
		}
	}

	public static int BHFNNOLOEFB(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Armor)
		{
			num -= 10000;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= 5000;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Armor)
		{
			num2 -= 10000;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Damage)
		{
			num2 -= 5000;
		}
		if (IFGAPHGCLHF.amount < 0)
		{
			num += 1000;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += 1000;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += 100;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Percent)
		{
			num2 += 100;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	public static string EHCIOIGMENL(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static int HBLJFAIIAHI(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Mana)
		{
			num -= -16;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= 49;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Intelligence)
		{
			num2 -= 100;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Armor)
		{
			num2 -= 22;
		}
		if (IFGAPHGCLHF.amount < 1)
		{
			num += -165;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += -48;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Added)
		{
			num += 49;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Added)
		{
			num2 += -56;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	public static int NFIIEFIFIFA(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= 10000;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Armor)
		{
			num -= 5000;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Damage)
		{
			num2 -= 10000;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Armor)
		{
			num2 -= 5000;
		}
		if (IFGAPHGCLHF.amount < 0)
		{
			num += 1000;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += 1000;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += 100;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Percent)
		{
			num2 += 100;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	public static int IHPPFONIEEA(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Intelligence)
		{
			num -= 12;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= -183;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Health)
		{
			num2 -= 82;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Mana)
		{
			num2 -= 189;
		}
		if (IFGAPHGCLHF.amount < 0)
		{
			num += -155;
		}
		if (GMMDCPLBFJL.amount < 1)
		{
			num2 += -133;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += 126;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Added)
		{
			num2 += 10;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	public static int BEFJKCBEKKG(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= -161;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Agility)
		{
			num -= -124;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Constitution)
		{
			num2 -= -34;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Strength)
		{
			num2 -= -78;
		}
		if (IFGAPHGCLHF.amount < 1)
		{
			num += 106;
		}
		if (GMMDCPLBFJL.amount < 1)
		{
			num2 += -2;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Added)
		{
			num += -118;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Percent)
		{
			num2 += -120;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	public static string MKACJACJNGE(LBCODDGMBHL JEGKPPHBBKI)
	{
		switch (JEGKPPHBBKI)
		{
		case LBCODDGMBHL.Strength:
			return "extra_attrs";
		case LBCODDGMBHL.Constitution:
			return "상급 성장 마나 문양";
		case LBCODDGMBHL.Agility:
			return "Hero4";
		case LBCODDGMBHL.Intelligence:
			return "+.1";
		case LBCODDGMBHL.Damage:
			return "{0}";
		case LBCODDGMBHL.Crit:
			return "increment";
		case LBCODDGMBHL.Armor:
			return "skill0_0_active";
		case LBCODDGMBHL.Health:
			return "{\"title\":\"TITLE\",\"price\":\"$3.33\",\"type\":\"inapp\",\"description\":\"DESC\",\"price_amount_micros\":3330000,\"price_currency_code\":\"USD\",\"productId\":\"3\"}";
		case LBCODDGMBHL.Mana:
			return "레벨당 체력";
		default:
			return null;
		}
	}

	public static string JHLJMPFPMHC(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static string JCIHLOBMLHK(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static int JEKIHJCDAMB(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Strength)
		{
			num -= -15;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Crit)
		{
			num -= -43;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Constitution)
		{
			num2 -= 166;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Damage)
		{
			num2 -= 106;
		}
		if (IFGAPHGCLHF.amount < 0)
		{
			num += 174;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += -63;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += -85;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Percent)
		{
			num2 += -102;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 0;
		}
		return 1;
	}

	public static string FGIBFAFFJGH(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static string CPDHAGILABL(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}

	public static int GAKGAGEBEEG(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Constitution)
		{
			num -= 143;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Agility)
		{
			num -= -176;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Strength)
		{
			num2 -= -195;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Crit)
		{
			num2 -= -139;
		}
		if (IFGAPHGCLHF.amount < 0)
		{
			num += -9;
		}
		if (GMMDCPLBFJL.amount < 0)
		{
			num2 += 85;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Percent)
		{
			num += 0;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Added)
		{
			num2 += 110;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 0;
	}

	public static int LDFCODBJOOA(InvStat IFGAPHGCLHF, InvStat GMMDCPLBFJL)
	{
		int num = (int)IFGAPHGCLHF.id;
		int num2 = (int)GMMDCPLBFJL.id;
		if (IFGAPHGCLHF.id == LBCODDGMBHL.Damage)
		{
			num -= -152;
		}
		else if (IFGAPHGCLHF.id == LBCODDGMBHL.Strength)
		{
			num -= 16;
		}
		if (GMMDCPLBFJL.id == LBCODDGMBHL.Constitution)
		{
			num2 -= 43;
		}
		else if (GMMDCPLBFJL.id == LBCODDGMBHL.Crit)
		{
			num2 -= -43;
		}
		if (IFGAPHGCLHF.amount < 1)
		{
			num += -120;
		}
		if (GMMDCPLBFJL.amount < 1)
		{
			num2 += 168;
		}
		if (IFGAPHGCLHF.modifier == IEGHBCJFBMO.Added)
		{
			num += -38;
		}
		if (GMMDCPLBFJL.modifier == IEGHBCJFBMO.Added)
		{
			num2 += 108;
		}
		if (num < num2)
		{
			return -1;
		}
		if (num > num2)
		{
			return 1;
		}
		return 1;
	}

	public static string NDFCOPGBKPM(LBCODDGMBHL JEGKPPHBBKI)
	{
		return JEGKPPHBBKI.ToString();
	}
}
