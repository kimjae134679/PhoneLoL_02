using UnityEngine;

public class UIMessageBox : MonoBehaviour
{
	public class OBFPGCJFBNL
	{
		public string DGGJBFIOGLP;

		public bool DEFPDJJKCLE;

		public NICHPBLEBEI KDCDLLMMINL;

		public NICHPBLEBEI OBJMBAKEDGA;

		public bool OIGBBINEPEA;

		public bool OKIGEBPMPBH;

		public void EKIOLLKEHGM()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = true;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = false;
			OKIGEBPMPBH = false;
		}

		public void ALEGAHHEGCK()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = true;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = true;
			OKIGEBPMPBH = true;
		}

		public void LDNEFFHJNPL()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = false;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = false;
			OKIGEBPMPBH = false;
		}

		public void INOKJCKAONB()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = false;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = false;
			OKIGEBPMPBH = true;
		}

		public void OMDJLPCAMIG()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = true;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = false;
			OKIGEBPMPBH = true;
		}

		public void GHFNEDIPGDP()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = true;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = true;
			OKIGEBPMPBH = true;
		}

		public void BCGICPOKOHO()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = false;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = false;
			OKIGEBPMPBH = true;
		}

		public void NECJDAEBLDA()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = false;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = true;
			OKIGEBPMPBH = false;
		}

		public void NNBHCBPELPG()
		{
			DGGJBFIOGLP = string.Empty;
			DEFPDJJKCLE = true;
			KDCDLLMMINL = null;
			OBJMBAKEDGA = null;
			OIGBBINEPEA = false;
			OKIGEBPMPBH = false;
		}
	}

	public delegate void NICHPBLEBEI();

	public UILabel m_messageLabel;

	public UIButton m_okButton;

	public UIButton m_cancelButton;

	private OBFPGCJFBNL MPLJJDGBEPI = new OBFPGCJFBNL();

	public void OnClickCancelButton()
	{
		MPLJJDGBEPI.OKIGEBPMPBH = true;
		if (MPLJJDGBEPI.OBJMBAKEDGA != null)
		{
			MPLJJDGBEPI.OBJMBAKEDGA();
		}
		base.gameObject.SetActive(false);
		MsgManager.get_Instance().RemoveMessageInfo(MPLJJDGBEPI);
	}

	private void DNBDGBJNCBP()
	{
	}

	public void EJLJJLLCAGI()
	{
		MPLJJDGBEPI.OIGBBINEPEA = true;
		if (MPLJJDGBEPI.KDCDLLMMINL != null)
		{
			MPLJJDGBEPI.KDCDLLMMINL();
		}
		base.gameObject.SetActive(true);
		MsgManager.get_Instance().GIBPGJKKGKO(MPLJJDGBEPI);
	}

	public void LCCMMFOGKED()
	{
		MPLJJDGBEPI.OIGBBINEPEA = true;
		if (MPLJJDGBEPI.KDCDLLMMINL != null)
		{
			MPLJJDGBEPI.KDCDLLMMINL();
		}
		base.gameObject.SetActive(false);
		MsgManager.get_Instance().GIBPGJKKGKO(MPLJJDGBEPI);
	}

	public void OnClickOKButton()
	{
		MPLJJDGBEPI.OIGBBINEPEA = true;
		if (MPLJJDGBEPI.KDCDLLMMINL != null)
		{
			MPLJJDGBEPI.KDCDLLMMINL();
		}
		base.gameObject.SetActive(false);
		MsgManager.get_Instance().RemoveMessageInfo(MPLJJDGBEPI);
	}

	private void OnDisable()
	{
	}

	public void IEPMMBBMGCJ(OBFPGCJFBNL FHPFBPNCGOC)
	{
		MPLJJDGBEPI = FHPFBPNCGOC;
		m_messageLabel.set_text(MPLJJDGBEPI.DGGJBFIOGLP);
		m_cancelButton.gameObject.SetActive(MPLJJDGBEPI.DEFPDJJKCLE);
	}

	private void GPFPLFJCNOL()
	{
	}

	private void Update()
	{
	}

	private void IPFEBDCDMFA()
	{
	}

	private void IFJGPCOJDMM()
	{
	}

	public void SetInfo(OBFPGCJFBNL FHPFBPNCGOC)
	{
		MPLJJDGBEPI = FHPFBPNCGOC;
		m_messageLabel.set_text(MPLJJDGBEPI.DGGJBFIOGLP);
		m_cancelButton.gameObject.SetActive(MPLJJDGBEPI.DEFPDJJKCLE);
	}

	public void Init()
	{
		MPLJJDGBEPI.LDNEFFHJNPL();
	}

	public void NNBHCBPELPG()
	{
		MPLJJDGBEPI.INOKJCKAONB();
	}

	private void Start()
	{
	}

	public void INOKJCKAONB()
	{
		MPLJJDGBEPI.ALEGAHHEGCK();
	}

	private void FIGIAACOJMH()
	{
	}

	public void GAGCCNCIKKG(OBFPGCJFBNL FHPFBPNCGOC)
	{
		MPLJJDGBEPI = FHPFBPNCGOC;
		m_messageLabel.DCKJILCPKFD(MPLJJDGBEPI.DGGJBFIOGLP);
		m_cancelButton.gameObject.SetActive(MPLJJDGBEPI.DEFPDJJKCLE);
	}

	public void LMJOANHHCHI(OBFPGCJFBNL FHPFBPNCGOC)
	{
		MPLJJDGBEPI = FHPFBPNCGOC;
		m_messageLabel.DCKJILCPKFD(MPLJJDGBEPI.DGGJBFIOGLP);
		m_cancelButton.gameObject.SetActive(MPLJJDGBEPI.DEFPDJJKCLE);
	}

	public void HOIBCDMLEEK(OBFPGCJFBNL FHPFBPNCGOC)
	{
		MPLJJDGBEPI = FHPFBPNCGOC;
		m_messageLabel.DCKJILCPKFD(MPLJJDGBEPI.DGGJBFIOGLP);
		m_cancelButton.gameObject.SetActive(MPLJJDGBEPI.DEFPDJJKCLE);
	}

	public void MGMHNEMIOGK()
	{
		MPLJJDGBEPI.OIGBBINEPEA = true;
		if (MPLJJDGBEPI.KDCDLLMMINL != null)
		{
			MPLJJDGBEPI.KDCDLLMMINL();
		}
		base.gameObject.SetActive(false);
		MsgManager.get_Instance().GIBPGJKKGKO(MPLJJDGBEPI);
	}
}
