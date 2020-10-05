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
            return GetListAll<DmLoaiDoiTuongInfor>(Declare.StoreProcedureNamespace.spLoaiDoiTuongSelectAll, Declare.TableNamespace.DmLoaiDoiTuong);
        }

        internal void Update(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongUpdate);
            SetParams(DMLoaiDoiTuongInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongInsert);
            SetParams(DMLoaiDoiTuongInfor);
            Parameters["@IdLoaiDT"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdLoaiDT"].Value.ToString());
        }

        internal void Delete(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongDelete);
            Parameters.AddWithValue("@IdLoaiDT", DMLoaiDoiTuongInfor.IdLoaiDT);
            ExecuteNoneQuery();
        }

        internal bool Exist(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdLoaiDT", DMLoaiDoiTuongInfor.IdLoaiDT);
            Parameters.AddWithValue("@MaLoaiDT", DMLoaiDoiTuongInfor.MaLoaiDT);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value.ToString()) == 1;
        }

        internal List<DmLoaiDoiTuongInfor> Search(DmLoaiDoiTuongInfor DMLoaiDoiTuongInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongSearch);
            //Parameters.AddWithValue("@MaLoaiDT", DMLoaiDoiTuongInfor.MaLoaiDT);
            Parameters.AddWithValue("@TenLoaiDT", DMLoaiDoiTuongInfor.TenLoaiDT);
            return FillToList<DmLoaiDoiTuongInfor>();
        }

        public DmLoaiDoiTuongInfor GetLoaiDoiTuongbyID(int idLoaiDoiTuong)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiDoiTuongGetbyId);
            Parameters.AddWithValue("@IDLoaiDT", idLoaiDoiTuong);
            return FillToObject<DmLoaiDoiTuongInfor>();
        }
       
    }
}
