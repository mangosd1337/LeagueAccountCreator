using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace maxCreator
{
	// Token: 0x0200000A RID: 10
	public sealed class ListBoxLog : IDisposable
	{
		// Token: 0x0600004A RID: 74 RVA: 0x000045B1 File Offset: 0x000027B1
		private void OnHandleCreated(object sender, EventArgs e)
		{
			this._canAdd = true;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000045BA File Offset: 0x000027BA
		private void OnHandleDestroyed(object sender, EventArgs e)
		{
			this._canAdd = false;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000045C4 File Offset: 0x000027C4
		private void DrawItemHandler(object sender, DrawItemEventArgs e)
		{
			if (e.Index >= 0)
			{
				e.DrawBackground();
				e.DrawFocusRectangle();
				ListBoxLog.LogEvent logEvent = ((ListBox)sender).Items[e.Index] as ListBoxLog.LogEvent;
				if (logEvent == null)
				{
					logEvent = new ListBoxLog.LogEvent(Level.Critical, ((ListBox)sender).Items[e.Index].ToString());
				}
				Color color;
				switch (logEvent.Level)
				{
				case Level.Critical:
					color = Color.White;
					break;
				case Level.Error:
					color = Color.Red;
					break;
				case Level.Warning:
					color = Color.Goldenrod;
					break;
				case Level.Info:
					color = Color.Green;
					break;
				case Level.Verbose:
					color = Color.Blue;
					break;
				default:
					color = Color.Black;
					break;
				}
				if (logEvent.Level == Level.Critical)
				{
					e.Graphics.FillRectangle(new SolidBrush(Color.Red), e.Bounds);
				}
				e.Graphics.DrawString(this.FormatALogEventMessage(logEvent, this._messageFormat), new Font("Lucida Console", 8.25f, FontStyle.Regular), new SolidBrush(color), e.Bounds);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000046D7 File Offset: 0x000028D7
		private void KeyDownHandler(object sender, KeyEventArgs e)
		{
			if (e.Modifiers == Keys.Control && e.KeyCode == Keys.C)
			{
				this.CopyToClipboard();
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000046F6 File Offset: 0x000028F6
		private void CopyMenuOnClickHandler(object sender, EventArgs e)
		{
			this.CopyToClipboard();
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004700 File Offset: 0x00002900
		private void CopyMenuPopupHandler(object sender, EventArgs e)
		{
			ContextMenu contextMenu = sender as ContextMenu;
			if (contextMenu != null)
			{
				contextMenu.MenuItems[0].Enabled = (this._listBox.SelectedItems.Count > 0);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000473C File Offset: 0x0000293C
		private void WriteEvent(ListBoxLog.LogEvent logEvent)
		{
			if (logEvent != null && this._canAdd)
			{
				this._listBox.BeginInvoke(new ListBoxLog.AddALogEntryDelegate(this.AddALogEntry), new object[]
				{
					logEvent
				});
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004778 File Offset: 0x00002978
		private void AddALogEntry(object item)
		{
			this._listBox.Items.Add(item);
			if (this._listBox.Items.Count > this._maxEntriesInListBox)
			{
				this._listBox.Items.RemoveAt(0);
			}
			if (!this._paused)
			{
				this._listBox.TopIndex = this._listBox.Items.Count - 1;
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000047E8 File Offset: 0x000029E8
		private string LevelName(Level level)
		{
			switch (level)
			{
			case Level.Critical:
				return "Critical";
			case Level.Error:
				return "Error";
			case Level.Warning:
				return "Warning";
			case Level.Info:
				return "Info";
			case Level.Verbose:
				return "Verbose";
			case Level.Debug:
				return "Debug";
			default:
				return string.Format("<value={0}>", (int)level);
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000484C File Offset: 0x00002A4C
		private string FormatALogEventMessage(ListBoxLog.LogEvent logEvent, string messageFormat)
		{
			string text = logEvent.Message;
			if (text == null)
			{
				text = "<NULL>";
			}
			return string.Format(messageFormat, new object[]
			{
				logEvent.EventTime.ToString("yyyy-MM-dd HH:mm:ss.fff"),
				logEvent.EventTime.ToString("yyyy-MM-dd HH:mm:ss"),
				logEvent.EventTime.ToString("yyyy-MM-dd"),
				logEvent.EventTime.ToString("HH:mm:ss.fff"),
				logEvent.EventTime.ToString("HH:mm:ss"),
				this.LevelName(logEvent.Level)[0],
				this.LevelName(logEvent.Level),
				(int)logEvent.Level,
				text
			});
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004924 File Offset: 0x00002B24
		private void CopyToClipboard()
		{
			if (this._listBox.SelectedItems.Count > 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.AppendLine("{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fcharset0 Courier;}}");
				stringBuilder.AppendLine("{\\colortbl;\\red255\\green255\\blue255;\\red255\\green0\\blue0;\\red218\\green165\\blue32;\\red0\\green128\\blue0;\\red0\\green0\\blue255;\\red0\\green0\\blue0}");
				foreach (object obj in this._listBox.SelectedItems)
				{
					ListBoxLog.LogEvent logEvent = (ListBoxLog.LogEvent)obj;
					stringBuilder.AppendFormat("{{\\f0\\fs16\\chshdng0\\chcbpat{0}\\cb{0}\\cf{1} ", (logEvent.Level == Level.Critical) ? 2 : 1, (int)((logEvent.Level == Level.Critical) ? Level.Error : ((logEvent.Level > Level.Debug) ? ((Level)6) : (logEvent.Level + 1))));
					stringBuilder.Append(this.FormatALogEventMessage(logEvent, this._messageFormat));
					stringBuilder.AppendLine("\\par}");
				}
				stringBuilder.AppendLine("}");
				Clipboard.SetData(DataFormats.Rtf, stringBuilder.ToString());
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004A2C File Offset: 0x00002C2C
		public ListBoxLog(ListBox listBox) : this(listBox, "{0} [{5}] : {8}", 2000)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004A3F File Offset: 0x00002C3F
		public ListBoxLog(ListBox listBox, string messageFormat) : this(listBox, messageFormat, 2000)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004A50 File Offset: 0x00002C50
		public ListBoxLog(ListBox listBox, string messageFormat, int maxLinesInListbox)
		{
			this._disposed = false;
			this._listBox = listBox;
			this._messageFormat = messageFormat;
			this._maxEntriesInListBox = maxLinesInListbox;
			this._paused = false;
			this._canAdd = listBox.IsHandleCreated;
			this._listBox.SelectionMode = SelectionMode.MultiExtended;
			this._listBox.HandleCreated += this.OnHandleCreated;
			this._listBox.HandleDestroyed += this.OnHandleDestroyed;
			this._listBox.DrawItem += this.DrawItemHandler;
			this._listBox.KeyDown += this.KeyDownHandler;
			MenuItem[] menuItems = new MenuItem[]
			{
				new MenuItem("Copy", new EventHandler(this.CopyMenuOnClickHandler))
			};
			this._listBox.ContextMenu = new ContextMenu(menuItems);
			this._listBox.ContextMenu.Popup += this.CopyMenuPopupHandler;
			this._listBox.DrawMode = DrawMode.OwnerDrawFixed;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004B55 File Offset: 0x00002D55
		public void Log(string message)
		{
			this.Log(Level.Debug, message);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004B5F File Offset: 0x00002D5F
		public void Log(string format, params object[] args)
		{
			this.Log(Level.Debug, (format == null) ? null : string.Format(format, args));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004B75 File Offset: 0x00002D75
		public void Log(Level level, string format, params object[] args)
		{
			this.Log(level, (format == null) ? null : string.Format(format, args));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004B8B File Offset: 0x00002D8B
		public void Log(Level level, string message)
		{
			this.WriteEvent(new ListBoxLog.LogEvent(level, message));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004B9A File Offset: 0x00002D9A
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00004BA2 File Offset: 0x00002DA2
		public bool Paused
		{
			get
			{
				return this._paused;
			}
			set
			{
				this._paused = value;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004BAC File Offset: 0x00002DAC
		~ListBoxLog()
		{
			if (!this._disposed)
			{
				this.Dispose(false);
				this._disposed = true;
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004BE8 File Offset: 0x00002DE8
		public void Dispose()
		{
			if (!this._disposed)
			{
				this.Dispose(true);
				GC.SuppressFinalize(this);
				this._disposed = true;
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004C08 File Offset: 0x00002E08
		private void Dispose(bool disposing)
		{
			if (this._listBox != null)
			{
				this._canAdd = false;
				this._listBox.HandleCreated -= this.OnHandleCreated;
				this._listBox.HandleCreated -= this.OnHandleDestroyed;
				this._listBox.DrawItem -= this.DrawItemHandler;
				this._listBox.KeyDown -= this.KeyDownHandler;
				this._listBox.ContextMenu.MenuItems.Clear();
				this._listBox.ContextMenu.Popup -= this.CopyMenuPopupHandler;
				this._listBox.ContextMenu = null;
				this._listBox.Items.Clear();
				this._listBox.DrawMode = DrawMode.Normal;
				this._listBox = null;
			}
		}

		// Token: 0x04000047 RID: 71
		private const string DEFAULT_MESSAGE_FORMAT = "{0} [{5}] : {8}";

		// Token: 0x04000048 RID: 72
		private const int DEFAULT_MAX_LINES_IN_LISTBOX = 2000;

		// Token: 0x04000049 RID: 73
		private bool _disposed;

		// Token: 0x0400004A RID: 74
		private ListBox _listBox;

		// Token: 0x0400004B RID: 75
		private string _messageFormat;

		// Token: 0x0400004C RID: 76
		private int _maxEntriesInListBox;

		// Token: 0x0400004D RID: 77
		private bool _canAdd;

		// Token: 0x0400004E RID: 78
		private bool _paused;

		// Token: 0x0200000B RID: 11
		private class LogEvent
		{
			// Token: 0x06000061 RID: 97 RVA: 0x00004CE3 File Offset: 0x00002EE3
			public LogEvent(Level level, string message)
			{
				this.EventTime = DateTime.Now;
				this.Level = level;
				this.Message = message;
			}

			// Token: 0x0400004F RID: 79
			public readonly DateTime EventTime;

			// Token: 0x04000050 RID: 80
			public readonly Level Level;

			// Token: 0x04000051 RID: 81
			public readonly string Message;
		}

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x06000063 RID: 99
		private delegate void AddALogEntryDelegate(object item);
	}
}
