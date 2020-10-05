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
    //public class TblDmLoaiTheUuDai : DataObject
    //{
    //    #region Overrides of DataObject

    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmLoaiTheUuDai;
    //    }

    //    #endregion
    //}

    //[Serializable]
    //public class DmLoaiTheUuDaiInfo : TblDmLoaiTheUuDai
    //{
    //    public DmLoaiTheUuDaiInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdUuDai { get; set; }
    //    [NullValue(-1)]
    //    [IsKey(false)]//không phải key trong CSDL
    //    public int IdLoaiThe { get; set; }
    //    [NullValue("")]
    //    public string DichVu { get; set; }
    //    [NullValue("")]
    //    public string UuDai { get; set; }

    //}
}

public class DmLoaitheUuDaiProvider
{
    public static List<DmLoaiTheUuDaiInfo> GetListDmLoaiTheUuDaiInfoFromOid(int oid)
    {
        return DMLoaiTheUuDaiDAO.Instance.GetLoaiTheQuyenLoiByIdInfo(oid);
    }

    public static int Insert(DmLoaiTheUuDaiInfo dmLoaiTheUDInfo)
    {
        return DMLoaiTheUuDaiDAO.Instance.Insert(dmLoaiTheUDInfo);
    }

    public static void Delete(DmLoaiTheUuDaiInfo dmLoaiTheUDInfo)
    {
        DMLoaiTheUuDaiDAO.Instance.Delete(dmLoaiTheUDInfo);
    }
}
