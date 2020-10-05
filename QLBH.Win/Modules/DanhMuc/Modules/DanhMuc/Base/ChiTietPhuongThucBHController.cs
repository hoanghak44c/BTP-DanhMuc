using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietPhuongThucBHController : ChiTietDmChungController<DMPhuongThucBanHangInfo>
    {
        public ChiTietPhuongThucBHController()
        {
            Provider = DMPhuongThucBHDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.Ma, dm.GhiChu, dm.SuDung);
        }

        protected override DMPhuongThucBanHangInfo GetFormInfo()
        {
            return new DMPhuongThucBanHangInfo
            {
                Ten = txtTen.Text.Trim(),
                Ma = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdPhuongThucBH = frmList.Oid
            };
        }
    }
}
