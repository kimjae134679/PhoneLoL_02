using System.Collections.Generic;
using UnityEngine;

public abstract class UIItemSlot : MonoBehaviour
{
	public UISprite icon;

	public UIWidget background;

	public UILabel label;

	public AudioClip grabSound;

	public AudioClip placeSound;

	public AudioClip errorSound;

	private InvGameItem LDHIMLFAEBA;

	private string HKIANMAIKCB = string.Empty;

	private static InvGameItem DPADEOOOBMK;

	protected abstract InvGameItem IJDFFCGIIKC { get; }

	protected abstract InvGameItem OKFJBLHDOCD();

	protected abstract InvGameItem DHCPGJEEBAF(InvGameItem HBIPOCDNMCB);

	private void MFNMCMNOAFO(bool IJOKMMKOBNG)
	{
		InvGameItem invGameItem = ((!IJOKMMKOBNG) ? null : LDHIMLFAEBA);
		if (invGameItem != null)
		{
			InvBaseItem baseItem = invGameItem.baseItem;
			if (baseItem != null)
			{
				string text = "[" + MGDLEEIDDII.CMILNJAOOCB(invGameItem.color) + "]" + invGameItem.name + "[-]\n";
				string text2 = text;
				text = text2 + "[AFAFAF]Level " + invGameItem.itemLevel + " " + baseItem.slot;
				List<InvStat> list = invGameItem.BMKGNDNOKGA();
				int i = 0;
				for (int count = list.Count; i < count; i++)
				{
					InvStat invStat = list[i];
					if (invStat.amount != 0)
					{
						text = ((invStat.amount >= 0) ? (text + "\n[00FF00]+" + invStat.amount) : (text + "\n[FF0000]" + invStat.amount));
						if (invStat.modifier == InvStat.IEGHBCJFBMO.Percent)
						{
							text += "%";
						}
						text = text + " " + invStat.id;
						text += "[-]";
					}
				}
				if (!string.IsNullOrEmpty(baseItem.description))
				{
					text = text + "\n[FF9900]" + baseItem.description;
				}
				UITooltip.ShowText(text);
				return;
			}
		}
		UITooltip.ShowText(null);
	}

	private void OnClick()
	{
		if (DPADEOOOBMK != null)
		{
			HMJLBBELIGG(null);
		}
		else if (LDHIMLFAEBA != null)
		{
			DPADEOOOBMK = DHCPGJEEBAF(null);
			if (DPADEOOOBMK != null)
			{
				NLDABIMKKMP.FANLLKDLCPF(grabSound);
			}
			LOGJALFEHAA();
		}
	}

	private void OnDrag(Vector2 ALBBEKIPKGK)
	{
		if (DPADEOOOBMK == null && LDHIMLFAEBA != null)
		{
			UICamera.currentTouch.KHODMNLKNFK = UICamera.PFDLLOPFLMM.BasedOnDelta;
			DPADEOOOBMK = DHCPGJEEBAF(null);
			NLDABIMKKMP.FANLLKDLCPF(grabSound);
			LOGJALFEHAA();
		}
	}

	private void HMJLBBELIGG(GameObject LHACFNECMNA)
	{
		InvGameItem invGameItem = DHCPGJEEBAF(DPADEOOOBMK);
		if (DPADEOOOBMK == invGameItem)
		{
			NLDABIMKKMP.FANLLKDLCPF(errorSound);
		}
		else if (invGameItem != null)
		{
			NLDABIMKKMP.FANLLKDLCPF(grabSound);
		}
		else
		{
			NLDABIMKKMP.FANLLKDLCPF(placeSound);
		}
		DPADEOOOBMK = invGameItem;
		LOGJALFEHAA();
	}

	private void LOGJALFEHAA()
	{
		if (DPADEOOOBMK != null && DPADEOOOBMK.baseItem != null)
		{
			UICursor.Set(DPADEOOOBMK.baseItem.iconAtlas, DPADEOOOBMK.baseItem.iconName);
		}
		else
		{
			UICursor.Clear();
		}
	}

	private void Update()
	{
		InvGameItem invGameItem = OKFJBLHDOCD();
		if (LDHIMLFAEBA == invGameItem)
		{
			return;
		}
		LDHIMLFAEBA = invGameItem;
		InvBaseItem invBaseItem = ((invGameItem == null) ? null : invGameItem.baseItem);
		if (label != null)
		{
			string text = ((invGameItem == null) ? null : invGameItem.name);
			if (string.IsNullOrEmpty(HKIANMAIKCB))
			{
				HKIANMAIKCB = label.get_text();
			}
			label.set_text((text == null) ? HKIANMAIKCB : text);
		}
		if (icon != null)
		{
			if (invBaseItem == null || invBaseItem.iconAtlas == null)
			{
				icon.enabled = false;
			}
			else
			{
				icon.set_atlas(invBaseItem.iconAtlas);
				icon.set_spriteName(invBaseItem.iconName);
				icon.enabled = true;
				icon.MakePixelPerfect();
			}
		}
		if (background != null)
		{
			background.set_color((invGameItem == null) ? Color.white : invGameItem.color);
		}
	}
}
