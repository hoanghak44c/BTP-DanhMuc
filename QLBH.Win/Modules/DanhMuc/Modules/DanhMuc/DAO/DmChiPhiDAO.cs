using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmChiPhiDAO : SynchronizableDAO
    {
        private static DmChiPhiDAO instance;
        private DmChiPhiDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmChiPhi;
            UseCaching = true;
        }

        public static DmChiPhiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmChiPhiDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmChiPhiSynchronize.Instance.Synchronize();
        }

        public List<DMChiPhiInfo> GetListActivedChiPhiInfor()
        {
            return GetListAll<DMChiPhiInfo>(Declare.StoreProcedureNamespace.spChiPhiSelectActived, Declare.TableNamespace.DmChiPhi);
        }

        public List<DMChiPhiInfo> GetListChiPhiInfor()
        {
            return GetListAll<DMChiPhiInfo>(Declare.StoreProcedureNamespace.spChiPhiSelectAll, Declare.TableNamespace.DmChiPhi);
        }

        internal void Update(DMChiPhiInfo dmChiPhiInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChiPhiUpdate, ParseToParams(dmChiPhiInfo));
        }

        internal int Insert(DMChiPhiInfo dmChiPhiInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChiPhiInsert, ParseToParams(dmChiPhiInfo));

            return Convert.ToInt32(Parameters["p_IdChiPhi"].Value.ToString());
        }

        internal void Delete(DMChiPhiInfo dmChiPhiInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChiPhiDelete, dmChiPhiInfo.IdChiPhi);
        }

        public bool Exist(DMChiPhiInfo dmChiPhiInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spChiPhiExist, dmChiPhiInfo.IdChiPhi, dmChiPhiInfo.Ma);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMChiPhiInfo> Search(DMChiPhiInfo dmChiPhiInfo)
        {
            return GetListCommand<DMChiPhiInfo>(Declare.StoreProcedureNamespace.spChiPhiSearch, dmChiPhiInfo.Ma, dmChiPhiInfo.Ten);
        }

        public DMChiPhiInfo GetChiPhiByIdInfo(int idChiPhi)
        {
            return GetObjectCommand<DMChiPhiInfo>(Declare.StoreProcedureNamespace.spChiPhiGetbyId, idChiPhi);
        }
    }
}
