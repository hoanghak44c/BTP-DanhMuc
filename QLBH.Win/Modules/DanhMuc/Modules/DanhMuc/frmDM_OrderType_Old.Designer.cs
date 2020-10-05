using QLBH.Core.Form;
namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_OrderType_Old
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.ucActions1 = new QLBH.Core.UserControls.UCActions();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.clIdOrderType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSuDung = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMaOrder = new QLBH.Core.Form.GtidTextBox();
            this.txtMoTa = new QLBH.Core.Form.GtidTextBox();
            this.txtTenOrderType = new QLBH.Core.Form.GtidTextBox();
            this.lblSuDung = new System.Windows.Forms.Label();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtMaLine = new QLBH.Core.Form.GtidTextBox();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpThucThi
            // 
            this.grpThucThi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThucThi.Controls.Add(this.ucActions1);
            this.grpThucThi.Location = new System.Drawing.Point(7, 496);
            this.grpThucThi.Name = "grpThucThi";
            this.grpThucThi.Size = new System.Drawing.Size(710, 51);
            this.grpThucThi.TabIndex = 1;
            this.grpThucThi.TabStop = false;
            // 
            // ucActions1
            // 
            this.ucActions1.Location = new System.Drawing.Point(0, 12);
            this.ucActions1.Name = "ucActions1";
            this.ucActions1.Size = new System.Drawing.Size(707, 33);
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
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.tableLayoutPanel3);
            this.grpThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThongTin.ForeColor = System.Drawing.Color.Black;
            this.grpThongTin.Location = new System.Drawing.Point(7, 35);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(710, 459);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Danh sách Order Type";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 412F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dgvList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblMa, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMaOrder, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMoTa, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtTenOrderType, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblSuDung, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.chkSuDung, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblMoTa, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblTen, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblLine, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtMaLine, 1, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(704, 440);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clIdOrderType,
            this.clCode,
            this.clName,
            this.clGhiChu,
            this.clSuDung,
            this.clLine});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvList, 4);
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 25;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvList.RowTemplate.Height = 20;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvList.Size = new System.Drawing.Size(698, 281);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // clIdOrderType
            // 
            this.clIdOrderType.DataPropertyName = "IdOrderType";
            this.clIdOrderType.HeaderText = "Id";
            this.clIdOrderType.Name = "clIdOrderType";
            this.clIdOrderType.Visible = false;
            // 
            // clCode
            // 
            this.clCode.DataPropertyName = "Code";
            this.clCode.HeaderText = "Code";
            this.clCode.Name = "clCode";
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Name";
            this.clName.Name = "clName";
            // 
            // clGhiChu
            // 
            this.clGhiChu.DataPropertyName = "GhiChu";
            this.clGhiChu.HeaderText = "Ghi Chú";
            this.clGhiChu.Name = "clGhiChu";
            // 
            // clSuDung
            // 
            this.clSuDung.DataPropertyName = "SuDung";
            this.clSuDung.HeaderText = "Sử Dụng";
            this.clSuDung.Name = "clSuDung";
            this.clSuDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clSuDung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // clLine
            // 
            this.clLine.DataPropertyName = "Line";
            this.clLine.HeaderText = "Line";
            this.clLine.Name = "clLine";
            // 
            // lblMa
            // 
            this.lblMa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.Black;
            this.lblMa.Location = new System.Drawing.Point(3, 301);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(64, 13);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã ORDER";
            // 
            // txtMaOrder
            // 
            this.txtMaOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMaOrder.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaOrder.Location = new System.Drawing.Point(93, 298);
            this.txtMaOrder.MaxLength = 50;
            this.txtMaOrder.Name = "txtMaOrder";
            this.txtMaOrder.Size = new System.Drawing.Size(188, 20);
            this.txtMaOrder.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtMoTa, 2);
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(93, 373);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.tableLayoutPanel3.SetRowSpan(this.txtMoTa, 2);
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(600, 44);
            this.txtMoTa.TabIndex = 3;
            // 
            // txtTenOrderType
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtTenOrderType, 2);
            this.txtTenOrderType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTenOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenOrderType.Location = new System.Drawing.Point(93, 348);
            this.txtTenOrderType.Name = "txtTenOrderType";
            this.txtTenOrderType.Size = new System.Drawing.Size(600, 20);
            this.txtTenOrderType.TabIndex = 2;
            // 
            // lblSuDung
            // 
            this.lblSuDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSuDung.AutoSize = true;
            this.lblSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuDung.ForeColor = System.Drawing.Color.Black;
            this.lblSuDung.Location = new System.Drawing.Point(3, 423);
            this.lblSuDung.Name = "lblSuDung";
            this.lblSuDung.Size = new System.Drawing.Size(47, 13);
            this.lblSuDung.TabIndex = 0;
            this.lblSuDung.Text = "Sử dụng";
            // 
            // chkSuDung
            // 
            this.chkSuDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(93, 423);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(15, 14);
            this.chkSuDung.TabIndex = 4;
            this.chkSuDung.UseVisualStyleBackColor = true;
            // 
            // lblMoTa
            // 
            this.lblMoTa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.ForeColor = System.Drawing.Color.Black;
            this.lblMoTa.Location = new System.Drawing.Point(3, 376);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(34, 13);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô tả";
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(3, 351);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(79, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên OrderType";
            // 
            // lblLine
            // 
            this.lblLine.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.ForeColor = System.Drawing.Color.Black;
            this.lblLine.Location = new System.Drawing.Point(3, 326);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(49, 13);
            this.lblLine.TabIndex = 5;
            this.lblLine.Text = "Mã LINE";
            // 
            // txtMaLine
            // 
            this.txtMaLine.Location = new System.Drawing.Point(93, 323);
            this.txtMaLine.MaxLength = 50;
            this.txtMaLine.Name = "txtMaLine";
            this.txtMaLine.Size = new System.Drawing.Size(188, 20);
            this.txtMaLine.TabIndex = 6;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTieuDe.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblTieuDe, 4);
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTieuDe.Location = new System.Drawing.Point(184, 4);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(334, 24);
            this.lblTieuDe.TabIndex = 45;
            this.lblTieuDe.Text = "DANH MỤC ORDERTYPE";
            this.lblTieuDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99957F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00043F));
            this.tableLayoutPanel1.Controls.Add(this.lblTieuDe, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 32);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // frmDM_OrderType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpThucThi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(733, 581);
            this.MinimumSize = new System.Drawing.Size(733, 581);
            this.Name = "frmDM_OrderType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục OrderType";
            this.Load += new System.EventHandler(this.frmDM_OrderType_Load);
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThucThi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblSuDung;
        private System.Windows.Forms.CheckBox chkSuDung;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblLine;
        private GtidTextBox txtMaOrder;
        private GtidTextBox txtMoTa;
        private GtidTextBox txtTenOrderType;
        private GtidTextBox txtMaLine;
        private QLBH.Core.UserControls.UCActions ucActions1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdOrderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLine;
    }
}