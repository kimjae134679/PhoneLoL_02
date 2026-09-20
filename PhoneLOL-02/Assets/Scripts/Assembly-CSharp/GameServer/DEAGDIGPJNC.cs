using System.Collections.Generic;

namespace GameServer
{
	public abstract class DEAGDIGPJNC
	{
		private List<long> NEFBLKHOFHN;

		protected DEAGDIGPJNC()
		{
			KFKJDJIJPHP();
		}

		protected abstract int BJKLGMNIEHA();

		protected abstract long LMAHFLAOKCD(int DDILAEMMCAJ);

		public void PEFJOMFAOJI()
		{
		}

		public void KFKJDJIJPHP()
		{
			if (NEFBLKHOFHN != null)
			{
				return;
			}
			int num = 0;
			NEFBLKHOFHN = new List<long>(BJKLGMNIEHA() + 1);
			for (num = 0; num <= BJKLGMNIEHA(); num++)
			{
				if (num < 2)
				{
					NEFBLKHOFHN.Add(0L);
				}
				else
				{
					NEFBLKHOFHN.Add(LMAHFLAOKCD(num));
				}
			}
		}

		public int EGACBGNDOBA(long JKLMKGNFLDF)
		{
			int num = 0;
			for (num = 1; num <= BJKLGMNIEHA(); num++)
			{
				if (JKLMKGNFLDF < NEFBLKHOFHN[num])
				{
					return num - 1;
				}
			}
			return BJKLGMNIEHA();
		}

		public long GPNMCPKECGG(int DDILAEMMCAJ)
		{
			if (DDILAEMMCAJ < 0 || DDILAEMMCAJ > BJKLGMNIEHA())
			{
				return 0L;
			}
			return NEFBLKHOFHN[DDILAEMMCAJ];
		}

		public long HMFMCIDDFBF()
		{
			return GPNMCPKECGG(BJKLGMNIEHA());
		}

		public float POAFOAMNDGM(int JKLMKGNFLDF)
		{
			float result = 0f;
			for (int i = 0; i < NEFBLKHOFHN.Count; i++)
			{
				if (JKLMKGNFLDF < NEFBLKHOFHN[i])
				{
					long num = NEFBLKHOFHN[i] - NEFBLKHOFHN[i - 1];
					if (num == 0L)
					{
						num = 1L;
					}
					result = (float)(JKLMKGNFLDF - NEFBLKHOFHN[i - 1]) / (float)num;
					break;
				}
			}
			return result;
		}
	}
}
