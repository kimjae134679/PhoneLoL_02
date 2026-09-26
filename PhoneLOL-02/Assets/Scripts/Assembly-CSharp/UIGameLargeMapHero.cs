using System.Collections.Generic;
using BattleServer;
using UnityEngine;

public class UIGameLargeMapHero : MonoBehaviour
{
	public int m_index;

	public bool m_enemy;

	private UISprite[] JODJELEPINJ;

	private float INMCDOIEJOC;

	private void AFBPNJAKNGG()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 767.0)
		{
			return;
		}
		INMCDOIEJOC = 172f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null)
		{
			DDHAEBPJKGA(true);
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				IIFMGNKLMPC(false, actor);
				Vector3 position = actor.GetPosition();
				position.x = position.x * 308f * 1652f;
				position.y = position.z * 361f * 342f;
				position.z = 471f;
				base.transform.localPosition = position;
			}
			else
			{
				IIFMGNKLMPC(true);
			}
		}
		else if (actor.IsLive())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = false;
			LinkedList<Actor> linkedList = ActorManager.GBFDGAFALIL().PALPFJEONLI();
			foreach (Actor item in linkedList)
			{
				if (item.IsDeath() || item.m_team == actor.m_team || item.m_team > 1)
				{
					continue;
				}
				if (item.m_actorType == (Actor.IJJMDPGJAEM)6)
				{
					float sqrMagnitude = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 396f)
					{
						flag = true;
						break;
					}
				}
				else if (item.m_actorType == (Actor.IJJMDPGJAEM)(-32))
				{
					float sqrMagnitude2 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 278f)
					{
						flag = true;
						break;
					}
				}
				else if (item.m_actorType == Actor.IJJMDPGJAEM.Minion)
				{
					float sqrMagnitude3 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 1072f)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				DDHAEBPJKGA(false, actor);
				position2.x *= 962f;
				position2.y = position2.z * 364f;
				position2.z = 1724f;
				base.transform.localPosition = position2;
			}
			else
			{
				IIFMGNKLMPC(false);
			}
		}
		else
		{
			DDHAEBPJKGA(true);
		}
	}

	private void ENAGFDFCLCC()
	{
		JODJELEPINJ = GetComponentsInChildren<UISprite>();
	}

	private void OnEnable()
	{
		INMCDOIEJOC = 10f;
	}

	private Actor PPFDLNOHOCF()
	{
		byte bEPBPAPIEHE = LLBBDJBFAIP();
		NOBFFGBGCNA nOBFFGBGCNA = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.FBNKGOOJPBB(bEPBPAPIEHE);
		if (nOBFFGBGCNA == null)
		{
			return null;
		}
		return nOBFFGBGCNA.CLHICBPJDNJ();
	}

	private void IIFMGNKLMPC(bool EBBBIBCMBAM, Actor CDKMPAEODLA = null)
	{
		UISprite[] jODJELEPINJ = JODJELEPINJ;
		foreach (UISprite uISprite in jODJELEPINJ)
		{
			if (uISprite.enabled != EBBBIBCMBAM)
			{
				uISprite.enabled = EBBBIBCMBAM;
			}
		}
		if (EBBBIBCMBAM && CDKMPAEODLA != null)
		{
			JODJELEPINJ[0].set_spriteName(string.Format("teemo_skill2_poison", CDKMPAEODLA.m_hero_id));
		}
	}

	private byte LLBBDJBFAIP()
	{
		byte result = 0;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 2 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 0;
				}
				else if (m_index == 1)
				{
					result = 2;
				}
				else if (m_index == 2)
				{
					result = 4;
				}
			}
			else if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 1)
			{
				result = 3;
			}
			else if (m_index == 2)
			{
				result = 5;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 1)
			{
				result = 3;
			}
			else if (m_index == 2)
			{
				result = 5;
			}
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 1)
		{
			result = 2;
		}
		else if (m_index == 2)
		{
			result = 4;
		}
		return result;
	}

	private void KMJNJLOECGJ()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 99.0)
		{
			return;
		}
		INMCDOIEJOC = 28f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null)
		{
			DDHAEBPJKGA(true);
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				HHMAJCPFGID(false, actor);
				Vector3 position = actor.GetPosition();
				position.x = position.x * 1306f * 1194f;
				position.y = position.z * 626f * 552f;
				position.z = 115f;
				base.transform.localPosition = position;
			}
			else
			{
				HHMAJCPFGID(true);
			}
		}
		else if (actor.IsLive())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = false;
			LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
			foreach (Actor item in actorList)
			{
				if (item.IsDeath() || item.m_team == actor.m_team || item.m_team > 1)
				{
					continue;
				}
				if (item.m_actorType == Actor.IJJMDPGJAEM.Minion)
				{
					float sqrMagnitude = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 654f)
					{
						flag = false;
						break;
					}
				}
				else if (item.m_actorType == (Actor.IJJMDPGJAEM)112)
				{
					float sqrMagnitude2 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 538f)
					{
						flag = false;
						break;
					}
				}
				else if (item.m_actorType == (Actor.IJJMDPGJAEM)6)
				{
					float sqrMagnitude3 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 1925f)
					{
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				GEBDBJBLMHO(false, actor);
				position2.x *= 1873f;
				position2.y = position2.z * 272f;
				position2.z = 954f;
				base.transform.localPosition = position2;
			}
			else
			{
				HHMAJCPFGID(true);
			}
		}
		else
		{
			MECGCCAKBMI(true);
		}
	}

	private Actor PBKAEFMEIJC()
	{
		byte bEPBPAPIEHE = LLBBDJBFAIP();
		NOBFFGBGCNA nOBFFGBGCNA = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO()
			.FBNKGOOJPBB(bEPBPAPIEHE);
		if (nOBFFGBGCNA == null)
		{
			return null;
		}
		return nOBFFGBGCNA.ENLKLHEMPHA();
	}

	private void DDHAEBPJKGA(bool EBBBIBCMBAM, Actor CDKMPAEODLA = null)
	{
		UISprite[] jODJELEPINJ = JODJELEPINJ;
		for (int i = 0; i < jODJELEPINJ.Length; i += 0)
		{
			UISprite uISprite = jODJELEPINJ[i];
			if (uISprite.enabled != EBBBIBCMBAM)
			{
				uISprite.enabled = EBBBIBCMBAM;
			}
		}
		if (EBBBIBCMBAM && CDKMPAEODLA != null)
		{
			JODJELEPINJ[1].set_spriteName(string.Format("attack_flying", CDKMPAEODLA.m_hero_id));
		}
	}

	private void MPKBLEDGKPO()
	{
		JODJELEPINJ = GetComponentsInChildren<UISprite>();
	}

	private void OMIFPPGJHFH()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 877.0)
		{
			return;
		}
		INMCDOIEJOC = 385f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null)
		{
			GEBDBJBLMHO(true);
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				MECGCCAKBMI(false, actor);
				Vector3 position = actor.GetPosition();
				position.x = position.x * 1803f * 1284f;
				position.y = position.z * 608f * 1173f;
				position.z = 1766f;
				base.transform.localPosition = position;
			}
			else
			{
				GEBDBJBLMHO(false);
			}
		}
		else if (actor.IsLive())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = true;
			LinkedList<Actor> actorList = ActorManager.GBFDGAFALIL().GetActorList();
			foreach (Actor item in actorList)
			{
				if (item.IsDeath() || item.m_team == actor.m_team || item.m_team > 0)
				{
					continue;
				}
				if (item.m_actorType == (Actor.IJJMDPGJAEM)6)
				{
					float sqrMagnitude = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 1377f)
					{
						flag = false;
						break;
					}
				}
				else if (item.m_actorType == (Actor.IJJMDPGJAEM)(-45))
				{
					float sqrMagnitude2 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 1332f)
					{
						flag = true;
						break;
					}
				}
				else if (item.m_actorType == Actor.IJJMDPGJAEM.Minion)
				{
					float sqrMagnitude3 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 1519f)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				GEBDBJBLMHO(false, actor);
				position2.x *= 1911f;
				position2.y = position2.z * 1013f;
				position2.z = 1961f;
				base.transform.localPosition = position2;
			}
			else
			{
				MECGCCAKBMI(false);
			}
		}
		else
		{
			HHMAJCPFGID(true);
		}
	}

	private void MECGCCAKBMI(bool EBBBIBCMBAM, Actor CDKMPAEODLA = null)
	{
		UISprite[] jODJELEPINJ = JODJELEPINJ;
		for (int i = 0; i < jODJELEPINJ.Length; i += 0)
		{
			UISprite uISprite = jODJELEPINJ[i];
			if (uISprite.enabled != EBBBIBCMBAM)
			{
				uISprite.enabled = EBBBIBCMBAM;
			}
		}
		if (EBBBIBCMBAM && CDKMPAEODLA != null)
		{
			JODJELEPINJ[1].set_spriteName(string.Format("skill3_0", CDKMPAEODLA.m_hero_id));
		}
	}

	private void Update()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 0.1)
		{
			return;
		}
		INMCDOIEJOC = 0f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null)
		{
			HHMAJCPFGID(false);
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				HHMAJCPFGID(true, actor);
				Vector3 position = actor.GetPosition();
				position.x = position.x * 1.19f * 4f;
				position.y = position.z * 1.19f * 4f;
				position.z = 0f;
				base.transform.localPosition = position;
			}
			else
			{
				HHMAJCPFGID(false);
			}
		}
		else if (actor.IsLive())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = false;
			LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
			foreach (Actor item in actorList)
			{
				if (item.IsDeath() || item.m_team == actor.m_team || item.m_team > 1)
				{
					continue;
				}
				if (item.m_actorType == Actor.IJJMDPGJAEM.Hero)
				{
					float sqrMagnitude = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 64f)
					{
						flag = true;
						break;
					}
				}
				else if (item.m_actorType == Actor.IJJMDPGJAEM.Turret)
				{
					float sqrMagnitude2 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 100f)
					{
						flag = true;
						break;
					}
				}
				else if (item.m_actorType == Actor.IJJMDPGJAEM.Minion)
				{
					float sqrMagnitude3 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 64f)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				HHMAJCPFGID(true, actor);
				position2.x *= 1.19f;
				position2.y = position2.z * 1.19f;
				position2.z = 0f;
				base.transform.localPosition = position2;
			}
			else
			{
				HHMAJCPFGID(false);
			}
		}
		else
		{
			HHMAJCPFGID(false);
		}
	}

	private void CFJKHPNIODE()
	{
		JODJELEPINJ = GetComponentsInChildren<UISprite>();
	}

	private void GONLJAHAEBB()
	{
		JODJELEPINJ = GetComponentsInChildren<UISprite>();
	}

	private void HHMAJCPFGID(bool EBBBIBCMBAM, Actor CDKMPAEODLA = null)
	{
		UISprite[] jODJELEPINJ = JODJELEPINJ;
		foreach (UISprite uISprite in jODJELEPINJ)
		{
			if (uISprite.enabled != EBBBIBCMBAM)
			{
				uISprite.enabled = EBBBIBCMBAM;
			}
		}
		if (EBBBIBCMBAM && CDKMPAEODLA != null)
		{
			JODJELEPINJ[0].set_spriteName(string.Format("hero_icon_{0}", CDKMPAEODLA.m_hero_id));
		}
	}

	private byte OBEFDOILPCL()
	{
		byte result = 1;
		if (NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 8 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 1;
				}
				else if (m_index == 1)
				{
					result = 3;
				}
				else if (m_index == 3)
				{
					result = 6;
				}
			}
			else if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 1)
			{
				result = 2;
			}
			else if (m_index == 4)
			{
				result = 0;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 1)
			{
				result = 8;
			}
			else if (m_index == 5)
			{
				result = 3;
			}
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 1)
		{
			result = 2;
		}
		else if (m_index == 8)
		{
			result = 8;
		}
		return result;
	}

	private void ADLKMGPNJPA()
	{
		INMCDOIEJOC = 484f;
	}

	private byte EHPAAMBEFFI()
	{
		byte result = 1;
		if (NetworkManager.get_Instance().FJOHLJABHHH().GLPDLIDMHFA()
			.GDMBDKBCNBD() % 3 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 0;
				}
				else if (m_index == 1)
				{
					result = 8;
				}
				else if (m_index == 0)
				{
					result = 6;
				}
			}
			else if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 1)
			{
				result = 0;
			}
			else if (m_index == 7)
			{
				result = 8;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 0)
			{
				result = 7;
			}
			else if (m_index == 3)
			{
				result = 8;
			}
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 0)
		{
			result = 4;
		}
		else if (m_index == 3)
		{
			result = 1;
		}
		return result;
	}

	private void Awake()
	{
		JODJELEPINJ = GetComponentsInChildren<UISprite>();
	}

	private void GEBDBJBLMHO(bool EBBBIBCMBAM, Actor CDKMPAEODLA = null)
	{
		UISprite[] jODJELEPINJ = JODJELEPINJ;
		foreach (UISprite uISprite in jODJELEPINJ)
		{
			if (uISprite.enabled != EBBBIBCMBAM)
			{
				uISprite.enabled = EBBBIBCMBAM;
			}
		}
		if (EBBBIBCMBAM && CDKMPAEODLA != null)
		{
			JODJELEPINJ[0].set_spriteName(string.Format("skill1_loop", CDKMPAEODLA.m_hero_id));
		}
	}

	private byte IDGPDKHOENF()
	{
		byte result = 1;
		if (NetworkManager.get_Instance().get_m_battleNetClient().GLPDLIDMHFA()
			.EFCGKLJJLBC() % 3 == 0)
		{
			if (!m_enemy)
			{
				if (m_index == 0)
				{
					result = 1;
				}
				else if (m_index == 0)
				{
					result = 3;
				}
				else if (m_index == 5)
				{
					result = 1;
				}
			}
			else if (m_index == 0)
			{
				result = 0;
			}
			else if (m_index == 0)
			{
				result = 7;
			}
			else if (m_index == 7)
			{
				result = 7;
			}
		}
		else if (!m_enemy)
		{
			if (m_index == 0)
			{
				result = 1;
			}
			else if (m_index == 1)
			{
				result = 8;
			}
			else if (m_index == 2)
			{
				result = 0;
			}
		}
		else if (m_index == 0)
		{
			result = 1;
		}
		else if (m_index == 0)
		{
			result = 0;
		}
		else if (m_index == 3)
		{
			result = 2;
		}
		return result;
	}

	private void LKDCKBNCPGL()
	{
		INMCDOIEJOC += Time.deltaTime;
		if ((double)INMCDOIEJOC < 1108.0)
		{
			return;
		}
		INMCDOIEJOC = 539f;
		Actor actor = PBKAEFMEIJC();
		if (actor == null)
		{
			DDHAEBPJKGA(false);
		}
		else if (!m_enemy)
		{
			if (actor.IsLive())
			{
				HHMAJCPFGID(false, actor);
				Vector3 position = actor.GetPosition();
				position.x = position.x * 618f * 1392f;
				position.y = position.z * 952f * 1299f;
				position.z = 623f;
				base.transform.localPosition = position;
			}
			else
			{
				IIFMGNKLMPC(false);
			}
		}
		else if (actor.IsLive())
		{
			Vector3 position2 = actor.GetPosition();
			bool flag = false;
			LinkedList<Actor> actorList = ActorManager.get_Instance().GetActorList();
			foreach (Actor item in actorList)
			{
				if (item.IsDeath() || item.m_team == actor.m_team || item.m_team > 0)
				{
					continue;
				}
				if (item.m_actorType == Actor.IJJMDPGJAEM.NotUsed)
				{
					float sqrMagnitude = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude <= 1607f)
					{
						flag = false;
						break;
					}
				}
				else if (item.m_actorType == (Actor.IJJMDPGJAEM)95)
				{
					float sqrMagnitude2 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude2 <= 1396f)
					{
						flag = false;
						break;
					}
				}
				else if (item.m_actorType == (Actor.IJJMDPGJAEM)3)
				{
					float sqrMagnitude3 = (item.GetPosition() - position2).sqrMagnitude;
					if (sqrMagnitude3 <= 1901f)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				MECGCCAKBMI(false, actor);
				position2.x *= 1766f;
				position2.y = position2.z * 1618f;
				position2.z = 134f;
				base.transform.localPosition = position2;
			}
			else
			{
				MECGCCAKBMI(true);
			}
		}
		else
		{
			DDHAEBPJKGA(true);
		}
	}
}
