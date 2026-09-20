using UnityEngine;

public class NcAddForce : NcEffectBehaviour
{
	public Vector3 m_AddForce = new Vector3(0f, 300f, 0f);

	public Vector3 m_RandomRange = new Vector3(100f, 100f, 100f);

	public ForceMode m_ForceMode;

	private void KHFBKIFBHMN()
	{
		if (base.GetComponent<Rigidbody>() != null)
		{
			Vector3 force = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + m_AddForce.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + m_AddForce.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + m_AddForce.z);
			base.GetComponent<Rigidbody>().AddForce(force, m_ForceMode);
		}
	}

	private void INBEKOMFEOP()
	{
		if (base.GetComponent<Rigidbody>() != null)
		{
			Vector3 force = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + m_AddForce.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + m_AddForce.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + m_AddForce.z);
			base.GetComponent<Rigidbody>().AddForce(force, m_ForceMode);
		}
	}

	private void FMDCADHECGH()
	{
		if (base.enabled)
		{
			AIBOCNDOFFN();
		}
	}

	private void Start()
	{
		if (base.enabled)
		{
			KHFBKIFBHMN();
		}
	}

	private void PKFIFAMFLIJ()
	{
		if (base.GetComponent<Rigidbody>() != null)
		{
			Vector3 force = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + m_AddForce.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + m_AddForce.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + m_AddForce.z);
			base.GetComponent<Rigidbody>().AddForce(force, m_ForceMode);
		}
	}

	private void EKGLJIGHJLC()
	{
		if (base.GetComponent<Rigidbody>() != null)
		{
			Vector3 force = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + m_AddForce.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + m_AddForce.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + m_AddForce.z);
			base.GetComponent<Rigidbody>().AddForce(force, m_ForceMode);
		}
	}

	private void FOGNMJLPHAI()
	{
		if (base.enabled)
		{
			EKGLJIGHJLC();
		}
	}

	private void AIBOCNDOFFN()
	{
		if (base.GetComponent<Rigidbody>() != null)
		{
			Vector3 force = new Vector3(Random.Range(0f - m_RandomRange.x, m_RandomRange.x) + m_AddForce.x, Random.Range(0f - m_RandomRange.y, m_RandomRange.y) + m_AddForce.y, Random.Range(0f - m_RandomRange.z, m_RandomRange.z) + m_AddForce.z);
			base.GetComponent<Rigidbody>().AddForce(force, m_ForceMode);
		}
	}

	private void IJCPEFOBKHO()
	{
		if (base.enabled)
		{
			EKGLJIGHJLC();
		}
	}

	private void PAJOOFIAPMI()
	{
		if (base.enabled)
		{
			PKFIFAMFLIJ();
		}
	}
}
