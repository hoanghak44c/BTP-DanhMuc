using System;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietChucNangController : ChiTietDmChungController<DMChucNangInfor>
    {
        public ChiTietChucNangController()
        {
            Provider = DMChucNangDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenChucNang, dm.MaChucNang, dm.GhiChu, dm.SuDung);
        }

        protected override DMChucNangInfor GetFormInfo()
        {
            return new DMChucNangInfor
            {
                TenChucNang = txtTen.Text.Trim(),
                MaChucNang = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdChucNang = frmList.Oid
            };
        }
    }
}
