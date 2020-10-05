using System;
using System.Collections.Generic;
using System.Text;
using QLBanHang.Modules.DanhMuc.Infors;
using QLBH.Common;
using QLBH.Core.Data;
using QLBanHang.Modules.DanhMuc.DAO;

// <Remarks>
// Tạo DMChucNangProvider
// Người tạo: Bùi Đức Hạnh
// Ngày tạo : 07/03/2012
// Người sửa cuối:
// </remarks>

namespace QLBanHang.Modules.DanhMuc.Providers
{
    //[Serializable]
    //public class TblDMChucNang : DataObject
    //{
    //    public override string GetDataObjectName()
    //    {
    //        return Declare.TableNamespace.DmChucNang;
    //    }
    //}

    //[Serializable]
    //public class DMChucNangInfor : TblDMChucNang
    //{
    //    public DMChucNangInfor()
    //    {
    //        SetNullValues(this);
    //    }

    //    [IsKey(true)]
    //    [NullValue(-1)]
    //    public int IdChucNang { get; set; }

    //    [NullValue("")]
    //    public string MaChucNang { get; set; }

    //    [NullValue("")]
    //    public string TenChucNang { get; set; }

    //    [NullValue("")]
    //    public string GhiChu { get; set; }

    //    [NullValue(-1)]
    //    public int SuDung { get; set; }
    //}
    public class DMChucNangDataProvider : SynchronizableProvider, IDanhMucEditInfor<DMChucNangInfor>
    {
        private static DMChucNangDataProvider instance;
        private DMChucNangDataProvider()
        {
            controllerDAO = DmChucNangDAO.Instance;
        }

        public static DMChucNangDataProvider Instance
        {
            get
            {
                if (instance == null) instance = new DMChucNangDataProvider();
                return instance;
            }   
        }

        public List<DMChucNangInfor> GetChucNangInfor()
        {
           return DmChucNangDAO.Instance.GetListChucNangInfo();
        }
    
        public int Insert(DMChucNangInfor dmChucNangInfor)
        {
            return DmChucNangDAO.Instance.Insert(dmChucNangInfor);
        }

        public void Delete(DMChucNangInfor dmChucNangInfor)
        {
            DmChucNangDAO.Instance.Delete(dmChucNangInfor);
        }
    
        public void Update(DMChucNangInfor dmChucNangInfor)
        {
            DmChucNangDAO.Instance.Update(dmChucNangInfor);
        }

        public bool IsExisted(DMChucNangInfor dmChucNangInfor)
        {
            return DmChucNangDAO.Instance.Exist(dmChucNangInfor);
        }

        public bool IsUsed(DMChucNangInfor checkInfo)
        {
            return false;
        }

        public List<DMChucNangInfor> Search(DMChucNangInfor match)
        {
            return DmChucNangDAO.Instance.Search(match);
        }

        public DMChucNangInfor GetFullInfoByKey(params object[] keyParams)
        {
            return DmChucNangDAO.Instance.GetChucNangByIdInfo(Convert.ToInt32(keyParams[0]));
        }
    }
}
