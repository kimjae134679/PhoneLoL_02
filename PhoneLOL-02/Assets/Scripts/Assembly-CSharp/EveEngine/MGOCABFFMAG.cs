namespace EveEngine
{
	public enum MGOCABFFMAG : ushort
	{
		None = 60000,
		Auth = 60001,
		UDPAuth = 60002,
		CheckAlive = 60003,
		JoinP2PGroup = 60004,
		LeaveP2PGroup = 60005,
		GiveupMasterP2PGroup = 60006,
		ChangeMasterP2PGroup = 60007,
		HolePunchingArrived = 60008,
		MasterPriority = 60009,
		U_Auth = 60010,
		U_Ping = 60011,
		U_P2PPing = 60012,
		U_HolePunching = 60013,
		U_SerializeView = 60014,
		U_RPC = 60015,
		U_Instantiate = 60016,
		U_Destroy = 60017,
		U_Message = 60018
	}
}
