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
    public class DSHangHoaController:AppBaseTrustedController<IDSHangHoaView>,IDSHangHoaController
    {
   

        public DSHangHoaController(IDSHangHoaView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
           View.DataSource= DMSanPhamDAO.Instance.GetListSanPhamInfo();
            

        }
        public void Search()
        {
            View.DataSource =
                DMSanPhamDAO.Instance.Search(new DMSanPhamInfo {MaSanPham = View.Ma, TenSanPham = View.Ten});

        }
        public void Add()
        {
            CTHangHoaView.Instance.ShowDialog();

        }
        public void Edit()
        {
            CTHangHoaView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DMSanPhamDAO.Instance.Delete((DMSanPhamInfo)View.ItemRowHanle);
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
