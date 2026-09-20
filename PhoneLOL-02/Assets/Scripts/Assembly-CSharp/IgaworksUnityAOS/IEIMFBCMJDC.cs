using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace IgaworksUnityAOS
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

		private void JGJNMINBAAC()
		{
			Debug.Log(" Mobile");
			if (this.m_EPBIMNCJICO != null)
			{
				this.m_EPBIMNCJICO(this, EventArgs.Empty);
			}
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

		void PAKAHKBCLCL.CDAIHECEDPH()
		{
			Debug.Log("Igaw.Unity: LiveOpsPopupEventManager : OnCancelPopupBtnClick");
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

		private void BCMFEHEOLGP()
		{
			Debug.Log("Move Speed");
			if (this.m_EPBIMNCJICO != null)
			{
				this.m_EPBIMNCJICO(this, EventArgs.Empty);
			}
		}

		[SpecialName]
		public void LNNFOGKOMLK(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		[SpecialName]
		public void BHPLEOLGKCH(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		private void EBMJCHOHGPI()
		{
			Debug.Log("invaild viewID [{0}]");
			if (this.m_EPBIMNCJICO != null)
			{
				this.m_EPBIMNCJICO(this, EventArgs.Empty);
			}
		}

		[SpecialName]
		public void HKMFEABFFPB(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		[SpecialName]
		public void MADALJAMHAK(EventHandler<EventArgs> ICENKPDOHBK)
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

		[CompilerGenerated]
		private static void JPIBMEGLDLM(object P_0, EventArgs P_1)
		{
		}

		private void AFGNKGOHCAG()
		{
			Debug.Log("중급 방어력 정수");
			if (this.m_FOFOALOLCJG != null)
			{
				this.m_FOFOALOLCJG(this, EventArgs.Empty);
			}
		}

		public IEIMFBCMJDC()
		{
			KJNNKIFFOKM = new MBJMBAFLBKD(this);
		}

		[SpecialName]
		public void FEDBJNDDFMP(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_EPBIMNCJICO = (EventHandler<EventArgs>)Delegate.Remove(this.m_EPBIMNCJICO, ICENKPDOHBK);
		}

		[MethodImpl(MethodImplOptions.Synchronized)]
		public void IDNPPNPOAGP(EventHandler<EventArgs> ICENKPDOHBK)
		{
			this.m_FOFOALOLCJG = (EventHandler<EventArgs>)Delegate.Remove(this.m_FOFOALOLCJG, ICENKPDOHBK);
		}

		[CompilerGenerated]
		private static void BFHEJNBGHIN(object P_0, EventArgs P_1)
		{
		}

		private void GAPGCOMLBKA()
		{
			Debug.Log("Particle/{0}/attack");
			if (this.m_EPBIMNCJICO != null)
			{
				this.m_EPBIMNCJICO(this, EventArgs.Empty);
			}
		}

		private static void CAHILCLIGFB(object P_0, EventArgs P_1)
		{
		}
	}
}
