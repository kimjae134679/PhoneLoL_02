using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Sound Volume")]
[RequireComponent(typeof(UISlider))]
public class UISoundVolume : MonoBehaviour
{
	private UISlider EFNMLBDGJKH;

	private void LPDECCDKODG()
	{
		NLDABIMKKMP.FMEJHPOLPEK(UIProgressBar.current.BMOPKBJOAGE());
	}

	private void PDEKJHLCJHM()
	{
		EFNMLBDGJKH = GetComponent<UISlider>();
		EFNMLBDGJKH.set_value(NLDABIMKKMP.KOIEJCDNKKJ());
		EventDelegate.GBFCKODJEGE(EFNMLBDGJKH.onChange, LPDECCDKODG);
	}

	private void PCFCEAOOAEE()
	{
		EFNMLBDGJKH = GetComponent<UISlider>();
		EFNMLBDGJKH.ICKFKDNHDOG(NLDABIMKKMP.KOIEJCDNKKJ());
		EventDelegate.GBFCKODJEGE(EFNMLBDGJKH.onChange, KHKEHIBGBPF);
	}

	private void MJJONHKKFBG()
	{
		NLDABIMKKMP.FMEJHPOLPEK(UIProgressBar.current.get_value());
	}

	private void NOEHLDLICEA()
	{
		NLDABIMKKMP.FMEJHPOLPEK(UIProgressBar.current.BMOPKBJOAGE());
	}

	private void Awake()
	{
		EFNMLBDGJKH = GetComponent<UISlider>();
		EFNMLBDGJKH.set_value(NLDABIMKKMP.KOIEJCDNKKJ());
		EventDelegate.GBFCKODJEGE(EFNMLBDGJKH.onChange, KHKEHIBGBPF);
	}

	private void KHKEHIBGBPF()
	{
		NLDABIMKKMP.FMEJHPOLPEK(UIProgressBar.current.get_value());
	}

	private void HCOEIEEONIO()
	{
		NLDABIMKKMP.FMEJHPOLPEK(UIProgressBar.current.get_value());
	}

	private void GONLJAHAEBB()
	{
		EFNMLBDGJKH = GetComponent<UISlider>();
		EFNMLBDGJKH.set_value(NLDABIMKKMP.KOIEJCDNKKJ());
		EventDelegate.GBFCKODJEGE(EFNMLBDGJKH.onChange, MJJONHKKFBG);
	}

	private void BHAMHNJNALK()
	{
		NLDABIMKKMP.FMEJHPOLPEK(UIProgressBar.current.BMOPKBJOAGE());
	}

	private void DFOCLGJGFEF()
	{
		NLDABIMKKMP.FMEJHPOLPEK(UIProgressBar.current.get_value());
	}

	private void CFJKHPNIODE()
	{
		EFNMLBDGJKH = GetComponent<UISlider>();
		EFNMLBDGJKH.ICKFKDNHDOG(NLDABIMKKMP.KOIEJCDNKKJ());
		EventDelegate.GBFCKODJEGE(EFNMLBDGJKH.onChange, KHKEHIBGBPF);
	}
}
