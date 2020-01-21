private Dictionary<RoleType, Dictionary<Scp914Knob, float[]>> classRecipes;

private void Start()
{
	//at the end of the method
	try
	{
		foreach (object obj in Enum.GetValues(typeof(ItemType)))
		{
			ItemType key = (ItemType)obj;
			Dictionary<Scp914Knob, ItemType[]> dictionary;
			this.recipesDict.TryGetValue(key, out dictionary);
			foreach (object obj2 in Enum.GetValues(typeof(Scp914Knob)))
			{
				Scp914Knob key2 = (Scp914Knob)obj2;
				string text = key.ToString().ToUpper() + "_" + key2.ToString().ToUpper();
				List<int> source;
				if (ConfigFile.ModConfig.MattyMod.SCP914.Objects.TryGetValue(text, out source))
				{
					ItemType[] array2 = (from i in source
					select (ItemType)i).ToArray<ItemType>();
					if (!array2.IsEmpty<ItemType>())
					{
						ServerConsole.AddLog(string.Concat(new object[]
						{
							"[DEBUG] [914] ",
							text,
							" [",
							string.Join<ItemType>(" , ", array2),
							"]"
						}));
						if (dictionary == null)
						{
							dictionary = new Dictionary<Scp914Knob, ItemType[]>();
						}
						if (!dictionary.TryAdd(key2, array2))
						{
							dictionary.Remove(key2);
							dictionary.Add(key2, array2);
						}
					}
				}
			}
			if (dictionary != null && !this.recipesDict.TryAdd(key, dictionary))
			{
				this.recipesDict.Remove(key);
				this.recipesDict.Add(key, dictionary);
			}
		}
		foreach (object obj3 in Enum.GetValues(typeof(RoleType)))
		{
			RoleType key3 = (RoleType)obj3;
			Dictionary<Scp914Knob, float[]> dictionary2 = null;
			foreach (object obj4 in Enum.GetValues(typeof(Scp914Knob)))
			{
				Scp914Knob key4 = (Scp914Knob)obj4;
				string text2 = key3.ToString().ToUpper() + "_" + key4.ToString().ToUpper();
				List<int> source2;
				if (ConfigFile.ModConfig.MattyMod.SCP914.Classes.TryGetValue(text2, out source2))
				{
					float[] array3 = (from i in source2
					select (float)i).ToArray<float>();
					if (!array3.IsEmpty<float>())
					{
						ServerConsole.AddLog(string.Concat(new object[]
						{
							"[DEBUG] [914] ",
							text2,
							" [",
							string.Join<float>(" , ", array3),
							"]"
						}));
						if (dictionary2 == null)
						{
							dictionary2 = new Dictionary<Scp914Knob, float[]>();
						}
						if (!dictionary2.TryAdd(key4, array3))
						{
							dictionary2.Remove(key4);
							dictionary2.Add(key4, array3);
						}
					}
				}
			}
			if (dictionary2 != null)
			{
				this.classRecipes.Add(key3, dictionary2);
			}
		}
	}
	catch (Exception ex)
	{
		ServerConsole.AddLog("[ERROR] [914] " + ex.ToString());
	}
}

private void UpgradeObjects(IEnumerable<Pickup> items, IReadOnlyCollection<CharacterClassManager> players)
{
	//inside this foreach loop
	foreach (CharacterClassManager characterClassManager in players)
	{
		//at the end of the foreach
    Dictionary<Scp914Knob, float[]> dictionary;
		float[] array;
		if (this.classRecipes.TryGetValue(characterClassManager.CurClass, out dictionary) && dictionary.TryGetValue(this.knobState, out array))
		{
			float num = array[UnityEngine.Random.Range(0, array.Length)];
			if (num > 0f)
			{
				characterClassManager.gameObject.GetComponent<PlayerStats>().HealHPAmount(num);
			}
			else
			{
				characterClassManager.gameObject.GetComponent<PlayerStats>().HurtPlayer(new PlayerStats.HitInfo(-num, "914", DamageTypes.Wall, 0), characterClassManager.gameObject);
			}
		}
	}
}
