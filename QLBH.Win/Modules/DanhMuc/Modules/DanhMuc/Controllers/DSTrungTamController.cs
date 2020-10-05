using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;
using QLBH.Core.Exceptions;
using QLBH.Core.Interfaces;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Views;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
   public  class DSTrungTamController:AppBaseTrustedController<IDSTrungTamView>,IDSTrungTamController
   {
       
       //private List<DMTrungTamInfor> oDataSource = null;// khai báo list dữ liệu đổ vào datagrid
       public DSTrungTamController(IDSTrungTamView view) : base(view)
       {
       }
       protected override void DisplayViewInfo()
       {

           View.DataSource = DmTrungTamDAO.Instance.GetAllTrungTam();
           
       }
       
       

       public void TimKiem()
       {
      
           View.DataSource = DmTrungTamDAO.Instance.Search(new DMTrungTamInfor{MaTrungTam = View.MaTrungTam,TenTrungTam = View.TenTrungTam});
       }


       public void Edit()
       {
           CTTrungTamView.CreateView(View.ItemRowHanle).ShowDialog();
       }
       public void Exit()
       {
           View.Close();
       }
       public void Delete()
       {
           try
           {
               DmTrungTamDAO.Instance.Delete((DMTrungTamInfor)View.ItemRowHanle);
               View.ShowMessage("Xóa dữ liệu thành công!");
               View.RefreshDataSource();
           }
           catch (Exception ex)
           {
               
               throw new ManagedException(ex.Message);
           }
           
       }
   }
}
