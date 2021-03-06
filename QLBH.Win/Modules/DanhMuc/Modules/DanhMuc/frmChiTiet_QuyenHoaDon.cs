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
    public partial class frmChiTiet_QuyenHoaDon : DevExpress.XtraEditors.XtraForm
    {
        frmDM_QuyenHoaDon frm;
        DMQuyenHoaDonInfor dm;
        #region TestUnit Function

        public void SetInput(string sTen, string sMa, int sSoluong, int sSudung)
        {
#if DEBUG
            txtKyHieu.Text = sTen;
            txtKyHieuDau.Text = sMa;
            txtSoLuong.Text = Convert.ToString(sSoluong);
            txtDaDung.Text = Convert.ToString(sSudung);

#endif
        }

        public void TestSave()
        {
#if DEBUG
            Save();
#endif
        }

        public void TestDelete()
        {
#if DEBUG
            Delete();
#endif
        }

        #endregion
        public frmChiTiet_QuyenHoaDon(frmDM_QuyenHoaDon frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        #region Action
        #region Reset
        private void Reset()
        {
            txtSoLuong.Text = "";
            txtKyHieuDau.Text = "";
            txtKyHieu.Text = "";
            txtDaDung.Text = "";
            txtConLai.Text = "";
            txtKyHieu.Focus();
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
                dm = DMQuyenHoaDonDataProvider.GetHoaDonInfo(frm.kytudau,frm.kyhieuhoadon);
                string conlai = (Convert.ToInt32(dm.SoLuong.ToString()) - Convert.ToInt32(dm.SuDung.ToString())).ToString();
                txtSoLuong.Text = dm.SoLuong.ToString();
                txtKyHieuDau.Text = dm.KyTuDauSerie;
                txtKyHieu.Text = dm.KyHieuHoaDon;
                txtDaDung.Text = dm.SuDung.ToString();
                txtConLai.Text = conlai;
                txtKyHieu.Enabled = false;
                txtKyHieuDau.Enabled = false;
            }
            if (frm.IsSync)
            {
                //không cho phép người dùng sửa, xóa các thông tin trên form.
                txtKyHieu.Enabled = false;
                txtKyHieuDau.Enabled = false;
                btnXoa.Enabled = false;
            }
        }
        #endregion

        #region SetHoaDonInfo
        private DMQuyenHoaDonInfor SetHoaDonInfo()
        {
            return new DMQuyenHoaDonInfor
              {
                KyHieuHoaDon = txtKyHieu.Text.Trim(),
                KyTuDauSerie = txtKyHieuDau.Text.Trim(),
                SoLuong = Convert.ToInt32(txtSoLuong.Text),
                SuDung = Convert.ToInt32(txtDaDung.Text)
              };

        }
        #endregion

        #region Check
        private bool Check()
        {
            if (String.IsNullOrEmpty(txtKyHieu.Text))
            {
                txtKyHieu.Focus();
                throw new InvalidOperationException("Ký hiệu không được để trống !");
            }
            if (String.IsNullOrEmpty(txtKyHieuDau.Text))
            {
                txtKyHieuDau.Focus();
                throw new InvalidOperationException("Ký tự đầu không được để trống !");
            }
            if (frm.IsSync)
            {
                if (txtKyHieu.Text != dm.KyHieuHoaDon)
                {
                    throw new InvalidOperationException("Ký hiệu hóa đơn đã bị thay đổi !");
                }
                if (txtKyHieuDau.Text != dm.KyTuDauSerie)
                {
                    throw new InvalidOperationException("Ký tự đầu đã bị thay đổi !");
                }
            }

            if (frm.isAdd && DMQuyenHoaDonDataProvider.Kiemtra(new DMQuyenHoaDonInfor { KyHieuHoaDon = txtKyHieu.Text.Trim(), KyTuDauSerie = txtKyHieuDau.Text.Trim() }))
            {
                throw new InvalidOperationException("Ký hiệu đã có trong hệ thống !");
            }
            return true;
        }
        #endregion

        #region Save
        private void Save()
        {
            if(Check())
            {
                if ( frm.isAdd)
                {
                    DMQuyenHoaDonDataProvider.Insert(SetHoaDonInfo());
                }
                else
                {
                    DMQuyenHoaDonDataProvider.Update(SetHoaDonInfo());
                }
                frm.ReLoad();
                frm.SetControl(false);
                this.Close();
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

            DMQuyenHoaDonDataProvider.Delete(new DMQuyenHoaDonInfor { KyHieuHoaDon = frm.kyhieuhoadon, KyTuDauSerie = frm.kytudau});
        }
        #endregion
        #endregion

        #region Event
        private void frmChiTiet_QuyenHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtDaDung_TextChanged(object sender, EventArgs e)
        {
            int sd = Convert.ToInt32(txtDaDung.Text.Trim());
            int sl = Convert.ToInt32(txtSoLuong.Text.Trim());
            if (sd <= sl)
            {
                txtConLai.Text = (sl - sd).ToString();
            }
            else
            {
                MessageBox.Show("Số lượng đã dùng không được lớn hơn số lượng hiện có !");
                txtDaDung.Focus();
                txtDaDung.Text = "";
                return;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
                if (frm.isAdd)
                {
                    MessageBox.Show("Thêm mới thành công !");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công!");
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
        //Todo: @HaH cần xem lại xem Quyển hóa đơn nào đã dùng thì không được phép xóa
        private void btnXoa_Click(object sender, EventArgs e)
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
        #endregion
    }
}