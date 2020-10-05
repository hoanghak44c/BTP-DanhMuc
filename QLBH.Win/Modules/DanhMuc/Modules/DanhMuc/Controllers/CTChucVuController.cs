using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
   public class CTChucVuController:AppBaseTrustedController<ICTChucVuView>,ICTChucVuController 
   {
       private DMChucVuInfor _chucvuinfor=new DMChucVuInfor();
       public CTChucVuController(ICTChucVuView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();
       }
       private  void GetData()
       {
           _chucvuinfor = View.ChucVuInfor;
       }
       private void LoadDataSource()
       {
           if(_chucvuinfor!=null)
           {
               View.IdChucVu = _chucvuinfor.IdChucVu;
               View.MaChucVu = _chucvuinfor.MaChucVu;
               View.TenChucVu = _chucvuinfor.TenChucVu;
               View.MoTa = _chucvuinfor.GhiChu;
               View.SuDung = _chucvuinfor.SuDung;
           }
       }
       public  void Insert()
       {
           if(_chucvuinfor==null)
           {
               _chucvuinfor=new DMChucVuInfor();
               _chucvuinfor.MaChucVu = View.MaChucVu;
               _chucvuinfor.TenChucVu = View.TenChucVu;
               _chucvuinfor.GhiChu = View.MoTa;
               _chucvuinfor.SuDung = View.SuDung;
               _chucvuinfor.IdChucVu = DmChucVuDAO.Instance.Insert(_chucvuinfor);
               ((List<DMChucVuInfor>)DSChucVuView.Instance.DataSource).Add(_chucvuinfor);
               DSChucVuView.Instance.RefreshDataSource();
           }
       }
       public void Update()
       {
           _chucvuinfor.IdChucVu = View.IdChucVu;
           _chucvuinfor.MaChucVu = View.MaChucVu;
           _chucvuinfor.TenChucVu = View.TenChucVu;
           _chucvuinfor.GhiChu = View.MoTa;
           _chucvuinfor.SuDung = View.SuDung;
           DmChucVuDAO.Instance.Update(_chucvuinfor);
           ((List<DMChucVuInfor>)DSChucVuView.Instance.DataSource).Add(_chucvuinfor);
           DSChucVuView.Instance.RefreshDataSource();
       }
       public void Check()
       {
           if(string.IsNullOrEmpty(View.MaChucVu))
               throw  new InvalidOperationException("Không được để trống mã chức vụ!");
           if(string.IsNullOrEmpty(View.TenChucVu))
               throw  new InvalidOperationException("Không được để trống tên chức vụ!");
       }
       public void Save()
       {
           if(_chucvuinfor==null)
           {
               Check();
               Insert();
               View.ShowMessage("Thêm mới thành công !");
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
