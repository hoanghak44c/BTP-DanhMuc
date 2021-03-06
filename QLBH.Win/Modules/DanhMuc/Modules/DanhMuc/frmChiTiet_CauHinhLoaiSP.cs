using System;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_CauHinhLoaiSP : DevExpress.XtraEditors.XtraForm
    {
        public int IdLoaiSanPham;
        private frmDMCauHinh_LoaiSanPham frm;
        private CauHinh_LoaiSanPhamInfo dm;
        public frmChiTiet_CauHinhLoaiSP()
        {
            InitializeComponent();
        }
        public frmChiTiet_CauHinhLoaiSP(frmDMCauHinh_LoaiSanPham frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        #region Action

        #region Reset
        private void Reset()
        {
            txtGhiChu.Text = "";
            txtTenLoi.Text = "";
            txtMaLoi.Text = "";
            cbSuDung.Checked = false;
            txtMaLoi.Focus();
        }
        #endregion

        #region LoadLoaiSP
        private void LoadLoaiSP()
        {
            //cboLoaiItem.DataSource = DMLoaiSanPhamDataProvider.GetLoaiSPPairInfor();
            //cboLoaiItem.DisplayMember = "TenLoaiSP";
            //cboLoaiItem.ValueMember = "IdLoaiSP";
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frm.isAdd)
            {
                Reset();
                btnDelete.Enabled = false;
                txtMaLoi.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = true;
                txtMaLoi.Enabled = false;
                dm = CauHinh_LoaiSanPhamDataProvider.GetListCauHinhLoaiSPInfoFromOid(frm.Oid);

                txtTenLoi.Text = dm.TenCauHinh;
                txtMaLoi.Text = dm.MaCauHinh;
                txtGhiChu.Text = dm.GhiChu;
                cbSuDung.Checked = dm.SuDung == 1;
                txtLoaiSanPham.Text = dm.TenLoaiSp;
            }
        }
        #endregion

        #region SetCauHinhInfo
        private CauHinh_LoaiSanPhamInfo SetCauHinhInfo()
        {
            CauHinh_LoaiSanPhamInfo dm = new CauHinh_LoaiSanPhamInfo();
            dm.MaCauHinh = txtMaLoi.Text.Trim();
            dm.TenCauHinh = txtTenLoi.Text.Trim();
            dm.GhiChu = txtGhiChu.Text.Trim();
            dm.IdSanPham = IdLoaiSanPham;
            dm.SuDung = Convert.ToInt32(cbSuDung.Checked);
            dm.IdCauHinh = frm.Oid;

            return dm;
        }
        #endregion

        #region Save
        private void Save()
        {
            check();
            if (frm.isAdd)
            {
                CauHinh_LoaiSanPhamDataProvider.Insert(SetCauHinhInfo());
            }
            else
            {
                CauHinh_LoaiSanPhamInfo dm = SetCauHinhInfo();
                dm.IdCauHinh = frm.Oid;
                CauHinh_LoaiSanPhamDataProvider.Update(dm);
            }
        }
        #endregion

        #region Check
        private void check()
        {
            //todo: @HAH thiếu check chọn loại sản phẩm
            if (txtMaLoi.Text == "")
            {
                txtMaLoi.Focus();
                throw new Exception("Mã cấu hình không được để trống !");
            }
            if (txtTenLoi.Text == "")
            {
                txtTenLoi.Focus();
                throw new Exception("Tên cấu hình không được để trống !");
            }
            //if (CauHinh_LoaiSanPhamDataProvider.KiemTra(new CauHinh_LoaiSanPhamInfo { IdCauHinh = frm.Oid, MaCauHinh = txtMaLoi.Text.Trim() }))
            //{
            //    txtMaLoi.Focus();
            //    throw new Exception("Mã cấu hình đã tồn tại trong hệ thống.Xin hãy kiểm tra lại !");
            //}
        }
        #endregion 

        #region Delete
        private void Delete()
        {
            if (frm.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            CauHinh_LoaiSanPhamDataProvider.Delete(new CauHinh_LoaiSanPhamInfo { IdCauHinh = frm.Oid });
            this.Close();
            frm.ReLoad();
        }
        #endregion

        #endregion

        private void frmChiTiet_CauHinhLoaiSP_Load(object sender, EventArgs e)
        {
            LoadLoaiSP();
            LoadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                if (frm.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                    this.Close();
                }
                frm.ReLoad();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này ?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Delete();
                }
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(ex.ToString(), Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#else
                MessageBox.Show(ex.Message, Declare.titleError, MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoaiSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmLookUp_LoaiSanPham frm = new frmLookUp_LoaiSanPham(false, "%" + txtLoaiSanPham.Text.Trim() + "%");
                frm.ShowDialog();
                if (frm.DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    txtLoaiSanPham.Text = frm.SelectedItem.TenLoaiSP;
                    IdLoaiSanPham = frm.SelectedItem.IdLoaiSP;
                }
            }
        }
    }
}