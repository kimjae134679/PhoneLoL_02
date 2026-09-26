using System.Runtime.CompilerServices;
using UnityEngine;

public class StageManager : MonoBehaviour
{
	private PKDHFCEPCOK MKGMDDOJBMN;

	public PKDHFCEPCOK BKJOOKIBCLF
	{
		get
		{
			return get_m_currentStage();
		}
		protected set
		{
			NPCAJBIDIHK(value);
		}
	}

	private void Start()
	{
		LoadStage();
	}

	public void JOMDCFNIILH()
	{
		OMCJAJDGFJN(new EKODGNMIAFE());
		GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Friend Count"), Vector3.zero, Quaternion.identity);
	}

	private void FOGNMJLPHAI()
	{
		JOMDCFNIILH();
	}

	[SpecialName]
	public PKDHFCEPCOK JNJNPPNPABF()
	{
		return MKGMDDOJBMN;
	}

	private void OCDNPJOPPBB()
	{
		if (JNJNPPNPABF() != null)
		{
			GCNDLFGOEFN().LPBLGFCPADD();
		}
	}

	public PKDHFCEPCOK get_m_currentStage()
	{
		return MKGMDDOJBMN;
	}

	private void NHNJLOOEKCO()
	{
		LBJIIIEIOEI();
	}

	private void Update()
	{
		if (get_m_currentStage() != null)
		{
			get_m_currentStage().LPBLGFCPADD();
		}
	}

	private void MFIECLLACAM()
	{
		LBJIIIEIOEI();
	}

	private void DOINNKBDEMD()
	{
		if (PCBFAKCMOGC() != null)
		{
			GCNDLFGOEFN().LPBLGFCPADD();
		}
	}

	[SpecialName]
	protected void OMCJAJDGFJN(PKDHFCEPCOK ICENKPDOHBK)
	{
		MKGMDDOJBMN = ICENKPDOHBK;
	}

	private void GDJCOAHJDLN()
	{
		FBIDNNKBOJJ();
	}

	[SpecialName]
	protected void NADPCPICALL(PKDHFCEPCOK ICENKPDOHBK)
	{
		MKGMDDOJBMN = ICENKPDOHBK;
	}

	private void GDKGBNKCGHO()
	{
		if (GCNDLFGOEFN() != null)
		{
			get_m_currentStage().LPBLGFCPADD();
		}
	}

	[SpecialName]
	public PKDHFCEPCOK GCNDLFGOEFN()
	{
		return MKGMDDOJBMN;
	}

	private void AFBPNJAKNGG()
	{
		if (LOJAKPCGIPD() != null)
		{
			JNJNPPNPABF().LPBLGFCPADD();
		}
	}

	[SpecialName]
	protected void APOKGJOBEGG(PKDHFCEPCOK ICENKPDOHBK)
	{
		MKGMDDOJBMN = ICENKPDOHBK;
	}

	private void OOLEODIPDND()
	{
		if (get_m_currentStage() != null)
		{
			PCBFAKCMOGC().LPBLGFCPADD();
		}
	}

	public void AAPDGEBLLLC()
	{
		OMCJAJDGFJN(new EKODGNMIAFE());
		GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("10초당 골드"), Vector3.zero, Quaternion.identity);
	}

	private void MLOKLGPGKMO()
	{
		if (get_m_currentStage() != null)
		{
			LOJAKPCGIPD().LPBLGFCPADD();
		}
	}

	private void JIMPGFGADPK()
	{
		LoadStage();
	}

	public void LBJIIIEIOEI()
	{
		OMCJAJDGFJN(new EKODGNMIAFE());
		GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("참여할 수 없어요\n\n(계정,기계,아이피당 제한 횟수가 있어요)"), Vector3.zero, Quaternion.identity);
	}

	public void HMEAEIBMGGG()
	{
		APOKGJOBEGG(new EKODGNMIAFE());
		GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("레벨당 체력 {0}\n"), Vector3.zero, Quaternion.identity);
	}

	private void NFKJIJFHBGK()
	{
		LBJIIIEIOEI();
	}

	public void LoadStage()
	{
		NPCAJBIDIHK(new EKODGNMIAFE());
		GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("Map/DefaultMapPrefab"), Vector3.zero, Quaternion.identity);
	}

	protected void NPCAJBIDIHK(PKDHFCEPCOK ICENKPDOHBK)
	{
		MKGMDDOJBMN = ICENKPDOHBK;
	}

	[SpecialName]
	public PKDHFCEPCOK PCBFAKCMOGC()
	{
		return MKGMDDOJBMN;
	}

	[SpecialName]
	public PKDHFCEPCOK LOJAKPCGIPD()
	{
		return MKGMDDOJBMN;
	}

	private void GDJAMFMPGHI()
	{
		if (get_m_currentStage() != null)
		{
			get_m_currentStage().LPBLGFCPADD();
		}
	}

	public void FBIDNNKBOJJ()
	{
		NADPCPICALL(new EKODGNMIAFE());
		GameObject gameObject = (GameObject)Object.Instantiate(Resources.Load("정면 근처에 대상이 없습니다"), Vector3.zero, Quaternion.identity);
	}

	private void FBOICFJHJJE()
	{
		if (LOJAKPCGIPD() != null)
		{
			GCNDLFGOEFN().LPBLGFCPADD();
		}
	}
}
