using System;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.DAO;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // Tạo DMOrderTypeProvider
    // Người tạo: Bùi Đức Hạnh
    // Ngày tạo : 25/02/2012
    // Người sửa cuối:28/02/2012
    // </remarks>
    //[Serializable]
    //public class TblDMOrderType : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmOrderType;
    //    }
    //}
    //[Serializable]
    //public class DMOrderTypeInfor :TblDMOrderType
    //{
    //    public DMOrderTypeInfor()
    //    {
    //        SetNullValues(this);
    //    }
    //    [IsKey(true)]
    //    [NullValue(-1)]
    //    public int IdOrderType { get; set; }
    //    [NullValue("")]
    //    public string Code { get; set; }
    //    [NullValue("")]
    //    public string Name { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue("")]
    //    public string Line { get; set; }
        //[NullValue("")]
        //public string OrderCk { get; set; }
        //[NullValue("")]
        //public string LineCk { get; set; }
    //}

    //[Serializable]
    //public class DMOrderTypeLoadInfor : TblDMOrderType,ISuDung
    //{
    //    public DMOrderTypeLoadInfor()
    //    {
    //        SetNullValues(this);
    //    }
    //    [IsKey(true)]
    //    [NullValue(-1)]
    //    public int IdOrderType { get; set; }
    //    [NullValue("")]
    //    public string Name { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue("")]
    //    public string Code { get; set; }
        
    //}

    public class DMOrderTypeProvider : SynchronizableProvider
    {
        private static DMOrderTypeProvider instance;

        private DMOrderTypeProvider()
        {
            controllerDAO = DmOrderTypeDAO.Instance;
        }

        public static DMOrderTypeProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMOrderTypeProvider();
                return instance;
            }   
        }
       public static List<DMOrderTypeInfor> GetListOrderTypeInfor()
       {
           return DmOrderTypeDAO.Instance.GetListOrderTypeInfor();
       }

       public static List<DMOrderTypePairInfor> GetListOrderTypepairInfor()
       {
           return DmOrderTypeDAO.Instance.GetListOrderTypePairInfo();
       }
       //public static List<DMOrderTypeLoadInfor> GetCboOrderInfo()
       //{
       //    return DmOrderTypeDAO.Instance.GetListOrderTypePairInfo();
       //}

       internal static bool KiemTra(DMOrderTypeInfor dmOrderTypeInfor)
       {
           return DmOrderTypeDAO.Instance.Exist(dmOrderTypeInfor);
       }
       internal static void Insert(DMOrderTypeInfor dmOrderTypeInfor)
       {
           DmOrderTypeDAO.Instance.Insert(dmOrderTypeInfor);
       }

       internal static void Update(DMOrderTypeInfor dmOrderTypeInfor)
       {
           DmOrderTypeDAO.Instance.Update(dmOrderTypeInfor);
       }

       public static void Delete(DMOrderTypeInfor dmOrderTypeInfor)
       {
           DmOrderTypeDAO.Instance.Delete(dmOrderTypeInfor);
       }
        //public static List<DMOrderTypeInfor>Search(DMOrderTypeInfor infor)
        //{
        //    return DmOrderTypeDAO.Instance.Search(infor.OrderType, infor.Name);
        //}
       public static List<DMOrderTypeInfor> Search(DMOrderTypeInfor match)
       {
           return DmOrderTypeDAO.Instance.Search(match);
       }

       public static DMOrderTypeInfor GetListDmOrderTypeInfoFromOid(int idOrderType)
       {
           return DmOrderTypeDAO.Instance.GetOrderTypeIdInfo(idOrderType);
       }
    }
}
