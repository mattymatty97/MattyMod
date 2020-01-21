public static ModConfigType ModConfig;

public static void ReloadGameConfigs(bool firstTime = false)
		{
      //after loading config_gameplay.txt
      ServerConsole.AddLog("Loading Mod config...");
			string text = FileManager.GetAppFolder(true, true, "") + "config_mod.txt";
			if (File.Exists(text))
			{
				ConfigFile.ModConfig = ModConfigType.Deserialize(text);
				ConfigFile.ModConfig.fixNulls();
			}
			else
			{
				if (ConfigFile.ModConfig == null)
				{
					ConfigFile.ModConfig = new ModConfigType();
				}
				ConfigFile.ModConfig.Serialize(text);
			}
      //rest of the code
    }
