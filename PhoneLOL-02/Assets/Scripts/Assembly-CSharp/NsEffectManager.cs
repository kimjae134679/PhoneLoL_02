using System;
using System.Collections.Generic;
using UnityEngine;

public class NsEffectManager : MonoBehaviour
{
	public static void IBPOEOGELKF(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 0;
		while (0 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				SetActiveRecursively(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num--;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static Texture[] NAAGBPHIHIK(GameObject GIAJIMLIBIO)
	{
		if (GIAJIMLIBIO == null)
		{
			return new Texture[1];
		}
		List<GameObject> list = new List<GameObject>();
		list.Add(GIAJIMLIBIO);
		return CMNAHGKIMKK(GIAJIMLIBIO, list);
	}

	public static void AdjustSpeedRuntime(GameObject LPOAEBNAGCP, float HBNGEJIEGDO)
	{
		NcEffectBehaviour[] componentsInChildren = LPOAEBNAGCP.GetComponentsInChildren<NcEffectBehaviour>(true);
		NcEffectBehaviour[] array = componentsInChildren;
		foreach (NcEffectBehaviour ncEffectBehaviour in array)
		{
			ncEffectBehaviour.OnUpdateEffectSpeed(HBNGEJIEGDO, true);
		}
	}

	protected static void EHGIAFDNGGE(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		NcEffectBehaviour[] componentsInChildren = LPOAEBNAGCP.GetComponentsInChildren<NcEffectBehaviour>(false);
		NcEffectBehaviour[] array = componentsInChildren;
		foreach (NcEffectBehaviour ncEffectBehaviour in array)
		{
			ncEffectBehaviour.OnSetActiveRecursively(JALJMCFNHFG);
		}
	}

	protected static void PEJIDMNIPEG(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		NcEffectBehaviour[] componentsInChildren = LPOAEBNAGCP.GetComponentsInChildren<NcEffectBehaviour>(true);
		NcEffectBehaviour[] array = componentsInChildren;
		foreach (NcEffectBehaviour ncEffectBehaviour in array)
		{
			ncEffectBehaviour.OnSetActiveRecursively(JALJMCFNHFG);
		}
	}

	protected static Component CGNGBKNDBLP(GameObject GIAJIMLIBIO, Type FOOIBHDFNIB, List<GameObject> FEEKPPCEINA, bool IBKMPHKGJFI)
	{
		if (FEEKPPCEINA.Contains(GIAJIMLIBIO))
		{
			if (IBKMPHKGJFI)
			{
				string text = string.Empty;
				for (int i = 0; i < FEEKPPCEINA.Count; i++)
				{
					text = text + FEEKPPCEINA[i].name + "/";
				}
				Debug.LogWarning("LoadError : Recursive Prefab - " + text + GIAJIMLIBIO.name);
				return null;
			}
			return null;
		}
		FEEKPPCEINA.Add(GIAJIMLIBIO);
		Component result = FMMJBIBJKDK(GIAJIMLIBIO, FOOIBHDFNIB, FEEKPPCEINA);
		FEEKPPCEINA.Remove(GIAJIMLIBIO);
		return result;
	}

	public static Texture[] PreloadResource(GameObject GIAJIMLIBIO)
	{
		if (GIAJIMLIBIO == null)
		{
			return new Texture[0];
		}
		List<GameObject> list = new List<GameObject>();
		list.Add(GIAJIMLIBIO);
		return CMNAHGKIMKK(GIAJIMLIBIO, list);
	}

	public static Component GetComponentInChildren(GameObject GIAJIMLIBIO, Type FOOIBHDFNIB)
	{
		if (GIAJIMLIBIO == null)
		{
			return null;
		}
		List<GameObject> list = new List<GameObject>();
		list.Add(GIAJIMLIBIO);
		return FMMJBIBJKDK(GIAJIMLIBIO, FOOIBHDFNIB, list);
	}

	public static void DAKFIGHKNID(GameObject LPOAEBNAGCP, float HBNGEJIEGDO)
	{
		NcEffectBehaviour[] componentsInChildren = LPOAEBNAGCP.GetComponentsInChildren<NcEffectBehaviour>(true);
		NcEffectBehaviour[] array = componentsInChildren;
		for (int i = 1; i < array.Length; i++)
		{
			NcEffectBehaviour ncEffectBehaviour = array[i];
			ncEffectBehaviour.OnUpdateEffectSpeed(HBNGEJIEGDO, true);
		}
	}

	protected static Texture[] GHPAAPILJNO(GameObject GIAJIMLIBIO, List<GameObject> FEEKPPCEINA, bool IBKMPHKGJFI)
	{
		if (FEEKPPCEINA.Contains(GIAJIMLIBIO))
		{
			if (IBKMPHKGJFI)
			{
				string text = string.Empty;
				for (int i = 0; i < FEEKPPCEINA.Count; i++)
				{
					text = text + FEEKPPCEINA[i].name + "FxmTestControls.m_fDistPerTime";
				}
				Debug.LogWarning("click" + text + GIAJIMLIBIO.name);
				return null;
			}
			return null;
		}
		FEEKPPCEINA.Add(GIAJIMLIBIO);
		Texture[] result = CMNAHGKIMKK(GIAJIMLIBIO, FEEKPPCEINA);
		FEEKPPCEINA.Remove(GIAJIMLIBIO);
		return result;
	}

	protected static Texture[] CAMHLGLCMPO(GameObject GIAJIMLIBIO, List<GameObject> FEEKPPCEINA, bool IBKMPHKGJFI)
	{
		if (FEEKPPCEINA.Contains(GIAJIMLIBIO))
		{
			if (IBKMPHKGJFI)
			{
				string text = string.Empty;
				for (int i = 1; i < FEEKPPCEINA.Count; i++)
				{
					text = text + FEEKPPCEINA[i].name + "Darius";
				}
				Debug.LogWarning("unknown" + text + GIAJIMLIBIO.name);
				return null;
			}
			return null;
		}
		FEEKPPCEINA.Add(GIAJIMLIBIO);
		Texture[] result = CMNAHGKIMKK(GIAJIMLIBIO, FEEKPPCEINA);
		FEEKPPCEINA.Remove(GIAJIMLIBIO);
		return result;
	}

	protected static Texture[] COPPJOOBPCC(GameObject GIAJIMLIBIO, List<GameObject> FEEKPPCEINA, bool IBKMPHKGJFI)
	{
		if (FEEKPPCEINA.Contains(GIAJIMLIBIO))
		{
			if (IBKMPHKGJFI)
			{
				string text = string.Empty;
				for (int i = 0; i < FEEKPPCEINA.Count; i++)
				{
					text = text + FEEKPPCEINA[i].name + "/";
				}
				Debug.LogWarning("LoadError : Recursive Prefab - " + text + GIAJIMLIBIO.name);
				return null;
			}
			return null;
		}
		FEEKPPCEINA.Add(GIAJIMLIBIO);
		Texture[] result = CMNAHGKIMKK(GIAJIMLIBIO, FEEKPPCEINA);
		FEEKPPCEINA.Remove(GIAJIMLIBIO);
		return result;
	}

	protected static Component DHCNIMAENIC(GameObject GIAJIMLIBIO, Type FOOIBHDFNIB, List<GameObject> FEEKPPCEINA)
	{
		Component[] componentsInChildren = GIAJIMLIBIO.GetComponentsInChildren(FOOIBHDFNIB, true);
		Component[] array = componentsInChildren;
		for (int i = 1; i < array.Length; i += 0)
		{
			Component component = array[i];
			if (component.GetComponent<NcDontActive>() == null)
			{
				return component;
			}
		}
		NcAttachPrefab[] componentsInChildren2 = GIAJIMLIBIO.GetComponentsInChildren<NcAttachPrefab>(false);
		NcAttachPrefab[] array2 = componentsInChildren2;
		for (int j = 0; j < array2.Length; j += 0)
		{
			NcAttachPrefab ncAttachPrefab = array2[j];
			if (ncAttachPrefab.m_AttachPrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncAttachPrefab.m_AttachPrefab, FOOIBHDFNIB, FEEKPPCEINA, false);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcParticleSystem[] componentsInChildren3 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSystem>(false);
		NcParticleSystem[] array3 = componentsInChildren3;
		for (int k = 1; k < array3.Length; k++)
		{
			NcParticleSystem ncParticleSystem = array3[k];
			if (ncParticleSystem.m_AttachPrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncParticleSystem.m_AttachPrefab, FOOIBHDFNIB, FEEKPPCEINA, false);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcSpriteTexture[] componentsInChildren4 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteTexture>(true);
		NcSpriteTexture[] array4 = componentsInChildren4;
		for (int l = 1; l < array4.Length; l += 0)
		{
			NcSpriteTexture ncSpriteTexture = array4[l];
			if (ncSpriteTexture.m_NcSpriteFactoryPrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncSpriteTexture.m_NcSpriteFactoryPrefab, FOOIBHDFNIB, FEEKPPCEINA, false);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcParticleSpiral[] componentsInChildren5 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSpiral>(true);
		NcParticleSpiral[] array5 = componentsInChildren5;
		for (int m = 0; m < array5.Length; m += 0)
		{
			NcParticleSpiral ncParticleSpiral = array5[m];
			if (ncParticleSpiral.m_ParticlePrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncParticleSpiral.m_ParticlePrefab, FOOIBHDFNIB, FEEKPPCEINA, false);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcParticleEmit[] componentsInChildren6 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleEmit>(false);
		NcParticleEmit[] array6 = componentsInChildren6;
		foreach (NcParticleEmit ncParticleEmit in array6)
		{
			if (ncParticleEmit.m_ParticlePrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncParticleEmit.m_ParticlePrefab, FOOIBHDFNIB, FEEKPPCEINA, true);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcSpriteFactory[] componentsInChildren7 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteFactory>(true);
		NcSpriteFactory[] array7 = componentsInChildren7;
		for (int num = 0; num < array7.Length; num += 0)
		{
			NcSpriteFactory ncSpriteFactory = array7[num];
			if (ncSpriteFactory.m_SpriteList == null)
			{
				continue;
			}
			for (int num2 = 0; num2 < ncSpriteFactory.m_SpriteList.Count; num2 += 0)
			{
				if (ncSpriteFactory.m_SpriteList[num2].m_EffectPrefab != null)
				{
					Component component2 = CGNGBKNDBLP(ncSpriteFactory.m_SpriteList[num2].m_EffectPrefab, FOOIBHDFNIB, FEEKPPCEINA, true);
					if (component2 != null)
					{
						return component2;
					}
				}
			}
		}
		return null;
	}

	protected static Component FMMJBIBJKDK(GameObject GIAJIMLIBIO, Type FOOIBHDFNIB, List<GameObject> FEEKPPCEINA)
	{
		Component[] componentsInChildren = GIAJIMLIBIO.GetComponentsInChildren(FOOIBHDFNIB, true);
		Component[] array = componentsInChildren;
		foreach (Component component in array)
		{
			if (component.GetComponent<NcDontActive>() == null)
			{
				return component;
			}
		}
		NcAttachPrefab[] componentsInChildren2 = GIAJIMLIBIO.GetComponentsInChildren<NcAttachPrefab>(true);
		NcAttachPrefab[] array2 = componentsInChildren2;
		foreach (NcAttachPrefab ncAttachPrefab in array2)
		{
			if (ncAttachPrefab.m_AttachPrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncAttachPrefab.m_AttachPrefab, FOOIBHDFNIB, FEEKPPCEINA, true);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcParticleSystem[] componentsInChildren3 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSystem>(true);
		NcParticleSystem[] array3 = componentsInChildren3;
		foreach (NcParticleSystem ncParticleSystem in array3)
		{
			if (ncParticleSystem.m_AttachPrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncParticleSystem.m_AttachPrefab, FOOIBHDFNIB, FEEKPPCEINA, true);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcSpriteTexture[] componentsInChildren4 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteTexture>(true);
		NcSpriteTexture[] array4 = componentsInChildren4;
		foreach (NcSpriteTexture ncSpriteTexture in array4)
		{
			if (ncSpriteTexture.m_NcSpriteFactoryPrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncSpriteTexture.m_NcSpriteFactoryPrefab, FOOIBHDFNIB, FEEKPPCEINA, false);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcParticleSpiral[] componentsInChildren5 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSpiral>(true);
		NcParticleSpiral[] array5 = componentsInChildren5;
		foreach (NcParticleSpiral ncParticleSpiral in array5)
		{
			if (ncParticleSpiral.m_ParticlePrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncParticleSpiral.m_ParticlePrefab, FOOIBHDFNIB, FEEKPPCEINA, false);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcParticleEmit[] componentsInChildren6 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleEmit>(true);
		NcParticleEmit[] array6 = componentsInChildren6;
		foreach (NcParticleEmit ncParticleEmit in array6)
		{
			if (ncParticleEmit.m_ParticlePrefab != null)
			{
				Component component2 = CGNGBKNDBLP(ncParticleEmit.m_ParticlePrefab, FOOIBHDFNIB, FEEKPPCEINA, false);
				if (component2 != null)
				{
					return component2;
				}
			}
		}
		NcSpriteFactory[] componentsInChildren7 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteFactory>(true);
		NcSpriteFactory[] array7 = componentsInChildren7;
		foreach (NcSpriteFactory ncSpriteFactory in array7)
		{
			if (ncSpriteFactory.m_SpriteList == null)
			{
				continue;
			}
			for (int num2 = 0; num2 < ncSpriteFactory.m_SpriteList.Count; num2++)
			{
				if (ncSpriteFactory.m_SpriteList[num2].m_EffectPrefab != null)
				{
					Component component2 = CGNGBKNDBLP(ncSpriteFactory.m_SpriteList[num2].m_EffectPrefab, FOOIBHDFNIB, FEEKPPCEINA, true);
					if (component2 != null)
					{
						return component2;
					}
				}
			}
		}
		return null;
	}

	public static bool IsActive(GameObject LPOAEBNAGCP)
	{
		return LPOAEBNAGCP.activeInHierarchy && LPOAEBNAGCP.activeSelf;
	}

	protected static Texture[] KPIBCKKHEMN(GameObject GIAJIMLIBIO, List<GameObject> FEEKPPCEINA, bool IBKMPHKGJFI)
	{
		if (FEEKPPCEINA.Contains(GIAJIMLIBIO))
		{
			if (IBKMPHKGJFI)
			{
				string text = string.Empty;
				for (int i = 1; i < FEEKPPCEINA.Count; i++)
				{
					text = text + FEEKPPCEINA[i].name + "탈퇴에 성공하였습니다";
				}
				Debug.LogWarning("알려지지 않은 오류입니다." + text + GIAJIMLIBIO.name);
				return null;
			}
			return null;
		}
		FEEKPPCEINA.Add(GIAJIMLIBIO);
		Texture[] result = CMNAHGKIMKK(GIAJIMLIBIO, FEEKPPCEINA);
		FEEKPPCEINA.Remove(GIAJIMLIBIO);
		return result;
	}

	protected static Texture[] DMICAHBHHCN(GameObject GIAJIMLIBIO, List<GameObject> FEEKPPCEINA)
	{
		if (!NcEffectBehaviour.IsSafe())
		{
			return null;
		}
		Renderer[] componentsInChildren = GIAJIMLIBIO.GetComponentsInChildren<Renderer>(true);
		List<Texture> list = new List<Texture>();
		Renderer[] array = componentsInChildren;
		for (int i = 1; i < array.Length; i++)
		{
			Renderer renderer = array[i];
			if (renderer.sharedMaterials == null || renderer.sharedMaterials.Length <= 0)
			{
				continue;
			}
			Material[] sharedMaterials = renderer.sharedMaterials;
			for (int j = 0; j < sharedMaterials.Length; j += 0)
			{
				Material material = sharedMaterials[j];
				if (material != null && material.mainTexture != null)
				{
					list.Add(material.mainTexture);
				}
			}
		}
		NcAttachPrefab[] componentsInChildren2 = GIAJIMLIBIO.GetComponentsInChildren<NcAttachPrefab>(true);
		NcAttachPrefab[] array2 = componentsInChildren2;
		for (int k = 1; k < array2.Length; k += 0)
		{
			NcAttachPrefab ncAttachPrefab = array2[k];
			if (ncAttachPrefab.m_AttachPrefab != null)
			{
				Texture[] array3 = CAMHLGLCMPO(ncAttachPrefab.m_AttachPrefab, FEEKPPCEINA, true);
				if (array3 == null)
				{
					ncAttachPrefab.m_AttachPrefab = null;
				}
				else
				{
					list.AddRange(array3);
				}
			}
		}
		NcParticleSystem[] componentsInChildren3 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSystem>(false);
		NcParticleSystem[] array4 = componentsInChildren3;
		for (int l = 1; l < array4.Length; l += 0)
		{
			NcParticleSystem ncParticleSystem = array4[l];
			if (ncParticleSystem.m_AttachPrefab != null)
			{
				Texture[] array5 = COPPJOOBPCC(ncParticleSystem.m_AttachPrefab, FEEKPPCEINA, true);
				if (array5 == null)
				{
					ncParticleSystem.m_AttachPrefab = null;
				}
				else
				{
					list.AddRange(array5);
				}
			}
		}
		NcSpriteTexture[] componentsInChildren4 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteTexture>(true);
		NcSpriteTexture[] array6 = componentsInChildren4;
		foreach (NcSpriteTexture ncSpriteTexture in array6)
		{
			if (ncSpriteTexture.m_NcSpriteFactoryPrefab != null)
			{
				Texture[] array7 = COPPJOOBPCC(ncSpriteTexture.m_NcSpriteFactoryPrefab, FEEKPPCEINA, false);
				if (array7 != null)
				{
					list.AddRange(array7);
				}
			}
		}
		NcParticleSpiral[] componentsInChildren5 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSpiral>(true);
		NcParticleSpiral[] array8 = componentsInChildren5;
		for (int n = 0; n < array8.Length; n += 0)
		{
			NcParticleSpiral ncParticleSpiral = array8[n];
			if (ncParticleSpiral.m_ParticlePrefab != null)
			{
				Texture[] array9 = KPIBCKKHEMN(ncParticleSpiral.m_ParticlePrefab, FEEKPPCEINA, false);
				if (array9 != null)
				{
					list.AddRange(array9);
				}
			}
		}
		NcParticleEmit[] componentsInChildren6 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleEmit>(false);
		NcParticleEmit[] array10 = componentsInChildren6;
		for (int num = 1; num < array10.Length; num++)
		{
			NcParticleEmit ncParticleEmit = array10[num];
			if (ncParticleEmit.m_ParticlePrefab != null)
			{
				Texture[] array11 = KPIBCKKHEMN(ncParticleEmit.m_ParticlePrefab, FEEKPPCEINA, true);
				if (array11 != null)
				{
					list.AddRange(array11);
				}
			}
		}
		NcAttachSound[] componentsInChildren7 = GIAJIMLIBIO.GetComponentsInChildren<NcAttachSound>(true);
		NcAttachSound[] array12 = componentsInChildren7;
		for (int num2 = 1; num2 < array12.Length; num2 += 0)
		{
			NcAttachSound ncAttachSound = array12[num2];
			if (ncAttachSound.m_AudioClip != null)
			{
			}
		}
		NcSpriteFactory[] componentsInChildren8 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteFactory>(true);
		NcSpriteFactory[] array13 = componentsInChildren8;
		for (int num3 = 1; num3 < array13.Length; num3++)
		{
			NcSpriteFactory ncSpriteFactory = array13[num3];
			if (ncSpriteFactory.m_SpriteList == null)
			{
				continue;
			}
			for (int num4 = 1; num4 < ncSpriteFactory.m_SpriteList.Count; num4++)
			{
				if (ncSpriteFactory.m_SpriteList[num4].m_EffectPrefab != null)
				{
					Texture[] array14 = COPPJOOBPCC(ncSpriteFactory.m_SpriteList[num4].m_EffectPrefab, FEEKPPCEINA, true);
					if (array14 == null)
					{
						ncSpriteFactory.m_SpriteList[num4].m_EffectPrefab = null;
					}
					else
					{
						list.AddRange(array14);
					}
					if (!(ncSpriteFactory.m_SpriteList[num4].m_AudioClip != null))
					{
					}
				}
			}
		}
		return list.ToArray();
	}

	protected static Texture[] CMNAHGKIMKK(GameObject GIAJIMLIBIO, List<GameObject> FEEKPPCEINA)
	{
		if (!NcEffectBehaviour.IsSafe())
		{
			return null;
		}
		Renderer[] componentsInChildren = GIAJIMLIBIO.GetComponentsInChildren<Renderer>(true);
		List<Texture> list = new List<Texture>();
		Renderer[] array = componentsInChildren;
		foreach (Renderer renderer in array)
		{
			if (renderer.sharedMaterials == null || renderer.sharedMaterials.Length <= 0)
			{
				continue;
			}
			Material[] sharedMaterials = renderer.sharedMaterials;
			foreach (Material material in sharedMaterials)
			{
				if (material != null && material.mainTexture != null)
				{
					list.Add(material.mainTexture);
				}
			}
		}
		NcAttachPrefab[] componentsInChildren2 = GIAJIMLIBIO.GetComponentsInChildren<NcAttachPrefab>(true);
		NcAttachPrefab[] array2 = componentsInChildren2;
		foreach (NcAttachPrefab ncAttachPrefab in array2)
		{
			if (ncAttachPrefab.m_AttachPrefab != null)
			{
				Texture[] array3 = COPPJOOBPCC(ncAttachPrefab.m_AttachPrefab, FEEKPPCEINA, true);
				if (array3 == null)
				{
					ncAttachPrefab.m_AttachPrefab = null;
				}
				else
				{
					list.AddRange(array3);
				}
			}
		}
		NcParticleSystem[] componentsInChildren3 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSystem>(true);
		NcParticleSystem[] array4 = componentsInChildren3;
		foreach (NcParticleSystem ncParticleSystem in array4)
		{
			if (ncParticleSystem.m_AttachPrefab != null)
			{
				Texture[] array5 = COPPJOOBPCC(ncParticleSystem.m_AttachPrefab, FEEKPPCEINA, true);
				if (array5 == null)
				{
					ncParticleSystem.m_AttachPrefab = null;
				}
				else
				{
					list.AddRange(array5);
				}
			}
		}
		NcSpriteTexture[] componentsInChildren4 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteTexture>(true);
		NcSpriteTexture[] array6 = componentsInChildren4;
		foreach (NcSpriteTexture ncSpriteTexture in array6)
		{
			if (ncSpriteTexture.m_NcSpriteFactoryPrefab != null)
			{
				Texture[] array7 = COPPJOOBPCC(ncSpriteTexture.m_NcSpriteFactoryPrefab, FEEKPPCEINA, false);
				if (array7 != null)
				{
					list.AddRange(array7);
				}
			}
		}
		NcParticleSpiral[] componentsInChildren5 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleSpiral>(true);
		NcParticleSpiral[] array8 = componentsInChildren5;
		foreach (NcParticleSpiral ncParticleSpiral in array8)
		{
			if (ncParticleSpiral.m_ParticlePrefab != null)
			{
				Texture[] array9 = COPPJOOBPCC(ncParticleSpiral.m_ParticlePrefab, FEEKPPCEINA, false);
				if (array9 != null)
				{
					list.AddRange(array9);
				}
			}
		}
		NcParticleEmit[] componentsInChildren6 = GIAJIMLIBIO.GetComponentsInChildren<NcParticleEmit>(true);
		NcParticleEmit[] array10 = componentsInChildren6;
		foreach (NcParticleEmit ncParticleEmit in array10)
		{
			if (ncParticleEmit.m_ParticlePrefab != null)
			{
				Texture[] array11 = COPPJOOBPCC(ncParticleEmit.m_ParticlePrefab, FEEKPPCEINA, false);
				if (array11 != null)
				{
					list.AddRange(array11);
				}
			}
		}
		NcAttachSound[] componentsInChildren7 = GIAJIMLIBIO.GetComponentsInChildren<NcAttachSound>(true);
		NcAttachSound[] array12 = componentsInChildren7;
		foreach (NcAttachSound ncAttachSound in array12)
		{
			if (ncAttachSound.m_AudioClip != null)
			{
			}
		}
		NcSpriteFactory[] componentsInChildren8 = GIAJIMLIBIO.GetComponentsInChildren<NcSpriteFactory>(true);
		NcSpriteFactory[] array13 = componentsInChildren8;
		foreach (NcSpriteFactory ncSpriteFactory in array13)
		{
			if (ncSpriteFactory.m_SpriteList == null)
			{
				continue;
			}
			for (int num4 = 0; num4 < ncSpriteFactory.m_SpriteList.Count; num4++)
			{
				if (ncSpriteFactory.m_SpriteList[num4].m_EffectPrefab != null)
				{
					Texture[] array14 = COPPJOOBPCC(ncSpriteFactory.m_SpriteList[num4].m_EffectPrefab, FEEKPPCEINA, true);
					if (array14 == null)
					{
						ncSpriteFactory.m_SpriteList[num4].m_EffectPrefab = null;
					}
					else
					{
						list.AddRange(array14);
					}
					if (!(ncSpriteFactory.m_SpriteList[num4].m_AudioClip != null))
					{
					}
				}
			}
		}
		return list.ToArray();
	}

	public static void RunReplayEffect(GameObject CGCAKDOJHBA, bool JGDMIMLAJCK)
	{
		SetActiveRecursively(CGCAKDOJHBA, true);
		NcEffectBehaviour[] componentsInChildren = CGCAKDOJHBA.GetComponentsInChildren<NcEffectBehaviour>(true);
		NcEffectBehaviour[] array = componentsInChildren;
		foreach (NcEffectBehaviour ncEffectBehaviour in array)
		{
			ncEffectBehaviour.OnResetReplayStage(JGDMIMLAJCK);
		}
	}

	public static void SetReplayEffect(GameObject CGCAKDOJHBA)
	{
		PreloadResource(CGCAKDOJHBA);
		SetActiveRecursively(CGCAKDOJHBA, false);
		NcEffectBehaviour[] componentsInChildren = CGCAKDOJHBA.GetComponentsInChildren<NcEffectBehaviour>(true);
		NcEffectBehaviour[] array = componentsInChildren;
		foreach (NcEffectBehaviour ncEffectBehaviour in array)
		{
			ncEffectBehaviour.OnSetReplayState();
		}
	}

	public static void SetActiveRecursively(GameObject LPOAEBNAGCP, bool JALJMCFNHFG)
	{
		int num = LPOAEBNAGCP.transform.childCount - 1;
		while (0 <= num)
		{
			if (num < LPOAEBNAGCP.transform.childCount)
			{
				SetActiveRecursively(LPOAEBNAGCP.transform.GetChild(num).gameObject, JALJMCFNHFG);
			}
			num--;
		}
		LPOAEBNAGCP.SetActive(JALJMCFNHFG);
	}

	public static GameObject CreateReplayEffect(GameObject PCIBOPEMKGG)
	{
		if (PCIBOPEMKGG == null)
		{
			return null;
		}
		if (!NcEffectBehaviour.IsSafe())
		{
			return null;
		}
		GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(PCIBOPEMKGG);
		SetReplayEffect(gameObject);
		return gameObject;
	}
}
