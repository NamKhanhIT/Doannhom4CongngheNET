namespace Doannhom4CongngheNET
{
    partial class FrmSinhVienReport
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
            this.reportViewerSV = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewerSV
            // 
            this.reportViewerSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewerSV.DocumentMapWidth = 96;
            this.reportViewerSV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportViewerSV.LocalReport.DisplayName = "ReportSinhVien.rdlc";
            this.reportViewerSV.Location = new System.Drawing.Point(0, 0);
            this.reportViewerSV.Name = "reportViewer1";
            this.reportViewerSV.Size = new System.Drawing.Size(100, 100);
            this.reportViewerSV.TabIndex = 0;
            // 
            // FrmSinhVienReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 444);
            this.Name = "FrmSinhVienReport";
            this.Text = "FrmSinhVienReport";
            this.Load += new System.EventHandler(this.FrmSinhVienReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSV;
    }
}