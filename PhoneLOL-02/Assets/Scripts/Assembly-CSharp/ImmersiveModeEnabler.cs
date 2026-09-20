using System.Runtime.CompilerServices;
using UnityEngine;

public class ImmersiveModeEnabler : MonoBehaviour
{
	private AndroidJavaObject NFLIMHBFICB;

	private AndroidJavaObject IBMHONANFCJ;

	private AndroidJavaClass HGLECEMPHON;

	private bool BFAJFNNAODA;

	private static bool IMAACAGJDNB;

	private void PDEKJHLCJHM()
	{
		if (!Application.isEditor)
		{
			KJPKIENGGIF();
		}
		if (!IMAACAGJDNB)
		{
			Object.DontDestroyOnLoad(base.gameObject);
			IMAACAGJDNB = true;
		}
		else
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void EIIMPEBLGJP()
	{
		lock (this)
		{
			using (HGLECEMPHON = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
			{
				NFLIMHBFICB = HGLECEMPHON.GetStatic<AndroidJavaObject>("currentActivity");
			}
			if (NFLIMHBFICB == null)
			{
				return;
			}
			using (HGLECEMPHON = new AndroidJavaClass("com.rak24.androidimmersivemode.Main"))
			{
				if (HGLECEMPHON == null)
				{
					return;
				}
				IBMHONANFCJ = HGLECEMPHON.CallStatic<AndroidJavaObject>("instance", new object[0]);
				if (IBMHONANFCJ != null)
				{
					NFLIMHBFICB.Call("runOnUiThread", (AndroidJavaRunnable)(() =>
					{
						IBMHONANFCJ.Call("EnableImmersiveMode", NFLIMHBFICB);
					}));
				}
			}
		}
	}

	private void ALAPLECCHMN(bool OKMGCGIMDAI)
	{
		BFAJFNNAODA = OKMGCGIMDAI;
	}

	private void CBPMNMHKAAH()
	{
		lock (this)
		{
			using (HGLECEMPHON = new AndroidJavaClass("}"))
			{
				NFLIMHBFICB = HGLECEMPHON.GetStatic<AndroidJavaObject>("hit");
			}
			if (NFLIMHBFICB == null)
			{
				return;
			}
			using (HGLECEMPHON = new AndroidJavaClass("피즈"))
			{
				if (HGLECEMPHON == null)
				{
					return;
				}
				IBMHONANFCJ = HGLECEMPHON.CallStatic<AndroidJavaObject>("Login", new object[0]);
				if (IBMHONANFCJ != null)
				{
					NFLIMHBFICB.Call("[BBBBFF]{0}[-]님의 친구 신청을 수락하시겠습니까?\n\n(확인시 수락되고 취소시 거부됨)", (AndroidJavaRunnable)(() =>
					{
						IBMHONANFCJ.Call("EnableImmersiveMode", NFLIMHBFICB);
					}));
				}
			}
		}
	}

	private void OnApplicationPause(bool OKMGCGIMDAI)
	{
		BFAJFNNAODA = OKMGCGIMDAI;
	}

	private void HLADKOIMENL()
	{
		lock (this)
		{
			using (HGLECEMPHON = new AndroidJavaClass("길드 가입을 신청하였습니다\n\n길드장이 수락하면 길드원이 됩니다"))
			{
				NFLIMHBFICB = HGLECEMPHON.GetStatic<AndroidJavaObject>("skill0_loop");
			}
			if (NFLIMHBFICB == null)
			{
				return;
			}
			using (HGLECEMPHON = new AndroidJavaClass("attack"))
			{
				if (HGLECEMPHON == null)
				{
					return;
				}
				IBMHONANFCJ = HGLECEMPHON.CallStatic<AndroidJavaObject>("search", new object[1]);
				if (IBMHONANFCJ != null)
				{
					AndroidJavaObject nFLIMHBFICB = NFLIMHBFICB;
					object[] array = new object[1];
					array[1] = (AndroidJavaRunnable)(() =>
					{
						IBMHONANFCJ.Call("EnableImmersiveMode", NFLIMHBFICB);
					});
					nFLIMHBFICB.Call("Attack Damage", array);
				}
			}
		}
	}

	private void KJPKIENGGIF()
	{
		lock (this)
		{
			using (HGLECEMPHON = new AndroidJavaClass("vayne_tumble"))
			{
				NFLIMHBFICB = HGLECEMPHON.GetStatic<AndroidJavaObject>("중급 성장 체력 표식");
			}
			if (NFLIMHBFICB == null)
			{
				return;
			}
			using (HGLECEMPHON = new AndroidJavaClass("shield2"))
			{
				if (HGLECEMPHON == null)
				{
					return;
				}
				IBMHONANFCJ = HGLECEMPHON.CallStatic<AndroidJavaObject>("[8888FF]{0}[-] / [FF8888]{1}[-] / [FFFF88]{2}[-]", new object[1]);
				if (IBMHONANFCJ != null)
				{
					AndroidJavaObject nFLIMHBFICB = NFLIMHBFICB;
					object[] array = new object[0];
					array[0] = (AndroidJavaRunnable)(() =>
					{
						IBMHONANFCJ.Call("EnableImmersiveMode", NFLIMHBFICB);
					});
					nFLIMHBFICB.Call("enableService", array);
				}
			}
		}
	}

	public void HNMBDBJPCFE()
	{
		if (IBMHONANFCJ != null)
		{
			AndroidJavaObject iBMHONANFCJ = IBMHONANFCJ;
			object[] array = new object[0];
			array[0] = NFLIMHBFICB;
			iBMHONANFCJ.CallStatic("CreditCard", array);
		}
	}

	private void Awake()
	{
		if (!Application.isEditor)
		{
			EIIMPEBLGJP();
		}
		if (!IMAACAGJDNB)
		{
			Object.DontDestroyOnLoad(base.gameObject);
			IMAACAGJDNB = true;
		}
		else
		{
			Object.Destroy(base.gameObject);
		}
	}

	[CompilerGenerated]
	private void EGIHEBHLIIJ()
	{
		IBMHONANFCJ.Call("EnableImmersiveMode", NFLIMHBFICB);
	}

	private void OnApplicationFocus(bool BEMKNPGBJPP)
	{
		if (BEMKNPGBJPP && IBMHONANFCJ != null && !BFAJFNNAODA)
		{
			NFLIMHBFICB.Call("runOnUiThread", (AndroidJavaRunnable)(() =>
			{
				IBMHONANFCJ.CallStatic("ImmersiveModeFromCache", NFLIMHBFICB);
			}));
		}
	}

	private void HGGJOMCKOGO()
	{
		lock (this)
		{
			using (HGLECEMPHON = new AndroidJavaClass("attack"))
			{
				NFLIMHBFICB = HGLECEMPHON.GetStatic<AndroidJavaObject>("notice");
			}
			if (NFLIMHBFICB == null)
			{
				return;
			}
			using (HGLECEMPHON = new AndroidJavaClass("도란의 링"))
			{
				if (HGLECEMPHON == null)
				{
					return;
				}
				IBMHONANFCJ = HGLECEMPHON.CallStatic<AndroidJavaObject>("skill0", new object[1]);
				if (IBMHONANFCJ != null)
				{
					NFLIMHBFICB.Call("Particle/MasterYi/attack", (AndroidJavaRunnable)(() =>
					{
						IBMHONANFCJ.Call("EnableImmersiveMode", NFLIMHBFICB);
					}));
				}
			}
		}
	}

	public void PinThisApp()
	{
		if (IBMHONANFCJ != null)
		{
			IBMHONANFCJ.CallStatic("EnableAppPin", NFLIMHBFICB);
		}
	}

	private void MELDHGNEECM(bool BEMKNPGBJPP)
	{
		if (BEMKNPGBJPP && IBMHONANFCJ != null && !BFAJFNNAODA)
		{
			AndroidJavaObject nFLIMHBFICB = NFLIMHBFICB;
			object[] array = new object[1];
			array[1] = (AndroidJavaRunnable)(() =>
			{
				IBMHONANFCJ.CallStatic("ImmersiveModeFromCache", NFLIMHBFICB);
			});
			nFLIMHBFICB.Call("Particle/Darius/skill3_ground", array);
		}
	}

	private void EICMMILMBPA()
	{
		if (!Application.isEditor)
		{
			CBPMNMHKAAH();
		}
		if (!IMAACAGJDNB)
		{
			Object.DontDestroyOnLoad(base.gameObject);
			IMAACAGJDNB = true;
		}
		else
		{
			Object.Destroy(base.gameObject);
		}
	}

	public void UnPinThisApp()
	{
		if (IBMHONANFCJ != null)
		{
			IBMHONANFCJ.CallStatic("DisableAppPin", NFLIMHBFICB);
		}
	}

	private void BEBFIBHFOPF(bool OKMGCGIMDAI)
	{
		BFAJFNNAODA = OKMGCGIMDAI;
	}

	public void GPJPDEJPFIA()
	{
		if (IBMHONANFCJ != null)
		{
			AndroidJavaObject iBMHONANFCJ = IBMHONANFCJ;
			object[] array = new object[1];
			array[1] = NFLIMHBFICB;
			iBMHONANFCJ.CallStatic("skill3_missile", array);
		}
	}

	[CompilerGenerated]
	private void GHFLCICAGCC()
	{
		IBMHONANFCJ.CallStatic("ImmersiveModeFromCache", NFLIMHBFICB);
	}
}
