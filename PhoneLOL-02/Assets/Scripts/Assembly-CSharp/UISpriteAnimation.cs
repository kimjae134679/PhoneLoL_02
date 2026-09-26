using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/UI/Sprite Animation")]
[RequireComponent(typeof(UISprite))]
public class UISpriteAnimation : MonoBehaviour
{
	[HideInInspector]
	[SerializeField]
	protected int mFPS = 30;

	[HideInInspector]
	[SerializeField]
	protected string mPrefix = string.Empty;

	[SerializeField]
	[HideInInspector]
	protected bool mLoop = true;

	[HideInInspector]
	[SerializeField]
	protected bool mSnap = true;

	protected UISprite MCOKEKMANAF;

	protected float CMNEPIJBAHA;

	protected int EMPCBNMOHGI;

	protected bool FIHNOEAJEJH = true;

	protected List<string> CGBHFJCCMAB = new List<string>();

	public int NOBNBJOKJHI
	{
		get
		{
			return get_frames();
		}
	}

	public int DEEJFGCHCAP
	{
		get
		{
			return get_framesPerSecond();
		}
		set
		{
			set_framesPerSecond(value);
		}
	}

	public string DKIBJCCBNPB
	{
		get
		{
			return get_namePrefix();
		}
		set
		{
			set_namePrefix(value);
		}
	}

	public bool PODMBFNPCJM
	{
		get
		{
			return get_loop();
		}
		set
		{
			set_loop(value);
		}
	}

	public bool PBOCBEAGJPJ
	{
		get
		{
			return get_isPlaying();
		}
	}

	public void set_loop(bool ICENKPDOHBK)
	{
		mLoop = ICENKPDOHBK;
	}

	public void GKMLNKIAELP()
	{
		if (MCOKEKMANAF == null)
		{
			MCOKEKMANAF = GetComponent<UISprite>();
		}
		CGBHFJCCMAB.Clear();
		if (!(MCOKEKMANAF != null) || !(MCOKEKMANAF.get_atlas() != null))
		{
			return;
		}
		List<UISpriteData> spriteList = MCOKEKMANAF.get_atlas().get_spriteList();
		int i = 0;
		for (int count = spriteList.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = spriteList[i];
			if (string.IsNullOrEmpty(mPrefix) || uISpriteData.name.StartsWith(mPrefix))
			{
				CGBHFJCCMAB.Add(uISpriteData.name);
			}
		}
		CGBHFJCCMAB.Sort();
	}

	public int get_frames()
	{
		return CGBHFJCCMAB.Count;
	}

	public void set_namePrefix(string ICENKPDOHBK)
	{
		if (mPrefix != ICENKPDOHBK)
		{
			mPrefix = ICENKPDOHBK;
			RebuildSpriteList();
		}
	}

	protected virtual void Update()
	{
		if (!FIHNOEAJEJH || CGBHFJCCMAB.Count <= 1 || !Application.isPlaying || !((float)mFPS > 0f))
		{
			return;
		}
		CMNEPIJBAHA += RealTime.get_deltaTime();
		float num = 1f / (float)mFPS;
		if (!(num < CMNEPIJBAHA))
		{
			return;
		}
		CMNEPIJBAHA = ((!(num > 0f)) ? 0f : (CMNEPIJBAHA - num));
		if (++EMPCBNMOHGI >= CGBHFJCCMAB.Count)
		{
			EMPCBNMOHGI = 0;
			FIHNOEAJEJH = get_loop();
		}
		if (FIHNOEAJEJH)
		{
			MCOKEKMANAF.set_spriteName(CGBHFJCCMAB[EMPCBNMOHGI]);
			if (mSnap)
			{
				MCOKEKMANAF.MakePixelPerfect();
			}
		}
	}

	[SpecialName]
	public void OOEBBDFMBFJ(int ICENKPDOHBK)
	{
		mFPS = ICENKPDOHBK;
	}

	public void Reset()
	{
		FIHNOEAJEJH = true;
		EMPCBNMOHGI = 0;
		if (MCOKEKMANAF != null && CGBHFJCCMAB.Count > 0)
		{
			MCOKEKMANAF.set_spriteName(CGBHFJCCMAB[EMPCBNMOHGI]);
			if (mSnap)
			{
				MCOKEKMANAF.MakePixelPerfect();
			}
		}
	}

	public void set_framesPerSecond(int ICENKPDOHBK)
	{
		mFPS = ICENKPDOHBK;
	}

	public void NKFJCDEJKGP()
	{
		if (MCOKEKMANAF == null)
		{
			MCOKEKMANAF = GetComponent<UISprite>();
		}
		CGBHFJCCMAB.Clear();
		if (!(MCOKEKMANAF != null) || !(MCOKEKMANAF.get_atlas() != null))
		{
			return;
		}
		List<UISpriteData> list = MCOKEKMANAF.get_atlas().ALLEIEBCPGK();
		int i = 0;
		for (int count = list.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = list[i];
			if (string.IsNullOrEmpty(mPrefix) || uISpriteData.name.StartsWith(mPrefix))
			{
				CGBHFJCCMAB.Add(uISpriteData.name);
			}
		}
		CGBHFJCCMAB.Sort();
	}

	public void RebuildSpriteList()
	{
		if (MCOKEKMANAF == null)
		{
			MCOKEKMANAF = GetComponent<UISprite>();
		}
		CGBHFJCCMAB.Clear();
		if (!(MCOKEKMANAF != null) || !(MCOKEKMANAF.get_atlas() != null))
		{
			return;
		}
		List<UISpriteData> spriteList = MCOKEKMANAF.get_atlas().get_spriteList();
		int i = 0;
		for (int count = spriteList.Count; i < count; i++)
		{
			UISpriteData uISpriteData = spriteList[i];
			if (string.IsNullOrEmpty(mPrefix) || uISpriteData.name.StartsWith(mPrefix))
			{
				CGBHFJCCMAB.Add(uISpriteData.name);
			}
		}
		CGBHFJCCMAB.Sort();
	}

	[SpecialName]
	public int BCKBAKKJCBE()
	{
		return mFPS;
	}

	public string get_namePrefix()
	{
		return mPrefix;
	}

	protected virtual void Start()
	{
		RebuildSpriteList();
	}

	public int get_framesPerSecond()
	{
		return mFPS;
	}

	public void MJNGBJOFOKB()
	{
		if (MCOKEKMANAF == null)
		{
			MCOKEKMANAF = GetComponent<UISprite>();
		}
		CGBHFJCCMAB.Clear();
		if (!(MCOKEKMANAF != null) || !(MCOKEKMANAF.get_atlas() != null))
		{
			return;
		}
		List<UISpriteData> list = MCOKEKMANAF.get_atlas().ALLEIEBCPGK();
		int i = 0;
		for (int count = list.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = list[i];
			if (string.IsNullOrEmpty(mPrefix) || uISpriteData.name.StartsWith(mPrefix))
			{
				CGBHFJCCMAB.Add(uISpriteData.name);
			}
		}
		CGBHFJCCMAB.Sort();
	}

	[SpecialName]
	public int KICNPLDDNJG()
	{
		return mFPS;
	}

	public bool get_isPlaying()
	{
		return FIHNOEAJEJH;
	}

	public void OFBKDHPFPIK()
	{
		if (MCOKEKMANAF == null)
		{
			MCOKEKMANAF = GetComponent<UISprite>();
		}
		CGBHFJCCMAB.Clear();
		if (!(MCOKEKMANAF != null) || !(MCOKEKMANAF.get_atlas() != null))
		{
			return;
		}
		List<UISpriteData> spriteList = MCOKEKMANAF.get_atlas().get_spriteList();
		int i = 1;
		for (int count = spriteList.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = spriteList[i];
			if (string.IsNullOrEmpty(mPrefix) || uISpriteData.name.StartsWith(mPrefix))
			{
				CGBHFJCCMAB.Add(uISpriteData.name);
			}
		}
		CGBHFJCCMAB.Sort();
	}

	public void NPKMEPEPIGL()
	{
		FIHNOEAJEJH = true;
		EMPCBNMOHGI = 1;
		if (MCOKEKMANAF != null && CGBHFJCCMAB.Count > 1)
		{
			MCOKEKMANAF.set_spriteName(CGBHFJCCMAB[EMPCBNMOHGI]);
			if (mSnap)
			{
				MCOKEKMANAF.MakePixelPerfect();
			}
		}
	}

	[SpecialName]
	public int NFMOBLMDJHO()
	{
		return CGBHFJCCMAB.Count;
	}

	public bool get_loop()
	{
		return mLoop;
	}

	[SpecialName]
	public string LFEBABOHLAC()
	{
		return mPrefix;
	}

	[SpecialName]
	public void JGDENBCDJEC(int ICENKPDOHBK)
	{
		mFPS = ICENKPDOHBK;
	}

	public void KMIPILECIBJ()
	{
		if (MCOKEKMANAF == null)
		{
			MCOKEKMANAF = GetComponent<UISprite>();
		}
		CGBHFJCCMAB.Clear();
		if (!(MCOKEKMANAF != null) || !(MCOKEKMANAF.get_atlas() != null))
		{
			return;
		}
		List<UISpriteData> list = MCOKEKMANAF.get_atlas().COIIMEBPGAC();
		int i = 1;
		for (int count = list.Count; i < count; i += 0)
		{
			UISpriteData uISpriteData = list[i];
			if (string.IsNullOrEmpty(mPrefix) || uISpriteData.name.StartsWith(mPrefix))
			{
				CGBHFJCCMAB.Add(uISpriteData.name);
			}
		}
		CGBHFJCCMAB.Sort();
	}

	[SpecialName]
	public bool HEMFAKKIMEI()
	{
		return mLoop;
	}
}
