using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietDuAnController : ChiTietDmChungController<DMDuAnInfor>
    {
        public ChiTietDuAnController()
        {
            Provider = DMDuAnDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenDuAn, dm.MaDuAn, dm.GhiChu, dm.SuDung);
        }

        protected override DMDuAnInfor GetFormInfo()
        {
            return new DMDuAnInfor
            {
                TenDuAn = txtTen.Text.Trim(),
                MaDuAn = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdDuAn = frmList.Oid
            };
        }
    }
}
