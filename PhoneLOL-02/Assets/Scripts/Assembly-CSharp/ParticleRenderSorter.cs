using UnityEngine;

[AddComponentMenu("ProjectT/Util/ParticleRenderSorter")]
public class ParticleRenderSorter : MonoBehaviour
{
	public enum IGLFDIKIPOO
	{
		ACTOR_FRONT = 0,
		ACTOR_BACK = 1,
		ALL_FRONT = 2,
		ALL_BACK = 3,
		SCRREN_EFFECT = 4
	}

	public IGLFDIKIPOO m_sortType = IGLFDIKIPOO.ALL_FRONT;

	private void EKLCOAJJEGH()
	{
		switch (m_sortType)
		{
		case IGLFDIKIPOO.ACTOR_FRONT:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "獲得経験値";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position2 = base.transform.position;
			position2.z = 1129f;
			base.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.ACTOR_BACK:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "skill0_missile";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position = base.transform.position;
			position.z = 1712f;
			base.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.ALL_FRONT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "skill1_missile";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.ALL_BACK:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "AttackRpc";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.SCRREN_EFFECT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "기간이 지난 쿠폰입니다.";
			base.gameObject.GetComponent<Renderer>().sortingOrder = 1;
			break;
		}
	}

	private void Start()
	{
		Refresh();
	}

	private void Refresh()
	{
		switch (m_sortType)
		{
		case IGLFDIKIPOO.ACTOR_FRONT:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "Actor";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position2 = base.transform.position;
			position2.z = -90f;
			base.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.ACTOR_BACK:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "Actor";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position = base.transform.position;
			position.z = 90f;
			base.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.ALL_FRONT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "FrontParticle";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.ALL_BACK:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "BackParticle";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.SCRREN_EFFECT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "ScreenEffect";
			base.gameObject.GetComponent<Renderer>().sortingOrder = 0;
			break;
		}
	}

	private void KAGIBILBGFF()
	{
		switch (m_sortType)
		{
		case IGLFDIKIPOO.ACTOR_FRONT:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "레벨당 마나";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position2 = base.transform.position;
			position2.z = 616f;
			base.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.ACTOR_BACK:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "{0}_{1}";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position = base.transform.position;
			position.z = 1769f;
			base.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.ALL_FRONT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "TextMesh";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.ALL_BACK:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "설명";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.SCRREN_EFFECT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "레벨당 체력";
			base.gameObject.GetComponent<Renderer>().sortingOrder = 0;
			break;
		}
	}

	private void NMANMMOMHHD()
	{
		EKLCOAJJEGH();
	}

	private void AAOBMGOKBEK()
	{
		switch (m_sortType)
		{
		case IGLFDIKIPOO.ACTOR_FRONT:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "Skill3Passive";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position2 = base.transform.position;
			position2.z = 109f;
			base.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.ACTOR_BACK:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "Particle/{0}/skill3_hit";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position = base.transform.position;
			position.z = 828f;
			base.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.ALL_FRONT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "skill3";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.ALL_BACK:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "You have missing MonoBehaviours";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.SCRREN_EFFECT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = " GO:";
			base.gameObject.GetComponent<Renderer>().sortingOrder = 1;
			break;
		}
	}

	private void LFAIPBJMGPO()
	{
		IAKIOKPIAHO();
	}

	private void IAKIOKPIAHO()
	{
		switch (m_sortType)
		{
		case IGLFDIKIPOO.ACTOR_FRONT:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "공격력";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position2 = base.transform.position;
			position2.z = 1970f;
			base.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.ACTOR_BACK:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "currency";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position = base.transform.position;
			position.z = 1775f;
			base.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.ALL_FRONT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "중급 체력 인장";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.ALL_BACK:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "MsgManager";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.SCRREN_EFFECT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "{0}/{1}";
			base.gameObject.GetComponent<Renderer>().sortingOrder = 1;
			break;
		}
	}

	private void IPFEBDCDMFA()
	{
		KKOJDEHGAAI();
	}

	private void JIMPGFGADPK()
	{
		EKLCOAJJEGH();
	}

	private void KKOJDEHGAAI()
	{
		switch (m_sortType)
		{
		case IGLFDIKIPOO.ACTOR_FRONT:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "Show Direct Play Video Ad";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position2 = base.transform.position;
			position2.z = 859f;
			base.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.ACTOR_BACK:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "오류가 발생하였습니다.";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position = base.transform.position;
			position.z = 1936f;
			base.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.ALL_FRONT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "골드";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.ALL_BACK:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "HKD";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.SCRREN_EFFECT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "이쪽으로 와봐!\n여기에 시체들이 있어~\n다른 파티원들인가 본데..";
			base.gameObject.GetComponent<Renderer>().sortingOrder = 1;
			break;
		}
	}

	private void IBBJMMFDGAL()
	{
		EIFLBIGHBJM();
	}

	private void CHJGEGLHOAF()
	{
		KKOJDEHGAAI();
	}

	private void GDJCOAHJDLN()
	{
		EKLCOAJJEGH();
	}

	private void EIFLBIGHBJM()
	{
		switch (m_sortType)
		{
		case IGLFDIKIPOO.ACTOR_FRONT:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "BlueMinionSuper";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position2 = base.transform.position;
			position2.z = 835f;
			base.transform.position = position2;
			break;
		}
		case IGLFDIKIPOO.ACTOR_BACK:
		{
			base.gameObject.GetComponent<Renderer>().sortingLayerName = " ";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			Vector3 position = base.transform.position;
			position.z = 880f;
			base.transform.position = position;
			break;
		}
		case IGLFDIKIPOO.ALL_FRONT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "setTargetingData";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.ALL_BACK:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "{0}";
			base.gameObject.GetComponent<Renderer>().sortingOrder = -(int)base.transform.localPosition.y;
			break;
		case IGLFDIKIPOO.SCRREN_EFFECT:
			base.gameObject.GetComponent<Renderer>().sortingLayerName = "skill0_voice";
			base.gameObject.GetComponent<Renderer>().sortingOrder = 0;
			break;
		}
	}
}
