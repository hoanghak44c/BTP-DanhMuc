using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLyDoTraHangDAO : SynchronizableDAO
    {
        private static DmLyDoTraHangDAO instance;
        private DmLyDoTraHangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLyDoTraHang;
            UseCaching = true;
        }

        public static DmLyDoTraHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLyDoTraHangDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmLyDoTraHangSynchronize.Instance.Synchronize();
        }

        public List<DMLyDoTraHangInfo> GetListLyDoTraHangInfor()
        {
            return GetListAll<DMLyDoTraHangInfo>(Declare.StoreProcedureNamespace.spLyDoTraHangSelectAll, Declare.TableNamespace.DmLyDoTraHang);
        }

        internal void Update(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoTraHangUpdate, ParseToParams(dmLyDoTraHangInfo));
        }

        internal int Insert(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoTraHangInsert, ParseToParams(dmLyDoTraHangInfo));

            return Convert.ToInt32(Parameters["p_IdLyDoTH"].Value.ToString());
        }

        internal void Delete(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoTraHangDelete, dmLyDoTraHangInfo.IdLyDoTH);
        }

        public bool Exist(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoTraHangExist, dmLyDoTraHangInfo.IdLyDoTH, dmLyDoTraHangInfo.MaLyDo);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMLyDoTraHangInfo> Search(DMLyDoTraHangInfo dmLyDoTraHangInfo)
        {
            return GetListCommand<DMLyDoTraHangInfo>(Declare.StoreProcedureNamespace.spLyDoTraHangSearch, dmLyDoTraHangInfo.MaLyDo, dmLyDoTraHangInfo.Ten);
        }

        public DMLyDoTraHangInfo GetLyDoTraHangByIdInfo(int idLyDoTraHang)
        {
            return GetObjectCommand<DMLyDoTraHangInfo>(Declare.StoreProcedureNamespace.spLyDoTraHangGetbyId, idLyDoTraHang);
        }
    }
}
