using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EveEngine
{
	public class KJGALEFHHOA : IDisposable
	{
		private EKACODPEIIO KLBIKHEFDHH;

		private Socket GOOMHBJNFKC;

		private IPEndPoint FLILLEDKKJB;

		private bool APEJFABHJDF;

		private bool KKKNDCBEPEF;

		private float ODMDLAIDNHK;

		private float KIBFBGJOIPG;

		private float PMFJPPIBHIA;

		private float CILIIANOEAL;

		private bool LGKJFHMCJOK;

		private LHOLJMEKHBF FOCHEKNBHCA;

		private byte[] KCOCDEHJKDI;

		private IPEndPoint AGIFNOKEDFC;

		private PJEMPFEIOAK GKHKNBMDHLG;

		private IPEndPoint ENAMEHKGJIB;

		private float GHOOCNKOOMH;

		private long GADFNCHDCON;

		private long JLCKDADEJFJ;

		private long NFEPJAFIJDG;

		private long ANLHDMJKKGN;

		public IPEndPoint ICMIKELNDOE
		{
			get
			{
				return JKFABOIKDIH();
			}
			protected set
			{
				GNAJMFIBCOD(value);
			}
		}

		public float CPJDGIPNPIB
		{
			get
			{
				return EJNOJPCPLEB();
			}
			protected set
			{
				LAMMAAFNCDC(value);
			}
		}

		public long JBOGGGCEIIL
		{
			get
			{
				return AHENPLPJMIO();
			}
			protected set
			{
				KNIGJJCMMDB(value);
			}
		}

		public long KCIFANMMLBB
		{
			get
			{
				return HBDONGPNKFP();
			}
			protected set
			{
				GAGPEPNEECJ(value);
			}
		}

		public long BMMNCFPHLPH
		{
			get
			{
				return CPIOCIKCKHM();
			}
			protected set
			{
				KBDPNBBKPOF(value);
			}
		}

		public long IGHJKMKFLOD
		{
			get
			{
				return OCLIFEKNCEO();
			}
			protected set
			{
				DFFMMLNGKNF(value);
			}
		}

		[SpecialName]
		protected void FDHCDEOGFII(long ICENKPDOHBK)
		{
			GADFNCHDCON = ICENKPDOHBK;
		}

		protected void LAMMAAFNCDC(float ICENKPDOHBK)
		{
			GHOOCNKOOMH = ICENKPDOHBK;
		}

		public long CPIOCIKCKHM()
		{
			return NFEPJAFIJDG;
		}

		[SpecialName]
		public long MKFHPNHEABE()
		{
			return GADFNCHDCON;
		}

		public void Dispose()
		{
			JDBENBMLFNP(true);
		}

		public long OCLIFEKNCEO()
		{
			return ANLHDMJKKGN;
		}

		public IPEndPoint JKFABOIKDIH()
		{
			return ENAMEHKGJIB;
		}

		public void FBAFKOCPFPG(CMNIABEFLBJ EFDLFNPAKGO, bool FIPPPHACEPC, ABBLIOLAABC FGJKPJLFOBD)
		{
			FBAFKOCPFPG(EFDLFNPAKGO, FIPPPHACEPC, false, false, FGJKPJLFOBD.BIPMNCGGIJF());
		}

		public void BAIHBPKGHEJ(int NECJILEFBAO, LHOLJMEKHBF KFBEDDIHEIB)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(60013);
			cMNIABEFLBJ.GBMJNFOEACC(NECJILEFBAO);
			cMNIABEFLBJ.GBMJNFOEACC(KLBIKHEFDHH.NCHJJNGPOPA());
			cMNIABEFLBJ.GBMJNFOEACC(KFBEDDIHEIB.NCHJJNGPOPA());
			if (KFBEDDIHEIB.PMLLFPODCGE())
			{
				cMNIABEFLBJ.GBMJNFOEACC(false);
			}
			else
			{
				cMNIABEFLBJ.GBMJNFOEACC(true);
			}
			IPEndPoint iPEndPoint = null;
			if (KFBEDDIHEIB.EINBHIEBMEA < 15)
			{
				iPEndPoint = ((KFBEDDIHEIB.EINBHIEBMEA % 3 == 0) ? KFBEDDIHEIB.BHNAFPLHPHH() : ((KFBEDDIHEIB.EINBHIEBMEA % 3 != 1) ? KFBEDDIHEIB.AMFDFEKGNJH() : KFBEDDIHEIB.HENPNJFHBAC()));
			}
			else
			{
				int num = KFBEDDIHEIB.BHNAFPLHPHH().Port + (KFBEDDIHEIB.EINBHIEBMEA - 14);
				if (num >= 1 && num <= 65535)
				{
					iPEndPoint = new IPEndPoint(KFBEDDIHEIB.BHNAFPLHPHH().Address, num);
				}
			}
			KFBEDDIHEIB.EINBHIEBMEA++;
			cMNIABEFLBJ.GBMJNFOEACC(iPEndPoint);
			cMNIABEFLBJ.ILIGMIAKIIA(0);
			cMNIABEFLBJ.JBLBKKGPGOK(KLBIKHEFDHH.NCHJJNGPOPA());
			cMNIABEFLBJ.BCKCJLNLABI(false);
			FBAFKOCPFPG(cMNIABEFLBJ.EIMBOIKCJPE(), cMNIABEFLBJ.EJGJCLHFIAM(), iPEndPoint);
			cMNIABEFLBJ.CDPNLMMNNBD();
			if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Full)
			{
				Debug.Log(string.Format("SendHolePunching {0} {1}", NECJILEFBAO, KFBEDDIHEIB.NCHJJNGPOPA()));
			}
		}

		public float EJNOJPCPLEB()
		{
			return GHOOCNKOOMH;
		}

		private void MLPAJJDMMKJ(PJEMPFEIOAK HMOAHNANKNE, IPEndPoint HGLJLELKDLE)
		{
			if (!KKKNDCBEPEF)
			{
				return;
			}
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			bool flag = HMOAHNANKNE.JCGKFEPEJPO();
			IPEndPoint iPEndPoint = HMOAHNANKNE.KJFAHHKIGAJ();
			ABBLIOLAABC aBBLIOLAABC = KLBIKHEFDHH.PPIFDHBBEPM().KBLCDMPGOMM(num);
			if (aBBLIOLAABC == null)
			{
				return;
			}
			if (KLBIKHEFDHH.NCHJJNGPOPA() == num2)
			{
				LHOLJMEKHBF lHOLJMEKHBF = aBBLIOLAABC.KBLCDMPGOMM(num3);
				if (lHOLJMEKHBF != null)
				{
					lHOLJMEKHBF.LBMGLBHNFFE(iPEndPoint);
					lHOLJMEKHBF.ADLHDGCJJOI(HGLJLELKDLE);
					lHOLJMEKHBF.AJJGLNHAPPF(LHOLJMEKHBF.OEOIIKMBGAG.BothConnected);
					if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Full)
					{
						Debug.Log(string.Format("P2P Connected {0} to {1}", num2, num3));
					}
				}
				return;
			}
			LHOLJMEKHBF lHOLJMEKHBF2 = aBBLIOLAABC.KBLCDMPGOMM(num2);
			if (lHOLJMEKHBF2 != null)
			{
				lHOLJMEKHBF2.ADLHDGCJJOI(HGLJLELKDLE);
				CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
				cMNIABEFLBJ.DGFDHOLDCDL(60013);
				cMNIABEFLBJ.GBMJNFOEACC(num);
				cMNIABEFLBJ.GBMJNFOEACC(num2);
				cMNIABEFLBJ.GBMJNFOEACC(num3);
				cMNIABEFLBJ.GBMJNFOEACC(flag);
				cMNIABEFLBJ.GBMJNFOEACC(iPEndPoint);
				FBAFKOCPFPG(cMNIABEFLBJ, false, lHOLJMEKHBF2);
				if (flag)
				{
					CMNIABEFLBJ cMNIABEFLBJ2 = CMNIABEFLBJ.PEFJOMFAOJI();
					cMNIABEFLBJ2.DGFDHOLDCDL(60008);
					cMNIABEFLBJ2.GBMJNFOEACC(num);
					cMNIABEFLBJ2.GBMJNFOEACC(num2);
					cMNIABEFLBJ2.GBMJNFOEACC(num3);
					cMNIABEFLBJ2.GBMJNFOEACC(iPEndPoint);
					KLBIKHEFDHH.FBAFKOCPFPG(cMNIABEFLBJ2);
				}
			}
		}

		public void ACBMFJIILGF()
		{
			KKKNDCBEPEF = false;
			APEJFABHJDF = false;
		}

		protected void GAGPEPNEECJ(long ICENKPDOHBK)
		{
			JLCKDADEJFJ = ICENKPDOHBK;
		}

		public int FBAFKOCPFPG(CMNIABEFLBJ EFDLFNPAKGO, IPEndPoint HGLJLELKDLE)
		{
			KBDPNBBKPOF(CPIOCIKCKHM() + 1);
			DFFMMLNGKNF(OCLIFEKNCEO() + (EFDLFNPAKGO.EJGJCLHFIAM() + 8));
			EFDLFNPAKGO.JBLBKKGPGOK(KLBIKHEFDHH.NCHJJNGPOPA());
			EFDLFNPAKGO.BCKCJLNLABI(false);
			try
			{
				return FBAFKOCPFPG(EFDLFNPAKGO.EIMBOIKCJPE(), EFDLFNPAKGO.EJGJCLHFIAM(), HGLJLELKDLE);
			}
			catch
			{
			}
			return 0;
		}

		internal void LCOAOJNHOJJ(int FDEJBCNGOEG, LinkedList<PFPNBBFDKMD> KEEMMDMLLIN)
		{
			FOCHEKNBHCA.AAGKKFOEIAN(FDEJBCNGOEG, KEEMMDMLLIN);
		}

		protected void KNIGJJCMMDB(long ICENKPDOHBK)
		{
			GADFNCHDCON = ICENKPDOHBK;
		}

		public void MFOBPBIMKMC(CMNIABEFLBJ EFDLFNPAKGO, bool FIPPPHACEPC, LHOLJMEKHBF CKDEFLBOGDM)
		{
			if (FIPPPHACEPC)
			{
				bool flag = CKDEFLBOGDM.EGOBJKNFHHN(EFDLFNPAKGO, KLBIKHEFDHH.NCHJJNGPOPA());
				KBDPNBBKPOF(CPIOCIKCKHM() + 1);
				DFFMMLNGKNF(OCLIFEKNCEO() + (EFDLFNPAKGO.EJGJCLHFIAM() + 2));
				CKDEFLBOGDM.PMFAPJGPCGN(DateTime.Now.Ticks);
				if (flag && GOOMHBJNFKC != null)
				{
					CKDEFLBOGDM.HMMPLCGDGOF(this, EFDLFNPAKGO.EIMBOIKCJPE(), EFDLFNPAKGO.EJGJCLHFIAM());
				}
				return;
			}
			EFDLFNPAKGO.ILIGMIAKIIA(0);
			EFDLFNPAKGO.JBLBKKGPGOK(KLBIKHEFDHH.NCHJJNGPOPA());
			EFDLFNPAKGO.BCKCJLNLABI();
			KBDPNBBKPOF(CPIOCIKCKHM() + 0);
			DFFMMLNGKNF(OCLIFEKNCEO() + (EFDLFNPAKGO.EJGJCLHFIAM() + 3));
			if (GOOMHBJNFKC != null)
			{
				CKDEFLBOGDM.HMMPLCGDGOF(this, EFDLFNPAKGO.EIMBOIKCJPE(), EFDLFNPAKGO.EJGJCLHFIAM());
			}
			EFDLFNPAKGO.CDPNLMMNNBD();
		}

		private void CBPFAIFIJLN(PJEMPFEIOAK HMOAHNANKNE, IPEndPoint HGLJLELKDLE)
		{
			if (!KKKNDCBEPEF)
			{
				long num = HMOAHNANKNE.GAGNPBAMJLE();
				GNAJMFIBCOD(HMOAHNANKNE.KJFAHHKIGAJ());
				long ticks = DateTime.Now.Ticks - num;
				LAMMAAFNCDC((float)(new TimeSpan(ticks).TotalSeconds * 0.5));
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Informational)
				{
					Debug.Log(string.Format("Local EndPoint {0}", PBMGEMIBOCF()));
				}
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Full)
				{
					Debug.Log(string.Format("OnAuth {0}", FLILLEDKKJB));
				}
				KKKNDCBEPEF = true;
				APEJFABHJDF = false;
				CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
				cMNIABEFLBJ.DGFDHOLDCDL(60002);
				cMNIABEFLBJ.GBMJNFOEACC(PBMGEMIBOCF());
				cMNIABEFLBJ.GBMJNFOEACC(JKFABOIKDIH());
				KLBIKHEFDHH.FBAFKOCPFPG(cMNIABEFLBJ);
			}
		}

		private void EEKOHOGCJJF(PJEMPFEIOAK HMOAHNANKNE, IPEndPoint HGLJLELKDLE)
		{
			if (!KKKNDCBEPEF)
			{
				long num = HMOAHNANKNE.GAGNPBAMJLE();
				GNAJMFIBCOD(HMOAHNANKNE.KJFAHHKIGAJ());
				long ticks = DateTime.Now.Ticks - num;
				LAMMAAFNCDC((float)(new TimeSpan(ticks).TotalSeconds * 491.0));
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.ErrorsOnly)
				{
					Debug.Log(string.Format("FxmTestSingleMouse.m_fDistance", PBMGEMIBOCF()));
				}
				if (EveUnityNetwork.get_Instance().m_logLevel >= (EveUnityNetwork.IFLONDHKBBI)6)
				{
					Debug.Log(string.Format("skill1_loop", FLILLEDKKJB));
				}
				KKKNDCBEPEF = true;
				APEJFABHJDF = true;
				CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
				cMNIABEFLBJ.DGFDHOLDCDL(65365);
				cMNIABEFLBJ.GBMJNFOEACC(PBMGEMIBOCF());
				cMNIABEFLBJ.JPFOAAHOIBE(JKFABOIKDIH());
				KLBIKHEFDHH.FBAFKOCPFPG(cMNIABEFLBJ);
			}
		}

		public void LDNEFFHJNPL()
		{
			GOOMHBJNFKC = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			GOOMHBJNFKC.Blocking = false;
			GOOMHBJNFKC.SendBufferSize = 2000000;
			GOOMHBJNFKC.ReceiveBufferSize = 2000000;
			APEJFABHJDF = false;
		}

		public void FBAFKOCPFPG(CMNIABEFLBJ EFDLFNPAKGO, bool FIPPPHACEPC, LHOLJMEKHBF CKDEFLBOGDM)
		{
			if (FIPPPHACEPC)
			{
				bool flag = CKDEFLBOGDM.EGOBJKNFHHN(EFDLFNPAKGO, KLBIKHEFDHH.NCHJJNGPOPA());
				KBDPNBBKPOF(CPIOCIKCKHM() + 1);
				DFFMMLNGKNF(OCLIFEKNCEO() + (EFDLFNPAKGO.EJGJCLHFIAM() + 8));
				CKDEFLBOGDM.AFABDAHEAMK(DateTime.Now.Ticks);
				if (flag && GOOMHBJNFKC != null)
				{
					CKDEFLBOGDM.HMMPLCGDGOF(this, EFDLFNPAKGO.EIMBOIKCJPE(), EFDLFNPAKGO.EJGJCLHFIAM());
				}
				return;
			}
			EFDLFNPAKGO.ILIGMIAKIIA(0);
			EFDLFNPAKGO.JBLBKKGPGOK(KLBIKHEFDHH.NCHJJNGPOPA());
			EFDLFNPAKGO.BCKCJLNLABI(false);
			KBDPNBBKPOF(CPIOCIKCKHM() + 1);
			DFFMMLNGKNF(OCLIFEKNCEO() + (EFDLFNPAKGO.EJGJCLHFIAM() + 8));
			if (GOOMHBJNFKC != null)
			{
				CKDEFLBOGDM.HMMPLCGDGOF(this, EFDLFNPAKGO.EIMBOIKCJPE(), EFDLFNPAKGO.EJGJCLHFIAM());
			}
			EFDLFNPAKGO.CDPNLMMNNBD();
		}

		public KJGALEFHHOA(EKACODPEIIO FHALIMDOODA, IPEndPoint CNDLAKPDMPB)
		{
			KLBIKHEFDHH = FHALIMDOODA;
			KKKNDCBEPEF = false;
			LGKJFHMCJOK = false;
			ODMDLAIDNHK = 0.9f;
			KIBFBGJOIPG = 0f;
			PMFJPPIBHIA = 0f;
			CILIIANOEAL = 0f;
			FLILLEDKKJB = CNDLAKPDMPB;
			FOCHEKNBHCA = new LHOLJMEKHBF(KLBIKHEFDHH, null, 0);
			FOCHEKNBHCA.LBMGLBHNFFE(CNDLAKPDMPB);
			FOCHEKNBHCA.ADLHDGCJJOI(CNDLAKPDMPB);
			FOCHEKNBHCA.BDIMBPONFCP(CNDLAKPDMPB);
			KCOCDEHJKDI = new byte[16384];
			AGIFNOKEDFC = new IPEndPoint(IPAddress.Any, 0);
			GKHKNBMDHLG = new PJEMPFEIOAK(16384);
			GKHKNBMDHLG.IHGAIBPLLIC(16384);
		}

		public bool LPBLGFCPADD(float DMLKFKGBHKJ)
		{
			HECFOFBHFNE();
			if (APEJFABHJDF)
			{
				ODMDLAIDNHK += DMLKFKGBHKJ;
				if (ODMDLAIDNHK >= 1f)
				{
					ODMDLAIDNHK = 0f;
					CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
					cMNIABEFLBJ.DGFDHOLDCDL(60010);
					cMNIABEFLBJ.GBMJNFOEACC(DateTime.Now.Ticks);
					FBAFKOCPFPG(cMNIABEFLBJ, false, FOCHEKNBHCA);
				}
			}
			else
			{
				KIBFBGJOIPG += DMLKFKGBHKJ;
				if (KIBFBGJOIPG >= 5f)
				{
					KIBFBGJOIPG = 0f;
					CMNIABEFLBJ cMNIABEFLBJ2 = CMNIABEFLBJ.PEFJOMFAOJI();
					cMNIABEFLBJ2.DGFDHOLDCDL(60011);
					cMNIABEFLBJ2.GBMJNFOEACC(DateTime.Now.Ticks);
					cMNIABEFLBJ2.GBMJNFOEACC((ushort)(EJNOJPCPLEB() * 1000f));
					FBAFKOCPFPG(cMNIABEFLBJ2, false, FOCHEKNBHCA);
				}
			}
			PMFJPPIBHIA += DMLKFKGBHKJ;
			if (PMFJPPIBHIA >= 0.03f)
			{
				PMFJPPIBHIA = 0f;
				long ticks = DateTime.Now.Ticks;
				if (!FOCHEKNBHCA.AFABDAHEAMK(ticks))
				{
					return false;
				}
				KLBIKHEFDHH.PPIFDHBBEPM().AFABDAHEAMK(ticks);
			}
			return true;
		}

		internal void AAGKKFOEIAN(int FDEJBCNGOEG, LinkedList<PFPNBBFDKMD> KEEMMDMLLIN)
		{
			FOCHEKNBHCA.AAGKKFOEIAN(FDEJBCNGOEG, KEEMMDMLLIN);
		}

		public int FBAFKOCPFPG(byte[] EDMNHDBEPMC, int EOOFAKHOBPM, IPEndPoint HGLJLELKDLE)
		{
			if (EOOFAKHOBPM <= 0)
			{
				return 0;
			}
			try
			{
				GOOMHBJNFKC.SendTo(EDMNHDBEPMC, EOOFAKHOBPM, SocketFlags.None, HGLJLELKDLE);
			}
			catch
			{
			}
			return 0;
		}

		protected void GNAJMFIBCOD(IPEndPoint ICENKPDOHBK)
		{
			ENAMEHKGJIB = ICENKPDOHBK;
		}

		[SpecialName]
		protected void LNGKDDGHBLL(IPEndPoint ICENKPDOHBK)
		{
			ENAMEHKGJIB = ICENKPDOHBK;
		}

		public void CHPLAOFPDBD(int NECJILEFBAO, LHOLJMEKHBF KFBEDDIHEIB)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(60012);
			cMNIABEFLBJ.GBMJNFOEACC(NECJILEFBAO);
			cMNIABEFLBJ.GBMJNFOEACC(KLBIKHEFDHH.NCHJJNGPOPA());
			cMNIABEFLBJ.GBMJNFOEACC(KFBEDDIHEIB.NCHJJNGPOPA());
			cMNIABEFLBJ.GBMJNFOEACC(DateTime.Now.Ticks);
			FBAFKOCPFPG(cMNIABEFLBJ, false, KFBEDDIHEIB);
			if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Full)
			{
				Debug.Log(string.Format("SendP2PPing {0} {1}", NECJILEFBAO, KFBEDDIHEIB.NCHJJNGPOPA()));
			}
		}

		[CompilerGenerated]
		private void JHIMIJDGIHC(PJEMPFEIOAK EFDLFNPAKGO, IPEndPoint HENFLIGFHEO)
		{
			GINOEGAMKHO(EFDLFNPAKGO, HENFLIGFHEO);
		}

		public long HBDONGPNKFP()
		{
			return JLCKDADEJFJ;
		}

		public void FBAFKOCPFPG(CMNIABEFLBJ EFDLFNPAKGO, bool FIPPPHACEPC, bool DEIFJBHFIME, bool IKIPOIDHENP, ABBLIOLAABC FGJKPJLFOBD)
		{
			FBAFKOCPFPG(EFDLFNPAKGO, FIPPPHACEPC, DEIFJBHFIME, IKIPOIDHENP, FGJKPJLFOBD.BIPMNCGGIJF());
		}

		internal void HBKEFJINMJK(float DMLKFKGBHKJ)
		{
			CILIIANOEAL += DMLKFKGBHKJ;
			CILIIANOEAL = 0f;
			FOCHEKNBHCA.MPIBGMJJJOH(this);
			KLBIKHEFDHH.PPIFDHBBEPM().MPIBGMJJJOH(this);
		}

		private void GINOEGAMKHO(PJEMPFEIOAK HMOAHNANKNE, IPEndPoint HGLJLELKDLE)
		{
			if (HMOAHNANKNE.KCGNKBDGONC() >= 60000)
			{
				switch ((MGOCABFFMAG)HMOAHNANKNE.KCGNKBDGONC())
				{
				case MGOCABFFMAG.U_Auth:
					CBPFAIFIJLN(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_Ping:
					BGFAIGIBAMP(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_P2PPing:
					MJOFLMMMGJK(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_HolePunching:
					MLPAJJDMMKJ(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_SerializeView:
					KLBIKHEFDHH.AJJCIJFJDAJ(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_RPC:
					KLBIKHEFDHH.KIBGHKLBHOJ(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_Instantiate:
					KLBIKHEFDHH.GAGKHKEDJPE(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_Destroy:
					KLBIKHEFDHH.EMJOODMOIGA(HMOAHNANKNE, HGLJLELKDLE);
					break;
				case MGOCABFFMAG.U_Message:
					KLBIKHEFDHH.BPGDNOKCOKI(HMOAHNANKNE, HGLJLELKDLE);
					break;
				}
			}
			else
			{
				KLBIKHEFDHH.AHIMLKAFIIE(HMOAHNANKNE);
			}
		}

		public long AHENPLPJMIO()
		{
			return GADFNCHDCON;
		}

		public void FBAFKOCPFPG(CMNIABEFLBJ EFDLFNPAKGO, bool FIPPPHACEPC, bool DEIFJBHFIME, LHOLJMEKHBF CKDEFLBOGDM)
		{
			if (!DEIFJBHFIME && CKDEFLBOGDM.GMHFFJFKCGE())
			{
				EFDLFNPAKGO.CDPNLMMNNBD();
				return;
			}
			int cMGMOJAFLFL = EFDLFNPAKGO.EJGJCLHFIAM();
			if (!DEIFJBHFIME && CKDEFLBOGDM.FCACEHMGKHI())
			{
				FBAFKOCPFPG(EFDLFNPAKGO, FIPPPHACEPC, CKDEFLBOGDM);
				return;
			}
			EFDLFNPAKGO.KDOJNBAJJEO(cMGMOJAFLFL);
			EFDLFNPAKGO.GBMJNFOEACC(CKDEFLBOGDM.NCHJJNGPOPA());
			EFDLFNPAKGO.GBMJNFOEACC((byte)1);
			FBAFKOCPFPG(EFDLFNPAKGO, FIPPPHACEPC, FOCHEKNBHCA);
		}

		internal void HBIDGGIMLIN(float DMLKFKGBHKJ)
		{
			CILIIANOEAL += DMLKFKGBHKJ;
			CILIIANOEAL = 449f;
			FOCHEKNBHCA.LHMNNLHMDPI(this);
			KLBIKHEFDHH.PPIFDHBBEPM().MPIBGMJJJOH(this);
		}

		protected virtual void JDBENBMLFNP(bool BPCKECGFJPA)
		{
			LGKJFHMCJOK = true;
			if (BPCKECGFJPA && GOOMHBJNFKC != null)
			{
				try
				{
					GOOMHBJNFKC.Close();
				}
				catch
				{
				}
				GOOMHBJNFKC = null;
			}
		}

		public void FBAFKOCPFPG(CMNIABEFLBJ EFDLFNPAKGO, bool FIPPPHACEPC, bool DEIFJBHFIME, bool IKIPOIDHENP, IEnumerable<LHOLJMEKHBF> PECPCAIAPAK)
		{
			EFDLFNPAKGO.KDEDMHOLJPM();
			int num = EFDLFNPAKGO.EJGJCLHFIAM();
			int num2 = num;
			CMNIABEFLBJ cMNIABEFLBJ = EFDLFNPAKGO.HECAENAKOPA(false);
			cMNIABEFLBJ.KDOJNBAJJEO(num);
			byte b = 0;
			foreach (LHOLJMEKHBF item in PECPCAIAPAK)
			{
				if ((IKIPOIDHENP || !item.GMHFFJFKCGE()) && (DEIFJBHFIME || !item.FCACEHMGKHI()))
				{
					cMNIABEFLBJ.GBMJNFOEACC(item.NCHJJNGPOPA());
					b++;
					num2 += 4;
					if (b >= 100 || num2 >= 995)
					{
						cMNIABEFLBJ.GBMJNFOEACC(b);
						FBAFKOCPFPG(cMNIABEFLBJ, FIPPPHACEPC, FOCHEKNBHCA);
						cMNIABEFLBJ = EFDLFNPAKGO.HECAENAKOPA(false);
						cMNIABEFLBJ.KDOJNBAJJEO(num);
						b = 0;
						num2 = num;
					}
				}
			}
			if (b > 0)
			{
				cMNIABEFLBJ.GBMJNFOEACC(b);
				FBAFKOCPFPG(cMNIABEFLBJ, FIPPPHACEPC, FOCHEKNBHCA);
			}
			else
			{
				cMNIABEFLBJ.CDPNLMMNNBD();
			}
			if (!DEIFJBHFIME)
			{
				foreach (LHOLJMEKHBF item2 in PECPCAIAPAK)
				{
					if (!item2.GMHFFJFKCGE() && item2.FCACEHMGKHI())
					{
						CMNIABEFLBJ eFDLFNPAKGO = EFDLFNPAKGO.HECAENAKOPA(false);
						FBAFKOCPFPG(eFDLFNPAKGO, FIPPPHACEPC, item2);
					}
				}
			}
			EFDLFNPAKGO.CDPNLMMNNBD();
		}

		protected void DFFMMLNGKNF(long ICENKPDOHBK)
		{
			ANLHDMJKKGN = ICENKPDOHBK;
		}

		[SpecialName]
		protected void KPKCELBBGPP(long ICENKPDOHBK)
		{
			GADFNCHDCON = ICENKPDOHBK;
		}

		private void MJOFLMMMGJK(PJEMPFEIOAK HMOAHNANKNE, IPEndPoint HGLJLELKDLE)
		{
			if (!KKKNDCBEPEF)
			{
				return;
			}
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			long num4 = HMOAHNANKNE.GAGNPBAMJLE();
			ABBLIOLAABC aBBLIOLAABC = KLBIKHEFDHH.PPIFDHBBEPM().KBLCDMPGOMM(num);
			if (aBBLIOLAABC == null)
			{
				return;
			}
			if (KLBIKHEFDHH.NCHJJNGPOPA() == num2)
			{
				long ticks = DateTime.Now.Ticks - num4;
				LHOLJMEKHBF lHOLJMEKHBF = aBBLIOLAABC.KBLCDMPGOMM(num3);
				if (lHOLJMEKHBF != null)
				{
					lHOLJMEKHBF.ADLHDGCJJOI(HGLJLELKDLE);
					lHOLJMEKHBF.IPOKIMFNANH((float)(new TimeSpan(ticks).TotalSeconds * 0.5));
					lHOLJMEKHBF.AJJGLNHAPPF(LHOLJMEKHBF.OEOIIKMBGAG.BothConnected);
				}
				return;
			}
			LHOLJMEKHBF lHOLJMEKHBF2 = aBBLIOLAABC.KBLCDMPGOMM(num2);
			if (lHOLJMEKHBF2 != null)
			{
				lHOLJMEKHBF2.ADLHDGCJJOI(HGLJLELKDLE);
				CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
				cMNIABEFLBJ.DGFDHOLDCDL(60012);
				cMNIABEFLBJ.GBMJNFOEACC(num);
				cMNIABEFLBJ.GBMJNFOEACC(num2);
				cMNIABEFLBJ.GBMJNFOEACC(num3);
				cMNIABEFLBJ.GBMJNFOEACC(num4);
				FBAFKOCPFPG(cMNIABEFLBJ, false, lHOLJMEKHBF2);
			}
		}

		private void BGFAIGIBAMP(PJEMPFEIOAK HMOAHNANKNE, IPEndPoint HGLJLELKDLE)
		{
			if (KKKNDCBEPEF)
			{
				long num = HMOAHNANKNE.GAGNPBAMJLE();
				if (HMOAHNANKNE.JCGKFEPEJPO())
				{
					IPEndPoint iPEndPoint = HMOAHNANKNE.KJFAHHKIGAJ();
				}
				long ticks = DateTime.Now.Ticks - num;
				LAMMAAFNCDC((float)(new TimeSpan(ticks).TotalSeconds * 0.5));
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Full)
				{
					Debug.Log(string.Format("Receive Ping"));
				}
			}
		}

		public void POLDDBEIGHG()
		{
			KKKNDCBEPEF = false;
			APEJFABHJDF = true;
		}

		[SpecialName]
		public long MNNHKFKOKFE()
		{
			return JLCKDADEJFJ;
		}

		internal void ANIKGIGFJGE(int FDEJBCNGOEG, LinkedList<PFPNBBFDKMD> KEEMMDMLLIN)
		{
			FOCHEKNBHCA.AAGKKFOEIAN(FDEJBCNGOEG, KEEMMDMLLIN);
		}

		private void HECFOFBHFNE()
		{
			if (LGKJFHMCJOK)
			{
				return;
			}
			int num = 0;
			EndPoint remoteEP = AGIFNOKEDFC;
			try
			{
				while (GOOMHBJNFKC.Available > 0)
				{
					int num2 = GOOMHBJNFKC.ReceiveFrom(KCOCDEHJKDI, ref remoteEP);
					if (num2 < 16)
					{
						throw new ArgumentException("invalid udp packet");
					}
					KNIGJJCMMDB(AHENPLPJMIO() + 1);
					GAGPEPNEECJ(HBDONGPNKFP() + (num2 + 8));
					num = 0;
					while (num2 - num >= 16)
					{
						AGIFNOKEDFC = (IPEndPoint)remoteEP;
						int num3 = HOKDCGLFEIL.IOLIFEMLNHL(KCOCDEHJKDI, num);
						if (num3 < 16 || num2 - num < num3)
						{
							break;
						}
						GKHKNBMDHLG.LDNEFFHJNPL();
						GKHKNBMDHLG.HCBNCGILGEJ(KCOCDEHJKDI, num, num3);
						GKHKNBMDHLG.HIAMPPLHDAN();
						num += num3;
						if (GKHKNBMDHLG.OGFHNAKAINM() == 0)
						{
							GINOEGAMKHO(GKHKNBMDHLG, AGIFNOKEDFC);
							continue;
						}
						LHOLJMEKHBF lHOLJMEKHBF = null;
						lHOLJMEKHBF = ((GKHKNBMDHLG.NCHJJNGPOPA() != 0) ? KLBIKHEFDHH.PPIFDHBBEPM().IAFNIPEGNLN(GKHKNBMDHLG.NCHJJNGPOPA()) : FOCHEKNBHCA);
						if (lHOLJMEKHBF != null)
						{
							lHOLJMEKHBF.CEEACCPIABN(GKHKNBMDHLG, AGIFNOKEDFC, (PJEMPFEIOAK EFDLFNPAKGO, IPEndPoint HENFLIGFHEO) =>
							{
								GINOEGAMKHO(EFDLFNPAKGO, HENFLIGFHEO);
							});
						}
					}
				}
			}
			catch (Exception pAANPLECGAP)
			{
				if (KLBIKHEFDHH.MAJJNANHNDF != null)
				{
					KLBIKHEFDHH.MAJJNANHNDF(pAANPLECGAP);
				}
			}
		}

		protected void KBDPNBBKPOF(long ICENKPDOHBK)
		{
			NFEPJAFIJDG = ICENKPDOHBK;
		}

		[SpecialName]
		public long CIBFEMDGNFG()
		{
			return JLCKDADEJFJ;
		}

		public IPEndPoint PBMGEMIBOCF()
		{
			IPEndPoint iPEndPoint = (IPEndPoint)GOOMHBJNFKC.LocalEndPoint;
			IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
			for (int i = 0; i < hostEntry.AddressList.Length; i++)
			{
				if (hostEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
				{
					return new IPEndPoint(hostEntry.AddressList[i], iPEndPoint.Port);
				}
			}
			return null;
		}
	}
}
