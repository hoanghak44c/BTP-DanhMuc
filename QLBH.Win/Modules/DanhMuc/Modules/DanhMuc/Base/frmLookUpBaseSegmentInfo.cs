using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseSegmentInfo : frmLookUp_BaseNew_1<SegmentInfo>
    {
        public frmLookUpBaseSegmentInfo(){}

        public frmLookUpBaseSegmentInfo(string searchInput) : base(searchInput) { }

        public frmLookUpBaseSegmentInfo(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseSegmentInfo(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

    }
}
