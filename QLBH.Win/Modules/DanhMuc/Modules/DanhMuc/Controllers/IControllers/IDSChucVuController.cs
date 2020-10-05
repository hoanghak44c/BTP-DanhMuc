using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
    public interface IDSChucVuController
    {
        void Search();
        void Add();
        void Edit();
        void Exit();
        void Delete();
    }
}
