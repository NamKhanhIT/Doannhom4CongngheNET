namespace Doannhom4CongngheNET
{
    partial class FrmLogin
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.BtnSignUp = new System.Windows.Forms.Button();
            this.lbSignUp = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.BtnClose = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.BtnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.CbPassword = new System.Windows.Forms.CheckBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtAccount = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.lbAccount = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelLogin.Controls.Add(this.LoginPicture);
            this.panelLogin.Controls.Add(this.BtnSignUp);
            this.panelLogin.Controls.Add(this.lbSignUp);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(359, 474);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // LoginPicture
            // 
            this.LoginPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginPicture.Image = global::Doannhom4CongngheNET.Properties.Resources.Logo_Trường_ĐH_Vinh___VinhUni;
            this.LoginPicture.Location = new System.Drawing.Point(70, 51);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(210, 163);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPicture.TabIndex = 3;
            this.LoginPicture.TabStop = false;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSignUp.BackColor = System.Drawing.Color.MistyRose;
            this.BtnSignUp.FlatAppearance.BorderSize = 0;
            this.BtnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignUp.Location = new System.Drawing.Point(99, 344);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(149, 45);
            this.BtnSignUp.TabIndex = 5;
            this.BtnSignUp.Text = "Đăng kí";
            this.BtnSignUp.UseVisualStyleBackColor = false;
            this.BtnSignUp.Click += new System.EventHandler(this.BtnSignUp_Click);
            // 
            // lbSignUp
            // 
            this.lbSignUp.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbSignUp.AutoSize = true;
            this.lbSignUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSignUp.Location = new System.Drawing.Point(22, 307);
            this.lbSignUp.Name = "lbSignUp";
            this.lbSignUp.Size = new System.Drawing.Size(313, 20);
            this.lbSignUp.TabIndex = 1;
            this.lbSignUp.Text = "Chưa có tài khoản? Đăng kí tại đây !";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.BtnClose);
            this.panelDesktop.Controls.Add(this.BtnMaximize);
            this.panelDesktop.Controls.Add(this.BtnMinimize);
            this.panelDesktop.Controls.Add(this.CbPassword);
            this.panelDesktop.Controls.Add(this.BtnLogin);
            this.panelDesktop.Controls.Add(this.TxtAccount);
            this.panelDesktop.Controls.Add(this.TxtPassword);
            this.panelDesktop.Controls.Add(this.lbAccount);
            this.panelDesktop.Controls.Add(this.lbPassword);
            this.panelDesktop.Controls.Add(this.lbLogin);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(359, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(617, 474);
            this.panelDesktop.TabIndex = 1;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseDown);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.SystemColors.Control;
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.BtnClose.IconColor = System.Drawing.Color.Black;
            this.BtnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnClose.IconSize = 25;
            this.BtnClose.Location = new System.Drawing.Point(590, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(27, 25);
            this.BtnClose.TabIndex = 16;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMaximize
            // 
            this.BtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMaximize.ForeColor = System.Drawing.Color.Black;
            this.BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.BtnMaximize.IconColor = System.Drawing.Color.Black;
            this.BtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximize.IconSize = 19;
            this.BtnMaximize.Location = new System.Drawing.Point(570, 2);
            this.BtnMaximize.Name = "BtnMaximize";
            this.BtnMaximize.Size = new System.Drawing.Size(23, 19);
            this.BtnMaximize.TabIndex = 17;
            this.BtnMaximize.TabStop = false;
            this.BtnMaximize.Click += new System.EventHandler(this.BtnMaximize_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMinimize.ForeColor = System.Drawing.Color.Black;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.BtnMinimize.IconColor = System.Drawing.Color.Black;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 19;
            this.BtnMinimize.Location = new System.Drawing.Point(541, 2);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(23, 19);
            this.BtnMinimize.TabIndex = 18;
            this.BtnMinimize.TabStop = false;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click_1);
            // 
            // CbPassword
            // 
            this.CbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbPassword.AutoSize = true;
            this.CbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbPassword.Location = new System.Drawing.Point(426, 262);
            this.CbPassword.Name = "CbPassword";
            this.CbPassword.Size = new System.Drawing.Size(125, 22);
            this.CbPassword.TabIndex = 3;
            this.CbPassword.Text = "Hiện mật khẩu";
            this.CbPassword.UseVisualStyleBackColor = true;
            this.CbPassword.CheckedChanged += new System.EventHandler(this.CbPassword_CheckedChanged);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(249, 288);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(124, 63);
            this.BtnLogin.TabIndex = 4;
            this.BtnLogin.Text = "Đăng nhập";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtAccount
            // 
            this.TxtAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtAccount.Location = new System.Drawing.Point(69, 151);
            this.TxtAccount.Name = "TxtAccount";
            this.TxtAccount.Size = new System.Drawing.Size(482, 22);
            this.TxtAccount.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtPassword.Location = new System.Drawing.Point(69, 222);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(482, 22);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // lbAccount
            // 
            this.lbAccount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbAccount.AutoSize = true;
            this.lbAccount.BackColor = System.Drawing.SystemColors.Control;
            this.lbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccount.Location = new System.Drawing.Point(64, 123);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(125, 22);
            this.lbAccount.TabIndex = 9;
            this.lbAccount.Text = "Tên tài khoản:";
            // 
            // lbPassword
            // 
            this.lbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPassword.Location = new System.Drawing.Point(64, 194);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(88, 22);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Mật khẩu:";
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbLogin.Location = new System.Drawing.Point(244, 35);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(138, 25);
            this.lbLogin.TabIndex = 11;
            this.lbLogin.Text = "ĐĂNG NHẬP";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 474);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLogin);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập tài khoản";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmLogin_MouseDown);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lbSignUp;
        private System.Windows.Forms.Button BtnSignUp;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox BtnClose;
        private FontAwesome.Sharp.IconPictureBox BtnMaximize;
        private FontAwesome.Sharp.IconPictureBox BtnMinimize;
        private System.Windows.Forms.CheckBox CbPassword;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtAccount;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbLogin;
    }
}