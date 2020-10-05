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
   public  class CTDonViTinhController:AppBaseTrustedController<ICTDonViTinhView>,ICTDonViTinhController
   {
       private DMDonViTinhInfor _dmDonViTinh=new DMDonViTinhInfor();
       public CTDonViTinhController(ICTDonViTinhView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();
       }
       private void GetData()
       {
           _dmDonViTinh = View.DonViTinhInfor;
       }
       private void LoadDataSource()
       {
           if(_dmDonViTinh!=null)
           {
               View.IDDonViTinh = _dmDonViTinh.IdDonViTinh;
               View.MaDonViTinh = _dmDonViTinh.KyHieu;
               View.GhiChu = _dmDonViTinh.GhiChu;
               View.TenDonViTinh = _dmDonViTinh.TenDonViTinh;
               View.SuDung = _dmDonViTinh.SuDung;
           }
       }
       public  void Insert()
       {
           if(_dmDonViTinh==null)
           {
               _dmDonViTinh=new DMDonViTinhInfor();
               _dmDonViTinh.TenDonViTinh = View.TenDonViTinh;
               _dmDonViTinh.KyHieu = View.MaDonViTinh;
               _dmDonViTinh.GhiChu = View.GhiChu;
               _dmDonViTinh.SuDung = View.SuDung;
               _dmDonViTinh.IdDonViTinh = DmDonViTinhDAO.Instance.Insert(_dmDonViTinh);
               ((List<DMDonViTinhInfor>)DSDonViTinhView.Instance.DataSource).Add(_dmDonViTinh);
               DSDonViTinhView.Instance.RefreshDataSource();
           }
       }
       public void Update()
       {
           _dmDonViTinh.IdDonViTinh = View.IDDonViTinh;
           _dmDonViTinh.KyHieu = View.MaDonViTinh;
           _dmDonViTinh.TenDonViTinh = View.TenDonViTinh;
           _dmDonViTinh.GhiChu = View.GhiChu;
           _dmDonViTinh.SuDung = View.SuDung;
           DmDonViTinhDAO.Instance.Update(_dmDonViTinh);
           ((List<DMDonViTinhInfor>)DSDonViTinhView.Instance.DataSource).Add(_dmDonViTinh);
           DSDonViTinhView.Instance.RefreshDataSource();

       }
       private void Check()
       {
           if(string.IsNullOrEmpty(View.MaDonViTinh))
           {
               throw new InvalidOperationException("Không được để trống mã đơn vị tính !");
           }
           if(string.IsNullOrEmpty(View.TenDonViTinh))
           {
               throw  new InvalidOperationException("Không được để trống tên đơn vị tính !");
           }
       }
       public  void Save()
       {
           if(_dmDonViTinh==null)
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
               View.ShowMessage("Cập nhật dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;
           }
       }
       public void Exit()
       {
           View.Close();
       }
   }
}
