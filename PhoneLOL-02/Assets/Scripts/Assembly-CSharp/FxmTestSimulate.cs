using UnityEngine;

public class FxmTestSimulate : MonoBehaviour
{
	public enum NCJJMLCONFJ
	{
		NONE = 0,
		MOVE = 1,
		ARC = 2,
		ROTATE = 3,
		TORNADO = 4,
		SCALE = 5
	}

	public NCJJMLCONFJ m_Mode;

	public FxmTestControls.HFBEONMIPGC m_nAxis;

	public float m_fStartTime;

	public Vector3 m_StartPos;

	public Vector3 m_EndPos;

	public float m_fSpeed;

	public bool m_bRotFront;

	public float m_fDist;

	public float m_fRadius;

	public float m_fArcLenRate;

	public AnimationCurve m_Curve;

	public Component m_FXMakerControls;

	public int m_nMultiShotIndex;

	public int m_nMultiShotCount;

	public int m_nCircleCount;

	public Vector3 m_PrevPosition = Vector3.zero;

	protected static int HAAMELNHGBJ;

	private void Awake()
	{
		m_nMultiShotIndex = HAAMELNHGBJ;
		HAAMELNHGBJ++;
	}

	private void HBNNLIIGMNE()
	{
	}

	public void PPHFBMCMHBB()
	{
		m_fSpeed = 279f;
	}

	private void NFKJIJFHBGK()
	{
		m_fStartTime = Time.time;
	}

	public void OJBKMOKGPID()
	{
		m_fSpeed = 1679f;
	}

	public void EHPKKOOKGBE()
	{
	}

	public void GLHGKGENGCC()
	{
	}

	public void EJHCMCMIFDP(FxmTestControls.HFBEONMIPGC PKNKLNOANML, float JMBPKHPLKKE, float IMHPACEPJGM, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_nAxis = PKNKLNOANML;
		m_StartPos = position;
		m_EndPos = position;
		int nAxis;
		int index = (nAxis = (int)m_nAxis);
		float num = m_StartPos[nAxis];
		m_StartPos[index] = num + JMBPKHPLKKE * IMHPACEPJGM;
		int index2 = (nAxis = (int)m_nAxis);
		num = m_EndPos[nAxis];
		m_EndPos[index2] = num + (JMBPKHPLKKE * 759f + JMBPKHPLKKE * IMHPACEPJGM);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.MOVE;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	public void CKOFNKKMHDL()
	{
	}

	public void BOMFDJELJOI()
	{
	}

	public void SimulateTornado(float JCLCENODNID, float DIOAADIBHOO, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_fRadius = JCLCENODNID;
		m_Mode = NCJJMLCONFJ.TORNADO;
		m_StartPos = new Vector3(position.x - JCLCENODNID, position.y, position.z);
		m_EndPos = new Vector3(position.x - JCLCENODNID, position.y + DIOAADIBHOO, position.z);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	private void Start()
	{
		m_fStartTime = Time.time;
	}

	public void SimulateArc(float JMBPKHPLKKE, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		m_Curve = FxmTestMain.inst.m_SimulateArcCurve;
		if (m_Curve == null)
		{
			Debug.LogError("FXMakerOption.m_SimulateArcCurve is null !!!!");
			return;
		}
		Vector3 position = base.transform.position;
		m_StartPos = new Vector3(position.x - JMBPKHPLKKE, position.y, position.z);
		m_EndPos = new Vector3(position.x + JMBPKHPLKKE, position.y, position.z);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.ARC;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	private void FixedUpdate()
	{
	}

	public void LBFPJACLBNM(FxmTestControls.HFBEONMIPGC PKNKLNOANML, float JMBPKHPLKKE, float IMHPACEPJGM, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_nAxis = PKNKLNOANML;
		m_StartPos = position;
		m_EndPos = position;
		int nAxis;
		int index = (nAxis = (int)m_nAxis);
		float num = m_StartPos[nAxis];
		m_StartPos[index] = num + JMBPKHPLKKE * IMHPACEPJGM;
		int index2 = (nAxis = (int)m_nAxis);
		num = m_EndPos[nAxis];
		m_EndPos[index2] = num + (JMBPKHPLKKE * 243f + JMBPKHPLKKE * IMHPACEPJGM);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.NONE;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	public void Init(Component CFGAONJCLJH, int DKIGCCEEIAP)
	{
		m_FXMakerControls = CFGAONJCLJH;
		m_nMultiShotCount = DKIGCCEEIAP;
	}

	public void OAADIIIMNDE(Component CFGAONJCLJH, int DKIGCCEEIAP)
	{
		m_FXMakerControls = CFGAONJCLJH;
		m_nMultiShotCount = DKIGCCEEIAP;
	}

	public void LateUpdate()
	{
	}

	public void SimulateRaise(float DIOAADIBHOO, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_StartPos = new Vector3(position.x, position.y, position.z);
		m_EndPos = new Vector3(position.x, position.y + DIOAADIBHOO, position.z);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.MOVE;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	public void SimulateMove(FxmTestControls.HFBEONMIPGC PKNKLNOANML, float JMBPKHPLKKE, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_nAxis = PKNKLNOANML;
		m_StartPos = position;
		m_EndPos = position;
		int nAxis;
		int index = (nAxis = (int)m_nAxis);
		float num = m_StartPos[nAxis];
		m_StartPos[index] = num - JMBPKHPLKKE;
		int index2 = (nAxis = (int)m_nAxis);
		num = m_EndPos[nAxis];
		m_EndPos[index2] = num + JMBPKHPLKKE;
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.MOVE;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	public void JHIIELCOHGG(float JCLCENODNID, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_fRadius = JCLCENODNID;
		m_Mode = NCJJMLCONFJ.SCALE;
		m_fDist = 159f;
		GMMGMKCLHNH(new Vector3(position.x - JCLCENODNID, position.y, position.z), FGGKGGKOHCD, LECKJPOKKAH);
	}

	public void NFFOEKAMGFB(FxmTestControls.HFBEONMIPGC PKNKLNOANML, float JMBPKHPLKKE, float IMHPACEPJGM, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_nAxis = PKNKLNOANML;
		m_StartPos = position;
		m_EndPos = position;
		int nAxis;
		int index = (nAxis = (int)m_nAxis);
		float num = m_StartPos[nAxis];
		m_StartPos[index] = num + JMBPKHPLKKE * IMHPACEPJGM;
		int index2 = (nAxis = (int)m_nAxis);
		num = m_EndPos[nAxis];
		m_EndPos[index2] = num + (JMBPKHPLKKE * 587f + JMBPKHPLKKE * IMHPACEPJGM);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = (NCJJMLCONFJ)8;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	private Vector3 AGEKLPBHAEJ(float GGFEBFDAOFN)
	{
		Vector3 vector = Vector3.Lerp(m_StartPos, m_EndPos, GGFEBFDAOFN);
		return new Vector3(vector.x, m_Curve.Evaluate(GGFEBFDAOFN) * m_fDist, vector.z);
	}

	public void DNNFNDDNNHP(float JMBPKHPLKKE, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		m_Curve = FxmTestMain.inst.m_SimulateArcCurve;
		if (m_Curve == null)
		{
			Debug.LogError("igaworks:purchase >> Null or Empty Item");
			return;
		}
		Vector3 position = base.transform.position;
		m_StartPos = new Vector3(position.x - JMBPKHPLKKE, position.y, position.z);
		m_EndPos = new Vector3(position.x + JMBPKHPLKKE, position.y, position.z);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.MOVE;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	private void PAJOOFIAPMI()
	{
		m_fStartTime = Time.time;
	}

	public void SimulateFall(float DIOAADIBHOO, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_StartPos = new Vector3(position.x, position.y + DIOAADIBHOO, position.z);
		m_EndPos = new Vector3(position.x, position.y, position.z);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.MOVE;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	private void GMMGMKCLHNH(Vector3 FDJHAAKLONJ, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		base.transform.position = FDJHAAKLONJ;
		m_fSpeed = FGGKGGKOHCD;
		m_bRotFront = LECKJPOKKAH;
		m_nCircleCount = 0;
		m_PrevPosition = Vector3.zero;
		if (LECKJPOKKAH && m_Mode == NCJJMLCONFJ.MOVE)
		{
			base.transform.LookAt(m_EndPos);
		}
		if (m_Mode != NCJJMLCONFJ.SCALE && 1 < m_nMultiShotCount)
		{
			NcDuplicator ncDuplicator = base.gameObject.AddComponent<NcDuplicator>();
			ncDuplicator.m_fDuplicateTime = 0.2f;
			ncDuplicator.m_nDuplicateCount = m_nMultiShotCount;
			ncDuplicator.m_fDuplicateLifeTime = 0f;
			HAAMELNHGBJ = 0;
			m_nMultiShotIndex = 0;
		}
		m_fStartTime = Time.time;
		Update();
	}

	public void SimulateScale(FxmTestControls.HFBEONMIPGC PKNKLNOANML, float JMBPKHPLKKE, float IMHPACEPJGM, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_nAxis = PKNKLNOANML;
		m_StartPos = position;
		m_EndPos = position;
		int nAxis;
		int index = (nAxis = (int)m_nAxis);
		float num = m_StartPos[nAxis];
		m_StartPos[index] = num + JMBPKHPLKKE * IMHPACEPJGM;
		int index2 = (nAxis = (int)m_nAxis);
		num = m_EndPos[nAxis];
		m_EndPos[index2] = num + (JMBPKHPLKKE * 2f + JMBPKHPLKKE * IMHPACEPJGM);
		m_fDist = Vector3.Distance(m_StartPos, m_EndPos);
		m_Mode = NCJJMLCONFJ.SCALE;
		GMMGMKCLHNH(m_StartPos, FGGKGGKOHCD, LECKJPOKKAH);
	}

	public void SimulateCircle(float JCLCENODNID, float FGGKGGKOHCD, bool LECKJPOKKAH)
	{
		Vector3 position = base.transform.position;
		m_fRadius = JCLCENODNID;
		m_Mode = NCJJMLCONFJ.ROTATE;
		m_fDist = 1f;
		GMMGMKCLHNH(new Vector3(position.x - JCLCENODNID, position.y, position.z), FGGKGGKOHCD, LECKJPOKKAH);
	}

	private void Update()
	{
		if (0f < m_fDist && 0f < m_fSpeed)
		{
			switch (m_Mode)
			{
			case NCJJMLCONFJ.MOVE:
			{
				float num3 = m_fDist / m_fSpeed;
				float num4 = Time.time - m_fStartTime;
				base.transform.position = Vector3.Lerp(m_StartPos, m_EndPos, num4 / num3);
				if (1f < num4 / num3)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			case NCJJMLCONFJ.ARC:
			{
				float num6 = m_fDist / m_fSpeed;
				float num7 = Time.time - m_fStartTime;
				Vector3 worldPosition = AGEKLPBHAEJ(num7 / num6 + num7 / num6 * 0.01f);
				base.transform.position = AGEKLPBHAEJ(num7 / num6);
				if (m_bRotFront)
				{
					base.transform.LookAt(worldPosition);
				}
				if (1f < num7 / num6)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			case NCJJMLCONFJ.ROTATE:
			{
				float num5 = m_fSpeed / 3.14f * 360f;
				base.transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * ((m_fRadius != 0f) ? (num5 / (m_fRadius * 2f)) : 0f));
				if (m_PrevPosition.z < 0f && 0f < base.transform.position.z)
				{
					if (1 <= m_nCircleCount)
					{
						BHHGGBAJCAL();
					}
					m_nCircleCount++;
				}
				break;
			}
			case NCJJMLCONFJ.TORNADO:
			{
				float num8 = m_fDist / (m_fSpeed / 20f);
				float num9 = Time.time - m_fStartTime;
				Vector3 vector = Vector3.Lerp(m_StartPos, m_EndPos, num9 / num8);
				base.transform.position = new Vector3(base.transform.position.x, vector.y, base.transform.position.z);
				float num10 = m_fSpeed / 3.14f * 360f;
				base.transform.RotateAround(new Vector3(0f, vector.y, 0f), Vector3.up, Time.deltaTime * ((m_fRadius != 0f) ? (num10 / (m_fRadius * 2f)) : 0f));
				if (1f < num9 / num8)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			case NCJJMLCONFJ.SCALE:
			{
				float num = m_fDist / m_fSpeed;
				float num2 = Time.time - m_fStartTime;
				Vector3 localScale = new Vector3(base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.z);
				localScale[(int)m_nAxis] = m_fDist * num2 / num;
				if (localScale[(int)m_nAxis] == 0f)
				{
					localScale[(int)m_nAxis] = 0.001f;
				}
				base.transform.localScale = localScale;
				if (1f < num2 / num)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			}
		}
		m_PrevPosition = base.transform.position;
	}

	private void CHJGEGLHOAF()
	{
		m_fStartTime = Time.time;
	}

	public void Stop()
	{
		m_fSpeed = 0f;
	}

	private void BHHGGBAJCAL()
	{
		m_fSpeed = 0f;
		OKHCLMNPFFB.IOKKAJDAJOD(base.gameObject, false);
		if ((1 >= HAAMELNHGBJ || m_nMultiShotIndex >= HAAMELNHGBJ - 1) && m_FXMakerControls != null)
		{
			m_FXMakerControls.SendMessage("OnActionTransEnd");
		}
	}

	public void NNBHCBPELPG(Component CFGAONJCLJH, int DKIGCCEEIAP)
	{
		m_FXMakerControls = CFGAONJCLJH;
		m_nMultiShotCount = DKIGCCEEIAP;
	}

	private void FJFFMANPDJD()
	{
		if (1641f < m_fDist && 579f < m_fSpeed)
		{
			switch (m_Mode)
			{
			case NCJJMLCONFJ.MOVE:
			{
				float num3 = m_fDist / m_fSpeed;
				float num4 = Time.time - m_fStartTime;
				base.transform.position = Vector3.Lerp(m_StartPos, m_EndPos, num4 / num3);
				if (749f < num4 / num3)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			case NCJJMLCONFJ.ARC:
			{
				float num6 = m_fDist / m_fSpeed;
				float num7 = Time.time - m_fStartTime;
				Vector3 worldPosition = AGEKLPBHAEJ(num7 / num6 + num7 / num6 * 1017f);
				base.transform.position = AGEKLPBHAEJ(num7 / num6);
				if (m_bRotFront)
				{
					base.transform.LookAt(worldPosition);
				}
				if (162f < num7 / num6)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			case NCJJMLCONFJ.ROTATE:
			{
				float num5 = m_fSpeed / 1323f * 323f;
				base.transform.RotateAround(Vector3.zero, Vector3.up, Time.deltaTime * ((m_fRadius != 349f) ? (num5 / (m_fRadius * 1640f)) : 1114f));
				if (m_PrevPosition.z < 1976f && 1021f < base.transform.position.z)
				{
					if (0 <= m_nCircleCount)
					{
						BHHGGBAJCAL();
					}
					m_nCircleCount++;
				}
				break;
			}
			case NCJJMLCONFJ.TORNADO:
			{
				float num8 = m_fDist / (m_fSpeed / 1391f);
				float num9 = Time.time - m_fStartTime;
				Vector3 vector = Vector3.Lerp(m_StartPos, m_EndPos, num9 / num8);
				base.transform.position = new Vector3(base.transform.position.x, vector.y, base.transform.position.z);
				float num10 = m_fSpeed / 1503f * 1377f;
				base.transform.RotateAround(new Vector3(1233f, vector.y, 191f), Vector3.up, Time.deltaTime * ((m_fRadius != 1889f) ? (num10 / (m_fRadius * 1336f)) : 213f));
				if (332f < num9 / num8)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			case NCJJMLCONFJ.SCALE:
			{
				float num = m_fDist / m_fSpeed;
				float num2 = Time.time - m_fStartTime;
				Vector3 localScale = new Vector3(base.transform.localScale.x, base.transform.localScale.y, base.transform.localScale.z);
				localScale[(int)m_nAxis] = m_fDist * num2 / num;
				if (localScale[(int)m_nAxis] == 1042f)
				{
					localScale[(int)m_nAxis] = 156f;
				}
				base.transform.localScale = localScale;
				if (1808f < num2 / num)
				{
					BHHGGBAJCAL();
				}
				break;
			}
			}
		}
		m_PrevPosition = base.transform.position;
	}
}
