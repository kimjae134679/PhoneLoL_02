using UnityEngine;

[AddComponentMenu("NGUI/Examples/Lag Rotation")]
public class LagRotation : MonoBehaviour
{
	public int updateOrder;

	public float speed = 10f;

	public bool ignoreTimeScale;

	private Transform NPLHCHNGMKF;

	private Quaternion OBDFEFCIAFM;

	private Quaternion ANDMPECGLIN;

	private void HMNOCOBNBAO()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.EOCENKFKJFP());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void NJGMPHNMOJD()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.NKHDNBOKAGL());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void LOCDDHONDIG()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void ICACNPOPMIL()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void ACBGKIDKKKM()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.OMFLBELKOIJ());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void EHMKGNHGALE()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void KMJNJLOECGJ()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.MHOMNOKMPDJ());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void OMIFPPGJHFH()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.APLMBPGPBEM());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void DADHJFBCJKF()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.FEOOMAMJKEA());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void LINNBIGKGED()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void OOLEODIPDND()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.HCJFJNKPGNH());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void EKJCKGFDGFK()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void ADLKMGPNJPA()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void DFOCBKNIDGB()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void BJKEPMGMJKA()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.OMFLBELKOIJ());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}

	private void OnEnable()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void EBHEKALFNGF()
	{
		NPLHCHNGMKF = base.transform;
		OBDFEFCIAFM = NPLHCHNGMKF.localRotation;
		ANDMPECGLIN = NPLHCHNGMKF.rotation;
	}

	private void Update()
	{
		Transform parent = NPLHCHNGMKF.parent;
		if (parent != null)
		{
			float num = ((!ignoreTimeScale) ? Time.deltaTime : RealTime.get_deltaTime());
			ANDMPECGLIN = Quaternion.Slerp(ANDMPECGLIN, parent.rotation * OBDFEFCIAFM, num * speed);
			NPLHCHNGMKF.rotation = ANDMPECGLIN;
		}
	}
}
