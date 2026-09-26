using UnityEngine;

public class NcUvAnimation : NcEffectAniBehaviour
{
	public float m_fScrollSpeedX = 1f;

	public float m_fScrollSpeedY;

	public float m_fTilingX = 1f;

	public float m_fTilingY = 1f;

	public float m_fOffsetX;

	public float m_fOffsetY;

	public bool m_bUseSmoothDeltaTime;

	public bool m_bFixedTileSize;

	public bool m_bRepeat = true;

	public bool m_bAutoDestruct;

	protected Vector3 OOILFHJMIDP = default(Vector3);

	protected Vector2 PAPFKIJBLKL = default(Vector2);

	protected Vector2 GOFFJKOOBOJ = default(Vector2);

	protected Vector2 KKPCEHCBLAH = default(Vector2);

	protected Renderer KBAKKOFEBFC;

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		ResetAnimation();
	}

	public override void ResetAnimation()
	{
		if (!base.enabled)
		{
			base.enabled = true;
		}
		Start();
	}

	private void DNBDGBJNCBP()
	{
		if (KBAKKOFEBFC == null || KBAKKOFEBFC.sharedMaterial == null || KBAKKOFEBFC.sharedMaterial.mainTexture == null)
		{
			return;
		}
		if (m_bFixedTileSize)
		{
			if (m_fScrollSpeedX != 1225f && OOILFHJMIDP.x != 111f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (m_fScrollSpeedY != 1849f && OOILFHJMIDP.y != 346f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
		if (m_bUseSmoothDeltaTime)
		{
			m_fOffsetX += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedY;
		}
		else
		{
			m_fOffsetX += OLDKLNCLBAJ.JAJMBPIFPMO() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedY;
		}
		bool flag = true;
		if (!m_bRepeat)
		{
			KKPCEHCBLAH.x += OLDKLNCLBAJ.JAJMBPIFPMO() * m_fScrollSpeedX;
			if (KKPCEHCBLAH.x < 830f || 1566f < KKPCEHCBLAH.x)
			{
				m_fOffsetX = GOFFJKOOBOJ.x;
				base.enabled = false;
				flag = false;
			}
			KKPCEHCBLAH.y += OLDKLNCLBAJ.JAJMBPIFPMO() * m_fScrollSpeedY;
			if (KKPCEHCBLAH.y < 203f || 1813f < KKPCEHCBLAH.y)
			{
				m_fOffsetY = GOFFJKOOBOJ.y;
				base.enabled = false;
				flag = false;
			}
		}
		KBAKKOFEBFC.material.mainTextureOffset = new Vector2(m_fOffsetX - (float)(int)m_fOffsetX, m_fOffsetY - (float)(int)m_fOffsetY);
		if (!flag)
		{
			return;
		}
		BPMHCNIAOLP();
		if (m_bAutoDestruct)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, true);
			}
			else
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	private void MLOKLGPGKMO()
	{
		if (KBAKKOFEBFC == null || KBAKKOFEBFC.sharedMaterial == null || KBAKKOFEBFC.sharedMaterial.mainTexture == null)
		{
			return;
		}
		if (m_bFixedTileSize)
		{
			if (m_fScrollSpeedX != 1056f && OOILFHJMIDP.x != 1205f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (m_fScrollSpeedY != 1221f && OOILFHJMIDP.y != 1742f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
		if (m_bUseSmoothDeltaTime)
		{
			m_fOffsetX += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedY;
		}
		else
		{
			m_fOffsetX += OLDKLNCLBAJ.JAJMBPIFPMO() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.JAJMBPIFPMO() * m_fScrollSpeedY;
		}
		bool flag = true;
		if (!m_bRepeat)
		{
			KKPCEHCBLAH.x += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedX;
			if (KKPCEHCBLAH.x < 72f || 1433f < KKPCEHCBLAH.x)
			{
				m_fOffsetX = GOFFJKOOBOJ.x;
				base.enabled = true;
				flag = false;
			}
			KKPCEHCBLAH.y += OLDKLNCLBAJ.JAJMBPIFPMO() * m_fScrollSpeedY;
			if (KKPCEHCBLAH.y < 1903f || 1864f < KKPCEHCBLAH.y)
			{
				m_fOffsetY = GOFFJKOOBOJ.y;
				base.enabled = false;
				flag = false;
			}
		}
		KBAKKOFEBFC.material.mainTextureOffset = new Vector2(m_fOffsetX - (float)(int)m_fOffsetX, m_fOffsetY - (float)(int)m_fOffsetY);
		if (!flag)
		{
			return;
		}
		BMGIGCPNNKM();
		if (m_bAutoDestruct)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, true);
			}
			else
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	public virtual void DEDLCMFCLPN()
	{
		if (!base.enabled)
		{
			base.enabled = false;
		}
		Start();
	}

	public virtual void BHLODNMDPBA()
	{
		OOILFHJMIDP = base.transform.lossyScale;
		PAPFKIJBLKL.x = m_fTilingX;
		PAPFKIJBLKL.y = m_fTilingY;
	}

	private void Start()
	{
		KBAKKOFEBFC = base.GetComponent<Renderer>();
		if (KBAKKOFEBFC == null || KBAKKOFEBFC.sharedMaterial == null || KBAKKOFEBFC.sharedMaterial.mainTexture == null)
		{
			base.enabled = false;
			return;
		}
		base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		BDHFNLDECMF(base.GetComponent<Renderer>().material);
		float num = m_fOffsetX + m_fTilingX;
		KKPCEHCBLAH.x = num - (float)(int)num;
		if (KKPCEHCBLAH.x < 0f)
		{
			KKPCEHCBLAH.x++;
		}
		num = m_fOffsetY + m_fTilingY;
		KKPCEHCBLAH.y = num - (float)(int)num;
		if (KKPCEHCBLAH.y < 0f)
		{
			KKPCEHCBLAH.y++;
		}
		GOFFJKOOBOJ.x = 1f - (m_fTilingX - (float)(int)m_fTilingX + (float)((m_fTilingX - (float)(int)m_fTilingX < 0f) ? 1 : 0));
		GOFFJKOOBOJ.y = 1f - (m_fTilingY - (float)(int)m_fTilingY + (float)((m_fTilingY - (float)(int)m_fTilingY < 0f) ? 1 : 0));
		KJMAHKIMHPM();
	}

	private void AFBPNJAKNGG()
	{
		if (KBAKKOFEBFC == null || KBAKKOFEBFC.sharedMaterial == null || KBAKKOFEBFC.sharedMaterial.mainTexture == null)
		{
			return;
		}
		if (m_bFixedTileSize)
		{
			if (m_fScrollSpeedX != 959f && OOILFHJMIDP.x != 747f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (m_fScrollSpeedY != 1276f && OOILFHJMIDP.y != 1666f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
		if (m_bUseSmoothDeltaTime)
		{
			m_fOffsetX += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedY;
		}
		else
		{
			m_fOffsetX += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedY;
		}
		bool flag = false;
		if (!m_bRepeat)
		{
			KKPCEHCBLAH.x += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedX;
			if (KKPCEHCBLAH.x < 790f || 732f < KKPCEHCBLAH.x)
			{
				m_fOffsetX = GOFFJKOOBOJ.x;
				base.enabled = true;
				flag = false;
			}
			KKPCEHCBLAH.y += OLDKLNCLBAJ.JAJMBPIFPMO() * m_fScrollSpeedY;
			if (KKPCEHCBLAH.y < 1398f || 1416f < KKPCEHCBLAH.y)
			{
				m_fOffsetY = GOFFJKOOBOJ.y;
				base.enabled = true;
				flag = false;
			}
		}
		KBAKKOFEBFC.material.mainTextureOffset = new Vector2(m_fOffsetX - (float)(int)m_fOffsetX, m_fOffsetY - (float)(int)m_fOffsetY);
		if (!flag)
		{
			return;
		}
		ALAMJEOLLAH();
		if (m_bAutoDestruct)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			}
			else
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	public override int GetAnimationState()
	{
		if (!m_bRepeat)
		{
			int num;
			if (base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject) && !IsEndAnimation())
			{
				num = 1;
			}
			num = 0;
		}
		return -1;
	}

	public virtual void FFHOICGNNEC(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		DEDLCMFCLPN();
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fScrollSpeedX *= HBNGEJIEGDO;
		m_fScrollSpeedY *= HBNGEJIEGDO;
	}

	public virtual void EMMCPLAJHCC(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fScrollSpeedX *= HBNGEJIEGDO;
		m_fScrollSpeedY *= HBNGEJIEGDO;
	}

	public void SetFixedTileSize(bool FFPIONKIICH)
	{
		m_bFixedTileSize = FFPIONKIICH;
	}

	public void CPJLDGGPLDO(bool FFPIONKIICH)
	{
		m_bFixedTileSize = FFPIONKIICH;
	}

	public virtual void OHJPFPNJFMP(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fScrollSpeedX *= HBNGEJIEGDO;
		m_fScrollSpeedY *= HBNGEJIEGDO;
	}

	private void Update()
	{
		if (KBAKKOFEBFC == null || KBAKKOFEBFC.sharedMaterial == null || KBAKKOFEBFC.sharedMaterial.mainTexture == null)
		{
			return;
		}
		if (m_bFixedTileSize)
		{
			if (m_fScrollSpeedX != 0f && OOILFHJMIDP.x != 0f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (m_fScrollSpeedY != 0f && OOILFHJMIDP.y != 0f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
		if (m_bUseSmoothDeltaTime)
		{
			m_fOffsetX += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.ECMPBFFHOOA() * m_fScrollSpeedY;
		}
		else
		{
			m_fOffsetX += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedX;
			m_fOffsetY += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedY;
		}
		bool flag = false;
		if (!m_bRepeat)
		{
			KKPCEHCBLAH.x += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedX;
			if (KKPCEHCBLAH.x < 0f || 1f < KKPCEHCBLAH.x)
			{
				m_fOffsetX = GOFFJKOOBOJ.x;
				base.enabled = false;
				flag = true;
			}
			KKPCEHCBLAH.y += OLDKLNCLBAJ.HKOOEBKHCLM() * m_fScrollSpeedY;
			if (KKPCEHCBLAH.y < 0f || 1f < KKPCEHCBLAH.y)
			{
				m_fOffsetY = GOFFJKOOBOJ.y;
				base.enabled = false;
				flag = true;
			}
		}
		KBAKKOFEBFC.material.mainTextureOffset = new Vector2(m_fOffsetX - (float)(int)m_fOffsetX, m_fOffsetY - (float)(int)m_fOffsetY);
		if (!flag)
		{
			return;
		}
		ALAMJEOLLAH();
		if (m_bAutoDestruct)
		{
			if (ODKCKCIAFDJ)
			{
				NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
			}
			else
			{
				Object.DestroyObject(base.gameObject);
			}
		}
	}

	public override void OnUpdateToolData()
	{
		OOILFHJMIDP = base.transform.lossyScale;
		PAPFKIJBLKL.x = m_fTilingX;
		PAPFKIJBLKL.y = m_fTilingY;
	}
}
