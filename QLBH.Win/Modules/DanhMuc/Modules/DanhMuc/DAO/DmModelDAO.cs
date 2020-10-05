using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmModelDAO:SynchronizableDAO 
    {
        private static DmModelDAO instance;
        private DmModelDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmModel;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }

        public static DmModelDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmModelDAO();
                return instance;
            }
        }

        public List<SegmentChildInfo> GetListSegmentInfor()
        {
            //return GetListAll<SegmentChildInfo>(Declare.StoreProcedureNamespace.spModelSelectAll, Declare.TableNamespace.DmModel);
            return GetListAll<SegmentChildInfo>(@"SELECT t1.ma, t1.ten, t1.nhom as macha, last_update_date
                FROM tbl_dm_dl_model t1", Declare.TableNamespace.DmModel);
        }
    }
}
