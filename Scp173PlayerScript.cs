	// This is my own rework, do whatever you want with it, for I do not care.
	// Token: 0x0600121F RID: 4639
	private void FixedUpdate()
	{
		//before forcing _allowMove
		if (ConfigFile.ModConfig.MattyMod.SCP173.Enabled && this._allowMove)
		{
			Scp173PlayerScript.reworkPlusTime -= Time.fixedDeltaTime * 1.25f;
			if (Scp173PlayerScript.reworkPlusTime < 0f)
			{
				Scp173PlayerScript.reworkPlusTime = 0f;
			}
		}
	}
	// Token: 0x06001222 RID: 4642 RVA: 0x0006A180 File Offset: 0x00068380
	private void DoBlinkingSequence()
	{
		//after Remaining time
		if (ConfigFile.ModConfig.MattyMod.SCP173.Enabled && !this._allowMove)
		{
			Scp173PlayerScript.reworkPlusTime += UnityEngine.Random.Range(0.25f, 0.45f);
			if (Scp173PlayerScript.reworkPlusTime > this.minBlinkTime - 1f)
			{
				Scp173PlayerScript.reworkPlusTime = this.minBlinkTime - 1f;
			}
		}
	}
	private static float reworkPlusTime = 0f;
