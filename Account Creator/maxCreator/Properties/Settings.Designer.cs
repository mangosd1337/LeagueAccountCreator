using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace maxCreator.Properties
{
	// Token: 0x0200000F RID: 15
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00004DEC File Offset: 0x00002FEC
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600006F RID: 111 RVA: 0x00004DF3 File Offset: 0x00002FF3
		// (set) Token: 0x06000070 RID: 112 RVA: 0x00004E05 File Offset: 0x00003005
		[DefaultSettingValue("")]
		[UserScopedSetting]
		[DebuggerNonUserCode]
		public string dbc_login
		{
			get
			{
				return (string)this["dbc_login"];
			}
			set
			{
				this["dbc_login"] = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000071 RID: 113 RVA: 0x00004E13 File Offset: 0x00003013
		// (set) Token: 0x06000072 RID: 114 RVA: 0x00004E25 File Offset: 0x00003025
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string dbc_passwd
		{
			get
			{
				return (string)this["dbc_passwd"];
			}
			set
			{
				this["dbc_passwd"] = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00004E33 File Offset: 0x00003033
		// (set) Token: 0x06000074 RID: 116 RVA: 0x00004E45 File Offset: 0x00003045
		[DebuggerNonUserCode]
		[UserScopedSetting]
		[DefaultSettingValue("False")]
		public bool settings_usedbc
		{
			get
			{
				return (bool)this["settings_usedbc"];
			}
			set
			{
				this["settings_usedbc"] = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00004E58 File Offset: 0x00003058
		// (set) Token: 0x06000076 RID: 118 RVA: 0x00004E6A File Offset: 0x0000306A
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		[UserScopedSetting]
		public bool settings_namerandom
		{
			get
			{
				return (bool)this["settings_namerandom"];
			}
			set
			{
				this["settings_namerandom"] = value;
			}
		}

		// Token: 0x04000056 RID: 86
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
