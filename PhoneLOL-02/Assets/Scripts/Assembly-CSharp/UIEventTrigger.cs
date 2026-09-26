using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Event Trigger")]
public class UIEventTrigger : MonoBehaviour
{
	public static UIEventTrigger current;

	public List<EventDelegate> onHoverOver = new List<EventDelegate>();

	public List<EventDelegate> onHoverOut = new List<EventDelegate>();

	public List<EventDelegate> onPress = new List<EventDelegate>();

	public List<EventDelegate> onRelease = new List<EventDelegate>();

	public List<EventDelegate> onSelect = new List<EventDelegate>();

	public List<EventDelegate> onDeselect = new List<EventDelegate>();

	public List<EventDelegate> onClick = new List<EventDelegate>();

	public List<EventDelegate> onDoubleClick = new List<EventDelegate>();

	public List<EventDelegate> onDragOver = new List<EventDelegate>();

	public List<EventDelegate> onDragOut = new List<EventDelegate>();

	private void APFDMHKADPJ(GameObject LHACFNECMNA)
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDragOver);
			current = null;
		}
	}

	private void LGDMGDAMNFA()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDoubleClick);
			current = null;
		}
	}

	private void AHCJKIBBNOP(GameObject LHACFNECMNA)
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDragOver);
			current = null;
		}
	}

	private void HJHLOFDNIOL(bool MLIBCICOOAI)
	{
		if (!(current != null))
		{
			current = this;
			if (MLIBCICOOAI)
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOver);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOut);
			}
			current = null;
		}
	}

	private void BAFBJKPOMJM(GameObject LHACFNECMNA)
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDragOut);
			current = null;
		}
	}

	private void PIGLGFDCADE(bool JBHJFOLKOCP)
	{
		if (!(current != null))
		{
			current = this;
			if (JBHJFOLKOCP)
			{
				EventDelegate.MKPMEAMPDLJ(onSelect);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onDeselect);
			}
			current = null;
		}
	}

	private void HDOPLMKBFEA(GameObject LHACFNECMNA)
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDragOut);
			current = null;
		}
	}

	private void MAIPLAJNNAB(bool NLGJIEONPNP)
	{
		if (!(current != null))
		{
			current = this;
			if (NLGJIEONPNP)
			{
				EventDelegate.MKPMEAMPDLJ(onPress);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onRelease);
			}
			current = null;
		}
	}

	private void GCFJNKDCKFO(GameObject LHACFNECMNA)
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDragOut);
			current = null;
		}
	}

	private void BNBGBACFPGA(bool JBHJFOLKOCP)
	{
		if (!(current != null))
		{
			current = this;
			if (JBHJFOLKOCP)
			{
				EventDelegate.MKPMEAMPDLJ(onSelect);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onDeselect);
			}
			current = null;
		}
	}

	private void LEPAIBNHACL()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDoubleClick);
			current = null;
		}
	}

	private void LJAIHEEJBID(GameObject LHACFNECMNA)
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDragOver);
			current = null;
		}
	}

	private void BODIEEFFCME(bool MLIBCICOOAI)
	{
		if (!(current != null))
		{
			current = this;
			if (MLIBCICOOAI)
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOver);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOut);
			}
			current = null;
		}
	}

	private void GPEIOKHGGDL()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDoubleClick);
			current = null;
		}
	}

	private void OnClick()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onClick);
			current = null;
		}
	}

	private void KCBLKLMPNII()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onClick);
			current = null;
		}
	}

	private void KFBDMBELNIH(bool NLGJIEONPNP)
	{
		if (!(current != null))
		{
			current = this;
			if (NLGJIEONPNP)
			{
				EventDelegate.MKPMEAMPDLJ(onPress);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onRelease);
			}
			current = null;
		}
	}

	private void LOBKLJFONLJ()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onClick);
			current = null;
		}
	}

	private void NOACAIINNGJ()
	{
		if (!(current != null))
		{
			current = this;
			EventDelegate.MKPMEAMPDLJ(onDoubleClick);
			current = null;
		}
	}

	private void JADBJGCMIMF(bool JBHJFOLKOCP)
	{
		if (!(current != null))
		{
			current = this;
			if (JBHJFOLKOCP)
			{
				EventDelegate.MKPMEAMPDLJ(onSelect);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onDeselect);
			}
			current = null;
		}
	}

	private void NDNBPKKAKDJ(bool NLGJIEONPNP)
	{
		if (!(current != null))
		{
			current = this;
			if (NLGJIEONPNP)
			{
				EventDelegate.MKPMEAMPDLJ(onPress);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onRelease);
			}
			current = null;
		}
	}

	private void FGECOIGPMOK(bool NLGJIEONPNP)
	{
		if (!(current != null))
		{
			current = this;
			if (NLGJIEONPNP)
			{
				EventDelegate.MKPMEAMPDLJ(onPress);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onRelease);
			}
			current = null;
		}
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (!(current != null))
		{
			current = this;
			if (MLIBCICOOAI)
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOver);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOut);
			}
			current = null;
		}
	}

	private void BAHAPLJBLEH(bool MLIBCICOOAI)
	{
		if (!(current != null))
		{
			current = this;
			if (MLIBCICOOAI)
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOver);
			}
			else
			{
				EventDelegate.MKPMEAMPDLJ(onHoverOut);
			}
			current = null;
		}
	}
}
