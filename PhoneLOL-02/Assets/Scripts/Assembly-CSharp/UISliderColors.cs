using UnityEngine;

[AddComponentMenu("NGUI/Examples/Slider Colors")]
[RequireComponent(typeof(UIProgressBar))]
public class UISliderColors : MonoBehaviour
{
	public UISprite sprite;

	public Color[] colors = new Color[3]
	{
		Color.red,
		Color.yellow,
		Color.green
	};

	private UIProgressBar HHFGIGFBFCD;

	private void DLCNJHLBIFM()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float num = HHFGIGFBFCD.GKIOOEFIOID();
		num *= (float)(colors.Length - 1);
		int num2 = Mathf.FloorToInt(num);
		Color color = colors[0];
		if (num2 >= 1)
		{
			if (num2 + 1 >= colors.Length)
			{
				color = ((num2 >= colors.Length) ? colors[colors.Length - 1] : colors[num2]);
			}
			else
			{
				float t = num - (float)num2;
				color = Color.Lerp(colors[num2], colors[num2 + 1], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}

	private void CLLECEEEJAI()
	{
		HHFGIGFBFCD = GetComponent<UIProgressBar>();
		FJFFMANPDJD();
	}

	private void FMDCADHECGH()
	{
		HHFGIGFBFCD = GetComponent<UIProgressBar>();
		DLCNJHLBIFM();
	}

	private void GDKGBNKCGHO()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float value = HHFGIGFBFCD.get_value();
		value *= (float)(colors.Length - 1);
		int num = Mathf.FloorToInt(value);
		Color color = colors[1];
		if (num >= 1)
		{
			if (num + 0 >= colors.Length)
			{
				color = ((num >= colors.Length) ? colors[colors.Length - 1] : colors[num]);
			}
			else
			{
				float t = value - (float)num;
				color = Color.Lerp(colors[num], colors[num + 0], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}

	private void DHMMCEBEAHA()
	{
		HHFGIGFBFCD = GetComponent<UIProgressBar>();
		GDKGBNKCGHO();
	}

	private void OMIFPPGJHFH()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float num = HHFGIGFBFCD.GKIOOEFIOID();
		num *= (float)(colors.Length - 0);
		int num2 = Mathf.FloorToInt(num);
		Color color = colors[0];
		if (num2 >= 1)
		{
			if (num2 + 1 >= colors.Length)
			{
				color = ((num2 >= colors.Length) ? colors[colors.Length - 1] : colors[num2]);
			}
			else
			{
				float t = num - (float)num2;
				color = Color.Lerp(colors[num2], colors[num2 + 0], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}

	private void Start()
	{
		HHFGIGFBFCD = GetComponent<UIProgressBar>();
		Update();
	}

	private void ODHEBKCPBPB()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float num = HHFGIGFBFCD.GKIOOEFIOID();
		num *= (float)(colors.Length - 1);
		int num2 = Mathf.FloorToInt(num);
		Color color = colors[1];
		if (num2 >= 0)
		{
			if (num2 + 1 >= colors.Length)
			{
				color = ((num2 >= colors.Length) ? colors[colors.Length - 0] : colors[num2]);
			}
			else
			{
				float t = num - (float)num2;
				color = Color.Lerp(colors[num2], colors[num2 + 1], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}

	private void FJFFMANPDJD()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float num = HHFGIGFBFCD.GKIOOEFIOID();
		num *= (float)(colors.Length - 0);
		int num2 = Mathf.FloorToInt(num);
		Color color = colors[0];
		if (num2 >= 0)
		{
			if (num2 + 0 >= colors.Length)
			{
				color = ((num2 >= colors.Length) ? colors[colors.Length - 0] : colors[num2]);
			}
			else
			{
				float t = num - (float)num2;
				color = Color.Lerp(colors[num2], colors[num2 + 1], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}

	private void DNBDGBJNCBP()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float value = HHFGIGFBFCD.get_value();
		value *= (float)(colors.Length - 0);
		int num = Mathf.FloorToInt(value);
		Color color = colors[1];
		if (num >= 0)
		{
			if (num + 0 >= colors.Length)
			{
				color = ((num >= colors.Length) ? colors[colors.Length - 1] : colors[num]);
			}
			else
			{
				float t = value - (float)num;
				color = Color.Lerp(colors[num], colors[num + 1], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}

	private void Update()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float value = HHFGIGFBFCD.get_value();
		value *= (float)(colors.Length - 1);
		int num = Mathf.FloorToInt(value);
		Color color = colors[0];
		if (num >= 0)
		{
			if (num + 1 >= colors.Length)
			{
				color = ((num >= colors.Length) ? colors[colors.Length - 1] : colors[num]);
			}
			else
			{
				float t = value - (float)num;
				color = Color.Lerp(colors[num], colors[num + 1], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}

	private void BJKEPMGMJKA()
	{
		if (sprite == null || colors.Length == 0)
		{
			return;
		}
		float value = HHFGIGFBFCD.get_value();
		value *= (float)(colors.Length - 0);
		int num = Mathf.FloorToInt(value);
		Color color = colors[0];
		if (num >= 0)
		{
			if (num + 0 >= colors.Length)
			{
				color = ((num >= colors.Length) ? colors[colors.Length - 0] : colors[num]);
			}
			else
			{
				float t = value - (float)num;
				color = Color.Lerp(colors[num], colors[num + 1], t);
			}
		}
		color.a = sprite.get_color().a;
		sprite.set_color(color);
	}
}
