using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseMaLoi: frmLookUp_Base<DMMaLoiPairInfor>
    {
        public frmLookUpBaseMaLoi(){}

        public frmLookUpBaseMaLoi(string searchInput) : base(searchInput) { }

        public frmLookUpBaseMaLoi(bool isMultiSelect) : base(isMultiSelect) {}

        public frmLookUpBaseMaLoi(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMMaLoiDataProvider.GetListMaLoiPairInfor();
        }
    }
}
