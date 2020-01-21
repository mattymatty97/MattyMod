	// before every door changeState make a call to broadcastDoor(GameObject door)
	// This is RemoteKeycard.
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

	private void broadcastDoor(GameObject door)
	{
		IEnumerable<GameObject> players = PlayerManager.players;
		int status = door.GetComponent<Door>().status;
		if (status == 0 || status == 1)
		{
			IEnumerable<GameObject> source = players;
			Func<GameObject, bool> <>9__0;
			Func<GameObject, bool> predicate;
			if ((predicate = <>9__0) == null)
			{
				predicate = (<>9__0 = ((GameObject p) => Vector3.Distance(p.transform.position, door.gameObject.transform.position) < PlayerInteract.distance));
			}
			foreach (GameObject gameObject in source.Where(predicate))
			{
				CharacterClassManager component = gameObject.GetComponent<CharacterClassManager>();
				component.TargetConsolePrint(component.connectionToClient, string.Concat(new object[]
				{
					"Player: <color=green>",
					base.gameObject.GetComponent<NicknameSync>().MyNick,
					"</color> ",
					(status == 0) ? "Openned" : "Closed",
					" ",
					door.name,
					" :",
					door.GetComponent<NetworkIdentity>().assetId
				}), "grey");
			}
		}
	}
