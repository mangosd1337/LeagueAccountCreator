using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace maxCreator.Properties
{
	// Token: 0x0200000E RID: 14
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00004D6A File Offset: 0x00002F6A
		internal Resources()
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00004D74 File Offset: 0x00002F74
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("maxCreator.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600006B RID: 107 RVA: 0x00004DB3 File Offset: 0x00002FB3
		// (set) Token: 0x0600006C RID: 108 RVA: 0x00004DBA File Offset: 0x00002FBA
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00004DC4 File Offset: 0x00002FC4
		internal static Bitmap ver_1_web_light
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("ver_1_web_light", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000054 RID: 84
		private static ResourceManager resourceMan;

		// Token: 0x04000055 RID: 85
		private static CultureInfo resourceCulture;
	}
}
