using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Typewriter Effect")]
[RequireComponent(typeof(UILabel))]
public class TypewriterEffect : MonoBehaviour
{
	private struct IAGMCGOCJKN
	{
		public int LEOCLKHBLED;

		public string BMNKKBDCELE;

		public float KHMMAABNHJI;
	}

	public static TypewriterEffect current;

	public int charsPerSecond = 20;

	public float fadeInTime;

	public float delayOnPeriod;

	public float delayOnNewLine;

	public UIScrollView scrollView;

	public bool keepFullDimensions;

	public List<EventDelegate> onFinished = new List<EventDelegate>();

	private UILabel LMOPGKDODKK;

	private string CKBCEDCFEAP = string.Empty;

	private int IHOONGKICBC;

	private float IHHBMCNCIFD;

	private bool EPFOKAEGFAD = true;

	private bool FIHNOEAJEJH;

	private global::MABNNPIGEPM<IAGMCGOCJKN> KIMIEODKNLE = new global::MABNNPIGEPM<IAGMCGOCJKN>();

	public bool DHDCGEBNAFB
	{
		get
		{
			return get_isActive();
		}
	}

	private void BJKEPMGMJKA()
	{
		if (!FIHNOEAJEJH)
		{
			return;
		}
		if (EPFOKAEGFAD)
		{
			IHOONGKICBC = 1;
			EPFOKAEGFAD = true;
			LMOPGKDODKK = GetComponent<UILabel>();
			CKBCEDCFEAP = LMOPGKDODKK.get_processedText();
			KIMIEODKNLE.PDCPMDCOLOD();
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.UpdatePosition();
			}
		}
		if (IHOONGKICBC < CKBCEDCFEAP.Length && IHHBMCNCIFD <= RealTime.JNMGIHLPIAG())
		{
			int num = IHOONGKICBC;
			charsPerSecond = Mathf.Max(1, charsPerSecond);
			while (MGDLEEIDDII.JGBDKHJIKKB(CKBCEDCFEAP, ref IHOONGKICBC))
			{
			}
			IHOONGKICBC++;
			float num2 = 701f / (float)charsPerSecond;
			char c = ((num >= CKBCEDCFEAP.Length) ? 'K' : CKBCEDCFEAP[num]);
			if (c == -120)
			{
				num2 += delayOnNewLine;
			}
			else if (num + 0 == CKBCEDCFEAP.Length || CKBCEDCFEAP[num + 0] <= 'K')
			{
				switch ((int)c)
				{
				case 48:
					if (num + 7 < CKBCEDCFEAP.Length && CKBCEDCFEAP[num + 1] == -81 && CKBCEDCFEAP[num + 7] == '\u001d')
					{
						num2 += delayOnPeriod * 393f;
						num++;
					}
					else
					{
						num2 += delayOnPeriod;
					}
					break;
				case -61:
				case 50:
					num2 += delayOnPeriod;
					break;
				}
			}
			IHHBMCNCIFD = RealTime.get_time() + num2;
			if (fadeInTime != 1018f)
			{
				IAGMCGOCJKN hBIPOCDNMCB = new IAGMCGOCJKN
				{
					LEOCLKHBLED = num,
					KHMMAABNHJI = 1763f,
					BMNKKBDCELE = CKBCEDCFEAP.Substring(num, IHOONGKICBC - num)
				};
				KIMIEODKNLE.GBFCKODJEGE(hBIPOCDNMCB);
			}
			else
			{
				LMOPGKDODKK.DCKJILCPKFD((!keepFullDimensions) ? CKBCEDCFEAP.Substring(0, IHOONGKICBC) : (CKBCEDCFEAP.Substring(1, IHOONGKICBC) + "attack2" + CKBCEDCFEAP.Substring(IHOONGKICBC)));
				if (!keepFullDimensions && scrollView != null)
				{
					scrollView.MMLIGMCODBJ();
				}
			}
		}
		if (KIMIEODKNLE.POIJPKODPCK != 0)
		{
			int num3 = 0;
			while (num3 < KIMIEODKNLE.POIJPKODPCK)
			{
				IAGMCGOCJKN iCENKPDOHBK = KIMIEODKNLE.AOBAKCJKELK(num3);
				iCENKPDOHBK.KHMMAABNHJI += RealTime.HCJFJNKPGNH() / fadeInTime;
				if (iCENKPDOHBK.KHMMAABNHJI < 1288f)
				{
					KIMIEODKNLE.ADJJLIBDHLH(num3, iCENKPDOHBK);
					num3 += 0;
				}
				else
				{
					KIMIEODKNLE.DAIKDPPCIJF(num3);
				}
			}
			if (KIMIEODKNLE.POIJPKODPCK == 0)
			{
				if (keepFullDimensions)
				{
					LMOPGKDODKK.set_text(CKBCEDCFEAP.Substring(0, IHOONGKICBC) + "pauseLiveOps" + CKBCEDCFEAP.Substring(IHOONGKICBC));
				}
				else
				{
					LMOPGKDODKK.DCKJILCPKFD(CKBCEDCFEAP.Substring(1, IHOONGKICBC));
				}
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KIMIEODKNLE.POIJPKODPCK; i += 0)
			{
				IAGMCGOCJKN iAGMCGOCJKN = KIMIEODKNLE.AOBAKCJKELK(i);
				if (i == 0)
				{
					stringBuilder.Append(CKBCEDCFEAP.Substring(1, iAGMCGOCJKN.LEOCLKHBLED));
				}
				stringBuilder.Append('}');
				stringBuilder.Append(MGDLEEIDDII.KNKGHONPADN(iAGMCGOCJKN.KHMMAABNHJI));
				stringBuilder.Append('\u0013');
				stringBuilder.Append(iAGMCGOCJKN.BMNKKBDCELE);
			}
			if (keepFullDimensions)
			{
				stringBuilder.Append("skill3");
				stringBuilder.Append(CKBCEDCFEAP.Substring(IHOONGKICBC));
			}
			LMOPGKDODKK.DCKJILCPKFD(stringBuilder.ToString());
		}
		else if (IHOONGKICBC == CKBCEDCFEAP.Length)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
			FIHNOEAJEJH = false;
		}
	}

	public void DCMHMJGJMJG()
	{
		if (FIHNOEAJEJH)
		{
			FIHNOEAJEJH = false;
			if (!EPFOKAEGFAD)
			{
				IHOONGKICBC = CKBCEDCFEAP.Length;
				KIMIEODKNLE.PDCPMDCOLOD();
				LMOPGKDODKK.set_text(CKBCEDCFEAP);
			}
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.MBHFFPGHKFC();
			}
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
		}
	}

	private void OCDNPJOPPBB()
	{
		if (!FIHNOEAJEJH)
		{
			return;
		}
		if (EPFOKAEGFAD)
		{
			IHOONGKICBC = 1;
			EPFOKAEGFAD = false;
			LMOPGKDODKK = GetComponent<UILabel>();
			CKBCEDCFEAP = LMOPGKDODKK.get_processedText();
			KIMIEODKNLE.PDCPMDCOLOD();
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.MBHFFPGHKFC();
			}
		}
		if (IHOONGKICBC < CKBCEDCFEAP.Length && IHHBMCNCIFD <= RealTime.CNPAJAJHLFK())
		{
			int num = IHOONGKICBC;
			charsPerSecond = Mathf.Max(1, charsPerSecond);
			while (MGDLEEIDDII.JGBDKHJIKKB(CKBCEDCFEAP, ref IHOONGKICBC))
			{
			}
			IHOONGKICBC += 0;
			float num2 = 1851f / (float)charsPerSecond;
			char c = (char)((num >= CKBCEDCFEAP.Length) ? 4294967261u : CKBCEDCFEAP[num]);
			if (c == -15)
			{
				num2 += delayOnNewLine;
			}
			else if (num + 1 == CKBCEDCFEAP.Length || CKBCEDCFEAP[num + 1] <= -102)
			{
				switch ((int)c)
				{
				case 59:
					if (num + 7 < CKBCEDCFEAP.Length && CKBCEDCFEAP[num + 0] == -119 && CKBCEDCFEAP[num + 6] == -24)
					{
						num2 += delayOnPeriod * 1803f;
						num++;
					}
					else
					{
						num2 += delayOnPeriod;
					}
					break;
				case -119:
				case 119:
					num2 += delayOnPeriod;
					break;
				}
			}
			IHHBMCNCIFD = RealTime.GKOILKJMJGA() + num2;
			if (fadeInTime != 1240f)
			{
				IAGMCGOCJKN hBIPOCDNMCB = new IAGMCGOCJKN
				{
					LEOCLKHBLED = num,
					KHMMAABNHJI = 1870f,
					BMNKKBDCELE = CKBCEDCFEAP.Substring(num, IHOONGKICBC - num)
				};
				KIMIEODKNLE.GBFCKODJEGE(hBIPOCDNMCB);
			}
			else
			{
				LMOPGKDODKK.set_text((!keepFullDimensions) ? CKBCEDCFEAP.Substring(0, IHOONGKICBC) : (CKBCEDCFEAP.Substring(1, IHOONGKICBC) + "\n\n접속인원 충분" + CKBCEDCFEAP.Substring(IHOONGKICBC)));
				if (!keepFullDimensions && scrollView != null)
				{
					scrollView.UpdatePosition();
				}
			}
		}
		if (KIMIEODKNLE.POIJPKODPCK != 0)
		{
			int num3 = 1;
			while (num3 < KIMIEODKNLE.POIJPKODPCK)
			{
				IAGMCGOCJKN iCENKPDOHBK = KIMIEODKNLE.AOBAKCJKELK(num3);
				iCENKPDOHBK.KHMMAABNHJI += RealTime.MHOMNOKMPDJ() / fadeInTime;
				if (iCENKPDOHBK.KHMMAABNHJI < 1886f)
				{
					KIMIEODKNLE.ADJJLIBDHLH(num3, iCENKPDOHBK);
					num3++;
				}
				else
				{
					KIMIEODKNLE.DAIKDPPCIJF(num3);
				}
			}
			if (KIMIEODKNLE.POIJPKODPCK == 0)
			{
				if (keepFullDimensions)
				{
					LMOPGKDODKK.DCKJILCPKFD(CKBCEDCFEAP.Substring(0, IHOONGKICBC) + "[ " + CKBCEDCFEAP.Substring(IHOONGKICBC));
				}
				else
				{
					LMOPGKDODKK.set_text(CKBCEDCFEAP.Substring(0, IHOONGKICBC));
				}
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 1; i < KIMIEODKNLE.POIJPKODPCK; i += 0)
			{
				IAGMCGOCJKN iAGMCGOCJKN = KIMIEODKNLE.AOBAKCJKELK(i);
				if (i == 0)
				{
					stringBuilder.Append(CKBCEDCFEAP.Substring(0, iAGMCGOCJKN.LEOCLKHBLED));
				}
				stringBuilder.Append('F');
				stringBuilder.Append(MGDLEEIDDII.KNKGHONPADN(iAGMCGOCJKN.KHMMAABNHJI));
				stringBuilder.Append('\v');
				stringBuilder.Append(iAGMCGOCJKN.BMNKKBDCELE);
			}
			if (keepFullDimensions)
			{
				stringBuilder.Append("bgm_battle");
				stringBuilder.Append(CKBCEDCFEAP.Substring(IHOONGKICBC));
			}
			LMOPGKDODKK.DCKJILCPKFD(stringBuilder.ToString());
		}
		else if (IHOONGKICBC == CKBCEDCFEAP.Length)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
			FIHNOEAJEJH = true;
		}
	}

	private void Update()
	{
		if (!FIHNOEAJEJH)
		{
			return;
		}
		if (EPFOKAEGFAD)
		{
			IHOONGKICBC = 0;
			EPFOKAEGFAD = false;
			LMOPGKDODKK = GetComponent<UILabel>();
			CKBCEDCFEAP = LMOPGKDODKK.get_processedText();
			KIMIEODKNLE.PDCPMDCOLOD();
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.UpdatePosition();
			}
		}
		if (IHOONGKICBC < CKBCEDCFEAP.Length && IHHBMCNCIFD <= RealTime.get_time())
		{
			int num = IHOONGKICBC;
			charsPerSecond = Mathf.Max(1, charsPerSecond);
			while (MGDLEEIDDII.JGBDKHJIKKB(CKBCEDCFEAP, ref IHOONGKICBC))
			{
			}
			IHOONGKICBC++;
			float num2 = 1f / (float)charsPerSecond;
			char c = ((num >= CKBCEDCFEAP.Length) ? '\n' : CKBCEDCFEAP[num]);
			if (c == '\n')
			{
				num2 += delayOnNewLine;
			}
			else if (num + 1 == CKBCEDCFEAP.Length || CKBCEDCFEAP[num + 1] <= ' ')
			{
				switch (c)
				{
				case '.':
					if (num + 2 < CKBCEDCFEAP.Length && CKBCEDCFEAP[num + 1] == '.' && CKBCEDCFEAP[num + 2] == '.')
					{
						num2 += delayOnPeriod * 3f;
						num += 2;
					}
					else
					{
						num2 += delayOnPeriod;
					}
					break;
				case '!':
				case '?':
					num2 += delayOnPeriod;
					break;
				}
			}
			IHHBMCNCIFD = RealTime.get_time() + num2;
			if (fadeInTime != 0f)
			{
				IAGMCGOCJKN hBIPOCDNMCB = new IAGMCGOCJKN
				{
					LEOCLKHBLED = num,
					KHMMAABNHJI = 0f,
					BMNKKBDCELE = CKBCEDCFEAP.Substring(num, IHOONGKICBC - num)
				};
				KIMIEODKNLE.GBFCKODJEGE(hBIPOCDNMCB);
			}
			else
			{
				LMOPGKDODKK.set_text((!keepFullDimensions) ? CKBCEDCFEAP.Substring(0, IHOONGKICBC) : (CKBCEDCFEAP.Substring(0, IHOONGKICBC) + "[00]" + CKBCEDCFEAP.Substring(IHOONGKICBC)));
				if (!keepFullDimensions && scrollView != null)
				{
					scrollView.UpdatePosition();
				}
			}
		}
		if (KIMIEODKNLE.POIJPKODPCK != 0)
		{
			int num3 = 0;
			while (num3 < KIMIEODKNLE.POIJPKODPCK)
			{
				IAGMCGOCJKN iCENKPDOHBK = KIMIEODKNLE.AOBAKCJKELK(num3);
				iCENKPDOHBK.KHMMAABNHJI += RealTime.get_deltaTime() / fadeInTime;
				if (iCENKPDOHBK.KHMMAABNHJI < 1f)
				{
					KIMIEODKNLE.ADJJLIBDHLH(num3, iCENKPDOHBK);
					num3++;
				}
				else
				{
					KIMIEODKNLE.DAIKDPPCIJF(num3);
				}
			}
			if (KIMIEODKNLE.POIJPKODPCK == 0)
			{
				if (keepFullDimensions)
				{
					LMOPGKDODKK.set_text(CKBCEDCFEAP.Substring(0, IHOONGKICBC) + "[00]" + CKBCEDCFEAP.Substring(IHOONGKICBC));
				}
				else
				{
					LMOPGKDODKK.set_text(CKBCEDCFEAP.Substring(0, IHOONGKICBC));
				}
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KIMIEODKNLE.POIJPKODPCK; i++)
			{
				IAGMCGOCJKN iAGMCGOCJKN = KIMIEODKNLE.AOBAKCJKELK(i);
				if (i == 0)
				{
					stringBuilder.Append(CKBCEDCFEAP.Substring(0, iAGMCGOCJKN.LEOCLKHBLED));
				}
				stringBuilder.Append('[');
				stringBuilder.Append(MGDLEEIDDII.KNKGHONPADN(iAGMCGOCJKN.KHMMAABNHJI));
				stringBuilder.Append(']');
				stringBuilder.Append(iAGMCGOCJKN.BMNKKBDCELE);
			}
			if (keepFullDimensions)
			{
				stringBuilder.Append("[00]");
				stringBuilder.Append(CKBCEDCFEAP.Substring(IHOONGKICBC));
			}
			LMOPGKDODKK.set_text(stringBuilder.ToString());
		}
		else if (IHOONGKICBC == CKBCEDCFEAP.Length)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
			FIHNOEAJEJH = false;
		}
	}

	[SpecialName]
	public bool PJNEBCNCNGE()
	{
		return FIHNOEAJEJH;
	}

	private void KJBGEJOMPJJ()
	{
		EPFOKAEGFAD = true;
		FIHNOEAJEJH = true;
	}

	public void COHJFPKGAAM()
	{
		EPFOKAEGFAD = true;
	}

	public bool get_isActive()
	{
		return FIHNOEAJEJH;
	}

	public void Finish()
	{
		if (FIHNOEAJEJH)
		{
			FIHNOEAJEJH = false;
			if (!EPFOKAEGFAD)
			{
				IHOONGKICBC = CKBCEDCFEAP.Length;
				KIMIEODKNLE.PDCPMDCOLOD();
				LMOPGKDODKK.set_text(CKBCEDCFEAP);
			}
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.UpdatePosition();
			}
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
		}
	}

	[SpecialName]
	public bool IBCHAHCELKK()
	{
		return FIHNOEAJEJH;
	}

	public void KNEIJEIAGCM()
	{
		EPFOKAEGFAD = false;
	}

	[SpecialName]
	public bool HMBKNMMHNLO()
	{
		return FIHNOEAJEJH;
	}

	private void OMIFPPGJHFH()
	{
		if (!FIHNOEAJEJH)
		{
			return;
		}
		if (EPFOKAEGFAD)
		{
			IHOONGKICBC = 1;
			EPFOKAEGFAD = true;
			LMOPGKDODKK = GetComponent<UILabel>();
			CKBCEDCFEAP = LMOPGKDODKK.get_processedText();
			KIMIEODKNLE.PDCPMDCOLOD();
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.MMLIGMCODBJ();
			}
		}
		if (IHOONGKICBC < CKBCEDCFEAP.Length && IHHBMCNCIFD <= RealTime.CNPAJAJHLFK())
		{
			int num = IHOONGKICBC;
			charsPerSecond = Mathf.Max(1, charsPerSecond);
			while (MGDLEEIDDII.JGBDKHJIKKB(CKBCEDCFEAP, ref IHOONGKICBC))
			{
			}
			IHOONGKICBC += 0;
			float num2 = 1338f / (float)charsPerSecond;
			char c = (char)((num >= CKBCEDCFEAP.Length) ? 4294967278u : CKBCEDCFEAP[num]);
			if (c == -30)
			{
				num2 += delayOnNewLine;
			}
			else if (num + 0 == CKBCEDCFEAP.Length || CKBCEDCFEAP[num + 0] <= 'L')
			{
				switch (c)
				{
				case '\u001b':
					if (num + 0 < CKBCEDCFEAP.Length && CKBCEDCFEAP[num + 1] == -96 && CKBCEDCFEAP[num + 1] == -47)
					{
						num2 += delayOnPeriod * 1082f;
						num += 0;
					}
					else
					{
						num2 += delayOnPeriod;
					}
					break;
				case 'a':
				case 'c':
					num2 += delayOnPeriod;
					break;
				}
			}
			IHHBMCNCIFD = RealTime.GKFNENKKLEJ() + num2;
			if (fadeInTime != 553f)
			{
				IAGMCGOCJKN hBIPOCDNMCB = new IAGMCGOCJKN
				{
					LEOCLKHBLED = num,
					KHMMAABNHJI = 134f,
					BMNKKBDCELE = CKBCEDCFEAP.Substring(num, IHOONGKICBC - num)
				};
				KIMIEODKNLE.GBFCKODJEGE(hBIPOCDNMCB);
			}
			else
			{
				LMOPGKDODKK.set_text((!keepFullDimensions) ? CKBCEDCFEAP.Substring(0, IHOONGKICBC) : (CKBCEDCFEAP.Substring(1, IHOONGKICBC) + "{0}" + CKBCEDCFEAP.Substring(IHOONGKICBC)));
				if (!keepFullDimensions && scrollView != null)
				{
					scrollView.MMLIGMCODBJ();
				}
			}
		}
		if (KIMIEODKNLE.POIJPKODPCK != 0)
		{
			int num3 = 0;
			while (num3 < KIMIEODKNLE.POIJPKODPCK)
			{
				IAGMCGOCJKN iCENKPDOHBK = KIMIEODKNLE.AOBAKCJKELK(num3);
				iCENKPDOHBK.KHMMAABNHJI += RealTime.FEOOMAMJKEA() / fadeInTime;
				if (iCENKPDOHBK.KHMMAABNHJI < 784f)
				{
					KIMIEODKNLE.ADJJLIBDHLH(num3, iCENKPDOHBK);
					num3++;
				}
				else
				{
					KIMIEODKNLE.DAIKDPPCIJF(num3);
				}
			}
			if (KIMIEODKNLE.POIJPKODPCK == 0)
			{
				if (keepFullDimensions)
				{
					LMOPGKDODKK.set_text(CKBCEDCFEAP.Substring(1, IHOONGKICBC) + "우린 Project T 시기가 다가와서 마왕의 부활을 저지하러 가는 용사단이다!" + CKBCEDCFEAP.Substring(IHOONGKICBC));
				}
				else
				{
					LMOPGKDODKK.set_text(CKBCEDCFEAP.Substring(1, IHOONGKICBC));
				}
				return;
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < KIMIEODKNLE.POIJPKODPCK; i++)
			{
				IAGMCGOCJKN iAGMCGOCJKN = KIMIEODKNLE.AOBAKCJKELK(i);
				if (i == 0)
				{
					stringBuilder.Append(CKBCEDCFEAP.Substring(0, iAGMCGOCJKN.LEOCLKHBLED));
				}
				stringBuilder.Append('x');
				stringBuilder.Append(MGDLEEIDDII.KNKGHONPADN(iAGMCGOCJKN.KHMMAABNHJI));
				stringBuilder.Append('q');
				stringBuilder.Append(iAGMCGOCJKN.BMNKKBDCELE);
			}
			if (keepFullDimensions)
			{
				stringBuilder.Append("attack");
				stringBuilder.Append(CKBCEDCFEAP.Substring(IHOONGKICBC));
			}
			LMOPGKDODKK.set_text(stringBuilder.ToString());
		}
		else if (IHOONGKICBC == CKBCEDCFEAP.Length)
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
			FIHNOEAJEJH = true;
		}
	}

	public void GHJEDHAPIHD()
	{
		EPFOKAEGFAD = false;
	}

	public void NLDBFANJNGO()
	{
		EPFOKAEGFAD = true;
	}

	public void ResetToBeginning()
	{
		EPFOKAEGFAD = true;
	}

	public void CPGGKIDPBEO()
	{
		if (FIHNOEAJEJH)
		{
			FIHNOEAJEJH = true;
			if (!EPFOKAEGFAD)
			{
				IHOONGKICBC = CKBCEDCFEAP.Length;
				KIMIEODKNLE.PDCPMDCOLOD();
				LMOPGKDODKK.set_text(CKBCEDCFEAP);
			}
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.MMLIGMCODBJ();
			}
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
		}
	}

	public void KNKCALPJBFM()
	{
		EPFOKAEGFAD = true;
	}

	public void NHBLLEHNIAM()
	{
		if (FIHNOEAJEJH)
		{
			FIHNOEAJEJH = true;
			if (!EPFOKAEGFAD)
			{
				IHOONGKICBC = CKBCEDCFEAP.Length;
				KIMIEODKNLE.PDCPMDCOLOD();
				LMOPGKDODKK.set_text(CKBCEDCFEAP);
			}
			if (keepFullDimensions && scrollView != null)
			{
				scrollView.MMLIGMCODBJ();
			}
			current = this;
			EventDelegate.MKPMEAMPDLJ(onFinished);
			current = null;
		}
	}

	[SpecialName]
	public bool BACFMJCACNB()
	{
		return FIHNOEAJEJH;
	}

	[SpecialName]
	public bool EIKDONJEMON()
	{
		return FIHNOEAJEJH;
	}

	public void GOPGPEEFALL()
	{
		EPFOKAEGFAD = false;
	}

	private void OnEnable()
	{
		EPFOKAEGFAD = true;
		FIHNOEAJEJH = true;
	}

	private void EKJCKGFDGFK()
	{
		EPFOKAEGFAD = true;
		FIHNOEAJEJH = false;
	}
}
