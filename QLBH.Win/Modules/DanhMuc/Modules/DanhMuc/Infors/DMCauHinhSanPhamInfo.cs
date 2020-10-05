using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraEditors.Repository;
using QLBH.Core.Data;
using QLBH.Core.Infors;

namespace QLBanHang.Modules.DanhMuc.Infors
{
    [Serializable]
    public class DMCauHinhSanPhamInfo : NotifyInfo
    {
        private int idSanPham;
        public int IdSanPham
        {
            get { return idSanPham; }
            set
            {
                if(idSanPham != value) NotifyChange();
                idSanPham = value;
            }
        }

        private string tenCauHinh;
        public string TenCauHinh
        {
            get { return tenCauHinh; }
            set
            {
                if(tenCauHinh != value) NotifyChange();
                tenCauHinh = value;
            }
        }

        private string giaTri;
        public string GiaTri
        {
            get { return giaTri; }
            set
            {
                if(giaTri != value) NotifyChange();
                giaTri = value;
            }
        }

        private int soTT;
        public int SoTT
        {
            get { return soTT; }
            set
            {
                if(soTT != value) NotifyChange();
                soTT = value;
            }
        }

        private string maSanPham;
        public string MaSanPham
        {
            get { return maSanPham; }
            set
            {
                if (maSanPham != value) NotifyChange();
                maSanPham = value;
            }
        }

        private string tenSanPham;
        public string TenSanPham
        {
            get { return tenSanPham; }
            set
            {
                if(tenSanPham != value) NotifyChange();
                tenSanPham = value;
            }
        }

        private string logo;
        public string Logo
        {
            get { return logo; }
            set
            {
                if(logo != value) NotifyChange();
                logo = value;
            }
        }

        private int trangThai;
        public int TrangThai
        {
            get { return trangThai; }
            set
            {
                if(trangThai != value) NotifyChange();
                trangThai = value;
            }
        }

        private string hang;
        public string Hang
        {
            get { return hang; }
            set
            {
                if (hang != value) NotifyChange();
                hang = value;
            }
        }

    }
}
