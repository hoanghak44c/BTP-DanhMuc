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
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
    public class DSBieuMauThueController:AppBaseTrustedController<IDSBieuMauThueView>,IDSBieuMauThueController
    {
        private List<DMTaxCodeInfor> oDataSource = null;
        public DSBieuMauThueController(IDSBieuMauThueView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            oDataSource = DmTaxCodeDAO.Instance.GetListTaxCodeInfo();
            View.DataSource = oDataSource;
        }
        public void Search()
        {
            View.DataSource =
                DmTaxCodeDAO.Instance.Search(new DMTaxCodeInfor {Code = View.MaTaxCode, Name = View.TenTaxCode});

        }
        public void Add()
        {
            CTBieuMauThueView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTBieuMauThueView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {

            try
            {
                DmTaxCodeDAO.Instance.Delete((DMTaxCodeInfor)View.ItemRowHanle);
                View.ShowMessage("Xóa dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                
                throw new ManagedException(ex.Message);
            }
            

        }
        public void Exit()
        {
            View.Close();
        }
    }
}
