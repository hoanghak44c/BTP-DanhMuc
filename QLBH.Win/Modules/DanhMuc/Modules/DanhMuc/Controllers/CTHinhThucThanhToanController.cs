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
   public class CTHinhThucThanhToanController:AppBaseTrustedController<ICTHinhThucThanhToanView>,ICTHinhThucThanhToanController 
   {
       private DMThanhToanInfor _thanhtoainfor =new DMThanhToanInfor();
       public CTHinhThucThanhToanController(ICTHinhThucThanhToanView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();
           LoadLoaiThanhToan();

       }
       private void  GetData()
       {
           _thanhtoainfor = View.thanhtoaninfo;
       }
       private void LoadDataSource()
       {
           if(_thanhtoainfor!=null)
           {
               View.IdThanhToan = _thanhtoainfor.IdThanhToan;
               View.Ma = _thanhtoainfor.Ma;
               View.Ten = _thanhtoainfor.Ten;
               View.GhiChu = _thanhtoainfor.GhiChu;
               View.SuDung = _thanhtoainfor.SuDung;
               View.LoaiThanhToan = _thanhtoainfor.LoaiThanhToan;

           }
       }
       private void LoadLoaiThanhToan()
       {
           List<LookUpInfor> list=new List<LookUpInfor>();
           list.Add(new LookUpInfor{ID = 0,Name = "Bất kỳ"});
           list.Add(new LookUpInfor{ID=1,Name = "Tiền mặt"});
           list.Add(new LookUpInfor{ID=2,Name = "Chuyển khoản"});
           list.Add(new LookUpInfor{ID=3,Name = "Thẻ"});
           list.Add(new LookUpInfor{ID=-1,Name = "Voucher "});
           View.objLoaiThanhToan = list;


       }
       private  void Insert()
       {
           if(_thanhtoainfor==null)
           {
               _thanhtoainfor=new DMThanhToanInfor();
               _thanhtoainfor.Ma = View.Ma;
               _thanhtoainfor.Ten = View.Ten;
               _thanhtoainfor.GhiChu = View.GhiChu;
               _thanhtoainfor.SuDung = View.SuDung;
               _thanhtoainfor.LoaiThanhToan = View.SuDung;
               _thanhtoainfor.IdThanhToan = DmThanhToanDAO.Instance.Insert(_thanhtoainfor);
                   ((List<DMThanhToanInfor>)DSHinhThucThanhToanView.Instance.DataSource).Add(_thanhtoainfor);
               DSHinhThucThanhToanView.Instance.RefreshDataSource();
           }
       }
       private void Update()
       {
           _thanhtoainfor.IdThanhToan = View.IdThanhToan;
           _thanhtoainfor.Ma = View.Ma;
           _thanhtoainfor.Ten = View.Ten;
           _thanhtoainfor.GhiChu = View.GhiChu;
           _thanhtoainfor.SuDung = View.SuDung;
           _thanhtoainfor.LoaiThanhToan = View.SuDung;
           DmThanhToanDAO.Instance.Update(_thanhtoainfor);
           ((List<DMThanhToanInfor>)DSHinhThucThanhToanView.Instance.DataSource).Add(_thanhtoainfor);
           DSHinhThucThanhToanView.Instance.RefreshDataSource();
           
       }
       private void Check()
       {
           if(String.IsNullOrEmpty(View.Ma))
           {
               throw new InvalidOperationException("Không được để trống mã hình thức thanh toán !");

           }
           if(String.IsNullOrEmpty(View.Ten))
           {
               throw new InvalidOperationException("Không được để trống tên hình thức thanh toán !");
           }
       }
       public void Save()
       {
           if(_thanhtoainfor==null)
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
