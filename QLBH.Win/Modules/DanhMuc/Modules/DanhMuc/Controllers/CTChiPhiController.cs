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
    public class CTChiPhiController:AppBaseTrustedController<ICTChiPhiView>,ICTChiPhiController 
    {
        DMChiPhiInfo _chiphiinfo=new DMChiPhiInfo();
        public CTChiPhiController(ICTChiPhiView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();

        }
        private void GetData()
        {
            _chiphiinfo = View.chiphiinfo;
        }
        private void LoadDataSource()
        {
            if(_chiphiinfo!=null)
            {
                View.IdChiPhi = _chiphiinfo.IdChiPhi;
                View.Ten = _chiphiinfo.Ten;
                View.Ma = _chiphiinfo.Ma;
                View.GhiChu = _chiphiinfo.GhiChu;
                View.SuDung = _chiphiinfo.SuDung;
            }
        }
        private void Insert()
        {
            if(_chiphiinfo==null)
            {
                _chiphiinfo=new DMChiPhiInfo();
                _chiphiinfo.Ma = View.Ma;
                _chiphiinfo.Ten = View.Ten;
                _chiphiinfo.GhiChu = View.GhiChu;
                _chiphiinfo.SuDung = View.SuDung;
                _chiphiinfo.IdChiPhi = DmChiPhiDAO.Instance.Insert(_chiphiinfo);
                ((List<DMChiPhiInfo>)DSChiPhiView.Instance.DataSource ).Add(_chiphiinfo);
                DSChiPhiView.Instance.RefreshDataSource();

            }
        }
        private void Update()
        {
            _chiphiinfo.IdChiPhi = View.IdChiPhi;
            _chiphiinfo.Ma = View.Ma;
            _chiphiinfo.Ten = View.Ten;
            _chiphiinfo.GhiChu = View.GhiChu;
            _chiphiinfo.SuDung = View.SuDung;
             DmChiPhiDAO.Instance.Update(_chiphiinfo);
            ((List<DMChiPhiInfo>)DSChiPhiView.Instance.DataSource).Add(_chiphiinfo);
            DSChiPhiView.Instance.RefreshDataSource();
        }
        private void Check()
        {
            if(String.IsNullOrEmpty(View.Ma))
            {
                throw new InvalidOperationException("Không được để trống mã chi phí");

            }
            if(String.IsNullOrEmpty(View.Ten))
            {
                throw new InvalidOperationException("Không được để trống tên chi phí");
            }
        }
        public void Save()
        {
            if(_chiphiinfo==null)
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
