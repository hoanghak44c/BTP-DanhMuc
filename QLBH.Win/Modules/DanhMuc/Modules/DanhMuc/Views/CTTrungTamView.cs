using QLBanHang.Modules.DanhMuc.Controllers;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Form2;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Views
{
    public  class CTTrungTamView :AppBaseView<CTTrungTamController,ICTTrungTamController,FrmCtDmTrungTam,ICTTrungTamView>
    {
        protected CTTrungTamView()
        {
            
        }
        protected CTTrungTamView(object ItemRowHanle)
        {
            this.DMTrungTamInfo = (DMTrungTamInfor) ItemRowHanle;
        }

        public DMTrungTamInfor DMTrungTamInfo {  get; set; }
       
    }
}