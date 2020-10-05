using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
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
    //public class TblDmPhongBan : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmPhongBan;
    //    }
    //}

    /// <summary>
    /// Info này dùng cho việc khai báo danh mục
    /// </summary>
    //[Serializable]
    //public class DMPhongBanInfo : TblDmPhongBan
    //{
    //    public DMPhongBanInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdPhongBan { get; set; }
    //    [NullValue("")]
    //    public string MaPhongBan { get; set; }
    //    [NullValue("")]
    //    public string TenPhongBan { get; set; }

    //    [NullValue("")]
    //    public string GhiChu { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}

    //note: @All chú ý cách implement ISuDung để có thể lọc những dữ liệu được phép sử dụng
    /// <summary>
    /// Info này dùng cho việc fill vào các control như combobox, listbox
    /// </summary>
    //[Serializable]
    //public class DMPhongBanPairInfo : TblDmPhongBan, ISuDung
    //{
    //    public DMPhongBanPairInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdPhongBan { get; set; }
    //    [NullValue("")]
    //    public string TenPhongBan { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}


    public class DMPhongBanDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMPhongBanInfor>
    {
        private static DMPhongBanDataProvider instance;

        private DMPhongBanDataProvider()
        {
            controllerDAO = DmPhongBanDAO.Instance;
        }

        public static DMPhongBanDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMPhongBanDataProvider();
                return instance;
            }   
        }
        /// <summary>
        /// Dùng để fill grid
        /// </summary>
        /// <returns></returns>
        public List<DMPhongBanInfor> GetListPhongBanInfor()
        {
            return DmPhongBanDAO.Instance.GetListPhongBanInfor();
        }
        public List<DMPhongBanInfor> GetListActivedPhongBanInfor()
        {
            return DmPhongBanDAO.Instance.GetListActivedPhongBanInfor();
        }

        /// <summary>
        /// Dùng để fill combobox, listbox
        /// </summary>
        /// <returns></returns>
        public List<DMPhongBanPairInfor> GetListPhongBanPairInfo()
        {
            return DmPhongBanDAO.Instance.GetListPhongBanPairInfo();
        }

        public bool IsExisted(DMPhongBanInfor dmPhongBanInfor)
        {
            return DmPhongBanDAO.Instance.Exist(dmPhongBanInfor);
        }
        
        public bool IsUsed(DMPhongBanInfor checkInfo)
        {
            return false;
        }

        public DMPhongBanInfor GetFullInfoByKey(params object[] keyParams)
        {
            return DmPhongBanDAO.Instance.GetPhongBanByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public int Insert(DMPhongBanInfor dmPhongBanInfor)
        {
            return DmPhongBanDAO.Instance.Insert(dmPhongBanInfor);
        }

        public void Update(DMPhongBanInfor dmPhongBanInfor)
        {
            DmPhongBanDAO.Instance.Update(dmPhongBanInfor);
        }

        public void Delete(DMPhongBanInfor dmPhongBanInfor)
        {
            DmPhongBanDAO.Instance.Delete(dmPhongBanInfor);
        }

        public List<DMPhongBanInfor> Search(DMPhongBanInfor dmMaLoiInfor)
        {
            return DmPhongBanDAO.Instance.Search(dmMaLoiInfor);
        }
    }
}
