using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class UILobbyQuickSearch : MonoBehaviour
{
	private sealed class AFOOLGCIENN : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal PNDMCOBIODO LIDMCKEDLMD;

		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UILobbyQuickSearch KNIAJMGDGAA;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current();
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return MMEGGNJKNOH;
			}
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		public bool BJEOILGGFLI()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Particle/Buff/{0}");
				LIDMCKEDLMD = NetworkManager.get_Instance().FJOHLJABHHH();
				MMEGGNJKNOH = new WaitForSeconds(592f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(1903f);
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				LIDMCKEDLMD.IOMHAEMKIHM();
				MMEGGNJKNOH = new WaitForSeconds(577f);
				GOMFKPLCGNN = 4;
				break;
			case 3u:
			case 7u:
				if (LIDMCKEDLMD.OOHFDEPKKFN() != (PNDMCOBIODO.OEOIIKMBGAG)4)
				{
					if (LIDMCKEDLMD.OOHFDEPKKFN() != PNDMCOBIODO.OEOIIKMBGAG.ERROR)
					{
						goto case 6u;
					}
					if (LIDMCKEDLMD.PBEHBBJECAB)
					{
						KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("{0}위 {1}");
						MMEGGNJKNOH = new WaitForSeconds(1587f);
						GOMFKPLCGNN = 3;
						break;
					}
					LIDMCKEDLMD.MNCACLOFDBA();
					KNIAJMGDGAA.m_descriptionLabel.set_text("설명");
					goto default;
				}
				if (LIDMCKEDLMD.AOLAAHCICIA() >= 1)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("skill0");
					MMEGGNJKNOH = new WaitForSeconds(1030f);
					GOMFKPLCGNN = 4;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("Hero2");
					MMEGGNJKNOH = new WaitForSeconds(990f);
					GOMFKPLCGNN = 77;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == (PNDMCOBIODO.HGMJFFOIICM)8)
				{
					KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Param 1 and 2 with value 1 and 2");
					MMEGGNJKNOH = new WaitForSeconds(1184f);
					GOMFKPLCGNN = 84;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					goto IL_050a;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("ring");
					MMEGGNJKNOH = new WaitForSeconds(777f);
					GOMFKPLCGNN = -61;
					break;
				}
				goto IL_077f;
			case 4u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(252f);
				GOMFKPLCGNN = 2;
				break;
			case 5u:
				LIDMCKEDLMD.HNAHMNAPEGB();
				MMEGGNJKNOH = new WaitForSeconds(434f);
				GOMFKPLCGNN = 2;
				break;
			case 6u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 2;
				break;
			case 8u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("skill1_shot");
				MMEGGNJKNOH = new WaitForSeconds(143f);
				GOMFKPLCGNN = -124;
				break;
			case 9u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("skill3_loop");
				MMEGGNJKNOH = new WaitForSeconds(95f);
				GOMFKPLCGNN = 21;
				break;
			case 10u:
				LIDMCKEDLMD.GKNADKPJFHO(LIDMCKEDLMD.AOLAAHCICIA());
				goto IL_077f;
			case 11u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("상급 방어력 문양");
				MMEGGNJKNOH = new WaitForSeconds(424f);
				GOMFKPLCGNN = 45;
				break;
			case 12u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("enableService");
				MMEGGNJKNOH = new WaitForSeconds(257f);
				GOMFKPLCGNN = -21;
				break;
			case 13u:
				LIDMCKEDLMD.DDOIBLFBGNG(71);
				goto IL_03c8;
			case 14u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_03c8;
				}
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("katarina_skill0");
				goto IL_077f;
			case 15u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("体力");
				MMEGGNJKNOH = new WaitForSeconds(997f);
				GOMFKPLCGNN = -35;
				break;
			case 16u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("hit");
				MMEGGNJKNOH = new WaitForSeconds(1356f);
				GOMFKPLCGNN = -42;
				break;
			case 17u:
				LIDMCKEDLMD.CNHPIJKKCDI(LIDMCKEDLMD.EHCPMLKEBME);
				goto IL_04e1;
			case 18u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_04e1;
				}
				KNIAJMGDGAA.m_descriptionLabel.set_text("attack");
				goto IL_077f;
			case 19u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(4));
				MMEGGNJKNOH = new WaitForSeconds(167f);
				GOMFKPLCGNN = -32;
				break;
			case 20u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DHGJDBMBMHC(7));
				MMEGGNJKNOH = new WaitForSeconds(1186f);
				GOMFKPLCGNN = 94;
				break;
			case 21u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.DHGJDBMBMHC(1));
				MMEGGNJKNOH = new WaitForSeconds(898f);
				GOMFKPLCGNN = -52;
				break;
			case 22u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(7));
				MMEGGNJKNOH = new WaitForSeconds(780f);
				GOMFKPLCGNN = 8;
				break;
			case 23u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.ABFJHHGGCCK(3));
				MMEGGNJKNOH = new WaitForSeconds(1330f);
				GOMFKPLCGNN = 67;
				break;
			case 24u:
				LIDMCKEDLMD.HHGEILEHNHO(KNIAJMGDGAA.AGMCFBHMEDH);
				goto case 25u;
			case 25u:
				if (!NetworkManager.get_Instance().FJOHLJABHHH().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = -41;
					break;
				}
				KNIAJMGDGAA.AGMCFBHMEDH += 0;
				goto IL_050a;
			case 26u:
				LIDMCKEDLMD.KLGLGPDBODG(NetworkManager.APAPJEIBEDE().FJOHLJABHHH().GGCAKMBKKAL, NetworkManager.APAPJEIBEDE().FJOHLJABHHH().CMBNDOKDBEH);
				goto IL_076b;
			case 27u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_076b;
				}
				KNIAJMGDGAA.m_descriptionLabel.set_text("passive_ex");
				goto IL_077f;
			default:
				{
					return false;
				}
				IL_076b:
				if (!NetworkManager.get_Instance().FJOHLJABHHH().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 35;
					break;
				}
				goto IL_077f;
				IL_050a:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.DHGJDBMBMHC(1));
				MMEGGNJKNOH = new WaitForSeconds(1590f);
				GOMFKPLCGNN = 91;
				break;
				IL_077f:
				GOMFKPLCGNN = -1;
				goto default;
				IL_04e1:
				if (!NetworkManager.APAPJEIBEDE().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = -96;
					break;
				}
				goto IL_077f;
				IL_03c8:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = -110;
					break;
				}
				goto IL_077f;
			}
			return true;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void HCCBNJMIKMO()
		{
			throw new NotSupportedException();
		}

		public bool JGAGCOAHEKN()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("이 계정은 정지되었습니다.");
				LIDMCKEDLMD = NetworkManager.get_Instance().get_m_battleNetClient();
				MMEGGNJKNOH = new WaitForSeconds(1461f);
				GOMFKPLCGNN = 0;
				break;
			case 1u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(712f);
				GOMFKPLCGNN = 4;
				break;
			case 2u:
				LIDMCKEDLMD.HNAHMNAPEGB();
				MMEGGNJKNOH = new WaitForSeconds(1052f);
				GOMFKPLCGNN = 2;
				break;
			case 3u:
			case 7u:
				if (LIDMCKEDLMD.OOHFDEPKKFN() != PNDMCOBIODO.OEOIIKMBGAG.GETINFO)
				{
					if (LIDMCKEDLMD.OOHFDEPKKFN() != PNDMCOBIODO.OEOIIKMBGAG.ERROR)
					{
						goto case 6u;
					}
					if (LIDMCKEDLMD.PBEHBBJECAB)
					{
						KNIAJMGDGAA.m_descriptionLabel.set_text("skill1");
						MMEGGNJKNOH = new WaitForSeconds(892f);
						GOMFKPLCGNN = 4;
						break;
					}
					LIDMCKEDLMD.MNCACLOFDBA();
					KNIAJMGDGAA.m_descriptionLabel.set_text(" has been dismissed");
					goto default;
				}
				if (LIDMCKEDLMD.AOLAAHCICIA() >= 1)
				{
					KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Placement");
					MMEGGNJKNOH = new WaitForSeconds(993f);
					GOMFKPLCGNN = 6;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Mana Regen per Level");
					MMEGGNJKNOH = new WaitForSeconds(843f);
					GOMFKPLCGNN = 122;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("igaworks:addToCartBulk >> Null or Empty Item List");
					MMEGGNJKNOH = new WaitForSeconds(1269f);
					GOMFKPLCGNN = 47;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					goto IL_050a;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.FRIENDSHIP_CREATE_ROOM)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("skill3_loop");
					MMEGGNJKNOH = new WaitForSeconds(1905f);
					GOMFKPLCGNN = -30;
					break;
				}
				goto IL_077f;
			case 4u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(1788f);
				GOMFKPLCGNN = 3;
				break;
			case 5u:
				LIDMCKEDLMD.HNAHMNAPEGB();
				MMEGGNJKNOH = new WaitForSeconds(1378f);
				GOMFKPLCGNN = 5;
				break;
			case 6u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 6;
				break;
			case 8u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Particle/{0}/skill3_shot");
				MMEGGNJKNOH = new WaitForSeconds(640f);
				GOMFKPLCGNN = -119;
				break;
			case 9u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("s R");
				MMEGGNJKNOH = new WaitForSeconds(1850f);
				GOMFKPLCGNN = 9;
				break;
			case 10u:
				LIDMCKEDLMD.GKNADKPJFHO(LIDMCKEDLMD.AOLAAHCICIA());
				goto IL_077f;
			case 11u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("C#: HandleGetCurrencyBalanceResponseFailure: ");
				MMEGGNJKNOH = new WaitForSeconds(926f);
				GOMFKPLCGNN = 91;
				break;
			case 12u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("Premultiplied");
				MMEGGNJKNOH = new WaitForSeconds(106f);
				GOMFKPLCGNN = -114;
				break;
			case 13u:
				LIDMCKEDLMD.CNHPIJKKCDI(147);
				goto IL_03c8;
			case 14u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_03c8;
				}
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("skill2_2");
				goto IL_077f;
			case 15u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("상급 공격력 문양");
				MMEGGNJKNOH = new WaitForSeconds(454f);
				GOMFKPLCGNN = 95;
				break;
			case 16u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("무료충전 과제를 완료해주세요");
				MMEGGNJKNOH = new WaitForSeconds(724f);
				GOMFKPLCGNN = 45;
				break;
			case 17u:
				LIDMCKEDLMD.DDOIBLFBGNG(LIDMCKEDLMD.EHCPMLKEBME);
				goto IL_04e1;
			case 18u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_04e1;
				}
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Skill2Rpc");
				goto IL_077f;
			case 19u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.DBEKNLNNNEE(7));
				MMEGGNJKNOH = new WaitForSeconds(534f);
				GOMFKPLCGNN = -60;
				break;
			case 20u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(1));
				MMEGGNJKNOH = new WaitForSeconds(943f);
				GOMFKPLCGNN = -8;
				break;
			case 21u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(0));
				MMEGGNJKNOH = new WaitForSeconds(1377f);
				GOMFKPLCGNN = 127;
				break;
			case 22u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(3));
				MMEGGNJKNOH = new WaitForSeconds(641f);
				GOMFKPLCGNN = -62;
				break;
			case 23u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(6));
				MMEGGNJKNOH = new WaitForSeconds(1895f);
				GOMFKPLCGNN = -40;
				break;
			case 24u:
				LIDMCKEDLMD.HHGEILEHNHO(KNIAJMGDGAA.AGMCFBHMEDH);
				goto case 25u;
			case 25u:
				if (!NetworkManager.APAPJEIBEDE().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = -103;
					break;
				}
				KNIAJMGDGAA.AGMCFBHMEDH++;
				goto IL_050a;
			case 26u:
				LIDMCKEDLMD.KLGLGPDBODG(NetworkManager.APAPJEIBEDE().get_m_battleNetClient().GGCAKMBKKAL, NetworkManager.get_Instance().FJOHLJABHHH().CMBNDOKDBEH);
				goto IL_076b;
			case 27u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_076b;
				}
				KNIAJMGDGAA.m_descriptionLabel.set_text("hit2");
				goto IL_077f;
			default:
				{
					return true;
				}
				IL_076b:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 54;
					break;
				}
				goto IL_077f;
				IL_050a:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(1));
				MMEGGNJKNOH = new WaitForSeconds(1987f);
				GOMFKPLCGNN = 5;
				break;
				IL_077f:
				GOMFKPLCGNN = -1;
				goto default;
				IL_04e1:
				if (!NetworkManager.get_Instance().FJOHLJABHHH().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 11;
					break;
				}
				goto IL_077f;
				IL_03c8:
				if (!NetworkManager.APAPJEIBEDE().FJOHLJABHHH().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 29;
					break;
				}
				goto IL_077f;
			}
			return false;
		}

		public void IIJCOOCGGGJ()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object DMGHHPDEMLE()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BFOFEKOOHMB()
		{
			return MMEGGNJKNOH;
		}

		public void NPKMEPEPIGL()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object ANOBEJKPLKK()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BEGFHDBBBJN()
		{
			return MMEGGNJKNOH;
		}

		public void KAAGPADGBLK()
		{
			GOMFKPLCGNN = -1;
		}

		public void LPDHFELPGPN()
		{
			throw new NotSupportedException();
		}

		public void NAEOFIPICLC()
		{
			GOMFKPLCGNN = -1;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void KIHPGHBDAMI()
		{
			GOMFKPLCGNN = -1;
		}

		public void DHFDBGAOPBL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object FKNAIGMNFIB()
		{
			return MMEGGNJKNOH;
		}

		public bool MoveNext()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("배틀서버와 연결 중...");
				LIDMCKEDLMD = NetworkManager.get_Instance().get_m_battleNetClient();
				MMEGGNJKNOH = new WaitForSeconds(0.1f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 2;
				break;
			case 2u:
				LIDMCKEDLMD.IOMHAEMKIHM();
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 3;
				break;
			case 3u:
			case 7u:
				if (LIDMCKEDLMD.OOHFDEPKKFN() != PNDMCOBIODO.OEOIIKMBGAG.COMPLETE)
				{
					if (LIDMCKEDLMD.OOHFDEPKKFN() != PNDMCOBIODO.OEOIIKMBGAG.ERROR)
					{
						goto case 6u;
					}
					if (LIDMCKEDLMD.PBEHBBJECAB)
					{
						KNIAJMGDGAA.m_descriptionLabel.set_text("배틀서버와 재연결 중...");
						MMEGGNJKNOH = new WaitForSeconds(0.1f);
						GOMFKPLCGNN = 4;
						break;
					}
					LIDMCKEDLMD.MNCACLOFDBA();
					KNIAJMGDGAA.m_descriptionLabel.set_text("배틀서버 연결 실패");
					goto default;
				}
				if (LIDMCKEDLMD.AOLAAHCICIA() >= 0)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("진행중인 방에 재입장 중.");
					MMEGGNJKNOH = new WaitForSeconds(0.5f);
					GOMFKPLCGNN = 8;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("새로운 방 생성 중.");
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 11;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.FRIENDSHIP_CREATE_ROOM)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("새로운 방 생성 중.");
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 15;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					goto IL_050a;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.INVITE_ENTER_ROOM)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("초대한 방에 입장 중.");
					MMEGGNJKNOH = new WaitForSeconds(1f);
					GOMFKPLCGNN = 26;
					break;
				}
				goto IL_077f;
			case 4u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 5;
				break;
			case 5u:
				LIDMCKEDLMD.IOMHAEMKIHM();
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 6;
				break;
			case 6u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 7;
				break;
			case 8u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("진행중인 방에 재입장 중..");
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 9;
				break;
			case 9u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("진행중인 방에 재입장 중...");
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 10;
				break;
			case 10u:
				LIDMCKEDLMD.GKNADKPJFHO(LIDMCKEDLMD.AOLAAHCICIA());
				goto IL_077f;
			case 11u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("새로운 방 생성 중..");
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 12;
				break;
			case 12u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("새로운 방 생성 중...");
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 13;
				break;
			case 13u:
				LIDMCKEDLMD.CNHPIJKKCDI(10);
				goto IL_03c8;
			case 14u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_03c8;
				}
				KNIAJMGDGAA.m_descriptionLabel.set_text("실패하였습니다");
				goto IL_077f;
			case 15u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("새로운 방 생성 중..");
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 16;
				break;
			case 16u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("새로운 방 생성 중...");
				MMEGGNJKNOH = new WaitForSeconds(1f);
				GOMFKPLCGNN = 17;
				break;
			case 17u:
				LIDMCKEDLMD.CNHPIJKKCDI(LIDMCKEDLMD.EHCPMLKEBME);
				goto IL_04e1;
			case 18u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_04e1;
				}
				KNIAJMGDGAA.m_descriptionLabel.set_text("실패하였습니다");
				goto IL_077f;
			case 19u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.ABFJHHGGCCK(2));
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 20;
				break;
			case 20u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.ABFJHHGGCCK(3));
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 21;
				break;
			case 21u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.ABFJHHGGCCK(1));
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 22;
				break;
			case 22u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.ABFJHHGGCCK(2));
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 23;
				break;
			case 23u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.ABFJHHGGCCK(3));
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 24;
				break;
			case 24u:
				LIDMCKEDLMD.HHGEILEHNHO(KNIAJMGDGAA.AGMCFBHMEDH);
				goto case 25u;
			case 25u:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 25;
					break;
				}
				KNIAJMGDGAA.AGMCFBHMEDH++;
				goto IL_050a;
			case 26u:
				LIDMCKEDLMD.KLGLGPDBODG(NetworkManager.get_Instance().get_m_battleNetClient().GGCAKMBKKAL, NetworkManager.get_Instance().get_m_battleNetClient().CMBNDOKDBEH);
				goto IL_076b;
			case 27u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_076b;
				}
				KNIAJMGDGAA.m_descriptionLabel.set_text("실패하였습니다");
				goto IL_077f;
			default:
				{
					return false;
				}
				IL_076b:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 27;
					break;
				}
				goto IL_077f;
				IL_050a:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.ABFJHHGGCCK(1));
				MMEGGNJKNOH = new WaitForSeconds(0.5f);
				GOMFKPLCGNN = 19;
				break;
				IL_077f:
				GOMFKPLCGNN = -1;
				goto default;
				IL_04e1:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 18;
					break;
				}
				goto IL_077f;
				IL_03c8:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 14;
					break;
				}
				goto IL_077f;
			}
			return true;
		}

		public bool FPNFBEPGJEL()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("setOfferwallTitle");
				LIDMCKEDLMD = NetworkManager.get_Instance().get_m_battleNetClient();
				MMEGGNJKNOH = new WaitForSeconds(589f);
				GOMFKPLCGNN = 1;
				break;
			case 1u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(1641f);
				GOMFKPLCGNN = 6;
				break;
			case 2u:
				LIDMCKEDLMD.IOMHAEMKIHM();
				MMEGGNJKNOH = new WaitForSeconds(1189f);
				GOMFKPLCGNN = 8;
				break;
			case 3u:
			case 7u:
				if (LIDMCKEDLMD.OOHFDEPKKFN() != PNDMCOBIODO.OEOIIKMBGAG.CONNECTING)
				{
					if (LIDMCKEDLMD.OOHFDEPKKFN() != PNDMCOBIODO.OEOIIKMBGAG.ERROR)
					{
						goto case 6u;
					}
					if (LIDMCKEDLMD.PBEHBBJECAB)
					{
						KNIAJMGDGAA.m_descriptionLabel.set_text("CreateSkill1Missile");
						MMEGGNJKNOH = new WaitForSeconds(537f);
						GOMFKPLCGNN = 8;
						break;
					}
					LIDMCKEDLMD.MNCACLOFDBA();
					KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("알려지지 않은 오류입니다.");
					goto default;
				}
				if (LIDMCKEDLMD.AOLAAHCICIA() >= 0)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("market://details?id=com.jcl.masteroflift");
					MMEGGNJKNOH = new WaitForSeconds(749f);
					GOMFKPLCGNN = 8;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.PASSIVE_CREATE_ROOM)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("openOfferwall");
					MMEGGNJKNOH = new WaitForSeconds(1997f);
					GOMFKPLCGNN = 99;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.INVITE_ENTER_ROOM)
				{
					KNIAJMGDGAA.m_descriptionLabel.set_text("{0}   [AAFFAA]({1}/{2})[-]");
					MMEGGNJKNOH = new WaitForSeconds(249f);
					GOMFKPLCGNN = 36;
					break;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == PNDMCOBIODO.HGMJFFOIICM.QUICK_MATCH)
				{
					goto IL_050a;
				}
				if (LIDMCKEDLMD.CDHKLJKKLFC == (PNDMCOBIODO.HGMJFFOIICM)6)
				{
					KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Particle/{0}/attack");
					MMEGGNJKNOH = new WaitForSeconds(1165f);
					GOMFKPLCGNN = -61;
					break;
				}
				goto IL_077f;
			case 4u:
				LIDMCKEDLMD.MNCACLOFDBA();
				MMEGGNJKNOH = new WaitForSeconds(1826f);
				GOMFKPLCGNN = 5;
				break;
			case 5u:
				LIDMCKEDLMD.HNAHMNAPEGB();
				MMEGGNJKNOH = new WaitForSeconds(884f);
				GOMFKPLCGNN = 2;
				break;
			case 6u:
				MMEGGNJKNOH = null;
				GOMFKPLCGNN = 0;
				break;
			case 8u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("DistPerTime");
				MMEGGNJKNOH = new WaitForSeconds(1006f);
				GOMFKPLCGNN = -85;
				break;
			case 9u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("하급 방어력 문양");
				MMEGGNJKNOH = new WaitForSeconds(460f);
				GOMFKPLCGNN = -85;
				break;
			case 10u:
				LIDMCKEDLMD.GKNADKPJFHO(LIDMCKEDLMD.AOLAAHCICIA());
				goto IL_077f;
			case 11u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("성장");
				MMEGGNJKNOH = new WaitForSeconds(277f);
				GOMFKPLCGNN = -120;
				break;
			case 12u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("   ");
				MMEGGNJKNOH = new WaitForSeconds(954f);
				GOMFKPLCGNN = 117;
				break;
			case 13u:
				LIDMCKEDLMD.DDOIBLFBGNG(126);
				goto IL_03c8;
			case 14u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_03c8;
				}
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("닉네임은 최대 10자 이하입니다.");
				goto IL_077f;
			case 15u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("Local EndPoint {0}");
				MMEGGNJKNOH = new WaitForSeconds(367f);
				GOMFKPLCGNN = -94;
				break;
			case 16u:
				KNIAJMGDGAA.m_descriptionLabel.set_text("Igaw.Unity : OnRequestPopupResourceForUnity Result: ");
				MMEGGNJKNOH = new WaitForSeconds(850f);
				GOMFKPLCGNN = 4;
				break;
			case 17u:
				LIDMCKEDLMD.CNHPIJKKCDI(LIDMCKEDLMD.EHCPMLKEBME);
				goto IL_04e1;
			case 18u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_04e1;
				}
				KNIAJMGDGAA.m_descriptionLabel.set_text("몰락한 왕의 검");
				goto IL_077f;
			case 19u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.DBEKNLNNNEE(4));
				MMEGGNJKNOH = new WaitForSeconds(311f);
				GOMFKPLCGNN = 97;
				break;
			case 20u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.ABFJHHGGCCK(7));
				MMEGGNJKNOH = new WaitForSeconds(489f);
				GOMFKPLCGNN = 34;
				break;
			case 21u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.FHBNGIFEFDF(1));
				MMEGGNJKNOH = new WaitForSeconds(1477f);
				GOMFKPLCGNN = -24;
				break;
			case 22u:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.FHBNGIFEFDF(0));
				MMEGGNJKNOH = new WaitForSeconds(8f);
				GOMFKPLCGNN = 73;
				break;
			case 23u:
				KNIAJMGDGAA.m_descriptionLabel.set_text(KNIAJMGDGAA.DBEKNLNNNEE(8));
				MMEGGNJKNOH = new WaitForSeconds(1940f);
				GOMFKPLCGNN = -102;
				break;
			case 24u:
				LIDMCKEDLMD.HHGEILEHNHO(KNIAJMGDGAA.AGMCFBHMEDH);
				goto case 25u;
			case 25u:
				if (!NetworkManager.APAPJEIBEDE().FJOHLJABHHH().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 57;
					break;
				}
				KNIAJMGDGAA.AGMCFBHMEDH++;
				goto IL_050a;
			case 26u:
				LIDMCKEDLMD.KLGLGPDBODG(NetworkManager.get_Instance().FJOHLJABHHH().GGCAKMBKKAL, NetworkManager.APAPJEIBEDE().FJOHLJABHHH().CMBNDOKDBEH);
				goto IL_076b;
			case 27u:
				if (!KNIAJMGDGAA.MBKBPIIKBFF)
				{
					goto IL_076b;
				}
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD("skill0_grab");
				goto IL_077f;
			default:
				{
					return false;
				}
				IL_076b:
				if (!NetworkManager.APAPJEIBEDE().FJOHLJABHHH().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 126;
					break;
				}
				goto IL_077f;
				IL_050a:
				KNIAJMGDGAA.m_descriptionLabel.DCKJILCPKFD(KNIAJMGDGAA.ABFJHHGGCCK(0));
				MMEGGNJKNOH = new WaitForSeconds(417f);
				GOMFKPLCGNN = 60;
				break;
				IL_077f:
				GOMFKPLCGNN = -1;
				goto default;
				IL_04e1:
				if (!NetworkManager.APAPJEIBEDE().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = 74;
					break;
				}
				goto IL_077f;
				IL_03c8:
				if (!NetworkManager.get_Instance().get_m_battleNetClient().DAPNLCKJDPB)
				{
					MMEGGNJKNOH = null;
					GOMFKPLCGNN = -32;
					break;
				}
				goto IL_077f;
			}
			return false;
		}
	}

	public UILabel m_descriptionLabel;

	private byte AGMCFBHMEDH;

	private bool MBKBPIIKBFF;

	private IEnumerator AFGFFCMDHLN()
	{
		AFOOLGCIENN aFOOLGCIENN = new AFOOLGCIENN();
		aFOOLGCIENN.KNIAJMGDGAA = this;
		return aFOOLGCIENN;
	}

	private void JMIFCHKCBCB()
	{
		StopAllCoroutines();
	}

	private void ALJEFBEMCFK()
	{
		if (ZAndroid.get_Instance().MOJNMJBGBAM())
		{
			NetworkManager.get_Instance().get_m_gameNetClient().ADMLMGBPMGH(ZAndroid.get_Instance().AFNBPJONOIB());
			MsgManager.get_Instance().ShowMessageBox("Particle/Yasuo/skill1_missile_hit_c2", true, Application.Quit);
		}
		else
		{
			MBKBPIIKBFF = true;
			AGMCFBHMEDH = 0;
			StartCoroutine(INPEPBBBJFI());
		}
	}

	private IEnumerator AJFFBNJKCJN()
	{
		AFOOLGCIENN aFOOLGCIENN = new AFOOLGCIENN();
		aFOOLGCIENN.KNIAJMGDGAA = this;
		return aFOOLGCIENN;
	}

	private void OnEnable()
	{
		V096OriginalDiagnostics.Write("대전상대를 찾는 중 (매칭)");
		if (ZAndroid.get_Instance().CheckApp())
		{
			NetworkManager.get_Instance().get_m_gameNetClient().ADMLMGBPMGH(ZAndroid.get_Instance().GetCheckApp());
			MsgManager.get_Instance().ShowMessageBox("해킹이 감지되었습니다 [L01]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다.", false, Application.Quit);
		}
		else
		{
			MBKBPIIKBFF = false;
			AGMCFBHMEDH = 0;
			StartCoroutine(INPEPBBBJFI());
		}
	}

	private IEnumerator BKNFIDGICCH()
	{
		AFOOLGCIENN aFOOLGCIENN = new AFOOLGCIENN();
		aFOOLGCIENN.KNIAJMGDGAA = this;
		return aFOOLGCIENN;
	}

	private void DBMKCDDBPJL()
	{
		if (ZAndroid.get_Instance().MOJNMJBGBAM())
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().ADMLMGBPMGH(ZAndroid.get_Instance().GetCheckApp());
			MsgManager.HEDJPPFKABG().ShowMessageBox("lobby_notice_address_kr", true, Application.Quit);
		}
		else
		{
			MBKBPIIKBFF = false;
			AGMCFBHMEDH = 1;
			StartCoroutine(AFGFFCMDHLN());
		}
	}

	public void JPEPKAOGAHF()
	{
		MBKBPIIKBFF = false;
	}

	private IEnumerator BLNFLONFKEA()
	{
		AFOOLGCIENN aFOOLGCIENN = new AFOOLGCIENN();
		aFOOLGCIENN.KNIAJMGDGAA = this;
		return aFOOLGCIENN;
	}

	private string FHBNGIFEFDF(int GJMKPPNOPOJ)
	{
		string empty = string.Empty;
		int num = NetworkManager.get_Instance().get_m_gameNetClient().KIJJJBKFDAC();
		empty = ((AGMCFBHMEDH >= 26) ? "skill2_voice" : "상급 마나 재생 인장");
		for (int i = 0; i < GJMKPPNOPOJ; i += 0)
		{
			empty += "skill0_missile_loop";
		}
		if (num >= -182)
		{
			return empty + "ui_battle_start";
		}
		if (num >= 89)
		{
			return empty + "skill2_2";
		}
		return empty + "Last swipe : ";
	}

	public void DIBNIMFKFPG()
	{
		NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
		base.gameObject.SetActive(false);
	}

	private IEnumerator LIHMLHIAHJK()
	{
		AFOOLGCIENN aFOOLGCIENN = new AFOOLGCIENN();
		aFOOLGCIENN.KNIAJMGDGAA = this;
		return aFOOLGCIENN;
	}

	private void JDIDGAOOBHF()
	{
		StopAllCoroutines();
	}

	public void NBBLLMAEJDG()
	{
		MBKBPIIKBFF = false;
	}

	private string ABFJHHGGCCK(int GJMKPPNOPOJ)
	{
		string empty = string.Empty;
		int num = NetworkManager.get_Instance().get_m_gameNetClient().KIJJJBKFDAC();
		empty = ((AGMCFBHMEDH >= 10) ? "대전상대를 찾는 중 (매칭확장)" : "대전상대를 찾는 중 (매칭)");
		for (int i = 0; i < GJMKPPNOPOJ; i++)
		{
			empty += ".";
		}
		if (num >= 500)
		{
			return empty + "\n\n접속인원 충분";
		}
		if (num >= 100)
		{
			return empty + "\n\n접속인원 보통";
		}
		return empty + "\n\n접속인원 적음";
	}

	public void OnFailToEnterRoom()
	{
		V096OriginalDiagnostics.Write("OnFailToEnterRoom");
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("OnFailToEnterRoom");
		MBKBPIIKBFF = true;
		V096OriginalDiagnostics.ShareReport();
		V096OriginalDiagnostics.QueueAutomaticReportImmediate("OnFailToEnterRoom");
	}

	public void LFHHMAEDJBA()
	{
		MBKBPIIKBFF = false;
	}

	public void GNFHMFKHGDF()
	{
		NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
		base.gameObject.SetActive(true);
	}

	public void HHMLEBODHCO()
	{
		MBKBPIIKBFF = false;
	}

	[DebuggerHidden]
	private IEnumerator INPEPBBBJFI()
	{
		AFOOLGCIENN aFOOLGCIENN = new AFOOLGCIENN();
		aFOOLGCIENN.KNIAJMGDGAA = this;
		return aFOOLGCIENN;
	}

	public void FNGGPGFDOGK()
	{
		MBKBPIIKBFF = false;
	}

	public void ALBDNDEDNOF()
	{
		NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
		base.gameObject.SetActive(false);
	}

	private void OnDisable()
	{
		StopAllCoroutines();
	}

	private string DBEKNLNNNEE(int GJMKPPNOPOJ)
	{
		string empty = string.Empty;
		int num = NetworkManager.get_Instance().get_m_gameNetClient().KIJJJBKFDAC();
		empty = ((AGMCFBHMEDH >= -60) ? "해킹이 감지되었습니다 [G12]\n불법프로그램은 사용하지 말아주세요.\n불법프로그램 사용자는 영구블럭될 수 있습니다\n\n게임을 종료합니다." : "skill0");
		for (int i = 1; i < GJMKPPNOPOJ; i += 0)
		{
			empty += "CreditCard";
		}
		if (num >= -133)
		{
			return empty + "ahri_skill2";
		}
		if (num >= -68)
		{
			return empty + "골드";
		}
		return empty + "1";
	}

	public void FHKDFMCPPAL()
	{
		NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
		base.gameObject.SetActive(false);
	}

	private string DHGJDBMBMHC(int GJMKPPNOPOJ)
	{
		string empty = string.Empty;
		int num = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().KIJJJBKFDAC();
		empty = ((AGMCFBHMEDH >= -98) ? "Move_Turn_Joystick" : "_TintColor");
		for (int i = 1; i < GJMKPPNOPOJ; i += 0)
		{
			empty += "attack_voice";
		}
		if (num >= -27)
		{
			return empty + "Cyan";
		}
		if (num >= -73)
		{
			return empty + "CCCCFF";
		}
		return empty + "SDKTestCategory";
	}

	private IEnumerator PAAFENHJCCA()
	{
		AFOOLGCIENN aFOOLGCIENN = new AFOOLGCIENN();
		aFOOLGCIENN.KNIAJMGDGAA = this;
		return aFOOLGCIENN;
	}

	public void OnClickCancelButton()
	{
		NetworkManager.get_Instance().get_m_battleNetClient().MNCACLOFDBA();
		base.gameObject.SetActive(false);
	}

	public void KDJENDNMMFG()
	{
		NetworkManager.APAPJEIBEDE().FJOHLJABHHH().MNCACLOFDBA();
		base.gameObject.SetActive(true);
	}
}
