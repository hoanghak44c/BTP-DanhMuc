using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;


// <Remarks>
// form frmDM_LoaiDichVu
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 08/04/2012
// Ngày sửa cuối:
// </remarks>
//todo : @HanhBD frmDM_LoaiDichVu
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_LoaiDichVu:frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoaiDichVuSearch;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_LoaiDichVu));
            this.btnTimKiem = new QLBH.Core.Form.GtidButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLoaiDichVuSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenLoaiDichVuSearch);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách loại dịch vụ";
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
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(808, 20);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên loại dịch vụ";
            // 
            // txtTenLoaiDichVuSearch
            // 
            this.txtTenLoaiDichVuSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoaiDichVuSearch.Location = new System.Drawing.Point(118, 22);
            this.txtTenLoaiDichVuSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoaiDichVuSearch.Name = "txtTenLoaiDichVuSearch";
            this.txtTenLoaiDichVuSearch.Size = new System.Drawing.Size(670, 23);
            this.txtTenLoaiDichVuSearch.TabIndex = 21;
            // 
            // frmDM_LoaiDichVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_LoaiDichVu";
            this.OnThemMoi += new System.EventHandler(this.frmDM_LoaiDichVu_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_LoaiDichVu_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_LoaiDichVu_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_LoaiDichVu_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_LoaiDichVu_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_LoaiDichVu()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC LOẠI DỊCH VỤ";
            SyncProvider = DMLoaiDichVuDataProvider.Instance;
            LoadSync();
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMLoaiDichVuDataProvider.GetListDichVuInfo();
            btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DMLoaiDichVuDataProvider.Delete(new DMLoaiDichVuInfor{IdLoaiDichVu = Oid});
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion

        void frmDM_LoaiDichVu_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMLoaiDichVuInfor)dgvDanhSachMatHang.GetFocusedRow()).IdLoaiDichVu.ToString());
        }

        void frmDM_LoaiDichVu_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiDichVu frm = new frmChiTiet_LoaiDichVu(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_LoaiDichVu_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiDichVu frm = new frmChiTiet_LoaiDichVu(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_LoaiDichVu_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_LoaiDichVu frm = new frmChiTiet_LoaiDichVu(this);
            frm.ShowDialog();
        }

        private void frmDM_LoaiDichVu_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMLoaiDichVuDataProvider.Search(new DMLoaiDichVuInfor{TenDichVu = txtTenLoaiDichVuSearch.Text.Trim()});
        }
    }
}
