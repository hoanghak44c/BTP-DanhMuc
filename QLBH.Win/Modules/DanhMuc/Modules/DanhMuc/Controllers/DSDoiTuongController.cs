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
    public class DSDoiTuongController:AppBaseTrustedController<IDSDoiTuongView>,IDSDoiTuongController
    {
        
        public DSDoiTuongController(IDSDoiTuongView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
         View.DataSource = DMDoiTuongDAO.Instance.GetListDoiTuongInfo();
           
        }
        public void Search()
        {
            View.DataSource = DMDoiTuongDAO.Instance.Search(new DMDoiTuongInfo{MaDoiTuong = View.MaDoiTuong,
            TenDoiTuong = View.TenDoiTuong});

        }
        public void Add()
        {
            CTDoiTuongView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTDoiTuongView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DMDoiTuongDAO.Instance.Delete((DMDoiTuongInfo)View.ItemRowHanle);
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
