using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using QLBanHang.Modules.DanhMuc.Controllers.IControllers;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Views;
using QLBanHang.Modules.DanhMuc.Views.IViews;
using QLBH.Core.Controllers;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.Controllers
{
    public class CTCauHinhSanPhamController:AppBaseTrustedController<ICTCauHinhSanPhamView>,ICTCauHinhSanPhamController
    {
        private List<DMCauHinhSanPhamInfo> oDataSource = null;
        DMCauHinhSanPhamInfo _cauhinhinfo=new DMCauHinhSanPhamInfo();
        public CTCauHinhSanPhamController(ICTCauHinhSanPhamView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();
            oDataSource = DmCauHinhSanPhamDAO.Instance.GetCauHinhByIdSanPham(View.IdSanPham);
            View.DataSource = oDataSource;

        }
        public void SearchByIdSP()
        {
            View.DataSource = DmCauHinhSanPhamDAO.Instance.GetCauHinhByIdSanPham(View.IdSanPham);
        }
        private void  GetData()
        {
            _cauhinhinfo = View.cauhinhspinfo;
        }
        private void LoadDataSource()
        {
            if(_cauhinhinfo!=null)
            {
                View.IdSanPham = _cauhinhinfo.IdSanPham;
                View.TenCauHinh = _cauhinhinfo.TenCauHinh;
                View.SoTT = _cauhinhinfo.SoTT;
                View.GiaTri = _cauhinhinfo.GiaTri;
                View.Hang = _cauhinhinfo.Hang;
                View.logo = _cauhinhinfo.Logo;


            }
        }
        public void Insert()
        {
            if(_cauhinhinfo==null)
            {
               
                _cauhinhinfo.IdSanPham = View.IdSanPham;
                _cauhinhinfo.TenCauHinh = View.TenCauHinh;
                _cauhinhinfo.GiaTri = View.GiaTri;
                _cauhinhinfo.Hang = View.Hang;
                _cauhinhinfo.Logo = View.logo;
                _cauhinhinfo.SoTT = View.SoTT;
                List<DMCauHinhSanPhamInfo> list = new List<DMCauHinhSanPhamInfo>();
                _cauhinhinfo = new DMCauHinhSanPhamInfo();
                for (int i = 0; i < list.Count; i++)
                {
                    DMCauHinhSanPhamInfo infor = list[i];
                     DmCauHinhSanPhamDAO.Instance.Insert(_cauhinhinfo.IdSanPham, infor.TenCauHinh,
                                                                    _cauhinhinfo.GiaTri, _cauhinhinfo.SoTT);
                }
                ((List<DMCauHinhSanPhamInfo>)DSCauHinhSanPhamView.Instance.DataSource ).Add(_cauhinhinfo);
                DSCauHinhSanPhamView.Instance.RefreshDataSource();



            }
            
        }
        public void Update()
        {
            _cauhinhinfo.IdSanPham = View.IdSanPham;
            _cauhinhinfo.TenCauHinh = View.TenCauHinh;
            _cauhinhinfo.GiaTri = View.GiaTri;
            _cauhinhinfo.Hang = View.Hang;
            _cauhinhinfo.Logo = View.logo;
            _cauhinhinfo.SoTT = View.SoTT;
            List<DMCauHinhSanPhamInfo> list = new List<DMCauHinhSanPhamInfo>();
            _cauhinhinfo = new DMCauHinhSanPhamInfo();
            for (int i = 0; i < list.Count; i++)
            {
                DMCauHinhSanPhamInfo infor = list[i];
                DmCauHinhSanPhamDAO.Instance.Update(_cauhinhinfo.IdSanPham, infor.TenCauHinh,
                                                               _cauhinhinfo.GiaTri, _cauhinhinfo.SoTT);
            }
            ((List<DMCauHinhSanPhamInfo>)DSCauHinhSanPhamView.Instance.DataSource).Add(_cauhinhinfo);
            DSCauHinhSanPhamView.Instance.RefreshDataSource();
            
        }
        public void Updatelogo()
        {
            _cauhinhinfo.IdSanPham = View.IdSanPham;
            _cauhinhinfo.Logo = View.logo;
            DmCauHinhSanPhamDAO.Instance.UpdateLogo(View.IdSanPham,View.logo);
        }
        private void Check()
        {
            if(String.IsNullOrEmpty(Convert.ToString(View.IdSanPham)))
            {
                throw new InvalidOperationException("Chưa chọn mã sản phẩm !");
            }
        }
        public void ChonSP()
        {
            frmLookUp_SanPham frm=new frmLookUp_SanPham();
            if(frm.ShowDialog()==DialogResult.OK)
            {
                View.IdSanPham = frm.SelectedItem.IdSanPham;
            }
        }
        public void Save()
        {
            if(_cauhinhinfo==null)
            {
                Check();
                Insert();
                View.ShowMessage("Thêm dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
            else
            {
                Update();
                View.ShowMessage("Sửa dữ liệu thành công !");
                View.DialogResult = DialogResult.OK;
            }
        }
        public void SaoChep()
        {
            try
            {
                frmLookUp_SanPham frm = new frmLookUp_SanPham("%%");
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    DMSanPhamInfo dmSanPhamInfo = frm.SelectedItem;
                    if (DmCauHinhSanPhamDAO.Instance.DaCoCauHinh(View.IdSanPham))
                    {
                        if (
                            MessageBox.Show("Sản phẩm này đã có cấu hình bạn có muốn ghi đè không ?", "Xác Nhận ",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2) == DialogResult.No)
                            return;
                    }
                    else if (
                        MessageBox.Show("Bạn chắc chắn sẽ sao chép cấu hình cho sản phẩm ?",
                                        dmSanPhamInfo.MaSanPham, MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                        MessageBoxDefaultButton.Button2) == DialogResult.No)
                        return;
                    try
                    {
                        ConnectionUtil.Instance.BeginTransaction();
                        DmCauHinhSanPhamDAO.Instance.Delete(dmSanPhamInfo.IdSanPham);
                        List<DMCauHinhSanPhamInfo> list = new List<DMCauHinhSanPhamInfo>();
                        for (int i = 0; i < list.Count; i++)
                        {
                            DMCauHinhSanPhamInfo info = list[i];
                            DmCauHinhSanPhamDAO.Instance.Update(info.IdSanPham, info.TenCauHinh, info.GiaTri, info.SoTT);
                            ConnectionUtil.Instance.CommitTransaction();

                        }

                    }
                    catch (Exception)
                    {
                        {
                            ConnectionUtil.Instance.RollbackTransaction();
                            throw;
                        }

                    }

                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);

            }
    }
     


        public void Exit()
        {
            View.Close();
        }
    }
}
