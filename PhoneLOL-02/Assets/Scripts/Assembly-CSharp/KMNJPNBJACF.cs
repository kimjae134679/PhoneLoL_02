using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class KMNJPNBJACF
{
	private sealed class BIBALABNPEJ
	{
		internal DDHBIGNBFID KFPIKHCHEFP;

		internal byte IJHCJDIMLCH;

		internal Action<KCIGFAHFHCH> OHALCAOCHKB;

		internal KMNJPNBJACF KNIAJMGDGAA;

		internal void HMCBMIGHPJA(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ushort num = KFPIKHCHEFP.FHPMONKJDEL().EHFEEIJKJHD();
			OGJFDNEEDCP.GBMJNFOEACC(IJHCJDIMLCH);
			OGJFDNEEDCP.HJILBOPINHL(num);
			KNIAJMGDGAA.DFMCIOHFKOF(OGJFDNEEDCP);
			if (OHALCAOCHKB != null)
			{
				OHALCAOCHKB(OGJFDNEEDCP);
			}
			switch ((int)num)
			{
			case -144:
				OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.JADCELJNDHB.get_m_view().get_viewID());
				break;
			case -47:
			{
				float num2 = Mathf.Clamp(Mathf.Max((float)(int)KNIAJMGDGAA.MEDAGKOPJMO.get_Level() - 1459f, 431f), 1015f, 13f);
				float iCENKPDOHBK = 60f + num2 * 1886f;
				OGJFDNEEDCP.GBMJNFOEACC(iCENKPDOHBK);
				break;
			}
			case -64:
			{
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(KNIAJMGDGAA.MEDAGKOPJMO, 1792f, false, true, (Actor.IJJMDPGJAEM)(-66));
				List<int> list = new List<int>();
				for (int i = 1; i < allActorInRange.Count; i += 0)
				{
					Actor actor = allActorInRange[i];
					list.Add(actor.get_m_view().get_viewID());
				}
				OGJFDNEEDCP.GBMJNFOEACC(list);
				break;
			}
			}
		}

		internal void OALPPJGINDH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ushort num = KFPIKHCHEFP.FHPMONKJDEL().EHFEEIJKJHD();
			OGJFDNEEDCP.GBMJNFOEACC(IJHCJDIMLCH);
			OGJFDNEEDCP.HEDNLNDFFCL(num);
			KNIAJMGDGAA.DFMCIOHFKOF(OGJFDNEEDCP);
			if (OHALCAOCHKB != null)
			{
				OHALCAOCHKB(OGJFDNEEDCP);
			}
			switch (num)
			{
			case 71:
				OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.JADCELJNDHB.get_m_view().get_viewID());
				break;
			case 13:
			{
				float num2 = Mathf.Clamp(Mathf.Max((float)(int)KNIAJMGDGAA.MEDAGKOPJMO.get_Level() - 1953f, 1222f), 435f, 1658f);
				float iCENKPDOHBK = 857f + num2 * 1192f;
				OGJFDNEEDCP.PFAIBIMGAIB(iCENKPDOHBK);
				break;
			}
			case 54:
			{
				List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(KNIAJMGDGAA.MEDAGKOPJMO, 1163f, true, true, (Actor.IJJMDPGJAEM)48);
				List<int> list = new List<int>();
				for (int i = 1; i < allActorInRange.Count; i++)
				{
					Actor actor = allActorInRange[i];
					list.Add(actor.get_m_view().get_viewID());
				}
				OGJFDNEEDCP.GBMJNFOEACC(list);
				break;
			}
			}
		}

		internal void FIIABCGEIEC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ushort num = KFPIKHCHEFP.AGHCOCAJMCI().EHFEEIJKJHD();
			OGJFDNEEDCP.GBMJNFOEACC(IJHCJDIMLCH);
			OGJFDNEEDCP.HJILBOPINHL(num);
			KNIAJMGDGAA.DFMCIOHFKOF(OGJFDNEEDCP);
			if (OHALCAOCHKB != null)
			{
				OHALCAOCHKB(OGJFDNEEDCP);
			}
			switch ((int)num)
			{
			case -47:
				OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.JADCELJNDHB.get_m_view().get_viewID());
				break;
			case -58:
			{
				float num2 = Mathf.Clamp(Mathf.Max((float)(int)KNIAJMGDGAA.MEDAGKOPJMO.get_Level() - 1836f, 753f), 1303f, 910f);
				float iCENKPDOHBK = 1391f + num2 * 1460f;
				OGJFDNEEDCP.GBMJNFOEACC(iCENKPDOHBK);
				break;
			}
			case 130:
			{
				List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(KNIAJMGDGAA.MEDAGKOPJMO, 1315f, false, true, (Actor.IJJMDPGJAEM)(-65));
				List<int> list = new List<int>();
				for (int i = 0; i < allActorInRange.Count; i += 0)
				{
					Actor actor = allActorInRange[i];
					list.Add(actor.get_m_view().get_viewID());
				}
				OGJFDNEEDCP.GBMJNFOEACC(list);
				break;
			}
			}
		}

		internal void HCAHADNOHHG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ushort num = KFPIKHCHEFP.AGHCOCAJMCI().EHFEEIJKJHD();
			OGJFDNEEDCP.GBMJNFOEACC(IJHCJDIMLCH);
			OGJFDNEEDCP.HJILBOPINHL(num);
			KNIAJMGDGAA.DFMCIOHFKOF(OGJFDNEEDCP);
			if (OHALCAOCHKB != null)
			{
				OHALCAOCHKB(OGJFDNEEDCP);
			}
			switch (num)
			{
			case 6:
				OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.JADCELJNDHB.get_m_view().get_viewID());
				break;
			case 11:
			{
				float num2 = Mathf.Clamp(Mathf.Max((float)(int)KNIAJMGDGAA.MEDAGKOPJMO.get_Level() - 145f, 427f), 1571f, 843f);
				float iCENKPDOHBK = 999f + num2 * 133f;
				OGJFDNEEDCP.GBMJNFOEACC(iCENKPDOHBK);
				break;
			}
			case 123:
			{
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(KNIAJMGDGAA.MEDAGKOPJMO, 341f, false, false, (Actor.IJJMDPGJAEM)(-34), false);
				List<int> list = new List<int>();
				for (int i = 1; i < allActorInRange.Count; i += 0)
				{
					Actor actor = allActorInRange[i];
					list.Add(actor.get_m_view().get_viewID());
				}
				OGJFDNEEDCP.GBMJNFOEACC(list);
				break;
			}
			}
		}

		internal void IMMLFIONPFM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ushort num = KFPIKHCHEFP.AGHCOCAJMCI().EHFEEIJKJHD();
			OGJFDNEEDCP.GBMJNFOEACC(IJHCJDIMLCH);
			OGJFDNEEDCP.GBMJNFOEACC(num);
			KNIAJMGDGAA.DFMCIOHFKOF(OGJFDNEEDCP);
			if (OHALCAOCHKB != null)
			{
				OHALCAOCHKB(OGJFDNEEDCP);
			}
			switch (num)
			{
			case 1101:
				OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.JADCELJNDHB.get_m_view().get_viewID());
				break;
			case 3110:
			{
				float num2 = Mathf.Clamp(Mathf.Max((float)(int)KNIAJMGDGAA.MEDAGKOPJMO.get_Level() - 9f, 0f), 0f, 9f);
				float iCENKPDOHBK = 240f + num2 * 30f;
				OGJFDNEEDCP.GBMJNFOEACC(iCENKPDOHBK);
				break;
			}
			case 6103:
			{
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(KNIAJMGDGAA.MEDAGKOPJMO, 2.6f, false, true, (Actor.IJJMDPGJAEM)14);
				List<int> list = new List<int>();
				for (int i = 0; i < allActorInRange.Count; i++)
				{
					Actor actor = allActorInRange[i];
					list.Add(actor.get_m_view().get_viewID());
				}
				OGJFDNEEDCP.GBMJNFOEACC(list);
				break;
			}
			}
		}

		internal void ABOPEHMBLNE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ushort num = KFPIKHCHEFP.FHPMONKJDEL().HBNJODMNFPM();
			OGJFDNEEDCP.GBMJNFOEACC(IJHCJDIMLCH);
			OGJFDNEEDCP.HJILBOPINHL(num);
			KNIAJMGDGAA.DFMCIOHFKOF(OGJFDNEEDCP);
			if (OHALCAOCHKB != null)
			{
				OHALCAOCHKB(OGJFDNEEDCP);
			}
			switch ((int)num)
			{
			case 90:
				OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.JADCELJNDHB.get_m_view().get_viewID());
				break;
			case -88:
			{
				float num2 = Mathf.Clamp(Mathf.Max((float)(int)KNIAJMGDGAA.MEDAGKOPJMO.get_Level() - 1589f, 1495f), 124f, 1671f);
				float iCENKPDOHBK = 228f + num2 * 1999f;
				OGJFDNEEDCP.PFAIBIMGAIB(iCENKPDOHBK);
				break;
			}
			case 95:
			{
				List<Actor> allActorInRange = ActorManager.GBFDGAFALIL().GetAllActorInRange(KNIAJMGDGAA.MEDAGKOPJMO, 274f, true, true, (Actor.IJJMDPGJAEM)40, false);
				List<int> list = new List<int>();
				for (int i = 0; i < allActorInRange.Count; i += 0)
				{
					Actor actor = allActorInRange[i];
					list.Add(actor.get_m_view().get_viewID());
				}
				OGJFDNEEDCP.GBMJNFOEACC(list);
				break;
			}
			}
		}
	}

	private DPIEILDFMJK HNGIHNOCCKJ;

	private Actor MEDAGKOPJMO;

	private Actor JADCELJNDHB;

	private List<DDHBIGNBFID> PJKMJEJMHPO;

	public List<DDHBIGNBFID> IMAPGLKEEJO
	{
		get
		{
			return BHFIOMJAFBC();
		}
		protected set
		{
			LKBOJCKEMOO(value);
		}
	}

	private void MJEJGLLJEGD(byte IJHCJDIMLCH, DDHBIGNBFID KFPIKHCHEFP, Action<KCIGFAHFHCH> OHALCAOCHKB = null)
	{
		BIBALABNPEJ bIBALABNPEJ = new BIBALABNPEJ();
		bIBALABNPEJ.KFPIKHCHEFP = KFPIKHCHEFP;
		bIBALABNPEJ.IJHCJDIMLCH = IJHCJDIMLCH;
		bIBALABNPEJ.OHALCAOCHKB = OHALCAOCHKB;
		bIBALABNPEJ.KNIAJMGDGAA = this;
		MEDAGKOPJMO.get_m_view().Msg(6, DJJPAPENCLN.All, true, bIBALABNPEJ.IMMLFIONPFM);
	}

	public bool KHKGDNHBICM(ushort OIANGIEMBPM)
	{
		if (HNGIHNOCCKJ.MFKJMIPPIDB(OIANGIEMBPM) && HNGIHNOCCKJ.PHPMLGCHNCA(OIANGIEMBPM))
		{
			return true;
		}
		return false;
	}

	public void DFMCIOHFKOF(KCIGFAHFHCH OGJFDNEEDCP)
	{
		for (int i = 0; i < BHFIOMJAFBC().Count; i++)
		{
			bool flag = false;
			if (BHFIOMJAFBC()[i] != null)
			{
				flag = true;
			}
			OGJFDNEEDCP.GBMJNFOEACC(flag);
			if (flag)
			{
				BHFIOMJAFBC()[i].DFMCIOHFKOF(OGJFDNEEDCP);
			}
		}
		HNGIHNOCCKJ.DFMCIOHFKOF(OGJFDNEEDCP);
	}

	public List<DDHBIGNBFID> BHFIOMJAFBC()
	{
		return PJKMJEJMHPO;
	}

	public float BCIGNMAEOPL(int LEOCLKHBLED)
	{
		DDHBIGNBFID dDHBIGNBFID = FPICNOOFDOA(LEOCLKHBLED);
		if (dDHBIGNBFID == null || dDHBIGNBFID.AGHCOCAJMCI().FILHECEKNMK <= 0.01f)
		{
			return 0f;
		}
		BKCPOFBMCHJ bKCPOFBMCHJ = HNGIHNOCCKJ.APLMLICAINE(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD());
		if (bKCPOFBMCHJ == null)
		{
			return 1f;
		}
		return bKCPOFBMCHJ.BCIGNMAEOPL();
	}

	public DDHBIGNBFID FNKHBCDNCLL(ushort CDLJHFICDDI)
	{
		for (int i = 0; i < FBNCCAOBAOG().Count; i++)
		{
			DDHBIGNBFID dDHBIGNBFID = BHFIOMJAFBC()[i];
			if (dDHBIGNBFID != null && (ushort)dDHBIGNBFID.AGHCOCAJMCI().HBNJODMNFPM() == CDLJHFICDDI)
			{
				return dDHBIGNBFID;
			}
		}
		return null;
	}

	public KMNJPNBJACF(Actor CDKMPAEODLA)
	{
		MEDAGKOPJMO = CDKMPAEODLA;
		LKBOJCKEMOO(new List<DDHBIGNBFID>(PhoneLOLModeRules.ItemSlots));
		for (int i = 0; i < PhoneLOLModeRules.ItemSlots; i++)
		{
			BHFIOMJAFBC().Add(null);
		}
		HNGIHNOCCKJ = new DPIEILDFMJK();
	}

	public int FFPFLLKFDJA(ushort OIANGIEMBPM)
	{
		for (int i = 0; i < BHFIOMJAFBC().Count; i++)
		{
			DDHBIGNBFID dDHBIGNBFID = BHFIOMJAFBC()[i];
			if (dDHBIGNBFID != null && (ushort)dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD() == OIANGIEMBPM)
			{
				return i;
			}
		}
		return -1;
	}

	public bool OPDJKDJPNDN(byte LEOCLKHBLED)
	{
		DDHBIGNBFID dDHBIGNBFID = FPICNOOFDOA(LEOCLKHBLED);
		if (dDHBIGNBFID == null || !dDHBIGNBFID.AGHCOCAJMCI().POLDNPKBGIH())
		{
			return false;
		}
		if (MEDAGKOPJMO == null || !MEDAGKOPJMO.IsLive())
		{
			return false;
		}
		if (!MEDAGKOPJMO.get_m_view().IsMine())
		{
			return false;
		}
		switch (dDHBIGNBFID.AGHCOCAJMCI().ONJCKKLOJIA())
		{
		case PKCGCIEPDEM.ACPICCBBPHF.Active:
			if (DJCDLKEJILF(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD()))
			{
				HNGIHNOCCKJ.NEOMOBIMGFF(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD());
				MJEJGLLJEGD(LEOCLKHBLED, dDHBIGNBFID);
			}
			break;
		case PKCGCIEPDEM.ACPICCBBPHF.Consume:
			if (DJCDLKEJILF(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD()) && NNECHJPELNH(LEOCLKHBLED, 1))
			{
				HNGIHNOCCKJ.NEOMOBIMGFF(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD());
				MJEJGLLJEGD(LEOCLKHBLED, dDHBIGNBFID);
			}
			break;
		case PKCGCIEPDEM.ACPICCBBPHF.ChargeConsume:
			if (DJCDLKEJILF(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD()) && dDHBIGNBFID.FEIPBCECGMO(1))
			{
				HNGIHNOCCKJ.NEOMOBIMGFF(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD());
				MJEJGLLJEGD(LEOCLKHBLED, dDHBIGNBFID);
			}
			break;
		}
		return false;
	}

	public int HLHNKLIKFKP(ushort CDLJHFICDDI, int AGJJOHLCJKF)
	{
		DDHBIGNBFID dDHBIGNBFID = FNKHBCDNCLL(CDLJHFICDDI);
		if (dDHBIGNBFID == null)
		{
			return 0;
		}
		if ((int)dDHBIGNBFID.HENGMGCOBCP() < AGJJOHLCJKF)
		{
			return 2;
		}
		return 1;
	}

	public bool EFKOCBLNIHA(ushort OIANGIEMBPM)
	{
		if (HNGIHNOCCKJ.MFKJMIPPIDB(OIANGIEMBPM) && HNGIHNOCCKJ.NEOMOBIMGFF(OIANGIEMBPM))
		{
			return true;
		}
		return false;
	}

	public bool DMPBAMAKICO(ushort CDLJHFICDDI)
	{
		DDHBIGNBFID dDHBIGNBFID = HFIPKEOBOPK(CDLJHFICDDI);
		if (dDHBIGNBFID == null)
		{
			return false;
		}
		if (!dDHBIGNBFID.AGHCOCAJMCI().CIGEEDBPDDM)
		{
			return false;
		}
		return true;
	}

	public DDHBIGNBFID FPICNOOFDOA(int LEOCLKHBLED)
	{
		return BHFIOMJAFBC()[LEOCLKHBLED];
	}

	public void EMBOAOKJINO(ushort OIANGIEMBPM, float ICENKPDOHBK)
	{
		DDHBIGNBFID dDHBIGNBFID = HFIPKEOBOPK(OIANGIEMBPM);
		if (dDHBIGNBFID != null)
		{
			BKCPOFBMCHJ bKCPOFBMCHJ = HNGIHNOCCKJ.APLMLICAINE(OIANGIEMBPM);
			if (bKCPOFBMCHJ != null)
			{
				bKCPOFBMCHJ.DKLODFGAOPF(ICENKPDOHBK);
			}
		}
	}

	public void LPBLGFCPADD(float DMLKFKGBHKJ)
	{
		HNGIHNOCCKJ.LPBLGFCPADD(DMLKFKGBHKJ);
	}

	protected void LKBOJCKEMOO(List<DDHBIGNBFID> ICENKPDOHBK)
	{
		PJKMJEJMHPO = ICENKPDOHBK;
	}

	public void GJPFIPICBAM(KCIGFAHFHCH OGJFDNEEDCP)
	{
		for (int i = 0; i < BHFIOMJAFBC().Count; i++)
		{
			bool ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			if (ICENKPDOHBK)
			{
				BHFIOMJAFBC()[i] = new DDHBIGNBFID();
				BHFIOMJAFBC()[i].GJPFIPICBAM(OGJFDNEEDCP);
			}
			else
			{
				BHFIOMJAFBC()[i] = null;
			}
		}
		HNGIHNOCCKJ.GJPFIPICBAM(OGJFDNEEDCP);
	}

	[SpecialName]
	protected void ENNCMBOKKMF(List<DDHBIGNBFID> ICENKPDOHBK)
	{
		PJKMJEJMHPO = ICENKPDOHBK;
	}

	public int DGLMPNDAAEL()
	{
		int num = 0;
		for (int i = 0; i < BHFIOMJAFBC().Count; i++)
		{
			DDHBIGNBFID dDHBIGNBFID = BHFIOMJAFBC()[i];
			if (dDHBIGNBFID != null)
			{
				num += dDHBIGNBFID.AGHCOCAJMCI().MGGCDFHFMKK;
			}
		}
		return num;
	}

	public bool BKHEPGHFJAO(int LEOCLKHBLED, int AGJJOHLCJKF)
	{
		DDHBIGNBFID dDHBIGNBFID = FPICNOOFDOA(LEOCLKHBLED);
		if (dDHBIGNBFID == null)
		{
			return false;
		}
		if (dDHBIGNBFID.AGHCOCAJMCI().ONJCKKLOJIA() == (PKCGCIEPDEM.ACPICCBBPHF)5)
		{
			BHFIOMJAFBC()[LEOCLKHBLED] = null;
		}
		else
		{
			if ((int)dDHBIGNBFID.HENGMGCOBCP() < AGJJOHLCJKF)
			{
				return true;
			}
			if ((int)dDHBIGNBFID.HENGMGCOBCP() == AGJJOHLCJKF)
			{
				BHFIOMJAFBC()[LEOCLKHBLED] = null;
			}
			else
			{
				dDHBIGNBFID.FEIPBCECGMO(AGJJOHLCJKF);
			}
		}
		return false;
	}

	public bool GCLDCBGGNIK(ushort CDLJHFICDDI)
	{
		DDHBIGNBFID dDHBIGNBFID = FNKHBCDNCLL(CDLJHFICDDI);
		if (dDHBIGNBFID == null)
		{
			return false;
		}
		if (!dDHBIGNBFID.FHPMONKJDEL().CIGEEDBPDDM)
		{
			return false;
		}
		return false;
	}

	public bool KOBLEIOLJPL(ushort CDLJHFICDDI)
	{
		DDHBIGNBFID dDHBIGNBFID = HFIPKEOBOPK(CDLJHFICDDI);
		if (dDHBIGNBFID == null)
		{
			return false;
		}
		if (!dDHBIGNBFID.AGHCOCAJMCI().CIGEEDBPDDM)
		{
			return false;
		}
		return true;
	}

	public int MBCEBKJDEAK(ushort CDLJHFICDDI, int AGJJOHLCJKF)
	{
		DDHBIGNBFID dDHBIGNBFID = HFIPKEOBOPK(CDLJHFICDDI);
		if (dDHBIGNBFID == null)
		{
			return 1;
		}
		if ((int)dDHBIGNBFID.HENGMGCOBCP() < AGJJOHLCJKF)
		{
			return 2;
		}
		return 0;
	}

	public void DLMNENJNMII(KCIGFAHFHCH OGJFDNEEDCP)
	{
		byte ICENKPDOHBK;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
		ushort ICENKPDOHBK2;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
		GJPFIPICBAM(OGJFDNEEDCP);
		switch (ICENKPDOHBK2)
		{
		case 1101:
		{
			int ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			EveView eveView2 = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK3);
			if (eveView2 == null)
			{
				return;
			}
			Actor component2 = eveView2.GetComponent<Actor>();
			if (component2 == null || component2.IsDeath())
			{
				return;
			}
			component2.OnDamage(MEDAGKOPJMO, 0.0, 100.0, 0.0, 2);
			component2.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, MEDAGKOPJMO, 3f, 0.25f);
			component2.CreateParticle("Particle/Item/item1101_hit", true);
			break;
		}
		case 1109:
		{
			ushort num = OGJFDNEEDCP.AJPFAAFLHEB();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				int kPNEBLJJGEA = OGJFDNEEDCP.PNBKOPGIHDI();
				EveView eveView3 = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(kPNEBLJJGEA);
				if (!(eveView3 == null))
				{
					Actor component3 = eveView3.GetComponent<Actor>();
					if (!(component3 == null) && !component3.IsDeath())
					{
						component3.OnDamage(MEDAGKOPJMO, 0.0, 120.0, 0.0, 2);
						component3.CreateParticle("Particle/Item/item1109_hit", false);
					}
				}
			}
			MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("item_1109_hit");
			break;
		}
		case 3110:
		{
			float ICENKPDOHBK4;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK4);
			MEDAGKOPJMO.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Shield, null, 1.5f, ICENKPDOHBK4);
			break;
		}
		case 6103:
		{
			List<int> list = new List<int>();
			OGJFDNEEDCP.CAHACMKBJMI(list);
			foreach (int item in list)
			{
				EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(item);
				if (!(eveView == null))
				{
					Actor component = eveView.GetComponent<Actor>();
					if (!(component == null) && !component.IsDeath())
					{
						component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, MEDAGKOPJMO, 4f, 0.35f);
					}
				}
			}
			MEDAGKOPJMO.CreateParticle("Particle/Item/item6103", false);
			break;
		}
		case 9001:
			MEDAGKOPJMO.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.HpPotion);
			break;
		}
		MEDAGKOPJMO.m_multiSound.LKLFMNKDLHJ("item_use");
	}

	private bool DJCDLKEJILF(ushort OIANGIEMBPM)
	{
		if (!HNGIHNOCCKJ.MFKJMIPPIDB(OIANGIEMBPM))
		{
			return false;
		}
		ushort num = OIANGIEMBPM;
		if (num == 1101)
		{
			JADCELJNDHB = ActorManager.get_Instance().GetActorInAttackRange(MEDAGKOPJMO, 5.5f, 90f, false, true, Actor.IJJMDPGJAEM.Hero);
			if (JADCELJNDHB == null)
			{
				JADCELJNDHB = ActorManager.get_Instance().GetActorInAttackRange(MEDAGKOPJMO, 5.5f, 90f, false, true, Actor.IJJMDPGJAEM.Monster);
			}
			if (JADCELJNDHB == null)
			{
				MsgManager.get_Instance().ShowTip("정면 근처에 적 챔피언이 없습니다");
				return false;
			}
		}
		return true;
	}

	public bool EHPANPJCEHM(ushort OIANGIEMBPM, int HMOOBMDKIAN)
	{
		KCIGFAHFHCH kCIGFAHFHCH = new KCIGFAHFHCH(512);
		kCIGFAHFHCH.GBMJNFOEACC((HMOOBMDKIAN << 16) | OIANGIEMBPM);
		DIHFDDPPCDL(kCIGFAHFHCH);
		return true;
	}

	public bool PGNKPIFFMJE(ushort OIANGIEMBPM, int AGJJOHLCJKF)
	{
		if (OIANGIEMBPM == 0)
		{
			return false;
		}
		PKCGCIEPDEM pKCGCIEPDEM = KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().FPICNOOFDOA(OIANGIEMBPM);
		if (pKCGCIEPDEM == null)
		{
			return false;
		}
		if (pKCGCIEPDEM.FILHECEKNMK >= 0.001f || pKCGCIEPDEM.AMENIOICKGM > 0f)
		{
			HNGIHNOCCKJ.PGNKPIFFMJE(OIANGIEMBPM);
		}
		DDHBIGNBFID dDHBIGNBFID = HFIPKEOBOPK(OIANGIEMBPM);
		if (dDHBIGNBFID != null && !(PhoneLOLModeRules.Enabled && dDHBIGNBFID.AGHCOCAJMCI().CIGEEDBPDDM))
		{
			if (dDHBIGNBFID.AGHCOCAJMCI().ONJCKKLOJIA() != PKCGCIEPDEM.ACPICCBBPHF.ChargeConsume && dDHBIGNBFID.PEIIGDBFGMK(AGJJOHLCJKF))
			{
				return true;
			}
			if (dDHBIGNBFID.AGHCOCAJMCI().CIGEEDBPDDM)
			{
				return false;
			}
		}
		int num = FHLMNBLCMEP();
		if (num < 0)
		{
			return false;
		}
		if (pKCGCIEPDEM.ONJCKKLOJIA() == PKCGCIEPDEM.ACPICCBBPHF.ChargeConsume)
		{
			AGJJOHLCJKF = pKCGCIEPDEM.OMPBNLBKLIM;
		}
		BHFIOMJAFBC()[num] = new DDHBIGNBFID(pKCGCIEPDEM, AGJJOHLCJKF);
		return true;
	}

	public DDHBIGNBFID DDIBAIMBOGJ(int LEOCLKHBLED)
	{
		return FBNCCAOBAOG()[LEOCLKHBLED];
	}

	public DDHBIGNBFID HFIPKEOBOPK(ushort CDLJHFICDDI)
	{
		for (int i = 0; i < BHFIOMJAFBC().Count; i++)
		{
			DDHBIGNBFID dDHBIGNBFID = BHFIOMJAFBC()[i];
			if (dDHBIGNBFID != null && (ushort)dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD() == CDLJHFICDDI)
			{
				return dDHBIGNBFID;
			}
		}
		return null;
	}

	public bool FLAGEFLCOGP(ushort OIANGIEMBPM, float HMOOBMDKIAN, Action<KCIGFAHFHCH> OHALCAOCHKB = null)
	{
		DDHBIGNBFID dDHBIGNBFID = HFIPKEOBOPK(OIANGIEMBPM);
		if (dDHBIGNBFID == null || dDHBIGNBFID.AGHCOCAJMCI().AMENIOICKGM <= 0f)
		{
			return false;
		}
		if (MEDAGKOPJMO == null)
		{
			return false;
		}
		if (!MEDAGKOPJMO.get_m_view().IsMine())
		{
			return false;
		}
		int num = FFPFLLKFDJA(OIANGIEMBPM);
		if (num < 0)
		{
			return false;
		}
		if (DKMJFJJDGNA(OIANGIEMBPM, HMOOBMDKIAN))
		{
			MJEJGLLJEGD((byte)num, dDHBIGNBFID, OHALCAOCHKB);
			return true;
		}
		return false;
	}

	public bool MHPDADHKGOJ(byte LEOCLKHBLED)
	{
		DDHBIGNBFID dDHBIGNBFID = FPICNOOFDOA(LEOCLKHBLED);
		if (dDHBIGNBFID == null || !dDHBIGNBFID.AGHCOCAJMCI().POLDNPKBGIH())
		{
			return true;
		}
		if (MEDAGKOPJMO == null || !MEDAGKOPJMO.IsLive())
		{
			return true;
		}
		if (!MEDAGKOPJMO.get_m_view().IsMine())
		{
			return true;
		}
		switch (dDHBIGNBFID.FHPMONKJDEL().EBHAKAADLEK())
		{
		case PKCGCIEPDEM.ACPICCBBPHF.Equip:
			if (DJCDLKEJILF(dDHBIGNBFID.FHPMONKJDEL().EHFEEIJKJHD()))
			{
				HNGIHNOCCKJ.PHPMLGCHNCA(dDHBIGNBFID.FHPMONKJDEL().HBNJODMNFPM());
				MJEJGLLJEGD(LEOCLKHBLED, dDHBIGNBFID);
			}
			break;
		case PKCGCIEPDEM.ACPICCBBPHF.Active:
			if (DJCDLKEJILF(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD()) && BKHEPGHFJAO(LEOCLKHBLED, 1))
			{
				HNGIHNOCCKJ.NEOMOBIMGFF(dDHBIGNBFID.AGHCOCAJMCI().HBNJODMNFPM());
				MJEJGLLJEGD(LEOCLKHBLED, dDHBIGNBFID);
			}
			break;
		case PKCGCIEPDEM.ACPICCBBPHF.Consume:
			if (DJCDLKEJILF(dDHBIGNBFID.AGHCOCAJMCI().HBNJODMNFPM()) && dDHBIGNBFID.OIPDOPNEDGI(0))
			{
				HNGIHNOCCKJ.NEOMOBIMGFF(dDHBIGNBFID.AGHCOCAJMCI().HBNJODMNFPM());
				MJEJGLLJEGD(LEOCLKHBLED, dDHBIGNBFID);
			}
			break;
		}
		return true;
	}

	public List<DDHBIGNBFID> BLEAFNOADMK()
	{
		return new List<DDHBIGNBFID>(FBNCCAOBAOG());
	}

	public bool BKHADCMOLJO(ushort OIANGIEMBPM, float HMOOBMDKIAN)
	{
		if (HNGIHNOCCKJ.CMKNMGLCEGA(OIANGIEMBPM, HMOOBMDKIAN) && HNGIHNOCCKJ.EIIPBMOPABC(OIANGIEMBPM, HMOOBMDKIAN))
		{
			return false;
		}
		return true;
	}

	public List<DDHBIGNBFID> HLEOBKFMENK()
	{
		return new List<DDHBIGNBFID>(FBNCCAOBAOG());
	}

	public int OAHFGIGJHHC()
	{
		return BHFIOMJAFBC().Count;
	}

	public bool DKMJFJJDGNA(ushort OIANGIEMBPM, float HMOOBMDKIAN)
	{
		if (HNGIHNOCCKJ.DEOEGIIHNPP(OIANGIEMBPM, HMOOBMDKIAN) && HNGIHNOCCKJ.EIIPBMOPABC(OIANGIEMBPM, HMOOBMDKIAN))
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public List<DDHBIGNBFID> FBNCCAOBAOG()
	{
		return PJKMJEJMHPO;
	}

	public void DIHFDDPPCDL(KCIGFAHFHCH OGJFDNEEDCP)
	{
	}

	public List<DDHBIGNBFID> PGGCPABCIHG()
	{
		return new List<DDHBIGNBFID>(BHFIOMJAFBC());
	}

	public int FHLMNBLCMEP()
	{
		for (int i = 0; i < BHFIOMJAFBC().Count; i++)
		{
			DDHBIGNBFID dDHBIGNBFID = BHFIOMJAFBC()[i];
			if (dDHBIGNBFID == null)
			{
				return i;
			}
		}
		return -1;
	}

	public bool NNECHJPELNH(int LEOCLKHBLED, int AGJJOHLCJKF)
	{
		DDHBIGNBFID dDHBIGNBFID = FPICNOOFDOA(LEOCLKHBLED);
		if (dDHBIGNBFID == null)
		{
			return false;
		}
		if (dDHBIGNBFID.AGHCOCAJMCI().ONJCKKLOJIA() == PKCGCIEPDEM.ACPICCBBPHF.ChargeConsume)
		{
			BHFIOMJAFBC()[LEOCLKHBLED] = null;
		}
		else
		{
			if ((int)dDHBIGNBFID.HENGMGCOBCP() < AGJJOHLCJKF)
			{
				return false;
			}
			if ((int)dDHBIGNBFID.HENGMGCOBCP() == AGJJOHLCJKF)
			{
				BHFIOMJAFBC()[LEOCLKHBLED] = null;
			}
			else
			{
				dDHBIGNBFID.FEIPBCECGMO(AGJJOHLCJKF);
			}
		}
		return true;
	}

	public int FKCOABKJIFB()
	{
		int num = 1;
		for (int i = 0; i < BHFIOMJAFBC().Count; i += 0)
		{
			DDHBIGNBFID dDHBIGNBFID = BHFIOMJAFBC()[i];
			if (dDHBIGNBFID != null)
			{
				num += dDHBIGNBFID.FHPMONKJDEL().MGGCDFHFMKK;
			}
		}
		return num;
	}

	public List<DDHBIGNBFID> HNLPEDLGDJD()
	{
		return new List<DDHBIGNBFID>(BHFIOMJAFBC());
	}

	public float IAGCIMKDNGG(int LEOCLKHBLED)
	{
		DDHBIGNBFID dDHBIGNBFID = FPICNOOFDOA(LEOCLKHBLED);
		if (dDHBIGNBFID == null || dDHBIGNBFID.AGHCOCAJMCI().AMENIOICKGM <= 0.01f)
		{
			return 0f;
		}
		BKCPOFBMCHJ bKCPOFBMCHJ = HNGIHNOCCKJ.APLMLICAINE(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD());
		if (bKCPOFBMCHJ == null)
		{
			return 0f;
		}
		return bKCPOFBMCHJ.IAGCIMKDNGG();
	}

	public void LDNEFFHJNPL()
	{
		for (int i = 0; i < BHFIOMJAFBC().Count; i++)
		{
			BHFIOMJAFBC()[i] = null;
		}
	}

	public void JBLLGJEAJJM(KCIGFAHFHCH OGJFDNEEDCP)
	{
		for (int i = 1; i < 8; i++)
		{
			bool ICENKPDOHBK;
			OGJFDNEEDCP.BNLCLGMMAPD(out ICENKPDOHBK);
			if (ICENKPDOHBK)
			{
				FBNCCAOBAOG()[i] = new DDHBIGNBFID();
				BHFIOMJAFBC()[i].GJPFIPICBAM(OGJFDNEEDCP);
			}
			else
			{
				FBNCCAOBAOG()[i] = null;
			}
		}
		HNGIHNOCCKJ.JJJOLOBPHDC(OGJFDNEEDCP);
	}
}
