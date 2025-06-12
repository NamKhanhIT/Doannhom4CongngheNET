using System.Drawing;
using System.Windows.Forms;

namespace Doannhom4CongngheNET
{
    partial class FrmMenu
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
            this.lbThu = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnLogOut);
            this.panelMenu.Controls.Add(this.btnPayment);
            this.panelMenu.Controls.Add(this.btnFixingRoom);
            this.panelMenu.Controls.Add(this.btnSignUpRoom);
            this.panelMenu.Controls.Add(this.btnSearchRoom);
            this.panelMenu.Controls.Add(this.btnInformation);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(356, 894);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.btnLogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogOut.IconSize = 32;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 832);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnLogOut.Size = new System.Drawing.Size(356, 62);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            this.btnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayment.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnPayment.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPayment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPayment.IconSize = 32;
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(0, 322);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnPayment.Size = new System.Drawing.Size(356, 62);
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Thanh toán";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayment.UseVisualStyleBackColor = true;
            // 
            // btnFixingRoom
            // 
            this.btnFixingRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFixingRoom.FlatAppearance.BorderSize = 0;
            this.btnFixingRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFixingRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFixingRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFixingRoom.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnFixingRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFixingRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFixingRoom.IconSize = 32;
            this.btnFixingRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixingRoom.Location = new System.Drawing.Point(0, 260);
            this.btnFixingRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFixingRoom.Name = "btnFixingRoom";
            this.btnFixingRoom.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnFixingRoom.Size = new System.Drawing.Size(356, 62);
            this.btnFixingRoom.TabIndex = 4;
            this.btnFixingRoom.Text = "Sửa chữa";
            this.btnFixingRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFixingRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFixingRoom.UseVisualStyleBackColor = true;
            // 
            // btnSignUpRoom
            // 
            this.btnSignUpRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSignUpRoom.FlatAppearance.BorderSize = 0;
            this.btnSignUpRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUpRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUpRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSignUpRoom.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnSignUpRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSignUpRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSignUpRoom.IconSize = 32;
            this.btnSignUpRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUpRoom.Location = new System.Drawing.Point(0, 198);
            this.btnSignUpRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSignUpRoom.Name = "btnSignUpRoom";
            this.btnSignUpRoom.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnSignUpRoom.Size = new System.Drawing.Size(356, 62);
            this.btnSignUpRoom.TabIndex = 3;
            this.btnSignUpRoom.Text = "Đăng ký phòng";
            this.btnSignUpRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUpRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSignUpRoom.UseVisualStyleBackColor = true;
            // 
            // btnSearchRoom
            // 
            this.btnSearchRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearchRoom.FlatAppearance.BorderSize = 0;
            this.btnSearchRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoom.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSearchRoom.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearchRoom.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSearchRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchRoom.IconSize = 32;
            this.btnSearchRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRoom.Location = new System.Drawing.Point(0, 136);
            this.btnSearchRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchRoom.Name = "btnSearchRoom";
            this.btnSearchRoom.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnSearchRoom.Size = new System.Drawing.Size(356, 62);
            this.btnSearchRoom.TabIndex = 2;
            this.btnSearchRoom.Text = "Tìm kiếm phòng";
            this.btnSearchRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearchRoom.UseVisualStyleBackColor = true;
            // 
            // btnInformation
            // 
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformation.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInformation.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnInformation.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformation.IconSize = 32;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(0, 74);
            this.btnInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnInformation.Size = new System.Drawing.Size(356, 62);
            this.btnInformation.TabIndex = 1;
            this.btnInformation.Text = "Thông tin";
            this.btnInformation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(356, 74);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::Doannhom4CongngheNET.Properties.Resources.Logo_Trường_ĐH_Vinh___VinhUni;
            this.btnHome.Location = new System.Drawing.Point(16, 15);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(47, 43);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // panelTiltleBar
            // 
            this.panelTiltleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTiltleBar.Controls.Add(this.btnClose);
            this.panelTiltleBar.Controls.Add(this.btnMaximize);
            this.panelTiltleBar.Controls.Add(this.btnMinimize);
            this.panelTiltleBar.Controls.Add(this.lbChildForm);
            this.panelTiltleBar.Controls.Add(this.iconCurentChildForm);
            this.panelTiltleBar.Controls.Add(this.lbThu);
            this.panelTiltleBar.Controls.Add(this.lbNgay);
            this.panelTiltleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTiltleBar.Location = new System.Drawing.Point(356, 0);
            this.panelTiltleBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTiltleBar.Name = "panelTiltleBar";
            this.panelTiltleBar.Size = new System.Drawing.Size(1568, 85);
            this.panelTiltleBar.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 34;
            this.btnClose.Location = new System.Drawing.Point(2906, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.TabStop = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 34;
            this.btnMaximize.Location = new System.Drawing.Point(2860, 15);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(37, 34);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 34;
            this.btnMinimize.Location = new System.Drawing.Point(2815, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(37, 34);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.TabStop = false;
            // 
            // lbChildForm
            // 
            this.lbChildForm.AutoSize = true;
            this.lbChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbChildForm.Location = new System.Drawing.Point(67, 25);
            this.lbChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChildForm.Name = "lbChildForm";
            this.lbChildForm.Size = new System.Drawing.Size(54, 20);
            this.lbChildForm.TabIndex = 2;
            this.lbChildForm.Text = "Home";
            // 
            // iconCurentChildForm
            // 
            this.iconCurentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurentChildForm.IconSize = 39;
            this.iconCurentChildForm.Location = new System.Drawing.Point(16, 18);
            this.iconCurentChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconCurentChildForm.Name = "iconCurentChildForm";
            this.iconCurentChildForm.Size = new System.Drawing.Size(43, 39);
            this.iconCurentChildForm.TabIndex = 1;
            this.iconCurentChildForm.TabStop = false;
            // 
            // lbThu
            // 
            this.lbThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbThu.AutoSize = true;
            this.lbThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThu.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbThu.Location = new System.Drawing.Point(2635, 25);
            this.lbThu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThu.Name = "lbThu";
            this.lbThu.Size = new System.Drawing.Size(37, 20);
            this.lbThu.TabIndex = 6;
            this.lbThu.Text = "Thứ";
            // 
            // lbNgay
            // 
            this.lbNgay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgay.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbNgay.Location = new System.Drawing.Point(2690, 25);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(47, 20);
            this.lbNgay.TabIndex = 7;
            this.lbNgay.Text = "Ngày";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(356, 85);
            this.panelShadow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1568, 11);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDesktop.Controls.Add(this.lbWelcome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(356, 96);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1568, 798);
            this.panelDesktop.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Location = new System.Drawing.Point(115, 253);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(44, 16);
            this.lbWelcome.TabIndex = 0;
            this.lbWelcome.Text = "label1";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 894);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTiltleBar);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý KTX";
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
        private System.Windows.Forms.Label lbThu;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Timer timer1;
        private Label lbWelcome;
    }
}

