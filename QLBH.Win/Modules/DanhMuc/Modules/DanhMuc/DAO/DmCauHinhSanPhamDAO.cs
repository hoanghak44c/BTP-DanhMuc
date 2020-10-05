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
    public class DmCauHinhSanPhamDAO :SynchronizableDAO
    {
        private static DmCauHinhSanPhamDAO instance;
        private DmCauHinhSanPhamDAO()
        {
            //CRUDTableName = Declare.TableNamespace.DmDuAn;
            //UseCaching = true;
        }

        public static DmCauHinhSanPhamDAO Instance
        {
            get
            {
                if (instance == null) instance = new DmCauHinhSanPhamDAO();
                return instance;
            }
        }

        //internal override void Synchronize()
        //{
        //    DmDuAnSynchronize.Instance.Synchronize();
        //}
        public List<DMCauHinhSanPhamInfo> GetListCauHinhSanPham()
        {
            return GetListCommand<DMCauHinhSanPhamInfo>(Declare.StoreProcedureNamespace.spCauHinhSanPhamSelectAll);
        }
        public List<DMCauHinhSanPhamInfo> GetListSearchCauHinhSanPhamCo(int ton)
        {
            return GetListCommand<DMCauHinhSanPhamInfo>(Declare.StoreProcedureNamespace.spCauHinhSanPhamSearch,ton);
        }
        public List<DMCauHinhSanPhamInfo> GetListSearchCauHinhSanPhamKhong(int ton)
        {
            return GetListCommand<DMCauHinhSanPhamInfo>(Declare.StoreProcedureNamespace.spCauHinhSanPhamSearchKhong,ton);
        }
        public DMCauHinhSanPhamInfo GetNhaCCByIdSanPham(int idSanPham)
        {
            return GetObjectCommand<DMCauHinhSanPhamInfo>(Declare.StoreProcedureNamespace.spNhaCCGetByIdSanPham, idSanPham);
        }
        internal void Update(int idSanPham, string tenCauHinh, string giaTri, int soTT)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhSanPhamUpdate,
                           idSanPham,
                           tenCauHinh,
                           giaTri,
                           soTT);
        }
        internal void UpdateLogo(int idSanPham,string loGo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhSanPhamUpdateLogo,idSanPham,loGo);
        }
        internal void Insert(int idSanPham, string tenCauHinh, string giaTri, int soTT)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhSanPhamInsert, idSanPham,
                           tenCauHinh,
                           giaTri,
                           soTT);
            //return Convert.ToInt32(Parameters["p_IdSanPham"].Value.ToString());
        }

        internal void Delete(DMCauHinhSanPhamInfo dmCauHinhSanPhamInfo)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhSanPhamDelete, dmCauHinhSanPhamInfo.IdSanPham);
        }

        internal void Delete(int idSanPham)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhSanPhamDelete, idSanPham);
        }

        //public bool Exist(DMCauHinhSanPhamInfo dmCauHinhSanPhamInfo)
        //{
        //    ExecuteCommand(Declare.StoreProcedureNamespace.spDuAnExist, dmDuAnInfor.IdDuAn, dmDuAnInfor.MaDuAn);

        //    return Convert.ToInt32(Parameters["p_Count"].Value) == 1;
        //}

        internal List<DMCauHinhSanPhamInfo> Search(DMCauHinhSanPhamInfo dmCauHinhSanPhamInfo)
        {
            return GetListCommand<DMCauHinhSanPhamInfo>(Declare.StoreProcedureNamespace.spCauHinhSanPhamSearch, dmCauHinhSanPhamInfo.TenCauHinh, dmCauHinhSanPhamInfo.GiaTri);
        }

        public List<DMCauHinhSanPhamInfo> GetCauHinhByIdSanPham(int idSanPham)
        {
            return GetListCommand<DMCauHinhSanPhamInfo>(Declare.StoreProcedureNamespace.spCauHinhSanPhamGetbyId, idSanPham);
        }

        public bool DaCoCauHinh(int idSanPham)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhSanPhamExists);

            return Convert.ToInt32(Parameters["p_Count"].Value.ToString()) > 0;
        }
    }
}
