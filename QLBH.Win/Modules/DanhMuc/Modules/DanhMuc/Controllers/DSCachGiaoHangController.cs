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
    public class DSCachGiaoHangController:AppBaseTrustedController<IDSCachGiaoHangView >,IDSCachGiaoHangController
    {
        private List<DMCachGiaoHangInfo> oDataSource = null;
        public DSCachGiaoHangController(IDSCachGiaoHangView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            oDataSource = DmCachGiaoHangDAO.Instance.GetListCachGiaoHangInfor();
            View.DataSource = oDataSource;
        }
        public void Search()
        {
            View.DataSource = DmCachGiaoHangDAO.Instance.Search(new DMCachGiaoHangInfo {Ma = View.Ma, Ten = View.Ten});
        }
        public void Add()
        {
            CTCachGiaoHangView.Instance.ShowDialog();
        }
        public void Edit()
        {
            CTCachGiaoHangView.CreateView(View.ItemRowHanle).ShowDialog();
        }
        public void Delete()
        {
            try
            {
                DmCachGiaoHangDAO.Instance.Delete((DMCachGiaoHangInfo)View.ItemRowHanle);
                View.ShowMessage("Xóa dữ liệu thành công");
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

