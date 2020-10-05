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
   public class CTLoaiKhachHangView:AppBaseView<CTLoaiKhachHangController,ICTLoaiKhachHangController,FrmCTLoaiKhachHang,ICTLoaiKhachHangView>
   {
       protected CTLoaiKhachHangView()
       {
           
       }
       protected CTLoaiKhachHangView(object ITemRowHanle)
       {
           this.LoaiKhachHangInfor = (DmLoaiDoiTuongInfor) ITemRowHanle;
       }

       public DmLoaiDoiTuongInfor LoaiKhachHangInfor { get; set; }

    }
}
