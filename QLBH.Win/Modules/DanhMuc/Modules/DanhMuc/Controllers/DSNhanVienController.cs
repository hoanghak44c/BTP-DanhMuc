using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
   public  class DSNhanVienController:AppBaseTrustedController<IDSNhanVienView>,IDSNhanVienController
   {
       //private List<DMNhanVienInfo> oDataSoure = null;
       public DSNhanVienController(IDSNhanVienView view) : base(view)
       {

       }

       protected override void DisplayViewInfo()
       {
           View.DataSource = DMNhanVienDAO.Instance.GetListNhanVienInfor();
           LoadPhongBan();
           LoadChucVu();
       }
       private  void LoadPhongBan()
       {
         View.PhongBanDataSource=  DmPhongBanDAO.Instance.GetAllPhongBan();
       }
       private void LoadChucVu()
       {
          View.ChucVuDataSource= DmChucVuDAO.Instance.GetAllChucVu();
       }
       public void Search()
       {
           View.DataSource = DMNhanVienDAO.Instance.Search(new DMNhanVienInfo {MaNhanVien = View.MaNhanVien,HoTen = View.TenNhanVien,IdPhongBan = View.IdPhongBan,IdChucVu = View.IdChucVu});
       }

       public void Add()
       {
           CTNhanVienView.Instance.ShowDialog();
       }
       public void Edit()
       {
           CTNhanVienView.CreateView(View.ItemRowHanle).ShowDialog();
       }
       public void Exit()
       {
           View.Close();
       }
       public void Delete()
       {
           try
           {
           DMNhanVienDAO.Instance.Delete((DMNhanVienInfo)View.ItemRowHanle);
           View.ShowMessage("Xóa dữ liệu thành công !");
           View.DialogResult = DialogResult.OK;
           }
           catch (Exception ex)
           {
               
               throw new ManagedException(ex.Message);
           }
          
       }
   }
}

