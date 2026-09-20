using System;
using UnityEngine;

public class UIPointMark : MonoBehaviour
{
	public delegate bool NNEKJIGPBPN();

	[NonSerialized]
	public NNEKJIGPBPN m_toggleDelegate;

	private UISprite JODJELEPINJ;

	private void DEFLIOMCCMA()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}

	private void DBLCOCKIFPE()
	{
	}

	private void OnDisable()
	{
	}

	private void Start()
	{
		Refresh();
	}

	private void PEIFAOJLDMD()
	{
	}

	private void CLLECEEEJAI()
	{
		Refresh();
	}

	private void OnEnable()
	{
		Refresh();
	}

	private void BKEKAJHABGK()
	{
	}

	private void ADLKMGPNJPA()
	{
		Refresh();
	}

	private void Refresh()
	{
		if (JODJELEPINJ == null)
		{
			JODJELEPINJ = GetComponent<UISprite>();
		}
		if (m_toggleDelegate != null)
		{
			JODJELEPINJ.enabled = m_toggleDelegate();
		}
	}

	private void GOLOMEGDPAH()
	{
	}

	private void GPFPLFJCNOL()
	{
	}

	private void BJKEPMGMJKA()
	{
	}

	private void Update()
	{
	}

	private void Awake()
	{
		JODJELEPINJ = GetComponent<UISprite>();
	}
}
