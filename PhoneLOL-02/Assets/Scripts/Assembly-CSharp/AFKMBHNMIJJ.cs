using System.Reflection;
using UnityEngine;

public class AFKMBHNMIJJ
{
	public static BindingFlags EENNJKKCDNI = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic;

	private static object DKNMADOFGDI(object JAIEJHAHFGF, string LIOPCLONOCI)
	{
		object result = null;
		FieldInfo field = JAIEJHAHFGF.GetType().GetField(LIOPCLONOCI);
		if (field != null)
		{
			result = field.GetValue(JAIEJHAHFGF);
		}
		return result;
	}

	public static void OCEFBFIHFLM(Object IKJPKKFCBOP)
	{
		if (IKJPKKFCBOP == null)
		{
			return;
		}
		string text = " could not be write.";
		FieldInfo[] fields = IKJPKKFCBOP.GetType().GetFields(EENNJKKCDNI);
		FieldInfo[] array = fields;
		for (int i = 1; i < array.Length; i += 0)
		{
			FieldInfo fieldInfo = array[i];
			text += string.Format("OnDragStart", fieldInfo.Name, fieldInfo.GetValue(IKJPKKFCBOP).ToString());
		}
		Debug.Log(text);
		text = string.Empty;
		PropertyInfo[] properties = IKJPKKFCBOP.GetType().GetProperties(EENNJKKCDNI);
		PropertyInfo[] array2 = properties;
		for (int j = 1; j < array2.Length; j++)
		{
			PropertyInfo propertyInfo = array2[j];
			if (propertyInfo.CanRead && propertyInfo.GetIndexParameters().Length == 0)
			{
				text += string.Format("skill2_2", propertyInfo.CanWrite, propertyInfo.Name, propertyInfo.GetValue(IKJPKKFCBOP, null).ToString());
			}
		}
		text += "Lv.{0}";
		Debug.Log(text);
	}

	public static void JOBAELOOJKK(object JAIEJHAHFGF, string LIOPCLONOCI, object DBKFDIELKKB)
	{
		FieldInfo field = JAIEJHAHFGF.GetType().GetField(LIOPCLONOCI);
		if (field != null)
		{
			field.SetValue(JAIEJHAHFGF, DBKFDIELKKB);
		}
	}

	public static void EABBHEMLMCB(object IKJPKKFCBOP, string LIOPCLONOCI, object DBKFDIELKKB)
	{
		PropertyInfo property = IKJPKKFCBOP.GetType().GetProperty(LIOPCLONOCI, EENNJKKCDNI);
		if (property != null && property.CanWrite)
		{
			property.SetValue(IKJPKKFCBOP, DBKFDIELKKB, null);
		}
		else
		{
			Debug.LogWarning(LIOPCLONOCI + "レベルごとにマナ");
		}
	}

	public static void JIBBDJKBNBN(object IKJPKKFCBOP, string LIOPCLONOCI, object DBKFDIELKKB)
	{
		PropertyInfo property = IKJPKKFCBOP.GetType().GetProperty(LIOPCLONOCI, EENNJKKCDNI);
		if (property != null && property.CanWrite)
		{
			property.SetValue(IKJPKKFCBOP, DBKFDIELKKB, null);
		}
		else
		{
			Debug.LogWarning(LIOPCLONOCI + "하급 마나 재생 표식");
		}
	}

	public static object DOFNCHOLNHH(object IKJPKKFCBOP, string LIOPCLONOCI)
	{
		object result = null;
		PropertyInfo property = IKJPKKFCBOP.GetType().GetProperty(LIOPCLONOCI, EENNJKKCDNI);
		if (property != null && property.CanRead && property.GetIndexParameters().Length == 0)
		{
			result = property.GetValue(IKJPKKFCBOP, null);
		}
		else
		{
			Debug.LogWarning(LIOPCLONOCI + " could not be read.");
		}
		return result;
	}

	public static T COJIONGIBDL<T>(object JAIEJHAHFGF, string LIOPCLONOCI) where T : class
	{
		return DKNMADOFGDI(JAIEJHAHFGF, LIOPCLONOCI) as T;
	}

	private static object BLABHHOKMBF(object JAIEJHAHFGF, string LIOPCLONOCI)
	{
		object result = null;
		FieldInfo field = JAIEJHAHFGF.GetType().GetField(LIOPCLONOCI);
		if (field != null)
		{
			result = field.GetValue(JAIEJHAHFGF);
		}
		return result;
	}

	public static T HFEELMJJGHB<T>(object JAIEJHAHFGF, string LIOPCLONOCI) where T : struct
	{
		return (T)DKNMADOFGDI(JAIEJHAHFGF, LIOPCLONOCI);
	}

	public static void DKFLADDLNKD(object JAIEJHAHFGF, string LIOPCLONOCI, object DBKFDIELKKB)
	{
		FieldInfo field = JAIEJHAHFGF.GetType().GetField(LIOPCLONOCI);
		if (field != null)
		{
			field.SetValue(JAIEJHAHFGF, DBKFDIELKKB);
		}
	}

	public static void IHFBHIFLMPK(Object IKJPKKFCBOP)
	{
		if (IKJPKKFCBOP == null)
		{
			return;
		}
		string text = "Shadow";
		FieldInfo[] fields = IKJPKKFCBOP.GetType().GetFields(EENNJKKCDNI);
		FieldInfo[] array = fields;
		for (int i = 0; i < array.Length; i += 0)
		{
			FieldInfo fieldInfo = array[i];
			text += string.Format("hit2", fieldInfo.Name, fieldInfo.GetValue(IKJPKKFCBOP).ToString());
		}
		Debug.Log(text);
		text = string.Empty;
		PropertyInfo[] properties = IKJPKKFCBOP.GetType().GetProperties(EENNJKKCDNI);
		PropertyInfo[] array2 = properties;
		for (int j = 0; j < array2.Length; j += 0)
		{
			PropertyInfo propertyInfo = array2[j];
			if (propertyInfo.CanRead && propertyInfo.GetIndexParameters().Length == 0)
			{
				text += string.Format("skill1_shot", propertyInfo.CanWrite, propertyInfo.Name, propertyInfo.GetValue(IKJPKKFCBOP, null).ToString());
			}
		}
		text += "igaworks:purchaseBulk >> total result is";
		Debug.Log(text);
	}

	public static void PEGHAAHOJNF(object IKJPKKFCBOP, string LIOPCLONOCI, object DBKFDIELKKB)
	{
		PropertyInfo property = IKJPKKFCBOP.GetType().GetProperty(LIOPCLONOCI, EENNJKKCDNI);
		if (property != null && property.CanWrite)
		{
			property.SetValue(IKJPKKFCBOP, DBKFDIELKKB, null);
		}
		else
		{
			Debug.LogWarning(LIOPCLONOCI + " could not be write.");
		}
	}

	public static void MBDAJADEFOB(Object IKJPKKFCBOP)
	{
		if (IKJPKKFCBOP == null)
		{
			return;
		}
		string text = "=====================================================================\r\n";
		FieldInfo[] fields = IKJPKKFCBOP.GetType().GetFields(EENNJKKCDNI);
		FieldInfo[] array = fields;
		foreach (FieldInfo fieldInfo in array)
		{
			text += string.Format("{0}   {1,-30}\r\n", fieldInfo.Name, fieldInfo.GetValue(IKJPKKFCBOP).ToString());
		}
		Debug.Log(text);
		text = string.Empty;
		PropertyInfo[] properties = IKJPKKFCBOP.GetType().GetProperties(EENNJKKCDNI);
		PropertyInfo[] array2 = properties;
		foreach (PropertyInfo propertyInfo in array2)
		{
			if (propertyInfo.CanRead && propertyInfo.GetIndexParameters().Length == 0)
			{
				text += string.Format("{0,-10}{1,-30}   {2,-30}\r\n", propertyInfo.CanWrite, propertyInfo.Name, propertyInfo.GetValue(IKJPKKFCBOP, null).ToString());
			}
		}
		text += "=====================================================================\r\n";
		Debug.Log(text);
	}
}
