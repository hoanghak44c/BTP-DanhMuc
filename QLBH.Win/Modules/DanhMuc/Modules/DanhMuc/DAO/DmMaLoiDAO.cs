using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmMaLoiDAO :BaseDAO
    {
        private static DmMaLoiDAO instance;
        private DmMaLoiDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmMaLoi;
            UseCaching = true;
        } 
        public static DmMaLoiDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmMaLoiDAO();
                return instance;
            }
        }

        public List<DMMaLoiPairInfor> GetListMaLoiPairInfor()
        {
            return GetListAll<DMMaLoiPairInfor>(Declare.StoreProcedureNamespace.spMaLoiSelectAll, Declare.TableNamespace.DmMaLoi);
        }
        public List<DMMaLoiInfor> GetListMaLoiInfor()
        {
            return GetListAll<DMMaLoiInfor>(Declare.StoreProcedureNamespace.spMaLoiSelectAll, Declare.TableNamespace.DmMaLoi);
        }

        internal void Update(DMMaLoiInfor dmMaLoiInfor)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spMaLoiUpdate);
            //SetParams(dmMaLoiInfor);
            //ExecuteNoneQuery();


            ExecuteCommand(Declare.StoreProcedureNamespace.spMaLoiUpdate ,dmMaLoiInfor.IdMaLoi,dmMaLoiInfor.MaLoi, dmMaLoiInfor.IdLoaiItem, dmMaLoiInfor.TenLoi, dmMaLoiInfor.GhiChu, dmMaLoiInfor.SuDung);
        }

        internal int Insert(DMMaLoiInfor dmMaLoiInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spMaLoiInsert,dmMaLoiInfor.IdMaLoi,dmMaLoiInfor.MaLoi,dmMaLoiInfor.IdLoaiItem,dmMaLoiInfor.TenLoi,dmMaLoiInfor.GhiChu,dmMaLoiInfor.SuDung);
            return Convert.ToInt32(Parameters["p_IdMaLoi"].Value.ToString());
        }

        internal void Delete(DMMaLoiInfor dmMaLoiInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spMaLoiDelete,dmMaLoiInfor.IdMaLoi);
        }

        internal bool Exist(DMMaLoiInfor dmMaLoiInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spMaLoiExist,dmMaLoiInfor.IdMaLoi,dmMaLoiInfor.TenLoi);
            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<DMMaLoiPairInfor> Search(DMMaLoiPairInfor dmMaLoiInfor)
        {
            return GetListCommand<DMMaLoiPairInfor>(Declare.StoreProcedureNamespace.spMaLoiSearch,dmMaLoiInfor.MaLoi,dmMaLoiInfor.TenLoi);
        }
        public DMMaLoiInfor GetMaLoiByIdInfo(int id)
        {
            return GetObjectCommand<DMMaLoiInfor>(Declare.StoreProcedureNamespace.spMaLoitById, id);
        }
    }
}
