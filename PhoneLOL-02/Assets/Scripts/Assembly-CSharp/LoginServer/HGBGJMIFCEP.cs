namespace LoginServer
{
	internal enum HGBGJMIFCEP : byte
	{
		Success = 0,
		InvalidProtocolVersion = 1,
		InvalidUserID = 2,
		AlreadyConnect = 3,
		BlockUser = 4,
		Unknown = byte.MaxValue
	}
}
