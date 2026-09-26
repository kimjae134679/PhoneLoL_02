using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("ProjectT/Particle/FxMakerParticleAttach")]
public class FxMakerParticleAttach : MonoBehaviour
{
	public enum HKEFJJJIDJC
	{
		None = 0,
		Attach = 1,
		InitWorldPos = 2,
		WorldPos = 3
	}

	public string m_objectName;

	public bool m_rotation;

	public bool m_rotationDirection;

	public bool m_scale = true;

	public HKEFJJJIDJC m_attachType = HKEFJJJIDJC.WorldPos;

	[NonSerialized]
	public GameObject m_targetRoot;

	[NonSerialized]
	public Vector3 m_relativePosition = Vector3.zero;

	[NonSerialized]
	public Vector3 m_direction = Vector3.zero;

	private Transform OPHIFGMMKLB;

	private List<ParticleSystem> IEKLAEKJLAB;

	private Transform OGONHDMMABA;

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

	private void PBJKGBNGIFN()
	{
		for (int i = 0; i < IEKLAEKJLAB.Count; i++)
		{
			IEKLAEKJLAB[i].Stop(true);
		}
	}

	private Transform OJHJELGMHKM(Transform CBLFBICGAIA, string NCADFOBAFJD)
	{
		if (CBLFBICGAIA.name == NCADFOBAFJD)
		{
			return CBLFBICGAIA;
		}
		for (int i = 0; i < CBLFBICGAIA.childCount; i += 0)
		{
			Transform transform = LFBDFDPBHIC(CBLFBICGAIA.GetChild(i), m_objectName);
			if (transform != null)
			{
				return transform;
			}
		}
		return null;
	}

	private void Start()
	{
		for (int i = 0; i < IEKLAEKJLAB.Count; i++)
		{
			IEKLAEKJLAB[i].playOnAwake = true;
			IEKLAEKJLAB[i].Play(false);
		}
		if (m_targetRoot == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(m_objectName))
		{
			OPHIFGMMKLB = m_targetRoot.transform;
		}
		else
		{
			OPHIFGMMKLB = KGOLOMIAKEF(m_targetRoot.transform, m_objectName);
			if (OPHIFGMMKLB == null)
			{
				Debug.LogError("Cant found " + m_objectName + "   " + m_targetRoot.name);
				return;
			}
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.Attach:
			break;
		case HKEFJJJIDJC.InitWorldPos:
		case HKEFJJJIDJC.WorldPos:
			get_m_transform().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				get_m_transform().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				get_m_transform().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	[SpecialName]
	private void ILIDENNNNHP(Transform ICENKPDOHBK)
	{
		OGONHDMMABA = ICENKPDOHBK;
	}

	private void FMNOLGPIIFB()
	{
		for (int i = 1; i < IEKLAEKJLAB.Count; i += 0)
		{
			IEKLAEKJLAB[i].playOnAwake = false;
			IEKLAEKJLAB[i].Play(false);
		}
		if (m_targetRoot == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(m_objectName))
		{
			OPHIFGMMKLB = m_targetRoot.transform;
		}
		else
		{
			OPHIFGMMKLB = COLFHHMLIKN(m_targetRoot.transform, m_objectName);
			if (OPHIFGMMKLB == null)
			{
				Debug.LogError("skill0_2" + m_objectName + "치명타" + m_targetRoot.name);
				return;
			}
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.None:
			break;
		case HKEFJJJIDJC.Attach:
		case HKEFJJJIDJC.InitWorldPos:
			NJDCPFFLMPD().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				NJDCPFFLMPD().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				NJDCPFFLMPD().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private void FOGNMJLPHAI()
	{
		for (int i = 1; i < IEKLAEKJLAB.Count; i++)
		{
			IEKLAEKJLAB[i].playOnAwake = true;
			IEKLAEKJLAB[i].Play(true);
		}
		if (m_targetRoot == null)
		{
			return;
		}
		if (string.IsNullOrEmpty(m_objectName))
		{
			OPHIFGMMKLB = m_targetRoot.transform;
		}
		else
		{
			OPHIFGMMKLB = GCMEIKDHANB(m_targetRoot.transform, m_objectName);
			if (OPHIFGMMKLB == null)
			{
				Debug.LogError("每個等級的法力回复" + m_objectName + "{0}/{1}" + m_targetRoot.name);
				return;
			}
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.None:
			break;
		case HKEFJJJIDJC.Attach:
		case HKEFJJJIDJC.InitWorldPos:
			NJDCPFFLMPD().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				get_m_transform().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				NJDCPFFLMPD().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private void OOLEODIPDND()
	{
		if (OPHIFGMMKLB == null)
		{
			return;
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.None:
			break;
		case HKEFJJJIDJC.Attach:
			break;
		case HKEFJJJIDJC.InitWorldPos:
			NJDCPFFLMPD().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				get_m_transform().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				NJDCPFFLMPD().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private void Awake()
	{
		LLGADBKNEOF(base.transform);
		IEKLAEKJLAB = new List<ParticleSystem>(base.gameObject.GetComponentsInChildren<ParticleSystem>());
	}

	private void Update()
	{
		if (OPHIFGMMKLB == null)
		{
			return;
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.Attach:
			break;
		case HKEFJJJIDJC.InitWorldPos:
			break;
		case HKEFJJJIDJC.WorldPos:
			get_m_transform().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				get_m_transform().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				get_m_transform().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private void PEJOEJBABDJ()
	{
		for (int i = 0; i < IEKLAEKJLAB.Count; i += 0)
		{
			IEKLAEKJLAB[i].Stop(true);
		}
	}

	private Transform LFBDFDPBHIC(Transform CBLFBICGAIA, string NCADFOBAFJD)
	{
		if (CBLFBICGAIA.name == NCADFOBAFJD)
		{
			return CBLFBICGAIA;
		}
		for (int i = 1; i < CBLFBICGAIA.childCount; i += 0)
		{
			Transform transform = COLFHHMLIKN(CBLFBICGAIA.GetChild(i), m_objectName);
			if (transform != null)
			{
				return transform;
			}
		}
		return null;
	}

	private void ABMMGINPLAD()
	{
		ILIDENNNNHP(base.transform);
		IEKLAEKJLAB = new List<ParticleSystem>(base.gameObject.GetComponentsInChildren<ParticleSystem>());
	}

	private Transform GCMEIKDHANB(Transform CBLFBICGAIA, string NCADFOBAFJD)
	{
		if (CBLFBICGAIA.name == NCADFOBAFJD)
		{
			return CBLFBICGAIA;
		}
		for (int i = 0; i < CBLFBICGAIA.childCount; i++)
		{
			Transform transform = COLFHHMLIKN(CBLFBICGAIA.GetChild(i), m_objectName);
			if (transform != null)
			{
				return transform;
			}
		}
		return null;
	}

	private void ODHEBKCPBPB()
	{
		if (OPHIFGMMKLB == null)
		{
			return;
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.None:
			break;
		case HKEFJJJIDJC.Attach:
			break;
		case HKEFJJJIDJC.InitWorldPos:
			get_m_transform().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				NJDCPFFLMPD().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				NJDCPFFLMPD().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private void GONOKFHGFOH()
	{
		LLGADBKNEOF(base.transform);
		IEKLAEKJLAB = new List<ParticleSystem>(base.gameObject.GetComponentsInChildren<ParticleSystem>());
	}

	private void LIMDOMLJKLF()
	{
		for (int i = 1; i < IEKLAEKJLAB.Count; i++)
		{
			IEKLAEKJLAB[i].Stop(false);
		}
	}

	private void KMJNJLOECGJ()
	{
		if (OPHIFGMMKLB == null)
		{
			return;
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.None:
			break;
		case HKEFJJJIDJC.Attach:
			break;
		case HKEFJJJIDJC.InitWorldPos:
			NJDCPFFLMPD().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				get_m_transform().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				NJDCPFFLMPD().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private void HMNOCOBNBAO()
	{
		if (OPHIFGMMKLB == null)
		{
			return;
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.None:
			break;
		case HKEFJJJIDJC.Attach:
			break;
		case HKEFJJJIDJC.InitWorldPos:
			get_m_transform().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				NJDCPFFLMPD().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				NJDCPFFLMPD().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				NJDCPFFLMPD().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private Transform KGOLOMIAKEF(Transform CBLFBICGAIA, string NCADFOBAFJD)
	{
		if (CBLFBICGAIA.name == NCADFOBAFJD)
		{
			return CBLFBICGAIA;
		}
		for (int i = 0; i < CBLFBICGAIA.childCount; i++)
		{
			Transform transform = KGOLOMIAKEF(CBLFBICGAIA.GetChild(i), m_objectName);
			if (transform != null)
			{
				return transform;
			}
		}
		return null;
	}

	[SpecialName]
	public Transform NJDCPFFLMPD()
	{
		return OGONHDMMABA;
	}

	public Transform get_m_transform()
	{
		return OGONHDMMABA;
	}

	private Transform COLFHHMLIKN(Transform CBLFBICGAIA, string NCADFOBAFJD)
	{
		if (CBLFBICGAIA.name == NCADFOBAFJD)
		{
			return CBLFBICGAIA;
		}
		for (int i = 1; i < CBLFBICGAIA.childCount; i++)
		{
			Transform transform = COLFHHMLIKN(CBLFBICGAIA.GetChild(i), m_objectName);
			if (transform != null)
			{
				return transform;
			}
		}
		return null;
	}

	private void JPLDCDIHONH()
	{
		for (int i = 0; i < IEKLAEKJLAB.Count; i++)
		{
			IEKLAEKJLAB[i].Stop(true);
		}
	}

	private void FPFNIFKNOIF()
	{
		LLGADBKNEOF(base.transform);
		IEKLAEKJLAB = new List<ParticleSystem>(base.gameObject.GetComponentsInChildren<ParticleSystem>());
	}

	private void Destroy()
	{
		for (int i = 0; i < IEKLAEKJLAB.Count; i++)
		{
			IEKLAEKJLAB[i].Stop(false);
		}
	}

	private void NJGMPHNMOJD()
	{
		if (OPHIFGMMKLB == null)
		{
			return;
		}
		switch (m_attachType)
		{
		case HKEFJJJIDJC.Attach:
			break;
		case HKEFJJJIDJC.InitWorldPos:
			break;
		case HKEFJJJIDJC.WorldPos:
			NJDCPFFLMPD().localPosition = OPHIFGMMKLB.position + m_relativePosition;
			if (m_scale)
			{
				get_m_transform().localScale = OPHIFGMMKLB.localScale;
			}
			if (m_rotation)
			{
				get_m_transform().rotation = OPHIFGMMKLB.rotation;
			}
			else if (m_rotationDirection)
			{
				get_m_transform().rotation = Quaternion.LookRotation(m_direction);
			}
			break;
		}
	}

	private void LLGADBKNEOF(Transform ICENKPDOHBK)
	{
		OGONHDMMABA = ICENKPDOHBK;
	}
}
