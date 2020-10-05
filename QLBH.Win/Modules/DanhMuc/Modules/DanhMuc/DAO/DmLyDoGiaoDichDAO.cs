using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmLyDoGiaoDichDAO : SynchronizableDAO
    {
        private static DmLyDoGiaoDichDAO instance;
        private DmLyDoGiaoDichDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmLyDoGiaoDich;
            UseCaching = true;
        }

        public static DmLyDoGiaoDichDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmLyDoGiaoDichDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmLyDoGiaoDichSynchronize.Instance.Synchronize();
        }

        public List<DMLyDoGiaoDichInfo> GetListLyDoGiaoDichInfor()
        {
            return GetListAll<DMLyDoGiaoDichInfo>(Declare.StoreProcedureNamespace.spLyDoGiaoDichSelectAll, Declare.TableNamespace.DmLyDoGiaoDich);
        }

        internal void Update(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoGiaoDichUpdate, ParseToParams(dmLyDoGiaoDichInfo));
        }

        internal int Insert(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoGiaoDichInsert, ParseToParams(dmLyDoGiaoDichInfo));

            return Convert.ToInt32(Parameters["p_IdLyDoGD"].Value.ToString());
        }

        internal void Delete(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoGiaoDichDelete, dmLyDoGiaoDichInfo.IdLyDoGD);
        }

        public bool Exist(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spLyDoGiaoDichExist, dmLyDoGiaoDichInfo.IdLyDoGD, dmLyDoGiaoDichInfo.Ma);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMLyDoGiaoDichInfo> Search(DMLyDoGiaoDichInfo dmLyDoGiaoDichInfo)
        {
            return GetListCommand<DMLyDoGiaoDichInfo>(Declare.StoreProcedureNamespace.spLyDoGiaoDichSearch, dmLyDoGiaoDichInfo.Ma, dmLyDoGiaoDichInfo.Ten);
        }

        public DMLyDoGiaoDichInfo GetLyDoGiaoDichByIdInfo(int idLyDoGiaoDich)
        {
            return GetObjectCommand<DMLyDoGiaoDichInfo>(Declare.StoreProcedureNamespace.spLyDoGiaoDichGetbyId, idLyDoGiaoDich);
        }
    }
}
