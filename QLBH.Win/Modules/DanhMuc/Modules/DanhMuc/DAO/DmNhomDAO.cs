using System;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmNhomDAO : SynchronizableDAO
    {

        private static DmNhomDAO instance;

        private DmNhomDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNhom;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }

        public static DmNhomDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmNhomDAO();
                return instance;
            }
        }

        public List<SegmentChildInfo> GetListSegmentChildInfor()
        {
            //return GetListAll<SegmentChildInfo>(Declare.StoreProcedureNamespace.spNhomSelectAll, Declare.TableNamespace.DmNhom);
            return GetListAll<SegmentChildInfo>(@"SELECT t1.ma, t1.ten, t1.chung as macha, last_update_date
	            FROM tbl_dm_dl_nhom t1", Declare.TableNamespace.DmNhom);
        }
    }
}