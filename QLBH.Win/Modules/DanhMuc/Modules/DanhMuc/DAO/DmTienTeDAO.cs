using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmTienTeDAO :SynchronizableDAO
    {
        private static DmTienTeDAO instance;

        private DmTienTeDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmTienTe;
            UseCaching = true;
        }

        public static DmTienTeDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmTienTeDAO();
                return instance;
            }   
        }
        public List<DMTienTeInfor> GetListTienteInfo()
        {
            return GetListAll<DMTienTeInfor>(Declare.StoreProcedureNamespace.spTienTeSelectAll,Declare.TableNamespace.DmTienTe);
        }

        internal void Update(DMTienTeInfor dmTienTeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTienTeUpdate);
            SetParams(dmTienTeInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMTienTeInfor dmTienTeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTienTeInsert);
            SetParams(dmTienTeInfor);
            Parameters["@IdTienTe"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();
            return Convert.ToInt32(Parameters["@IdTienTe"].Value.ToString());
        }

        internal void Delete(DMTienTeInfor dmTienTeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTienTeDelete);
            Parameters.AddWithValue("@IdTienTe", dmTienTeInfor.IdTienTe);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMTienTeInfor dmTienTeInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spTienTeExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdTienTe", dmTienTeInfor.IdTienTe);
            Parameters.AddWithValue("@KyHieu", dmTienTeInfor.KyHieu);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }

        internal List<DMTienTeInfor> Search(DMTienTeInfor dmTienTeInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spTienTeSearch);
            Parameters.AddWithValue("@TenTienTe", dmTienTeInfor.TenTienTe);
            Parameters.AddWithValue("@KyHieu", dmTienTeInfor.KyHieu);
            return FillToList<DMTienTeInfor>();
        }
        public DMTienTeInfor GetTienTeByIdInfo(int idTienTe)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spTienTeGetbyId);
            Parameters.AddWithValue("@IdTienTe", idTienTe);
            return FillToObject<DMTienTeInfor>();
        }
    }
}
