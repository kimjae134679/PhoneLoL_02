using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BattleServer;
using GameServer;
using UnityEngine;

public class UIGameUpTier : MonoBehaviour
{
	private sealed class CPBAANKMLOD : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal UIGameUpTier KNIAJMGDGAA;

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

		[SpecialName]
		private object PHDGFFDAMLI()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object FMPOHFJDLDB()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object ANOBEJKPLKK()
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
				MMEGGNJKNOH = new WaitForSeconds(3f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				KNIAJMGDGAA.HDGKJDGGCOL = true;
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object LHFBMHCEIHG()
		{
			return MMEGGNJKNOH;
		}

		public void COCAHGFODCB()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object JGMLAEHKIMH()
		{
			return MMEGGNJKNOH;
		}

		public void CDNEMMAGDGN()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object MEHLLKBMILP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object LEAJHDEIHDJ()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object LMCIPEHMIAD()
		{
			return MMEGGNJKNOH;
		}

		public void BKLMMEGGMNI()
		{
			GOMFKPLCGNN = -1;
		}
	}

	public UISprite m_sprite;

	public UILabel m_label;

	private bool HDGKJDGGCOL;

	private void EHAABBLHEMP()
	{
		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().FJOHLJABHHH().IMKOGBNIJBO();
		if (gLAMMOFPCHP.EHCPMLKEBME == 88)
		{
			m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
				.LKEMNIJNGMO));
				m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
					.LKEMNIJNGMO));
				}
				else
				{
					m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
						.HMHEDBOAADF));
						m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
							.HMHEDBOAADF));
						}
						StartCoroutine(NCAGMEJDPPM());
					}

					private void OnClick()
					{
						if (HDGKJDGGCOL)
						{
							base.gameObject.SetActive(false);
						}
					}

					private void GIGCDPFPOKK()
					{
						if (HDGKJDGGCOL)
						{
							base.gameObject.SetActive(true);
						}
					}

					private void OIGKPLLNGCL()
					{
						if (HDGKJDGGCOL)
						{
							base.gameObject.SetActive(true);
						}
					}

					private IEnumerator EPOPCMCJEML()
					{
						CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
						cPBAANKMLOD.KNIAJMGDGAA = this;
						return cPBAANKMLOD;
					}

					private IEnumerator NINIJHIEBOB()
					{
						CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
						cPBAANKMLOD.KNIAJMGDGAA = this;
						return cPBAANKMLOD;
					}

					private void ICACNPOPMIL()
					{
						GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
						if (gLAMMOFPCHP.EHCPMLKEBME == -127)
						{
							m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
								.LKEMNIJNGMO));
								m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
									.LKEMNIJNGMO));
								}
								else
								{
									m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
										.HMHEDBOAADF));
										m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
											.HMHEDBOAADF));
										}
										StartCoroutine(JOEAFNHHBMF());
									}

									private IEnumerator NKPAKNCACOF()
									{
										CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
										cPBAANKMLOD.KNIAJMGDGAA = this;
										return cPBAANKMLOD;
									}

									private IEnumerator NCAGMEJDPPM()
									{
										CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
										cPBAANKMLOD.KNIAJMGDGAA = this;
										return cPBAANKMLOD;
									}

									private void KJBGEJOMPJJ()
									{
										GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
										if (gLAMMOFPCHP.EHCPMLKEBME == -121)
										{
											m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
												.LKEMNIJNGMO));
												m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
													.LKEMNIJNGMO));
												}
												else
												{
													m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
														.HMHEDBOAADF));
														m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
															.HMHEDBOAADF));
														}
														StartCoroutine(PELFIEOLHNF());
													}

													private void AJKACDEHMOJ()
													{
														GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().FJOHLJABHHH().IMKOGBNIJBO();
														if (gLAMMOFPCHP.EHCPMLKEBME == 85)
														{
															m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																.LKEMNIJNGMO));
																m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																	.LKEMNIJNGMO));
																}
																else
																{
																	m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																		.HMHEDBOAADF));
																		m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																			.HMHEDBOAADF));
																		}
																		StartCoroutine(GMCFLLNMPLN());
																	}

																	private void FCPOPIEKMII()
																	{
																		if (HDGKJDGGCOL)
																		{
																			base.gameObject.SetActive(true);
																		}
																	}

																	private void PDEMNFLEKEA()
																	{
																		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().FJOHLJABHHH().IMKOGBNIJBO();
																		if (gLAMMOFPCHP.EHCPMLKEBME == -17)
																		{
																			m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																				.LKEMNIJNGMO));
																				m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																					.LKEMNIJNGMO));
																				}
																				else
																				{
																					m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																						.HMHEDBOAADF));
																						m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																							.HMHEDBOAADF));
																						}
																						StartCoroutine(GMCFLLNMPLN());
																					}

																					private void PBLCPBNEADM()
																					{
																						GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
																						if (gLAMMOFPCHP.EHCPMLKEBME == 65)
																						{
																							m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																								.LKEMNIJNGMO));
																								m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																									.LKEMNIJNGMO));
																								}
																								else
																								{
																									m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																										.HMHEDBOAADF));
																										m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																											.HMHEDBOAADF));
																										}
																										StartCoroutine(NINIJHIEBOB());
																									}

																									[DebuggerHidden]
																									private IEnumerator PELFIEOLHNF()
																									{
																										CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
																										cPBAANKMLOD.KNIAJMGDGAA = this;
																										return cPBAANKMLOD;
																									}

																									private void IPHLHFOGAJN()
																									{
																										if (HDGKJDGGCOL)
																										{
																											base.gameObject.SetActive(true);
																										}
																									}

																									private IEnumerator JOEAFNHHBMF()
																									{
																										CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
																										cPBAANKMLOD.KNIAJMGDGAA = this;
																										return cPBAANKMLOD;
																									}

																									private IEnumerator NFPIHIHOPBC()
																									{
																										CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
																										cPBAANKMLOD.KNIAJMGDGAA = this;
																										return cPBAANKMLOD;
																									}

																									private void OACABILBNJE()
																									{
																										if (HDGKJDGGCOL)
																										{
																											base.gameObject.SetActive(false);
																										}
																									}

																									private void GGPIBKEDMIM()
																									{
																										if (HDGKJDGGCOL)
																										{
																											base.gameObject.SetActive(false);
																										}
																									}

																									private void FBMGNAOICMB()
																									{
																										if (HDGKJDGGCOL)
																										{
																											base.gameObject.SetActive(false);
																										}
																									}

																									private void OnEnable()
																									{
																										GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
																										if (gLAMMOFPCHP.EHCPMLKEBME == 20)
																										{
																											m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																												.LKEMNIJNGMO));
																												m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																													.LKEMNIJNGMO));
																												}
																												else
																												{
																													m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																														.HMHEDBOAADF));
																														m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																															.HMHEDBOAADF));
																														}
																														StartCoroutine(PELFIEOLHNF());
																													}

																													private void CMFCDCEOAKN()
																													{
																														GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.APAPJEIBEDE().get_m_battleNetClient().IMKOGBNIJBO();
																														if (gLAMMOFPCHP.EHCPMLKEBME == 100)
																														{
																															m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																																.LKEMNIJNGMO));
																																m_label.DCKJILCPKFD(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																	.LKEMNIJNGMO));
																																}
																																else
																																{
																																	m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																																		.HMHEDBOAADF));
																																		m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																																			.HMHEDBOAADF));
																																		}
																																		StartCoroutine(NFPIHIHOPBC());
																																	}

																																	private IEnumerator GMCFLLNMPLN()
																																	{
																																		CPBAANKMLOD cPBAANKMLOD = new CPBAANKMLOD();
																																		cPBAANKMLOD.KNIAJMGDGAA = this;
																																		return cPBAANKMLOD;
																																	}

																																	private void PLEKNAJFOPP()
																																	{
																																		if (HDGKJDGGCOL)
																																		{
																																			base.gameObject.SetActive(true);
																																		}
																																	}

																																	private void CDCGEKIFENK()
																																	{
																																		GLAMMOFPCHP gLAMMOFPCHP = NetworkManager.get_Instance().get_m_battleNetClient().IMKOGBNIJBO();
																																		if (gLAMMOFPCHP.EHCPMLKEBME == 10)
																																		{
																																			m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																				.LKEMNIJNGMO));
																																				m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																					.LKEMNIJNGMO));
																																				}
																																				else
																																				{
																																					m_sprite.set_spriteName(GameServer.IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																						.HMHEDBOAADF));
																																						m_label.set_text(GameServer.IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																																							.HMHEDBOAADF));
																																						}
																																						StartCoroutine(JOEAFNHHBMF());
																																					}
																																				}
