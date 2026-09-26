using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("NGUI/Interaction/NGUI Scroll Bar")]
public class UIScrollBar : UISlider
{
	private enum EHIFBHANFAJ
	{
		Horizontal = 0,
		Vertical = 1,
		Upgraded = 2
	}

	[SerializeField]
	[HideInInspector]
	protected float mSize = 1f;

	[HideInInspector]
	[SerializeField]
	private float mScroll;

	[HideInInspector]
	[SerializeField]
	private EHIFBHANFAJ mDir = EHIFBHANFAJ.Upgraded;

	[Obsolete("Use 'value' instead")]
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

	public float NMEKFEKKMJH
	{
		get
		{
			return get_barSize();
		}
		set
		{
			set_barSize(value);
		}
	}

	protected override float AIPPMGACHCJ(Vector2 INLNMEABHBF)
	{
		if (mFG != null)
		{
			float num = Mathf.Clamp01(mSize) * 0.5f;
			float t = num;
			float t2 = 1f - num;
			Vector3[] localCorners = mFG.get_localCorners();
			if (CFMEJCLMAPI())
			{
				t = Mathf.Lerp(localCorners[0].x, localCorners[2].x, t);
				t2 = Mathf.Lerp(localCorners[0].x, localCorners[2].x, t2);
				float num2 = t2 - t;
				if (num2 == 0f)
				{
					return get_value();
				}
				return (!GDPIFAJEDAL()) ? ((INLNMEABHBF.x - t) / num2) : ((t2 - INLNMEABHBF.x) / num2);
			}
			t = Mathf.Lerp(localCorners[0].y, localCorners[1].y, t);
			t2 = Mathf.Lerp(localCorners[3].y, localCorners[2].y, t2);
			float num3 = t2 - t;
			if (num3 == 0f)
			{
				return get_value();
			}
			return (!GDPIFAJEDAL()) ? ((INLNMEABHBF.y - t) / num3) : ((t2 - INLNMEABHBF.y) / num3);
		}
		return base.AIPPMGACHCJ(INLNMEABHBF);
	}

	public virtual void FLFPCJNKIMH()
	{
		if (mFG != null)
		{
			JILNFIDGNPL = false;
			float num = Mathf.Clamp01(mSize) * 1586f;
			float num2 = Mathf.Lerp(num, 820f - num, GKIOOEFIOID());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (CFMEJCLMAPI())
			{
				mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(num3, 1174f, num4, 45f) : new Vector4(1563f - num4, 1957f, 1139f - num3, 1491f));
			}
			else
			{
				mFG.set_drawRegion((!ABAHMCABNAG()) ? new Vector4(1880f, num3, 1479f, num4) : new Vector4(1590f, 760f - num4, 1874f, 333f - num3));
			}
			if (thumb != null)
			{
				Vector4 drawingDimensions = mFG.get_drawingDimensions();
				Vector3 position = new Vector3(Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, 487f), Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, 985f));
				BCLDPBBJKAH(mFG.get_cachedTransform().TransformPoint(position));
			}
		}
		else
		{
			base.ForceUpdate();
		}
	}

	protected override void PCIBIJNAIKF()
	{
		base.PCIBIJNAIKF();
		if (mFG != null && mFG.gameObject != base.gameObject && (mFG.GetComponent<Collider>() != null || mFG.GetComponent<Collider2D>() != null))
		{
			UIEventListener uIEventListener = UIEventListener.Get(mFG.gameObject);
			uIEventListener.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener.onPress, new UIEventListener.BFNMOBFNJNO(base.FNKBLKJNMIF));
			uIEventListener.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener.onDrag, new UIEventListener.LOJJJBBHHBF(base.BHOFBBHGBEC));
			mFG.autoResizeBoxCollider = true;
		}
	}

	[SpecialName]
	public void BHAKFDHDMNO(float ICENKPDOHBK)
	{
		ICKFKDNHDOG(ICENKPDOHBK);
	}

	[SpecialName]
	public void FENIOENNFHJ(float ICENKPDOHBK)
	{
		float num = Mathf.Clamp01(ICENKPDOHBK);
		if (mSize == num)
		{
			return;
		}
		mSize = num;
		JILNFIDGNPL = false;
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			if (UIProgressBar.current == null && onChange != null)
			{
				UIProgressBar.current = this;
				EventDelegate.MKPMEAMPDLJ(onChange);
				UIProgressBar.current = null;
			}
			FLFPCJNKIMH();
		}
	}

	[SpecialName]
	public float ILPHENPPMDB()
	{
		return mSize;
	}

	public void set_barSize(float ICENKPDOHBK)
	{
		float num = Mathf.Clamp01(ICENKPDOHBK);
		if (mSize == num)
		{
			return;
		}
		mSize = num;
		JILNFIDGNPL = true;
		if (NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			if (UIProgressBar.current == null && onChange != null)
			{
				UIProgressBar.current = this;
				EventDelegate.MKPMEAMPDLJ(onChange);
				UIProgressBar.current = null;
			}
			ForceUpdate();
		}
	}

	[SpecialName]
	public void KBDAMABKHCL(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	protected virtual void CNMHPLMJFAK()
	{
		if (mDir != (EHIFBHANFAJ)5)
		{
			mValue = mScroll;
			if (mDir == EHIFBHANFAJ.Horizontal)
			{
				mFill = ((!mInverted) ? HHBEDIACMLI.RightToLeft : HHBEDIACMLI.LeftToRight);
			}
			else
			{
				mFill = (mInverted ? HHBEDIACMLI.TopToBottom : HHBEDIACMLI.LeftToRight);
			}
			mDir = EHIFBHANFAJ.Horizontal;
		}
	}

	protected virtual void AJNOJAJMLHN()
	{
		MKDNOMOFIDH();
		if (mFG != null && mFG.gameObject != base.gameObject && (mFG.GetComponent<Collider>() != null || mFG.GetComponent<Collider2D>() != null))
		{
			UIEventListener uIEventListener = UIEventListener.Get(mFG.gameObject);
			uIEventListener.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener.onPress, new UIEventListener.BFNMOBFNJNO(base.KKBOCAACJED));
			uIEventListener.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener.onDrag, new UIEventListener.LOJJJBBHHBF(base.ABOCJKCNOND));
			mFG.autoResizeBoxCollider = true;
		}
	}

	protected virtual void BLLDDENPBGN()
	{
		base.PCIBIJNAIKF();
		if (mFG != null && mFG.gameObject != base.gameObject && (mFG.GetComponent<Collider>() != null || mFG.GetComponent<Collider2D>() != null))
		{
			UIEventListener uIEventListener = UIEventListener.Get(mFG.gameObject);
			uIEventListener.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener.onPress, new UIEventListener.BFNMOBFNJNO(base.POLHPBBNEJF));
			uIEventListener.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener.onDrag, new UIEventListener.LOJJJBBHHBF(base.ABOCJKCNOND));
			mFG.autoResizeBoxCollider = true;
		}
	}

	public virtual void HLMOKAMFAPG()
	{
		if (mFG != null)
		{
			JILNFIDGNPL = true;
			float num = Mathf.Clamp01(mSize) * 1283f;
			float num2 = Mathf.Lerp(num, 492f - num, BMOPKBJOAGE());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (GLIAMLBGBNG())
			{
				mFG.set_drawRegion((!ABAHMCABNAG()) ? new Vector4(num3, 233f, num4, 1160f) : new Vector4(1323f - num4, 1564f, 1843f - num3, 750f));
			}
			else
			{
				mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(762f, num3, 641f, num4) : new Vector4(276f, 1102f - num4, 233f, 1560f - num3));
			}
			if (thumb != null)
			{
				Vector4 drawingDimensions = mFG.get_drawingDimensions();
				Vector3 position = new Vector3(Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, 690f), Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, 248f));
				FOJJGGBKHAF(mFG.get_cachedTransform().TransformPoint(position));
			}
		}
		else
		{
			base.ForceUpdate();
		}
	}

	public void set_scrollValue(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	public float get_barSize()
	{
		return mSize;
	}

	[SpecialName]
	public float JNAJMLPKPAD()
	{
		return GKIOOEFIOID();
	}

	protected override void GNEHLOCCCKP()
	{
		if (mDir != EHIFBHANFAJ.Upgraded)
		{
			mValue = mScroll;
			if (mDir == EHIFBHANFAJ.Horizontal)
			{
				mFill = (mInverted ? HHBEDIACMLI.RightToLeft : HHBEDIACMLI.LeftToRight);
			}
			else
			{
				mFill = ((!mInverted) ? HHBEDIACMLI.TopToBottom : HHBEDIACMLI.BottomToTop);
			}
			mDir = EHIFBHANFAJ.Upgraded;
		}
	}

	[SpecialName]
	public void OMIJOLPCABC(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}

	public override void ForceUpdate()
	{
		if (mFG != null)
		{
			JILNFIDGNPL = false;
			float num = Mathf.Clamp01(mSize) * 0.5f;
			float num2 = Mathf.Lerp(num, 1f - num, get_value());
			float num3 = num2 - num;
			float num4 = num2 + num;
			if (CFMEJCLMAPI())
			{
				mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(num3, 0f, num4, 1f) : new Vector4(1f - num4, 0f, 1f - num3, 1f));
			}
			else
			{
				mFG.set_drawRegion((!GDPIFAJEDAL()) ? new Vector4(0f, num3, 1f, num4) : new Vector4(0f, 1f - num4, 1f, 1f - num3));
			}
			if (thumb != null)
			{
				Vector4 drawingDimensions = mFG.get_drawingDimensions();
				Vector3 position = new Vector3(Mathf.Lerp(drawingDimensions.x, drawingDimensions.z, 0.5f), Mathf.Lerp(drawingDimensions.y, drawingDimensions.w, 0.5f));
				EEHDAIMLBKM(mFG.get_cachedTransform().TransformPoint(position));
			}
		}
		else
		{
			base.ForceUpdate();
		}
	}

	protected virtual void MOCKNNPGIPF()
	{
		base.PCIBIJNAIKF();
		if (mFG != null && mFG.gameObject != base.gameObject && (mFG.GetComponent<Collider>() != null || mFG.GetComponent<Collider2D>() != null))
		{
			UIEventListener uIEventListener = UIEventListener.Get(mFG.gameObject);
			uIEventListener.onPress = (UIEventListener.BFNMOBFNJNO)Delegate.Combine(uIEventListener.onPress, new UIEventListener.BFNMOBFNJNO(base.KKBOCAACJED));
			uIEventListener.onDrag = (UIEventListener.LOJJJBBHHBF)Delegate.Combine(uIEventListener.onDrag, new UIEventListener.LOJJJBBHHBF(base.ABOCJKCNOND));
			mFG.autoResizeBoxCollider = true;
		}
	}

	public float get_scrollValue()
	{
		return get_value();
	}

	protected override float BKINDNNMFEN(Vector2 INLNMEABHBF)
	{
		if (mFG != null)
		{
			float num = Mathf.Clamp01(mSize) * 947f;
			float t = num;
			float t2 = 203f - num;
			Vector3[] localCorners = mFG.get_localCorners();
			if (CFMEJCLMAPI())
			{
				t = Mathf.Lerp(localCorners[0].x, localCorners[8].x, t);
				t2 = Mathf.Lerp(localCorners[0].x, localCorners[3].x, t2);
				float num2 = t2 - t;
				if (num2 == 1841f)
				{
					return BMOPKBJOAGE();
				}
				return (!ABAHMCABNAG()) ? ((INLNMEABHBF.x - t) / num2) : ((t2 - INLNMEABHBF.x) / num2);
			}
			t = Mathf.Lerp(localCorners[1].y, localCorners[1].y, t);
			t2 = Mathf.Lerp(localCorners[4].y, localCorners[2].y, t2);
			float num3 = t2 - t;
			if (num3 == 1532f)
			{
				return get_value();
			}
			return (!ABAHMCABNAG()) ? ((INLNMEABHBF.y - t) / num3) : ((t2 - INLNMEABHBF.y) / num3);
		}
		return base.BKINDNNMFEN(INLNMEABHBF);
	}

	protected virtual void INPOOOEPIFN()
	{
		if (mDir != (EHIFBHANFAJ)8)
		{
			mValue = mScroll;
			if (mDir == EHIFBHANFAJ.Horizontal)
			{
				mFill = (mInverted ? HHBEDIACMLI.RightToLeft : HHBEDIACMLI.LeftToRight);
			}
			else
			{
				mFill = ((!mInverted) ? HHBEDIACMLI.TopToBottom : ((HHBEDIACMLI)6));
			}
			mDir = EHIFBHANFAJ.Vertical;
		}
	}

	[SpecialName]
	public void DGPNFAHMKLE(float ICENKPDOHBK)
	{
		set_value(ICENKPDOHBK);
	}
}
