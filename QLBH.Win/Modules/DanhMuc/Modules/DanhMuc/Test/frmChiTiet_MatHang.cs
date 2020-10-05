using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_MatHang
    {
        #region TestUnit
        public void SetInput(string sTen, string sMa, string sTenTat, string sMaVach, int iGiaNhap, string sGhiChu, int iSuDung, int iChietKhau,int iTrungMaVach)
        {
#if DEBUG
            txtTenSanPham.Text = sTen;
            txtMaSanPham.Text = sMa;
            txtTenTat.Text = sTenTat;
            txtMaVach.Text = sMaVach;
            txtGiaNhap.Text = Convert.ToString(iGiaNhap);
            txtMoTa.Text = sGhiChu;
            chkSuDung.Checked = iSuDung == 1;
            chkChietKhau.Checked = iChietKhau == 0;
            chkTrungMaVach.Checked = iTrungMaVach == 0;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            SaveMatHang();
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
