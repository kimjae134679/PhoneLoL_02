namespace GooglePlayGames
{
	public static class GameInfo
	{
		private const string UnescapedApplicationId = "APPID";

		private const string UnescapedIosClientId = "CLIENTID";

		public const string ApplicationId = "__APPID__";

		public const string IosClientId = "__CLIENTID__";

		public static bool ApplicationIdInitialized()
		{
			return !"__APPID__".Equals(ToEscapedToken("APPID"));
		}

		public static bool IosClientIdInitialized()
		{
			return !"__CLIENTID__".Equals(ToEscapedToken("CLIENTID"));
		}

		private static string ToEscapedToken(string token)
		{
			return string.Format("__{0}__", token);
		}
	}
}
