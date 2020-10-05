using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
//using Oracle.DataAccess.Client;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Providers;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // DMLoaiThuChiDataProvider
    // Người tạo: Trần Tuấn Cường
    // Ngày tạo : 29/02/2012
    //Người sửa cuối:29/02/2012
    // </remarks>
    //[Serializable]
    //public class TblDmLoaiNhanVien : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmNhanVien;
    //    }
    //}

    //[Serializable]
    //public class DmNhanVienInfo : TblDmLoaiNhanVien
    //{
    //    public DmNhanVienInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdNhanVien { get; set; }
    //    [NullValue("")]
    //    public string MaNhanVien { get; set; }
    //    [NullValue("")]
    //    public string HoTen { get; set; }

    //    [NullValue("")]
    //    public string NgaySinh { get; set; }
    //    [NullValue(-1)]
    //    public int GioiTinh { get; set; }
    //    [NullValue(-1)]
    //    public int IdPhongBan { get; set; }
    //    [NullValue(-1)]
    //    public int IdChucVu { get; set; }
    //    [NullValue("")]
    //    public string DiaChi { get; set; }

    //    [NullValue("")]
    //    public string DienThoai { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }

    //    [NullValue("")]
    //    public string Email { get; set; }

    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //}

    ////note: @All chú ý cách dùng khai báo để join table
    //[Serializable, 
    //Join(JoinType.INNER, Declare.TableNamespace.DmPhongBan, "IdPhongBan"), 
    //Join(JoinType.INNER, Declare.TableNamespace.DmChucVu, "IdChucVu")]
    //public class DmNhanVienGridInfo : TblDmLoaiNhanVien
    //{
    //    public DmNhanVienGridInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1), IsKey(true)]
    //    public int IdNhanVien { get; set; }
    //    [NullValue("")]
    //    public string MaNhanVien { get; set; }
    //    [NullValue("")]
    //    public string HoTen { get; set; }

    //    [NullValue("")]
    //    public string NgaySinh { get; set; }
    //    [NullValue(-1)]
    //    public int GioiTinh { get; set; }

    //    [NullValue(-1), Owner(Declare.TableNamespace.DmNhanVien)]
    //    public int IdPhongBan { get; set; }

    //    [NullValue(-1), Owner(Declare.TableNamespace.DmNhanVien)]
    //    public int IdChucVu { get; set; }

    //    [NullValue("")]
    //    public string DiaChi { get; set; }

    //    [NullValue("")]
    //    public string DienThoai { get; set; }

    //    //note: @All nếu field có ở nhiều bảng thì phải chỉ rõ field đi theo bảng nào
    //    //note: vì SuDung có ở DmPhongBan, DmChucVu, DmNhanVien nên ở đây cần chỉ rõ là lấy từ bảng DmNhanVien
    //    [NullValue(-1), Owner(Declare.TableNamespace.DmNhanVien)]
    //    public int SuDung { get; set; }

    //    [NullValue("")]
    //    public string Email { get; set; }

    //    [NullValue(""), Owner(Declare.TableNamespace.DmNhanVien)]
    //    public string GhiChu { get; set; }

    //    [NullValue("")]
    //    public string TenPhongBan { get; set; }

    //    [NullValue("")]
    //    public string TenChucVu { get; set; }
    //}

    public class DmNhanVienDataProvider : SynchronizableProvider
    {
        /// <summary>
        /// Dùng để fill grid
        /// </summary>
        /// <returns></returns>
        private static DmNhanVienDataProvider instance;

        private DmNhanVienDataProvider()
        {
            controllerDAO = DMNhanVienDAO.Instance;
        }

        public static DmNhanVienDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmNhanVienDataProvider();
                return instance;
            }   
        }
        //public static List<DmNhanVienGridInfo> GetListDmNhanVienInfo()
        //{
        //    return DMNhanVienDAO.Instance.GetListNhanVienInfo();
        //}

        public static List<DMNhanVienInfo> GetListDmNhanVienInfor()
        {
            return DMNhanVienDAO.Instance.GetListNhanVienInfor();
        }

        public static List<DMNhanVienInfo> GetListDmNhanVienUsingInfor()
        {
            return DMNhanVienDAO.Instance.GetListNhanVienUsingInfor();
        }

        /// <summary>
        /// Trả về danh sách các nhân viên được phép look up theo user hiện tại
        /// </summary>
        /// <returns></returns>
        public static List<DMNhanVienInfo> GetListDmNhanVienInforByUserId(int userId)
        {
            return DMNhanVienDAO.Instance.GetListDmNhanVienInforByUserId(userId);
        }

        public static List<NhanVienCBOInfo> GetListNhanVienCBOInfor()
        {
            return DMNhanVienDAO.Instance.GetListNhanVienCBOInfor();
        }

        /// <summary>
        /// Trả về danh sách các nhân viên được phép look up theo user hiện tại
        /// </summary>
        /// <returns></returns>
        public static List<DMNhanVienInfo> GetListDmNhanVienInforByIdTrungTam(int idTrungTam)
        {
            return DMNhanVienDAO.Instance.GetListDmNhanVienInforByIdTrungTam(idTrungTam);
        }

        public static List<NhanVienCBOInfo> GetListNhanVienCBOInforByIdTrungTam(int idTrungTam)
        {
            return DMNhanVienDAO.Instance.GetListNhanVienCBOInforByIdTrungTam(idTrungTam);
        }

        public static List<DMNhanVienInfo> GetListDmNhanVienInforByIdKho(int idKho)
        {
            return DMNhanVienDAO.Instance.GetListDmNhanVienInforByIdKho(idKho);
        }

        public static List<DMNhanVienInfo> GetListTruongCaInforByUserId(int userId)
        {
            return DMNhanVienDAO.Instance.GetListTruongCaInforByUserId(userId);
        }

        public static List<DMNhanVienInfo> GetListTruongCaInforByIdKho(int idKho)
        {
            return DMNhanVienDAO.Instance.GetListTruongCaInforByIdKho(idKho);
        }

        public static DMNhanVienInfo GetNhanVienInforByCode_UserId(int userId, string code, int truongCa)
        {
            return DMNhanVienDAO.Instance.GetNhanVienInforByCode_UserId(userId, code, truongCa);
        }

        public static DMNhanVienInfo GetListDmNhanVienInfoFromOid(int oid)
        {
            return DMNhanVienDAO.Instance.GetNhanVienByIdInfo(oid);
        }

        public static bool KiemTra(DMNhanVienInfo match)
        {
            return DMNhanVienDAO.Instance.Exist(match);
        }

        internal static int Insert(DMNhanVienInfo dmNhanVienInfo)
        {
            return DMNhanVienDAO.Instance.Insert(dmNhanVienInfo);
        }

        internal void AddKho(Kho_NhanvienInfo khoNhanvienInfo)
        {
            Kho_NhanVienDAO.Instance.Insert(khoNhanvienInfo);
        }

        internal void RemoveKho(Kho_NhanvienInfo khoNhanvienInfo)
        {
            Kho_NhanVienDAO.Instance.Delete(khoNhanvienInfo);
        }

        internal static void Update(DMNhanVienInfo dmNhanVienInfo)
        {
            DMNhanVienDAO.Instance.Update(dmNhanVienInfo);
        }

        public static void Delete(DMNhanVienInfo dmNhanVienInfo)
        {
            DMNhanVienDAO.Instance.Delete(dmNhanVienInfo);
        }

        public static List<DMNhanVienInfo> Search(DMNhanVienInfo match)
        {
            return DMNhanVienDAO.Instance.Search(match);
        }

        public List<DMKhoCBOLoadInfo> GetListKhoCBOLoadInfor(int idNhanVien)
        {
            return DMNhanVienDAO.Instance.GetListKhoCBOLoadInfor(idNhanVien);
        }
        public static DMNhanVienInfo GetNhanVienByText(string nhanvien)
        {
            return DMNhanVienDAO.Instance.GetNhanVienByText(nhanvien);
        }

        public static List<DMNhanVienInfo> GetListDmNhanVienInforByIdTrungTamAndNhomNguoiDung(int idTrungTam, int idNhomNguoiDung)
        {
            return DMNhanVienDAO.Instance.GetListDmNhanVienInforByIdTrungTamAndNhomNguoiDung(idTrungTam, idNhomNguoiDung);
        }
        public DMNhanVienInfo GetNhanVienByMaVach(string mavach)
        {
            return DMNhanVienDAO.Instance.GetNhanVienByMaVach(mavach);
        }  
    }
}
