using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class Kho_NhanVienDAO : BaseDAO
    {
        private static Kho_NhanVienDAO instance;
        private Kho_NhanVienDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmKhoNhanVien;
            UseCaching = false;
        }
        public static Kho_NhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new Kho_NhanVienDAO();
                return instance;
            }
        }
        public List<Kho_NhanvienInfo> GetListKhoNhanVienInfo()
        {
            return GetListAll<Kho_NhanvienInfo>(Declare.StoreProcedureNamespace.spKhoNhanVienSelectAll, Declare.TableNamespace.DmKhoNhanVien);
        }
        public List<Kho_NhanvienInfo> GetListNhanVienInfoByIdNhanVien(int idNhanVien)
        {
            return GetListCommand<Kho_NhanvienInfo>(Declare.StoreProcedureNamespace.spKhoNhanVienSelectByidNhanvien, idNhanVien);
        }
        internal void Insert(Kho_NhanvienInfo dmKhoInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spKhoNhanVienInsert,dmKhoInfor.IdKho,
                dmKhoInfor.IdNhanVien);
        }
        internal void Delete(Kho_NhanvienInfo dmKhoInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spKhoNhanVienDelete,dmKhoInfor.IdNhanVien);
        }
    }
}
