using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace IgaworksUnityAOS.IgawLiveOpsPopupEventManager
{
	internal class IEIMFBCMJDC : PAKAHKBCLCL
	{
		private MBJMBAFLBKD KJNNKIFFOKM;

		private EventHandler<EventArgs> m_EPBIMNCJICO = delegate
		{
		};

		private EventHandler<EventArgs> m_FOFOALOLCJG = delegate
		{
		};

		[CompilerGenerated]
		private static EventHandler<EventArgs> LMHKLDMDCGN;

		[CompilerGenerated]
		private static EventHandler<EventArgs> EBEPKDBGDGN;

		public event EventHandler<EventArgs> EPBIMNCJICO
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				HGDPNPIDGJL(value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				CAFEPGLEAFA(value);
			}
		}

		public event EventHandler<EventArgs> FOFOALOLCJG
		{
			[MethodImpl(MethodImplOptions.Synchronized)]
			add
			{
				KHGBCIPCIOE(value);
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			remove
			{
				IDNPPNPOAGP(value);
			}
		}

		[CompilerGenerated]
		private static void JHPEMCJLOPF(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void MBHNDMMKFMJ(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void IDNPPNPOAGP(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void CAFEPGLEAFA(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		void PAKAHKBCLCL.PDKJIBNABOB()
		{
			Debug.Log("Igaw.Unity: LiveOpsPopupEventManager : OnPopupClick");
			if (this.m_EPBIMNCJICO != null)
			{
				this.m_EPBIMNCJICO(this, EventArgs.Empty);
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void KHGBCIPCIOE(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Combine(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		private static void KEJHGHADMDD(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void OHFLECOFNPA(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		[SpecialName]
		public void CEMBEBKEKDP(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Combine(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private static void EDCNGGFNAJM(object P_0, EventArgs P_1)
		{
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void HGDPNPIDGJL(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Combine(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private static void PKBKNALOGKJ(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void NGGOIDJIIAJ(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		[SpecialName]
		public void ICFBPFJHKAF(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private static void JAHNGMKCKDB(object P_0, EventArgs P_1)
		{
		}

		private void BBBEHBNLIAM()
		{
			Debug.Log("Controls");
			if (this.m_FOFOALOLCJG != null)
			{
				this.m_FOFOALOLCJG(this, EventArgs.Empty);
			}
		}

		[SpecialName]
		public void KDOLAIPKBGH(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		[SpecialName]
		public void IBFCHNHGMEA(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		private static void PIGJHKEAPEK(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void ADBEELCDHAA(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		private void LMJMIKFOPGJ()
		{
			Debug.Log("Safe LoadLevel end");
			if (this.m_FOFOALOLCJG != null)
			{
				this.m_FOFOALOLCJG(this, EventArgs.Empty);
			}
		}

		[CompilerGenerated]
		private static void LDPGNMJHONN(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void LPOPBPGIPHC(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Combine(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private static void AAEEDIMOBOM(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void CJMNAPKICAD(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		void PAKAHKBCLCL.CDAIHECEDPH()
		{
			Debug.Log("Igaw.Unity: LiveOpsPopupEventManager : OnCancelPopupBtnClick");
			if (this.m_FOFOALOLCJG != null)
			{
				this.m_FOFOALOLCJG(this, EventArgs.Empty);
			}
		}

		[SpecialName]
		public void KDIJIIGBOEP(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Combine(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private void MODOBKGGBJP()
		{
			Debug.Log("0.0");
			if (this.m_FOFOALOLCJG != null)
			{
				this.m_FOFOALOLCJG(this, EventArgs.Empty);
			}
		}

		[SpecialName]
		public void ANFFBHBFCJI(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		private static void HLBFABGAILO(object P_0, EventArgs P_1)
		{
		}

		public IEIMFBCMJDC()
		{
			KJNNKIFFOKM = new MBJMBAFLBKD(this);
		}
	}
}
