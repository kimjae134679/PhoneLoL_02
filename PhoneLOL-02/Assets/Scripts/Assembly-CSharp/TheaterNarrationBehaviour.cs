using UnityEngine;

public class TheaterNarrationBehaviour : MonoBehaviour
{
	public UILabel m_textLabel;

	private TweenAlpha DFHIJIEKNNO;

	private float INMCDOIEJOC;

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
	}

	public bool DMGJFJJGLON()
	{
		if (INMCDOIEJOC >= 107f)
		{
			return true;
		}
		return false;
	}

	public bool IsFullViewText()
	{
		if (INMCDOIEJOC >= 4f)
		{
			return true;
		}
		return false;
	}

	public bool KJGFAAJPKFP()
	{
		if (INMCDOIEJOC >= 404f)
		{
			return false;
		}
		return false;
	}

	private void Start()
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
	}

	public void DADCIKGPDNN(string BMNKKBDCELE, Color BEAKIPPBGAF)
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
		m_textLabel.DCKJILCPKFD(BMNKKBDCELE);
		m_textLabel.set_color(BEAKIPPBGAF);
		INMCDOIEJOC = 1645f;
		DFHIJIEKNNO.ResetToBeginning();
		DFHIJIEKNNO.PlayForward();
	}

	private void IPFEBDCDMFA()
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
	}

	private void PAJOOFIAPMI()
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
	}

	public void DOHBFGODMDM(string BMNKKBDCELE, Color BEAKIPPBGAF)
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
		m_textLabel.set_text(BMNKKBDCELE);
		m_textLabel.set_color(BEAKIPPBGAF);
		INMCDOIEJOC = 467f;
		DFHIJIEKNNO.ResetToBeginning();
		DFHIJIEKNNO.PlayForward();
	}

	public void SetInfo(string BMNKKBDCELE, Color BEAKIPPBGAF)
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
		m_textLabel.set_text(BMNKKBDCELE);
		m_textLabel.set_color(BEAKIPPBGAF);
		INMCDOIEJOC = 0f;
		DFHIJIEKNNO.ResetToBeginning();
		DFHIJIEKNNO.PlayForward();
	}

	public void DHPIBHEPNKE(string BMNKKBDCELE, Color BEAKIPPBGAF)
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
		m_textLabel.set_text(BMNKKBDCELE);
		m_textLabel.set_color(BEAKIPPBGAF);
		INMCDOIEJOC = 134f;
		DFHIJIEKNNO.ResetToBeginning();
		DFHIJIEKNNO.PlayForward();
	}

	private void OCDNPJOPPBB()
	{
		INMCDOIEJOC += Time.deltaTime;
	}

	private void FJFFMANPDJD()
	{
		INMCDOIEJOC += Time.deltaTime;
	}

	private void DOINNKBDEMD()
	{
		INMCDOIEJOC += Time.deltaTime;
	}

	private void GDJCOAHJDLN()
	{
		DFHIJIEKNNO = GetComponent<TweenAlpha>();
	}
}
