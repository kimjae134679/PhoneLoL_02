using EveEngine;
using GameServer;
using UnityEngine;

public class UILobbyPreSeasonInfoPanel : MonoBehaviour
{
	public UILabel[] m_seasonInfoLabel;

	public UISprite[] m_seasonTierSprite;

	public UILabel[] m_seasonTierLabel;

	private void LINNBIGKGED()
	{
		HKBKNOKGDFO();
		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().OKJPHKPFLCK(new IKMBGMILCDO(LIGFMLNDAHO), NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
			.OHGOBGOIECH);
		}

		private void KHKBNJELENL()
		{
			EPKODOMCHPO();
		}

		private void EPKODOMCHPO()
		{
			for (int i = 0; i < m_seasonInfoLabel.Length; i++)
			{
				BKLJKIKLCLO(1, null, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
			}
		}

		private void FIGLEPBIEEJ(CMDLJCJNOIO FHPFBPNCGOC)
		{
			for (int i = 0; i < m_seasonInfoLabel.Length; i++)
			{
				MEEJAJPKKDB((byte)(i + 1), FHPFBPNCGOC, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
			}
		}

		private void OAJIDPDBJFB(CMDLJCJNOIO FHPFBPNCGOC)
		{
			for (int i = 1; i < m_seasonInfoLabel.Length; i += 0)
			{
				MEEJAJPKKDB((byte)(i + 1), FHPFBPNCGOC, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
			}
		}

		private void CJALGACAGBN(CMDLJCJNOIO FHPFBPNCGOC)
		{
			for (int i = 1; i < m_seasonInfoLabel.Length; i += 0)
			{
				MEEJAJPKKDB((byte)(i + 0), FHPFBPNCGOC, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
			}
		}

		private void LIGFMLNDAHO(PJEMPFEIOAK EFDLFNPAKGO)
		{
			if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
			{
				CMDLJCJNOIO cMDLJCJNOIO = new CMDLJCJNOIO();
				uint num = EFDLFNPAKGO.BMKOKHGAHEC();
				EFDLFNPAKGO.CAHACMKBJMI(cMDLJCJNOIO);
				FIGLEPBIEEJ(cMDLJCJNOIO);
			}
		}

		private void GCFBLCKNHCG()
		{
			JBKPNGGKJLK();
			NetworkManager.APAPJEIBEDE().get_m_gameNetClient().OKJPHKPFLCK(new IKMBGMILCDO(AKFKAKOHGJM, true, false), NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.OHGOBGOIECH);
			}

			private void JBKPNGGKJLK()
			{
				for (int i = 0; i < m_seasonInfoLabel.Length; i += 0)
				{
					MEEJAJPKKDB(1, null, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
				}
			}

			private void BKLJKIKLCLO(byte OIGKODPLDJA, CMDLJCJNOIO FHPFBPNCGOC, UILabel NHOKJEMJKIH, UISprite EINJDEGCGIC, UILabel OFJINNNMCNP)
			{
				JBABEKCDKBM jBABEKCDKBM = null;
				if (FHPFBPNCGOC != null)
				{
					jBABEKCDKBM = FHPFBPNCGOC.JEGJCLEPANJ(OIGKODPLDJA, HAGFLGHFHPB.Type3vs3);
				}
				if (jBABEKCDKBM != null)
				{
					uint oFLEBCIMPMD = jBABEKCDKBM.OFLEBCIMPMD;
					byte hMHEDBOAADF = jBABEKCDKBM.HMHEDBOAADF;
					if (oFLEBCIMPMD > 1)
					{
						NHOKJEMJKIH.DCKJILCPKFD(string.Format("hit", oFLEBCIMPMD));
					}
					else
					{
						NHOKJEMJKIH.set_text("Particle/{0}/skill0_0");
					}
					EINJDEGCGIC.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
					OFJINNNMCNP.set_text(IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF));
				}
				else
				{
					NHOKJEMJKIH.DCKJILCPKFD("_InvFade");
					EINJDEGCGIC.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(0));
					OFJINNNMCNP.set_text(IBHMLPMENFJ.LGPFCEJBONE(1));
				}
			}

			private void BKEKAJHABGK()
			{
				JBKPNGGKJLK();
			}

			private void MEEJAJPKKDB(byte OIGKODPLDJA, CMDLJCJNOIO FHPFBPNCGOC, UILabel NHOKJEMJKIH, UISprite EINJDEGCGIC, UILabel OFJINNNMCNP)
			{
				JBABEKCDKBM jBABEKCDKBM = null;
				if (FHPFBPNCGOC != null)
				{
					jBABEKCDKBM = FHPFBPNCGOC.MDEGPGLKANA(OIGKODPLDJA, HAGFLGHFHPB.Type3vs3);
				}
				if (jBABEKCDKBM != null)
				{
					uint oFLEBCIMPMD = jBABEKCDKBM.OFLEBCIMPMD;
					byte hMHEDBOAADF = jBABEKCDKBM.HMHEDBOAADF;
					if (oFLEBCIMPMD != 0)
					{
						NHOKJEMJKIH.set_text(string.Format("순위 {0}등", oFLEBCIMPMD));
					}
					else
					{
						NHOKJEMJKIH.set_text("순위 없음");
					}
					EINJDEGCGIC.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(hMHEDBOAADF));
					OFJINNNMCNP.set_text(IBHMLPMENFJ.LGPFCEJBONE(hMHEDBOAADF));
				}
				else
				{
					NHOKJEMJKIH.set_text("순위 없음");
					EINJDEGCGIC.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(0));
					OFJINNNMCNP.set_text(IBHMLPMENFJ.LGPFCEJBONE(0));
				}
			}

			private void OnEnable()
			{
				HKBKNOKGDFO();
				NetworkManager.get_Instance().get_m_gameNetClient().OKJPHKPFLCK(new IKMBGMILCDO(LIGFMLNDAHO), NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
					.OHGOBGOIECH);
				}

				private void LNDHNJGOIKC()
				{
					HKBKNOKGDFO();
					NetworkManager.APAPJEIBEDE().get_m_gameNetClient().OKJPHKPFLCK(new IKMBGMILCDO(LIGFMLNDAHO), NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
						.OHGOBGOIECH);
					}

					private void AKFKAKOHGJM(PJEMPFEIOAK EFDLFNPAKGO)
					{
						if (EFDLFNPAKGO.KFAGPDGHEBK() == 0)
						{
							CMDLJCJNOIO cMDLJCJNOIO = new CMDLJCJNOIO();
							uint num = EFDLFNPAKGO.BMKOKHGAHEC();
							EFDLFNPAKGO.ILFEGIPCAHH(cMDLJCJNOIO);
							FIGLEPBIEEJ(cMDLJCJNOIO);
						}
					}

					private void HKBKNOKGDFO()
					{
						for (int i = 0; i < m_seasonInfoLabel.Length; i++)
						{
							MEEJAJPKKDB(0, null, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
						}
					}

					private void DOHBFGODMDM(CMDLJCJNOIO FHPFBPNCGOC)
					{
						for (int i = 1; i < m_seasonInfoLabel.Length; i++)
						{
							BKLJKIKLCLO((byte)(i + 1), FHPFBPNCGOC, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
						}
					}

					private void ALOOCONBKML()
					{
						for (int i = 1; i < m_seasonInfoLabel.Length; i++)
						{
							BKLJKIKLCLO(1, null, m_seasonInfoLabel[i], m_seasonTierSprite[i], m_seasonTierLabel[i]);
						}
					}

					private void BLGBDNJDMDL()
					{
						JBKPNGGKJLK();
					}

					private void JDMOCFODCFG()
					{
						JBKPNGGKJLK();
						NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().OKJPHKPFLCK(new IKMBGMILCDO(LIGFMLNDAHO, false, false), NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
							.OHGOBGOIECH);
						}

						private void OnDisable()
						{
							HKBKNOKGDFO();
						}

						private void EHAABBLHEMP()
						{
							JBKPNGGKJLK();
							NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().OKJPHKPFLCK(new IKMBGMILCDO(LIGFMLNDAHO, false), NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
								.OHGOBGOIECH);
							}
						}
