using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

// <Remarks>
// form frmDM_LoaiThuChi
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 17/04/2012
// Ngày sửa cuối:
// </remarks>
//todo :@HanhBD frmDM_LoaiThuChi
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_LoaiThuChi: frmDM_ListBaseNew
    {

        private QLBH.Core.Form.GtidButton btnTimKiem;
        private QLBH.Core.Form.GtidTextBox txtTimKiemTen;
        private QLBH.Core.Form.GtidTextBox txtTimKiemMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_LoaiThuChi));
            this.btnTimKiem = new QLBH.Core.Form.GtidButton();
            this.txtTimKiemTen = new QLBH.Core.Form.GtidTextBox();
            this.txtTimKiemMa = new QLBH.Core.Form.GtidTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtTimKiemTen);
            this.groupBox1.Controls.Add(this.txtTimKiemMa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Size = new System.Drawing.Size(897, 71);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Size = new System.Drawing.Size(906, 63);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Size = new System.Drawing.Size(906, 519);
            this.grpThongTin.Text = "Danh sách loại thu chi";
            // 
            // dgvDanhSachMatHang
            // 
            this.dgvDanhSachMatHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvDanhSachMatHang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvDanhSachMatHang.OptionsBehavior.AutoPopulateColumns = false;
            this.dgvDanhSachMatHang.OptionsBehavior.Editable = false;
            this.dgvDanhSachMatHang.OptionsView.ShowAutoFilterRow = true;
            // 
            // grcBase
            // 
            this.grcBase.Size = new System.Drawing.Size(894, 488);
            // 
            // btnXoa
            // 
            this.btnXoa.Text = "Xóa(F8)";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(799, 19);
            this.btnDong.Text = "Thoát(ESC)";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Text = "Cập nhật(F2)";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(698, 19);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(796, 20);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 19;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemTen.Location = new System.Drawing.Point(471, 23);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(310, 22);
            this.txtTimKiemTen.TabIndex = 18;
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemMa.Location = new System.Drawing.Point(105, 23);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Size = new System.Drawing.Size(262, 22);
            this.txtTimKiemMa.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên loại thu chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã loại thu chi";
            // 
            // frmDM_LoaiThuChi
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(923, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_LoaiThuChi";
            this.Text = "Danh mục thu chi";
            this.OnThemMoi += new System.EventHandler(this.frmDM_LoaiThuChi_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_LoaiThuChi_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_LoaiThuChi_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_LoaiThuChi_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_LoaiThuChi_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_LoaiThuChi()
        {
            //lblTieuDe.Text = "DANH MỤC LOẠI THU CHI";
            InitializeComponent();
            SyncProvider = DMLoaiThuChiDataProvider.Instance;
            LoadSync();
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
            btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DMLoaiThuChiDataProvider.Delete(new DMLoaiThuChiInfor { IdThuChi = Oid });
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion

        #region Event
        private void frmDM_LoaiThuChi_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiThuChi frm = new frmChiTiet_LoaiThuChi(this);
                frm.ShowDialog();
            }
        }

        void frmDM_LoaiThuChi_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMLoaiThuChiInfor)dgvDanhSachMatHang.GetFocusedRow()).IdThuChi.ToString());
        }

        private void frmDM_LoaiThuChi_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiThuChi frm = new frmChiTiet_LoaiThuChi(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_LoaiThuChi_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_LoaiThuChi frm = new frmChiTiet_LoaiThuChi(this);
            frm.ShowDialog();
        }

        private void frmDM_LoaiThuChi_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMLoaiThuChiDataProvider.Search(new DMLoaiThuChiInfor { KyHieu = txtTimKiemMa.Text.Trim(), Ten = txtTimKiemTen.Text.Trim() });

        }
        #endregion
    }
}
