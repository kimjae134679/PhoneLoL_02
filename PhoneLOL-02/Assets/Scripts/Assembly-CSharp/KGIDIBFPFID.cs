using System;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

public static class KGIDIBFPFID
{
	public static void DDKAKJOOONJ(Vector3 CMGMOJAFLFL, Color BEAKIPPBGAF, float JOICFLEPABK = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		BEAKIPPBGAF = ((!(BEAKIPPBGAF == default(Color))) ? BEAKIPPBGAF : Color.white);
		Debug.DrawRay(CMGMOJAFLFL + Vector3.up * (JOICFLEPABK * 0.5f), -Vector3.up * JOICFLEPABK, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawRay(CMGMOJAFLFL + Vector3.right * (JOICFLEPABK * 0.5f), -Vector3.right * JOICFLEPABK, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawRay(CMGMOJAFLFL + Vector3.forward * (JOICFLEPABK * 0.5f), -Vector3.forward * JOICFLEPABK, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void DDKAKJOOONJ(Vector3 CMGMOJAFLFL, float JOICFLEPABK = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		DDKAKJOOONJ(CMGMOJAFLFL, Color.white, JOICFLEPABK, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void EPNBFPANOJF(Bounds GHIJKEOIMEA, Color BEAKIPPBGAF, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		Vector3 center = GHIJKEOIMEA.center;
		float x = GHIJKEOIMEA.extents.x;
		float y = GHIJKEOIMEA.extents.y;
		float z = GHIJKEOIMEA.extents.z;
		Vector3 start = center + new Vector3(x, y, z);
		Vector3 vector = center + new Vector3(x, y, 0f - z);
		Vector3 vector2 = center + new Vector3(0f - x, y, z);
		Vector3 vector3 = center + new Vector3(0f - x, y, 0f - z);
		Vector3 vector4 = center + new Vector3(x, 0f - y, z);
		Vector3 end = center + new Vector3(x, 0f - y, 0f - z);
		Vector3 vector5 = center + new Vector3(0f - x, 0f - y, z);
		Vector3 vector6 = center + new Vector3(0f - x, 0f - y, 0f - z);
		Debug.DrawLine(start, vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(start, vector, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector2, vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector, vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(start, vector4, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector, end, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector2, vector5, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector3, vector6, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector4, vector5, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector4, end, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector5, vector6, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector6, end, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void EPNBFPANOJF(Bounds GHIJKEOIMEA, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		EPNBFPANOJF(GHIJKEOIMEA, Color.white, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void MMOALGMIKBJ(Transform LMDGNFKCKAN, Vector3 POIJPKODPCK, Color BEAKIPPBGAF, [Optional] Vector3 BLLOFLFALFM, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		Vector3 vector = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + -POIJPKODPCK * 0.5f);
		Vector3 vector2 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector3 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector4 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector5 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector6 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector7 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + POIJPKODPCK * 0.5f);
		Vector3 vector8 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Debug.DrawLine(vector, vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector2, vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector3, vector4, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector4, vector, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector5, vector6, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector6, vector7, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector7, vector8, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector8, vector5, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector, vector5, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector2, vector6, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector3, vector7, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector4, vector8, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void MMOALGMIKBJ(Transform LMDGNFKCKAN, Vector3 POIJPKODPCK, [Optional] Vector3 BLLOFLFALFM, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		MMOALGMIKBJ(LMDGNFKCKAN, POIJPKODPCK, Color.white, BLLOFLFALFM, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void MMOALGMIKBJ(Matrix4x4 HKEFGLFGJNJ, Vector3 POIJPKODPCK, Color BEAKIPPBGAF, [Optional] Vector3 BLLOFLFALFM, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		BEAKIPPBGAF = ((!(BEAKIPPBGAF == default(Color))) ? BEAKIPPBGAF : Color.white);
		Vector3 vector = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + -POIJPKODPCK * 0.5f);
		Vector3 vector2 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector3 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector4 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector5 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector6 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector7 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + POIJPKODPCK * 0.5f);
		Vector3 vector8 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Debug.DrawLine(vector, vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector2, vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector3, vector4, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector4, vector, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector5, vector6, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector6, vector7, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector7, vector8, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector8, vector5, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector, vector5, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector2, vector6, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector3, vector7, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(vector4, vector8, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void MMOALGMIKBJ(Matrix4x4 HKEFGLFGJNJ, Vector3 POIJPKODPCK, [Optional] Vector3 BLLOFLFALFM, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		MMOALGMIKBJ(HKEFGLFGJNJ, POIJPKODPCK, Color.white, BLLOFLFALFM, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void PBKNGECCKPO(Vector3 CMGMOJAFLFL, Vector3 GAFFLHNJKBF, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		Vector3 vector = GAFFLHNJKBF.normalized * FIMDBMJIEON;
		Vector3 rhs = Vector3.Slerp(vector, -vector, 0.5f);
		Vector3 vector2 = Vector3.Cross(vector, rhs).normalized * FIMDBMJIEON;
		Matrix4x4 matrix4x = default(Matrix4x4);
		matrix4x[0] = vector2.x;
		matrix4x[1] = vector2.y;
		matrix4x[2] = vector2.z;
		matrix4x[4] = vector.x;
		matrix4x[5] = vector.y;
		matrix4x[6] = vector.z;
		matrix4x[8] = rhs.x;
		matrix4x[9] = rhs.y;
		matrix4x[10] = rhs.z;
		Vector3 start = CMGMOJAFLFL + matrix4x.MultiplyPoint3x4(new Vector3(Mathf.Cos(0f), 0f, Mathf.Sin(0f)));
		Vector3 vector3 = Vector3.zero;
		BEAKIPPBGAF = ((!(BEAKIPPBGAF == default(Color))) ? BEAKIPPBGAF : Color.white);
		for (int i = 0; i < 91; i++)
		{
			vector3.x = Mathf.Cos((float)(i * 4) * ((float)Math.PI / 180f));
			vector3.z = Mathf.Sin((float)(i * 4) * ((float)Math.PI / 180f));
			vector3.y = 0f;
			vector3 = CMGMOJAFLFL + matrix4x.MultiplyPoint3x4(vector3);
			Debug.DrawLine(start, vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			start = vector3;
		}
	}

	public static void PBKNGECCKPO(Vector3 CMGMOJAFLFL, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		PBKNGECCKPO(CMGMOJAFLFL, Vector3.up, BEAKIPPBGAF, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void PBKNGECCKPO(Vector3 CMGMOJAFLFL, Vector3 GAFFLHNJKBF, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		PBKNGECCKPO(CMGMOJAFLFL, GAFFLHNJKBF, Color.white, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void PBKNGECCKPO(Vector3 CMGMOJAFLFL, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		PBKNGECCKPO(CMGMOJAFLFL, Vector3.up, Color.white, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void OPADOFHCODP(Vector3 CMGMOJAFLFL, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		float num = 10f;
		Vector3 start = new Vector3(CMGMOJAFLFL.x, CMGMOJAFLFL.y + FIMDBMJIEON * Mathf.Sin(0f), CMGMOJAFLFL.z + FIMDBMJIEON * Mathf.Cos(0f));
		Vector3 start2 = new Vector3(CMGMOJAFLFL.x + FIMDBMJIEON * Mathf.Cos(0f), CMGMOJAFLFL.y, CMGMOJAFLFL.z + FIMDBMJIEON * Mathf.Sin(0f));
		Vector3 start3 = new Vector3(CMGMOJAFLFL.x + FIMDBMJIEON * Mathf.Cos(0f), CMGMOJAFLFL.y + FIMDBMJIEON * Mathf.Sin(0f), CMGMOJAFLFL.z);
		for (int i = 1; i < 37; i++)
		{
			Vector3 vector = new Vector3(CMGMOJAFLFL.x, CMGMOJAFLFL.y + FIMDBMJIEON * Mathf.Sin(num * (float)i * ((float)Math.PI / 180f)), CMGMOJAFLFL.z + FIMDBMJIEON * Mathf.Cos(num * (float)i * ((float)Math.PI / 180f)));
			Vector3 vector2 = new Vector3(CMGMOJAFLFL.x + FIMDBMJIEON * Mathf.Cos(num * (float)i * ((float)Math.PI / 180f)), CMGMOJAFLFL.y, CMGMOJAFLFL.z + FIMDBMJIEON * Mathf.Sin(num * (float)i * ((float)Math.PI / 180f)));
			Vector3 vector3 = new Vector3(CMGMOJAFLFL.x + FIMDBMJIEON * Mathf.Cos(num * (float)i * ((float)Math.PI / 180f)), CMGMOJAFLFL.y + FIMDBMJIEON * Mathf.Sin(num * (float)i * ((float)Math.PI / 180f)), CMGMOJAFLFL.z);
			Debug.DrawLine(start, vector, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(start2, vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(start3, vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			start = vector;
			start2 = vector2;
			start3 = vector3;
		}
	}

	public static void OPADOFHCODP(Vector3 CMGMOJAFLFL, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		OPADOFHCODP(CMGMOJAFLFL, Color.white, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void HAHKEFODDKB(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		Vector3 vector = (IDFCFEOMBKP - GAKOOBECLIB).normalized * FIMDBMJIEON;
		Vector3 vector2 = Vector3.Slerp(vector, -vector, 0.5f);
		Vector3 vector3 = Vector3.Cross(vector, vector2).normalized * FIMDBMJIEON;
		PBKNGECCKPO(GAKOOBECLIB, vector, BEAKIPPBGAF, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
		PBKNGECCKPO(IDFCFEOMBKP, -vector, BEAKIPPBGAF, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
		PBKNGECCKPO((GAKOOBECLIB + IDFCFEOMBKP) * 0.5f, vector, BEAKIPPBGAF, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB + vector3, IDFCFEOMBKP + vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB - vector3, IDFCFEOMBKP - vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB + vector2, IDFCFEOMBKP + vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB - vector2, IDFCFEOMBKP - vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB - vector3, GAKOOBECLIB + vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB - vector2, GAKOOBECLIB + vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(IDFCFEOMBKP - vector3, IDFCFEOMBKP + vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(IDFCFEOMBKP - vector2, IDFCFEOMBKP + vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void HAHKEFODDKB(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		HAHKEFODDKB(GAKOOBECLIB, IDFCFEOMBKP, Color.white, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void IOCIPEONMDM(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC, Color BEAKIPPBGAF, float IINELJPKNBN = 45f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		float magnitude = IJMNFOGNFAC.magnitude;
		Vector3 vector = IJMNFOGNFAC;
		Vector3 vector2 = Vector3.Slerp(vector, -vector, 0.5f);
		Vector3 vector3 = Vector3.Cross(vector, vector2).normalized * magnitude;
		IJMNFOGNFAC = IJMNFOGNFAC.normalized;
		Vector3 direction = Vector3.Slerp(vector, vector2, IINELJPKNBN / 90f);
		Plane plane = new Plane(-IJMNFOGNFAC, CMGMOJAFLFL + vector);
		Ray ray = new Ray(CMGMOJAFLFL, direction);
		float enter;
		plane.Raycast(ray, out enter);
		Debug.DrawRay(CMGMOJAFLFL, direction.normalized * enter, BEAKIPPBGAF);
		Debug.DrawRay(CMGMOJAFLFL, Vector3.Slerp(vector, -vector2, IINELJPKNBN / 90f).normalized * enter, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawRay(CMGMOJAFLFL, Vector3.Slerp(vector, vector3, IINELJPKNBN / 90f).normalized * enter, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawRay(CMGMOJAFLFL, Vector3.Slerp(vector, -vector3, IINELJPKNBN / 90f).normalized * enter, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		PBKNGECCKPO(CMGMOJAFLFL + vector, IJMNFOGNFAC, BEAKIPPBGAF, (vector - direction.normalized * enter).magnitude, FICMMBLHCBF, OFDKMOKCNEG);
		PBKNGECCKPO(CMGMOJAFLFL + vector * 0.5f, IJMNFOGNFAC, BEAKIPPBGAF, (vector * 0.5f - direction.normalized * (enter * 0.5f)).magnitude, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void IOCIPEONMDM(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC, float IINELJPKNBN = 45f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		IOCIPEONMDM(CMGMOJAFLFL, IJMNFOGNFAC, Color.white, IINELJPKNBN, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void IOCIPEONMDM(Vector3 CMGMOJAFLFL, Color BEAKIPPBGAF, float IINELJPKNBN = 45f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		IOCIPEONMDM(CMGMOJAFLFL, Vector3.up, BEAKIPPBGAF, IINELJPKNBN, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void IOCIPEONMDM(Vector3 CMGMOJAFLFL, float IINELJPKNBN = 45f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		IOCIPEONMDM(CMGMOJAFLFL, Vector3.up, Color.white, IINELJPKNBN, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void NGHDANJNLAL(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC, Color BEAKIPPBGAF, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		Debug.DrawRay(CMGMOJAFLFL, IJMNFOGNFAC, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		IOCIPEONMDM(CMGMOJAFLFL + IJMNFOGNFAC, -IJMNFOGNFAC * 0.333f, BEAKIPPBGAF, 15f, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void NGHDANJNLAL(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		NGHDANJNLAL(CMGMOJAFLFL, IJMNFOGNFAC, Color.white, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void DGKMFNPFCNF(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		Vector3 vector = (IDFCFEOMBKP - GAKOOBECLIB).normalized * FIMDBMJIEON;
		Vector3 vector2 = Vector3.Slerp(vector, -vector, 0.5f);
		Vector3 vector3 = Vector3.Cross(vector, vector2).normalized * FIMDBMJIEON;
		float magnitude = (GAKOOBECLIB - IDFCFEOMBKP).magnitude;
		float num = Mathf.Max(0f, magnitude * 0.5f - FIMDBMJIEON);
		Vector3 vector4 = (IDFCFEOMBKP + GAKOOBECLIB) * 0.5f;
		GAKOOBECLIB = vector4 + (GAKOOBECLIB - vector4).normalized * num;
		IDFCFEOMBKP = vector4 + (IDFCFEOMBKP - vector4).normalized * num;
		PBKNGECCKPO(GAKOOBECLIB, vector, BEAKIPPBGAF, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
		PBKNGECCKPO(IDFCFEOMBKP, -vector, BEAKIPPBGAF, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB + vector3, IDFCFEOMBKP + vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB - vector3, IDFCFEOMBKP - vector3, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB + vector2, IDFCFEOMBKP + vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		Debug.DrawLine(GAKOOBECLIB - vector2, IDFCFEOMBKP - vector2, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		for (int i = 1; i < 26; i++)
		{
			Debug.DrawLine(Vector3.Slerp(vector3, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(vector3, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(Vector3.Slerp(-vector3, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(-vector3, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(Vector3.Slerp(vector2, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(vector2, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(Vector3.Slerp(-vector2, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(-vector2, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(Vector3.Slerp(vector3, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(vector3, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(Vector3.Slerp(-vector3, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(-vector3, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(Vector3.Slerp(vector2, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(vector2, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
			Debug.DrawLine(Vector3.Slerp(-vector2, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(-vector2, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP, BEAKIPPBGAF, FICMMBLHCBF, OFDKMOKCNEG);
		}
	}

	public static void DGKMFNPFCNF(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, float FIMDBMJIEON = 1f, float FICMMBLHCBF = 0f, bool OFDKMOKCNEG = true)
	{
		DGKMFNPFCNF(GAKOOBECLIB, IDFCFEOMBKP, Color.white, FIMDBMJIEON, FICMMBLHCBF, OFDKMOKCNEG);
	}

	public static void LBLNPKHPODL(Vector3 CMGMOJAFLFL, Color BEAKIPPBGAF, float JOICFLEPABK = 1f)
	{
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		Gizmos.DrawRay(CMGMOJAFLFL + Vector3.up * (JOICFLEPABK * 0.5f), -Vector3.up * JOICFLEPABK);
		Gizmos.DrawRay(CMGMOJAFLFL + Vector3.right * (JOICFLEPABK * 0.5f), -Vector3.right * JOICFLEPABK);
		Gizmos.DrawRay(CMGMOJAFLFL + Vector3.forward * (JOICFLEPABK * 0.5f), -Vector3.forward * JOICFLEPABK);
		Gizmos.color = color;
	}

	public static void LBLNPKHPODL(Vector3 CMGMOJAFLFL, float JOICFLEPABK = 1f)
	{
		LBLNPKHPODL(CMGMOJAFLFL, Color.white, JOICFLEPABK);
	}

	public static void HGPFOJEMPBC(Bounds GHIJKEOIMEA, Color BEAKIPPBGAF)
	{
		Vector3 center = GHIJKEOIMEA.center;
		float x = GHIJKEOIMEA.extents.x;
		float y = GHIJKEOIMEA.extents.y;
		float z = GHIJKEOIMEA.extents.z;
		Vector3 vector = center + new Vector3(x, y, z);
		Vector3 vector2 = center + new Vector3(x, y, 0f - z);
		Vector3 vector3 = center + new Vector3(0f - x, y, z);
		Vector3 vector4 = center + new Vector3(0f - x, y, 0f - z);
		Vector3 vector5 = center + new Vector3(x, 0f - y, z);
		Vector3 to = center + new Vector3(x, 0f - y, 0f - z);
		Vector3 vector6 = center + new Vector3(0f - x, 0f - y, z);
		Vector3 vector7 = center + new Vector3(0f - x, 0f - y, 0f - z);
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		Gizmos.DrawLine(vector, vector3);
		Gizmos.DrawLine(vector, vector2);
		Gizmos.DrawLine(vector3, vector4);
		Gizmos.DrawLine(vector2, vector4);
		Gizmos.DrawLine(vector, vector5);
		Gizmos.DrawLine(vector2, to);
		Gizmos.DrawLine(vector3, vector6);
		Gizmos.DrawLine(vector4, vector7);
		Gizmos.DrawLine(vector5, vector6);
		Gizmos.DrawLine(vector5, to);
		Gizmos.DrawLine(vector6, vector7);
		Gizmos.DrawLine(vector7, to);
		Gizmos.color = color;
	}

	public static void HGPFOJEMPBC(Bounds GHIJKEOIMEA)
	{
		HGPFOJEMPBC(GHIJKEOIMEA, Color.white);
	}

	public static void GFNGEGCIAIO(Transform LMDGNFKCKAN, Vector3 POIJPKODPCK, Color BEAKIPPBGAF, [Optional] Vector3 BLLOFLFALFM)
	{
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		Vector3 vector = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + -POIJPKODPCK * 0.5f);
		Vector3 vector2 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector3 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector4 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector5 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector6 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector7 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + POIJPKODPCK * 0.5f);
		Vector3 vector8 = LMDGNFKCKAN.TransformPoint(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Gizmos.DrawLine(vector, vector2);
		Gizmos.DrawLine(vector2, vector3);
		Gizmos.DrawLine(vector3, vector4);
		Gizmos.DrawLine(vector4, vector);
		Gizmos.DrawLine(vector5, vector6);
		Gizmos.DrawLine(vector6, vector7);
		Gizmos.DrawLine(vector7, vector8);
		Gizmos.DrawLine(vector8, vector5);
		Gizmos.DrawLine(vector, vector5);
		Gizmos.DrawLine(vector2, vector6);
		Gizmos.DrawLine(vector3, vector7);
		Gizmos.DrawLine(vector4, vector8);
		Gizmos.color = color;
	}

	public static void GFNGEGCIAIO(Transform LMDGNFKCKAN, Vector3 POIJPKODPCK, [Optional] Vector3 BLLOFLFALFM)
	{
		GFNGEGCIAIO(LMDGNFKCKAN, POIJPKODPCK, Color.white, BLLOFLFALFM);
	}

	public static void GFNGEGCIAIO(Matrix4x4 HKEFGLFGJNJ, Vector3 POIJPKODPCK, Color BEAKIPPBGAF, [Optional] Vector3 BLLOFLFALFM)
	{
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		Vector3 vector = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + -POIJPKODPCK * 0.5f);
		Vector3 vector2 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector3 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector4 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, 0f - POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Vector3 vector5 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector6 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(POIJPKODPCK.x, POIJPKODPCK.y, 0f - POIJPKODPCK.z) * 0.5f);
		Vector3 vector7 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + POIJPKODPCK * 0.5f);
		Vector3 vector8 = HKEFGLFGJNJ.MultiplyPoint3x4(BLLOFLFALFM + new Vector3(0f - POIJPKODPCK.x, POIJPKODPCK.y, POIJPKODPCK.z) * 0.5f);
		Gizmos.DrawLine(vector, vector2);
		Gizmos.DrawLine(vector2, vector3);
		Gizmos.DrawLine(vector3, vector4);
		Gizmos.DrawLine(vector4, vector);
		Gizmos.DrawLine(vector5, vector6);
		Gizmos.DrawLine(vector6, vector7);
		Gizmos.DrawLine(vector7, vector8);
		Gizmos.DrawLine(vector8, vector5);
		Gizmos.DrawLine(vector, vector5);
		Gizmos.DrawLine(vector2, vector6);
		Gizmos.DrawLine(vector3, vector7);
		Gizmos.DrawLine(vector4, vector8);
		Gizmos.color = color;
	}

	public static void GFNGEGCIAIO(Matrix4x4 HKEFGLFGJNJ, Vector3 POIJPKODPCK, [Optional] Vector3 BLLOFLFALFM)
	{
		GFNGEGCIAIO(HKEFGLFGJNJ, POIJPKODPCK, Color.white, BLLOFLFALFM);
	}

	public static void FHFHAOICIIB(Vector3 CMGMOJAFLFL, Vector3 GAFFLHNJKBF, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f)
	{
		GAFFLHNJKBF = ((!(GAFFLHNJKBF == Vector3.zero)) ? GAFFLHNJKBF : Vector3.up).normalized * FIMDBMJIEON;
		Vector3 rhs = Vector3.Slerp(GAFFLHNJKBF, -GAFFLHNJKBF, 0.5f);
		Vector3 vector = Vector3.Cross(GAFFLHNJKBF, rhs).normalized * FIMDBMJIEON;
		Matrix4x4 matrix4x = default(Matrix4x4);
		matrix4x[0] = vector.x;
		matrix4x[1] = vector.y;
		matrix4x[2] = vector.z;
		matrix4x[4] = GAFFLHNJKBF.x;
		matrix4x[5] = GAFFLHNJKBF.y;
		matrix4x[6] = GAFFLHNJKBF.z;
		matrix4x[8] = rhs.x;
		matrix4x[9] = rhs.y;
		matrix4x[10] = rhs.z;
		Vector3 vector2 = CMGMOJAFLFL + matrix4x.MultiplyPoint3x4(new Vector3(Mathf.Cos(0f), 0f, Mathf.Sin(0f)));
		Vector3 vector3 = Vector3.zero;
		Color color = Gizmos.color;
		Gizmos.color = ((!(BEAKIPPBGAF == default(Color))) ? BEAKIPPBGAF : Color.white);
		for (int i = 0; i < 91; i++)
		{
			vector3.x = Mathf.Cos((float)(i * 4) * ((float)Math.PI / 180f));
			vector3.z = Mathf.Sin((float)(i * 4) * ((float)Math.PI / 180f));
			vector3.y = 0f;
			vector3 = CMGMOJAFLFL + matrix4x.MultiplyPoint3x4(vector3);
			Gizmos.DrawLine(vector2, vector3);
			vector2 = vector3;
		}
		Gizmos.color = color;
	}

	public static void FHFHAOICIIB(Vector3 CMGMOJAFLFL, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f)
	{
		FHFHAOICIIB(CMGMOJAFLFL, Vector3.up, BEAKIPPBGAF, FIMDBMJIEON);
	}

	public static void FHFHAOICIIB(Vector3 CMGMOJAFLFL, Vector3 GAFFLHNJKBF, float FIMDBMJIEON = 1f)
	{
		FHFHAOICIIB(CMGMOJAFLFL, CMGMOJAFLFL, Color.white, FIMDBMJIEON);
	}

	public static void FHFHAOICIIB(Vector3 CMGMOJAFLFL, float FIMDBMJIEON = 1f)
	{
		FHFHAOICIIB(CMGMOJAFLFL, Vector3.up, Color.white, FIMDBMJIEON);
	}

	public static void ACOPCJJAFGK(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f)
	{
		Vector3 vector = (IDFCFEOMBKP - GAKOOBECLIB).normalized * FIMDBMJIEON;
		Vector3 vector2 = Vector3.Slerp(vector, -vector, 0.5f);
		Vector3 vector3 = Vector3.Cross(vector, vector2).normalized * FIMDBMJIEON;
		FHFHAOICIIB(GAKOOBECLIB, vector, BEAKIPPBGAF, FIMDBMJIEON);
		FHFHAOICIIB(IDFCFEOMBKP, -vector, BEAKIPPBGAF, FIMDBMJIEON);
		FHFHAOICIIB((GAKOOBECLIB + IDFCFEOMBKP) * 0.5f, vector, BEAKIPPBGAF, FIMDBMJIEON);
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		Gizmos.DrawLine(GAKOOBECLIB + vector3, IDFCFEOMBKP + vector3);
		Gizmos.DrawLine(GAKOOBECLIB - vector3, IDFCFEOMBKP - vector3);
		Gizmos.DrawLine(GAKOOBECLIB + vector2, IDFCFEOMBKP + vector2);
		Gizmos.DrawLine(GAKOOBECLIB - vector2, IDFCFEOMBKP - vector2);
		Gizmos.DrawLine(GAKOOBECLIB - vector3, GAKOOBECLIB + vector3);
		Gizmos.DrawLine(GAKOOBECLIB - vector2, GAKOOBECLIB + vector2);
		Gizmos.DrawLine(IDFCFEOMBKP - vector3, IDFCFEOMBKP + vector3);
		Gizmos.DrawLine(IDFCFEOMBKP - vector2, IDFCFEOMBKP + vector2);
		Gizmos.color = color;
	}

	public static void ACOPCJJAFGK(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, float FIMDBMJIEON = 1f)
	{
		ACOPCJJAFGK(GAKOOBECLIB, IDFCFEOMBKP, Color.white, FIMDBMJIEON);
	}

	public static void CICKGMBOEEJ(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC, Color BEAKIPPBGAF, float IINELJPKNBN = 45f)
	{
		float magnitude = IJMNFOGNFAC.magnitude;
		Vector3 vector = IJMNFOGNFAC;
		Vector3 vector2 = Vector3.Slerp(vector, -vector, 0.5f);
		Vector3 vector3 = Vector3.Cross(vector, vector2).normalized * magnitude;
		IJMNFOGNFAC = IJMNFOGNFAC.normalized;
		Vector3 direction = Vector3.Slerp(vector, vector2, IINELJPKNBN / 90f);
		Plane plane = new Plane(-IJMNFOGNFAC, CMGMOJAFLFL + vector);
		Ray ray = new Ray(CMGMOJAFLFL, direction);
		float enter;
		plane.Raycast(ray, out enter);
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		Gizmos.DrawRay(CMGMOJAFLFL, direction.normalized * enter);
		Gizmos.DrawRay(CMGMOJAFLFL, Vector3.Slerp(vector, -vector2, IINELJPKNBN / 90f).normalized * enter);
		Gizmos.DrawRay(CMGMOJAFLFL, Vector3.Slerp(vector, vector3, IINELJPKNBN / 90f).normalized * enter);
		Gizmos.DrawRay(CMGMOJAFLFL, Vector3.Slerp(vector, -vector3, IINELJPKNBN / 90f).normalized * enter);
		FHFHAOICIIB(CMGMOJAFLFL + vector, IJMNFOGNFAC, BEAKIPPBGAF, (vector - direction.normalized * enter).magnitude);
		FHFHAOICIIB(CMGMOJAFLFL + vector * 0.5f, IJMNFOGNFAC, BEAKIPPBGAF, (vector * 0.5f - direction.normalized * (enter * 0.5f)).magnitude);
		Gizmos.color = color;
	}

	public static void CICKGMBOEEJ(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC, float IINELJPKNBN = 45f)
	{
		CICKGMBOEEJ(CMGMOJAFLFL, IJMNFOGNFAC, Color.white, IINELJPKNBN);
	}

	public static void CICKGMBOEEJ(Vector3 CMGMOJAFLFL, Color BEAKIPPBGAF, float IINELJPKNBN = 45f)
	{
		CICKGMBOEEJ(CMGMOJAFLFL, Vector3.up, BEAKIPPBGAF, IINELJPKNBN);
	}

	public static void CICKGMBOEEJ(Vector3 CMGMOJAFLFL, float IINELJPKNBN = 45f)
	{
		CICKGMBOEEJ(CMGMOJAFLFL, Vector3.up, Color.white, IINELJPKNBN);
	}

	public static void KNDHADHNKPG(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC, Color BEAKIPPBGAF)
	{
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		Gizmos.DrawRay(CMGMOJAFLFL, IJMNFOGNFAC);
		CICKGMBOEEJ(CMGMOJAFLFL + IJMNFOGNFAC, -IJMNFOGNFAC * 0.333f, BEAKIPPBGAF, 15f);
		Gizmos.color = color;
	}

	public static void KNDHADHNKPG(Vector3 CMGMOJAFLFL, Vector3 IJMNFOGNFAC)
	{
		KNDHADHNKPG(CMGMOJAFLFL, IJMNFOGNFAC, Color.white);
	}

	public static void CCAICFLHOKE(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, Color BEAKIPPBGAF, float FIMDBMJIEON = 1f)
	{
		Vector3 vector = (IDFCFEOMBKP - GAKOOBECLIB).normalized * FIMDBMJIEON;
		Vector3 vector2 = Vector3.Slerp(vector, -vector, 0.5f);
		Vector3 vector3 = Vector3.Cross(vector, vector2).normalized * FIMDBMJIEON;
		Color color = Gizmos.color;
		Gizmos.color = BEAKIPPBGAF;
		float magnitude = (GAKOOBECLIB - IDFCFEOMBKP).magnitude;
		float num = Mathf.Max(0f, magnitude * 0.5f - FIMDBMJIEON);
		Vector3 vector4 = (IDFCFEOMBKP + GAKOOBECLIB) * 0.5f;
		GAKOOBECLIB = vector4 + (GAKOOBECLIB - vector4).normalized * num;
		IDFCFEOMBKP = vector4 + (IDFCFEOMBKP - vector4).normalized * num;
		FHFHAOICIIB(GAKOOBECLIB, vector, BEAKIPPBGAF, FIMDBMJIEON);
		FHFHAOICIIB(IDFCFEOMBKP, -vector, BEAKIPPBGAF, FIMDBMJIEON);
		Gizmos.DrawLine(GAKOOBECLIB + vector3, IDFCFEOMBKP + vector3);
		Gizmos.DrawLine(GAKOOBECLIB - vector3, IDFCFEOMBKP - vector3);
		Gizmos.DrawLine(GAKOOBECLIB + vector2, IDFCFEOMBKP + vector2);
		Gizmos.DrawLine(GAKOOBECLIB - vector2, IDFCFEOMBKP - vector2);
		for (int i = 1; i < 26; i++)
		{
			Gizmos.DrawLine(Vector3.Slerp(vector3, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(vector3, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB);
			Gizmos.DrawLine(Vector3.Slerp(-vector3, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(-vector3, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB);
			Gizmos.DrawLine(Vector3.Slerp(vector2, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(vector2, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB);
			Gizmos.DrawLine(Vector3.Slerp(-vector2, -vector, (float)i / 25f) + GAKOOBECLIB, Vector3.Slerp(-vector2, -vector, (float)(i - 1) / 25f) + GAKOOBECLIB);
			Gizmos.DrawLine(Vector3.Slerp(vector3, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(vector3, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP);
			Gizmos.DrawLine(Vector3.Slerp(-vector3, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(-vector3, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP);
			Gizmos.DrawLine(Vector3.Slerp(vector2, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(vector2, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP);
			Gizmos.DrawLine(Vector3.Slerp(-vector2, vector, (float)i / 25f) + IDFCFEOMBKP, Vector3.Slerp(-vector2, vector, (float)(i - 1) / 25f) + IDFCFEOMBKP);
		}
		Gizmos.color = color;
	}

	public static void CCAICFLHOKE(Vector3 GAKOOBECLIB, Vector3 IDFCFEOMBKP, float FIMDBMJIEON = 1f)
	{
		CCAICFLHOKE(GAKOOBECLIB, IDFCFEOMBKP, Color.white, FIMDBMJIEON);
	}

	public static string LJBECMGCOAL(object HCKCCHPJOPI, bool FADNGGJKDFE = false)
	{
		string text = string.Empty;
		MethodInfo[] methods = HCKCCHPJOPI.GetType().GetMethods();
		for (int i = 0; i < methods.Length; i++)
		{
			text = ((!FADNGGJKDFE) ? (text + methods[i].Name + "\n") : string.Concat(text, methods[i], "\n"));
		}
		return text;
	}

	public static string HMCGGNGNNOA(Type FBAGNJILEGD, bool FADNGGJKDFE = false)
	{
		string text = string.Empty;
		MethodInfo[] methods = FBAGNJILEGD.GetMethods();
		for (int i = 0; i < methods.Length; i++)
		{
			text = ((!FADNGGJKDFE) ? (text + methods[i].Name + "\n") : string.Concat(text, methods[i], "\n"));
		}
		return text;
	}
}
