	// This is just RemoteKeycard.
	public void CallCmdOpenDoor(GameObject doorId)
	{
		//before SCP check
		if (ConfigFile.ModConfig.MattyMod.RemoteKeycard)
	{
		try
		{
			Inventory.SyncListItemInfo items = this._inv.items;
			int i = 0;
			while (i < items.Count)
			{
				if (this._inv.GetItemByID(items[i].id).permissions.Contains(component.permissionLevel))
				{
					if (!component.locked)
					{
						this.broadcastDoor(doorId);
						component.ChangeState(false);
						return;
					}
					this.RpcDenied(doorId);
					return;
				}
				else
				{
					i++;
				}
			}
		}
		catch
		{
			this.RpcDenied(doorId);
		}
	}
	}
