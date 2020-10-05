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
    public class DSLyDoTraHangController:AppBaseTrustedController<IDSLyDoTraHangView >,IDSLyDoTraHangController
    {
        //private List<DMLyDoTraHangInfo> oDataSource = null;
        public DSLyDoTraHangController(IDSLyDoTraHangView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
           View.DataSource = DmLyDoTraHangDAO.Instance.GetListLyDoTraHangInfor();
          
        }
        public void Search()
        {
            View.DataSource =
                DmLyDoTraHangDAO.Instance.Search(new DMLyDoTraHangInfo {MaLyDo = View.MaLyDo, Ten = View.LyDo});

        }
        public void Add()
        {
            CTLyDoTraHangView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTLyDoTraHangView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Exit()
        {
            View.Close();
        }
        public void Delete()
        {
            try
            {
                DmLyDoTraHangDAO.Instance.Delete((DMLyDoTraHangInfo)View.ItemRowHanle);
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
