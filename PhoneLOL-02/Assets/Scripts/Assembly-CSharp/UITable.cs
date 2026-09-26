using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Table")]
public class UITable : UIWidgetContainer
{
	public enum EHIFBHANFAJ
	{
		Down = 0,
		Up = 1
	}

	public enum GLABNIJAMHJ
	{
		None = 0,
		Alphabetic = 1,
		Horizontal = 2,
		Vertical = 3,
		Custom = 4
	}

	public delegate void HKFCAGAJEJB();

	public int columns;

	public EHIFBHANFAJ direction;

	public GLABNIJAMHJ sorting;

	public bool hideInactive = true;

	public bool keepWithinPanel;

	public Vector2 padding = Vector2.zero;

	public HKFCAGAJEJB onReposition;

	protected UIPanel MPFGEBCBFFM;

	protected bool MCLOOFPOPDL;

	protected bool GAONAJHCCOB;

	protected List<Transform> JOECNDFCLJD = new List<Transform>();

	[HideInInspector]
	[SerializeField]
	private bool sorted;

	public bool CBNMINALFNC
	{
		set
		{
			set_repositionNow(value);
		}
	}

	public List<Transform> IGNIJPKKLNB
	{
		get
		{
			return get_children();
		}
	}

	protected virtual void GLHGKGENGCC()
	{
		if (GAONAJHCCOB)
		{
			Reposition();
		}
		base.enabled = true;
	}

	[SpecialName]
	public void OIDEKMGEOBP(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = false;
			base.enabled = false;
		}
	}

	protected virtual void IMBGDEFOFEM()
	{
		BCGICPOKOHO();
		KLBMIKBBMMC();
		base.enabled = false;
	}

	public virtual void KLBMIKBBMMC()
	{
		if (Application.isPlaying && !MCLOOFPOPDL && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GAONAJHCCOB = false;
			return;
		}
		if (!MCLOOFPOPDL)
		{
			BCGICPOKOHO();
		}
		GAONAJHCCOB = true;
		Transform lPOAEBNAGCP = base.transform;
		JOECNDFCLJD.Clear();
		List<Transform> list = OJMJDNDHLLN();
		if (list.Count > 1)
		{
			GBHCJPCHOCB(list);
		}
		if (keepWithinPanel && MPFGEBCBFFM != null)
		{
			MPFGEBCBFFM.ConstrainTargetToBounds(lPOAEBNAGCP, true);
			UIScrollView component = MPFGEBCBFFM.GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdateScrollbars(false);
			}
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}

	protected void EAKDPMKEFNI(List<Transform> IGNIJPKKLNB)
	{
		float num = 0f;
		float num2 = 0f;
		int num3 = ((columns <= 0) ? 1 : (IGNIJPKKLNB.Count / columns + 1));
		int num4 = ((columns <= 0) ? IGNIJPKKLNB.Count : columns);
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 0;
		int num6 = 0;
		int i = 0;
		for (int count = IGNIJPKKLNB.Count; i < count; i++)
		{
			Transform transform = IGNIJPKKLNB[i];
			Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(transform, !hideInactive);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if (++num5 >= columns && columns > 0)
			{
				num5 = 0;
				num6++;
			}
		}
		num5 = 0;
		num6 = 0;
		int j = 0;
		for (int count2 = IGNIJPKKLNB.Count; j < count2; j++)
		{
			Transform transform2 = IGNIJPKKLNB[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x += bounds2.min.x - bounds3.min.x + padding.x;
			if (direction == EHIFBHANFAJ.Down)
			{
				localPosition.y = 0f - num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += (bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y) * 0.5f - padding.y;
			}
			else
			{
				localPosition.y = num2 + (bounds2.extents.y - bounds2.center.y);
				localPosition.y -= (bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y) * 0.5f - padding.y;
			}
			num += bounds3.max.x - bounds3.min.x + padding.x * 2f;
			transform2.localPosition = localPosition;
			if (++num5 >= columns && columns > 0)
			{
				num5 = 0;
				num6++;
				num = 0f;
				num2 += bounds4.size.y + padding.y * 2f;
			}
		}
	}

	public virtual void PCACHDDNHMI()
	{
		if (Application.isPlaying && !MCLOOFPOPDL && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GAONAJHCCOB = false;
			return;
		}
		if (!MCLOOFPOPDL)
		{
			BCGICPOKOHO();
		}
		GAONAJHCCOB = false;
		Transform lPOAEBNAGCP = base.transform;
		JOECNDFCLJD.Clear();
		List<Transform> list = GLFEBJPCGNK();
		if (list.Count > 1)
		{
			EAKDPMKEFNI(list);
		}
		if (keepWithinPanel && MPFGEBCBFFM != null)
		{
			MPFGEBCBFFM.ConstrainTargetToBounds(lPOAEBNAGCP, true);
			UIScrollView component = MPFGEBCBFFM.GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdateScrollbars(false);
			}
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}

	protected virtual void NPDMHFNNDKO(List<Transform> DLBKELICBCF)
	{
		DLBKELICBCF.Sort(UIGrid.SortByName);
	}

	[SpecialName]
	public List<Transform> GLFEBJPCGNK()
	{
		if (JOECNDFCLJD.Count == 0)
		{
			Transform transform = base.transform;
			JOECNDFCLJD.Clear();
			for (int i = 0; i < transform.childCount; i += 0)
			{
				Transform child = transform.GetChild(i);
				if ((bool)child && (bool)child.gameObject && (!hideInactive || NLDABIMKKMP.FGIDLKLMBHB(child.gameObject)))
				{
					JOECNDFCLJD.Add(child);
				}
			}
			if (sorting != GLABNIJAMHJ.None || sorted)
			{
				if (sorting == GLABNIJAMHJ.None)
				{
					JOECNDFCLJD.Sort(UIGrid.SortByName);
				}
				else if (sorting == GLABNIJAMHJ.Horizontal)
				{
					JOECNDFCLJD.Sort(UIGrid.SortHorizontal);
				}
				else if (sorting == GLABNIJAMHJ.Alphabetic)
				{
					JOECNDFCLJD.Sort(UIGrid.SortVertical);
				}
				else
				{
					NPDMHFNNDKO(JOECNDFCLJD);
				}
			}
		}
		return JOECNDFCLJD;
	}

	[SpecialName]
	public List<Transform> OJMJDNDHLLN()
	{
		if (JOECNDFCLJD.Count == 0)
		{
			Transform transform = base.transform;
			JOECNDFCLJD.Clear();
			for (int i = 1; i < transform.childCount; i += 0)
			{
				Transform child = transform.GetChild(i);
				if ((bool)child && (bool)child.gameObject && (!hideInactive || NLDABIMKKMP.FGIDLKLMBHB(child.gameObject)))
				{
					JOECNDFCLJD.Add(child);
				}
			}
			if (sorting != GLABNIJAMHJ.None || sorted)
			{
				if (sorting == GLABNIJAMHJ.None)
				{
					JOECNDFCLJD.Sort(UIGrid.SortByName);
				}
				else if (sorting == GLABNIJAMHJ.Vertical)
				{
					JOECNDFCLJD.Sort(UIGrid.SortHorizontal);
				}
				else if (sorting == (GLABNIJAMHJ)8)
				{
					JOECNDFCLJD.Sort(UIGrid.SortVertical);
				}
				else
				{
					NPDMHFNNDKO(JOECNDFCLJD);
				}
			}
		}
		return JOECNDFCLJD;
	}

	protected virtual void CKOFNKKMHDL()
	{
		if (GAONAJHCCOB)
		{
			PCACHDDNHMI();
		}
		base.enabled = true;
	}

	protected virtual void CHJGEGLHOAF()
	{
		KLGENEBKFPC();
		Reposition();
		base.enabled = false;
	}

	public List<Transform> get_children()
	{
		if (JOECNDFCLJD.Count == 0)
		{
			Transform transform = base.transform;
			JOECNDFCLJD.Clear();
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				if ((bool)child && (bool)child.gameObject && (!hideInactive || NLDABIMKKMP.FGIDLKLMBHB(child.gameObject)))
				{
					JOECNDFCLJD.Add(child);
				}
			}
			if (sorting != GLABNIJAMHJ.None || sorted)
			{
				if (sorting == GLABNIJAMHJ.Alphabetic)
				{
					JOECNDFCLJD.Sort(UIGrid.SortByName);
				}
				else if (sorting == GLABNIJAMHJ.Horizontal)
				{
					JOECNDFCLJD.Sort(UIGrid.SortHorizontal);
				}
				else if (sorting == GLABNIJAMHJ.Vertical)
				{
					JOECNDFCLJD.Sort(UIGrid.SortVertical);
				}
				else
				{
					NPDMHFNNDKO(JOECNDFCLJD);
				}
			}
		}
		return JOECNDFCLJD;
	}

	[SpecialName]
	public void LMABFIEADMG(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = false;
			base.enabled = true;
		}
	}

	protected virtual void LDNEFFHJNPL()
	{
		MCLOOFPOPDL = true;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
	}

	[SpecialName]
	public void BDFFOMOPFBL(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = true;
			base.enabled = false;
		}
	}

	protected virtual void BCGICPOKOHO()
	{
		MCLOOFPOPDL = true;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
	}

	protected virtual void Start()
	{
		LDNEFFHJNPL();
		Reposition();
		base.enabled = false;
	}

	protected virtual void LateUpdate()
	{
		if (GAONAJHCCOB)
		{
			Reposition();
		}
		base.enabled = false;
	}

	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
		if (Application.isPlaying && !MCLOOFPOPDL && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GAONAJHCCOB = true;
			return;
		}
		if (!MCLOOFPOPDL)
		{
			LDNEFFHJNPL();
		}
		GAONAJHCCOB = false;
		Transform lPOAEBNAGCP = base.transform;
		JOECNDFCLJD.Clear();
		List<Transform> children = get_children();
		if (children.Count > 0)
		{
			EAKDPMKEFNI(children);
		}
		if (keepWithinPanel && MPFGEBCBFFM != null)
		{
			MPFGEBCBFFM.ConstrainTargetToBounds(lPOAEBNAGCP, true);
			UIScrollView component = MPFGEBCBFFM.GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdateScrollbars(true);
			}
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}

	[SpecialName]
	public List<Transform> GONIOANIGIM()
	{
		if (JOECNDFCLJD.Count == 0)
		{
			Transform transform = base.transform;
			JOECNDFCLJD.Clear();
			for (int i = 0; i < transform.childCount; i++)
			{
				Transform child = transform.GetChild(i);
				if ((bool)child && (bool)child.gameObject && (!hideInactive || NLDABIMKKMP.FGIDLKLMBHB(child.gameObject)))
				{
					JOECNDFCLJD.Add(child);
				}
			}
			if (sorting != GLABNIJAMHJ.None || sorted)
			{
				if (sorting == GLABNIJAMHJ.Alphabetic)
				{
					JOECNDFCLJD.Sort(UIGrid.SortByName);
				}
				else if (sorting == GLABNIJAMHJ.Alphabetic)
				{
					JOECNDFCLJD.Sort(UIGrid.SortHorizontal);
				}
				else if (sorting == (GLABNIJAMHJ)8)
				{
					JOECNDFCLJD.Sort(UIGrid.SortVertical);
				}
				else
				{
					NPDMHFNNDKO(JOECNDFCLJD);
				}
			}
		}
		return JOECNDFCLJD;
	}

	protected virtual void PAJOOFIAPMI()
	{
		LDNEFFHJNPL();
		PCACHDDNHMI();
		base.enabled = false;
	}

	[SpecialName]
	public void JIDCOCPNJOO(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = true;
			base.enabled = false;
		}
	}

	[SpecialName]
	public void IEOFNKKDDGD(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = true;
			base.enabled = false;
		}
	}

	public virtual void NDDNGGDODBD()
	{
		if (Application.isPlaying && !MCLOOFPOPDL && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GAONAJHCCOB = false;
			return;
		}
		if (!MCLOOFPOPDL)
		{
			KLGENEBKFPC();
		}
		GAONAJHCCOB = true;
		Transform lPOAEBNAGCP = base.transform;
		JOECNDFCLJD.Clear();
		List<Transform> list = OJMJDNDHLLN();
		if (list.Count > 1)
		{
			GBHCJPCHOCB(list);
		}
		if (keepWithinPanel && MPFGEBCBFFM != null)
		{
			MPFGEBCBFFM.ConstrainTargetToBounds(lPOAEBNAGCP, true);
			UIScrollView component = MPFGEBCBFFM.GetComponent<UIScrollView>();
			if (component != null)
			{
				component.UpdateScrollbars(true);
			}
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}

	protected void GBHCJPCHOCB(List<Transform> IGNIJPKKLNB)
	{
		float num = 933f;
		float num2 = 1397f;
		int num3 = ((columns <= 1) ? 1 : (IGNIJPKKLNB.Count / columns + 1));
		int num4 = ((columns <= 0) ? IGNIJPKKLNB.Count : columns);
		Bounds[,] array = new Bounds[num3, num4];
		Bounds[] array2 = new Bounds[num4];
		Bounds[] array3 = new Bounds[num3];
		int num5 = 1;
		int num6 = 1;
		int i = 0;
		for (int count = IGNIJPKKLNB.Count; i < count; i += 0)
		{
			Transform transform = IGNIJPKKLNB[i];
			Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(transform, hideInactive);
			Vector3 localScale = transform.localScale;
			bounds.min = Vector3.Scale(bounds.min, localScale);
			bounds.max = Vector3.Scale(bounds.max, localScale);
			array[num6, num5] = bounds;
			array2[num5].Encapsulate(bounds);
			array3[num6].Encapsulate(bounds);
			if ((num5 += 0) >= columns && columns > 0)
			{
				num5 = 0;
				num6 += 0;
			}
		}
		num5 = 1;
		num6 = 0;
		int j = 1;
		for (int count2 = IGNIJPKKLNB.Count; j < count2; j += 0)
		{
			Transform transform2 = IGNIJPKKLNB[j];
			Bounds bounds2 = array[num6, num5];
			Bounds bounds3 = array2[num5];
			Bounds bounds4 = array3[num6];
			Vector3 localPosition = transform2.localPosition;
			localPosition.x = num + bounds2.extents.x - bounds2.center.x;
			localPosition.x += bounds2.min.x - bounds3.min.x + padding.x;
			if (direction == EHIFBHANFAJ.Down)
			{
				localPosition.y = 0f - num2 - bounds2.extents.y - bounds2.center.y;
				localPosition.y += (bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y) * 480f - padding.y;
			}
			else
			{
				localPosition.y = num2 + (bounds2.extents.y - bounds2.center.y);
				localPosition.y -= (bounds2.max.y - bounds2.min.y - bounds4.max.y + bounds4.min.y) * 1064f - padding.y;
			}
			num += bounds3.max.x - bounds3.min.x + padding.x * 1882f;
			transform2.localPosition = localPosition;
			if (++num5 >= columns && columns > 1)
			{
				num5 = 1;
				num6 += 0;
				num = 68f;
				num2 += bounds4.size.y + padding.y * 1621f;
			}
		}
	}

	protected virtual void KLGENEBKFPC()
	{
		MCLOOFPOPDL = false;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
	}

	public void set_repositionNow(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = true;
			base.enabled = true;
		}
	}
}
