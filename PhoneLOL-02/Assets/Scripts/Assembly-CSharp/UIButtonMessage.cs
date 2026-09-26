using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Button Message (Legacy)")]
public class UIButtonMessage : MonoBehaviour
{
	public enum FMPOPHBALHP
	{
		OnClick = 0,
		OnMouseOver = 1,
		OnMouseOut = 2,
		OnPress = 3,
		OnRelease = 4,
		OnDoubleClick = 5
	}

	public GameObject target;

	public string functionName;

	public FMPOPHBALHP trigger;

	public bool includeChildren;

	private bool BAMIBNMGNBO;

	private void KDKPLLCABOC(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Touch))
		{
			OCMBHJHBEBG(IOGFFPOIBBB);
		}
	}

	private void EBHEKALFNGF()
	{
		if (BAMIBNMGNBO)
		{
			KMPOCJKOAHJ(UICamera.DMOOCIJDAIK(base.gameObject));
		}
	}

	private void LOBKLJFONLJ()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			FBAFKOCPFPG();
		}
	}

	private void MADCDCNEGBO()
	{
		if (BAMIBNMGNBO)
		{
			PBDCBOEHJLH(UICamera.IsHighlighted(base.gameObject));
		}
	}

	private void JIDEBIPNAOA(bool MLIBCICOOAI)
	{
		if (base.enabled && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == FMPOPHBALHP.OnDoubleClick)))
		{
			FBAFKOCPFPG();
		}
	}

	private void OJMBNBMBAMK(bool MLIBCICOOAI)
	{
		if (base.enabled && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnClick) || (!MLIBCICOOAI && trigger == (FMPOPHBALHP)8)))
		{
			FBAFKOCPFPG();
		}
	}

	private void CLLECEEEJAI()
	{
		BAMIBNMGNBO = true;
	}

	private void DGHCKMGOOGK(bool MLIBCICOOAI)
	{
		if (base.enabled && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOut)))
		{
			FBAFKOCPFPG();
		}
	}

	private void GPEIOKHGGDL()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnDoubleClick)
		{
			FBAFKOCPFPG();
		}
	}

	private void EIHPKMOAONI()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnDoubleClick)
		{
			FBAFKOCPFPG();
		}
	}

	private void HJHLOFDNIOL(bool MLIBCICOOAI)
	{
		if (base.enabled && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == (FMPOPHBALHP)8)))
		{
			FBAFKOCPFPG();
		}
	}

	private void OnEnable()
	{
		if (BAMIBNMGNBO)
		{
			DGHCKMGOOGK(UICamera.IsHighlighted(base.gameObject));
		}
	}

	private void Start()
	{
		BAMIBNMGNBO = true;
	}

	private void CKPEBBDKICD()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			FBAFKOCPFPG();
		}
	}

	private void OnClick()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			FBAFKOCPFPG();
		}
	}

	private void KCBLKLMPNII()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			FBAFKOCPFPG();
		}
	}

	private void OCMBHJHBEBG(bool MLIBCICOOAI)
	{
		if (base.enabled && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == FMPOPHBALHP.OnClick)))
		{
			FBAFKOCPFPG();
		}
	}

	private void JADBJGCMIMF(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == UICamera.DOCFHOGBBJH.Controller))
		{
			DGHCKMGOOGK(IOGFFPOIBBB);
		}
	}

	private void KDHBGEDFGDJ(bool JPNFGIEDOMM)
	{
		if (base.enabled && ((JPNFGIEDOMM && trigger == FMPOPHBALHP.OnDoubleClick) || (!JPNFGIEDOMM && trigger == FMPOPHBALHP.OnDoubleClick)))
		{
			FBAFKOCPFPG();
		}
	}

	private void ANNDIHGOEEL()
	{
		if (BAMIBNMGNBO)
		{
			OCMBHJHBEBG(UICamera.DMOOCIJDAIK(base.gameObject));
		}
	}

	private void NGBIIKMJLGF()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnMouseOver)
		{
			FBAFKOCPFPG();
		}
	}

	private void KMPOCJKOAHJ(bool MLIBCICOOAI)
	{
		if (base.enabled && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver) || (!MLIBCICOOAI && trigger == FMPOPHBALHP.OnClick)))
		{
			FBAFKOCPFPG();
		}
	}

	private void LJNHGILPEDC()
	{
		if (base.enabled && trigger == FMPOPHBALHP.OnClick)
		{
			FBAFKOCPFPG();
		}
	}

	private void NAIJEKINENM(bool JPNFGIEDOMM)
	{
		if (base.enabled && ((JPNFGIEDOMM && trigger == (FMPOPHBALHP)6) || (!JPNFGIEDOMM && trigger == FMPOPHBALHP.OnRelease)))
		{
			FBAFKOCPFPG();
		}
	}

	private void FBAFKOCPFPG()
	{
		if (string.IsNullOrEmpty(functionName))
		{
			return;
		}
		if (target == null)
		{
			target = base.gameObject;
		}
		if (includeChildren)
		{
			Transform[] componentsInChildren = target.GetComponentsInChildren<Transform>();
			int i = 0;
			for (int num = componentsInChildren.Length; i < num; i++)
			{
				Transform transform = componentsInChildren[i];
				transform.gameObject.SendMessage(functionName, base.gameObject, SendMessageOptions.DontRequireReceiver);
			}
		}
		else
		{
			target.SendMessage(functionName, base.gameObject, SendMessageOptions.DontRequireReceiver);
		}
	}

	private void PIGLGFDCADE(bool IOGFFPOIBBB)
	{
		if (base.enabled && (!IOGFFPOIBBB || UICamera.currentScheme == (UICamera.DOCFHOGBBJH)8))
		{
			JIDEBIPNAOA(IOGFFPOIBBB);
		}
	}

	private void NDNBPKKAKDJ(bool JPNFGIEDOMM)
	{
		if (base.enabled && ((JPNFGIEDOMM && trigger == FMPOPHBALHP.OnPress) || (!JPNFGIEDOMM && trigger == FMPOPHBALHP.OnRelease)))
		{
			FBAFKOCPFPG();
		}
	}

	private void PBDCBOEHJLH(bool MLIBCICOOAI)
	{
		if (base.enabled && ((MLIBCICOOAI && trigger == FMPOPHBALHP.OnClick) || (!MLIBCICOOAI && trigger == FMPOPHBALHP.OnMouseOver)))
		{
			FBAFKOCPFPG();
		}
	}
}
