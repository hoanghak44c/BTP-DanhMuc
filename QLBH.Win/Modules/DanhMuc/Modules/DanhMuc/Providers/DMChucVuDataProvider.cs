using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.DAO;

//todo:@HanhBD DMChucVuDataProvider
namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // DMLoaiThuChiDataProvider
    // Người tạo: Trần Tuấn Cường
    // Ngày tạo : 29/02/2012
    //Người sửa cuối:29/02/2012
    // </remarks>
    //[Serializable]
    //public class TblDmChucVu : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmChucVu;
    //    }
    //}
    //[Serializable]
    //public class DMChucVuInfo : TblDmChucVu
    //{
    //    public DMChucVuInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdChucVu { get; set; }
    //    [NullValue("")]
    //    public string MaChucVu { get; set; }
    //    [NullValue("")]
    //    public string TenChucVu { get; set; }

    //    [NullValue("")]
    //    public string GhiChu { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}

    //[Serializable]
    //public class DMChucVuPairInfo : TblDmChucVu, ISuDung
    //{
    //    public DMChucVuPairInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdChucVu { get; set; }
    //    [NullValue("")]
    //    public string TenChucVu { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}
    public interface IDanhMucEditInfor<T>
    {
        T GetFullInfoByKey(params object[] keyParams);
        int Insert(T insertInfo);
        void Update(T updateInfo);
        void Delete(T deleteInfo);
        bool IsExisted(T checkInfo);
        bool IsUsed(T checkInfo);
    }

    public class DMChucVuDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMChucVuInfor>
    {
        private static DMChucVuDataProvider instance;
        private DMChucVuDataProvider()
        {
            controllerDAO = DmChucVuDAO.Instance;
        }

        public static DMChucVuDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMChucVuDataProvider();
                return instance;
            }   
        }

        /// <summary>
        /// Dùng để fill grid
        /// </summary>
        /// <returns></returns>
        public static List<DMChucVuInfor> GetListChucVuInfor()
        {
            return DmChucVuDAO.Instance.GetListChucVuInfo();
        }

        /// <summary>
        /// Dùng để fill combobox, listbox
        /// </summary>
        /// <returns></returns>
        public static List<DMChucVuPairInfor> GetListChucVuPairInfo()
        {
            return DmChucVuDAO.Instance.GetListChucVuPairInfo();
        }
        /// <summary>
        /// Cho biết đã tồn tại trong bảng chức vụ hay chưa
        /// </summary>
        public bool IsExisted(DMChucVuInfor dmChucVuInfor)
        {
            return DmChucVuDAO.Instance.Exist(dmChucVuInfor);
        }
        /// <summary>
        /// Cho biết đã được sử dụng trong các bảng khác hay chưa
        /// </summary>
        public bool IsUsed(DMChucVuInfor dmChucVuInfor)
        {
            return false;
        }

        public int Insert(DMChucVuInfor dmChucVuInfor)
        {
            return DmChucVuDAO.Instance.Insert(dmChucVuInfor);
        }

        public void Update(DMChucVuInfor dmChucVuInfor)
        {
            DmChucVuDAO.Instance.Update(dmChucVuInfor);
        }

        public void Delete(DMChucVuInfor dmChucVuInfor)
        {
            DmChucVuDAO.Instance.Delete(dmChucVuInfor);
        }

        public static List<DMChucVuInfor> Search(DMChucVuInfor match)
        {
            return DmChucVuDAO.Instance.Search(match);
        }

        public DMChucVuInfor GetFullInfoByKey(params object[] keyParams)
        {
            return DmChucVuDAO.Instance.GetChucVuByIdInfo(Convert.ToInt32(keyParams[0]));
        }

    }
}
