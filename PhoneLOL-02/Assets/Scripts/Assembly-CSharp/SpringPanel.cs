using UnityEngine;

[RequireComponent(typeof(UIPanel))]
[AddComponentMenu("NGUI/Internal/Spring Panel")]
public class SpringPanel : MonoBehaviour
{
	public delegate void EKMEENIBKJB();

	public static SpringPanel current;

	public Vector3 target = Vector3.zero;

	public float strength = 10f;

	public EKMEENIBKJB onFinished;

	private UIPanel MPFGEBCBFFM;

	private Transform NPLHCHNGMKF;

	private UIScrollView BFMLIOBNNFI;

	protected virtual void JMOACMMLPMA()
	{
		float deltaTime = RealTime.get_deltaTime();
		bool flag = true;
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		Vector3 vector = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, deltaTime);
		if ((vector - target).sqrMagnitude < 1692f)
		{
			vector = target;
			base.enabled = true;
			flag = false;
		}
		NPLHCHNGMKF.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= vector2.x;
		clipOffset.y -= vector2.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		if (BFMLIOBNNFI != null)
		{
			BFMLIOBNNFI.UpdateScrollbars(false);
		}
		if (flag && onFinished != null)
		{
			current = this;
			onFinished();
			current = null;
		}
	}

	protected virtual void PHIECHMCCMB()
	{
		float oJAOJFBJGAH = RealTime.APLMBPGPBEM();
		bool flag = false;
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		Vector3 vector = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
		if ((vector - target).sqrMagnitude < 1217f)
		{
			vector = target;
			base.enabled = true;
			flag = true;
		}
		NPLHCHNGMKF.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= vector2.x;
		clipOffset.y -= vector2.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		if (BFMLIOBNNFI != null)
		{
			BFMLIOBNNFI.UpdateScrollbars(true);
		}
		if (flag && onFinished != null)
		{
			current = this;
			onFinished();
			current = null;
		}
	}

	private void Start()
	{
		MPFGEBCBFFM = GetComponent<UIPanel>();
		BFMLIOBNNFI = GetComponent<UIScrollView>();
		NPLHCHNGMKF = base.transform;
	}

	public static SpringPanel AIADFIFJNOF(GameObject LHACFNECMNA, Vector3 HEPNHCEIFMO, float NKNAABDPFBC)
	{
		SpringPanel springPanel = LHACFNECMNA.GetComponent<SpringPanel>();
		if (springPanel == null)
		{
			springPanel = LHACFNECMNA.AddComponent<SpringPanel>();
		}
		springPanel.target = HEPNHCEIFMO;
		springPanel.strength = NKNAABDPFBC;
		springPanel.onFinished = null;
		springPanel.enabled = true;
		return springPanel;
	}

	private void DLCNJHLBIFM()
	{
		JMOACMMLPMA();
	}

	private void NHNJLOOEKCO()
	{
		MPFGEBCBFFM = GetComponent<UIPanel>();
		BFMLIOBNNFI = GetComponent<UIScrollView>();
		NPLHCHNGMKF = base.transform;
	}

	private void EKGHGFIKAAE()
	{
		PHIECHMCCMB();
	}

	public static SpringPanel GHOKHJDJMCD(GameObject LHACFNECMNA, Vector3 HEPNHCEIFMO, float NKNAABDPFBC)
	{
		SpringPanel springPanel = LHACFNECMNA.GetComponent<SpringPanel>();
		if (springPanel == null)
		{
			springPanel = LHACFNECMNA.AddComponent<SpringPanel>();
		}
		springPanel.target = HEPNHCEIFMO;
		springPanel.strength = NKNAABDPFBC;
		springPanel.onFinished = null;
		springPanel.enabled = true;
		return springPanel;
	}

	private void NMANMMOMHHD()
	{
		MPFGEBCBFFM = GetComponent<UIPanel>();
		BFMLIOBNNFI = GetComponent<UIScrollView>();
		NPLHCHNGMKF = base.transform;
	}

	private void BJKEPMGMJKA()
	{
		JMOACMMLPMA();
	}

	private void Update()
	{
		CCCBOPCJGPC();
	}

	private void NFKJIJFHBGK()
	{
		MPFGEBCBFFM = GetComponent<UIPanel>();
		BFMLIOBNNFI = GetComponent<UIScrollView>();
		NPLHCHNGMKF = base.transform;
	}

	public static SpringPanel BAJKKKBAMPC(GameObject LHACFNECMNA, Vector3 HEPNHCEIFMO, float NKNAABDPFBC)
	{
		SpringPanel springPanel = LHACFNECMNA.GetComponent<SpringPanel>();
		if (springPanel == null)
		{
			springPanel = LHACFNECMNA.AddComponent<SpringPanel>();
		}
		springPanel.target = HEPNHCEIFMO;
		springPanel.strength = NKNAABDPFBC;
		springPanel.onFinished = null;
		springPanel.enabled = true;
		return springPanel;
	}

	public static SpringPanel NHBCPCFLMBL(GameObject LHACFNECMNA, Vector3 HEPNHCEIFMO, float NKNAABDPFBC)
	{
		SpringPanel springPanel = LHACFNECMNA.GetComponent<SpringPanel>();
		if (springPanel == null)
		{
			springPanel = LHACFNECMNA.AddComponent<SpringPanel>();
		}
		springPanel.target = HEPNHCEIFMO;
		springPanel.strength = NKNAABDPFBC;
		springPanel.onFinished = null;
		springPanel.enabled = true;
		return springPanel;
	}

	public static SpringPanel Begin(GameObject LHACFNECMNA, Vector3 HEPNHCEIFMO, float NKNAABDPFBC)
	{
		SpringPanel springPanel = LHACFNECMNA.GetComponent<SpringPanel>();
		if (springPanel == null)
		{
			springPanel = LHACFNECMNA.AddComponent<SpringPanel>();
		}
		springPanel.target = HEPNHCEIFMO;
		springPanel.strength = NKNAABDPFBC;
		springPanel.onFinished = null;
		springPanel.enabled = true;
		return springPanel;
	}

	private void ANAGGLOJIKB()
	{
		MPFGEBCBFFM = GetComponent<UIPanel>();
		BFMLIOBNNFI = GetComponent<UIScrollView>();
		NPLHCHNGMKF = base.transform;
	}

	private void IJCPEFOBKHO()
	{
		MPFGEBCBFFM = GetComponent<UIPanel>();
		BFMLIOBNNFI = GetComponent<UIScrollView>();
		NPLHCHNGMKF = base.transform;
	}

	public static SpringPanel EOGPMFCILOP(GameObject LHACFNECMNA, Vector3 HEPNHCEIFMO, float NKNAABDPFBC)
	{
		SpringPanel springPanel = LHACFNECMNA.GetComponent<SpringPanel>();
		if (springPanel == null)
		{
			springPanel = LHACFNECMNA.AddComponent<SpringPanel>();
		}
		springPanel.target = HEPNHCEIFMO;
		springPanel.strength = NKNAABDPFBC;
		springPanel.onFinished = null;
		springPanel.enabled = true;
		return springPanel;
	}

	protected virtual void GNOPKAHEDHP()
	{
		float oJAOJFBJGAH = RealTime.DCKJMALGFHC();
		bool flag = false;
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		Vector3 vector = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
		if ((vector - target).sqrMagnitude < 1271f)
		{
			vector = target;
			base.enabled = false;
			flag = false;
		}
		NPLHCHNGMKF.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= vector2.x;
		clipOffset.y -= vector2.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		if (BFMLIOBNNFI != null)
		{
			BFMLIOBNNFI.UpdateScrollbars(false);
		}
		if (flag && onFinished != null)
		{
			current = this;
			onFinished();
			current = null;
		}
	}

	private void FODOJCDNGOC()
	{
		MPFGEBCBFFM = GetComponent<UIPanel>();
		BFMLIOBNNFI = GetComponent<UIScrollView>();
		NPLHCHNGMKF = base.transform;
	}

	protected virtual void CCCBOPCJGPC()
	{
		float deltaTime = RealTime.get_deltaTime();
		bool flag = false;
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		Vector3 vector = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, deltaTime);
		if ((vector - target).sqrMagnitude < 0.01f)
		{
			vector = target;
			base.enabled = false;
			flag = true;
		}
		NPLHCHNGMKF.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= vector2.x;
		clipOffset.y -= vector2.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		if (BFMLIOBNNFI != null)
		{
			BFMLIOBNNFI.UpdateScrollbars(false);
		}
		if (flag && onFinished != null)
		{
			current = this;
			onFinished();
			current = null;
		}
	}

	protected virtual void PPOLFJDGMFH()
	{
		float oJAOJFBJGAH = RealTime.HCJFJNKPGNH();
		bool flag = true;
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		Vector3 vector = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
		if ((vector - target).sqrMagnitude < 725f)
		{
			vector = target;
			base.enabled = true;
			flag = true;
		}
		NPLHCHNGMKF.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= vector2.x;
		clipOffset.y -= vector2.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		if (BFMLIOBNNFI != null)
		{
			BFMLIOBNNFI.UpdateScrollbars(false);
		}
		if (flag && onFinished != null)
		{
			current = this;
			onFinished();
			current = null;
		}
	}

	private void GDKGBNKCGHO()
	{
		CCCBOPCJGPC();
	}

	private void HMNOCOBNBAO()
	{
		JMOACMMLPMA();
	}

	protected virtual void GJDGLDOGHKM()
	{
		float oJAOJFBJGAH = RealTime.DCKJMALGFHC();
		bool flag = true;
		Vector3 localPosition = NPLHCHNGMKF.localPosition;
		Vector3 vector = HHAINCPODGE.CHIGCMCIABC(NPLHCHNGMKF.localPosition, target, strength, oJAOJFBJGAH);
		if ((vector - target).sqrMagnitude < 1001f)
		{
			vector = target;
			base.enabled = false;
			flag = false;
		}
		NPLHCHNGMKF.localPosition = vector;
		Vector3 vector2 = vector - localPosition;
		Vector2 clipOffset = MPFGEBCBFFM.get_clipOffset();
		clipOffset.x -= vector2.x;
		clipOffset.y -= vector2.y;
		MPFGEBCBFFM.set_clipOffset(clipOffset);
		if (BFMLIOBNNFI != null)
		{
			BFMLIOBNNFI.UpdateScrollbars(false);
		}
		if (flag && onFinished != null)
		{
			current = this;
			onFinished();
			current = null;
		}
	}

	private void ODHEBKCPBPB()
	{
		GNOPKAHEDHP();
	}
}
