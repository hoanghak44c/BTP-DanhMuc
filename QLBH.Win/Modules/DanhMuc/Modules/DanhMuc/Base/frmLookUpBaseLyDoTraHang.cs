using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseLyDoTraHang : frmLookUp_BaseNew_1<DMLyDoTraHangInfo>
    {
        public frmLookUpBaseLyDoTraHang(){}

        public frmLookUpBaseLyDoTraHang(string searchInput) : base(searchInput) { }

        public frmLookUpBaseLyDoTraHang(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseLyDoTraHang(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

    }
}
