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
    public class DmDuAnDAO :SynchronizableDAO
    {
        private static DmDuAnDAO instance;
        private DmDuAnDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmDuAn;
            UseCaching = true;
        }

        public static DmDuAnDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmDuAnDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmDuAnSynchronize.Instance.Synchronize();
        }

        public List<DMDuAnInfor> GetListDuAnInfor()
        {
            return GetListAll<DMDuAnInfor>(Declare.StoreProcedureNamespace.spDuAnSelectAll, Declare.TableNamespace.DmDuAn);
        }

        internal void Update(DMDuAnInfor dmDuAnInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDuAnUpdate, ParseToParams(dmDuAnInfor));
        }

        internal int Insert(DMDuAnInfor dmDuAnInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDuAnInsert, ParseToParams(dmDuAnInfor));

            return Convert.ToInt32(Parameters["p_IdDuAn"].Value.ToString());
        }

        internal void Delete(DMDuAnInfor dmDuAnInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDuAnDelete, dmDuAnInfor.IdDuAn);
        }

        public bool Exist(DMDuAnInfor dmDuAnInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spDuAnExist, dmDuAnInfor.IdDuAn, dmDuAnInfor.MaDuAn);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMDuAnInfor> Search(DMDuAnInfor dmDuAnInfor)
        {
            return GetListCommand<DMDuAnInfor>(Declare.StoreProcedureNamespace.spDuAnSearch, dmDuAnInfor.TenDuAn, dmDuAnInfor.MaDuAn);
        }

        public DMDuAnInfor GetDuAnByIdInfo(int idDuAn)
        {
            return GetObjectCommand<DMDuAnInfor>(Declare.StoreProcedureNamespace.spDuAnGetbyId, idDuAn);
        }

    }
}
