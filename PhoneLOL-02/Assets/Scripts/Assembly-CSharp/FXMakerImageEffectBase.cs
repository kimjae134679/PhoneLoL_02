using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Camera))]
[AddComponentMenu("")]
public class FXMakerImageEffectBase : MonoBehaviour
{
	public Shader shader;

	private Material CPDNLKKJLPD;

	protected Material BJJILBPBOGP
	{
		get
		{
			return IFDCGNNEIOL();
		}
	}

	[SpecialName]
	protected Material OJNEBMKKCHJ()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)(-29);
		}
		return CPDNLKKJLPD;
	}

	[SpecialName]
	protected Material FHBGOAHDONI()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)87;
		}
		return CPDNLKKJLPD;
	}

	[SpecialName]
	protected Material ADEKMCHHGAO()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = HideFlags.HideInHierarchy | HideFlags.HideInInspector;
		}
		return CPDNLKKJLPD;
	}

	[SpecialName]
	protected Material ELDKNEMIFFA()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)62;
		}
		return CPDNLKKJLPD;
	}

	protected void NAEELEFFJLC()
	{
		if ((bool)CPDNLKKJLPD)
		{
			Object.DestroyImmediate(CPDNLKKJLPD);
		}
	}

	protected void PAKIFAGJDEO()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = false;
		}
	}

	protected void Start()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = false;
		}
	}

	[SpecialName]
	protected Material MIHGMHJPOIK()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)109;
		}
		return CPDNLKKJLPD;
	}

	protected void DMPIIJNBDID()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = true;
		}
	}

	protected Material IFDCGNNEIOL()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = HideFlags.HideAndDontSave;
		}
		return CPDNLKKJLPD;
	}

	[SpecialName]
	protected Material LJIBGEMCAMC()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = HideFlags.HideInInspector;
		}
		return CPDNLKKJLPD;
	}

	protected void PAJOOFIAPMI()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = true;
		}
	}

	protected void IPFEBDCDMFA()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material BIJEFLDPGBA()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)48;
		}
		return CPDNLKKJLPD;
	}

	[SpecialName]
	protected Material JABAIKOCPCB()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)(-27);
		}
		return CPDNLKKJLPD;
	}

	protected void DDEGDABBPDF()
	{
		if ((bool)CPDNLKKJLPD)
		{
			Object.DestroyImmediate(CPDNLKKJLPD);
		}
	}

	protected void GPFPLFJCNOL()
	{
		if ((bool)CPDNLKKJLPD)
		{
			Object.DestroyImmediate(CPDNLKKJLPD);
		}
	}

	protected void DBLCOCKIFPE()
	{
		if ((bool)CPDNLKKJLPD)
		{
			Object.DestroyImmediate(CPDNLKKJLPD);
		}
	}

	protected void JEHHOGCJEMM()
	{
		if ((bool)CPDNLKKJLPD)
		{
			Object.DestroyImmediate(CPDNLKKJLPD);
		}
	}

	protected void BPLOLCKEJJK()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = true;
		}
	}

	[SpecialName]
	protected Material JGOAEIECNKI()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)49;
		}
		return CPDNLKKJLPD;
	}

	[SpecialName]
	protected Material EHGOOFBBKOL()
	{
		if (CPDNLKKJLPD == null)
		{
			CPDNLKKJLPD = new Material(shader);
			CPDNLKKJLPD.hideFlags = (HideFlags)(-78);
		}
		return CPDNLKKJLPD;
	}

	protected void MCGBEHNCGEP()
	{
		if ((bool)CPDNLKKJLPD)
		{
			Object.DestroyImmediate(CPDNLKKJLPD);
		}
	}

	protected void OnDisable()
	{
		if ((bool)CPDNLKKJLPD)
		{
			Object.DestroyImmediate(CPDNLKKJLPD);
		}
	}

	protected void JPBNPEJJJPI()
	{
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
		}
		else if (!shader || !shader.isSupported)
		{
			base.enabled = false;
		}
	}
}
