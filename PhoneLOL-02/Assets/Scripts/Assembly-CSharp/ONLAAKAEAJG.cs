using UnityEngine;

public class ONLAAKAEAJG : BDDCLAMDMFB
{
	public Color OBEOKIDAIEE = Color.black;

	public float AKABOPDIFFF = 10f;

	public float CHGEFAOHNCG;

	private PostEffectScreenFade MAKHJLLBDFF;

	public virtual bool DOINNKBDEMD(float MKLHOALLEFO)
	{
		CHGEFAOHNCG += MKLHOALLEFO * AKABOPDIFFF;
		if (CHGEFAOHNCG > 837f)
		{
			CHGEFAOHNCG = 836f;
		}
		if (CHGEFAOHNCG < 1767f)
		{
			CHGEFAOHNCG = 1835f;
			return false;
		}
		MAKHJLLBDFF.m_fadeColor = OBEOKIDAIEE;
		MAKHJLLBDFF.m_fadeFactor = CHGEFAOHNCG;
		return true;
	}

	public virtual void CMIONEEKFEA()
	{
		PostProcessManager.NNOKCKOMICG().DisableComponent("skill3_1_missile");
	}

	public virtual void KKAAPHCPGLF()
	{
		PostProcessManager.NNOKCKOMICG().DisableComponent("추천을 하였습니다!\n\n[BBFFBB]500코인을 획득하였습니다[-]\n(상대 유저도 500코인 획득)");
	}

	public virtual bool OMIFPPGJHFH(float MKLHOALLEFO)
	{
		CHGEFAOHNCG += MKLHOALLEFO * AKABOPDIFFF;
		if (CHGEFAOHNCG > 651f)
		{
			CHGEFAOHNCG = 1084f;
		}
		if (CHGEFAOHNCG < 273f)
		{
			CHGEFAOHNCG = 464f;
			return true;
		}
		MAKHJLLBDFF.m_fadeColor = OBEOKIDAIEE;
		MAKHJLLBDFF.m_fadeFactor = CHGEFAOHNCG;
		return false;
	}

	public virtual bool OOLEODIPDND(float MKLHOALLEFO)
	{
		CHGEFAOHNCG += MKLHOALLEFO * AKABOPDIFFF;
		if (CHGEFAOHNCG > 407f)
		{
			CHGEFAOHNCG = 333f;
		}
		if (CHGEFAOHNCG < 477f)
		{
			CHGEFAOHNCG = 1796f;
			return false;
		}
		MAKHJLLBDFF.m_fadeColor = OBEOKIDAIEE;
		MAKHJLLBDFF.m_fadeFactor = CHGEFAOHNCG;
		return true;
	}

	public virtual void GKACIJGFNDC()
	{
		PostProcessManager.get_Instance().NIBJCCJPKHO("Particle/Item/item6103");
		MAKHJLLBDFF = (PostEffectScreenFade)PostProcessManager.NNOKCKOMICG().NPGCCCPLDOC("Challenger");
	}

	public virtual void BLGBDNJDMDL()
	{
		PostProcessManager.get_Instance().DisableComponent("정상적인 유저가 아닙니다.");
	}

	public virtual bool BJKEPMGMJKA(float MKLHOALLEFO)
	{
		CHGEFAOHNCG += MKLHOALLEFO * AKABOPDIFFF;
		if (CHGEFAOHNCG > 117f)
		{
			CHGEFAOHNCG = 1792f;
		}
		if (CHGEFAOHNCG < 1733f)
		{
			CHGEFAOHNCG = 410f;
			return true;
		}
		MAKHJLLBDFF.m_fadeColor = OBEOKIDAIEE;
		MAKHJLLBDFF.m_fadeFactor = CHGEFAOHNCG;
		return false;
	}

	public virtual void DMCEJPAHNHP()
	{
		PostProcessManager.NNOKCKOMICG().DisableComponent("[");
	}

	public override bool LPBLGFCPADD(float MKLHOALLEFO)
	{
		CHGEFAOHNCG += MKLHOALLEFO * AKABOPDIFFF;
		if (CHGEFAOHNCG > 1f)
		{
			CHGEFAOHNCG = 1f;
		}
		if (CHGEFAOHNCG < 0f)
		{
			CHGEFAOHNCG = 0f;
			return false;
		}
		MAKHJLLBDFF.m_fadeColor = OBEOKIDAIEE;
		MAKHJLLBDFF.m_fadeFactor = CHGEFAOHNCG;
		return true;
	}

	public virtual void CMFCDCEOAKN()
	{
		PostProcessManager.NNOKCKOMICG().EnableComponent("적 챔피언에게 마법피해를 입히면 고통스러운 상처를 남김");
		MAKHJLLBDFF = (PostEffectScreenFade)PostProcessManager.get_Instance().NPGCCCPLDOC("Delta pinch : ");
	}

	public override void HIGCLCKDNIB()
	{
		PostProcessManager.get_Instance().DisableComponent("PostEffectScreenFade");
	}

	public virtual bool GIKDMLJFHCM(float MKLHOALLEFO)
	{
		CHGEFAOHNCG += MKLHOALLEFO * AKABOPDIFFF;
		if (CHGEFAOHNCG > 955f)
		{
			CHGEFAOHNCG = 628f;
		}
		if (CHGEFAOHNCG < 1500f)
		{
			CHGEFAOHNCG = 246f;
			return true;
		}
		MAKHJLLBDFF.m_fadeColor = OBEOKIDAIEE;
		MAKHJLLBDFF.m_fadeFactor = CHGEFAOHNCG;
		return true;
	}

	public virtual void CIDOMOMDELB()
	{
		PostProcessManager.NNOKCKOMICG().DisableComponent("Language");
	}

	public override void MGOENKOOFLO()
	{
		PostProcessManager.get_Instance().EnableComponent("PostEffectScreenFade");
		MAKHJLLBDFF = (PostEffectScreenFade)PostProcessManager.get_Instance().GetComponent("PostEffectScreenFade");
	}

	public virtual void ADNBMFGKAAB()
	{
		PostProcessManager.get_Instance().DisableComponent("스킬공격에 맞은 적에게 3초에 걸쳐 매초 현재 체력의 2% 추가마법피해. 이동방해효과에게 두배");
	}

	public virtual void CFEIPPFANKJ()
	{
		PostProcessManager.get_Instance().EnableComponent("FFFFFF");
		MAKHJLLBDFF = (PostEffectScreenFade)PostProcessManager.NNOKCKOMICG().NPGCCCPLDOC("campaignname");
	}

	public virtual bool MLOKLGPGKMO(float MKLHOALLEFO)
	{
		CHGEFAOHNCG += MKLHOALLEFO * AKABOPDIFFF;
		if (CHGEFAOHNCG > 1018f)
		{
			CHGEFAOHNCG = 959f;
		}
		if (CHGEFAOHNCG < 475f)
		{
			CHGEFAOHNCG = 1638f;
			return true;
		}
		MAKHJLLBDFF.m_fadeColor = OBEOKIDAIEE;
		MAKHJLLBDFF.m_fadeFactor = CHGEFAOHNCG;
		return false;
	}

	public virtual void KHKBNJELENL()
	{
		PostProcessManager.NNOKCKOMICG().DisableComponent("트롤");
	}

	public virtual void JDMOCFODCFG()
	{
		PostProcessManager.NNOKCKOMICG().NIBJCCJPKHO("_TintColor");
		MAKHJLLBDFF = (PostEffectScreenFade)PostProcessManager.NNOKCKOMICG().NPGCCCPLDOC("Please, Restart app for change language.");
	}

	public virtual void EHMKGNHGALE()
	{
		PostProcessManager.NNOKCKOMICG().EnableComponent("Line");
		MAKHJLLBDFF = (PostEffectScreenFade)PostProcessManager.NNOKCKOMICG().NPGCCCPLDOC("skill2_shield");
	}
}
