using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLoaiItemDAO :SynchronizableDAO
    {
        private static DmLoaiItemDAO instance;
        private DmLoaiItemDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiItem;
            UseCaching = true;
        }
        public static DmLoaiItemDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiItemDAO();
                return instance;
            }
        }
        public List<DMLoaiItemInfor> GetListItemInfor()
        {
            return GetListAll<DMLoaiItemInfor>(Declare.StoreProcedureNamespace.spLoaiItemSelectAll, Declare.TableNamespace.DmLoaiItem);
        }

        internal void Update(DMLoaiItemInfor dmLoaiItemInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiItemUpdate);
            SetParams(dmLoaiItemInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMLoaiItemInfor dmLoaiItemInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiItemInsert);
            SetParams(dmLoaiItemInfor);
            Parameters["@IdLoaiItem"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdLoaiItem"].Value.ToString());
        }

        internal void Delete(DMLoaiItemInfor dmLoaiItemInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiItemDelete);
            Parameters.AddWithValue("@IdLoaiItem", dmLoaiItemInfor.IdLoaiItem);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMLoaiItemInfor dmLoaiItemInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiItemExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdLoaiItem", dmLoaiItemInfor.IdLoaiItem);
            Parameters.AddWithValue("@MaLoaiItem", dmLoaiItemInfor.MaLoaiItem);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<DMLoaiItemInfor> Search(DMLoaiItemInfor dmLoaiItemInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiItemSearch);
            Parameters.AddWithValue("@MaLoaiItem", dmLoaiItemInfor.MaLoaiItem);
            return FillToList<DMLoaiItemInfor>();
        }
        public DMLoaiItemInfor GetTrungTamByIdInfo(int id)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiItemGetById);
            Parameters.AddWithValue("@IdLoaiItem", id);
            return FillToObject<DMLoaiItemInfor>();
        }
    }
}
