using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseKhoDieuChuyen : frmLookUpBaseKho
    {
        public frmLookUpBaseKhoDieuChuyen(int idNhanVien)
        {
            this.idNhanVien = idNhanVien;
        }

        public frmLookUpBaseKhoDieuChuyen(int idNhanVien, bool isMultiSelect)
            : base(isMultiSelect)
        {
            this.idNhanVien = idNhanVien;
        }

        protected override void OnLoad()
        {
            ListInitInfo = DMKhoDataProvider.GetListKhoInforByIdNhanVien2(idNhanVien);
        }
    }
}
