using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
    public interface ICTDoiTuongController
    {
        void Save();
        void Exit();
        void  GetDiaChiHoaDonByMaDoiTuong();
        void ChoseDTCha();
        void ChoseOrderType();
    }
}
