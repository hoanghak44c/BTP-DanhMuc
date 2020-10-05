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
    public class DmCaBanHangDAO : BaseDAO
    {
        private static DmCaBanHangDAO instance;
        private DmCaBanHangDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmTaxCode;
            //UseCaching = true;
        }
        public static DmCaBanHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmCaBanHangDAO();
                return instance;
            }
        }

        public List<DmCaBanHangInfor> GetListCaBanHangInfors()
        {
            return GetListCommand<DmCaBanHangInfor>(Declare.StoreProcedureNamespace.spCaBanHangSelectAll);
        }
        public DmCaBanHangInfor GetCurrentCaBanHangInfors()
        {
            return GetObjectCommand<DmCaBanHangInfor>(Declare.StoreProcedureNamespace.spCaBanHangGetCurrent);
        }

    }
}
