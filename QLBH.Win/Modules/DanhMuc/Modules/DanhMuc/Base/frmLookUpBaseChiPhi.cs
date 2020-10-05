using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseChiPhi : frmLookUp_BaseNew_1<DMChiPhiInfo>
    {
        public frmLookUpBaseChiPhi(){}

        public frmLookUpBaseChiPhi(string searchInput) : base(searchInput) { }

        public frmLookUpBaseChiPhi(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseChiPhi(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMChiPhiDataProvider.Instance.GetListChiPhiInfo();
        }

    }
}
