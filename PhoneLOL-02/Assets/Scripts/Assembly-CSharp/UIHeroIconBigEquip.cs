using System.Runtime.CompilerServices;
using GameServer;
using UnityEngine;

public class UIHeroIconBigEquip : MonoBehaviour
{
	private UISprite MFGGHEFHCBO;

	private NEFBHKKAMJF PLFLBNMECBJ;

	private byte PBIFCOGFJAH;

	public NEFBHKKAMJF AGBOJPFKOIJ
	{
		get
		{
			return get_m_heroInfo();
		}
		protected set
		{
			IPBKFFHGCAD(value);
		}
	}

	public byte HHFKBNJEILA
	{
		get
		{
			return get_m_equipIndex();
		}
		protected set
		{
			HAGPINECIHF(value);
		}
	}

	private void PAINCFBOPGI()
	{
		HFJCHIDCONJ(JJOLBGCKIFO(), ONPAKAOIBKG());
	}

	[SpecialName]
	public NEFBHKKAMJF JJOLBGCKIFO()
	{
		return PLFLBNMECBJ;
	}

	[SpecialName]
	protected void GEPCICOCCJA(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private void Update()
	{
	}

	private void Start()
	{
	}

	private void Refresh()
	{
		SetInfo(get_m_heroInfo(), get_m_equipIndex());
	}

	public void HFJCHIDCONJ(NEFBHKKAMJF FHPFBPNCGOC, byte MLOLMLCIOCA)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		MNEKAAAJFJB(FHPFBPNCGOC);
		HAGPINECIHF(MLOLMLCIOCA);
	}

	private void MIAPCHPDEND()
	{
		EINNCAEHIFE(JJOLBGCKIFO(), get_m_equipIndex());
	}

	protected void HAGPINECIHF(byte ICENKPDOHBK)
	{
		PBIFCOGFJAH = ICENKPDOHBK;
	}

	protected void IPBKFFHGCAD(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public void DADCIKGPDNN(NEFBHKKAMJF FHPFBPNCGOC, byte MLOLMLCIOCA)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		MNEKAAAJFJB(FHPFBPNCGOC);
		BCOONPBJBAL(MLOLMLCIOCA);
	}

	public NEFBHKKAMJF get_m_heroInfo()
	{
		return PLFLBNMECBJ;
	}

	[SpecialName]
	protected void MNEKAAAJFJB(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	[SpecialName]
	protected void BICOHOJBEIO(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private void AAOBMGOKBEK()
	{
		DADCIKGPDNN(BCIDGIAGPKI(), ONPAKAOIBKG());
	}

	public void SetInfo(NEFBHKKAMJF FHPFBPNCGOC, byte MLOLMLCIOCA)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		IPBKFFHGCAD(FHPFBPNCGOC);
		HAGPINECIHF(MLOLMLCIOCA);
	}

	[SpecialName]
	public byte ONNADKBBDON()
	{
		return PBIFCOGFJAH;
	}

	public void EINNCAEHIFE(NEFBHKKAMJF FHPFBPNCGOC, byte MLOLMLCIOCA)
	{
		MFGGHEFHCBO = GetComponent<UISprite>();
		BICOHOJBEIO(FHPFBPNCGOC);
		HAGPINECIHF(MLOLMLCIOCA);
	}

	[SpecialName]
	public byte ONPAKAOIBKG()
	{
		return PBIFCOGFJAH;
	}

	[SpecialName]
	public NEFBHKKAMJF BCIDGIAGPKI()
	{
		return PLFLBNMECBJ;
	}

	private void CDFLFBEFAIG()
	{
		SetInfo(JJOLBGCKIFO(), ONNADKBBDON());
	}

	public byte get_m_equipIndex()
	{
		return PBIFCOGFJAH;
	}

	[SpecialName]
	protected void BCOONPBJBAL(byte ICENKPDOHBK)
	{
		PBIFCOGFJAH = ICENKPDOHBK;
	}
}
