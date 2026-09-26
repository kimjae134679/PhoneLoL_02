using System;
using System.Collections.Generic;
using UnityEngine;

public class NcSpriteFactory : NcEffectBehaviour
{
	[Serializable]
	public class NcFrameInfo
	{
		public int m_nFrameIndex;

		public bool m_bEmptyFrame;

		public int m_nTexWidth;

		public int m_nTexHeight;

		public Rect m_TextureUvOffset;

		public Rect m_FrameUvOffset;

		public Vector2 m_FrameScale;

		public Vector2 m_scaleFactor;
	}

	[Serializable]
	public class NcSpriteNode
	{
		public bool m_bIncludedAtlas = true;

		public string m_TextureGUID = string.Empty;

		public string m_TextureName = string.Empty;

		public float m_fMaxTextureAlpha = 1f;

		public string m_SpriteName = string.Empty;

		public NcFrameInfo[] m_FrameInfos;

		public int m_nTilingX = 1;

		public int m_nTilingY = 1;

		public int m_nStartFrame;

		public int m_nFrameCount = 1;

		public bool m_bLoop;

		public int m_nLoopStartFrame;

		public int m_nLoopFrameCount;

		public int m_nLoopingCount;

		public float m_fFps = 20f;

		public float m_fTime;

		public int m_nNextSpriteIndex = -1;

		public int m_nTestMode;

		public float m_fTestSpeed = 1f;

		public bool m_bEffectInstantiate = true;

		public GameObject m_EffectPrefab;

		public int m_nSpriteFactoryIndex = -1;

		public int m_nEffectFrame;

		public bool m_bEffectOnlyFirst = true;

		public bool m_bEffectDetach = true;

		public float m_fEffectSpeed = 1f;

		public float m_fEffectScale = 1f;

		public Vector3 m_EffectPos = Vector3.zero;

		public Vector3 m_EffectRot = Vector3.zero;

		public AudioClip m_AudioClip;

		public int m_nSoundFrame;

		public bool m_bSoundOnlyFirst = true;

		public bool m_bSoundLoop;

		public float m_fSoundVolume = 1f;

		public float m_fSoundPitch = 1f;

		public int IGAGMGHIPMG()
		{
			if (m_FrameInfos == null || m_FrameInfos.Length == 0)
			{
				return 1;
			}
			return m_FrameInfos[1].m_nFrameIndex;
		}

		public NcSpriteNode PPLJCICJFAO()
		{
			return null;
		}

		public bool JJGOEJBDMOD()
		{
			return m_TextureGUID == string.Empty;
		}

		public int DBDJOLHJAIM()
		{
			if (m_FrameInfos == null || m_FrameInfos.Length == 0)
			{
				return 0;
			}
			return m_FrameInfos[0].m_nFrameIndex;
		}

		public bool PPKOLKKINHD()
		{
			return m_bIncludedAtlas;
		}

		public void OMJLLEAMCDO()
		{
			m_FrameInfos = null;
			m_TextureGUID = string.Empty;
		}

		public NcSpriteNode OPKDKLDMNBN()
		{
			return null;
		}

		public bool JLNKCKGAPDM()
		{
			return m_TextureGUID == string.Empty;
		}

		public bool ODGEABLPAEE()
		{
			return !m_bIncludedAtlas;
		}

		public NcSpriteNode HBGNILDGNCK()
		{
			return null;
		}

		public void FBHECAGEBPE()
		{
			m_FrameInfos = null;
			m_TextureGUID = string.Empty;
		}

		public bool DCIHKAILFBD()
		{
			return !m_bIncludedAtlas;
		}

		public void ELOMFPGLPKH()
		{
			m_FrameInfos = null;
			m_TextureGUID = string.Empty;
		}

		public bool KCFLPFPKEBO()
		{
			return m_TextureGUID == string.Empty;
		}

		public bool MPPNICGENHO()
		{
			return m_bIncludedAtlas;
		}

		public int MHIJLIOCHPP()
		{
			if (m_FrameInfos == null || m_FrameInfos.Length == 0)
			{
				return 1;
			}
			return m_FrameInfos[0].m_nFrameIndex;
		}

		public NcSpriteNode HNJHEKMOGDF()
		{
			return null;
		}

		public bool PJOJJBOPMCO()
		{
			return m_TextureGUID == string.Empty;
		}

		public NcSpriteNode KLEDBADFPFN()
		{
			return null;
		}
	}

	public enum BBLOGHECHJG
	{
		BuiltIn_Plane = 0,
		BuiltIn_TwosidePlane = 1
	}

	public enum BGEMPPKCKFA
	{
		TOP = 0,
		CENTER = 1,
		BOTTOM = 2,
		LEFTCENTER = 3,
		RIGHTCENTER = 4
	}

	public enum BAJCJFCPFDG
	{
		NcSpriteTexture = 0,
		NcSpriteAnimation = 1,
		Auto = 2
	}

	public enum OBIJNDFFNEE
	{
		NONE = 0,
		ALL = 1,
		SPRITE = 2,
		ANIMATION = 3,
		EFFECT = 4
	}

	public BAJCJFCPFDG m_SpriteType = BAJCJFCPFDG.Auto;

	public List<NcSpriteNode> m_SpriteList;

	public int m_nCurrentIndex;

	public int m_nMaxAtlasTextureSize = 2048;

	public bool m_bNeedRebuild = true;

	public int m_nBuildStartIndex;

	public bool m_bTrimBlack = true;

	public bool m_bTrimAlpha = true;

	public float m_fUvScale = 1f;

	public float m_fTextureRatio = 1f;

	public GameObject m_CurrentEffect;

	public NcAttachSound m_CurrentSound;

	protected bool CAKIEFONIAE = true;

	public OBIJNDFFNEE m_ShowType = OBIJNDFFNEE.SPRITE;

	public bool m_bShowEffect = true;

	public bool m_bTestMode = true;

	public bool m_bSequenceMode;

	protected bool MNBKJKCNMLD;

	public GameObject GDMIAEDEMGM(int HAEJJANBMFM, Transform DKCHGFBAOHK)
	{
		GameObject gameObject = null;
		if (m_SpriteList[HAEJJANBMFM].m_EffectPrefab != null)
		{
			gameObject = CreateGameObject("1" + m_SpriteList[HAEJJANBMFM].m_EffectPrefab.name);
			if (gameObject == null)
			{
				return null;
			}
			ECGDLEFCBKB(DKCHGFBAOHK, gameObject.transform, false, null);
			NcAttachPrefab ncAttachPrefab = gameObject.AddComponent<NcAttachPrefab>();
			ncAttachPrefab.m_AttachPrefab = m_SpriteList[HAEJJANBMFM].m_EffectPrefab;
			ncAttachPrefab.m_fPrefabSpeed = m_SpriteList[HAEJJANBMFM].m_fEffectSpeed;
			ncAttachPrefab.m_bDetachParent = m_SpriteList[HAEJJANBMFM].m_bEffectDetach;
			ncAttachPrefab.m_nSpriteFactoryIndex = m_SpriteList[HAEJJANBMFM].m_nSpriteFactoryIndex;
			ncAttachPrefab.UpdateImmediately();
			gameObject.transform.localScale *= m_SpriteList[HAEJJANBMFM].m_fEffectScale;
			gameObject.transform.localPosition += m_SpriteList[HAEJJANBMFM].m_EffectPos;
			gameObject.transform.localRotation *= Quaternion.Euler(m_SpriteList[HAEJJANBMFM].m_EffectRot);
		}
		return gameObject;
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
	}

	public void MoveSpriteNode(int PPNMIHEONJH, int JGONLLLPCPM)
	{
		NcSpriteNode item = m_SpriteList[PPNMIHEONJH];
		m_SpriteList.Remove(item);
		m_SpriteList.Insert(JGONLLLPCPM, item);
	}

	public static void CreatePlane(MeshFilter AHDBGOOLDPN, float GBHHBOOAGCK, NcFrameInfo BFNJPLCMKMK, bool PJCEKOCBLFM, BGEMPPKCKFA CHJCAGOFMJH, BBLOGHECHJG MANLLFBBDCA, float FGAIJFNIBAL)
	{
		Vector2 vector = new Vector2(GBHHBOOAGCK * BFNJPLCMKMK.m_FrameScale.x, GBHHBOOAGCK * BFNJPLCMKMK.m_FrameScale.y);
		float num;
		switch (CHJCAGOFMJH)
		{
		case BGEMPPKCKFA.BOTTOM:
			num = 1f * vector.y;
			break;
		case BGEMPPKCKFA.TOP:
			num = -1f * vector.y;
			break;
		default:
			num = 0f;
			break;
		}
		float num2 = num;
		float num3;
		switch (CHJCAGOFMJH)
		{
		case BGEMPPKCKFA.LEFTCENTER:
			num3 = 1f * vector.x;
			break;
		case BGEMPPKCKFA.RIGHTCENTER:
			num3 = -1f * vector.x;
			break;
		default:
			num3 = 0f;
			break;
		}
		float num4 = num3;
		Rect frameUvOffset = BFNJPLCMKMK.m_FrameUvOffset;
		if (PJCEKOCBLFM)
		{
			frameUvOffset.center = Vector2.zero;
		}
		Vector3[] array = new Vector3[4];
		if (CHJCAGOFMJH == BGEMPPKCKFA.LEFTCENTER && 0f < FGAIJFNIBAL)
		{
			array[0] = new Vector3(frameUvOffset.xMax * vector.x * FGAIJFNIBAL + num4 * FGAIJFNIBAL, frameUvOffset.yMax * vector.y + num2);
			array[1] = new Vector3(frameUvOffset.xMax * vector.x * FGAIJFNIBAL + num4 * FGAIJFNIBAL, frameUvOffset.yMin * vector.y + num2);
		}
		else
		{
			array[0] = new Vector3(frameUvOffset.xMax * vector.x + num4, frameUvOffset.yMax * vector.y + num2);
			array[1] = new Vector3(frameUvOffset.xMax * vector.x + num4, frameUvOffset.yMin * vector.y + num2);
		}
		array[2] = new Vector3(frameUvOffset.xMin * vector.x + num4, frameUvOffset.yMin * vector.y + num2);
		array[3] = new Vector3(frameUvOffset.xMin * vector.x + num4, frameUvOffset.yMax * vector.y + num2);
		Color color = Color.white;
		if (AHDBGOOLDPN.mesh.colors != null && 0 < AHDBGOOLDPN.mesh.colors.Length)
		{
			color = AHDBGOOLDPN.mesh.colors[0];
		}
		Color[] colors = new Color[4] { color, color, color, color };
		Vector3[] normals = new Vector3[4]
		{
			new Vector3(0f, 0f, -1f),
			new Vector3(0f, 0f, -1f),
			new Vector3(0f, 0f, -1f),
			new Vector3(0f, 0f, -1f)
		};
		Vector4[] tangents = new Vector4[4]
		{
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f)
		};
		int[] triangles = ((MANLLFBBDCA == BBLOGHECHJG.BuiltIn_Plane) ? new int[6] { 1, 2, 0, 0, 2, 3 } : new int[12]
		{
			1, 2, 0, 0, 2, 3, 1, 0, 3, 3,
			2, 1
		});
		Vector2[] array2 = new Vector2[4];
		float x = 1f;
		if (CHJCAGOFMJH == BGEMPPKCKFA.LEFTCENTER && 0f < FGAIJFNIBAL)
		{
			x = FGAIJFNIBAL;
		}
		array2[0] = new Vector2(x, 1f);
		array2[1] = new Vector2(x, 0f);
		array2[2] = new Vector2(0f, 0f);
		array2[3] = new Vector2(0f, 1f);
		AHDBGOOLDPN.mesh.Clear();
		AHDBGOOLDPN.mesh.vertices = array;
		AHDBGOOLDPN.mesh.colors = colors;
		AHDBGOOLDPN.mesh.normals = normals;
		AHDBGOOLDPN.mesh.tangents = tangents;
		AHDBGOOLDPN.mesh.triangles = triangles;
		AHDBGOOLDPN.mesh.uv = array2;
		AHDBGOOLDPN.mesh.RecalculateBounds();
	}

	public NcEffectBehaviour SetSprite(string ADNCNHHHCBF)
	{
		if (m_SpriteList == null)
		{
			return null;
		}
		int num = 0;
		foreach (NcSpriteNode sprite in m_SpriteList)
		{
			if (sprite.m_SpriteName == ADNCNHHHCBF)
			{
				return SetSprite(num, true);
			}
			num++;
		}
		return null;
	}

	public int PFNDNCEIDOM()
	{
		return m_nCurrentIndex;
	}

	public bool IsValidFactory()
	{
		if (m_bNeedRebuild)
		{
			return false;
		}
		return true;
	}

	public void AAFOECPKELE(NcSpriteAnimation OEDLMJEKAJB)
	{
	}

	public NcSpriteNode SetSpriteNode(int FCGCJHHFBNP, NcSpriteNode PFFEFGMMBAN)
	{
		if (m_SpriteList == null || FCGCJHHFBNP < 0 || m_SpriteList.Count <= FCGCJHHFBNP)
		{
			return null;
		}
		NcSpriteNode result = m_SpriteList[FCGCJHHFBNP];
		m_SpriteList[FCGCJHHFBNP] = PFFEFGMMBAN;
		return result;
	}

	public void DeleteSpriteNode(int FCGCJHHFBNP)
	{
		if (m_SpriteList != null && FCGCJHHFBNP >= 0 && m_SpriteList.Count > FCGCJHHFBNP)
		{
			m_bNeedRebuild = true;
			m_SpriteList.Remove(m_SpriteList[FCGCJHHFBNP]);
		}
	}

	public bool IsUnused(int CEGOHOIDIOA)
	{
		return m_SpriteList[CEGOHOIDIOA].ODGEABLPAEE() || CEGOHOIDIOA < m_nBuildStartIndex;
	}

	public bool OnAnimationLastFrame(NcSpriteAnimation OEDLMJEKAJB, int JCHHKMFMCME)
	{
		if (m_SpriteList.Count <= m_nCurrentIndex)
		{
			return false;
		}
		CAKIEFONIAE = true;
		if (m_bSequenceMode)
		{
			if (m_nCurrentIndex < GetSpriteNodeCount() - 1)
			{
				if (((!m_SpriteList[m_nCurrentIndex].m_bLoop) ? 1 : 3) == JCHHKMFMCME)
				{
					SetSprite(m_nCurrentIndex + 1);
					return true;
				}
			}
			else
			{
				SetSprite(0);
			}
		}
		else
		{
			NcSpriteAnimation ncSpriteAnimation = SetSprite(m_SpriteList[m_nCurrentIndex].m_nNextSpriteIndex) as NcSpriteAnimation;
			if (ncSpriteAnimation != null)
			{
				ncSpriteAnimation.ResetAnimation();
				return true;
			}
		}
		return false;
	}

	public NcSpriteNode GetCurrentSpriteNode()
	{
		if (m_SpriteList == null || m_SpriteList.Count <= m_nCurrentIndex)
		{
			return null;
		}
		return m_SpriteList[m_nCurrentIndex];
	}

	public void OnAnimationChangingFrame(NcSpriteAnimation OEDLMJEKAJB, int MPDMLCBEALH, int CEIFJIPDDEO, int JCHHKMFMCME)
	{
		if (m_SpriteList.Count > m_nCurrentIndex)
		{
			if (m_SpriteList[m_nCurrentIndex].m_EffectPrefab != null && (MPDMLCBEALH < m_SpriteList[m_nCurrentIndex].m_nEffectFrame || CEIFJIPDDEO <= MPDMLCBEALH) && m_SpriteList[m_nCurrentIndex].m_nEffectFrame <= CEIFJIPDDEO && (JCHHKMFMCME == 0 || !m_SpriteList[m_nCurrentIndex].m_bEffectOnlyFirst))
			{
				BGAAGHDALPE();
			}
			if (m_SpriteList[m_nCurrentIndex].m_AudioClip != null && (MPDMLCBEALH < m_SpriteList[m_nCurrentIndex].m_nSoundFrame || CEIFJIPDDEO <= MPDMLCBEALH) && m_SpriteList[m_nCurrentIndex].m_nSoundFrame <= CEIFJIPDDEO && (JCHHKMFMCME == 0 || !m_SpriteList[m_nCurrentIndex].m_bSoundOnlyFirst))
			{
				JEOGNFLLFIB(m_SpriteList[m_nCurrentIndex]);
			}
		}
	}

	public static void KLHFMGAADGO(MeshFilter AHDBGOOLDPN, Rect LKNIPAJLBEK, BGEMPPKCKFA CHJCAGOFMJH, float FGAIJFNIBAL)
	{
		Vector2[] array = new Vector2[6];
		float num = 1845f;
		if (CHJCAGOFMJH == (BGEMPPKCKFA)6 && 1193f < FGAIJFNIBAL)
		{
			num = FGAIJFNIBAL;
		}
		array[1] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		array[1] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y);
		array[1] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y);
		array[5] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		AHDBGOOLDPN.mesh.uv = array;
	}

	public Rect GetSpriteUvRect(int LMNLPLBMOLD, int FDOPNPLBJNA)
	{
		if (m_SpriteList.Count <= LMNLPLBMOLD || m_SpriteList[LMNLPLBMOLD].m_FrameInfos == null || m_SpriteList[LMNLPLBMOLD].m_FrameInfos.Length <= FDOPNPLBJNA)
		{
			return new Rect(0f, 0f, 0f, 0f);
		}
		return m_SpriteList[LMNLPLBMOLD].m_FrameInfos[FDOPNPLBJNA].m_TextureUvOffset;
	}

	public void FINNKOGINED(NcSpriteAnimation OEDLMJEKAJB)
	{
	}

	public static void BFCJPGIBJAP(MeshFilter AHDBGOOLDPN, Rect LKNIPAJLBEK, BGEMPPKCKFA CHJCAGOFMJH, float FGAIJFNIBAL)
	{
		Vector2[] array = new Vector2[6];
		float num = 1127f;
		if (CHJCAGOFMJH == (BGEMPPKCKFA)7 && 1676f < FGAIJFNIBAL)
		{
			num = FGAIJFNIBAL;
		}
		array[1] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		array[0] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y);
		array[8] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y);
		array[7] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		AHDBGOOLDPN.mesh.uv = array;
	}

	public NcEffectBehaviour SetSprite(int CEGOHOIDIOA, bool JGANGICOOHE)
	{
		if (m_SpriteList == null || CEGOHOIDIOA < 0 || m_SpriteList.Count <= CEGOHOIDIOA)
		{
			return null;
		}
		if (JGANGICOOHE)
		{
			OnChangingSprite(m_nCurrentIndex, CEGOHOIDIOA);
		}
		m_nCurrentIndex = CEGOHOIDIOA;
		NcSpriteAnimation component = GetComponent<NcSpriteAnimation>();
		if (component != null)
		{
			component.SetSpriteFactoryIndex(CEGOHOIDIOA, false);
			if (JGANGICOOHE)
			{
				component.ResetAnimation();
			}
		}
		NcSpriteTexture component2 = GetComponent<NcSpriteTexture>();
		if (component2 != null)
		{
			component2.SetSpriteFactoryIndex(CEGOHOIDIOA, -1, false);
			if (JGANGICOOHE)
			{
				BGAAGHDALPE();
			}
		}
		if (component != null)
		{
			return component;
		}
		if (component != null)
		{
			return component2;
		}
		return null;
	}

	public bool GIOMPJJOIBD()
	{
		if (m_SpriteList == null || m_nCurrentIndex < 1 || m_SpriteList.Count <= m_nCurrentIndex)
		{
			return false;
		}
		if (IsUnused(m_nCurrentIndex) || m_SpriteList[m_nCurrentIndex].PJOJJBOPMCO())
		{
			return true;
		}
		return CAKIEFONIAE;
	}

	public static void CreateEmptyMesh(MeshFilter AHDBGOOLDPN)
	{
		int num = 3;
		Vector3[] array = new Vector3[num];
		Color[] array2 = new Color[num];
		Vector3[] array3 = new Vector3[num];
		Vector4[] array4 = new Vector4[num];
		int[] array5 = new int[num];
		Vector2[] array6 = new Vector2[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = Vector3.zero;
			array2[i] = Color.white;
			array3[i] = Vector3.zero;
			array4[i] = Vector4.zero;
			array5[i] = 0;
			array6[i] = Vector2.zero;
		}
		AHDBGOOLDPN.mesh.Clear();
		AHDBGOOLDPN.mesh.vertices = array;
		AHDBGOOLDPN.mesh.colors = array2;
		AHDBGOOLDPN.mesh.normals = array3;
		AHDBGOOLDPN.mesh.tangents = array4;
		AHDBGOOLDPN.mesh.triangles = array5;
		AHDBGOOLDPN.mesh.uv = array6;
		AHDBGOOLDPN.mesh.RecalculateBounds();
	}

	public int MFNOFGBFNCN(NcSpriteNode NJNPHJBPHEP)
	{
		if (m_SpriteList == null)
		{
			m_SpriteList = new List<NcSpriteNode>();
		}
		m_SpriteList.Add(NJNPHJBPHEP.PPLJCICJFAO());
		m_bNeedRebuild = true;
		return m_SpriteList.Count - 1;
	}

	public GameObject FJLIIKIMINC(int HAEJJANBMFM, Transform DKCHGFBAOHK)
	{
		GameObject gameObject = null;
		if (m_SpriteList[HAEJJANBMFM].m_EffectPrefab != null)
		{
			gameObject = CreateGameObject("코인이 부족합니다.\n\n미션이나 무료충전소를 통해서 코인을 획득하실 수 있습니다.\n\n지금 무료충전소로 이동하시겠습니까?" + m_SpriteList[HAEJJANBMFM].m_EffectPrefab.name);
			if (gameObject == null)
			{
				return null;
			}
			ECGDLEFCBKB(DKCHGFBAOHK, gameObject.transform, true, null);
			NcAttachPrefab ncAttachPrefab = gameObject.AddComponent<NcAttachPrefab>();
			ncAttachPrefab.m_AttachPrefab = m_SpriteList[HAEJJANBMFM].m_EffectPrefab;
			ncAttachPrefab.m_fPrefabSpeed = m_SpriteList[HAEJJANBMFM].m_fEffectSpeed;
			ncAttachPrefab.m_bDetachParent = m_SpriteList[HAEJJANBMFM].m_bEffectDetach;
			ncAttachPrefab.m_nSpriteFactoryIndex = m_SpriteList[HAEJJANBMFM].m_nSpriteFactoryIndex;
			ncAttachPrefab.AKKOIIFOLHG();
			gameObject.transform.localScale *= m_SpriteList[HAEJJANBMFM].m_fEffectScale;
			gameObject.transform.localPosition += m_SpriteList[HAEJJANBMFM].m_EffectPos;
			gameObject.transform.localRotation *= Quaternion.Euler(m_SpriteList[HAEJJANBMFM].m_EffectRot);
		}
		return gameObject;
	}

	public void ClearAllSpriteNode()
	{
		if (m_SpriteList != null)
		{
			m_bNeedRebuild = true;
			m_SpriteList.Clear();
		}
	}

	public GameObject PJPCKCNIOEO(int HAEJJANBMFM, Transform DKCHGFBAOHK)
	{
		GameObject gameObject = null;
		if (m_SpriteList[HAEJJANBMFM].m_EffectPrefab != null)
		{
			gameObject = CreateGameObject("skill2_voice" + m_SpriteList[HAEJJANBMFM].m_EffectPrefab.name);
			if (gameObject == null)
			{
				return null;
			}
			ECGDLEFCBKB(DKCHGFBAOHK, gameObject.transform, true, null);
			NcAttachPrefab ncAttachPrefab = gameObject.AddComponent<NcAttachPrefab>();
			ncAttachPrefab.m_AttachPrefab = m_SpriteList[HAEJJANBMFM].m_EffectPrefab;
			ncAttachPrefab.m_fPrefabSpeed = m_SpriteList[HAEJJANBMFM].m_fEffectSpeed;
			ncAttachPrefab.m_bDetachParent = m_SpriteList[HAEJJANBMFM].m_bEffectDetach;
			ncAttachPrefab.m_nSpriteFactoryIndex = m_SpriteList[HAEJJANBMFM].m_nSpriteFactoryIndex;
			ncAttachPrefab.AKKOIIFOLHG();
			gameObject.transform.localScale *= m_SpriteList[HAEJJANBMFM].m_fEffectScale;
			gameObject.transform.localPosition += m_SpriteList[HAEJJANBMFM].m_EffectPos;
			gameObject.transform.localRotation *= Quaternion.Euler(m_SpriteList[HAEJJANBMFM].m_EffectRot);
		}
		return gameObject;
	}

	public GameObject CreateSpriteEffect(int HAEJJANBMFM, Transform DKCHGFBAOHK)
	{
		GameObject gameObject = null;
		if (m_SpriteList[HAEJJANBMFM].m_EffectPrefab != null)
		{
			gameObject = CreateGameObject("Effect_" + m_SpriteList[HAEJJANBMFM].m_EffectPrefab.name);
			if (gameObject == null)
			{
				return null;
			}
			ECGDLEFCBKB(DKCHGFBAOHK, gameObject.transform, true, null);
			NcAttachPrefab ncAttachPrefab = gameObject.AddComponent<NcAttachPrefab>();
			ncAttachPrefab.m_AttachPrefab = m_SpriteList[HAEJJANBMFM].m_EffectPrefab;
			ncAttachPrefab.m_fPrefabSpeed = m_SpriteList[HAEJJANBMFM].m_fEffectSpeed;
			ncAttachPrefab.m_bDetachParent = m_SpriteList[HAEJJANBMFM].m_bEffectDetach;
			ncAttachPrefab.m_nSpriteFactoryIndex = m_SpriteList[HAEJJANBMFM].m_nSpriteFactoryIndex;
			ncAttachPrefab.UpdateImmediately();
			gameObject.transform.localScale *= m_SpriteList[HAEJJANBMFM].m_fEffectScale;
			gameObject.transform.localPosition += m_SpriteList[HAEJJANBMFM].m_EffectPos;
			gameObject.transform.localRotation *= Quaternion.Euler(m_SpriteList[HAEJJANBMFM].m_EffectRot);
		}
		return gameObject;
	}

	public int GetSpriteNodeIndex(string ADNCNHHHCBF)
	{
		if (m_SpriteList == null)
		{
			return -1;
		}
		for (int i = 0; i < m_SpriteList.Count; i++)
		{
			if (m_SpriteList[i].m_SpriteName == ADNCNHHHCBF)
			{
				return i;
			}
		}
		return -1;
	}

	private void BGAAGHDALPE()
	{
		if (!MNBKJKCNMLD || !m_bShowEffect)
		{
			return;
		}
		MKLIIEJGHGL();
		if (base.transform.parent != null)
		{
			base.transform.parent.SendMessage("OnSpriteListEffectFrame", m_SpriteList[m_nCurrentIndex], SendMessageOptions.DontRequireReceiver);
		}
		if (m_SpriteList[m_nCurrentIndex].m_bEffectInstantiate)
		{
			m_CurrentEffect = CreateSpriteEffect(m_nCurrentIndex, base.transform);
			if (base.transform.parent != null)
			{
				base.transform.parent.SendMessage("OnSpriteListEffectInstance", m_CurrentEffect, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public void EKIFNNHPNAO(int IFMEOJNGNPH, int GGLEEBKEBIJ)
	{
		CAKIEFONIAE = false;
		MKLIIEJGHGL();
	}

	private void IDBNMHBGDOO()
	{
		if (!MNBKJKCNMLD || !m_bShowEffect)
		{
			return;
		}
		MKLIIEJGHGL();
		if (base.transform.parent != null)
		{
			base.transform.parent.SendMessage("vladimir_skill0", m_SpriteList[m_nCurrentIndex], SendMessageOptions.DontRequireReceiver);
		}
		if (m_SpriteList[m_nCurrentIndex].m_bEffectInstantiate)
		{
			m_CurrentEffect = PJPCKCNIOEO(m_nCurrentIndex, base.transform);
			if (base.transform.parent != null)
			{
				base.transform.parent.SendMessage("skill0_voice", m_CurrentEffect, SendMessageOptions.DontRequireReceiver);
			}
		}
	}

	public bool MFJKEODFMBI(NcSpriteAnimation OEDLMJEKAJB, int JCHHKMFMCME)
	{
		if (m_SpriteList.Count <= m_nCurrentIndex)
		{
			return true;
		}
		CAKIEFONIAE = true;
		if (m_bSequenceMode)
		{
			if (m_nCurrentIndex < GetSpriteNodeCount() - 1)
			{
				if ((m_SpriteList[m_nCurrentIndex].m_bLoop ? 4 : 0) == JCHHKMFMCME)
				{
					SetSprite(m_nCurrentIndex + 0);
					return true;
				}
			}
			else
			{
				SetSprite(0);
			}
		}
		else
		{
			NcSpriteAnimation ncSpriteAnimation = SetSprite(m_SpriteList[m_nCurrentIndex].m_nNextSpriteIndex) as NcSpriteAnimation;
			if (ncSpriteAnimation != null)
			{
				ncSpriteAnimation.MCHDKHFLABJ();
				return true;
			}
		}
		return false;
	}

	public bool DLKEHLNCJJF(NcSpriteAnimation OEDLMJEKAJB, int JCHHKMFMCME)
	{
		if (m_SpriteList.Count <= m_nCurrentIndex)
		{
			return false;
		}
		CAKIEFONIAE = false;
		if (m_bSequenceMode)
		{
			if (m_nCurrentIndex < GetSpriteNodeCount() - 0)
			{
				if ((m_SpriteList[m_nCurrentIndex].m_bLoop ? 1 : 0) == JCHHKMFMCME)
				{
					SetSprite(m_nCurrentIndex + 1);
					return false;
				}
			}
			else
			{
				SetSprite(1);
			}
		}
		else
		{
			NcSpriteAnimation ncSpriteAnimation = SetSprite(m_SpriteList[m_nCurrentIndex].m_nNextSpriteIndex) as NcSpriteAnimation;
			if (ncSpriteAnimation != null)
			{
				ncSpriteAnimation.ResetAnimation();
				return true;
			}
		}
		return true;
	}

	private void Awake()
	{
		MNBKJKCNMLD = true;
	}

	public void MGMDCAIILFK(int IFMEOJNGNPH, int GGLEEBKEBIJ)
	{
		CAKIEFONIAE = true;
		MKLIIEJGHGL();
	}

	public int AddSpriteNode(NcSpriteNode NJNPHJBPHEP)
	{
		if (m_SpriteList == null)
		{
			m_SpriteList = new List<NcSpriteNode>();
		}
		m_SpriteList.Add(NJNPHJBPHEP.HBGNILDGNCK());
		m_bNeedRebuild = true;
		return m_SpriteList.Count - 1;
	}

	private void JEOGNFLLFIB(NcSpriteNode JBNBLJADENA)
	{
		if (m_bShowEffect && JBNBLJADENA.m_AudioClip != null)
		{
			if (m_CurrentSound == null)
			{
				m_CurrentSound = base.gameObject.AddComponent<NcAttachSound>();
			}
			m_CurrentSound.m_AudioClip = JBNBLJADENA.m_AudioClip;
			m_CurrentSound.m_bLoop = JBNBLJADENA.m_bSoundLoop;
			m_CurrentSound.m_fVolume = JBNBLJADENA.m_fSoundVolume;
			m_CurrentSound.m_fPitch = JBNBLJADENA.m_fSoundPitch;
			m_CurrentSound.enabled = true;
			m_CurrentSound.Replay();
		}
	}

	private void MKLIIEJGHGL()
	{
		if (m_CurrentEffect != null)
		{
			UnityEngine.Object.Destroy(m_CurrentEffect);
		}
		m_CurrentEffect = null;
	}

	public void OnAnimationStartFrame(NcSpriteAnimation OEDLMJEKAJB)
	{
	}

	public static void UpdatePlane(MeshFilter AHDBGOOLDPN, float GBHHBOOAGCK, NcFrameInfo BFNJPLCMKMK, bool PJCEKOCBLFM, BGEMPPKCKFA CHJCAGOFMJH, float FGAIJFNIBAL)
	{
		Vector2 vector = new Vector2(GBHHBOOAGCK * BFNJPLCMKMK.m_FrameScale.x, GBHHBOOAGCK * BFNJPLCMKMK.m_FrameScale.y);
		float num;
		switch (CHJCAGOFMJH)
		{
		case BGEMPPKCKFA.BOTTOM:
			num = 1f * vector.y;
			break;
		case BGEMPPKCKFA.TOP:
			num = -1f * vector.y;
			break;
		default:
			num = 0f;
			break;
		}
		float num2 = num;
		float num3;
		switch (CHJCAGOFMJH)
		{
		case BGEMPPKCKFA.LEFTCENTER:
			num3 = 1f * vector.x;
			break;
		case BGEMPPKCKFA.RIGHTCENTER:
			num3 = -1f * vector.x;
			break;
		default:
			num3 = 0f;
			break;
		}
		float num4 = num3;
		Rect frameUvOffset = BFNJPLCMKMK.m_FrameUvOffset;
		if (PJCEKOCBLFM)
		{
			frameUvOffset.center = Vector2.zero;
		}
		Vector3[] array = new Vector3[4];
		if (CHJCAGOFMJH == BGEMPPKCKFA.LEFTCENTER && 0f < FGAIJFNIBAL)
		{
			array[0] = new Vector3(frameUvOffset.xMax * vector.x * FGAIJFNIBAL + num4 * FGAIJFNIBAL, frameUvOffset.yMax * vector.y + num2);
			array[1] = new Vector3(frameUvOffset.xMax * vector.x * FGAIJFNIBAL + num4 * FGAIJFNIBAL, frameUvOffset.yMin * vector.y + num2);
		}
		else
		{
			array[0] = new Vector3(frameUvOffset.xMax * vector.x + num4, frameUvOffset.yMax * vector.y + num2);
			array[1] = new Vector3(frameUvOffset.xMax * vector.x + num4, frameUvOffset.yMin * vector.y + num2);
		}
		array[2] = new Vector3(frameUvOffset.xMin * vector.x, frameUvOffset.yMin * vector.y + num2);
		array[3] = new Vector3(frameUvOffset.xMin * vector.x, frameUvOffset.yMax * vector.y + num2);
		AHDBGOOLDPN.mesh.vertices = array;
		AHDBGOOLDPN.mesh.RecalculateBounds();
	}

	public NcSpriteNode GetSpriteNode(int FCGCJHHFBNP)
	{
		if (m_SpriteList == null || FCGCJHHFBNP < 0 || m_SpriteList.Count <= FCGCJHHFBNP)
		{
			return null;
		}
		return m_SpriteList[FCGCJHHFBNP];
	}

	public int GetCurrentSpriteIndex()
	{
		return m_nCurrentIndex;
	}

	public void OnChangingSprite(int IFMEOJNGNPH, int GGLEEBKEBIJ)
	{
		CAKIEFONIAE = false;
		MKLIIEJGHGL();
	}

	public GameObject LPBMKKMNDKD(int HAEJJANBMFM, Transform DKCHGFBAOHK)
	{
		GameObject gameObject = null;
		if (m_SpriteList[HAEJJANBMFM].m_EffectPrefab != null)
		{
			gameObject = CreateGameObject("hit2" + m_SpriteList[HAEJJANBMFM].m_EffectPrefab.name);
			if (gameObject == null)
			{
				return null;
			}
			ECGDLEFCBKB(DKCHGFBAOHK, gameObject.transform, false, null);
			NcAttachPrefab ncAttachPrefab = gameObject.AddComponent<NcAttachPrefab>();
			ncAttachPrefab.m_AttachPrefab = m_SpriteList[HAEJJANBMFM].m_EffectPrefab;
			ncAttachPrefab.m_fPrefabSpeed = m_SpriteList[HAEJJANBMFM].m_fEffectSpeed;
			ncAttachPrefab.m_bDetachParent = m_SpriteList[HAEJJANBMFM].m_bEffectDetach;
			ncAttachPrefab.m_nSpriteFactoryIndex = m_SpriteList[HAEJJANBMFM].m_nSpriteFactoryIndex;
			ncAttachPrefab.UpdateImmediately();
			gameObject.transform.localScale *= m_SpriteList[HAEJJANBMFM].m_fEffectScale;
			gameObject.transform.localPosition += m_SpriteList[HAEJJANBMFM].m_EffectPos;
			gameObject.transform.localRotation *= Quaternion.Euler(m_SpriteList[HAEJJANBMFM].m_EffectRot);
		}
		return gameObject;
	}

	public static void ELEKIBFCEKD(MeshFilter AHDBGOOLDPN, Rect LKNIPAJLBEK, BGEMPPKCKFA CHJCAGOFMJH, float FGAIJFNIBAL)
	{
		Vector2[] array = new Vector2[1];
		float num = 712f;
		if (CHJCAGOFMJH == (BGEMPPKCKFA)7 && 679f < FGAIJFNIBAL)
		{
			num = FGAIJFNIBAL;
		}
		array[0] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		array[0] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y);
		array[5] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y);
		array[0] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		AHDBGOOLDPN.mesh.uv = array;
	}

	public NcSpriteNode GetSpriteNode(string ADNCNHHHCBF)
	{
		if (m_SpriteList == null)
		{
			return null;
		}
		foreach (NcSpriteNode sprite in m_SpriteList)
		{
			if (sprite.m_SpriteName == ADNCNHHHCBF)
			{
				return sprite;
			}
		}
		return null;
	}

	private void CFJKHPNIODE()
	{
		MNBKJKCNMLD = false;
	}

	public NcSpriteNode ADJAHDPKKFN(int FCGCJHHFBNP)
	{
		if (m_SpriteList == null || FCGCJHHFBNP < 0 || m_SpriteList.Count <= FCGCJHHFBNP)
		{
			return null;
		}
		return m_SpriteList[FCGCJHHFBNP];
	}

	public int AddSpriteNode()
	{
		NcSpriteNode item = new NcSpriteNode();
		if (m_SpriteList == null)
		{
			m_SpriteList = new List<NcSpriteNode>();
		}
		m_SpriteList.Add(item);
		return m_SpriteList.Count - 1;
	}

	public Rect BMAIALGGBLF(int LMNLPLBMOLD, int FDOPNPLBJNA)
	{
		if (m_SpriteList.Count <= LMNLPLBMOLD || m_SpriteList[LMNLPLBMOLD].m_FrameInfos == null || m_SpriteList[LMNLPLBMOLD].m_FrameInfos.Length <= FDOPNPLBJNA)
		{
			return new Rect(1921f, 725f, 273f, 768f);
		}
		return m_SpriteList[LMNLPLBMOLD].m_FrameInfos[FDOPNPLBJNA].m_TextureUvOffset;
	}

	public bool IsEndSprite()
	{
		if (m_SpriteList == null || m_nCurrentIndex < 0 || m_SpriteList.Count <= m_nCurrentIndex)
		{
			return true;
		}
		if (IsUnused(m_nCurrentIndex) || m_SpriteList[m_nCurrentIndex].JLNKCKGAPDM())
		{
			return true;
		}
		return CAKIEFONIAE;
	}

	public static void UpdateMeshUVs(MeshFilter AHDBGOOLDPN, Rect LKNIPAJLBEK, BGEMPPKCKFA CHJCAGOFMJH, float FGAIJFNIBAL)
	{
		Vector2[] array = new Vector2[4];
		float num = 1f;
		if (CHJCAGOFMJH == BGEMPPKCKFA.LEFTCENTER && 0f < FGAIJFNIBAL)
		{
			num = FGAIJFNIBAL;
		}
		array[0] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		array[1] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y);
		array[2] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y);
		array[3] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		AHDBGOOLDPN.mesh.uv = array;
	}

	public int GetSpriteNodeCount()
	{
		if (m_SpriteList == null)
		{
			return 0;
		}
		return m_SpriteList.Count;
	}

	public static void LDNCKLMOKIN(MeshFilter AHDBGOOLDPN, Rect LKNIPAJLBEK, BGEMPPKCKFA CHJCAGOFMJH, float FGAIJFNIBAL)
	{
		Vector2[] array = new Vector2[2];
		float num = 1354f;
		if (CHJCAGOFMJH == BGEMPPKCKFA.RIGHTCENTER && 1433f < FGAIJFNIBAL)
		{
			num = FGAIJFNIBAL;
		}
		array[1] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		array[0] = new Vector2(LKNIPAJLBEK.x + LKNIPAJLBEK.width * num, LKNIPAJLBEK.y);
		array[8] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y);
		array[5] = new Vector2(LKNIPAJLBEK.x, LKNIPAJLBEK.y + LKNIPAJLBEK.height);
		AHDBGOOLDPN.mesh.uv = array;
	}

	private void ABMMGINPLAD()
	{
		MNBKJKCNMLD = true;
	}

	public NcEffectBehaviour SetSprite(int CEGOHOIDIOA)
	{
		return SetSprite(CEGOHOIDIOA, true);
	}
}
