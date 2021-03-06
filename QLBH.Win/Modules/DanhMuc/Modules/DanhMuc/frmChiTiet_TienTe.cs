using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;

// <Remarks>
// form frmChiTiet_TienTe
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 14/04/2012
// Ngày sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_TienTe : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_TienTe frmTT;
        DMTienTeInfor dm;
        #endregion

        #region TestUnit Function

        public void SetInput(string sTen, string sMa, string sMota,int sTygia,int iSudung)
        {
#if DEBUG
            txtTen.Text = sTen;
            txtMa.Text = sMa;
            txtMoTa.Text = sMota;
            txtTyGia.Text = Convert.ToString(sTygia);
            chkSuDung.Checked = iSudung == 1;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            SaveTienTe();
#endif
        }

        public void TestDelete()
        {
#if DEBUG
            Delete();
#endif
        }

        #endregion
        #region frmChiTiet_TienTe
        public frmChiTiet_TienTe(frmDM_TienTe frm)
        {
            InitializeComponent();
            this.frmTT = frm;
        }
        #endregion

        #region Action
        #region LoadData
        private void LoadData()
        {
            if (!frmTT.isAdd)
            {
                txtMa.Enabled = false;
                dm = DMTienTeDataProvider.GetListDmTienTeInfoFromOid(frmTT.Oid);
                txtTen.Text = dm.TenTienTe;
                txtMa.Text = dm.KyHieu;
                txtMoTa.Text = dm.GhiChu;
                txtTyGia.Text = Convert.ToString(dm.TyGia);
                chkSuDung.Checked = dm.SuDung == 1;
                txtTen.Focus();
            }
            else
            {
                btnDelete.Enabled = false;
                Reset();
            }
            if (frmTT.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMa.Enabled = false;
                txtTen.Enabled = false;
                btnDelete.Enabled = false;
            }
        }
        #endregion

        #region Reset
        protected void Reset()
        {
            txtTen.Text = "";
            txtMa.Text = "";
            txtMoTa.Text = "";
            txtTyGia.Text = "";
            chkSuDung.Checked = true;
            txtMa.Focus();
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMa.Text))
            {
                txtMa.Focus();
                throw new InvalidOperationException("Mã tiền tệ không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTen.Text))
            {
                txtTen.Focus();
                throw new InvalidOperationException("Tên tiền tệ không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTyGia.Text))
            {
                txtTyGia.Focus();
                throw new InvalidOperationException("Tỷ giá không được để trống !");
            }
            if (frmTT.IsSync)
            {
                if (txtTen.Text != dm.TenTienTe)
                {
                    throw new InvalidOperationException("Tên tiền tệ đã bị thay đổi !");
                }
                if (txtMa.Text != dm.KyHieu)
                {
                    throw new InvalidOperationException("Mã tiền tệ đã bị thay đổi !");
                }
            }
            if (DMTienTeDataProvider.KiemTra(new DMTienTeInfor {IdTienTe = frmTT.Oid,KyHieu = txtMa.Text.Trim()}))
            {
                throw new InvalidOperationException("Mã tiền tệ đã tồn tại trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region SetTienTe
        private DMTienTeInfor SetTienTe()
        {
            return new DMTienTeInfor
               {
                   TenTienTe = txtTen.Text.Trim(),
                   KyHieu = txtMa.Text.Trim(),
                   GhiChu = txtMoTa.Text.Trim(),
                   TyGia = Convert.ToInt32(txtTyGia.Text.Trim()),
                   SuDung = Convert.ToInt32(chkSuDung.Checked),
                   IdTienTe = frmTT.Oid
               };
        }
        #endregion
        #region SaveTienTe
        private void SaveTienTe()
        {
            if(Check())
            {
                if (frmTT.isAdd)
                {
                    DMTienTeDataProvider.Insert(SetTienTe());
                }
                else
                {
                    DMTienTeDataProvider.Update(SetTienTe());
                }
            }
        }
        
        #endregion

        #region Delete
        private void Delete()
        {
            if (frmTT.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if (frmTT.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DMTienTeDataProvider.Delete(new DMTienTeInfor { IdTienTe = frmTT.Oid });
        }
        #endregion
        #endregion

        #region Event

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveTienTe();
                if(frmTT.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                this.Close();
                frmTT.ReLoad();
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
                frmTT.ReLoad();
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

        private void frmChiTiet_TienTe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion


    }
}