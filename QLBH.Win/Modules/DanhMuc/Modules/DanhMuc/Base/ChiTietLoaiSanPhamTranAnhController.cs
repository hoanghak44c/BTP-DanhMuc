using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietLoaiSanPhamTranAnhController : ChiTietDmChungController<DMLoaiSanPhamInfo>
    {
        public ChiTietLoaiSanPhamTranAnhController()
        {
            Provider = DMLoaiSanPhamDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenLoaiSP, dm.MaLoaiSP, dm.GhiChu, dm.SuDung);
        }

        protected override DMLoaiSanPhamInfo GetFormInfo()
        {
            return new DMLoaiSanPhamInfo
            {
                TenLoaiSP = txtTen.Text.Trim(),
                MaLoaiSP = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdLoaiSP = frmList.Oid
            };
        }
    }
}
