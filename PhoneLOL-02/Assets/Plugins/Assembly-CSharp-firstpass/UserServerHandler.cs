using Nas;
using UnityEngine;

public class UserServerHandler : EventHandler
{
	public override void OnNASWallClose()
	{
		Debug.Log("OnNASWallClose");
	}
}
