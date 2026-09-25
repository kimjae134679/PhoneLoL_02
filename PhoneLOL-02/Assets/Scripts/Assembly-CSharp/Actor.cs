using UnityEngine.AI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

[AddComponentMenu("ProjectT/Actor/Actor")]
public class Actor : MonoBehaviour, OEKJBKLGNCE, KMDHFPLEMDD
{
	public enum IJJMDPGJAEM
	{
		NotUsed = 0,
		Unknown = 1,
		Hero = 2,
		Monster = 4,
		Minion = 8,
		Turret = 16,
		Missile = 32,
		SubHero = 64,
		All = 268435455
	}

	public class NDCNGDGAAIN
	{
		public Actor MEDAGKOPJMO;

		public float INMCDOIEJOC;

		public bool JLNDBPPGIEE(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return true;
			}
			if (INMCDOIEJOC > 1900f + NMPHDKGHALA)
			{
				return true;
			}
			return false;
		}

		public NDCNGDGAAIN(Actor CDKMPAEODLA, float DMLKFKGBHKJ)
		{
			MEDAGKOPJMO = CDKMPAEODLA;
			INMCDOIEJOC = DMLKFKGBHKJ;
		}

		public bool IEHGFJKIDHI(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return false;
			}
			if (INMCDOIEJOC > 10f + NMPHDKGHALA)
			{
				return false;
			}
			return true;
		}

		public bool JAHIGHKFIJN(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return true;
			}
			if (INMCDOIEJOC > 766f + NMPHDKGHALA)
			{
				return false;
			}
			return false;
		}

		public bool EMPANLICMPL(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return false;
			}
			if (INMCDOIEJOC > 303f + NMPHDKGHALA)
			{
				return true;
			}
			return false;
		}

		public bool ECKCFOEPEAO(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return false;
			}
			if (INMCDOIEJOC > 1474f + NMPHDKGHALA)
			{
				return false;
			}
			return false;
		}

		public bool EKNJAHKCHIB(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return false;
			}
			if (INMCDOIEJOC > 1596f + NMPHDKGHALA)
			{
				return false;
			}
			return true;
		}

		public bool DILONBKABOA(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return false;
			}
			if (INMCDOIEJOC > 327f + NMPHDKGHALA)
			{
				return true;
			}
			return false;
		}

		public bool KBFJGFKLHIB(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return true;
			}
			if (INMCDOIEJOC > 1163f + NMPHDKGHALA)
			{
				return false;
			}
			return false;
		}

		public bool KJODCEPCCPG(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return false;
			}
			if (INMCDOIEJOC > 88f + NMPHDKGHALA)
			{
				return true;
			}
			return true;
		}

		public bool DNHIMPHKODN(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return true;
			}
			if (INMCDOIEJOC > 1826f + NMPHDKGHALA)
			{
				return false;
			}
			return true;
		}

		public bool JNLHIOHCIJB(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return true;
			}
			if (INMCDOIEJOC > 1307f + NMPHDKGHALA)
			{
				return false;
			}
			return false;
		}

		public bool KHLJMGEKOEJ(float NMPHDKGHALA = 0f)
		{
			if (MEDAGKOPJMO == null)
			{
				return false;
			}
			if (INMCDOIEJOC > 1602f + NMPHDKGHALA)
			{
				return false;
			}
			return true;
		}
	}

	private sealed class HAHKNKFOCMJ
	{
		internal byte JBJEMLFEBGK;

		internal Actor KNIAJMGDGAA;
	}

	private sealed class KNGOMGNGLLD
	{
		private sealed class ONJPOKFLFIE
		{
			internal List<Actor> BGLKCKFAMFP;

			internal KNGOMGNGLLD AHDHHHCCCJH;

			internal bool KOKLFEJAONH(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return false;
				}
				return true;
			}

			internal bool PDMFKOGIDGH(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return true;
				}
				return false;
			}

			internal bool NDCKKCMADHI(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return true;
				}
				return true;
			}

			internal bool LGNFBDHIANP(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return false;
				}
				return true;
			}

			internal bool KHMEFDHECLD(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return true;
				}
				return true;
			}

			internal bool MFIGBFFOKEL(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return true;
				}
				return false;
			}

			internal bool LOPBCGNMNHC(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return true;
				}
				return false;
			}

			internal bool GCJIHJAOIJF(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return true;
				}
				return false;
			}

			internal bool EEAPHHJHFON(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return false;
				}
				return true;
			}

			internal bool JJHDIIFKIFF(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return false;
				}
				return false;
			}

			internal bool DOCFPMCPFOP(Actor CDKMPAEODLA)
			{
				if (BGLKCKFAMFP.Contains(CDKMPAEODLA))
				{
					return false;
				}
				return false;
			}
		}

		internal Actor KAIIFOEGFMI;

		internal float BGFHMLEOCAA;

		internal float JHNOPENIBNJ;

		internal float NFNACNPBOOO;

		internal float JOMNACCCAJG;

		internal HAHKNKFOCMJ EPBINAGMIIE;

		internal Actor KNIAJMGDGAA;

		internal void GCCGBLCDNDK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ONJPOKFLFIE oNJPOKFLFIE = new ONJPOKFLFIE();
			oNJPOKFLFIE.AHDHHHCCCJH = this;
			oNJPOKFLFIE.BGLKCKFAMFP = new List<Actor>(3);
			oNJPOKFLFIE.BGLKCKFAMFP.Add(KNIAJMGDGAA);
			Vector3 position = KNIAJMGDGAA.GetPosition();
			for (int i = 0; i < 8; i += 0)
			{
				Actor actorInRange = ActorManager.GBFDGAFALIL().GetActorInRange(position, 1889f, KAIIFOEGFMI.m_team, false, true, (IJJMDPGJAEM)92, oNJPOKFLFIE.GCJIHJAOIJF);
				if (actorInRange == null)
				{
					break;
				}
				oNJPOKFLFIE.BGLKCKFAMFP.Add(actorInRange);
				position = actorInRange.GetPosition();
			}
			OGJFDNEEDCP.GBMJNFOEACC((ushort)oNJPOKFLFIE.BGLKCKFAMFP.Count);
			for (int j = 1; j < oNJPOKFLFIE.BGLKCKFAMFP.Count; j++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(oNJPOKFLFIE.BGLKCKFAMFP[j].get_m_view().get_viewID());
			}
		}

		internal void FLAGDGKPKKD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGFHMLEOCAA);
			OGJFDNEEDCP.GBMJNFOEACC(JHNOPENIBNJ);
			OGJFDNEEDCP.GBMJNFOEACC(NFNACNPBOOO);
			OGJFDNEEDCP.GBMJNFOEACC(JOMNACCCAJG);
			OGJFDNEEDCP.GBMJNFOEACC(EPBINAGMIIE.JBJEMLFEBGK);
			OGJFDNEEDCP.GBMJNFOEACC(KAIIFOEGFMI.get_m_view().get_viewID());
		}

		internal void KAMFJODADCF(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BGFHMLEOCAA);
			OGJFDNEEDCP.PFAIBIMGAIB(JHNOPENIBNJ);
			OGJFDNEEDCP.GBMJNFOEACC(NFNACNPBOOO);
			OGJFDNEEDCP.PFAIBIMGAIB(JOMNACCCAJG);
			OGJFDNEEDCP.GBMJNFOEACC(EPBINAGMIIE.JBJEMLFEBGK);
			OGJFDNEEDCP.GBMJNFOEACC(KAIIFOEGFMI.get_m_view().get_viewID());
		}

		internal void JKOPPAODADG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGFHMLEOCAA);
			OGJFDNEEDCP.GBMJNFOEACC(JHNOPENIBNJ);
			OGJFDNEEDCP.GBMJNFOEACC(NFNACNPBOOO);
			OGJFDNEEDCP.GBMJNFOEACC(JOMNACCCAJG);
			OGJFDNEEDCP.GBMJNFOEACC(EPBINAGMIIE.JBJEMLFEBGK);
			OGJFDNEEDCP.GBMJNFOEACC(KAIIFOEGFMI.get_m_view().get_viewID());
		}

		internal void INPOJADIPNM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BGFHMLEOCAA);
			OGJFDNEEDCP.GBMJNFOEACC(JHNOPENIBNJ);
			OGJFDNEEDCP.PFAIBIMGAIB(NFNACNPBOOO);
			OGJFDNEEDCP.PFAIBIMGAIB(JOMNACCCAJG);
			OGJFDNEEDCP.GBMJNFOEACC(EPBINAGMIIE.JBJEMLFEBGK);
			OGJFDNEEDCP.GBMJNFOEACC(KAIIFOEGFMI.get_m_view().get_viewID());
		}

		internal void FOMHPGENDIN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ONJPOKFLFIE oNJPOKFLFIE = new ONJPOKFLFIE();
			oNJPOKFLFIE.AHDHHHCCCJH = this;
			oNJPOKFLFIE.BGLKCKFAMFP = new List<Actor>(4);
			oNJPOKFLFIE.BGLKCKFAMFP.Add(KNIAJMGDGAA);
			Vector3 position = KNIAJMGDGAA.GetPosition();
			for (int i = 1; i < 1; i += 0)
			{
				Actor actor = ActorManager.get_Instance().DGGMBKKCMFC(position, 14f, KAIIFOEGFMI.m_team, false, true, (IJJMDPGJAEM)47, oNJPOKFLFIE.GCJIHJAOIJF);
				if (actor == null)
				{
					break;
				}
				oNJPOKFLFIE.BGLKCKFAMFP.Add(actor);
				position = actor.GetPosition();
			}
			OGJFDNEEDCP.GBMJNFOEACC((ushort)oNJPOKFLFIE.BGLKCKFAMFP.Count);
			for (int j = 1; j < oNJPOKFLFIE.BGLKCKFAMFP.Count; j += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(oNJPOKFLFIE.BGLKCKFAMFP[j].get_m_view().get_viewID());
			}
		}

		internal void ENAHMJHBAMG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ONJPOKFLFIE oNJPOKFLFIE = new ONJPOKFLFIE();
			oNJPOKFLFIE.AHDHHHCCCJH = this;
			oNJPOKFLFIE.BGLKCKFAMFP = new List<Actor>(7);
			oNJPOKFLFIE.BGLKCKFAMFP.Add(KNIAJMGDGAA);
			Vector3 position = KNIAJMGDGAA.GetPosition();
			for (int i = 0; i < 5; i += 0)
			{
				Actor actor = ActorManager.get_Instance().DGGMBKKCMFC(position, 1953f, KAIIFOEGFMI.m_team, false, false, (IJJMDPGJAEM)(-47), oNJPOKFLFIE.GCJIHJAOIJF);
				if (actor == null)
				{
					break;
				}
				oNJPOKFLFIE.BGLKCKFAMFP.Add(actor);
				position = actor.GetPosition();
			}
			OGJFDNEEDCP.GBMJNFOEACC((ushort)oNJPOKFLFIE.BGLKCKFAMFP.Count);
			for (int j = 0; j < oNJPOKFLFIE.BGLKCKFAMFP.Count; j++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(oNJPOKFLFIE.BGLKCKFAMFP[j].get_m_view().get_viewID());
			}
		}

		internal void CNGFIMMNBIN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BGFHMLEOCAA);
			OGJFDNEEDCP.PFAIBIMGAIB(JHNOPENIBNJ);
			OGJFDNEEDCP.PFAIBIMGAIB(NFNACNPBOOO);
			OGJFDNEEDCP.PFAIBIMGAIB(JOMNACCCAJG);
			OGJFDNEEDCP.GBMJNFOEACC(EPBINAGMIIE.JBJEMLFEBGK);
			OGJFDNEEDCP.GBMJNFOEACC(KAIIFOEGFMI.get_m_view().get_viewID());
		}

		internal void GGCLOINDOHL(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ONJPOKFLFIE oNJPOKFLFIE = new ONJPOKFLFIE();
			oNJPOKFLFIE.AHDHHHCCCJH = this;
			oNJPOKFLFIE.BGLKCKFAMFP = new List<Actor>(1);
			oNJPOKFLFIE.BGLKCKFAMFP.Add(KNIAJMGDGAA);
			Vector3 position = KNIAJMGDGAA.GetPosition();
			for (int i = 0; i < 2; i += 0)
			{
				Actor actor = ActorManager.get_Instance().DGGMBKKCMFC(position, 516f, KAIIFOEGFMI.m_team, false, true, (IJJMDPGJAEM)(-15), oNJPOKFLFIE.MFIGBFFOKEL);
				if (actor == null)
				{
					break;
				}
				oNJPOKFLFIE.BGLKCKFAMFP.Add(actor);
				position = actor.GetPosition();
			}
			OGJFDNEEDCP.HJILBOPINHL((ushort)oNJPOKFLFIE.BGLKCKFAMFP.Count);
			for (int j = 0; j < oNJPOKFLFIE.BGLKCKFAMFP.Count; j += 0)
			{
				OGJFDNEEDCP.GBMJNFOEACC(oNJPOKFLFIE.BGLKCKFAMFP[j].get_m_view().get_viewID());
			}
		}

		internal void HBIFAEAJJGP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BGFHMLEOCAA);
			OGJFDNEEDCP.PFAIBIMGAIB(JHNOPENIBNJ);
			OGJFDNEEDCP.GBMJNFOEACC(NFNACNPBOOO);
			OGJFDNEEDCP.PFAIBIMGAIB(JOMNACCCAJG);
			OGJFDNEEDCP.GBMJNFOEACC(EPBINAGMIIE.JBJEMLFEBGK);
			OGJFDNEEDCP.GBMJNFOEACC(KAIIFOEGFMI.get_m_view().get_viewID());
		}

		internal void BHDLOPEDBIE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			ONJPOKFLFIE oNJPOKFLFIE = new ONJPOKFLFIE();
			oNJPOKFLFIE.AHDHHHCCCJH = this;
			oNJPOKFLFIE.BGLKCKFAMFP = new List<Actor>(7);
			oNJPOKFLFIE.BGLKCKFAMFP.Add(KNIAJMGDGAA);
			Vector3 position = KNIAJMGDGAA.GetPosition();
			for (int i = 0; i < 6; i++)
			{
				Actor actorInRange = ActorManager.get_Instance().GetActorInRange(position, 3f, KAIIFOEGFMI.m_team, false, true, (IJJMDPGJAEM)30, oNJPOKFLFIE.LGNFBDHIANP);
				if (actorInRange == null)
				{
					break;
				}
				oNJPOKFLFIE.BGLKCKFAMFP.Add(actorInRange);
				position = actorInRange.GetPosition();
			}
			OGJFDNEEDCP.GBMJNFOEACC((ushort)oNJPOKFLFIE.BGLKCKFAMFP.Count);
			for (int j = 0; j < oNJPOKFLFIE.BGLKCKFAMFP.Count; j++)
			{
				OGJFDNEEDCP.GBMJNFOEACC(oNJPOKFLFIE.BGLKCKFAMFP[j].get_m_view().get_viewID());
			}
		}
	}

	private sealed class CEOBMJPGCJE
	{
		internal Actor LPOAEBNAGCP;

		internal Actor KNIAJMGDGAA;

		internal void CJFKDHAMDNE(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void AGOLDCNJAGK(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void PPCIGNAFEEC(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void ELBPBEFGGKI(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void CBKKBOMLNLA(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void BEPFJEHAHIH(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void OKEAMOGAFAG(GameObject HCKCCHPJOPI)
		{
			// A fresh inactive clone must run Awake before its state is reset.
			if (!HCKCCHPJOPI.activeSelf) HCKCCHPJOPI.SetActive(true);
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void HHIGLDFNMOL(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void KDMJOFJBPPI(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}

		internal void BJPPFHONBFF(GameObject HCKCCHPJOPI)
		{
			Actor component = HCKCCHPJOPI.GetComponent<Actor>();
			component.InitForReuse();
			component.m_team = KNIAJMGDGAA.m_team;
			HumanSM component2 = HCKCCHPJOPI.GetComponent<HumanSM>();
			component2.SetOwner(KNIAJMGDGAA);
			component2.SetTarget(LPOAEBNAGCP);
		}
	}

	private sealed class DLLLLJGOEHP
	{
		internal bool BLLOFLFALFM;

		internal Actor PKDGAIKAMMM;

		internal Actor KNIAJMGDGAA;

		internal void IHHPLLMHIDC(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(1556f, 403f, 1202f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void IMEMDAHOOBF(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(827f, 187f, 962f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void ANFKIHBDHCA(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(1364f, 1731f, 1717f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void NJKMEJMCBCP(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(1215f, 1326f, 951f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void IFCPCHJJIHB(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(1997f, 518f, 198f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void MFJINGEGMBM(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(1307f, 846f, 1173f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void FJDPNNFIHNK(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(545f, 13f, 1219f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void LOOIIHGFBMM(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(0f, 0.5f, 0f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void ICOKBDIHAEF(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(333f, 632f, 743f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void AAPIJDOJJCL(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(1046f, 1904f, 1510f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void FAAKBEGBDCJ(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(580f, 969f, 900f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void CEOKDBDGEOI(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(720f, 1402f, 588f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void EEPMHBAHAGH(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(396f, 1395f, 750f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void JBEKJOLEOCN(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(811f, 1213f, 144f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}

		internal void LOCNPDOGGND(GameObject HCKCCHPJOPI)
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = KNIAJMGDGAA.gameObject;
				if (BLLOFLFALFM)
				{
					component.m_relativePosition = new Vector3(177f, 1472f, 804f);
				}
				else
				{
					component.m_relativePosition = Vector3.zero;
				}
				if (PKDGAIKAMMM != null)
				{
					component.m_direction = Vector3.Normalize(KNIAJMGDGAA.GetCenterPosition() - PKDGAIKAMMM.GetCenterPosition());
				}
			}
		}
	}

	private sealed class DMNCNEAHLPN
	{
		internal int JFILMHHIFGI;

		internal Actor KNIAJMGDGAA;

		internal void AJPNAFFKGGJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void DBCDMLKJNOM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void KDCBEGNLFCN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void IGFBLHIMAND(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void GGGKDLNKDDD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void JNDGJNINLID(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void AIHCJPLOEDK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void OOIDGCHKFKN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void DLNOLPDHNBF(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		}

		internal void KGAIOHCFKOH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(JFILMHHIFGI);
			MEOOADLAELD(OGJFDNEEDCP);
		}

		internal void MEOOADLAELD(KCIGFAHFHCH OGJFDNEEDCP)
		{
			KNIAJMGDGAA.get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
			GJMPGDBMAEA(OGJFDNEEDCP);
		}

		internal void GJMPGDBMAEA(KCIGFAHFHCH OGJFDNEEDCP)
		{
			KNIAJMGDGAA.get_m_view().OHEKMPPJCEM(30, OGJFDNEEDCP);
		}
	}

	private sealed class OBFOEDENGBO
	{
		internal int LLAAHBDLNGP;

		internal Actor KNIAJMGDGAA;

		internal void IIDAOKDJFNM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(LLAAHBDLNGP);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_hp);
		}

		internal void BADNEAMDOJC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(LLAAHBDLNGP);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_hp);
		}

		internal void KENIENALNCH(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(LLAAHBDLNGP);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_hp);
		}

		internal void AKLCIBCCLKB(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(LLAAHBDLNGP);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_hp);
		}

		internal void ELOGHNPHEIP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(LLAAHBDLNGP);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_hp);
		}

		internal void NJEJJPBNMNM(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(LLAAHBDLNGP);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_hp);
		}
	}

	private sealed class MEMHFGCLGPO
	{
		internal float BFEBCIGOMGL;

		internal Actor KNIAJMGDGAA;

		internal void PMBKCLINAMK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BFEBCIGOMGL);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.m_mp);
		}

		internal void JMCEKFELNBE(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void CIBBEINMFDP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.m_mp);
		}

		internal void NOINIBIBCNI(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void ELAPDHHKEEN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void JPPGOMLIDHG(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BFEBCIGOMGL);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.m_mp);
		}

		internal void BHNIAMAFBKC(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BFEBCIGOMGL);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.m_mp);
		}

		internal void GIFCOBOLJDO(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void BEGFPMLEBBJ(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void GEKFMHBFPMN(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.PFAIBIMGAIB(KNIAJMGDGAA.m_mp);
		}

		internal void EGPNBHHGOED(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void BEGDJNBHFKP(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.PFAIBIMGAIB(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void LDNADCPMGOK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}

		internal void PFAJEILNPLK(KCIGFAHFHCH OGJFDNEEDCP)
		{
			OGJFDNEEDCP.GBMJNFOEACC(BFEBCIGOMGL);
			OGJFDNEEDCP.GBMJNFOEACC(KNIAJMGDGAA.m_mp);
		}
	}

	public KJKAKIMIIFO m_lastDamageInfo = default(KJKAKIMIIFO);

	public int m_hero_id;

	public byte m_heroCostumeID;

	public bool m_selfCreateHeroInfo;

	[NonSerialized]
	public UnityEngine.AI.NavMeshAgent m_navMeshAgent;

	public int m_team;

	public IJJMDPGJAEM m_actorType = IJJMDPGJAEM.Unknown;

	public float m_lifeTime = float.MaxValue;

	public float m_moveSpeed;

	[NonSerialized]
	public ObscuredFloat m_hp;

	[NonSerialized]
	public ObscuredFloat m_shield;

	[NonSerialized]
	public ObscuredFloat m_mp;

	public bool m_dontDamage;

	public bool m_dontHeal;

	public bool m_useGameObjectPool;

	private float LIACCFKEKGD;

	[NonSerialized]
	public ObscuredFloat m_attackElapsedTime;

	[NonSerialized]
	public ObscuredFloat m_spellElapsedTime;

	[NonSerialized]
	public Animator m_animator;

	[NonSerialized]
	public ActorAniEvent m_actorAniEvent;

	[NonSerialized]
	public bool m_furyHero;

	public GameObject m_damageHUDPosition;

	private GameObject PGDLJMDKCAF;

	public AudioClip[] m_audioClips;

	public GOHHBNABIDO m_multiSound;

	private EffectChanger ALGJCGCNOAC;

	private LinkedList<NDCNGDGAAIN> DFBGNEHOAHD;

	private float FJDDDIIHBAF;

	private byte HGHPFDHHPBF;

	[NonSerialized]
	public bool m_enable;

	private ObscuredByte ELLDOFEGKMJ;

	private ObscuredUInt FFLHOOPFHMM;

	private ObscuredUShort IBIKONGOAKN;

	private ObscuredUShort PKGNAADLLNE;

	private ObscuredUShort HGGCMNDHIPC;

	private ObscuredUShort IANMCKGEBNA;

	private ObscuredUInt OBDPODBBMDA;

	private ObscuredUInt MCEIJGCLIIO;

	private static uint[] KAAABNKKAJL;

	private ObscuredByte[] MNDDPGPFJNE;

	public ObscuredByte m_skillPoint;

	private NEFBHKKAMJF PLFLBNMECBJ;

	private KMNJPNBJACF MLHIMDGOBMB;

	private CLJOMPBCNOE FJKMEOKDGDB;

	private ObscuredBool PCDAEICLJIH;

	private HFDJCHHPKKJ MICGAGHIECO;

	private StateMachine LFCGGKCACPP;

	private Transform OGONHDMMABA;

	private float NOCOPPMPLGA;

	private UIHeroDamageHUD JFCMEMONMBC;

	private EveView PFHHNPPCOED;

	private ObscuredInt PDFEHFIOBKF;

	private ObscuredInt FKELMHPFDNN;

	public int m_v093RuneGoldTick;

	public int OGHDONMKDFC
	{
		get
		{
			return get_m_max_hp_base();
		}
	}

	public int FIPGMKMOEDH
	{
		get
		{
			return get_m_max_hp_add();
		}
	}

	public int LBJMNDBMNAE
	{
		get
		{
			return get_m_max_hp();
		}
	}

	public int DEPBFDGAEGJ
	{
		get
		{
			return get_m_hp_regen_base();
		}
	}

	public int PFNGGGAOMAA
	{
		get
		{
			return get_m_hp_regen_add();
		}
	}

	public float HOIDFECKIPK
	{
		get
		{
			return get_m_hp_regen_add_percent();
		}
	}

	public int JKOEPLLJDKM
	{
		get
		{
			return get_m_hp_regen();
		}
	}

	public int EPEOOHJBIBL
	{
		get
		{
			return get_m_max_mp_base();
		}
	}

	public int FEMNCNMLFNA
	{
		get
		{
			return get_m_max_mp_add();
		}
	}

	public int OCOOIOGCOEE
	{
		get
		{
			return get_m_max_mp();
		}
	}

	public int KILNDBGINEF
	{
		get
		{
			return get_m_mp_regen_base();
		}
	}

	public int HHDEGDJBLJD
	{
		get
		{
			return get_m_mp_regen_add();
		}
	}

	public float KONDBHGNNJH
	{
		get
		{
			return get_m_mp_regen_add_percent();
		}
	}

	public int MGLIOBDEJLF
	{
		get
		{
			return get_m_mp_regen();
		}
	}

	public float KNAFNPGNOAE
	{
		get
		{
			return get_m_cooldown_percent_base();
		}
	}

	public float BEONNEGGBNM
	{
		get
		{
			return get_m_cooldown_percent_add();
		}
	}

	public float BDKLLIMAGPP
	{
		get
		{
			return get_m_cooldown_percent();
		}
	}

	public float OKLGOPIDHLH
	{
		get
		{
			return get_m_phy_att_base();
		}
	}

	public float NFGGINHNGJM
	{
		get
		{
			return get_m_phy_att_add();
		}
	}

	public float LHEKBMLAJMA
	{
		get
		{
			return get_m_phy_att();
		}
	}

	public float FBBOCCNNHOH
	{
		get
		{
			return get_m_phy_def_base();
		}
	}

	public float OGNDMFLHAFE
	{
		get
		{
			return get_m_phy_def_add();
		}
	}

	public float FBEBCNEPHJD
	{
		get
		{
			return get_m_phy_def();
		}
	}

	public float JJBDMMBFNLI
	{
		get
		{
			return get_m_mag_att_base();
		}
	}

	public float IPHHAAHAFFF
	{
		get
		{
			return get_m_mag_att_add();
		}
	}

	public float KBMBFHHNDPE
	{
		get
		{
			return get_m_mag_att();
		}
	}

	public float PNBKNIHMKJN
	{
		get
		{
			return get_m_mag_def_base();
		}
	}

	public float KHDDLEGHKND
	{
		get
		{
			return get_m_mag_def_add();
		}
	}

	public float NLMHKBGDKLA
	{
		get
		{
			return get_m_mag_def();
		}
	}

	public float IIICODNIMNN
	{
		get
		{
			return get_m_att_range();
		}
	}

	public float GDHKHDCOLLI
	{
		get
		{
			return get_m_att_speed_base();
		}
	}

	public float BGPDHFKEHFH
	{
		get
		{
			return get_m_att_speed_add();
		}
	}

	public float PHCDIEDHDLH
	{
		get
		{
			return get_m_att_speed_add_percent();
		}
	}

	public float LNKFLFOGCCD
	{
		get
		{
			return get_m_att_speed();
		}
	}

	public float KKBDODGGMAM
	{
		get
		{
			return get_m_critical_percent_base();
		}
	}

	public float OGPBMOCIICF
	{
		get
		{
			return get_m_critical_percent_add();
		}
	}

	public float CJALIPCFCLA
	{
		get
		{
			return get_m_critical_percent();
		}
	}

	public float JDLIHBLCFDD
	{
		get
		{
			return get_m_life_steal_base();
		}
	}

	public float NJJBANBHDNK
	{
		get
		{
			return get_m_life_steal_add();
		}
	}

	public float DNKBBMEOPMN
	{
		get
		{
			return get_m_life_steal();
		}
	}

	public float BMALLGGBAIO
	{
		get
		{
			return get_m_mag_life_steal_base();
		}
	}

	public float CBFJCMMKAJN
	{
		get
		{
			return get_m_mag_life_steal_add();
		}
	}

	public float LKBGDNPEKAJ
	{
		get
		{
			return get_m_mag_life_steal();
		}
	}

	public float NEPGMKLCMFF
	{
		get
		{
			return get_m_move_speed();
		}
	}

	public float NJCBMDJOIAH
	{
		get
		{
			return get_m_phy_def_pass();
		}
	}

	public float LAAGBIKMHAE
	{
		get
		{
			return get_m_mag_def_pass();
		}
	}

	public NEFBHKKAMJF AGBOJPFKOIJ
	{
		get
		{
			return get_m_heroInfo();
		}
		protected set
		{
			IPBKFFHGCAD(value);
		}
	}

	public KMNJPNBJACF JGEGHKNBHGF
	{
		get
		{
			return get_m_gameItems();
		}
		protected set
		{
			LNDMNHECDNO(value);
		}
	}

	public CLJOMPBCNOE EECHPHHFNGD
	{
		get
		{
			return get_m_runeAbility();
		}
		protected set
		{
			IICEMDNOGEP(value);
		}
	}

	public ObscuredBool PPLNEGOBMAK
	{
		get
		{
			return get_m_cloaking();
		}
		protected set
		{
			LGHAHMLBHJJ(value);
		}
	}

	public HFDJCHHPKKJ BHKHGAOHDOE
	{
		get
		{
			return get_m_buffsInfo();
		}
		protected set
		{
			DDKIPFANAIC(value);
		}
	}

	public StateMachine KDDJDCHFFNP
	{
		get
		{
			return get_m_stateMachine();
		}
		protected set
		{
			NDNPJAHBMDP(value);
		}
	}

	public Transform NKLLEJLLNKA
	{
		get
		{
			return get_m_transform();
		}
		private set
		{
			LLGADBKNEOF(value);
		}
	}

	public float DMKJDOAOLDN
	{
		get
		{
			return get_m_frequency();
		}
		protected set
		{
			KIIBFPDIHOE(value);
		}
	}

	public float INMCDOIEJOC
	{
		get
		{
			return get_m_elapsedTime();
		}
	}

	public float KKBFDIKIKEJ
	{
		get
		{
			return get_m_attackCoolTime();
		}
	}

	public float FNDCANGLPLO
	{
		get
		{
			return get_m_spellCoolTime();
		}
	}

	public bool MJJFLBIHCJE
	{
		get
		{
			return get_IsMpHero();
		}
	}

	public UIHeroDamageHUD HCLPEDDCICN
	{
		get
		{
			return get_m_damageHUD();
		}
		protected set
		{
			CPCOODNEOCA(value);
		}
	}

	public string FAMLHOPJHHA
	{
		get
		{
			return get_m_resourceName();
		}
	}

	public EffectChanger LEGABAAGEAM
	{
		get
		{
			return get_EffectChanger();
		}
	}

	public EveView GHLOJMDIHNE
	{
		get
		{
			return get_m_view();
		}
		protected set
		{
			NOLEMPCHIGH(value);
		}
	}

	public byte DNKKEHGMMEO
	{
		get
		{
			return get_Level();
		}
	}

	public uint CLDOAPPKLKH
	{
		get
		{
			return get_Experience();
		}
	}

	public ushort ODFMMOGBFFI
	{
		get
		{
			return get_KillCount();
		}
	}

	public ushort IGCJAANKAPJ
	{
		get
		{
			return get_DeathCount();
		}
	}

	public ushort BKKIMAAEJNO
	{
		get
		{
			return get_AssistCount();
		}
	}

	public ushort INGHEFEIDLO
	{
		get
		{
			return get_MinionCount();
		}
	}

	public uint MANNDMECNEN
	{
		get
		{
			return get_GamePoint();
		}
	}

	public uint LCEIDNEFEDK
	{
		get
		{
			return get_TotalAttackDamage();
		}
	}

	public ObscuredInt CNCFLMCCJKF
	{
		get
		{
			return get_m_money();
		}
		protected set
		{
			NNCNGFFJHLM(value);
		}
	}

	public ObscuredInt IOIADJGLIMM
	{
		get
		{
			return get_m_autoMoney();
		}
		protected set
		{
			IJMKMDEBBAD(value);
		}
	}

	public float get_m_cooldown_percent_base()
	{
		return 0f;
	}

	public int get_m_mp_regen_add()
	{
		int num = 0;
		if (get_IsMpHero())
		{
			int num2 = get_m_gameItems().OAHFGIGJHHC();
			for (int i = 0; i < num2; i++)
			{
				if (get_m_gameItems().FPICNOOFDOA(i) != null)
				{
					num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().MGLIOBDEJLF;
				}
			}
			if (get_m_runeAbility() != null)
			{
				num += (int)(get_m_runeAbility().MGLIOBDEJLF + get_m_runeAbility().PAPMBLAMOGD * (float)(int)get_Level());
			}
		}
		if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Blue))
		{
			num += 25;
		}
		if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Baron))
		{
			num += 25;
		}
		return num;
	}

	public float get_m_att_range()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		return gPNKIAHCKMG.IIJMLJCIJFD().IIICODNIMNN;
	}

	public bool IsDeath()
	{
		if (get_m_stateMachine().get_m_state() == StateMachine.OEOIIKMBGAG.Death || (float)m_hp <= 0f)
		{
			return true;
		}
		return false;
	}

	public float get_m_phy_att_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		return gPNKIAHCKMG.IIJMLJCIJFD().LOJEMAMKHFD + gPNKIAHCKMG.IIJMLJCIJFD().ELDBGIKHAIO * (float)(get_Level() - 1);
	}

	[JDLHECHNNDH]
	public void OnKillHeroRpc(int ODOLPBKMIIO, byte JONLMGNMOGH)
	{
		Actor actor = null;
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ODOLPBKMIIO);
		if (eveView == null)
		{
			return;
		}
		actor = eveView.GetComponent<Actor>();
		if (actor == null)
		{
			return;
		}
		if (actor.m_actorType == IJJMDPGJAEM.Hero)
		{
			actor.IncreaseKillCount();
			bool flag = GameManager.get_Instance().SetFirstBlood();
			int num = GameManager.get_Instance().GetGoldAtKill(this);
			if (flag)
			{
				num += num / 2;
			}
			actor.IncreaseMoney(num);
			if (actor == ActorManager.get_Instance().GetControlActor())
			{
				actor.get_m_damageHUD().AddGold(num, Color.white, 0.2f);
			}
			if (flag)
			{
				SoundManager.get_Instance().PlaySound("FirstBlood");
			}
			else if (IsMyTeam())
			{
				SoundManager.get_Instance().PlaySound(string.Format("Death{0}", JONLMGNMOGH));
			}
			else
			{
				SoundManager.get_Instance().PlaySound(string.Format("Kill{0}", JONLMGNMOGH));
			}
		}
		else
		{
			SoundManager.get_Instance().PlaySound("DeathMyself");
		}
		IncreaseDeathCount();
		GameManager.get_Instance().OnKillHero(actor, this);
		actor.get_m_stateMachine().OnKillHero(this);
	}

	public float get_m_mag_att_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += (float)get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().KBMBFHHNDPE;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().KBMBFHHNDPE + get_m_runeAbility().OOJHKLBFHED * (float)(int)get_Level();
		}
		if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Baron))
		{
			num += 60f;
		}
		if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Dragon))
		{
			num += 20f;
		}
		if (get_m_gameItems().MBCEBKJDEAK(3109, 1) == 0)
		{
			num += (float)get_m_max_mp() * 0.03f;
		}
		return num;
	}

	public float AddMp(float BFEBCIGOMGL)
	{
		float num = BFEBCIGOMGL;
		if (BFEBCIGOMGL > 0f)
		{
			int max_mp = get_m_max_mp();
			float num2 = m_mp;
			float num3 = num2 + BFEBCIGOMGL;
			if (num3 > (float)max_mp)
			{
				num = (float)max_mp - num2;
				m_mp = max_mp;
			}
			else
			{
				num = BFEBCIGOMGL;
				m_mp = num3;
			}
		}
		else
		{
			float num4 = 0f;
			if (get_IsMpHero())
			{
				if (get_m_gameItems().MBCEBKJDEAK(3109, 1) == 0)
				{
					num4 -= 0.25f;
				}
				if (get_m_gameItems().MBCEBKJDEAK(3004, 1) == 0)
				{
					num4 -= 0.1f;
				}
				BFEBCIGOMGL += (float)(int)(BFEBCIGOMGL * num4);
				if (BFEBCIGOMGL >= 0f)
				{
					return 0f;
				}
			}
			float num5 = m_mp;
			float num6 = num5 + BFEBCIGOMGL;
			if (num6 < 0f)
			{
				num = 0f - num5;
				m_mp = 0f;
			}
			else
			{
				num = BFEBCIGOMGL;
				m_mp = num6;
			}
		}
		return num;
	}

	protected void IPBKFFHGCAD(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	public void OBDNNLGICFM(int JFILMHHIFGI)
	{
		NNCNGFFJHLM((int)JJBKJJNMDPG() + JFILMHHIFGI);
	}

	public void SetInfo(NEFBHKKAMJF PDACDEPJNFO, CLJOMPBCNOE GHJGDDKBAIB = null)
	{
		m_hero_id = PDACDEPJNFO.GPNKIAHCKMG.INGLCFJBNOB();
		IPBKFFHGCAD(PDACDEPJNFO);
		IICEMDNOGEP(GHJGDDKBAIB);
		m_hp = get_m_max_hp();
		m_mp = 0f;
		UpdateAbility();
	}

	public void OnMsgView(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		switch ((ICOGNNKEKHJ)IKKFLANGAEA)
		{
		case ICOGNNKEKHJ.Damage:
		{
			float ICENKPDOHBK7;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK7);
			float ICENKPDOHBK8;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK8);
			float ICENKPDOHBK9;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK9);
			float ICENKPDOHBK10;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK10);
			byte ICENKPDOHBK11;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK11);
			int ICENKPDOHBK12;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK12);
			if (base.gameObject != null)
			{
				OnApplyDamage(ICENKPDOHBK7, ICENKPDOHBK8, ICENKPDOHBK9, ICENKPDOHBK10, ICENKPDOHBK11, ICENKPDOHBK12);
			}
			break;
		}
		case ICOGNNKEKHJ.ChangeGameItem:
		{
			int ICENKPDOHBK6;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK6);
			get_m_gameItems().GJPFIPICBAM(OGJFDNEEDCP);
			NNCNGFFJHLM(ICENKPDOHBK6);
			if ((float)m_hp > (float)get_m_max_hp())
			{
				m_hp = get_m_max_hp();
			}
			if ((float)m_mp > (float)get_m_max_mp())
			{
				m_mp = get_m_max_mp();
			}
			break;
		}
		case ICOGNNKEKHJ.RequestRecovery:
			OnDeserializeView(OGJFDNEEDCP);
			break;
		case ICOGNNKEKHJ.ItemUse:
			get_m_gameItems().DLMNENJNMII(OGJFDNEEDCP);
			break;
		case ICOGNNKEKHJ.AddHp:
		{
			int ICENKPDOHBK15;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK15);
			float ICENKPDOHBK16;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK16);
			m_hp = ICENKPDOHBK16;
			break;
		}
		case ICOGNNKEKHJ.AddMp:
		{
			float ICENKPDOHBK13;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK13);
			float ICENKPDOHBK14;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK14);
			m_mp = ICENKPDOHBK14;
			break;
		}
		case ICOGNNKEKHJ.AddBuff:
		{
			ushort ICENKPDOHBK2;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
			int ICENKPDOHBK3;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
			float ICENKPDOHBK4;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK4);
			float ICENKPDOHBK5;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK5);
			Actor actor = null;
			if (ICENKPDOHBK3 >= 0)
			{
				EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ICENKPDOHBK3);
				if (eveView == null)
				{
					break;
				}
				actor = eveView.GetComponent<Actor>();
				if (actor == null)
				{
					break;
				}
			}
			get_m_buffsInfo().IFNLBPAIMJE(KIMJPIBNFGA.JJBDAOJIDAL().MDAEKOLGOOC().FPICNOOFDOA(ICENKPDOHBK2), actor, ICENKPDOHBK4, ICENKPDOHBK5);
			break;
		}
		case ICOGNNKEKHJ.RemoveBuff:
		{
			ushort ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			get_m_buffsInfo().KHFDBEEGPIL(ICENKPDOHBK);
			break;
		}
		case ICOGNNKEKHJ.RemoveAllCC:
			get_m_buffsInfo().ACBMHLOGIAF();
			break;
		}
	}

	public byte get_Level()
	{
		return ELLDOFEGKMJ;
	}

	public int AddHp(int LLAAHBDLNGP, bool GEBMJMANKFI = true)
	{
		if (LLAAHBDLNGP == 0)
		{
			return 0;
		}
		int num = 0;
		if (LLAAHBDLNGP > 0)
		{
			float num2 = 0f;
			if (GEBMJMANKFI && get_m_gameItems().MBCEBKJDEAK(6102, 1) == 0)
			{
				num2 += 0.2f;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.PainfulWound))
			{
				num2 -= 0.3f;
			}
			LLAAHBDLNGP += (int)((float)LLAAHBDLNGP * num2);
			if (LLAAHBDLNGP <= 0)
			{
				return 0;
			}
			int max_hp = get_m_max_hp();
			float num3 = m_hp;
			float num4 = num3 + (float)LLAAHBDLNGP;
			if (num4 > (float)max_hp)
			{
				num = (int)((float)max_hp - num3);
				m_hp = max_hp;
			}
			else
			{
				num = LLAAHBDLNGP;
				m_hp = num4;
			}
		}
		else
		{
			float num5 = m_hp;
			float num6 = num5 + (float)LLAAHBDLNGP;
			if (num6 <= 0f)
			{
				num = -(int)num5;
				m_hp = 0f;
				if (m_actorType == IJJMDPGJAEM.Hero && GetHumanSM() != null)
				{
					GetHumanSM().m_respawnRemainTime = GameManager.get_Instance().GetRespawnTime(get_Level());
				}
				if (get_m_view() != null && get_m_view().IsMine())
				{
					get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Death);
				}
			}
			else
			{
				num = LLAAHBDLNGP;
				m_hp = num6;
			}
		}
		if (get_m_damageHUD() != null)
		{
			get_m_damageHUD().Refresh();
		}
		return num;
	}

	public float get_m_critical_percent()
	{
		float num = get_m_critical_percent_base() + get_m_critical_percent_add();
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		if (gPNKIAHCKMG.INGLCFJBNOB() == 18)
		{
			num *= 2f;
		}
		else if (gPNKIAHCKMG.INGLCFJBNOB() == 20)
		{
			num += (float)m_mp * 0.0035f;
		}
		if (num > 0.85f)
		{
			num = 0.85f;
		}
		return num;
	}

	public void DGMEBEEMNNH(bool ICENKPDOHBK)
	{
		LGHAHMLBHJJ(ICENKPDOHBK);
		bool flag = false;
		if (ICENKPDOHBK)
		{
			if (IsMyTeam())
			{
				if (ALGJCGCNOAC != null)
				{
					ALGJCGCNOAC.LACMEKNHGFJ(1875f);
				}
			}
			else
			{
				if (ALGJCGCNOAC != null)
				{
					ALGJCGCNOAC.SetAlpha(889f);
				}
				flag = true;
			}
		}
		else if (ALGJCGCNOAC != null)
		{
			ALGJCGCNOAC.FKDDPLGECPF(878f);
		}
		if (flag)
		{
			if (get_m_damageHUD() != null)
			{
				get_m_damageHUD().gameObject.SetActive(true);
			}
			if (PGDLJMDKCAF != null)
			{
				PGDLJMDKCAF.SetActive(true);
			}
		}
		else
		{
			if (get_m_damageHUD() != null)
			{
				get_m_damageHUD().gameObject.SetActive(false);
			}
			if (PGDLJMDKCAF != null)
			{
				PGDLJMDKCAF.SetActive(false);
			}
		}
	}

	public int get_m_max_mp_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		return (int)(gPNKIAHCKMG.IIJMLJCIJFD().OCOOIOGCOEE + gPNKIAHCKMG.IIJMLJCIJFD().GHCBBJBDNPH * (get_Level() - 1));
	}

	public Vector3 GetDirection()
	{
		return GetHumanSM().m_direction;
	}

	public float get_m_elapsedTime()
	{
		return Time.deltaTime * get_m_frequency();
	}

	[SpecialName]
	public float BILOHJAEGCG()
	{
		return Time.deltaTime * get_m_frequency();
	}

	[SpecialName]
	public float IMKGGHDAPNA()
	{
		float num = 1205f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 1; i < num2; i++)
		{
			if (get_m_gameItems().DDIBAIMBOGJ(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).FHPMONKJDEL().ELOOOLLHHID;
			}
		}
		if (m_actorType == (IJJMDPGJAEM)7 && m_hero_id == -16 && get_m_buffsInfo().CKMKKIFJOPF((JGOOOBHDBCG.ACPICCBBPHF)89))
		{
			float num3 = get_m_max_hp();
			if (num3 > 1809f)
			{
				num += (569f - Mathf.Clamp01((float)m_hp / num3)) * 723f;
			}
		}
		return num;
	}

	public void SetAnimation(string NCADFOBAFJD)
	{
		if (m_animator == null)
		{
			return;
		}
		if (NCADFOBAFJD == "run")
		{
			m_animator.speed = m_moveSpeed * get_m_frequency();
		}
		else
		{
			m_animator.speed = 1f;
		}
		if (NCADFOBAFJD.Contains("attack") || NCADFOBAFJD.Contains("critical"))
		{
			float att_speed = get_m_att_speed();
			if (att_speed > 1f)
			{
				m_animator.speed = att_speed;
			}
			else
			{
				m_animator.speed = 1f;
			}
			m_animator.Play(NCADFOBAFJD, -1, 0f);
		}
		else if (NCADFOBAFJD.Contains("skill"))
		{
			m_animator.Play(NCADFOBAFJD, -1, 0f);
		}
		else
		{
			m_animator.Play(NCADFOBAFJD, -1, 0f);
		}
		m_animator.Update(0f);
	}

	public void SetFrequency(float LFNNGEKFJBI)
	{
		KIIBFPDIHOE(LFNNGEKFJBI);
		if (m_animator != null)
		{
			m_animator.speed = LFNNGEKFJBI;
		}
	}

	public float get_m_spellCoolTime()
	{
		return 261.351f;
	}

	public string get_m_resourceName()
	{
		if (GetHeroInfo() == null || GetHeroInfo().GPNKIAHCKMG == null)
		{
			return string.Empty;
		}
		return GetHeroInfo().GPNKIAHCKMG.BKAJABLECGK();
	}

	public float get_m_mag_life_steal_base()
	{
		return 0f;
	}

	public UIHeroDamageHUD get_m_damageHUD()
	{
		return JFCMEMONMBC;
	}

	public float get_m_mag_def_pass()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += (float)get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().LAAGBIKMHAE;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().LAAGBIKMHAE;
		}
		return num;
	}

	protected void KIIBFPDIHOE(float ICENKPDOHBK)
	{
		NOCOPPMPLGA = ICENKPDOHBK;
	}

	[JDLHECHNNDH]
	public void OnPortalWarp(Vector3 HEPNHCEIFMO)
	{
		GameManager.get_Instance().ResetPortal();
		Warp(HEPNHCEIFMO);
		SoundManager.get_Instance().PlaySound("PortalWarp");
	}

	public bool IJBJAKPGGGN()
	{
		int num = 1;
		if (NetworkManager.APAPJEIBEDE() != null)
		{
			num = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
				.GDMBDKBCNBD() % 3;
		}
		if (m_team == num)
		{
			return false;
		}
		return false;
	}

	public ushort get_MinionCount()
	{
		return IANMCKGEBNA;
	}

	protected void IICEMDNOGEP(CLJOMPBCNOE ICENKPDOHBK)
	{
		FJKMEOKDGDB = ICENKPDOHBK;
	}

	[JDLHECHNNDH]
	public void OnAssistHeroRpc(int ODOLPBKMIIO, int JFILMHHIFGI)
	{
		Actor actor = null;
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(ODOLPBKMIIO);
		if (eveView == null)
		{
			return;
		}
		actor = eveView.GetComponent<Actor>();
		if (actor == null)
		{
			return;
		}
		if (actor.m_actorType == IJJMDPGJAEM.Hero)
		{
			actor.IncreaseAssistCount();
			actor.IncreaseMoney(JFILMHHIFGI);
			if (actor == ActorManager.get_Instance().GetControlActor())
			{
				actor.get_m_damageHUD().AddGold(JFILMHHIFGI, Color.white, 0.2f);
			}
		}
		actor.get_m_stateMachine().OnAssistHero(this);
	}

	public static uint GetExpFromLevel(byte DDILAEMMCAJ)
	{
		CGAMDJPGLBB();
		return KAAABNKKAJL[DDILAEMMCAJ];
	}

	[SpecialName]
	public int FBNBKKOAPOJ()
	{
		int num = get_m_max_hp_base() + get_m_max_hp_add();
		if (m_hero_id == -26)
		{
			num += (int)(get_m_mag_att_add() * 1315f);
		}
		return num;
	}

	public float GetBodyRadius()
	{
		if (m_navMeshAgent == null)
		{
			UnityEngine.AI.NavMeshObstacle component = GetComponent<UnityEngine.AI.NavMeshObstacle>();
			if (component != null)
			{
				return component.radius * 2f;
			}
			return 0f;
		}
		return m_navMeshAgent.radius;
	}

	public bool DecreaseMoney(int JFILMHHIFGI)
	{
		if (JFILMHHIFGI > (int)get_m_money())
		{
			return false;
		}
		NNCNGFFJHLM((int)get_m_money() - JFILMHHIFGI);
		return true;
	}

	public void LLNHEAFGKBP(Actor KAIIFOEGFMI)
	{
		if (KAIIFOEGFMI == null || KAIIFOEGFMI.m_actorType != (IJJMDPGJAEM)6 || m_actorType != IJJMDPGJAEM.Unknown)
		{
			return;
		}
		for (LinkedListNode<NDCNGDGAAIN> linkedListNode = DFBGNEHOAHD.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			NDCNGDGAAIN value = linkedListNode.Value;
			if (value.MEDAGKOPJMO == KAIIFOEGFMI)
			{
				DFBGNEHOAHD.Remove(linkedListNode);
				break;
			}
		}
		DFBGNEHOAHD.AddLast(new NDCNGDGAAIN(KAIIFOEGFMI, 78f));
	}

	protected void IJMKMDEBBAD(ObscuredInt ICENKPDOHBK)
	{
		FKELMHPFDNN = ICENKPDOHBK;
	}

	public bool IsLive()
	{
		return !IsDeath();
	}

	public float get_m_hp_regen_add_percent()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().ELOOOLLHHID;
			}
		}
		if (m_actorType == IJJMDPGJAEM.Hero && m_hero_id == 26 && get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill1))
		{
			float num3 = get_m_max_hp();
			if (num3 > 0f)
			{
				num += (1f - Mathf.Clamp01((float)m_hp / num3)) * 0.5f;
			}
		}
		return num;
	}

	public void AddLastAttacker(Actor KAIIFOEGFMI)
	{
		if (KAIIFOEGFMI == null || KAIIFOEGFMI.m_actorType != IJJMDPGJAEM.Hero || m_actorType != IJJMDPGJAEM.Hero)
		{
			return;
		}
		for (LinkedListNode<NDCNGDGAAIN> linkedListNode = DFBGNEHOAHD.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			NDCNGDGAAIN value = linkedListNode.Value;
			if (value.MEDAGKOPJMO == KAIIFOEGFMI)
			{
				DFBGNEHOAHD.Remove(linkedListNode);
				break;
			}
		}
		DFBGNEHOAHD.AddLast(new NDCNGDGAAIN(KAIIFOEGFMI, 0f));
	}

	public void Warp(Vector3 HEPNHCEIFMO)
	{
		if (m_navMeshAgent != null && m_navMeshAgent.enabled)
		{
			m_navMeshAgent.Warp(HEPNHCEIFMO);
		}
		else
		{
			get_m_transform().position = HEPNHCEIFMO;
		}
	}

	[SpecialName]
	public ObscuredInt JJBKJJNMDPG()
	{
		return PDFEHFIOBKF;
	}

	public void StageInit(Vector3 HEPNHCEIFMO)
	{
		get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Idle);
	}

	public bool SkillLevelUp(byte KLGHHEDJLCA)
	{
		if (!IsPossibleSkillLevelUp(KLGHHEDJLCA))
		{
			return false;
		}
		if ((byte)MNDDPGPFJNE[KLGHHEDJLCA] == 0)
		{
			GetHumanSM().GetCastSkill(KLGHHEDJLCA).IHKCKBJBEGF = 1000f;
		}
		++MNDDPGPFJNE[KLGHHEDJLCA];
		--m_skillPoint;
		if (get_m_view().IsMine())
		{
			get_m_view().RPC("OnChangeSkillLevelRpc", DJJPAPENCLN.Others, KLGHHEDJLCA, (byte)MNDDPGPFJNE[KLGHHEDJLCA], (byte)m_skillPoint);
		}
		return true;
	}

	public NEFBHKKAMJF get_m_heroInfo()
	{
		return PLFLBNMECBJ;
	}

	public float get_m_move_speed()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		return gPNKIAHCKMG.IIJMLJCIJFD().NEPGMKLCMFF;
	}

	public int get_m_hp_regen_add()
	{
		int num = 0;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().JKOEPLLJDKM;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += (int)(get_m_runeAbility().JKOEPLLJDKM + get_m_runeAbility().KLLFADLJALD * (float)(int)get_Level());
		}
		if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Baron))
		{
			num += 50;
		}
		return num;
	}

	[CompilerGenerated]
	private void OIEEAOKENFL(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OnSerializeView(OGJFDNEEDCP);
	}

	private void Start()
	{
		ActorManager.get_Instance().RegisterActor(this);
		m_enable = true;
		if (m_damageHUDPosition != null && get_m_damageHUD() == null)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(Resources.Load("HUD/HeroDamageHUD"));
			CPCOODNEOCA(gameObject.GetComponent<UIHeroDamageHUD>());
			get_m_damageHUD().SetInfo(this, m_damageHUDPosition.transform);
		}
		if (m_actorType == IJJMDPGJAEM.Hero)
		{
			m_multiSound.DOEFMBOKLHF(ActorManager.get_Instance().m_heroCommonAudioClips);
		}
	}

	public bool IncreaseExp(uint PNJKANMGGBA)
	{
		PNJKANMGGBA = V093RuneBattleFix.ApplyExperience(PNJKANMGGBA, this);
		FFLHOOPFHMM = (uint)FFLHOOPFHMM + PNJKANMGGBA;
		if ((uint)FFLHOOPFHMM > GetMaxExp())
		{
			FFLHOOPFHMM = GetMaxExp();
		}
		byte b = ELLDOFEGKMJ;
		ELLDOFEGKMJ = GetLevelFromExp(FFLHOOPFHMM);
		byte b2 = ELLDOFEGKMJ;
		if (b2 != b)
		{
			m_skillPoint = (byte)((byte)m_skillPoint + b2 - b);
			UpdateAbility();
			if (get_m_view() != null && get_m_view().IsMine())
			{
				get_m_view().RPC("OnSetLevelRpc", DJJPAPENCLN.Others, b2, get_Experience());
			}
			return true;
		}
		return false;
	}

	public float get_m_phy_att()
	{
		float num = get_m_phy_att_base() + get_m_phy_att_add();
		if (m_actorType == IJJMDPGJAEM.Hero)
		{
			ALBEPPGKFMM aLBEPPGKFMM = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.TryndamereSkill1);
			if (aLBEPPGKFMM != null && aLBEPPGKFMM.FEFNGALOFDI() != null)
			{
				float num2 = 20f + (float)(aLBEPPGKFMM.FEFNGALOFDI().GetSkillLevel(1) - 1) * 15f;
				num -= num2;
			}
			if (m_hero_id == 26 && get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
			{
				num += num * 0.3f;
				num += 15f + (float)(GetSkillLevel(3) - 1) * 5f;
			}
		}
		if (num < 0f)
		{
			num = 0f;
		}
		return num;
	}

	public bool IsMyTeam()
	{
		int num = 0;
		if (NetworkManager.get_Instance() != null)
		{
			num = NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
				.GDMBDKBCNBD() % 2;
		}
		if (m_team == num)
		{
			return true;
		}
		return false;
	}

	public void IncreaseTotalAttackDamage(uint APEMNIIDCJG)
	{
		MCEIJGCLIIO = (uint)MCEIJGCLIIO + APEMNIIDCJG;
	}

	public float GetAttackCoolTimeRate()
	{
		return (float)m_attackElapsedTime / get_m_attackCoolTime();
	}

	public void AddMpRemote(float BFEBCIGOMGL)
	{
		MEMHFGCLGPO mEMHFGCLGPO = new MEMHFGCLGPO();
		mEMHFGCLGPO.BFEBCIGOMGL = BFEBCIGOMGL;
		mEMHFGCLGPO.KNIAJMGDGAA = this;
		if (get_m_view().IsMine())
		{
			mEMHFGCLGPO.BFEBCIGOMGL = AddMp(mEMHFGCLGPO.BFEBCIGOMGL);
			get_m_view().Msg(25, DJJPAPENCLN.Others, true, mEMHFGCLGPO.GIFCOBOLJDO);
		}
	}

	public float get_m_mag_def()
	{
		return get_m_mag_def_base() + get_m_mag_def_add();
	}

	public int get_m_max_mp()
	{
		return get_m_max_mp_base() + get_m_max_mp_add();
	}

	public bool get_IsMpHero()
	{
		if (!m_furyHero && m_hero_id != 3 && m_hero_id != 6 && m_hero_id != 10 && m_hero_id != 13)
		{
			return true;
		}
		return false;
	}

	public void IncreaseAutoMoney(int JFILMHHIFGI)
	{
		JFILMHHIFGI = V093RuneBattleFix.ApplyAutoGold(JFILMHHIFGI, this);
		if (PhoneLOLModeRules.Enabled) JFILMHHIFGI *= 2;
		IJMKMDEBBAD((int)get_m_autoMoney() + JFILMHHIFGI);
		NNCNGFFJHLM((int)get_m_money() + JFILMHHIFGI);
	}

	public float GetSpellCoolTimeRate()
	{
		return (float)m_spellElapsedTime / get_m_spellCoolTime();
	}

	protected void NOLEMPCHIGH(EveView ICENKPDOHBK)
	{
		PFHHNPPCOED = ICENKPDOHBK;
	}

	public float get_m_frequency()
	{
		return NOCOPPMPLGA;
	}

	public void Move(Vector3 BFEECILPJLM, bool GDEMKNOABKN = false)
	{
		if (m_navMeshAgent != null && m_navMeshAgent.enabled)
		{
			m_navMeshAgent.Move(BFEECILPJLM);
			return;
		}
		get_m_transform().position = get_m_transform().position + BFEECILPJLM;
		if (!GDEMKNOABKN)
		{
			return;
		}
		Terrain terrain = GameManager.get_Instance().get_m_terrain();
		if (terrain != null)
		{
			float num = terrain.SampleHeight(base.transform.localPosition);
			if (num >= -5f && num <= 5f)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, num, base.transform.localPosition.z);
			}
		}
	}

	public int get_m_mp_regen_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		float num = (int)(gPNKIAHCKMG.IIJMLJCIJFD().MGLIOBDEJLF + gPNKIAHCKMG.IIJMLJCIJFD().GFGOPIKFOAN * (float)(get_Level() - 1));
		return (int)num;
	}

	public void IncreaseMoney(int JFILMHHIFGI)
	{
		NNCNGFFJHLM((int)get_m_money() + JFILMHHIFGI);
	}

	public void IncreaseDeathCount()
	{
		++PKGNAADLLNE;
	}

	public float get_m_phy_def()
	{
		return get_m_phy_def_base() + get_m_phy_def_add();
	}

	public int get_m_hp_regen()
	{
		int hp_regen_base = get_m_hp_regen_base();
		return hp_regen_base + get_m_hp_regen_add() + (int)((float)hp_regen_base * get_m_hp_regen_add_percent());
	}

	public CLJOMPBCNOE get_m_runeAbility()
	{
		return FJKMEOKDGDB;
	}

	public int get_m_hp_regen_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		float num = (int)(gPNKIAHCKMG.IIJMLJCIJFD().JKOEPLLJDKM + gPNKIAHCKMG.IIJMLJCIJFD().BKOBAIPJAHP * (float)(get_Level() - 1));
		return (int)num;
	}

	public static byte GetLevelFromExp(uint PNJKANMGGBA)
	{
		CGAMDJPGLBB();
		for (uint num = 0u; num < KAAABNKKAJL.Length; num++)
		{
			if (PNJKANMGGBA < KAAABNKKAJL[num])
			{
				return (byte)(num - 1);
			}
		}
		return (byte)(KAAABNKKAJL.Length - 1);
	}

	public float get_m_phy_att_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += (float)get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().LHEKBMLAJMA;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().LHEKBMLAJMA + get_m_runeAbility().JGPIIFFIAIG * (float)(int)get_Level();
		}
		if (m_actorType == IJJMDPGJAEM.Hero)
		{
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Baron))
			{
				num += 60f;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Dragon))
			{
				num += 20f;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.DariusPassiveEx))
			{
				num += (float)(30 + (get_Level() - 1) * 10);
			}
		}
		return num;
	}

	public int get_m_max_hp_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		return (int)(gPNKIAHCKMG.IIJMLJCIJFD().LBJMNDBMNAE + gPNKIAHCKMG.IIJMLJCIJFD().EPKGCHPIHEL * (get_Level() - 1));
	}

	public void SetLevel(byte DDILAEMMCAJ)
	{
		if (DDILAEMMCAJ > 18)
		{
			DDILAEMMCAJ = 18;
		}
		ELLDOFEGKMJ = DDILAEMMCAJ;
	}

	public float get_m_life_steal()
	{
		float num = get_m_life_steal_base() + get_m_life_steal_add();
		return PhoneLOLModeRules.LifeSteal(num);
	}

	[SpecialName]
	public float NGHONDPBKFH()
	{
		float num = 198f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().DDIBAIMBOGJ(i) != null)
			{
				num += (float)get_m_gameItems().FPICNOOFDOA(i).FHPMONKJDEL().LAAGBIKMHAE;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().LAAGBIKMHAE;
		}
		return num;
	}

	public void UpdateAbility()
	{
		m_moveSpeed = get_m_move_speed();
	}

	private static void CGAMDJPGLBB()
	{
		if (KAAABNKKAJL == null)
		{
			KAAABNKKAJL = new uint[19];
			uint num = 280u;
			KAAABNKKAJL[2] = 280u;
			for (uint num2 = 3u; num2 < KAAABNKKAJL.Length; num2++)
			{
				num += 100;
				KAAABNKKAJL[num2] = KAAABNKKAJL[num2 - 1] + num;
			}
		}
	}

	public uint get_Experience()
	{
		return FFLHOOPFHMM;
	}

	public float get_m_mag_def_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += (float)get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().NLMHKBGDKLA;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().NLMHKBGDKLA + get_m_runeAbility().BNKPEMNKEMO * (float)(int)get_Level();
		}
		if (m_actorType == IJJMDPGJAEM.Hero && m_hero_id == 26 && !get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
		{
			num += 20f + (float)(GetSkillLevel(3) - 1) * 10f;
		}
		return num;
	}

	public GameObject CreateParticle(string NCADFOBAFJD, bool BLLOFLFALFM)
	{
		if (BLLOFLFALFM)
		{
			return CreateParticle(NCADFOBAFJD, GetCenterPosition(), Quaternion.identity);
		}
		return CreateParticle(NCADFOBAFJD, GetPosition(), Quaternion.identity);
	}

	public bool IsCurrentAnimation(string NCADFOBAFJD)
	{
		if (m_animator == null)
		{
			return false;
		}
		if (m_animator.GetCurrentAnimatorStateInfo(0).IsName(NCADFOBAFJD))
		{
			return true;
		}
		if (m_animator.GetNextAnimatorStateInfo(0).IsName(NCADFOBAFJD))
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	protected void PMEAMECDHNB(ObscuredInt ICENKPDOHBK)
	{
		FKELMHPFDNN = ICENKPDOHBK;
	}

	public bool IsMaxLevel()
	{
		if (get_Level() >= 18)
		{
			return true;
		}
		return false;
	}

	public float get_m_life_steal_base()
	{
		return 0f;
	}

	public HumanSM GetHumanSM()
	{
		return (HumanSM)get_m_stateMachine();
	}

	public EffectChanger get_EffectChanger()
	{
		return ALGJCGCNOAC;
	}

	public virtual NEFBHKKAMJF GetHeroInfo()
	{
		if (get_m_stateMachine() == null)
		{
			return null;
		}
		if (get_m_stateMachine().get_m_owner() != null)
		{
			return get_m_stateMachine().get_m_owner().GetHeroInfo();
		}
		return get_m_heroInfo();
	}

	public void OnApplyDamage(float BGFHMLEOCAA, float JHNOPENIBNJ, float NFNACNPBOOO, float JOMNACCCAJG, byte JBJEMLFEBGK, int HGIGECICLLJ)
	{
		if (get_m_stateMachine() == null)
		{
			return;
		}
		m_hp = BGFHMLEOCAA;
        var practice = get_m_stateMachine() as PhoneLOLPracticeGuardSM;
        if (practice != null && BGFHMLEOCAA <= 0f) {
            // Award only the configured training bounty, then revive without normal kill events.
            practice.ApplyKillReward(HGIGECICLLJ);
            practice.OnEnterDeath();
            return;
        }
		if (BGFHMLEOCAA <= 0f)
		{
			get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Death);
		}
		if (m_actorType == IJJMDPGJAEM.Hero)
		{
			GetHumanSM().CancelReturnHome();
		}
		EveView eveView = EveUnityNetwork.get_Instance().get_m_peer().NLALKBLCPFK(HGIGECICLLJ);
		if (eveView == null)
		{
			return;
		}
		Actor component = eveView.GetComponent<Actor>();
		if (component == null)
		{
			return;
		}
		if (component.GetHeroInfo() != null)
		{
			component.IncreaseTotalAttackDamage((uint)JHNOPENIBNJ);
		}
		ALBEPPGKFMM aLBEPPGKFMM = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.ZedSkill3);
		if (aLBEPPGKFMM != null)
		{
			aLBEPPGKFMM.PMIMCLENGDE(JHNOPENIBNJ, component);
		}
		if (get_m_damageHUD() != null)
		{
			get_m_damageHUD().Refresh();
		}
		if (m_actorType == IJJMDPGJAEM.Hero && component.m_actorType == IJJMDPGJAEM.Hero)
		{
			AddLastAttacker(component);
			Actor actorInRange = ActorManager.get_Instance().GetActorInRange(this, 8f, true, true, IJJMDPGJAEM.Turret);
			if (actorInRange != null)
			{
				TurretSM turretSM = actorInRange.get_m_stateMachine() as TurretSM;
				if (turretSM != null)
				{
					turretSM.SetHeroTarget(component);
				}
			}
			if (JBJEMLFEBGK == 0 && get_m_gameItems().MBCEBKJDEAK(6103, 1) == 0)
			{
				component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, this, 1f, 0.15f);
			}
		}
		if (m_actorType != IJJMDPGJAEM.Turret && component.m_actorType == IJJMDPGJAEM.Hero && component.IsLive())
		{
			switch (JBJEMLFEBGK)
			{
			case 0:
			{
				float life_steal = component.get_m_life_steal();
				if (life_steal > 0f)
				{
					component.AddHp((int)(JHNOPENIBNJ * life_steal));
				}
				break;
			}
			case 1:
			{
				float mag_life_steal = component.get_m_mag_life_steal();
				if (mag_life_steal > 0f)
				{
					component.AddHp((int)((double)(JHNOPENIBNJ * mag_life_steal) * 0.8));
				}
				break;
			}
			}
			if (m_actorType == IJJMDPGJAEM.Monster && m_hero_id != 20002 && m_hero_id != 20003 && component.get_m_gameItems().MBCEBKJDEAK(8001, 1) == 0)
			{
				component.AddHp((int)(JHNOPENIBNJ * 0.1f), false);
			}
		}
		if ((JBJEMLFEBGK == 0 || JBJEMLFEBGK == 1) && component.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Red))
		{
			get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.RedDebuff, component);
		}
		if ((JBJEMLFEBGK == 0 || JBJEMLFEBGK == 1) && component.m_actorType == IJJMDPGJAEM.Hero && get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1))
		{
			ALBEPPGKFMM aLBEPPGKFMM2 = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1);
			if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.FEFNGALOFDI() != null && aLBEPPGKFMM2.FEFNGALOFDI().IsLive() && aLBEPPGKFMM2.FEFNGALOFDI().m_team != m_team)
			{
				aLBEPPGKFMM2.FEFNGALOFDI().get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.LucianSkill1SpeedUp);
			}
		}
		if (JBJEMLFEBGK == 0 && component.m_actorType == IJJMDPGJAEM.Hero && m_actorType == IJJMDPGJAEM.Hero && component.get_m_gameItems().MBCEBKJDEAK(1104, 1) == 0)
		{
			component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent, null, 2f, 0.06f);
		}
		if (BGFHMLEOCAA <= 0f)
		{
			if (m_actorType == IJJMDPGJAEM.Hero)
			{
				GetHumanSM().m_respawnRemainTime = GameManager.get_Instance().GetRespawnTime(get_Level());
				Actor actor = component;
				if (actor.m_actorType != IJJMDPGJAEM.Hero)
				{
					NDCNGDGAAIN lastAttacker = GetLastAttacker();
					if (lastAttacker != null && lastAttacker.IEHGFJKIDHI())
					{
						actor = lastAttacker.MEDAGKOPJMO;
					}
				}
				if (actor.FJDDDIIHBAF <= 10f)
				{
					actor.HGHPFDHHPBF++;
				}
				else
				{
					actor.HGHPFDHHPBF = 1;
				}
				actor.FJDDDIIHBAF = 0f;
				if (get_m_view().IsMine())
				{
					get_m_view().RPC("OnKillHeroRpc", DJJPAPENCLN.Others, actor.get_m_view().get_viewID(), actor.HGHPFDHHPBF);
					OnKillHeroRpc(actor.get_m_view().get_viewID(), actor.HGHPFDHHPBF);
					int num = 0;
					LinkedListNode<NDCNGDGAAIN> linkedListNode = DFBGNEHOAHD.First;
					while (linkedListNode != null)
					{
						NDCNGDGAAIN value = linkedListNode.Value;
						linkedListNode = linkedListNode.Next;
						if (value.IEHGFJKIDHI() && value.MEDAGKOPJMO != actor && value.MEDAGKOPJMO.m_actorType == IJJMDPGJAEM.Hero)
						{
							num++;
						}
					}
					if (num > 0)
					{
						int num2 = GameManager.get_Instance().GetGoldAtKill(this) / 2 / num;
						for (linkedListNode = DFBGNEHOAHD.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
						{
							NDCNGDGAAIN value2 = linkedListNode.Value;
							if (value2.IEHGFJKIDHI() && value2.MEDAGKOPJMO != actor && value2.MEDAGKOPJMO.m_actorType == IJJMDPGJAEM.Hero)
							{
								get_m_view().RPC("OnAssistHeroRpc", DJJPAPENCLN.Others, value2.MEDAGKOPJMO.get_m_view().get_viewID(), num2);
								OnAssistHeroRpc(value2.MEDAGKOPJMO.get_m_view().get_viewID(), num2);
							}
						}
					}
				}
				if (component.m_actorType == IJJMDPGJAEM.Hero && component.get_m_view().IsMine())
				{
					ALBEPPGKFMM aLBEPPGKFMM3 = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.Red);
					if (aLBEPPGKFMM3 != null)
					{
						component.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Red);
					}
					ALBEPPGKFMM aLBEPPGKFMM4 = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.Blue);
					if (aLBEPPGKFMM4 != null)
					{
						component.get_m_buffsInfo().COFJEHDAFPO(JGOOOBHDBCG.ACPICCBBPHF.Blue);
					}
				}
			}
			if (m_actorType == IJJMDPGJAEM.Minion || m_actorType == IJJMDPGJAEM.Monster)
			{
				if (component.m_actorType == IJJMDPGJAEM.Hero)
				{
					int goldAtKill = GameManager.get_Instance().GetGoldAtKill(this);
					if (m_hero_id == 20002 || m_hero_id == 20003)
					{
						List<Actor> teamActor = ActorManager.get_Instance().GetTeamActor(component.m_team, IJJMDPGJAEM.Hero);
						for (int i = 0; i < teamActor.Count; i++)
						{
							Actor actor2 = teamActor[i];
							actor2.IncreaseMoney(goldAtKill);
							if (m_hero_id == 20002)
							{
								actor2.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Dragon);
							}
							else if (m_hero_id == 20003)
							{
								actor2.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Baron);
								Actor teamActor2 = ActorManager.get_Instance().GetTeamActor(component.m_team, 31000);
								if (teamActor2 != null)
								{
									teamActor2.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.SpawnSuperMinion);
								}
							}
							if (actor2 == ActorManager.get_Instance().GetControlActor())
							{
								actor2.get_m_damageHUD().AddGold(goldAtKill, Color.white, 0.2f);
								SoundManager.get_Instance().PlaySound("ui_take_coin");
							}
						}
					}
					else
					{
						component.IncreaseMinionCount();
						component.IncreaseMoney(goldAtKill);
						component.IncreaseGamePoint((uint)goldAtKill);
						if (component == ActorManager.get_Instance().GetControlActor())
						{
							component.get_m_damageHUD().AddGold(goldAtKill, Color.white, 0.2f);
							SoundManager.get_Instance().PlaySound("ui_take_coin");
						}
					}
					GameManager.get_Instance().KillMonster((ushort)m_hero_id, component.GetPosition());
				}
				List<Actor> allActorInRange = ActorManager.get_Instance().GetAllActorInRange(this, 8f, false, false, IJJMDPGJAEM.Hero);
				if (allActorInRange.Count > 0)
				{
					float num3 = GameManager.get_Instance().GetExpAtKill(this) / (float)allActorInRange.Count;
					for (int j = 0; j < allActorInRange.Count; j++)
					{
						allActorInRange[j].IncreaseExp((uint)num3);
					}
				}
				if (m_hero_id == 20000)
				{
					component.get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.Red);
					component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Red);
				}
				else if (m_hero_id == 20001)
				{
					component.get_m_buffsInfo().KHFDBEEGPIL(JGOOOBHDBCG.ACPICCBBPHF.Blue);
					component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Blue);
				}
			}
			if (m_actorType == IJJMDPGJAEM.Minion && component.m_actorType == IJJMDPGJAEM.Hero)
			{
				List<Actor> allActorInRange2 = ActorManager.get_Instance().GetAllActorInRange(component, 14f, true, false, IJJMDPGJAEM.Hero);
				for (int k = 0; k < allActorInRange2.Count; k++)
				{
					bool flag = false;
					int num4 = 0;
					if (!(component == allActorInRange2[k]))
					{
						if (allActorInRange2[k].get_m_gameItems().MBCEBKJDEAK(8013, 1) == 0)
						{
							num4 = 9;
							allActorInRange2[k].IncreaseMoney(num4);
							flag = true;
						}
						else if (allActorInRange2[k].get_m_gameItems().MBCEBKJDEAK(8012, 1) == 0)
						{
							num4 = 8;
							allActorInRange2[k].IncreaseMoney(num4);
							flag = true;
						}
						else if (allActorInRange2[k].get_m_gameItems().MBCEBKJDEAK(8011, 1) == 0)
						{
							num4 = 4;
							allActorInRange2[k].IncreaseMoney(num4);
							flag = true;
						}
						if (flag && allActorInRange2[k] == ActorManager.get_Instance().GetControlActor())
						{
							allActorInRange2[k].get_m_damageHUD().AddGold(num4, Color.white, 0.2f);
							SoundManager.get_Instance().PlaySound("ui_take_coin");
						}
					}
				}
			}
			if (m_actorType == IJJMDPGJAEM.Turret)
			{
				int goldAtKill2 = GameManager.get_Instance().GetGoldAtKill(this);
				int oIOCBJMKGCD = 0;
				if (m_team == 0)
				{
					oIOCBJMKGCD = 1;
				}
				List<Actor> teamActor3 = ActorManager.get_Instance().GetTeamActor(oIOCBJMKGCD, IJJMDPGJAEM.Hero);
				for (int l = 0; l < teamActor3.Count; l++)
				{
					Actor actor3 = teamActor3[l];
					actor3.IncreaseMoney(goldAtKill2);
					if (actor3 == ActorManager.get_Instance().GetControlActor())
					{
						actor3.get_m_damageHUD().AddGold(goldAtKill2, Color.white, 0.2f);
						SoundManager.get_Instance().PlaySound("ui_take_coin");
					}
				}
				if (IsMyTeam())
				{
					SoundManager.get_Instance().PlaySound("DestroyMyTeamTurret");
				}
				else
				{
					SoundManager.get_Instance().PlaySound("DestroyOtherTeamTurret");
				}
			}
			if (m_actorType == IJJMDPGJAEM.Hero || m_actorType == IJJMDPGJAEM.Minion || m_actorType == IJJMDPGJAEM.Monster)
			{
				bool flag2 = false;
				if (NFNACNPBOOO > 0f && component.get_m_gameItems().MBCEBKJDEAK(1107, 1) == 0)
				{
					flag2 = true;
				}
				if (JBJEMLFEBGK == 0 && (component.get_m_gameItems().MBCEBKJDEAK(1009, 1) == 0 || component.get_m_gameItems().MBCEBKJDEAK(7001, 1) == 0))
				{
					flag2 = true;
				}
				if (flag2)
				{
					if (component.GetHeroInfo() != null && component.GetHeroInfo().GPNKIAHCKMG.OBDLBCLHIPC() == HNEBHCMAOAE.HFIHMACFPMM.Melee)
					{
						component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeed, null, 2f, 0.5f);
					}
					else
					{
						component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeed, null, 2f, 0.25f);
					}
				}
			}
		}
		else
		{
			if (JBJEMLFEBGK == 0)
			{
				if (get_m_gameItems().MBCEBKJDEAK(6014, 1) == 0)
				{
					component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack, this, 1f, 0.1f);
				}
				if (m_actorType == IJJMDPGJAEM.Hero && component.m_actorType == IJJMDPGJAEM.Hero && get_m_gameItems().MBCEBKJDEAK(6105, 1) == 0)
				{
					component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.PainfulWound, this, 3f);
					float num5 = 25f + (float)get_m_max_hp_add() * 0.05f;
					component.OnDamage(this, 0.0, num5, 0.0, 2);
				}
			}
			if (JBJEMLFEBGK == 1)
			{
				if (component.get_m_gameItems().MBCEBKJDEAK(3107, 1) == 0)
				{
					get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Slow, component, 1f, 0.2f);
				}
				if (component.get_m_gameItems().MBCEBKJDEAK(3108, 1) == 0)
				{
					get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.LiandryTorment, component);
				}
			}
			if (m_actorType == IJJMDPGJAEM.Hero || m_actorType == IJJMDPGJAEM.Minion || m_actorType == IJJMDPGJAEM.Monster)
			{
				if (component.get_m_gameItems().MBCEBKJDEAK(1108, 1) == 0)
				{
					get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.PainfulWound, this, 5f);
				}
				bool flag3 = false;
				if (NFNACNPBOOO > 0f && component.get_m_gameItems().MBCEBKJDEAK(1107, 1) == 0)
				{
					get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.BlackCleaver, this);
					flag3 = true;
				}
				if (JOMNACCCAJG > 0f && m_actorType == IJJMDPGJAEM.Hero && component.get_m_gameItems().MBCEBKJDEAK(3103, 1) == 0)
				{
					get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.PainfulWound, this, 5f);
				}
				if (JBJEMLFEBGK == 0 && (component.get_m_gameItems().MBCEBKJDEAK(1009, 1) == 0 || component.get_m_gameItems().MBCEBKJDEAK(7001, 1) == 0))
				{
					flag3 = true;
				}
				if (flag3)
				{
					if (component.GetHeroInfo() != null && component.GetHeroInfo().GPNKIAHCKMG.OBDLBCLHIPC() == HNEBHCMAOAE.HFIHMACFPMM.Melee)
					{
						component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeed, null, 2f, 0.15f);
					}
					else
					{
						component.get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeed, null, 2f, 0.08f);
					}
				}
			}
			if ((float)m_hp <= (float)get_m_max_hp() * 0.3f)
			{
				if (get_m_gameItems().MBCEBKJDEAK(1104, 1) == 0 && get_m_gameItems().EFKOCBLNIHA(1104))
				{
					float iCENKPDOHBK = 240f + (float)((byte)ELLDOFEGKMJ - 1) * 10f;
					get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.Shield, this, 2f, iCENKPDOHBK);
				}
				if (JOMNACCCAJG > 0f)
				{
					if (get_m_gameItems().MBCEBKJDEAK(1106, 1) == 0 && get_m_gameItems().EFKOCBLNIHA(1106))
					{
						get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.MagShield, this, 5f, 350f);
					}
					if (get_m_gameItems().MBCEBKJDEAK(1010, 1) == 0 && get_m_gameItems().EFKOCBLNIHA(1010))
					{
						float iCENKPDOHBK2 = 110f + (float)((byte)ELLDOFEGKMJ - 1) * 10f;
						get_m_buffsInfo().IFNLBPAIMJE(JGOOOBHDBCG.ACPICCBBPHF.MagShield, this, 5f, iCENKPDOHBK2);
					}
				}
			}
		}
		get_m_stateMachine().OnDamage(component, JHNOPENIBNJ);
	}

	public float get_m_cooldown_percent()
	{
		float num = get_m_cooldown_percent_base() + get_m_cooldown_percent_add();
		return PhoneLOLModeRules.CooldownReduction(num);
	}

	public void CreateMissileRPC(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Actor LPOAEBNAGCP)
	{
		if (GetHumanSM().IsMine())
		{
			get_m_view().RPC("CreateMissile", DJJPAPENCLN.All, NCADFOBAFJD, HEPNHCEIFMO, LPOAEBNAGCP.get_m_stateMachine().get_m_view().get_viewID());
		}
	}

	private void FixedUpdate()
	{
		DoUpdate();
	}

	public byte GetSkillLevel(int GBGBBGEPEMI)
	{
		return MNDDPGPFJNE[GBGBBGEPEMI];
	}

	public virtual void OnDestroy()
	{
		if (get_m_damageHUD() != null)
		{
			UnityEngine.Object.DestroyObject(get_m_damageHUD().gameObject);
		}
	}

	[JDLHECHNNDH]
	public void OnSetLevelRpc(byte DDILAEMMCAJ, uint PNJKANMGGBA)
	{
		ELLDOFEGKMJ = DDILAEMMCAJ;
		FFLHOOPFHMM = PNJKANMGGBA;
	}

	public void IncreaseAssistCount()
	{
		++HGGCMNDHIPC;
	}

	public EveView get_m_view()
	{
		return PFHHNPPCOED;
	}

	public void JNIPLJAFFFB(string NCADFOBAFJD)
	{
		if (m_animator == null)
		{
			return;
		}
		if (NCADFOBAFJD == "주문흡혈 {0}%\n")
		{
			m_animator.speed = m_moveSpeed * get_m_frequency();
		}
		else
		{
			m_animator.speed = 928f;
		}
		if (NCADFOBAFJD.Contains("skill0_missile_return") || NCADFOBAFJD.Contains("Singleton of "))
		{
			float att_speed = get_m_att_speed();
			if (att_speed > 576f)
			{
				m_animator.speed = att_speed;
			}
			else
			{
				m_animator.speed = 1126f;
			}
			m_animator.Play(NCADFOBAFJD, -1, 1000f);
		}
		else if (NCADFOBAFJD.Contains("buff_shield_loop"))
		{
			m_animator.Play(NCADFOBAFJD, -1, 1927f);
		}
		else
		{
			m_animator.Play(NCADFOBAFJD, -1, 383f);
		}
		m_animator.Update(793f);
	}

	public void IncreaseKillCount()
	{
		++IBIKONGOAKN;
	}

	protected void NDNPJAHBMDP(StateMachine ICENKPDOHBK)
	{
		LFCGGKCACPP = ICENKPDOHBK;
	}

	public void FJKBCHKIMCG(Vector3 BFEECILPJLM, bool GDEMKNOABKN = false)
	{
		if (m_navMeshAgent != null && m_navMeshAgent.enabled)
		{
			m_navMeshAgent.Move(BFEECILPJLM);
			return;
		}
		get_m_transform().position = get_m_transform().position + BFEECILPJLM;
		if (!GDEMKNOABKN)
		{
			return;
		}
		Terrain terrain = GameManager.get_Instance().get_m_terrain();
		if (terrain != null)
		{
			float num = terrain.SampleHeight(base.transform.localPosition);
			if (num >= 836f && num <= 1958f)
			{
				base.transform.localPosition = new Vector3(base.transform.localPosition.x, num, base.transform.localPosition.z);
			}
		}
	}

	public float get_m_mag_life_steal_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().MOHEOOEFLNK;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().MOHEOOEFLNK;
		}
		return num;
	}

	public float get_m_critical_percent_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().CJALIPCFCLA;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().CJALIPCFCLA;
		}
		return num;
	}

	public float get_m_phy_def_pass()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += (float)get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().NJCBMDJOIAH;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().NJCBMDJOIAH;
		}
		return num;
	}

	public float get_m_att_speed()
	{
		float num = get_m_att_speed_base() * (1f + get_m_att_speed_add_percent());
		float num2 = 0f;
		num2 -= get_m_buffsInfo().KDPEHABNMFC(JGOOOBHDBCG.ACPICCBBPHF.SlowAttack);
		num += num * num2;
		return PhoneLOLModeRules.AttackSpeed(num);
	}

	public ushort get_KillCount()
	{
		return IBIKONGOAKN;
	}

	public NDCNGDGAAIN GetLastAttacker()
	{
		if (DFBGNEHOAHD.Count <= 0)
		{
			return null;
		}
		return DFBGNEHOAHD.Last.Value;
	}

	public int get_m_max_hp_add()
	{
		int num = 0;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().NCBAGGNLLLK;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += (int)(get_m_runeAbility().NCBAGGNLLLK + get_m_runeAbility().MDAGHJFEODE * (float)(int)get_Level());
		}
		return num;
	}

	public Transform get_m_transform()
	{
		return OGONHDMMABA;
	}

	public float get_m_mag_def_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		float num = gPNKIAHCKMG.IIJMLJCIJFD().NLMHKBGDKLA + gPNKIAHCKMG.IIJMLJCIJFD().JFLFAKNHKNP * (float)(get_Level() - 1);
		ALBEPPGKFMM aLBEPPGKFMM = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill3);
		if (aLBEPPGKFMM != null)
		{
			num += (float)(20 + (GetSkillLevel(3) - 1) * 20);
			num += get_m_mag_att() * 0.2f;
		}
		return num;
	}

	[CompilerGenerated]
	private void MENMLKKMDHC(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = base.gameObject;
			component.m_direction = GetHumanSM().m_direction;
		}
	}

	public ushort get_AssistCount()
	{
		return HGGCMNDHIPC;
	}

	public float get_m_attackCoolTime()
	{
		return 1f / get_m_att_speed();
	}

	public ObscuredInt get_m_money()
	{
		return PDFEHFIOBKF;
	}

	public virtual float OnAttackDamage(Actor AECFMGGMOGH, double KDDLCDGFEME = 0.0, double PBNJAIOOGKN = 0.0, double OHEDEPKFAJE = 0.0)
	{
		Actor actor = AECFMGGMOGH;
		if (actor.get_m_stateMachine().get_m_owner() != null)
		{
			actor = actor.get_m_stateMachine().get_m_owner();
		}
		if (actor == null || actor.GetHeroInfo() == null)
		{
			return 0f;
		}
		double num = actor.get_m_phy_att();
		double num2 = actor.get_m_mag_att();
		double num3 = num;
		num3 += KDDLCDGFEME;
		double num4 = 0.0;
		num4 += PBNJAIOOGKN;
		if (m_actorType == IJJMDPGJAEM.Turret)
		{
			double num5 = num2 - num;
			if (num5 >= 1.0)
			{
				num4 += num5 * 0.20000000298023224;
			}
		}
		CreateDamageParticle(string.Format("Particle/{0}/hit", actor.get_m_resourceName()), actor, true);
		return OnDamage(actor, num3, num4, OHEDEPKFAJE, 0);
	}

	public virtual float OnDamage(Actor AECFMGGMOGH, double HKMFCFABKGI, double HANPEPIBBBG, double OHEDEPKFAJE = 0.0, byte JBJEMLFEBGK = 1)
	{
		HAHKNKFOCMJ hAHKNKFOCMJ = new HAHKNKFOCMJ();
		hAHKNKFOCMJ.JBJEMLFEBGK = JBJEMLFEBGK;
		hAHKNKFOCMJ.KNIAJMGDGAA = this;
		m_lastDamageInfo.PDCPMDCOLOD();
		try
		{
			KNGOMGNGLLD kNGOMGNGLLD = new KNGOMGNGLLD();
			kNGOMGNGLLD.EPBINAGMIIE = hAHKNKFOCMJ;
			kNGOMGNGLLD.KNIAJMGDGAA = this;
			kNGOMGNGLLD.KAIIFOEGFMI = AECFMGGMOGH;
			if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_stateMachine().get_m_owner() != null)
			{
				kNGOMGNGLLD.KAIIFOEGFMI = kNGOMGNGLLD.KAIIFOEGFMI.get_m_stateMachine().get_m_owner();
			}
			if (get_m_stateMachine().get_m_state() == StateMachine.OEOIIKMBGAG.Death || (float)m_hp <= 0f)
			{
				return 0f;
			}
			if (m_dontDamage)
			{
				return 0f;
			}
			if (m_hero_id == 30001)
			{
				if (ActorManager.get_Instance().GetTeamActor(m_team, 30000) != null)
				{
					return 0f;
				}
			}
			else if (m_hero_id == 30002)
			{
				if (ActorManager.get_Instance().GetTeamActor(m_team, 30001) != null)
				{
					return 0f;
				}
			}
			else if (m_hero_id == 31000 && ActorManager.get_Instance().GetTeamActor(m_team, 30002) != null)
			{
				return 0f;
			}
			bool flag = false;
			if (kNGOMGNGLLD.KAIIFOEGFMI.m_actorType == IJJMDPGJAEM.Hero && kNGOMGNGLLD.KAIIFOEGFMI.m_hero_id == 18)
			{
				flag = true;
			}
			if (hAHKNKFOCMJ.JBJEMLFEBGK == 0 && kNGOMGNGLLD.KAIIFOEGFMI.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TeemoSkill0Blind))
			{
				return 0f;
			}
			if (hAHKNKFOCMJ.JBJEMLFEBGK == 1 && m_hero_id == 14 && get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill2))
			{
				AddMpRemote(80f + (float)(GetSkillLevel(2) - 1) * 15f);
				get_m_buffsInfo().LIKOKCJNLLF(JGOOOBHDBCG.ACPICCBBPHF.SivirSkill2);
				return -1f;
			}
			if (m_hero_id == 27)
			{
				float num = 4f + get_m_mag_att() * 0.01f;
				HKMFCFABKGI = Mathf.Max((float)HKMFCFABKGI - num, (float)HKMFCFABKGI * 0.5f);
				HANPEPIBBBG = Mathf.Max((float)HANPEPIBBBG - num, (float)HANPEPIBBBG * 0.5f);
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.RivenSkill3))
			{
				HKMFCFABKGI *= 1.2;
			}
			kNGOMGNGLLD.JHNOPENIBNJ = 0f;
			kNGOMGNGLLD.NFNACNPBOOO = 0f;
			kNGOMGNGLLD.JOMNACCCAJG = 0f;
			float num2 = kNGOMGNGLLD.KAIIFOEGFMI.get_m_phy_def_pass();
			float num3 = kNGOMGNGLLD.KAIIFOEGFMI.get_m_mag_def_pass();
			if (kNGOMGNGLLD.KAIIFOEGFMI.m_actorType == IJJMDPGJAEM.Hero && kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems() != null)
			{
				if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().HFIPKEOBOPK(1105) != null)
				{
					num2 += get_m_phy_def() * 0.35f;
				}
				else if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().HFIPKEOBOPK(1108) != null)
				{
					num2 += get_m_phy_def() * 0.25f;
				}
				if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().HFIPKEOBOPK(3106) != null)
				{
					num3 += get_m_mag_def() * 0.4f;
				}
				if (hAHKNKFOCMJ.JBJEMLFEBGK == 0)
				{
					if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().MBCEBKJDEAK(3105, 1) == 0)
					{
						HANPEPIBBBG += (double)(15f + kNGOMGNGLLD.KAIIFOEGFMI.get_m_mag_att() * 0.15f);
					}
					if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().MBCEBKJDEAK(1101, 1) == 0 && m_actorType != IJJMDPGJAEM.Turret)
					{
						float num4 = (float)m_hp * 0.06f;
						if (m_actorType != IJJMDPGJAEM.Hero && num4 > 60f)
						{
							num4 = 60f;
						}
						HKMFCFABKGI += (double)num4;
					}
					if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().MBCEBKJDEAK(3006, 1) == 0 && kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().EFKOCBLNIHA(3006))
					{
						HANPEPIBBBG += (double)(50f + kNGOMGNGLLD.KAIIFOEGFMI.get_m_mag_att() * 0.15f);
					}
					if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().MBCEBKJDEAK(1109, 1) == 0)
					{
						kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().EMBOAOKJINO(1109, 10f);
						kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().FLAGEFLCOGP(1109, 100f, kNGOMGNGLLD.BHDLOPEDBIE);
					}
				}
			}
			if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.YasuoSkill3))
			{
				num2 *= 1.5f;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.ZedSkill3))
			{
				num2 += get_m_phy_def_add() * 0.4f;
			}
			if (kNGOMGNGLLD.KAIIFOEGFMI.m_hero_id == 23)
			{
				num2 += get_m_phy_def() * (0.05f + (float)(kNGOMGNGLLD.KAIIFOEGFMI.GetSkillLevel(2) - 1) * 0.05f);
			}
			if (m_actorType == IJJMDPGJAEM.Turret)
			{
				OHEDEPKFAJE = 0.0;
				num2 = 0f;
				num3 = 0f;
			}
			if (kNGOMGNGLLD.KAIIFOEGFMI.m_actorType == IJJMDPGJAEM.Turret)
			{
				num2 += 200f;
			}
			float num5 = get_m_phy_def();
			ALBEPPGKFMM aLBEPPGKFMM = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.BlackCleaver);
			if (aLBEPPGKFMM != null)
			{
				int num6 = Mathf.Min(aLBEPPGKFMM.DGMHBHFHHBL(), 6);
				float num7 = (float)num6 * 0.03f;
				num5 *= 1f - num7;
			}
			num5 -= num2;
			if (num5 < 0f)
			{
				num5 = 0f;
			}
			float num8 = num5 / (num5 + 120f);
			float mag_def = get_m_mag_def();
			mag_def -= num3;
			if (mag_def < 0f)
			{
				mag_def = 0f;
			}
			float num9 = mag_def / (mag_def + 100f);
			kNGOMGNGLLD.NFNACNPBOOO = (float)HKMFCFABKGI - (float)HKMFCFABKGI * num8;
			kNGOMGNGLLD.JOMNACCCAJG = (float)HANPEPIBBBG - (float)HANPEPIBBBG * num9;
			if (m_actorType == IJJMDPGJAEM.Monster && m_hero_id != 20002 && m_hero_id != 20003 && kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().MBCEBKJDEAK(8001, 1) == 0)
			{
				kNGOMGNGLLD.NFNACNPBOOO += 35f;
			}
			if (hAHKNKFOCMJ.JBJEMLFEBGK == 0 && m_actorType != IJJMDPGJAEM.Turret && UnityEngine.Random.Range(0f, 1f) > 1f - kNGOMGNGLLD.KAIIFOEGFMI.get_m_critical_percent())
			{
				if (kNGOMGNGLLD.KAIIFOEGFMI.get_m_gameItems().MBCEBKJDEAK(1102, 1) == 0)
				{
					kNGOMGNGLLD.NFNACNPBOOO *= 2.25f;
				}
				else
				{
					kNGOMGNGLLD.NFNACNPBOOO *= 2f;
				}
				if (flag)
				{
					kNGOMGNGLLD.NFNACNPBOOO *= 0.9f;
				}
				if (get_m_gameItems().MBCEBKJDEAK(6103, 1) == 0)
				{
					kNGOMGNGLLD.NFNACNPBOOO *= 0.9f;
				}
				m_lastDamageInfo.KKNMLHOHJNK = true;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.VladimirSkill3))
			{
				kNGOMGNGLLD.NFNACNPBOOO *= 1.15f;
				kNGOMGNGLLD.JOMNACCCAJG *= 1.15f;
			}
			ALBEPPGKFMM aLBEPPGKFMM2 = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.MagShield);
			if (aLBEPPGKFMM2 != null && aLBEPPGKFMM2.CGPEFIHCMDD > 0f)
			{
				if (aLBEPPGKFMM2.CGPEFIHCMDD <= kNGOMGNGLLD.JOMNACCCAJG)
				{
					kNGOMGNGLLD.JOMNACCCAJG -= aLBEPPGKFMM2.CGPEFIHCMDD;
					aLBEPPGKFMM2.CGPEFIHCMDD = 0f;
					get_m_buffsInfo().KHFDBEEGPIL(aLBEPPGKFMM2);
				}
				else
				{
					aLBEPPGKFMM2.CGPEFIHCMDD -= kNGOMGNGLLD.JOMNACCCAJG;
					kNGOMGNGLLD.JOMNACCCAJG = 0f;
				}
			}
			kNGOMGNGLLD.JHNOPENIBNJ = kNGOMGNGLLD.NFNACNPBOOO + kNGOMGNGLLD.JOMNACCCAJG + (float)OHEDEPKFAJE;
			float num10 = 0f;
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.GarenSkill1))
			{
				num10 -= kNGOMGNGLLD.JHNOPENIBNJ * 0.3f;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.MasterYiSkill1))
			{
				float num11 = 0.5f + (float)(GetSkillLevel(1) - 1) * 0.05f;
				if (kNGOMGNGLLD.KAIIFOEGFMI.m_actorType == IJJMDPGJAEM.Turret)
				{
					num11 *= 0.5f;
				}
				num10 -= kNGOMGNGLLD.JHNOPENIBNJ * num11;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.AlistarSkill3))
			{
				float num12 = 0.5f + (float)(GetSkillLevel(3) - 1) * 0.1f;
				if (kNGOMGNGLLD.KAIIFOEGFMI.m_actorType == IJJMDPGJAEM.Turret)
				{
					num12 *= 0.5f;
				}
				num10 -= kNGOMGNGLLD.JHNOPENIBNJ * num12;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill2))
			{
				if (hAHKNKFOCMJ.JBJEMLFEBGK == 0)
				{
					num10 -= kNGOMGNGLLD.JHNOPENIBNJ;
				}
				else if (hAHKNKFOCMJ.JBJEMLFEBGK == 1)
				{
					num10 -= kNGOMGNGLLD.JHNOPENIBNJ * 0.25f;
				}
			}
			kNGOMGNGLLD.JHNOPENIBNJ += num10;
			kNGOMGNGLLD.JHNOPENIBNJ = Mathf.Max(kNGOMGNGLLD.JHNOPENIBNJ, 0f);
			ALBEPPGKFMM aLBEPPGKFMM3 = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.Shield);
			if (aLBEPPGKFMM3 != null && aLBEPPGKFMM3.CGPEFIHCMDD > 0f)
			{
				if (aLBEPPGKFMM3.CGPEFIHCMDD <= kNGOMGNGLLD.JHNOPENIBNJ)
				{
					kNGOMGNGLLD.JHNOPENIBNJ -= aLBEPPGKFMM3.CGPEFIHCMDD;
					aLBEPPGKFMM3.CGPEFIHCMDD = 0f;
					get_m_buffsInfo().KHFDBEEGPIL(aLBEPPGKFMM3);
				}
				else
				{
					aLBEPPGKFMM3.CGPEFIHCMDD -= kNGOMGNGLLD.JHNOPENIBNJ;
					kNGOMGNGLLD.JHNOPENIBNJ = 0f;
				}
			}
			float num13 = m_shield;
			if (num13 > 0f)
			{
				if (num13 >= kNGOMGNGLLD.JHNOPENIBNJ)
				{
					m_shield = (float)m_shield - kNGOMGNGLLD.JHNOPENIBNJ;
					kNGOMGNGLLD.JHNOPENIBNJ = 0f;
				}
				else
				{
					m_shield = 0f;
					kNGOMGNGLLD.JHNOPENIBNJ -= num13;
				}
			}
			kNGOMGNGLLD.JHNOPENIBNJ = get_m_stateMachine().OnPreDamage(kNGOMGNGLLD.KAIIFOEGFMI, hAHKNKFOCMJ.JBJEMLFEBGK, kNGOMGNGLLD.JHNOPENIBNJ);
			if (kNGOMGNGLLD.JHNOPENIBNJ < 0f)
			{
				return kNGOMGNGLLD.JHNOPENIBNJ;
			}
			kNGOMGNGLLD.BGFHMLEOCAA = m_hp;
			if (kNGOMGNGLLD.BGFHMLEOCAA >= kNGOMGNGLLD.JHNOPENIBNJ)
			{
				kNGOMGNGLLD.BGFHMLEOCAA -= kNGOMGNGLLD.JHNOPENIBNJ;
			}
			else
			{
				kNGOMGNGLLD.JHNOPENIBNJ = kNGOMGNGLLD.BGFHMLEOCAA;
				kNGOMGNGLLD.BGFHMLEOCAA = 0f;
			}
			if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.TryndamereSkill3) && kNGOMGNGLLD.BGFHMLEOCAA < 1f)
			{
				kNGOMGNGLLD.BGFHMLEOCAA = 1f;
			}
			if (kNGOMGNGLLD.BGFHMLEOCAA <= 0f)
			{
				m_lastDamageInfo.IKAIHHIDHFK = true;
			}
			if (get_m_view().IsMine())
			{
				get_m_view().Msg(4, DJJPAPENCLN.All, true, kNGOMGNGLLD.FLAGDGKPKKD);
			}
			return kNGOMGNGLLD.JHNOPENIBNJ;
		}
		catch (Exception exception)
		{
            if (get_m_stateMachine() is PhoneLOLPracticeGuardSM) Debug.LogException(exception);
		}
		return 0f;
	}

	[JDLHECHNNDH]
	public void OnGameItemBuySellRPC(uint ANCDOGMDMKC, ushort CDLJHFICDDI, int DHNOPCIJDBO)
	{
		PKCGCIEPDEM pKCGCIEPDEM = KIMJPIBNFGA.JJBDAOJIDAL().NFOGHIOAPCI().FPICNOOFDOA(CDLJHFICDDI);
		if (pKCGCIEPDEM == null || pKCGCIEPDEM.MGGCDFHFMKK != DHNOPCIJDBO)
		{
			NetworkManager.get_Instance().get_m_gameNetClient().PIFONOBPPMI(ANCDOGMDMKC, "GameItem Hack", CDLJHFICDDI, DHNOPCIJDBO);
		}
	}

	public float get_m_mag_att_base()
	{
		return 0f;
	}

	protected void CPCOODNEOCA(UIHeroDamageHUD ICENKPDOHBK)
	{
		JFCMEMONMBC = ICENKPDOHBK;
	}

	public void CCBKNDHFHFO(Vector3 HEPNHCEIFMO)
	{
		GameManager.get_Instance().ResetPortal();
		Warp(HEPNHCEIFMO);
		SoundManager.GDMJIJCBOLE().PlaySound("hit");
	}

	public virtual void Init()
	{
		KIIBFPDIHOE(1f);
		m_hp = 1f;
		m_shield = 0f;
		m_mp = 0f;
		m_spellElapsedTime = get_m_spellCoolTime();
		DFBGNEHOAHD.Clear();
		for (int i = 0; i < get_m_transform().childCount; i++)
		{
			Transform child = get_m_transform().GetChild(i);
			Animator component = child.GetComponent<Animator>();
			if (m_animator == null && component != null)
			{
				m_animator = component;
			}
			ActorAniEvent component2 = child.GetComponent<ActorAniEvent>();
			if (m_actorAniEvent == null && component2 != null)
			{
				m_actorAniEvent = component2;
			}
		}
		NDNPJAHBMDP(GetComponent<StateMachine>());
		m_navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		DDKIPFANAIC(new HFDJCHHPKKJ(this));
		ALGJCGCNOAC = GetComponent<EffectChanger>();
		if (ALGJCGCNOAC == null)
		{
			ALGJCGCNOAC = base.gameObject.AddComponent<EffectChanger>();
		}
		if (m_selfCreateHeroInfo)
		{
			NEFBHKKAMJF nEFBHKKAMJF = new NEFBHKKAMJF();
			nEFBHKKAMJF.FIGLEPBIEEJ((ushort)m_hero_id);
			SetInfo(nEFBHKKAMJF);
		}
		get_m_stateMachine().Init();
		ActorManager.get_Instance().RegisterActor(this);
	}

	public float get_m_life_steal_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().PPNKFFAHHBB;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().PPNKFFAHHBB;
		}
		if (m_actorType == IJJMDPGJAEM.Hero && m_hero_id == 26 && get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill1))
		{
			num += 0.14f + (float)(GetSkillLevel(1) - 1) * 0.02f;
		}
		return num;
	}

	protected void DDKIPFANAIC(HFDJCHHPKKJ ICENKPDOHBK)
	{
		MICGAGHIECO = ICENKPDOHBK;
	}

	private void CDPPOJHHHGE()
	{
		DoUpdate();
	}

	public float get_m_mag_life_steal()
	{
		float num = get_m_mag_life_steal_base() + get_m_mag_life_steal_add();
		return PhoneLOLModeRules.LifeSteal(num);
	}

	public void CallGameItemBuySellRPC(uint ANCDOGMDMKC, ushort CDLJHFICDDI, int DHNOPCIJDBO)
	{
		if (get_m_view().IsMine())
		{
			get_m_view();
			int num = 1;
			object[] array = new object[3] { ANCDOGMDMKC, CDLJHFICDDI, DHNOPCIJDBO };
		}
	}

	public static float KDJJJHKLOPA(uint PNJKANMGGBA)
	{
		CGAMDJPGLBB();
		byte levelFromExp = GetLevelFromExp(PNJKANMGGBA);
		if (levelFromExp + 1 >= KAAABNKKAJL.Length)
		{
			return 448f;
		}
		uint num = PNJKANMGGBA - KAAABNKKAJL[levelFromExp];
		return (float)num / (float)(KAAABNKKAJL[levelFromExp + 1] - KAAABNKKAJL[levelFromExp]);
	}

	public static uint GetMaxExp()
	{
		CGAMDJPGLBB();
		return KAAABNKKAJL[KAAABNKKAJL.Length - 1];
	}

	public void AddHpRemote(int LLAAHBDLNGP)
	{
		OBFOEDENGBO oBFOEDENGBO = new OBFOEDENGBO();
		oBFOEDENGBO.LLAAHBDLNGP = LLAAHBDLNGP;
		oBFOEDENGBO.KNIAJMGDGAA = this;
		if (get_m_view().IsMine())
		{
			oBFOEDENGBO.LLAAHBDLNGP = AddHp(oBFOEDENGBO.LLAAHBDLNGP);
			get_m_view().Msg(24, DJJPAPENCLN.All, true, oBFOEDENGBO.ELOGHNPHEIP);
		}
	}

	public uint get_GamePoint()
	{
		return OBDPODBBMDA;
	}

	private void Awake()
	{
		LLGADBKNEOF(base.transform);
		m_multiSound = new GOHHBNABIDO();
		m_multiSound.PEFJOMFAOJI(base.gameObject, m_audioClips);
		DFBGNEHOAHD = new LinkedList<NDCNGDGAAIN>();
		LNDMNHECDNO(new KMNJPNBJACF(this));
		NOLEMPCHIGH(GetComponent<EveView>());
		for (int i = 0; i < get_m_transform().childCount; i++)
		{
			GameObject gameObject = get_m_transform().GetChild(i).gameObject;
			if (gameObject.name.Contains("Shadow"))
			{
				PGDLJMDKCAF = gameObject;
			}
		}
		OBAGJGIDICJ();
		Init();
	}

	public void UpdateCoolTime()
	{
		float deltaTime = Time.deltaTime;
		m_attackElapsedTime = (float)m_attackElapsedTime + deltaTime;
		FJDDDIIHBAF += deltaTime;
		for (LinkedListNode<NDCNGDGAAIN> linkedListNode = DFBGNEHOAHD.First; linkedListNode != null; linkedListNode = linkedListNode.Next)
		{
			linkedListNode.Value.INMCDOIEJOC += deltaTime;
		}
		get_m_gameItems().LPBLGFCPADD(deltaTime);
	}

	public Actor CreateMissile(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Actor LPOAEBNAGCP)
	{
		CEOBMJPGCJE cEOBMJPGCJE = new CEOBMJPGCJE();
		cEOBMJPGCJE.LPOAEBNAGCP = LPOAEBNAGCP;
		cEOBMJPGCJE.KNIAJMGDGAA = this;
		Quaternion kMILPEHBBEL = get_m_transform().localRotation;
		if (cEOBMJPGCJE.LPOAEBNAGCP != null)
		{
			Vector3 forward = cEOBMJPGCJE.LPOAEBNAGCP.GetPosition() - GetPosition();
			kMILPEHBBEL = Quaternion.LookRotation(forward);
		}
		string path = string.Format("Particle/{0}/{1}", m_hero_id == 31000 && NCADFOBAFJD == "attack_missile" ? "Turret" : get_m_resourceName(), NCADFOBAFJD);
		// Resolve the actual projectile instead of trusting a hash-only effect cache.
		GameObject prefab = Resources.Load<GameObject>(path);
		if (prefab == null || prefab.GetComponent<Actor>() == null || prefab.GetComponent<HumanSM>() == null)
			throw new InvalidOperationException("Invalid projectile prefab: " + path);
		GameObject gameObject = GameObjectPool.Alloc(prefab, HEPNHCEIFMO, kMILPEHBBEL, cEOBMJPGCJE.OKEAMOGAFAG);
		if (gameObject == null)
		{
			return null;
		}
		return gameObject.GetComponent<Actor>();
	}

	public Vector3 GetCenterPosition()
	{
		Vector3 localPosition = get_m_transform().localPosition;
		if (m_navMeshAgent != null)
		{
			localPosition.y += m_navMeshAgent.height * 0.5f;
		}
		return localPosition;
	}

	public StateMachine get_m_stateMachine()
	{
		return LFCGGKCACPP;
	}

	public int ONOIFGGOLNJ(int LLAAHBDLNGP, bool GEBMJMANKFI = true)
	{
		if (LLAAHBDLNGP == 0)
		{
			return 0;
		}
		int num = 1;
		if (LLAAHBDLNGP > 1)
		{
			float num2 = 1410f;
			if (GEBMJMANKFI && get_m_gameItems().HLHNKLIKFKP(147, 0) == 0)
			{
				num2 += 192f;
			}
			if (get_m_buffsInfo().KNINEDPJMJE(JGOOOBHDBCG.ACPICCBBPHF.MoveSpeedPercent))
			{
				num2 -= 169f;
			}
			LLAAHBDLNGP += (int)((float)LLAAHBDLNGP * num2);
			if (LLAAHBDLNGP <= 0)
			{
				return 0;
			}
			int max_hp = get_m_max_hp();
			float num3 = m_hp;
			float num4 = num3 + (float)LLAAHBDLNGP;
			if (num4 > (float)max_hp)
			{
				num = (int)((float)max_hp - num3);
				m_hp = max_hp;
			}
			else
			{
				num = LLAAHBDLNGP;
				m_hp = num4;
			}
		}
		else
		{
			float num5 = m_hp;
			float num6 = num5 + (float)LLAAHBDLNGP;
			if (num6 <= 357f)
			{
				num = -(int)num5;
				m_hp = 879f;
				if (m_actorType == IJJMDPGJAEM.Hero && GetHumanSM() != null)
				{
					GetHumanSM().m_respawnRemainTime = GameManager.get_Instance().GetRespawnTime(get_Level());
				}
				if (get_m_view() != null && get_m_view().IsMine())
				{
					NMJPCLBJIPO().SetState(StateMachine.OEOIIKMBGAG.Stun);
				}
			}
			else
			{
				num = LLAAHBDLNGP;
				m_hp = num6;
			}
		}
		if (get_m_damageHUD() != null)
		{
			get_m_damageHUD().FKFKDGDCCED();
		}
		return num;
	}

	public float get_m_phy_def_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += (float)get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().FBEBCNEPHJD;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().FBEBCNEPHJD + get_m_runeAbility().KIPMHLBNJEM * (float)(int)get_Level();
		}
		if (m_actorType == IJJMDPGJAEM.Hero && m_hero_id == 26 && !get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.OlafSkill3))
		{
			num += 20f + (float)(GetSkillLevel(3) - 1) * 10f;
		}
		return num;
	}

	public float get_m_critical_percent_base()
	{
		return 0f;
	}

	public void IncreaseMinionCount()
	{
		++IANMCKGEBNA;
	}

	public float get_m_att_speed_add()
	{
		return 0f;
	}

	public Vector2 NIIFBAPEFNN()
	{
		return new Vector2(GetHumanSM().m_direction.x, GetHumanSM().m_direction.z);
	}

	protected void LNDMNHECDNO(KMNJPNBJACF ICENKPDOHBK)
	{
		MLHIMDGOBMB = ICENKPDOHBK;
	}

	public int get_m_mp_regen()
	{
		int mp_regen_base = get_m_mp_regen_base();
		return mp_regen_base + get_m_mp_regen_add() + (int)((float)mp_regen_base * get_m_mp_regen_add_percent());
	}

	public void OnDeserializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		bool ICENKPDOHBK;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
		base.gameObject.SetActive(ICENKPDOHBK);
		OGJFDNEEDCP.CAHACMKBJMI(out ELLDOFEGKMJ);
		OGJFDNEEDCP.CAHACMKBJMI(out FFLHOOPFHMM);
		OGJFDNEEDCP.CAHACMKBJMI(out m_hp);
		OGJFDNEEDCP.CAHACMKBJMI(out m_mp);
		OGJFDNEEDCP.CAHACMKBJMI(out IBIKONGOAKN);
		OGJFDNEEDCP.CAHACMKBJMI(out PKGNAADLLNE);
		OGJFDNEEDCP.CAHACMKBJMI(out HGGCMNDHIPC);
		OGJFDNEEDCP.CAHACMKBJMI(out IANMCKGEBNA);
		for (int i = 0; i < MNDDPGPFJNE.Length; i++)
		{
			OGJFDNEEDCP.CAHACMKBJMI(out MNDDPGPFJNE[i]);
		}
		OGJFDNEEDCP.CAHACMKBJMI(out m_skillPoint);
		OGJFDNEEDCP.CAHACMKBJMI(out m_spellElapsedTime);
		int ICENKPDOHBK2;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
		int ICENKPDOHBK3;
		OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK3);
		NNCNGFFJHLM(ICENKPDOHBK2);
		IJMKMDEBBAD(ICENKPDOHBK3);
		get_m_gameItems().GJPFIPICBAM(OGJFDNEEDCP);
		get_m_buffsInfo().GJPFIPICBAM(OGJFDNEEDCP);
		get_m_stateMachine().OnDeserializeView(OGJFDNEEDCP);
	}

	[JDLHECHNNDH]
	public void OnChangeSkillLevelRpc(byte KLGHHEDJLCA, byte MGLANIAPADB, byte LIGNCEPJBBA)
	{
		MNDDPGPFJNE[KLGHHEDJLCA] = MGLANIAPADB;
		m_skillPoint = LIGNCEPJBBA;
	}

	public bool PossibleDamage(Actor PKDGAIKAMMM)
	{
		if (!IsLive())
		{
			return false;
		}
		if (m_dontDamage)
		{
			return false;
		}
		if (PKDGAIKAMMM != null && m_team == PKDGAIKAMMM.m_team)
		{
			return false;
		}
		return true;
	}

	public float get_m_mp_regen_add_percent()
	{
		float num = 0f;
		if (get_IsMpHero())
		{
			int num2 = get_m_gameItems().OAHFGIGJHHC();
			for (int i = 0; i < num2; i++)
			{
				if (get_m_gameItems().FPICNOOFDOA(i) != null)
				{
					num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().HFGCMLGPJAO;
				}
			}
		}
		return num;
	}

	private void AFHFDHKEEJH(GameObject HCKCCHPJOPI)
	{
		FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
		if (component != null)
		{
			component.m_targetRoot = base.gameObject;
			component.m_direction = GetHumanSM().m_direction;
		}
	}

	public KMNJPNBJACF get_m_gameItems()
	{
		return MLHIMDGOBMB;
	}

	public ObscuredBool get_m_cloaking()
	{
		return PCDAEICLJIH;
	}

	[SpecialName]
	public StateMachine NMJPCLBJIPO()
	{
		return LFCGGKCACPP;
	}

	protected void NNCNGFFJHLM(ObscuredInt ICENKPDOHBK)
	{
		PDFEHFIOBKF = ICENKPDOHBK;
	}

	public Vector3 GetPosition()
	{
		try
		{
			return get_m_transform().localPosition;
		}
		catch
		{
			LLGADBKNEOF(GetComponent<Transform>());
			return get_m_transform().localPosition;
		}
	}

	public float get_m_mag_att()
	{
		float num = get_m_mag_att_base() + get_m_mag_att_add();
		if (get_m_gameItems().MBCEBKJDEAK(3102, 1) == 0)
		{
			num *= 1.4f;
		}
		if (m_hero_id == 19)
		{
			num += (float)get_m_max_hp_add() / 40f;
		}
		return num;
	}

	[SpecialName]
	public int GEKLNJKJNMP()
	{
		int mp_regen_base = get_m_mp_regen_base();
		return mp_regen_base + get_m_mp_regen_add() + (int)((float)mp_regen_base * get_m_mp_regen_add_percent());
	}

	public void SetCloaking(bool ICENKPDOHBK)
	{
		LGHAHMLBHJJ(ICENKPDOHBK);
		bool flag = true;
		if (ICENKPDOHBK)
		{
			if (IsMyTeam())
			{
				if (ALGJCGCNOAC != null)
				{
					ALGJCGCNOAC.SetAlpha(0.5f);
				}
			}
			else
			{
				if (ALGJCGCNOAC != null)
				{
					ALGJCGCNOAC.SetAlpha(0f);
				}
				flag = false;
			}
		}
		else if (ALGJCGCNOAC != null)
		{
			ALGJCGCNOAC.SetAlpha(1f);
		}
		if (flag)
		{
			if (get_m_damageHUD() != null)
			{
				get_m_damageHUD().gameObject.SetActive(true);
			}
			if (PGDLJMDKCAF != null)
			{
				PGDLJMDKCAF.SetActive(true);
			}
		}
		else
		{
			if (get_m_damageHUD() != null)
			{
				get_m_damageHUD().gameObject.SetActive(false);
			}
			if (PGDLJMDKCAF != null)
			{
				PGDLJMDKCAF.SetActive(false);
			}
		}
	}

	public static float GetExpPercent(uint PNJKANMGGBA)
	{
		CGAMDJPGLBB();
		byte levelFromExp = GetLevelFromExp(PNJKANMGGBA);
		if (levelFromExp + 1 >= KAAABNKKAJL.Length)
		{
			return 1f;
		}
		uint num = PNJKANMGGBA - KAAABNKKAJL[levelFromExp];
		return (float)num / (float)(KAAABNKKAJL[levelFromExp + 1] - KAAABNKKAJL[levelFromExp]);
	}

	public void IncreaseGamePoint(uint MLGKODPIOHA)
	{
		OBDPODBBMDA = (uint)OBDPODBBMDA + MLGKODPIOHA;
	}

	[SpecialName]
	protected void BICOHOJBEIO(NEFBHKKAMJF ICENKPDOHBK)
	{
		PLFLBNMECBJ = ICENKPDOHBK;
	}

	private void LLGADBKNEOF(Transform ICENKPDOHBK)
	{
		OGONHDMMABA = ICENKPDOHBK;
	}

	public GameObject CreateParticle(string NCADFOBAFJD, Vector3 HEPNHCEIFMO, Quaternion KMILPEHBBEL)
	{
		GameObject gameObject = GameObjectPool.Alloc(NCADFOBAFJD, HEPNHCEIFMO, KMILPEHBBEL, (GameObject HCKCCHPJOPI) =>
		{
			FxMakerParticleAttach component = HCKCCHPJOPI.GetComponent<FxMakerParticleAttach>();
			if (component != null)
			{
				component.m_targetRoot = base.gameObject;
				component.m_direction = GetHumanSM().m_direction;
			}
		});
		if (gameObject != null)
		{
			NsEffectManager.RunReplayEffect(gameObject, true);
		}
		return gameObject;
	}

	public virtual void DoUpdate()
	{
		UpdateCoolTime();
		get_m_buffsInfo().DPILNPAPPKI(Time.deltaTime);
		ALGJCGCNOAC.OnUpdate(get_m_elapsedTime());
		if (m_actorType == IJJMDPGJAEM.Hero && IsLive())
		{
			LIACCFKEKGD += Time.deltaTime;
			if (LIACCFKEKGD >= 5f)
			{
				LIACCFKEKGD -= 5f;
				int hp_regen = get_m_hp_regen();
				if ((float)m_hp < (float)get_m_max_hp() && hp_regen != 0)
				{
					AddHpRemote(hp_regen);
				}
				if (!m_furyHero)
				{
					int mp_regen = get_m_mp_regen();
					if ((float)m_mp < (float)get_m_max_mp() && mp_regen != 0)
					{
						AddMpRemote(mp_regen);
					}
				}
			}
		}
		m_lifeTime -= get_m_elapsedTime();
		if (m_lifeTime <= 0f && get_m_stateMachine().get_m_state() != StateMachine.OEOIIKMBGAG.Death)
		{
			get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.Death);
		}
	}

	public Vector2 GetPosition2D()
	{
		return new Vector2(get_m_transform().localPosition.x, get_m_transform().localPosition.z);
	}

	public float get_m_cooldown_percent_add()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().BDKLLIMAGPP;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().BDKLLIMAGPP + get_m_runeAbility().FFOIEDLDCBI * (float)(int)get_Level();
		}
		if (get_m_buffsInfo().CKMKKIFJOPF(JGOOOBHDBCG.ACPICCBBPHF.Blue))
		{
			num += 0.1f;
		}
		return num;
	}

	public HFDJCHHPKKJ get_m_buffsInfo()
	{
		return MICGAGHIECO;
	}

	public uint get_TotalAttackDamage()
	{
		return MCEIJGCLIIO;
	}

	public ushort get_DeathCount()
	{
		return PKGNAADLLNE;
	}

	public Vector3 GetHeadPosition()
	{
		Vector3 localPosition = get_m_transform().localPosition;
		if (m_navMeshAgent != null)
		{
			localPosition.y += m_navMeshAgent.height;
		}
		return localPosition;
	}

	public float CPGNLGCGPID()
	{
		return (float)m_attackElapsedTime / get_m_attackCoolTime();
	}

	public void InitForRespawn(Vector3 HEPNHCEIFMO)
	{
		get_m_transform().localPosition = HEPNHCEIFMO;
		m_hp = get_m_max_hp();
		m_mp = get_m_max_mp();
		if (get_m_damageHUD() != null)
		{
			get_m_damageHUD().gameObject.SetActive(true);
		}
		if (m_navMeshAgent != null)
		{
			m_navMeshAgent.enabled = true;
		}
		get_m_stateMachine().ChangeState(StateMachine.OEOIIKMBGAG.Idle, HEPNHCEIFMO);
		get_m_stateMachine().SetStateForce(StateMachine.OEOIIKMBGAG.Idle);
		SetAnimation("idle");
		base.gameObject.SetActive(true);
	}

	public bool DGBABDEKEAE(uint PNJKANMGGBA)
	{
		FFLHOOPFHMM = (uint)FFLHOOPFHMM + PNJKANMGGBA;
		if ((uint)FFLHOOPFHMM > GetMaxExp())
		{
			FFLHOOPFHMM = GetMaxExp();
		}
		byte b = ELLDOFEGKMJ;
		ELLDOFEGKMJ = GetLevelFromExp(FFLHOOPFHMM);
		byte b2 = ELLDOFEGKMJ;
		if (b2 != b)
		{
			m_skillPoint = (byte)((byte)m_skillPoint + b2 - b);
			UpdateAbility();
			if (get_m_view() != null && get_m_view().IsMine())
			{
				EveView view = get_m_view();
				object[] array = new object[8];
				array[0] = b2;
				array[0] = get_Experience();
				view.RPC("Zed", DJJPAPENCLN.Others, array);
			}
			return true;
		}
		return false;
	}

	public void InitForReuse()
	{
		if (m_actorType != IJJMDPGJAEM.Unknown)
		{
			for (int i = 0; i < MNDDPGPFJNE.Length; i++)
			{
				MNDDPGPFJNE[i] = (byte)0;
			}
			ELLDOFEGKMJ = (byte)1;
			FFLHOOPFHMM = 0u;
			OBDPODBBMDA = 0u;
			NNCNGFFJHLM(500);
			IJMKMDEBBAD(0);
			m_skillPoint = (byte)1;
			IBIKONGOAKN = (ushort)0;
			PKGNAADLLNE = (ushort)0;
			HGGCMNDHIPC = (ushort)0;
			IANMCKGEBNA = (ushort)0;
			MCEIJGCLIIO = 0u;
			LIACCFKEKGD = 0f;
			FJDDDIIHBAF = 0f;
			HGHPFDHHPBF = 0;
		}
		if (get_m_damageHUD() != null)
		{
			get_m_damageHUD().gameObject.SetActive(true);
		}
		if (m_navMeshAgent != null)
		{
			m_navMeshAgent.enabled = true;
		}
		get_m_stateMachine().SetStateForce(StateMachine.OEOIIKMBGAG.Idle);
		SetAnimation("idle");
	}

	public void CJNCFNACFDP(string NCADFOBAFJD)
	{
		if (m_animator == null)
		{
			return;
		}
		if (NCADFOBAFJD == "s R")
		{
			m_animator.speed = m_moveSpeed * get_m_frequency();
		}
		else
		{
			m_animator.speed = 1168f;
		}
		if (NCADFOBAFJD.Contains("User Friends:") || NCADFOBAFJD.Contains("skill1"))
		{
			float att_speed = get_m_att_speed();
			if (att_speed > 1856f)
			{
				m_animator.speed = att_speed;
			}
			else
			{
				m_animator.speed = 737f;
			}
			m_animator.Play(NCADFOBAFJD, -1, 1649f);
		}
		else if (NCADFOBAFJD.Contains("skill1_loop"))
		{
			m_animator.Play(NCADFOBAFJD, -1, 1737f);
		}
		else
		{
			m_animator.Play(NCADFOBAFJD, -1, 380f);
		}
		m_animator.Update(1563f);
	}

	public int get_m_max_mp_add()
	{
		int num = 0;
		if (get_IsMpHero())
		{
			int num2 = get_m_gameItems().OAHFGIGJHHC();
			for (int i = 0; i < num2; i++)
			{
				if (get_m_gameItems().FPICNOOFDOA(i) != null)
				{
					num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().BELPBCDOPBA;
				}
			}
			if (get_m_runeAbility() != null)
			{
				num += (int)(get_m_runeAbility().BELPBCDOPBA + get_m_runeAbility().BJHADLMCNJO * (float)(int)get_Level());
			}
		}
		return num;
	}

	public int get_m_max_hp()
	{
        if (get_m_stateMachine() is PhoneLOLPracticeGuardSM) return PhoneLOLPracticeGuardSM.MaxHealth;
		int num = get_m_max_hp_base() + get_m_max_hp_add();
		if (m_hero_id == 19)
		{
			num += (int)(get_m_mag_att_add() * 1.4f);
		}
		return V093RuneBattleFix.ApplyMaxHp(num, this);
	}

	public bool IsPossibleSkillLevelUp(byte KLGHHEDJLCA)
	{
		if ((byte)m_skillPoint == 0)
		{
			return false;
		}
		if (KLGHHEDJLCA >= MNDDPGPFJNE.Length)
		{
			return false;
		}
		byte level = get_Level();
		byte skillLevel = GetSkillLevel(KLGHHEDJLCA);
		if (skillLevel >= 5)
		{
			return false;
		}
		if (KLGHHEDJLCA == 3)
		{
			if (skillLevel == 0 && level < 6)
			{
				return false;
			}
			if (skillLevel == 1 && level < 11)
			{
				return false;
			}
			if (skillLevel == 2 && level < 16)
			{
				return false;
			}
			if (skillLevel >= 3)
			{
				return false;
			}
		}
		else if ((level + 1) / 2 <= skillLevel)
		{
			return false;
		}
		return true;
	}

	[SpecialName]
	public float GLFGJINHMLB()
	{
		float num = 563f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 1; i < num2; i++)
		{
			if (get_m_gameItems().DDIBAIMBOGJ(i) != null)
			{
				num += (float)get_m_gameItems().DDIBAIMBOGJ(i).AGHCOCAJMCI().NLMHKBGDKLA;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().NLMHKBGDKLA + get_m_runeAbility().BNKPEMNKEMO * (float)(int)get_Level();
		}
		if (m_actorType == (IJJMDPGJAEM)5 && m_hero_id == -28 && !get_m_buffsInfo().KNINEDPJMJE((JGOOOBHDBCG.ACPICCBBPHF)65431))
		{
			num += 1215f + (float)(GetSkillLevel(0) - 1) * 198f;
		}
		return num;
	}

	public float get_m_phy_def_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		float num = gPNKIAHCKMG.IIJMLJCIJFD().FBEBCNEPHJD + gPNKIAHCKMG.IIJMLJCIJFD().PDAOIGGBLPH * (float)(get_Level() - 1);
		ALBEPPGKFMM aLBEPPGKFMM = get_m_buffsInfo().EMILLELIOHH(JGOOOBHDBCG.ACPICCBBPHF.JaxSkill3);
		if (aLBEPPGKFMM != null)
		{
			num += (float)(20 + (GetSkillLevel(3) - 1) * 20);
			num += get_m_phy_att_add() * 0.5f;
		}
		return num;
	}

	public void GDGCEEJHFFD(Vector3 HEPNHCEIFMO)
	{
		get_m_stateMachine().SetState(StateMachine.OEOIIKMBGAG.None);
	}

	public ObscuredInt get_m_autoMoney()
	{
		return FKELMHPFDNN;
	}

	public void CallRecoveryRpc(int FDEJBCNGOEG)
	{
		get_m_view().Msg(5, FDEJBCNGOEG, true, true, (KCIGFAHFHCH OGJFDNEEDCP) =>
		{
			OnSerializeView(OGJFDNEEDCP);
		});
	}

	public void OnSerializeView(KCIGFAHFHCH OGJFDNEEDCP)
	{
		OGJFDNEEDCP.GBMJNFOEACC(base.gameObject.activeInHierarchy);
		OGJFDNEEDCP.GBMJNFOEACC(ELLDOFEGKMJ);
		OGJFDNEEDCP.GBMJNFOEACC(FFLHOOPFHMM);
		OGJFDNEEDCP.GBMJNFOEACC(m_hp);
		OGJFDNEEDCP.GBMJNFOEACC(m_mp);
		OGJFDNEEDCP.GBMJNFOEACC(IBIKONGOAKN);
		OGJFDNEEDCP.GBMJNFOEACC(PKGNAADLLNE);
		OGJFDNEEDCP.GBMJNFOEACC(HGGCMNDHIPC);
		OGJFDNEEDCP.GBMJNFOEACC(IANMCKGEBNA);
		for (int i = 0; i < MNDDPGPFJNE.Length; i++)
		{
			OGJFDNEEDCP.GBMJNFOEACC(MNDDPGPFJNE[i]);
		}
		OGJFDNEEDCP.GBMJNFOEACC(m_skillPoint);
		OGJFDNEEDCP.GBMJNFOEACC(m_spellElapsedTime);
		OGJFDNEEDCP.GBMJNFOEACC(get_m_money());
		OGJFDNEEDCP.GBMJNFOEACC(get_m_autoMoney());
		get_m_gameItems().DFMCIOHFKOF(OGJFDNEEDCP);
		get_m_buffsInfo().DFMCIOHFKOF(OGJFDNEEDCP);
		get_m_stateMachine().OnSerializeView(OGJFDNEEDCP);
	}

	private void OBAGJGIDICJ()
	{
		MNDDPGPFJNE = new ObscuredByte[4];
		for (int i = 0; i < MNDDPGPFJNE.Length; i++)
		{
			MNDDPGPFJNE[i] = (byte)0;
		}
		ELLDOFEGKMJ = (byte)1;
		FFLHOOPFHMM = 0u;
		IBIKONGOAKN = (ushort)0;
		PKGNAADLLNE = (ushort)0;
		HGGCMNDHIPC = (ushort)0;
		IANMCKGEBNA = (ushort)0;
		OBDPODBBMDA = 0u;
		MCEIJGCLIIO = 0u;
		m_skillPoint = (byte)1;
		NNCNGFFJHLM(500);
	}

	public float get_m_att_speed_add_percent()
	{
		float num = 0f;
		int num2 = get_m_gameItems().OAHFGIGJHHC();
		for (int i = 0; i < num2; i++)
		{
			if (get_m_gameItems().FPICNOOFDOA(i) != null)
			{
				num += get_m_gameItems().FPICNOOFDOA(i).AGHCOCAJMCI().NMFDEKCMJAH;
			}
		}
		if (get_m_runeAbility() != null)
		{
			num += get_m_runeAbility().NMFDEKCMJAH;
		}
		return num + GetHumanSM().GetPlusAttackSpeed();
	}

	public float get_m_att_speed_base()
	{
		HNEBHCMAOAE gPNKIAHCKMG = GetHeroInfo().GPNKIAHCKMG;
		return gPNKIAHCKMG.IIJMLJCIJFD().LNKFLFOGCCD * (1f + gPNKIAHCKMG.IIJMLJCIJFD().FHJCBAOBGPG * (float)(get_Level() - 1) * 0.01f);
	}

	protected void LGHAHMLBHJJ(ObscuredBool ICENKPDOHBK)
	{
		PCDAEICLJIH = ICENKPDOHBK;
	}

	public void CreateDamageParticle(string NCADFOBAFJD, Actor PKDGAIKAMMM, bool BLLOFLFALFM = false)
	{
		DLLLLJGOEHP dLLLLJGOEHP = new DLLLLJGOEHP();
		dLLLLJGOEHP.BLLOFLFALFM = BLLOFLFALFM;
		dLLLLJGOEHP.PKDGAIKAMMM = PKDGAIKAMMM;
		dLLLLJGOEHP.KNIAJMGDGAA = this;
		try
		{
			GameObject gameObject = GameObjectPool.Alloc(NCADFOBAFJD, dLLLLJGOEHP.LOOIIHGFBMM);
			if (gameObject != null)
			{
				NsEffectManager.RunReplayEffect(gameObject, true);
			}
		}
		catch (Exception exception)
		{
			Debug.LogException(exception, base.gameObject);
		}
	}

	public void CallChangeGameItemRPC()
	{
		DMNCNEAHLPN dMNCNEAHLPN = new DMNCNEAHLPN();
		dMNCNEAHLPN.KNIAJMGDGAA = this;
		if (!get_m_view().IsMine())
		{
			return;
		}
		dMNCNEAHLPN.JFILMHHIFGI = get_m_money();
		if ((float)m_hp > (float)get_m_max_hp())
		{
			m_hp = get_m_max_hp();
		}
		if ((float)m_mp > (float)get_m_max_mp())
		{
			m_mp = get_m_max_mp();
		}
		get_m_view();
		int num3 = 30;
		int num4 = 1;
		int num5 = 1;
		_ = new Action<KCIGFAHFHCH>(dMNCNEAHLPN.KGAIOHCFKOH);
		int num = get_m_gameItems().DGLMPNDAAEL();
		int num2 = (int)(float)GameManager.get_Instance().get_m_elapsedTime();
		if ((num2 < 180 || (dMNCNEAHLPN.JFILMHHIFGI + num < num2 * 30 && dMNCNEAHLPN.JFILMHHIFGI + num < 50000)) && (num2 >= 180 || dMNCNEAHLPN.JFILMHHIFGI + num < 5400))
		{
			return;
		}
		OBILGKHFCHO oBILGKHFCHO = new OBILGKHFCHO();
		oBILGKHFCHO.PNIMJFCJLHM = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.DCHDPGPBJGC;
		oBILGKHFCHO.EEFMONDACJN = num2;
		oBILGKHFCHO.DDILAEMMCAJ = ELLDOFEGKMJ;
		oBILGKHFCHO.JFILMHHIFGI = dMNCNEAHLPN.JFILMHHIFGI;
		oBILGKHFCHO.NMGLFEEAMOA = num;
		for (int i = 0; i < get_m_gameItems().BHFIOMJAFBC().Count; i++)
		{
			DDHBIGNBFID dDHBIGNBFID = get_m_gameItems().BHFIOMJAFBC()[i];
			if (dDHBIGNBFID != null)
			{
				oBILGKHFCHO.EOECENOCDOG.Add(dDHBIGNBFID.AGHCOCAJMCI().EHFEEIJKJHD());
				oBILGKHFCHO.LLANMMOBEIG.Add(dDHBIGNBFID.HENGMGCOBCP());
			}
			else
			{
				oBILGKHFCHO.EOECENOCDOG.Add(0);
				oBILGKHFCHO.LLANMMOBEIG.Add(0);
			}
		}
		NetworkManager.get_Instance().get_m_gameNetClient();
	}

	public Vector2 GetDirection2D()
	{
		return new Vector2(GetHumanSM().m_direction.x, GetHumanSM().m_direction.z);
	}

	[SpecialName]
	public float LCNPIBGONIL()
	{
		return 762f;
	}
}
