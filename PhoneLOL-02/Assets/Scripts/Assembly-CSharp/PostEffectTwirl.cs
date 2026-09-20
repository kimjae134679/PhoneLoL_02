using UnityEngine;

public class PostEffectTwirl : MonoBehaviour
{
	public Shader m_shader;

	public Vector2 radius = new Vector2(0.3f, 0.3f);

	public float angle = 50f;

	public Vector2 center = new Vector2(0.5f, 0.5f);

	private Material ANGELBBJKNL;

	private PostEffectBase ACPCKIDKECJ;

	private void IJCPEFOBKHO()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void HKOHJCDHDIP()
	{
		RenderTexture source = ACPCKIDKECJ.HDBAKILBPEO();
		RenderTexture target = ACPCKIDKECJ.GetTarget();
		ImageEffects.RenderDistortion(ANGELBBJKNL, source, target, angle, center, radius);
	}

	private void FMNOLGPIIFB()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void DMPIIJNBDID()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void NMANMMOMHHD()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void IMBGDEFOFEM()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void OnPreCull()
	{
		RenderTexture source = ACPCKIDKECJ.GetSource();
		RenderTexture target = ACPCKIDKECJ.GetTarget();
		ImageEffects.RenderDistortion(ANGELBBJKNL, source, target, angle, center, radius);
	}

	private void KELLIBFLBLP()
	{
		RenderTexture source = ACPCKIDKECJ.HDBAKILBPEO();
		RenderTexture destination = ACPCKIDKECJ.OJGHFMEFMGE();
		ImageEffects.RenderDistortion(ANGELBBJKNL, source, destination, angle, center, radius);
	}

	private void Start()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}

	private void FMDCADHECGH()
	{
		ANGELBBJKNL = new Material(m_shader);
		ACPCKIDKECJ = GetComponent<PostEffectBase>();
	}
}
