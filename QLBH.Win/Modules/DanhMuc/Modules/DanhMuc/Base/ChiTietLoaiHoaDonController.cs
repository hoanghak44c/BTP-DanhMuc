using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietLoaiHoaDonController : ChiTietDmChungController<DMLoaiHoaDonInfo>
    {
        public ChiTietLoaiHoaDonController()
        {
            Provider = DMLoaiHoaDonDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.KyHieu, dm.GhiChu, dm.SuDung);
        }

        protected override DMLoaiHoaDonInfo GetFormInfo()
        {
            return new DMLoaiHoaDonInfo
            {
                Ten = txtTen.Text.Trim(),
                KyHieu = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                Id = frmList.Oid
            };
        }
    }
}
