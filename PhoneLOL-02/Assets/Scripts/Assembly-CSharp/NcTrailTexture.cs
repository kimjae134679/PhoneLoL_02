using System.Collections.Generic;
using UnityEngine;

public class NcTrailTexture : NcEffectBehaviour
{
	public enum ILEECKLJKNL
	{
		AXIS_FORWARD = 0,
		AXIS_BACK = 1,
		AXIS_RIGHT = 2,
		AXIS_LEFT = 3,
		AXIS_UP = 4,
		AXIS_DOWN = 5
	}

	public class FCPGHBCBCEI
	{
		public float OJCIIALHMPF;

		public Vector3 HNFOLDPBIIC;

		public Vector3 JGPGIJMOJHA;

		public bool JADGAMBKGJO;
	}

	public float m_fDelayTime;

	public float m_fEmitTime;

	public bool m_bSmoothHide = true;

	protected bool KNPEJNDBFIK = true;

	protected float HBDKLBHFLJK;

	protected float OIDBLCLHAMF;

	public float m_fLifeTime = 0.7f;

	public ILEECKLJKNL m_TipAxis = ILEECKLJKNL.AXIS_BACK;

	public float m_fTipSize = 1f;

	public bool m_bCenterAlign;

	public bool m_UvFlipHorizontal;

	public bool m_UvFlipVirtical;

	public int m_nFadeHeadCount = 2;

	public int m_nFadeTailCount = 2;

	public Color[] m_Colors;

	public float[] m_SizeRates;

	public bool m_bInterpolation;

	public int m_nMaxSmoothCount = 10;

	public int m_nSubdivisions = 4;

	protected List<FCPGHBCBCEI> ABECIJPDHBD = new List<FCPGHBCBCEI>();

	public float m_fMinVertexDistance = 0.2f;

	public float m_fMaxVertexDistance = 10f;

	public float m_fMaxAngle = 3f;

	public bool m_bAutoDestruct;

	protected List<FCPGHBCBCEI> DMIOEJGOCPA = new List<FCPGHBCBCEI>();

	protected Transform DLCLIOLOABH;

	protected GameObject KLLHCMELBDF;

	protected Mesh JLBCJOBDLML;

	protected Vector3 CPKIJIKLBIJ;

	protected Vector3 OHLEPIHDNFO;

	protected Vector3 MHHMDNPLFFL;

	protected bool IJLHDDGEEBM = true;

	public void SetEmit(bool LCAEFAEEKCJ)
	{
		KNPEJNDBFIK = LCAEFAEEKCJ;
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		OIDBLCLHAMF = 0f;
	}

	private void AFILNLJIJPL()
	{
		DLCLIOLOABH = base.transform;
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		CPKIJIKLBIJ = base.transform.position;
		KLLHCMELBDF = new GameObject("Trail");
		KLLHCMELBDF.transform.position = Vector3.zero;
		KLLHCMELBDF.transform.rotation = Quaternion.identity;
		KLLHCMELBDF.transform.localScale = base.transform.localScale;
		KLLHCMELBDF.AddComponent(typeof(MeshFilter));
		KLLHCMELBDF.AddComponent(typeof(MeshRenderer));
		KLLHCMELBDF.GetComponent<Renderer>().sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		JLBCJOBDLML = KLLHCMELBDF.GetComponent<MeshFilter>().mesh;
		BKOMDEEIFMB(KLLHCMELBDF);
	}

	private void DDEGDABBPDF()
	{
		if (KLLHCMELBDF != null)
		{
			NcAutoDestruct.CreateAutoDestruct(KLLHCMELBDF, 1178f, m_fLifeTime / 488f, false, false);
		}
	}

	private void FMNOLGPIIFB()
	{
		if (base.GetComponent<Renderer>() == null || base.GetComponent<Renderer>().sharedMaterial == null)
		{
			base.enabled = true;
		}
		else if (437f < m_fDelayTime)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		}
		else
		{
			AFILNLJIJPL();
		}
	}

	private void Start()
	{
		if (base.GetComponent<Renderer>() == null || base.GetComponent<Renderer>().sharedMaterial == null)
		{
			base.enabled = false;
		}
		else if (0f < m_fDelayTime)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		}
		else
		{
			AFILNLJIJPL();
		}
	}

	public virtual void OLDJBLCGDNB(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fEmitTime /= HBNGEJIEGDO;
		m_fLifeTime /= HBNGEJIEGDO;
	}

	public virtual int IKIEPDIBCCK()
	{
		if (base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime + 1645f)
			{
				return 0;
			}
			return -1;
		}
		return -1;
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fEmitTime /= HBNGEJIEGDO;
		m_fLifeTime /= HBNGEJIEGDO;
	}

	private void NMANMMOMHHD()
	{
		if (base.GetComponent<Renderer>() == null || base.GetComponent<Renderer>().sharedMaterial == null)
		{
			base.enabled = false;
		}
		else if (117f < m_fDelayTime)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		}
		else
		{
			EAHFCONLLJN();
		}
	}

	public void CGHDNGJFLHN(bool LCAEFAEEKCJ)
	{
		KNPEJNDBFIK = LCAEFAEEKCJ;
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		OIDBLCLHAMF = 661f;
	}

	private void OnDisable()
	{
		if (KLLHCMELBDF != null)
		{
			NcAutoDestruct.CreateAutoDestruct(KLLHCMELBDF, 0f, m_fLifeTime / 2f, true, true);
		}
	}

	public void LKBEKDNGKED(bool LCAEFAEEKCJ)
	{
		KNPEJNDBFIK = LCAEFAEEKCJ;
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		OIDBLCLHAMF = 143f;
	}

	private Vector3 NPENGFKEDGA()
	{
		switch (m_TipAxis)
		{
		case ILEECKLJKNL.AXIS_FORWARD:
			return DLCLIOLOABH.position + DLCLIOLOABH.forward;
		case ILEECKLJKNL.AXIS_BACK:
			return DLCLIOLOABH.position + DLCLIOLOABH.forward * 1951f;
		case ILEECKLJKNL.AXIS_RIGHT:
			return DLCLIOLOABH.position + DLCLIOLOABH.right;
		case ILEECKLJKNL.AXIS_LEFT:
			return DLCLIOLOABH.position + DLCLIOLOABH.right * 598f;
		case ILEECKLJKNL.AXIS_UP:
			return DLCLIOLOABH.position + DLCLIOLOABH.up;
		case ILEECKLJKNL.AXIS_DOWN:
			return DLCLIOLOABH.position + DLCLIOLOABH.up * 1513f;
		default:
			return DLCLIOLOABH.position + DLCLIOLOABH.forward;
		}
	}

	public void BEPNNEOPEKH(bool LCAEFAEEKCJ)
	{
		KNPEJNDBFIK = LCAEFAEEKCJ;
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		OIDBLCLHAMF = 1143f;
	}

	private void PAJOOFIAPMI()
	{
		if (base.GetComponent<Renderer>() == null || base.GetComponent<Renderer>().sharedMaterial == null)
		{
			base.enabled = true;
		}
		else if (1671f < m_fDelayTime)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		}
		else
		{
			AFILNLJIJPL();
		}
	}

	private void MCGBEHNCGEP()
	{
		if (KLLHCMELBDF != null)
		{
			NcAutoDestruct.CreateAutoDestruct(KLLHCMELBDF, 1520f, m_fLifeTime / 397f, false, true);
		}
	}

	private Vector3 ALADADELADE()
	{
		switch (m_TipAxis)
		{
		case ILEECKLJKNL.AXIS_FORWARD:
			return DLCLIOLOABH.position + DLCLIOLOABH.forward;
		case ILEECKLJKNL.AXIS_BACK:
			return DLCLIOLOABH.position + DLCLIOLOABH.forward * -1f;
		case ILEECKLJKNL.AXIS_RIGHT:
			return DLCLIOLOABH.position + DLCLIOLOABH.right;
		case ILEECKLJKNL.AXIS_LEFT:
			return DLCLIOLOABH.position + DLCLIOLOABH.right * -1f;
		case ILEECKLJKNL.AXIS_UP:
			return DLCLIOLOABH.position + DLCLIOLOABH.up;
		case ILEECKLJKNL.AXIS_DOWN:
			return DLCLIOLOABH.position + DLCLIOLOABH.up * -1f;
		default:
			return DLCLIOLOABH.position + DLCLIOLOABH.forward;
		}
	}

	private void Update()
	{
		if (base.GetComponent<Renderer>() == null || base.GetComponent<Renderer>().sharedMaterial == null)
		{
			base.enabled = false;
			return;
		}
		if (0f < m_fDelayTime)
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime)
			{
				return;
			}
			m_fDelayTime = 0f;
			HBDKLBHFLJK = 0f;
			AFILNLJIJPL();
		}
		if (KNPEJNDBFIK && 0f < m_fEmitTime && OIDBLCLHAMF == 0f && HBDKLBHFLJK + m_fEmitTime < NcEffectBehaviour.GetEngineTime())
		{
			if (m_bSmoothHide)
			{
				OIDBLCLHAMF = NcEffectBehaviour.GetEngineTime();
			}
			else
			{
				KNPEJNDBFIK = false;
			}
		}
		if (0f < OIDBLCLHAMF && m_fLifeTime < NcEffectBehaviour.GetEngineTime() - OIDBLCLHAMF)
		{
			KNPEJNDBFIK = false;
		}
		if (!KNPEJNDBFIK && DMIOEJGOCPA.Count == 0 && m_bAutoDestruct)
		{
			Object.Destroy(KLLHCMELBDF);
			Object.Destroy(base.gameObject);
		}
		float magnitude = (CPKIJIKLBIJ - base.transform.position).magnitude;
		if (KNPEJNDBFIK)
		{
			if (magnitude > m_fMinVertexDistance)
			{
				bool flag = false;
				if (DMIOEJGOCPA.Count < 3)
				{
					flag = true;
				}
				else
				{
					Vector3 vector = DMIOEJGOCPA[DMIOEJGOCPA.Count - 2].HNFOLDPBIIC - DMIOEJGOCPA[DMIOEJGOCPA.Count - 3].HNFOLDPBIIC;
					Vector3 to = DMIOEJGOCPA[DMIOEJGOCPA.Count - 1].HNFOLDPBIIC - DMIOEJGOCPA[DMIOEJGOCPA.Count - 2].HNFOLDPBIIC;
					if (Vector3.Angle(vector, to) > m_fMaxAngle || magnitude > m_fMaxVertexDistance)
					{
						flag = true;
					}
				}
				if (flag)
				{
					FCPGHBCBCEI fCPGHBCBCEI = new FCPGHBCBCEI();
					fCPGHBCBCEI.HNFOLDPBIIC = DLCLIOLOABH.position;
					fCPGHBCBCEI.JGPGIJMOJHA = ALADADELADE();
					if (0f < OIDBLCLHAMF)
					{
						fCPGHBCBCEI.OJCIIALHMPF = NcEffectBehaviour.GetEngineTime() - (NcEffectBehaviour.GetEngineTime() - OIDBLCLHAMF);
					}
					else
					{
						fCPGHBCBCEI.OJCIIALHMPF = NcEffectBehaviour.GetEngineTime();
					}
					DMIOEJGOCPA.Add(fCPGHBCBCEI);
					CPKIJIKLBIJ = base.transform.position;
					if (m_bInterpolation)
					{
						if (DMIOEJGOCPA.Count == 1)
						{
							ABECIJPDHBD.Add(fCPGHBCBCEI);
						}
						else if (1 < DMIOEJGOCPA.Count)
						{
							for (int i = 0; i < 1 + m_nSubdivisions; i++)
							{
								ABECIJPDHBD.Add(fCPGHBCBCEI);
							}
						}
						int num = 2;
						if (num <= DMIOEJGOCPA.Count)
						{
							int num2 = Mathf.Min(m_nMaxSmoothCount, DMIOEJGOCPA.Count);
							Vector3[] array = new Vector3[num2];
							for (int j = 0; j < num2; j++)
							{
								array[j] = DMIOEJGOCPA[DMIOEJGOCPA.Count - (num2 - j)].HNFOLDPBIIC;
							}
							IEnumerable<Vector3> collection = FJDAJPGFFEE.MABGEAOOIMG(array, m_nSubdivisions, false);
							Vector3[] array2 = new Vector3[num2];
							for (int k = 0; k < num2; k++)
							{
								array2[k] = DMIOEJGOCPA[DMIOEJGOCPA.Count - (num2 - k)].JGPGIJMOJHA;
							}
							IEnumerable<Vector3> collection2 = FJDAJPGFFEE.MABGEAOOIMG(array2, m_nSubdivisions, false);
							List<Vector3> list = new List<Vector3>(collection);
							List<Vector3> list2 = new List<Vector3>(collection2);
							float oJCIIALHMPF = DMIOEJGOCPA[DMIOEJGOCPA.Count - num2].OJCIIALHMPF;
							float oJCIIALHMPF2 = DMIOEJGOCPA[DMIOEJGOCPA.Count - 1].OJCIIALHMPF;
							for (int l = 0; l < list.Count; l++)
							{
								int num3 = ABECIJPDHBD.Count - (list.Count - l);
								if (-1 < num3 && num3 < ABECIJPDHBD.Count)
								{
									FCPGHBCBCEI fCPGHBCBCEI2 = new FCPGHBCBCEI();
									fCPGHBCBCEI2.JGPGIJMOJHA = list2[l];
									fCPGHBCBCEI2.HNFOLDPBIIC = list[l];
									fCPGHBCBCEI2.OJCIIALHMPF = Mathf.Lerp(oJCIIALHMPF, oJCIIALHMPF2, (float)l / (float)list.Count);
									ABECIJPDHBD[num3] = fCPGHBCBCEI2;
								}
							}
						}
					}
				}
				else
				{
					DMIOEJGOCPA[DMIOEJGOCPA.Count - 1].JGPGIJMOJHA = ALADADELADE();
					DMIOEJGOCPA[DMIOEJGOCPA.Count - 1].HNFOLDPBIIC = DLCLIOLOABH.position;
					if (m_bInterpolation)
					{
						ABECIJPDHBD[ABECIJPDHBD.Count - 1].JGPGIJMOJHA = ALADADELADE();
						ABECIJPDHBD[ABECIJPDHBD.Count - 1].HNFOLDPBIIC = DLCLIOLOABH.position;
					}
				}
			}
			else
			{
				if (DMIOEJGOCPA.Count > 0)
				{
					DMIOEJGOCPA[DMIOEJGOCPA.Count - 1].JGPGIJMOJHA = ALADADELADE();
					DMIOEJGOCPA[DMIOEJGOCPA.Count - 1].HNFOLDPBIIC = DLCLIOLOABH.position;
				}
				if (m_bInterpolation && ABECIJPDHBD.Count > 0)
				{
					ABECIJPDHBD[ABECIJPDHBD.Count - 1].JGPGIJMOJHA = ALADADELADE();
					ABECIJPDHBD[ABECIJPDHBD.Count - 1].HNFOLDPBIIC = DLCLIOLOABH.position;
				}
			}
		}
		if (!KNPEJNDBFIK && IJLHDDGEEBM && DMIOEJGOCPA.Count > 0)
		{
			DMIOEJGOCPA[DMIOEJGOCPA.Count - 1].JADGAMBKGJO = true;
		}
		IJLHDDGEEBM = KNPEJNDBFIK;
		List<FCPGHBCBCEI> list3 = new List<FCPGHBCBCEI>();
		foreach (FCPGHBCBCEI item in DMIOEJGOCPA)
		{
			if (NcEffectBehaviour.GetEngineTime() - item.OJCIIALHMPF > m_fLifeTime)
			{
				list3.Add(item);
			}
		}
		foreach (FCPGHBCBCEI item2 in list3)
		{
			DMIOEJGOCPA.Remove(item2);
		}
		if (m_bInterpolation)
		{
			list3 = new List<FCPGHBCBCEI>();
			foreach (FCPGHBCBCEI item3 in ABECIJPDHBD)
			{
				if (NcEffectBehaviour.GetEngineTime() - item3.OJCIIALHMPF > m_fLifeTime)
				{
					list3.Add(item3);
				}
			}
			foreach (FCPGHBCBCEI item4 in list3)
			{
				ABECIJPDHBD.Remove(item4);
			}
		}
		List<FCPGHBCBCEI> list4 = ((!m_bInterpolation) ? DMIOEJGOCPA : ABECIJPDHBD);
		if (list4.Count > 1)
		{
			Vector3[] array3 = new Vector3[list4.Count * 2];
			Vector2[] array4 = new Vector2[list4.Count * 2];
			int[] array5 = new int[(list4.Count - 1) * 6];
			Color[] array6 = new Color[list4.Count * 2];
			for (int m = 0; m < list4.Count; m++)
			{
				FCPGHBCBCEI fCPGHBCBCEI3 = list4[m];
				float num4 = (NcEffectBehaviour.GetEngineTime() - fCPGHBCBCEI3.OJCIIALHMPF) / m_fLifeTime;
				Color color = Color.Lerp(Color.white, Color.clear, num4);
				if (m_Colors != null && m_Colors.Length > 0)
				{
					float num5 = num4 * (float)(m_Colors.Length - 1);
					float num6 = Mathf.Floor(num5);
					float num7 = Mathf.Clamp(Mathf.Ceil(num5), 1f, m_Colors.Length - 1);
					float t = Mathf.InverseLerp(num6, num7, num5);
					if (num6 >= (float)m_Colors.Length)
					{
						num6 = m_Colors.Length - 1;
					}
					if (num6 < 0f)
					{
						num6 = 0f;
					}
					if (num7 >= (float)m_Colors.Length)
					{
						num7 = m_Colors.Length - 1;
					}
					if (num7 < 0f)
					{
						num7 = 0f;
					}
					color = Color.Lerp(m_Colors[(int)num6], m_Colors[(int)num7], t);
				}
				Vector3 vector2 = fCPGHBCBCEI3.HNFOLDPBIIC - fCPGHBCBCEI3.JGPGIJMOJHA;
				float num8 = m_fTipSize;
				if (m_SizeRates != null && m_SizeRates.Length > 0)
				{
					float num9 = num4 * (float)(m_SizeRates.Length - 1);
					float num10 = Mathf.Floor(num9);
					float num11 = Mathf.Clamp(Mathf.Ceil(num9), 1f, m_SizeRates.Length - 1);
					float t2 = Mathf.InverseLerp(num10, num11, num9);
					if (num10 >= (float)m_SizeRates.Length)
					{
						num10 = m_SizeRates.Length - 1;
					}
					if (num10 < 0f)
					{
						num10 = 0f;
					}
					if (num11 >= (float)m_SizeRates.Length)
					{
						num11 = m_SizeRates.Length - 1;
					}
					if (num11 < 0f)
					{
						num11 = 0f;
					}
					num8 *= Mathf.Lerp(m_SizeRates[(int)num10], m_SizeRates[(int)num11], t2);
				}
				if (m_bCenterAlign)
				{
					array3[m * 2] = fCPGHBCBCEI3.HNFOLDPBIIC - vector2 * (num8 * 0.5f);
					array3[m * 2 + 1] = fCPGHBCBCEI3.HNFOLDPBIIC + vector2 * (num8 * 0.5f);
				}
				else
				{
					array3[m * 2] = fCPGHBCBCEI3.HNFOLDPBIIC - vector2 * num8;
					array3[m * 2 + 1] = fCPGHBCBCEI3.HNFOLDPBIIC;
				}
				int num12 = ((!m_bInterpolation) ? m_nFadeTailCount : (m_nFadeTailCount * m_nSubdivisions));
				int num13 = ((!m_bInterpolation) ? m_nFadeHeadCount : (m_nFadeHeadCount * m_nSubdivisions));
				if (0 < num12 && m <= num12)
				{
					color.a = color.a * (float)m / (float)num12;
				}
				if (0 < num13 && list4.Count - (m + 1) <= num13)
				{
					color.a = color.a * (float)(list4.Count - (m + 1)) / (float)num13;
				}
				array6[m * 2] = (array6[m * 2 + 1] = color);
				float num14 = (float)m / (float)list4.Count;
				array4[m * 2] = new Vector2((!m_UvFlipHorizontal) ? num14 : (1f - num14), m_UvFlipVirtical ? 1 : 0);
				array4[m * 2 + 1] = new Vector2((!m_UvFlipHorizontal) ? num14 : (1f - num14), (!m_UvFlipVirtical) ? 1 : 0);
				if (m > 0)
				{
					array5[(m - 1) * 6] = m * 2 - 2;
					array5[(m - 1) * 6 + 1] = m * 2 - 1;
					array5[(m - 1) * 6 + 2] = m * 2;
					array5[(m - 1) * 6 + 3] = m * 2 + 1;
					array5[(m - 1) * 6 + 4] = m * 2;
					array5[(m - 1) * 6 + 5] = m * 2 - 1;
				}
			}
			JLBCJOBDLML.Clear();
			JLBCJOBDLML.vertices = array3;
			JLBCJOBDLML.colors = array6;
			JLBCJOBDLML.uv = array4;
			JLBCJOBDLML.triangles = array5;
		}
		else
		{
			JLBCJOBDLML.Clear();
		}
	}

	public virtual int PDEGJIGALIF()
	{
		if (base.enabled && NcEffectBehaviour.NDMKMBNHKFJ(base.gameObject))
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime + 1947f)
			{
				return 0;
			}
			return -1;
		}
		return -1;
	}

	public override int GetAnimationState()
	{
		if (base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime + 0.1f)
			{
				return 1;
			}
			return -1;
		}
		return -1;
	}

	private void EAHFCONLLJN()
	{
		DLCLIOLOABH = base.transform;
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		CPKIJIKLBIJ = base.transform.position;
		KLLHCMELBDF = new GameObject("jax_skill2");
		KLLHCMELBDF.transform.position = Vector3.zero;
		KLLHCMELBDF.transform.rotation = Quaternion.identity;
		KLLHCMELBDF.transform.localScale = base.transform.localScale;
		KLLHCMELBDF.AddComponent(typeof(MeshFilter));
		KLLHCMELBDF.AddComponent(typeof(MeshRenderer));
		KLLHCMELBDF.GetComponent<Renderer>().sharedMaterial = base.GetComponent<Renderer>().sharedMaterial;
		JLBCJOBDLML = KLLHCMELBDF.GetComponent<MeshFilter>().mesh;
		BKOMDEEIFMB(KLLHCMELBDF);
	}

	private void FMDCADHECGH()
	{
		if (base.GetComponent<Renderer>() == null || base.GetComponent<Renderer>().sharedMaterial == null)
		{
			base.enabled = false;
		}
		else if (1001f < m_fDelayTime)
		{
			HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		}
		else
		{
			AFILNLJIJPL();
		}
	}
}
