using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DMLoaiTheQuyenLoiDAO : BaseDAO
    {
        private static DMLoaiTheQuyenLoiDAO instance;
        private DMLoaiTheQuyenLoiDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiTheQuyenLoi;
            UseCaching = true;
        }
        public static DMLoaiTheQuyenLoiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiTheQuyenLoiDAO();
                return instance;
            }
        }
        internal int Insert(DmLoaiTheQuyenLoiInfo dmLoaiTheInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaitheQuyenLoiInsert);
            SetParams(dmLoaiTheInfor);
            Parameters["@IdLoaiThe"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdLoaiThe"].Value.ToString());
        }
        internal void Delete(DmLoaiTheQuyenLoiInfo dmLoaiTheInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaitheQuyenLoiDelete);
            Parameters.AddWithValue("@IdLoaiThe", dmLoaiTheInfor.IdLoaiThe);
            ExecuteNoneQuery();
        }
        public List<DmLoaiTheQuyenLoiInfo> GetLoaiTheQuyenLoiByIdInfo(int idLoaithe)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaitheQuyenLoiSelectByidLoaiThe);
            Parameters.AddWithValue("@IdLoaiThe", idLoaithe);
            return FillToList<DmLoaiTheQuyenLoiInfo>();
        }
    }
}
