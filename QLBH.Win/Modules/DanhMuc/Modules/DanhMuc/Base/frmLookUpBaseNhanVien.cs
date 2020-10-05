using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseNhanVien : frmLookUp_BaseNew<DMNhanVienInfo>
    {
        private int idKho = -1;//tim nhan vien theo kho
        private int userId = -1;//tim theo user hien tai
        private bool isTruongCa = false;//tim truong ca theo user hien tai
        private int idTrungTam = -1, idNhomNguoiDung = -1; //tìm nhân viên theo bộ phận xử lý liên quan;

        public frmLookUpBaseNhanVien(){}

        public frmLookUpBaseNhanVien(string searchInput) : base(searchInput) { }

        public frmLookUpBaseNhanVien(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseNhanVien(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        public frmLookUpBaseNhanVien(bool isMultiSelect, string searchInput, int idKho) : base(isMultiSelect, searchInput)
        {
            this.idKho = idKho;
        }
        
        //11/03/2015 11:24 AM - hah prototype này không được dùng ở đâu cả nên rào lại
        //public frmLookUpBaseNhanVien(bool isMultiSelect, string searchInput, int idkho, int userId)
        //    : base(isMultiSelect, searchInput)
        //{
        //    this.idKho = idkho;
        //    this.userId = userId;
        //}

        public frmLookUpBaseNhanVien(bool isMultiSelect, string searchInput, int idTrungTam, int idNhomNguoiDung)
            : base(isMultiSelect, searchInput)
        {
            this.idTrungTam = idTrungTam;
            this.idNhomNguoiDung = idNhomNguoiDung;
        }

        public frmLookUpBaseNhanVien(bool isMultiSelect, string searchInput, int idkho, bool isTruongCa)
            : base(isMultiSelect, searchInput)
        {
            this.idKho = idkho;
            this.isTruongCa = isTruongCa;
        }

        protected override void OnLoad()
        {
            if (idKho == -1)
            {
                if (userId == -1)
                {
                    ListInitInfo = DmNhanVienDataProvider.GetListDmNhanVienUsingInfor();
                }
                else
                {
                    ListInitInfo = DmNhanVienDataProvider.GetListDmNhanVienInforByUserId(userId);
                }
            }
            else if (idKho >= 0)
            {
                if (isTruongCa)
                {
                    ListInitInfo = DmNhanVienDataProvider.GetListTruongCaInforByIdKho(idKho);    
                }
                else
                {
                    ListInitInfo = DmNhanVienDataProvider.GetListDmNhanVienInforByIdKho(idKho);    
                }
            } 
            else if(idTrungTam > 0 && idNhomNguoiDung > 0)
            {
                ListInitInfo = DmNhanVienDataProvider.GetListDmNhanVienInforByIdTrungTamAndNhomNguoiDung(idTrungTam, idNhomNguoiDung);
            }
        }
    }
}
