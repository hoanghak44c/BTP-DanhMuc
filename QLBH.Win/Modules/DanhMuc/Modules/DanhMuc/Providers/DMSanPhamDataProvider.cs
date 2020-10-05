using System;
using System.Collections.Generic;
using System.Data;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBanHang.Modules.DanhMuc.DAO;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // DMLoaiThuChiDataProvider
    // Người tạo: Trần Tuấn Cường
    // Ngày tạo : 29/02/2012
    //Người sửa cuối:29/02/2012
    // </remarks>
    //[Serializable]
    //public class TblDmSanPham : DataObject
    //{
    //    #region Overrides of DataObject

    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmSanPham;
    //    }

    //    #endregion
    //}

    //[Serializable]
    //public class DmSanPhamInfo : TblDmSanPham
    //{
    //    public DmSanPhamInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdSanPham { get; set; }
    //    [NullValue(-1)]
    //    public int IdCha { get; set; }
    //    [NullValue("")]
    //    public string MaVach { get; set; }
    //    [NullValue("")]
    //    public string MaSanPham { get; set; }
    //    [NullValue("")]
    //    public string TenSanPham { get; set; }
    //    [NullValue(-1)]
    //    public int IdDonViTinh { get; set; }
    //    [NullValue(-1)]
    //    public int GiaNhap { get; set; }
    //    [NullValue("")]
    //    public string MoTa { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue(-1)]
    //    public int TrungMaVach { get; set; }
    //    [NullValue("")]
    //    public string TenVietTat { get; set; }
    //    [NullValue(-1)]
    //    public int ChietKhau { get; set; }
    //}

    //[Serializable]
    //public class DmSanPhamLoadInfo : TblDmSanPham
    //{
    //    public DmSanPhamLoadInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdSanPham { get; set; }
    //    [NullValue(-1)]
    //    public int IdCha { get; set; }
    //    [NullValue("")]
    //    public string MaSanPham { get; set; }
    //    [NullValue("")]
    //    public string TenSanPham { get; set; }
    //    [NullValue(-1)]
    //    public int GiaNhap { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //    [NullValue("")]
    //    public string TenVietTat { get; set; }
    //    [NullValue(-1)]
    //    public int ChietKhau { get; set; }
    //}

    //[Serializable]
    //public class DmSanPhamCboInfo : TblDmSanPham,ISuDung
    //{
    //    public DmSanPhamCboInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdSanPham { get; set; }
    //    [NullValue(-1)]
    //    public string TenSanPham { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}
    
    public class DmSanPhamProvider : SynchronizableProvider, IDataPageRetriever<DMSanPhamInfo>
    {
        private static DmSanPhamProvider instance;

        private DmSanPhamProvider()
        {
            controllerDAO = DMSanPhamDAO.Instance;
        }

        public static DmSanPhamProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmSanPhamProvider();
                return instance;
            }   
        }

        public static List<DMSanPhamInfo> GetListDmSanPhamInfo()
        {
            return DMSanPhamDAO.Instance.GetListSanPhamInfo();
        }

        public static List<DMSanPhamInfo> GetListDmSanPhamCauHinhInfo()
        {
            return DMSanPhamDAO.Instance.GetListSanPhamCauHinhInfo();
        }

        public static List<DMSanPhamInfo> GetListDmSanPhamInfo(int idKho, int idTrungTam, bool exists, bool isTonAo)
        {
            return DMSanPhamDAO.Instance.GetListSanPhamInfo(idKho, idTrungTam, exists, isTonAo);
        }

        public static List<DMSanPhamPairInfo> GetCboDmSanPhamInfo()
        {
            return DMSanPhamDAO.Instance.GetListSanPhamCBOInfo();
        }

        public static DMSanPhamInfo GetSanPhamById(int oid)
        {
            return DMSanPhamDAO.Instance.GetSanPhamInfoById(oid);
        }

        public static bool KiemTra(DMSanPhamInfo match)
        {
            return DMSanPhamDAO.Instance.Exist(match);
        }

        public DMSanPhamInfo GetSanPhamByMa(string maSanPham)
        {
            return DMSanPhamDAO.Instance.GetSanPhamByMa(maSanPham);
        }

        public static List<DMSanPhamInfo> Search(DMSanPhamInfo match)
        {
            return DMSanPhamDAO.Instance.Search(match);
        }

        internal static void Insert(DMSanPhamInfo dmSanPhamInfo)
        {
            DMSanPhamDAO.Instance.Insert(dmSanPhamInfo);
        }

        internal static void Update(DMSanPhamInfo dmSanPhamInfo)
        {
            DMSanPhamDAO.Instance.Update(dmSanPhamInfo);
        }

        public static void Delete(DMSanPhamInfo dmSanPhamInfo)
        {
            DMSanPhamDAO.Instance.Delete(dmSanPhamInfo);
        }

        public static List<DMSanPhamBriefInfo> GetListSanPhamBrief(int suDung, int chietKhau)
        {
            return DMSanPhamDAO.Instance.GetListSanPhamBrief(suDung, chietKhau);
        }
        public static List<DMSanPhamBriefInfo> GetListSanPhamBrief(int idNguoiDung, int suDung, int chietKhau)
        {
            return DMSanPhamDAO.Instance.GetListSanPhamBrief(idNguoiDung, suDung, chietKhau);
        }
        public static List<DMSanPhamBriefInfo> GetListSanPhamTonBrief(int idNguoiDung, int suDung, int chietKhau, int idKho, int tonAll)
        {
            return DMSanPhamDAO.Instance.GetListSanPhamTonBrief(idNguoiDung, suDung, chietKhau, idKho, tonAll);
        }
        public static DMSanPhamBriefInfo GetSanPhamBriefByMa(string maSanPham)
        {
            return DMSanPhamDAO.Instance.GetSanPhamBriefByMa(maSanPham);
        }
        public static DMSanPhamBriefInfo GetSanPhamBriefByNSDMa(string maSanPham, int idNhomNguoiDung)
        {
            return DMSanPhamDAO.Instance.GetSanPhamBriefByNSDMa(maSanPham, idNhomNguoiDung);
        }
        public List<ItemTonKhoInfor> LoadTonKhoTheoTrungTam(int idSanPham)
        {
            return DMSanPhamDAO.Instance.LoadTonKhoTheoTrungTam(idSanPham);
        }
        public static DMSanPhamInfo GetSanPhamByText(string sanpham)
        {
            return DMSanPhamDAO.Instance.GetSanPhamByText(sanpham);
        }
        #region Implementation of IDataPageRetriever

        public List<DMSanPhamInfo> SupplyPageOfData(string conditonLookUp, int lowerPageBoundary, int rowsPerPage)
        {
            return DMSanPhamDAO.Instance.SupplyPageOfData(conditonLookUp, lowerPageBoundary, rowsPerPage);
        }

        #endregion

        public List<DMSanPhamInfo> GetListDmSanPhamInfoUsing()
        {
            return DMSanPhamDAO.Instance.GetListDmSanPhamInfoUsing();
        }
    }
}