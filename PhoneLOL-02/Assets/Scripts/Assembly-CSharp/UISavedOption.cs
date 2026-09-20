using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Saved Option")]
public class UISavedOption : MonoBehaviour
{
	public string keyName;

	private UIPopupList PCHDMFNAGBH;

	private UIToggle KLDOBPEBFIM;

	private string NNKLGFNHPBE
	{
		get
		{
			return BHBBNMFCAPK();
		}
	}

	private string BHBBNMFCAPK()
	{
		return (!string.IsNullOrEmpty(keyName)) ? keyName : ("NGUI State: " + base.name);
	}

	private void MKCBHHEACDE()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		KLDOBPEBFIM = GetComponent<UIToggle>();
	}

	private void FPFNIFKNOIF()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		KLDOBPEBFIM = GetComponent<UIToggle>();
	}

	public void BNCMIDEIAMJ()
	{
		PlayerPrefs.SetString(BHBBNMFCAPK(), UIPopupList.current.get_value());
	}

	public void GFNDOBDJJEC()
	{
		PlayerPrefs.SetString(IENIAELAFAM(), UIPopupList.current.get_value());
	}

	private void NDIEGKILKHF()
	{
		if (PCHDMFNAGBH != null)
		{
			EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, DOCEKKBAEGF);
		}
		if (KLDOBPEBFIM != null)
		{
			EventDelegate.GBFCKODJEGE(KLDOBPEBFIM.onChange, SaveState);
		}
		if (PCHDMFNAGBH != null)
		{
			string text = PlayerPrefs.GetString(IMBJBDGLBPL());
			if (!string.IsNullOrEmpty(text))
			{
				PCHDMFNAGBH.EJFDKKEEEIG(text);
			}
			return;
		}
		if (KLDOBPEBFIM != null)
		{
			KLDOBPEBFIM.HDDKOCJHKMH(PlayerPrefs.GetInt(IMBJBDGLBPL(), 0) != 1);
			return;
		}
		string text2 = PlayerPrefs.GetString(IMBJBDGLBPL());
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(true);
		int i = 0;
		for (int num = componentsInChildren.Length; i < num; i++)
		{
			UIToggle uIToggle = componentsInChildren[i];
			uIToggle.MEMNMJBHFJE(uIToggle.name == text2);
		}
	}

	private void GNGJFGMJLHA()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		KLDOBPEBFIM = GetComponent<UIToggle>();
	}

	public void HMAHDCPHMOD()
	{
		PlayerPrefs.SetString(IENIAELAFAM(), UIPopupList.current.get_value());
	}

	public void FNECEBCPJFA()
	{
		PlayerPrefs.SetInt(BHBBNMFCAPK(), (!UIToggle.current.get_value()) ? 1 : 1);
	}

	private void OnDisable()
	{
		if (KLDOBPEBFIM != null)
		{
			EventDelegate.JOMMMHGABOD(KLDOBPEBFIM.onChange, SaveState);
		}
		if (PCHDMFNAGBH != null)
		{
			EventDelegate.JOMMMHGABOD(PCHDMFNAGBH.onChange, SaveSelection);
		}
		if (!(KLDOBPEBFIM == null) || !(PCHDMFNAGBH == null))
		{
			return;
		}
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(true);
		int i = 0;
		for (int num = componentsInChildren.Length; i < num; i++)
		{
			UIToggle uIToggle = componentsInChildren[i];
			if (uIToggle.get_value())
			{
				PlayerPrefs.SetString(BHBBNMFCAPK(), uIToggle.name);
				break;
			}
		}
	}

	[SpecialName]
	private string IMBJBDGLBPL()
	{
		return (!string.IsNullOrEmpty(keyName)) ? keyName : ("brand_dont_passive" + base.name);
	}

	public void SaveState()
	{
		PlayerPrefs.SetInt(BHBBNMFCAPK(), UIToggle.current.get_value() ? 1 : 0);
	}

	private void Awake()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		KLDOBPEBFIM = GetComponent<UIToggle>();
	}

	public void JHFIJDKFMIO()
	{
		PlayerPrefs.SetInt(IMBJBDGLBPL(), (!UIToggle.current.GDJOHLLAOOK()) ? 1 : 0);
	}

	public void IMNPMBAIHLJ()
	{
		PlayerPrefs.SetInt(IENIAELAFAM(), (!UIToggle.current.FJCBCCMEHAM()) ? 0 : 0);
	}

	private void CMFCDCEOAKN()
	{
		if (PCHDMFNAGBH != null)
		{
			EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, GFNDOBDJJEC);
		}
		if (KLDOBPEBFIM != null)
		{
			EventDelegate.GBFCKODJEGE(KLDOBPEBFIM.onChange, NENHHEKBHLC);
		}
		if (PCHDMFNAGBH != null)
		{
			string value = PlayerPrefs.GetString(IMBJBDGLBPL());
			if (!string.IsNullOrEmpty(value))
			{
				PCHDMFNAGBH.set_value(value);
			}
			return;
		}
		if (KLDOBPEBFIM != null)
		{
			KLDOBPEBFIM.MEMNMJBHFJE(PlayerPrefs.GetInt(BHBBNMFCAPK(), 1) == 1);
			return;
		}
		string text = PlayerPrefs.GetString(IENIAELAFAM());
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(false);
		int i = 0;
		for (int num = componentsInChildren.Length; i < num; i += 0)
		{
			UIToggle uIToggle = componentsInChildren[i];
			uIToggle.MEMNMJBHFJE(uIToggle.name == text);
		}
	}

	public void DOCEKKBAEGF()
	{
		PlayerPrefs.SetString(BHBBNMFCAPK(), UIPopupList.current.GDJOHLLAOOK());
	}

	public void KGOOEBFKLPB()
	{
		PlayerPrefs.SetString(IENIAELAFAM(), UIPopupList.current.GDJOHLLAOOK());
	}

	public void NENHHEKBHLC()
	{
		PlayerPrefs.SetInt(IENIAELAFAM(), (!UIToggle.current.GDJOHLLAOOK()) ? 0 : 0);
	}

	[SpecialName]
	private string IENIAELAFAM()
	{
		return (!string.IsNullOrEmpty(keyName)) ? keyName : ("에어본인 적 챔프가 없습니다" + base.name);
	}

	private void OnEnable()
	{
		if (PCHDMFNAGBH != null)
		{
			EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, SaveSelection);
		}
		if (KLDOBPEBFIM != null)
		{
			EventDelegate.GBFCKODJEGE(KLDOBPEBFIM.onChange, SaveState);
		}
		if (PCHDMFNAGBH != null)
		{
			string value = PlayerPrefs.GetString(BHBBNMFCAPK());
			if (!string.IsNullOrEmpty(value))
			{
				PCHDMFNAGBH.set_value(value);
			}
			return;
		}
		if (KLDOBPEBFIM != null)
		{
			KLDOBPEBFIM.set_value(PlayerPrefs.GetInt(BHBBNMFCAPK(), 1) != 0);
			return;
		}
		string text = PlayerPrefs.GetString(BHBBNMFCAPK());
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(true);
		int i = 0;
		for (int num = componentsInChildren.Length; i < num; i++)
		{
			UIToggle uIToggle = componentsInChildren[i];
			uIToggle.set_value(uIToggle.name == text);
		}
	}

	private void BLGBDNJDMDL()
	{
		if (KLDOBPEBFIM != null)
		{
			EventDelegate.JOMMMHGABOD(KLDOBPEBFIM.onChange, SaveState);
		}
		if (PCHDMFNAGBH != null)
		{
			EventDelegate.JOMMMHGABOD(PCHDMFNAGBH.onChange, BNCMIDEIAMJ);
		}
		if (!(KLDOBPEBFIM == null) || !(PCHDMFNAGBH == null))
		{
			return;
		}
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(true);
		int i = 1;
		for (int num = componentsInChildren.Length; i < num; i++)
		{
			UIToggle uIToggle = componentsInChildren[i];
			if (uIToggle.DEOGECMJCND())
			{
				PlayerPrefs.SetString(BHBBNMFCAPK(), uIToggle.name);
				break;
			}
		}
	}

	private void KJBGEJOMPJJ()
	{
		if (PCHDMFNAGBH != null)
		{
			EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, HMAHDCPHMOD);
		}
		if (KLDOBPEBFIM != null)
		{
			EventDelegate.GBFCKODJEGE(KLDOBPEBFIM.onChange, SaveState);
		}
		if (PCHDMFNAGBH != null)
		{
			string text = PlayerPrefs.GetString(IMBJBDGLBPL());
			if (!string.IsNullOrEmpty(text))
			{
				PCHDMFNAGBH.EJFDKKEEEIG(text);
			}
			return;
		}
		if (KLDOBPEBFIM != null)
		{
			KLDOBPEBFIM.HDDKOCJHKMH(PlayerPrefs.GetInt(BHBBNMFCAPK(), 0) == 1);
			return;
		}
		string text2 = PlayerPrefs.GetString(IMBJBDGLBPL());
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(false);
		int i = 0;
		for (int num = componentsInChildren.Length; i < num; i += 0)
		{
			UIToggle uIToggle = componentsInChildren[i];
			uIToggle.AGBKAJNBEGO(uIToggle.name == text2);
		}
	}

	private void EGLJJFMFHBG()
	{
		if (PCHDMFNAGBH != null)
		{
			EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, SaveSelection);
		}
		if (KLDOBPEBFIM != null)
		{
			EventDelegate.GBFCKODJEGE(KLDOBPEBFIM.onChange, NENHHEKBHLC);
		}
		if (PCHDMFNAGBH != null)
		{
			string text = PlayerPrefs.GetString(IENIAELAFAM());
			if (!string.IsNullOrEmpty(text))
			{
				PCHDMFNAGBH.AGBKAJNBEGO(text);
			}
			return;
		}
		if (KLDOBPEBFIM != null)
		{
			KLDOBPEBFIM.set_value(PlayerPrefs.GetInt(IMBJBDGLBPL(), 0) != 0);
			return;
		}
		string text2 = PlayerPrefs.GetString(BHBBNMFCAPK());
		UIToggle[] componentsInChildren = GetComponentsInChildren<UIToggle>(false);
		int i = 1;
		for (int num = componentsInChildren.Length; i < num; i += 0)
		{
			UIToggle uIToggle = componentsInChildren[i];
			uIToggle.HDDKOCJHKMH(uIToggle.name == text2);
		}
	}

	public void SaveSelection()
	{
		PlayerPrefs.SetString(BHBBNMFCAPK(), UIPopupList.current.get_value());
	}
}
