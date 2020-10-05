using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Form;

namespace QLBanHang.Modules.DanhMuc.Base
{
    public class frmLookUpBaseKho : frmLookUp_BaseNew_1<DMKhoInfo>
    {
        protected int idTrungTam = -1;
        protected int idNhanVien = -1;
        protected int baoHanh = -1;

        public frmLookUpBaseKho(){}

        public frmLookUpBaseKho(string searchInput) : base(searchInput) { }

        public frmLookUpBaseKho(bool isMultiSelect) : base(isMultiSelect) { }

        public frmLookUpBaseKho(bool isMultiSelect, string searchInput) : base(isMultiSelect, searchInput) { }

        public frmLookUpBaseKho(bool isMultiSelect, string searchInput, int idTrungTam, int idNhanVien) : base(isMultiSelect, searchInput)
        {
            this.idTrungTam = idTrungTam;
            this.idNhanVien = idNhanVien;
        }
        public frmLookUpBaseKho(bool isMultiSelect, string searchInput, int idTrungTam, int idNhanVien, int baoHanh)
            : base(isMultiSelect, searchInput)
        {
            this.idTrungTam = idTrungTam;
            this.idNhanVien = idNhanVien;
            this.baoHanh = baoHanh;
        }
        protected override void OnLoad()
        {
            if (idTrungTam == -1)
            {
                ListInitInfo = idNhanVien == -1
                                   ? DMKhoDataProvider.GetListDMKhoInfor()
                                   : DMKhoDataProvider.GetListKhoInforByIdNhanVien(idNhanVien);
            }
            else
            {
                ListInitInfo = idNhanVien == -1
                                   ? DMKhoDataProvider.Instance.GetListKhoInfo(idTrungTam)
                                   : DMKhoDataProvider.GetListKhoInfoByTTamNVien(idTrungTam, idNhanVien);
            }
            if (baoHanh == 1)
            {
                if (ListInitInfo == null)
                
                    ListInitInfo = new List<DMKhoInfo>();

                ListInitInfo.Insert(0, new DMKhoInfo()
                                           {
                                               IdKho = 0,
                                               MaKho = "BH.KHACH",
                                               TenKho = "Kho khách bảo hành",
                                               SuDung = 1,
                                               IdTrungTam = idTrungTam
                                           });
            }
        }
    }
}
