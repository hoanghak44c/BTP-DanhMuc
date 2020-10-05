using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_HangHoa : frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidSimpleButton btnFilter;
        private Label label8;
        private QLBH.Core.Form.GtidTextBox txtFilterMa;
        private QLBH.Core.Form.GtidTextBox txtFilterTen;
        private Label label9;
        List<DMSanPhamInfo> liSanPham = new List<DMSanPhamInfo>();
        DMSanPhamInfo dm = new DMSanPhamInfo();

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_HangHoa));
            this.btnFilter = new QLBH.Core.Form.GtidSimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilterMa = new QLBH.Core.Form.GtidTextBox();
            this.txtFilterTen = new QLBH.Core.Form.GtidTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFilterMa);
            this.groupBox1.Controls.Add(this.txtFilterTen);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(917, 81);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Location = new System.Drawing.Point(10, 426);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Location = new System.Drawing.Point(9, 98);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpThongTin.Size = new System.Drawing.Size(917, 328);
            // 
            // grcBase
            // 
            this.grcBase.Location = new System.Drawing.Point(8, 19);
            this.grcBase.Size = new System.Drawing.Size(897, 301);
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
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(809, 28);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnFilter.Size = new System.Drawing.Size(95, 25);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "Lọc(F9)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã mặt hàng";
            // 
            // txtFilterMa
            // 
            this.txtFilterMa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterMa.Location = new System.Drawing.Point(112, 31);
            this.txtFilterMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterMa.MaxLength = 50;
            this.txtFilterMa.Name = "txtFilterMa";
            this.txtFilterMa.Size = new System.Drawing.Size(272, 22);
            this.txtFilterMa.TabIndex = 10;
            // 
            // txtFilterTen
            // 
            this.txtFilterTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterTen.Location = new System.Drawing.Point(489, 30);
            this.txtFilterTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterTen.MaxLength = 1000;
            this.txtFilterTen.Name = "txtFilterTen";
            this.txtFilterTen.Size = new System.Drawing.Size(310, 22);
            this.txtFilterTen.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(396, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên mặt hàng";
            // 
            // frmDM_HangHoa
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(943, 512);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_HangHoa";
            this.Load += new System.EventHandler(this.frmDM_HangHoa_Load);
            this.OnThemMoi += new System.EventHandler(this.frmDM_HangHoa_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_HangHoa_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_HangHoa_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_HangHoa_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_HangHoa_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_HangHoa()
        {
            //lblTieuDe.Text = "DANH MỤC HÀNG HÓA";
            InitializeComponent();
            SyncProvider = DmSanPhamProvider.Instance;
            LoadSync();
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DmSanPhamProvider.GetListDmSanPhamInfo();
            btnFilter.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DmSanPhamProvider.Delete(new DMSanPhamInfo { IdSanPham = Oid });
            MessageBox.Show("Xóa thành công bản ghi");
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion


        private void btnFilter_Click(object sender, EventArgs e)
        {
            liSanPham.Clear();
            liSanPham = DmSanPhamProvider.Search(new DMSanPhamInfo { MaSanPham = txtFilterMa.Text.Trim(), TenSanPham = txtFilterTen.Text.Trim().ToUpper() });
            grcBase.DataSource = liSanPham;
        }

        private void frmDM_HangHoa_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_MatHang frm = new frmChiTiet_MatHang(this);
            frm.ShowDialog();
        }

        private void frmDM_HangHoa_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void frmDM_HangHoa_OnCapNhat(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_MatHang frm = new frmChiTiet_MatHang(this);
            frm.ShowDialog();
        }

        void frmDM_HangHoa_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMSanPhamInfo)dgvDanhSachMatHang.GetFocusedRow()).IdSanPham.ToString());
        }

        private void frmDM_HangHoa_OnGridDoubleClick(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_MatHang frm = new frmChiTiet_MatHang(this);
            frm.ShowDialog();
        }

        private void frmDM_HangHoa_Load(object sender, EventArgs e)
        {

        }

    }
}
