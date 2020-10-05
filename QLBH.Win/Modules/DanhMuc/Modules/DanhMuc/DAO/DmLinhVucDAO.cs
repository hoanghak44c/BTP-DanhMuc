using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLinhVucDAO : SynchronizableDAO
    {
        private static DmLinhVucDAO instance;
        private DmLinhVucDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLinhVuc;
            UseCaching = true;
        }

        public static DmLinhVucDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLinhVucDAO();
                return instance;
            }
        }

        public List<SegmentInfo> GetListSegmentInfor()
        {
            return GetListAll<SegmentInfo>(Declare.StoreProcedureNamespace.spLinhVucSelectAll, Declare.TableNamespace.DmLinhVuc);
        }
    }
}
