using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.DAO;

// <Remarks>
// Tạo DMLoaiItemProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 05/03/2012
// Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMLoaiItem : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmLoaiItem;
    //    }
    //}

    //[Serializable]
    //public class DMLoaiItemInfor: TblDMLoaiItem
    //{
    //     public DMLoaiItemInfor()
    //    {
    //        SetNullValues(this);
    //    }

    //     [NullValue(-1), IsKey(true)]
    //     public int IdLoaiItem { get; set; }

    //     [NullValue("")]
    //     public string MaLoaiItem { get; set; }

    //     [NullValue("")]
    //     public string TenLoaiItem { get; set; }

    //     [NullValue("")]
    //     public string GhiChu { get; set; }

    //     [NullValue(-1)]
    //     public int SuDung { get; set; }
    //}
   public class DMLoaiItemDataProvider : SynchronizableProvider
   {
        private static DMLoaiItemDataProvider instance;
        private DMLoaiItemDataProvider()
        {
            controllerDAO = DmLoaiItemDAO.Instance;
        }

        public static DMLoaiItemDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiItemDataProvider();
                return instance;
            }   
        }

       public static List<DMLoaiItemInfor> GetListItemInfor()
       {
           return DmLoaiItemDAO.Instance.GetListItemInfor();
       }

       internal static void Insert(DMLoaiItemInfor dmLoaiItemInfor)
       {
            DmLoaiItemDAO.Instance.Insert(dmLoaiItemInfor);
       }

       public static void Delete(DMLoaiItemInfor dmLoaiItemInfor)
       {
           DmLoaiItemDAO.Instance.Delete(dmLoaiItemInfor);
       }

       internal static void Update(DMLoaiItemInfor dmLoaiItemInfor)
       {
           DmLoaiItemDAO.Instance.Update(dmLoaiItemInfor);
       }

       public static List<DMLoaiItemInfor> Search(DMLoaiItemInfor dmLoaiItemInfor)
       {
           return DmLoaiItemDAO.Instance.Search(dmLoaiItemInfor);
       }

       public static bool Kiemtra(DMLoaiItemInfor dmLoaiItemInfor)
       {
           return DmLoaiItemDAO.Instance.Exist(dmLoaiItemInfor);
       }
       public static DMLoaiItemInfor GetLoaiItemByIdInfo(int id)
       {
           return DmLoaiItemDAO.Instance.GetTrungTamByIdInfo(id);
       }
   }
}
