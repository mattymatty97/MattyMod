//this is for resetting UserIds and fixing MultiAdmin round triggered commands
public void Roundrestart()
{
	if (ConfigFile.ModConfig.MattyMod.ResetID)
	{
		FieldInfo field = typeof(QueryProcessor).GetField("_idIterator", BindingFlags.Static | BindingFlags.NonPublic);
		if (field != null)
		{
			field.SetValue(null, -1);
		}
	}
	//og code goes there
	ServerConsole.AddLog("Round restarting");
}
