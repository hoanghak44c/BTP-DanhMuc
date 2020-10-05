using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Form2;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Views
{
    public class DSNhanVienView:AppBaseView<DSNhanVienController,IDSNhanVienController,frmDmNhanVien,IDSNhanVienView>
    {
        protected DSNhanVienView()
        {}

        protected DSNhanVienView(object ItemRowHanle)
        {
            this.NhanVienInfor = (DMNhanVienInfo) ItemRowHanle;
        }

        public DMNhanVienInfo NhanVienInfor { get; set; }
    }
}
