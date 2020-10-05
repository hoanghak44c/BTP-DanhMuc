using System;
using System.Data;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;
using QLBH.Common;
using QLBH.Core.Data;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_KhachHang : frmDM_ListBaseNew
    {
        List<DMDoiTuongInfo> listDoiTuong;
        public string strMaKhachHang = "";
        private QLBH.Core.Form.GtidButton btnFilter;
        private System.Windows.Forms.Label label7;
        private QLBH.Core.Form.GtidTextBox txtFilterTen;
        private System.Windows.Forms.Label label6;
        private QLBH.Core.Form.GtidTextBox txtFilterMa;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_KhachHang));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFilter = new QLBH.Core.Form.GtidButton();
            this.txtFilterTen = new QLBH.Core.Form.GtidTextBox();
            this.txtFilterMa = new QLBH.Core.Form.GtidTextBox();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtFilterTen);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFilterMa);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách khách hàng";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(387, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khách hàng";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(808, 24);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnFilter.Size = new System.Drawing.Size(95, 25);
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Lọc(F9)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFilterTen
            // 
            this.txtFilterTen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterTen.ForeColor = System.Drawing.Color.Black;
            this.txtFilterTen.Location = new System.Drawing.Point(486, 25);
            this.txtFilterTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterTen.MaxLength = 150;
            this.txtFilterTen.Name = "txtFilterTen";
            this.txtFilterTen.Size = new System.Drawing.Size(310, 22);
            this.txtFilterTen.TabIndex = 8;
            // 
            // txtFilterMa
            // 
            this.txtFilterMa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterMa.ForeColor = System.Drawing.Color.Black;
            this.txtFilterMa.Location = new System.Drawing.Point(110, 25);
            this.txtFilterMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterMa.MaxLength = 15;
            this.txtFilterMa.Name = "txtFilterMa";
            this.txtFilterMa.Size = new System.Drawing.Size(271, 22);
            this.txtFilterMa.TabIndex = 7;
            // 
            // frmDM_KhachHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_KhachHang";
            this.Text = "Danh mục khách hàng";
            this.OnThemMoi += new System.EventHandler(this.frmDM_KhachHang_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_KhachHang_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_KhachHang_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_KhachHang_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_KhachHang_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_KhachHang()
        {
            InitializeComponent();
            SyncProvider = DmDoiTuongProvider.Instance;
            LoadSync();
        }
        #region Action
        protected override void LoadData()
        {
            grcBase.DataSource = DmDoiTuongProvider.GetListDmDoiTuongInfo();
            btnFilter.Text = Resources.btnSearch;
        }

        private bool Search(DMDoiTuongInfo dmKHInfor)
        {
            return (txtFilterMa.Text.Trim() == String.Empty || (txtFilterMa.Text.Trim() != String.Empty &&
                    dmKHInfor.MaDoiTuong.ToLower().Contains(txtFilterMa.Text.Trim().ToLower())))
                   && (txtFilterTen.Text.Trim() == String.Empty || (txtFilterTen.Text.Trim() != String.Empty &&
                       dmKHInfor.TenDoiTuong.ToLower().Contains(txtFilterTen.Text.Trim().ToLower())));

        }

        private void Delete()
        {
            DmDoiTuongProvider.Delete(new DMDoiTuongInfo { IdDoiTuong = Oid });

            MessageBox.Show("Xóa thành công !");
            LoadData();
            SetControl(false);
        }

        #endregion

        private void frmDM_KhachHang_OnCapNhat(object sender, EventArgs e)
        {
            isAdd = false;
            //frmChiTiet_KhachHang frm = new frmChiTiet_KhachHang(this);
            //frm.ShowDialog();
            frmChiTiet_DoiTuong frmChiTietDoiTuong = new frmChiTiet_DoiTuong(Oid);
            frmChiTietDoiTuong.ShowDialog();
            if (frmChiTietDoiTuong.DialogResult == DialogResult.OK) ReLoad();
        }

        private void frmDM_KhachHang_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_DoiTuong frmChiTietDoiTuong = new frmChiTiet_DoiTuong();
            frmChiTietDoiTuong.ShowDialog();
            if (frmChiTietDoiTuong .DialogResult== DialogResult.OK) ReLoad();
        }

        private void frmDM_KhachHang_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            listDoiTuong = DmDoiTuongProvider.Search(new DMDoiTuongInfo { MaDoiTuong = txtFilterMa.Text.Trim(), TenDoiTuong = txtFilterTen.Text.Trim() });
            grcBase.DataSource = listDoiTuong;
        }

        void frmDM_KhachHang_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMDoiTuongInfo)dgvDanhSachMatHang.GetFocusedRow()).IdDoiTuong.ToString());
        }

        private void frmDM_KhachHang_OnGridDoubleClick(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_DoiTuong frmChiTietDoiTuong = new frmChiTiet_DoiTuong(Oid);
            if (frmChiTietDoiTuong.ShowDialog() == DialogResult.OK) ReLoad();
        }
    }
}
