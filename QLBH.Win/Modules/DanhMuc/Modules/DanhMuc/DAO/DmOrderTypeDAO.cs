using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmOrderTypeDAO :SynchronizableDAO
    {
        private static DmOrderTypeDAO instance;
        private DmOrderTypeDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmOrderType;
            UseCaching = true;
        }
        public static DmOrderTypeDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmOrderTypeDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmOrderTypeSynchronize.Instance.Synchronize();
        }

        public List<DMOrderTypeInfor> GetListOrderTypeInfor()
        {
            return GetListAll<DMOrderTypeInfor>(Declare.StoreProcedureNamespace.spOrderTypeSelectAll, Declare.TableNamespace.DmOrderType);
        }

        public List<DMOrderTypePairInfor> GetListOrderTypePairInfo()
        {
            return GetListAll<DMOrderTypePairInfor>(Declare.StoreProcedureNamespace.spOrderTypeSelectPair, Declare.TableNamespace.DmOrderType);
        }

        internal void Update(DMOrderTypeInfor dmOrderTypeInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spOrderTypeUpdate,
                                dmOrderTypeInfor.IdOrderType,
                                dmOrderTypeInfor.OrderType,
                                dmOrderTypeInfor.Name,
                                dmOrderTypeInfor.GhiChu,
                                dmOrderTypeInfor.SuDung,
                                dmOrderTypeInfor.LineType,
                                dmOrderTypeInfor.LineKm,
                                dmOrderTypeInfor.LineCk,
                                dmOrderTypeInfor.NganhHang);
        }

        internal int Insert(DMOrderTypeInfor dmOrderTypeInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spOrderTypeInsert,
                                dmOrderTypeInfor.IdOrderType,
                                dmOrderTypeInfor.OrderType,
                                dmOrderTypeInfor.Name,
                                dmOrderTypeInfor.GhiChu,
                                dmOrderTypeInfor.SuDung,
                                dmOrderTypeInfor.LineType,
                                dmOrderTypeInfor.LineKm,
                                dmOrderTypeInfor.LineCk,
                                dmOrderTypeInfor.NganhHang);
            //return Convert.ToInt32(Parameters["@IdOrderType"].Value.ToString());
            //return Common.IntValue(Parameters["p_IdOrderType"].Value.ToString());
        }

        internal void Delete(DMOrderTypeInfor dmOrderTypeInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spOrderTypeDelete,
                dmOrderTypeInfor.IdOrderType);

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spOrderTypeDelete);
            //Parameters.AddWithValue("@IdOrderType", dmOrderTypeInfor.IdOrderType);
            //ExecuteNoneQuery();
        }

        internal bool Exist(DMOrderTypeInfor dmOrderTypeInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spOrderTypeExist,
                dmOrderTypeInfor.IdOrderType,
                dmOrderTypeInfor.OrderType) > 0;

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spOrderTypeExist);
            //Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@IdOrderType", dmOrderTypeInfor.IdOrderType);
            //Parameters.AddWithValue("@Code", dmOrderTypeInfor.OrderType);
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        //internal List<DMOrderTypeInfor> Search(string MaOrderType ,string TenOrderType)
        //{
        //    return GetListCommand<DMOrderTypeInfor>(Declare.StoreProcedureNamespace.spOrderTypeSearch, MaOrderType,
        //                                            TenOrderType);
        //}
        internal List<DMOrderTypeInfor> Search(DMOrderTypeInfor dmOrderTypeInfor)
        {
            return GetListCommand<DMOrderTypeInfor>(Declare.StoreProcedureNamespace.spOrderTypeSearch,
                dmOrderTypeInfor.Name,
                dmOrderTypeInfor.OrderType);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spOrderTypeSearch);
            //Parameters.AddWithValue("@Name", dmOrderTypeInfor.Name);
            //Parameters.AddWithValue("@Code", dmOrderTypeInfor.OrderType);
            //return FillToList<DMOrderTypeInfor>();
        }
        public DMOrderTypeInfor GetOrderTypeIdInfo(int idOrderType)
        {
            return GetObjectCommand<DMOrderTypeInfor>(Declare.StoreProcedureNamespace.spOrderTypeGetbyId,
                idOrderType);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spOrderTypeGetbyId);
            //Parameters.AddWithValue("@IdOrderType", idOrderType);
            //return FillToObject<DMOrderTypeInfor>();
        }
    }
}
