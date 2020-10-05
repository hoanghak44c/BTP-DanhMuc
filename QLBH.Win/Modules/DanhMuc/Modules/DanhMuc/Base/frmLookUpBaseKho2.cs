using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseKho2 : frmLookUp_BaseNew_1<DMKhoInfo>
    {
        private int idNhanVien;
        
        public frmLookUpBaseKho2(int idNhanVien)
        {
            this.idNhanVien = idNhanVien;
        }
        
        public frmLookUpBaseKho2(int idNhanVien, bool isMultiSelect) :base(isMultiSelect)
        {
            this.idNhanVien = idNhanVien;
        }

        protected override void OnLoad()
        {
            ListInitInfo = DMKhoDataProvider.GetListKhoInforByIdNhanVien2(idNhanVien);
        }
    }
}
