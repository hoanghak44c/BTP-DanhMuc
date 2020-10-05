using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;
using QLBH.Common;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDmMaVung : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmMaVung;
    //    }
    //}

    //[Serializable]
    //public class MaVungInfo : TblDmMaVung
    //{
    //    public MaVungInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue("")]
    //    public string MaVung { get; set; }
    //    [NullValue("")]
    //    public string TenVung { get; set; }
    //}

    public class MaVungDataProvider
    {
        public static List<MaVungInfo> GetListDMMaVungInfo()
        {
            return DmMaVungDAO.Instance.GetListDMMaVungInfo();
            //return ProviderBase.SelectAll<MaVungInfo>();
        }

        internal static bool KiemTra(Predicate<MaVungInfo> match)
        {
            throw new NotImplementedException();
            //return ProviderBase.Exists(match);
        }

        internal static void Insert(MaVungInfo dmLoaiThuChiInfo)
        {
            throw new NotImplementedException();
            //ProviderBase.Insert(dmLoaiThuChiInfo);
        }

        internal static void Update(MaVungInfo dmLoaiThuChiInfo)
        {
            throw new NotImplementedException();
            //ProviderBase.Update(dmLoaiThuChiInfo);
        }

        internal static void Delete(MaVungInfo dmLoaiThuChiInfo)
        {
            throw new NotImplementedException();
            //ProviderBase.Delete(dmLoaiThuChiInfo);
        }

    }
}
