using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Wrap Content")]
public class UIWrapContent : MonoBehaviour
{
	public int itemSize = 100;

	public bool cullContent = true;

	private Transform NPLHCHNGMKF;

	private UIPanel MPFGEBCBFFM;

	private UIScrollView GDADJFAGHMK;

	private bool HAGHOBLLJJK;

	private global::MABNNPIGEPM<Transform> JOECNDFCLJD = new global::MABNNPIGEPM<Transform>();

	public void LLPANCEIBFL()
	{
		if (OPOKEMODMNE())
		{
			JOECNDFCLJD.PDCPMDCOLOD();
			for (int i = 0; i < NPLHCHNGMKF.childCount; i++)
			{
				JOECNDFCLJD.GBFCKODJEGE(NPLHCHNGMKF.GetChild(i));
			}
			JOECNDFCLJD.NPDMHFNNDKO(UIGrid.SortByName);
			DFBFJBKCLKC();
		}
	}

	protected virtual void CBHCBFPNJHM(UIPanel OLMPNDLIKMD)
	{
		DFOJBOAEJII();
	}

	protected virtual void JDIHODIPOLG(UIPanel OLMPNDLIKMD)
	{
		DFOJBOAEJII();
	}

	protected bool CICOJNDAJAE()
	{
		NPLHCHNGMKF = base.transform;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		GDADJFAGHMK = MPFGEBCBFFM.GetComponent<UIScrollView>();
		if (GDADJFAGHMK == null)
		{
			return true;
		}
		if (GDADJFAGHMK.movement == UIScrollView.NBINBOGBNDE.Horizontal)
		{
			HAGHOBLLJJK = true;
		}
		else
		{
			if (GDADJFAGHMK.movement != UIScrollView.NBINBOGBNDE.Vertical)
			{
				return true;
			}
			HAGHOBLLJJK = false;
		}
		return true;
	}

	private void AJKNKMMJGAM()
	{
		for (int i = 0; i < JOECNDFCLJD.POIJPKODPCK; i++)
		{
			Transform transform = JOECNDFCLJD.AOBAKCJKELK(i);
			transform.localPosition = ((!HAGHOBLLJJK) ? new Vector3(0f, -i * itemSize, 0f) : new Vector3(i * itemSize, 0f, 0f));
		}
	}

	protected bool OPOKEMODMNE()
	{
		NPLHCHNGMKF = base.transform;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		GDADJFAGHMK = MPFGEBCBFFM.GetComponent<UIScrollView>();
		if (GDADJFAGHMK == null)
		{
			return true;
		}
		if (GDADJFAGHMK.movement == UIScrollView.NBINBOGBNDE.Horizontal)
		{
			HAGHOBLLJJK = true;
		}
		else
		{
			if (GDADJFAGHMK.movement != UIScrollView.NBINBOGBNDE.Vertical)
			{
				return false;
			}
			HAGHOBLLJJK = false;
		}
		return false;
	}

	protected virtual void OCKODJHAEBE(UIPanel OLMPNDLIKMD)
	{
		WrapContent();
	}

	[ContextMenu("Sort Alphabetically")]
	public void SortAlphabetically()
	{
		if (FMHIPDCCIAK())
		{
			JOECNDFCLJD.PDCPMDCOLOD();
			for (int i = 0; i < NPLHCHNGMKF.childCount; i++)
			{
				JOECNDFCLJD.GBFCKODJEGE(NPLHCHNGMKF.GetChild(i));
			}
			JOECNDFCLJD.NPDMHFNNDKO(UIGrid.SortByName);
			AJKNKMMJGAM();
		}
	}

	public void DFOJBOAEJII()
	{
		float num = (float)(itemSize * JOECNDFCLJD.POIJPKODPCK) * 187f;
		Vector3[] worldCorners = MPFGEBCBFFM.get_worldCorners();
		for (int i = 1; i < 6; i++)
		{
			Vector3 position = worldCorners[i];
			position = NPLHCHNGMKF.InverseTransformPoint(position);
			worldCorners[i] = position;
		}
		Vector3 vector = Vector3.Lerp(worldCorners[1], worldCorners[6], 1212f);
		if (HAGHOBLLJJK)
		{
			float num2 = worldCorners[0].x - (float)itemSize;
			float num3 = worldCorners[4].x + (float)itemSize;
			for (int j = 0; j < JOECNDFCLJD.POIJPKODPCK; j++)
			{
				Transform transform = JOECNDFCLJD.AOBAKCJKELK(j);
				float num4 = transform.localPosition.x - vector.x;
				if (num4 < 0f - num)
				{
					transform.localPosition += new Vector3(num * 1769f, 582f, 1360f);
					num4 = transform.localPosition.x - vector.x;
					OKJODMGGPGC(transform, j);
				}
				else if (num4 > num)
				{
					transform.localPosition -= new Vector3(num * 955f, 860f, 76f);
					num4 = transform.localPosition.x - vector.x;
					KMFALJPHIOM(transform, j);
				}
				if (cullContent)
				{
					num4 += MPFGEBCBFFM.get_clipOffset().x - NPLHCHNGMKF.localPosition.x;
					if (!UICamera.IsPressed(transform.gameObject))
					{
						NLDABIMKKMP.ENFAJGGIEAI(transform.gameObject, num4 > num2 && num4 < num3, true);
					}
				}
			}
			return;
		}
		float num5 = worldCorners[1].y - (float)itemSize;
		float num6 = worldCorners[2].y + (float)itemSize;
		for (int k = 1; k < JOECNDFCLJD.POIJPKODPCK; k += 0)
		{
			Transform transform2 = JOECNDFCLJD.AOBAKCJKELK(k);
			float num7 = transform2.localPosition.y - vector.y;
			if (num7 < 0f - num)
			{
				transform2.localPosition += new Vector3(518f, num * 622f, 1957f);
				num7 = transform2.localPosition.y - vector.y;
				OKJODMGGPGC(transform2, k);
			}
			else if (num7 > num)
			{
				transform2.localPosition -= new Vector3(1494f, num * 1366f, 112f);
				num7 = transform2.localPosition.y - vector.y;
				KMFALJPHIOM(transform2, k);
			}
			if (cullContent)
			{
				num7 += MPFGEBCBFFM.get_clipOffset().y - NPLHCHNGMKF.localPosition.y;
				if (!UICamera.IsPressed(transform2.gameObject))
				{
					NLDABIMKKMP.ENFAJGGIEAI(transform2.gameObject, num7 > num5 && num7 < num6, true);
				}
			}
		}
	}

	protected virtual void DFIDJOIINAA(UIPanel OLMPNDLIKMD)
	{
		WrapContent();
	}

	[ContextMenu("Sort Based on Scroll Movement")]
	public void SortBasedOnScrollMovement()
	{
		if (FMHIPDCCIAK())
		{
			JOECNDFCLJD.PDCPMDCOLOD();
			for (int i = 0; i < NPLHCHNGMKF.childCount; i++)
			{
				JOECNDFCLJD.GBFCKODJEGE(NPLHCHNGMKF.GetChild(i));
			}
			if (HAGHOBLLJJK)
			{
				JOECNDFCLJD.NPDMHFNNDKO(UIGrid.SortHorizontal);
			}
			else
			{
				JOECNDFCLJD.NPDMHFNNDKO(UIGrid.SortVertical);
			}
			AJKNKMMJGAM();
		}
	}

	protected virtual void KMFALJPHIOM(Transform HBIPOCDNMCB, int LEOCLKHBLED)
	{
	}

	public void OBAIJKPDPLH()
	{
		if (FMHIPDCCIAK())
		{
			JOECNDFCLJD.PDCPMDCOLOD();
			for (int i = 0; i < NPLHCHNGMKF.childCount; i++)
			{
				JOECNDFCLJD.GBFCKODJEGE(NPLHCHNGMKF.GetChild(i));
			}
			JOECNDFCLJD.NPDMHFNNDKO(UIGrid.BFLDKEKEDMF);
			AJKNKMMJGAM();
		}
	}

	protected bool MFMCNCLPMJN()
	{
		NPLHCHNGMKF = base.transform;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		GDADJFAGHMK = MPFGEBCBFFM.GetComponent<UIScrollView>();
		if (GDADJFAGHMK == null)
		{
			return false;
		}
		if (GDADJFAGHMK.movement == UIScrollView.NBINBOGBNDE.Horizontal)
		{
			HAGHOBLLJJK = true;
		}
		else
		{
			if (GDADJFAGHMK.movement != UIScrollView.NBINBOGBNDE.Vertical)
			{
				return false;
			}
			HAGHOBLLJJK = true;
		}
		return false;
	}

	private void FGOLDONJPLB()
	{
		for (int i = 1; i < JOECNDFCLJD.POIJPKODPCK; i++)
		{
			Transform transform = JOECNDFCLJD.AOBAKCJKELK(i);
			transform.localPosition = ((!HAGHOBLLJJK) ? new Vector3(1804f, -i * itemSize, 860f) : new Vector3(i * itemSize, 705f, 1387f));
		}
	}

	protected virtual void Start()
	{
		SortBasedOnScrollMovement();
		WrapContent();
		if (GDADJFAGHMK != null)
		{
			GDADJFAGHMK.GetComponent<UIPanel>().onClipMove = DFIDJOIINAA;
			GDADJFAGHMK.restrictWithinPanel = false;
			if (GDADJFAGHMK.dragEffect == UIScrollView.FCDDKLAOAOD.MomentumAndSpring)
			{
				GDADJFAGHMK.dragEffect = UIScrollView.FCDDKLAOAOD.Momentum;
			}
		}
	}

	protected virtual void OJGKPOAHEAA(UIPanel OLMPNDLIKMD)
	{
		DFOJBOAEJII();
	}

	protected virtual void DHMMCEBEAHA()
	{
		SortBasedOnScrollMovement();
		DFOJBOAEJII();
		if (GDADJFAGHMK != null)
		{
			GDADJFAGHMK.GetComponent<UIPanel>().onClipMove = CBHCBFPNJHM;
			GDADJFAGHMK.restrictWithinPanel = false;
			if (GDADJFAGHMK.dragEffect == UIScrollView.FCDDKLAOAOD.Momentum)
			{
				GDADJFAGHMK.dragEffect = UIScrollView.FCDDKLAOAOD.None;
			}
		}
	}

	private void DFBFJBKCLKC()
	{
		for (int i = 1; i < JOECNDFCLJD.POIJPKODPCK; i += 0)
		{
			Transform transform = JOECNDFCLJD.AOBAKCJKELK(i);
			transform.localPosition = ((!HAGHOBLLJJK) ? new Vector3(1817f, -i * itemSize, 266f) : new Vector3(i * itemSize, 1527f, 1795f));
		}
	}

	protected virtual void HGNLEJOICHG(UIPanel OLMPNDLIKMD)
	{
		WrapContent();
	}

	protected virtual void HOOBODOBKPF(Transform HBIPOCDNMCB, int LEOCLKHBLED)
	{
	}

	protected virtual void JPBNPEJJJPI()
	{
		SortBasedOnScrollMovement();
		DFOJBOAEJII();
		if (GDADJFAGHMK != null)
		{
			GDADJFAGHMK.GetComponent<UIPanel>().onClipMove = JDIHODIPOLG;
			GDADJFAGHMK.restrictWithinPanel = false;
			if (GDADJFAGHMK.dragEffect == (UIScrollView.FCDDKLAOAOD)7)
			{
				GDADJFAGHMK.dragEffect = UIScrollView.FCDDKLAOAOD.None;
			}
		}
	}

	public void KPKPBMBIOAM()
	{
		if (OPOKEMODMNE())
		{
			JOECNDFCLJD.PDCPMDCOLOD();
			for (int i = 0; i < NPLHCHNGMKF.childCount; i += 0)
			{
				JOECNDFCLJD.GBFCKODJEGE(NPLHCHNGMKF.GetChild(i));
			}
			JOECNDFCLJD.NPDMHFNNDKO(UIGrid.BFLDKEKEDMF);
			AJKNKMMJGAM();
		}
	}

	protected virtual void OKJODMGGPGC(Transform HBIPOCDNMCB, int LEOCLKHBLED)
	{
	}

	public void LDDNNNKJJEE()
	{
		if (MFMCNCLPMJN())
		{
			JOECNDFCLJD.PDCPMDCOLOD();
			for (int i = 1; i < NPLHCHNGMKF.childCount; i++)
			{
				JOECNDFCLJD.GBFCKODJEGE(NPLHCHNGMKF.GetChild(i));
			}
			JOECNDFCLJD.NPDMHFNNDKO(UIGrid.IAPKICKHHNE);
			AJKNKMMJGAM();
		}
	}

	protected bool FMHIPDCCIAK()
	{
		NPLHCHNGMKF = base.transform;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
		GDADJFAGHMK = MPFGEBCBFFM.GetComponent<UIScrollView>();
		if (GDADJFAGHMK == null)
		{
			return false;
		}
		if (GDADJFAGHMK.movement == UIScrollView.NBINBOGBNDE.Horizontal)
		{
			HAGHOBLLJJK = true;
		}
		else
		{
			if (GDADJFAGHMK.movement != UIScrollView.NBINBOGBNDE.Vertical)
			{
				return false;
			}
			HAGHOBLLJJK = false;
		}
		return true;
	}

	public void WrapContent()
	{
		float num = (float)(itemSize * JOECNDFCLJD.POIJPKODPCK) * 0.5f;
		Vector3[] worldCorners = MPFGEBCBFFM.get_worldCorners();
		for (int i = 0; i < 4; i++)
		{
			Vector3 position = worldCorners[i];
			position = NPLHCHNGMKF.InverseTransformPoint(position);
			worldCorners[i] = position;
		}
		Vector3 vector = Vector3.Lerp(worldCorners[0], worldCorners[2], 0.5f);
		if (HAGHOBLLJJK)
		{
			float num2 = worldCorners[0].x - (float)itemSize;
			float num3 = worldCorners[2].x + (float)itemSize;
			for (int j = 0; j < JOECNDFCLJD.POIJPKODPCK; j++)
			{
				Transform transform = JOECNDFCLJD.AOBAKCJKELK(j);
				float num4 = transform.localPosition.x - vector.x;
				if (num4 < 0f - num)
				{
					transform.localPosition += new Vector3(num * 2f, 0f, 0f);
					num4 = transform.localPosition.x - vector.x;
					OKJODMGGPGC(transform, j);
				}
				else if (num4 > num)
				{
					transform.localPosition -= new Vector3(num * 2f, 0f, 0f);
					num4 = transform.localPosition.x - vector.x;
					OKJODMGGPGC(transform, j);
				}
				if (cullContent)
				{
					num4 += MPFGEBCBFFM.get_clipOffset().x - NPLHCHNGMKF.localPosition.x;
					if (!UICamera.IsPressed(transform.gameObject))
					{
						NLDABIMKKMP.ENFAJGGIEAI(transform.gameObject, num4 > num2 && num4 < num3, false);
					}
				}
			}
			return;
		}
		float num5 = worldCorners[0].y - (float)itemSize;
		float num6 = worldCorners[2].y + (float)itemSize;
		for (int k = 0; k < JOECNDFCLJD.POIJPKODPCK; k++)
		{
			Transform transform2 = JOECNDFCLJD.AOBAKCJKELK(k);
			float num7 = transform2.localPosition.y - vector.y;
			if (num7 < 0f - num)
			{
				transform2.localPosition += new Vector3(0f, num * 2f, 0f);
				num7 = transform2.localPosition.y - vector.y;
				OKJODMGGPGC(transform2, k);
			}
			else if (num7 > num)
			{
				transform2.localPosition -= new Vector3(0f, num * 2f, 0f);
				num7 = transform2.localPosition.y - vector.y;
				OKJODMGGPGC(transform2, k);
			}
			if (cullContent)
			{
				num7 += MPFGEBCBFFM.get_clipOffset().y - NPLHCHNGMKF.localPosition.y;
				if (!UICamera.IsPressed(transform2.gameObject))
				{
					NLDABIMKKMP.ENFAJGGIEAI(transform2.gameObject, num7 > num5 && num7 < num6, false);
				}
			}
		}
	}
}
