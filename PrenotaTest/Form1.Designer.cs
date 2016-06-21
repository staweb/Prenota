namespace PrenotaTest
{
	partial class Form1
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
			this.txtCookies = new System.Windows.Forms.RichTextBox();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.picBox = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLog = new System.Windows.Forms.RichTextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.picBoxFiltered = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFiltered)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetLogin
			// 
			this.btnGetLogin.Location = new System.Drawing.Point(558, 6);
			this.btnGetLogin.Name = "btnGetLogin";
			this.btnGetLogin.Size = new System.Drawing.Size(75, 23);
			this.btnGetLogin.TabIndex = 6;
			this.btnGetLogin.Text = "Get Login";
			this.btnGetLogin.UseVisualStyleBackColor = true;
			this.btnGetLogin.Click += new System.EventHandler(this.btnGetLogin_Click);
			// 
			// txtUrl
			// 
			this.txtUrl.Location = new System.Drawing.Point(140, 9);
			this.txtUrl.Name = "txtUrl";
			this.txtUrl.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtUrl.Size = new System.Drawing.Size(412, 20);
			this.txtUrl.TabIndex = 5;
			this.txtUrl.Text = "https://prenotaonline.esteri.it/login.aspx?cidsede=100001&returnUrl=/";
			// 
			// txtCookies
			// 
			this.txtCookies.Location = new System.Drawing.Point(941, 220);
			this.txtCookies.Name = "txtCookies";
			this.txtCookies.Size = new System.Drawing.Size(275, 203);
			this.txtCookies.TabIndex = 9;
			this.txtCookies.Text = "";
			// 
			// webBrowser
			// 
			this.webBrowser.Location = new System.Drawing.Point(12, 35);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(923, 617);
			this.webBrowser.TabIndex = 10;
			// 
			// picBox
			// 
			this.picBox.Location = new System.Drawing.Point(941, 53);
			this.picBox.Name = "picBox";
			this.picBox.Size = new System.Drawing.Size(275, 61);
			this.picBox.TabIndex = 11;
			this.picBox.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(941, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 16);
			this.label2.TabIndex = 13;
			this.label2.Text = "Captcha";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(12, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(122, 20);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "Exibir HTML ?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(941, 201);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "Cookies";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(941, 426);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 16);
			this.label3.TabIndex = 17;
			this.label3.Text = "Log";
			// 
			// txtLog
			// 
			this.txtLog.Location = new System.Drawing.Point(941, 445);
			this.txtLog.Name = "txtLog";
			this.txtLog.Size = new System.Drawing.Size(275, 207);
			this.txtLog.TabIndex = 16;
			this.txtLog.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(941, 118);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 16);
			this.label4.TabIndex = 19;
			this.label4.Text = "Captcha Filtered";
			// 
			// picBoxFiltered
			// 
			this.picBoxFiltered.Location = new System.Drawing.Point(941, 137);
			this.picBoxFiltered.Name = "picBoxFiltered";
			this.picBoxFiltered.Size = new System.Drawing.Size(275, 61);
			this.picBoxFiltered.TabIndex = 18;
			this.picBoxFiltered.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1220, 664);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.picBoxFiltered);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtLog);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.picBox);
			this.Controls.Add(this.webBrowser);
			this.Controls.Add(this.txtCookies);
			this.Controls.Add(this.btnGetLogin);
			this.Controls.Add(this.txtUrl);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picBoxFiltered)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnGetLogin;
		private System.Windows.Forms.TextBox txtUrl;
		private System.Windows.Forms.RichTextBox txtCookies;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.PictureBox picBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.RichTextBox txtLog;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox picBoxFiltered;
	}
}

