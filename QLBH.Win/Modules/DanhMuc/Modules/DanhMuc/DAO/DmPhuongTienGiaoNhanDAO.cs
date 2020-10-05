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
    public class DmPhuongTienGiaoNhanDAO : BaseDAO
    {
        private static DmPhuongTienGiaoNhanDAO instance;
        private DmPhuongTienGiaoNhanDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmTaxCode;
            //UseCaching = true;
        }
        public static DmPhuongTienGiaoNhanDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmPhuongTienGiaoNhanDAO();
                return instance;
            }   
        }

 
        public List<DMPhuongTienGiaoNhanInfor> GetListPhuongTienGiaoNhanInfors()
        {
            return GetListCommand<DMPhuongTienGiaoNhanInfor>(Declare.StoreProcedureNamespace.spPhuongTienGiaoNhanSelectAll);
        }
    }
}
