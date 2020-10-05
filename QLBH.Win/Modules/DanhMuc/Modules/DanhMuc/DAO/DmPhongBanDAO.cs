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
    public class DmPhongBanDAO :SynchronizableDAO
    {
        private static DmPhongBanDAO instance;
        private DmPhongBanDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmPhongBan;
            UseCaching = true;
        }
        public static DmPhongBanDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmPhongBanDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmPhongBanSynchronize.Instance.Synchronize();
        }


        public List<DMPhongBanInfor> GetListPhongBanInfor()
        {
            return GetListAll<DMPhongBanInfor>(Declare.StoreProcedureNamespace.spPhongBanSelectAll,Declare.TableNamespace.DmPhongBan);
        }
        public List<DMPhongBanInfor> GetListActivedPhongBanInfor()
        {
            return GetListAll<DMPhongBanInfor>(Declare.StoreProcedureNamespace.spPhongBanSelectActived, Declare.TableNamespace.DmPhongBan);
        }

        //todo: @CuongTT(DONE) chua dung
        public List<DMPhongBanPairInfor> GetListPhongBanPairInfo()
        {
            return GetListAll<DMPhongBanPairInfor>(Declare.StoreProcedureNamespace.spPhongBanSelectPair, Declare.TableNamespace.DmPhongBan);
        }

        internal void Update(DMPhongBanInfor dmPhongBanInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spPhongBanUpdate);
            SetParams(dmPhongBanInfor);
            ExecuteNoneQuery();
        }

        internal int Insert(DMPhongBanInfor dmPhongBanInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spPhongBanInsert);
            SetParams(dmPhongBanInfor);
            //Parameters["@IdPhongBan"].Direction = ParameterDirection.Output;
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdPhongBan"].Value.ToString());
        }

        internal void Delete(DMPhongBanInfor dmPhongBanInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spPhongBanDelete);
            Parameters.AddWithValue("@IdPhongBan", dmPhongBanInfor.IdPhongBan);
            ExecuteNoneQuery();
        }

        internal bool Exist(DMPhongBanInfor dmPhongBanInfor)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spPhongBanExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdPhongBan", dmPhongBanInfor.IdPhongBan);
            Parameters.AddWithValue("@MaPhongBan", dmPhongBanInfor.MaPhongBan);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<DMPhongBanInfor> Search(DMPhongBanInfor dmMaLoiInfor)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spPhongBanSearch);
            Parameters.AddWithValue("@TenPhongBan", dmMaLoiInfor.TenPhongBan);
            Parameters.AddWithValue("@MaPhongBan", dmMaLoiInfor.MaPhongBan);
            return FillToList<DMPhongBanInfor>();
        }
        public DMPhongBanInfor GetPhongBanByIdInfo(int id)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spPhongBanGetById);
            Parameters.AddWithValue("@IdLoaiItem", id);
            return FillToObject<DMPhongBanInfor>();
        }
        public  List<DMPhongBanInfor>GetAllPhongBan()
        {
            return GetListCommand<DMPhongBanInfor>(Declare.StoreProcedureNamespace.spPhongBanSelectAll);
        }
    }
}
