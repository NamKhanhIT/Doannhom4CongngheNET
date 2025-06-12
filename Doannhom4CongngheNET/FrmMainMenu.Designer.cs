namespace Doannhom4CongngheNET.Resources
{
    partial class FrmMainMenu
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
            this.components = new System.ComponentModel.Container();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.lbChildForm = new System.Windows.Forms.Label();
            this.btnLogOut = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.iconCurentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTiltleBar = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQuanLy = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.Btn1 = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentChildForm)).BeginInit();
            this.panelTiltleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.btnQuanLy.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(269, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(803, 9);
            this.panelShadow.TabIndex = 6;
            // 
            // lbChildForm
            // 
            this.lbChildForm.AutoSize = true;
            this.lbChildForm.ForeColor = System.Drawing.Color.Navy;
            this.lbChildForm.Location = new System.Drawing.Point(62, 21);
            this.lbChildForm.Name = "lbChildForm";
            this.lbChildForm.Size = new System.Drawing.Size(67, 16);
            this.lbChildForm.TabIndex = 1;
            this.lbChildForm.Text = "Trang chủ";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnLogOut.IconColor = System.Drawing.Color.Black;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 32;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 518);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(269, 50);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 23;
            this.btnClose.Location = new System.Drawing.Point(777, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 19;
            this.btnMaximize.Location = new System.Drawing.Point(750, 3);
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
            this.btnMinimize.Location = new System.Drawing.Point(723, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(23, 19);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(269, 181);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
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
            this.btnHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseDown);
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
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(269, 60);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(803, 508);
            this.panelDesktop.TabIndex = 7;
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
            this.panelTiltleBar.Location = new System.Drawing.Point(269, 0);
            this.panelTiltleBar.Name = "panelTiltleBar";
            this.panelTiltleBar.Size = new System.Drawing.Size(803, 60);
            this.panelTiltleBar.TabIndex = 5;
            this.panelTiltleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTiltleBar_MouseDown);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panelMenu.Controls.Add(this.btnQuanLy);
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(269, 568);
            this.panelMenu.TabIndex = 4;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Controls.Add(this.iconButton4);
            this.btnQuanLy.Controls.Add(this.iconButton3);
            this.btnQuanLy.Controls.Add(this.iconButton2);
            this.btnQuanLy.Controls.Add(this.iconButton1);
            this.btnQuanLy.Controls.Add(this.Btn1);
            this.btnQuanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanLy.Location = new System.Drawing.Point(0, 181);
            this.btnQuanLy.MaximumSize = new System.Drawing.Size(267, 191);
            this.btnQuanLy.MinimumSize = new System.Drawing.Size(267, 58);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(267, 58);
            this.btnQuanLy.TabIndex = 1;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(0, 189);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(267, 57);
            this.iconButton4.TabIndex = 4;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(0, 143);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(267, 46);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "iconButton3";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 100);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(267, 43);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 57);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(267, 43);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "iconButton1";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.Btn1.IconColor = System.Drawing.Color.Black;
            this.Btn1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn1.Location = new System.Drawing.Point(0, 0);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(267, 57);
            this.Btn1.TabIndex = 0;
            this.Btn1.Text = "iconButton1";
            this.Btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 568);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTiltleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmMainMenu";
            this.Text = "frmNhanVienMenu";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentChildForm)).EndInit();
            this.panelTiltleBar.ResumeLayout(false);
            this.panelTiltleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.btnQuanLy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Label lbChildForm;
        private FontAwesome.Sharp.IconButton btnLogOut;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurentChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelTiltleBar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel btnQuanLy;
        private FontAwesome.Sharp.IconButton Btn1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}