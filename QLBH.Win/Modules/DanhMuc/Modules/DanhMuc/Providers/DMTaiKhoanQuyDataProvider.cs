using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

// <Remarks>
// Tạo DMBieuMauThueProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 09/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{

    public class DMTaiKhoanQuyDataProvider
    {
        private static DMTaiKhoanQuyDataProvider instance;

        private DMTaiKhoanQuyDataProvider()
        {
        }

        public static DMTaiKhoanQuyDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMTaiKhoanQuyDataProvider();
                return instance;
            }   
        }
        public List<DMTaiKhoanQuyInfo> GetListTaiKhoanQuyInfors()
        {
            return DmTaiKhoanQuyDAO.Instance.GetListTaiKhoanQuyInfors();
        }
        public List<DMTaiKhoanQuyInfo> GetListTaiKhoanQuyByTrungTam(int idTrungTam)
        {
            return DmTaiKhoanQuyDAO.Instance.GetListTaiKhoanQuyByTrungTam(idTrungTam);
        }

        public DMTaiKhoanQuyInfo GetTaiKhoanQuyByText(string tkquy)
        {
            return DmTaiKhoanQuyDAO.Instance.GetTaiKhoanQuyByText(tkquy);
        }

        public DMTaiKhoanQuyInfo GetTaiKhoanQuyTMByTrungTam(int idTrungTam)
        {
            return DmTaiKhoanQuyDAO.Instance.GetTaiKhoanQuyTMByTrungTam(idTrungTam);
        }
    }
}
