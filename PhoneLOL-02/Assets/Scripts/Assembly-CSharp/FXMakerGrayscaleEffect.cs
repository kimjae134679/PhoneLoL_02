using UnityEngine;

[ExecuteInEditMode]
public class FXMakerGrayscaleEffect : FXMakerImageEffectBase
{
	public Texture textureRamp;

	public float rampOffset;

	private void KLAFFPKMHPE(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		MIHGMHJPOIK().SetTexture("상급 성장 공격력 정수", textureRamp);
		FHBGOAHDONI().SetFloat("skill1_voice", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, OJNEBMKKCHJ());
	}

	private void OnRenderImage(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		IFDCGNNEIOL().SetTexture("_RampTex", textureRamp);
		IFDCGNNEIOL().SetFloat("_RampOffset", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, IFDCGNNEIOL());
	}

	private void OPHJMBIEGFH(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		JGOAEIECNKI().SetTexture("Drag me", textureRamp);
		IFDCGNNEIOL().SetFloat("_EmisColor", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, IFDCGNNEIOL());
	}

	private void PJILDLBPKID(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		ADEKMCHHGAO().SetTexture("알수 없는 오류입니다", textureRamp);
		MIHGMHJPOIK().SetFloat("거기 서라~!", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, BIJEFLDPGBA());
	}

	private void GCGOHKGDMNL(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		JABAIKOCPCB().SetTexture("attack_missile_hit", textureRamp);
		ADEKMCHHGAO().SetFloat("Delta angle : ", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, JGOAEIECNKI());
	}

	private void PENGIFGNIFD(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		JABAIKOCPCB().SetTexture(" has no material setter", textureRamp);
		JGOAEIECNKI().SetFloat("무료충전소 또는 플러스락으로 {0}코인이 충전되었습니다!", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, MIHGMHJPOIK());
	}

	private void NAGCLMIAEEP(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		MIHGMHJPOIK().SetTexture("riven_skill3", textureRamp);
		ADEKMCHHGAO().SetFloat("skill0", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, ELDKNEMIFFA());
	}

	private void ENFADIPFGIM(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		OJNEBMKKCHJ().SetTexture("skill0_1", textureRamp);
		FHBGOAHDONI().SetFloat("BankTransfer", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, ADEKMCHHGAO());
	}

	private void OHEFJDFABIJ(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		OJNEBMKKCHJ().SetTexture("zed_skill3", textureRamp);
		IFDCGNNEIOL().SetFloat("ragtime presents", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, MIHGMHJPOIK());
	}

	private void OJMPMPLIOGI(RenderTexture GMGCPPOHDLM, RenderTexture POOHHBDBMME)
	{
		FHBGOAHDONI().SetTexture("SDKTestEvent", textureRamp);
		ELDKNEMIFFA().SetFloat("Particle/{0}/skill0_0_c3", rampOffset);
		Graphics.Blit(GMGCPPOHDLM, POOHHBDBMME, BIJEFLDPGBA());
	}
}
