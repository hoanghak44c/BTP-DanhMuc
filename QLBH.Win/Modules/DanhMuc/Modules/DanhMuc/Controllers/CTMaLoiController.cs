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
   public class CTMaLoiController:AppBaseTrustedController<ICTMaLoiView>,ICTMaLoiController 
   {
       private DMMaLoiInfor _maloiinfor =new DMMaLoiInfor();
       public CTMaLoiController(ICTMaLoiView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();

       }
       private void GetData()
       {
           _maloiinfor = View.maloiinfor;

       }
       private void LoadDataSource()
       {
           if(_maloiinfor!=null)
           {
               View.IdMaLoi = _maloiinfor.IdMaLoi;
               View.MaLoi = _maloiinfor.MaLoi;
               View.TenLoi = _maloiinfor.TenLoi;
               View.GhiChu = _maloiinfor.GhiChu;
               View.SuDung = _maloiinfor.SuDung;
               View.TenLoaiSP = _maloiinfor.TenLoaiSP;
               View.IdLoaiItem = _maloiinfor.IdLoaiItem;

           }
       }
       private void Insert()
       {
           _maloiinfor=new DMMaLoiInfor();
           _maloiinfor.IdLoaiItem = View.IdLoaiItem;
           _maloiinfor.MaLoi = View.MaLoi;
           _maloiinfor.TenLoi = View.TenLoi;
           _maloiinfor.GhiChu = View.GhiChu;
           _maloiinfor.SuDung = View.SuDung;
           _maloiinfor.TenLoaiSP = View.TenLoaiSP;
           _maloiinfor.IdMaLoi = DmMaLoiDAO.Instance.Insert(_maloiinfor);
           ((List<DMMaLoiInfor>)DSMaLoiView.Instance.DataSource ).Add(_maloiinfor);
           DSMaLoiView.Instance.RefreshDataSource();

       }
       private void Update()
       {
           _maloiinfor.IdMaLoi = View.IdMaLoi;
           _maloiinfor.IdLoaiItem = View.IdLoaiItem;
           _maloiinfor.MaLoi = View.MaLoi;
           _maloiinfor.TenLoi = View.TenLoi;
           _maloiinfor.GhiChu = View.GhiChu;
           _maloiinfor.SuDung = View.SuDung;
           _maloiinfor.TenLoaiSP = View.TenLoaiSP;
            DmMaLoiDAO.Instance.Update(_maloiinfor);
           ((List<DMMaLoiInfor>)DSMaLoiView.Instance.DataSource).Add(_maloiinfor);
           DSMaLoiView.Instance.RefreshDataSource();

       }
       private void Check()
       {
           if(String.IsNullOrEmpty(View.MaLoi))
           {
               throw new InvalidOperationException("Không được để trống mã lỗi");

           }
           if(String.IsNullOrEmpty(View.TenLoi))
           {
               throw new InvalidOperationException("Không được để trống tên lỗi");
           }
       }
       public void Save()
       {
           if(_maloiinfor==null)
           {
               Check();
               Insert();
               View.ShowMessage("Thêm mới dữ liệu thành công !");
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
