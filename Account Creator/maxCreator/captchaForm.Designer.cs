namespace maxCreator
{
	// Token: 0x02000002 RID: 2
	public partial class captchaForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000B RID: 11 RVA: 0x0000210A File Offset: 0x0000030A
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x0000212C File Offset: 0x0000032C
		private void InitializeComponent()
		{
			this.captchaBox = new global::System.Windows.Forms.PictureBox();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.button2 = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.captchaBox).BeginInit();
			base.SuspendLayout();
			this.captchaBox.Location = new global::System.Drawing.Point(12, 12);
			this.captchaBox.Name = "captchaBox";
			this.captchaBox.Size = new global::System.Drawing.Size(334, 79);
			this.captchaBox.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.captchaBox.TabIndex = 0;
			this.captchaBox.TabStop = false;
			this.textBox1.Location = new global::System.Drawing.Point(13, 98);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(333, 20);
			this.textBox1.TabIndex = 1;
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.Location = new global::System.Drawing.Point(13, 125);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(158, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.button2.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button2.Location = new global::System.Drawing.Point(186, 125);
			this.button2.MaximumSize = new global::System.Drawing.Size(160, 23);
			this.button2.MinimumSize = new global::System.Drawing.Size(160, 23);
			this.button2.Name = "button2";
			this.button2.Size = new global::System.Drawing.Size(160, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Cancel";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new global::System.EventHandler(this.button2_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(358, 163);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			base.Controls.Add(this.captchaBox);
			base.Name = "captchaForm";
			base.ShowIcon = false;
			this.Text = "captcha";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.captcha_Load);
			((global::System.ComponentModel.ISupportInitialize)this.captchaBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000002 RID: 2
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.PictureBox captchaBox;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.Button button2;
	}
}
