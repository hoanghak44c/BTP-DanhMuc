using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Providers;

// <Remarks>
// Tạo DMOrderTypeProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 26/03/2012
// Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMTienTe : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmTienTe;
    //    }
    //}
    //[Serializable]
    //public class DMTienTeInfo : TblDMTienTe
    //{
    //    public DMTienTeInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [IsKey(true)]
    //    [NullValue(-1)]
    //    public int IdTienTe { get; set; }
    //    [NullValue("")]
    //    public string KyHieu { get; set; }
    //    [NullValue("")]
    //    public string TenTienTe { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue(-1)]
    //    public float TyGia { get; set; }
    //}
    //public class DMTienTeDataProvider
    //{
    //    public static List<DMTienTeInfo> GetListTienTeInfo()
    //    {
    //        return ProviderBase.SelectAll<DMTienTeInfo>();
    //    }

    //    internal static bool KiemTra(Predicate<DMTienTeInfo>match)
    //    {
    //        return ProviderBase.Exists(match);
    //    }

    //    internal static void Insert(DMTienTeInfo dmTienTeInfo)
    //    {
    //        ProviderBase.Insert(dmTienTeInfo);
    //    }

    //    internal static void Update(DMTienTeInfo dmTienTeInfo)
    //    {
    //        ProviderBase.Update(dmTienTeInfo);
    //    }

    //    internal static void Delete(DMTienTeInfo dmTienTeInfo)
    //    {
    //        ProviderBase.Delete(dmTienTeInfo);
    //    }
    //}
    public class DMTienTeDataProvider : SynchronizableProvider
    {
        private static DMTienTeDataProvider instance;

        private DMTienTeDataProvider()
        {
            controllerDAO = DmTienTeDAO.Instance;
        }

        public static DMTienTeDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMTienTeDataProvider();
                return instance;
            }   
        }
        public static List<DMTienTeInfor> GetListTienTeInfor()
        {
            return DmTienTeDAO.Instance.GetListTienteInfo();
        }

        internal static bool KiemTra(DMTienTeInfor dmTienTeInfor)
        {
            return DmTienTeDAO.Instance.Exist(dmTienTeInfor);
        }

        internal static void Update(DMTienTeInfor dmTienTeInfor)
        {
            DmTienTeDAO.Instance.Update(dmTienTeInfor);
        }

        public static void Delete(DMTienTeInfor dMTienTeInfo)
        {
            DmTienTeDAO.Instance.Delete(dMTienTeInfo);
        }

        internal static void Insert(DMTienTeInfor dMTienTeInfo)
        {
            DmTienTeDAO.Instance.Insert(dMTienTeInfo);
        }

        public static List<DMTienTeInfor> Search(DMTienTeInfor match)
        {
            return DmTienTeDAO.Instance.Search(match);
        }

        public static DMTienTeInfor GetListDmTienTeInfoFromOid(int idTienTe)
        {
            return DmTienTeDAO.Instance.GetTienTeByIdInfo(idTienTe);
        }
    }

}
