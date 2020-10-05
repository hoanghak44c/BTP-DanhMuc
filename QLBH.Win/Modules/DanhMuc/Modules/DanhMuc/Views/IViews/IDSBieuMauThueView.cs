using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBH.Core.Interfaces;

namespace QLBanHang.Modules.DanhMuc.Views.IViews
{
    public interface IDSBieuMauThueView:IBaseView<IDSBieuMauThueController>
    {
        object DataSource { get; set; }
        object ItemRowHanle {  get; }
        string MaTaxCode { get; }
        string TenTaxCode { get; }
        void RefreshDataSource();
    }
}
