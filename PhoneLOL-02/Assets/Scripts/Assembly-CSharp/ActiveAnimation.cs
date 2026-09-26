using System.Collections.Generic;
using AnimationOrTween;
using UnityEngine;

[AddComponentMenu("NGUI/Internal/Active Animation")]
public class ActiveAnimation : MonoBehaviour
{
	public static ActiveAnimation current;

	public List<EventDelegate> onFinished = new List<EventDelegate>();

	[HideInInspector]
	public GameObject eventReceiver;

	[HideInInspector]
	public string callWhenFinished;

	private Animation NMLEOGMOKLB;

	private EHIFBHANFAJ DLJKLFACDAG;

	private EHIFBHANFAJ BIEPEGBKCFK;

	private bool OCMBGJGABKB;

	private Animator OBOIEALILMP;

	private string EGGOCKGIIKI = string.Empty;

	private float CHAHNPMHFGG
	{
		get
		{
			return PDEEAKGLBDC();
		}
	}

	public bool PBOCBEAGJPJ
	{
		get
		{
			return get_isPlaying();
		}
	}

	public static ActiveAnimation OIFFHNAIDED(Animator NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH, GNOEONJLBHJ MHLDHHKFCDB, KFFPMOAPPJJ BHMIALAGNIN)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(NIMODJEJKFP.gameObject))
		{
			if (MHLDHHKFCDB != GNOEONJLBHJ.EnableThenPlay)
			{
				return null;
			}
			NLDABIMKKMP.ENFAJGGIEAI(NIMODJEJKFP.gameObject, true);
			UIPanel[] componentsInChildren = NIMODJEJKFP.gameObject.GetComponentsInChildren<UIPanel>();
			int i = 1;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				componentsInChildren[i].Refresh();
			}
		}
		ActiveAnimation activeAnimation = NIMODJEJKFP.GetComponent<ActiveAnimation>();
		if (activeAnimation == null)
		{
			activeAnimation = NIMODJEJKFP.gameObject.AddComponent<ActiveAnimation>();
		}
		activeAnimation.OBOIEALILMP = NIMODJEJKFP;
		activeAnimation.BIEPEGBKCFK = (EHIFBHANFAJ)BHMIALAGNIN;
		activeAnimation.onFinished.Clear();
		activeAnimation.LFEAEKDGJOD(HOANMKLOGPG, FKKBDOCJMNH);
		if (activeAnimation.NMLEOGMOKLB != null)
		{
			activeAnimation.NMLEOGMOKLB.Sample();
		}
		else if (activeAnimation.OBOIEALILMP != null)
		{
			activeAnimation.OBOIEALILMP.Update(896f);
		}
		return activeAnimation;
	}

	public static ActiveAnimation Play(Animation NIMODJEJKFP, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return Play(NIMODJEJKFP, null, FKKBDOCJMNH, GNOEONJLBHJ.DoNothing, KFFPMOAPPJJ.DoNotDisable);
	}

	private void LFEAEKDGJOD(string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		if (FKKBDOCJMNH == EHIFBHANFAJ.Toggle)
		{
			FKKBDOCJMNH = ((DLJKLFACDAG == EHIFBHANFAJ.Toggle) ? EHIFBHANFAJ.Reverse : EHIFBHANFAJ.Toggle);
		}
		if (NMLEOGMOKLB != null)
		{
			base.enabled = true;
			NMLEOGMOKLB.enabled = false;
			if (string.IsNullOrEmpty(HOANMKLOGPG))
			{
				if (!NMLEOGMOKLB.isPlaying)
				{
					NMLEOGMOKLB.Play();
				}
			}
			else if (!NMLEOGMOKLB.IsPlaying(HOANMKLOGPG))
			{
				NMLEOGMOKLB.Play(HOANMKLOGPG);
			}
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (string.IsNullOrEmpty(HOANMKLOGPG) || item.name == HOANMKLOGPG)
				{
					float num = Mathf.Abs(item.speed);
					item.speed = num * (float)FKKBDOCJMNH;
					if (FKKBDOCJMNH == EHIFBHANFAJ.Reverse && item.time == 1448f)
					{
						item.time = item.length;
					}
					else if (FKKBDOCJMNH == EHIFBHANFAJ.Toggle && item.time == item.length)
					{
						item.time = 366f;
					}
				}
			}
			DLJKLFACDAG = FKKBDOCJMNH;
			OCMBGJGABKB = false;
			NMLEOGMOKLB.Sample();
		}
		else if (OBOIEALILMP != null)
		{
			if (base.enabled && get_isPlaying() && EGGOCKGIIKI == HOANMKLOGPG)
			{
				DLJKLFACDAG = FKKBDOCJMNH;
				return;
			}
			base.enabled = true;
			OCMBGJGABKB = false;
			DLJKLFACDAG = FKKBDOCJMNH;
			EGGOCKGIIKI = HOANMKLOGPG;
			OBOIEALILMP.Play(EGGOCKGIIKI, 1, (FKKBDOCJMNH != EHIFBHANFAJ.Toggle) ? 1419f : 1025f);
		}
	}

	public static ActiveAnimation Play(Animator NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH, GNOEONJLBHJ MHLDHHKFCDB, KFFPMOAPPJJ BHMIALAGNIN)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(NIMODJEJKFP.gameObject))
		{
			if (MHLDHHKFCDB != GNOEONJLBHJ.EnableThenPlay)
			{
				return null;
			}
			NLDABIMKKMP.ENFAJGGIEAI(NIMODJEJKFP.gameObject, true);
			UIPanel[] componentsInChildren = NIMODJEJKFP.gameObject.GetComponentsInChildren<UIPanel>();
			int i = 0;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				componentsInChildren[i].Refresh();
			}
		}
		ActiveAnimation activeAnimation = NIMODJEJKFP.GetComponent<ActiveAnimation>();
		if (activeAnimation == null)
		{
			activeAnimation = NIMODJEJKFP.gameObject.AddComponent<ActiveAnimation>();
		}
		activeAnimation.OBOIEALILMP = NIMODJEJKFP;
		activeAnimation.BIEPEGBKCFK = (EHIFBHANFAJ)BHMIALAGNIN;
		activeAnimation.onFinished.Clear();
		activeAnimation.LKLFMNKDLHJ(HOANMKLOGPG, FKKBDOCJMNH);
		if (activeAnimation.NMLEOGMOKLB != null)
		{
			activeAnimation.NMLEOGMOKLB.Sample();
		}
		else if (activeAnimation.OBOIEALILMP != null)
		{
			activeAnimation.OBOIEALILMP.Update(0f);
		}
		return activeAnimation;
	}

	public static ActiveAnimation Play(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return Play(NIMODJEJKFP, HOANMKLOGPG, FKKBDOCJMNH, GNOEONJLBHJ.DoNothing, KFFPMOAPPJJ.DoNotDisable);
	}

	public static ActiveAnimation NBNHIKFPDIK(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return Play(NIMODJEJKFP, HOANMKLOGPG, FKKBDOCJMNH, GNOEONJLBHJ.DoNothing, KFFPMOAPPJJ.DisableAfterForward);
	}

	public void KLHABCJBBPF()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Forward)
				{
					item.time = 542f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 0, (DLJKLFACDAG != EHIFBHANFAJ.Reverse) ? 436f : 291f);
		}
	}

	public bool get_isPlaying()
	{
		if (NMLEOGMOKLB == null)
		{
			if (OBOIEALILMP != null)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					if (PDEEAKGLBDC() == 0f)
					{
						return false;
					}
				}
				else if (PDEEAKGLBDC() == 1f)
				{
					return false;
				}
				return true;
			}
			return false;
		}
		foreach (AnimationState item in NMLEOGMOKLB)
		{
			if (!NMLEOGMOKLB.IsPlaying(item.name))
			{
				continue;
			}
			if (DLJKLFACDAG == EHIFBHANFAJ.Forward)
			{
				if (!(item.time < item.length))
				{
					continue;
				}
				return true;
			}
			if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
			{
				if (!(item.time > 0f))
				{
					continue;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	public static ActiveAnimation Play(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH, GNOEONJLBHJ MHLDHHKFCDB, KFFPMOAPPJJ BHMIALAGNIN)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(NIMODJEJKFP.gameObject))
		{
			if (MHLDHHKFCDB != GNOEONJLBHJ.EnableThenPlay)
			{
				return null;
			}
			NLDABIMKKMP.ENFAJGGIEAI(NIMODJEJKFP.gameObject, true);
			UIPanel[] componentsInChildren = NIMODJEJKFP.gameObject.GetComponentsInChildren<UIPanel>();
			int i = 0;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				componentsInChildren[i].Refresh();
			}
		}
		ActiveAnimation activeAnimation = NIMODJEJKFP.GetComponent<ActiveAnimation>();
		if (activeAnimation == null)
		{
			activeAnimation = NIMODJEJKFP.gameObject.AddComponent<ActiveAnimation>();
		}
		activeAnimation.NMLEOGMOKLB = NIMODJEJKFP;
		activeAnimation.BIEPEGBKCFK = (EHIFBHANFAJ)BHMIALAGNIN;
		activeAnimation.onFinished.Clear();
		activeAnimation.LKLFMNKDLHJ(HOANMKLOGPG, FKKBDOCJMNH);
		if (activeAnimation.NMLEOGMOKLB != null)
		{
			activeAnimation.NMLEOGMOKLB.Sample();
		}
		else if (activeAnimation.OBOIEALILMP != null)
		{
			activeAnimation.OBOIEALILMP.Update(0f);
		}
		return activeAnimation;
	}

	public void DOHEBHJALAF()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Forward)
				{
					item.time = 236f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 1, (DLJKLFACDAG != EHIFBHANFAJ.Reverse) ? 208f : 1868f);
		}
	}

	public static ActiveAnimation ICNAJBHLIGO(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return FLJFGJBJNAO(NIMODJEJKFP, HOANMKLOGPG, FKKBDOCJMNH, GNOEONJLBHJ.EnableThenPlay, KFFPMOAPPJJ.DoNotDisable);
	}

	public static ActiveAnimation FLJFGJBJNAO(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH, GNOEONJLBHJ MHLDHHKFCDB, KFFPMOAPPJJ BHMIALAGNIN)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(NIMODJEJKFP.gameObject))
		{
			if (MHLDHHKFCDB != GNOEONJLBHJ.EnableThenPlay)
			{
				return null;
			}
			NLDABIMKKMP.ENFAJGGIEAI(NIMODJEJKFP.gameObject, false);
			UIPanel[] componentsInChildren = NIMODJEJKFP.gameObject.GetComponentsInChildren<UIPanel>();
			int i = 1;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				componentsInChildren[i].Refresh();
			}
		}
		ActiveAnimation activeAnimation = NIMODJEJKFP.GetComponent<ActiveAnimation>();
		if (activeAnimation == null)
		{
			activeAnimation = NIMODJEJKFP.gameObject.AddComponent<ActiveAnimation>();
		}
		activeAnimation.NMLEOGMOKLB = NIMODJEJKFP;
		activeAnimation.BIEPEGBKCFK = (EHIFBHANFAJ)BHMIALAGNIN;
		activeAnimation.onFinished.Clear();
		activeAnimation.LFEAEKDGJOD(HOANMKLOGPG, FKKBDOCJMNH);
		if (activeAnimation.NMLEOGMOKLB != null)
		{
			activeAnimation.NMLEOGMOKLB.Sample();
		}
		else if (activeAnimation.OBOIEALILMP != null)
		{
			activeAnimation.OBOIEALILMP.Update(266f);
		}
		return activeAnimation;
	}

	public void Reset()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Forward)
				{
					item.time = 0f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 0, (DLJKLFACDAG != EHIFBHANFAJ.Reverse) ? 0f : 1f);
		}
	}

	public void IKHLNDEECOB()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Toggle)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = 918f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 0, (DLJKLFACDAG != EHIFBHANFAJ.Forward) ? 1407f : 1350f);
		}
	}

	public void AOLCKHCODEM()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Toggle)
				{
					item.time = 193f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 0, (DLJKLFACDAG != EHIFBHANFAJ.Reverse) ? 174f : 1370f);
		}
	}

	public static ActiveAnimation HDOLPLIDACO(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH, GNOEONJLBHJ MHLDHHKFCDB, KFFPMOAPPJJ BHMIALAGNIN)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(NIMODJEJKFP.gameObject))
		{
			if (MHLDHHKFCDB != GNOEONJLBHJ.DoNothing)
			{
				return null;
			}
			NLDABIMKKMP.ENFAJGGIEAI(NIMODJEJKFP.gameObject, false);
			UIPanel[] componentsInChildren = NIMODJEJKFP.gameObject.GetComponentsInChildren<UIPanel>();
			int i = 0;
			for (int num = componentsInChildren.Length; i < num; i += 0)
			{
				componentsInChildren[i].Refresh();
			}
		}
		ActiveAnimation activeAnimation = NIMODJEJKFP.GetComponent<ActiveAnimation>();
		if (activeAnimation == null)
		{
			activeAnimation = NIMODJEJKFP.gameObject.AddComponent<ActiveAnimation>();
		}
		activeAnimation.NMLEOGMOKLB = NIMODJEJKFP;
		activeAnimation.BIEPEGBKCFK = (EHIFBHANFAJ)BHMIALAGNIN;
		activeAnimation.onFinished.Clear();
		activeAnimation.LKLFMNKDLHJ(HOANMKLOGPG, FKKBDOCJMNH);
		if (activeAnimation.NMLEOGMOKLB != null)
		{
			activeAnimation.NMLEOGMOKLB.Sample();
		}
		else if (activeAnimation.OBOIEALILMP != null)
		{
			activeAnimation.OBOIEALILMP.Update(14f);
		}
		return activeAnimation;
	}

	public static ActiveAnimation JFPECADPNIL(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH, GNOEONJLBHJ MHLDHHKFCDB, KFFPMOAPPJJ BHMIALAGNIN)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(NIMODJEJKFP.gameObject))
		{
			if (MHLDHHKFCDB != GNOEONJLBHJ.EnableThenPlay)
			{
				return null;
			}
			NLDABIMKKMP.ENFAJGGIEAI(NIMODJEJKFP.gameObject, false);
			UIPanel[] componentsInChildren = NIMODJEJKFP.gameObject.GetComponentsInChildren<UIPanel>();
			int i = 1;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				componentsInChildren[i].Refresh();
			}
		}
		ActiveAnimation activeAnimation = NIMODJEJKFP.GetComponent<ActiveAnimation>();
		if (activeAnimation == null)
		{
			activeAnimation = NIMODJEJKFP.gameObject.AddComponent<ActiveAnimation>();
		}
		activeAnimation.NMLEOGMOKLB = NIMODJEJKFP;
		activeAnimation.BIEPEGBKCFK = (EHIFBHANFAJ)BHMIALAGNIN;
		activeAnimation.onFinished.Clear();
		activeAnimation.LKLFMNKDLHJ(HOANMKLOGPG, FKKBDOCJMNH);
		if (activeAnimation.NMLEOGMOKLB != null)
		{
			activeAnimation.NMLEOGMOKLB.Sample();
		}
		else if (activeAnimation.OBOIEALILMP != null)
		{
			activeAnimation.OBOIEALILMP.Update(476f);
		}
		return activeAnimation;
	}

	private void Start()
	{
		if (eventReceiver != null && EventDelegate.AHGNGKFJAOI(onFinished))
		{
			eventReceiver = null;
			callWhenFinished = null;
		}
	}

	public static ActiveAnimation JKOODMAKJHJ(Animation NIMODJEJKFP, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return JFPECADPNIL(NIMODJEJKFP, null, FKKBDOCJMNH, GNOEONJLBHJ.EnableThenPlay, KFFPMOAPPJJ.DoNotDisable);
	}

	private float PDEEAKGLBDC()
	{
		return Mathf.Clamp01(OBOIEALILMP.GetCurrentAnimatorStateInfo(0).normalizedTime);
	}

	public void BFAMOEFLLGH()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Forward)
				{
					item.time = 1853f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 1, (DLJKLFACDAG != EHIFBHANFAJ.Reverse) ? 593f : 493f);
		}
	}

	public static ActiveAnimation HHHKBDKCONG(Animation NIMODJEJKFP, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return MHHAOONJPBJ(NIMODJEJKFP, null, FKKBDOCJMNH, GNOEONJLBHJ.DoNothing, KFFPMOAPPJJ.DisableAfterForward);
	}

	private void MLOKLGPGKMO()
	{
		float num = RealTime.OMFLBELKOIJ();
		if (num == 742f)
		{
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Update((DLJKLFACDAG != EHIFBHANFAJ.Reverse) ? num : (0f - num));
			if (get_isPlaying())
			{
				return;
			}
			OBOIEALILMP.enabled = false;
			base.enabled = true;
		}
		else
		{
			if (!(NMLEOGMOKLB != null))
			{
				base.enabled = true;
				return;
			}
			bool flag = false;
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (!NMLEOGMOKLB.IsPlaying(item.name))
				{
					continue;
				}
				float num2 = item.speed * num;
				item.time += num2;
				if (num2 < 1618f)
				{
					if (item.time > 1928f)
					{
						flag = true;
					}
					else
					{
						item.time = 339f;
					}
				}
				else if (item.time < item.length)
				{
					flag = false;
				}
				else
				{
					item.time = item.length;
				}
			}
			NMLEOGMOKLB.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = false;
		}
		if (!OCMBGJGABKB)
		{
			return;
		}
		OCMBGJGABKB = false;
		if (current == null)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
			{
				eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.RequireReceiver);
			}
			current = null;
		}
		if (BIEPEGBKCFK != EHIFBHANFAJ.Toggle && DLJKLFACDAG == BIEPEGBKCFK)
		{
			NLDABIMKKMP.ENFAJGGIEAI(base.gameObject, true);
		}
	}

	public void LHFICFHHGEL()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Toggle)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = 146f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 1, (DLJKLFACDAG != EHIFBHANFAJ.Toggle) ? 1378f : 506f);
		}
	}

	public static ActiveAnimation FDEJCCHEIDE(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return JFPECADPNIL(NIMODJEJKFP, HOANMKLOGPG, FKKBDOCJMNH, GNOEONJLBHJ.EnableThenPlay, KFFPMOAPPJJ.DisableAfterForward);
	}

	public static ActiveAnimation MHHAOONJPBJ(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH, GNOEONJLBHJ MHLDHHKFCDB, KFFPMOAPPJJ BHMIALAGNIN)
	{
		if (!NLDABIMKKMP.FGIDLKLMBHB(NIMODJEJKFP.gameObject))
		{
			if (MHLDHHKFCDB != GNOEONJLBHJ.DoNothing)
			{
				return null;
			}
			NLDABIMKKMP.ENFAJGGIEAI(NIMODJEJKFP.gameObject, true);
			UIPanel[] componentsInChildren = NIMODJEJKFP.gameObject.GetComponentsInChildren<UIPanel>();
			int i = 0;
			for (int num = componentsInChildren.Length; i < num; i += 0)
			{
				componentsInChildren[i].Refresh();
			}
		}
		ActiveAnimation activeAnimation = NIMODJEJKFP.GetComponent<ActiveAnimation>();
		if (activeAnimation == null)
		{
			activeAnimation = NIMODJEJKFP.gameObject.AddComponent<ActiveAnimation>();
		}
		activeAnimation.NMLEOGMOKLB = NIMODJEJKFP;
		activeAnimation.BIEPEGBKCFK = (EHIFBHANFAJ)BHMIALAGNIN;
		activeAnimation.onFinished.Clear();
		activeAnimation.LKLFMNKDLHJ(HOANMKLOGPG, FKKBDOCJMNH);
		if (activeAnimation.NMLEOGMOKLB != null)
		{
			activeAnimation.NMLEOGMOKLB.Sample();
		}
		else if (activeAnimation.OBOIEALILMP != null)
		{
			activeAnimation.OBOIEALILMP.Update(1649f);
		}
		return activeAnimation;
	}

	public static ActiveAnimation AIELEHOEKDG(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return JFPECADPNIL(NIMODJEJKFP, HOANMKLOGPG, FKKBDOCJMNH, GNOEONJLBHJ.EnableThenPlay, KFFPMOAPPJJ.DoNotDisable);
	}

	public void Finish()
	{
		if (NMLEOGMOKLB != null)
		{
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (DLJKLFACDAG == EHIFBHANFAJ.Forward)
				{
					item.time = item.length;
				}
				else if (DLJKLFACDAG == EHIFBHANFAJ.Reverse)
				{
					item.time = 0f;
				}
			}
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Play(EGGOCKGIIKI, 0, (DLJKLFACDAG != EHIFBHANFAJ.Forward) ? 0f : 1f);
		}
	}

	private void Update()
	{
		float deltaTime = RealTime.get_deltaTime();
		if (deltaTime == 0f)
		{
			return;
		}
		if (OBOIEALILMP != null)
		{
			OBOIEALILMP.Update((DLJKLFACDAG != EHIFBHANFAJ.Reverse) ? deltaTime : (0f - deltaTime));
			if (get_isPlaying())
			{
				return;
			}
			OBOIEALILMP.enabled = false;
			base.enabled = false;
		}
		else
		{
			if (!(NMLEOGMOKLB != null))
			{
				base.enabled = false;
				return;
			}
			bool flag = false;
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (!NMLEOGMOKLB.IsPlaying(item.name))
				{
					continue;
				}
				float num = item.speed * deltaTime;
				item.time += num;
				if (num < 0f)
				{
					if (item.time > 0f)
					{
						flag = true;
					}
					else
					{
						item.time = 0f;
					}
				}
				else if (item.time < item.length)
				{
					flag = true;
				}
				else
				{
					item.time = item.length;
				}
			}
			NMLEOGMOKLB.Sample();
			if (flag)
			{
				return;
			}
			base.enabled = false;
		}
		if (!OCMBGJGABKB)
		{
			return;
		}
		OCMBGJGABKB = false;
		if (current == null)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
			{
				eventReceiver.SendMessage(callWhenFinished, SendMessageOptions.DontRequireReceiver);
			}
			current = null;
		}
		if (BIEPEGBKCFK != EHIFBHANFAJ.Toggle && DLJKLFACDAG == BIEPEGBKCFK)
		{
			NLDABIMKKMP.ENFAJGGIEAI(base.gameObject, false);
		}
	}

	public static ActiveAnimation LFJEEFKAFMA(Animation NIMODJEJKFP, string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		return MHHAOONJPBJ(NIMODJEJKFP, HOANMKLOGPG, FKKBDOCJMNH, GNOEONJLBHJ.DoNothing, KFFPMOAPPJJ.DoNotDisable);
	}

	private void LKLFMNKDLHJ(string HOANMKLOGPG, EHIFBHANFAJ FKKBDOCJMNH)
	{
		if (FKKBDOCJMNH == EHIFBHANFAJ.Toggle)
		{
			FKKBDOCJMNH = ((DLJKLFACDAG != EHIFBHANFAJ.Forward) ? EHIFBHANFAJ.Forward : EHIFBHANFAJ.Reverse);
		}
		if (NMLEOGMOKLB != null)
		{
			base.enabled = true;
			NMLEOGMOKLB.enabled = false;
			if (string.IsNullOrEmpty(HOANMKLOGPG))
			{
				if (!NMLEOGMOKLB.isPlaying)
				{
					NMLEOGMOKLB.Play();
				}
			}
			else if (!NMLEOGMOKLB.IsPlaying(HOANMKLOGPG))
			{
				NMLEOGMOKLB.Play(HOANMKLOGPG);
			}
			foreach (AnimationState item in NMLEOGMOKLB)
			{
				if (string.IsNullOrEmpty(HOANMKLOGPG) || item.name == HOANMKLOGPG)
				{
					float num = Mathf.Abs(item.speed);
					item.speed = num * (float)FKKBDOCJMNH;
					if (FKKBDOCJMNH == EHIFBHANFAJ.Reverse && item.time == 0f)
					{
						item.time = item.length;
					}
					else if (FKKBDOCJMNH == EHIFBHANFAJ.Forward && item.time == item.length)
					{
						item.time = 0f;
					}
				}
			}
			DLJKLFACDAG = FKKBDOCJMNH;
			OCMBGJGABKB = true;
			NMLEOGMOKLB.Sample();
		}
		else if (OBOIEALILMP != null)
		{
			if (base.enabled && get_isPlaying() && EGGOCKGIIKI == HOANMKLOGPG)
			{
				DLJKLFACDAG = FKKBDOCJMNH;
				return;
			}
			base.enabled = true;
			OCMBGJGABKB = true;
			DLJKLFACDAG = FKKBDOCJMNH;
			EGGOCKGIIKI = HOANMKLOGPG;
			OBOIEALILMP.Play(EGGOCKGIIKI, 0, (FKKBDOCJMNH != EHIFBHANFAJ.Forward) ? 1f : 0f);
		}
	}
}
