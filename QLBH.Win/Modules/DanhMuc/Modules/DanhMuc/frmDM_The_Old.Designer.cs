namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_The_Old
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_The_Old));
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.dgvLoaiThe = new System.Windows.Forms.DataGridView();
            this.colIdLoaiThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSuDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new QLBH.Core.Form.GtidButton();
            this.btnCapNhat = new QLBH.Core.Form.GtidButton();
            this.btnDong = new QLBH.Core.Form.GtidButton();
            this.btnXoa = new QLBH.Core.Form.GtidButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenTheLoc = new System.Windows.Forms.TextBox();
            this.btnLoc = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGhiChuLoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaTheLoc = new System.Windows.Forms.TextBox();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThe)).BeginInit();
            this.grpThucThi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.dgvLoaiThe);
            this.grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.MidnightBlue;
            this.grpThongTin.Location = new System.Drawing.Point(7, 68);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(895, 406);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Danh sách loại thẻ";
            // 
            // dgvLoaiThe
            // 
            this.dgvLoaiThe.AllowUserToAddRows = false;
            this.dgvLoaiThe.AllowUserToDeleteRows = false;
            this.dgvLoaiThe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiThe.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiThe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiThe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdLoaiThe,
            this.colMaThe,
            this.colTenThe,
            this.colGhiChu,
            this.colSuDung});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiThe.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiThe.Location = new System.Drawing.Point(6, 18);
            this.dgvLoaiThe.Name = "dgvLoaiThe";
            this.dgvLoaiThe.ReadOnly = true;
            this.dgvLoaiThe.RowHeadersWidth = 21;
            this.dgvLoaiThe.RowTemplate.Height = 20;
            this.dgvLoaiThe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiThe.Size = new System.Drawing.Size(877, 382);
            this.dgvLoaiThe.TabIndex = 23;
            this.dgvLoaiThe.DoubleClick += new System.EventHandler(this.dgvLoaiThe_DoubleClick);
            this.dgvLoaiThe.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvLoaiThe_RowsAdded);
            this.dgvLoaiThe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiThe_CellClick);
            this.dgvLoaiThe.SelectionChanged += new System.EventHandler(this.dgvLoaiThe_SelectionChanged);
            // 
            // colIdLoaiThe
            // 
            this.colIdLoaiThe.DataPropertyName = "IdLoaiThe";
            this.colIdLoaiThe.HeaderText = "IDLoaiThe";
            this.colIdLoaiThe.Name = "colIdLoaiThe";
            this.colIdLoaiThe.ReadOnly = true;
            this.colIdLoaiThe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colIdLoaiThe.Visible = false;
            // 
            // colMaThe
            // 
            this.colMaThe.DataPropertyName = "MaThe";
            this.colMaThe.HeaderText = "Mã thẻ";
            this.colMaThe.Name = "colMaThe";
            this.colMaThe.ReadOnly = true;
            this.colMaThe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTenThe
            // 
            this.colTenThe.DataPropertyName = "TenThe";
            this.colTenThe.HeaderText = "Tên thẻ";
            this.colTenThe.Name = "colTenThe";
            this.colTenThe.ReadOnly = true;
            this.colTenThe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTenThe.Width = 300;
            // 
            // colGhiChu
            // 
            this.colGhiChu.DataPropertyName = "GhiChu";
            this.colGhiChu.HeaderText = "Ghi chú";
            this.colGhiChu.Name = "colGhiChu";
            this.colGhiChu.ReadOnly = true;
            this.colGhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colGhiChu.Width = 290;
            // 
            // colSuDung
            // 
            this.colSuDung.DataPropertyName = "SuDung";
            this.colSuDung.HeaderText = "Sử dụng";
            this.colSuDung.Name = "colSuDung";
            this.colSuDung.ReadOnly = true;
            this.colSuDung.Width = 80;
            // 
            // grpThucThi
            // 
            this.grpThucThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThucThi.Controls.Add(this.btnThemMoi);
            this.grpThucThi.Controls.Add(this.btnCapNhat);
            this.grpThucThi.Controls.Add(this.btnDong);
            this.grpThucThi.Controls.Add(this.btnXoa);
            this.grpThucThi.Location = new System.Drawing.Point(7, 480);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(895, 51);
            this.grpThucThi.TabIndex = 2;
            this.grpThucThi.TabStop = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMoi.Image")));
            this.btnThemMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemMoi.Location = new System.Drawing.Point(273, 16);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(79, 26);
            this.btnThemMoi.TabIndex = 19;
            this.btnThemMoi.Text = "    &Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(358, 16);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(79, 26);
            this.btnCapNhat.TabIndex = 20;
            this.btnCapNhat.Text = "    &Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(528, 16);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(79, 26);
            this.btnDong.TabIndex = 22;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(443, 16);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(79, 26);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "&Xóa ";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTenTheLoc);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGhiChuLoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaTheLoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(895, 50);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(223, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Tên thẻ";
            // 
            // txtTenTheLoc
            // 
            this.txtTenTheLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTheLoc.ForeColor = System.Drawing.Color.Black;
            this.txtTenTheLoc.Location = new System.Drawing.Point(273, 19);
            this.txtTenTheLoc.MaxLength = 15;
            this.txtTenTheLoc.Name = "txtTenTheLoc";
            this.txtTenTheLoc.Size = new System.Drawing.Size(225, 20);
            this.txtTenTheLoc.TabIndex = 6;
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoc.Location = new System.Drawing.Point(803, 17);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(75, 23);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(26, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã thẻ";
            // 
            // txtGhiChuLoc
            // 
            this.txtGhiChuLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChuLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChuLoc.ForeColor = System.Drawing.Color.Black;
            this.txtGhiChuLoc.Location = new System.Drawing.Point(554, 19);
            this.txtGhiChuLoc.MaxLength = 150;
            this.txtGhiChuLoc.Name = "txtGhiChuLoc";
            this.txtGhiChuLoc.Size = new System.Drawing.Size(243, 20);
            this.txtGhiChuLoc.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(504, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ghi chú";
            // 
            // txtMaTheLoc
            // 
            this.txtMaTheLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTheLoc.ForeColor = System.Drawing.Color.Black;
            this.txtMaTheLoc.Location = new System.Drawing.Point(76, 19);
            this.txtMaTheLoc.MaxLength = 15;
            this.txtMaTheLoc.Name = "txtMaTheLoc";
            this.txtMaTheLoc.Size = new System.Drawing.Size(141, 20);
            this.txtMaTheLoc.TabIndex = 1;
            // 
            // frmDM_The
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpThucThi);
            this.Controls.Add(this.grpThongTin);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmDM_The";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại thẻ khách hàng";
            this.Load += new System.EventHandler(this.frmDM_The_Load);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiThe)).EndInit();
            this.grpThucThi.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.GroupBox grpThucThi;
        internal QLBH.Core.Form.GtidButton btnThemMoi;
        internal QLBH.Core.Form.GtidButton btnXoa;
        internal QLBH.Core.Form.GtidButton btnCapNhat;
        internal QLBH.Core.Form.GtidButton btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private QLBH.Core.Form.GtidButton btnLoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGhiChuLoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaTheLoc;
        private System.Windows.Forms.DataGridView dgvLoaiThe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenTheLoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdLoaiThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhiChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSuDung;
    }
}