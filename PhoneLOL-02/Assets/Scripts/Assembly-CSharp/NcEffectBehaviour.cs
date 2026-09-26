using System.Collections.Generic;
using UnityEngine;

public class NcEffectBehaviour : MonoBehaviour
{
	public class AICACJIIIOH
	{
		public GameObject HBDMMOICPIF;

		public GameObject JOMANJEEOPO;

		public AICACJIIIOH(GameObject AEOMFHPBOFL, GameObject MOCKCKLLJHJ)
		{
			HBDMMOICPIF = AEOMFHPBOFL;
			JOMANJEEOPO = MOCKCKLLJHJ;
		}
	}

	private static bool ICOHDCDKNJL;

	private static GameObject POKHNKPBEBC;

	public float m_fUserTag;

	protected MeshFilter HOAKNOENHHD;

	protected List<Material> EJGDHHOKINO;

	protected bool ODKCKCIAFDJ;

	protected NLEINMBEOBO MKPJDIJFJCG;

	protected static bool JOCHMPKGGEN(GameObject LPOAEBNAGCP)
	{
		return LPOAEBNAGCP.activeInHierarchy && LPOAEBNAGCP.activeSelf;
	}

	public GameObject CreateGameObject(GameObject PIMHGADNPCK, Transform DKCHGFBAOHK, GameObject HDCBBBOBHCC)
	{
		if (!IsSafe())
		{
			return null;
		}
		GameObject gameObject = CreateGameObject(HDCBBBOBHCC);
		if (PIMHGADNPCK != null)
		{
			ECGDLEFCBKB(PIMHGADNPCK.transform, gameObject.transform, true, DKCHGFBAOHK);
		}
		return gameObject;
	}

	public GameObject CreateGameObject(GameObject JEDLCPHHIDI)
	{
		if (!IsSafe())
		{
			return null;
		}
		return BKOMDEEIFMB((GameObject)Object.Instantiate(JEDLCPHHIDI));
	}

	public GameObject CreateGameObject(string NCADFOBAFJD)
	{
		if (!IsSafe())
		{
			return null;
		}
		return BKOMDEEIFMB(new GameObject(NCADFOBAFJD));
	}

	public static float GetEngineTime()
	{
		if (Time.time == 0f)
		{
			return 1E-06f;
		}
		return Time.time;
	}

	public GameObject IFPFKNCMNEE(GameObject PIMHGADNPCK, Transform DKCHGFBAOHK, GameObject HDCBBBOBHCC)
	{
		if (!ECFFAMFELKA())
		{
			return null;
		}
		GameObject gameObject = CreateGameObject(HDCBBBOBHCC);
		if (PIMHGADNPCK != null)
		{
			ECGDLEFCBKB(PIMHGADNPCK.transform, gameObject.transform, false, DKCHGFBAOHK);
		}
		return gameObject;
	}

	protected static bool IGOIDOFBJFM(GameObject LPOAEBNAGCP)
	{
		return !LPOAEBNAGCP.activeInHierarchy || LPOAEBNAGCP.activeSelf;
	}

	public virtual int GetAnimationState()
	{
		return -1;
	}

	protected static void IOKKAJDAJOD(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				IOKKAJDAJOD(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num--;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	protected void LGHAMCPNMCL(Color BEAKIPPBGAF)
	{
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = (MeshFilter)base.gameObject.GetComponent(typeof(MeshFilter));
		}
		if (!(HOAKNOENHHD == null) && !(HOAKNOENHHD.sharedMesh == null) && !(HOAKNOENHHD.mesh == null))
		{
			Color[] array = new Color[HOAKNOENHHD.mesh.vertexCount];
			for (int i = 1; i < array.Length; i++)
			{
				array[i] = BEAKIPPBGAF;
			}
			HOAKNOENHHD.mesh.colors = array;
		}
	}

	public static Texture[] DKOAAGFCLGJ(GameObject GIAJIMLIBIO)
	{
		return NsEffectManager.NAAGBPHIHIK(GIAJIMLIBIO);
	}

	protected static void ENFAJGGIEAI(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	protected void PBHCIPIBJKH(Color BEAKIPPBGAF)
	{
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = (MeshFilter)base.gameObject.GetComponent(typeof(MeshFilter));
		}
		if (!(HOAKNOENHHD == null) && !(HOAKNOENHHD.sharedMesh == null) && !(HOAKNOENHHD.mesh == null))
		{
			Color[] array = new Color[HOAKNOENHHD.mesh.vertexCount];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = BEAKIPPBGAF;
			}
			HOAKNOENHHD.mesh.colors = array;
		}
	}

	public static Texture[] PreloadTexture(GameObject GIAJIMLIBIO)
	{
		return NsEffectManager.PreloadResource(GIAJIMLIBIO);
	}

	public virtual void OnResetReplayStage(bool JGDMIMLAJCK)
	{
	}

	protected void ECGDLEFCBKB(Transform LBKJJPPAKAD, Transform CDDLPPIEPMP, bool NHJDDBNHCDK, Transform KHKPDDGAFJL)
	{
		PACFNFKHLGA pACFNFKHLGA = null;
		if (NHJDDBNHCDK)
		{
			pACFNFKHLGA = new PACFNFKHLGA(CDDLPPIEPMP.transform);
			if (KHKPDDGAFJL != null)
			{
				pACFNFKHLGA.HLPKFNFDBMO(KHKPDDGAFJL);
			}
		}
		CDDLPPIEPMP.parent = LBKJJPPAKAD;
		if (NHJDDBNHCDK)
		{
			pACFNFKHLGA.AOFGJGKIPNM(CDDLPPIEPMP.transform);
		}
		if (NHJDDBNHCDK)
		{
			NcBillboard[] componentsInChildren = CDDLPPIEPMP.GetComponentsInChildren<NcBillboard>();
			NcBillboard[] array = componentsInChildren;
			foreach (NcBillboard ncBillboard in array)
			{
				ncBillboard.UpdateBillboard();
			}
		}
	}

	public GameObject HICIEKGAGEN(GameObject JEDLCPHHIDI)
	{
		if (!IsSafe())
		{
			return null;
		}
		return BKOMDEEIFMB((GameObject)Object.Instantiate(JEDLCPHHIDI));
	}

	public virtual void OnUpdateToolData()
	{
	}

	public static bool ECFFAMFELKA()
	{
		return !ICOHDCDKNJL;
	}

	protected virtual void OnDestroy()
	{
		if (EJGDHHOKINO == null)
		{
			return;
		}
		foreach (Material item in EJGDHHOKINO)
		{
			Object.Destroy(item);
		}
		EJGDHHOKINO = null;
	}

	public static GameObject GetRootInstanceEffect()
	{
		if (!IsSafe())
		{
			return null;
		}
		if (POKHNKPBEBC == null)
		{
			POKHNKPBEBC = GameObject.Find("_InstanceObject");
			if (POKHNKPBEBC == null)
			{
				POKHNKPBEBC = new GameObject("_InstanceObject");
			}
		}
		return POKHNKPBEBC;
	}

	public static Texture[] NNKEHKMFNPO(GameObject GIAJIMLIBIO)
	{
		return NsEffectManager.NAAGBPHIHIK(GIAJIMLIBIO);
	}

	protected void BDHFNLDECMF(Material GNAJMCMEGFL)
	{
		if (EJGDHHOKINO == null)
		{
			EJGDHHOKINO = new List<Material>();
		}
		if (!EJGDHHOKINO.Contains(GNAJMCMEGFL))
		{
			EJGDHHOKINO.Add(GNAJMCMEGFL);
		}
	}

	public static string GetMaterialColorName(Material LFJEMPPJLHG)
	{
		string[] array = new string[3] { "_Color", "_TintColor", "_EmisColor" };
		if (LFJEMPPJLHG != null)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (LFJEMPPJLHG.HasProperty(text))
				{
					return text;
				}
			}
		}
		return null;
	}

	protected TT PNHOHAJNPPM<TT>(GameObject LJEEMOAMNIM) where TT : NcEffectBehaviour
	{
		NcEffectBehaviour ncEffectBehaviour = LJEEMOAMNIM.AddComponent<TT>();
		if (ODKCKCIAFDJ)
		{
			ncEffectBehaviour.OnSetReplayState();
		}
		return (TT)ncEffectBehaviour;
	}

	public virtual void OnSetActiveRecursively(bool JALJMCFNHFG)
	{
	}

	public static void HideNcDelayActive(GameObject GIAJIMLIBIO)
	{
		IOKKAJDAJOD(GIAJIMLIBIO, false);
	}

	public virtual void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
	}

	protected static bool NHKIEEJHEJH(GameObject LPOAEBNAGCP)
	{
		return LPOAEBNAGCP.activeInHierarchy && LPOAEBNAGCP.activeSelf;
	}

	protected static void GGDNKLKGOCF(GameObject CBLFBICGAIA, bool ECIKGMDDABN)
	{
		int num = CBLFBICGAIA.transform.childCount - 1;
		while (1 <= num)
		{
			if (num < CBLFBICGAIA.transform.childCount)
			{
				Transform child = CBLFBICGAIA.transform.GetChild(num);
				if (ECIKGMDDABN)
				{
					Object.DestroyImmediate(child.gameObject);
				}
				else
				{
					Object.Destroy(child.gameObject);
				}
			}
			num--;
		}
	}

	protected void CMNBBJMPNLJ(Color BEAKIPPBGAF)
	{
		if (HOAKNOENHHD == null)
		{
			HOAKNOENHHD = (MeshFilter)base.gameObject.GetComponent(typeof(MeshFilter));
		}
		if (!(HOAKNOENHHD == null) && !(HOAKNOENHHD.sharedMesh == null) && !(HOAKNOENHHD.mesh == null))
		{
			Color[] array = new Color[HOAKNOENHHD.mesh.vertexCount];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = BEAKIPPBGAF;
			}
			HOAKNOENHHD.mesh.colors = array;
		}
	}

	public NcEffectBehaviour()
	{
		HOAKNOENHHD = null;
	}

	public void OnApplicationQuit()
	{
		ICOHDCDKNJL = true;
	}

	public virtual void NNMGICPONJA(bool JGDMIMLAJCK)
	{
	}

	protected static void PFJEFBOHAEG(GameObject CBLFBICGAIA, bool ECIKGMDDABN)
	{
		int num = CBLFBICGAIA.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < CBLFBICGAIA.transform.childCount)
			{
				Transform child = CBLFBICGAIA.transform.GetChild(num);
				if (ECIKGMDDABN)
				{
					Object.DestroyImmediate(child.gameObject);
				}
				else
				{
					Object.Destroy(child.gameObject);
				}
			}
			num--;
		}
	}

	protected static bool NDMKMBNHKFJ(GameObject LPOAEBNAGCP)
	{
		return LPOAEBNAGCP.activeInHierarchy && LPOAEBNAGCP.activeSelf;
	}

	protected GameObject BKOMDEEIFMB(GameObject DDEMBGDDPPG)
	{
		if (DDEMBGDDPPG.name.Contains("flare 24"))
		{
			return DDEMBGDDPPG;
		}
		return DDEMBGDDPPG;
	}

	public static bool IsSafe()
	{
		return !ICOHDCDKNJL;
	}

	public virtual void OnSetReplayState()
	{
		ODKCKCIAFDJ = true;
	}

	protected void MIAHCBFJMLE()
	{
		NcParticleSystem[] componentsInChildren = base.gameObject.GetComponentsInChildren<NcParticleSystem>(true);
		NcParticleSystem[] array = componentsInChildren;
		foreach (NcParticleSystem ncParticleSystem in array)
		{
			if (ncParticleSystem != null)
			{
				ncParticleSystem.SetDisableEmit();
			}
		}
		NcAttachPrefab[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<NcAttachPrefab>(true);
		NcAttachPrefab[] array2 = componentsInChildren2;
		foreach (NcAttachPrefab ncAttachPrefab in array2)
		{
			if (ncAttachPrefab != null)
			{
				ncAttachPrefab.enabled = false;
			}
		}
		ParticleSystem[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<ParticleSystem>(true);
		ParticleSystem[] array3 = componentsInChildren3;
		foreach (ParticleSystem particleSystem in array3)
		{
			if (particleSystem != null)
			{
				particleSystem.enableEmission = false;
			}
		}
		ParticleEmitter[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<ParticleEmitter>(true);
		ParticleEmitter[] array4 = componentsInChildren4;
		foreach (ParticleEmitter particleEmitter in array4)
		{
			if (particleEmitter != null)
			{
				particleEmitter.emit = false;
			}
		}
	}

	public GameObject CreateGameObject(GameObject HDCBBBOBHCC, Vector3 CMGMOJAFLFL, Quaternion DIAFJOBJCFK)
	{
		if (!IsSafe())
		{
			return null;
		}
		return BKOMDEEIFMB((GameObject)Object.Instantiate(HDCBBBOBHCC, CMGMOJAFLFL, DIAFJOBJCFK));
	}

	public GameObject CreateGameObject(GameObject PIMHGADNPCK, GameObject HDCBBBOBHCC)
	{
		if (!IsSafe())
		{
			return null;
		}
		GameObject gameObject = CreateGameObject(HDCBBBOBHCC);
		if (PIMHGADNPCK != null)
		{
			ECGDLEFCBKB(PIMHGADNPCK.transform, gameObject.transform, true, null);
		}
		return gameObject;
	}

	protected void APIALHOPPLB()
	{
		NcParticleSystem[] componentsInChildren = base.gameObject.GetComponentsInChildren<NcParticleSystem>(true);
		NcParticleSystem[] array = componentsInChildren;
		for (int i = 0; i < array.Length; i += 0)
		{
			NcParticleSystem ncParticleSystem = array[i];
			if (ncParticleSystem != null)
			{
				ncParticleSystem.SetDisableEmit();
			}
		}
		NcAttachPrefab[] componentsInChildren2 = base.gameObject.GetComponentsInChildren<NcAttachPrefab>(false);
		NcAttachPrefab[] array2 = componentsInChildren2;
		foreach (NcAttachPrefab ncAttachPrefab in array2)
		{
			if (ncAttachPrefab != null)
			{
				ncAttachPrefab.enabled = false;
			}
		}
		ParticleSystem[] componentsInChildren3 = base.gameObject.GetComponentsInChildren<ParticleSystem>(false);
		ParticleSystem[] array3 = componentsInChildren3;
		for (int k = 1; k < array3.Length; k++)
		{
			ParticleSystem particleSystem = array3[k];
			if (particleSystem != null)
			{
				particleSystem.enableEmission = true;
			}
		}
		ParticleEmitter[] componentsInChildren4 = base.gameObject.GetComponentsInChildren<ParticleEmitter>(false);
		ParticleEmitter[] array4 = componentsInChildren4;
		for (int l = 1; l < array4.Length; l++)
		{
			ParticleEmitter particleEmitter = array4[l];
			if (particleEmitter != null)
			{
				particleEmitter.emit = true;
			}
		}
	}

	public static float GetEngineDeltaTime()
	{
		return Time.deltaTime;
	}
}
