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
			this.txtViewState01 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txtValidation01 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtUrlResp = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.txtViewState02 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txtValidation02 = new System.Windows.Forms.TextBox();
			this.ckCaptcha = new System.Windows.Forms.CheckBox();
			this.label14 = new System.Windows.Forms.Label();
			this.numStep = new System.Windows.Forms.NumericUpDown();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnStartLoop = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lbLoopOnline = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFiltered)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numStep)).BeginInit();
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
			this.webBrowser.Location = new System.Drawing.Point(12, 137);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(885, 503);
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
			this.label2.Size = new System.Drawing.Size(85, 16);
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
			this.label4.Size = new System.Drawing.Size(85, 16);
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
			this.btnSelectCaptcha.Location = new System.Drawing.Point(1072, 2);
			this.btnSelectCaptcha.Name = "btnSelectCaptcha";
			this.btnSelectCaptcha.Size = new System.Drawing.Size(59, 23);
			this.btnSelectCaptcha.TabIndex = 20;
			this.btnSelectCaptcha.Text = "Arquivo";
			this.btnSelectCaptcha.UseVisualStyleBackColor = true;
			this.btnSelectCaptcha.Click += new System.EventHandler(this.btnSelectCaptcha_Click);
			// 
			// btnGetCaptcha
			// 
			this.btnGetCaptcha.Location = new System.Drawing.Point(993, 2);
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
			this.btnCaptcha04.Location = new System.Drawing.Point(1137, 3);
			this.btnCaptcha04.Name = "btnCaptcha04";
			this.btnCaptcha04.Size = new System.Drawing.Size(78, 23);
			this.btnCaptcha04.TabIndex = 30;
			this.btnCaptcha04.Text = "Captcha 04";
			this.btnCaptcha04.UseVisualStyleBackColor = true;
			this.btnCaptcha04.Click += new System.EventHandler(this.btnCaptcha04_Click);
			// 
			// btnCaptcha10
			// 
			this.btnCaptcha10.Location = new System.Drawing.Point(1221, 3);
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
			this.label1.Size = new System.Drawing.Size(85, 16);
			this.label1.TabIndex = 32;
			this.label1.Text = "Captcha 04";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(1106, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(85, 16);
			this.label8.TabIndex = 33;
			this.label8.Text = "Captcha 03";
			// 
			// txtViewState01
			// 
			this.txtViewState01.Location = new System.Drawing.Point(13, 85);
			this.txtViewState01.Multiline = true;
			this.txtViewState01.Name = "txtViewState01";
			this.txtViewState01.Size = new System.Drawing.Size(204, 46);
			this.txtViewState01.TabIndex = 34;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(12, 67);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(118, 15);
			this.label9.TabIndex = 35;
			this.label9.Text = "__VIEWSTATE 01";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(429, 67);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(165, 15);
			this.label10.TabIndex = 37;
			this.label10.Text = "__EVENTVALIDATION 01";
			// 
			// txtValidation01
			// 
			this.txtValidation01.Location = new System.Drawing.Point(432, 85);
			this.txtValidation01.Multiline = true;
			this.txtValidation01.Name = "txtValidation01";
			this.txtValidation01.Size = new System.Drawing.Size(230, 46);
			this.txtValidation01.TabIndex = 36;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(12, 37);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(72, 15);
			this.label11.TabIndex = 38;
			this.label11.Text = "URL Resp";
			// 
			// txtUrlResp
			// 
			this.txtUrlResp.Location = new System.Drawing.Point(90, 34);
			this.txtUrlResp.Name = "txtUrlResp";
			this.txtUrlResp.Size = new System.Drawing.Size(572, 20);
			this.txtUrlResp.TabIndex = 39;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(238, 67);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(118, 15);
			this.label12.TabIndex = 41;
			this.label12.Text = "__VIEWSTATE 02";
			// 
			// txtViewState02
			// 
			this.txtViewState02.Location = new System.Drawing.Point(223, 85);
			this.txtViewState02.Multiline = true;
			this.txtViewState02.Name = "txtViewState02";
			this.txtViewState02.Size = new System.Drawing.Size(203, 46);
			this.txtViewState02.TabIndex = 40;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(663, 67);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(165, 15);
			this.label13.TabIndex = 43;
			this.label13.Text = "__EVENTVALIDATION 02";
			// 
			// txtValidation02
			// 
			this.txtValidation02.Location = new System.Drawing.Point(666, 85);
			this.txtValidation02.Multiline = true;
			this.txtValidation02.Name = "txtValidation02";
			this.txtValidation02.Size = new System.Drawing.Size(230, 46);
			this.txtValidation02.TabIndex = 42;
			// 
			// ckCaptcha
			// 
			this.ckCaptcha.AutoSize = true;
			this.ckCaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ckCaptcha.Location = new System.Drawing.Point(903, 6);
			this.ckCaptcha.Name = "ckCaptcha";
			this.ckCaptcha.Size = new System.Drawing.Size(84, 17);
			this.ckCaptcha.TabIndex = 44;
			this.ckCaptcha.Text = "Captcha ?";
			this.ckCaptcha.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(665, 36);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(39, 15);
			this.label14.TabIndex = 46;
			this.label14.Text = "Loop";
			// 
			// numStep
			// 
			this.numStep.Location = new System.Drawing.Point(707, 34);
			this.numStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numStep.Name = "numStep";
			this.numStep.Size = new System.Drawing.Size(47, 20);
			this.numStep.TabIndex = 47;
			this.numStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numStep.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(737, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(65, 23);
			this.btnRefresh.TabIndex = 48;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnStartLoop
			// 
			this.btnStartLoop.Location = new System.Drawing.Point(801, 33);
			this.btnStartLoop.Name = "btnStartLoop";
			this.btnStartLoop.Size = new System.Drawing.Size(41, 23);
			this.btnStartLoop.TabIndex = 49;
			this.btnStartLoop.Text = "Start";
			this.btnStartLoop.UseVisualStyleBackColor = true;
			this.btnStartLoop.Click += new System.EventHandler(this.btnStartLoop_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(756, 33);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(41, 23);
			this.btnStop.TabIndex = 50;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lbLoopOnline
			// 
			this.lbLoopOnline.AutoSize = true;
			this.lbLoopOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLoopOnline.ForeColor = System.Drawing.Color.Red;
			this.lbLoopOnline.Location = new System.Drawing.Point(843, 37);
			this.lbLoopOnline.Name = "lbLoopOnline";
			this.lbLoopOnline.Size = new System.Drawing.Size(33, 15);
			this.lbLoopOnline.TabIndex = 51;
			this.lbLoopOnline.Text = "OFF";
			// 
			// FormWeb
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1306, 664);
			this.Controls.Add(this.lbLoopOnline);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStartLoop);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.numStep);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.ckCaptcha);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.txtValidation02);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.txtViewState02);
			this.Controls.Add(this.txtUrlResp);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtValidation01);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtViewState01);
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
			((System.ComponentModel.ISupportInitialize)(this.numStep)).EndInit();
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
		private System.Windows.Forms.TextBox txtViewState01;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtValidation01;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtUrlResp;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox txtViewState02;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtValidation02;
		private System.Windows.Forms.CheckBox ckCaptcha;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.NumericUpDown numStep;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnStartLoop;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lbLoopOnline;
	}
}

