using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using AForge.Imaging.Filters;
using mshtml;
using Tesseract;

namespace RecogCaptcha
{ 
	public partial class FormWeb : Form
	{
		private List<string> _lstWord;

		public FormWeb()
		{
			InitializeComponent();
			_lstWord = new List<string>();
            webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);

			//btnGetLogin_Click(null, null);
			btnCaptcha04_Click(null, null);
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

			// execute the request
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			//foreach (Cookie cook in response.Cookies)
			//{
			//	txtResult.Text = cook.Name + " - " + cook.Value + "<br>";
			//}

			//string content = new StreamReader(response.GetResponseStream()).ReadToEnd();
			//webBrowser.DocumentText = content;
		}

		private void webBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
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
			SetLog("Clicou");
		}

		private void FillForm()
		{
			if (webBrowser.Document != null)
			{
				if (webBrowser.Document.Url != null)
				{
					var urlWebBrowser = webBrowser.Document.Url;

					#region [ Login ]

					if (urlWebBrowser.AbsolutePath.IndexOf("login", StringComparison.Ordinal) > -1 || urlWebBrowser.LocalPath.IndexOf("login", StringComparison.Ordinal) > -1)
					{
						#region [ Login 01 ]

						HtmlElement elemBtnLogin = webBrowser.Document.GetElementById("BtnLogin");
						if (elemBtnLogin != null)
						{
							elemBtnLogin.InvokeMember("click");
							SetLog("Login 01 ativado");
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

						btnGetCaptcha_Click(null, null);

						var elemBtnConfermaL = webBrowser.Document.GetElementById("BtnConfermaL");
						if (elemBtnConfermaL != null)
						{
							//elemBtnConfermaL.InvokeMember("click");
							SetLog("Login 02 ativado");
						}

						#endregion
					}

					#endregion
				}
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
			var elemCaptcha = webBrowser.Document?.GetElementById("captchaLogin");
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
