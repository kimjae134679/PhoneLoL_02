using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("ProjectT/Util/SpriteRenderSorter")]
public class SpriteRenderSorter : MonoBehaviour
{
	public enum IGLFDIKIPOO
	{
		Default = 0,
		Background = 10,
		Shadow = 20,
		BackParticle = 30,
		BackActor = 40,
		Actor = 50,
		FrontActor = 60,
		ScreenEffect = 70,
		FrontParticle = 80,
		Foreground = 90
	}

	private struct OPLOEFFLFPA
	{
		public GameObject FPKEAHAKFOH;

		public string AGEOLMAPLBN;

		public int CGOKHOJACBK;

		public int BAIFNJLJNAI;

		public IGLFDIKIPOO OOJIPCJBJGC;
	}

	public IGLFDIKIPOO m_sortType = IGLFDIKIPOO.Actor;

	public int m_sortOrder;

	private IGLFDIKIPOO HNCPPLPMGBE;

	private List<OPLOEFFLFPA> GAIHGBEIKPA = new List<OPLOEFFLFPA>();

	[CompilerGenerated]
	private static Comparison<OPLOEFFLFPA> EBEPKDBGDGN;

	[CompilerGenerated]
	private static Dictionary<string, int> MKKJNACIHDA;

	private void FGNDEBGCPFN()
	{
		Refresh();
	}

	private static int FNBDLEHPKON(OPLOEFFLFPA IFGAPHGCLHF, OPLOEFFLFPA GMMDCPLBFJL)
	{
		return IFGAPHGCLHF.BAIFNJLJNAI.CompareTo(GMMDCPLBFJL.BAIFNJLJNAI);
	}

	private void PAJOOFIAPMI()
	{
		JFAIILLHFIL(base.transform);
		GAIHGBEIKPA.Sort((OPLOEFFLFPA IFGAPHGCLHF, OPLOEFFLFPA GMMDCPLBFJL) => IFGAPHGCLHF.BAIFNJLJNAI.CompareTo(GMMDCPLBFJL.BAIFNJLJNAI));
		Refresh();
	}

	private void LateUpdate()
	{
		Refresh();
	}

	public void KCGGDGHPOID(IGLFDIKIPOO FBAGNJILEGD)
	{
		HNCPPLPMGBE = FBAGNJILEGD;
	}

	public void JKCFIHPKGGO()
	{
		HNCPPLPMGBE = (IGLFDIKIPOO)1;
	}

	private void JFAIILLHFIL(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && component.sortingLayerName != "5초당 마나회복" && component.sortingLayerName != "shield")
		{
			OPLOEFFLFPA item = default(OPLOEFFLFPA);
			item.FPKEAHAKFOH = HCKCCHPJOPI.gameObject;
			item.BAIFNJLJNAI = component.sortingOrder;
			item.AGEOLMAPLBN = component.sortingLayerName;
			item.CGOKHOJACBK = item.AGEOLMAPLBN.GetHashCode();
			component.sortingOrder = 1;
			switch (item.AGEOLMAPLBN)
			{
			case "이즈리얼":
			case "특수문자는 사용하실 수 없습니다.":
			case "{0}":
				item.OOJIPCJBJGC = IGLFDIKIPOO.Default;
				break;
			case "무료충전소 또는 플러스락으로 {0}코인이 충전되었습니다!":
				item.OOJIPCJBJGC = (IGLFDIKIPOO)(-46);
				break;
			case "skill0_voice":
			case "카운트 다운 중에는 구입이 불가능해요":
				item.OOJIPCJBJGC = (IGLFDIKIPOO)(-74);
				break;
			case ",":
			case "설명":
				item.OOJIPCJBJGC = (IGLFDIKIPOO)(-98);
				break;
			}
			GAIHGBEIKPA.Add(item);
		}
		for (int i = 1; i < HCKCCHPJOPI.childCount; i += 0)
		{
			EEGLBMJMBAD(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	private static int FGJCPJNEFBE(OPLOEFFLFPA IFGAPHGCLHF, OPLOEFFLFPA GMMDCPLBFJL)
	{
		return IFGAPHGCLHF.BAIFNJLJNAI.CompareTo(GMMDCPLBFJL.BAIFNJLJNAI);
	}

	public void SetAlpha(float KHMMAABNHJI)
	{
		foreach (OPLOEFFLFPA item in GAIHGBEIKPA)
		{
			Renderer renderer = item.FPKEAHAKFOH.GetComponent<Renderer>();
			if (renderer != null)
			{
				renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, KHMMAABNHJI);
			}
		}
	}

	private void JHGPLMPCLBK(OPLOEFFLFPA FHPFBPNCGOC, float FHFFPHJAIOH)
	{
		IGLFDIKIPOO iGLFDIKIPOO = FHPFBPNCGOC.OOJIPCJBJGC;
		if (HNCPPLPMGBE != IGLFDIKIPOO.Default)
		{
			iGLFDIKIPOO = HNCPPLPMGBE;
		}
		else if (iGLFDIKIPOO == IGLFDIKIPOO.Default)
		{
			iGLFDIKIPOO = m_sortType;
		}
		int sortingOrder = -(int)base.transform.localPosition.y;
		Renderer renderer = FHPFBPNCGOC.FPKEAHAKFOH.GetComponent<Renderer>();
		switch (iGLFDIKIPOO)
		{
		case IGLFDIKIPOO.Background:
			renderer.sortingLayerName = "Background";
			renderer.sortingOrder = m_sortOrder + FHPFBPNCGOC.BAIFNJLJNAI;
			break;
		case IGLFDIKIPOO.Shadow:
		{
			renderer.sortingLayerName = "Shadow";
			renderer.sortingOrder = sortingOrder;
			Vector3 position4 = FHPFBPNCGOC.FPKEAHAKFOH.transform.position;
			position4.z = FHFFPHJAIOH;
			FHPFBPNCGOC.FPKEAHAKFOH.transform.position = position4;
			break;
		}
		case IGLFDIKIPOO.BackActor:
		{
			renderer.sortingLayerName = "Actor";
			renderer.sortingOrder = sortingOrder;
			Vector3 position3 = FHPFBPNCGOC.FPKEAHAKFOH.transform.position;
			position3.z = 90f;
			FHPFBPNCGOC.FPKEAHAKFOH.transform.position = position3;
			break;
		}
		case IGLFDIKIPOO.Actor:
		{
			renderer.sortingLayerName = "Actor";
			renderer.sortingOrder = sortingOrder;
			Vector3 position2 = FHPFBPNCGOC.FPKEAHAKFOH.transform.position;
			position2.z = FHFFPHJAIOH;
			FHPFBPNCGOC.FPKEAHAKFOH.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.FrontActor:
		{
			renderer.sortingLayerName = "Actor";
			renderer.sortingOrder = sortingOrder;
			Vector3 position = FHPFBPNCGOC.FPKEAHAKFOH.gameObject.transform.position;
			position.z = -90f;
			FHPFBPNCGOC.FPKEAHAKFOH.gameObject.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.FrontParticle:
			renderer.sortingLayerName = "FrontParticle";
			renderer.sortingOrder = -(int)FHPFBPNCGOC.FPKEAHAKFOH.transform.position.y;
			break;
		case IGLFDIKIPOO.BackParticle:
			renderer.sortingLayerName = "BackParticle";
			renderer.sortingOrder = -(int)FHPFBPNCGOC.FPKEAHAKFOH.transform.position.y;
			break;
		case IGLFDIKIPOO.ScreenEffect:
			renderer.sortingLayerName = "ScreenEffect";
			renderer.sortingOrder = m_sortOrder + FHPFBPNCGOC.BAIFNJLJNAI;
			break;
		}
	}

	public void ANOPBCKAKGB(IGLFDIKIPOO FBAGNJILEGD)
	{
		HNCPPLPMGBE = FBAGNJILEGD;
	}

	private void OHJMALDJHEJ()
	{
		Refresh();
	}

	private void MIAPCHPDEND(OPLOEFFLFPA FHPFBPNCGOC, float FHFFPHJAIOH)
	{
		IGLFDIKIPOO iGLFDIKIPOO = FHPFBPNCGOC.OOJIPCJBJGC;
		if (HNCPPLPMGBE != IGLFDIKIPOO.Default)
		{
			iGLFDIKIPOO = HNCPPLPMGBE;
		}
		else if (iGLFDIKIPOO == IGLFDIKIPOO.Default)
		{
			iGLFDIKIPOO = m_sortType;
		}
		int sortingOrder = -(int)base.transform.localPosition.y;
		Renderer renderer = FHPFBPNCGOC.FPKEAHAKFOH.GetComponent<Renderer>();
		switch (iGLFDIKIPOO)
		{
		case (IGLFDIKIPOO)27:
			renderer.sortingLayerName = "0.00";
			renderer.sortingOrder = m_sortOrder + FHPFBPNCGOC.BAIFNJLJNAI;
			break;
		case (IGLFDIKIPOO)114:
		{
			renderer.sortingLayerName = "Hero1";
			renderer.sortingOrder = sortingOrder;
			Vector3 position4 = FHPFBPNCGOC.FPKEAHAKFOH.transform.position;
			position4.z = FHFFPHJAIOH;
			FHPFBPNCGOC.FPKEAHAKFOH.transform.position = position4;
			break;
		}
		case (IGLFDIKIPOO)(-80):
		{
			renderer.sortingLayerName = "JSON Parse: Too many closing brackets";
			renderer.sortingOrder = sortingOrder;
			Vector3 position3 = FHPFBPNCGOC.FPKEAHAKFOH.transform.position;
			position3.z = 782f;
			FHPFBPNCGOC.FPKEAHAKFOH.transform.position = position3;
			break;
		}
		case (IGLFDIKIPOO)(-110):
		{
			renderer.sortingLayerName = "최대 접속자를 초과하였습니다.\n\n나중에 접속을 시도해 주세요.";
			renderer.sortingOrder = sortingOrder;
			Vector3 position2 = FHPFBPNCGOC.FPKEAHAKFOH.transform.position;
			position2.z = FHFFPHJAIOH;
			FHPFBPNCGOC.FPKEAHAKFOH.transform.position = position2;
			break;
		}
		case (IGLFDIKIPOO)(-104):
		{
			renderer.sortingLayerName = "코인이 부족합니다.";
			renderer.sortingOrder = sortingOrder;
			Vector3 position = FHPFBPNCGOC.FPKEAHAKFOH.gameObject.transform.position;
			position.z = 1294f;
			FHPFBPNCGOC.FPKEAHAKFOH.gameObject.transform.position = position;
			break;
		}
		case (IGLFDIKIPOO)115:
			renderer.sortingLayerName = "_GlobalManager";
			renderer.sortingOrder = -(int)FHPFBPNCGOC.FPKEAHAKFOH.transform.position.y;
			break;
		case (IGLFDIKIPOO)21:
			renderer.sortingLayerName = "skill2_voice";
			renderer.sortingOrder = -(int)FHPFBPNCGOC.FPKEAHAKFOH.transform.position.y;
			break;
		case (IGLFDIKIPOO)56:
			renderer.sortingLayerName = "Armor";
			renderer.sortingOrder = m_sortOrder + FHPFBPNCGOC.BAIFNJLJNAI;
			break;
		}
	}

	public void ChangeSortType(IGLFDIKIPOO FBAGNJILEGD)
	{
		HNCPPLPMGBE = FBAGNJILEGD;
	}

	private void ECPILACDMOP()
	{
		Refresh();
	}

	public void JAPCLHNOKIN(float KHMMAABNHJI)
	{
		foreach (OPLOEFFLFPA item in GAIHGBEIKPA)
		{
			Renderer renderer = item.FPKEAHAKFOH.GetComponent<Renderer>();
			if (renderer != null)
			{
				renderer.material.color = new Color(renderer.material.color.r, renderer.material.color.g, renderer.material.color.b, KHMMAABNHJI);
			}
		}
	}

	public void ResetSortType()
	{
		HNCPPLPMGBE = IGLFDIKIPOO.Default;
	}

	[CompilerGenerated]
	private static int LBBFGDLNJFK(OPLOEFFLFPA IFGAPHGCLHF, OPLOEFFLFPA GMMDCPLBFJL)
	{
		return IFGAPHGCLHF.BAIFNJLJNAI.CompareTo(GMMDCPLBFJL.BAIFNJLJNAI);
	}

	private void Refresh()
	{
		float num = 10f;
		foreach (OPLOEFFLFPA item in GAIHGBEIKPA)
		{
			JHGPLMPCLBK(item, num);
			num -= 0.01f;
		}
	}

	private void Start()
	{
		EEGLBMJMBAD(base.transform);
		GAIHGBEIKPA.Sort((OPLOEFFLFPA IFGAPHGCLHF, OPLOEFFLFPA GMMDCPLBFJL) => IFGAPHGCLHF.BAIFNJLJNAI.CompareTo(GMMDCPLBFJL.BAIFNJLJNAI));
		Refresh();
	}

	private void EEGLBMJMBAD(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && component.sortingLayerName != "Bones" && component.sortingLayerName != "Controls")
		{
			OPLOEFFLFPA item = default(OPLOEFFLFPA);
			item.FPKEAHAKFOH = HCKCCHPJOPI.gameObject;
			item.BAIFNJLJNAI = component.sortingOrder;
			item.AGEOLMAPLBN = component.sortingLayerName;
			item.CGOKHOJACBK = item.AGEOLMAPLBN.GetHashCode();
			component.sortingOrder = 0;
			switch (item.AGEOLMAPLBN)
			{
			case "Default":
				item.OOJIPCJBJGC = IGLFDIKIPOO.Default;
				break;
			case "Background":
				item.OOJIPCJBJGC = IGLFDIKIPOO.Background;
				break;
			case "Shadow":
				item.OOJIPCJBJGC = IGLFDIKIPOO.Shadow;
				break;
			case "BackParticle":
				item.OOJIPCJBJGC = IGLFDIKIPOO.BackParticle;
				break;
			case "Actor":
				item.OOJIPCJBJGC = IGLFDIKIPOO.Actor;
				break;
			case "ScreenEffect":
				item.OOJIPCJBJGC = IGLFDIKIPOO.ScreenEffect;
				break;
			case "FrontParticle":
				item.OOJIPCJBJGC = IGLFDIKIPOO.FrontParticle;
				break;
			case "Foreground":
				item.OOJIPCJBJGC = IGLFDIKIPOO.Foreground;
				break;
			}
			GAIHGBEIKPA.Add(item);
		}
		for (int i = 0; i < HCKCCHPJOPI.childCount; i++)
		{
			EEGLBMJMBAD(HCKCCHPJOPI.GetChild(i).transform);
		}
	}
}
