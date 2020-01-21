public static void ReloadServerName()
{
	ServerConsole._serverName = ConfigFile.ServerConfig.GetString("server_name", "My Server Name") + (ConfigFile.ModConfig.MattyMod.Tracking ? " <color=#ffffff00><size=1>SMMattyModV1.2.1</size></color>" : string.Empty);
}
