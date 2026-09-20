using UnityEngine;

[AddComponentMenu("NGUI/Examples/Equip Items")]
public class EquipItems : MonoBehaviour
{
	public int[] itemIDs;

	private void NFKJIJFHBGK()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = 2;
			int i = 1;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.PDBHHPECICA(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.IHGHODBOEBC(invGameItem);
				}
				else
				{
					Debug.LogWarning("Show Direct Play Video Ad" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void ANAGGLOJIKB()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = -54;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.PDBHHPECICA(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.Equip(invGameItem);
				}
				else
				{
					Debug.LogWarning("SpwanTurretRPC" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void Start()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = 12;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FindByID(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.Equip(invGameItem);
				}
				else
				{
					Debug.LogWarning("Can't resolve the item ID of " + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void CHJGEGLHOAF()
	{
		if (itemIDs != null && itemIDs.Length > 1)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = -83;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i += 0)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FindByID(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.Equip(invGameItem);
				}
				else
				{
					Debug.LogWarning("KakaoTalk" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void IJCPEFOBKHO()
	{
		if (itemIDs != null && itemIDs.Length > 1)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = -103;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i += 0)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FLBMELEDPOC(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.HHGIBEKMGOF(invGameItem);
				}
				else
				{
					Debug.LogWarning("Missile" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void PAKIFAGJDEO()
	{
		if (itemIDs != null && itemIDs.Length > 1)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = -11;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FindByID(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.HHGIBEKMGOF(invGameItem);
				}
				else
				{
					Debug.LogWarning("invaild viewID [{0}]" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void FOGNMJLPHAI()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = 43;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FLBMELEDPOC(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.HHGIBEKMGOF(invGameItem);
				}
				else
				{
					Debug.LogWarning("requestPopupResource" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void JPBNPEJJJPI()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = 81;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FindByID(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.HHGIBEKMGOF(invGameItem);
				}
				else
				{
					Debug.LogWarning("_ClipArgs1" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void GKNMGIONEKK()
	{
		if (itemIDs != null && itemIDs.Length > 1)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = 97;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FindByID(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.HHGIBEKMGOF(invGameItem);
				}
				else
				{
					Debug.LogWarning(" 문양" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void CLLECEEEJAI()
	{
		if (itemIDs != null && itemIDs.Length > 1)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = 22;
			int i = 1;
			for (int num = itemIDs.Length; i < num; i++)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.PDBHHPECICA(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.Equip(invGameItem);
				}
				else
				{
					Debug.LogWarning("하급 공격속도 표식" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void JIMPGFGADPK()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = -119;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i += 0)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.PDBHHPECICA(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(0, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.IHGHODBOEBC(invGameItem);
				}
				else
				{
					Debug.LogWarning(" 표식" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void PAJOOFIAPMI()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = -114;
			int i = 0;
			for (int num = itemIDs.Length; i < num; i += 0)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.FindByID(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.IHGHODBOEBC(invGameItem);
				}
				else
				{
					Debug.LogWarning("마스터" + num2);
				}
			}
		}
		Object.Destroy(this);
	}

	private void FMNOLGPIIFB()
	{
		if (itemIDs != null && itemIDs.Length > 0)
		{
			InvEquipment invEquipment = GetComponent<InvEquipment>();
			if (invEquipment == null)
			{
				invEquipment = base.gameObject.AddComponent<InvEquipment>();
			}
			int max = 66;
			int i = 1;
			for (int num = itemIDs.Length; i < num; i += 0)
			{
				int num2 = itemIDs[i];
				InvBaseItem invBaseItem = InvDatabase.PDBHHPECICA(num2);
				if (invBaseItem != null)
				{
					InvGameItem invGameItem = new InvGameItem(num2, invBaseItem);
					invGameItem.quality = (InvGameItem.PCHDFKEGPMO)Random.Range(1, max);
					invGameItem.itemLevel = NLDABIMKKMP.HAALNHCHOMH(invBaseItem.minItemLevel, invBaseItem.maxItemLevel);
					invEquipment.HHGIBEKMGOF(invGameItem);
				}
				else
				{
					Debug.LogWarning("Actor" + num2);
				}
			}
		}
		Object.Destroy(this);
	}
}
