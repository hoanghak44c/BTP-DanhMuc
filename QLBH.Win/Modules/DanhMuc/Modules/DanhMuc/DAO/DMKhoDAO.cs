using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DongBoERP;
using QLBH.Common;
using QLBH.Core.Data;

namespace QLBanHang.Modules.DanhMuc.DAO
{
    public class DMKhoDAO : SynchronizableDAO
    {
        private static DMKhoDAO instance;

        private DMKhoDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmKho;
            UseCaching = true;
        }

        public static DMKhoDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMKhoDAO();
                return instance;
            }
        }

        internal override void Synchronize()
        {
            DmKhoSynchronize.Instance.Synchronize();
        }

        internal List<DMKhoGridLoadInfo> GetListKhoInfo()
        {
            return GetListAll<DMKhoGridLoadInfo>(Declare.StoreProcedureNamespace.spKhoSelectAll, Declare.TableNamespace.DmKho);
        }
        /// <summary>
        /// Không lấy kho type = 3
        /// </summary>
        /// <returns></returns>
        public List<DMKhoInfo> GetListKhoInfor()
        {
            return GetListAll<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoSelectAllEx3, Declare.TableNamespace.DmKho);
        }

        public List<DMKhoCBOLoadInfo> GetListKhoCBOInfo()
        {
            return GetListAll<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.spKhoSelectPair, Declare.TableNamespace.DmKho);
        }

        /// <summary>
        /// Tra ve danh sach cac kho khac tru kho hien tai (dung de dieu chuyen kho).
        /// </summary>
        /// <returns></returns>
        public List<DMKhoCBOLoadInfo> GetListKhoOrtherByNhanVien()
        {
            return GetListCommand<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.spKhoSelectOtherByNhanVien, Declare.IdNhanVien, Declare.IdKho);
        }

        public List<DMKhoCBOLoadInfo> GetListKhoByNhanVien(int idNhanVien)
        {
            return GetListCommand<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.spKhoSelectByNhanVien, idNhanVien);
        }

        public List<DMKhoInfo> GetListKhoInforByIdNhanVien(int idNhanVien)
        {
            return GetListCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoSelectInforByIdNhanVien, idNhanVien);
        }
        public List<DMKhoInfo> GetListKhoInforByIdNhanVien2(int idNhanVien)
        {
            return GetListCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoSelectInforByIdNhanVien2, idNhanVien);
        }
        public List<DMKhoInfo> GetListKhoDieuChuyenByIdNhanVien(int idNhanVien)
        {
            return GetListCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoDieuChuyenSelectByIdNhanVien, idNhanVien);
        }
        public List<DMKhoCBOLoadInfo> GetListKhoByUser(int idUser)
        {
            return GetListCommand<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.spKhoSelectByUser, idUser);
        }

        internal void Update(DMKhoInfo dmKhoInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spKhoUpdate, dmKhoInfor.IdKho, dmKhoInfor.IdTrungTam, dmKhoInfor.MaKho,
                           dmKhoInfor.TenKho, dmKhoInfor.DiaChi, dmKhoInfor.DienThoai, dmKhoInfor.Fax, dmKhoInfor.Email,
                           dmKhoInfor.GhiChu, dmKhoInfor.SuDung, dmKhoInfor.NgayKhoaSo, dmKhoInfor.NgayDuDau, dmKhoInfor.InHoaDon, dmKhoInfor.InPhieuXuat, dmKhoInfor.LanDongBoTruoc
                           , dmKhoInfor.MaVung, dmKhoInfor.IdKhachMacDinh, dmKhoInfor.KhoaNhapDauKy, dmKhoInfor.OtherTrungTam,
                           dmKhoInfor.MaKhoOracle, dmKhoInfor.ViTri, dmKhoInfor.Duong, dmKhoInfor.Tinh, dmKhoInfor.QuocGia, dmKhoInfor.Type);

        }

        internal int Insert(DMKhoInfo dmKhoInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spKhoInsert, dmKhoInfor.IdTrungTam, 
                dmKhoInfor.MaKho, dmKhoInfor.TenKho, dmKhoInfor.DiaChi, dmKhoInfor.DienThoai, 
                dmKhoInfor.Fax, dmKhoInfor.Email, dmKhoInfor.GhiChu, dmKhoInfor.SuDung,
                dmKhoInfor.NgayKhoaSo,dmKhoInfor.NgayDuDau,dmKhoInfor.InHoaDon, dmKhoInfor.InPhieuXuat,
                dmKhoInfor.LanDongBoTruoc, dmKhoInfor.MaVung, dmKhoInfor.IdKhachMacDinh,
                dmKhoInfor.KhoaNhapDauKy,dmKhoInfor.OtherTrungTam, dmKhoInfor.MaKhoOracle, 
                dmKhoInfor.ViTri, dmKhoInfor.Duong, dmKhoInfor.Tinh,dmKhoInfor.QuocGia, dmKhoInfor.Type);
        }

        internal void Delete(DMKhoInfo dmKhoInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spKhoDelete, dmKhoInfor.IdKho);
        }

        internal bool Exist(DMKhoInfo dmKhoInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spKhoExist, dmKhoInfor.IdKho, dmKhoInfor.MaKho) > 0;
        }

        internal List<DMKhoGridLoadInfo> Search(DMKhoGridLoadInfo dmKhoInfor)
        {
            return GetListCommand<DMKhoGridLoadInfo>(Declare.StoreProcedureNamespace.spKhoSearch, dmKhoInfor.MaKho, dmKhoInfor.TenKho);
        }

        public DMKhoInfo GetKhoByIdInfo(int idKho)
        {
            return GetObjectCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoGetById, idKho);
        }

        internal List<DMKhoCBOLoadInfo> GetListKhoCBOInfo(int idTrungTam)
        {
            return GetListCommand<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.spKhoSelectPairByTrungTam, idTrungTam);
        }

        public List<DMKhoInfo> GetListKhoInfo(int idTrungTam)
        {
            return GetListCommand<DMKhoInfo>("select * from tbl_dm_kho where idtrungtam = :idtrungtam", idTrungTam);
        }

        internal List<DMKhoInfo> GetListKhoNhapLaiInfoByTTamNVien(int idTrungTam, int idNhanVien)
        {
            return GetListCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoNhapLaiGetByTrungTamNhanVien, idTrungTam, idNhanVien);
        }

        internal List<DMKhoInfo> GetListKhoInfoByTTamNVien(int idTrungTam, int idNhanVien)
        {
            return GetListCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoGetByTrungTamNhanVien, idTrungTam, idNhanVien);
        }

        public List<NhanVienCBOInfo> GetListNhanVienCBOInfo(int idKho)
        {
            return GetListCommand<NhanVienCBOInfo>(Declare.StoreProcedureNamespace.spNhanVienGetByKhoId, idKho);
        }
        public DMKhoInfo GetKhoInfoByCode(string code, int idTrungTam)
        {
            return GetObjectCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoGetByCode, code, idTrungTam);
        }
        public DMKhoInfo GetKhoByText(string kho)
        {
            return GetObjectCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.spKhoGetByText, kho);
        }
        internal List<DMKhoCBOLoadInfo> GetKhoByInfor()
        {
            return GetListCommand<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.sp_dm_kho_getkhoandtentrungtam);
            //return GetListCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.SP_DM_KHO_GETINFORKHO);
        }
        //internal  List<DMKhoInfo>GetKhoByIdTrungTamHachToan()
        //{
        //    return GetListCommand<DMKhoInfo>(Declare.StoreProcedureNamespace.sp_Kho_GetByIdTrungTamHachToan);
        //}
        internal List<DMKhoCBOLoadInfo> GetKhoByIdTrungTamHachToan(int Idtrungtamhachtoan)
        {
            return GetListCommand<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.sp_Dm_Kho_GetKhoByIdTrungTam, Idtrungtamhachtoan);
        }

        public bool IsCrossedOU(int idKho1, int idKho2)
        {
            return Convert.ToInt32(ExecuteScalar(@"select decode(tt1.ouid, (select tt2.ouid from tbl_dm_kho kho2
                    inner join tbl_dm_trungtam tt2 on kho2.idtrungtam = tt2.idtrungtam
                    where kho2.idkho = :IdKho2), 0, 1) from tbl_dm_kho kho1
                inner join tbl_dm_trungtam tt1 on kho1.idtrungtam = tt1.idtrungtam
                where kho1.idkho = :IdKho1", idKho2, idKho1)) == 1;
        }

        public List<DMKhoSInfo> GetListIdKhoTon(int idTrungTam)
        {
            string cmdText = @"select distinct abs(htk.idkho) idkho, kho.idtrungtam from tbl_hanghoa_chitiet htk
                        inner join tbl_dm_kho kho on kho.idkho = abs(htk.idkho)";

            var param = new List<object>();

            if(idTrungTam > 0)
            {
                cmdText += " and kho.idtrungtam = :idTrungTam";

                param.Add(idTrungTam);
            }

            cmdText += " where htk.soluong > 0";

            return GetListCommand<DMKhoSInfo>(cmdText, param.ToArray());
        }
    }
}
