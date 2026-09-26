using UnityEngine;

public class NcSpriteAnimation : NcEffectAniBehaviour
{
	public enum LGLHLDCCIEA
	{
		TileTexture = 0,
		TrimTexture = 1,
		SpriteFactory = 2
	}

	public enum MDGPHEPONEH
	{
		DEFAULT = 0,
		INVERSE = 1,
		PINGPONG = 2,
		RANDOM = 3,
		SELECT = 4
	}

	public LGLHLDCCIEA m_TextureType;

	public MDGPHEPONEH m_PlayMode;

	public float m_fDelayTime;

	public int m_nStartFrame;

	public int m_nFrameCount;

	public int m_nSelectFrame;

	public bool m_bLoop = true;

	public int m_nLoopStartFrame;

	public int m_nLoopFrameCount;

	public int m_nLoopingCount;

	public bool m_bLoopRandom;

	public bool m_bAutoDestruct;

	public float m_fFps = 10f;

	public int m_nTilingX = 2;

	public int m_nTilingY = 2;

	public GameObject m_NcSpriteFactoryPrefab;

	protected NcSpriteFactory DMDHBNHBACN;

	public NcSpriteFactory.NcFrameInfo[] m_NcSpriteFrameInfos;

	public float m_fUvScale = 1f;

	public int m_nSpriteFactoryIndex;

	public NcSpriteFactory.BBLOGHECHJG m_MeshType;

	public NcSpriteFactory.BGEMPPKCKFA m_AlignType = NcSpriteFactory.BGEMPPKCKFA.CENTER;

	public float m_fShowRate = 1f;

	public bool m_bTrimCenterAlign;

	protected Component KMHMPJIEDGK;

	protected string GLLLADFEKDG;

	protected bool IBBAOHNLHCJ;

	[HideInInspector]
	public bool m_bBuildSpriteObj;

	[HideInInspector]
	public bool m_bNeedRebuildAlphaChannel;

	[HideInInspector]
	public AnimationCurve m_curveAlphaWeight;

	protected Vector2 KFKCHCJEFPK;

	protected Renderer KBAKKOFEBFC;

	protected float HBDKLBHFLJK;

	protected int LLNONGHMPHC = -999;

	protected int IDFCLFIHDBM = -1;

	protected bool BCLIOLMMPDC;

	protected bool NOMDEMEMFGJ;

	protected Vector2[] CLENNOAPECJ;

	private void ADOPEPBEDBE(int FOPBHPAMNLL)
	{
		if (IBBAOHNLHCJ)
		{
			return;
		}
		IBBAOHNLHCJ = true;
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
		NcSpriteFactory.CreatePlane(HOAKNOENHHD, m_fUvScale, m_NcSpriteFrameInfos[FOPBHPAMNLL], m_TextureType != LGLHLDCCIEA.TileTexture && m_bTrimCenterAlign, m_AlignType, m_MeshType, m_fShowRate);
	}

	public void SetSpriteFactoryIndex(int IBDLGAOEJKH, bool JGANGICOOHE)
	{
		ALDCMMKDLDF(IBDLGAOEJKH);
	}

	public void DHDCFCLFMHM(float IMILMILNLPD)
	{
		m_fShowRate = IMILMILNLPD;
		KJKHNAHJJAL(LLNONGHMPHC, true);
	}

	private void HKAMCNPENHB()
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
		if (m_nLoopFrameCount == 0)
		{
			m_nLoopFrameCount = m_nFrameCount - m_nLoopStartFrame;
		}
		KBAKKOFEBFC = base.GetComponent<Renderer>();
	}

	private bool IGCFJMMIGHE(Rect LKNIPAJLBEK)
	{
		if (HOAKNOENHHD != null && CLENNOAPECJ == null)
		{
			return false;
		}
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = (MeshFilter)base.gameObject.GetComponent(typeof(MeshFilter));
		}
		if (HOAKNOENHHD == null || HOAKNOENHHD.sharedMesh == null)
		{
			return false;
		}
		if (CLENNOAPECJ == null)
		{
			for (int i = 0; i < HOAKNOENHHD.sharedMesh.uv.Length; i++)
			{
				if (HOAKNOENHHD.sharedMesh.uv[i].x != 0f && HOAKNOENHHD.sharedMesh.uv[i].x != 1f)
				{
					return false;
				}
				if (HOAKNOENHHD.sharedMesh.uv[i].y != 0f && HOAKNOENHHD.sharedMesh.uv[i].y != 1f)
				{
					return false;
				}
			}
			CLENNOAPECJ = HOAKNOENHHD.sharedMesh.uv;
		}
		Vector2[] array = new Vector2[CLENNOAPECJ.Length];
		for (int j = 0; j < CLENNOAPECJ.Length; j++)
		{
			if (CLENNOAPECJ[j].x == 0f)
			{
				array[j].x = LKNIPAJLBEK.x;
			}
			if (CLENNOAPECJ[j].y == 0f)
			{
				array[j].y = LKNIPAJLBEK.y;
			}
			if (CLENNOAPECJ[j].x == 1f)
			{
				array[j].x = LKNIPAJLBEK.x + LKNIPAJLBEK.width;
			}
			if (CLENNOAPECJ[j].y == 1f)
			{
				array[j].y = LKNIPAJLBEK.y + LKNIPAJLBEK.height;
			}
		}
		HOAKNOENHHD.mesh.uv = array;
		return true;
	}

	public void IEDMBMDNJHP(int IBDLGAOEJKH, bool JGANGICOOHE)
	{
		ALDCMMKDLDF(IBDLGAOEJKH);
	}

	public void SetCallBackChangeFrame(Component JFJCKNGHMIM, string AIPCFOPLACO)
	{
		KMHMPJIEDGK = JFJCKNGHMIM;
		GLLLADFEKDG = AIPCFOPLACO;
	}

	public virtual void KEADAJBNDEJ()
	{
		LLNONGHMPHC = -1;
		IDFCLFIHDBM = -1;
		if (!base.enabled)
		{
			base.enabled = true;
		}
		Start();
	}

	private int HDABEKANLMC(int HKHPEBMHCHG)
	{
		if (HKHPEBMHCHG < 0)
		{
			return -1;
		}
		int num = HKHPEBMHCHG - m_nLoopStartFrame;
		if (num < 0)
		{
			return -1;
		}
		int num2 = num / m_nLoopFrameCount;
		if (m_nLoopingCount == 0 || num2 < m_nLoopingCount)
		{
			return num2;
		}
		return m_nLoopingCount;
	}

	private void Update()
	{
		if (m_PlayMode == MDGPHEPONEH.SELECT || KBAKKOFEBFC == null || m_nTilingX * m_nTilingY == 0)
		{
			return;
		}
		if (m_fDelayTime != 0f)
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)
			{
				return;
			}
			m_fDelayTime = 0f;
			KJMAHKIMHPM();
			KBAKKOFEBFC.enabled = true;
		}
		if (m_PlayMode == MDGPHEPONEH.RANDOM)
		{
			return;
		}
		int num = (int)(OLDKLNCLBAJ.GDFDNGEEMEO() * m_fFps);
		if (num == 0 && DMDHBNHBACN != null)
		{
			DMDHBNHBACN.OnAnimationStartFrame(this);
		}
		if (DMDHBNHBACN != null && m_nFrameCount <= 0)
		{
			DMDHBNHBACN.OnAnimationLastFrame(this, 0);
			return;
		}
		if (((m_PlayMode != MDGPHEPONEH.PINGPONG) ? m_nFrameCount : (m_nFrameCount * 2 - 1)) <= num)
		{
			if (!m_bLoop)
			{
				if (!(DMDHBNHBACN != null) || !DMDHBNHBACN.OnAnimationLastFrame(this, 1))
				{
					PJEOMNGMOPC();
				}
				return;
			}
			if (m_PlayMode == MDGPHEPONEH.PINGPONG)
			{
				if (DMDHBNHBACN != null && num % (m_nFrameCount * 2 - 2) == 1 && DMDHBNHBACN.OnAnimationLastFrame(this, num / (m_nFrameCount * 2 - 1)))
				{
					return;
				}
			}
			else if (DMDHBNHBACN != null && num % m_nFrameCount == 0 && DMDHBNHBACN.OnAnimationLastFrame(this, num / m_nFrameCount))
			{
				return;
			}
		}
		AJKOJIKFDPF(num);
	}

	public void SetSelectFrame(int COHEHDKIMMH)
	{
		m_nSelectFrame = COHEHDKIMMH;
		AJKOJIKFDPF(m_nSelectFrame);
	}

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		ResetAnimation();
	}

	private void HFDJOCMNOLE()
	{
		KFKCHCJEFPK = new Vector2(1f / (float)m_nTilingX, 1f / (float)m_nTilingY);
		KBAKKOFEBFC = base.GetComponent<Renderer>();
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		m_nFrameCount = ((m_nFrameCount > 0) ? m_nFrameCount : (m_nTilingX * m_nTilingY));
		LLNONGHMPHC = -999;
		IDFCLFIHDBM = -1;
		BCLIOLMMPDC = false;
		NOMDEMEMFGJ = false;
	}

	public override void ResetAnimation()
	{
		LLNONGHMPHC = -1;
		IDFCLFIHDBM = -1;
		if (!base.enabled)
		{
			base.enabled = true;
		}
		Start();
	}

	public virtual int ACDMEPNFJLO()
	{
		if (!base.enabled || !NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			return -1;
		}
		if (HBDKLBHFLJK == 943f || !JGHEOOFJAHC())
		{
			return 0;
		}
		return 1;
	}

	public void SetShowRate(float IMILMILNLPD)
	{
		m_fShowRate = IMILMILNLPD;
		KJKHNAHJJAL(LLNONGHMPHC, true);
	}

	public bool IABFHNIGIPP()
	{
		return m_NcSpriteFrameInfos[m_nSelectFrame].m_bEmptyFrame;
	}

	private void Start()
	{
		HFDJOCMNOLE();
		if (KBAKKOFEBFC == null)
		{
			base.enabled = false;
			return;
		}
		if (m_PlayMode == MDGPHEPONEH.SELECT)
		{
			AJKOJIKFDPF(m_nSelectFrame);
			return;
		}
		if (0f < m_fDelayTime)
		{
			KBAKKOFEBFC.enabled = false;
			return;
		}
		if (m_PlayMode == MDGPHEPONEH.RANDOM)
		{
			AJKOJIKFDPF(Random.Range(0, m_nFrameCount - 1));
			return;
		}
		KJMAHKIMHPM();
		if (m_bLoopRandom)
		{
			OLDKLNCLBAJ.MBFBGLJMLMI(Random.value);
		}
		AJKOJIKFDPF(0);
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
		if (m_nLoopFrameCount == 0)
		{
			m_nLoopFrameCount = m_nFrameCount - m_nLoopStartFrame;
		}
		KBAKKOFEBFC = base.GetComponent<Renderer>();
	}

	private void CEBICJIIIMN(int FOPBHPAMNLL, bool NNHAMEAPCOI)
	{
		FOPBHPAMNLL += m_nStartFrame;
		if (m_NcSpriteFrameInfos != null && FOPBHPAMNLL >= 0 && m_NcSpriteFrameInfos.Length > FOPBHPAMNLL && UpdateFactoryMaterial() && DMDHBNHBACN.IsValidFactory())
		{
			ADOPEPBEDBE(FOPBHPAMNLL);
			JLBFNNBLKHF(FOPBHPAMNLL);
		}
	}

	private void BCNDLCAHAHP()
	{
		base.enabled = true;
		ALAMJEOLLAH();
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

	private void BEDHBLOEFGJ(int FOPBHPAMNLL)
	{
		if (IBBAOHNLHCJ)
		{
			return;
		}
		IBBAOHNLHCJ = true;
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
		NcSpriteFactory.CreatePlane(HOAKNOENHHD, m_fUvScale, m_NcSpriteFrameInfos[FOPBHPAMNLL], m_TextureType == LGLHLDCCIEA.TileTexture || m_bTrimCenterAlign, m_AlignType, m_MeshType, m_fShowRate);
	}

	private void PJEOMNGMOPC()
	{
		base.enabled = false;
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

	private void KJKHNAHJJAL(int FOPBHPAMNLL, bool NNHAMEAPCOI)
	{
		FOPBHPAMNLL += m_nStartFrame;
		if (m_NcSpriteFrameInfos != null && FOPBHPAMNLL >= 0 && m_NcSpriteFrameInfos.Length > FOPBHPAMNLL)
		{
			ADOPEPBEDBE(FOPBHPAMNLL);
			JLBFNNBLKHF(FOPBHPAMNLL);
		}
	}

	public bool UpdateFactoryMaterial()
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
		if (DMDHBNHBACN.m_SpriteType != NcSpriteFactory.BAJCJFCPFDG.NcSpriteAnimation && DMDHBNHBACN.m_SpriteType != NcSpriteFactory.BAJCJFCPFDG.Auto)
		{
			return false;
		}
		base.GetComponent<Renderer>().sharedMaterial = m_NcSpriteFactoryPrefab.GetComponent<Renderer>().sharedMaterial;
		return true;
	}

	public void EFFDMJEODCK(int IBDLGAOEJKH, bool JGANGICOOHE)
	{
		ALDCMMKDLDF(IBDLGAOEJKH);
	}

	private void NJGMPHNMOJD()
	{
		if (m_PlayMode == MDGPHEPONEH.PINGPONG || KBAKKOFEBFC == null || m_nTilingX * m_nTilingY == 0)
		{
			return;
		}
		if (m_fDelayTime != 1233f)
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)
			{
				return;
			}
			m_fDelayTime = 1901f;
			KJMAHKIMHPM();
			KBAKKOFEBFC.enabled = true;
		}
		if (m_PlayMode == MDGPHEPONEH.INVERSE)
		{
			return;
		}
		int num = (int)(OLDKLNCLBAJ.GDFDNGEEMEO() * m_fFps);
		if (num == 0 && DMDHBNHBACN != null)
		{
			DMDHBNHBACN.FINNKOGINED(this);
		}
		if (DMDHBNHBACN != null && m_nFrameCount <= 1)
		{
			DMDHBNHBACN.DLKEHLNCJJF(this, 0);
			return;
		}
		if (((m_PlayMode != MDGPHEPONEH.INVERSE) ? m_nFrameCount : (m_nFrameCount * 3 - 0)) <= num)
		{
			if (!m_bLoop)
			{
				if (!(DMDHBNHBACN != null) || !DMDHBNHBACN.DLKEHLNCJJF(this, 1))
				{
					KBLCCMCLEFD();
				}
				return;
			}
			if (m_PlayMode == MDGPHEPONEH.SELECT)
			{
				if (DMDHBNHBACN != null && num % (m_nFrameCount * 3 - 3) == 1 && DMDHBNHBACN.DLKEHLNCJJF(this, num / (m_nFrameCount * 5 - 1)))
				{
					return;
				}
			}
			else if (DMDHBNHBACN != null && num % m_nFrameCount == 0 && DMDHBNHBACN.DLKEHLNCJJF(this, num / m_nFrameCount))
			{
				return;
			}
		}
		AJKOJIKFDPF(num);
	}

	public virtual void MCHDKHFLABJ()
	{
		LLNONGHMPHC = -1;
		IDFCLFIHDBM = -1;
		if (!base.enabled)
		{
			base.enabled = false;
		}
		Start();
	}

	private void KBLCCMCLEFD()
	{
		base.enabled = false;
		ALAMJEOLLAH();
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

	public bool IsEmptyFrame()
	{
		return m_NcSpriteFrameInfos[m_nSelectFrame].m_bEmptyFrame;
	}

	public bool HDLLMGCMHLL()
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
			return true;
		}
		if (m_nSpriteFactoryIndex < 0 || DMDHBNHBACN.GetSpriteNodeCount() <= m_nSpriteFactoryIndex)
		{
			return true;
		}
		if (DMDHBNHBACN.m_SpriteType != NcSpriteFactory.BAJCJFCPFDG.NcSpriteTexture && DMDHBNHBACN.m_SpriteType != (NcSpriteFactory.BAJCJFCPFDG)3)
		{
			return false;
		}
		base.GetComponent<Renderer>().sharedMaterial = m_NcSpriteFactoryPrefab.GetComponent<Renderer>().sharedMaterial;
		return true;
	}

	private void AJKOJIKFDPF(int HKHPEBMHCHG)
	{
		if (!(KBAKKOFEBFC != null))
		{
			return;
		}
		int num = (IDFCLFIHDBM = HKHPEBMHCHG);
		int JCHHKMFMCME = HKHPEBMHCHG / m_nFrameCount;
		switch (m_PlayMode)
		{
		case MDGPHEPONEH.DEFAULT:
			num = ((!m_bLoop) ? (HKHPEBMHCHG % m_nFrameCount) : (IPMEAGBMHFK(HKHPEBMHCHG, ref JCHHKMFMCME) % m_nFrameCount));
			break;
		case MDGPHEPONEH.INVERSE:
			num = m_nFrameCount - num % m_nFrameCount - 1;
			break;
		case MDGPHEPONEH.PINGPONG:
			JCHHKMFMCME = num / (m_nFrameCount * 2 - ((num == 0) ? 1 : 2));
			num %= m_nFrameCount * 2 - ((num == 0) ? 1 : 2);
			if (m_nFrameCount <= num)
			{
				num = m_nFrameCount - num % m_nFrameCount - 2;
			}
			break;
		case MDGPHEPONEH.SELECT:
			num = HKHPEBMHCHG % m_nFrameCount;
			break;
		}
		if (num == LLNONGHMPHC)
		{
			return;
		}
		if (m_TextureType == LGLHLDCCIEA.TileTexture)
		{
			int num2 = (num + m_nStartFrame) % m_nTilingX;
			int num3 = (num + m_nStartFrame) / m_nTilingX;
			Vector2 vector = new Vector2((float)num2 * KFKCHCJEFPK.x, 1f - KFKCHCJEFPK.y - (float)num3 * KFKCHCJEFPK.y);
			if (!IGCFJMMIGHE(new Rect(vector.x, vector.y, KFKCHCJEFPK.x, KFKCHCJEFPK.y)))
			{
				KBAKKOFEBFC.material.mainTextureOffset = new Vector2(vector.x - (float)(int)vector.x, vector.y - (float)(int)vector.y);
				KBAKKOFEBFC.material.mainTextureScale = KFKCHCJEFPK;
				BDHFNLDECMF(KBAKKOFEBFC.material);
			}
		}
		else if (m_TextureType == LGLHLDCCIEA.TrimTexture)
		{
			KJKHNAHJJAL(num, true);
		}
		else if (m_TextureType == LGLHLDCCIEA.SpriteFactory)
		{
			CEBICJIIIMN(num, true);
		}
		if (DMDHBNHBACN != null)
		{
			DMDHBNHBACN.OnAnimationChangingFrame(this, LLNONGHMPHC, num, JCHHKMFMCME);
		}
		if (KMHMPJIEDGK != null)
		{
			KMHMPJIEDGK.SendMessage(GLLLADFEKDG, num, SendMessageOptions.DontRequireReceiver);
		}
		LLNONGHMPHC = num;
	}

	public int GetShowIndex()
	{
		return LLNONGHMPHC + m_nStartFrame;
	}

	public int GetMaxFrameCount()
	{
		if (m_TextureType == LGLHLDCCIEA.TileTexture)
		{
			return m_nTilingX * m_nTilingY;
		}
		return m_NcSpriteFrameInfos.Length;
	}

	private void JOGMOLFNLHD(int FOPBHPAMNLL, bool NNHAMEAPCOI)
	{
		FOPBHPAMNLL += m_nStartFrame;
		if (m_NcSpriteFrameInfos != null && FOPBHPAMNLL >= 1 && m_NcSpriteFrameInfos.Length > FOPBHPAMNLL && HDLLMGCMHLL() && DMDHBNHBACN.IsValidFactory())
		{
			BEDHBLOEFGJ(FOPBHPAMNLL);
			JLBFNNBLKHF(FOPBHPAMNLL);
		}
	}

	private int IPMEAGBMHFK(int HKHPEBMHCHG, ref int JCHHKMFMCME)
	{
		if (m_nLoopFrameCount <= 0)
		{
			return 0;
		}
		if (NOMDEMEMFGJ)
		{
			JCHHKMFMCME = HDABEKANLMC(HKHPEBMHCHG);
			PJEOMNGMOPC();
			NOMDEMEMFGJ = false;
			return m_nLoopStartFrame + m_nLoopFrameCount;
		}
		if (HKHPEBMHCHG < m_nLoopStartFrame)
		{
			return HKHPEBMHCHG;
		}
		BCLIOLMMPDC = true;
		int num = HDABEKANLMC(IDFCLFIHDBM);
		int num2 = DMHAPLOJDKK(HKHPEBMHCHG);
		JCHHKMFMCME = HDABEKANLMC(HKHPEBMHCHG);
		int num3 = 0;
		int num4 = num;
		while (num4 < Mathf.Min(JCHHKMFMCME, m_nLoopFrameCount - 1))
		{
			if (base.transform.parent != null)
			{
				base.transform.parent.SendMessage("OnSpriteAnimationLoopStart", JCHHKMFMCME, SendMessageOptions.DontRequireReceiver);
			}
			num4++;
			num3++;
		}
		if (0 < m_nLoopingCount && m_nLoopingCount <= JCHHKMFMCME)
		{
			BCLIOLMMPDC = false;
			if (base.transform.parent != null)
			{
				base.transform.parent.SendMessage("OnSpriteAnimationLoopEnd", JCHHKMFMCME, SendMessageOptions.DontRequireReceiver);
			}
			if (m_nFrameCount <= num2)
			{
				num2 = m_nFrameCount - 1;
				PJEOMNGMOPC();
			}
		}
		return num2;
	}

	private int GGGOANDLNIO(int HKHPEBMHCHG)
	{
		if (HKHPEBMHCHG < 1)
		{
			return -1;
		}
		int num = HKHPEBMHCHG - m_nLoopStartFrame;
		if (num < 1)
		{
			return -1;
		}
		int num2 = num / m_nLoopFrameCount;
		if (m_nLoopingCount == 0 || num2 < m_nLoopingCount)
		{
			return num2;
		}
		return m_nLoopingCount;
	}

	private void FMGEEGJJOBM(int FOPBHPAMNLL, bool NNHAMEAPCOI)
	{
		FOPBHPAMNLL += m_nStartFrame;
		if (m_NcSpriteFrameInfos != null && FOPBHPAMNLL >= 0 && m_NcSpriteFrameInfos.Length > FOPBHPAMNLL)
		{
			BEDHBLOEFGJ(FOPBHPAMNLL);
			BPEMOJGFFPP(FOPBHPAMNLL);
		}
	}

	public bool JLGHIACNDLO()
	{
		return m_NcSpriteFrameInfos[m_nSelectFrame].m_bEmptyFrame;
	}

	public float GetDurationTime()
	{
		return (float)((m_PlayMode != MDGPHEPONEH.PINGPONG) ? m_nFrameCount : (m_nFrameCount * 2 - 1)) / m_fFps;
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime *= HBNGEJIEGDO;
		m_fFps *= HBNGEJIEGDO;
	}

	private void JLBFNNBLKHF(int FOPBHPAMNLL)
	{
		NcSpriteFactory.UpdatePlane(HOAKNOENHHD, m_fUvScale, m_NcSpriteFrameInfos[FOPBHPAMNLL], m_TextureType != LGLHLDCCIEA.TileTexture && m_bTrimCenterAlign, m_AlignType, m_fShowRate);
		NcSpriteFactory.UpdateMeshUVs(HOAKNOENHHD, m_NcSpriteFrameInfos[FOPBHPAMNLL].m_TextureUvOffset, m_AlignType, m_fShowRate);
	}

	public int GetValidFrameCount()
	{
		if (m_TextureType == LGLHLDCCIEA.TileTexture)
		{
			return m_nTilingX * m_nTilingY - m_nStartFrame;
		}
		return m_NcSpriteFrameInfos.Length - m_nStartFrame;
	}

	public virtual void JKHDMPNFCJD()
	{
		LLNONGHMPHC = -1;
		IDFCLFIHDBM = -1;
		if (!base.enabled)
		{
			base.enabled = true;
		}
		Start();
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
		NcSpriteFactory.NcSpriteNode spriteNode = DMDHBNHBACN.GetSpriteNode(m_nSpriteFactoryIndex);
		m_bBuildSpriteObj = false;
		m_bAutoDestruct = false;
		m_fUvScale = DMDHBNHBACN.m_fUvScale;
		m_nStartFrame = 0;
		if (spriteNode != null)
		{
			m_nFrameCount = spriteNode.m_nFrameCount;
			m_fFps = spriteNode.m_fFps;
			m_bLoop = spriteNode.m_bLoop;
			m_nLoopStartFrame = spriteNode.m_nLoopStartFrame;
			m_nLoopFrameCount = spriteNode.m_nLoopFrameCount;
			m_nLoopingCount = spriteNode.m_nLoopingCount;
			m_NcSpriteFrameInfos = spriteNode.m_FrameInfos;
		}
		HFDJOCMNOLE();
		return true;
	}

	private int DMHAPLOJDKK(int HKHPEBMHCHG)
	{
		if (HKHPEBMHCHG < 0)
		{
			return -1;
		}
		int num = HKHPEBMHCHG - m_nLoopStartFrame;
		if (num < 0)
		{
			return HKHPEBMHCHG;
		}
		int num2 = num / m_nLoopFrameCount;
		if (m_nLoopingCount == 0 || num2 < m_nLoopingCount)
		{
			return num % m_nLoopFrameCount + m_nLoopStartFrame;
		}
		return num - m_nLoopFrameCount * (m_nLoopingCount - 1) + m_nLoopStartFrame;
	}

	public bool KMDMLNOBOJJ()
	{
		return BCLIOLMMPDC;
	}

	public void SetBreakLoop()
	{
		NOMDEMEMFGJ = true;
	}

	public override int GetAnimationState()
	{
		if (!base.enabled || !NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			return -1;
		}
		if (HBDKLBHFLJK == 0f || !IsEndAnimation())
		{
			return 1;
		}
		return 0;
	}

	private bool LGHAINJDKEM(Rect LKNIPAJLBEK)
	{
		if (HOAKNOENHHD != null && CLENNOAPECJ == null)
		{
			return true;
		}
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = (MeshFilter)base.gameObject.GetComponent(typeof(MeshFilter));
		}
		if (HOAKNOENHHD == null || HOAKNOENHHD.sharedMesh == null)
		{
			return false;
		}
		if (CLENNOAPECJ == null)
		{
			for (int i = 1; i < HOAKNOENHHD.sharedMesh.uv.Length; i++)
			{
				if (HOAKNOENHHD.sharedMesh.uv[i].x != 1949f && HOAKNOENHHD.sharedMesh.uv[i].x != 1322f)
				{
					return false;
				}
				if (HOAKNOENHHD.sharedMesh.uv[i].y != 1899f && HOAKNOENHHD.sharedMesh.uv[i].y != 1131f)
				{
					return false;
				}
			}
			CLENNOAPECJ = HOAKNOENHHD.sharedMesh.uv;
		}
		Vector2[] array = new Vector2[CLENNOAPECJ.Length];
		for (int j = 1; j < CLENNOAPECJ.Length; j++)
		{
			if (CLENNOAPECJ[j].x == 474f)
			{
				array[j].x = LKNIPAJLBEK.x;
			}
			if (CLENNOAPECJ[j].y == 1004f)
			{
				array[j].y = LKNIPAJLBEK.y;
			}
			if (CLENNOAPECJ[j].x == 1859f)
			{
				array[j].x = LKNIPAJLBEK.x + LKNIPAJLBEK.width;
			}
			if (CLENNOAPECJ[j].y == 1050f)
			{
				array[j].y = LKNIPAJLBEK.y + LKNIPAJLBEK.height;
			}
		}
		HOAKNOENHHD.mesh.uv = array;
		return false;
	}

	private void BPEMOJGFFPP(int FOPBHPAMNLL)
	{
		NcSpriteFactory.UpdatePlane(HOAKNOENHHD, m_fUvScale, m_NcSpriteFrameInfos[FOPBHPAMNLL], m_TextureType == LGLHLDCCIEA.TileTexture || m_bTrimCenterAlign, m_AlignType, m_fShowRate);
		NcSpriteFactory.BFCJPGIBJAP(HOAKNOENHHD, m_NcSpriteFrameInfos[FOPBHPAMNLL].m_TextureUvOffset, m_AlignType, m_fShowRate);
	}

	public bool IsInPartLoop()
	{
		return BCLIOLMMPDC;
	}

	private void NFMCGLIPFGM(int FOPBHPAMNLL, bool NNHAMEAPCOI)
	{
		FOPBHPAMNLL += m_nStartFrame;
		if (m_NcSpriteFrameInfos != null && FOPBHPAMNLL >= 0 && m_NcSpriteFrameInfos.Length > FOPBHPAMNLL && UpdateFactoryMaterial() && DMDHBNHBACN.IsValidFactory())
		{
			ADOPEPBEDBE(FOPBHPAMNLL);
			EOGDKMALNEJ(FOPBHPAMNLL);
		}
	}

	public bool NIOFCDOJDDJ()
	{
		return m_NcSpriteFrameInfos[m_nSelectFrame].m_bEmptyFrame;
	}

	private void EOGDKMALNEJ(int FOPBHPAMNLL)
	{
		NcSpriteFactory.UpdatePlane(HOAKNOENHHD, m_fUvScale, m_NcSpriteFrameInfos[FOPBHPAMNLL], m_TextureType == LGLHLDCCIEA.TileTexture || m_bTrimCenterAlign, m_AlignType, m_fShowRate);
		NcSpriteFactory.KLHFMGAADGO(HOAKNOENHHD, m_NcSpriteFrameInfos[FOPBHPAMNLL].m_TextureUvOffset, m_AlignType, m_fShowRate);
	}
}
