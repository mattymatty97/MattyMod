private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
      //at the end of method
			if (scene.name == "Facility")
			{
				ServerConsole.AddLog("MattyMod v"+ConfigFile.ModConfig.MattyMod.Version+" loaded");
			}
		}
