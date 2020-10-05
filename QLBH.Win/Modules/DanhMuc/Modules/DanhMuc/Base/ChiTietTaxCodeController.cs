using System;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietTaxCodeController : ChiTietDmChungController<DMTaxCodeInfor>
    {
        public ChiTietTaxCodeController()
        {
            Provider = DMTaxCodeDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.Name, dm.Code, dm.GhiChu, dm.SuDung);
        }
        
        protected override DMTaxCodeInfor GetFormInfo()
        {
            return new DMTaxCodeInfor
                       {
                           IdTaxCode = frmList.Oid,
                           Code = txtMa.Text.Trim(),
                           Name = txtTen.Text.Trim(),
                           GhiChu = txtMoTa.Text.Trim(),
                           SuDung = Convert.ToInt32(chkSuDung.Checked),
                       };
        }
    }
}
