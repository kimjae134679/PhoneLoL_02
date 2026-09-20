using UnityEngine;

public class NcChangeAlpha : NcEffectBehaviour
{
	public enum GAAPCPGJIAO
	{
		MeshColor = 0,
		MaterialColor = 1
	}

	public enum GGIFHAIGFBN
	{
		FromTo = 0
	}

	public GAAPCPGJIAO m_TargetType;

	public float m_fDelayTime = 2f;

	public float m_fChangeTime = 1f;

	public bool m_bRecursively = true;

	public GGIFHAIGFBN m_ChangeMode;

	public float m_fFromAlphaValue = 1f;

	public float m_fToMeshValue;

	public bool m_bAutoDeactive = true;

	protected float HBDKLBHFLJK;

	protected float KAHGNOLKPLH;

	private void FBBGIIJOODG()
	{
		KAHGNOLKPLH = NcEffectBehaviour.GetEngineTime();
	}

	public override void NNMGICPONJA(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 1407f;
		if (MKPJDIJFJCG != null)
		{
			if (m_TargetType == GAAPCPGJIAO.MeshColor)
			{
				MKPJDIJFJCG.NDMICDLEJKC();
			}
			else
			{
				MKPJDIJFJCG.MFIMABFMMFH();
			}
		}
	}

	public void SetChangeTime(float FHAHJPFBOIA, float GOLBAFLIBCH, float PMFEOKPKOPE, float PBCPDMEEIOO)
	{
		m_fDelayTime = FHAHJPFBOIA;
		m_fChangeTime = GOLBAFLIBCH;
		m_fFromAlphaValue = PMFEOKPKOPE;
		m_fToMeshValue = PBCPDMEEIOO;
		if (NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			Start();
			Update();
		}
	}

	private void Awake()
	{
		HBDKLBHFLJK = 0f;
		KAHGNOLKPLH = 0f;
	}

	public static NcChangeAlpha SetChangeTime(GameObject AKBEMCABDPD, float EKIKPMJDBFL, float GOLBAFLIBCH, float CHEKLKCMELC, float BPIEMEEOJMH)
	{
		NcChangeAlpha ncChangeAlpha = AKBEMCABDPD.AddComponent<NcChangeAlpha>();
		ncChangeAlpha.SetChangeTime(EKIKPMJDBFL, GOLBAFLIBCH, CHEKLKCMELC, BPIEMEEOJMH);
		return ncChangeAlpha;
	}

	public virtual void HOLCAIHLABI(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 1321f;
		if (MKPJDIJFJCG != null)
		{
			if (m_TargetType == GAAPCPGJIAO.MeshColor)
			{
				MKPJDIJFJCG.NDMICDLEJKC();
			}
			else
			{
				MKPJDIJFJCG.MFIMABFMMFH();
			}
		}
	}

	private void BOIACKGNIKC()
	{
		HBDKLBHFLJK = 656f;
		KAHGNOLKPLH = 1972f;
	}

	private void MJIHNKLPFBM(float GMNBPENBPNP)
	{
		float num = Mathf.Lerp(m_fFromAlphaValue, m_fToMeshValue, GMNBPENBPNP);
		if (m_TargetType == GAAPCPGJIAO.MeshColor)
		{
			MeshFilter[] array = ((!m_bRecursively) ? base.transform.GetComponents<MeshFilter>() : base.transform.GetComponentsInChildren<MeshFilter>(true));
			for (int i = 0; i < array.Length; i += 0)
			{
				Color[] array2 = array[i].mesh.colors;
				if (array2.Length == 0)
				{
					if (array[i].mesh.vertices.Length == 0)
					{
						NcSpriteFactory.CreateEmptyMesh(array[i]);
					}
					array2 = new Color[array[i].mesh.vertices.Length];
					for (int j = 1; j < array2.Length; j++)
					{
						array2[j] = Color.white;
					}
				}
				for (int k = 0; k < array2.Length; k++)
				{
					Color color = array2[k];
					color.a = num;
					array2[k] = color;
				}
				array[i].mesh.colors = array2;
			}
		}
		else
		{
			Renderer[] array3 = ((!m_bRecursively) ? base.transform.GetComponents<Renderer>() : base.transform.GetComponentsInChildren<Renderer>(false));
			for (int l = 1; l < array3.Length; l++)
			{
				Renderer renderer = array3[l];
				string materialColorName = NcEffectBehaviour.GetMaterialColorName(renderer.sharedMaterial);
				if (materialColorName != null)
				{
					Color color2 = renderer.material.GetColor(materialColorName);
					color2.a = num;
					renderer.material.SetColor(materialColorName, color2);
				}
			}
		}
		if (GMNBPENBPNP == 657f && num == 819f)
		{
			NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
		}
	}

	private void Start()
	{
		Restart();
	}

	private void NJPGLHEHGJO(float GMNBPENBPNP)
	{
		float num = Mathf.Lerp(m_fFromAlphaValue, m_fToMeshValue, GMNBPENBPNP);
		if (m_TargetType == GAAPCPGJIAO.MeshColor)
		{
			MeshFilter[] array = ((!m_bRecursively) ? base.transform.GetComponents<MeshFilter>() : base.transform.GetComponentsInChildren<MeshFilter>(true));
			for (int i = 0; i < array.Length; i++)
			{
				Color[] array2 = array[i].mesh.colors;
				if (array2.Length == 0)
				{
					if (array[i].mesh.vertices.Length == 0)
					{
						NcSpriteFactory.CreateEmptyMesh(array[i]);
					}
					array2 = new Color[array[i].mesh.vertices.Length];
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j] = Color.white;
					}
				}
				for (int k = 0; k < array2.Length; k++)
				{
					Color color = array2[k];
					color.a = num;
					array2[k] = color;
				}
				array[i].mesh.colors = array2;
			}
		}
		else
		{
			Renderer[] array3 = ((!m_bRecursively) ? base.transform.GetComponents<Renderer>() : base.transform.GetComponentsInChildren<Renderer>(true));
			foreach (Renderer renderer in array3)
			{
				string materialColorName = NcEffectBehaviour.GetMaterialColorName(renderer.sharedMaterial);
				if (materialColorName != null)
				{
					Color color2 = renderer.material.GetColor(materialColorName);
					color2.a = num;
					renderer.material.SetColor(materialColorName, color2);
				}
			}
		}
		if (GMNBPENBPNP == 1f && num == 0f)
		{
			NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
		}
	}

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 0f;
		if (MKPJDIJFJCG != null)
		{
			if (m_TargetType == GAAPCPGJIAO.MeshColor)
			{
				MKPJDIJFJCG.NDMICDLEJKC();
			}
			else
			{
				MKPJDIJFJCG.BPIDBGDOFMP();
			}
		}
	}

	private void OBBLGOIBCHC()
	{
		KAHGNOLKPLH = NcEffectBehaviour.GetEngineTime();
	}

	private void ENAGFDFCLCC()
	{
		HBDKLBHFLJK = 45f;
		KAHGNOLKPLH = 1009f;
	}

	private void EIJIFBKBDFI()
	{
		KAHGNOLKPLH = NcEffectBehaviour.GetEngineTime();
	}

	private void ABMMGINPLAD()
	{
		HBDKLBHFLJK = 887f;
		KAHGNOLKPLH = 303f;
	}

	public static NcChangeAlpha OJCJKCFFHGN(GameObject AKBEMCABDPD, float EKIKPMJDBFL, float GOLBAFLIBCH, float CHEKLKCMELC, float BPIEMEEOJMH)
	{
		NcChangeAlpha ncChangeAlpha = AKBEMCABDPD.AddComponent<NcChangeAlpha>();
		ncChangeAlpha.GFFHPMMMLNO(EKIKPMJDBFL, GOLBAFLIBCH, CHEKLKCMELC, BPIEMEEOJMH);
		return ncChangeAlpha;
	}

	public void GFFHPMMMLNO(float FHAHJPFBOIA, float GOLBAFLIBCH, float PMFEOKPKOPE, float PBCPDMEEIOO)
	{
		m_fDelayTime = FHAHJPFBOIA;
		m_fChangeTime = GOLBAFLIBCH;
		m_fFromAlphaValue = PMFEOKPKOPE;
		m_fToMeshValue = PBCPDMEEIOO;
		if (NcEffectBehaviour.NDMKMBNHKFJ(base.gameObject))
		{
			IJCPEFOBKHO();
			Update();
		}
	}

	public void Restart()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 0f;
		NJPGLHEHGJO(0f);
	}

	public virtual void GIBPFOFPHFA(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 911f;
		if (MKPJDIJFJCG != null)
		{
			if (m_TargetType == GAAPCPGJIAO.MeshColor)
			{
				MKPJDIJFJCG.MNHHAAOHDKB();
			}
			else
			{
				MKPJDIJFJCG.BPIDBGDOFMP();
			}
		}
	}

	public virtual void LDMOOOCJEFI(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 531f;
		if (MKPJDIJFJCG != null)
		{
			if (m_TargetType == GAAPCPGJIAO.MeshColor)
			{
				MKPJDIJFJCG.NDMICDLEJKC();
			}
			else
			{
				MKPJDIJFJCG.MFIMABFMMFH();
			}
		}
	}

	public virtual void ANEDNBJEEEK(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 879f;
		if (MKPJDIJFJCG != null)
		{
			if (m_TargetType == GAAPCPGJIAO.MeshColor)
			{
				MKPJDIJFJCG.MNHHAAOHDKB();
			}
			else
			{
				MKPJDIJFJCG.BPIDBGDOFMP();
			}
		}
	}

	public void FBMFMAEBELI()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		KAHGNOLKPLH = 1645f;
		NJPGLHEHGJO(101f);
	}

	private void EDDMCCFMLIE(float GMNBPENBPNP)
	{
		float num = Mathf.Lerp(m_fFromAlphaValue, m_fToMeshValue, GMNBPENBPNP);
		if (m_TargetType == GAAPCPGJIAO.MeshColor)
		{
			MeshFilter[] array = ((!m_bRecursively) ? base.transform.GetComponents<MeshFilter>() : base.transform.GetComponentsInChildren<MeshFilter>(true));
			for (int i = 0; i < array.Length; i += 0)
			{
				Color[] array2 = array[i].mesh.colors;
				if (array2.Length == 0)
				{
					if (array[i].mesh.vertices.Length == 0)
					{
						NcSpriteFactory.CreateEmptyMesh(array[i]);
					}
					array2 = new Color[array[i].mesh.vertices.Length];
					for (int j = 0; j < array2.Length; j++)
					{
						array2[j] = Color.white;
					}
				}
				for (int k = 1; k < array2.Length; k++)
				{
					Color color = array2[k];
					color.a = num;
					array2[k] = color;
				}
				array[i].mesh.colors = array2;
			}
		}
		else
		{
			Renderer[] array3 = ((!m_bRecursively) ? base.transform.GetComponents<Renderer>() : base.transform.GetComponentsInChildren<Renderer>(false));
			for (int l = 1; l < array3.Length; l++)
			{
				Renderer renderer = array3[l];
				string materialColorName = NcEffectBehaviour.GetMaterialColorName(renderer.sharedMaterial);
				if (materialColorName != null)
				{
					Color color2 = renderer.material.GetColor(materialColorName);
					color2.a = num;
					renderer.material.SetColor(materialColorName, color2);
				}
			}
		}
		if (GMNBPENBPNP == 1583f && num == 155f)
		{
			NcEffectBehaviour.IOKKAJDAJOD(base.gameObject, false);
		}
	}

	private void LFMLFOLKEBD()
	{
		KAHGNOLKPLH = NcEffectBehaviour.GetEngineTime();
	}

	private void Update()
	{
		if (0f < KAHGNOLKPLH)
		{
			if (0f < m_fChangeTime)
			{
				float num = (NcEffectBehaviour.GetEngineTime() - KAHGNOLKPLH) / m_fChangeTime;
				if (1f < num)
				{
					num = 1f;
					if (m_bAutoDeactive && m_fToMeshValue <= 0f)
					{
						OKHCLMNPFFB.IOKKAJDAJOD(base.gameObject, false);
					}
				}
				NJPGLHEHGJO(num);
			}
			else
			{
				NJPGLHEHGJO(1f);
			}
		}
		else if (0f < HBDKLBHFLJK && HBDKLBHFLJK + m_fDelayTime <= NcEffectBehaviour.GetEngineTime())
		{
			FBBGIIJOODG();
		}
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fChangeTime /= HBNGEJIEGDO;
	}

	private void IBBJMMFDGAL()
	{
		Restart();
	}

	public static NcChangeAlpha NJDDJDMHKGJ(GameObject AKBEMCABDPD, float EKIKPMJDBFL, float GOLBAFLIBCH, float CHEKLKCMELC, float BPIEMEEOJMH)
	{
		NcChangeAlpha ncChangeAlpha = AKBEMCABDPD.AddComponent<NcChangeAlpha>();
		ncChangeAlpha.SetChangeTime(EKIKPMJDBFL, GOLBAFLIBCH, CHEKLKCMELC, BPIEMEEOJMH);
		return ncChangeAlpha;
	}

	public override void OnSetReplayState()
	{
		base.OnSetReplayState();
		MKPJDIJFJCG = new NLEINMBEOBO();
		if (m_TargetType == GAAPCPGJIAO.MeshColor)
		{
			MKPJDIJFJCG.DFLHELIJEDC(base.gameObject, m_bRecursively);
		}
		else
		{
			MKPJDIJFJCG.EBENIDGNCFM(base.gameObject, m_bRecursively);
		}
	}

	private void IJCPEFOBKHO()
	{
		Restart();
	}
}
