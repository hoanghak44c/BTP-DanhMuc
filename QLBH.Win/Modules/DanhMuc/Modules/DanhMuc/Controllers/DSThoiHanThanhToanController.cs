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
    public class DSThoiHanThanhToanController:AppBaseTrustedController<IDSThoiHanThanhToanView>,IDSThoiHanThanhToanController
    {
        //private List<DMLoaiThuChiInfor> oDataSource = null;
        public DSThoiHanThanhToanController(IDSThoiHanThanhToanView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
                            
            View.DataSource= DmLoaiThuChiDAO.Instance.GetListLoaiThuChiInfor();
           
        }
        public void Search()
        {
            View.DataSource = DmLoaiThuChiDAO.Instance.Search(new DMLoaiThuChiInfor {KyHieu = View.Ma, Ten = View.Ten});
        }
        public void Add()
        {
            CTThoiHanThanhToanView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTThoiHanThanhToanView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DmLoaiThuChiDAO.Instance.Delete((DMLoaiThuChiInfor)View.ItemRowHanle);
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
