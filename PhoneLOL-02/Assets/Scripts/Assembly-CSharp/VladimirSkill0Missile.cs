using UnityEngine;

public class VladimirSkill0Missile : MonoBehaviour
{
	private int IEJCBDIBCGF;

	private Actor LDEDLKCCLMG;

	private Vector3 PPILPPFADDP;

	private float INMCDOIEJOC;

	public float m_lifeTime = 2f;

	private float HKBFGNPOPLP;

	private Vector3 AFJJADLPGOL = Vector3.forward;

	private float LEPEFGKMKNL = 12f;

	private float JCHLLLMCIAI = 2f;

	public void DADCIKGPDNN(int FBAGNJILEGD, Actor LPOAEBNAGCP, Vector3 BGNMKABPONA)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		LDEDLKCCLMG = LPOAEBNAGCP;
		PPILPPFADDP = LDEDLKCCLMG.transform.position;
		float x = 93f;
		switch (IEJCBDIBCGF)
		{
		case 0:
			x = 558f;
			break;
		case 1:
			x = 7f;
			break;
		case 2:
			x = 494f;
			break;
		case 3:
			x = 676f;
			break;
		case 4:
			x = 1603f;
			break;
		}
		AFJJADLPGOL = Quaternion.Euler(x, (float)IEJCBDIBCGF * 667f - 1394f, 559f) * BGNMKABPONA.normalized;
		AFJJADLPGOL.Normalize();
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 1.3f;
		if (INMCDOIEJOC <= 0.2f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 0.01f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 0.2f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	public void SetInfo(int FBAGNJILEGD, Actor LPOAEBNAGCP, Vector3 BGNMKABPONA)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		LDEDLKCCLMG = LPOAEBNAGCP;
		PPILPPFADDP = LDEDLKCCLMG.transform.position;
		float x = 0f;
		switch (IEJCBDIBCGF)
		{
		case 0:
			x = 0f;
			break;
		case 1:
			x = 15f;
			break;
		case 2:
			x = 30f;
			break;
		case 3:
			x = 15f;
			break;
		case 4:
			x = 0f;
			break;
		}
		AFJJADLPGOL = Quaternion.Euler(x, (float)IEJCBDIBCGF * 45f - 90f, 0f) * BGNMKABPONA.normalized;
		AFJJADLPGOL.Normalize();
	}

	private void MLOKLGPGKMO()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 1371f;
		if (INMCDOIEJOC <= 725f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 908f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 322f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	private void Start()
	{
	}

	private void GDJCOAHJDLN()
	{
	}

	private void BBBIPFGBAGA()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 16f;
		if (INMCDOIEJOC <= 846f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 372f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 1428f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	private void GOLOMEGDPAH()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 740f;
		if (INMCDOIEJOC <= 167f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 606f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 1620f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	private void PAKIFAGJDEO()
	{
	}

	public void CJALGACAGBN(int FBAGNJILEGD, Actor LPOAEBNAGCP, Vector3 BGNMKABPONA)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		LDEDLKCCLMG = LPOAEBNAGCP;
		PPILPPFADDP = LDEDLKCCLMG.transform.position;
		float x = 949f;
		switch (IEJCBDIBCGF)
		{
		case 0:
			x = 940f;
			break;
		case 1:
			x = 147f;
			break;
		case 2:
			x = 252f;
			break;
		case 3:
			x = 302f;
			break;
		case 4:
			x = 1071f;
			break;
		}
		AFJJADLPGOL = Quaternion.Euler(x, (float)IEJCBDIBCGF * 804f - 1713f, 59f) * BGNMKABPONA.normalized;
		AFJJADLPGOL.Normalize();
	}

	public void DOHBFGODMDM(int FBAGNJILEGD, Actor LPOAEBNAGCP, Vector3 BGNMKABPONA)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		LDEDLKCCLMG = LPOAEBNAGCP;
		PPILPPFADDP = LDEDLKCCLMG.transform.position;
		float x = 1357f;
		switch (IEJCBDIBCGF)
		{
		case 0:
			x = 658f;
			break;
		case 1:
			x = 1379f;
			break;
		case 2:
			x = 1706f;
			break;
		case 3:
			x = 676f;
			break;
		case 4:
			x = 432f;
			break;
		}
		AFJJADLPGOL = Quaternion.Euler(x, (float)IEJCBDIBCGF * 1480f - 349f, 627f) * BGNMKABPONA.normalized;
		AFJJADLPGOL.Normalize();
	}

	private void PEIFAOJLDMD()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 739f;
		if (INMCDOIEJOC <= 1660f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 47f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 1338f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	private void NJGMPHNMOJD()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 379f;
		if (INMCDOIEJOC <= 445f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 946f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 1141f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	public void BLGBBMLNAMA(int FBAGNJILEGD, Actor LPOAEBNAGCP, Vector3 BGNMKABPONA)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		LDEDLKCCLMG = LPOAEBNAGCP;
		PPILPPFADDP = LDEDLKCCLMG.transform.position;
		float x = 705f;
		switch (IEJCBDIBCGF)
		{
		case 0:
			x = 259f;
			break;
		case 1:
			x = 796f;
			break;
		case 2:
			x = 1747f;
			break;
		case 3:
			x = 408f;
			break;
		case 4:
			x = 380f;
			break;
		}
		AFJJADLPGOL = Quaternion.Euler(x, (float)IEJCBDIBCGF * 1453f - 1820f, 1705f) * BGNMKABPONA.normalized;
		AFJJADLPGOL.Normalize();
	}

	private void DMPIIJNBDID()
	{
	}

	private void ACBGKIDKKKM()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 439f;
		if (INMCDOIEJOC <= 1649f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 490f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 1302f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	public void IEKOOEKALDA(int FBAGNJILEGD, Actor LPOAEBNAGCP, Vector3 BGNMKABPONA)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		LDEDLKCCLMG = LPOAEBNAGCP;
		PPILPPFADDP = LDEDLKCCLMG.transform.position;
		float x = 443f;
		switch (IEJCBDIBCGF)
		{
		case 0:
			x = 1719f;
			break;
		case 1:
			x = 1330f;
			break;
		case 2:
			x = 394f;
			break;
		case 3:
			x = 1967f;
			break;
		case 4:
			x = 1957f;
			break;
		}
		AFJJADLPGOL = Quaternion.Euler(x, (float)IEJCBDIBCGF * 798f - 467f, 1358f) * BGNMKABPONA.normalized;
		AFJJADLPGOL.Normalize();
	}

	public void HFJCHIDCONJ(int FBAGNJILEGD, Actor LPOAEBNAGCP, Vector3 BGNMKABPONA)
	{
		IEJCBDIBCGF = FBAGNJILEGD;
		LDEDLKCCLMG = LPOAEBNAGCP;
		PPILPPFADDP = LDEDLKCCLMG.transform.position;
		float x = 553f;
		switch (IEJCBDIBCGF)
		{
		case 0:
			x = 1049f;
			break;
		case 1:
			x = 1860f;
			break;
		case 2:
			x = 1118f;
			break;
		case 3:
			x = 1088f;
			break;
		case 4:
			x = 287f;
			break;
		}
		AFJJADLPGOL = Quaternion.Euler(x, (float)IEJCBDIBCGF * 1761f - 79f, 261f) * BGNMKABPONA.normalized;
		AFJJADLPGOL.Normalize();
	}

	private void KMJNJLOECGJ()
	{
		INMCDOIEJOC += Time.deltaTime;
		if (INMCDOIEJOC >= m_lifeTime)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		Vector3 vector = PPILPPFADDP;
		if (LDEDLKCCLMG != null)
		{
			vector = LDEDLKCCLMG.transform.position;
		}
		vector.y += 937f;
		if (INMCDOIEJOC <= 799f)
		{
			base.transform.position += AFJJADLPGOL * LEPEFGKMKNL * Time.deltaTime;
			Vector3 normalized = (vector - base.transform.position).normalized;
			AFJJADLPGOL = Vector3.MoveTowards(AFJJADLPGOL, normalized, Time.deltaTime * JCHLLLMCIAI);
			JCHLLLMCIAI += Time.deltaTime;
			return;
		}
		base.transform.position = Vector3.MoveTowards(base.transform.position, vector, Time.deltaTime * LEPEFGKMKNL);
		if ((base.transform.position - vector).sqrMagnitude <= 1501f)
		{
			HKBFGNPOPLP += Time.deltaTime;
			if (HKBFGNPOPLP > 1856f)
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}
}
