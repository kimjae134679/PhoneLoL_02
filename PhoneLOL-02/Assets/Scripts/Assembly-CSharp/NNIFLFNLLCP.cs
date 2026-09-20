using System.Collections.Generic;

public class NNIFLFNLLCP
{
	public class FPOBKLFFOIA
	{
		public uint OHGOBGOIECH;

		public string NCADFOBAFJD;

		public bool KJMGOIKHPOI;

		public FPOBKLFFOIA()
		{
			NCADFOBAFJD = string.Empty;
		}
	}

	private static Dictionary<uint, FPOBKLFFOIA> DMMLNFEHFGK = new Dictionary<uint, FPOBKLFFOIA>();

	public static string KOHGEKLILEN(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = true;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.get_Instance().FGAGFCDEKCC().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static string GEIMDLHLKOE(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = false;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static void HOBEOFGIILE(uint OHGOBGOIECH, string NCADFOBAFJD)
	{
		FPOBKLFFOIA value = null;
		if (DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) && value != null)
		{
			value.NCADFOBAFJD = NCADFOBAFJD;
			value.KJMGOIKHPOI = true;
		}
	}

	public static void NHEJNKOPNPA(uint OHGOBGOIECH, string NCADFOBAFJD)
	{
		FPOBKLFFOIA value = null;
		if (DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) && value != null)
		{
			value.NCADFOBAFJD = NCADFOBAFJD;
			value.KJMGOIKHPOI = false;
		}
	}

	public static string DNBFPCMKKAP(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = true;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.get_Instance().FGAGFCDEKCC().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static string DGGHDMMGJGI(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = true;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.APAPJEIBEDE().FGAGFCDEKCC().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static void KGFFLHKPMKG(uint OHGOBGOIECH, string NCADFOBAFJD)
	{
		FPOBKLFFOIA value = null;
		if (DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) && value != null)
		{
			value.NCADFOBAFJD = NCADFOBAFJD;
			value.KJMGOIKHPOI = true;
		}
	}

	public static void AOKCAILOFPD(uint OHGOBGOIECH, string NCADFOBAFJD)
	{
		FPOBKLFFOIA value = null;
		if (DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) && value != null)
		{
			value.NCADFOBAFJD = NCADFOBAFJD;
			value.KJMGOIKHPOI = false;
		}
	}

	public static string AOODEPGCBLE(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = false;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static void KJLGKNCFCPB(uint OHGOBGOIECH, string NCADFOBAFJD)
	{
		FPOBKLFFOIA value = null;
		if (DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) && value != null)
		{
			value.NCADFOBAFJD = NCADFOBAFJD;
			value.KJMGOIKHPOI = true;
		}
	}

	public static string JBKGENEJCKK(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = false;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.get_Instance().get_m_communityNetClient().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static string JBKFGFHOGEI(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = true;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.APAPJEIBEDE().ALOBHBHLDKK().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static void AMGPDDGOLEA(uint OHGOBGOIECH, string NCADFOBAFJD)
	{
		FPOBKLFFOIA value = null;
		if (DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) && value != null)
		{
			value.NCADFOBAFJD = NCADFOBAFJD;
			value.KJMGOIKHPOI = false;
		}
	}

	public static string COPHJAHDHOL(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = false;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.get_Instance().ALOBHBHLDKK().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}

	public static void LMFKBLFDAEP(uint OHGOBGOIECH, string NCADFOBAFJD)
	{
		FPOBKLFFOIA value = null;
		if (DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) && value != null)
		{
			value.NCADFOBAFJD = NCADFOBAFJD;
			value.KJMGOIKHPOI = true;
		}
	}

	public static string JNPBKBLBJFD(uint OHGOBGOIECH)
	{
		if (OHGOBGOIECH == 0)
		{
			return string.Empty;
		}
		FPOBKLFFOIA value = null;
		if (!DMMLNFEHFGK.TryGetValue(OHGOBGOIECH, out value) || value == null)
		{
			value = new FPOBKLFFOIA();
			value.OHGOBGOIECH = OHGOBGOIECH;
			value.KJMGOIKHPOI = false;
			DMMLNFEHFGK.Add(OHGOBGOIECH, value);
			NetworkManager.get_Instance().ALOBHBHLDKK().IAFGAGLHEIA(OHGOBGOIECH);
		}
		return value.NCADFOBAFJD;
	}
}
