using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.DAO;

// <Remarks>
// Tạo DMMaLoiProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 01/03/2012
// Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMMaLoi : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmMaLoi;
    //    }
    //}
    //[Serializable]
    //public class DMMaLoiInfor :TblDMMaLoi
    //{
    //    public DMMaLoiInfor()
    //    {
    //        SetNullValues(this);
    //    }

    //    [NullValue(-1), IsKey(true)]
    //    public int IdMaLoi { get; set; }

    //    [NullValue("")]
    //    public string MaLoi { get; set; }

    //    [NullValue(-1)]
    //    public int IdLoaiItem { get; set; }

    //    [NullValue("")]
    //    public string TenLoi { get; set; }

    //    [NullValue("")]
    //    public string GhiChu { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}
    public class DMMaLoiDataProvider
    {
        public static List<DMMaLoiPairInfor> GetListMaLoiPairInfor()
        {
            return DmMaLoiDAO.Instance.GetListMaLoiPairInfor();
        }
        public static List<DMMaLoiInfor> GetListMaLoiInfor()
        {
            return DmMaLoiDAO.Instance.GetListMaLoiInfor();
        }

        public static int Insert(DMMaLoiInfor dmMaLoiInfor)
        {
            return DmMaLoiDAO.Instance.Insert(dmMaLoiInfor);
        }

        public static void Delete(DMMaLoiInfor dmMaLoiInfor)
        {
            DmMaLoiDAO.Instance.Delete(dmMaLoiInfor);
        }

        public static void Update(DMMaLoiInfor dmMaLoiInfor)
        {
            DmMaLoiDAO.Instance.Update(dmMaLoiInfor);
        }

        internal static bool Kiemtra(DMMaLoiInfor dmMaLoiInfor)
        {
            return DmMaLoiDAO.Instance.Exist(dmMaLoiInfor);
        }

        public static List<DMMaLoiPairInfor> Search(DMMaLoiPairInfor dmMaLoiInfor)
        {
            return DmMaLoiDAO.Instance.Search(dmMaLoiInfor);
        }
        public static DMMaLoiInfor GetLoaiItemByIdInfo(int id)
        {
            return DmMaLoiDAO.Instance.GetMaLoiByIdInfo(id);
        }
    }
}
