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
  public  class DSOrderTypeController:AppBaseTrustedController<IDSOrderTypeView >,IDSOrderTypeController
  {
      //private List<DMOrderTypeInfor> oDataSource = null;
      public DSOrderTypeController(IDSOrderTypeView view) : base(view)
      {
      }

      protected override void DisplayViewInfo()
      {
                  View.DataSource = DmOrderTypeDAO.Instance.GetListOrderTypeInfor();
         
      }
      public void Search()
      {
          View.DataSource=DmOrderTypeDAO.Instance.Search(new DMOrderTypeInfor{OrderType = View.MaOrderType,Name  =View.TenOrderType});
      }
      public void Add()
      {
          CTOrderTypeView.Instance.ShowDialog();
      }
      public void Edit()
      {
          CTOrderTypeView.CreateView(View.ItemRowHanle).ShowDialog();
      }

      public void Exit()
      {
          View.Close();
      }

      public void Delete()
      {
          try
          {
              DmOrderTypeDAO.Instance.Delete((DMOrderTypeInfor)View.ItemRowHanle);
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
