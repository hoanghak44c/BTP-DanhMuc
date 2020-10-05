using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLoaiDAO : SynchronizableDAO
    {
        private static DmLoaiDAO instance;
        private DmLoaiDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoai;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }

        public static DmLoaiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiDAO();
                return instance;
            }
        }

        public List<SegmentChildInfo> GetListSegmentInfor()
        {
            //return GetListAll<SegmentChildInfo>(Declare.StoreProcedureNamespace.spLoaiSelectAll, Declare.TableNamespace.DmLoai);
            return GetListAll<SegmentChildInfo>(@"SELECT t1.ma, t1.ten, t1.nganh as macha, last_update_date
	            FROM tbl_dm_dl_loai t1", Declare.TableNamespace.DmLoai);
        }
    }
}
