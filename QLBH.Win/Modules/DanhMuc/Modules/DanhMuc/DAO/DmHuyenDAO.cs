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
    public class DmHuyenDAO : BaseDAO
    {
        private static DmHuyenDAO instance;
        private DmHuyenDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmTaxCode;
            //UseCaching = true;
        }
        public static DmHuyenDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmHuyenDAO();
                return instance;
            }
        }


        public List<DMHuyenInfor> GetListHuyenByTinhInfors(int idTinh)
        {
            return GetListCommand<DMHuyenInfor>(Declare.StoreProcedureNamespace.spHuyenSelectByTinh, idTinh);
        }

        public DMHuyenInfor GetQuanHuyenByText(string huyen, int idTinh)
        {
            return GetObjectCommand<DMHuyenInfor>(Declare.StoreProcedureNamespace.spHuyenSelectByText, huyen, idTinh);
        }
        public DMHuyenInfor GetQuanHuyenById(int huyen)
        {
            return GetObjectCommand<DMHuyenInfor>(Declare.StoreProcedureNamespace.spHuyenSelectById, huyen);
        }
    }
}
