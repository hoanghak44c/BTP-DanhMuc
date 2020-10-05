using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmCachGiaoHangDAO : SynchronizableDAO
    {
         private static DmCachGiaoHangDAO instance;
         private DmCachGiaoHangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmCachGiaoHang;
            UseCaching = true;
        }

         public static DmCachGiaoHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmCachGiaoHangDAO();
                return instance;
            }
        }

         internal override void Synchronize()
         {
             DmCachGiaoHangSynchronize.Instance.Synchronize();
         }

        public List<DMCachGiaoHangInfo> GetListCachGiaoHangInfor()
        {
            return GetListAll<DMCachGiaoHangInfo>(Declare.StoreProcedureNamespace.spCachGiaoHangSelectAll, Declare.TableNamespace.DmCachGiaoHang);
        }

        internal void Update(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCachGiaoHangUpdate, ParseToParams(dmCachGiaoHangInfo));
        }

        internal int Insert(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCachGiaoHangInsert, ParseToParams(dmCachGiaoHangInfo));

            return Convert.ToInt32(Parameters["p_IdCachGiaoHang"].Value.ToString());
        }

        internal void Delete(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCachGiaoHangDelete, dmCachGiaoHangInfo.IdCachGiaoHang);
        }

        public bool Exist(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCachGiaoHangExist, dmCachGiaoHangInfo.IdCachGiaoHang, dmCachGiaoHangInfo.Ma);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMCachGiaoHangInfo> Search(DMCachGiaoHangInfo dmCachGiaoHangInfo)
        {
            return GetListCommand<DMCachGiaoHangInfo>(Declare.StoreProcedureNamespace.spCachGiaoHangSearch, dmCachGiaoHangInfo.Ma, dmCachGiaoHangInfo.Ten);
        }

        public DMCachGiaoHangInfo GetCachGiaoHangByIdInfo(int idCachGiaoHang)
        {
            return GetObjectCommand<DMCachGiaoHangInfo>(Declare.StoreProcedureNamespace.spCachGiaoHangGetbyId, idCachGiaoHang);
        }
    }
}
