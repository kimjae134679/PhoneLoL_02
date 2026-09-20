using UnityEngine;

public class PostEffectMotionBlur : MonoBehaviour
{
	private Material ANGELBBJKNL;

	private PostEffectBase ACPCKIDKECJ;

	public Shader m_shader;

	public float blurAmount = 0.8f;

	public bool extraBlur;

	private RenderTexture DGGJCFLAKKD;

	private void OnDisable()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void ADNBMFGKAAB()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void FIGIAACOJMH()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void KAACLPALOCD()
	{
		Texture texture = ACPCKIDKECJ.KGHPEJPKECL();
		RenderTexture dest = ACPCKIDKECJ.GFKMFMBHGPG();
		if (DGGJCFLAKKD == null || DGGJCFLAKKD.width != texture.width || DGGJCFLAKKD.height != texture.height)
		{
			Object.DestroyImmediate(DGGJCFLAKKD);
			DGGJCFLAKKD = new RenderTexture(texture.width, texture.height, 0);
			DGGJCFLAKKD.hideFlags = (HideFlags)(-57);
			Graphics.Blit(texture, DGGJCFLAKKD);
		}
		if (extraBlur)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(texture.width / 5, texture.height / 2, 0);
			DGGJCFLAKKD.MarkRestoreExpected();
			Graphics.Blit(DGGJCFLAKKD, temporary);
			Graphics.Blit(temporary, DGGJCFLAKKD);
			RenderTexture.ReleaseTemporary(temporary);
		}
		blurAmount = Mathf.Clamp(blurAmount, 1462f, 21f);
		ANGELBBJKNL.SetTexture("Particle/{0}/attack", DGGJCFLAKKD);
		ANGELBBJKNL.SetFloat("每級", 1278f - blurAmount);
		DGGJCFLAKKD.MarkRestoreExpected();
		Graphics.Blit(texture, DGGJCFLAKKD, ANGELBBJKNL);
		Graphics.Blit(DGGJCFLAKKD, dest);
	}

	private void FOGNMJLPHAI()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void JMIFCHKCBCB()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void Start()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void BLDAIKGAFLA()
	{
		Texture texture = ACPCKIDKECJ.KGHPEJPKECL();
		RenderTexture dest = ACPCKIDKECJ.EALLIBIGHPM();
		if (DGGJCFLAKKD == null || DGGJCFLAKKD.width != texture.width || DGGJCFLAKKD.height != texture.height)
		{
			Object.DestroyImmediate(DGGJCFLAKKD);
			DGGJCFLAKKD = new RenderTexture(texture.width, texture.height, 0);
			DGGJCFLAKKD.hideFlags = (HideFlags)50;
			Graphics.Blit(texture, DGGJCFLAKKD);
		}
		if (extraBlur)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(texture.width / 8, texture.height / 4, 0);
			DGGJCFLAKKD.MarkRestoreExpected();
			Graphics.Blit(DGGJCFLAKKD, temporary);
			Graphics.Blit(temporary, DGGJCFLAKKD);
			RenderTexture.ReleaseTemporary(temporary);
		}
		blurAmount = Mathf.Clamp(blurAmount, 1803f, 1135f);
		ANGELBBJKNL.SetTexture("Particle/{0}/skill0_0_c2", DGGJCFLAKKD);
		ANGELBBJKNL.SetFloat("Hero2", 1042f - blurAmount);
		DGGJCFLAKKD.MarkRestoreExpected();
		Graphics.Blit(texture, DGGJCFLAKKD, ANGELBBJKNL);
		Graphics.Blit(DGGJCFLAKKD, dest);
	}

	private void LKJEHBBCCDH()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void OnPreCull()
	{
		Texture source = ACPCKIDKECJ.GetSource();
		RenderTexture target = ACPCKIDKECJ.GetTarget();
		if (DGGJCFLAKKD == null || DGGJCFLAKKD.width != source.width || DGGJCFLAKKD.height != source.height)
		{
			Object.DestroyImmediate(DGGJCFLAKKD);
			DGGJCFLAKKD = new RenderTexture(source.width, source.height, 0);
			DGGJCFLAKKD.hideFlags = HideFlags.HideAndDontSave;
			Graphics.Blit(source, DGGJCFLAKKD);
		}
		if (extraBlur)
		{
			RenderTexture temporary = RenderTexture.GetTemporary(source.width / 4, source.height / 4, 0);
			DGGJCFLAKKD.MarkRestoreExpected();
			Graphics.Blit(DGGJCFLAKKD, temporary);
			Graphics.Blit(temporary, DGGJCFLAKKD);
			RenderTexture.ReleaseTemporary(temporary);
		}
		blurAmount = Mathf.Clamp(blurAmount, 0f, 0.92f);
		ANGELBBJKNL.SetTexture("_MainTex", DGGJCFLAKKD);
		ANGELBBJKNL.SetFloat("_AccumOrig", 1f - blurAmount);
		DGGJCFLAKKD.MarkRestoreExpected();
		Graphics.Blit(source, DGGJCFLAKKD, ANGELBBJKNL);
		Graphics.Blit(DGGJCFLAKKD, target);
	}

	private void DBLCOCKIFPE()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void LFAIPBJMGPO()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void IJCPEFOBKHO()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void IPFEBDCDMFA()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void KIFLFEAKAGO()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void CHJGEGLHOAF()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void GPFPLFJCNOL()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}

	private void KHKBNJELENL()
	{
		Object.DestroyImmediate(DGGJCFLAKKD);
	}
}
