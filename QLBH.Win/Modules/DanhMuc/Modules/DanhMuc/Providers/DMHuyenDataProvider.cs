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

    public class DMHuyenDataProvider
    {
        private static DMHuyenDataProvider instance;
        public static DMHuyenDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMHuyenDataProvider();
                return instance;
            }   
        }

        public List<DMHuyenInfor> GetListHuyenByTinhInfors(int idTinh)
        {
            return DmHuyenDAO.Instance.GetListHuyenByTinhInfors(idTinh);
        }

        public DMHuyenInfor GetQuanHuyenByText(string huyen, int idTinh)
        {
            return DmHuyenDAO.Instance.GetQuanHuyenByText(huyen, idTinh);
        }
        public DMHuyenInfor GetQuanHuyenById(int huyen)
        {
            return DmHuyenDAO.Instance.GetQuanHuyenById(huyen);
        }
    }
}
