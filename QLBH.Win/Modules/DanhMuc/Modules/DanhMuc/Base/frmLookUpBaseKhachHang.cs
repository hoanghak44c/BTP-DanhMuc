using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseKhachHang : frmLookUp_BaseNew_1<DMDoiTuongInfo>
    {
        private int idNhomDoiTuong = -1;

        public frmLookUpBaseKhachHang(){}

        public frmLookUpBaseKhachHang(string searchInput) : base(searchInput) { }

        public frmLookUpBaseKhachHang(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseKhachHang(bool isMultiSelect, string searchInput) : base(isMultiSelect,searchInput) { }

        public frmLookUpBaseKhachHang(bool isMultiSelect, string searchInput,int idNhomDoiTuong) : base(isMultiSelect, searchInput)
        {
            this.idNhomDoiTuong = idNhomDoiTuong;
        }

        protected override void OnLoad()
        {
            if (idNhomDoiTuong == -1)
            {
                ListInitInfo = DmDoiTuongProvider.GetListDmDoiTuongKhachHang();
            }
            else
            {
                ListInitInfo = DmDoiTuongProvider.GetDmDoiTuongByLoaiDT(idNhomDoiTuong);
            }                
        }
    }
}
