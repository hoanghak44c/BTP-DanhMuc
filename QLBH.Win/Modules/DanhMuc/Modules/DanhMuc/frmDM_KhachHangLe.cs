using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

// <Remarks>
// form frmDM_KhachHangLe
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 26/05/2012
// Ngày sửa cuối:
// </remarks>
//todo: @HanhBD frmDM_KhachHangLe

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_KhachHangLe : frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btnFilter;
        private System.Windows.Forms.Label label7;
        private QLBH.Core.Form.GtidTextBox txtFilterSoCMND;
        private System.Windows.Forms.Label label6;
        private QLBH.Core.Form.GtidTextBox txtFilterMaRieng;
    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_KhachHangLe));
            this.btnFilter = new QLBH.Core.Form.GtidButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFilterSoCMND = new QLBH.Core.Form.GtidTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFilterMaRieng = new QLBH.Core.Form.GtidTextBox();
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
            this.groupBox1.Controls.Add(this.txtFilterSoCMND);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFilterMaRieng);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách khách hàng lẻ";
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
            this.btnFilter.Location = new System.Drawing.Point(808, 25);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnFilter.Size = new System.Drawing.Size(95, 25);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Lọc(F9)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mã Riêng";
            // 
            // txtFilterSoCMND
            // 
            this.txtFilterSoCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterSoCMND.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterSoCMND.ForeColor = System.Drawing.Color.Black;
            this.txtFilterSoCMND.Location = new System.Drawing.Point(462, 28);
            this.txtFilterSoCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterSoCMND.MaxLength = 150;
            this.txtFilterSoCMND.Name = "txtFilterSoCMND";
            this.txtFilterSoCMND.Size = new System.Drawing.Size(330, 22);
            this.txtFilterSoCMND.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(390, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Số CMND";
            // 
            // txtFilterMaRieng
            // 
            this.txtFilterMaRieng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterMaRieng.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterMaRieng.ForeColor = System.Drawing.Color.Black;
            this.txtFilterMaRieng.Location = new System.Drawing.Point(87, 28);
            this.txtFilterMaRieng.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterMaRieng.MaxLength = 15;
            this.txtFilterMaRieng.Name = "txtFilterMaRieng";
            this.txtFilterMaRieng.Size = new System.Drawing.Size(271, 22);
            this.txtFilterMaRieng.TabIndex = 12;
            // 
            // frmDM_KhachHangLe
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_KhachHangLe";
            this.Text = "Danh mục khách hàng lẻ";
            this.OnThemMoi += new System.EventHandler(this.frmDM_KhachHangLe_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_KhachHangLe_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_KhachHangLe_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_KhachHangLe_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_KhachHangLe_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_KhachHangLe()
        {
            //lblTieuDe.Text = "DANH MỤC KHÁCH HÀNG LẺ";
            InitializeComponent();
        }

        #region Action
        protected override void LoadData()
        {
            grcBase.DataSource = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
            btnFilter.Text = Resources.btnSearch;
        }
        private void Delete()
        {
            DmDoiTuongProvider.Delete(new DMDoiTuongInfo { IdDoiTuong = Oid });

            MessageBox.Show("Xóa thành công !");
            LoadData();
            SetControl(false);
        }

        #region Event
        private void frmDM_KhachHangLe_OnCapNhat(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_KhachHangLe frm = new frmChiTiet_KhachHangLe(this);
            frm.ShowDialog();
        }

        void frmDM_KhachHangLe_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMDoiTuongInfo)dgvDanhSachMatHang.GetFocusedRow()).IdDoiTuong.ToString());
        }

        private void frmDM_KhachHangLe_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_KhachHangLe frm = new frmChiTiet_KhachHangLe(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_KhachHangLe_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_KhachHangLe frm = new frmChiTiet_KhachHangLe(this);
            frm.ShowDialog();
        }

        private void frmDM_KhachHangLe_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DmDoiTuongProvider.SearchRieng(new DMDoiTuongInfo { MaRieng = txtFilterMaRieng.Text.Trim(), SoCMND = txtFilterSoCMND.Text.Trim() });
        }
        #endregion

        #endregion

    }
} 
