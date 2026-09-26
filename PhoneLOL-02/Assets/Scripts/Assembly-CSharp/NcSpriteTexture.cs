using UnityEngine;

public class NcSpriteTexture : NcEffectBehaviour
{
	public GameObject m_NcSpriteFactoryPrefab;

	protected NcSpriteFactory DMDHBNHBACN;

	public NcSpriteFactory.NcFrameInfo[] m_NcSpriteFrameInfos;

	public float m_fUvScale = 1f;

	public int m_nSpriteFactoryIndex;

	public int m_nFrameIndex;

	public NcSpriteFactory.BBLOGHECHJG m_MeshType;

	public NcSpriteFactory.BGEMPPKCKFA m_AlignType = NcSpriteFactory.BGEMPPKCKFA.CENTER;

	public float m_fShowRate = 1f;

	protected GameObject FFCLOLNHAOC;

	public void SetSpriteFactoryIndex(string ADNCNHHHCBF, int FDOPNPLBJNA, bool JGANGICOOHE)
	{
		if (DMDHBNHBACN == null)
		{
			if (!m_NcSpriteFactoryPrefab || !(m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>() != null))
			{
				return;
			}
			DMDHBNHBACN = m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>();
		}
		m_nSpriteFactoryIndex = DMDHBNHBACN.GetSpriteNodeIndex(ADNCNHHHCBF);
		SetSpriteFactoryIndex(m_nSpriteFactoryIndex, FDOPNPLBJNA, JGANGICOOHE);
	}

	public void IHEAHAFLPAO(int IBDLGAOEJKH, int FDOPNPLBJNA, bool JGANGICOOHE)
	{
		if (ALDCMMKDLDF(IBDLGAOEJKH))
		{
			SetFrameIndex(FDOPNPLBJNA);
			if (JGANGICOOHE)
			{
				KJKHNAHJJAL(JGANGICOOHE);
			}
		}
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
	}

	public virtual void JECAJIKAOBN()
	{
	}

	public virtual void EDLDIEDIEAG(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
	}

	public void SetFrameIndex(int FDOPNPLBJNA)
	{
		m_nFrameIndex = ((0 > FDOPNPLBJNA) ? m_nFrameIndex : FDOPNPLBJNA);
		if (m_NcSpriteFrameInfos != null)
		{
			m_nFrameIndex = ((m_NcSpriteFrameInfos.Length != 0) ? ((m_NcSpriteFrameInfos.Length > m_nFrameIndex) ? m_nFrameIndex : (m_NcSpriteFrameInfos.Length - 1)) : 0);
		}
	}

	private void DEFLIOMCCMA()
	{
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = base.gameObject.GetComponent<MeshFilter>();
			if (HOAKNOENHHD == null)
			{
				HOAKNOENHHD = base.gameObject.AddComponent<MeshFilter>();
			}
		}
		if (m_NcSpriteFactoryPrefab == null && base.gameObject.GetComponent<NcSpriteFactory>() != null)
		{
			m_NcSpriteFactoryPrefab = base.gameObject;
		}
		NBLIIIBHKGG(m_nSpriteFactoryIndex);
	}

	public void SetSpriteFactoryIndex(int IBDLGAOEJKH, int FDOPNPLBJNA, bool JGANGICOOHE)
	{
		if (ALDCMMKDLDF(IBDLGAOEJKH))
		{
			SetFrameIndex(FDOPNPLBJNA);
			if (JGANGICOOHE)
			{
				KJKHNAHJJAL(JGANGICOOHE);
			}
		}
	}

	public void NINNJLPOIMJ(int FDOPNPLBJNA)
	{
		m_nFrameIndex = ((1 > FDOPNPLBJNA) ? m_nFrameIndex : FDOPNPLBJNA);
		if (m_NcSpriteFrameInfos != null)
		{
			m_nFrameIndex = ((m_NcSpriteFrameInfos.Length != 0) ? ((m_NcSpriteFrameInfos.Length > m_nFrameIndex) ? m_nFrameIndex : (m_NcSpriteFrameInfos.Length - 0)) : 0);
		}
	}

	private void Awake()
	{
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = base.gameObject.GetComponent<MeshFilter>();
			if (HOAKNOENHHD == null)
			{
				HOAKNOENHHD = base.gameObject.AddComponent<MeshFilter>();
			}
		}
		if (m_NcSpriteFactoryPrefab == null && base.gameObject.GetComponent<NcSpriteFactory>() != null)
		{
			m_NcSpriteFactoryPrefab = base.gameObject;
		}
		ALDCMMKDLDF(m_nSpriteFactoryIndex);
	}

	private void Start()
	{
		KJKHNAHJJAL(true);
	}

	public void SetShowRate(float IMILMILNLPD)
	{
		m_fShowRate = IMILMILNLPD;
		KJKHNAHJJAL(true);
	}

	public override void OnUpdateToolData()
	{
	}

	public void PPEAFDDLKBK(string ADNCNHHHCBF, int FDOPNPLBJNA, bool JGANGICOOHE)
	{
		if (DMDHBNHBACN == null)
		{
			if (!m_NcSpriteFactoryPrefab || !(m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>() != null))
			{
				return;
			}
			DMDHBNHBACN = m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>();
		}
		m_nSpriteFactoryIndex = DMDHBNHBACN.GetSpriteNodeIndex(ADNCNHHHCBF);
		SetSpriteFactoryIndex(m_nSpriteFactoryIndex, FDOPNPLBJNA, JGANGICOOHE);
	}

	private void JGFFKGLIKBC()
	{
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = base.gameObject.GetComponent<MeshFilter>();
			if (HOAKNOENHHD == null)
			{
				HOAKNOENHHD = base.gameObject.AddComponent<MeshFilter>();
			}
		}
		if (m_NcSpriteFactoryPrefab == null && base.gameObject.GetComponent<NcSpriteFactory>() != null)
		{
			m_NcSpriteFactoryPrefab = base.gameObject;
		}
		NBLIIIBHKGG(m_nSpriteFactoryIndex);
	}

	public void HIGAGFNFGGA(string ADNCNHHHCBF, int FDOPNPLBJNA, bool JGANGICOOHE)
	{
		if (DMDHBNHBACN == null)
		{
			if (!m_NcSpriteFactoryPrefab || !(m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>() != null))
			{
				return;
			}
			DMDHBNHBACN = m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>();
		}
		m_nSpriteFactoryIndex = DMDHBNHBACN.GetSpriteNodeIndex(ADNCNHHHCBF);
		BJEBCAKKBCE(m_nSpriteFactoryIndex, FDOPNPLBJNA, JGANGICOOHE);
	}

	private bool ALDCMMKDLDF(int IBDLGAOEJKH)
	{
		m_nSpriteFactoryIndex = IBDLGAOEJKH;
		if (DMDHBNHBACN == null)
		{
			if (!m_NcSpriteFactoryPrefab || !(m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>() != null))
			{
				return false;
			}
			DMDHBNHBACN = m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>();
		}
		if (!DMDHBNHBACN.IsValidFactory())
		{
			return false;
		}
		m_NcSpriteFrameInfos = DMDHBNHBACN.GetSpriteNode(m_nSpriteFactoryIndex).m_FrameInfos;
		m_fUvScale = DMDHBNHBACN.m_fUvScale;
		return true;
	}

	public bool UpdateSpriteMaterial()
	{
		if (m_NcSpriteFactoryPrefab == null)
		{
			return false;
		}
		if (m_NcSpriteFactoryPrefab.GetComponent<Renderer>() == null || m_NcSpriteFactoryPrefab.GetComponent<Renderer>().sharedMaterial == null || m_NcSpriteFactoryPrefab.GetComponent<Renderer>().sharedMaterial.mainTexture == null)
		{
			return false;
		}
		if (base.GetComponent<Renderer>() == null)
		{
			return false;
		}
		if (DMDHBNHBACN == null)
		{
			return false;
		}
		if (m_nSpriteFactoryIndex < 0 || DMDHBNHBACN.GetSpriteNodeCount() <= m_nSpriteFactoryIndex)
		{
			return false;
		}
		if (DMDHBNHBACN.m_SpriteType != NcSpriteFactory.BAJCJFCPFDG.NcSpriteTexture && DMDHBNHBACN.m_SpriteType != NcSpriteFactory.BAJCJFCPFDG.Auto)
		{
			return false;
		}
		base.GetComponent<Renderer>().sharedMaterial = m_NcSpriteFactoryPrefab.GetComponent<Renderer>().sharedMaterial;
		return true;
	}

	private bool NBLIIIBHKGG(int IBDLGAOEJKH)
	{
		m_nSpriteFactoryIndex = IBDLGAOEJKH;
		if (DMDHBNHBACN == null)
		{
			if (!m_NcSpriteFactoryPrefab || !(m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>() != null))
			{
				return false;
			}
			DMDHBNHBACN = m_NcSpriteFactoryPrefab.GetComponent<NcSpriteFactory>();
		}
		if (!DMDHBNHBACN.IsValidFactory())
		{
			return true;
		}
		m_NcSpriteFrameInfos = DMDHBNHBACN.ADJAHDPKKFN(m_nSpriteFactoryIndex).m_FrameInfos;
		m_fUvScale = DMDHBNHBACN.m_fUvScale;
		return true;
	}

	public void BJEBCAKKBCE(int IBDLGAOEJKH, int FDOPNPLBJNA, bool JGANGICOOHE)
	{
		if (NBLIIIBHKGG(IBDLGAOEJKH))
		{
			SetFrameIndex(FDOPNPLBJNA);
			if (JGANGICOOHE)
			{
				KJKHNAHJJAL(JGANGICOOHE);
			}
		}
	}

	private void KJKHNAHJJAL(bool NNHAMEAPCOI)
	{
		if (!UpdateSpriteMaterial() || !DMDHBNHBACN.IsValidFactory())
		{
			return;
		}
		if (m_NcSpriteFrameInfos.Length == 0)
		{
			SetSpriteFactoryIndex(m_nSpriteFactoryIndex, m_nFrameIndex, false);
		}
		if (HOAKNOENHHD == null)
		{
			if (base.gameObject.GetComponent<MeshFilter>() != null)
			{
				HOAKNOENHHD = base.gameObject.GetComponent<MeshFilter>();
			}
			else
			{
				HOAKNOENHHD = base.gameObject.AddComponent<MeshFilter>();
			}
		}
		NcSpriteFactory.CreatePlane(HOAKNOENHHD, m_fUvScale, m_NcSpriteFrameInfos[m_nFrameIndex], false, m_AlignType, m_MeshType, m_fShowRate);
		NcSpriteFactory.UpdateMeshUVs(HOAKNOENHHD, m_NcSpriteFrameInfos[m_nFrameIndex].m_TextureUvOffset, m_AlignType, m_fShowRate);
		if (NNHAMEAPCOI)
		{
			FFCLOLNHAOC = DMDHBNHBACN.CreateSpriteEffect(m_nSpriteFactoryIndex, base.transform);
		}
	}
}
