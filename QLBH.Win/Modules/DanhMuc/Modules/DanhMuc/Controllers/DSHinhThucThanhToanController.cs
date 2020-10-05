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
 public   class DSHinhThucThanhToanController:AppBaseTrustedController<IDSHinhThucThanhToanView >,IDSHinhThucThanhToanController
 {
    

     public DSHinhThucThanhToanController(IDSHinhThucThanhToanView view) : base(view)
     {
     }

     protected override void DisplayViewInfo()
     {
          View.DataSource= DmThanhToanDAO.Instance.GetListDmThanhToanInfo();
       
     }
     public void Search()
     {
         View.DataSource = DmThanhToanDAO.Instance.Search(new DMThanhToanInfor {Ma = View.Ma, Ten = View.Ten});
         
     }
     public void Add()
     {
         CTHinhThucThanhToanView.Instance.ShowDialog();
     }
     public void Edit()
     {
         CTHinhThucThanhToanView.CreateView(View.ItemRowHanle).ShowDialog();
     }
     public void Delete()
     {
         try
         {
             DmThanhToanDAO.Instance.Delete((DMThanhToanInfor)View.ItemRowHanle);
             View.ShowMessage("Xóa dữ liệu thành công !");
             View.DialogResult = DialogResult.OK;

         }
         catch (Exception ex )
         {
             
             throw new ManagedException(ex.Message);
         }
        
     }
     public void Exit()
     {
         View.Close();
     }
 }
}
