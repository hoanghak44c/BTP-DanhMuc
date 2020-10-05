using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
    public interface IDSNhanVienController
    {
        void Add();
        void Edit();
        //List<DMNhanVienInfo> Search(DMNhanVienInfo match);
        void Search();
        void Delete();
        void Exit();

    }
}
