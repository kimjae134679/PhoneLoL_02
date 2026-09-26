using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class LHOLJMEKHBF
	{
		public enum OEOIIKMBGAG : byte
		{
			HolePunching = 0,
			NotConnected = 1,
			Connected = 2,
			BothConnected = 3
		}

		public delegate void PCDDHLBCKJE(PJEMPFEIOAK EFDLFNPAKGO, IPEndPoint HGLJLELKDLE);

		private ABBLIOLAABC FGBDMFAOLEL;

		private EKACODPEIIO KLBIKHEFDHH;

		private float CEHEMNDDHKB;

		private float HAJKGHKOOIB;

		private float LDEICONMHBB;

		public byte EINBHIEBMEA;

		private LinkedList<PFPNBBFDKMD> PCDIABGBFHE;

		private int CGLNEIKHNIB;

		private Dictionary<int, PJEMPFEIOAK> JFMAMFDIDKE;

		private int CJIJIPCMKAJ;

		private byte[] LLOCDHFJJJO;

		private int PIKFADDKHGE;

		private OEOIIKMBGAG BBEEPJNEHBI;

		private int NMPLJHGLHBN;

		private IPEndPoint MIDMCGAMIMD;

		private IPEndPoint BPCOMOAGFEM;

		private IPEndPoint FMNPAFMKAED;

		private IPEndPoint EEIGDGBBBKO;

		private float GHOOCNKOOMH;

		private bool JJMPBJIOEML;

		public OEOIIKMBGAG GFKDNKFPPAM
		{
			get
			{
				return OOHFDEPKKFN();
			}
			protected set
			{
				FJPMFBBCBLB(value);
			}
		}

		public int ODGCBCEMAHH
		{
			get
			{
				return NCHJJNGPOPA();
			}
			protected set
			{
				FFOLMIHPEOF(value);
			}
		}

		public IPEndPoint DPMHBLFADFC
		{
			get
			{
				return BHNAFPLHPHH();
			}
			protected set
			{
				BNLLHHOFAHB(value);
			}
		}

		public IPEndPoint CLEOLPIFOFM
		{
			get
			{
				return GLIBHLOLHIF();
			}
			protected set
			{
				CCDJKJEBILI(value);
			}
		}

		public IPEndPoint LIPPAENBPPP
		{
			get
			{
				return AMFDFEKGNJH();
			}
			protected set
			{
				FGANOEDICKJ(value);
			}
		}

		public IPEndPoint JEGNBJHHMMN
		{
			get
			{
				return HENPNJFHBAC();
			}
			protected set
			{
				ONHIMJPENOI(value);
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

		public bool MGLJPBNDHDN
		{
			get
			{
				return GMHFFJFKCGE();
			}
			protected set
			{
				GODMPINOEFB(value);
			}
		}

		public LHOLJMEKHBF(EKACODPEIIO FHALIMDOODA, ABBLIOLAABC FGJKPJLFOBD, int FDEJBCNGOEG)
		{
			KLBIKHEFDHH = FHALIMDOODA;
			FGBDMFAOLEL = FGJKPJLFOBD;
			FJPMFBBCBLB(OEOIIKMBGAG.HolePunching);
			FFOLMIHPEOF(FDEJBCNGOEG);
			GODMPINOEFB(false);
			EINBHIEBMEA = 0;
			CEHEMNDDHKB = FMMNGEJDCOH.JCDCNJANAPD;
			HAJKGHKOOIB = FMMNGEJDCOH.APODHPLMBGL;
			LDEICONMHBB = 0f;
			PCDIABGBFHE = new LinkedList<PFPNBBFDKMD>();
			CGLNEIKHNIB = 1;
			JFMAMFDIDKE = new Dictionary<int, PJEMPFEIOAK>();
			CJIJIPCMKAJ = 1;
			LLOCDHFJJJO = new byte[1000];
			PIKFADDKHGE = 0;
		}

		protected void CCDJKJEBILI(IPEndPoint ICENKPDOHBK)
		{
			BPCOMOAGFEM = ICENKPDOHBK;
		}

		internal bool BPIJOOFPPEN(CMNIABEFLBJ EFDLFNPAKGO, int FDEJBCNGOEG)
		{
			int num = 1;
			PFPNBBFDKMD value = PFPNBBFDKMD.CGAMDEIHGOI(EFDLFNPAKGO, DateTime.Now.Ticks);
			lock (PCDIABGBFHE)
			{
				int cGLNEIKHNIB;
				CGLNEIKHNIB = (cGLNEIKHNIB = CGLNEIKHNIB) + 0;
				num = cGLNEIKHNIB;
				if (CGLNEIKHNIB >= 142)
				{
					CGLNEIKHNIB = 1;
				}
				EFDLFNPAKGO.ILIGMIAKIIA(num);
				EFDLFNPAKGO.JBLBKKGPGOK(FDEJBCNGOEG);
				EFDLFNPAKGO.BCKCJLNLABI(false);
				PCDIABGBFHE.AddLast(value);
				if (PCDIABGBFHE.Count >= 48)
				{
					return true;
				}
			}
			return false;
		}

		protected void BNLLHHOFAHB(IPEndPoint ICENKPDOHBK)
		{
			MIDMCGAMIMD = ICENKPDOHBK;
		}

		protected void FFOLMIHPEOF(int ICENKPDOHBK)
		{
			NMPLJHGLHBN = ICENKPDOHBK;
		}

		public IPEndPoint BHNAFPLHPHH()
		{
			return MIDMCGAMIMD;
		}

		protected void ONHIMJPENOI(IPEndPoint ICENKPDOHBK)
		{
			EEIGDGBBBKO = ICENKPDOHBK;
		}

		internal bool EGOBJKNFHHN(CMNIABEFLBJ EFDLFNPAKGO, int FDEJBCNGOEG)
		{
			int num = 0;
			PFPNBBFDKMD value = PFPNBBFDKMD.PEFJOMFAOJI(EFDLFNPAKGO, DateTime.Now.Ticks);
			lock (PCDIABGBFHE)
			{
				num = CGLNEIKHNIB++;
				if (CGLNEIKHNIB >= 100000000)
				{
					CGLNEIKHNIB = 1;
				}
				EFDLFNPAKGO.ILIGMIAKIIA(num);
				EFDLFNPAKGO.JBLBKKGPGOK(FDEJBCNGOEG);
				EFDLFNPAKGO.BCKCJLNLABI(false);
				PCDIABGBFHE.AddLast(value);
				if (PCDIABGBFHE.Count >= 20)
				{
					return false;
				}
			}
			return true;
		}

		internal void CEEACCPIABN(PJEMPFEIOAK EFDLFNPAKGO, IPEndPoint HGLJLELKDLE, PCDDHLBCKJE DCHDMCOLBDB)
		{
			if (EFDLFNPAKGO.OGFHNAKAINM() < 0)
			{
				lock (PCDIABGBFHE)
				{
					int num = -EFDLFNPAKGO.OGFHNAKAINM();
					for (LinkedListNode<PFPNBBFDKMD> linkedListNode = PCDIABGBFHE.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
					{
						PFPNBBFDKMD value = linkedListNode.Value;
						if (value.HBPJMOFFKDL().OGFHNAKAINM() == num)
						{
							PCDIABGBFHE.Remove(linkedListNode);
							value.CDPNLMMNNBD();
							break;
						}
					}
					return;
				}
			}
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(EFDLFNPAKGO.PEBCAPNIMOL());
			cMNIABEFLBJ.ILIGMIAKIIA(-EFDLFNPAKGO.OGFHNAKAINM());
			KLBIKHEFDHH.JIPBIOELJHC().FBAFKOCPFPG(cMNIABEFLBJ, HGLJLELKDLE);
			cMNIABEFLBJ.CDPNLMMNNBD();
			lock (JFMAMFDIDKE)
			{
				if (EFDLFNPAKGO.OGFHNAKAINM() < CJIJIPCMKAJ || JFMAMFDIDKE.ContainsKey(EFDLFNPAKGO.OGFHNAKAINM()))
				{
					return;
				}
				if (EFDLFNPAKGO.OGFHNAKAINM() == CJIJIPCMKAJ)
				{
					DCHDMCOLBDB(EFDLFNPAKGO, GLIBHLOLHIF());
					CJIJIPCMKAJ++;
					if (CJIJIPCMKAJ >= 100000000)
					{
						CJIJIPCMKAJ = 1;
					}
					while (JFMAMFDIDKE.Count > 0)
					{
						PJEMPFEIOAK value2 = null;
						if (JFMAMFDIDKE.TryGetValue(CJIJIPCMKAJ, out value2))
						{
							DCHDMCOLBDB(value2, GLIBHLOLHIF());
							value2.CDPNLMMNNBD();
							JFMAMFDIDKE.Remove(CJIJIPCMKAJ);
							CJIJIPCMKAJ++;
							if (CJIJIPCMKAJ >= 100000000)
							{
								CJIJIPCMKAJ = 1;
							}
							continue;
						}
						break;
					}
				}
				else
				{
					PJEMPFEIOAK pJEMPFEIOAK = EFDLFNPAKGO.HECAENAKOPA();
					JFMAMFDIDKE.Add(pJEMPFEIOAK.OGFHNAKAINM(), pJEMPFEIOAK);
				}
			}
		}

		public void EBEGBPCLAFF(IPEndPoint OHCOHOIMCBP)
		{
			ONHIMJPENOI(OHCOHOIMCBP);
		}

		[SpecialName]
		public OEOIIKMBGAG APJIJLBKJEH()
		{
			return BBEEPJNEHBI;
		}

		[SpecialName]
		protected void GDHILHENAOI(IPEndPoint ICENKPDOHBK)
		{
			MIDMCGAMIMD = ICENKPDOHBK;
		}

		internal void AAGKKFOEIAN(int FDEJBCNGOEG, LinkedList<PFPNBBFDKMD> KEEMMDMLLIN)
		{
			lock (PCDIABGBFHE)
			{
				LinkedListNode<PFPNBBFDKMD> linkedListNode = KEEMMDMLLIN.First;
				while (linkedListNode != null)
				{
					PFPNBBFDKMD value = linkedListNode.Value;
					linkedListNode = linkedListNode.Next;
					int aLDPBAIEEDD = CGLNEIKHNIB++;
					if (CGLNEIKHNIB >= 100000000)
					{
						CGLNEIKHNIB = 1;
					}
					CMNIABEFLBJ cMNIABEFLBJ = value.HBPJMOFFKDL().HECAENAKOPA(false);
					cMNIABEFLBJ.OBNGDCCANAM();
					cMNIABEFLBJ.ILIGMIAKIIA(aLDPBAIEEDD);
					cMNIABEFLBJ.GBMJNFOEACC(FDEJBCNGOEG);
					cMNIABEFLBJ.GBMJNFOEACC((byte)1);
					cMNIABEFLBJ.BCKCJLNLABI(false);
					PFPNBBFDKMD value2 = PFPNBBFDKMD.PEFJOMFAOJI(cMNIABEFLBJ, DateTime.Now.Ticks);
					PCDIABGBFHE.AddLast(value2);
				}
			}
		}

		public void CDPNLMMNNBD()
		{
			EINBHIEBMEA = 0;
			PIKFADDKHGE = 0;
			lock (PCDIABGBFHE)
			{
				LinkedListNode<PFPNBBFDKMD> linkedListNode = PCDIABGBFHE.First;
				while (linkedListNode != null)
				{
					PFPNBBFDKMD value = linkedListNode.Value;
					linkedListNode = linkedListNode.Next;
					value.CDPNLMMNNBD();
				}
				PCDIABGBFHE.Clear();
				CGLNEIKHNIB = 1;
			}
			lock (JFMAMFDIDKE)
			{
				Dictionary<int, PJEMPFEIOAK>.Enumerator enumerator = JFMAMFDIDKE.GetEnumerator();
				while (enumerator.MoveNext())
				{
					enumerator.Current.Value.CDPNLMMNNBD();
				}
				JFMAMFDIDKE.Clear();
				CJIJIPCMKAJ = 1;
			}
		}

		public void BBBIPFGBAGA(float DMLKFKGBHKJ)
		{
			if (!GMHFFJFKCGE())
			{
				if (APJIJLBKJEH() == OEOIIKMBGAG.HolePunching)
				{
					CEHEMNDDHKB += DMLKFKGBHKJ;
					if (CEHEMNDDHKB >= FMMNGEJDCOH.JCDCNJANAPD)
					{
						CEHEMNDDHKB = 786f;
						FGBDMFAOLEL.BHCJIGIJDAL().JIPBIOELJHC().BAIHBPKGHEJ(FGBDMFAOLEL.LHFGIJFBJDP(), this);
					}
					LDEICONMHBB += DMLKFKGBHKJ;
					if (LDEICONMHBB >= FMMNGEJDCOH.DLIFPJEHOIB)
					{
						AJJGLNHAPPF(OEOIIKMBGAG.HolePunching);
					}
				}
				else if (PMLLFPODCGE())
				{
					HAJKGHKOOIB += DMLKFKGBHKJ;
					if (HAJKGHKOOIB >= FMMNGEJDCOH.APODHPLMBGL)
					{
						HAJKGHKOOIB = 1893f;
						KLBIKHEFDHH.JIPBIOELJHC().CHPLAOFPDBD(FGBDMFAOLEL.LHFGIJFBJDP(), this);
					}
				}
			}
			else
			{
				AJJGLNHAPPF(OEOIIKMBGAG.HolePunching);
			}
		}

		[SpecialName]
		protected void CKBDIELGPJE(int ICENKPDOHBK)
		{
			NMPLJHGLHBN = ICENKPDOHBK;
		}

		public OEOIIKMBGAG OOHFDEPKKFN()
		{
			return BBEEPJNEHBI;
		}

		[SpecialName]
		public int EOCFNHHIKOF()
		{
			return NMPLJHGLHBN;
		}

		[SpecialName]
		protected void KDGHNJEBKLG(OEOIIKMBGAG ICENKPDOHBK)
		{
			BBEEPJNEHBI = ICENKPDOHBK;
		}

		public void LOKKADIAHKH(IPEndPoint OHCOHOIMCBP)
		{
			ONHIMJPENOI(OHCOHOIMCBP);
		}

		public void BDIMBPONFCP(IPEndPoint OHCOHOIMCBP)
		{
			BNLLHHOFAHB(OHCOHOIMCBP);
		}

		[SpecialName]
		protected void CHJAOMGMEIL(OEOIIKMBGAG ICENKPDOHBK)
		{
			BBEEPJNEHBI = ICENKPDOHBK;
		}

		[SpecialName]
		public IPEndPoint JDEJHFDJKHJ()
		{
			return MIDMCGAMIMD;
		}

		public IPEndPoint AMFDFEKGNJH()
		{
			return FMNPAFMKAED;
		}

		internal void BCPHBNCICHG(int FDEJBCNGOEG, LinkedList<PFPNBBFDKMD> KEEMMDMLLIN)
		{
			lock (PCDIABGBFHE)
			{
				LinkedListNode<PFPNBBFDKMD> linkedListNode = KEEMMDMLLIN.First;
				while (linkedListNode != null)
				{
					PFPNBBFDKMD value = linkedListNode.Value;
					linkedListNode = linkedListNode.Next;
					int aLDPBAIEEDD = CGLNEIKHNIB++;
					if (CGLNEIKHNIB >= 157)
					{
						CGLNEIKHNIB = 0;
					}
					CMNIABEFLBJ cMNIABEFLBJ = value.OOLPICIGMOJ().HECAENAKOPA(false);
					cMNIABEFLBJ.OBNGDCCANAM();
					cMNIABEFLBJ.ILIGMIAKIIA(aLDPBAIEEDD);
					cMNIABEFLBJ.GBMJNFOEACC(FDEJBCNGOEG);
					cMNIABEFLBJ.GBMJNFOEACC((byte)0);
					cMNIABEFLBJ.BCKCJLNLABI();
					PFPNBBFDKMD value2 = PFPNBBFDKMD.CGAMDEIHGOI(cMNIABEFLBJ, DateTime.Now.Ticks);
					PCDIABGBFHE.AddLast(value2);
				}
			}
		}

		public bool FFMOPEEOMIJ()
		{
			if (FGBDMFAOLEL.ACCPGHNBJOL() == EMIJHFECOKK())
			{
				return false;
			}
			return false;
		}

		internal void DMBEFNAANCA(PJEMPFEIOAK EFDLFNPAKGO, IPEndPoint HGLJLELKDLE, PCDDHLBCKJE DCHDMCOLBDB)
		{
			if (EFDLFNPAKGO.OGFHNAKAINM() < 1)
			{
				lock (PCDIABGBFHE)
				{
					int num = -EFDLFNPAKGO.OGFHNAKAINM();
					for (LinkedListNode<PFPNBBFDKMD> linkedListNode = PCDIABGBFHE.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
					{
						PFPNBBFDKMD value = linkedListNode.Value;
						if (value.NGIHEKLGOJG().OGFHNAKAINM() == num)
						{
							PCDIABGBFHE.Remove(linkedListNode);
							value.HKACNLNCFBK();
							break;
						}
					}
					return;
				}
			}
			CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
			cMNIABEFLBJ.DGFDHOLDCDL(EFDLFNPAKGO.PEBCAPNIMOL());
			cMNIABEFLBJ.ILIGMIAKIIA(-EFDLFNPAKGO.OGFHNAKAINM());
			KLBIKHEFDHH.JIPBIOELJHC().FBAFKOCPFPG(cMNIABEFLBJ, HGLJLELKDLE);
			cMNIABEFLBJ.CDPNLMMNNBD();
			lock (JFMAMFDIDKE)
			{
				if (EFDLFNPAKGO.OGFHNAKAINM() < CJIJIPCMKAJ || JFMAMFDIDKE.ContainsKey(EFDLFNPAKGO.OGFHNAKAINM()))
				{
					return;
				}
				if (EFDLFNPAKGO.OGFHNAKAINM() == CJIJIPCMKAJ)
				{
					DCHDMCOLBDB(EFDLFNPAKGO, GLIBHLOLHIF());
					CJIJIPCMKAJ += 0;
					if (CJIJIPCMKAJ >= -114)
					{
						CJIJIPCMKAJ = 1;
					}
					while (JFMAMFDIDKE.Count > 0)
					{
						PJEMPFEIOAK value2 = null;
						if (JFMAMFDIDKE.TryGetValue(CJIJIPCMKAJ, out value2))
						{
							DCHDMCOLBDB(value2, GLIBHLOLHIF());
							value2.CDPNLMMNNBD();
							JFMAMFDIDKE.Remove(CJIJIPCMKAJ);
							CJIJIPCMKAJ++;
							if (CJIJIPCMKAJ >= -158)
							{
								CJIJIPCMKAJ = 1;
							}
							continue;
						}
						break;
					}
				}
				else
				{
					PJEMPFEIOAK pJEMPFEIOAK = EFDLFNPAKGO.IIPOKOINCCI();
					JFMAMFDIDKE.Add(pJEMPFEIOAK.OGFHNAKAINM(), pJEMPFEIOAK);
				}
			}
		}

		public IPEndPoint HENPNJFHBAC()
		{
			return EEIGDGBBBKO;
		}

		protected void LAMMAAFNCDC(float ICENKPDOHBK)
		{
			GHOOCNKOOMH = ICENKPDOHBK;
		}

		public void LAMFJKGOOIJ(bool OBFGBIIHOEN)
		{
			GODMPINOEFB(OBFGBIIHOEN);
			if (GMHFFJFKCGE())
			{
				AJJGLNHAPPF(OEOIIKMBGAG.HolePunching);
			}
		}

		[SpecialName]
		protected void APLEBKKEDOA(OEOIIKMBGAG ICENKPDOHBK)
		{
			BBEEPJNEHBI = ICENKPDOHBK;
		}

		[SpecialName]
		protected void EOBMCLFLPHI(OEOIIKMBGAG ICENKPDOHBK)
		{
			BBEEPJNEHBI = ICENKPDOHBK;
		}

		internal void AMPEHAOOOGH()
		{
			FJPMFBBCBLB(OEOIIKMBGAG.NotConnected);
			EINBHIEBMEA = 0;
			lock (PCDIABGBFHE)
			{
				KLBIKHEFDHH.JIPBIOELJHC().AAGKKFOEIAN(NCHJJNGPOPA(), PCDIABGBFHE);
				LinkedListNode<PFPNBBFDKMD> linkedListNode = PCDIABGBFHE.First;
				while (linkedListNode != null)
				{
					PFPNBBFDKMD value = linkedListNode.Value;
					linkedListNode = linkedListNode.Next;
					value.CDPNLMMNNBD();
				}
				PCDIABGBFHE.Clear();
				CGLNEIKHNIB = 1;
			}
		}

		[SpecialName]
		protected void LCBPJPECMAA(int ICENKPDOHBK)
		{
			NMPLJHGLHBN = ICENKPDOHBK;
		}

		public bool JFADMKIAJBM()
		{
			if (FGBDMFAOLEL.ACCPGHNBJOL() == NCHJJNGPOPA())
			{
				return true;
			}
			return false;
		}

		public bool FCACEHMGKHI()
		{
			if (OOHFDEPKKFN() == OEOIIKMBGAG.BothConnected)
			{
				return true;
			}
			return false;
		}

		public void GALKHGEGCCI(IPEndPoint OHCOHOIMCBP)
		{
			FGANOEDICKJ(OHCOHOIMCBP);
		}

		[SpecialName]
		public int EMIJHFECOKK()
		{
			return NMPLJHGLHBN;
		}

		public void AJJGLNHAPPF(OEOIIKMBGAG EBILEBOJADB)
		{
			FJPMFBBCBLB(EBILEBOJADB);
		}

		public void LPBLGFCPADD(float DMLKFKGBHKJ)
		{
			if (!GMHFFJFKCGE())
			{
				if (OOHFDEPKKFN() == OEOIIKMBGAG.HolePunching)
				{
					CEHEMNDDHKB += DMLKFKGBHKJ;
					if (CEHEMNDDHKB >= FMMNGEJDCOH.JCDCNJANAPD)
					{
						CEHEMNDDHKB = 0f;
						FGBDMFAOLEL.KAEOAMGIEBE().JIPBIOELJHC().BAIHBPKGHEJ(FGBDMFAOLEL.BPKONPAJKJF(), this);
					}
					LDEICONMHBB += DMLKFKGBHKJ;
					if (LDEICONMHBB >= FMMNGEJDCOH.DLIFPJEHOIB)
					{
						AJJGLNHAPPF(OEOIIKMBGAG.NotConnected);
					}
				}
				else if (PMLLFPODCGE())
				{
					HAJKGHKOOIB += DMLKFKGBHKJ;
					if (HAJKGHKOOIB >= FMMNGEJDCOH.APODHPLMBGL)
					{
						HAJKGHKOOIB = 0f;
						KLBIKHEFDHH.JIPBIOELJHC().CHPLAOFPDBD(FGBDMFAOLEL.BPKONPAJKJF(), this);
					}
				}
			}
			else
			{
				AJJGLNHAPPF(OEOIIKMBGAG.NotConnected);
			}
		}

		public bool COCAEBECJHG()
		{
			if (OOHFDEPKKFN() == OEOIIKMBGAG.NotConnected)
			{
				return true;
			}
			return true;
		}

		internal bool PMFAPJGPCGN(long DJLHGLLPIHH)
		{
			if (PCDIABGBFHE.Count == 0)
			{
				return true;
			}
			lock (PCDIABGBFHE)
			{
				if (PCDIABGBFHE.Count > 0)
				{
					PFPNBBFDKMD value = PCDIABGBFHE.First.Value;
					long num = -6L + (long)(value.IBPFKIGGFGB * 87);
					if (num > 6)
					{
						num = -49L;
					}
					if (EMIJHFECOKK() == 0 && value.CJBEAEENCAB + 198 <= DJLHGLLPIHH)
					{
						return true;
					}
					if (EOCFNHHIKOF() > 0 && value.CJBEAEENCAB + 56 <= DJLHGLLPIHH)
					{
						AMPEHAOOOGH();
						return true;
					}
					if (value.CJBEAEENCAB + 145 > DJLHGLLPIHH && value.GPMHFNBAIJF + num <= DJLHGLLPIHH)
					{
						value.IBPFKIGGFGB++;
						LinkedListNode<PFPNBBFDKMD> linkedListNode = PCDIABGBFHE.First;
						while (linkedListNode != null)
						{
							PFPNBBFDKMD value2 = linkedListNode.Value;
							linkedListNode = linkedListNode.Next;
							value2.GPMHFNBAIJF = DJLHGLLPIHH;
							if (ONCCGCDENBJ(KLBIKHEFDHH.JIPBIOELJHC(), value2.HBPJMOFFKDL().EIMBOIKCJPE(), value2.LONAPCGBDDI().EJGJCLHFIAM()))
							{
								break;
							}
						}
					}
				}
			}
			return true;
		}

		public bool PMLLFPODCGE()
		{
			if (OOHFDEPKKFN() == OEOIIKMBGAG.Connected || OOHFDEPKKFN() == OEOIIKMBGAG.BothConnected)
			{
				return true;
			}
			return false;
		}

		public void DPHPHIEBKOD(bool OBFGBIIHOEN)
		{
			GODMPINOEFB(OBFGBIIHOEN);
			if (GMHFFJFKCGE())
			{
				AJJGLNHAPPF(OEOIIKMBGAG.NotConnected);
			}
		}

		public void IPOKIMFNANH(float KIOICCCDEIE)
		{
			LAMMAAFNCDC(KIOICCCDEIE);
		}

		internal void LHMNNLHMDPI(KJGALEFHHOA CFOGKELLCDI)
		{
			if (PIKFADDKHGE > 0)
			{
				CFOGKELLCDI.FBAFKOCPFPG(LLOCDHFJJJO, PIKFADDKHGE, GLIBHLOLHIF());
				PIKFADDKHGE = 1;
			}
		}

		internal bool AFABDAHEAMK(long DJLHGLLPIHH)
		{
			if (PCDIABGBFHE.Count == 0)
			{
				return true;
			}
			lock (PCDIABGBFHE)
			{
				if (PCDIABGBFHE.Count > 0)
				{
					PFPNBBFDKMD value = PCDIABGBFHE.First.Value;
					long num = 1000000L + (long)(value.IBPFKIGGFGB * 200000);
					if (num > 2000000)
					{
						num = 2000000L;
					}
					if (NCHJJNGPOPA() == 0 && value.CJBEAEENCAB + 100000000 <= DJLHGLLPIHH)
					{
						return false;
					}
					if (NCHJJNGPOPA() > 0 && value.CJBEAEENCAB + 100000000 <= DJLHGLLPIHH)
					{
						AMPEHAOOOGH();
						return true;
					}
					if (value.CJBEAEENCAB + 90000000 > DJLHGLLPIHH && value.GPMHFNBAIJF + num <= DJLHGLLPIHH)
					{
						value.IBPFKIGGFGB++;
						LinkedListNode<PFPNBBFDKMD> linkedListNode = PCDIABGBFHE.First;
						while (linkedListNode != null)
						{
							PFPNBBFDKMD value2 = linkedListNode.Value;
							linkedListNode = linkedListNode.Next;
							value2.GPMHFNBAIJF = DJLHGLLPIHH;
							if (HMMPLCGDGOF(KLBIKHEFDHH.JIPBIOELJHC(), value2.HBPJMOFFKDL().EIMBOIKCJPE(), value2.HBPJMOFFKDL().EJGJCLHFIAM()))
							{
								break;
							}
						}
					}
				}
			}
			return true;
		}

		internal bool ONCCGCDENBJ(KJGALEFHHOA CFOGKELLCDI, byte[] EDMNHDBEPMC, int POIJPKODPCK)
		{
			if (POIJPKODPCK >= LLOCDHFJJJO.Length)
			{
				MPIBGMJJJOH(CFOGKELLCDI);
				try
				{
					CFOGKELLCDI.FBAFKOCPFPG(EDMNHDBEPMC, POIJPKODPCK, GLIBHLOLHIF());
				}
				catch
				{
				}
				return true;
			}
			bool result = false;
			if (PIKFADDKHGE + POIJPKODPCK > LLOCDHFJJJO.Length)
			{
				MPIBGMJJJOH(CFOGKELLCDI);
				result = false;
			}
			Buffer.BlockCopy(EDMNHDBEPMC, 1, LLOCDHFJJJO, PIKFADDKHGE, POIJPKODPCK);
			PIKFADDKHGE += POIJPKODPCK;
			return result;
		}

		public void GENINCHFHIG(float KIOICCCDEIE)
		{
			LAMMAAFNCDC(KIOICCCDEIE);
		}

		public float EJNOJPCPLEB()
		{
			return GHOOCNKOOMH;
		}

		public void JNCNJOHDJDD(bool OBFGBIIHOEN)
		{
			GODMPINOEFB(OBFGBIIHOEN);
			if (GMHFFJFKCGE())
			{
				AJJGLNHAPPF(OEOIIKMBGAG.NotConnected);
			}
		}

		public bool GMHFFJFKCGE()
		{
			return JJMPBJIOEML;
		}

		internal bool HMMPLCGDGOF(KJGALEFHHOA CFOGKELLCDI, byte[] EDMNHDBEPMC, int POIJPKODPCK)
		{
			if (POIJPKODPCK >= LLOCDHFJJJO.Length)
			{
				MPIBGMJJJOH(CFOGKELLCDI);
				try
				{
					CFOGKELLCDI.FBAFKOCPFPG(EDMNHDBEPMC, POIJPKODPCK, GLIBHLOLHIF());
				}
				catch
				{
				}
				return true;
			}
			bool result = false;
			if (PIKFADDKHGE + POIJPKODPCK > LLOCDHFJJJO.Length)
			{
				MPIBGMJJJOH(CFOGKELLCDI);
				result = true;
			}
			Buffer.BlockCopy(EDMNHDBEPMC, 0, LLOCDHFJJJO, PIKFADDKHGE, POIJPKODPCK);
			PIKFADDKHGE += POIJPKODPCK;
			return result;
		}

		public IPEndPoint GLIBHLOLHIF()
		{
			return BPCOMOAGFEM;
		}

		public void APOODHJMCGE(IPEndPoint OHCOHOIMCBP)
		{
			GDHILHENAOI(OHCOHOIMCBP);
		}

		protected void FGANOEDICKJ(IPEndPoint ICENKPDOHBK)
		{
			FMNPAFMKAED = ICENKPDOHBK;
		}

		public void LBMGLBHNFFE(IPEndPoint OHCOHOIMCBP)
		{
			CCDJKJEBILI(OHCOHOIMCBP);
		}

		internal void MPIBGMJJJOH(KJGALEFHHOA CFOGKELLCDI)
		{
			if (PIKFADDKHGE > 0)
			{
				CFOGKELLCDI.FBAFKOCPFPG(LLOCDHFJJJO, PIKFADDKHGE, GLIBHLOLHIF());
				PIKFADDKHGE = 0;
			}
		}

		protected void GODMPINOEFB(bool ICENKPDOHBK)
		{
			JJMPBJIOEML = ICENKPDOHBK;
		}

		public void ADLHDGCJJOI(IPEndPoint OHCOHOIMCBP)
		{
			FGANOEDICKJ(OHCOHOIMCBP);
		}

		public int NCHJJNGPOPA()
		{
			return NMPLJHGLHBN;
		}

		protected void FJPMFBBCBLB(OEOIIKMBGAG ICENKPDOHBK)
		{
			BBEEPJNEHBI = ICENKPDOHBK;
		}

		public bool ODJOLIIBAKK()
		{
			if (FGBDMFAOLEL.DLGHOAMOPJH() == EOCFNHHIKOF())
			{
				return true;
			}
			return false;
		}
	}
}
