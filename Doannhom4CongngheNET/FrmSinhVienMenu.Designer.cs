namespace Doannhom4CongngheNET
{
    partial class FrmSinhVienMenu
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnPayment = new FontAwesome.Sharp.IconButton();
            this.btnFixingRoom = new FontAwesome.Sharp.IconButton();
            this.btnSignUpRoom = new FontAwesome.Sharp.IconButton();
            this.btnSearchRoom = new FontAwesome.Sharp.IconButton();
            this.btnInformation = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTiltleBar = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.lbChildForm = new System.Windows.Forms.Label();
            this.iconCurentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lbWelcome = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTiltleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnPayment);
            this.panelMenu.Controls.Add(this.btnFixingRoom);
            this.panelMenu.Controls.Add(this.btnSignUpRoom);
            this.panelMenu.Controls.Add(this.btnSearchRoom);
            this.panelMenu.Controls.Add(this.btnInformation);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 726);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnLogOut.IconColor = System.Drawing.Color.Black;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 32;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 676);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(267, 50);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnPayment.IconColor = System.Drawing.Color.Black;
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.IconSize = 32;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(0, 381);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(267, 50);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnFixingRoom
            // 
            this.btnFixingRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFixingRoom.FlatAppearance.BorderSize = 0;
            this.btnFixingRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixingRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFixingRoom.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.btnFixingRoom.IconColor = System.Drawing.Color.Black;
            this.btnFixingRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFixingRoom.IconSize = 32;
            this.btnFixingRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixingRoom.Location = new System.Drawing.Point(0, 331);
            this.btnFixingRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFixingRoom.Name = "btnFixingRoom";
            this.btnFixingRoom.Size = new System.Drawing.Size(267, 50);
            this.btnFixingRoom.TabIndex = 4;
            this.btnFixingRoom.Text = "Bảo trì và sửa chữa";
            this.btnFixingRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixingRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFixingRoom.UseVisualStyleBackColor = true;
            this.btnFixingRoom.Click += new System.EventHandler(this.btnFixingRoom_Click);
            // 
            // btnSignUpRoom
            // 
            this.btnSignUpRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignUpRoom.FlatAppearance.BorderSize = 0;
            this.btnSignUpRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSignUpRoom.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.btnSignUpRoom.IconColor = System.Drawing.Color.Black;
            this.btnSignUpRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignUpRoom.IconSize = 32;
            this.btnSignUpRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUpRoom.Location = new System.Drawing.Point(0, 281);
            this.btnSignUpRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSignUpRoom.Name = "btnSignUpRoom";
            this.btnSignUpRoom.Size = new System.Drawing.Size(267, 50);
            this.btnSignUpRoom.TabIndex = 3;
            this.btnSignUpRoom.Text = "Đăng kí phòng";
            this.btnSignUpRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUpRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUpRoom.UseVisualStyleBackColor = true;
            this.btnSignUpRoom.Click += new System.EventHandler(this.btnSignUpRoom_Click);
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchRoom.FlatAppearance.BorderSize = 0;
            this.btnSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSearchRoom.IconChar = FontAwesome.Sharp.IconChar.Hotel;
            this.btnSearchRoom.IconColor = System.Drawing.Color.Black;
            this.btnSearchRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchRoom.IconSize = 32;
            this.btnSearchRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRoom.Location = new System.Drawing.Point(0, 231);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Size = new System.Drawing.Size(267, 50);
            this.btnSearchRoom.TabIndex = 2;
            this.btnSearchRoom.Text = "Tra cứu phòng";
            this.btnSearchRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            this.btnSearchRoom.Click += new System.EventHandler(this.btnSearchRoom_Click);
            // 
            // btnInformation
            // 
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInformation.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnInformation.IconColor = System.Drawing.Color.Black;
            this.btnInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformation.IconSize = 32;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(0, 181);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(267, 50);
            this.btnInformation.TabIndex = 1;
            this.btnInformation.Text = "Thông tin sinh viên";
            this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.Click += new System.EventHandler(this.btnInformation_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(267, 181);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Doannhom4CongngheNET.Properties.Resources.Logo_Trường_ĐH_Vinh___VinhUni;
            this.btnHome.Location = new System.Drawing.Point(25, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(210, 129);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTiltleBar
            // 
            this.panelTiltleBar.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelTiltleBar.Controls.Add(this.btnClose);
            this.panelTiltleBar.Controls.Add(this.btnMaximize);
            this.panelTiltleBar.Controls.Add(this.btnMinimize);
            this.panelTiltleBar.Controls.Add(this.lbChildForm);
            this.panelTiltleBar.Controls.Add(this.iconCurentChildForm);
            this.panelTiltleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTiltleBar.Location = new System.Drawing.Point(267, 0);
            this.panelTiltleBar.Name = "panelTiltleBar";
            this.panelTiltleBar.Size = new System.Drawing.Size(1038, 60);
            this.panelTiltleBar.TabIndex = 1;
            this.panelTiltleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTiltleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 23;
            this.btnClose.Location = new System.Drawing.Point(1012, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 19;
            this.btnMaximize.Location = new System.Drawing.Point(985, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(23, 19);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 19;
            this.btnMinimize.Location = new System.Drawing.Point(958, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 19);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lbChildForm
            // 
            this.lbChildForm.AutoSize = true;
            this.lbChildForm.ForeColor = System.Drawing.Color.Navy;
            this.lbChildForm.Location = new System.Drawing.Point(62, 21);
            this.lbChildForm.Name = "lbChildForm";
            this.lbChildForm.Size = new System.Drawing.Size(64, 25);
            this.lbChildForm.TabIndex = 1;
            this.lbChildForm.Text = "Home";
            // 
            // iconCurentChildForm
            // 
            this.iconCurentChildForm.BackColor = System.Drawing.Color.RoyalBlue;
            this.iconCurentChildForm.ForeColor = System.Drawing.Color.Navy;
            this.iconCurentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurentChildForm.IconColor = System.Drawing.Color.Navy;
            this.iconCurentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurentChildForm.IconSize = 39;
            this.iconCurentChildForm.Location = new System.Drawing.Point(17, 12);
            this.iconCurentChildForm.Name = "iconCurentChildForm";
            this.iconCurentChildForm.Size = new System.Drawing.Size(39, 45);
            this.iconCurentChildForm.TabIndex = 0;
            this.iconCurentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(267, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1038, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDesktop.Controls.Add(this.lbWelcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(267, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1038, 657);
            this.panelDesktop.TabIndex = 3;
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(625, 48);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(64, 25);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "label1";
            // 
            // FrmSinhVienMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 726);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTiltleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmSinhVienMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTiltleBar.ResumeLayout(false);
            this.panelTiltleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnInformation;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconButton btnPayment;
        private FontAwesome.Sharp.IconButton btnFixingRoom;
        private FontAwesome.Sharp.IconButton btnSignUpRoom;
        private FontAwesome.Sharp.IconButton btnSearchRoom;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTiltleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurentChildForm;
        private System.Windows.Forms.Label lbChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private System.Windows.Forms.Label lbWelcome;
    }
}

