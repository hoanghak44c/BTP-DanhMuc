using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.DAO;

// <Remarks>
// Tạo DMOrderTypeProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 29/02/2012
// Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMQuyenHoaDon : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmQuyenHoaDon;
    //    }
    //}
    //[Serializable]
    //public class DMQuyenHoaDonInfo : TblDMQuyenHoaDon
    //{
    //    public DMQuyenHoaDonInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(""), IsKey(false)]
    //    public string KyHieuHoaDon { get; set; }

    //    [NullValue(""), IsKey(false)]
    //    public string KyTuDauSerie { get; set; }

    //    [NullValue(-1)]
    //    public int SoLuong { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}
   public class DMQuyenHoaDonDataProvider :SynchronizableProvider
    {
        private static DMQuyenHoaDonDataProvider instance;

        private DMQuyenHoaDonDataProvider()
        {
            controllerDAO = DmQuyenHoaDonDAO.Instance;
        }

        public static DMQuyenHoaDonDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMQuyenHoaDonDataProvider();
                return instance;
            }   
        }
       public static List<DMQuyenHoaDonInfor> GetListQuyenHoaDonInfor()
       {
           return DmQuyenHoaDonDAO.Instance.GetListQuyenHoaDonInfor();
       }

       public static List<DMQuyenHoaDonInfor> GetListQuyenHoaDonEmptyInfor()
       {
           return DmQuyenHoaDonDAO.Instance.GetListQuyenHoaDonEmptyInfor();
       }

       public static List<DMQuyenHoaDonInfor> Search(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
       {
           return DmQuyenHoaDonDAO.Instance.Search(dmQuyenHoaDonInfor);
       }

       internal static void Insert(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
       {
           DmQuyenHoaDonDAO.Instance.Insert(dmQuyenHoaDonInfor);
       }

       public static void Delete(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
       {
           DmQuyenHoaDonDAO.Instance.Delete(dmQuyenHoaDonInfor);
       }

       internal static void Update(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
       {
           DmQuyenHoaDonDAO.Instance.Update(dmQuyenHoaDonInfor);
       }

       internal static bool Kiemtra(DMQuyenHoaDonInfor dmQuyenHoaDonInfor)
       {
           return DmQuyenHoaDonDAO.Instance.Exist(dmQuyenHoaDonInfor);
       }
       public static DMQuyenHoaDonInfor GetHoaDonInfo(string kytudau,string kyhieuhoadon)
       {
           return DmQuyenHoaDonDAO.Instance.GetHoaDonInfo(kytudau,kyhieuhoadon);
       }
    }
}
