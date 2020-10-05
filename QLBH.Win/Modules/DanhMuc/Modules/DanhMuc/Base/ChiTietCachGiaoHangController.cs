using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietCachGiaoHangController : ChiTietDmChungController<DMCachGiaoHangInfo>
    {
        public ChiTietCachGiaoHangController()
        {
            Provider = DMCachGiaoHangDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.Ma, dm.GhiChu, dm.SuDung);
        }

        protected override DMCachGiaoHangInfo GetFormInfo()
        {
            return new DMCachGiaoHangInfo
            {
                Ten = txtTen.Text.Trim(),
                Ma = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdCachGiaoHang = frmList.Oid
            };
        }
    }
}
