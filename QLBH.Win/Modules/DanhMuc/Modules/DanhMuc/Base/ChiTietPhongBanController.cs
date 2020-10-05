using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class ChiTietPhongBanController : ChiTietDmChungController<DMPhongBanInfor>
    {
        public ChiTietPhongBanController()
        {
            Provider = DMPhongBanDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenPhongBan, dm.MaPhongBan, dm.GhiChu, dm.SuDung);
        }

        protected override DMPhongBanInfor GetFormInfo()
        {
            return new DMPhongBanInfor
            {
                TenPhongBan = txtTen.Text.Trim(),
                MaPhongBan = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdPhongBan = frmList.Oid
            };
        }
    }

    public class ChiTietPhongBanController1 : ChiTietDmChungController1<DMPhongBanInfor>
    {
        public ChiTietPhongBanController1()
        {
            Provider = DMPhongBanDataProvider.Instance;
        }

        protected override void SetFormInfo()
        {
            SetFormInfo(dm.TenPhongBan, dm.MaPhongBan, dm.GhiChu, dm.SuDung);
        }

        protected override DMPhongBanInfor GetFormInfo()
        {
            return new DMPhongBanInfor
            {
                TenPhongBan = txtTen.Text.Trim(),
                MaPhongBan = txtMa.Text.Trim(),
                GhiChu = txtMoTa.Text.Trim(),
                SuDung = Convert.ToInt32(chkSuDung.Checked),
                IdPhongBan = frmList.Oid
            };
        }
    }
}
