using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
    public interface IDSChiPhiController
    {
        void Search();
        void Add();
        void Edit();
        void Delete();
        void Exit();

    }
}
