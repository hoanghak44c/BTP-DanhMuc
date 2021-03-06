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

// <Remarks>
// form frmChiTiet_LoaiThuChi
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 17/04/2012
// Ngày sửa cuối:
// </remarks>
//Note:@HanhBD frmChiTiet_LoaiThuChi
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_LoaiThuChi : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        private frmDM_LoaiThuChi frmDMLoaiThuChi;
        private DMLoaiThuChiInfor dm;
        #endregion

        #region TestUnit Function

        public void SetInput(string sTen, string sMa, string sMota,int sType, int iSudung)
        {
#if DEBUG
            txtTen.Text = sTen;
            txtKyHieu.Text = sMa;
            txtGhiChu.Text = sMota;
            txtType.Text = Convert.ToString(sType);
            chkSuDung.Checked = iSudung == 1;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            SaveDoiTuong();
#endif
        }

        public void TestDelete()
        {
#if DEBUG
            Delete();
#endif
        }

        #endregion
        public frmChiTiet_LoaiThuChi()
        {
            InitializeComponent();
        }

        public frmChiTiet_LoaiThuChi(frmDM_LoaiThuChi frm)
        {
            InitializeComponent();
            this.frmDMLoaiThuChi = frm;
        }

        #region Action

        #region Reset
        private void Reset()
        {
            txtTen.Text = "";
            txtKyHieu.Text = "";
            txtType.Text = "";
            txtGhiChu.Text = "";
            chkSuDung.Checked = false;
            txtKyHieu.Focus();
        }
        #endregion

        #region LoadData
        private void Loaddata()
        {
            if (frmDMLoaiThuChi.isAdd)
            {
                Reset();
                btnDelete.Enabled = false;
            }
            else
            {
                txtKyHieu.Enabled = false;
                dm = DMLoaiThuChiDataProvider.GetListDmThuChiInfoFromOid(frmDMLoaiThuChi.Oid);
                txtTen.Text = dm.Ten;
                txtKyHieu.Text = dm.KyHieu;
                txtGhiChu.Text = dm.GhiChu;
                txtType.Text = Convert.ToString(dm.Type);
                chkSuDung.Checked = dm.SuDung == 1;
            }
            if (frmDMLoaiThuChi.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtKyHieu.Enabled = false;
                txtTen.Enabled = false;
                btnDelete.Enabled = false;
            }

        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmDMLoaiThuChi.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmDMLoaiThuChi.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DMLoaiThuChiDataProvider.Delete(new DMLoaiThuChiInfor { IdThuChi = frmDMLoaiThuChi.Oid });
        }
        #endregion

        #region Check()
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtKyHieu.Text))
            {
                txtKyHieu.Focus();
                throw new InvalidOperationException("Ký hiệu không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                txtTen.Focus();
                throw new InvalidOperationException("Tên không được để trống !");
            }
            if (frmDMLoaiThuChi.IsSync)
            {
                if (txtKyHieu.Text != dm.KyHieu)
                {
                    throw new InvalidOperationException("Ký hiệu đã bị thay đổi !");
                }
                if (txtTen.Text != dm.Ten)
                {
                    throw new InvalidOperationException("Tên loại thu chi đã bị thay đổi !");
                }
            }
            if (DMLoaiThuChiDataProvider.KiemTra(new DMLoaiThuChiInfor {IdThuChi = frmDMLoaiThuChi.Oid,KyHieu = txtKyHieu.Text.Trim() }))
            {
                throw new InvalidOperationException("Ký hiệu đã tồn tại trong hệ thống!");
            }
            return true;
        }
        #endregion
        #region SaveDoiTuong
        private void SaveDoiTuong()
        {
            if(Check())
            {
                if (frmDMLoaiThuChi.isAdd)
                {
                    DMLoaiThuChiDataProvider.Insert(SetDanhMuc());
                }
                else
                {
                    DMLoaiThuChiDataProvider.Update(SetDanhMuc());
                }
            }
        }
        
        #endregion

        #region SetDanhMuc
        private DMLoaiThuChiInfor SetDanhMuc()
        {
            DMLoaiThuChiInfor dm = new DMLoaiThuChiInfor();
            dm.IdThuChi = Convert.ToInt32(frmDMLoaiThuChi.Oid);
            dm.Ten = txtTen.Text.Trim();
            dm.KyHieu = txtKyHieu.Text.Trim();
            dm.GhiChu = txtGhiChu.Text.Trim();
            dm.Type = Convert.ToInt32(txtType.Text.Trim());
            dm.SuDung = Convert.ToInt32(chkSuDung.Checked);
            return dm;
        }
        #endregion

        #endregion
        #region Event

        private void frmChiTiet_LoaiThuChi_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDoiTuong();
                if(frmDMLoaiThuChi.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công !");
                }
                this.Close();
                frmDMLoaiThuChi.ReLoad();
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
                frmDMLoaiThuChi.ReLoad();
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

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtType.Text != "")
                    Convert.ToInt32(txtType.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtType.Text = "";
            }
        }
    }
}