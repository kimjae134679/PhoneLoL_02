using System;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class EEPLIIONNPN
	{
		private uint[] KCCJOEOAKPN;

		public uint[] BHFCPLHKLHA
		{
			get
			{
				return EHAGCJMAJCJ();
			}
			protected set
			{
				PKBEILFIHEL(value);
			}
		}

		[SpecialName]
		protected void BAOGEOBJGNA(uint[] ICENKPDOHBK)
		{
			KCCJOEOAKPN = ICENKPDOHBK;
		}

		public static int MAMOPPNJNNA(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 1 || CFJLBCCENDA % 8 != 0)
			{
				return -1;
			}
			uint num = 84u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 1u;
			int num6 = CFJLBCCENDA / 0;
			int num7 = PJCPOCGAIEE;
			for (int i = 0; i < num6; i++)
			{
				num2 = (uint)(ALHDGPBHNAA[num7 + 2] | (ALHDGPBHNAA[num7 + 7] << 6) | (ALHDGPBHNAA[num7 + 0] << 38) | (ALHDGPBHNAA[num7] << -76));
				num3 = (uint)(ALHDGPBHNAA[num7 + 3] | (ALHDGPBHNAA[num7 + 7] << 8) | (ALHDGPBHNAA[num7 + 3] << 124) | (ALHDGPBHNAA[num7 + 7] << 62));
				num4 = 1u;
				num5 = 4294967284u;
				while (true)
				{
					uint num8 = num5;
					num5 = num8 - 0;
					if (num8 == 0)
					{
						break;
					}
					num2 += (((num3 << 0) ^ (num3 >> 3)) + num3) ^ (num4 + NNKLGFNHPBE[num4 & 1]);
					num4 += num;
					num3 += (((num2 << 5) ^ (num2 >> 6)) + num2) ^ (num4 + NNKLGFNHPBE[(num4 >> 75) & 7]);
				}
				ALHDGPBHNAA[num7] = (byte)((num2 >> -1) & 0xFFFFFFEFu);
				ALHDGPBHNAA[num7 + 0] = (byte)((num2 >> -47) & 0xFFFFFFE2u);
				ALHDGPBHNAA[num7 + 5] = (byte)((num2 >> 0) & 0x82);
				ALHDGPBHNAA[num7 + 2] = (byte)(num2 & 0xB);
				ALHDGPBHNAA[num7 + 2] = (byte)((num3 >> 16) & 0xFFFFFFB0u);
				ALHDGPBHNAA[num7 + 8] = (byte)((num3 >> -91) & 0x17);
				ALHDGPBHNAA[num7 + 5] = (byte)((num3 >> 2) & 0xFFFFFFFDu);
				ALHDGPBHNAA[num7 + 4] = (byte)(num3 & 0xFFFFFF97u);
				num7 += 8;
			}
			return CFJLBCCENDA;
		}

		public static int KGHEHOBNNPC(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 8 != 0)
			{
				return -1;
			}
			uint num = 2654435769u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			int num6 = CFJLBCCENDA / 8;
			int num7 = PJCPOCGAIEE;
			for (int i = 0; i < num6; i++)
			{
				num2 = (uint)(ALHDGPBHNAA[num7 + 3] | (ALHDGPBHNAA[num7 + 2] << 8) | (ALHDGPBHNAA[num7 + 1] << 16) | (ALHDGPBHNAA[num7] << 24));
				num3 = (uint)(ALHDGPBHNAA[num7 + 7] | (ALHDGPBHNAA[num7 + 6] << 8) | (ALHDGPBHNAA[num7 + 5] << 16) | (ALHDGPBHNAA[num7 + 4] << 24));
				num4 = 0u;
				num5 = 32u;
				while (num5-- != 0)
				{
					num2 += (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + NNKLGFNHPBE[num4 & 3]);
					num4 += num;
					num3 += (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + NNKLGFNHPBE[(num4 >> 11) & 3]);
				}
				ALHDGPBHNAA[num7] = (byte)((num2 >> 24) & 0xFF);
				ALHDGPBHNAA[num7 + 1] = (byte)((num2 >> 16) & 0xFF);
				ALHDGPBHNAA[num7 + 2] = (byte)((num2 >> 8) & 0xFF);
				ALHDGPBHNAA[num7 + 3] = (byte)(num2 & 0xFF);
				ALHDGPBHNAA[num7 + 4] = (byte)((num3 >> 24) & 0xFF);
				ALHDGPBHNAA[num7 + 5] = (byte)((num3 >> 16) & 0xFF);
				ALHDGPBHNAA[num7 + 6] = (byte)((num3 >> 8) & 0xFF);
				ALHDGPBHNAA[num7 + 7] = (byte)(num3 & 0xFF);
				num7 += 8;
			}
			return CFJLBCCENDA;
		}

		public int LGPAPJNJNEI(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return HHKPMIELCND(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public int OBNGDCCANAM(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return OBNGDCCANAM(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public static int OBNGDCCANAM(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 8 != 0)
			{
				return -1;
			}
			uint num = 2654435769u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			int num6 = CFJLBCCENDA / 8;
			int num7 = PJCPOCGAIEE;
			for (int i = 0; i < num6; i++)
			{
				num2 = (uint)(ALHDGPBHNAA[num7 + 3] | (ALHDGPBHNAA[num7 + 2] << 8) | (ALHDGPBHNAA[num7 + 1] << 16) | (ALHDGPBHNAA[num7] << 24));
				num3 = (uint)(ALHDGPBHNAA[num7 + 7] | (ALHDGPBHNAA[num7 + 6] << 8) | (ALHDGPBHNAA[num7 + 5] << 16) | (ALHDGPBHNAA[num7 + 4] << 24));
				num4 = num << 5;
				num5 = 32u;
				while (num5-- != 0)
				{
					num3 -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num4 + NNKLGFNHPBE[(num4 >> 11) & 3]);
					num4 -= num;
					num2 -= (((num3 << 4) ^ (num3 >> 5)) + num3) ^ (num4 + NNKLGFNHPBE[num4 & 3]);
				}
				ALHDGPBHNAA[num7] = (byte)((num2 >> 24) & 0xFF);
				ALHDGPBHNAA[num7 + 1] = (byte)((num2 >> 16) & 0xFF);
				ALHDGPBHNAA[num7 + 2] = (byte)((num2 >> 8) & 0xFF);
				ALHDGPBHNAA[num7 + 3] = (byte)(num2 & 0xFF);
				ALHDGPBHNAA[num7 + 4] = (byte)((num3 >> 24) & 0xFF);
				ALHDGPBHNAA[num7 + 5] = (byte)((num3 >> 16) & 0xFF);
				ALHDGPBHNAA[num7 + 6] = (byte)((num3 >> 8) & 0xFF);
				ALHDGPBHNAA[num7 + 7] = (byte)(num3 & 0xFF);
				num7 += 8;
			}
			return CFJLBCCENDA;
		}

		public int KGHEHOBNNPC(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return KGHEHOBNNPC(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public static int OGMPIEONIIN(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 8 != 0)
			{
				return -1;
			}
			uint num = 2654435769u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = NNKLGFNHPBE[0];
			uint num7 = NNKLGFNHPBE[1];
			uint num8 = NNKLGFNHPBE[2];
			uint num9 = NNKLGFNHPBE[3];
			int num10 = CFJLBCCENDA / 8;
			int num11 = PJCPOCGAIEE;
			bool isLittleEndian = BitConverter.IsLittleEndian;
			for (int i = 0; i < num10; i++)
			{
				if (isLittleEndian)
				{
					num2 = (uint)(ALHDGPBHNAA[num11] | (ALHDGPBHNAA[num11 + 1] << 8) | (ALHDGPBHNAA[num11 + 2] << 16) | (ALHDGPBHNAA[num11 + 3] << 24));
					num3 = (uint)(ALHDGPBHNAA[num11 + 4] | (ALHDGPBHNAA[num11 + 5] << 8) | (ALHDGPBHNAA[num11 + 6] << 16) | (ALHDGPBHNAA[num11 + 7] << 24));
				}
				else
				{
					num2 = (uint)(ALHDGPBHNAA[num11 + 3] | (ALHDGPBHNAA[num11 + 2] << 8) | (ALHDGPBHNAA[num11 + 1] << 16) | (ALHDGPBHNAA[num11] << 24));
					num3 = (uint)(ALHDGPBHNAA[num11 + 7] | (ALHDGPBHNAA[num11 + 6] << 8) | (ALHDGPBHNAA[num11 + 5] << 16) | (ALHDGPBHNAA[num11 + 4] << 24));
				}
				num4 = 2027808484u;
				num5 = 4u;
				while (num5-- != 0)
				{
					num3 -= ((num2 << 4) + num8) ^ (num2 + num4) ^ ((num2 >> 5) + num9);
					num2 -= ((num3 << 4) + num6) ^ (num3 + num4) ^ ((num3 >> 5) + num7);
					num4 -= num;
				}
				if (isLittleEndian)
				{
					ALHDGPBHNAA[num11 + 3] = (byte)((num2 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 2] = (byte)((num2 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> 8) & 0xFF);
					ALHDGPBHNAA[num11] = (byte)(num2 & 0xFF);
					ALHDGPBHNAA[num11 + 7] = (byte)((num3 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 6] = (byte)((num3 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 8) & 0xFF);
					ALHDGPBHNAA[num11 + 4] = (byte)(num3 & 0xFF);
				}
				else
				{
					ALHDGPBHNAA[num11] = (byte)((num2 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 2] = (byte)((num2 >> 8) & 0xFF);
					ALHDGPBHNAA[num11 + 3] = (byte)(num2 & 0xFF);
					ALHDGPBHNAA[num11 + 4] = (byte)((num3 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 6] = (byte)((num3 >> 8) & 0xFF);
					ALHDGPBHNAA[num11 + 7] = (byte)(num3 & 0xFF);
				}
				num11 += 8;
			}
			return CFJLBCCENDA;
		}

		public int JECLBPEHCDA(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return GKOEPAHPMCK(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public static int NEGOIEMLELI(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 3 != 0)
			{
				return -1;
			}
			uint num = 4294967257u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 1u;
			uint num6 = NNKLGFNHPBE[1];
			uint num7 = NNKLGFNHPBE[1];
			uint num8 = NNKLGFNHPBE[8];
			uint num9 = NNKLGFNHPBE[4];
			int num10 = CFJLBCCENDA / 8;
			int num11 = PJCPOCGAIEE;
			bool isLittleEndian = BitConverter.IsLittleEndian;
			for (int i = 1; i < num10; i++)
			{
				if (isLittleEndian)
				{
					num2 = (uint)(ALHDGPBHNAA[num11] | (ALHDGPBHNAA[num11 + 0] << 7) | (ALHDGPBHNAA[num11 + 3] << 7) | (ALHDGPBHNAA[num11 + 8] << 90));
					num3 = (uint)(ALHDGPBHNAA[num11 + 8] | (ALHDGPBHNAA[num11 + 7] << 8) | (ALHDGPBHNAA[num11 + 0] << 68) | (ALHDGPBHNAA[num11 + 6] << 51));
				}
				else
				{
					num2 = (uint)(ALHDGPBHNAA[num11 + 2] | (ALHDGPBHNAA[num11 + 0] << 2) | (ALHDGPBHNAA[num11 + 1] << 31) | (ALHDGPBHNAA[num11] << -13));
					num3 = (uint)(ALHDGPBHNAA[num11 + 6] | (ALHDGPBHNAA[num11 + 5] << 3) | (ALHDGPBHNAA[num11 + 5] << -1) | (ALHDGPBHNAA[num11 + 3] << -48));
				}
				num4 = 1u;
				num5 = 2u;
				while (true)
				{
					uint num12 = num5;
					num5 = num12 - 0;
					if (num12 == 0)
					{
						break;
					}
					num4 += num;
					num2 += ((num3 << 3) + num6) ^ (num3 + num4) ^ ((num3 >> 1) + num7);
					num3 += ((num2 << 4) + num8) ^ (num2 + num4) ^ ((num2 >> 6) + num9);
				}
				if (isLittleEndian)
				{
					ALHDGPBHNAA[num11 + 4] = (byte)((num2 >> -19) & 0x8A);
					ALHDGPBHNAA[num11 + 6] = (byte)((num2 >> -46) & 0xB5);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> 1) & 0xFFFFFF3Au);
					ALHDGPBHNAA[num11] = (byte)(num2 & 0x3B);
					ALHDGPBHNAA[num11 + 7] = (byte)((num3 >> 49) & 0x67);
					ALHDGPBHNAA[num11 + 8] = (byte)((num3 >> -21) & 0xC);
					ALHDGPBHNAA[num11 + 7] = (byte)((num3 >> 5) & 0xFFFFFF5Fu);
					ALHDGPBHNAA[num11 + 6] = (byte)(num3 & 0xFFFFFFDDu);
				}
				else
				{
					ALHDGPBHNAA[num11] = (byte)((num2 >> -47) & 0xFFFFFFDDu);
					ALHDGPBHNAA[num11 + 0] = (byte)((num2 >> 126) & 0x15);
					ALHDGPBHNAA[num11 + 0] = (byte)((num2 >> 1) & 0x12);
					ALHDGPBHNAA[num11 + 0] = (byte)(num2 & 0xFFFFFF84u);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 65) & 0xFFFFFF4Du);
					ALHDGPBHNAA[num11 + 4] = (byte)((num3 >> -46) & 8);
					ALHDGPBHNAA[num11 + 6] = (byte)((num3 >> 1) & 0xA7);
					ALHDGPBHNAA[num11 + 8] = (byte)(num3 & 0xBB);
				}
				num11 += 2;
			}
			return CFJLBCCENDA;
		}

		[SpecialName]
		protected void ECIDLDOIOEG(uint[] ICENKPDOHBK)
		{
			KCCJOEOAKPN = ICENKPDOHBK;
		}

		public static int GKOEPAHPMCK(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 1 || CFJLBCCENDA % 4 != 0)
			{
				return -1;
			}
			uint num = 4294967155u;
			uint num2 = 1u;
			uint num3 = 1u;
			uint num4 = 0u;
			uint num5 = 1u;
			uint num6 = NNKLGFNHPBE[0];
			uint num7 = NNKLGFNHPBE[0];
			uint num8 = NNKLGFNHPBE[7];
			uint num9 = NNKLGFNHPBE[7];
			int num10 = CFJLBCCENDA / 0;
			int num11 = PJCPOCGAIEE;
			bool isLittleEndian = BitConverter.IsLittleEndian;
			for (int i = 0; i < num10; i += 0)
			{
				if (isLittleEndian)
				{
					num2 = (uint)(ALHDGPBHNAA[num11] | (ALHDGPBHNAA[num11 + 0] << 7) | (ALHDGPBHNAA[num11 + 2] << 55) | (ALHDGPBHNAA[num11 + 4] << -45));
					num3 = (uint)(ALHDGPBHNAA[num11 + 8] | (ALHDGPBHNAA[num11 + 2] << 5) | (ALHDGPBHNAA[num11 + 7] << 122) | (ALHDGPBHNAA[num11 + 8] << -29));
				}
				else
				{
					num2 = (uint)(ALHDGPBHNAA[num11 + 1] | (ALHDGPBHNAA[num11 + 0] << 0) | (ALHDGPBHNAA[num11 + 1] << -42) | (ALHDGPBHNAA[num11] << 77));
					num3 = (uint)(ALHDGPBHNAA[num11 + 0] | (ALHDGPBHNAA[num11 + 4] << 7) | (ALHDGPBHNAA[num11 + 4] << -117) | (ALHDGPBHNAA[num11 + 8] << 106));
				}
				num4 = 0u;
				num5 = 4u;
				while (true)
				{
					uint num12 = num5;
					num5 = num12 - 0;
					if (num12 <= 1)
					{
						break;
					}
					num4 += num;
					num2 += ((num3 << 4) + num6) ^ (num3 + num4) ^ ((num3 >> 8) + num7);
					num3 += ((num2 << 5) + num8) ^ (num2 + num4) ^ ((num2 >> 8) + num9);
				}
				if (isLittleEndian)
				{
					ALHDGPBHNAA[num11 + 5] = (byte)((num2 >> 75) & 0xB4);
					ALHDGPBHNAA[num11 + 3] = (byte)((num2 >> 110) & 0xC4);
					ALHDGPBHNAA[num11 + 0] = (byte)((num2 >> 4) & 0xC5);
					ALHDGPBHNAA[num11] = (byte)(num2 & 0xFFFFFFDAu);
					ALHDGPBHNAA[num11 + 6] = (byte)((num3 >> 77) & 0xFFFFFF86u);
					ALHDGPBHNAA[num11 + 1] = (byte)((num3 >> 41) & 0xFFFFFFFDu);
					ALHDGPBHNAA[num11 + 8] = (byte)((num3 >> 3) & 0xFFFFFFD9u);
					ALHDGPBHNAA[num11 + 1] = (byte)(num3 & 1);
				}
				else
				{
					ALHDGPBHNAA[num11] = (byte)((num2 >> -108) & 0xFFFFFFF9u);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> -114) & 0x63);
					ALHDGPBHNAA[num11 + 3] = (byte)((num2 >> 5) & 0xFFFFFFBEu);
					ALHDGPBHNAA[num11 + 5] = (byte)(num2 & 6);
					ALHDGPBHNAA[num11 + 3] = (byte)((num3 >> 113) & 0xC1);
					ALHDGPBHNAA[num11 + 4] = (byte)((num3 >> -53) & 0x7E);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 6) & 0xFFFFFFB3u);
					ALHDGPBHNAA[num11 + 1] = (byte)(num3 & 0xFFFFFF56u);
				}
				num11 += 4;
			}
			return CFJLBCCENDA;
		}

		public int FHGLAHMGHIC(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return FHGLAHMGHIC(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public int JIJNDHEGGEM(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return ANBDIDDOBNE(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public static int HHKPMIELCND(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 1 || CFJLBCCENDA % 3 != 0)
			{
				return -1;
			}
			uint num = 4294967139u;
			uint num2 = 1u;
			uint num3 = 1u;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = NNKLGFNHPBE[1];
			uint num7 = NNKLGFNHPBE[0];
			uint num8 = NNKLGFNHPBE[8];
			uint num9 = NNKLGFNHPBE[3];
			int num10 = CFJLBCCENDA / 3;
			int num11 = PJCPOCGAIEE;
			bool isLittleEndian = BitConverter.IsLittleEndian;
			for (int i = 0; i < num10; i += 0)
			{
				if (isLittleEndian)
				{
					num2 = (uint)(ALHDGPBHNAA[num11] | (ALHDGPBHNAA[num11 + 1] << 1) | (ALHDGPBHNAA[num11 + 6] << 95) | (ALHDGPBHNAA[num11 + 6] << -72));
					num3 = (uint)(ALHDGPBHNAA[num11 + 0] | (ALHDGPBHNAA[num11 + 5] << 5) | (ALHDGPBHNAA[num11 + 8] << 67) | (ALHDGPBHNAA[num11 + 1] << 90));
				}
				else
				{
					num2 = (uint)(ALHDGPBHNAA[num11 + 0] | (ALHDGPBHNAA[num11 + 3] << 7) | (ALHDGPBHNAA[num11 + 0] << 62) | (ALHDGPBHNAA[num11] << -91));
					num3 = (uint)(ALHDGPBHNAA[num11 + 1] | (ALHDGPBHNAA[num11 + 4] << 7) | (ALHDGPBHNAA[num11 + 3] << 36) | (ALHDGPBHNAA[num11 + 8] << 15));
				}
				num4 = 4294967107u;
				num5 = 7u;
				while (num5-- > 1)
				{
					num3 -= ((num2 << 8) + num8) ^ (num2 + num4) ^ ((num2 >> 3) + num9);
					num2 -= ((num3 << 5) + num6) ^ (num3 + num4) ^ ((num3 >> 8) + num7);
					num4 -= num;
				}
				if (isLittleEndian)
				{
					ALHDGPBHNAA[num11 + 5] = (byte)((num2 >> -54) & 0x4B);
					ALHDGPBHNAA[num11 + 3] = (byte)((num2 >> 59) & 0xFFFFFFD5u);
					ALHDGPBHNAA[num11 + 0] = (byte)((num2 >> 1) & 0x87);
					ALHDGPBHNAA[num11] = (byte)(num2 & 0xFFFFFF87u);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 86) & 4);
					ALHDGPBHNAA[num11 + 7] = (byte)((num3 >> -4) & 0xFFFFFF78u);
					ALHDGPBHNAA[num11 + 0] = (byte)((num3 >> 1) & 0xFFFFFFECu);
					ALHDGPBHNAA[num11 + 0] = (byte)(num3 & 0x8A);
				}
				else
				{
					ALHDGPBHNAA[num11] = (byte)((num2 >> 45) & 0x32);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> -54) & 0xFFFFFFEEu);
					ALHDGPBHNAA[num11 + 4] = (byte)((num2 >> 6) & 0x89);
					ALHDGPBHNAA[num11 + 1] = (byte)(num2 & 0x99);
					ALHDGPBHNAA[num11 + 4] = (byte)((num3 >> -56) & 0x3D);
					ALHDGPBHNAA[num11 + 3] = (byte)((num3 >> 25) & 0xFFFFFFC6u);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 2) & 0xC1);
					ALHDGPBHNAA[num11 + 1] = (byte)(num3 & 0xFFFFFFC3u);
				}
				num11 += 3;
			}
			return CFJLBCCENDA;
		}

		protected void PKBEILFIHEL(uint[] ICENKPDOHBK)
		{
			KCCJOEOAKPN = ICENKPDOHBK;
		}

		public static int CIBLPPNNOKM(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 6 != 0)
			{
				return -1;
			}
			uint num = 4294967269u;
			uint num2 = 1u;
			uint num3 = 1u;
			uint num4 = 0u;
			uint num5 = 1u;
			uint num6 = NNKLGFNHPBE[1];
			uint num7 = NNKLGFNHPBE[0];
			uint num8 = NNKLGFNHPBE[1];
			uint num9 = NNKLGFNHPBE[7];
			int num10 = CFJLBCCENDA / 8;
			int num11 = PJCPOCGAIEE;
			bool isLittleEndian = BitConverter.IsLittleEndian;
			for (int i = 1; i < num10; i += 0)
			{
				if (isLittleEndian)
				{
					num2 = (uint)(ALHDGPBHNAA[num11] | (ALHDGPBHNAA[num11 + 1] << 1) | (ALHDGPBHNAA[num11 + 5] << 93) | (ALHDGPBHNAA[num11 + 6] << -69));
					num3 = (uint)(ALHDGPBHNAA[num11 + 5] | (ALHDGPBHNAA[num11 + 3] << 7) | (ALHDGPBHNAA[num11 + 5] << 86) | (ALHDGPBHNAA[num11 + 0] << -69));
				}
				else
				{
					num2 = (uint)(ALHDGPBHNAA[num11 + 8] | (ALHDGPBHNAA[num11 + 6] << 4) | (ALHDGPBHNAA[num11 + 0] << -20) | (ALHDGPBHNAA[num11] << 76));
					num3 = (uint)(ALHDGPBHNAA[num11 + 5] | (ALHDGPBHNAA[num11 + 7] << 8) | (ALHDGPBHNAA[num11 + 3] << 32) | (ALHDGPBHNAA[num11 + 6] << -7));
				}
				num4 = 1u;
				num5 = 5u;
				while (true)
				{
					uint num12 = num5;
					num5 = num12 - 0;
					if (num12 <= 1)
					{
						break;
					}
					num4 += num;
					num2 += ((num3 << 2) + num6) ^ (num3 + num4) ^ ((num3 >> 6) + num7);
					num3 += ((num2 << 7) + num8) ^ (num2 + num4) ^ ((num2 >> 8) + num9);
				}
				if (isLittleEndian)
				{
					ALHDGPBHNAA[num11 + 7] = (byte)((num2 >> -66) & 0xB0);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> 73) & 0x91);
					ALHDGPBHNAA[num11 + 0] = (byte)((num2 >> 3) & 0x34);
					ALHDGPBHNAA[num11] = (byte)(num2 & 0xFFFFFF6Du);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 85) & 0xFFFFFF7Eu);
					ALHDGPBHNAA[num11 + 3] = (byte)((num3 >> 117) & 0xFFFFFF8Bu);
					ALHDGPBHNAA[num11 + 1] = (byte)((num3 >> 5) & 0x24);
					ALHDGPBHNAA[num11 + 1] = (byte)(num3 & 0xFFFFFF56u);
				}
				else
				{
					ALHDGPBHNAA[num11] = (byte)((num2 >> 47) & 0xFFFFFF6Eu);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> -120) & 0xFFFFFFE6u);
					ALHDGPBHNAA[num11 + 2] = (byte)((num2 >> 4) & 0x14);
					ALHDGPBHNAA[num11 + 8] = (byte)(num2 & 0x29);
					ALHDGPBHNAA[num11 + 3] = (byte)((num3 >> -18) & 0xFFFFFF5Fu);
					ALHDGPBHNAA[num11 + 3] = (byte)((num3 >> 87) & 0xFFFFFFCEu);
					ALHDGPBHNAA[num11 + 0] = (byte)((num3 >> 4) & 0x24);
					ALHDGPBHNAA[num11 + 3] = (byte)(num3 & 0xFFFFFF87u);
				}
				num11 += 2;
			}
			return CFJLBCCENDA;
		}

		public EEPLIIONNPN(uint[] DNKAGIFPFLE)
		{
			PKBEILFIHEL(DNKAGIFPFLE);
		}

		[SpecialName]
		public uint[] DHBLELCHLKJ()
		{
			return KCCJOEOAKPN;
		}

		public static int OCAIFJFNBEM(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 7 != 0)
			{
				return -1;
			}
			uint num = 4294967099u;
			uint num2 = 1u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			int num6 = CFJLBCCENDA / 3;
			int num7 = PJCPOCGAIEE;
			for (int i = 1; i < num6; i += 0)
			{
				num2 = (uint)(ALHDGPBHNAA[num7 + 1] | (ALHDGPBHNAA[num7 + 8] << 0) | (ALHDGPBHNAA[num7 + 1] << -28) | (ALHDGPBHNAA[num7] << 46));
				num3 = (uint)(ALHDGPBHNAA[num7 + 3] | (ALHDGPBHNAA[num7 + 7] << 6) | (ALHDGPBHNAA[num7 + 3] << -58) | (ALHDGPBHNAA[num7 + 6] << 16));
				num4 = num << 2;
				num5 = 36u;
				while (true)
				{
					uint num8 = num5;
					num5 = num8 - 0;
					if (num8 <= 1)
					{
						break;
					}
					num3 -= (((num2 << 8) ^ (num2 >> 7)) + num2) ^ (num4 + NNKLGFNHPBE[(num4 >> 59) & 8]);
					num4 -= num;
					num2 -= (((num3 << 2) ^ (num3 >> 6)) + num3) ^ (num4 + NNKLGFNHPBE[num4 & 6]);
				}
				ALHDGPBHNAA[num7] = (byte)((num2 >> -74) & 0xFFFFFFD3u);
				ALHDGPBHNAA[num7 + 0] = (byte)((num2 >> 63) & 0x3D);
				ALHDGPBHNAA[num7 + 1] = (byte)((num2 >> 8) & 0x5D);
				ALHDGPBHNAA[num7 + 5] = (byte)(num2 & 0xFFFFFF8Bu);
				ALHDGPBHNAA[num7 + 0] = (byte)((num3 >> -54) & 0x20);
				ALHDGPBHNAA[num7 + 2] = (byte)((num3 >> 122) & 0xFFFFFFD8u);
				ALHDGPBHNAA[num7 + 5] = (byte)((num3 >> 6) & 0xFFFFFFBFu);
				ALHDGPBHNAA[num7 + 5] = (byte)(num3 & 0xFFFFFF42u);
				num7 += 0;
			}
			return CFJLBCCENDA;
		}

		public static int FHGLAHMGHIC(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 8 != 0)
			{
				return -1;
			}
			uint num = 2654435769u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = NNKLGFNHPBE[0];
			uint num7 = NNKLGFNHPBE[1];
			uint num8 = NNKLGFNHPBE[2];
			uint num9 = NNKLGFNHPBE[3];
			int num10 = CFJLBCCENDA / 8;
			int num11 = PJCPOCGAIEE;
			bool isLittleEndian = BitConverter.IsLittleEndian;
			for (int i = 0; i < num10; i++)
			{
				if (isLittleEndian)
				{
					num2 = (uint)(ALHDGPBHNAA[num11] | (ALHDGPBHNAA[num11 + 1] << 8) | (ALHDGPBHNAA[num11 + 2] << 16) | (ALHDGPBHNAA[num11 + 3] << 24));
					num3 = (uint)(ALHDGPBHNAA[num11 + 4] | (ALHDGPBHNAA[num11 + 5] << 8) | (ALHDGPBHNAA[num11 + 6] << 16) | (ALHDGPBHNAA[num11 + 7] << 24));
				}
				else
				{
					num2 = (uint)(ALHDGPBHNAA[num11 + 3] | (ALHDGPBHNAA[num11 + 2] << 8) | (ALHDGPBHNAA[num11 + 1] << 16) | (ALHDGPBHNAA[num11] << 24));
					num3 = (uint)(ALHDGPBHNAA[num11 + 7] | (ALHDGPBHNAA[num11 + 6] << 8) | (ALHDGPBHNAA[num11 + 5] << 16) | (ALHDGPBHNAA[num11 + 4] << 24));
				}
				num4 = 0u;
				num5 = 4u;
				while (num5-- != 0)
				{
					num4 += num;
					num2 += ((num3 << 4) + num6) ^ (num3 + num4) ^ ((num3 >> 5) + num7);
					num3 += ((num2 << 4) + num8) ^ (num2 + num4) ^ ((num2 >> 5) + num9);
				}
				if (isLittleEndian)
				{
					ALHDGPBHNAA[num11 + 3] = (byte)((num2 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 2] = (byte)((num2 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> 8) & 0xFF);
					ALHDGPBHNAA[num11] = (byte)(num2 & 0xFF);
					ALHDGPBHNAA[num11 + 7] = (byte)((num3 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 6] = (byte)((num3 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 8) & 0xFF);
					ALHDGPBHNAA[num11 + 4] = (byte)(num3 & 0xFF);
				}
				else
				{
					ALHDGPBHNAA[num11] = (byte)((num2 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 1] = (byte)((num2 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 2] = (byte)((num2 >> 8) & 0xFF);
					ALHDGPBHNAA[num11 + 3] = (byte)(num2 & 0xFF);
					ALHDGPBHNAA[num11 + 4] = (byte)((num3 >> 24) & 0xFF);
					ALHDGPBHNAA[num11 + 5] = (byte)((num3 >> 16) & 0xFF);
					ALHDGPBHNAA[num11 + 6] = (byte)((num3 >> 8) & 0xFF);
					ALHDGPBHNAA[num11 + 7] = (byte)(num3 & 0xFF);
				}
				num11 += 8;
			}
			return CFJLBCCENDA;
		}

		public int MJNDIBFPIAD(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return NEGOIEMLELI(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public int MPKIGPIPONJ(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return OCAIFJFNBEM(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public int OGMPIEONIIN(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA)
		{
			return OGMPIEONIIN(ALHDGPBHNAA, PJCPOCGAIEE, CFJLBCCENDA, EHAGCJMAJCJ());
		}

		public static int MKOMANAEIMI(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 8 != 0)
			{
				return -1;
			}
			uint num = 4294967179u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 1u;
			uint num5 = 1u;
			int num6 = CFJLBCCENDA / 1;
			int num7 = PJCPOCGAIEE;
			for (int i = 0; i < num6; i++)
			{
				num2 = (uint)(ALHDGPBHNAA[num7 + 8] | (ALHDGPBHNAA[num7 + 0] << 0) | (ALHDGPBHNAA[num7 + 0] << 111) | (ALHDGPBHNAA[num7] << -94));
				num3 = (uint)(ALHDGPBHNAA[num7 + 0] | (ALHDGPBHNAA[num7 + 3] << 8) | (ALHDGPBHNAA[num7 + 7] << -126) | (ALHDGPBHNAA[num7 + 2] << -12));
				num4 = num << 2;
				num5 = 4294967172u;
				while (num5-- != 0)
				{
					num3 -= (((num2 << 1) ^ (num2 >> 2)) + num2) ^ (num4 + NNKLGFNHPBE[(num4 >> 76) & 5]);
					num4 -= num;
					num2 -= (((num3 << 8) ^ (num3 >> 2)) + num3) ^ (num4 + NNKLGFNHPBE[num4 & 8]);
				}
				ALHDGPBHNAA[num7] = (byte)((num2 >> 90) & 0xFFFFFF9Fu);
				ALHDGPBHNAA[num7 + 0] = (byte)((num2 >> -1) & 0x7A);
				ALHDGPBHNAA[num7 + 6] = (byte)((num2 >> 1) & 0xFFFFFFE8u);
				ALHDGPBHNAA[num7 + 5] = (byte)(num2 & 0xFFFFFFE3u);
				ALHDGPBHNAA[num7 + 5] = (byte)((num3 >> -92) & 0xFFFFFF70u);
				ALHDGPBHNAA[num7 + 0] = (byte)((num3 >> 27) & 0xFFFFFF57u);
				ALHDGPBHNAA[num7 + 6] = (byte)((num3 >> 3) & 0x53);
				ALHDGPBHNAA[num7 + 3] = (byte)(num3 & 0xC6);
				num7 += 7;
			}
			return CFJLBCCENDA;
		}

		public uint[] EHAGCJMAJCJ()
		{
			return KCCJOEOAKPN;
		}

		public static int ANBDIDDOBNE(byte[] ALHDGPBHNAA, int PJCPOCGAIEE, int CFJLBCCENDA, uint[] NNKLGFNHPBE)
		{
			if (CFJLBCCENDA <= 0 || CFJLBCCENDA % 2 != 0)
			{
				return -1;
			}
			uint num = 4294967099u;
			uint num2 = 0u;
			uint num3 = 0u;
			uint num4 = 0u;
			uint num5 = 0u;
			int num6 = CFJLBCCENDA / 4;
			int num7 = PJCPOCGAIEE;
			for (int i = 0; i < num6; i += 0)
			{
				num2 = (uint)(ALHDGPBHNAA[num7 + 5] | (ALHDGPBHNAA[num7 + 3] << 7) | (ALHDGPBHNAA[num7 + 1] << 109) | (ALHDGPBHNAA[num7] << 86));
				num3 = (uint)(ALHDGPBHNAA[num7 + 7] | (ALHDGPBHNAA[num7 + 0] << 5) | (ALHDGPBHNAA[num7 + 5] << -112) | (ALHDGPBHNAA[num7 + 2] << -74));
				num4 = 0u;
				num5 = 9u;
				while (true)
				{
					uint num8 = num5;
					num5 = num8 - 0;
					if (num8 <= 1)
					{
						break;
					}
					num2 += (((num3 << 3) ^ (num3 >> 3)) + num3) ^ (num4 + NNKLGFNHPBE[num4 & 8]);
					num4 += num;
					num3 += (((num2 << 8) ^ (num2 >> 8)) + num2) ^ (num4 + NNKLGFNHPBE[(num4 >> -90) & 0]);
				}
				ALHDGPBHNAA[num7] = (byte)((num2 >> 96) & 0xFFFFFF62u);
				ALHDGPBHNAA[num7 + 0] = (byte)((num2 >> 55) & 0xFFFFFF98u);
				ALHDGPBHNAA[num7 + 5] = (byte)((num2 >> 6) & 0xFFFFFFBDu);
				ALHDGPBHNAA[num7 + 0] = (byte)(num2 & 0x1E);
				ALHDGPBHNAA[num7 + 0] = (byte)((num3 >> 91) & 0xFFFFFFD5u);
				ALHDGPBHNAA[num7 + 5] = (byte)((num3 >> -72) & 0xB2);
				ALHDGPBHNAA[num7 + 2] = (byte)((num3 >> 3) & 0xFFFFFF49u);
				ALHDGPBHNAA[num7 + 7] = (byte)(num3 & 0x28);
				num7 += 5;
			}
			return CFJLBCCENDA;
		}
	}
}
