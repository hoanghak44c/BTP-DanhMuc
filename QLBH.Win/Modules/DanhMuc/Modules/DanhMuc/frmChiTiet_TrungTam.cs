using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
//Note:@CuongTT frmChiTiet_TrungTam
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_TrungTam : DevExpress.XtraEditors.XtraForm
    {
        #region Declare
        frmDM_TrungTam frm;
        DMTrungTamInfor dm;
        private Common Common = new Common();
        #endregion
        public frmChiTiet_TrungTam(frmDM_TrungTam frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        #region Action
        #region LoadData
        private void LoadData()
        {
            if (!frm.isAdd)
            {
                btnDelete.Enabled = false;
                txtMaTrungTam.Enabled = false;
                dm = DMTrungTamDataProvider.GetTrungTamByIdInfo(frm.Oid);
                txtTenTrungTam.Text = dm.TenTrungTam;
                txtMaTrungTam.Text = dm.MaTrungTam;
                txtGhiChu.Text = dm.GhiChu;
                txtFax.Text = dm.Fax;
                txtEmail.Text = dm.Email;
                txtDienThoai.Text = dm.DienThoai;
                txtDiaChi.Text = dm.DiaChi;
                chkSuDung.Checked = dm.SuDung == 1;
                txtViTri.Text = dm.ViTri;
                txtDuong.Text = dm.Duong;
                txtTinh.Text = dm.Tinh;
                txtQuocGia.Text = dm.QuocGia;
                txtTenTrungTam.Focus();
            }
            else
            {
                btnDelete.Enabled = false;
                Reset();
                //txtDienThoai.Text = "0";
                //txtFax.Text = "0";
            }

            if (frm.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtMaTrungTam.Enabled = false;
                //txtTenTrungTam.Enabled = false;
                //txtDiaChi.Enabled = false;
                //txtDienThoai.Enabled = false;
                //txtFax.Enabled = false;
                //txtEmail.Enabled = false;
                //chkSuDung.Enabled = false;
                //txtViTri.Enabled = false;
                //txtDuong.Enabled = false;
                //txtTinh.Enabled = false;
                //txtQuocGia.Enabled = false;
                //btnDelete.Enabled = false;
            }
        }
        #endregion

        #region Reset
        protected void Reset()
        {
            txtTenTrungTam.Text = String.Empty;
            txtMaTrungTam.Text = String.Empty;
            txtGhiChu.Text = String.Empty;
            txtFax.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtDienThoai.Text = String.Empty;
            txtDiaChi.Text = String.Empty;
            txtViTri.Text = String.Empty;
            txtDuong.Text = String.Empty;
            txtTinh.Text = String.Empty;
            txtQuocGia.Text = String.Empty;
            txtMaTrungTam.Focus();
        }
        #endregion

        #region SetTrungTamInfo
        private DMTrungTamInfor SetTrungTamInfo()
        {
            return new DMTrungTamInfor
               {
                   MaTrungTam = txtMaTrungTam.Text.Trim(),
                   TenTrungTam = txtTenTrungTam.Text.Trim(),
                   DiaChi = txtDiaChi.Text.Trim(),
                   DienThoai = txtDienThoai.Text.Trim(),
                   Email = txtEmail.Text.Trim(),
                   Fax = txtFax.Text.Trim(),
                   GhiChu = txtGhiChu.Text.Trim(),
                   SuDung = Convert.ToInt32(chkSuDung.Checked),
                   ViTri= txtViTri.Text.Trim(),
                   Duong = txtDuong.Text.Trim(),
                   Tinh = txtTinh.Text.Trim(),
                   QuocGia = txtQuocGia.Text.Trim(),
                   IdTrungTam = frm.Oid
               };
        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtMaTrungTam.Text))
            {
                txtMaTrungTam.Focus();
                throw new InvalidOperationException("Mã trung tâm không được để trống !");
            }
            if (String.IsNullOrEmpty(txtTenTrungTam.Text))
            {
                txtTenTrungTam.Focus();
                throw new InvalidOperationException("Tên trung tâm không được để trống !");
            }
            //if (String.IsNullOrEmpty(txtDiaChi.Text))
            //{
            //    txtDiaChi.Focus();
            //    throw new InvalidOperationException("Địa chỉ trung tâm không được để trống !");
            //}
            //if (String.IsNullOrEmpty(txtDienThoai.Text))
            //{
            //    txtDienThoai.Focus();
            //    throw new InvalidOperationException("Điện thoại trung tâm không được để trống !");
            //}
            //if (String.IsNullOrEmpty(txtFax.Text))
            //{
            //    txtFax.Focus();
            //    throw new InvalidOperationException("Fax trung tâm không được để trống !");
            //}
            //if (String.IsNullOrEmpty(txtEmail.Text))
            //{
            //    txtEmail.Focus();
            //    throw new InvalidOperationException("Email không được để trống !");
            //}
            if (txtEmail.Text.Trim().Length > 0 && Common.ValidEmail(txtEmail.Text.Trim()) == false)
            {
                txtEmail.Focus();
                throw new InvalidOperationException("Email chưa đúng định dạng!");
            }
            if (frm.IsSync && !frm.isAdd)
            {
                //if (dm != null && txtTenTrungTam.Text != dm.TenTrungTam)
                //{
                //    throw new InvalidOperationException("Tên trung tâm đã bị thay đổi !");
                //}
                if (dm != null && txtMaTrungTam.Text != dm.MaTrungTam)
                {
                    throw new InvalidOperationException("Mã trung tâm đã bị thay đổi !");
                }
                //if (dm != null && txtDiaChi.Text != dm.DiaChi)
                //{
                //    throw new InvalidOperationException("Địa chỉ đã bị thay đổi !");
                //}
            }

            if (DMTrungTamDataProvider.KiemTra(new DMTrungTamInfor{IdTrungTam = frm.Oid, MaTrungTam = txtMaTrungTam.Text.Trim()}))
            {
                txtMaTrungTam.SelectAll();
                txtMaTrungTam.Focus();
                throw new InvalidOperationException("Mã trung tâm đã tồn tại trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region Save
        private void Save()
        {
            if(Check())
            {
                if (frm.isAdd && !frm.IsSync)
                {
                    DMTrungTamDataProvider.Insert(SetTrungTamInfo());
                }
                else
                {
                    DMTrungTamDataProvider.Update(SetTrungTamInfo());
                }
            }
        }
        #endregion

        #region Delete
        private void Delete()
        {
            if (frm.isAdd)
            {
                throw new InvalidOperationException("Bạn không thể xóa khi đang thêm mới!");
            }
            if(frm.IsSync)
            {
                throw new InvalidOperationException("Bạn không thể xóa dữ liệu được đồng bộ!");
            }
            DMTrungTamDataProvider.Delete(new DMTrungTamInfor { IdTrungTam = frm.Oid });
        }
        #endregion

        #endregion
        #region Event
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                if(frm.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công!");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
                MessageBox.Show("Xóa bản ghi thành công!");
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

        private void frmChiTiet_TrungTam_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtFax.Text != "")
                    Convert.ToInt32(txtFax.Text);
            }
            catch
            {
                MessageBox.Show("Bạn chỉ có thể nhập số !");
                txtFax.SelectAll();
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    if (txtDienThoai.Text != "")
            //        Convert.ToInt32(txtDienThoai.Text);
            //}
            //catch
            //{
            //    MessageBox.Show("Bạn chỉ có thể nhập số !");
            //    txtDienThoai.SelectAll();
            //}
        }
        private void txtTenTrungTam_Enter(object sender, EventArgs e)
        {
            Common.SelectAllText(sender);
        }

        private void txtFax_KeyDown(object sender, KeyEventArgs e)
        {
            //if ((e.KeyValue >= 48 && e.KeyValue <= 57) ||(e.KeyValue >= 96 && e.KeyValue <= 105))
            //{
            //    //do continue
            //}
            //else
            //{
            //    e.Handled = true;
            //    e.SuppressKeyPress = true;
            //}
        }

        private void txtDienThoai_Leave(object sender, EventArgs e)
        {
            //bool fag;

            //fag = Common.IsNumber(txtDienThoai.Text);
            //if (fag == false)
            //{
            //    MessageBox.Show("Số điện thoại phải là kiểu số!");
            //    txtDienThoai.Focus();
            //}
        }

        private void txtFax_Leave(object sender, EventArgs e)
        {
            
            //bool fag;

            //fag = Common.IsNumber(txtFax.Text);
            //if (fag == false)
            //{
            //    MessageBox.Show("Số Fax phải là kiểu số!");
            //    txtFax.Focus();
            //}
        }
    }
}