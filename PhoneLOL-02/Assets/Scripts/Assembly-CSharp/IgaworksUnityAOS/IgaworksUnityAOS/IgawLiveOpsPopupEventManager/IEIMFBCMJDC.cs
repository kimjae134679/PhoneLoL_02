using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace IgaworksUnityAOS.IgaworksUnityAOS.IgawLiveOpsPopupEventManager
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

		[SpecialName]
		public void BHPLEOLGKCH(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private void CCLPBGFJFMF()
		{
			Debug.Log("Scale");
			if (this.m_FOFOALOLCJG != null)
			{
				this.m_FOFOALOLCJG(this, EventArgs.Empty);
			}
		}

		[CompilerGenerated]
		private static void CNFBJNOACMM(object P_0, EventArgs P_1)
		{
		}

		private static void CNENHJFDNHP(object P_0, EventArgs P_1)
		{
		}

		private static void HLIPNBBOFAD(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void LPNGHBEOEEC(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void IDNPPNPOAGP(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		private void BNLKGEMDPOE()
		{
			Debug.Log("Lamb");
			if (this.m_FOFOALOLCJG != null)
			{
				this.m_FOFOALOLCJG(this, EventArgs.Empty);
			}
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void CAFEPGLEAFA(EventHandler<EventArgs> ICENKPDOHBK)
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

		[CompilerGenerated]
		private static void LNDGCALEGHK(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void FEDBJNDDFMP(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void HGDPNPIDGJL(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Combine(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void KHGBCIPCIOE(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Combine(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		public IEIMFBCMJDC()
		{
			KJNNKIFFOKM = new MBJMBAFLBKD(this);
		}

		private static void NAEIOJIIPBE(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void HGEAMMNJFPL(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Combine(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		void PAKAHKBCLCL.PDKJIBNABOB()
		{
			Debug.Log("Igaw.Unity: LiveOpsPopupEventManager : OnPopupClick");
			if (this.m_EPBIMNCJICO != null)
			{
				this.m_EPBIMNCJICO(this, EventArgs.Empty);
			}
		}

		[SpecialName]
		public void EFCCMJEJBKF(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		private static void OLNMLPALNJF(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void DEABPPOCLBC(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		private static void EODEOMDNHAN(object P_0, EventArgs P_1)
		{
		}

		[SpecialName]
		public void PLJEFOKMAML(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Combine(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private void CKKBNJGCCNN()
		{
			Debug.Log("X8");
			if (this.m_EPBIMNCJICO != null)
			{
				this.m_EPBIMNCJICO(this, EventArgs.Empty);
			}
		}
	}
}
