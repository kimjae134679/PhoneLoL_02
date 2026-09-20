using UnityEngine;

public static class LGPKMBHJBKI
{
	public static bool CIDAEFBINFO(this Vector3 LPOAEBNAGCP, Vector3 HINDJBPPAMD, float FFFDGPLJOFP)
	{
		return (LPOAEBNAGCP - HINDJBPPAMD).sqrMagnitude < FFFDGPLJOFP;
	}

	public static bool CIDAEFBINFO(this Vector2 LPOAEBNAGCP, Vector2 HINDJBPPAMD, float FFFDGPLJOFP)
	{
		return (LPOAEBNAGCP - HINDJBPPAMD).sqrMagnitude < FFFDGPLJOFP;
	}

	public static bool CIDAEFBINFO(this Quaternion LPOAEBNAGCP, Quaternion HINDJBPPAMD, float IAAAPJHNLBF)
	{
		return Quaternion.Angle(LPOAEBNAGCP, HINDJBPPAMD) < IAAAPJHNLBF;
	}

	public static bool CIDAEFBINFO(this float LPOAEBNAGCP, float HINDJBPPAMD, float NHMGNKLNIKG)
	{
		return Mathf.Abs(LPOAEBNAGCP - HINDJBPPAMD) < NHMGNKLNIKG;
	}
}
