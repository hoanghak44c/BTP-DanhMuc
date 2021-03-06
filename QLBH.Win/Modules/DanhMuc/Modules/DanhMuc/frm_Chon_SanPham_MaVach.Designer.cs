using QLBH.Core.Form;
namespace QLBanHang.Modules.DanhMuc
{
    partial class frm_Chon_SanPham_MaVach
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
            this.txtSearchTen = new GtidTextBox();
            this.txtSearchMa = new GtidTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new GtidButton();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchTen
            // 
            this.txtSearchTen.Location = new System.Drawing.Point(197, 31);
            this.txtSearchTen.Name = "txtSearchTen";
            this.txtSearchTen.Size = new System.Drawing.Size(422, 20);
            this.txtSearchTen.TabIndex = 1;
            this.txtSearchTen.TextChanged += new System.EventHandler(this.txtSearchTen_TextChanged);
            this.txtSearchTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchTen_KeyDown);
            // 
            // txtSearchMa
            // 
            this.txtSearchMa.Location = new System.Drawing.Point(48, 31);
            this.txtSearchMa.MaxLength = 10;
            this.txtSearchMa.Name = "txtSearchMa";
            this.txtSearchMa.Size = new System.Drawing.Size(151, 20);
            this.txtSearchMa.TabIndex = 0;
            this.txtSearchMa.TextChanged += new System.EventHandler(this.txtSearchMa_TextChanged);
            this.txtSearchMa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchMa_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Tìm";
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.Location = new System.Drawing.Point(284, 421);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(62, 25);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AllowUserToDeleteRows = false;
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colMa,
            this.colTen});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhMuc.Location = new System.Drawing.Point(7, 51);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhMuc.RowHeadersWidth = 25;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(612, 364);
            this.dgvDanhMuc.TabIndex = 2;
            this.dgvDanhMuc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDanhMuc_MouseClick);
            this.dgvDanhMuc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvDanhMuc_MouseDoubleClick);
            this.dgvDanhMuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDanhMuc_KeyDown);
            // 
            // colID
            // 
            this.colID.DataPropertyName = "IdSanPham";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "MaVach";
            this.colMa.HeaderText = "Mã vạch";
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            this.colMa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colMa.Width = 150;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "TenSanPham";
            this.colTen.HeaderText = "Tên";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            this.colTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTen.Width = 400;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(228, 3);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(174, 22);
            this.lbTitle.TabIndex = 33;
            this.lbTitle.Text = "CHỌN SẢN PHẨM";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Chon_SanPham_MaVach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 452);
            this.Controls.Add(this.txtSearchTen);
            this.Controls.Add(this.txtSearchMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.lbTitle);
            this.Name = "frm_Chon_SanPham_MaVach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chon_SanPham";
            this.Load += new System.EventHandler(this.frm_Chon_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchTen;
        private System.Windows.Forms.TextBox txtSearchMa;
        private System.Windows.Forms.Label label3;
        private QLBH.Core.Form.GtidButton btnThoat;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
    }
}