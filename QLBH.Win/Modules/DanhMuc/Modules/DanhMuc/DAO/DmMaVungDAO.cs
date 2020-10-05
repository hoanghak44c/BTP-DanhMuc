using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.Providers;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    class DmMaVungDAO : BaseDAO
    {
        private static DmMaVungDAO instance;
        private DmMaVungDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmMaVung;
            UseCaching = false;
        }

        public static DmMaVungDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmMaVungDAO();
                return instance;
            }
        }

        public List<MaVungInfo> GetListDMMaVungInfo()
        {
            return GetListAll<MaVungInfo>(Declare.StoreProcedureNamespace.spMaVungSelectAll);
        }
    }
}
