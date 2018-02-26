using System;

namespace maxCreator.Vendor
{
	// Token: 0x0200000D RID: 13
	public class MathCalculations
	{
		// Token: 0x06000066 RID: 102 RVA: 0x00004D04 File Offset: 0x00002F04
		public static int RandomNumber(int min, int max)
		{
			int result;
			lock (MathCalculations.syncLock)
			{
				result = MathCalculations.random.Next(min, max);
			}
			return result;
		}

		// Token: 0x04000052 RID: 82
		private static readonly Random random = new Random();

		// Token: 0x04000053 RID: 83
		private static readonly object syncLock = new object();
	}
}
