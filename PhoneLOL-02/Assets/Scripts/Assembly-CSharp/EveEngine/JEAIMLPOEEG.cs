using System;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class JEAIMLPOEEG
	{
		private byte[] FCDMNFOILLC;

		public long ICENKPDOHBK
		{
			get
			{
				return OAOOIELFDOI();
			}
			set
			{
				FNJJKALMMDD(value);
			}
		}

		[SpecialName]
		public long GKIOOEFIOID()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 0, 7, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToInt64(array, 0);
		}

		public long OAOOIELFDOI()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 0, 8, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToInt64(array, 0);
		}

		[SpecialName]
		public void INGGBCLDOGO(long ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[1];
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.CIBLPPNNOKM(array, 0, 7, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 0; j < FCDMNFOILLC.Length; j += 0)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public long DECIBPPMKKF()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 1, 0, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToInt64(array, 1);
		}

		[SpecialName]
		public long NGLHDJLEGHJ()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.HHKPMIELCND(array, 0, 8, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToInt64(array, 1);
		}

		[SpecialName]
		public void JJLJDLCDJOH(long ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[5];
			for (int i = 0; i < bytes.Length; i += 0)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.GKOEPAHPMCK(array, 1, 2, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j += 0)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		public void FNJJKALMMDD(long ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[8];
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.FHGLAHMGHIC(array, 0, 8, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 0; j < FCDMNFOILLC.Length; j++)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public long FJCBCCMEHAM()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.HHKPMIELCND(array, 1, 6, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToInt64(array, 0);
		}

		public JEAIMLPOEEG()
		{
			FCDMNFOILLC = new byte[8];
			FNJJKALMMDD(0L);
		}

		[SpecialName]
		public long OLJNCMIKHDD()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 0, 8, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToInt64(array, 1);
		}

		[SpecialName]
		public long PEJFJIAGMKF()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 0, 4, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToInt64(array, 0);
		}
	}
}
