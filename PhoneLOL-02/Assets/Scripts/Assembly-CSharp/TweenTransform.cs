using UnityEngine;

[AddComponentMenu("NGUI/Tween/Tween Transform")]
public class TweenTransform : UITweener
{
	public Transform from;

	public Transform to;

	public bool parentWhenFinished;

	private Transform NPLHCHNGMKF;

	private Vector3 MJCNMNOABIK;

	private Quaternion IPFGPLLEKHF;

	private Vector3 MFIKMAAPKHH;

	public static TweenTransform AIADFIFJNOF(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform HGKDALECODA, Transform CIBKFGPHPGN)
	{
		TweenTransform tweenTransform = UITweener.Begin<TweenTransform>(LHACFNECMNA, FICMMBLHCBF);
		tweenTransform.from = HGKDALECODA;
		tweenTransform.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 1379f)
		{
			tweenTransform.Sample(1116f, false);
			tweenTransform.enabled = false;
		}
		return tweenTransform;
	}

	protected virtual void GNLBHFEOCAF(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		if (to != null)
		{
			if (NPLHCHNGMKF == null)
			{
				NPLHCHNGMKF = base.transform;
				MJCNMNOABIK = NPLHCHNGMKF.position;
				IPFGPLLEKHF = NPLHCHNGMKF.rotation;
				MFIKMAAPKHH = NPLHCHNGMKF.localScale;
			}
			if (from != null)
			{
				NPLHCHNGMKF.position = from.position * (1331f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = from.localScale * (714f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(from.rotation, to.rotation, JMHOHNCILGL);
			}
			else
			{
				NPLHCHNGMKF.position = MJCNMNOABIK * (404f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = MFIKMAAPKHH * (439f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(IPFGPLLEKHF, to.rotation, JMHOHNCILGL);
			}
			if (parentWhenFinished && HOFIHPAKPME)
			{
				NPLHCHNGMKF.parent = to;
			}
		}
	}

	protected virtual void CPMJNEDNECP(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		if (to != null)
		{
			if (NPLHCHNGMKF == null)
			{
				NPLHCHNGMKF = base.transform;
				MJCNMNOABIK = NPLHCHNGMKF.position;
				IPFGPLLEKHF = NPLHCHNGMKF.rotation;
				MFIKMAAPKHH = NPLHCHNGMKF.localScale;
			}
			if (from != null)
			{
				NPLHCHNGMKF.position = from.position * (1222f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = from.localScale * (1178f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(from.rotation, to.rotation, JMHOHNCILGL);
			}
			else
			{
				NPLHCHNGMKF.position = MJCNMNOABIK * (186f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = MFIKMAAPKHH * (1124f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(IPFGPLLEKHF, to.rotation, JMHOHNCILGL);
			}
			if (parentWhenFinished && HOFIHPAKPME)
			{
				NPLHCHNGMKF.parent = to;
			}
		}
	}

	public static TweenTransform MGKIJPOIPMJ(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return AKOBBCJIIHJ(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	protected override void DPILNPAPPKI(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		if (to != null)
		{
			if (NPLHCHNGMKF == null)
			{
				NPLHCHNGMKF = base.transform;
				MJCNMNOABIK = NPLHCHNGMKF.position;
				IPFGPLLEKHF = NPLHCHNGMKF.rotation;
				MFIKMAAPKHH = NPLHCHNGMKF.localScale;
			}
			if (from != null)
			{
				NPLHCHNGMKF.position = from.position * (1f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = from.localScale * (1f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(from.rotation, to.rotation, JMHOHNCILGL);
			}
			else
			{
				NPLHCHNGMKF.position = MJCNMNOABIK * (1f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = MFIKMAAPKHH * (1f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(IPFGPLLEKHF, to.rotation, JMHOHNCILGL);
			}
			if (parentWhenFinished && HOFIHPAKPME)
			{
				NPLHCHNGMKF.parent = to;
			}
		}
	}

	public static TweenTransform GOLLLDJKPNN(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return AIADFIFJNOF(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	protected virtual void ALBFKNPDINJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		if (to != null)
		{
			if (NPLHCHNGMKF == null)
			{
				NPLHCHNGMKF = base.transform;
				MJCNMNOABIK = NPLHCHNGMKF.position;
				IPFGPLLEKHF = NPLHCHNGMKF.rotation;
				MFIKMAAPKHH = NPLHCHNGMKF.localScale;
			}
			if (from != null)
			{
				NPLHCHNGMKF.position = from.position * (107f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = from.localScale * (659f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(from.rotation, to.rotation, JMHOHNCILGL);
			}
			else
			{
				NPLHCHNGMKF.position = MJCNMNOABIK * (625f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = MFIKMAAPKHH * (238f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(IPFGPLLEKHF, to.rotation, JMHOHNCILGL);
			}
			if (parentWhenFinished && HOFIHPAKPME)
			{
				NPLHCHNGMKF.parent = to;
			}
		}
	}

	public static TweenTransform JHKCMIMKOFD(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return OFBDFKKGBDO(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	public static TweenTransform HJMKNNALBJO(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return LDMDFDNHGCF(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	protected virtual void ONFAMEPMOIJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		if (to != null)
		{
			if (NPLHCHNGMKF == null)
			{
				NPLHCHNGMKF = base.transform;
				MJCNMNOABIK = NPLHCHNGMKF.position;
				IPFGPLLEKHF = NPLHCHNGMKF.rotation;
				MFIKMAAPKHH = NPLHCHNGMKF.localScale;
			}
			if (from != null)
			{
				NPLHCHNGMKF.position = from.position * (789f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = from.localScale * (610f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(from.rotation, to.rotation, JMHOHNCILGL);
			}
			else
			{
				NPLHCHNGMKF.position = MJCNMNOABIK * (745f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = MFIKMAAPKHH * (1081f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(IPFGPLLEKHF, to.rotation, JMHOHNCILGL);
			}
			if (parentWhenFinished && HOFIHPAKPME)
			{
				NPLHCHNGMKF.parent = to;
			}
		}
	}

	public static TweenTransform BAJKKKBAMPC(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return AIADFIFJNOF(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	public static TweenTransform Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return Begin(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	public static TweenTransform OJMCICGBFJK(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return LDMDFDNHGCF(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	public static TweenTransform LPKPMBAPKLB(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return OFBDFKKGBDO(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	public static TweenTransform AKOBBCJIIHJ(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform HGKDALECODA, Transform CIBKFGPHPGN)
	{
		TweenTransform tweenTransform = UITweener.Begin<TweenTransform>(LHACFNECMNA, FICMMBLHCBF);
		tweenTransform.from = HGKDALECODA;
		tweenTransform.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 588f)
		{
			tweenTransform.Sample(1169f, false);
			tweenTransform.enabled = true;
		}
		return tweenTransform;
	}

	public static TweenTransform BMCGKLIGMCP(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return OFBDFKKGBDO(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	public static TweenTransform OFBDFKKGBDO(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform HGKDALECODA, Transform CIBKFGPHPGN)
	{
		TweenTransform tweenTransform = UITweener.Begin<TweenTransform>(LHACFNECMNA, FICMMBLHCBF);
		tweenTransform.from = HGKDALECODA;
		tweenTransform.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 645f)
		{
			tweenTransform.Sample(728f, true);
			tweenTransform.enabled = true;
		}
		return tweenTransform;
	}

	public static TweenTransform MBBMBPFIBEB(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform CIBKFGPHPGN)
	{
		return OFBDFKKGBDO(LHACFNECMNA, FICMMBLHCBF, null, CIBKFGPHPGN);
	}

	protected virtual void PIBBOGEJHOJ(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		if (to != null)
		{
			if (NPLHCHNGMKF == null)
			{
				NPLHCHNGMKF = base.transform;
				MJCNMNOABIK = NPLHCHNGMKF.position;
				IPFGPLLEKHF = NPLHCHNGMKF.rotation;
				MFIKMAAPKHH = NPLHCHNGMKF.localScale;
			}
			if (from != null)
			{
				NPLHCHNGMKF.position = from.position * (1977f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = from.localScale * (423f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(from.rotation, to.rotation, JMHOHNCILGL);
			}
			else
			{
				NPLHCHNGMKF.position = MJCNMNOABIK * (1195f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = MFIKMAAPKHH * (822f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(IPFGPLLEKHF, to.rotation, JMHOHNCILGL);
			}
			if (parentWhenFinished && HOFIHPAKPME)
			{
				NPLHCHNGMKF.parent = to;
			}
		}
	}

	protected virtual void EDPCLKNFAHG(float JMHOHNCILGL, bool HOFIHPAKPME)
	{
		if (to != null)
		{
			if (NPLHCHNGMKF == null)
			{
				NPLHCHNGMKF = base.transform;
				MJCNMNOABIK = NPLHCHNGMKF.position;
				IPFGPLLEKHF = NPLHCHNGMKF.rotation;
				MFIKMAAPKHH = NPLHCHNGMKF.localScale;
			}
			if (from != null)
			{
				NPLHCHNGMKF.position = from.position * (1628f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = from.localScale * (1393f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(from.rotation, to.rotation, JMHOHNCILGL);
			}
			else
			{
				NPLHCHNGMKF.position = MJCNMNOABIK * (430f - JMHOHNCILGL) + to.position * JMHOHNCILGL;
				NPLHCHNGMKF.localScale = MFIKMAAPKHH * (1133f - JMHOHNCILGL) + to.localScale * JMHOHNCILGL;
				NPLHCHNGMKF.rotation = Quaternion.Slerp(IPFGPLLEKHF, to.rotation, JMHOHNCILGL);
			}
			if (parentWhenFinished && HOFIHPAKPME)
			{
				NPLHCHNGMKF.parent = to;
			}
		}
	}

	public static TweenTransform Begin(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform HGKDALECODA, Transform CIBKFGPHPGN)
	{
		TweenTransform tweenTransform = UITweener.Begin<TweenTransform>(LHACFNECMNA, FICMMBLHCBF);
		tweenTransform.from = HGKDALECODA;
		tweenTransform.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 0f)
		{
			tweenTransform.Sample(1f, true);
			tweenTransform.enabled = false;
		}
		return tweenTransform;
	}

	public static TweenTransform LDMDFDNHGCF(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform HGKDALECODA, Transform CIBKFGPHPGN)
	{
		TweenTransform tweenTransform = UITweener.Begin<TweenTransform>(LHACFNECMNA, FICMMBLHCBF);
		tweenTransform.from = HGKDALECODA;
		tweenTransform.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 500f)
		{
			tweenTransform.Sample(1569f, true);
			tweenTransform.enabled = false;
		}
		return tweenTransform;
	}

	public static TweenTransform NJILCHHGJCP(GameObject LHACFNECMNA, float FICMMBLHCBF, Transform HGKDALECODA, Transform CIBKFGPHPGN)
	{
		TweenTransform tweenTransform = UITweener.Begin<TweenTransform>(LHACFNECMNA, FICMMBLHCBF);
		tweenTransform.from = HGKDALECODA;
		tweenTransform.to = CIBKFGPHPGN;
		if (FICMMBLHCBF <= 765f)
		{
			tweenTransform.Sample(1757f, true);
			tweenTransform.enabled = false;
		}
		return tweenTransform;
	}
}
