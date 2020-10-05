using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmChucNangDAO : SynchronizableDAO
    {
        private static DmChucNangDAO instance;
        private DmChucNangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmChucNang;
            UseCaching = true;
        }
        public static DmChucNangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmChucNangDAO();
                return instance;
            }
        }

        public List<DMChucNangInfor> GetListChucNangInfo()
        {
            return GetListAll<DMChucNangInfor>(Declare.StoreProcedureNamespace.spChucNangSelectAll, Declare.TableNamespace.DmChucNang);
        }

        internal void Update(DMChucNangInfor dmChucNangInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucNangUpdate);
            SetParams(dmChucNangInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMChucNangInfor dmChucNangInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucNangInsert);
            SetParams(dmChucNangInfor);
            Parameters["@IdChucNang"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdChucNang"].Value.ToString());
        }

        internal void Delete(DMChucNangInfor dmChucNangInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucNangDelete);
            Parameters.AddWithValue("@IdChucNang", dmChucNangInfor.IdChucNang);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMChucNangInfor dmChucNangInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spChucNangExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdChucNang", dmChucNangInfor.IdChucNang);
            Parameters.AddWithValue("@MaChucNang", dmChucNangInfor.MaChucNang);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }

        internal List<DMChucNangInfor> Search(DMChucNangInfor dmChucNangInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spChucNangSearch);
            Parameters.AddWithValue("@MaChucNang", dmChucNangInfor.MaChucNang);
            Parameters.AddWithValue("@TenChucNang", dmChucNangInfor.TenChucNang);
            return FillToList<DMChucNangInfor>();
        }

        public DMChucNangInfor GetChucNangByIdInfo(int idChucNang)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spChucNangGetbyId);
            Parameters.AddWithValue("@IdChucNang", idChucNang);
            return FillToObject<DMChucNangInfor>();
        }
    }
}
