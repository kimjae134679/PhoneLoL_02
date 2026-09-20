using UnityEngine;

[AddComponentMenu("NGUI/Examples/Lag Position")]
public class LagPosition : MonoBehaviour
{
	public int updateOrder;

	public Vector3 speed = new Vector3(10f, 10f, 10f);

	public bool ignoreTimeScale;

	private Transform NPLHCHNGMKF;

	private Vector3 OBDFEFCIAFM;

	private Vector3 ANDMPECGLIN;

	private void FJFFMANPDJD()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.FEOOMAMJKEA());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void MADCDCNEGBO()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void DOINNKBDEMD()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.APLMBPGPBEM());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void EBHEKALFNGF()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void DNBDGBJNCBP()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.APLMBPGPBEM());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void NJGMPHNMOJD()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.OMFLBELKOIJ());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void LOCDDHONDIG()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void GNOAPFAKBIN()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void ODHEBKCPBPB()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.get_deltaTime());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void MLOKLGPGKMO()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.OMFLBELKOIJ());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void GDKGBNKCGHO()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.FEOOMAMJKEA());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void EKGHGFIKAAE()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.NKHDNBOKAGL());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void OnEnable()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void EKJCKGFDGFK()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void NDIEGKILKHF()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void OMIFPPGJHFH()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.DCKJMALGFHC());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void PDEMNFLEKEA()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void Update()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.get_deltaTime());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void FBOICFJHJJE()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.HCJFJNKPGNH());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}

	private void DFOCBKNIDGB()
	{
		NPLHCHNGMKF = base.transform;
		ANDMPECGLIN = NPLHCHNGMKF.position;
		OBDFEFCIAFM = NPLHCHNGMKF.localPosition;
	}

	private void OOLEODIPDND()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.OMFLBELKOIJ());
			Vector3 vector = parent.position + parent.rotation * OBDFEFCIAFM;
			ANDMPECGLIN.x = Mathf.Lerp(ANDMPECGLIN.x, vector.x, Mathf.Clamp01(num * speed.x));
			ANDMPECGLIN.y = Mathf.Lerp(ANDMPECGLIN.y, vector.y, Mathf.Clamp01(num * speed.y));
			ANDMPECGLIN.z = Mathf.Lerp(ANDMPECGLIN.z, vector.z, Mathf.Clamp01(num * speed.z));
			NPLHCHNGMKF.position = ANDMPECGLIN;
		}
	}
}
