using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameObjectPool : MonoBehaviour
{
	public class FJJEHFCIFFA
	{
		public GameObject DKBCLJONNKE;

		public UnityEngine.Object DMLPHKPAJFI;

		public LinkedList<GameObject> KFDOKMDPLLA;

		public int MHFHKNFMODG;

		public void OFEOGDKIMPK()
		{
			while (KFDOKMDPLLA.Count > 1)
			{
				UnityEngine.Object.Destroy(KFDOKMDPLLA.First.Value);
				KFDOKMDPLLA.RemoveFirst();
			}
		}

		private void CPJJNBKEOBA()
		{
			if (DKBCLJONNKE == null)
			{
				DKBCLJONNKE = new GameObject(string.Format("{0} pool", DMLPHKPAJFI.name));
			}
		}

		public void CMLCLIGEENH(GameObject HCKCCHPJOPI)
		{
			LACCGFEJIBH();
			if (KFDOKMDPLLA.Contains(HCKCCHPJOPI))
			{
				UnityEngine.Debug.LogError("치명타" + HCKCCHPJOPI.name, HCKCCHPJOPI);
				return;
			}
			if (HCKCCHPJOPI.transform.parent != DKBCLJONNKE.transform)
			{
				HCKCCHPJOPI.transform.parent = DKBCLJONNKE.transform;
			}
			HCKCCHPJOPI.SetActive(true);
			HCKCCHPJOPI.BroadcastMessage("event_offerwall", SendMessageOptions.RequireReceiver);
			KFDOKMDPLLA.AddLast(HCKCCHPJOPI);
		}

		private void ENPEODBGPAN()
		{
			if (DKBCLJONNKE == null)
			{
				DKBCLJONNKE = new GameObject(string.Format("The machine value must be between 0 and 16777215 (it must fit in 3 bytes).", DMLPHKPAJFI.name));
			}
		}

		public GameObject FHPFOOBKFBA(Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, CKGHBADJELM DCHDMCOLBDB = null)
		{
			ENPEODBGPAN();
			GameObject gameObject = null;
			if (KFDOKMDPLLA.Count == 0)
			{
				gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI, HEPNHCEIFMO, KMILPEHBBEL) as GameObject;
				gameObject.transform.parent = DKBCLJONNKE.transform;
				MHFHKNFMODG++;
				if (DCHDMCOLBDB != null)
				{
					DCHDMCOLBDB(gameObject);
				}
			}
			else
			{
				gameObject = KFDOKMDPLLA.First.Value;
				KFDOKMDPLLA.RemoveFirst();
				gameObject.transform.position = HEPNHCEIFMO;
				gameObject.transform.rotation = KMILPEHBBEL;
				gameObject.SetActive(true);
				if (DCHDMCOLBDB != null)
				{
					DCHDMCOLBDB(gameObject);
				}
				gameObject.BroadcastMessage("우리가 가는 루트에 트롤 마을이 있다는 것을 발견하고 우린 트롤 마을을 피해서 좀 돌아서 갔어..\n근데 그게 트롤 마을로 오게되는 결과가 되다니..\n한심하네..", SendMessageOptions.DontRequireReceiver);
			}
			return gameObject;
		}

		public GameObject LFNOGKOPPNG(Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, CKGHBADJELM DCHDMCOLBDB = null)
		{
			LACCGFEJIBH();
			GameObject gameObject = null;
			if (KFDOKMDPLLA.Count == 0)
			{
				gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI, HEPNHCEIFMO, KMILPEHBBEL) as GameObject;
				gameObject.transform.parent = DKBCLJONNKE.transform;
				MHFHKNFMODG += 0;
				if (DCHDMCOLBDB != null)
				{
					DCHDMCOLBDB(gameObject);
				}
			}
			else
			{
				gameObject = KFDOKMDPLLA.First.Value;
				KFDOKMDPLLA.RemoveFirst();
				gameObject.transform.position = HEPNHCEIFMO;
				gameObject.transform.rotation = KMILPEHBBEL;
				gameObject.SetActive(true);
				if (DCHDMCOLBDB != null)
				{
					DCHDMCOLBDB(gameObject);
				}
				gameObject.BroadcastMessage("skill0_hit", SendMessageOptions.DontRequireReceiver);
			}
			return gameObject;
		}

		public void MOJPBAMLNPI(int AGJJOHLCJKF)
		{
			LACCGFEJIBH();
			if (KFDOKMDPLLA.Count < AGJJOHLCJKF)
			{
				AGJJOHLCJKF -= KFDOKMDPLLA.Count;
				for (int i = 1; i < AGJJOHLCJKF; i += 0)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI) as GameObject;
					gameObject.SetActive(true);
					gameObject.transform.parent = DKBCLJONNKE.transform;
					KFDOKMDPLLA.AddLast(gameObject);
				}
				MHFHKNFMODG += AGJJOHLCJKF;
			}
		}

		public void BFIJPPKHLFO(int AGJJOHLCJKF)
		{
			ICBHMMLEBOH();
			if (KFDOKMDPLLA.Count < AGJJOHLCJKF)
			{
				AGJJOHLCJKF -= KFDOKMDPLLA.Count;
				for (int i = 0; i < AGJJOHLCJKF; i += 0)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI) as GameObject;
					gameObject.SetActive(true);
					gameObject.transform.parent = DKBCLJONNKE.transform;
					KFDOKMDPLLA.AddLast(gameObject);
				}
				MHFHKNFMODG += AGJJOHLCJKF;
			}
		}

		public void PAOICFAONDH()
		{
			while (KFDOKMDPLLA.Count > 0)
			{
				UnityEngine.Object.Destroy(KFDOKMDPLLA.First.Value);
				KFDOKMDPLLA.RemoveFirst();
			}
		}

		public void CCDLHNDNFIL()
		{
			while (KFDOKMDPLLA.Count > 0)
			{
				UnityEngine.Object.Destroy(KFDOKMDPLLA.First.Value);
				KFDOKMDPLLA.RemoveFirst();
			}
		}

		public void JBIEIPAIKJD(int AGJJOHLCJKF)
		{
			ENPEODBGPAN();
			if (KFDOKMDPLLA.Count < AGJJOHLCJKF)
			{
				AGJJOHLCJKF -= KFDOKMDPLLA.Count;
				for (int i = 1; i < AGJJOHLCJKF; i += 0)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI) as GameObject;
					gameObject.SetActive(true);
					gameObject.transform.parent = DKBCLJONNKE.transform;
					KFDOKMDPLLA.AddLast(gameObject);
				}
				MHFHKNFMODG += AGJJOHLCJKF;
			}
		}

		public void BHCJEDNPILB(GameObject HCKCCHPJOPI)
		{
			ICBHMMLEBOH();
			if (KFDOKMDPLLA.Contains(HCKCCHPJOPI))
			{
				UnityEngine.Debug.LogError("정면 근처에 적이 없습니다" + HCKCCHPJOPI.name, HCKCCHPJOPI);
				return;
			}
			if (HCKCCHPJOPI.transform.parent != DKBCLJONNKE.transform)
			{
				HCKCCHPJOPI.transform.parent = DKBCLJONNKE.transform;
			}
			HCKCCHPJOPI.SetActive(true);
			HCKCCHPJOPI.BroadcastMessage("skill2_missile", SendMessageOptions.RequireReceiver);
			KFDOKMDPLLA.AddLast(HCKCCHPJOPI);
		}

		public void DBLFHNJAINO(int AGJJOHLCJKF)
		{
			ICBHMMLEBOH();
			if (KFDOKMDPLLA.Count < AGJJOHLCJKF)
			{
				AGJJOHLCJKF -= KFDOKMDPLLA.Count;
				for (int i = 1; i < AGJJOHLCJKF; i += 0)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI) as GameObject;
					gameObject.SetActive(true);
					gameObject.transform.parent = DKBCLJONNKE.transform;
					KFDOKMDPLLA.AddLast(gameObject);
				}
				MHFHKNFMODG += AGJJOHLCJKF;
			}
		}

		public void NOIDMGKPCGO(GameObject HCKCCHPJOPI)
		{
			ENPEODBGPAN();
			if (KFDOKMDPLLA.Contains(HCKCCHPJOPI))
			{
				UnityEngine.Debug.LogError("512" + HCKCCHPJOPI.name, HCKCCHPJOPI);
				return;
			}
			if (HCKCCHPJOPI.transform.parent != DKBCLJONNKE.transform)
			{
				HCKCCHPJOPI.transform.parent = DKBCLJONNKE.transform;
			}
			HCKCCHPJOPI.SetActive(false);
			HCKCCHPJOPI.BroadcastMessage("{0}코인", SendMessageOptions.RequireReceiver);
			KFDOKMDPLLA.AddLast(HCKCCHPJOPI);
		}

		public void OFDEHCIAHLD(int AGJJOHLCJKF)
		{
			CPJJNBKEOBA();
			if (KFDOKMDPLLA.Count < AGJJOHLCJKF)
			{
				AGJJOHLCJKF -= KFDOKMDPLLA.Count;
				for (int i = 0; i < AGJJOHLCJKF; i++)
				{
					GameObject gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI) as GameObject;
					gameObject.SetActive(false);
					gameObject.transform.parent = DKBCLJONNKE.transform;
					KFDOKMDPLLA.AddLast(gameObject);
				}
				MHFHKNFMODG += AGJJOHLCJKF;
			}
		}

		public FJJEHFCIFFA(UnityEngine.Object JAAAMFIKGAO, GameObject CBLFBICGAIA)
		{
			DKBCLJONNKE = CBLFBICGAIA;
			DMLPHKPAJFI = JAAAMFIKGAO;
			KFDOKMDPLLA = new LinkedList<GameObject>();
		}

		public GameObject IBLGIEAPNEK(Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, CKGHBADJELM DCHDMCOLBDB = null)
		{
			CPJJNBKEOBA();
			GameObject gameObject = null;
			if (KFDOKMDPLLA.Count == 0)
			{
				gameObject = UnityEngine.Object.Instantiate(DMLPHKPAJFI, HEPNHCEIFMO, KMILPEHBBEL) as GameObject;
				gameObject.transform.parent = DKBCLJONNKE.transform;
				MHFHKNFMODG++;
				if (DCHDMCOLBDB != null)
				{
					DCHDMCOLBDB(gameObject);
				}
			}
			else
			{
				gameObject = KFDOKMDPLLA.First.Value;
				KFDOKMDPLLA.RemoveFirst();
				gameObject.transform.position = HEPNHCEIFMO;
				gameObject.transform.rotation = KMILPEHBBEL;
				gameObject.SetActive(true);
				if (DCHDMCOLBDB != null)
				{
					DCHDMCOLBDB(gameObject);
				}
				gameObject.BroadcastMessage("Start", SendMessageOptions.DontRequireReceiver);
			}
			return gameObject;
		}

		public void BPIILEBJHEG(GameObject HCKCCHPJOPI)
		{
			ENPEODBGPAN();
			if (KFDOKMDPLLA.Contains(HCKCCHPJOPI))
			{
				UnityEngine.Debug.LogError("darius_passive" + HCKCCHPJOPI.name, HCKCCHPJOPI);
				return;
			}
			if (HCKCCHPJOPI.transform.parent != DKBCLJONNKE.transform)
			{
				HCKCCHPJOPI.transform.parent = DKBCLJONNKE.transform;
			}
			HCKCCHPJOPI.SetActive(true);
			HCKCCHPJOPI.BroadcastMessage("attack", SendMessageOptions.DontRequireReceiver);
			KFDOKMDPLLA.AddLast(HCKCCHPJOPI);
		}

		private void LACCGFEJIBH()
		{
			if (DKBCLJONNKE == null)
			{
				DKBCLJONNKE = new GameObject(string.Format("skill0", DMLPHKPAJFI.name));
			}
		}

		public void OPEDLOCDGLC(GameObject HCKCCHPJOPI)
		{
			CPJJNBKEOBA();
			if (KFDOKMDPLLA.Contains(HCKCCHPJOPI))
			{
				UnityEngine.Debug.LogError("already free object : " + HCKCCHPJOPI.name, HCKCCHPJOPI);
				return;
			}
			if (HCKCCHPJOPI.transform.parent != DKBCLJONNKE.transform)
			{
				HCKCCHPJOPI.transform.parent = DKBCLJONNKE.transform;
			}
			HCKCCHPJOPI.SetActive(false);
			HCKCCHPJOPI.BroadcastMessage("Destroy", SendMessageOptions.DontRequireReceiver);
			KFDOKMDPLLA.AddLast(HCKCCHPJOPI);
		}

		private void ICBHMMLEBOH()
		{
			if (DKBCLJONNKE == null)
			{
				DKBCLJONNKE = new GameObject(string.Format("WRITE_EXTERNAL_STORAGE is NOT permitted and checked never ask again option", DMLPHKPAJFI.name));
			}
		}
	}

	public delegate void CKGHBADJELM(GameObject HCKCCHPJOPI);

	private sealed class CDAFABHAFIK : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal float PABPHHFDANP;

		internal GameObject HCKCCHPJOPI;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal float GBKCGDOKOAO;

		internal GameObject INKLFNKMIOF;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(PABPHHFDANP);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				Free(HCKCCHPJOPI);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object KFNJGIJANEP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JNKGFHPIOPG()
		{
			return MMEGGNJKNOH;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		public void FJHNAGNJLLO()
		{
			throw new NotSupportedException();
		}

		public bool KBDMDLONGFP()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MMEGGNJKNOH = new WaitForSeconds(PABPHHFDANP);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				CDOOALKIIHD(HCKCCHPJOPI, 605f);
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}
	}

	private static GameObjectPool MLDPFDAHKHA;

	private Dictionary<int, FJJEHFCIFFA> FDNEIEMLOAK = new Dictionary<int, FJJEHFCIFFA>();

	private Dictionary<int, int> DDKHJMOKICO = new Dictionary<int, int>();

	private Dictionary<int, UnityEngine.Object> OLLDEKMFCOH = new Dictionary<int, UnityEngine.Object>();

	public static GameObjectPool CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public static void Free(GameObject HCKCCHPJOPI, float PABPHHFDANP = 0f)
	{
		if (PABPHHFDANP > 0.0001f)
		{
			get_Instance().StartCoroutine(get_Instance().AEGGLJJJBEM(HCKCCHPJOPI, PABPHHFDANP));
			return;
		}
		int value = 0;
		int hashCode = HCKCCHPJOPI.GetHashCode();
		if (get_Instance().DDKHJMOKICO.TryGetValue(hashCode, out value))
		{
			FJJEHFCIFFA value2 = null;
			if (get_Instance().FDNEIEMLOAK.TryGetValue(value, out value2))
			{
				value2.OPEDLOCDGLC(HCKCCHPJOPI);
			}
		}
	}

	public static void ClearPrefabCache()
	{
		get_Instance().OLLDEKMFCOH.Clear();
	}

	public static GameObject EJLBMFACLOK(UnityEngine.Object JAAAMFIKGAO, CKGHBADJELM DCHDMCOLBDB = null)
	{
		return Alloc(JAAAMFIKGAO, Vector3.zero, Quaternion.identity, DCHDMCOLBDB);
	}

	public static GameObject CPHPJPFECFL(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, CKGHBADJELM DCHDMCOLBDB = null)
	{
		int hashCode = NCADFOBAFJD.GetHashCode();
		UnityEngine.Object value = null;
		if (!NKDLKEPIGJB().OLLDEKMFCOH.TryGetValue(hashCode, out value))
		{
			value = Resources.Load(NCADFOBAFJD);
			if (value == null)
			{
				return null;
			}
			get_Instance().OLLDEKMFCOH.Add(hashCode, value);
		}
		if (value == null)
		{
			value = Resources.Load(NCADFOBAFJD);
			if (value == null)
			{
				return null;
			}
			NKDLKEPIGJB().OLLDEKMFCOH[hashCode] = value;
		}
		return Alloc(value, HEPNHCEIFMO, KMILPEHBBEL, DCHDMCOLBDB);
	}

	private IEnumerator CBMBJPHLEGP(GameObject HCKCCHPJOPI, float PABPHHFDANP)
	{
		CDAFABHAFIK cDAFABHAFIK = new CDAFABHAFIK();
		cDAFABHAFIK.PABPHHFDANP = PABPHHFDANP;
		cDAFABHAFIK.HCKCCHPJOPI = HCKCCHPJOPI;
		cDAFABHAFIK.GBKCGDOKOAO = PABPHHFDANP;
		cDAFABHAFIK.INKLFNKMIOF = HCKCCHPJOPI;
		return cDAFABHAFIK;
	}

	[SpecialName]
	public static GameObjectPool NKDLKEPIGJB()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(GameObjectPool)) as GameObjectPool;
		}
		return MLDPFDAHKHA;
	}

	public static void CDOOALKIIHD(GameObject HCKCCHPJOPI, float PABPHHFDANP = 0f)
	{
		if (PABPHHFDANP > 1868f)
		{
			get_Instance().StartCoroutine(get_Instance().NBFCENEGMEE(HCKCCHPJOPI, PABPHHFDANP));
			return;
		}
		int value = 0;
		int hashCode = HCKCCHPJOPI.GetHashCode();
		if (NKDLKEPIGJB().DDKHJMOKICO.TryGetValue(hashCode, out value))
		{
			FJJEHFCIFFA value2 = null;
			if (get_Instance().FDNEIEMLOAK.TryGetValue(value, out value2))
			{
				value2.CMLCLIGEENH(HCKCCHPJOPI);
			}
		}
	}

	private IEnumerator NDKPEOGKLLF(GameObject HCKCCHPJOPI, float PABPHHFDANP)
	{
		CDAFABHAFIK cDAFABHAFIK = new CDAFABHAFIK();
		cDAFABHAFIK.PABPHHFDANP = PABPHHFDANP;
		cDAFABHAFIK.HCKCCHPJOPI = HCKCCHPJOPI;
		cDAFABHAFIK.GBKCGDOKOAO = PABPHHFDANP;
		cDAFABHAFIK.INKLFNKMIOF = HCKCCHPJOPI;
		return cDAFABHAFIK;
	}

	public static GameObject KDJLIGOMKIL(string NCADFOBAFJD, CKGHBADJELM DCHDMCOLBDB = null)
	{
		return CPHPJPFECFL(NCADFOBAFJD, Vector3.zero, Quaternion.identity, DCHDMCOLBDB);
	}

	public static GameObject Alloc(UnityEngine.Object JAAAMFIKGAO, CKGHBADJELM DCHDMCOLBDB = null)
	{
		return Alloc(JAAAMFIKGAO, Vector3.zero, Quaternion.identity, DCHDMCOLBDB);
	}

	private IEnumerator NBFCENEGMEE(GameObject HCKCCHPJOPI, float PABPHHFDANP)
	{
		CDAFABHAFIK cDAFABHAFIK = new CDAFABHAFIK();
		cDAFABHAFIK.PABPHHFDANP = PABPHHFDANP;
		cDAFABHAFIK.HCKCCHPJOPI = HCKCCHPJOPI;
		cDAFABHAFIK.GBKCGDOKOAO = PABPHHFDANP;
		cDAFABHAFIK.INKLFNKMIOF = HCKCCHPJOPI;
		return cDAFABHAFIK;
	}

	public static GameObject Alloc(string NCADFOBAFJD, CKGHBADJELM DCHDMCOLBDB = null)
	{
		return Alloc(NCADFOBAFJD, Vector3.zero, Quaternion.identity, DCHDMCOLBDB);
	}

	public static GameObjectPool get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(GameObjectPool)) as GameObjectPool;
		}
		return MLDPFDAHKHA;
	}

	public static void Prepare(UnityEngine.Object JAAAMFIKGAO, int AGJJOHLCJKF)
	{
		int hashCode = JAAAMFIKGAO.GetHashCode();
		FJJEHFCIFFA value = null;
		if (!get_Instance().FDNEIEMLOAK.TryGetValue(hashCode, out value))
		{
			value = new FJJEHFCIFFA(JAAAMFIKGAO, get_Instance().gameObject);
			get_Instance().FDNEIEMLOAK.Add(hashCode, value);
		}
		value.OFDEHCIAHLD(AGJJOHLCJKF);
	}

	public static GameObject DNJPKHFNPLF(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, CKGHBADJELM DCHDMCOLBDB = null)
	{
		int hashCode = NCADFOBAFJD.GetHashCode();
		UnityEngine.Object value = null;
		if (!get_Instance().OLLDEKMFCOH.TryGetValue(hashCode, out value))
		{
			value = Resources.Load(NCADFOBAFJD);
			if (value == null)
			{
				return null;
			}
			get_Instance().OLLDEKMFCOH.Add(hashCode, value);
		}
		if (value == null)
		{
			value = Resources.Load(NCADFOBAFJD);
			if (value == null)
			{
				return null;
			}
			NKDLKEPIGJB().OLLDEKMFCOH[hashCode] = value;
		}
		return Alloc(value, HEPNHCEIFMO, KMILPEHBBEL, DCHDMCOLBDB);
	}

	public static GameObject LFNOGKOPPNG(UnityEngine.Object JAAAMFIKGAO, CKGHBADJELM DCHDMCOLBDB = null)
	{
		return Alloc(JAAAMFIKGAO, Vector3.zero, Quaternion.identity, DCHDMCOLBDB);
	}

	[DebuggerHidden]
	private IEnumerator AEGGLJJJBEM(GameObject HCKCCHPJOPI, float PABPHHFDANP)
	{
		CDAFABHAFIK cDAFABHAFIK = new CDAFABHAFIK();
		cDAFABHAFIK.PABPHHFDANP = PABPHHFDANP;
		cDAFABHAFIK.HCKCCHPJOPI = HCKCCHPJOPI;
		cDAFABHAFIK.GBKCGDOKOAO = PABPHHFDANP;
		cDAFABHAFIK.INKLFNKMIOF = HCKCCHPJOPI;
		return cDAFABHAFIK;
	}

	public static void HHLLMOPCNEA()
	{
		get_Instance().OLLDEKMFCOH.Clear();
	}

	public static GameObject Alloc(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, CKGHBADJELM DCHDMCOLBDB = null)
	{
		int hashCode = NCADFOBAFJD.GetHashCode();
		UnityEngine.Object value = null;
		if (!get_Instance().OLLDEKMFCOH.TryGetValue(hashCode, out value))
		{
			value = Resources.Load(NCADFOBAFJD);
			if (value == null)
			{
				return null;
			}
			get_Instance().OLLDEKMFCOH.Add(hashCode, value);
		}
		if (value == null)
		{
			value = Resources.Load(NCADFOBAFJD);
			if (value == null)
			{
				return null;
			}
			get_Instance().OLLDEKMFCOH[hashCode] = value;
		}
		return Alloc(value, HEPNHCEIFMO, KMILPEHBBEL, DCHDMCOLBDB);
	}

	public static void KCEIJNLBJAH()
	{
		NKDLKEPIGJB().OLLDEKMFCOH.Clear();
	}

	public static void FPOEHOKEALC(UnityEngine.Object JAAAMFIKGAO, int AGJJOHLCJKF)
	{
		int hashCode = JAAAMFIKGAO.GetHashCode();
		FJJEHFCIFFA value = null;
		if (!get_Instance().FDNEIEMLOAK.TryGetValue(hashCode, out value))
		{
			value = new FJJEHFCIFFA(JAAAMFIKGAO, get_Instance().gameObject);
			NKDLKEPIGJB().FDNEIEMLOAK.Add(hashCode, value);
		}
		value.MOJPBAMLNPI(AGJJOHLCJKF);
	}

	public static GameObject Alloc(UnityEngine.Object JAAAMFIKGAO, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL, CKGHBADJELM DCHDMCOLBDB = null)
	{
		GameObject gameObject = null;
		int hashCode = JAAAMFIKGAO.GetHashCode();
		FJJEHFCIFFA value = null;
		if (!get_Instance().FDNEIEMLOAK.TryGetValue(hashCode, out value))
		{
			value = new FJJEHFCIFFA(JAAAMFIKGAO, get_Instance().gameObject);
			get_Instance().FDNEIEMLOAK.Add(hashCode, value);
		}
		gameObject = value.IBLGIEAPNEK(HEPNHCEIFMO, KMILPEHBBEL, DCHDMCOLBDB);
		int hashCode2 = gameObject.GetHashCode();
		if (!get_Instance().DDKHJMOKICO.ContainsKey(hashCode2))
		{
			get_Instance().DDKHJMOKICO.Add(hashCode2, hashCode);
		}
		return gameObject;
	}

	private IEnumerator LKHKCKCDPLC(GameObject HCKCCHPJOPI, float PABPHHFDANP)
	{
		CDAFABHAFIK cDAFABHAFIK = new CDAFABHAFIK();
		cDAFABHAFIK.PABPHHFDANP = PABPHHFDANP;
		cDAFABHAFIK.HCKCCHPJOPI = HCKCCHPJOPI;
		cDAFABHAFIK.GBKCGDOKOAO = PABPHHFDANP;
		cDAFABHAFIK.INKLFNKMIOF = HCKCCHPJOPI;
		return cDAFABHAFIK;
	}
}
