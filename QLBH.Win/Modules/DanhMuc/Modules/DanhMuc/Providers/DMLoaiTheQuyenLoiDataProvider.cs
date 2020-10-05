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
    //public class TblDmLoaiTheQuyenLoi : DataObject
    //{
    //    #region Overrides of DataObject

    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmLoaiTheQuyenLoi;
    //    }

    //    #endregion
    //}

    //[Serializable]
    //public class DmLoaiTheQuyenLoiInfo : TblDmLoaiTheQuyenLoi
    //{
    //    public DmLoaiTheQuyenLoiInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdQuyenLoi { get; set; }
    //    [NullValue(-1)]
    //    [IsKey(false)]//không phải key trong CSDL
    //    public int IdLoaiThe { get; set; }
    //    [NullValue(-1)]
    //    public int IdSanPham { get; set; }
    //    [NullValue(-1)]
    //    public int TyLeGiam { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //}
}

public class DmLoaitheQuyenLoiProvider
{
    public static List<DmLoaiTheQuyenLoiInfo> GetListLoaiTheQuyenLoiInfoFromOid(int oid)
    {
        return DMLoaiTheQuyenLoiDAO.Instance.GetLoaiTheQuyenLoiByIdInfo(oid);
    }

    public static int Insert(DmLoaiTheQuyenLoiInfo dmLoaiTheQLInfo)
    {
        return DMLoaiTheQuyenLoiDAO.Instance.Insert(dmLoaiTheQLInfo);
    }

    public static void Delete(DmLoaiTheQuyenLoiInfo dmLoaiTheQLInfo)
    {
        DMLoaiTheQuyenLoiDAO.Instance.Delete(dmLoaiTheQLInfo);
    }
}
