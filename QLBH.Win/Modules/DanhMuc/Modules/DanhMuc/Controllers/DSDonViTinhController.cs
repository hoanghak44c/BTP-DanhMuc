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
    public class DSDonViTinhController:AppBaseTrustedController<IDSDonViTinhView>,IDSDonViTinhController
    {
       

        public DSDonViTinhController(IDSDonViTinhView view) : base(view)
        {

        }

        protected override void DisplayViewInfo()
        {
            View.DataSource = DmDonViTinhDAO.Instance.GetListDonViTinhInfo();
           

        }
        public void Search()
        {
            View.DataSource = DmDonViTinhDAO.Instance.Search(new DMDonViTinhInfor{TenDonViTinh = View.TenDonViTinh,KyHieu = View.MaDonViTinh});
        }
        public void Add()
        {
            CTDonViTinhView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTDonViTinhView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DmDonViTinhDAO.Instance.Delete((DMDonViTinhInfor)View.ItemRowHanle);
                View.ShowMessage("Xóa dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                
                throw new ManagedException(ex.Message);
            }
            
        }
        public  void Exit()
        {
            View.Close();
        }
    }
}
