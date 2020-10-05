using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Interfaces;
using QLBanHang.Modules.DanhMuc.Form2;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Views
{
    public class CTPhongBanView:AppBaseView <CTPhongBanController,ICTPhongBanController,FrmCtPhongBan,ICTPhongBanView >
    {
        protected CTPhongBanView()
        {
            
        }
        protected CTPhongBanView(object ItemRowHanle)
        {
            this.PhongBanInfor = (DMPhongBanInfor)ItemRowHanle;
        }

        public DMPhongBanInfor PhongBanInfor { get; set; }
        
    }
}
