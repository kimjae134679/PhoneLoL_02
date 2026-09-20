using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class OPLCILAKGIC : NFFHBNEJAEE
{
	private sealed class DFLMODJDBKP : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal OPLCILAKGIC KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}

		public bool IIBEAMELJDD()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, "코인이 부족합니다", true, "TextLongTap"));
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "{0}위 {1}", true, "challenger"));
				GOMFKPLCGNN = 7;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Center, "   ", false, "레벨당 마나"));
				GOMFKPLCGNN = 2;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, (AOAOIDDIIKE)3, "critical_hit", false, "passive_missile"));
				GOMFKPLCGNN = 8;
				break;
			case 4u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Center, "{0}", false, "skill1"));
				GOMFKPLCGNN = 4;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Particle/Spell/flash", false, "Health Regen"));
				GOMFKPLCGNN = 6;
				break;
			case 6u:
				KNIAJMGDGAA.MCGBEHNCGEP();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return false;
		}

		public void PBGEKALPKFI()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object EKEFFEBDAHE()
		{
			return MMEGGNJKNOH;
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool NEOILBIIDBE()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Refresh", true, "Hero10001"));
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Center, "중급 성장 마나 문양", false, "Particle/{0}/lightning_hit"));
				GOMFKPLCGNN = 3;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, (AOAOIDDIIKE)5, "quantity", false, "attack"));
				GOMFKPLCGNN = 8;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, (AOAOIDDIIKE)7, "탈주", false, "Particle/{0}/skill0_ex"));
				GOMFKPLCGNN = 6;
				break;
			case 4u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, "UnAllocateViewID() should be called after the EveView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", false, "Health per Level"));
				GOMFKPLCGNN = 3;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "com.unity3d.player.UnityPlayer", true, " : you must setup receiver gameobject"));
				GOMFKPLCGNN = 0;
				break;
			case 6u:
				KNIAJMGDGAA.MCGBEHNCGEP();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return true;
		}

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BEGFHDBBBJN()
		{
			return MMEGGNJKNOH;
		}

		public void LKGMENJHBGF()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object ILCOECOMDAF()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object FHCBKMICEHI()
		{
			return MMEGGNJKNOH;
		}

		public void NEPECFKOKGN()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Right, "Hero10001", true, "하잖은 벌레들이 여기까지 살아서 왔구나!!"));
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Hero3", true, "그.. 그. 트롤.."));
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Right, "Hero10001", true, "오호~ 뒤에 있는 조그만 벌레는 생각보다 목숨이 좀 길구나!! 크크크"));
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Right, "Hero10001", true, "하지만 그것도 오늘이 마지막 이겠지!!"));
				GOMFKPLCGNN = 4;
				break;
			case 4u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Hero1", true, "길고 짧은건 대봐야 알 수 있는것!!"));
				GOMFKPLCGNN = 5;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Hero1", true, "자!! 간다!!"));
				GOMFKPLCGNN = 6;
				break;
			case 6u:
				KNIAJMGDGAA.HIGCLCKDNIB();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object MGBPOAHMJLK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		public bool HFJNKDFFGNG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, (AOAOIDDIIKE)5, "Failed to Instantiate prefab:", false, "katarina_skill0"));
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, "Language", true, "fizz_skill1_passive"));
				GOMFKPLCGNN = 4;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, (AOAOIDDIIKE)7, "Tryndamere", false, "Particle/Olaf/skill0_missile"));
				GOMFKPLCGNN = 7;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, (AOAOIDDIIKE)3, "hit2", false, "retention"));
				GOMFKPLCGNN = 5;
				break;
			case 4u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, "tryndamere_skill3", true, "skill0"));
				GOMFKPLCGNN = 4;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, "획득 경험치", true, "#########################################"));
				GOMFKPLCGNN = 0;
				break;
			case 6u:
				KNIAJMGDGAA.GPFPLFJCNOL();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		public void JJFHJIEJKNJ()
		{
			throw new NotSupportedException();
		}

		public void NKGKKHGCCJG()
		{
			GOMFKPLCGNN = -1;
		}
	}

	public virtual void MCGBEHNCGEP()
	{
		base.HIGCLCKDNIB();
	}

	public OPLCILAKGIC()
	{
		EAKNHHJBHOD = 1014;
		CMIOFNJJGFN = 3;
		KONOAEPMEJA = CIPMICDJPEH.Begin;
	}

	public virtual void JMHMHHONDDO()
	{
		OAADIIIMNDE();
	}

	public virtual void MADCDCNEGBO()
	{
		base.MGOENKOOFLO();
	}

	public virtual void DDEGDABBPDF()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void BMEDFIPNBJM()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void JMIFCHKCBCB()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void GCFBLCKNHCG()
	{
		base.MGOENKOOFLO();
	}

	public virtual void ELILEDHDHEN()
	{
		base.LDNEFFHJNPL();
	}

	public virtual void IFJGPCOJDMM()
	{
		base.HIGCLCKDNIB();
	}

	public virtual IEnumerator ODHEBKCPBPB()
	{
		DFLMODJDBKP dFLMODJDBKP = new DFLMODJDBKP();
		dFLMODJDBKP.KNIAJMGDGAA = this;
		return dFLMODJDBKP;
	}

	public virtual void GPFPLFJCNOL()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void OJGBPLFKPIJ()
	{
		OAADIIIMNDE();
	}

	[DebuggerHidden]
	public override IEnumerator LPBLGFCPADD()
	{
		DFLMODJDBKP dFLMODJDBKP = new DFLMODJDBKP();
		dFLMODJDBKP.KNIAJMGDGAA = this;
		return dFLMODJDBKP;
	}

	public override void LDNEFFHJNPL()
	{
		base.LDNEFFHJNPL();
	}

	public override void HIGCLCKDNIB()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void DMCEJPAHNHP()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void LKJEHBBCCDH()
	{
		base.HIGCLCKDNIB();
	}

	public override void OENLLEKFJHM()
	{
		COGEJPHIAKE();
	}

	public virtual IEnumerator GIKDMLJFHCM()
	{
		DFLMODJDBKP dFLMODJDBKP = new DFLMODJDBKP();
		dFLMODJDBKP.KNIAJMGDGAA = this;
		return dFLMODJDBKP;
	}

	public override void MGOENKOOFLO()
	{
		base.MGOENKOOFLO();
	}

	public virtual void LNDHNJGOIKC()
	{
		base.MGOENKOOFLO();
	}

	public virtual void LODCKIKABJH()
	{
		base.LDNEFFHJNPL();
	}
}
