using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietBangKeThueController : ChiTietDmChungController<DMBangKeThueInfo>
    {
        public ChiTietBangKeThueController()
        {
            Provider = DMBangKeThueDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.KyHieu, dm.GhiChu, dm.SuDung);
        }

        protected override DMBangKeThueInfo GetFormInfo()
        {
            return new DMBangKeThueInfo
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
