using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseTaiKhoanQuy : frmLookUp_BaseNew_1<DMTaiKhoanQuyInfo>
    {
        private int idTrungTam = -1;

        public frmLookUpBaseTaiKhoanQuy(){}

        public frmLookUpBaseTaiKhoanQuy(string searchInput) : base(searchInput) { }

        public frmLookUpBaseTaiKhoanQuy(string searchInput, int idTrungTam) : base(searchInput)
        {
            this.idTrungTam = idTrungTam;
        }

        public frmLookUpBaseTaiKhoanQuy(bool isMultiSelect) : base(isMultiSelect) { }


        public frmLookUpBaseTaiKhoanQuy(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        public frmLookUpBaseTaiKhoanQuy(bool isMultiSelect, string searchInput, int idTrungTam)
            : base(isMultiSelect, searchInput)
        {
            this.idTrungTam = idTrungTam;
        }

        protected override void OnLoad()
        {
            ListInitInfo = DMTaiKhoanQuyDataProvider.Instance.GetListTaiKhoanQuyByTrungTam(idTrungTam);
        }

    }
}
