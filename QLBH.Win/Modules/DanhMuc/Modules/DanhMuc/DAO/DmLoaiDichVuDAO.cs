using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLoaiDichVuDAO :SynchronizableDAO
    {
        private static DmLoaiDichVuDAO instance;
        private DmLoaiDichVuDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiDichVu;
            UseCaching = true;
        }
        public static DmLoaiDichVuDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiDichVuDAO();
                return instance;
            }
        }
        public List<DMLoaiDichVuInfor> GetListDichVuInfor()
        {
            return GetListAll<DMLoaiDichVuInfor>(Declare.StoreProcedureNamespace.spLoaiDichVuSelectAll, Declare.TableNamespace.DmLoaiDichVu);
        }

        internal void Update(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDichVuUpdate);
            SetParams(dmLoaiDichVuInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDichVuInsert);
            SetParams(dmLoaiDichVuInfor);
            Parameters["@IdLoaiDichVu"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdLoaiDichVu"].Value.ToString());
        }

        internal void Delete(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDichVuDelete);
            Parameters.AddWithValue("@IdLoaiDichVu", dmLoaiDichVuInfor.IdLoaiDichVu);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDichVuExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdLoaiDichVu", dmLoaiDichVuInfor.IdLoaiDichVu);
            Parameters.AddWithValue("@MaLoaiDichVu", dmLoaiDichVuInfor.MaLoaiDichVu);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<DMLoaiDichVuInfor> Search(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiDichVuSearch);
            Parameters.AddWithValue("@IdLoaiDichVu", dmLoaiDichVuInfor.TenDichVu);
            return FillToList<DMLoaiDichVuInfor>();
        }
        public DMLoaiDichVuInfor GetLoaiDichVuByIdInfo(int id)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiDichVuGetById);
            Parameters.AddWithValue("@IdTrungTam", id);
            return FillToObject<DMLoaiDichVuInfor>();
        }
    }
}
