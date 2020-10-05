using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Internal;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Form2;
using QLBH.Core.Exceptions;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
    public class DSPhongBanController:AppBaseTrustedController<IDSPhongBanView>,IDSPhongBanController
    {
        //private List<DMPhongBanInfor> oDataSource = null;
        public DSPhongBanController(IDSPhongBanView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
                            
          View.DataSource  = DmPhongBanDAO.Instance.GetListPhongBanInfor();
          
        }
        public  void Add()
        {
            CTPhongBanView.Instance.ShowDialog();
        }
        public void Search()
        {
            View.DataSource = DmPhongBanDAO.Instance.Search(new DMPhongBanInfor{MaPhongBan = View.MaPhongBan,TenPhongBan = View.TenPhongBan});
        }
        public void Edit()
        {
            CTPhongBanView.CreateView(View.ItemRowHanle).ShowDialog();
        }

        public void Exit()
        {
            View.Close();
        }

        public void Delete()
        {
            try
            {
                DmPhongBanDAO.Instance.Delete((DMPhongBanInfor)View.ItemRowHanle);
                View.ShowMessage("Xóa dữ liệu thành công !");
                View.RefreshDataSource();
            }
            catch (Exception ex)
            {
                
                throw new ManagedException(ex.Message);
            }
        }
    }
}
