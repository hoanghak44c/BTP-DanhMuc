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
    public class DMLoaiTheKhachHangDAO:SynchronizableDAO
    {
        private static DMLoaiTheKhachHangDAO instance;
        private DMLoaiTheKhachHangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLoaiTheKhachHang;
            UseCaching = true;
        }
        public static DMLoaiTheKhachHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiTheKhachHangDAO();
                return instance;
            }
        }
        public List<DMLoaiTheKhachHangLoadInfo> GetListTheInfo()
        {
            return GetListAll<DMLoaiTheKhachHangLoadInfo>(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangselectAll, Declare.TableNamespace.DmLoaiTheKhachHang);
        }
        public List<DMLoaiTheKhachHangInfo> GetListDMTheInfo()
        {
            return GetListAll<DMLoaiTheKhachHangInfo>(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangselectAll, Declare.TableNamespace.DmLoaiTheKhachHang);
        }
        public List<DMLoaiTheKhachHangCBOInfo> GetListTheCBOInfo()
        {
            return GetListAll<DMLoaiTheKhachHangCBOInfo>(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangselectAll, Declare.TableNamespace.DmLoaiTheKhachHang);
        }
        internal void Update(DMLoaiTheKhachHangInfo dmLoaiTheInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangUpdate,
                ParseToParams<DMLoaiTheKhachHangInfo>(dmLoaiTheInfor));

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangUpdate);
            //SetParams(dmLoaiTheInfor);
            //ExecuteNoneQuery();
        }
        internal int Insert(DMLoaiTheKhachHangInfo dmLoaiTheInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangInsert,
                ParseToParams<DMLoaiTheKhachHangInfo>(dmLoaiTheInfor));

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangInsert);
            //SetParams(dmLoaiTheInfor);
            //Parameters["@IdLoaiThe"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@IdLoaiThe"].Value.ToString());
        }
        public void Delete(DMLoaiTheKhachHangInfo dmLoaiTheKHInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangDelete,
                dmLoaiTheKHInfor.IdLoaiThe);

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangDelete);
            //Parameters.AddWithValue("@IdLoaiThe", dmLoaiTheKHInfor.IdLoaiThe);
            //ExecuteNoneQuery();
        }
        internal bool Exist(DMLoaiTheKhachHangInfo dmLoaitheKHInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangExist,
                dmLoaitheKHInfor.IdLoaiThe,
                dmLoaitheKHInfor.MaThe) > 0;

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangExist);
            //Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@IdLoaiThe", dmLoaitheKHInfor.IdLoaiThe);
            //Parameters.AddWithValue("@MaThe", dmLoaitheKHInfor.MaThe);
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<DMLoaiTheKhachHangInfo> Search(DMLoaiTheKhachHangInfo dmLoaitheKHInfor)
        {
            return GetListCommand<DMLoaiTheKhachHangInfo>(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangSearch,
                dmLoaitheKHInfor.TenThe,
                dmLoaitheKHInfor.MaThe);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangSearch);
            //Parameters.AddWithValue("@TenTenThe", dmLoaitheKHInfor.TenThe);
            //Parameters.AddWithValue("@MaThe", dmLoaitheKHInfor.MaThe);
            //return FillToList<DMLoaiTheKhachHangInfo>();
        }
        public DMLoaiTheKhachHangInfo GetDoiTuongByIdInfo(int idLoaithe)
        {
            return GetObjectCommand<DMLoaiTheKhachHangInfo>(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangGetById,
                idLoaithe);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spLoaiThe_KhachHangGetById);
            //Parameters.AddWithValue("@IdLoaiThe", idLoaithe);
            //return FillToObject<DMLoaiTheKhachHangInfo>();
        }
    }
}
