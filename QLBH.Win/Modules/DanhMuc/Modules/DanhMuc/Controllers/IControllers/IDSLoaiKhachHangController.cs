using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
    public interface IDSLoaiKhachHangController
    {
        void Add();
        void Search();
        void Edit();
        void Delete();
        void Exit();
    }
}
