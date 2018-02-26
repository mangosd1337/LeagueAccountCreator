using System;
using System.Windows.Forms;

namespace maxCreator
{
	// Token: 0x02000007 RID: 7
	internal static class Program
	{
		// Token: 0x06000040 RID: 64 RVA: 0x0000454F File Offset: 0x0000274F
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
