using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PostProcessManager : MonoBehaviour
{
	public enum ACPICCBBPHF
	{
		SepiaTone = 0,
		Grayscale = 1,
		MotionBlur = 2,
		Twirl = 3,
		ScreenFade = 4,
		Shake = 5,
		Max = 6
	}

	private static PostProcessManager MLDPFDAHKHA;

	public Camera m_camera;

	private Dictionary<ACPICCBBPHF, BDDCLAMDMFB> CNCALKAKACA;

	private LinkedList<ACPICCBBPHF> AGPLDHOONAP;

	public static PostProcessManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public void JBAJPOANEAN()
	{
	}

	public void Disable(ACPICCBBPHF FBAGNJILEGD)
	{
		BDDCLAMDMFB value = null;
		if (CNCALKAKACA.TryGetValue(FBAGNJILEGD, out value))
		{
			value.HIGCLCKDNIB();
			CNCALKAKACA.Remove(FBAGNJILEGD);
		}
	}

	public void FLCHPCHHIDO(Color BEAKIPPBGAF, float JAAEPPOELOP, float MEGDEIKCOII)
	{
		ONLAAKAEAJG oNLAAKAEAJG;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.SepiaTone))
		{
			oNLAAKAEAJG = (ONLAAKAEAJG)CNCALKAKACA[ACPICCBBPHF.MotionBlur];
		}
		else
		{
			oNLAAKAEAJG = new ONLAAKAEAJG();
			CNCALKAKACA.Add(ACPICCBBPHF.Grayscale, oNLAAKAEAJG);
		}
		oNLAAKAEAJG.CHGEFAOHNCG = JAAEPPOELOP;
		oNLAAKAEAJG.OBEOKIDAIEE = BEAKIPPBGAF;
		oNLAAKAEAJG.AKABOPDIFFF = MEGDEIKCOII;
		oNLAAKAEAJG.MGOENKOOFLO();
	}

	public void EFEDDCDIDGH(float MEGDEIKCOII)
	{
	}

	public Behaviour NPGCCCPLDOC(string AEFKGAOFLPM)
	{
		return (Behaviour)m_camera.gameObject.GetComponent(AEFKGAOFLPM);
	}

	private void Awake()
	{
		CNCALKAKACA = new Dictionary<ACPICCBBPHF, BDDCLAMDMFB>();
		AGPLDHOONAP = new LinkedList<ACPICCBBPHF>();
	}

	public void EnableComponent(string AEFKGAOFLPM)
	{
		Behaviour behaviour = (Behaviour)m_camera.gameObject.GetComponent(AEFKGAOFLPM);
		if (!(behaviour == null))
		{
			behaviour.enabled = true;
		}
	}

	public void EnableScreenFade(Color BEAKIPPBGAF, float JAAEPPOELOP, float MEGDEIKCOII)
	{
		ONLAAKAEAJG oNLAAKAEAJG;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.ScreenFade))
		{
			oNLAAKAEAJG = (ONLAAKAEAJG)CNCALKAKACA[ACPICCBBPHF.ScreenFade];
		}
		else
		{
			oNLAAKAEAJG = new ONLAAKAEAJG();
			CNCALKAKACA.Add(ACPICCBBPHF.ScreenFade, oNLAAKAEAJG);
		}
		oNLAAKAEAJG.CHGEFAOHNCG = JAAEPPOELOP;
		oNLAAKAEAJG.OBEOKIDAIEE = BEAKIPPBGAF;
		oNLAAKAEAJG.AKABOPDIFFF = MEGDEIKCOII;
		oNLAAKAEAJG.MGOENKOOFLO();
	}

	[SpecialName]
	public static PostProcessManager NNOKCKOMICG()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(PostProcessManager)) as PostProcessManager;
			if (MLDPFDAHKHA == null)
			{
				Type[] array = new Type[0];
				array[1] = typeof(PostProcessManager);
				MLDPFDAHKHA = new GameObject("CreateSkill3Missile", array).GetComponent<PostProcessManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void EnableSepiaTone()
	{
	}

	public void EnableGrayscale()
	{
	}

	public void EnableMotionBlur()
	{
	}

	public void EnableTwirl(float MEGDEIKCOII)
	{
	}

	private void Update()
	{
		foreach (KeyValuePair<ACPICCBBPHF, BDDCLAMDMFB> item in CNCALKAKACA)
		{
			if (!item.Value.LPBLGFCPADD(Time.deltaTime))
			{
				AGPLDHOONAP.AddLast(item.Key);
			}
		}
		if (AGPLDHOONAP.Count <= 0)
		{
			return;
		}
		foreach (ACPICCBBPHF item2 in AGPLDHOONAP)
		{
			Disable(item2);
		}
		AGPLDHOONAP.Clear();
	}

	public static PostProcessManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(PostProcessManager)) as PostProcessManager;
			if (MLDPFDAHKHA == null)
			{
				MLDPFDAHKHA = new GameObject("PostProcessManager", typeof(PostProcessManager)).GetComponent<PostProcessManager>();
			}
		}
		return MLDPFDAHKHA;
	}

	public void KIKHBAFCKKE(Color BEAKIPPBGAF, float JAAEPPOELOP, float MEGDEIKCOII)
	{
		ONLAAKAEAJG oNLAAKAEAJG;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.ScreenFade))
		{
			oNLAAKAEAJG = (ONLAAKAEAJG)CNCALKAKACA[ACPICCBBPHF.SepiaTone];
		}
		else
		{
			oNLAAKAEAJG = new ONLAAKAEAJG();
			CNCALKAKACA.Add(ACPICCBBPHF.Shake, oNLAAKAEAJG);
		}
		oNLAAKAEAJG.CHGEFAOHNCG = JAAEPPOELOP;
		oNLAAKAEAJG.OBEOKIDAIEE = BEAKIPPBGAF;
		oNLAAKAEAJG.AKABOPDIFFF = MEGDEIKCOII;
		oNLAAKAEAJG.CMFCDCEOAKN();
	}

	public new Behaviour GetComponent(string AEFKGAOFLPM)
	{
		return (Behaviour)m_camera.gameObject.GetComponent(AEFKGAOFLPM);
	}

	private void GONOKFHGFOH()
	{
		CNCALKAKACA = new Dictionary<ACPICCBBPHF, BDDCLAMDMFB>();
		AGPLDHOONAP = new LinkedList<ACPICCBBPHF>();
	}

	public void OLJOBOEPDBM(Color BEAKIPPBGAF, float JAAEPPOELOP, float MEGDEIKCOII)
	{
		ONLAAKAEAJG oNLAAKAEAJG;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.MotionBlur))
		{
			oNLAAKAEAJG = (ONLAAKAEAJG)CNCALKAKACA[ACPICCBBPHF.Shake];
		}
		else
		{
			oNLAAKAEAJG = new ONLAAKAEAJG();
			CNCALKAKACA.Add(ACPICCBBPHF.Shake, oNLAAKAEAJG);
		}
		oNLAAKAEAJG.CHGEFAOHNCG = JAAEPPOELOP;
		oNLAAKAEAJG.OBEOKIDAIEE = BEAKIPPBGAF;
		oNLAAKAEAJG.AKABOPDIFFF = MEGDEIKCOII;
		oNLAAKAEAJG.MGOENKOOFLO();
	}

	public void DIIIPOPCLNL()
	{
	}

	public void NIBJCCJPKHO(string AEFKGAOFLPM)
	{
		Behaviour behaviour = (Behaviour)m_camera.gameObject.GetComponent(AEFKGAOFLPM);
		if (!(behaviour == null))
		{
			behaviour.enabled = false;
		}
	}

	public void FHEMKDIGPGD(Color BEAKIPPBGAF, float JAAEPPOELOP, float MEGDEIKCOII)
	{
		ONLAAKAEAJG oNLAAKAEAJG;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.Grayscale))
		{
			oNLAAKAEAJG = (ONLAAKAEAJG)CNCALKAKACA[ACPICCBBPHF.SepiaTone];
		}
		else
		{
			oNLAAKAEAJG = new ONLAAKAEAJG();
			CNCALKAKACA.Add(ACPICCBBPHF.Max, oNLAAKAEAJG);
		}
		oNLAAKAEAJG.CHGEFAOHNCG = JAAEPPOELOP;
		oNLAAKAEAJG.OBEOKIDAIEE = BEAKIPPBGAF;
		oNLAAKAEAJG.AKABOPDIFFF = MEGDEIKCOII;
		oNLAAKAEAJG.CMFCDCEOAKN();
	}

	private bool DMEPNLCJIOI(ACPICCBBPHF FBAGNJILEGD)
	{
		return CNCALKAKACA.ContainsKey(FBAGNJILEGD);
	}

	public void ALMKPPJPIDL(float PJJFCGMEIFE, float HBNDHMPNCME)
	{
		GGLEKEOLHDE gGLEKEOLHDE;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.SepiaTone))
		{
			gGLEKEOLHDE = (GGLEKEOLHDE)CNCALKAKACA[ACPICCBBPHF.Max];
		}
		else
		{
			gGLEKEOLHDE = new GGLEKEOLHDE();
			CNCALKAKACA.Add(ACPICCBBPHF.MotionBlur, gGLEKEOLHDE);
		}
		gGLEKEOLHDE.KFKCHCJEFPK = PJJFCGMEIFE;
		gGLEKEOLHDE.CINKCJHCHAP = HBNDHMPNCME;
		gGLEKEOLHDE.MGOENKOOFLO();
	}

	public void CMEGPJMPFCD(Color BEAKIPPBGAF, float JAAEPPOELOP, float MEGDEIKCOII)
	{
		ONLAAKAEAJG oNLAAKAEAJG;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.ScreenFade))
		{
			oNLAAKAEAJG = (ONLAAKAEAJG)CNCALKAKACA[ACPICCBBPHF.Twirl];
		}
		else
		{
			oNLAAKAEAJG = new ONLAAKAEAJG();
			CNCALKAKACA.Add(ACPICCBBPHF.ScreenFade, oNLAAKAEAJG);
		}
		oNLAAKAEAJG.CHGEFAOHNCG = JAAEPPOELOP;
		oNLAAKAEAJG.OBEOKIDAIEE = BEAKIPPBGAF;
		oNLAAKAEAJG.AKABOPDIFFF = MEGDEIKCOII;
		oNLAAKAEAJG.CMFCDCEOAKN();
	}

	public void EnableShake(float PJJFCGMEIFE, float HBNDHMPNCME)
	{
		GGLEKEOLHDE gGLEKEOLHDE;
		if (CNCALKAKACA.ContainsKey(ACPICCBBPHF.Shake))
		{
			gGLEKEOLHDE = (GGLEKEOLHDE)CNCALKAKACA[ACPICCBBPHF.Shake];
		}
		else
		{
			gGLEKEOLHDE = new GGLEKEOLHDE();
			CNCALKAKACA.Add(ACPICCBBPHF.Shake, gGLEKEOLHDE);
		}
		gGLEKEOLHDE.KFKCHCJEFPK = PJJFCGMEIFE;
		gGLEKEOLHDE.CINKCJHCHAP = HBNDHMPNCME;
		gGLEKEOLHDE.MGOENKOOFLO();
	}

	public void DisableComponent(string AEFKGAOFLPM)
	{
		Behaviour behaviour = (Behaviour)m_camera.gameObject.GetComponent(AEFKGAOFLPM);
		if (!(behaviour == null))
		{
			behaviour.enabled = false;
		}
	}
}
