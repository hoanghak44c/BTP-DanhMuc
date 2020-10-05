using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_LoaiDoiTuong : frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btnTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoaiDoiTuongSearch;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_LoaiDoiTuong));
            this.btnTimKiem = new QLBH.Core.Form.GtidButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLoaiDoiTuongSearch = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.txtTenLoaiDoiTuongSearch);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnTimKiem.Location = new System.Drawing.Point(808, 25);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 23;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên loại đối tượng";
            // 
            // txtTenLoaiDoiTuongSearch
            // 
            this.txtTenLoaiDoiTuongSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoaiDoiTuongSearch.Location = new System.Drawing.Point(127, 25);
            this.txtTenLoaiDoiTuongSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoaiDoiTuongSearch.Name = "txtTenLoaiDoiTuongSearch";
            this.txtTenLoaiDoiTuongSearch.Size = new System.Drawing.Size(670, 22);
            this.txtTenLoaiDoiTuongSearch.TabIndex = 24;
            // 
            // frmDM_LoaiDoiTuong
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDM_LoaiDoiTuong";
            this.Text = "Danh mục loại đối tượng";
            this.OnThemMoi += new System.EventHandler(this.frmDM_LoaiDoiTuong_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_LoaiDoiTuong_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_LoaiDoiTuong_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_LoaiDoiTuong_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_LoaiDoiTuong_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_LoaiDoiTuong()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC LOẠI DỊCH VỤ";
            SyncProvider = DmLoaiDoiTuongDataProvider.Instance;
            LoadSync();
        }
        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DmLoaiDoiTuongDataProvider.GetListLoaiDoiTuongInfor();
            btnTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DmLoaiDoiTuongDataProvider.Delete(new DmLoaiDoiTuongInfor { IdLoaiDT = Oid });
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion
        #region Event
        private void frmDM_LoaiDoiTuong_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiDoiTuong frm = new frmChiTiet_LoaiDoiTuong(this);
                frm.ShowDialog();
            }
        }

        void frmDM_LoaiDoiTuong_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DmLoaiDoiTuongInfor)dgvDanhSachMatHang.GetFocusedRow()).IdLoaiDT.ToString());
        }

        private void frmDM_LoaiDoiTuong_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiDoiTuong frm = new frmChiTiet_LoaiDoiTuong(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_LoaiDoiTuong_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_LoaiDoiTuong frm = new frmChiTiet_LoaiDoiTuong(this);
            frm.ShowDialog();
        }

        private void frmDM_LoaiDoiTuong_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DmLoaiDoiTuongDataProvider.Search(new DmLoaiDoiTuongInfor() { TenLoaiDT = txtTenLoaiDoiTuongSearch.Text.Trim() });
        }
        #endregion
    }
}
