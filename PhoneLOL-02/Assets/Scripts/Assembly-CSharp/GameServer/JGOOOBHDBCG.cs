using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;

namespace GameServer
{
	public class JGOOOBHDBCG : EOPOBHFNFPA
	{
		public enum ACPICCBBPHF : ushort
		{
			Stun = 1,
			Slow = 2,
			SlowAttack = 3,
			PainfulWound = 4,
			Silence = 5,
			MoveSpeed = 6,
			MoveSpeedPercent = 7,
			Shield = 8,
			MagShield = 9,
			HpPotion = 10,
			LiandryTorment = 11,
			BlackCleaver = 12,
			FloatStun = 13,
			VayneTumble = 14,
			VayneSkill3 = 15,
			VayneStelth = 16,
			Red = 17,
			RedDebuff = 18,
			Blue = 19,
			Dragon = 20,
			Baron = 21,
			SpawnSuperMinion = 22,
			ZedSkill3 = 23,
			AhriSkill2 = 24,
			AhriSkill3 = 25,
			KatarinaSkill0 = 26,
			KatarinaSkill1 = 27,
			EzrealPassive = 28,
			GravesSkill2 = 29,
			BlitzcrankPassive = 30,
			BlitzcrankSkill1 = 31,
			BlitzcrankSkill2 = 32,
			RivenSkill0 = 33,
			RivenSkill2 = 34,
			RivenSkill3 = 35,
			MasterYiSkill1 = 36,
			MasterYiSkill2 = 37,
			MasterYiSkill3 = 38,
			AlistarPassive = 39,
			AlistarSkill3 = 40,
			GarenSkill0 = 41,
			GarenSkill0_MoveSpeed = 42,
			GarenSkill1 = 43,
			RenektonSkill1 = 44,
			RenektonSkill2 = 45,
			RenektonSkill3 = 46,
			SivirPassive = 47,
			SivirSkill2 = 48,
			SivirSkill3 = 49,
			JaxSkill1 = 50,
			JaxSkill2 = 51,
			JaxSkill3 = 52,
			TalonSkill0 = 53,
			TalonSkill0Blood = 54,
			TalonSkill2 = 55,
			TalonSkill3 = 56,
			LucianSkill1 = 57,
			LucianSkill1SpeedUp = 58,
			YasuoPassive = 59,
			YasuoSkill3 = 60,
			VladimirSkill0 = 61,
			VladimirSkill2 = 62,
			VladimirSkill3 = 63,
			TryndamereSkill1 = 64,
			TryndamereSkill3 = 65,
			TeemoPassive = 66,
			TeemoSkill0Blind = 67,
			TeemoSkill1 = 68,
			TeemoSkill2Poison = 69,
			TeemoSkill3Poison = 70,
			BrandPassiveFire = 71,
			BrandPassiveEx = 72,
			BrandDontPassive = 73,
			DariusPassive = 74,
			DariusPassiveEx = 75,
			DariusSkill1 = 76,
			TristanaSkill0 = 77,
			TristanaSkill2 = 78,
			SorakaProtectionOfStar = 79,
			OlafSkill1 = 80,
			OlafSkill3 = 81,
			FizzSkill1Passive = 82,
			FizzSkill1 = 83
		}

		private Dictionary<ushort, IDMGMJLOKBB> FKAKBFOMGDD;

		public Dictionary<ushort, IDMGMJLOKBB> OCNCLEHJFNL
		{
			get
			{
				return IBJONKKGBHN();
			}
			protected set
			{
				LDHJNCKMDKD(value);
			}
		}

		public JGOOOBHDBCG()
		{
			LDHJNCKMDKD(new Dictionary<ushort, IDMGMJLOKBB>());
			IDMGMJLOKBB iDMGMJLOKBB = new IDMGMJLOKBB(1);
			iDMGMJLOKBB.FIGLEPBIEEJ("stun", true, iDMGMJLOKBB.PEBCAPNIMOL(), 1, 2f, 0f, false, "stun");
			IBJONKKGBHN().Add(1, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(2);
			iDMGMJLOKBB.FIGLEPBIEEJ("slow", true, 0, 0, 1f, 0f, false, "slow");
			IBJONKKGBHN().Add(2, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(3);
			iDMGMJLOKBB.FIGLEPBIEEJ("slow_attack", true, 0, 0, 1f, 0f, false, "slow_attack");
			IBJONKKGBHN().Add(3, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(4);
			iDMGMJLOKBB.FIGLEPBIEEJ("painful_wound", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1f, 0f, false, "painful_wound");
			IBJONKKGBHN().Add(4, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(5);
			iDMGMJLOKBB.FIGLEPBIEEJ("silence", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1f, 0f, false, "silence");
			IBJONKKGBHN().Add(5, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(6);
			iDMGMJLOKBB.FIGLEPBIEEJ("move_speed", false, 0, 0, 1f, 0f, false, "move_speed");
			IBJONKKGBHN().Add(6, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(7);
			iDMGMJLOKBB.FIGLEPBIEEJ("move_speed_percent", false, 0, 0, 1f, 0f, false, "move_speed_percent");
			IBJONKKGBHN().Add(7, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(8);
			iDMGMJLOKBB.FIGLEPBIEEJ("shield", false, 0, 0, 1f, 0f, false, "shield");
			IBJONKKGBHN().Add(8, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(9);
			iDMGMJLOKBB.FIGLEPBIEEJ("mag_shield", false, 0, 0, 1f, 0f, false, "mag_shield");
			IBJONKKGBHN().Add(9, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(10);
			iDMGMJLOKBB.FIGLEPBIEEJ("hp_potion", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 15.1f, 0.5f, false, "hp_potion");
			IBJONKKGBHN().Add(10, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(11);
			iDMGMJLOKBB.FIGLEPBIEEJ("liandry_torment", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3.1f, 1f, false, "liandry_torment");
			IBJONKKGBHN().Add(11, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(12);
			iDMGMJLOKBB.FIGLEPBIEEJ("black_cleaver", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "black_cleaver");
			IBJONKKGBHN().Add(12, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(13);
			iDMGMJLOKBB.FIGLEPBIEEJ("float_stun", true, 1, 1, 2f, 0f, false, string.Empty);
			IBJONKKGBHN().Add(13, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(14);
			iDMGMJLOKBB.FIGLEPBIEEJ("vayne_tumble", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "vayne_tumble");
			IBJONKKGBHN().Add(14, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(15);
			iDMGMJLOKBB.FIGLEPBIEEJ("vayne_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 8f, 0f, false, "vayne_skill3");
			IBJONKKGBHN().Add(15, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(16);
			iDMGMJLOKBB.FIGLEPBIEEJ("vayne_stelth", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1f, 0f, false, "vayne_stelth");
			IBJONKKGBHN().Add(16, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(17);
			iDMGMJLOKBB.FIGLEPBIEEJ("red", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 120f, 0f, false, "red");
			IBJONKKGBHN().Add(17, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(18);
			iDMGMJLOKBB.FIGLEPBIEEJ("red_debuff", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3f, 1f, false, "red_debuff");
			IBJONKKGBHN().Add(18, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(19);
			iDMGMJLOKBB.FIGLEPBIEEJ("blue", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 120f, 0f, false, "blue");
			IBJONKKGBHN().Add(19, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(20);
			iDMGMJLOKBB.FIGLEPBIEEJ("dragon", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 180f, 0f, false, "dragon");
			IBJONKKGBHN().Add(20, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(21);
			iDMGMJLOKBB.FIGLEPBIEEJ("baron", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 240f, 0f, false, "baron");
			IBJONKKGBHN().Add(21, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(22);
			iDMGMJLOKBB.FIGLEPBIEEJ("spawn_super_minion", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 180f, 0f, false, "spawn_super_minion");
			IBJONKKGBHN().Add(22, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(23);
			iDMGMJLOKBB.FIGLEPBIEEJ("zed_skill3", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "zed_skill3");
			IBJONKKGBHN().Add(23, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(24);
			iDMGMJLOKBB.FIGLEPBIEEJ("ahri_skill2", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1f, 0f, false, "ahri_skill2");
			IBJONKKGBHN().Add(24, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(25);
			iDMGMJLOKBB.FIGLEPBIEEJ("ahri_skill3", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 10f, 0f, false, "ahri_skill3");
			IBJONKKGBHN().Add(25, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(26);
			iDMGMJLOKBB.FIGLEPBIEEJ("katarina_skill0", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "katarina_skill0");
			IBJONKKGBHN().Add(26, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(27);
			iDMGMJLOKBB.FIGLEPBIEEJ("katarina_skill1", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1f, 0f, false, "katarina_skill1");
			IBJONKKGBHN().Add(27, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(28);
			iDMGMJLOKBB.FIGLEPBIEEJ("ezreal_passive", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "ezreal_passive");
			IBJONKKGBHN().Add(28, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(29);
			iDMGMJLOKBB.FIGLEPBIEEJ("graves_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "graves_skill2");
			IBJONKKGBHN().Add(29, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(30);
			iDMGMJLOKBB.FIGLEPBIEEJ("blitzcrank_passive", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 10f, 0f, false, "blitzcrank_passive");
			IBJONKKGBHN().Add(30, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(31);
			iDMGMJLOKBB.FIGLEPBIEEJ("blitzcrank_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 8f, 0f, false, "blitzcrank_skill1");
			IBJONKKGBHN().Add(31, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(32);
			iDMGMJLOKBB.FIGLEPBIEEJ("blitzcrank_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 20f, 0f, false, "blitzcrank_skill2");
			IBJONKKGBHN().Add(32, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(33);
			iDMGMJLOKBB.FIGLEPBIEEJ("riven_skill0", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "riven_skill0");
			IBJONKKGBHN().Add(33, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(34);
			iDMGMJLOKBB.FIGLEPBIEEJ("riven_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1.5f, 0f, false, "riven_skill2");
			IBJONKKGBHN().Add(34, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(35);
			iDMGMJLOKBB.FIGLEPBIEEJ("riven_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 15f, 0f, false, "riven_skill3");
			IBJONKKGBHN().Add(35, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(36);
			iDMGMJLOKBB.FIGLEPBIEEJ("masteryi_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "masteryi_skill1");
			IBJONKKGBHN().Add(36, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(37);
			iDMGMJLOKBB.FIGLEPBIEEJ("masteryi_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 5f, 0f, false, "masteryi_skill2");
			IBJONKKGBHN().Add(37, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(38);
			iDMGMJLOKBB.FIGLEPBIEEJ("masteryi_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 8f, 0f, false, "masteryi_skill3");
			IBJONKKGBHN().Add(38, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(39);
			iDMGMJLOKBB.FIGLEPBIEEJ("alistar_passive", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3.2f, 0f, false, "alistar_passive");
			IBJONKKGBHN().Add(39, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(40);
			iDMGMJLOKBB.FIGLEPBIEEJ("alistar_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 7f, 0f, false, "alistar_skill3");
			IBJONKKGBHN().Add(40, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(41);
			iDMGMJLOKBB.FIGLEPBIEEJ("garen_skill0", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4.5f, 0f, false, "garen_skill0");
			IBJONKKGBHN().Add(41, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(42);
			iDMGMJLOKBB.FIGLEPBIEEJ("garen_skill0_movespeed", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4.5f, 0f, false, "garen_skill0_movespeed");
			IBJONKKGBHN().Add(42, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(43);
			iDMGMJLOKBB.FIGLEPBIEEJ("garen_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 2f, 0f, false, "garen_skill1");
			IBJONKKGBHN().Add(43, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(44);
			iDMGMJLOKBB.FIGLEPBIEEJ("renekton_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 15f, 0f, false, "renekton_skill1");
			IBJONKKGBHN().Add(44, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(45);
			iDMGMJLOKBB.FIGLEPBIEEJ("renekton_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "renekton_skill2");
			IBJONKKGBHN().Add(45, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(46);
			iDMGMJLOKBB.FIGLEPBIEEJ("renekton_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 15f, 0.5f, false, "renekton_skill3");
			IBJONKKGBHN().Add(46, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(47);
			iDMGMJLOKBB.FIGLEPBIEEJ("sivir_passive", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 2f, 0f, false, "sivir_passive");
			IBJONKKGBHN().Add(47, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(48);
			iDMGMJLOKBB.FIGLEPBIEEJ("sivir_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 2f, 0f, false, "sivir_skill2");
			IBJONKKGBHN().Add(48, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(49);
			iDMGMJLOKBB.FIGLEPBIEEJ("sivir_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 8f, 0f, false, "sivir_skill3");
			IBJONKKGBHN().Add(49, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(50);
			iDMGMJLOKBB.FIGLEPBIEEJ("jax_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 10f, 0f, false, "jax_skill1");
			IBJONKKGBHN().Add(50, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(51);
			iDMGMJLOKBB.FIGLEPBIEEJ("jax_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 2f, 0f, false, "jax_skill2");
			IBJONKKGBHN().Add(51, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(52);
			iDMGMJLOKBB.FIGLEPBIEEJ("jax_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 8f, 0f, false, "jax_skill3");
			IBJONKKGBHN().Add(52, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(53);
			iDMGMJLOKBB.FIGLEPBIEEJ("talon_skill0", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 10f, 0f, false, "talon_skill0");
			IBJONKKGBHN().Add(53, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(54);
			iDMGMJLOKBB.FIGLEPBIEEJ("talon_skill0_blood", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 1f, false, "talon_skill0_blood");
			IBJONKKGBHN().Add(54, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(55);
			iDMGMJLOKBB.FIGLEPBIEEJ("talon_skill2", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3f, 0f, false, "talon_skill2");
			IBJONKKGBHN().Add(55, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(56);
			iDMGMJLOKBB.FIGLEPBIEEJ("talon_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 2.5f, 0f, false, "talon_skill3");
			IBJONKKGBHN().Add(56, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(57);
			iDMGMJLOKBB.FIGLEPBIEEJ("lucian_skill1", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "lucian_skill1");
			IBJONKKGBHN().Add(57, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(58);
			iDMGMJLOKBB.FIGLEPBIEEJ("lucian_skill1_speedup", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1f, 0f, false, "lucian_skill1_speedup");
			IBJONKKGBHN().Add(58, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(59);
			iDMGMJLOKBB.FIGLEPBIEEJ("yasuo_passive", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1.5f, 0f, false, "yasuo_passive");
			IBJONKKGBHN().Add(59, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(60);
			iDMGMJLOKBB.FIGLEPBIEEJ("yasuo_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 15f, 0f, false, "yasuo_skill3");
			IBJONKKGBHN().Add(60, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(61);
			iDMGMJLOKBB.FIGLEPBIEEJ("vladimir_skill0", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3f, 0f, false, "vladimir_skill0");
			IBJONKKGBHN().Add(61, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(62);
			iDMGMJLOKBB.FIGLEPBIEEJ("vladimir_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1.5f, 0f, false, "vladimir_skill2");
			IBJONKKGBHN().Add(62, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(63);
			iDMGMJLOKBB.FIGLEPBIEEJ("vladimir_skill3", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "vladimir_skill3");
			IBJONKKGBHN().Add(63, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(64);
			iDMGMJLOKBB.FIGLEPBIEEJ("tryndamere_skill1", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "tryndamere_skill1");
			IBJONKKGBHN().Add(64, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(65);
			iDMGMJLOKBB.FIGLEPBIEEJ("tryndamere_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "tryndamere_skill3");
			IBJONKKGBHN().Add(65, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(66);
			iDMGMJLOKBB.FIGLEPBIEEJ("teemo_passive", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3f, 0f, false, "teemo_passive");
			IBJONKKGBHN().Add(66, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(67);
			iDMGMJLOKBB.FIGLEPBIEEJ("teemo_skill0_blind", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 1.5f, 0f, false, "teemo_skill0_blind");
			IBJONKKGBHN().Add(67, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(68);
			iDMGMJLOKBB.FIGLEPBIEEJ("teemo_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3f, 0f, false, "teemo_skill1");
			IBJONKKGBHN().Add(68, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(69);
			iDMGMJLOKBB.FIGLEPBIEEJ("teemo_skill2_poison", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4.1f, 1f, false, "teemo_skill2_poison");
			IBJONKKGBHN().Add(69, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(70);
			iDMGMJLOKBB.FIGLEPBIEEJ("teemo_skill3_poison", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 3.1f, 1f, false, "teemo_skill3_poison");
			IBJONKKGBHN().Add(70, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(71);
			iDMGMJLOKBB.FIGLEPBIEEJ("brand_passive_fire", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4.1f, 1f, false, "brand_passive_fire");
			IBJONKKGBHN().Add(71, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(72);
			iDMGMJLOKBB.FIGLEPBIEEJ("brand_passive_ex", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 2f, 0f, false, "brand_passive_ex");
			IBJONKKGBHN().Add(72, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(73);
			iDMGMJLOKBB.FIGLEPBIEEJ("brand_dont_passive", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "brand_dont_passive");
			IBJONKKGBHN().Add(73, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(74);
			iDMGMJLOKBB.FIGLEPBIEEJ("darius_passive", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 5.1f, 1f, false, "darius_passive");
			IBJONKKGBHN().Add(74, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(75);
			iDMGMJLOKBB.FIGLEPBIEEJ("darius_passive_ex", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "darius_passive_ex");
			IBJONKKGBHN().Add(75, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(76);
			iDMGMJLOKBB.FIGLEPBIEEJ("darius_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 30f, 0f, false, "darius_skill1");
			IBJONKKGBHN().Add(76, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(77);
			iDMGMJLOKBB.FIGLEPBIEEJ("tristana_skill0", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 7f, 0f, false, "tristana_skill0");
			IBJONKKGBHN().Add(77, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(78);
			iDMGMJLOKBB.FIGLEPBIEEJ("tristana_skill2", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 4f, 0f, false, "tristana_skill2");
			IBJONKKGBHN().Add(78, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(79);
			iDMGMJLOKBB.FIGLEPBIEEJ("soraka_protectionofstar", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 5.1f, 1f, false, "soraka_protectionofstar");
			IBJONKKGBHN().Add(79, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(80);
			iDMGMJLOKBB.FIGLEPBIEEJ("olaf_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "olaf_skill1");
			IBJONKKGBHN().Add(80, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(81);
			iDMGMJLOKBB.FIGLEPBIEEJ("olaf_skill3", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 6f, 0f, false, "olaf_skill3");
			IBJONKKGBHN().Add(81, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(82);
			iDMGMJLOKBB.FIGLEPBIEEJ("fizz_skill1_passive", true, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 5f, 0.5f, false, "fizz_skill1_passive");
			IBJONKKGBHN().Add(82, iDMGMJLOKBB);
			iDMGMJLOKBB = new IDMGMJLOKBB(83);
			iDMGMJLOKBB.FIGLEPBIEEJ("fizz_skill1", false, iDMGMJLOKBB.PEBCAPNIMOL(), 0, 5f, 0f, false, "fizz_skill1");
			IBJONKKGBHN().Add(83, iDMGMJLOKBB);
		}

		[SpecialName]
		public Dictionary<ushort, IDMGMJLOKBB> LLMJCPIKHNN()
		{
			return FKAKBFOMGDD;
		}

		[SpecialName]
		public Dictionary<ushort, IDMGMJLOKBB> HEJBLJJEFIG()
		{
			return FKAKBFOMGDD;
		}

		public void EIMLGHFBJAB(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.HEDNLNDFFCL((ushort)HJAKFKOJFGE().Count);
			foreach (KeyValuePair<ushort, IDMGMJLOKBB> item in HJAKFKOJFGE())
			{
				item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
			}
		}

		public void JLJIAGGFMNO(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.HEDNLNDFFCL((ushort)LLMJCPIKHNN().Count);
			foreach (KeyValuePair<ushort, IDMGMJLOKBB> item in LLMJCPIKHNN())
			{
				item.Value.CKLEIPGCHNI(EFDLFNPAKGO);
			}
		}

		[SpecialName]
		protected void PIKCJAOPIDK(Dictionary<ushort, IDMGMJLOKBB> ICENKPDOHBK)
		{
			FKAKBFOMGDD = ICENKPDOHBK;
		}

		public IDMGMJLOKBB FMEFKCAPONI(ushort OHGOBGOIECH)
		{
			IDMGMJLOKBB value;
			if (!HJAKFKOJFGE().TryGetValue(OHGOBGOIECH, out value))
			{
				return null;
			}
			return value;
		}

		public void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			EFDLFNPAKGO.GBMJNFOEACC((ushort)IBJONKKGBHN().Count);
			foreach (KeyValuePair<ushort, IDMGMJLOKBB> item in IBJONKKGBHN())
			{
				item.Value.CFGEKKHOKKE(EFDLFNPAKGO);
			}
		}

		[SpecialName]
		public Dictionary<ushort, IDMGMJLOKBB> JLMPGNJDIOM()
		{
			return FKAKBFOMGDD;
		}

		[SpecialName]
		public Dictionary<ushort, IDMGMJLOKBB> NEEJBOEJPHN()
		{
			return FKAKBFOMGDD;
		}

		public void LEDLMGNKOJA(PJEMPFEIOAK EFDLFNPAKGO)
		{
			IBJONKKGBHN().Clear();
			ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
			for (short num2 = 1; num2 < num; num2++)
			{
				IDMGMJLOKBB iDMGMJLOKBB = new IDMGMJLOKBB(0);
				iDMGMJLOKBB.HLFOFGMHEAM(EFDLFNPAKGO);
				NEEJBOEJPHN().Add(iDMGMJLOKBB.PEBCAPNIMOL(), iDMGMJLOKBB);
			}
		}

		public Dictionary<ushort, IDMGMJLOKBB> IBJONKKGBHN()
		{
			return FKAKBFOMGDD;
		}

		public void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			IBJONKKGBHN().Clear();
			ushort num = EFDLFNPAKGO.AJPFAAFLHEB();
			for (short num2 = 0; num2 < num; num2++)
			{
				IDMGMJLOKBB iDMGMJLOKBB = new IDMGMJLOKBB(0);
				iDMGMJLOKBB.JCOLMPJMMEB(EFDLFNPAKGO);
				IBJONKKGBHN().Add(iDMGMJLOKBB.PEBCAPNIMOL(), iDMGMJLOKBB);
			}
		}

		protected void LDHJNCKMDKD(Dictionary<ushort, IDMGMJLOKBB> ICENKPDOHBK)
		{
			FKAKBFOMGDD = ICENKPDOHBK;
		}

		[SpecialName]
		public Dictionary<ushort, IDMGMJLOKBB> HJAKFKOJFGE()
		{
			return FKAKBFOMGDD;
		}

		public IDMGMJLOKBB DDIBAIMBOGJ(ushort OHGOBGOIECH)
		{
			IDMGMJLOKBB value;
			if (!HJAKFKOJFGE().TryGetValue(OHGOBGOIECH, out value))
			{
				return null;
			}
			return value;
		}

		public IDMGMJLOKBB FPICNOOFDOA(ushort OHGOBGOIECH)
		{
			IDMGMJLOKBB value;
			if (!IBJONKKGBHN().TryGetValue(OHGOBGOIECH, out value))
			{
				return null;
			}
			return value;
		}
	}
}
