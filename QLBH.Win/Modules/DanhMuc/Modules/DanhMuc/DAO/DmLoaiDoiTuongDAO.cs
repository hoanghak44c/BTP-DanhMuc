using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLoaiDoiTuongDAO : SynchronizableDAO
    {
        private static DmLoaiDoiTuongDAO instance;
        private DmLoaiDoiTuongDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiDoiTuong;
            UseCaching = false;
        }
        public static DmLoaiDoiTuongDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaiDoiTuongDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmLoaiDoiTuongSynchronize.Instance.Synchronize();
        }

        public List<DmLoaiDoiTuongInfor> GetListLoaiDoiTuongInfor()
        {
            return GetListAll<DmLoaiDoiTuongInfor>(Declare.StoreProcedureNamespace.spLoaiDoiTuongSelectAll, 
                Declare.TableNamespace.DmLoaiDoiTuong);
        }

        internal void Update(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongUpdate,
                ParseToParams<DmLoaiDoiTuongInfor>(DMLoaiDoiTuongInfor));

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongUpdate);
            //SetParams(DMLoaiDoiTuongInfor);
            //ExecuteNoneQuery();
        }

        internal int Insert(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spLoaiDoiTuongInsert,
                ParseToParams<DmLoaiDoiTuongInfor>(DMLoaiDoiTuongInfor));

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongInsert);
            //SetParams(DMLoaiDoiTuongInfor);
            //Parameters["@IdLoaiDT"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@IdLoaiDT"].Value.ToString());
        }

        internal void Delete(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongDelete,
                DMLoaiDoiTuongInfor.IdLoaiDT);

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongDelete);
            //Parameters.AddWithValue("@IdLoaiDT", DMLoaiDoiTuongInfor.IdLoaiDT);
            //ExecuteNoneQuery();
        }

        internal bool Exist(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spLoaiDoiTuongExist,
                DMLoaiDoiTuongInfor.IdLoaiDT,
                DMLoaiDoiTuongInfor.MaLoaiDT) > 0;

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongExist);
            //Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@IdLoaiDT", DMLoaiDoiTuongInfor.IdLoaiDT);
            //Parameters.AddWithValue("@MaLoaiDT", DMLoaiDoiTuongInfor.MaLoaiDT);
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@Count"].Value.ToString()) == 1;
        }

        internal List<DmLoaiDoiTuongInfor> Search(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            return GetListCommand<DmLoaiDoiTuongInfor>(Declare.StoreProcedureNamespace.spLoaiDoiTuongSearch, 
                DMLoaiDoiTuongInfor.TenLoaiDT);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongSearch);
            ////Parameters.AddWithValue("@MaLoaiDT", DMLoaiDoiTuongInfor.MaLoaiDT);
            //Parameters.AddWithValue("@TenLoaiDT", DMLoaiDoiTuongInfor.TenLoaiDT);
            //return FillToList<DmLoaiDoiTuongInfor>();
        }

        public DmLoaiDoiTuongInfor GetLoaiDoiTuongbyID(int idLoaiDoiTuong)
        {
            return GetObjectCommand<DmLoaiDoiTuongInfor>(Declare.StoreProcedureNamespace.spLoaiDoiTuongGetbyId,
                idLoaiDoiTuong);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongGetbyId);
            //Parameters.AddWithValue("@IDLoaiDT", idLoaiDoiTuong);
            //return FillToObject<DmLoaiDoiTuongInfor>();
        }
       
    }
}
