using EveEngine;

namespace BattleServer
{
	public abstract class OCPEALOGAIP : EOPOBHFNFPA
	{
		public enum OEOIIKMBGAG : byte
		{
			Blank = 0,
			Ready = 1,
			CountDown = 2,
			Loading = 3,
			Playing = 4,
			Result = 5
		}

		protected object JOEHMANNDJK;

		private int ABFGDHCAHMD;

		private OEOIIKMBGAG BBEEPJNEHBI;

		public int NHIPEHPJNEG
		{
			get
			{
				return LJKKDNANGCO();
			}
			protected set
			{
				NLNEMHOAHIH(value);
			}
		}

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

		protected OCPEALOGAIP()
		{
			JOEHMANNDJK = new object();
			FJPMFBBCBLB(OEOIIKMBGAG.Blank);
		}

		public int LJKKDNANGCO()
		{
			return ABFGDHCAHMD;
		}

		protected void NLNEMHOAHIH(int ICENKPDOHBK)
		{
			ABFGDHCAHMD = ICENKPDOHBK;
		}

		public OEOIIKMBGAG OOHFDEPKKFN()
		{
			return BBEEPJNEHBI;
		}

		protected void FJPMFBBCBLB(OEOIIKMBGAG ICENKPDOHBK)
		{
			BBEEPJNEHBI = ICENKPDOHBK;
		}

		public virtual void CFGEKKHOKKE(CMNIABEFLBJ EFDLFNPAKGO)
		{
		}

		public virtual void JCOLMPJMMEB(PJEMPFEIOAK EFDLFNPAKGO)
		{
		}
	}
}
