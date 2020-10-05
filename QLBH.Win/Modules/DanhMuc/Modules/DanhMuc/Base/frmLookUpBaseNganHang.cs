using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseNganHang : frmLookUp_BaseNew_1<DMNganHangInfor>
    {
        public frmLookUpBaseNganHang(){}

        public frmLookUpBaseNganHang(string searchInput) : base(searchInput) { }

        public frmLookUpBaseNganHang(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseNganHang(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMNganHangDataProvider.Instance.GetListNganHangInfors();
        }
    }
}
