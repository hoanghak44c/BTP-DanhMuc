namespace QLBanHang.Modules.DanhMuc.Form2
{
    partial class FrmCTDuAn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCTDuAn));
            this.panelCT1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.chkSuDung = new DevExpress.XtraEditors.CheckEdit();
            this.memoGhiChu = new DevExpress.XtraEditors.MemoEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtMa = new DevExpress.XtraEditors.TextEdit();
            this.panelCT2 = new DevExpress.XtraEditors.PanelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelCT1)).BeginInit();
            this.panelCT1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSuDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCT2)).BeginInit();
            this.panelCT2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCT1
            // 
            this.panelCT1.Controls.Add(this.labelControl3);
            this.panelCT1.Controls.Add(this.labelControl2);
            this.panelCT1.Controls.Add(this.labelControl1);
            this.panelCT1.Controls.Add(this.chkSuDung);
            this.panelCT1.Controls.Add(this.memoGhiChu);
            this.panelCT1.Controls.Add(this.txtTen);
            this.panelCT1.Controls.Add(this.txtMa);
            this.panelCT1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCT1.Location = new System.Drawing.Point(0, 0);
            this.panelCT1.Name = "panelCT1";
            this.panelCT1.Size = new System.Drawing.Size(554, 204);
            this.panelCT1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(74, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Ghi Chú";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(74, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên Dự Án";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã Dự Án";
            // 
            // chkSuDung
            // 
            this.chkSuDung.Location = new System.Drawing.Point(131, 163);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Properties.Caption = "Sử Dụng";
            this.chkSuDung.Size = new System.Drawing.Size(75, 19);
            this.chkSuDung.TabIndex = 3;
            // 
            // memoGhiChu
            // 
            this.memoGhiChu.Location = new System.Drawing.Point(131, 77);
            this.memoGhiChu.Name = "memoGhiChu";
            this.memoGhiChu.Size = new System.Drawing.Size(373, 79);
            this.memoGhiChu.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(131, 50);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(276, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(131, 23);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(276, 20);
            this.txtMa.TabIndex = 0;
            // 
            // panelCT2
            // 
            this.panelCT2.Controls.Add(this.btnDong);
            this.panelCT2.Controls.Add(this.btnXoa);
            this.panelCT2.Controls.Add(this.btnSave);
            this.panelCT2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCT2.Location = new System.Drawing.Point(0, 210);
            this.panelCT2.Name = "panelCT2";
            this.panelCT2.Size = new System.Drawing.Size(554, 76);
            this.panelCT2.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(331, 26);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(95, 25);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(230, 26);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 25);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(129, 26);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmCTDuAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 286);
            this.Controls.Add(this.panelCT2);
            this.Controls.Add(this.panelCT1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCTDuAn";
            this.Text = "Chi tiết dự án";
            ((System.ComponentModel.ISupportInitialize)(this.panelCT1)).EndInit();
            this.panelCT1.ResumeLayout(false);
            this.panelCT1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkSuDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelCT2)).EndInit();
            this.panelCT2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelCT1;
        private DevExpress.XtraEditors.PanelControl panelCT2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit chkSuDung;
        private DevExpress.XtraEditors.MemoEdit memoGhiChu;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtMa;
    }
}