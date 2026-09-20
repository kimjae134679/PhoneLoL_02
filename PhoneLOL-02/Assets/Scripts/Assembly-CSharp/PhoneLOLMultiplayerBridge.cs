using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using BattleServer;
using EveEngine;
using UnityEngine;

public static class PhoneLOLMultiplayerBridge
{
	private sealed class Message
	{
		public int target;

		public ushort pid;

		public byte[] payload;
	}

	private static readonly Queue<Message> pending = new Queue<Message>();

	private static PNDMCOBIODO loading;

	private static bool multiplayer;

	private static bool started;

	private static float deadline;

	private static int tx;

	private static int rx;

	private static readonly IPEndPoint endpoint = new IPEndPoint(IPAddress.Loopback, 20003);

	private static readonly Type diagnostics = typeof(PNDMCOBIODO).Assembly.GetType("V096OriginalDiagnostics");

	private static void Diag(string method, string value)
	{
		try
		{
			diagnostics.GetMethod(method, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic).Invoke(null, new object[1] { value });
		}
		catch
		{
			Debug.Log(value);
		}
	}

	private static void Log(string text)
	{
		Diag("Write", "V1154_MULTI|" + text);
	}

	public static void OnRoster(PNDMCOBIODO client)
	{
		if (client.IMKOGBNIJBO().OOHFDEPKKFN() != OCPEALOGAIP.OEOIIKMBGAG.CountDown)
		{
			return;
		}
		int num = 0;
		HashSet<int> hashSet = new HashSet<int>();
		HashSet<int> hashSet2 = new HashSet<int>();
		bool flag = true;
		foreach (NOBFFGBGCNA item in client.IMKOGBNIJBO().FMCMCKANEBC())
		{
			if (item.GBGKGJKBPHM != 0 && item.FPFIIDFCLOL != 0)
			{
				num++;
				flag &= item.ODGCBCEMAHH > 0 && item.LHPLBMLPIFO > 0 && hashSet.Add(item.ODGCBCEMAHH) && hashSet2.Add(item.LHPLBMLPIFO);
				Log("ROSTER|slot=" + item.COKFPAODPCF() + "|owner=" + item.ODGCBCEMAHH + "|view=" + item.LHPLBMLPIFO + "|hero=" + item.FPFIIDFCLOL);
			}
		}
		pending.Clear();
		started = false;
		loading = null;
		tx = (rx = 0);
		multiplayer = num > 1;
		EveUnityNetwork instance = EveUnityNetwork.get_Instance();
		ABBLIOLAABC defaultGroup = instance.GetDefaultGroup();
		flag &= !multiplayer || (defaultGroup != null && hashSet.Contains(client.NCHJJNGPOPA()) && hashSet.Contains(defaultGroup.ACCPGHNBJOL()));
		instance.IsLocalMode = !multiplayer;
		Log("COUNTDOWN|members=" + num + "|session=" + client.NCHJJNGPOPA() + "|master=" + ((defaultGroup == null) ? (-1) : defaultGroup.ACCPGHNBJOL()) + "|valid=" + flag);
		if (!flag)
		{
			client.MKJCMHPMECO = true;
			client.EMOCPLIJIEK = true;
			client.MNCACLOFDBA();
		}
	}

	public static void BeginLoad(PNDMCOBIODO client, int stage)
	{
		loading = client;
		started = false;
		deadline = Time.realtimeSinceStartup + 90f;
		client.IMKOGBNIJBO().AJJGLNHAPPF(OCPEALOGAIP.OEOIIKMBGAG.Loading);
		client.MKJCMHPMECO = false;
		client.EMOCPLIJIEK = false;
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(19);
		cMNIABEFLBJ.GBMJNFOEACC(stage);
		Log("LOADED_WAIT|session=" + client.NCHJJNGPOPA());
		if (!client.FBAFKOCPFPG(cMNIABEFLBJ))
		{
			Fail("load_send_failed");
		}
	}

	private static void Fail(string reason)
	{
		pending.Clear();
		started = false;
		if (loading != null)
		{
			loading.MKJCMHPMECO = true;
			loading.EMOCPLIJIEK = true;
		}
		loading = null;
		Log("CANCEL|" + reason);
	}

	public static void Tick()
	{
		if (loading != null && !started && Time.realtimeSinceStartup >= deadline)
		{
			Fail("loading_timeout_90s");
		}
	}

	public static void OnStart(PNDMCOBIODO client)
	{
		if (client != loading)
		{
			if (!started)
			{
				client.MKJCMHPMECO = true;
				client.EMOCPLIJIEK = true;
				Log("REJECT_START|no_active_load");
			}
			return;
		}
		if (client.MKJCMHPMECO || (multiplayer && client.IMKOGBNIJBO().DCHDPGPBJGC == 0L))
		{
			Fail("invalid_start_ack");
			return;
		}
		started = true;
		loading = null;
		EveUnityNetwork.get_Instance().IsLocalMode = !multiplayer;
		Log("SHARED_START|game=" + client.IMKOGBNIJBO().DCHDPGPBJGC + "|session=" + client.NCHJJNGPOPA() + "|queued=" + pending.Count);
		while (pending.Count > 0)
		{
			Transmit(pending.Dequeue());
		}
		Diag("QueueAutomaticReportImmediate", "same_game_start");
	}

	public static void SendGroup(KJGALEFHHOA ignored, CMNIABEFLBJ packet, bool reliable, ABBLIOLAABC group)
	{
		Send(packet, -1);
	}

	public static void SendGroupFlags(KJGALEFHHOA ignored, CMNIABEFLBJ packet, bool reliable, bool viaServer, bool includeSelf, ABBLIOLAABC group)
	{
		Send(packet, includeSelf ? (-2) : (-1));
	}

	public static void SendTarget(KJGALEFHHOA ignored, CMNIABEFLBJ packet, bool reliable, bool viaServer, LHOLJMEKHBF target)
	{
		if (target == null || (!viaServer && target.GMHFFJFKCGE()))
		{
			packet.CDPNLMMNNBD();
		}
		else
		{
			Send(packet, target.NCHJJNGPOPA());
		}
	}

	private static void Send(CMNIABEFLBJ packet, int target)
	{
		if (!multiplayer)
		{
			packet.CDPNLMMNNBD();
			return;
		}
		int num = packet.EJGJCLHFIAM();
		ushort num2 = packet.PEBCAPNIMOL();
		if (num2 < 60014 || num2 > 60018 || num < 16 || num > 60000)
		{
			packet.CDPNLMMNNBD();
			return;
		}
		Message message = new Message();
		message.target = target;
		message.pid = num2;
		message.payload = new byte[num - 16];
		Buffer.BlockCopy(packet.EIMBOIKCJPE(), 16, message.payload, 0, message.payload.Length);
		packet.CDPNLMMNNBD();
		if (!started)
		{
			if (pending.Count >= 2048)
			{
				Fail("prestart_queue_limit");
			}
			else
			{
				pending.Enqueue(message);
			}
		}
		else
		{
			Transmit(message);
		}
	}

	private static void Transmit(Message m)
	{
		EKACODPEIIO netClient = EveUnityNetwork.get_Instance().get_m_netClient();
		CMNIABEFLBJ cMNIABEFLBJ = CMNIABEFLBJ.PEFJOMFAOJI();
		cMNIABEFLBJ.DGFDHOLDCDL(60019);
		cMNIABEFLBJ.GBMJNFOEACC(m.target);
		cMNIABEFLBJ.GBMJNFOEACC(m.pid);
		cMNIABEFLBJ.GBMJNFOEACC(m.payload, 0, m.payload.Length);
		if (netClient.FBAFKOCPFPG(cMNIABEFLBJ))
		{
			tx++;
			if (tx <= 5 || tx % 1000 == 0)
			{
				Log("TX|count=" + tx + "|pid=" + m.pid);
			}
		}
	}

	public static bool Receive(EKACODPEIIO client, PJEMPFEIOAK packet)
	{
		ushort num = packet.KCGNKBDGONC();
		if (num < 60014 || num > 60018)
		{
			return false;
		}
		if (!multiplayer || !started || client != EveUnityNetwork.get_Instance().get_m_netClient())
		{
			return true;
		}
		switch (num)
		{
		case 60014:
			if (client.AJJCIJFJDAJ != null)
			{
				client.AJJCIJFJDAJ(packet, endpoint);
			}
			break;
		case 60015:
			if (client.KIBGHKLBHOJ != null)
			{
				client.KIBGHKLBHOJ(packet, endpoint);
			}
			break;
		case 60016:
			if (client.GAGKHKEDJPE != null)
			{
				client.GAGKHKEDJPE(packet, endpoint);
			}
			break;
		case 60017:
			if (client.EMJOODMOIGA != null)
			{
				client.EMJOODMOIGA(packet, endpoint);
			}
			break;
		case 60018:
			if (client.BPGDNOKCOKI != null)
			{
				client.BPGDNOKCOKI(packet, endpoint);
			}
			break;
		}
		rx++;
		if (rx <= 5 || rx % 1000 == 0)
		{
			Log("RX|count=" + rx + "|pid=" + num);
		}
		return true;
	}
}
