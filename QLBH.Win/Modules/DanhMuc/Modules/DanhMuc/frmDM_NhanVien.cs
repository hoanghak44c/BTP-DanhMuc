using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QLBanHang.Properties;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Providers;
using System.Collections;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc
{
    public class frmDM_NhanVien : frmDM_ListBaseNew
    {
        private System.Windows.Forms.ComboBox cboChucDanhS;
        private System.Windows.Forms.Label label11;
        private QLBH.Core.Form.GtidButton btnFilter;
        private System.Windows.Forms.Label label12;
        private QLBH.Core.Form.GtidTextBox txtFilterTen;
        private System.Windows.Forms.ComboBox cboPhongBanS;
        private System.Windows.Forms.Label label8;
        private QLBH.Core.Form.GtidTextBox txtFilterMa;
        private System.Windows.Forms.Label label7;
    
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_NhanVien));
            this.cboChucDanhS = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnFilter = new QLBH.Core.Form.GtidButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFilterTen = new QLBH.Core.Form.GtidTextBox();
            this.cboPhongBanS = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFilterMa = new QLBH.Core.Form.GtidTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpThucThi.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboChucDanhS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtFilterTen);
            this.groupBox1.Controls.Add(this.cboPhongBanS);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtFilterMa);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(911, 102);
            // 
            // grpThucThi
            // 
            this.grpThucThi.Location = new System.Drawing.Point(6, 390);
            // 
            // grpThongTin
            // 
            this.grpThongTin.Location = new System.Drawing.Point(11, 119);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.grpThongTin.Size = new System.Drawing.Size(911, 264);
            this.grpThongTin.Text = "Danh sách nhân viên";
            // 
            // grcBase
            // 
            this.grcBase.Size = new System.Drawing.Size(897, 232);
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
            // cboChucDanhS
            // 
            this.cboChucDanhS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cboChucDanhS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucDanhS.FormattingEnabled = true;
            this.cboChucDanhS.Location = new System.Drawing.Point(494, 53);
            this.cboChucDanhS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboChucDanhS.Name = "cboChucDanhS";
            this.cboChucDanhS.Size = new System.Drawing.Size(326, 24);
            this.cboChucDanhS.TabIndex = 37;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(418, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Chức danh";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFilter.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Appearance.Options.UseFont = true;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(809, 19);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.ShortCutKey = System.Windows.Forms.Keys.F9;
            this.btnFilter.Size = new System.Drawing.Size(95, 25);
            this.btnFilter.TabIndex = 35;
            this.btnFilter.Text = "Lọc(F9)";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(7, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 16);
            this.label12.TabIndex = 38;
            this.label12.Text = "Phòng ban";
            // 
            // txtFilterTen
            // 
            this.txtFilterTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterTen.Location = new System.Drawing.Point(494, 22);
            this.txtFilterTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterTen.Name = "txtFilterTen";
            this.txtFilterTen.Size = new System.Drawing.Size(310, 22);
            this.txtFilterTen.TabIndex = 34;
            // 
            // cboPhongBanS
            // 
            this.cboPhongBanS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBanS.FormattingEnabled = true;
            this.cboPhongBanS.Location = new System.Drawing.Point(88, 53);
            this.cboPhongBanS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboPhongBanS.Name = "cboPhongBanS";
            this.cboPhongBanS.Size = new System.Drawing.Size(325, 24);
            this.cboPhongBanS.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(418, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Tên";
            // 
            // txtFilterMa
            // 
            this.txtFilterMa.Location = new System.Drawing.Point(89, 22);
            this.txtFilterMa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterMa.Name = "txtFilterMa";
            this.txtFilterMa.Size = new System.Drawing.Size(325, 22);
            this.txtFilterMa.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Mã";
            // 
            // frmDM_NhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.Appearance.Font = new System.Drawing.Font("Arial", 10F);
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(937, 466);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "frmDM_NhanVien";
            this.Text = "Danh mục nhân viên";
            this.Load += new System.EventHandler(this.frmDM_NhanVien_Load);
            this.OnThemMoi += new System.EventHandler(this.frmDM_NhanVien_OnThemMoi);
            this.OnXoa += new System.EventHandler(this.frmDM_NhanVien_OnXoa);
            this.OnCapNhat += new System.EventHandler(this.frmDM_NhanVien_OnCapNhat);
            this.OnGridCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.frmDM_NhanVien_OnGridCellClick);
            this.OnGridDoubleClick += new System.EventHandler(this.frmDM_NhanVien_OnGridDoubleClick);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpThucThi.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcBase)).EndInit();
            this.ResumeLayout(false);

        }

        public frmDM_NhanVien()
        {
            InitializeComponent();
            dgvDanhSachMatHangGent();
            //lblTieuDe.Text = "DANH SÁCH NHÂN VIÊN";
            SyncProvider = DmNhanVienDataProvider.Instance;
            LoadSync();
        }

        #region Action
        #region LoadChucVu
        private void LoadChucVu()
        {
            List<DMChucVuPairInfor> LiCV = new List<DMChucVuPairInfor>();
            LiCV.Add(new DMChucVuPairInfor { IdChucVu = 0, SuDung = 0, TenChucVu = "Tất cả" });
            LiCV.AddRange(DMChucVuDataProvider.GetListChucVuPairInfo());
            cboChucDanhS.DataSource = LiCV;
            cboChucDanhS.DisplayMember = "TenChucVu";
            cboChucDanhS.ValueMember = "IdChucVu";
            
        }
        #endregion

        #region LoadPhongBan
        private void LoadPhongBan()
        {
            List<DMPhongBanPairInfor> LiPB = new List<DMPhongBanPairInfor>();
            LiPB.Add(new DMPhongBanPairInfor { IdPhongBan = 0, SuDung = 0, TenPhongBan = "Tất cả" });
            LiPB.AddRange(DMPhongBanDataProvider.Instance.GetListPhongBanPairInfo());
            cboPhongBanS.DataSource = LiPB;
            cboPhongBanS.DisplayMember = "TenPhongBan";
            cboPhongBanS.ValueMember = "IdPhongBan";
        }
        #endregion

        #region LoadData
        protected override void LoadData()
        {
            grcBase.DataSource = DmNhanVienDataProvider.GetListDmNhanVienInfor();
            btnFilter.Text = Resources.btnSearch;
        }
        #endregion

        #region Delete
        private void Delete()
        {
            DmNhanVienDataProvider.Delete(new DMNhanVienInfo { IdNhanVien = Oid });
            LoadData();
            SetControl(false);
        }
        #endregion

        #region dgvDanhSachMatHangGent
        private void dgvDanhSachMatHangGent()
        {
            ////dgvDanhSachMatHang.Rows.Clear();
            //dgvDanhSachMatHang.Columns.Clear();

            ////DataGridViewTextBoxColumn colSTT = new DataGridViewTextBoxColumn();
            ////colSTT.Name = "STT";
            ////colSTT.HeaderText = "STT";
            ////colSTT.SortMode = DataGridViewColumnSortMode.NotSortable;
            ////colSTT.Width = 50;
            ////colSTT.ReadOnly = true;
            ////colSTT.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ////colSTT.DataPropertyName = "SoTT";
            ////dgvDanhSachMatHang.Columns.Add(colSTT);

            //DataGridViewTextBoxColumn colID = new DataGridViewTextBoxColumn();
            //colID.Name = "ID";
            //colID.HeaderText = "ID";
            //colID.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colID.ReadOnly = true;
            //colID.Visible = false;
            //colID.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //colID.DataPropertyName = "IdNhanVien";
            //dgvDanhSachMatHang.Columns.Add(colID);

            //DataGridViewTextBoxColumn colMa = new DataGridViewTextBoxColumn();
            //colMa.Name = "MaNhanVien";
            //colMa.HeaderText = "Mã nhân viên";
            ////colMa.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colMa.Width = 110;
            //colMa.ReadOnly = true;
            //colMa.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //colMa.DataPropertyName = "MaNhanVien";
            //colMa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dgvDanhSachMatHang.Columns.Add(colMa);

            //DataGridViewTextBoxColumn colTen = new DataGridViewTextBoxColumn();
            //colTen.Name = "HoTen";
            //colTen.HeaderText = "Họ tên";
            //colTen.ValueType = typeof(string);
            ////colTen.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colTen.Width = 203;
            //colTen.ReadOnly = true;
            //colTen.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            //colTen.DataPropertyName = "HoTen";
            //colTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //colTen.MinimumWidth = 200;
            //dgvDanhSachMatHang.Columns.Add(colTen);

            //DataGridViewTextBoxColumn colNgaySinh = new DataGridViewTextBoxColumn();
            //colNgaySinh.Name = "NgaySinh";
            //colNgaySinh.HeaderText = "Ngày sinh";
            //colNgaySinh.Visible = false;
            //colNgaySinh.DataPropertyName = "NgaySinh";
            //dgvDanhSachMatHang.Columns.Add(colNgaySinh);

            //DataGridViewTextBoxColumn colGioiTinh = new DataGridViewTextBoxColumn();
            //colGioiTinh.Name = "GioiTinh";
            //colGioiTinh.HeaderText = "Giới tính";
            //colGioiTinh.Width = 0;
            //colGioiTinh.Visible = false;
            //colGioiTinh.DataPropertyName = "GioiTinh";
            //dgvDanhSachMatHang.Columns.Add(colGioiTinh);

            //DataGridViewTextBoxColumn colNhom = new DataGridViewTextBoxColumn();
            //colNhom.Name = "PhongBan";
            //colNhom.HeaderText = "Phòng ban";
            //colNhom.ValueType = typeof(string);
            //colNhom.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colNhom.Width = 150;
            //colNhom.ReadOnly = true;
            //colNhom.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ////colNhom.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //colNhom.MinimumWidth = 150;
            //colNhom.DataPropertyName = "TenPhongBan";
            //dgvDanhSachMatHang.Columns.Add(colNhom);

            //DataGridViewTextBoxColumn colChucVu = new DataGridViewTextBoxColumn();
            //colChucVu.Name = "ChucVu";
            //colChucVu.HeaderText = "Chức vụ";
            //colChucVu.ValueType = typeof(string);
            //colChucVu.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colChucVu.Width = 150;
            //colChucVu.ReadOnly = true;
            //colChucVu.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            ////colChucVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //colChucVu.MinimumWidth = 150;
            //colChucVu.DataPropertyName = "TenChucVu";
            //dgvDanhSachMatHang.Columns.Add(colChucVu);

            //DataGridViewTextBoxColumn colDiaChi = new DataGridViewTextBoxColumn();
            //colDiaChi.Name = "DiaChi";
            //colDiaChi.HeaderText = "Địa chỉ";
            //colDiaChi.Visible = false;
            //colDiaChi.DataPropertyName = "DiaChi";
            ////colDiaChi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ////colDiaChi.MinimumWidth = 200;
            //dgvDanhSachMatHang.Columns.Add(colDiaChi);

            //DataGridViewTextBoxColumn colDienThoai = new DataGridViewTextBoxColumn();
            //colDienThoai.Name = "DienThoai";
            //colDienThoai.HeaderText = "Điện thoại";
            //colDienThoai.Visible = false;
            //colDienThoai.DataPropertyName = "DienThoai";
            //dgvDanhSachMatHang.Columns.Add(colDienThoai);

            //DataGridViewCheckBoxColumn colSuDung = new DataGridViewCheckBoxColumn();
            //colSuDung.Name = "SuDung";
            //colSuDung.HeaderText = "Sử dụng";
            //colSuDung.Width = 100;
            //colSuDung.ReadOnly = true;
            //colSuDung.SortMode = DataGridViewColumnSortMode.NotSortable;
            //colSuDung.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //colSuDung.DataPropertyName = "SuDung";
            //dgvDanhSachMatHang.Columns.Add(colSuDung);

            //DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            //colEmail.Name = "Email";
            //colEmail.HeaderText = "Email";
            //colEmail.Visible = false;
            //colEmail.DataPropertyName = "Email";
            //dgvDanhSachMatHang.Columns.Add(colEmail);

            //DataGridViewTextBoxColumn colGhiChu = new DataGridViewTextBoxColumn();
            //colGhiChu.Name = "GhiChu";
            //colGhiChu.HeaderText = "Ghi chú";
            //colGhiChu.Visible = false;
            //colGhiChu.DataPropertyName = "GhiChu";
            //dgvDanhSachMatHang.Columns.Add(colGhiChu);

            //dgvDanhSachMatHang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvDanhSachMatHang.MultiSelect = false;
            //dgvDanhSachMatHang.AutoGenerateColumns = false;
        }
        #endregion
        #endregion

        private void frmDM_NhanVien_Load(object sender, EventArgs e)
        {
            LoadChucVu();
            LoadPhongBan();
        }

        private void frmDM_NhanVien_OnCapNhat(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_NhanVien frm = new frmChiTiet_NhanVien(this);
            frm.ShowDialog();
        }

        private void frmDM_NhanVien_OnThemMoi(object sender, EventArgs e)
        {
            isAdd = true;
            frmChiTiet_NhanVien frm = new frmChiTiet_NhanVien(this);
            frm.ShowDialog();
        }

        private void frmDM_NhanVien_OnXoa(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DMNhanVienInfo dm = new DMNhanVienInfo();
            dm.HoTen = txtFilterTen.Text.Trim();
            dm.MaNhanVien = txtFilterMa.Text.Trim();
            dm.IdChucVu = Convert.ToInt32(cboChucDanhS.SelectedValue.ToString());
            dm.IdPhongBan = Convert.ToInt32(cboPhongBanS.SelectedValue.ToString());
            grcBase.DataSource = DmNhanVienDataProvider.Search(dm);
        }

        void frmDM_NhanVien_OnGridCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            SetControl(true);
            Oid = ((DMNhanVienInfo)dgvDanhSachMatHang.GetFocusedRow()).IdNhanVien;
        }

        private void frmDM_NhanVien_OnGridDoubleClick(object sender, EventArgs e)
        {
            isAdd = false;
            frmChiTiet_NhanVien frm = new frmChiTiet_NhanVien(this);
            frm.ShowDialog();
        }
    }
}
