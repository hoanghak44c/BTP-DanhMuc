using System;
using System.Collections.Generic;
using System.Text;

// <Remarks>
// form frmChiTiet_NhanVien
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_NhanVien
    {
        #region TestUnit
        public void SetInput(string sTen, string sMa, string sNgaySinh, string sDiaChi, string sDienThoai, string sEmail, string sGhiChu, int iSuDung, int idPhongBan, int idChucVu)
        {
#if DEBUG
            LoadPhongBan();
            LoadChucVu();
            txtHoTen.Text = sTen;
            txtMaNhanVien.Text = sMa;
//            txtNgaySinh.Text = sNgaySinh;
            txtDiaChi.Text = sDiaChi;
            txtDienThoai.Text = sDienThoai;
            txtEmail.Text = sEmail ;
            txtGhiChu.Text = sGhiChu;
            chkSuDung.Checked = iSuDung == 1;
            cboPhongBan.SelectedValue = idPhongBan;
            cboChucVu.SelectedValue = idChucVu;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            SaveNhanVien();
#endif
        }

        public void TestDelete()
        {
#if DEBUG
            Delete();
#endif
        }
        public void TestCheck()
        {
#if DEBUG
            Check();
#endif
        }
        #endregion
    }
}
