using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseThoiHanTToan : frmLookUp_BaseNew<DMLoaiThuChiInfor>
    {
        public frmLookUpBaseThoiHanTToan(){}

        public frmLookUpBaseThoiHanTToan(string searchInput) : base(searchInput) { }

        public frmLookUpBaseThoiHanTToan(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseThoiHanTToan(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMLoaiThuChiDataProvider.GetListLoaiThuChiInfor();
        }
    }
}
