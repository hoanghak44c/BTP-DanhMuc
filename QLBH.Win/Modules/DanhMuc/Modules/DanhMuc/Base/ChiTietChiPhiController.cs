using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietChiPhiController : ChiTietDmChungController<DMChiPhiInfo>
    {
        public ChiTietChiPhiController()
        {
            Provider = DMChiPhiDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.Ma, dm.GhiChu, dm.SuDung);
        }

        protected override DMChiPhiInfo GetFormInfo()
        {
            return new DMChiPhiInfo
            {
                Ten = txtTen.Text.Trim(),
                Ma = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdChiPhi = frmList.Oid
            };
        }
    }
}
