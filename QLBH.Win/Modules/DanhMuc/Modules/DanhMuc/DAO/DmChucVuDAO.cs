using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmChucVuDAO: SynchronizableDAO
    {
        private static DmChucVuDAO instance;
        private DmChucVuDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmChucVu;
            UseCaching = true;
        }
        public static DmChucVuDAO Instance
        {
            get
            {
                if(instance==null)instance = new DmChucVuDAO();
                return instance;
            }
        }

        public List<DMChucVuInfor> GetListChucVuInfo()
        {
            return GetListAll<DMChucVuInfor>(Declare.StoreProcedureNamespace.spChucVuSelectAll, Declare.TableNamespace.DmChucVu);
        }

        public List<DMChucVuPairInfor> GetListChucVuPairInfo()
        {
            return GetListAll<DMChucVuPairInfor>(Declare.StoreProcedureNamespace.spChucVuSelectPair, Declare.TableNamespace.DmChucVu);
        }

        internal void Update(DMChucVuInfor dmChucVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucVuUpdate);
            SetParams(dmChucVuInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMChucVuInfor dmChucVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucVuInsert);
            SetParams(dmChucVuInfor);
            Parameters["@IdChucVu"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdChucVu"].Value.ToString());
        }

        internal void Delete(DMChucVuInfor dmChucVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucVuDelete);
            Parameters.AddWithValue("@IdChucVu", dmChucVuInfor.IdChucVu);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMChucVuInfor dmChucVuInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucVuExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdChucVu", dmChucVuInfor.IdChucVu);
            Parameters.AddWithValue("@MaChucVu", dmChucVuInfor.MaChucVu);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }

        internal List<DMChucVuInfor> Search(DMChucVuInfor dmChucVuInfor)
        {
            return GetListCommand<DMChucVuInfor>(Declare.StoreProcedureNamespace.spChucVuSearch,
                dmChucVuInfor.MaChucVu, dmChucVuInfor.TenChucVu);
            //CreateGetListCommand(Declare.StoreProcedureNamespace.spChucVuSearch);
            //Parameters.AddWithValue("@MaChucVu", dmChucVuInfor.MaChucVu);
            //Parameters.AddWithValue("@TenChucVu", dmChucVuInfor.TenChucVu);
            //return FillToList<DMChucVuInfor>();
        }

        public DMChucVuInfor GetChucVuByIdInfo(int idChucVu)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spChucVuGetbyId);
            Parameters.AddWithValue("@IdChucVu", idChucVu);
            return FillToObject<DMChucVuInfor>();
        }
        public List<DMChucVuInfor>GetAllChucVu()
        {
            return GetListCommand<DMChucVuInfor>(Declare.StoreProcedureNamespace.spChucVuSelectAll);
        }
    }
}
