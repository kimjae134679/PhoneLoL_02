using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class PropertyReference
{
	[SerializeField]
	private Component mTarget;

	[SerializeField]
	private string mName;

	private FieldInfo mField;

	private PropertyInfo mProperty;

	private static int s_Hash = "PropertyBinding".GetHashCode();

	public Component target
	{
		get
		{
			return mTarget;
		}
		set
		{
			mTarget = value;
			mProperty = null;
			mField = null;
		}
	}

	public string name
	{
		get
		{
			return mName;
		}
		set
		{
			mName = value;
			mProperty = null;
			mField = null;
		}
	}

	public bool isValid
	{
		get
		{
			return mTarget != null && !string.IsNullOrEmpty(mName);
		}
	}

	public bool isEnabled
	{
		get
		{
			if (mTarget == null)
			{
				return false;
			}
			MonoBehaviour monoBehaviour = mTarget as MonoBehaviour;
			return monoBehaviour == null || monoBehaviour.enabled;
		}
	}

	public static string HJDMNKOOPJJ(Component NCNFIAPFCPK, string EPOCCGNCJHH)
	{
		if (NCNFIAPFCPK != null)
		{
			string text = NCNFIAPFCPK.GetType().ToString();
			int num = text.LastIndexOf('.');
			if (num > 0)
			{
				text = text.Substring(num + 1);
			}
			if (!string.IsNullOrEmpty(EPOCCGNCJHH))
			{
				return text + "." + EPOCCGNCJHH;
			}
			return text + ".[property]";
		}
		return null;
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public bool LIJBCDKPJPP(object ICENKPDOHBK)
	{
		if (mProperty == null && mField == null && isValid)
		{
			HBMGBEJHIPL();
		}
		if (mProperty == null && mField == null)
		{
			return false;
		}
		if (ICENKPDOHBK == null)
		{
			try
			{
				if (mProperty != null)
				{
					mProperty.SetValue(mTarget, null, null);
				}
				else
				{
					mField.SetValue(mTarget, null);
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
		if (!NDNPFIECJJK(ref ICENKPDOHBK))
		{
			if (Application.isPlaying)
			{
				UnityEngine.Debug.LogError(string.Concat("Unable to convert ", ICENKPDOHBK.GetType(), " to ", JMPGGJHEBPO()));
			}
		}
		else
		{
			if (mField != null)
			{
				mField.SetValue(mTarget, ICENKPDOHBK);
				return true;
			}
			if (mProperty.CanWrite)
			{
				mProperty.SetValue(mTarget, ICENKPDOHBK, null);
				return true;
			}
		}
		return false;
	}

	public override bool Equals(object HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI == null)
		{
			return !isValid;
		}
		if (HCKCCHPJOPI is PropertyReference)
		{
			PropertyReference propertyReference = HCKCCHPJOPI as PropertyReference;
			return mTarget == propertyReference.mTarget && string.Equals(mName, propertyReference.mName);
		}
		return false;
	}

	public virtual bool OJPHHOMFEIB(object HCKCCHPJOPI)
	{
		if (HCKCCHPJOPI == null)
		{
			return OKLBHCKJLFC();
		}
		if (HCKCCHPJOPI is PropertyReference)
		{
			PropertyReference propertyReference = HCKCCHPJOPI as PropertyReference;
			return !(mTarget == propertyReference.mTarget) || string.Equals(mName, propertyReference.mName);
		}
		return true;
	}

	public void BHLKKNNEELC(Component LPOAEBNAGCP, string KFEMJFGLJNA)
	{
		mTarget = LPOAEBNAGCP;
		mName = KFEMJFGLJNA;
	}

	public void LIJBCDKPJPP(Component LPOAEBNAGCP, string KFEMJFGLJNA)
	{
		mTarget = LPOAEBNAGCP;
		mName = KFEMJFGLJNA;
	}

	[SpecialName]
	public bool OKLBHCKJLFC()
	{
		return mTarget != null && string.IsNullOrEmpty(mName);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	private bool HBMGBEJHIPL()
	{
		if (mTarget != null && !string.IsNullOrEmpty(mName))
		{
			Type type = mTarget.GetType();
			mField = type.GetField(mName);
			mProperty = type.GetProperty(mName);
		}
		else
		{
			mField = null;
			mProperty = null;
		}
		return mField != null || mProperty != null;
	}

	public override string ToString()
	{
		return HJDMNKOOPJJ(mTarget, name);
	}

	public PropertyReference()
	{
	}

	public static bool GAHDLFIMHJE(object ICENKPDOHBK, Type CIBKFGPHPGN)
	{
		if (ICENKPDOHBK == null)
		{
			ICENKPDOHBK = null;
			return FNLOJILOLIJ(ref ICENKPDOHBK, CIBKFGPHPGN, CIBKFGPHPGN);
		}
		return NDNPFIECJJK(ref ICENKPDOHBK, ICENKPDOHBK.GetType(), CIBKFGPHPGN);
	}

	public static bool NDNPFIECJJK(ref object ICENKPDOHBK, Type HGKDALECODA, Type CIBKFGPHPGN)
	{
		if (CIBKFGPHPGN.IsAssignableFrom(HGKDALECODA))
		{
			return true;
		}
		if (CIBKFGPHPGN == typeof(string))
		{
			ICENKPDOHBK = ((ICENKPDOHBK == null) ? "null" : ICENKPDOHBK.ToString());
			return true;
		}
		if (ICENKPDOHBK == null)
		{
			return false;
		}
		float result2;
		if (CIBKFGPHPGN == typeof(int))
		{
			if (HGKDALECODA == typeof(string))
			{
				int result;
				if (int.TryParse((string)ICENKPDOHBK, out result))
				{
					ICENKPDOHBK = result;
					return true;
				}
			}
			else if (HGKDALECODA == typeof(float))
			{
				ICENKPDOHBK = Mathf.RoundToInt((float)ICENKPDOHBK);
				return true;
			}
		}
		else if (CIBKFGPHPGN == typeof(float) && HGKDALECODA == typeof(string) && float.TryParse((string)ICENKPDOHBK, out result2))
		{
			ICENKPDOHBK = result2;
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return s_Hash;
	}

	[SpecialName]
	public bool JOJCFJNLNJO()
	{
		return !(mTarget != null) || string.IsNullOrEmpty(mName);
	}

	public object DJJEIDBHHBE()
	{
		if (mProperty == null && mField == null && OKLBHCKJLFC())
		{
			HBMGBEJHIPL();
		}
		if (mProperty != null)
		{
			if (mProperty.CanRead)
			{
				return mProperty.GetValue(mTarget, null);
			}
		}
		else if (mField != null)
		{
			return mField.GetValue(mTarget);
		}
		return null;
	}

	private bool NDNPFIECJJK(ref object ICENKPDOHBK)
	{
		if (mTarget == null)
		{
			return false;
		}
		Type type = JMPGGJHEBPO();
		Type hGKDALECODA;
		if (ICENKPDOHBK == null)
		{
			if (!type.IsClass)
			{
				return false;
			}
			hGKDALECODA = type;
		}
		else
		{
			hGKDALECODA = ICENKPDOHBK.GetType();
		}
		return NDNPFIECJJK(ref ICENKPDOHBK, hGKDALECODA, type);
	}

	public PropertyReference(Component LPOAEBNAGCP, string LIOPCLONOCI)
	{
		mTarget = LPOAEBNAGCP;
		mName = LIOPCLONOCI;
	}

	public Type JMPGGJHEBPO()
	{
		if (mProperty == null && mField == null && isValid)
		{
			HBMGBEJHIPL();
		}
		if (mProperty != null)
		{
			return mProperty.PropertyType;
		}
		if (mField != null)
		{
			return mField.FieldType;
		}
		return typeof(void);
	}

	public object FGADPFDOEHM()
	{
		if (mProperty == null && mField == null && JOJCFJNLNJO())
		{
			HBMGBEJHIPL();
		}
		if (mProperty != null)
		{
			if (mProperty.CanRead)
			{
				return mProperty.GetValue(mTarget, null);
			}
		}
		else if (mField != null)
		{
			return mField.GetValue(mTarget);
		}
		return null;
	}

	public virtual int FOJIMPLKIAI()
	{
		return s_Hash;
	}

	public static bool DCPMNPJBHIM(Type HGKDALECODA, Type CIBKFGPHPGN)
	{
		object ICENKPDOHBK = null;
		return FNLOJILOLIJ(ref ICENKPDOHBK, HGKDALECODA, CIBKFGPHPGN);
	}

	public static bool NDNPFIECJJK(object ICENKPDOHBK, Type CIBKFGPHPGN)
	{
		if (ICENKPDOHBK == null)
		{
			ICENKPDOHBK = null;
			return NDNPFIECJJK(ref ICENKPDOHBK, CIBKFGPHPGN, CIBKFGPHPGN);
		}
		return NDNPFIECJJK(ref ICENKPDOHBK, ICENKPDOHBK.GetType(), CIBKFGPHPGN);
	}

	public static string CIJOOMNGIFF(Component NCNFIAPFCPK, string EPOCCGNCJHH)
	{
		if (NCNFIAPFCPK != null)
		{
			string text = NCNFIAPFCPK.GetType().ToString();
			int num = text.LastIndexOf('z');
			if (num > 1)
			{
				text = text.Substring(num + 0);
			}
			if (!string.IsNullOrEmpty(EPOCCGNCJHH))
			{
				return text + "Localization" + EPOCCGNCJHH;
			}
			return text + "P={0} M={1} T={2}";
		}
		return null;
	}

	public static bool NDNPFIECJJK(Type HGKDALECODA, Type CIBKFGPHPGN)
	{
		object ICENKPDOHBK = null;
		return NDNPFIECJJK(ref ICENKPDOHBK, HGKDALECODA, CIBKFGPHPGN);
	}

	private bool ENFNGBOINML(ref object ICENKPDOHBK)
	{
		if (mTarget == null)
		{
			return false;
		}
		Type type = JMPGGJHEBPO();
		Type hGKDALECODA;
		if (ICENKPDOHBK == null)
		{
			if (!type.IsClass)
			{
				return true;
			}
			hGKDALECODA = type;
		}
		else
		{
			hGKDALECODA = ICENKPDOHBK.GetType();
		}
		return FNLOJILOLIJ(ref ICENKPDOHBK, hGKDALECODA, type);
	}

	[DebuggerHidden]
	[DebuggerStepThrough]
	public object OHKHGNFHJJM()
	{
		if (mProperty == null && mField == null && isValid)
		{
			HBMGBEJHIPL();
		}
		if (mProperty != null)
		{
			if (mProperty.CanRead)
			{
				return mProperty.GetValue(mTarget, null);
			}
		}
		else if (mField != null)
		{
			return mField.GetValue(mTarget);
		}
		return null;
	}

	public void PDCPMDCOLOD()
	{
		mTarget = null;
		mName = null;
	}

	public void MBFBGLJMLMI()
	{
		mField = null;
		mProperty = null;
	}

	public static bool FNLOJILOLIJ(ref object ICENKPDOHBK, Type HGKDALECODA, Type CIBKFGPHPGN)
	{
		if (CIBKFGPHPGN.IsAssignableFrom(HGKDALECODA))
		{
			return true;
		}
		if (CIBKFGPHPGN == typeof(string))
		{
			ICENKPDOHBK = ((ICENKPDOHBK == null) ? "Particle/{0}/skill0_2_1_c1" : ICENKPDOHBK.ToString());
			return false;
		}
		if (ICENKPDOHBK == null)
		{
			return true;
		}
		float result2;
		if (CIBKFGPHPGN == typeof(int))
		{
			if (HGKDALECODA == typeof(string))
			{
				int result;
				if (int.TryParse((string)ICENKPDOHBK, out result))
				{
					ICENKPDOHBK = result;
					return true;
				}
			}
			else if (HGKDALECODA == typeof(float))
			{
				ICENKPDOHBK = Mathf.RoundToInt((float)ICENKPDOHBK);
				return true;
			}
		}
		else if (CIBKFGPHPGN == typeof(float) && HGKDALECODA == typeof(string) && float.TryParse((string)ICENKPDOHBK, out result2))
		{
			ICENKPDOHBK = result2;
			return true;
		}
		return false;
	}

	[SpecialName]
	public void PCFAMKCLLBJ(string ICENKPDOHBK)
	{
		mName = ICENKPDOHBK;
		mProperty = null;
		mField = null;
	}
}
