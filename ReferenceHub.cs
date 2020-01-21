using System;
using System.Collections.Generic;
using RemoteAdmin;
using UnityEngine;
using GameCore;

// You can just copy and paste this. This is just a newer version of replace disconnecteds. I sure hope they use this function in Smod2 although it shouldn't matter
public partial class ReferenceHub : MonoBehaviour
{
	// ReferenceHub
	private void OnDestroy()
	{
		ReferenceHub.Hubs.Remove(base.gameObject);
		RoleType curClass = base.gameObject.GetComponent<CharacterClassManager>().CurClass;
		if (curClass == RoleType.Spectator || curClass == RoleType.Tutorial)
		{
			return;
		}
		if (!ConfigFile.ModConfig.MattyMod.ReplaceDisconnects)
		{
			return;
		}
		string replaceMessage = ConfigFile.ModConfig.MattyMod.ReplaceMessage;
		Inventory component = base.GetComponent<Inventory>();
		Vector3 realModelPosition = base.GetComponent<PlyMovementSync>().RealModelPosition;
		float health = base.GetComponent<PlayerStats>().health;
		Quaternion rotation = base.transform.rotation;
		System.Random random = new System.Random();
		ReferenceHub[] array = (from hub in ReferenceHub.Hubs.Values
		where hub.gameObject != PlayerManager.localPlayer
		where hub.characterClassManager.CurClass == RoleType.Spectator
		where !hub.serverRoles.OverwatchEnabled
		select hub).ToArray<ReferenceHub>();
		if (array.Length != 0)
		{
			ReferenceHub referenceHub = array[random.Next(array.Length)];
			if (!(PlayerManager.localPlayer == referenceHub.gameObject) && referenceHub.characterClassManager.CurClass == RoleType.Spectator && !referenceHub.gameObject.GetComponent<CharacterClassManager>().GetComponent<ServerRoles>().OverwatchEnabled)
			{
				referenceHub.characterClassManager.SetPlayersClass(curClass, referenceHub.gameObject, true, false);
				if (curClass == RoleType.Scp079)
				{
					this.Copy079(referenceHub.scp079PlayerScript, base.GetComponent<Scp079PlayerScript>());
				}
				Timing.RunCoroutine(this.ReallyFunCoroutine(realModelPosition, rotation, health, referenceHub.gameObject), 1);
				foreach (Inventory.SyncItemInfo syncItemInfo in component.items)
				{
					referenceHub.inventory.AddNewItem(syncItemInfo.id, syncItemInfo.durability, syncItemInfo.modSight, syncItemInfo.modBarrel, syncItemInfo.modOther);
				}
				PlayerManager.localPlayer.GetComponent<Broadcast>().TargetAddElement(referenceHub.characterClassManager.connectionToClient, replaceMessage, 7U, false);
			}
		}
	}

	
	private IEnumerator<float> ReallyFunCoroutine(Vector3 pos, Quaternion rot, float health, GameObject go)
	{
		yield return Timing.WaitForSeconds(0.3f);
		go.GetComponent<PlyMovementSync>().OverridePosition(pos, 0f, false);
		yield return Timing.WaitForSeconds(0.5f);
		go.transform.rotation = rot;
		PlayerStats component = go.GetComponent<PlayerStats>();
		component.health = health;
		component.TargetSyncHp(component.connectionToClient, health);
		yield break;
	}

	private void Copy079(Scp079PlayerScript dst, Scp079PlayerScript src) {
		dst.currentCamera = src.currentCamera;
		dst.currentRoom = src.currentRoom;
		dst.currentZone = src.currentZone;
		dst.lockedDoors = src.lockedDoors;
		dst.maxMana = src.maxMana;
		dst.nearbyInteractables = src.nearbyInteractables;
		dst.nearestCameras = src.nearestCameras;
		dst.NetworkcurExp = src.NetworkcurExp;
		dst.NetworkcurLvl = src.NetworkcurLvl;
		dst.NetworkcurMana = src.NetworkcurMana;
		dst.NetworkcurSpeaker = src.NetworkcurSpeaker;
		dst.NetworkmaxMana = src.NetworkmaxMana;
	}
}
