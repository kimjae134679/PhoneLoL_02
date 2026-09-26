namespace BattleServer
{
	public enum MKNHNGCAOFD : ushort
	{
		None = 0,
		Login = 1,
		Logout = 2,
		CheckAlive = 3,
		QuickSearchRoom = 4,
		CreateRoom = 5,
		ChangeAutoEnterRoom = 6,
		EnterRoom = 7,
		EnterInviteRoom = 8,
		EnterRoomOtherUser = 9,
		LeaveRoom = 10,
		EnterRoomFromIndex = 11,
		SelectHero = 12,
		SelectHeroCostume = 13,
		SelectPosition = 14,
		SelectRune = 15,
		GameReady = 16,
		CountDown = 17,
		GameLoading = 18,
		GameLoadingState = 19,
		GameStart = 20,
		BattleStart = 21,
		GameResult = 22,
		UserCustomBlock = 23
	}
}
