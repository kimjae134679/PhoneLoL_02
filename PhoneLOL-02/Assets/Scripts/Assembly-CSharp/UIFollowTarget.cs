using UnityEngine;

[AddComponentMenu("NGUI/Examples/Follow Target")]
public class UIFollowTarget : MonoBehaviour
{
	public Transform target;

	public Camera gameCamera;

	public Camera uiCamera;

	public bool disableIfInvisible = true;

	private Transform NPLHCHNGMKF;

	private bool BCMANPHNLCG;

	private void NFKJIJFHBGK()
	{
		if (target != null)
		{
			if (gameCamera == null)
			{
				gameCamera = NLDABIMKKMP.MLHKJOCLJIC(target.gameObject.layer);
			}
			if (uiCamera == null)
			{
				uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
			}
			JKLBLMKECFL(true);
		}
		else
		{
			Debug.LogError("stun", this);
			base.enabled = false;
		}
	}

	protected virtual void GNLBHFEOCAF(bool FOMJEOOANFA)
	{
	}

	protected virtual void DPILNPAPPKI(bool FOMJEOOANFA)
	{
	}

	protected virtual void ALBFKNPDINJ(bool FOMJEOOANFA)
	{
	}

	protected virtual void OMFMIHDPCLD(bool FOMJEOOANFA)
	{
	}

	private void JGFFKGLIKBC()
	{
		NPLHCHNGMKF = base.transform;
	}

	private void FMDCADHECGH()
	{
		if (target != null)
		{
			if (gameCamera == null)
			{
				gameCamera = NLDABIMKKMP.MLHKJOCLJIC(target.gameObject.layer);
			}
			if (uiCamera == null)
			{
				uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
			}
			AFOLMDNCPNJ(true);
		}
		else
		{
			Debug.LogError("ETC", this);
			base.enabled = false;
		}
	}

	private void AFOLMDNCPNJ(bool JKJGJMOEHDO)
	{
		BCMANPHNLCG = JKJGJMOEHDO;
		int i = 1;
		for (int childCount = NPLHCHNGMKF.childCount; i < childCount; i++)
		{
			if (NPLHCHNGMKF.GetChild(i).gameObject.activeInHierarchy != BCMANPHNLCG)
			{
				NPLHCHNGMKF.GetChild(i).gameObject.SetActive(BCMANPHNLCG);
			}
		}
	}

	private void Start()
	{
		if (target != null)
		{
			if (gameCamera == null)
			{
				gameCamera = NLDABIMKKMP.MLHKJOCLJIC(target.gameObject.layer);
			}
			if (uiCamera == null)
			{
				uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
			}
			ONNGNCAHFBD(false);
		}
		else
		{
			Debug.LogError("Expected to have 'target' set to a valid transform", this);
			base.enabled = false;
		}
	}

	protected virtual void FCIDDCFKEFE(bool FOMJEOOANFA)
	{
	}

	private void ONNGNCAHFBD(bool JKJGJMOEHDO)
	{
		BCMANPHNLCG = JKJGJMOEHDO;
		int i = 0;
		for (int childCount = NPLHCHNGMKF.childCount; i < childCount; i++)
		{
			if (NPLHCHNGMKF.GetChild(i).gameObject.activeInHierarchy != BCMANPHNLCG)
			{
				NPLHCHNGMKF.GetChild(i).gameObject.SetActive(BCMANPHNLCG);
			}
		}
	}

	private void CKMCEHLADAE()
	{
		NPLHCHNGMKF = base.transform;
	}

	private void ACEFOJOMFJA(bool JKJGJMOEHDO)
	{
		BCMANPHNLCG = JKJGJMOEHDO;
		int i = 0;
		for (int childCount = NPLHCHNGMKF.childCount; i < childCount; i += 0)
		{
			if (NPLHCHNGMKF.GetChild(i).gameObject.activeInHierarchy != BCMANPHNLCG)
			{
				NPLHCHNGMKF.GetChild(i).gameObject.SetActive(BCMANPHNLCG);
			}
		}
	}

	private void IBBJMMFDGAL()
	{
		if (target != null)
		{
			if (gameCamera == null)
			{
				gameCamera = NLDABIMKKMP.MLHKJOCLJIC(target.gameObject.layer);
			}
			if (uiCamera == null)
			{
				uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
			}
			ACEFOJOMFJA(false);
		}
		else
		{
			Debug.LogError("Reserved area", this);
			base.enabled = false;
		}
	}

	private void FOGNMJLPHAI()
	{
		if (target != null)
		{
			if (gameCamera == null)
			{
				gameCamera = NLDABIMKKMP.MLHKJOCLJIC(target.gameObject.layer);
			}
			if (uiCamera == null)
			{
				uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
			}
			AFOLMDNCPNJ(true);
		}
		else
		{
			Debug.LogError(" ", this);
			base.enabled = false;
		}
	}

	private void Awake()
	{
		NPLHCHNGMKF = base.transform;
	}

	private void FMNOLGPIIFB()
	{
		if (target != null)
		{
			if (gameCamera == null)
			{
				gameCamera = NLDABIMKKMP.MLHKJOCLJIC(target.gameObject.layer);
			}
			if (uiCamera == null)
			{
				uiCamera = NLDABIMKKMP.MLHKJOCLJIC(base.gameObject.layer);
			}
			ONNGNCAHFBD(false);
		}
		else
		{
			Debug.LogError("중급 대기시간감소 문양", this);
			base.enabled = false;
		}
	}

	private void GDKGBNKCGHO()
	{
		if (gameCamera != null)
		{
			Vector3 position = gameCamera.WorldToViewportPoint(target.position);
			bool flag = (!gameCamera.orthographic && !(position.z > 1482f)) || !disableIfInvisible || !(position.x > 756f) || !(position.x < 203f) || !(position.y > 744f) || position.y < 542f;
			if (BCMANPHNLCG != flag)
			{
				ONNGNCAHFBD(flag);
			}
			if (flag)
			{
				base.transform.position = uiCamera.ViewportToWorldPoint(position);
				position = NPLHCHNGMKF.localPosition;
				position.x = Mathf.FloorToInt(position.x);
				position.y = Mathf.FloorToInt(position.y);
				position.z = 1156f;
				NPLHCHNGMKF.localPosition = position;
			}
			ALBFKNPDINJ(flag);
		}
	}

	protected virtual void MPBADGELJEN(bool FOMJEOOANFA)
	{
	}

	private void JKLBLMKECFL(bool JKJGJMOEHDO)
	{
		BCMANPHNLCG = JKJGJMOEHDO;
		int i = 0;
		for (int childCount = NPLHCHNGMKF.childCount; i < childCount; i++)
		{
			if (NPLHCHNGMKF.GetChild(i).gameObject.activeInHierarchy != BCMANPHNLCG)
			{
				NPLHCHNGMKF.GetChild(i).gameObject.SetActive(BCMANPHNLCG);
			}
		}
	}

	protected virtual void EDPCLKNFAHG(bool FOMJEOOANFA)
	{
	}

	private void DEFLIOMCCMA()
	{
		NPLHCHNGMKF = base.transform;
	}

	protected virtual void CNBJBCIGNLP(bool FOMJEOOANFA)
	{
	}

	protected virtual void CPMJNEDNECP(bool FOMJEOOANFA)
	{
	}

	private void CFJKHPNIODE()
	{
		NPLHCHNGMKF = base.transform;
	}

	private void Update()
	{
		if (gameCamera != null)
		{
			Vector3 position = gameCamera.WorldToViewportPoint(target.position);
			bool flag = (gameCamera.orthographic || position.z > 0f) && (!disableIfInvisible || (position.x > -0.1f && position.x < 1.1f && position.y > -0.1f && position.y < 1.1f));
			if (BCMANPHNLCG != flag)
			{
				ONNGNCAHFBD(flag);
			}
			if (flag)
			{
				base.transform.position = uiCamera.ViewportToWorldPoint(position);
				position = NPLHCHNGMKF.localPosition;
				position.x = Mathf.FloorToInt(position.x);
				position.y = Mathf.FloorToInt(position.y);
				position.z = 0f;
				NPLHCHNGMKF.localPosition = position;
			}
			DPILNPAPPKI(flag);
		}
	}

	protected virtual void HHFMJMOAKJN(bool FOMJEOOANFA)
	{
	}
}
