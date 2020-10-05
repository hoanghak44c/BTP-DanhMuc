using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
   public class DSChucVuController:AppBaseTrustedController<IDSChucVuView>,IDSChucVuController
   {
       
       public DSChucVuController(IDSChucVuView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           View.DataSource = DmChucVuDAO.Instance.GetListChucVuInfo();
          
       }
       public void Add()
       {
           CTChucVuView.Instance.ShowDialog();
       }
       public void Edit()
       {
           CTChucVuView.CreateView(View.ItemRowHanle).ShowDialog();
       }
       public void Search()
       {
           View.DataSource = DmChucVuDAO.Instance.Search(new DMChucVuInfor{MaChucVu = View.MaChucVu,TenChucVu = View.TenChucVu});
       }
       public void Exit()
       {
           View.Close();
       }
       public void Delete()
       {
           try
           {
               DmChucVuDAO.Instance.Delete((DMChucVuInfor)View.ItemRowHanle);
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
