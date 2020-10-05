using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

// <Remarks>
// form frmDM_ListDM
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 13/04/2012
// Ngày sửa cuối:
// </remarks>
//todo : @HanhBD frmDM_ListDM
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_ListDM :frmDM_ListBaseNew
    {

        private QLBH.Core.Form.GtidButton btnTimKiem;
        private QLBH.Core.Form.GtidTextBox txtTimKiemTen;
        private System.Windows.Forms.Label lblTenDanhMuc;
        public string TblName = "";
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_ListDM));
            this.btnTimKiem = new QLBH.Core.Form.GtidButton();
            this.txtTimKiemTen = new QLBH.Core.Form.GtidTextBox();
            this.lblTenDanhMuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimKiemTen);
            this.groupBox1.Controls.Add(this.lblTenDanhMuc);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách danh mục";
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
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(551, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemTen.Location = new System.Drawing.Point(117, 26);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(408, 22);
            this.txtTimKiemTen.TabIndex = 13;
            // 
            // lblTenDanhMuc
            // 
            this.lblTenDanhMuc.AutoSize = true;
            this.lblTenDanhMuc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTenDanhMuc.Location = new System.Drawing.Point(20, 29);
            this.lblTenDanhMuc.Name = "lblTenDanhMuc";
            this.lblTenDanhMuc.Size = new System.Drawing.Size(90, 16);
            this.lblTenDanhMuc.TabIndex = 11;
            this.lblTenDanhMuc.Text = "Tên danh mục";
            // 
            // frmDM_ListDM
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_ListDM";
            this.Text = "Danh mục ";
            this.OnThemMoi += new System.EventHandler(this.frmDM_ListDM_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_ListDM_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_ListDM_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_ListDM_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_ListDM_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_ListDM()
        {
            //lblTieuDe.Text = "DANH SÁCH DANH MỤC";
            InitializeComponent();
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = KhaiBaoDMDataProvider.GetListKhaiBaoInfo();
            btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            KhaiBaoDMDataProvider.Delete(new DMListInfor { TblName = TblName });
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion

        private void frmDM_ListDM_OnCapNhat(object sender, EventArgs e)
        {
                isAdd = false;
                frmChiTiet_ListDM frm = new frmChiTiet_ListDM(this);
                frm.ShowDialog();

        }

        void frmDM_ListDM_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            TblName = ((DMListInfor)dgvDanhSachMatHang.GetFocusedRow()).TblName;
        }

        private void frmDM_ListDM_OnGridDoubleClick(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_ListDM frm = new frmChiTiet_ListDM(this);
            frm.ShowDialog();
        }

        private void frmDM_ListDM_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_ListDM frm = new frmChiTiet_ListDM(this);
            frm.ShowDialog();
        }

        private void frmDM_ListDM_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource =
                KhaiBaoDMDataProvider.Search(new DMListInfor {Name = txtTimKiemTen.Text.Trim()});
        }
    }
}
