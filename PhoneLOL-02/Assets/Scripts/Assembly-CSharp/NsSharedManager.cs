using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NsSharedManager : MonoBehaviour
{
	protected static NsSharedManager LKLBEDDILFA;

	protected List<GameObject> LLAADMNOKCN = new List<GameObject>();

	protected List<GameObject> BDOOGEJLLLK = new List<GameObject>();

	protected List<AudioClip> ONJHPDFGBPF = new List<AudioClip>();

	protected List<List<AudioSource>> HOMHHKBJFAH = new List<List<AudioSource>>();

	public static NsSharedManager NPDBJHMBINE
	{
		get
		{
			return get_inst();
		}
	}

	private AudioSource LOMOEJALOGF(List<AudioSource> OHELMFIIBBD, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		OHELMFIIBBD.Add(audioSource);
		audioSource.clip = OGLIJDHNIMH;
		audioSource.priority = HACINLOGNIL;
		audioSource.loop = IOGIECOGNBG;
		audioSource.volume = BIJJALEKANE;
		audioSource.pitch = IAMCKCKGGOG;
		audioSource.playOnAwake = false;
		return audioSource;
	}

	public void AGABIOAKLFI(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource sharedAudioSource = GetSharedAudioSource(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (sharedAudioSource == null)
		{
			return;
		}
		if (sharedAudioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			sharedAudioSource.Stop();
		}
		sharedAudioSource.Play();
	}

	public AudioSource AABDBINEFNO(AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		int num = ONJHPDFGBPF.IndexOf(OGLIJDHNIMH);
		if (num < 1)
		{
			if (!NcEffectBehaviour.ECFFAMFELKA())
			{
				return null;
			}
			List<AudioSource> list = new List<AudioSource>();
			ONJHPDFGBPF.Add(OGLIJDHNIMH);
			HOMHHKBJFAH.Add(list);
			return GLLIKFEFBCC(list, OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		}
		foreach (AudioSource item in HOMHHKBJFAH[num])
		{
			if (item.volume == BIJJALEKANE && item.pitch == IAMCKCKGGOG && item.loop == IOGIECOGNBG && item.priority == HACINLOGNIL)
			{
				return item;
			}
		}
		return NGCBPCAJIDD(HOMHHKBJFAH[num], OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
	}

	public void HJBLJLJBEFF(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = AABDBINEFNO(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (audioSource == null)
		{
			return;
		}
		if (audioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			audioSource.Stop();
		}
		audioSource.Play();
	}

	public GameObject DPBEICMECPJ(GameObject IJPKFJEELIE)
	{
		int num = LLAADMNOKCN.IndexOf(IJPKFJEELIE);
		if (num < 0 || BDOOGEJLLLK[num] == null)
		{
			if (!NcEffectBehaviour.IsSafe())
			{
				return null;
			}
			GameObject gameObject = (GameObject)Object.Instantiate(IJPKFJEELIE);
			gameObject.transform.parent = NcEffectBehaviour.GetRootInstanceEffect().transform;
			if (1 <= num)
			{
				BDOOGEJLLLK[num] = gameObject;
			}
			else
			{
				LLAADMNOKCN.Add(IJPKFJEELIE);
				BDOOGEJLLLK.Add(gameObject);
			}
			NcParticleSystem component = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component)
			{
				component.enabled = false;
			}
			if ((bool)gameObject.GetComponent<ParticleEmitter>())
			{
				gameObject.GetComponent<ParticleEmitter>().emit = true;
				gameObject.GetComponent<ParticleEmitter>().useWorldSpace = true;
				ParticleAnimator component2 = gameObject.GetComponent<ParticleAnimator>();
				if ((bool)component2)
				{
					component2.autodestruct = false;
				}
			}
			NcParticleSystem component3 = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component3)
			{
				component3.m_bBurst = true;
			}
			ParticleSystem component4 = gameObject.GetComponent<ParticleSystem>();
			if ((bool)component4)
			{
				component4.enableEmission = false;
			}
			return gameObject;
		}
		return BDOOGEJLLLK[num];
	}

	public void PlaySharedAudioSource(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource sharedAudioSource = GetSharedAudioSource(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (sharedAudioSource == null)
		{
			return;
		}
		if (sharedAudioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			sharedAudioSource.Stop();
		}
		sharedAudioSource.Play();
	}

	public void CMAAPJCJGOM(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = AABDBINEFNO(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (audioSource == null)
		{
			return;
		}
		if (audioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			audioSource.Stop();
		}
		audioSource.Play();
	}

	public static NsSharedManager get_inst()
	{
		if (LKLBEDDILFA == null)
		{
			LKLBEDDILFA = NcEffectBehaviour.GetRootInstanceEffect().AddComponent<NsSharedManager>();
		}
		return LKLBEDDILFA;
	}

	public void BHAEAKBKDGL(GameObject IJPKFJEELIE, int LEMAHEMLJFG, Vector3 IMCBPDJDNPG)
	{
		GameObject gameObject = HBOOIKGAOFJ(IJPKFJEELIE);
		if (gameObject == null)
		{
			return;
		}
		gameObject.transform.position = IMCBPDJDNPG;
		if (gameObject.GetComponent<ParticleEmitter>() != null)
		{
			gameObject.GetComponent<ParticleEmitter>().Emit(LEMAHEMLJFG);
			return;
		}
		ParticleSystem component = gameObject.GetComponent<ParticleSystem>();
		if (component != null)
		{
			component.Emit(LEMAHEMLJFG);
		}
	}

	public GameObject GetSharedParticleGameObject(GameObject IJPKFJEELIE)
	{
		int num = LLAADMNOKCN.IndexOf(IJPKFJEELIE);
		if (num < 0 || BDOOGEJLLLK[num] == null)
		{
			if (!NcEffectBehaviour.IsSafe())
			{
				return null;
			}
			GameObject gameObject = (GameObject)Object.Instantiate(IJPKFJEELIE);
			gameObject.transform.parent = NcEffectBehaviour.GetRootInstanceEffect().transform;
			if (0 <= num)
			{
				BDOOGEJLLLK[num] = gameObject;
			}
			else
			{
				LLAADMNOKCN.Add(IJPKFJEELIE);
				BDOOGEJLLLK.Add(gameObject);
			}
			NcParticleSystem component = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component)
			{
				component.enabled = false;
			}
			if ((bool)gameObject.GetComponent<ParticleEmitter>())
			{
				gameObject.GetComponent<ParticleEmitter>().emit = false;
				gameObject.GetComponent<ParticleEmitter>().useWorldSpace = true;
				ParticleAnimator component2 = gameObject.GetComponent<ParticleAnimator>();
				if ((bool)component2)
				{
					component2.autodestruct = false;
				}
			}
			NcParticleSystem component3 = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component3)
			{
				component3.m_bBurst = false;
			}
			ParticleSystem component4 = gameObject.GetComponent<ParticleSystem>();
			if ((bool)component4)
			{
				component4.enableEmission = false;
			}
			return gameObject;
		}
		return BDOOGEJLLLK[num];
	}

	public GameObject AJONFPLEPMO(GameObject IJPKFJEELIE)
	{
		int num = LLAADMNOKCN.IndexOf(IJPKFJEELIE);
		if (num < 1 || BDOOGEJLLLK[num] == null)
		{
			if (!NcEffectBehaviour.ECFFAMFELKA())
			{
				return null;
			}
			GameObject gameObject = (GameObject)Object.Instantiate(IJPKFJEELIE);
			gameObject.transform.parent = NcEffectBehaviour.GetRootInstanceEffect().transform;
			if (1 <= num)
			{
				BDOOGEJLLLK[num] = gameObject;
			}
			else
			{
				LLAADMNOKCN.Add(IJPKFJEELIE);
				BDOOGEJLLLK.Add(gameObject);
			}
			NcParticleSystem component = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component)
			{
				component.enabled = true;
			}
			if ((bool)gameObject.GetComponent<ParticleEmitter>())
			{
				gameObject.GetComponent<ParticleEmitter>().emit = true;
				gameObject.GetComponent<ParticleEmitter>().useWorldSpace = true;
				ParticleAnimator component2 = gameObject.GetComponent<ParticleAnimator>();
				if ((bool)component2)
				{
					component2.autodestruct = false;
				}
			}
			NcParticleSystem component3 = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component3)
			{
				component3.m_bBurst = true;
			}
			ParticleSystem component4 = gameObject.GetComponent<ParticleSystem>();
			if ((bool)component4)
			{
				component4.enableEmission = false;
			}
			return gameObject;
		}
		return BDOOGEJLLLK[num];
	}

	public void GFMFHKOAPBD(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = AABDBINEFNO(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (audioSource == null)
		{
			return;
		}
		if (audioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			audioSource.Stop();
		}
		audioSource.Play();
	}

	public AudioSource GetSharedAudioSource(AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		int num = ONJHPDFGBPF.IndexOf(OGLIJDHNIMH);
		if (num < 0)
		{
			if (!NcEffectBehaviour.IsSafe())
			{
				return null;
			}
			List<AudioSource> list = new List<AudioSource>();
			ONJHPDFGBPF.Add(OGLIJDHNIMH);
			HOMHHKBJFAH.Add(list);
			return JJIEFHGOHLG(list, OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		}
		foreach (AudioSource item in HOMHHKBJFAH[num])
		{
			if (item.volume == BIJJALEKANE && item.pitch == IAMCKCKGGOG && item.loop == IOGIECOGNBG && item.priority == HACINLOGNIL)
			{
				return item;
			}
		}
		return JJIEFHGOHLG(HOMHHKBJFAH[num], OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
	}

	private AudioSource NGCBPCAJIDD(List<AudioSource> OHELMFIIBBD, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		OHELMFIIBBD.Add(audioSource);
		audioSource.clip = OGLIJDHNIMH;
		audioSource.priority = HACINLOGNIL;
		audioSource.loop = IOGIECOGNBG;
		audioSource.volume = BIJJALEKANE;
		audioSource.pitch = IAMCKCKGGOG;
		audioSource.playOnAwake = false;
		return audioSource;
	}

	private AudioSource NPOMMAJCFIB(List<AudioSource> OHELMFIIBBD, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		OHELMFIIBBD.Add(audioSource);
		audioSource.clip = OGLIJDHNIMH;
		audioSource.priority = HACINLOGNIL;
		audioSource.loop = IOGIECOGNBG;
		audioSource.volume = BIJJALEKANE;
		audioSource.pitch = IAMCKCKGGOG;
		audioSource.playOnAwake = true;
		return audioSource;
	}

	[SpecialName]
	public static NsSharedManager EOBIIMPOMJM()
	{
		if (LKLBEDDILFA == null)
		{
			LKLBEDDILFA = NcEffectBehaviour.GetRootInstanceEffect().AddComponent<NsSharedManager>();
		}
		return LKLBEDDILFA;
	}

	public AudioSource HHEPOCFDPGB(AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		int num = ONJHPDFGBPF.IndexOf(OGLIJDHNIMH);
		if (num < 0)
		{
			if (!NcEffectBehaviour.IsSafe())
			{
				return null;
			}
			List<AudioSource> list = new List<AudioSource>();
			ONJHPDFGBPF.Add(OGLIJDHNIMH);
			HOMHHKBJFAH.Add(list);
			return NPOMMAJCFIB(list, OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		}
		foreach (AudioSource item in HOMHHKBJFAH[num])
		{
			if (item.volume == BIJJALEKANE && item.pitch == IAMCKCKGGOG && item.loop == IOGIECOGNBG && item.priority == HACINLOGNIL)
			{
				return item;
			}
		}
		return NPOMMAJCFIB(HOMHHKBJFAH[num], OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
	}

	private AudioSource KPLNBIEFOGB(List<AudioSource> OHELMFIIBBD, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		OHELMFIIBBD.Add(audioSource);
		audioSource.clip = OGLIJDHNIMH;
		audioSource.priority = HACINLOGNIL;
		audioSource.loop = IOGIECOGNBG;
		audioSource.volume = BIJJALEKANE;
		audioSource.pitch = IAMCKCKGGOG;
		audioSource.playOnAwake = false;
		return audioSource;
	}

	public void AMAKMMMOINE(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = HHEPOCFDPGB(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (audioSource == null)
		{
			return;
		}
		if (audioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			audioSource.Stop();
		}
		audioSource.Play();
	}

	public GameObject HBOOIKGAOFJ(GameObject IJPKFJEELIE)
	{
		int num = LLAADMNOKCN.IndexOf(IJPKFJEELIE);
		if (num < 1 || BDOOGEJLLLK[num] == null)
		{
			if (!NcEffectBehaviour.ECFFAMFELKA())
			{
				return null;
			}
			GameObject gameObject = (GameObject)Object.Instantiate(IJPKFJEELIE);
			gameObject.transform.parent = NcEffectBehaviour.GetRootInstanceEffect().transform;
			if (1 <= num)
			{
				BDOOGEJLLLK[num] = gameObject;
			}
			else
			{
				LLAADMNOKCN.Add(IJPKFJEELIE);
				BDOOGEJLLLK.Add(gameObject);
			}
			NcParticleSystem component = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component)
			{
				component.enabled = true;
			}
			if ((bool)gameObject.GetComponent<ParticleEmitter>())
			{
				gameObject.GetComponent<ParticleEmitter>().emit = false;
				gameObject.GetComponent<ParticleEmitter>().useWorldSpace = false;
				ParticleAnimator component2 = gameObject.GetComponent<ParticleAnimator>();
				if ((bool)component2)
				{
					component2.autodestruct = false;
				}
			}
			NcParticleSystem component3 = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component3)
			{
				component3.m_bBurst = true;
			}
			ParticleSystem component4 = gameObject.GetComponent<ParticleSystem>();
			if ((bool)component4)
			{
				component4.enableEmission = false;
			}
			return gameObject;
		}
		return BDOOGEJLLLK[num];
	}

	public void EmitSharedParticleSystem(GameObject IJPKFJEELIE, int LEMAHEMLJFG, Vector3 IMCBPDJDNPG)
	{
		GameObject sharedParticleGameObject = GetSharedParticleGameObject(IJPKFJEELIE);
		if (sharedParticleGameObject == null)
		{
			return;
		}
		sharedParticleGameObject.transform.position = IMCBPDJDNPG;
		if (sharedParticleGameObject.GetComponent<ParticleEmitter>() != null)
		{
			sharedParticleGameObject.GetComponent<ParticleEmitter>().Emit(LEMAHEMLJFG);
			return;
		}
		ParticleSystem component = sharedParticleGameObject.GetComponent<ParticleSystem>();
		if (component != null)
		{
			component.Emit(LEMAHEMLJFG);
		}
	}

	public void AECJCMGGECJ(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = AABDBINEFNO(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (audioSource == null)
		{
			return;
		}
		if (audioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			audioSource.Stop();
		}
		audioSource.Play();
	}

	public GameObject KKPGBCHDBED(GameObject IJPKFJEELIE)
	{
		int num = LLAADMNOKCN.IndexOf(IJPKFJEELIE);
		if (num < 1 || BDOOGEJLLLK[num] == null)
		{
			if (!NcEffectBehaviour.IsSafe())
			{
				return null;
			}
			GameObject gameObject = (GameObject)Object.Instantiate(IJPKFJEELIE);
			gameObject.transform.parent = NcEffectBehaviour.GetRootInstanceEffect().transform;
			if (1 <= num)
			{
				BDOOGEJLLLK[num] = gameObject;
			}
			else
			{
				LLAADMNOKCN.Add(IJPKFJEELIE);
				BDOOGEJLLLK.Add(gameObject);
			}
			NcParticleSystem component = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component)
			{
				component.enabled = true;
			}
			if ((bool)gameObject.GetComponent<ParticleEmitter>())
			{
				gameObject.GetComponent<ParticleEmitter>().emit = false;
				gameObject.GetComponent<ParticleEmitter>().useWorldSpace = false;
				ParticleAnimator component2 = gameObject.GetComponent<ParticleAnimator>();
				if ((bool)component2)
				{
					component2.autodestruct = false;
				}
			}
			NcParticleSystem component3 = gameObject.GetComponent<NcParticleSystem>();
			if ((bool)component3)
			{
				component3.m_bBurst = true;
			}
			ParticleSystem component4 = gameObject.GetComponent<ParticleSystem>();
			if ((bool)component4)
			{
				component4.enableEmission = true;
			}
			return gameObject;
		}
		return BDOOGEJLLLK[num];
	}

	private AudioSource GLLIKFEFBCC(List<AudioSource> OHELMFIIBBD, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		OHELMFIIBBD.Add(audioSource);
		audioSource.clip = OGLIJDHNIMH;
		audioSource.priority = HACINLOGNIL;
		audioSource.loop = IOGIECOGNBG;
		audioSource.volume = BIJJALEKANE;
		audioSource.pitch = IAMCKCKGGOG;
		audioSource.playOnAwake = false;
		return audioSource;
	}

	public void PCIGHEKEIPG(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = AABDBINEFNO(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (audioSource == null)
		{
			return;
		}
		if (audioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			audioSource.Stop();
		}
		audioSource.Play();
	}

	public void ILONNOCKLJD(bool OCHHPGBCDFC, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource sharedAudioSource = GetSharedAudioSource(OGLIJDHNIMH, HACINLOGNIL, IOGIECOGNBG, BIJJALEKANE, IAMCKCKGGOG);
		if (sharedAudioSource == null)
		{
			return;
		}
		if (sharedAudioSource.isPlaying)
		{
			if (OCHHPGBCDFC)
			{
				return;
			}
			sharedAudioSource.Stop();
		}
		sharedAudioSource.Play();
	}

	[SpecialName]
	public static NsSharedManager LLOHIPACKOA()
	{
		if (LKLBEDDILFA == null)
		{
			LKLBEDDILFA = NcEffectBehaviour.GetRootInstanceEffect().AddComponent<NsSharedManager>();
		}
		return LKLBEDDILFA;
	}

	private AudioSource JJIEFHGOHLG(List<AudioSource> OHELMFIIBBD, AudioClip OGLIJDHNIMH, int HACINLOGNIL, bool IOGIECOGNBG, float BIJJALEKANE, float IAMCKCKGGOG)
	{
		AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
		OHELMFIIBBD.Add(audioSource);
		audioSource.clip = OGLIJDHNIMH;
		audioSource.priority = HACINLOGNIL;
		audioSource.loop = IOGIECOGNBG;
		audioSource.volume = BIJJALEKANE;
		audioSource.pitch = IAMCKCKGGOG;
		audioSource.playOnAwake = false;
		return audioSource;
	}
}
