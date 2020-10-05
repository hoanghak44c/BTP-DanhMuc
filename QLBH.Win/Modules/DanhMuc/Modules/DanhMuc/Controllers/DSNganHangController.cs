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
   public class DSNganHangController:AppBaseTrustedController<IDSNganHangView >,IDSNganHangController
   {
       //private List<DMNganHangInfor> oDataSource = null;

       public DSNganHangController(IDSNganHangView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
          View.DataSource = DmNganHangDAO.Instance.GetListNganHangInfors();
  


       }
       public void Search()
       {
           View.DataSource =
               DmNganHangDAO.Instance.Search(new DMNganHangInfor {MaNganHang = View.Ma, TenNganHang = View.Ten});

       }
       public void Add()
       {
           CTNganHangView.Instance.ShowDialog();
       }
       public void Edit()
       {
           CTNganHangView.CreateView(View.ItemRowHanle).ShowDialog();
       }
       public void Exit()
       {
           View.Close();
       }
       public void Delete()
       {
           try
           {
               DmNganHangDAO.Instance.Delete((DMNganHangInfor)View.ItemRowHanle);
               View.ShowMessage("xóa dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;

           }
           catch (Exception ex)
           {
               
               throw new ManagedException(ex.Message);
           }
           
       }
   }
}
