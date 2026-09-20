using UnityEngine;

public class NcAttachSound : NcEffectBehaviour
{
	public enum MKGGKFNKLOM
	{
		StopAndPlay = 0,
		UniquePlay = 1,
		MultiPlay = 2
	}

	public MKGGKFNKLOM m_PlayType;

	public bool m_bSharedAudioSource = true;

	public bool m_bPlayOnActive;

	public float m_fDelayTime;

	public float m_fRepeatTime;

	public int m_nRepeatCount;

	public AudioClip m_AudioClip;

	public int m_nPriority = 128;

	public bool m_bLoop;

	public float m_fVolume = 1f;

	public float m_fPitch = 1f;

	protected AudioSource NAAJLPLAAAF;

	protected float HBDKLBHFLJK;

	protected int AEOFIKHAPMJ;

	protected bool DMJHFKIKHMA;

	protected bool OBAFCGGDPMP = true;

	public virtual void DJGLFPKOCBN(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		PMOJAGNKMHM();
	}

	private void DJCELGKLDAP()
	{
		if (m_bPlayOnActive)
		{
			PMOJAGNKMHM();
		}
	}

	private void MADCDCNEGBO()
	{
		if (m_bPlayOnActive)
		{
			PMOJAGNKMHM();
		}
	}

	public virtual void HDFDNEGAMAB(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		Replay();
	}

	public virtual void BBDCHAJNGHF()
	{
		base.OnSetReplayState();
	}

	public virtual int BHNCDBHBBOO()
	{
		if ((base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject)) || (NAAJLPLAAAF != null && (NAAJLPLAAAF.isPlaying || NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)))
		{
			return 0;
		}
		return 1;
	}

	public void CreateAttachSound()
	{
		if (m_PlayType == MKGGKFNKLOM.MultiPlay || !m_bSharedAudioSource)
		{
			if (NAAJLPLAAAF == null)
			{
				NAAJLPLAAAF = base.gameObject.AddComponent<AudioSource>();
			}
			NAAJLPLAAAF.clip = m_AudioClip;
			NAAJLPLAAAF.priority = m_nPriority;
			NAAJLPLAAAF.loop = m_bLoop;
			NAAJLPLAAAF.volume = m_fVolume;
			NAAJLPLAAAF.pitch = m_fPitch;
			NAAJLPLAAAF.playOnAwake = false;
			NAAJLPLAAAF.Play();
		}
		else
		{
			NsSharedManager.get_inst().PlaySharedAudioSource(m_PlayType == MKGGKFNKLOM.UniquePlay, m_AudioClip, m_nPriority, m_bLoop, m_fVolume, m_fPitch);
		}
		AEOFIKHAPMJ++;
	}

	public virtual void CPHAPJFIPEC(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		Replay();
	}

	public virtual int GODPKOIFOHB()
	{
		if ((base.enabled && NcEffectBehaviour.JOCHMPKGGEN(base.gameObject)) || (NAAJLPLAAAF != null && (NAAJLPLAAAF.isPlaying || NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)))
		{
			return 0;
		}
		return 0;
	}

	private void Update()
	{
		if (m_AudioClip == null)
		{
			base.enabled = false;
		}
		else
		{
			if (!OBAFCGGDPMP)
			{
				return;
			}
			if (!DMJHFKIKHMA)
			{
				HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
				DMJHFKIKHMA = true;
			}
			if (HBDKLBHFLJK + ((AEOFIKHAPMJ != 0) ? m_fRepeatTime : m_fDelayTime) <= NcEffectBehaviour.GetEngineTime())
			{
				CreateAttachSound();
				if (0f < m_fRepeatTime && (m_nRepeatCount == 0 || AEOFIKHAPMJ < m_nRepeatCount))
				{
					HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
				}
				else
				{
					OBAFCGGDPMP = false;
				}
			}
		}
	}

	private void CMFCDCEOAKN()
	{
		if (m_bPlayOnActive)
		{
			Replay();
		}
	}

	public virtual void KEJCELOFBMI()
	{
		base.OnSetReplayState();
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	public virtual void EMMCPLAJHCC(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	public virtual int JILEDBKIDBO()
	{
		if ((base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject)) || (NAAJLPLAAAF != null && (NAAJLPLAAAF.isPlaying || NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)))
		{
			return 1;
		}
		return 0;
	}

	public void PMOJAGNKMHM()
	{
		DMJHFKIKHMA = true;
		OBAFCGGDPMP = false;
		base.enabled = false;
		AEOFIKHAPMJ = 0;
	}

	public virtual void GAICEDBMPOF(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	public virtual void NMEJIGPCHAH()
	{
		base.OnSetReplayState();
	}

	public void Replay()
	{
		DMJHFKIKHMA = false;
		OBAFCGGDPMP = true;
		base.enabled = true;
		AEOFIKHAPMJ = 0;
	}

	public override void OnSetReplayState()
	{
		base.OnSetReplayState();
	}

	public virtual void CCNFGGECFHM(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fRepeatTime /= HBNGEJIEGDO;
	}

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		Replay();
	}

	public override int GetAnimationState()
	{
		if ((base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject)) || (NAAJLPLAAAF != null && (NAAJLPLAAAF.isPlaying || NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)))
		{
			return 1;
		}
		return 0;
	}

	private void GKACIJGFNDC()
	{
		if (m_bPlayOnActive)
		{
			PMOJAGNKMHM();
		}
	}

	private void OnEnable()
	{
		if (m_bPlayOnActive)
		{
			Replay();
		}
	}
}
