using System;

namespace maxCreator
{
	// Token: 0x02000008 RID: 8
	internal class FormHandler
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00004566 File Offset: 0x00002766
		// (set) Token: 0x06000042 RID: 66 RVA: 0x0000456D File Offset: 0x0000276D
		internal static Form1 MainForm_ { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00004575 File Offset: 0x00002775
		// (set) Token: 0x06000044 RID: 68 RVA: 0x0000457C File Offset: 0x0000277C
		internal static captchaForm captcha_ { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00004584 File Offset: 0x00002784
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000458B File Offset: 0x0000278B
		internal static bool Ready { get; set; }

		// Token: 0x06000047 RID: 71 RVA: 0x00004593 File Offset: 0x00002793
		internal static void Initialize(Form1 mainForm)
		{
			FormHandler.MainForm_ = mainForm;
			FormHandler.Ready = true;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000045A1 File Offset: 0x000027A1
		internal static void Initialize(captchaForm captchaForm)
		{
			FormHandler.captcha_ = captchaForm;
		}
	}
}
