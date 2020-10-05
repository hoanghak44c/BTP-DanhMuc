using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Base;
using QLBanHang.Modules.DanhMuc.Controllers;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Form2;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public class CTChucVuView:AppBaseView<CTChucVuController,ICTChucVuController,FrmCtChucVu,ICTChucVuView>
    {
        protected CTChucVuView()
        {}
        protected CTChucVuView(object ItemRowHanle)
        {
            this.ChucVuInfor = (DMChucVuInfor) ItemRowHanle;
        }

        public DMChucVuInfor ChucVuInfor { get; set; }
    }
}
