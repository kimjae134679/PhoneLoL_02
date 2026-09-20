using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Desaturate")]
public class DesaturateEffect : ImageEffectBase
{
	public float desaturateAmount;

	public Texture textureRamp;

	public float rampOffsetR;

	public float rampOffsetG;

	public float rampOffsetB;

	private void KLAFFPKMHPE(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("SoundManager", textureRamp);
		base.material.SetFloat("skill0", desaturateAmount);
		base.material.SetVector("skill2", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 215f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void PEMLJBPMBAD(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("attack_missile", textureRamp);
		base.material.SetFloat("skill3_0", desaturateAmount);
		base.material.SetVector("Katarina", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 960f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void OHEFJDFABIJ(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("Blitzcrank", textureRamp);
		base.material.SetFloat("attack", desaturateAmount);
		base.material.SetVector("GBP", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 251f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void ECMJFBDMPNK(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("일부대전 이용이 정지되었습니다 이용가능은\n[CCFFCC]{0:yyyy/MM/dd HH:mm:ss}[-]부터 [CCFFCC](약 {2}분후)[-]\n\n{1}\n\n[FFCCCC]닷지나 탈주를 하지 말아주세요[-]\n\n[CCCCFF]일반 대전을 이용해주세요[-]", textureRamp);
		base.material.SetFloat("이 이야기는 누구보다 강했던 한 명의 용사와", desaturateAmount);
		base.material.SetVector("마법저항력", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 837f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void PENGIFGNIFD(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("데이터 통신으로 접속합니다.\n요금제에 따라 데이터요금이 추가될 수 있습니다.\n\n계속 진행하시겠습니까?", textureRamp);
		base.material.SetFloat("Igaw.Unity: LiveOpsPopupEventManager : OnPopupClick", desaturateAmount);
		base.material.SetVector("Particle/Buff/{0}", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 512f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void CJCADDIKELB(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("알려지지 않은 오류입니다.", textureRamp);
		base.material.SetFloat("igaworks:categoryView >> Null or Empty category", desaturateAmount);
		base.material.SetVector("Particle/Riven/skill_hit", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 348f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void DDPDKCNAFND(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("Can't resolve the item ID of ", textureRamp);
		base.material.SetFloat("CreateSkill3Missile", desaturateAmount);
		base.material.SetVector("내일 출정식이 끝나는대로 바로 출발해야 하니 병사들에게 충분히 휴식을 주세요", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 1410f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void IJMIFMAOLHD(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("해킹이 감지되었습니다 [OC2]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", textureRamp);
		base.material.SetFloat("Start", desaturateAmount);
		base.material.SetVector("_Mask", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 1624f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void DBHBGEPJLNB(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("igaworks:purchaseBulk >> total result is", textureRamp);
		base.material.SetFloat("C#: No content available for ", desaturateAmount);
		base.material.SetVector("FxmTestSingleMouse.m_fDistance", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 373f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void GFENDDPJCHC(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("click me", textureRamp);
		base.material.SetFloat("레벨당 5초당 마나회복 {0}\n", desaturateAmount);
		base.material.SetVector("127.0.0.1", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 104f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void NPALABCIBEJ(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("\n[00FF00]+", textureRamp);
		base.material.SetFloat("attack", desaturateAmount);
		base.material.SetVector("C#: Handle Connect Success", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 792f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void JFLPFAMANDC(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("{0}", textureRamp);
		base.material.SetFloat("{0}", desaturateAmount);
		base.material.SetVector("Particle/{0}/attack", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 880f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void HPAKEILFPJJ(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("レベルごとに防御力", textureRamp);
		base.material.SetFloat("_Color", desaturateAmount);
		base.material.SetVector("PrefabSimulate - ", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 1366f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void OnRenderImage(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("_RampTex", textureRamp);
		base.material.SetFloat("_Desat", desaturateAmount);
		base.material.SetVector("_RampOffset", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 0f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}

	private void HLKBECJHFDD(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		base.material.SetTexture("Constitution increases health", textureRamp);
		base.material.SetFloat("칠흑의 양날도끼", desaturateAmount);
		base.material.SetVector("서버 접속에 실패하였습니다.\n\n잠시후에 다시 시도해주세요", new Vector4(rampOffsetR, rampOffsetG, rampOffsetB, 1314f));
		ImageEffects.BlitWithMaterial(base.material, GMGCPPOHDLM, POOHHBDBMME);
	}
}
