using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class JKGHDNIMIEE : NFFHBNEJAEE
{
	private sealed class EHJJKNKEHCA : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal JKGHDNIMIEE KNIAJMGDGAA;

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

		public bool BJEOILGGFLI()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.ODBENGJMILH(1100f);
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Center, "Particle/{0}/skill0_buff_hit", false, "platinum"));
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Center, "이미 접속중입니다.\n\n기존 접속을 끊거나\n잠시후에 다시 시도해 주세요.", true, "하급 성장 마나 인장"));
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, string.Empty, true, "skill1_loop"));
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "teemo_passive", true, "Nexus/RedNexus"));
				GOMFKPLCGNN = 6;
				break;
			case 4u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.JMOACOOLDCH(true, Color.black, 1709f);
				MMEGGNJKNOH = new WaitForSeconds(1741f);
				GOMFKPLCGNN = 2;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, string.Empty, true, "skill2"));
				GOMFKPLCGNN = 4;
				break;
			case 6u:
				MMEGGNJKNOH = new WaitForSeconds(1524f);
				GOMFKPLCGNN = 4;
				break;
			case 7u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.ODBENGJMILH(351f);
				KNIAJMGDGAA.DDEGDABBPDF();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return false;
		}

		[SpecialName]
		private object GDHBJAJPNBF()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object PHDGFFDAMLI()
		{
			return MMEGGNJKNOH;
		}

		public void LDNDAOJGIIO()
		{
			throw new NotSupportedException();
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.ODBENGJMILH(298f);
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "sound", true, "sound"));
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, "painful_wound", true, "정면 근처에 적이 없습니다"));
				GOMFKPLCGNN = 5;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Center, string.Empty, false, "isLimitAdTrackingEnabled"));
				GOMFKPLCGNN = 5;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "hit", false, "skill2_missile"));
				GOMFKPLCGNN = 2;
				break;
			case 4u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.JMOACOOLDCH(true, Color.black, 880f);
				MMEGGNJKNOH = new WaitForSeconds(1409f);
				GOMFKPLCGNN = 3;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Center, string.Empty, true, "브론즈"));
				GOMFKPLCGNN = 8;
				break;
			case 6u:
				MMEGGNJKNOH = new WaitForSeconds(1673f);
				GOMFKPLCGNN = 1;
				break;
			case 7u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.ODBENGJMILH(1619f);
				KNIAJMGDGAA.HIGCLCKDNIB();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		[SpecialName]
		private object JMGIAIKDMIM()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.ODBENGJMILH(1f);
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Hero10002", true, "흐으윽... 가.. 강하군..."));
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Hero1", true, "너무 늦게 알았어!!!"));
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, string.Empty, true, "(문지기가 쓰러진다.)"));
				GOMFKPLCGNN = 3;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, "Hero1", true, "그럼 이제 마계 문을 열어볼까?"));
				GOMFKPLCGNN = 4;
				break;
			case 4u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.JMOACOOLDCH(true, Color.black, 1.5f);
				MMEGGNJKNOH = new WaitForSeconds(3f);
				GOMFKPLCGNN = 5;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Left, string.Empty, true, "굳게 닫혀 열수 없을꺼 같은 거대한 문이 조금씩 열리면서 문사이로 하얀 빛이 새어나오고 있다.\n이제 우리는 마계로 간다."));
				GOMFKPLCGNN = 6;
				break;
			case 6u:
				MMEGGNJKNOH = new WaitForSeconds(3f);
				GOMFKPLCGNN = 7;
				break;
			case 7u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.ODBENGJMILH(1f);
				KNIAJMGDGAA.HIGCLCKDNIB();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return false;
			}
			return true;
		}

		public void OOIACMDIKIA()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object JGDFFAFIKFC()
		{
			return MMEGGNJKNOH;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		public bool KAHALICNEBF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.ODBENGJMILH(1286f);
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Center, "RecoveryRPC", true, "retention"));
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Center, "attack2", false, "알 수 없는 오류"));
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, string.Empty, true, "Igaw.Unity : OnGetTrackingParameterForUnity : "));
				GOMFKPLCGNN = 8;
				break;
			case 3u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Hero, AOAOIDDIIKE.Center, "\n", false, "skill0"));
				GOMFKPLCGNN = 2;
				break;
			case 4u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.JMOACOOLDCH(false, Color.black, 877f);
				MMEGGNJKNOH = new WaitForSeconds(1742f);
				GOMFKPLCGNN = 1;
				break;
			case 5u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(KNIAJMGDGAA.CCOOKGINGLB(JLAMNMBFPBK.Light, AOAOIDDIIKE.Left, string.Empty, true, "주문력"));
				GOMFKPLCGNN = 6;
				break;
			case 6u:
				MMEGGNJKNOH = new WaitForSeconds(23f);
				GOMFKPLCGNN = 0;
				break;
			case 7u:
				KNIAJMGDGAA.PFIINNGKNJH();
				KNIAJMGDGAA.ODBENGJMILH(467f);
				KNIAJMGDGAA.KKAAPHCPGLF();
				GOMFKPLCGNN = -1;
				goto default;
			default:
				return true;
			}
			return false;
		}

		public void CLMMBEKNAJP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object ILBNFHMAGCF()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object GJKMLHEACFK()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void KMGPIGOKDJK()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object BFBDKFOJMAK()
		{
			return MMEGGNJKNOH;
		}

		public void FPLNHDDGGHP()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public void CHFDNLJNKBN()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JNKGFHPIOPG()
		{
			return MMEGGNJKNOH;
		}

		public void DFNHAOEKBCI()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		public void BKLMMEGGMNI()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void DAPBOMILKPH()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}
	}

	public virtual void ALJEFBEMCFK()
	{
		base.MGOENKOOFLO();
	}

	public virtual void LINNBIGKGED()
	{
		base.MGOENKOOFLO();
	}

	public virtual void KKAAPHCPGLF()
	{
		base.HIGCLCKDNIB();
	}

	public virtual IEnumerator HMNOCOBNBAO()
	{
		EHJJKNKEHCA eHJJKNKEHCA = new EHJJKNKEHCA();
		eHJJKNKEHCA.KNIAJMGDGAA = this;
		return eHJJKNKEHCA;
	}

	public virtual void GNOAPFAKBIN()
	{
		base.MGOENKOOFLO();
	}

	public JKGHDNIMIEE()
	{
		EAKNHHJBHOD = 1008;
		CMIOFNJJGFN = 3;
		KONOAEPMEJA = CIPMICDJPEH.Clear;
	}

	public override void MGOENKOOFLO()
	{
		base.MGOENKOOFLO();
	}

	public virtual void LDDLDNKGBBC()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void OJGBPLFKPIJ()
	{
		OENLLEKFJHM();
	}

	public override void HIGCLCKDNIB()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void BKEKAJHABGK()
	{
		base.HIGCLCKDNIB();
	}

	public override void OAADIIIMNDE()
	{
		base.LDNEFFHJNPL();
	}

	public virtual void DFOCBKNIDGB()
	{
		base.MGOENKOOFLO();
	}

	[DebuggerHidden]
	public override IEnumerator LPBLGFCPADD()
	{
		EHJJKNKEHCA eHJJKNKEHCA = new EHJJKNKEHCA();
		eHJJKNKEHCA.KNIAJMGDGAA = this;
		return eHJJKNKEHCA;
	}

	public virtual void DDEGDABBPDF()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void LKJEHBBCCDH()
	{
		base.HIGCLCKDNIB();
	}

	public virtual void JDMOCFODCFG()
	{
		base.MGOENKOOFLO();
	}

	public virtual void NBHEHKDNAIH()
	{
		base.LDNEFFHJNPL();
	}

	public override void LDNEFFHJNPL()
	{
		base.LDNEFFHJNPL();
	}

	public virtual IEnumerator BJKEPMGMJKA()
	{
		EHJJKNKEHCA eHJJKNKEHCA = new EHJJKNKEHCA();
		eHJJKNKEHCA.KNIAJMGDGAA = this;
		return eHJJKNKEHCA;
	}
}
