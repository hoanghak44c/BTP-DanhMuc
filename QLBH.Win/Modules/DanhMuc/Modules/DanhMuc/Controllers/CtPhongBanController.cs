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
    public class CTPhongBanController:AppBaseTrustedController<ICTPhongBanView>,ICTPhongBanController
    {
        private DMPhongBanInfor objPhongBan=new DMPhongBanInfor();
        public CTPhongBanController(ICTPhongBanView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();
        }
        private void GetData()
        {
            objPhongBan = View.PhongBanInfor;
        }
        private void LoadDataSource()
        {
            if(objPhongBan!=null)
            {
                View.Id = objPhongBan.IdPhongBan;
                View.MaPhongBan = objPhongBan.MaPhongBan;
                View.TenPhongBan = objPhongBan.TenPhongBan;
                View.GhiChu = objPhongBan.GhiChu;
                View.SuDung = objPhongBan.SuDung;

            }
        }
        public void Insert()
        {
            if(objPhongBan==null)
            {
                objPhongBan=new DMPhongBanInfor();
                objPhongBan.MaPhongBan = View.MaPhongBan;
                objPhongBan.TenPhongBan = View.TenPhongBan;
                objPhongBan.GhiChu = View.GhiChu;
                objPhongBan.SuDung = View.SuDung;
                objPhongBan.IdPhongBan = DmPhongBanDAO.Instance.Insert(objPhongBan);
                ((List<DMPhongBanInfor>)DSPhongBanView.Instance.DataSource).Add(objPhongBan);
                DSPhongBanView.Instance.RefreshDataSource();
            }
        }
        public void Update()
        {
            if(objPhongBan!=null)
            {
                objPhongBan.MaPhongBan = View.MaPhongBan;
                objPhongBan.TenPhongBan = View.TenPhongBan;
                objPhongBan.GhiChu = View.GhiChu;
                objPhongBan.SuDung = View.SuDung;
                DmPhongBanDAO.Instance.Update(objPhongBan);
                ((List<DMPhongBanInfor>)DSPhongBanView.Instance.DataSource).Add(objPhongBan);
                DSPhongBanView.Instance.RefreshDataSource();

            }
        }
        public void Check()
        {
            if(string.IsNullOrEmpty(View.MaPhongBan))
            {
                throw new InvalidOperationException("Không được để trống mã phòng ban!");
            }
            if(string.IsNullOrEmpty(View.TenPhongBan))
            {
                throw new InvalidOperationException("Không được để trống tên phòng ban!");
            }
        }
        public  void Save()
        {
            if(objPhongBan==null)
            {
                Check();
                Insert();
                View.ShowMessage("Thêm dữ liệu thành công");
                View.DialogResult = DialogResult.OK;
            }
            else
            {
                Check();
                Update();
                View.ShowMessage("Sửa dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
        }
        public void Exit()
        {
            View.Close();
        }
        
    }
}
