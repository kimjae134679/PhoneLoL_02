using UnityEngine;

public class NcTilingTexture : NcEffectBehaviour
{
	public float m_fTilingX = 2f;

	public float m_fTilingY = 2f;

	public float m_fOffsetX;

	public float m_fOffsetY;

	public bool m_bFixedTileSize;

	protected Vector3 OOILFHJMIDP = default(Vector3);

	protected Vector2 PAPFKIJBLKL = default(Vector2);

	private void MLOKLGPGKMO()
	{
		if (m_bFixedTileSize)
		{
			if (OOILFHJMIDP.x != 579f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (OOILFHJMIDP.y != 1858f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
	}

	public override void OnUpdateToolData()
	{
		OOILFHJMIDP = base.transform.lossyScale;
		PAPFKIJBLKL.x = m_fTilingX;
		PAPFKIJBLKL.y = m_fTilingY;
	}

	private void BBBIPFGBAGA()
	{
		if (m_bFixedTileSize)
		{
			if (OOILFHJMIDP.x != 1573f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (OOILFHJMIDP.y != 1068f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
	}

	public virtual void EOJABCMOAEL()
	{
		OOILFHJMIDP = base.transform.lossyScale;
		PAPFKIJBLKL.x = m_fTilingX;
		PAPFKIJBLKL.y = m_fTilingY;
	}

	private void GDKGBNKCGHO()
	{
		if (m_bFixedTileSize)
		{
			if (OOILFHJMIDP.x != 934f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (OOILFHJMIDP.y != 651f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
	}

	private void Start()
	{
		if (base.GetComponent<Renderer>() != null && base.GetComponent<Renderer>().material != null)
		{
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
			base.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(m_fOffsetX - (float)(int)m_fOffsetX, m_fOffsetY - (float)(int)m_fOffsetY);
			BDHFNLDECMF(base.GetComponent<Renderer>().material);
		}
	}

	private void IPFEBDCDMFA()
	{
		if (base.GetComponent<Renderer>() != null && base.GetComponent<Renderer>().material != null)
		{
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
			base.GetComponent<Renderer>().material.mainTextureOffset = new Vector2(m_fOffsetX - (float)(int)m_fOffsetX, m_fOffsetY - (float)(int)m_fOffsetY);
			BDHFNLDECMF(base.GetComponent<Renderer>().material);
		}
	}

	private void Update()
	{
		if (m_bFixedTileSize)
		{
			if (OOILFHJMIDP.x != 0f)
			{
				m_fTilingX = PAPFKIJBLKL.x * (base.transform.lossyScale.x / OOILFHJMIDP.x);
			}
			if (OOILFHJMIDP.y != 0f)
			{
				m_fTilingY = PAPFKIJBLKL.y * (base.transform.lossyScale.y / OOILFHJMIDP.y);
			}
			base.GetComponent<Renderer>().material.mainTextureScale = new Vector2(m_fTilingX, m_fTilingY);
		}
	}

	public virtual void ILAIHAPPKBI()
	{
		OOILFHJMIDP = base.transform.lossyScale;
		PAPFKIJBLKL.x = m_fTilingX;
		PAPFKIJBLKL.y = m_fTilingY;
	}
}
