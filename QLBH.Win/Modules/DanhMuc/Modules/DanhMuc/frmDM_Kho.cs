using System;
using System.Collections.Generic;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;


namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_Kho : frmDM_ListBaseNew
    {

        private QLBH.Core.Form.GtidButton btnFilter;
        private System.Windows.Forms.Label label2;
        private QLBH.Core.Form.GtidTextBox txtFilterTenKho;
        private System.Windows.Forms.Label label1;
        private QLBH.Core.Form.GtidTextBox txtFilterMaKho;
        private DMKhoInfo dm = new DMKhoInfo();

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_Kho));
            this.btnFilter = new QLBH.Core.Form.GtidButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterTenKho = new QLBH.Core.Form.GtidTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilterMaKho = new QLBH.Core.Form.GtidTextBox();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFilterTenKho);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFilterMaKho);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách kho";
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
            this.btnFilter.TabIndex = 9;
            this.btnFilter.Text = "Lọc(F9)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(351, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên kho";
            // 
            // txtFilterTenKho
            // 
            this.txtFilterTenKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTenKho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterTenKho.Location = new System.Drawing.Point(412, 28);
            this.txtFilterTenKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterTenKho.MaxLength = 150;
            this.txtFilterTenKho.Name = "txtFilterTenKho";
            this.txtFilterTenKho.Size = new System.Drawing.Size(370, 22);
            this.txtFilterTenKho.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã kho";
            // 
            // txtFilterMaKho
            // 
            this.txtFilterMaKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFilterMaKho.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterMaKho.Location = new System.Drawing.Point(67, 28);
            this.txtFilterMaKho.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterMaKho.MaxLength = 15;
            this.txtFilterMaKho.Name = "txtFilterMaKho";
            this.txtFilterMaKho.Size = new System.Drawing.Size(276, 22);
            this.txtFilterMaKho.TabIndex = 7;
            // 
            // frmDM_Kho
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_Kho";
            this.Text = "Danh mục kho hàng";
            this.OnGridHeaderDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.frmDM_Kho_OnGridHeaderDoubleClick);
            this.OnThemMoi += new System.EventHandler(this.frmDM_Kho_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_Kho_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_Kho_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_Kho_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_Kho_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_Kho()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC KHO HÀNG";
            SyncProvider = DMKhoDataProvider.Instance;
            LoadSync();
        }

        #region Action
        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMKhoDataProvider.GetListDMKhoInfo();
            btnFilter.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (DMKhoDataProvider.Instance.GetListNhanVienCBOInfo(Oid).Count > 0) throw new Exception("Kho này đang được sử dụng, không thể xóa được");
            DMKhoDataProvider.Delete(new DMKhoInfo { IdKho = Oid });
            LoadData();
            SetControl(false);
        }
        #endregion

       #endregion

        private void frmDM_Kho_OnCapNhat(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_Kho frm = new frmChiTiet_Kho(this);
            frm.ShowDialog();
        }

        private void frmDM_Kho_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_Kho frm = new frmChiTiet_Kho(this);
            frm.ShowDialog();
        }

        private void frmDM_Kho_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMKhoDataProvider.Search(new DMKhoGridLoadInfo { MaKho = txtFilterMaKho.Text.Trim(), TenKho = txtFilterTenKho.Text.Trim() });
        }

        void frmDM_Kho_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = ((DMKhoGridLoadInfo)dgvDanhSachMatHang.GetFocusedRow()).IdKho;
        }

        private void frmDM_Kho_OnGridDoubleClick(object sender, EventArgs e)
        {
            if(Oid == 0) return;
            isAdd = false;
            frmChiTiet_Kho frm = new frmChiTiet_Kho(this);
            frm.ShowDialog();
        }

        void frmDM_Kho_OnGridHeaderDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            return;
        }

    }
}
