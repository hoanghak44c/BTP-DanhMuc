using System;
using System.Collections.Generic;
using System.Text;

// <Remarks>
// form frmChiTiet_the
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 28/05/2012
// Ngày sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc
{
    public partial class frmChiTiet_The
    {
        #region TestUnit
        public void SetInput(string sTen, string sMa, int iTichLuyTu, int iTichLuyDen, int iGiaTriMuaLanDau,int iBaoLuuDiem, int iTinhNangKhac,int iHieuLuc)
        {
#if DEBUG
            txtTenThe.Text = sTen;
            txtMaThe.Text = sMa;
            txtTichLuyTu.Text = Convert.ToString(iTichLuyTu);
            txtTichLuyDen.Text= Convert.ToString(iTichLuyDen) ;
            txtGiaTriMuaLanDau.Text = Convert.ToString(iGiaTriMuaLanDau);
            txtBaoLuuDiem.Text = Convert.ToString(iBaoLuuDiem);
            txtTinhNangKhac.Text =Convert.ToString(iTinhNangKhac);
            txtHieuLuc.Text =Convert.ToString(iHieuLuc);
#endif
        }

        public void TestSave()
        {
#if DEBUG
            SaveLoaiThe();
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
