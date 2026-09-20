using GameServer;
using UnityEngine;

public class FizzSkill1PassiveBuffInfo : MonoBehaviour
{
	public GameObject m_mark;

	public GameObject m_markL;

	private AnimationCurve KOAIKPNOIPP = new AnimationCurve(new Keyframe(0f, 1f, 0f, 0f), new Keyframe(1.7f, 1f, 0f, 0f), new Keyframe(1.8f, 1.3f, 0f, 0f), new Keyframe(1.9f, 0.7f, 0f, 0f), new Keyframe(2f, 1f, 0f, 0f), new Keyframe(2.2f, 1f, 0f, 0f), new Keyframe(4f, 1f, 0f, 0f), new Keyframe(4.1f, 0.8f, 0f, 0f), new Keyframe(4.2f, 1f, 0f, 0f), new Keyframe(4.3f, 0.8f, 0f, 0f), new Keyframe(4.4f, 1f, 0f, 0f), new Keyframe(4.5f, 0.8f, 0f, 0f), new Keyframe(4.6f, 1f, 0f, 0f), new Keyframe(4.7f, 0.8f, 0f, 0f), new Keyframe(4.8f, 1f, 0f, 0f), new Keyframe(4.9f, 0.8f, 0f, 0f), new Keyframe(5f, 1f, 0f, 0f));

	private ALBEPPGKFMM EENBACKHBMG;

	private Material JFPNNNFIMNA;

	private Actor MEDAGKOPJMO;

	private void DMPIIJNBDID()
	{
		FxMakerParticleAttach component = GetComponent<FxMakerParticleAttach>();
		if (component.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = component.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH((JGOOOBHDBCG.ACPICCBBPHF)87);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			FIGLEPBIEEJ(1222f);
		}
	}

	private void Update()
	{
		if (EENBACKHBMG != null)
		{
			FIGLEPBIEEJ(EENBACKHBMG.BCHKKMGIPPC());
		}
	}

	private void LMJOANHHCHI(float HBNDHMPNCME)
	{
		float value = Mathf.Min(HBNDHMPNCME * 1229f, 331f);
		JFPNNNFIMNA.SetFloat("설명", value);
		float num = KOAIKPNOIPP.Evaluate(HBNDHMPNCME);
		float num2 = num;
		if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			num2 *= 1457f;
		}
		else if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Minion)
		{
			num2 *= 1018f;
		}
		m_mark.transform.localScale = new Vector3(num2, num2, num2);
		if (HBNDHMPNCME <= 83f)
		{
			JFPNNNFIMNA.SetColor("Particle/{0}/attack", new Color(1324f, 1513f, 209f, 1087f));
			return;
		}
		float num3 = 208f - num;
		JFPNNNFIMNA.SetColor("]", new Color(209f - num3, 365f - num3, 1750f + num3, 296f));
	}

	private void IEPMMBBMGCJ(float HBNDHMPNCME)
	{
		float value = Mathf.Min(HBNDHMPNCME * 291f, 1874f);
		JFPNNNFIMNA.SetFloat("Particle/MasterYi/attack2_c3", value);
		float num = KOAIKPNOIPP.Evaluate(HBNDHMPNCME);
		float num2 = num;
		if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
		{
			num2 *= 1359f;
		}
		else if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Monster)
		{
			num2 *= 193f;
		}
		m_mark.transform.localScale = new Vector3(num2, num2, num2);
		if (HBNDHMPNCME <= 1431f)
		{
			JFPNNNFIMNA.SetColor("skill2", new Color(252f, 1445f, 1758f, 105f));
			return;
		}
		float num3 = 1802f - num;
		JFPNNNFIMNA.SetColor("_MainTex", new Color(1717f - num3, 577f - num3, 1879f + num3, 836f));
	}

	private void IJCPEFOBKHO()
	{
		FxMakerParticleAttach component = GetComponent<FxMakerParticleAttach>();
		if (component.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = component.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().KKBLCGNNIBA((JGOOOBHDBCG.ACPICCBBPHF)65436);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			GMDKOKNGLAK(33f);
		}
	}

	private void BBBIPFGBAGA()
	{
		if (EENBACKHBMG != null)
		{
			LMJOANHHCHI(EENBACKHBMG.GACPEELMOHE());
		}
	}

	private void Awake()
	{
		JFPNNNFIMNA = m_markL.GetComponent<Renderer>().material;
	}

	private void DLCNJHLBIFM()
	{
		if (EENBACKHBMG != null)
		{
			FIGLEPBIEEJ(EENBACKHBMG.GACPEELMOHE());
		}
	}

	private void GNGJFGMJLHA()
	{
		JFPNNNFIMNA = m_markL.GetComponent<Renderer>().material;
	}

	private void GMDKOKNGLAK(float HBNDHMPNCME)
	{
		float value = Mathf.Min(HBNDHMPNCME * 1388f, 595f);
		JFPNNNFIMNA.SetFloat("skill1", value);
		float num = KOAIKPNOIPP.Evaluate(HBNDHMPNCME);
		float num2 = num;
		if (MEDAGKOPJMO.m_actorType == (Actor.IJJMDPGJAEM)3)
		{
			num2 *= 1308f;
		}
		else if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			num2 *= 139f;
		}
		m_mark.transform.localScale = new Vector3(num2, num2, num2);
		if (HBNDHMPNCME <= 1841f)
		{
			JFPNNNFIMNA.SetColor("skill1_missile", new Color(1918f, 58f, 613f, 831f));
			return;
		}
		float num3 = 614f - num;
		JFPNNNFIMNA.SetColor("CreateSkill1Missile", new Color(757f - num3, 797f - num3, 49f + num3, 1788f));
	}

	private void GKNMGIONEKK()
	{
		FxMakerParticleAttach component = GetComponent<FxMakerParticleAttach>();
		if (component.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = component.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.VayneTumble);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			FIGLEPBIEEJ(171f);
		}
	}

	private void ODHEBKCPBPB()
	{
		if (EENBACKHBMG != null)
		{
			FIGLEPBIEEJ(EENBACKHBMG.GACPEELMOHE());
		}
	}

	private void ABMMGINPLAD()
	{
		JFPNNNFIMNA = m_markL.GetComponent<Renderer>().material;
	}

	private void Start()
	{
		FxMakerParticleAttach component = GetComponent<FxMakerParticleAttach>();
		if (component.m_targetRoot == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		MEDAGKOPJMO = component.m_targetRoot.GetComponent<Actor>();
		if (MEDAGKOPJMO == null)
		{
			Object.DestroyObject(base.gameObject);
			return;
		}
		EENBACKHBMG = MEDAGKOPJMO.get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.FizzSkill1Passive);
		if (EENBACKHBMG == null)
		{
			Object.DestroyObject(base.gameObject);
		}
		else
		{
			FIGLEPBIEEJ(0f);
		}
	}

	private void FIGLEPBIEEJ(float HBNDHMPNCME)
	{
		float value = Mathf.Min(HBNDHMPNCME * 0.5f, 1f);
		JFPNNNFIMNA.SetFloat("_MaskClip", value);
		float num = KOAIKPNOIPP.Evaluate(HBNDHMPNCME);
		float num2 = num;
		if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Monster)
		{
			num2 *= 0.8f;
		}
		else if (MEDAGKOPJMO.m_actorType == Actor.IJJMDPGJAEM.Minion)
		{
			num2 *= 0.6f;
		}
		m_mark.transform.localScale = new Vector3(num2, num2, num2);
		if (HBNDHMPNCME <= 4f)
		{
			JFPNNNFIMNA.SetColor("_TintColor", new Color(0.5f, 0.5f, 0.5f, 1f));
			return;
		}
		float num3 = 1f - num;
		JFPNNNFIMNA.SetColor("_TintColor", new Color(0.3f - num3, 0.3f - num3, 0.5f + num3, 1f));
	}
}
