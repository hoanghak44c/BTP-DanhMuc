using System;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietDonViTinhController : ChiTietDmChungController<DMDonViTinhInfor>
    {
        public ChiTietDonViTinhController()
        {
            Provider = DmDonViTinhProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenDonViTinh, dm.KyHieu, dm.GhiChu, dm.SuDung);
        }

        protected override DMDonViTinhInfor GetFormInfo()
        {
            return new DMDonViTinhInfor
            {
                TenDonViTinh = txtTen.Text.Trim(),
                KyHieu = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdDonViTinh = frmList.Oid
            };
        }
    }
}
