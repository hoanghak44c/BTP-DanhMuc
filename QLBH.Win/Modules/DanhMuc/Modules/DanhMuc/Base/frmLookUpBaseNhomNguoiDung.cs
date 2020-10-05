using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBanHang.Modules.HeThong.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseNhomNguoiDung : frmLookUp_BaseNew_1<DMNhomNguoiDungInfor>
    {
        public frmLookUpBaseNhomNguoiDung(){}

        public frmLookUpBaseNhomNguoiDung(string searchInput) : base(searchInput) { }

        public frmLookUpBaseNhomNguoiDung(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseNhomNguoiDung(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

    }
}
