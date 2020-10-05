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
    //public class TblDmKho : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmkHo;
    //    }
    //}
    //[Serializable]
    //public class DMKhoInfo : TblDmKho
    //{
    //    public DMKhoInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1), IsKey(true)]
    //    public int IdKho { get; set; }
    //    [NullValue(-1)]
    //    public int IdTrungTam { get; set; }
    //    [NullValue("")]
    //    public string MaKho { get; set; }
    //    [NullValue("")]
    //    public string TenKho { get; set; }
    //    [NullValue("")]
    //    public string DiaChi { get; set; }
    //    [NullValue("")]
    //    public string DienThoai { get; set; }
    //    [NullValue("")]
    //    public string Fax { get; set; }
    //    [NullValue("")]
    //    public string Email { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue(typeof(DateTime), Declare.DateMinValue)]
    //    public DateTime NgayKhoaSo { get; set; }
    //    [NullValue(typeof(DateTime), Declare.DateMinValue)]
    //    public DateTime NgayDuDau { get; set; }
    //    [NullValue(-1)]
    //    public int InHoaDon { get; set; }
    //    [NullValue(-1)]
    //    public int InPhieuXuat { get; set; }
    //    [NullValue(typeof(DateTime), Declare.DateMinValue)]
    //    public DateTime LanDongBoTruoc { get; set; }
    //    [NullValue("")]
    //    public string MaVung { get; set; }
    //    [NullValue(-1)]
    //    public int IdKhachMacDinh { get; set; }
    //    [NullValue(-1)]
    //    public int KhoaNhapDauKy { get; set; }
    //    [NullValue("")]
    //    public string OtherTrungTam { get; set; }
    //    [NullValue("")]
    //    public string MaKhoOracle { get; set; }
    //}

    //[Serializable]
    //public class DMKhoGridLoadInfo : TblDmKho
    //{
    //    public DMKhoGridLoadInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1), IsKey(true)]
    //    public int IdKho { get; set; }
    //    [NullValue(-1)]
    //    public int IdTrungTam { get; set; }
    //    [NullValue("")]
    //    public string MaKho { get; set; }
    //    [NullValue("")]
    //    public string TenKho { get; set; }
    //    [NullValue("")]
    //    public string DiaChi { get; set; }
    //    [NullValue("")]
    //    public string DienThoai { get; set; }
    //    [NullValue("")]
    //    public string Fax { get; set; }
    //    [NullValue("")]
    //    public string Email { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue("")]
    //    public string MaVung { get; set; }
    //    [NullValue("")]
    //    public string OtherTrungTam { get; set; }
    //    [NullValue("")]
    //    public string MaKhoOracle { get; set; }
    //}

    //[Serializable]
    //public class DMKhoCboLoadInfo : TblDmKho,ISuDung
    //{
    //    public DMKhoCboLoadInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1), IsKey(true)]
    //    public int IdKho { get; set; }
    //    [NullValue("")]
    //    public string TenKho { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
        
    //}

    //[Serializable]
    //public class DmKhoByTrungTamPairInfo : TblDmKho, ISuDung
    //{
    //    public DmKhoByTrungTamPairInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    public int IdTrungTam { get; set; }
    //    [NullValue("")]
    //    public string MaKho { get; set; }
    //    [NullValue("")]
    //    public string TenKho { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }

    //}

    public class DMKhoDataProvider :SynchronizableProvider
    {
        private static DMKhoDataProvider instance;
        private DMKhoDataProvider()
        {
            controllerDAO = DMKhoDAO.Instance;
            Member = "dW9B2y9pK4jloiFl+DSbWA==";
        }

        public static DMKhoDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMKhoDataProvider();
                return instance;
            }   
        }

        public static List<DMKhoGridLoadInfo> GetListDMKhoInfo()
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoInfo());
        }
        /// <summary>
        /// Không lấy kho type = 3
        /// </summary>
        /// <returns></returns>
        public static List<DMKhoInfo> GetListDMKhoInfor()
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoInfor());
        }

        public static DMKhoInfo GetKhoByIdInfo(int idKho)
        {
            return DMKhoDAO.Instance.GetKhoByIdInfo(idKho);
        }

        public static List<DMKhoCBOLoadInfo> GetCboDMKhoInfo()
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoCBOInfo());
        }
        /// <summary>
        /// Trả về danh sách các kho khác (trừ kho hiện tại, dùng cho điều chuyển kho)
        /// </summary>
        /// <returns></returns>
        public List<DMKhoCBOLoadInfo> GetListKhoOrtherByNhanVien()
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoOrtherByNhanVien());
        }

        /// <summary>
        /// Trả về danh sách các kho theo id nhan vien
        /// </summary>
        /// <returns></returns>
        public List<DMKhoCBOLoadInfo> GetListKhoByNhanVien(int idNhanVien)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoByNhanVien(idNhanVien));
        }
        public static List<DMKhoInfo> GetListKhoInforByIdNhanVien(int idNhanVien)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoInforByIdNhanVien(idNhanVien));
        }
        /// <summary>
        /// Trả về danh sách các kho được quyền yêu cầu điều chuyển
        /// </summary>
        /// <param name="idNhanVien"></param>
        /// <returns>
        /// Trả về danh sách các kho được quyền yêu cầu điều chuyển. 
        /// Giám đốc siêu thị thì được quyền yêu cầu từ mọi kho.
        /// </returns>
        public static List<DMKhoInfo> GetListKhoInforByIdNhanVien2(int idNhanVien)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoInforByIdNhanVien2(idNhanVien));
        }
        public static List<DMKhoInfo> GetListKhoDieuChuyenByIdNhanVien(int idNhanVien)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoDieuChuyenByIdNhanVien(idNhanVien));
        }

        public List<DMKhoCBOLoadInfo> GetListKhoByUser(int idUser)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoByUser(idUser));
        }

        public List<NhanVienCBOInfo> GetListNhanVienCBOInfo(int idKho)
        {
            return DMKhoDAO.Instance.GetListNhanVienCBOInfo(idKho);
        }

        public static List<DMKhoCBOLoadInfo> GetListKhoByTrungTamPairInfo(int idTrungTam)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoCBOInfo(idTrungTam));
        }

        public List<DMKhoInfo> GetListKhoInfo(int idTrungTam)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoInfo(idTrungTam));
        }

        public List<DMKhoInfo> GetListKhoByTrungTam(int idTrungTam)
        {
            List<DMKhoInfo> buffer = DMKhoDAO.Instance.GetListKhoInfor();

            return Instance.Validate(buffer.FindAll(delegate(DMKhoInfo match) { return match.IdTrungTam == idTrungTam; }));
        }

        public List<DMKhoGridLoadInfo> GetListAllKhoByTrungTam(int idTrungTam)
        {
            List<DMKhoGridLoadInfo> buffer = DMKhoDAO.Instance.GetListKhoInfo();

            return Instance.Validate(buffer.FindAll(delegate(DMKhoGridLoadInfo match) { return match.IdTrungTam == idTrungTam; }));
        }

        public static List<DMKhoInfo> GetListKhoInfoByTTamNVien(int idTrungTam, int idNhanVien)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoInfoByTTamNVien(idTrungTam, idNhanVien));
        }

        public static List<DMKhoInfo> GetListKhoNhapLaiInfoByTTamNVien(int idTrungTam, int idNhanVien)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListKhoNhapLaiInfoByTTamNVien(idTrungTam, idNhanVien));
        }

        internal static bool KiemTra(DMKhoInfo match)
        {
            return DMKhoDAO.Instance.Exist(match);
        }

        internal static void Insert(DMKhoInfo dmLoaiThuChiInfo)
        {
            DMKhoDAO.Instance.Insert(dmLoaiThuChiInfo);
        }

        internal static void Update(DMKhoInfo dmLoaiThuChiInfo)
        {
            DMKhoDAO.Instance.Update(dmLoaiThuChiInfo);
        }

        public static void Delete(DMKhoInfo dmLoaiThuChiInfo)
        {
            DMKhoDAO.Instance.Delete(dmLoaiThuChiInfo);
        }

        public static List<DMKhoGridLoadInfo> Search(DMKhoGridLoadInfo match)
        {
            return Instance.Validate(DMKhoDAO.Instance.Search(match));
        }

        public DMKhoInfo GetKhoInfoByCode(string code, int idTrungTam)
        {
            return DMKhoDAO.Instance.GetKhoInfoByCode(code, idTrungTam);
        }

        public DMKhoInfo GetKhoByText(string kho)
        {
            return DMKhoDAO.Instance.GetKhoByText(kho);
        }

        public bool IsCrossedOU(int idKho1, int idKho2)
        {
            return DMKhoDAO.Instance.IsCrossedOU(idKho1, idKho2);
        }

        public List<DMKhoSInfo> GetListIdKhoTon(int idTrungTam)
        {
            return Instance.Validate(DMKhoDAO.Instance.GetListIdKhoTon(idTrungTam));
        }
    }
}