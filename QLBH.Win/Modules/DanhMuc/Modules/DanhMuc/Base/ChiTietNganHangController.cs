using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietNganHangController : ChiTietDmChungController<DMNganHangInfor>
    {
        public ChiTietNganHangController()
        {
            Provider = DMNganHangDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenNganHang, dm.MaNganHang, dm.GhiChu, dm.SuDung);
        }

        protected override DMNganHangInfor GetFormInfo()
        {
            return new DMNganHangInfor
            {
                TenNganHang = txtTen.Text.Trim(),
                MaNganHang = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdNganHang = frmList.Oid
            };
        }
    }
}
