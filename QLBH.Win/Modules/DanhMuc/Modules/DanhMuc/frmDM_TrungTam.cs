using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Properties;
using QLBH.Common;

// <Remarks>
// form frm_DM_TrungTam
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 02/04/2012
// Ngày sửa cuối:
// </remarks>
//todo:@HanhBD frm_DM_TrungTam
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_TrungTam: frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btnTimKiem;
        private QLBH.Core.Form.GtidTextBox txtTimKiemTen;
        private QLBH.Core.Form.GtidTextBox txtTimKiemMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_TrungTam));
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
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách trung tâm";
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
            this.grcBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.grcBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcBase.Location = new System.Drawing.Point(3, 19);
            this.grcBase.Size = new System.Drawing.Size(905, 496);
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
            this.btnTimKiem.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Appearance.Options.UseFont = true;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(808, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 9;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemTen.Location = new System.Drawing.Point(466, 27);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(325, 22);
            this.txtTimKiemTen.TabIndex = 8;
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemMa.Location = new System.Drawing.Point(103, 27);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Size = new System.Drawing.Size(262, 22);
            this.txtTimKiemMa.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(373, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên trung tâm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(13, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã trung tâm";
            // 
            // frmDM_TrungTam
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_TrungTam";
            this.Text = "Danh mục trung tâm";
            this.OnThemMoi += new System.EventHandler(this.frmDM_TrungTam_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_TrungTam_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_TrungTam_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_TrungTam_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_TrungTam_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_TrungTam()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC TRUNG TÂM";
            SyncProvider = DMTrungTamDataProvider.Instance;
            LoadSync();
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMTrungTamDataProvider.GetListTrungTamInfo();
            btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if(DMKhoDataProvider.GetListKhoByTrungTamPairInfo(Oid).Count > 0) throw new Exception("Trung tâm này đang được sử dụng nên không thể xóa.");
            DMTrungTamDataProvider.Delete(new DMTrungTamInfor { IdTrungTam = Oid });
            LoadData();
            SetControl(false);
        }
        #endregion
        #endregion

        private void frmDM_TrungTam_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_TrungTam frm = new frmChiTiet_TrungTam(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_TrungTam_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_TrungTam frm = new frmChiTiet_TrungTam(this);
            frm.ShowDialog();
        }

        private void frmDM_TrungTam_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMTrungTamDataProvider.Search(new DMTrungTamInfor { MaTrungTam = txtTimKiemMa.Text.Trim(), TenTrungTam = txtTimKiemTen.Text.Trim().ToUpper() });
            //grcBase.DataSource = DMTrungTamDataProvider.Search(txtTimKiemTen.Text.Trim(), txtTimKiemMa.Text.Trim());
        }

        void frmDM_TrungTam_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_TrungTam frm = new frmChiTiet_TrungTam(this);
                frm.ShowDialog();
            }
        }

        void frmDM_TrungTam_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = ((DMTrungTamInfor)dgvDanhSachMatHang.GetFocusedRow()).IdTrungTam;
        }
    }
}
