using System;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    class DmThanhToanDAO : SynchronizableDAO
    {
        private static DmThanhToanDAO instance;
        private DmThanhToanDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmThanhToan;
            UseCaching = true;
        }

        public static DmThanhToanDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmThanhToanDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmHinhThucThanhToanSynchronize.Instance.Synchronize();
        }

        public List<DMThanhToanInfor> GetListDmThanhToanInfo()
        {
            return GetListAll<DMThanhToanInfor>(Declare.StoreProcedureNamespace.spHinhThucThanhToanSelectAll, Declare.TableNamespace.DmThanhToan);
        }

        public int Insert(DMThanhToanInfor dmThanhToanInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spHinhThucThanhToanInsert, dmThanhToanInfor.Ma, dmThanhToanInfor.Ten, dmThanhToanInfor.GhiChu, dmThanhToanInfor.SuDung);
            return Convert.ToInt32(Parameters["p_IdThanhToan"].Value.ToString());
        }

        public void Update(DMThanhToanInfor dmThanhToanInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spHinhThucThanhToanUpdate, ParseToParams(dmThanhToanInfor));
        }

        public void Delete(DMThanhToanInfor dmThanhToanInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spHinhThucThanhToanDelete, dmThanhToanInfor.IdThanhToan);
        }

        public bool CheckExist(DMThanhToanInfor dmThanhToanInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spHinhThucThanhToanExist, dmThanhToanInfor.IdThanhToan,
                           dmThanhToanInfor.Ma);
            return Convert.ToInt32(Parameters["p_Count"].Value) >= 1;
        }
        internal List<DMThanhToanInfor> Search(DMThanhToanInfor dmChiPhiInfo)
        {
            return GetListCommand<DMThanhToanInfor>(Declare.StoreProcedureNamespace.spHinhThucThanhToanSearch, dmChiPhiInfo.Ma, dmChiPhiInfo.Ten);
        }

        public DMThanhToanInfor GetThanhToanByIdInfo(int idThanhToan)
        {
            return GetObjectCommand<DMThanhToanInfor>(Declare.StoreProcedureNamespace.spHinhThucThanhToanGetbyId, idThanhToan);
        }
    }
}
