using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmHangDAO : SynchronizableDAO
    {
        private static DmHangDAO instance;
        private DmHangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmHang;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }

        public static DmHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmHangDAO();
                return instance;
            }
        }

        public List<SegmentInfo> GetListSegmentInfor()
        {
            //return GetListAll<SegmentInfo>(Declare.StoreProcedureNamespace.spHangSelectAll, Declare.TableNamespace.DmHang);
            return GetListAll<SegmentInfo>("SELECT t1.ma, t1.ten FROM tbl_dm_dl_hang t1", Declare.TableNamespace.DmHang);
        }
    }
}
