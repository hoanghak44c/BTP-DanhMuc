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
    public class DSChiPhiController:AppBaseTrustedController<IDSChiPhiView >,IDSChiPhiController
    {
  
        public DSChiPhiController(IDSChiPhiView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
           View.DataSource = DmChiPhiDAO.Instance.GetListChiPhiInfor();
          

        }
        public void Search()
        {
            View.DataSource = DmChiPhiDAO.Instance.Search(new DMChiPhiInfo {Ma = View.Ma, Ten = View.Ten});
            
        }
        public void Add()
        {
            CTChiPhiView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTChiPhiView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Exit()
        {
            View.Close();
        }
        public void Delete()
        {
            try
            {
                DmChiPhiDAO.Instance.Delete((DMChiPhiInfo)View.ItemRowHanle);
                View.ShowMessage("Xóa dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                
                throw new ManagedException(ex.Message);
            }
            
        }
    }
}
