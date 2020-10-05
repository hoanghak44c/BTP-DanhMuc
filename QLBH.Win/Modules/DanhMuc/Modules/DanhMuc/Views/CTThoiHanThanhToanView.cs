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
    public class CTThoiHanThanhToanView:AppBaseView<CTThoiHanThanhToanController ,ICTThoiHanThanhToanController,FrmCTThoiHanThanhToan,ICTThoiHanThanhToanView >
    {
        protected CTThoiHanThanhToanView()
        {
            
        }
        protected CTThoiHanThanhToanView(object ItemRowHanle)
        {
            this.thuchiinfor = (DMLoaiThuChiInfor) ItemRowHanle;
        }

        public DMLoaiThuChiInfor thuchiinfor { get; set; }
    }
}
