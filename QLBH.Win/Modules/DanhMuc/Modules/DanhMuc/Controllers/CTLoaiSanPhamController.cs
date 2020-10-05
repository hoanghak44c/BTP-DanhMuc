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
    public class CTLoaiSanPhamController:AppBaseTrustedController<ICTLoaiSanPhamView>,ICTLoaiSanPhamController 
    {
        private DMLoaiSanPhamInfo _SpInfo=new DMLoaiSanPhamInfo();
        public CTLoaiSanPhamController(ICTLoaiSanPhamView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();
            LoadNhomCha();

        }
        private void GetData()
        {
            _SpInfo = View.SanPhamInfo;

        }
        private void LoadDataSource()
        {
            if(_SpInfo!=null)
            {
                View.IdLoaiSP = _SpInfo.IdLoaiSP;
                View.MaLoaiSP = _SpInfo.MaLoaiSP;
                View.TenLoaiSP = _SpInfo.TenLoaiSP;
                View.Nganh = _SpInfo.Nganh;
                View.Chung = _SpInfo.Chung;
                View.Loai = _SpInfo.Loai;
                View.Hang = _SpInfo.Hang;
                View.LinhVuc = _SpInfo.LinhVuc;
                View.Nhom = _SpInfo.Nhom;
                View.Model = _SpInfo.Model;
                View.MoTa = _SpInfo.GhiChu;
                View.NhomCha = _SpInfo.NhomCha;
                View.SuDung = _SpInfo.SuDung;
            }
        }
        private void LoadNhomCha()
        {
            View.NhomChaDataSource = DmLoaiDoiTuongDAO.Instance.GetListLoaiDoiTuongInfor();
        }
        public void ChoseNganh()
        {
            frmLookUp_Nganh frm=new frmLookUp_Nganh();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.Nganh = frm.SelectedItem.Ten;

            }
        }
        public void ChoseChung()
        {
            frmLookUp_Chung frm=new frmLookUp_Chung();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.Chung = frm.SelectedItem.Ten;
            }
        }
        public void ChoseHang()
        {
            frmLookUp_Hang frm=new frmLookUp_Hang();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.Hang = frm.SelectedItem.Ten;
            }
        }
        public void ChoseLinhVuc()
        {
            frmLookUp_LinhVuc frm=new frmLookUp_LinhVuc();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.LinhVuc = frm.SelectedItem.Ten;
            }
        }
        public void ChoseLoai()
        {
            frmLookUp_Loai frm=new frmLookUp_Loai();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.Loai = frm.SelectedItem.Ten;
            }
        }
        public void ChoseNhom()
        {
            frmLookUp_Nhom frm=new frmLookUp_Nhom();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.Nhom = frm.SelectedItem.Ten;
            }
        }
        public void ChoseModel()
        {
            frmLookUp_Model frm=new frmLookUp_Model();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.Model = frm.SelectedItem.Ten;
            }
        }
        public void Insert()
        {
            if(_SpInfo==null)
            {
                _SpInfo=new DMLoaiSanPhamInfo();
       
                _SpInfo.MaLoaiSP = View.MaLoaiSP;
                _SpInfo.TenLoaiSP = View.TenLoaiSP;
                _SpInfo.Nganh = View.Nganh;
                _SpInfo.Chung = View.Chung;
                _SpInfo.Loai = View.Loai;
                _SpInfo.Hang = View.Hang;
                _SpInfo.LinhVuc = View.LinhVuc;
                _SpInfo.Nhom = View.Nhom;
                _SpInfo.Model = View.Model;
                _SpInfo.GhiChu = View.MoTa;
                _SpInfo.NhomCha = View.NhomCha;
                _SpInfo.SuDung = View.SuDung;
                _SpInfo.IdLoaiSP = DMLoaiSPDAO.Instance.Insert(_SpInfo);
                ((List<DMLoaiSanPhamInfo>)DSLoaiSanPhamView.Instance.DataSource).Add(_SpInfo);
                DSLoaiSanPhamView.Instance.RefreshDataSource();
            }
           

        }
        public void Upadte()
        {
            
            _SpInfo.IdLoaiSP = View.IdLoaiSP;
            _SpInfo.MaLoaiSP = View.MaLoaiSP;
            _SpInfo.TenLoaiSP = View.TenLoaiSP;
            _SpInfo.Nganh = View.Nganh;
            _SpInfo.Chung = View.Chung;
            _SpInfo.Loai = View.Loai;
            _SpInfo.Hang = View.Hang;
            _SpInfo.LinhVuc = View.LinhVuc;
            _SpInfo.Nhom = View.Nhom;
            _SpInfo.Model = View.Model;
            _SpInfo.GhiChu = View.MoTa;
            _SpInfo.NhomCha = View.NhomCha;
            _SpInfo.SuDung = View.SuDung;
            DMLoaiSPDAO.Instance.Update(_SpInfo);
            ((List<DMLoaiSanPhamInfo>)DSLoaiSanPhamView.Instance.DataSource).Add(_SpInfo);
            DSLoaiSanPhamView.Instance.RefreshDataSource();

        }
        private void Check()
        {
            if(String.IsNullOrEmpty(View.MaLoaiSP))
            {
                throw new InvalidOperationException("Không được để trống mã loại sản phẩm!");

            }
            if(String.IsNullOrEmpty(View.TenLoaiSP))
            {
                throw new InvalidOperationException("Không được để trống tên loại sản phầm !");

            }
        }
        public void Save()
        {
            if(_SpInfo==null)
            {
                Check();
                Insert();
                View.ShowMessage("Thêm dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
            else
            {
                Check();
                Upadte();
                View.ShowMessage("Cập nhật dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
        }
        public void Exit()
        {
            View.Close();
        }
        
    }
}
