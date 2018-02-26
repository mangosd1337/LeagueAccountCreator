using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Windows.Forms;
using DeathByCaptcha;
using maxCreator.Properties;
using maxCreator.Vendor;
using OpenQA.Selenium;
using OpenQA.Selenium.PhantomJS;
using RPGKit.FantasyNameGenerator;
using RPGKit.FantasyNameGenerator.Generators;

namespace maxCreator
{
	// Token: 0x02000003 RID: 3
	internal class lol
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x0000241C File Offset: 0x0000061C
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002424 File Offset: 0x00000624
		public string cpt { get; set; }

		// Token: 0x06000010 RID: 16 RVA: 0x00002430 File Offset: 0x00000630
		public lol()
		{
			PhantomJSDriverService phantomJSDriverService = PhantomJSDriverService.CreateDefaultService();
			phantomJSDriverService.HideCommandPromptWindow = true;
			this._driver = new PhantomJSDriver(phantomJSDriverService);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002468 File Offset: 0x00000668
		public Account create(ListBoxLog listBoxLog, string region)
		{
			Account account = new Account();
			FantasyNameSettings fantasyNameSettings = new FantasyNameSettings(Classes.Warrior, Race.None, true, true, Gender.Male);
			IFantasyNameGenerator fantasyNameGenerator = FantasyNameGenerator.FromSettingsInfo(fantasyNameSettings);
			account.Name = fantasyNameGenerator.GetFantasyNames(1).First<FantasyName>().FirstName + fantasyNameGenerator.GetFantasyNames(10).First<FantasyName>().LastName;
			if (Settings.Default.settings_namerandom)
			{
				Account account2 = account;
				account2.Name += MathCalculations.RandomNumber(1000, 9999);
			}
			account.Password = this.CreatePassword();
			account.Email = account.Name + "@gmail.com";
			account.Birthday = this.RandomBirthday();
			account.Region = region;
			this._driver.Manage().Timeouts().ImplicitlyWait(new TimeSpan(0, 0, 30));
			this._driver.Navigate().GoToUrl("https://signup." + account.Region + ".leagueoflegends.com/en/signup/");
			this._driver.FindElement(By.Id("PvpnetAccountName")).SendKeys(account.Name);
			this._driver.FindElement(By.Id("PvpnetAccountPassword")).SendKeys(account.Password);
			this._driver.FindElement(By.Id("PvpnetAccountConfirmPassword")).SendKeys(account.Password);
			this._driver.FindElement(By.Id("PvpnetAccountEmailAddress")).SendKeys(account.Email);
			this._driver.FindElement(By.Id("PvpnetAccountDateOfBirthDay")).SendKeys(account.Birthday.Day.ToString().PadLeft(2, '0'));
			this._driver.FindElement(By.Id("PvpnetAccountDateOfBirthMonth")).SendKeys(account.Birthday.Month.ToString().PadLeft(2, '0'));
			this._driver.FindElement(By.Id("PvpnetAccountDateOfBirthYear")).SendKeys(account.Birthday.Year.ToString());
			this._driver.FindElement(By.Id("PvpnetAccountTouAgree")).Click();
			account.CaptchaImage = Image.FromStream(WebRequest.Create(string.Format(this._driver.FindElement(By.Id("recaptcha_challenge_image")).GetAttribute("src"), new object[0])).GetResponse().GetResponseStream());
			if (Settings.Default.settings_usedbc)
			{
				Client client = new SocketClient(Settings.Default.dbc_login.ToString(), Settings.Default.dbc_passwd.ToString());
				try
				{
					client.GetBalance();
					lol.captcha = client.Decode(WebRequest.Create(string.Format(this._driver.FindElement(By.Id("recaptcha_challenge_image")).GetAttribute("src"), new object[0])).GetResponse().GetResponseStream());
					if (lol.captcha != null)
					{
						Console.WriteLine("CAPTCHA {0} solved: {1}", lol.captcha.Id, lol.captcha.Text);
						this.cpt = lol.captcha.Text;
					}
					goto IL_396;
				}
				catch (AccessDeniedException)
				{
					goto IL_396;
				}
			}
			using (captchaForm captchaForm = new captchaForm(account.CaptchaImage))
			{
				listBoxLog.Log(Level.Info, "Manual Captcha Solving!");
				DialogResult dialogResult = captchaForm.ShowDialog();
				if (dialogResult == DialogResult.OK)
				{
					this.cpt = captchaForm.CaptchaText;
				}
				else if (dialogResult == DialogResult.Cancel)
				{
					captchaForm.canceled = false;
					listBoxLog.Log(Level.Warning, "User has Canceled the Process!");
					return account;
				}
			}
			IL_396:
			this._driver.FindElement(By.Id("recaptcha_response_field")).SendKeys(this.cpt);
			this._driver.FindElement(By.Id("AccountSubmit")).Click();
			try
			{
				string text = this._driver.FindElement(By.XPath("//*[text()='Your account has been created!']")).Text;
				if (text.Length > 0)
				{
					FormHandler.MainForm_.UpdateGrid(account);
					FormHandler.MainForm_.DeathbyCaptcha();
					listBoxLog.Log(Level.Info, string.Concat(new string[]
					{
						"Account Created: ",
						account.Name,
						" ",
						account.Password,
						" @ ",
						account.Region
					}));
				}
				else
				{
					listBoxLog.Log(Level.Warning, "Could not Create Account - Unknown Error!");
				}
			}
			catch
			{
				listBoxLog.Log(Level.Warning, "Could not Create Account - Unknown Error!");
			}
			this._driver.Quit();
			return account;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002928 File Offset: 0x00000B28
		public string CreatePassword()
		{
			char[][] array = new char[][]
			{
				lol.PASSWORD_CHARS_LCASE.ToCharArray(),
				lol.PASSWORD_CHARS_UCASE.ToCharArray(),
				lol.PASSWORD_CHARS_NUMERIC.ToCharArray()
			};
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i] = array[i].Length;
			}
			int[] array3 = new int[array.Length];
			for (int j = 0; j < array3.Length; j++)
			{
				array3[j] = j;
			}
			byte[] array4 = new byte[4];
			RNGCryptoServiceProvider rngcryptoServiceProvider = new RNGCryptoServiceProvider();
			rngcryptoServiceProvider.GetBytes(array4);
			int seed = BitConverter.ToInt32(array4, 0);
			Random random = new Random(seed);
			char[] array5 = new char[15];
			int num = array3.Length - 1;
			for (int k = 0; k < array5.Length; k++)
			{
				int num2;
				if (num == 0)
				{
					num2 = 0;
				}
				else
				{
					num2 = random.Next(0, num);
				}
				int num3 = array3[num2];
				int num4 = array2[num3] - 1;
				int num5;
				if (num4 == 0)
				{
					num5 = 0;
				}
				else
				{
					num5 = random.Next(0, num4 + 1);
				}
				array5[k] = array[num3][num5];
				if (num4 == 0)
				{
					array2[num3] = array[num3].Length;
				}
				else
				{
					if (num4 != num5)
					{
						char c = array[num3][num4];
						array[num3][num4] = array[num3][num5];
						array[num3][num5] = c;
					}
					array2[num3]--;
				}
				if (num == 0)
				{
					num = array3.Length - 1;
				}
				else
				{
					if (num != num2)
					{
						int num6 = array3[num];
						array3[num] = array3[num2];
						array3[num2] = num6;
					}
					num--;
				}
			}
			return new string(array5);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002AC8 File Offset: 0x00000CC8
		private DateTime RandomBirthday()
		{
			Random random = new Random();
			int year = random.Next(1960, 1995);
			int month = random.Next(1, 12);
			int maxValue = DateTime.DaysInMonth(year, month);
			int day = random.Next(1, maxValue);
			DateTime result = new DateTime(year, month, day);
			return result;
		}

		// Token: 0x0400000B RID: 11
		private IWebDriver _driver;

		// Token: 0x0400000C RID: 12
		public static Captcha captcha;

		// Token: 0x0400000D RID: 13
		private Random random = new Random();

		// Token: 0x0400000E RID: 14
		private static string PASSWORD_CHARS_LCASE = "abcdefgijkmnopqrstwxyz";

		// Token: 0x0400000F RID: 15
		private static string PASSWORD_CHARS_UCASE = "ABCDEFGHJKLMNPQRSTWXYZ";

		// Token: 0x04000010 RID: 16
		private static string PASSWORD_CHARS_NUMERIC = "23456789";
	}
}
