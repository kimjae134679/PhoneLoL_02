using UnityEngine;

[AddComponentMenu("NGUI/Tween/Spring Position")]
public class SpringPosition : MonoBehaviour
{
	public delegate void EKMEENIBKJB();

	public static SpringPosition current;

	public Vector3 target = Vector3.zero;

	public float strength = 10f;

	public bool worldSpace;

	public bool ignoreTimeScale;

	public bool updateScrollView;

	public EKMEENIBKJB onFinished;

	[HideInInspector]
	[SerializeField]
	private GameObject eventReceiver;

	[HideInInspector]
	[SerializeField]
	public string callWhenFinished;

	private Transform NPLHCHNGMKF;

	private float LOBCOELEFJH;

	private UIScrollView LGIGKAEAJKE;

	private void KEOHIGNNDFG()
	{
		current = this;
		if (onFinished != null)
		{
			onFinished();
		}
		if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
		{
			eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		current = null;
	}

	public static SpringPosition Begin(GameObject LHACFNECMNA, Vector3 HEPNHCEIFMO, float NKNAABDPFBC)
	{
		SpringPosition springPosition = LHACFNECMNA.GetComponent<SpringPosition>();
		if (springPosition == null)
		{
			springPosition = LHACFNECMNA.AddComponent<SpringPosition>();
		}
		springPosition.target = HEPNHCEIFMO;
		springPosition.strength = NKNAABDPFBC;
		springPosition.onFinished = null;
		if (!springPosition.enabled)
		{
			springPosition.LOBCOELEFJH = 0f;
			springPosition.enabled = true;
		}
		return springPosition;
	}

	private void GKNMGIONEKK()
	{
		NPLHCHNGMKF = base.transform;
		if (updateScrollView)
		{
			LGIGKAEAJKE = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(base.gameObject);
		}
	}

	private void Update()
	{
		float oJAOJFBJGAH = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.get_deltaTime());
		if (worldSpace)
		{
			if (LOBCOELEFJH == 0f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.position).sqrMagnitude * 0.001f;
			}
			NPLHCHNGMKF.position = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.position, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.position).sqrMagnitude)
			{
				NPLHCHNGMKF.position = target;
				KEOHIGNNDFG();
				base.enabled = false;
			}
		}
		else
		{
			if (LOBCOELEFJH == 0f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.localPosition).sqrMagnitude * 1E-05f;
			}
			NPLHCHNGMKF.localPosition = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.localPosition).sqrMagnitude)
			{
				NPLHCHNGMKF.localPosition = target;
				KEOHIGNNDFG();
				base.enabled = false;
			}
		}
		if (LGIGKAEAJKE != null)
		{
			LGIGKAEAJKE.UpdateScrollbars(true);
		}
	}

	private void JBCMLAMFBDF()
	{
		current = this;
		if (onFinished != null)
		{
			onFinished();
		}
		if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
		{
			eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		current = null;
	}

	private void DBODMMHCHEM()
	{
		current = this;
		if (onFinished != null)
		{
			onFinished();
		}
		if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
		{
			eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.RequireReceiver);
		}
		current = null;
	}

	private void Start()
	{
		NPLHCHNGMKF = base.transform;
		if (updateScrollView)
		{
			LGIGKAEAJKE = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(base.gameObject);
		}
	}

	private void DNBDGBJNCBP()
	{
		float oJAOJFBJGAH = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.APLMBPGPBEM());
		if (worldSpace)
		{
			if (LOBCOELEFJH == 834f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.position).sqrMagnitude * 14f;
			}
			NPLHCHNGMKF.position = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.position, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.position).sqrMagnitude)
			{
				NPLHCHNGMKF.position = target;
				KEOHIGNNDFG();
				base.enabled = false;
			}
		}
		else
		{
			if (LOBCOELEFJH == 801f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.localPosition).sqrMagnitude * 31f;
			}
			NPLHCHNGMKF.localPosition = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.localPosition).sqrMagnitude)
			{
				NPLHCHNGMKF.localPosition = target;
				DBODMMHCHEM();
				base.enabled = false;
			}
		}
		if (LGIGKAEAJKE != null)
		{
			LGIGKAEAJKE.UpdateScrollbars(false);
		}
	}

	private void BPLOLCKEJJK()
	{
		NPLHCHNGMKF = base.transform;
		if (updateScrollView)
		{
			LGIGKAEAJKE = NLDABIMKKMP.ANPDHFFNJFD<UIScrollView>(base.gameObject);
		}
	}

	private void LKBCLDEBJDP()
	{
		current = this;
		if (onFinished != null)
		{
			onFinished();
		}
		if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
		{
			eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		current = null;
	}

	private void CGHCMHIOOKF()
	{
		current = this;
		if (onFinished != null)
		{
			onFinished();
		}
		if (eventReceiver != null && !string.IsNullOrEmpty(callWhenFinished))
		{
			eventReceiver.SendMessage(callWhenFinished, this, SendMessageOptions.DontRequireReceiver);
		}
		current = null;
	}

	private void MLOKLGPGKMO()
	{
		float oJAOJFBJGAH = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.DCKJMALGFHC());
		if (worldSpace)
		{
			if (LOBCOELEFJH == 1403f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.position).sqrMagnitude * 748f;
			}
			NPLHCHNGMKF.position = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.position, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.position).sqrMagnitude)
			{
				NPLHCHNGMKF.position = target;
				CGHCMHIOOKF();
				base.enabled = true;
			}
		}
		else
		{
			if (LOBCOELEFJH == 126f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.localPosition).sqrMagnitude * 1550f;
			}
			NPLHCHNGMKF.localPosition = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.localPosition).sqrMagnitude)
			{
				NPLHCHNGMKF.localPosition = target;
				CGHCMHIOOKF();
				base.enabled = false;
			}
		}
		if (LGIGKAEAJKE != null)
		{
			LGIGKAEAJKE.UpdateScrollbars(true);
		}
	}

	private void EKGHGFIKAAE()
	{
		float oJAOJFBJGAH = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.DCKJMALGFHC());
		if (worldSpace)
		{
			if (LOBCOELEFJH == 1775f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.position).sqrMagnitude * 1040f;
			}
			NPLHCHNGMKF.position = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.position, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.position).sqrMagnitude)
			{
				NPLHCHNGMKF.position = target;
				JBCMLAMFBDF();
				base.enabled = true;
			}
		}
		else
		{
			if (LOBCOELEFJH == 687f)
			{
				LOBCOELEFJH = (target - NPLHCHNGMKF.localPosition).sqrMagnitude * 912f;
			}
			NPLHCHNGMKF.localPosition = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
			if (LOBCOELEFJH >= (target - NPLHCHNGMKF.localPosition).sqrMagnitude)
			{
				NPLHCHNGMKF.localPosition = target;
				CGHCMHIOOKF();
				base.enabled = true;
			}
		}
		if (LGIGKAEAJKE != null)
		{
			LGIGKAEAJKE.UpdateScrollbars(true);
		}
	}
}
