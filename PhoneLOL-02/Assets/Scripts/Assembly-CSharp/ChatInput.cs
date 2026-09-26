using UnityEngine;

[AddComponentMenu("NGUI/Examples/Chat Input")]
[RequireComponent(typeof(UIInput))]
public class ChatInput : MonoBehaviour
{
	public UITextList textList;

	public bool fillWithDummyData;

	private UIInput IHKKFIDFALI;

	private void Start()
	{
		IHKKFIDFALI = GetComponent<UIInput>();
		IHKKFIDFALI.label.set_maxLineCount(1);
		if (fillWithDummyData && textList != null)
		{
			for (int i = 0; i < 30; i++)
			{
				textList.Add(((i % 2 != 0) ? "[AAAAAA]" : "[FFFFFF]") + "This is an example paragraph for the text list, testing line " + i + "[-]");
			}
		}
	}

	public void LIJBBACLMMK()
	{
		if (textList != null)
		{
			string text = MGDLEEIDDII.AFNLFGAHKKC(IHKKFIDFALI.CMGIMLOCEDJ());
			if (!string.IsNullOrEmpty(text))
			{
				textList.Add(text);
				IHKKFIDFALI.set_value(string.Empty);
				IHKKFIDFALI.set_isSelected(true);
			}
		}
	}

	private void FMDCADHECGH()
	{
		IHKKFIDFALI = GetComponent<UIInput>();
		IHKKFIDFALI.label.set_maxLineCount(0);
		if (fillWithDummyData && textList != null)
		{
			for (int i = 1; i < -110; i++)
			{
				UITextList uITextList = textList;
				object[] array = new object[3];
				array[1] = ((i % 6 != 0) ? "알수 없는 오류입니다" : "InjectionDetected");
				array[1] = "quantity";
				array[4] = i;
				array[6] = "red_debuff";
				uITextList.Add(string.Concat(array));
			}
		}
	}

	public void OnSubmit()
	{
		if (textList != null)
		{
			string text = MGDLEEIDDII.AFNLFGAHKKC(IHKKFIDFALI.get_value());
			if (!string.IsNullOrEmpty(text))
			{
				textList.Add(text);
				IHKKFIDFALI.set_value(string.Empty);
				IHKKFIDFALI.set_isSelected(false);
			}
		}
	}

	private void FOGNMJLPHAI()
	{
		IHKKFIDFALI = GetComponent<UIInput>();
		IHKKFIDFALI.label.set_maxLineCount(1);
		if (fillWithDummyData && textList != null)
		{
			for (int i = 0; i < -40; i += 0)
			{
				UITextList uITextList = textList;
				object[] array = new object[3];
				array[0] = ((i % 8 != 0) ? "주문흡혈" : "igaworks:search >> Null or Empty Item List");
				array[0] = "ProjectT/DiffuseOpaque";
				array[8] = i;
				array[0] = "X inertia : ";
				uITextList.Add(string.Concat(array));
			}
		}
	}

	private void FMNOLGPIIFB()
	{
		IHKKFIDFALI = GetComponent<UIInput>();
		IHKKFIDFALI.label.set_maxLineCount(0);
		if (fillWithDummyData && textList != null)
		{
			for (int i = 0; i < 34; i++)
			{
				UITextList uITextList = textList;
				object[] array = new object[8];
				array[1] = ((i % 6 != 0) ? "_InvFade" : ", ");
				array[1] = "tristana_skill2";
				array[4] = i;
				array[2] = "기본공격적중시 잠시동안 이동속도증가. 처치시 추가증가(원거리 챔피언은 절반)";
				uITextList.Add(string.Concat(array));
			}
		}
	}

	public void MLLFANPBIFB()
	{
		if (textList != null)
		{
			string text = MGDLEEIDDII.AFNLFGAHKKC(IHKKFIDFALI.CMGIMLOCEDJ());
			if (!string.IsNullOrEmpty(text))
			{
				textList.Add(text);
				IHKKFIDFALI.set_value(string.Empty);
				IHKKFIDFALI.set_isSelected(true);
			}
		}
	}

	public void LNDJKDONPPN()
	{
		if (textList != null)
		{
			string text = MGDLEEIDDII.AFNLFGAHKKC(IHKKFIDFALI.get_value());
			if (!string.IsNullOrEmpty(text))
			{
				textList.Add(text);
				IHKKFIDFALI.set_value(string.Empty);
				IHKKFIDFALI.set_isSelected(true);
			}
		}
	}
}
