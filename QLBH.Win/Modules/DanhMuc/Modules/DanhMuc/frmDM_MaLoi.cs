using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_MaLoi:frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoiSearch;
        private System.Windows.Forms.TextBox txtMaLoi;
        private System.Windows.Forms.Label label2;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_MaLoi));
            this.btTimKiem = new QLBH.Core.Form.GtidButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenLoiSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaLoi);
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenLoiSearch);
            this.groupBox1.Controls.Add(this.label2);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách mã lỗi";
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
            // btTimKiem
            // 
            this.btTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btTimKiem.Image")));
            this.btTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTimKiem.Location = new System.Drawing.Point(819, 31);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btTimKiem.Size = new System.Drawing.Size(84, 25);
            this.btTimKiem.TabIndex = 20;
            this.btTimKiem.Text = "Lọc(F9)";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tên cấu hình";
            // 
            // txtTenLoiSearch
            // 
            this.txtTenLoiSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenLoiSearch.Location = new System.Drawing.Point(454, 31);
            this.txtTenLoiSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenLoiSearch.Name = "txtTenLoiSearch";
            this.txtTenLoiSearch.Size = new System.Drawing.Size(350, 23);
            this.txtTenLoiSearch.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã lỗi";
            // 
            // txtMaLoi
            // 
            this.txtMaLoi.Location = new System.Drawing.Point(57, 30);
            this.txtMaLoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoi.Name = "txtMaLoi";
            this.txtMaLoi.Size = new System.Drawing.Size(280, 23);
            this.txtMaLoi.TabIndex = 25;
            // 
            // frmDM_MaLoi
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_MaLoi";
            this.Text = "Danh mục mã lỗi";
            this.Load += new System.EventHandler(this.frmDM_MaLoi_Load);
            this.OnThemMoi += new System.EventHandler(this.frmDM_MaLoi_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_MaLoi_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_MaLoi_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_MaLoi_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_MaLoi_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_MaLoi()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC MÃ LỖI";
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMMaLoiDataProvider.GetListMaLoiInfor();
            btTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DMMaLoiDataProvider.Delete(new DMMaLoiInfor{IdMaLoi = Oid});
            LoadData();
            SetControl(false);
        }
        #endregion

        #region LoadLoaiThietBi
        private void LoadLoaiThietBi()
        {
            //cboLoaiItemSearch.DataSource = DMLoaiItemDataProvider.GetListItemInfor();
            //cboLoaiItemSearch.DisplayMember = "TenLoaiItem";
            //cboLoaiItemSearch.ValueMember = "IdLoaiItem";
        }
        #endregion

        #endregion

        void frmDM_MaLoi_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMMaLoiInfor)dgvDanhSachMatHang.GetFocusedRow()).IdMaLoi.ToString());
        }

        void frmDM_MaLoi_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_MaLoi frm = new frmChiTiet_MaLoi(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_MaLoi_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_MaLoi frm = new frmChiTiet_MaLoi(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_MaLoi_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_MaLoi frm = new frmChiTiet_MaLoi(this);
            frm.ShowDialog();
        }

        private void frmDM_MaLoi_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void frmDM_MaLoi_Load(object sender, EventArgs e)
        {
            //LoadLoaiThietBi();
            SetControl(false);
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMMaLoiDataProvider.Search(new DMMaLoiPairInfor{MaLoi = txtMaLoi.Text.Trim(),TenLoi = txtTenLoiSearch.Text.Trim()});
        }
    }
}
