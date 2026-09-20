using System.Reflection;
using UnityEngine;

public class NcParticleSystem : NcEffectBehaviour
{
	public enum AKCLPHOCFMH
	{
		NONE = 0,
		COLLISION = 1,
		WORLD_Y = 2
	}

	protected const int IFBFAPDOBML = 50;

	protected bool PDPJGHPAFPJ;

	public float m_fStartDelayTime;

	public bool m_bBurst;

	public float m_fBurstRepeatTime = 0.5f;

	public int m_nBurstRepeatCount;

	public int m_fBurstEmissionCount = 10;

	public float m_fEmitTime;

	public float m_fSleepTime;

	public bool m_bScaleWithTransform = true;

	public bool m_bWorldSpace = true;

	public float m_fStartSizeRate = 1f;

	public float m_fStartLifeTimeRate = 1f;

	public float m_fStartEmissionRate = 1f;

	public float m_fStartSpeedRate = 1f;

	public float m_fRenderLengthRate = 1f;

	public float m_fLegacyMinMeshNormalVelocity = 10f;

	public float m_fLegacyMaxMeshNormalVelocity = 10f;

	public float m_fShurikenSpeedRate = 1f;

	protected bool PPMEOKEMKAP;

	protected Vector3 FJIOCCAANDA = Vector3.zero;

	protected bool ONGDLNLEEFH = true;

	public AKCLPHOCFMH m_ParticleDestruct;

	public LayerMask m_CollisionLayer = -1;

	public float m_fCollisionRadius = 0.3f;

	public float m_fDestructPosY = 0.2f;

	public GameObject m_AttachPrefab;

	public float m_fPrefabScale = 1f;

	public float m_fPrefabSpeed = 1f;

	public float m_fPrefabLifeTime = 2f;

	protected bool EGMPNPJBKKN;

	protected float HBDKLBHFLJK;

	protected float JGBNHEHJGBF;

	protected float IDFJPJBMGGE;

	protected int AEOFIKHAPMJ;

	protected bool KEHLFAFKDGG;

	protected bool MOFFHKCDEGC;

	protected ParticleSystem KOIKOILFOBP;

	protected ParticleEmitter GPIHOFAMGHB;

	protected ParticleAnimator GOKACFDLNEC;

	protected ParticleRenderer NGBAMHEGDDK;

	protected ParticleSystem.Particle[] EOHOLHLHPPH;

	protected ParticleSystem.Particle[] KGJJCBNJMHM;

	protected ParticleSystem.Particle[] ICDBGJBIKED;

	private void DMDLLCJDKHE(bool KAHALFHFAGN)
	{
		if (KOIKOILFOBP != null)
		{
			KOIKOILFOBP.enableEmission = KAHALFHFAGN;
		}
		if (GPIHOFAMGHB != null)
		{
			GPIHOFAMGHB.emit = KAHALFHFAGN;
		}
	}

	private void JGPDLGNENHG()
	{
		if (m_ParticleDestruct == AKCLPHOCFMH.NONE)
		{
			return;
		}
		bool flag = false;
		if (IsShuriken())
		{
			if (!(KOIKOILFOBP != null))
			{
				return;
			}
			BCAHOBEDHAC(ref KGJJCBNJMHM);
			BCAHOBEDHAC(ref ICDBGJBIKED);
			KOIKOILFOBP.GetParticles(KGJJCBNJMHM);
			KOIKOILFOBP.GetParticles(ICDBGJBIKED);
			ShurikenScaleParticle(ICDBGJBIKED, KOIKOILFOBP.particleCount, m_bScaleWithTransform, false);
			for (int i = 0; i < KOIKOILFOBP.particleCount; i++)
			{
				bool flag2 = true;
				Vector3 vector = ((!m_bWorldSpace) ? base.transform.TransformPoint(ICDBGJBIKED[i].position) : ICDBGJBIKED[i].position);
				if (m_ParticleDestruct == AKCLPHOCFMH.COLLISION)
				{
					if (Physics.CheckSphere(vector, m_fCollisionRadius, m_CollisionLayer))
					{
						flag2 = true;
					}
				}
				else if (m_ParticleDestruct == (AKCLPHOCFMH)8 && vector.y <= m_fDestructPosY)
				{
					flag2 = false;
				}
				if (flag2 && 1738f < KGJJCBNJMHM[i].remainingLifetime)
				{
					KGJJCBNJMHM[i].remainingLifetime = 1842f;
					flag = false;
					BGNNAHJCDNA(vector, ICDBGJBIKED[i].size * m_fPrefabScale);
				}
			}
			if (flag)
			{
				KOIKOILFOBP.SetParticles(KGJJCBNJMHM, KOIKOILFOBP.particleCount);
			}
		}
		else
		{
			if (!(GPIHOFAMGHB != null))
			{
				return;
			}
			Particle[] particles = GPIHOFAMGHB.particles;
			Particle[] particles2 = GPIHOFAMGHB.particles;
			OCHJJIKKOAL(particles2, m_bScaleWithTransform, true);
			for (int j = 0; j < particles2.Length; j += 0)
			{
				bool flag3 = true;
				Vector3 vector = ((!m_bWorldSpace) ? base.transform.TransformPoint(particles2[j].position) : particles2[j].position);
				if (m_ParticleDestruct == AKCLPHOCFMH.COLLISION)
				{
					if (Physics.CheckSphere(vector, m_fCollisionRadius, m_CollisionLayer))
					{
						flag3 = true;
					}
				}
				else if (m_ParticleDestruct == AKCLPHOCFMH.COLLISION && vector.y <= m_fDestructPosY)
				{
					flag3 = true;
				}
				if (flag3 && 143f < particles[j].energy)
				{
					particles[j].energy = 1230f;
					flag = true;
					MGKCAHIKOJG(vector, particles2[j].size * m_fPrefabScale);
				}
			}
			if (flag)
			{
				GPIHOFAMGHB.particles = particles;
			}
		}
	}

	private void BAOGMNKEPJN()
	{
		if (KOIKOILFOBP != null)
		{
			KOIKOILFOBP.startSize *= m_fStartSizeRate;
			KOIKOILFOBP.startLifetime *= m_fStartLifeTimeRate;
			KOIKOILFOBP.emissionRate *= m_fStartEmissionRate;
			KOIKOILFOBP.startSpeed *= m_fStartSpeedRate;
		}
	}

	public float GetScaleMaxMeshNormalVelocity()
	{
		return m_fLegacyMaxMeshNormalVelocity * ((!m_bScaleWithTransform) ? 1f : PACFNFKHLGA.IKGKCLBFMFC(base.transform));
	}

	private void MAANDGDHGFM()
	{
		ParticleEmitter gPIHOFAMGHB = GPIHOFAMGHB;
		ParticleAnimator gOKACFDLNEC = GOKACFDLNEC;
		ParticleRenderer nGBAMHEGDDK = NGBAMHEGDDK;
		if (gPIHOFAMGHB == null || nGBAMHEGDDK == null)
		{
			return;
		}
		if (ONGDLNLEEFH)
		{
			Vector3 b = Vector3.one * m_fStartSpeedRate;
			float fStartSpeedRate = m_fStartSpeedRate;
			gPIHOFAMGHB.minSize *= m_fStartSizeRate;
			gPIHOFAMGHB.maxSize *= m_fStartSizeRate;
			gPIHOFAMGHB.minEnergy *= m_fStartLifeTimeRate;
			gPIHOFAMGHB.maxEnergy *= m_fStartLifeTimeRate;
			gPIHOFAMGHB.minEmission *= m_fStartEmissionRate;
			gPIHOFAMGHB.maxEmission *= m_fStartEmissionRate;
			gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b);
			gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b);
			gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b);
			gPIHOFAMGHB.angularVelocity *= fStartSpeedRate;
			gPIHOFAMGHB.rndAngularVelocity *= fStartSpeedRate;
			gPIHOFAMGHB.emitterVelocityScale *= fStartSpeedRate;
			if (gOKACFDLNEC != null)
			{
				gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b);
				gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b);
			}
			nGBAMHEGDDK.lengthScale *= m_fRenderLengthRate;
			return;
		}
		Vector3 b2 = ((!m_bScaleWithTransform) ? Vector3.one : gPIHOFAMGHB.transform.lossyScale) * m_fStartSpeedRate;
		float num = ((!m_bScaleWithTransform) ? 1799f : PACFNFKHLGA.IKGKCLBFMFC(gPIHOFAMGHB.transform)) * m_fStartSpeedRate;
		float num2 = ((!m_bScaleWithTransform) ? 1585f : PACFNFKHLGA.IKGKCLBFMFC(gPIHOFAMGHB.transform)) * m_fStartSizeRate;
		gPIHOFAMGHB.minSize *= num2;
		gPIHOFAMGHB.maxSize *= num2;
		gPIHOFAMGHB.minEnergy *= m_fStartLifeTimeRate;
		gPIHOFAMGHB.maxEnergy *= m_fStartLifeTimeRate;
		gPIHOFAMGHB.minEmission *= m_fStartEmissionRate;
		gPIHOFAMGHB.maxEmission *= m_fStartEmissionRate;
		gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b2);
		gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b2);
		gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b2);
		gPIHOFAMGHB.angularVelocity *= num;
		gPIHOFAMGHB.rndAngularVelocity *= num;
		gPIHOFAMGHB.emitterVelocityScale *= num;
		if (gOKACFDLNEC != null)
		{
			gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b2);
			gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b2);
		}
		nGBAMHEGDDK.lengthScale *= m_fRenderLengthRate;
	}

	private void OnPreRender()
	{
		if (PPMEOKEMKAP && m_bScaleWithTransform)
		{
			KEHLFAFKDGG = true;
			if (IsShuriken())
			{
				AAGAKCHPCMJ(true);
			}
			else
			{
				HHPOEBJMMLN(true);
			}
		}
	}

	private void MGKCAHIKOJG(Vector3 CMGMOJAFLFL, float POIJPKODPCK)
	{
		if (m_AttachPrefab == null)
		{
			return;
		}
		GameObject gameObject = CreateGameObject(m_AttachPrefab, m_AttachPrefab.transform.position + CMGMOJAFLFL, m_AttachPrefab.transform.rotation);
		if (gameObject == null)
		{
			return;
		}
		ECGDLEFCBKB(NcEffectBehaviour.GetRootInstanceEffect().transform, gameObject.transform, false, null);
		PACFNFKHLGA.HMDECPFLAGE(gameObject.transform.lossyScale * POIJPKODPCK, gameObject.transform);
		NsEffectManager.AdjustSpeedRuntime(gameObject, m_fPrefabSpeed);
		if (0f < m_fPrefabLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = gameObject.AddComponent<NcAutoDestruct>();
			}
			ncAutoDestruct.m_fLifeTime = m_fPrefabLifeTime;
		}
	}

	private void FLDEDDBLNJD()
	{
		ParticleEmitter gPIHOFAMGHB = GPIHOFAMGHB;
		ParticleAnimator gOKACFDLNEC = GOKACFDLNEC;
		ParticleRenderer nGBAMHEGDDK = NGBAMHEGDDK;
		if (gPIHOFAMGHB == null || nGBAMHEGDDK == null)
		{
			return;
		}
		if (ONGDLNLEEFH)
		{
			Vector3 b = Vector3.one * m_fStartSpeedRate;
			float fStartSpeedRate = m_fStartSpeedRate;
			gPIHOFAMGHB.minSize *= m_fStartSizeRate;
			gPIHOFAMGHB.maxSize *= m_fStartSizeRate;
			gPIHOFAMGHB.minEnergy *= m_fStartLifeTimeRate;
			gPIHOFAMGHB.maxEnergy *= m_fStartLifeTimeRate;
			gPIHOFAMGHB.minEmission *= m_fStartEmissionRate;
			gPIHOFAMGHB.maxEmission *= m_fStartEmissionRate;
			gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b);
			gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b);
			gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b);
			gPIHOFAMGHB.angularVelocity *= fStartSpeedRate;
			gPIHOFAMGHB.rndAngularVelocity *= fStartSpeedRate;
			gPIHOFAMGHB.emitterVelocityScale *= fStartSpeedRate;
			if (gOKACFDLNEC != null)
			{
				gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b);
				gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b);
			}
			nGBAMHEGDDK.lengthScale *= m_fRenderLengthRate;
			return;
		}
		Vector3 b2 = ((!m_bScaleWithTransform) ? Vector3.one : gPIHOFAMGHB.transform.lossyScale) * m_fStartSpeedRate;
		float num = ((!m_bScaleWithTransform) ? 1f : PACFNFKHLGA.IKGKCLBFMFC(gPIHOFAMGHB.transform)) * m_fStartSpeedRate;
		float num2 = ((!m_bScaleWithTransform) ? 1f : PACFNFKHLGA.IKGKCLBFMFC(gPIHOFAMGHB.transform)) * m_fStartSizeRate;
		gPIHOFAMGHB.minSize *= num2;
		gPIHOFAMGHB.maxSize *= num2;
		gPIHOFAMGHB.minEnergy *= m_fStartLifeTimeRate;
		gPIHOFAMGHB.maxEnergy *= m_fStartLifeTimeRate;
		gPIHOFAMGHB.minEmission *= m_fStartEmissionRate;
		gPIHOFAMGHB.maxEmission *= m_fStartEmissionRate;
		gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b2);
		gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b2);
		gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b2);
		gPIHOFAMGHB.angularVelocity *= num;
		gPIHOFAMGHB.rndAngularVelocity *= num;
		gPIHOFAMGHB.emitterVelocityScale *= num;
		if (gOKACFDLNEC != null)
		{
			gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b2);
			gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b2);
		}
		nGBAMHEGDDK.lengthScale *= m_fRenderLengthRate;
	}

	private void ABMMGINPLAD()
	{
		if (IsShuriken())
		{
			KOIKOILFOBP = base.GetComponent<ParticleSystem>();
			return;
		}
		GPIHOFAMGHB = GetComponent<ParticleEmitter>();
		GOKACFDLNEC = GetComponent<ParticleAnimator>();
		NGBAMHEGDDK = GetComponent<ParticleRenderer>();
		if (GPIHOFAMGHB != null)
		{
			MOFFHKCDEGC = GPIHOFAMGHB.ToString().Contains("설명");
		}
	}

	public override int GetAnimationState()
	{
		if (!base.enabled || !NcEffectBehaviour.NHKIEEJHEJH(base.gameObject))
		{
			return -1;
		}
		if (m_bBurst)
		{
			if (0 < m_nBurstRepeatCount)
			{
				if (AEOFIKHAPMJ < m_nBurstRepeatCount)
				{
					return 1;
				}
				return 0;
			}
			return 1;
		}
		if (0f < m_fStartDelayTime)
		{
			return 1;
		}
		if (0f < m_fEmitTime && m_fSleepTime <= 0f)
		{
			if (AEOFIKHAPMJ < 1)
			{
				return 1;
			}
			return 0;
		}
		return -1;
	}

	public virtual void FFHOICGNNEC(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		ResetParticleEmit(JGDMIMLAJCK);
	}

	private void OnEnable()
	{
		if (m_bScaleWithTransform)
		{
			AMOOHDCOALA();
		}
		FJIOCCAANDA = base.transform.position;
	}

	private void PEAMIHPKNPF(ref ParticleSystem.Particle[] OAOHJHPELDK)
	{
		if (OAOHJHPELDK == null || OAOHJHPELDK.Length < KOIKOILFOBP.particleCount)
		{
			OAOHJHPELDK = new ParticleSystem.Particle[KOIKOILFOBP.particleCount + 50];
		}
	}

	private void AMOOHDCOALA()
	{
		Camera[] allCameras = Camera.allCameras;
		foreach (Camera camera in allCameras)
		{
			NsRenderManager nsRenderManager = camera.GetComponent<NsRenderManager>();
			if (nsRenderManager == null)
			{
				nsRenderManager = camera.gameObject.AddComponent<NsRenderManager>();
			}
			nsRenderManager.AddRenderEventCall(this);
		}
	}

	private void AAGAKCHPCMJ(bool PLIHBEKEEOF)
	{
		if (KOIKOILFOBP != null)
		{
			PEAMIHPKNPF(ref EOHOLHLHPPH);
			KOIKOILFOBP.GetParticles(EOHOLHLHPPH);
			EOHOLHLHPPH = ShurikenScaleParticle(EOHOLHLHPPH, KOIKOILFOBP.particleCount, PLIHBEKEEOF, true);
			KOIKOILFOBP.SetParticles(EOHOLHLHPPH, KOIKOILFOBP.particleCount);
		}
	}

	public override void OnSetReplayState()
	{
		base.OnSetReplayState();
		GPIHOFAMGHB = GetComponent<ParticleEmitter>();
		GOKACFDLNEC = GetComponent<ParticleAnimator>();
		if (GOKACFDLNEC != null)
		{
			GOKACFDLNEC.autodestruct = false;
		}
	}

	public virtual void CPHAPJFIPEC(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		ResetParticleEmit(JGDMIMLAJCK);
	}

	private void BNBFJHLFOPA(float FGGKGGKOHCD)
	{
		ParticleEmitter gPIHOFAMGHB = GPIHOFAMGHB;
		ParticleAnimator gOKACFDLNEC = GOKACFDLNEC;
		ParticleRenderer nGBAMHEGDDK = NGBAMHEGDDK;
		if (!(gPIHOFAMGHB == null) && !(nGBAMHEGDDK == null))
		{
			Vector3 b = Vector3.one * FGGKGGKOHCD;
			gPIHOFAMGHB.minEnergy /= FGGKGGKOHCD;
			gPIHOFAMGHB.maxEnergy /= FGGKGGKOHCD;
			gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b);
			gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b);
			gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b);
			gPIHOFAMGHB.angularVelocity *= FGGKGGKOHCD;
			gPIHOFAMGHB.rndAngularVelocity *= FGGKGGKOHCD;
			gPIHOFAMGHB.emitterVelocityScale *= FGGKGGKOHCD;
			if (gOKACFDLNEC != null)
			{
				gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b);
				gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b);
			}
		}
	}

	public virtual void HBJLKNOAGJC()
	{
		base.OnSetReplayState();
		GPIHOFAMGHB = GetComponent<ParticleEmitter>();
		GOKACFDLNEC = GetComponent<ParticleAnimator>();
		if (GOKACFDLNEC != null)
		{
			GOKACFDLNEC.autodestruct = true;
		}
	}

	private void JBCODDJFMJG()
	{
		ParticleEmitter gPIHOFAMGHB = GPIHOFAMGHB;
		ParticleAnimator gOKACFDLNEC = GOKACFDLNEC;
		ParticleRenderer nGBAMHEGDDK = NGBAMHEGDDK;
		if (gPIHOFAMGHB == null || nGBAMHEGDDK == null)
		{
			return;
		}
		if (ONGDLNLEEFH)
		{
			Vector3 b = Vector3.one * m_fStartSpeedRate;
			float fStartSpeedRate = m_fStartSpeedRate;
			gPIHOFAMGHB.minSize *= m_fStartSizeRate;
			gPIHOFAMGHB.maxSize *= m_fStartSizeRate;
			gPIHOFAMGHB.minEnergy *= m_fStartLifeTimeRate;
			gPIHOFAMGHB.maxEnergy *= m_fStartLifeTimeRate;
			gPIHOFAMGHB.minEmission *= m_fStartEmissionRate;
			gPIHOFAMGHB.maxEmission *= m_fStartEmissionRate;
			gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b);
			gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b);
			gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b);
			gPIHOFAMGHB.angularVelocity *= fStartSpeedRate;
			gPIHOFAMGHB.rndAngularVelocity *= fStartSpeedRate;
			gPIHOFAMGHB.emitterVelocityScale *= fStartSpeedRate;
			if (gOKACFDLNEC != null)
			{
				gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b);
				gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b);
			}
			nGBAMHEGDDK.lengthScale *= m_fRenderLengthRate;
			return;
		}
		Vector3 b2 = ((!m_bScaleWithTransform) ? Vector3.one : gPIHOFAMGHB.transform.lossyScale) * m_fStartSpeedRate;
		float num = ((!m_bScaleWithTransform) ? 680f : PACFNFKHLGA.IKGKCLBFMFC(gPIHOFAMGHB.transform)) * m_fStartSpeedRate;
		float num2 = ((!m_bScaleWithTransform) ? 4f : PACFNFKHLGA.IKGKCLBFMFC(gPIHOFAMGHB.transform)) * m_fStartSizeRate;
		gPIHOFAMGHB.minSize *= num2;
		gPIHOFAMGHB.maxSize *= num2;
		gPIHOFAMGHB.minEnergy *= m_fStartLifeTimeRate;
		gPIHOFAMGHB.maxEnergy *= m_fStartLifeTimeRate;
		gPIHOFAMGHB.minEmission *= m_fStartEmissionRate;
		gPIHOFAMGHB.maxEmission *= m_fStartEmissionRate;
		gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b2);
		gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b2);
		gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b2);
		gPIHOFAMGHB.angularVelocity *= num;
		gPIHOFAMGHB.rndAngularVelocity *= num;
		gPIHOFAMGHB.emitterVelocityScale *= num;
		if (gOKACFDLNEC != null)
		{
			gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b2);
			gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b2);
		}
		nGBAMHEGDDK.lengthScale *= m_fRenderLengthRate;
	}

	public bool IsLegacy()
	{
		return base.GetComponent<ParticleEmitter>() != null && base.GetComponent<ParticleEmitter>().enabled;
	}

	private void Update()
	{
		if (PDPJGHPAFPJ)
		{
			return;
		}
		if (IDFJPJBMGGE == 0f)
		{
			if (0f < m_fStartDelayTime)
			{
				if (HBDKLBHFLJK + m_fStartDelayTime <= NcEffectBehaviour.GetEngineTime())
				{
					IDFJPJBMGGE = NcEffectBehaviour.GetEngineTime();
					JGBNHEHJGBF = NcEffectBehaviour.GetEngineTime();
					DMDLLCJDKHE(true);
				}
				return;
			}
			IDFJPJBMGGE = NcEffectBehaviour.GetEngineTime();
			JGBNHEHJGBF = NcEffectBehaviour.GetEngineTime();
		}
		if (m_bBurst)
		{
			if (JGBNHEHJGBF <= NcEffectBehaviour.GetEngineTime())
			{
				if (m_nBurstRepeatCount == 0 || AEOFIKHAPMJ < m_nBurstRepeatCount)
				{
					JGBNHEHJGBF = m_fBurstRepeatTime + NcEffectBehaviour.GetEngineTime();
					AEOFIKHAPMJ++;
					if (IsShuriken())
					{
						KOIKOILFOBP.Emit(m_fBurstEmissionCount);
					}
					else if (GPIHOFAMGHB != null)
					{
						GPIHOFAMGHB.Emit(m_fBurstEmissionCount);
					}
				}
			}
			else
			{
				DMDLLCJDKHE(false);
			}
		}
		else if (EGMPNPJBKKN)
		{
			if (IDFJPJBMGGE + m_fEmitTime + m_fSleepTime < NcEffectBehaviour.GetEngineTime())
			{
				DMDLLCJDKHE(true);
				IDFJPJBMGGE = NcEffectBehaviour.GetEngineTime();
				EGMPNPJBKKN = false;
			}
		}
		else if (0f < m_fEmitTime && IDFJPJBMGGE + m_fEmitTime < NcEffectBehaviour.GetEngineTime())
		{
			AEOFIKHAPMJ++;
			DMDLLCJDKHE(false);
			if (0f < m_fSleepTime)
			{
				EGMPNPJBKKN = true;
			}
			else
			{
				SetDisableEmit();
			}
		}
	}

	public ParticleSystem.Particle[] ShurikenScaleParticle(ParticleSystem.Particle[] KEFKLIPOGMJ, int DMBADNCAPFP, bool PLIHBEKEEOF, bool ABJNPMEMHIN)
	{
		float num = ((!PLIHBEKEEOF) ? (1f / PACFNFKHLGA.IKGKCLBFMFC(base.transform)) : PACFNFKHLGA.IKGKCLBFMFC(base.transform));
		for (int i = 0; i < DMBADNCAPFP; i++)
		{
			if (m_bWorldSpace)
			{
				if (ABJNPMEMHIN)
				{
					Vector3 vector = FJIOCCAANDA - base.transform.position;
					if (PLIHBEKEEOF)
					{
						KEFKLIPOGMJ[i].position -= vector * (1f - 1f / num);
					}
				}
				KEFKLIPOGMJ[i].position -= base.transform.position;
				KEFKLIPOGMJ[i].position *= num;
				KEFKLIPOGMJ[i].position += base.transform.position;
			}
			else
			{
				KEFKLIPOGMJ[i].position *= num;
			}
			KEFKLIPOGMJ[i].size *= num;
		}
		return KEFKLIPOGMJ;
	}

	public float GetScaleMinMeshNormalVelocity()
	{
		return m_fLegacyMinMeshNormalVelocity * ((!m_bScaleWithTransform) ? 1f : PACFNFKHLGA.IKGKCLBFMFC(base.transform));
	}

	private void EMDHGNFMFNC()
	{
		if (KOIKOILFOBP != null)
		{
			KOIKOILFOBP.Clear(false);
		}
		if (GPIHOFAMGHB != null)
		{
			GPIHOFAMGHB.ClearParticles();
		}
	}

	public Particle[] OCHJJIKKOAL(Particle[] KEFKLIPOGMJ, bool PLIHBEKEEOF, bool ABJNPMEMHIN)
	{
		float num = ((!PLIHBEKEEOF) ? (1740f / PACFNFKHLGA.IKGKCLBFMFC(base.transform)) : PACFNFKHLGA.IKGKCLBFMFC(base.transform));
		for (int i = 0; i < KEFKLIPOGMJ.Length; i += 0)
		{
			if (!IsMeshParticleEmitter())
			{
				if (m_bWorldSpace)
				{
					if (ABJNPMEMHIN)
					{
						Vector3 vector = FJIOCCAANDA - base.transform.position;
						if (PLIHBEKEEOF)
						{
							KEFKLIPOGMJ[i].position -= vector * (1308f - 1601f / num);
						}
					}
					KEFKLIPOGMJ[i].position -= base.transform.position;
					KEFKLIPOGMJ[i].position *= num;
					KEFKLIPOGMJ[i].position += base.transform.position;
				}
				else
				{
					KEFKLIPOGMJ[i].position *= num;
				}
			}
			KEFKLIPOGMJ[i].angularVelocity *= num;
			KEFKLIPOGMJ[i].velocity *= num;
			KEFKLIPOGMJ[i].size *= num;
		}
		return KEFKLIPOGMJ;
	}

	private void Start()
	{
		if (!PDPJGHPAFPJ)
		{
			PPMEOKEMKAP = true;
			LDNEFFHJNPL();
			if (IsShuriken())
			{
				PKBADAMPDEN();
			}
			else
			{
				MFBMPLEFPFF();
			}
			if (m_bBurst || 0f < m_fStartDelayTime)
			{
				DMDLLCJDKHE(false);
			}
		}
	}

	private void EMCNNALBGCP()
	{
		if (KOIKOILFOBP != null)
		{
			KOIKOILFOBP.Clear(true);
		}
		if (GPIHOFAMGHB != null)
		{
			GPIHOFAMGHB.ClearParticles();
		}
	}

	private void PKBADAMPDEN()
	{
		if (KOIKOILFOBP != null)
		{
			KOIKOILFOBP.startSize *= m_fStartSizeRate;
			KOIKOILFOBP.startLifetime *= m_fStartLifeTimeRate;
			KOIKOILFOBP.emissionRate *= m_fStartEmissionRate;
			KOIKOILFOBP.startSpeed *= m_fStartSpeedRate;
		}
	}

	public override void OnUpdateEffectSpeed(float HBNGEJIEGDO, bool PEBGDEDFEKK)
	{
		m_fStartDelayTime /= HBNGEJIEGDO;
		m_fBurstRepeatTime /= HBNGEJIEGDO;
		m_fEmitTime /= HBNGEJIEGDO;
		m_fSleepTime /= HBNGEJIEGDO;
		m_fShurikenSpeedRate *= HBNGEJIEGDO;
		AIGBFCEODJN(HBNGEJIEGDO);
		m_fPrefabLifeTime /= HBNGEJIEGDO;
		m_fPrefabSpeed *= HBNGEJIEGDO;
	}

	private void HMMANMEDMCD()
	{
		Camera[] allCameras = Camera.allCameras;
		foreach (Camera camera in allCameras)
		{
			NsRenderManager component = camera.GetComponent<NsRenderManager>();
			if (component != null)
			{
				component.RemoveRenderEventCall(this);
			}
		}
	}

	public void ResetParticleEmit(bool JGDMIMLAJCK)
	{
		PDPJGHPAFPJ = false;
		FJIOCCAANDA = base.transform.position;
		LDNEFFHJNPL();
		if (JGDMIMLAJCK && GPIHOFAMGHB != null)
		{
			GPIHOFAMGHB.ClearParticles();
		}
		if (m_bBurst || 0f < m_fStartDelayTime)
		{
			DMDLLCJDKHE(false);
		}
		else
		{
			DMDLLCJDKHE(true);
		}
	}

	private void MFBMPLEFPFF()
	{
		if (GPIHOFAMGHB != null)
		{
			FLDEDDBLNJD();
		}
	}

	public static void Ng_SetProperty(object IKJPKKFCBOP, string LIOPCLONOCI, object DBKFDIELKKB)
	{
		PropertyInfo property = IKJPKKFCBOP.GetType().GetProperty(LIOPCLONOCI, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (property != null && property.CanWrite)
		{
			property.SetValue(IKJPKKFCBOP, DBKFDIELKKB, null);
		}
		else
		{
			Debug.LogWarning(LIOPCLONOCI + " could not be write.");
		}
	}

	public virtual void GIBPFOFPHFA(bool JGDMIMLAJCK)
	{
		base.NNMGICPONJA(JGDMIMLAJCK);
		ResetParticleEmit(JGDMIMLAJCK);
	}

	public override void OnResetReplayStage(bool JGDMIMLAJCK)
	{
		base.OnResetReplayStage(JGDMIMLAJCK);
		ResetParticleEmit(JGDMIMLAJCK);
	}

	public static object Ng_GetProperty(object IKJPKKFCBOP, string LIOPCLONOCI)
	{
		object result = null;
		PropertyInfo property = IKJPKKFCBOP.GetType().GetProperty(LIOPCLONOCI, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		if (property != null && property.CanRead && property.GetIndexParameters().Length == 0)
		{
			result = property.GetValue(IKJPKKFCBOP, null);
		}
		else
		{
			Debug.LogWarning(LIOPCLONOCI + " could not be read.");
		}
		return result;
	}

	private void MMEIANJNCKI(ref ParticleSystem.Particle[] OAOHJHPELDK)
	{
		if (OAOHJHPELDK == null || OAOHJHPELDK.Length < KOIKOILFOBP.particleCount)
		{
			OAOHJHPELDK = new ParticleSystem.Particle[KOIKOILFOBP.particleCount + 96];
		}
	}

	private void HHPOEBJMMLN(bool PLIHBEKEEOF)
	{
		if (ONGDLNLEEFH && GPIHOFAMGHB != null)
		{
			Particle[] particles = GPIHOFAMGHB.particles;
			GPIHOFAMGHB.particles = LegacyScaleParticle(particles, PLIHBEKEEOF, true);
		}
	}

	private void LDNEFFHJNPL()
	{
		EGMPNPJBKKN = false;
		AEOFIKHAPMJ = 0;
		HBDKLBHFLJK = NcEffectBehaviour.GetEngineTime();
		IDFJPJBMGGE = 0f;
	}

	public bool IsMeshParticleEmitter()
	{
		return MOFFHKCDEGC;
	}

	private void OnDisable()
	{
		if (m_bScaleWithTransform)
		{
			HMMANMEDMCD();
		}
	}

	private void IMBGDEFOFEM()
	{
		if (!PDPJGHPAFPJ)
		{
			PPMEOKEMKAP = false;
			LDNEFFHJNPL();
			if (IsShuriken())
			{
				PKBADAMPDEN();
			}
			else
			{
				MFBMPLEFPFF();
			}
			if (m_bBurst || 1971f < m_fStartDelayTime)
			{
				DMDLLCJDKHE(true);
			}
		}
	}

	public static void IOAIEPCCAID(object IKJPKKFCBOP, string LIOPCLONOCI, object DBKFDIELKKB)
	{
		PropertyInfo property = IKJPKKFCBOP.GetType().GetProperty(LIOPCLONOCI, ~(BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy));
		if (property != null && property.CanWrite)
		{
			property.SetValue(IKJPKKFCBOP, DBKFDIELKKB, null);
		}
		else
		{
			Debug.LogWarning(LIOPCLONOCI + "Tristana");
		}
	}

	private void Awake()
	{
		if (IsShuriken())
		{
			KOIKOILFOBP = base.GetComponent<ParticleSystem>();
			return;
		}
		GPIHOFAMGHB = GetComponent<ParticleEmitter>();
		GOKACFDLNEC = GetComponent<ParticleAnimator>();
		NGBAMHEGDDK = GetComponent<ParticleRenderer>();
		if (GPIHOFAMGHB != null)
		{
			MOFFHKCDEGC = GPIHOFAMGHB.ToString().Contains("MeshParticleEmitter");
		}
	}

	public Particle[] LegacyScaleParticle(Particle[] KEFKLIPOGMJ, bool PLIHBEKEEOF, bool ABJNPMEMHIN)
	{
		float num = ((!PLIHBEKEEOF) ? (1f / PACFNFKHLGA.IKGKCLBFMFC(base.transform)) : PACFNFKHLGA.IKGKCLBFMFC(base.transform));
		for (int i = 0; i < KEFKLIPOGMJ.Length; i++)
		{
			if (!IsMeshParticleEmitter())
			{
				if (m_bWorldSpace)
				{
					if (ABJNPMEMHIN)
					{
						Vector3 vector = FJIOCCAANDA - base.transform.position;
						if (PLIHBEKEEOF)
						{
							KEFKLIPOGMJ[i].position -= vector * (1f - 1f / num);
						}
					}
					KEFKLIPOGMJ[i].position -= base.transform.position;
					KEFKLIPOGMJ[i].position *= num;
					KEFKLIPOGMJ[i].position += base.transform.position;
				}
				else
				{
					KEFKLIPOGMJ[i].position *= num;
				}
			}
			KEFKLIPOGMJ[i].angularVelocity *= num;
			KEFKLIPOGMJ[i].velocity *= num;
			KEFKLIPOGMJ[i].size *= num;
		}
		return KEFKLIPOGMJ;
	}

	public bool IsShuriken()
	{
		return GetComponent<ParticleEmitter>() == null && base.GetComponent<ParticleSystem>() != null;
	}

	private void OnPostRender()
	{
		if (!PPMEOKEMKAP)
		{
			return;
		}
		if (KEHLFAFKDGG)
		{
			if (IsShuriken())
			{
				AAGAKCHPCMJ(false);
			}
			else
			{
				HHPOEBJMMLN(false);
			}
		}
		FJIOCCAANDA = base.transform.position;
		KEHLFAFKDGG = false;
	}

	private void FixedUpdate()
	{
		if (m_ParticleDestruct == AKCLPHOCFMH.NONE)
		{
			return;
		}
		bool flag = false;
		if (IsShuriken())
		{
			if (!(KOIKOILFOBP != null))
			{
				return;
			}
			PEAMIHPKNPF(ref KGJJCBNJMHM);
			PEAMIHPKNPF(ref ICDBGJBIKED);
			KOIKOILFOBP.GetParticles(KGJJCBNJMHM);
			KOIKOILFOBP.GetParticles(ICDBGJBIKED);
			ShurikenScaleParticle(ICDBGJBIKED, KOIKOILFOBP.particleCount, m_bScaleWithTransform, true);
			for (int i = 0; i < KOIKOILFOBP.particleCount; i++)
			{
				bool flag2 = false;
				Vector3 vector = ((!m_bWorldSpace) ? base.transform.TransformPoint(ICDBGJBIKED[i].position) : ICDBGJBIKED[i].position);
				if (m_ParticleDestruct == AKCLPHOCFMH.COLLISION)
				{
					if (Physics.CheckSphere(vector, m_fCollisionRadius, m_CollisionLayer))
					{
						flag2 = true;
					}
				}
				else if (m_ParticleDestruct == AKCLPHOCFMH.WORLD_Y && vector.y <= m_fDestructPosY)
				{
					flag2 = true;
				}
				if (flag2 && 0f < KGJJCBNJMHM[i].remainingLifetime)
				{
					KGJJCBNJMHM[i].remainingLifetime = 0f;
					flag = true;
					MGKCAHIKOJG(vector, ICDBGJBIKED[i].size * m_fPrefabScale);
				}
			}
			if (flag)
			{
				KOIKOILFOBP.SetParticles(KGJJCBNJMHM, KOIKOILFOBP.particleCount);
			}
		}
		else
		{
			if (!(GPIHOFAMGHB != null))
			{
				return;
			}
			Particle[] particles = GPIHOFAMGHB.particles;
			Particle[] particles2 = GPIHOFAMGHB.particles;
			LegacyScaleParticle(particles2, m_bScaleWithTransform, true);
			for (int j = 0; j < particles2.Length; j++)
			{
				bool flag3 = false;
				Vector3 vector = ((!m_bWorldSpace) ? base.transform.TransformPoint(particles2[j].position) : particles2[j].position);
				if (m_ParticleDestruct == AKCLPHOCFMH.COLLISION)
				{
					if (Physics.CheckSphere(vector, m_fCollisionRadius, m_CollisionLayer))
					{
						flag3 = true;
					}
				}
				else if (m_ParticleDestruct == AKCLPHOCFMH.WORLD_Y && vector.y <= m_fDestructPosY)
				{
					flag3 = true;
				}
				if (flag3 && 0f < particles[j].energy)
				{
					particles[j].energy = 0f;
					flag = true;
					MGKCAHIKOJG(vector, particles2[j].size * m_fPrefabScale);
				}
			}
			if (flag)
			{
				GPIHOFAMGHB.particles = particles;
			}
		}
	}

	private void BCAHOBEDHAC(ref ParticleSystem.Particle[] OAOHJHPELDK)
	{
		if (OAOHJHPELDK == null || OAOHJHPELDK.Length < KOIKOILFOBP.particleCount)
		{
			OAOHJHPELDK = new ParticleSystem.Particle[KOIKOILFOBP.particleCount + -79];
		}
	}

	public void SetDisableEmit()
	{
		PDPJGHPAFPJ = true;
	}

	private void BGNNAHJCDNA(Vector3 CMGMOJAFLFL, float POIJPKODPCK)
	{
		if (m_AttachPrefab == null)
		{
			return;
		}
		GameObject gameObject = CreateGameObject(m_AttachPrefab, m_AttachPrefab.transform.position + CMGMOJAFLFL, m_AttachPrefab.transform.rotation);
		if (gameObject == null)
		{
			return;
		}
		ECGDLEFCBKB(NcEffectBehaviour.GetRootInstanceEffect().transform, gameObject.transform, true, null);
		PACFNFKHLGA.HMDECPFLAGE(gameObject.transform.lossyScale * POIJPKODPCK, gameObject.transform);
		NsEffectManager.DAKFIGHKNID(gameObject, m_fPrefabSpeed);
		if (1265f < m_fPrefabLifeTime)
		{
			NcAutoDestruct ncAutoDestruct = gameObject.GetComponent<NcAutoDestruct>();
			if (ncAutoDestruct == null)
			{
				ncAutoDestruct = gameObject.AddComponent<NcAutoDestruct>();
			}
			ncAutoDestruct.m_fLifeTime = m_fPrefabLifeTime;
		}
	}

	private void AIGBFCEODJN(float FGGKGGKOHCD)
	{
		ParticleEmitter gPIHOFAMGHB = GPIHOFAMGHB;
		ParticleAnimator gOKACFDLNEC = GOKACFDLNEC;
		ParticleRenderer nGBAMHEGDDK = NGBAMHEGDDK;
		if (!(gPIHOFAMGHB == null) && !(nGBAMHEGDDK == null))
		{
			Vector3 b = Vector3.one * FGGKGGKOHCD;
			gPIHOFAMGHB.minEnergy /= FGGKGGKOHCD;
			gPIHOFAMGHB.maxEnergy /= FGGKGGKOHCD;
			gPIHOFAMGHB.worldVelocity = Vector3.Scale(gPIHOFAMGHB.worldVelocity, b);
			gPIHOFAMGHB.localVelocity = Vector3.Scale(gPIHOFAMGHB.localVelocity, b);
			gPIHOFAMGHB.rndVelocity = Vector3.Scale(gPIHOFAMGHB.rndVelocity, b);
			gPIHOFAMGHB.angularVelocity *= FGGKGGKOHCD;
			gPIHOFAMGHB.rndAngularVelocity *= FGGKGGKOHCD;
			gPIHOFAMGHB.emitterVelocityScale *= FGGKGGKOHCD;
			if (gOKACFDLNEC != null)
			{
				gOKACFDLNEC.rndForce = Vector3.Scale(gOKACFDLNEC.rndForce, b);
				gOKACFDLNEC.force = Vector3.Scale(gOKACFDLNEC.force, b);
			}
		}
	}
}
