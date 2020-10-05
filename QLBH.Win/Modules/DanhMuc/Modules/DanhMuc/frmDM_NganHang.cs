﻿using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;


// <Remarks>
// form frmDM_NganHang
// Người tạo: Bùi Đức Hạnh
// Ngày tạo :06/01/2013
// Ngày sửa cuối:
// </remarks>
//todo: @HanhBD Danh mục ngân hàng
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_NganHang : frmDM_ListBaseNew
    {

        private QLBH.Core.Form.GtidButton btnTimKiem;
        private QLBH.Core.Form.GtidTextBox txtTimKiemTen;
        private QLBH.Core.Form.GtidTextBox txtTimKiemMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_NganHang));
            this.btnTimKiem = new QLBH.Core.Form.GtidButton();
            this.txtTimKiemTen = new QLBH.Core.Form.GtidTextBox();
            this.txtTimKiemMa = new QLBH.Core.Form.GtidTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
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
            this.btnTimKiem.Location = new System.Drawing.Point(807, 23);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemTen.Location = new System.Drawing.Point(473, 26);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(320, 22);
            this.txtTimKiemTen.TabIndex = 23;
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemMa.Location = new System.Drawing.Point(105, 26);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Size = new System.Drawing.Size(262, 22);
            this.txtTimKiemMa.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(373, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tên đơn vị tính";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã đơn vị tính";
            // 
            // frmDM_NganHang
            // 
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDM_NganHang";
            this.Text = "Danh mục ngân hàng";
            this.OnThemMoi += new System.EventHandler(this.frmDM_NganHang_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_NganHang_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_NganHang_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_NganHang_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_NganHang_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }
        public frmDM_NganHang()
        {
            InitializeComponent();
            SyncProvider = DMNganHangDataProvider.Instance;
            LoadSync();
        }
        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMNganHangDataProvider.Instance.GetListNganHangInfors();
            //btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (DMNganHangDataProvider.Instance.IsUsed(new DMNganHangInfor() { IdNganHang = Oid }))
            {
                throw new InvalidOperationException("Mã đơn vị tính đang được sử dụng!");
            }
            DMNganHangDataProvider.Instance.Delete(new DMNganHangInfor { IdNganHang = Oid });
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion
        #region Events
        private void frmDM_NganHang_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_NganHang frm = new frmChiTiet_NganHang(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_NganHang_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMNganHangInfor)dgvDanhSachMatHang.GetFocusedRow()).IdNganHang.ToString());
        }

        private void frmDM_NganHang_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_NganHang frm = new frmChiTiet_NganHang(this);
                frm.ShowDialog();
            }
        }
        private void frmDM_NganHang_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_NganHang frm = new frmChiTiet_NganHang(this);
            frm.ShowDialog();
        }

        private void frmDM_NganHang_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMNganHangDataProvider.Instance.Search(new DMNganHangInfor() { MaNganHang = txtTimKiemMa.Text, TenNganHang = txtTimKiemTen.Text });
        }
        #endregion
    }
}
