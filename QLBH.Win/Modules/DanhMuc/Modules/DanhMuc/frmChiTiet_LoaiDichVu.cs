using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;

//Note:@HanhBD frmChiTiet_LoaiDichVu
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_LoaiDichVu : DevExpress.XtraEditors.XtraForm
    {
        private frmDM_LoaiDichVu frm;
        private DMLoaiDichVuInfor dm;
        public frmChiTiet_LoaiDichVu()
        {
            InitializeComponent();
        }
        public frmChiTiet_LoaiDichVu(frmDM_LoaiDichVu frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        #region Action

        #region Reset
        private void Reset()
        {
            txtTenLoaiDichVu.Text = "";
            txtMaLoaiDichVu.Text = "";
            txtGhiChu.Text = "";
            cbSuDung.Checked = false;
            txtMaLoaiDichVu.Focus();
        }
        #endregion

        #region LoadData
        private void LoadData()
        {
            if (frm.isAdd)
            {
                Reset();
                btnXoa.Enabled = false;
            }
            else
            {
                dm = DMLoaiDichVuDataProvider.GetTrungTamByIdInfo(frm.Oid);

                txtTenLoaiDichVu.Text = dm.TenDichVu;
                txtMaLoaiDichVu.Text = dm.MaLoaiDichVu;
                txtGhiChu.Text = dm.GhiChu;
                cbSuDung.Checked = dm.SuDung == 1;
            }
            if (frm.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaLoaiDichVu.Enabled = false;
                txtTenLoaiDichVu.Enabled = false;
                btnXoa.Enabled = false;
            }

        }
        #endregion

        #region SetLoaiDichVuInfo
        private DMLoaiDichVuInfor SetLoaiDichVuInfo()
        {
            DMLoaiDichVuInfor dm = new DMLoaiDichVuInfor();
            dm.MaLoaiDichVu = txtMaLoaiDichVu.Text.Trim();
            dm.TenDichVu = txtTenLoaiDichVu.Text.Trim();
            dm.GhiChu = txtGhiChu.Text.Trim();

            return dm;
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaLoaiDichVu.Text))
            {
                txtMaLoaiDichVu.Focus();
                throw new InvalidOperationException("Mã loại Item không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenLoaiDichVu.Text))
            {
                txtTenLoaiDichVu.Focus();
                throw new InvalidOperationException("Mã loại Item không được để trống !");
            }
            if (frm.IsSync)
            {
                if (txtMaLoaiDichVu.Text != dm.MaLoaiDichVu)
                {
                    throw new InvalidOperationException("Mã Loại Item đã bị thay đổi !");
                }
                if (txtTenLoaiDichVu.Text != dm.TenDichVu)
                {
                    throw new InvalidOperationException("Tên loại Item chi đã bị thay đổi !");
                }
            }

            if (DMLoaiDichVuDataProvider.Kiemtra(new DMLoaiDichVuInfor { IdLoaiDichVu = frm.Oid, MaLoaiDichVu = txtMaLoaiDichVu.Text.Trim() }))
            {
                throw new InvalidOperationException("Mã loại Item không được để trống !");
            }
            return true;
        }
        #endregion
        #region Save
        private void Save()
        {
            if(Check())
            {
                if (frm.isAdd)
                {
                    DMLoaiDichVuDataProvider.Insert(SetLoaiDichVuInfo());
                    Reset();
                }
                else
                {
                    DMLoaiDichVuInfor dm = SetLoaiDichVuInfo();
                    dm.IdLoaiDichVu = frm.Oid;
                    DMLoaiDichVuDataProvider.Update(dm);
                }
            }
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frm.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới !");
            }
            if (frm.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DMLoaiDichVuDataProvider.Delete(new DMLoaiDichVuInfor { IdLoaiDichVu = frm.Oid });
        }
        #endregion

        #endregion

        private void frmChiTiet_LoaiDichVu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                if(frm.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
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
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa thành công bản ghi!");
                this.Close();
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
    }
}