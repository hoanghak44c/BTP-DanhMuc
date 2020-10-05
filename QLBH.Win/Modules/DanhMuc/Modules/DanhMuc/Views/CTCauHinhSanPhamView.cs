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
    public class CTCauHinhSanPhamView:AppBaseView<CTCauHinhSanPhamController,ICTCauHinhSanPhamController,FrmCTCauHinhSanPham,ICTCauHinhSanPhamView>
    {
        protected CTCauHinhSanPhamView()
        {
            
        }
        protected CTCauHinhSanPhamView(object ItemRowHanle)
        {
            this.cauhinhspinfo = (DMCauHinhSanPhamInfo) ItemRowHanle;
        }

        public DMCauHinhSanPhamInfo cauhinhspinfo { get; set; }
    }
}
