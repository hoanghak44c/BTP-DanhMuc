using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmPhuongThucBanHangDAO : SynchronizableDAO
    {
        private static DmPhuongThucBanHangDAO instance;
        private DmPhuongThucBanHangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmPhuongThucBanHang;
            UseCaching = true;
        }

        public static DmPhuongThucBanHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmPhuongThucBanHangDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmPhuongThucBanHangSynchronize.Instance.Synchronize();
        }

        public List<DMPhuongThucBanHangInfo> GetListPhuongThucBanHangInfor()
        {
            return GetListAll<DMPhuongThucBanHangInfo>(Declare.StoreProcedureNamespace.spPhuongThucBHSelectAll, Declare.TableNamespace.DmPhuongThucBanHang);
        }

        internal void Update(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spPhuongThucBHUpdate, ParseToParams(dmPhuongThucBanHangInfo));
        }

        internal int Insert(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spPhuongThucBHInsert, ParseToParams(dmPhuongThucBanHangInfo));

            return Convert.ToInt32(Parameters["p_IdPhuongThucBH"].Value.ToString());
        }

        internal void Delete(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spPhuongThucBHDelete, dmPhuongThucBanHangInfo.IdPhuongThucBH);
        }

        public bool Exist(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spPhuongThucBHExist, dmPhuongThucBanHangInfo.IdPhuongThucBH, dmPhuongThucBanHangInfo.Ma);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMPhuongThucBanHangInfo> Search(DMPhuongThucBanHangInfo dmPhuongThucBanHangInfo)
        {
            return GetListCommand<DMPhuongThucBanHangInfo>(Declare.StoreProcedureNamespace.spPhuongThucBHSearch, dmPhuongThucBanHangInfo.Ma, dmPhuongThucBanHangInfo.Ten);
        }

        public DMPhuongThucBanHangInfo GetPhuongThucBanHangByIdInfo(int idPhuongThucBanHang)
        {
            return GetObjectCommand<DMPhuongThucBanHangInfo>(Declare.StoreProcedureNamespace.spPhuongThucBHGetbyId, idPhuongThucBanHang);
        }
    }
}
