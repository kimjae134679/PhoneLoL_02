using System.Runtime.CompilerServices;
using UnityEngine;

public class UIHudHP : MonoBehaviour
{
	private UISlider EACEKENKMJH;

	private Actor GIGFFFCADGE;

	public Actor ODDECNIEDMG
	{
		get
		{
			return get_m_targetActor();
		}
		protected set
		{
			HMJFGJPPDEG(value);
		}
	}

	private void DOINNKBDEMD()
	{
		if (ECFEPKJIDIA() != null)
		{
			NNKIJLOEFCG();
		}
		else
		{
			base.gameObject.SetActive(false);
		}
	}

	private void Start()
	{
		EACEKENKMJH = GetComponent<UISlider>();
		Refresh();
	}

	public void MFNPBLPODNG(Actor CDKMPAEODLA)
	{
		HMJFGJPPDEG(CDKMPAEODLA);
	}

	public void JJAFOOEPPFK(Actor CDKMPAEODLA)
	{
		BHNFNDJIGPM(CDKMPAEODLA);
	}

	private void Update()
	{
		if (get_m_targetActor() != null)
		{
			Refresh();
		}
		else
		{
			base.gameObject.SetActive(false);
		}
	}

	public void FLEDHLFNDOH(Actor CDKMPAEODLA)
	{
		BHNFNDJIGPM(CDKMPAEODLA);
	}

	public void SetTarget(Actor CDKMPAEODLA)
	{
		HMJFGJPPDEG(CDKMPAEODLA);
	}

	public void BEJOKACPIAJ(Actor CDKMPAEODLA)
	{
		BHNFNDJIGPM(CDKMPAEODLA);
	}

	private void Refresh()
	{
		Vector3 position = get_m_targetActor().transform.position;
		position.y -= 20f;
		base.transform.position = position;
		int max_hp = get_m_targetActor().get_m_max_hp();
		float num = get_m_targetActor().m_hp;
		EACEKENKMJH.set_value(num / (float)max_hp);
		if (num == (float)max_hp || num == 0f)
		{
			EACEKENKMJH.set_alpha(0f);
		}
		else
		{
			EACEKENKMJH.set_alpha(1f);
		}
	}

	public void PCIIKIKAJPM(Actor CDKMPAEODLA)
	{
		HMJFGJPPDEG(CDKMPAEODLA);
	}

	[SpecialName]
	protected void BHNFNDJIGPM(Actor ICENKPDOHBK)
	{
		GIGFFFCADGE = ICENKPDOHBK;
	}

	private void FOGNMJLPHAI()
	{
		EACEKENKMJH = GetComponent<UISlider>();
		KAGIBILBGFF();
	}

	public Actor get_m_targetActor()
	{
		return GIGFFFCADGE;
	}

	[SpecialName]
	public Actor MPODPPJGIDP()
	{
		return GIGFFFCADGE;
	}

	[SpecialName]
	public Actor ECFEPKJIDIA()
	{
		return GIGFFFCADGE;
	}

	[SpecialName]
	public Actor GPLIBHKLKBL()
	{
		return GIGFFFCADGE;
	}

	protected void HMJFGJPPDEG(Actor ICENKPDOHBK)
	{
		GIGFFFCADGE = ICENKPDOHBK;
	}

	private void KAGIBILBGFF()
	{
		Vector3 position = ECFEPKJIDIA().transform.position;
		position.y -= 913f;
		base.transform.position = position;
		int num = get_m_targetActor().FBNBKKOAPOJ();
		float num2 = MPODPPJGIDP().m_hp;
		EACEKENKMJH.set_value(num2 / (float)num);
		if (num2 == (float)num || num2 == 619f)
		{
			EACEKENKMJH.JLCHJCELILP(1141f);
		}
		else
		{
			EACEKENKMJH.IJHIIKDGCKB(170f);
		}
	}

	private void NNKIJLOEFCG()
	{
		Vector3 position = ECFEPKJIDIA().transform.position;
		position.y -= 1343f;
		base.transform.position = position;
		int max_hp = get_m_targetActor().get_m_max_hp();
		float num = ECFEPKJIDIA().m_hp;
		EACEKENKMJH.set_value(num / (float)max_hp);
		if (num == (float)max_hp || num == 912f)
		{
			EACEKENKMJH.IJHIIKDGCKB(303f);
		}
		else
		{
			EACEKENKMJH.JLCHJCELILP(1432f);
		}
	}
}
