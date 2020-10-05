using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class CauHinh_LoaiSanPhamDAO : BaseDAO
    {
        private static CauHinh_LoaiSanPhamDAO instance;
        private CauHinh_LoaiSanPhamDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmCauHinhLoaiSP;
            UseCaching = true;
        }
        public static CauHinh_LoaiSanPhamDAO Instance
        {
            get
            {
                if (instance == null) instance = new CauHinh_LoaiSanPhamDAO();
                return instance;
            }
        }
        public List<CauHinh_LoaiSanPhamInfo> GetListCauHinhLoaiSanPhamInfo()
        {
            return GetListAll<CauHinh_LoaiSanPhamInfo>(Declare.StoreProcedureNamespace.spCauHinhLoaiSanPhamSelectAll, Declare.TableNamespace.DmCauHinhLoaiSP);
        }

        internal void Update(CauHinh_LoaiSanPhamInfo info)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhLoaiSanPhamUpdate,info.IdCauHinh,info.IdSanPham,info.MaCauHinh,info.TenCauHinh,info.GhiChu,info.SuDung);
            //SetParams(info);
            //ExecuteNoneQuery();
        }
        internal int Insert(CauHinh_LoaiSanPhamInfo info)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spCauHinhLoaiSanPhamInsert, info.IdCauHinh, info.IdSanPham,
                           info.MaCauHinh, info.TenCauHinh, info.GhiChu, info.SuDung);
            //SetParams(info);
            //Parameters["@IdLoaiSP"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@IdLoaiSP"].Value.ToString());
        }
        internal void Delete(CauHinh_LoaiSanPhamInfo info)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spCauHinhLoaiSanPhamDelete);
            Parameters.AddWithValue("@IdLoaiSP", info.IdCauHinh);
            ExecuteNoneQuery();
        }
        internal bool Exist(CauHinh_LoaiSanPhamInfo info)
        {
            CreateCommonCommand(Declare.StoreProcedureNamespace.spCauHinhLoaiSanPhamExist);
            Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            Parameters.AddWithValue("@IdChucNang", info.IdCauHinh);
            Parameters.AddWithValue("@TenChucNang", info.MaCauHinh);
            ExecuteNoneQuery();

            return Convert.ToInt32(Parameters["@Count"].Value) == 1;
        }
        internal List<CauHinh_LoaiSanPhamInfo> Search(CauHinh_LoaiSanPhamInfo info)
        {
            CreateGetListCommand(Declare.StoreProcedureNamespace.spCauHinhLoaiSanPhamSearch);
            Parameters.AddWithValue("@TenChucNang", info.TenCauHinh);
            Parameters.AddWithValue("@MaChucNang", info.MaCauHinh);
            return FillToList<CauHinh_LoaiSanPhamInfo>();
        }
        public CauHinh_LoaiSanPhamInfo GetCauHinhLoaiSPByIdInfo(int id)
        {
            return GetObjectCommand<CauHinh_LoaiSanPhamInfo>(Declare.StoreProcedureNamespace.spCauHinhLoaiSanPhamGetById,id);
            //Parameters.AddWithValue("@IdChucNang", id);
            //return FillToObject<CauHinh_LoaiSanPhamInfo>();
        }
    }
}
