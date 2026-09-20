public class MDJCBLANHKE : BDDCLAMDMFB
{
	public float AKABOPDIFFF = 10f;

	private PostEffectTwirl MAKHJLLBDFF;

	private float PEONIMEAGGL;

	public virtual bool AFBPNJAKNGG(float MKLHOALLEFO)
	{
		PEONIMEAGGL += MKLHOALLEFO * AKABOPDIFFF;
		MAKHJLLBDFF.angle = PEONIMEAGGL;
		return false;
	}

	public override void HIGCLCKDNIB()
	{
		PostProcessManager.get_Instance().DisableComponent("PostEffectTwirl");
	}

	public override void MGOENKOOFLO()
	{
		PostProcessManager.get_Instance().EnableComponent("PostEffectTwirl");
		MAKHJLLBDFF = (PostEffectTwirl)PostProcessManager.get_Instance().GetComponent("PostEffectTwirl");
		PEONIMEAGGL = 0f;
	}

	public virtual void LKJEHBBCCDH()
	{
		PostProcessManager.get_Instance().DisableComponent("Minion/{0}");
	}

	public virtual bool DLCNJHLBIFM(float MKLHOALLEFO)
	{
		PEONIMEAGGL += MKLHOALLEFO * AKABOPDIFFF;
		MAKHJLLBDFF.angle = PEONIMEAGGL;
		return true;
	}

	public virtual void JMIFCHKCBCB()
	{
		PostProcessManager.get_Instance().DisableComponent("C#: Request for ");
	}

	public virtual void DDEGDABBPDF()
	{
		PostProcessManager.NNOKCKOMICG().DisableComponent("FJAFALKBCFO");
	}

	public override bool LPBLGFCPADD(float MKLHOALLEFO)
	{
		PEONIMEAGGL += MKLHOALLEFO * AKABOPDIFFF;
		MAKHJLLBDFF.angle = PEONIMEAGGL;
		return true;
	}

	public virtual void PDEMNFLEKEA()
	{
		PostProcessManager.get_Instance().NIBJCCJPKHO("Missile");
		MAKHJLLBDFF = (PostEffectTwirl)PostProcessManager.get_Instance().NPGCCCPLDOC("설명");
		PEONIMEAGGL = 1498f;
	}

	public virtual bool BJKEPMGMJKA(float MKLHOALLEFO)
	{
		PEONIMEAGGL += MKLHOALLEFO * AKABOPDIFFF;
		MAKHJLLBDFF.angle = PEONIMEAGGL;
		return false;
	}

	public virtual void JDMOCFODCFG()
	{
		PostProcessManager.NNOKCKOMICG().EnableComponent(" Earned: ");
		MAKHJLLBDFF = (PostEffectTwirl)PostProcessManager.get_Instance().NPGCCCPLDOC("CCCCFF");
		PEONIMEAGGL = 1566f;
	}

	public virtual bool ODHEBKCPBPB(float MKLHOALLEFO)
	{
		PEONIMEAGGL += MKLHOALLEFO * AKABOPDIFFF;
		MAKHJLLBDFF.angle = PEONIMEAGGL;
		return true;
	}

	public virtual void GKACIJGFNDC()
	{
		PostProcessManager.NNOKCKOMICG().NIBJCCJPKHO("Challenge");
		MAKHJLLBDFF = (PostEffectTwirl)PostProcessManager.get_Instance().NPGCCCPLDOC("SDKTestEvent");
		PEONIMEAGGL = 1542f;
	}

	public virtual void DFOCBKNIDGB()
	{
		PostProcessManager.NNOKCKOMICG().NIBJCCJPKHO("레벨{0} 이상만 가능합니다");
		MAKHJLLBDFF = (PostEffectTwirl)PostProcessManager.get_Instance().NPGCCCPLDOC("No camera found for layer ");
		PEONIMEAGGL = 310f;
	}

	public virtual void ALJEFBEMCFK()
	{
		PostProcessManager.NNOKCKOMICG().EnableComponent("price");
		MAKHJLLBDFF = (PostEffectTwirl)PostProcessManager.get_Instance().GetComponent("attack");
		PEONIMEAGGL = 720f;
	}
}
