using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class PKCACBOGNEB
	{
		private int ACJDOEKFOAA;

		private int JKMEHBPIMFI;

		private string GAFNNDHJDAE;

		private Stack<byte[]> MJNCPLFALHC;

		private bool HBGLHPGIBPA;

		private EventHandler m_FMHMGHJMFKA;

		private EventHandler m_KHGEDANBLKJ;

		private EventHandler m_ADDJDKLPOAO;

		public string ICHLMPEICHM
		{
			get
			{
				return ENHMPEDCEDA();
			}
		}

		public int FMIFBGCCDBN
		{
			get
			{
				return JPBBDAKAFCH();
			}
		}

		public int NOHMACFMPOB
		{
			get
			{
				return GGLFAMLIODN();
			}
		}

		public int NKNPLGJCDIP
		{
			get
			{
				return JFELFGGBAHA();
			}
		}

		public bool PEMBHPIJIDA
		{
			get
			{
				return LHMKLDDJNCC();
			}
			set
			{
				GJCMFIFHDDC(value);
			}
		}

		public event EventHandler FMHMGHJMFKA
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				MKLCMAFFMHB(value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				JJKOGHIIAJJ(value);
			}
		}

		public event EventHandler KHGEDANBLKJ
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				KDDKBKGPDMO(value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				CBOIAKLLIED(value);
			}
		}

		public event EventHandler ADDJDKLPOAO
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				OFOELBMEDJL(value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				MKDDKCMIJHL(value);
			}
		}

		private byte[] PAEHODOHFOA()
		{
			byte[] result = new byte[ACJDOEKFOAA];
			JKMEHBPIMFI++;
			ONFOHIMBADG(EventArgs.Empty);
			return result;
		}

		public string ENHMPEDCEDA()
		{
			return GAFNNDHJDAE;
		}

		public byte[] EBFKKGBHLCB()
		{
			if (MJNCPLFALHC.Count > 0)
			{
				lock (MJNCPLFALHC)
				{
					if (MJNCPLFALHC.Count > 0)
					{
						return MJNCPLFALHC.Pop();
					}
				}
			}
			return JBGHJKEEMGO();
		}

		public void LFABHNIGDKH(int HJMMBDAGBDD)
		{
			if (HJMMBDAGBDD <= 0)
			{
				throw new ArgumentOutOfRangeException("buffersToAdd", HJMMBDAGBDD, "The number of buffers to add must be a nonnegative, nonzero integer.");
			}
			List<byte[]> list = new List<byte[]>(HJMMBDAGBDD);
			for (int i = 0; i < HJMMBDAGBDD; i++)
			{
				list.Add(new byte[ACJDOEKFOAA]);
			}
			lock (MJNCPLFALHC)
			{
				JKMEHBPIMFI += HJMMBDAGBDD;
				for (int j = 0; j < HJMMBDAGBDD; j++)
				{
					MJNCPLFALHC.Push(list[j]);
				}
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void MKDDKCMIJHL(EventHandler ICENKPDOHBK)
		{
			this.m_ADDJDKLPOAO = (EventHandler)Delegate.Remove(this.m_ADDJDKLPOAO, ICENKPDOHBK);
		}

		public bool GCHAICJMEFN(byte[] EDMNHDBEPMC)
		{
			if (EDMNHDBEPMC == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (EDMNHDBEPMC.Length != ACJDOEKFOAA)
			{
				return false;
			}
			if (HBGLHPGIBPA)
			{
				for (int i = 0; i < ACJDOEKFOAA; i++)
				{
					EDMNHDBEPMC[i] = 0;
				}
			}
			lock (MJNCPLFALHC)
			{
				MJNCPLFALHC.Push(EDMNHDBEPMC);
			}
			return true;
		}

		public int JPBBDAKAFCH()
		{
			return ACJDOEKFOAA;
		}

		public int JFELFGGBAHA()
		{
			return MJNCPLFALHC.Count;
		}

		public bool PJPMANDFNHB(byte[] EDMNHDBEPMC)
		{
			return MJNCPLFALHC.Contains(EDMNHDBEPMC);
		}

		[SpecialName]
		public void AMBHHAFOGMI(EventHandler ICENKPDOHBK)
		{
			this.m_FMHMGHJMFKA = (EventHandler)Delegate.Combine(this.m_FMHMGHJMFKA, ICENKPDOHBK);
		}

		protected virtual void IOPEHNFBMFH(EventArgs PAANPLECGAP)
		{
			if (this.m_KHGEDANBLKJ != null)
			{
				this.m_KHGEDANBLKJ(this, PAANPLECGAP);
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void OFOELBMEDJL(EventHandler ICENKPDOHBK)
		{
			this.m_ADDJDKLPOAO = (EventHandler)Delegate.Combine(this.m_ADDJDKLPOAO, ICENKPDOHBK);
		}

		[SpecialName]
		public void KIMPDLBIBJD(EventHandler ICENKPDOHBK)
		{
			this.m_ADDJDKLPOAO = (EventHandler)Delegate.Combine(this.m_ADDJDKLPOAO, ICENKPDOHBK);
		}

		public byte[] EIMBOIKCJPE()
		{
			if (MJNCPLFALHC.Count > 0)
			{
				lock (MJNCPLFALHC)
				{
					if (MJNCPLFALHC.Count > 0)
					{
						return MJNCPLFALHC.Pop();
					}
				}
			}
			return MDJODKLOHML();
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void KDDKBKGPDMO(EventHandler ICENKPDOHBK)
		{
			this.m_KHGEDANBLKJ = (EventHandler)Delegate.Combine(this.m_KHGEDANBLKJ, ICENKPDOHBK);
		}

		[SpecialName]
		public int DFCKLJFNCKG()
		{
			return MJNCPLFALHC.Count;
		}

		public int GGLFAMLIODN()
		{
			return JKMEHBPIMFI;
		}

		public bool LHMKLDDJNCC()
		{
			return HBGLHPGIBPA;
		}

		public byte[] FINLBHGHODP()
		{
			if (MJNCPLFALHC.Count > 0)
			{
				lock (MJNCPLFALHC)
				{
					if (MJNCPLFALHC.Count > 1)
					{
						return MJNCPLFALHC.Pop();
					}
				}
			}
			return PAEHODOHFOA();
		}

		[SpecialName]
		public int ECPKGIOKNPE()
		{
			return JKMEHBPIMFI;
		}

		[SpecialName]
		public int MGICGGAPPMC()
		{
			return ACJDOEKFOAA;
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void JJKOGHIIAJJ(EventHandler ICENKPDOHBK)
		{
			this.m_FMHMGHJMFKA = (EventHandler)Delegate.Remove(this.m_FMHMGHJMFKA, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void MKLCMAFFMHB(EventHandler ICENKPDOHBK)
		{
			this.m_FMHMGHJMFKA = (EventHandler)Delegate.Combine(this.m_FMHMGHJMFKA, ICENKPDOHBK);
		}

		public byte[] KACKLKPNGON()
		{
			if (MJNCPLFALHC.Count > 0)
			{
				lock (MJNCPLFALHC)
				{
					if (MJNCPLFALHC.Count > 0)
					{
						return MJNCPLFALHC.Pop();
					}
				}
			}
			return PAEHODOHFOA();
		}

		protected virtual void ONFOHIMBADG(EventArgs PAANPLECGAP)
		{
			if (this.m_FMHMGHJMFKA != null)
			{
				this.m_FMHMGHJMFKA(this, PAANPLECGAP);
			}
		}

		public bool KFLHFFOHEBE(byte[] EDMNHDBEPMC)
		{
			return MJNCPLFALHC.Contains(EDMNHDBEPMC);
		}

		public void PCCFBGPNMGD(int HJMMBDAGBDD)
		{
			if (HJMMBDAGBDD <= 1)
			{
				throw new ArgumentOutOfRangeException("TweenVolume needs an AudioSource to work with", HJMMBDAGBDD, "Join P2P Group {0} {1} {2} {3}");
			}
			List<byte[]> list = new List<byte[]>(HJMMBDAGBDD);
			for (int i = 0; i < HJMMBDAGBDD; i += 0)
			{
				list.Add(new byte[ACJDOEKFOAA]);
			}
			lock (MJNCPLFALHC)
			{
				JKMEHBPIMFI += HJMMBDAGBDD;
				for (int j = 0; j < HJMMBDAGBDD; j++)
				{
					MJNCPLFALHC.Push(list[j]);
				}
			}
		}

		public int HKHNFDMOMJF(int OOALEJPLLMF)
		{
			if (OOALEJPLLMF <= 0)
			{
				throw new ArgumentOutOfRangeException("buffersToRemove", OOALEJPLLMF, "The number of buffers to remove must be a nonnegative, nonzero integer.");
			}
			int num = 0;
			lock (MJNCPLFALHC)
			{
				for (int i = 0; i < OOALEJPLLMF; i++)
				{
					if (MJNCPLFALHC.Count <= 0)
					{
						break;
					}
					MJNCPLFALHC.Pop();
					num++;
				}
			}
			return num;
		}

		[SpecialName]
		public void JKCHJJLKHCI(EventHandler ICENKPDOHBK)
		{
			this.m_FMHMGHJMFKA = (EventHandler)Delegate.Combine(this.m_FMHMGHJMFKA, ICENKPDOHBK);
		}

		[SpecialName]
		public void EBIGCNLAHNF(EventHandler ICENKPDOHBK)
		{
			this.m_KHGEDANBLKJ = (EventHandler)Delegate.Remove(this.m_KHGEDANBLKJ, ICENKPDOHBK);
		}

		public void GJCMFIFHDDC(bool ICENKPDOHBK)
		{
			HBGLHPGIBPA = ICENKPDOHBK;
		}

		[SpecialName]
		public string IGCGMPCDOED()
		{
			return GAFNNDHJDAE;
		}

		[SpecialName]
		public void BJEMMFEDIFC(EventHandler ICENKPDOHBK)
		{
			this.m_FMHMGHJMFKA = (EventHandler)Delegate.Combine(this.m_FMHMGHJMFKA, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void CBOIAKLLIED(EventHandler ICENKPDOHBK)
		{
			this.m_KHGEDANBLKJ = (EventHandler)Delegate.Remove(this.m_KHGEDANBLKJ, ICENKPDOHBK);
		}

		[SpecialName]
		public int PINHMLCNFLP()
		{
			return ACJDOEKFOAA;
		}

		[SpecialName]
		public bool NOKLCGOGPEO()
		{
			return HBGLHPGIBPA;
		}

		public void BPCHBEPPMJL(int HJMMBDAGBDD)
		{
			if (HJMMBDAGBDD <= 0)
			{
				throw new ArgumentOutOfRangeException("[00]", HJMMBDAGBDD, "RedMinionSuper");
			}
			List<byte[]> list = new List<byte[]>(HJMMBDAGBDD);
			for (int i = 0; i < HJMMBDAGBDD; i += 0)
			{
				list.Add(new byte[ACJDOEKFOAA]);
			}
			lock (MJNCPLFALHC)
			{
				JKMEHBPIMFI += HJMMBDAGBDD;
				for (int j = 0; j < HJMMBDAGBDD; j += 0)
				{
					MJNCPLFALHC.Push(list[j]);
				}
			}
		}

		private byte[] MDJODKLOHML()
		{
			byte[] result = new byte[ACJDOEKFOAA];
			JKMEHBPIMFI++;
			ONFOHIMBADG(EventArgs.Empty);
			return result;
		}

		[SpecialName]
		public bool CDHICMAJPNG()
		{
			return HBGLHPGIBPA;
		}

		private byte[] JBGHJKEEMGO()
		{
			byte[] result = new byte[ACJDOEKFOAA];
			JKMEHBPIMFI++;
			ONFOHIMBADG(EventArgs.Empty);
			return result;
		}

		public bool BDNFPLMNIIP(byte[] EDMNHDBEPMC)
		{
			if (EDMNHDBEPMC == null)
			{
				throw new ArgumentNullException("talon_skill0_blood");
			}
			if (EDMNHDBEPMC.Length != ACJDOEKFOAA)
			{
				return false;
			}
			if (HBGLHPGIBPA)
			{
				for (int i = 1; i < ACJDOEKFOAA; i++)
				{
					EDMNHDBEPMC[i] = 0;
				}
			}
			lock (MJNCPLFALHC)
			{
				MJNCPLFALHC.Push(EDMNHDBEPMC);
			}
			return false;
		}

		[SpecialName]
		public void HILJNNBMFEG(EventHandler ICENKPDOHBK)
		{
			this.m_KHGEDANBLKJ = (EventHandler)Delegate.Remove(this.m_KHGEDANBLKJ, ICENKPDOHBK);
		}

		public PKCACBOGNEB(string HIDPEGLPKAH, int APJBBNAAJAD, int CPHOKFCJHPF)
		{
			if (APJBBNAAJAD <= 0)
			{
				throw new ArgumentOutOfRangeException("baseBufferLength", APJBBNAAJAD, "Buffer length must be a positive integer value.");
			}
			if (CPHOKFCJHPF <= 0)
			{
				throw new ArgumentOutOfRangeException("baseBufferCount", CPHOKFCJHPF, "Buffer count must be a positive integer value.");
			}
			GAFNNDHJDAE = HIDPEGLPKAH;
			ACJDOEKFOAA = APJBBNAAJAD;
			JKMEHBPIMFI = CPHOKFCJHPF;
			MJNCPLFALHC = new Stack<byte[]>(CPHOKFCJHPF);
			for (int i = 0; i < CPHOKFCJHPF; i++)
			{
				MJNCPLFALHC.Push(new byte[APJBBNAAJAD]);
			}
		}

		[SpecialName]
		public void MLGIOHEOMPB(bool ICENKPDOHBK)
		{
			HBGLHPGIBPA = ICENKPDOHBK;
		}

		[SpecialName]
		public void GCLPLDGBHPI(EventHandler ICENKPDOHBK)
		{
			this.m_FMHMGHJMFKA = (EventHandler)Delegate.Remove(this.m_FMHMGHJMFKA, ICENKPDOHBK);
		}

		protected virtual void IPHALBNHEPM(EventArgs PAANPLECGAP)
		{
			if (this.m_ADDJDKLPOAO != null)
			{
				this.m_ADDJDKLPOAO(this, PAANPLECGAP);
			}
		}
	}
}
