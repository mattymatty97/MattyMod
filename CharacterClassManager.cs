public void SetRandomRoles()
{
	//at the end of the method
	if (ConfigFile.ModConfig.MattyMod.SCP106.Enable)
	{
		Scp106PlayerScript.InitializeStalky106();
	}
}

public void SetPlayersClass(RoleType classid, GameObject ply, bool lite = false, bool escape = false)
{
	 //where setting health
	 int maxHP = this.Classes.SafeGet(classid).maxHP;
	if (!ConfigFile.ModConfig.MattyMod.Classes.HP.TryGetValue(classid.ToString().ToLower(), out maxHP))
	{
		maxHP = this.Classes.SafeGet(classid).maxHP;
	}
	ply.GetComponent<PlayerStats>().SetHPAmount(maxHP);
	ply.GetComponent<PlayerStats>().maxHP = maxHP;
	 //where giving items
	 ItemType[] array = this.Classes.SafeGet(classid).startItems;
	List<int> source;
	if (ConfigFile.ModConfig.MattyMod.Classes.Items.TryGetValue(classid.ToString().ToLower(), out source))
	{
		array = (from i in source
		select (ItemType)i).ToArray<ItemType>();
	}
	foreach (ItemType itemType in array)
	{
		if (itemType != ItemType.None)
		{
			component.AddNewItem(itemType, -4.6566467E+11f, 0, 0, 0);
		}
	}
}
