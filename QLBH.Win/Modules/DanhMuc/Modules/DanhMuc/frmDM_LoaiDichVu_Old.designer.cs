namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_LoaiDichVu_Old
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
            this.txtTenLoaiDichVuSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaLoaiDichVu = new System.Windows.Forms.TextBox();
            this.lblMaDV = new System.Windows.Forms.Label();
            this.lblSuDung = new System.Windows.Forms.Label();
            this.cbSuDung = new System.Windows.Forms.CheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.txtTenLoaiDichVu = new System.Windows.Forms.TextBox();
            this.ucActions1 = new QLBH.Core.UserControls.UCActions();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clIdLoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaLoaiDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSudung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.groupBox1.Controls.Add(this.txtTenLoaiDichVuSearch);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(663, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Location = new System.Drawing.Point(320, 20);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(72, 26);
            this.btTimKiem.TabIndex = 12;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên loại dịch vụ";
            // 
            // txtTenLoaiDichVuSearch
            // 
            this.txtTenLoaiDichVuSearch.Location = new System.Drawing.Point(101, 22);
            this.txtTenLoaiDichVuSearch.Name = "txtTenLoaiDichVuSearch";
            this.txtTenLoaiDichVuSearch.Size = new System.Drawing.Size(202, 21);
            this.txtTenLoaiDichVuSearch.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaLoaiDichVu);
            this.groupBox2.Controls.Add(this.lblMaDV);
            this.groupBox2.Controls.Add(this.lblSuDung);
            this.groupBox2.Controls.Add(this.cbSuDung);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Controls.Add(this.lblGhiChu);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.lblTenDV);
            this.groupBox2.Controls.Add(this.txtTenLoaiDichVu);
            this.groupBox2.Location = new System.Drawing.Point(10, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mã lỗi";
            // 
            // txtMaLoaiDichVu
            // 
            this.txtMaLoaiDichVu.Location = new System.Drawing.Point(506, 201);
            this.txtMaLoaiDichVu.Name = "txtMaLoaiDichVu";
            this.txtMaLoaiDichVu.Size = new System.Drawing.Size(151, 21);
            this.txtMaLoaiDichVu.TabIndex = 20;
            // 
            // lblMaDV
            // 
            this.lblMaDV.AutoSize = true;
            this.lblMaDV.Location = new System.Drawing.Point(421, 204);
            this.lblMaDV.Name = "lblMaDV";
            this.lblMaDV.Size = new System.Drawing.Size(77, 13);
            this.lblMaDV.TabIndex = 23;
            this.lblMaDV.Text = "Mã loại dịch vụ";
            // 
            // lblSuDung
            // 
            this.lblSuDung.AutoSize = true;
            this.lblSuDung.Location = new System.Drawing.Point(4, 287);
            this.lblSuDung.Name = "lblSuDung";
            this.lblSuDung.Size = new System.Drawing.Size(47, 13);
            this.lblSuDung.TabIndex = 22;
            this.lblSuDung.Text = "Sử dụng";
            // 
            // cbSuDung
            // 
            this.cbSuDung.AutoSize = true;
            this.cbSuDung.Location = new System.Drawing.Point(88, 289);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdLoaiDichVu,
            this.clMaLoaiDichVu,
            this.clTenDichVu,
            this.clGhiChu,
            this.clSudung});
            this.dgvList.Location = new System.Drawing.Point(8, 18);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.RowHeadersWidth = 25;
            this.dgvList.RowTemplate.Height = 20;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(649, 177);
            this.dgvList.TabIndex = 20;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(3, 230);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(42, 13);
            this.lblGhiChu.TabIndex = 19;
            this.lblGhiChu.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(89, 227);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(568, 54);
            this.txtGhiChu.TabIndex = 18;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Location = new System.Drawing.Point(3, 204);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(81, 13);
            this.lblTenDV.TabIndex = 17;
            this.lblTenDV.Text = "Tên loại dịch vụ";
            // 
            // txtTenLoaiDichVu
            // 
            this.txtTenLoaiDichVu.Location = new System.Drawing.Point(89, 201);
            this.txtTenLoaiDichVu.Name = "txtTenLoaiDichVu";
            this.txtTenLoaiDichVu.Size = new System.Drawing.Size(322, 21);
            this.txtTenLoaiDichVu.TabIndex = 16;
            // 
            // ucActions1
            // 
            this.ucActions1.Location = new System.Drawing.Point(89, 11);
            this.ucActions1.Name = "ucActions1";
            this.ucActions1.Size = new System.Drawing.Size(490, 33);
            this.ucActions1.TabIndex = 2;
            this.ucActions1.OnDelete += new QLBH.Core.UserControls.ActionHandler<object>(this.ucActions1_OnDelete);
            this.ucActions1.OnLoadEditor += new QLBH.Core.UserControls.ActionHandler<object>(this.ucActions1_OnLoadEditor);
            this.ucActions1.OnValidate += new QLBH.Core.UserControls.ActionValidateHandler<object>(this.ucActions1_OnValidate);
            this.ucActions1.OnEnableEditor += new QLBH.Core.UserControls.ActionHandler(this.ucActions1_OnEnableEditor);
            this.ucActions1.OnUpdate += new QLBH.Core.UserControls.ActionHandler<object>(this.ucActions1_OnUpdate);
            this.ucActions1.OnDisableEditor += new QLBH.Core.UserControls.ActionHandler(this.ucActions1_OnDisableEditor);
            this.ucActions1.OnClose += new QLBH.Core.UserControls.ActionHandler(this.ucActions1_OnClose);
            this.ucActions1.OnSynchronize += new QLBH.Core.UserControls.ActionHandler(this.ucActions1_OnSynchronize);
            this.ucActions1.OnAdd += new QLBH.Core.UserControls.ActionHandler<object>(this.ucActions1_OnAdd);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucActions1);
            this.groupBox3.Location = new System.Drawing.Point(10, 405);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 60);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // clIdLoaiDichVu
            // 
            this.clIdLoaiDichVu.DataPropertyName = "IdLoaiDichVu";
            this.clIdLoaiDichVu.HeaderText = "IdLoaiDichVu";
            this.clIdLoaiDichVu.Name = "clIdLoaiDichVu";
            this.clIdLoaiDichVu.ReadOnly = true;
            this.clIdLoaiDichVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clIdLoaiDichVu.Visible = false;
            // 
            // clMaLoaiDichVu
            // 
            this.clMaLoaiDichVu.DataPropertyName = "MaLoaiDichVu";
            this.clMaLoaiDichVu.HeaderText = "MaLoaiDichVu";
            this.clMaLoaiDichVu.Name = "clMaLoaiDichVu";
            this.clMaLoaiDichVu.ReadOnly = true;
            this.clMaLoaiDichVu.Width = 120;
            // 
            // clTenDichVu
            // 
            this.clTenDichVu.DataPropertyName = "TenDichVu";
            this.clTenDichVu.HeaderText = "Tên loại dịch vụ";
            this.clTenDichVu.Name = "clTenDichVu";
            this.clTenDichVu.ReadOnly = true;
            this.clTenDichVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clTenDichVu.Width = 180;
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi Chú";
            this.clGhiChu.Name = "clGhiChu";
            this.clGhiChu.ReadOnly = true;
            this.clGhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clGhiChu.Width = 250;
            // 
            // clSudung
            // 
            this.clSudung.DataPropertyName = "SuDung";
            this.clSudung.HeaderText = "Sử dụng";
            this.clSudung.Name = "clSudung";
            this.clSudung.ReadOnly = true;
            this.clSudung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSudung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmDM_LoaiDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 469);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDM_LoaiDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại dịch vụ";
            this.Load += new System.EventHandler(this.frmDM_LoaiDichVu_Load);
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
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.TextBox txtTenLoaiDichVu;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoaiDichVuSearch;
        private QLBH.Core.Form.GtidButton btTimKiem;
        private System.Windows.Forms.Label lblSuDung;
        private System.Windows.Forms.CheckBox cbSuDung;
        private System.Windows.Forms.Label lblMaDV;
        private System.Windows.Forms.TextBox txtMaLoaiDichVu;
        private QLBH.Core.UserControls.UCActions ucActions1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLoaiDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSudung;
    }
}