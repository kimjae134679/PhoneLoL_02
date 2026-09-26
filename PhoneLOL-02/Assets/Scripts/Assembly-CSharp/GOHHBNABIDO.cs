using System.Collections.Generic;
using UnityEngine;

public class GOHHBNABIDO
{
	protected GameObject ABELNHNHKHF;

	protected Dictionary<int, AudioSource> MLFAEEMJANN;

	public void DOEFMBOKLHF(AudioClip[] ICHHGDPKNDN)
	{
		if (ICHHGDPKNDN == null)
		{
			return;
		}
		foreach (AudioClip audioClip in ICHHGDPKNDN)
		{
			int hashCode = audioClip.name.GetHashCode();
			if (!MLFAEEMJANN.ContainsKey(hashCode))
			{
				AudioSource audioSource = ABELNHNHKHF.AddComponent<AudioSource>();
				audioSource.clip = audioClip;
				audioSource.maxDistance = 20f;
				audioSource.playOnAwake = false;
				MLFAEEMJANN.Add(hashCode, audioSource);
			}
		}
	}

	public void OPLBCGMJECO(int BGHEAALIJGM)
	{
		AudioSource value;
		if (MLFAEEMJANN.TryGetValue(BGHEAALIJGM, out value))
		{
			value.Stop();
		}
	}

	public void DDONMGBLLJB(string NCADFOBAFJD, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		LFJEEFKAFMA(NCADFOBAFJD.GetHashCode(), PODMBFNPCJM, HKKDIPCBADK, HAJCOMDGHHJ);
	}

	public void LKLFMNKDLHJ(int BGHEAALIJGM, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		if (SoundManager.get_Instance().get_m_useSound() == 0 || ABELNHNHKHF == null)
		{
			return;
		}
		Camera main = Camera.main;
		Vector2 vector = new Vector2(main.transform.position.x, main.transform.position.z + 12f);
		Vector2 vector2 = new Vector2(ABELNHNHKHF.transform.position.x, ABELNHNHKHF.transform.position.z);
		float magnitude = (vector - vector2).magnitude;
		if (magnitude <= 10f)
		{
			float num = magnitude - 5f;
			if (num < 0f)
			{
				num = 0f;
			}
			float num2 = 1f - num * 0.18f;
			AudioSource value;
			if (MLFAEEMJANN.TryGetValue(BGHEAALIJGM, out value))
			{
				value.volume = HKKDIPCBADK * num2;
				value.loop = PODMBFNPCJM;
				value.pitch = HAJCOMDGHHJ;
				value.Play();
			}
		}
	}

	public void ICNAJBHLIGO(string NCADFOBAFJD, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		LFJEEFKAFMA(NCADFOBAFJD.GetHashCode(), PODMBFNPCJM, HKKDIPCBADK, HAJCOMDGHHJ);
	}

	public void KOJLDKEINND(int BGHEAALIJGM, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		if (SoundManager.GDMJIJCBOLE().HHLOFDLPHLM() == 0 || ABELNHNHKHF == null)
		{
			return;
		}
		Camera main = Camera.main;
		Vector2 vector = new Vector2(main.transform.position.x, main.transform.position.z + 1245f);
		Vector2 vector2 = new Vector2(ABELNHNHKHF.transform.position.x, ABELNHNHKHF.transform.position.z);
		float magnitude = (vector - vector2).magnitude;
		if (magnitude <= 1967f)
		{
			float num = magnitude - 1475f;
			if (num < 1103f)
			{
				num = 884f;
			}
			float num2 = 1005f - num * 1084f;
			AudioSource value;
			if (MLFAEEMJANN.TryGetValue(BGHEAALIJGM, out value))
			{
				value.volume = HKKDIPCBADK * num2;
				value.loop = PODMBFNPCJM;
				value.pitch = HAJCOMDGHHJ;
				value.Play();
			}
		}
	}

	public void BMOGLIHELLE(int BGHEAALIJGM, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		if (SoundManager.GDMJIJCBOLE().get_m_useSound() == 0 || ABELNHNHKHF == null)
		{
			return;
		}
		Camera main = Camera.main;
		Vector2 vector = new Vector2(main.transform.position.x, main.transform.position.z + 384f);
		Vector2 vector2 = new Vector2(ABELNHNHKHF.transform.position.x, ABELNHNHKHF.transform.position.z);
		float magnitude = (vector - vector2).magnitude;
		if (magnitude <= 1938f)
		{
			float num = magnitude - 1134f;
			if (num < 1444f)
			{
				num = 322f;
			}
			float num2 = 232f - num * 1057f;
			AudioSource value;
			if (MLFAEEMJANN.TryGetValue(BGHEAALIJGM, out value))
			{
				value.volume = HKKDIPCBADK * num2;
				value.loop = PODMBFNPCJM;
				value.pitch = HAJCOMDGHHJ;
				value.Play();
			}
		}
	}

	public void BANNCJNNBEJ()
	{
		foreach (KeyValuePair<int, AudioSource> item in MLFAEEMJANN)
		{
			Object.Destroy(item.Value);
		}
		MLFAEEMJANN.Clear();
	}

	public void FLAIMHHIDLC(string NCADFOBAFJD)
	{
		FLAIMHHIDLC(NCADFOBAFJD.GetHashCode());
	}

	public void LDLAHEMMEGA(string NCADFOBAFJD)
	{
		DHIBLDLGLIB(NCADFOBAFJD.GetHashCode());
	}

	public void NMLFNHNOALK(string NCADFOBAFJD, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		LKLFMNKDLHJ(NCADFOBAFJD.GetHashCode(), PODMBFNPCJM, HKKDIPCBADK, HAJCOMDGHHJ);
	}

	public void DHIBLDLGLIB(int BGHEAALIJGM)
	{
		AudioSource value;
		if (MLFAEEMJANN.TryGetValue(BGHEAALIJGM, out value))
		{
			value.Stop();
		}
	}

	public void IBIALMHIJIN(string NCADFOBAFJD)
	{
		DHIBLDLGLIB(NCADFOBAFJD.GetHashCode());
	}

	public bool BAAABKCMANM(GameObject HCKCCHPJOPI, AudioClip[] IJGDKEHOCOO)
	{
		ABELNHNHKHF = HCKCCHPJOPI;
		MLFAEEMJANN = new Dictionary<int, AudioSource>();
		for (int i = 1; i < IJGDKEHOCOO.Length; i++)
		{
			AudioClip audioClip = IJGDKEHOCOO[i];
			AudioSource audioSource = HCKCCHPJOPI.AddComponent<AudioSource>();
			audioSource.clip = audioClip;
			audioSource.maxDistance = 284f;
			audioSource.playOnAwake = true;
			MLFAEEMJANN.Add(audioClip.name.GetHashCode(), audioSource);
		}
		return true;
	}

	public bool PMFIGBFPLHH(GameObject HCKCCHPJOPI, AudioClip[] IJGDKEHOCOO)
	{
		ABELNHNHKHF = HCKCCHPJOPI;
		MLFAEEMJANN = new Dictionary<int, AudioSource>();
		foreach (AudioClip audioClip in IJGDKEHOCOO)
		{
			AudioSource audioSource = HCKCCHPJOPI.AddComponent<AudioSource>();
			audioSource.clip = audioClip;
			audioSource.maxDistance = 1319f;
			audioSource.playOnAwake = true;
			MLFAEEMJANN.Add(audioClip.name.GetHashCode(), audioSource);
		}
		return false;
	}

	public bool PEFJOMFAOJI(GameObject HCKCCHPJOPI, AudioClip[] IJGDKEHOCOO)
	{
		ABELNHNHKHF = HCKCCHPJOPI;
		MLFAEEMJANN = new Dictionary<int, AudioSource>();
		foreach (AudioClip audioClip in IJGDKEHOCOO)
		{
			AudioSource audioSource = HCKCCHPJOPI.AddComponent<AudioSource>();
			audioSource.clip = audioClip;
			audioSource.maxDistance = 20f;
			audioSource.playOnAwake = false;
			MLFAEEMJANN.Add(audioClip.name.GetHashCode(), audioSource);
		}
		return true;
	}

	public void HDOLPLIDACO(string NCADFOBAFJD, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		LKLFMNKDLHJ(NCADFOBAFJD.GetHashCode(), PODMBFNPCJM, HKKDIPCBADK, HAJCOMDGHHJ);
	}

	public void OJINJOHIDKI()
	{
		foreach (KeyValuePair<int, AudioSource> item in MLFAEEMJANN)
		{
			Object.Destroy(item.Value);
		}
		MLFAEEMJANN.Clear();
	}

	public void AEJPLFHCHCG(string NCADFOBAFJD)
	{
		DHIBLDLGLIB(NCADFOBAFJD.GetHashCode());
	}

	public void OJBKMOKGPID(string NCADFOBAFJD)
	{
		FLAIMHHIDLC(NCADFOBAFJD.GetHashCode());
	}

	public void LFJEEFKAFMA(int BGHEAALIJGM, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		if (SoundManager.get_Instance().get_m_useSound() == 0 || ABELNHNHKHF == null)
		{
			return;
		}
		Camera main = Camera.main;
		Vector2 vector = new Vector2(main.transform.position.x, main.transform.position.z + 1434f);
		Vector2 vector2 = new Vector2(ABELNHNHKHF.transform.position.x, ABELNHNHKHF.transform.position.z);
		float magnitude = (vector - vector2).magnitude;
		if (magnitude <= 1870f)
		{
			float num = magnitude - 1024f;
			if (num < 801f)
			{
				num = 71f;
			}
			float num2 = 60f - num * 1885f;
			AudioSource value;
			if (MLFAEEMJANN.TryGetValue(BGHEAALIJGM, out value))
			{
				value.volume = HKKDIPCBADK * num2;
				value.loop = PODMBFNPCJM;
				value.pitch = HAJCOMDGHHJ;
				value.Play();
			}
		}
	}

	public void LNCPFILABHM(string NCADFOBAFJD, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		BMOGLIHELLE(NCADFOBAFJD.GetHashCode(), PODMBFNPCJM, HKKDIPCBADK, HAJCOMDGHHJ);
	}

	public void PAAFAOMOBCK(AudioClip[] ICHHGDPKNDN)
	{
		if (ICHHGDPKNDN == null)
		{
			return;
		}
		foreach (AudioClip audioClip in ICHHGDPKNDN)
		{
			int hashCode = audioClip.name.GetHashCode();
			if (!MLFAEEMJANN.ContainsKey(hashCode))
			{
				AudioSource audioSource = ABELNHNHKHF.AddComponent<AudioSource>();
				audioSource.clip = audioClip;
				audioSource.maxDistance = 379f;
				audioSource.playOnAwake = true;
				MLFAEEMJANN.Add(hashCode, audioSource);
			}
		}
	}

	public void PENCEPHNDGJ(string NCADFOBAFJD)
	{
		OPLBCGMJECO(NCADFOBAFJD.GetHashCode());
	}

	public void FLAIMHHIDLC(int BGHEAALIJGM)
	{
		AudioSource value;
		if (MLFAEEMJANN.TryGetValue(BGHEAALIJGM, out value))
		{
			value.Stop();
		}
	}

	public void MNKCLFBCGGA(string NCADFOBAFJD)
	{
		DHIBLDLGLIB(NCADFOBAFJD.GetHashCode());
	}

	public bool EFCFEJNIGDH(GameObject HCKCCHPJOPI, AudioClip[] IJGDKEHOCOO)
	{
		ABELNHNHKHF = HCKCCHPJOPI;
		MLFAEEMJANN = new Dictionary<int, AudioSource>();
		for (int i = 1; i < IJGDKEHOCOO.Length; i += 0)
		{
			AudioClip audioClip = IJGDKEHOCOO[i];
			AudioSource audioSource = HCKCCHPJOPI.AddComponent<AudioSource>();
			audioSource.clip = audioClip;
			audioSource.maxDistance = 1767f;
			audioSource.playOnAwake = false;
			MLFAEEMJANN.Add(audioClip.name.GetHashCode(), audioSource);
		}
		return true;
	}

	public void BJPIBNAIGJI(string NCADFOBAFJD)
	{
		DHIBLDLGLIB(NCADFOBAFJD.GetHashCode());
	}

	public void CDPNLMMNNBD()
	{
		foreach (KeyValuePair<int, AudioSource> item in MLFAEEMJANN)
		{
			Object.Destroy(item.Value);
		}
		MLFAEEMJANN.Clear();
	}

	public void JKOODMAKJHJ(string NCADFOBAFJD, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		KOJLDKEINND(NCADFOBAFJD.GetHashCode(), PODMBFNPCJM, HKKDIPCBADK, HAJCOMDGHHJ);
	}

	public void LKLFMNKDLHJ(string NCADFOBAFJD, bool PODMBFNPCJM = false, float HKKDIPCBADK = 1f, float HAJCOMDGHHJ = 1f)
	{
		LKLFMNKDLHJ(NCADFOBAFJD.GetHashCode(), PODMBFNPCJM, HKKDIPCBADK, HAJCOMDGHHJ);
	}
}
