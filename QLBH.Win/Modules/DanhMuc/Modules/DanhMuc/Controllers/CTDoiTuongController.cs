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
    public class CTDoiTuongController:AppBaseTrustedController<ICTDoiTuongView>,ICTDoiTuongController
    {
        private List<DMDoiTuongInfo> oDataSource = null;
        private DMDoiTuongInfo _dmdoituonginfo =new DMDoiTuongInfo();
        public CTDoiTuongController(ICTDoiTuongView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();
            LoadLoaiDoiTuong();
            //LoadLoaiThe();
            LoadGioiTinh();
            if(_dmdoituonginfo!=null)
            {
                oDataSource = DMDoiTuongDAO.Instance.GetDoiTuongByMaDoiTuong(View.MaDoiTuong);
                View.DataSource = oDataSource;
            }
            
        }
        private void GetData()
        {
            _dmdoituonginfo = View.dmDoiTuongInfo;
        }
        private void  LoadDataSource()
        {
            if(_dmdoituonginfo!=null)
            {
                View.IdDoiTuong = _dmdoituonginfo.IdDoiTuong;
                View.MaDoiTuong = _dmdoituonginfo.MaDoiTuong;
                View.TenDoiTuong = _dmdoituonginfo.TenDoiTuong;
                View.MaRieng = _dmdoituonginfo.MaRieng;
                View.IdLoaiDoiTuong = _dmdoituonginfo.IdLoaiDoiTuong;
                View.GioiTinh = _dmdoituonginfo.GioiTinh;
                View.DoTuoi = _dmdoituonginfo.DoTuoi;
                View.NgaySinh = _dmdoituonginfo.NgaySinh;
                View.SoCMND = _dmdoituonginfo.SoCMND;
                View.DiaChi = _dmdoituonginfo.DiaChi;
                View.DienThoai = _dmdoituonginfo.DienThoai;
                View.Fax = _dmdoituonginfo.Fax;
                View.Email = _dmdoituonginfo.Email;
                View.Tinh = _dmdoituonginfo.Tinh;
                View.Huyen = _dmdoituonginfo.Huyen;
                View.QuocGia = _dmdoituonginfo.QuocGia;
                View.IdCha = _dmdoituonginfo.IdCha;
                View.NgheNghiep = _dmdoituonginfo.NgheNghiep;
                View.PhongBan = _dmdoituonginfo.PhongBan;
                View.ChuDoanhNghiep = _dmdoituonginfo.ChuDoanhNghiep;
                View.DienThoai_CDN = _dmdoituonginfo.DienThoai_CDN;
                View.Email_CDN = _dmdoituonginfo.Email_CDN;
                View.MaSoThue = _dmdoituonginfo.MaSoThue;
                View.SoDKKD = _dmdoituonginfo.SoDKKD;
                View.WebSite = _dmdoituonginfo.WebSite;
                View.NguoiLienLac = _dmdoituonginfo.NguoiLienLac;
                View.CMND_NLL = _dmdoituonginfo.CMND_NLL;
                View.DienThoai_NLL = _dmdoituonginfo.DienThoai_NLL;
                View.Biet_Ta_Tu = _dmdoituonginfo.Biet_Ta_Tu;
                View.TaiKhoan = _dmdoituonginfo.TaiKhoan;
                View.ThuNhap = _dmdoituonginfo.ThuNhap;
                View.NganHang = _dmdoituonginfo.NganHang;
                View.HanMucTinDung = _dmdoituonginfo.HanMucTinDung;
                View.HanMucTDConLai = _dmdoituonginfo.HanMucTDConLai;
                View.CongNoKhachHang = _dmdoituonginfo.CongNoKhachHang;
                View.HanTra = _dmdoituonginfo.HanTra;
                View.TyLePhat = _dmdoituonginfo.TyLePhat;
                View.BillTo = _dmdoituonginfo.BillTo;
                View.ShipTo = _dmdoituonginfo.ShipTo;
                View.GhiChu = _dmdoituonginfo.GhiChu;
                View.ThuNhap = _dmdoituonginfo.ThuNhap;
                View.GiaTriMuaHang = _dmdoituonginfo.GiaTriMuaHang;
                View.SoLanMuaHang = _dmdoituonginfo.SoLanMuaHang;
                View.IdOrderType = _dmdoituonginfo.IdOrderType;
                View.IdLoaiThe = _dmdoituonginfo.IdLoaiThe;
                View.NgayCapThe = _dmdoituonginfo.NgayCapThe;
                View.SuDung = _dmdoituonginfo.SuDung;
            }
            
        }
        private void LoadLoaiDoiTuong()
        {
            View.LoaiDoiTuongDataSource = DmLoaiDoiTuongDAO.Instance.GetListLoaiDoiTuongInfor();
        }
        private void LoadGioiTinh()
        {
            List<LookUpInfor> listgt=new List<LookUpInfor>();
            listgt.Add(new LookUpInfor{ID=0,Name = "Nữ"});
            listgt.Add(new LookUpInfor {ID = 1,Name = "Nam"});
            View.objGT = listgt;
        }
        private void Insert()
        {
            if(_dmdoituonginfo==null)
            {
                _dmdoituonginfo = new DMDoiTuongInfo();
                _dmdoituonginfo.MaDoiTuong = View.MaDoiTuong;
               _dmdoituonginfo.TenDoiTuong = View.TenDoiTuong;
                _dmdoituonginfo.MaRieng = View.MaRieng;
                _dmdoituonginfo.IdLoaiDoiTuong = View.IdLoaiDoiTuong;
                _dmdoituonginfo.GioiTinh =View.GioiTinh;
                _dmdoituonginfo.DoTuoi = View.DoTuoi;
                _dmdoituonginfo.NgaySinh = View.NgaySinh;
                _dmdoituonginfo.SoCMND = View.SoCMND;
                _dmdoituonginfo.DiaChi = View.DiaChi;
                _dmdoituonginfo.DienThoai = View.DienThoai;
                _dmdoituonginfo.Fax = View.Fax;
                _dmdoituonginfo.Email = View.Email;
                _dmdoituonginfo.Tinh = View.Tinh;
                _dmdoituonginfo.Huyen = View.Huyen;
                _dmdoituonginfo.QuocGia = View.QuocGia;
                _dmdoituonginfo.IdCha = View.IdCha;
                _dmdoituonginfo.NgheNghiep =View.NgheNghiep;
                _dmdoituonginfo.PhongBan = View.PhongBan;
                _dmdoituonginfo.ChuDoanhNghiep =View.ChuDoanhNghiep;
                _dmdoituonginfo.DienThoai_CDN = View.DienThoai_CDN;
                _dmdoituonginfo.Email_CDN = View.Email_CDN;
                _dmdoituonginfo.MaSoThue = View.MaSoThue;
                _dmdoituonginfo.SoDKKD = View.SoDKKD;
                _dmdoituonginfo.WebSite = View.WebSite;
                _dmdoituonginfo.NguoiLienLac = View.NguoiLienLac;
                _dmdoituonginfo.CMND_NLL = View.CMND_NLL;
                _dmdoituonginfo.DienThoai_NLL = View.DienThoai_NLL;
                _dmdoituonginfo.Biet_Ta_Tu = View.Biet_Ta_Tu;
                _dmdoituonginfo.TaiKhoan = View.TaiKhoan;
                _dmdoituonginfo.ThuNhap = View.ThuNhap;
                _dmdoituonginfo.NganHang = View.NganHang;
                _dmdoituonginfo.HanMucTinDung = View.HanMucTinDung;
                _dmdoituonginfo.HanMucTDConLai = View.HanMucTDConLai;
                _dmdoituonginfo.CongNoKhachHang = View.CongNoKhachHang;
                _dmdoituonginfo.HanTra = View.HanTra;
                _dmdoituonginfo.TyLePhat = View.TyLePhat;
                _dmdoituonginfo.BillTo = View.BillTo;
                _dmdoituonginfo.ShipTo = View.ShipTo;
                _dmdoituonginfo.GhiChu = View.GhiChu;
                _dmdoituonginfo.ThuNhap =View.ThuNhap;
                _dmdoituonginfo.GiaTriMuaHang = View.GiaTriMuaHang;
                _dmdoituonginfo.SoLanMuaHang = View.SoLanMuaHang;
                _dmdoituonginfo.IdOrderType = View.IdOrderType;
                _dmdoituonginfo.IdLoaiThe = View.IdLoaiThe;
                _dmdoituonginfo.NgayCapThe = View.NgayCapThe;
                _dmdoituonginfo.SuDung = View.SuDung;
                _dmdoituonginfo.Type = 1;
                _dmdoituonginfo.IdDoiTuong = DMDoiTuongDAO.Instance.Insert(_dmdoituonginfo);
                ((List<DMDoiTuongInfo>)DSDoiTuongView.Instance.DataSource).Add(_dmdoituonginfo);
                DSDoiTuongView.Instance.RefreshDataSource();

            }
        }
        private void Update()
        {
            _dmdoituonginfo.IdDoiTuong = View.IdDoiTuong;
            _dmdoituonginfo.MaDoiTuong = View.MaDoiTuong;
            _dmdoituonginfo.TenDoiTuong = View.TenDoiTuong;
            _dmdoituonginfo.MaRieng = View.MaRieng;
            _dmdoituonginfo.IdLoaiDoiTuong = View.IdLoaiDoiTuong;
            _dmdoituonginfo.GioiTinh = View.GioiTinh;
            _dmdoituonginfo.DoTuoi = View.DoTuoi;
            _dmdoituonginfo.NgaySinh = View.NgaySinh;
            _dmdoituonginfo.SoCMND = View.SoCMND;
            _dmdoituonginfo.DiaChi = View.DiaChi;
            _dmdoituonginfo.DienThoai = View.DienThoai;
            _dmdoituonginfo.Fax = View.Fax;
            _dmdoituonginfo.Email = View.Email;
            _dmdoituonginfo.Tinh = View.Tinh;
            _dmdoituonginfo.Huyen = View.Huyen;
            _dmdoituonginfo.QuocGia = View.QuocGia;
            _dmdoituonginfo.IdCha = View.IdCha;
            _dmdoituonginfo.NgheNghiep = View.NgheNghiep;
            _dmdoituonginfo.PhongBan = View.PhongBan;
            _dmdoituonginfo.ChuDoanhNghiep = View.ChuDoanhNghiep;
            _dmdoituonginfo.DienThoai_CDN = View.DienThoai_CDN;
            _dmdoituonginfo.Email_CDN = View.Email_CDN;
            _dmdoituonginfo.MaSoThue = View.MaSoThue;
            _dmdoituonginfo.SoDKKD = View.SoDKKD;
            _dmdoituonginfo.WebSite = View.WebSite;
            _dmdoituonginfo.NguoiLienLac = View.NguoiLienLac;
            _dmdoituonginfo.CMND_NLL = View.CMND_NLL;
            _dmdoituonginfo.DienThoai_NLL = View.DienThoai_NLL;
            _dmdoituonginfo.Biet_Ta_Tu = View.Biet_Ta_Tu;
            _dmdoituonginfo.TaiKhoan = View.TaiKhoan;
            _dmdoituonginfo.ThuNhap = View.ThuNhap;
            _dmdoituonginfo.NganHang = View.NganHang;
            _dmdoituonginfo.HanMucTinDung = View.HanMucTinDung;
            _dmdoituonginfo.HanMucTDConLai = View.HanMucTDConLai;
            _dmdoituonginfo.CongNoKhachHang = View.CongNoKhachHang;
            _dmdoituonginfo.HanTra = View.HanTra;
            _dmdoituonginfo.TyLePhat = View.TyLePhat;
            _dmdoituonginfo.BillTo = View.BillTo;
            _dmdoituonginfo.ShipTo = View.ShipTo;
            _dmdoituonginfo.GhiChu = View.GhiChu;
            _dmdoituonginfo.ThuNhap = View.ThuNhap;
            _dmdoituonginfo.GiaTriMuaHang = View.GiaTriMuaHang;
            _dmdoituonginfo.SoLanMuaHang = View.SoLanMuaHang;
            _dmdoituonginfo.IdOrderType = View.IdOrderType;
            _dmdoituonginfo.IdLoaiThe = View.IdLoaiThe;
            _dmdoituonginfo.NgayCapThe = View.NgayCapThe;
            _dmdoituonginfo.SuDung = View.SuDung;
            _dmdoituonginfo.Type = 1;
           DMDoiTuongDAO.Instance.Update(_dmdoituonginfo);
            ((List<DMDoiTuongInfo>)DSDoiTuongView.Instance.DataSource).Add(_dmdoituonginfo);
            DSDoiTuongView.Instance.RefreshDataSource();
        }
        private void Check()
        {
            if(string.IsNullOrEmpty(View.MaDoiTuong))
            {
                View.ShowMessage("Không được để trống mã đối tượng!");
            }
            if(string.IsNullOrEmpty(View.TenDoiTuong))
            {
                View.ShowMessage("Không được để trống tên đối tượng !");
            }
        }

        public void Save()
        {
            if(_dmdoituonginfo==null)
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
        public void ChoseDTCha()
        {
            frmLookUp_KhachHang frm=new frmLookUp_KhachHang();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.IdCha = frm.SelectedItem.IdCha;
            }
        }
        public void ChoseOrderType()
        {
            frmLookUp_OrderType frm=new frmLookUp_OrderType();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.IdOrderType = frm.SelectedItem.IdOrderType;
            }

        }
        public void GetDiaChiHoaDonByMaDoiTuong()
        {
            View.DataSource = DMDoiTuongDAO.Instance.GetDoiTuongByCode(View.MaDoiTuong);

        }
        public void Exit()
        {
            View.Close();
        }
    }
}
