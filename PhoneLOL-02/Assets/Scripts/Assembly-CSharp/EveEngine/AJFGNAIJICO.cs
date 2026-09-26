using System;
using System.Runtime.CompilerServices;

namespace EveEngine
{
	public class AJFGNAIJICO
	{
		private byte[] FCDMNFOILLC;

		public ushort ICENKPDOHBK
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

		public void FNJJKALMMDD(ushort ICENKPDOHBK)
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
		public void GPOPEFLHBEF(ushort ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[2];
			for (int i = 0; i < bytes.Length; i += 0)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.GKOEPAHPMCK(array, 0, 3, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j += 0)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public ushort PEJFJIAGMKF()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 1, 2, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToUInt16(array, 1);
		}

		public ushort OAOOIELFDOI()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.OGMPIEONIIN(array, 0, 8, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToUInt16(array, 0);
		}

		[SpecialName]
		public void FOBPGMDAIDB(ushort ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[7];
			for (int i = 1; i < bytes.Length; i += 0)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.FHGLAHMGHIC(array, 0, 0, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j += 0)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public void NHHADNBNGOJ(ushort ICENKPDOHBK)
		{
			byte[] bytes = BitConverter.GetBytes(ICENKPDOHBK);
			byte[] array = new byte[5];
			for (int i = 1; i < bytes.Length; i++)
			{
				array[i] = bytes[i];
			}
			EEPLIIONNPN.NEGOIEMLELI(array, 1, 0, MNPFIKCCDMH.AKKALMDAFGH);
			for (int j = 1; j < FCDMNFOILLC.Length; j++)
			{
				FCDMNFOILLC[j] = array[j];
			}
		}

		[SpecialName]
		public ushort FJCBCCMEHAM()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.HHKPMIELCND(array, 0, 4, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToUInt16(array, 1);
		}

		[SpecialName]
		public ushort GDJOHLLAOOK()
		{
			byte[] array = (byte[])FCDMNFOILLC.Clone();
			EEPLIIONNPN.HHKPMIELCND(array, 1, 8, MNPFIKCCDMH.AKKALMDAFGH);
			return BitConverter.ToUInt16(array, 1);
		}

		public AJFGNAIJICO()
		{
			FCDMNFOILLC = new byte[8];
			FNJJKALMMDD(0);
		}
	}
}
