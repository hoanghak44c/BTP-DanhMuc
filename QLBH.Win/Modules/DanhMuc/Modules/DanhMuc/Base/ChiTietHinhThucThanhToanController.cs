using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietHinhThucThanhToanController : ChiTietDmChungController<DMThanhToanInfor>
    {
        public ChiTietHinhThucThanhToanController()
        {
            Provider = DMThanhToanDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Ten, dm.Ma, dm.GhiChu, dm.SuDung);
        }

        protected override DMThanhToanInfor GetFormInfo()
        {
            return new DMThanhToanInfor
            {
                Ten = txtTen.Text.Trim(),
                Ma = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdThanhToan = frmList.Oid
            };
        }
    }
}
