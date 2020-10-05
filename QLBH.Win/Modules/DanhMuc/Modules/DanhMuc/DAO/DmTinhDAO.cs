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
    public class DmTinhDAO : BaseDAO
    {
        private static DmTinhDAO instance;
        private DmTinhDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmTaxCode;
            //UseCaching = true;
        }
        public static DmTinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmTinhDAO();
                return instance;
            }
        }

        public List<DMTinhInfor> GetListTinhInfors()
        {
            return GetListCommand<DMTinhInfor>(Declare.StoreProcedureNamespace.spTinhSelectAll);
        }
        public DMTinhInfor GetTinhThanhByText(string tinh)
        {
            return GetObjectCommand<DMTinhInfor>(Declare.StoreProcedureNamespace.spTinhSelectByText, tinh);
        }
        public DMTinhInfor GetTinhThanhById(int tinh)
        {
            return GetObjectCommand<DMTinhInfor>(Declare.StoreProcedureNamespace.spTinhSelectById, tinh);
        }
    }
}
