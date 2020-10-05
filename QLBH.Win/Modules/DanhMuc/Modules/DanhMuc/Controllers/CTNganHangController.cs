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
    public class CTNganHangController:AppBaseTrustedController<ICTNganHangView >,ICTNganHangController 
    {
        private DMNganHangInfor _nganhanginfor=new DMNganHangInfor();
        public CTNganHangController(ICTNganHangView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();


        }
        private void GetData()
        {
            _nganhanginfor = View.nganhanginfor;

        }
        private void LoadDataSource()
        {
            if(_nganhanginfor!=null)
            {
                View.IdNganHang = _nganhanginfor.IdNganHang;
                View.TenNganHang = _nganhanginfor.TenNganHang;
                View.MaNganHang = _nganhanginfor.MaNganHang;
                View.GhiChu = _nganhanginfor.GhiChu;
                View.SuDung = _nganhanginfor.SuDung;

            }
        }
        private void Insert()
        {
            if(_nganhanginfor==null)
            {
                _nganhanginfor=new DMNganHangInfor();
                _nganhanginfor.MaNganHang = View.MaNganHang;
                _nganhanginfor.TenNganHang = View.TenNganHang;
                _nganhanginfor.GhiChu = View.GhiChu;
                _nganhanginfor.SuDung = View.SuDung;
                _nganhanginfor.IdNganHang = DmNganHangDAO.Instance.Insert(_nganhanginfor);
                ((List<DMNganHangInfor>)DSNganHangView.Instance.DataSource ).Add(_nganhanginfor);
                DSNganHangView.Instance.RefreshDataSource();


            }
        }
        private void Update()
        {
            _nganhanginfor.IdNganHang = View.IdNganHang;
            _nganhanginfor.MaNganHang = View.MaNganHang;
            _nganhanginfor.TenNganHang = View.TenNganHang;
            _nganhanginfor.GhiChu = View.GhiChu;
            _nganhanginfor.SuDung = View.SuDung;
            DmNganHangDAO.Instance.Update(_nganhanginfor);
            ((List<DMNganHangInfor>)DSNganHangView.Instance.DataSource).Add(_nganhanginfor);
            DSNganHangView.Instance.RefreshDataSource();
        }
        private void Check()
        {
            if(String.IsNullOrEmpty(View.MaNganHang))
            {
                throw new InvalidOperationException("Không được để trống mã ngân hàng !");

            }
            if(String.IsNullOrEmpty(View.TenNganHang))
            {
                throw new InvalidOperationException("Không được để trống tên ngân hàng !");
            }
        }
        public void Save()
        {
            if(_nganhanginfor==null)
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
