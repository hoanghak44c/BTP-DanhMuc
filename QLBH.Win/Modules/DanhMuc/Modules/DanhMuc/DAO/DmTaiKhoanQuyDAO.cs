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
    public class DmTaiKhoanQuyDAO: SynchronizableDAO
    {
        private static DmTaiKhoanQuyDAO instance;
        private DmTaiKhoanQuyDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmTaxCode;
            //UseCaching = true;
        }
        public static DmTaiKhoanQuyDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmTaiKhoanQuyDAO();
                return instance;
            }   
        }

        internal override void Synchronize()
        {
            //DmTaiKhoanQuySynchronize.Instance.Synchronize();
        }

        public List<DMTaiKhoanQuyInfo> GetListTaiKhoanQuyInfors()
        {
            return GetListCommand<DMTaiKhoanQuyInfo>(Declare.StoreProcedureNamespace.spTaiKhoanQuySelectAll);
        }
        public List<DMTaiKhoanQuyInfo> GetListTaiKhoanQuyByTrungTam(int idTrungTam)
        {
            return GetListCommand<DMTaiKhoanQuyInfo>(Declare.StoreProcedureNamespace.spTaiKhoanQuySelectByTrungTam, idTrungTam);
        }
        public DMTaiKhoanQuyInfo GetTaiKhoanQuyByText(string tkquy)
        {
            return GetObjectCommand<DMTaiKhoanQuyInfo>(Declare.StoreProcedureNamespace.spTaiKhoanQuyGetByText, tkquy);
        }
        public DMTaiKhoanQuyInfo GetTaiKhoanQuyTMByTrungTam(int idTrungTam)
        {
            return GetObjectCommand<DMTaiKhoanQuyInfo>(Declare.StoreProcedureNamespace.spTaiKhoanQuyTMGetByTrungTam, idTrungTam);
        }
    }
}
