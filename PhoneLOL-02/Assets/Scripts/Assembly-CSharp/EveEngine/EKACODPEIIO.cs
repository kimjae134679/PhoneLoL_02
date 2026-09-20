using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UnityEngine;

namespace EveEngine
{
	public abstract class EKACODPEIIO : IDisposable
	{
		public delegate void NBDMMINAPFC(PJEMPFEIOAK HMOAHNANKNE, IPEndPoint HGLJLELKDLE);

		public delegate void HPFJLPLLBAE(Exception PAANPLECGAP);

		public delegate void FOLFEODIOGL(PJEMPFEIOAK HMOAHNANKNE);

		protected Socket GOOMHBJNFKC;

		private byte[] KCOCDEHJKDI;

		private int NAAMANJIJCE;

		private bool PIGFGHMKJKF;

		private bool NKKPEFMNFHE;

		private bool LOEHMFOCLIB;

		protected TimeSpan EPMBOPLLFFB = TimeSpan.Zero;

		private LinkedList<PJEMPFEIOAK> BKCMHAPLBDC;

		private IPEndPoint PAJIPDFPDEG;

		private AutoResetEvent EGIIKLELGCL = new AutoResetEvent(false);

		private Dictionary<ushort, FOLFEODIOGL> BCKJLNFPKLA;

		private volatile bool APKGNOJLAJF;

		private float MBJAGHPKFFM;

		public NBDMMINAPFC AJJCIJFJDAJ;

		public NBDMMINAPFC KIBGHKLBHOJ;

		public NBDMMINAPFC GAGKHKEDJPE;

		public NBDMMINAPFC EMJOODMOIGA;

		public NBDMMINAPFC BPGDNOKCOKI;

		public HPFJLPLLBAE MAJJNANHNDF;

		protected Dictionary<int, FOLFEODIOGL> FGAKKAMBDFM;

		private bool PIFELLELNOA;

		private bool BOJFGANJALI;

		private int MEKLPIBAPOJ;

		private int NMPLJHGLHBN;

		private KJGALEFHHOA KNCPJCHDENA;

		private FMMNGEJDCOH MHHCDDFKNKK;

		private bool NGCOIPAECCD;

		public bool BGIKENBPGOC
		{
			get
			{
				return MKEKHOHAFKP();
			}
			protected set
			{
				HLAFDPFLMCH(value);
			}
		}

		public bool CIBAGKKFOFO
		{
			get
			{
				return JLOBDDDEIDL();
			}
			private set
			{
				FCFEPCMDLNP(value);
			}
		}

		public int BGKMCEIBHPC
		{
			get
			{
				return HFCHJAKELKG();
			}
			private set
			{
				OOKHFGBOIGJ(value);
			}
		}

		public int ODGCBCEMAHH
		{
			get
			{
				return NCHJJNGPOPA();
			}
			private set
			{
				FFOLMIHPEOF(value);
			}
		}

		public KJGALEFHHOA HLFODJJAENN
		{
			get
			{
				return JIPBIOELJHC();
			}
			private set
			{
				PALKKIBPHLL(value);
			}
		}

		public FMMNGEJDCOH AGJIBEEAGEJ
		{
			get
			{
				return PPIFDHBBEPM();
			}
			private set
			{
				GKPBDJBJMKK(value);
			}
		}

		public bool IEMBNJLELKM
		{
			get
			{
				return FPKPLPMCMDA();
			}
			private set
			{
				JAAGBGBDLOG(value);
			}
		}

		public EKACODPEIIO()
		{
			KCOCDEHJKDI = new byte[163840];
			BCKJLNFPKLA = new Dictionary<ushort, FOLFEODIOGL>();
			BKCMHAPLBDC = new LinkedList<PJEMPFEIOAK>();
			FGAKKAMBDFM = new Dictionary<int, FOLFEODIOGL>();
			GKPBDJBJMKK(new FMMNGEJDCOH(this));
			PIGFGHMKJKF = false;
			APKGNOJLAJF = false;
			NKKPEFMNFHE = false;
			LOEHMFOCLIB = false;
			HLAFDPFLMCH(false);
			FCFEPCMDLNP(false);
			OOKHFGBOIGJ(0);
			MBJAGHPKFFM = 0f;
			JAAGBGBDLOG(true);
			NIFAIFOJLFI.LFJBNIDJHOM();
		}

		public bool MKEKHOHAFKP()
		{
			return PIFELLELNOA;
		}

		protected void HLAFDPFLMCH(bool ICENKPDOHBK)
		{
			PIFELLELNOA = ICENKPDOHBK;
		}

		public bool JLOBDDDEIDL()
		{
			return BOJFGANJALI;
		}

		private void FCFEPCMDLNP(bool ICENKPDOHBK)
		{
			BOJFGANJALI = ICENKPDOHBK;
		}

		public int HFCHJAKELKG()
		{
			return MEKLPIBAPOJ;
		}

		private void OOKHFGBOIGJ(int ICENKPDOHBK)
		{
			MEKLPIBAPOJ = ICENKPDOHBK;
		}

		public int NCHJJNGPOPA()
		{
			return NMPLJHGLHBN;
		}

		private void FFOLMIHPEOF(int ICENKPDOHBK)
		{
			NMPLJHGLHBN = ICENKPDOHBK;
		}

		public KJGALEFHHOA JIPBIOELJHC()
		{
			return KNCPJCHDENA;
		}

		private void PALKKIBPHLL(KJGALEFHHOA ICENKPDOHBK)
		{
			KNCPJCHDENA = ICENKPDOHBK;
		}

		public FMMNGEJDCOH PPIFDHBBEPM()
		{
			return MHHCDDFKNKK;
		}

		private void GKPBDJBJMKK(FMMNGEJDCOH ICENKPDOHBK)
		{
			MHHCDDFKNKK = ICENKPDOHBK;
		}

		public bool FPKPLPMCMDA()
		{
			V096OriginalDiagnostics.ShareReport();
			return NGCOIPAECCD;
		}

		private void JAAGBGBDLOG(bool ICENKPDOHBK)
		{
			NGCOIPAECCD = ICENKPDOHBK;
		}

		public void Dispose()
		{
			JDBENBMLFNP(true);
			GC.SuppressFinalize(this);
		}

		protected virtual void JDBENBMLFNP(bool BPCKECGFJPA)
		{
			if (BPCKECGFJPA)
			{
				MNCACLOFDBA();
				GOOMHBJNFKC.Close();
				BKCMHAPLBDC.Clear();
				BKCMHAPLBDC = null;
				KCOCDEHJKDI = null;
				PAJIPDFPDEG = null;
				if (JIPBIOELJHC() != null)
				{
					JIPBIOELJHC().Dispose();
					PALKKIBPHLL(null);
				}
				EGIIKLELGCL.Close();
				EGIIKLELGCL = null;
			}
		}

		public bool IOMHAEMKIHM(IPEndPoint OHCOHOIMCBP)
		{
			if (MKEKHOHAFKP())
			{
				return false;
			}
			if (NHKIEEJHEJH())
			{
				return false;
			}
			PPIFDHBBEPM().PDCPMDCOLOD();
			FGAKKAMBDFM.Clear();
			BKCMHAPLBDC.Clear();
			if (JIPBIOELJHC() != null)
			{
				JIPBIOELJHC().Dispose();
				PALKKIBPHLL(null);
			}
			APKGNOJLAJF = false;
			NKKPEFMNFHE = false;
			LOEHMFOCLIB = false;
			HLAFDPFLMCH(true);
			FCFEPCMDLNP(false);
			OOKHFGBOIGJ(0);
			MBJAGHPKFFM = 0f;
			NAAMANJIJCE = 0;
			PAJIPDFPDEG = OHCOHOIMCBP;
			GOOMHBJNFKC = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			GOOMHBJNFKC.LingerState = new LingerOption(true, 0);
			GOOMHBJNFKC.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.KeepAlive, true);
			GOOMHBJNFKC.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
			GOOMHBJNFKC.SendBufferSize = 163840;
			GOOMHBJNFKC.ReceiveBufferSize = 163840;
			if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
			{
				JAAGBGBDLOG(false);
			}
			else
			{
				JAAGBGBDLOG(true);
			}
			GOOMHBJNFKC.BeginConnect(PAJIPDFPDEG, IKNIELDCBMH, GOOMHBJNFKC);
			return true;
		}

		private void IKNIELDCBMH(IAsyncResult HIJLMPFMHBH)
		{
			try
			{
				GOOMHBJNFKC.EndConnect(HIJLMPFMHBH);
				HLAFDPFLMCH(false);
				OOMONGJIOAB();
			}
			catch (Exception pAANPLECGAP)
			{
				HLAFDPFLMCH(false);
				NEFPLIAKOEE();
				if (MAJJNANHNDF != null)
				{
					MAJJNANHNDF(pAANPLECGAP);
				}
			}
		}

		public bool OACOJHEOGIL(IPEndPoint OHCOHOIMCBP)
		{
			if (MKEKHOHAFKP())
			{
				return false;
			}
			if (NHKIEEJHEJH())
			{
				return false;
			}
			LOEHMFOCLIB = false;
			APKGNOJLAJF = false;
			PAJIPDFPDEG = OHCOHOIMCBP;
			GOOMHBJNFKC = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			GOOMHBJNFKC.NoDelay = true;
			GOOMHBJNFKC.LingerState = new LingerOption(true, 0);
			GOOMHBJNFKC.SendBufferSize = 81920;
			GOOMHBJNFKC.ReceiveBufferSize = 81920;
			if (Application.internetReachability == NetworkReachability.ReachableViaCarrierDataNetwork)
			{
				JAAGBGBDLOG(false);
			}
			else
			{
				JAAGBGBDLOG(true);
			}
			try
			{
				GOOMHBJNFKC.Connect(PAJIPDFPDEG);
				OOMONGJIOAB();
				return true;
			}
			catch (Exception pAANPLECGAP)
			{
				NEFPLIAKOEE();
				if (MAJJNANHNDF != null)
				{
					MAJJNANHNDF(pAANPLECGAP);
				}
			}
			return false;
		}

		public void MNCACLOFDBA()
		{
			if (!NHKIEEJHEJH())
			{
				return;
			}
			try
			{
				PPIFDHBBEPM().PDCPMDCOLOD();
				FGAKKAMBDFM.Clear();
				BKCMHAPLBDC.Clear();
				GOOMHBJNFKC.Shutdown(SocketShutdown.Both);
				GOOMHBJNFKC.Disconnect(true);
				if (JIPBIOELJHC() != null)
				{
					JIPBIOELJHC().Dispose();
					PALKKIBPHLL(null);
				}
			}
			catch (Exception)
			{
			}
		}

		public bool FBAFKOCPFPG(CMNIABEFLBJ EFDLFNPAKGO, FOLFEODIOGL NDDGMOOOINI = null)
		{
			if (GOOMHBJNFKC == null)
			{
				return false;
			}
			if (!GOOMHBJNFKC.Connected)
			{
				return false;
			}
			try
			{
				EFDLFNPAKGO.MGADFEIAJOB();
				if (NDDGMOOOINI != null)
				{
					if (FGAKKAMBDFM.ContainsKey(EFDLFNPAKGO.OGFHNAKAINM()))
					{
						FGAKKAMBDFM[EFDLFNPAKGO.OGFHNAKAINM()] = NDDGMOOOINI;
					}
					else
					{
						FGAKKAMBDFM.Add(EFDLFNPAKGO.OGFHNAKAINM(), NDDGMOOOINI);
					}
				}
				EFDLFNPAKGO.BCKCJLNLABI();
				EFDLFNPAKGO.BFFJJKCEODA(CDBKHBBPHEH);
				GOOMHBJNFKC.SendAsync(EFDLFNPAKGO.OGANCGLPGLC());
			}
			catch (Exception pAANPLECGAP)
			{
				EFDLFNPAKGO.CDPNLMMNNBD();
				NEFPLIAKOEE();
				if (MAJJNANHNDF != null)
				{
					MAJJNANHNDF(pAANPLECGAP);
				}
				return false;
			}
			return true;
		}

		private void CDBKHBBPHEH(object LBAMPEPAANM, SocketAsyncEventArgs PAANPLECGAP)
		{
			CMNIABEFLBJ cMNIABEFLBJ = PAANPLECGAP.UserToken as CMNIABEFLBJ;
			if (cMNIABEFLBJ != null)
			{
				cMNIABEFLBJ.CDPNLMMNNBD();
			}
			if (PAANPLECGAP.SocketError != SocketError.Success)
			{
				NEFPLIAKOEE();
			}
		}

		public bool NHKIEEJHEJH()
		{
			if (GOOMHBJNFKC == null)
			{
				return false;
			}
			if (!GOOMHBJNFKC.Connected)
			{
				return false;
			}
			return PIGFGHMKJKF;
		}

		public DateTime GDFDNGEEMEO()
		{
			return DateTime.Now + EPMBOPLLFFB;
		}

		public bool LFCAELOOLPF(int HAMFBILCGLF)
		{
			return FGAKKAMBDFM.ContainsKey(HAMFBILCGLF);
		}

		protected void HADMKAKPDDO(ushort OHGOBGOIECH, FOLFEODIOGL OKAOHNAPGCL)
		{
			BCKJLNFPKLA.Add(OHGOBGOIECH, OKAOHNAPGCL);
		}

		public void LPBLGFCPADD(float DMLKFKGBHKJ)
		{
			lock (BKCMHAPLBDC)
			{
				if (LOEHMFOCLIB && NKKPEFMNFHE)
				{
					PIGFGHMKJKF = NKKPEFMNFHE;
				}
				while (BKCMHAPLBDC.Count > 0)
				{
					PJEMPFEIOAK value = BKCMHAPLBDC.First.Value;
                    // A login callback can close the connection and clear this queue.
                    BKCMHAPLBDC.RemoveFirst();
					try
					{
						GINOEGAMKHO(value);
					}
					catch (Exception exception)
					{
						Debug.LogException(exception);
					}
					value.CDPNLMMNNBD();
				}
				if (LOEHMFOCLIB && !NKKPEFMNFHE)
				{
					PIGFGHMKJKF = NKKPEFMNFHE;
					OIHIOEMEAKF();
				}
				LOEHMFOCLIB = false;
			}
			try
			{
				if (JIPBIOELJHC() != null)
				{
					if (!JIPBIOELJHC().LPBLGFCPADD(DMLKFKGBHKJ))
					{
						MNCACLOFDBA();
						return;
					}
					PPIFDHBBEPM().LPBLGFCPADD(DMLKFKGBHKJ);
					JIPBIOELJHC().HBKEFJINMJK(DMLKFKGBHKJ);
				}
				if (APKGNOJLAJF)
				{
					MBJAGHPKFFM += DMLKFKGBHKJ;
					if (MBJAGHPKFFM >= 20f)
					{
						MBJAGHPKFFM = 0f;
						OHEPFFDKBJK();
					}
				}
			}
			catch (Exception exception2)
			{
				Debug.LogException(exception2);
			}
			DPILNPAPPKI(DMLKFKGBHKJ);
		}

		public abstract void DPILNPAPPKI(float DMLKFKGBHKJ);

		public virtual void EPHKPHKIFFE(ushort OHGOBGOIECH)
		{
		}

		private void GINOEGAMKHO(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (PhoneLOLMultiplayerBridge.Receive(this, HMOAHNANKNE))
			{
				return;
			}
			if (HMOAHNANKNE.KCGNKBDGONC() >= 60000)
			{
				switch ((MGOCABFFMAG)HMOAHNANKNE.KCGNKBDGONC())
				{
				case MGOCABFFMAG.Auth:
					CBPFAIFIJLN(HMOAHNANKNE);
					break;
				case MGOCABFFMAG.UDPAuth:
					AHJNJOANBOD(HMOAHNANKNE);
					break;
				case MGOCABFFMAG.JoinP2PGroup:
					LNHMLJJCMMH(HMOAHNANKNE);
					break;
				case MGOCABFFMAG.LeaveP2PGroup:
					OIDGPLEFDBA(HMOAHNANKNE);
					break;
				case MGOCABFFMAG.ChangeMasterP2PGroup:
					KBEEHPGOOII(HMOAHNANKNE);
					break;
				case MGOCABFFMAG.HolePunchingArrived:
					KMBMCMCJAOL(HMOAHNANKNE);
					break;
				case MGOCABFFMAG.CheckAlive:
				case MGOCABFFMAG.GiveupMasterP2PGroup:
					break;
				}
				return;
			}
			FOLFEODIOGL value = null;
			if (FGAKKAMBDFM.TryGetValue(HMOAHNANKNE.OGFHNAKAINM(), out value))
			{
				value(HMOAHNANKNE);
				FGAKKAMBDFM.Remove(HMOAHNANKNE.OGFHNAKAINM());
				EPHKPHKIFFE(HMOAHNANKNE.KCGNKBDGONC());
				return;
			}
			if (BCKJLNFPKLA.TryGetValue(HMOAHNANKNE.KCGNKBDGONC(), out value))
			{
				value(HMOAHNANKNE);
				EPHKPHKIFFE(HMOAHNANKNE.KCGNKBDGONC());
				return;
			}
			throw new ArgumentException("unregistered packet function from id.");
		}

		internal void AHIMLKAFIIE(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (HMOAHNANKNE.KCGNKBDGONC() < 60000)
			{
				FOLFEODIOGL value = null;
				if (!BCKJLNFPKLA.TryGetValue(HMOAHNANKNE.KCGNKBDGONC(), out value))
				{
					throw new ArgumentException("unregistered packet function from id.");
				}
				value(HMOAHNANKNE);
				EPHKPHKIFFE(HMOAHNANKNE.KCGNKBDGONC());
			}
		}

		public void KGNMBELLPNG(IAsyncResult DBCICPELGNH)
		{
			SocketError errorCode = SocketError.Success;
			CMNIABEFLBJ cMNIABEFLBJ = null;
			try
			{
				cMNIABEFLBJ = (CMNIABEFLBJ)DBCICPELGNH.AsyncState;
				int num = GOOMHBJNFKC.EndSend(DBCICPELGNH, out errorCode);
				if (num < cMNIABEFLBJ.EJGJCLHFIAM())
				{
					throw new ArgumentException("fail to send packet all size.");
				}
				cMNIABEFLBJ.CDPNLMMNNBD();
			}
			catch (SocketException ex)
			{
				errorCode = ex.SocketErrorCode;
			}
			catch
			{
				errorCode = SocketError.SocketError;
			}
			if (errorCode != SocketError.Success)
			{
				NEFPLIAKOEE();
			}
			DIOOIPEFFID(errorCode, cMNIABEFLBJ);
		}

		public virtual void DIOOIPEFFID(SocketError MAOLPBBJOJB, CMNIABEFLBJ LCNMDBEHKIP)
		{
		}

		public void ADHHEKHLKKO(IAsyncResult DBCICPELGNH)
		{
			int num = 0;
			try
			{
				num = GOOMHBJNFKC.EndReceive(DBCICPELGNH);
				if (num > 0)
				{
					NAAMANJIJCE += num;
					if (NAAMANJIJCE > 2)
					{
						int num2 = 0;
						while (num2++ < 50)
						{
							int num3 = HOKDCGLFEIL.IOLIFEMLNHL(KCOCDEHJKDI, 0);
							if (num3 == 0)
							{
								throw new ArgumentException("packet size is 0");
							}
							if (NAAMANJIJCE < num3)
							{
								break;
							}
							PJEMPFEIOAK pJEMPFEIOAK = PJEMPFEIOAK.PEFJOMFAOJI();
							pJEMPFEIOAK.LDNEFFHJNPL();
							pJEMPFEIOAK.HCBNCGILGEJ(KCOCDEHJKDI, 0, num3);
							pJEMPFEIOAK.HIAMPPLHDAN();
							if (NAAMANJIJCE - num3 > 0)
							{
								Buffer.BlockCopy(KCOCDEHJKDI, num3, KCOCDEHJKDI, 0, NAAMANJIJCE - num3);
							}
							lock (BKCMHAPLBDC)
							{
								BKCMHAPLBDC.AddLast(pJEMPFEIOAK);
							}
							NAAMANJIJCE -= num3;
							if (NAAMANJIJCE <= 0)
							{
								break;
							}
						}
					}
					GOOMHBJNFKC.BeginReceive(KCOCDEHJKDI, NAAMANJIJCE, KCOCDEHJKDI.Length - NAAMANJIJCE, SocketFlags.None, ADHHEKHLKKO, this);
				}
				else
				{
					NEFPLIAKOEE();
				}
			}
			catch (Exception pAANPLECGAP)
			{
				NEFPLIAKOEE();
				if (MAJJNANHNDF != null)
				{
					MAJJNANHNDF(pAANPLECGAP);
				}
			}
		}

		public void OOMONGJIOAB()
		{
			MBJAGHPKFFM = 0f;
			if (GOOMHBJNFKC.Connected)
			{
				GOOMHBJNFKC.BeginReceive(KCOCDEHJKDI, NAAMANJIJCE, KCOCDEHJKDI.Length - NAAMANJIJCE, SocketFlags.None, ADHHEKHLKKO, this);
			}
			lock (BKCMHAPLBDC)
			{
				NKKPEFMNFHE = true;
				LOEHMFOCLIB = true;
			}
			OPBJKMBJCKK();
		}

		public void NEFPLIAKOEE()
		{
			MNCACLOFDBA();
			lock (BKCMHAPLBDC)
			{
				NKKPEFMNFHE = false;
				LOEHMFOCLIB = true;
			}
		}

		public abstract void CPILEHGNHGE();

		public abstract void OIHIOEMEAKF();

		private void OPBJKMBJCKK()
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(60001);
			cMNIABEFLBJ.GBMJNFOEACC(107);
			cMNIABEFLBJ.GBMJNFOEACC(DateTime.Now.Ticks);
			cMNIABEFLBJ.GBMJNFOEACC(FPKPLPMCMDA());
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void CBPFAIFIJLN(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (APKGNOJLAJF)
			{
				return;
			}
			if (HMOAHNANKNE.KFAGPDGHEBK() == 0)
			{
				long num = HMOAHNANKNE.GAGNPBAMJLE();
				DateTime dateTime = HMOAHNANKNE.NOIDCBCMCMK();
				FFOLMIHPEOF(HMOAHNANKNE.PNBKOPGIHDI());
				FCFEPCMDLNP(HMOAHNANKNE.JCGKFEPEJPO());
				if (JLOBDDDEIDL())
				{
					OOKHFGBOIGJ(HMOAHNANKNE.PNBKOPGIHDI());
				}
				TimeSpan timeSpan = new TimeSpan((DateTime.Now.Ticks - num) / 2);
				EPMBOPLLFFB = dateTime + timeSpan - DateTime.Now;
				JHJNCOHHOGA.EJEDDIOJPJD(EPMBOPLLFFB);
				if (JLOBDDDEIDL())
				{
					if (JIPBIOELJHC() == null)
					{
						IPEndPoint cNDLAKPDMPB = new IPEndPoint(PAJIPDFPDEG.Address, HFCHJAKELKG());
						PALKKIBPHLL(new KJGALEFHHOA(this, cNDLAKPDMPB));
						JIPBIOELJHC().LDNEFFHJNPL();
						JIPBIOELJHC().POLDDBEIGHG();
					}
				}
				else
				{
					APKGNOJLAJF = true;
					CPILEHGNHGE();
				}
			}
			else
			{
				MNCACLOFDBA();
			}
		}

		private void AHJNJOANBOD(PJEMPFEIOAK HMOAHNANKNE)
		{
			if (JLOBDDDEIDL() && !APKGNOJLAJF)
			{
				APKGNOJLAJF = true;
				CPILEHGNHGE();
			}
		}

		private void OHEPFFDKBJK()
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(60003);
			cMNIABEFLBJ.GBMJNFOEACC(DateTime.Now.Ticks);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void LNHMLJJCMMH(PJEMPFEIOAK HMOAHNANKNE)
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			IPEndPoint iPEndPoint = HMOAHNANKNE.KJFAHHKIGAJ();
			IPEndPoint eJLHGDDBGIO = HMOAHNANKNE.KJFAHHKIGAJ();
			if (num2 == NCHJJNGPOPA())
			{
				PPIFDHBBEPM().MMJOMFGEJHC(num, num3);
				LHOLJMEKHBF lHOLJMEKHBF = PPIFDHBBEPM().EDEIEIHNNMD(num, num2, num3, iPEndPoint, eJLHGDDBGIO);
				lHOLJMEKHBF.JNCNJOHDJDD(true);
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Informational)
				{
					Debug.Log(string.Format("Create P2P Group {0} {1} {2} {3}", num, num2, num3, iPEndPoint));
				}
			}
			else
			{
				PPIFDHBBEPM().EDEIEIHNNMD(num, num2, num3, iPEndPoint, eJLHGDDBGIO);
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Informational)
				{
					Debug.Log(string.Format("Join P2P Group {0} {1} {2} {3}", num, num2, num3, iPEndPoint));
				}
			}
		}

		private void OIDGPLEFDBA(PJEMPFEIOAK HMOAHNANKNE)
		{
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			int num3 = HMOAHNANKNE.PNBKOPGIHDI();
			if (num2 == NCHJJNGPOPA())
			{
				PPIFDHBBEPM().GCKJMAIOBHF(num);
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Informational)
				{
					Debug.Log(string.Format("Destroy P2P Group {0} {1}", num, num2));
				}
			}
			else
			{
				PPIFDHBBEPM().PCKEOANHGBD(num, num2, num3);
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Informational)
				{
					Debug.Log(string.Format("Leave P2P Group {0} {1} {2}", num, num2, num3));
				}
			}
		}

		private void KMBMCMCJAOL(PJEMPFEIOAK HMOAHNANKNE)
		{
			int nECJILEFBAO = HMOAHNANKNE.PNBKOPGIHDI();
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			int num2 = HMOAHNANKNE.PNBKOPGIHDI();
			IPEndPoint oHCOHOIMCBP = HMOAHNANKNE.KJFAHHKIGAJ();
			ABBLIOLAABC aBBLIOLAABC = PPIFDHBBEPM().KBLCDMPGOMM(nECJILEFBAO);
			if (aBBLIOLAABC == null || NCHJJNGPOPA() != num)
			{
				return;
			}
			LHOLJMEKHBF lHOLJMEKHBF = aBBLIOLAABC.KBLCDMPGOMM(num2);
			if (lHOLJMEKHBF != null)
			{
				lHOLJMEKHBF.LBMGLBHNFFE(oHCOHOIMCBP);
				if (lHOLJMEKHBF.OOHFDEPKKFN() != LHOLJMEKHBF.OEOIIKMBGAG.BothConnected)
				{
					lHOLJMEKHBF.AJJGLNHAPPF(LHOLJMEKHBF.OEOIIKMBGAG.Connected);
				}
				if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Informational)
				{
					Debug.Log(string.Format("P2P Connected from Server {0} to {1}", num, num2));
				}
			}
		}

		public void JHBDMGLMEIH(int NECJILEFBAO)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(60006);
			cMNIABEFLBJ.GBMJNFOEACC(NECJILEFBAO);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}

		private void KBEEHPGOOII(PJEMPFEIOAK HMOAHNANKNE)
		{
			int nECJILEFBAO = HMOAHNANKNE.PNBKOPGIHDI();
			int num = HMOAHNANKNE.PNBKOPGIHDI();
			PPIFDHBBEPM().LBMGEFMOIGL(nECJILEFBAO, num);
			if (EveUnityNetwork.get_Instance().m_logLevel >= EveUnityNetwork.IFLONDHKBBI.Informational)
			{
				Debug.Log(string.Format("P2P Change Master {0}", num));
			}
		}

		public void OPEBDCDCMDM(sbyte FOLFEDBLOJH)
		{
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(60009);
			cMNIABEFLBJ.GBMJNFOEACC(FOLFEDBLOJH);
			FBAFKOCPFPG(cMNIABEFLBJ);
		}
	}
}
