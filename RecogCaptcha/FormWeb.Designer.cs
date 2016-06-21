namespace RecogCaptcha
{
	partial class FormWeb
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnGetLogin = new System.Windows.Forms.Button();
			this.txtUrl = new System.Windows.Forms.TextBox();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.picBox = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLog = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.picBoxFiltered = new System.Windows.Forms.PictureBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.btnSelectCaptcha = new System.Windows.Forms.Button();
			this.btnGetCaptcha = new System.Windows.Forms.Button();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPsw = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.picBox4 = new System.Windows.Forms.PictureBox();
			this.picBox3 = new System.Windows.Forms.PictureBox();
			this.btnCaptcha04 = new System.Windows.Forms.Button();
			this.btnCaptcha10 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFiltered)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetLogin
			// 
			this.btnGetLogin.Location = new System.Drawing.Point(666, 4);
			this.btnGetLogin.Name = "btnGetLogin";
			this.btnGetLogin.Size = new System.Drawing.Size(65, 23);
			this.btnGetLogin.TabIndex = 6;
			this.btnGetLogin.Text = "Get Login";
			this.btnGetLogin.UseVisualStyleBackColor = true;
			this.btnGetLogin.Click += new System.EventHandler(this.btnGetLogin_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(317, 6);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtUrl.Size = new System.Drawing.Size(345, 20);
			this.txtUrl.TabIndex = 5;
			this.txtUrl.Text = "https://prenotaonline.esteri.it/login.aspx?cidsede=100001&returnUrl=/";
			// 
			// webBrowser
			// 
			this.webBrowser.Location = new System.Drawing.Point(12, 35);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(885, 617);
			this.webBrowser.TabIndex = 10;
			// 
			// picBox
			// 
			this.picBox.Location = new System.Drawing.Point(903, 60);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(200, 100);
			this.picBox.TabIndex = 11;
			this.picBox.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(903, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Captcha 01";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(900, 285);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 16);
			this.label3.TabIndex = 17;
			this.label3.Text = "Log";
			// 
			// txtLog
			// 
			this.txtLog.Location = new System.Drawing.Point(903, 304);
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(391, 347);
			this.txtLog.TabIndex = 16;
			this.txtLog.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(903, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 16);
			this.label4.TabIndex = 19;
			this.label4.Text = "Captcha 02";
			// 
			// picBoxFiltered
			// 
			this.picBoxFiltered.Location = new System.Drawing.Point(903, 182);
			this.picBoxFiltered.Name = "picBoxFiltered";
			this.picBoxFiltered.Size = new System.Drawing.Size(200, 100);
			this.picBoxFiltered.TabIndex = 18;
			this.picBoxFiltered.TabStop = false;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
			// 
			// btnSelectCaptcha
			// 
			this.btnSelectCaptcha.Location = new System.Drawing.Point(816, 3);
			this.btnSelectCaptcha.Name = "btnSelectCaptcha";
			this.btnSelectCaptcha.Size = new System.Drawing.Size(59, 23);
			this.btnSelectCaptcha.TabIndex = 20;
			this.btnSelectCaptcha.Text = "Arquivo";
			this.btnSelectCaptcha.UseVisualStyleBackColor = true;
			this.btnSelectCaptcha.Click += new System.EventHandler(this.btnSelectCaptcha_Click);
			// 
			// btnGetCaptcha
			// 
			this.btnGetCaptcha.Location = new System.Drawing.Point(737, 3);
			this.btnGetCaptcha.Name = "btnGetCaptcha";
			this.btnGetCaptcha.Size = new System.Drawing.Size(73, 23);
			this.btnGetCaptcha.TabIndex = 21;
			this.btnGetCaptcha.Text = "GetCaptcha";
			this.btnGetCaptcha.UseVisualStyleBackColor = true;
			this.btnGetCaptcha.Click += new System.EventHandler(this.btnGetCaptcha_Click);
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(56, 8);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(107, 20);
			this.txtLogin.TabIndex = 22;
			this.txtLogin.Text = "dicaiado@gmail.com";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(10, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "User";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(169, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 16);
			this.label6.TabIndex = 25;
			this.label6.Text = "Psw";
			// 
			// txtPsw
			// 
			this.txtPsw.Location = new System.Drawing.Point(210, 8);
			this.txtPsw.Name = "txtPsw";
			this.txtPsw.Size = new System.Drawing.Size(66, 20);
			this.txtPsw.TabIndex = 24;
			this.txtPsw.Text = "d4n13l4$";
			this.txtPsw.UseSystemPasswordChar = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(282, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 16);
			this.label7.TabIndex = 26;
			this.label7.Text = "URL";
			// 
			// picBox4
			// 
			this.picBox4.Location = new System.Drawing.Point(1109, 182);
			this.picBox4.Name = "picBox4";
			this.picBox4.Size = new System.Drawing.Size(200, 100);
			this.picBox4.TabIndex = 29;
			this.picBox4.TabStop = false;
			// 
			// picBox3
			// 
			this.picBox3.Location = new System.Drawing.Point(1109, 60);
			this.picBox3.Name = "picBox3";
			this.picBox3.Size = new System.Drawing.Size(200, 100);
			this.picBox3.TabIndex = 28;
			this.picBox3.TabStop = false;
			// 
			// btnCaptcha04
			// 
			this.btnCaptcha04.Location = new System.Drawing.Point(906, 2);
			this.btnCaptcha04.Name = "btnCaptcha04";
			this.btnCaptcha04.Size = new System.Drawing.Size(78, 23);
			this.btnCaptcha04.TabIndex = 30;
			this.btnCaptcha04.Text = "Captcha 04";
			this.btnCaptcha04.UseVisualStyleBackColor = true;
			this.btnCaptcha04.Click += new System.EventHandler(this.btnCaptcha04_Click);
			// 
			// btnCaptcha10
			// 
			this.btnCaptcha10.Location = new System.Drawing.Point(990, 2);
			this.btnCaptcha10.Name = "btnCaptcha10";
			this.btnCaptcha10.Size = new System.Drawing.Size(78, 23);
			this.btnCaptcha10.TabIndex = 31;
			this.btnCaptcha10.Text = "Captcha 10";
			this.btnCaptcha10.UseVisualStyleBackColor = true;
			this.btnCaptcha10.Click += new System.EventHandler(this.btnCaptcha10_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(1106, 163);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 16);
			this.label1.TabIndex = 32;
			this.label1.Text = "Captcha 04";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(1106, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 16);
			this.label8.TabIndex = 33;
			this.label8.Text = "Captcha 03";
			// 
			// FormWeb
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1306, 664);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCaptcha10);
			this.Controls.Add(this.btnCaptcha04);
			this.Controls.Add(this.picBox4);
			this.Controls.Add(this.picBox3);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtPsw);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.btnGetCaptcha);
			this.Controls.Add(this.btnSelectCaptcha);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.picBoxFiltered);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.picBox);
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.btnGetLogin);
			this.Controls.Add(this.txtUrl);
			this.Name = "FormWeb";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFiltered)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnGetLogin;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.PictureBox picBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txtLog;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox picBoxFiltered;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Button btnSelectCaptcha;
		private System.Windows.Forms.Button btnGetCaptcha;
		private System.Windows.Forms.TextBox txtLogin;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPsw;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox picBox4;
		private System.Windows.Forms.PictureBox picBox3;
		private System.Windows.Forms.Button btnCaptcha04;
		private System.Windows.Forms.Button btnCaptcha10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
	}
}

