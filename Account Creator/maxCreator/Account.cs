using System;
using System.Drawing;

namespace maxCreator
{
	// Token: 0x02000005 RID: 5
	public class Account
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000044A6 File Offset: 0x000026A6
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000044AE File Offset: 0x000026AE
		public long id { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000044B7 File Offset: 0x000026B7
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000044BF File Offset: 0x000026BF
		public string Name { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000044C8 File Offset: 0x000026C8
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000044D0 File Offset: 0x000026D0
		public string Password { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000044D9 File Offset: 0x000026D9
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000044E1 File Offset: 0x000026E1
		public string Email { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000044EA File Offset: 0x000026EA
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000044F2 File Offset: 0x000026F2
		public DateTime Birthday { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000044FB File Offset: 0x000026FB
		// (set) Token: 0x06000037 RID: 55 RVA: 0x00004503 File Offset: 0x00002703
		public Image CaptchaImage { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0000450C File Offset: 0x0000270C
		// (set) Token: 0x06000039 RID: 57 RVA: 0x00004514 File Offset: 0x00002714
		public string Region { get; set; }
	}
}
