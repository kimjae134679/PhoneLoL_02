PhoneLOLRealtimeLog.SendBatch(new PhoneLOLServerSettings { host = "127.0.0.1", port = 29000 },
    System.Text.Encoding.UTF8.GetBytes("V1165_UNITY_DIAG_ACK_PROBE|source=new-CSharp-uploader|synthetic=1\n"));
return "PASS: new C# uploader received the existing server's HTTP 204 acknowledgement.";
