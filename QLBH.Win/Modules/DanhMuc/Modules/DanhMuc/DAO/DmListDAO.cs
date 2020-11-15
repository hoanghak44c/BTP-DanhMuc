using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    internal class DmListDAO : BaseDAO
    {
        private static DmListDAO instance;
        private DmListDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmKhaiBao;
            UseCaching = true;
        }

        public static DmListDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmListDAO();
                return instance;
            }
        }

        public List<DMListInfor> GetListDMInfo()
        {
            return GetListAll<DMListInfor>(Declare.StoreProcedureNamespace.spKhaiBaoSelectAll, Declare.TableNamespace.DmKhaiBao);
        }
        //public List<DMSanPhamPairInfo> GetListSanPhamCBOInfo()
        //{
        //    return GetListAll<DMSanPhamPairInfo>(Declare.StoreProcedureNamespace.spSanPhamSelectPair, Declare.TableNamespace.DmSanPham);
        //}
        internal void Update(DMListInfor dmListInfor)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spKhaiBaoUpdate);
            //SetParams(dmListInfor);
            //ExecuteNoneQuery();

            ExecuteCommand(Declare.StoreProcedureNamespace.spKhaiBaoUpdate, ParseToParams<DMListInfor>(dmListInfor));
        }
        internal void Insert(DMListInfor dmListInfor)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spKhaiBaoInsert);
            //SetParams(dmListInfor);
            //Parameters["@IdDoiTuong"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@IdDoiTuong"].Value.ToString());

            ExecuteCommand(Declare.StoreProcedureNamespace.spKhaiBaoInsert, ParseToParams<DMListInfor>(dmListInfor));
        }
        internal void Delete(DMListInfor dmListInfor)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spKhaiBaoDelete);
            //Parameters.AddWithValue("@TblName", dmListInfor.TblName);
            //ExecuteNoneQuery();

            ExecuteCommand(Declare.StoreProcedureNamespace.spKhaiBaoDelete, dmListInfor.TblName);
        }
        internal bool Exist(DMListInfor dmListInfor)
        {
            //CreateCommand(Declare.StoreProcedureNamespace.spKhaiBaoExist);
            //Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@TblName", dmListInfor.TblName);
            //ExecuteNoneQuery();

            //object result = ExecuteScalar(Declare.StoreProcedureNamespace.spKhaiBaoExist, 0, dmListInfor.TblName);
            //return Convert.ToInt32(result) == 1;

            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spKhaiBaoExist, dmListInfor.TblName) > 0;
        }
        internal List<DMListInfor> Search(DMListInfor dmListInfor)
        {
            return GetListCommand<DMListInfor>(Declare.StoreProcedureNamespace.spKhaiBaoSearch, 
                dmListInfor.TblName, 
                dmListInfor.Name);
            
            //CreateCommand(Declare.StoreProcedureNamespace.spKhaiBaoSearch, dmListInfor.TblName, dmListInfor.Name);
            //return FillToList<DMListInfor>();
        }

        internal bool IsSync(string tableName)
        {
            DMListInfor dmListInfor = GetDoiTuongByIdInfo(tableName);
            if (dmListInfor == null) return false;
            return dmListInfor.OnlyPOS == 0;
        }

        public DMListInfor GetDoiTuongByIdInfo(string tblName)
        {
            return GetObjectCommand<DMListInfor>(Declare.StoreProcedureNamespace.spKhaiBaoGetById, tblName);

            //CreateCommand(Declare.StoreProcedureNamespace.spKhaiBaoGetById, tblName);
            //return FillToObject<DMListInfor>();
        }
    }
}
