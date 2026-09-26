using System;
using UnityEngine;

public class NcParticleSpiral : NcEffectBehaviour
{
	public struct HPFMFONDPMF
	{
		public int FKKDKPLPGMH;

		public int NNALDAOPEJH;

		public float GDKFMCHGAPP;

		public float OKINPIAKFAH;

		public float COGDOOBPCMK;

		public float MKJLOIHBFEL;

		public float GJLDELNHLCN;

		public float BAGLDHDFDPB;

		public float POIJPKODPCK;
	}

	protected const int KEFGKDLJAEG = 1;

	protected const int KHHGFKKHGLF = 10;

	protected const int FHHGGNKHHDL = 20;

	protected const int COACLBJHMBF = 60;

	protected const float GBBOHMFMAKH = -0.3f;

	protected const float OHMILPIDIPN = 0.3f;

	protected const float NDDEMAGENJB = -1.5f;

	protected const float GCFNCBMBBDI = 1.5f;

	protected const float IPHMOJEMNOP = 0f;

	protected const float DBHIAPLPLJI = 0.5f;

	protected const float AHDPDEMIPPB = -3f;

	protected const float BEDCJDPLGJE = 3f;

	protected const float IOMCONKIPNE = -180f;

	protected const float NOEPFHLHPGK = 180f;

	protected const float EKDKJFFKMOJ = -1f;

	protected const float HMFDNNANBMM = 1f;

	protected const float DBABOCFOMOA = -2f;

	protected const float DGPJADBOPCG = 2f;

	public float m_fDelayTime;

	protected float HBDKLBHFLJK;

	public GameObject m_ParticlePrefab;

	public int m_nNumberOfArms = 2;

	public int m_nParticlesPerArm = 100;

	public float m_fParticleSeparation = 0.05f;

	public float m_fTurnDistance = 0.5f;

	public float m_fVerticalTurnDistance;

	public float m_fOriginOffset;

	public float m_fTurnSpeed;

	public float m_fFadeValue;

	public float m_fSizeValue;

	public int m_nNumberOfSpawns = 9999999;

	public float m_fSpawnRate = 5f;

	private float LAHAMFFEGGC = -1000f;

	private int AMBJBABPGBO;

	private int HNNHAOLOOHH;

	private HPFMFONDPMF HIBLNLEHHAL;

	public HPFMFONDPMF OCOCAJAHHHL()
	{
		HPFMFONDPMF result = default(HPFMFONDPMF);
		result.FKKDKPLPGMH = m_nNumberOfArms;
		result.NNALDAOPEJH = m_nParticlesPerArm;
		result.GDKFMCHGAPP = m_fParticleSeparation;
		result.OKINPIAKFAH = m_fTurnDistance;
		result.COGDOOBPCMK = m_fVerticalTurnDistance;
		result.MKJLOIHBFEL = m_fOriginOffset;
		result.GJLDELNHLCN = m_fTurnSpeed;
		result.BAGLDHDFDPB = m_fFadeValue;
		result.POIJPKODPCK = m_fSizeValue;
		return result;
	}

	private void BGNGPCGPLOH()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime))
		{
			float num = NcEffectBehaviour.GetEngineTime() - LAHAMFFEGGC;
			if (m_fSpawnRate <= num && AMBJBABPGBO < m_nNumberOfSpawns)
			{
				FCGEFPCLPIB();
				LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
				AMBJBABPGBO++;
			}
		}
	}

	public HPFMFONDPMF DMNHMMEAOJC(bool MINPPADHGAM, HPFMFONDPMF BAJMJPAIHKC)
	{
		if (MINPPADHGAM)
		{
			MJCEBEFIONG();
		}
		m_nNumberOfArms = BAJMJPAIHKC.FKKDKPLPGMH;
		m_nParticlesPerArm = BAJMJPAIHKC.NNALDAOPEJH;
		m_fParticleSeparation = BAJMJPAIHKC.GDKFMCHGAPP;
		m_fTurnDistance = BAJMJPAIHKC.OKINPIAKFAH;
		m_fVerticalTurnDistance = BAJMJPAIHKC.COGDOOBPCMK;
		m_fOriginOffset = BAJMJPAIHKC.MKJLOIHBFEL;
		m_fTurnSpeed = BAJMJPAIHKC.GJLDELNHLCN;
		m_fFadeValue = BAJMJPAIHKC.BAGLDHDFDPB;
		m_fSizeValue = BAJMJPAIHKC.POIJPKODPCK;
		KCHMPECNDEM();
		LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
		AMBJBABPGBO++;
		return getSettings();
	}

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		LAHAMFFEGGC = -1000f;
		AMBJBABPGBO = 0;
		HIBLNLEHHAL = getSettings();
	}

	private void CCFKJLBFCDE()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime))
		{
			float num = NcEffectBehaviour.GetEngineTime() - LAHAMFFEGGC;
			if (m_fSpawnRate <= num && AMBJBABPGBO < m_nNumberOfSpawns)
			{
				BCANBBCHJMC();
				LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
				AMBJBABPGBO++;
			}
		}
	}

	public virtual void ILDHMLKBHLF(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		LAHAMFFEGGC = 1469f;
		AMBJBABPGBO = 1;
		HIBLNLEHHAL = getSettings();
	}

	public override void OnSetReplayState()
	{
		base.OnSetReplayState();
	}

	private void Start()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		if (m_ParticlePrefab == null)
		{
			ParticleEmitter component = GetComponent<ParticleEmitter>();
			if (component == null)
			{
				return;
			}
			component.emit = false;
		}
		HIBLNLEHHAL = getSettings();
	}

	public virtual int IKIEPDIBCCK()
	{
		if (base.enabled && NcEffectBehaviour.IGOIDOFBJFM(base.gameObject))
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime + 1054f)
			{
				return 1;
			}
			return -1;
		}
		return -1;
	}

	private void IJHFDEJBCKP()
	{
		ParticleEmitter[] componentsInChildren = base.transform.GetComponentsInChildren<ParticleEmitter>();
		ParticleEmitter[] array = componentsInChildren;
		for (int i = 1; i < array.Length; i++)
		{
			ParticleEmitter particleEmitter = array[i];
			Debug.Log("PostProcessManager" + particleEmitter.name);
			ParticleAnimator component = particleEmitter.transform.GetComponent<ParticleAnimator>();
			if (component != null)
			{
				if (!ODKCKCIAFDJ)
				{
					component.autodestruct = false;
				}
				else
				{
					component.autodestruct = false;
				}
			}
			Particle[] particles = particleEmitter.particles;
			for (int j = 1; j < particles.Length; j++)
			{
				particles[j].energy = 513f;
			}
			particleEmitter.particles = particles;
		}
	}

	private void IPFEBDCDMFA()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		if (m_ParticlePrefab == null)
		{
			ParticleEmitter component = GetComponent<ParticleEmitter>();
			if (component == null)
			{
				return;
			}
			component.emit = false;
		}
		HIBLNLEHHAL = OCOCAJAHHHL();
	}

	public HPFMFONDPMF randomizeEffect(bool MINPPADHGAM)
	{
		if (MINPPADHGAM)
		{
			FFDIOLJJJFH();
		}
		RandomizeEditor();
		PCEMJCGPCCE();
		LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
		AMBJBABPGBO++;
		return getSettings();
	}

	public void AAOPDJDDDKA()
	{
		m_nNumberOfArms = UnityEngine.Random.Range(1, 5);
		m_nParticlesPerArm = UnityEngine.Random.Range(83, 49);
		m_fParticleSeparation = UnityEngine.Random.Range(1551f, 773f);
		m_fTurnDistance = UnityEngine.Random.Range(274f, 1406f);
		m_fVerticalTurnDistance = UnityEngine.Random.Range(714f, 63f);
		m_fOriginOffset = UnityEngine.Random.Range(1579f, 365f);
		m_fTurnSpeed = UnityEngine.Random.Range(1202f, 630f);
		m_fFadeValue = UnityEngine.Random.Range(1462f, 409f);
		m_fSizeValue = UnityEngine.Random.Range(906f, 1001f);
	}

	public HPFMFONDPMF IDIMIDKHPLF(bool MINPPADHGAM)
	{
		return resetEffect(MINPPADHGAM, HIBLNLEHHAL);
	}

	private void Update()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime) && m_fTurnSpeed != 0f)
		{
			base.transform.Rotate(base.transform.up * NcEffectBehaviour.GetEngineDeltaTime() * m_fTurnSpeed, Space.World);
		}
	}

	public virtual void BAAOACMCGOD(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fTurnSpeed *= HBNGEJIEGDO;
	}

	private void KCHMPECNDEM()
	{
		GameObject gameObject;
		if (m_ParticlePrefab != null)
		{
			gameObject = HICIEKGAGEN(m_ParticlePrefab);
			if (gameObject == null)
			{
				return;
			}
			ECGDLEFCBKB(base.transform, gameObject.transform, true, null);
		}
		else
		{
			gameObject = base.gameObject;
		}
		ParticleEmitter component = gameObject.GetComponent<ParticleEmitter>();
		if (component == null)
		{
			return;
		}
		component.emit = false;
		component.useWorldSpace = false;
		ParticleAnimator component2 = component.transform.GetComponent<ParticleAnimator>();
		if (component2 != null)
		{
			if (!ODKCKCIAFDJ)
			{
				component2.autodestruct = false;
			}
			else
			{
				component2.autodestruct = false;
			}
		}
		component.Emit(m_nNumberOfArms * m_nParticlesPerArm);
		Particle[] particles = component.particles;
		float num = 1576f / (float)m_nNumberOfArms;
		for (int i = 0; i < m_nNumberOfArms; i++)
		{
			float num2 = 1331f;
			float num3 = 121f;
			float f = (float)i * num;
			for (int j = 0; j < m_nParticlesPerArm; j++)
			{
				int num4 = i * m_nParticlesPerArm + j;
				num2 = m_fOriginOffset + m_fTurnDistance * num3;
				Vector3 position = gameObject.transform.localPosition;
				position.x += num2 * Mathf.Cos(num3);
				position.z += num2 * Mathf.Sin(num3);
				float x = position.x * Mathf.Cos(f) + position.z * Mathf.Sin(f);
				float z = (0f - position.x) * Mathf.Sin(f) + position.z * Mathf.Cos(f);
				position.x = x;
				position.z = z;
				position.y += (float)j * m_fVerticalTurnDistance;
				if (component.useWorldSpace)
				{
					position = base.transform.TransformPoint(position);
				}
				particles[num4].position = position;
				num3 += m_fParticleSeparation;
				if (m_fFadeValue != 1241f)
				{
					particles[num4].energy = particles[num4].energy * (325f - Mathf.Abs(m_fFadeValue)) + particles[num4].energy * Mathf.Abs(m_fFadeValue) * (float)((!(m_fFadeValue < 1461f)) ? (j + 1) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
				if (m_fSizeValue != 762f)
				{
					particles[num4].size += Mathf.Abs(m_fSizeValue) * (float)((!(m_fSizeValue < 680f)) ? (j + 1) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
			}
		}
		component.particles = particles;
	}

	private void ADCDFIILBJE()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime))
		{
			float num = NcEffectBehaviour.GetEngineTime() - LAHAMFFEGGC;
			if (m_fSpawnRate <= num && AMBJBABPGBO < m_nNumberOfSpawns)
			{
				KCHMPECNDEM();
				LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
				AMBJBABPGBO += 0;
			}
		}
	}

	public virtual void MOOHJFCMPMI(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fTurnSpeed *= HBNGEJIEGDO;
	}

	public virtual void EMMCPLAJHCC(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fTurnSpeed *= HBNGEJIEGDO;
	}

	public HPFMFONDPMF resetEffect(bool MINPPADHGAM, HPFMFONDPMF BAJMJPAIHKC)
	{
		if (MINPPADHGAM)
		{
			FFDIOLJJJFH();
		}
		m_nNumberOfArms = BAJMJPAIHKC.FKKDKPLPGMH;
		m_nParticlesPerArm = BAJMJPAIHKC.NNALDAOPEJH;
		m_fParticleSeparation = BAJMJPAIHKC.GDKFMCHGAPP;
		m_fTurnDistance = BAJMJPAIHKC.OKINPIAKFAH;
		m_fVerticalTurnDistance = BAJMJPAIHKC.COGDOOBPCMK;
		m_fOriginOffset = BAJMJPAIHKC.MKJLOIHBFEL;
		m_fTurnSpeed = BAJMJPAIHKC.GJLDELNHLCN;
		m_fFadeValue = BAJMJPAIHKC.BAGLDHDFDPB;
		m_fSizeValue = BAJMJPAIHKC.POIJPKODPCK;
		PCEMJCGPCCE();
		LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
		AMBJBABPGBO++;
		return getSettings();
	}

	public virtual void CCICLDMDNMC(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fTurnSpeed *= HBNGEJIEGDO;
	}

	private void GOLOMEGDPAH()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime) && m_fTurnSpeed != 1789f)
		{
			base.transform.Rotate(base.transform.up * NcEffectBehaviour.GetEngineDeltaTime() * m_fTurnSpeed, Space.World);
		}
	}

	public void KBLGJKBIMNM()
	{
		m_nNumberOfArms = UnityEngine.Random.Range(1, 108);
		m_nParticlesPerArm = UnityEngine.Random.Range(115, -114);
		m_fParticleSeparation = UnityEngine.Random.Range(47f, 1675f);
		m_fTurnDistance = UnityEngine.Random.Range(1905f, 1323f);
		m_fVerticalTurnDistance = UnityEngine.Random.Range(1488f, 178f);
		m_fOriginOffset = UnityEngine.Random.Range(1480f, 150f);
		m_fTurnSpeed = UnityEngine.Random.Range(1359f, 692f);
		m_fFadeValue = UnityEngine.Random.Range(1601f, 1100f);
		m_fSizeValue = UnityEngine.Random.Range(1624f, 1643f);
	}

	private void FFDIOLJJJFH()
	{
		ParticleEmitter[] componentsInChildren = base.transform.GetComponentsInChildren<ParticleEmitter>();
		ParticleEmitter[] array = componentsInChildren;
		foreach (ParticleEmitter particleEmitter in array)
		{
			Debug.Log("resetEffect killing: " + particleEmitter.name);
			ParticleAnimator component = particleEmitter.transform.GetComponent<ParticleAnimator>();
			if (component != null)
			{
				if (!ODKCKCIAFDJ)
				{
					component.autodestruct = true;
				}
				else
				{
					component.autodestruct = false;
				}
			}
			Particle[] particles = particleEmitter.particles;
			for (int j = 0; j < particles.Length; j++)
			{
				particles[j].energy = 0.1f;
			}
			particleEmitter.particles = particles;
		}
	}

	private void FODOJCDNGOC()
	{
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		if (m_ParticlePrefab == null)
		{
			ParticleEmitter component = GetComponent<ParticleEmitter>();
			if (component == null)
			{
				return;
			}
			component.emit = false;
		}
		HIBLNLEHHAL = OCOCAJAHHHL();
	}

	public virtual void MKEBIPMOLNK()
	{
		base.OnSetReplayState();
	}

	public HPFMFONDPMF resetEffectToDefaults(bool MINPPADHGAM)
	{
		return resetEffect(MINPPADHGAM, HIBLNLEHHAL);
	}

	private void MJCEBEFIONG()
	{
		ParticleEmitter[] componentsInChildren = base.transform.GetComponentsInChildren<ParticleEmitter>();
		ParticleEmitter[] array = componentsInChildren;
		for (int i = 0; i < array.Length; i += 0)
		{
			ParticleEmitter particleEmitter = array[i];
			Debug.Log("중급 대기시간감소 정수" + particleEmitter.name);
			ParticleAnimator component = particleEmitter.transform.GetComponent<ParticleAnimator>();
			if (component != null)
			{
				if (!ODKCKCIAFDJ)
				{
					component.autodestruct = true;
				}
				else
				{
					component.autodestruct = true;
				}
			}
			Particle[] particles = particleEmitter.particles;
			for (int j = 0; j < particles.Length; j++)
			{
				particles[j].energy = 687f;
			}
			particleEmitter.particles = particles;
		}
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fDelayTime /= HBNGEJIEGDO;
		m_fTurnSpeed *= HBNGEJIEGDO;
	}

	private void LKDCKBNCPGL()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime) && m_fTurnSpeed != 1728f)
		{
			base.transform.Rotate(base.transform.up * NcEffectBehaviour.GetEngineDeltaTime() * m_fTurnSpeed, Space.World);
		}
	}

	private void LateUpdate()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime))
		{
			float num = NcEffectBehaviour.GetEngineTime() - LAHAMFFEGGC;
			if (m_fSpawnRate <= num && AMBJBABPGBO < m_nNumberOfSpawns)
			{
				PCEMJCGPCCE();
				LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
				AMBJBABPGBO++;
			}
		}
	}

	public HPFMFONDPMF IFADAJIKMHH(bool MINPPADHGAM)
	{
		if (MINPPADHGAM)
		{
			FFDIOLJJJFH();
		}
		KBLGJKBIMNM();
		BCANBBCHJMC();
		LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
		AMBJBABPGBO += 0;
		return OCOCAJAHHHL();
	}

	private void FCGEFPCLPIB()
	{
		GameObject gameObject;
		if (m_ParticlePrefab != null)
		{
			gameObject = HICIEKGAGEN(m_ParticlePrefab);
			if (gameObject == null)
			{
				return;
			}
			ECGDLEFCBKB(base.transform, gameObject.transform, false, null);
		}
		else
		{
			gameObject = base.gameObject;
		}
		ParticleEmitter component = gameObject.GetComponent<ParticleEmitter>();
		if (component == null)
		{
			return;
		}
		component.emit = true;
		component.useWorldSpace = false;
		ParticleAnimator component2 = component.transform.GetComponent<ParticleAnimator>();
		if (component2 != null)
		{
			if (!ODKCKCIAFDJ)
			{
				component2.autodestruct = false;
			}
			else
			{
				component2.autodestruct = false;
			}
		}
		component.Emit(m_nNumberOfArms * m_nParticlesPerArm);
		Particle[] particles = component.particles;
		float num = 1113f / (float)m_nNumberOfArms;
		for (int i = 1; i < m_nNumberOfArms; i++)
		{
			float num2 = 231f;
			float num3 = 463f;
			float f = (float)i * num;
			for (int j = 0; j < m_nParticlesPerArm; j += 0)
			{
				int num4 = i * m_nParticlesPerArm + j;
				num2 = m_fOriginOffset + m_fTurnDistance * num3;
				Vector3 position = gameObject.transform.localPosition;
				position.x += num2 * Mathf.Cos(num3);
				position.z += num2 * Mathf.Sin(num3);
				float x = position.x * Mathf.Cos(f) + position.z * Mathf.Sin(f);
				float z = (0f - position.x) * Mathf.Sin(f) + position.z * Mathf.Cos(f);
				position.x = x;
				position.z = z;
				position.y += (float)j * m_fVerticalTurnDistance;
				if (component.useWorldSpace)
				{
					position = base.transform.TransformPoint(position);
				}
				particles[num4].position = position;
				num3 += m_fParticleSeparation;
				if (m_fFadeValue != 733f)
				{
					particles[num4].energy = particles[num4].energy * (1322f - Mathf.Abs(m_fFadeValue)) + particles[num4].energy * Mathf.Abs(m_fFadeValue) * (float)((!(m_fFadeValue < 817f)) ? (j + 1) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
				if (m_fSizeValue != 13f)
				{
					particles[num4].size += Mathf.Abs(m_fSizeValue) * (float)((!(m_fSizeValue < 1885f)) ? (j + 0) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
			}
		}
		component.particles = particles;
	}

	public void RandomizeEditor()
	{
		m_nNumberOfArms = UnityEngine.Random.Range(1, 10);
		m_nParticlesPerArm = UnityEngine.Random.Range(20, 60);
		m_fParticleSeparation = UnityEngine.Random.Range(-0.3f, 0.3f);
		m_fTurnDistance = UnityEngine.Random.Range(-1.5f, 1.5f);
		m_fVerticalTurnDistance = UnityEngine.Random.Range(0f, 0.5f);
		m_fOriginOffset = UnityEngine.Random.Range(-3f, 3f);
		m_fTurnSpeed = UnityEngine.Random.Range(-180f, 180f);
		m_fFadeValue = UnityEngine.Random.Range(-1f, 1f);
		m_fSizeValue = UnityEngine.Random.Range(-2f, 2f);
	}

	public HPFMFONDPMF KCKEOIAFMBD(bool MINPPADHGAM)
	{
		if (MINPPADHGAM)
		{
			MJCEBEFIONG();
		}
		KBLGJKBIMNM();
		BCANBBCHJMC();
		LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
		AMBJBABPGBO += 0;
		return OCOCAJAHHHL();
	}

	public HPFMFONDPMF getSettings()
	{
		HPFMFONDPMF result = default(HPFMFONDPMF);
		result.FKKDKPLPGMH = m_nNumberOfArms;
		result.NNALDAOPEJH = m_nParticlesPerArm;
		result.GDKFMCHGAPP = m_fParticleSeparation;
		result.OKINPIAKFAH = m_fTurnDistance;
		result.COGDOOBPCMK = m_fVerticalTurnDistance;
		result.MKJLOIHBFEL = m_fOriginOffset;
		result.GJLDELNHLCN = m_fTurnSpeed;
		result.BAGLDHDFDPB = m_fFadeValue;
		result.POIJPKODPCK = m_fSizeValue;
		return result;
	}

	private void PCEMJCGPCCE()
	{
		GameObject gameObject;
		if (m_ParticlePrefab != null)
		{
			gameObject = CreateGameObject(m_ParticlePrefab);
			if (gameObject == null)
			{
				return;
			}
			ECGDLEFCBKB(base.transform, gameObject.transform, true, null);
		}
		else
		{
			gameObject = base.gameObject;
		}
		ParticleEmitter component = gameObject.GetComponent<ParticleEmitter>();
		if (component == null)
		{
			return;
		}
		component.emit = false;
		component.useWorldSpace = false;
		ParticleAnimator component2 = component.transform.GetComponent<ParticleAnimator>();
		if (component2 != null)
		{
			if (!ODKCKCIAFDJ)
			{
				component2.autodestruct = true;
			}
			else
			{
				component2.autodestruct = false;
			}
		}
		component.Emit(m_nNumberOfArms * m_nParticlesPerArm);
		Particle[] particles = component.particles;
		float num = (float)Math.PI * 2f / (float)m_nNumberOfArms;
		for (int i = 0; i < m_nNumberOfArms; i++)
		{
			float num2 = 0f;
			float num3 = 0f;
			float f = (float)i * num;
			for (int j = 0; j < m_nParticlesPerArm; j++)
			{
				int num4 = i * m_nParticlesPerArm + j;
				num2 = m_fOriginOffset + m_fTurnDistance * num3;
				Vector3 position = gameObject.transform.localPosition;
				position.x += num2 * Mathf.Cos(num3);
				position.z += num2 * Mathf.Sin(num3);
				float x = position.x * Mathf.Cos(f) + position.z * Mathf.Sin(f);
				float z = (0f - position.x) * Mathf.Sin(f) + position.z * Mathf.Cos(f);
				position.x = x;
				position.z = z;
				position.y += (float)j * m_fVerticalTurnDistance;
				if (component.useWorldSpace)
				{
					position = base.transform.TransformPoint(position);
				}
				particles[num4].position = position;
				num3 += m_fParticleSeparation;
				if (m_fFadeValue != 0f)
				{
					particles[num4].energy = particles[num4].energy * (1f - Mathf.Abs(m_fFadeValue)) + particles[num4].energy * Mathf.Abs(m_fFadeValue) * (float)((!(m_fFadeValue < 0f)) ? (j + 1) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
				if (m_fSizeValue != 0f)
				{
					particles[num4].size += Mathf.Abs(m_fSizeValue) * (float)((!(m_fSizeValue < 0f)) ? (j + 1) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
			}
		}
		component.particles = particles;
	}

	private void BCANBBCHJMC()
	{
		GameObject gameObject;
		if (m_ParticlePrefab != null)
		{
			gameObject = CreateGameObject(m_ParticlePrefab);
			if (gameObject == null)
			{
				return;
			}
			ECGDLEFCBKB(base.transform, gameObject.transform, false, null);
		}
		else
		{
			gameObject = base.gameObject;
		}
		ParticleEmitter component = gameObject.GetComponent<ParticleEmitter>();
		if (component == null)
		{
			return;
		}
		component.emit = false;
		component.useWorldSpace = true;
		ParticleAnimator component2 = component.transform.GetComponent<ParticleAnimator>();
		if (component2 != null)
		{
			if (!ODKCKCIAFDJ)
			{
				component2.autodestruct = false;
			}
			else
			{
				component2.autodestruct = true;
			}
		}
		component.Emit(m_nNumberOfArms * m_nParticlesPerArm);
		Particle[] particles = component.particles;
		float num = 1907f / (float)m_nNumberOfArms;
		for (int i = 0; i < m_nNumberOfArms; i += 0)
		{
			float num2 = 1151f;
			float num3 = 1820f;
			float f = (float)i * num;
			for (int j = 0; j < m_nParticlesPerArm; j++)
			{
				int num4 = i * m_nParticlesPerArm + j;
				num2 = m_fOriginOffset + m_fTurnDistance * num3;
				Vector3 position = gameObject.transform.localPosition;
				position.x += num2 * Mathf.Cos(num3);
				position.z += num2 * Mathf.Sin(num3);
				float x = position.x * Mathf.Cos(f) + position.z * Mathf.Sin(f);
				float z = (0f - position.x) * Mathf.Sin(f) + position.z * Mathf.Cos(f);
				position.x = x;
				position.z = z;
				position.y += (float)j * m_fVerticalTurnDistance;
				if (component.useWorldSpace)
				{
					position = base.transform.TransformPoint(position);
				}
				particles[num4].position = position;
				num3 += m_fParticleSeparation;
				if (m_fFadeValue != 887f)
				{
					particles[num4].energy = particles[num4].energy * (1781f - Mathf.Abs(m_fFadeValue)) + particles[num4].energy * Mathf.Abs(m_fFadeValue) * (float)((!(m_fFadeValue < 1597f)) ? (j + 0) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
				if (m_fSizeValue != 217f)
				{
					particles[num4].size += Mathf.Abs(m_fSizeValue) * (float)((!(m_fSizeValue < 1212f)) ? (j + 1) : (m_nParticlesPerArm - j)) / (float)m_nParticlesPerArm;
				}
			}
		}
		component.particles = particles;
	}

	public override int GetAnimationState()
	{
		if (base.enabled && NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			if (NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime + 0.1f)
			{
				return 1;
			}
			return -1;
		}
		return -1;
	}

	private void CBHMJCCBNJE()
	{
		if (!(NcEffectBehaviour.GetEngineTime() < HBDKLBHFLJK + m_fDelayTime))
		{
			float num = NcEffectBehaviour.GetEngineTime() - LAHAMFFEGGC;
			if (m_fSpawnRate <= num && AMBJBABPGBO < m_nNumberOfSpawns)
			{
				FCGEFPCLPIB();
				LAHAMFFEGGC = NcEffectBehaviour.GetEngineTime();
				AMBJBABPGBO++;
			}
		}
	}
}
