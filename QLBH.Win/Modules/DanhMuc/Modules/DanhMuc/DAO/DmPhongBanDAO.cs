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
            ExecuteCommand(Declare.StoreProcedureNamespace.spPhongBanUpdate, ParseToParams<DMPhongBanInfor>(dmPhongBanInfor));
        }

        internal int Insert(DMPhongBanInfor dmPhongBanInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spPhongBanInsert, ParseToParams<DMPhongBanInfor>(dmPhongBanInfor));
            //SetParams(dmPhongBanInfor);
            //Parameters["@IdPhongBan"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@IdPhongBan"].Value.ToString());
        }

        internal void Delete(DMPhongBanInfor dmPhongBanInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spPhongBanDelete, dmPhongBanInfor.IdPhongBan);
        }

        internal bool Exist(DMPhongBanInfor dmPhongBanInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spPhongBanExist, dmPhongBanInfor.IdPhongBan, dmPhongBanInfor.MaPhongBan) > 0;
        }
        internal List<DMPhongBanInfor> Search(DMPhongBanInfor dmMaLoiInfor)
        {
            return GetListCommand<DMPhongBanInfor>(Declare.StoreProcedureNamespace.spPhongBanSearch, dmMaLoiInfor.TenPhongBan, dmMaLoiInfor.MaPhongBan);
        }
        public DMPhongBanInfor GetPhongBanByIdInfo(int id)
        {
            return GetObjectCommand<DMPhongBanInfor>(Declare.StoreProcedureNamespace.spPhongBanGetById, id);
        }
        public  List<DMPhongBanInfor>GetAllPhongBan()
        {
            return GetListCommand<DMPhongBanInfor>(Declare.StoreProcedureNamespace.spPhongBanSelectAll);
        }
    }
}
