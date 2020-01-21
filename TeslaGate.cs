private List<PlayerStats> PlayersInRange(bool hurtRange)
{
	this.playerStats.Clear();
	if (hurtRange)
	{
		GameObject[] array = this.killers;
		for (int i = 0; i < array.Length; i++)
		{
			Collider[] array2 = Physics.OverlapBox(array[i].transform.position + Vector3.up * (this.sizeOfKiller.y / 2f), this.sizeOfKiller / 2f, default(Quaternion), this.killerMask);
			for (int j = 0; j < array2.Length; j++)
			{
				PlayerStats componentInParent = array2[j].GetComponentInParent<PlayerStats>();
				if (componentInParent != null && componentInParent.ccm.CurClass != RoleType.Spectator)
				{
					this.playerStats.Add(componentInParent);
				}
			}
		}
	}
	else
	{
		foreach (GameObject gameObject in PlayerManager.players)
		{
			if (Vector3.Distance(base.transform.position, gameObject.transform.position) < this.sizeOfTrigger && gameObject.GetComponent<CharacterClassManager>().CurClass != RoleType.Spectator)
			{
				CharacterClassManager component = gameObject.GetComponent<CharacterClassManager>();
				if (ConfigFile.ModConfig.MattyMod.TeslaOpt.Teams.Contains((int)component.Classes[(int)component.CurClass].team) && ConfigFile.ModConfig.MattyMod.TeslaOpt.Roles.Contains((int)component.CurClass))
				{
					this.playerStats.Add(gameObject.GetComponent<PlayerStats>());
				}
			}
		}
	}
	return this.playerStats;
}
