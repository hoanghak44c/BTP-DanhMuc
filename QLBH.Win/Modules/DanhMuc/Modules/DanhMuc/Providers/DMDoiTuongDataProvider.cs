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
    //public class TblDmDoiTuong : DataObject
    //{
    //    #region Overrides of DataObject

    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmDoiTuong;
    //    }

    //    #endregion
    //}

    //[Serializable]
    //public class DmKhachHangInfo : TblDmDoiTuong
    //{
    //    public DmKhachHangInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1), IsKey(true)]
    //    public int IdDoiTuong { get; set; }
    //    [NullValue(-1)]
    //    public int IdCha { get; set; }
    //    [NullValue("")]
    //    public string MaDoiTuong { get; set; }
    //    [NullValue("")]
    //    public string TenDoiTuong { get; set; }
    //    [NullValue("")]
    //    public string NguoiLienLac { get; set; }
    //    [NullValue("")]
    //    public string DiaChi { get; set; }
    //    [NullValue("")]
    //    public string DienThoai { get; set; }
    //    [NullValue("")]
    //    public string Fax { get; set; }
    //    [NullValue("")]
    //    public string Email { get; set; }
    //    [NullValue("")]
    //    public string MaSoThue { get; set; }
    //    /// <summary>
    //    /// Type: Khách hàng = 0, Đại lý = 1, Đối tác = 2
    //    /// </summary>
    //    [NullValue(-1)]
    //    public int Type { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int GioiTinh { get; set; }
    //    [NullValue(typeof(DateTime), Declare.DateMinValue)]
    //    public DateTime NgaySinh { get; set; }
    //    [NullValue(-1)]
    //    public int IdOrderType { get; set; }
    //}

    //[Serializable]
    //public class DmKhachHangLoadInfo : TblDmDoiTuong,ISuDung
    //{
    //    public DmKhachHangLoadInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1), IsKey(true)]
    //    public int IdDoiTuong { get; set; }
    //    [NullValue("")]
    //    public string TenDoiTuong { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
        
    //}
   
    public class DmDoiTuongProvider :SynchronizableProvider
    {
        private static DmDoiTuongProvider instance;
        private DmDoiTuongProvider()
        {
            controllerDAO = DMDoiTuongDAO.Instance;
        }

        public static DmDoiTuongProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmDoiTuongProvider();
                return instance;
            }   
        }

        public static List<DMDoiTuongInfo> GetListDmDoiTuongInfo()
        {
            return DMDoiTuongDAO.Instance.GetListDoiTuongInfo();
        }

        public static List<DMDoiTuongInfo> GetListDmDoiTuongInfoEx()
        {
            return DMDoiTuongDAO.Instance.GetListDoiTuongInfoEx();
        }

        public static List<DMDoiTuongInfo> GetListDmDoiTuongKhachHang()
        {
            return DMDoiTuongDAO.Instance.GetListDoiTuongInfoByType(1);
        }

        public static List<DMDoiTuongInfo> GetListDoiTuongKLInfo(int idDTCha)
        {
            return DMDoiTuongDAO.Instance.GetListDoiTuongKLInfo(idDTCha);
        }

        public static DMDoiTuongInfo GetListDoiTuongKLInfoByCode(int idDTCha, string code)
        {
            return DMDoiTuongDAO.Instance.GetListDoiTuongKLInfoByCode(idDTCha, code);
        }

        public static DMDoiTuongInfo GetDoiTuongInfoByCode(string code)
        {
            return DMDoiTuongDAO.Instance.GetDoiTuongByCode(code);
        }

        public static DMDoiTuongInfo GetDoiTuongInfoBySoPO(string soPO)
        {
            return DMDoiTuongDAO.Instance.GetDoiTuongInfoBySoPO(soPO);
        }

        public static List<DMDoiTuongInfo> GetListDmDoiTuongNCC()
        {
            return DMDoiTuongDAO.Instance.GetListDoiTuongInfoByType(2);
        }

        public static List<DMDoiTuongInfo> GetListDmDoiTuongDTacGVan()
        {
            return DMDoiTuongDAO.Instance.GetListDmDoiTuongDTacGVan();
        }

        public static List<DMDoiTuongPairInfo> GetCboDmDoiTuongInfo()
        {
            return DMDoiTuongDAO.Instance.GetListDoiTuongCBOInfo();
        }

        public static DMDoiTuongInfo GetDmDoiTuongInfoFromOid(int oid)
        {
            return DMDoiTuongDAO.Instance.GetDoiTuongByIdInfo(oid);
        }

        internal static bool KiemTra(DMDoiTuongInfo match)
        {
            return DMDoiTuongDAO.Instance.Exist(match);
        }

        public static bool KiemTraLe(DMDoiTuongInfo match)
        {
            return DMDoiTuongDAO.Instance.ExistLe(match);
        }

        internal static int Insert(DMDoiTuongInfo dmDoiTuongInfo)
        {
            return DMDoiTuongDAO.Instance.Insert(dmDoiTuongInfo);
        }

        internal static void Update(DMDoiTuongInfo dmDoiTuongInfo)
        {
            DMDoiTuongDAO.Instance.Update(dmDoiTuongInfo);
        }

        public static void Delete(DMDoiTuongInfo dmDoiTuongInfo)
        {
            DMDoiTuongDAO.Instance.Delete(dmDoiTuongInfo);
        }

        public static List<DMDoiTuongInfo> Search(DMDoiTuongInfo match)
        {
            return DMDoiTuongDAO.Instance.Search(match);
        }

        public static List<DMDoiTuongInfo> SearchRieng(DMDoiTuongInfo match)
        {
            return DMDoiTuongDAO.Instance.SearchRieng(match);
        }

        public static List<DMDoiTuongPairInfo> GetCboDmDoiTuongByLoaiDT(int loaiDT)
        {
            return DMDoiTuongDAO.Instance.GetCboDmDoiTuongByLoaiDT(loaiDT);
        }
        public static List<DMDoiTuongInfo> GetDmDoiTuongByLoaiDT(int loaiDT)
        {
            return DMDoiTuongDAO.Instance.GetDmDoiTuongByLoaiDT(loaiDT);
        }
        public DMDoiTuongInfo GetDmDoiTuongByLoaiDT_Code(int loaiDT, string code)
        {
            return DMDoiTuongDAO.Instance.GetDmDoiTuongByLoaiDT_Code(loaiDT, code);
        }
        public DMDoiTuongInfo GetDoiTuongByText(string doituong)
        {
            return DMDoiTuongDAO.Instance.GetDoiTuongByText(doituong);
        }
        public DMDoiTuongInfo GetDoiTuongKLByText(string doituong)
        {
            return DMDoiTuongDAO.Instance.GetDoiTuongKLByText(doituong);
        }
    }
}
