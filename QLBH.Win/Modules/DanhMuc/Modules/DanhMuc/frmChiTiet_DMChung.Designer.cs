namespace QLBanHang.Modules.DanhMuc
{
    partial class frmChiTiet_DMChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTiet_DMChung));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new QLBH.Core.Form.GtidButton();
            this.btnCapNhat = new QLBH.Core.Form.GtidButton();
            this.btnClose = new QLBH.Core.Form.GtidButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblSuDung = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(2, 11);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(743, 22);
            this.lblTieuDe.TabIndex = 2;
            this.lblTieuDe.Text = "CHI TIẾT ";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(2, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(743, 74);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99957F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00043F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.Controls.Add(this.btnXoa, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCapNhat, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnClose, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(8, 25);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(726, 39);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(314, 4);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ShortCutKey = System.Windows.Forms.Keys.F8;
            this.btnXoa.Size = new System.Drawing.Size(97, 31);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(213, 4);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.ShortCutKey = System.Windows.Forms.Keys.F2;
            this.btnCapNhat.Size = new System.Drawing.Size(95, 31);
            this.btnCapNhat.TabIndex = 0;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(417, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShortCutKey = System.Windows.Forms.Keys.Escape;
            this.btnClose.Size = new System.Drawing.Size(95, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00043F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Controls.Add(this.btnDong, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, -258);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 39);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(403, 4);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btnDong.Size = new System.Drawing.Size(93, 31);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // groupBoxList
            // 
            this.groupBoxList.Controls.Add(this.chkSuDung);
            this.groupBoxList.Controls.Add(this.txtMoTa);
            this.groupBoxList.Controls.Add(this.txtTen);
            this.groupBoxList.Controls.Add(this.txtMa);
            this.groupBoxList.Controls.Add(this.lblSuDung);
            this.groupBoxList.Controls.Add(this.lblMoTa);
            this.groupBoxList.Controls.Add(this.lblTen);
            this.groupBoxList.Controls.Add(this.lblMa);
            this.groupBoxList.Location = new System.Drawing.Point(2, 54);
            this.groupBoxList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBoxList.Size = new System.Drawing.Size(743, 193);
            this.groupBoxList.TabIndex = 0;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Nội dung chi tiết";
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(84, 170);
            this.chkSuDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(15, 14);
            this.chkSuDung.TabIndex = 3;
            this.chkSuDung.UseVisualStyleBackColor = true;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(84, 91);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(651, 67);
            this.txtMoTa.TabIndex = 2;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(84, 58);
            this.txtTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(223, 22);
            this.txtTen.TabIndex = 1;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(84, 25);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMa.MaxLength = 10;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(223, 22);
            this.txtMa.TabIndex = 0;
            // 
            // lblSuDung
            // 
            this.lblSuDung.Location = new System.Drawing.Point(5, 167);
            this.lblSuDung.Name = "lblSuDung";
            this.lblSuDung.Size = new System.Drawing.Size(70, 25);
            this.lblSuDung.TabIndex = 7;
            this.lblSuDung.Text = "Sử Dụng";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Location = new System.Drawing.Point(8, 95);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(70, 25);
            this.lblMoTa.TabIndex = 6;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // lblTen
            // 
            this.lblTen.Location = new System.Drawing.Point(8, 62);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(70, 25);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Tên";
            // 
            // lblMa
            // 
            this.lblMa.Location = new System.Drawing.Point(8, 28);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(70, 25);
            this.lblMa.TabIndex = 4;
            this.lblMa.Text = "Mã";
            // 
            // frmChiTiet_DMChung
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 343);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChiTiet_DMChung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChiTiet_DMChung_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal QLBH.Core.Form.GtidButton btnDong;
        protected System.Windows.Forms.GroupBox groupBoxList;
        protected System.Windows.Forms.CheckBox chkSuDung;
        protected System.Windows.Forms.TextBox txtMoTa;
        protected System.Windows.Forms.TextBox txtTen;
        protected System.Windows.Forms.TextBox txtMa;
        protected System.Windows.Forms.Label lblSuDung;
        protected System.Windows.Forms.Label lblMoTa;
        protected System.Windows.Forms.Label lblTen;
        protected System.Windows.Forms.Label lblMa;
        protected QLBH.Core.Form.GtidButton btnXoa;
        protected QLBH.Core.Form.GtidButton btnCapNhat;
        protected QLBH.Core.Form.GtidButton btnClose;
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}