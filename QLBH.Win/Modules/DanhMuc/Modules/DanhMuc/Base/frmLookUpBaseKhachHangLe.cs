using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseKhachHangLe : frmLookUp_Base<DMDoiTuongInfo>
    {
        public frmLookUpBaseKhachHangLe(){}

        public frmLookUpBaseKhachHangLe(bool isMultiSelect) : base(isMultiSelect) { }

        protected override void OnLoad()
        {
            ListInitInfo = DmDoiTuongProvider.GetListDmDoiTuongInfoEx();
        }
    }
}
