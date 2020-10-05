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
    //public class TblKhoNhanVien : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmkHoNhanVien;
    //    }
    //}
    //[Serializable]
    //public class Kho_NhanVienInfo : TblKhoNhanVien
    //{
    //    public Kho_NhanVienInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(false)]
    //    public int IdKho { get; set; }
    //    [IsKey(false)]
    //    [NullValue(-1)]
    //    public int IdNhanVien { get; set; }
        
    //}

    //[Serializable]
    //public class Kho_NhanVienDelInfo : TblKhoNhanVien
    //{
    //    public Kho_NhanVienDelInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    public int IdKho { get; set; }
    //    [IsKey(false)]
    //    [NullValue(-1)]
    //    public int IdNhanVien { get; set; }

    //}
    public class Kho_NhanVienDataProvider
    {
        public static List<Kho_NhanvienInfo> GetListKhoNhanVienInfo()
        {
            return Kho_NhanVienDAO.Instance.GetListKhoNhanVienInfo();
        }

        public static List<Kho_NhanvienInfo> GetListKhoNhanVienInfoFromIdNhanVien(int idnhanvien)
        {
            return Kho_NhanVienDAO.Instance.GetListNhanVienInfoByIdNhanVien(idnhanvien);
        }

        internal static bool KiemTra(Predicate<Kho_NhanvienInfo> match)
        {
            return ProviderBase.Exists(match);
        }

        internal static void Insert(Kho_NhanvienInfo khoNhanVienInfo)
        {
            Kho_NhanVienDAO.Instance.Insert(khoNhanVienInfo);
        }

        internal static void Delete(Kho_NhanvienInfo khoNhanVienInfo)
        {
            Kho_NhanVienDAO.Instance.Delete(khoNhanVienInfo);
        }
    }
}
