using System;
using System.Collections.Generic;
using System.Linq;
using GameCore;
using YamlDotNet.Serialization;

namespace MattyMod
{
	// Token: 0x020006E6 RID: 1766
	public class MattyModConfig : ModConfigType.IModFile
	{
		// Token: 0x06002521 RID: 9505 RVA: 0x000BB044 File Offset: 0x000B9244
		public MattyModConfig()
		{
			this.replaceMessage = "You've replaced a player that disconnected.";
			this.scp096 = new MattyModConfig.Scp096();
			this.scp106 = new MattyModConfig.Scp106();
			this.tesla = new MattyModConfig.Tesla();
			this.scp914 = new MattyModConfig.Scp914();
			this.scp173 = new MattyModConfig.Scp173();
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x00020F85 File Offset: 0x0001F185
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x00020F8D File Offset: 0x0001F18D
		[YamlMember(Alias = "reset_id", Order = 10)]
		public bool ResetID
		{
			get
			{
				return this.resetID;
			}
			set
			{
				this.resetID = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x00020F96 File Offset: 0x0001F196
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x00020F9E File Offset: 0x0001F19E
		[YamlMember(Alias = "friendly_fire", Order = 11)]
		public bool FFRoundend
		{
			get
			{
				return this.ffRoundEnd;
			}
			set
			{
				this.ffRoundEnd = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x00020FA7 File Offset: 0x0001F1A7
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x00020FAF File Offset: 0x0001F1AF
		[YamlMember(Alias = "scp_096_options", Order = 20)]
		public MattyModConfig.Scp096 SCP096
		{
			get
			{
				return this.scp096;
			}
			set
			{
				this.scp096 = value;
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06002528 RID: 9512 RVA: 0x00020FB8 File Offset: 0x0001F1B8
		// (set) Token: 0x06002529 RID: 9513 RVA: 0x00020FC0 File Offset: 0x0001F1C0
		[YamlMember(Alias = "scp_106_options", Order = 21)]
		public MattyModConfig.Scp106 SCP106
		{
			get
			{
				return this.scp106;
			}
			set
			{
				this.scp106 = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x00020FC9 File Offset: 0x0001F1C9
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x00020FD1 File Offset: 0x0001F1D1
		[YamlMember(Alias = "tesla_options", Order = 30)]
		public MattyModConfig.Tesla TeslaOpt
		{
			get
			{
				return this.tesla;
			}
			set
			{
				this.tesla = value;
			}
		}

		// Token: 0x1700044C RID: 1100
		// (get) Token: 0x0600252C RID: 9516 RVA: 0x00020FDA File Offset: 0x0001F1DA
		// (set) Token: 0x0600252D RID: 9517 RVA: 0x00020FE2 File Offset: 0x0001F1E2
		[YamlMember(Alias = "914_options", Order = 40)]
		public MattyModConfig.Scp914 SCP914
		{
			get
			{
				return this.scp914;
			}
			set
			{
				this.scp914 = value;
			}
		}

		// Token: 0x1700044D RID: 1101
		// (get) Token: 0x0600252E RID: 9518 RVA: 0x00020FEB File Offset: 0x0001F1EB
		// (set) Token: 0x0600252F RID: 9519 RVA: 0x00020FF3 File Offset: 0x0001F1F3
		[YamlMember(Alias = "173_options", Order = 22)]
		public MattyModConfig.Scp173 SCP173
		{
			get
			{
				return this.scp173;
			}
			set
			{
				this.scp173 = value;
			}
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06002530 RID: 9520 RVA: 0x00020FFC File Offset: 0x0001F1FC
		// (set) Token: 0x06002531 RID: 9521 RVA: 0x00021004 File Offset: 0x0001F204
		[YamlMember(Alias = "remote_keycard", Order = 8)]
		public bool RemoteKeycard
		{
			get
			{
				return this.remotekeycard;
			}
			set
			{
				this.remotekeycard = value;
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06002532 RID: 9522 RVA: 0x0002100D File Offset: 0x0001F20D
		// (set) Token: 0x06002533 RID: 9523 RVA: 0x00021015 File Offset: 0x0001F215
		[YamlMember(Alias = "invisible_tutorial", Order = 9)]
		public bool InvisibleTutorial
		{
			get
			{
				return this.ivisibleTutorial;
			}
			set
			{
				this.ivisibleTutorial = value;
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06002534 RID: 9524 RVA: 0x0002101E File Offset: 0x0001F21E
		// (set) Token: 0x06002535 RID: 9525 RVA: 0x00021026 File Offset: 0x0001F226
		[YamlMember(Alias = "replace_disconnects", Order = 5)]
		public bool ReplaceDisconnects
		{
			get
			{
				return this.replaceDisconnecs;
			}
			set
			{
				this.replaceDisconnecs = value;
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06002536 RID: 9526 RVA: 0x0002102F File Offset: 0x0001F22F
		// (set) Token: 0x06002537 RID: 9527 RVA: 0x00021037 File Offset: 0x0001F237
		[YamlMember(Alias = "replace_message", Order = 6)]
		public string ReplaceMessage
		{
			get
			{
				return this.replaceMessage;
			}
			set
			{
				this.replaceMessage = value;
			}
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x00021040 File Offset: 0x0001F240
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x00021048 File Offset: 0x0001F248
		[YamlMember(Alias = "servername_tracking", Order = 0)]
		public bool Tracking
		{
			get
			{
				return this.tracking;
			}
			set
			{
				this.tracking = value;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x00021051 File Offset: 0x0001F251
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x00021059 File Offset: 0x0001F259
		[YamlMember(Alias = "class_defaults", Order = 50)]
		public MattyModConfig.ClassDefaults Classes
		{
			get
			{
				return this.classes;
			}
			set
			{
				this.classes = value;
			}
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000BB0AC File Offset: 0x000B92AC
		public void fixNulls()
		{
			if (this.ReplaceMessage == null)
			{
				this.ReplaceMessage = "";
			}
			if (this.SCP096 == null)
			{
				this.SCP096 = new MattyModConfig.Scp096(true);
			}
			this.SCP096.fixNulls();
			if (this.SCP106 == null)
			{
				this.SCP106 = new MattyModConfig.Scp106(true);
			}
			this.SCP106.fixNulls();
			if (this.SCP173 == null)
			{
				this.SCP173 = new MattyModConfig.Scp173(true);
			}
			this.SCP173.fixNulls();
			if (this.SCP914 == null)
			{
				this.SCP914 = new MattyModConfig.Scp914(true);
			}
			this.SCP914.fixNulls();
			if (this.Classes == null)
			{
				this.Classes = new MattyModConfig.ClassDefaults(true);
			}
			this.Classes.fixNulls();
			if (this.TeslaOpt == null)
			{
				this.TeslaOpt = new MattyModConfig.Tesla(true);
			}
			this.TeslaOpt.fixNulls();
		}

		// Token: 0x040022F7 RID: 8951
		private bool resetID;

		// Token: 0x040022F8 RID: 8952
		private bool ffRoundEnd;

		// Token: 0x040022F9 RID: 8953
		private MattyModConfig.Scp096 scp096;

		// Token: 0x040022FA RID: 8954
		private MattyModConfig.Scp106 scp106;

		// Token: 0x040022FB RID: 8955
		private MattyModConfig.Tesla tesla;

		// Token: 0x040022FC RID: 8956
		private MattyModConfig.Scp914 scp914;

		// Token: 0x040022FD RID: 8957
		private MattyModConfig.Scp173 scp173;

		// Token: 0x040022FE RID: 8958
		private bool remotekeycard;

		// Token: 0x040022FF RID: 8959
		private bool ivisibleTutorial;

		// Token: 0x04002300 RID: 8960
		private bool replaceDisconnecs;

		// Token: 0x04002301 RID: 8961
		private string replaceMessage;

		// Token: 0x04002302 RID: 8962
		private bool tracking = true;

		// Token: 0x04002303 RID: 8963
		private MattyModConfig.ClassDefaults classes = new MattyModConfig.ClassDefaults();

		// Token: 0x020006E7 RID: 1767
		public class Scp096 : ModConfigType.IModFile
		{
			// Token: 0x17000454 RID: 1108
			// (get) Token: 0x0600253E RID: 9534 RVA: 0x00021062 File Offset: 0x0001F262
			// (set) Token: 0x0600253F RID: 9535 RVA: 0x0002106A File Offset: 0x0001F26A
			[YamlMember(Alias = "rage_punish")]
			public bool Punish
			{
				get
				{
					return this.punish;
				}
				set
				{
					this.punish = value;
				}
			}

			// Token: 0x17000455 RID: 1109
			// (get) Token: 0x06002540 RID: 9536 RVA: 0x00021073 File Offset: 0x0001F273
			// (set) Token: 0x06002541 RID: 9537 RVA: 0x0002107B File Offset: 0x0001F27B
			[YamlMember(Alias = "ignore_tutorial")]
			public bool Tutorial
			{
				get
				{
					return this.tutorial;
				}
				set
				{
					this.tutorial = value;
				}
			}

			// Token: 0x06002542 RID: 9538 RVA: 0x00021084 File Offset: 0x0001F284
			public Scp096()
			{
			}

			// Token: 0x17000456 RID: 1110
			// (get) Token: 0x06002543 RID: 9539 RVA: 0x0002109A File Offset: 0x0001F29A
			// (set) Token: 0x06002544 RID: 9540 RVA: 0x000210A2 File Offset: 0x0001F2A2
			[YamlMember(Alias = "enable_rework", Order = 1)]
			public bool Enable
			{
				get
				{
					return this.enable;
				}
				set
				{
					this.enable = value;
				}
			}

			// Token: 0x06002545 RID: 9541 RVA: 0x000210AB File Offset: 0x0001F2AB
			public Scp096(bool empty)
			{
				if (empty)
				{
					this.punish = false;
					this.tutorial = false;
					this.enable = false;
				}
			}

			// Token: 0x06002546 RID: 9542 RVA: 0x00003029 File Offset: 0x00001229
			public void fixNulls()
			{
			}

			// Token: 0x04002304 RID: 8964
			private bool punish = true;

			// Token: 0x04002305 RID: 8965
			private bool tutorial = true;

			// Token: 0x04002306 RID: 8966
			private bool enable;
		}

		// Token: 0x020006E8 RID: 1768
		public class Scp106 : ModConfigType.IModFile
		{
			// Token: 0x17000457 RID: 1111
			// (get) Token: 0x06002547 RID: 9543 RVA: 0x000210D9 File Offset: 0x0001F2D9
			// (set) Token: 0x06002548 RID: 9544 RVA: 0x000210E1 File Offset: 0x0001F2E1
			[YamlMember(Order = 100)]
			public MattyModConfig.Scp106Messages Messages
			{
				get
				{
					return this.messages;
				}
				set
				{
					this.messages = value;
				}
			}

			// Token: 0x17000458 RID: 1112
			// (get) Token: 0x06002549 RID: 9545 RVA: 0x000210EA File Offset: 0x0001F2EA
			// (set) Token: 0x0600254A RID: 9546 RVA: 0x000210F2 File Offset: 0x0001F2F2
			[YamlMember(Order = 3)]
			public float Cooldown
			{
				get
				{
					return this.cooldown;
				}
				set
				{
					this.cooldown = value;
				}
			}

			// Token: 0x17000459 RID: 1113
			// (get) Token: 0x0600254B RID: 9547 RVA: 0x000210FB File Offset: 0x0001F2FB
			// (set) Token: 0x0600254C RID: 9548 RVA: 0x00021103 File Offset: 0x0001F303
			[YamlMember(Alias = "initial_cooldown", Order = 2)]
			public float InitCooldown
			{
				get
				{
					return this.initCooldown;
				}
				set
				{
					this.initCooldown = value;
				}
			}

			// Token: 0x0600254D RID: 9549 RVA: 0x0002110C File Offset: 0x0001F30C
			public Scp106()
			{
			}

			// Token: 0x1700045A RID: 1114
			// (get) Token: 0x0600254E RID: 9550 RVA: 0x00021135 File Offset: 0x0001F335
			// (set) Token: 0x0600254F RID: 9551 RVA: 0x0002113D File Offset: 0x0001F33D
			[YamlMember(Alias = "enable_stalky", Order = 1)]
			public bool Enable
			{
				get
				{
					return this.enable;
				}
				set
				{
					this.enable = value;
				}
			}

			// Token: 0x06002550 RID: 9552 RVA: 0x000BB188 File Offset: 0x000B9388
			public Scp106(bool empty)
			{
				if (empty)
				{
					this.cooldown = 0f;
					this.initCooldown = 0f;
					this.enable = false;
					this.messages = new MattyModConfig.Scp106Messages(true);
				}
			}

			// Token: 0x06002551 RID: 9553 RVA: 0x00021146 File Offset: 0x0001F346
			public void fixNulls()
			{
				if (this.messages == null)
				{
					this.messages = new MattyModConfig.Scp106Messages(true);
				}
				this.messages.fixNulls();
			}

			// Token: 0x04002307 RID: 8967
			private MattyModConfig.Scp106Messages messages = new MattyModConfig.Scp106Messages();

			// Token: 0x04002308 RID: 8968
			private float cooldown = 60f;

			// Token: 0x04002309 RID: 8969
			private float initCooldown = 120f;

			// Token: 0x0400230A RID: 8970
			private bool enable;
		}

		// Token: 0x020006E9 RID: 1769
		public class Scp106Messages : ModConfigType.IModFile
		{
			// Token: 0x1700045B RID: 1115
			// (get) Token: 0x06002552 RID: 9554 RVA: 0x00021167 File Offset: 0x0001F367
			// (set) Token: 0x06002553 RID: 9555 RVA: 0x0002116F File Offset: 0x0001F36F
			public string Spawn
			{
				get
				{
					return this.spawn;
				}
				set
				{
					this.spawn = value;
				}
			}

			// Token: 0x1700045C RID: 1116
			// (get) Token: 0x06002554 RID: 9556 RVA: 0x00021178 File Offset: 0x0001F378
			// (set) Token: 0x06002555 RID: 9557 RVA: 0x00021180 File Offset: 0x0001F380
			[YamlMember(Alias = "press_again")]
			public string PressAgain
			{
				get
				{
					return this.pressAgain;
				}
				set
				{
					this.pressAgain = value;
				}
			}

			// Token: 0x1700045D RID: 1117
			// (get) Token: 0x06002556 RID: 9558 RVA: 0x00021189 File Offset: 0x0001F389
			// (set) Token: 0x06002557 RID: 9559 RVA: 0x00021191 File Offset: 0x0001F391
			[YamlMember(Alias = "cooldown_end")]
			public string EndCooldown
			{
				get
				{
					return this.endCooldown;
				}
				set
				{
					this.endCooldown = value;
				}
			}

			// Token: 0x06002558 RID: 9560 RVA: 0x0002119A File Offset: 0x0001F39A
			public Scp106Messages() : this(false)
			{
			}

			// Token: 0x1700045E RID: 1118
			// (get) Token: 0x06002559 RID: 9561 RVA: 0x000211A3 File Offset: 0x0001F3A3
			// (set) Token: 0x0600255A RID: 9562 RVA: 0x000211AB File Offset: 0x0001F3AB
			public string Cooldown
			{
				get
				{
					return this.cooldown;
				}
				set
				{
					this.cooldown = value;
				}
			}

			// Token: 0x1700045F RID: 1119
			// (get) Token: 0x0600255B RID: 9563 RVA: 0x000211B4 File Offset: 0x0001F3B4
			// (set) Token: 0x0600255C RID: 9564 RVA: 0x000211BC File Offset: 0x0001F3BC
			[YamlMember(Alias = "stalk")]
			public string Stalk
			{
				get
				{
					return this.stalk;
				}
				set
				{
					this.stalk = value;
				}
			}

			// Token: 0x0600255D RID: 9565 RVA: 0x000BB1E8 File Offset: 0x000B93E8
			public Scp106Messages(bool empty)
			{
				if (!empty)
				{
					this.spawn = "<size=80><color=#0020ed><b>Stalk</b></color></size>\\nIn this server, you can <color=#0020ed><b>stalk</b></color> humans by double-clicking the portal creation button in the <b>[TAB]</b> menu.";
					this.pressAgain = "\\nPress the portal creation button again to <color=#ff0955><b>Stalk</b></color> a random player.";
					this.cooldown = "\\nYou have to wait $time seconds to use <color=#0020ed><b>Stalk</b></color>.";
					this.endCooldown = "\\n<b><color=#0020ed><b>Stalk</b></color> <color=#00e861>ready</color></b>.\\n<size=30>Press the portal creation button twice to use it.</size>";
					return;
				}
				this.spawn = "";
				this.pressAgain = "";
				this.cooldown = "";
				this.endCooldown = "";
				this.stalk = "";
			}

			// Token: 0x0600255E RID: 9566 RVA: 0x000BB270 File Offset: 0x000B9470
			public void fixNulls()
			{
				if (this.spawn == null)
				{
					this.spawn = "";
				}
				if (this.pressAgain == null)
				{
					this.pressAgain = "";
				}
				if (this.cooldown == null)
				{
					this.cooldown = "";
				}
				if (this.endCooldown == null)
				{
					this.endCooldown = "";
				}
				if (this.stalk == null)
				{
					this.stalk = "";
				}
			}

			// Token: 0x0400230B RID: 8971
			private string spawn;

			// Token: 0x0400230C RID: 8972
			public string pressAgain;

			// Token: 0x0400230D RID: 8973
			private string cooldown;

			// Token: 0x0400230E RID: 8974
			private string endCooldown;

			// Token: 0x0400230F RID: 8975
			private string stalk = "\\n<i>You will <color=#0020ed><b>stalk</b></color><b>$name</b>, who is a $class</i>\\n<size=30><color=#FFFFFF66>Cooldown: $time</color></size>";
		}

		// Token: 0x020006EA RID: 1770
		public class Tesla : ModConfigType.IModFile
		{
			// Token: 0x17000460 RID: 1120
			// (get) Token: 0x0600255F RID: 9567 RVA: 0x000211C5 File Offset: 0x0001F3C5
			// (set) Token: 0x06002560 RID: 9568 RVA: 0x000211CD File Offset: 0x0001F3CD
			[YamlMember(Alias = "trigger_teams")]
			public List<int> Teams
			{
				get
				{
					return this.teams;
				}
				set
				{
					this.teams = value;
				}
			}

			// Token: 0x17000461 RID: 1121
			// (get) Token: 0x06002561 RID: 9569 RVA: 0x000211D6 File Offset: 0x0001F3D6
			// (set) Token: 0x06002562 RID: 9570 RVA: 0x000211DE File Offset: 0x0001F3DE
			[YamlMember(Alias = "trigger_roles")]
			public List<int> Roles
			{
				get
				{
					return this.roles;
				}
				set
				{
					this.roles = value;
				}
			}

			// Token: 0x06002563 RID: 9571 RVA: 0x000BB2DC File Offset: 0x000B94DC
			public Tesla()
			{
			}

			// Token: 0x06002564 RID: 9572 RVA: 0x000BB378 File Offset: 0x000B9578
			public Tesla(bool empty)
			{
				if (empty)
				{
					this.teams = new List<int>();
					this.roles = new List<int>();
				}
			}

			// Token: 0x06002565 RID: 9573 RVA: 0x000211E7 File Offset: 0x0001F3E7
			public void fixNulls()
			{
				if (this.teams == null)
				{
					this.teams = new List<int>();
				}
				if (this.roles == null)
				{
					this.roles = new List<int>();
				}
			}

			// Token: 0x04002310 RID: 8976
			private List<int> teams = (from Team e in Enum.GetValues(typeof(Team))
			select (int)e).ToList<int>();

			// Token: 0x04002311 RID: 8977
			private List<int> roles = (from RoleType e in Enum.GetValues(typeof(RoleType))
			select (int)e).ToList<int>();
		}

		// Token: 0x020006EC RID: 1772
		public class Scp914 : ModConfigType.IModFile
		{
			// Token: 0x0600256C RID: 9580 RVA: 0x0002121B File Offset: 0x0001F41B
			public Scp914() : this(false)
			{
			}

			// Token: 0x17000462 RID: 1122
			// (get) Token: 0x0600256D RID: 9581 RVA: 0x00021224 File Offset: 0x0001F424
			// (set) Token: 0x0600256E RID: 9582 RVA: 0x0002122C File Offset: 0x0001F42C
			public Dictionary<string, List<int>> Objects
			{
				get
				{
					return this.objects;
				}
				set
				{
					this.objects = value;
				}
			}

			// Token: 0x17000463 RID: 1123
			// (get) Token: 0x0600256F RID: 9583 RVA: 0x00021235 File Offset: 0x0001F435
			// (set) Token: 0x06002570 RID: 9584 RVA: 0x0002123D File Offset: 0x0001F43D
			public Dictionary<string, List<int>> Classes
			{
				get
				{
					return this.classes;
				}
				set
				{
					this.classes = value;
				}
			}

			// Token: 0x06002571 RID: 9585 RVA: 0x000BB42C File Offset: 0x000B962C
			public Scp914(bool empty)
			{
				if (!empty)
				{
					this.objects = new Dictionary<string, List<int>>();
					this.objects.Add("COIN_ROUGH", new List<int>
					{
						-1
					});
					this.objects.Add("COIN_COARSE", new List<int>
					{
						-1,
						35
					});
					this.objects.Add("COIN_ONETOONE", new List<int>
					{
						35
					});
					this.objects.Add("COIN_FINE", new List<int>
					{
						35
					});
					this.objects.Add("COIN_VERYFINE", new List<int>
					{
						35
					});
					this.classes = new Dictionary<string, List<int>>();
					this.classes.Add("CLASSD_ROUGH", new List<int>
					{
						-12
					});
					this.classes.Add("CLASSD_COARSE", new List<int>
					{
						-6
					});
					this.classes.Add("CLASSD_ONETOONE", new List<int>
					{
						0
					});
					this.classes.Add("CLASSD_FINE", new List<int>
					{
						6
					});
					this.classes.Add("CLASSD_VERYFINE", new List<int>
					{
						-12,
						12
					});
				}
			}

			// Token: 0x06002572 RID: 9586 RVA: 0x00021246 File Offset: 0x0001F446
			public void fixNulls()
			{
				if (this.objects == null)
				{
					this.objects = new Dictionary<string, List<int>>();
				}
				if (this.classes == null)
				{
					this.classes = new Dictionary<string, List<int>>();
				}
			}

			// Token: 0x04002317 RID: 8983
			private Dictionary<string, List<int>> objects;

			// Token: 0x04002318 RID: 8984
			private Dictionary<string, List<int>> classes;
		}

		// Token: 0x020006ED RID: 1773
		public class Scp173 : ModConfigType.IModFile
		{
			// Token: 0x17000464 RID: 1124
			// (get) Token: 0x06002573 RID: 9587 RVA: 0x0002126E File Offset: 0x0001F46E
			// (set) Token: 0x06002574 RID: 9588 RVA: 0x00021276 File Offset: 0x0001F476
			public bool Enabled
			{
				get
				{
					return this.enabled;
				}
				set
				{
					this.enabled = value;
				}
			}

			// Token: 0x06002575 RID: 9589 RVA: 0x0002127F File Offset: 0x0001F47F
			public Scp173() : this(false)
			{
			}

			// Token: 0x06002576 RID: 9590 RVA: 0x00021288 File Offset: 0x0001F488
			public Scp173(bool empty)
			{
				if (empty)
				{
					this.enabled = false;
				}
			}

			// Token: 0x06002577 RID: 9591 RVA: 0x00003029 File Offset: 0x00001229
			public void fixNulls()
			{
			}

			// Token: 0x04002319 RID: 8985
			private bool enabled;
		}

		// Token: 0x020006EE RID: 1774
		public class ClassDefaults : ModConfigType.IModFile
		{
			// Token: 0x06002578 RID: 9592 RVA: 0x0002129A File Offset: 0x0001F49A
			public ClassDefaults() : this(false)
			{
			}

			// Token: 0x17000465 RID: 1125
			// (get) Token: 0x06002579 RID: 9593 RVA: 0x000212A3 File Offset: 0x0001F4A3
			// (set) Token: 0x0600257A RID: 9594 RVA: 0x000212AB File Offset: 0x0001F4AB
			[YamlMember(Alias = "hp")]
			public Dictionary<string, int> HP
			{
				get
				{
					return this.hp;
				}
				set
				{
					this.hp = value;
				}
			}

			// Token: 0x17000466 RID: 1126
			// (get) Token: 0x0600257B RID: 9595 RVA: 0x000212B4 File Offset: 0x0001F4B4
			// (set) Token: 0x0600257C RID: 9596 RVA: 0x000212BC File Offset: 0x0001F4BC
			public Dictionary<string, List<int>> Items
			{
				get
				{
					return this.items;
				}
				set
				{
					this.items = value;
				}
			}

			// Token: 0x0600257D RID: 9597 RVA: 0x000BB58C File Offset: 0x000B978C
			public ClassDefaults(bool empty)
			{
				if (!empty)
				{
					this.hp = new Dictionary<string, int>();
					this.hp.Add("classd", 100);
					this.items = new Dictionary<string, List<int>>();
					this.items.Add("classd", new List<int>());
				}
			}

			// Token: 0x0600257E RID: 9598 RVA: 0x000212C5 File Offset: 0x0001F4C5
			public void fixNulls()
			{
				if (this.items == null)
				{
					this.items = new Dictionary<string, List<int>>();
				}
				if (this.hp == null)
				{
					this.hp = new Dictionary<string, int>();
				}
			}

			// Token: 0x0400231A RID: 8986
			private Dictionary<string, int> hp;

			// Token: 0x0400231B RID: 8987
			private Dictionary<string, List<int>> items;
		}
	}
}
