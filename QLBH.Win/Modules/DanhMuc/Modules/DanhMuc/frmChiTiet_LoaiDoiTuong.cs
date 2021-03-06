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

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_LoaiDoiTuong : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private frmDM_LoaiDoiTuong frmDMLoaiDT;
        private DmLoaiDoiTuongInfor dm;
        #endregion

        public frmChiTiet_LoaiDoiTuong()
        {
            InitializeComponent();
        }
        public frmChiTiet_LoaiDoiTuong(frmDM_LoaiDoiTuong frm)
        {
            InitializeComponent();
            this.frmDMLoaiDT = frm;
        }
        #region Action

        #region Reset
        private void Reset()
        {
            txtTenLoaiDT.Text = String.Empty;
            txtMaLoaiDT.Text = String.Empty;
            txtNhomCha.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            chkSuDung.Checked = false;
            txtMaLoaiDT.Focus();
        }
        #endregion

        #region LoadData
        private void Loaddata()
        {
            if (frmDMLoaiDT.isAdd)
            {
                Reset();
                btnDelete.Enabled = false;
            }
            else
            {
                txtMaLoaiDT.Enabled = false;
                dm = DmLoaiDoiTuongDataProvider.GetListDmLoaiDTInfoFromOid(frmDMLoaiDT.Oid);
                txtTenLoaiDT.Text = dm.TenLoaiDT;
                txtMaLoaiDT.Text = dm.MaLoaiDT;
                txtGhiChu.Text = dm.GhiChu;
                txtNhomCha.Text = Convert.ToString(dm.NhomCha);
                chkSuDung.Checked = dm.SuDung == 1;
            }
            if (frmDMLoaiDT.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaLoaiDT.Enabled = false;
                txtTenLoaiDT.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmDMLoaiDT.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmDMLoaiDT.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DmLoaiDoiTuongDataProvider.Delete(new DmLoaiDoiTuongInfor() { IdLoaiDT = frmDMLoaiDT.Oid });
        }
        #endregion

        #region Check()
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaLoaiDT.Text))
            {
                txtMaLoaiDT.Focus();
                throw new InvalidOperationException("Mã loại đối tượng không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenLoaiDT.Text))
            {
                txtTenLoaiDT.Focus();
                throw new InvalidOperationException("Tên loại đối tượng không được để trống !");
            }
            if (String.IsNullOrEmpty(txtNhomCha.Text))
            {
                txtNhomCha.Focus();
                throw new InvalidOperationException("Bạn chưa nhập nhóm cha!");
            }
            if (frmDMLoaiDT.IsSync)
            {
                if (txtMaLoaiDT.Text != dm.MaLoaiDT)
                {
                    throw new InvalidOperationException("Mã loại đối tượng đã bị thay đổi !");
                }
                //if (txtTenLoaiDT.Text != dm.TenLoaiDT)
                //{
                //    throw new InvalidOperationException("Tên loại đối tượng đã bị thay đổi !");
                //}
            }
            if (DmLoaiDoiTuongDataProvider.KiemTra(new DmLoaiDoiTuongInfor() { IdLoaiDT = frmDMLoaiDT.Oid, MaLoaiDT = txtMaLoaiDT.Text.Trim() }))
            {
                throw new InvalidOperationException("Mã loại đối tượng đã tồn tại trong hệ thống!");
            }
            return true;
        }
        #endregion
        #region SaveDoiTuong
        private void SaveDoiTuong()
        {
            if (Check())
            {
                if (frmDMLoaiDT.isAdd)
                {
                    DmLoaiDoiTuongDataProvider.Insert(SetDanhMuc());
                }
                else
                {
                    DmLoaiDoiTuongDataProvider.Update(SetDanhMuc());
                }
            }
        }

        #endregion

        #region SetDanhMuc
        private DmLoaiDoiTuongInfor SetDanhMuc()
        {
            DmLoaiDoiTuongInfor dm = new DmLoaiDoiTuongInfor();
            dm.TenLoaiDT = txtTenLoaiDT.Text.Trim();
            dm.MaLoaiDT = txtMaLoaiDT.Text.Trim();
            dm.GhiChu = txtGhiChu.Text.Trim();
            dm.NhomCha = Convert.ToInt32(txtNhomCha.Text.Trim());
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            dm.IdLoaiDT = frmDMLoaiDT.Oid;
            return dm;
        }
        #endregion

        #endregion

        #region Event

        private void frmChiTiet_LoaiDoiTuong_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDoiTuong();
                if (frmDMLoaiDT.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
                frmDMLoaiDT.ReLoad();
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
                Delete();
                MessageBox.Show("Xóa thành công bản ghi!");
                this.Close();
                frmDMLoaiDT.ReLoad();
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
        #endregion

        private void txtNhomCha_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNhomCha.Text != "")
                    Convert.ToInt32(txtNhomCha.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtNhomCha.SelectAll();
            }
        }
    }
}