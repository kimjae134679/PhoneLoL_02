using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Localize")]
[ExecuteInEditMode]
[RequireComponent(typeof(UIWidget))]
public class UILocalize : MonoBehaviour
{
	public string key;

	private bool BAMIBNMGNBO;

	public string ICENKPDOHBK
	{
		set
		{
			set_value(value);
		}
	}

	private void LFAIPBJMGPO()
	{
		BAMIBNMGNBO = false;
		OCGMJNGCPFC();
	}

	private void FOGNMJLPHAI()
	{
		BAMIBNMGNBO = false;
		OnLocalize();
	}

	private void OnEnable()
	{
		if (BAMIBNMGNBO)
		{
			OnLocalize();
		}
	}

	private void NMANMMOMHHD()
	{
		BAMIBNMGNBO = false;
		OCGMJNGCPFC();
	}

	private void FMDCADHECGH()
	{
		BAMIBNMGNBO = true;
		OCGMJNGCPFC();
	}

	public void set_value(string ICENKPDOHBK)
	{
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			return;
		}
		UIWidget component = GetComponent<UIWidget>();
		UILabel uILabel = component as UILabel;
		UISprite uISprite = component as UISprite;
		if (uILabel != null)
		{
			UIInput uIInput = NLDABIMKKMP.ANPDHFFNJFD<UIInput>(uILabel.gameObject);
			if (uIInput != null && uIInput.label == uILabel)
			{
				uIInput.set_defaultText(ICENKPDOHBK);
			}
			else
			{
				uILabel.set_text(ICENKPDOHBK);
			}
		}
		else if (uISprite != null)
		{
			uISprite.set_spriteName(ICENKPDOHBK);
			uISprite.MakePixelPerfect();
		}
	}

	private void OCGMJNGCPFC()
	{
		if (string.IsNullOrEmpty(key))
		{
			UILabel component = GetComponent<UILabel>();
			if (component != null)
			{
				key = component.get_text();
			}
		}
		if (!string.IsNullOrEmpty(key))
		{
			IEIEDCKPGLK(FKHDOBFNMLP.OHKHGNFHJJM(key));
		}
	}

	private void BPLOLCKEJJK()
	{
		BAMIBNMGNBO = true;
		OCGMJNGCPFC();
	}

	private void FMNOLGPIIFB()
	{
		BAMIBNMGNBO = true;
		OnLocalize();
	}

	private void Start()
	{
		BAMIBNMGNBO = true;
		OnLocalize();
	}

	[SpecialName]
	public void ICKFKDNHDOG(string ICENKPDOHBK)
	{
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			return;
		}
		UIWidget component = GetComponent<UIWidget>();
		UILabel uILabel = component as UILabel;
		UISprite uISprite = component as UISprite;
		if (uILabel != null)
		{
			UIInput uIInput = NLDABIMKKMP.ANPDHFFNJFD<UIInput>(uILabel.gameObject);
			if (uIInput != null && uIInput.label == uILabel)
			{
				uIInput.set_defaultText(ICENKPDOHBK);
			}
			else
			{
				uILabel.set_text(ICENKPDOHBK);
			}
		}
		else if (uISprite != null)
		{
			uISprite.set_spriteName(ICENKPDOHBK);
			uISprite.MakePixelPerfect();
		}
	}

	private void EKJCKGFDGFK()
	{
		if (BAMIBNMGNBO)
		{
			OnLocalize();
		}
	}

	private void DHMMCEBEAHA()
	{
		BAMIBNMGNBO = false;
		OnLocalize();
	}

	private void CFEIPPFANKJ()
	{
		if (BAMIBNMGNBO)
		{
			OCGMJNGCPFC();
		}
	}

	[SpecialName]
	public void IEIEDCKPGLK(string ICENKPDOHBK)
	{
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			return;
		}
		UIWidget component = GetComponent<UIWidget>();
		UILabel uILabel = component as UILabel;
		UISprite uISprite = component as UISprite;
		if (uILabel != null)
		{
			UIInput uIInput = NLDABIMKKMP.ANPDHFFNJFD<UIInput>(uILabel.gameObject);
			if (uIInput != null && uIInput.label == uILabel)
			{
				uIInput.set_defaultText(ICENKPDOHBK);
			}
			else
			{
				uILabel.DCKJILCPKFD(ICENKPDOHBK);
			}
		}
		else if (uISprite != null)
		{
			uISprite.set_spriteName(ICENKPDOHBK);
			uISprite.MakePixelPerfect();
		}
	}

	private void NFKJIJFHBGK()
	{
		BAMIBNMGNBO = false;
		OCGMJNGCPFC();
	}

	private void IBBJMMFDGAL()
	{
		BAMIBNMGNBO = true;
		OCGMJNGCPFC();
	}

	[SpecialName]
	public void HDDKOCJHKMH(string ICENKPDOHBK)
	{
		if (string.IsNullOrEmpty(ICENKPDOHBK))
		{
			return;
		}
		UIWidget component = GetComponent<UIWidget>();
		UILabel uILabel = component as UILabel;
		UISprite uISprite = component as UISprite;
		if (uILabel != null)
		{
			UIInput uIInput = NLDABIMKKMP.ANPDHFFNJFD<UIInput>(uILabel.gameObject);
			if (uIInput != null && uIInput.label == uILabel)
			{
				uIInput.set_defaultText(ICENKPDOHBK);
			}
			else
			{
				uILabel.set_text(ICENKPDOHBK);
			}
		}
		else if (uISprite != null)
		{
			uISprite.set_spriteName(ICENKPDOHBK);
			uISprite.MakePixelPerfect();
		}
	}

	private void OnLocalize()
	{
		if (string.IsNullOrEmpty(key))
		{
			UILabel component = GetComponent<UILabel>();
			if (component != null)
			{
				key = component.get_text();
			}
		}
		if (!string.IsNullOrEmpty(key))
		{
			set_value(FKHDOBFNMLP.OHKHGNFHJJM(key));
		}
	}

	private void GKNMGIONEKK()
	{
		BAMIBNMGNBO = false;
		OnLocalize();
	}
}
