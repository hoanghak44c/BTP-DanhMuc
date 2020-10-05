using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseHangHoa : frmLookUp_BaseNew_1<DMSanPhamBriefInfo>
    {
        private int idNhomNguoiDung;
        private int suDung;
        private int chietKhau;
        private int idKho = -1;
        private int tonAll = 0;

        public frmLookUpBaseHangHoa(){}

        public frmLookUpBaseHangHoa(bool isMultiSelect, int idNhomNguoiDung, int suDung, int chietKhau) : base(isMultiSelect)
        {
            this.suDung = suDung;
            this.chietKhau = chietKhau;
            this.idNhomNguoiDung = idNhomNguoiDung;
        }

        public frmLookUpBaseHangHoa(bool isMultiSelect, int idNhomNguoiDung, int suDung, int chietKhau, int idKho)
            : base(isMultiSelect)
        {
            this.suDung = suDung;
            this.chietKhau = chietKhau;
            this.idNhomNguoiDung = idNhomNguoiDung;
            this.idKho = idKho;
        }

        public frmLookUpBaseHangHoa(bool isMultiSelect, int idNhomNguoiDung, int suDung, int chietKhau, int idKho, int tonAll)
            : base(isMultiSelect)
        {
            this.suDung = suDung;
            this.chietKhau = chietKhau;
            this.idNhomNguoiDung = idNhomNguoiDung;
            this.idKho = idKho;
            this.tonAll = tonAll;
        }

        protected override void OnLoad()
        {
            if (idKho == -1)
                ListInitInfo = DmSanPhamProvider.GetListSanPhamBrief(idNhomNguoiDung, suDung, chietKhau);
            else
                ListInitInfo = DmSanPhamProvider.GetListSanPhamTonBrief(idNhomNguoiDung, suDung, chietKhau, idKho, tonAll);
        }

        protected override string[] LookUpPropertyNames()
        {
            return new [] { "TenLoaiSP" };
        }
    }
}
