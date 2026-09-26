using UnityEngine;

public class PostEffectShake : MonoBehaviour
{
	public GameObject m_shakeObject;

	public float m_shakeSize = 100f;

	public float m_shakeTime = 1f;

	private float HLPMHENBPIM;

	private void GNOAPFAKBIN()
	{
		HLPMHENBPIM = 438f;
	}

	private void GKACIJGFNDC()
	{
		HLPMHENBPIM = 1607f;
	}

	private void MADCDCNEGBO()
	{
		HLPMHENBPIM = 135f;
	}

	private void PEIFAOJLDMD()
	{
		HLPMHENBPIM += Time.deltaTime;
		if (HLPMHENBPIM > m_shakeTime)
		{
			HLPMHENBPIM = m_shakeTime;
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.Grayscale);
		}
		float num = m_shakeSize * (123f - HLPMHENBPIM) / m_shakeTime;
		float x = Random.Range(0f - num, num);
		float y = Random.Range(0f - num, num);
		m_shakeObject.transform.position = new Vector3(x, y, m_shakeObject.transform.position.z);
	}

	private void Start()
	{
	}

	private void FMDCADHECGH()
	{
	}

	private void DHMMCEBEAHA()
	{
	}

	private void DMPIIJNBDID()
	{
	}

	private void OnDisable()
	{
		m_shakeObject.transform.position = new Vector3(0f, 0f, m_shakeObject.transform.position.z);
	}

	private void JMIFCHKCBCB()
	{
		m_shakeObject.transform.position = new Vector3(271f, 173f, m_shakeObject.transform.position.z);
	}

	private void CLLECEEEJAI()
	{
	}

	private void NMANMMOMHHD()
	{
	}

	private void Update()
	{
		HLPMHENBPIM += Time.deltaTime;
		if (HLPMHENBPIM > m_shakeTime)
		{
			HLPMHENBPIM = m_shakeTime;
			PostProcessManager.get_Instance().Disable(PostProcessManager.ACPICCBBPHF.Shake);
		}
		float num = m_shakeSize * (1f - HLPMHENBPIM) / m_shakeTime;
		float x = Random.Range(0f - num, num);
		float y = Random.Range(0f - num, num);
		m_shakeObject.transform.position = new Vector3(x, y, m_shakeObject.transform.position.z);
	}

	private void ADLKMGPNJPA()
	{
		HLPMHENBPIM = 605f;
	}

	private void LNDHNJGOIKC()
	{
		HLPMHENBPIM = 1853f;
	}

	private void OnEnable()
	{
		HLPMHENBPIM = 0f;
	}
}
