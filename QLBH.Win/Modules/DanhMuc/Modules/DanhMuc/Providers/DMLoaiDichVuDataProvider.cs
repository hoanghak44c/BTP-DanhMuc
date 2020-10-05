using System;
using System.Collections.Generic;
using System.Text;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.DAO;

// <Remarks>
// Tạo DMLoaiDichVuProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 03/03/2012
// Người sửa cuối:
// </remarks>
namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMLoaiDichVu : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmLoaiDichVu;
    //    }
    //}
    //[Serializable]
    //public class DMLoaiDichVuInfor :TblDMLoaiDichVu
    //{
    //     public DMLoaiDichVuInfor()
    //    {
    //        SetNullValues(this);
    //    }

    //    [IsKey(true)]
    //    [NullValue(-1)]
    //    public int IdLoaiDichVu { get; set; }

    //    [NullValue("")]
    //    public string MaLoaiDichVu { get; set; }

    //    [NullValue("")]
    //    public string TenDichVu { get; set; }

    //    [NullValue("")]
    //    public string GhiChu { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }

    //}
    public class DMLoaiDichVuDataProvider :SynchronizableProvider
    {
        private static DMLoaiDichVuDataProvider instance;
        private DMLoaiDichVuDataProvider()
        {
            controllerDAO = DmLoaiDichVuDAO.Instance;
        }

        public static DMLoaiDichVuDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMLoaiDichVuDataProvider();
                return instance;
            }   
        }

        public static List<DMLoaiDichVuInfor> GetListDichVuInfo()
        {
            return DmLoaiDichVuDAO.Instance.GetListDichVuInfor();
        }

        internal static void Insert(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            DmLoaiDichVuDAO.Instance.Insert(dmLoaiDichVuInfor);
        }

        internal static void Delete(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            DmLoaiDichVuDAO.Instance.Delete(dmLoaiDichVuInfor);
        }

        internal static void Update(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            DmLoaiDichVuDAO.Instance.Update(dmLoaiDichVuInfor);
        }

        internal static bool Kiemtra(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            return DmLoaiDichVuDAO.Instance.Exist(dmLoaiDichVuInfor);
        }

        internal static List<DMLoaiDichVuInfor> Search(DMLoaiDichVuInfor dmLoaiDichVuInfor)
        {
            return DmLoaiDichVuDAO.Instance.Search(dmLoaiDichVuInfor);
        }
        public static DMLoaiDichVuInfor GetTrungTamByIdInfo(int id)
        {
            return DmLoaiDichVuDAO.Instance.GetLoaiDichVuByIdInfo(id);
        }
    }
}
