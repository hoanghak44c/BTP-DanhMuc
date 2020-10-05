using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Properties;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_BangKeThue : frmDM_ListBaseNew
    {
        private QLBH.Core.Form.GtidButton btnTimKiem;
        private QLBH.Core.Form.GtidTextBox txtTimKiemTen;
        private QLBH.Core.Form.GtidTextBox txtTimKiemMa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGhiChu;
        private System.Windows.Forms.Label label3;
    
        public frmDM_BangKeThue()
        {
            InitializeComponent();
            SyncProvider = DMBangKeThueDataProvider.Instance;
            LoadSync();
        }
        protected override void LoadData()
        {
            grcBase.DataSource = DMBangKeThueDataProvider.Instance.GetListBangKeThueInfo();
            btnTimKiem.Text = Resources.btnSearch;
        }
        private void Delete()
        {
            DMBangKeThueDataProvider.Instance.Delete(new DMBangKeThueInfo() { Id = Oid });
            LoadData();
            SetControl(false);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_BangKeThue));
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
            this.btnTimKiem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(808, 24);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnTimKiem.Size = new System.Drawing.Size(95, 25);
            this.btnTimKiem.TabIndex = 29;
            this.btnTimKiem.Text = "Lọc(F9)";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiemTen
            // 
            this.txtTimKiemTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiemTen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemTen.Location = new System.Drawing.Point(462, 28);
            this.txtTimKiemTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemTen.Name = "txtTimKiemTen";
            this.txtTimKiemTen.Size = new System.Drawing.Size(325, 22);
            this.txtTimKiemTen.TabIndex = 28;
            // 
            // txtTimKiemMa
            // 
            this.txtTimKiemMa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiemMa.Location = new System.Drawing.Point(90, 28);
            this.txtTimKiemMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTimKiemMa.Name = "txtTimKiemMa";
            this.txtTimKiemMa.Size = new System.Drawing.Size(262, 22);
            this.txtTimKiemMa.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(380, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tên bảng kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(14, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã bảng kê";
            // 
            // frmDM_BangKeThue
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 686);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDM_BangKeThue";
            this.Text = "Danh mục bảng kê thuế";
            this.OnThemMoi += new System.EventHandler(this.frmDM_BangKeThue_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_BangKeThue_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_BangKeThue_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_BangKeThue_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_BangKeThue_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        private void frmDM_BangKeThue_OnCapNhat(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_BangKeThue frm = new frmChiTiet_BangKeThue(this);
                frm.ShowDialog();
            }
        }

        void frmDM_BangKeThue_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = Convert.ToInt32(((DMBangKeThueInfo)dgvDanhSachMatHang.GetFocusedRow()).Id.ToString());
        }

        private void frmDM_BangKeThue_OnGridDoubleClick(object sender, EventArgs e)
        {
            if (Oid > 0)
            {
                isAdd = false;
                frmChiTiet_BangKeThue frm = new frmChiTiet_BangKeThue(this);
                frm.ShowDialog();
            }
        }

        private void frmDM_BangKeThue_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_BangKeThue frm = new frmChiTiet_BangKeThue(this);
            frm.ShowDialog();
        }

        private void frmDM_BangKeThue_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            grcBase.DataSource = DMBangKeThueDataProvider.Instance.Search(new DMBangKeThueInfo{KyHieu = txtTimKiemMa.Text,Ten = txtTimKiemTen.Text});
        }
    }
}
