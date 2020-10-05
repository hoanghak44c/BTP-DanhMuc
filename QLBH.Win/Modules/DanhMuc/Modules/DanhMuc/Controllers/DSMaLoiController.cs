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
    public class DSMaLoiController:AppBaseTrustedController<IDSMaLoiView>,IDSMaLoiController
    {
        //private List<DMMaLoiInfor> oDataSource = null;

        public DSMaLoiController(IDSMaLoiView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
           View.DataSource = DmMaLoiDAO.Instance.GetListMaLoiInfor();
         

        }
        public void Search()
        {
            View.DataSource = DmMaLoiDAO.Instance.Search(new DMMaLoiPairInfor {MaLoi = View.MaLoi, TenLoi = View.TenLoi});

        }
        public void Add()
        {
            CTMaLoiView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTMaLoiView.CreateView(View.ItemRowHanle).ShowDialog();

        }
        public void Delete()
        {
            try
            {
                DmMaLoiDAO.Instance.Delete((DMMaLoiInfor)View.ItemRowHanle);
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
