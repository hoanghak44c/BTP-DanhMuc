﻿using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

// <Remarks>
// form frmDM_DonViTinh
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 24/04/2012
// Ngày sửa cuối:
// </remarks>
//todo: @HanhBD frmDM_DM_DonViTinh

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_DonViTinh : frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btnTimKiem;
        private QLBH.Core.Form.GtidTextBox txtTimKiemTen;
        private QLBH.Core.Form.GtidTextBox txtTimKiemMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    
        public frmDM_DonViTinh()
        {
            //lblTieuDe.Text = "DANH MỤC ĐƠN VỊ TÍNH";
            InitializeComponent();
            SyncProvider = DmDonViTinhProvider.Instance;
            LoadSync();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_DonViTinh));
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
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách đơn vị tính";
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
            this.btnTimKiem.Location = new System.Drawing.Point(808, 21);
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
            this.txtTimKiemTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemTen.Location = new System.Drawing.Point(474, 24);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(320, 22);
            this.txtTimKiemTen.TabIndex = 18;
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemMa.Location = new System.Drawing.Point(106, 24);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Size = new System.Drawing.Size(262, 22);
            this.txtTimKiemMa.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(374, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tên đơn vị tính";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã đơn vị tính";
            // 
            // frmDM_DonViTinh
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_DonViTinh";
            this.Text = "Danh mục đơn vị tính";
            this.OnThemMoi += new System.EventHandler(this.frmDM_DonViTinh_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_DonViTinh_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_DonViTinh_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_DonViTinh_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_DonViTinh_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DmDonViTinhProvider.Instance.GetListDonViTinhInfo();
            btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (DmDonViTinhProvider.Instance.IsUsed(new DMDonViTinhInfor { IdDonViTinh = Oid }))
            {
                throw new InvalidOperationException("Mã đơn vị tính đang được sử dụng!");
            }
            DmDonViTinhProvider.Instance.Delete(new DMDonViTinhInfor { IdDonViTinh = Oid });
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion
        #region Event
        private void frmDM_DonViTinh_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_DonViTinh frm = new frmChiTiet_DonViTinh(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_DonViTinh_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_DonViTinh frm = new frmChiTiet_DonViTinh(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_DonViTinh_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_DonViTinh frm = new frmChiTiet_DonViTinh(this);
            frm.ShowDialog();
        }

        private void frmDM_DonViTinh_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        void frmDM_DonViTinh_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMDonViTinhInfor)dgvDanhSachMatHang.GetFocusedRow()).IdDonViTinh.ToString());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DmDonViTinhProvider.Instance.Search(new DMDonViTinhInfor { KyHieu = txtTimKiemMa.Text, TenDonViTinh = txtTimKiemTen.Text });
        }
        #endregion

    }
}