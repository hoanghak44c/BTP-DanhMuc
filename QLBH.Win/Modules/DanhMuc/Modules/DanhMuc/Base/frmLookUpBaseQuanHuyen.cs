using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseQuanHuyen : frmLookUp_BaseNew_1<DMHuyenInfor>
    {
        private int idTinh = -1;
        public frmLookUpBaseQuanHuyen(){}

        public frmLookUpBaseQuanHuyen(string searchInput) : base(searchInput) { }

        public frmLookUpBaseQuanHuyen(string searchInput, int idTinh) : base(searchInput)
        {
            this.idTinh = idTinh;
        }

        public frmLookUpBaseQuanHuyen(bool isMultiSelect) : base(isMultiSelect) { }


        public frmLookUpBaseQuanHuyen(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        public frmLookUpBaseQuanHuyen(bool isMultiSelect, string searchInput, int idTinh) : base(isMultiSelect, searchInput)
        {
            this.idTinh = idTinh;
        }

        protected override void OnLoad()
        {
            ListInitInfo = DMHuyenDataProvider.Instance.GetListHuyenByTinhInfors(idTinh);
        }

    }
}
