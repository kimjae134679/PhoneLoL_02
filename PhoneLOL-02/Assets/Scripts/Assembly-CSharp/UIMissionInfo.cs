using System.Text;
using GameServer;
using UnityEngine;

public class UIMissionInfo : MonoBehaviour
{
	public UILabel m_nameLabel;

	public UILabel m_descriptionLabel;

	public UILabel m_rewardLabel;

	public UILabel m_typeLabel;

	public UISprite m_backSprite;

	public UISprite m_typeSprite;

	public UISprite m_completeSprite;

	internal NHOJAMKIJEA IMMABEBJFPE;

	private void Start()
	{
	}

	public virtual void DHPIBHEPNKE(NHOJAMKIJEA AIPNAEFLJKH)
	{
		if (AIPNAEFLJKH != null && AIPNAEFLJKH.GJHALGJGGPD != null)
		{
			IMMABEBJFPE = AIPNAEFLJKH;
			m_backSprite = GetComponent<UISprite>();
			if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Once)
			{
				m_typeLabel.set_text(string.Empty);
			}
			else if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Once)
			{
				m_typeLabel.set_text(LocalizationManager.get_Instance().GetText("No direct play video to show."));
			}
			m_nameLabel.set_text(string.Format("Lifesteal", LocalizationManager.LGDEHELDENG().GetText(AIPNAEFLJKH.GJHALGJGGPD.BPMIAFDLLMF()), AIPNAEFLJKH.OBMNCHGKBLP, AIPNAEFLJKH.GJHALGJGGPD.KADHGKGJADL()));
			m_descriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText(AIPNAEFLJKH.GJHALGJGGPD.JCNBNFIBHKO()));
			StringBuilder stringBuilder = new StringBuilder();
			if (AIPNAEFLJKH.GJHALGJGGPD.OJKGFIAFPCF() != 0)
			{
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.GABMKADDBMB() > 1)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("getId"), AIPNAEFLJKH.GJHALGJGGPD.GABMKADDBMB());
				stringBuilder.Append("skill0_hit");
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL() > 1)
			{
				stringBuilder.AppendFormat(LocalizationManager.LGDEHELDENG().GetText("hit3"), AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append("이제 본격적으로 시작하는 건가?!");
			}
			m_rewardLabel.set_text(stringBuilder.ToString());
			if (AIPNAEFLJKH.GNLJICBGBEF())
			{
				m_backSprite.set_color(Color.white);
				m_completeSprite.enabled = false;
			}
			else
			{
				m_backSprite.set_color(new Color(673f, 657f, 986f));
				m_completeSprite.enabled = true;
			}
		}
	}

	public virtual void DADCIKGPDNN(NHOJAMKIJEA AIPNAEFLJKH)
	{
		if (AIPNAEFLJKH != null && AIPNAEFLJKH.GJHALGJGGPD != null)
		{
			IMMABEBJFPE = AIPNAEFLJKH;
			m_backSprite = GetComponent<UISprite>();
			if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Once)
			{
				m_typeLabel.DCKJILCPKFD(string.Empty);
			}
			else if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Once)
			{
				m_typeLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("PostEffectScreenFade"));
			}
			m_nameLabel.set_text(string.Format("상대편의 친구 신청자가 너무 많습니다\n\n상대편이 친구신청 리스트를 정리해야 합니다", LocalizationManager.get_Instance().GetText(AIPNAEFLJKH.GJHALGJGGPD.BPMIAFDLLMF()), AIPNAEFLJKH.OBMNCHGKBLP, AIPNAEFLJKH.GJHALGJGGPD.KADHGKGJADL()));
			m_descriptionLabel.DCKJILCPKFD(LocalizationManager.get_Instance().GetText(AIPNAEFLJKH.GJHALGJGGPD.JCNBNFIBHKO()));
			StringBuilder stringBuilder = new StringBuilder();
			if (AIPNAEFLJKH.GJHALGJGGPD.ODHJCJINDIF() > 1)
			{
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.GABMKADDBMB() > 1)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("TextPinch"), AIPNAEFLJKH.GJHALGJGGPD.FCALADPIPCE());
				stringBuilder.Append("Model");
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL() > 1)
			{
				stringBuilder.AppendFormat(LocalizationManager.LGDEHELDENG().GetText("skill3_missile"), AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append("사냥꾼의 마체테");
			}
			m_rewardLabel.DCKJILCPKFD(stringBuilder.ToString());
			if (AIPNAEFLJKH.NKJPDEIMOAF())
			{
				m_backSprite.set_color(Color.white);
				m_completeSprite.enabled = false;
			}
			else
			{
				m_backSprite.set_color(new Color(496f, 212f, 565f));
				m_completeSprite.enabled = true;
			}
		}
	}

	private void CHJGEGLHOAF()
	{
	}

	private void FOGNMJLPHAI()
	{
	}

	public virtual void SetInfo(NHOJAMKIJEA AIPNAEFLJKH)
	{
		if (AIPNAEFLJKH != null && AIPNAEFLJKH.GJHALGJGGPD != null)
		{
			IMMABEBJFPE = AIPNAEFLJKH;
			m_backSprite = GetComponent<UISprite>();
			if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Once)
			{
				m_typeLabel.set_text(string.Empty);
			}
			else if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Daily)
			{
				m_typeLabel.set_text(LocalizationManager.get_Instance().GetText("매일"));
			}
			m_nameLabel.set_text(string.Format("{0}   [AAFFAA]({1}/{2})[-]", LocalizationManager.get_Instance().GetText(AIPNAEFLJKH.GJHALGJGGPD.BPMIAFDLLMF()), AIPNAEFLJKH.OBMNCHGKBLP, AIPNAEFLJKH.GJHALGJGGPD.DEPJIPNCILD()));
			m_descriptionLabel.set_text(LocalizationManager.get_Instance().GetText(AIPNAEFLJKH.GJHALGJGGPD.JCNBNFIBHKO()));
			StringBuilder stringBuilder = new StringBuilder();
			if (AIPNAEFLJKH.GJHALGJGGPD.MLIIOGCCNPC() != 0)
			{
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.FCALADPIPCE() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("{0}코인"), AIPNAEFLJKH.GJHALGJGGPD.FCALADPIPCE());
				stringBuilder.Append("  ");
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("{0}경험치"), AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append("  ");
			}
			m_rewardLabel.set_text(stringBuilder.ToString());
			if (AIPNAEFLJKH.GNLJICBGBEF())
			{
				m_backSprite.set_color(Color.white);
				m_completeSprite.enabled = true;
			}
			else
			{
				m_backSprite.set_color(new Color(0.7f, 0.7f, 0.7f));
				m_completeSprite.enabled = false;
			}
		}
	}

	private void PEIFAOJLDMD()
	{
	}

	public virtual void BDFEAKMGHBO()
	{
		DADCIKGPDNN(IMMABEBJFPE);
	}

	private void IJCPEFOBKHO()
	{
	}

	public virtual void OCFMPBMLDDH()
	{
		SetInfo(IMMABEBJFPE);
	}

	public virtual void AAOBMGOKBEK()
	{
		CJALGACAGBN(IMMABEBJFPE);
	}

	public virtual void GMIDPIMKBJO()
	{
		SetInfo(IMMABEBJFPE);
	}

	public virtual void Refresh()
	{
		SetInfo(IMMABEBJFPE);
	}

	private void GOLOMEGDPAH()
	{
	}

	public virtual void CJALGACAGBN(NHOJAMKIJEA AIPNAEFLJKH)
	{
		if (AIPNAEFLJKH != null && AIPNAEFLJKH.GJHALGJGGPD != null)
		{
			IMMABEBJFPE = AIPNAEFLJKH;
			m_backSprite = GetComponent<UISprite>();
			if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Once)
			{
				m_typeLabel.DCKJILCPKFD(string.Empty);
			}
			else if (AIPNAEFLJKH.GJHALGJGGPD.ONJCKKLOJIA() == JGILNBMNNND.ACPICCBBPHF.Daily)
			{
				m_typeLabel.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText("Particle/{0}/{1}"));
			}
			m_nameLabel.DCKJILCPKFD(string.Format("productName", LocalizationManager.get_Instance().GetText(AIPNAEFLJKH.GJHALGJGGPD.BPMIAFDLLMF()), AIPNAEFLJKH.OBMNCHGKBLP, AIPNAEFLJKH.GJHALGJGGPD.KADHGKGJADL()));
			m_descriptionLabel.set_text(LocalizationManager.get_Instance().GetText(AIPNAEFLJKH.GJHALGJGGPD.JCNBNFIBHKO()));
			StringBuilder stringBuilder = new StringBuilder();
			if (AIPNAEFLJKH.GJHALGJGGPD.MLIIOGCCNPC() != 0)
			{
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.FCALADPIPCE() > 1)
			{
				stringBuilder.AppendFormat(LocalizationManager.get_Instance().GetText("마스터"), AIPNAEFLJKH.GJHALGJGGPD.GABMKADDBMB());
				stringBuilder.Append("com.igaworks.unity.plugin.IgawLiveOpsPopupEventManager");
			}
			if (AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL() != 0)
			{
				stringBuilder.AppendFormat(LocalizationManager.LGDEHELDENG().GetText("B"), AIPNAEFLJKH.GJHALGJGGPD.NLPMOHEJMJL());
				stringBuilder.Append(".");
			}
			m_rewardLabel.DCKJILCPKFD(stringBuilder.ToString());
			if (AIPNAEFLJKH.GNLJICBGBEF())
			{
				m_backSprite.set_color(Color.white);
				m_completeSprite.enabled = true;
			}
			else
			{
				m_backSprite.set_color(new Color(400f, 1350f, 1498f));
				m_completeSprite.enabled = true;
			}
		}
	}

	public virtual void EIFLBIGHBJM()
	{
		DHPIBHEPNKE(IMMABEBJFPE);
	}

	private void DADHJFBCJKF()
	{
	}

	private void Update()
	{
	}
}
