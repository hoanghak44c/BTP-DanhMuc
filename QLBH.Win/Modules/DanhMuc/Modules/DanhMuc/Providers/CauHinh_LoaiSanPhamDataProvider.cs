using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class CauHinh_LoaiSanPhamDataProvider
    {
        public static List<CauHinh_LoaiSanPhamInfo> GetCauHinhLoaiSPInfor()
        {
            return CauHinh_LoaiSanPhamDAO.Instance.GetListCauHinhLoaiSanPhamInfo();
        }
        internal static void Insert(CauHinh_LoaiSanPhamInfo info)
        {
            CauHinh_LoaiSanPhamDAO.Instance.Insert(info);
        }
        public static void Delete(CauHinh_LoaiSanPhamInfo info)
        {
            CauHinh_LoaiSanPhamDAO.Instance.Delete(info);
        }
        internal static void Update(CauHinh_LoaiSanPhamInfo info)
        {
            CauHinh_LoaiSanPhamDAO.Instance.Update(info);
        }
        public static bool KiemTra(CauHinh_LoaiSanPhamInfo info)
        {
            return CauHinh_LoaiSanPhamDAO.Instance.Exist(info);
        }
        public static List<CauHinh_LoaiSanPhamInfo> Search(CauHinh_LoaiSanPhamInfo match)
        {
            return CauHinh_LoaiSanPhamDAO.Instance.Search(match);
        }
        public static CauHinh_LoaiSanPhamInfo GetListCauHinhLoaiSPInfoFromOid(int id)
        {
            return CauHinh_LoaiSanPhamDAO.Instance.GetCauHinhLoaiSPByIdInfo(id);
        }
    }
}
