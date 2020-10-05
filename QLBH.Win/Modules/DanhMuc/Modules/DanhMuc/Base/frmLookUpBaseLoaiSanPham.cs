using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseLoaiSanPham: frmLookUp_BaseNew<DMLoaiSanPhamInfo>
    {
        public frmLookUpBaseLoaiSanPham(){}

        public frmLookUpBaseLoaiSanPham(string searchInput) : base(searchInput) { }

        public frmLookUpBaseLoaiSanPham(bool isMultiSelect) : base(isMultiSelect) {}

        public frmLookUpBaseLoaiSanPham(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DMLoaiSanPhamDataProvider.GetLoaiSPInfor();
        }
    }
}
