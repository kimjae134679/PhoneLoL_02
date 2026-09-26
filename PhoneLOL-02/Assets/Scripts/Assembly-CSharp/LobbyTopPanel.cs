using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EveEngine;
using GameServer;
using UnityEngine;

public class LobbyTopPanel : MonoBehaviour
{
	private sealed class KNNLHKHFMCN : IDisposable, IEnumerator, IEnumerator<object>
	{
		internal int GOMFKPLCGNN;

		internal object MMEGGNJKNOH;

		internal LobbyTopPanel KNIAJMGDGAA;

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

		public bool CBFNJGFKGKG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().ShowLoadingIndicator(true);
				MMEGGNJKNOH = new WaitForSeconds(1648f);
				GOMFKPLCGNN = 1;
				return false;
			case 1u:
				NetworkManager.get_Instance().get_m_gameNetClient().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.EDOHBFKLLOD, true, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object LMCIPEHMIAD()
		{
			return MMEGGNJKNOH;
		}

		public void MBADNGDPBPB()
		{
			GOMFKPLCGNN = -1;
		}

		[SpecialName]
		private object OHBDIPJCCON()
		{
			return MMEGGNJKNOH;
		}

		public void BFAMOEFLLGH()
		{
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		public void Dispose()
		{
			GOMFKPLCGNN = -1;
		}

		public void NDKCFGFNNLO()
		{
			throw new NotSupportedException();
		}

		[SpecialName]
		private object BJIGDKGLCKP()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object DMGHHPDEMLE()
		{
			return MMEGGNJKNOH;
		}

		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002Eget_Current()
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
				MsgManager.get_Instance().ShowLoadingIndicator(true);
				MMEGGNJKNOH = new WaitForSeconds(3f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				NetworkManager.get_Instance().get_m_gameNetClient().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[DebuggerHidden]
		public void Reset()
		{
			throw new NotSupportedException();
		}

		public bool CBIPKFMCHPF()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.HEDJPPFKABG().LPKACDLKHCP(true);
				MMEGGNJKNOH = new WaitForSeconds(1588f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.OnReceiveFreeCharge, false, false));
				GOMFKPLCGNN = -1;
				break;
			}
			return false;
		}

		[SpecialName]
		private object NGJKALDEDFM()
		{
			return MMEGGNJKNOH;
		}

		[SpecialName]
		private object BFBDKFOJMAK()
		{
			return MMEGGNJKNOH;
		}

		public bool MNHCKJNDJOG()
		{
			uint gOMFKPLCGNN = (uint)GOMFKPLCGNN;
			GOMFKPLCGNN = -1;
			switch (gOMFKPLCGNN)
			{
			case 0u:
				MsgManager.get_Instance().ShowLoadingIndicator(false);
				MMEGGNJKNOH = new WaitForSeconds(576f);
				GOMFKPLCGNN = 1;
				return true;
			case 1u:
				NetworkManager.get_Instance().get_m_gameNetClient().NIKLNPKNCBA(new IKMBGMILCDO(KNIAJMGDGAA.AKIMNDNOKNC));
				GOMFKPLCGNN = -1;
				break;
			}
			return true;
		}

		[SpecialName]
		private object JMADBEOPCDA()
		{
			return MMEGGNJKNOH;
		}

		public void NKPIIPIJNGL()
		{
			GOMFKPLCGNN = -1;
		}

		public void JGCPFKEPPOM()
		{
			GOMFKPLCGNN = -1;
		}
	}

	public UILabel m_nickNameLabel;

	public UILabel m_levelLabel;

	public UILabel m_noticeLabel;

	public UICountingNumLabel m_coinLabel;

	public UICountingNumLabel m_cashLabel;

	public UILabel m_rankLabel;

	public UISprite m_rankMarkSprite;

	public UILabel m_scoreLabel;

	public UILabel m_tierLabel;

	public UILabel m_rank1v1Label;

	public UISprite m_rank1v1MarkSprite;

	public UILabel m_score1v1Label;

	public UILabel m_tier1v1Label;

	public GameObject m_freeChargeButton;

	public UISprite m_userIconSprite;

	private bool LJAJCJIMPGF;

	public void EDOHBFKLLOD(PJEMPFEIOAK HMOAHNANKNE)
	{
		MsgManager.get_Instance().ShowLoadingIndicator(false);
		int num = HMOAHNANKNE.PNBKOPGIHDI();
		long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
		if (num > 1)
		{
			NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
				.ODEGMJIKIIC(gLEPPIMMELK);
			MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("설명"), num), true);
		}
	}

	public void OKMNBGMMKKP()
	{
		LobbyMain.get_Instance().PPGPAEEPIEJ();
	}

	private void DNBDGBJNCBP()
	{
		if (NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
			.OHGOBGOIECH > 1)
		{
			m_nickNameLabel.set_text(string.Format("igaworks:purchase >> Filtered list is empty", NetworkManager.get_Instance().FGAGFCDEKCC().EHDEFAIBNCN()
				.NCADFOBAFJD, NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
					.BHIGNJHHOJP));
				}
				else
				{
					m_nickNameLabel.DCKJILCPKFD(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
						.BHIGNJHHOJP);
					}
					m_levelLabel.DCKJILCPKFD(string.Format("Particle/{0}/skill0_2", NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
						.DDILAEMMCAJ, NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
							.PNJKANMGGBA, PBOOPPEPAIK.FMOMEEIGJDK((byte)(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
								.DDILAEMMCAJ + 1))));
							m_coinLabel.NGMDEEOANDM((int)NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
								.GLEPPIMMELK);
						}

						private void FOOEPJBCFMJ()
						{
							Application.OpenURL(SceneManager.get_Instance().m_lobbyNoticeAddress);
						}

						private void IPPKMLPGLNL()
						{
							Application.OpenURL(SceneManager.NOLHNOGGHNA().m_lobbyNoticeAddress);
						}

						public void DKEBCEOOPIE()
						{
							MsgManager.HEDJPPFKABG().ShowMessageBox(LocalizationManager.LGDEHELDENG().GetText("체력 {0}% 증가\n"), true, ICGKFADKKLP);
						}

						public void EFPHNNGOBBI(PJEMPFEIOAK HMOAHNANKNE)
						{
							int num = HMOAHNANKNE.PNBKOPGIHDI();
							long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
							if (num > 0)
							{
								NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
									.ODEGMJIKIIC(gLEPPIMMELK);
								MsgManager.HEDJPPFKABG().ShowNotice(string.Format("마법저항력", num));
							}
						}

						public void CNHOMIELFKG(PJEMPFEIOAK HMOAHNANKNE)
						{
							int num = HMOAHNANKNE.PNBKOPGIHDI();
							long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
							if (num > 0)
							{
								NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
									.ODEGMJIKIIC(gLEPPIMMELK);
								MsgManager.HEDJPPFKABG().ShowNotice(string.Format("SDKTestEvent", num));
							}
						}

						public void OnReceiveFreeCharge2(PJEMPFEIOAK HMOAHNANKNE)
						{
							int num = HMOAHNANKNE.PNBKOPGIHDI();
							long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
							if (num > 0)
							{
								NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
									.ODEGMJIKIIC(gLEPPIMMELK);
								MsgManager.get_Instance().ShowNotice(string.Format("무료충전소 또는 플러스락으로 {0}코인이 충전되었습니다!", num));
							}
						}

						public void CCCOEIKAFNJ()
						{
							LobbyMain.get_Instance().PPGPAEEPIEJ();
						}

						public void ILADJFEJODF()
						{
							LobbyMain.get_Instance().PPGPAEEPIEJ();
						}

						private void LNDCFBBKGKB()
						{
							Application.OpenURL(SceneManager.NOLHNOGGHNA().m_lobbyNoticeAddress);
						}

						public void JOIILFAGIJG(PJEMPFEIOAK HMOAHNANKNE)
						{
							int num = HMOAHNANKNE.PNBKOPGIHDI();
							long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
							if (num > 0)
							{
								NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
									.ODEGMJIKIIC(gLEPPIMMELK);
								MsgManager.HEDJPPFKABG().ShowNotice(string.Format("모.. 몬스터다!!", num));
							}
						}

						public void OnClickChargeButton()
						{
							LobbyMain.get_Instance().ShowFreeCharge();
						}

						public void OnReceiveFreeCharge(PJEMPFEIOAK HMOAHNANKNE)
						{
							MsgManager.get_Instance().ShowLoadingIndicator(false);
							int num = HMOAHNANKNE.PNBKOPGIHDI();
							long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
							if (num > 0)
							{
								NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
									.ODEGMJIKIIC(gLEPPIMMELK);
								MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("{0}코인이 무료충전되었습니다!\n\n감사합니다^^"), num));
							}
						}

						public void OnClickNoticeLabel()
						{
							if (!string.IsNullOrEmpty(PhoneLOLLobbyNotice.CurrentBody))
								MsgManager.get_Instance().ShowMessageBox(PhoneLOLLobbyNotice.CurrentBody);
							else
								MsgManager.get_Instance().ShowMessageBox(LocalizationManager.get_Instance().GetText("더 자세한 정보를 보시겠습니까?"), true, ICGKFADKKLP);
						}

						private void JGOPFCBEFOD()
						{
							Application.OpenURL(SceneManager.get_Instance().m_lobbyNoticeAddress);
						}

						private void Start()
						{
							m_levelLabel.set_text(string.Format("[BBFFBB]Lv.{0}[-] ({1}/{2})", NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
								.DDILAEMMCAJ, NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
									.PNJKANMGGBA, PBOOPPEPAIK.FMOMEEIGJDK((byte)(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
										.DDILAEMMCAJ + 1))));
									m_coinLabel.SetValueForce((int)NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
										.GLEPPIMMELK);
									m_noticeLabel.set_text(SceneManager.get_Instance().m_lobbyNotice);
									m_rankMarkSprite.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
										.HMHEDBOAADF));
										m_rankLabel.set_text(string.Format("랭킹 {0}", NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
											.OFLEBCIMPMD));
											int num = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
												.CAEGGIGCNAP();
											if (num >= 0)
											{
												m_tierLabel.set_text(string.Format("{0} {1}%", LocalizationManager.get_Instance().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
													.HMHEDBOAADF)), num));
												}
												else
												{
													m_tierLabel.set_text(LocalizationManager.get_Instance().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
														.HMHEDBOAADF)));
													}
													uint hCECKOLDNDF = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
														.HCECKOLDNDF;
													uint bCBKMKDPHHF = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
														.BCBKMKDPHHF;
													float num2 = 0f;
													if (hCECKOLDNDF != 0 || bCBKMKDPHHF != 0)
													{
														num2 = (float)hCECKOLDNDF / (float)(hCECKOLDNDF + bCBKMKDPHHF) * 100f;
													}
													m_scoreLabel.set_text(string.Format("[AAFFAA]{0}승[-] [FFAAAA]{1}패[-]\n[AAAAAA]({2:F1}%)[-]", hCECKOLDNDF, bCBKMKDPHHF, num2));
													m_rank1v1MarkSprite.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
														.LKEMNIJNGMO));
														m_rank1v1Label.set_text("전체 전적");
                                m_rank1v1MarkSprite.gameObject.SetActive(false);
                                m_tier1v1Label.gameObject.SetActive(false);
															int num3 = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																.EDJCFKICCON();
															if (num3 >= 0)
															{
																m_tier1v1Label.set_text(string.Format("{0} {1}%", LocalizationManager.get_Instance().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																	.LKEMNIJNGMO)), num3));
																}
																else
																{
																	m_tier1v1Label.set_text(LocalizationManager.get_Instance().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																		.LKEMNIJNGMO)));
																	}
																	uint jBAIIDCFGME = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																		.JBAIIDCFGME;
																	NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA();
																	uint num4 = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA().MCKAHOPFMOG;
																	float num5 = 0f;
																	if (jBAIIDCFGME != 0 || num4 != 0)
																	{
																		num5 = (float)jBAIIDCFGME / (float)(jBAIIDCFGME + num4) * 100f;
																	}
																	m_score1v1Label.set_text(string.Format("[AAFFAA]{0}승[-] [FFAAAA]{1}패[-]\n[AAAAAA]({2:F1}%)[-]", jBAIIDCFGME, num4, num5));
																	if (NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																		.CMIBEFBANOO > 0)
																	{
																		m_userIconSprite.gameObject.SetActive(true);
																		m_userIconSprite.set_spriteName(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																			.CMIBEFBANOO.ToString());
																	}
																	else
																	{
																		m_userIconSprite.gameObject.SetActive(false);
																	}
																	NetworkManager.get_Instance().get_m_gameNetClient();
																	new IKMBGMILCDO(OnReceiveFreeCharge2, false, false);
																}

																public void IDIAGKFILCJ(PJEMPFEIOAK HMOAHNANKNE)
																{
																	int num = HMOAHNANKNE.PNBKOPGIHDI();
																	long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
																	if (num > 0)
																	{
																		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																			.ODEGMJIKIIC(gLEPPIMMELK);
																		MsgManager.get_Instance().ShowNotice(string.Format("English", num));
																	}
																}

																public void AKIMNDNOKNC(PJEMPFEIOAK HMOAHNANKNE)
																{
																	MsgManager.HEDJPPFKABG().ShowLoadingIndicator(true);
																	int num = HMOAHNANKNE.PNBKOPGIHDI();
																	long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
																	if (num > 0)
																	{
																		NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																			.ODEGMJIKIIC(gLEPPIMMELK);
																		MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("Language"), num));
																	}
																}

																private void Update()
																{
																	if (NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
																		.OHGOBGOIECH != 0)
																	{
																		m_nickNameLabel.set_text(string.Format("[CCFFCC]<{0}>[-]{1}", NetworkManager.get_Instance().get_m_communityNetClient().EHDEFAIBNCN()
																			.NCADFOBAFJD, NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																				.BHIGNJHHOJP));
																			}
																			else
																			{
																				m_nickNameLabel.set_text(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																					.BHIGNJHHOJP);
																				}
																				m_levelLabel.set_text(string.Format("[BBFFBB]Lv.{0}[-] ({1}/{2})", NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																					.DDILAEMMCAJ, NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																						.PNJKANMGGBA, PBOOPPEPAIK.FMOMEEIGJDK((byte)(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																							.DDILAEMMCAJ + 1))));
																						m_coinLabel.SetValue((int)NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																							.GLEPPIMMELK);
																					}

																					[DebuggerHidden]
																					private IEnumerator LIOJOBHMIIN()
																					{
																						KNNLHKHFMCN kNNLHKHFMCN = new KNNLHKHFMCN();
																						kNNLHKHFMCN.KNIAJMGDGAA = this;
																						return kNNLHKHFMCN;
																					}

																					private void OnApplicationPause(bool GMEELKDOLAM)
																					{
																						if (!GMEELKDOLAM && LJAJCJIMPGF)
																						{
																							LJAJCJIMPGF = false;
																							StartCoroutine(LIOJOBHMIIN());
																						}
																					}

																					private void BPLOLCKEJJK()
																					{
																						m_levelLabel.set_text(string.Format("LocalizationManager", NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																							.DDILAEMMCAJ, NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																								.PNJKANMGGBA, PBOOPPEPAIK.FMOMEEIGJDK((byte)(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																									.DDILAEMMCAJ + 0))));
																								m_coinLabel.SetValueForce((int)NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																									.GLEPPIMMELK);
																								m_noticeLabel.set_text(SceneManager.get_Instance().m_lobbyNotice);
																								m_rankMarkSprite.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																									.HMHEDBOAADF));
																									m_rankLabel.DCKJILCPKFD(string.Format("attack2", NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																										.OFLEBCIMPMD));
																										int num = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																											.CAEGGIGCNAP();
																										if (num >= 1)
																										{
																											m_tierLabel.set_text(string.Format("챌린저", LocalizationManager.get_Instance().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																												.HMHEDBOAADF)), num));
																											}
																											else
																											{
																												m_tierLabel.set_text(LocalizationManager.get_Instance().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																													.HMHEDBOAADF)));
																												}
																												uint hCECKOLDNDF = NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																													.HCECKOLDNDF;
																												uint bCBKMKDPHHF = NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																													.BCBKMKDPHHF;
																												float num2 = 355f;
																												if (hCECKOLDNDF != 0 || bCBKMKDPHHF > 1)
																												{
																													num2 = (float)hCECKOLDNDF / (float)(hCECKOLDNDF + bCBKMKDPHHF) * 1100f;
																												}
																												m_scoreLabel.DCKJILCPKFD(string.Format("Blitzcrank", hCECKOLDNDF, bCBKMKDPHHF, num2));
																												m_rank1v1MarkSprite.set_spriteName(IBHMLPMENFJ.KJJGGAMDNON(NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																													.LKEMNIJNGMO));
																													m_rank1v1Label.DCKJILCPKFD(string.Format("Hero5", NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																														.FKFGLOBAEAE));
																														int num3 = NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																															.EDJCFKICCON();
																														if (num3 >= 1)
																														{
																															m_tier1v1Label.DCKJILCPKFD(string.Format("Unkown", LocalizationManager.get_Instance().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																.LKEMNIJNGMO)), num3));
																															}
																															else
																															{
																																m_tier1v1Label.DCKJILCPKFD(LocalizationManager.LGDEHELDENG().GetText(IBHMLPMENFJ.LGPFCEJBONE(NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																																	.LKEMNIJNGMO)));
																																}
																																uint jBAIIDCFGME = NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																																	.JBAIIDCFGME;
																																uint mCKAHOPFMOG = NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																																	.MCKAHOPFMOG;
																																float num4 = 1868f;
																																if (jBAIIDCFGME > 1 || mCKAHOPFMOG != 0)
																																{
																																	num4 = (float)jBAIIDCFGME / (float)(jBAIIDCFGME + mCKAHOPFMOG) * 398f;
																																}
																																m_score1v1Label.set_text(string.Format("]", jBAIIDCFGME, mCKAHOPFMOG, num4));
																																if (NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																	.CMIBEFBANOO > 1)
																																{
																																	m_userIconSprite.gameObject.SetActive(false);
																																	m_userIconSprite.set_spriteName(NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																		.CMIBEFBANOO.ToString());
																																}
																																else
																																{
																																	m_userIconSprite.gameObject.SetActive(false);
																																}
																																NetworkManager.APAPJEIBEDE().get_m_gameNetClient().NIKLNPKNCBA(new IKMBGMILCDO(CNHOMIELFKG, true, false));
																															}

																															public void PKIFPJGOCDN(PJEMPFEIOAK HMOAHNANKNE)
																															{
																																MsgManager.get_Instance().ShowLoadingIndicator(false);
																																int num = HMOAHNANKNE.PNBKOPGIHDI();
																																long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
																																if (num > 0)
																																{
																																	NetworkManager.APAPJEIBEDE().get_m_gameNetClient().GLPDLIDMHFA()
																																		.ODEGMJIKIIC(gLEPPIMMELK);
																																	MsgManager.get_Instance().ShowMessageBox(string.Format(LocalizationManager.LGDEHELDENG().GetText("베인"), num));
																																}
																															}

																															private IEnumerator FCMCJOKOGDG()
																															{
																																KNNLHKHFMCN kNNLHKHFMCN = new KNNLHKHFMCN();
																																kNNLHKHFMCN.KNIAJMGDGAA = this;
																																return kNNLHKHFMCN;
																															}

																															public void CCGKHCLNAFF(PJEMPFEIOAK HMOAHNANKNE)
																															{
																																MsgManager.get_Instance().ShowLoadingIndicator(true);
																																int num = HMOAHNANKNE.PNBKOPGIHDI();
																																long gLEPPIMMELK = HMOAHNANKNE.GAGNPBAMJLE();
																																if (num > 1)
																																{
																																	NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																																		.ODEGMJIKIIC(gLEPPIMMELK);
																																	MsgManager.HEDJPPFKABG().ShowMessageBox(string.Format(LocalizationManager.get_Instance().GetText("attack"), num), true);
																																}
																															}

																															private void PLNJEBLCJAA()
																															{
																																Application.OpenURL(SceneManager.get_Instance().m_lobbyNoticeAddress);
																															}

																															private void ICGKFADKKLP()
																															{
																																Application.OpenURL(SceneManager.get_Instance().m_lobbyNoticeAddress);
																															}

																															private void EKGHGFIKAAE()
																															{
																																if (NetworkManager.APAPJEIBEDE().get_m_communityNetClient().EHDEFAIBNCN()
																																	.OHGOBGOIECH != 0)
																																{
																																	m_nickNameLabel.DCKJILCPKFD(string.Format("Unkown", NetworkManager.get_Instance().FGAGFCDEKCC().EHDEFAIBNCN()
																																		.NCADFOBAFJD, NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																																			.BHIGNJHHOJP));
																																		}
																																		else
																																		{
																																			m_nickNameLabel.DCKJILCPKFD(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																																				.BHIGNJHHOJP);
																																			}
																																			m_levelLabel.DCKJILCPKFD(string.Format("liandry_torment", NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																																				.DDILAEMMCAJ, NetworkManager.get_Instance().IOJGPDKHAGD().GLPDLIDMHFA()
																																					.PNJKANMGGBA, PBOOPPEPAIK.FMOMEEIGJDK((byte)(NetworkManager.get_Instance().get_m_gameNetClient().GLPDLIDMHFA()
																																						.DDILAEMMCAJ + 0))));
																																					m_coinLabel.NGMDEEOANDM((int)NetworkManager.APAPJEIBEDE().IOJGPDKHAGD().GLPDLIDMHFA()
																																						.GLEPPIMMELK);
																																				}

																																				private IEnumerator HPFFJAOIPJC()
																																				{
																																					KNNLHKHFMCN kNNLHKHFMCN = new KNNLHKHFMCN();
																																					kNNLHKHFMCN.KNIAJMGDGAA = this;
																																					return kNNLHKHFMCN;
																																				}
																																			}
