using UnityEngine;

public class PostEffectGrayscale : MonoBehaviour
{
	public Shader m_shader;

	private Material ANGELBBJKNL;

	private PostEffectBase ACPCKIDKECJ;

	private void PAJOOFIAPMI()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void IHBEDNLHIHG()
	{
		Texture source = ACPCKIDKECJ.GetSource();
		RenderTexture dest = ACPCKIDKECJ.EALLIBIGHPM();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void KELLIBFLBLP()
	{
		Texture source = ACPCKIDKECJ.KDKPIBMGHGI();
		RenderTexture dest = ACPCKIDKECJ.OJGHFMEFMGE();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void CHJGEGLHOAF()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void Start()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void EBHPOBLLBKG()
	{
		Texture source = ACPCKIDKECJ.HDBAKILBPEO();
		RenderTexture dest = ACPCKIDKECJ.GFKMFMBHGPG();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void IPHHFFNCDJH()
	{
		Texture source = ACPCKIDKECJ.AJKLKGKECPH();
		RenderTexture dest = ACPCKIDKECJ.GFKMFMBHGPG();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void IPFEBDCDMFA()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void HKOHJCDHDIP()
	{
		Texture source = ACPCKIDKECJ.KGHPEJPKECL();
		RenderTexture target = ACPCKIDKECJ.GetTarget();
		Graphics.Blit(source, target, ANGELBBJKNL);
	}

	private void DJFHLFDIADN()
	{
		Texture source = ACPCKIDKECJ.GetSource();
		RenderTexture dest = ACPCKIDKECJ.CDMDELILHMC();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void FMNOLGPIIFB()
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

	private void HPCJJBPPPPN()
	{
		Texture source = ACPCKIDKECJ.GetSource();
		RenderTexture dest = ACPCKIDKECJ.GFKMFMBHGPG();
		Graphics.Blit(source, dest, ANGELBBJKNL);
	}

	private void FOGNMJLPHAI()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}
}
