using System;
using System.Collections.Generic;
using QLBanHang.Modules.DanhMuc.DAO;
using QLBH.Core.Data;
using QLBH.Common;
using QLBanHang.Modules.DanhMuc.Infors;

namespace QLBanHang.Modules.DanhMuc.Providers
{
    // <Remarks>
    // DMLoaiThuChiDataProvider
    // Người tạo: Trần Tuấn Cường
    // Ngày tạo : 29/02/2012
    //Người sửa cuối:29/02/2012
    // </remarks>
    //[Serializable]
    //public class TblDmDonViTinh : DataObject
    //{
    //    #region Overrides of DataObject

    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmDonViTinh;
    //    }

    //    #endregion
    //}

    //[Serializable]
    //public class DmDonViTinhInfo : TblDmDonViTinh
    //{
    //    public DmDonViTinhInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdDonViTinh { get; set; }
    //    [NullValue("")]
    //    public string KyHieu { get; set; }
    //    [NullValue("")]
    //    public string TenDonViTinh { get; set; }
    //    [NullValue("")]
    //    public string GhiChu { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}
    //[Serializable]
    //public class DmDonViTinhLoadInfo : TblDmDonViTinh,ISuDung
    //{
    //    public DmDonViTinhLoadInfo()
    //    {
    //        SetNullValues(this);
    //    }
    //    [NullValue(-1)]
    //    [IsKey(true)]
    //    public int IdDonViTinh { get; set; }
    //    [NullValue("")]
    //    public string TenDonViTinh { get; set; }
    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}

    public class DmDonViTinhProvider : SynchronizableProvider, IDanhMucEditInfor<DMDonViTinhInfor>
    {
        private static DmDonViTinhProvider instance;
        private DmDonViTinhProvider()
        {
            controllerDAO = DmDonViTinhDAO.Instance;
        }

        public static DmDonViTinhProvider Instance
        {
            get
            {
                if (instance == null) instance = new DmDonViTinhProvider();
                return instance;
            }   
        }

        public List<DMDonViTinhInfor> GetListDonViTinhInfo()
        {
            return DmDonViTinhDAO.Instance.GetListDonViTinhInfo();
        }
        public List<DMDonViTinhLoadInfor> GetCboDonViTinhInfo()
        {
            return DmDonViTinhDAO.Instance.GetListDonViTinhLoadInfo();
        }

        public bool IsExisted(DMDonViTinhInfor dmDonViTinhInfor)
        {
            return DmDonViTinhDAO.Instance.Exist(dmDonViTinhInfor);
        }

        public int Insert(DMDonViTinhInfor dmDonViTinhInfor)
        {
            return DmDonViTinhDAO.Instance.Insert(dmDonViTinhInfor);
        }

        public void Update(DMDonViTinhInfor dmDonViTinhInfor)
        {
            DmDonViTinhDAO.Instance.Update(dmDonViTinhInfor);
        }

        public void Delete(DMDonViTinhInfor dmDonViTinhInfor)
        {
            DmDonViTinhDAO.Instance.Delete(dmDonViTinhInfor);
        }

        public List<DMDonViTinhInfor> Search(DMDonViTinhInfor match)
        {
            return DmDonViTinhDAO.Instance.Search(match);
        }

        public DMDonViTinhInfor GetFullInfoByKey(params object [] keyParams)
        {
            return DmDonViTinhDAO.Instance.GetDonViTinhByIdInfo(Convert.ToInt32(keyParams[0]));
        }

        public bool IsUsed(DMDonViTinhInfor checkInfo)
        {
            return DmDonViTinhDAO.Instance.IsUsed(checkInfo.IdDonViTinh);
        }
    }
}