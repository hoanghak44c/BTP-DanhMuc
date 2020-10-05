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
    public class DMLoaiTheUuDaiDAO : BaseDAO
    {
        private static DMLoaiTheUuDaiDAO instance;
        private DMLoaiTheUuDaiDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiTheUuDai;
            UseCaching = true;
        }
        public static DMLoaiTheUuDaiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiTheUuDaiDAO();
                return instance;
            }
        }
        internal int Insert(DmLoaiTheUuDaiInfo dmLoaiTheInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaitheUuDaiInsert);
            SetParams(dmLoaiTheInfor);
            Parameters["@IdLoaiThe"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdLoaiThe"].Value.ToString());
        }
        internal void Delete(DmLoaiTheUuDaiInfo dmLoaiTheInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaitheUuDaiDelete);
            Parameters.AddWithValue("@IdLoaiThe", dmLoaiTheInfor.IdLoaiThe);
            ExecuteNoneQuery();
        }
        public List<DmLoaiTheUuDaiInfo> GetLoaiTheQuyenLoiByIdInfo(int idLoaithe)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaitheUuDaiSelectByidLoaiThe);
            Parameters.AddWithValue("@IdLoaiThe", idLoaithe);
            return FillToList<DmLoaiTheUuDaiInfo>();
        }
    }
}
