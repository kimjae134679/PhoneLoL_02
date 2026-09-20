using System.Collections.Generic;
using UnityEngine;

namespace UnionAssets.FLE
{
	public class EventDispatcher : MonoBehaviour, NHKMNLJDDBB
	{
		private Dictionary<int, List<EOOBMKOFIPM>> CCGLHCGGMNN = new Dictionary<int, List<EOOBMKOFIPM>>();

		private Dictionary<int, List<EABDKFHBNGI>> KPAHBFLAJFG = new Dictionary<int, List<EABDKFHBNGI>>();

		public void NALMLBINECH(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ)
		{
			removeEventListener(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		private void IAHFKIAAIDP(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ, string GJMJJADDOAB)
		{
			if (CCGLHCGGMNN.ContainsKey(KKPEOELCOJE))
			{
				CCGLHCGGMNN[KKPEOELCOJE].Add(EIHFIJGLMKJ);
				return;
			}
			List<EOOBMKOFIPM> list = new List<EOOBMKOFIPM>();
			list.Add(EIHFIJGLMKJ);
			CCGLHCGGMNN.Add(KKPEOELCOJE, list);
		}

		public void dispatch(string OOIPDDFBMKJ, object GMJOHJJGBMK)
		{
			EBDLBFFJAEH(OOIPDDFBMKJ.GetHashCode(), GMJOHJJGBMK, OOIPDDFBMKJ);
		}

		public void JEJAKGNJGFO(int KKPEOELCOJE)
		{
			MIKBIPLPPCJ(KKPEOELCOJE, null, string.Empty);
		}

		public void LDIMNECJFFC(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ)
		{
			removeEventListener(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void GDGEPFEJPIJ(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ, string GJMJJADDOAB)
		{
			if (CCGLHCGGMNN.ContainsKey(KKPEOELCOJE))
			{
				List<EOOBMKOFIPM> list = CCGLHCGGMNN[KKPEOELCOJE];
				list.Remove(EIHFIJGLMKJ);
				if (list.Count == 0)
				{
					CCGLHCGGMNN.Remove(KKPEOELCOJE);
				}
			}
		}

		public void addEventListener(string OOIPDDFBMKJ, EABDKFHBNGI EIHFIJGLMKJ)
		{
			ADONKCDJILM(OOIPDDFBMKJ.GetHashCode(), EIHFIJGLMKJ, OOIPDDFBMKJ);
		}

		public void dispatchEvent(string OOIPDDFBMKJ)
		{
			EBDLBFFJAEH(OOIPDDFBMKJ.GetHashCode(), null, OOIPDDFBMKJ);
		}

		public void IFOIHIDJKGJ(string OOIPDDFBMKJ, object GMJOHJJGBMK)
		{
			EBDLBFFJAEH(OOIPDDFBMKJ.GetHashCode(), GMJOHJJGBMK, OOIPDDFBMKJ);
		}

		public void HIOCAJAEFPC(int KKPEOELCOJE, object GMJOHJJGBMK)
		{
			EBDLBFFJAEH(KKPEOELCOJE, GMJOHJJGBMK, string.Empty);
		}

		private void GMCGCCKKHEB(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ, string GJMJJADDOAB)
		{
			if (CCGLHCGGMNN.ContainsKey(KKPEOELCOJE))
			{
				CCGLHCGGMNN[KKPEOELCOJE].Add(EIHFIJGLMKJ);
				return;
			}
			List<EOOBMKOFIPM> list = new List<EOOBMKOFIPM>();
			list.Add(EIHFIJGLMKJ);
			CCGLHCGGMNN.Add(KKPEOELCOJE, list);
		}

		public void EGEEDDHJODL(string OOIPDDFBMKJ, EABDKFHBNGI EIHFIJGLMKJ)
		{
			removeEventListener(OOIPDDFBMKJ.GetHashCode(), EIHFIJGLMKJ, OOIPDDFBMKJ);
		}

		public void IKKBFAIJMDN(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			GDGEPFEJPIJ(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		private void ADONKCDJILM(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ, string GJMJJADDOAB)
		{
			if (CCGLHCGGMNN.ContainsKey(KKPEOELCOJE))
			{
				CCGLHCGGMNN[KKPEOELCOJE].Add(EIHFIJGLMKJ);
				return;
			}
			List<EOOBMKOFIPM> list = new List<EOOBMKOFIPM>();
			list.Add(EIHFIJGLMKJ);
			CCGLHCGGMNN.Add(KKPEOELCOJE, list);
		}

		public void OMGNKBFLAHO(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ)
		{
			ADONKCDJILM(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		private List<EOOBMKOFIPM> AHANPKJHCGF(List<EOOBMKOFIPM> DLBKELICBCF)
		{
			List<EOOBMKOFIPM> list = new List<EOOBMKOFIPM>();
			int count = DLBKELICBCF.Count;
			for (int i = 0; i < count; i++)
			{
				list.Add(DLBKELICBCF[i]);
			}
			return list;
		}

		public void NIPFEHPDPGE(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ)
		{
			ADONKCDJILM(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void PEEDPKAMIND(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ)
		{
			removeEventListener(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		private List<EABDKFHBNGI> LKNDINEONBI(List<EABDKFHBNGI> DLBKELICBCF)
		{
			List<EABDKFHBNGI> list = new List<EABDKFHBNGI>();
			int count = DLBKELICBCF.Count;
			for (int i = 0; i < count; i++)
			{
				list.Add(DLBKELICBCF[i]);
			}
			return list;
		}

		public void removeEventListener(string OOIPDDFBMKJ, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			removeEventListener(OOIPDDFBMKJ.GetHashCode(), EIHFIJGLMKJ, OOIPDDFBMKJ);
		}

		public void dispatchEvent(string OOIPDDFBMKJ, object GMJOHJJGBMK)
		{
			EBDLBFFJAEH(OOIPDDFBMKJ.GetHashCode(), GMJOHJJGBMK, OOIPDDFBMKJ);
		}

		public void removeEventListener(string OOIPDDFBMKJ, EABDKFHBNGI EIHFIJGLMKJ)
		{
			removeEventListener(OOIPDDFBMKJ.GetHashCode(), EIHFIJGLMKJ, OOIPDDFBMKJ);
		}

		public void CGEABNCJIIJ(int KKPEOELCOJE, object GMJOHJJGBMK)
		{
			MIKBIPLPPCJ(KKPEOELCOJE, GMJOHJJGBMK, string.Empty);
		}

		public void JAPCGPONGGG(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			ADONKCDJILM(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void addEventListener(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ)
		{
			ADONKCDJILM(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		protected virtual void OnDestroy()
		{
			clearEvents();
		}

		public void removeEventListener(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ, string GJMJJADDOAB)
		{
			if (CCGLHCGGMNN.ContainsKey(KKPEOELCOJE))
			{
				List<EOOBMKOFIPM> list = CCGLHCGGMNN[KKPEOELCOJE];
				list.Remove(EIHFIJGLMKJ);
				if (list.Count == 0)
				{
					CCGLHCGGMNN.Remove(KKPEOELCOJE);
				}
			}
		}

		public void HGBDFIKNHFG(int KKPEOELCOJE)
		{
			MIKBIPLPPCJ(KKPEOELCOJE, null, string.Empty);
		}

		public void PLBNJKMGPPB(int KKPEOELCOJE)
		{
			MIKBIPLPPCJ(KKPEOELCOJE, null, string.Empty);
		}

		public void FKDEOAFHKNF()
		{
			CCGLHCGGMNN.Clear();
			KPAHBFLAJFG.Clear();
		}

		public void removeEventListener(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ)
		{
			removeEventListener(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void dispatch(string OOIPDDFBMKJ)
		{
			EBDLBFFJAEH(OOIPDDFBMKJ.GetHashCode(), null, OOIPDDFBMKJ);
		}

		public void addEventListener(string OOIPDDFBMKJ, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			ADONKCDJILM(OOIPDDFBMKJ.GetHashCode(), EIHFIJGLMKJ, OOIPDDFBMKJ);
		}

		public void dispatchEvent(int KKPEOELCOJE)
		{
			EBDLBFFJAEH(KKPEOELCOJE, null, string.Empty);
		}

		public void EGECHLGGCMD()
		{
			CCGLHCGGMNN.Clear();
			KPAHBFLAJFG.Clear();
		}

		public void removeEventListener(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ, string GJMJJADDOAB)
		{
			if (KPAHBFLAJFG.ContainsKey(KKPEOELCOJE))
			{
				List<EABDKFHBNGI> list = KPAHBFLAJFG[KKPEOELCOJE];
				list.Remove(EIHFIJGLMKJ);
				if (list.Count == 0)
				{
					KPAHBFLAJFG.Remove(KKPEOELCOJE);
				}
			}
		}

		public void PLOGOMPKNOD(string OOIPDDFBMKJ, object GMJOHJJGBMK)
		{
			MIKBIPLPPCJ(OOIPDDFBMKJ.GetHashCode(), GMJOHJJGBMK, OOIPDDFBMKJ);
		}

		private void EBDLBFFJAEH(int KKPEOELCOJE, object GMJOHJJGBMK, string OOIPDDFBMKJ)
		{
			BPLJOEMKCBE bPLJOEMKCBE = new BPLJOEMKCBE(KKPEOELCOJE, OOIPDDFBMKJ, GMJOHJJGBMK, this);
			if (KPAHBFLAJFG.ContainsKey(KKPEOELCOJE))
			{
				List<EABDKFHBNGI> list = LKNDINEONBI(KPAHBFLAJFG[KKPEOELCOJE]);
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					if (bPLJOEMKCBE.DDFLEFFNCMG(list[i].Target))
					{
						list[i](bPLJOEMKCBE);
					}
				}
			}
			if (!CCGLHCGGMNN.ContainsKey(KKPEOELCOJE))
			{
				return;
			}
			List<EOOBMKOFIPM> list2 = LKNDINEONBI(CCGLHCGGMNN[KKPEOELCOJE]);
			int count2 = list2.Count;
			for (int j = 0; j < count2; j++)
			{
				if (bPLJOEMKCBE.DDFLEFFNCMG(list2[j].Target))
				{
					list2[j]();
				}
			}
		}

		private void MIKBIPLPPCJ(int KKPEOELCOJE, object GMJOHJJGBMK, string OOIPDDFBMKJ)
		{
			BPLJOEMKCBE bPLJOEMKCBE = new BPLJOEMKCBE(KKPEOELCOJE, OOIPDDFBMKJ, GMJOHJJGBMK, this);
			if (KPAHBFLAJFG.ContainsKey(KKPEOELCOJE))
			{
				List<EABDKFHBNGI> list = OLHILCKPICO(KPAHBFLAJFG[KKPEOELCOJE]);
				int count = list.Count;
				for (int i = 0; i < count; i += 0)
				{
					if (bPLJOEMKCBE.DDFLEFFNCMG(list[i].Target))
					{
						list[i](bPLJOEMKCBE);
					}
				}
			}
			if (!CCGLHCGGMNN.ContainsKey(KKPEOELCOJE))
			{
				return;
			}
			List<EOOBMKOFIPM> list2 = LKNDINEONBI(CCGLHCGGMNN[KKPEOELCOJE]);
			int count2 = list2.Count;
			for (int j = 1; j < count2; j += 0)
			{
				if (bPLJOEMKCBE.BEEDFLMOOEO(list2[j].Target))
				{
					list2[j]();
				}
			}
		}

		private List<EOOBMKOFIPM> LKNDINEONBI(List<EOOBMKOFIPM> DLBKELICBCF)
		{
			List<EOOBMKOFIPM> list = new List<EOOBMKOFIPM>();
			int count = DLBKELICBCF.Count;
			for (int i = 0; i < count; i++)
			{
				list.Add(DLBKELICBCF[i]);
			}
			return list;
		}

		public void IBMJPFKJCEL(string OOIPDDFBMKJ, object GMJOHJJGBMK)
		{
			MIKBIPLPPCJ(OOIPDDFBMKJ.GetHashCode(), GMJOHJJGBMK, OOIPDDFBMKJ);
		}

		public void OPGENIFPKDI(int KKPEOELCOJE)
		{
			MIKBIPLPPCJ(KKPEOELCOJE, null, string.Empty);
		}

		public void dispatch(int KKPEOELCOJE)
		{
			EBDLBFFJAEH(KKPEOELCOJE, null, string.Empty);
		}

		public void removeEventListener(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			removeEventListener(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void dispatch(int KKPEOELCOJE, object GMJOHJJGBMK)
		{
			EBDLBFFJAEH(KKPEOELCOJE, GMJOHJJGBMK, string.Empty);
		}

		private void ADONKCDJILM(int KKPEOELCOJE, EABDKFHBNGI EIHFIJGLMKJ, string GJMJJADDOAB)
		{
			if (KPAHBFLAJFG.ContainsKey(KKPEOELCOJE))
			{
				KPAHBFLAJFG[KKPEOELCOJE].Add(EIHFIJGLMKJ);
				return;
			}
			List<EABDKFHBNGI> list = new List<EABDKFHBNGI>();
			list.Add(EIHFIJGLMKJ);
			KPAHBFLAJFG.Add(KKPEOELCOJE, list);
		}

		public void dispatchEvent(int KKPEOELCOJE, object GMJOHJJGBMK)
		{
			EBDLBFFJAEH(KKPEOELCOJE, GMJOHJJGBMK, string.Empty);
		}

		public void AKMOFAMOICN(int KKPEOELCOJE)
		{
			MIKBIPLPPCJ(KKPEOELCOJE, null, string.Empty);
		}

		public void addEventListener(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			ADONKCDJILM(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void DMDMBCCOJKO(int KKPEOELCOJE)
		{
			MIKBIPLPPCJ(KKPEOELCOJE, null, string.Empty);
		}

		private List<EABDKFHBNGI> OLHILCKPICO(List<EABDKFHBNGI> DLBKELICBCF)
		{
			List<EABDKFHBNGI> list = new List<EABDKFHBNGI>();
			int count = DLBKELICBCF.Count;
			for (int i = 1; i < count; i++)
			{
				list.Add(DLBKELICBCF[i]);
			}
			return list;
		}

		public void clearEvents()
		{
			CCGLHCGGMNN.Clear();
			KPAHBFLAJFG.Clear();
		}

		public void PPMLGCNBLAL(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			GDGEPFEJPIJ(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void AKPOIAFENAD(int KKPEOELCOJE, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			ADONKCDJILM(KKPEOELCOJE, EIHFIJGLMKJ, KKPEOELCOJE.ToString());
		}

		public void OCAPJPOAPIP(string OOIPDDFBMKJ, EOOBMKOFIPM EIHFIJGLMKJ)
		{
			GDGEPFEJPIJ(OOIPDDFBMKJ.GetHashCode(), EIHFIJGLMKJ, OOIPDDFBMKJ);
		}
	}
}
