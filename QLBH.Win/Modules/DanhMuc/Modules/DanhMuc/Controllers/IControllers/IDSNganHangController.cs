using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
    public interface IDSNganHangController
    {
        void Search();
        void Add();
        void Edit();
        void Delete();
        void Exit();

    }
}
