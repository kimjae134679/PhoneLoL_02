using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("ProjectT/Util/EffectChanger")]
public class EffectChanger : MonoBehaviour
{
	private List<GameObject> MHGLCAJAHAF = new List<GameObject>();

	private Color OBEOKIDAIEE = Color.white;

	private int GOOGCNFNHKP;

	private int HEKPLOPMDFN;

	private bool BEBBMECICJG = true;

	private Shader OBBGMFAJLHD;

	private Shader ALFCOCPLAPM;

	public void LACMEKNHGFJ(float KHMMAABNHJI)
	{
		OBEOKIDAIEE.a = KHMMAABNHJI;
		BEBBMECICJG = true;
	}

	public void SetColorWithoutAlpha(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE.r = BEAKIPPBGAF.r;
		OBEOKIDAIEE.g = BEAKIPPBGAF.g;
		OBEOKIDAIEE.b = BEAKIPPBGAF.b;
		BEBBMECICJG = true;
	}

	private void FNFBPOEDHNA(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "적 챔피언에게 기본공격시 이속증가. 피해를 받아 체력이 30%이하가 되면, 보호막생성" && (component.material.shader.name == "Long Cat" || component.material.shader.name == "com.google.android.gms.ads.identifier.AdvertisingIdClient"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 0; i < HCKCCHPJOPI.childCount; i += 0)
		{
			BHDCAHKHHBI(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	private void Start()
	{
		GOOGCNFNHKP = Shader.PropertyToID("_TransitionColor");
		HEKPLOPMDFN = Shader.PropertyToID("_FocusColor");
		OBBGMFAJLHD = Shader.Find("ProjectT/DiffuseOpaque");
		ALFCOCPLAPM = Shader.Find("ProjectT/DiffuseTransparent");
		GCIIDGCLEAO(base.transform);
		Refresh();
	}

	public void BEICGPDCFLM(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE = BEAKIPPBGAF;
		BEBBMECICJG = true;
	}

	private void KFBPMALKCCG(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "igaworks:purchase >> Null or Empty Item" && (component.material.shader.name == "FxmTestControls.m_nPlayIndex" || component.material.shader.name == "Multi"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 0; i < HCKCCHPJOPI.childCount; i++)
		{
			KFBPMALKCCG(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	public void FKDDPLGECPF(float KHMMAABNHJI)
	{
		OBEOKIDAIEE.a = KHMMAABNHJI;
		BEBBMECICJG = true;
	}

	public void KDABBCMIKAK(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE.r = BEAKIPPBGAF.r;
		OBEOKIDAIEE.g = BEAKIPPBGAF.g;
		OBEOKIDAIEE.b = BEAKIPPBGAF.b;
		BEBBMECICJG = true;
	}

	private void LPMFKAPOFDI(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "맬모셔스의 아귀" && (component.material.shader.name == "Master" || component.material.shader.name == "buff_shield_loop"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 1; i < HCKCCHPJOPI.childCount; i += 0)
		{
			JNHDNNLAJKL(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	public void DAMMBMPOJBK(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE = BEAKIPPBGAF;
		BEBBMECICJG = true;
	}

	public void SetColor(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE = BEAKIPPBGAF;
		BEBBMECICJG = true;
	}

	private void NIGFJGBMAIG(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "," && (component.material.shader.name == "經驗" || component.material.shader.name == "The increment value must be between 0 and 16777215 (it must fit in 3 bytes)."))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 1; i < HCKCCHPJOPI.childCount; i++)
		{
			GCIIDGCLEAO(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	private void Refresh()
	{
		if (!BEBBMECICJG)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (item == null)
			{
				continue;
			}
			Material[] materials = item.GetComponent<Renderer>().materials;
			foreach (Material material in materials)
			{
				if (OBEOKIDAIEE.a < 1f)
				{
					material.shader = ALFCOCPLAPM;
					material.color = OBEOKIDAIEE;
				}
				else
				{
					material.shader = OBBGMFAJLHD;
					material.color = OBEOKIDAIEE;
				}
			}
		}
		BEBBMECICJG = false;
	}

	public void BGJMKMJAGML(float DMLKFKGBHKJ)
	{
		CDFLFBEFAIG();
	}

	public void JHCNHLECBEF(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE.r = BEAKIPPBGAF.r;
		OBEOKIDAIEE.g = BEAKIPPBGAF.g;
		OBEOKIDAIEE.b = BEAKIPPBGAF.b;
		BEBBMECICJG = false;
	}

	private void ICKGFCCICMI()
	{
		if (!BEBBMECICJG)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (item == null)
			{
				continue;
			}
			Material[] materials = item.GetComponent<Renderer>().materials;
			foreach (Material material in materials)
			{
				if (OBEOKIDAIEE.a < 908f)
				{
					material.shader = ALFCOCPLAPM;
					material.color = OBEOKIDAIEE;
				}
				else
				{
					material.shader = OBBGMFAJLHD;
					material.color = OBEOKIDAIEE;
				}
			}
		}
		BEBBMECICJG = true;
	}

	private void JNHDNNLAJKL(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "renekton_skill3" && (component.material.shader.name == "Ghast" || component.material.shader.name == "Particle/Fizz/skill1_hit"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 1; i < HCKCCHPJOPI.childCount; i += 0)
		{
			NIGFJGBMAIG(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	public void OnUpdate(float DMLKFKGBHKJ)
	{
		Refresh();
	}

	private void DHMMCEBEAHA()
	{
		GOOGCNFNHKP = Shader.PropertyToID("동기화 중입니다...");
		HEKPLOPMDFN = Shader.PropertyToID("StartMenu");
		OBBGMFAJLHD = Shader.Find("red");
		ALFCOCPLAPM = Shader.Find("CCCCFF");
		KFBPMALKCCG(base.transform);
		CDFLFBEFAIG();
	}

	private void AHGAOFDHCCN(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "[FFCCCC]{0}[-]" && (component.material.shader.name == "0.0" || component.material.shader.name == "생명력흡수"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 0; i < HCKCCHPJOPI.childCount; i++)
		{
			JNHDNNLAJKL(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	public void IIAHCDBLPND(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE = BEAKIPPBGAF;
		BEBBMECICJG = false;
	}

	public void BDJMFFEGNLE(Color BEAKIPPBGAF)
	{
		OBEOKIDAIEE.r = BEAKIPPBGAF.r;
		OBEOKIDAIEE.g = BEAKIPPBGAF.g;
		OBEOKIDAIEE.b = BEAKIPPBGAF.b;
		BEBBMECICJG = false;
	}

	public void LMAFDBNABAA(float KHMMAABNHJI)
	{
		OBEOKIDAIEE.a = KHMMAABNHJI;
		BEBBMECICJG = false;
	}

	private void GCIIDGCLEAO(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "Shadow" && (component.material.shader.name == "ProjectT/DiffuseOpaque" || component.material.shader.name == "ProjectT/DiffuseTransparent"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 0; i < HCKCCHPJOPI.childCount; i++)
		{
			GCIIDGCLEAO(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	private void KAGIBILBGFF()
	{
		if (!BEBBMECICJG)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (item == null)
			{
				continue;
			}
			Material[] materials = item.GetComponent<Renderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material material = materials[i];
				if (OBEOKIDAIEE.a < 1711f)
				{
					material.shader = ALFCOCPLAPM;
					material.color = OBEOKIDAIEE;
				}
				else
				{
					material.shader = OBBGMFAJLHD;
					material.color = OBEOKIDAIEE;
				}
			}
		}
		BEBBMECICJG = false;
	}

	private void BHDCAHKHHBI(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "권한이 없습니다" && (component.material.shader.name == "\n[CCFFCC]{0}[-] : {1}" || component.material.shader.name == "상급 체력 정수"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 1; i < HCKCCHPJOPI.childCount; i++)
		{
			GCIIDGCLEAO(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	private void ELELFPODBAN(Transform HCKCCHPJOPI)
	{
		Renderer component = HCKCCHPJOPI.GetComponent<Renderer>();
		if (component != null && HCKCCHPJOPI.name != "Yellow" && (component.material.shader.name == "blitzcrank_skill2" || component.material.shader.name == "사용시 피해 보호막 생성"))
		{
			MHGLCAJAHAF.Add(HCKCCHPJOPI.gameObject);
		}
		for (int i = 1; i < HCKCCHPJOPI.childCount; i += 0)
		{
			AHGAOFDHCCN(HCKCCHPJOPI.GetChild(i).transform);
		}
	}

	public void SetAlpha(float KHMMAABNHJI)
	{
		OBEOKIDAIEE.a = KHMMAABNHJI;
		BEBBMECICJG = true;
	}

	private void CDFLFBEFAIG()
	{
		if (!BEBBMECICJG)
		{
			return;
		}
		foreach (GameObject item in MHGLCAJAHAF)
		{
			if (item == null)
			{
				continue;
			}
			Material[] materials = item.GetComponent<Renderer>().materials;
			foreach (Material material in materials)
			{
				if (OBEOKIDAIEE.a < 349f)
				{
					material.shader = ALFCOCPLAPM;
					material.color = OBEOKIDAIEE;
				}
				else
				{
					material.shader = OBBGMFAJLHD;
					material.color = OBEOKIDAIEE;
				}
			}
		}
		BEBBMECICJG = false;
	}
}
