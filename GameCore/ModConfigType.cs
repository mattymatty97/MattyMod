using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using MattyMod;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.EventEmitters;

namespace GameCore
{
	// Token: 0x020006EF RID: 1775
	public class ModConfigType
	{
		// Token: 0x06002580 RID: 9600 RVA: 0x000BB5E0 File Offset: 0x000B97E0
		public static ModConfigType Deserialize(string configfile)
		{
			ModConfigType result;
			try
			{
				DeserializerBuilder deserializerBuilder = new DeserializerBuilder().IgnoreUnmatchedProperties().IgnoreFields();
				string input = File.ReadAllText(configfile);
				result = deserializerBuilder.Build().Deserialize<ModConfigType>(input);
			}
			catch (Exception ex)
			{
				ServerConsole.AddLog(string.Concat(new string[]
				{
					"[ERROR] [CONFIG] ",
					"Exception: ",
					ex.GetType().ToString(),
					"\nMessage: ",
					ex.Message,
					"\nStackTrace: ",
					ex.StackTrace
				}));
				result = new ModConfigType();
			}
			return result;
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000BB67C File Offset: 0x000B987C
		public void Serialize(string configfile)
		{
			try
			{
				string text = new SerializerBuilder().EmitDefaults().WithEventEmitter<ModConfigType.FlowStyleIntegerSequences>((IEventEmitter next) => new ModConfigType.FlowStyleIntegerSequences(next)).IgnoreFields().Build().Serialize(this);
				text = Regex.Replace(text, "^( *\\w*:) *", "\n$0", RegexOptions.Multiline);
				File.WriteAllText(configfile, text);
			}
			catch (Exception ex)
			{
				ServerConsole.AddLog(string.Concat(new string[]
				{
					"[ERROR] [CONFIG] ",
					"Exception: ",
					ex.GetType().ToString(),
					"\nMessage: ",
					ex.Message,
					"\nStackTrace: ",
					ex.StackTrace
				}));
			}
		}

		// Token: 0x17000467 RID: 1127
		// (get) Token: 0x06002582 RID: 9602 RVA: 0x00021300 File Offset: 0x0001F500
		// (set) Token: 0x06002583 RID: 9603 RVA: 0x00021308 File Offset: 0x0001F508
		public MattyModConfig MattyMod
		{
			get
			{
				return this.mattyMod;
			}
			set
			{
				this.mattyMod = value;
			}
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x00021311 File Offset: 0x0001F511
		public void fixNulls()
		{
			if (this.MattyMod == null)
			{
				this.MattyMod = new MattyModConfig();
			}
			this.MattyMod.fixNulls();
		}

		// Token: 0x0400231C RID: 8988
		private MattyModConfig mattyMod = new MattyModConfig();

		// Token: 0x020006F1 RID: 1777
		private class FlowStyleIntegerSequences : ChainedEventEmitter
		{
			// Token: 0x06002588 RID: 9608 RVA: 0x00021345 File Offset: 0x0001F545
			public FlowStyleIntegerSequences(IEventEmitter nextEmitter) : base(nextEmitter)
			{
			}

			// Token: 0x06002589 RID: 9609 RVA: 0x0002134E File Offset: 0x0001F54E
			public override void Emit(SequenceStartEventInfo eventInfo, IEmitter emitter)
			{
				if (typeof(IEnumerable<int>).IsAssignableFrom(eventInfo.Source.Type))
				{
					eventInfo = new SequenceStartEventInfo(eventInfo.Source)
					{
						Style = SequenceStyle.Flow
					};
				}
				this.nextEmitter.Emit(eventInfo, emitter);
			}
		}

		// Token: 0x020006F2 RID: 1778
		public interface IModFile
		{
			// Token: 0x0600258A RID: 9610
			void fixNulls();
		}
	}
}
