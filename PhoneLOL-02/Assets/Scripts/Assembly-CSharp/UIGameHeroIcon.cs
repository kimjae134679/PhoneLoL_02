using System.Runtime.CompilerServices;
using UnityEngine;

public class UIGameHeroIcon : UIHeroIcon
{
	public UISlider m_hpSlider;

	public UISlider m_mpSlider;

	public GameObject m_cashEffect;

	private int BEDAHAIIIIN;

	public virtual void GDKGBNKCGHO()
	{
		base.FJFFMANPDJD();
	}

	public override void Update()
	{
		base.Update();
	}

	public virtual void DEFLIOMCCMA()
	{
		base.Awake();
	}

	public virtual void FMDCADHECGH()
	{
		base.DMPIIJNBDID();
		m_hpSlider.ICKFKDNHDOG(1045f);
		m_mpSlider.ICKFKDNHDOG(795f);
		UIEventTrigger component = GetComponent<UIEventTrigger>();
		component.onClick.Add(new EventDelegate(NBDGIBOKPKM));
	}

	public void EADKGAEJLAF(int CEDNFFEKGIN)
	{
		BEDAHAIIIIN = CEDNFFEKGIN;
	}

	public void SetHero(int CEDNFFEKGIN)
	{
		BEDAHAIIIIN = CEDNFFEKGIN;
	}

	public virtual void IMBGDEFOFEM()
	{
		base.DMPIIJNBDID();
		m_hpSlider.set_value(794f);
		m_mpSlider.ICKFKDNHDOG(1458f);
		UIEventTrigger component = GetComponent<UIEventTrigger>();
		component.onClick.Add(new EventDelegate(NBDGIBOKPKM));
	}

	public void DOOEDLAOIFA(int CEDNFFEKGIN)
	{
		BEDAHAIIIIN = CEDNFFEKGIN;
	}

	private void NBDGIBOKPKM()
	{
		LNBHHEGJGEJ();
	}

	public void LNBHHEGJGEJ()
	{
	}

	public override void Awake()
	{
		base.Awake();
	}

	private void OHEOIFDDBHG()
	{
		DNDGFEFEJPA();
	}

	private void NLMMOABPELA()
	{
		LNBHHEGJGEJ();
	}

	public override void Start()
	{
		base.Start();
		m_hpSlider.set_value(0f);
		m_mpSlider.set_value(0f);
		UIEventTrigger component = GetComponent<UIEventTrigger>();
		component.onClick.Add(new EventDelegate(() =>
		{
			OnClickHeroIcon();
		}));
	}

	public void OnClickHeroIcon()
	{
	}

	[CompilerGenerated]
	private void PIPLOJFBBNK()
	{
		OnClickHeroIcon();
	}

	public void DNDGFEFEJPA()
	{
	}
}
