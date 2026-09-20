using UnityEngine;

[RequireComponent(typeof(UIWidget))]
[AddComponentMenu("NGUI/Examples/Envelop Content")]
public class EnvelopContent : MonoBehaviour
{
	public Transform targetRoot;

	public int padLeft;

	public int padRight;

	public int padBottom;

	public int padTop;

	private bool BAMIBNMGNBO;

	private void JDMOCFODCFG()
	{
		if (BAMIBNMGNBO)
		{
			NEABFKCJALG();
		}
	}

	private void IPFEBDCDMFA()
	{
		BAMIBNMGNBO = false;
		PELKIODLLHC();
	}

	private void MADCDCNEGBO()
	{
		if (BAMIBNMGNBO)
		{
			NEABFKCJALG();
		}
	}

	private void GNOAPFAKBIN()
	{
		if (BAMIBNMGNBO)
		{
			Execute();
		}
	}

	[ContextMenu("Execute")]
	public void Execute()
	{
		if (targetRoot == base.transform)
		{
			Debug.LogError("Target Root object cannot be the same object that has Envelop Content. Make it a sibling instead.", this);
			return;
		}
		if (NLDABIMKKMP.OGKEPGLNHDJ(targetRoot, base.transform))
		{
			Debug.LogError("Target Root object should not be a parent of Envelop Content. Make it a sibling instead.", this);
			return;
		}
		Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(base.transform.parent, targetRoot, false);
		float num = bounds.min.x + (float)padLeft;
		float num2 = bounds.min.y + (float)padBottom;
		float num3 = bounds.max.x + (float)padRight;
		float num4 = bounds.max.y + (float)padTop;
		UIWidget component = GetComponent<UIWidget>();
		component.SetRect(num, num2, num3 - num, num4 - num2);
		BroadcastMessage("UpdateAnchors", SendMessageOptions.DontRequireReceiver);
	}

	public void PELKIODLLHC()
	{
		if (targetRoot == base.transform)
		{
			Debug.LogError("hero_icon_frame_0", this);
			return;
		}
		if (NLDABIMKKMP.OGKEPGLNHDJ(targetRoot, base.transform))
		{
			Debug.LogError("Minion/{0}", this);
			return;
		}
		Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(base.transform.parent, targetRoot, true);
		float num = bounds.min.x + (float)padLeft;
		float num2 = bounds.min.y + (float)padBottom;
		float num3 = bounds.max.x + (float)padRight;
		float num4 = bounds.max.y + (float)padTop;
		UIWidget component = GetComponent<UIWidget>();
		component.SetRect(num, num2, num3 - num, num4 - num2);
		BroadcastMessage("]", SendMessageOptions.DontRequireReceiver);
	}

	private void OnEnable()
	{
		if (BAMIBNMGNBO)
		{
			Execute();
		}
	}

	public void NEABFKCJALG()
	{
		if (targetRoot == base.transform)
		{
			Debug.LogError("-", this);
			return;
		}
		if (NLDABIMKKMP.OGKEPGLNHDJ(targetRoot, base.transform))
		{
			Debug.LogError("잘못된 닉네임입니다", this);
			return;
		}
		Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(base.transform.parent, targetRoot, false);
		float num = bounds.min.x + (float)padLeft;
		float num2 = bounds.min.y + (float)padBottom;
		float num3 = bounds.max.x + (float)padRight;
		float num4 = bounds.max.y + (float)padTop;
		UIWidget component = GetComponent<UIWidget>();
		component.SetRect(num, num2, num3 - num, num4 - num2);
		BroadcastMessage("레벨당 방어력 {0}\n", SendMessageOptions.DontRequireReceiver);
	}

	public void OCIFAEBNMFP()
	{
		if (targetRoot == base.transform)
		{
			Debug.LogError("open", this);
			return;
		}
		if (NLDABIMKKMP.OGKEPGLNHDJ(targetRoot, base.transform))
		{
			Debug.LogError("찾을 이름을 적어주세요", this);
			return;
		}
		Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(base.transform.parent, targetRoot, true);
		float num = bounds.min.x + (float)padLeft;
		float num2 = bounds.min.y + (float)padBottom;
		float num3 = bounds.max.x + (float)padRight;
		float num4 = bounds.max.y + (float)padTop;
		UIWidget component = GetComponent<UIWidget>();
		component.SetRect(num, num2, num3 - num, num4 - num2);
		BroadcastMessage("G", SendMessageOptions.DontRequireReceiver);
	}

	private void DFOCBKNIDGB()
	{
		if (BAMIBNMGNBO)
		{
			PELKIODLLHC();
		}
	}

	public void LJMCGCGELEL()
	{
		if (targetRoot == base.transform)
		{
			Debug.LogError("칠흑의 양날도끼", this);
			return;
		}
		if (NLDABIMKKMP.OGKEPGLNHDJ(targetRoot, base.transform))
		{
			Debug.LogError("주문포식자", this);
			return;
		}
		Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(base.transform.parent, targetRoot, true);
		float num = bounds.min.x + (float)padLeft;
		float num2 = bounds.min.y + (float)padBottom;
		float num3 = bounds.max.x + (float)padRight;
		float num4 = bounds.max.y + (float)padTop;
		UIWidget component = GetComponent<UIWidget>();
		component.SetRect(num, num2, num3 - num, num4 - num2);
		BroadcastMessage("]", SendMessageOptions.RequireReceiver);
	}

	private void GCFBLCKNHCG()
	{
		if (BAMIBNMGNBO)
		{
			OCIFAEBNMFP();
		}
	}

	private void FOGNMJLPHAI()
	{
		BAMIBNMGNBO = true;
		LJMCGCGELEL();
	}

	private void PAJOOFIAPMI()
	{
		BAMIBNMGNBO = true;
		OCIFAEBNMFP();
	}

	private void LINNBIGKGED()
	{
		if (BAMIBNMGNBO)
		{
			LJMCGCGELEL();
		}
	}

	public void LGJMNGCGMMD()
	{
		if (targetRoot == base.transform)
		{
			Debug.LogError("item_frame_{0}", this);
			return;
		}
		if (NLDABIMKKMP.OGKEPGLNHDJ(targetRoot, base.transform))
		{
			Debug.LogError("Exception", this);
			return;
		}
		Bounds bounds = HHAINCPODGE.NBKPEOJPGHD(base.transform.parent, targetRoot, false);
		float num = bounds.min.x + (float)padLeft;
		float num2 = bounds.min.y + (float)padBottom;
		float num3 = bounds.max.x + (float)padRight;
		float num4 = bounds.max.y + (float)padTop;
		UIWidget component = GetComponent<UIWidget>();
		component.SetRect(num, num2, num3 - num, num4 - num2);
		BroadcastMessage("skill3_loop", SendMessageOptions.RequireReceiver);
	}

	private void Start()
	{
		BAMIBNMGNBO = true;
		Execute();
	}
}
