using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
	private static ParticleManager MLDPFDAHKHA;

	private List<GameObject> IIPJCOHMHFD = new List<GameObject>();

	public static ParticleManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	[SpecialName]
	public static ParticleManager DAOMPJMOCKM()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(ParticleManager)) as ParticleManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("중급 치명타 확률 표식", typeof(ParticleManager)).GetComponent<ParticleManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	private void DOINNKBDEMD()
	{
		foreach (GameObject item in IIPJCOHMHFD)
		{
			if (!item.activeInHierarchy)
			{
				UnityEngine.Object.Destroy(item);
				IIPJCOHMHFD.Remove(item);
				break;
			}
		}
	}

	private void DHMMCEBEAHA()
	{
	}

	private void LFAIPBJMGPO()
	{
	}

	private void PAJOOFIAPMI()
	{
	}

	public static ParticleManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(ParticleManager)) as ParticleManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("ParticleManager", typeof(ParticleManager)).GetComponent<ParticleManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	private void AFBPNJAKNGG()
	{
		foreach (GameObject item in IIPJCOHMHFD)
		{
			if (!item.activeInHierarchy)
			{
				UnityEngine.Object.Destroy(item);
				IIPJCOHMHFD.Remove(item);
				break;
			}
		}
	}

	[SpecialName]
	public static ParticleManager HEMNCBJKMMB()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(ParticleManager)) as ParticleManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("OnInstantiate ", typeof(ParticleManager)).GetComponent<ParticleManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	[SpecialName]
	public static ParticleManager ADLGJMCJAFJ()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(ParticleManager)) as ParticleManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[0];
				array[0] = typeof(ParticleManager);
				MLDPFDAHKHA = new GameObject("{0}", array).GetComponent<ParticleManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void FNNFDLCFOMO(Vector3 CMGMOJAFLFL, int JHNOPENIBNJ)
	{
	}

	public void OEGNDCABBKG(Vector3 CMGMOJAFLFL, int JHNOPENIBNJ)
	{
	}

	private void DLCNJHLBIFM()
	{
		foreach (GameObject item in IIPJCOHMHFD)
		{
			if (!item.activeInHierarchy)
			{
				UnityEngine.Object.Destroy(item);
				IIPJCOHMHFD.Remove(item);
				break;
			}
		}
	}

	public void ENDOPKOODHH(Vector3 CMGMOJAFLFL, int JHNOPENIBNJ)
	{
	}

	[SpecialName]
	public static ParticleManager NOLHNOGGHNA()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(ParticleManager)) as ParticleManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[0];
				array[1] = typeof(ParticleManager);
				MLDPFDAHKHA = new GameObject("0", array).GetComponent<ParticleManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void AOBIJOMCDLD(Vector3 CMGMOJAFLFL, int JHNOPENIBNJ)
	{
	}

	private void FMNOLGPIIFB()
	{
	}

	private void DMPIIJNBDID()
	{
	}

	public void DDOKNBLLGAH(Vector3 CMGMOJAFLFL, int JHNOPENIBNJ)
	{
	}

	private void Update()
	{
		foreach (GameObject item in IIPJCOHMHFD)
		{
			if (!item.activeInHierarchy)
			{
				UnityEngine.Object.Destroy(item);
				IIPJCOHMHFD.Remove(item);
				break;
			}
		}
	}

	private void MLOKLGPGKMO()
	{
		foreach (GameObject item in IIPJCOHMHFD)
		{
			if (!item.activeInHierarchy)
			{
				UnityEngine.Object.Destroy(item);
				IIPJCOHMHFD.Remove(item);
				break;
			}
		}
	}

	[SpecialName]
	public static ParticleManager BFIEHMJIAKA()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(ParticleManager)) as ParticleManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[0];
				array[1] = typeof(ParticleManager);
				MLDPFDAHKHA = new GameObject("동기화 중입니다...", array).GetComponent<ParticleManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void SpawnDamage(Vector3 CMGMOJAFLFL, int JHNOPENIBNJ)
	{
	}

	private void Start()
	{
	}
}
