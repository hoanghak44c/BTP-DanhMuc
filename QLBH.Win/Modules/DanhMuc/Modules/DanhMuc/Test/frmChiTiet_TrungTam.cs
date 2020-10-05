using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_TrungTam
    {
        #region TestUnit Function

        public void SetInput(string sTen, string sMa, string sDiaChi, string sDienThoai, string sEmail, string sFax, string sMota, int iSudung)
        {
#if DEBUG
            txtTenTrungTam.Text = sTen;
            txtMaTrungTam.Text = sMa;
            txtDiaChi.Text = sDiaChi;
            txtDienThoai.Text = sDienThoai;
            txtEmail.Text = sEmail;
            txtFax.Text = sFax;
            txtGhiChu.Text = sMota;
            chkSuDung.Checked = iSudung == 1;
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
    }
}
