namespace QLBanHang.Modules
{
    partial class frmDM_CauHinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTimKiem = new QLBH.Core.Form.GtidButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenCauHinhSearch = new System.Windows.Forms.TextBox();
            this.cboLoaiItemSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaCauHinh = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSuDung = new System.Windows.Forms.CheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.IdCauHinh_ThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCauHinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLoaiItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCauHinh_ThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sudung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCauHinh = new System.Windows.Forms.TextBox();
            this.cboLoaiItem = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btThoat = new QLBH.Core.Form.GtidButton();
            this.btXoa = new QLBH.Core.Form.GtidButton();
            this.btCapNhat = new QLBH.Core.Form.GtidButton();
            this.btThem = new QLBH.Core.Form.GtidButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenCauHinhSearch);
            this.groupBox1.Controls.Add(this.cboLoaiItemSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 61);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTimKiem.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Appearance.Options.UseFont = true;
            this.btTimKiem.Location = new System.Drawing.Point(587, 22);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btTimKiem.Size = new System.Drawing.Size(72, 28);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên cấu hình";
            // 
            // txtTenCauHinhSearch
            // 
            this.txtTenCauHinhSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenCauHinhSearch.Location = new System.Drawing.Point(382, 24);
            this.txtTenCauHinhSearch.Name = "txtTenCauHinhSearch";
            this.txtTenCauHinhSearch.Size = new System.Drawing.Size(202, 22);
            this.txtTenCauHinhSearch.TabIndex = 18;
            this.txtTenCauHinhSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenCauHinhSearch_KeyPress);
            // 
            // cboLoaiItemSearch
            // 
            this.cboLoaiItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiItemSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiItemSearch.FormattingEnabled = true;
            this.cboLoaiItemSearch.Location = new System.Drawing.Point(78, 20);
            this.cboLoaiItemSearch.Name = "cboLoaiItemSearch";
            this.cboLoaiItemSearch.Size = new System.Drawing.Size(220, 24);
            this.cboLoaiItemSearch.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Loại thiết bị";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaCauHinh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbSuDung);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtCauHinh);
            this.groupBox2.Controls.Add(this.cboLoaiItem);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(10, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 360);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách cấu hình";
            // 
            // txtMaCauHinh
            // 
            this.txtMaCauHinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCauHinh.Location = new System.Drawing.Point(486, 248);
            this.txtMaCauHinh.Name = "txtMaCauHinh";
            this.txtMaCauHinh.Size = new System.Drawing.Size(171, 22);
            this.txtMaCauHinh.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(402, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Mã cấu hình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sử dụng";
            // 
            // cbSuDung
            // 
            this.cbSuDung.AutoSize = true;
            this.cbSuDung.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuDung.Location = new System.Drawing.Point(95, 340);
            this.cbSuDung.Name = "cbSuDung";
            this.cbSuDung.Size = new System.Drawing.Size(15, 14);
            this.cbSuDung.TabIndex = 21;
            this.cbSuDung.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCauHinh_ThietBi,
            this.MaCauHinh,
            this.IdLoaiItem,
            this.TenLoaiItem,
            this.TenCauHinh_ThietBi,
            this.GhiChu,
            this.Sudung});
            this.dgvList.Location = new System.Drawing.Point(8, 19);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.RowHeadersWidth = 25;
            this.dgvList.RowTemplate.Height = 20;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(649, 180);
            this.dgvList.TabIndex = 20;
            this.dgvList.CurrentCellChanged += new System.EventHandler(this.dgvList_CurrentCellChanged);
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // IdCauHinh_ThietBi
            // 
            this.IdCauHinh_ThietBi.DataPropertyName = "IdCauHinh_ThietBi";
            this.IdCauHinh_ThietBi.HeaderText = "IdCauHinh_ThietBi";
            this.IdCauHinh_ThietBi.Name = "IdCauHinh_ThietBi";
            this.IdCauHinh_ThietBi.ReadOnly = true;
            this.IdCauHinh_ThietBi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdCauHinh_ThietBi.Visible = false;
            // 
            // MaCauHinh
            // 
            this.MaCauHinh.DataPropertyName = "MaCauHinh";
            this.MaCauHinh.HeaderText = "MaCauHinh";
            this.MaCauHinh.Name = "MaCauHinh";
            this.MaCauHinh.ReadOnly = true;
            // 
            // IdLoaiItem
            // 
            this.IdLoaiItem.DataPropertyName = "IdLoaiItem";
            this.IdLoaiItem.HeaderText = "IdLoaiItem";
            this.IdLoaiItem.Name = "IdLoaiItem";
            this.IdLoaiItem.ReadOnly = true;
            this.IdLoaiItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdLoaiItem.Visible = false;
            // 
            // TenLoaiItem
            // 
            this.TenLoaiItem.DataPropertyName = "TenLoaiItem";
            this.TenLoaiItem.HeaderText = "Loại thiết bị";
            this.TenLoaiItem.Name = "TenLoaiItem";
            this.TenLoaiItem.ReadOnly = true;
            this.TenLoaiItem.Width = 120;
            // 
            // TenCauHinh_ThietBi
            // 
            this.TenCauHinh_ThietBi.DataPropertyName = "TenCauHinh_ThietBi";
            this.TenCauHinh_ThietBi.HeaderText = "Tên cấu hình";
            this.TenCauHinh_ThietBi.Name = "TenCauHinh_ThietBi";
            this.TenCauHinh_ThietBi.ReadOnly = true;
            this.TenCauHinh_ThietBi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenCauHinh_ThietBi.Width = 180;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GhiChu.Width = 230;
            // 
            // Sudung
            // 
            this.Sudung.DataPropertyName = "SuDung";
            this.Sudung.HeaderText = "Sử dụng";
            this.Sudung.Name = "Sudung";
            this.Sudung.ReadOnly = true;
            this.Sudung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sudung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(95, 276);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(562, 58);
            this.txtGhiChu.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tên cấu hình";
            // 
            // txtCauHinh
            // 
            this.txtCauHinh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCauHinh.Location = new System.Drawing.Point(95, 248);
            this.txtCauHinh.Name = "txtCauHinh";
            this.txtCauHinh.Size = new System.Drawing.Size(301, 22);
            this.txtCauHinh.TabIndex = 16;
            // 
            // cboLoaiItem
            // 
            this.cboLoaiItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiItem.FormattingEnabled = true;
            this.cboLoaiItem.Location = new System.Drawing.Point(95, 218);
            this.cboLoaiItem.Name = "cboLoaiItem";
            this.cboLoaiItem.Size = new System.Drawing.Size(156, 24);
            this.cboLoaiItem.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Loại thiết bị";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btThoat);
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btCapNhat);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 447);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 61);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btThoat
            // 
            this.btThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThoat.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Appearance.Options.UseFont = true;
            this.btThoat.Location = new System.Drawing.Point(429, 20);
            this.btThoat.Name = "btThoat";
            this.btThoat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btThoat.Size = new System.Drawing.Size(78, 28);
            this.btThoat.TabIndex = 11;
            this.btThoat.Text = "Đóng";
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btXoa
            // 
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btXoa.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(339, 20);
            this.btXoa.Name = "btXoa";
            this.btXoa.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btXoa.Size = new System.Drawing.Size(78, 28);
            this.btXoa.TabIndex = 10;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCapNhat.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btCapNhat.Appearance.Options.UseFont = true;
            this.btCapNhat.Location = new System.Drawing.Point(248, 20);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btCapNhat.Size = new System.Drawing.Size(78, 28);
            this.btCapNhat.TabIndex = 9;
            this.btCapNhat.Text = "Cập nhật";
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // btThem
            // 
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btThem.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Location = new System.Drawing.Point(156, 20);
            this.btThem.Name = "btThem";
            this.btThem.ShortCutKey = System.Windows.Forms.Keys.None;
            this.btThem.Size = new System.Drawing.Size(78, 28);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm mới";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // frmDM_CauHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(223)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(676, 514);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDM_CauHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục cấu hình";
            this.Load += new System.EventHandler(this.frmDanhMucCauHinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private QLBH.Core.Form.GtidButton btThoat;
        private QLBH.Core.Form.GtidButton btXoa;
        private QLBH.Core.Form.GtidButton btCapNhat;
        private QLBH.Core.Form.GtidButton btThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCauHinh;
        private System.Windows.Forms.ComboBox cboLoaiItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cboLoaiItemSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenCauHinhSearch;
        private QLBH.Core.Form.GtidButton btTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbSuDung;
        private System.Windows.Forms.TextBox txtMaCauHinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCauHinh_ThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoaiItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCauHinh_ThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sudung;
    }
}