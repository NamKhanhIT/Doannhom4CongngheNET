namespace Doannhom4CongngheNET
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSoPhong = new System.Windows.Forms.Label();
            this.lbLoaiPhong = new System.Windows.Forms.Label();
            this.lbSucChua = new System.Windows.Forms.Label();
            this.lbTinhTrang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSoPhong
            // 
            this.lbSoPhong.AutoSize = true;
            this.lbSoPhong.Location = new System.Drawing.Point(-4, 9);
            this.lbSoPhong.Name = "lbSoPhong";
            this.lbSoPhong.Size = new System.Drawing.Size(65, 16);
            this.lbSoPhong.TabIndex = 0;
            this.lbSoPhong.Text = "Số phòng";
            // 
            // lbLoaiPhong
            // 
            this.lbLoaiPhong.AutoSize = true;
            this.lbLoaiPhong.Location = new System.Drawing.Point(-4, 38);
            this.lbLoaiPhong.Name = "lbLoaiPhong";
            this.lbLoaiPhong.Size = new System.Drawing.Size(80, 16);
            this.lbLoaiPhong.TabIndex = 1;
            this.lbLoaiPhong.Text = "Loại phòng: ";
            // 
            // lbSucChua
            // 
            this.lbSucChua.AutoSize = true;
            this.lbSucChua.Location = new System.Drawing.Point(-4, 70);
            this.lbSucChua.Name = "lbSucChua";
            this.lbSucChua.Size = new System.Drawing.Size(65, 16);
            this.lbSucChua.TabIndex = 1;
            this.lbSucChua.Text = "Sức chứa:";
            // 
            // lbTinhTrang
            // 
            this.lbTinhTrang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTinhTrang.AutoSize = true;
            this.lbTinhTrang.Location = new System.Drawing.Point(3, 112);
            this.lbTinhTrang.Name = "lbTinhTrang";
            this.lbTinhTrang.Size = new System.Drawing.Size(70, 16);
            this.lbTinhTrang.TabIndex = 1;
            this.lbTinhTrang.Text = "Trạng thái:";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbTinhTrang);
            this.Controls.Add(this.lbSucChua);
            this.Controls.Add(this.lbLoaiPhong);
            this.Controls.Add(this.lbSoPhong);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(160, 139);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControl1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSoPhong;
        private System.Windows.Forms.Label lbLoaiPhong;
        private System.Windows.Forms.Label lbSucChua;
        private System.Windows.Forms.Label lbTinhTrang;
    }
}
