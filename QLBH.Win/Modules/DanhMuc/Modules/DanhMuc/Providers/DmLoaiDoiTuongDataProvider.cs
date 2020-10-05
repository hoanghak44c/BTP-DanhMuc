using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;

// <Remarks>
// Tạo DMLoaiDoiTuongDataProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 05/06/2012
// Người sửa cuối:
// </remarks>
//todo:@HanhBD DMLoaiDoiTuongDataProvider
namespace QLBanHang.Modules.DanhMuc.Providers
{
    public class DmLoaiDoiTuongDataProvider :SynchronizableProvider
    {
        private static DmLoaiDoiTuongDataProvider instance;
        private DmLoaiDoiTuongDataProvider()
        {
            controllerDAO = DmLoaiDoiTuongDAO.Instance;
        }

        public static DmLoaiDoiTuongDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiDoiTuongDataProvider();
                return instance;
            }   
        }

       public static List<DmLoaiDoiTuongInfor> GetListLoaiDoiTuongInfor()
       {
           return DmLoaiDoiTuongDAO.Instance.GetListLoaiDoiTuongInfor();
       }

       internal static void Insert(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
       {
           DmLoaiDoiTuongDAO.Instance.Insert(DMLoaiDoiTuongInfor);
       }

       public static void Delete(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
       {
           DmLoaiDoiTuongDAO.Instance.Delete(DMLoaiDoiTuongInfor);
       }

       internal static void Update(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
       {
           DmLoaiDoiTuongDAO.Instance.Update(DMLoaiDoiTuongInfor);
       }

       public static bool KiemTra(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
       {
           return DmLoaiDoiTuongDAO.Instance.Exist(DMLoaiDoiTuongInfor);
       }

       public static List<DmLoaiDoiTuongInfor> Search(DmLoaiDoiTuongInfor match)
       {
           return DmLoaiDoiTuongDAO.Instance.Search(match);
       }

       public static DmLoaiDoiTuongInfor GetListDmLoaiDTInfoFromOid(int idLoaiDT)
       {
           return DmLoaiDoiTuongDAO.Instance.GetLoaiDoiTuongbyID(idLoaiDT);
       }
    }
}
