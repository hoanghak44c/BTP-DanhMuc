using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseSanPham : frmLookUp_BaseNew_1<DMSanPhamInfo>
    {

        public frmLookUpBaseSanPham(){}

        public frmLookUpBaseSanPham(string searchInput) : base(searchInput) { }

        public frmLookUpBaseSanPham(bool isMultiSelect) : base(isMultiSelect) {}

        public frmLookUpBaseSanPham(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DmSanPhamProvider.GetListDmSanPhamInfo();
        }

        protected override string[] LookUpPropertyNames()
        {
            return new [] { "TenLoaiSP" };
        }
    }

    public class frmLookUpBaseSanPham_1 : frmLookUp_BaseNew_1<DMSanPhamInfo>
    {

        public frmLookUpBaseSanPham_1() { }

        public frmLookUpBaseSanPham_1(string searchInput) : base(searchInput) { }

        public frmLookUpBaseSanPham_1(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseSanPham_1(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        protected override void OnLoad()
        {
            ListInitInfo = DmSanPhamProvider.GetListDmSanPhamInfo();
        }

        protected override string[] LookUpPropertyNames()
        {
            return new[] { "TenLoaiSP" };
        }
    }
}
