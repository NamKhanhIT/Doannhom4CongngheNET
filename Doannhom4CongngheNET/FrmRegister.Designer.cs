namespace Doannhom4CongngheNET
{
    partial class FrmRegister
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
            this.btnSignIn = new System.Windows.Forms.Button();
            this.lbSignIn = new System.Windows.Forms.Label();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.txtVaitro = new System.Windows.Forms.TextBox();
            this.lbVaitro = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelLogin.Controls.Add(this.LoginPicture);
            this.panelLogin.Controls.Add(this.btnSignIn);
            this.panelLogin.Controls.Add(this.lbSignIn);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(359, 450);
            this.panelLogin.TabIndex = 2;
            this.panelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogin_MouseDown);
            // 
            // LoginPicture
            // 
            this.LoginPicture.Image = global::Doannhom4CongngheNET.Properties.Resources.Logo_Trường_ĐH_Vinh___VinhUni;
            this.LoginPicture.Location = new System.Drawing.Point(70, 51);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(210, 163);
            this.LoginPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LoginPicture.TabIndex = 3;
            this.LoginPicture.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.MistyRose;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(99, 344);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(149, 45);
            this.btnSignIn.TabIndex = 2;
            this.btnSignIn.Text = "Đăng nhập";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lbSignIn
            // 
            this.lbSignIn.AutoSize = true;
            this.lbSignIn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lbSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbSignIn.Location = new System.Drawing.Point(22, 307);
            this.lbSignIn.Name = "lbSignIn";
            this.lbSignIn.Size = new System.Drawing.Size(319, 20);
            this.lbSignIn.TabIndex = 1;
            this.lbSignIn.Text = "Đã có tài khoản? Đăng nhập tại đây !";
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.BackColor = System.Drawing.SystemColors.Control;
            this.lbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegister.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRegister.Location = new System.Drawing.Point(269, 9);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(100, 25);
            this.lbRegister.TabIndex = 11;
            this.lbRegister.Text = "ĐĂNG KÍ";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPassword.Location = new System.Drawing.Point(67, 142);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(88, 22);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Mật khẩu:";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.BackColor = System.Drawing.SystemColors.Control;
            this.lbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccount.Location = new System.Drawing.Point(68, 34);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(125, 22);
            this.lbAccount.TabIndex = 9;
            this.lbAccount.Text = "Tên tài khoản:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Location = new System.Drawing.Point(72, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(482, 22);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtAccount.Location = new System.Drawing.Point(73, 62);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(482, 22);
            this.txtAccount.TabIndex = 13;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(255, 354);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(124, 63);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Đăng kí";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.btnMinimize.IconColor = System.Drawing.Color.Black;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 19;
            this.btnMinimize.Location = new System.Drawing.Point(546, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 19);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Black;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 19;
            this.btnMaximize.Location = new System.Drawing.Point(575, 2);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 19);
            this.btnMaximize.TabIndex = 17;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.Black;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 23;
            this.btnClose.Location = new System.Drawing.Point(598, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 32);
            this.btnClose.TabIndex = 16;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Controls.Add(this.txtUserName);
            this.panelDesktop.Controls.Add(this.lbUserName);
            this.panelDesktop.Controls.Add(this.txtVaitro);
            this.panelDesktop.Controls.Add(this.lbVaitro);
            this.panelDesktop.Controls.Add(this.txtEmail);
            this.panelDesktop.Controls.Add(this.lbEmail);
            this.panelDesktop.Controls.Add(this.btnClose);
            this.panelDesktop.Controls.Add(this.btnMaximize);
            this.panelDesktop.Controls.Add(this.btnMinimize);
            this.panelDesktop.Controls.Add(this.btnSignUp);
            this.panelDesktop.Controls.Add(this.txtAccount);
            this.panelDesktop.Controls.Add(this.txtPassword);
            this.panelDesktop.Controls.Add(this.lbAccount);
            this.panelDesktop.Controls.Add(this.lbPassword);
            this.panelDesktop.Controls.Add(this.lbRegister);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(359, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(622, 450);
            this.panelDesktop.TabIndex = 3;
            this.panelDesktop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDesktop_MouseDown);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtUserName.Location = new System.Drawing.Point(73, 117);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(482, 22);
            this.txtUserName.TabIndex = 24;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.SystemColors.Control;
            this.lbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUserName.Location = new System.Drawing.Point(69, 92);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(92, 22);
            this.lbUserName.TabIndex = 23;
            this.lbUserName.Text = "Họ và tên:";
            // 
            // txtVaitro
            // 
            this.txtVaitro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVaitro.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtVaitro.Location = new System.Drawing.Point(73, 293);
            this.txtVaitro.Name = "txtVaitro";
            this.txtVaitro.Size = new System.Drawing.Size(482, 22);
            this.txtVaitro.TabIndex = 22;
            // 
            // lbVaitro
            // 
            this.lbVaitro.AutoSize = true;
            this.lbVaitro.BackColor = System.Drawing.SystemColors.Control;
            this.lbVaitro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVaitro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbVaitro.Location = new System.Drawing.Point(68, 265);
            this.lbVaitro.Name = "lbVaitro";
            this.lbVaitro.Size = new System.Drawing.Size(67, 22);
            this.lbVaitro.TabIndex = 21;
            this.lbVaitro.Text = "Vai trò:";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEmail.Location = new System.Drawing.Point(72, 228);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(482, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.SystemColors.Control;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEmail.Location = new System.Drawing.Point(67, 200);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 22);
            this.lbEmail.TabIndex = 19;
            this.lbEmail.Text = "Email:";
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelLogin);
            this.Name = "FrmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng kí tài khoản";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label lbSignIn;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Button btnSignUp;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.TextBox txtVaitro;
        private System.Windows.Forms.Label lbVaitro;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUserName;
    }
}