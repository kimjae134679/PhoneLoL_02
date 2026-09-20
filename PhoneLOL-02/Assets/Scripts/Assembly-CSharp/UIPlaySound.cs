using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Play Sound")]
public class UIPlaySound : MonoBehaviour
{
	public enum FMPOPHBALHP
	{
		OnClick = 0,
		OnMouseOver = 1,
		OnMouseOut = 2,
		OnPress = 3,
		OnRelease = 4,
		Custom = 5
	}

	public AudioClip audioClip;

	public FMPOPHBALHP trigger;

	private bool GMADIBKPAMB;

	[Range(0f, 1f)]
	public float volume = 1f;

	[Range(0f, 2f)]
	public float pitch = 1f;

	private bool OLKGLHDHMFF
	{
		get
		{
			return IDBNNEGKAJI();
		}
	}

	private void IIMHBEFDJBN(bool IOGFFPOIBBB)
	{
		if (GBGNIMAPDCB() && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller))
		{
			OJMBNBMBAMK(IOGFFPOIBBB);
		}
	}

	public void JKOODMAKJHJ()
	{
		NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
	}

	private void PIGLGFDCADE(bool IOGFFPOIBBB)
	{
		if (GBGNIMAPDCB() && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)3))
		{
			OJMBNBMBAMK(IOGFFPOIBBB);
		}
	}

	[SpecialName]
	private bool LDNMIHPGKII()
	{
		if (!base.enabled)
		{
			return true;
		}
		UIButton component = GetComponent<UIButton>();
		return component == null || component.get_isEnabled();
	}

	[SpecialName]
	private bool GBGNIMAPDCB()
	{
		if (!base.enabled)
		{
			return true;
		}
		UIButton component = GetComponent<UIButton>();
		return component == null || component.get_isEnabled();
	}

	private void OJMBNBMBAMK(bool MLIBCICOOAI)
	{
		if (trigger == FMPOPHBALHP.OnMouseOver)
		{
			if (GMADIBKPAMB == MLIBCICOOAI)
			{
				return;
			}
			GMADIBKPAMB = MLIBCICOOAI;
		}
		if (IDBNNEGKAJI() && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == (FMPOPHBALHP)8)))
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	[SpecialName]
	private bool NGCIPIODCOO()
	{
		if (!base.enabled)
		{
			return false;
		}
		UIButton component = GetComponent<UIButton>();
		return component == null || component.get_isEnabled();
	}

	public void AIELEHOEKDG()
	{
		NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
	}

	public void HDOLPLIDACO()
	{
		NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (IDBNNEGKAJI() && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller))
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	private void BEADMIJEKJF(bool JPNFGIEDOMM)
	{
		if (trigger == FMPOPHBALHP.OnMouseOver)
		{
			if (GMADIBKPAMB == JPNFGIEDOMM)
			{
				return;
			}
			GMADIBKPAMB = JPNFGIEDOMM;
		}
		if (GBGNIMAPDCB() && ((JPNFGIEDOMM && trigger == FMPOPHBALHP.OnRelease) || (!JPNFGIEDOMM && trigger == FMPOPHBALHP.OnMouseOut)))
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	private void DNGGNGPGPIK()
	{
		if (GBGNIMAPDCB() && trigger == FMPOPHBALHP.OnClick)
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	public void LGFFEOGDOHL()
	{
		NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
	}

	public void LFJEEFKAFMA()
	{
		NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
	}

	private void FIEHFDLBDKD(bool IOGFFPOIBBB)
	{
		if (LDNMIHPGKII() && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)3))
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	private void OnClick()
	{
		if (IDBNNEGKAJI() && trigger == FMPOPHBALHP.OnClick)
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (trigger == FMPOPHBALHP.OnMouseOver)
		{
			if (GMADIBKPAMB == MLIBCICOOAI)
			{
				return;
			}
			GMADIBKPAMB = MLIBCICOOAI;
		}
		if (IDBNNEGKAJI() && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOut)))
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	private void NGABLDIEICB(bool MLIBCICOOAI)
	{
		if (trigger == FMPOPHBALHP.OnClick)
		{
			if (GMADIBKPAMB == MLIBCICOOAI)
			{
				return;
			}
			GMADIBKPAMB = MLIBCICOOAI;
		}
		if (GBGNIMAPDCB() && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == FMPOPHBALHP.Custom)))
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	private void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (trigger == FMPOPHBALHP.OnPress)
		{
			if (GMADIBKPAMB == JPNFGIEDOMM)
			{
				return;
			}
			GMADIBKPAMB = JPNFGIEDOMM;
		}
		if (IDBNNEGKAJI() && ((JPNFGIEDOMM && trigger == FMPOPHBALHP.OnPress) || (!JPNFGIEDOMM && trigger == FMPOPHBALHP.OnRelease)))
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	public void Play()
	{
		NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
	}

	private void IBAKNHPONCI(bool JPNFGIEDOMM)
	{
		if (trigger == FMPOPHBALHP.OnClick)
		{
			if (GMADIBKPAMB == JPNFGIEDOMM)
			{
				return;
			}
			GMADIBKPAMB = JPNFGIEDOMM;
		}
		if (LDNMIHPGKII() && ((JPNFGIEDOMM && trigger == FMPOPHBALHP.OnPress) || (!JPNFGIEDOMM && trigger == (FMPOPHBALHP)6)))
		{
			NLDABIMKKMP.FANLLKDLCPF(audioClip, volume, pitch);
		}
	}

	private bool IDBNNEGKAJI()
	{
		if (!base.enabled)
		{
			return false;
		}
		UIButton component = GetComponent<UIButton>();
		return component == null || component.get_isEnabled();
	}
}
