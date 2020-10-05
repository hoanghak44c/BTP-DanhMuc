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
    public class DSLoaiSanPhamController:AppBaseTrustedController<IDSLoaiSanPhamView>,IDSLoaiSanPhamController
    {
        //private List<DMLoaiSanPhamInfo> oDataSource = null;
        public DSLoaiSanPhamController(IDSLoaiSanPhamView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            View.DataSource = DMLoaiSPDAO.Instance.GetListLoaiSPInfo();
          
        }
        public void Search()
        {
            View.DataSource =
                DMLoaiSPDAO.Instance.Search(new DMLoaiSanPhamInfo
                                                {MaLoaiSP = View.MaLoaiSanPham, TenLoaiSP = View.TenLoaiSanPham});

        }
        public void Add()
        {
            CTLoaiSanPhamView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTLoaiSanPhamView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DMLoaiSPDAO.Instance.Delete((DMLoaiSanPhamInfo)View.ItemRowHanle);
                View.ShowMessage("Xóa dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                
                throw new Exception(ex.Message);
            }
        }
        public void Exit()
        {
            View.Close();
        }
        

    }
    
}
