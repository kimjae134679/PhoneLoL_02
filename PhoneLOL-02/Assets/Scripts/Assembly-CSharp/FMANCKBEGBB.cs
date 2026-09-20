using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class FMANCKBEGBB
{
	public enum AOAOIDDIIKE
	{
		Left = 0,
		Center = 1,
		Right = 2
	}

	public enum JLAMNMBFPBK
	{
		Hero = 0,
		Light = 1,
		Dark = 2
	}

	private sealed class PGFELGBAAOK : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal JLAMNMBFPBK BDIGPAOEKPN;

		internal AOAOIDDIIKE HEPNHCEIFMO;

		internal string NCADFOBAFJD;

		internal bool NCDNGHPLOGH;

		internal string BMNKKBDCELE;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal JLAMNMBFPBK JACIEODFGOP;

		internal AOAOIDDIIKE NKFEPGMMNMM;

		internal string DEOIGLHAKDJ;

		internal bool LOMLGABOCEP;

		internal string IHIEHDNONHD;

		internal FMANCKBEGBB KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		public void PLOOENOBGJL()
		{
			throw new NotSupportedException();
		}

		public void JJFHJIEJKNJ()
		{
			throw new NotSupportedException();
		}

		public bool KKJFPODFKCB()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().KEGOGOCGOHB((TheaterTalkWindowBehaviour.MKLGBPDOGFC)BDIGPAOEKPN, (TheaterTalkIllustBehaviour.CGNFDFOCFHO)HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH, BMNKKBDCELE));
				GOMFKPLCGNN = 0;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().Talk((TheaterTalkWindowBehaviour.MKLGBPDOGFC)BDIGPAOEKPN, (TheaterTalkIllustBehaviour.CGNFDFOCFHO)HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH, BMNKKBDCELE));
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object BOHACHPKNOE()
		{
			return MMEGGNJKNOH;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void LKGMENJHBGF()
		{
			GOMFKPLCGNN = -1;
		}

		public bool BDHBKIPJENC()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().NOPBAAAOMLP((TheaterTalkWindowBehaviour.MKLGBPDOGFC)BDIGPAOEKPN, (TheaterTalkIllustBehaviour.CGNFDFOCFHO)HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH, BMNKKBDCELE));
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object KKGNLCJGHID()
		{
			return MMEGGNJKNOH;
		}

		public bool AAAMEOEOJHM()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().KEGOGOCGOHB((TheaterTalkWindowBehaviour.MKLGBPDOGFC)BDIGPAOEKPN, (TheaterTalkIllustBehaviour.CGNFDFOCFHO)HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH, BMNKKBDCELE));
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public void AHEHIJAMCDO()
		{
			GOMFKPLCGNN = -1;
		}

		public void EJAKHHBBJPL()
		{
			throw new NotSupportedException();
		}

		public void OCFAAIMPJFI()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LCJGIOCHEJO()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BDANALHKFBH()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().KEGOGOCGOHB((TheaterTalkWindowBehaviour.MKLGBPDOGFC)BDIGPAOEKPN, (TheaterTalkIllustBehaviour.CGNFDFOCFHO)HEPNHCEIFMO, NCADFOBAFJD, NCDNGHPLOGH, BMNKKBDCELE));
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}
	}

	private sealed class NOKBGKNMAJL : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal string BMNKKBDCELE;

		internal Color BEAKIPPBGAF;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal string IHIEHDNONHD;

		internal Color LFPNEMBHJJC;

		internal FMANCKBEGBB KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		public bool GMJNFFCMCNJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().Narration(BMNKKBDCELE, BEAKIPPBGAF));
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object KAMNAHHFPLK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object GLNBOOGOGOO()
		{
			return MMEGGNJKNOH;
		}

		public bool LLKGBIDKCOF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().JDDGNIIBOHB(BMNKKBDCELE, BEAKIPPBGAF));
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().Narration(BMNKKBDCELE, BEAKIPPBGAF));
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().JDDGNIIBOHB(BMNKKBDCELE, BEAKIPPBGAF));
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		public void AOLCKHCODEM()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object NGJKALDEDFM()
		{
			return MMEGGNJKNOH;
		}

		public bool DKGDMIMNCFJ()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = KNIAJMGDGAA.LNKGHAKHDIF(TheaterManager.get_Instance().JDDGNIIBOHB(BMNKKBDCELE, BEAKIPPBGAF));
				GOMFKPLCGNN = 0;
				return true;
			case 1u:
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object FFJDBFMILPN()
		{
			return MMEGGNJKNOH;
		}

		public void BKAONBFNGOC()
		{
			throw new NotSupportedException();
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}
	}

	private int OPOBCLNMELP;

	public FMANCKBEGBB()
	{
	}

	public virtual void LDNEFFHJNPL()
	{
	}

	public abstract IEnumerator LPBLGFCPADD();

	public virtual void MGOENKOOFLO()
	{
	}

	public virtual void HIGCLCKDNIB()
	{
		CILGGLEAAFC(true);
		PFIINNGKNJH();
		HFDIAILALDC(false, Color.black);
		TheaterManager.get_Instance().End();
	}

	public Coroutine LNKGHAKHDIF(IEnumerator FHHGLHGHAFC)
	{
		return TheaterManager.get_Instance().StartCoroutine(FHHGLHGHAFC);
	}

	[DebuggerHidden]
	protected IEnumerator CCOOKGINGLB(JLAMNMBFPBK BDIGPAOEKPN, AOAOIDDIIKE HEPNHCEIFMO, string NCADFOBAFJD, bool NCDNGHPLOGH, string BMNKKBDCELE)
	{
		PGFELGBAAOK pGFELGBAAOK = new PGFELGBAAOK();
		pGFELGBAAOK.BDIGPAOEKPN = BDIGPAOEKPN;
		pGFELGBAAOK.HEPNHCEIFMO = HEPNHCEIFMO;
		pGFELGBAAOK.NCADFOBAFJD = NCADFOBAFJD;
		pGFELGBAAOK.NCDNGHPLOGH = NCDNGHPLOGH;
		pGFELGBAAOK.BMNKKBDCELE = BMNKKBDCELE;
		pGFELGBAAOK.JACIEODFGOP = BDIGPAOEKPN;
		pGFELGBAAOK.NKFEPGMMNMM = HEPNHCEIFMO;
		pGFELGBAAOK.DEOIGLHAKDJ = NCADFOBAFJD;
		pGFELGBAAOK.LOMLGABOCEP = NCDNGHPLOGH;
		pGFELGBAAOK.IHIEHDNONHD = BMNKKBDCELE;
		pGFELGBAAOK.KNIAJMGDGAA = this;
		return pGFELGBAAOK;
	}

	protected void PFIINNGKNJH()
	{
		TheaterManager.get_Instance().CloseTalk();
	}

	[DebuggerHidden]
	protected IEnumerator MOHBBHHKONN(Color BEAKIPPBGAF, string BMNKKBDCELE)
	{
		NOKBGKNMAJL nOKBGKNMAJL = new NOKBGKNMAJL();
		nOKBGKNMAJL.BMNKKBDCELE = BMNKKBDCELE;
		nOKBGKNMAJL.BEAKIPPBGAF = BEAKIPPBGAF;
		nOKBGKNMAJL.IHIEHDNONHD = BMNKKBDCELE;
		nOKBGKNMAJL.LFPNEMBHJJC = BEAKIPPBGAF;
		nOKBGKNMAJL.KNIAJMGDGAA = this;
		return nOKBGKNMAJL;
	}

	protected void CILGGLEAAFC(bool EGPIIGGMKHJ)
	{
		TheaterManager.get_Instance().ToggleGUI(EGPIIGGMKHJ);
	}

	protected void ODBENGJMILH(float LFNNGEKFJBI)
	{
		ActorManager.get_Instance().SetFrequency(LFNNGEKFJBI);
	}

	protected void GLMCJIHGHBJ(float PJJFCGMEIFE = 5f, float HBNDHMPNCME = 1f)
	{
		TheaterManager.get_Instance().CameraShake(PJJFCGMEIFE, HBNDHMPNCME);
	}

	protected void HDNLHLGJAFO(string NCADFOBAFJD)
	{
		if (OPOBCLNMELP == 0)
		{
			OPOBCLNMELP = SoundManager.get_Instance().GetCurrentBGMNameHash();
		}
		SoundManager.get_Instance().PlayBGM(NCADFOBAFJD);
	}

	protected void FJIJMDFPAFI()
	{
		SoundManager.get_Instance().StopBGM();
	}

	protected void NOOFEJDIMKG()
	{
		if (OPOBCLNMELP != 0)
		{
			SoundManager.get_Instance().PlayBGM(OPOBCLNMELP);
			OPOBCLNMELP = 0;
		}
	}

	protected void FANLLKDLCPF(string NCADFOBAFJD)
	{
		SoundManager.get_Instance().PlaySound(NCADFOBAFJD);
	}

	protected void KHHCEAEJBKL(bool EBBBIBCMBAM)
	{
		if (EBBBIBCMBAM)
		{
			PostProcessManager.get_Instance().EnableSepiaTone();
		}
		else
		{
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.SepiaTone);
		}
	}

	protected void BLBIFFIAMHP(bool EBBBIBCMBAM)
	{
		if (EBBBIBCMBAM)
		{
			PostProcessManager.get_Instance().EnableGrayscale();
		}
		else
		{
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.Grayscale);
		}
	}

	protected void MEIABDOICOF(bool EBBBIBCMBAM, float MEGDEIKCOII = 180f)
	{
		if (EBBBIBCMBAM)
		{
			PostProcessManager.get_Instance().EnableTwirl(MEGDEIKCOII);
		}
		else
		{
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.Twirl);
		}
	}

	protected void NNNAHIPHNDI(bool EBBBIBCMBAM, Color BEAKIPPBGAF, float MEGDEIKCOII = 0.5f)
	{
		MEGDEIKCOII = 0f - MEGDEIKCOII;
		if (EBBBIBCMBAM)
		{
			PostProcessManager.get_Instance().EnableScreenFade(BEAKIPPBGAF, 1f, MEGDEIKCOII);
		}
		else
		{
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.ScreenFade);
		}
	}

	protected void JMOACOOLDCH(bool EBBBIBCMBAM, Color BEAKIPPBGAF, float MEGDEIKCOII = 0.5f)
	{
		if (EBBBIBCMBAM)
		{
			PostProcessManager.get_Instance().EnableScreenFade(BEAKIPPBGAF, 0f, MEGDEIKCOII);
		}
		else
		{
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.ScreenFade);
		}
	}

	protected void HFDIAILALDC(bool EBBBIBCMBAM, Color BEAKIPPBGAF)
	{
		if (EBBBIBCMBAM)
		{
			PostProcessManager.get_Instance().EnableScreenFade(BEAKIPPBGAF, 1f, 0f);
		}
		else
		{
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.ScreenFade);
		}
	}
}
