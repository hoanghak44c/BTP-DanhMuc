using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.DAO;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // DMLoaiThuChiDataProvider
    // Người tạo: Trần Tuấn Cường
    // Ngày tạo : 29/02/2012
    //Người sửa cuối:29/02/2012
    // </remarks>
    //[Serializable]
    //public class TblDoiTuongDiaChi : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DoiTuongDiaChi;
    //    }
    //}
    //[Serializable]
    //public class DoiTuong_DiaChiInfo : TblDoiTuongDiaChi
    //{
    //    public DoiTuong_DiaChiInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(false)]
    //    public int IdDiaChi { get; set; }
    //    [IsKey(false)]
    //    [NullValue(-1)]
    //    public int IdDoiTuong { get; set; }
    //    [NullValue("")]
    //    public string SiteNumber { get; set; }
    //    [NullValue("")]
    //    public string DiaChi { get; set; }
    //    [NullValue("")]
    //    public string MaVung { get; set; }

    //}

    public class DoiTuong_DiaChiDataProvider
    {
        //public static List<DoiTuong_DiaChiInfo> GetListDoiTuongDiaChiInfo()
        //{
        //    return ProviderBase.SelectAll<DoiTuong_DiaChiInfo>();
        //}

        public static List<DoiTuong_DiaChiInfo> GetListDoiTuongDiaChiInfoFromIdDoiTuong(int match)
        {
            return DoiTuong_DiaChiDAO.Instance.GetDoiTuongDiaChiByIdInfo(match);
        }

        //internal static bool KiemTra(Predicate<DoiTuong_DiaChiInfo> match)
        //{
        //    return ProviderBase.Exists(match);
        //}

        internal static void Insert(DoiTuong_DiaChiInfo dmDoiTuongDiachiInfo)
        {
            DoiTuong_DiaChiDAO.Instance.Insert(dmDoiTuongDiachiInfo);
        }
        
        //internal static void Update(DoiTuong_DiaChiInfo dmDoiTuongDiachiInfo)
        //{
        //    ProviderBase.Update(dmDoiTuongDiachiInfo);
        //}

        internal static void Delete(DoiTuong_DiaChiInfo dmDoiTuongDiachiInfo)
        {
            DoiTuong_DiaChiDAO.Instance.Delete(dmDoiTuongDiachiInfo);
        }

    }
}
