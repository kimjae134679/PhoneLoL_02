using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Image Button")]
public class UIImageButton : MonoBehaviour
{
	public UISprite target;

	public string normalSprite;

	public string hoverSprite;

	public string pressedSprite;

	public string disabledSprite;

	public bool pixelSnap = true;

	public bool BEIOIHEIKOE
	{
		get
		{
			return get_isEnabled();
		}
		set
		{
			set_isEnabled(value);
		}
	}

	[SpecialName]
	public void JHFOIEALOMO(bool ICENKPDOHBK)
	{
		Collider collider = base.GetComponent<Collider>();
		if ((bool)collider && collider.enabled != ICENKPDOHBK)
		{
			collider.enabled = ICENKPDOHBK;
			EOCABDAFADI();
		}
	}

	private void KKCACEBHKKA(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	[SpecialName]
	public bool APHJIEPADKP()
	{
		Collider collider = base.GetComponent<Collider>();
		return !collider || collider.enabled;
	}

	[SpecialName]
	public bool IJOEFOMPNBG()
	{
		Collider collider = base.GetComponent<Collider>();
		return !collider || collider.enabled;
	}

	private void KHHKEGBKODL(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void COHJNJFHEEP()
	{
		if (target != null)
		{
			if (string.IsNullOrEmpty(normalSprite))
			{
				normalSprite = target.FFPPLGDLPIF();
			}
			if (string.IsNullOrEmpty(hoverSprite))
			{
				hoverSprite = target.FECKGIJOCFF();
			}
			if (string.IsNullOrEmpty(pressedSprite))
			{
				pressedSprite = target.NJHDFNDHAAC();
			}
			if (string.IsNullOrEmpty(disabledSprite))
			{
				disabledSprite = target.DCLPIGEEKNF();
			}
		}
	}

	private void PBKIONJCBBD(string BGOMOIOJAPC)
	{
		if (!(target.get_atlas() == null) && target.get_atlas().GetSprite(BGOMOIOJAPC) != null)
		{
			target.set_spriteName(BGOMOIOJAPC);
			if (pixelSnap)
			{
				target.MakePixelPerfect();
			}
		}
	}

	private void DIHKJBGDLKO()
	{
		if (target != null)
		{
			if (string.IsNullOrEmpty(normalSprite))
			{
				normalSprite = target.NJHDFNDHAAC();
			}
			if (string.IsNullOrEmpty(hoverSprite))
			{
				hoverSprite = target.DCLPIGEEKNF();
			}
			if (string.IsNullOrEmpty(pressedSprite))
			{
				pressedSprite = target.FECKGIJOCFF();
			}
			if (string.IsNullOrEmpty(disabledSprite))
			{
				disabledSprite = target.DCLPIGEEKNF();
			}
		}
	}

	private void ILLAEFAKBLC(bool NLGJIEONPNP)
	{
		if (NLGJIEONPNP)
		{
			PBKIONJCBBD(pressedSprite);
		}
		else
		{
			EOCABDAFADI();
		}
	}

	private void JKCOKLFMOBI()
	{
		if (target != null)
		{
			if (APHJIEPADKP())
			{
				PBKIONJCBBD((!UICamera.IsHighlighted(base.gameObject)) ? normalSprite : hoverSprite);
			}
			else
			{
				PBKIONJCBBD(disabledSprite);
			}
		}
	}

	private void LINNBIGKGED()
	{
		if (target == null)
		{
			target = GetComponentInChildren<UISprite>();
		}
		LPHPAHHFKGJ();
	}

	private void NDNBPKKAKDJ(bool NLGJIEONPNP)
	{
		if (NLGJIEONPNP)
		{
			PBKIONJCBBD(pressedSprite);
		}
		else
		{
			IMJMOFIHPNN();
		}
	}

	public bool get_isEnabled()
	{
		Collider collider = base.GetComponent<Collider>();
		return (bool)collider && collider.enabled;
	}

	private void OJMBNBMBAMK(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void JGMPEGHFBMG(bool MLIBCICOOAI)
	{
		if (IJOEFOMPNBG() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void JKDMADIMAMK()
	{
		if (target != null)
		{
			if (string.IsNullOrEmpty(normalSprite))
			{
				normalSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(hoverSprite))
			{
				hoverSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(pressedSprite))
			{
				pressedSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(disabledSprite))
			{
				disabledSprite = target.get_spriteName();
			}
		}
	}

	private void GLDJPBALGIH(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void OnValidate()
	{
		if (target != null)
		{
			if (string.IsNullOrEmpty(normalSprite))
			{
				normalSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(hoverSprite))
			{
				hoverSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(pressedSprite))
			{
				pressedSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(disabledSprite))
			{
				disabledSprite = target.get_spriteName();
			}
		}
	}

	private void EOCABDAFADI()
	{
		if (target != null)
		{
			if (IJOEFOMPNBG())
			{
				PBKIONJCBBD((!UICamera.IsHighlighted(base.gameObject)) ? normalSprite : hoverSprite);
			}
			else
			{
				PBKIONJCBBD(disabledSprite);
			}
		}
	}

	[SpecialName]
	public void INDFELJBOIE(bool ICENKPDOHBK)
	{
		Collider collider = base.GetComponent<Collider>();
		if ((bool)collider && collider.enabled != ICENKPDOHBK)
		{
			collider.enabled = ICENKPDOHBK;
			JNLLGOINJKH();
		}
	}

	private void LBFBKPCCHIB(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void IMJMOFIHPNN()
	{
		if (target != null)
		{
			if (get_isEnabled())
			{
				PBKIONJCBBD((!UICamera.IsHighlighted(base.gameObject)) ? normalSprite : hoverSprite);
			}
			else
			{
				PBKIONJCBBD(disabledSprite);
			}
		}
	}

	public void set_isEnabled(bool ICENKPDOHBK)
	{
		Collider collider = base.GetComponent<Collider>();
		if ((bool)collider && collider.enabled != ICENKPDOHBK)
		{
			collider.enabled = ICENKPDOHBK;
			IMJMOFIHPNN();
		}
	}

	private void ANPMEDDMKMD()
	{
		if (target != null)
		{
			if (string.IsNullOrEmpty(normalSprite))
			{
				normalSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(hoverSprite))
			{
				hoverSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(pressedSprite))
			{
				pressedSprite = target.get_spriteName();
			}
			if (string.IsNullOrEmpty(disabledSprite))
			{
				disabledSprite = target.FFPPLGDLPIF();
			}
		}
	}

	[SpecialName]
	public void KMDFCPOMFFM(bool ICENKPDOHBK)
	{
		Collider collider = base.GetComponent<Collider>();
		if ((bool)collider && collider.enabled != ICENKPDOHBK)
		{
			collider.enabled = ICENKPDOHBK;
			JKCOKLFMOBI();
		}
	}

	private void IMMPBHMIHDE(bool NLGJIEONPNP)
	{
		if (NLGJIEONPNP)
		{
			PBKIONJCBBD(pressedSprite);
		}
		else
		{
			IMJMOFIHPNN();
		}
	}

	private void FJEJPEDGLHN(bool NLGJIEONPNP)
	{
		if (NLGJIEONPNP)
		{
			PBKIONJCBBD(pressedSprite);
		}
		else
		{
			EOCABDAFADI();
		}
	}

	private void LPHPAHHFKGJ()
	{
		if (target != null)
		{
			if (get_isEnabled())
			{
				PBKIONJCBBD((!UICamera.DMOOCIJDAIK(base.gameObject)) ? normalSprite : hoverSprite);
			}
			else
			{
				PBKIONJCBBD(disabledSprite);
			}
		}
	}

	private void KBJLHLFEMJE()
	{
		if (target != null)
		{
			if (get_isEnabled())
			{
				PBKIONJCBBD((!UICamera.DMOOCIJDAIK(base.gameObject)) ? normalSprite : hoverSprite);
			}
			else
			{
				PBKIONJCBBD(disabledSprite);
			}
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void AMKBALDOCCC(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void GPELHDPCALL()
	{
		if (target != null)
		{
			if (string.IsNullOrEmpty(normalSprite))
			{
				normalSprite = target.DCLPIGEEKNF();
			}
			if (string.IsNullOrEmpty(hoverSprite))
			{
				hoverSprite = target.FECKGIJOCFF();
			}
			if (string.IsNullOrEmpty(pressedSprite))
			{
				pressedSprite = target.DCLPIGEEKNF();
			}
			if (string.IsNullOrEmpty(disabledSprite))
			{
				disabledSprite = target.FECKGIJOCFF();
			}
		}
	}

	private void OnEnable()
	{
		if (target == null)
		{
			target = GetComponentInChildren<UISprite>();
		}
		IMJMOFIHPNN();
	}

	private void PBDCBOEHJLH(bool MLIBCICOOAI)
	{
		if (get_isEnabled() && target != null)
		{
			PBKIONJCBBD((!MLIBCICOOAI) ? normalSprite : hoverSprite);
		}
	}

	private void JNLLGOINJKH()
	{
		if (target != null)
		{
			if (APHJIEPADKP())
			{
				PBKIONJCBBD((!UICamera.DMOOCIJDAIK(base.gameObject)) ? normalSprite : hoverSprite);
			}
			else
			{
				PBKIONJCBBD(disabledSprite);
			}
		}
	}
}
