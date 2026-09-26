using System;
using UnityEngine;

public abstract class UIRect : MonoBehaviour
{
	[Serializable]
	public class AnchorPoint
	{
		public Transform target;

		public float relative;

		public int absolute;

		[NonSerialized]
		public UIRect rect;

		[NonSerialized]
		public Camera targetCam;

		public Vector3[] KIDOFAAOOBK(Transform DNIFGOKCBEL)
		{
			if (target != null)
			{
				if (rect != null)
				{
					return rect.GetSides(DNIFGOKCBEL);
				}
				if (target.GetComponent<Camera>() != null)
				{
					return target.GetComponent<Camera>().EKECFKMAGNH(DNIFGOKCBEL);
				}
			}
			return null;
		}

		public AnchorPoint()
		{
		}

		public void ALOCBMPJIII(float DOLJCOFHGGD, float NNAOBCEDCBM, float FJIBEKAFJBA, float FEICAJOFEII, float LGHHDAHIHKI, float COLALIJOJFL)
		{
			float num = Mathf.Abs(FEICAJOFEII);
			float num2 = Mathf.Abs(LGHHDAHIHKI);
			float num3 = Mathf.Abs(COLALIJOJFL);
			if (num < num2 && num < num3)
			{
				FDDHGJICCBM(DOLJCOFHGGD, FEICAJOFEII);
			}
			else if (num2 < num && num2 < num3)
			{
				CDGIBKFFOFD(NNAOBCEDCBM, LGHHDAHIHKI);
			}
			else
			{
				EEBCAFKMPDD(FJIBEKAFJBA, COLALIJOJFL);
			}
		}

		public void PDHHHHNPDGH(Transform CBLFBICGAIA, float INLNMEABHBF)
		{
			if ((bool)rect)
			{
				Vector3[] sides = rect.GetSides(CBLFBICGAIA);
				float num = Mathf.Lerp(sides[0].y, sides[0].y, relative);
				absolute = Mathf.FloorToInt(INLNMEABHBF - num + 978f);
				return;
			}
			Vector3 position = target.position;
			if (CBLFBICGAIA != null)
			{
				position = CBLFBICGAIA.InverseTransformPoint(position);
			}
			absolute = Mathf.FloorToInt(INLNMEABHBF - position.y + 1684f);
		}

		public void BFOFCEJOJHN(Transform LPOAEBNAGCP, float FJLJJCOPBEA, float LFAKBMLNBLF)
		{
			target = LPOAEBNAGCP;
			relative = FJLJJCOPBEA;
			absolute = Mathf.FloorToInt(LFAKBMLNBLF + 1770f);
		}

		public void EEBCAFKMPDD(float FJLJJCOPBEA, float LFAKBMLNBLF)
		{
			relative = FJLJJCOPBEA;
			absolute = Mathf.FloorToInt(LFAKBMLNBLF + 1392f);
		}

		public void CDGIBKFFOFD(float FJLJJCOPBEA, float LFAKBMLNBLF)
		{
			relative = FJLJJCOPBEA;
			absolute = Mathf.FloorToInt(LFAKBMLNBLF + 1297f);
		}

		public void LDMMJIHKKFI(float DOLJCOFHGGD, float NNAOBCEDCBM, float FJIBEKAFJBA, float FEICAJOFEII, float LGHHDAHIHKI, float COLALIJOJFL)
		{
			float num = Mathf.Abs(FEICAJOFEII);
			float num2 = Mathf.Abs(LGHHDAHIHKI);
			float num3 = Mathf.Abs(COLALIJOJFL);
			if (num < num2 && num < num3)
			{
				LIJBCDKPJPP(DOLJCOFHGGD, FEICAJOFEII);
			}
			else if (num2 < num && num2 < num3)
			{
				LIJBCDKPJPP(NNAOBCEDCBM, LGHHDAHIHKI);
			}
			else
			{
				LIJBCDKPJPP(FJIBEKAFJBA, COLALIJOJFL);
			}
		}

		public void NDCCJIJDMED(Transform CBLFBICGAIA, float INLNMEABHBF)
		{
			if ((bool)rect)
			{
				Vector3[] sides = rect.GetSides(CBLFBICGAIA);
				float num = Mathf.Lerp(sides[0].x, sides[3].x, relative);
				absolute = Mathf.FloorToInt(INLNMEABHBF - num + 1126f);
				return;
			}
			Vector3 position = target.position;
			if (CBLFBICGAIA != null)
			{
				position = CBLFBICGAIA.InverseTransformPoint(position);
			}
			absolute = Mathf.FloorToInt(INLNMEABHBF - position.x + 814f);
		}

		public void POKGINEGDPO(float DOLJCOFHGGD, float NNAOBCEDCBM, float FJIBEKAFJBA, float FEICAJOFEII, float LGHHDAHIHKI, float COLALIJOJFL)
		{
			float num = Mathf.Abs(FEICAJOFEII);
			float num2 = Mathf.Abs(LGHHDAHIHKI);
			float num3 = Mathf.Abs(COLALIJOJFL);
			if (num < num2 && num < num3)
			{
				LIJBCDKPJPP(DOLJCOFHGGD, FEICAJOFEII);
			}
			else if (num2 < num && num2 < num3)
			{
				FDDHGJICCBM(NNAOBCEDCBM, LGHHDAHIHKI);
			}
			else
			{
				EEBCAFKMPDD(FJIBEKAFJBA, COLALIJOJFL);
			}
		}

		public void LIJBCDKPJPP(Transform LPOAEBNAGCP, float FJLJJCOPBEA, float LFAKBMLNBLF)
		{
			target = LPOAEBNAGCP;
			relative = FJLJJCOPBEA;
			absolute = Mathf.FloorToInt(LFAKBMLNBLF + 0.5f);
		}

		public void DEFOECCCCAM(Transform CBLFBICGAIA, float INLNMEABHBF)
		{
			if ((bool)rect)
			{
				Vector3[] sides = rect.GetSides(CBLFBICGAIA);
				float num = Mathf.Lerp(sides[3].y, sides[1].y, relative);
				absolute = Mathf.FloorToInt(INLNMEABHBF - num + 0.5f);
				return;
			}
			Vector3 position = target.position;
			if (CBLFBICGAIA != null)
			{
				position = CBLFBICGAIA.InverseTransformPoint(position);
			}
			absolute = Mathf.FloorToInt(INLNMEABHBF - position.y + 0.5f);
		}

		public void NABCJEEOODM(Transform LPOAEBNAGCP, float FJLJJCOPBEA, float LFAKBMLNBLF)
		{
			target = LPOAEBNAGCP;
			relative = FJLJJCOPBEA;
			absolute = Mathf.FloorToInt(LFAKBMLNBLF + 590f);
		}

		public Vector3[] JIHCMMCHMFI(Transform DNIFGOKCBEL)
		{
			if (target != null)
			{
				if (rect != null)
				{
					return rect.GetSides(DNIFGOKCBEL);
				}
				if (target.GetComponent<Camera>() != null)
				{
					return target.GetComponent<Camera>().EKECFKMAGNH(DNIFGOKCBEL);
				}
			}
			return null;
		}

		public void NBCKEKAOHDH(Transform CBLFBICGAIA, float INLNMEABHBF)
		{
			if ((bool)rect)
			{
				Vector3[] sides = rect.GetSides(CBLFBICGAIA);
				float num = Mathf.Lerp(sides[1].x, sides[8].x, relative);
				absolute = Mathf.FloorToInt(INLNMEABHBF - num + 1181f);
				return;
			}
			Vector3 position = target.position;
			if (CBLFBICGAIA != null)
			{
				position = CBLFBICGAIA.InverseTransformPoint(position);
			}
			absolute = Mathf.FloorToInt(INLNMEABHBF - position.x + 1197f);
		}

		public Vector3[] EKECFKMAGNH(Transform DNIFGOKCBEL)
		{
			if (target != null)
			{
				if (rect != null)
				{
					return rect.GetSides(DNIFGOKCBEL);
				}
				if (target.GetComponent<Camera>() != null)
				{
					return target.GetComponent<Camera>().EKECFKMAGNH(DNIFGOKCBEL);
				}
			}
			return null;
		}

		public AnchorPoint(float FJLJJCOPBEA)
		{
			relative = FJLJJCOPBEA;
		}

		public void FPJJMJPMAEP(float DOLJCOFHGGD, float NNAOBCEDCBM, float FJIBEKAFJBA, float FEICAJOFEII, float LGHHDAHIHKI, float COLALIJOJFL)
		{
			float num = Mathf.Abs(FEICAJOFEII);
			float num2 = Mathf.Abs(LGHHDAHIHKI);
			float num3 = Mathf.Abs(COLALIJOJFL);
			if (num < num2 && num < num3)
			{
				FDDHGJICCBM(DOLJCOFHGGD, FEICAJOFEII);
			}
			else if (num2 < num && num2 < num3)
			{
				EEBCAFKMPDD(NNAOBCEDCBM, LGHHDAHIHKI);
			}
			else
			{
				CDGIBKFFOFD(FJIBEKAFJBA, COLALIJOJFL);
			}
		}

		public void NEJBJIGICAI(Transform CBLFBICGAIA, float INLNMEABHBF)
		{
			if ((bool)rect)
			{
				Vector3[] sides = rect.GetSides(CBLFBICGAIA);
				float num = Mathf.Lerp(sides[6].y, sides[0].y, relative);
				absolute = Mathf.FloorToInt(INLNMEABHBF - num + 1331f);
				return;
			}
			Vector3 position = target.position;
			if (CBLFBICGAIA != null)
			{
				position = CBLFBICGAIA.InverseTransformPoint(position);
			}
			absolute = Mathf.FloorToInt(INLNMEABHBF - position.y + 1591f);
		}

		public void LDMMJIHKKFI(float FEICAJOFEII, float LGHHDAHIHKI, float COLALIJOJFL)
		{
			LDMMJIHKKFI(0f, 0.5f, 1f, FEICAJOFEII, LGHHDAHIHKI, COLALIJOJFL);
		}

		public void MCFJPKPKGPF(Transform CBLFBICGAIA, float INLNMEABHBF)
		{
			if ((bool)rect)
			{
				Vector3[] sides = rect.GetSides(CBLFBICGAIA);
				float num = Mathf.Lerp(sides[0].x, sides[2].x, relative);
				absolute = Mathf.FloorToInt(INLNMEABHBF - num + 0.5f);
				return;
			}
			Vector3 position = target.position;
			if (CBLFBICGAIA != null)
			{
				position = CBLFBICGAIA.InverseTransformPoint(position);
			}
			absolute = Mathf.FloorToInt(INLNMEABHBF - position.x + 0.5f);
		}

		public void LIJBCDKPJPP(float FJLJJCOPBEA, float LFAKBMLNBLF)
		{
			relative = FJLJJCOPBEA;
			absolute = Mathf.FloorToInt(LFAKBMLNBLF + 0.5f);
		}

		public void FDDHGJICCBM(float FJLJJCOPBEA, float LFAKBMLNBLF)
		{
			relative = FJLJJCOPBEA;
			absolute = Mathf.FloorToInt(LFAKBMLNBLF + 1279f);
		}
	}

	public enum IJGPLHJNGJC
	{
		OnEnable = 0,
		OnUpdate = 1
	}

	public AnchorPoint leftAnchor = new AnchorPoint();

	public AnchorPoint rightAnchor = new AnchorPoint(1f);

	public AnchorPoint bottomAnchor = new AnchorPoint();

	public AnchorPoint topAnchor = new AnchorPoint(1f);

	public IJGPLHJNGJC updateAnchors = IJGPLHJNGJC.OnUpdate;

	protected GameObject NOHEHMDGHHB;

	protected Transform NPLHCHNGMKF;

	protected global::MABNNPIGEPM<UIRect> JOECNDFCLJD = new global::MABNNPIGEPM<UIRect>();

	protected bool DJAFKDJINKI = true;

	protected bool BAMIBNMGNBO;

	protected bool CFCNOGOJNFC;

	protected bool HLBFCFMHMKM;

	[NonSerialized]
	public float finalAlpha = 1f;

	private UIRoot ONNMDGOJEBB;

	private UIRect IIJJJLNFCNC;

	private Camera MGKMCAPPOKH;

	private int DDHHLCDJCNM = -1;

	private bool MMJOEJJPMGF;

	private bool HOINJNLMGFH;

	private static Vector3[] OMFIAGADNDK = new Vector3[4];

	public GameObject MNIONGONBNA
	{
		get
		{
			return get_cachedGameObject();
		}
	}

	public Transform EEIMMEBDEGC
	{
		get
		{
			return get_cachedTransform();
		}
	}

	public Camera DIJGFHBJGBB
	{
		get
		{
			return get_anchorCamera();
		}
	}

	public bool GOJOEMCGCGG
	{
		get
		{
			return get_isFullyAnchored();
		}
	}

	public virtual bool CDCNFDEMOKD
	{
		get
		{
			return get_isAnchoredHorizontally();
		}
	}

	public virtual bool KLLGKADLKLL
	{
		get
		{
			return get_isAnchoredVertically();
		}
	}

	public virtual bool CNOAGFGBIJK
	{
		get
		{
			return get_canBeAnchored();
		}
	}

	public UIRect CBLFBICGAIA
	{
		get
		{
			return get_parent();
		}
	}

	public UIRoot FHBEKMLLJPI
	{
		get
		{
			return get_root();
		}
	}

	public bool FBLIGLFIJAJ
	{
		get
		{
			return get_isAnchored();
		}
	}

	public abstract float KHMMAABNHJI { get; set; }

	public abstract Vector3[] AJNDJHGBILC { get; }

	public abstract Vector3[] CENAKAENDGH { get; }

	public GameObject get_cachedGameObject()
	{
		if (NOHEHMDGHHB == null)
		{
			NOHEHMDGHHB = base.gameObject;
		}
		return NOHEHMDGHHB;
	}

	public Transform get_cachedTransform()
	{
		if (NPLHCHNGMKF == null)
		{
			NPLHCHNGMKF = base.transform;
		}
		return NPLHCHNGMKF;
	}

	public Camera get_anchorCamera()
	{
		if (!MMJOEJJPMGF)
		{
			ResetAnchors();
		}
		return MGKMCAPPOKH;
	}

	public bool get_isFullyAnchored()
	{
		return (bool)leftAnchor.target && (bool)rightAnchor.target && (bool)topAnchor.target && (bool)bottomAnchor.target;
	}

	public virtual bool get_isAnchoredHorizontally()
	{
		return (bool)leftAnchor.target || (bool)rightAnchor.target;
	}

	public virtual bool get_isAnchoredVertically()
	{
		return (bool)bottomAnchor.target || (bool)topAnchor.target;
	}

	public virtual bool get_canBeAnchored()
	{
		return true;
	}

	public UIRect get_parent()
	{
		if (!CFCNOGOJNFC)
		{
			CFCNOGOJNFC = true;
			IIJJJLNFCNC = NLDABIMKKMP.ANPDHFFNJFD<UIRect>(get_cachedTransform().parent);
		}
		return IIJJJLNFCNC;
	}

	public UIRoot get_root()
	{
		if (get_parent() != null)
		{
			return IIJJJLNFCNC.get_root();
		}
		if (!HOINJNLMGFH)
		{
			HOINJNLMGFH = true;
			ONNMDGOJEBB = NLDABIMKKMP.ANPDHFFNJFD<UIRoot>(get_cachedTransform());
		}
		return ONNMDGOJEBB;
	}

	public bool get_isAnchored()
	{
		return ((bool)leftAnchor.target || (bool)rightAnchor.target || (bool)topAnchor.target || (bool)bottomAnchor.target) && get_canBeAnchored();
	}

	public abstract float get_alpha();

	public abstract void set_alpha(float ICENKPDOHBK);

	public abstract float CalculateFinalAlpha(int HEFOBGOMLEE);

	public abstract Vector3[] get_localCorners();

	public abstract Vector3[] get_worldCorners();

	public virtual void Invalidate(bool JMCCPCFOHKC)
	{
		DJAFKDJINKI = true;
		if (JMCCPCFOHKC)
		{
			for (int i = 0; i < JOECNDFCLJD.POIJPKODPCK; i++)
			{
				JOECNDFCLJD.EDMNHDBEPMC[i].Invalidate(true);
			}
		}
	}

	public virtual Vector3[] GetSides(Transform DNIFGOKCBEL)
	{
		if (get_anchorCamera() != null)
		{
			return get_anchorCamera().EKECFKMAGNH(DNIFGOKCBEL);
		}
		Vector3 position = get_cachedTransform().position;
		for (int i = 0; i < 4; i++)
		{
			OMFIAGADNDK[i] = position;
		}
		if (DNIFGOKCBEL != null)
		{
			for (int j = 0; j < 4; j++)
			{
				OMFIAGADNDK[j] = DNIFGOKCBEL.InverseTransformPoint(OMFIAGADNDK[j]);
			}
		}
		return OMFIAGADNDK;
	}

	protected Vector3 CLKPPFFFGGB(AnchorPoint BPCPMHJJCEK, Transform FOMOIPPFLBA)
	{
		if (get_anchorCamera() == null || BPCPMHJJCEK.targetCam == null)
		{
			return get_cachedTransform().localPosition;
		}
		Vector3 vector = MGKMCAPPOKH.ViewportToWorldPoint(BPCPMHJJCEK.targetCam.WorldToViewportPoint(BPCPMHJJCEK.target.position));
		if (FOMOIPPFLBA != null)
		{
			vector = FOMOIPPFLBA.InverseTransformPoint(vector);
		}
		vector.x = Mathf.Floor(vector.x + 0.5f);
		vector.y = Mathf.Floor(vector.y + 0.5f);
		return vector;
	}

	protected virtual void OnEnable()
	{
		MMJOEJJPMGF = false;
		DDHHLCDJCNM = -1;
		if (updateAnchors == IJGPLHJNGJC.OnEnable)
		{
			HLBFCFMHMKM = true;
		}
		if (BAMIBNMGNBO)
		{
			OHHOHFAGBBF();
		}
	}

	protected virtual void OHHOHFAGBBF()
	{
		DJAFKDJINKI = true;
		HOINJNLMGFH = false;
		CFCNOGOJNFC = false;
		if (get_parent() != null)
		{
			IIJJJLNFCNC.JOECNDFCLJD.GBFCKODJEGE(this);
		}
	}

	protected virtual void OnDisable()
	{
		if ((bool)IIJJJLNFCNC)
		{
			IIJJJLNFCNC.JOECNDFCLJD.JOMMMHGABOD(this);
		}
		IIJJJLNFCNC = null;
		ONNMDGOJEBB = null;
		HOINJNLMGFH = false;
		CFCNOGOJNFC = false;
	}

	protected void Start()
	{
		BAMIBNMGNBO = true;
		OHHOHFAGBBF();
		PCIBIJNAIKF();
	}

	public void Update()
	{
		if (!MMJOEJJPMGF)
		{
			ResetAnchors();
		}
		int frameCount = Time.frameCount;
		if (DDHHLCDJCNM == frameCount)
		{
			return;
		}
		if (updateAnchors == IJGPLHJNGJC.OnUpdate || HLBFCFMHMKM)
		{
			DDHHLCDJCNM = frameCount;
			HLBFCFMHMKM = false;
			bool flag = false;
			if ((bool)leftAnchor.target)
			{
				flag = true;
				if (leftAnchor.rect != null && leftAnchor.rect.DDHHLCDJCNM != frameCount)
				{
					leftAnchor.rect.Update();
				}
			}
			if ((bool)bottomAnchor.target)
			{
				flag = true;
				if (bottomAnchor.rect != null && bottomAnchor.rect.DDHHLCDJCNM != frameCount)
				{
					bottomAnchor.rect.Update();
				}
			}
			if ((bool)rightAnchor.target)
			{
				flag = true;
				if (rightAnchor.rect != null && rightAnchor.rect.DDHHLCDJCNM != frameCount)
				{
					rightAnchor.rect.Update();
				}
			}
			if ((bool)topAnchor.target)
			{
				flag = true;
				if (topAnchor.rect != null && topAnchor.rect.DDHHLCDJCNM != frameCount)
				{
					topAnchor.rect.Update();
				}
			}
			if (flag)
			{
				ADEEMHKMJBF();
			}
		}
		DPILNPAPPKI();
	}

	public void UpdateAnchors()
	{
		if (get_isAnchored())
		{
			ADEEMHKMJBF();
		}
	}

	protected abstract void ADEEMHKMJBF();

	public void SetAnchor(Transform FFMBLAOKAKN)
	{
		leftAnchor.target = FFMBLAOKAKN;
		rightAnchor.target = FFMBLAOKAKN;
		topAnchor.target = FFMBLAOKAKN;
		bottomAnchor.target = FFMBLAOKAKN;
		ResetAnchors();
		UpdateAnchors();
	}

	public void SetAnchor(GameObject LHACFNECMNA)
	{
		Transform target = ((!(LHACFNECMNA != null)) ? null : LHACFNECMNA.transform);
		leftAnchor.target = target;
		rightAnchor.target = target;
		topAnchor.target = target;
		bottomAnchor.target = target;
		ResetAnchors();
		UpdateAnchors();
	}

	public void SetAnchor(GameObject LHACFNECMNA, int FPCKPMKLBDG, int HKAHBBIAGHM, int FADFOBCCGNM, int JINCLNOFKNM)
	{
		Transform target = ((!(LHACFNECMNA != null)) ? null : LHACFNECMNA.transform);
		leftAnchor.target = target;
		rightAnchor.target = target;
		topAnchor.target = target;
		bottomAnchor.target = target;
		leftAnchor.relative = 0f;
		rightAnchor.relative = 1f;
		bottomAnchor.relative = 0f;
		topAnchor.relative = 1f;
		leftAnchor.absolute = FPCKPMKLBDG;
		rightAnchor.absolute = FADFOBCCGNM;
		bottomAnchor.absolute = HKAHBBIAGHM;
		topAnchor.absolute = JINCLNOFKNM;
		ResetAnchors();
		UpdateAnchors();
	}

	public void ResetAnchors()
	{
		MMJOEJJPMGF = true;
		leftAnchor.rect = ((!leftAnchor.target) ? null : leftAnchor.target.GetComponent<UIRect>());
		bottomAnchor.rect = ((!bottomAnchor.target) ? null : bottomAnchor.target.GetComponent<UIRect>());
		rightAnchor.rect = ((!rightAnchor.target) ? null : rightAnchor.target.GetComponent<UIRect>());
		topAnchor.rect = ((!topAnchor.target) ? null : topAnchor.target.GetComponent<UIRect>());
		MGKMCAPPOKH = NLDABIMKKMP.MLHKJOCLJIC(get_cachedGameObject().layer);
		HMJKLHMFHBF(leftAnchor);
		HMJKLHMFHBF(bottomAnchor);
		HMJKLHMFHBF(rightAnchor);
		HMJKLHMFHBF(topAnchor);
		HLBFCFMHMKM = true;
	}

	public abstract void SetRect(float MPBOINGECFO, float OECPEJEIMHO, float KODEGPNOHNB, float JPGIEHMKOPA);

	private void HMJKLHMFHBF(AnchorPoint CNFEFNGPPED)
	{
		if (CNFEFNGPPED.target == null || CNFEFNGPPED.rect != null)
		{
			CNFEFNGPPED.targetCam = null;
		}
		else
		{
			CNFEFNGPPED.targetCam = NLDABIMKKMP.MLHKJOCLJIC(CNFEFNGPPED.target.gameObject.layer);
		}
	}

	public virtual void ParentHasChanged()
	{
		CFCNOGOJNFC = false;
		UIRect uIRect = NLDABIMKKMP.ANPDHFFNJFD<UIRect>(get_cachedTransform().parent);
		if (IIJJJLNFCNC != uIRect)
		{
			if ((bool)IIJJJLNFCNC)
			{
				IIJJJLNFCNC.JOECNDFCLJD.JOMMMHGABOD(this);
			}
			IIJJJLNFCNC = uIRect;
			if ((bool)IIJJJLNFCNC)
			{
				IIJJJLNFCNC.JOECNDFCLJD.GBFCKODJEGE(this);
			}
			HOINJNLMGFH = false;
		}
	}

	protected abstract void PCIBIJNAIKF();

	protected virtual void DPILNPAPPKI()
	{
	}
}
