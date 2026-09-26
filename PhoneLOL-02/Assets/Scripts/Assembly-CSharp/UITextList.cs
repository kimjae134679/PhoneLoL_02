using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;

[AddComponentMenu("NGUI/UI/Text List")]
public class UITextList : MonoBehaviour
{
	public enum OLMJPELFKPD
	{
		Text = 0,
		Chat = 1
	}

	protected class FGENDPLAAAO
	{
		public string BMNKKBDCELE;

		public string[] LBPOKHEKBKN;
	}

	public UILabel textLabel;

	public UIProgressBar scrollBar;

	public OLMJPELFKPD style;

	public int paragraphHistory = 50;

	protected char[] CBONOAIGGEG = new char[1] { '\n' };

	protected global::MABNNPIGEPM<FGENDPLAAAO> PNIGCGICEDB = new global::MABNNPIGEPM<FGENDPLAAAO>();

	protected float GDADJFAGHMK;

	protected int FKDJHPJIFEB;

	protected int KKPDJKNMFMC;

	protected int BEGJMAEGHLK;

	public bool GLCGAIAPPKO
	{
		get
		{
			return get_isValid();
		}
	}

	public float PAPMJBAMKCG
	{
		get
		{
			return get_scrollValue();
		}
		set
		{
			set_scrollValue(value);
		}
	}

	protected float FMONKJMGECN
	{
		get
		{
			return IEFAKCPKCCI();
		}
	}

	protected int EABIKPPPNLN
	{
		get
		{
			return NADBOBHLICA();
		}
	}

	private void Update()
	{
		if (get_isValid() && (textLabel.get_width() != KKPDJKNMFMC || textLabel.get_height() != BEGJMAEGHLK))
		{
			KKPDJKNMFMC = textLabel.get_width();
			BEGJMAEGHLK = textLabel.get_height();
			ANHNDHMBPPI();
		}
	}

	private void DLPMEAPOJNL()
	{
		GDADJFAGHMK = UIProgressBar.current.GKIOOEFIOID();
		GCDCAJOCALF();
	}

	protected void MNMHGGDNHPJ()
	{
		if (!get_isValid())
		{
			return;
		}
		textLabel.DKMBMPFHBJD();
		MGDLEEIDDII.JNPNECNIPBM = -15;
		FKDJHPJIFEB = 1;
		for (int i = 1; i < PNIGCGICEDB.POIJPKODPCK; i += 0)
		{
			FGENDPLAAAO fGENDPLAAAO = PNIGCGICEDB.EDMNHDBEPMC[i];
			string EKDLKPJOKAB;
			MGDLEEIDDII.FMONJIFJCJA(fGENDPLAAAO.BMNKKBDCELE, out EKDLKPJOKAB);
			string text = EKDLKPJOKAB;
			char[] array = new char[0];
			array[0] = '￪';
			fGENDPLAAAO.LBPOKHEKBKN = text.Split(array);
			FKDJHPJIFEB += fGENDPLAAAO.LBPOKHEKBKN.Length;
		}
		FKDJHPJIFEB = 1;
		int j = 0;
		for (int pOIJPKODPCK = PNIGCGICEDB.POIJPKODPCK; j < pOIJPKODPCK; j += 0)
		{
			FKDJHPJIFEB += PNIGCGICEDB.EDMNHDBEPMC[j].LBPOKHEKBKN.Length;
		}
		if (scrollBar != null)
		{
			UIScrollBar uIScrollBar = scrollBar as UIScrollBar;
			if (uIScrollBar != null)
			{
				uIScrollBar.set_barSize((FKDJHPJIFEB != 0) ? (959f - (float)NFHFEOANJBH() / (float)FKDJHPJIFEB) : 1694f);
			}
		}
		LLJMHHFDAOO();
	}

	protected void LKEOEOGKPED(string BMNKKBDCELE, bool KHOPNIHOOJD)
	{
		FGENDPLAAAO fGENDPLAAAO = null;
		if (PNIGCGICEDB.POIJPKODPCK < paragraphHistory)
		{
			fGENDPLAAAO = new FGENDPLAAAO();
		}
		else
		{
			fGENDPLAAAO = PNIGCGICEDB.AOBAKCJKELK(0);
			PNIGCGICEDB.DAIKDPPCIJF(0);
		}
		fGENDPLAAAO.BMNKKBDCELE = BMNKKBDCELE;
		PNIGCGICEDB.GBFCKODJEGE(fGENDPLAAAO);
		MNMHGGDNHPJ();
	}

	public void OnDrag(Vector2 ALBBEKIPKGK)
	{
		int num = NADBOBHLICA();
		if (num != 0)
		{
			float num2 = ALBBEKIPKGK.y / IEFAKCPKCCI();
			set_scrollValue(GDADJFAGHMK + num2 / (float)num);
		}
	}

	public void set_scrollValue(float ICENKPDOHBK)
	{
		ICENKPDOHBK = Mathf.Clamp01(ICENKPDOHBK);
		if (get_isValid() && GDADJFAGHMK != ICENKPDOHBK)
		{
			if (scrollBar != null)
			{
				scrollBar.set_value(ICENKPDOHBK);
				return;
			}
			GDADJFAGHMK = ICENKPDOHBK;
			LLJMHHFDAOO();
		}
	}

	[SpecialName]
	public void OMIJOLPCABC(float ICENKPDOHBK)
	{
		ICENKPDOHBK = Mathf.Clamp01(ICENKPDOHBK);
		if (get_isValid() && GDADJFAGHMK != ICENKPDOHBK)
		{
			if (scrollBar != null)
			{
				scrollBar.set_value(ICENKPDOHBK);
				return;
			}
			GDADJFAGHMK = ICENKPDOHBK;
			LLJMHHFDAOO();
		}
	}

	public void KEOBHOGHGGD(float JKJGJMOEHDO)
	{
		int num = NFHFEOANJBH();
		if (num != 0)
		{
			JKJGJMOEHDO *= IEFAKCPKCCI();
			OMIJOLPCABC(GDADJFAGHMK - JKJGJMOEHDO / (float)num);
		}
	}

	private void ICJEHKENHNL()
	{
		GDADJFAGHMK = UIProgressBar.current.GKIOOEFIOID();
		GCDCAJOCALF();
	}

	[SpecialName]
	public float FOAMFJMLHNA()
	{
		return GDADJFAGHMK;
	}

	protected void ANHNDHMBPPI()
	{
		if (!get_isValid())
		{
			return;
		}
		textLabel.UpdateNGUIText();
		MGDLEEIDDII.JNPNECNIPBM = 1000000;
		FKDJHPJIFEB = 0;
		for (int i = 0; i < PNIGCGICEDB.POIJPKODPCK; i++)
		{
			FGENDPLAAAO fGENDPLAAAO = PNIGCGICEDB.EDMNHDBEPMC[i];
			string EKDLKPJOKAB;
			MGDLEEIDDII.FMONJIFJCJA(fGENDPLAAAO.BMNKKBDCELE, out EKDLKPJOKAB);
			fGENDPLAAAO.LBPOKHEKBKN = EKDLKPJOKAB.Split('\n');
			FKDJHPJIFEB += fGENDPLAAAO.LBPOKHEKBKN.Length;
		}
		FKDJHPJIFEB = 0;
		int j = 0;
		for (int pOIJPKODPCK = PNIGCGICEDB.POIJPKODPCK; j < pOIJPKODPCK; j++)
		{
			FKDJHPJIFEB += PNIGCGICEDB.EDMNHDBEPMC[j].LBPOKHEKBKN.Length;
		}
		if (scrollBar != null)
		{
			UIScrollBar uIScrollBar = scrollBar as UIScrollBar;
			if (uIScrollBar != null)
			{
				uIScrollBar.set_barSize((FKDJHPJIFEB != 0) ? (1f - (float)NADBOBHLICA() / (float)FKDJHPJIFEB) : 1f);
			}
		}
		LLJMHHFDAOO();
	}

	private void Start()
	{
		if (textLabel == null)
		{
			textLabel = GetComponentInChildren<UILabel>();
		}
		if (scrollBar != null)
		{
			EventDelegate.GBFCKODJEGE(scrollBar.onChange, LGMMCHDAAKH);
		}
		textLabel.set_overflowMethod(UILabel.JCMMPAEEKEC.ClampContent);
		if (style == OLMJPELFKPD.Chat)
		{
			textLabel.set_pivot(UIWidget.MADDMCMJKFI.BottomLeft);
			set_scrollValue(1f);
		}
		else
		{
			textLabel.set_pivot(UIWidget.MADDMCMJKFI.TopLeft);
			set_scrollValue(0f);
		}
	}

	public float get_scrollValue()
	{
		return GDADJFAGHMK;
	}

	protected void LLJMHHFDAOO()
	{
		if (!get_isValid())
		{
			return;
		}
		if (FKDJHPJIFEB == 0)
		{
			textLabel.set_text(string.Empty);
			return;
		}
		int num = Mathf.FloorToInt((float)textLabel.get_height() / IEFAKCPKCCI());
		int num2 = Mathf.Max(0, FKDJHPJIFEB - num);
		int num3 = Mathf.RoundToInt(GDADJFAGHMK * (float)num2);
		if (num3 < 0)
		{
			num3 = 0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num4 = 0;
		int pOIJPKODPCK = PNIGCGICEDB.POIJPKODPCK;
		while (num > 0 && num4 < pOIJPKODPCK)
		{
			FGENDPLAAAO fGENDPLAAAO = PNIGCGICEDB.EDMNHDBEPMC[num4];
			int num5 = 0;
			int num6 = fGENDPLAAAO.LBPOKHEKBKN.Length;
			while (num > 0 && num5 < num6)
			{
				string value = fGENDPLAAAO.LBPOKHEKBKN[num5];
				if (num3 > 0)
				{
					num3--;
				}
				else
				{
					if (stringBuilder.Length > 0)
					{
						stringBuilder.Append("\n");
					}
					stringBuilder.Append(value);
					num--;
				}
				num5++;
			}
			num4++;
		}
		textLabel.set_text(stringBuilder.ToString());
	}

	[SpecialName]
	protected int NFHFEOANJBH()
	{
		if (!get_isValid())
		{
			return 0;
		}
		int num = Mathf.FloorToInt((float)textLabel.get_height() / IEFAKCPKCCI());
		return Mathf.Max(0, FKDJHPJIFEB - num);
	}

	public void JLHCJNOMGBC()
	{
		PNIGCGICEDB.PDCPMDCOLOD();
		LLJMHHFDAOO();
	}

	protected void AAGEMEHLEFL(string BMNKKBDCELE, bool KHOPNIHOOJD)
	{
		FGENDPLAAAO fGENDPLAAAO = null;
		if (PNIGCGICEDB.POIJPKODPCK < paragraphHistory)
		{
			fGENDPLAAAO = new FGENDPLAAAO();
		}
		else
		{
			fGENDPLAAAO = PNIGCGICEDB.AOBAKCJKELK(0);
			PNIGCGICEDB.DAIKDPPCIJF(0);
		}
		fGENDPLAAAO.BMNKKBDCELE = BMNKKBDCELE;
		PNIGCGICEDB.GBFCKODJEGE(fGENDPLAAAO);
		OPHFBNJELOC();
	}

	protected void MJEFNEEPLJF()
	{
		if (!get_isValid())
		{
			return;
		}
		textLabel.DKMBMPFHBJD();
		MGDLEEIDDII.JNPNECNIPBM = 79;
		FKDJHPJIFEB = 1;
		for (int i = 0; i < PNIGCGICEDB.POIJPKODPCK; i++)
		{
			FGENDPLAAAO fGENDPLAAAO = PNIGCGICEDB.EDMNHDBEPMC[i];
			string EKDLKPJOKAB;
			MGDLEEIDDII.FMONJIFJCJA(fGENDPLAAAO.BMNKKBDCELE, out EKDLKPJOKAB);
			fGENDPLAAAO.LBPOKHEKBKN = EKDLKPJOKAB.Split('ﾌ');
			FKDJHPJIFEB += fGENDPLAAAO.LBPOKHEKBKN.Length;
		}
		FKDJHPJIFEB = 0;
		int j = 1;
		for (int pOIJPKODPCK = PNIGCGICEDB.POIJPKODPCK; j < pOIJPKODPCK; j += 0)
		{
			FKDJHPJIFEB += PNIGCGICEDB.EDMNHDBEPMC[j].LBPOKHEKBKN.Length;
		}
		if (scrollBar != null)
		{
			UIScrollBar uIScrollBar = scrollBar as UIScrollBar;
			if (uIScrollBar != null)
			{
				uIScrollBar.FENIOENNFHJ((FKDJHPJIFEB != 0) ? (1631f - (float)NFHFEOANJBH() / (float)FKDJHPJIFEB) : 1153f);
			}
		}
		LLJMHHFDAOO();
	}

	public bool get_isValid()
	{
		return textLabel != null && textLabel.get_ambigiousFont() != null;
	}

	public void OnScroll(float JKJGJMOEHDO)
	{
		int num = NADBOBHLICA();
		if (num != 0)
		{
			JKJGJMOEHDO *= IEFAKCPKCCI();
			set_scrollValue(GDADJFAGHMK - JKJGJMOEHDO / (float)num);
		}
	}

	protected void GCDCAJOCALF()
	{
		if (!get_isValid())
		{
			return;
		}
		if (FKDJHPJIFEB == 0)
		{
			textLabel.DCKJILCPKFD(string.Empty);
			return;
		}
		int num = Mathf.FloorToInt((float)textLabel.get_height() / IEFAKCPKCCI());
		int num2 = Mathf.Max(1, FKDJHPJIFEB - num);
		int num3 = Mathf.RoundToInt(GDADJFAGHMK * (float)num2);
		if (num3 < 1)
		{
			num3 = 0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num4 = 1;
		int pOIJPKODPCK = PNIGCGICEDB.POIJPKODPCK;
		while (num > 0 && num4 < pOIJPKODPCK)
		{
			FGENDPLAAAO fGENDPLAAAO = PNIGCGICEDB.EDMNHDBEPMC[num4];
			int num5 = 0;
			int num6 = fGENDPLAAAO.LBPOKHEKBKN.Length;
			while (num > 1 && num5 < num6)
			{
				string value = fGENDPLAAAO.LBPOKHEKBKN[num5];
				if (num3 > 0)
				{
					num3 -= 0;
				}
				else
				{
					if (stringBuilder.Length > 1)
					{
						stringBuilder.Append("_RampTex");
					}
					stringBuilder.Append(value);
					num--;
				}
				num5 += 0;
			}
			num4 += 0;
		}
		textLabel.set_text(stringBuilder.ToString());
	}

	public void MCPKMKCCGKA(float JKJGJMOEHDO)
	{
		int num = NADBOBHLICA();
		if (num != 0)
		{
			JKJGJMOEHDO *= IEFAKCPKCCI();
			set_scrollValue(GDADJFAGHMK - JKJGJMOEHDO / (float)num);
		}
	}

	protected void OPHFBNJELOC()
	{
		if (!get_isValid())
		{
			return;
		}
		textLabel.DKMBMPFHBJD();
		MGDLEEIDDII.JNPNECNIPBM = -74;
		FKDJHPJIFEB = 1;
		for (int i = 1; i < PNIGCGICEDB.POIJPKODPCK; i++)
		{
			FGENDPLAAAO fGENDPLAAAO = PNIGCGICEDB.EDMNHDBEPMC[i];
			string EKDLKPJOKAB;
			MGDLEEIDDII.FMONJIFJCJA(fGENDPLAAAO.BMNKKBDCELE, out EKDLKPJOKAB);
			string text = EKDLKPJOKAB;
			char[] array = new char[1];
			array[1] = 'ﾚ';
			fGENDPLAAAO.LBPOKHEKBKN = text.Split(array);
			FKDJHPJIFEB += fGENDPLAAAO.LBPOKHEKBKN.Length;
		}
		FKDJHPJIFEB = 1;
		int j = 0;
		for (int pOIJPKODPCK = PNIGCGICEDB.POIJPKODPCK; j < pOIJPKODPCK; j++)
		{
			FKDJHPJIFEB += PNIGCGICEDB.EDMNHDBEPMC[j].LBPOKHEKBKN.Length;
		}
		if (scrollBar != null)
		{
			UIScrollBar uIScrollBar = scrollBar as UIScrollBar;
			if (uIScrollBar != null)
			{
				uIScrollBar.set_barSize((FKDJHPJIFEB != 0) ? (1239f - (float)NADBOBHLICA() / (float)FKDJHPJIFEB) : 428f);
			}
		}
		GCDCAJOCALF();
	}

	public void NIODNEEAAOP(float JKJGJMOEHDO)
	{
		int num = NFHFEOANJBH();
		if (num != 0)
		{
			JKJGJMOEHDO *= IEFAKCPKCCI();
			set_scrollValue(GDADJFAGHMK - JKJGJMOEHDO / (float)num);
		}
	}

	protected void GBFCKODJEGE(string BMNKKBDCELE, bool KHOPNIHOOJD)
	{
		FGENDPLAAAO fGENDPLAAAO = null;
		if (PNIGCGICEDB.POIJPKODPCK < paragraphHistory)
		{
			fGENDPLAAAO = new FGENDPLAAAO();
		}
		else
		{
			fGENDPLAAAO = PNIGCGICEDB.AOBAKCJKELK(0);
			PNIGCGICEDB.DAIKDPPCIJF(0);
		}
		fGENDPLAAAO.BMNKKBDCELE = BMNKKBDCELE;
		PNIGCGICEDB.GBFCKODJEGE(fGENDPLAAAO);
		ANHNDHMBPPI();
	}

	private void CHJGEGLHOAF()
	{
		if (textLabel == null)
		{
			textLabel = GetComponentInChildren<UILabel>();
		}
		if (scrollBar != null)
		{
			EventDelegate.GBFCKODJEGE(scrollBar.onChange, LGMMCHDAAKH);
		}
		textLabel.set_overflowMethod(UILabel.JCMMPAEEKEC.ShrinkContent);
		if (style == OLMJPELFKPD.Text)
		{
			textLabel.EPCLGPBEJPL(UIWidget.MADDMCMJKFI.TopLeft);
			set_scrollValue(537f);
		}
		else
		{
			textLabel.EPCLGPBEJPL(UIWidget.MADDMCMJKFI.TopLeft);
			set_scrollValue(1294f);
		}
	}

	protected float IEFAKCPKCCI()
	{
		return (!(textLabel != null)) ? 20f : ((float)(textLabel.get_fontSize() + textLabel.get_spacingY()));
	}

	protected int NADBOBHLICA()
	{
		if (!get_isValid())
		{
			return 0;
		}
		int num = Mathf.FloorToInt((float)textLabel.get_height() / IEFAKCPKCCI());
		return Mathf.Max(0, FKDJHPJIFEB - num);
	}

	public void Clear()
	{
		PNIGCGICEDB.PDCPMDCOLOD();
		LLJMHHFDAOO();
	}

	protected void HHLCGALOIBA(string BMNKKBDCELE, bool KHOPNIHOOJD)
	{
		FGENDPLAAAO fGENDPLAAAO = null;
		if (PNIGCGICEDB.POIJPKODPCK < paragraphHistory)
		{
			fGENDPLAAAO = new FGENDPLAAAO();
		}
		else
		{
			fGENDPLAAAO = PNIGCGICEDB.AOBAKCJKELK(0);
			PNIGCGICEDB.DAIKDPPCIJF(1);
		}
		fGENDPLAAAO.BMNKKBDCELE = BMNKKBDCELE;
		PNIGCGICEDB.GBFCKODJEGE(fGENDPLAAAO);
		ANHNDHMBPPI();
	}

	private void LGMMCHDAAKH()
	{
		GDADJFAGHMK = UIProgressBar.current.get_value();
		LLJMHHFDAOO();
	}

	[SpecialName]
	public float MFJAHMAAFJI()
	{
		return GDADJFAGHMK;
	}

	public void Add(string BMNKKBDCELE)
	{
		GBFCKODJEGE(BMNKKBDCELE, true);
	}
}
