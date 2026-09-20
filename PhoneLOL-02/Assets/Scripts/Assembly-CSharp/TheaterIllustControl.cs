using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TheaterIllustControl : MonoBehaviour
{
	public SpriteRenderer m_illust;

	public bool JLMOBACBFGP
	{
		get
		{
			return get_flip();
		}
		set
		{
			set_flip(value);
		}
	}

	private void FJFFMANPDJD()
	{
	}

	public bool get_flip()
	{
		if (m_illust.transform.localScale.x < 0f)
		{
			return true;
		}
		return false;
	}

	private void NFKJIJFHBGK()
	{
	}

	[SpecialName]
	public void CFHPIHOJNKP(bool ICENKPDOHBK)
	{
		m_illust.transform.localScale = new Vector3(ICENKPDOHBK ? (0f - Math.Abs(m_illust.transform.localScale.x)) : Math.Abs(m_illust.transform.localScale.x), m_illust.transform.localScale.y, m_illust.transform.localScale.z);
	}

	private void GOLOMEGDPAH()
	{
	}

	private void Update()
	{
	}

	private void BJKEPMGMJKA()
	{
	}

	[SpecialName]
	public void BFJMKNOKKIG(bool ICENKPDOHBK)
	{
		m_illust.transform.localScale = new Vector3(ICENKPDOHBK ? (0f - Math.Abs(m_illust.transform.localScale.x)) : Math.Abs(m_illust.transform.localScale.x), m_illust.transform.localScale.y, m_illust.transform.localScale.z);
	}

	private void DHMMCEBEAHA()
	{
	}

	public void set_flip(bool ICENKPDOHBK)
	{
		m_illust.transform.localScale = new Vector3(ICENKPDOHBK ? (0f - Math.Abs(m_illust.transform.localScale.x)) : Math.Abs(m_illust.transform.localScale.x), m_illust.transform.localScale.y, m_illust.transform.localScale.z);
	}

	private void LFAIPBJMGPO()
	{
	}

	[SpecialName]
	public void BKBEOKIGCDE(bool ICENKPDOHBK)
	{
		m_illust.transform.localScale = new Vector3(ICENKPDOHBK ? (0f - Math.Abs(m_illust.transform.localScale.x)) : Math.Abs(m_illust.transform.localScale.x), m_illust.transform.localScale.y, m_illust.transform.localScale.z);
	}

	private void GDKGBNKCGHO()
	{
	}

	public void BLNEMLCDJOF(string NCADFOBAFJD)
	{
	}

	public void PlayAnimation(string NCADFOBAFJD)
	{
	}

	private void BPLOLCKEJJK()
	{
	}

	private void Start()
	{
	}

	[SpecialName]
	public bool PDNOIJCHFKP()
	{
		if (m_illust.transform.localScale.x < 693f)
		{
			return false;
		}
		return true;
	}

	private void NMANMMOMHHD()
	{
	}

	public void PHECGMLBANM(string NCADFOBAFJD)
	{
	}
}
