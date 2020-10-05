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
    public class CTLoaiHoaDonController:AppBaseTrustedController<ICTLoaiHoaDonView >,ICTLoaiHoaDonController 
    {
        private DMLoaiHoaDonInfo _hoadoninfo=new DMLoaiHoaDonInfo();
        public CTLoaiHoaDonController(ICTLoaiHoaDonView view) : base(view)
        {

        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();
        }
        private void GetData()
        {
            _hoadoninfo = View.hoadoninfo;
        }
        private void LoadDataSource()
        {
            if(_hoadoninfo!=null)
            {
                View.IdLoaiHoaDon = _hoadoninfo.Id;
                View.KyHieu = _hoadoninfo.KyHieu;
                View.Ten = _hoadoninfo.Ten;
                View.GhiChu = _hoadoninfo.GhiChu;
                View.SuDung = _hoadoninfo.SuDung;

            }
            
        
        }
        private void Insert()
        {
            if(_hoadoninfo==null)
            {
                _hoadoninfo=new DMLoaiHoaDonInfo();
                _hoadoninfo.KyHieu = View.KyHieu;
                _hoadoninfo.Ten = View.Ten;
                _hoadoninfo.GhiChu = View.GhiChu;
                _hoadoninfo.SuDung = View.SuDung;
                _hoadoninfo.Id = DmLoaiHoaDonDAO.Instance.Insert(_hoadoninfo);
                ((List<DMLoaiHoaDonInfo>)DSLoaiHoaDonView.Instance.DataSource ).Add(_hoadoninfo);
                DSLoaiHoaDonView.Instance.RefreshDataSource();
            }
        }
        private void Update()
        {
            _hoadoninfo.Id = View.IdLoaiHoaDon;
            _hoadoninfo.KyHieu = View.KyHieu;
            _hoadoninfo.Ten = View.Ten;
            _hoadoninfo.GhiChu = View.GhiChu;
            _hoadoninfo.SuDung = View.SuDung;
          DmLoaiHoaDonDAO.Instance.Update(_hoadoninfo);
            ((List<DMLoaiHoaDonInfo>)DSLoaiHoaDonView.Instance.DataSource).Add(_hoadoninfo);
            DSLoaiHoaDonView.Instance.RefreshDataSource();
        }
        private void Check()
        {
            if(String.IsNullOrEmpty(View.KyHieu))
            {
                throw new InvalidOperationException("Không được để trống ký hiệu hóa đơn ");
            }
            if(String.IsNullOrEmpty(View.Ten))
            {
                throw new InvalidOperationException("Không được để trống tên loại hóa đơn ");
            }
        }
        public void Save()
        {
            if(_hoadoninfo==null)
            {
                Check();
                Insert();
                View.ShowMessage("Thêm dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
            else
            {
                Update();
                View.ShowMessage("Sửa dữ liệu thành côn !");
                View.DialogResult = DialogResult.OK;
            }
        }
        public void Exit()
        {
            View.Close();
        }
    }
}
