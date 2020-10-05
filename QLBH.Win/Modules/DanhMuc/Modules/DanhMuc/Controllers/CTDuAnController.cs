using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
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
   public class CTDuAnController:AppBaseTrustedController<ICTDuAnView >,ICTDuAnController 
   {
       private DMDuAnInfor _duaninfor=new DMDuAnInfor();
       public CTDuAnController(ICTDuAnView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();

       }
       private void GetData()
       {
           _duaninfor = View.duaninfor;

       }
       private void LoadDataSource()
       {
           if (_duaninfor != null)
           {


               View.IdDuAn = _duaninfor.IdDuAn;
               View.MaDuAn = _duaninfor.MaDuAn;
               View.TenDuAn = _duaninfor.TenDuAn;
               View.GhiChu = _duaninfor.GhiChu;
               View.SuDung = _duaninfor.SuDung;
           }
       }
       private void Insert()
       {
           if(_duaninfor==null)
           {
               _duaninfor=new DMDuAnInfor();
               _duaninfor.MaDuAn = View.MaDuAn;
               _duaninfor.TenDuAn = View.TenDuAn;
               _duaninfor.GhiChu = View.GhiChu;
               _duaninfor.SuDung = View.SuDung;
               _duaninfor.IdDuAn = DmDuAnDAO.Instance.Insert(_duaninfor);
               ((List<DMDuAnInfor>)DSDuAnView.Instance.DataSource ).Add(_duaninfor);
               DSDuAnView.Instance.RefreshDataSource();

           }
       }
       private void Update()
       {
           _duaninfor.IdDuAn = View.IdDuAn;
           _duaninfor.MaDuAn = View.MaDuAn;
           _duaninfor.TenDuAn = View.TenDuAn;
           _duaninfor.GhiChu = View.GhiChu;
           _duaninfor.SuDung = View.SuDung;

       }
       private void Check()
       {
           if(String.IsNullOrEmpty(View.MaDuAn))
           {
               throw new InvalidOperationException("Không được để trống mã dự án");
           }
           if(String.IsNullOrEmpty(View.TenDuAn))
           {
               throw new InvalidOperationException("Không được để trống Tên dự án");
           }
       }
       public void Save()
       {
           if(_duaninfor==null)
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
