using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_KhachHang
    {
        #region TestUnit
        public void SetInput(string sTen, string sMaDoiTuong, string sMaSoThue,DateTime dngaysinh,  string sNguoiLL,string sOrderType,string sDienThoai, string sEmail, string sFax, string sGhiChu, int iSuDung)
        {
#if DEBUG
            txtTen.Text = sTen;
            txtMa.Text = sMaDoiTuong;
            txtMaSoThue.Text = sMaSoThue;
            txtNguoiLienLac.Text = sNguoiLL;
            txtNgaySinh.Value = dngaysinh;
            txtOrderType.Text = sOrderType;
            txtDienThoai.Text = sDienThoai;
            txtEmail.Text = sEmail;
            txtFax.Text = sFax;
            txtGhiChu.Text = sGhiChu;
            chkSuDung.Checked = iSuDung == 1;
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
        public void TestCheck()
        {
#if DEBUG
            Check();
#endif
        }
        #endregion
    }
}
