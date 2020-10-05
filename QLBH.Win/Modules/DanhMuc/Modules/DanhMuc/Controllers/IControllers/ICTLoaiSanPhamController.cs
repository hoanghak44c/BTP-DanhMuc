using System;
using System.Collections.Generic;
using System.Text;

namespace QLBanHang.Modules.DanhMuc.Controllers.IControllers
{
   public interface ICTLoaiSanPhamController
   {
       void Save();
       void Exit();
       void ChoseNganh();
       void ChoseChung();
       void ChoseHang();
       void ChoseLinhVuc();
       void ChoseLoai();
       void ChoseNhom();
       void ChoseModel();
   }
}
