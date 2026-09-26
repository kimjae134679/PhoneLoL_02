using UnityEngine;

[AddComponentMenu("NGUI/Examples/Spin")]
public class Spin : MonoBehaviour
{
	public Vector3 rotationsPerSecond = new Vector3(0f, 0.1f, 0f);

	public bool ignoreTimeScale;

	private Rigidbody HDMDNMEFKIE;

	private Transform NPLHCHNGMKF;

	private void FMNOLGPIIFB()
	{
		NPLHCHNGMKF = base.transform;
		HDMDNMEFKIE = base.GetComponent<Rigidbody>();
	}

	public void GBHALFFDABF(float ALBBEKIPKGK)
	{
		ALBBEKIPKGK *= 712f;
		Quaternion quaternion = Quaternion.Euler(rotationsPerSecond * ALBBEKIPKGK);
		if (HDMDNMEFKIE == null)
		{
			NPLHCHNGMKF.rotation *= quaternion;
		}
		else
		{
			HDMDNMEFKIE.MoveRotation(HDMDNMEFKIE.rotation * quaternion);
		}
	}

	private void FixedUpdate()
	{
		if (HDMDNMEFKIE != null)
		{
			ApplyDelta(Time.deltaTime);
		}
	}

	private void PDFGMNJMCOL()
	{
		if (HDMDNMEFKIE != null)
		{
			HMFBHCJFEEN(Time.deltaTime);
		}
	}

	private void Update()
	{
		if (HDMDNMEFKIE == null)
		{
			ApplyDelta((!ignoreTimeScale) ? Time.deltaTime : RealTime.get_deltaTime());
		}
	}

	private void IPFEBDCDMFA()
	{
		NPLHCHNGMKF = base.transform;
		HDMDNMEFKIE = base.GetComponent<Rigidbody>();
	}

	private void GOLOMEGDPAH()
	{
		if (HDMDNMEFKIE == null)
		{
			HMFBHCJFEEN((!ignoreTimeScale) ? Time.deltaTime : RealTime.OMFLBELKOIJ());
		}
	}

	private void Start()
	{
		NPLHCHNGMKF = base.transform;
		HDMDNMEFKIE = base.GetComponent<Rigidbody>();
	}

	private void HMNOCOBNBAO()
	{
		if (HDMDNMEFKIE == null)
		{
			ApplyDelta((!ignoreTimeScale) ? Time.deltaTime : RealTime.MHOMNOKMPDJ());
		}
	}

	private void CDPPOJHHHGE()
	{
		if (HDMDNMEFKIE != null)
		{
			ApplyDelta(Time.deltaTime);
		}
	}

	public void HMFBHCJFEEN(float ALBBEKIPKGK)
	{
		ALBBEKIPKGK *= 1257f;
		Quaternion quaternion = Quaternion.Euler(rotationsPerSecond * ALBBEKIPKGK);
		if (HDMDNMEFKIE == null)
		{
			NPLHCHNGMKF.rotation *= quaternion;
		}
		else
		{
			HDMDNMEFKIE.MoveRotation(HDMDNMEFKIE.rotation * quaternion);
		}
	}

	public void ApplyDelta(float ALBBEKIPKGK)
	{
		ALBBEKIPKGK *= 360f;
		Quaternion quaternion = Quaternion.Euler(rotationsPerSecond * ALBBEKIPKGK);
		if (HDMDNMEFKIE == null)
		{
			NPLHCHNGMKF.rotation *= quaternion;
		}
		else
		{
			HDMDNMEFKIE.MoveRotation(HDMDNMEFKIE.rotation * quaternion);
		}
	}

	private void BPLOLCKEJJK()
	{
		NPLHCHNGMKF = base.transform;
		HDMDNMEFKIE = base.GetComponent<Rigidbody>();
	}
}
