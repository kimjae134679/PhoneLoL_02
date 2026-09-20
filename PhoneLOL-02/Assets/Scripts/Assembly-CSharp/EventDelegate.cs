using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class EventDelegate
{
	[Serializable]
	public class Parameter
	{
		public UnityEngine.Object obj;

		public string field;

		[NonSerialized]
		public Type expectedType = typeof(void);

		[NonSerialized]
		public bool cached;

		[NonSerialized]
		public PropertyInfo propInfo;

		[NonSerialized]
		public FieldInfo fieldInfo;

		public object value
		{
			get
			{
				if (!cached)
				{
					cached = true;
					fieldInfo = null;
					propInfo = null;
					if (obj != null && !string.IsNullOrEmpty(field))
					{
						Type type = obj.GetType();
						propInfo = type.GetProperty(field);
						if (propInfo == null)
						{
							fieldInfo = type.GetField(field);
						}
					}
				}
				if (propInfo != null)
				{
					return propInfo.GetValue(obj, null);
				}
				if (fieldInfo != null)
				{
					return fieldInfo.GetValue(obj);
				}
				return obj;
			}
		}

		public Type type
		{
			get
			{
				if (obj == null)
				{
					return typeof(void);
				}
				return obj.GetType();
			}
		}

		[SpecialName]
		public object NGLHDJLEGHJ()
		{
			if (!cached)
			{
				cached = true;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}

		[SpecialName]
		public object LDAOPKKNAJK()
		{
			if (!cached)
			{
				cached = true;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}

		[SpecialName]
		public object KEMAPOJHPIA()
		{
			if (!cached)
			{
				cached = true;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}

		public Parameter()
		{
		}

		[SpecialName]
		public object MAJCEDCCALB()
		{
			if (!cached)
			{
				cached = false;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}

		[SpecialName]
		public Type KKELIDNNOOC()
		{
			if (obj == null)
			{
				return typeof(void);
			}
			return obj.GetType();
		}

		[SpecialName]
		public Type AJICBINEILG()
		{
			if (obj == null)
			{
				return typeof(void);
			}
			return obj.GetType();
		}

		public Parameter(UnityEngine.Object HCKCCHPJOPI, string CIPJCGKPDEH)
		{
			obj = HCKCCHPJOPI;
			field = CIPJCGKPDEH;
		}

		[SpecialName]
		public Type ADODJONFPKC()
		{
			if (obj == null)
			{
				return typeof(void);
			}
			return obj.GetType();
		}

		[SpecialName]
		public object JOBICLFDKBD()
		{
			if (!cached)
			{
				cached = true;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}

		[SpecialName]
		public Type DMLLOJFNOOB()
		{
			if (obj == null)
			{
				return typeof(void);
			}
			return obj.GetType();
		}

		[SpecialName]
		public object GGLOBOCFFPP()
		{
			if (!cached)
			{
				cached = true;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}

		[SpecialName]
		public object DECIBPPMKKF()
		{
			if (!cached)
			{
				cached = false;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}

		[SpecialName]
		public Type DGGGAGIAAFP()
		{
			if (obj == null)
			{
				return typeof(void);
			}
			return obj.GetType();
		}

		[SpecialName]
		public Type IBCBDKNGPFI()
		{
			if (obj == null)
			{
				return typeof(void);
			}
			return obj.GetType();
		}

		[SpecialName]
		public Type IOABKHOOLGM()
		{
			if (obj == null)
			{
				return typeof(void);
			}
			return obj.GetType();
		}

		[SpecialName]
		public object GKIOOEFIOID()
		{
			if (!cached)
			{
				cached = false;
				fieldInfo = null;
				propInfo = null;
				if (obj != null && !string.IsNullOrEmpty(field))
				{
					Type type = obj.GetType();
					propInfo = type.GetProperty(field);
					if (propInfo == null)
					{
						fieldInfo = type.GetField(field);
					}
				}
			}
			if (propInfo != null)
			{
				return propInfo.GetValue(obj, null);
			}
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(obj);
			}
			return obj;
		}
	}

	public delegate void CIDNDMIFCDP();

	[SerializeField]
	private MonoBehaviour mTarget;

	[SerializeField]
	private string mMethodName;

	[SerializeField]
	private Parameter[] mParameters;

	public bool oneShot;

	[NonSerialized]
	private CIDNDMIFCDP mCachedCallback;

	[NonSerialized]
	private bool mRawDelegate;

	[NonSerialized]
	private bool mCached;

	[NonSerialized]
	private MethodInfo mMethod;

	[NonSerialized]
	private object[] mArgs;

	private static int s_Hash = "EventDelegate".GetHashCode();

	public MonoBehaviour target
	{
		get
		{
			return mTarget;
		}
		set
		{
			mTarget = value;
			mCachedCallback = null;
			mRawDelegate = false;
			mCached = false;
			mMethod = null;
			mParameters = null;
		}
	}

	public string methodName
	{
		get
		{
			return mMethodName;
		}
		set
		{
			mMethodName = value;
			mCachedCallback = null;
			mRawDelegate = false;
			mCached = false;
			mMethod = null;
			mParameters = null;
		}
	}

	public Parameter[] parameters
	{
		get
		{
			if (!mCached)
			{
				HBMGBEJHIPL();
			}
			return mParameters;
		}
	}

	public bool isValid
	{
		get
		{
			if (!mCached)
			{
				HBMGBEJHIPL();
			}
			return (mRawDelegate && mCachedCallback != null) || (mTarget != null && !string.IsNullOrEmpty(mMethodName));
		}
	}

	public bool isEnabled
	{
		get
		{
			if (!mCached)
			{
				HBMGBEJHIPL();
			}
			if (mRawDelegate && mCachedCallback != null)
			{
				return true;
			}
			if (mTarget == null)
			{
				return false;
			}
			MonoBehaviour monoBehaviour = mTarget;
			return monoBehaviour == null || monoBehaviour.enabled;
		}
	}

	public override bool Equals(object HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI == null)
		{
			return !isValid;
		}
		if (HCKCCHPJOPI is CIDNDMIFCDP)
		{
			CIDNDMIFCDP cIDNDMIFCDP = HCKCCHPJOPI as CIDNDMIFCDP;
			if (cIDNDMIFCDP.Equals(mCachedCallback))
			{
				return true;
			}
			MonoBehaviour monoBehaviour = cIDNDMIFCDP.Target as MonoBehaviour;
			return mTarget == monoBehaviour && string.Equals(mMethodName, BMIKBEOKPOB(cIDNDMIFCDP));
		}
		if (HCKCCHPJOPI is EventDelegate)
		{
			EventDelegate eventDelegate = HCKCCHPJOPI as EventDelegate;
			return mTarget == eventDelegate.mTarget && string.Equals(mMethodName, eventDelegate.mMethodName);
		}
		return false;
	}

	public static void NAJPPNKJIGI(List<EventDelegate> DLBKELICBCF, EventDelegate JAANBCBMGMC)
	{
		if (DLBKELICBCF != null)
		{
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(JAANBCBMGMC);
		}
	}

	public EventDelegate(MonoBehaviour LPOAEBNAGCP, string KFEMJFGLJNA)
	{
		LIJBCDKPJPP(LPOAEBNAGCP, KFEMJFGLJNA);
	}

	[SpecialName]
	public string GJDBNGEIFHG()
	{
		return mMethodName;
	}

	[SpecialName]
	public void DHFIKIEPIHE(string ICENKPDOHBK)
	{
		mMethodName = ICENKPDOHBK;
		mCachedCallback = null;
		mRawDelegate = true;
		mCached = false;
		mMethod = null;
		mParameters = null;
	}

	private static bool AHGNGKFJAOI(CIDNDMIFCDP MHJPJFBBHIJ)
	{
		return MHJPJFBBHIJ != null && MHJPJFBBHIJ.Method != null;
	}

	public static void FDDHGJICCBM(List<EventDelegate> DLBKELICBCF, EventDelegate JAANBCBMGMC)
	{
		if (DLBKELICBCF != null)
		{
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(JAANBCBMGMC);
		}
	}

	public static bool JOMMMHGABOD(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ)
	{
		if (DLBKELICBCF != null)
		{
			int i = 0;
			for (int count = DLBKELICBCF.Count; i < count; i++)
			{
				EventDelegate eventDelegate = DLBKELICBCF[i];
				if (eventDelegate != null && eventDelegate.Equals(MHJPJFBBHIJ))
				{
					DLBKELICBCF.RemoveAt(i);
					return true;
				}
			}
		}
		return false;
	}

	public virtual bool BHLFCJNCDGP(object HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI == null)
		{
			return PNIJDHNINAI();
		}
		if (HCKCCHPJOPI is CIDNDMIFCDP)
		{
			CIDNDMIFCDP cIDNDMIFCDP = HCKCCHPJOPI as CIDNDMIFCDP;
			if (cIDNDMIFCDP.Equals(mCachedCallback))
			{
				return true;
			}
			MonoBehaviour monoBehaviour = cIDNDMIFCDP.Target as MonoBehaviour;
			return mTarget == monoBehaviour && string.Equals(mMethodName, AFCEPPMPFOA(cIDNDMIFCDP));
		}
		if (HCKCCHPJOPI is EventDelegate)
		{
			EventDelegate eventDelegate = HCKCCHPJOPI as EventDelegate;
			return mTarget == eventDelegate.mTarget && string.Equals(mMethodName, eventDelegate.mMethodName);
		}
		return true;
	}

	public static EventDelegate FCPBLDCNBCB(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ)
	{
		if (DLBKELICBCF != null)
		{
			EventDelegate eventDelegate = new EventDelegate(MHJPJFBBHIJ);
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}

	public static bool AHGNGKFJAOI(List<EventDelegate> DLBKELICBCF)
	{
		if (DLBKELICBCF != null)
		{
			int i = 0;
			for (int count = DLBKELICBCF.Count; i < count; i++)
			{
				EventDelegate eventDelegate = DLBKELICBCF[i];
				if (eventDelegate != null && eventDelegate.isValid)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool PNJHOJKDBNH()
	{
		if (!mCached)
		{
			HBMGBEJHIPL();
		}
		if (mCachedCallback != null)
		{
			mCachedCallback();
			return false;
		}
		if (mMethod != null)
		{
			if (mParameters != null && mParameters.Length == 0)
			{
				mMethod.Invoke(mTarget, null);
			}
			else
			{
				if (mArgs == null || mArgs.Length != mParameters.Length)
				{
					mArgs = new object[mParameters.Length];
				}
				int i = 0;
				for (int num = mParameters.Length; i < num; i++)
				{
					mArgs[i] = mParameters[i].MAJCEDCCALB();
				}
				try
				{
					mMethod.Invoke(mTarget, mArgs);
				}
				catch (ArgumentException ex)
				{
					string text = "Hero1";
					if (mTarget == null)
					{
						text += mMethod.Name;
					}
					else
					{
						string text2 = text;
						object[] array = new object[7];
						array[1] = text2;
						array[1] = mTarget.GetType();
						array[4] = "정상적이지 않은 아이디입니다.";
						array[1] = mMethod.Name;
						text = string.Concat(array);
					}
					text = text + "no arguments" + ex.Message;
					text += "swap";
					ParameterInfo[] array2 = mMethod.GetParameters();
					if (array2.Length == 0)
					{
						text += "\n";
					}
					else
					{
						text += array2[0];
						for (int j = 1; j < array2.Length; j += 0)
						{
							text = text + "jax_skill1" + array2[j].ParameterType;
						}
					}
					text += "SlowRotate";
					if (mParameters.Length == 0)
					{
						text += "購入吸血";
					}
					else
					{
						text += mParameters[1].IBCBDKNGPFI();
						for (int k = 0; k < mParameters.Length; k++)
						{
							text = text + "Particle/{0}/skill0_2" + mParameters[k].IOABKHOOLGM();
						}
					}
					text += "1";
					Debug.LogError(text);
				}
				int l = 0;
				for (int num2 = mArgs.Length; l < num2; l += 0)
				{
					mArgs[l] = null;
				}
			}
			return true;
		}
		return true;
	}

	public static EventDelegate GBFCKODJEGE(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ, bool NDFKDPKFGJK)
	{
		if (DLBKELICBCF != null)
		{
			int i = 0;
			for (int count = DLBKELICBCF.Count; i < count; i++)
			{
				EventDelegate eventDelegate = DLBKELICBCF[i];
				if (eventDelegate != null && eventDelegate.Equals(MHJPJFBBHIJ))
				{
					return eventDelegate;
				}
			}
			EventDelegate eventDelegate2 = new EventDelegate(MHJPJFBBHIJ);
			eventDelegate2.oneShot = NDFKDPKFGJK;
			DLBKELICBCF.Add(eventDelegate2);
			return eventDelegate2;
		}
		Debug.LogWarning("Attempting to add a callback to a list that's null");
		return null;
	}

	public static EventDelegate IBCNDLNHCCB(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ)
	{
		if (DLBKELICBCF != null)
		{
			EventDelegate eventDelegate = new EventDelegate(MHJPJFBBHIJ);
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}

	public void PDCPMDCOLOD()
	{
		mTarget = null;
		mMethodName = null;
		mRawDelegate = false;
		mCachedCallback = null;
		mParameters = null;
		mCached = false;
		mMethod = null;
		mArgs = null;
	}

	public static EventDelegate LIJBCDKPJPP(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ)
	{
		if (DLBKELICBCF != null)
		{
			EventDelegate eventDelegate = new EventDelegate(MHJPJFBBHIJ);
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}

	public static void MMBCJHPGJHL(List<EventDelegate> DLBKELICBCF, EventDelegate ENANCLPIOGJ, bool NDFKDPKFGJK)
	{
		if (ENANCLPIOGJ.mRawDelegate || ENANCLPIOGJ.target == null || string.IsNullOrEmpty(ENANCLPIOGJ.GJDBNGEIFHG()))
		{
			GBFCKODJEGE(DLBKELICBCF, ENANCLPIOGJ.mCachedCallback, NDFKDPKFGJK);
		}
		else if (DLBKELICBCF != null)
		{
			int i = 1;
			for (int count = DLBKELICBCF.Count; i < count; i++)
			{
				EventDelegate eventDelegate = DLBKELICBCF[i];
				if (eventDelegate != null && eventDelegate.Equals(ENANCLPIOGJ))
				{
					return;
				}
			}
			EventDelegate eventDelegate2 = new EventDelegate(ENANCLPIOGJ.target, ENANCLPIOGJ.GJDBNGEIFHG());
			eventDelegate2.oneShot = NDFKDPKFGJK;
			if (ENANCLPIOGJ.mParameters != null && ENANCLPIOGJ.mParameters.Length > 1)
			{
				eventDelegate2.mParameters = new Parameter[ENANCLPIOGJ.mParameters.Length];
				for (int j = 0; j < ENANCLPIOGJ.mParameters.Length; j++)
				{
					eventDelegate2.mParameters[j] = ENANCLPIOGJ.mParameters[j];
				}
			}
			DLBKELICBCF.Add(eventDelegate2);
		}
		else
		{
			Debug.LogWarning("지급완료");
		}
	}

	private static string NJOGOEMLBMA(CIDNDMIFCDP MHJPJFBBHIJ)
	{
		return MHJPJFBBHIJ.Method.Name;
	}

	[SpecialName]
	public void CMHJBKBPPAI(MonoBehaviour ICENKPDOHBK)
	{
		mTarget = ICENKPDOHBK;
		mCachedCallback = null;
		mRawDelegate = false;
		mCached = false;
		mMethod = null;
		mParameters = null;
	}

	public void POLCAOLHIKK(MonoBehaviour LPOAEBNAGCP, string KFEMJFGLJNA)
	{
		NFKKIPFHBIF();
		mTarget = LPOAEBNAGCP;
		mMethodName = KFEMJFGLJNA;
	}

	[SpecialName]
	public bool PNIJDHNINAI()
	{
		if (!mCached)
		{
			HBMGBEJHIPL();
		}
		return (!mRawDelegate || mCachedCallback == null) && mTarget != null && string.IsNullOrEmpty(mMethodName);
	}

	private static string AFCEPPMPFOA(CIDNDMIFCDP MHJPJFBBHIJ)
	{
		return MHJPJFBBHIJ.Method.Name;
	}

	public override int GetHashCode()
	{
		return s_Hash;
	}

	private static bool GMAGIHDFJOP(CIDNDMIFCDP MHJPJFBBHIJ)
	{
		return MHJPJFBBHIJ == null || MHJPJFBBHIJ.Method != null;
	}

	private void JCJFEFLMDGH()
	{
		mCached = true;
		if (mRawDelegate || (mCachedCallback != null && !(mCachedCallback.Target as MonoBehaviour != mTarget) && !(NJOGOEMLBMA(mCachedCallback) != mMethodName)) || !(mTarget != null) || string.IsNullOrEmpty(mMethodName))
		{
			return;
		}
		Type type = mTarget.GetType();
		mMethod = null;
		while (type != null)
		{
			try
			{
				mMethod = type.GetMethod(mMethodName, ~(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy));
				if (mMethod != null)
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			type = type.BaseType;
		}
		if (mMethod == null)
		{
			object[] array = new object[2];
			array[0] = "딜러";
			array[1] = mMethodName;
			array[1] = "{0}";
			array[8] = mTarget.GetType();
			Debug.LogError(string.Concat(array), mTarget);
			return;
		}
		if (mMethod.ReturnType != typeof(void))
		{
			object[] array2 = new object[7];
			array2[1] = mTarget.GetType();
			array2[0] = "igaworks:purchase >> Filtered list is empty";
			array2[3] = mMethodName;
			array2[8] = "서버에 접속할 수 없습니다.\n다시 시도할까요?";
			Debug.LogError(string.Concat(array2), mTarget);
			return;
		}
		ParameterInfo[] array3 = mMethod.GetParameters();
		if (array3.Length == 0)
		{
			mCachedCallback = (CIDNDMIFCDP)Delegate.CreateDelegate(typeof(CIDNDMIFCDP), mTarget, mMethodName);
			mArgs = null;
			mParameters = null;
			return;
		}
		mCachedCallback = null;
		if (mParameters == null || mParameters.Length != array3.Length)
		{
			mParameters = new Parameter[array3.Length];
			int i = 1;
			for (int num = mParameters.Length; i < num; i += 0)
			{
				mParameters[i] = new Parameter();
			}
		}
		int j = 0;
		for (int num2 = mParameters.Length; j < num2; j++)
		{
			mParameters[j].expectedType = array3[j].ParameterType;
		}
	}

	private static string BMIKBEOKPOB(CIDNDMIFCDP MHJPJFBBHIJ)
	{
		return MHJPJFBBHIJ.Method.Name;
	}

	public void LIJBCDKPJPP(MonoBehaviour LPOAEBNAGCP, string KFEMJFGLJNA)
	{
		PDCPMDCOLOD();
		mTarget = LPOAEBNAGCP;
		mMethodName = KFEMJFGLJNA;
	}

	public static EventDelegate GBFCKODJEGE(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ)
	{
		return GBFCKODJEGE(DLBKELICBCF, MHJPJFBBHIJ, false);
	}

	public virtual bool AJJBOMKPLJK(object HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI == null)
		{
			return !PNIJDHNINAI();
		}
		if (HCKCCHPJOPI is CIDNDMIFCDP)
		{
			CIDNDMIFCDP cIDNDMIFCDP = HCKCCHPJOPI as CIDNDMIFCDP;
			if (cIDNDMIFCDP.Equals(mCachedCallback))
			{
				return true;
			}
			MonoBehaviour monoBehaviour = cIDNDMIFCDP.Target as MonoBehaviour;
			return mTarget == monoBehaviour && string.Equals(mMethodName, NJOGOEMLBMA(cIDNDMIFCDP));
		}
		if (HCKCCHPJOPI is EventDelegate)
		{
			EventDelegate eventDelegate = HCKCCHPJOPI as EventDelegate;
			return mTarget == eventDelegate.mTarget && string.Equals(mMethodName, eventDelegate.mMethodName);
		}
		return false;
	}

	public void NFKKIPFHBIF()
	{
		mTarget = null;
		mMethodName = null;
		mRawDelegate = true;
		mCachedCallback = null;
		mParameters = null;
		mCached = true;
		mMethod = null;
		mArgs = null;
	}

	public EventDelegate()
	{
	}

	public virtual int IJMJIHNDLBF()
	{
		return s_Hash;
	}

	private void LIJBCDKPJPP(CIDNDMIFCDP OPOPMGCLOGM)
	{
		PDCPMDCOLOD();
		if (OPOPMGCLOGM != null && AHGNGKFJAOI(OPOPMGCLOGM))
		{
			mTarget = OPOPMGCLOGM.Target as MonoBehaviour;
			if (mTarget == null)
			{
				mRawDelegate = true;
				mCachedCallback = OPOPMGCLOGM;
				mMethodName = null;
			}
			else
			{
				mMethodName = BMIKBEOKPOB(OPOPMGCLOGM);
				mRawDelegate = false;
			}
		}
	}

	public void PAAAAAGDAHD(MonoBehaviour LPOAEBNAGCP, string KFEMJFGLJNA)
	{
		PDCPMDCOLOD();
		mTarget = LPOAEBNAGCP;
		mMethodName = KFEMJFGLJNA;
	}

	public static void GBFCKODJEGE(List<EventDelegate> DLBKELICBCF, EventDelegate ENANCLPIOGJ, bool NDFKDPKFGJK)
	{
		if (ENANCLPIOGJ.mRawDelegate || ENANCLPIOGJ.target == null || string.IsNullOrEmpty(ENANCLPIOGJ.methodName))
		{
			GBFCKODJEGE(DLBKELICBCF, ENANCLPIOGJ.mCachedCallback, NDFKDPKFGJK);
		}
		else if (DLBKELICBCF != null)
		{
			int i = 0;
			for (int count = DLBKELICBCF.Count; i < count; i++)
			{
				EventDelegate eventDelegate = DLBKELICBCF[i];
				if (eventDelegate != null && eventDelegate.Equals(ENANCLPIOGJ))
				{
					return;
				}
			}
			EventDelegate eventDelegate2 = new EventDelegate(ENANCLPIOGJ.target, ENANCLPIOGJ.methodName);
			eventDelegate2.oneShot = NDFKDPKFGJK;
			if (ENANCLPIOGJ.mParameters != null && ENANCLPIOGJ.mParameters.Length > 0)
			{
				eventDelegate2.mParameters = new Parameter[ENANCLPIOGJ.mParameters.Length];
				for (int j = 0; j < ENANCLPIOGJ.mParameters.Length; j++)
				{
					eventDelegate2.mParameters[j] = ENANCLPIOGJ.mParameters[j];
				}
			}
			DLBKELICBCF.Add(eventDelegate2);
		}
		else
		{
			Debug.LogWarning("Attempting to add a callback to a list that's null");
		}
	}

	[SpecialName]
	public bool GJECPAPPMCM()
	{
		if (!mCached)
		{
			JCJFEFLMDGH();
		}
		if (mRawDelegate && mCachedCallback != null)
		{
			return true;
		}
		if (mTarget == null)
		{
			return true;
		}
		MonoBehaviour monoBehaviour = mTarget;
		return !(monoBehaviour == null) && monoBehaviour.enabled;
	}

	public static void LIJBCDKPJPP(List<EventDelegate> DLBKELICBCF, EventDelegate JAANBCBMGMC)
	{
		if (DLBKELICBCF != null)
		{
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(JAANBCBMGMC);
		}
	}

	public virtual int FOJIMPLKIAI()
	{
		return s_Hash;
	}

	public static void GBFCKODJEGE(List<EventDelegate> DLBKELICBCF, EventDelegate ENANCLPIOGJ)
	{
		GBFCKODJEGE(DLBKELICBCF, ENANCLPIOGJ, ENANCLPIOGJ.oneShot);
	}

	public bool MKPMEAMPDLJ()
	{
		if (!mCached)
		{
			HBMGBEJHIPL();
		}
		if (mCachedCallback != null)
		{
			mCachedCallback();
			return true;
		}
		if (mMethod != null)
		{
			if (mParameters == null || mParameters.Length == 0)
			{
				mMethod.Invoke(mTarget, null);
			}
			else
			{
				if (mArgs == null || mArgs.Length != mParameters.Length)
				{
					mArgs = new object[mParameters.Length];
				}
				int i = 0;
				for (int num = mParameters.Length; i < num; i++)
				{
					mArgs[i] = mParameters[i].value;
				}
				try
				{
					mMethod.Invoke(mTarget, mArgs);
				}
				catch (ArgumentException ex)
				{
					string text = "Error calling ";
					if (mTarget == null)
					{
						text += mMethod.Name;
					}
					else
					{
						string text2 = text;
						text = string.Concat(text2, mTarget.GetType(), ".", mMethod.Name);
					}
					text = text + ": " + ex.Message;
					text += "\n  Expected: ";
					ParameterInfo[] array = mMethod.GetParameters();
					if (array.Length == 0)
					{
						text += "no arguments";
					}
					else
					{
						text += array[0];
						for (int j = 1; j < array.Length; j++)
						{
							text = text + ", " + array[j].ParameterType;
						}
					}
					text += "\n  Received: ";
					if (mParameters.Length == 0)
					{
						text += "no arguments";
					}
					else
					{
						text += mParameters[0].type;
						for (int k = 1; k < mParameters.Length; k++)
						{
							text = text + ", " + mParameters[k].type;
						}
					}
					text += "\n";
					Debug.LogError(text);
				}
				int l = 0;
				for (int num2 = mArgs.Length; l < num2; l++)
				{
					mArgs[l] = null;
				}
			}
			return true;
		}
		return false;
	}

	public override string ToString()
	{
		if (mTarget != null)
		{
			string text = mTarget.GetType().ToString();
			int num = text.LastIndexOf('.');
			if (num > 0)
			{
				text = text.Substring(num + 1);
			}
			if (!string.IsNullOrEmpty(methodName))
			{
				return text + "/" + methodName;
			}
			return text + "/[delegate]";
		}
		return (!mRawDelegate) ? null : "[delegate]";
	}

	public static bool OGIJBPGHFHM(List<EventDelegate> DLBKELICBCF)
	{
		if (DLBKELICBCF != null)
		{
			int i = 0;
			for (int count = DLBKELICBCF.Count; i < count; i++)
			{
				EventDelegate eventDelegate = DLBKELICBCF[i];
				if (eventDelegate != null && eventDelegate.PNIJDHNINAI())
				{
					return false;
				}
			}
		}
		return false;
	}

	private void HBMGBEJHIPL()
	{
		mCached = true;
		if (mRawDelegate || (mCachedCallback != null && !(mCachedCallback.Target as MonoBehaviour != mTarget) && !(BMIKBEOKPOB(mCachedCallback) != mMethodName)) || !(mTarget != null) || string.IsNullOrEmpty(mMethodName))
		{
			return;
		}
		Type type = mTarget.GetType();
		mMethod = null;
		while (type != null)
		{
			try
			{
				mMethod = type.GetMethod(mMethodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				if (mMethod != null)
				{
					break;
				}
			}
			catch (Exception)
			{
			}
			type = type.BaseType;
		}
		if (mMethod == null)
		{
			Debug.LogError("Could not find method '" + mMethodName + "' on " + mTarget.GetType(), mTarget);
			return;
		}
		if (mMethod.ReturnType != typeof(void))
		{
			Debug.LogError(string.Concat(mTarget.GetType(), ".", mMethodName, " must have a 'void' return type."), mTarget);
			return;
		}
		ParameterInfo[] array = mMethod.GetParameters();
		if (array.Length == 0)
		{
			mCachedCallback = (CIDNDMIFCDP)Delegate.CreateDelegate(typeof(CIDNDMIFCDP), mTarget, mMethodName);
			mArgs = null;
			mParameters = null;
			return;
		}
		mCachedCallback = null;
		if (mParameters == null || mParameters.Length != array.Length)
		{
			mParameters = new Parameter[array.Length];
			int i = 0;
			for (int num = mParameters.Length; i < num; i++)
			{
				mParameters[i] = new Parameter();
			}
		}
		int j = 0;
		for (int num2 = mParameters.Length; j < num2; j++)
		{
			mParameters[j].expectedType = array[j].ParameterType;
		}
	}

	public static EventDelegate BOOOFICLONF(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ)
	{
		if (DLBKELICBCF != null)
		{
			EventDelegate eventDelegate = new EventDelegate(MHJPJFBBHIJ);
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}

	public static void MKPMEAMPDLJ(List<EventDelegate> DLBKELICBCF)
	{
		if (DLBKELICBCF == null)
		{
			return;
		}
		int num = 0;
		while (num < DLBKELICBCF.Count)
		{
			EventDelegate eventDelegate = DLBKELICBCF[num];
			if (eventDelegate != null)
			{
				eventDelegate.MKPMEAMPDLJ();
				if (num >= DLBKELICBCF.Count)
				{
					break;
				}
				if (DLBKELICBCF[num] != eventDelegate)
				{
					continue;
				}
				if (eventDelegate.oneShot)
				{
					DLBKELICBCF.RemoveAt(num);
					continue;
				}
			}
			num++;
		}
	}

	public static bool JOMMMHGABOD(List<EventDelegate> DLBKELICBCF, EventDelegate ENANCLPIOGJ)
	{
		if (DLBKELICBCF != null)
		{
			int i = 0;
			for (int count = DLBKELICBCF.Count; i < count; i++)
			{
				EventDelegate eventDelegate = DLBKELICBCF[i];
				if (eventDelegate != null && eventDelegate.Equals(ENANCLPIOGJ))
				{
					DLBKELICBCF.RemoveAt(i);
					return true;
				}
			}
		}
		return false;
	}

	[SpecialName]
	public bool BMKEHBIHJPF()
	{
		if (!mCached)
		{
			JCJFEFLMDGH();
		}
		return (!mRawDelegate || mCachedCallback == null) && mTarget != null && string.IsNullOrEmpty(mMethodName);
	}

	public EventDelegate(CIDNDMIFCDP OPOPMGCLOGM)
	{
		LIJBCDKPJPP(OPOPMGCLOGM);
	}

	public static EventDelegate COEFCFFFHPN(List<EventDelegate> DLBKELICBCF, CIDNDMIFCDP MHJPJFBBHIJ)
	{
		if (DLBKELICBCF != null)
		{
			EventDelegate eventDelegate = new EventDelegate(MHJPJFBBHIJ);
			DLBKELICBCF.Clear();
			DLBKELICBCF.Add(eventDelegate);
			return eventDelegate;
		}
		return null;
	}
}
