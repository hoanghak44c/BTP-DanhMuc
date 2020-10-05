using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietLyDoTraHangController : ChiTietDmChungController<DMLyDoTraHangInfo>
    {
        public ChiTietLyDoTraHangController()
        {
            Provider = DMLyDoTraHangDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.MaLyDo, dm.GhiChu, dm.SuDung);
        }

        protected override DMLyDoTraHangInfo GetFormInfo()
        {
            return new DMLyDoTraHangInfo
            {
                Ten = txtTen.Text.Trim(),
                MaLyDo = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdLyDoTH = frmList.Oid
            };
        }
    }
}
