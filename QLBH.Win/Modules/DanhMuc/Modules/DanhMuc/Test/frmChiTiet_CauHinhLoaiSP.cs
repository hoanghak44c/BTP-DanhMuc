using System;
using System.Collections.Generic;
using System.Text;

// <Remarks>
// form frmChiTiet_CauHinhLoaiSP
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_CauHinhLoaiSP
    {
        #region TestUnit
        public void SetInput(string sTen, string sMa, string sMota, int iSudung, string LoaiSP)
        {
#if DEBUG
            txtTenLoi.Text = sTen;
            txtMaLoi.Text = sMa;
            txtGhiChu.Text = sMota;
            cbSuDung.Checked = iSudung == 1;
            txtLoaiSanPham.Text = LoaiSP;
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
        public void TestCheck()
        {
#if DEBUG
            check();
#endif
        }
        #endregion
    }
}
