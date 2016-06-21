using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecogCaptcha;

namespace PrenotaTest
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			webBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser_DocumentCompleted);
		}


		private void SetLog(string msg)
		{
			txtLog.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - " + msg + Environment.NewLine + txtLog.Text;
		}
		private void SetLogCookie(string name, string value)
		{
			txtCookies.Text = name + " - " + value + Environment.NewLine + txtLog.Text;
		}

		private void btnGetLogin_Click(object sender, EventArgs e)
		{
			var url = txtUrl.Text;

			webBrowser.Navigate(url);
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
			DisplayMetaDescription();

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

		private void DisplayMetaDescription()
		{
			if (webBrowser.Document != null)
			{
				HtmlElement elem = webBrowser.Document.GetElementById("captchaLogin");
				if (elem != null)
				{
					String nameStr = elem.GetAttribute("src");
					SetLog("captchaLogin: " + nameStr);
					if (nameStr.IndexOf("captcha") > -1)
					{
						HttpWebRequest requestCaptcha = (HttpWebRequest)WebRequest.Create(nameStr);
						requestCaptcha.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:48.0) Gecko/20100101 Firefox/48.0";
						requestCaptcha.Method = "GET";
						requestCaptcha.Accept = "text/html";

						using (var responseCaptcha = (HttpWebResponse)requestCaptcha.GetResponse())
						{
							using (var streamCaptcha = responseCaptcha.GetResponseStream())
							{
								picBox.Image = Bitmap.FromStream(streamCaptcha);
							}
						}
					}
				}
			}
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
							elemUserName.InnerText = "dicaiado@gmail.com";
						}

						var elemPsw = webBrowser.Document.GetElementById("Password");
						if (elemPsw != null)
						{
							elemPsw.InnerText = "d4n13l4$";
						}

						var elemCaptcha = webBrowser.Document.GetElementById("captchaLogin");
						if (elemCaptcha != null)
						{
							GetCaptcha(elemCaptcha);
						}

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

		public void GetCaptcha(HtmlElement elem)
		{
			var nameStr = elem.GetAttribute("src");
			SetLog("captchaLogin: " + nameStr);
			if (nameStr.IndexOf("captcha", StringComparison.Ordinal) > -1)
			{
				var requestCaptcha = (HttpWebRequest)WebRequest.Create(nameStr);
				requestCaptcha.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:48.0) Gecko/20100101 Firefox/48.0";
				requestCaptcha.Method = "GET";
				requestCaptcha.Accept = "text/html";

				using (var responseCaptcha = (HttpWebResponse)requestCaptcha.GetResponse())
				{
					using (var streamCaptcha = responseCaptcha.GetResponseStream())
					{
						if (streamCaptcha != null)
						{
							var imgCaptcha = Image.FromStream(streamCaptcha);
							picBox.Image = imgCaptcha;

							var lstWord = new List<String>();
							//var filteredImg = Decaptcha.DecaptchaImg(imgCaptcha, ref lstWord);
							lstWord.ForEach(SetLog);

							//picBoxFiltered.Image = filteredImg;
						}
					}
				}
			}
		}

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
