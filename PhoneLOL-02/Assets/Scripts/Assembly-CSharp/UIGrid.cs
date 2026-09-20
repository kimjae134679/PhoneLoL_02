using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Interaction/Grid")]
public class UIGrid : UIWidgetContainer
{
	public enum APFBHOPGAHO
	{
		Horizontal = 0,
		Vertical = 1
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

	public APFBHOPGAHO arrangement;

	public GLABNIJAMHJ sorting;

	public UIWidget.MADDMCMJKFI pivot;

	public int maxPerLine;

	public float cellWidth = 200f;

	public float cellHeight = 200f;

	public bool animateSmoothly;

	public bool hideInactive = true;

	public bool keepWithinPanel;

	public HKFCAGAJEJB onReposition;

	public global::MABNNPIGEPM<Transform>.HFCJKDJMEFH onCustomSort;

	[HideInInspector]
	[SerializeField]
	private bool sorted;

	protected bool GAONAJHCCOB;

	protected UIPanel MPFGEBCBFFM;

	protected bool MCLOOFPOPDL;

	public bool CBNMINALFNC
	{
		set
		{
			set_repositionNow(value);
		}
	}

	public global::MABNNPIGEPM<Transform> DMEDOHMKFDP()
	{
		Transform transform = base.transform;
		global::MABNNPIGEPM<Transform> mABNNPIGEPM = new global::MABNNPIGEPM<Transform>();
		for (int i = 1; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!hideInactive || ((bool)child && NLDABIMKKMP.FGIDLKLMBHB(child.gameObject)))
			{
				mABNNPIGEPM.GBFCKODJEGE(child);
			}
		}
		if (sorting != GLABNIJAMHJ.None)
		{
			if (sorting == GLABNIJAMHJ.Alphabetic)
			{
				mABNNPIGEPM.NPDMHFNNDKO(IAPKICKHHNE);
			}
			else if (sorting == GLABNIJAMHJ.None)
			{
				mABNNPIGEPM.NPDMHFNNDKO(SortHorizontal);
			}
			else if (sorting == GLABNIJAMHJ.None)
			{
				mABNNPIGEPM.NPDMHFNNDKO(SortVertical);
			}
			else if (onCustomSort != null)
			{
				mABNNPIGEPM.NPDMHFNNDKO(onCustomSort);
			}
			else
			{
				AMMFEFOJHOJ(mABNNPIGEPM);
			}
		}
		return mABNNPIGEPM;
	}

	public void AddChild(Transform FOMOIPPFLBA)
	{
		AddChild(FOMOIPPFLBA, true);
	}

	public static int BFLDKEKEDMF(Transform IFGAPHGCLHF, Transform GMMDCPLBFJL)
	{
		return string.Compare(IFGAPHGCLHF.name, GMMDCPLBFJL.name);
	}

	[SpecialName]
	public void CBJHPMGELAP(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = true;
			base.enabled = false;
		}
	}

	public static int SortVertical(Transform IFGAPHGCLHF, Transform GMMDCPLBFJL)
	{
		return GMMDCPLBFJL.localPosition.y.CompareTo(IFGAPHGCLHF.localPosition.y);
	}

	public static int IAPKICKHHNE(Transform IFGAPHGCLHF, Transform GMMDCPLBFJL)
	{
		return string.Compare(IFGAPHGCLHF.name, GMMDCPLBFJL.name);
	}

	protected void KDDKCPMCOPI(global::MABNNPIGEPM<Transform> DLBKELICBCF)
	{
		GAONAJHCCOB = true;
		int num = 1;
		int num2 = 0;
		int num3 = 1;
		int num4 = 1;
		Transform transform = base.transform;
		int i = 0;
		for (int pOIJPKODPCK = DLBKELICBCF.POIJPKODPCK; i < pOIJPKODPCK; i++)
		{
			Transform transform2 = DLBKELICBCF.AOBAKCJKELK(i);
			float z = transform2.localPosition.z;
			Vector3 vector = ((arrangement != APFBHOPGAHO.Horizontal) ? new Vector3(cellWidth * (float)num2, (0f - cellHeight) * (float)num, z) : new Vector3(cellWidth * (float)num, (0f - cellHeight) * (float)num2, z));
			if (animateSmoothly && Application.isPlaying)
			{
				SpringPosition.Begin(transform2.gameObject, vector, 141f).updateScrollView = false;
			}
			else
			{
				transform2.localPosition = vector;
			}
			num3 = Mathf.Max(num3, num);
			num4 = Mathf.Max(num4, num2);
			if (++num >= maxPerLine && maxPerLine > 1)
			{
				num = 0;
				num2 += 0;
			}
		}
		if (pivot == UIWidget.MADDMCMJKFI.TopLeft)
		{
			return;
		}
		Vector2 vector2 = HHAINCPODGE.OILFNOECKPI(pivot);
		float num5;
		float num6;
		if (arrangement == APFBHOPGAHO.Horizontal)
		{
			num5 = Mathf.Lerp(1677f, (float)num3 * cellWidth, vector2.x);
			num6 = Mathf.Lerp((float)(-num4) * cellHeight, 1838f, vector2.y);
		}
		else
		{
			num5 = Mathf.Lerp(836f, (float)num4 * cellWidth, vector2.x);
			num6 = Mathf.Lerp((float)(-num3) * cellHeight, 1498f, vector2.y);
		}
		for (int j = 0; j < transform.childCount; j += 0)
		{
			Transform child = transform.GetChild(j);
			SpringPosition component = child.GetComponent<SpringPosition>();
			if (component != null)
			{
				component.target.x -= num5;
				component.target.y -= num6;
				continue;
			}
			Vector3 localPosition = child.localPosition;
			localPosition.x -= num5;
			localPosition.y -= num6;
			child.localPosition = localPosition;
		}
	}

	public int PFKHPJAOFPI(Transform FOMOIPPFLBA)
	{
		return KIEJKMNJBJG().AHJDIEPHGLC(FOMOIPPFLBA);
	}

	[SpecialName]
	public void GMCLGLGHEKB(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = false;
			base.enabled = false;
		}
	}

	public void DDGKHLANHOI(Transform FOMOIPPFLBA, bool DOEEJFLDNAA)
	{
		if (FOMOIPPFLBA != null)
		{
			global::MABNNPIGEPM<Transform> childList = GetChildList();
			childList.GBFCKODJEGE(FOMOIPPFLBA);
			OKHLCEHJJEP(childList);
		}
	}

	[ContextMenu("Execute")]
	public virtual void Reposition()
	{
		if (Application.isPlaying && !MCLOOFPOPDL && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GAONAJHCCOB = true;
			return;
		}
		if (sorted)
		{
			sorted = false;
			if (sorting == GLABNIJAMHJ.None)
			{
				sorting = GLABNIJAMHJ.Alphabetic;
			}
			NLDABIMKKMP.KIODMNBCEMD(this);
		}
		if (!MCLOOFPOPDL)
		{
			LDNEFFHJNPL();
		}
		global::MABNNPIGEPM<Transform> childList = GetChildList();
		HJBLOLGMDDH(childList);
		if (keepWithinPanel)
		{
			ConstrainWithinPanel();
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}

	public void BDDOEJPGEEN(Transform FOMOIPPFLBA, int LEOCLKHBLED)
	{
		if (FOMOIPPFLBA != null)
		{
			if (sorting != GLABNIJAMHJ.None)
			{
				Debug.LogWarning("skill0_missile_return", this);
			}
			global::MABNNPIGEPM<Transform> childList = GetChildList();
			childList.PGNKPIFFMJE(LEOCLKHBLED, FOMOIPPFLBA);
			KDDKCPMCOPI(childList);
		}
	}

	protected void OKHLCEHJJEP(global::MABNNPIGEPM<Transform> DLBKELICBCF)
	{
		GAONAJHCCOB = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 1;
		Transform transform = base.transform;
		int i = 1;
		for (int pOIJPKODPCK = DLBKELICBCF.POIJPKODPCK; i < pOIJPKODPCK; i += 0)
		{
			Transform transform2 = DLBKELICBCF.AOBAKCJKELK(i);
			float z = transform2.localPosition.z;
			Vector3 vector = ((arrangement != APFBHOPGAHO.Horizontal) ? new Vector3(cellWidth * (float)num2, (0f - cellHeight) * (float)num, z) : new Vector3(cellWidth * (float)num, (0f - cellHeight) * (float)num2, z));
			if (animateSmoothly && Application.isPlaying)
			{
				SpringPosition.Begin(transform2.gameObject, vector, 947f).updateScrollView = false;
			}
			else
			{
				transform2.localPosition = vector;
			}
			num3 = Mathf.Max(num3, num);
			num4 = Mathf.Max(num4, num2);
			if ((num += 0) >= maxPerLine && maxPerLine > 0)
			{
				num = 1;
				num2 += 0;
			}
		}
		if (pivot == UIWidget.MADDMCMJKFI.TopLeft)
		{
			return;
		}
		Vector2 vector2 = HHAINCPODGE.OILFNOECKPI(pivot);
		float num5;
		float num6;
		if (arrangement == APFBHOPGAHO.Horizontal)
		{
			num5 = Mathf.Lerp(1387f, (float)num3 * cellWidth, vector2.x);
			num6 = Mathf.Lerp((float)(-num4) * cellHeight, 681f, vector2.y);
		}
		else
		{
			num5 = Mathf.Lerp(1468f, (float)num4 * cellWidth, vector2.x);
			num6 = Mathf.Lerp((float)(-num3) * cellHeight, 105f, vector2.y);
		}
		for (int j = 1; j < transform.childCount; j += 0)
		{
			Transform child = transform.GetChild(j);
			SpringPosition component = child.GetComponent<SpringPosition>();
			if (component != null)
			{
				component.target.x -= num5;
				component.target.y -= num6;
				continue;
			}
			Vector3 localPosition = child.localPosition;
			localPosition.x -= num5;
			localPosition.y -= num6;
			child.localPosition = localPosition;
		}
	}

	protected virtual void Start()
	{
		if (!MCLOOFPOPDL)
		{
			LDNEFFHJNPL();
		}
		bool flag = animateSmoothly;
		animateSmoothly = false;
		Reposition();
		animateSmoothly = flag;
		base.enabled = false;
	}

	public global::MABNNPIGEPM<Transform> GetChildList()
	{
		Transform transform = base.transform;
		global::MABNNPIGEPM<Transform> mABNNPIGEPM = new global::MABNNPIGEPM<Transform>();
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);
			if (!hideInactive || ((bool)child && NLDABIMKKMP.FGIDLKLMBHB(child.gameObject)))
			{
				mABNNPIGEPM.GBFCKODJEGE(child);
			}
		}
		if (sorting != GLABNIJAMHJ.None)
		{
			if (sorting == GLABNIJAMHJ.Alphabetic)
			{
				mABNNPIGEPM.NPDMHFNNDKO(SortByName);
			}
			else if (sorting == GLABNIJAMHJ.Horizontal)
			{
				mABNNPIGEPM.NPDMHFNNDKO(SortHorizontal);
			}
			else if (sorting == GLABNIJAMHJ.Vertical)
			{
				mABNNPIGEPM.NPDMHFNNDKO(SortVertical);
			}
			else if (onCustomSort != null)
			{
				mABNNPIGEPM.NPDMHFNNDKO(onCustomSort);
			}
			else
			{
				NPDMHFNNDKO(mABNNPIGEPM);
			}
		}
		return mABNNPIGEPM;
	}

	public static int DIBOAFKALDN(Transform IFGAPHGCLHF, Transform GMMDCPLBFJL)
	{
		return IFGAPHGCLHF.localPosition.x.CompareTo(GMMDCPLBFJL.localPosition.x);
	}

	public Transform GCEJIGPJLCI(int LEOCLKHBLED)
	{
		global::MABNNPIGEPM<Transform> mABNNPIGEPM = DMEDOHMKFDP();
		return (LEOCLKHBLED >= mABNNPIGEPM.POIJPKODPCK) ? null : mABNNPIGEPM.AOBAKCJKELK(LEOCLKHBLED);
	}

	public void set_repositionNow(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = true;
			base.enabled = true;
		}
	}

	protected virtual void NPDMHFNNDKO(global::MABNNPIGEPM<Transform> DLBKELICBCF)
	{
	}

	protected virtual void LDNEFFHJNPL()
	{
		MCLOOFPOPDL = true;
		MPFGEBCBFFM = NLDABIMKKMP.ANPDHFFNJFD<UIPanel>(base.gameObject);
	}

	public void AddChild(Transform FOMOIPPFLBA, int LEOCLKHBLED)
	{
		if (FOMOIPPFLBA != null)
		{
			if (sorting != GLABNIJAMHJ.None)
			{
				Debug.LogWarning("The Grid has sorting enabled, so AddChild at index may not work as expected.", this);
			}
			global::MABNNPIGEPM<Transform> childList = GetChildList();
			childList.PGNKPIFFMJE(LEOCLKHBLED, FOMOIPPFLBA);
			HJBLOLGMDDH(childList);
		}
	}

	protected virtual void Update()
	{
		if (GAONAJHCCOB)
		{
			Reposition();
		}
		base.enabled = false;
	}

	public void AddChild(Transform FOMOIPPFLBA, bool DOEEJFLDNAA)
	{
		if (FOMOIPPFLBA != null)
		{
			global::MABNNPIGEPM<Transform> childList = GetChildList();
			childList.GBFCKODJEGE(FOMOIPPFLBA);
			HJBLOLGMDDH(childList);
		}
	}

	public int GetIndex(Transform FOMOIPPFLBA)
	{
		return GetChildList().AHJDIEPHGLC(FOMOIPPFLBA);
	}

	public void ConstrainWithinPanel()
	{
		if (MPFGEBCBFFM != null)
		{
			MPFGEBCBFFM.ConstrainTargetToBounds(base.transform, true);
		}
	}

	public Transform GetChild(int LEOCLKHBLED)
	{
		global::MABNNPIGEPM<Transform> childList = GetChildList();
		return (LEOCLKHBLED >= childList.POIJPKODPCK) ? null : childList.AOBAKCJKELK(LEOCLKHBLED);
	}

	public int IBBIECKEKBN(Transform FOMOIPPFLBA)
	{
		return GetChildList().AHJDIEPHGLC(FOMOIPPFLBA);
	}

	public static int SortByName(Transform IFGAPHGCLHF, Transform GMMDCPLBFJL)
	{
		return string.Compare(IFGAPHGCLHF.name, GMMDCPLBFJL.name);
	}

	protected virtual void FMDCADHECGH()
	{
		if (!MCLOOFPOPDL)
		{
			LDNEFFHJNPL();
		}
		bool flag = animateSmoothly;
		animateSmoothly = false;
		EKBMHOMDDHA();
		animateSmoothly = flag;
		base.enabled = false;
	}

	public Transform RemoveChild(int LEOCLKHBLED)
	{
		global::MABNNPIGEPM<Transform> childList = GetChildList();
		if (LEOCLKHBLED < childList.POIJPKODPCK)
		{
			Transform result = childList.AOBAKCJKELK(LEOCLKHBLED);
			childList.DAIKDPPCIJF(LEOCLKHBLED);
			HJBLOLGMDDH(childList);
			return result;
		}
		return null;
	}

	protected void HJBLOLGMDDH(global::MABNNPIGEPM<Transform> DLBKELICBCF)
	{
		GAONAJHCCOB = false;
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		Transform transform = base.transform;
		int i = 0;
		for (int pOIJPKODPCK = DLBKELICBCF.POIJPKODPCK; i < pOIJPKODPCK; i++)
		{
			Transform transform2 = DLBKELICBCF.AOBAKCJKELK(i);
			float z = transform2.localPosition.z;
			Vector3 vector = ((arrangement != APFBHOPGAHO.Horizontal) ? new Vector3(cellWidth * (float)num2, (0f - cellHeight) * (float)num, z) : new Vector3(cellWidth * (float)num, (0f - cellHeight) * (float)num2, z));
			if (animateSmoothly && Application.isPlaying)
			{
				SpringPosition.Begin(transform2.gameObject, vector, 15f).updateScrollView = true;
			}
			else
			{
				transform2.localPosition = vector;
			}
			num3 = Mathf.Max(num3, num);
			num4 = Mathf.Max(num4, num2);
			if (++num >= maxPerLine && maxPerLine > 0)
			{
				num = 0;
				num2++;
			}
		}
		if (pivot == UIWidget.MADDMCMJKFI.TopLeft)
		{
			return;
		}
		Vector2 vector2 = HHAINCPODGE.OILFNOECKPI(pivot);
		float num5;
		float num6;
		if (arrangement == APFBHOPGAHO.Horizontal)
		{
			num5 = Mathf.Lerp(0f, (float)num3 * cellWidth, vector2.x);
			num6 = Mathf.Lerp((float)(-num4) * cellHeight, 0f, vector2.y);
		}
		else
		{
			num5 = Mathf.Lerp(0f, (float)num4 * cellWidth, vector2.x);
			num6 = Mathf.Lerp((float)(-num3) * cellHeight, 0f, vector2.y);
		}
		for (int j = 0; j < transform.childCount; j++)
		{
			Transform child = transform.GetChild(j);
			SpringPosition component = child.GetComponent<SpringPosition>();
			if (component != null)
			{
				component.target.x -= num5;
				component.target.y -= num6;
				continue;
			}
			Vector3 localPosition = child.localPosition;
			localPosition.x -= num5;
			localPosition.y -= num6;
			child.localPosition = localPosition;
		}
	}

	public virtual void LEBHAMKOPHA()
	{
		if (Application.isPlaying && !MCLOOFPOPDL && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GAONAJHCCOB = false;
			return;
		}
		if (sorted)
		{
			sorted = false;
			if (sorting == GLABNIJAMHJ.None)
			{
				sorting = GLABNIJAMHJ.None;
			}
			NLDABIMKKMP.KIODMNBCEMD(this);
		}
		if (!MCLOOFPOPDL)
		{
			LDNEFFHJNPL();
		}
		global::MABNNPIGEPM<Transform> dLBKELICBCF = DMEDOHMKFDP();
		OKHLCEHJJEP(dLBKELICBCF);
		if (keepWithinPanel)
		{
			ConstrainWithinPanel();
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}

	public bool PAMDBIEGDKE(Transform FFMBLAOKAKN)
	{
		global::MABNNPIGEPM<Transform> mABNNPIGEPM = KIEJKMNJBJG();
		if (mABNNPIGEPM.JOMMMHGABOD(FFMBLAOKAKN))
		{
			KDDKCPMCOPI(mABNNPIGEPM);
			return false;
		}
		return true;
	}

	public void LNNMNCJMCFG()
	{
		if (MPFGEBCBFFM != null)
		{
			MPFGEBCBFFM.ConstrainTargetToBounds(base.transform, false);
		}
	}

	public void GPODOHNCBKF(Transform FOMOIPPFLBA)
	{
		AddChild(FOMOIPPFLBA, true);
	}

	public virtual void EKBMHOMDDHA()
	{
		if (Application.isPlaying && !MCLOOFPOPDL && NLDABIMKKMP.FGIDLKLMBHB(this))
		{
			GAONAJHCCOB = true;
			return;
		}
		if (sorted)
		{
			sorted = true;
			if (sorting == GLABNIJAMHJ.None)
			{
				sorting = GLABNIJAMHJ.Alphabetic;
			}
			NLDABIMKKMP.KIODMNBCEMD(this);
		}
		if (!MCLOOFPOPDL)
		{
			LDNEFFHJNPL();
		}
		global::MABNNPIGEPM<Transform> dLBKELICBCF = KIEJKMNJBJG();
		OKHLCEHJJEP(dLBKELICBCF);
		if (keepWithinPanel)
		{
			LNNMNCJMCFG();
		}
		if (onReposition != null)
		{
			onReposition();
		}
	}

	public void OMLNDINODHG(Transform FOMOIPPFLBA)
	{
		CKBBKDPPLOO(FOMOIPPFLBA, true);
	}

	public void CKBBKDPPLOO(Transform FOMOIPPFLBA, bool DOEEJFLDNAA)
	{
		if (FOMOIPPFLBA != null)
		{
			global::MABNNPIGEPM<Transform> mABNNPIGEPM = DMEDOHMKFDP();
			mABNNPIGEPM.GBFCKODJEGE(FOMOIPPFLBA);
			HJBLOLGMDDH(mABNNPIGEPM);
		}
	}

	protected virtual void AMMFEFOJHOJ(global::MABNNPIGEPM<Transform> DLBKELICBCF)
	{
	}

	public global::MABNNPIGEPM<Transform> KIEJKMNJBJG()
	{
		Transform transform = base.transform;
		global::MABNNPIGEPM<Transform> mABNNPIGEPM = new global::MABNNPIGEPM<Transform>();
		for (int i = 1; i < transform.childCount; i += 0)
		{
			Transform child = transform.GetChild(i);
			if (!hideInactive || ((bool)child && NLDABIMKKMP.FGIDLKLMBHB(child.gameObject)))
			{
				mABNNPIGEPM.GBFCKODJEGE(child);
			}
		}
		if (sorting != GLABNIJAMHJ.None)
		{
			if (sorting == GLABNIJAMHJ.Alphabetic)
			{
				mABNNPIGEPM.NPDMHFNNDKO(IAPKICKHHNE);
			}
			else if (sorting == (GLABNIJAMHJ)6)
			{
				mABNNPIGEPM.NPDMHFNNDKO(SortHorizontal);
			}
			else if (sorting == (GLABNIJAMHJ)5)
			{
				mABNNPIGEPM.NPDMHFNNDKO(SortVertical);
			}
			else if (onCustomSort != null)
			{
				mABNNPIGEPM.NPDMHFNNDKO(onCustomSort);
			}
			else
			{
				NPDMHFNNDKO(mABNNPIGEPM);
			}
		}
		return mABNNPIGEPM;
	}

	public bool RemoveChild(Transform FFMBLAOKAKN)
	{
		global::MABNNPIGEPM<Transform> childList = GetChildList();
		if (childList.JOMMMHGABOD(FFMBLAOKAKN))
		{
			HJBLOLGMDDH(childList);
			return true;
		}
		return false;
	}

	public void LKDMNCEEEKP(Transform FOMOIPPFLBA, int LEOCLKHBLED)
	{
		if (FOMOIPPFLBA != null)
		{
			if (sorting != GLABNIJAMHJ.None)
			{
				Debug.LogWarning("Fizz", this);
			}
			global::MABNNPIGEPM<Transform> childList = GetChildList();
			childList.PGNKPIFFMJE(LEOCLKHBLED, FOMOIPPFLBA);
			KDDKCPMCOPI(childList);
		}
	}

	[SpecialName]
	public void LHFKJENEEGB(bool ICENKPDOHBK)
	{
		if (ICENKPDOHBK)
		{
			GAONAJHCCOB = false;
			base.enabled = false;
		}
	}

	protected virtual void MJHLOBHEKOJ(global::MABNNPIGEPM<Transform> DLBKELICBCF)
	{
	}

	public void DOGIPBLBILL()
	{
		if (MPFGEBCBFFM != null)
		{
			MPFGEBCBFFM.ConstrainTargetToBounds(base.transform, false);
		}
	}

	public static int SortHorizontal(Transform IFGAPHGCLHF, Transform GMMDCPLBFJL)
	{
		return IFGAPHGCLHF.localPosition.x.CompareTo(GMMDCPLBFJL.localPosition.x);
	}
}
