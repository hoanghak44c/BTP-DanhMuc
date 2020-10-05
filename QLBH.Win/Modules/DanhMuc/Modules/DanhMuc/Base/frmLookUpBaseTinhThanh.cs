using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseTinhThanh : frmLookUp_BaseNew_1<DMTinhInfor>
    {
        public frmLookUpBaseTinhThanh(){}

        public frmLookUpBaseTinhThanh(string searchInput) : base(searchInput) { }

        public frmLookUpBaseTinhThanh(bool isMultiSelect) : base(isMultiSelect) { }


        public frmLookUpBaseTinhThanh(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMTinhDataProvider.Instance.GetListTinhInfors();
        }
    }
}
