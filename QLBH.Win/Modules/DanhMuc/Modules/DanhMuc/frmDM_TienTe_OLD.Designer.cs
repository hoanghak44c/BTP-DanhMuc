using QLBH.Core.Form;
namespace QLBanHang.Modules.DanhMuc
{
    partial class frmDM_TienTe_OLD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpThucThi = new System.Windows.Forms.GroupBox();
            this.ucActions1 = new QLBH.Core.UserControls.UCActions();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.clKyHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTenTienTe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTyGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new QLBH.Core.Form.GtidTextBox();
            this.chkSuDung = new System.Windows.Forms.CheckBox();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new QLBH.Core.Form.GtidTextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new QLBH.Core.Form.GtidTextBox();
            this.lblTygia = new System.Windows.Forms.Label();
            this.txtTyGia = new QLBH.Core.Form.GtidTextBox();
            this.lblSuDung = new System.Windows.Forms.Label();
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
            this.ucActions1.Location = new System.Drawing.Point(3, 12);
            this.ucActions1.Name = "ucActions1";
            this.ucActions1.Size = new System.Drawing.Size(704, 33);
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
            this.grpThongTin.Text = "Danh sách họ trị liệu";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 498F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dgvList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblMa, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtMa, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.chkSuDung, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblMoTa, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtMoTa, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblTen, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtTen, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblTygia, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtTyGia, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblSuDung, 0, 7);
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(704, 440);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clKyHieu,
            this.clTenTienTe,
            this.clGhiChu,
            this.clSuDung,
            this.clTyGia,
            this.Id});
            this.tableLayoutPanel3.SetColumnSpan(this.dgvList, 4);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(3, 3);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 25;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.Height = 20;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(698, 281);
            this.dgvList.TabIndex = 0;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // clKyHieu
            // 
            this.clKyHieu.DataPropertyName = "KyHieu";
            this.clKyHieu.HeaderText = "Ký Hiệu";
            this.clKyHieu.Name = "clKyHieu";
            // 
            // clTenTienTe
            // 
            this.clTenTienTe.DataPropertyName = "TenTienTe";
            this.clTenTienTe.HeaderText = "Tên Tiền Tệ";
            this.clTenTienTe.Name = "clTenTienTe";
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
            // 
            // clTyGia
            // 
            this.clTyGia.DataPropertyName = "TyGia";
            this.clTyGia.HeaderText = "Tỷ Giá";
            this.clTyGia.Name = "clTyGia";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "IdTienTe";
            this.Id.HeaderText = "IdTienTe";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // lblMa
            // 
            this.lblMa.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.ForeColor = System.Drawing.Color.Black;
            this.lblMa.Location = new System.Drawing.Point(3, 301);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(67, 13);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã họ trị liệu";
            // 
            // txtMa
            // 
            this.txtMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMa.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(93, 298);
            this.txtMa.MaxLength = 10;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(102, 20);
            this.txtMa.TabIndex = 1;
            // 
            // chkSuDung
            // 
            this.chkSuDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.Location = new System.Drawing.Point(93, 420);
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
            this.lblMoTa.Location = new System.Drawing.Point(3, 351);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(34, 13);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtMoTa, 2);
            this.txtMoTa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.Location = new System.Drawing.Point(93, 348);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.tableLayoutPanel3.SetRowSpan(this.txtMoTa, 2);
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(600, 44);
            this.txtMoTa.TabIndex = 3;
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.Black;
            this.lblTen.Location = new System.Drawing.Point(3, 326);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(71, 13);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên họ trị liệu";
            // 
            // txtTen
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.txtTen, 2);
            this.txtTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(93, 323);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(600, 20);
            this.txtTen.TabIndex = 2;
            // 
            // lblTygia
            // 
            this.lblTygia.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTygia.AutoSize = true;
            this.lblTygia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTygia.ForeColor = System.Drawing.Color.Black;
            this.lblTygia.Location = new System.Drawing.Point(3, 398);
            this.lblTygia.Name = "lblTygia";
            this.lblTygia.Size = new System.Drawing.Size(36, 13);
            this.lblTygia.TabIndex = 0;
            this.lblTygia.Text = "Tỷ giá";
            // 
            // txtTyGia
            // 
            this.txtTyGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTyGia.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTyGia.Location = new System.Drawing.Point(93, 398);
            this.txtTyGia.MaxLength = 10;
            this.txtTyGia.Name = "txtTyGia";
            this.txtTyGia.Size = new System.Drawing.Size(102, 20);
            this.txtTyGia.TabIndex = 6;
            this.txtTyGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblSuDung
            // 
            this.lblSuDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSuDung.AutoSize = true;
            this.lblSuDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuDung.ForeColor = System.Drawing.Color.Black;
            this.lblSuDung.Location = new System.Drawing.Point(3, 421);
            this.lblSuDung.Name = "lblSuDung";
            this.lblSuDung.Size = new System.Drawing.Size(47, 13);
            this.lblSuDung.TabIndex = 0;
            this.lblSuDung.Text = "Sử dụng";
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
            this.lblTieuDe.Text = "DANH MỤC TIỀN TỆ";
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
            // frmDM_TienTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 543);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.grpThucThi);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(733, 581);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(733, 581);
            this.Name = "frmDM_TienTe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Họ trị liệu";
            this.Load += new System.EventHandler(this.frmDM_TienTe_Load);
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
        private System.Windows.Forms.CheckBox chkSuDung;
        private System.Windows.Forms.Label lblSuDung;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTygia;
        private GtidTextBox txtMoTa;
        private GtidTextBox txtMa;
        private GtidTextBox txtTen;
        private GtidTextBox txtTyGia;
        private QLBH.Core.UserControls.UCActions ucActions1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clKyHieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTenTienTe;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTyGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}