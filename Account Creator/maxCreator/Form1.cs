using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeathByCaptcha;
using maxCreator.Properties;

namespace maxCreator
{
	// Token: 0x02000004 RID: 4
	public partial class Form1 : Form
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000015 RID: 21 RVA: 0x00002B35 File Offset: 0x00000D35
		// (set) Token: 0x06000016 RID: 22 RVA: 0x00002B3D File Offset: 0x00000D3D
		public Settings settings { get; set; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002B46 File Offset: 0x00000D46
		// (set) Token: 0x06000018 RID: 24 RVA: 0x00002B4E File Offset: 0x00000D4E
		public string region { get; set; }

		// Token: 0x06000019 RID: 25 RVA: 0x00002B57 File Offset: 0x00000D57
		public Form1()
		{
			this.InitializeComponent();
			FormHandler.Initialize(this);
			Form1.listBoxLog = new ListBoxLog(FormHandler.MainForm_.listBox1);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002B80 File Offset: 0x00000D80
		private void Form1_Load(object sender, EventArgs e)
		{
			this.dbc_login.Text = Settings.Default.dbc_login;
			this.dbc_passwd.Text = Settings.Default.dbc_passwd;
			this.cBox_setDbc.Checked = Settings.Default.settings_usedbc;
			this.cBox_randomNumber.Checked = Settings.Default.settings_namerandom;
			this.comboBox1.SelectedIndex = 0;
			this.DeathbyCaptcha();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002BFC File Offset: 0x00000DFC
		private void button1_Click(object sender, EventArgs e)
		{
			if (!this.__CreationActive)
			{
				string text;
				switch (text = this.comboBox1.Text)
				{
				case "EU West":
					this.region = "euw";
					break;
				case "North America":
					this.region = "na";
					break;
				case "EU Nordic & East":
					this.region = "eune";
					break;
				case "Brasil":
					this.region = "br";
					break;
				case "Turkey":
					this.region = "tr";
					break;
				case "Russia":
					this.region = "ru";
					break;
				case "Latin America North":
					this.region = "lan";
					break;
				case "Latin America South":
					this.region = "las";
					break;
				case "Oceania":
					this.region = "oce";
					break;
				}
				Form1.listBoxLog.Log(Level.Info, string.Format("Creating Accounts at {0}", this.region));
				this.__CreationActive = true;
				this.btn_start.Text = "Stop!";
				FormHandler.MainForm_.btn_start.Enabled = false;
				Task.Factory.StartNew(delegate
				{
					this.StartCreation();
				});
				FormHandler.MainForm_.btn_start.Enabled = true;
				return;
			}
			this.__CreationActive = false;
			this.btn_start.Text = "Start!";
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002DE4 File Offset: 0x00000FE4
		private void dbc_login_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.dbc_login = this.dbc_login.Text.ToString();
			Settings.Default.Save();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002E0A File Offset: 0x0000100A
		private void dbc_passwd_TextChanged(object sender, EventArgs e)
		{
			Settings.Default.dbc_passwd = this.dbc_passwd.Text.ToString();
			Settings.Default.Save();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002E58 File Offset: 0x00001058
		private void StartCreation()
		{
			int num = 5;
			List<Task> list = new List<Task>();
			while (this.__CreationActive)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].IsCompleted)
					{
						list[i].Dispose();
						list.RemoveAt(i);
					}
				}
				if (list.Count < num)
				{
					Task item = Task.Factory.StartNew(delegate
					{
						lol lol = new lol();
						lol.create(Form1.listBoxLog, this.region);
					});
					list.Add(item);
				}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002F3C File Offset: 0x0000113C
		public void DeathbyCaptcha()
		{
			if (Settings.Default.settings_usedbc)
			{
				Client client = new SocketClient(Settings.Default.dbc_login.ToString(), Settings.Default.dbc_passwd.ToString());
				try
				{
					if (base.InvokeRequired)
					{
						base.BeginInvoke(new MethodInvoker(delegate
						{
							this.dbc_balance.Text = client.GetBalance().ToString();
							this.dbc_user.Text = client.GetUser().Id.ToString();
						}));
					}
					else
					{
						this.dbc_balance.Text = client.GetBalance().ToString();
						this.dbc_user.Text = client.GetUser().Id.ToString();
					}
				}
				catch
				{
				}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003008 File Offset: 0x00001208
		public void writeCSV(DataGridView gridIn, string outputFile)
		{
			if (gridIn.RowCount > 0)
			{
				DataGridViewRow dataGridViewRow = new DataGridViewRow();
				StreamWriter streamWriter = new StreamWriter(outputFile);
				for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
				{
					if (i > 0)
					{
						streamWriter.Write(",");
					}
					streamWriter.Write(gridIn.Columns[i].HeaderText);
				}
				streamWriter.WriteLine();
				for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
				{
					if (j > 0)
					{
						streamWriter.WriteLine();
					}
					dataGridViewRow = gridIn.Rows[j];
					for (int k = 0; k <= gridIn.Columns.Count - 1; k++)
					{
						if (k > 0)
						{
							streamWriter.Write(",");
						}
						string text = dataGridViewRow.Cells[k].Value.ToString();
						text = text.Replace(',', ' ');
						text = text.Replace(Environment.NewLine, " ");
						streamWriter.Write(text);
					}
				}
				streamWriter.Close();
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003120 File Offset: 0x00001320
		private void btn_export_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.InitialDirectory = Convert.ToString(Environment.SpecialFolder.Desktop);
			saveFileDialog.Filter = "Text File, yo! (*.txt)|*.txt|All Files (*.*)|*.*";
			saveFileDialog.FilterIndex = 1;
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.writeCSV(this.dataGridView1, saveFileDialog.FileName);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003171 File Offset: 0x00001371
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Process.Start("http://www.maxgolds.com");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000317E File Offset: 0x0000137E
		private void pictureBox1_MouseEnter(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Hand;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000318B File Offset: 0x0000138B
		private void pictureBox1_MouseLeave(object sender, EventArgs e)
		{
			this.Cursor = Cursors.Default;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003198 File Offset: 0x00001398
		private void cBox_setDbc_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cBox_setDbc.Checked)
			{
				Settings.Default.settings_usedbc = true;
				Form1.listBoxLog.Log(Level.Critical, "Enabled DeathByCaptcha!");
			}
			else
			{
				Settings.Default.settings_usedbc = false;
				Form1.listBoxLog.Log(Level.Critical, "Disabled DeathByCaptcha!");
			}
			Settings.Default.Save();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003284 File Offset: 0x00001484
		public void UpdateGrid(Account current)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new MethodInvoker(delegate
				{
					this.dataGridView1.Rows.Add(new object[]
					{
						current.Region,
						current.Name,
						current.Password,
						current.Birthday.Date.ToString(),
						current.Email
					});
				}));
				return;
			}
			this.dataGridView1.Rows.Add(new object[]
			{
				current.Region,
				current.Name,
				current.Password,
				current.Birthday.Date.ToString(),
				current.Email
			});
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003340 File Offset: 0x00001540
		private void cBox_randomNumber_CheckedChanged(object sender, EventArgs e)
		{
			if (this.cBox_randomNumber.Checked)
			{
				Settings.Default.settings_namerandom = true;
				Form1.listBoxLog.Log(Level.Critical, "Enabled 'Use Random Number'!");
			}
			else
			{
				Settings.Default.settings_namerandom = false;
				Form1.listBoxLog.Log(Level.Critical, "Disabled 'Use Random Number'!");
			}
			Settings.Default.Save();
		}

		// Token: 0x04000012 RID: 18
		public static ListBoxLog listBoxLog;

		// Token: 0x04000013 RID: 19
		public bool __CreationActive;
	}
}
