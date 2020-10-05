using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

// <Remarks>
// form frmDM_LoaiItem
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 05/04/2012
// Ngày sửa cuối:
// </remarks>
//todo : @HanhBD frmDM_LoaiItem
namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_LoaiItem:frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoaiItem;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_LoaiItem));
            this.btTimKiem = new QLBH.Core.Form.GtidButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoaiItem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaLoaiItem);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Text = "Danh sách Loại Item";
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
            this.btTimKiem.Location = new System.Drawing.Point(808, 23);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btTimKiem.TabIndex = 20;
            this.btTimKiem.Text = "Lọc(F9)";
            this.btTimKiem.UseVisualStyleBackColor = true;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã loại Item";
            // 
            // txtMaLoaiItem
            // 
            this.txtMaLoaiItem.Location = new System.Drawing.Point(96, 25);
            this.txtMaLoaiItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaLoaiItem.Name = "txtMaLoaiItem";
            this.txtMaLoaiItem.Size = new System.Drawing.Size(700, 23);
            this.txtMaLoaiItem.TabIndex = 21;
            // 
            // frmDM_LoaiItem
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_LoaiItem";
            this.Text = "Danh mục loại Item";
            this.OnThemMoi += new System.EventHandler(this.frmDM_LoaiItem_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_LoaiItem_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_LoaiItem_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_LoaiItem_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_LoaiItem_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_LoaiItem()
        {
            InitializeComponent();
            //lblTieuDe.Text = "DANH MỤC LOẠI ITEM";
            SyncProvider = DMLoaiItemDataProvider.Instance;
            LoadSync();
        }

        #region Action

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DMLoaiItemDataProvider.GetListItemInfor();
            btTimKiem.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DMLoaiItemDataProvider.Delete(new DMLoaiItemInfor{IdLoaiItem = Oid});
            LoadData();
            SetControl(false);
        }
        #endregion

        #endregion

        void frmDM_LoaiItem_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMLoaiItemInfor)dgvDanhSachMatHang.GetFocusedRow()).IdLoaiItem.ToString());
        }

        void frmDM_LoaiItem_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiItem frm = new frmChiTiet_LoaiItem(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_LoaiItem_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_LoaiItem frm = new frmChiTiet_LoaiItem(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_LoaiItem_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_LoaiItem frm = new frmChiTiet_LoaiItem(this);
            frm.ShowDialog();
        }

        private void frmDM_LoaiItem_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMLoaiItemDataProvider.Search(new DMLoaiItemInfor{MaLoaiItem = txtMaLoaiItem.Text.Trim()});
        }
    }
}
