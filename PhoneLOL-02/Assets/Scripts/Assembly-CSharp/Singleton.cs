using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Component
{
	private static T GBDPGCKEOHD;

	private static bool PJKIPNMJOPG;

	private static bool DCNJHKGHKFJ;

	public static T CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	protected virtual void Awake()
	{
		if (GBDPGCKEOHD == null)
		{
			GBDPGCKEOHD = this as T;
			Object.DontDestroyOnLoad(base.gameObject);
			PJKIPNMJOPG = true;
		}
		else
		{
			Debug.LogError(string.Format("Already created singleton object {0}", typeof(T)), base.gameObject);
		}
	}

	protected virtual void OnApplicationQuit()
	{
		DCNJHKGHKFJ = true;
	}

	protected virtual void PCFCEAOOAEE()
	{
		if (GBDPGCKEOHD == null)
		{
			GBDPGCKEOHD = this as T;
			Object.DontDestroyOnLoad(base.gameObject);
			PJKIPNMJOPG = true;
		}
		else
		{
			Debug.LogError(string.Format("Restart", typeof(T)), base.gameObject);
		}
	}

	protected virtual void JMFANEPLGDE()
	{
		DCNJHKGHKFJ = true;
	}

	protected virtual void GEBPMKHNEAF()
	{
		DCNJHKGHKFJ = true;
	}

	public static T get_Instance()
	{
		if (!PJKIPNMJOPG)
		{
			PJKIPNMJOPG = true;
			GBDPGCKEOHD = Object.FindObjectOfType<T>();
			if (GBDPGCKEOHD == null && !DCNJHKGHKFJ)
			{
				GameObject gameObject = new GameObject();
				gameObject.name = typeof(T).Name;
				GBDPGCKEOHD = gameObject.AddComponent<T>();
			}
		}
		return GBDPGCKEOHD;
	}

	protected virtual void NOFKAHPHOBA()
	{
		DCNJHKGHKFJ = false;
	}
}
