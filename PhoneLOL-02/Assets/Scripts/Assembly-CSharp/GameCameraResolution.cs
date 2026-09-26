using System;
using UnityEngine;

[Serializable]
public class GameCameraResolution
{
	public enum EPEJMNPPLNB
	{
		None = 0,
		FitWidth = 1,
		FitHeight = 2,
		FitVisible = 3,
		StretchToFit = 4,
		PixelPerfectFit = 5
	}

	public enum DJEJPECIIHP
	{
		Constant = 0,
		Center = 1
	}

	public float scale = 1f;

	public Vector2 offsetPixels = new Vector2(0f, 0f);

	public EPEJMNPPLNB autoScaleMode = EPEJMNPPLNB.FitVisible;

	public DJEJPECIIHP fitMode = DJEJPECIIHP.Center;
}
