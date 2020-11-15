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
    public class DMNhanVienDAO : SynchronizableDAO
    {
        private static DMNhanVienDAO instance;
        private DMNhanVienDAO()
        {
            CRUDTableName = Declare.TableNamespace.DmNhanVien;
            UseCaching = true;
            TrackField = "t1.modifiedat";
        }
        public static DMNhanVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new DMNhanVienDAO();
                return instance;
            }
        }
        
        internal override void Synchronize()
        {
            DmSalePersonSynchronize.Instance.Synchronize();
        }

        //public List<DmNhanVienGridInfo> GetListNhanVienInfo()
        //{
        //    return GetListAll<DmNhanVienGridInfo>(Declare.StoreProcedureNamespace.spNhanVienSelectAll, Declare.TableNamespace.DmNhanVien);
        //}

        public List<DMNhanVienInfo> GetListNhanVienInfor()
        {
            //return GetListAll<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienSelectAll, Declare.TableNamespace.DmNhanVien);
            return
                GetListAll<DMNhanVienInfo>(@"SELECT t1.idnhanvien,
					 t1.manhanvien,
					 t1.hoten,
					 t1.ngaysinh,
					 t1.gioitinh,
					 t1.idphongban,
					 t1.idtrungtamhachtoan,
					 t1.idchucvu,
					 t1.diachi,
					 t1.dienthoai,
					 t1.sudung,
					 t1.email,
					 t1.ghichu,
					 t2.tenphongban,
					 t3.tenchucvu,
					 t1.idquanlytructiep,
					 t4.hoten QuanLyTrucTiep
			            FROM tbl_dm_nhanvien t1
			            left join tbl_dm_phongban t2
				            on t1.idphongban = t2.idphongban
			            LEFT JOIN tbl_dm_nhanvien t4
				            ON t1.idquanlytructiep = t4.idnhanvien
			            left join tbl_dm_chucvu t3
				            on t1.idchucvu = t3.idchucvu",
                    Declare.TableNamespace.DmNhanVien);
        }

        public List<DMNhanVienInfo> GetListNhanVienUsingInfor()
        {
            //return GetListAll<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienUsingSelectAll, Declare.TableNamespace.DmNhanVien);
            return
                GetListAll<DMNhanVienInfo>(@"SELECT t1.idnhanvien,
					 t1.manhanvien,
					 t1.hoten,
					 t1.ngaysinh,
					 t1.gioitinh,
					 t1.idphongban,
					 t1.idtrungtamhachtoan,
					 t1.idchucvu,
					 t1.diachi,
					 t1.dienthoai,
					 t1.sudung,
					 t1.email,
					 t1.ghichu,
					 t2.tenphongban,
					 t3.tenchucvu,
					 t1.idquanlytructiep,
					 t4.hoten QuanLyTrucTiep
			            FROM tbl_dm_nhanvien t1
			            left join tbl_dm_phongban t2
				            on t1.idphongban = t2.idphongban
			            LEFT JOIN tbl_dm_nhanvien t4
				            ON t1.idquanlytructiep = t4.idnhanvien
			            left join tbl_dm_chucvu t3
				            on t1.idchucvu = t3.idchucvu
		             where t1.sudung = 1",
                    Declare.TableNamespace.DmNhanVien);
        }

        internal void Update(DMNhanVienInfo dmNhanVienInfor)
        {
            //ExecuteCommand(Declare.StoreProcedureNamespace.spNhanVienUpdate, ParseToParams(dmNhanVienInfor));
            ExecuteCommand(Declare.StoreProcedureNamespace.sp_NhanVien_Update,
                           dmNhanVienInfor.IdNhanVien, dmNhanVienInfor.MaNhanVien,
                           dmNhanVienInfor.HoTen, dmNhanVienInfor.NgaySinh, 
                           dmNhanVienInfor.GioiTinh, dmNhanVienInfor.IdPhongBan, 
                           dmNhanVienInfor.IdChucVu, dmNhanVienInfor.DiaChi, 
                           dmNhanVienInfor.DienThoai, dmNhanVienInfor.SuDung,
                           dmNhanVienInfor.Email, dmNhanVienInfor.GhiChu, 
                           dmNhanVienInfor.IdTrungTamHachToan, 
                           dmNhanVienInfor.IdQuanLyTrucTiep,
                           dmNhanVienInfor.PhuTrachCSKH, dmNhanVienInfor.MaVach);
        }
        internal int Insert(DMNhanVienInfo dmNhanVienInfor)
        {
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spNhanVienInsert);
            //SetParams(dmNhanVienInfor);
            //Parameters["@IdNhanVien"].Direction = ParameterDirection.Output;
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@IdNhanVien"].Value.ToString());
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.sp_DM_NhanVien_Insert, 
               dmNhanVienInfor.MaNhanVien,
               dmNhanVienInfor.HoTen, dmNhanVienInfor.NgaySinh, dmNhanVienInfor.GioiTinh,
               dmNhanVienInfor.IdPhongBan, dmNhanVienInfor.IdChucVu,
               dmNhanVienInfor.DiaChi, dmNhanVienInfor.DienThoai, dmNhanVienInfor.Email,dmNhanVienInfor.GhiChu, dmNhanVienInfor.SuDung,
               dmNhanVienInfor.IdTrungTamHachToan, dmNhanVienInfor.IdQuanLyTrucTiep, dmNhanVienInfor.PhuTrachCSKH, dmNhanVienInfor.MaVach);
        }
        internal void Delete(DMNhanVienInfo dmNhanVienInfor)
        {
            ExecuteCommand(Declare.StoreProcedureNamespace.spNhanVienDelete, dmNhanVienInfor.IdNhanVien);
            //CreateCommonCommand(Declare.StoreProcedureNamespace.spNhanVienDelete);
            //Parameters.AddWithValue("@IdNhanVien", dmNhanVienInfor.IdNhanVien);
            //ExecuteNoneQuery();
        }
        internal bool Exist(DMNhanVienInfo dmNhanVienInfor)
        {
            return GetObjectCommand<int>(Declare.StoreProcedureNamespace.spNhanVienExist,
                dmNhanVienInfor.IdNhanVien,
                dmNhanVienInfor.MaNhanVien) > 0;

            //CreateCommonCommand(Declare.StoreProcedureNamespace.spNhanVienExist);
            //Parameters.AddWithValue("@Count", 0).Direction = ParameterDirection.Output;
            //Parameters.AddWithValue("@IdNhanVien", dmNhanVienInfor.IdNhanVien);
            //Parameters.AddWithValue("@MaNhanVien", dmNhanVienInfor.MaNhanVien);
            //ExecuteNoneQuery();

            //return Convert.ToInt32(Parameters["@Count"].Value.ToString()) == 1;
        }
        internal List<DMNhanVienInfo> Search(DMNhanVienInfo dmNhanVienInfor)
        {
            return GetListCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienSearch,
                dmNhanVienInfor.HoTen,
                dmNhanVienInfor.MaNhanVien,
                dmNhanVienInfor.IdPhongBan,
                dmNhanVienInfor.IdChucVu);

            //CreateGetListCommand(Declare.StoreProcedureNamespace.spNhanVienSearch);
            //Parameters.AddWithValue("@TenNhanVien", dmNhanVienInfor.HoTen);
            //Parameters.AddWithValue("@MaNhanVien", dmNhanVienInfor.MaNhanVien);
            //Parameters.AddWithValue("@IdPhongBan", dmNhanVienInfor.IdPhongBan);
            //Parameters.AddWithValue("@IdChucVu", dmNhanVienInfor.IdChucVu);
            //return FillToList<DMNhanVienInfo>();
        }

        public DMNhanVienInfo GetNhanVienByIdInfo(int idNhanVien)
        {
            return GetObjectCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetById, idNhanVien);
            //CreateGetListCommand(Declare.StoreProcedureNamespace.spNhanVienGetById);
            //Parameters.AddWithValue("@IdNhanVien", idNhanVien);
            //return FillToObject<DMNhanVienInfo>();
        }
        /// <summary>
        /// Trả về danh sách các nhân viên được phép lookup theo user hiện tại
        /// </summary>
        /// <returns></returns>
        public List<DMNhanVienInfo> GetListDmNhanVienInforByUserId(int userId)
        {
            return GetListCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetAllByUserId, userId);
        }

        public List<NhanVienCBOInfo> GetListNhanVienCBOInfor()
        {
            return GetListCommand<NhanVienCBOInfo>(Declare.StoreProcedureNamespace.spNhanVienGetByUserId, Declare.UserId);
        }

        /// <summary>
        /// Trả về danh sách các nhân viên theo id trung tam
        /// </summary>
        /// <returns></returns>
        public List<DMNhanVienInfo> GetListDmNhanVienInforByIdTrungTam(int idTrungTam)
        {
            return GetListCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetAllByTrungTamId, idTrungTam);
        }

        public List<NhanVienCBOInfo> GetListNhanVienCBOInforByIdTrungTam(int idTrungTam)
        {
            return GetListCommand<NhanVienCBOInfo>(Declare.StoreProcedureNamespace.spNhanVienGetByTrungTamId, idTrungTam);
        }

        public List<DMNhanVienInfo> GetListDmNhanVienInforByIdKho(int idKho)
        {
            return GetListCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetByIdKho, idKho);
        }

        public List<DMNhanVienInfo> GetListTruongCaInforByUserId(int userId)
        {
            return GetListCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetTruongCaByUser, userId);
        }

        public List<DMNhanVienInfo> GetListTruongCaInforByIdKho(int idKho)
        {
            return GetListCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetTruongCaByIdKho, idKho);
        }

        public DMNhanVienInfo GetNhanVienInforByCode_UserId(int userId, string code, int truongCa)
        {
            return GetObjectCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetByCodeAndUserId, userId, code, truongCa);
        }
        public List<DMKhoCBOLoadInfo> GetListKhoCBOLoadInfor(int idNhanVien)
        {
            return GetListCommand<DMKhoCBOLoadInfo>(Declare.StoreProcedureNamespace.spKhoSelectByNhanVien, idNhanVien);
        }
        public DMNhanVienInfo GetNhanVienByText(string nhanvien)
        {
            return GetObjectCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetByText, nhanvien);
        }

        public List<DMNhanVienInfo> GetListDmNhanVienInforByIdTrungTamAndNhomNguoiDung(int idTrungTam, int idNhomNguoiDung)
        {
            return GetListCommand<DMNhanVienInfo>(
                @"select nv.IdNhanVien, MaNhanVien, HoTen from tbl_dm_nhanvien nv, tbl_dm_nguoidung nd
                where 1 = 1
                and nv.idnhanvien = nd.idnhanvien
                and nd.idnhomnguoidung = :idNhomNguoiDung
                and idTrungTamHachToan = :idTrungTamHachToan", idNhomNguoiDung, idTrungTam);
        }
        public DMNhanVienInfo GetNhanVienByMaVach(string mavach)
        {
            return GetObjectCommand<DMNhanVienInfo>(Declare.StoreProcedureNamespace.spNhanVienGetByMaVach, mavach);
        }       
    }
}
