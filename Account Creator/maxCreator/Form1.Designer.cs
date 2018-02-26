namespace maxCreator
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000028 RID: 40 RVA: 0x0000339C File Offset: 0x0000159C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000033BC File Offset: 0x000015BC
		private void InitializeComponent()
		{
			this.btn_start = new global::System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new global::System.Windows.Forms.FlowLayoutPanel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.btn_export = new global::System.Windows.Forms.Button();
			this.dbc_user = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.dbc_balance = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.listBox1 = new global::System.Windows.Forms.ListBox();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.cBox_setDbc = new global::System.Windows.Forms.CheckBox();
			this.dbc_passwd = new global::System.Windows.Forms.TextBox();
			this.dbc_login = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.cBox_randomNumber = new global::System.Windows.Forms.CheckBox();
			this.label4 = new global::System.Windows.Forms.Label();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.Region = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountPassword = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountBirthday = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.AccountEmail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).BeginInit();
			this.tabPage2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			base.SuspendLayout();
			this.btn_start.Location = new global::System.Drawing.Point(6, 58);
			this.btn_start.Name = "btn_start";
			this.btn_start.Size = new global::System.Drawing.Size(75, 23);
			this.btn_start.TabIndex = 0;
			this.btn_start.Text = "Start!";
			this.btn_start.UseVisualStyleBackColor = true;
			this.btn_start.Click += new global::System.EventHandler(this.button1_Click);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Controls.Add(this.tabControl1);
			this.flowLayoutPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new global::System.Drawing.Size(749, 425);
			this.flowLayoutPanel1.TabIndex = 4;
			this.pictureBox1.Image = global::maxCreator.Properties.Resources.ver_1_web_light;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(345, 87);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.pictureBox1.MouseEnter += new global::System.EventHandler(this.pictureBox1_MouseEnter);
			this.pictureBox1.MouseLeave += new global::System.EventHandler(this.pictureBox1_MouseLeave);
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.btn_export);
			this.groupBox2.Controls.Add(this.dbc_user);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.dbc_balance);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.btn_start);
			this.groupBox2.Location = new global::System.Drawing.Point(354, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(391, 87);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Control";
			this.btn_export.Location = new global::System.Drawing.Point(88, 58);
			this.btn_export.Name = "btn_export";
			this.btn_export.Size = new global::System.Drawing.Size(75, 23);
			this.btn_export.TabIndex = 5;
			this.btn_export.Text = "Export";
			this.btn_export.UseVisualStyleBackColor = true;
			this.btn_export.Click += new global::System.EventHandler(this.btn_export_Click);
			this.dbc_user.AutoSize = true;
			this.dbc_user.Location = new global::System.Drawing.Point(316, 38);
			this.dbc_user.Name = "dbc_user";
			this.dbc_user.Size = new global::System.Drawing.Size(58, 13);
			this.dbc_user.TabIndex = 4;
			this.dbc_user.Text = "Log in first!";
			this.label5.AutoSize = true;
			this.label5.Location = new global::System.Drawing.Point(261, 38);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(32, 13);
			this.label5.TabIndex = 3;
			this.label5.Text = "User:";
			this.dbc_balance.AutoSize = true;
			this.dbc_balance.Location = new global::System.Drawing.Point(316, 16);
			this.dbc_balance.Name = "dbc_balance";
			this.dbc_balance.Size = new global::System.Drawing.Size(28, 13);
			this.dbc_balance.TabIndex = 2;
			this.dbc_balance.Text = "0.00";
			this.label3.AutoSize = true;
			this.label3.Location = new global::System.Drawing.Point(261, 16);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(49, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Balance:";
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.tabControl1.Location = new global::System.Drawing.Point(3, 96);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(746, 329);
			this.tabControl1.TabIndex = 2;
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.listBox1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(738, 303);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "League of Legends";
			this.tabPage1.UseVisualStyleBackColor = true;
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.BackgroundColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.Region,
				this.AccountName,
				this.AccountPassword,
				this.AccountBirthday,
				this.AccountEmail
			});
			this.dataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new global::System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new global::System.Drawing.Size(732, 176);
			this.dataGridView1.TabIndex = 1;
			this.listBox1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new global::System.Drawing.Point(3, 179);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new global::System.Drawing.Size(732, 121);
			this.listBox1.TabIndex = 0;
			this.tabPage2.Controls.Add(this.groupBox3);
			this.tabPage2.Controls.Add(this.groupBox1);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(738, 303);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			this.groupBox1.Controls.Add(this.cBox_setDbc);
			this.groupBox1.Controls.Add(this.dbc_passwd);
			this.groupBox1.Controls.Add(this.dbc_login);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new global::System.Drawing.Point(6, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(275, 119);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Death by Captcha";
			this.cBox_setDbc.AutoSize = true;
			this.cBox_setDbc.Location = new global::System.Drawing.Point(9, 19);
			this.cBox_setDbc.Name = "cBox_setDbc";
			this.cBox_setDbc.Size = new global::System.Drawing.Size(129, 17);
			this.cBox_setDbc.TabIndex = 1;
			this.cBox_setDbc.Text = "Use DeathByCaptcha";
			this.cBox_setDbc.UseVisualStyleBackColor = true;
			this.cBox_setDbc.CheckedChanged += new global::System.EventHandler(this.cBox_setDbc_CheckedChanged);
			this.dbc_passwd.Location = new global::System.Drawing.Point(70, 68);
			this.dbc_passwd.Name = "dbc_passwd";
			this.dbc_passwd.Size = new global::System.Drawing.Size(191, 20);
			this.dbc_passwd.TabIndex = 3;
			this.dbc_passwd.UseSystemPasswordChar = true;
			this.dbc_passwd.TextChanged += new global::System.EventHandler(this.dbc_passwd_TextChanged);
			this.dbc_login.Location = new global::System.Drawing.Point(70, 42);
			this.dbc_login.Name = "dbc_login";
			this.dbc_login.Size = new global::System.Drawing.Size(191, 20);
			this.dbc_login.TabIndex = 2;
			this.dbc_login.TextChanged += new global::System.EventHandler(this.dbc_login_TextChanged);
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(6, 71);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(56, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password:";
			this.label2.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(6, 45);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username:";
			this.label1.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.groupBox3.Controls.Add(this.cBox_randomNumber);
			this.groupBox3.Location = new global::System.Drawing.Point(288, 7);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(442, 118);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Default Settings";
			this.cBox_randomNumber.AutoSize = true;
			this.cBox_randomNumber.Location = new global::System.Drawing.Point(6, 19);
			this.cBox_randomNumber.Name = "cBox_randomNumber";
			this.cBox_randomNumber.Size = new global::System.Drawing.Size(128, 17);
			this.cBox_randomNumber.TabIndex = 0;
			this.cBox_randomNumber.Text = "Use Random Number";
			this.cBox_randomNumber.UseVisualStyleBackColor = true;
			this.cBox_randomNumber.CheckedChanged += new global::System.EventHandler(this.cBox_randomNumber_CheckedChanged);
			this.label4.AutoSize = true;
			this.label4.Location = new global::System.Drawing.Point(7, 20);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(44, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Region:";
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FlatStyle = global::System.Windows.Forms.FlatStyle.Popup;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"EU West",
				"North America",
				"EU Nordic & East",
				"Brasil",
				"Turkey",
				"Russia",
				"Latin America North",
				"Latin America South",
				"Oceania"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(57, 16);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 7;
			this.Region.HeaderText = "Region";
			this.Region.Name = "Region";
			this.Region.ReadOnly = true;
			this.AccountName.HeaderText = "Name";
			this.AccountName.Name = "AccountName";
			this.AccountName.ReadOnly = true;
			this.AccountPassword.HeaderText = "Password";
			this.AccountPassword.Name = "AccountPassword";
			this.AccountPassword.ReadOnly = true;
			this.AccountBirthday.HeaderText = "Birthday";
			this.AccountBirthday.Name = "AccountBirthday";
			this.AccountBirthday.ReadOnly = true;
			this.AccountEmail.HeaderText = "Fictional E-Mail";
			this.AccountEmail.Name = "AccountEmail";
			this.AccountEmail.ReadOnly = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			base.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			base.ClientSize = new global::System.Drawing.Size(749, 425);
			base.Controls.Add(this.flowLayoutPanel1);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(765, 464);
			base.MinimizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(765, 464);
			base.Name = "Form1";
			this.Text = "maxCreator";
			base.Load += new global::System.EventHandler(this.Form1_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dataGridView1).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000014 RID: 20
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Button btn_start;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.TextBox dbc_passwd;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.TextBox dbc_login;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.ListBox listBox1;

		// Token: 0x04000021 RID: 33
		public global::System.Windows.Forms.DataGridView dataGridView1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.Label dbc_balance;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label dbc_user;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Button btn_export;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.CheckBox cBox_setDbc;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.CheckBox cBox_randomNumber;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400002D RID: 45
		private new global::System.Windows.Forms.DataGridViewTextBoxColumn Region;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.DataGridViewTextBoxColumn AccountName;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.DataGridViewTextBoxColumn AccountPassword;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.DataGridViewTextBoxColumn AccountBirthday;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.DataGridViewTextBoxColumn AccountEmail;
	}
}
