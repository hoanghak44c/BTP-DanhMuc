using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Core.Data;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DmNganHangDAO: SynchronizableDAO
    {
        private static DmNganHangDAO instance;
        private DmNganHangDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmTaxCode;
            UseCaching = true;
        }
        public static DmNganHangDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmNganHangDAO();
                return instance;
            }   
        }

        internal override void Synchronize()
        {
            DmNganHangSynchronize.Instance.Synchronize();
        }

        public List<DMNganHangInfor> GetListNganHangInfors()
        {
            return GetListCommand<DMNganHangInfor>(Declare.StoreProcedureNamespace.spNganHangSelectAll);
        }

        internal void Update(DMNganHangInfor dmNganHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNganHangUpdate, dmNganHangInfo.IdNganHang,
                           dmNganHangInfo.MaNganHang, dmNganHangInfo.TenNganHang, dmNganHangInfo.GhiChu,
                           dmNganHangInfo.SuDung);
        }

        internal int Insert(DMNganHangInfor dmNganHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNganHangInsert, dmNganHangInfo.MaNganHang,
                           dmNganHangInfo.TenNganHang, dmNganHangInfo.GhiChu, dmNganHangInfo.SuDung);

            return Convert.ToInt32(Parameters["p_IdNganHang"].Value.ToString());
        }

        internal void Delete(DMNganHangInfor dmNganHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNganHangDelete, dmNganHangInfo.IdNganHang);
        }

        public bool Exist(DMNganHangInfor dmNganHangInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNganHangExist, dmNganHangInfo.IdNganHang, dmNganHangInfo.MaNganHang);

            return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        }

        internal List<DMNganHangInfor> Search(DMNganHangInfor dmNganHangInfo)
        {
            return GetListCommand<DMNganHangInfor>(Declare.StoreProcedureNamespace.spNganHangSearch, dmNganHangInfo.MaNganHang, dmNganHangInfo.TenNganHang);
        }

        public DMNganHangInfor GetNganHangByIdInfo(int idNganHang)
        {
            return GetObjectCommand<DMNganHangInfor>(Declare.StoreProcedureNamespace.spNganHangGetbyId, idNganHang);
        }
        public DMNganHangInfor GetNganHangByText(string nganHang)
        {
            return GetObjectCommand<DMNganHangInfor>(Declare.StoreProcedureNamespace.spNganHangGetText, nganHang);
        }
    }
}
