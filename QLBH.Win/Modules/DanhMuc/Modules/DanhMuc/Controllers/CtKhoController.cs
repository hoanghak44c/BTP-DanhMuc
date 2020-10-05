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
    public class CTKhoController:AppBaseTrustedController<ICTKhoView>,ICTKhoController
    {
       
       
        private DMKhoInfo _dmkhoinfo = new DMKhoInfo(); // _dmkhoinfo:tên đối tượng được gọi 
        public CTKhoController(ICTKhoView view) : base(view)
        {
        }

        protected override void DisplayViewInfo()
        {
            GetData();
            LoadDataSource();
            LoadTrungTam();//lấy tất cả danh sách trung tâm  
            LoadKho(View.IdKho);

        }
        
        private void GetData()
        {
            _dmkhoinfo = View.dmKhoInfo;
        }
       
        private void LoadDataSource()
        {
            if(_dmkhoinfo!=null)
            {
                
                View.IdKho = _dmkhoinfo.IdKho;
                View.MaKho = _dmkhoinfo.MaKho;
                View.TenKho = _dmkhoinfo.TenKho;
                View.DiaChi = _dmkhoinfo.DiaChi;
                View.DienThoai = _dmkhoinfo.DienThoai;
                View.Fax = _dmkhoinfo.Fax;
                View.Email = _dmkhoinfo.Email;
                View.GhiChu = _dmkhoinfo.GhiChu;
                View.SuDung = _dmkhoinfo.SuDung;
                View.MaVung = _dmkhoinfo.MaVung;
                View.MaKhoOracle = _dmkhoinfo.MaKhoOracle;
                View.ViTri = _dmkhoinfo.ViTri;
                View.Tinh = _dmkhoinfo.Tinh;
                View.Duong = _dmkhoinfo.Duong;
                View.QuocGia = _dmkhoinfo.QuocGia;
                View.Type = _dmkhoinfo.Type;
                View.OtherTrungTam = _dmkhoinfo.OtherTrungTam;
            }
        }
        private void LoadTrungTam()
        {
            View.TrungTamDataSource = DmTrungTamDAO.Instance.GetAllTrungTam();
            View.checkTrungTam = DmTrungTamDAO.Instance.GetAllTrungTam();
        }
        public void Insert()
        {
            string str = ",";
            for (int i = 0; i < View.OtherTrungTamCount; i++)
            {
                str += Convert.ToInt32(View.CheckedOtherTrungTam(i))+",";
            }
            
            if (_dmkhoinfo == null)
            {
                
                _dmkhoinfo = new DMKhoInfo();
                _dmkhoinfo.MaKho = View.MaKho;
                _dmkhoinfo.IdTrungTam = View.IdTrungTam;
                _dmkhoinfo.TenKho = View.TenKho;
                _dmkhoinfo.DiaChi = View.DiaChi;
                _dmkhoinfo.DienThoai = View.DienThoai;
                _dmkhoinfo.Fax = View.Fax;
                _dmkhoinfo.Email = View.Email;
                _dmkhoinfo.GhiChu = View.GhiChu;
                _dmkhoinfo.SuDung = View.SuDung;
                _dmkhoinfo.OtherTrungTam = str;
                _dmkhoinfo.MaKhoOracle = View.MaKhoOracle;
                _dmkhoinfo.ViTri = View.ViTri;
                _dmkhoinfo.Duong = View.Duong;
                _dmkhoinfo.Tinh = View.Tinh;
                _dmkhoinfo.QuocGia = View.QuocGia;
                _dmkhoinfo.Type = View.Type;
                _dmkhoinfo.IdKho = DMKhoDAO.Instance.Insert(_dmkhoinfo);
                ((List<DMKhoInfo>)DSKhoView.Instance.DataSource).Add(_dmkhoinfo);
                DSKhoView.Instance.RefreshDataSource();
                View.ShowMessage("Thêm mới thành công !");
                View.DialogResult = DialogResult.OK;
            }
        }
        
        // lấy kho ra theo id kho
        private void LoadKho(int idkho)
        {
            if (_dmkhoinfo != null)
            {
                
                DMKhoInfo dmKhoInfo = DMKhoDAO.Instance.GetKhoByIdInfo(idkho);
                if (!String.IsNullOrEmpty(dmKhoInfo.OtherTrungTam))
                {
                    string[] sidkho = dmKhoInfo.OtherTrungTam.Split(',');// tách othertrungtam chỉ để lại idtrungtam
                    foreach (var s in sidkho)
                    {
                        foreach (var a in (List<DMTrungTamInfor>) View.listcheckothertrungtam)// vòng lặp othertrungtam 
                        {
                            if (!String.IsNullOrEmpty(s) && a.IdTrungTam == Convert.ToInt32(s))
                            {
                                View.othertrungtamcheck(((List<DMTrungTamInfor>) View.listcheckothertrungtam).IndexOf(a)); // những id trung tâm được tách "," được gán check
                            }
                        }
                    }
                }

            }
        }


        public void Update()
        {


            LoadKho(View.IdKho);
            string str = ",";
            for (int i = 0; i < View.OtherTrungTamCount; i++)
            {
                str += Convert.ToInt32(View.CheckedOtherTrungTam(i))+",";
            }
            _dmkhoinfo.IdKho = View.IdKho;
            _dmkhoinfo.MaKho = View.MaKho;
            _dmkhoinfo.IdTrungTam = View.IdTrungTam;
            _dmkhoinfo.TenKho = View.TenKho;
            _dmkhoinfo.DiaChi = View.DiaChi;
            _dmkhoinfo.DienThoai = View.DienThoai;
            _dmkhoinfo.Email = View.Email;
            _dmkhoinfo.GhiChu = View.GhiChu;
            _dmkhoinfo.SuDung = View.SuDung;
            _dmkhoinfo.OtherTrungTam =str;
            _dmkhoinfo.MaKhoOracle = View.MaKhoOracle;
            _dmkhoinfo.ViTri = View.ViTri;
            _dmkhoinfo.Duong = View.Duong;
            _dmkhoinfo.QuocGia = View.QuocGia;
            DMKhoDAO.Instance.Update(_dmkhoinfo);
            ((List<DMKhoInfo>)DSKhoView.Instance.DataSource).Add(_dmkhoinfo);
            DSKhoView.Instance.RefreshDataSource();
            View.ShowMessage("Sửa dữ liệu thành công !");
            View.DialogResult = DialogResult.OK;
        }
        public void Check()
        {
            if(string.IsNullOrEmpty(View.MaKho))
                throw  new InvalidOperationException("Không đượ để trống mã kho!");
            if(string.IsNullOrEmpty(View.TenKho))
                throw  new InvalidOperationException("Không được để trống tên kho!");
        }
        public void Save()
        {
            try
            {
                if(_dmkhoinfo==null)
                {
                 Check();
                 Insert();
                }
              
               else
               {
                Check();
                Update();
               }

               }
               catch (Exception ex)
               { 
                throw new Exception(ex.Message);
               }
           
        }
        public void Exit()
        {
            View.Close();
        }

    }
}
