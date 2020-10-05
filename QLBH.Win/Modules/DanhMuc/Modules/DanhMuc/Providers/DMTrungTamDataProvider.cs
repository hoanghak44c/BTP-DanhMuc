using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Providers
{   // <Remarks>
    // Tạo DMTrungTamProvider
    // Người tạo: Bùi Đức Hạnh
    // Ngày tạo : 01/03/2012
    // Người sửa cuối:
    // </remarks>

    public class DMTrungTamDataProvider : SynchronizableProvider
    {
        private static DMTrungTamDataProvider instance;
        
        private DMTrungTamDataProvider()
        {
            controllerDAO = DmTrungTamDAO.Instance;
            Member = "VAPMDD1kOEnloiFl+DSbWA==";
        }

        public static DMTrungTamDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMTrungTamDataProvider();
                return instance;
            }   
        }

        public static List<DMTrungTamInfor> GetListTrungTamInfo()
        {
            return GetListTrungTamInfo(-1);
        }

        public static List<DMTrungTamInfor> GetListTrungTamInfo(int baoHanh)
        {
            return Instance.Validate(DmTrungTamDAO.Instance.GetListTrungTamInfo(baoHanh));
        }

        public static List<DMTrungTamPairInfor> GetListTrungTamPairInfo()
        {
            return Instance.Validate(DmTrungTamDAO.Instance.GetListTrungTamPairInfo());
        }
        /// <summary>
        /// Trả về danh sách trung tâm theo ID nhân viên
        /// </summary>
        /// <param name="idNhanVien"></param>
        /// <returns></returns>
        public static List<DMTrungTamInfor> GetListTrungTamInfoByIdNhanVien(int idNhanVien, int baoHanh)
        {
            return Instance.Validate(DmTrungTamDAO.Instance.GetListTrungTamInfoByIdNhanVien(idNhanVien, baoHanh));
        }

        public static List<DMTrungTamInfor> GetListTrungTamInfoByIdNhanVien(int idNhanVien)
        {
            return GetListTrungTamInfoByIdNhanVien(idNhanVien, -1);
        }

        public static List<DMTrungTamPairInfor> GetListTrungTamPairInfoByIdNhanVien(int idNhanVien)
        {
            return Instance.Validate(DmTrungTamDAO.Instance.GetListTrungTamPairInfoByIdNhanVien(idNhanVien));
        }

        internal static void Update(DMTrungTamInfor dmTrungTamInfor)
        {
            DmTrungTamDAO.Instance.Update(dmTrungTamInfor);
        }
        
        internal static void Insert(DMTrungTamInfor dmTrungTamInfor)
        {
            DmTrungTamDAO.Instance.Insert(dmTrungTamInfor);
        }

        public static void Delete(DMTrungTamInfor dmTrungTamInfor)
        {
            DmTrungTamDAO.Instance.Delete(dmTrungTamInfor);
        }

        internal static bool KiemTra(DMTrungTamInfor dmTrungTamInfor)
        {
            return DmTrungTamDAO.Instance.Exist(dmTrungTamInfor);
        }

        public static List<DMTrungTamInfor> Search(DMTrungTamInfor dmTrungTamInfor)
        {
            return Instance.Validate(DmTrungTamDAO.Instance.Search(dmTrungTamInfor));
        }

        //public static List<DMTrungTamInfor>Search(string matrungtam,string tentrungtam)
        //{
        //    return DmTrungTamDAO.Instance.Search(matrungtam, tentrungtam);
        //}

        public static DMTrungTamInfor GetTrungTamByIdInfo(int idTrungTam)
        {
            return DmTrungTamDAO.Instance.GetTrungTamByIdInfo(idTrungTam);
        }

        public static DMTrungTamInfor GetTrungTamByIdKho(int idKho)
        {
            return DmTrungTamDAO.Instance.GetTrungTamByIdKho(idKho);
        }

        public static DMTrungTamInfor GetTrungTamByText(string trungtam)
        {
            return DmTrungTamDAO.Instance.GetTrungTamByText(trungtam);
        }

        public static DMTrungTamInfor GetTrungTamByMa(string maTrungtam)
        {
            return DmTrungTamDAO.Instance.GetTrungTamByMa(maTrungtam);
        }
        public static List<DMTrungTamPairInfor> GetTrungTamNoWeb()
        {
            return Instance.Validate(DmTrungTamDAO.Instance.GetTrungTamNoWeb());
        }

        public bool IsCrossedOU(int idTrungTam1, int idTrungTam2)
        {
            return DmTrungTamDAO.Instance.IsCrossedOU(idTrungTam1, idTrungTam2);
        }

    }
}
