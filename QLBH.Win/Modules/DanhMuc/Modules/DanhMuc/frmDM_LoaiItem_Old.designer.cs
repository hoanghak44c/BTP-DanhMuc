namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_LoaiItem_Old
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMaLoaiItem = new System.Windows.Forms.TextBox();
            this.lblMaItem = new System.Windows.Forms.Label();
            this.lblSuDung = new System.Windows.Forms.Label();
            this.cbSuDung = new System.Windows.Forms.CheckBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.clIdLoaiItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMaLoaiItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenLoaiItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSudung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblTenItem = new System.Windows.Forms.Label();
            this.txtTenLoaiItem = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucActions1 = new QLBH.Core.UserControls.UCActions();
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
            this.groupBox1.Controls.Add(this.txtTenLoiSearch);
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
            this.btTimKiem.Location = new System.Drawing.Point(307, 18);
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
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tên loại Item";
            // 
            // txtTenLoiSearch
            // 
            this.txtTenLoiSearch.Location = new System.Drawing.Point(88, 22);
            this.txtTenLoiSearch.Name = "txtTenLoiSearch";
            this.txtTenLoiSearch.Size = new System.Drawing.Size(202, 21);
            this.txtTenLoiSearch.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMaLoaiItem);
            this.groupBox2.Controls.Add(this.lblMaItem);
            this.groupBox2.Controls.Add(this.lblSuDung);
            this.groupBox2.Controls.Add(this.cbSuDung);
            this.groupBox2.Controls.Add(this.dgvList);
            this.groupBox2.Controls.Add(this.lblGhiChu);
            this.groupBox2.Controls.Add(this.txtGhiChu);
            this.groupBox2.Controls.Add(this.lblTenItem);
            this.groupBox2.Controls.Add(this.txtTenLoaiItem);
            this.groupBox2.Location = new System.Drawing.Point(10, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách mã lỗi";
            // 
            // txtMaLoaiItem
            // 
            this.txtMaLoaiItem.Location = new System.Drawing.Point(481, 202);
            this.txtMaLoaiItem.Name = "txtMaLoaiItem";
            this.txtMaLoaiItem.Size = new System.Drawing.Size(176, 21);
            this.txtMaLoaiItem.TabIndex = 24;
            // 
            // lblMaItem
            // 
            this.lblMaItem.AutoSize = true;
            this.lblMaItem.Location = new System.Drawing.Point(411, 205);
            this.lblMaItem.Name = "lblMaItem";
            this.lblMaItem.Size = new System.Drawing.Size(65, 13);
            this.lblMaItem.TabIndex = 23;
            this.lblMaItem.Text = "Mã loại Item";
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
            this.cbSuDung.Location = new System.Drawing.Point(74, 287);
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
            this.clIdLoaiItem,
            this.clMaLoaiItem,
            this.clTenLoaiItem,
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
            // clIdLoaiItem
            // 
            this.clIdLoaiItem.DataPropertyName = "IdLoaiItem";
            this.clIdLoaiItem.HeaderText = "IdLoaiItem";
            this.clIdLoaiItem.Name = "clIdLoaiItem";
            this.clIdLoaiItem.ReadOnly = true;
            this.clIdLoaiItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clIdLoaiItem.Visible = false;
            // 
            // clMaLoaiItem
            // 
            this.clMaLoaiItem.DataPropertyName = "MaLoaiItem";
            this.clMaLoaiItem.HeaderText = "MaLoaiItem";
            this.clMaLoaiItem.Name = "clMaLoaiItem";
            this.clMaLoaiItem.ReadOnly = true;
            this.clMaLoaiItem.Width = 120;
            // 
            // clTenLoaiItem
            // 
            this.clTenLoaiItem.DataPropertyName = "TenLoaiItem";
            this.clTenLoaiItem.HeaderText = "Tên loại Item";
            this.clTenLoaiItem.Name = "clTenLoaiItem";
            this.clTenLoaiItem.ReadOnly = true;
            this.clTenLoaiItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clTenLoaiItem.Width = 180;
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "GhiChu";
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
            this.txtGhiChu.Location = new System.Drawing.Point(75, 227);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(582, 54);
            this.txtGhiChu.TabIndex = 18;
            // 
            // lblTenItem
            // 
            this.lblTenItem.AutoSize = true;
            this.lblTenItem.Location = new System.Drawing.Point(3, 204);
            this.lblTenItem.Name = "lblTenItem";
            this.lblTenItem.Size = new System.Drawing.Size(69, 13);
            this.lblTenItem.TabIndex = 17;
            this.lblTenItem.Text = "Tên loại Item";
            // 
            // txtTenLoaiItem
            // 
            this.txtTenLoaiItem.Location = new System.Drawing.Point(74, 201);
            this.txtTenLoaiItem.Name = "txtTenLoaiItem";
            this.txtTenLoaiItem.Size = new System.Drawing.Size(322, 21);
            this.txtTenLoaiItem.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucActions1);
            this.groupBox3.Location = new System.Drawing.Point(10, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(663, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // ucActions1
            // 
            this.ucActions1.Location = new System.Drawing.Point(88, 18);
            this.ucActions1.Name = "ucActions1";
            this.ucActions1.Size = new System.Drawing.Size(490, 33);
            this.ucActions1.TabIndex = 0;
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
            // frmDM_LoaiItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDM_LoaiItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục Loại Item";
            this.Load += new System.EventHandler(this.frmDM_LoaiItem_Load);
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
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblTenItem;
        private System.Windows.Forms.TextBox txtTenLoaiItem;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoiSearch;
        private QLBH.Core.Form.GtidButton btTimKiem;
        private System.Windows.Forms.Label lblSuDung;
        private System.Windows.Forms.CheckBox cbSuDung;
        private System.Windows.Forms.Label lblMaItem;
        private System.Windows.Forms.TextBox txtMaLoaiItem;
        private QLBH.Core.UserControls.UCActions ucActions1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdLoaiItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMaLoaiItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenLoaiItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSudung;
    }
}