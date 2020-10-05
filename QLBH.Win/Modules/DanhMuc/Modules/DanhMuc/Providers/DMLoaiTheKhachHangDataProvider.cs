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
    //public class TblDmLoaiTheKhachHang : DataObject
    //{
    //    #region Overrides of DataObject

    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmLoaiTheKhachHang;
    //    }

    //    #endregion
    //}

    //[Serializable]
    //public class DmLoaiTheKhachHangInfo : TblDmLoaiTheKhachHang
    //{
    //    public DmLoaiTheKhachHangInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdLoaiThe { get; set; }
    //    [NullValue("")]
    //    public string MaThe { get; set; }
    //    [NullValue("")]
    //    public string TenThe { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int ThoiGianHieuLuc { get; set ; }
    //    [NullValue(-1)]
    //    public int DoUuTien { get; set; }
    //    [NullValue(-1)]
    //    public int BaoLuuDiem { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue(-1)]
    //    public int DK_GT_LanDau { get; set; }
    //    [NullValue(-1)]
    //    public int DK_GT_TichLuy_Tu { get; set; }
    //    [NullValue(-1)]
    //    public int DK_GT_TichLuy_Den { get; set; }
    //    [NullValue("")]
    //    public string DK_SP_KemTheo { get; set; }
    //    [NullValue(-1)]
    //    public int IsTangQuaSN { get; set; }
    //    [NullValue(-1)]
    //    public int IsBHVang { get; set; }
    //    [NullValue(-1)]
    //    public int IsUpdateSPNew { get; set; }
    //    [NullValue(-1)]
    //    public int IsJointCourse { get; set; }
    //    [NullValue(-1)]
    //    public int IsSupport { get; set; }
    //}
    //}
    //[Serializable]
    //public class DmLoaiTheKhachHangLoadInfo : TblDmLoaiTheKhachHang,ISuDung
    //{
    //    public DmLoaiTheKhachHangLoadInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdLoaiThe { get; set; }
    //    [NullValue("")]
    //    public string MaThe { get; set; }
    //    [NullValue("")]
    //    public string TenThe { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }

    //}

    public class DmLoaitheKhachHangProvider :SynchronizableProvider
    {
        private static DmLoaitheKhachHangProvider instance;

        private DmLoaitheKhachHangProvider()
        {
            controllerDAO = DMLoaiTheKhachHangDAO.Instance;
        }

        public static DmLoaitheKhachHangProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmLoaitheKhachHangProvider();
                return instance;
            }   
        }
        public static List<DMLoaiTheKhachHangLoadInfo> GetListDmLoaiTheInfo()
        {
            return DMLoaiTheKhachHangDAO.Instance.GetListTheInfo();
        }
        public static List<DMLoaiTheKhachHangCBOInfo> GetCboDmLoaiTheInfo()
        {
            return DMLoaiTheKhachHangDAO.Instance.GetListTheCBOInfo();
        }
        public static DMLoaiTheKhachHangInfo GetListDmLoaiTheInfoFromIdLoaiThe(int idloaithe)
        {
            return DMLoaiTheKhachHangDAO.Instance.GetDoiTuongByIdInfo(idloaithe);
        }
        public static List<DMLoaiTheKhachHangInfo> GetListDmLoaiTheInfor()
        {
            return DMLoaiTheKhachHangDAO.Instance.GetListDMTheInfo();
        }
        public static bool KiemTra(DMLoaiTheKhachHangInfo match)
        {
            return DMLoaiTheKhachHangDAO.Instance.Exist(match);
        }

        public static int Insert(DMLoaiTheKhachHangInfo dmLoaiTheKHInfo)
        {
            return DMLoaiTheKhachHangDAO.Instance.Insert(dmLoaiTheKHInfo);
        }

        public static void Update(DMLoaiTheKhachHangInfo dmLoaiTheKHInfo)
        {
            DMLoaiTheKhachHangDAO.Instance.Update(dmLoaiTheKHInfo);
        }

        public static void Delete(DMLoaiTheKhachHangInfo dmLoaiTheKHInfo)
        {
            DMLoaiTheKhachHangDAO.Instance.Delete(dmLoaiTheKHInfo);
        }
        public static List<DMLoaiTheKhachHangInfo> Search(DMLoaiTheKhachHangInfo match)
        {
            return DMLoaiTheKhachHangDAO.Instance.Search(match);
        }

        //internal static List<DmKhachHangInfo> GetListDmNhanVienInfo()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
