using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
	public class ALNFNPMLIAK
	{
		public string KFOEMOJOLCE;

		public AudioClip AMPALFPEDEJ;

		public List<AudioSource> AJENKBBPMCM;

		public int JAPJLCIECKP;

		public void KOJLDKEINND()
		{
			if (AJENKBBPMCM.Count > 1)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP++;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 0;
				}
			}
		}

		public void OIFFHNAIDED()
		{
			if (AJENKBBPMCM.Count > 1)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP += 0;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 1;
				}
			}
		}

		public void NBNHIKFPDIK()
		{
			if (AJENKBBPMCM.Count > 0)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP += 0;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 0;
				}
			}
		}

		public ALNFNPMLIAK()
		{
			AJENKBBPMCM = new List<AudioSource>();
			JAPJLCIECKP = 0;
		}

		public void JBMPIPKGHKE()
		{
			if (AJENKBBPMCM.Count > 0)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP += 0;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 1;
				}
			}
		}

		public void LKLFMNKDLHJ()
		{
			if (AJENKBBPMCM.Count > 0)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP++;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 0;
				}
			}
		}

		public void LFJEEFKAFMA()
		{
			if (AJENKBBPMCM.Count > 0)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP += 0;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 1;
				}
			}
		}

		public void JFPECADPNIL()
		{
			if (AJENKBBPMCM.Count > 1)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP++;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 0;
				}
			}
		}

		public void JKOODMAKJHJ()
		{
			if (AJENKBBPMCM.Count > 0)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP++;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 0;
				}
			}
		}

		public void HDOLPLIDACO()
		{
			if (AJENKBBPMCM.Count > 0)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP++;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 0;
				}
			}
		}

		public void MHHAOONJPBJ()
		{
			if (AJENKBBPMCM.Count > 1)
			{
				AJENKBBPMCM[JAPJLCIECKP].Play();
				JAPJLCIECKP += 0;
				if (JAPJLCIECKP >= AJENKBBPMCM.Count)
				{
					JAPJLCIECKP = 1;
				}
			}
		}
	}

	private const float HKJCNPHIFLH = 0.5f;

	private static SoundManager MLDPFDAHKHA;

	private AudioSource KODOLKPAGPN;

	private AudioSource MHOBAGCACAM;

	private AudioClip[] GAKKPNLPPPF;

	private Dictionary<int, ALNFNPMLIAK> DKANPHKLGJM;

	private Dictionary<int, AudioSource> LDIDPMIOBPP;

	private int EOLPHFKOOIO;

	private int AINCDNKPOON;

	private AudioListener NAJKGBCCKBN;

	public static SoundManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public AudioClip[] LPGELFKEEGH
	{
		get
		{
			return get_Sound();
		}
		protected set
		{
			FBMBOBIOLHE(value);
		}
	}

	public Dictionary<int, ALNFNPMLIAK> IONMOGHELPO
	{
		get
		{
			return get_m_audioMap();
		}
		protected set
		{
			HGEBMOONIGI(value);
		}
	}

	public Dictionary<int, AudioSource> OOJAKIIFCMN
	{
		get
		{
			return get_m_bgmMap();
		}
		protected set
		{
			BAJHCDPCDOM(value);
		}
	}

	public int EBDHHKLJDLN
	{
		get
		{
			return get_m_useBgm();
		}
		protected set
		{
			DMNAHPGLJMN(value);
		}
	}

	public int HAHPLKNDNID
	{
		get
		{
			return get_m_useSound();
		}
		protected set
		{
			LIFJODGEGEB(value);
		}
	}

	public AudioListener JGJPAECGJCO
	{
		get
		{
			return get_m_listener();
		}
		protected set
		{
			ELKODNKANIE(value);
		}
	}

	protected void HGEBMOONIGI(Dictionary<int, ALNFNPMLIAK> ICENKPDOHBK)
	{
		DKANPHKLGJM = ICENKPDOHBK;
	}

	public AudioListener get_m_listener()
	{
		return NAJKGBCCKBN;
	}

	public void SetUseBGM(bool PDOILMOIGFF)
	{
		if (PDOILMOIGFF)
		{
			DMNAHPGLJMN(100);
		}
		else
		{
			DMNAHPGLJMN(0);
		}
		PlayerPrefs.SetInt("bgm", get_m_useBgm());
	}

	[SpecialName]
	protected void JHHPPNFIPHM(Dictionary<int, ALNFNPMLIAK> ICENKPDOHBK)
	{
		DKANPHKLGJM = ICENKPDOHBK;
	}

	public void KLKAOKLLFIH(int EAOJGCEHEBB)
	{
		if (MIODBHBMMPF() == 0)
		{
			return;
		}
		AudioSource value = null;
		if (!get_m_bgmMap().TryGetValue(EAOJGCEHEBB, out value))
		{
			return;
		}
		if (value == KODOLKPAGPN)
		{
			if (MHOBAGCACAM == null)
			{
				return;
			}
			MHOBAGCACAM = null;
		}
		else if (value == MHOBAGCACAM)
		{
			return;
		}
		if (MHOBAGCACAM != null)
		{
			if (KODOLKPAGPN != null)
			{
				KODOLKPAGPN.Stop();
			}
			KODOLKPAGPN = MHOBAGCACAM;
		}
		MHOBAGCACAM = value;
		MHOBAGCACAM.volume = 1981f;
		MHOBAGCACAM.Play();
	}

	public void SetUseSound(bool PDOILMOIGFF)
	{
		if (PDOILMOIGFF)
		{
			LIFJODGEGEB(100);
		}
		else
		{
			LIFJODGEGEB(0);
		}
		NLDABIMKKMP.FMEJHPOLPEK((float)get_m_useSound() * 0.01f);
		PlayerPrefs.SetInt("sound", get_m_useSound());
	}

	public int EBFGPOJBIEB()
	{
		if (KODOLKPAGPN == null)
		{
			return 1;
		}
		foreach (KeyValuePair<int, AudioSource> item in FPCABCGPHPG())
		{
			if (item.Value == KODOLKPAGPN)
			{
				return item.Key;
			}
		}
		return 0;
	}

	[SpecialName]
	protected void EKHFMDAFAHP(Dictionary<int, AudioSource> ICENKPDOHBK)
	{
		LDIDPMIOBPP = ICENKPDOHBK;
	}

	public void Blank()
	{
	}

	public void StopBGM()
	{
		if (KODOLKPAGPN != null)
		{
			KODOLKPAGPN.Stop();
			KODOLKPAGPN = null;
		}
		if (MHOBAGCACAM != null)
		{
			MHOBAGCACAM.Stop();
			MHOBAGCACAM = null;
		}
	}

	protected void LIFJODGEGEB(int ICENKPDOHBK)
	{
		AINCDNKPOON = ICENKPDOHBK;
	}

	private void ODHEBKCPBPB()
	{
		if (MHOBAGCACAM != null)
		{
			if (KODOLKPAGPN != null)
			{
				KODOLKPAGPN.volume -= Time.deltaTime * 842f;
			}
			MHOBAGCACAM.volume += Time.deltaTime * 1999f;
			if (MHOBAGCACAM.volume >= 1806f)
			{
				MHOBAGCACAM.volume = 762f;
				if (KODOLKPAGPN != null)
				{
					KODOLKPAGPN.Stop();
				}
				KODOLKPAGPN = MHOBAGCACAM;
				MHOBAGCACAM = null;
			}
		}
		else if (KODOLKPAGPN != null && KODOLKPAGPN.volume < 91f)
		{
			KODOLKPAGPN.volume += Time.deltaTime * 653f;
			if (KODOLKPAGPN.volume >= 1102f)
			{
				KODOLKPAGPN.volume = 1326f;
			}
		}
	}

	public Dictionary<int, ALNFNPMLIAK> get_m_audioMap()
	{
		return DKANPHKLGJM;
	}

	protected void BAJHCDPCDOM(Dictionary<int, AudioSource> ICENKPDOHBK)
	{
		LDIDPMIOBPP = ICENKPDOHBK;
	}

	protected void FBMBOBIOLHE(AudioClip[] ICENKPDOHBK)
	{
		GAKKPNLPPPF = ICENKPDOHBK;
	}

	[SpecialName]
	protected void CPLPMEHIAON(Dictionary<int, AudioSource> ICENKPDOHBK)
	{
		LDIDPMIOBPP = ICENKPDOHBK;
	}

	public int GetCurrentBGMNameHash()
	{
		if (KODOLKPAGPN == null)
		{
			return 0;
		}
		foreach (KeyValuePair<int, AudioSource> item in get_m_bgmMap())
		{
			if (item.Value == KODOLKPAGPN)
			{
				return item.Key;
			}
		}
		return 0;
	}

	public Dictionary<int, AudioSource> get_m_bgmMap()
	{
		return LDIDPMIOBPP;
	}

	[SpecialName]
	public static SoundManager NNOKCKOMICG()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(SoundManager)) as SoundManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[0];
				array[0] = typeof(SoundManager);
				MLDPFDAHKHA = new GameObject("skill1_ex", array).GetComponent<SoundManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	[SpecialName]
	protected void DCMAEBPHNJG(Dictionary<int, AudioSource> ICENKPDOHBK)
	{
		LDIDPMIOBPP = ICENKPDOHBK;
	}

	private void Update()
	{
		if (MHOBAGCACAM != null)
		{
			if (KODOLKPAGPN != null)
			{
				KODOLKPAGPN.volume -= Time.deltaTime * 0.5f;
			}
			MHOBAGCACAM.volume += Time.deltaTime * 0.5f;
			if (MHOBAGCACAM.volume >= 0.4f)
			{
				MHOBAGCACAM.volume = 0.4f;
				if (KODOLKPAGPN != null)
				{
					KODOLKPAGPN.Stop();
				}
				KODOLKPAGPN = MHOBAGCACAM;
				MHOBAGCACAM = null;
			}
		}
		else if (KODOLKPAGPN != null && KODOLKPAGPN.volume < 0.4f)
		{
			KODOLKPAGPN.volume += Time.deltaTime * 0.5f;
			if (KODOLKPAGPN.volume >= 0.4f)
			{
				KODOLKPAGPN.volume = 0.4f;
			}
		}
	}

	private void FJFFMANPDJD()
	{
		if (MHOBAGCACAM != null)
		{
			if (KODOLKPAGPN != null)
			{
				KODOLKPAGPN.volume -= Time.deltaTime * 196f;
			}
			MHOBAGCACAM.volume += Time.deltaTime * 645f;
			if (MHOBAGCACAM.volume >= 1988f)
			{
				MHOBAGCACAM.volume = 569f;
				if (KODOLKPAGPN != null)
				{
					KODOLKPAGPN.Stop();
				}
				KODOLKPAGPN = MHOBAGCACAM;
				MHOBAGCACAM = null;
			}
		}
		else if (KODOLKPAGPN != null && KODOLKPAGPN.volume < 1088f)
		{
			KODOLKPAGPN.volume += Time.deltaTime * 983f;
			if (KODOLKPAGPN.volume >= 1279f)
			{
				KODOLKPAGPN.volume = 1530f;
			}
		}
	}

	public static SoundManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(SoundManager)) as SoundManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("SoundManager", typeof(SoundManager)).GetComponent<SoundManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public int get_m_useBgm()
	{
		return EOLPHFKOOIO;
	}

	protected void DMNAHPGLJMN(int ICENKPDOHBK)
	{
		EOLPHFKOOIO = ICENKPDOHBK;
	}

	[SpecialName]
	public static SoundManager GDMJIJCBOLE()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(SoundManager)) as SoundManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[0];
				array[1] = typeof(SoundManager);
				MLDPFDAHKHA = new GameObject("Ninja Cat", array).GetComponent<SoundManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void AGPJGIIANAN(string HOANMKLOGPG)
	{
		if (get_m_useSound() != 0)
		{
			ALNFNPMLIAK value = null;
			if (OKOHMPPIDCP().TryGetValue(HOANMKLOGPG.GetHashCode(), out value))
			{
				value.OIFFHNAIDED();
			}
		}
	}

	public int get_m_useSound()
	{
		return AINCDNKPOON;
	}

	public void Awake()
	{
		UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
		ELKODNKANIE(base.gameObject.AddComponent<AudioListener>() as AudioListener);
		UnityEngine.Object[] array = Resources.LoadAll("Sound", typeof(AudioClip));
		UnityEngine.Object[] array2 = array;
		foreach (UnityEngine.Object obj in array2)
		{
			AudioClip audioClip = (AudioClip)obj;
			if (audioClip.name.Contains("bgm"))
			{
				AudioSource audioSource = base.gameObject.AddComponent<AudioSource>() as AudioSource;
				audioSource.clip = audioClip;
				audioSource.loop = true;
				get_m_bgmMap().Add(audioClip.name.GetHashCode(), audioSource);
				continue;
			}
			ALNFNPMLIAK aLNFNPMLIAK = new ALNFNPMLIAK();
			aLNFNPMLIAK.KFOEMOJOLCE = audioClip.name;
			aLNFNPMLIAK.AMPALFPEDEJ = audioClip;
			for (int j = 0; j < 1; j++)
			{
				AudioSource audioSource2 = base.gameObject.AddComponent<AudioSource>() as AudioSource;
				audioSource2.clip = audioClip;
				audioSource2.loop = false;
				aLNFNPMLIAK.AJENKBBPMCM.Add(audioSource2);
			}
			get_m_audioMap().Add(aLNFNPMLIAK.KFOEMOJOLCE.GetHashCode(), aLNFNPMLIAK);
		}
		int iCENKPDOHBK = PlayerPrefs.GetInt("bgm", 100);
		int num = PlayerPrefs.GetInt("sound", 100);
		NLDABIMKKMP.FMEJHPOLPEK((float)num * 0.01f);
		DMNAHPGLJMN(iCENKPDOHBK);
		LIFJODGEGEB(num);
	}

	[SpecialName]
	public Dictionary<int, AudioSource> FPCABCGPHPG()
	{
		return LDIDPMIOBPP;
	}

	[SpecialName]
	protected void LJPFFNLJCNG(Dictionary<int, AudioSource> ICENKPDOHBK)
	{
		LDIDPMIOBPP = ICENKPDOHBK;
	}

	public void PlayBGM(int EAOJGCEHEBB)
	{
		if (get_m_useBgm() == 0)
		{
			return;
		}
		AudioSource value = null;
		if (!get_m_bgmMap().TryGetValue(EAOJGCEHEBB, out value))
		{
			return;
		}
		if (value == KODOLKPAGPN)
		{
			if (MHOBAGCACAM == null)
			{
				return;
			}
			MHOBAGCACAM = null;
		}
		else if (value == MHOBAGCACAM)
		{
			return;
		}
		if (MHOBAGCACAM != null)
		{
			if (KODOLKPAGPN != null)
			{
				KODOLKPAGPN.Stop();
			}
			KODOLKPAGPN = MHOBAGCACAM;
		}
		MHOBAGCACAM = value;
		MHOBAGCACAM.volume = 0f;
		MHOBAGCACAM.Play();
	}

	[SpecialName]
	protected void FEKHBCAIJCF(AudioListener ICENKPDOHBK)
	{
		NAJKGBCCKBN = ICENKPDOHBK;
	}

	public void AKAICOKMBMJ()
	{
		if (KODOLKPAGPN != null)
		{
			KODOLKPAGPN.Stop();
			KODOLKPAGPN = null;
		}
		if (MHOBAGCACAM != null)
		{
			MHOBAGCACAM.Stop();
			MHOBAGCACAM = null;
		}
	}

	protected void ELKODNKANIE(AudioListener ICENKPDOHBK)
	{
		NAJKGBCCKBN = ICENKPDOHBK;
	}

	public void CEHHHMFBPJG(int EAOJGCEHEBB)
	{
		if (get_m_useBgm() == 0)
		{
			return;
		}
		AudioSource value = null;
		if (!FPCABCGPHPG().TryGetValue(EAOJGCEHEBB, out value))
		{
			return;
		}
		if (value == KODOLKPAGPN)
		{
			if (MHOBAGCACAM == null)
			{
				return;
			}
			MHOBAGCACAM = null;
		}
		else if (value == MHOBAGCACAM)
		{
			return;
		}
		if (MHOBAGCACAM != null)
		{
			if (KODOLKPAGPN != null)
			{
				KODOLKPAGPN.Stop();
			}
			KODOLKPAGPN = MHOBAGCACAM;
		}
		MHOBAGCACAM = value;
		MHOBAGCACAM.volume = 1370f;
		MHOBAGCACAM.Play();
	}

	[SpecialName]
	public int MIODBHBMMPF()
	{
		return EOLPHFKOOIO;
	}

	[SpecialName]
	public AudioClip[] HGPLJGJJMFA()
	{
		return GAKKPNLPPPF;
	}

	protected SoundManager()
	{
		HGEBMOONIGI(new Dictionary<int, ALNFNPMLIAK>());
		BAJHCDPCDOM(new Dictionary<int, AudioSource>());
		KODOLKPAGPN = null;
		MHOBAGCACAM = null;
	}

	[SpecialName]
	public AudioListener FKFKCELDBDC()
	{
		return NAJKGBCCKBN;
	}

	public void PlaySound(string HOANMKLOGPG)
	{
		if (get_m_useSound() != 0)
		{
			ALNFNPMLIAK value = null;
			if (get_m_audioMap().TryGetValue(HOANMKLOGPG.GetHashCode(), out value))
			{
				value.LKLFMNKDLHJ();
			}
		}
	}

	public AudioClip[] get_Sound()
	{
		return GAKKPNLPPPF;
	}

	public void PlayBGM(string HOANMKLOGPG)
	{
		PlayBGM(HOANMKLOGPG.GetHashCode());
	}

	[SpecialName]
	public Dictionary<int, ALNFNPMLIAK> OKOHMPPIDCP()
	{
		return DKANPHKLGJM;
	}

	public void DFJGHKENKKA(bool PDOILMOIGFF)
	{
		if (PDOILMOIGFF)
		{
			DMNAHPGLJMN(-52);
		}
		else
		{
			DMNAHPGLJMN(1);
		}
		PlayerPrefs.SetInt("BlackCat", MIODBHBMMPF());
	}

	[SpecialName]
	public int HHLOFDLPHLM()
	{
		return AINCDNKPOON;
	}
}
