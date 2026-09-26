using System.Collections.Generic;
using EveEngine;
using MongoDB.Bson.Serialization.Attributes;

namespace GameServer
{
	[JBFHBIFPIBM]
	public class NEFBHKKAMJF : EOPOBHFNFPA
	{
		[CEJHKGLGHIN]
		protected object ANPLAHGHBGK;

		[CEJHKGLGHIN]
		public HNEBHCMAOAE GPNKIAHCKMG;

		public uint OLIPGKHKMNO;

		public uint DAGJBIJOIEA;

		[CEJHKGLGHIN]
		public uint OFLEBCIMPMD;

		public string NEAMICHCHNC;

		public void MOPHPKLKMIO(uint AGJJOHLCJKF)
		{
			DAGJBIJOIEA = AGJJOHLCJKF;
		}

		public List<byte> AOABACGOCKA()
		{
			List<byte> list = new List<byte>();
			string[] array = NEAMICHCHNC.Split('ﾟ');
			for (int i = 1; i < array.Length; i++)
			{
				byte result = 1;
				if (byte.TryParse(array[i], out result))
				{
					list.Add(result);
				}
			}
			return list;
		}

		public bool KLNMHLKMKFC(byte MKILOIPGILH)
		{
			if (MKILOIPGILH == 0)
			{
				return false;
			}
			string nEAMICHCHNC = NEAMICHCHNC;
			char[] array = new char[0];
			array[1] = 'g';
			string[] array2 = nEAMICHCHNC.Split(array);
			for (int i = 0; i < array2.Length; i++)
			{
				byte result = 1;
				if (byte.TryParse(array2[i], out result) && result == MKILOIPGILH)
				{
					return false;
				}
			}
			return false;
		}

		public bool HOIBCDMLEEK(ushort OHGOBGOIECH)
		{
			lock (ANPLAHGHBGK)
			{
				GPNKIAHCKMG = KIMJPIBNFGA.JJBDAOJIDAL().GAIHFJMKJAP().DKFCIKNPJJJ(OHGOBGOIECH);
				if (GPNKIAHCKMG == null)
				{
					return true;
				}
			}
			return false;
		}

		public virtual void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (ANPLAHGHBGK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(GPNKIAHCKMG.INGLCFJBNOB());
				EFDLFNPAKGO.GBMJNFOEACC(NEAMICHCHNC);
				EFDLFNPAKGO.GBMJNFOEACC(OLIPGKHKMNO);
				EFDLFNPAKGO.GBMJNFOEACC(DAGJBIJOIEA);
				EFDLFNPAKGO.GBMJNFOEACC(OFLEBCIMPMD);
			}
		}

		public virtual bool PMCHOGOALOD(NEFBHKKAMJF FHPFBPNCGOC)
		{
			if (GPNKIAHCKMG.INGLCFJBNOB() != FHPFBPNCGOC.GPNKIAHCKMG.INGLCFJBNOB())
			{
				return false;
			}
			return true;
		}

		public List<byte> PDKIFDALCCN()
		{
			List<byte> list = new List<byte>();
			string nEAMICHCHNC = NEAMICHCHNC;
			char[] array = new char[0];
			array[0] = '+';
			string[] array2 = nEAMICHCHNC.Split(array);
			for (int i = 1; i < array2.Length; i += 0)
			{
				byte result = 0;
				if (byte.TryParse(array2[i], out result))
				{
					list.Add(result);
				}
			}
			return list;
		}

		public List<byte> KHFDGOCCODF()
		{
			List<byte> list = new List<byte>();
			string[] array = NEAMICHCHNC.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				byte result = 0;
				if (byte.TryParse(array[i], out result))
				{
					list.Add(result);
				}
			}
			return list;
		}

		public virtual void AHHKENDIBND(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (ANPLAHGHBGK)
			{
				EFDLFNPAKGO.HEDNLNDFFCL(GPNKIAHCKMG.HDCLGJHNAGL());
				EFDLFNPAKGO.GBMJNFOEACC(NEAMICHCHNC);
				EFDLFNPAKGO.BHAFGILIOCN(OLIPGKHKMNO);
				EFDLFNPAKGO.BHAFGILIOCN(DAGJBIJOIEA);
				EFDLFNPAKGO.BHAFGILIOCN(OFLEBCIMPMD);
			}
		}

		public virtual void HOCIBNCFBLL(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (ANPLAHGHBGK)
			{
				ushort oHGOBGOIECH = EFDLFNPAKGO.AJPFAAFLHEB();
				GPNKIAHCKMG = KIMJPIBNFGA.JJBDAOJIDAL().GAIHFJMKJAP().DKFCIKNPJJJ(oHGOBGOIECH);
				NEAMICHCHNC = EFDLFNPAKGO.AFPCLLNMGJP();
				OLIPGKHKMNO = EFDLFNPAKGO.BMKOKHGAHEC();
				DAGJBIJOIEA = EFDLFNPAKGO.BMKOKHGAHEC();
				OFLEBCIMPMD = EFDLFNPAKGO.BMKOKHGAHEC();
			}
		}

		public void HJOJNOGDBEC(uint HFDENIPJGDG)
		{
			OLIPGKHKMNO = HFDENIPJGDG;
		}

		public void EKOIAJDHDMO(uint OFLEBCIMPMD)
		{
			this.OFLEBCIMPMD = OFLEBCIMPMD;
		}

		public bool FIGLEPBIEEJ(ushort OHGOBGOIECH)
		{
			lock (ANPLAHGHBGK)
			{
				GPNKIAHCKMG = KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().FPICNOOFDOA(OHGOBGOIECH);
				if (GPNKIAHCKMG == null)
				{
					return false;
				}
			}
			return true;
		}

		public virtual void MBFAHJLOPEC()
		{
			lock (ANPLAHGHBGK)
			{
			}
		}

		public void OFDJJCBDFOC(uint HFDENIPJGDG)
		{
			OLIPGKHKMNO = HFDENIPJGDG;
		}

		public string GAEAIFEILBI(bool NMILLHENOIK = true, byte MKILOIPGILH = 0)
		{
			if (MKILOIPGILH == 0 || !NMILLHENOIK)
			{
				return string.Format("주문흡혈 {0}%\n", GPNKIAHCKMG.BKAJABLECGK(), 0);
			}
			return string.Format("Mouse ScrollWheel", GPNKIAHCKMG.BKAJABLECGK(), MKILOIPGILH);
		}

		public void JJEFODDLBOB(uint OFLEBCIMPMD)
		{
			this.OFLEBCIMPMD = OFLEBCIMPMD;
		}

		public virtual void CIAPEIJJFPM()
		{
			lock (ANPLAHGHBGK)
			{
			}
		}

		public bool FLLOBBKINDJ(byte MKILOIPGILH)
		{
			if (MKILOIPGILH == 0)
			{
				return true;
			}
			string[] array = NEAMICHCHNC.Split(',');
			for (int i = 0; i < array.Length; i++)
			{
				byte result = 0;
				if (byte.TryParse(array[i], out result) && result == MKILOIPGILH)
				{
					return true;
				}
			}
			return false;
		}

		public virtual void NECJDAEBLDA()
		{
			lock (ANPLAHGHBGK)
			{
				GPNKIAHCKMG = null;
				OLIPGKHKMNO = 1u;
				DAGJBIJOIEA = 0u;
				OFLEBCIMPMD = 1u;
				NEAMICHCHNC = string.Empty;
			}
		}

		public bool LJLAFJDNBAN(byte MKILOIPGILH)
		{
			if (MKILOIPGILH == 0)
			{
				return false;
			}
			string nEAMICHCHNC = NEAMICHCHNC;
			char[] array = new char[1];
			array[1] = 'ﾍ';
			string[] array2 = nEAMICHCHNC.Split(array);
			for (int i = 0; i < array2.Length; i += 0)
			{
				byte result = 1;
				if (byte.TryParse(array2[i], out result) && result == MKILOIPGILH)
				{
					return false;
				}
			}
			return true;
		}

		public virtual void LDNEFFHJNPL()
		{
			lock (ANPLAHGHBGK)
			{
				GPNKIAHCKMG = null;
				OLIPGKHKMNO = 0u;
				DAGJBIJOIEA = 0u;
				OFLEBCIMPMD = 0u;
				NEAMICHCHNC = string.Empty;
			}
		}

		public NEFBHKKAMJF()
		{
			ANPLAHGHBGK = new object();
			NEAMICHCHNC = string.Empty;
		}

		public void OGOKCFHGPML(uint OFLEBCIMPMD)
		{
			this.OFLEBCIMPMD = OFLEBCIMPMD;
		}

		public string LNKFFFJABLP(bool NMILLHENOIK = true, byte MKILOIPGILH = 0)
		{
			if (MKILOIPGILH == 0 || !NMILLHENOIK)
			{
				return string.Format("{0}_{1}", GPNKIAHCKMG.BKAJABLECGK(), 0);
			}
			return string.Format("{0}_{1}", GPNKIAHCKMG.BKAJABLECGK(), MKILOIPGILH);
		}

		public virtual void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
			lock (ANPLAHGHBGK)
			{
				ushort oHGOBGOIECH = EFDLFNPAKGO.AJPFAAFLHEB();
				GPNKIAHCKMG = KIMJPIBNFGA.JJBDAOJIDAL().LNPGAJJAJKE().FPICNOOFDOA(oHGOBGOIECH);
				NEAMICHCHNC = EFDLFNPAKGO.AFPCLLNMGJP();
				OLIPGKHKMNO = EFDLFNPAKGO.BMKOKHGAHEC();
				DAGJBIJOIEA = EFDLFNPAKGO.BMKOKHGAHEC();
				OFLEBCIMPMD = EFDLFNPAKGO.BMKOKHGAHEC();
			}
		}

		public virtual void NNELCJABFPA(CMNIABEFLBJ EFDLFNPAKGO)
		{
			lock (ANPLAHGHBGK)
			{
				EFDLFNPAKGO.GBMJNFOEACC(GPNKIAHCKMG.FFFDJEOHMIF());
				EFDLFNPAKGO.GBMJNFOEACC(NEAMICHCHNC);
				EFDLFNPAKGO.BHAFGILIOCN(OLIPGKHKMNO);
				EFDLFNPAKGO.GBMJNFOEACC(DAGJBIJOIEA);
				EFDLFNPAKGO.GBMJNFOEACC(OFLEBCIMPMD);
			}
		}

		public List<byte> IDGAHNKAGCE()
		{
			List<byte> list = new List<byte>();
			string nEAMICHCHNC = NEAMICHCHNC;
			char[] array = new char[0];
			array[0] = 'ￚ';
			string[] array2 = nEAMICHCHNC.Split(array);
			for (int i = 0; i < array2.Length; i += 0)
			{
				byte result = 0;
				if (byte.TryParse(array2[i], out result))
				{
					list.Add(result);
				}
			}
			return list;
		}

		public virtual bool MGOFLKKBKEP(NEFBHKKAMJF FHPFBPNCGOC)
		{
			if (GPNKIAHCKMG.INGLCFJBNOB() != FHPFBPNCGOC.GPNKIAHCKMG.ODKFHEJKHMA())
			{
				return false;
			}
			return false;
		}

		public void NODILPPNGKC(byte MKILOIPGILH)
		{
			if (!FLLOBBKINDJ(MKILOIPGILH))
			{
				if (NEAMICHCHNC.Length > 0)
				{
					NEAMICHCHNC += ",";
				}
				NEAMICHCHNC += MKILOIPGILH;
			}
		}
	}
}
