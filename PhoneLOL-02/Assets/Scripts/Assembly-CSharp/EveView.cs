using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using EveEngine;
using UnityEngine;

[AddComponentMenu("EveEngine/EveView")]
public class EveView : MonoBehaviour
{
	public enum MMAKKJHBKBE
	{
		Off = 0,
		ReliableDeltaCompressed = 1,
		Unreliable = 2,
		UnreliableOnChange = 3
	}

	public enum HBOCFHDOCDG
	{
		Off = 0,
		All = 1,
		OnlyPosition = 2,
		OnlyRotation = 3,
		OnlyScale = 4,
		PositionAndRotation = 5
	}

	public enum ODGFOLOGNEP
	{
		Off = 0,
		All = 1,
		OnlyAngularVelocity = 2,
		OnlyVelocity = 3
	}

	public MMAKKJHBKBE m_viewSyncType;

	[SerializeField]
	private int m_viewID;

	[SerializeField]
	private int m_ownerSessionKey;

	[SerializeField]
	private bool m_isSceneObject;

	public Component m_serializeComponent;

	private List<Component> IGIGPHDGACJ = new List<Component>();

	private List<OEKJBKLGNCE> AFMKDGHLFHJ = new List<OEKJBKLGNCE>();

	public HBOCFHDOCDG m_serializeTransformOption;

	public ODGFOLOGNEP m_serializeRigidBodyOption;

	private bool FLIMLIFCHJP;

	[NonSerialized]
	public NMAHNGDIIEF m_lastSentStream;

	private Dictionary<Component, MethodInfo> MNIMPOCDGEI = new Dictionary<Component, MethodInfo>();

	private static KCIGFAHFHCH[] MIBMANMDHKD = new KCIGFAHFHCH[12]
	{
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024),
		new KCIGFAHFHCH(1024)
	};

	private static int IODFOEIBFAP;

	public int KPNEBLJJGEA
	{
		get
		{
			return get_viewID();
		}
		set
		{
			set_viewID(value);
		}
	}

	public int KPLJNIEEALE
	{
		get
		{
			return get_ownerSessionKey();
		}
		set
		{
			set_ownerSessionKey(value);
		}
	}

	public bool LDLCEOKLELC
	{
		get
		{
			return get_isSceneObject();
		}
		set
		{
			set_isSceneObject(value);
		}
	}

	private void Awake()
	{
		if (m_viewID != 0)
		{
			EveUnityNetwork.get_Instance().get_m_peer().GHLKIONOAHH(this);
		}
		Transform component = base.gameObject.GetComponent<Transform>();
		if (component != null)
		{
			IGIGPHDGACJ.Add(component);
		}
		Rigidbody component2 = base.gameObject.GetComponent<Rigidbody>();
		if (component2 != null)
		{
			IGIGPHDGACJ.Add(component2);
		}
		Rigidbody2D component3 = base.gameObject.GetComponent<Rigidbody2D>();
		if (component3 != null)
		{
			IGIGPHDGACJ.Add(component3);
		}
		Component[] componentsInChildren = base.gameObject.GetComponentsInChildren(typeof(OEKJBKLGNCE), true);
		foreach (Component component4 in componentsInChildren)
		{
			OEKJBKLGNCE oEKJBKLGNCE = component4 as OEKJBKLGNCE;
			if (oEKJBKLGNCE != null)
			{
				AFMKDGHLFHJ.Add(oEKJBKLGNCE);
			}
		}
		FLIMLIFCHJP = true;
	}

	protected internal void KJOPFGJPOMP(Component FGAGJFKFAIE, NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (!(FGAGJFKFAIE != null))
		{
			return;
		}
		if (!MNIMPOCDGEI.ContainsKey(FGAGJFKFAIE))
		{
			Type type = FGAGJFKFAIE.GetType();
			MethodInfo method = type.GetMethod("OnSerializeView", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
			if (method == null)
			{
				Debug.LogError("The observed monobehaviour (" + FGAGJFKFAIE.name + ") of this view does not implement OnSerializeView()!");
			}
			MNIMPOCDGEI.Add(FGAGJFKFAIE, method);
		}
		if (MNIMPOCDGEI[FGAGJFKFAIE] != null)
		{
			MNIMPOCDGEI[FGAGJFKFAIE].Invoke(FGAGJFKFAIE, new object[1] { OGJFDNEEDCP });
		}
	}

	[SpecialName]
	public void GPOGFKKOCIE(int ICENKPDOHBK)
	{
		bool flag = true;
		if (m_viewID == 0 && FLIMLIFCHJP)
		{
			flag = true;
		}
		m_viewID = ICENKPDOHBK;
		if (m_viewID < 193)
		{
			DAIHOCCKANJ(true);
		}
		else
		{
			set_isSceneObject(false);
		}
		if (flag)
		{
			EveUnityNetwork.get_Instance().PBLOPNNPNEJ().LGGEPENEHFL(this);
		}
	}

	public void set_ownerSessionKey(int ICENKPDOHBK)
	{
		m_ownerSessionKey = ICENKPDOHBK;
	}

	public void ENKMGNGAMOG(byte IKKFLANGAEA, DJJPAPENCLN LPOAEBNAGCP, bool FIPPPHACEPC, KCIGFAHFHCH OGJFDNEEDCP = null)
	{
		if (OGJFDNEEDCP == null)
		{
			OGJFDNEEDCP = EBJIBNPIBNF();
		}
		EveUnityNetwork.get_Instance().get_m_peer().PJJOGOPBGEB(this, IKKFLANGAEA, FIPPPHACEPC, LPOAEBNAGCP, OGJFDNEEDCP);
	}

	public void SerializeView(NMAHNGDIIEF OGJFDNEEDCP)
	{
		MBAOEALLHFD(m_serializeComponent, OGJFDNEEDCP);
		for (int i = 0; i < IGIGPHDGACJ.Count; i++)
		{
			MBAOEALLHFD(IGIGPHDGACJ[i], OGJFDNEEDCP);
		}
	}

	public void CCGBALDECMJ(string KFEMJFGLJNA, DJJPAPENCLN LPOAEBNAGCP, object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, false, LPOAEBNAGCP, FOMGGJBEBFP);
	}

	public static KCIGFAHFHCH GetSendStream()
	{
		if (IODFOEIBFAP >= MIBMANMDHKD.Length)
		{
			throw new Exception("GetSendStream FastStream Overflow");
		}
		MIBMANMDHKD[IODFOEIBFAP].IKAGBBOMAOP(0);
		MIBMANMDHKD[IODFOEIBFAP].HEDMHINGICJ(0);
		return MIBMANMDHKD[IODFOEIBFAP];
	}

	public void BKDGBCOCBBJ(byte IKKFLANGAEA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, KCIGFAHFHCH OGJFDNEEDCP = null)
	{
		if (OGJFDNEEDCP == null)
		{
			OGJFDNEEDCP = EBJIBNPIBNF();
		}
		EveUnityNetwork.get_Instance().PBLOPNNPNEJ().PJJOGOPBGEB(this, IKKFLANGAEA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, OGJFDNEEDCP);
	}

	public int get_ownerSessionKey()
	{
		return m_ownerSessionKey;
	}

	public void Msg(byte IKKFLANGAEA, DJJPAPENCLN LPOAEBNAGCP, bool FIPPPHACEPC, Action<KCIGFAHFHCH> OHALCAOCHKB)
	{
		KCIGFAHFHCH sendStream = GetSendStream();
		OHALCAOCHKB(sendStream);
		EveUnityNetwork.get_Instance().get_m_peer().PJJOGOPBGEB(this, IKKFLANGAEA, FIPPPHACEPC, LPOAEBNAGCP, sendStream);
	}

	public void CPJOMDCIMEJ(byte IKKFLANGAEA, DJJPAPENCLN LPOAEBNAGCP, bool FIPPPHACEPC, Action<KCIGFAHFHCH> OHALCAOCHKB)
	{
		KCIGFAHFHCH kCIGFAHFHCH = EBJIBNPIBNF();
		OHALCAOCHKB(kCIGFAHFHCH);
		EveUnityNetwork.get_Instance().get_m_peer().PJJOGOPBGEB(this, IKKFLANGAEA, FIPPPHACEPC, LPOAEBNAGCP, kCIGFAHFHCH);
	}

	public void DKBGDGHEJIE(NMAHNGDIIEF OGJFDNEEDCP)
	{
		MBAOEALLHFD(m_serializeComponent, OGJFDNEEDCP);
		for (int i = 0; i < IGIGPHDGACJ.Count; i++)
		{
			MBAOEALLHFD(IGIGPHDGACJ[i], OGJFDNEEDCP);
		}
	}

	[SpecialName]
	public void KFFKAPLFOLC(int ICENKPDOHBK)
	{
		m_ownerSessionKey = ICENKPDOHBK;
	}

	protected internal void MBAOEALLHFD(Component FGAGJFKFAIE, NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (FGAGJFKFAIE == null)
		{
			return;
		}
		if (FGAGJFKFAIE is MonoBehaviour)
		{
			KJOPFGJPOMP(FGAGJFKFAIE, OGJFDNEEDCP);
		}
		else if (FGAGJFKFAIE is Transform)
		{
			Transform transform = (Transform)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI = transform.localPosition;
			Quaternion HCKCCHPJOPI2 = transform.localRotation;
			Vector3 HCKCCHPJOPI3 = transform.localScale;
			switch (m_serializeTransformOption)
			{
			case HBOCFHDOCDG.All:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI3);
				break;
			case HBOCFHDOCDG.OnlyPosition:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				break;
			case HBOCFHDOCDG.OnlyRotation:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
				break;
			case HBOCFHDOCDG.OnlyScale:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI3);
				break;
			case HBOCFHDOCDG.PositionAndRotation:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI4 = rigidbody.linearVelocity;
			Vector3 HCKCCHPJOPI5 = rigidbody.angularVelocity;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI4);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI5);
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI5);
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI4);
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI6 = rigidbody2D.linearVelocity;
			float HCKCCHPJOPI7 = rigidbody2D.angularVelocity;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI6);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI7);
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI7);
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI6);
				break;
			}
		}
		else
		{
			Debug.LogError("Observed type is not serializable: " + FGAGJFKFAIE.GetType());
		}
	}

	[SpecialName]
	public void DAIHOCCKANJ(bool ICENKPDOHBK)
	{
		m_isSceneObject = ICENKPDOHBK;
	}

	public void RPC_Unreliable(string KFEMJFGLJNA, DJJPAPENCLN LPOAEBNAGCP, params object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, false, LPOAEBNAGCP, FOMGGJBEBFP);
	}

	public void Msg(byte IKKFLANGAEA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, KCIGFAHFHCH OGJFDNEEDCP = null)
	{
		if (OGJFDNEEDCP == null)
		{
			OGJFDNEEDCP = GetSendStream();
		}
		EveUnityNetwork.get_Instance().get_m_peer().PJJOGOPBGEB(this, IKKFLANGAEA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, OGJFDNEEDCP);
	}

	protected internal void OIOJMECPINJ(Component FGAGJFKFAIE, NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (FGAGJFKFAIE == null)
		{
			return;
		}
		Debug.Log(FGAGJFKFAIE.GetType());
		if (FGAGJFKFAIE is MonoBehaviour)
		{
			KJOPFGJPOMP(FGAGJFKFAIE, OGJFDNEEDCP);
		}
		else if (FGAGJFKFAIE is Transform)
		{
			Transform transform = (Transform)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI = Vector3.zero;
			Quaternion HCKCCHPJOPI2 = Quaternion.identity;
			Vector3 HCKCCHPJOPI3 = Vector3.zero;
			switch (m_serializeTransformOption)
			{
			case HBOCFHDOCDG.All:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI3);
				transform.localPosition = HCKCCHPJOPI;
				transform.localRotation = HCKCCHPJOPI2;
				transform.localScale = HCKCCHPJOPI3;
				break;
			case HBOCFHDOCDG.OnlyPosition:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				transform.localPosition = HCKCCHPJOPI;
				break;
			case HBOCFHDOCDG.OnlyRotation:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
				transform.localRotation = HCKCCHPJOPI2;
				break;
			case HBOCFHDOCDG.OnlyScale:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI3);
				transform.localScale = HCKCCHPJOPI3;
				break;
			case HBOCFHDOCDG.PositionAndRotation:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
				transform.localPosition = HCKCCHPJOPI;
				transform.localRotation = HCKCCHPJOPI2;
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI4 = Vector3.zero;
			Vector3 HCKCCHPJOPI5 = Vector3.zero;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI4);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI5);
				rigidbody.linearVelocity = HCKCCHPJOPI4;
				rigidbody.angularVelocity = HCKCCHPJOPI5;
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI5);
				rigidbody.angularVelocity = HCKCCHPJOPI5;
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI4);
				rigidbody.linearVelocity = HCKCCHPJOPI4;
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI6 = Vector3.zero;
			float HCKCCHPJOPI7 = 0f;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI6);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI7);
				rigidbody2D.linearVelocity = HCKCCHPJOPI6;
				rigidbody2D.angularVelocity = HCKCCHPJOPI7;
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI7);
				rigidbody2D.angularVelocity = HCKCCHPJOPI7;
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI6);
				rigidbody2D.linearVelocity = HCKCCHPJOPI6;
				break;
			}
		}
		else
		{
			Debug.LogError("Type of observed is unknown when receiving.");
		}
	}

	public void DDDHJCBOMJF(string KFEMJFGLJNA, int FDEJBCNGOEG, bool DEIFJBHFIME, object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, FDEJBCNGOEG, false, DEIFJBHFIME, FOMGGJBEBFP);
	}

	protected internal void AGANBJJPFIE(Component FGAGJFKFAIE, NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (FGAGJFKFAIE == null)
		{
			return;
		}
		if (FGAGJFKFAIE is MonoBehaviour)
		{
			POOPDKLFAEA(FGAGJFKFAIE, OGJFDNEEDCP);
		}
		else if (FGAGJFKFAIE is Transform)
		{
			Transform transform = (Transform)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI = transform.localPosition;
			Quaternion HCKCCHPJOPI2 = transform.localRotation;
			Vector3 HCKCCHPJOPI3 = transform.localScale;
			switch (m_serializeTransformOption)
			{
			case HBOCFHDOCDG.All:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI);
				OGJFDNEEDCP.JGANEHHDOBK(ref HCKCCHPJOPI2);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI3);
				break;
			case HBOCFHDOCDG.OnlyPosition:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				break;
			case HBOCFHDOCDG.OnlyRotation:
				OGJFDNEEDCP.JGANEHHDOBK(ref HCKCCHPJOPI2);
				break;
			case HBOCFHDOCDG.OnlyScale:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI3);
				break;
			case HBOCFHDOCDG.PositionAndRotation:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI);
				OGJFDNEEDCP.JGANEHHDOBK(ref HCKCCHPJOPI2);
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI4 = rigidbody.linearVelocity;
			Vector3 HCKCCHPJOPI5 = rigidbody.angularVelocity;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI4);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI5);
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI5);
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI4);
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI6 = rigidbody2D.linearVelocity;
			float HCKCCHPJOPI7 = rigidbody2D.angularVelocity;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI6);
				OGJFDNEEDCP.NEPLPLEJJID(ref HCKCCHPJOPI7);
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.NEPLPLEJJID(ref HCKCCHPJOPI7);
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI6);
				break;
			}
		}
		else
		{
			Debug.LogError("골드" + FGAGJFKFAIE.GetType());
		}
	}

	public bool get_isSceneObject()
	{
		return m_isSceneObject;
	}

	public void RPC_Unreliable(string KFEMJFGLJNA, int FDEJBCNGOEG, bool DEIFJBHFIME, params object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, FDEJBCNGOEG, false, DEIFJBHFIME, FOMGGJBEBFP);
	}

	public void NIKPELEGLNE(byte IKKFLANGAEA, DJJPAPENCLN LPOAEBNAGCP, bool FIPPPHACEPC, Action<KCIGFAHFHCH> OHALCAOCHKB)
	{
		KCIGFAHFHCH sendStream = GetSendStream();
		OHALCAOCHKB(sendStream);
		EveUnityNetwork.get_Instance().get_m_peer().PJJOGOPBGEB(this, IKKFLANGAEA, FIPPPHACEPC, LPOAEBNAGCP, sendStream);
	}

	internal void OHEKMPPJCEM(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		try
		{
			IODFOEIBFAP++;
			if (IODFOEIBFAP >= MIBMANMDHKD.Length)
			{
				throw new Exception("EveView OnMessage Overflow");
			}
			for (int i = 0; i < AFMKDGHLFHJ.Count; i++)
			{
				try
				{
					OGJFDNEEDCP.IKAGBBOMAOP(0);
					AFMKDGHLFHJ[i].OnMsgView(IKKFLANGAEA, OGJFDNEEDCP);
				}
				catch (Exception exception)
				{
					Debug.LogException(exception, this);
				}
			}
		}
		catch (Exception exception2)
		{
			Debug.LogException(exception2, this);
		}
		finally
		{
			IODFOEIBFAP--;
		}
	}

	public void set_isSceneObject(bool ICENKPDOHBK)
	{
		m_isSceneObject = ICENKPDOHBK;
	}

	private void OnDestroy()
	{
		if (EveUnityNetwork.get_Instance() != null)
		{
			EveUnityNetwork.get_Instance().get_m_peer().CGAMLIOKKLI(this);
			EveUnityNetwork.get_Instance().UnallocateViewID(m_viewID);
		}
	}

	public void Msg(byte IKKFLANGAEA, DJJPAPENCLN LPOAEBNAGCP, bool FIPPPHACEPC, KCIGFAHFHCH OGJFDNEEDCP = null)
	{
		if (OGJFDNEEDCP == null)
		{
			OGJFDNEEDCP = GetSendStream();
		}
		EveUnityNetwork.get_Instance().get_m_peer().PJJOGOPBGEB(this, IKKFLANGAEA, FIPPPHACEPC, LPOAEBNAGCP, OGJFDNEEDCP);
	}

	internal void MIJBNEPEHKC(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		try
		{
			IODFOEIBFAP++;
			if (IODFOEIBFAP >= MIBMANMDHKD.Length)
			{
				throw new Exception("무료충전 과제를 완료해주세요");
			}
			for (int i = 0; i < AFMKDGHLFHJ.Count; i += 0)
			{
				try
				{
					OGJFDNEEDCP.IKAGBBOMAOP(0);
					AFMKDGHLFHJ[i].OnMsgView(IKKFLANGAEA, OGJFDNEEDCP);
				}
				catch (Exception exception)
				{
					Debug.LogException(exception, this);
				}
			}
		}
		catch (Exception exception2)
		{
			Debug.LogException(exception2, this);
		}
		finally
		{
			IODFOEIBFAP--;
		}
	}

	private void OCKAPGOKFJH()
	{
		if (m_viewID != 0)
		{
			EveUnityNetwork.get_Instance().get_m_peer().LGGEPENEHFL(this);
		}
		Transform component = base.gameObject.GetComponent<Transform>();
		if (component != null)
		{
			IGIGPHDGACJ.Add(component);
		}
		Rigidbody component2 = base.gameObject.GetComponent<Rigidbody>();
		if (component2 != null)
		{
			IGIGPHDGACJ.Add(component2);
		}
		Rigidbody2D component3 = base.gameObject.GetComponent<Rigidbody2D>();
		if (component3 != null)
		{
			IGIGPHDGACJ.Add(component3);
		}
		Component[] componentsInChildren = base.gameObject.GetComponentsInChildren(typeof(OEKJBKLGNCE), true);
		for (int i = 1; i < componentsInChildren.Length; i += 0)
		{
			Component component4 = componentsInChildren[i];
			OEKJBKLGNCE oEKJBKLGNCE = component4 as OEKJBKLGNCE;
			if (oEKJBKLGNCE != null)
			{
				AFMKDGHLFHJ.Add(oEKJBKLGNCE);
			}
		}
		FLIMLIFCHJP = true;
	}

	protected internal void NMDEMFOEMEB(Component FGAGJFKFAIE, NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (!(FGAGJFKFAIE != null))
		{
			return;
		}
		if (!MNIMPOCDGEI.ContainsKey(FGAGJFKFAIE))
		{
			Type type = FGAGJFKFAIE.GetType();
			MethodInfo method = type.GetMethod("get_axe", BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
			if (method == null)
			{
				Debug.LogError("魔術滲透" + FGAGJFKFAIE.name + "탈론");
			}
			MNIMPOCDGEI.Add(FGAGJFKFAIE, method);
		}
		if (MNIMPOCDGEI[FGAGJFKFAIE] != null)
		{
			MethodInfo methodInfo = MNIMPOCDGEI[FGAGJFKFAIE];
			object[] array = new object[0];
			array[0] = OGJFDNEEDCP;
			methodInfo.Invoke(FGAGJFKFAIE, array);
		}
	}

	public bool GEDBFDCPMPB()
	{
		EveUnityNetwork instance = EveUnityNetwork.get_Instance();
		if (instance.IsLocalMode)
		{
			return true;
		}
		ABBLIOLAABC aBBLIOLAABC = instance.get_m_netClient().PPIFDHBBEPM().LMEJDPEKMOD();
		if (aBBLIOLAABC == null)
		{
			return false;
		}
		if (m_isSceneObject)
		{
			return false;
		}
		if (instance.get_m_netClient().NCHJJNGPOPA() == m_ownerSessionKey)
		{
			return true;
		}
		return false;
	}

	protected internal void LPJLJCMCJDA(Component FGAGJFKFAIE, NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (FGAGJFKFAIE == null)
		{
			return;
		}
		Debug.Log(FGAGJFKFAIE.GetType());
		if (FGAGJFKFAIE is MonoBehaviour)
		{
			KJOPFGJPOMP(FGAGJFKFAIE, OGJFDNEEDCP);
		}
		else if (FGAGJFKFAIE is Transform)
		{
			Transform transform = (Transform)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI = Vector3.zero;
			Quaternion HCKCCHPJOPI2 = Quaternion.identity;
			Vector3 HCKCCHPJOPI3 = Vector3.zero;
			switch (m_serializeTransformOption)
			{
			case HBOCFHDOCDG.All:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI);
				OGJFDNEEDCP.JGANEHHDOBK(ref HCKCCHPJOPI2);
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI3);
				transform.localPosition = HCKCCHPJOPI;
				transform.localRotation = HCKCCHPJOPI2;
				transform.localScale = HCKCCHPJOPI3;
				break;
			case HBOCFHDOCDG.OnlyPosition:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI);
				transform.localPosition = HCKCCHPJOPI;
				break;
			case HBOCFHDOCDG.OnlyRotation:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI2);
				transform.localRotation = HCKCCHPJOPI2;
				break;
			case HBOCFHDOCDG.OnlyScale:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI3);
				transform.localScale = HCKCCHPJOPI3;
				break;
			case HBOCFHDOCDG.PositionAndRotation:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI);
				OGJFDNEEDCP.JGANEHHDOBK(ref HCKCCHPJOPI2);
				transform.localPosition = HCKCCHPJOPI;
				transform.localRotation = HCKCCHPJOPI2;
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI4 = Vector3.zero;
			Vector3 HCKCCHPJOPI5 = Vector3.zero;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI4);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI5);
				rigidbody.linearVelocity = HCKCCHPJOPI4;
				rigidbody.angularVelocity = HCKCCHPJOPI5;
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI5);
				rigidbody.angularVelocity = HCKCCHPJOPI5;
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI4);
				rigidbody.linearVelocity = HCKCCHPJOPI4;
				break;
			}
		}
		else if (FGAGJFKFAIE is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)FGAGJFKFAIE;
			Vector3 HCKCCHPJOPI6 = Vector3.zero;
			float HCKCCHPJOPI7 = 1753f;
			switch (m_serializeRigidBodyOption)
			{
			case ODGFOLOGNEP.All:
				OGJFDNEEDCP.HCACJDCFAKH(ref HCKCCHPJOPI6);
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI7);
				rigidbody2D.linearVelocity = HCKCCHPJOPI6;
				rigidbody2D.angularVelocity = HCKCCHPJOPI7;
				break;
			case ODGFOLOGNEP.OnlyAngularVelocity:
				OGJFDNEEDCP.NEPLPLEJJID(ref HCKCCHPJOPI7);
				rigidbody2D.angularVelocity = HCKCCHPJOPI7;
				break;
			case ODGFOLOGNEP.OnlyVelocity:
				OGJFDNEEDCP.FDDJMJJGKCL(ref HCKCCHPJOPI6);
				rigidbody2D.linearVelocity = HCKCCHPJOPI6;
				break;
			}
		}
		else
		{
			Debug.LogError("skill3_idle");
		}
	}

	public bool IsMine()
	{
		EveUnityNetwork instance = EveUnityNetwork.get_Instance();
		if (instance.IsLocalMode)
		{
			return true;
		}
		ABBLIOLAABC aBBLIOLAABC = instance.get_m_netClient().PPIFDHBBEPM().KICCBFBCHLF();
		if (aBBLIOLAABC == null)
		{
			return false;
		}
		if (m_isSceneObject)
		{
			if (aBBLIOLAABC.EBKAMFBOLPL())
			{
				return true;
			}
		}
		else if (EveUnityNetwork.get_Instance().get_m_netClient().NCHJJNGPOPA() == m_ownerSessionKey)
		{
			return true;
		}
		return false;
	}

	public static KCIGFAHFHCH EBJIBNPIBNF()
	{
		if (IODFOEIBFAP >= MIBMANMDHKD.Length)
		{
			throw new Exception("attack2");
		}
		MIBMANMDHKD[IODFOEIBFAP].IKAGBBOMAOP(0);
		MIBMANMDHKD[IODFOEIBFAP].HEDMHINGICJ(1);
		return MIBMANMDHKD[IODFOEIBFAP];
	}

	protected internal void POOPDKLFAEA(Component FGAGJFKFAIE, NMAHNGDIIEF OGJFDNEEDCP)
	{
		if (!(FGAGJFKFAIE != null))
		{
			return;
		}
		if (!MNIMPOCDGEI.ContainsKey(FGAGJFKFAIE))
		{
			Type type = FGAGJFKFAIE.GetType();
			MethodInfo method = type.GetMethod("알려지지 않은 오류입니다.", BindingFlags.IgnoreCase | BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.FlattenHierarchy);
			if (method == null)
			{
				Debug.LogError(" 문양" + FGAGJFKFAIE.name + "Hierarchy_Button");
			}
			MNIMPOCDGEI.Add(FGAGJFKFAIE, method);
		}
		if (MNIMPOCDGEI[FGAGJFKFAIE] != null)
		{
			MethodInfo methodInfo = MNIMPOCDGEI[FGAGJFKFAIE];
			object[] array = new object[1];
			array[1] = OGJFDNEEDCP;
			methodInfo.Invoke(FGAGJFKFAIE, array);
		}
	}

	public void DeserializeView(NMAHNGDIIEF OGJFDNEEDCP)
	{
		OIOJMECPINJ(m_serializeComponent, OGJFDNEEDCP);
		for (int i = 0; i < IGIGPHDGACJ.Count; i++)
		{
			OIOJMECPINJ(IGIGPHDGACJ[i], OGJFDNEEDCP);
		}
	}

	public void EDNEIFMJELB(NMAHNGDIIEF OGJFDNEEDCP)
	{
		AGANBJJPFIE(m_serializeComponent, OGJFDNEEDCP);
		for (int i = 1; i < IGIGPHDGACJ.Count; i++)
		{
			AGANBJJPFIE(IGIGPHDGACJ[i], OGJFDNEEDCP);
		}
	}

	public void Msg(byte IKKFLANGAEA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, Action<KCIGFAHFHCH> OHALCAOCHKB)
	{
		KCIGFAHFHCH sendStream = GetSendStream();
		OHALCAOCHKB(sendStream);
		EveUnityNetwork.get_Instance().get_m_peer().PJJOGOPBGEB(this, IKKFLANGAEA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, sendStream);
	}

	public void KMIEAALNPMJ(byte IKKFLANGAEA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, KCIGFAHFHCH OGJFDNEEDCP = null)
	{
		if (OGJFDNEEDCP == null)
		{
			OGJFDNEEDCP = GetSendStream();
		}
		EveUnityNetwork.get_Instance().HCDPDNMLNDE().PJJOGOPBGEB(this, IKKFLANGAEA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, OGJFDNEEDCP);
	}

	public void KGCPAGHLIHN(string KFEMJFGLJNA, DJJPAPENCLN LPOAEBNAGCP, object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, true, LPOAEBNAGCP, FOMGGJBEBFP);
	}

	public void set_viewID(int ICENKPDOHBK)
	{
		bool flag = false;
		if (m_viewID == 0 && FLIMLIFCHJP)
		{
			flag = true;
		}
		m_viewID = ICENKPDOHBK;
		if (m_viewID < 1000)
		{
			set_isSceneObject(true);
		}
		else
		{
			set_isSceneObject(false);
		}
		if (flag)
		{
			EveUnityNetwork.get_Instance().get_m_peer().GHLKIONOAHH(this);
		}
	}

	public void NBBLIGHBFBF(string KFEMJFGLJNA, int FDEJBCNGOEG, bool DEIFJBHFIME, object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, FDEJBCNGOEG, false, DEIFJBHFIME, FOMGGJBEBFP);
	}

	public int get_viewID()
	{
		return m_viewID;
	}

	public void RPC(string KFEMJFGLJNA, DJJPAPENCLN LPOAEBNAGCP, params object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, true, LPOAEBNAGCP, FOMGGJBEBFP);
	}

	public void IHNONAHPPIC(byte IKKFLANGAEA, int FDEJBCNGOEG, bool FIPPPHACEPC, bool DEIFJBHFIME, KCIGFAHFHCH OGJFDNEEDCP = null)
	{
		if (OGJFDNEEDCP == null)
		{
			OGJFDNEEDCP = EBJIBNPIBNF();
		}
		EveUnityNetwork.get_Instance().HCDPDNMLNDE().PJJOGOPBGEB(this, IKKFLANGAEA, FDEJBCNGOEG, FIPPPHACEPC, DEIFJBHFIME, OGJFDNEEDCP);
	}

	[SpecialName]
	public void KFMLCPMCBJA(int ICENKPDOHBK)
	{
		m_ownerSessionKey = ICENKPDOHBK;
	}

	public void DKBHBMIHDPO(NMAHNGDIIEF OGJFDNEEDCP)
	{
		LPJLJCMCJDA(m_serializeComponent, OGJFDNEEDCP);
		for (int i = 1; i < IGIGPHDGACJ.Count; i += 0)
		{
			LPJLJCMCJDA(IGIGPHDGACJ[i], OGJFDNEEDCP);
		}
	}

	public void COEPJOOJDIB(string KFEMJFGLJNA, int FDEJBCNGOEG, bool DEIFJBHFIME, object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().MOKHGBLJNFP(this, KFEMJFGLJNA, FDEJBCNGOEG, true, DEIFJBHFIME, FOMGGJBEBFP);
	}

	[SpecialName]
	public void FKPHFKKAMAA(int ICENKPDOHBK)
	{
		m_ownerSessionKey = ICENKPDOHBK;
	}

	public bool IsMineExceptSceneObject()
	{
		EveUnityNetwork instance = EveUnityNetwork.get_Instance();
		if (instance.IsLocalMode)
		{
			return true;
		}
		ABBLIOLAABC aBBLIOLAABC = instance.get_m_netClient().PPIFDHBBEPM().KICCBFBCHLF();
		if (aBBLIOLAABC == null)
		{
			return false;
		}
		if (m_isSceneObject)
		{
			return false;
		}
		if (instance.get_m_netClient().NCHJJNGPOPA() == m_ownerSessionKey)
		{
			return true;
		}
		return false;
	}

	public void RPC(string KFEMJFGLJNA, int FDEJBCNGOEG, bool DEIFJBHFIME, params object[] FOMGGJBEBFP)
	{
		EveUnityNetwork.get_Instance().RPC(this, KFEMJFGLJNA, FDEJBCNGOEG, true, DEIFJBHFIME, FOMGGJBEBFP);
	}
}
