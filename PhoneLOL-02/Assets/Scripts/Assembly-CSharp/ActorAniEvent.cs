using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("ProjectT/Actor/ActorAniEvent")]
public class ActorAniEvent : MonoBehaviour
{
	public delegate void OEPBAKMJHOI();

	private OEPBAKMJHOI m_PCPCOFFCKNA;

	private OEPBAKMJHOI m_KCBHPEHFEDM;

	private OEPBAKMJHOI m_LJLFIFIMKHC;

	private OEPBAKMJHOI m_HJEGFADBKKH;

	private OEPBAKMJHOI m_IAOANEGOCFO;

	public event OEPBAKMJHOI PCPCOFFCKNA
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_m_attackEvent(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_m_attackEvent(value);
		}
	}

	public event OEPBAKMJHOI KCBHPEHFEDM
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_m_skill0Event(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_m_skill0Event(value);
		}
	}

	public event OEPBAKMJHOI LJLFIFIMKHC
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_m_skill1Event(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_m_skill1Event(value);
		}
	}

	public event OEPBAKMJHOI HJEGFADBKKH
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_m_skill2Event(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_m_skill2Event(value);
		}
	}

	public event OEPBAKMJHOI IAOANEGOCFO
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			add_m_skill3Event(value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			remove_m_skill3Event(value);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void add_m_skill2Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_HJEGFADBKKH = (OEPBAKMJHOI)Delegate.Combine(this.m_HJEGFADBKKH, ICENKPDOHBK);
	}

	private void DLCNJHLBIFM()
	{
	}

	public void NCEPHBGDDNN()
	{
		if (this.m_IAOANEGOCFO != null)
		{
			this.m_IAOANEGOCFO();
		}
	}

	[SpecialName]
	public void CNPHPPJOGFA(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_KCBHPEHFEDM = (OEPBAKMJHOI)Delegate.Combine(this.m_KCBHPEHFEDM, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void add_m_skill3Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_IAOANEGOCFO = (OEPBAKMJHOI)Delegate.Combine(this.m_IAOANEGOCFO, ICENKPDOHBK);
	}

	[SpecialName]
	public void OKCFAKDNDAF(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_KCBHPEHFEDM = (OEPBAKMJHOI)Delegate.Remove(this.m_KCBHPEHFEDM, ICENKPDOHBK);
	}

	[SpecialName]
	public void HNGAPEJODLJ(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_PCPCOFFCKNA = (OEPBAKMJHOI)Delegate.Remove(this.m_PCPCOFFCKNA, ICENKPDOHBK);
	}

	public void ILLLEEDAFBO()
	{
		if (this.m_LJLFIFIMKHC != null)
		{
			this.m_LJLFIFIMKHC();
		}
	}

	public void OnAttack()
	{
		if (this.m_PCPCOFFCKNA != null)
		{
			this.m_PCPCOFFCKNA();
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void remove_m_skill1Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_LJLFIFIMKHC = (OEPBAKMJHOI)Delegate.Remove(this.m_LJLFIFIMKHC, ICENKPDOHBK);
	}

	public void KLGKONNBPJD()
	{
		if (this.m_KCBHPEHFEDM != null)
		{
			this.m_KCBHPEHFEDM();
		}
	}

	public void OnSkill2()
	{
		if (this.m_HJEGFADBKKH != null)
		{
			this.m_HJEGFADBKKH();
		}
	}

	private void DADHJFBCJKF()
	{
	}

	[SpecialName]
	public void JLKHJKBAGFM(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_KCBHPEHFEDM = (OEPBAKMJHOI)Delegate.Remove(this.m_KCBHPEHFEDM, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void remove_m_skill2Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_HJEGFADBKKH = (OEPBAKMJHOI)Delegate.Remove(this.m_HJEGFADBKKH, ICENKPDOHBK);
	}

	private void ECPILACDMOP()
	{
	}

	private void Update()
	{
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void remove_m_skill0Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_KCBHPEHFEDM = (OEPBAKMJHOI)Delegate.Remove(this.m_KCBHPEHFEDM, ICENKPDOHBK);
	}

	private void Start()
	{
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void remove_m_attackEvent(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_PCPCOFFCKNA = (OEPBAKMJHOI)Delegate.Remove(this.m_PCPCOFFCKNA, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void add_m_skill1Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_LJLFIFIMKHC = (OEPBAKMJHOI)Delegate.Combine(this.m_LJLFIFIMKHC, ICENKPDOHBK);
	}

	public void KLJPMDJNIDK()
	{
		if (this.m_HJEGFADBKKH != null)
		{
			this.m_HJEGFADBKKH();
		}
	}

	public void OnSkill0()
	{
		if (this.m_KCBHPEHFEDM != null)
		{
			this.m_KCBHPEHFEDM();
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void remove_m_skill3Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_IAOANEGOCFO = (OEPBAKMJHOI)Delegate.Remove(this.m_IAOANEGOCFO, ICENKPDOHBK);
	}

	[SpecialName]
	public void ILAKGHCPPCH(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_IAOANEGOCFO = (OEPBAKMJHOI)Delegate.Combine(this.m_IAOANEGOCFO, ICENKPDOHBK);
	}

	public void OGOJLCCOOON()
	{
		if (this.m_LJLFIFIMKHC != null)
		{
			this.m_LJLFIFIMKHC();
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void add_m_attackEvent(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_PCPCOFFCKNA = (OEPBAKMJHOI)Delegate.Combine(this.m_PCPCOFFCKNA, ICENKPDOHBK);
	}

	public void OnSkill1()
	{
		if (this.m_LJLFIFIMKHC != null)
		{
			this.m_LJLFIFIMKHC();
		}
	}

	private void BPLOLCKEJJK()
	{
	}

	public void IDBMFEECJPF()
	{
		if (this.m_HJEGFADBKKH != null)
		{
			this.m_HJEGFADBKKH();
		}
	}

	public void NDHNMMLGKIK()
	{
		if (this.m_IAOANEGOCFO != null)
		{
			this.m_IAOANEGOCFO();
		}
	}

	[SpecialName]
	public void FPMIEJHKELF(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_PCPCOFFCKNA = (OEPBAKMJHOI)Delegate.Remove(this.m_PCPCOFFCKNA, ICENKPDOHBK);
	}

	private void CCFKJLBFCDE()
	{
	}

	public void OnSkill3()
	{
		if (this.m_IAOANEGOCFO != null)
		{
			this.m_IAOANEGOCFO();
		}
	}

	[SpecialName]
	public void MFMAMLOHKJF(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_HJEGFADBKKH = (OEPBAKMJHOI)Delegate.Combine(this.m_HJEGFADBKKH, ICENKPDOHBK);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	public void add_m_skill0Event(OEPBAKMJHOI ICENKPDOHBK)
	{
		this.m_KCBHPEHFEDM = (OEPBAKMJHOI)Delegate.Combine(this.m_KCBHPEHFEDM, ICENKPDOHBK);
	}

	public void AGBMBGIIBDE()
	{
		if (this.m_HJEGFADBKKH != null)
		{
			this.m_HJEGFADBKKH();
		}
	}

	private void LateUpdate()
	{
	}
}
