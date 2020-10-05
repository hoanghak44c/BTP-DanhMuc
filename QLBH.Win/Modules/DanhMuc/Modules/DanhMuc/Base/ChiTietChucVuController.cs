using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietChucVuController : ChiTietDmChungController<DMChucVuInfor>
    {
        public ChiTietChucVuController()
        {
            Provider = DMChucVuDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenChucVu, dm.MaChucVu, dm.GhiChu, dm.SuDung);
        }

        protected override DMChucVuInfor GetFormInfo()
        {
            return new DMChucVuInfor
            {
                TenChucVu = txtTen.Text.Trim(),
                MaChucVu = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdChucVu = frmList.Oid
            };
        }

        
    }
}
