using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseHang : frmLookUp_Base<SegmentInfo>
    {
        public frmLookUpBaseHang(){}

        public frmLookUpBaseHang(string searchInput) : base(searchInput) { }

        public frmLookUpBaseHang(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseHang(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DmHangDataProvider.Instance.GetListSegmentInfor();
        }

    }
}
