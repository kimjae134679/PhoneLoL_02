using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Internal/Property Binding")]
public class PropertyBinding : MonoBehaviour
{
	public enum MPIMEFCGGGD
	{
		OnStart = 0,
		OnUpdate = 1,
		OnLateUpdate = 2,
		OnFixedUpdate = 3
	}

	public enum EHIFBHANFAJ
	{
		SourceUpdatesTarget = 0,
		TargetUpdatesSource = 1,
		BiDirectional = 2
	}

	public PropertyReference source;

	public PropertyReference target;

	public EHIFBHANFAJ direction;

	public MPIMEFCGGGD update = MPIMEFCGGGD.OnUpdate;

	public bool editMode = true;

	private object NIAJOLPMDEN;

	public void EAJPBHMKFHI()
	{
		if (source == null || target == null || !source.isValid || !target.isValid)
		{
			return;
		}
		if (direction == EHIFBHANFAJ.SourceUpdatesTarget)
		{
			target.LIJBCDKPJPP(source.OHKHGNFHJJM());
		}
		else if (direction == EHIFBHANFAJ.TargetUpdatesSource)
		{
			source.LIJBCDKPJPP(target.DJJEIDBHHBE());
		}
		else
		{
			if (source.JMPGGJHEBPO() != target.JMPGGJHEBPO())
			{
				return;
			}
			object obj = source.OHKHGNFHJJM();
			if (NIAJOLPMDEN == null || !NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				target.LIJBCDKPJPP(obj);
				return;
			}
			obj = target.DJJEIDBHHBE();
			if (!NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				source.LIJBCDKPJPP(obj);
			}
		}
	}

	private void JBIMMOMICGD()
	{
		if (update == (MPIMEFCGGGD)7)
		{
			EAJPBHMKFHI();
		}
	}

	public void JBJCPCDMBLI()
	{
		if (source == null || target == null || !source.OKLBHCKJLFC() || !target.isValid)
		{
			return;
		}
		if (direction == EHIFBHANFAJ.SourceUpdatesTarget)
		{
			target.LIJBCDKPJPP(source.DJJEIDBHHBE());
		}
		else if (direction == EHIFBHANFAJ.SourceUpdatesTarget)
		{
			source.LIJBCDKPJPP(target.DJJEIDBHHBE());
		}
		else
		{
			if (source.JMPGGJHEBPO() != target.JMPGGJHEBPO())
			{
				return;
			}
			object obj = source.OHKHGNFHJJM();
			if (NIAJOLPMDEN == null || !NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				target.LIJBCDKPJPP(obj);
				return;
			}
			obj = target.OHKHGNFHJJM();
			if (!NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				source.LIJBCDKPJPP(obj);
			}
		}
	}

	private void CCFKJLBFCDE()
	{
		if (update == MPIMEFCGGGD.OnFixedUpdate)
		{
			GLPHDDMJIBI();
		}
	}

	private void BNFDGGBLLLI()
	{
		if (update == (MPIMEFCGGGD)6)
		{
			UpdateTarget();
		}
	}

	private void FOGNMJLPHAI()
	{
		UpdateTarget();
		if (update == MPIMEFCGGGD.OnStart)
		{
			base.enabled = true;
		}
	}

	private void FMNOLGPIIFB()
	{
		JBJCPCDMBLI();
		if (update == MPIMEFCGGGD.OnStart)
		{
			base.enabled = true;
		}
	}

	public void GLPHDDMJIBI()
	{
		if (source == null || target == null || !source.OKLBHCKJLFC() || !target.OKLBHCKJLFC())
		{
			return;
		}
		if (direction == EHIFBHANFAJ.SourceUpdatesTarget)
		{
			target.LIJBCDKPJPP(source.OHKHGNFHJJM());
		}
		else if (direction == EHIFBHANFAJ.TargetUpdatesSource)
		{
			source.LIJBCDKPJPP(target.FGADPFDOEHM());
		}
		else
		{
			if (source.JMPGGJHEBPO() != target.JMPGGJHEBPO())
			{
				return;
			}
			object obj = source.DJJEIDBHHBE();
			if (NIAJOLPMDEN == null || !NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				target.LIJBCDKPJPP(obj);
				return;
			}
			obj = target.OHKHGNFHJJM();
			if (!NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				source.LIJBCDKPJPP(obj);
			}
		}
	}

	private void Start()
	{
		UpdateTarget();
		if (update == MPIMEFCGGGD.OnStart)
		{
			base.enabled = false;
		}
	}

	public void GPBJFOKFMMO()
	{
		if (source == null || target == null || !source.OKLBHCKJLFC() || !target.isValid)
		{
			return;
		}
		if (direction == EHIFBHANFAJ.SourceUpdatesTarget)
		{
			target.LIJBCDKPJPP(source.OHKHGNFHJJM());
		}
		else if (direction == EHIFBHANFAJ.SourceUpdatesTarget)
		{
			source.LIJBCDKPJPP(target.DJJEIDBHHBE());
		}
		else
		{
			if (source.JMPGGJHEBPO() != target.JMPGGJHEBPO())
			{
				return;
			}
			object obj = source.OHKHGNFHJJM();
			if (NIAJOLPMDEN == null || !NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				target.LIJBCDKPJPP(obj);
				return;
			}
			obj = target.DJJEIDBHHBE();
			if (!NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				source.LIJBCDKPJPP(obj);
			}
		}
	}

	private void FixedUpdate()
	{
		if (update == MPIMEFCGGGD.OnFixedUpdate)
		{
			UpdateTarget();
		}
	}

	private void LateUpdate()
	{
		if (update == MPIMEFCGGGD.OnLateUpdate)
		{
			UpdateTarget();
		}
	}

	[ContextMenu("Update Now")]
	public void UpdateTarget()
	{
		if (source == null || target == null || !source.isValid || !target.isValid)
		{
			return;
		}
		if (direction == EHIFBHANFAJ.SourceUpdatesTarget)
		{
			target.LIJBCDKPJPP(source.OHKHGNFHJJM());
		}
		else if (direction == EHIFBHANFAJ.TargetUpdatesSource)
		{
			source.LIJBCDKPJPP(target.OHKHGNFHJJM());
		}
		else
		{
			if (source.JMPGGJHEBPO() != target.JMPGGJHEBPO())
			{
				return;
			}
			object obj = source.OHKHGNFHJJM();
			if (NIAJOLPMDEN == null || !NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				target.LIJBCDKPJPP(obj);
				return;
			}
			obj = target.OHKHGNFHJJM();
			if (!NIAJOLPMDEN.Equals(obj))
			{
				NIAJOLPMDEN = obj;
				source.LIJBCDKPJPP(obj);
			}
		}
	}

	private void NDHECLNJGOK()
	{
		if (update == MPIMEFCGGGD.OnFixedUpdate)
		{
			GPBJFOKFMMO();
		}
	}

	private void NBBIJJOPGPE()
	{
		if (update == MPIMEFCGGGD.OnLateUpdate)
		{
			UpdateTarget();
		}
	}

	private void GDKGBNKCGHO()
	{
		if (update == MPIMEFCGGGD.OnUpdate)
		{
			EAJPBHMKFHI();
		}
	}

	private void DGIKBFFMIJM()
	{
		if (update == MPIMEFCGGGD.OnLateUpdate)
		{
			GLPHDDMJIBI();
		}
	}

	private void MBOGEOOGAOL()
	{
		if (update == MPIMEFCGGGD.OnStart)
		{
			GLPHDDMJIBI();
		}
	}

	private void OnValidate()
	{
		if (source != null)
		{
			source.MBFBGLJMLMI();
		}
		if (target != null)
		{
			target.MBFBGLJMLMI();
		}
	}

	private void PDFGMNJMCOL()
	{
		if (update == (MPIMEFCGGGD)5)
		{
			GLPHDDMJIBI();
		}
	}

	private void Update()
	{
		if (update == MPIMEFCGGGD.OnUpdate)
		{
			UpdateTarget();
		}
	}
}
