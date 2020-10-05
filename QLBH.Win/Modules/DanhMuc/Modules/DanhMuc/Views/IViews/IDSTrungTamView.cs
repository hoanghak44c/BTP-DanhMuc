using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{

    public interface IDSTrungTamView:IBaseView<IDSTrungTamController>
    {
        object DataSource { get; set; }
        object ItemRowHanle { get; }
        string TenTrungTam { get;  }
        string MaTrungTam { get;  }
        void RefreshDataSource();
     
    }
}
