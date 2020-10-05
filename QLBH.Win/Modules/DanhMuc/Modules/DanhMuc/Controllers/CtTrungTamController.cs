using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;
using QLBanHang.Modules.DanhMuc.Infors;



namespace QLBanHang.Modules.DanhMuc.Controllers
{
    public class CTTrungTamController:AppBaseTrustedController<ICTTrungTamView>,ICTTrungTamController
    {  
        
        // cấu trúc các phần danh mục gần giống nhau

        private DMTrungTamInfor objtrungtam=new DMTrungTamInfor();// khai báo đối tượng
        public CTTrungTamController(ICTTrungTamView view) : base(view)
        {
        }
        protected override void DisplayViewInfo()
        {
            GetData(); // set dữ liệu cho đối tượng
            LoadDataSource();// load ra dữ liệu
        }
        private void GetData()
        {
            objtrungtam = View.DMTrungTamInfo;
        }
        private void LoadDataSource()
        {
            if(objtrungtam!=null)
            {
                View.IdTrungTam = objtrungtam.IdTrungTam;
                View.MaTrungTam = objtrungtam.MaTrungTam;
                View.TenTrungTam = objtrungtam.TenTrungTam;
                View.DiaChi = objtrungtam.DiaChi;
                View.DienThoai = objtrungtam.DienThoai;
                View.Email = objtrungtam.Email;
                View.Fax = objtrungtam.Fax;
                View.GhiChu = objtrungtam.GhiChu;
                View.SuDung = objtrungtam.SuDung;
                View.IdBangGia = objtrungtam.IdBangGia;
                View.Price_List_Id = objtrungtam.Price_List_Id;
                View.ViTri = objtrungtam.ViTri;
                View.Duong = objtrungtam.Duong;
                View.Tinh = objtrungtam.Tinh;
                View.QuocGia = objtrungtam.QuocGia;
                View.ChannelCode = objtrungtam.ChannelCode; 
            }
            
        }
        private void Insert()
        {
            objtrungtam = new DMTrungTamInfor();           
            objtrungtam.MaTrungTam = View.MaTrungTam;
            objtrungtam.TenTrungTam = View.TenTrungTam;
            objtrungtam.DiaChi = View.DiaChi;
            objtrungtam.DienThoai = View.DienThoai;
            objtrungtam.Email = View.Email;
            objtrungtam.Fax = View.Fax;
            objtrungtam.GhiChu = View.GhiChu;
            objtrungtam.SuDung = View.SuDung;
            objtrungtam.IdBangGia = View.IdBangGia;
            objtrungtam.ViTri = View.ViTri;
            objtrungtam.Duong = View.Duong;
            objtrungtam.Tinh = View.Tinh;
            objtrungtam.QuocGia = View.QuocGia;
            objtrungtam.ChannelCode = View.ChannelCode;
            objtrungtam.IdTrungTam = DmTrungTamDAO.Instance.Insert(objtrungtam);
            ((List<DMTrungTamInfor>)DSTrungTamView.Instance.DataSource).Add(objtrungtam);
             DSTrungTamView.Instance.RefreshDataSource();
        }
        private void Update()
        {
            objtrungtam.IdTrungTam = View.IdTrungTam;
            objtrungtam.MaTrungTam = View.MaTrungTam;
            objtrungtam.TenTrungTam = View.TenTrungTam;
            objtrungtam.DiaChi = View.DiaChi;
            objtrungtam.DienThoai = View.DienThoai;
            objtrungtam.Email = View.Email;
            objtrungtam.Fax = View.Fax;
            objtrungtam.GhiChu = View.GhiChu;
            objtrungtam.SuDung = View.SuDung;
            objtrungtam.IdBangGia = View.IdBangGia;
            objtrungtam.ViTri = View.ViTri;
            objtrungtam.Duong = View.Duong;
            objtrungtam.Tinh = View.Tinh;
            objtrungtam.QuocGia = View.QuocGia;
            objtrungtam.ChannelCode = View.ChannelCode;
             DmTrungTamDAO.Instance.Update(objtrungtam);
            ((List<DMTrungTamInfor>)DSTrungTamView.Instance.DataSource).Add(objtrungtam);
            DSTrungTamView.Instance.RefreshDataSource();

        }
        private void Check()// kiểm tra mã và tên không được để trống!
        {
            if(string.IsNullOrEmpty(View.MaTrungTam))
            {
                throw new InvalidOperationException("Không được để trống mã trung tâm !");
            }
            if(string.IsNullOrEmpty(View.TenTrungTam))
            {
                throw new InvalidOperationException("Không đượ để trống tên trung tâm !");
            }
        }
        public void Save()
        {
            if(objtrungtam==null)
            {
                Check();
                Insert();
                View.ShowMessage("Thêm mới thành công !");
                View.DialogResult = DialogResult.OK;
            }
            else
            {
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
