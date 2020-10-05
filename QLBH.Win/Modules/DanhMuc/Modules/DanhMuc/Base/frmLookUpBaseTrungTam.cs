using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseTrungTam : frmLookUp_BaseNew<DMTrungTamInfor>
    {
        private int idNhanVien = -1;
        private int baoHanh = -1;//trung tam bao hanh
        public frmLookUpBaseTrungTam(){}

        public frmLookUpBaseTrungTam(string searchInput) : base(searchInput) { }

        public frmLookUpBaseTrungTam(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseTrungTam(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        public frmLookUpBaseTrungTam(bool isMultiSelect, string searchInput, int idNhanVien) : base(isMultiSelect, searchInput)
        {
            this.idNhanVien = idNhanVien;
        }

        public frmLookUpBaseTrungTam(bool isMultiSelect, string searchInput, int idNhanVien, int baoHanh)
            : base(isMultiSelect, searchInput)
        {
            this.idNhanVien = idNhanVien;
            this.baoHanh = baoHanh;
        }

        protected override void OnLoad()
        {
            if (idNhanVien == -1)
            {
                ListInitInfo = DMTrungTamDataProvider.GetListTrungTamInfo(baoHanh);    
            }
            else
            {
                ListInitInfo = DMTrungTamDataProvider.GetListTrungTamInfoByIdNhanVien(idNhanVien, baoHanh);
            }
        }
    }
}
