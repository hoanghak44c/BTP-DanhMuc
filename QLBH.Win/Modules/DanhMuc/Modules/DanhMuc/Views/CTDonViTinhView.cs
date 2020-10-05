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
    public class CTDonViTinhView:AppBaseView<CTDonViTinhController,ICTDonViTinhController,FrmCTDonViTinh,ICTDonViTinhView>
    {
        protected CTDonViTinhView()
        {
            
        }
        protected CTDonViTinhView(object ItemRowHanle)
        {
            this.DonViTinhInfor = (DMDonViTinhInfor) ItemRowHanle;
        }

        public DMDonViTinhInfor DonViTinhInfor { get; set; }
    }
}
