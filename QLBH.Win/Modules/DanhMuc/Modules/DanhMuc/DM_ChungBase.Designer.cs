namespace QLBanHang.Modules.DanhMuc
{
    partial class DM_ChungBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.clMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSuDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblSuDung = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.ucActions1 = new QLBH.Core.UserControls.UCActions();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxList = new System.Windows.Forms.GroupBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMa,
            this.clId,
            this.clTen,
            this.clSuDung,
            this.clMoTa});
            this.dgvList.Location = new System.Drawing.Point(6, 20);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(693, 245);
            this.dgvList.TabIndex = 48;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // clMa
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.clMa.DefaultCellStyle = dataGridViewCellStyle4;
            this.clMa.FillWeight = 88.23428F;
            this.clMa.HeaderText = "Mã";
            this.clMa.Name = "clMa";
            // 
            // clId
            // 
            this.clId.HeaderText = "clId";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Visible = false;
            // 
            // clTen
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clTen.DefaultCellStyle = dataGridViewCellStyle5;
            this.clTen.FillWeight = 101.5228F;
            this.clTen.HeaderText = "Tên";
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            // 
            // clSuDung
            // 
            this.clSuDung.FillWeight = 71.30051F;
            this.clSuDung.HeaderText = "Sử Dụng";
            this.clSuDung.Name = "clSuDung";
            this.clSuDung.ReadOnly = true;
            this.clSuDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSuDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clMoTa
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clMoTa.DefaultCellStyle = dataGridViewCellStyle6;
            this.clMoTa.FillWeight = 138.9423F;
            this.clMoTa.HeaderText = "Mô Tả";
            this.clMoTa.Name = "clMoTa";
            this.clMoTa.ReadOnly = true;
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(9, 283);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(21, 13);
            this.lblMa.TabIndex = 49;
            this.lblMa.Text = "Mã";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(9, 310);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(25, 13);
            this.lblTen.TabIndex = 50;
            this.lblTen.Text = "Tên";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Location = new System.Drawing.Point(9, 337);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(36, 13);
            this.lblMoTa.TabIndex = 52;
            this.lblMoTa.Text = "Mô Tả";
            // 
            // lblSuDung
            // 
            this.lblSuDung.AutoSize = true;
            this.lblSuDung.Location = new System.Drawing.Point(9, 402);
            this.lblSuDung.Name = "lblSuDung";
            this.lblSuDung.Size = new System.Drawing.Size(48, 13);
            this.lblSuDung.TabIndex = 53;
            this.lblSuDung.Text = "Sử Dụng";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(58, 280);
            this.txtMa.MaxLength = 10;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(184, 21);
            this.txtMa.TabIndex = 54;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(58, 307);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(184, 21);
            this.txtTen.TabIndex = 55;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(57, 334);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(642, 61);
            this.txtMoTa.TabIndex = 57;
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(58, 402);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(15, 14);
            this.chkSuDung.TabIndex = 58;
            this.chkSuDung.UseVisualStyleBackColor = true;
            // 
            // ucActions1
            // 
            this.ucActions1.Location = new System.Drawing.Point(101, 14);
            this.ucActions1.Name = "ucActions1";
            this.ucActions1.Size = new System.Drawing.Size(490, 33);
            this.ucActions1.TabIndex = 59;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucActions1);
            this.groupBox1.Location = new System.Drawing.Point(3, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 53);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
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
            this.groupBoxList.Controls.Add(this.dgvList);
            this.groupBoxList.Location = new System.Drawing.Point(3, 43);
            this.groupBoxList.Name = "groupBoxList";
            this.groupBoxList.Size = new System.Drawing.Size(705, 425);
            this.groupBoxList.TabIndex = 61;
            this.groupBoxList.TabStop = false;
            this.groupBoxList.Text = "Danh sách danh mục";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(268, 9);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(184, 24);
            this.lblTieuDe.TabIndex = 62;
            this.lblTieuDe.Text = "DANH MỤC CHUNG";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DM_ChungBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 553);
            this.Controls.Add(this.lblTieuDe);
            this.Controls.Add(this.groupBoxList);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(733, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(725, 591);
            this.Name = "DM_ChungBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Mục Chung";
            this.Load += new System.EventHandler(this.DM_ChungBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBoxList.ResumeLayout(false);
            this.groupBoxList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.DataGridView dgvList;
        protected System.Windows.Forms.Label lblMa;
        protected System.Windows.Forms.Label lblTen;
        protected System.Windows.Forms.Label lblMoTa;
        protected System.Windows.Forms.Label lblSuDung;
        protected System.Windows.Forms.TextBox txtMa;
        protected System.Windows.Forms.TextBox txtTen;
        protected System.Windows.Forms.TextBox txtMoTa;
        protected System.Windows.Forms.CheckBox chkSuDung;
        protected QLBH.Core.UserControls.UCActions ucActions1;
        protected System.Windows.Forms.GroupBox groupBoxList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoTa;
        protected System.Windows.Forms.Label lblTieuDe;
    }
}