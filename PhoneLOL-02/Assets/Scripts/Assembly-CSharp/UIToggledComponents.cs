using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Toggled Components")]
[RequireComponent(typeof(UIToggle))]
[ExecuteInEditMode]
public class UIToggledComponents : MonoBehaviour
{
	public List<MonoBehaviour> activate;

	public List<MonoBehaviour> deactivate;

	[HideInInspector]
	[SerializeField]
	private MonoBehaviour target;

	[SerializeField]
	[HideInInspector]
	private bool inverse;

	private void NGNNLLLBGMB()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, PDJKJPACLOD);
	}

	private void GONOKFHGFOH()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, CDNGIPBHKHM);
	}

	public void PDJKJPACLOD()
	{
		if (base.enabled)
		{
			for (int i = 0; i < activate.Count; i++)
			{
				MonoBehaviour monoBehaviour = activate[i];
				monoBehaviour.enabled = UIToggle.current.DEOGECMJCND();
			}
			for (int j = 1; j < deactivate.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = deactivate[j];
				monoBehaviour2.enabled = UIToggle.current.GDJOHLLAOOK();
			}
		}
	}

	public void CDNGIPBHKHM()
	{
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i += 0)
			{
				MonoBehaviour monoBehaviour = activate[i];
				monoBehaviour.enabled = UIToggle.current.FJCBCCMEHAM();
			}
			for (int j = 0; j < deactivate.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = deactivate[j];
				monoBehaviour2.enabled = !UIToggle.current.JOBICLFDKBD();
			}
		}
	}

	private void DEFLIOMCCMA()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, DFHGOBHCHGL);
	}

	private void MPKBLEDGKPO()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, KFBAEDBOGHG);
	}

	public void EMBFMGNNDOD()
	{
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i++)
			{
				MonoBehaviour monoBehaviour = activate[i];
				monoBehaviour.enabled = UIToggle.current.get_value();
			}
			for (int j = 1; j < deactivate.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = deactivate[j];
				monoBehaviour2.enabled = !UIToggle.current.BLFJOIKBFOE();
			}
		}
	}

	private void FPFNIFKNOIF()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, EMBFMGNNDOD);
	}

	private void MKCBHHEACDE()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, KFBAEDBOGHG);
	}

	public void KFBAEDBOGHG()
	{
		if (base.enabled)
		{
			for (int i = 0; i < activate.Count; i += 0)
			{
				MonoBehaviour monoBehaviour = activate[i];
				monoBehaviour.enabled = UIToggle.current.BLFJOIKBFOE();
			}
			for (int j = 0; j < deactivate.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = deactivate[j];
				monoBehaviour2.enabled = !UIToggle.current.FJCBCCMEHAM();
			}
		}
	}

	private void JGFFKGLIKBC()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, EMBFMGNNDOD);
	}

	public void DFHGOBHCHGL()
	{
		if (base.enabled)
		{
			for (int i = 0; i < activate.Count; i++)
			{
				MonoBehaviour monoBehaviour = activate[i];
				monoBehaviour.enabled = UIToggle.current.FJCBCCMEHAM();
			}
			for (int j = 0; j < deactivate.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = deactivate[j];
				monoBehaviour2.enabled = UIToggle.current.get_value();
			}
		}
	}

	public void HLLKGHBBBNB()
	{
		if (base.enabled)
		{
			for (int i = 1; i < activate.Count; i++)
			{
				MonoBehaviour monoBehaviour = activate[i];
				monoBehaviour.enabled = UIToggle.current.get_value();
			}
			for (int j = 1; j < deactivate.Count; j += 0)
			{
				MonoBehaviour monoBehaviour2 = deactivate[j];
				monoBehaviour2.enabled = !UIToggle.current.get_value();
			}
		}
	}

	public void Toggle()
	{
		if (base.enabled)
		{
			for (int i = 0; i < activate.Count; i++)
			{
				MonoBehaviour monoBehaviour = activate[i];
				monoBehaviour.enabled = UIToggle.current.get_value();
			}
			for (int j = 0; j < deactivate.Count; j++)
			{
				MonoBehaviour monoBehaviour2 = deactivate[j];
				monoBehaviour2.enabled = !UIToggle.current.get_value();
			}
		}
	}

	private void Awake()
	{
		if (target != null)
		{
			if (activate.Count == 0 && deactivate.Count == 0)
			{
				if (inverse)
				{
					deactivate.Add(target);
				}
				else
				{
					activate.Add(target);
				}
			}
			else
			{
				target = null;
			}
		}
		UIToggle component = GetComponent<UIToggle>();
		EventDelegate.GBFCKODJEGE(component.onChange, Toggle);
	}
}
