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
   public  class CTNhanVienController:AppBaseTrustedController<ICTNhanVienView>,ICTNhanVienController
   {
       private DMNhanVienInfo objNhanVien=new DMNhanVienInfo();
       private List<DMKhoCBOLoadInfo> oDataSource = null;
       public CTNhanVienController(ICTNhanVienView view) : base(view)
       {
       }

       protected override void DisplayViewInfo()
       {
           GetData();
           LoadDataSource();
           LoadGioiTinh();
           LoadPhongBan();
           LoadChucVu();
           // nếu thêm mới thì load tất cả kho với trung tâm 
           // nếu update thì load ra danh sách trung tâm , kho theo idtrungtam

           if(objNhanVien==null)
           {
               oDataSource = DMKhoDAO.Instance.GetKhoByInfor();
               View.DataSource = oDataSource;
           }
           else
           {
               oDataSource = DMKhoDAO.Instance.GetKhoByIdTrungTamHachToan(View.IdTrungTamHachToan);
               View.DataSource = oDataSource;
           }
          
           
           
           
       }
       private void GetData()
       {
           objNhanVien = View.NhanVienInfo;
       }
      
       private void LoadDataSource()
       {
           if(objNhanVien!=null)
           {
               View.IdNhanVien = objNhanVien.IdNhanVien;
               View.MaNhanVien = objNhanVien.MaNhanVien;
               View.HoTen = objNhanVien.HoTen;
               View.NgaySinh = objNhanVien.NgaySinh;
               View.GioiTinh = objNhanVien.GioiTinh;
               View.IdPhongBan = objNhanVien.IdPhongBan;
               View.IdChucVu = objNhanVien.IdChucVu;
               View.DiaChi = objNhanVien.DiaChi;
               View.DienThoai = objNhanVien.DienThoai;
               View.SuDung = objNhanVien.SuDung;
               View.Email = objNhanVien.Email;
               View.GhiChu = objNhanVien.GhiChu;
               View.IdTrungTamHachToan = objNhanVien.IdTrungTamHachToan;
               
           }
           
       }
       private void LoadGioiTinh()
       {
           List<LookUpInfor>list=new List<LookUpInfor>();
           list.Add(new LookUpInfor{ID = 0,Name = "Nữ"});
           list.Add(new LookUpInfor{ID=1,Name = "Nam"});
           View.objGioiTinh = list;

       }
       private void LoadPhongBan()
       {
           View.PhongBanDataSource = DmPhongBanDAO.Instance.GetAllPhongBan();
       }
       private void LoadChucVu()
       {
           View.ChucVuDataSource = DmChucVuDAO.Instance.GetAllChucVu();
       }
       // lấy dữ liệu kho theo id trung tâm
       public  void GetKhoByIdTrungTam()
       {
           View.DataSource = DMKhoDAO.Instance.GetKhoByIdTrungTamHachToan(View.IdTrungTamHachToan);
       }
       public  void Insert()
       {
           if (objNhanVien == null)
           {
               objNhanVien=new DMNhanVienInfo();
               objNhanVien.MaNhanVien = View.MaNhanVien;
               objNhanVien.HoTen = View.HoTen;
               objNhanVien.NgaySinh = View.NgaySinh;
               objNhanVien.GioiTinh = View.GioiTinh;
               objNhanVien.IdPhongBan = View.IdPhongBan;
               objNhanVien.IdChucVu = View.IdChucVu;
               objNhanVien.DiaChi = View.DiaChi;
               objNhanVien.DienThoai = View.DienThoai;
               objNhanVien.SuDung = View.SuDung;
               objNhanVien.Email = View.Email;
               objNhanVien.GhiChu = View.GhiChu;
               objNhanVien.IdTrungTamHachToan = View.IdTrungTamHachToan;
               objNhanVien.IdNhanVien = DMNhanVienDAO.Instance.Insert(objNhanVien);
               ((List<DMNhanVienInfo>) (DSNhanVienView.Instance.DataSource)).Add(objNhanVien);
               DSNhanVienView.Instance.RefreshDataSource();
           }
       }
       public  void Update()
       {
           objNhanVien.IdNhanVien = View.IdNhanVien;
           objNhanVien.MaNhanVien = View.MaNhanVien;
           objNhanVien.HoTen = View.HoTen;
           objNhanVien.NgaySinh = View.NgaySinh;
           objNhanVien.GioiTinh = View.GioiTinh;
           objNhanVien.IdPhongBan = View.IdPhongBan;
           objNhanVien.IdChucVu = View.IdChucVu;
           objNhanVien.DiaChi = View.DiaChi;
           objNhanVien.DienThoai = View.DienThoai;
           objNhanVien.SuDung = View.SuDung;
           objNhanVien.Email = View.Email;
           objNhanVien.GhiChu = View.GhiChu;
           objNhanVien.IdTrungTamHachToan = View.IdTrungTamHachToan;
           DMNhanVienDAO.Instance.Update(objNhanVien);
          
       }
       private void Check()
       {
           if(string.IsNullOrEmpty(View.MaNhanVien))
           {
               throw new InvalidOperationException("Không được để trống mã nhân viên! ");
           }
           if(string.IsNullOrEmpty(View.HoTen))
           {
               throw  new InvalidOperationException("Không được để trống tên nhân viên !");
           }
       }
       public void Save()
       {
           if(objNhanVien==null)
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
               View.ShowMessage("Sửa dữ liệu thành công !");
               View.DialogResult = DialogResult.OK;
           }
       }
       public void ChoseTrungTam()
       {
           frmLookUp_TrungTam frmLookUpTrungTam=new frmLookUp_TrungTam();
           if(frmLookUpTrungTam.ShowDialog()==DialogResult.OK)
           {
               View.IdTrungTamHachToan = frmLookUpTrungTam.SelectedItem.IdTrungTam;
           }
       }
       public  void Exit()
       {
           View.Close();
       }
   }
}
