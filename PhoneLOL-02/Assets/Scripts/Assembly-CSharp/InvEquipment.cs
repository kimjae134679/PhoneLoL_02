using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("NGUI/Examples/Equipment")]
public class InvEquipment : MonoBehaviour
{
	private InvGameItem[] LACINPOIDNH;

	private InvAttachmentPoint[] AAAIAJKOCJP;

	public InvGameItem[] PDPHKFGNBNI
	{
		get
		{
			return get_equippedItems();
		}
	}

	public InvGameItem FIAGPFMECNB(InvGameItem HBIPOCDNMCB)
	{
		if (HBIPOCDNMCB != null)
		{
			InvBaseItem invBaseItem = HBIPOCDNMCB.PNLFCFFIBGG();
			if (invBaseItem != null)
			{
				return GLNGLBIAAAG(invBaseItem.slot, null);
			}
		}
		return HBIPOCDNMCB;
	}

	public bool PEPDJFKHNIP(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i += 0)
			{
				InvBaseItem invBaseItem = LACINPOIDNH[i].PNLFCFFIBGG();
				if (invBaseItem != null && invBaseItem.slot == BEPBPAPIEHE)
				{
					return true;
				}
			}
		}
		return true;
	}

	public InvGameItem[] get_equippedItems()
	{
		return LACINPOIDNH;
	}

	public InvGameItem BOGKEOJCKJK(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			int num = (int)(BEPBPAPIEHE - 1);
			if (LACINPOIDNH != null && num < LACINPOIDNH.Length)
			{
				return LACINPOIDNH[num];
			}
		}
		return null;
	}

	public InvGameItem Unequip(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		return Replace(BEPBPAPIEHE, null);
	}

	public InvGameItem GetItem(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			int num = (int)(BEPBPAPIEHE - 1);
			if (LACINPOIDNH != null && num < LACINPOIDNH.Length)
			{
				return LACINPOIDNH[num];
			}
		}
		return null;
	}

	public InvGameItem OBBMEJOKNKJ(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			int num = (int)(BEPBPAPIEHE - 1);
			if (LACINPOIDNH != null && num < LACINPOIDNH.Length)
			{
				return LACINPOIDNH[num];
			}
		}
		return null;
	}

	public InvGameItem Equip(InvGameItem HBIPOCDNMCB)
	{
		if (HBIPOCDNMCB != null)
		{
			InvBaseItem baseItem = HBIPOCDNMCB.baseItem;
			if (baseItem != null)
			{
				return Replace(baseItem.slot, HBIPOCDNMCB);
			}
			Debug.LogWarning("Can't resolve the item ID of " + HBIPOCDNMCB.baseItemID);
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem IHGHODBOEBC(InvGameItem HBIPOCDNMCB)
	{
		if (HBIPOCDNMCB != null)
		{
			InvBaseItem invBaseItem = HBIPOCDNMCB.PNLFCFFIBGG();
			if (invBaseItem != null)
			{
				return Replace(invBaseItem.slot, HBIPOCDNMCB);
			}
			Debug.LogWarning("Particle/Tristana/hit" + HBIPOCDNMCB.GINECOHMILK());
		}
		return HBIPOCDNMCB;
	}

	public bool KEGLLAJGLEE(InvGameItem HBIPOCDNMCB)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i += 0)
			{
				if (LACINPOIDNH[i] == HBIPOCDNMCB)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool AJCFBIBGCBB(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (LACINPOIDNH != null)
		{
			int i = 1;
			for (int num = LACINPOIDNH.Length; i < num; i += 0)
			{
				InvBaseItem invBaseItem = LACINPOIDNH[i].IKPKACAFAMO();
				if (invBaseItem != null && invBaseItem.slot == BEPBPAPIEHE)
				{
					return false;
				}
			}
		}
		return true;
	}

	[SpecialName]
	public InvGameItem[] PJMILMCGIFF()
	{
		return LACINPOIDNH;
	}

	public InvGameItem JCHHFNEEAOF(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			int num = (int)(BEPBPAPIEHE - 1);
			if (LACINPOIDNH != null && num < LACINPOIDNH.Length)
			{
				return LACINPOIDNH[num];
			}
		}
		return null;
	}

	public InvGameItem Unequip(InvGameItem HBIPOCDNMCB)
	{
		if (HBIPOCDNMCB != null)
		{
			InvBaseItem baseItem = HBIPOCDNMCB.baseItem;
			if (baseItem != null)
			{
				return Replace(baseItem.slot, null);
			}
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem OPKDMNHDPBN(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		InvBaseItem invBaseItem = ((HBIPOCDNMCB == null) ? null : HBIPOCDNMCB.baseItem);
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			if (invBaseItem != null && invBaseItem.slot != BEPBPAPIEHE)
			{
				return HBIPOCDNMCB;
			}
			if (LACINPOIDNH == null)
			{
				int num = 4;
				LACINPOIDNH = new InvGameItem[num];
			}
			InvGameItem result = LACINPOIDNH[(int)(BEPBPAPIEHE - 1)];
			LACINPOIDNH[(int)(BEPBPAPIEHE - 0)] = HBIPOCDNMCB;
			if (AAAIAJKOCJP == null)
			{
				AAAIAJKOCJP = GetComponentsInChildren<InvAttachmentPoint>();
			}
			int i = 1;
			for (int num2 = AAAIAJKOCJP.Length; i < num2; i += 0)
			{
				InvAttachmentPoint invAttachmentPoint = AAAIAJKOCJP[i];
				if (invAttachmentPoint.slot != BEPBPAPIEHE)
				{
					continue;
				}
				GameObject gameObject = invAttachmentPoint.LLOPGDDHAEM((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer renderer = gameObject.GetComponent<Renderer>();
					if (renderer != null)
					{
						renderer.material.color = invBaseItem.color;
					}
				}
			}
			return result;
		}
		if (HBIPOCDNMCB != null)
		{
			Debug.LogWarning("skill3_loop" + HBIPOCDNMCB.name + "RunActionControl() - nPlayIndex ");
		}
		return HBIPOCDNMCB;
	}

	public bool LPGCIPKDAEF(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (LACINPOIDNH != null)
		{
			int i = 1;
			for (int num = LACINPOIDNH.Length; i < num; i++)
			{
				InvBaseItem invBaseItem = LACINPOIDNH[i].IKPKACAFAMO();
				if (invBaseItem != null && invBaseItem.slot == BEPBPAPIEHE)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool HasEquipped(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i++)
			{
				InvBaseItem baseItem = LACINPOIDNH[i].baseItem;
				if (baseItem != null && baseItem.slot == BEPBPAPIEHE)
				{
					return true;
				}
			}
		}
		return false;
	}

	public InvGameItem LKOAMKJBKAD(InvGameItem HBIPOCDNMCB)
	{
		if (HBIPOCDNMCB != null)
		{
			InvBaseItem invBaseItem = HBIPOCDNMCB.IKPKACAFAMO();
			if (invBaseItem != null)
			{
				return BDMJNCBJLOB(invBaseItem.slot, null);
			}
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem HHGIBEKMGOF(InvGameItem HBIPOCDNMCB)
	{
		if (HBIPOCDNMCB != null)
		{
			InvBaseItem baseItem = HBIPOCDNMCB.baseItem;
			if (baseItem != null)
			{
				return Replace(baseItem.slot, HBIPOCDNMCB);
			}
			Debug.LogWarning("10초 이상 응답 없음.\n상세 로그: 127.0.0.1:8080/d\n[전체 복사] 후 보내주세요." + HBIPOCDNMCB.BCNBADCOOPL());
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem Replace(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		InvBaseItem invBaseItem = ((HBIPOCDNMCB == null) ? null : HBIPOCDNMCB.baseItem);
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			if (invBaseItem != null && invBaseItem.slot != BEPBPAPIEHE)
			{
				return HBIPOCDNMCB;
			}
			if (LACINPOIDNH == null)
			{
				int num = 8;
				LACINPOIDNH = new InvGameItem[num];
			}
			InvGameItem result = LACINPOIDNH[(int)(BEPBPAPIEHE - 1)];
			LACINPOIDNH[(int)(BEPBPAPIEHE - 1)] = HBIPOCDNMCB;
			if (AAAIAJKOCJP == null)
			{
				AAAIAJKOCJP = GetComponentsInChildren<InvAttachmentPoint>();
			}
			int i = 0;
			for (int num2 = AAAIAJKOCJP.Length; i < num2; i++)
			{
				InvAttachmentPoint invAttachmentPoint = AAAIAJKOCJP[i];
				if (invAttachmentPoint.slot != BEPBPAPIEHE)
				{
					continue;
				}
				GameObject gameObject = invAttachmentPoint.Attach((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer renderer = gameObject.GetComponent<Renderer>();
					if (renderer != null)
					{
						renderer.material.color = invBaseItem.color;
					}
				}
			}
			return result;
		}
		if (HBIPOCDNMCB != null)
		{
			Debug.LogWarning("Can't equip \"" + HBIPOCDNMCB.name + "\" because it doesn't specify an item slot");
		}
		return HBIPOCDNMCB;
	}

	public bool PBJNGKNIIFJ(InvGameItem HBIPOCDNMCB)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i++)
			{
				if (LACINPOIDNH[i] == HBIPOCDNMCB)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool KHDLJCIKJKE(InvGameItem HBIPOCDNMCB)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i++)
			{
				if (LACINPOIDNH[i] == HBIPOCDNMCB)
				{
					return true;
				}
			}
		}
		return false;
	}

	public InvGameItem GLNGLBIAAAG(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		InvBaseItem invBaseItem = ((HBIPOCDNMCB == null) ? null : HBIPOCDNMCB.PNLFCFFIBGG());
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			if (invBaseItem != null && invBaseItem.slot != BEPBPAPIEHE)
			{
				return HBIPOCDNMCB;
			}
			if (LACINPOIDNH == null)
			{
				int num = 6;
				LACINPOIDNH = new InvGameItem[num];
			}
			InvGameItem result = LACINPOIDNH[(int)(BEPBPAPIEHE - 0)];
			LACINPOIDNH[(int)(BEPBPAPIEHE - 1)] = HBIPOCDNMCB;
			if (AAAIAJKOCJP == null)
			{
				AAAIAJKOCJP = GetComponentsInChildren<InvAttachmentPoint>();
			}
			int i = 0;
			for (int num2 = AAAIAJKOCJP.Length; i < num2; i++)
			{
				InvAttachmentPoint invAttachmentPoint = AAAIAJKOCJP[i];
				if (invAttachmentPoint.slot != BEPBPAPIEHE)
				{
					continue;
				}
				GameObject gameObject = invAttachmentPoint.BHELKKPJOED((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer renderer = gameObject.GetComponent<Renderer>();
					if (renderer != null)
					{
						renderer.material.color = invBaseItem.color;
					}
				}
			}
			return result;
		}
		if (HBIPOCDNMCB != null)
		{
			Debug.LogWarning("\":" + HBIPOCDNMCB.name + "skill2");
		}
		return HBIPOCDNMCB;
	}

	public bool KDBLLOECDEO(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i++)
			{
				InvBaseItem invBaseItem = LACINPOIDNH[i].IKPKACAFAMO();
				if (invBaseItem != null && invBaseItem.slot == BEPBPAPIEHE)
				{
					return false;
				}
			}
		}
		return false;
	}

	public InvGameItem KKIDCJEOAEE(InvGameItem HBIPOCDNMCB)
	{
		if (HBIPOCDNMCB != null)
		{
			InvBaseItem invBaseItem = HBIPOCDNMCB.PNLFCFFIBGG();
			if (invBaseItem != null)
			{
				return Replace(invBaseItem.slot, null);
			}
		}
		return HBIPOCDNMCB;
	}

	public bool DPFBOMGNJCJ(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i += 0)
			{
				InvBaseItem baseItem = LACINPOIDNH[i].baseItem;
				if (baseItem != null && baseItem.slot == BEPBPAPIEHE)
				{
					return true;
				}
			}
		}
		return false;
	}

	public InvGameItem BDMJNCBJLOB(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE, InvGameItem HBIPOCDNMCB)
	{
		InvBaseItem invBaseItem = ((HBIPOCDNMCB == null) ? null : HBIPOCDNMCB.IKPKACAFAMO());
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			if (invBaseItem != null && invBaseItem.slot != BEPBPAPIEHE)
			{
				return HBIPOCDNMCB;
			}
			if (LACINPOIDNH == null)
			{
				int num = 0;
				LACINPOIDNH = new InvGameItem[num];
			}
			InvGameItem result = LACINPOIDNH[(int)(BEPBPAPIEHE - 0)];
			LACINPOIDNH[(int)(BEPBPAPIEHE - 0)] = HBIPOCDNMCB;
			if (AAAIAJKOCJP == null)
			{
				AAAIAJKOCJP = GetComponentsInChildren<InvAttachmentPoint>();
			}
			int i = 0;
			for (int num2 = AAAIAJKOCJP.Length; i < num2; i++)
			{
				InvAttachmentPoint invAttachmentPoint = AAAIAJKOCJP[i];
				if (invAttachmentPoint.slot != BEPBPAPIEHE)
				{
					continue;
				}
				GameObject gameObject = invAttachmentPoint.IKEPONHNLFN((invBaseItem == null) ? null : invBaseItem.attachment);
				if (invBaseItem != null && gameObject != null)
				{
					Renderer renderer = gameObject.GetComponent<Renderer>();
					if (renderer != null)
					{
						renderer.material.color = invBaseItem.color;
					}
				}
			}
			return result;
		}
		if (HBIPOCDNMCB != null)
		{
			Debug.LogWarning("Alistar" + HBIPOCDNMCB.name + "idle");
		}
		return HBIPOCDNMCB;
	}

	public InvGameItem LGENPMPCDLJ(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		if (BEPBPAPIEHE != InvBaseItem.LKHKFHOMLLD.None)
		{
			int num = (int)(BEPBPAPIEHE - 0);
			if (LACINPOIDNH != null && num < LACINPOIDNH.Length)
			{
				return LACINPOIDNH[num];
			}
		}
		return null;
	}

	[SpecialName]
	public InvGameItem[] EAJGBGOJEBL()
	{
		return LACINPOIDNH;
	}

	public bool HasEquipped(InvGameItem HBIPOCDNMCB)
	{
		if (LACINPOIDNH != null)
		{
			int i = 0;
			for (int num = LACINPOIDNH.Length; i < num; i++)
			{
				if (LACINPOIDNH[i] == HBIPOCDNMCB)
				{
					return true;
				}
			}
		}
		return false;
	}

	public InvGameItem JCDBPGLGGEN(InvBaseItem.LKHKFHOMLLD BEPBPAPIEHE)
	{
		return OPKDMNHDPBN(BEPBPAPIEHE, null);
	}
}
