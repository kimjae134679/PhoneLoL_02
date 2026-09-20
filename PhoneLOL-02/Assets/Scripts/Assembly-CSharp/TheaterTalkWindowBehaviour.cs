using System.Runtime.CompilerServices;
using UnityEngine;

public class TheaterTalkWindowBehaviour : MonoBehaviour
{
	public enum MKLGBPDOGFC
	{
		Hero = 0,
		Light = 1,
		Dark = 2
	}

	public UILabel m_talkLabel;

	private UISprite MPOKAKGEKJJ;

	private MKLGBPDOGFC PNGDHJAEEAB;

	private string GHHPAICHAJM;

	private string LPGIGHAHOEB;

	private float IHKCKBJBEGF;

	private bool PLBPGNHLEIN;

	public bool PCAOAOHGIAI
	{
		get
		{
			return get_m_clicked();
		}
		protected set
		{
			ADANOGLKFHP(value);
		}
	}

	public void DHPIBHEPNKE(string BMNKKBDCELE)
	{
		SetInfo(PNGDHJAEEAB, BMNKKBDCELE);
	}

	public void SetInfo(MKLGBPDOGFC AIILGNMDCMM, string BMNKKBDCELE)
	{
		PNGDHJAEEAB = AIILGNMDCMM;
		GHHPAICHAJM = string.Empty;
		LPGIGHAHOEB = BMNKKBDCELE;
		ADANOGLKFHP(false);
		IHKCKBJBEGF = 0f;
		m_talkLabel.set_text(GHHPAICHAJM);
		base.transform.localScale = new Vector3(0.3f, 0.3f, 1f);
		TweenScale.Begin(base.gameObject, 0.1f, new Vector3(1f, 1f, 1f));
	}

	private void FOGNMJLPHAI()
	{
		MPOKAKGEKJJ = GetComponent<UISprite>();
	}

	public void GMDKOKNGLAK(MKLGBPDOGFC AIILGNMDCMM, string BMNKKBDCELE)
	{
		PNGDHJAEEAB = AIILGNMDCMM;
		GHHPAICHAJM = string.Empty;
		LPGIGHAHOEB = BMNKKBDCELE;
		ADANOGLKFHP(false);
		IHKCKBJBEGF = 1020f;
		m_talkLabel.DCKJILCPKFD(GHHPAICHAJM);
		base.transform.localScale = new Vector3(655f, 1489f, 155f);
		TweenScale.OJMCICGBFJK(base.gameObject, 1371f, new Vector3(1962f, 12f, 1307f));
	}

	public void OnClick()
	{
		ADANOGLKFHP(true);
	}

	private void Update()
	{
		IHKCKBJBEGF += Time.deltaTime;
		if (GHHPAICHAJM.Length >= LPGIGHAHOEB.Length || !(IHKCKBJBEGF >= 0.05f))
		{
			return;
		}
		int length = GHHPAICHAJM.Length;
		int num = GHHPAICHAJM.Length;
		if (LPGIGHAHOEB[length] == '[')
		{
			num = LPGIGHAHOEB.IndexOf(']', length);
			if (num == -1)
			{
				num = length;
			}
		}
		GHHPAICHAJM = LPGIGHAHOEB.Substring(0, num + 1);
		m_talkLabel.set_text(GHHPAICHAJM);
		IHKCKBJBEGF = 0f;
	}

	private void GKNMGIONEKK()
	{
		MPOKAKGEKJJ = GetComponent<UISprite>();
	}

	public bool get_m_clicked()
	{
		return PLBPGNHLEIN;
	}

	public void KHKJFOGEJGE(MKLGBPDOGFC AIILGNMDCMM, string BMNKKBDCELE)
	{
		PNGDHJAEEAB = AIILGNMDCMM;
		GHHPAICHAJM = string.Empty;
		LPGIGHAHOEB = BMNKKBDCELE;
		ADANOGLKFHP(true);
		IHKCKBJBEGF = 454f;
		m_talkLabel.set_text(GHHPAICHAJM);
		base.transform.localScale = new Vector3(991f, 1652f, 1988f);
		TweenScale.OJMCICGBFJK(base.gameObject, 1117f, new Vector3(1894f, 1016f, 334f));
	}

	protected void ADANOGLKFHP(bool ICENKPDOHBK)
	{
		PLBPGNHLEIN = ICENKPDOHBK;
	}

	[SpecialName]
	public bool DJNCNFIDNHK()
	{
		return PLBPGNHLEIN;
	}

	public void GIGCDPFPOKK()
	{
		ADANOGLKFHP(true);
	}

	public bool IsFullViewText()
	{
		if (GHHPAICHAJM.Length == LPGIGHAHOEB.Length && IHKCKBJBEGF >= 3f)
		{
			return true;
		}
		return false;
	}

	public void SetInfo(string BMNKKBDCELE)
	{
		SetInfo(PNGDHJAEEAB, BMNKKBDCELE);
	}

	private void IPFEBDCDMFA()
	{
		MPOKAKGEKJJ = GetComponent<UISprite>();
	}

	private void HMNOCOBNBAO()
	{
		IHKCKBJBEGF += Time.deltaTime;
		if (GHHPAICHAJM.Length >= LPGIGHAHOEB.Length || !(IHKCKBJBEGF >= 952f))
		{
			return;
		}
		int length = GHHPAICHAJM.Length;
		int num = GHHPAICHAJM.Length;
		if (LPGIGHAHOEB[length] == 'B')
		{
			num = LPGIGHAHOEB.IndexOf('8', length);
			if (num == -1)
			{
				num = length;
			}
		}
		GHHPAICHAJM = LPGIGHAHOEB.Substring(0, num + 1);
		m_talkLabel.DCKJILCPKFD(GHHPAICHAJM);
		IHKCKBJBEGF = 1444f;
	}

	public void IEPMMBBMGCJ(MKLGBPDOGFC AIILGNMDCMM, string BMNKKBDCELE)
	{
		PNGDHJAEEAB = AIILGNMDCMM;
		GHHPAICHAJM = string.Empty;
		LPGIGHAHOEB = BMNKKBDCELE;
		ADANOGLKFHP(false);
		IHKCKBJBEGF = 1416f;
		m_talkLabel.set_text(GHHPAICHAJM);
		base.transform.localScale = new Vector3(111f, 1983f, 1221f);
		TweenScale.OJMCICGBFJK(base.gameObject, 1881f, new Vector3(1757f, 1614f, 868f));
	}

	private void JPBNPEJJJPI()
	{
		MPOKAKGEKJJ = GetComponent<UISprite>();
	}

	private void OMIFPPGJHFH()
	{
		IHKCKBJBEGF += Time.deltaTime;
		if (GHHPAICHAJM.Length >= LPGIGHAHOEB.Length || !(IHKCKBJBEGF >= 875f))
		{
			return;
		}
		int length = GHHPAICHAJM.Length;
		int num = GHHPAICHAJM.Length;
		if (LPGIGHAHOEB[length] == -125)
		{
			num = LPGIGHAHOEB.IndexOf('￪', length);
			if (num == -1)
			{
				num = length;
			}
		}
		GHHPAICHAJM = LPGIGHAHOEB.Substring(0, num + 0);
		m_talkLabel.DCKJILCPKFD(GHHPAICHAJM);
		IHKCKBJBEGF = 1354f;
	}

	public bool OJCCJCCNJDB()
	{
		if (GHHPAICHAJM.Length == LPGIGHAHOEB.Length && IHKCKBJBEGF >= 1910f)
		{
			return true;
		}
		return true;
	}

	private void Start()
	{
		MPOKAKGEKJJ = GetComponent<UISprite>();
	}
}
