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
    public class DSPhuongThucBanHangController:AppBaseTrustedController<IDSPhuongThucBanHangView >,IDSPhuongThucBanHangController
    {
        private List<DMPhuongThucBanHangInfo> oDataSource = null;
        public DSPhuongThucBanHangController(IDSPhuongThucBanHangView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            oDataSource = DmPhuongThucBanHangDAO.Instance.GetListPhuongThucBanHangInfor();
            View.DataSource = oDataSource;
        }
        public void Search()
        {
            View.DataSource =
                DmPhuongThucBanHangDAO.Instance.Search(new DMPhuongThucBanHangInfo {Ma = View.Ma, Ten = View.Ten});
        }
        public void Add()
        {
            CTPhuongThucBanHangView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTPhuongThucBanHangView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DmPhuongThucBanHangDAO.Instance.Delete((DMPhuongThucBanHangInfo)View.ItemRowHanle);
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
