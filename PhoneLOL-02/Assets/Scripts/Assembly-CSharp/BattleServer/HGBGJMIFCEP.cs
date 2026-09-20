namespace BattleServer
{
	public enum HGBGJMIFCEP : byte
	{
		Success = 0,
		InvalidProtocolVersion = 1,
		InvalidUserID = 2,
		InvalidNickname = 3,
		AlreadyConnect = 4,
		InvalidCharacter = 5,
		InvalidAdventure = 6,
		InvalidMission = 7,
		NotEnoughLevel = 8,
		NotEnoughCoin = 9,
		NotEnoughCash = 10,
		NotEnoughHeart = 11,
		NotEnoughFood = 12,
		NotEnoughSkillPoint = 13,
		MaxLevel = 14,
		MaxCount = 15,
		AlreadyEnterRoom = 16,
		NotEnoughItem = 17,
		AlreadyEquipItem = 18,
		AlreadyExistHero = 19,
		AlreadyClear = 20,
		AlreadyResultChat = 21,
		BlockUser = 22,
		MaxTodayRecommendCount = 23,
		MaxTotalRecommendCount = 24,
		AlreadyRecommendUser = 25,
		InvalidCoupon = 26,
		ExpireCoupon = 27,
		AlreadyUseCoupon = 28,
		AlreadyConnectAccount = 29,
		Unknown = 30
	}
}
