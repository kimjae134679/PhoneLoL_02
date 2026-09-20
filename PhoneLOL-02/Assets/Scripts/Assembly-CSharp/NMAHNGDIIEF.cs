using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class NMAHNGDIIEF
{
	public const int AKEJHCPLAFH = 1000;

	private bool EBNDGHKKIPG;

	internal List<object> GMJOHJJGBMK;

	private byte LDOLAEGOFOL;

	protected MemoryStream CJOFIDKNECK;

	protected BinaryReader JEJNNDANAPE;

	protected BinaryWriter IPDNOLCLJNB;

	private int BIPBLFLPMPM;

	public bool JEOKBGHLGNM
	{
		get
		{
			return BNENHLMHIII();
		}
	}

	public bool KCMEOKODPNN
	{
		get
		{
			return JAJFFNNJLKC();
		}
	}

	public int DMLNPGBBAME
	{
		get
		{
			return FBEELGMLHIC();
		}
	}

	public void FDDJMJJGKCL(ref ObscuredByte HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			byte b = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(b);
			IPDNOLCLJNB.Write(b);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadByte();
		}
	}

	public void FDDJMJJGKCL(ref bool IIPNBNBEBOI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(IIPNBNBEBOI);
			IPDNOLCLJNB.Write(IIPNBNBEBOI);
		}
		else
		{
			IIPNBNBEBOI = JEJNNDANAPE.ReadBoolean();
		}
	}

	public void FDDJMJJGKCL(ref ObscuredInt HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			int num = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(num);
			IPDNOLCLJNB.Write(num);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadInt32();
		}
	}

	public void NFKKIPFHBIF()
	{
		GMJOHJJGBMK.Clear();
		LDOLAEGOFOL = 0;
		CJOFIDKNECK.Position = 1L;
	}

	public void PKLIADIGLOG(ref int PPCCJNLEMGO)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(PPCCJNLEMGO);
			IPDNOLCLJNB.Write(PPCCJNLEMGO);
		}
		else
		{
			PPCCJNLEMGO = JEJNNDANAPE.ReadInt32();
		}
	}

	public byte[] EIMBOIKCJPE()
	{
		return CJOFIDKNECK.GetBuffer();
	}

	public void FDDJMJJGKCL(ref char ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadChar();
		}
	}

	public void CAJCOCDJNKL()
	{
		GMJOHJJGBMK.Clear();
		LDOLAEGOFOL = 0;
		CJOFIDKNECK.Position = 0L;
	}

	public void EIJLIIFFJDD(ref ObscuredByte HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			byte b = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(b);
			IPDNOLCLJNB.Write(b);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadByte();
		}
	}

	public bool BNENHLMHIII()
	{
		return EBNDGHKKIPG;
	}

	public void FDDJMJJGKCL(ref Vector2 HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.x);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.y);
		}
		else
		{
			HCKCCHPJOPI.x = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.y = JEJNNDANAPE.ReadSingle();
		}
	}

	public void DCLOBNIFOEB(ref uint PPCCJNLEMGO)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(PPCCJNLEMGO);
			IPDNOLCLJNB.Write(PPCCJNLEMGO);
		}
		else
		{
			PPCCJNLEMGO = JEJNNDANAPE.ReadUInt32();
		}
	}

	public void PKJGJONDENE(ref Vector2 HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.x);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.y);
		}
		else
		{
			HCKCCHPJOPI.x = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.y = JEJNNDANAPE.ReadSingle();
		}
	}

	public void FDDJMJJGKCL(ref uint PPCCJNLEMGO)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(PPCCJNLEMGO);
			IPDNOLCLJNB.Write(PPCCJNLEMGO);
		}
		else
		{
			PPCCJNLEMGO = JEJNNDANAPE.ReadUInt32();
		}
	}

	public void FDDJMJJGKCL(ref float HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadSingle();
		}
	}

	public void PDCPMDCOLOD()
	{
		GMJOHJJGBMK.Clear();
		LDOLAEGOFOL = 0;
		CJOFIDKNECK.Position = 0L;
	}

	public void HCBNCGILGEJ(byte[] EDMNHDBEPMC, int BFEECILPJLM, int AGJJOHLCJKF)
	{
		CJOFIDKNECK.Write(EDMNHDBEPMC, BFEECILPJLM, AGJJOHLCJKF);
		CJOFIDKNECK.Position = 0L;
	}

	public void FDDJMJJGKCL(ref ObscuredUShort HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			ushort num = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(num);
			IPDNOLCLJNB.Write(num);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadUInt16();
		}
	}

	public void JGANEHHDOBK(ref Quaternion HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.x);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.y);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.z);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.w);
		}
		else
		{
			HCKCCHPJOPI.x = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.y = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.z = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.w = JEJNNDANAPE.ReadSingle();
		}
	}

	public bool JAJFFNNJLKC()
	{
		return !EBNDGHKKIPG;
	}

	public int FBEELGMLHIC()
	{
		return GMJOHJJGBMK.Count;
	}

	public void FDDJMJJGKCL(ref short ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt16();
		}
	}

	public void OOIFNKCJMJP(ref bool IIPNBNBEBOI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(IIPNBNBEBOI);
			IPDNOLCLJNB.Write(IIPNBNBEBOI);
		}
		else
		{
			IIPNBNBEBOI = JEJNNDANAPE.ReadBoolean();
		}
	}

	public void HNIFGMHGNHB()
	{
		GMJOHJJGBMK.Clear();
		LDOLAEGOFOL = 1;
		CJOFIDKNECK.Position = 1L;
	}

	public void CJBMAGMAKAK(ref bool IIPNBNBEBOI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(IIPNBNBEBOI);
			IPDNOLCLJNB.Write(IIPNBNBEBOI);
		}
		else
		{
			IIPNBNBEBOI = JEJNNDANAPE.ReadBoolean();
		}
	}

	public void HCACJDCFAKH(ref Vector3 HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.x);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.y);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.z);
		}
		else
		{
			HCKCCHPJOPI.x = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.y = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.z = JEJNNDANAPE.ReadSingle();
		}
	}

	public void FDDJMJJGKCL(ref byte ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadByte();
		}
	}

	public void FDDJMJJGKCL(ref ObscuredFloat HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			float num = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(num);
			IPDNOLCLJNB.Write(num);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadSingle();
		}
	}

	public void CANBGEOBDEE(ref short ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt16();
		}
	}

	[SpecialName]
	public int PGOEHOBFJFB()
	{
		return GMJOHJJGBMK.Count;
	}

	[SpecialName]
	public int LFCGNHLHFGK()
	{
		return GMJOHJJGBMK.Count;
	}

	public void FDDJMJJGKCL(ref Vector3 HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.x);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.y);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.z);
		}
		else
		{
			HCKCCHPJOPI.x = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.y = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.z = JEJNNDANAPE.ReadSingle();
		}
	}

	[SpecialName]
	public int LEMLHLOIAOL()
	{
		return GMJOHJJGBMK.Count;
	}

	public void NPOBBAGLIJI(byte[] EDMNHDBEPMC, int BFEECILPJLM, int AGJJOHLCJKF)
	{
		CJOFIDKNECK.Write(EDMNHDBEPMC, BFEECILPJLM, AGJJOHLCJKF);
		CJOFIDKNECK.Position = 1L;
	}

	public object[] OANJFMIDNBB()
	{
		return GMJOHJJGBMK.ToArray();
	}

	public void FOFAHOKLLLG(ref ObscuredBool HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			bool flag = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(flag);
			IPDNOLCLJNB.Write(flag);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadBoolean();
		}
	}

	public void INHGLLCNOBJ(ref int PPCCJNLEMGO)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(PPCCJNLEMGO);
			IPDNOLCLJNB.Write(PPCCJNLEMGO);
		}
		else
		{
			PPCCJNLEMGO = JEJNNDANAPE.ReadInt32();
		}
	}

	public void HBIEFFCPCAB(int CMGMOJAFLFL)
	{
		CJOFIDKNECK.Position = CMGMOJAFLFL;
	}

	public void NEPLPLEJJID(ref float HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadSingle();
		}
	}

	public NMAHNGDIIEF(bool EBNDGHKKIPG, object[] BJOKNLKNNLG)
	{
		this.EBNDGHKKIPG = EBNDGHKKIPG;
		if (BJOKNLKNNLG == null)
		{
			GMJOHJJGBMK = new List<object>();
		}
		else
		{
			GMJOHJJGBMK = new List<object>(BJOKNLKNNLG);
		}
		CJOFIDKNECK = new MemoryStream(1000);
		JEJNNDANAPE = new BinaryReader(CJOFIDKNECK);
		IPDNOLCLJNB = new BinaryWriter(CJOFIDKNECK);
	}

	public int EJGJCLHFIAM()
	{
		return (int)CJOFIDKNECK.Position;
	}

	public void HLEJPIJLPBH(ref short ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt16();
		}
	}

	public void CPJPBLPJHHO(ref ushort ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadUInt16();
		}
	}

	public void FDDJMJJGKCL(ref int PPCCJNLEMGO)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(PPCCJNLEMGO);
			IPDNOLCLJNB.Write(PPCCJNLEMGO);
		}
		else
		{
			PPCCJNLEMGO = JEJNNDANAPE.ReadInt32();
		}
	}

	public void MHELCCFGKKG(int CMGMOJAFLFL)
	{
		CJOFIDKNECK.Position = CMGMOJAFLFL;
	}

	public void FDDJMJJGKCL(ref ObscuredBool HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			bool flag = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(flag);
			IPDNOLCLJNB.Write(flag);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadBoolean();
		}
	}

	public void HEDNKMBJEPO(ref ObscuredByte HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			byte b = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(b);
			IPDNOLCLJNB.Write(b);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadByte();
		}
	}

	public void JCGPNKHBDCN(ref uint PPCCJNLEMGO)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(PPCCJNLEMGO);
			IPDNOLCLJNB.Write(PPCCJNLEMGO);
		}
		else
		{
			PPCCJNLEMGO = JEJNNDANAPE.ReadUInt32();
		}
	}

	public void FDDJMJJGKCL(ref string ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			if (ICENKPDOHBK == null)
			{
				IPDNOLCLJNB.Write((ushort)0);
				return;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(ICENKPDOHBK);
			ushort value = (ushort)bytes.Length;
			IPDNOLCLJNB.Write(value);
			IPDNOLCLJNB.Write(bytes);
		}
		else
		{
			ushort num = JEJNNDANAPE.ReadUInt16();
			if (num == 0)
			{
				ICENKPDOHBK = string.Empty;
				return;
			}
			byte[] bytes2 = JEJNNDANAPE.ReadBytes(num);
			ICENKPDOHBK = Encoding.UTF8.GetString(bytes2);
		}
	}

	public object[] ECDCMJJHELN()
	{
		return GMJOHJJGBMK.ToArray();
	}

	public void FDDJMJJGKCL(ref Quaternion HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(HCKCCHPJOPI);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.x);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.y);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.z);
			IPDNOLCLJNB.Write(HCKCCHPJOPI.w);
		}
		else
		{
			HCKCCHPJOPI.x = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.y = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.z = JEJNNDANAPE.ReadSingle();
			HCKCCHPJOPI.w = JEJNNDANAPE.ReadSingle();
		}
	}

	public void IKMGOJGHIEO(ref ObscuredFloat HCKCCHPJOPI)
	{
		if (EBNDGHKKIPG)
		{
			float num = HCKCCHPJOPI;
			GMJOHJJGBMK.Add(num);
			IPDNOLCLJNB.Write(num);
		}
		else
		{
			HCKCCHPJOPI = JEJNNDANAPE.ReadSingle();
		}
	}

	public void FDDJMJJGKCL(ref ushort ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadUInt16();
		}
	}

	public void LACBECPOPNM(ref short ICENKPDOHBK)
	{
		if (EBNDGHKKIPG)
		{
			GMJOHJJGBMK.Add(ICENKPDOHBK);
			IPDNOLCLJNB.Write(ICENKPDOHBK);
		}
		else
		{
			ICENKPDOHBK = JEJNNDANAPE.ReadInt16();
		}
	}
}
