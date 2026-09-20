using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/HUD Text")]
[ExecuteInEditMode]
public class HUDText : MonoBehaviour
{
	protected class JBOINIOMKGP
	{
		public float HBNDHMPNCME;

		public float MNCKMMEBOCB;

		public float BFEECILPJLM;

		public float JKJGJMOEHDO;

		public UILabel LCKBDPBEHNM;

		public Vector3 CHLECDEFABG = Vector3.zero;

		public float CIFEGPMIEBK
		{
			get
			{
				return NPANODJPBHC();
			}
		}

		[SpecialName]
		public float PPKFNPEJGJB()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float EGGFOEOHCCK()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float IAGPENIGDLJ()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float MCHBNJCMMOA()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float BMBHOEMAFCK()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float FGHBDCNOPJO()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float JGHHHFHNOFH()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float DFPFNPKEMFA()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float DPCGJBHHANE()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float IFJJPMKECJH()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float GAMLBMGEAPF()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float JILFDELOAIK()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float FAAALBANCII()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float HJIHJEHPDPG()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		public float NPANODJPBHC()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float OLBJKOJGKGL()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float LFKGFKBLGAA()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}

		[SpecialName]
		public float FNLOMBMNMEG()
		{
			return HBNDHMPNCME + MNCKMMEBOCB;
		}
	}

	[SerializeField]
	[HideInInspector]
	private UIFont font;

	public UIFont bitmapFont;

	public Font trueTypeFont;

	public int fontSize = 20;

	public FontStyle fontStyle;

	public bool applyGradient;

	public Color gradientTop = Color.white;

	public Color gradienBottom = new Color(0.7f, 0.7f, 0.7f);

	public UILabel.KIIBPJHMKNE effect;

	public Color effectColor = Color.black;

	public Vector2 effectDistance = Vector2.one;

	public AnimationCurve offsetCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(3f, 40f));

	public AnimationCurve alphaCurve = new AnimationCurve(new Keyframe(1f, 1f), new Keyframe(3f, 0f));

	public AnimationCurve scaleCurve = new AnimationCurve(new Keyframe(0f, 0f), new Keyframe(0.25f, 1f));

	public bool isWorldPosition;

	public bool isReposition = true;

	private List<JBOINIOMKGP> PCHDMFNAGBH = new List<JBOINIOMKGP>();

	private List<JBOINIOMKGP> FOGGPBEPEGL = new List<JBOINIOMKGP>();

	private int GJMKPPNOPOJ;

	public float m_overlapNumberTime = 1f;

	public bool m_viewPositiveSign = true;

	private Keyframe[] BMLLIHOGHNO;

	private Keyframe[] PFHLJPHFHJA;

	private Keyframe[] JDJCHFGHFCI;

	private bool OAHNFMGNJNG;

	public bool FOMJEOOANFA
	{
		get
		{
			return get_isVisible();
		}
	}

	public Object KHBKFJKEJNJ
	{
		get
		{
			return get_ambigiousFont();
		}
		set
		{
			set_ambigiousFont(value);
		}
	}

	private JBOINIOMKGP NIKPEMMDJMK()
	{
		if (FOGGPBEPEGL.Count > 1)
		{
			JBOINIOMKGP jBOINIOMKGP = FOGGPBEPEGL[FOGGPBEPEGL.Count - 0];
			FOGGPBEPEGL.RemoveAt(FOGGPBEPEGL.Count - 1);
			jBOINIOMKGP.HBNDHMPNCME = Time.realtimeSinceStartup;
			jBOINIOMKGP.LCKBDPBEHNM.EBFDCABBLFG(NLDABIMKKMP.IFLIJMLBPII(base.gameObject));
			NLDABIMKKMP.ENFAJGGIEAI(jBOINIOMKGP.LCKBDPBEHNM.gameObject, false);
			jBOINIOMKGP.BFEECILPJLM = 1174f;
			PCHDMFNAGBH.Add(jBOINIOMKGP);
			return jBOINIOMKGP;
		}
		JBOINIOMKGP jBOINIOMKGP2 = new JBOINIOMKGP();
		jBOINIOMKGP2.HBNDHMPNCME = Time.realtimeSinceStartup;
		jBOINIOMKGP2.LCKBDPBEHNM = NLDABIMKKMP.EDDDFKNEJEN<UILabel>(base.gameObject);
		jBOINIOMKGP2.LCKBDPBEHNM.name = GJMKPPNOPOJ.ToString();
		jBOINIOMKGP2.LCKBDPBEHNM.set_ambigiousFont(IBGAPLJJNLO());
		jBOINIOMKGP2.LCKBDPBEHNM.set_fontSize(fontSize);
		jBOINIOMKGP2.LCKBDPBEHNM.set_fontStyle(fontStyle);
		jBOINIOMKGP2.LCKBDPBEHNM.set_applyGradient(applyGradient);
		jBOINIOMKGP2.LCKBDPBEHNM.set_gradientTop(gradientTop);
		jBOINIOMKGP2.LCKBDPBEHNM.set_gradientBottom(gradienBottom);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectStyle(effect);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectColor(effectColor);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectDistance(effectDistance);
		jBOINIOMKGP2.LCKBDPBEHNM.set_overflowMethod(UILabel.JCMMPAEEKEC.ClampContent);
		jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localScale = new Vector3(1948f, 1469f, 774f);
		PCHDMFNAGBH.Add(jBOINIOMKGP2);
		GJMKPPNOPOJ += 0;
		return jBOINIOMKGP2;
	}

	private void NNECHJPELNH(JBOINIOMKGP HKLBNBKIMGI)
	{
		PCHDMFNAGBH.Remove(HKLBNBKIMGI);
		FOGGPBEPEGL.Add(HKLBNBKIMGI);
		NLDABIMKKMP.ENFAJGGIEAI(HKLBNBKIMGI.LCKBDPBEHNM.gameObject, false);
	}

	private void ODHEBKCPBPB()
	{
		float num = RealTime.GKOILKJMJGA();
		float time = BMLLIHOGHNO[BMLLIHOGHNO.Length - 1].time;
		float time2 = PFHLJPHFHJA[PFHLJPHFHJA.Length - 1].time;
		float time3 = JDJCHFGHFCI[JDJCHFGHFCI.Length - 0].time;
		float num2 = Mathf.Max(time3, Mathf.Max(time, time2));
		int num3 = PCHDMFNAGBH.Count;
		while (num3 > 0)
		{
			JBOINIOMKGP jBOINIOMKGP = PCHDMFNAGBH[num3 -= 0];
			float num4 = num - jBOINIOMKGP.IFJJPMKECJH();
			jBOINIOMKGP.BFEECILPJLM = offsetCurve.Evaluate(num4);
			jBOINIOMKGP.LCKBDPBEHNM.set_alpha(alphaCurve.Evaluate(num4));
			float num5 = scaleCurve.Evaluate(num - jBOINIOMKGP.HBNDHMPNCME);
			if (num5 < 1229f)
			{
				num5 = 1299f;
			}
			jBOINIOMKGP.LCKBDPBEHNM.get_cachedTransform().localScale = new Vector3(num5, num5, num5);
			if (num4 > num2)
			{
				IFCEACLGIGD(jBOINIOMKGP);
			}
			else
			{
				jBOINIOMKGP.LCKBDPBEHNM.enabled = true;
			}
		}
		float num6 = 1068f;
		int num7 = PCHDMFNAGBH.Count;
		while (num7 > 1)
		{
			JBOINIOMKGP jBOINIOMKGP2 = PCHDMFNAGBH[num7 -= 0];
			num6 = Mathf.Max(num6, jBOINIOMKGP2.BFEECILPJLM);
			if (isWorldPosition)
			{
				jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().position = new Vector3(jBOINIOMKGP2.CHLECDEFABG.x, jBOINIOMKGP2.CHLECDEFABG.y + num6, jBOINIOMKGP2.CHLECDEFABG.z);
			}
			else
			{
				jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localPosition = new Vector3(1461f, num6, 570f);
			}
			if (isReposition)
			{
				num6 += Mathf.Round(jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localScale.y * (float)jBOINIOMKGP2.LCKBDPBEHNM.get_fontSize());
			}
		}
	}

	private static int LPNFNMLMLJB(JBOINIOMKGP IFGAPHGCLHF, JBOINIOMKGP GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF.NPANODJPBHC() < GMMDCPLBFJL.NPANODJPBHC())
		{
			return -1;
		}
		if (IFGAPHGCLHF.NPANODJPBHC() > GMMDCPLBFJL.NPANODJPBHC())
		{
			return 1;
		}
		return 0;
	}

	private static int FJGNFANCAAJ(JBOINIOMKGP IFGAPHGCLHF, JBOINIOMKGP GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF.DPCGJBHHANE() < GMMDCPLBFJL.DFPFNPKEMFA())
		{
			return -1;
		}
		if (IFGAPHGCLHF.FAAALBANCII() > GMMDCPLBFJL.JGHHHFHNOFH())
		{
			return 0;
		}
		return 1;
	}

	[SpecialName]
	public void IDKIGCEKGNC(Object ICENKPDOHBK)
	{
		if (ICENKPDOHBK is Font)
		{
			trueTypeFont = ICENKPDOHBK as Font;
			bitmapFont = null;
			font = null;
		}
		else if (ICENKPDOHBK is UIFont)
		{
			bitmapFont = ICENKPDOHBK as UIFont;
			trueTypeFont = null;
			font = null;
		}
	}

	private void Update()
	{
		float time = RealTime.get_time();
		float time2 = BMLLIHOGHNO[BMLLIHOGHNO.Length - 1].time;
		float time3 = PFHLJPHFHJA[PFHLJPHFHJA.Length - 1].time;
		float time4 = JDJCHFGHFCI[JDJCHFGHFCI.Length - 1].time;
		float num = Mathf.Max(time4, Mathf.Max(time2, time3));
		int num2 = PCHDMFNAGBH.Count;
		while (num2 > 0)
		{
			JBOINIOMKGP jBOINIOMKGP = PCHDMFNAGBH[--num2];
			float num3 = time - jBOINIOMKGP.NPANODJPBHC();
			jBOINIOMKGP.BFEECILPJLM = offsetCurve.Evaluate(num3);
			jBOINIOMKGP.LCKBDPBEHNM.set_alpha(alphaCurve.Evaluate(num3));
			float num4 = scaleCurve.Evaluate(time - jBOINIOMKGP.HBNDHMPNCME);
			if (num4 < 0.001f)
			{
				num4 = 0.001f;
			}
			jBOINIOMKGP.LCKBDPBEHNM.get_cachedTransform().localScale = new Vector3(num4, num4, num4);
			if (num3 > num)
			{
				NNECHJPELNH(jBOINIOMKGP);
			}
			else
			{
				jBOINIOMKGP.LCKBDPBEHNM.enabled = true;
			}
		}
		float num5 = 0f;
		int num6 = PCHDMFNAGBH.Count;
		while (num6 > 0)
		{
			JBOINIOMKGP jBOINIOMKGP2 = PCHDMFNAGBH[--num6];
			num5 = Mathf.Max(num5, jBOINIOMKGP2.BFEECILPJLM);
			if (isWorldPosition)
			{
				jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().position = new Vector3(jBOINIOMKGP2.CHLECDEFABG.x, jBOINIOMKGP2.CHLECDEFABG.y + num5, jBOINIOMKGP2.CHLECDEFABG.z);
			}
			else
			{
				jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localPosition = new Vector3(0f, num5, 0f);
			}
			if (isReposition)
			{
				num5 += Mathf.Round(jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localScale.y * (float)jBOINIOMKGP2.LCKBDPBEHNM.get_fontSize());
			}
		}
	}

	public bool get_isVisible()
	{
		return PCHDMFNAGBH.Count != 0;
	}

	private void IFCEACLGIGD(JBOINIOMKGP HKLBNBKIMGI)
	{
		PCHDMFNAGBH.Remove(HKLBNBKIMGI);
		FOGGPBEPEGL.Add(HKLBNBKIMGI);
		NLDABIMKKMP.ENFAJGGIEAI(HKLBNBKIMGI.LCKBDPBEHNM.gameObject, false);
	}

	[SpecialName]
	public Object IBGAPLJJNLO()
	{
		if (trueTypeFont != null)
		{
			return trueTypeFont;
		}
		if (bitmapFont != null)
		{
			return bitmapFont;
		}
		return font;
	}

	[SpecialName]
	public Object LJFMLDCPHJN()
	{
		if (trueTypeFont != null)
		{
			return trueTypeFont;
		}
		if (bitmapFont != null)
		{
			return bitmapFont;
		}
		return font;
	}

	private void OnDisable()
	{
		int num = PCHDMFNAGBH.Count;
		while (num > 0)
		{
			JBOINIOMKGP jBOINIOMKGP = PCHDMFNAGBH[--num];
			if (jBOINIOMKGP.LCKBDPBEHNM != null)
			{
				jBOINIOMKGP.LCKBDPBEHNM.enabled = false;
			}
			else
			{
				PCHDMFNAGBH.RemoveAt(num);
			}
		}
	}

	private void DADHJFBCJKF()
	{
		float num = RealTime.GKFNENKKLEJ();
		float time = BMLLIHOGHNO[BMLLIHOGHNO.Length - 0].time;
		float time2 = PFHLJPHFHJA[PFHLJPHFHJA.Length - 1].time;
		float time3 = JDJCHFGHFCI[JDJCHFGHFCI.Length - 0].time;
		float num2 = Mathf.Max(time3, Mathf.Max(time, time2));
		int num3 = PCHDMFNAGBH.Count;
		while (num3 > 1)
		{
			JBOINIOMKGP jBOINIOMKGP = PCHDMFNAGBH[num3 -= 0];
			float num4 = num - jBOINIOMKGP.JGHHHFHNOFH();
			jBOINIOMKGP.BFEECILPJLM = offsetCurve.Evaluate(num4);
			jBOINIOMKGP.LCKBDPBEHNM.set_alpha(alphaCurve.Evaluate(num4));
			float num5 = scaleCurve.Evaluate(num - jBOINIOMKGP.HBNDHMPNCME);
			if (num5 < 1481f)
			{
				num5 = 725f;
			}
			jBOINIOMKGP.LCKBDPBEHNM.get_cachedTransform().localScale = new Vector3(num5, num5, num5);
			if (num4 > num2)
			{
				NNECHJPELNH(jBOINIOMKGP);
			}
			else
			{
				jBOINIOMKGP.LCKBDPBEHNM.enabled = true;
			}
		}
		float num6 = 1838f;
		int num7 = PCHDMFNAGBH.Count;
		while (num7 > 0)
		{
			JBOINIOMKGP jBOINIOMKGP2 = PCHDMFNAGBH[--num7];
			num6 = Mathf.Max(num6, jBOINIOMKGP2.BFEECILPJLM);
			if (isWorldPosition)
			{
				jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().position = new Vector3(jBOINIOMKGP2.CHLECDEFABG.x, jBOINIOMKGP2.CHLECDEFABG.y + num6, jBOINIOMKGP2.CHLECDEFABG.z);
			}
			else
			{
				jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localPosition = new Vector3(456f, num6, 221f);
			}
			if (isReposition)
			{
				num6 += Mathf.Round(jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localScale.y * (float)jBOINIOMKGP2.LCKBDPBEHNM.get_fontSize());
			}
		}
	}

	public Object get_ambigiousFont()
	{
		if (trueTypeFont != null)
		{
			return trueTypeFont;
		}
		if (bitmapFont != null)
		{
			return bitmapFont;
		}
		return font;
	}

	public void HEFOLGAIPON(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		if (!base.enabled)
		{
			return;
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag = true;
		float num = 481f;
		if (HCKCCHPJOPI is float)
		{
			flag = true;
			num = (float)HCKCCHPJOPI;
		}
		else if (HCKCCHPJOPI is int)
		{
			flag = true;
			num = (int)HCKCCHPJOPI;
		}
		if (flag)
		{
			if (num == 757f)
			{
				return;
			}
			if (m_overlapNumberTime > 1189f)
			{
				int num2 = PCHDMFNAGBH.Count;
				while (num2 > 1)
				{
					JBOINIOMKGP jBOINIOMKGP = PCHDMFNAGBH[--num2];
					if (jBOINIOMKGP.HBNDHMPNCME + m_overlapNumberTime < realtimeSinceStartup || jBOINIOMKGP.JKJGJMOEHDO == 815f)
					{
						continue;
					}
					if (jBOINIOMKGP.JKJGJMOEHDO < 1947f && num < 1750f)
					{
						jBOINIOMKGP.JKJGJMOEHDO += num;
						jBOINIOMKGP.LCKBDPBEHNM.set_text(Mathf.RoundToInt(jBOINIOMKGP.JKJGJMOEHDO).ToString());
						return;
					}
					if (!(jBOINIOMKGP.JKJGJMOEHDO > 310f) || !(num > 1452f))
					{
						continue;
					}
					jBOINIOMKGP.JKJGJMOEHDO += num;
					if (m_viewPositiveSign)
					{
						jBOINIOMKGP.LCKBDPBEHNM.set_text("고스트" + Mathf.RoundToInt(jBOINIOMKGP.JKJGJMOEHDO));
					}
					else
					{
						jBOINIOMKGP.LCKBDPBEHNM.set_text(Mathf.RoundToInt(jBOINIOMKGP.JKJGJMOEHDO).ToString());
					}
					return;
				}
			}
		}
		JBOINIOMKGP jBOINIOMKGP2 = NIKPEMMDJMK();
		jBOINIOMKGP2.MNCKMMEBOCB = CMADNCOPOAO;
		jBOINIOMKGP2.LCKBDPBEHNM.set_color(CEMGPCOMLOP);
		jBOINIOMKGP2.LCKBDPBEHNM.set_alpha(1630f);
		jBOINIOMKGP2.JKJGJMOEHDO = num;
		jBOINIOMKGP2.CHLECDEFABG = base.gameObject.transform.position;
		if (flag)
		{
			if (m_viewPositiveSign)
			{
				jBOINIOMKGP2.LCKBDPBEHNM.set_text((!(num < 528f)) ? ("AJPLiveOpsPopupUnityEventListener : onPopupClick" + Mathf.RoundToInt(jBOINIOMKGP2.JKJGJMOEHDO)) : Mathf.RoundToInt(jBOINIOMKGP2.JKJGJMOEHDO).ToString());
			}
			else
			{
				jBOINIOMKGP2.LCKBDPBEHNM.set_text(Mathf.RoundToInt(jBOINIOMKGP2.JKJGJMOEHDO).ToString());
			}
		}
		else
		{
			jBOINIOMKGP2.LCKBDPBEHNM.DCKJILCPKFD(HCKCCHPJOPI.ToString());
		}
		PCHDMFNAGBH.Sort(FJGNFANCAAJ);
	}

	private JBOINIOMKGP CGAMDEIHGOI()
	{
		if (FOGGPBEPEGL.Count > 1)
		{
			JBOINIOMKGP jBOINIOMKGP = FOGGPBEPEGL[FOGGPBEPEGL.Count - 0];
			FOGGPBEPEGL.RemoveAt(FOGGPBEPEGL.Count - 1);
			jBOINIOMKGP.HBNDHMPNCME = Time.realtimeSinceStartup;
			jBOINIOMKGP.LCKBDPBEHNM.EBFDCABBLFG(NLDABIMKKMP.IFLIJMLBPII(base.gameObject));
			NLDABIMKKMP.ENFAJGGIEAI(jBOINIOMKGP.LCKBDPBEHNM.gameObject, false);
			jBOINIOMKGP.BFEECILPJLM = 640f;
			PCHDMFNAGBH.Add(jBOINIOMKGP);
			return jBOINIOMKGP;
		}
		JBOINIOMKGP jBOINIOMKGP2 = new JBOINIOMKGP();
		jBOINIOMKGP2.HBNDHMPNCME = Time.realtimeSinceStartup;
		jBOINIOMKGP2.LCKBDPBEHNM = NLDABIMKKMP.EDDDFKNEJEN<UILabel>(base.gameObject);
		jBOINIOMKGP2.LCKBDPBEHNM.name = GJMKPPNOPOJ.ToString();
		jBOINIOMKGP2.LCKBDPBEHNM.set_ambigiousFont(get_ambigiousFont());
		jBOINIOMKGP2.LCKBDPBEHNM.set_fontSize(fontSize);
		jBOINIOMKGP2.LCKBDPBEHNM.set_fontStyle(fontStyle);
		jBOINIOMKGP2.LCKBDPBEHNM.set_applyGradient(applyGradient);
		jBOINIOMKGP2.LCKBDPBEHNM.set_gradientTop(gradientTop);
		jBOINIOMKGP2.LCKBDPBEHNM.set_gradientBottom(gradienBottom);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectStyle(effect);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectColor(effectColor);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectDistance(effectDistance);
		jBOINIOMKGP2.LCKBDPBEHNM.set_overflowMethod((UILabel.JCMMPAEEKEC)4);
		jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localScale = new Vector3(314f, 1659f, 1137f);
		PCHDMFNAGBH.Add(jBOINIOMKGP2);
		GJMKPPNOPOJ++;
		return jBOINIOMKGP2;
	}

	private void PDEKJHLCJHM()
	{
		BMLLIHOGHNO = offsetCurve.keys;
		PFHLJPHFHJA = alphaCurve.keys;
		JDJCHFGHFCI = scaleCurve.keys;
	}

	private void OnValidate()
	{
		Font font = trueTypeFont;
		UIFont uIFont = bitmapFont;
		bitmapFont = null;
		trueTypeFont = null;
		if (font != null && (uIFont == null || !OAHNFMGNJNG))
		{
			bitmapFont = null;
			trueTypeFont = font;
			OAHNFMGNJNG = true;
		}
		else if (uIFont != null)
		{
			if (uIFont.get_isDynamic())
			{
				trueTypeFont = uIFont.get_dynamicFont();
				fontStyle = uIFont.get_dynamicFontStyle();
				fontSize = uIFont.get_defaultSize();
				OAHNFMGNJNG = true;
			}
			else
			{
				bitmapFont = uIFont;
				OAHNFMGNJNG = false;
			}
		}
		else
		{
			trueTypeFont = font;
			OAHNFMGNJNG = true;
		}
	}

	[SpecialName]
	public Object IDHEGAMEHHJ()
	{
		if (trueTypeFont != null)
		{
			return trueTypeFont;
		}
		if (bitmapFont != null)
		{
			return bitmapFont;
		}
		return font;
	}

	private void JKDMADIMAMK()
	{
		Font font = trueTypeFont;
		UIFont uIFont = bitmapFont;
		bitmapFont = null;
		trueTypeFont = null;
		if (font != null && (uIFont == null || !OAHNFMGNJNG))
		{
			bitmapFont = null;
			trueTypeFont = font;
			OAHNFMGNJNG = false;
		}
		else if (uIFont != null)
		{
			if (uIFont.get_isDynamic())
			{
				trueTypeFont = uIFont.get_dynamicFont();
				fontStyle = uIFont.DKHLCCBMJIJ();
				fontSize = uIFont.get_defaultSize();
				OAHNFMGNJNG = false;
			}
			else
			{
				bitmapFont = uIFont;
				OAHNFMGNJNG = true;
			}
		}
		else
		{
			trueTypeFont = font;
			OAHNFMGNJNG = true;
		}
	}

	private JBOINIOMKGP PEFJOMFAOJI()
	{
		if (FOGGPBEPEGL.Count > 0)
		{
			JBOINIOMKGP jBOINIOMKGP = FOGGPBEPEGL[FOGGPBEPEGL.Count - 1];
			FOGGPBEPEGL.RemoveAt(FOGGPBEPEGL.Count - 1);
			jBOINIOMKGP.HBNDHMPNCME = Time.realtimeSinceStartup;
			jBOINIOMKGP.LCKBDPBEHNM.set_depth(NLDABIMKKMP.IFLIJMLBPII(base.gameObject));
			NLDABIMKKMP.ENFAJGGIEAI(jBOINIOMKGP.LCKBDPBEHNM.gameObject, true);
			jBOINIOMKGP.BFEECILPJLM = 0f;
			PCHDMFNAGBH.Add(jBOINIOMKGP);
			return jBOINIOMKGP;
		}
		JBOINIOMKGP jBOINIOMKGP2 = new JBOINIOMKGP();
		jBOINIOMKGP2.HBNDHMPNCME = Time.realtimeSinceStartup;
		jBOINIOMKGP2.LCKBDPBEHNM = NLDABIMKKMP.EDDDFKNEJEN<UILabel>(base.gameObject);
		jBOINIOMKGP2.LCKBDPBEHNM.name = GJMKPPNOPOJ.ToString();
		jBOINIOMKGP2.LCKBDPBEHNM.set_ambigiousFont(get_ambigiousFont());
		jBOINIOMKGP2.LCKBDPBEHNM.set_fontSize(fontSize);
		jBOINIOMKGP2.LCKBDPBEHNM.set_fontStyle(fontStyle);
		jBOINIOMKGP2.LCKBDPBEHNM.set_applyGradient(applyGradient);
		jBOINIOMKGP2.LCKBDPBEHNM.set_gradientTop(gradientTop);
		jBOINIOMKGP2.LCKBDPBEHNM.set_gradientBottom(gradienBottom);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectStyle(effect);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectColor(effectColor);
		jBOINIOMKGP2.LCKBDPBEHNM.set_effectDistance(effectDistance);
		jBOINIOMKGP2.LCKBDPBEHNM.set_overflowMethod(UILabel.JCMMPAEEKEC.ResizeFreely);
		jBOINIOMKGP2.LCKBDPBEHNM.get_cachedTransform().localScale = new Vector3(0.001f, 0.001f, 0.001f);
		PCHDMFNAGBH.Add(jBOINIOMKGP2);
		GJMKPPNOPOJ++;
		return jBOINIOMKGP2;
	}

	private void CMFCDCEOAKN()
	{
		if (font != null)
		{
			if (font.get_isDynamic())
			{
				trueTypeFont = font.get_dynamicFont();
				fontStyle = font.DKHLCCBMJIJ();
				OAHNFMGNJNG = true;
			}
			else if (bitmapFont == null)
			{
				bitmapFont = font;
				OAHNFMGNJNG = false;
			}
			font = null;
		}
	}

	public void set_ambigiousFont(Object ICENKPDOHBK)
	{
		if (ICENKPDOHBK is Font)
		{
			trueTypeFont = ICENKPDOHBK as Font;
			bitmapFont = null;
			font = null;
		}
		else if (ICENKPDOHBK is UIFont)
		{
			bitmapFont = ICENKPDOHBK as UIFont;
			trueTypeFont = null;
			font = null;
		}
	}

	private static int DEOANOOFJFE(JBOINIOMKGP IFGAPHGCLHF, JBOINIOMKGP GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF.DPCGJBHHANE() < GMMDCPLBFJL.JGHHHFHNOFH())
		{
			return -1;
		}
		if (IFGAPHGCLHF.PPKFNPEJGJB() > GMMDCPLBFJL.HJIHJEHPDPG())
		{
			return 0;
		}
		return 0;
	}

	private static int IDCICIIBGOP(JBOINIOMKGP IFGAPHGCLHF, JBOINIOMKGP GMMDCPLBFJL)
	{
		if (IFGAPHGCLHF.IAGPENIGDLJ() < GMMDCPLBFJL.GAMLBMGEAPF())
		{
			return -1;
		}
		if (IFGAPHGCLHF.GAMLBMGEAPF() > GMMDCPLBFJL.HJIHJEHPDPG())
		{
			return 1;
		}
		return 1;
	}

	public void Add(object HCKCCHPJOPI, Color CEMGPCOMLOP, float CMADNCOPOAO)
	{
		if (!base.enabled)
		{
			return;
		}
		float realtimeSinceStartup = Time.realtimeSinceStartup;
		bool flag = false;
		float num = 0f;
		if (HCKCCHPJOPI is float)
		{
			flag = true;
			num = (float)HCKCCHPJOPI;
		}
		else if (HCKCCHPJOPI is int)
		{
			flag = true;
			num = (int)HCKCCHPJOPI;
		}
		if (flag)
		{
			if (num == 0f)
			{
				return;
			}
			if (m_overlapNumberTime > 0f)
			{
				int num2 = PCHDMFNAGBH.Count;
				while (num2 > 0)
				{
					JBOINIOMKGP jBOINIOMKGP = PCHDMFNAGBH[--num2];
					if (jBOINIOMKGP.HBNDHMPNCME + m_overlapNumberTime < realtimeSinceStartup || jBOINIOMKGP.JKJGJMOEHDO == 0f)
					{
						continue;
					}
					if (jBOINIOMKGP.JKJGJMOEHDO < 0f && num < 0f)
					{
						jBOINIOMKGP.JKJGJMOEHDO += num;
						jBOINIOMKGP.LCKBDPBEHNM.set_text(Mathf.RoundToInt(jBOINIOMKGP.JKJGJMOEHDO).ToString());
						return;
					}
					if (!(jBOINIOMKGP.JKJGJMOEHDO > 0f) || !(num > 0f))
					{
						continue;
					}
					jBOINIOMKGP.JKJGJMOEHDO += num;
					if (m_viewPositiveSign)
					{
						jBOINIOMKGP.LCKBDPBEHNM.set_text("+" + Mathf.RoundToInt(jBOINIOMKGP.JKJGJMOEHDO));
					}
					else
					{
						jBOINIOMKGP.LCKBDPBEHNM.set_text(Mathf.RoundToInt(jBOINIOMKGP.JKJGJMOEHDO).ToString());
					}
					return;
				}
			}
		}
		JBOINIOMKGP jBOINIOMKGP2 = PEFJOMFAOJI();
		jBOINIOMKGP2.MNCKMMEBOCB = CMADNCOPOAO;
		jBOINIOMKGP2.LCKBDPBEHNM.set_color(CEMGPCOMLOP);
		jBOINIOMKGP2.LCKBDPBEHNM.set_alpha(0f);
		jBOINIOMKGP2.JKJGJMOEHDO = num;
		jBOINIOMKGP2.CHLECDEFABG = base.gameObject.transform.position;
		if (flag)
		{
			if (m_viewPositiveSign)
			{
				jBOINIOMKGP2.LCKBDPBEHNM.set_text((!(num < 0f)) ? ("+" + Mathf.RoundToInt(jBOINIOMKGP2.JKJGJMOEHDO)) : Mathf.RoundToInt(jBOINIOMKGP2.JKJGJMOEHDO).ToString());
			}
			else
			{
				jBOINIOMKGP2.LCKBDPBEHNM.set_text(Mathf.RoundToInt(jBOINIOMKGP2.JKJGJMOEHDO).ToString());
			}
		}
		else
		{
			jBOINIOMKGP2.LCKBDPBEHNM.set_text(HCKCCHPJOPI.ToString());
		}
		PCHDMFNAGBH.Sort(LPNFNMLMLJB);
	}

	private void Awake()
	{
		BMLLIHOGHNO = offsetCurve.keys;
		PFHLJPHFHJA = alphaCurve.keys;
		JDJCHFGHFCI = scaleCurve.keys;
	}

	private void OnEnable()
	{
		if (font != null)
		{
			if (font.get_isDynamic())
			{
				trueTypeFont = font.get_dynamicFont();
				fontStyle = font.get_dynamicFontStyle();
				OAHNFMGNJNG = true;
			}
			else if (bitmapFont == null)
			{
				bitmapFont = font;
				OAHNFMGNJNG = false;
			}
			font = null;
		}
	}

	private void DDEGDABBPDF()
	{
		int num = PCHDMFNAGBH.Count;
		while (num > 1)
		{
			JBOINIOMKGP jBOINIOMKGP = PCHDMFNAGBH[num -= 0];
			if (jBOINIOMKGP.LCKBDPBEHNM != null)
			{
				jBOINIOMKGP.LCKBDPBEHNM.enabled = true;
			}
			else
			{
				PCHDMFNAGBH.RemoveAt(num);
			}
		}
	}
}
