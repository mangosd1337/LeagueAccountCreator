using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace maxCreator
{
	// Token: 0x02000002 RID: 2
	public partial class captchaForm : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public string CaptchaText { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002061 File Offset: 0x00000261
		// (set) Token: 0x06000004 RID: 4 RVA: 0x00002069 File Offset: 0x00000269
		public string ReturnValue1 { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002072 File Offset: 0x00000272
		// (set) Token: 0x06000006 RID: 6 RVA: 0x0000207A File Offset: 0x0000027A
		public Image captchaImage { get; set; }

		// Token: 0x06000007 RID: 7 RVA: 0x00002083 File Offset: 0x00000283
		public captchaForm(Image CaptchaImage)
		{
			this.InitializeComponent();
			this.captchaImage = CaptchaImage;
			FormHandler.Initialize(this);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020AB File Offset: 0x000002AB
		private void button2_Click(object sender, EventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate
			{
				FormHandler.MainForm_.__CreationActive = false;
			}));
			this.canceled = true;
			base.Close();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020DE File Offset: 0x000002DE
		private void button1_Click(object sender, EventArgs e)
		{
			this.CaptchaText = this.textBox1.Text;
			base.Close();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020F7 File Offset: 0x000002F7
		private void captcha_Load(object sender, EventArgs e)
		{
			this.captchaBox.Image = this.captchaImage;
		}

		// Token: 0x04000001 RID: 1
		public bool canceled;
	}
}
