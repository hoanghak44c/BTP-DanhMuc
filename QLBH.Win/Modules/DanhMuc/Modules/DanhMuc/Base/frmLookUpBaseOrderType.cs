using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseOrderType : frmLookUp_BaseNew<DMOrderTypeInfor>
    {
        public frmLookUpBaseOrderType(){}

        public frmLookUpBaseOrderType(string searchInput) : base(searchInput) { }

        public frmLookUpBaseOrderType(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseOrderType(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMOrderTypeProvider.GetListOrderTypeInfor();                
        }

        protected override string[] LookUpPropertyNames()
        {
            return new[] {"Name"};
        }
    }
}
