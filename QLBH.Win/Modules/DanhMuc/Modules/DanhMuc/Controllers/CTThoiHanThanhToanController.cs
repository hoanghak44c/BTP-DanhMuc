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
   public class CTThoiHanThanhToanController:AppBaseTrustedController<ICTThoiHanThanhToanView >,ICTThoiHanThanhToanController 
   {
       private  DMLoaiThuChiInfor _thuchiinfor=new DMLoaiThuChiInfor();
       public CTThoiHanThanhToanController(ICTThoiHanThanhToanView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();

       }
       private void GetData()
       {
           _thuchiinfor = View.thuchiinfor;
       }
       private void LoadDataSource()
       {
           if(_thuchiinfor!=null)
           {
               View.IdThuChi = _thuchiinfor.IdThuChi;
               View.KyHieu = _thuchiinfor.KyHieu;
               View.Ten = _thuchiinfor.Ten;
               View.GhiChu = _thuchiinfor.GhiChu;
               View.Type = _thuchiinfor.Type;
               View.SuDung = _thuchiinfor.SuDung;

           }
       }
       private void Insert()
       {
           if(_thuchiinfor==null)
           {
               _thuchiinfor=new DMLoaiThuChiInfor();
               _thuchiinfor.KyHieu = View.KyHieu;
               _thuchiinfor.Ten = View.Ten;
               _thuchiinfor.GhiChu = View.GhiChu;
               _thuchiinfor.Type = View.Type;
               _thuchiinfor.SuDung = View.SuDung;
               _thuchiinfor.IdThuChi = DmLoaiThuChiDAO.Instance.Insert(_thuchiinfor);
               ((List<DMLoaiThuChiInfor>)DSThoiHanThanhToanView.Instance.DataSource).Add(_thuchiinfor);
               DSThoiHanThanhToanView.Instance.RefreshDataSource();
           }
       }
       private void Update()

       {

           _thuchiinfor.IdThuChi = View.IdThuChi;
           _thuchiinfor.KyHieu = View.KyHieu;
           _thuchiinfor.Ten = View.Ten;
           _thuchiinfor.GhiChu = View.GhiChu;
           _thuchiinfor.Type = View.Type;
           _thuchiinfor.SuDung = View.SuDung;
           DmLoaiThuChiDAO.Instance.Update(_thuchiinfor);
           ((List<DMLoaiThuChiInfor>)DSThoiHanThanhToanView.Instance.DataSource).Add(_thuchiinfor);
           DSThoiHanThanhToanView.Instance.RefreshDataSource();


       }
       private void Check()
       {
           if(String.IsNullOrEmpty(View.KyHieu))
           {
               throw  new InvalidOperationException("Không được để trống mã thu chi");
           }
           if(String.IsNullOrEmpty(View.Ten))
           {
               throw new InvalidOperationException("Không được để trống tên thu chi !");

           }
       }
       public void Save()
       {
           if(_thuchiinfor==null)
           {
               Check();
               Insert();
               View.ShowMessage("Thêm dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;

           }
           else
           {
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
