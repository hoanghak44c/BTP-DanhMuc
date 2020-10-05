using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmNganhDAO : SynchronizableDAO
    {

        private static DmNganhDAO instance;

        private DmNganhDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNganh;
            UseCaching = true;
        }

        public static DmNganhDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmNganhDAO();
                return instance;
            }
        }

        public List<SegmentChildInfo> GetListSegmentInfor()
        {
            return GetListAll<SegmentChildInfo>(Declare.StoreProcedureNamespace.spNganhSelectAll, Declare.TableNamespace.DmNganh);
        }

        public List<string> GetListNganhTonKho(int idKho)
        {
            string cmdText = @"select distinct lsp.nganh from tbl_hangtonkho htk, tbl_sanpham sp, tbl_dm_loaisanpham lsp
                        where htk.idsanpham = sp.idsanpham
                        and sp.idcha = lsp.idloaisp
                        and htk.idkho in (:idKho, -:idKho) and htk.soluong + htk.tonao > 0";

            return GetListCommand<string>(cmdText, idKho);
        }
    }
}