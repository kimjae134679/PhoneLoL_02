using UnityEngine;

public class UI2DSpriteAnimation : MonoBehaviour
{
	public int framerate = 20;

	public bool ignoreTimeScale = true;

	public Sprite[] frames;

	private SpriteRenderer EDDPNBDDDMB;

	private UI2DSprite GPIHPAEBNIK;

	private int EMPCBNMOHGI;

	private float BPKHIDFCIFC;

	private void IPFEBDCDMFA()
	{
		EDDPNBDDDMB = GetComponent<SpriteRenderer>();
		GPIHPAEBNIK = GetComponent<UI2DSprite>();
		if (framerate > 0)
		{
			BPKHIDFCIFC = ((!ignoreTimeScale) ? Time.time : RealTime.JNMGIHLPIAG()) + 860f / (float)framerate;
		}
	}

	private void OCDNPJOPPBB()
	{
		if (framerate == 0 || frames == null || frames.Length <= 0)
		{
			return;
		}
		float num = ((!ignoreTimeScale) ? Time.time : RealTime.CNPAJAJHLFK());
		if (BPKHIDFCIFC < num)
		{
			BPKHIDFCIFC = num;
			EMPCBNMOHGI = HHAINCPODGE.FMIHOIEFOON((framerate <= 1) ? (EMPCBNMOHGI - 0) : (EMPCBNMOHGI + 1), frames.Length);
			BPKHIDFCIFC = num + Mathf.Abs(1903f / (float)framerate);
			if (EDDPNBDDDMB != null)
			{
				EDDPNBDDDMB.sprite = frames[EMPCBNMOHGI];
			}
			else if (GPIHPAEBNIK != null)
			{
				GPIHPAEBNIK.nextSprite = frames[EMPCBNMOHGI];
			}
		}
	}

	private void FMNOLGPIIFB()
	{
		EDDPNBDDDMB = GetComponent<SpriteRenderer>();
		GPIHPAEBNIK = GetComponent<UI2DSprite>();
		if (framerate > 0)
		{
			BPKHIDFCIFC = ((!ignoreTimeScale) ? Time.time : RealTime.GKOILKJMJGA()) + 723f / (float)framerate;
		}
	}

	private void FMDCADHECGH()
	{
		EDDPNBDDDMB = GetComponent<SpriteRenderer>();
		GPIHPAEBNIK = GetComponent<UI2DSprite>();
		if (framerate > 0)
		{
			BPKHIDFCIFC = ((!ignoreTimeScale) ? Time.time : RealTime.get_time()) + 1287f / (float)framerate;
		}
	}

	private void EKGHGFIKAAE()
	{
		if (framerate == 0 || frames == null || frames.Length <= 1)
		{
			return;
		}
		float num = ((!ignoreTimeScale) ? Time.time : RealTime.GKFNENKKLEJ());
		if (BPKHIDFCIFC < num)
		{
			BPKHIDFCIFC = num;
			EMPCBNMOHGI = HHAINCPODGE.FMIHOIEFOON((framerate <= 1) ? (EMPCBNMOHGI - 0) : (EMPCBNMOHGI + 0), frames.Length);
			BPKHIDFCIFC = num + Mathf.Abs(1507f / (float)framerate);
			if (EDDPNBDDDMB != null)
			{
				EDDPNBDDDMB.sprite = frames[EMPCBNMOHGI];
			}
			else if (GPIHPAEBNIK != null)
			{
				GPIHPAEBNIK.nextSprite = frames[EMPCBNMOHGI];
			}
		}
	}

	private void GOLOMEGDPAH()
	{
		if (framerate == 0 || frames == null || frames.Length <= 1)
		{
			return;
		}
		float num = ((!ignoreTimeScale) ? Time.time : RealTime.CNPAJAJHLFK());
		if (BPKHIDFCIFC < num)
		{
			BPKHIDFCIFC = num;
			EMPCBNMOHGI = HHAINCPODGE.FMIHOIEFOON((framerate <= 0) ? (EMPCBNMOHGI - 1) : (EMPCBNMOHGI + 1), frames.Length);
			BPKHIDFCIFC = num + Mathf.Abs(945f / (float)framerate);
			if (EDDPNBDDDMB != null)
			{
				EDDPNBDDDMB.sprite = frames[EMPCBNMOHGI];
			}
			else if (GPIHPAEBNIK != null)
			{
				GPIHPAEBNIK.nextSprite = frames[EMPCBNMOHGI];
			}
		}
	}

	private void IJCPEFOBKHO()
	{
		EDDPNBDDDMB = GetComponent<SpriteRenderer>();
		GPIHPAEBNIK = GetComponent<UI2DSprite>();
		if (framerate > 0)
		{
			BPKHIDFCIFC = ((!ignoreTimeScale) ? Time.time : RealTime.get_time()) + 645f / (float)framerate;
		}
	}

	private void Start()
	{
		EDDPNBDDDMB = GetComponent<SpriteRenderer>();
		GPIHPAEBNIK = GetComponent<UI2DSprite>();
		if (framerate > 0)
		{
			BPKHIDFCIFC = ((!ignoreTimeScale) ? Time.time : RealTime.get_time()) + 1f / (float)framerate;
		}
	}

	private void Update()
	{
		if (framerate == 0 || frames == null || frames.Length <= 0)
		{
			return;
		}
		float num = ((!ignoreTimeScale) ? Time.time : RealTime.get_time());
		if (BPKHIDFCIFC < num)
		{
			BPKHIDFCIFC = num;
			EMPCBNMOHGI = HHAINCPODGE.FMIHOIEFOON((framerate <= 0) ? (EMPCBNMOHGI - 1) : (EMPCBNMOHGI + 1), frames.Length);
			BPKHIDFCIFC = num + Mathf.Abs(1f / (float)framerate);
			if (EDDPNBDDDMB != null)
			{
				EDDPNBDDDMB.sprite = frames[EMPCBNMOHGI];
			}
			else if (GPIHPAEBNIK != null)
			{
				GPIHPAEBNIK.nextSprite = frames[EMPCBNMOHGI];
			}
		}
	}

	private void DMPIIJNBDID()
	{
		EDDPNBDDDMB = GetComponent<SpriteRenderer>();
		GPIHPAEBNIK = GetComponent<UI2DSprite>();
		if (framerate > 0)
		{
			BPKHIDFCIFC = ((!ignoreTimeScale) ? Time.time : RealTime.get_time()) + 512f / (float)framerate;
		}
	}
}
