using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Properties;

// <Remarks>
// form frmDM_QuyenHoaDon
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 14/04/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frmDM_QuyenHoaDon
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_QuyenHoaDon:frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btnTimKiem;
        private QLBH.Core.Form.GtidTextBox txtFilterKyHieuDau;
        private System.Windows.Forms.Label label12;
        private QLBH.Core.Form.GtidTextBox txtFilterKyHieu;
        private System.Windows.Forms.Label label13;
        public string kyhieuhoadon = "";
        public string kytudau = "";

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_QuyenHoaDon));
            this.btnTimKiem = new QLBH.Core.Form.GtidButton();
            this.txtFilterKyHieuDau = new QLBH.Core.Form.GtidTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFilterKyHieu = new QLBH.Core.Form.GtidTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.txtFilterKyHieuDau);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtFilterKyHieu);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách quyển hóa đơn";
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
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(808, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtFilterKyHieuDau
            // 
            this.txtFilterKyHieuDau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterKyHieuDau.Location = new System.Drawing.Point(461, 27);
            this.txtFilterKyHieuDau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterKyHieuDau.Name = "txtFilterKyHieuDau";
            this.txtFilterKyHieuDau.Size = new System.Drawing.Size(330, 22);
            this.txtFilterKyHieuDau.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "Ký hiệu đầu";
            // 
            // txtFilterKyHieu
            // 
            this.txtFilterKyHieu.Location = new System.Drawing.Point(73, 27);
            this.txtFilterKyHieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterKyHieu.Name = "txtFilterKyHieu";
            this.txtFilterKyHieu.Size = new System.Drawing.Size(289, 22);
            this.txtFilterKyHieu.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 3;
            this.label13.Text = "Ký hiệu";
            // 
            // frmDM_QuyenHoaDon
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_QuyenHoaDon";
            this.Text = "Danh mục hóa đơn";
            this.OnThemMoi += new System.EventHandler(this.frmDM_QuyenHoaDon_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_QuyenHoaDon_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_QuyenHoaDon_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_QuyenHoaDon_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_QuyenHoaDon_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_QuyenHoaDon()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC QUYỂN HÓA ĐƠN";
        }

        #region Action

        #region SetControl
        public void SetControl(bool var)
        {
            btnXoa.Enabled = var;
            btnCapNhat.Enabled = var;
        }
        #endregion

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMQuyenHoaDonDataProvider.GetListQuyenHoaDonInfor();
            btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DMQuyenHoaDonDataProvider.Delete(new DMQuyenHoaDonInfor{KyHieuHoaDon = kyhieuhoadon,KyTuDauSerie = kytudau});
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion

        private void frmDM_QuyenHoaDon_OnCapNhat(object sender, EventArgs e)
        {
            if (kyhieuhoadon != "")
            {
                isAdd = false;
                frmChiTiet_QuyenHoaDon frm = new frmChiTiet_QuyenHoaDon(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_QuyenHoaDon_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_QuyenHoaDon frm = new frmChiTiet_QuyenHoaDon(this);
            frm.ShowDialog();
        }

        private void frmDM_QuyenHoaDon_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMQuyenHoaDonDataProvider.Search(new DMQuyenHoaDonInfor{KyHieuHoaDon = txtFilterKyHieu.Text.Trim(),KyTuDauSerie = txtFilterKyHieuDau.Text.Trim()});
        }

        void frmDM_QuyenHoaDon_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            SetControl(true);
            kyhieuhoadon = ((DMQuyenHoaDonInfor)dgvDanhSachMatHang.GetFocusedRow()).KyHieuHoaDon;
            kytudau = ((DMQuyenHoaDonInfor)dgvDanhSachMatHang.GetFocusedRow()).KyTuDauSerie;
        }

        private void frmDM_QuyenHoaDon_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (kyhieuhoadon != "")
            {
                isAdd = false;
                frmChiTiet_QuyenHoaDon frm = new frmChiTiet_QuyenHoaDon(this);
                frm.ShowDialog();
            }
        }

       
    }
}
 