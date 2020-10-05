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

namespace QLBanHang.Modules.DanhMuc.Controllers
{
   public class CTCachGiaoHangController:AppBaseTrustedController<ICTCachGiaoHangView>,ICTCachGiaoHangController

   {
       private DMCachGiaoHangInfo _objcachgiaohang=new DMCachGiaoHangInfo();
       public CTCachGiaoHangController(ICTCachGiaoHangView view) : base(view)
       {
       
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();

       }
       private void GetData()
       {
           _objcachgiaohang = View._cachgiaohanginfo;

       }
       private void LoadDataSource()
       {
          if(_objcachgiaohang!=null)
          {
              View.IdCachGiaoHang = _objcachgiaohang.IdCachGiaoHang;
              View.Ma = _objcachgiaohang.Ma;
              View.Ten = _objcachgiaohang.Ten;
              View.GhiChu = _objcachgiaohang.GhiChu;
              View.SuDung = _objcachgiaohang.SuDung;
          }

       }
       public void Insert()
       {
           if(_objcachgiaohang==null)
           {
              _objcachgiaohang=new DMCachGiaoHangInfo();
               _objcachgiaohang.Ma = View.Ma;
               _objcachgiaohang.Ten = View.Ten;
               _objcachgiaohang.GhiChu = View.GhiChu;
               _objcachgiaohang.SuDung = View.SuDung;
               _objcachgiaohang.IdCachGiaoHang = DmCachGiaoHangDAO.Instance.Insert(_objcachgiaohang);
               ((List<DMCachGiaoHangInfo>)DSCachGiaoHangView.Instance.DataSource).Add(_objcachgiaohang);
               DSCachGiaoHangView.Instance.RefreshDataSource();
           }

       }
       public void Update()
       {
           _objcachgiaohang.IdCachGiaoHang = View.IdCachGiaoHang;
           _objcachgiaohang.Ma = View.Ma;
           _objcachgiaohang.Ten = View.Ten;
           _objcachgiaohang.GhiChu = View.GhiChu;
           _objcachgiaohang.SuDung = View.SuDung;
           DmCachGiaoHangDAO.Instance.Update(_objcachgiaohang);
           ((List<DMCachGiaoHangInfo>)DSCachGiaoHangView.Instance.DataSource).Add(_objcachgiaohang);
           DSCachGiaoHangView.Instance.RefreshDataSource();
       }
       private void Check()
       {
           if(String.IsNullOrEmpty(View.Ma))
           {
               View.ShowMessage("Không được để trống mã cách giao hàng !");

           }
           if(String.IsNullOrEmpty(View.Ten))
           {
               View.ShowMessage("Không được để trống tên giao hàng !");
           }
       }
       public void Save()
       {
           if(_objcachgiaohang==null)
           {
               Check();
               Insert();
               View.ShowMessage("Thêm dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;
           }
           else
           {
               Check();
               Update();
               View.ShowMessage("Sửa dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;
           }
       }
       public void Exit()
       {
           View.Close();
       }
   }
}
