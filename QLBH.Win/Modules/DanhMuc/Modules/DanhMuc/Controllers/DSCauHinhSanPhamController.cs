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
   public class DSCauHinhSanPhamController:AppBaseTrustedController<IDSCauHinhSanPhamView>,IDSCauHinhSanPhamController
   {
       private List<DMCauHinhSanPhamInfo> oDataSource = null;
       public DSCauHinhSanPhamController(IDSCauHinhSanPhamView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           oDataSource = DmCauHinhSanPhamDAO.Instance.GetListCauHinhSanPham();
           View.DataSource = oDataSource;
           LoadTon();
       }
       private void LoadTon()
       {
           List<LookUpInfor> listTon=new List<LookUpInfor>();
           listTon.Add(new LookUpInfor {ID = 1,Name = "Có tồn"});
           listTon.Add(new LookUpInfor{ID=0,Name = "Không có tồn "});
           View.TrangThaiTon = listTon;
       }
       public void SearchCoTon()
       {
           View.DataSource =
               DmCauHinhSanPhamDAO.Instance.GetListSearchCauHinhSanPhamCo(View.IdTon);
       }
       public void SearchKhongTon()
       {
           View.DataSource = DmCauHinhSanPhamDAO.Instance.GetListSearchCauHinhSanPhamKhong(View.IdTon);
       }
       public void Add()
       {
           CTCauHinhSanPhamView.Instance.ShowDialog();
       }
       public void Edit()
       {
           CTCauHinhSanPhamView.CreateView(View.ItemRowHanle).ShowDialog();
       }
       public void Delete()
       {
           try
           {
               DmCauHinhSanPhamDAO.Instance.Delete((DMCauHinhSanPhamInfo)View.ItemRowHanle);
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
