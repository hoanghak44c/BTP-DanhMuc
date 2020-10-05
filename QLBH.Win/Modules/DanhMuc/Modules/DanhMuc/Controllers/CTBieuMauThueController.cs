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
    public class CTBieuMauThueController:AppBaseTrustedController<ICTBieuMauThueView>,ICTBieuMauThueController 
    {
        private DMTaxCodeInfor _taxcodeinfo =new DMTaxCodeInfor();
        public CTBieuMauThueController(ICTBieuMauThueView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();

        }
        private void GetData()
        {
            _taxcodeinfo = View.taxcodeinfo;
        }
        private void LoadDataSource()
        {
            if(_taxcodeinfo!=null)
            {
                View.IdTaxCode = _taxcodeinfo.IdTaxCode;
                View.Code = _taxcodeinfo.Code;
                View.Name = _taxcodeinfo.Name;
                View.GhiChu = _taxcodeinfo.GhiChu;
                View.SuDung = _taxcodeinfo.SuDung;
                View.GiaTri = _taxcodeinfo.GiaTri;

            }
        }
        private void Insert()
        {
            if(_taxcodeinfo==null)
            {
                _taxcodeinfo=new DMTaxCodeInfor();
                _taxcodeinfo.Code = View.Code;
                _taxcodeinfo.Name = View.Name;
                _taxcodeinfo.GhiChu = View.GhiChu;
                _taxcodeinfo.SuDung = View.SuDung;
                _taxcodeinfo.GiaTri = View.GiaTri;
                _taxcodeinfo.IdTaxCode = DmTaxCodeDAO.Instance.Insert(_taxcodeinfo);
                ((List<DMTaxCodeInfor>)DSBieuMauThueView.Instance.DataSource ).Add(_taxcodeinfo);
                DSBieuMauThueView.Instance.RefreshDataSource();


            }
        }
        private void Update()
        {
            _taxcodeinfo.IdTaxCode = View.IdTaxCode;
            _taxcodeinfo.Code = View.Code;
            _taxcodeinfo.Name = View.Name;
            _taxcodeinfo.GhiChu = View.GhiChu;
            _taxcodeinfo.SuDung = View.SuDung;
            _taxcodeinfo.GiaTri = View.GiaTri;
            DmTaxCodeDAO.Instance.Insert(_taxcodeinfo);
            ((List<DMTaxCodeInfor>)DSBieuMauThueView.Instance.DataSource).Add(_taxcodeinfo);
            DSBieuMauThueView.Instance.RefreshDataSource();
            
        }
        private void Check()
        {
            if(String.IsNullOrEmpty(View.Code))
            {
                throw new InvalidOperationException("Không được để trống mã Taxcode!");
            }
            if(String.IsNullOrEmpty(View.Name))
            {
                throw new InvalidOperationException("Không được để trống tên Taxcode!");
            }
        }
        public void Save()
        {
            if(_taxcodeinfo==null)
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
