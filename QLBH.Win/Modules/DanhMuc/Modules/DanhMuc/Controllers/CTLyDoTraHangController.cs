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
  public  class CTLyDoTraHangController:AppBaseTrustedController<ICTLyDoTraHangView >,ICTLyDoTraHangController 
  {
      private DMLyDoTraHangInfo _trahanginfo=new DMLyDoTraHangInfo();
      public CTLyDoTraHangController(ICTLyDoTraHangView view) : base(view)
      {
      }

      protected override void DisplayViewInfo()
      {
          GetData();
          LoadDataSource();
      }
      private void GetData()
      {
          _trahanginfo = View.lydotrahanginfo;

      }
      private void LoadDataSource()
      {
          if(_trahanginfo!=null)
          {
              View.IdLyDoTraHang = _trahanginfo.IdLyDoTH;
              View.Ma = _trahanginfo.MaLyDo;
              View.Ten = _trahanginfo.Ten;
              View.GhiChu = _trahanginfo.GhiChu;
              View.SuDung = _trahanginfo.SuDung;
          }
      }
      private void Insert()
      {
          if(_trahanginfo==null)
          {
              _trahanginfo=new DMLyDoTraHangInfo();
              _trahanginfo.MaLyDo = View.Ma;
              _trahanginfo.Ten = View.Ten;
              _trahanginfo.GhiChu = View.GhiChu;
              _trahanginfo.SuDung = View.SuDung;
              _trahanginfo.IdLyDoTH = DmLyDoTraHangDAO.Instance.Insert(_trahanginfo);
              ((List<DMLyDoTraHangInfo>)DSLyDoTraHangView.Instance.DataSource).Add(_trahanginfo);
              DSLyDoTraHangView.Instance.RefreshDataSource();

          }
      }
      private void Update()
      {
          _trahanginfo.IdLyDoTH = View.IdLyDoTraHang;
          _trahanginfo.MaLyDo = View.Ma;
          _trahanginfo.Ten = View.Ten;
          _trahanginfo.GhiChu = View.GhiChu;
          _trahanginfo.SuDung = View.SuDung;
           DmLyDoTraHangDAO.Instance.Update(_trahanginfo);
          ((List<DMLyDoTraHangInfo>)DSLyDoTraHangView.Instance.DataSource).Add(_trahanginfo);
          DSLyDoTraHangView.Instance.RefreshDataSource();
      }
      private void Check()
      {
          if(String.IsNullOrEmpty(View.Ma))
          {
              throw new InvalidOperationException("Không được để trống mã lý do !");
          }
          if(String.IsNullOrEmpty(View.Ten))
          {
              throw  new InvalidOperationException("Không được để trống tên lý do");
          }

      }
      public void Save()
      {
          if(_trahanginfo==null)
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
