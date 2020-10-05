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
    public class CTDuAnView:AppBaseView<CTDuAnController ,ICTDuAnController,FrmCTDuAn,ICTDuAnView >
    {
        protected CTDuAnView()
        {
            
        }
        protected CTDuAnView(object ItemRowHanle)
        {
            this.duaninfor = (DMDuAnInfor) ItemRowHanle;

        }

        public DMDuAnInfor duaninfor { get; set; }
    }
}
