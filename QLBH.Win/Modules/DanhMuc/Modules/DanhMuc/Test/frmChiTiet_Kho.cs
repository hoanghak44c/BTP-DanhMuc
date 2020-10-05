using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_Kho
    {
        #region TestUnit
        public void SetInput(string sTen, string sMaKho,string sMaKhoOracle, string sDiaChi, string sDienThoai, string sEmail,string sFax, string sGhiChu, int iSuDung)
        {
#if DEBUG
            txtTenKho.Text = sTen;
            txtMaKho.Text = sMaKho;
            txtMaKhoOracle.Text = sMaKhoOracle;
            txtDiaChi.Text = sDiaChi;
            txtDienThoai.Text = sDienThoai;
            txtEmail.Text = sEmail ;
            txtFax.Text = sFax;
            txtGhiChu.Text = sGhiChu;
            chkSuDung.Checked = iSuDung == 1;
#endif
        }

        public void TestSave()
        {
#if DEBUG
            SaveKho();
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
