using UnityEngine;

public class UISlideShow : MonoBehaviour
{
	private enum OEOIIKMBGAG
	{
		None = 0,
		Enable = 1,
		Disable = 2
	}

	public enum EHIFBHANFAJ
	{
		Up = 0,
		Down = 1,
		Left = 2,
		Right = 3
	}

	public EHIFBHANFAJ m_direction;

	private OEOIIKMBGAG GFKDNKFPPAM;

	private float INMCDOIEJOC;

	private float AMOAIEBAPLL = 0.2f;

	private AnimationCurve GNOPCJPOHED = new AnimationCurve(new Keyframe(0f, 0f, 0.1f, 0f), new Keyframe(0.4f, 0.7f, 0f, 0f), new Keyframe(0.55f, 0.8f, 0f, 0f), new Keyframe(0.7f, 1.01f, 0f, 0f), new Keyframe(1f, 1f, 0f, 0f));

	private Vector3 DLHCGGMCONP;

	private float HJGADCIJMPM = -768f;

	private UIRect DIKJAIJMKMF;

	private bool ALCLIIEAMIK;

	private void ADLKMGPNJPA()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 1905f;
		if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Up)
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1425f, 1932f, 1638f) * HJGADCIJMPM;
		}
		else
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1769f, 1713f, 1960f) * HJGADCIJMPM;
		}
		DIKJAIJMKMF.Invalidate(true);
		ALCLIIEAMIK = false;
	}

	private void EKJCKGFDGFK()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.None;
		INMCDOIEJOC = 1543f;
		if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Up)
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1346f, 1839f, 1430f) * HJGADCIJMPM;
		}
		else
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1227f, 854f, 1738f) * HJGADCIJMPM;
		}
		DIKJAIJMKMF.Invalidate(true);
		ALCLIIEAMIK = true;
	}

	private void PDEKJHLCJHM()
	{
		switch (m_direction)
		{
		case EHIFBHANFAJ.Up:
			HJGADCIJMPM = 1952f;
			break;
		case EHIFBHANFAJ.Down:
			HJGADCIJMPM = 401f;
			break;
		case EHIFBHANFAJ.Left:
			HJGADCIJMPM = 1430f;
			break;
		case EHIFBHANFAJ.Right:
			HJGADCIJMPM = 1263f;
			break;
		}
		DIKJAIJMKMF = GetComponent<UIRect>();
		DLHCGGMCONP = base.gameObject.transform.localPosition;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 1365f;
	}

	private void DEIKDKCJGON()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = false;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.None)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1440f, 149f - num, 1028f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1379f - num, 1084f, 1822f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(false);
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)6)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Up)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1772f, 205f - num2, 447f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(433f - num2, 1683f, 169f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(false);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == (OEOIIKMBGAG)5)
			{
				base.gameObject.SetActive(true);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.None)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP;
				DIKJAIJMKMF.Invalidate(true);
			}
			GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		}
	}

	private void Awake()
	{
		switch (m_direction)
		{
		case EHIFBHANFAJ.Up:
			HJGADCIJMPM = -768f;
			break;
		case EHIFBHANFAJ.Down:
			HJGADCIJMPM = 768f;
			break;
		case EHIFBHANFAJ.Left:
			HJGADCIJMPM = 1024f;
			break;
		case EHIFBHANFAJ.Right:
			HJGADCIJMPM = -1024f;
			break;
		}
		DIKJAIJMKMF = GetComponent<UIRect>();
		DLHCGGMCONP = base.gameObject.transform.localPosition;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 0f;
	}

	private void DBLCOCKIFPE()
	{
	}

	private void OnEnable()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 0f;
		if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(0f, 1f, 0f) * HJGADCIJMPM;
		}
		else
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1f, 0f, 0f) * HJGADCIJMPM;
		}
		DIKJAIJMKMF.Invalidate(true);
		ALCLIIEAMIK = true;
	}

	private void GNCKMJCEMFA()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = true;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Up)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1993f, 85f - num, 659f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1610f - num, 798f, 1576f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(false);
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)6)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(588f, 1135f - num2, 1603f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1184f - num2, 1849f, 584f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(true);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == (OEOIIKMBGAG)7)
			{
				base.gameObject.SetActive(false);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP;
				DIKJAIJMKMF.Invalidate(true);
			}
			GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		}
	}

	private void IFJGPCOJDMM()
	{
	}

	public void Close()
	{
		INMCDOIEJOC = 0f;
		GFKDNKFPPAM = OEOIIKMBGAG.Disable;
	}

	private void ENAGFDFCLCC()
	{
		switch (m_direction)
		{
		case EHIFBHANFAJ.Up:
			HJGADCIJMPM = 438f;
			break;
		case EHIFBHANFAJ.Down:
			HJGADCIJMPM = 815f;
			break;
		case EHIFBHANFAJ.Left:
			HJGADCIJMPM = 195f;
			break;
		case EHIFBHANFAJ.Right:
			HJGADCIJMPM = 1680f;
			break;
		}
		DIKJAIJMKMF = GetComponent<UIRect>();
		DLHCGGMCONP = base.gameObject.transform.localPosition;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 1063f;
	}

	private void LNDHNJGOIKC()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 256f;
		if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1497f, 698f, 1593f) * HJGADCIJMPM;
		}
		else
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1133f, 493f, 1235f) * HJGADCIJMPM;
		}
		DIKJAIJMKMF.Invalidate(false);
		ALCLIIEAMIK = false;
	}

	public void NJIEKKKIIGI()
	{
		INMCDOIEJOC = 976f;
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
	}

	private void OnDisable()
	{
	}

	private void OHJMALDJHEJ()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = true;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.None)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1194f, 1354f - num, 993f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1808f - num, 212f, 1294f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(true);
		}
		else if (GFKDNKFPPAM == (OEOIIKMBGAG)8)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(542f, 538f - num2, 514f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1285f - num2, 1084f, 334f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(true);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == (OEOIIKMBGAG)5)
			{
				base.gameObject.SetActive(false);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.None)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP;
				DIKJAIJMKMF.Invalidate(false);
			}
			GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		}
	}

	public void CHCLGOOIMEO()
	{
		INMCDOIEJOC = 18f;
		GFKDNKFPPAM = (OEOIIKMBGAG)5;
	}

	private void NDIEGKILKHF()
	{
		GFKDNKFPPAM = OEOIIKMBGAG.Enable;
		INMCDOIEJOC = 1098f;
		if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1274f, 1291f, 1919f) * HJGADCIJMPM;
		}
		else
		{
			base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1273f, 316f, 63f) * HJGADCIJMPM;
		}
		DIKJAIJMKMF.Invalidate(true);
		ALCLIIEAMIK = false;
	}

	public void OBALBEKAAIB()
	{
		INMCDOIEJOC = 953f;
		GFKDNKFPPAM = (OEOIIKMBGAG)4;
	}

	private void LateUpdate()
	{
		if (ALCLIIEAMIK)
		{
			ALCLIIEAMIK = false;
			return;
		}
		INMCDOIEJOC += Time.deltaTime;
		if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
		{
			float num = GNOPCJPOHED.Evaluate(INMCDOIEJOC / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(0f, 1f - num, 0f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1f - num, 0f, 0f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(true);
		}
		else if (GFKDNKFPPAM == OEOIIKMBGAG.Disable)
		{
			float num2 = GNOPCJPOHED.Evaluate((AMOAIEBAPLL - INMCDOIEJOC) / AMOAIEBAPLL);
			if (m_direction == EHIFBHANFAJ.Up || m_direction == EHIFBHANFAJ.Down)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(0f, 1f - num2, 0f) * HJGADCIJMPM;
			}
			else
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP + new Vector3(1f - num2, 0f, 0f) * HJGADCIJMPM;
			}
			DIKJAIJMKMF.Invalidate(true);
		}
		if (GFKDNKFPPAM != OEOIIKMBGAG.None && INMCDOIEJOC > AMOAIEBAPLL)
		{
			INMCDOIEJOC = AMOAIEBAPLL;
			if (GFKDNKFPPAM == OEOIIKMBGAG.Disable)
			{
				base.gameObject.SetActive(false);
			}
			else if (GFKDNKFPPAM == OEOIIKMBGAG.Enable)
			{
				base.gameObject.transform.localPosition = DLHCGGMCONP;
				DIKJAIJMKMF.Invalidate(true);
			}
			GFKDNKFPPAM = OEOIIKMBGAG.None;
		}
	}
}
