using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBasePhongBan : frmLookUp_BaseNew_1<DMPhongBanPairInfor>
    {
        public frmLookUpBasePhongBan(){}

        public frmLookUpBasePhongBan(string searchInput) : base(searchInput) { }

        public frmLookUpBasePhongBan(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBasePhongBan(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMPhongBanDataProvider.Instance.GetListPhongBanPairInfo();
        }

    }
}
