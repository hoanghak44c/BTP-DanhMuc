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
   public class DSLoaiKhachHangController:AppBaseTrustedController<IDSLoaiKhachHangView>,IDSLoaiKhachHangController
   {
       
       public DSLoaiKhachHangController(IDSLoaiKhachHangView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           View.DataSource= DmLoaiDoiTuongDAO.Instance.GetListLoaiDoiTuongInfor();
           

       }
       public void Search()
       {
           View.DataSource =
               DmLoaiDoiTuongDAO.Instance.Search(new DmLoaiDoiTuongInfor {MaLoaiDT = View.TenLoaiKhachHang});
       }
       public void Add()
       {
           CTLoaiKhachHangView.Instance.ShowDialog();
       }
       public void Edit()
       {
           CTLoaiKhachHangView.CreateView(View.ItemRowHanle).ShowDialog();
       }
       public void Delete()
       {
           try
           {
               DmLoaiDoiTuongDAO.Instance.Delete((DmLoaiDoiTuongInfor)View.ItemRowHanle);
               View.ShowMessage("Xóa dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;

           }
           catch (Exception ex)
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
