using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmChungDAO : SynchronizableDAO
    {
        private static DmChungDAO instance;
        private DmChungDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmChung;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }

        public static DmChungDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmChungDAO();
                return instance;
            }
        }

        public List<SegmentChildInfo> GetListSegmentInfor()
        {
            //return GetListAll<SegmentChildInfo>(Declare.StoreProcedureNamespace.spChungSelectAll, Declare.TableNamespace.DmChung);
            return GetListAll<SegmentChildInfo>(@"SELECT t1.ma, t1.ten, t1.loai as macha, last_update_date
	            FROM tbl_dm_dl_chung t1", Declare.TableNamespace.DmChung);
        }
    }
}
