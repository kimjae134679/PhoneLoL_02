using UnityEngine;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	private static T EJJNICDDJMH;

	public static T CJGEEIOJKHE
	{
		get
		{
			return get_instance();
		}
	}

	public static T get_instance()
	{
		if (EJJNICDDJMH == null)
		{
			EJJNICDDJMH = Object.FindObjectOfType(typeof(T)) as T;
			if (EJJNICDDJMH == null)
			{
				EJJNICDDJMH = new GameObject("Singleton of " + typeof(T).ToString(), typeof(T)).GetComponent<T>();
				EJJNICDDJMH.Init();
			}
		}
		return EJJNICDDJMH;
	}

	private void Awake()
	{
		if (EJJNICDDJMH == null)
		{
			EJJNICDDJMH = this as T;
		}
	}

	public virtual void Init()
	{
	}

	private void OnApplicationQuit()
	{
		EJJNICDDJMH = (T)null;
	}
}
