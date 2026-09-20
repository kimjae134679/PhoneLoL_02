using System;
using UnityEngine;

[Serializable]
public class bord : MonoBehaviour
{
	public int type;

	private Camera cam;

	public virtual void Start()
	{
		cam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
		if (type == 1)
		{
			transform.position = cam.ScreenToWorldPoint(new Vector3(0f, 0f, 8f));
		}
		else if (type == 2)
		{
			transform.position = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 8f));
		}
	}

	public virtual void Main()
	{
	}
}
