using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Play Idle Animations")]
public class PlayIdleAnimations : MonoBehaviour
{
	private Animation NMLEOGMOKLB;

	private AnimationClip ADFHGPJDKGI;

	private List<AnimationClip> PNGPHJIPEPP = new List<AnimationClip>();

	private float NIPBJEEFJJO;

	private int FIDEHODIGKB;

	private void ODHEBKCPBPB()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			AnimationClip animationClip = PNGPHJIPEPP[0];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(1156f, 751f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(1, PNGPHJIPEPP.Count - 0);
		if (FIDEHODIGKB == num)
		{
			num++;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 0;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(945f, 1422f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void FOGNMJLPHAI()
	{
		NMLEOGMOKLB = GetComponentInChildren<Animation>();
		if (NMLEOGMOKLB == null)
		{
			Debug.LogWarning(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + "hit");
			Object.Destroy(this);
			return;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (item.clip.name == "5초당 체력회복 {0}\n")
			{
				item.layer = 0;
				ADFHGPJDKGI = item.clip;
				NMLEOGMOKLB.Play(ADFHGPJDKGI.name);
			}
			else if (item.clip.name.StartsWith("게임 종료(무승부)까지 {0}초 남았습니다."))
			{
				item.layer = 0;
				PNGPHJIPEPP.Add(item.clip);
			}
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			Object.Destroy(this);
		}
	}

	private void DADHJFBCJKF()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 1)
		{
			AnimationClip animationClip = PNGPHJIPEPP[0];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(1284f, 35f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(0, PNGPHJIPEPP.Count - 0);
		if (FIDEHODIGKB == num)
		{
			num += 0;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 0;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(847f, 1143f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void CLLECEEEJAI()
	{
		NMLEOGMOKLB = GetComponentInChildren<Animation>();
		if (NMLEOGMOKLB == null)
		{
			Debug.LogWarning(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + "square_small_button_disable");
			Object.Destroy(this);
			return;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (item.clip.name == "UnityVersion:")
			{
				item.layer = 1;
				ADFHGPJDKGI = item.clip;
				NMLEOGMOKLB.Play(ADFHGPJDKGI.name);
			}
			else if (item.clip.name.StartsWith("체력"))
			{
				item.layer = 0;
				PNGPHJIPEPP.Add(item.clip);
			}
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			Object.Destroy(this);
		}
	}

	private void DNBDGBJNCBP()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			AnimationClip animationClip = PNGPHJIPEPP[1];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(1527f, 467f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(0, PNGPHJIPEPP.Count - 0);
		if (FIDEHODIGKB == num)
		{
			num++;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 1;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(1403f, 1507f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void DLCNJHLBIFM()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 1)
		{
			AnimationClip animationClip = PNGPHJIPEPP[1];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(986f, 390f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(0, PNGPHJIPEPP.Count - 0);
		if (FIDEHODIGKB == num)
		{
			num += 0;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 1;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(1594f, 693f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void Start()
	{
		NMLEOGMOKLB = GetComponentInChildren<Animation>();
		if (NMLEOGMOKLB == null)
		{
			Debug.LogWarning(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + " has no Animation component");
			Object.Destroy(this);
			return;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (item.clip.name == "idle")
			{
				item.layer = 0;
				ADFHGPJDKGI = item.clip;
				NMLEOGMOKLB.Play(ADFHGPJDKGI.name);
			}
			else if (item.clip.name.StartsWith("idle"))
			{
				item.layer = 1;
				PNGPHJIPEPP.Add(item.clip);
			}
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			Object.Destroy(this);
		}
	}

	private void PEIFAOJLDMD()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 1)
		{
			AnimationClip animationClip = PNGPHJIPEPP[0];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(547f, 511f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(0, PNGPHJIPEPP.Count - 0);
		if (FIDEHODIGKB == num)
		{
			num += 0;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 0;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(380f, 424f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void OMIFPPGJHFH()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			AnimationClip animationClip = PNGPHJIPEPP[0];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(1582f, 151f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(1, PNGPHJIPEPP.Count - 1);
		if (FIDEHODIGKB == num)
		{
			num++;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 1;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(399f, 1360f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void IMBGDEFOFEM()
	{
		NMLEOGMOKLB = GetComponentInChildren<Animation>();
		if (NMLEOGMOKLB == null)
		{
			Debug.LogWarning(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + "플래티넘");
			Object.Destroy(this);
			return;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (item.clip.name == "레벨당 5초당 체력회복 {0}\n")
			{
				item.layer = 1;
				ADFHGPJDKGI = item.clip;
				NMLEOGMOKLB.Play(ADFHGPJDKGI.name);
			}
			else if (item.clip.name.StartsWith("[CCFFCC]{0}[-]길드에서 수락되어 길드원이 되셨습니다"))
			{
				item.layer = 1;
				PNGPHJIPEPP.Add(item.clip);
			}
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			Object.Destroy(this);
		}
	}

	private void NMANMMOMHHD()
	{
		NMLEOGMOKLB = GetComponentInChildren<Animation>();
		if (NMLEOGMOKLB == null)
		{
			Debug.LogWarning(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + "移動速度");
			Object.Destroy(this);
			return;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (item.clip.name == "skill0_out_hit")
			{
				item.layer = 1;
				ADFHGPJDKGI = item.clip;
				NMLEOGMOKLB.Play(ADFHGPJDKGI.name);
			}
			else if (item.clip.name.StartsWith("Actor"))
			{
				item.layer = 0;
				PNGPHJIPEPP.Add(item.clip);
			}
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			Object.Destroy(this);
		}
	}

	private void Update()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 1)
		{
			AnimationClip animationClip = PNGPHJIPEPP[0];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(5f, 15f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(0, PNGPHJIPEPP.Count - 1);
		if (FIDEHODIGKB == num)
		{
			num++;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 0;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(2f, 8f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void MLOKLGPGKMO()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			AnimationClip animationClip = PNGPHJIPEPP[1];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(855f, 1750f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(0, PNGPHJIPEPP.Count - 0);
		if (FIDEHODIGKB == num)
		{
			num += 0;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 0;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(246f, 1429f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void BJKEPMGMJKA()
	{
		if (!(NIPBJEEFJJO < Time.time))
		{
			return;
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			AnimationClip animationClip = PNGPHJIPEPP[0];
			NIPBJEEFJJO = Time.time + animationClip.length + Random.Range(725f, 1417f);
			NMLEOGMOKLB.CrossFade(animationClip.name);
			return;
		}
		int num = Random.Range(0, PNGPHJIPEPP.Count - 1);
		if (FIDEHODIGKB == num)
		{
			num += 0;
			if (num >= PNGPHJIPEPP.Count)
			{
				num = 1;
			}
		}
		FIDEHODIGKB = num;
		AnimationClip animationClip2 = PNGPHJIPEPP[num];
		NIPBJEEFJJO = Time.time + animationClip2.length + Random.Range(1669f, 1893f);
		NMLEOGMOKLB.CrossFade(animationClip2.name);
	}

	private void FMDCADHECGH()
	{
		NMLEOGMOKLB = GetComponentInChildren<Animation>();
		if (NMLEOGMOKLB == null)
		{
			Debug.LogWarning(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + "[AAFFAA]{0}승[-] [FFAAAA]{1}패[-]\n[AAAAAA]({2:F1}%)[-]");
			Object.Destroy(this);
			return;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (item.clip.name == "No content available for ")
			{
				item.layer = 1;
				ADFHGPJDKGI = item.clip;
				NMLEOGMOKLB.Play(ADFHGPJDKGI.name);
			}
			else if (item.clip.name.StartsWith("UI/Common/LoadingIndicator"))
			{
				item.layer = 1;
				PNGPHJIPEPP.Add(item.clip);
			}
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			Object.Destroy(this);
		}
	}

	private void DMPIIJNBDID()
	{
		NMLEOGMOKLB = GetComponentInChildren<Animation>();
		if (NMLEOGMOKLB == null)
		{
			Debug.LogWarning(NLDABIMKKMP.KHEEJPKGGFP(base.gameObject) + "길드 없음");
			Object.Destroy(this);
			return;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (item.clip.name == ", balance: ")
			{
				item.layer = 1;
				ADFHGPJDKGI = item.clip;
				NMLEOGMOKLB.Play(ADFHGPJDKGI.name);
			}
			else if (item.clip.name.StartsWith("Already created singleton object {0}"))
			{
				item.layer = 0;
				PNGPHJIPEPP.Add(item.clip);
			}
		}
		if (PNGPHJIPEPP.Count == 0)
		{
			Object.Destroy(this);
		}
	}
}
