using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmBangKeThueDAO : SynchronizableDAO
    {
        private static DmBangKeThueDAO instance;
        private DmBangKeThueDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmBangKeThue;
            UseCaching = true;
        }

        public static DmBangKeThueDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmBangKeThueDAO();
                return instance;
            }
        }
        public List<DMBangKeThueInfo> GetListBangKeThueInfor()
        {
            return GetListAll<DMBangKeThueInfo>(Declare.StoreProcedureNamespace.spBangKeThueSelectAll, Declare.TableNamespace.DmBangKeThue);
        }

        internal void Update(DMBangKeThueInfo dmBangKeThueInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangKeThueUpdate, ParseToParams(dmBangKeThueInfo));
        }

        internal int Insert(DMBangKeThueInfo dmBangKeThueInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangKeThueInsert, ParseToParams(dmBangKeThueInfo));

            return Convert.ToInt32(Parameters["p_Id"].Value.ToString());
        }

        internal void Delete(DMBangKeThueInfo dmBangKeThueInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangKeThueDelete, dmBangKeThueInfo.Id);
        }

        public bool Exist(DMBangKeThueInfo dmBangKeThueInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spBangKeThueExist, dmBangKeThueInfo.Id, dmBangKeThueInfo.KyHieu);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMBangKeThueInfo> Search(DMBangKeThueInfo dmBangKeThueInfo)
        {
            return GetListCommand<DMBangKeThueInfo>(Declare.StoreProcedureNamespace.spBangKeThueSearch, dmBangKeThueInfo.KyHieu, dmBangKeThueInfo.Ten);
        }

        public DMBangKeThueInfo GetBangKeThueByIdInfo(int idBangKeThue)
        {
            return GetObjectCommand<DMBangKeThueInfo>(Declare.StoreProcedureNamespace.spBangKeThueGetbyId, idBangKeThue);
        }
    }
}
