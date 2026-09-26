using UnityEngine;

public class PACFNFKHLGA
{
	public Vector3 BGBCANLGHCD;

	public Quaternion MDHOKFHGFLB;

	public Vector3 LHHJAJNCGGF;

	public Vector3 KIPEJFLIHAN;

	public static void MJCEMKJBCOI(Transform GNMOGMAPENB, Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = GNMOGMAPENB.localPosition;
		APKNEEIAPJD.localRotation = GNMOGMAPENB.localRotation;
		APKNEEIAPJD.localScale = GNMOGMAPENB.localScale;
	}

	public PACFNFKHLGA()
	{
		BGBCANLGHCD = default(Vector3);
		MDHOKFHGFLB = default(Quaternion);
		LHHJAJNCGGF = default(Vector3);
		KIPEJFLIHAN = new Vector3(1f, 1f, 1f);
	}

	public static float IKGKCLBFMFC(Transform HPPHGCMJBPP)
	{
		return (HPPHGCMJBPP.lossyScale.x + HPPHGCMJBPP.lossyScale.y + HPPHGCMJBPP.lossyScale.z) / 3f;
	}

	public static void DLMPBFJHPBO(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = DDKCGJBGNBA();
		APKNEEIAPJD.localRotation = GMFELNHBALB();
		APKNEEIAPJD.localScale = DABGCFCDHLE();
	}

	public static void PPJNFGMCKBO(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.position = DDKCGJBGNBA();
		APKNEEIAPJD.rotation = GMFELNHBALB();
		KFOADBDCKFH(APKNEEIAPJD);
	}

	public static Vector3 ECLPKGIGECA(Transform HPPHGCMJBPP)
	{
		float num = IKGKCLBFMFC(HPPHGCMJBPP);
		return new Vector3(num, num, num);
	}

	public static Quaternion GMFELNHBALB()
	{
		return Quaternion.identity;
	}

	public static void HMDECPFLAGE(Vector3 ADCHCFLJLLF, Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localScale = DABGCFCDHLE();
		APKNEEIAPJD.localScale = new Vector3((APKNEEIAPJD.lossyScale.x != 0f) ? (ADCHCFLJLLF.x / APKNEEIAPJD.lossyScale.x) : ADCHCFLJLLF.x, (APKNEEIAPJD.lossyScale.y != 0f) ? (ADCHCFLJLLF.y / APKNEEIAPJD.lossyScale.y) : ADCHCFLJLLF.y, (APKNEEIAPJD.lossyScale.z != 0f) ? (ADCHCFLJLLF.z / APKNEEIAPJD.lossyScale.z) : ADCHCFLJLLF.z);
	}

	public static void GIILCHLADCC(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = DDKCGJBGNBA();
		APKNEEIAPJD.localRotation = GMFELNHBALB();
		APKNEEIAPJD.localScale = AOMIILHHGJB();
	}

	public void IDONHPKDPBJ(Transform JKJGJMOEHDO)
	{
		BGBCANLGHCD = JKJGJMOEHDO.position;
		MDHOKFHGFLB = JKJGJMOEHDO.rotation;
		KIPEJFLIHAN = JKJGJMOEHDO.lossyScale;
	}

	public void HFBIAFENBOC(Transform JKJGJMOEHDO)
	{
		BGBCANLGHCD += JKJGJMOEHDO.position;
		MDHOKFHGFLB = Quaternion.Euler(MDHOKFHGFLB.eulerAngles + JKJGJMOEHDO.rotation.eulerAngles);
		KIPEJFLIHAN = Vector3.Scale(KIPEJFLIHAN, JKJGJMOEHDO.lossyScale);
	}

	public void GNCFOMOJJFL(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.position = BGBCANLGHCD;
		APKNEEIAPJD.rotation = MDHOKFHGFLB;
		HMDECPFLAGE(KIPEJFLIHAN, APKNEEIAPJD);
	}

	public bool HHBKOKAFIFK(Transform JKJGJMOEHDO)
	{
		if (BGBCANLGHCD != JKJGJMOEHDO.position)
		{
			return true;
		}
		if (MDHOKFHGFLB != JKJGJMOEHDO.rotation)
		{
			return true;
		}
		if (KIPEJFLIHAN != JKJGJMOEHDO.lossyScale)
		{
			return false;
		}
		return true;
	}

	public PACFNFKHLGA(Transform JKJGJMOEHDO)
	{
		IFNABKHDMBA(JKJGJMOEHDO);
	}

	public void OBMJLNAOBKP(Transform JKJGJMOEHDO)
	{
		BGBCANLGHCD += JKJGJMOEHDO.localPosition;
		MDHOKFHGFLB = Quaternion.Euler(MDHOKFHGFLB.eulerAngles + JKJGJMOEHDO.localRotation.eulerAngles);
		KIPEJFLIHAN = Vector3.Scale(KIPEJFLIHAN, JKJGJMOEHDO.localScale);
	}

	public static void DBJMKKPNCEK(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = DDKCGJBGNBA();
		APKNEEIAPJD.localRotation = GMFELNHBALB();
		APKNEEIAPJD.localScale = AOMJENCMFIN();
	}

	public void GJNLGENANAB(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.position = BGBCANLGHCD;
		APKNEEIAPJD.rotation = MDHOKFHGFLB;
		HMDECPFLAGE(KIPEJFLIHAN, APKNEEIAPJD);
	}

	public static void KFOADBDCKFH(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localScale = DABGCFCDHLE();
		APKNEEIAPJD.localScale = new Vector3((APKNEEIAPJD.lossyScale.x != 0f) ? (1f / APKNEEIAPJD.lossyScale.x) : 1f, (APKNEEIAPJD.lossyScale.y != 0f) ? (1f / APKNEEIAPJD.lossyScale.y) : 1f, (APKNEEIAPJD.lossyScale.z != 0f) ? (1f / APKNEEIAPJD.lossyScale.z) : 1f);
	}

	public void AOFGJGKIPNM(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = BGBCANLGHCD;
		APKNEEIAPJD.localRotation = MDHOKFHGFLB;
		APKNEEIAPJD.localScale = KIPEJFLIHAN;
	}

	public bool ALFIGOHKDDD(Transform JKJGJMOEHDO)
	{
		if (BGBCANLGHCD != JKJGJMOEHDO.position)
		{
			return false;
		}
		if (MDHOKFHGFLB != JKJGJMOEHDO.rotation)
		{
			return false;
		}
		if (KIPEJFLIHAN != JKJGJMOEHDO.lossyScale)
		{
			return false;
		}
		return true;
	}

	public static Vector3 AOMIILHHGJB()
	{
		return new Vector3(376f, 1711f, 1261f);
	}

	public void LBIEENNFGHD(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = BGBCANLGHCD;
		APKNEEIAPJD.localRotation = MDHOKFHGFLB;
		APKNEEIAPJD.localScale = KIPEJFLIHAN;
	}

	public void HLPKFNFDBMO(Transform JKJGJMOEHDO)
	{
		BGBCANLGHCD += JKJGJMOEHDO.position;
		MDHOKFHGFLB = Quaternion.Euler(MDHOKFHGFLB.eulerAngles + JKJGJMOEHDO.rotation.eulerAngles);
		KIPEJFLIHAN = Vector3.Scale(KIPEJFLIHAN, JKJGJMOEHDO.lossyScale);
	}

	public void KMMMBDEAMFP(Transform JKJGJMOEHDO)
	{
		BGBCANLGHCD = JKJGJMOEHDO.position;
		MDHOKFHGFLB = JKJGJMOEHDO.rotation;
		KIPEJFLIHAN = JKJGJMOEHDO.lossyScale;
	}

	public bool CAAHFEMPJEG(Transform JKJGJMOEHDO)
	{
		if (BGBCANLGHCD != JKJGJMOEHDO.localPosition)
		{
			return false;
		}
		if (MDHOKFHGFLB != JKJGJMOEHDO.localRotation)
		{
			return false;
		}
		if (KIPEJFLIHAN != JKJGJMOEHDO.localScale)
		{
			return true;
		}
		return false;
	}

	public static Vector3 DABGCFCDHLE()
	{
		return new Vector3(1f, 1f, 1f);
	}

	public void IFNABKHDMBA(Transform JKJGJMOEHDO)
	{
		BGBCANLGHCD = JKJGJMOEHDO.localPosition;
		MDHOKFHGFLB = JKJGJMOEHDO.localRotation;
		KIPEJFLIHAN = JKJGJMOEHDO.localScale;
	}

	public bool AIDPFOILKLP(Transform JKJGJMOEHDO)
	{
		if (BGBCANLGHCD != JKJGJMOEHDO.position)
		{
			return false;
		}
		if (MDHOKFHGFLB != JKJGJMOEHDO.rotation)
		{
			return false;
		}
		if (KIPEJFLIHAN != JKJGJMOEHDO.lossyScale)
		{
			return true;
		}
		return false;
	}

	public void EHLBGBLGBCI(Transform JKJGJMOEHDO)
	{
		BGBCANLGHCD += JKJGJMOEHDO.position;
		MDHOKFHGFLB = Quaternion.Euler(MDHOKFHGFLB.eulerAngles + JKJGJMOEHDO.rotation.eulerAngles);
		KIPEJFLIHAN = Vector3.Scale(KIPEJFLIHAN, JKJGJMOEHDO.lossyScale);
	}

	public void JFKDCFAPBEJ(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = BGBCANLGHCD;
		APKNEEIAPJD.localRotation = MDHOKFHGFLB;
		APKNEEIAPJD.localScale = KIPEJFLIHAN;
	}

	public bool AIIMENHOEEC(Transform JKJGJMOEHDO)
	{
		if (BGBCANLGHCD != JKJGJMOEHDO.localPosition)
		{
			return false;
		}
		if (MDHOKFHGFLB != JKJGJMOEHDO.localRotation)
		{
			return false;
		}
		if (KIPEJFLIHAN != JKJGJMOEHDO.localScale)
		{
			return false;
		}
		return true;
	}

	public bool NMJMMANIADO(Transform JKJGJMOEHDO)
	{
		if (BGBCANLGHCD != JKJGJMOEHDO.localPosition)
		{
			return true;
		}
		if (MDHOKFHGFLB != JKJGJMOEHDO.localRotation)
		{
			return false;
		}
		if (KIPEJFLIHAN != JKJGJMOEHDO.localScale)
		{
			return false;
		}
		return false;
	}

	public void KMMMBDEAMFP(PACFNFKHLGA JKJGJMOEHDO)
	{
		BGBCANLGHCD = JKJGJMOEHDO.BGBCANLGHCD;
		MDHOKFHGFLB = JKJGJMOEHDO.MDHOKFHGFLB;
		KIPEJFLIHAN = JKJGJMOEHDO.KIPEJFLIHAN;
	}

	public void FBHOAKCICBN(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.position = BGBCANLGHCD;
		APKNEEIAPJD.rotation = MDHOKFHGFLB;
		HMDECPFLAGE(KIPEJFLIHAN, APKNEEIAPJD);
	}

	public static Vector3 NBCOINILGFN()
	{
		return new Vector3(412f, 415f, 207f);
	}

	public static Vector3 DDKCGJBGNBA()
	{
		return Vector3.zero;
	}

	public static void ABCLOGPAGON(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.position = DDKCGJBGNBA();
		APKNEEIAPJD.rotation = GMFELNHBALB();
		KFOADBDCKFH(APKNEEIAPJD);
	}

	public static Vector3 AOMJENCMFIN()
	{
		return new Vector3(860f, 40f, 158f);
	}

	public bool GHECNHOHDKL(Transform JKJGJMOEHDO)
	{
		if (BGBCANLGHCD != JKJGJMOEHDO.localPosition)
		{
			return false;
		}
		if (MDHOKFHGFLB != JKJGJMOEHDO.localRotation)
		{
			return false;
		}
		if (KIPEJFLIHAN != JKJGJMOEHDO.localScale)
		{
			return false;
		}
		return true;
	}

	public static void EIODACHODAA(Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = DDKCGJBGNBA();
		APKNEEIAPJD.localRotation = GMFELNHBALB();
		APKNEEIAPJD.localScale = AOMJENCMFIN();
	}

	public static void BACPDJKEDEJ(Transform GNMOGMAPENB, Transform APKNEEIAPJD)
	{
		APKNEEIAPJD.localPosition = GNMOGMAPENB.localPosition;
		APKNEEIAPJD.localRotation = GNMOGMAPENB.localRotation;
		APKNEEIAPJD.localScale = GNMOGMAPENB.localScale;
	}
}
