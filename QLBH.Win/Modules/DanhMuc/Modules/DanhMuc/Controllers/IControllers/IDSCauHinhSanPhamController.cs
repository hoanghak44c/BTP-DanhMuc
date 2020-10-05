using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
    public interface IDSCauHinhSanPhamController
    {
        void SearchCoTon();
        void SearchKhongTon();
        void Add();
        void Edit();
        void Delete();
        void Exit();

    }
}
