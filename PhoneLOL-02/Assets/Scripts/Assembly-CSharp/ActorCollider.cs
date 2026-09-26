using UnityEngine;

[AddComponentMenu("ProjectT/Actor/ActorCollider")]
public class ActorCollider : MonoBehaviour
{
	public BoxCollider m_damageCollider;

	public BoxCollider m_attackCollider;

	public BoxCollider[] m_skillCollider;

	public bool CheckDamage(BoxCollider2D JCBIJNIGKFI)
	{
		return m_damageCollider.bounds.Intersects(JCBIJNIGKFI.bounds);
	}

	public float ONOIJEGOMOK()
	{
		return m_damageCollider.bounds.size.y;
	}

	public bool EGPNNFMGDBI(ActorCollider LPOAEBNAGCP)
	{
		return m_attackCollider.bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	private void KMJNJLOECGJ()
	{
	}

	public bool DGCFPPDHFPF(int GBGBBGEPEMI, ActorCollider LPOAEBNAGCP)
	{
		return m_skillCollider[GBGBBGEPEMI].bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	public float CKOGFGPKFHK()
	{
		return m_damageCollider.bounds.size.y;
	}

	public bool JIAELKOPFNA(ActorCollider LPOAEBNAGCP)
	{
		return m_attackCollider.bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	public Vector3 GetDamageCenter()
	{
		return m_damageCollider.bounds.center;
	}

	public Vector3 LLEIJADPDJG()
	{
		return m_damageCollider.bounds.center;
	}

	public bool CheckAttack(BoxCollider2D ABLKHLFHIOH)
	{
		return m_attackCollider.bounds.Intersects(ABLKHLFHIOH.bounds);
	}

	public bool KABEIBIBIPJ(BoxCollider2D ABLKHLFHIOH)
	{
		return m_attackCollider.bounds.Intersects(ABLKHLFHIOH.bounds);
	}

	public float LGAKKPGGEPA()
	{
		return m_damageCollider.bounds.size.y;
	}

	public bool BABGNGGIMNC(int GBGBBGEPEMI, ActorCollider LPOAEBNAGCP)
	{
		return m_skillCollider[GBGBBGEPEMI].bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	public bool BGFODLONICH(BoxCollider2D JCBIJNIGKFI)
	{
		return m_damageCollider.bounds.Intersects(JCBIJNIGKFI.bounds);
	}

	private void ACBGKIDKKKM()
	{
	}

	public bool GOBOGIHOEGJ(int GBGBBGEPEMI, ActorCollider LPOAEBNAGCP)
	{
		return m_skillCollider[GBGBBGEPEMI].bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	public Vector3 IMJFHEGCEEN()
	{
		return m_damageCollider.bounds.center;
	}

	public bool FKCMKFMKDMB(BoxCollider2D ABLKHLFHIOH)
	{
		return m_attackCollider.bounds.Intersects(ABLKHLFHIOH.bounds);
	}

	public bool CheckSkill(int GBGBBGEPEMI, ActorCollider LPOAEBNAGCP)
	{
		return m_skillCollider[GBGBBGEPEMI].bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	private void MLOKLGPGKMO()
	{
	}

	public bool KLKPFFMCNCJ(BoxCollider2D ABLKHLFHIOH)
	{
		return m_attackCollider.bounds.Intersects(ABLKHLFHIOH.bounds);
	}

	public float JADINGEFECK()
	{
		return m_damageCollider.bounds.size.y;
	}

	private void NGNNLLLBGMB()
	{
	}

	public bool KHMNENINCID(ActorCollider LPOAEBNAGCP)
	{
		return m_attackCollider.bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	public float GetDamageHeight()
	{
		return m_damageCollider.bounds.size.y;
	}

	private void LOGAHPDKPHK()
	{
	}

	public float BINEOLMGCDH()
	{
		return m_damageCollider.bounds.size.y;
	}

	private void Awake()
	{
	}

	public float HIILBEFIAFK()
	{
		return m_damageCollider.bounds.size.y;
	}

	public bool KGGFCJFPJJO(int GBGBBGEPEMI, ActorCollider LPOAEBNAGCP)
	{
		return m_skillCollider[GBGBBGEPEMI].bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	public float DOOMCDNLOLE()
	{
		return m_damageCollider.bounds.size.y;
	}

	public bool PEKGCLDNEML(BoxCollider2D ABLKHLFHIOH)
	{
		return m_attackCollider.bounds.Intersects(ABLKHLFHIOH.bounds);
	}

	private void FPFNIFKNOIF()
	{
	}

	public float FNJMIPCBEJO()
	{
		return m_damageCollider.bounds.size.y;
	}

	private void Update()
	{
	}

	public bool CheckAttack(ActorCollider LPOAEBNAGCP)
	{
		return m_attackCollider.bounds.Intersects(LPOAEBNAGCP.m_damageCollider.bounds);
	}

	public bool OEMNDHHKOKG(BoxCollider2D ABLKHLFHIOH)
	{
		return m_attackCollider.bounds.Intersects(ABLKHLFHIOH.bounds);
	}
}
