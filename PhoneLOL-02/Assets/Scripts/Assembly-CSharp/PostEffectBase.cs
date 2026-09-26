using UnityEngine;

public class PostEffectBase : MonoBehaviour
{
	public RenderTexture m_sourceTexture;

	public RenderTexture m_targetTexture;

	public UITexture m_screenTexture;

	private RenderTexture NAGMDLMAGGJ;

	private void OnPreCull()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	public RenderTexture IEELAJHKGGG()
	{
		return NAGMDLMAGGJ;
	}

	public RenderTexture OJGHFMEFMGE()
	{
		if (NAGMDLMAGGJ == m_sourceTexture)
		{
			NAGMDLMAGGJ = m_targetTexture;
			m_screenTexture.set_mainTexture(m_targetTexture);
			return m_targetTexture;
		}
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
		return m_sourceTexture;
	}

	public RenderTexture EALLIBIGHPM()
	{
		if (NAGMDLMAGGJ == m_sourceTexture)
		{
			NAGMDLMAGGJ = m_targetTexture;
			m_screenTexture.set_mainTexture(m_targetTexture);
			return m_targetTexture;
		}
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
		return m_sourceTexture;
	}

	public RenderTexture CDMDELILHMC()
	{
		if (NAGMDLMAGGJ == m_sourceTexture)
		{
			NAGMDLMAGGJ = m_targetTexture;
			m_screenTexture.set_mainTexture(m_targetTexture);
			return m_targetTexture;
		}
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
		return m_sourceTexture;
	}

	private void Start()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	private void HAPMMNKOMDC()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	private void LFAIPBJMGPO()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	private void PJJBLKPPFEN()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	private void HPCJJBPPPPN()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	public RenderTexture GetTarget()
	{
		if (NAGMDLMAGGJ == m_sourceTexture)
		{
			NAGMDLMAGGJ = m_targetTexture;
			m_screenTexture.set_mainTexture(m_targetTexture);
			return m_targetTexture;
		}
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
		return m_sourceTexture;
	}

	private void BJFPJALLFFL()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	public RenderTexture KAKOOLAPCLP()
	{
		if (NAGMDLMAGGJ == m_sourceTexture)
		{
			NAGMDLMAGGJ = m_targetTexture;
			m_screenTexture.set_mainTexture(m_targetTexture);
			return m_targetTexture;
		}
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
		return m_sourceTexture;
	}

	public RenderTexture GFKMFMBHGPG()
	{
		if (NAGMDLMAGGJ == m_sourceTexture)
		{
			NAGMDLMAGGJ = m_targetTexture;
			m_screenTexture.set_mainTexture(m_targetTexture);
			return m_targetTexture;
		}
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
		return m_sourceTexture;
	}

	private void EBHPOBLLBKG()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	private void MDIBCLMFCDH()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	public RenderTexture KDKPIBMGHGI()
	{
		return NAGMDLMAGGJ;
	}

	private void IBBJMMFDGAL()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	public RenderTexture KGHPEJPKECL()
	{
		return NAGMDLMAGGJ;
	}

	private void NFKJIJFHBGK()
	{
		NAGMDLMAGGJ = m_sourceTexture;
		m_screenTexture.set_mainTexture(m_sourceTexture);
	}

	public RenderTexture HDBAKILBPEO()
	{
		return NAGMDLMAGGJ;
	}

	public RenderTexture AJKLKGKECPH()
	{
		return NAGMDLMAGGJ;
	}

	public RenderTexture GetSource()
	{
		return NAGMDLMAGGJ;
	}
}
