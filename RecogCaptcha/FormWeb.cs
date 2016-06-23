using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using mshtml;
using Tesseract;
using Timer = System.Windows.Forms.Timer;

namespace RecogCaptcha
{ 
	public partial class FormWeb : Form
	{
		private List<string> _lstWord;
		private bool _flagIni;
		private bool _elemPrenotaFirstTime;

		public FormWeb()
		{
			InitializeComponent();
			_lstWord = new List<string>();
			_flagIni = true;
			_elemPrenotaFirstTime = true;
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);

			btnGetLogin_Click(null, null);
			//btnCaptcha04_Click(null, null);
		}


		private void SetLog(string msg)
		{
			txtLog.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + msg + Environment.NewLine + txtLog.Text;
		}
		private void SetLogCookie(string name, string value)
		{
			txtLog.Text = name + " - " + value + Environment.NewLine + txtLog.Text;
		}

		private void btnGetLogin_Click(object sender, EventArgs e)
		{
			var url = txtUrl.Text;

			webBrowser.Navigate(url);
			webBrowser.ScriptErrorsSuppressed = true;

			Thread.Sleep(3000);
			HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
			request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:48.0) Gecko/20100101 Firefox/48.0";
			//request.ContentType = "application/x-www-form-urlencoded";
			request.Method = "GET";
			request.Accept = "text/html";
		}

		private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			txtUrlResp.Text = webBrowser.Document != null && webBrowser.Document.Url != null ? webBrowser.Document.Url.ToString() : string.Empty;

			SetLog("Completo");

			var doc = webBrowser.Document;
			var iEvent = doc;
			if (iEvent != null) iEvent.Click += new HtmlElementEventHandler(ClickEventHandler);

			FillForm();


			var cookieContainer = GetCookieContainer();
			Hashtable table = (Hashtable)cookieContainer.GetType().InvokeMember("m_domainTable", BindingFlags.NonPublic | BindingFlags.GetField | BindingFlags.Instance, null, cookieContainer, new object[] { });
			foreach (var key in table.Keys)
			{
				foreach (Cookie cookie in cookieContainer.GetCookies(new Uri(string.Format("http://{0}/", key))))
				{
					SetLogCookie(cookie.Name, cookie.Value);
				}
			}
		}

		private void ClickEventHandler(object Sender, HtmlElementEventArgs e)
		{
			//SetLog("Clicou");
		}

		private void FillForm()
		{
			if (webBrowser.Document != null && webBrowser.Document.Url != null)
			{
				var urlWebBrowser = webBrowser.Document.Url;

				var flLocal = (urlWebBrowser.AbsolutePath.IndexOf("login", StringComparison.Ordinal) > -1 || urlWebBrowser.LocalPath.IndexOf("login", StringComparison.Ordinal) > -1);

				#region [ ViewState ]

				var elemViewState = webBrowser.Document.GetElementById("__VIEWSTATE");
				if (elemViewState != null)
				{
					if (_flagIni)
						txtViewState01.Text = elemViewState.GetAttribute("value");
					else
						txtViewState02.Text = elemViewState.GetAttribute("value");
				}

				var elemViewValidation = webBrowser.Document.GetElementById("__EVENTVALIDATION");
				if (elemViewValidation != null)
				{
					if (_flagIni)
						txtValidation01.Text = elemViewValidation.GetAttribute("value");
					else
						txtValidation02.Text = elemViewValidation.GetAttribute("value");
				}


				#endregion [ ViewState ]

				#region [ Login ]

				if (flLocal || urlWebBrowser.AbsolutePath.IndexOf("login", StringComparison.Ordinal) > -1 || urlWebBrowser.LocalPath.IndexOf("login", StringComparison.Ordinal) > -1)
				{
					#region [ Login 01 ]

					HtmlElement elemBtnLogin = webBrowser.Document.GetElementById("BtnLogin");
					if (elemBtnLogin != null)
					{
						SetState();

						elemBtnLogin.InvokeMember("click");
						SetLog("Login 01 ativado");
						return;
					}

					#endregion

					#region [ Login 02 ]

					var elemUserName = webBrowser.Document.GetElementById("UserName");
					if (elemUserName != null)
					{
						elemUserName.InnerText = txtLogin.Text;
					}

					var elemPsw = webBrowser.Document.GetElementById("Password");
					if (elemPsw != null)
					{
						elemPsw.InnerText = txtPsw.Text;
					}

					if(ckCaptcha.Checked)
						btnGetCaptcha_Click(null, null);

					var elemBtnConfermaL = webBrowser.Document.GetElementById("BtnConfermaL");
					if (elemBtnConfermaL != null)
					{
						//elemBtnConfermaL.InvokeMember("click");
						SetLog("Login 02 ativado");
					}

					#endregion
				}

				#endregion [ Login ]

				#region [ Prenota 01 ]

				var elemPrenota = webBrowser.Document.GetElementById("ctl00_repFunzioni_ctl00_btnMenuItem");
				if (elemPrenota != null && _elemPrenotaFirstTime)
				{
					elemPrenota.InvokeMember("click");
					SetLog("Prenota 01");
					_elemPrenotaFirstTime = false;
                    return;
				}

				#endregion [ Prenota 01 ]

				#region [ Prenota 02 - Calendar / Confirma ]

				if (flLocal || urlWebBrowser.AbsolutePath.IndexOf("acc_Prenota", StringComparison.Ordinal) > -1 || urlWebBrowser.LocalPath.IndexOf("acc_Prenota", StringComparison.Ordinal) > -1)
				{
					#region [ 03 - Prenota Calendar Confirma ]

					var elemCalendarConferma = webBrowser.Document.GetElementById("ctl00_ContentPlaceHolder1_acc_Calendario1_repFasce_ctl01_btnConferma");
					if (elemCalendarConferma != null)
					{
						elemCalendarConferma.InvokeMember("click");
						SetLog("Prenota 02 - Calendar Confirma");
						return;
					}

					#endregion [ 03 - Prenota Calendar Confirma ]

					#region [ 02 - Prenota Calendar ]

					var elemCalendar = webBrowser.Document.GetElementById("ctl00_ContentPlaceHolder1_acc_Calendario1_myCalendario1");
					if (elemCalendar != null)
					{
						_flCalendario = true;
						InitTimerCheckCalendar();
						return;
					}

					#endregion [ 02 - Prenota Calendar ]

					#region [ 01 - Prenota ]

					var elemPrenotaContinua = webBrowser.Document.GetElementById("ctl00_ContentPlaceHolder1_acc_datiAddizionali1_btnContinua");
					if (elemPrenotaContinua != null)
					{
						elemPrenotaContinua.InvokeMember("click");
						SetLog("Prenota 02 - Legalizzazione Continua");
						return;
					}

					#endregion [ 01 - Prenota ]

					#region [ 01 - Prenota ]

					var elemPrenotaLegalizzazione = webBrowser.Document.GetElementById("ctl00_ContentPlaceHolder1_rpServizi_ctl04_btnNomeServizio");
					if (elemPrenotaLegalizzazione != null)
					{
						elemPrenotaLegalizzazione.InvokeMember("click");
						SetLog("Prenota 02 - Legalizzazione");
					}

					#endregion [ 01 - Prenota ]
				}


				#endregion [ Prenota 02 - Calendar / Confirma ]

				_flagIni = false;
			}
		}

		#region [ CheckCalendar ]

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			webBrowser.Refresh();
		}

		private void btnStartLoop_Click(object sender, EventArgs e)
		{
			var elemCalendar = webBrowser.Document != null ? webBrowser.Document.GetElementById("ctl00_ContentPlaceHolder1_acc_Calendario1_myCalendario1") : null;
			if (elemCalendar != null)
			{
				InitTimerCheckCalendar();
			}
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			_timer.Stop();
			_timer.Enabled = false;
			lbLoopOnline.Text = "OFF";
			lbLoopOnline.ForeColor = Color.Red;
		}

		private Timer _timer;
		private bool _flCalendario = false;
		public void InitTimerCheckCalendar()
		{
			if (_timer != null && _timer.Enabled) return;

			_timer = new Timer();
			_timer.Tick += new EventHandler(CheckCalendarLoop);
			_timer.Interval = Convert.ToInt32(numStep.Value * 1000); // in miliseconds
			_timer.Enabled = true;
			_timer.Start();
			lbLoopOnline.Text = "ON";
			lbLoopOnline.ForeColor = Color.DarkGreen;
        }

		private void CheckCalendarLoop(object sender, EventArgs e)
		{
			if (!CheckCalendar() && _flCalendario)
			{
				_flCalendario = false;
                webBrowser.GoBack();
				//webBrowser.Refresh(WebBrowserRefreshOption.Normal);
			}
		}

		private bool CheckCalendar()
		{
			SetLog("Prenota 02 - Start Calendar");
			foreach (var item in webBrowser.Document.GetElementsByTagName("input").Cast<HtmlElement>().Where(item => item.OuterHtml.Contains("pulsanteCalendario")))
			{
				if (item.GetAttribute("type").Equals("submit")
						&& !item.GetAttribute("name").Equals("ctl00$ContentPlaceHolder1$acc_Calendario1$myCalendario1$ctl01")
						&& !item.GetAttribute("name").Equals("ctl00$ContentPlaceHolder1$acc_Calendario1$myCalendario1$ctl03")
				)
				{
					item.InvokeMember("Click");
					SetLog("Prenota 02 - Input found");

					btnStop_Click(null, null);
                    return true;
				}
			}

			foreach (var item in webBrowser.Document.GetElementsByTagName("td").Cast<HtmlElement>().Where(item => item.OuterHtml.Contains("calendarCellOpen")))
			{
				foreach (var childItem in item.Children.Cast<HtmlElement>().Where(childItem => childItem.TagName == "input"))
				{
					childItem.InvokeMember("Click");
					SetLog("Prenota 02 - Open Input found");
					btnStop_Click(null, null);
					return true;
				}
			}
			return false;
		}

		#endregion [ CheckCalendar ]

		private void SetState()
		{
			if (!_flagIni || webBrowser.Document == null) return;

			var elemViewState = webBrowser.Document.GetElementById("__VIEWSTATE");
			if (elemViewState != null)
			{
				if (!string.IsNullOrEmpty(txtViewState01.Text))
					elemViewState.SetAttribute("value", txtViewState01.Text);
			}

			var elemViewValidation = webBrowser.Document.GetElementById("__EVENTVALIDATION");
			if (elemViewValidation != null)
			{
				if (!string.IsNullOrEmpty(txtValidation01.Text))
					elemViewValidation.SetAttribute("value", txtValidation01.Text);
			}
		}

		#region [ Get Captcha By SRC ]

		private void btnCaptcha04_Click(object sender, EventArgs e)
		{
			ProcessGetCaptchaByElement(@"https://prenotaonline.esteri.it/captcha/default.aspx?pos=2&vers=787&vers=852");
		}
		private void btnCaptcha10_Click(object sender, EventArgs e)
		{
			ProcessGetCaptchaByElement(@"https://prenotaonline.esteri.it/captcha/default.aspx?pos=3&vers=425&vers=461&vers=690&vers=523&vers=217");
		}
		public void GetCaptchaByElement(HtmlElement elem)
		{
			var nameStr = elem.GetAttribute("src");
			SetLog("captchaLogin: " + nameStr);
			if (nameStr.IndexOf("captcha", StringComparison.Ordinal) > -1)
			{
				ProcessGetCaptchaByElement(nameStr);
			}
		}
		public void ProcessGetCaptchaByElement(string url)
		{
			var requestCaptcha = (HttpWebRequest)WebRequest.Create(url);
			requestCaptcha.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:48.0) Gecko/20100101 Firefox/48.0";
			requestCaptcha.Method = "GET";
			requestCaptcha.Accept = "text/html";

			using (var responseCaptcha = (HttpWebResponse)requestCaptcha.GetResponse())
			{
				using (var streamCaptcha = responseCaptcha.GetResponseStream())
				{
					if (streamCaptcha != null)
					{
						ProcessGetCaptcha(Image.FromStream(streamCaptcha));
					}
				}
			}
		}

		#endregion [ Get Captcha By SRC ]

		#region [ Get Captcha By Image ]

		private void btnSelectCaptcha_Click(object sender, EventArgs e)
		{
			openFileDialog.ShowDialog();
		}
		private void openFileDialog_FileOk(object sender, CancelEventArgs e)
		{
			Bitmap image = new Bitmap(openFileDialog.FileName);
			if (image != null)
			{
				ProcessGetCaptcha(new Bitmap(openFileDialog.FileName));
			}
			image.Dispose();
		}

		private void btnGetCaptcha_Click(object sender, EventArgs e)
		{
            if (webBrowser.Document == null) return;

			var elemCaptcha = webBrowser.Document.GetElementById("captchaLogin");
			if (elemCaptcha == null) return;

			ProcessGetCaptcha(Getimg.CopyImageAlt(webBrowser, elemCaptcha));
		}
		private void ProcessGetCaptcha(Image imgCaptcha)
		{
			picBox.Image = imgCaptcha;
			Decaptcha.ApplyOcr((Bitmap)imgCaptcha, ref _lstWord);

			var filteredImg = Getimg.ApplyFilters(imgCaptcha);
			picBoxFiltered.Image = filteredImg;
			Decaptcha.ApplyOcr((Bitmap)filteredImg, ref _lstWord);

			filteredImg = Getimg.ApplyFilters02(imgCaptcha);
			picBox3.Image = filteredImg;
			Decaptcha.ApplyOcr((Bitmap)filteredImg, ref _lstWord);

			filteredImg = Getimg.ApplyFilters03(filteredImg);
			picBox4.Image = filteredImg;
			Decaptcha.ApplyOcr((Bitmap)filteredImg, ref _lstWord);

			_lstWord.ForEach(item => SetLog("Decaptcha: " + item));
		}

		#endregion [ Get Captcha By Image ]

		public CookieContainer GetCookieContainer()
		{
			var container = new CookieContainer();
			if (webBrowser.Document != null && webBrowser.Document.Cookie != null)
			{
				foreach (var cookie in webBrowser.Document.Cookie.Split(';'))
				{
					var name = cookie.Split('=')[0];
					var value = cookie.Substring(name.Length + 1);
					container.Add(new Cookie(name.Trim(), value.Trim(), "/", "prenotaonline.esteri.it"));
				}
			}
			return container;
		}
	}
}
