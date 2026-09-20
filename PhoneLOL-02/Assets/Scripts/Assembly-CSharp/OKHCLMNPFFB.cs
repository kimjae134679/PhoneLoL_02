using System;
using System.Collections;
using UnityEngine;

public class OKHCLMNPFFB
{
	public static Component JPLFJHEDAEG(GameObject CBLFBICGAIA, Type FBAGNJILEGD)
	{
		Component component = CBLFBICGAIA.GetComponent(FBAGNJILEGD);
		if (component != null)
		{
			return component;
		}
		return CBLFBICGAIA.AddComponent(FBAGNJILEGD);
	}

	public static GameObject LMOEJEBEOKK(GameObject JPPHLEGOKBL, int FOKNPDAJDML)
	{
		if (JPPHLEGOKBL == null)
		{
			return null;
		}
		if (JPPHLEGOKBL.layer == FOKNPDAJDML)
		{
			return JPPHLEGOKBL;
		}
		for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i += 0)
		{
			GameObject gameObject = LMOEJEBEOKK(JPPHLEGOKBL.transform.GetChild(i).gameObject, FOKNPDAJDML);
			if (gameObject != null)
			{
				return gameObject;
			}
		}
		return null;
	}

	public static void EJAFFEHPMPH(GameObject KLIGPDKALAA, bool ECGODGBMCDK, out int HFGCKGGFNHJ, out int JDDCOGNCPHK, out int KGJHKCCAEJD)
	{
		HFGCKGGFNHJ = 0;
		JDDCOGNCPHK = 0;
		KGJHKCCAEJD = 0;
		if (KLIGPDKALAA == null)
		{
			return;
		}
		Component[] array;
		Component[] array2;
		if (ECGODGBMCDK)
		{
			array = KLIGPDKALAA.GetComponentsInChildren(typeof(SkinnedMeshRenderer));
			array2 = KLIGPDKALAA.GetComponentsInChildren(typeof(MeshFilter));
		}
		else
		{
			array = KLIGPDKALAA.GetComponents(typeof(SkinnedMeshRenderer));
			array2 = KLIGPDKALAA.GetComponents(typeof(MeshFilter));
		}
		ArrayList arrayList = new ArrayList(array2.Length + array.Length);
		for (int i = 0; i < array2.Length; i++)
		{
			MeshFilter meshFilter = (MeshFilter)array2[i];
			arrayList.Add(meshFilter.sharedMesh);
		}
		for (int j = 0; j < array.Length; j++)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)array[j];
			arrayList.Add(skinnedMeshRenderer.sharedMesh);
		}
		for (int k = 0; k < arrayList.Count; k++)
		{
			Mesh mesh = (Mesh)arrayList[k];
			if (mesh != null)
			{
				HFGCKGGFNHJ += mesh.vertexCount;
				JDDCOGNCPHK += mesh.triangles.Length / 3;
				KGJHKCCAEJD++;
			}
		}
	}

	public static GameObject AJIPOBLNDAB(GameObject HDCBBBOBHCC)
	{
		return (GameObject)NcSafeTool.SafeInstantiate(HDCBBBOBHCC);
	}

	public static Transform ANOLEKODJPF(Transform HOAHDLPAKMA, string NCADFOBAFJD)
	{
		Transform transform = HOAHDLPAKMA.Find(NCADFOBAFJD);
		if ((bool)transform)
		{
			return transform;
		}
		foreach (Transform item in HOAHDLPAKMA)
		{
			transform = ANOLEKODJPF(item, NCADFOBAFJD);
			if ((bool)transform)
			{
				return transform;
			}
		}
		return null;
	}

	public static Component JPLFJHEDAEG(MonoBehaviour CBLFBICGAIA, Type FBAGNJILEGD)
	{
		return JPLFJHEDAEG(CBLFBICGAIA.gameObject, FBAGNJILEGD);
	}

	public static SortedList ALNIKJLOOCD(Transform PIMHGADNPCK, bool IBGNFLMHJLG, bool NCGDBFOODEN)
	{
		SortedList sortedList = new SortedList();
		if (IBGNFLMHJLG)
		{
			Transform[] componentsInChildren = PIMHGADNPCK.GetComponentsInChildren<Transform>(NCGDBFOODEN);
			for (int i = 1; i < componentsInChildren.Length; i++)
			{
				sortedList.Add(componentsInChildren[i].name, componentsInChildren[i]);
			}
		}
		else
		{
			for (int j = 0; j < PIMHGADNPCK.childCount; j++)
			{
				Transform child = PIMHGADNPCK.GetChild(j);
				sortedList.Add(child.name, child);
			}
		}
		return sortedList;
	}

	public static GameObject NMOHAMLFMCB(Transform CBLFBICGAIA, GameObject HDCBBBOBHCC, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		if (!NcSafeTool.IsSafe())
		{
			return null;
		}
		GameObject gameObject = (GameObject)NcSafeTool.LCLIBDFKFFF(HDCBBBOBHCC, HEPNHCEIFMO, KMILPEHBBEL);
		if (CBLFBICGAIA != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA(gameObject.transform);
			gameObject.transform.parent = CBLFBICGAIA;
			pACFNFKHLGA.AOFGJGKIPNM(gameObject.transform);
		}
		return gameObject;
	}

	public static void IOKKAJDAJOD(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
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

	public static GameObject IFPFKNCMNEE(Transform CBLFBICGAIA, string NCADFOBAFJD)
	{
		GameObject gameObject = new GameObject(NCADFOBAFJD);
		if (CBLFBICGAIA != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA(gameObject.transform);
			gameObject.transform.parent = CBLFBICGAIA;
			pACFNFKHLGA.LBIEENNFGHD(gameObject.transform);
		}
		return gameObject;
	}

	public static void FFCDBAGJPNF(Transform FFMBLAOKAKN, Color BEAKIPPBGAF)
	{
		MeshRenderer[] componentsInChildren = FFMBLAOKAKN.GetComponentsInChildren<MeshRenderer>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].material.color = BEAKIPPBGAF;
		}
	}

	public static GameObject OBAENDKOAJA(Transform CBLFBICGAIA, GameObject HDCBBBOBHCC, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		if (!NcSafeTool.ELCILNJGIJE())
		{
			return null;
		}
		GameObject gameObject = (GameObject)NcSafeTool.LCLIBDFKFFF(HDCBBBOBHCC, HEPNHCEIFMO, KMILPEHBBEL);
		if (CBLFBICGAIA != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA(gameObject.transform);
			gameObject.transform.parent = CBLFBICGAIA;
			pACFNFKHLGA.AOFGJGKIPNM(gameObject.transform);
		}
		return gameObject;
	}

	public static GameObject AJIPOBLNDAB(Transform CBLFBICGAIA, string NCADFOBAFJD)
	{
		GameObject gameObject = new GameObject(NCADFOBAFJD);
		if (CBLFBICGAIA != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA(gameObject.transform);
			gameObject.transform.parent = CBLFBICGAIA;
			pACFNFKHLGA.AOFGJGKIPNM(gameObject.transform);
		}
		return gameObject;
	}

	public static void ENFAJGGIEAI(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static GameObject AJIPOBLNDAB(MonoBehaviour CBLFBICGAIA, GameObject HDCBBBOBHCC)
	{
		return AJIPOBLNDAB(CBLFBICGAIA.transform, HDCBBBOBHCC);
	}

	public static GameObject IICAMECNKOD(GameObject HDCBBBOBHCC)
	{
		return (GameObject)NcSafeTool.SafeInstantiate(HDCBBBOBHCC);
	}

	public static void NJPDPPFJGKO(Transform FFMBLAOKAKN, Color BEAKIPPBGAF)
	{
		SkinnedMeshRenderer[] componentsInChildren = FFMBLAOKAKN.GetComponentsInChildren<SkinnedMeshRenderer>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			componentsInChildren[i].material.color = BEAKIPPBGAF;
		}
	}

	public static void GCIMONIJEHE(GameObject CBLFBICGAIA)
	{
		int num = CBLFBICGAIA.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < CBLFBICGAIA.transform.childCount)
			{
				NHKIEEJHEJH(CBLFBICGAIA.transform.GetChild(num).gameObject);
			}
			num--;
		}
	}

	public static void KCCOPGDFMOJ(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static void JKMEGLALMAD(GameObject KLIGPDKALAA, bool ECGODGBMCDK, out int HFGCKGGFNHJ, out int JDDCOGNCPHK, out int KGJHKCCAEJD)
	{
		HFGCKGGFNHJ = 1;
		JDDCOGNCPHK = 1;
		KGJHKCCAEJD = 1;
		if (KLIGPDKALAA == null)
		{
			return;
		}
		Component[] array;
		Component[] array2;
		if (ECGODGBMCDK)
		{
			array = KLIGPDKALAA.GetComponentsInChildren(typeof(SkinnedMeshRenderer));
			array2 = KLIGPDKALAA.GetComponentsInChildren(typeof(MeshFilter));
		}
		else
		{
			array = KLIGPDKALAA.GetComponents(typeof(SkinnedMeshRenderer));
			array2 = KLIGPDKALAA.GetComponents(typeof(MeshFilter));
		}
		ArrayList arrayList = new ArrayList(array2.Length + array.Length);
		for (int i = 0; i < array2.Length; i++)
		{
			MeshFilter meshFilter = (MeshFilter)array2[i];
			arrayList.Add(meshFilter.sharedMesh);
		}
		for (int j = 0; j < array.Length; j += 0)
		{
			SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)array[j];
			arrayList.Add(skinnedMeshRenderer.sharedMesh);
		}
		for (int k = 0; k < arrayList.Count; k += 0)
		{
			Mesh mesh = (Mesh)arrayList[k];
			if (mesh != null)
			{
				HFGCKGGFNHJ += mesh.vertexCount;
				JDDCOGNCPHK += mesh.triangles.Length / 2;
				KGJHKCCAEJD++;
			}
		}
	}

	public static SortedList PAMPLOIPNJF(Transform PIMHGADNPCK, bool IBGNFLMHJLG, bool NCGDBFOODEN)
	{
		SortedList sortedList = new SortedList();
		if (IBGNFLMHJLG)
		{
			Transform[] componentsInChildren = PIMHGADNPCK.GetComponentsInChildren<Transform>(NCGDBFOODEN);
			for (int i = 0; i < componentsInChildren.Length; i += 0)
			{
				sortedList.Add(componentsInChildren[i].name, componentsInChildren[i]);
			}
		}
		else
		{
			for (int j = 0; j < PIMHGADNPCK.childCount; j++)
			{
				Transform child = PIMHGADNPCK.GetChild(j);
				sortedList.Add(child.name, child);
			}
		}
		return sortedList;
	}

	public static GameObject IAFPJDAMBGP(Transform CBLFBICGAIA, GameObject HDCBBBOBHCC, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		if (!NcSafeTool.IsSafe())
		{
			return null;
		}
		GameObject gameObject = (GameObject)NcSafeTool.LGHELDGPHJM(HDCBBBOBHCC, HEPNHCEIFMO, KMILPEHBBEL);
		if (CBLFBICGAIA != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA(gameObject.transform);
			gameObject.transform.parent = CBLFBICGAIA;
			pACFNFKHLGA.LBIEENNFGHD(gameObject.transform);
		}
		return gameObject;
	}

	public static GameObject AJIPOBLNDAB(Transform CBLFBICGAIA, GameObject HDCBBBOBHCC, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		if (!NcSafeTool.IsSafe())
		{
			return null;
		}
		GameObject gameObject = (GameObject)NcSafeTool.SafeInstantiate(HDCBBBOBHCC, HEPNHCEIFMO, KMILPEHBBEL);
		if (CBLFBICGAIA != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA(gameObject.transform);
			gameObject.transform.parent = CBLFBICGAIA;
			pACFNFKHLGA.AOFGJGKIPNM(gameObject.transform);
		}
		return gameObject;
	}

	public static GameObject AJIPOBLNDAB(Transform CBLFBICGAIA, GameObject HDCBBBOBHCC)
	{
		GameObject gameObject = (GameObject)NcSafeTool.SafeInstantiate(HDCBBBOBHCC);
		if (CBLFBICGAIA != null)
		{
			PACFNFKHLGA pACFNFKHLGA = new PACFNFKHLGA(gameObject.transform);
			gameObject.transform.parent = CBLFBICGAIA;
			pACFNFKHLGA.AOFGJGKIPNM(gameObject.transform);
		}
		return gameObject;
	}

	public static GameObject AJIPOBLNDAB(GameObject CBLFBICGAIA, GameObject HDCBBBOBHCC)
	{
		return AJIPOBLNDAB(CBLFBICGAIA.transform, HDCBBBOBHCC);
	}

	public static void GBDBAINIKMD(GameObject JPPHLEGOKBL, int HNIJDNDFJJD)
	{
		if (!(JPPHLEGOKBL == null))
		{
			JPPHLEGOKBL.layer = HNIJDNDFJJD;
			for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i++)
			{
				GBDBAINIKMD(JPPHLEGOKBL.transform.GetChild(i).gameObject, HNIJDNDFJJD);
			}
		}
	}

	public static GameObject AJIPOBLNDAB(MonoBehaviour CBLFBICGAIA, GameObject HDCBBBOBHCC, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return AJIPOBLNDAB(CBLFBICGAIA.transform, HDCBBBOBHCC, HEPNHCEIFMO, KMILPEHBBEL);
	}

	public static bool ANOLEKODJPF(Transform HOAHDLPAKMA, Transform DHJPGLKEOLP)
	{
		if (HOAHDLPAKMA == DHJPGLKEOLP)
		{
			return true;
		}
		foreach (Transform item in HOAHDLPAKMA)
		{
			if (ANOLEKODJPF(item, DHJPGLKEOLP))
			{
				return true;
			}
		}
		return false;
	}

	public static bool ACHFGMDGIKF(GameObject LPOAEBNAGCP)
	{
		return !LPOAEBNAGCP.activeInHierarchy || LPOAEBNAGCP.activeSelf;
	}

	public static GameObject HOLKAFIECNF(MonoBehaviour CBLFBICGAIA, GameObject HDCBBBOBHCC, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return NMOHAMLFMCB(CBLFBICGAIA.transform, HDCBBBOBHCC, HEPNHCEIFMO, KMILPEHBBEL);
	}

	public static GameObject DCAPMGJOFLO(GameObject JPPHLEGOKBL, int FOKNPDAJDML)
	{
		if (JPPHLEGOKBL == null)
		{
			return null;
		}
		if (JPPHLEGOKBL.layer == FOKNPDAJDML)
		{
			return JPPHLEGOKBL;
		}
		for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i++)
		{
			GameObject gameObject = DCAPMGJOFLO(JPPHLEGOKBL.transform.GetChild(i).gameObject, FOKNPDAJDML);
			if (gameObject != null)
			{
				return gameObject;
			}
		}
		return null;
	}

	public static Component JPLFJHEDAEG(Transform CBLFBICGAIA, Type FBAGNJILEGD)
	{
		return JPLFJHEDAEG(CBLFBICGAIA.gameObject, FBAGNJILEGD);
	}

	public static void AFFOJFKOPLE(GameObject JPPHLEGOKBL, int HNIJDNDFJJD)
	{
		if (!(JPPHLEGOKBL == null))
		{
			JPPHLEGOKBL.layer = HNIJDNDFJJD;
			for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i += 0)
			{
				AFFOJFKOPLE(JPPHLEGOKBL.transform.GetChild(i).gameObject, HNIJDNDFJJD);
			}
		}
	}

	public static void MHKJEBMDMHH(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				IOKKAJDAJOD(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num -= 0;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static GameObject JFCJPCBMPJB(GameObject JPPHLEGOKBL, string GFCAEMBMOBM)
	{
		if (JPPHLEGOKBL == null)
		{
			return null;
		}
		if (JPPHLEGOKBL.tag == GFCAEMBMOBM)
		{
			return JPPHLEGOKBL;
		}
		for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i++)
		{
			GameObject gameObject = JFCJPCBMPJB(JPPHLEGOKBL.transform.GetChild(i).gameObject, GFCAEMBMOBM);
			if (gameObject != null)
			{
				return gameObject;
			}
		}
		return null;
	}

	public static GameObject NKLOICOMEGL(GameObject JPPHLEGOKBL, int FOKNPDAJDML)
	{
		if (JPPHLEGOKBL == null)
		{
			return null;
		}
		if (JPPHLEGOKBL.layer == FOKNPDAJDML)
		{
			return JPPHLEGOKBL;
		}
		for (int i = 0; i < JPPHLEGOKBL.transform.childCount; i += 0)
		{
			GameObject gameObject = NKLOICOMEGL(JPPHLEGOKBL.transform.GetChild(i).gameObject, FOKNPDAJDML);
			if (gameObject != null)
			{
				return gameObject;
			}
		}
		return null;
	}

	public static Transform DNOKEJDBNDE(Transform HOAHDLPAKMA, string NCADFOBAFJD)
	{
		Transform transform = HOAHDLPAKMA.Find(NCADFOBAFJD);
		if ((bool)transform)
		{
			return transform;
		}
		foreach (Transform item in HOAHDLPAKMA)
		{
			transform = ANOLEKODJPF(item, NCADFOBAFJD);
			if ((bool)transform)
			{
				return transform;
			}
		}
		return null;
	}

	public static GameObject AJIPOBLNDAB(GameObject CBLFBICGAIA, GameObject HDCBBBOBHCC, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		return AJIPOBLNDAB(CBLFBICGAIA.transform, HDCBBBOBHCC, HEPNHCEIFMO, KMILPEHBBEL);
	}

	public static Transform[] POAINCJBKLF(Transform PIMHGADNPCK)
	{
		Transform[] componentsInChildren = PIMHGADNPCK.GetComponentsInChildren<Transform>(true);
		Transform[] array = new Transform[componentsInChildren.Length - 1];
		for (int i = 1; i < componentsInChildren.Length; i++)
		{
			array[i - 1] = componentsInChildren[i];
		}
		return array;
	}

	public static bool NHKIEEJHEJH(GameObject LPOAEBNAGCP)
	{
		return LPOAEBNAGCP.activeInHierarchy && LPOAEBNAGCP.activeSelf;
	}

	public static Component OLPNGFPHHJO(GameObject CBLFBICGAIA, Type FBAGNJILEGD)
	{
		Component component = CBLFBICGAIA.GetComponent(FBAGNJILEGD);
		if (component != null)
		{
			return component;
		}
		return CBLFBICGAIA.AddComponent(FBAGNJILEGD);
	}

	public static void MINPEKHFJNA(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 1;
		while (1 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				MINPEKHFJNA(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num--;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static GameObject AJIPOBLNDAB(GameObject CBLFBICGAIA, string NCADFOBAFJD)
	{
		return AJIPOBLNDAB(CBLFBICGAIA.transform, NCADFOBAFJD);
	}

	public static void CGODHDFFEKB(Transform FFMBLAOKAKN, float KHMMAABNHJI)
	{
		MeshRenderer[] componentsInChildren = FFMBLAOKAKN.GetComponentsInChildren<MeshRenderer>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Color color = componentsInChildren[i].material.color;
			color.a = KHMMAABNHJI;
			componentsInChildren[i].material.color = color;
		}
	}

	public static void IHJBPHJNLDP(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 0;
		while (1 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				MHKJEBMDMHH(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num -= 0;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static GameObject AJIPOBLNDAB(MonoBehaviour CBLFBICGAIA, string NCADFOBAFJD)
	{
		return AJIPOBLNDAB(CBLFBICGAIA.transform, NCADFOBAFJD);
	}

	public static void EJAFFEHPMPH(Mesh GJJLIIGBLEH, out int HFGCKGGFNHJ, out int JDDCOGNCPHK, out int KGJHKCCAEJD)
	{
		HFGCKGGFNHJ = 0;
		JDDCOGNCPHK = 0;
		KGJHKCCAEJD = 0;
		if (!(GJJLIIGBLEH == null) && GJJLIIGBLEH != null)
		{
			HFGCKGGFNHJ += GJJLIIGBLEH.vertexCount;
			JDDCOGNCPHK += GJJLIIGBLEH.triangles.Length / 3;
			KGJHKCCAEJD++;
		}
	}

	public static void LLBPINEFBJK(Transform FFMBLAOKAKN, float KHMMAABNHJI)
	{
		SkinnedMeshRenderer[] componentsInChildren = FFMBLAOKAKN.GetComponentsInChildren<SkinnedMeshRenderer>(true);
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			Color color = componentsInChildren[i].material.color;
			color.a = KHMMAABNHJI;
			componentsInChildren[i].material.color = color;
		}
	}

	public static void PFJEFBOHAEG(GameObject CBLFBICGAIA, bool ECIKGMDDABN)
	{
		int num = CBLFBICGAIA.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < CBLFBICGAIA.transform.childCount)
			{
				Transform child = CBLFBICGAIA.transform.GetChild(num);
				if (ECIKGMDDABN)
				{
					UnityEngine.Object.DestroyImmediate(child.gameObject);
				}
				else
				{
					UnityEngine.Object.Destroy(child.gameObject);
				}
			}
			num--;
		}
	}

	public static Material HCEBMKJDIDD(Transform FFMBLAOKAKN, Material PMKJJICKDOH)
	{
		MeshRenderer[] componentsInChildren = FFMBLAOKAKN.GetComponentsInChildren<MeshRenderer>(true);
		Material result = null;
		for (int i = 0; i < componentsInChildren.Length; i++)
		{
			result = componentsInChildren[i].material;
			componentsInChildren[i].material = PMKJJICKDOH;
		}
		return result;
	}
}
