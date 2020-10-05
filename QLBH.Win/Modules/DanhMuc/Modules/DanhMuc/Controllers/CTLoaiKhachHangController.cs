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
   public class CTLoaiKhachHangController:AppBaseTrustedController<ICTLoaiKhachHangView>,ICTLoaiKhachHangController
   {
       private DmLoaiDoiTuongInfor _dmKhachHangInfor = new DmLoaiDoiTuongInfor();
       public CTLoaiKhachHangController(ICTLoaiKhachHangView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();
       }
       private void GetData()
       {
           _dmKhachHangInfor = View.LoaiKhachHangInfor;

       }
       private void LoadDataSource()
       {
           if(_dmKhachHangInfor!=null)
           {
               View.IDLoaiKhachHang = _dmKhachHangInfor.IdLoaiDT;
               View.MaLoaiKhachHang = _dmKhachHangInfor.MaLoaiDT;
               View.TenLoaiKhachHang = _dmKhachHangInfor.TenLoaiDT;
               View.GhiChu = _dmKhachHangInfor.GhiChu;
               View.SuDung = _dmKhachHangInfor.SuDung;
               View.NhomCha = _dmKhachHangInfor.NhomCha;
           }
       }
       public void Insert()
       {
           if(_dmKhachHangInfor==null)
           {
               _dmKhachHangInfor=new DmLoaiDoiTuongInfor();
               _dmKhachHangInfor.MaLoaiDT = View.MaLoaiKhachHang;
               _dmKhachHangInfor.TenLoaiDT = View.TenLoaiKhachHang;
               _dmKhachHangInfor.GhiChu = View.GhiChu;
               _dmKhachHangInfor.NhomCha = View.NhomCha;
               _dmKhachHangInfor.SuDung = View.SuDung;
               _dmKhachHangInfor.IdLoaiDT = DmLoaiDoiTuongDAO.Instance.Insert(_dmKhachHangInfor);
               ((List<DmLoaiDoiTuongInfor>)DSLoaiKhachHangView.Instance.DataSource).Add(_dmKhachHangInfor);
               DSLoaiKhachHangView.Instance.RefreshDataSource();
           }
       }
       public void Update()
       {
           _dmKhachHangInfor.IdLoaiDT = View.IDLoaiKhachHang;
           _dmKhachHangInfor.MaLoaiDT = View.MaLoaiKhachHang;
           _dmKhachHangInfor.TenLoaiDT = View.TenLoaiKhachHang;
           _dmKhachHangInfor.GhiChu = View.GhiChu;
           _dmKhachHangInfor.NhomCha = View.NhomCha;
           _dmKhachHangInfor.SuDung = View.SuDung;
           DmLoaiDoiTuongDAO.Instance.Update(_dmKhachHangInfor);
           ((List<DmLoaiDoiTuongInfor>)DSDoiTuongView.Instance.DataSource).Add(_dmKhachHangInfor);
           DSLoaiKhachHangView.Instance.RefreshDataSource();
       }
      private void Check()
      {
          if(string.IsNullOrEmpty(View.MaLoaiKhachHang))
          {
              throw new InvalidOperationException("Không được để trống mã loại khách hàng!");

          }
          if(string.IsNullOrEmpty(View.TenLoaiKhachHang))
          {
              throw new InvalidOperationException("Không được để trống tên loại khách hàng!");

          }
      }
       public void Save()
       {
           if(_dmKhachHangInfor==null )
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
