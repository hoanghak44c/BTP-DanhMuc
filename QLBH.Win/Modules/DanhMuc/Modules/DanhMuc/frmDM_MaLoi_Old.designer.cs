namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_MaLoi_Old
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
            this.txtTenLoiSearch = new System.Windows.Forms.TextBox();
            this.cboLoaiItemSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLoaiTB = new System.Windows.Forms.Label();
            this.cboLoaiItem = new System.Windows.Forms.ComboBox();
            this.txtTenLoi = new System.Windows.Forms.TextBox();
            this.lblTenLoi = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.IdMaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdLoaiItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sudung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbSuDung = new System.Windows.Forms.CheckBox();
            this.lblSuDung = new System.Windows.Forms.Label();
            this.txtMaLoi = new System.Windows.Forms.TextBox();
            this.lblMaLoi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucActions1 = new QLBH.Core.UserControls.UCActions();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenLoiSearch);
            this.groupBox1.Controls.Add(this.cboLoaiItemSearch);
            this.groupBox1.Controls.Add(this.label2);
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
            this.btTimKiem.Location = new System.Drawing.Point(585, 19);
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
            this.label3.Location = new System.Drawing.Point(303, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên cấu hình";
            // 
            // txtTenLoiSearch
            // 
            this.txtTenLoiSearch.Location = new System.Drawing.Point(374, 22);
            this.txtTenLoiSearch.Name = "txtTenLoiSearch";
            this.txtTenLoiSearch.Size = new System.Drawing.Size(202, 21);
            this.txtTenLoiSearch.TabIndex = 18;
            // 
            // cboLoaiItemSearch
            // 
            this.cboLoaiItemSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiItemSearch.FormattingEnabled = true;
            this.cboLoaiItemSearch.Location = new System.Drawing.Point(75, 21);
            this.cboLoaiItemSearch.Name = "cboLoaiItemSearch";
            this.cboLoaiItemSearch.Size = new System.Drawing.Size(220, 21);
            this.cboLoaiItemSearch.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Loại thiết bị";
            // 
            // lblLoaiTB
            // 
            this.lblLoaiTB.AutoSize = true;
            this.lblLoaiTB.Location = new System.Drawing.Point(4, 205);
            this.lblLoaiTB.Name = "lblLoaiTB";
            this.lblLoaiTB.Size = new System.Drawing.Size(62, 13);
            this.lblLoaiTB.TabIndex = 14;
            this.lblLoaiTB.Text = "Loại thiết bị";
            // 
            // cboLoaiItem
            // 
            this.cboLoaiItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiItem.FormattingEnabled = true;
            this.cboLoaiItem.Location = new System.Drawing.Point(75, 202);
            this.cboLoaiItem.Name = "cboLoaiItem";
            this.cboLoaiItem.Size = new System.Drawing.Size(156, 21);
            this.cboLoaiItem.TabIndex = 15;
            // 
            // txtTenLoi
            // 
            this.txtTenLoi.Location = new System.Drawing.Point(75, 230);
            this.txtTenLoi.Name = "txtTenLoi";
            this.txtTenLoi.Size = new System.Drawing.Size(322, 21);
            this.txtTenLoi.TabIndex = 16;
            // 
            // lblTenLoi
            // 
            this.lblTenLoi.AutoSize = true;
            this.lblTenLoi.Location = new System.Drawing.Point(4, 233);
            this.lblTenLoi.Name = "lblTenLoi";
            this.lblTenLoi.Size = new System.Drawing.Size(38, 13);
            this.lblTenLoi.TabIndex = 17;
            this.lblTenLoi.Text = "Tên lỗi";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(76, 256);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(581, 54);
            this.txtGhiChu.TabIndex = 18;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(4, 259);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(42, 13);
            this.lblGhiChu.TabIndex = 19;
            this.lblGhiChu.Text = "Ghi chú";
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
            this.IdMaLoi,
            this.IdLoaiItem,
            this.TenLoaiItem,
            this.MaLoi,
            this.TenLoi,
            this.GhiChu,
            this.Sudung});
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
            this.dgvList.Size = new System.Drawing.Size(649, 167);
            this.dgvList.TabIndex = 20;
            // 
            // IdMaLoi
            // 
            this.IdMaLoi.DataPropertyName = "IdMaLoi";
            this.IdMaLoi.HeaderText = "IdMaLoi";
            this.IdMaLoi.Name = "IdMaLoi";
            this.IdMaLoi.ReadOnly = true;
            this.IdMaLoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdMaLoi.Visible = false;
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
            // MaLoi
            // 
            this.MaLoi.DataPropertyName = "MaLoi";
            this.MaLoi.HeaderText = "MaLoi";
            this.MaLoi.Name = "MaLoi";
            this.MaLoi.ReadOnly = true;
            // 
            // TenLoi
            // 
            this.TenLoi.DataPropertyName = "TenLoi";
            this.TenLoi.HeaderText = "Tên lỗi";
            this.TenLoi.Name = "TenLoi";
            this.TenLoi.ReadOnly = true;
            this.TenLoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.TenLoi.Width = 180;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            this.GhiChu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.GhiChu.Width = 250;
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
            // cbSuDung
            // 
            this.cbSuDung.AutoSize = true;
            this.cbSuDung.Location = new System.Drawing.Point(75, 316);
            this.cbSuDung.Name = "cbSuDung";
            this.cbSuDung.Size = new System.Drawing.Size(15, 14);
            this.cbSuDung.TabIndex = 21;
            this.cbSuDung.UseVisualStyleBackColor = true;
            // 
            // lblSuDung
            // 
            this.lblSuDung.AutoSize = true;
            this.lblSuDung.Location = new System.Drawing.Point(5, 316);
            this.lblSuDung.Name = "lblSuDung";
            this.lblSuDung.Size = new System.Drawing.Size(47, 13);
            this.lblSuDung.TabIndex = 22;
            this.lblSuDung.Text = "Sử dụng";
            // 
            // txtMaLoi
            // 
            this.txtMaLoi.Location = new System.Drawing.Point(454, 230);
            this.txtMaLoi.Name = "txtMaLoi";
            this.txtMaLoi.Size = new System.Drawing.Size(203, 21);
            this.txtMaLoi.TabIndex = 23;
            // 
            // lblMaLoi
            // 
            this.lblMaLoi.AutoSize = true;
            this.lblMaLoi.Location = new System.Drawing.Point(413, 233);
            this.lblMaLoi.Name = "lblMaLoi";
            this.lblMaLoi.Size = new System.Drawing.Size(34, 13);
            this.lblMaLoi.TabIndex = 24;
            this.lblMaLoi.Text = "Mã lỗi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaLoi);
            this.groupBox2.Controls.Add(this.txtMaLoi);
            this.groupBox2.Controls.Add(this.lblSuDung);
            this.groupBox2.Controls.Add(this.cbSuDung);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Controls.Add(this.lblGhiChu);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.lblTenLoi);
            this.groupBox2.Controls.Add(this.txtTenLoi);
            this.groupBox2.Controls.Add(this.cboLoaiItem);
            this.groupBox2.Controls.Add(this.lblLoaiTB);
            this.groupBox2.Location = new System.Drawing.Point(10, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mã lỗi";
            // 
            // ucActions1
            // 
            this.ucActions1.Location = new System.Drawing.Point(6, 11);
            this.ucActions1.Name = "ucActions1";
            this.ucActions1.Size = new System.Drawing.Size(656, 33);
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
            this.groupBox3.Location = new System.Drawing.Point(10, 421);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 46);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // frmDM_MaLoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 477);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDM_MaLoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục mã lỗi";
            this.Load += new System.EventHandler(this.frmDM_MaLoi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLoaiItemSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoiSearch;
        private QLBH.Core.Form.GtidButton btTimKiem;
        private System.Windows.Forms.Label lblLoaiTB;
        private System.Windows.Forms.ComboBox cboLoaiItem;
        private System.Windows.Forms.TextBox txtTenLoi;
        private System.Windows.Forms.Label lblTenLoi;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLoaiItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sudung;
        private System.Windows.Forms.CheckBox cbSuDung;
        private System.Windows.Forms.Label lblSuDung;
        private System.Windows.Forms.TextBox txtMaLoi;
        private System.Windows.Forms.Label lblMaLoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLBH.Core.UserControls.UCActions ucActions1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}