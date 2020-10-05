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
    public class CTOrderTypeController:AppBaseTrustedController<ICTOrderTypeView >,ICTOrderTypeController 
    {
        private DMOrderTypeInfor _orderinfo=new DMOrderTypeInfor();
        public CTOrderTypeController(ICTOrderTypeView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();
            LoadNganh();


        }
        private void GetData()
        {
            _orderinfo = View.OrderInfo;

        }
        private void LoadDataSource()
        {
            if(_orderinfo!=null)
            {
                View.IdOrderType = _orderinfo.IdOrderType;
                View.OrderType = _orderinfo.OrderType;
                View.Name = _orderinfo.Name;
                View.GhiChu = _orderinfo.GhiChu;
                View.SuDung = _orderinfo.SuDung;
                View.LineType = _orderinfo.LineType;
                View.LineCk = _orderinfo.LineCk;
                View.LineKm = _orderinfo.LineKm;
                View.NganhHang = _orderinfo.NganhHang;

            }
            
        }
        private void LoadNganh()
        {
            View.NganhHangDataSource=DmNganhDAO.Instance.GetListSegmentInfor();
        }
        private void Insert()
        {
            if(_orderinfo==null)
            {
                _orderinfo=new DMOrderTypeInfor();
                _orderinfo.OrderType = View.OrderType;
                _orderinfo.Name = View.Name;
                _orderinfo.GhiChu = View.GhiChu;
                _orderinfo.SuDung = View.SuDung;
                _orderinfo.LineType = View.LineType;
                _orderinfo.LineCk = View.LineCk;
                _orderinfo.LineKm = View.LineKm;
                _orderinfo.NganhHang = View.NganhHang;
                
                _orderinfo.IdOrderType = DmOrderTypeDAO.Instance.Insert(_orderinfo);
                ((List<DMOrderTypeInfor>)DSOrderTypeView.Instance.DataSource ).Add(_orderinfo);
                DSOrderTypeView.Instance.RefreshDataSource();
            }
        }
        private void Update()
        {
            _orderinfo.IdOrderType = View.IdOrderType;
            _orderinfo.OrderType = View.OrderType;
            _orderinfo.Name = View.Name;
            _orderinfo.GhiChu = View.GhiChu;
            _orderinfo.SuDung = View.SuDung;
            _orderinfo.LineType = View.LineType;
            _orderinfo.LineCk = View.LineCk;
            _orderinfo.LineKm = View.LineKm;
            _orderinfo.NganhHang = View.NganhHang;
            
             DmOrderTypeDAO.Instance.Update(_orderinfo);
            ((List<DMOrderTypeInfor>)DSOrderTypeView.Instance.DataSource).Add(_orderinfo);
            DSOrderTypeView.Instance.RefreshDataSource();
        }
        private void Check()
        {
            if(String.IsNullOrEmpty(View.OrderType))
            {
                throw new InvalidOperationException("Không được để trống mã ordertype!");
            }
            if(String.IsNullOrEmpty(View.Name))
            {
                throw new InvalidOperationException("Không được để trống tên ordertype");

            }
        }
        public void Save()
        {
            if(_orderinfo==null)
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
                View.DialogResult=DialogResult.OK;
            }
        }
        public void Exit()
        {
            View.Close();
        }
        
    }
}
