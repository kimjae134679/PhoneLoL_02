using System;

namespace MongoDB.Bson
{
	public static class LLOCJIKLEII
	{
		public static byte[] KDOLNLMOPHO(string MABBPNNIMBJ)
		{
			if (MABBPNNIMBJ == null)
			{
				throw new ArgumentNullException(MABBPNNIMBJ);
			}
			byte[] EOOFAKHOBPM;
			if (!DDKAIBGOPKC(MABBPNNIMBJ, out EOOFAKHOBPM))
			{
				throw new FormatException("String should contain only hexadecimal digits.");
			}
			return EOOFAKHOBPM;
		}

		public static char BGJJMJKCNIM(int ICENKPDOHBK)
		{
			return (char)(ICENKPDOHBK + ((ICENKPDOHBK >= 10) ? 87 : 48));
		}

		public static string NPFBFKMIGOD(byte[] EOOFAKHOBPM)
		{
			if (EOOFAKHOBPM == null)
			{
				throw new ArgumentNullException("bytes");
			}
			int num = EOOFAKHOBPM.Length;
			char[] array = new char[num * 2];
			int i = 0;
			int num2 = 0;
			for (; i < num; i++)
			{
				byte b = EOOFAKHOBPM[i];
				array[num2++] = BGJJMJKCNIM(b >> 4);
				array[num2++] = BGJJMJKCNIM(b & 0xF);
			}
			return new string(array);
		}

		public static DateTime FLFIJKFHPHJ(DateTime FGLJHFHHPJN)
		{
			if (FGLJHFHHPJN == DateTime.MinValue)
			{
				return DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Local);
			}
			if (FGLJHFHHPJN == DateTime.MaxValue)
			{
				return DateTime.SpecifyKind(DateTime.MaxValue, DateTimeKind.Local);
			}
			return FGLJHFHHPJN.ToLocalTime();
		}

		public static DateTime GBMKPDKGNNB(DateTime FGLJHFHHPJN)
		{
			if (FGLJHFHHPJN == DateTime.MinValue)
			{
				return DateTime.SpecifyKind(DateTime.MinValue, DateTimeKind.Utc);
			}
			if (FGLJHFHHPJN == DateTime.MaxValue)
			{
				return DateTime.SpecifyKind(DateTime.MaxValue, DateTimeKind.Utc);
			}
			return FGLJHFHHPJN.ToUniversalTime();
		}

		public static bool DDKAIBGOPKC(string MABBPNNIMBJ, out byte[] EOOFAKHOBPM)
		{
			EOOFAKHOBPM = null;
			if (MABBPNNIMBJ == null)
			{
				return false;
			}
			byte[] array = new byte[(MABBPNNIMBJ.Length + 1) / 2];
			int num = 0;
			int num2 = 0;
			if (MABBPNNIMBJ.Length % 2 == 1)
			{
				int ICENKPDOHBK;
				if (!EDKFJAGKLAP(MABBPNNIMBJ[num++], out ICENKPDOHBK))
				{
					return false;
				}
				array[num2++] = (byte)ICENKPDOHBK;
			}
			while (num < MABBPNNIMBJ.Length)
			{
				int ICENKPDOHBK2;
				if (!EDKFJAGKLAP(MABBPNNIMBJ[num++], out ICENKPDOHBK2))
				{
					return false;
				}
				int ICENKPDOHBK3;
				if (!EDKFJAGKLAP(MABBPNNIMBJ[num++], out ICENKPDOHBK3))
				{
					return false;
				}
				array[num2++] = (byte)((ICENKPDOHBK2 << 4) | ICENKPDOHBK3);
			}
			EOOFAKHOBPM = array;
			return true;
		}

		private static bool EDKFJAGKLAP(char CEMGPCOMLOP, out int ICENKPDOHBK)
		{
			if (CEMGPCOMLOP >= '0' && CEMGPCOMLOP <= '9')
			{
				ICENKPDOHBK = CEMGPCOMLOP - 48;
				return true;
			}
			if (CEMGPCOMLOP >= 'a' && CEMGPCOMLOP <= 'f')
			{
				ICENKPDOHBK = 10 + (CEMGPCOMLOP - 97);
				return true;
			}
			if (CEMGPCOMLOP >= 'A' && CEMGPCOMLOP <= 'F')
			{
				ICENKPDOHBK = 10 + (CEMGPCOMLOP - 65);
				return true;
			}
			ICENKPDOHBK = 0;
			return false;
		}
	}
}
