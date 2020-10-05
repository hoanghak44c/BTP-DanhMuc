using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using System.Data;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // KhaiBaoDMDataProvider
    // Người tạo: Bùi Đức Hạnh
    // Ngày tạo : 22/02/2012
    // </remarks>
    
    public class KhaiBaoDMDataProvider
    {
        public static List<DMListInfor> GetListKhaiBaoInfo()
        {
            return DmListDAO.Instance.GetListDMInfo();
        }

        internal static void Insert(DMListInfor dmListInfor)
        {
            DmListDAO.Instance.Insert(dmListInfor);
        }

        internal static void Update(DMListInfor dmListInfor)
        {
            DmListDAO.Instance.Update(dmListInfor);
        }

        public static void Delete(DMListInfor dmListInfor)
        {
            DmListDAO.Instance.Delete(dmListInfor);
        }

        internal static bool Kiemtra(DMListInfor match)
        {
            return DmListDAO.Instance.Exist(match);
        }

        internal static bool IsSync(string tableName)
        {
            return DmListDAO.Instance.IsSync(tableName);
        }

        public static DMListInfor GetListDMInfoFromOid(string tblName)
        {
            return DmListDAO.Instance.GetDoiTuongByIdInfo(tblName);
        }
        public static List<DMListInfor> Search(DMListInfor match)
        {
            return DmListDAO.Instance.Search(match);
        }
    }
}
