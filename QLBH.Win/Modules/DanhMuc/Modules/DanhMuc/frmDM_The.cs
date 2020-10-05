using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Collections.Generic;
using QLBanHang.Properties;
using QLBH.Common.Objects;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_The : frmDM_ListBaseNew
    {
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenTheLoc;
        private QLBH.Core.Form.GtidButton btnLoc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaTheLoc;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_The));
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenTheLoc = new System.Windows.Forms.TextBox();
            this.btnLoc = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaTheLoc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTenTheLoc);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaTheLoc);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa(F8)";
            // 
            // btnDong
            // 
            this.btnDong.Text = "Thoát(ESC)";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Text = "Cập nhật(F2)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(391, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tên thẻ";
            // 
            // txtTenTheLoc
            // 
            this.txtTenTheLoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTheLoc.ForeColor = System.Drawing.Color.Black;
            this.txtTenTheLoc.Location = new System.Drawing.Point(449, 23);
            this.txtTenTheLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenTheLoc.MaxLength = 15;
            this.txtTenTheLoc.Multiline = true;
            this.txtTenTheLoc.Name = "txtTenTheLoc";
            this.txtTenTheLoc.Size = new System.Drawing.Size(345, 24);
            this.txtTenTheLoc.TabIndex = 13;
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.Image = ((System.Drawing.Image)(resources.GetObject("btnLoc.Image")));
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(808, 22);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnLoc.Size = new System.Drawing.Size(95, 25);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Lọc(F9)";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mã thẻ";
            // 
            // txtMaTheLoc
            // 
            this.txtMaTheLoc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTheLoc.ForeColor = System.Drawing.Color.Black;
            this.txtMaTheLoc.Location = new System.Drawing.Point(66, 25);
            this.txtMaTheLoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaTheLoc.MaxLength = 15;
            this.txtMaTheLoc.Name = "txtMaTheLoc";
            this.txtMaTheLoc.Size = new System.Drawing.Size(291, 22);
            this.txtMaTheLoc.TabIndex = 9;
            // 
            // frmDM_The
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_The";
            this.Text = "Danh mục loại thẻ";
            this.OnThemMoi += new System.EventHandler(this.frmDM_The_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_The_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_The_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_The_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_The_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_The()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC LOẠI THẺ";
            SyncProvider = DmLoaitheKhachHangProvider.Instance;
            LoadSync();
        }

        #region Action
        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DmLoaitheKhachHangProvider.GetListDmLoaiTheInfo();
            btnLoc.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DmLoaitheKhachHangProvider.Delete(new DMLoaiTheKhachHangInfo { IdLoaiThe = Oid });
            MessageBox.Show("Xóa thành công bản ghi !");
            LoadData();
            SetControl(false);
        }
        #endregion
        #endregion

        private void btnLoc_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DmLoaitheKhachHangProvider.Search(new DMLoaiTheKhachHangInfo { TenThe = txtTenTheLoc.Text.Trim(), MaThe = txtMaTheLoc.Text.Trim() });
        }

        void frmDM_The_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = ((DMLoaiTheKhachHangLoadInfo)dgvDanhSachMatHang.GetFocusedRow()).IdLoaiThe;
        }

        void frmDM_The_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid != 0)
            {
                isAdd = false;
                frmChiTiet_The frm = new frmChiTiet_The(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_The_OnCapNhat(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_The frm = new frmChiTiet_The(this);
            frm.ShowDialog();
        }

        private void frmDM_The_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_The frm = new frmChiTiet_The(this);
            frm.ShowDialog();
        }

        private void frmDM_The_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }
        
    }
}
