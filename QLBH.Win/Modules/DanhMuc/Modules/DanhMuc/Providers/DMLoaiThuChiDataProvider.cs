using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.DAO;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // DMLoaiThuChiDataProvider
    // Người tạo: Bùi Đức Hạnh
    // Ngày tạo : 24/02/2012
    //Người sửa cuối:27/02/2012
    // </remarks>
    //[Serializable]
    //public class TblDmLoaiThuChi : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmLoaiThuChi;
    //    }
    //}
    //[Serializable]
    //public class DMLoaiThuChiInfo :TblDmLoaiThuChi
    //{
    //    public DMLoaiThuChiInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdThuChi { get; set; }
    //    [NullValue("")]
    //    public string KyHieu { get; set; }
    //    [NullValue("")]
    //    public string Ten { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int Type { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}
   public class DMLoaiThuChiDataProvider :SynchronizableProvider
    {
        private static DMLoaiThuChiDataProvider instance;

        private DMLoaiThuChiDataProvider()
        {
            controllerDAO = DmLoaiThuChiDAO.Instance;
        }

        public static DMLoaiThuChiDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiThuChiDataProvider();
                return instance;
            }   
        }
       public static List<DMLoaiThuChiInfor> GetListLoaiThuChiInfor()
       {
           return DmLoaiThuChiDAO.Instance.GetListLoaiThuChiInfor();
       }

       internal static bool KiemTra(DMLoaiThuChiInfor dmLoaiThuChiInfo)
       {
           return DmLoaiThuChiDAO.Instance.Exist(dmLoaiThuChiInfo);
       }

       internal static void Insert(DMLoaiThuChiInfor dmLoaiThuChiInfo)
       {
           DmLoaiThuChiDAO.Instance.Insert(dmLoaiThuChiInfo);
       }

       internal static void Update(DMLoaiThuChiInfor dmLoaiThuChiInfo)
       {
           DmLoaiThuChiDAO.Instance.Update(dmLoaiThuChiInfo);
       }

       public static void Delete(DMLoaiThuChiInfor dmLoaiThuChiInfo)
       {
           DmLoaiThuChiDAO.Instance.Delete(dmLoaiThuChiInfo);
       }

       public static List<DMLoaiThuChiInfor> Search(DMLoaiThuChiInfor match)
       {
           return DmLoaiThuChiDAO.Instance.Search(match);
       }

       public static DMLoaiThuChiInfor GetListDmThuChiInfoFromOid(int IdThuChi)
       {
           return DmLoaiThuChiDAO.Instance.GetDoiTuongByIdInfo(IdThuChi);
       }
       public static DMLoaiThuChiInfor GetDmThuChiInfoByText(string thuchi)
       {
           return DmLoaiThuChiDAO.Instance.GetDmThuChiInfoByText(thuchi);
       }
    }
}
