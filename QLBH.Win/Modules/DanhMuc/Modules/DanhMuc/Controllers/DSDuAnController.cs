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
    public class DSDuAnController:AppBaseTrustedController<IDSDuAnView >,IDSDuAnController
    {
       

        public DSDuAnController(IDSDuAnView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            View.DataSource = DmDuAnDAO.Instance.GetListDuAnInfor();
            

        }
        public void Search()
        {
            View.DataSource = DmDuAnDAO.Instance.Search(new DMDuAnInfor {MaDuAn = View.Ma, TenDuAn = View.Ten});

        }
        public void Add()
        {
            CTDuAnView.Instance.ShowDialog();

        }
        public void Edit()
        {
            CTDuAnView.CreateView(View.ItemRowHanle).ShowDialog();

        }
        public void Delete()
        {
            try
            {
                DmDuAnDAO.Instance.Delete((DMDuAnInfor)View.ItemRowHanle);
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
