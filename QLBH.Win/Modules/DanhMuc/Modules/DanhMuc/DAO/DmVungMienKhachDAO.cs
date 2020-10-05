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
    public class DmVungMienKhachDAO : BaseDAO
    {
        private static DmVungMienKhachDAO instance;
        private DmVungMienKhachDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmTaxCode;
            //UseCaching = true;
        }
        public static DmVungMienKhachDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmVungMienKhachDAO();
                return instance;
            }   
        }

 
        public List<DMVungMienKhachInfor> GetListVungMienKhachInfors()
        {
            return GetListCommand<DMVungMienKhachInfor>(Declare.StoreProcedureNamespace.spVungMienKhachSelectAll);
        }

    }
}
