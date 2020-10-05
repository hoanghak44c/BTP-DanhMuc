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
    public class  DSKhoController:AppBaseTrustedController<IDSKhoView>,IDSKhoController
    {
     
        public DSKhoController(IDSKhoView view) : base(view)
        {
            
        }

        protected override void DisplayViewInfo()
        {
          View.DataSource = DMKhoDAO.Instance.GetListKhoInfo();
           
        }
        public void Search()
        {
            View.DataSource = DMKhoDAO.Instance.Search(new DMKhoGridLoadInfo{MaKho = View.MaKho,TenKho =View.TenKho});
        }
        public void Add()
        {
            CTKhoView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTKhoView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Exit()
        {
            View.Close();
        }
        public void Delete()
        {
            try
            {
                DMKhoDAO.Instance.Delete((DMKhoInfo)View.ItemRowHanle);
                DSKhoView.Instance.RefreshDataSource();
                View.ShowMessage("Xóa Dữ Liệu Thành Công !");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
           
        }
    }
}
