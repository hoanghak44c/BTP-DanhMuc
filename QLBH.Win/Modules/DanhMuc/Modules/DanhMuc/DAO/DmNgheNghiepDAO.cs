using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Core.Data;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmNgheNghiepDAO : BaseDAO
    {
        private static DmNgheNghiepDAO instance;
        private DmNgheNghiepDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmTaxCode;
            //UseCaching = true;
        }
        public static DmNgheNghiepDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmNgheNghiepDAO();
                return instance;
            }
        }


        public List<DmNgheNghiepInfor> GetListNgheNghiepInfors()
        {
            return GetListCommand<DmNgheNghiepInfor>(Declare.StoreProcedureNamespace.spNgheNghiepSelectAll);
        }
    }
}
