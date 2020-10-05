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
    public class CTDoiTuongView:AppBaseView<CTDoiTuongController,ICTDoiTuongController,FrmCTDoiTuongKhachHang,ICTDoiTuongView>
    {
      protected CTDoiTuongView()
        {
            
        }
        protected CTDoiTuongView(object ItemRowHanle)
        {
            this.dmDoiTuongInfo = (DMDoiTuongInfo)ItemRowHanle;
           
        }

        public DMDoiTuongInfo dmDoiTuongInfo { get; set; }
      
       
    }
}
