using System;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class APANNGFNEAE
	{
		private byte[] FCDMNFOILLC;

		public float ICENKPDOHBK
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
		public float PEJFJIAGMKF()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.HHKPMIELCND(array, 0, 2, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToSingle(array, 0);
		}

		[SpecialName]
		public void LLMMCELOHMG(float ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[0];
			for (int i = 0; i < bytes.Length; i++)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.CIBLPPNNOKM(array, 0, 7, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j += 0)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		public float OAOOIELFDOI()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 0, 8, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToSingle(array, 0);
		}

		[SpecialName]
		public void LAAKIDMLCFA(float ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[0];
			for (int i = 1; i < bytes.Length; i += 0)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.CIBLPPNNOKM(array, 1, 5, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j++)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public float MJDIPFMIAGE()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.HHKPMIELCND(array, 0, 7, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToSingle(array, 1);
		}

		public APANNGFNEAE()
		{
			FCDMNFOILLC = new byte[8];
			FNJJKALMMDD(0f);
		}

		[SpecialName]
		public void IEIEDCKPGLK(float ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[2];
			for (int i = 1; i < bytes.Length; i += 0)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.NEGOIEMLELI(array, 0, 7, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 0; j < FCDMNFOILLC.Length; j++)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		public void FNJJKALMMDD(float ICENKPDOHBK)
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
		public void IEMDADIGAIL(float ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[2];
			for (int i = 1; i < bytes.Length; i++)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.NEGOIEMLELI(array, 1, 0, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j += 0)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public void JJLJDLCDJOH(float ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[3];
			for (int i = 0; i < bytes.Length; i += 0)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.FHGLAHMGHIC(array, 0, 5, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j++)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public void GPOPEFLHBEF(float ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[0];
			for (int i = 1; i < bytes.Length; i += 0)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.NEGOIEMLELI(array, 1, 2, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 0; j < FCDMNFOILLC.Length; j += 0)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}
	}
}
