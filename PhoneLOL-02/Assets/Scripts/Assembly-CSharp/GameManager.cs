using System;
using BattleServer;
using CodeStage.AntiCheat.ObscuredTypes;
using EveEngine;
using GameServer;
using UnityEngine;

public abstract class GameManager : MonoBehaviour, OEKJBKLGNCE
{
	public enum HAGFLGHFHPB
	{
		MultiGame = 0,
		MtmGame = 1
	}

	public enum OEOIIKMBGAG
	{
		Ready = 0,
		Battle = 1,
		Win = 2,
		Lose = 3,
		Draw = 4
	}

	public enum NFDDJKNBBGL
	{
		OutGame = 0,
		InGame = 1,
		Pause = 2
	}

	private static GameManager MLDPFDAHKHA;

	public UILabel m_timeOverLabel;

	public GameObject m_mainDescription;

	public UILabel m_mainDescriptionLabel;

	public UILabel m_moneyDescriptionLabel;

	public UIGameMiniMap m_miniMap;

	public bool m_testMode;

	public int m_testHeroID = 2;

	public int m_testHeroCostumeID;

	public int m_testHeroLevel = 1;

	public int m_testHeroAddGold;

	[NonSerialized]
	public float m_actionElapsedTime;

	private int BPPCDKBECOA;

	private int AAGLKFIGCDE;

	private float JJKPMHBKGAG;

	private DateTime LFKNBPBKDOP;

	private HAGFLGHFHPB JCHKFLKFLBM;

	private OEOIIKMBGAG BBEEPJNEHBI;

	private ObscuredFloat KHMAILBFBMN;

	private ObscuredFloat NCACMNPDKFH;

	private ObscuredInt[] ABALLNONFDK;

	private ObscuredBool KOAHDMLBDPK;

	private EveView PFHHNPPCOED;

	private Terrain CNNHKKBDBLA;

	public static GameManager CJFCFLEHJKI
	{
		get
		{
			return get_Instance();
		}
	}

	public DateTime ANNCBPBPJFJ
	{
		get
		{
			return get_m_gameStartTime();
		}
		protected set
		{
			MJBAEAAHLPK(value);
		}
	}

	public HAGFLGHFHPB KOFDOLNGHEA
	{
		get
		{
			return get_m_gameType();
		}
		protected set
		{
			ICBOJLCLNID(value);
		}
	}

	public OEOIIKMBGAG GFKDNKFPPAM
	{
		get
		{
			return get_m_state();
		}
		protected set
		{
			FJPMFBBCBLB(value);
		}
	}

	public ObscuredFloat INMCDOIEJOC
	{
		get
		{
			return get_m_elapsedTime();
		}
		protected set
		{
			NILBNOIINED(value);
		}
	}

	public ObscuredFloat KKEMMLLBJHB
	{
		get
		{
			return get_m_portalElapsedTime();
		}
		protected set
		{
			BFFOMMHGNIC(value);
		}
	}

	public ObscuredInt[] FNMKAMLOMEE
	{
		get
		{
			return get_m_teamKillCount();
		}
		protected set
		{
			GFBPHPKBMJD(value);
		}
	}

	public ObscuredBool GHFCJGEADAL
	{
		get
		{
			return get_m_useFirstBlood();
		}
		protected set
		{
			HOIKAKFPODD(value);
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

	public int JPAPMBJFOLJ
	{
		get
		{
			return get_Fps();
		}
	}

	public Terrain FLAPJIHPKFE
	{
		get
		{
			return get_m_terrain();
		}
		private set
		{
			FPAHPEBACGO(value);
		}
	}

	public static GameManager get_Instance()
	{
		if (MLDPFDAHKHA == null)
		{
			MLDPFDAHKHA = UnityEngine.Object.FindObjectOfType(typeof(GameManager)) as GameManager;
		}
		return MLDPFDAHKHA;
	}

	public DateTime get_m_gameStartTime()
	{
		return LFKNBPBKDOP;
	}

	protected void MJBAEAAHLPK(DateTime ICENKPDOHBK)
	{
		LFKNBPBKDOP = ICENKPDOHBK;
	}

	public HAGFLGHFHPB get_m_gameType()
	{
		return JCHKFLKFLBM;
	}

	protected void ICBOJLCLNID(HAGFLGHFHPB ICENKPDOHBK)
	{
		JCHKFLKFLBM = ICENKPDOHBK;
	}

	public OEOIIKMBGAG get_m_state()
	{
		return BBEEPJNEHBI;
	}

	protected void FJPMFBBCBLB(OEOIIKMBGAG ICENKPDOHBK)
	{
		BBEEPJNEHBI = ICENKPDOHBK;
	}

	public ObscuredFloat get_m_elapsedTime()
	{
		return KHMAILBFBMN;
	}

	protected void NILBNOIINED(ObscuredFloat ICENKPDOHBK)
	{
		KHMAILBFBMN = ICENKPDOHBK;
	}

	public ObscuredFloat get_m_portalElapsedTime()
	{
		return NCACMNPDKFH;
	}

	protected void BFFOMMHGNIC(ObscuredFloat ICENKPDOHBK)
	{
		NCACMNPDKFH = ICENKPDOHBK;
	}

	public ObscuredInt[] get_m_teamKillCount()
	{
		return ABALLNONFDK;
	}

	protected void GFBPHPKBMJD(ObscuredInt[] ICENKPDOHBK)
	{
		ABALLNONFDK = ICENKPDOHBK;
	}

	public ObscuredBool get_m_useFirstBlood()
	{
		return KOAHDMLBDPK;
	}

	protected void HOIKAKFPODD(ObscuredBool ICENKPDOHBK)
	{
		KOAHDMLBDPK = ICENKPDOHBK;
	}

	public EveView get_m_view()
	{
		return PFHHNPPCOED;
	}

	protected void NOLEMPCHIGH(EveView ICENKPDOHBK)
	{
		PFHHNPPCOED = ICENKPDOHBK;
	}

	public int get_Fps()
	{
		return BPPCDKBECOA;
	}

	public Terrain get_m_terrain()
	{
		return CNNHKKBDBLA;
	}

	private void FPAHPEBACGO(Terrain ICENKPDOHBK)
	{
		CNNHKKBDBLA = ICENKPDOHBK;
	}

	public virtual void Awake()
	{
		NOLEMPCHIGH(GetComponent<EveView>());
		FPAHPEBACGO(UnityEngine.Object.FindObjectOfType<Terrain>());
		FJPMFBBCBLB(OEOIIKMBGAG.Ready);
		Screen.sleepTimeout = -1;
		SceneManager.get_Instance().m_gamePlayCount++;
		GameServer.KIMJPIBNFGA.JJBDAOJIDAL().PEFJOMFAOJI();
		NILBNOIINED(0f);
		BFFOMMHGNIC(0f);
		GFBPHPKBMJD(new ObscuredInt[2]);
		get_m_teamKillCount()[0] = 0;
		get_m_teamKillCount()[1] = 0;
		HOIKAKFPODD(false);
		BPPCDKBECOA = 30;
		AAGLKFIGCDE = 0;
		JJKPMHBKGAG = 0f;
	}

	public virtual void Start()
	{
		MJBAEAAHLPK(DateTime.Now);
		InitStage();
	}

	public virtual void Update()
	{
		if (get_m_state() == OEOIIKMBGAG.Battle)
		{
			BFFOMMHGNIC((float)get_m_portalElapsedTime() + Time.deltaTime);
		}
		JJKPMHBKGAG += Time.deltaTime;
		if (JJKPMHBKGAG >= 1f)
		{
			JJKPMHBKGAG = 0f;
			BPPCDKBECOA = AAGLKFIGCDE;
			AAGLKFIGCDE = 0;
		}
		AAGLKFIGCDE++;
	}

	protected virtual void JNLACFFDDHO(int KNDELHHFLLG)
	{
	}

	public void Blank()
	{
	}

	public virtual void InitStage()
	{
		FJPMFBBCBLB(OEOIIKMBGAG.Battle);
	}

	public virtual void SetStageOver()
	{
	}

	public virtual int GetGoldAtKill(Actor JMEDKCPCJNA)
	{
		Actor.IJJMDPGJAEM actorType = JMEDKCPCJNA.m_actorType;
		ushort num = (ushort)JMEDKCPCJNA.m_hero_id;
		int killCount = JMEDKCPCJNA.get_KillCount();
		int deathCount = JMEDKCPCJNA.get_DeathCount();
		float num2 = get_m_elapsedTime();
		int num3 = 0;
		switch (actorType)
		{
		case Actor.IJJMDPGJAEM.Hero:
		{
			int num4 = killCount - deathCount;
			int num5 = 188 + num4 * 25;
			if (num5 < 50)
			{
				num5 = 50;
			}
			if (num5 > 500)
			{
				num5 = 500;
			}
			num3 = num5;
			break;
		}
		case Actor.IJJMDPGJAEM.Minion:
			switch (num)
			{
			case 10000:
			case 10010:
				num3 = (int)(19.8f + num2 / 90f * 0.2f);
				break;
			case 10001:
			case 10011:
				num3 = (int)(16.8f + num2 / 90f * 0.2f);
				break;
			case 10002:
			case 10012:
				num3 = (int)(40f + num2 / 90f * 0.5f);
				break;
			case 10003:
			case 10013:
				num3 = (int)(40f + num2 / 270f * 1f);
				break;
			case 10100:
				num3 = 200;
				break;
			}
			break;
		case Actor.IJJMDPGJAEM.Monster:
			switch (num)
			{
			case 20000:
				num3 = 36;
				break;
			case 20001:
				num3 = 36;
				break;
			case 20002:
				num3 = 100;
				break;
			case 20003:
				num3 = 300;
				break;
			case 20004:
				num3 = 16;
				break;
			case 20005:
				num3 = 53;
				break;
			case 20006:
				num3 = 14;
				break;
			case 20007:
				num3 = 60;
				break;
			case 20008:
				num3 = 50;
				break;
			}
			break;
		case Actor.IJJMDPGJAEM.Turret:
			num3 = 150;
			break;
		}
		return (int)((float)num3 * 1.6f);
	}

	public virtual float GetExpAtKill(Actor JMEDKCPCJNA)
	{
		Actor.IJJMDPGJAEM actorType = JMEDKCPCJNA.m_actorType;
		ushort num = (ushort)JMEDKCPCJNA.m_hero_id;
		float num2 = 0f;
		switch (actorType)
		{
		case Actor.IJJMDPGJAEM.Hero:
			num2 = 30f;
			break;
		case Actor.IJJMDPGJAEM.Minion:
			switch (num)
			{
			case 10000:
			case 10010:
				num2 = 59f;
				break;
			case 10001:
			case 10011:
				num2 = 29f;
				break;
			case 10002:
			case 10012:
				num2 = 92f;
				break;
			case 10003:
			case 10013:
				num2 = 97f;
				break;
			case 10100:
				num2 = 0f;
				break;
			}
			break;
		case Actor.IJJMDPGJAEM.Monster:
			switch (num)
			{
			case 20000:
				num2 = 120f;
				break;
			case 20001:
				num2 = 120f;
				break;
			case 20002:
				num2 = 180f;
				break;
			case 20003:
				num2 = 180f;
				break;
			case 20004:
				num2 = 64f;
				break;
			case 20005:
				num2 = 64f;
				break;
			case 20006:
				num2 = 64f;
				break;
			case 20007:
				num2 = 64f;
				break;
			case 20008:
				num2 = 64f;
				break;
			}
			break;
		}
		return num2 * 3f;
	}

	public virtual void KillMonster(ushort FMADHAHOIDJ, Vector3 HEPNHCEIFMO)
	{
	}

	public virtual void OnKillHero(Actor KAIIFOEGFMI, Actor JMEDKCPCJNA)
	{
		if (JMEDKCPCJNA.m_actorType == Actor.IJJMDPGJAEM.Hero)
		{
			if (JMEDKCPCJNA.m_team == 0)
			{
				++get_m_teamKillCount()[1];
			}
			else if (JMEDKCPCJNA.m_team == 1)
			{
				++get_m_teamKillCount()[0];
			}
		}
	}

	public bool SetFirstBlood()
	{
		if (!get_m_useFirstBlood())
		{
			HOIKAKFPODD(true);
			return true;
		}
		return false;
	}

	public virtual void OnApplicationPause(bool NCNJEPMGAGH)
	{
	}

	public bool PossiblePortal()
	{
		if ((float)get_m_portalElapsedTime() >= 30f)
		{
			return true;
		}
		return false;
	}

	public void ResetPortal()
	{
		BFFOMMHGNIC(0f);
	}

	public bool CheckGameItemHack()
	{
		return false;
	}

	public void CallPingRPC(byte FBAGNJILEGD, Vector3 HEPNHCEIFMO)
	{
		get_m_view().RPC("PingRPC", DJJPAPENCLN.All, NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD(), FBAGNJILEGD, HEPNHCEIFMO);
	}

	[JDLHECHNNDH]
	public void PingRPC(byte BEPBPAPIEHE, byte FBAGNJILEGD, Vector3 HEPNHCEIFMO)
	{
		if (BEPBPAPIEHE % 2 == NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 2)
		{
			m_miniMap.CreatePing(FBAGNJILEGD, HEPNHCEIFMO);
		}
	}

	public abstract Vector3 GetTeamPos(int OIOCBJMKGCD);

	public abstract Vector3[] GetMinionTeamWayPoints(int OIOCBJMKGCD);

	public abstract void SetResult(byte HIJLMPFMHBH, PJEMPFEIOAK HMOAHNANKNE);

	public abstract float GetRespawnTime(byte DDILAEMMCAJ);

	public abstract float GetMonsterRespawnTime(ushort FMADHAHOIDJ);

	public virtual void OnMsgView(byte IKKFLANGAEA, KCIGFAHFHCH OGJFDNEEDCP)
	{
		ICOGNNKEKHJ iCOGNNKEKHJ = (ICOGNNKEKHJ)IKKFLANGAEA;
		if (iCOGNNKEKHJ == ICOGNNKEKHJ.RejoinAsyncComplete)
		{
			byte ICENKPDOHBK;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK);
			int ICENKPDOHBK2;
			OGJFDNEEDCP.CAHACMKBJMI(out ICENKPDOHBK2);
			NOBFFGBGCNA nOBFFGBGCNA = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
				.FBNKGOOJPBB(ICENKPDOHBK);
			nOBFFGBGCNA.ENLKLHEMPHA().get_m_view().set_ownerSessionKey(ICENKPDOHBK2);
			nOBFFGBGCNA.ENLKLHEMPHA().get_m_view().set_isSceneObject(false);
		}
	}
}
