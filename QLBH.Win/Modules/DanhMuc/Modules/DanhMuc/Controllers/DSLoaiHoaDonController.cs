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
    public class DSLoaiHoaDonController:AppBaseTrustedController<IDSLoaiHoaDonView >,IDSLoaiHoaDonController
    {
        //private List<DMLoaiHoaDonInfo> oDataSource = null;
        public DSLoaiHoaDonController(IDSLoaiHoaDonView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            View.DataSource = DmLoaiHoaDonDAO.Instance.GetListLoaiHoaDonInfor();
            
        }
        public void Search()
        {
            View.DataSource = DmLoaiHoaDonDAO.Instance.Search(new DMLoaiHoaDonInfo {KyHieu = View.Ma, Ten = View.Ten});
        }
        public void Add()
        {
            CTLoaiHoaDonView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTLoaiHoaDonView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DmLoaiHoaDonDAO.Instance.Delete((DMLoaiHoaDonInfo)View.ItemRowHanle);
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
