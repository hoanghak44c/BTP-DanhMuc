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
    public class CTPhuongThucBanHangController : AppBaseTrustedController<ICTPhuongThucBanHangView>, ICTPhuongThucBanHangController
    {
        private DMPhuongThucBanHangInfo _oPhuongThucBanHang = new DMPhuongThucBanHangInfo();

        public CTPhuongThucBanHangController(ICTPhuongThucBanHangView view)
            : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();

        }
        private void GetData()
        {
            _oPhuongThucBanHang = View._PhuongThucBanHangInfo;
        }
        private void LoadDataSource()
        {
            if (_oPhuongThucBanHang != null)
            {
                View.IdPhuongThucBanHang = _oPhuongThucBanHang.IdPhuongThucBH;
                View.Ma = _oPhuongThucBanHang.Ma;
                View.Ten = _oPhuongThucBanHang.Ten;
                View.GhiChu = _oPhuongThucBanHang.GhiChu;
                View.SuDung = _oPhuongThucBanHang.SuDung;
            }
        }
        public void Insert()
        {
            if (_oPhuongThucBanHang == null)
            {
                _oPhuongThucBanHang = new DMPhuongThucBanHangInfo();
                _oPhuongThucBanHang.Ma = View.Ma;
                _oPhuongThucBanHang.Ten = View.Ten;
                _oPhuongThucBanHang.GhiChu = View.GhiChu;
                _oPhuongThucBanHang.SuDung = View.SuDung;
                _oPhuongThucBanHang.IdPhuongThucBH = DmPhuongThucBanHangDAO.Instance.Insert(_oPhuongThucBanHang);
                ((List<DMPhuongThucBanHangInfo>)DSPhuongThucBanHangView.Instance.DataSource).Add(_oPhuongThucBanHang);
                DSPhuongThucBanHangView.Instance.RefreshDataSource();
            }
        }
        public void Update()
        {
            _oPhuongThucBanHang.IdPhuongThucBH = View.IdPhuongThucBanHang;
            _oPhuongThucBanHang.Ma = View.Ma;
            _oPhuongThucBanHang.Ten = View.Ten;
            _oPhuongThucBanHang.GhiChu = View.GhiChu;
            _oPhuongThucBanHang.SuDung = View.SuDung;
            DmPhuongThucBanHangDAO.Instance.Update(_oPhuongThucBanHang);
            ((List<DMPhuongThucBanHangInfo>)DSPhuongThucBanHangView.Instance.DataSource).Add(_oPhuongThucBanHang);
            DSPhuongThucBanHangView.Instance.RefreshDataSource();
        }
        private void Check()
        {
            if(String.IsNullOrEmpty(View.Ma))
            {
               throw new InvalidOperationException("Không được để trống mã phương thức bán hàng !");
            }
            if(String.IsNullOrEmpty(View.Ten))
            {
                throw new InvalidOperationException("Không được để trống tên phương thức!");
            }

        }
        public void Save()
        {
            if(_oPhuongThucBanHang==null)
            {
                Check();
                Insert();
                View.ShowMessage("Thêm mới thành công !");
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
