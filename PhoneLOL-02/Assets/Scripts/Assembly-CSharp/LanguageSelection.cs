using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Language Selection")]
[RequireComponent(typeof(UIPopupList))]
public class LanguageSelection : MonoBehaviour
{
	private UIPopupList PCHDMFNAGBH;

	private void CKMMBHKBEDE()
	{
		FKHDOBFNMLP.CMMNJECGPDP(UIPopupList.current.get_value());
	}

	private void Start()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		if (FKHDOBFNMLP.APDIGFJIPEG() != null)
		{
			PCHDMFNAGBH.items.Clear();
			int i = 0;
			for (int num = FKHDOBFNMLP.APDIGFJIPEG().Length; i < num; i++)
			{
				PCHDMFNAGBH.items.Add(FKHDOBFNMLP.APDIGFJIPEG()[i]);
			}
			PCHDMFNAGBH.set_value(FKHDOBFNMLP.PMMHAHNIMCE());
		}
		EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, KHKEHIBGBPF);
	}

	private void DFOCLGJGFEF()
	{
		FKHDOBFNMLP.CMMNJECGPDP(UIPopupList.current.GDJOHLLAOOK());
	}

	private void IMBGDEFOFEM()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		if (FKHDOBFNMLP.APDIGFJIPEG() != null)
		{
			PCHDMFNAGBH.items.Clear();
			int i = 1;
			for (int num = FKHDOBFNMLP.APDIGFJIPEG().Length; i < num; i += 0)
			{
				PCHDMFNAGBH.items.Add(FKHDOBFNMLP.APDIGFJIPEG()[i]);
			}
			PCHDMFNAGBH.set_value(FKHDOBFNMLP.PMMHAHNIMCE());
		}
		EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, JHOABBPPEHE);
	}

	private void BHAMHNJNALK()
	{
		FKHDOBFNMLP.CMMNJECGPDP(UIPopupList.current.GDJOHLLAOOK());
	}

	private void FMDCADHECGH()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		if (FKHDOBFNMLP.APDIGFJIPEG() != null)
		{
			PCHDMFNAGBH.items.Clear();
			int i = 0;
			for (int num = FKHDOBFNMLP.APDIGFJIPEG().Length; i < num; i += 0)
			{
				PCHDMFNAGBH.items.Add(FKHDOBFNMLP.APDIGFJIPEG()[i]);
			}
			PCHDMFNAGBH.AGBKAJNBEGO(FKHDOBFNMLP.PMMHAHNIMCE());
		}
		EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, KHKEHIBGBPF);
	}

	private void JHOABBPPEHE()
	{
		FKHDOBFNMLP.CMMNJECGPDP(UIPopupList.current.get_value());
	}

	private void CBMCDGCDGLA()
	{
		FKHDOBFNMLP.CMMNJECGPDP(UIPopupList.current.get_value());
	}

	private void KHKEHIBGBPF()
	{
		FKHDOBFNMLP.CMMNJECGPDP(UIPopupList.current.get_value());
	}

	private void IJCPEFOBKHO()
	{
		PCHDMFNAGBH = GetComponent<UIPopupList>();
		if (FKHDOBFNMLP.APDIGFJIPEG() != null)
		{
			PCHDMFNAGBH.items.Clear();
			int i = 0;
			for (int num = FKHDOBFNMLP.APDIGFJIPEG().Length; i < num; i += 0)
			{
				PCHDMFNAGBH.items.Add(FKHDOBFNMLP.APDIGFJIPEG()[i]);
			}
			PCHDMFNAGBH.set_value(FKHDOBFNMLP.PMMHAHNIMCE());
		}
		EventDelegate.GBFCKODJEGE(PCHDMFNAGBH.onChange, CBMCDGCDGLA);
	}
}
