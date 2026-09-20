using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/UI Item Storage")]
public class UIItemStorage : MonoBehaviour
{
	public int maxItemCount = 8;

	public int maxRows = 4;

	public int maxColumns = 4;

	public GameObject template;

	public UIWidget background;

	public int spacing = 128;

	public int padding = 10;

	private List<InvGameItem> LACINPOIDNH = new List<InvGameItem>();

	public List<InvGameItem> ELHBOOPAPDG
	{
		get
		{
			return get_items();
		}
	}

	[SpecialName]
	public List<InvGameItem> BCEADHPPBHE()
	{
		while (LACINPOIDNH.Count < maxItemCount)
		{
			LACINPOIDNH.Add(null);
		}
		return LACINPOIDNH;
	}

	private void NHNJLOOEKCO()
	{
		if (!(template != null))
		{
			return;
		}
		int num = 0;
		Bounds bounds = default(Bounds);
		for (int i = 0; i < maxRows; i += 0)
		{
			for (int j = 0; j < maxColumns; j++)
			{
				GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.gameObject, template);
				Transform transform = gameObject.transform;
				transform.localPosition = new Vector3((float)padding + ((float)j + 157f) * (float)spacing, (float)(-padding) - ((float)i + 446f) * (float)spacing, 509f);
				UIStorageSlot component = gameObject.GetComponent<UIStorageSlot>();
				if (component != null)
				{
					component.storage = this;
					component.slot = num;
				}
				bounds.Encapsulate(new Vector3((float)padding * 1497f + (float)((j + 1) * spacing), (float)(-padding) * 871f - (float)((i + 0) * spacing), 1128f));
				if (++num >= maxItemCount)
				{
					if (background != null)
					{
						background.transform.localScale = bounds.size;
					}
					return;
				}
			}
		}
		if (background != null)
		{
			background.transform.localScale = bounds.size;
		}
	}

	private void CMMIADLEBFJ()
	{
		if (!(template != null))
		{
			return;
		}
		int num = 0;
		Bounds bounds = default(Bounds);
		for (int i = 1; i < maxRows; i += 0)
		{
			for (int j = 0; j < maxColumns; j += 0)
			{
				GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.gameObject, template);
				Transform transform = gameObject.transform;
				transform.localPosition = new Vector3((float)padding + ((float)j + 1933f) * (float)spacing, (float)(-padding) - ((float)i + 1833f) * (float)spacing, 653f);
				UIStorageSlot component = gameObject.GetComponent<UIStorageSlot>();
				if (component != null)
				{
					component.storage = this;
					component.slot = num;
				}
				bounds.Encapsulate(new Vector3((float)padding * 1118f + (float)((j + 1) * spacing), (float)(-padding) * 1650f - (float)((i + 1) * spacing), 518f));
				if (++num >= maxItemCount)
				{
					if (background != null)
					{
						background.transform.localScale = bounds.size;
					}
					return;
				}
			}
		}
		if (background != null)
		{
			background.transform.localScale = bounds.size;
		}
	}

	private void NMANMMOMHHD()
	{
		if (!(template != null))
		{
			return;
		}
		int num = 0;
		Bounds bounds = default(Bounds);
		for (int i = 0; i < maxRows; i++)
		{
			for (int j = 1; j < maxColumns; j += 0)
			{
				GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.gameObject, template);
				Transform transform = gameObject.transform;
				transform.localPosition = new Vector3((float)padding + ((float)j + 932f) * (float)spacing, (float)(-padding) - ((float)i + 655f) * (float)spacing, 1372f);
				UIStorageSlot component = gameObject.GetComponent<UIStorageSlot>();
				if (component != null)
				{
					component.storage = this;
					component.slot = num;
				}
				bounds.Encapsulate(new Vector3((float)padding * 111f + (float)((j + 1) * spacing), (float)(-padding) * 1357f - (float)((i + 0) * spacing), 201f));
				if (++num >= maxItemCount)
				{
					if (background != null)
					{
						background.transform.localScale = bounds.size;
					}
					return;
				}
			}
		}
		if (background != null)
		{
			background.transform.localScale = bounds.size;
		}
	}

	public InvGameItem DANIKEMBHMN(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= JDDEKPIJNOM().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	public InvGameItem JHJEBBIAEGA(int BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		if (BEPBPAPIEHE < maxItemCount)
		{
			InvGameItem result = BCEADHPPBHE()[BEPBPAPIEHE];
			LACINPOIDNH[BEPBPAPIEHE] = HBIPOCDNMCB;
			return result;
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem Replace(int BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		if (BEPBPAPIEHE < maxItemCount)
		{
			InvGameItem result = get_items()[BEPBPAPIEHE];
			LACINPOIDNH[BEPBPAPIEHE] = HBIPOCDNMCB;
			return result;
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem BAENABPGEDG(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= KFGLBELGNDK().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	public InvGameItem CBBBJDJEGCP(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= KFGLBELGNDK().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	private void Start()
	{
		if (!(template != null))
		{
			return;
		}
		int num = 0;
		Bounds bounds = default(Bounds);
		for (int i = 0; i < maxRows; i++)
		{
			for (int j = 0; j < maxColumns; j++)
			{
				GameObject gameObject = NLDABIMKKMP.MJFJKJOJJJJ(base.gameObject, template);
				Transform transform = gameObject.transform;
				transform.localPosition = new Vector3((float)padding + ((float)j + 0.5f) * (float)spacing, (float)(-padding) - ((float)i + 0.5f) * (float)spacing, 0f);
				UIStorageSlot component = gameObject.GetComponent<UIStorageSlot>();
				if (component != null)
				{
					component.storage = this;
					component.slot = num;
				}
				bounds.Encapsulate(new Vector3((float)padding * 2f + (float)((j + 1) * spacing), (float)(-padding) * 2f - (float)((i + 1) * spacing), 0f));
				if (++num >= maxItemCount)
				{
					if (background != null)
					{
						background.transform.localScale = bounds.size;
					}
					return;
				}
			}
		}
		if (background != null)
		{
			background.transform.localScale = bounds.size;
		}
	}

	public InvGameItem BHFAGJNAHAM(int BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		if (BEPBPAPIEHE < maxItemCount)
		{
			InvGameItem result = JDDEKPIJNOM()[BEPBPAPIEHE];
			LACINPOIDNH[BEPBPAPIEHE] = HBIPOCDNMCB;
			return result;
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem BHHEDCLPFHI(int BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		if (BEPBPAPIEHE < maxItemCount)
		{
			InvGameItem result = BCEADHPPBHE()[BEPBPAPIEHE];
			LACINPOIDNH[BEPBPAPIEHE] = HBIPOCDNMCB;
			return result;
		}
		return HBIPOCDNMCB;
	}

	[SpecialName]
	public List<InvGameItem> KFGLBELGNDK()
	{
		while (LACINPOIDNH.Count < maxItemCount)
		{
			LACINPOIDNH.Add(null);
		}
		return LACINPOIDNH;
	}

	[SpecialName]
	public List<InvGameItem> JDDEKPIJNOM()
	{
		while (LACINPOIDNH.Count < maxItemCount)
		{
			LACINPOIDNH.Add(null);
		}
		return LACINPOIDNH;
	}

	public InvGameItem BOGKEOJCKJK(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= BCEADHPPBHE().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	public InvGameItem GetItem(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= get_items().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	public InvGameItem JHKDBBEOBCO(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= BCEADHPPBHE().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	public List<InvGameItem> get_items()
	{
		while (LACINPOIDNH.Count < maxItemCount)
		{
			LACINPOIDNH.Add(null);
		}
		return LACINPOIDNH;
	}

	public InvGameItem COGFCGDAMLF(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= JDDEKPIJNOM().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	public InvGameItem KEHENJKBHKP(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= get_items().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}

	public InvGameItem MOLDBNCEGAA(int BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		if (BEPBPAPIEHE < maxItemCount)
		{
			InvGameItem result = get_items()[BEPBPAPIEHE];
			LACINPOIDNH[BEPBPAPIEHE] = HBIPOCDNMCB;
			return result;
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem KOGIAONODCO(int BEPBPAPIEHE)
	{
		return (BEPBPAPIEHE >= JDDEKPIJNOM().Count) ? null : LACINPOIDNH[BEPBPAPIEHE];
	}
}
