using UnityEngine;

public class PostEffectSepiaTone : MonoBehaviour
{
	public Shader m_shader;

	private Material ANGELBBJKNL;

	private PostEffectBase ACPCKIDKECJ;

	private void FOGNMJLPHAI()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void FMDCADHECGH()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void Start()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void OnPreCull()
	{
		Texture source = ACPCKIDKECJ.GetSource();
		RenderTexture target = ACPCKIDKECJ.GetTarget();
		Graphics.Blit(source, target, ANGELBBJKNL);
	}

	private void IJCPEFOBKHO()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void NMANMMOMHHD()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void DJFHLFDIADN()
	{
		Texture source = ACPCKIDKECJ.KDKPIBMGHGI();
		RenderTexture dest = ACPCKIDKECJ.GFKMFMBHGPG();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void IMBGDEFOFEM()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void OGDMCEGKBDN()
	{
		Texture source = ACPCKIDKECJ.AJKLKGKECPH();
		RenderTexture target = ACPCKIDKECJ.GetTarget();
		Graphics.Blit(source, target, ANGELBBJKNL);
	}

	private void HPCJJBPPPPN()
	{
		Texture source = ACPCKIDKECJ.AJKLKGKECPH();
		RenderTexture dest = ACPCKIDKECJ.KAKOOLAPCLP();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void KELLIBFLBLP()
	{
		Texture source = ACPCKIDKECJ.GetSource();
		RenderTexture dest = ACPCKIDKECJ.CDMDELILHMC();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}
}
